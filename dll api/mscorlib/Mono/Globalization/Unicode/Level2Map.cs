using System;

namespace Mono.Globalization.Unicode
{
	// Token: 0x02000037 RID: 55
	internal class Level2Map
	{
		// Token: 0x060000AA RID: 170 RVA: 0x00003AE1 File Offset: 0x00001CE1
		public Level2Map(byte source, byte replace)
		{
			this.Source = source;
			this.Replace = replace;
		}

		// Token: 0x040000E3 RID: 227
		public byte Source;

		// Token: 0x040000E4 RID: 228
		public byte Replace;
	}
}
