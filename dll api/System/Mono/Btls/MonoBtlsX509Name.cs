using System;
using System.Runtime.InteropServices;
using System.Text;

namespace Mono.Btls
{
	// Token: 0x0200005C RID: 92
	internal class MonoBtlsX509Name : MonoBtlsObject
	{
		// Token: 0x06000235 RID: 565
		[DllImport("libmono-btls-shared")]
		private static extern long mono_btls_x509_name_hash(IntPtr handle);

		// Token: 0x06000236 RID: 566
		[DllImport("libmono-btls-shared")]
		private static extern long mono_btls_x509_name_hash_old(IntPtr handle);

		// Token: 0x06000237 RID: 567
		[DllImport("libmono-btls-shared")]
		private static extern int mono_btls_x509_name_get_entry_count(IntPtr handle);

		// Token: 0x06000238 RID: 568
		[DllImport("libmono-btls-shared")]
		private static extern MonoBtlsX509NameEntryType mono_btls_x509_name_get_entry_type(IntPtr name, int index);

		// Token: 0x06000239 RID: 569
		[DllImport("libmono-btls-shared")]
		private static extern int mono_btls_x509_name_get_entry_oid(IntPtr name, int index, IntPtr buffer, int size);

		// Token: 0x0600023A RID: 570
		[DllImport("libmono-btls-shared")]
		private static extern int mono_btls_x509_name_get_entry_oid_data(IntPtr name, int index, out IntPtr data);

		// Token: 0x0600023B RID: 571
		[DllImport("libmono-btls-shared")]
		private static extern int mono_btls_x509_name_get_entry_value(IntPtr name, int index, out int tag, out IntPtr str);

		// Token: 0x0600023C RID: 572
		[DllImport("libmono-btls-shared")]
		private unsafe static extern IntPtr mono_btls_x509_name_from_data(void* data, int len, int use_canon_enc);

		// Token: 0x0600023D RID: 573
		[DllImport("libmono-btls-shared")]
		private static extern void mono_btls_x509_name_free(IntPtr handle);

		// Token: 0x1700005B RID: 91
		// (get) Token: 0x0600023E RID: 574 RVA: 0x000084C8 File Offset: 0x000066C8
		internal new MonoBtlsX509Name.BoringX509NameHandle Handle
		{
			get
			{
				return (MonoBtlsX509Name.BoringX509NameHandle)base.Handle;
			}
		}

		// Token: 0x0600023F RID: 575 RVA: 0x000057BA File Offset: 0x000039BA
		internal MonoBtlsX509Name(MonoBtlsX509Name.BoringX509NameHandle handle) : base(handle)
		{
		}

		// Token: 0x06000240 RID: 576 RVA: 0x000084D5 File Offset: 0x000066D5
		public long GetHash()
		{
			return MonoBtlsX509Name.mono_btls_x509_name_hash(this.Handle.DangerousGetHandle());
		}

		// Token: 0x06000241 RID: 577 RVA: 0x000084E7 File Offset: 0x000066E7
		public long GetHashOld()
		{
			return MonoBtlsX509Name.mono_btls_x509_name_hash_old(this.Handle.DangerousGetHandle());
		}

		// Token: 0x06000242 RID: 578 RVA: 0x000084F9 File Offset: 0x000066F9
		public int GetEntryCount()
		{
			return MonoBtlsX509Name.mono_btls_x509_name_get_entry_count(this.Handle.DangerousGetHandle());
		}

		// Token: 0x06000243 RID: 579 RVA: 0x0000850B File Offset: 0x0000670B
		public MonoBtlsX509NameEntryType GetEntryType(int index)
		{
			if (index >= this.GetEntryCount())
			{
				throw new ArgumentOutOfRangeException();
			}
			return MonoBtlsX509Name.mono_btls_x509_name_get_entry_type(this.Handle.DangerousGetHandle(), index);
		}

		// Token: 0x06000244 RID: 580 RVA: 0x00008530 File Offset: 0x00006730
		public string GetEntryOid(int index)
		{
			if (index >= this.GetEntryCount())
			{
				throw new ArgumentOutOfRangeException();
			}
			IntPtr intPtr = Marshal.AllocHGlobal(4096);
			string result;
			try
			{
				int num = MonoBtlsX509Name.mono_btls_x509_name_get_entry_oid(this.Handle.DangerousGetHandle(), index, intPtr, 4096);
				base.CheckError(num > 0, "GetEntryOid");
				result = Marshal.PtrToStringAnsi(intPtr);
			}
			finally
			{
				Marshal.FreeHGlobal(intPtr);
			}
			return result;
		}

		// Token: 0x06000245 RID: 581 RVA: 0x000085A0 File Offset: 0x000067A0
		public byte[] GetEntryOidData(int index)
		{
			IntPtr source;
			int num = MonoBtlsX509Name.mono_btls_x509_name_get_entry_oid_data(this.Handle.DangerousGetHandle(), index, out source);
			base.CheckError(num > 0, "GetEntryOidData");
			byte[] array = new byte[num];
			Marshal.Copy(source, array, 0, num);
			return array;
		}

		// Token: 0x06000246 RID: 582 RVA: 0x000085E4 File Offset: 0x000067E4
		public unsafe string GetEntryValue(int index, out int tag)
		{
			if (index >= this.GetEntryCount())
			{
				throw new ArgumentOutOfRangeException();
			}
			IntPtr intPtr;
			int num = MonoBtlsX509Name.mono_btls_x509_name_get_entry_value(this.Handle.DangerousGetHandle(), index, out tag, out intPtr);
			if (num <= 0)
			{
				return null;
			}
			string @string;
			try
			{
				@string = new UTF8Encoding().GetString((byte*)((void*)intPtr), num);
			}
			finally
			{
				if (intPtr != IntPtr.Zero)
				{
					base.FreeDataPtr(intPtr);
				}
			}
			return @string;
		}

		// Token: 0x06000247 RID: 583 RVA: 0x00008658 File Offset: 0x00006858
		public unsafe static MonoBtlsX509Name CreateFromData(byte[] data, bool use_canon_enc)
		{
			void* data2;
			if (data == null || data.Length == 0)
			{
				data2 = null;
			}
			else
			{
				data2 = (void*)(&data[0]);
			}
			IntPtr intPtr = MonoBtlsX509Name.mono_btls_x509_name_from_data(data2, data.Length, use_canon_enc ? 1 : 0);
			if (intPtr == IntPtr.Zero)
			{
				throw new MonoBtlsException("mono_btls_x509_name_from_data() failed.");
			}
			return new MonoBtlsX509Name(new MonoBtlsX509Name.BoringX509NameHandle(intPtr, false));
		}

		// Token: 0x0200005D RID: 93
		internal class BoringX509NameHandle : MonoBtlsObject.MonoBtlsHandle
		{
			// Token: 0x06000248 RID: 584 RVA: 0x000086B0 File Offset: 0x000068B0
			internal BoringX509NameHandle(IntPtr handle, bool ownsHandle) : base(handle, ownsHandle)
			{
				this.dontFree = !ownsHandle;
			}

			// Token: 0x06000249 RID: 585 RVA: 0x000086C4 File Offset: 0x000068C4
			protected override bool ReleaseHandle()
			{
				if (!this.dontFree)
				{
					MonoBtlsX509Name.mono_btls_x509_name_free(this.handle);
				}
				return true;
			}

			// Token: 0x04000132 RID: 306
			private bool dontFree;
		}
	}
}
