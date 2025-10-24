using System;

namespace System.Linq.Expressions.Compiler
{
	// Token: 0x020000DC RID: 220
	internal static class ParameterProviderExtensions
	{
		// Token: 0x060006FA RID: 1786 RVA: 0x000160F8 File Offset: 0x000142F8
		public static int IndexOf(this IParameterProvider provider, ParameterExpression parameter)
		{
			int i = 0;
			int parameterCount = provider.ParameterCount;
			while (i < parameterCount)
			{
				if (provider.GetParameter(i) == parameter)
				{
					return i;
				}
				i++;
			}
			return -1;
		}

		// Token: 0x060006FB RID: 1787 RVA: 0x00016125 File Offset: 0x00014325
		public static bool Contains(this IParameterProvider provider, ParameterExpression parameter)
		{
			return provider.IndexOf(parameter) >= 0;
		}
	}
}
