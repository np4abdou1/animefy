using System;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace Mono.Btls
{
	// Token: 0x0200003C RID: 60
	internal class MonoBtlsPkcs12 : MonoBtlsObject
	{
		// Token: 0x1700004F RID: 79
		// (get) Token: 0x0600015F RID: 351 RVA: 0x000067D0 File Offset: 0x000049D0
		internal new MonoBtlsPkcs12.BoringPkcs12Handle Handle
		{
			get
			{
				return (MonoBtlsPkcs12.BoringPkcs12Handle)base.Handle;
			}
		}

		// Token: 0x06000160 RID: 352
		[DllImport("libmono-btls-shared")]
		private static extern void mono_btls_pkcs12_free(IntPtr handle);

		// Token: 0x06000161 RID: 353
		[DllImport("libmono-btls-shared")]
		private static extern IntPtr mono_btls_pkcs12_new();

		// Token: 0x06000162 RID: 354
		[DllImport("libmono-btls-shared")]
		private static extern int mono_btls_pkcs12_get_count(IntPtr handle);

		// Token: 0x06000163 RID: 355
		[DllImport("libmono-btls-shared")]
		private static extern IntPtr mono_btls_pkcs12_get_cert(IntPtr Handle, int index);

		// Token: 0x06000164 RID: 356
		[DllImport("libmono-btls-shared")]
		private unsafe static extern int mono_btls_pkcs12_import(IntPtr chain, void* data, int len, SafePasswordHandle password);

		// Token: 0x06000165 RID: 357
		[DllImport("libmono-btls-shared")]
		private static extern int mono_btls_pkcs12_has_private_key(IntPtr pkcs12);

		// Token: 0x06000166 RID: 358
		[DllImport("libmono-btls-shared")]
		private static extern IntPtr mono_btls_pkcs12_get_private_key(IntPtr pkcs12);

		// Token: 0x06000167 RID: 359 RVA: 0x000067DD File Offset: 0x000049DD
		internal MonoBtlsPkcs12() : base(new MonoBtlsPkcs12.BoringPkcs12Handle(MonoBtlsPkcs12.mono_btls_pkcs12_new()))
		{
		}

		// Token: 0x17000050 RID: 80
		// (get) Token: 0x06000168 RID: 360 RVA: 0x000067EF File Offset: 0x000049EF
		public int Count
		{
			get
			{
				return MonoBtlsPkcs12.mono_btls_pkcs12_get_count(this.Handle.DangerousGetHandle());
			}
		}

		// Token: 0x06000169 RID: 361 RVA: 0x00006804 File Offset: 0x00004A04
		public MonoBtlsX509 GetCertificate(int index)
		{
			if (index >= this.Count)
			{
				throw new IndexOutOfRangeException();
			}
			IntPtr intPtr = MonoBtlsPkcs12.mono_btls_pkcs12_get_cert(this.Handle.DangerousGetHandle(), index);
			base.CheckError(intPtr != IntPtr.Zero, "GetCertificate");
			return new MonoBtlsX509(new MonoBtlsX509.BoringX509Handle(intPtr));
		}

		// Token: 0x0600016A RID: 362 RVA: 0x00006854 File Offset: 0x00004A54
		public unsafe void Import(byte[] buffer, SafePasswordHandle password)
		{
			fixed (byte[] array = buffer)
			{
				void* data;
				if (buffer == null || array.Length == 0)
				{
					data = null;
				}
				else
				{
					data = (void*)(&array[0]);
				}
				int ret = MonoBtlsPkcs12.mono_btls_pkcs12_import(this.Handle.DangerousGetHandle(), data, buffer.Length, password);
				base.CheckError(ret, "Import");
			}
		}

		// Token: 0x17000051 RID: 81
		// (get) Token: 0x0600016B RID: 363 RVA: 0x0000689D File Offset: 0x00004A9D
		public bool HasPrivateKey
		{
			get
			{
				return MonoBtlsPkcs12.mono_btls_pkcs12_has_private_key(this.Handle.DangerousGetHandle()) != 0;
			}
		}

		// Token: 0x0600016C RID: 364 RVA: 0x000068B4 File Offset: 0x00004AB4
		public MonoBtlsKey GetPrivateKey()
		{
			if (!this.HasPrivateKey)
			{
				throw new InvalidOperationException();
			}
			if (this.privateKey == null)
			{
				IntPtr intPtr = MonoBtlsPkcs12.mono_btls_pkcs12_get_private_key(this.Handle.DangerousGetHandle());
				base.CheckError(intPtr != IntPtr.Zero, "GetPrivateKey");
				this.privateKey = new MonoBtlsKey(new MonoBtlsKey.BoringKeyHandle(intPtr));
			}
			return this.privateKey;
		}

		// Token: 0x040000BA RID: 186
		private MonoBtlsKey privateKey;

		// Token: 0x0200003D RID: 61
		internal class BoringPkcs12Handle : MonoBtlsObject.MonoBtlsHandle
		{
			// Token: 0x0600016D RID: 365 RVA: 0x000057D0 File Offset: 0x000039D0
			public BoringPkcs12Handle(IntPtr handle) : base(handle, true)
			{
			}

			// Token: 0x0600016E RID: 366 RVA: 0x00006915 File Offset: 0x00004B15
			protected override bool ReleaseHandle()
			{
				MonoBtlsPkcs12.mono_btls_pkcs12_free(this.handle);
				return true;
			}
		}
	}
}
