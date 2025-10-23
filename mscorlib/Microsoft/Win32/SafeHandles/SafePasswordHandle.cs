using System;
using System.Runtime.InteropServices;

namespace Microsoft.Win32.SafeHandles
{
	// Token: 0x0200005C RID: 92
	internal sealed class SafePasswordHandle : SafeHandle
	{
		// Token: 0x06000209 RID: 521 RVA: 0x0000E224 File Offset: 0x0000C424
		private IntPtr CreateHandle(string password)
		{
			return Marshal.StringToHGlobalAnsi(password);
		}

		// Token: 0x0600020A RID: 522 RVA: 0x0000E22C File Offset: 0x0000C42C
		private void FreeHandle()
		{
			Marshal.ZeroFreeGlobalAllocAnsi(this.handle);
		}

		// Token: 0x0600020B RID: 523 RVA: 0x0000E239 File Offset: 0x0000C439
		public SafePasswordHandle(string password) : base(IntPtr.Zero, true)
		{
			if (password != null)
			{
				base.SetHandle(this.CreateHandle(password));
			}
		}

		// Token: 0x0600020C RID: 524 RVA: 0x0000E257 File Offset: 0x0000C457
		protected override bool ReleaseHandle()
		{
			if (this.handle != IntPtr.Zero)
			{
				this.FreeHandle();
			}
			base.SetHandle((IntPtr)(-1));
			return true;
		}

		// Token: 0x0600020D RID: 525 RVA: 0x0000E27E File Offset: 0x0000C47E
		protected override void Dispose(bool disposing)
		{
			if (disposing && SafeHandleCache<SafePasswordHandle>.IsCachedInvalidHandle(this))
			{
				return;
			}
			base.Dispose(disposing);
		}

		// Token: 0x17000038 RID: 56
		// (get) Token: 0x0600020E RID: 526 RVA: 0x0000E293 File Offset: 0x0000C493
		public override bool IsInvalid
		{
			get
			{
				return this.handle == (IntPtr)(-1);
			}
		}

		// Token: 0x0600020F RID: 527 RVA: 0x0000E2A6 File Offset: 0x0000C4A6
		internal string Mono_DangerousGetString()
		{
			return Marshal.PtrToStringAnsi(base.DangerousGetHandle());
		}
	}
}
