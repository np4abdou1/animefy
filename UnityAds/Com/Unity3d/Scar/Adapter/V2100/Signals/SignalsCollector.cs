using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Content;
using Android.Runtime;
using Com.Unity3d.Scar.Adapter.Common;
using Com.Unity3d.Scar.Adapter.Common.Signals;
using Com.Unity3d.Scar.Adapter.V2100.Requests;
using Java.Interop;
using Java.Lang;

namespace Com.Unity3d.Scar.Adapter.V2100.Signals
{
	// Token: 0x02000245 RID: 581
	[Register("com/unity3d/scar/adapter/v2100/signals/SignalsCollector", DoNotGenerateAcw = true)]
	public class SignalsCollector : SignalsCollectorBase, ISignalsCollector, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000AB4 RID: 2740
		// (get) Token: 0x06001E43 RID: 7747 RVA: 0x000547E0 File Offset: 0x000529E0
		internal new static IntPtr class_ref
		{
			get
			{
				return SignalsCollector._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000AB5 RID: 2741
		// (get) Token: 0x06001E44 RID: 7748 RVA: 0x00054804 File Offset: 0x00052A04
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return SignalsCollector._members;
			}
		}

		// Token: 0x17000AB6 RID: 2742
		// (get) Token: 0x06001E45 RID: 7749 RVA: 0x0005480C File Offset: 0x00052A0C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return SignalsCollector._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000AB7 RID: 2743
		// (get) Token: 0x06001E46 RID: 7750 RVA: 0x00054830 File Offset: 0x00052A30
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return SignalsCollector._members.ManagedPeerType;
			}
		}

		// Token: 0x06001E47 RID: 7751 RVA: 0x0005483C File Offset: 0x00052A3C
		protected SignalsCollector(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06001E48 RID: 7752 RVA: 0x00054848 File Offset: 0x00052A48
		[Register(".ctor", "(Lcom/unity3d/scar/adapter/v2100/requests/AdRequestFactory;)V", "")]
		public unsafe SignalsCollector(AdRequestFactory adRequestFactory) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((adRequestFactory == null) ? IntPtr.Zero : adRequestFactory.Handle);
				base.SetHandle(SignalsCollector._members.InstanceMethods.StartCreateInstance("(Lcom/unity3d/scar/adapter/v2100/requests/AdRequestFactory;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				SignalsCollector._members.InstanceMethods.FinishCreateInstance("(Lcom/unity3d/scar/adapter/v2100/requests/AdRequestFactory;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(adRequestFactory);
			}
		}

		// Token: 0x06001E49 RID: 7753 RVA: 0x000548F8 File Offset: 0x00052AF8
		private static Delegate GetGetSCARSignal_Landroid_content_Context_Ljava_lang_String_ZLcom_unity3d_scar_adapter_common_DispatchGroup_Lcom_unity3d_scar_adapter_common_signals_SignalsResult_Handler()
		{
			if (SignalsCollector.cb_getSCARSignal_Landroid_content_Context_Ljava_lang_String_ZLcom_unity3d_scar_adapter_common_DispatchGroup_Lcom_unity3d_scar_adapter_common_signals_SignalsResult_ == null)
			{
				SignalsCollector.cb_getSCARSignal_Landroid_content_Context_Ljava_lang_String_ZLcom_unity3d_scar_adapter_common_DispatchGroup_Lcom_unity3d_scar_adapter_common_signals_SignalsResult_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLLZLL_V(SignalsCollector.n_GetSCARSignal_Landroid_content_Context_Ljava_lang_String_ZLcom_unity3d_scar_adapter_common_DispatchGroup_Lcom_unity3d_scar_adapter_common_signals_SignalsResult_));
			}
			return SignalsCollector.cb_getSCARSignal_Landroid_content_Context_Ljava_lang_String_ZLcom_unity3d_scar_adapter_common_DispatchGroup_Lcom_unity3d_scar_adapter_common_signals_SignalsResult_;
		}

		// Token: 0x06001E4A RID: 7754 RVA: 0x0005491C File Offset: 0x00052B1C
		private static void n_GetSCARSignal_Landroid_content_Context_Ljava_lang_String_ZLcom_unity3d_scar_adapter_common_DispatchGroup_Lcom_unity3d_scar_adapter_common_signals_SignalsResult_(IntPtr jnienv, IntPtr native__this, IntPtr native_context, IntPtr native_placementId, bool isInterstitial, IntPtr native_dispatchGroup, IntPtr native_signalsResult)
		{
			SignalsCollectorBase @object = Java.Lang.Object.GetObject<SignalsCollector>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Context object2 = Java.Lang.Object.GetObject<Context>(native_context, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_placementId, JniHandleOwnership.DoNotTransfer);
			DispatchGroup object3 = Java.Lang.Object.GetObject<DispatchGroup>(native_dispatchGroup, JniHandleOwnership.DoNotTransfer);
			SignalsResult object4 = Java.Lang.Object.GetObject<SignalsResult>(native_signalsResult, JniHandleOwnership.DoNotTransfer);
			@object.GetSCARSignal(object2, @string, isInterstitial, object3, object4);
		}

		// Token: 0x06001E4B RID: 7755 RVA: 0x00054960 File Offset: 0x00052B60
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

		// Token: 0x040006D3 RID: 1747
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/scar/adapter/v2100/signals/SignalsCollector", typeof(SignalsCollector));

		// Token: 0x040006D4 RID: 1748
		private static Delegate cb_getSCARSignal_Landroid_content_Context_Ljava_lang_String_ZLcom_unity3d_scar_adapter_common_DispatchGroup_Lcom_unity3d_scar_adapter_common_signals_SignalsResult_;
	}
}
