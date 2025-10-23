using System;
using System.IO;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Text;

namespace System.Net
{
	// Token: 0x02000118 RID: 280
	internal class CommandStream : NetworkStreamWrapper
	{
		// Token: 0x06000802 RID: 2050 RVA: 0x0002CE28 File Offset: 0x0002B028
		internal CommandStream(TcpClient client) : base(client)
		{
			this._decoder = this._encoding.GetDecoder();
		}

		// Token: 0x06000803 RID: 2051 RVA: 0x0002CE58 File Offset: 0x0002B058
		internal virtual void Abort(Exception e)
		{
			if (NetEventSource.IsEnabled)
			{
				NetEventSource.Info(this, "closing control Stream", "Abort");
			}
			lock (this)
			{
				if (this._aborted)
				{
					return;
				}
				this._aborted = true;
			}
			try
			{
				base.Close(0);
			}
			finally
			{
				if (e != null)
				{
					this.InvokeRequestCallback(e);
				}
				else
				{
					this.InvokeRequestCallback(null);
				}
			}
		}

		// Token: 0x06000804 RID: 2052 RVA: 0x0002CEE0 File Offset: 0x0002B0E0
		protected override void Dispose(bool disposing)
		{
			if (NetEventSource.IsEnabled)
			{
				NetEventSource.Info(this, null, "Dispose");
			}
			this.InvokeRequestCallback(null);
		}

		// Token: 0x06000805 RID: 2053 RVA: 0x0002CEFC File Offset: 0x0002B0FC
		protected void InvokeRequestCallback(object obj)
		{
			WebRequest request = this._request;
			if (request != null)
			{
				((FtpWebRequest)request).RequestCallback(obj);
			}
		}

		// Token: 0x1700015A RID: 346
		// (get) Token: 0x06000806 RID: 2054 RVA: 0x0002CF1F File Offset: 0x0002B11F
		internal bool RecoverableFailure
		{
			get
			{
				return this._recoverableFailure;
			}
		}

		// Token: 0x06000807 RID: 2055 RVA: 0x0002CF27 File Offset: 0x0002B127
		protected void MarkAsRecoverableFailure()
		{
			if (this._index <= 1)
			{
				this._recoverableFailure = true;
			}
		}

		// Token: 0x06000808 RID: 2056 RVA: 0x0002CF3C File Offset: 0x0002B13C
		internal Stream SubmitRequest(WebRequest request, bool isAsync, bool readInitalResponseOnConnect)
		{
			this.ClearState();
			CommandStream.PipelineEntry[] commands = this.BuildCommandsList(request);
			this.InitCommandPipeline(request, commands, isAsync);
			if (readInitalResponseOnConnect)
			{
				this._doSend = false;
				this._index = -1;
			}
			return this.ContinueCommandPipeline();
		}

		// Token: 0x06000809 RID: 2057 RVA: 0x0002CF77 File Offset: 0x0002B177
		protected virtual void ClearState()
		{
			this.InitCommandPipeline(null, null, false);
		}

		// Token: 0x0600080A RID: 2058 RVA: 0x000022FE File Offset: 0x000004FE
		protected virtual CommandStream.PipelineEntry[] BuildCommandsList(WebRequest request)
		{
			return null;
		}

		// Token: 0x0600080B RID: 2059 RVA: 0x0002CF82 File Offset: 0x0002B182
		protected Exception GenerateException(string message, WebExceptionStatus status, Exception innerException)
		{
			return new WebException(message, innerException, status, null);
		}

		// Token: 0x0600080C RID: 2060 RVA: 0x0002CF8D File Offset: 0x0002B18D
		protected Exception GenerateException(FtpStatusCode code, string statusDescription, Exception innerException)
		{
			return new WebException(SR.Format("The remote server returned an error: {0}.", NetRes.GetWebStatusCodeString(code, statusDescription)), innerException, WebExceptionStatus.ProtocolError, null);
		}

