using System;

namespace System.Linq.Expressions
{
	// Token: 0x0200008F RID: 143
	internal interface IParameterProvider
	{
		// Token: 0x060004AA RID: 1194
		ParameterExpression GetParameter(int index);

		// Token: 0x17000091 RID: 145
		// (get) Token: 0x060004AB RID: 1195
		int ParameterCount { get; }
	}
}
