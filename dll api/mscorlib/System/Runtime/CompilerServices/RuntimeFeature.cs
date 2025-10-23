using System;

namespace System.Runtime.CompilerServices
{
	/// <summary>A class whose static <see cref="M:System.Runtime.CompilerServices.RuntimeFeature.IsSupported(System.String)" /> method checks whether a specified feature is supported by the common language runtime. </summary>
	// Token: 0x02000450 RID: 1104
	public static class RuntimeFeature
	{
		// Token: 0x17000406 RID: 1030
		// (get) Token: 0x06002017 RID: 8215 RVA: 0x0000B18D File Offset: 0x0000938D
		public static bool IsDynamicCodeSupported
		{
			get
			{
				return true;
			}
		}
	}
}
