using System;
using System.Collections;
using System.Globalization;
using System.IO;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Text;

namespace System.Net
{
	// Token: 0x0200011F RID: 287
	internal class FtpControlStream : CommandStream
	{
		// Token: 0x17000161 RID: 353
		// (get) Token: 0x06000825 RID: 2085 RVA: 0x0002D8DD File Offset: 0x0002BADD
		// (set) Token: 0x06000826 RID: 2086 RVA: 0x0002D906 File Offset: 0x0002BB06
		internal NetworkCredential Credentials
		{
			get
			{
				if (this._credentials != null && this._credentials.IsAlive)
				{
					return (NetworkCredential)this._credentials.Target;
				}
				return null;
			}
			set
			{
				if (this._credentials == null)
				{
					this._credentials = new WeakReference(null);
				}
				this._credentials.Target = value;
			}
		}

		// Token: 0x06000827 RID: 2087 RVA: 0x0002D928 File Offset: 0x0002BB28
		internal FtpControlStream(TcpClient client) : base(client)
		{
		}

		// Token: 0x06000828 RID: 2088 RVA: 0x0002D944 File Offset: 0x0002BB44
		internal void AbortConnect()
		{
			Socket dataSocket = this._dataSocket;
			if (dataSocket != null)
			{
				try
				{
					dataSocket.Close();
				}
				catch (ObjectDisposedException)
				{
				}
			}
		}

		// Token: 0x06000829 RID: 2089 RVA: 0x0002D978 File Offset: 0x0002BB78
		private static void AcceptCallback(IAsyncResult asyncResult)
		{
			FtpControlStream ftpControlStream = (FtpControlStream)asyncResult.AsyncState;
			Socket dataSocket = ftpControlStream._dataSocket;
			try
			{
				ftpControlStream._dataSocket = dataSocket.EndAccept(asyncResult);
				if (!ftpControlStream.ServerAddress.Equals(((IPEndPoint)ftpControlStream._dataSocket.RemoteEndPoint).Address))
				{
					ftpControlStream._dataSocket.Close();
					throw new WebException("The data connection was made from an address that is different than the address to which the FTP connection was made.", WebExceptionStatus.ProtocolError);
				}
				ftpControlStream.ContinueCommandPipeline();
			}
			catch (Exception obj)
			{
				ftpControlStream.CloseSocket();
				ftpControlStream.InvokeRequestCallback(obj);
			}
			finally
			{
				dataSocket.Close();
			}
		}

		// Token: 0x0600082A RID: 2090 RVA: 0x0002DA1C File Offset: 0x0002BC1C
		private static void ConnectCallback(IAsyncResult asyncResult)
		{
			FtpControlStream ftpControlStream = (FtpControlStream)asyncResult.AsyncState;
			try
			{
				ftpControlStream._dataSocket.EndConnect(asyncResult);
				ftpControlStream.ContinueCommandPipeline();
			}
			catch (Exception obj)
			{
				ftpControlStream.CloseSocket();
				ftpControlStream.InvokeRequestCallback(obj);
			}
		}

		// Token: 0x0600082B RID: 2091 RVA: 0x0002DA6C File Offset: 0x0002BC6C
		private static void SSLHandshakeCallback(IAsyncResult asyncResult)
		{
			FtpControlStream ftpControlStream = (FtpControlStream)asyncResult.AsyncState;
			try
			{
				ftpControlStream._tlsStream.EndAuthenticateAsClient(asyncResult);
				ftpControlStream.ContinueCommandPipeline();
			}
			catch (Exception obj)
			{
				ftpControlStream.CloseSocket();
				ftpControlStream.InvokeRequestCallback(obj);
			}
		}

		// Token: 0x0600082C RID: 2092 RVA: 0x0002DABC File Offset: 0x0002BCBC
		private CommandStream.PipelineInstruction QueueOrCreateFtpDataStream(ref Stream stream)
		{
			if (this._dataSocket == null)
			{
				throw new InternalException();
			}
			if (this._tlsStream != null)
			{
				stream = new FtpDataStream(this._tlsStream, (FtpWebRequest)this._request, this.IsFtpDataStreamWriteable());
				this._tlsStream = null;
				return CommandStream.PipelineInstruction.GiveStream;
			}
			NetworkStream networkStream = new NetworkStream(this._dataSocket, true);
			if (base.UsingSecureStream)
			{
				FtpWebRequest ftpWebRequest = (FtpWebRequest)this._request;
				TlsStream tlsStream = new TlsStream(networkStream, this._dataSocket, ftpWebRequest.RequestUri.Host, ftpWebRequest.ClientCertificates);
				networkStream = tlsStream;
				if (this._isAsync)
				{
					this._tlsStream = tlsStream;
					tlsStream.BeginAuthenticateAsClient(FtpControlStream.s_SSLHandshakeCallback, this);
					return CommandStream.PipelineInstruction.Pause;
				}
				tlsStream.AuthenticateAsClient();
			}
			stream = new FtpDataStream(networkStream, (FtpWebRequest)this._request, this.IsFtpDataStreamWriteable());
			return CommandStream.PipelineInstruction.GiveStream;
		}

