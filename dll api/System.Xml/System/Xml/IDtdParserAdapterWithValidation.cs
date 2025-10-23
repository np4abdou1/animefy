using System;

namespace System.Xml
{
	// Token: 0x02000030 RID: 48
	internal interface IDtdParserAdapterWithValidation : IDtdParserAdapter
	{
		// Token: 0x1700003D RID: 61
		// (get) Token: 0x06000194 RID: 404
		bool DtdValidation { get; }

		// Token: 0x1700003E RID: 62
		// (get) Token: 0x06000195 RID: 405
		IValidationEventHandling ValidationEventHandling { get; }
	}
}
