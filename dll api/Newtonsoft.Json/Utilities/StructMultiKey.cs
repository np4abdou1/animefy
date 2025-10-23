using System;
using System.Runtime.CompilerServices;

namespace Newtonsoft.Json.Utilities
{
	// Token: 0x020000F2 RID: 242
	[NullableContext(1)]
	[Nullable(0)]
	internal readonly struct StructMultiKey<[Nullable(2)] T1, [Nullable(2)] T2> : IEquatable<StructMultiKey<T1, T2>>
	{
		// Token: 0x0600071B RID: 1819 RVA: 0x00024659 File Offset: 0x00022859
		public StructMultiKey(T1 v1, T2 v2)
		{
			this.Value1 = v1;
			this.Value2 = v2;
		}

		// Token: 0x0600071C RID: 1820 RVA: 0x0002466C File Offset: 0x0002286C
		public override int GetHashCode()
		{
			T1 value = this.Value1;
			int num = (value != null) ? value.GetHashCode() : 0;
			T2 value2 = this.Value2;
			return num ^ ((value2 != null) ? value2.GetHashCode() : 0);
		}

		// Token: 0x0600071D RID: 1821 RVA: 0x000246C4 File Offset: 0x000228C4
		[NullableContext(2)]
		public override bool Equals(object obj)
		{
			if (obj is StructMultiKey<T1, T2>)
			{
				StructMultiKey<T1, T2> other = (StructMultiKey<T1, T2>)obj;
				return this.Equals(other);
			}
			return false;
		}

		// Token: 0x0600071E RID: 1822 RVA: 0x000246EB File Offset: 0x000228EB
		public bool Equals([Nullable(new byte[]
		{
			0,
			1,
			1
		})] StructMultiKey<T1, T2> other)
		{
			return object.Equals(this.Value1, other.Value1) && object.Equals(this.Value2, other.Value2);
		}

		// Token: 0x040004D4 RID: 1236
		public readonly T1 Value1;

		// Token: 0x040004D5 RID: 1237
		public readonly T2 Value2;
	}
}
