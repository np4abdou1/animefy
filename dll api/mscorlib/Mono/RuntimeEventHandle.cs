using System;

namespace Mono
{
	// Token: 0x02000016 RID: 22
	internal struct RuntimeEventHandle
	{
		// Token: 0x06000040 RID: 64 RVA: 0x00002726 File Offset: 0x00000926
		internal RuntimeEventHandle(IntPtr v)
		{
			this.value = v;
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x06000041 RID: 65 RVA: 0x0000272F File Offset: 0x0000092F
		public IntPtr Value
		{
			get
			{
				return this.value;
			}
		}

		// Token: 0x06000042 RID: 66 RVA: 0x00002738 File Offset: 0x00000938
		public override bool Equals(object obj)
		{
			return obj != null && !(base.GetType() != obj.GetType()) && this.value == ((RuntimeEventHandle)obj).Value;
		}

		// Token: 0x06000043 RID: 67 RVA: 0x00002780 File Offset: 0x00000980
		public override int GetHashCode()
		{
			return this.value.GetHashCode();
		}

		// Token: 0x0400008C RID: 140
		private IntPtr value;
	}
}
