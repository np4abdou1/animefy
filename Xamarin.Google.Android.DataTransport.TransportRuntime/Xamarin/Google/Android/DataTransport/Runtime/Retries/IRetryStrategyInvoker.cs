using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Xamarin.Google.Android.DataTransport.Runtime.Retries
{
	// Token: 0x02000064 RID: 100
	[Register("com/google/android/datatransport/runtime/retries/RetryStrategy", DoNotGenerateAcw = true)]
	internal class IRetryStrategyInvoker : Java.Lang.Object, IRetryStrategy, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000102 RID: 258
		// (get) Token: 0x06000343 RID: 835 RVA: 0x0000A7F8 File Offset: 0x000089F8
		private static IntPtr java_class_ref
		{
			get
			{
				return IRetryStrategyInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000103 RID: 259
		// (get) Token: 0x06000344 RID: 836 RVA: 0x0000A81C File Offset: 0x00008A1C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IRetryStrategyInvoker._members;
			}
		}

		// Token: 0x17000104 RID: 260
		// (get) Token: 0x06000345 RID: 837 RVA: 0x0000A823 File Offset: 0x00008A23
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x17000105 RID: 261
		// (get) Token: 0x06000346 RID: 838 RVA: 0x0000A82B File Offset: 0x00008A2B
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IRetryStrategyInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06000347 RID: 839 RVA: 0x0000A837 File Offset: 0x00008A37
		public static IRetryStrategy GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IRetryStrategy>(handle, transfer);
		}

		// Token: 0x06000348 RID: 840 RVA: 0x0000A840 File Offset: 0x00008A40
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IRetryStrategyInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'com.google.android.datatransport.runtime.retries.RetryStrategy'.");
			}
			return handle;
		}

		// Token: 0x06000349 RID: 841 RVA: 0x0000A86B File Offset: 0x00008A6B
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x0600034A RID: 842 RVA: 0x0000A89C File Offset: 0x00008A9C
		public IRetryStrategyInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IRetryStrategyInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x0600034B RID: 843 RVA: 0x0000A8D4 File Offset: 0x00008AD4
		private static Delegate GetShouldRetry_Ljava_lang_Object_Ljava_lang_Object_Handler()
		{
			if (IRetryStrategyInvoker.cb_shouldRetry_Ljava_lang_Object_Ljava_lang_Object_ == null)
			{
				IRetryStrategyInvoker.cb_shouldRetry_Ljava_lang_Object_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_L(IRetryStrategyInvoker.n_ShouldRetry_Ljava_lang_Object_Ljava_lang_Object_));
			}
			return IRetryStrategyInvoker.cb_shouldRetry_Ljava_lang_Object_Ljava_lang_Object_;
		}

		// Token: 0x0600034C RID: 844 RVA: 0x0000A8F8 File Offset: 0x00008AF8
		private static IntPtr n_ShouldRetry_Ljava_lang_Object_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			IRetryStrategy @object = Java.Lang.Object.GetObject<IRetryStrategy>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_p0, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object3 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_p1, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.ShouldRetry(object2, object3));
		}

		// Token: 0x0600034D RID: 845 RVA: 0x0000A92C File Offset: 0x00008B2C
		public unsafe Java.Lang.Object ShouldRetry(Java.Lang.Object p0, Java.Lang.Object p1)
		{
			if (this.id_shouldRetry_Ljava_lang_Object_Ljava_lang_Object_ == IntPtr.Zero)
			{
				this.id_shouldRetry_Ljava_lang_Object_Ljava_lang_Object_ = JNIEnv.GetMethodID(this.class_ref, "shouldRetry", "(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;");
			}
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(p0);
			IntPtr intPtr2 = JNIEnv.ToLocalJniHandle(p1);
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(intPtr);
			ptr[1] = new JValue(intPtr2);
			Java.Lang.Object @object = Java.Lang.Object.GetObject<Java.Lang.Object>(JNIEnv.CallObjectMethod(base.Handle, this.id_shouldRetry_Ljava_lang_Object_Ljava_lang_Object_, ptr), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef(intPtr);
			JNIEnv.DeleteLocalRef(intPtr2);
			return @object;
		}

		// Token: 0x040000B9 RID: 185
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/google/android/datatransport/runtime/retries/RetryStrategy", typeof(IRetryStrategyInvoker));

		// Token: 0x040000BA RID: 186
		private IntPtr class_ref;

		// Token: 0x040000BB RID: 187
		private static Delegate cb_shouldRetry_Ljava_lang_Object_Ljava_lang_Object_;

		// Token: 0x040000BC RID: 188
		private IntPtr id_shouldRetry_Ljava_lang_Object_Ljava_lang_Object_;
	}
}
