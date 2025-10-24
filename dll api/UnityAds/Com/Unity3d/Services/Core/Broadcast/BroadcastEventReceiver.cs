using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Content;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Com.Unity3d.Services.Core.Broadcast
{
	// Token: 0x02000182 RID: 386
	[Register("com/unity3d/services/core/broadcast/BroadcastEventReceiver", DoNotGenerateAcw = true)]
	public class BroadcastEventReceiver : BroadcastReceiver
	{
		// Token: 0x1700062B RID: 1579
		// (get) Token: 0x0600115E RID: 4446 RVA: 0x0002EA40 File Offset: 0x0002CC40
		internal static IntPtr class_ref
		{
			get
			{
				return BroadcastEventReceiver._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700062C RID: 1580
		// (get) Token: 0x0600115F RID: 4447 RVA: 0x0002EA64 File Offset: 0x0002CC64
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return BroadcastEventReceiver._members;
			}
		}

		// Token: 0x1700062D RID: 1581
		// (get) Token: 0x06001160 RID: 4448 RVA: 0x0002EA6C File Offset: 0x0002CC6C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return BroadcastEventReceiver._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700062E RID: 1582
		// (get) Token: 0x06001161 RID: 4449 RVA: 0x0002EA90 File Offset: 0x0002CC90
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return BroadcastEventReceiver._members.ManagedPeerType;
			}
		}

		// Token: 0x06001162 RID: 4450 RVA: 0x00024CBC File Offset: 0x00022EBC
		protected BroadcastEventReceiver(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06001163 RID: 4451 RVA: 0x0002EA9C File Offset: 0x0002CC9C
		[Register(".ctor", "(Ljava/lang/String;)V", "")]
		public unsafe BroadcastEventReceiver(string name) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			IntPtr intPtr = JNIEnv.NewString(name);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				base.SetHandle(BroadcastEventReceiver._members.InstanceMethods.StartCreateInstance("(Ljava/lang/String;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				BroadcastEventReceiver._members.InstanceMethods.FinishCreateInstance("(Ljava/lang/String;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
		}

		// Token: 0x06001164 RID: 4452 RVA: 0x0002EB40 File Offset: 0x0002CD40
		private static Delegate GetOnReceive_Landroid_content_Context_Landroid_content_Intent_Handler()
		{
			if (BroadcastEventReceiver.cb_onReceive_Landroid_content_Context_Landroid_content_Intent_ == null)
			{
				BroadcastEventReceiver.cb_onReceive_Landroid_content_Context_Landroid_content_Intent_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_V(BroadcastEventReceiver.n_OnReceive_Landroid_content_Context_Landroid_content_Intent_));
			}
			return BroadcastEventReceiver.cb_onReceive_Landroid_content_Context_Landroid_content_Intent_;
		}

		// Token: 0x06001165 RID: 4453 RVA: 0x0002EB64 File Offset: 0x0002CD64
		private static void n_OnReceive_Landroid_content_Context_Landroid_content_Intent_(IntPtr jnienv, IntPtr native__this, IntPtr native_context, IntPtr native_intent)
		{
			BroadcastReceiver @object = Java.Lang.Object.GetObject<BroadcastEventReceiver>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Context object2 = Java.Lang.Object.GetObject<Context>(native_context, JniHandleOwnership.DoNotTransfer);
			Intent object3 = Java.Lang.Object.GetObject<Intent>(native_intent, JniHandleOwnership.DoNotTransfer);
			@object.OnReceive(object2, object3);
		}

		// Token: 0x06001166 RID: 4454 RVA: 0x0002EB90 File Offset: 0x0002CD90
		[Register("onReceive", "(Landroid/content/Context;Landroid/content/Intent;)V", "GetOnReceive_Landroid_content_Context_Landroid_content_Intent_Handler")]
		public unsafe override void OnReceive(Context context, Intent intent)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((context == null) ? IntPtr.Zero : context.Handle);
				ptr[1] = new JniArgumentValue((intent == null) ? IntPtr.Zero : intent.Handle);
				BroadcastEventReceiver._members.InstanceMethods.InvokeVirtualVoidMethod("onReceive.(Landroid/content/Context;Landroid/content/Intent;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(context);
				GC.KeepAlive(intent);
			}
		}

		// Token: 0x04000444 RID: 1092
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/services/core/broadcast/BroadcastEventReceiver", typeof(BroadcastEventReceiver));

		// Token: 0x04000445 RID: 1093
		private static Delegate cb_onReceive_Landroid_content_Context_Landroid_content_Intent_;
	}
}
