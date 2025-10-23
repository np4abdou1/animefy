using System;
using System.Runtime.InteropServices;
using System.Threading;

namespace Mono.Btls
{
	// Token: 0x0200004E RID: 78
	internal class MonoBtlsX509 : MonoBtlsObject
	{
		// Token: 0x17000056 RID: 86
		// (get) Token: 0x060001F2 RID: 498 RVA: 0x00007D1E File Offset: 0x00005F1E
		internal new MonoBtlsX509.BoringX509Handle Handle
		{
			get
			{
				return (MonoBtlsX509.BoringX509Handle)base.Handle;
			}
		}

		// Token: 0x060001F3 RID: 499 RVA: 0x000057BA File Offset: 0x000039BA
		internal MonoBtlsX509(MonoBtlsX509.BoringX509Handle handle) : base(handle)
		{
		}

		// Token: 0x060001F4 RID: 500
		[DllImport("libmono-btls-shared")]
		private static extern IntPtr mono_btls_x509_up_ref(IntPtr handle);

		// Token: 0x060001F5 RID: 501
		[DllImport("libmono-btls-shared")]
		private static extern IntPtr mono_btls_x509_from_data(IntPtr data, int len, MonoBtlsX509Format format);

		// Token: 0x060001F6 RID: 502
		[DllImport("libmono-btls-shared")]
		private static extern IntPtr mono_btls_x509_get_subject_name(IntPtr handle);

		// Token: 0x060001F7 RID: 503
		[DllImport("libmono-btls-shared")]
		private static extern int mono_btls_x509_get_raw_data(IntPtr handle, IntPtr bio, MonoBtlsX509Format format);

		// Token: 0x060001F8 RID: 504
		[DllImport("libmono-btls-shared")]
		private static extern int mono_btls_x509_cmp(IntPtr a, IntPtr b);

		// Token: 0x060001F9 RID: 505
		[DllImport("libmono-btls-shared")]
		private static extern void mono_btls_x509_free(IntPtr handle);

		// Token: 0x060001FA RID: 506
		[DllImport("libmono-btls-shared")]
		private static extern int mono_btls_x509_add_explicit_trust(IntPtr handle, MonoBtlsX509TrustKind kind);

		// Token: 0x060001FB RID: 507 RVA: 0x00007D2C File Offset: 0x00005F2C
		internal MonoBtlsX509 Copy()
		{
			IntPtr intPtr = MonoBtlsX509.mono_btls_x509_up_ref(this.Handle.DangerousGetHandle());
			base.CheckError(intPtr != IntPtr.Zero, "Copy");
			return new MonoBtlsX509(new MonoBtlsX509.BoringX509Handle(intPtr));
		}

		// Token: 0x060001FC RID: 508 RVA: 0x00007D6C File Offset: 0x00005F6C
		public static MonoBtlsX509 LoadFromData(byte[] buffer, MonoBtlsX509Format format)
		{
			IntPtr intPtr = Marshal.AllocHGlobal(buffer.Length);
			if (intPtr == IntPtr.Zero)
			{
				throw new OutOfMemoryException();
			}
			MonoBtlsX509 result;
			try
			{
				Marshal.Copy(buffer, 0, intPtr, buffer.Length);
				IntPtr intPtr2 = MonoBtlsX509.mono_btls_x509_from_data(intPtr, buffer.Length, format);
				if (intPtr2 == IntPtr.Zero)
				{
					throw new MonoBtlsException("Failed to read certificate from data.");
				}
				result = new MonoBtlsX509(new MonoBtlsX509.BoringX509Handle(intPtr2));
			}
			finally
			{
				Marshal.FreeHGlobal(intPtr);
			}
			return result;
		}

		// Token: 0x060001FD RID: 509 RVA: 0x00007DE8 File Offset: 0x00005FE8
		public MonoBtlsX509Name GetSubjectName()
		{
			IntPtr intPtr = MonoBtlsX509.mono_btls_x509_get_subject_name(this.Handle.DangerousGetHandle());
			base.CheckError(intPtr != IntPtr.Zero, "GetSubjectName");
			return new MonoBtlsX509Name(new MonoBtlsX509Name.BoringX509NameHandle(intPtr, false));
		}

		// Token: 0x060001FE RID: 510 RVA: 0x00007E28 File Offset: 0x00006028
		public long GetSubjectNameHash()
		{
			base.CheckThrow();
			long hash;
			using (MonoBtlsX509Name subjectName = this.GetSubjectName())
			{
				hash = subjectName.GetHash();
			}
			return hash;
		}

		// Token: 0x060001FF RID: 511 RVA: 0x00007E68 File Offset: 0x00006068
		public byte[] GetRawData(MonoBtlsX509Format format)
		{
			byte[] data;
			using (MonoBtlsBioMemory monoBtlsBioMemory = new MonoBtlsBioMemory())
			{
				int ret = MonoBtlsX509.mono_btls_x509_get_raw_data(this.Handle.DangerousGetHandle(), monoBtlsBioMemory.Handle.DangerousGetHandle(), format);
				base.CheckError(ret, "GetRawData");
				data = monoBtlsBioMemory.GetData();
			}
			return data;
		}

		// Token: 0x06000200 RID: 512 RVA: 0x00007EC8 File Offset: 0x000060C8
		public static int Compare(MonoBtlsX509 a, MonoBtlsX509 b)
		{
			return MonoBtlsX509.mono_btls_x509_cmp(a.Handle.DangerousGetHandle(), b.Handle.DangerousGetHandle());
		}

		// Token: 0x06000201 RID: 513 RVA: 0x00007EE8 File Offset: 0x000060E8
		public void AddExplicitTrust(MonoBtlsX509TrustKind kind)
		{
			base.CheckThrow();
			int ret = MonoBtlsX509.mono_btls_x509_add_explicit_trust(this.Handle.DangerousGetHandle(), kind);
			base.CheckError(ret, "AddExplicitTrust");
		}

		// Token: 0x0200004F RID: 79
		internal class BoringX509Handle : MonoBtlsObject.MonoBtlsHandle
		{
			// Token: 0x06000202 RID: 514 RVA: 0x000057D0 File Offset: 0x000039D0
			public BoringX509Handle(IntPtr handle) : base(handle, true)
			{
			}

			// Token: 0x06000203 RID: 515 RVA: 0x00007F19 File Offset: 0x00006119
			protected override bool ReleaseHandle()
			{
				if (this.handle != IntPtr.Zero)
				{
					MonoBtlsX509.mono_btls_x509_free(this.handle);
				}
				return true;
			}

			// Token: 0x06000204 RID: 516 RVA: 0x00007F39 File Offset: 0x00006139
			public IntPtr StealHandle()
			{
				return Interlocked.Exchange(ref this.handle, IntPtr.Zero);
			}
		}
	}
}
