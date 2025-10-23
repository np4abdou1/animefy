using System;

namespace System.Xml
{
	// Token: 0x0200002D RID: 45
	internal interface IDtdEntityInfo
	{
		// Token: 0x17000026 RID: 38
		// (get) Token: 0x06000164 RID: 356
		string Name { get; }

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x06000165 RID: 357
		bool IsExternal { get; }

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x06000166 RID: 358
		bool IsDeclaredInExternal { get; }

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x06000167 RID: 359
		bool IsUnparsedEntity { get; }

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x06000168 RID: 360
		bool IsParameterEntity { get; }

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x06000169 RID: 361
		string BaseUriString { get; }

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x0600016A RID: 362
		string DeclaredUriString { get; }

		// Token: 0x1700002D RID: 45
		// (get) Token: 0x0600016B RID: 363
		string SystemId { get; }

		// Token: 0x1700002E RID: 46
		// (get) Token: 0x0600016C RID: 364
		string PublicId { get; }

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x0600016D RID: 365
		string Text { get; }

		// Token: 0x17000030 RID: 48
		// (get) Token: 0x0600016E RID: 366
		int LineNumber { get; }

		// Token: 0x17000031 RID: 49
		// (get) Token: 0x0600016F RID: 367
		int LinePosition { get; }
	}
}
