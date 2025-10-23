using System;

namespace System.Net
{
	// Token: 0x0200012A RID: 298
	internal class FtpWebRequestCreator : IWebRequestCreate
	{
		// Token: 0x060008A4 RID: 2212 RVA: 0x0000222D File Offset: 0x0000042D
		internal FtpWebRequestCreator()
		{
		}

		// Token: 0x060008A5 RID: 2213 RVA: 0x000310ED File Offset: 0x0002F2ED
		public WebRequest Create(Uri uri)
		{
			return new FtpWebRequest(uri);
		}
	}
}
