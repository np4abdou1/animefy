using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Authentication;
using System.Security.Cryptography;
using System.Threading;

namespace Mono.Btls
{
	// Token: 0x0200003A RID: 58
	internal abstract class MonoBtlsObject : IDisposable
	{
		// Token: 0x0600014F RID: 335 RVA: 0x000065B2 File Offset: 0x000047B2
		internal MonoBtlsObject(MonoBtlsObject.MonoBtlsHandle handle)
		{
			this.handle = handle;
		}

		// Token: 0x1700004C RID: 76
		// (get) Token: 0x06000150 RID: 336 RVA: 0x000065C1 File Offset: 0x000047C1
		internal MonoBtlsObject.MonoBtlsHandle Handle
		{
			get
			{
				this.CheckThrow();
				return this.handle;
			}
		}

		// Token: 0x1700004D RID: 77
		// (get) Token: 0x06000151 RID: 337 RVA: 0x000065CF File Offset: 0x000047CF
		public bool IsValid
		{
			get
			{
				return this.handle != null && !this.handle.IsInvalid;
			}
		}

		// Token: 0x06000152 RID: 338 RVA: 0x000065E9 File Offset: 0x000047E9
		protected void CheckThrow()
		{
			if (this.lastError != null)
			{
				throw this.lastError;
			}
			if (this.handle == null || this.handle.IsInvalid)
			{
				throw new ObjectDisposedException("MonoBtlsSsl");
			}
		}

		// Token: 0x06000153 RID: 339 RVA: 0x0000661A File Offset: 0x0000481A
		protected Exception SetException(Exception ex)
		{
			if (this.lastError == null)
			{
				this.lastError = ex;
			}
			return ex;
		}

		// Token: 0x06000154 RID: 340 RVA: 0x0000662C File Offset: 0x0000482C
		protected void CheckError(bool ok, [CallerMemberName] string callerName = null)
		{
			if (ok)
			{
				return;
			}
			if (callerName != null)
			{
				throw new CryptographicException(string.Concat(new string[]
				{
					"`",
					base.GetType().Name,
					".",
					callerName,
					"` failed."
				}));
			}
			throw new CryptographicException();
		}

		// Token: 0x06000155 RID: 341 RVA: 0x00006680 File Offset: 0x00004880
		protected void CheckError(int ret, [CallerMemberName] string callerName = null)
		{
			this.CheckError(ret == 1, callerName);
		}

		// Token: 0x06000156 RID: 342 RVA: 0x00006690 File Offset: 0x00004890
		protected internal void CheckLastError([CallerMemberName] string callerName = null)
		{
			Exception ex = Interlocked.Exchange<Exception>(ref this.lastError, null);
			if (ex == null)
			{
				return;
			}
			if (ex is AuthenticationException || ex is NotSupportedException)
			{
				throw ex;
			}
			string message;
			if (callerName != null)
			{
				message = string.Concat(new string[]
				{
					"Caught unhandled exception in `",
					base.GetType().Name,
					".",
					callerName,
					"`."
				});
			}
			else
			{
				message = "Caught unhandled exception.";
			}
			throw new CryptographicException(message, ex);
		}

		// Token: 0x06000157 RID: 343
		[DllImport("libmono-btls-shared")]
		private static extern void mono_btls_free(IntPtr data);

		// Token: 0x06000158 RID: 344 RVA: 0x00006708 File Offset: 0x00004908
		protected void FreeDataPtr(IntPtr data)
		{
			MonoBtlsObject.mono_btls_free(data);
		}

		// Token: 0x06000159 RID: 345 RVA: 0x00004D67 File Offset: 0x00002F67
		protected virtual void Close()
		{
		}

		// Token: 0x0600015A RID: 346 RVA: 0x00006710 File Offset: 0x00004910
		protected void Dispose(bool disposing)
		{
			if (disposing)
			{
				try
				{
					if (this.handle != null)
					{
						this.Close();
						this.handle.Dispose();
						this.handle = null;
					}
				}
				finally
				{
					ObjectDisposedException value = new ObjectDisposedException(base.GetType().Name);
					Interlocked.CompareExchange<Exception>(ref this.lastError, value, null);
				}
			}
		}

		// Token: 0x0600015B RID: 347 RVA: 0x00006774 File Offset: 0x00004974
		public void Dispose()
		{
			this.Dispose(true);
			GC.SuppressFinalize(this);
		}

		// Token: 0x0600015C RID: 348 RVA: 0x00006784 File Offset: 0x00004984
		~MonoBtlsObject()
		{
			this.Dispose(false);
		}

		// Token: 0x040000B8 RID: 184
		private MonoBtlsObject.MonoBtlsHandle handle;

		// Token: 0x040000B9 RID: 185
		private Exception lastError;

		// Token: 0x0200003B RID: 59
		protected internal abstract class MonoBtlsHandle : SafeHandle
		{
			// Token: 0x0600015D RID: 349 RVA: 0x000067B4 File Offset: 0x000049B4
			internal MonoBtlsHandle(IntPtr handle, bool ownsHandle) : base(handle, ownsHandle)
			{
			}

			// Token: 0x1700004E RID: 78
			// (get) Token: 0x0600015E RID: 350 RVA: 0x000067BE File Offset: 0x000049BE
			public override bool IsInvalid
			{
				get
				{
					return this.handle == IntPtr.Zero;
				}
			}
		}
	}
}
