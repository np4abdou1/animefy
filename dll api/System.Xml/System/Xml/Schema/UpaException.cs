using System;

namespace System.Xml.Schema
{
	// Token: 0x02000234 RID: 564
	internal class UpaException : Exception
	{
		// Token: 0x06001292 RID: 4754 RVA: 0x00071AA8 File Offset: 0x0006FCA8
		public UpaException(object particle1, object particle2)
		{
			this.particle1 = particle1;
			this.particle2 = particle2;
		}

		// Token: 0x170003DC RID: 988
		// (get) Token: 0x06001293 RID: 4755 RVA: 0x00071ABE File Offset: 0x0006FCBE
		public object Particle1
		{
			get
			{
				return this.particle1;
			}
		}

		// Token: 0x170003DD RID: 989
		// (get) Token: 0x06001294 RID: 4756 RVA: 0x00071AC6 File Offset: 0x0006FCC6
		public object Particle2
		{
			get
			{
				return this.particle2;
			}
		}

		// Token: 0x04000C8F RID: 3215
		private object particle1;

		// Token: 0x04000C90 RID: 3216
		private object particle2;
	}
}
