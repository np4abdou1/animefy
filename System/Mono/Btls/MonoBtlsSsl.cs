using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;

namespace Mono.Btls
{
	// Token: 0x02000042 RID: 66
	internal class MonoBtlsSsl : MonoBtlsObject
	{
		// Token: 0x0600018D RID: 397
		[DllImport("libmono-btls-shared")]
		private static extern void mono_btls_ssl_destroy(IntPtr handle);

		// Token: 0x0600018E RID: 398
		[DllImport("libmono-btls-shared")]
		private static extern IntPtr mono_btls_ssl_new(IntPtr handle);

		// Token: 0x0600018F RID: 399
		[DllImport("libmono-btls-shared")]
		private static extern int mono_btls_ssl_use_certificate(IntPtr handle, IntPtr x509);

		// Token: 0x06000190 RID: 400
		[DllImport("libmono-btls-shared")]
		private static extern int mono_btls_ssl_use_private_key(IntPtr handle, IntPtr key);

		// Token: 0x06000191 RID: 401
		[DllImport("libmono-btls-shared")]
		private static extern int mono_btls_ssl_add_chain_certificate(IntPtr handle, IntPtr x509);

		// Token: 0x06000192 RID: 402
		[DllImport("libmono-btls-shared")]
		private static extern int mono_btls_ssl_accept(IntPtr handle);

		// Token: 0x06000193 RID: 403
		[DllImport("libmono-btls-shared")]
		private static extern int mono_btls_ssl_connect(IntPtr handle);

		// Token: 0x06000194 RID: 404
		[DllImport("libmono-btls-shared")]
		private static extern int mono_btls_ssl_handshake(IntPtr handle);

		// Token: 0x06000195 RID: 405
		[DllImport("libmono-btls-shared")]
		private static extern void mono_btls_ssl_close(IntPtr handle);

		// Token: 0x06000196 RID: 406
		[DllImport("libmono-btls-shared")]
		private static extern void mono_btls_ssl_set_bio(IntPtr handle, IntPtr bio);

		// Token: 0x06000197 RID: 407
		[DllImport("libmono-btls-shared")]
		private static extern int mono_btls_ssl_read(IntPtr handle, IntPtr data, int len);

		// Token: 0x06000198 RID: 408
		[DllImport("libmono-btls-shared")]
		private static extern int mono_btls_ssl_write(IntPtr handle, IntPtr data, int len);

		// Token: 0x06000199 RID: 409
		[DllImport("libmono-btls-shared")]
		private static extern int mono_btls_ssl_get_error(IntPtr handle, int ret_code);

		// Token: 0x0600019A RID: 410
		[DllImport("libmono-btls-shared")]
		private static extern int mono_btls_ssl_get_version(IntPtr handle);

		// Token: 0x0600019B RID: 411
		[DllImport("libmono-btls-shared")]
		private static extern int mono_btls_ssl_get_cipher(IntPtr handle);

		// Token: 0x0600019C RID: 412
		[DllImport("libmono-btls-shared")]
		private static extern IntPtr mono_btls_ssl_get_peer_certificate(IntPtr handle);

		// Token: 0x0600019D RID: 413
		[DllImport("libmono-btls-shared")]
		private static extern void mono_btls_ssl_print_errors_cb(IntPtr func, IntPtr ctx);

		// Token: 0x0600019E RID: 414
		[DllImport("libmono-btls-shared")]
		private static extern int mono_btls_ssl_set_server_name(IntPtr handle, IntPtr name);

		// Token: 0x0600019F RID: 415
		[DllImport("libmono-btls-shared")]
		private static extern IntPtr mono_btls_ssl_get_server_name(IntPtr handle);

		// Token: 0x060001A0 RID: 416
		[DllImport("libmono-btls-shared")]
		private static extern void mono_btls_ssl_set_renegotiate_mode(IntPtr handle, int mode);

		// Token: 0x060001A1 RID: 417
		[DllImport("libmono-btls-shared")]
		private static extern int mono_btls_ssl_renegotiate_pending(IntPtr handle);

