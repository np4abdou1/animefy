using System;

namespace System.Threading
{
	// Token: 0x020001C6 RID: 454
	public class Lock
	{
		// Token: 0x060010D5 RID: 4309 RVA: 0x00045791 File Offset: 0x00043991
		public void Acquire()
		{
			Monitor.Enter(this._lock);
		}

		// Token: 0x060010D6 RID: 4310 RVA: 0x0004579E File Offset: 0x0004399E
		public void Release()
		{
			Monitor.Exit(this._lock);
		}

		// Token: 0x04000670 RID: 1648
		private object _lock = new object();
	}
}
