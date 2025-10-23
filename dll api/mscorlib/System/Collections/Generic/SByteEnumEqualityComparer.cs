using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

namespace System.Collections.Generic
{
	// Token: 0x02000648 RID: 1608
	[Serializable]
	internal sealed class SByteEnumEqualityComparer<T> : EnumEqualityComparer<T>, ISerializable where T : struct
	{
		// Token: 0x060030C6 RID: 12486 RVA: 0x000C4A3C File Offset: 0x000C2C3C
		public SByteEnumEqualityComparer()
		{
		}

		// Token: 0x060030C7 RID: 12487 RVA: 0x000C4A3C File Offset: 0x000C2C3C
		public SByteEnumEqualityComparer(SerializationInfo information, StreamingContext context)
		{
		}

		// Token: 0x060030C8 RID: 12488 RVA: 0x000C4A44 File Offset: 0x000C2C44
		public override int GetHashCode(T obj)
		{
			return ((sbyte)JitHelpers.UnsafeEnumCast<T>(obj)).GetHashCode();
		}
	}
}