		// Token: 0x060001A2 RID: 418 RVA: 0x00006F5C File Offset: 0x0000515C
		private static MonoBtlsSsl.BoringSslHandle Create_internal(MonoBtlsSslCtx ctx)
		{
			IntPtr intPtr = MonoBtlsSsl.mono_btls_ssl_new(ctx.Handle.DangerousGetHandle());
			if (intPtr == IntPtr.Zero)
			{
				throw new MonoBtlsException();
			}
			return new MonoBtlsSsl.BoringSslHandle(intPtr);
		}

		// Token: 0x060001A3 RID: 419 RVA: 0x00006F86 File Offset: 0x00005186
		public MonoBtlsSsl(MonoBtlsSslCtx ctx) : base(MonoBtlsSsl.Create_internal(ctx))
		{
			this.printErrorsFunc = new MonoBtlsSsl.PrintErrorsCallbackFunc(MonoBtlsSsl.PrintErrorsCallback);
			this.printErrorsFuncPtr = Marshal.GetFunctionPointerForDelegate<MonoBtlsSsl.PrintErrorsCallbackFunc>(this.printErrorsFunc);
		}

		// Token: 0x17000053 RID: 83
		// (get) Token: 0x060001A4 RID: 420 RVA: 0x00006FB7 File Offset: 0x000051B7
		internal new MonoBtlsSsl.BoringSslHandle Handle
		{
			get
			{
				return (MonoBtlsSsl.BoringSslHandle)base.Handle;
			}
		}

		// Token: 0x060001A5 RID: 421 RVA: 0x00006FC4 File Offset: 0x000051C4
		public void SetBio(MonoBtlsBio bio)
		{
			base.CheckThrow();
			this.bio = bio;
			MonoBtlsSsl.mono_btls_ssl_set_bio(this.Handle.DangerousGetHandle(), bio.Handle.DangerousGetHandle());
		}

		// Token: 0x060001A6 RID: 422 RVA: 0x00006FF0 File Offset: 0x000051F0
		private Exception ThrowError([CallerMemberName] string callerName = null)
		{
			string text;
			try
			{
				if (callerName == null)
				{
					callerName = base.GetType().Name;
				}
				text = this.GetErrors();
			}
			catch
			{
				text = null;
			}
			if (text != null)
			{
				throw new MonoBtlsException("{0} failed: {1}.", new object[]
				{
					callerName,
					text
				});
			}
			throw new MonoBtlsException("{0} failed.", new object[]
			{
				callerName
			});
		}

		// Token: 0x060001A7 RID: 423 RVA: 0x0000705C File Offset: 0x0000525C
		private MonoBtlsSslError GetError(int ret_code)
		{
			base.CheckThrow();
			this.bio.CheckLastError("GetError");
			return (MonoBtlsSslError)MonoBtlsSsl.mono_btls_ssl_get_error(this.Handle.DangerousGetHandle(), ret_code);
		}

		// Token: 0x060001A8 RID: 424 RVA: 0x00007085 File Offset: 0x00005285
		public void SetCertificate(MonoBtlsX509 x509)
		{
			base.CheckThrow();
			if (MonoBtlsSsl.mono_btls_ssl_use_certificate(this.Handle.DangerousGetHandle(), x509.Handle.DangerousGetHandle()) <= 0)
			{
				throw this.ThrowError("SetCertificate");
			}
		}

		// Token: 0x060001A9 RID: 425 RVA: 0x000070B7 File Offset: 0x000052B7
		public void SetPrivateKey(MonoBtlsKey key)
		{
			base.CheckThrow();
			if (MonoBtlsSsl.mono_btls_ssl_use_private_key(this.Handle.DangerousGetHandle(), key.Handle.DangerousGetHandle()) <= 0)
			{
				throw this.ThrowError("SetPrivateKey");
			}
		}

		// Token: 0x060001AA RID: 426 RVA: 0x000070E9 File Offset: 0x000052E9
		public void AddIntermediateCertificate(MonoBtlsX509 x509)
		{
			base.CheckThrow();
			if (MonoBtlsSsl.mono_btls_ssl_add_chain_certificate(this.Handle.DangerousGetHandle(), x509.Handle.DangerousGetHandle()) <= 0)
			{
				throw this.ThrowError("AddIntermediateCertificate");
			}
		}

