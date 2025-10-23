using System;
using System.Security.Cryptography.X509Certificates;

namespace Mono.Security.Interface
{
	// Token: 0x02000040 RID: 64
	// (Invoke) Token: 0x0600014D RID: 333
	public delegate bool MonoRemoteCertificateValidationCallback(string targetHost, X509Certificate certificate, X509Chain chain, MonoSslPolicyErrors sslPolicyErrors);
}
