using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

namespace Newtonsoft.Json.Utilities
{
	// Token: 0x020000F5 RID: 245
	internal static class ValidationUtils
	{
		// Token: 0x06000733 RID: 1843 RVA: 0x000248D4 File Offset: 0x00022AD4
		[NullableContext(1)]
		public static void ArgumentNotNull([Nullable(2)] [NotNull] object value, string parameterName)
		{
			if (value == null)
			{
				throw new ArgumentNullException(parameterName);
			}
		}
	}
}
