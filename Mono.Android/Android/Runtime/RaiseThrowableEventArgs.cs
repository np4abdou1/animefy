using System;

namespace Android.Runtime
{
	// Token: 0x020002F2 RID: 754
	public class RaiseThrowableEventArgs : EventArgs
	{
		// Token: 0x06001DE3 RID: 7651 RVA: 0x00051DD1 File Offset: 0x0004FFD1
		public RaiseThrowableEventArgs(Exception e)
		{
			this.Exception = e;
		}

		// Token: 0x17000612 RID: 1554
		// (get) Token: 0x06001DE4 RID: 7652 RVA: 0x00051DE0 File Offset: 0x0004FFE0
		// (set) Token: 0x06001DE5 RID: 7653 RVA: 0x00051DE8 File Offset: 0x0004FFE8
		public Exception Exception { get; private set; }

		// Token: 0x17000613 RID: 1555
		// (get) Token: 0x06001DE6 RID: 7654 RVA: 0x00051DF1 File Offset: 0x0004FFF1
		// (set) Token: 0x06001DE7 RID: 7655 RVA: 0x00051DF9 File Offset: 0x0004FFF9
		public bool Handled
		{
			get
			{
				return this.handled;
			}
			set
			{
				if (value)
				{
					this.handled = value;
				}
			}
		}

		// Token: 0x04000C66 RID: 3174
		private bool handled;
	}
}
