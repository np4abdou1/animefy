using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;

namespace Bumptech.Glide.Module
{
	// Token: 0x0200006E RID: 110
	[Register("com/bumptech/glide/module/LibraryGlideModule", DoNotGenerateAcw = true)]
	internal class LibraryGlideModuleInvoker : LibraryGlideModule
	{
		// Token: 0x060004DD RID: 1245 RVA: 0x0001054F File Offset: 0x0000E74F
		public LibraryGlideModuleInvoker(IntPtr handle, JniHandleOwnership transfer) : base(handle, transfer)
		{
		}

		// Token: 0x170000EF RID: 239
		// (get) Token: 0x060004DE RID: 1246 RVA: 0x00010559 File Offset: 0x0000E759
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return LibraryGlideModuleInvoker._members;
			}
		}

		// Token: 0x170000F0 RID: 240
		// (get) Token: 0x060004DF RID: 1247 RVA: 0x00010560 File Offset: 0x0000E760
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return LibraryGlideModuleInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x04000108 RID: 264
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/bumptech/glide/module/LibraryGlideModule", typeof(LibraryGlideModuleInvoker));
	}
}
