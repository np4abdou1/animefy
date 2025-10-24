using System;
using System.Reflection;

namespace System.Linq.Expressions
{
	// Token: 0x020000AF RID: 175
	internal class InstanceMethodCallExpression : MethodCallExpression, IArgumentProvider
	{
		// Token: 0x06000568 RID: 1384 RVA: 0x000130F6 File Offset: 0x000112F6
		public InstanceMethodCallExpression(MethodInfo method, Expression instance) : base(method)
		{
			this._instance = instance;
		}

		// Token: 0x06000569 RID: 1385 RVA: 0x00013106 File Offset: 0x00011306
		internal override Expression GetInstance()
		{
			return this._instance;
		}

		// Token: 0x04000191 RID: 401
		private readonly Expression _instance;
	}
}
