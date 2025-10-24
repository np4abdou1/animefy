using System;
using System.Reflection;

namespace System.Linq.Expressions
{
	// Token: 0x020000AA RID: 170
	internal sealed class PropertyExpression : MemberExpression
	{
		// Token: 0x06000545 RID: 1349 RVA: 0x00012E30 File Offset: 0x00011030
		public PropertyExpression(Expression expression, PropertyInfo member) : base(expression)
		{
			this._property = member;
		}

		// Token: 0x06000546 RID: 1350 RVA: 0x00012E40 File Offset: 0x00011040
		internal override MemberInfo GetMember()
		{
			return this._property;
		}

		// Token: 0x170000D0 RID: 208
		// (get) Token: 0x06000547 RID: 1351 RVA: 0x00012E48 File Offset: 0x00011048
		public sealed override Type Type
		{
			get
			{
				return this._property.PropertyType;
			}
		}

		// Token: 0x0400018B RID: 395
		private readonly PropertyInfo _property;
	}
}