		// Token: 0x0600080D RID: 2061 RVA: 0x0002CFA8 File Offset: 0x0002B1A8
		protected void InitCommandPipeline(WebRequest request, CommandStream.PipelineEntry[] commands, bool isAsync)
		{
			this._commands = commands;
			this._index = 0;
			this._request = request;
			this._aborted = false;
			this._doRead = true;
			this._doSend = true;
			this._currentResponseDescription = null;
			this._isAsync = isAsync;
			this._recoverableFailure = false;
			this._abortReason = string.Empty;
		}

		// Token: 0x0600080E RID: 2062 RVA: 0x0002D000 File Offset: 0x0002B200
		internal void CheckContinuePipeline()
		{
			if (this._isAsync)
			{
				return;
			}
			try
			{
				this.ContinueCommandPipeline();
			}
			catch (Exception e)
			{
				this.Abort(e);
			}
		}

		// Token: 0x0600080F RID: 2063 RVA: 0x0002D03C File Offset: 0x0002B23C
		protected Stream ContinueCommandPipeline()
		{
			bool isAsync = this._isAsync;
			while (this._index < this._commands.Length)
			{
				if (this._doSend)
				{
					if (this._index < 0)
					{
						throw new InternalException();
					}
					byte[] bytes = this.Encoding.GetBytes(this._commands[this._index].Command);
					if (NetEventSource.Log.IsEnabled())
					{
						string text = this._commands[this._index].Command.Substring(0, this._commands[this._index].Command.Length - 2);
						if (this._commands[this._index].HasFlag(CommandStream.PipelineEntryFlags.DontLogParameter))
						{
							int num = text.IndexOf(' ');
							if (num != -1)
							{
								text = text.Substring(0, num) + " ********";
							}
						}
						if (NetEventSource.IsEnabled)
						{
							NetEventSource.Info(this, FormattableStringFactory.Create("Sending command {0}", new object[]
							{
								text
							}), "ContinueCommandPipeline");
						}
					}
					try
					{
						if (isAsync)
						{
							this.BeginWrite(bytes, 0, bytes.Length, CommandStream.s_writeCallbackDelegate, this);
						}
						else
						{
							this.Write(bytes, 0, bytes.Length);
						}
					}
					catch (IOException)
					{
						this.MarkAsRecoverableFailure();
						throw;
					}
					catch
					{
						throw;
					}
					if (isAsync)
					{
						return null;
					}
				}
				Stream result = null;
				if (this.PostSendCommandProcessing(ref result))
				{
					return result;
				}
			}
			lock (this)
			{
				this.Close();
			}
			return null;
		}

		// Token: 0x06000810 RID: 2064 RVA: 0x0002D1D0 File Offset: 0x0002B3D0
		private bool PostSendCommandProcessing(ref Stream stream)
		{
			if (this._doRead)
			{
				bool isAsync = this._isAsync;
				int index = this._index;
				CommandStream.PipelineEntry[] commands = this._commands;
				try
				{
					ResponseDescription currentResponseDescription = this.ReceiveCommandResponse();
					if (isAsync)
					{
						return true;
					}
					this._currentResponseDescription = currentResponseDescription;
				}
				catch
				{
					if (index < 0 || index >= commands.Length || commands[index].Command != "QUIT\r\n")
					{
						throw;
					}
				}
			}
			return this.PostReadCommandProcessing(ref stream);
		}

