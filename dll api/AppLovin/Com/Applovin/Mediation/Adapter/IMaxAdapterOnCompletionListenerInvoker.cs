using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Com.Applovin.Mediation.Adapter
{
	// Token: 0x020000F9 RID: 249
	[Register("com/applovin/mediation/adapter/MaxAdapter$OnCompletionListener", DoNotGenerateAcw = true)]
	internal class IMaxAdapterOnCompletionListenerInvoker : Java.Lang.Object, IMaxAdapterOnCompletionListener, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x170002DC RID: 732
		// (get) Token: 0x06000AA7 RID: 2727 RVA: 0x0001D0E4 File Offset: 0x0001B2E4
		private static IntPtr java_class_ref
		{
			get
			{
				return IMaxAdapterOnCompletionListenerInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170002DD RID: 733
		// (get) Token: 0x06000AA8 RID: 2728 RVA: 0x0001D108 File Offset: 0x0001B308
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IMaxAdapterOnCompletionListenerInvoker._members;
			}
		}

		// Token: 0x170002DE RID: 734
		// (get) Token: 0x06000AA9 RID: 2729 RVA: 0x0001D10F File Offset: 0x0001B30F
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x170002DF RID: 735
		// (get) Token: 0x06000AAA RID: 2730 RVA: 0x0001D117 File Offset: 0x0001B317
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IMaxAdapterOnCompletionListenerInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06000AAB RID: 2731 RVA: 0x0001D123 File Offset: 0x0001B323
		public static IMaxAdapterOnCompletionListener GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IMaxAdapterOnCompletionListener>(handle, transfer);
		}

		// Token: 0x06000AAC RID: 2732 RVA: 0x0001D12C File Offset: 0x0001B32C
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IMaxAdapterOnCompletionListenerInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'com.applovin.mediation.adapter.MaxAdapter.OnCompletionListener'.");
			}
			return handle;
		}

		// Token: 0x06000AAD RID: 2733 RVA: 0x0001D157 File Offset: 0x0001B357
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x06000AAE RID: 2734 RVA: 0x0001D188 File Offset: 0x0001B388
		public IMaxAdapterOnCompletionListenerInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IMaxAdapterOnCompletionListenerInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x06000AAF RID: 2735 RVA: 0x0001D1C0 File Offset: 0x0001B3C0
		private static Delegate GetOnCompletion_Lcom_applovin_mediation_adapter_MaxAdapter_InitializationStatus_Ljava_lang_String_Handler()
		{
			if (IMaxAdapterOnCompletionListenerInvoker.cb_onCompletion_Lcom_applovin_mediation_adapter_MaxAdapter_InitializationStatus_Ljava_lang_String_ == null)
			{
				IMaxAdapterOnCompletionListenerInvoker.cb_onCompletion_Lcom_applovin_mediation_adapter_MaxAdapter_InitializationStatus_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_V(IMaxAdapterOnCompletionListenerInvoker.n_OnCompletion_Lcom_applovin_mediation_adapter_MaxAdapter_InitializationStatus_Ljava_lang_String_));
			}
			return IMaxAdapterOnCompletionListenerInvoker.cb_onCompletion_Lcom_applovin_mediation_adapter_MaxAdapter_InitializationStatus_Ljava_lang_String_;
		}

		// Token: 0x06000AB0 RID: 2736 RVA: 0x0001D1E4 File Offset: 0x0001B3E4
		private static void n_OnCompletion_Lcom_applovin_mediation_adapter_MaxAdapter_InitializationStatus_Ljava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			IMaxAdapterOnCompletionListener @object = Java.Lang.Object.GetObject<IMaxAdapterOnCompletionListener>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			MaxAdapterInitializationStatus object2 = Java.Lang.Object.GetObject<MaxAdapterInitializationStatus>(native_p0, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_p1, JniHandleOwnership.DoNotTransfer);
			@object.OnCompletion(object2, @string);
		}

		// Token: 0x06000AB1 RID: 2737 RVA: 0x0001D210 File Offset: 0x0001B410
		public unsafe void OnCompletion(MaxAdapterInitializationStatus p0, string p1)
		{
			if (this.id_onCompletion_Lcom_applovin_mediation_adapter_MaxAdapter_InitializationStatus_Ljava_lang_String_ == IntPtr.Zero)
			{
				this.id_onCompletion_Lcom_applovin_mediation_adapter_MaxAdapter_InitializationStatus_Ljava_lang_String_ = JNIEnv.GetMethodID(this.class_ref, "onCompletion", "(Lcom/applovin/mediation/adapter/MaxAdapter$InitializationStatus;Ljava/lang/String;)V");
			}
			IntPtr intPtr = JNIEnv.NewString(p1);
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((p0 == null) ? IntPtr.Zero : p0.Handle);
			ptr[1] = new JValue(intPtr);
			JNIEnv.CallVoidMethod(base.Handle, this.id_onCompletion_Lcom_applovin_mediation_adapter_MaxAdapter_InitializationStatus_Ljava_lang_String_, ptr);
			JNIEnv.DeleteLocalRef(intPtr);
		}

		// Token: 0x0400037C RID: 892
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/applovin/mediation/adapter/MaxAdapter$OnCompletionListener", typeof(IMaxAdapterOnCompletionListenerInvoker));

		// Token: 0x0400037D RID: 893
		private IntPtr class_ref;

		// Token: 0x0400037E RID: 894
		private static Delegate cb_onCompletion_Lcom_applovin_mediation_adapter_MaxAdapter_InitializationStatus_Ljava_lang_String_;

		// Token: 0x0400037F RID: 895
		private IntPtr id_onCompletion_Lcom_applovin_mediation_adapter_MaxAdapter_InitializationStatus_Ljava_lang_String_;
	}
}
