using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Com.Unity3d.Scar.Adapter.Common
{
	// Token: 0x0200029A RID: 666
	[Register("com/unity3d/scar/adapter/common/IAdsErrorHandler", DoNotGenerateAcw = true)]
	internal class IAdsErrorHandlerInvoker : Java.Lang.Object, IAdsErrorHandler, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000E9A RID: 3738
		// (get) Token: 0x06002617 RID: 9751 RVA: 0x000622A0 File Offset: 0x000604A0
		private static IntPtr java_class_ref
		{
			get
			{
				return IAdsErrorHandlerInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000E9B RID: 3739
		// (get) Token: 0x06002618 RID: 9752 RVA: 0x000622C4 File Offset: 0x000604C4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IAdsErrorHandlerInvoker._members;
			}
		}

		// Token: 0x17000E9C RID: 3740
		// (get) Token: 0x06002619 RID: 9753 RVA: 0x000622CB File Offset: 0x000604CB
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x17000E9D RID: 3741
		// (get) Token: 0x0600261A RID: 9754 RVA: 0x000622D3 File Offset: 0x000604D3
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IAdsErrorHandlerInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x0600261B RID: 9755 RVA: 0x000622DF File Offset: 0x000604DF
		public static IAdsErrorHandler GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IAdsErrorHandler>(handle, transfer);
		}

		// Token: 0x0600261C RID: 9756 RVA: 0x000622E8 File Offset: 0x000604E8
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IAdsErrorHandlerInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'com.unity3d.scar.adapter.common.IAdsErrorHandler'.");
			}
			return handle;
		}

		// Token: 0x0600261D RID: 9757 RVA: 0x00062313 File Offset: 0x00060513
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x0600261E RID: 9758 RVA: 0x00062344 File Offset: 0x00060544
		public IAdsErrorHandlerInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IAdsErrorHandlerInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x0600261F RID: 9759 RVA: 0x0006237C File Offset: 0x0006057C
		private static Delegate GetHandleError_Lcom_unity3d_scar_adapter_common_IUnityAdsError_Handler()
		{
			if (IAdsErrorHandlerInvoker.cb_handleError_Lcom_unity3d_scar_adapter_common_IUnityAdsError_ == null)
			{
				IAdsErrorHandlerInvoker.cb_handleError_Lcom_unity3d_scar_adapter_common_IUnityAdsError_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(IAdsErrorHandlerInvoker.n_HandleError_Lcom_unity3d_scar_adapter_common_IUnityAdsError_));
			}
			return IAdsErrorHandlerInvoker.cb_handleError_Lcom_unity3d_scar_adapter_common_IUnityAdsError_;
		}

		// Token: 0x06002620 RID: 9760 RVA: 0x000623A0 File Offset: 0x000605A0
		private static void n_HandleError_Lcom_unity3d_scar_adapter_common_IUnityAdsError_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			IAdsErrorHandler @object = Java.Lang.Object.GetObject<IAdsErrorHandler>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_p0, JniHandleOwnership.DoNotTransfer);
			@object.HandleError(object2);
		}

		// Token: 0x06002621 RID: 9761 RVA: 0x000623C4 File Offset: 0x000605C4
		public unsafe void HandleError(Java.Lang.Object p0)
		{
			if (this.id_handleError_Lcom_unity3d_scar_adapter_common_IUnityAdsError_ == IntPtr.Zero)
			{
				this.id_handleError_Lcom_unity3d_scar_adapter_common_IUnityAdsError_ = JNIEnv.GetMethodID(this.class_ref, "handleError", "(Lcom/unity3d/scar/adapter/common/IUnityAdsError;)V");
			}
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(p0);
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(intPtr);
			JNIEnv.CallVoidMethod(base.Handle, this.id_handleError_Lcom_unity3d_scar_adapter_common_IUnityAdsError_, ptr);
			JNIEnv.DeleteLocalRef(intPtr);
		}

		// Token: 0x04000762 RID: 1890
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/scar/adapter/common/IAdsErrorHandler", typeof(IAdsErrorHandlerInvoker));

		// Token: 0x04000763 RID: 1891
		private IntPtr class_ref;

		// Token: 0x04000764 RID: 1892
		private static Delegate cb_handleError_Lcom_unity3d_scar_adapter_common_IUnityAdsError_;

		// Token: 0x04000765 RID: 1893
		private IntPtr id_handleError_Lcom_unity3d_scar_adapter_common_IUnityAdsError_;
	}
}
