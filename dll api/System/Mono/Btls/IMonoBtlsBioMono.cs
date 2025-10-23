using System;

namespace Mono.Btls
{
	// Token: 0x0200002F RID: 47
	internal interface IMonoBtlsBioMono
	{
		// Token: 0x06000100 RID: 256
		int Read(byte[] buffer, int offset, int size, out bool wantMore);

		// Token: 0x06000101 RID: 257
		bool Write(byte[] buffer, int offset, int size);

		// Token: 0x06000102 RID: 258
		void Flush();

		// Token: 0x06000103 RID: 259
		void Close();
	}
}
