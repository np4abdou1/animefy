using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Android.Content
{
	// Token: 0x0200027A RID: 634
	[Register("android/content/BroadcastReceiver", DoNotGenerateAcw = true)]
	public abstract class BroadcastReceiver : Java.Lang.Object
	{
		// Token: 0x17000524 RID: 1316
		// (get) Token: 0x06001809 RID: 6153 RVA: 0x0003E3D7 File Offset: 0x0003C5D7
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return BroadcastReceiver._members;
			}
		}

		// Token: 0x17000525 RID: 1317
		// (get) Token: 0x0600180A RID: 6154 RVA: 0x0003E3E0 File Offset: 0x0003C5E0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return BroadcastReceiver._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000526 RID: 1318
		// (get) Token: 0x0600180B RID: 6155 RVA: 0x0003E404 File Offset: 0x0003C604
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return BroadcastReceiver._members.ManagedPeerType;
			}
		}

		// Token: 0x0600180C RID: 6156 RVA: 0x000021E0 File Offset: 0x000003E0
		protected BroadcastReceiver(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x0600180D RID: 6157 RVA: 0x0003E410 File Offset: 0x0003C610
		private static Delegate GetOnReceive_Landroid_content_Context_Landroid_content_Intent_Handler()
		{
			if (BroadcastReceiver.cb_onReceive_Landroid_content_Context_Landroid_content_Intent_ == null)
			{
				BroadcastReceiver.cb_onReceive_Landroid_content_Context_Landroid_content_Intent_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_V(BroadcastReceiver.n_OnReceive_Landroid_content_Context_Landroid_content_Intent_));
			}
			return BroadcastReceiver.cb_onReceive_Landroid_content_Context_Landroid_content_Intent_;
		}

		// Token: 0x0600180E RID: 6158 RVA: 0x0003E434 File Offset: 0x0003C634
		private static void n_OnReceive_Landroid_content_Context_Landroid_content_Intent_(IntPtr jnienv, IntPtr native__this, IntPtr native_context, IntPtr native_intent)
		{
			BroadcastReceiver @object = Java.Lang.Object.GetObject<BroadcastReceiver>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Context object2 = Java.Lang.Object.GetObject<Context>(native_context, JniHandleOwnership.DoNotTransfer);
			Intent object3 = Java.Lang.Object.GetObject<Intent>(native_intent, JniHandleOwnership.DoNotTransfer);
			@object.OnReceive(object2, object3);
		}

		// Token: 0x0600180F RID: 6159
		public abstract void OnReceive(Context context, Intent intent);

		// Token: 0x04000A40 RID: 2624
		private static readonly JniPeerMembers _members = new XAPeerMembers("android/content/BroadcastReceiver", typeof(BroadcastReceiver));

		// Token: 0x04000A41 RID: 2625
		private static Delegate cb_onReceive_Landroid_content_Context_Landroid_content_Intent_;
	}
}
