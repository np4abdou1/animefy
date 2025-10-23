using System;
using System.IO;
using System.Security.Authentication;
using System.Security.Cryptography.X509Certificates;
using System.Threading;
using System.Threading.Tasks;
using Mono.Net.Security;
using Mono.Net.Security.Private;
using Mono.Security.Interface;

namespace System.Net.Security
{
	/// <summary>Provides a stream used for client-server communication that uses the Secure Socket Layer (SSL) security protocol to authenticate the server and optionally the client.</summary>
	// Token: 0x02000224 RID: 548
	public class SslStream : AuthenticatedStream
	{
		// Token: 0x170002F6 RID: 758
		// (get) Token: 0x06000EC8 RID: 3784 RVA: 0x0004BCB8 File Offset: 0x00049EB8
		internal MobileAuthenticatedStream Impl
		{
			get
			{
				this.CheckDisposed();
				return this.impl;
			}
		}

		// Token: 0x170002F7 RID: 759
		// (get) Token: 0x06000EC9 RID: 3785 RVA: 0x0004BCC6 File Offset: 0x00049EC6
		internal string InternalTargetHost
		{
			get
			{
				this.CheckDisposed();
				return this.impl.TargetHost;
			}
		}

		// Token: 0x06000ECA RID: 3786 RVA: 0x0004BCD9 File Offset: 0x00049ED9
		private static MobileTlsProvider GetProvider()
		{
			return (MobileTlsProvider)Mono.Security.Interface.MonoTlsProviderFactory.GetProvider();
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Net.Security.SslStream" /> class using the specified <see cref="T:System.IO.Stream" />, stream closure behavior and certificate validation delegate.</summary>
		/// <param name="innerStream">A <see cref="T:System.IO.Stream" /> object used by the <see cref="T:System.Net.Security.SslStream" /> for sending and receiving data.</param>
		/// <param name="leaveInnerStreamOpen">A Boolean value that indicates the closure behavior of the <see cref="T:System.IO.Stream" /> object used by the <see cref="T:System.Net.Security.SslStream" /> for sending and receiving data. This parameter indicates if the inner stream is left open.</param>
		/// <param name="userCertificateValidationCallback">A <see cref="T:System.Net.Security.RemoteCertificateValidationCallback" /> delegate responsible for validating the certificate supplied by the remote party.</param>
		/// <exception cref="T:System.ArgumentException">
		///         <paramref name="innerStream" /> is not readable.-or-
		///         <paramref name="innerStream" /> is not writable.</exception>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="innerStream" /> is <see langword="null" />.-or-
		///         <paramref name="innerStream" /> is equal to <see cref="F:System.IO.Stream.Null" />.</exception>
		// Token: 0x06000ECB RID: 3787 RVA: 0x0004BCE5 File Offset: 0x00049EE5
		public SslStream(Stream innerStream, bool leaveInnerStreamOpen, RemoteCertificateValidationCallback userCertificateValidationCallback) : this(innerStream, leaveInnerStreamOpen, userCertificateValidationCallback, null)
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Net.Security.SslStream" /> class using the specified <see cref="T:System.IO.Stream" />, stream closure behavior, certificate validation delegate and certificate selection delegate.</summary>
		/// <param name="innerStream">A <see cref="T:System.IO.Stream" /> object used by the <see cref="T:System.Net.Security.SslStream" /> for sending and receiving data.</param>
		/// <param name="leaveInnerStreamOpen">A Boolean value that indicates the closure behavior of the <see cref="T:System.IO.Stream" /> object used by the <see cref="T:System.Net.Security.SslStream" /> for sending and receiving data. This parameter indicates if the inner stream is left open.</param>
		/// <param name="userCertificateValidationCallback">A <see cref="T:System.Net.Security.RemoteCertificateValidationCallback" /> delegate responsible for validating the certificate supplied by the remote party.</param>
		/// <param name="userCertificateSelectionCallback">A <see cref="T:System.Net.Security.LocalCertificateSelectionCallback" /> delegate responsible for selecting the certificate used for authentication.</param>
		/// <exception cref="T:System.ArgumentException">
		///         <paramref name="innerStream" /> is not readable.-or-
		///         <paramref name="innerStream" /> is not writable.</exception>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="innerStream" /> is <see langword="null" />.-or-
		///         <paramref name="innerStream" /> is equal to <see cref="F:System.IO.Stream.Null" />.</exception>
		// Token: 0x06000ECC RID: 3788 RVA: 0x0004BCF4 File Offset: 0x00049EF4
		public SslStream(Stream innerStream, bool leaveInnerStreamOpen, RemoteCertificateValidationCallback userCertificateValidationCallback, LocalCertificateSelectionCallback userCertificateSelectionCallback) : base(innerStream, leaveInnerStreamOpen)
		{
			this.provider = SslStream.GetProvider();
			this.settings = MonoTlsSettings.CopyDefaultSettings();
			this.SetAndVerifyValidationCallback(userCertificateValidationCallback);
			this.SetAndVerifySelectionCallback(userCertificateSelectionCallback);
			this.impl = this.provider.CreateSslStream(this, innerStream, leaveInnerStreamOpen, this.settings);
		}

		// Token: 0x06000ECD RID: 3789 RVA: 0x0004BD48 File Offset: 0x00049F48
		internal SslStream(Stream innerStream, bool leaveInnerStreamOpen, MonoTlsProvider provider, MonoTlsSettings settings) : base(innerStream, leaveInnerStreamOpen)
		{
			this.provider = (MobileTlsProvider)provider;
			this.settings = settings.Clone();
			this.explicitSettings = true;
			this.impl = this.provider.CreateSslStream(this, innerStream, leaveInnerStreamOpen, settings);
		}

		// Token: 0x06000ECE RID: 3790 RVA: 0x0004BD88 File Offset: 0x00049F88
		private void SetAndVerifyValidationCallback(RemoteCertificateValidationCallback callback)
		{
			if (this.validationCallback == null)
			{
				this.validationCallback = callback;
				this.settings.RemoteCertificateValidationCallback = CallbackHelpers.PublicToMono(callback);
				return;
			}
			if ((callback != null && this.validationCallback != callback) || (this.explicitSettings & this.settings.RemoteCertificateValidationCallback != null))
			{
				throw new InvalidOperationException(SR.Format("The '{0}' option was already set in the SslStream constructor.", "RemoteCertificateValidationCallback"));
			}
		}

		// Token: 0x06000ECF RID: 3791 RVA: 0x0004BDF4 File Offset: 0x00049FF4
		private void SetAndVerifySelectionCallback(LocalCertificateSelectionCallback callback)
		{
			if (this.selectionCallback == null)
			{
				this.selectionCallback = callback;
				if (callback == null)
				{
					this.settings.ClientCertificateSelectionCallback = null;
					return;
				}
				this.settings.ClientCertificateSelectionCallback = ((string t, X509CertificateCollection lc, X509Certificate rc, string[] ai) => callback(this, t, lc, rc, ai));
				return;
			}
			else
			{
				if ((callback != null && this.selectionCallback != callback) || (this.explicitSettings && this.settings.ClientCertificateSelectionCallback != null))
				{
					throw new InvalidOperationException(SR.Format("The '{0}' option was already set in the SslStream constructor.", "LocalCertificateSelectionCallback"));
				}
				return;
			}
		}

		/// <summary>Called by clients to authenticate the server and optionally the client in a client-server connection. The authentication process uses the specified certificate collection and SSL protocol.</summary>
		/// <param name="targetHost">The name of the server that will share this <see cref="T:System.Net.Security.SslStream" />.</param>
		/// <param name="clientCertificates">The <see cref="T:System.Security.Cryptography.X509Certificates.X509CertificateCollection" /> that contains client certificates.</param>
		/// <param name="enabledSslProtocols">The <see cref="T:System.Security.Authentication.SslProtocols" /> value that represents the protocol used for authentication.</param>
		/// <param name="checkCertificateRevocation">A <see cref="T:System.Boolean" /> value that specifies whether the certificate revocation list is checked during authentication.</param>
		// Token: 0x06000ED0 RID: 3792 RVA: 0x0004BE9B File Offset: 0x0004A09B
		public virtual void AuthenticateAsClient(string targetHost, X509CertificateCollection clientCertificates, SslProtocols enabledSslProtocols, bool checkCertificateRevocation)
		{
			this.Impl.AuthenticateAsClient(targetHost, clientCertificates, enabledSslProtocols, checkCertificateRevocation);
		}

		/// <summary>Called by clients to begin an asynchronous operation to authenticate the server and optionally the client using the specified certificates and security protocol.</summary>
		/// <param name="targetHost">The name of the server that shares this <see cref="T:System.Net.Security.SslStream" />.</param>
		/// <param name="clientCertificates">The <see cref="T:System.Security.Cryptography.X509Certificates.X509CertificateCollection" /> containing client certificates.</param>
		/// <param name="enabledSslProtocols">The <see cref="T:System.Security.Authentication.SslProtocols" /> value that represents the protocol used for authentication.</param>
		/// <param name="checkCertificateRevocation">A <see cref="T:System.Boolean" /> value that specifies whether the certificate revocation list is checked during authentication.</param>
		/// <param name="asyncCallback">An <see cref="T:System.AsyncCallback" /> delegate that references the method to invoke when the authentication is complete. </param>
		/// <param name="asyncState">A user-defined object that contains information about the operation. This object is passed to the <paramref name="asyncCallback" /> delegate when the operation completes.</param>
		/// <returns>An <see cref="T:System.IAsyncResult" /> object that indicates the status of the asynchronous operation. </returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="targetHost" /> is <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">
		///         <paramref name="enabledSslProtocols" /> is not a valid <see cref="T:System.Security.Authentication.SslProtocols" />  value.</exception>
		/// <exception cref="T:System.Security.Authentication.AuthenticationException">The authentication failed and left this object in an unusable state.</exception>
		/// <exception cref="T:System.InvalidOperationException">Authentication has already occurred.-or-Server authentication using this <see cref="T:System.Net.Security.SslStream" /> was tried previously.-or- Authentication is already in progress.</exception>
		/// <exception cref="T:System.ObjectDisposedException">This object has been closed.</exception>
		// Token: 0x06000ED1 RID: 3793 RVA: 0x0004BEAD File Offset: 0x0004A0AD
		public virtual IAsyncResult BeginAuthenticateAsClient(string targetHost, X509CertificateCollection clientCertificates, SslProtocols enabledSslProtocols, bool checkCertificateRevocation, AsyncCallback asyncCallback, object asyncState)
		{
			return TaskToApm.Begin(this.Impl.AuthenticateAsClientAsync(targetHost, clientCertificates, enabledSslProtocols, checkCertificateRevocation), asyncCallback, asyncState);
		}

		/// <summary>Ends a pending asynchronous server authentication operation started with a previous call to <see cref="Overload:System.Net.Security.SslStream.BeginAuthenticateAsServer" />.</summary>
		/// <param name="asyncResult">An <see cref="T:System.IAsyncResult" /> instance returned by a call to <see cref="Overload:System.Net.Security.SslStream.BeginAuthenticateAsServer" />. </param>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="asyncResult" /> is <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">
		///         <paramref name="asyncResult" /> was not created by a call to <see cref="Overload:System.Net.Security.SslStream.BeginAuthenticateAsServer" />.</exception>
		/// <exception cref="T:System.Security.Authentication.AuthenticationException">The authentication failed and left this object in an unusable state.</exception>
		/// <exception cref="T:System.InvalidOperationException">There is no pending server authentication to complete.</exception>
		// Token: 0x06000ED2 RID: 3794 RVA: 0x0004BEC8 File Offset: 0x0004A0C8
		public virtual void EndAuthenticateAsClient(IAsyncResult asyncResult)
		{
			TaskToApm.End(asyncResult);
		}

		/// <summary>Called by clients to authenticate the server and optionally the client in a client-server connection as an asynchronous operation. The authentication process uses the specified certificate collection and SSL protocol.</summary>
		/// <param name="targetHost">The name of the server that will share this <see cref="T:System.Net.Security.SslStream" />.</param>
		/// <param name="clientCertificates">The <see cref="T:System.Security.Cryptography.X509Certificates.X509CertificateCollection" /> that contains client certificates.</param>
		/// <param name="enabledSslProtocols">The <see cref="T:System.Security.Authentication.SslProtocols" /> value that represents the protocol used for authentication.</param>
		/// <param name="checkCertificateRevocation">A <see cref="T:System.Boolean" /> value that specifies whether the certificate revocation list is checked during authentication.</param>
		/// <returns>Returns <see cref="T:System.Threading.Tasks.Task" />The task object representing the asynchronous operation.</returns>
		// Token: 0x06000ED3 RID: 3795 RVA: 0x0004BED0 File Offset: 0x0004A0D0
		public virtual Task AuthenticateAsClientAsync(string targetHost, X509CertificateCollection clientCertificates, SslProtocols enabledSslProtocols, bool checkCertificateRevocation)
		{
			return this.Impl.AuthenticateAsClientAsync(targetHost, clientCertificates, enabledSslProtocols, checkCertificateRevocation);
		}

		/// <summary>Gets a <see cref="T:System.Boolean" /> value that indicates whether authentication was successful.</summary>
		/// <returns>
		///     <see langword="true" /> if successful authentication occurred; otherwise, <see langword="false" />.</returns>
		// Token: 0x170002F8 RID: 760
		// (get) Token: 0x06000ED4 RID: 3796 RVA: 0x0004BEE2 File Offset: 0x0004A0E2
		public override bool IsAuthenticated
		{
			get
			{
				return this.Impl.IsAuthenticated;
			}
		}

		/// <summary>Gets the certificate used to authenticate the local endpoint.</summary>
		/// <returns>An X509Certificate object that represents the certificate supplied for authentication or <see langword="null" /> if no certificate was supplied.</returns>
		/// <exception cref="T:System.InvalidOperationException">Authentication failed or has not occurred.</exception>
		// Token: 0x170002F9 RID: 761
		// (get) Token: 0x06000ED5 RID: 3797 RVA: 0x0004BEEF File Offset: 0x0004A0EF
		public virtual X509Certificate LocalCertificate
		{
			get
			{
				return this.Impl.LocalCertificate;
			}
		}

		/// <summary>Gets a <see cref="T:System.Boolean" /> value that indicates whether the underlying stream is seekable.</summary>
		/// <returns>This property always returns <see langword="false" />.</returns>
		// Token: 0x170002FA RID: 762
		// (get) Token: 0x06000ED6 RID: 3798 RVA: 0x000023F6 File Offset: 0x000005F6
		public override bool CanSeek
		{
			get
			{
				return false;
			}
		}

		/// <summary>Gets a <see cref="T:System.Boolean" /> value that indicates whether the underlying stream is readable.</summary>
		/// <returns>
		///     <see langword="true" /> if authentication has occurred and the underlying stream is readable; otherwise <see langword="false" />.</returns>
		// Token: 0x170002FB RID: 763
		// (get) Token: 0x06000ED7 RID: 3799 RVA: 0x0004BEFC File Offset: 0x0004A0FC
		public override bool CanRead
		{
			get
			{
				return this.impl != null && this.impl.CanRead;
			}
		}

		/// <summary>Gets a <see cref="T:System.Boolean" /> value that indicates whether the underlying stream supports time-outs.</summary>
		/// <returns>
		///     <see langword="true" /> if the underlying stream supports time-outs; otherwise, <see langword="false" />.</returns>
		// Token: 0x170002FC RID: 764
		// (get) Token: 0x06000ED8 RID: 3800 RVA: 0x00003E60 File Offset: 0x00002060
		public override bool CanTimeout
		{
			get
			{
				return base.InnerStream.CanTimeout;
			}
		}

		/// <summary>Gets a <see cref="T:System.Boolean" /> value that indicates whether the underlying stream is writable.</summary>
		/// <returns>
		///     <see langword="true" /> if authentication has occurred and the underlying stream is writable; otherwise <see langword="false" />.</returns>
		// Token: 0x170002FD RID: 765
		// (get) Token: 0x06000ED9 RID: 3801 RVA: 0x0004BF13 File Offset: 0x0004A113
		public override bool CanWrite
		{
			get
			{
				return this.impl != null && this.impl.CanWrite;
			}
		}

		/// <summary>Gets or sets the amount of time a read operation blocks waiting for data.</summary>
		/// <returns>A <see cref="T:System.Int32" /> that specifies the amount of time that elapses before a synchronous read operation fails.</returns>
		// Token: 0x170002FE RID: 766
		// (get) Token: 0x06000EDA RID: 3802 RVA: 0x0004BF2A File Offset: 0x0004A12A
		// (set) Token: 0x06000EDB RID: 3803 RVA: 0x0004BF37 File Offset: 0x0004A137
		public override int ReadTimeout
		{
			get
			{
				return this.Impl.ReadTimeout;
			}
			set
			{
				this.Impl.ReadTimeout = value;
			}
		}

		/// <summary>Gets or sets the amount of time a write operation blocks waiting for data.</summary>
		/// <returns>A <see cref="T:System.Int32" /> that specifies the amount of time that elapses before a synchronous write operation fails. </returns>
		// Token: 0x170002FF RID: 767
		// (get) Token: 0x06000EDC RID: 3804 RVA: 0x0004BF45 File Offset: 0x0004A145
		// (set) Token: 0x06000EDD RID: 3805 RVA: 0x0004BF52 File Offset: 0x0004A152
		public override int WriteTimeout
		{
			get
			{
				return this.Impl.WriteTimeout;
			}
			set
			{
				this.Impl.WriteTimeout = value;
			}
		}

		/// <summary>Gets the length of the underlying stream.</summary>
		/// <returns>A <see cref="T:System.Int64" />.The length of the underlying stream.</returns>
		/// <exception cref="T:System.NotSupportedException">Getting the value of this property is not supported when the underlying stream is a <see cref="T:System.Net.Sockets.NetworkStream" />.</exception>
		// Token: 0x17000300 RID: 768
		// (get) Token: 0x06000EDE RID: 3806 RVA: 0x0004BF60 File Offset: 0x0004A160
		public override long Length
		{
			get
			{
				return this.Impl.Length;
			}
		}

		/// <summary>Gets or sets the current position in the underlying stream.</summary>
		/// <returns>A <see cref="T:System.Int64" />.The current position in the underlying stream.</returns>
		/// <exception cref="T:System.NotSupportedException">Setting this property is not supported.-or-Getting the value of this property is not supported when the underlying stream is a <see cref="T:System.Net.Sockets.NetworkStream" />.</exception>
		// Token: 0x17000301 RID: 769
		// (get) Token: 0x06000EDF RID: 3807 RVA: 0x0004BF6D File Offset: 0x0004A16D
		// (set) Token: 0x06000EE0 RID: 3808 RVA: 0x0004BF7A File Offset: 0x0004A17A
		public override long Position
		{
			get
			{
				return this.Impl.Position;
			}
			set
			{
				throw new NotSupportedException(SR.GetString("This stream does not support seek operations."));
			}
		}

		/// <summary>Sets the length of the underlying stream.</summary>
		/// <param name="value">An <see cref="T:System.Int64" /> value that specifies the length of the stream.</param>
		// Token: 0x06000EE1 RID: 3809 RVA: 0x0004BF8B File Offset: 0x0004A18B
		public override void SetLength(long value)
		{
			this.Impl.SetLength(value);
		}

		/// <summary>Throws a <see cref="T:System.NotSupportedException" />.</summary>
		/// <param name="offset">This value is ignored.</param>
		/// <param name="origin">This value is ignored.</param>
		/// <returns>Always throws a <see cref="T:System.NotSupportedException" />.</returns>
		/// <exception cref="T:System.NotSupportedException">Seeking is not supported by <see cref="T:System.Net.Security.SslStream" /> objects.</exception>
		// Token: 0x06000EE2 RID: 3810 RVA: 0x0004BF7A File Offset: 0x0004A17A
		public override long Seek(long offset, SeekOrigin origin)
		{
			throw new NotSupportedException(SR.GetString("This stream does not support seek operations."));
		}

		// Token: 0x06000EE3 RID: 3811 RVA: 0x0004BF99 File Offset: 0x0004A199
		public override Task FlushAsync(CancellationToken cancellationToken)
		{
			return base.InnerStream.FlushAsync(cancellationToken);
		}

		/// <summary>Causes any buffered data to be written to the underlying device.</summary>
		// Token: 0x06000EE4 RID: 3812 RVA: 0x00003D60 File Offset: 0x00001F60
		public override void Flush()
		{
			base.InnerStream.Flush();
		}

		// Token: 0x06000EE5 RID: 3813 RVA: 0x0004BFA7 File Offset: 0x0004A1A7
		private void CheckDisposed()
		{
			if (this.impl == null)
			{
				throw new ObjectDisposedException("SslStream");
			}
		}

		/// <summary>Releases the unmanaged resources used by the <see cref="T:System.Net.Security.SslStream" /> and optionally releases the managed resources. </summary>
		/// <param name="disposing">
		///       <see langword="true" /> to release both managed and unmanaged resources; <see langword="false" /> to release only unmanaged resources. </param>
		// Token: 0x06000EE6 RID: 3814 RVA: 0x0004BFBC File Offset: 0x0004A1BC
		protected override void Dispose(bool disposing)
		{
			try
			{
				if (this.impl != null && disposing)
				{
					this.impl.Dispose();
					this.impl = null;
				}
			}
			finally
			{
				base.Dispose(disposing);
			}
		}

		/// <summary>Reads data from this stream and stores it in the specified array.</summary>
		/// <param name="buffer">A <see cref="T:System.Byte" /> array that receives the bytes read from this stream.</param>
		/// <param name="offset">A <see cref="T:System.Int32" /> that contains the zero-based location in <paramref name="buffer" /> at which to begin storing the data read from this stream.</param>
		/// <param name="count">A <see cref="T:System.Int32" /> that contains the maximum number of bytes to read from this stream.</param>
		/// <returns>A <see cref="T:System.Int32" /> value that specifies the number of bytes read. When there is no more data to be read, returns 0.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="buffer" /> is <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">
		///         <paramref name="offset" />
		///         <paramref name="&lt;" />
		///         <paramref name="0" />.
		///         <paramref name="-or-" />
		///
		///         <paramref name="offset" /> &gt; the length of <paramref name="buffer" />.-or-
		///         <paramref name="offset" /> + count &gt; the length of <paramref name="buffer" />.</exception>
		/// <exception cref="T:System.IO.IOException">The read operation failed. Check the inner exception, if present to determine the cause of the failure.</exception>
		/// <exception cref="T:System.NotSupportedException">There is already a read operation in progress.</exception>
		/// <exception cref="T:System.ObjectDisposedException">This object has been closed.</exception>
		/// <exception cref="T:System.InvalidOperationException">Authentication has not occurred.</exception>
		// Token: 0x06000EE7 RID: 3815 RVA: 0x0004C004 File Offset: 0x0004A204
		public override int Read(byte[] buffer, int offset, int count)
		{
			return this.Impl.Read(buffer, offset, count);
		}

		/// <summary>Write the specified number of <see cref="T:System.Byte" />s to the underlying stream using the specified buffer and offset.</summary>
		/// <param name="buffer">A <see cref="T:System.Byte" /> array that supplies the bytes written to the stream.</param>
		/// <param name="offset">A <see cref="T:System.Int32" /> that contains the zero-based location in <paramref name="buffer" /> at which to begin reading bytes to be written to the stream.</param>
		/// <param name="count">A <see cref="T:System.Int32" /> that contains the number of bytes to read from <paramref name="buffer" />.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="buffer" /> is <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">
		///         <paramref name="offset" />
		///         <paramref name="&lt;" />
		///         <paramref name="0" />.
		///         <paramref name="-or-" />
		///
		///         <paramref name="offset" /> &gt; the length of <paramref name="buffer" />.-or-
		///         <paramref name="offset" /> + count &gt; the length of <paramref name="buffer" />.</exception>
		/// <exception cref="T:System.IO.IOException">The write operation failed.</exception>
		/// <exception cref="T:System.NotSupportedException">There is already a write operation in progress.</exception>
		/// <exception cref="T:System.ObjectDisposedException">This object has been closed.</exception>
		/// <exception cref="T:System.InvalidOperationException">Authentication has not occurred.</exception>
		// Token: 0x06000EE8 RID: 3816 RVA: 0x0004C014 File Offset: 0x0004A214
		public override void Write(byte[] buffer, int offset, int count)
		{
			this.Impl.Write(buffer, offset, count);
		}

		// Token: 0x06000EE9 RID: 3817 RVA: 0x0004C024 File Offset: 0x0004A224
		public override Task<int> ReadAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken)
		{
			return this.Impl.ReadAsync(buffer, offset, count, cancellationToken);
		}

