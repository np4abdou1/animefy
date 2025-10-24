using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Android.Gms.Tasks
{
	// Token: 0x02000016 RID: 22
	[Register("com/google/android/gms/tasks/OnSuccessListener", DoNotGenerateAcw = true)]
	internal class IOnSuccessListenerInvoker : Java.Lang.Object, IOnSuccessListener, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000028 RID: 40
		// (get) Token: 0x060000CD RID: 205 RVA: 0x00003CE0 File Offset: 0x00001EE0
		private static IntPtr java_class_ref
		{
			get
			{
				return IOnSuccessListenerInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x060000CE RID: 206 RVA: 0x00003D04 File Offset: 0x00001F04
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IOnSuccessListenerInvoker._members;
			}
		}

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x060000CF RID: 207 RVA: 0x00003D0B File Offset: 0x00001F0B
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x060000D0 RID: 208 RVA: 0x00003D13 File Offset: 0x00001F13
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IOnSuccessListenerInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x060000D1 RID: 209 RVA: 0x00003D1F File Offset: 0x00001F1F
		public static IOnSuccessListener GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IOnSuccessListener>(handle, transfer);
		}

		// Token: 0x060000D2 RID: 210 RVA: 0x00003D28 File Offset: 0x00001F28
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IOnSuccessListenerInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'com.google.android.gms.tasks.OnSuccessListener'.");
			}
			return handle;
		}

		// Token: 0x060000D3 RID: 211 RVA: 0x00003D53 File Offset: 0x00001F53
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x060000D4 RID: 212 RVA: 0x00003D84 File Offset: 0x00001F84
		public IOnSuccessListenerInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IOnSuccessListenerInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x060000D5 RID: 213 RVA: 0x00003DBC File Offset: 0x00001FBC
		private static Delegate GetOnSuccess_Ljava_lang_Object_Handler()
		{
			if (IOnSuccessListenerInvoker.cb_onSuccess_Ljava_lang_Object_ == null)
			{
				IOnSuccessListenerInvoker.cb_onSuccess_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(IOnSuccessListenerInvoker.n_OnSuccess_Ljava_lang_Object_));
			}
			return IOnSuccessListenerInvoker.cb_onSuccess_Ljava_lang_Object_;
		}

		// Token: 0x060000D6 RID: 214 RVA: 0x00003DE0 File Offset: 0x00001FE0
		private static void n_OnSuccess_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_result)
		{
			IOnSuccessListener @object = Java.Lang.Object.GetObject<IOnSuccessListener>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_result, JniHandleOwnership.DoNotTransfer);
			@object.OnSuccess(object2);
		}

		// Token: 0x060000D7 RID: 215 RVA: 0x00003E04 File Offset: 0x00002004
		public unsafe void OnSuccess(Java.Lang.Object result)
		{
			if (this.id_onSuccess_Ljava_lang_Object_ == IntPtr.Zero)
			{
				this.id_onSuccess_Ljava_lang_Object_ = JNIEnv.GetMethodID(this.class_ref, "onSuccess", "(Ljava/lang/Object;)V");
			}
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(result);
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(intPtr);
			JNIEnv.CallVoidMethod(base.Handle, this.id_onSuccess_Ljava_lang_Object_, ptr);
			JNIEnv.DeleteLocalRef(intPtr);
		}

		// Token: 0x04000034 RID: 52
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/google/android/gms/tasks/OnSuccessListener", typeof(IOnSuccessListenerInvoker));

		// Token: 0x04000035 RID: 53
		private IntPtr class_ref;

		// Token: 0x04000036 RID: 54
		private static Delegate cb_onSuccess_Ljava_lang_Object_;

		// Token: 0x04000037 RID: 55
		private IntPtr id_onSuccess_Ljava_lang_Object_;
	}
}
