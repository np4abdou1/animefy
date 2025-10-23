using System;
using System.Reflection;

namespace System.Linq.Expressions
{
	// Token: 0x020000A9 RID: 169
	internal sealed class FieldExpression : MemberExpression
	{
		// Token: 0x06000542 RID: 1346 RVA: 0x00012E0B File Offset: 0x0001100B
		public FieldExpression(Expression expression, FieldInfo member) : base(expression)
		{
			this._field = member;
		}

		// Token: 0x06000543 RID: 1347 RVA: 0x00012E1B File Offset: 0x0001101B
		internal override MemberInfo GetMember()
		{
			return this._field;
		}

		// Token: 0x170000CF RID: 207
		// (get) Token: 0x06000544 RID: 1348 RVA: 0x00012E23 File Offset: 0x00011023
		public sealed override Type Type
		{
			get
			{
				return this._field.FieldType;
			}
		}

		// Token: 0x0400018A RID: 394
		private readonly FieldInfo _field;
	}
}
