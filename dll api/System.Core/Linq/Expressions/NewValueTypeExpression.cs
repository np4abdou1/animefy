using System;
using System.Collections.ObjectModel;
using System.Reflection;

namespace System.Linq.Expressions
{
	// Token: 0x020000C0 RID: 192
	internal sealed class NewValueTypeExpression : NewExpression
	{
		// Token: 0x060005BA RID: 1466 RVA: 0x0001388D File Offset: 0x00011A8D
		internal NewValueTypeExpression(Type type, ReadOnlyCollection<Expression> arguments, ReadOnlyCollection<MemberInfo> members) : base(null, arguments, members)
		{
			this.Type = type;
		}

		// Token: 0x170000F4 RID: 244
		// (get) Token: 0x060005BB RID: 1467 RVA: 0x0001389F File Offset: 0x00011A9F
		public sealed override Type Type { get; }
	}
}
