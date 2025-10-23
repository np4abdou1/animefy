using System;
using System.Runtime.InteropServices;

namespace SQLitePCL
{
	// Token: 0x0200002D RID: 45
	public class hook_handle : SafeGCHandle
	{
		// Token: 0x060001C6 RID: 454 RVA: 0x00003415 File Offset: 0x00001615
		public hook_handle(object target) : base(target, GCHandleType.Normal)
		{
		}

		// Token: 0x060001C7 RID: 455 RVA: 0x0000341F File Offset: 0x0000161F
		public IDisposable ForDispose()
		{
			if (this.IsInvalid)
			{
				return null;
			}
			return this;
		}
	}
}