		// Token: 0x06000EEA RID: 3818 RVA: 0x0004C036 File Offset: 0x0004A236
		public override Task WriteAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken)
		{
			return this.Impl.WriteAsync(buffer, offset, count, cancellationToken);
		}

		/// <summary>Begins an asynchronous read operation that reads data from the stream and stores it in the specified array.</summary>
		/// <param name="buffer">A <see cref="T:System.Byte" /> array that receives the bytes read from the stream.</param>
		/// <param name="offset">The zero-based location in <paramref name="buffer" /> at which to begin storing the data read from this stream.</param>
		/// <param name="count">The maximum number of bytes to read from the stream.</param>
		/// <param name="asyncCallback">An <see cref="T:System.AsyncCallback" /> delegate that references the method to invoke when the read operation is complete. </param>
		/// <param name="asyncState">A user-defined object that contains information about the read operation. This object is passed to the <paramref name="asyncCallback" /> delegate when the operation completes.</param>
		/// <returns>An <see cref="T:System.IAsyncResult" /> object that indicates the status of the asynchronous operation. </returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="buffer" /> is <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">
		///         <paramref name="offset" />
		///         <paramref name="&lt;" />
		///         <paramref name="0" />.
		///         <paramref name="-or-" />
		///
		///         <paramref name="offset" /> &gt; the length of <paramref name="buffer" />.-or-
		///         <paramref name="offset" /> + count &gt; the length of <paramref name="buffer" />.</exception>
		/// <exception cref="T:System.IO.IOException">The read operation failed.-or-Encryption is in use, but the data could not be decrypted.</exception>
		/// <exception cref="T:System.NotSupportedException">There is already a read operation in progress.</exception>
		/// <exception cref="T:System.ObjectDisposedException">This object has been closed.</exception>
		/// <exception cref="T:System.InvalidOperationException">Authentication has not occurred.</exception>
		// Token: 0x06000EEB RID: 3819 RVA: 0x0004C048 File Offset: 0x0004A248
		public override IAsyncResult BeginRead(byte[] buffer, int offset, int count, AsyncCallback callback, object state)
		{
			return TaskToApm.Begin(this.Impl.ReadAsync(buffer, offset, count), callback, state);
		}

