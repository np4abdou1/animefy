using System;
using System.Runtime.InteropServices;

namespace Mono.Btls
{
	// Token: 0x02000061 RID: 97
	internal class MonoBtlsX509StoreCtx : MonoBtlsObject
	{
		// Token: 0x1700005D RID: 93
		// (get) Token: 0x0600025B RID: 603 RVA: 0x0000887A File Offset: 0x00006A7A
		internal new MonoBtlsX509StoreCtx.BoringX509StoreCtxHandle Handle
		{
			get
			{
				return (MonoBtlsX509StoreCtx.BoringX509StoreCtxHandle)base.Handle;
			}
		}

		// Token: 0x0600025C RID: 604
		[DllImport("libmono-btls-shared")]
		private static extern IntPtr mono_btls_x509_store_ctx_new();

		// Token: 0x0600025D RID: 605
		[DllImport("libmono-btls-shared")]
		private static extern IntPtr mono_btls_x509_store_ctx_from_ptr(IntPtr ctx);

		// Token: 0x0600025E RID: 606
		[DllImport("libmono-btls-shared")]
		private static extern MonoBtlsX509Error mono_btls_x509_store_ctx_get_error(IntPtr handle, out IntPtr error_string);

		// Token: 0x0600025F RID: 607
		[DllImport("libmono-btls-shared")]
		private static extern IntPtr mono_btls_x509_store_ctx_get_chain(IntPtr handle);

		// Token: 0x06000260 RID: 608
		[DllImport("libmono-btls-shared")]
		private static extern int mono_btls_x509_store_ctx_init(IntPtr handle, IntPtr store, IntPtr chain);

		// Token: 0x06000261 RID: 609
		[DllImport("libmono-btls-shared")]
		private static extern int mono_btls_x509_store_ctx_set_param(IntPtr handle, IntPtr param);

		// Token: 0x06000262 RID: 610
		[DllImport("libmono-btls-shared")]
		private static extern int mono_btls_x509_store_ctx_verify_cert(IntPtr handle);

		// Token: 0x06000263 RID: 611
		[DllImport("libmono-btls-shared")]
		private static extern IntPtr mono_btls_x509_store_ctx_get_untrusted(IntPtr handle);

		// Token: 0x06000264 RID: 612
		[DllImport("libmono-btls-shared")]
		private static extern IntPtr mono_btls_x509_store_ctx_up_ref(IntPtr handle);

		// Token: 0x06000265 RID: 613
		[DllImport("libmono-btls-shared")]
		private static extern void mono_btls_x509_store_ctx_free(IntPtr handle);

		// Token: 0x06000266 RID: 614 RVA: 0x00008887 File Offset: 0x00006A87
		internal MonoBtlsX509StoreCtx() : base(new MonoBtlsX509StoreCtx.BoringX509StoreCtxHandle(MonoBtlsX509StoreCtx.mono_btls_x509_store_ctx_new(), true))
		{
		}

		// Token: 0x06000267 RID: 615 RVA: 0x0000889A File Offset: 0x00006A9A
		private static MonoBtlsX509StoreCtx.BoringX509StoreCtxHandle Create_internal(IntPtr store_ctx)
		{
			IntPtr intPtr = MonoBtlsX509StoreCtx.mono_btls_x509_store_ctx_from_ptr(store_ctx);
			if (intPtr == IntPtr.Zero)
			{
				throw new MonoBtlsException();
			}
			return new MonoBtlsX509StoreCtx.BoringX509StoreCtxHandle(intPtr, true);
		}

		// Token: 0x06000268 RID: 616 RVA: 0x000088BB File Offset: 0x00006ABB
		internal MonoBtlsX509StoreCtx(int preverify_ok, IntPtr store_ctx) : base(MonoBtlsX509StoreCtx.Create_internal(store_ctx))
		{
			this.verifyResult = new int?(preverify_ok);
		}

		// Token: 0x06000269 RID: 617 RVA: 0x000088D5 File Offset: 0x00006AD5
		internal MonoBtlsX509StoreCtx(MonoBtlsX509StoreCtx.BoringX509StoreCtxHandle ptr, int? verifyResult) : base(ptr)
		{
			this.verifyResult = verifyResult;
		}

		// Token: 0x0600026A RID: 618 RVA: 0x000088E8 File Offset: 0x00006AE8
		public MonoBtlsX509Error GetError()
		{
			IntPtr intPtr;
			return MonoBtlsX509StoreCtx.mono_btls_x509_store_ctx_get_error(this.Handle.DangerousGetHandle(), out intPtr);
		}

