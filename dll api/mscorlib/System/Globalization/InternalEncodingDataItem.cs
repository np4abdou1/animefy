using System;
using System.Security;

namespace System.Globalization
{
	// Token: 0x020005AB RID: 1451
	internal struct InternalEncodingDataItem
	{
		// Token: 0x040017BC RID: 6076
		[SecurityCritical]
		internal string webName;

		// Token: 0x040017BD RID: 6077
		internal ushort codePage;
	}
}
