using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Content;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Com.Unity3d.Services.Core.Connectivity
{
	// Token: 0x02000147 RID: 327
	[Register("com/unity3d/services/core/connectivity/ConnectivityChangeReceiver", DoNotGenerateAcw = true)]
	public class ConnectivityChangeReceiver : BroadcastReceiver
	{
		// Token: 0x170004B5 RID: 1205
		// (get) Token: 0x06000D16 RID: 3350 RVA: 0x00024C60 File Offset: 0x00022E60
		internal static IntPtr class_ref
		{
			get
			{
				return ConnectivityChangeReceiver._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170004B6 RID: 1206
		// (get) Token: 0x06000D17 RID: 3351 RVA: 0x00024C84 File Offset: 0x00022E84
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return ConnectivityChangeReceiver._members;
			}
		}

		// Token: 0x170004B7 RID: 1207
		// (get) Token: 0x06000D18 RID: 3352 RVA: 0x00024C8C File Offset: 0x00022E8C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return ConnectivityChangeReceiver._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170004B8 RID: 1208
		// (get) Token: 0x06000D19 RID: 3353 RVA: 0x00024CB0 File Offset: 0x00022EB0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return ConnectivityChangeReceiver._members.ManagedPeerType;
			}
		}

		// Token: 0x06000D1A RID: 3354 RVA: 0x00024CBC File Offset: 0x00022EBC
		protected ConnectivityChangeReceiver(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000D1B RID: 3355 RVA: 0x00024CC8 File Offset: 0x00022EC8
		[Register(".ctor", "()V", "")]
		public ConnectivityChangeReceiver() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			base.SetHandle(ConnectivityChangeReceiver._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
			ConnectivityChangeReceiver._members.InstanceMethods.FinishCreateInstance("()V", this, null);
		}

		// Token: 0x06000D1C RID: 3356 RVA: 0x00024D36 File Offset: 0x00022F36
		private static Delegate GetOnReceive_Landroid_content_Context_Landroid_content_Intent_Handler()
		{
			if (ConnectivityChangeReceiver.cb_onReceive_Landroid_content_Context_Landroid_content_Intent_ == null)
			{
				ConnectivityChangeReceiver.cb_onReceive_Landroid_content_Context_Landroid_content_Intent_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_V(ConnectivityChangeReceiver.n_OnReceive_Landroid_content_Context_Landroid_content_Intent_));
			}
			return ConnectivityChangeReceiver.cb_onReceive_Landroid_content_Context_Landroid_content_Intent_;
		}

		// Token: 0x06000D1D RID: 3357 RVA: 0x00024D5C File Offset: 0x00022F5C
		private static void n_OnReceive_Landroid_content_Context_Landroid_content_Intent_(IntPtr jnienv, IntPtr native__this, IntPtr native_context, IntPtr native_intent)
		{
			BroadcastReceiver @object = Java.Lang.Object.GetObject<ConnectivityChangeReceiver>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Context object2 = Java.Lang.Object.GetObject<Context>(native_context, JniHandleOwnership.DoNotTransfer);
			Intent object3 = Java.Lang.Object.GetObject<Intent>(native_intent, JniHandleOwnership.DoNotTransfer);
			@object.OnReceive(object2, object3);
		}

		// Token: 0x06000D1E RID: 3358 RVA: 0x00024D88 File Offset: 0x00022F88
		[Register("onReceive", "(Landroid/content/Context;Landroid/content/Intent;)V", "GetOnReceive_Landroid_content_Context_Landroid_content_Intent_Handler")]
		public unsafe override void OnReceive(Context context, Intent intent)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((context == null) ? IntPtr.Zero : context.Handle);
				ptr[1] = new JniArgumentValue((intent == null) ? IntPtr.Zero : intent.Handle);
				ConnectivityChangeReceiver._members.InstanceMethods.InvokeVirtualVoidMethod("onReceive.(Landroid/content/Context;Landroid/content/Intent;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(context);
				GC.KeepAlive(intent);
			}
		}

		// Token: 0x06000D1F RID: 3359 RVA: 0x00024E14 File Offset: 0x00023014
		[Register("register", "()V", "")]
		public static void Register()
		{
			ConnectivityChangeReceiver._members.StaticMethods.InvokeVoidMethod("register.()V", null);
		}

		// Token: 0x06000D20 RID: 3360 RVA: 0x00024E2C File Offset: 0x0002302C
		[Register("unregister", "()V", "")]
		public static void Unregister()
		{
			ConnectivityChangeReceiver._members.StaticMethods.InvokeVoidMethod("unregister.()V", null);
		}

		// Token: 0x04000305 RID: 773
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/services/core/connectivity/ConnectivityChangeReceiver", typeof(ConnectivityChangeReceiver));

		// Token: 0x04000306 RID: 774
		private static Delegate cb_onReceive_Landroid_content_Context_Landroid_content_Intent_;
	}
}
