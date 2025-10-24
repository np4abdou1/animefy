using System;

namespace System.Net
{
	// Token: 0x020001AB RID: 427
	internal class HttpRequestCreator : IWebRequestCreate
	{
		// Token: 0x06000B6E RID: 2926 RVA: 0x0000222D File Offset: 0x0000042D
		internal HttpRequestCreator()
		{
		}

		// Token: 0x06000B6F RID: 2927 RVA: 0x0003BE5E File Offset: 0x0003A05E
		public WebRequest Create(Uri uri)
		{
			return new HttpWebRequest(uri);
		}
	}
}
