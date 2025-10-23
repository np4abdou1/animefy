using System;
using System.Runtime.InteropServices;

namespace System.Buffers
{
	// Token: 0x02000653 RID: 1619
	public struct MemoryHandle : IDisposable
	{
		// Token: 0x060030F3 RID: 12531 RVA: 0x000C513C File Offset: 0x000C333C
		[CLSCompliant(false)]
		public unsafe MemoryHandle(void* pointer, GCHandle handle = default(GCHandle), IPinnable pinnable = null)
		{
			this._pointer = pointer;
			this._handle = handle;
			this._pinnable = pinnable;
		}

		// Token: 0x170007E4 RID: 2020
		// (get) Token: 0x060030F4 RID: 12532 RVA: 0x000C5153 File Offset: 0x000C3353
		[CLSCompliant(false)]
		public unsafe void* Pointer
		{
			get
			{
				return this._pointer;
			}
		}

		// Token: 0x060030F5 RID: 12533 RVA: 0x000C515B File Offset: 0x000C335B
		public void Dispose()
		{
			if (this._handle.IsAllocated)
			{
				this._handle.Free();
			}
			if (this._pinnable != null)
			{
				this._pinnable.Unpin();
				this._pinnable = null;
			}
			this._pointer = null;
		}

		// Token: 0x04001957 RID: 6487
		private unsafe void* _pointer;

		// Token: 0x04001958 RID: 6488
		private GCHandle _handle;

		// Token: 0x04001959 RID: 6489
		private IPinnable _pinnable;
	}
}
