using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Content;
using Android.Runtime;
using Com.Unity3d.Scar.Adapter.Common;
using Com.Unity3d.Scar.Adapter.Common.Signals;
using Java.Interop;
using Java.Lang;

namespace Com.Unity3d.Scar.Adapter.V1920.Signals
{
	// Token: 0x0200028A RID: 650
	[Register("com/unity3d/scar/adapter/v1920/signals/SignalsCollector", DoNotGenerateAcw = true)]
	public class SignalsCollector : SignalsCollectorBase, ISignalsCollector, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000E4D RID: 3661
		// (get) Token: 0x06002574 RID: 9588 RVA: 0x000606B8 File Offset: 0x0005E8B8
		internal new static IntPtr class_ref
		{
			get
			{
				return SignalsCollector._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000E4E RID: 3662
		// (get) Token: 0x06002575 RID: 9589 RVA: 0x000606DC File Offset: 0x0005E8DC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return SignalsCollector._members;
			}
		}

		// Token: 0x17000E4F RID: 3663
		// (get) Token: 0x06002576 RID: 9590 RVA: 0x000606E4 File Offset: 0x0005E8E4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return SignalsCollector._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000E50 RID: 3664
		// (get) Token: 0x06002577 RID: 9591 RVA: 0x00060708 File Offset: 0x0005E908
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return SignalsCollector._members.ManagedPeerType;
			}
		}

		// Token: 0x06002578 RID: 9592 RVA: 0x0005483C File Offset: 0x00052A3C
		protected SignalsCollector(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06002579 RID: 9593 RVA: 0x00060714 File Offset: 0x0005E914
		private static Delegate GetGetSCARSignal_Landroid_content_Context_Ljava_lang_String_ZLcom_unity3d_scar_adapter_common_DispatchGroup_Lcom_unity3d_scar_adapter_common_signals_SignalsResult_Handler()
		{
			if (SignalsCollector.cb_getSCARSignal_Landroid_content_Context_Ljava_lang_String_ZLcom_unity3d_scar_adapter_common_DispatchGroup_Lcom_unity3d_scar_adapter_common_signals_SignalsResult_ == null)
			{
				SignalsCollector.cb_getSCARSignal_Landroid_content_Context_Ljava_lang_String_ZLcom_unity3d_scar_adapter_common_DispatchGroup_Lcom_unity3d_scar_adapter_common_signals_SignalsResult_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLLZLL_V(SignalsCollector.n_GetSCARSignal_Landroid_content_Context_Ljava_lang_String_ZLcom_unity3d_scar_adapter_common_DispatchGroup_Lcom_unity3d_scar_adapter_common_signals_SignalsResult_));
			}
			return SignalsCollector.cb_getSCARSignal_Landroid_content_Context_Ljava_lang_String_ZLcom_unity3d_scar_adapter_common_DispatchGroup_Lcom_unity3d_scar_adapter_common_signals_SignalsResult_;
		}

		// Token: 0x0600257A RID: 9594 RVA: 0x00060738 File Offset: 0x0005E938
		private static void n_GetSCARSignal_Landroid_content_Context_Ljava_lang_String_ZLcom_unity3d_scar_adapter_common_DispatchGroup_Lcom_unity3d_scar_adapter_common_signals_SignalsResult_(IntPtr jnienv, IntPtr native__this, IntPtr native_context, IntPtr native_placementId, bool isInterstitial, IntPtr native_dispatchGroup, IntPtr native_signalsResult)
		{
			SignalsCollectorBase @object = Java.Lang.Object.GetObject<SignalsCollector>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Context object2 = Java.Lang.Object.GetObject<Context>(native_context, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_placementId, JniHandleOwnership.DoNotTransfer);
			DispatchGroup object3 = Java.Lang.Object.GetObject<DispatchGroup>(native_dispatchGroup, JniHandleOwnership.DoNotTransfer);
			SignalsResult object4 = Java.Lang.Object.GetObject<SignalsResult>(native_signalsResult, JniHandleOwnership.DoNotTransfer);
			@object.GetSCARSignal(object2, @string, isInterstitial, object3, object4);
		}

		// Token: 0x0600257B RID: 9595 RVA: 0x0006077C File Offset: 0x0005E97C
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

		// Token: 0x04000740 RID: 1856
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/scar/adapter/v1920/signals/SignalsCollector", typeof(SignalsCollector));

		// Token: 0x04000741 RID: 1857
		private static Delegate cb_getSCARSignal_Landroid_content_Context_Ljava_lang_String_ZLcom_unity3d_scar_adapter_common_DispatchGroup_Lcom_unity3d_scar_adapter_common_signals_SignalsResult_;
	}
}
