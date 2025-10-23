using System;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

namespace Mono.Btls
{
	// Token: 0x02000045 RID: 69
	internal class MonoBtlsSslCtx : MonoBtlsObject
	{
		// Token: 0x17000054 RID: 84
		// (get) Token: 0x060001C1 RID: 449 RVA: 0x0000748B File Offset: 0x0000568B
		internal new MonoBtlsSslCtx.BoringSslCtxHandle Handle
		{
			get
			{
				return (MonoBtlsSslCtx.BoringSslCtxHandle)base.Handle;
			}
		}

		// Token: 0x060001C2 RID: 450
		[DllImport("libmono-btls-shared")]
		private static extern IntPtr mono_btls_ssl_ctx_new();

		// Token: 0x060001C3 RID: 451
		[DllImport("libmono-btls-shared")]
		private static extern int mono_btls_ssl_ctx_free(IntPtr handle);

		// Token: 0x060001C4 RID: 452
		[DllImport("libmono-btls-shared")]
		private static extern void mono_btls_ssl_ctx_initialize(IntPtr handle, IntPtr instance);

		// Token: 0x060001C5 RID: 453
		[DllImport("libmono-btls-shared")]
		private static extern void mono_btls_ssl_ctx_set_cert_verify_callback(IntPtr handle, IntPtr func, int cert_required);

		// Token: 0x060001C6 RID: 454
		[DllImport("libmono-btls-shared")]
		private static extern void mono_btls_ssl_ctx_set_cert_select_callback(IntPtr handle, IntPtr func);

		// Token: 0x060001C7 RID: 455
		[DllImport("libmono-btls-shared")]
		private static extern void mono_btls_ssl_ctx_set_min_version(IntPtr handle, int version);

		// Token: 0x060001C8 RID: 456
		[DllImport("libmono-btls-shared")]
		private static extern void mono_btls_ssl_ctx_set_max_version(IntPtr handle, int version);

		// Token: 0x060001C9 RID: 457
		[DllImport("libmono-btls-shared")]
		private static extern int mono_btls_ssl_ctx_set_ciphers(IntPtr handle, int count, IntPtr data, int allow_unsupported);

		// Token: 0x060001CA RID: 458
		[DllImport("libmono-btls-shared")]
		private static extern int mono_btls_ssl_ctx_set_verify_param(IntPtr handle, IntPtr param);

		// Token: 0x060001CB RID: 459
		[DllImport("libmono-btls-shared")]
		private static extern int mono_btls_ssl_ctx_set_client_ca_list(IntPtr handle, int count, IntPtr sizes, IntPtr data);

		// Token: 0x060001CC RID: 460
		[DllImport("libmono-btls-shared")]
		private static extern void mono_btls_ssl_ctx_set_server_name_callback(IntPtr handle, IntPtr func);

		// Token: 0x060001CD RID: 461 RVA: 0x00007498 File Offset: 0x00005698
		public MonoBtlsSslCtx() : this(new MonoBtlsSslCtx.BoringSslCtxHandle(MonoBtlsSslCtx.mono_btls_ssl_ctx_new()))
		{
		}

		// Token: 0x060001CE RID: 462 RVA: 0x000074AC File Offset: 0x000056AC
		internal MonoBtlsSslCtx(MonoBtlsSslCtx.BoringSslCtxHandle handle) : base(handle)
		{
			this.instance = GCHandle.Alloc(this);
			this.instancePtr = GCHandle.ToIntPtr(this.instance);
			MonoBtlsSslCtx.mono_btls_ssl_ctx_initialize(handle.DangerousGetHandle(), this.instancePtr);
			this.verifyFunc = new MonoBtlsSslCtx.NativeVerifyFunc(MonoBtlsSslCtx.NativeVerifyCallback);
			this.selectFunc = new MonoBtlsSslCtx.NativeSelectFunc(MonoBtlsSslCtx.NativeSelectCallback);
			this.serverNameFunc = new MonoBtlsSslCtx.NativeServerNameFunc(MonoBtlsSslCtx.NativeServerNameCallback);
			this.verifyFuncPtr = Marshal.GetFunctionPointerForDelegate<MonoBtlsSslCtx.NativeVerifyFunc>(this.verifyFunc);
			this.selectFuncPtr = Marshal.GetFunctionPointerForDelegate<MonoBtlsSslCtx.NativeSelectFunc>(this.selectFunc);
			this.serverNameFuncPtr = Marshal.GetFunctionPointerForDelegate<MonoBtlsSslCtx.NativeServerNameFunc>(this.serverNameFunc);
			this.store = new MonoBtlsX509Store(this.Handle);
		}

