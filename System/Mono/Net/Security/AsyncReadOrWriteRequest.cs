using System;

namespace Mono.Net.Security
{
	// Token: 0x02000010 RID: 16
	internal abstract class AsyncReadOrWriteRequest : AsyncProtocolRequest
	{
		// Token: 0x17000010 RID: 16
		// (get) Token: 0x06000043 RID: 67 RVA: 0x00002DB7 File Offset: 0x00000FB7
		protected BufferOffsetSize UserBuffer { get; }

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x06000044 RID: 68 RVA: 0x00002DBF File Offset: 0x00000FBF
		// (set) Token: 0x06000045 RID: 69 RVA: 0x00002DC7 File Offset: 0x00000FC7
		protected int CurrentSize { get; set; }

		// Token: 0x06000046 RID: 70 RVA: 0x00002DD0 File Offset: 0x00000FD0
		public AsyncReadOrWriteRequest(MobileAuthenticatedStream parent, bool sync, byte[] buffer, int offset, int size) : base(parent, sync)
		{
			this.UserBuffer = new BufferOffsetSize(buffer, offset, size);
		}

		// Token: 0x06000047 RID: 71 RVA: 0x00002DEA File Offset: 0x00000FEA
		public override string ToString()
		{
			return string.Format("[{0}: {1}]", base.Name, this.UserBuffer);
		}
	}
}