		// Token: 0x0600082D RID: 2093 RVA: 0x0002DB88 File Offset: 0x0002BD88
		protected override void ClearState()
		{
			this._contentLength = -1L;
			this._lastModified = DateTime.MinValue;
			this._responseUri = null;
			this._dataHandshakeStarted = false;
			this.StatusCode = FtpStatusCode.Undefined;
			this.StatusLine = null;
			this._dataSocket = null;
			this._passiveEndPoint = null;
			this._tlsStream = null;
			base.ClearState();
		}

		// Token: 0x0600082E RID: 2094 RVA: 0x0002DBE0 File Offset: 0x0002BDE0
		protected override CommandStream.PipelineInstruction PipelineCallback(CommandStream.PipelineEntry entry, ResponseDescription response, bool timeout, ref Stream stream)
		{
			if (NetEventSource.IsEnabled)
			{
				NetEventSource.Info(this, FormattableStringFactory.Create("Command:{0} Description:{1}", new object[]
				{
					(entry != null) ? entry.Command : null,
					(response != null) ? response.StatusDescription : null
				}), "PipelineCallback");
			}
			if (response == null)
			{
				return CommandStream.PipelineInstruction.Abort;
			}
			FtpStatusCode status = (FtpStatusCode)response.Status;
			if (status != FtpStatusCode.ClosingControl)
			{
				this.StatusCode = status;
				this.StatusLine = response.StatusDescription;
			}
			if (response.InvalidStatusCode)
			{
				throw new WebException("The server returned a status code outside the valid range of 100-599.", WebExceptionStatus.ProtocolError);
			}
			if (this._index == -1)
			{
				if (status == FtpStatusCode.SendUserCommand)
				{
					this._bannerMessage = new StringBuilder();
					this._bannerMessage.Append(this.StatusLine);
					return CommandStream.PipelineInstruction.Advance;
				}
				if (status == FtpStatusCode.ServiceTemporarilyNotAvailable)
				{
					return CommandStream.PipelineInstruction.Reread;
				}
				throw base.GenerateException(status, response.StatusDescription, null);
			}
			else
			{
				if (entry.Command == "OPTS utf8 on\r\n")
				{
					if (response.PositiveCompletion)
					{
						base.Encoding = Encoding.UTF8;
					}
					else
					{
						base.Encoding = Encoding.Default;
					}
					return CommandStream.PipelineInstruction.Advance;
				}
				if (entry.Command.IndexOf("USER") != -1 && status == FtpStatusCode.LoggedInProceed)
				{
					this._loginState = FtpLoginState.LoggedIn;
					this._index++;
				}
				if (response.TransientFailure || response.PermanentFailure)
				{
					if (status == FtpStatusCode.ServiceNotAvailable)
					{
						base.MarkAsRecoverableFailure();
					}
					throw base.GenerateException(status, response.StatusDescription, null);
				}
				if (this._loginState != FtpLoginState.LoggedIn && entry.Command.IndexOf("PASS") != -1)
				{
					if (status != FtpStatusCode.NeedLoginAccount && status != FtpStatusCode.LoggedInProceed)
					{
						throw base.GenerateException(status, response.StatusDescription, null);
					}
					this._loginState = FtpLoginState.LoggedIn;
				}
				if (entry.HasFlag(CommandStream.PipelineEntryFlags.CreateDataConnection) && (response.PositiveCompletion || response.PositiveIntermediate))
				{
					bool flag;
					CommandStream.PipelineInstruction result = this.QueueOrCreateDataConection(entry, response, timeout, ref stream, out flag);
					if (!flag)
					{
						return result;
					}
				}
				if (status == FtpStatusCode.OpeningData || status == FtpStatusCode.DataAlreadyOpen)
				{
					if (this._dataSocket == null)
					{
						return CommandStream.PipelineInstruction.Abort;
					}
					if (!entry.HasFlag(CommandStream.PipelineEntryFlags.GiveDataStream))
					{
						this._abortReason = SR.Format("The status response ({0}) is not expected in response to '{1}' command.", status, entry.Command);
						return CommandStream.PipelineInstruction.Abort;
					}
					this.TryUpdateContentLength(response.StatusDescription);
					FtpWebRequest ftpWebRequest = (FtpWebRequest)this._request;
					if (ftpWebRequest.MethodInfo.ShouldParseForResponseUri)
					{
						this.TryUpdateResponseUri(response.StatusDescription, ftpWebRequest);
					}
					return this.QueueOrCreateFtpDataStream(ref stream);
				}
				else
				{
					if (status == FtpStatusCode.LoggedInProceed)
					{
						this._welcomeMessage.Append(this.StatusLine);
					}
					else if (status == FtpStatusCode.ClosingControl)
					{
						this._exitMessage.Append(response.StatusDescription);
						base.CloseSocket();
					}
					else if (status == FtpStatusCode.ServerWantsSecureSession)
					{
						if (!(base.NetworkStream is TlsStream))
						{
							FtpWebRequest ftpWebRequest2 = (FtpWebRequest)this._request;
							TlsStream tlsStream = new TlsStream(base.NetworkStream, base.Socket, ftpWebRequest2.RequestUri.Host, ftpWebRequest2.ClientCertificates);
							if (this._isAsync)
							{
								tlsStream.BeginAuthenticateAsClient(delegate(IAsyncResult ar)
								{
									try
									{
										tlsStream.EndAuthenticateAsClient(ar);
										this.NetworkStream = tlsStream;
										this.ContinueCommandPipeline();
									}
									catch (Exception obj)
									{
										this.CloseSocket();
										this.InvokeRequestCallback(obj);
									}
								}, null);
								return CommandStream.PipelineInstruction.Pause;
							}
							tlsStream.AuthenticateAsClient();
							base.NetworkStream = tlsStream;
						}
					}
					else if (status == FtpStatusCode.FileStatus)
					{
						FtpWebRequest ftpWebRequest3 = (FtpWebRequest)this._request;
						if (entry.Command.StartsWith("SIZE "))
						{
							this._contentLength = this.GetContentLengthFrom213Response(response.StatusDescription);
						}
						else if (entry.Command.StartsWith("MDTM "))
						{
							this._lastModified = this.GetLastModifiedFrom213Response(response.StatusDescription);
						}
					}
					else if (status == FtpStatusCode.PathnameCreated)
					{
						if (entry.Command == "PWD\r\n" && !entry.HasFlag(CommandStream.PipelineEntryFlags.UserCommand))
						{
							this._loginDirectory = this.GetLoginDirectory(response.StatusDescription);
						}
					}
					else if (entry.Command.IndexOf("CWD") != -1)
					{
						this._establishedServerDirectory = this._requestedServerDirectory;
					}
					if (response.PositiveIntermediate || (!base.UsingSecureStream && entry.Command == "AUTH TLS\r\n"))
					{
						return CommandStream.PipelineInstruction.Reread;
					}
					return CommandStream.PipelineInstruction.Advance;
				}
			}
		}