		// Token: 0x06000811 RID: 2065 RVA: 0x0002D250 File Offset: 0x0002B450
		private bool PostReadCommandProcessing(ref Stream stream)
		{
			if (this._index >= this._commands.Length)
			{
				return false;
			}
			this._doSend = false;
			this._doRead = false;
			CommandStream.PipelineEntry pipelineEntry;
			if (this._index == -1)
			{
				pipelineEntry = null;
			}
			else
			{
				pipelineEntry = this._commands[this._index];
			}
			CommandStream.PipelineInstruction pipelineInstruction;
			if (this._currentResponseDescription == null && pipelineEntry.Command == "QUIT\r\n")
			{
				pipelineInstruction = CommandStream.PipelineInstruction.Advance;
			}
			else
			{
				pipelineInstruction = this.PipelineCallback(pipelineEntry, this._currentResponseDescription, false, ref stream);
			}
			if (pipelineInstruction == CommandStream.PipelineInstruction.Abort)
			{
				Exception ex;
				if (this._abortReason != string.Empty)
				{
					ex = new WebException(this._abortReason);
				}
				else
				{
					ex = this.GenerateException("The underlying connection was closed: The server committed a protocol violation", WebExceptionStatus.ServerProtocolViolation, null);
				}
				this.Abort(ex);
				throw ex;
			}
			if (pipelineInstruction == CommandStream.PipelineInstruction.Advance)
			{
				this._currentResponseDescription = null;
				this._doSend = true;
				this._doRead = true;
				this._index++;
			}
			else
			{
				if (pipelineInstruction == CommandStream.PipelineInstruction.Pause)
				{
					return true;
				}
				if (pipelineInstruction == CommandStream.PipelineInstruction.GiveStream)
				{
					this._currentResponseDescription = null;
					this._doRead = true;
					if (this._isAsync)
					{
						this.ContinueCommandPipeline();
						this.InvokeRequestCallback(stream);
					}
					return true;
				}
				if (pipelineInstruction == CommandStream.PipelineInstruction.Reread)
				{
					this._currentResponseDescription = null;
					this._doRead = true;
				}
			}
			return false;
		}

		// Token: 0x06000812 RID: 2066 RVA: 0x000023F6 File Offset: 0x000005F6
		protected virtual CommandStream.PipelineInstruction PipelineCallback(CommandStream.PipelineEntry entry, ResponseDescription response, bool timeout, ref Stream stream)
		{
			return CommandStream.PipelineInstruction.Abort;
		}

		// Token: 0x06000813 RID: 2067 RVA: 0x0002D370 File Offset: 0x0002B570
		private static void ReadCallback(IAsyncResult asyncResult)
		{
			ReceiveState receiveState = (ReceiveState)asyncResult.AsyncState;
			try
			{
				Stream connection = receiveState.Connection;
				int num = 0;
				try
				{
					num = connection.EndRead(asyncResult);
					if (num == 0)
					{
						receiveState.Connection.CloseSocket();
					}
				}
				catch (IOException)
				{
					receiveState.Connection.MarkAsRecoverableFailure();
					throw;
				}
				catch
				{
					throw;
				}
				receiveState.Connection.ReceiveCommandResponseCallback(receiveState, num);
			}
			catch (Exception e)
			{
				receiveState.Connection.Abort(e);
			}
		}

		// Token: 0x06000814 RID: 2068 RVA: 0x0002D404 File Offset: 0x0002B604
		private static void WriteCallback(IAsyncResult asyncResult)
		{
			CommandStream commandStream = (CommandStream)asyncResult.AsyncState;
			try
			{
				try
				{
					commandStream.EndWrite(asyncResult);
				}
				catch (IOException)
				{
					commandStream.MarkAsRecoverableFailure();
					throw;
				}
				catch
				{
					throw;
				}
				Stream stream = null;
				if (!commandStream.PostSendCommandProcessing(ref stream))
				{
					commandStream.ContinueCommandPipeline();
				}
			}
			catch (Exception e)
			{
				commandStream.Abort(e);
			}
		}

		// Token: 0x1700015B RID: 347
		// (get) Token: 0x06000815 RID: 2069 RVA: 0x0002D47C File Offset: 0x0002B67C
		// (set) Token: 0x06000816 RID: 2070 RVA: 0x0002D484 File Offset: 0x0002B684
		protected Encoding Encoding
		{
			get
			{
				return this._encoding;
			}
			set
			{
				this._encoding = value;
				this._decoder = this._encoding.GetDecoder();
			}
		}

