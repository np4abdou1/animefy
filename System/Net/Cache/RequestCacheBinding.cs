using System;

namespace System.Net.Cache
{
	// Token: 0x020001F6 RID: 502
	internal class RequestCacheBinding
	{
		// Token: 0x170002BD RID: 701
		// (get) Token: 0x06000D6C RID: 3436 RVA: 0x000468E5 File Offset: 0x00044AE5
		internal RequestCache Cache
		{
			get
			{
				return this.m_RequestCache;
			}
		}

		// Token: 0x170002BE RID: 702
		// (get) Token: 0x06000D6D RID: 3437 RVA: 0x000468ED File Offset: 0x00044AED
		internal RequestCacheValidator Validator
		{
			get
			{
				return this.m_CacheValidator;
			}
		}

		// Token: 0x04000A2E RID: 2606
		private RequestCache m_RequestCache;

		// Token: 0x04000A2F RID: 2607
		private RequestCacheValidator m_CacheValidator;
	}
}