		// Token: 0x0600082F RID: 2095 RVA: 0x0002DFE8 File Offset: 0x0002C1E8
		protected override CommandStream.PipelineEntry[] BuildCommandsList(WebRequest req)
		{
			bool flag = false;
			FtpWebRequest ftpWebRequest = (FtpWebRequest)req;
			if (NetEventSource.IsEnabled)
			{
				NetEventSource.Info(this, null, "BuildCommandsList");
			}
			this._responseUri = ftpWebRequest.RequestUri;
			ArrayList arrayList = new ArrayList();
			if (ftpWebRequest.EnableSsl && !base.UsingSecureStream)
			{
				arrayList.Add(new CommandStream.PipelineEntry(this.FormatFtpCommand("AUTH", "TLS")));
				flag = true;
			}
			if (flag)
			{
				this._loginDirectory = null;
				this._establishedServerDirectory = null;
				this._requestedServerDirectory = null;
				this._currentTypeSetting = string.Empty;
				if (this._loginState == FtpLoginState.LoggedIn)
				{
					this._loginState = FtpLoginState.LoggedInButNeedsRelogin;
				}
			}
			if (this._loginState != FtpLoginState.LoggedIn)
			{
				this.Credentials = ftpWebRequest.Credentials.GetCredential(ftpWebRequest.RequestUri, "basic");
				this._welcomeMessage = new StringBuilder();
				this._exitMessage = new StringBuilder();
				string text = string.Empty;
				string text2 = string.Empty;
				if (this.Credentials != null)
				{
					text = this.Credentials.UserName;
					string domain = this.Credentials.Domain;
					if (!string.IsNullOrEmpty(domain))
					{
						text = domain + "\\" + text;
					}
					text2 = this.Credentials.Password;
				}
				if (text.Length == 0 && text2.Length == 0)
				{
					text = "anonymous";
					text2 = "anonymous@";
				}
				arrayList.Add(new CommandStream.PipelineEntry(this.FormatFtpCommand("USER", text)));
				arrayList.Add(new CommandStream.PipelineEntry(this.FormatFtpCommand("PASS", text2), CommandStream.PipelineEntryFlags.DontLogParameter));
				if (ftpWebRequest.EnableSsl && !base.UsingSecureStream)
				{
					arrayList.Add(new CommandStream.PipelineEntry(this.FormatFtpCommand("PBSZ", "0")));
					arrayList.Add(new CommandStream.PipelineEntry(this.FormatFtpCommand("PROT", "P")));
				}
				arrayList.Add(new CommandStream.PipelineEntry(this.FormatFtpCommand("OPTS", "utf8 on")));
				arrayList.Add(new CommandStream.PipelineEntry(this.FormatFtpCommand("PWD", null)));
			}
			FtpControlStream.GetPathOption pathOption = FtpControlStream.GetPathOption.Normal;
			if (ftpWebRequest.MethodInfo.HasFlag(FtpMethodFlags.DoesNotTakeParameter))
			{
				pathOption = FtpControlStream.GetPathOption.AssumeNoFilename;
			}
			else if (ftpWebRequest.MethodInfo.HasFlag(FtpMethodFlags.ParameterIsDirectory))
			{
				pathOption = FtpControlStream.GetPathOption.AssumeFilename;
			}
			string parameter;
			string text3;
			string text4;
			FtpControlStream.GetPathInfo(pathOption, ftpWebRequest.RequestUri, out parameter, out text3, out text4);
			if (text4.Length == 0 && ftpWebRequest.MethodInfo.HasFlag(FtpMethodFlags.TakesParameter))
			{
				throw new WebException("The requested URI is invalid for this FTP command.");
			}
			if (this._establishedServerDirectory != null && this._loginDirectory != null && this._establishedServerDirectory != this._loginDirectory)
			{
				arrayList.Add(new CommandStream.PipelineEntry(this.FormatFtpCommand("CWD", this._loginDirectory), CommandStream.PipelineEntryFlags.UserCommand));
				this._requestedServerDirectory = this._loginDirectory;
			}
			if (ftpWebRequest.MethodInfo.HasFlag(FtpMethodFlags.MustChangeWorkingDirectoryToPath) && text3.Length > 0)
			{
				arrayList.Add(new CommandStream.PipelineEntry(this.FormatFtpCommand("CWD", text3), CommandStream.PipelineEntryFlags.UserCommand));
				this._requestedServerDirectory = text3;
			}
			if (!ftpWebRequest.MethodInfo.IsCommandOnly)
			{
				string text5 = ftpWebRequest.UseBinary ? "I" : "A";
				if (this._currentTypeSetting != text5)
				{
					arrayList.Add(new CommandStream.PipelineEntry(this.FormatFtpCommand("TYPE", text5)));
					this._currentTypeSetting = text5;
				}
				if (ftpWebRequest.UsePassive)
				{
					string command = (base.ServerAddress.AddressFamily == AddressFamily.InterNetwork) ? "PASV" : "EPSV";
					arrayList.Add(new CommandStream.PipelineEntry(this.FormatFtpCommand(command, null), CommandStream.PipelineEntryFlags.CreateDataConnection));
				}
				else
				{
					string command2 = (base.ServerAddress.AddressFamily == AddressFamily.InterNetwork) ? "PORT" : "EPRT";
					this.CreateFtpListenerSocket(ftpWebRequest);
					arrayList.Add(new CommandStream.PipelineEntry(this.FormatFtpCommand(command2, this.GetPortCommandLine(ftpWebRequest))));
				}
				if (ftpWebRequest.ContentOffset > 0L)
				{
					arrayList.Add(new CommandStream.PipelineEntry(this.FormatFtpCommand("REST", ftpWebRequest.ContentOffset.ToString(CultureInfo.InvariantCulture))));
				}
			}
			CommandStream.PipelineEntryFlags pipelineEntryFlags = CommandStream.PipelineEntryFlags.UserCommand;
			if (!ftpWebRequest.MethodInfo.IsCommandOnly)
			{
				pipelineEntryFlags |= CommandStream.PipelineEntryFlags.GiveDataStream;
				if (!ftpWebRequest.UsePassive)
				{
					pipelineEntryFlags |= CommandStream.PipelineEntryFlags.CreateDataConnection;
				}
			}
			if (ftpWebRequest.MethodInfo.Operation == FtpOperation.Rename)
			{
				string str = (text3 == string.Empty) ? string.Empty : (text3 + "/");
				arrayList.Add(new CommandStream.PipelineEntry(this.FormatFtpCommand("RNFR", str + text4), pipelineEntryFlags));
				string parameter2;
				if (!string.IsNullOrEmpty(ftpWebRequest.RenameTo) && ftpWebRequest.RenameTo.StartsWith("/", StringComparison.OrdinalIgnoreCase))
				{
					parameter2 = ftpWebRequest.RenameTo;
				}
				else
				{
					parameter2 = str + ftpWebRequest.RenameTo;
				}
				arrayList.Add(new CommandStream.PipelineEntry(this.FormatFtpCommand("RNTO", parameter2), pipelineEntryFlags));
			}
			else if (ftpWebRequest.MethodInfo.HasFlag(FtpMethodFlags.DoesNotTakeParameter))
			{
				arrayList.Add(new CommandStream.PipelineEntry(this.FormatFtpCommand(ftpWebRequest.Method, string.Empty), pipelineEntryFlags));
			}
			else if (ftpWebRequest.MethodInfo.HasFlag(FtpMethodFlags.MustChangeWorkingDirectoryToPath))
			{
				arrayList.Add(new CommandStream.PipelineEntry(this.FormatFtpCommand(ftpWebRequest.Method, text4), pipelineEntryFlags));
			}
			else
			{
				arrayList.Add(new CommandStream.PipelineEntry(this.FormatFtpCommand(ftpWebRequest.Method, parameter), pipelineEntryFlags));
			}
			arrayList.Add(new CommandStream.PipelineEntry(this.FormatFtpCommand("QUIT", null)));
			return (CommandStream.PipelineEntry[])arrayList.ToArray(typeof(CommandStream.PipelineEntry));
		}

