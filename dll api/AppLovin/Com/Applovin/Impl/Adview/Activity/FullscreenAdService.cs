using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Com.Applovin.Impl.Adview.Activity
{
	// Token: 0x02000171 RID: 369
	[Register("com/applovin/impl/adview/activity/FullscreenAdService", DoNotGenerateAcw = true)]
	public class FullscreenAdService : Service
	{
		// Token: 0x170004A0 RID: 1184
		// (get) Token: 0x060011C4 RID: 4548 RVA: 0x000331F0 File Offset: 0x000313F0
		internal static IntPtr class_ref
		{
			get
			{
				return FullscreenAdService._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170004A1 RID: 1185
		// (get) Token: 0x060011C5 RID: 4549 RVA: 0x00033214 File Offset: 0x00031414
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return FullscreenAdService._members;
			}
		}

		// Token: 0x170004A2 RID: 1186
		// (get) Token: 0x060011C6 RID: 4550 RVA: 0x0003321C File Offset: 0x0003141C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return FullscreenAdService._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170004A3 RID: 1187
		// (get) Token: 0x060011C7 RID: 4551 RVA: 0x00033240 File Offset: 0x00031440
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return FullscreenAdService._members.ManagedPeerType;
			}
		}

		// Token: 0x060011C8 RID: 4552 RVA: 0x00026AB8 File Offset: 0x00024CB8
		protected FullscreenAdService(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x060011C9 RID: 4553 RVA: 0x0003324C File Offset: 0x0003144C
		[Register(".ctor", "()V", "")]
		public FullscreenAdService() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			base.SetHandle(FullscreenAdService._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
			FullscreenAdService._members.InstanceMethods.FinishCreateInstance("()V", this, null);
		}

		// Token: 0x060011CA RID: 4554 RVA: 0x000332BA File Offset: 0x000314BA
		private static Delegate GetOnBind_Landroid_content_Intent_Handler()
		{
			if (FullscreenAdService.cb_onBind_Landroid_content_Intent_ == null)
			{
				FullscreenAdService.cb_onBind_Landroid_content_Intent_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(FullscreenAdService.n_OnBind_Landroid_content_Intent_));
			}
			return FullscreenAdService.cb_onBind_Landroid_content_Intent_;
		}

		// Token: 0x060011CB RID: 4555 RVA: 0x000332E0 File Offset: 0x000314E0
		private static IntPtr n_OnBind_Landroid_content_Intent_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			Service @object = Java.Lang.Object.GetObject<FullscreenAdService>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Intent object2 = Java.Lang.Object.GetObject<Intent>(native_p0, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.OnBind(object2));
		}

		// Token: 0x060011CC RID: 4556 RVA: 0x00033308 File Offset: 0x00031508
		[Register("onBind", "(Landroid/content/Intent;)Landroid/os/IBinder;", "GetOnBind_Landroid_content_Intent_Handler")]
		public unsafe override IBinder OnBind(Intent p0)
		{
			IBinder @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((p0 == null) ? IntPtr.Zero : p0.Handle);
				@object = Java.Lang.Object.GetObject<IBinder>(FullscreenAdService._members.InstanceMethods.InvokeVirtualObjectMethod("onBind.(Landroid/content/Intent;)Landroid/os/IBinder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(p0);
			}
			return @object;
		}

		// Token: 0x040005D1 RID: 1489
		[Register("DATA_KEY_AD_SOURCE")]
		public const string DataKeyAdSource = "ad_source";

		// Token: 0x040005D2 RID: 1490
		[Register("DATA_KEY_RAW_FULL_AD_RESPONSE")]
		public const string DataKeyRawFullAdResponse = "raw_full_ad_response";

		// Token: 0x040005D3 RID: 1491
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/applovin/impl/adview/activity/FullscreenAdService", typeof(FullscreenAdService));

		// Token: 0x040005D4 RID: 1492
		private static Delegate cb_onBind_Landroid_content_Intent_;
	}
}
