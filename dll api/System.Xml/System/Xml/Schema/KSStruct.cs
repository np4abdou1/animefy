using System;

namespace System.Xml.Schema
{
	// Token: 0x02000230 RID: 560
	internal class KSStruct
	{
		// Token: 0x06001278 RID: 4728 RVA: 0x0007148F File Offset: 0x0006F68F
		public KSStruct(KeySequence ks, int dim)
		{
			this.ks = ks;
			this.fields = new LocatedActiveAxis[dim];
		}

		// Token: 0x04000C7F RID: 3199
		public int depth;

		// Token: 0x04000C80 RID: 3200
		public KeySequence ks;

		// Token: 0x04000C81 RID: 3201
		public LocatedActiveAxis[] fields;
	}
}
