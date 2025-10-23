using System;

namespace Mono
{
	// Token: 0x02000027 RID: 39
	internal struct SafeGPtrArrayHandle : IDisposable
	{
		// Token: 0x06000054 RID: 84 RVA: 0x00002991 File Offset: 0x00000B91
		internal SafeGPtrArrayHandle(IntPtr ptr)
		{
			this.handle = new RuntimeGPtrArrayHandle(ptr);
		}

		// Token: 0x06000055 RID: 85 RVA: 0x0000299F File Offset: 0x00000B9F
		public void Dispose()
		{
			RuntimeGPtrArrayHandle.DestroyAndFree(ref this.handle);
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x06000056 RID: 86 RVA: 0x000029AC File Offset: 0x00000BAC
		internal int Length
		{
			get
			{
				return this.handle.Length;
			}
		}

		// Token: 0x1700000E RID: 14
		internal IntPtr this[int i]
		{
			get
			{
				return this.handle[i];
			}
		}

		// Token: 0x040000B8 RID: 184
		private RuntimeGPtrArrayHandle handle;
	}
}
