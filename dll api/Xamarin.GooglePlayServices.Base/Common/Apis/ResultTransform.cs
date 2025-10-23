using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Android.Gms.Common.Apis
{
	// Token: 0x0200006D RID: 109
	[Register("com/google/android/gms/common/api/ResultTransform", DoNotGenerateAcw = true)]
	[JavaTypeParameters(new string[]
	{
		"R extends com.google.android.gms.common.api.Result",
		"S extends com.google.android.gms.common.api.Result"
	})]
	public abstract class ResultTransform : Java.Lang.Object
	{
		// Token: 0x17000136 RID: 310
		// (get) Token: 0x060004AA RID: 1194 RVA: 0x0000E134 File Offset: 0x0000C334
		internal static IntPtr class_ref
		{
			get
			{
				return ResultTransform._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000137 RID: 311
		// (get) Token: 0x060004AB RID: 1195 RVA: 0x0000E158 File Offset: 0x0000C358
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return ResultTransform._members;
			}
		}

		// Token: 0x17000138 RID: 312
		// (get) Token: 0x060004AC RID: 1196 RVA: 0x0000E160 File Offset: 0x0000C360
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return ResultTransform._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000139 RID: 313
		// (get) Token: 0x060004AD RID: 1197 RVA: 0x0000E184 File Offset: 0x0000C384
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return ResultTransform._members.ManagedPeerType;
			}
		}

		// Token: 0x060004AE RID: 1198 RVA: 0x00003280 File Offset: 0x00001480
		protected ResultTransform(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x060004AF RID: 1199 RVA: 0x0000E190 File Offset: 0x0000C390
		[Register(".ctor", "()V", "")]
		public ResultTransform() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			base.SetHandle(ResultTransform._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
			ResultTransform._members.InstanceMethods.FinishCreateInstance("()V", this, null);
		}

		// Token: 0x060004B0 RID: 1200 RVA: 0x0000E200 File Offset: 0x0000C400
		[Register("createFailedResult", "(Lcom/google/android/gms/common/api/Status;)Lcom/google/android/gms/common/api/PendingResult;", "")]
		public unsafe PendingResult CreateFailedResult(Statuses status)
		{
			PendingResult @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((status == null) ? IntPtr.Zero : status.Handle);
				@object = Java.Lang.Object.GetObject<PendingResult>(ResultTransform._members.InstanceMethods.InvokeNonvirtualObjectMethod("createFailedResult.(Lcom/google/android/gms/common/api/Status;)Lcom/google/android/gms/common/api/PendingResult;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(status);
			}
			return @object;
		}

		// Token: 0x060004B1 RID: 1201 RVA: 0x0000E274 File Offset: 0x0000C474
		private static Delegate GetOnFailure_Lcom_google_android_gms_common_api_Status_Handler()
		{
			if (ResultTransform.cb_onFailure_Lcom_google_android_gms_common_api_Status_ == null)
			{
				ResultTransform.cb_onFailure_Lcom_google_android_gms_common_api_Status_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(ResultTransform.n_OnFailure_Lcom_google_android_gms_common_api_Status_));
			}
			return ResultTransform.cb_onFailure_Lcom_google_android_gms_common_api_Status_;
		}

		// Token: 0x060004B2 RID: 1202 RVA: 0x0000E298 File Offset: 0x0000C498
		private static IntPtr n_OnFailure_Lcom_google_android_gms_common_api_Status_(IntPtr jnienv, IntPtr native__this, IntPtr native_status)
		{
			ResultTransform @object = Java.Lang.Object.GetObject<ResultTransform>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Statuses object2 = Java.Lang.Object.GetObject<Statuses>(native_status, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.OnFailure(object2));
		}

		// Token: 0x060004B3 RID: 1203 RVA: 0x0000E2C0 File Offset: 0x0000C4C0
		[Register("onFailure", "(Lcom/google/android/gms/common/api/Status;)Lcom/google/android/gms/common/api/Status;", "GetOnFailure_Lcom_google_android_gms_common_api_Status_Handler")]
		public unsafe virtual Statuses OnFailure(Statuses status)
		{
			Statuses @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((status == null) ? IntPtr.Zero : status.Handle);
				@object = Java.Lang.Object.GetObject<Statuses>(ResultTransform._members.InstanceMethods.InvokeVirtualObjectMethod("onFailure.(Lcom/google/android/gms/common/api/Status;)Lcom/google/android/gms/common/api/Status;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(status);
			}
			return @object;
		}

		// Token: 0x060004B4 RID: 1204 RVA: 0x0000E334 File Offset: 0x0000C534
		private static Delegate GetOnSuccess_Lcom_google_android_gms_common_api_Result_Handler()
		{
			if (ResultTransform.cb_onSuccess_Lcom_google_android_gms_common_api_Result_ == null)
			{
				ResultTransform.cb_onSuccess_Lcom_google_android_gms_common_api_Result_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(ResultTransform.n_OnSuccess_Lcom_google_android_gms_common_api_Result_));
			}
			return ResultTransform.cb_onSuccess_Lcom_google_android_gms_common_api_Result_;
		}

		// Token: 0x060004B5 RID: 1205 RVA: 0x0000E358 File Offset: 0x0000C558
		private static IntPtr n_OnSuccess_Lcom_google_android_gms_common_api_Result_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			ResultTransform @object = Java.Lang.Object.GetObject<ResultTransform>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_p0, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.OnSuccess(object2));
		}

		// Token: 0x060004B6 RID: 1206
		[Register("onSuccess", "(Lcom/google/android/gms/common/api/Result;)Lcom/google/android/gms/common/api/PendingResult;", "GetOnSuccess_Lcom_google_android_gms_common_api_Result_Handler")]
		public abstract PendingResult OnSuccess(Java.Lang.Object p0);

		// Token: 0x0400011D RID: 285
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/google/android/gms/common/api/ResultTransform", typeof(ResultTransform));

		// Token: 0x0400011E RID: 286
		private static Delegate cb_onFailure_Lcom_google_android_gms_common_api_Status_;

		// Token: 0x0400011F RID: 287
		private static Delegate cb_onSuccess_Lcom_google_android_gms_common_api_Result_;
	}
}
