using System;
using System.Runtime.InteropServices;

namespace System.Reflection.Emit
{
	// Token: 0x020004F5 RID: 1269
	[StructLayout(0)]
	internal class ByRefType : SymbolType
	{
		// Token: 0x0600249E RID: 9374 RVA: 0x0008FF49 File Offset: 0x0008E149
		internal ByRefType(Type elementType) : base(elementType)
		{
		}

		// Token: 0x0600249F RID: 9375 RVA: 0x0008FF52 File Offset: 0x0008E152
		internal override Type InternalResolve()
		{
			return this.m_baseType.InternalResolve().MakeByRefType();
		}

		// Token: 0x060024A0 RID: 9376 RVA: 0x0000B18D File Offset: 0x0000938D
		protected override bool IsByRefImpl()
		{
			return true;
		}

		// Token: 0x060024A1 RID: 9377 RVA: 0x0008FF64 File Offset: 0x0008E164
		internal override string FormatName(string elementName)
		{
			if (elementName == null)
			{
				return null;
			}
			return elementName + "&";
		}

		// Token: 0x060024A2 RID: 9378 RVA: 0x0008FF76 File Offset: 0x0008E176
		public override Type MakeArrayType()
		{
			throw new ArgumentException("Cannot create an array type of a byref type");
		}

		// Token: 0x060024A3 RID: 9379 RVA: 0x0008FF76 File Offset: 0x0008E176
		public override Type MakeArrayType(int rank)
		{
			throw new ArgumentException("Cannot create an array type of a byref type");
		}

		// Token: 0x060024A4 RID: 9380 RVA: 0x0008FF82 File Offset: 0x0008E182
		public override Type MakeByRefType()
		{
			throw new ArgumentException("Cannot create a byref type of an already byref type");
		}

		// Token: 0x060024A5 RID: 9381 RVA: 0x0008FF8E File Offset: 0x0008E18E
		public override Type MakePointerType()
		{
			throw new ArgumentException("Cannot create a pointer type of a byref type");
		}
	}
}
