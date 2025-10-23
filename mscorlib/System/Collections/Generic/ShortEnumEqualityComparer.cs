using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

namespace System.Collections.Generic
{
	// Token: 0x02000649 RID: 1609
	[Serializable]
	internal sealed class ShortEnumEqualityComparer<T> : EnumEqualityComparer<T>, ISerializable where T : struct
	{
		// Token: 0x060030C9 RID: 12489 RVA: 0x000C4A3C File Offset: 0x000C2C3C
		public ShortEnumEqualityComparer()
		{
		}

		// Token: 0x060030CA RID: 12490 RVA: 0x000C4A3C File Offset: 0x000C2C3C
		public ShortEnumEqualityComparer(SerializationInfo information, StreamingContext context)
		{
		}

		// Token: 0x060030CB RID: 12491 RVA: 0x000C4A60 File Offset: 0x000C2C60
		public override int GetHashCode(T obj)
		{
			return ((short)JitHelpers.UnsafeEnumCast<T>(obj)).GetHashCode();
		}
	}
}
