using System;

namespace System.Reflection
{
	// Token: 0x020004BC RID: 1212
	internal sealed class SignaturePointerType : SignatureHasElementType
	{
		// Token: 0x060021EB RID: 8683 RVA: 0x0008A9EE File Offset: 0x00088BEE
		internal SignaturePointerType(SignatureType elementType) : base(elementType)
		{
		}

		// Token: 0x060021EC RID: 8684 RVA: 0x0002ACA4 File Offset: 0x00028EA4
		protected sealed override bool IsArrayImpl()
		{
			return false;
		}

		// Token: 0x060021ED RID: 8685 RVA: 0x0002ACA4 File Offset: 0x00028EA4
		protected sealed override bool IsByRefImpl()
		{
			return false;
		}

		// Token: 0x060021EE RID: 8686 RVA: 0x0000B18D File Offset: 0x0000938D
		protected sealed override bool IsPointerImpl()
		{
			return true;
		}

		// Token: 0x17000472 RID: 1138
		// (get) Token: 0x060021EF RID: 8687 RVA: 0x0002ACA4 File Offset: 0x00028EA4
		public sealed override bool IsSZArray
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17000473 RID: 1139
		// (get) Token: 0x060021F0 RID: 8688 RVA: 0x0002ACA4 File Offset: 0x00028EA4
		public sealed override bool IsVariableBoundArray
		{
			get
			{
				return false;
			}
		}

		// Token: 0x060021F1 RID: 8689 RVA: 0x0008A9F7 File Offset: 0x00088BF7
		public sealed override int GetArrayRank()
		{
			throw new ArgumentException("Must be an array type.");
		}

		// Token: 0x17000474 RID: 1140
		// (get) Token: 0x060021F2 RID: 8690 RVA: 0x0008ABD4 File Offset: 0x00088DD4
		protected sealed override string Suffix
		{
			get
			{
				return "*";
			}
		}
	}
}