		// Token: 0x17000055 RID: 85
		// (get) Token: 0x060001CF RID: 463 RVA: 0x00007568 File Offset: 0x00005768
		public MonoBtlsX509Store CertificateStore
		{
			get
			{
				return this.store;
			}
		}

		// Token: 0x060001D0 RID: 464 RVA: 0x00007570 File Offset: 0x00005770
		private int VerifyCallback(bool preverify_ok, MonoBtlsX509StoreCtx ctx)
		{
			if (this.verifyCallback != null)
			{
				return this.verifyCallback(ctx);
			}
			return 0;
		}

		// Token: 0x060001D1 RID: 465 RVA: 0x00007588 File Offset: 0x00005788
		private static int NativeVerifyCallback(IntPtr instance, int preverify_ok, IntPtr store_ctx)
		{
			MonoBtlsSslCtx monoBtlsSslCtx = (MonoBtlsSslCtx)GCHandle.FromIntPtr(instance).Target;
			using (MonoBtlsX509StoreCtx monoBtlsX509StoreCtx = new MonoBtlsX509StoreCtx(preverify_ok, store_ctx))
			{
				try
				{
					return monoBtlsSslCtx.VerifyCallback(preverify_ok != 0, monoBtlsX509StoreCtx);
				}
				catch (Exception exception)
				{
					monoBtlsSslCtx.SetException(exception);
				}
			}
			return 0;
		}

		// Token: 0x060001D2 RID: 466 RVA: 0x000075F8 File Offset: 0x000057F8
		private static int NativeSelectCallback(IntPtr instance, int count, IntPtr sizes, IntPtr data)
		{
			MonoBtlsSslCtx monoBtlsSslCtx = (MonoBtlsSslCtx)GCHandle.FromIntPtr(instance).Target;
			int result;
			try
			{
				string[] acceptableIssuers = MonoBtlsSslCtx.CopyIssuers(count, sizes, data);
				if (monoBtlsSslCtx.selectCallback != null)
				{
					result = monoBtlsSslCtx.selectCallback(acceptableIssuers);
				}
				else
				{
					result = 1;
				}
			}
			catch (Exception exception)
			{
				monoBtlsSslCtx.SetException(exception);
				result = 0;
			}
			return result;
		}

		// Token: 0x060001D3 RID: 467 RVA: 0x00007660 File Offset: 0x00005860
		private static string[] CopyIssuers(int count, IntPtr sizesPtr, IntPtr dataPtr)
		{
			if (count == 0 || sizesPtr == IntPtr.Zero || dataPtr == IntPtr.Zero)
			{
				return null;
			}
			int[] array = new int[count];
			Marshal.Copy(sizesPtr, array, 0, count);
			IntPtr[] array2 = new IntPtr[count];
			Marshal.Copy(dataPtr, array2, 0, count);
			string[] array3 = new string[count];
			for (int i = 0; i < count; i++)
			{
				byte[] array4 = new byte[array[i]];
				Marshal.Copy(array2[i], array4, 0, array4.Length);
				using (MonoBtlsX509Name monoBtlsX509Name = MonoBtlsX509Name.CreateFromData(array4, false))
				{
					array3[i] = MonoBtlsUtils.FormatName(monoBtlsX509Name, true, ", ", true);
				}
			}
			return array3;
		}

		// Token: 0x060001D4 RID: 468 RVA: 0x00007714 File Offset: 0x00005914
		public void SetVerifyCallback(MonoBtlsVerifyCallback callback, bool client_cert_required)
		{
			base.CheckThrow();
			this.verifyCallback = callback;
			MonoBtlsSslCtx.mono_btls_ssl_ctx_set_cert_verify_callback(this.Handle.DangerousGetHandle(), this.verifyFuncPtr, client_cert_required ? 1 : 0);
		}