		/// <summary>Ends an asynchronous read operation started with a previous call to <see cref="M:System.Net.Security.SslStream.BeginRead(System.Byte[],System.Int32,System.Int32,System.AsyncCallback,System.Object)" />.</summary>
		/// <param name="asyncResult">An <see cref="T:System.IAsyncResult" /> instance returned by a call to <see cref="M:System.Net.Security.SslStream.BeginRead(System.Byte[],System.Int32,System.Int32,System.AsyncCallback,System.Object)" /></param>
		/// <returns>A <see cref="T:System.Int32" /> value that specifies the number of bytes read from the underlying stream.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="asyncResult" /> is <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">
		///         <paramref name="asyncResult" /> was not created by a call to <see cref="M:System.Net.Security.SslStream.BeginRead(System.Byte[],System.Int32,System.Int32,System.AsyncCallback,System.Object)" />.</exception>
		/// <exception cref="T:System.InvalidOperationException">There is no pending read operation to complete.</exception>
		/// <exception cref="T:System.IO.IOException">The read operation failed.</exception>
		/// <exception cref="T:System.InvalidOperationException">Authentication has not occurred.</exception>
		// Token: 0x06000EEC RID: 3820 RVA: 0x0004C061 File Offset: 0x0004A261
		public override int EndRead(IAsyncResult asyncResult)
		{
			return TaskToApm.End<int>(asyncResult);
		}

