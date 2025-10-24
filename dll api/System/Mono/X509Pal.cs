using System;

namespace Mono
{
	// Token: 0x02000004 RID: 4
	internal static class X509Pal
	{
		// Token: 0x17000006 RID: 6
		// (get) Token: 0x06000012 RID: 18 RVA: 0x000022DE File Offset: 0x000004DE
		public static X509PalImpl Instance
		{
			get
			{
				return SystemDependencyProvider.Instance.X509Pal;
			}
		}
	}
}