		// Token: 0x06000817 RID: 2071 RVA: 0x000023F6 File Offset: 0x000005F6
		protected virtual bool CheckValid(ResponseDescription response, ref int validThrough, ref int completeLength)
		{
			return false;
		}

		// Token: 0x06000818 RID: 2072 RVA: 0x0002D4A0 File Offset: 0x0002B6A0
		private ResponseDescription ReceiveCommandResponse()
		{
			ReceiveState receiveState = new ReceiveState(this);
			try
			{
				if (this._buffer.Length > 0)
				{
					this.ReceiveCommandResponseCallback(receiveState, -1);
				}
				else
				{
					try
					{
						if (this._isAsync)
						{
							this.BeginRead(receiveState.Buffer, 0, receiveState.Buffer.Length, CommandStream.s_readCallbackDelegate, receiveState);
							return null;
						}
						int num = this.Read(receiveState.Buffer, 0, receiveState.Buffer.Length);
						if (num == 0)
						{
							base.CloseSocket();
						}
						this.ReceiveCommandResponseCallback(receiveState, num);
					}
					catch (IOException)
					{
						this.MarkAsRecoverableFailure();
						throw;
					}
					catch
					{
						throw;
					}
				}
			}
			catch (Exception ex)
			{
				if (ex is WebException)
				{
					throw;
				}
				throw this.GenerateException("The underlying connection was closed: An unexpected error occurred on a receive", WebExceptionStatus.ReceiveFailure, ex);
			}
			return receiveState.Resp;
		}

		// Token: 0x06000819 RID: 2073 RVA: 0x0002D578 File Offset: 0x0002B778
		private void ReceiveCommandResponseCallback(ReceiveState state, int bytesRead)
		{
			int num = -1;
			for (;;)
			{
				int validThrough = state.ValidThrough;
				if (this._buffer.Length > 0)
				{
					state.Resp.StatusBuffer.Append(this._buffer);
					this._buffer = string.Empty;
					if (!this.CheckValid(state.Resp, ref validThrough, ref num))
					{
						break;
					}
				}
				else
				{
					if (bytesRead <= 0)
					{
						goto Block_3;
					}
					char[] array = new char[this._decoder.GetCharCount(state.Buffer, 0, bytesRead)];
					int chars = this._decoder.GetChars(state.Buffer, 0, bytesRead, array, 0, false);
					string text = new string(array, 0, chars);
					state.Resp.StatusBuffer.Append(text);
					if (!this.CheckValid(state.Resp, ref validThrough, ref num))
					{
						goto Block_4;
					}
					if (num >= 0)
					{
						int num2 = state.Resp.StatusBuffer.Length - num;
						if (num2 > 0)
						{
							this._buffer = text.Substring(text.Length - num2, num2);
						}
					}
				}
				if (num < 0)
				{
					state.ValidThrough = validThrough;
					try
					{
						if (this._isAsync)
						{
							this.BeginRead(state.Buffer, 0, state.Buffer.Length, CommandStream.s_readCallbackDelegate, state);
							return;
						}
						bytesRead = this.Read(state.Buffer, 0, state.Buffer.Length);
						if (bytesRead == 0)
						{
							base.CloseSocket();
						}
						continue;
					}
					catch (IOException)
					{
						this.MarkAsRecoverableFailure();
						throw;
					}
					catch
					{
						throw;
					}
					goto IL_17B;
				}
				goto IL_17B;
			}
			throw this.GenerateException("The underlying connection was closed: The server committed a protocol violation", WebExceptionStatus.ServerProtocolViolation, null);
			Block_3:
			throw this.GenerateException("The underlying connection was closed: The server committed a protocol violation", WebExceptionStatus.ServerProtocolViolation, null);
			Block_4:
			throw this.GenerateException("The underlying connection was closed: The server committed a protocol violation", WebExceptionStatus.ServerProtocolViolation, null);
			IL_17B:
			string text2 = state.Resp.StatusBuffer.ToString();
			state.Resp.StatusDescription = text2.Substring(0, num);
			if (NetEventSource.IsEnabled)
			{
				NetEventSource.Info(this, FormattableStringFactory.Create("Received response: {0}", new object[]
				{
					text2.Substring(0, num - 2)
				}), "ReceiveCommandResponseCallback");
			}
			if (this._isAsync)
			{
				if (state.Resp != null)
				{
					this._currentResponseDescription = state.Resp;
				}
				Stream stream = null;
				if (this.PostReadCommandProcessing(ref stream))
				{
					return;
				}
				this.ContinueCommandPipeline();
			}
		}

