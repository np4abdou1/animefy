using System;

namespace Mono
{
	// Token: 0x02000017 RID: 23
	internal struct RuntimePropertyHandle
	{
		// Token: 0x06000044 RID: 68 RVA: 0x0000278D File Offset: 0x0000098D
		internal RuntimePropertyHandle(IntPtr v)
		{
			this.value = v;
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x06000045 RID: 69 RVA: 0x00002796 File Offset: 0x00000996
		public IntPtr Value
		{
			get
			{
				return this.value;
			}
		}

		// Token: 0x06000046 RID: 70 RVA: 0x000027A0 File Offset: 0x000009A0
		public override bool Equals(object obj)
		{
			return obj != null && !(base.GetType() != obj.GetType()) && this.value == ((RuntimePropertyHandle)obj).Value;
		}

		// Token: 0x06000047 RID: 71 RVA: 0x000027E8 File Offset: 0x000009E8
		public override int GetHashCode()
		{
			return this.value.GetHashCode();
		}

		// Token: 0x0400008D RID: 141
		private IntPtr value;
	}
}
