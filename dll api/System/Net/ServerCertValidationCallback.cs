using System;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
using System.Threading;

namespace System.Net
{
	// Token: 0x02000199 RID: 409
	internal class ServerCertValidationCallback
	{
		// Token: 0x06000B18 RID: 2840 RVA: 0x0003A794 File Offset: 0x00038994
		internal ServerCertValidationCallback(RemoteCertificateValidationCallback validationCallback)
		{
			this.m_ValidationCallback = validationCallback;
			this.m_Context = ExecutionContext.Capture();
		}

		// Token: 0x1700021A RID: 538
		// (get) Token: 0x06000B19 RID: 2841 RVA: 0x0003A7AE File Offset: 0x000389AE
		internal RemoteCertificateValidationCallback ValidationCallback
		{
			get
			{
				return this.m_ValidationCallback;
			}
		}

		// Token: 0x06000B1A RID: 2842 RVA: 0x0003A7B8 File Offset: 0x000389B8
		internal void Callback(object state)
		{
			ServerCertValidationCallback.CallbackContext callbackContext = (ServerCertValidationCallback.CallbackContext)state;
			callbackContext.result = this.m_ValidationCallback(callbackContext.request, callbackContext.certificate, callbackContext.chain, callbackContext.sslPolicyErrors);
		}

		// Token: 0x06000B1B RID: 2843 RVA: 0x0003A7F8 File Offset: 0x000389F8
		internal bool Invoke(object request, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors)
		{
			if (this.m_Context == null)
			{
				return this.m_ValidationCallback(request, certificate, chain, sslPolicyErrors);
			}
			ExecutionContext executionContext = this.m_Context.CreateCopy();
			ServerCertValidationCallback.CallbackContext callbackContext = new ServerCertValidationCallback.CallbackContext(request, certificate, chain, sslPolicyErrors);
			ExecutionContext.Run(executionContext, new ContextCallback(this.Callback), callbackContext);
			return callbackContext.result;
		}

		// Token: 0x04000802 RID: 2050
		private readonly RemoteCertificateValidationCallback m_ValidationCallback;

		// Token: 0x04000803 RID: 2051
		private readonly ExecutionContext m_Context;

		// Token: 0x0200019A RID: 410
		private class CallbackContext
		{
			// Token: 0x06000B1C RID: 2844 RVA: 0x0003A84C File Offset: 0x00038A4C
			internal CallbackContext(object request, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors)
			{
				this.request = request;
				this.certificate = certificate;
				this.chain = chain;
				this.sslPolicyErrors = sslPolicyErrors;
			}

			// Token: 0x04000804 RID: 2052
			internal readonly object request;

			// Token: 0x04000805 RID: 2053
			internal readonly X509Certificate certificate;

			// Token: 0x04000806 RID: 2054
			internal readonly X509Chain chain;

			// Token: 0x04000807 RID: 2055
			internal readonly SslPolicyErrors sslPolicyErrors;

			// Token: 0x04000808 RID: 2056
			internal bool result;
		}
	}
}
