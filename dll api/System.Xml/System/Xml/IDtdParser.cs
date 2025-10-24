using System;
using System.Threading.Tasks;

namespace System.Xml
{
	// Token: 0x0200002E RID: 46
	internal interface IDtdParser
	{
		// Token: 0x06000170 RID: 368
		IDtdInfo ParseInternalDtd(IDtdParserAdapter adapter, bool saveInternalSubset);

		// Token: 0x06000171 RID: 369
		IDtdInfo ParseFreeFloatingDtd(string baseUri, string docTypeName, string publicId, string systemId, string internalSubset, IDtdParserAdapter adapter);

		// Token: 0x06000172 RID: 370
		Task<IDtdInfo> ParseInternalDtdAsync(IDtdParserAdapter adapter, bool saveInternalSubset);

		// Token: 0x06000173 RID: 371
		Task<IDtdInfo> ParseFreeFloatingDtdAsync(string baseUri, string docTypeName, string publicId, string systemId, string internalSubset, IDtdParserAdapter adapter);
	}
}
