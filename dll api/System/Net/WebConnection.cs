using System;
using System.IO;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Mono.Net.Security;

namespace System.Net
{
	// Token: 0x020001CC RID: 460
	internal class WebConnection : IDisposable
	{
		// Token: 0x1700027C RID: 636
		// (get) Token: 0x06000C6E RID: 3182 RVA: 0x00040FB3 File Offset: 0x0003F1B3
		public ServicePoint ServicePoint { get; }

		// Token: 0x06000C6F RID: 3183 RVA: 0x00040FBB File Offset: 0x0003F1BB
		public WebConnection(ServicePoint sPoint)
		{
			this.ServicePoint = sPoint;
		}

		// Token: 0x06000C70 RID: 3184 RVA: 0x00040FCA File Offset: 0x0003F1CA
		private bool CanReuse()
		{
			return !this.socket.Poll(0, SelectMode.SelectRead);
		}

		// Token: 0x06000C71 RID: 3185 RVA: 0x00040FDC File Offset: 0x0003F1DC
		private bool CheckReusable()
		{
			if (this.socket != null && this.socket.Connected)
			{
				try
				{
					if (this.CanReuse())
					{
						return true;
					}
				}
				catch
				{
				}
				return false;
			}
			return false;
		}

		// Token: 0x06000C72 RID: 3186 RVA: 0x00041024 File Offset: 0x0003F224
		private Task Connect(WebOperation operation, CancellationToken cancellationToken)
		{
			WebConnection.<Connect>d__16 <Connect>d__;
			<Connect>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<Connect>d__.<>4__this = this;
			<Connect>d__.operation = operation;
			<Connect>d__.cancellationToken = cancellationToken;
			<Connect>d__.<>1__state = -1;
			<Connect>d__.<>t__builder.Start<WebConnection.<Connect>d__16>(ref <Connect>d__);
			return <Connect>d__.<>t__builder.Task;
		}

		// Token: 0x06000C73 RID: 3187 RVA: 0x00041078 File Offset: 0x0003F278
		private Task<bool> CreateStream(WebOperation operation, bool reused, CancellationToken cancellationToken)
		{
			WebConnection.<CreateStream>d__18 <CreateStream>d__;
			<CreateStream>d__.<>t__builder = AsyncTaskMethodBuilder<bool>.Create();
			<CreateStream>d__.<>4__this = this;
			<CreateStream>d__.operation = operation;
			<CreateStream>d__.reused = reused;
			<CreateStream>d__.cancellationToken = cancellationToken;
			<CreateStream>d__.<>1__state = -1;
			<CreateStream>d__.<>t__builder.Start<WebConnection.<CreateStream>d__18>(ref <CreateStream>d__);
			return <CreateStream>d__.<>t__builder.Task;
		}

		// Token: 0x06000C74 RID: 3188 RVA: 0x000410D4 File Offset: 0x0003F2D4
		internal Task<WebRequestStream> InitConnection(WebOperation operation, CancellationToken cancellationToken)
		{
			WebConnection.<InitConnection>d__19 <InitConnection>d__;
			<InitConnection>d__.<>t__builder = AsyncTaskMethodBuilder<WebRequestStream>.Create();
			<InitConnection>d__.<>4__this = this;
			<InitConnection>d__.operation = operation;
			<InitConnection>d__.cancellationToken = cancellationToken;
			<InitConnection>d__.<>1__state = -1;
			<InitConnection>d__.<>t__builder.Start<WebConnection.<InitConnection>d__19>(ref <InitConnection>d__);
			return <InitConnection>d__.<>t__builder.Task;
		}

		// Token: 0x06000C75 RID: 3189 RVA: 0x00041128 File Offset: 0x0003F328
		internal static WebException GetException(WebExceptionStatus status, Exception error)
		{
			if (error == null)
			{
				return new WebException(string.Format("Error: {0}", status), status);
			}
			WebException ex = error as WebException;
			if (ex != null)
			{
				return ex;
			}
			return new WebException(string.Format("Error: {0} ({1})", status, error.Message), status, WebExceptionInternalStatus.RequestFatal, error);
		}

