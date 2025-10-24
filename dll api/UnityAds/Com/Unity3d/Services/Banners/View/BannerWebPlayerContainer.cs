using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Com.Unity3d.Services.Ads.Webplayer;
using Java.Interop;
using Java.Lang;
using Org.Json;

namespace Com.Unity3d.Services.Banners.View
{
	// Token: 0x020001BC RID: 444
	[Register("com/unity3d/services/banners/view/BannerWebPlayerContainer", DoNotGenerateAcw = true)]
	public class BannerWebPlayerContainer : RelativeLayout
	{
		// Token: 0x170006D4 RID: 1748
		// (get) Token: 0x060013BA RID: 5050 RVA: 0x00037BDC File Offset: 0x00035DDC
		internal static IntPtr class_ref
		{
			get
			{
				return BannerWebPlayerContainer._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170006D5 RID: 1749
		// (get) Token: 0x060013BB RID: 5051 RVA: 0x00037C00 File Offset: 0x00035E00
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return BannerWebPlayerContainer._members;
			}
		}

		// Token: 0x170006D6 RID: 1750
		// (get) Token: 0x060013BC RID: 5052 RVA: 0x00037C08 File Offset: 0x00035E08
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return BannerWebPlayerContainer._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170006D7 RID: 1751
		// (get) Token: 0x060013BD RID: 5053 RVA: 0x00037C2C File Offset: 0x00035E2C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return BannerWebPlayerContainer._members.ManagedPeerType;
			}
		}

		// Token: 0x060013BE RID: 5054 RVA: 0x0003528C File Offset: 0x0003348C
		protected BannerWebPlayerContainer(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x060013BF RID: 5055 RVA: 0x00037C38 File Offset: 0x00035E38
		[Register(".ctor", "(Landroid/content/Context;Ljava/lang/String;Lorg/json/JSONObject;Lorg/json/JSONObject;Lorg/json/JSONObject;Lcom/unity3d/services/banners/UnityBannerSize;)V", "")]
		public unsafe BannerWebPlayerContainer(Context context, string bannerAdId, JSONObject webSettings, JSONObject webPlayerSettings, JSONObject webPlayerEventSettings, UnityBannerSize size) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			IntPtr intPtr = JNIEnv.NewString(bannerAdId);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((context == null) ? IntPtr.Zero : context.Handle);
				ptr[1] = new JniArgumentValue(intPtr);
				ptr[2] = new JniArgumentValue((webSettings == null) ? IntPtr.Zero : webSettings.Handle);
				ptr[3] = new JniArgumentValue((webPlayerSettings == null) ? IntPtr.Zero : webPlayerSettings.Handle);
				ptr[4] = new JniArgumentValue((webPlayerEventSettings == null) ? IntPtr.Zero : webPlayerEventSettings.Handle);
				ptr[5] = new JniArgumentValue((size == null) ? IntPtr.Zero : size.Handle);
				base.SetHandle(BannerWebPlayerContainer._members.InstanceMethods.StartCreateInstance("(Landroid/content/Context;Ljava/lang/String;Lorg/json/JSONObject;Lorg/json/JSONObject;Lorg/json/JSONObject;Lcom/unity3d/services/banners/UnityBannerSize;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				BannerWebPlayerContainer._members.InstanceMethods.FinishCreateInstance("(Landroid/content/Context;Ljava/lang/String;Lorg/json/JSONObject;Lorg/json/JSONObject;Lorg/json/JSONObject;Lcom/unity3d/services/banners/UnityBannerSize;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(context);
				GC.KeepAlive(webSettings);
				GC.KeepAlive(webPlayerSettings);
				GC.KeepAlive(webPlayerEventSettings);
				GC.KeepAlive(size);
			}
		}

		// Token: 0x060013C0 RID: 5056 RVA: 0x00037DC8 File Offset: 0x00035FC8
		private static Delegate GetGetWebPlayerHandler()
		{
			if (BannerWebPlayerContainer.cb_getWebPlayer == null)
			{
				BannerWebPlayerContainer.cb_getWebPlayer = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(BannerWebPlayerContainer.n_GetWebPlayer));
			}
			return BannerWebPlayerContainer.cb_getWebPlayer;
		}

		// Token: 0x060013C1 RID: 5057 RVA: 0x00037DEC File Offset: 0x00035FEC
		private static IntPtr n_GetWebPlayer(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<BannerWebPlayerContainer>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).WebPlayer);
		}

		// Token: 0x170006D8 RID: 1752
		// (get) Token: 0x060013C2 RID: 5058 RVA: 0x00037E00 File Offset: 0x00036000
		public virtual WebPlayerView WebPlayer
		{
			[Register("getWebPlayer", "()Lcom/unity3d/services/ads/webplayer/WebPlayerView;", "GetGetWebPlayerHandler")]
			get
			{
				return Java.Lang.Object.GetObject<WebPlayerView>(BannerWebPlayerContainer._members.InstanceMethods.InvokeVirtualObjectMethod("getWebPlayer.()Lcom/unity3d/services/ads/webplayer/WebPlayerView;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x060013C3 RID: 5059 RVA: 0x00037E32 File Offset: 0x00036032
		private static Delegate GetDestroyHandler()
		{
			if (BannerWebPlayerContainer.cb_destroy == null)
			{
				BannerWebPlayerContainer.cb_destroy = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(BannerWebPlayerContainer.n_Destroy));
			}
			return BannerWebPlayerContainer.cb_destroy;
		}

		// Token: 0x060013C4 RID: 5060 RVA: 0x00037E56 File Offset: 0x00036056
		private static void n_Destroy(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<BannerWebPlayerContainer>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Destroy();
		}

		// Token: 0x060013C5 RID: 5061 RVA: 0x00037E65 File Offset: 0x00036065
		[Register("destroy", "()V", "GetDestroyHandler")]
		public virtual void Destroy()
		{
			BannerWebPlayerContainer._members.InstanceMethods.InvokeVirtualVoidMethod("destroy.()V", this, null);
		}

		// Token: 0x060013C6 RID: 5062 RVA: 0x00037E7E File Offset: 0x0003607E
		private static Delegate GetOnLayoutChange_Landroid_view_View_IIIIIIIIHandler()
		{
			if (BannerWebPlayerContainer.cb_onLayoutChange_Landroid_view_View_IIIIIIII == null)
			{
				BannerWebPlayerContainer.cb_onLayoutChange_Landroid_view_View_IIIIIIII = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLIIIIIIII_V(BannerWebPlayerContainer.n_OnLayoutChange_Landroid_view_View_IIIIIIII));
			}
			return BannerWebPlayerContainer.cb_onLayoutChange_Landroid_view_View_IIIIIIII;
		}

		// Token: 0x060013C7 RID: 5063 RVA: 0x00037EA4 File Offset: 0x000360A4
		private static void n_OnLayoutChange_Landroid_view_View_IIIIIIII(IntPtr jnienv, IntPtr native__this, IntPtr native_v, int left, int top, int right, int bottom, int oldLeft, int oldTop, int oldRight, int oldBottom)
		{
			BannerWebPlayerContainer @object = Java.Lang.Object.GetObject<BannerWebPlayerContainer>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			View object2 = Java.Lang.Object.GetObject<View>(native_v, JniHandleOwnership.DoNotTransfer);
			@object.OnLayoutChange(object2, left, top, right, bottom, oldLeft, oldTop, oldRight, oldBottom);
		}

		// Token: 0x060013C8 RID: 5064 RVA: 0x00037ED8 File Offset: 0x000360D8
		[Register("onLayoutChange", "(Landroid/view/View;IIIIIIII)V", "GetOnLayoutChange_Landroid_view_View_IIIIIIIIHandler")]
		public unsafe virtual void OnLayoutChange(View v, int left, int top, int right, int bottom, int oldLeft, int oldTop, int oldRight, int oldBottom)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)9) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((v == null) ? IntPtr.Zero : v.Handle);
				ptr[1] = new JniArgumentValue(left);
				ptr[2] = new JniArgumentValue(top);
				ptr[3] = new JniArgumentValue(right);
				ptr[4] = new JniArgumentValue(bottom);
				ptr[5] = new JniArgumentValue(oldLeft);
				ptr[6] = new JniArgumentValue(oldTop);
				ptr[7] = new JniArgumentValue(oldRight);
				ptr[8] = new JniArgumentValue(oldBottom);
				BannerWebPlayerContainer._members.InstanceMethods.InvokeVirtualVoidMethod("onLayoutChange.(Landroid/view/View;IIIIIIII)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(v);
			}
		}

		// Token: 0x060013C9 RID: 5065 RVA: 0x00037FF0 File Offset: 0x000361F0
		private static Delegate GetSetWebPlayerEventSettings_Lorg_json_JSONObject_Handler()
		{
			if (BannerWebPlayerContainer.cb_setWebPlayerEventSettings_Lorg_json_JSONObject_ == null)
			{
				BannerWebPlayerContainer.cb_setWebPlayerEventSettings_Lorg_json_JSONObject_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(BannerWebPlayerContainer.n_SetWebPlayerEventSettings_Lorg_json_JSONObject_));
			}
			return BannerWebPlayerContainer.cb_setWebPlayerEventSettings_Lorg_json_JSONObject_;
		}

		// Token: 0x060013CA RID: 5066 RVA: 0x00038014 File Offset: 0x00036214
		private static void n_SetWebPlayerEventSettings_Lorg_json_JSONObject_(IntPtr jnienv, IntPtr native__this, IntPtr native_webPlayerEventSettings)
		{
			BannerWebPlayerContainer @object = Java.Lang.Object.GetObject<BannerWebPlayerContainer>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			JSONObject object2 = Java.Lang.Object.GetObject<JSONObject>(native_webPlayerEventSettings, JniHandleOwnership.DoNotTransfer);
			@object.SetWebPlayerEventSettings(object2);
		}

		// Token: 0x060013CB RID: 5067 RVA: 0x00038038 File Offset: 0x00036238
		[Register("setWebPlayerEventSettings", "(Lorg/json/JSONObject;)V", "GetSetWebPlayerEventSettings_Lorg_json_JSONObject_Handler")]
		public unsafe virtual void SetWebPlayerEventSettings(JSONObject webPlayerEventSettings)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((webPlayerEventSettings == null) ? IntPtr.Zero : webPlayerEventSettings.Handle);
				BannerWebPlayerContainer._members.InstanceMethods.InvokeVirtualVoidMethod("setWebPlayerEventSettings.(Lorg/json/JSONObject;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(webPlayerEventSettings);
			}
		}

		// Token: 0x060013CC RID: 5068 RVA: 0x0003809C File Offset: 0x0003629C
		private static Delegate GetSetWebPlayerSettings_Lorg_json_JSONObject_Lorg_json_JSONObject_Handler()
		{
			if (BannerWebPlayerContainer.cb_setWebPlayerSettings_Lorg_json_JSONObject_Lorg_json_JSONObject_ == null)
			{
				BannerWebPlayerContainer.cb_setWebPlayerSettings_Lorg_json_JSONObject_Lorg_json_JSONObject_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_V(BannerWebPlayerContainer.n_SetWebPlayerSettings_Lorg_json_JSONObject_Lorg_json_JSONObject_));
			}
			return BannerWebPlayerContainer.cb_setWebPlayerSettings_Lorg_json_JSONObject_Lorg_json_JSONObject_;
		}

		// Token: 0x060013CD RID: 5069 RVA: 0x000380C0 File Offset: 0x000362C0
		private static void n_SetWebPlayerSettings_Lorg_json_JSONObject_Lorg_json_JSONObject_(IntPtr jnienv, IntPtr native__this, IntPtr native_webSettings, IntPtr native_webPlayerSettings)
		{
			BannerWebPlayerContainer @object = Java.Lang.Object.GetObject<BannerWebPlayerContainer>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			JSONObject object2 = Java.Lang.Object.GetObject<JSONObject>(native_webSettings, JniHandleOwnership.DoNotTransfer);
			JSONObject object3 = Java.Lang.Object.GetObject<JSONObject>(native_webPlayerSettings, JniHandleOwnership.DoNotTransfer);
			@object.SetWebPlayerSettings(object2, object3);
		}

		// Token: 0x060013CE RID: 5070 RVA: 0x000380EC File Offset: 0x000362EC
		[Register("setWebPlayerSettings", "(Lorg/json/JSONObject;Lorg/json/JSONObject;)V", "GetSetWebPlayerSettings_Lorg_json_JSONObject_Lorg_json_JSONObject_Handler")]
		public unsafe virtual void SetWebPlayerSettings(JSONObject webSettings, JSONObject webPlayerSettings)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((webSettings == null) ? IntPtr.Zero : webSettings.Handle);
				ptr[1] = new JniArgumentValue((webPlayerSettings == null) ? IntPtr.Zero : webPlayerSettings.Handle);
				BannerWebPlayerContainer._members.InstanceMethods.InvokeVirtualVoidMethod("setWebPlayerSettings.(Lorg/json/JSONObject;Lorg/json/JSONObject;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(webSettings);
				GC.KeepAlive(webPlayerSettings);
			}
		}

		// Token: 0x040004C0 RID: 1216
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/services/banners/view/BannerWebPlayerContainer", typeof(BannerWebPlayerContainer));

		// Token: 0x040004C1 RID: 1217
		private static Delegate cb_getWebPlayer;

		// Token: 0x040004C2 RID: 1218
		private static Delegate cb_destroy;

		// Token: 0x040004C3 RID: 1219
		private static Delegate cb_onLayoutChange_Landroid_view_View_IIIIIIII;

		// Token: 0x040004C4 RID: 1220
		private static Delegate cb_setWebPlayerEventSettings_Lorg_json_JSONObject_;

		// Token: 0x040004C5 RID: 1221
		private static Delegate cb_setWebPlayerSettings_Lorg_json_JSONObject_Lorg_json_JSONObject_;
	}
}
