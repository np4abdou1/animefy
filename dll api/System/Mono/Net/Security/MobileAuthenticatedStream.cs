using System;
using System.IO;
using System.Net;
using System.Net.Security;
using System.Runtime.CompilerServices;
using System.Runtime.ExceptionServices;
using System.Security.Authentication;
using System.Security.Cryptography.X509Certificates;
using System.Threading;
using System.Threading.Tasks;
using Mono.Security.Interface;

namespace Mono.Net.Security
{
	// Token: 0x02000015 RID: 21
	internal abstract class MobileAuthenticatedStream : AuthenticatedStream, IDisposable
	{
		// Token: 0x06000059 RID: 89 RVA: 0x000033D8 File Offset: 0x000015D8
		public MobileAuthenticatedStream(Stream innerStream, bool leaveInnerStreamOpen, SslStream owner, MonoTlsSettings settings, MobileTlsProvider provider) : base(innerStream, leaveInnerStreamOpen)
		{
			this.SslStream = owner;
			this.Settings = settings;
			this.Provider = provider;
			this.readBuffer = new BufferOffsetSize2(16500);
			this.writeBuffer = new BufferOffsetSize2(16384);
			this.operation = MobileAuthenticatedStream.Operation.None;
		}

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x0600005A RID: 90 RVA: 0x00003449 File Offset: 0x00001649
		public SslStream SslStream { get; }

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x0600005B RID: 91 RVA: 0x00003451 File Offset: 0x00001651
		public MonoTlsSettings Settings { get; }

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x0600005C RID: 92 RVA: 0x00003459 File Offset: 0x00001659
		public MobileTlsProvider Provider { get; }

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x0600005D RID: 93 RVA: 0x00003461 File Offset: 0x00001661
		// (set) Token: 0x0600005E RID: 94 RVA: 0x00003469 File Offset: 0x00001669
		internal string TargetHost { get; private set; }

		// Token: 0x0600005F RID: 95 RVA: 0x00003474 File Offset: 0x00001674
		internal void CheckThrow(bool authSuccessCheck, bool shutdownCheck = false)
		{
			if (this.lastException != null)
			{
				this.lastException.Throw();
			}
			if (authSuccessCheck && !this.IsAuthenticated)
			{
				throw new InvalidOperationException("This operation is only allowed using a successfully authenticated context.");
			}
			if (shutdownCheck && this.shutdown)
			{
				throw new InvalidOperationException("Write operations are not allowed after the channel was shutdown.");
			}
		}

		// Token: 0x06000060 RID: 96 RVA: 0x000034C0 File Offset: 0x000016C0
		internal static Exception GetSSPIException(Exception e)
		{
			if (e is OperationCanceledException || e is IOException || e is ObjectDisposedException || e is AuthenticationException || e is NotSupportedException)
			{
				return e;
			}
			return new AuthenticationException("Authentication failed, see inner exception.", e);
		}

		// Token: 0x06000061 RID: 97 RVA: 0x000034F7 File Offset: 0x000016F7
		internal static Exception GetIOException(Exception e, string message)
		{
			if (e is OperationCanceledException || e is IOException || e is ObjectDisposedException || e is AuthenticationException || e is NotSupportedException)
			{
				return e;
			}
			return new IOException(message, e);
		}

		// Token: 0x06000062 RID: 98 RVA: 0x0000352A File Offset: 0x0000172A
		internal static Exception GetInternalError()
		{
			throw new InvalidOperationException("Internal error.");
		}

		// Token: 0x06000063 RID: 99 RVA: 0x00003536 File Offset: 0x00001736
		internal static Exception GetInvalidNestedCallException()
		{
			throw new InvalidOperationException("Invalid nested call.");
		}

		// Token: 0x06000064 RID: 100 RVA: 0x00003544 File Offset: 0x00001744
		internal ExceptionDispatchInfo SetException(Exception e)
		{
			ExceptionDispatchInfo exceptionDispatchInfo = ExceptionDispatchInfo.Capture(e);
			return Interlocked.CompareExchange<ExceptionDispatchInfo>(ref this.lastException, exceptionDispatchInfo, null) ?? exceptionDispatchInfo;
		}

