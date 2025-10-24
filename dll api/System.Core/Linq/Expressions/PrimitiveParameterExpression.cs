using System;

namespace System.Linq.Expressions
{
	// Token: 0x020000C4 RID: 196
	internal sealed class PrimitiveParameterExpression<T> : ParameterExpression
	{
		// Token: 0x060005C8 RID: 1480 RVA: 0x00013A3D File Offset: 0x00011C3D
		internal PrimitiveParameterExpression(string name) : base(name)
		{
		}

		// Token: 0x170000FA RID: 250
		// (get) Token: 0x060005C9 RID: 1481 RVA: 0x0001291D File Offset: 0x00010B1D
		public sealed override Type Type
		{
			get
			{
				return typeof(T);
			}
		}
	}
}