		// Token: 0x0400057C RID: 1404
		private static readonly AsyncCallback s_writeCallbackDelegate = new AsyncCallback(CommandStream.WriteCallback);

		// Token: 0x0400057D RID: 1405
		private static readonly AsyncCallback s_readCallbackDelegate = new AsyncCallback(CommandStream.ReadCallback);

		// Token: 0x0400057E RID: 1406
		private bool _recoverableFailure;

		// Token: 0x0400057F RID: 1407
		protected WebRequest _request;

		// Token: 0x04000580 RID: 1408
		protected bool _isAsync;

		// Token: 0x04000581 RID: 1409
		private bool _aborted;

		// Token: 0x04000582 RID: 1410
		protected CommandStream.PipelineEntry[] _commands;

		// Token: 0x04000583 RID: 1411
		protected int _index;

		// Token: 0x04000584 RID: 1412
		private bool _doRead;

		// Token: 0x04000585 RID: 1413
		private bool _doSend;

		// Token: 0x04000586 RID: 1414
		private ResponseDescription _currentResponseDescription;

		// Token: 0x04000587 RID: 1415
		protected string _abortReason;

		// Token: 0x04000588 RID: 1416
		private string _buffer = string.Empty;

		// Token: 0x04000589 RID: 1417
		private Encoding _encoding = Encoding.UTF8;

		// Token: 0x0400058A RID: 1418
		private Decoder _decoder;

		// Token: 0x02000119 RID: 281
		internal enum PipelineInstruction
		{
			// Token: 0x0400058C RID: 1420
			Abort,
			// Token: 0x0400058D RID: 1421
			Advance,
			// Token: 0x0400058E RID: 1422
			Pause,
			// Token: 0x0400058F RID: 1423
			Reread,
			// Token: 0x04000590 RID: 1424
			GiveStream
		}

		// Token: 0x0200011A RID: 282
		[Flags]
		internal enum PipelineEntryFlags
		{
			// Token: 0x04000592 RID: 1426
			UserCommand = 1,
			// Token: 0x04000593 RID: 1427
			GiveDataStream = 2,
			// Token: 0x04000594 RID: 1428
			CreateDataConnection = 4,
			// Token: 0x04000595 RID: 1429
			DontLogParameter = 8
		}

		// Token: 0x0200011B RID: 283
		internal class PipelineEntry
		{
			// Token: 0x0600081B RID: 2075 RVA: 0x0002D7C4 File Offset: 0x0002B9C4
			internal PipelineEntry(string command)
			{
				this.Command = command;
			}

			// Token: 0x0600081C RID: 2076 RVA: 0x0002D7D3 File Offset: 0x0002B9D3
			internal PipelineEntry(string command, CommandStream.PipelineEntryFlags flags)
			{
				this.Command = command;
				this.Flags = flags;
			}

			// Token: 0x0600081D RID: 2077 RVA: 0x0002D7E9 File Offset: 0x0002B9E9
			internal bool HasFlag(CommandStream.PipelineEntryFlags flags)
			{
				return (this.Flags & flags) > (CommandStream.PipelineEntryFlags)0;
			}

			// Token: 0x04000596 RID: 1430
			internal string Command;

			// Token: 0x04000597 RID: 1431
			internal CommandStream.PipelineEntryFlags Flags;
		}
	}
}
