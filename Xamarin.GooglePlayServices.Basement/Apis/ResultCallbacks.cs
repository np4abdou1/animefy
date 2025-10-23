using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Android.Gms.Common.Apis
{
	// Token: 0x0200001E RID: 30
	[Register("com/google/android/gms/common/api/ResultCallbacks", DoNotGenerateAcw = true)]
	[JavaTypeParameters(new string[]
	{
		"R extends com.google.android.gms.common.api.Result"
	})]
	public abstract class ResultCallbacks : Java.Lang.Object, IResultCallback, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000033 RID: 51
		// (get) Token: 0x060000B8 RID: 184 RVA: 0x000035D0 File Offset: 0x000017D0
		internal static IntPtr class_ref
		{
			get
			{
				return ResultCallbacks._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000034 RID: 52
		// (get) Token: 0x060000B9 RID: 185 RVA: 0x000035F4 File Offset: 0x000017F4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return ResultCallbacks._members;
			}
		}

		// Token: 0x17000035 RID: 53
		// (get) Token: 0x060000BA RID: 186 RVA: 0x000035FC File Offset: 0x000017FC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return ResultCallbacks._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000036 RID: 54
		// (get) Token: 0x060000BB RID: 187 RVA: 0x00003620 File Offset: 0x00001820
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return ResultCallbacks._members.ManagedPeerType;
			}
		}

		// Token: 0x060000BC RID: 188 RVA: 0x00002EC0 File Offset: 0x000010C0
		protected ResultCallbacks(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x060000BD RID: 189 RVA: 0x0000362C File Offset: 0x0000182C
		[Register(".ctor", "()V", "")]
		public ResultCallbacks() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			base.SetHandle(ResultCallbacks._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
			ResultCallbacks._members.InstanceMethods.FinishCreateInstance("()V", this, null);
		}

		// Token: 0x060000BE RID: 190 RVA: 0x0000369A File Offset: 0x0000189A
		private static Delegate GetOnFailure_Lcom_google_android_gms_common_api_Status_Handler()
		{
			if (ResultCallbacks.cb_onFailure_Lcom_google_android_gms_common_api_Status_ == null)
			{
				ResultCallbacks.cb_onFailure_Lcom_google_android_gms_common_api_Status_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(ResultCallbacks.n_OnFailure_Lcom_google_android_gms_common_api_Status_));
			}
			return ResultCallbacks.cb_onFailure_Lcom_google_android_gms_common_api_Status_;
		}

		// Token: 0x060000BF RID: 191 RVA: 0x000036C0 File Offset: 0x000018C0
		private static void n_OnFailure_Lcom_google_android_gms_common_api_Status_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			ResultCallbacks @object = Java.Lang.Object.GetObject<ResultCallbacks>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Statuses object2 = Java.Lang.Object.GetObject<Statuses>(native_p0, JniHandleOwnership.DoNotTransfer);
			@object.OnFailure(object2);
		}

		// Token: 0x060000C0 RID: 192
		[Register("onFailure", "(Lcom/google/android/gms/common/api/Status;)V", "GetOnFailure_Lcom_google_android_gms_common_api_Status_Handler")]
		public abstract void OnFailure(Statuses p0);

		// Token: 0x060000C1 RID: 193 RVA: 0x000036E4 File Offset: 0x000018E4
		[Register("onResult", "(Lcom/google/android/gms/common/api/Result;)V", "")]
		public unsafe void OnResult(Java.Lang.Object result)
		{
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(result);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ResultCallbacks._members.InstanceMethods.InvokeNonvirtualVoidMethod("onResult.(Lcom/google/android/gms/common/api/Result;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(result);
			}
		}

		// Token: 0x060000C2 RID: 194 RVA: 0x00003748 File Offset: 0x00001948
		private static Delegate GetOnSuccess_Lcom_google_android_gms_common_api_Result_Handler()
		{
			if (ResultCallbacks.cb_onSuccess_Lcom_google_android_gms_common_api_Result_ == null)
			{
				ResultCallbacks.cb_onSuccess_Lcom_google_android_gms_common_api_Result_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(ResultCallbacks.n_OnSuccess_Lcom_google_android_gms_common_api_Result_));
			}
			return ResultCallbacks.cb_onSuccess_Lcom_google_android_gms_common_api_Result_;
		}

		// Token: 0x060000C3 RID: 195 RVA: 0x0000376C File Offset: 0x0000196C
		private static void n_OnSuccess_Lcom_google_android_gms_common_api_Result_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			ResultCallbacks @object = Java.Lang.Object.GetObject<ResultCallbacks>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_p0, JniHandleOwnership.DoNotTransfer);
			@object.OnSuccess(object2);
		}

		// Token: 0x060000C4 RID: 196
		[Register("onSuccess", "(Lcom/google/android/gms/common/api/Result;)V", "GetOnSuccess_Lcom_google_android_gms_common_api_Result_Handler")]
		public abstract void OnSuccess(Java.Lang.Object p0);

		// Token: 0x04000024 RID: 36
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/google/android/gms/common/api/ResultCallbacks", typeof(ResultCallbacks));

		// Token: 0x04000025 RID: 37
		private static Delegate cb_onFailure_Lcom_google_android_gms_common_api_Status_;

		// Token: 0x04000026 RID: 38
		private static Delegate cb_onSuccess_Lcom_google_android_gms_common_api_Result_;
	}
}
