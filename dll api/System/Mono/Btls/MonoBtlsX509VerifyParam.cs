using System;
using System.Runtime.InteropServices;

namespace Mono.Btls
{
	// Token: 0x02000064 RID: 100
	internal class MonoBtlsX509VerifyParam : MonoBtlsObject
	{
		// Token: 0x1700005F RID: 95
		// (get) Token: 0x06000274 RID: 628 RVA: 0x00008AB8 File Offset: 0x00006CB8
		internal new MonoBtlsX509VerifyParam.BoringX509VerifyParamHandle Handle
		{
			get
			{
				return (MonoBtlsX509VerifyParam.BoringX509VerifyParamHandle)base.Handle;
			}
		}

		// Token: 0x06000275 RID: 629
		[DllImport("libmono-btls-shared")]
		private static extern IntPtr mono_btls_x509_verify_param_copy(IntPtr handle);

		// Token: 0x06000276 RID: 630
		[DllImport("libmono-btls-shared")]
		private static extern IntPtr mono_btls_x509_verify_param_lookup(IntPtr name);

		// Token: 0x06000277 RID: 631
		[DllImport("libmono-btls-shared")]
		private static extern int mono_btls_x509_verify_param_can_modify(IntPtr param);

		// Token: 0x06000278 RID: 632
		[DllImport("libmono-btls-shared")]
		private static extern int mono_btls_x509_verify_param_set_host(IntPtr handle, IntPtr name, int namelen);

		// Token: 0x06000279 RID: 633
		[DllImport("libmono-btls-shared")]
		private static extern int mono_btls_x509_verify_param_set_time(IntPtr handle, long time);

		// Token: 0x0600027A RID: 634
		[DllImport("libmono-btls-shared")]
		private static extern void mono_btls_x509_verify_param_free(IntPtr handle);

		// Token: 0x0600027B RID: 635 RVA: 0x000057BA File Offset: 0x000039BA
		internal MonoBtlsX509VerifyParam(MonoBtlsX509VerifyParam.BoringX509VerifyParamHandle handle) : base(handle)
		{
		}

		// Token: 0x0600027C RID: 636 RVA: 0x00008AC8 File Offset: 0x00006CC8
		public MonoBtlsX509VerifyParam Copy()
		{
			IntPtr intPtr = MonoBtlsX509VerifyParam.mono_btls_x509_verify_param_copy(this.Handle.DangerousGetHandle());
			base.CheckError(intPtr != IntPtr.Zero, "Copy");
			return new MonoBtlsX509VerifyParam(new MonoBtlsX509VerifyParam.BoringX509VerifyParamHandle(intPtr));
		}

		// Token: 0x0600027D RID: 637 RVA: 0x00008B07 File Offset: 0x00006D07
		public static MonoBtlsX509VerifyParam GetSslClient()
		{
			return MonoBtlsX509VerifyParam.Lookup("ssl_client", true);
		}

		// Token: 0x0600027E RID: 638 RVA: 0x00008B14 File Offset: 0x00006D14
		public static MonoBtlsX509VerifyParam GetSslServer()
		{
			return MonoBtlsX509VerifyParam.Lookup("ssl_server", true);
		}

		// Token: 0x0600027F RID: 639 RVA: 0x00008B24 File Offset: 0x00006D24
		public static MonoBtlsX509VerifyParam Lookup(string name, bool fail = false)
		{
			IntPtr intPtr = IntPtr.Zero;
			IntPtr intPtr2 = IntPtr.Zero;
			MonoBtlsX509VerifyParam result;
			try
			{
				intPtr = Marshal.StringToHGlobalAnsi(name);
				intPtr2 = MonoBtlsX509VerifyParam.mono_btls_x509_verify_param_lookup(intPtr);
				if (intPtr2 == IntPtr.Zero)
				{
					if (fail)
					{
						throw new MonoBtlsException("X509_VERIFY_PARAM_lookup() could not find '{0}'.", new object[]
						{
							name
						});
					}
					result = null;
				}
				else
				{
					result = new MonoBtlsX509VerifyParam(new MonoBtlsX509VerifyParam.BoringX509VerifyParamHandle(intPtr2));
				}
			}
			finally
			{
				if (intPtr != IntPtr.Zero)
				{
					Marshal.FreeHGlobal(intPtr);
				}
			}
			return result;
		}

		// Token: 0x17000060 RID: 96
		// (get) Token: 0x06000280 RID: 640 RVA: 0x00008BA8 File Offset: 0x00006DA8
		public bool CanModify
		{
			get
			{
				return MonoBtlsX509VerifyParam.mono_btls_x509_verify_param_can_modify(this.Handle.DangerousGetHandle()) != 0;
			}
		}

		// Token: 0x06000281 RID: 641 RVA: 0x00008BBD File Offset: 0x00006DBD
		private void WantToModify()
		{
			if (!this.CanModify)
			{
				throw new MonoBtlsException("Attempting to modify read-only MonoBtlsX509VerifyParam instance.");
			}
		}

		// Token: 0x06000282 RID: 642 RVA: 0x00008BD4 File Offset: 0x00006DD4
		public void SetHost(string name)
		{
			this.WantToModify();
			IntPtr intPtr = IntPtr.Zero;
			try
			{
				intPtr = Marshal.StringToHGlobalAnsi(name);
				int ret = MonoBtlsX509VerifyParam.mono_btls_x509_verify_param_set_host(this.Handle.DangerousGetHandle(), intPtr, name.Length);
				base.CheckError(ret, "SetHost");
			}
			finally
			{
				if (intPtr != IntPtr.Zero)
				{
					Marshal.FreeHGlobal(intPtr);
				}
			}
		}

		// Token: 0x06000283 RID: 643 RVA: 0x00008C40 File Offset: 0x00006E40
		public void SetTime(DateTime time)
		{
			this.WantToModify();
			DateTime value = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
			long time2 = (long)time.Subtract(value).TotalSeconds;
			int ret = MonoBtlsX509VerifyParam.mono_btls_x509_verify_param_set_time(this.Handle.DangerousGetHandle(), time2);
			base.CheckError(ret, "SetTime");
		}

		// Token: 0x02000065 RID: 101
		internal class BoringX509VerifyParamHandle : MonoBtlsObject.MonoBtlsHandle
		{
			// Token: 0x06000284 RID: 644 RVA: 0x000057D0 File Offset: 0x000039D0
			public BoringX509VerifyParamHandle(IntPtr handle) : base(handle, true)
			{
			}

			// Token: 0x06000285 RID: 645 RVA: 0x00008C95 File Offset: 0x00006E95
			protected override bool ReleaseHandle()
			{
				MonoBtlsX509VerifyParam.mono_btls_x509_verify_param_free(this.handle);
				return true;
			}
		}
	}
}
