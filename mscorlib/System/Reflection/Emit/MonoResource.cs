using System;
using System.IO;

namespace System.Reflection.Emit
{
	// Token: 0x020004ED RID: 1261
	internal struct MonoResource
	{
		// Token: 0x040011A0 RID: 4512
		public byte[] data;

		// Token: 0x040011A1 RID: 4513
		public string name;

		// Token: 0x040011A2 RID: 4514
		public string filename;

		// Token: 0x040011A3 RID: 4515
		public ResourceAttributes attrs;

		// Token: 0x040011A4 RID: 4516
		public int offset;

		// Token: 0x040011A5 RID: 4517
		public Stream stream;
	}
}
