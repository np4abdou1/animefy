using System;
using System.Runtime.InteropServices;

namespace System.Reflection.Emit
{
	// Token: 0x020004F6 RID: 1270
	[StructLayout(0)]
	internal class PointerType : SymbolType
	{
		// Token: 0x060024A6 RID: 9382 RVA: 0x0008FF49 File Offset: 0x0008E149
		internal PointerType(Type elementType) : base(elementType)
		{
		}

		// Token: 0x060024A7 RID: 9383 RVA: 0x0008FF9A File Offset: 0x0008E19A
		internal override Type InternalResolve()
		{
			return this.m_baseType.InternalResolve().MakePointerType();
		}

		// Token: 0x060024A8 RID: 9384 RVA: 0x0000B18D File Offset: 0x0000938D
		protected override bool IsPointerImpl()
		{
			return true;
		}

		// Token: 0x060024A9 RID: 9385 RVA: 0x0008FFAC File Offset: 0x0008E1AC
		internal override string FormatName(string elementName)
		{
			if (elementName == null)
			{
				return null;
			}
			return elementName + "*";
		}
	}
}
