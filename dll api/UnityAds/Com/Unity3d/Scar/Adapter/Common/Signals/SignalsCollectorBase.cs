using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Content;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Com.Unity3d.Scar.Adapter.Common.Signals
{
	// Token: 0x020002B7 RID: 695
	[Register("com/unity3d/scar/adapter/common/signals/SignalsCollectorBase", DoNotGenerateAcw = true)]
	public abstract class SignalsCollectorBase : Java.Lang.Object, ISignalsCollector, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000EE9 RID: 3817
		// (get) Token: 0x0600275B RID: 10075 RVA: 0x00065930 File Offset: 0x00063B30
		internal static IntPtr class_ref
		{
			get
			{
				return SignalsCollectorBase._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000EEA RID: 3818
		// (get) Token: 0x0600275C RID: 10076 RVA: 0x00065954 File Offset: 0x00063B54
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return SignalsCollectorBase._members;
			}
		}

		// Token: 0x17000EEB RID: 3819
		// (get) Token: 0x0600275D RID: 10077 RVA: 0x0006595C File Offset: 0x00063B5C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return SignalsCollectorBase._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000EEC RID: 3820
		// (get) Token: 0x0600275E RID: 10078 RVA: 0x00065980 File Offset: 0x00063B80
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return SignalsCollectorBase._members.ManagedPeerType;
			}
		}

		// Token: 0x0600275F RID: 10079 RVA: 0x000021E8 File Offset: 0x000003E8
		protected SignalsCollectorBase(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06002760 RID: 10080 RVA: 0x0006598C File Offset: 0x00063B8C
		[Register(".ctor", "()V", "")]
		public SignalsCollectorBase() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			base.SetHandle(SignalsCollectorBase._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
			SignalsCollectorBase._members.InstanceMethods.FinishCreateInstance("()V", this, null);
		}

		// Token: 0x06002761 RID: 10081 RVA: 0x000659FA File Offset: 0x00063BFA
		private static Delegate GetGetSCARSignals_Landroid_content_Context_arrayLjava_lang_String_arrayLjava_lang_String_Lcom_unity3d_scar_adapter_common_signals_ISignalCollectionListener_Handler()
		{
			if (SignalsCollectorBase.cb_getSCARSignals_Landroid_content_Context_arrayLjava_lang_String_arrayLjava_lang_String_Lcom_unity3d_scar_adapter_common_signals_ISignalCollectionListener_ == null)
			{
				SignalsCollectorBase.cb_getSCARSignals_Landroid_content_Context_arrayLjava_lang_String_arrayLjava_lang_String_Lcom_unity3d_scar_adapter_common_signals_ISignalCollectionListener_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLLLL_V(SignalsCollectorBase.n_GetSCARSignals_Landroid_content_Context_arrayLjava_lang_String_arrayLjava_lang_String_Lcom_unity3d_scar_adapter_common_signals_ISignalCollectionListener_));
			}
			return SignalsCollectorBase.cb_getSCARSignals_Landroid_content_Context_arrayLjava_lang_String_arrayLjava_lang_String_Lcom_unity3d_scar_adapter_common_signals_ISignalCollectionListener_;
		}

		// Token: 0x06002762 RID: 10082 RVA: 0x00065A20 File Offset: 0x00063C20
		private static void n_GetSCARSignals_Landroid_content_Context_arrayLjava_lang_String_arrayLjava_lang_String_Lcom_unity3d_scar_adapter_common_signals_ISignalCollectionListener_(IntPtr jnienv, IntPtr native__this, IntPtr native_context, IntPtr native_interstitialList, IntPtr native_rewardedList, IntPtr native_signalCompletionListener)
		{
			SignalsCollectorBase @object = Java.Lang.Object.GetObject<SignalsCollectorBase>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Context object2 = Java.Lang.Object.GetObject<Context>(native_context, JniHandleOwnership.DoNotTransfer);
			string[] array = (string[])JNIEnv.GetArray(native_interstitialList, JniHandleOwnership.DoNotTransfer, typeof(string));
			string[] array2 = (string[])JNIEnv.GetArray(native_rewardedList, JniHandleOwnership.DoNotTransfer, typeof(string));
			ISignalCollectionListener object3 = Java.Lang.Object.GetObject<ISignalCollectionListener>(native_signalCompletionListener, JniHandleOwnership.DoNotTransfer);
			@object.GetSCARSignals(object2, array, array2, object3);
			if (array != null)
			{
				JNIEnv.CopyArray(array, native_interstitialList);
			}
			if (array2 != null)
			{
				JNIEnv.CopyArray(array2, native_rewardedList);
			}
		}

		// Token: 0x06002763 RID: 10083 RVA: 0x00065A94 File Offset: 0x00063C94
		[Register("getSCARSignals", "(Landroid/content/Context;[Ljava/lang/String;[Ljava/lang/String;Lcom/unity3d/scar/adapter/common/signals/ISignalCollectionListener;)V", "GetGetSCARSignals_Landroid_content_Context_arrayLjava_lang_String_arrayLjava_lang_String_Lcom_unity3d_scar_adapter_common_signals_ISignalCollectionListener_Handler")]
		public unsafe virtual void GetSCARSignals(Context context, string[] interstitialList, string[] rewardedList, ISignalCollectionListener signalCompletionListener)
		{
			IntPtr intPtr = JNIEnv.NewArray(interstitialList);
			IntPtr intPtr2 = JNIEnv.NewArray(rewardedList);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((context == null) ? IntPtr.Zero : context.Handle);
				ptr[1] = new JniArgumentValue(intPtr);
				ptr[2] = new JniArgumentValue(intPtr2);
				ptr[3] = new JniArgumentValue((signalCompletionListener == null) ? IntPtr.Zero : ((Java.Lang.Object)signalCompletionListener).Handle);
				SignalsCollectorBase._members.InstanceMethods.InvokeVirtualVoidMethod("getSCARSignals.(Landroid/content/Context;[Ljava/lang/String;[Ljava/lang/String;Lcom/unity3d/scar/adapter/common/signals/ISignalCollectionListener;)V", this, ptr);
			}
			finally
			{
				if (interstitialList != null)
				{
					JNIEnv.CopyArray(intPtr, interstitialList);
					JNIEnv.DeleteLocalRef(intPtr);
				}
				if (rewardedList != null)
				{
					JNIEnv.CopyArray(intPtr2, rewardedList);
					JNIEnv.DeleteLocalRef(intPtr2);
				}
				GC.KeepAlive(context);
				GC.KeepAlive(interstitialList);
				GC.KeepAlive(rewardedList);
				GC.KeepAlive(signalCompletionListener);
			}
		}

		// Token: 0x06002764 RID: 10084 RVA: 0x00065B90 File Offset: 0x00063D90
		private static Delegate GetGetSCARSignal_Landroid_content_Context_Ljava_lang_String_ZLcom_unity3d_scar_adapter_common_DispatchGroup_Lcom_unity3d_scar_adapter_common_signals_SignalsResult_Handler()
		{
			if (SignalsCollectorBase.cb_getSCARSignal_Landroid_content_Context_Ljava_lang_String_ZLcom_unity3d_scar_adapter_common_DispatchGroup_Lcom_unity3d_scar_adapter_common_signals_SignalsResult_ == null)
			{
				SignalsCollectorBase.cb_getSCARSignal_Landroid_content_Context_Ljava_lang_String_ZLcom_unity3d_scar_adapter_common_DispatchGroup_Lcom_unity3d_scar_adapter_common_signals_SignalsResult_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLLZLL_V(SignalsCollectorBase.n_GetSCARSignal_Landroid_content_Context_Ljava_lang_String_ZLcom_unity3d_scar_adapter_common_DispatchGroup_Lcom_unity3d_scar_adapter_common_signals_SignalsResult_));
			}
			return SignalsCollectorBase.cb_getSCARSignal_Landroid_content_Context_Ljava_lang_String_ZLcom_unity3d_scar_adapter_common_DispatchGroup_Lcom_unity3d_scar_adapter_common_signals_SignalsResult_;
		}

		// Token: 0x06002765 RID: 10085 RVA: 0x00065BB4 File Offset: 0x00063DB4
		private static void n_GetSCARSignal_Landroid_content_Context_Ljava_lang_String_ZLcom_unity3d_scar_adapter_common_DispatchGroup_Lcom_unity3d_scar_adapter_common_signals_SignalsResult_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, bool p2, IntPtr native_p3, IntPtr native_p4)
		{
			SignalsCollectorBase @object = Java.Lang.Object.GetObject<SignalsCollectorBase>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Context object2 = Java.Lang.Object.GetObject<Context>(native_p0, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_p1, JniHandleOwnership.DoNotTransfer);
			DispatchGroup object3 = Java.Lang.Object.GetObject<DispatchGroup>(native_p3, JniHandleOwnership.DoNotTransfer);
			SignalsResult object4 = Java.Lang.Object.GetObject<SignalsResult>(native_p4, JniHandleOwnership.DoNotTransfer);
			@object.GetSCARSignal(object2, @string, p2, object3, object4);
		}

		// Token: 0x06002766 RID: 10086
		[Register("getSCARSignal", "(Landroid/content/Context;Ljava/lang/String;ZLcom/unity3d/scar/adapter/common/DispatchGroup;Lcom/unity3d/scar/adapter/common/signals/SignalsResult;)V", "GetGetSCARSignal_Landroid_content_Context_Ljava_lang_String_ZLcom_unity3d_scar_adapter_common_DispatchGroup_Lcom_unity3d_scar_adapter_common_signals_SignalsResult_Handler")]
		public abstract void GetSCARSignal(Context p0, string p1, bool p2, DispatchGroup p3, SignalsResult p4);

		// Token: 0x040007DD RID: 2013
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/scar/adapter/common/signals/SignalsCollectorBase", typeof(SignalsCollectorBase));

		// Token: 0x040007DE RID: 2014
		private static Delegate cb_getSCARSignals_Landroid_content_Context_arrayLjava_lang_String_arrayLjava_lang_String_Lcom_unity3d_scar_adapter_common_signals_ISignalCollectionListener_;

		// Token: 0x040007DF RID: 2015
		private static Delegate cb_getSCARSignal_Landroid_content_Context_Ljava_lang_String_ZLcom_unity3d_scar_adapter_common_DispatchGroup_Lcom_unity3d_scar_adapter_common_signals_SignalsResult_;
	}
}
