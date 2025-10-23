using System;
using System.Runtime.InteropServices;

namespace Mono.Btls
{
	// Token: 0x0200002C RID: 44
	internal class MonoBtlsBio : MonoBtlsObject
	{
		// Token: 0x060000F7 RID: 247 RVA: 0x000057BA File Offset: 0x000039BA
		internal MonoBtlsBio(MonoBtlsBio.BoringBioHandle handle) : base(handle)
		{
		}

		// Token: 0x17000047 RID: 71
		// (get) Token: 0x060000F8 RID: 248 RVA: 0x000057C3 File Offset: 0x000039C3
		protected internal new MonoBtlsBio.BoringBioHandle Handle
		{
			get
			{
				return (MonoBtlsBio.BoringBioHandle)base.Handle;
			}
		}

		// Token: 0x060000F9 RID: 249
		[DllImport("libmono-btls-shared")]
		private static extern void mono_btls_bio_free(IntPtr handle);

		// Token: 0x0200002D RID: 45
		protected internal class BoringBioHandle : MonoBtlsObject.MonoBtlsHandle
		{
			// Token: 0x060000FA RID: 250 RVA: 0x000057D0 File Offset: 0x000039D0
			public BoringBioHandle(IntPtr handle) : base(handle, true)
			{
			}

			// Token: 0x060000FB RID: 251 RVA: 0x000057DA File Offset: 0x000039DA
			protected override bool ReleaseHandle()
			{
				if (this.handle != IntPtr.Zero)
				{
					MonoBtlsBio.mono_btls_bio_free(this.handle);
					this.handle = IntPtr.Zero;
				}
				return true;
			}
		}
	}
}