		// Token: 0x06000C76 RID: 3190 RVA: 0x0004117C File Offset: 0x0003F37C
		internal static bool ReadLine(byte[] buffer, ref int start, int max, ref string output)
		{
			bool flag = false;
			StringBuilder stringBuilder = new StringBuilder();
			int num = 0;
			while (start < max)
			{
				int num2 = start;
				start = num2 + 1;
				num = (int)buffer[num2];
				if (num == 10)
				{
					if (stringBuilder.Length > 0 && stringBuilder[stringBuilder.Length - 1] == '\r')
					{
						StringBuilder stringBuilder2 = stringBuilder;
						num2 = stringBuilder2.Length;
						stringBuilder2.Length = num2 - 1;
					}
					flag = false;
					break;
				}
				if (flag)
				{
					StringBuilder stringBuilder3 = stringBuilder;
					num2 = stringBuilder3.Length;
					stringBuilder3.Length = num2 - 1;
					break;
				}
				if (num == 13)
				{
					flag = true;
				}
				stringBuilder.Append((char)num);
			}
			if (num != 10 && num != 13)
			{
				return false;
			}
			if (stringBuilder.Length == 0)
			{
				output = null;
				return num == 10 || num == 13;
			}
			if (flag)
			{
				StringBuilder stringBuilder4 = stringBuilder;
				int num2 = stringBuilder4.Length;
				stringBuilder4.Length = num2 - 1;
			}
			output = stringBuilder.ToString();
			return true;
		}

		// Token: 0x06000C77 RID: 3191 RVA: 0x00041240 File Offset: 0x0003F440
		internal bool CanReuseConnection(WebOperation operation)
		{
			bool result;
			lock (this)
			{
				if (this.Closed || this.currentOperation != null)
				{
					result = false;
				}
				else if (!this.NtlmAuthenticated)
				{
					result = true;
				}
				else
				{
					NetworkCredential ntlmCredential = this.NtlmCredential;
					HttpWebRequest request = operation.Request;
					ICredentials credentials = (request.Proxy == null || request.Proxy.IsBypassed(request.RequestUri)) ? request.Credentials : request.Proxy.Credentials;
					NetworkCredential networkCredential = (credentials != null) ? credentials.GetCredential(request.RequestUri, "NTLM") : null;
					if (ntlmCredential == null || networkCredential == null || ntlmCredential.Domain != networkCredential.Domain || ntlmCredential.UserName != networkCredential.UserName || ntlmCredential.Password != networkCredential.Password)
					{
						result = false;
					}
					else
					{
						bool unsafeAuthenticatedConnectionSharing = request.UnsafeAuthenticatedConnectionSharing;
						bool unsafeAuthenticatedConnectionSharing2 = this.UnsafeAuthenticatedConnectionSharing;
						result = (unsafeAuthenticatedConnectionSharing && unsafeAuthenticatedConnectionSharing == unsafeAuthenticatedConnectionSharing2);
					}
				}
			}
			return result;
		}

		// Token: 0x06000C78 RID: 3192 RVA: 0x00041368 File Offset: 0x0003F568
		private bool PrepareSharingNtlm(WebOperation operation)
		{
			if (operation == null || !this.NtlmAuthenticated)
			{
				return true;
			}
			bool flag = false;
			NetworkCredential ntlmCredential = this.NtlmCredential;
			HttpWebRequest request = operation.Request;
			ICredentials credentials = (request.Proxy == null || request.Proxy.IsBypassed(request.RequestUri)) ? request.Credentials : request.Proxy.Credentials;
			NetworkCredential networkCredential = (credentials != null) ? credentials.GetCredential(request.RequestUri, "NTLM") : null;
			if (ntlmCredential == null || networkCredential == null || ntlmCredential.Domain != networkCredential.Domain || ntlmCredential.UserName != networkCredential.UserName || ntlmCredential.Password != networkCredential.Password)
			{
				flag = true;
			}
			if (!flag)
			{
				bool unsafeAuthenticatedConnectionSharing = request.UnsafeAuthenticatedConnectionSharing;
				bool unsafeAuthenticatedConnectionSharing2 = this.UnsafeAuthenticatedConnectionSharing;
				flag = (!unsafeAuthenticatedConnectionSharing || unsafeAuthenticatedConnectionSharing != unsafeAuthenticatedConnectionSharing2);
			}
			return flag;
		}

		// Token: 0x06000C79 RID: 3193 RVA: 0x0004144C File Offset: 0x0003F64C
		private void Reset()
		{
			lock (this)
			{
				this.tunnel = null;
				this.ResetNtlm();
			}
		}

		// Token: 0x06000C7A RID: 3194 RVA: 0x00041490 File Offset: 0x0003F690
		private void Close(bool reset)
		{
			lock (this)
			{
				this.CloseSocket();
				if (reset)
				{
					this.Reset();
				}
			}
		}

		// Token: 0x06000C7B RID: 3195 RVA: 0x000414D4 File Offset: 0x0003F6D4
		private void CloseSocket()
		{
			lock (this)
			{
				if (this.networkStream != null)
				{
					try
					{
						this.networkStream.Dispose();
					}
					catch
					{
					}
					this.networkStream = null;
				}
				if (this.monoTlsStream != null)
				{
					try
					{
						this.monoTlsStream.Dispose();
					}
					catch
					{
					}
					this.monoTlsStream = null;
				}
				if (this.socket != null)
				{
					try
					{
						this.socket.Dispose();
					}
					catch
					{
					}
					this.socket = null;
				}
				this.monoTlsStream = null;
			}
		}

