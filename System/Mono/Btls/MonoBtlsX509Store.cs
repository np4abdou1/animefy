using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

namespace Mono.Btls
{
	// Token: 0x0200005F RID: 95
	internal class MonoBtlsX509Store : MonoBtlsObject
	{
		// Token: 0x1700005C RID: 92
		// (get) Token: 0x0600024A RID: 586 RVA: 0x000086DA File Offset: 0x000068DA
		internal new MonoBtlsX509Store.BoringX509StoreHandle Handle
		{
			get
			{
				return (MonoBtlsX509Store.BoringX509StoreHandle)base.Handle;
			}
		}

		// Token: 0x0600024B RID: 587
		[DllImport("libmono-btls-shared")]
		private static extern IntPtr mono_btls_x509_store_new();

		// Token: 0x0600024C RID: 588
		[DllImport("libmono-btls-shared")]
		private static extern IntPtr mono_btls_x509_store_from_ssl_ctx(IntPtr handle);

		// Token: 0x0600024D RID: 589
		[DllImport("libmono-btls-shared")]
		private static extern int mono_btls_x509_store_set_default_paths(IntPtr handle);

		// Token: 0x0600024E RID: 590
		[DllImport("libmono-btls-shared")]
		private static extern int mono_btls_x509_store_add_cert(IntPtr handle, IntPtr x509);

		// Token: 0x0600024F RID: 591
		[DllImport("libmono-btls-shared")]
		private static extern void mono_btls_x509_store_free(IntPtr handle);

		// Token: 0x06000250 RID: 592 RVA: 0x000086E8 File Offset: 0x000068E8
		public void SetDefaultPaths()
		{
			int ret = MonoBtlsX509Store.mono_btls_x509_store_set_default_paths(this.Handle.DangerousGetHandle());
			base.CheckError(ret, "SetDefaultPaths");
		}

		// Token: 0x06000251 RID: 593 RVA: 0x00008712 File Offset: 0x00006912
		private static MonoBtlsX509Store.BoringX509StoreHandle Create_internal()
		{
			IntPtr intPtr = MonoBtlsX509Store.mono_btls_x509_store_new();
			if (intPtr == IntPtr.Zero)
			{
				throw new MonoBtlsException();
			}
			return new MonoBtlsX509Store.BoringX509StoreHandle(intPtr);
		}

		// Token: 0x06000252 RID: 594 RVA: 0x00008731 File Offset: 0x00006931
		private static MonoBtlsX509Store.BoringX509StoreHandle Create_internal(MonoBtlsSslCtx.BoringSslCtxHandle ctx)
		{
			IntPtr intPtr = MonoBtlsX509Store.mono_btls_x509_store_from_ssl_ctx(ctx.DangerousGetHandle());
			if (intPtr == IntPtr.Zero)
			{
				throw new MonoBtlsException();
			}
			return new MonoBtlsX509Store.BoringX509StoreHandle(intPtr);
		}

		// Token: 0x06000253 RID: 595 RVA: 0x00008756 File Offset: 0x00006956
		internal MonoBtlsX509Store() : base(MonoBtlsX509Store.Create_internal())
		{
		}

		// Token: 0x06000254 RID: 596 RVA: 0x00008763 File Offset: 0x00006963
		internal MonoBtlsX509Store(MonoBtlsSslCtx.BoringSslCtxHandle ctx) : base(MonoBtlsX509Store.Create_internal(ctx))
		{
		}

		// Token: 0x06000255 RID: 597 RVA: 0x00008774 File Offset: 0x00006974
		public void AddCertificate(MonoBtlsX509 x509)
		{
			int ret = MonoBtlsX509Store.mono_btls_x509_store_add_cert(this.Handle.DangerousGetHandle(), x509.Handle.DangerousGetHandle());
			base.CheckError(ret, "AddCertificate");
		}

		// Token: 0x06000256 RID: 598 RVA: 0x000087AC File Offset: 0x000069AC
		public void AddCollection(X509CertificateCollection collection, MonoBtlsX509TrustKind trust)
		{
			MonoBtlsX509LookupMonoCollection monoLookup = new MonoBtlsX509LookupMonoCollection(collection, trust);
			new MonoBtlsX509Lookup(this, MonoBtlsX509LookupType.MONO).AddMono(monoLookup);
		}

		// Token: 0x06000257 RID: 599 RVA: 0x000087D0 File Offset: 0x000069D0
		public void AddAndroidLookup()
		{
			MonoBtlsX509LookupAndroid monoLookup = new MonoBtlsX509LookupAndroid();
			new MonoBtlsX509Lookup(this, MonoBtlsX509LookupType.MONO).AddMono(monoLookup);
		}

		// Token: 0x06000258 RID: 600 RVA: 0x000087F0 File Offset: 0x000069F0
		protected override void Close()
		{
			try
			{
				if (this.lookupHash != null)
				{
					foreach (MonoBtlsX509Lookup monoBtlsX509Lookup in this.lookupHash.Values)
					{
						monoBtlsX509Lookup.Dispose();
					}
					this.lookupHash = null;
				}
			}
			finally
			{
				base.Close();
			}
		}

		// Token: 0x04000145 RID: 325
		private Dictionary<IntPtr, MonoBtlsX509Lookup> lookupHash;

		// Token: 0x02000060 RID: 96
		internal class BoringX509StoreHandle : MonoBtlsObject.MonoBtlsHandle
		{
			// Token: 0x06000259 RID: 601 RVA: 0x000057D0 File Offset: 0x000039D0
			public BoringX509StoreHandle(IntPtr handle) : base(handle, true)
			{
			}

			// Token: 0x0600025A RID: 602 RVA: 0x0000886C File Offset: 0x00006A6C
			protected override bool ReleaseHandle()
			{
				MonoBtlsX509Store.mono_btls_x509_store_free(this.handle);
				return true;
			}
		}
	}
}
