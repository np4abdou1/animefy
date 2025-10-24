using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Android.Gms.Common.Apis.Internal
{
	// Token: 0x02000025 RID: 37
	[Register("com/google/android/gms/common/api/internal/StatusExceptionMapper", DoNotGenerateAcw = true)]
	internal class IStatusExceptionMapperInvoker : Java.Lang.Object, IStatusExceptionMapper, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x1700005E RID: 94
		// (get) Token: 0x06000116 RID: 278 RVA: 0x000047BC File Offset: 0x000029BC
		private static IntPtr java_class_ref
		{
			get
			{
				return IStatusExceptionMapperInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700005F RID: 95
		// (get) Token: 0x06000117 RID: 279 RVA: 0x000047E0 File Offset: 0x000029E0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IStatusExceptionMapperInvoker._members;
			}
		}

		// Token: 0x17000060 RID: 96
		// (get) Token: 0x06000118 RID: 280 RVA: 0x000047E7 File Offset: 0x000029E7
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x17000061 RID: 97
		// (get) Token: 0x06000119 RID: 281 RVA: 0x000047EF File Offset: 0x000029EF
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IStatusExceptionMapperInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x0600011A RID: 282 RVA: 0x000047FB File Offset: 0x000029FB
		public static IStatusExceptionMapper GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IStatusExceptionMapper>(handle, transfer);
		}

		// Token: 0x0600011B RID: 283 RVA: 0x00004804 File Offset: 0x00002A04
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IStatusExceptionMapperInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'com.google.android.gms.common.api.internal.StatusExceptionMapper'.");
			}
			return handle;
		}

		// Token: 0x0600011C RID: 284 RVA: 0x0000482F File Offset: 0x00002A2F
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x0600011D RID: 285 RVA: 0x00004860 File Offset: 0x00002A60
		public IStatusExceptionMapperInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IStatusExceptionMapperInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x0600011E RID: 286 RVA: 0x00004898 File Offset: 0x00002A98
		private static Delegate GetGetException_Lcom_google_android_gms_common_api_Status_Handler()
		{
			if (IStatusExceptionMapperInvoker.cb_getException_Lcom_google_android_gms_common_api_Status_ == null)
			{
				IStatusExceptionMapperInvoker.cb_getException_Lcom_google_android_gms_common_api_Status_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(IStatusExceptionMapperInvoker.n_GetException_Lcom_google_android_gms_common_api_Status_));
			}
			return IStatusExceptionMapperInvoker.cb_getException_Lcom_google_android_gms_common_api_Status_;
		}

		// Token: 0x0600011F RID: 287 RVA: 0x000048BC File Offset: 0x00002ABC
		private static IntPtr n_GetException_Lcom_google_android_gms_common_api_Status_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			IStatusExceptionMapper @object = Java.Lang.Object.GetObject<IStatusExceptionMapper>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Statuses object2 = Java.Lang.Object.GetObject<Statuses>(native_p0, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.GetException(object2));
		}

		// Token: 0x06000120 RID: 288 RVA: 0x000048E4 File Offset: 0x00002AE4
		public unsafe Java.Lang.Exception GetException(Statuses p0)
		{
			if (this.id_getException_Lcom_google_android_gms_common_api_Status_ == IntPtr.Zero)
			{
				this.id_getException_Lcom_google_android_gms_common_api_Status_ = JNIEnv.GetMethodID(this.class_ref, "getException", "(Lcom/google/android/gms/common/api/Status;)Ljava/lang/Exception;");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((p0 == null) ? IntPtr.Zero : p0.Handle);
			return Java.Lang.Object.GetObject<Java.Lang.Exception>(JNIEnv.CallObjectMethod(base.Handle, this.id_getException_Lcom_google_android_gms_common_api_Status_, ptr), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x04000038 RID: 56
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/google/android/gms/common/api/internal/StatusExceptionMapper", typeof(IStatusExceptionMapperInvoker));

		// Token: 0x04000039 RID: 57
		private IntPtr class_ref;

		// Token: 0x0400003A RID: 58
		private static Delegate cb_getException_Lcom_google_android_gms_common_api_Status_;

		// Token: 0x0400003B RID: 59
		private IntPtr id_getException_Lcom_google_android_gms_common_api_Status_;
	}
}
