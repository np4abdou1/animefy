using System;

namespace System.Xml
{
	// Token: 0x0200002C RID: 44
	internal interface IDtdDefaultAttributeInfo : IDtdAttributeInfo
	{
		// Token: 0x17000022 RID: 34
		// (get) Token: 0x06000160 RID: 352
		string DefaultValueExpanded { get; }

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x06000161 RID: 353
		object DefaultValueTyped { get; }

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x06000162 RID: 354
		int ValueLineNumber { get; }

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x06000163 RID: 355
		int ValueLinePosition { get; }
	}
}
