using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Security;

namespace System.Collections.Generic
{
	// Token: 0x0200064A RID: 1610
	[Serializable]
	internal sealed class LongEnumEqualityComparer<T> : EqualityComparer<T>, ISerializable where T : struct
	{
		// Token: 0x060030CC RID: 12492 RVA: 0x000C4A7C File Offset: 0x000C2C7C
		public override bool Equals(T x, T y)
		{
			long num = JitHelpers.UnsafeEnumCastLong<T>(x);
			long num2 = JitHelpers.UnsafeEnumCastLong<T>(y);
			return num == num2;
		}

		// Token: 0x060030CD RID: 12493 RVA: 0x000C4A9C File Offset: 0x000C2C9C
		public override int GetHashCode(T obj)
		{
			return JitHelpers.UnsafeEnumCastLong<T>(obj).GetHashCode();
		}

		// Token: 0x060030CE RID: 12494 RVA: 0x000C4AB7 File Offset: 0x000C2CB7
		public override bool Equals(object obj)
		{
			return obj is LongEnumEqualityComparer<T>;
		}

		// Token: 0x060030CF RID: 12495 RVA: 0x000C422A File Offset: 0x000C242A
		public override int GetHashCode()
		{
			return base.GetType().Name.GetHashCode();
		}

		// Token: 0x060030D0 RID: 12496 RVA: 0x000C4671 File Offset: 0x000C2871
		public LongEnumEqualityComparer()
		{
		}

		// Token: 0x060030D1 RID: 12497 RVA: 0x000C4671 File Offset: 0x000C2871
		public LongEnumEqualityComparer(SerializationInfo information, StreamingContext context)
		{
		}

		// Token: 0x060030D2 RID: 12498 RVA: 0x000C4AC2 File Offset: 0x000C2CC2
		[SecurityCritical]
		public void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			info.SetType(typeof(ObjectEqualityComparer<T>));
		}
	}
}
