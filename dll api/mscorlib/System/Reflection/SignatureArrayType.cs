using System;

namespace System.Reflection
{
	// Token: 0x020004B8 RID: 1208
	internal sealed class SignatureArrayType : SignatureHasElementType
	{
		// Token: 0x060021B0 RID: 8624 RVA: 0x0008A97F File Offset: 0x00088B7F
		internal SignatureArrayType(SignatureType elementType, int rank, bool isMultiDim) : base(elementType)
		{
			this._rank = rank;
			this._isMultiDim = isMultiDim;
		}

		// Token: 0x060021B1 RID: 8625 RVA: 0x0000B18D File Offset: 0x0000938D
		protected sealed override bool IsArrayImpl()
		{
			return true;
		}

		// Token: 0x060021B2 RID: 8626 RVA: 0x0002ACA4 File Offset: 0x00028EA4
		protected sealed override bool IsByRefImpl()
		{
			return false;
		}

		// Token: 0x060021B3 RID: 8627 RVA: 0x0002ACA4 File Offset: 0x00028EA4
		protected sealed override bool IsPointerImpl()
		{
			return false;
		}

		// Token: 0x17000453 RID: 1107
		// (get) Token: 0x060021B4 RID: 8628 RVA: 0x0008A996 File Offset: 0x00088B96
		public sealed override bool IsSZArray
		{
			get
			{
				return !this._isMultiDim;
			}
		}

		// Token: 0x17000454 RID: 1108
		// (get) Token: 0x060021B5 RID: 8629 RVA: 0x0008A9A1 File Offset: 0x00088BA1
		public sealed override bool IsVariableBoundArray
		{
			get
			{
				return this._isMultiDim;
			}
		}

		// Token: 0x060021B6 RID: 8630 RVA: 0x0008A9A9 File Offset: 0x00088BA9
		public sealed override int GetArrayRank()
		{
			return this._rank;
		}

		// Token: 0x17000455 RID: 1109
		// (get) Token: 0x060021B7 RID: 8631 RVA: 0x0008A9B1 File Offset: 0x00088BB1
		protected sealed override string Suffix
		{
			get
			{
				if (!this._isMultiDim)
				{
					return "[]";
				}
				if (this._rank == 1)
				{
					return "[*]";
				}
				return "[" + new string(',', this._rank - 1) + "]";
			}
		}

		// Token: 0x04001061 RID: 4193
		private readonly int _rank;

		// Token: 0x04001062 RID: 4194
		private readonly bool _isMultiDim;
	}
}
