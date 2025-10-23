using System;
using System.Security;

namespace System.Globalization
{
	// Token: 0x020005AC RID: 1452
	internal struct InternalCodePageDataItem
	{
		// Token: 0x040017BE RID: 6078
		internal ushort codePage;

		// Token: 0x040017BF RID: 6079
		internal ushort uiFamilyCodePage;

		// Token: 0x040017C0 RID: 6080
		internal uint flags;

		// Token: 0x040017C1 RID: 6081
		[SecurityCritical]
		internal string Names;
	}
}
