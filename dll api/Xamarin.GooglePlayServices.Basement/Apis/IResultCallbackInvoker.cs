using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Android.Gms.Common.Apis
{
	// Token: 0x0200001D RID: 29
	[Register("com/google/android/gms/common/api/ResultCallback", DoNotGenerateAcw = true)]
	internal class IResultCallbackInvoker : Java.Lang.Object, IResultCallback, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x1700002F RID: 47
		// (get) Token: 0x060000AC RID: 172 RVA: 0x00003420 File Offset: 0x00001620
		private static IntPtr java_class_ref
		{
			get
			{
				return IResultCallbackInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000030 RID: 48
		// (get) Token: 0x060000AD RID: 173 RVA: 0x00003444 File Offset: 0x00001644
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IResultCallbackInvoker._members;
			}
		}

		// Token: 0x17000031 RID: 49
		// (get) Token: 0x060000AE RID: 174 RVA: 0x0000344B File Offset: 0x0000164B
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x17000032 RID: 50
		// (get) Token: 0x060000AF RID: 175 RVA: 0x00003453 File Offset: 0x00001653
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IResultCallbackInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x060000B0 RID: 176 RVA: 0x0000345F File Offset: 0x0000165F
		public static IResultCallback GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IResultCallback>(handle, transfer);
		}

		// Token: 0x060000B1 RID: 177 RVA: 0x00003468 File Offset: 0x00001668
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IResultCallbackInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'com.google.android.gms.common.api.ResultCallback'.");
			}
			return handle;
		}

		// Token: 0x060000B2 RID: 178 RVA: 0x00003493 File Offset: 0x00001693
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x060000B3 RID: 179 RVA: 0x000034C4 File Offset: 0x000016C4
		public IResultCallbackInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IResultCallbackInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x060000B4 RID: 180 RVA: 0x000034FC File Offset: 0x000016FC
		private static Delegate GetOnResult_Lcom_google_android_gms_common_api_Result_Handler()
		{
			if (IResultCallbackInvoker.cb_onResult_Lcom_google_android_gms_common_api_Result_ == null)
			{
				IResultCallbackInvoker.cb_onResult_Lcom_google_android_gms_common_api_Result_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(IResultCallbackInvoker.n_OnResult_Lcom_google_android_gms_common_api_Result_));
			}
			return IResultCallbackInvoker.cb_onResult_Lcom_google_android_gms_common_api_Result_;
		}

		// Token: 0x060000B5 RID: 181 RVA: 0x00003520 File Offset: 0x00001720
		private static void n_OnResult_Lcom_google_android_gms_common_api_Result_(IntPtr jnienv, IntPtr native__this, IntPtr native_result)
		{
			IResultCallback @object = Java.Lang.Object.GetObject<IResultCallback>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_result, JniHandleOwnership.DoNotTransfer);
			@object.OnResult(object2);
		}

		// Token: 0x060000B6 RID: 182 RVA: 0x00003544 File Offset: 0x00001744
		public unsafe void OnResult(Java.Lang.Object result)
		{
			if (this.id_onResult_Lcom_google_android_gms_common_api_Result_ == IntPtr.Zero)
			{
				this.id_onResult_Lcom_google_android_gms_common_api_Result_ = JNIEnv.GetMethodID(this.class_ref, "onResult", "(Lcom/google/android/gms/common/api/Result;)V");
			}
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(result);
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(intPtr);
			JNIEnv.CallVoidMethod(base.Handle, this.id_onResult_Lcom_google_android_gms_common_api_Result_, ptr);
			JNIEnv.DeleteLocalRef(intPtr);
		}

		// Token: 0x04000020 RID: 32
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/google/android/gms/common/api/ResultCallback", typeof(IResultCallbackInvoker));

		// Token: 0x04000021 RID: 33
		private IntPtr class_ref;

		// Token: 0x04000022 RID: 34
		private static Delegate cb_onResult_Lcom_google_android_gms_common_api_Result_;

		// Token: 0x04000023 RID: 35
		private IntPtr id_onResult_Lcom_google_android_gms_common_api_Result_;
	}
}