		// Token: 0x06000830 RID: 2096 RVA: 0x0002E54C File Offset: 0x0002C74C
		private CommandStream.PipelineInstruction QueueOrCreateDataConection(CommandStream.PipelineEntry entry, ResponseDescription response, bool timeout, ref Stream stream, out bool isSocketReady)
		{
			isSocketReady = false;
			if (this._dataHandshakeStarted)
			{
				isSocketReady = true;
				return CommandStream.PipelineInstruction.Pause;
			}
			this._dataHandshakeStarted = true;
			bool flag = false;
			int num = -1;
			if (entry.Command == "PASV\r\n" || entry.Command == "EPSV\r\n")
			{
				if (!response.PositiveCompletion)
				{
					this._abortReason = SR.Format("The server failed the passive mode request with status response ({0}).", response.Status);
					return CommandStream.PipelineInstruction.Abort;
				}
				if (entry.Command == "PASV\r\n")
				{
					num = this.GetPortV4(response.StatusDescription);
				}
				else
				{
					num = this.GetPortV6(response.StatusDescription);
				}
				flag = true;
			}
			if (flag)
			{
				if (num == -1)
				{
					NetEventSource.Fail(this, "'port' not set.", "QueueOrCreateDataConection");
				}
				try
				{
					this._dataSocket = this.CreateFtpDataSocket((FtpWebRequest)this._request, base.Socket);
				}
				catch (ObjectDisposedException)
				{
					throw ExceptionHelper.RequestAbortedException;
				}
				IPEndPoint localEP = new IPEndPoint(((IPEndPoint)base.Socket.LocalEndPoint).Address, 0);
				this._dataSocket.Bind(localEP);
				this._passiveEndPoint = new IPEndPoint(base.ServerAddress, num);
			}
			CommandStream.PipelineInstruction result;
			if (this._passiveEndPoint != null)
			{
				IPEndPoint passiveEndPoint = this._passiveEndPoint;
				this._passiveEndPoint = null;
				if (NetEventSource.IsEnabled)
				{
					NetEventSource.Info(this, "starting Connect()", "QueueOrCreateDataConection");
				}
				if (this._isAsync)
				{
					this._dataSocket.BeginConnect(passiveEndPoint, FtpControlStream.s_connectCallbackDelegate, this);
					result = CommandStream.PipelineInstruction.Pause;
				}
				else
				{
					this._dataSocket.Connect(passiveEndPoint);
					result = CommandStream.PipelineInstruction.Advance;
				}
			}
			else
			{
				if (NetEventSource.IsEnabled)
				{
					NetEventSource.Info(this, "starting Accept()", "QueueOrCreateDataConection");
				}
				if (this._isAsync)
				{
					this._dataSocket.BeginAccept(FtpControlStream.s_acceptCallbackDelegate, this);
					result = CommandStream.PipelineInstruction.Pause;
				}
				else
				{
					Socket dataSocket = this._dataSocket;
					try
					{
						this._dataSocket = this._dataSocket.Accept();
						if (!base.ServerAddress.Equals(((IPEndPoint)this._dataSocket.RemoteEndPoint).Address))
						{
							this._dataSocket.Close();
							throw new WebException("The data connection was made from an address that is different than the address to which the FTP connection was made.", WebExceptionStatus.ProtocolError);
						}
						isSocketReady = true;
						result = CommandStream.PipelineInstruction.Pause;
					}
					finally
					{
						dataSocket.Close();
					}
				}
			}
			return result;
		}

