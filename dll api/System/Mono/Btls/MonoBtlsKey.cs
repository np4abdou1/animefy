using System;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using Mono.Security.Cryptography;

namespace Mono.Btls
{
	// Token: 0x02000038 RID: 56
	internal class MonoBtlsKey : MonoBtlsObject
	{
		// Token: 0x06000143 RID: 323
		[DllImport("libmono-btls-shared")]
		private static extern IntPtr mono_btls_key_new();

		// Token: 0x06000144 RID: 324
		[DllImport("libmono-btls-shared")]
		private static extern void mono_btls_key_free(IntPtr handle);

		// Token: 0x06000145 RID: 325
		[DllImport("libmono-btls-shared")]
		private static extern IntPtr mono_btls_key_up_ref(IntPtr handle);

		// Token: 0x06000146 RID: 326
		[DllImport("libmono-btls-shared")]
		private static extern int mono_btls_key_get_bytes(IntPtr handle, out IntPtr data, out int size, int include_private_bits);

		// Token: 0x06000147 RID: 327
		[DllImport("libmono-btls-shared")]
		private static extern int mono_btls_key_assign_rsa_private_key(IntPtr handle, byte[] der, int der_length);

		// Token: 0x1700004B RID: 75
		// (get) Token: 0x06000148 RID: 328 RVA: 0x000064BB File Offset: 0x000046BB
		internal new MonoBtlsKey.BoringKeyHandle Handle
		{
			get
			{
				return (MonoBtlsKey.BoringKeyHandle)base.Handle;
			}
		}

		// Token: 0x06000149 RID: 329 RVA: 0x000057BA File Offset: 0x000039BA
		internal MonoBtlsKey(MonoBtlsKey.BoringKeyHandle handle) : base(handle)
		{
		}

		// Token: 0x0600014A RID: 330 RVA: 0x000064C8 File Offset: 0x000046C8
		public byte[] GetBytes(bool include_private_bits)
		{
			IntPtr intPtr;
			int num;
			int ret = MonoBtlsKey.mono_btls_key_get_bytes(this.Handle.DangerousGetHandle(), out intPtr, out num, include_private_bits ? 1 : 0);
			base.CheckError(ret, "GetBytes");
			byte[] array = new byte[num];
			Marshal.Copy(intPtr, array, 0, num);
			base.FreeDataPtr(intPtr);
			return array;
		}

		// Token: 0x0600014B RID: 331 RVA: 0x00006518 File Offset: 0x00004718
		public MonoBtlsKey Copy()
		{
			base.CheckThrow();
			IntPtr intPtr = MonoBtlsKey.mono_btls_key_up_ref(this.Handle.DangerousGetHandle());
			base.CheckError(intPtr != IntPtr.Zero, "Copy");
			return new MonoBtlsKey(new MonoBtlsKey.BoringKeyHandle(intPtr));
		}

		// Token: 0x0600014C RID: 332 RVA: 0x00006560 File Offset: 0x00004760
		public static MonoBtlsKey CreateFromRSAPrivateKey(RSA privateKey)
		{
			byte[] array = PKCS8.PrivateKeyInfo.Encode(privateKey);
			MonoBtlsKey monoBtlsKey = new MonoBtlsKey(new MonoBtlsKey.BoringKeyHandle(MonoBtlsKey.mono_btls_key_new()));
			if (MonoBtlsKey.mono_btls_key_assign_rsa_private_key(monoBtlsKey.Handle.DangerousGetHandle(), array, array.Length) == 0)
			{
				throw new MonoBtlsException("Assigning private key failed.");
			}
			return monoBtlsKey;
		}

		// Token: 0x02000039 RID: 57
		internal class BoringKeyHandle : MonoBtlsObject.MonoBtlsHandle
		{
			// Token: 0x0600014D RID: 333 RVA: 0x000057D0 File Offset: 0x000039D0
			internal BoringKeyHandle(IntPtr handle) : base(handle, true)
			{
			}

			// Token: 0x0600014E RID: 334 RVA: 0x000065A4 File Offset: 0x000047A4
			protected override bool ReleaseHandle()
			{
				MonoBtlsKey.mono_btls_key_free(this.handle);
				return true;
			}
		}
	}
}
