using System;

namespace System.Net
{
	// Token: 0x02000188 RID: 392
	internal struct HeaderVariantInfo
	{
		// Token: 0x06000AA0 RID: 2720 RVA: 0x0003816D File Offset: 0x0003636D
		internal HeaderVariantInfo(string name, CookieVariant variant)
		{
			this.m_name = name;
			this.m_variant = variant;
		}

		// Token: 0x17000202 RID: 514
		// (get) Token: 0x06000AA1 RID: 2721 RVA: 0x0003817D File Offset: 0x0003637D
		internal string Name
		{
			get
			{
				return this.m_name;
			}
		}

		// Token: 0x17000203 RID: 515
		// (get) Token: 0x06000AA2 RID: 2722 RVA: 0x00038185 File Offset: 0x00036385
		internal CookieVariant Variant
		{
			get
			{
				return this.m_variant;
			}
		}

		// Token: 0x040007D1 RID: 2001
		private string m_name;

		// Token: 0x040007D2 RID: 2002
		private CookieVariant m_variant;
	}
}