		// Token: 0x060001AB RID: 427 RVA: 0x0000711C File Offset: 0x0000531C
		public MonoBtlsSslError Accept()
		{
			base.CheckThrow();
			int ret_code = MonoBtlsSsl.mono_btls_ssl_accept(this.Handle.DangerousGetHandle());
			return this.GetError(ret_code);
		}

		// Token: 0x060001AC RID: 428 RVA: 0x00007148 File Offset: 0x00005348
		public MonoBtlsSslError Connect()
		{
			base.CheckThrow();
			int ret_code = MonoBtlsSsl.mono_btls_ssl_connect(this.Handle.DangerousGetHandle());
			return this.GetError(ret_code);
		}

		// Token: 0x060001AD RID: 429 RVA: 0x00007174 File Offset: 0x00005374
		public MonoBtlsSslError Handshake()
		{
			base.CheckThrow();
			int ret_code = MonoBtlsSsl.mono_btls_ssl_handshake(this.Handle.DangerousGetHandle());
			return this.GetError(ret_code);
		}

		// Token: 0x060001AE RID: 430 RVA: 0x000071A0 File Offset: 0x000053A0
		private static int PrintErrorsCallback(IntPtr str, IntPtr len, IntPtr ctx)
		{
			StringBuilder stringBuilder = (StringBuilder)GCHandle.FromIntPtr(ctx).Target;
			int result;
			try
			{
				string value = Marshal.PtrToStringAnsi(str, (int)len);
				stringBuilder.Append(value);
				result = 1;
			}
			catch
			{
				result = 0;
			}
			return result;
		}

		// Token: 0x060001AF RID: 431 RVA: 0x000071F0 File Offset: 0x000053F0
		public string GetErrors()
		{
			StringBuilder stringBuilder = new StringBuilder();
			GCHandle value = GCHandle.Alloc(stringBuilder);
			string result;
			try
			{
				MonoBtlsSsl.mono_btls_ssl_print_errors_cb(this.printErrorsFuncPtr, GCHandle.ToIntPtr(value));
				result = stringBuilder.ToString();
			}
			finally
			{
				if (value.IsAllocated)
				{
					value.Free();
				}
			}
			return result;
		}

		// Token: 0x060001B0 RID: 432 RVA: 0x00007248 File Offset: 0x00005448
		public void PrintErrors()
		{
			string errors = this.GetErrors();
			if (string.IsNullOrEmpty(errors))
			{
				return;
			}
			Console.Error.WriteLine(errors);
		}

		// Token: 0x060001B1 RID: 433 RVA: 0x00007270 File Offset: 0x00005470
		public MonoBtlsSslError Read(IntPtr data, ref int dataSize)
		{
			base.CheckThrow();
			int num = MonoBtlsSsl.mono_btls_ssl_read(this.Handle.DangerousGetHandle(), data, dataSize);
			if (num > 0)
			{
				dataSize = num;
				return MonoBtlsSslError.None;
			}
			MonoBtlsSslError error = this.GetError(num);
			if (num == 0 && error == MonoBtlsSslError.Syscall)
			{
				dataSize = 0;
				return MonoBtlsSslError.None;
			}
			dataSize = 0;
			return error;
		}

		// Token: 0x060001B2 RID: 434 RVA: 0x000072B8 File Offset: 0x000054B8
		public MonoBtlsSslError Write(IntPtr data, ref int dataSize)
		{
			base.CheckThrow();
			int num = MonoBtlsSsl.mono_btls_ssl_write(this.Handle.DangerousGetHandle(), data, dataSize);
			if (num >= 0)
			{
				dataSize = num;
				return MonoBtlsSslError.None;
			}
			MonoBtlsSslError result = (MonoBtlsSslError)MonoBtlsSsl.mono_btls_ssl_get_error(this.Handle.DangerousGetHandle(), num);
			dataSize = 0;
			return result;
		}

		// Token: 0x060001B3 RID: 435 RVA: 0x000072FC File Offset: 0x000054FC
		public int GetVersion()
		{
			base.CheckThrow();
			return MonoBtlsSsl.mono_btls_ssl_get_version(this.Handle.DangerousGetHandle());
		}

