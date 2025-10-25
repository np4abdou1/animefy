using System;
using System.Net;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;

namespace AQ.Helpers
{
	// Token: 0x02000094 RID: 148
	public class PublicFunctions
	{
		// Token: 0x06000695 RID: 1685 RVA: 0x00013A6A File Offset: 0x00011C6A
		public static void ValidateConnection()
		{
			ServicePointManager.ServerCertificateValidationCallback = ((object <p0>, X509Certificate <p1>, X509Chain <p2>, SslPolicyErrors <p3>) => true);
		}
	}
}