		/// <summary>Begins an asynchronous write operation that writes <see cref="T:System.Byte" />s from the specified buffer to the stream.</summary>
		/// <param name="buffer">A <see cref="T:System.Byte" /> array that supplies the bytes to be written to the stream.</param>
		/// <param name="offset">The zero-based location in <paramref name="buffer" /> at which to begin reading bytes to be written to the stream.</param>
		/// <param name="count">An <see cref="T:System.Int32" /> value that specifies the number of bytes to read from <paramref name="buffer" />.</param>
		/// <param name="asyncCallback">An <see cref="T:System.AsyncCallback" /> delegate that references the method to invoke when the write operation is complete. </param>
		/// <param name="asyncState">A user-defined object that contains information about the write operation. This object is passed to the <paramref name="asyncCallback" /> delegate when the operation completes.</param>
		/// <returns>An <see cref="T:System.IAsyncResult" /> object indicating the status of the asynchronous operation. </returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="buffer" /> is <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">
		///         <paramref name="offset" />
		///         <paramref name="&lt;" />
		///         <paramref name="0" />.
		///         <paramref name="-or-" />
		///
		///         <paramref name="offset" /> &gt; the length of <paramref name="buffer" />.-or-
		///         <paramref name="offset" /> + count &gt; the length of <paramref name="buffer" />.</exception>
		/// <exception cref="T:System.IO.IOException">The write operation failed.</exception>
		/// <exception cref="T:System.NotSupportedException">There is already a write operation in progress.</exception>
		/// <exception cref="T:System.ObjectDisposedException">This object has been closed.</exception>
		/// <exception cref="T:System.InvalidOperationException">Authentication has not occurred.</exception>
		// Token: 0x06000EED RID: 3821 RVA: 0x0004C069 File Offset: 0x0004A269
		public override IAsyncResult BeginWrite(byte[] buffer, int offset, int count, AsyncCallback callback, object state)
		{
			return TaskToApm.Begin(this.Impl.WriteAsync(buffer, offset, count), callback, state);
		}

