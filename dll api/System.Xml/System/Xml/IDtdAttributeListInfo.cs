using System;
using System.Collections.Generic;

namespace System.Xml
{
	// Token: 0x0200002A RID: 42
	internal interface IDtdAttributeListInfo
	{
		// Token: 0x1700001A RID: 26
		// (get) Token: 0x06000156 RID: 342
		bool HasNonCDataAttributes { get; }

		// Token: 0x06000157 RID: 343
		IDtdAttributeInfo LookupAttribute(string prefix, string localName);

		// Token: 0x06000158 RID: 344
		IEnumerable<IDtdDefaultAttributeInfo> LookupDefaultAttributes();
	}
}
