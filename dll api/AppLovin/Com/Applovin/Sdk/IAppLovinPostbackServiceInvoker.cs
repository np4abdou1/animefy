using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Com.Applovin.Sdk
{
	// Token: 0x0200008D RID: 141
	[Register("com/applovin/sdk/AppLovinPostbackService", DoNotGenerateAcw = true)]
	internal class IAppLovinPostbackServiceInvoker : Java.Lang.Object, IAppLovinPostbackService, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000164 RID: 356
		// (get) Token: 0x0600048D RID: 1165 RVA: 0x0000C2F0 File Offset: 0x0000A4F0
		private static IntPtr java_class_ref
		{
			get
			{
				return IAppLovinPostbackServiceInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000165 RID: 357
		// (get) Token: 0x0600048E RID: 1166 RVA: 0x0000C314 File Offset: 0x0000A514
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IAppLovinPostbackServiceInvoker._members;
			}
		}

		// Token: 0x17000166 RID: 358
		// (get) Token: 0x0600048F RID: 1167 RVA: 0x0000C31B File Offset: 0x0000A51B
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x17000167 RID: 359
		// (get) Token: 0x06000490 RID: 1168 RVA: 0x0000C323 File Offset: 0x0000A523
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IAppLovinPostbackServiceInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06000491 RID: 1169 RVA: 0x0000C32F File Offset: 0x0000A52F
		public static IAppLovinPostbackService GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IAppLovinPostbackService>(handle, transfer);
		}

		// Token: 0x06000492 RID: 1170 RVA: 0x0000C338 File Offset: 0x0000A538
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IAppLovinPostbackServiceInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'com.applovin.sdk.AppLovinPostbackService'.");
			}
			return handle;
		}

		// Token: 0x06000493 RID: 1171 RVA: 0x0000C363 File Offset: 0x0000A563
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x06000494 RID: 1172 RVA: 0x0000C394 File Offset: 0x0000A594
		public IAppLovinPostbackServiceInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IAppLovinPostbackServiceInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x06000495 RID: 1173 RVA: 0x0000C3CC File Offset: 0x0000A5CC
		private static Delegate GetDispatchPostbackAsync_Ljava_lang_String_Lcom_applovin_sdk_AppLovinPostbackListener_Handler()
		{
			if (IAppLovinPostbackServiceInvoker.cb_dispatchPostbackAsync_Ljava_lang_String_Lcom_applovin_sdk_AppLovinPostbackListener_ == null)
			{
				IAppLovinPostbackServiceInvoker.cb_dispatchPostbackAsync_Ljava_lang_String_Lcom_applovin_sdk_AppLovinPostbackListener_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_V(IAppLovinPostbackServiceInvoker.n_DispatchPostbackAsync_Ljava_lang_String_Lcom_applovin_sdk_AppLovinPostbackListener_));
			}
			return IAppLovinPostbackServiceInvoker.cb_dispatchPostbackAsync_Ljava_lang_String_Lcom_applovin_sdk_AppLovinPostbackListener_;
		}

		// Token: 0x06000496 RID: 1174 RVA: 0x0000C3F0 File Offset: 0x0000A5F0
		private static void n_DispatchPostbackAsync_Ljava_lang_String_Lcom_applovin_sdk_AppLovinPostbackListener_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			IAppLovinPostbackService @object = Java.Lang.Object.GetObject<IAppLovinPostbackService>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_p0, JniHandleOwnership.DoNotTransfer);
			IAppLovinPostbackListener object2 = Java.Lang.Object.GetObject<IAppLovinPostbackListener>(native_p1, JniHandleOwnership.DoNotTransfer);
			@object.DispatchPostbackAsync(@string, object2);
		}

		// Token: 0x06000497 RID: 1175 RVA: 0x0000C41C File Offset: 0x0000A61C
		public unsafe void DispatchPostbackAsync(string p0, IAppLovinPostbackListener p1)
		{
			if (this.id_dispatchPostbackAsync_Ljava_lang_String_Lcom_applovin_sdk_AppLovinPostbackListener_ == IntPtr.Zero)
			{
				this.id_dispatchPostbackAsync_Ljava_lang_String_Lcom_applovin_sdk_AppLovinPostbackListener_ = JNIEnv.GetMethodID(this.class_ref, "dispatchPostbackAsync", "(Ljava/lang/String;Lcom/applovin/sdk/AppLovinPostbackListener;)V");
			}
			IntPtr intPtr = JNIEnv.NewString(p0);
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(intPtr);
			ptr[1] = new JValue((p1 == null) ? IntPtr.Zero : ((Java.Lang.Object)p1).Handle);
			JNIEnv.CallVoidMethod(base.Handle, this.id_dispatchPostbackAsync_Ljava_lang_String_Lcom_applovin_sdk_AppLovinPostbackListener_, ptr);
			JNIEnv.DeleteLocalRef(intPtr);
		}

		// Token: 0x04000150 RID: 336
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/applovin/sdk/AppLovinPostbackService", typeof(IAppLovinPostbackServiceInvoker));

		// Token: 0x04000151 RID: 337
		private IntPtr class_ref;

		// Token: 0x04000152 RID: 338
		private static Delegate cb_dispatchPostbackAsync_Ljava_lang_String_Lcom_applovin_sdk_AppLovinPostbackListener_;

		// Token: 0x04000153 RID: 339
		private IntPtr id_dispatchPostbackAsync_Ljava_lang_String_Lcom_applovin_sdk_AppLovinPostbackListener_;
	}
}
