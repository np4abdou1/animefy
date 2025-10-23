using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.App;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Com.Applovin.Sdk
{
	// Token: 0x02000062 RID: 98
	[Register("com/applovin/sdk/AppLovinWebViewActivity", DoNotGenerateAcw = true)]
	public class AppLovinWebViewActivity : Activity
	{
		// Token: 0x17000115 RID: 277
		// (get) Token: 0x06000369 RID: 873 RVA: 0x000098F4 File Offset: 0x00007AF4
		internal static IntPtr class_ref
		{
			get
			{
				return AppLovinWebViewActivity._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000116 RID: 278
		// (get) Token: 0x0600036A RID: 874 RVA: 0x00009918 File Offset: 0x00007B18
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return AppLovinWebViewActivity._members;
			}
		}

		// Token: 0x17000117 RID: 279
		// (get) Token: 0x0600036B RID: 875 RVA: 0x00009920 File Offset: 0x00007B20
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return AppLovinWebViewActivity._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000118 RID: 280
		// (get) Token: 0x0600036C RID: 876 RVA: 0x00009944 File Offset: 0x00007B44
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return AppLovinWebViewActivity._members.ManagedPeerType;
			}
		}

		// Token: 0x0600036D RID: 877 RVA: 0x00009950 File Offset: 0x00007B50
		protected AppLovinWebViewActivity(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x0600036E RID: 878 RVA: 0x0000995C File Offset: 0x00007B5C
		[Register(".ctor", "()V", "")]
		public AppLovinWebViewActivity() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			base.SetHandle(AppLovinWebViewActivity._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
			AppLovinWebViewActivity._members.InstanceMethods.FinishCreateInstance("()V", this, null);
		}

		// Token: 0x0600036F RID: 879 RVA: 0x000099CA File Offset: 0x00007BCA
		private static Delegate GetLoadUrl_Ljava_lang_String_Lcom_applovin_sdk_AppLovinWebViewActivity_EventListener_Handler()
		{
			if (AppLovinWebViewActivity.cb_loadUrl_Ljava_lang_String_Lcom_applovin_sdk_AppLovinWebViewActivity_EventListener_ == null)
			{
				AppLovinWebViewActivity.cb_loadUrl_Ljava_lang_String_Lcom_applovin_sdk_AppLovinWebViewActivity_EventListener_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_V(AppLovinWebViewActivity.n_LoadUrl_Ljava_lang_String_Lcom_applovin_sdk_AppLovinWebViewActivity_EventListener_));
			}
			return AppLovinWebViewActivity.cb_loadUrl_Ljava_lang_String_Lcom_applovin_sdk_AppLovinWebViewActivity_EventListener_;
		}

		// Token: 0x06000370 RID: 880 RVA: 0x000099F0 File Offset: 0x00007BF0
		private static void n_LoadUrl_Ljava_lang_String_Lcom_applovin_sdk_AppLovinWebViewActivity_EventListener_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			AppLovinWebViewActivity @object = Java.Lang.Object.GetObject<AppLovinWebViewActivity>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_p0, JniHandleOwnership.DoNotTransfer);
			AppLovinWebViewActivity.IEventListener object2 = Java.Lang.Object.GetObject<AppLovinWebViewActivity.IEventListener>(native_p1, JniHandleOwnership.DoNotTransfer);
			@object.LoadUrl(@string, object2);
		}

		// Token: 0x06000371 RID: 881 RVA: 0x00009A1C File Offset: 0x00007C1C
		[Register("loadUrl", "(Ljava/lang/String;Lcom/applovin/sdk/AppLovinWebViewActivity$EventListener;)V", "GetLoadUrl_Ljava_lang_String_Lcom_applovin_sdk_AppLovinWebViewActivity_EventListener_Handler")]
		public unsafe virtual void LoadUrl(string p0, AppLovinWebViewActivity.IEventListener p1)
		{
			IntPtr intPtr = JNIEnv.NewString(p0);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((p1 == null) ? IntPtr.Zero : ((Java.Lang.Object)p1).Handle);
				AppLovinWebViewActivity._members.InstanceMethods.InvokeVirtualVoidMethod("loadUrl.(Ljava/lang/String;Lcom/applovin/sdk/AppLovinWebViewActivity$EventListener;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(p1);
			}
		}

		// Token: 0x040000CD RID: 205
		[Register("EVENT_DISMISSED_VIA_BACK_BUTTON")]
		public const string EventDismissedViaBackButton = "dismissed_via_back_button";

		// Token: 0x040000CE RID: 206
		[Register("INTENT_EXTRA_KEY_IMMERSIVE_MODE_ON")]
		public const string IntentExtraKeyImmersiveModeOn = "immersive_mode_on";

		// Token: 0x040000CF RID: 207
		[Register("INTENT_EXTRA_KEY_SDK_KEY")]
		public const string IntentExtraKeySdkKey = "sdk_key";

		// Token: 0x040000D0 RID: 208
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/applovin/sdk/AppLovinWebViewActivity", typeof(AppLovinWebViewActivity));

		// Token: 0x040000D1 RID: 209
		private static Delegate cb_loadUrl_Ljava_lang_String_Lcom_applovin_sdk_AppLovinWebViewActivity_EventListener_;

		// Token: 0x02000063 RID: 99
		[Register("com/applovin/sdk/AppLovinWebViewActivity$EventListener", "", "Com.Applovin.Sdk.AppLovinWebViewActivity/IEventListenerInvoker")]
		public interface IEventListener : IJavaObject, IDisposable, IJavaPeerable
		{
			// Token: 0x06000373 RID: 883
			[Register("onReceivedEvent", "(Ljava/lang/String;)V", "GetOnReceivedEvent_Ljava_lang_String_Handler:Com.Applovin.Sdk.AppLovinWebViewActivity/IEventListenerInvoker, AppLovin")]
			void OnReceivedEvent(string p0);
		}

		// Token: 0x02000064 RID: 100
		[Register("com/applovin/sdk/AppLovinWebViewActivity$EventListener", DoNotGenerateAcw = true)]
		internal class IEventListenerInvoker : Java.Lang.Object, AppLovinWebViewActivity.IEventListener, IJavaObject, IDisposable, IJavaPeerable
		{
			// Token: 0x17000119 RID: 281
			// (get) Token: 0x06000374 RID: 884 RVA: 0x00009AC0 File Offset: 0x00007CC0
			private static IntPtr java_class_ref
			{
				get
				{
					return AppLovinWebViewActivity.IEventListenerInvoker._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x1700011A RID: 282
			// (get) Token: 0x06000375 RID: 885 RVA: 0x00009AE4 File Offset: 0x00007CE4
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return AppLovinWebViewActivity.IEventListenerInvoker._members;
				}
			}

			// Token: 0x1700011B RID: 283
			// (get) Token: 0x06000376 RID: 886 RVA: 0x00009AEB File Offset: 0x00007CEB
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return this.class_ref;
				}
			}

			// Token: 0x1700011C RID: 284
			// (get) Token: 0x06000377 RID: 887 RVA: 0x00009AF3 File Offset: 0x00007CF3
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return AppLovinWebViewActivity.IEventListenerInvoker._members.ManagedPeerType;
				}
			}

			// Token: 0x06000378 RID: 888 RVA: 0x00009AFF File Offset: 0x00007CFF
			public static AppLovinWebViewActivity.IEventListener GetObject(IntPtr handle, JniHandleOwnership transfer)
			{
				return Java.Lang.Object.GetObject<AppLovinWebViewActivity.IEventListener>(handle, transfer);
			}

			// Token: 0x06000379 RID: 889 RVA: 0x00009B08 File Offset: 0x00007D08
			private static IntPtr Validate(IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf(handle, AppLovinWebViewActivity.IEventListenerInvoker.java_class_ref))
				{
					throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'com.applovin.sdk.AppLovinWebViewActivity.EventListener'.");
				}
				return handle;
			}

			// Token: 0x0600037A RID: 890 RVA: 0x00009B33 File Offset: 0x00007D33
			protected override void Dispose(bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
				{
					JNIEnv.DeleteGlobalRef(this.class_ref);
				}
				this.class_ref = IntPtr.Zero;
				base.Dispose(disposing);
			}

			// Token: 0x0600037B RID: 891 RVA: 0x00009B64 File Offset: 0x00007D64
			public IEventListenerInvoker(IntPtr handle, JniHandleOwnership transfer) : base(AppLovinWebViewActivity.IEventListenerInvoker.Validate(handle), transfer)
			{
				IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
				this.class_ref = JNIEnv.NewGlobalRef(objectClass);
				JNIEnv.DeleteLocalRef(objectClass);
			}

			// Token: 0x0600037C RID: 892 RVA: 0x00009B9C File Offset: 0x00007D9C
			private static Delegate GetOnReceivedEvent_Ljava_lang_String_Handler()
			{
				if (AppLovinWebViewActivity.IEventListenerInvoker.cb_onReceivedEvent_Ljava_lang_String_ == null)
				{
					AppLovinWebViewActivity.IEventListenerInvoker.cb_onReceivedEvent_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(AppLovinWebViewActivity.IEventListenerInvoker.n_OnReceivedEvent_Ljava_lang_String_));
				}
				return AppLovinWebViewActivity.IEventListenerInvoker.cb_onReceivedEvent_Ljava_lang_String_;
			}

			// Token: 0x0600037D RID: 893 RVA: 0x00009BC0 File Offset: 0x00007DC0
			private static void n_OnReceivedEvent_Ljava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				AppLovinWebViewActivity.IEventListener @object = Java.Lang.Object.GetObject<AppLovinWebViewActivity.IEventListener>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string @string = JNIEnv.GetString(native_p0, JniHandleOwnership.DoNotTransfer);
				@object.OnReceivedEvent(@string);
			}

			// Token: 0x0600037E RID: 894 RVA: 0x00009BE4 File Offset: 0x00007DE4
			public unsafe void OnReceivedEvent(string p0)
			{
				if (this.id_onReceivedEvent_Ljava_lang_String_ == IntPtr.Zero)
				{
					this.id_onReceivedEvent_Ljava_lang_String_ = JNIEnv.GetMethodID(this.class_ref, "onReceivedEvent", "(Ljava/lang/String;)V");
				}
				IntPtr intPtr = JNIEnv.NewString(p0);
				JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
				*ptr = new JValue(intPtr);
				JNIEnv.CallVoidMethod(base.Handle, this.id_onReceivedEvent_Ljava_lang_String_, ptr);
				JNIEnv.DeleteLocalRef(intPtr);
			}

			// Token: 0x040000D2 RID: 210
			private static readonly JniPeerMembers _members = new XAPeerMembers("com/applovin/sdk/AppLovinWebViewActivity$EventListener", typeof(AppLovinWebViewActivity.IEventListenerInvoker));

			// Token: 0x040000D3 RID: 211
			private IntPtr class_ref;

			// Token: 0x040000D4 RID: 212
			private static Delegate cb_onReceivedEvent_Ljava_lang_String_;

			// Token: 0x040000D5 RID: 213
			private IntPtr id_onReceivedEvent_Ljava_lang_String_;
		}

		// Token: 0x02000065 RID: 101
		public class EventEventArgs : EventArgs
		{
			// Token: 0x06000380 RID: 896 RVA: 0x00009C70 File Offset: 0x00007E70
			public EventEventArgs(string p0)
			{
				this.p0 = p0;
			}

			// Token: 0x1700011D RID: 285
			// (get) Token: 0x06000381 RID: 897 RVA: 0x00009C7F File Offset: 0x00007E7F
			public string P0
			{
				get
				{
					return this.p0;
				}
			}

			// Token: 0x040000D6 RID: 214
			private string p0;
		}

		// Token: 0x02000066 RID: 102
		[Register("mono/com/applovin/sdk/AppLovinWebViewActivity_EventListenerImplementor")]
		internal sealed class IEventListenerImplementor : Java.Lang.Object, AppLovinWebViewActivity.IEventListener, IJavaObject, IDisposable, IJavaPeerable
		{
			// Token: 0x06000382 RID: 898 RVA: 0x00009C87 File Offset: 0x00007E87
			public IEventListenerImplementor(object sender) : base(JNIEnv.StartCreateInstance("mono/com/applovin/sdk/AppLovinWebViewActivity_EventListenerImplementor", "()V", Array.Empty<JValue>()), JniHandleOwnership.TransferLocalRef)
			{
				JNIEnv.FinishCreateInstance(base.Handle, "()V", Array.Empty<JValue>());
				this.sender = sender;
			}

			// Token: 0x06000383 RID: 899 RVA: 0x00009CC0 File Offset: 0x00007EC0
			public void OnReceivedEvent(string p0)
			{
				EventHandler<AppLovinWebViewActivity.EventEventArgs> handler = this.Handler;
				if (handler != null)
				{
					handler(this.sender, new AppLovinWebViewActivity.EventEventArgs(p0));
				}
			}

			// Token: 0x06000384 RID: 900 RVA: 0x00009CE9 File Offset: 0x00007EE9
			internal static bool __IsEmpty(AppLovinWebViewActivity.IEventListenerImplementor value)
			{
				return value.Handler == null;
			}

			// Token: 0x040000D7 RID: 215
			private object sender;

			// Token: 0x040000D8 RID: 216
			public EventHandler<AppLovinWebViewActivity.EventEventArgs> Handler;
		}
	}
}
