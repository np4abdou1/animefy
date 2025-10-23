using System;
using Android.Runtime;
using Java.Interop;
using Java.Security.Cert;

namespace Javax.Net.Ssl
{
	// Token: 0x02000090 RID: 144
	[Register("javax/net/ssl/X509TrustManager", "", "Javax.Net.Ssl.IX509TrustManagerInvoker")]
	public interface IX509TrustManager : ITrustManager, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x06000235 RID: 565
		void CheckClientTrusted(X509Certificate[] chain, string authType);

		// Token: 0x06000236 RID: 566
		void CheckServerTrusted(X509Certificate[] chain, string authType);

		// Token: 0x06000237 RID: 567
		X509Certificate[] GetAcceptedIssuers();
	}
}
