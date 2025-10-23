using System;
using System.Collections;

namespace System.Runtime.Serialization.Formatters.Binary
{
	// Token: 0x020003E6 RID: 998
	internal sealed class SerObjectInfoInit
	{
		// Token: 0x04000DBC RID: 3516
		internal Hashtable seenBeforeTable = new Hashtable();

		// Token: 0x04000DBD RID: 3517
		internal int objectInfoIdCount = 1;

		// Token: 0x04000DBE RID: 3518
		internal SerStack oiPool = new SerStack("SerObjectInfo Pool");
	}
}