		// Token: 0x06000065 RID: 101 RVA: 0x0000356C File Offset: 0x0000176C
		public void AuthenticateAsClient(string targetHost, X509CertificateCollection clientCertificates, SslProtocols enabledSslProtocols, bool checkCertificateRevocation)
		{
			MonoSslClientAuthenticationOptions options = new MonoSslClientAuthenticationOptions
			{
				TargetHost = targetHost,
				ClientCertificates = clientCertificates,
				EnabledSslProtocols = enabledSslProtocols,
				CertificateRevocationCheckMode = (checkCertificateRevocation ? X509RevocationMode.Online : X509RevocationMode.NoCheck),
				EncryptionPolicy = EncryptionPolicy.RequireEncryption
			};
			Task task = this.ProcessAuthentication(true, options, CancellationToken.None);
			try
			{
				task.Wait();
			}
			catch (Exception e)
			{
				throw HttpWebRequest.FlattenException(e);
			}
		}

		// Token: 0x06000066 RID: 102 RVA: 0x000035D8 File Offset: 0x000017D8
		public Task AuthenticateAsClientAsync(string targetHost, X509CertificateCollection clientCertificates, SslProtocols enabledSslProtocols, bool checkCertificateRevocation)
		{
			MonoSslClientAuthenticationOptions options = new MonoSslClientAuthenticationOptions
			{
				TargetHost = targetHost,
				ClientCertificates = clientCertificates,
				EnabledSslProtocols = enabledSslProtocols,
				CertificateRevocationCheckMode = (checkCertificateRevocation ? X509RevocationMode.Online : X509RevocationMode.NoCheck),
				EncryptionPolicy = EncryptionPolicy.RequireEncryption
			};
			return this.ProcessAuthentication(false, options, CancellationToken.None);
		}

		// Token: 0x06000067 RID: 103 RVA: 0x00003624 File Offset: 0x00001824
		private Task ProcessAuthentication(bool runSynchronously, MonoSslAuthenticationOptions options, CancellationToken cancellationToken)
		{
			MobileAuthenticatedStream.<ProcessAuthentication>d__48 <ProcessAuthentication>d__;
			<ProcessAuthentication>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<ProcessAuthentication>d__.<>4__this = this;
			<ProcessAuthentication>d__.runSynchronously = runSynchronously;
			<ProcessAuthentication>d__.options = options;
			<ProcessAuthentication>d__.cancellationToken = cancellationToken;
			<ProcessAuthentication>d__.<>1__state = -1;
			<ProcessAuthentication>d__.<>t__builder.Start<MobileAuthenticatedStream.<ProcessAuthentication>d__48>(ref <ProcessAuthentication>d__);
			return <ProcessAuthentication>d__.<>t__builder.Task;
		}

		// Token: 0x06000068 RID: 104
		protected abstract MobileTlsContext CreateContext(MonoSslAuthenticationOptions options);

		// Token: 0x06000069 RID: 105 RVA: 0x00003680 File Offset: 0x00001880
		public override int Read(byte[] buffer, int offset, int count)
		{
			AsyncReadRequest asyncRequest = new AsyncReadRequest(this, true, buffer, offset, count);
			return this.StartOperation(MobileAuthenticatedStream.OperationType.Read, asyncRequest, CancellationToken.None).Result;
		}

		// Token: 0x0600006A RID: 106 RVA: 0x000036AC File Offset: 0x000018AC
		public override void Write(byte[] buffer, int offset, int count)
		{
			AsyncWriteRequest asyncRequest = new AsyncWriteRequest(this, true, buffer, offset, count);
			this.StartOperation(MobileAuthenticatedStream.OperationType.Write, asyncRequest, CancellationToken.None).Wait();
		}

		// Token: 0x0600006B RID: 107 RVA: 0x000036D8 File Offset: 0x000018D8
		public override Task<int> ReadAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken)
		{
			AsyncReadRequest asyncRequest = new AsyncReadRequest(this, false, buffer, offset, count);
			return this.StartOperation(MobileAuthenticatedStream.OperationType.Read, asyncRequest, cancellationToken);
		}

