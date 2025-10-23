using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Android.Gms.Common.Apis
{
	// Token: 0x0200006F RID: 111
	[Register("com/google/android/gms/common/api/TransformedResult", DoNotGenerateAcw = true)]
	[JavaTypeParameters(new string[]
	{
		"R extends com.google.android.gms.common.api.Result"
	})]
	public abstract class TransformedResult : Java.Lang.Object
	{
		// Token: 0x1700013C RID: 316
		// (get) Token: 0x060004BD RID: 1213 RVA: 0x0000E448 File Offset: 0x0000C648
		internal static IntPtr class_ref
		{
			get
			{
				return TransformedResult._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700013D RID: 317
		// (get) Token: 0x060004BE RID: 1214 RVA: 0x0000E46C File Offset: 0x0000C66C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return TransformedResult._members;
			}
		}

		// Token: 0x1700013E RID: 318
		// (get) Token: 0x060004BF RID: 1215 RVA: 0x0000E474 File Offset: 0x0000C674
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return TransformedResult._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700013F RID: 319
		// (get) Token: 0x060004C0 RID: 1216 RVA: 0x0000E498 File Offset: 0x0000C698
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return TransformedResult._members.ManagedPeerType;
			}
		}

		// Token: 0x060004C1 RID: 1217 RVA: 0x00003280 File Offset: 0x00001480
		protected TransformedResult(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x060004C2 RID: 1218 RVA: 0x0000E4A4 File Offset: 0x0000C6A4
		[Register(".ctor", "()V", "")]
		public TransformedResult() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			base.SetHandle(TransformedResult._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
			TransformedResult._members.InstanceMethods.FinishCreateInstance("()V", this, null);
		}

		// Token: 0x060004C3 RID: 1219 RVA: 0x0000E512 File Offset: 0x0000C712
		private static Delegate GetAndFinally_Lcom_google_android_gms_common_api_ResultCallbacks_Handler()
		{
			if (TransformedResult.cb_andFinally_Lcom_google_android_gms_common_api_ResultCallbacks_ == null)
			{
				TransformedResult.cb_andFinally_Lcom_google_android_gms_common_api_ResultCallbacks_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(TransformedResult.n_AndFinally_Lcom_google_android_gms_common_api_ResultCallbacks_));
			}
			return TransformedResult.cb_andFinally_Lcom_google_android_gms_common_api_ResultCallbacks_;
		}

		// Token: 0x060004C4 RID: 1220 RVA: 0x0000E538 File Offset: 0x0000C738
		private static void n_AndFinally_Lcom_google_android_gms_common_api_ResultCallbacks_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			TransformedResult @object = Java.Lang.Object.GetObject<TransformedResult>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ResultCallbacks object2 = Java.Lang.Object.GetObject<ResultCallbacks>(native_p0, JniHandleOwnership.DoNotTransfer);
			@object.AndFinally(object2);
		}

		// Token: 0x060004C5 RID: 1221
		[Register("andFinally", "(Lcom/google/android/gms/common/api/ResultCallbacks;)V", "GetAndFinally_Lcom_google_android_gms_common_api_ResultCallbacks_Handler")]
		public abstract void AndFinally(ResultCallbacks p0);

		// Token: 0x060004C6 RID: 1222 RVA: 0x0000E55B File Offset: 0x0000C75B
		private static Delegate GetThen_Lcom_google_android_gms_common_api_ResultTransform_Handler()
		{
			if (TransformedResult.cb_then_Lcom_google_android_gms_common_api_ResultTransform_ == null)
			{
				TransformedResult.cb_then_Lcom_google_android_gms_common_api_ResultTransform_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(TransformedResult.n_Then_Lcom_google_android_gms_common_api_ResultTransform_));
			}
			return TransformedResult.cb_then_Lcom_google_android_gms_common_api_ResultTransform_;
		}

		// Token: 0x060004C7 RID: 1223 RVA: 0x0000E580 File Offset: 0x0000C780
		private static IntPtr n_Then_Lcom_google_android_gms_common_api_ResultTransform_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			TransformedResult @object = Java.Lang.Object.GetObject<TransformedResult>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ResultTransform object2 = Java.Lang.Object.GetObject<ResultTransform>(native_p0, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.Then(object2));
		}

		// Token: 0x060004C8 RID: 1224
		[Register("then", "(Lcom/google/android/gms/common/api/ResultTransform;)Lcom/google/android/gms/common/api/TransformedResult;", "GetThen_Lcom_google_android_gms_common_api_ResultTransform_Handler")]
		[JavaTypeParameters(new string[]
		{
			"S extends com.google.android.gms.common.api.Result"
		})]
		public abstract TransformedResult Then(ResultTransform p0);

		// Token: 0x04000121 RID: 289
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/google/android/gms/common/api/TransformedResult", typeof(TransformedResult));

		// Token: 0x04000122 RID: 290
		private static Delegate cb_andFinally_Lcom_google_android_gms_common_api_ResultCallbacks_;

		// Token: 0x04000123 RID: 291
		private static Delegate cb_then_Lcom_google_android_gms_common_api_ResultTransform_;
	}
}
