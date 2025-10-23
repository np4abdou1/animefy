using System;
using System.Runtime.CompilerServices;

namespace Newtonsoft.Json.Converters
{
	// Token: 0x020001C6 RID: 454
	[NullableContext(2)]
	internal interface IXmlDocumentType : IXmlNode
	{
		// Token: 0x1700026E RID: 622
		// (get) Token: 0x06000F45 RID: 3909
		[Nullable(1)]
		string Name { [NullableContext(1)] get; }

		// Token: 0x1700026F RID: 623
		// (get) Token: 0x06000F46 RID: 3910
		string System { get; }

		// Token: 0x17000270 RID: 624
		// (get) Token: 0x06000F47 RID: 3911
		string Public { get; }

		// Token: 0x17000271 RID: 625
		// (get) Token: 0x06000F48 RID: 3912
		string InternalSubset { get; }
	}
}