		// Token: 0x060001D5 RID: 469 RVA: 0x00007740 File Offset: 0x00005940
		public void SetSelectCallback(MonoBtlsSelectCallback callback)
		{
			base.CheckThrow();
			this.selectCallback = callback;
			MonoBtlsSslCtx.mono_btls_ssl_ctx_set_cert_select_callback(this.Handle.DangerousGetHandle(), this.selectFuncPtr);
		}

		// Token: 0x060001D6 RID: 470 RVA: 0x00007765 File Offset: 0x00005965
		public void SetMinVersion(int version)
		{
			base.CheckThrow();
			MonoBtlsSslCtx.mono_btls_ssl_ctx_set_min_version(this.Handle.DangerousGetHandle(), version);
		}

		// Token: 0x060001D7 RID: 471 RVA: 0x0000777E File Offset: 0x0000597E
		public void SetMaxVersion(int version)
		{
			base.CheckThrow();
			MonoBtlsSslCtx.mono_btls_ssl_ctx_set_max_version(this.Handle.DangerousGetHandle(), version);
		}

		// Token: 0x060001D8 RID: 472 RVA: 0x00007798 File Offset: 0x00005998
		public void SetCiphers(short[] ciphers, bool allow_unsupported)
		{
			base.CheckThrow();
			IntPtr intPtr = Marshal.AllocHGlobal(ciphers.Length * 2);
			try
			{
				Marshal.Copy(ciphers, 0, intPtr, ciphers.Length);
				int num = MonoBtlsSslCtx.mono_btls_ssl_ctx_set_ciphers(this.Handle.DangerousGetHandle(), ciphers.Length, intPtr, allow_unsupported ? 1 : 0);
				base.CheckError(num > 0, "SetCiphers");
			}
			finally
			{
				Marshal.FreeHGlobal(intPtr);
			}
		}

		// Token: 0x060001D9 RID: 473 RVA: 0x00007808 File Offset: 0x00005A08
		public void SetVerifyParam(MonoBtlsX509VerifyParam param)
		{
			base.CheckThrow();
			int ret = MonoBtlsSslCtx.mono_btls_ssl_ctx_set_verify_param(this.Handle.DangerousGetHandle(), param.Handle.DangerousGetHandle());
			base.CheckError(ret, "SetVerifyParam");
		}

		// Token: 0x060001DA RID: 474 RVA: 0x00007844 File Offset: 0x00005A44
		public void SetClientCertificateIssuers(string[] acceptableIssuers)
		{
			base.CheckThrow();
			if (acceptableIssuers == null || acceptableIssuers.Length == 0)
			{
				return;
			}
			int num = acceptableIssuers.Length;
			new byte[num][];
			int[] array = new int[num];
			IntPtr[] array2 = new IntPtr[num];
			IntPtr intPtr = IntPtr.Zero;
			IntPtr intPtr2 = IntPtr.Zero;
			try
			{
				for (int i = 0; i < num; i++)
				{
					byte[] rawData = new X500DistinguishedName(acceptableIssuers[i]).RawData;
					array[i] = rawData.Length;
					array2[i] = Marshal.AllocHGlobal(rawData.Length);
					Marshal.Copy(rawData, 0, array2[i], rawData.Length);
				}
				intPtr = Marshal.AllocHGlobal(num * 4);
				Marshal.Copy(array, 0, intPtr, num);
				intPtr2 = Marshal.AllocHGlobal(num * 8);
				Marshal.Copy(array2, 0, intPtr2, num);
				int ret = MonoBtlsSslCtx.mono_btls_ssl_ctx_set_client_ca_list(this.Handle.DangerousGetHandle(), num, intPtr, intPtr2);
				base.CheckError(ret, "SetClientCertificateIssuers");
			}
			finally
			{
				for (int j = 0; j < num; j++)
				{
					if (array2[j] != IntPtr.Zero)
					{
						Marshal.FreeHGlobal(array2[j]);
					}
				}
				if (intPtr != IntPtr.Zero)
				{
					Marshal.FreeHGlobal(intPtr);
				}
				if (intPtr2 != IntPtr.Zero)
				{
					Marshal.FreeHGlobal(intPtr2);
				}
			}
		}