		// Token: 0x06000831 RID: 2097 RVA: 0x0002E780 File Offset: 0x0002C980
		private static void GetPathInfo(FtpControlStream.GetPathOption pathOption, Uri uri, out string path, out string directory, out string filename)
		{
			path = uri.GetComponents(UriComponents.Path, UriFormat.Unescaped);
			int num = path.LastIndexOf('/');
			if (pathOption == FtpControlStream.GetPathOption.AssumeFilename && num != -1 && num == path.Length - 1)
			{
				path = path.Substring(0, path.Length - 1);
				num = path.LastIndexOf('/');
			}
			if (pathOption == FtpControlStream.GetPathOption.AssumeNoFilename)
			{
				directory = path;
				filename = string.Empty;
			}
			else
			{
				directory = path.Substring(0, num + 1);
				filename = path.Substring(num + 1, path.Length - (num + 1));
			}
			if (directory.Length > 1 && directory[directory.Length - 1] == '/')
			{
				directory = directory.Substring(0, directory.Length - 1);
			}
		}

		// Token: 0x06000832 RID: 2098 RVA: 0x0002E83C File Offset: 0x0002CA3C
		private string FormatAddress(IPAddress address, int Port)
		{
			byte[] addressBytes = address.GetAddressBytes();
			StringBuilder stringBuilder = new StringBuilder(32);
			foreach (byte value in addressBytes)
			{
				stringBuilder.Append(value);
				stringBuilder.Append(',');
			}
			stringBuilder.Append(Port / 256);
			stringBuilder.Append(',');
			stringBuilder.Append(Port % 256);
			return stringBuilder.ToString();
		}

