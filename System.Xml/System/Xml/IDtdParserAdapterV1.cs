using System;

namespace System.Xml
{
	// Token: 0x02000031 RID: 49
	internal interface IDtdParserAdapterV1 : IDtdParserAdapterWithValidation, IDtdParserAdapter
	{
		// Token: 0x1700003F RID: 63
		// (get) Token: 0x06000196 RID: 406
		bool V1CompatibilityMode { get; }

		// Token: 0x17000040 RID: 64
		// (get) Token: 0x06000197 RID: 407
		bool Normalization { get; }

		// Token: 0x17000041 RID: 65
		// (get) Token: 0x06000198 RID: 408
		bool Namespaces { get; }
	}
}
