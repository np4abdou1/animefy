using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Content;
using Android.Runtime;
using Com.Unity3d.Scar.Adapter.Common;
using Com.Unity3d.Scar.Adapter.Common.Signals;
using Java.Interop;
using Java.Lang;

namespace Com.Unity3d.Scar.Adapter.V2000.Signals
{
	// Token: 0x0200025C RID: 604
	[Register("com/unity3d/scar/adapter/v2000/signals/SignalsCollector", DoNotGenerateAcw = true)]
	public class SignalsCollector : SignalsCollectorBase, ISignalsCollector, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000BFC RID: 3068
		// (get) Token: 0x060020CF RID: 8399 RVA: 0x00058CB8 File Offset: 0x00056EB8
		internal new static IntPtr class_ref
		{
			get
			{
				return SignalsCollector._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000BFD RID: 3069
		// (get) Token: 0x060020D0 RID: 8400 RVA: 0x00058CDC File Offset: 0x00056EDC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return SignalsCollector._members;
			}
		}

		// Token: 0x17000BFE RID: 3070
		// (get) Token: 0x060020D1 RID: 8401 RVA: 0x00058CE4 File Offset: 0x00056EE4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return SignalsCollector._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000BFF RID: 3071
		// (get) Token: 0x060020D2 RID: 8402 RVA: 0x00058D08 File Offset: 0x00056F08
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return SignalsCollector._members.ManagedPeerType;
			}
		}

		// Token: 0x060020D3 RID: 8403 RVA: 0x0005483C File Offset: 0x00052A3C
		protected SignalsCollector(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x060020D4 RID: 8404 RVA: 0x00058D14 File Offset: 0x00056F14
		private static Delegate GetGetSCARSignal_Landroid_content_Context_Ljava_lang_String_ZLcom_unity3d_scar_adapter_common_DispatchGroup_Lcom_unity3d_scar_adapter_common_signals_SignalsResult_Handler()
		{
			if (SignalsCollector.cb_getSCARSignal_Landroid_content_Context_Ljava_lang_String_ZLcom_unity3d_scar_adapter_common_DispatchGroup_Lcom_unity3d_scar_adapter_common_signals_SignalsResult_ == null)
			{
				SignalsCollector.cb_getSCARSignal_Landroid_content_Context_Ljava_lang_String_ZLcom_unity3d_scar_adapter_common_DispatchGroup_Lcom_unity3d_scar_adapter_common_signals_SignalsResult_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLLZLL_V(SignalsCollector.n_GetSCARSignal_Landroid_content_Context_Ljava_lang_String_ZLcom_unity3d_scar_adapter_common_DispatchGroup_Lcom_unity3d_scar_adapter_common_signals_SignalsResult_));
			}
			return SignalsCollector.cb_getSCARSignal_Landroid_content_Context_Ljava_lang_String_ZLcom_unity3d_scar_adapter_common_DispatchGroup_Lcom_unity3d_scar_adapter_common_signals_SignalsResult_;
		}

		// Token: 0x060020D5 RID: 8405 RVA: 0x00058D38 File Offset: 0x00056F38
		private static void n_GetSCARSignal_Landroid_content_Context_Ljava_lang_String_ZLcom_unity3d_scar_adapter_common_DispatchGroup_Lcom_unity3d_scar_adapter_common_signals_SignalsResult_(IntPtr jnienv, IntPtr native__this, IntPtr native_context, IntPtr native_placementId, bool isInterstitial, IntPtr native_dispatchGroup, IntPtr native_signalsResult)
		{
			SignalsCollectorBase @object = Java.Lang.Object.GetObject<SignalsCollector>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Context object2 = Java.Lang.Object.GetObject<Context>(native_context, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_placementId, JniHandleOwnership.DoNotTransfer);
			DispatchGroup object3 = Java.Lang.Object.GetObject<DispatchGroup>(native_dispatchGroup, JniHandleOwnership.DoNotTransfer);
			SignalsResult object4 = Java.Lang.Object.GetObject<SignalsResult>(native_signalsResult, JniHandleOwnership.DoNotTransfer);
			@object.GetSCARSignal(object2, @string, isInterstitial, object3, object4);
		}

		// Token: 0x060020D6 RID: 8406 RVA: 0x00058D7C File Offset: 0x00056F7C
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

		// Token: 0x040006F6 RID: 1782
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/scar/adapter/v2000/signals/SignalsCollector", typeof(SignalsCollector));

		// Token: 0x040006F7 RID: 1783
		private static Delegate cb_getSCARSignal_Landroid_content_Context_Ljava_lang_String_ZLcom_unity3d_scar_adapter_common_DispatchGroup_Lcom_unity3d_scar_adapter_common_signals_SignalsResult_;
	}
}
