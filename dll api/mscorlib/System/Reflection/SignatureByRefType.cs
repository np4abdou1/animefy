using System;

namespace System.Reflection
{
	// Token: 0x020004B9 RID: 1209
	internal sealed class SignatureByRefType : SignatureHasElementType
	{
		// Token: 0x060021B8 RID: 8632 RVA: 0x0008A9EE File Offset: 0x00088BEE
		internal SignatureByRefType(SignatureType elementType) : base(elementType)
		{
		}

		// Token: 0x060021B9 RID: 8633 RVA: 0x0002ACA4 File Offset: 0x00028EA4
		protected sealed override bool IsArrayImpl()
		{
			return false;
		}

		// Token: 0x060021BA RID: 8634 RVA: 0x0000B18D File Offset: 0x0000938D
		protected sealed override bool IsByRefImpl()
		{
			return true;
		}

		// Token: 0x060021BB RID: 8635 RVA: 0x0002ACA4 File Offset: 0x00028EA4
		protected sealed override bool IsPointerImpl()
		{
			return false;
		}

		// Token: 0x17000456 RID: 1110
		// (get) Token: 0x060021BC RID: 8636 RVA: 0x0002ACA4 File Offset: 0x00028EA4
		public sealed override bool IsSZArray
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17000457 RID: 1111
		// (get) Token: 0x060021BD RID: 8637 RVA: 0x0002ACA4 File Offset: 0x00028EA4
		public sealed override bool IsVariableBoundArray
		{
			get
			{
				return false;
			}
		}

		// Token: 0x060021BE RID: 8638 RVA: 0x0008A9F7 File Offset: 0x00088BF7
		public sealed override int GetArrayRank()
		{
			throw new ArgumentException("Must be an array type.");
		}

		// Token: 0x17000458 RID: 1112
		// (get) Token: 0x060021BF RID: 8639 RVA: 0x0008AA03 File Offset: 0x00088C03
		protected sealed override string Suffix
		{
			get
			{
				return "&";
			}
		}
	}
}