		// Token: 0x060001B4 RID: 436 RVA: 0x00007314 File Offset: 0x00005514
		public int GetCipher()
		{
			base.CheckThrow();
			int num = MonoBtlsSsl.mono_btls_ssl_get_cipher(this.Handle.DangerousGetHandle());
			base.CheckError(num > 0, "GetCipher");
			return num;
		}

		// Token: 0x060001B5 RID: 437 RVA: 0x00007348 File Offset: 0x00005548
		public MonoBtlsX509 GetPeerCertificate()
		{
			base.CheckThrow();
			IntPtr intPtr = MonoBtlsSsl.mono_btls_ssl_get_peer_certificate(this.Handle.DangerousGetHandle());
			if (intPtr == IntPtr.Zero)
			{
				return null;
			}
			return new MonoBtlsX509(new MonoBtlsX509.BoringX509Handle(intPtr));
		}

		// Token: 0x060001B6 RID: 438 RVA: 0x00007388 File Offset: 0x00005588
		public void SetServerName(string name)
		{
			base.CheckThrow();
			IntPtr intPtr = IntPtr.Zero;
			try
			{
				intPtr = Marshal.StringToHGlobalAnsi(name);
				int ret = MonoBtlsSsl.mono_btls_ssl_set_server_name(this.Handle.DangerousGetHandle(), intPtr);
				base.CheckError(ret, "SetServerName");
			}
			finally
			{
				if (intPtr != IntPtr.Zero)
				{
					Marshal.FreeHGlobal(intPtr);
				}
			}
		}

		// Token: 0x060001B7 RID: 439 RVA: 0x000073EC File Offset: 0x000055EC
		public string GetServerName()
		{
			base.CheckThrow();
			IntPtr intPtr = MonoBtlsSsl.mono_btls_ssl_get_server_name(this.Handle.DangerousGetHandle());
			if (intPtr == IntPtr.Zero)
			{
				return null;
			}
			return Marshal.PtrToStringAnsi(intPtr);
		}

		// Token: 0x060001B8 RID: 440 RVA: 0x00007425 File Offset: 0x00005625
		protected override void Close()
		{
			if (!this.Handle.IsInvalid)
			{
				MonoBtlsSsl.mono_btls_ssl_close(this.Handle.DangerousGetHandle());
			}
		}

		// Token: 0x060001B9 RID: 441 RVA: 0x00007444 File Offset: 0x00005644
		public void SetRenegotiateMode(MonoBtlsSslRenegotiateMode mode)
		{
			base.CheckThrow();
			MonoBtlsSsl.mono_btls_ssl_set_renegotiate_mode(this.Handle.DangerousGetHandle(), (int)mode);
		}

		// Token: 0x060001BA RID: 442 RVA: 0x0000745D File Offset: 0x0000565D
		public bool RenegotiatePending()
		{
			return MonoBtlsSsl.mono_btls_ssl_renegotiate_pending(this.Handle.DangerousGetHandle()) != 0;
		}

		// Token: 0x040000BB RID: 187
		private MonoBtlsBio bio;

		// Token: 0x040000BC RID: 188
		private MonoBtlsSsl.PrintErrorsCallbackFunc printErrorsFunc;

		// Token: 0x040000BD RID: 189
		private IntPtr printErrorsFuncPtr;

		// Token: 0x02000043 RID: 67
		internal class BoringSslHandle : MonoBtlsObject.MonoBtlsHandle
		{
			// Token: 0x060001BB RID: 443 RVA: 0x000057D0 File Offset: 0x000039D0
			public BoringSslHandle(IntPtr handle) : base(handle, true)
			{
			}

			// Token: 0x060001BC RID: 444 RVA: 0x00007472 File Offset: 0x00005672
			protected override bool ReleaseHandle()
			{
				MonoBtlsSsl.mono_btls_ssl_destroy(this.handle);
				this.handle = IntPtr.Zero;
				return true;
			}
		}

		// Token: 0x02000044 RID: 68
		// (Invoke) Token: 0x060001BE RID: 446
		private delegate int PrintErrorsCallbackFunc(IntPtr str, IntPtr len, IntPtr ctx);
	}
}
