using System;
using System.Runtime.InteropServices;
using System.Text;

namespace System.Reflection.Emit
{
	// Token: 0x020004F4 RID: 1268
	[StructLayout(0)]
	internal class ArrayType : SymbolType
	{
		// Token: 0x06002498 RID: 9368 RVA: 0x0008FE52 File Offset: 0x0008E052
		internal ArrayType(Type elementType, int rank) : base(elementType)
		{
			this.rank = rank;
		}

		// Token: 0x06002499 RID: 9369 RVA: 0x0008FE64 File Offset: 0x0008E064
		internal override Type InternalResolve()
		{
			Type type = this.m_baseType.InternalResolve();
			if (this.rank == 0)
			{
				return type.MakeArrayType();
			}
			return type.MakeArrayType(this.rank);
		}

		// Token: 0x0600249A RID: 9370 RVA: 0x0008FE98 File Offset: 0x0008E098
		internal override Type RuntimeResolve()
		{
			Type type = this.m_baseType.RuntimeResolve();
			if (this.rank == 0)
			{
				return type.MakeArrayType();
			}
			return type.MakeArrayType(this.rank);
		}

		// Token: 0x0600249B RID: 9371 RVA: 0x0000B18D File Offset: 0x0000938D
		protected override bool IsArrayImpl()
		{
			return true;
		}

		// Token: 0x0600249C RID: 9372 RVA: 0x0008FECC File Offset: 0x0008E0CC
		public override int GetArrayRank()
		{
			if (this.rank != 0)
			{
				return this.rank;
			}
			return 1;
		}

		// Token: 0x0600249D RID: 9373 RVA: 0x0008FEE0 File Offset: 0x0008E0E0
		internal override string FormatName(string elementName)
		{
			if (elementName == null)
			{
				return null;
			}
			StringBuilder stringBuilder = new StringBuilder(elementName);
			stringBuilder.Append("[");
			for (int i = 1; i < this.rank; i++)
			{
				stringBuilder.Append(",");
			}
			if (this.rank == 1)
			{
				stringBuilder.Append("*");
			}
			stringBuilder.Append("]");
			return stringBuilder.ToString();
		}

		// Token: 0x040011F5 RID: 4597
		private int rank;
	}
}
