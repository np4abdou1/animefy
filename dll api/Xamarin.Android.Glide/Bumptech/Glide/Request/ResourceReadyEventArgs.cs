using System;
using Bumptech.Glide.Load;
using Bumptech.Glide.Request.Target;
using Java.Lang;

namespace Bumptech.Glide.Request
{
	// Token: 0x02000093 RID: 147
	public class ResourceReadyEventArgs : EventArgs
	{
		// Token: 0x1700018B RID: 395
		// (get) Token: 0x06000788 RID: 1928 RVA: 0x00017708 File Offset: 0x00015908
		// (set) Token: 0x06000789 RID: 1929 RVA: 0x00017710 File Offset: 0x00015910
		public bool Handled
		{
			get
			{
				return this.handled;
			}
			set
			{
				this.handled = value;
			}
		}

		// Token: 0x0600078A RID: 1930 RVA: 0x00017719 File Offset: 0x00015919
		public ResourceReadyEventArgs(bool handled, Java.Lang.Object p0, Java.Lang.Object p1, ITarget p2, DataSource p3, bool p4)
		{
			this.handled = handled;
			this.p0 = p0;
			this.p1 = p1;
			this.p2 = p2;
			this.p3 = p3;
			this.p4 = p4;
		}

		// Token: 0x1700018C RID: 396
		// (get) Token: 0x0600078B RID: 1931 RVA: 0x0001774E File Offset: 0x0001594E
		public Java.Lang.Object P0
		{
			get
			{
				return this.p0;
			}
		}

		// Token: 0x1700018D RID: 397
		// (get) Token: 0x0600078C RID: 1932 RVA: 0x00017756 File Offset: 0x00015956
		public Java.Lang.Object P1
		{
			get
			{
				return this.p1;
			}
		}

		// Token: 0x1700018E RID: 398
		// (get) Token: 0x0600078D RID: 1933 RVA: 0x0001775E File Offset: 0x0001595E
		public ITarget P2
		{
			get
			{
				return this.p2;
			}
		}

		// Token: 0x1700018F RID: 399
		// (get) Token: 0x0600078E RID: 1934 RVA: 0x00017766 File Offset: 0x00015966
		public DataSource P3
		{
			get
			{
				return this.p3;
			}
		}

		// Token: 0x17000190 RID: 400
		// (get) Token: 0x0600078F RID: 1935 RVA: 0x0001776E File Offset: 0x0001596E
		public bool P4
		{
			get
			{
				return this.p4;
			}
		}

		// Token: 0x040001D1 RID: 465
		private bool handled;

		// Token: 0x040001D2 RID: 466
		private Java.Lang.Object p0;

		// Token: 0x040001D3 RID: 467
		private Java.Lang.Object p1;

		// Token: 0x040001D4 RID: 468
		private ITarget p2;

		// Token: 0x040001D5 RID: 469
		private DataSource p3;

		// Token: 0x040001D6 RID: 470
		private bool p4;
	}
}
