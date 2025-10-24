using System;
using System.Runtime.CompilerServices;

namespace Newtonsoft.Json.Utilities
{
	// Token: 0x020000BD RID: 189
	[NullableContext(1)]
	[Nullable(0)]
	internal class EnumInfo
	{
		// Token: 0x060005EB RID: 1515 RVA: 0x0001F887 File Offset: 0x0001DA87
		public EnumInfo(bool isFlags, ulong[] values, string[] names, string[] resolvedNames)
		{
			this.IsFlags = isFlags;
			this.Values = values;
			this.Names = names;
			this.ResolvedNames = resolvedNames;
		}

		// Token: 0x04000436 RID: 1078
		public readonly bool IsFlags;

		// Token: 0x04000437 RID: 1079
		public readonly ulong[] Values;

		// Token: 0x04000438 RID: 1080
		public readonly string[] Names;

		// Token: 0x04000439 RID: 1081
		public readonly string[] ResolvedNames;
	}
}
