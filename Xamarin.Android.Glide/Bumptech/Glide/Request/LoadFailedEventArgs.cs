using System;
using Bumptech.Glide.Load.Engine;
using Bumptech.Glide.Request.Target;
using Java.Lang;

namespace Bumptech.Glide.Request
{
	// Token: 0x02000092 RID: 146
	public class LoadFailedEventArgs : EventArgs
	{
		// Token: 0x17000186 RID: 390
		// (get) Token: 0x06000781 RID: 1921 RVA: 0x000176AA File Offset: 0x000158AA
		// (set) Token: 0x06000782 RID: 1922 RVA: 0x000176B2 File Offset: 0x000158B2
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

		// Token: 0x06000783 RID: 1923 RVA: 0x000176BB File Offset: 0x000158BB
		public LoadFailedEventArgs(bool handled, GlideException p0, Java.Lang.Object p1, ITarget p2, bool p3)
		{
			this.handled = handled;
			this.p0 = p0;
			this.p1 = p1;
			this.p2 = p2;
			this.p3 = p3;
		}

		// Token: 0x17000187 RID: 391
		// (get) Token: 0x06000784 RID: 1924 RVA: 0x000176E8 File Offset: 0x000158E8
		public GlideException P0
		{
			get
			{
				return this.p0;
			}
		}

		// Token: 0x17000188 RID: 392
		// (get) Token: 0x06000785 RID: 1925 RVA: 0x000176F0 File Offset: 0x000158F0
		public Java.Lang.Object P1
		{
			get
			{
				return this.p1;
			}
		}

		// Token: 0x17000189 RID: 393
		// (get) Token: 0x06000786 RID: 1926 RVA: 0x000176F8 File Offset: 0x000158F8
		public ITarget P2
		{
			get
			{
				return this.p2;
			}
		}

		// Token: 0x1700018A RID: 394
		// (get) Token: 0x06000787 RID: 1927 RVA: 0x00017700 File Offset: 0x00015900
		public bool P3
		{
			get
			{
				return this.p3;
			}
		}

		// Token: 0x040001CC RID: 460
		private bool handled;

		// Token: 0x040001CD RID: 461
		private GlideException p0;

		// Token: 0x040001CE RID: 462
		private Java.Lang.Object p1;

		// Token: 0x040001CF RID: 463
		private ITarget p2;

		// Token: 0x040001D0 RID: 464
		private bool p3;
	}
}