		// Token: 0x06000833 RID: 2099 RVA: 0x0002E8A8 File Offset: 0x0002CAA8
		private string FormatAddressV6(IPAddress address, int port)
		{
			StringBuilder stringBuilder = new StringBuilder(43);
			string value = address.ToString();
			stringBuilder.Append("|2|");
			stringBuilder.Append(value);
			stringBuilder.Append('|');
			stringBuilder.Append(port.ToString(NumberFormatInfo.InvariantInfo));
			stringBuilder.Append('|');
			return stringBuilder.ToString();
		}

		// Token: 0x17000162 RID: 354
		// (get) Token: 0x06000834 RID: 2100 RVA: 0x0002E901 File Offset: 0x0002CB01
		internal long ContentLength
		{
			get
			{
				return this._contentLength;
			}
		}

		// Token: 0x17000163 RID: 355
		// (get) Token: 0x06000835 RID: 2101 RVA: 0x0002E909 File Offset: 0x0002CB09
		internal DateTime LastModified
		{
			get
			{
				return this._lastModified;
			}
		}

		// Token: 0x17000164 RID: 356
		// (get) Token: 0x06000836 RID: 2102 RVA: 0x0002E911 File Offset: 0x0002CB11
		internal Uri ResponseUri
		{
			get
			{
				return this._responseUri;
			}
		}

		// Token: 0x17000165 RID: 357
		// (get) Token: 0x06000837 RID: 2103 RVA: 0x0002E919 File Offset: 0x0002CB19
		internal string BannerMessage
		{
			get
			{
				if (this._bannerMessage == null)
				{
					return null;
				}
				return this._bannerMessage.ToString();
			}
		}

		// Token: 0x17000166 RID: 358
		// (get) Token: 0x06000838 RID: 2104 RVA: 0x0002E930 File Offset: 0x0002CB30
		internal string WelcomeMessage
		{
			get
			{
				if (this._welcomeMessage == null)
				{
					return null;
				}
				return this._welcomeMessage.ToString();
			}
		}

		// Token: 0x17000167 RID: 359
		// (get) Token: 0x06000839 RID: 2105 RVA: 0x0002E947 File Offset: 0x0002CB47
		internal string ExitMessage
		{
			get
			{
				if (this._exitMessage == null)
				{
					return null;
				}
				return this._exitMessage.ToString();
			}
		}

		// Token: 0x0600083A RID: 2106 RVA: 0x0002E95E File Offset: 0x0002CB5E
		private long GetContentLengthFrom213Response(string responseString)
		{
			string[] array = responseString.Split(new char[]
			{
				' '
			});
			if (array.Length < 2)
			{
				throw new FormatException(SR.Format("The response string '{0}' has invalid format.", responseString));
			}
			return Convert.ToInt64(array[1], NumberFormatInfo.InvariantInfo);
		}

		// Token: 0x0600083B RID: 2107 RVA: 0x0002E994 File Offset: 0x0002CB94
		private DateTime GetLastModifiedFrom213Response(string str)
		{
			DateTime result = this._lastModified;
			string[] array = str.Split(new char[]
			{
				' ',
				'.'
			});
			if (array.Length < 2)
			{
				return result;
			}
			string text = array[1];
			if (text.Length < 14)
			{
				return result;
			}
			int year = Convert.ToInt32(text.Substring(0, 4), NumberFormatInfo.InvariantInfo);
			int month = (int)Convert.ToInt16(text.Substring(4, 2), NumberFormatInfo.InvariantInfo);
			int day = (int)Convert.ToInt16(text.Substring(6, 2), NumberFormatInfo.InvariantInfo);
			int hour = (int)Convert.ToInt16(text.Substring(8, 2), NumberFormatInfo.InvariantInfo);
			int minute = (int)Convert.ToInt16(text.Substring(10, 2), NumberFormatInfo.InvariantInfo);
			int second = (int)Convert.ToInt16(text.Substring(12, 2), NumberFormatInfo.InvariantInfo);
			int millisecond = 0;
			if (array.Length > 2)
			{
				millisecond = (int)Convert.ToInt16(array[2], NumberFormatInfo.InvariantInfo);
			}
			try
			{
				result = new DateTime(year, month, day, hour, minute, second, millisecond);
				result = result.ToLocalTime();
			}
			catch (ArgumentOutOfRangeException)
			{
			}
			catch (ArgumentException)
			{
			}
			return result;
		}

		// Token: 0x0600083C RID: 2108 RVA: 0x0002EAAC File Offset: 0x0002CCAC
		private void TryUpdateResponseUri(string str, FtpWebRequest request)
		{
			Uri uri = request.RequestUri;
			int num = str.IndexOf("for ");
			if (num == -1)
			{
				return;
			}
			num += 4;
			int num2 = str.LastIndexOf('(');
			if (num2 == -1)
			{
				num2 = str.Length;
			}
			if (num2 <= num)
			{
				return;
			}
			string text = str.Substring(num, num2 - num);
			text = text.TrimEnd(new char[]
			{
				' ',
				'.',
				'\r',
				'\n'
			});
			string text2 = text.Replace("%", "%25");
			text2 = text2.Replace("#", "%23");
			string absolutePath = uri.AbsolutePath;
			if (absolutePath.Length > 0 && absolutePath[absolutePath.Length - 1] != '/')
			{
				uri = new UriBuilder(uri)
				{
					Path = absolutePath + "/"
				}.Uri;
			}
			Uri uri2;
			if (!Uri.TryCreate(uri, text2, out uri2))
			{
				throw new FormatException(SR.Format("The server returned the filename ({0}) which is not valid.", text));
			}
			if (!uri.IsBaseOf(uri2) || uri.Segments.Length != uri2.Segments.Length - 1)
			{
				throw new FormatException(SR.Format("The server returned the filename ({0}) which is not valid.", text));
			}
			this._responseUri = uri2;
		}

