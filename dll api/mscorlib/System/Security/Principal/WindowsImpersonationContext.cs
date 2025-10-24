using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace System.Security.Principal
{
	/// <summary>Represents the Windows user prior to an impersonation operation.</summary>
	// Token: 0x020002F8 RID: 760
	[ComVisible(true)]
	public class WindowsImpersonationContext : IDisposable
	{
		// Token: 0x06001917 RID: 6423 RVA: 0x0006D923 File Offset: 0x0006BB23
		internal WindowsImpersonationContext(IntPtr token)
		{
			this._token = WindowsImpersonationContext.DuplicateToken(token);
			if (!WindowsImpersonationContext.SetCurrentToken(token))
			{
				throw new SecurityException("Couldn't impersonate token.");
			}
			this.undo = false;
		}

		/// <summary>Releases all resources used by the <see cref="T:System.Security.Principal.WindowsImpersonationContext" />.</summary>
		// Token: 0x06001918 RID: 6424 RVA: 0x0006D951 File Offset: 0x0006BB51
		[ComVisible(false)]
		public void Dispose()
		{
			if (!this.undo)
			{
				this.Undo();
			}
		}

		/// <summary>Reverts the user context to the Windows user represented by this object.</summary>
		/// <exception cref="T:System.Security.SecurityException">An attempt is made to use this method for any purpose other than to revert identity to self. </exception>
		// Token: 0x06001919 RID: 6425 RVA: 0x0006D961 File Offset: 0x0006BB61
		public void Undo()
		{
			if (!WindowsImpersonationContext.RevertToSelf())
			{
				WindowsImpersonationContext.CloseToken(this._token);
				throw new SecurityException("Couldn't switch back to original token.");
			}
			WindowsImpersonationContext.CloseToken(this._token);
			this.undo = true;
			GC.SuppressFinalize(this);
		}

		// Token: 0x0600191A RID: 6426
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool CloseToken(IntPtr token);

		// Token: 0x0600191B RID: 6427
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr DuplicateToken(IntPtr token);

		// Token: 0x0600191C RID: 6428
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool SetCurrentToken(IntPtr token);

		// Token: 0x0600191D RID: 6429
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool RevertToSelf();

		// Token: 0x04000A6D RID: 2669
		private IntPtr _token;

		// Token: 0x04000A6E RID: 2670
		private bool undo;
	}
}
