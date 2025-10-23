using System;
using System.Runtime.InteropServices;

namespace Mono.Btls
{
	// Token: 0x0200002E RID: 46
	internal class MonoBtlsBioMemory : MonoBtlsBio
	{
		// Token: 0x060000FC RID: 252
		[DllImport("libmono-btls-shared")]
		private static extern IntPtr mono_btls_bio_mem_new();

		// Token: 0x060000FD RID: 253
		[DllImport("libmono-btls-shared")]
		private static extern int mono_btls_bio_mem_get_data(IntPtr handle, out IntPtr data);

		// Token: 0x060000FE RID: 254 RVA: 0x00005805 File Offset: 0x00003A05
		public MonoBtlsBioMemory() : base(new MonoBtlsBio.BoringBioHandle(MonoBtlsBioMemory.mono_btls_bio_mem_new()))
		{
		}

		// Token: 0x060000FF RID: 255 RVA: 0x00005818 File Offset: 0x00003A18
		public byte[] GetData()
		{
			bool flag = false;
			byte[] result;
			try
			{
				base.Handle.DangerousAddRef(ref flag);
				IntPtr source;
				int num = MonoBtlsBioMemory.mono_btls_bio_mem_get_data(base.Handle.DangerousGetHandle(), out source);
				base.CheckError(num > 0, "GetData");
				byte[] array = new byte[num];
				Marshal.Copy(source, array, 0, num);
				result = array;
			}
			finally
			{
				if (flag)
				{
					base.Handle.DangerousRelease();
				}
			}
			return result;
		}
	}
}