		// Token: 0x0600083D RID: 2109 RVA: 0x0002EBD0 File Offset: 0x0002CDD0
		private void TryUpdateContentLength(string str)
		{
			int num = str.LastIndexOf("(");
			if (num != -1)
			{
				int num2 = str.IndexOf(" bytes).");
				if (num2 != -1 && num2 > num)
				{
					num++;
					long contentLength;
					if (long.TryParse(str.Substring(num, num2 - num), NumberStyles.AllowLeadingWhite | NumberStyles.AllowTrailingWhite, NumberFormatInfo.InvariantInfo, out contentLength))
					{
						this._contentLength = contentLength;
					}
				}
			}
		}

		// Token: 0x0600083E RID: 2110 RVA: 0x0002EC28 File Offset: 0x0002CE28
		private string GetLoginDirectory(string str)
		{
			int num = str.IndexOf('"');
			int num2 = str.LastIndexOf('"');
			if (num != -1 && num2 != -1 && num != num2)
			{
				return str.Substring(num + 1, num2 - num - 1);
			}
			return string.Empty;
		}

		// Token: 0x0600083F RID: 2111 RVA: 0x0002EC68 File Offset: 0x0002CE68
		private int GetPortV4(string responseString)
		{
			string[] array = responseString.Split(new char[]
			{
				' ',
				'(',
				',',
				')'
			});
			if (array.Length <= 7)
			{
				throw new FormatException(SR.Format("The response string '{0}' has invalid format.", responseString));
			}
			int num = array.Length - 1;
			if (!char.IsNumber(array[num], 0))
			{
				num--;
			}
			return (int)Convert.ToByte(array[num--], NumberFormatInfo.InvariantInfo) | (int)Convert.ToByte(array[num--], NumberFormatInfo.InvariantInfo) << 8;
		}

		// Token: 0x06000840 RID: 2112 RVA: 0x0002ECE0 File Offset: 0x0002CEE0
		private int GetPortV6(string responseString)
		{
			int num = responseString.LastIndexOf("(");
			int num2 = responseString.LastIndexOf(")");
			if (num == -1 || num2 <= num)
			{
				throw new FormatException(SR.Format("The response string '{0}' has invalid format.", responseString));
			}
			string[] array = responseString.Substring(num + 1, num2 - num - 1).Split(new char[]
			{
				'|'
			});
			if (array.Length < 4)
			{
				throw new FormatException(SR.Format("The response string '{0}' has invalid format.", responseString));
			}
			return Convert.ToInt32(array[3], NumberFormatInfo.InvariantInfo);
		}

		// Token: 0x06000841 RID: 2113 RVA: 0x0002ED60 File Offset: 0x0002CF60
		private void CreateFtpListenerSocket(FtpWebRequest request)
		{
			IPEndPoint localEP = new IPEndPoint(((IPEndPoint)base.Socket.LocalEndPoint).Address, 0);
			try
			{
				this._dataSocket = this.CreateFtpDataSocket(request, base.Socket);
			}
			catch (ObjectDisposedException)
			{
				throw ExceptionHelper.RequestAbortedException;
			}
			this._dataSocket.Bind(localEP);
			this._dataSocket.Listen(1);
		}

		// Token: 0x06000842 RID: 2114 RVA: 0x0002EDD0 File Offset: 0x0002CFD0
		private string GetPortCommandLine(FtpWebRequest request)
		{
			string result;
			try
			{
				IPEndPoint ipendPoint = (IPEndPoint)this._dataSocket.LocalEndPoint;
				if (base.ServerAddress.AddressFamily == AddressFamily.InterNetwork)
				{
					result = this.FormatAddress(ipendPoint.Address, ipendPoint.Port);
				}
				else
				{
					if (base.ServerAddress.AddressFamily != AddressFamily.InterNetworkV6)
					{
						throw new InternalException();
					}
					result = this.FormatAddressV6(ipendPoint.Address, ipendPoint.Port);
				}
			}
			catch (Exception innerException)
			{
				throw base.GenerateException("The underlying connection was closed: The server committed a protocol violation", WebExceptionStatus.ProtocolError, innerException);
			}
			return result;
		}

		// Token: 0x06000843 RID: 2115 RVA: 0x0002EE5C File Offset: 0x0002D05C
		private string FormatFtpCommand(string command, string parameter)
		{
			StringBuilder stringBuilder = new StringBuilder(command.Length + ((parameter != null) ? parameter.Length : 0) + 3);
			stringBuilder.Append(command);
			if (!string.IsNullOrEmpty(parameter))
			{
				stringBuilder.Append(' ');
				stringBuilder.Append(parameter);
			}
			stringBuilder.Append("\r\n");
			return stringBuilder.ToString();
		}