		// Token: 0x0600006C RID: 108 RVA: 0x000036FC File Offset: 0x000018FC
		public override Task WriteAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken)
		{
			AsyncWriteRequest asyncRequest = new AsyncWriteRequest(this, false, buffer, offset, count);
			return this.StartOperation(MobileAuthenticatedStream.OperationType.Write, asyncRequest, cancellationToken);
		}

		// Token: 0x0600006D RID: 109 RVA: 0x00003720 File Offset: 0x00001920
		private Task<int> StartOperation(MobileAuthenticatedStream.OperationType type, AsyncProtocolRequest asyncRequest, CancellationToken cancellationToken)
		{
			MobileAuthenticatedStream.<StartOperation>d__57 <StartOperation>d__;
			<StartOperation>d__.<>t__builder = AsyncTaskMethodBuilder<int>.Create();
			<StartOperation>d__.<>4__this = this;
			<StartOperation>d__.type = type;
			<StartOperation>d__.asyncRequest = asyncRequest;
			<StartOperation>d__.cancellationToken = cancellationToken;
			<StartOperation>d__.<>1__state = -1;
			<StartOperation>d__.<>t__builder.Start<MobileAuthenticatedStream.<StartOperation>d__57>(ref <StartOperation>d__);
			return <StartOperation>d__.<>t__builder.Task;
		}

		// Token: 0x0600006E RID: 110 RVA: 0x0000377C File Offset: 0x0000197C
		internal int InternalRead(byte[] buffer, int offset, int size, out bool outWantMore)
		{
			int result;
			try
			{
				AsyncProtocolRequest asyncRequest = this.asyncHandshakeRequest ?? this.asyncReadRequest;
				ValueTuple<int, bool> valueTuple = this.InternalRead(asyncRequest, this.readBuffer, buffer, offset, size);
				int item = valueTuple.Item1;
				bool item2 = valueTuple.Item2;
				outWantMore = item2;
				result = item;
			}
			catch (Exception e)
			{
				this.SetException(MobileAuthenticatedStream.GetIOException(e, "InternalRead() failed"));
				outWantMore = false;
				result = -1;
			}
			return result;
		}

		// Token: 0x0600006F RID: 111 RVA: 0x000037F0 File Offset: 0x000019F0
		private ValueTuple<int, bool> InternalRead(AsyncProtocolRequest asyncRequest, BufferOffsetSize internalBuffer, byte[] buffer, int offset, int size)
		{
			if (asyncRequest == null)
			{
				throw new InvalidOperationException();
			}
			if (internalBuffer.Size == 0 && !internalBuffer.Complete)
			{
				internalBuffer.Offset = (internalBuffer.Size = 0);
				asyncRequest.RequestRead(size);
				return new ValueTuple<int, bool>(0, true);
			}
			int num = Math.Min(internalBuffer.Size, size);
			Buffer.BlockCopy(internalBuffer.Buffer, internalBuffer.Offset, buffer, offset, num);
			internalBuffer.Offset += num;
			internalBuffer.Size -= num;
			return new ValueTuple<int, bool>(num, !internalBuffer.Complete && num < size);
		}

		// Token: 0x06000070 RID: 112 RVA: 0x0000388C File Offset: 0x00001A8C
		internal bool InternalWrite(byte[] buffer, int offset, int size)
		{
			bool result;
			try
			{
				AsyncProtocolRequest asyncProtocolRequest;
				switch (this.operation)
				{
				case MobileAuthenticatedStream.Operation.Handshake:
				case MobileAuthenticatedStream.Operation.Renegotiate:
					asyncProtocolRequest = this.asyncHandshakeRequest;
					goto IL_57;
				case MobileAuthenticatedStream.Operation.Read:
					asyncProtocolRequest = this.asyncReadRequest;
					if (this.xobileTlsContext.PendingRenegotiation())
					{
						goto IL_57;
					}
					goto IL_57;
				case MobileAuthenticatedStream.Operation.Write:
				case MobileAuthenticatedStream.Operation.Close:
					asyncProtocolRequest = this.asyncWriteRequest;
					goto IL_57;
				}
				throw MobileAuthenticatedStream.GetInternalError();
				IL_57:
				if (asyncProtocolRequest == null && this.operation != MobileAuthenticatedStream.Operation.Close)
				{
					throw MobileAuthenticatedStream.GetInternalError();
				}
				result = this.InternalWrite(asyncProtocolRequest, this.writeBuffer, buffer, offset, size);
			}
			catch (Exception e)
			{
				this.SetException(MobileAuthenticatedStream.GetIOException(e, "InternalWrite() failed"));
				result = false;
			}
			return result;
		}

		// Token: 0x06000071 RID: 113 RVA: 0x00003940 File Offset: 0x00001B40
		private bool InternalWrite(AsyncProtocolRequest asyncRequest, BufferOffsetSize2 internalBuffer, byte[] buffer, int offset, int size)
		{
			if (asyncRequest == null)
			{
				if (this.lastException != null)
				{
					return false;
				}
				if (Interlocked.Exchange(ref this.closeRequested, 1) == 0)
				{
					internalBuffer.Reset();
				}
				else if (internalBuffer.Remaining == 0)
				{
					throw new InvalidOperationException();
				}
			}
			internalBuffer.AppendData(buffer, offset, size);
			if (asyncRequest != null)
			{
				asyncRequest.RequestWrite();
			}
			return true;
		}

		// Token: 0x06000072 RID: 114 RVA: 0x00003994 File Offset: 0x00001B94
		internal Task<int> InnerRead(bool sync, int requestedSize, CancellationToken cancellationToken)
		{
			MobileAuthenticatedStream.<InnerRead>d__66 <InnerRead>d__;
			<InnerRead>d__.<>t__builder = AsyncTaskMethodBuilder<int>.Create();
			<InnerRead>d__.<>4__this = this;
			<InnerRead>d__.sync = sync;
			<InnerRead>d__.requestedSize = requestedSize;
			<InnerRead>d__.cancellationToken = cancellationToken;
			<InnerRead>d__.<>1__state = -1;
			<InnerRead>d__.<>t__builder.Start<MobileAuthenticatedStream.<InnerRead>d__66>(ref <InnerRead>d__);
			return <InnerRead>d__.<>t__builder.Task;
		}

		// Token: 0x06000073 RID: 115 RVA: 0x000039F0 File Offset: 0x00001BF0
		internal Task InnerWrite(bool sync, CancellationToken cancellationToken)
		{
			MobileAuthenticatedStream.<InnerWrite>d__67 <InnerWrite>d__;
			<InnerWrite>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<InnerWrite>d__.<>4__this = this;
			<InnerWrite>d__.sync = sync;
			<InnerWrite>d__.cancellationToken = cancellationToken;
			<InnerWrite>d__.<>1__state = -1;
			<InnerWrite>d__.<>t__builder.Start<MobileAuthenticatedStream.<InnerWrite>d__67>(ref <InnerWrite>d__);
			return <InnerWrite>d__.<>t__builder.Task;
		}

		// Token: 0x06000074 RID: 116 RVA: 0x00003A44 File Offset: 0x00001C44
		internal AsyncOperationStatus ProcessHandshake(AsyncOperationStatus status, bool renegotiate)
		{
			object obj = this.ioLock;
			AsyncOperationStatus result;
			lock (obj)
			{
				switch (this.operation)
				{
				case MobileAuthenticatedStream.Operation.None:
					if (renegotiate)
					{
						throw MobileAuthenticatedStream.GetInternalError();
					}
					this.operation = MobileAuthenticatedStream.Operation.Handshake;
					break;
				case MobileAuthenticatedStream.Operation.Handshake:
				case MobileAuthenticatedStream.Operation.Renegotiate:
					break;
				case MobileAuthenticatedStream.Operation.Authenticated:
					if (!renegotiate)
					{
						throw MobileAuthenticatedStream.GetInternalError();
					}
					this.operation = MobileAuthenticatedStream.Operation.Renegotiate;
					break;
				default:
					throw MobileAuthenticatedStream.GetInternalError();
				}
				switch (status)
				{
				case AsyncOperationStatus.Initialize:
					if (renegotiate)
					{
						this.xobileTlsContext.Renegotiate();
					}
					else
					{
						this.xobileTlsContext.StartHandshake();
					}
					result = AsyncOperationStatus.Continue;
					break;
				case AsyncOperationStatus.Continue:
				{
					AsyncOperationStatus asyncOperationStatus = AsyncOperationStatus.Continue;
					try
					{
						if (this.xobileTlsContext.ProcessHandshake())
						{
							this.xobileTlsContext.FinishHandshake();
							this.operation = MobileAuthenticatedStream.Operation.Authenticated;
							asyncOperationStatus = AsyncOperationStatus.Complete;
						}
					}
					catch (Exception e)
					{
						this.SetException(MobileAuthenticatedStream.GetSSPIException(e));
						base.Dispose();
						throw;
					}
					if (this.lastException != null)
					{
						this.lastException.Throw();
					}
					result = asyncOperationStatus;
					break;
				}
				case AsyncOperationStatus.ReadDone:
					throw new IOException("Authentication failed because the remote party has closed the transport stream.");
				default:
					throw new InvalidOperationException();
				}
			}
			return result;
		}

		// Token: 0x06000075 RID: 117 RVA: 0x00003B70 File Offset: 0x00001D70
		[return: TupleElementNames(new string[]
		{
			"ret",
			"wantMore"
		})]
		internal ValueTuple<int, bool> ProcessRead(BufferOffsetSize userBuffer)
		{
			object obj = this.ioLock;
			ValueTuple<int, bool> result;
			lock (obj)
			{
				if (this.operation != MobileAuthenticatedStream.Operation.Authenticated)
				{
					throw MobileAuthenticatedStream.GetInternalError();
				}
				this.operation = MobileAuthenticatedStream.Operation.Read;
				ValueTuple<int, bool> valueTuple = this.xobileTlsContext.Read(userBuffer.Buffer, userBuffer.Offset, userBuffer.Size);
				if (this.lastException != null)
				{
					this.lastException.Throw();
				}
				this.operation = MobileAuthenticatedStream.Operation.Authenticated;
				result = valueTuple;
			}
			return result;
		}

		// Token: 0x06000076 RID: 118 RVA: 0x00003BFC File Offset: 0x00001DFC
		[return: TupleElementNames(new string[]
		{
			"ret",
			"wantMore"
		})]
		internal ValueTuple<int, bool> ProcessWrite(BufferOffsetSize userBuffer)
		{
			object obj = this.ioLock;
			ValueTuple<int, bool> result;
			lock (obj)
			{
				if (this.operation != MobileAuthenticatedStream.Operation.Authenticated)
				{
					throw MobileAuthenticatedStream.GetInternalError();
				}
				this.operation = MobileAuthenticatedStream.Operation.Write;
				ValueTuple<int, bool> valueTuple = this.xobileTlsContext.Write(userBuffer.Buffer, userBuffer.Offset, userBuffer.Size);
				if (this.lastException != null)
				{
					this.lastException.Throw();
				}
				this.operation = MobileAuthenticatedStream.Operation.Authenticated;
				result = valueTuple;
			}
			return result;
		}

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x06000077 RID: 119 RVA: 0x00003C88 File Offset: 0x00001E88
		public override bool IsAuthenticated
		{
			get
			{
				object obj = this.ioLock;
				bool result;
				lock (obj)
				{
					result = (this.xobileTlsContext != null && this.lastException == null && this.xobileTlsContext.IsAuthenticated);
				}
				return result;
			}
		}

		// Token: 0x06000078 RID: 120 RVA: 0x00003CE4 File Offset: 0x00001EE4
		protected override void Dispose(bool disposing)
		{
			try
			{
				object obj = this.ioLock;
				lock (obj)
				{
					this.SetException(new ObjectDisposedException("MobileAuthenticatedStream"));
					if (this.xobileTlsContext != null)
					{
						this.xobileTlsContext.Dispose();
						this.xobileTlsContext = null;
					}
				}
			}
			finally
			{
				base.Dispose(disposing);
			}
		}

		// Token: 0x06000079 RID: 121 RVA: 0x00003D60 File Offset: 0x00001F60
		public override void Flush()
		{
			base.InnerStream.Flush();
		}

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x0600007A RID: 122 RVA: 0x00003D70 File Offset: 0x00001F70
		public X509Certificate LocalCertificate
		{
			get
			{
				object obj = this.ioLock;
				X509Certificate internalLocalCertificate;
				lock (obj)
				{
					this.CheckThrow(true, false);
					internalLocalCertificate = this.InternalLocalCertificate;
				}
				return internalLocalCertificate;
			}
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x0600007B RID: 123 RVA: 0x00003DBC File Offset: 0x00001FBC
		public X509Certificate InternalLocalCertificate
		{
			get
			{
				object obj = this.ioLock;
				X509Certificate result;
				lock (obj)
				{
					this.CheckThrow(false, false);
					if (this.xobileTlsContext == null)
					{
						result = null;
					}
					else
					{
						result = (this.xobileTlsContext.IsServer ? this.xobileTlsContext.LocalServerCertificate : this.xobileTlsContext.LocalClientCertificate);
					}
				}
				return result;
			}
		}

		// Token: 0x0600007C RID: 124 RVA: 0x00003E34 File Offset: 0x00002034
		public override long Seek(long offset, SeekOrigin origin)
		{
			throw new NotSupportedException();
		}

		// Token: 0x0600007D RID: 125 RVA: 0x00003E3B File Offset: 0x0000203B
		public override void SetLength(long value)
		{
			base.InnerStream.SetLength(value);
		}

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x0600007E RID: 126 RVA: 0x00003E49 File Offset: 0x00002049
		public override bool CanRead
		{
			get
			{
				return this.IsAuthenticated && base.InnerStream.CanRead;
			}
		}

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x0600007F RID: 127 RVA: 0x00003E60 File Offset: 0x00002060
		public override bool CanTimeout
		{
			get
			{
				return base.InnerStream.CanTimeout;
			}
		}

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x06000080 RID: 128 RVA: 0x00003E6D File Offset: 0x0000206D
		public override bool CanWrite
		{
			get
			{
				return (this.IsAuthenticated & base.InnerStream.CanWrite) && !this.shutdown;
			}
		}

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x06000081 RID: 129 RVA: 0x000023F6 File Offset: 0x000005F6
		public override bool CanSeek
		{
			get
			{
				return false;
			}
		}

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x06000082 RID: 130 RVA: 0x00003E8E File Offset: 0x0000208E
		public override long Length
		{
			get
			{
				return base.InnerStream.Length;
			}
		}

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x06000083 RID: 131 RVA: 0x00003E9B File Offset: 0x0000209B
		// (set) Token: 0x06000084 RID: 132 RVA: 0x00003E34 File Offset: 0x00002034
		public override long Position
		{
			get
			{
				return base.InnerStream.Position;
			}
			set
			{
				throw new NotSupportedException();
			}
		}

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x06000085 RID: 133 RVA: 0x00003EA8 File Offset: 0x000020A8
		// (set) Token: 0x06000086 RID: 134 RVA: 0x00003EB5 File Offset: 0x000020B5
		public override int ReadTimeout
		{
			get
			{
				return base.InnerStream.ReadTimeout;
			}
			set
			{
				base.InnerStream.ReadTimeout = value;
			}
		}

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x06000087 RID: 135 RVA: 0x00003EC3 File Offset: 0x000020C3
		// (set) Token: 0x06000088 RID: 136 RVA: 0x00003ED0 File Offset: 0x000020D0
		public override int WriteTimeout
		{
			get
			{
				return base.InnerStream.WriteTimeout;
			}
			set
			{
				base.InnerStream.WriteTimeout = value;
			}
		}

		// Token: 0x0400003B RID: 59
		private MobileTlsContext xobileTlsContext;

		// Token: 0x0400003C RID: 60
		private ExceptionDispatchInfo lastException;

		// Token: 0x0400003D RID: 61
		private AsyncProtocolRequest asyncHandshakeRequest;

		// Token: 0x0400003E RID: 62
		private AsyncProtocolRequest asyncReadRequest;

		// Token: 0x0400003F RID: 63
		private AsyncProtocolRequest asyncWriteRequest;

		// Token: 0x04000040 RID: 64
		private BufferOffsetSize2 readBuffer;

		// Token: 0x04000041 RID: 65
		private BufferOffsetSize2 writeBuffer;

		// Token: 0x04000042 RID: 66
		private object ioLock = new object();

		// Token: 0x04000043 RID: 67
		private int closeRequested;

		// Token: 0x04000044 RID: 68
		private bool shutdown;

		// Token: 0x04000045 RID: 69
		private MobileAuthenticatedStream.Operation operation;

		// Token: 0x04000046 RID: 70
		private static int uniqueNameInteger = 123;

		// Token: 0x0400004B RID: 75
		private static int nextId;

		// Token: 0x0400004C RID: 76
		internal readonly int ID = ++MobileAuthenticatedStream.nextId;

		// Token: 0x02000016 RID: 22
		private enum Operation
		{
			// Token: 0x0400004E RID: 78
			None,
			// Token: 0x0400004F RID: 79
			Handshake,
			// Token: 0x04000050 RID: 80
			Authenticated,
			// Token: 0x04000051 RID: 81
			Renegotiate,
			// Token: 0x04000052 RID: 82
			Read,
			// Token: 0x04000053 RID: 83
			Write,
			// Token: 0x04000054 RID: 84
			Close
		}

		// Token: 0x02000017 RID: 23
		private enum OperationType
		{
			// Token: 0x04000056 RID: 86
			Read,
			// Token: 0x04000057 RID: 87
			Write,
			// Token: 0x04000058 RID: 88
			Renegotiate,
			// Token: 0x04000059 RID: 89
			Shutdown
		}
	}
}
