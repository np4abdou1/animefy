using System;

namespace System.Linq.Expressions
{
	// Token: 0x02000083 RID: 131
	internal class TypedConstantExpression : ConstantExpression
	{
		// Token: 0x06000384 RID: 900 RVA: 0x0000FEFF File Offset: 0x0000E0FF
		internal TypedConstantExpression(object value, Type type) : base(value)
		{
			this.Type = type;
		}

		// Token: 0x17000084 RID: 132
		// (get) Token: 0x06000385 RID: 901 RVA: 0x0000FF0F File Offset: 0x0000E10F
		public sealed override Type Type { get; }
	}
}