		// Token: 0x0600026B RID: 619 RVA: 0x00008908 File Offset: 0x00006B08
		public MonoBtlsX509Chain GetChain()
		{
			IntPtr intPtr = MonoBtlsX509StoreCtx.mono_btls_x509_store_ctx_get_chain(this.Handle.DangerousGetHandle());
			base.CheckError(intPtr != IntPtr.Zero, "GetChain");
			return new MonoBtlsX509Chain(new MonoBtlsX509Chain.BoringX509ChainHandle(intPtr));
		}

		// Token: 0x0600026C RID: 620 RVA: 0x00008948 File Offset: 0x00006B48
		public MonoBtlsX509Chain GetUntrusted()
		{
			IntPtr intPtr = MonoBtlsX509StoreCtx.mono_btls_x509_store_ctx_get_untrusted(this.Handle.DangerousGetHandle());
			base.CheckError(intPtr != IntPtr.Zero, "GetUntrusted");
			return new MonoBtlsX509Chain(new MonoBtlsX509Chain.BoringX509ChainHandle(intPtr));
		}

		// Token: 0x0600026D RID: 621 RVA: 0x00008988 File Offset: 0x00006B88
		public void Initialize(MonoBtlsX509Store store, MonoBtlsX509Chain chain)
		{
			int ret = MonoBtlsX509StoreCtx.mono_btls_x509_store_ctx_init(this.Handle.DangerousGetHandle(), store.Handle.DangerousGetHandle(), chain.Handle.DangerousGetHandle());
			base.CheckError(ret, "Initialize");
		}

		// Token: 0x0600026E RID: 622 RVA: 0x000089C8 File Offset: 0x00006BC8
		public void SetVerifyParam(MonoBtlsX509VerifyParam param)
		{
			int ret = MonoBtlsX509StoreCtx.mono_btls_x509_store_ctx_set_param(this.Handle.DangerousGetHandle(), param.Handle.DangerousGetHandle());
			base.CheckError(ret, "SetVerifyParam");
		}

		// Token: 0x1700005E RID: 94
		// (get) Token: 0x0600026F RID: 623 RVA: 0x000089FD File Offset: 0x00006BFD
		public int VerifyResult
		{
			get
			{
				if (this.verifyResult == null)
				{
					throw new InvalidOperationException();
				}
				return this.verifyResult.Value;
			}
		}

		// Token: 0x06000270 RID: 624 RVA: 0x00008A1D File Offset: 0x00006C1D
		public int Verify()
		{
			this.verifyResult = new int?(MonoBtlsX509StoreCtx.mono_btls_x509_store_ctx_verify_cert(this.Handle.DangerousGetHandle()));
			return this.verifyResult.Value;
		}

		// Token: 0x06000271 RID: 625 RVA: 0x00008A48 File Offset: 0x00006C48
		public MonoBtlsX509StoreCtx Copy()
		{
			IntPtr intPtr = MonoBtlsX509StoreCtx.mono_btls_x509_store_ctx_up_ref(this.Handle.DangerousGetHandle());
			base.CheckError(intPtr != IntPtr.Zero, "Copy");
			return new MonoBtlsX509StoreCtx(new MonoBtlsX509StoreCtx.BoringX509StoreCtxHandle(intPtr, true), this.verifyResult);
		}

		// Token: 0x04000146 RID: 326
		private int? verifyResult;

		// Token: 0x02000062 RID: 98
		internal class BoringX509StoreCtxHandle : MonoBtlsObject.MonoBtlsHandle
		{
			// Token: 0x06000272 RID: 626 RVA: 0x00008A8E File Offset: 0x00006C8E
			internal BoringX509StoreCtxHandle(IntPtr handle, bool ownsHandle = true) : base(handle, ownsHandle)
			{
				this.dontFree = !ownsHandle;
			}

			// Token: 0x06000273 RID: 627 RVA: 0x00008AA2 File Offset: 0x00006CA2
			protected override bool ReleaseHandle()
			{
				if (!this.dontFree)
				{
					MonoBtlsX509StoreCtx.mono_btls_x509_store_ctx_free(this.handle);
				}
				return true;
			}

			// Token: 0x04000147 RID: 327
			private bool dontFree;
		}
	}
}
