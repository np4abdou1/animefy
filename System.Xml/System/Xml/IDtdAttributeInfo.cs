using System;

namespace System.Xml
{
	// Token: 0x0200002B RID: 43
	internal interface IDtdAttributeInfo
	{
		// Token: 0x1700001B RID: 27
		// (get) Token: 0x06000159 RID: 345
		string Prefix { get; }

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x0600015A RID: 346
		string LocalName { get; }

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x0600015B RID: 347
		int LineNumber { get; }

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x0600015C RID: 348
		int LinePosition { get; }

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x0600015D RID: 349
		bool IsNonCDataType { get; }

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x0600015E RID: 350
		bool IsDeclaredInExternal { get; }

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x0600015F RID: 351
		bool IsXmlAttribute { get; }
	}
}
