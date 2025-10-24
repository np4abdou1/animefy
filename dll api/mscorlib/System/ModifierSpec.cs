using System;
using System.Text;

namespace System
{
	// Token: 0x0200018D RID: 397
	internal interface ModifierSpec
	{
		// Token: 0x06000F52 RID: 3922
		Type Resolve(Type type);

		// Token: 0x06000F53 RID: 3923
		StringBuilder Append(StringBuilder sb);
	}
}
