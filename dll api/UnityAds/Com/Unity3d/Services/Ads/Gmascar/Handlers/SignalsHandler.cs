using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Com.Unity3d.Scar.Adapter.Common.Signals;
using Java.Interop;
using Java.Lang;

namespace Com.Unity3d.Services.Ads.Gmascar.Handlers
{
	// Token: 0x0200020A RID: 522
	[Register("com/unity3d/services/ads/gmascar/handlers/SignalsHandler", DoNotGenerateAcw = true)]
	public class SignalsHandler : Java.Lang.Object, ISignalCollectionListener, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000853 RID: 2131
		// (get) Token: 0x06001857 RID: 6231 RVA: 0x0004649C File Offset: 0x0004469C
		internal static IntPtr class_ref
		{
			get
			{
				return SignalsHandler._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000854 RID: 2132
		// (get) Token: 0x06001858 RID: 6232 RVA: 0x000464C0 File Offset: 0x000446C0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return SignalsHandler._members;
			}
		}

		// Token: 0x17000855 RID: 2133
		// (get) Token: 0x06001859 RID: 6233 RVA: 0x000464C8 File Offset: 0x000446C8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return SignalsHandler._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000856 RID: 2134
		// (get) Token: 0x0600185A RID: 6234 RVA: 0x000464EC File Offset: 0x000446EC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return SignalsHandler._members.ManagedPeerType;
			}
		}

		// Token: 0x0600185B RID: 6235 RVA: 0x000021E8 File Offset: 0x000003E8
		protected SignalsHandler(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x0600185C RID: 6236 RVA: 0x000464F8 File Offset: 0x000446F8
		[Register(".ctor", "()V", "")]
		public SignalsHandler() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			base.SetHandle(SignalsHandler._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
			SignalsHandler._members.InstanceMethods.FinishCreateInstance("()V", this, null);
		}

		// Token: 0x0600185D RID: 6237 RVA: 0x00046566 File Offset: 0x00044766
		private static Delegate GetOnSignalsCollected_Ljava_lang_String_Handler()
		{
			if (SignalsHandler.cb_onSignalsCollected_Ljava_lang_String_ == null)
			{
				SignalsHandler.cb_onSignalsCollected_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(SignalsHandler.n_OnSignalsCollected_Ljava_lang_String_));
			}
			return SignalsHandler.cb_onSignalsCollected_Ljava_lang_String_;
		}

		// Token: 0x0600185E RID: 6238 RVA: 0x0004658C File Offset: 0x0004478C
		private static void n_OnSignalsCollected_Ljava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native_signalsMap)
		{
			SignalsHandler @object = Java.Lang.Object.GetObject<SignalsHandler>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_signalsMap, JniHandleOwnership.DoNotTransfer);
			@object.OnSignalsCollected(@string);
		}

		// Token: 0x0600185F RID: 6239 RVA: 0x000465B0 File Offset: 0x000447B0
		[Register("onSignalsCollected", "(Ljava/lang/String;)V", "GetOnSignalsCollected_Ljava_lang_String_Handler")]
		public unsafe virtual void OnSignalsCollected(string signalsMap)
		{
			IntPtr intPtr = JNIEnv.NewString(signalsMap);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				SignalsHandler._members.InstanceMethods.InvokeVirtualVoidMethod("onSignalsCollected.(Ljava/lang/String;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
		}

		// Token: 0x06001860 RID: 6240 RVA: 0x0004660C File Offset: 0x0004480C
		private static Delegate GetOnSignalsCollectionFailed_Ljava_lang_String_Handler()
		{
			if (SignalsHandler.cb_onSignalsCollectionFailed_Ljava_lang_String_ == null)
			{
				SignalsHandler.cb_onSignalsCollectionFailed_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(SignalsHandler.n_OnSignalsCollectionFailed_Ljava_lang_String_));
			}
			return SignalsHandler.cb_onSignalsCollectionFailed_Ljava_lang_String_;
		}

		// Token: 0x06001861 RID: 6241 RVA: 0x00046630 File Offset: 0x00044830
		private static void n_OnSignalsCollectionFailed_Ljava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native_errorMsg)
		{
			SignalsHandler @object = Java.Lang.Object.GetObject<SignalsHandler>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_errorMsg, JniHandleOwnership.DoNotTransfer);
			@object.OnSignalsCollectionFailed(@string);
		}

		// Token: 0x06001862 RID: 6242 RVA: 0x00046654 File Offset: 0x00044854
		[Register("onSignalsCollectionFailed", "(Ljava/lang/String;)V", "GetOnSignalsCollectionFailed_Ljava_lang_String_Handler")]
		public unsafe virtual void OnSignalsCollectionFailed(string errorMsg)
		{
			IntPtr intPtr = JNIEnv.NewString(errorMsg);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				SignalsHandler._members.InstanceMethods.InvokeVirtualVoidMethod("onSignalsCollectionFailed.(Ljava/lang/String;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
		}

		// Token: 0x040005EE RID: 1518
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/services/ads/gmascar/handlers/SignalsHandler", typeof(SignalsHandler));

		// Token: 0x040005EF RID: 1519
		private static Delegate cb_onSignalsCollected_Ljava_lang_String_;

		// Token: 0x040005F0 RID: 1520
		private static Delegate cb_onSignalsCollectionFailed_Ljava_lang_String_;
	}
}
