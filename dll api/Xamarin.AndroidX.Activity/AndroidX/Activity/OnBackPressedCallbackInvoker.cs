using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;

namespace AndroidX.Activity
{
	// Token: 0x02000019 RID: 25
	[Register("androidx/activity/OnBackPressedCallback", DoNotGenerateAcw = true)]
	internal class OnBackPressedCallbackInvoker : OnBackPressedCallback
	{
		// Token: 0x060000B7 RID: 183 RVA: 0x00003BEE File Offset: 0x00001DEE
		public OnBackPressedCallbackInvoker(IntPtr handle, JniHandleOwnership transfer) : base(handle, transfer)
		{
		}

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x060000B8 RID: 184 RVA: 0x00003BF8 File Offset: 0x00001DF8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return OnBackPressedCallbackInvoker._members;
			}
		}

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x060000B9 RID: 185 RVA: 0x00003BFF File Offset: 0x00001DFF
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return OnBackPressedCallbackInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x060000BA RID: 186 RVA: 0x00003C0B File Offset: 0x00001E0B
		[Register("handleOnBackPressed", "()V", "GetHandleOnBackPressedHandler")]
		public override void HandleOnBackPressed()
		{
			OnBackPressedCallbackInvoker._members.InstanceMethods.InvokeAbstractVoidMethod("handleOnBackPressed.()V", this, null);
		}

		// Token: 0x04000026 RID: 38
		private static readonly JniPeerMembers _members = new XAPeerMembers("androidx/activity/OnBackPressedCallback", typeof(OnBackPressedCallbackInvoker));
	}
}
