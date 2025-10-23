using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Android.Views
{
	// Token: 0x0200016B RID: 363
	[Register("android/view/Window", DoNotGenerateAcw = true)]
	internal class WindowInvoker : Window
	{
		// Token: 0x06000D61 RID: 3425 RVA: 0x000227FC File Offset: 0x000209FC
		public WindowInvoker(IntPtr handle, JniHandleOwnership transfer) : base(handle, transfer)
		{
		}

		// Token: 0x1700027E RID: 638
		// (get) Token: 0x06000D62 RID: 3426 RVA: 0x00022806 File Offset: 0x00020A06
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return WindowInvoker._members;
			}
		}

		// Token: 0x1700027F RID: 639
		// (get) Token: 0x06000D63 RID: 3427 RVA: 0x0002280D File Offset: 0x00020A0D
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return WindowInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x17000280 RID: 640
		// (get) Token: 0x06000D64 RID: 3428 RVA: 0x0002281C File Offset: 0x00020A1C
		public override View DecorView
		{
			get
			{
				return Java.Lang.Object.GetObject<View>(WindowInvoker._members.InstanceMethods.InvokeAbstractObjectMethod("getDecorView.()Landroid/view/View;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x0400046D RID: 1133
		private static readonly JniPeerMembers _members = new XAPeerMembers("android/view/Window", typeof(WindowInvoker));
	}
}
