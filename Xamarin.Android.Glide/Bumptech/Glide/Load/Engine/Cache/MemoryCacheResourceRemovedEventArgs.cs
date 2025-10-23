using System;

namespace Bumptech.Glide.Load.Engine.Cache
{
	// Token: 0x0200016A RID: 362
	public class MemoryCacheResourceRemovedEventArgs : EventArgs
	{
		// Token: 0x060011F6 RID: 4598 RVA: 0x0003A07F File Offset: 0x0003827F
		public MemoryCacheResourceRemovedEventArgs(IResource p0)
		{
			this.p0 = p0;
		}

		// Token: 0x170004C8 RID: 1224
		// (get) Token: 0x060011F7 RID: 4599 RVA: 0x0003A08E File Offset: 0x0003828E
		public IResource P0
		{
			get
			{
				return this.p0;
			}
		}

		// Token: 0x04000428 RID: 1064
		private IResource p0;
	}
}
