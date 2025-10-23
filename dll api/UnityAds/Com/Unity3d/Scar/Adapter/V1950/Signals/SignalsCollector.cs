using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Content;
using Android.Runtime;
using Com.Unity3d.Scar.Adapter.Common;
using Com.Unity3d.Scar.Adapter.Common.Signals;
using Java.Interop;
using Java.Lang;

namespace Com.Unity3d.Scar.Adapter.V1950.Signals
{
	// Token: 0x02000272 RID: 626
	[Register("com/unity3d/scar/adapter/v1950/signals/SignalsCollector", DoNotGenerateAcw = true)]
	public class SignalsCollector : SignalsCollectorBase, ISignalsCollector, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000D3F RID: 3391
		// (get) Token: 0x06002350 RID: 9040 RVA: 0x0005CDF4 File Offset: 0x0005AFF4
		internal new static IntPtr class_ref
		{
			get
			{
				return SignalsCollector._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000D40 RID: 3392
		// (get) Token: 0x06002351 RID: 9041 RVA: 0x0005CE18 File Offset: 0x0005B018
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return SignalsCollector._members;
			}
		}

		// Token: 0x17000D41 RID: 3393
		// (get) Token: 0x06002352 RID: 9042 RVA: 0x0005CE20 File Offset: 0x0005B020
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return SignalsCollector._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000D42 RID: 3394
		// (get) Token: 0x06002353 RID: 9043 RVA: 0x0005CE44 File Offset: 0x0005B044
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return SignalsCollector._members.ManagedPeerType;
			}
		}

		// Token: 0x06002354 RID: 9044 RVA: 0x0005483C File Offset: 0x00052A3C
		protected SignalsCollector(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06002355 RID: 9045 RVA: 0x0005CE50 File Offset: 0x0005B050
		private static Delegate GetGetSCARSignal_Landroid_content_Context_Ljava_lang_String_ZLcom_unity3d_scar_adapter_common_DispatchGroup_Lcom_unity3d_scar_adapter_common_signals_SignalsResult_Handler()
		{
			if (SignalsCollector.cb_getSCARSignal_Landroid_content_Context_Ljava_lang_String_ZLcom_unity3d_scar_adapter_common_DispatchGroup_Lcom_unity3d_scar_adapter_common_signals_SignalsResult_ == null)
			{
				SignalsCollector.cb_getSCARSignal_Landroid_content_Context_Ljava_lang_String_ZLcom_unity3d_scar_adapter_common_DispatchGroup_Lcom_unity3d_scar_adapter_common_signals_SignalsResult_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLLZLL_V(SignalsCollector.n_GetSCARSignal_Landroid_content_Context_Ljava_lang_String_ZLcom_unity3d_scar_adapter_common_DispatchGroup_Lcom_unity3d_scar_adapter_common_signals_SignalsResult_));
			}
			return SignalsCollector.cb_getSCARSignal_Landroid_content_Context_Ljava_lang_String_ZLcom_unity3d_scar_adapter_common_DispatchGroup_Lcom_unity3d_scar_adapter_common_signals_SignalsResult_;
		}

		// Token: 0x06002356 RID: 9046 RVA: 0x0005CE74 File Offset: 0x0005B074
		private static void n_GetSCARSignal_Landroid_content_Context_Ljava_lang_String_ZLcom_unity3d_scar_adapter_common_DispatchGroup_Lcom_unity3d_scar_adapter_common_signals_SignalsResult_(IntPtr jnienv, IntPtr native__this, IntPtr native_context, IntPtr native_placementId, bool isInterstitial, IntPtr native_dispatchGroup, IntPtr native_signalsResult)
		{
			SignalsCollectorBase @object = Java.Lang.Object.GetObject<SignalsCollector>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Context object2 = Java.Lang.Object.GetObject<Context>(native_context, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_placementId, JniHandleOwnership.DoNotTransfer);
			DispatchGroup object3 = Java.Lang.Object.GetObject<DispatchGroup>(native_dispatchGroup, JniHandleOwnership.DoNotTransfer);
			SignalsResult object4 = Java.Lang.Object.GetObject<SignalsResult>(native_signalsResult, JniHandleOwnership.DoNotTransfer);
			@object.GetSCARSignal(object2, @string, isInterstitial, object3, object4);
		}

		// Token: 0x06002357 RID: 9047 RVA: 0x0005CEB8 File Offset: 0x0005B0B8
		[Register("getSCARSignal", "(Landroid/content/Context;Ljava/lang/String;ZLcom/unity3d/scar/adapter/common/DispatchGroup;Lcom/unity3d/scar/adapter/common/signals/SignalsResult;)V", "GetGetSCARSignal_Landroid_content_Context_Ljava_lang_String_ZLcom_unity3d_scar_adapter_common_DispatchGroup_Lcom_unity3d_scar_adapter_common_signals_SignalsResult_Handler")]
		public unsafe override void GetSCARSignal(Context context, string placementId, bool isInterstitial, DispatchGroup dispatchGroup, SignalsResult signalsResult)
		{
			IntPtr intPtr = JNIEnv.NewString(placementId);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((context == null) ? IntPtr.Zero : context.Handle);
				ptr[1] = new JniArgumentValue(intPtr);
				ptr[2] = new JniArgumentValue(isInterstitial);
				ptr[3] = new JniArgumentValue((dispatchGroup == null) ? IntPtr.Zero : dispatchGroup.Handle);
				ptr[4] = new JniArgumentValue((signalsResult == null) ? IntPtr.Zero : signalsResult.Handle);
				SignalsCollector._members.InstanceMethods.InvokeVirtualVoidMethod("getSCARSignal.(Landroid/content/Context;Ljava/lang/String;ZLcom/unity3d/scar/adapter/common/DispatchGroup;Lcom/unity3d/scar/adapter/common/signals/SignalsResult;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(context);
				GC.KeepAlive(dispatchGroup);
				GC.KeepAlive(signalsResult);
			}
		}

		// Token: 0x04000718 RID: 1816
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/scar/adapter/v1950/signals/SignalsCollector", typeof(SignalsCollector));

		// Token: 0x04000719 RID: 1817
		private static Delegate cb_getSCARSignal_Landroid_content_Context_Ljava_lang_String_ZLcom_unity3d_scar_adapter_common_DispatchGroup_Lcom_unity3d_scar_adapter_common_signals_SignalsResult_;
	}
}