		/// <summary>Ends an asynchronous write operation started with a previous call to <see cref="M:System.Net.Security.SslStream.BeginWrite(System.Byte[],System.Int32,System.Int32,System.AsyncCallback,System.Object)" />.</summary>
		/// <param name="asyncResult">An <see cref="T:System.IAsyncResult" /> instance returned by a call to <see cref="M:System.Net.Security.SslStream.BeginWrite(System.Byte[],System.Int32,System.Int32,System.AsyncCallback,System.Object)" /></param>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="asyncResult" /> is <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">
		///         <paramref name="asyncResult" /> was not created by a call to <see cref="M:System.Net.Security.SslStream.BeginWrite(System.Byte[],System.Int32,System.Int32,System.AsyncCallback,System.Object)" />.</exception>
		/// <exception cref="T:System.InvalidOperationException">There is no pending write operation to complete.</exception>
		/// <exception cref="T:System.IO.IOException">The write operation failed.</exception>
		/// <exception cref="T:System.InvalidOperationException">Authentication has not occurred.</exception>
		// Token: 0x06000EEE RID: 3822 RVA: 0x0004BEC8 File Offset: 0x0004A0C8
		public override void EndWrite(IAsyncResult asyncResult)
		{
			TaskToApm.End(asyncResult);
		}

		// Token: 0x04000BD9 RID: 3033
		private MobileTlsProvider provider;

		// Token: 0x04000BDA RID: 3034
		private MonoTlsSettings settings;

		// Token: 0x04000BDB RID: 3035
		private RemoteCertificateValidationCallback validationCallback;

		// Token: 0x04000BDC RID: 3036
		private LocalCertificateSelectionCallback selectionCallback;

		// Token: 0x04000BDD RID: 3037
		private MobileAuthenticatedStream impl;

		// Token: 0x04000BDE RID: 3038
		private bool explicitSettings;
	}
}
