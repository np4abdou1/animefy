using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Security;

namespace System.Collections.Generic
{
	// Token: 0x02000647 RID: 1607
	[Serializable]
	internal class EnumEqualityComparer<T> : EqualityComparer<T>, ISerializable where T : struct
	{
		// Token: 0x060030BF RID: 12479 RVA: 0x000C49CC File Offset: 0x000C2BCC
		public override bool Equals(T x, T y)
		{
			int num = JitHelpers.UnsafeEnumCast<T>(x);
			int num2 = JitHelpers.UnsafeEnumCast<T>(y);
			return num == num2;
		}

		// Token: 0x060030C0 RID: 12480 RVA: 0x000C49EC File Offset: 0x000C2BEC
		public override int GetHashCode(T obj)
		{
			return JitHelpers.UnsafeEnumCast<T>(obj).GetHashCode();
		}

		// Token: 0x060030C1 RID: 12481 RVA: 0x000C4671 File Offset: 0x000C2871
		public EnumEqualityComparer()
		{
		}

		// Token: 0x060030C2 RID: 12482 RVA: 0x000C4671 File Offset: 0x000C2871
		protected EnumEqualityComparer(SerializationInfo information, StreamingContext context)
		{
		}

		// Token: 0x060030C3 RID: 12483 RVA: 0x000C4A07 File Offset: 0x000C2C07
		[SecurityCritical]
		public void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			if (Type.GetTypeCode(Enum.GetUnderlyingType(typeof(T))) != TypeCode.Int32)
			{
				info.SetType(typeof(ObjectEqualityComparer<T>));
			}
		}

		// Token: 0x060030C4 RID: 12484 RVA: 0x000C4A31 File Offset: 0x000C2C31
		public override bool Equals(object obj)
		{
			return obj is EnumEqualityComparer<T>;
		}

		// Token: 0x060030C5 RID: 12485 RVA: 0x000C422A File Offset: 0x000C242A
		public override int GetHashCode()
		{
			return base.GetType().Name.GetHashCode();
		}
	}
}