		// Token: 0x06000844 RID: 2116 RVA: 0x0002EEB7 File Offset: 0x0002D0B7
		protected Socket CreateFtpDataSocket(FtpWebRequest request, Socket templateSocket)
		{
			return new Socket(templateSocket.AddressFamily, templateSocket.SocketType, templateSocket.ProtocolType);
		}

		// Token: 0x06000845 RID: 2117 RVA: 0x0002EED0 File Offset: 0x0002D0D0
		protected override bool CheckValid(ResponseDescription response, ref int validThrough, ref int completeLength)
		{
			if (NetEventSource.IsEnabled)
			{
				NetEventSource.Info(this, FormattableStringFactory.Create("CheckValid({0})", new object[]
				{
					response.StatusBuffer
				}), "CheckValid");
			}
			if (response.StatusBuffer.Length < 4)
			{
				return true;
			}
			string text = response.StatusBuffer.ToString();
			if (response.Status == -1)
			{
				if (!char.IsDigit(text[0]) || !char.IsDigit(text[1]) || !char.IsDigit(text[2]) || (text[3] != ' ' && text[3] != '-'))
				{
					return false;
				}
				response.StatusCodeString = text.Substring(0, 3);
				response.Status = (int)Convert.ToInt16(response.StatusCodeString, NumberFormatInfo.InvariantInfo);
				if (text[3] == '-')
				{
					response.Multiline = true;
				}
			}
			int num;
			while ((num = text.IndexOf("\r\n", validThrough)) != -1)
			{
				int num2 = validThrough;
				validThrough = num + 2;
				if (!response.Multiline)
				{
					completeLength = validThrough;
					return true;
				}
				if (text.Length > num2 + 4 && text.Substring(num2, 3) == response.StatusCodeString && text[num2 + 3] == ' ')
				{
					completeLength = validThrough;
					return true;
				}
			}
			return true;
		}

		// Token: 0x06000846 RID: 2118 RVA: 0x0002F008 File Offset: 0x0002D208
		private TriState IsFtpDataStreamWriteable()
		{
			FtpWebRequest ftpWebRequest = this._request as FtpWebRequest;
			if (ftpWebRequest != null)
			{
				if (ftpWebRequest.MethodInfo.IsUpload)
				{
					return TriState.True;
				}
				if (ftpWebRequest.MethodInfo.IsDownload)
				{
					return TriState.False;
				}
			}
			return TriState.Unspecified;
		}

		// Token: 0x040005A6 RID: 1446
		private Socket _dataSocket;

		// Token: 0x040005A7 RID: 1447
		private IPEndPoint _passiveEndPoint;

		// Token: 0x040005A8 RID: 1448
		private TlsStream _tlsStream;

		// Token: 0x040005A9 RID: 1449
		private StringBuilder _bannerMessage;

		// Token: 0x040005AA RID: 1450
		private StringBuilder _welcomeMessage;

		// Token: 0x040005AB RID: 1451
		private StringBuilder _exitMessage;

		// Token: 0x040005AC RID: 1452
		private WeakReference _credentials;

		// Token: 0x040005AD RID: 1453
		private string _currentTypeSetting = string.Empty;

		// Token: 0x040005AE RID: 1454
		private long _contentLength = -1L;

		// Token: 0x040005AF RID: 1455
		private DateTime _lastModified;

		// Token: 0x040005B0 RID: 1456
		private bool _dataHandshakeStarted;

		// Token: 0x040005B1 RID: 1457
		private string _loginDirectory;

		// Token: 0x040005B2 RID: 1458
		private string _establishedServerDirectory;

		// Token: 0x040005B3 RID: 1459
		private string _requestedServerDirectory;

		// Token: 0x040005B4 RID: 1460
		private Uri _responseUri;

		// Token: 0x040005B5 RID: 1461
		private FtpLoginState _loginState;

		// Token: 0x040005B6 RID: 1462
		internal FtpStatusCode StatusCode;

		// Token: 0x040005B7 RID: 1463
		internal string StatusLine;

		// Token: 0x040005B8 RID: 1464
		private static readonly AsyncCallback s_acceptCallbackDelegate = new AsyncCallback(FtpControlStream.AcceptCallback);

		// Token: 0x040005B9 RID: 1465
		private static readonly AsyncCallback s_connectCallbackDelegate = new AsyncCallback(FtpControlStream.ConnectCallback);

		// Token: 0x040005BA RID: 1466
		private static readonly AsyncCallback s_SSLHandshakeCallback = new AsyncCallback(FtpControlStream.SSLHandshakeCallback);

		// Token: 0x02000120 RID: 288
		private enum GetPathOption
		{
			// Token: 0x040005BC RID: 1468
			Normal,
			// Token: 0x040005BD RID: 1469
			AssumeFilename,
			// Token: 0x040005BE RID: 1470
			AssumeNoFilename
		}
	}
}
