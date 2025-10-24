using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;

namespace Bumptech.Glide.Module
{
	// Token: 0x02000066 RID: 102
	[Register("com/bumptech/glide/module/AppGlideModule", DoNotGenerateAcw = true)]
	internal class AppGlideModuleInvoker : AppGlideModule
	{
		// Token: 0x060004A6 RID: 1190 RVA: 0x0000FC2B File Offset: 0x0000DE2B
		public AppGlideModuleInvoker(IntPtr handle, JniHandleOwnership transfer) : base(handle, transfer)
		{
		}

		// Token: 0x170000DD RID: 221
		// (get) Token: 0x060004A7 RID: 1191 RVA: 0x0000FC35 File Offset: 0x0000DE35
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return AppGlideModuleInvoker._members;
			}
		}

		// Token: 0x170000DE RID: 222
		// (get) Token: 0x060004A8 RID: 1192 RVA: 0x0000FC3C File Offset: 0x0000DE3C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return AppGlideModuleInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x040000F7 RID: 247
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/bumptech/glide/module/AppGlideModule", typeof(AppGlideModuleInvoker));
	}
}