		// Token: 0x060001DB RID: 475 RVA: 0x00007978 File Offset: 0x00005B78
		public void SetServerNameCallback(MonoBtlsServerNameCallback callback)
		{
			base.CheckThrow();
			this.serverNameCallback = callback;
			MonoBtlsSslCtx.mono_btls_ssl_ctx_set_server_name_callback(this.Handle.DangerousGetHandle(), this.serverNameFuncPtr);
		}

		// Token: 0x060001DC RID: 476 RVA: 0x000079A0 File Offset: 0x00005BA0
		private static int NativeServerNameCallback(IntPtr instance)
		{
			MonoBtlsSslCtx monoBtlsSslCtx = (MonoBtlsSslCtx)GCHandle.FromIntPtr(instance).Target;
			int result;
			try
			{
				result = monoBtlsSslCtx.serverNameCallback();
			}
			catch (Exception exception)
			{
				monoBtlsSslCtx.SetException(exception);
				result = 0;
			}
			return result;
		}

		// Token: 0x060001DD RID: 477 RVA: 0x000079F0 File Offset: 0x00005BF0
		protected override void Close()
		{
			if (this.store != null)
			{
				this.store.Dispose();
				this.store = null;
			}
			if (this.instance.IsAllocated)
			{
				this.instance.Free();
			}
			base.Close();
		}

		// Token: 0x040000BE RID: 190
		private MonoBtlsSslCtx.NativeVerifyFunc verifyFunc;

		// Token: 0x040000BF RID: 191
		private MonoBtlsSslCtx.NativeSelectFunc selectFunc;

		// Token: 0x040000C0 RID: 192
		private MonoBtlsSslCtx.NativeServerNameFunc serverNameFunc;

		// Token: 0x040000C1 RID: 193
		private IntPtr verifyFuncPtr;

		// Token: 0x040000C2 RID: 194
		private IntPtr selectFuncPtr;

		// Token: 0x040000C3 RID: 195
		private IntPtr serverNameFuncPtr;

		// Token: 0x040000C4 RID: 196
		private MonoBtlsVerifyCallback verifyCallback;

		// Token: 0x040000C5 RID: 197
		private MonoBtlsSelectCallback selectCallback;

		// Token: 0x040000C6 RID: 198
		private MonoBtlsServerNameCallback serverNameCallback;

		// Token: 0x040000C7 RID: 199
		private MonoBtlsX509Store store;

		// Token: 0x040000C8 RID: 200
		private GCHandle instance;

		// Token: 0x040000C9 RID: 201
		private IntPtr instancePtr;

		// Token: 0x02000046 RID: 70
		internal class BoringSslCtxHandle : MonoBtlsObject.MonoBtlsHandle
		{
			// Token: 0x060001DE RID: 478 RVA: 0x000057D0 File Offset: 0x000039D0
			public BoringSslCtxHandle(IntPtr handle) : base(handle, true)
			{
			}

			// Token: 0x060001DF RID: 479 RVA: 0x00007A2A File Offset: 0x00005C2A
			protected override bool ReleaseHandle()
			{
				MonoBtlsSslCtx.mono_btls_ssl_ctx_free(this.handle);
				return true;
			}
		}

		// Token: 0x02000047 RID: 71
		// (Invoke) Token: 0x060001E1 RID: 481
		private delegate int NativeVerifyFunc(IntPtr instance, int preverify_ok, IntPtr ctx);

		// Token: 0x02000048 RID: 72
		// (Invoke) Token: 0x060001E5 RID: 485
		private delegate int NativeSelectFunc(IntPtr instance, int count, IntPtr sizes, IntPtr data);

		// Token: 0x02000049 RID: 73
		// (Invoke) Token: 0x060001E9 RID: 489
		private delegate int NativeServerNameFunc(IntPtr instance);
	}
}
