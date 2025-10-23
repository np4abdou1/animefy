using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Android.Webkit
{
	// Token: 0x02000107 RID: 263
	[Register("android/webkit/WebSettings", DoNotGenerateAcw = true)]
	public abstract class WebSettings : Java.Lang.Object
	{
		// Token: 0x1700013B RID: 315
		// (get) Token: 0x0600067D RID: 1661 RVA: 0x0000E9BE File Offset: 0x0000CBBE
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return WebSettings._members;
			}
		}

		// Token: 0x1700013C RID: 316
		// (get) Token: 0x0600067E RID: 1662 RVA: 0x0000E9C8 File Offset: 0x0000CBC8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return WebSettings._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700013D RID: 317
		// (get) Token: 0x0600067F RID: 1663 RVA: 0x0000E9EC File Offset: 0x0000CBEC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return WebSettings._members.ManagedPeerType;
			}
		}

		// Token: 0x06000680 RID: 1664 RVA: 0x000021E0 File Offset: 0x000003E0
		protected WebSettings(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000681 RID: 1665 RVA: 0x0000E9F8 File Offset: 0x0000CBF8
		private static Delegate GetSetCacheMode_IHandler()
		{
			if (WebSettings.cb_setCacheMode_I == null)
			{
				WebSettings.cb_setCacheMode_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_V(WebSettings.n_SetCacheMode_I));
			}
			return WebSettings.cb_setCacheMode_I;
		}

		// Token: 0x06000682 RID: 1666 RVA: 0x0000EA1C File Offset: 0x0000CC1C
		private static void n_SetCacheMode_I(IntPtr jnienv, IntPtr native__this, int native_mode)
		{
			Java.Lang.Object.GetObject<WebSettings>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).CacheMode = (CacheModes)native_mode;
		}

		// Token: 0x1700013E RID: 318
		// (set) Token: 0x06000683 RID: 1667
		public abstract CacheModes CacheMode { set; }

		// Token: 0x06000684 RID: 1668 RVA: 0x0000EA39 File Offset: 0x0000CC39
		private static Delegate GetSetDomStorageEnabled_ZHandler()
		{
			if (WebSettings.cb_setDomStorageEnabled_Z == null)
			{
				WebSettings.cb_setDomStorageEnabled_Z = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPZ_V(WebSettings.n_SetDomStorageEnabled_Z));
			}
			return WebSettings.cb_setDomStorageEnabled_Z;
		}

		// Token: 0x06000685 RID: 1669 RVA: 0x0000EA5D File Offset: 0x0000CC5D
		private static void n_SetDomStorageEnabled_Z(IntPtr jnienv, IntPtr native__this, bool flag)
		{
			Java.Lang.Object.GetObject<WebSettings>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).DomStorageEnabled = flag;
		}

		// Token: 0x1700013F RID: 319
		// (set) Token: 0x06000686 RID: 1670
		public abstract bool DomStorageEnabled { set; }

		// Token: 0x06000687 RID: 1671 RVA: 0x0000EA6D File Offset: 0x0000CC6D
		private static Delegate GetSetJavaScriptEnabled_ZHandler()
		{
			if (WebSettings.cb_setJavaScriptEnabled_Z == null)
			{
				WebSettings.cb_setJavaScriptEnabled_Z = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPZ_V(WebSettings.n_SetJavaScriptEnabled_Z));
			}
			return WebSettings.cb_setJavaScriptEnabled_Z;
		}

		// Token: 0x06000688 RID: 1672 RVA: 0x0000EA91 File Offset: 0x0000CC91
		private static void n_SetJavaScriptEnabled_Z(IntPtr jnienv, IntPtr native__this, bool flag)
		{
			Java.Lang.Object.GetObject<WebSettings>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).JavaScriptEnabled = flag;
		}

		// Token: 0x17000140 RID: 320
		// (set) Token: 0x06000689 RID: 1673
		public abstract bool JavaScriptEnabled { set; }

		// Token: 0x0600068A RID: 1674 RVA: 0x0000EAA1 File Offset: 0x0000CCA1
		private static Delegate GetSetMediaPlaybackRequiresUserGesture_ZHandler()
		{
			if (WebSettings.cb_setMediaPlaybackRequiresUserGesture_Z == null)
			{
				WebSettings.cb_setMediaPlaybackRequiresUserGesture_Z = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPZ_V(WebSettings.n_SetMediaPlaybackRequiresUserGesture_Z));
			}
			return WebSettings.cb_setMediaPlaybackRequiresUserGesture_Z;
		}

		// Token: 0x0600068B RID: 1675 RVA: 0x0000EAC5 File Offset: 0x0000CCC5
		private static void n_SetMediaPlaybackRequiresUserGesture_Z(IntPtr jnienv, IntPtr native__this, bool require)
		{
			Java.Lang.Object.GetObject<WebSettings>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).MediaPlaybackRequiresUserGesture = require;
		}

		// Token: 0x17000141 RID: 321
		// (set) Token: 0x0600068C RID: 1676
		public abstract bool MediaPlaybackRequiresUserGesture { set; }

		// Token: 0x0600068D RID: 1677 RVA: 0x0000EAD5 File Offset: 0x0000CCD5
		private static Delegate GetGetUserAgentStringHandler()
		{
			if (WebSettings.cb_getUserAgentString == null)
			{
				WebSettings.cb_getUserAgentString = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(WebSettings.n_GetUserAgentString));
			}
			return WebSettings.cb_getUserAgentString;
		}

		// Token: 0x0600068E RID: 1678 RVA: 0x0000EAF9 File Offset: 0x0000CCF9
		private static IntPtr n_GetUserAgentString(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<WebSettings>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).UserAgentString);
		}

		// Token: 0x0600068F RID: 1679 RVA: 0x0000EB0D File Offset: 0x0000CD0D
		private static Delegate GetSetUserAgentString_Ljava_lang_String_Handler()
		{
			if (WebSettings.cb_setUserAgentString_Ljava_lang_String_ == null)
			{
				WebSettings.cb_setUserAgentString_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(WebSettings.n_SetUserAgentString_Ljava_lang_String_));
			}
			return WebSettings.cb_setUserAgentString_Ljava_lang_String_;
		}

		// Token: 0x06000690 RID: 1680 RVA: 0x0000EB34 File Offset: 0x0000CD34
		private static void n_SetUserAgentString_Ljava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native_ua)
		{
			WebSettings @object = Java.Lang.Object.GetObject<WebSettings>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_ua, JniHandleOwnership.DoNotTransfer);
			@object.UserAgentString = @string;
		}

		// Token: 0x17000142 RID: 322
		// (get) Token: 0x06000691 RID: 1681
		// (set) Token: 0x06000692 RID: 1682
		public abstract string UserAgentString { get; set; }

		// Token: 0x06000693 RID: 1683 RVA: 0x0000EB57 File Offset: 0x0000CD57
		private static Delegate GetSetAppCacheEnabled_ZHandler()
		{
			if (WebSettings.cb_setAppCacheEnabled_Z == null)
			{
				WebSettings.cb_setAppCacheEnabled_Z = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPZ_V(WebSettings.n_SetAppCacheEnabled_Z));
			}
			return WebSettings.cb_setAppCacheEnabled_Z;
		}

		// Token: 0x06000694 RID: 1684 RVA: 0x0000EB7B File Offset: 0x0000CD7B
		private static void n_SetAppCacheEnabled_Z(IntPtr jnienv, IntPtr native__this, bool flag)
		{
			Java.Lang.Object.GetObject<WebSettings>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SetAppCacheEnabled(flag);
		}

		// Token: 0x06000695 RID: 1685
		public abstract void SetAppCacheEnabled(bool flag);

		// Token: 0x06000696 RID: 1686 RVA: 0x0000EB8B File Offset: 0x0000CD8B
		private static Delegate GetSetPluginState_Landroid_webkit_WebSettings_PluginState_Handler()
		{
			if (WebSettings.cb_setPluginState_Landroid_webkit_WebSettings_PluginState_ == null)
			{
				WebSettings.cb_setPluginState_Landroid_webkit_WebSettings_PluginState_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(WebSettings.n_SetPluginState_Landroid_webkit_WebSettings_PluginState_));
			}
			return WebSettings.cb_setPluginState_Landroid_webkit_WebSettings_PluginState_;
		}

		// Token: 0x06000697 RID: 1687 RVA: 0x0000EBB0 File Offset: 0x0000CDB0
		private static void n_SetPluginState_Landroid_webkit_WebSettings_PluginState_(IntPtr jnienv, IntPtr native__this, IntPtr native_state)
		{
			WebSettings @object = Java.Lang.Object.GetObject<WebSettings>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			WebSettings.PluginState object2 = Java.Lang.Object.GetObject<WebSettings.PluginState>(native_state, JniHandleOwnership.DoNotTransfer);
			@object.SetPluginState(object2);
		}

		// Token: 0x06000698 RID: 1688
		public abstract void SetPluginState(WebSettings.PluginState state);

		// Token: 0x040001A6 RID: 422
		private static readonly JniPeerMembers _members = new XAPeerMembers("android/webkit/WebSettings", typeof(WebSettings));

		// Token: 0x040001A7 RID: 423
		private static Delegate cb_setCacheMode_I;

		// Token: 0x040001A8 RID: 424
		private static Delegate cb_setDomStorageEnabled_Z;

		// Token: 0x040001A9 RID: 425
		private static Delegate cb_setJavaScriptEnabled_Z;

		// Token: 0x040001AA RID: 426
		private static Delegate cb_setMediaPlaybackRequiresUserGesture_Z;

		// Token: 0x040001AB RID: 427
		private static Delegate cb_getUserAgentString;

		// Token: 0x040001AC RID: 428
		private static Delegate cb_setUserAgentString_Ljava_lang_String_;

		// Token: 0x040001AD RID: 429
		private static Delegate cb_setAppCacheEnabled_Z;

		// Token: 0x040001AE RID: 430
		private static Delegate cb_setPluginState_Landroid_webkit_WebSettings_PluginState_;

		// Token: 0x02000108 RID: 264
		[Register("android/webkit/WebSettings$PluginState", DoNotGenerateAcw = true)]
		public sealed class PluginState : Java.Lang.Enum
		{
			// Token: 0x17000143 RID: 323
			// (get) Token: 0x0600069A RID: 1690 RVA: 0x0000EBF0 File Offset: 0x0000CDF0
			[Register("ON")]
			public static WebSettings.PluginState On
			{
				get
				{
					return Java.Lang.Object.GetObject<WebSettings.PluginState>(WebSettings.PluginState._members.StaticFields.GetObjectValue("ON.Landroid/webkit/WebSettings$PluginState;").Handle, JniHandleOwnership.TransferLocalRef);
				}
			}

			// Token: 0x17000144 RID: 324
			// (get) Token: 0x0600069B RID: 1691 RVA: 0x0000EC1F File Offset: 0x0000CE1F
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return WebSettings.PluginState._members;
				}
			}

			// Token: 0x17000145 RID: 325
			// (get) Token: 0x0600069C RID: 1692 RVA: 0x0000EC28 File Offset: 0x0000CE28
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return WebSettings.PluginState._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x17000146 RID: 326
			// (get) Token: 0x0600069D RID: 1693 RVA: 0x0000EC4C File Offset: 0x0000CE4C
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return WebSettings.PluginState._members.ManagedPeerType;
				}
			}

			// Token: 0x0600069E RID: 1694 RVA: 0x00008BD0 File Offset: 0x00006DD0
			internal PluginState(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
			{
			}

			// Token: 0x040001AF RID: 431
			private static readonly JniPeerMembers _members = new XAPeerMembers("android/webkit/WebSettings$PluginState", typeof(WebSettings.PluginState));
		}
	}
}
