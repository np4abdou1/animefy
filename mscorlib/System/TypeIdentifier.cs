using System;

namespace System
{
	// Token: 0x02000187 RID: 391
	internal interface TypeIdentifier : TypeName, IEquatable<TypeName>
	{
		// Token: 0x17000160 RID: 352
		// (get) Token: 0x06000F43 RID: 3907
		string InternalName { get; }
	}
}
