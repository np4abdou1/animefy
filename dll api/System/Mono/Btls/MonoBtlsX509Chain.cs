using System;
using System.Runtime.InteropServices;

namespace Mono.Btls
{
	// Token: 0x02000050 RID: 80
	internal class MonoBtlsX509Chain : MonoBtlsObject
	{
		// Token: 0x17000057 RID: 87
		// (get) Token: 0x06000205 RID: 517 RVA: 0x00007F4B File Offset: 0x0000614B
		internal new MonoBtlsX509Chain.BoringX509ChainHandle Handle
		{
			get
			{
				return (MonoBtlsX509Chain.BoringX509ChainHandle)base.Handle;
			}
		}

		// Token: 0x06000206 RID: 518
		[DllImport("libmono-btls-shared")]
		private static extern IntPtr mono_btls_x509_chain_new();

		// Token: 0x06000207 RID: 519
		[DllImport("libmono-btls-shared")]
		private static extern int mono_btls_x509_chain_get_count(IntPtr handle);

		// Token: 0x06000208 RID: 520
		[DllImport("libmono-btls-shared")]
		private static extern IntPtr mono_btls_x509_chain_get_cert(IntPtr Handle, int index);

		// Token: 0x06000209 RID: 521
		[DllImport("libmono-btls-shared")]
		private static extern int mono_btls_x509_chain_add_cert(IntPtr chain, IntPtr x509);

		// Token: 0x0600020A RID: 522
		[DllImport("libmono-btls-shared")]
		private static extern IntPtr mono_btls_x509_chain_up_ref(IntPtr handle);

		// Token: 0x0600020B RID: 523
		[DllImport("libmono-btls-shared")]
		private static extern void mono_btls_x509_chain_free(IntPtr handle);

		// Token: 0x0600020C RID: 524 RVA: 0x00007F58 File Offset: 0x00006158
		public MonoBtlsX509Chain() : base(new MonoBtlsX509Chain.BoringX509ChainHandle(MonoBtlsX509Chain.mono_btls_x509_chain_new()))
		{
		}

		// Token: 0x0600020D RID: 525 RVA: 0x000057BA File Offset: 0x000039BA
		internal MonoBtlsX509Chain(MonoBtlsX509Chain.BoringX509ChainHandle handle) : base(handle)
		{
		}

		// Token: 0x17000058 RID: 88
		// (get) Token: 0x0600020E RID: 526 RVA: 0x00007F6A File Offset: 0x0000616A
		public int Count
		{
			get
			{
				return MonoBtlsX509Chain.mono_btls_x509_chain_get_count(this.Handle.DangerousGetHandle());
			}
		}

		// Token: 0x0600020F RID: 527 RVA: 0x00007F7C File Offset: 0x0000617C
		public MonoBtlsX509 GetCertificate(int index)
		{
			if (index >= this.Count)
			{
				throw new IndexOutOfRangeException();
			}
			IntPtr intPtr = MonoBtlsX509Chain.mono_btls_x509_chain_get_cert(this.Handle.DangerousGetHandle(), index);
			base.CheckError(intPtr != IntPtr.Zero, "GetCertificate");
			return new MonoBtlsX509(new MonoBtlsX509.BoringX509Handle(intPtr));
		}

		// Token: 0x06000210 RID: 528 RVA: 0x00007FCB File Offset: 0x000061CB
		public void AddCertificate(MonoBtlsX509 x509)
		{
			MonoBtlsX509Chain.mono_btls_x509_chain_add_cert(this.Handle.DangerousGetHandle(), x509.Handle.DangerousGetHandle());
		}

		// Token: 0x06000211 RID: 529 RVA: 0x00007FEC File Offset: 0x000061EC
		internal MonoBtlsX509Chain Copy()
		{
			IntPtr intPtr = MonoBtlsX509Chain.mono_btls_x509_chain_up_ref(this.Handle.DangerousGetHandle());
			base.CheckError(intPtr != IntPtr.Zero, "Copy");
			return new MonoBtlsX509Chain(new MonoBtlsX509Chain.BoringX509ChainHandle(intPtr));
		}

		// Token: 0x02000051 RID: 81
		internal class BoringX509ChainHandle : MonoBtlsObject.MonoBtlsHandle
		{
			// Token: 0x06000212 RID: 530 RVA: 0x000057D0 File Offset: 0x000039D0
			public BoringX509ChainHandle(IntPtr handle) : base(handle, true)
			{
			}

			// Token: 0x06000213 RID: 531 RVA: 0x0000802B File Offset: 0x0000622B
			protected override bool ReleaseHandle()
			{
				MonoBtlsX509Chain.mono_btls_x509_chain_free(this.handle);
				return true;
			}
		}
	}
}
