using System;

namespace System.Net
{
	// Token: 0x0200018E RID: 398
	internal class FileWebRequestCreator : IWebRequestCreate
	{
		// Token: 0x06000ADF RID: 2783 RVA: 0x0000222D File Offset: 0x0000042D
		internal FileWebRequestCreator()
		{
		}

		// Token: 0x06000AE0 RID: 2784 RVA: 0x00039B24 File Offset: 0x00037D24
		public WebRequest Create(Uri uri)
		{
			return new FileWebRequest(uri);
		}
	}
}
