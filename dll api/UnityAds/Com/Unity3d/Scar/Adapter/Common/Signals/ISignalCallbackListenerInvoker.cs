using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Com.Unity3d.Scar.Adapter.Common.Signals
{
	// Token: 0x020002AB RID: 683
	[Register("com/unity3d/scar/adapter/common/signals/ISignalCallbackListener", DoNotGenerateAcw = true)]
	internal class ISignalCallbackListenerInvoker : Java.Lang.Object, ISignalCallbackListener, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000ED3 RID: 3795
		// (get) Token: 0x0600270A RID: 9994 RVA: 0x00064A60 File Offset: 0x00062C60
		private static IntPtr java_class_ref
		{
			get
			{
				return ISignalCallbackListenerInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000ED4 RID: 3796
		// (get) Token: 0x0600270B RID: 9995 RVA: 0x00064A84 File Offset: 0x00062C84
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return ISignalCallbackListenerInvoker._members;
			}
		}

		// Token: 0x17000ED5 RID: 3797
		// (get) Token: 0x0600270C RID: 9996 RVA: 0x00064A8B File Offset: 0x00062C8B
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x17000ED6 RID: 3798
		// (get) Token: 0x0600270D RID: 9997 RVA: 0x00064A93 File Offset: 0x00062C93
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return ISignalCallbackListenerInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x0600270E RID: 9998 RVA: 0x00064A9F File Offset: 0x00062C9F
		public static ISignalCallbackListener GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<ISignalCallbackListener>(handle, transfer);
		}

		// Token: 0x0600270F RID: 9999 RVA: 0x00064AA8 File Offset: 0x00062CA8
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, ISignalCallbackListenerInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'com.unity3d.scar.adapter.common.signals.ISignalCallbackListener'.");
			}
			return handle;
		}

		// Token: 0x06002710 RID: 10000 RVA: 0x00064AD3 File Offset: 0x00062CD3
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x06002711 RID: 10001 RVA: 0x00064B04 File Offset: 0x00062D04
		public ISignalCallbackListenerInvoker(IntPtr handle, JniHandleOwnership transfer) : base(ISignalCallbackListenerInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x06002712 RID: 10002 RVA: 0x00064B3C File Offset: 0x00062D3C
		private static Delegate GetOnFailure_Ljava_lang_String_Handler()
		{
			if (ISignalCallbackListenerInvoker.cb_onFailure_Ljava_lang_String_ == null)
			{
				ISignalCallbackListenerInvoker.cb_onFailure_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(ISignalCallbackListenerInvoker.n_OnFailure_Ljava_lang_String_));
			}
			return ISignalCallbackListenerInvoker.cb_onFailure_Ljava_lang_String_;
		}

		// Token: 0x06002713 RID: 10003 RVA: 0x00064B60 File Offset: 0x00062D60
		private static void n_OnFailure_Ljava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			ISignalCallbackListener @object = Java.Lang.Object.GetObject<ISignalCallbackListener>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_p0, JniHandleOwnership.DoNotTransfer);
			@object.OnFailure(@string);
		}

		// Token: 0x06002714 RID: 10004 RVA: 0x00064B84 File Offset: 0x00062D84
		public unsafe void OnFailure(string p0)
		{
			if (this.id_onFailure_Ljava_lang_String_ == IntPtr.Zero)
			{
				this.id_onFailure_Ljava_lang_String_ = JNIEnv.GetMethodID(this.class_ref, "onFailure", "(Ljava/lang/String;)V");
			}
			IntPtr intPtr = JNIEnv.NewString(p0);
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(intPtr);
			JNIEnv.CallVoidMethod(base.Handle, this.id_onFailure_Ljava_lang_String_, ptr);
			JNIEnv.DeleteLocalRef(intPtr);
		}

		// Token: 0x06002715 RID: 10005 RVA: 0x00064BF5 File Offset: 0x00062DF5
		private static Delegate GetOnSuccess_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Object_Handler()
		{
			if (ISignalCallbackListenerInvoker.cb_onSuccess_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Object_ == null)
			{
				ISignalCallbackListenerInvoker.cb_onSuccess_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLLL_V(ISignalCallbackListenerInvoker.n_OnSuccess_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Object_));
			}
			return ISignalCallbackListenerInvoker.cb_onSuccess_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Object_;
		}

		// Token: 0x06002716 RID: 10006 RVA: 0x00064C1C File Offset: 0x00062E1C
		private static void n_OnSuccess_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			ISignalCallbackListener @object = Java.Lang.Object.GetObject<ISignalCallbackListener>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_p0, JniHandleOwnership.DoNotTransfer);
			string string2 = JNIEnv.GetString(native_p1, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_p2, JniHandleOwnership.DoNotTransfer);
			@object.OnSuccess(@string, string2, object2);
		}

		// Token: 0x06002717 RID: 10007 RVA: 0x00064C54 File Offset: 0x00062E54
		public unsafe void OnSuccess(string p0, string p1, Java.Lang.Object p2)
		{
			if (this.id_onSuccess_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Object_ == IntPtr.Zero)
			{
				this.id_onSuccess_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Object_ = JNIEnv.GetMethodID(this.class_ref, "onSuccess", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/Object;)V");
			}
			IntPtr intPtr = JNIEnv.NewString(p0);
			IntPtr intPtr2 = JNIEnv.NewString(p1);
			IntPtr intPtr3 = JNIEnv.ToLocalJniHandle(p2);
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(intPtr);
			ptr[1] = new JValue(intPtr2);
			ptr[2] = new JValue(intPtr3);
			JNIEnv.CallVoidMethod(base.Handle, this.id_onSuccess_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Object_, ptr);
			JNIEnv.DeleteLocalRef(intPtr);
			JNIEnv.DeleteLocalRef(intPtr2);
			JNIEnv.DeleteLocalRef(intPtr3);
		}

		// Token: 0x040007BC RID: 1980
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/scar/adapter/common/signals/ISignalCallbackListener", typeof(ISignalCallbackListenerInvoker));

		// Token: 0x040007BD RID: 1981
		private IntPtr class_ref;

		// Token: 0x040007BE RID: 1982
		private static Delegate cb_onFailure_Ljava_lang_String_;

		// Token: 0x040007BF RID: 1983
		private IntPtr id_onFailure_Ljava_lang_String_;

		// Token: 0x040007C0 RID: 1984
		private static Delegate cb_onSuccess_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Object_;

		// Token: 0x040007C1 RID: 1985
		private IntPtr id_onSuccess_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Object_;
	}
}
