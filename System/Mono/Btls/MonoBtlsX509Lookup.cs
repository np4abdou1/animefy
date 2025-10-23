using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace Mono.Btls
{
	// Token: 0x02000054 RID: 84
	internal class MonoBtlsX509Lookup : MonoBtlsObject
	{
		// Token: 0x17000059 RID: 89
		// (get) Token: 0x06000214 RID: 532 RVA: 0x00008039 File Offset: 0x00006239
		internal new MonoBtlsX509Lookup.BoringX509LookupHandle Handle
		{
			get
			{
				return (MonoBtlsX509Lookup.BoringX509LookupHandle)base.Handle;
			}
		}

		// Token: 0x06000215 RID: 533
		[DllImport("libmono-btls-shared")]
		private static extern IntPtr mono_btls_x509_lookup_new(IntPtr store, MonoBtlsX509LookupType type);

		// Token: 0x06000216 RID: 534
		[DllImport("libmono-btls-shared")]
		private static extern int mono_btls_x509_lookup_add_mono(IntPtr handle, IntPtr monoLookup);

		// Token: 0x06000217 RID: 535
		[DllImport("libmono-btls-shared")]
		private static extern void mono_btls_x509_lookup_free(IntPtr handle);

		// Token: 0x06000218 RID: 536 RVA: 0x00008046 File Offset: 0x00006246
		private static MonoBtlsX509Lookup.BoringX509LookupHandle Create_internal(MonoBtlsX509Store store, MonoBtlsX509LookupType type)
		{
			IntPtr intPtr = MonoBtlsX509Lookup.mono_btls_x509_lookup_new(store.Handle.DangerousGetHandle(), type);
			if (intPtr == IntPtr.Zero)
			{
				throw new MonoBtlsException();
			}
			return new MonoBtlsX509Lookup.BoringX509LookupHandle(intPtr);
		}

		// Token: 0x06000219 RID: 537 RVA: 0x00008071 File Offset: 0x00006271
		internal MonoBtlsX509Lookup(MonoBtlsX509Store store, MonoBtlsX509LookupType type) : base(MonoBtlsX509Lookup.Create_internal(store, type))
		{
			this.store = store;
			this.type = type;
		}

		// Token: 0x0600021A RID: 538 RVA: 0x00008090 File Offset: 0x00006290
		internal void AddMono(MonoBtlsX509LookupMono monoLookup)
		{
			if (this.type != MonoBtlsX509LookupType.MONO)
			{
				throw new NotSupportedException();
			}
			int ret = MonoBtlsX509Lookup.mono_btls_x509_lookup_add_mono(this.Handle.DangerousGetHandle(), monoLookup.Handle.DangerousGetHandle());
			base.CheckError(ret, "AddMono");
			monoLookup.Install(this);
			if (this.monoLookups == null)
			{
				this.monoLookups = new List<MonoBtlsX509LookupMono>();
			}
			this.monoLookups.Add(monoLookup);
		}

		// Token: 0x0600021B RID: 539 RVA: 0x000080FA File Offset: 0x000062FA
		internal void AddCertificate(MonoBtlsX509 certificate)
		{
			this.store.AddCertificate(certificate);
		}

		// Token: 0x0600021C RID: 540 RVA: 0x00008108 File Offset: 0x00006308
		protected override void Close()
		{
			try
			{
				if (this.monoLookups != null)
				{
					foreach (MonoBtlsX509LookupMono monoBtlsX509LookupMono in this.monoLookups)
					{
						monoBtlsX509LookupMono.Dispose();
					}
					this.monoLookups = null;
				}
			}
			finally
			{
				base.Close();
			}
		}

		// Token: 0x04000121 RID: 289
		private MonoBtlsX509Store store;

		// Token: 0x04000122 RID: 290
		private MonoBtlsX509LookupType type;

		// Token: 0x04000123 RID: 291
		private List<MonoBtlsX509LookupMono> monoLookups;

		// Token: 0x02000055 RID: 85
		internal class BoringX509LookupHandle : MonoBtlsObject.MonoBtlsHandle
		{
			// Token: 0x0600021D RID: 541 RVA: 0x000057D0 File Offset: 0x000039D0
			public BoringX509LookupHandle(IntPtr handle) : base(handle, true)
			{
			}

			// Token: 0x0600021E RID: 542 RVA: 0x0000817C File Offset: 0x0000637C
			protected override bool ReleaseHandle()
			{
				MonoBtlsX509Lookup.mono_btls_x509_lookup_free(this.handle);
				return true;
			}
		}
	}
}
