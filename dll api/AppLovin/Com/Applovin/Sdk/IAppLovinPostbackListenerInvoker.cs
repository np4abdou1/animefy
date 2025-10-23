using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Com.Applovin.Sdk
{
	// Token: 0x02000088 RID: 136
	[Register("com/applovin/sdk/AppLovinPostbackListener", DoNotGenerateAcw = true)]
	internal class IAppLovinPostbackListenerInvoker : Java.Lang.Object, IAppLovinPostbackListener, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x1700015D RID: 349
		// (get) Token: 0x06000474 RID: 1140 RVA: 0x0000BF90 File Offset: 0x0000A190
		private static IntPtr java_class_ref
		{
			get
			{
				return IAppLovinPostbackListenerInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700015E RID: 350
		// (get) Token: 0x06000475 RID: 1141 RVA: 0x0000BFB4 File Offset: 0x0000A1B4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IAppLovinPostbackListenerInvoker._members;
			}
		}

		// Token: 0x1700015F RID: 351
		// (get) Token: 0x06000476 RID: 1142 RVA: 0x0000BFBB File Offset: 0x0000A1BB
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x17000160 RID: 352
		// (get) Token: 0x06000477 RID: 1143 RVA: 0x0000BFC3 File Offset: 0x0000A1C3
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IAppLovinPostbackListenerInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06000478 RID: 1144 RVA: 0x0000BFCF File Offset: 0x0000A1CF
		public static IAppLovinPostbackListener GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IAppLovinPostbackListener>(handle, transfer);
		}

		// Token: 0x06000479 RID: 1145 RVA: 0x0000BFD8 File Offset: 0x0000A1D8
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IAppLovinPostbackListenerInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'com.applovin.sdk.AppLovinPostbackListener'.");
			}
			return handle;
		}

		// Token: 0x0600047A RID: 1146 RVA: 0x0000C003 File Offset: 0x0000A203
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x0600047B RID: 1147 RVA: 0x0000C034 File Offset: 0x0000A234
		public IAppLovinPostbackListenerInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IAppLovinPostbackListenerInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x0600047C RID: 1148 RVA: 0x0000C06C File Offset: 0x0000A26C
		private static Delegate GetOnPostbackFailure_Ljava_lang_String_IHandler()
		{
			if (IAppLovinPostbackListenerInvoker.cb_onPostbackFailure_Ljava_lang_String_I == null)
			{
				IAppLovinPostbackListenerInvoker.cb_onPostbackFailure_Ljava_lang_String_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLI_V(IAppLovinPostbackListenerInvoker.n_OnPostbackFailure_Ljava_lang_String_I));
			}
			return IAppLovinPostbackListenerInvoker.cb_onPostbackFailure_Ljava_lang_String_I;
		}

		// Token: 0x0600047D RID: 1149 RVA: 0x0000C090 File Offset: 0x0000A290
		private static void n_OnPostbackFailure_Ljava_lang_String_I(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
		{
			IAppLovinPostbackListener @object = Java.Lang.Object.GetObject<IAppLovinPostbackListener>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_p0, JniHandleOwnership.DoNotTransfer);
			@object.OnPostbackFailure(@string, p1);
		}

		// Token: 0x0600047E RID: 1150 RVA: 0x0000C0B4 File Offset: 0x0000A2B4
		public unsafe void OnPostbackFailure(string p0, int p1)
		{
			if (this.id_onPostbackFailure_Ljava_lang_String_I == IntPtr.Zero)
			{
				this.id_onPostbackFailure_Ljava_lang_String_I = JNIEnv.GetMethodID(this.class_ref, "onPostbackFailure", "(Ljava/lang/String;I)V");
			}
			IntPtr intPtr = JNIEnv.NewString(p0);
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(intPtr);
			ptr[1] = new JValue(p1);
			JNIEnv.CallVoidMethod(base.Handle, this.id_onPostbackFailure_Ljava_lang_String_I, ptr);
			JNIEnv.DeleteLocalRef(intPtr);
		}

		// Token: 0x0600047F RID: 1151 RVA: 0x0000C138 File Offset: 0x0000A338
		private static Delegate GetOnPostbackSuccess_Ljava_lang_String_Handler()
		{
			if (IAppLovinPostbackListenerInvoker.cb_onPostbackSuccess_Ljava_lang_String_ == null)
			{
				IAppLovinPostbackListenerInvoker.cb_onPostbackSuccess_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(IAppLovinPostbackListenerInvoker.n_OnPostbackSuccess_Ljava_lang_String_));
			}
			return IAppLovinPostbackListenerInvoker.cb_onPostbackSuccess_Ljava_lang_String_;
		}

		// Token: 0x06000480 RID: 1152 RVA: 0x0000C15C File Offset: 0x0000A35C
		private static void n_OnPostbackSuccess_Ljava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			IAppLovinPostbackListener @object = Java.Lang.Object.GetObject<IAppLovinPostbackListener>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_p0, JniHandleOwnership.DoNotTransfer);
			@object.OnPostbackSuccess(@string);
		}

		// Token: 0x06000481 RID: 1153 RVA: 0x0000C180 File Offset: 0x0000A380
		public unsafe void OnPostbackSuccess(string p0)
		{
			if (this.id_onPostbackSuccess_Ljava_lang_String_ == IntPtr.Zero)
			{
				this.id_onPostbackSuccess_Ljava_lang_String_ = JNIEnv.GetMethodID(this.class_ref, "onPostbackSuccess", "(Ljava/lang/String;)V");
			}
			IntPtr intPtr = JNIEnv.NewString(p0);
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(intPtr);
			JNIEnv.CallVoidMethod(base.Handle, this.id_onPostbackSuccess_Ljava_lang_String_, ptr);
			JNIEnv.DeleteLocalRef(intPtr);
		}

		// Token: 0x04000144 RID: 324
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/applovin/sdk/AppLovinPostbackListener", typeof(IAppLovinPostbackListenerInvoker));

		// Token: 0x04000145 RID: 325
		private IntPtr class_ref;

		// Token: 0x04000146 RID: 326
		private static Delegate cb_onPostbackFailure_Ljava_lang_String_I;

		// Token: 0x04000147 RID: 327
		private IntPtr id_onPostbackFailure_Ljava_lang_String_I;

		// Token: 0x04000148 RID: 328
		private static Delegate cb_onPostbackSuccess_Ljava_lang_String_;

		// Token: 0x04000149 RID: 329
		private IntPtr id_onPostbackSuccess_Ljava_lang_String_;
	}
}
