using System;
using System.Runtime.CompilerServices;

namespace Newtonsoft.Json.Converters
{
	// Token: 0x020001C5 RID: 453
	[NullableContext(2)]
	internal interface IXmlDeclaration : IXmlNode
	{
		// Token: 0x1700026B RID: 619
		// (get) Token: 0x06000F40 RID: 3904
		string Version { get; }

		// Token: 0x1700026C RID: 620
		// (get) Token: 0x06000F41 RID: 3905
		// (set) Token: 0x06000F42 RID: 3906
		string Encoding { get; set; }

		// Token: 0x1700026D RID: 621
		// (get) Token: 0x06000F43 RID: 3907
		// (set) Token: 0x06000F44 RID: 3908
		string Standalone { get; set; }
	}
}