		// Token: 0x1700027D RID: 637
		// (get) Token: 0x06000C7C RID: 3196 RVA: 0x00041594 File Offset: 0x0003F794
		public bool Closed
		{
			get
			{
				return this.disposed != 0;
			}
		}

		// Token: 0x1700027E RID: 638
		// (get) Token: 0x06000C7D RID: 3197 RVA: 0x0004159F File Offset: 0x0003F79F
		public DateTime IdleSince
		{
			get
			{
				return this.idleSince;
			}
		}

		// Token: 0x06000C7E RID: 3198 RVA: 0x000415A8 File Offset: 0x0003F7A8
		public bool StartOperation(WebOperation operation, bool reused)
		{
			lock (this)
			{
				if (this.Closed)
				{
					return false;
				}
				if (Interlocked.CompareExchange<WebOperation>(ref this.currentOperation, operation, null) != null)
				{
					return false;
				}
				this.idleSince = DateTime.UtcNow + TimeSpan.FromDays(3650.0);
				if (reused && !this.PrepareSharingNtlm(operation))
				{
					this.Close(true);
				}
				operation.RegisterRequest(this.ServicePoint, this);
			}
			operation.Run();
			return true;
		}

		// Token: 0x06000C7F RID: 3199 RVA: 0x00041644 File Offset: 0x0003F844
		public bool Continue(WebOperation next)
		{
			lock (this)
			{
				if (this.Closed)
				{
					return false;
				}
				if (this.socket == null || !this.socket.Connected || !this.PrepareSharingNtlm(next))
				{
					this.Close(true);
					return false;
				}
				this.currentOperation = next;
				if (next == null)
				{
					return true;
				}
				next.RegisterRequest(this.ServicePoint, this);
			}
			next.Run();
			return true;
		}

		// Token: 0x06000C80 RID: 3200 RVA: 0x000416D4 File Offset: 0x0003F8D4
		private void Dispose(bool disposing)
		{
			if (Interlocked.CompareExchange(ref this.disposed, 1, 0) != 0)
			{
				return;
			}
			this.Close(true);
		}

		// Token: 0x06000C81 RID: 3201 RVA: 0x000416ED File Offset: 0x0003F8ED
		public void Dispose()
		{
			this.Dispose(true);
		}

		// Token: 0x06000C82 RID: 3202 RVA: 0x000416F6 File Offset: 0x0003F8F6
		private void ResetNtlm()
		{
			this.ntlm_authenticated = false;
			this.ntlm_credentials = null;
			this.unsafe_sharing = false;
		}

		// Token: 0x1700027F RID: 639
		// (get) Token: 0x06000C83 RID: 3203 RVA: 0x0004170D File Offset: 0x0003F90D
		// (set) Token: 0x06000C84 RID: 3204 RVA: 0x00041715 File Offset: 0x0003F915
		internal bool NtlmAuthenticated
		{
			get
			{
				return this.ntlm_authenticated;
			}
			set
			{
				this.ntlm_authenticated = value;
			}
		}

		// Token: 0x17000280 RID: 640
		// (get) Token: 0x06000C85 RID: 3205 RVA: 0x0004171E File Offset: 0x0003F91E
		// (set) Token: 0x06000C86 RID: 3206 RVA: 0x00041726 File Offset: 0x0003F926
		internal NetworkCredential NtlmCredential
		{
			get
			{
				return this.ntlm_credentials;
			}
			set
			{
				this.ntlm_credentials = value;
			}
		}

		// Token: 0x17000281 RID: 641
		// (get) Token: 0x06000C87 RID: 3207 RVA: 0x0004172F File Offset: 0x0003F92F
		// (set) Token: 0x06000C88 RID: 3208 RVA: 0x00041737 File Offset: 0x0003F937
		internal bool UnsafeAuthenticatedConnectionSharing
		{
			get
			{
				return this.unsafe_sharing;
			}
			set
			{
				this.unsafe_sharing = value;
			}
		}

		// Token: 0x04000931 RID: 2353
		private NetworkCredential ntlm_credentials;

		// Token: 0x04000932 RID: 2354
		private bool ntlm_authenticated;

		// Token: 0x04000933 RID: 2355
		private bool unsafe_sharing;

		// Token: 0x04000934 RID: 2356
		private Stream networkStream;

		// Token: 0x04000935 RID: 2357
		private Socket socket;

		// Token: 0x04000936 RID: 2358
		private MonoTlsStream monoTlsStream;

		// Token: 0x04000937 RID: 2359
		private WebConnectionTunnel tunnel;

		// Token: 0x04000938 RID: 2360
		private int disposed;

		// Token: 0x0400093A RID: 2362
		private DateTime idleSince;

		// Token: 0x0400093B RID: 2363
		private WebOperation currentOperation;
	}
}
