using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Com.Unity3d.Scar.Adapter.Common.Signals
{
	// Token: 0x020002B9 RID: 697
	[Register("com/unity3d/scar/adapter/common/signals/SignalsResult", DoNotGenerateAcw = true)]
	public class SignalsResult : Java.Lang.Object
	{
		// Token: 0x17000EEF RID: 3823
		// (get) Token: 0x0600276D RID: 10093 RVA: 0x00065D38 File Offset: 0x00063F38
		internal static IntPtr class_ref
		{
			get
			{
				return SignalsResult._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000EF0 RID: 3824
		// (get) Token: 0x0600276E RID: 10094 RVA: 0x00065D5C File Offset: 0x00063F5C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return SignalsResult._members;
			}
		}

		// Token: 0x17000EF1 RID: 3825
		// (get) Token: 0x0600276F RID: 10095 RVA: 0x00065D64 File Offset: 0x00063F64
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return SignalsResult._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000EF2 RID: 3826
		// (get) Token: 0x06002770 RID: 10096 RVA: 0x00065D88 File Offset: 0x00063F88
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return SignalsResult._members.ManagedPeerType;
			}
		}

		// Token: 0x06002771 RID: 10097 RVA: 0x000021E8 File Offset: 0x000003E8
		protected SignalsResult(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06002772 RID: 10098 RVA: 0x00065D94 File Offset: 0x00063F94
		[Register(".ctor", "()V", "")]
		public SignalsResult() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			base.SetHandle(SignalsResult._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
			SignalsResult._members.InstanceMethods.FinishCreateInstance("()V", this, null);
		}

		// Token: 0x06002773 RID: 10099 RVA: 0x00065E02 File Offset: 0x00064002
		private static Delegate GetGetErrorMessageHandler()
		{
			if (SignalsResult.cb_getErrorMessage == null)
			{
				SignalsResult.cb_getErrorMessage = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(SignalsResult.n_GetErrorMessage));
			}
			return SignalsResult.cb_getErrorMessage;
		}

		// Token: 0x06002774 RID: 10100 RVA: 0x00065E26 File Offset: 0x00064026
		private static IntPtr n_GetErrorMessage(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<SignalsResult>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ErrorMessage);
		}

		// Token: 0x06002775 RID: 10101 RVA: 0x00065E3A File Offset: 0x0006403A
		private static Delegate GetSetErrorMessage_Ljava_lang_String_Handler()
		{
			if (SignalsResult.cb_setErrorMessage_Ljava_lang_String_ == null)
			{
				SignalsResult.cb_setErrorMessage_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(SignalsResult.n_SetErrorMessage_Ljava_lang_String_));
			}
			return SignalsResult.cb_setErrorMessage_Ljava_lang_String_;
		}

		// Token: 0x06002776 RID: 10102 RVA: 0x00065E60 File Offset: 0x00064060
		private static void n_SetErrorMessage_Ljava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native_errorMessage)
		{
			SignalsResult @object = Java.Lang.Object.GetObject<SignalsResult>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_errorMessage, JniHandleOwnership.DoNotTransfer);
			@object.ErrorMessage = @string;
		}

		// Token: 0x17000EF3 RID: 3827
		// (get) Token: 0x06002777 RID: 10103 RVA: 0x00065E84 File Offset: 0x00064084
		// (set) Token: 0x06002778 RID: 10104 RVA: 0x00065EB8 File Offset: 0x000640B8
		public unsafe virtual string ErrorMessage
		{
			[Register("getErrorMessage", "()Ljava/lang/String;", "GetGetErrorMessageHandler")]
			get
			{
				return JNIEnv.GetString(SignalsResult._members.InstanceMethods.InvokeVirtualObjectMethod("getErrorMessage.()Ljava/lang/String;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
			[Register("setErrorMessage", "(Ljava/lang/String;)V", "GetSetErrorMessage_Ljava_lang_String_Handler")]
			set
			{
				IntPtr intPtr = JNIEnv.NewString(value);
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue(intPtr);
					SignalsResult._members.InstanceMethods.InvokeVirtualVoidMethod("setErrorMessage.(Ljava/lang/String;)V", this, ptr);
				}
				finally
				{
					JNIEnv.DeleteLocalRef(intPtr);
				}
			}
		}

		// Token: 0x06002779 RID: 10105 RVA: 0x00065F14 File Offset: 0x00064114
		private static Delegate GetGetSignalsMapHandler()
		{
			if (SignalsResult.cb_getSignalsMap == null)
			{
				SignalsResult.cb_getSignalsMap = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(SignalsResult.n_GetSignalsMap));
			}
			return SignalsResult.cb_getSignalsMap;
		}

		// Token: 0x0600277A RID: 10106 RVA: 0x00065F38 File Offset: 0x00064138
		private static IntPtr n_GetSignalsMap(IntPtr jnienv, IntPtr native__this)
		{
			return JavaDictionary<string, string>.ToLocalJniHandle(Java.Lang.Object.GetObject<SignalsResult>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SignalsMap);
		}

		// Token: 0x17000EF4 RID: 3828
		// (get) Token: 0x0600277B RID: 10107 RVA: 0x00065F4C File Offset: 0x0006414C
		public virtual IDictionary<string, string> SignalsMap
		{
			[Register("getSignalsMap", "()Ljava/util/Map;", "GetGetSignalsMapHandler")]
			get
			{
				return JavaDictionary<string, string>.FromJniHandle(SignalsResult._members.InstanceMethods.InvokeVirtualObjectMethod("getSignalsMap.()Ljava/util/Map;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x0600277C RID: 10108 RVA: 0x00065F7E File Offset: 0x0006417E
		private static Delegate GetAddToSignalsMap_Ljava_lang_String_Ljava_lang_String_Handler()
		{
			if (SignalsResult.cb_addToSignalsMap_Ljava_lang_String_Ljava_lang_String_ == null)
			{
				SignalsResult.cb_addToSignalsMap_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_V(SignalsResult.n_AddToSignalsMap_Ljava_lang_String_Ljava_lang_String_));
			}
			return SignalsResult.cb_addToSignalsMap_Ljava_lang_String_Ljava_lang_String_;
		}

		// Token: 0x0600277D RID: 10109 RVA: 0x00065FA4 File Offset: 0x000641A4
		private static void n_AddToSignalsMap_Ljava_lang_String_Ljava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native_placementId, IntPtr native_signal)
		{
			SignalsResult @object = Java.Lang.Object.GetObject<SignalsResult>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_placementId, JniHandleOwnership.DoNotTransfer);
			string string2 = JNIEnv.GetString(native_signal, JniHandleOwnership.DoNotTransfer);
			@object.AddToSignalsMap(@string, string2);
		}

		// Token: 0x0600277E RID: 10110 RVA: 0x00065FD0 File Offset: 0x000641D0
		[Register("addToSignalsMap", "(Ljava/lang/String;Ljava/lang/String;)V", "GetAddToSignalsMap_Ljava_lang_String_Ljava_lang_String_Handler")]
		public unsafe virtual void AddToSignalsMap(string placementId, string signal)
		{
			IntPtr intPtr = JNIEnv.NewString(placementId);
			IntPtr intPtr2 = JNIEnv.NewString(signal);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(intPtr2);
				SignalsResult._members.InstanceMethods.InvokeVirtualVoidMethod("addToSignalsMap.(Ljava/lang/String;Ljava/lang/String;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				JNIEnv.DeleteLocalRef(intPtr2);
			}
		}

		// Token: 0x040007E1 RID: 2017
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/scar/adapter/common/signals/SignalsResult", typeof(SignalsResult));

		// Token: 0x040007E2 RID: 2018
		private static Delegate cb_getErrorMessage;

		// Token: 0x040007E3 RID: 2019
		private static Delegate cb_setErrorMessage_Ljava_lang_String_;

		// Token: 0x040007E4 RID: 2020
		private static Delegate cb_getSignalsMap;

		// Token: 0x040007E5 RID: 2021
		private static Delegate cb_addToSignalsMap_Ljava_lang_String_Ljava_lang_String_;
	}
}
