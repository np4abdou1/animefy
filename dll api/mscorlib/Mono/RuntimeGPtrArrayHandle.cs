using System;
using System.Runtime.CompilerServices;

namespace Mono
{
	// Token: 0x02000018 RID: 24
	internal struct RuntimeGPtrArrayHandle
	{
		// Token: 0x06000048 RID: 72 RVA: 0x000027F5 File Offset: 0x000009F5
		internal unsafe RuntimeGPtrArrayHandle(IntPtr ptr)
		{
			this.value = (RuntimeStructs.GPtrArray*)((void*)ptr);
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x06000049 RID: 73 RVA: 0x00002803 File Offset: 0x00000A03
		internal unsafe int Length
		{
			get
			{
				return this.value->len;
			}
		}

		// Token: 0x1700000C RID: 12
		internal IntPtr this[int i]
		{
			get
			{
				return this.Lookup(i);
			}
		}

		// Token: 0x0600004B RID: 75 RVA: 0x00002819 File Offset: 0x00000A19
		internal unsafe IntPtr Lookup(int i)
		{
			if (i >= 0 && i < this.Length)
			{
				return this.value->data[i];
			}
			throw new IndexOutOfRangeException();
		}

		// Token: 0x0600004C RID: 76
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern void GPtrArrayFree(RuntimeStructs.GPtrArray* value);

		// Token: 0x0600004D RID: 77 RVA: 0x00002844 File Offset: 0x00000A44
		internal static void DestroyAndFree(ref RuntimeGPtrArrayHandle h)
		{
			RuntimeGPtrArrayHandle.GPtrArrayFree(h.value);
			h.value = null;
		}

		// Token: 0x0400008E RID: 142
		private unsafe RuntimeStructs.GPtrArray* value;
	}
}
