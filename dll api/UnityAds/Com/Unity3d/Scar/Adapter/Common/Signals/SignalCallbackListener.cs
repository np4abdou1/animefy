using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Com.Unity3d.Scar.Adapter.Common.Signals
{
	// Token: 0x020002B6 RID: 694
	[Register("com/unity3d/scar/adapter/common/signals/SignalCallbackListener", DoNotGenerateAcw = true)]
	[JavaTypeParameters(new string[]
	{
		"T"
	})]
	public class SignalCallbackListener : Java.Lang.Object, ISignalCallbackListener, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000EE5 RID: 3813
		// (get) Token: 0x0600274D RID: 10061 RVA: 0x0006553C File Offset: 0x0006373C
		internal static IntPtr class_ref
		{
			get
			{
				return SignalCallbackListener._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000EE6 RID: 3814
		// (get) Token: 0x0600274E RID: 10062 RVA: 0x00065560 File Offset: 0x00063760
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return SignalCallbackListener._members;
			}
		}

		// Token: 0x17000EE7 RID: 3815
		// (get) Token: 0x0600274F RID: 10063 RVA: 0x00065568 File Offset: 0x00063768
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return SignalCallbackListener._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000EE8 RID: 3816
		// (get) Token: 0x06002750 RID: 10064 RVA: 0x0006558C File Offset: 0x0006378C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return SignalCallbackListener._members.ManagedPeerType;
			}
		}

		// Token: 0x06002751 RID: 10065 RVA: 0x000021E8 File Offset: 0x000003E8
		protected SignalCallbackListener(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06002752 RID: 10066 RVA: 0x00065598 File Offset: 0x00063798
		[Register(".ctor", "(Lcom/unity3d/scar/adapter/common/DispatchGroup;Lcom/unity3d/scar/adapter/common/signals/SignalsResult;)V", "")]
		public unsafe SignalCallbackListener(DispatchGroup dispatchGroup, SignalsResult signalsResult) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((dispatchGroup == null) ? IntPtr.Zero : dispatchGroup.Handle);
				ptr[1] = new JniArgumentValue((signalsResult == null) ? IntPtr.Zero : signalsResult.Handle);
				base.SetHandle(SignalCallbackListener._members.InstanceMethods.StartCreateInstance("(Lcom/unity3d/scar/adapter/common/DispatchGroup;Lcom/unity3d/scar/adapter/common/signals/SignalsResult;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				SignalCallbackListener._members.InstanceMethods.FinishCreateInstance("(Lcom/unity3d/scar/adapter/common/DispatchGroup;Lcom/unity3d/scar/adapter/common/signals/SignalsResult;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(dispatchGroup);
				GC.KeepAlive(signalsResult);
			}
		}

		// Token: 0x06002753 RID: 10067 RVA: 0x00065670 File Offset: 0x00063870
		[Register(".ctor", "(Lcom/unity3d/scar/adapter/common/DispatchGroup;Lcom/unity3d/scar/adapter/common/signals/SignalsStorage;Lcom/unity3d/scar/adapter/common/signals/SignalsResult;)V", "")]
		public unsafe SignalCallbackListener(DispatchGroup dispatchGroup, SignalsStorage signalsStorage, SignalsResult signalsResult) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((dispatchGroup == null) ? IntPtr.Zero : dispatchGroup.Handle);
				ptr[1] = new JniArgumentValue((signalsStorage == null) ? IntPtr.Zero : signalsStorage.Handle);
				ptr[2] = new JniArgumentValue((signalsResult == null) ? IntPtr.Zero : signalsResult.Handle);
				base.SetHandle(SignalCallbackListener._members.InstanceMethods.StartCreateInstance("(Lcom/unity3d/scar/adapter/common/DispatchGroup;Lcom/unity3d/scar/adapter/common/signals/SignalsStorage;Lcom/unity3d/scar/adapter/common/signals/SignalsResult;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				SignalCallbackListener._members.InstanceMethods.FinishCreateInstance("(Lcom/unity3d/scar/adapter/common/DispatchGroup;Lcom/unity3d/scar/adapter/common/signals/SignalsStorage;Lcom/unity3d/scar/adapter/common/signals/SignalsResult;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(dispatchGroup);
				GC.KeepAlive(signalsStorage);
				GC.KeepAlive(signalsResult);
			}
		}

		// Token: 0x06002754 RID: 10068 RVA: 0x00065770 File Offset: 0x00063970
		private static Delegate GetOnFailure_Ljava_lang_String_Handler()
		{
			if (SignalCallbackListener.cb_onFailure_Ljava_lang_String_ == null)
			{
				SignalCallbackListener.cb_onFailure_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(SignalCallbackListener.n_OnFailure_Ljava_lang_String_));
			}
			return SignalCallbackListener.cb_onFailure_Ljava_lang_String_;
		}

		// Token: 0x06002755 RID: 10069 RVA: 0x00065794 File Offset: 0x00063994
		private static void n_OnFailure_Ljava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native_errorMessage)
		{
			SignalCallbackListener @object = Java.Lang.Object.GetObject<SignalCallbackListener>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_errorMessage, JniHandleOwnership.DoNotTransfer);
			@object.OnFailure(@string);
		}

		// Token: 0x06002756 RID: 10070 RVA: 0x000657B8 File Offset: 0x000639B8
		[Register("onFailure", "(Ljava/lang/String;)V", "GetOnFailure_Ljava_lang_String_Handler")]
		public unsafe virtual void OnFailure(string errorMessage)
		{
			IntPtr intPtr = JNIEnv.NewString(errorMessage);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				SignalCallbackListener._members.InstanceMethods.InvokeVirtualVoidMethod("onFailure.(Ljava/lang/String;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
		}

		// Token: 0x06002757 RID: 10071 RVA: 0x00065814 File Offset: 0x00063A14
		private static Delegate GetOnSuccess_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Object_Handler()
		{
			if (SignalCallbackListener.cb_onSuccess_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Object_ == null)
			{
				SignalCallbackListener.cb_onSuccess_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLLL_V(SignalCallbackListener.n_OnSuccess_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Object_));
			}
			return SignalCallbackListener.cb_onSuccess_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Object_;
		}

		// Token: 0x06002758 RID: 10072 RVA: 0x00065838 File Offset: 0x00063A38
		private static void n_OnSuccess_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_placementId, IntPtr native_signal, IntPtr native_queryInfo)
		{
			SignalCallbackListener @object = Java.Lang.Object.GetObject<SignalCallbackListener>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_placementId, JniHandleOwnership.DoNotTransfer);
			string string2 = JNIEnv.GetString(native_signal, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_queryInfo, JniHandleOwnership.DoNotTransfer);
			@object.OnSuccess(@string, string2, object2);
		}

		// Token: 0x06002759 RID: 10073 RVA: 0x00065870 File Offset: 0x00063A70
		[Register("onSuccess", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/Object;)V", "GetOnSuccess_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Object_Handler")]
		public unsafe virtual void OnSuccess(string placementId, string signal, Java.Lang.Object queryInfo)
		{
			IntPtr intPtr = JNIEnv.NewString(placementId);
			IntPtr intPtr2 = JNIEnv.NewString(signal);
			IntPtr intPtr3 = JNIEnv.ToLocalJniHandle(queryInfo);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(intPtr2);
				ptr[2] = new JniArgumentValue(intPtr3);
				SignalCallbackListener._members.InstanceMethods.InvokeVirtualVoidMethod("onSuccess.(Ljava/lang/String;Ljava/lang/String;Ljava/lang/Object;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				JNIEnv.DeleteLocalRef(intPtr2);
				JNIEnv.DeleteLocalRef(intPtr3);
				GC.KeepAlive(queryInfo);
			}
		}

		// Token: 0x040007DA RID: 2010
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/scar/adapter/common/signals/SignalCallbackListener", typeof(SignalCallbackListener));

		// Token: 0x040007DB RID: 2011
		private static Delegate cb_onFailure_Ljava_lang_String_;

		// Token: 0x040007DC RID: 2012
		private static Delegate cb_onSuccess_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Object_;
	}
}
