using System;

namespace System.Net
{
	/// <summary>Defines the HTTP version numbers that are supported by the <see cref="T:System.Net.HttpWebRequest" /> and <see cref="T:System.Net.HttpWebResponse" /> classes.</summary>
	// Token: 0x02000113 RID: 275
	public class HttpVersion
	{
		// Token: 0x04000569 RID: 1385
		public static readonly Version Unknown = new Version(0, 0);

		/// <summary>Defines a <see cref="T:System.Version" /> instance for HTTP 1.0.</summary>
		// Token: 0x0400056A RID: 1386
		public static readonly Version Version10 = new Version(1, 0);

		/// <summary>Defines a <see cref="T:System.Version" /> instance for HTTP 1.1.</summary>
		// Token: 0x0400056B RID: 1387
		public static readonly Version Version11 = new Version(1, 1);

		// Token: 0x0400056C RID: 1388
		public static readonly Version Version20 = new Version(2, 0);
	}
}
