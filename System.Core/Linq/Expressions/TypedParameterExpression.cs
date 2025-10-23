using System;

namespace System.Linq.Expressions
{
	// Token: 0x020000C3 RID: 195
	internal class TypedParameterExpression : ParameterExpression
	{
		// Token: 0x060005C6 RID: 1478 RVA: 0x00013A25 File Offset: 0x00011C25
		internal TypedParameterExpression(Type type, string name) : base(name)
		{
			this.Type = type;
		}

		// Token: 0x170000F9 RID: 249
		// (get) Token: 0x060005C7 RID: 1479 RVA: 0x00013A35 File Offset: 0x00011C35
		public sealed override Type Type { get; }
	}
}
