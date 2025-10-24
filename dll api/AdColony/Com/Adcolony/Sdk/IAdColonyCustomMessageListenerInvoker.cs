using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Com.Adcolony.Sdk
{
	// Token: 0x0200004D RID: 77
	[Register("com/adcolony/sdk/AdColonyCustomMessageListener", DoNotGenerateAcw = true)]
	internal class IAdColonyCustomMessageListenerInvoker : Java.Lang.Object, IAdColonyCustomMessageListener, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000118 RID: 280
		// (get) Token: 0x06000406 RID: 1030 RVA: 0x0000C6D0 File Offset: 0x0000A8D0
		private static IntPtr java_class_ref
		{
			get
			{
				return IAdColonyCustomMessageListenerInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000119 RID: 281
		// (get) Token: 0x06000407 RID: 1031 RVA: 0x0000C6F4 File Offset: 0x0000A8F4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IAdColonyCustomMessageListenerInvoker._members;
			}
		}

		// Token: 0x1700011A RID: 282
		// (get) Token: 0x06000408 RID: 1032 RVA: 0x0000C6FB File Offset: 0x0000A8FB
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x1700011B RID: 283
		// (get) Token: 0x06000409 RID: 1033 RVA: 0x0000C703 File Offset: 0x0000A903
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IAdColonyCustomMessageListenerInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x0600040A RID: 1034 RVA: 0x0000C70F File Offset: 0x0000A90F
		public static IAdColonyCustomMessageListener GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IAdColonyCustomMessageListener>(handle, transfer);
		}

		// Token: 0x0600040B RID: 1035 RVA: 0x0000C718 File Offset: 0x0000A918
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IAdColonyCustomMessageListenerInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'com.adcolony.sdk.AdColonyCustomMessageListener'.");
			}
			return handle;
		}

		// Token: 0x0600040C RID: 1036 RVA: 0x0000C743 File Offset: 0x0000A943
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x0600040D RID: 1037 RVA: 0x0000C774 File Offset: 0x0000A974
		public IAdColonyCustomMessageListenerInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IAdColonyCustomMessageListenerInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x0600040E RID: 1038 RVA: 0x0000C7AC File Offset: 0x0000A9AC
		private static Delegate GetOnAdColonyCustomMessage_Lcom_adcolony_sdk_AdColonyCustomMessage_Handler()
		{
			if (IAdColonyCustomMessageListenerInvoker.cb_onAdColonyCustomMessage_Lcom_adcolony_sdk_AdColonyCustomMessage_ == null)
			{
				IAdColonyCustomMessageListenerInvoker.cb_onAdColonyCustomMessage_Lcom_adcolony_sdk_AdColonyCustomMessage_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(IAdColonyCustomMessageListenerInvoker.n_OnAdColonyCustomMessage_Lcom_adcolony_sdk_AdColonyCustomMessage_));
			}
			return IAdColonyCustomMessageListenerInvoker.cb_onAdColonyCustomMessage_Lcom_adcolony_sdk_AdColonyCustomMessage_;
		}

		// Token: 0x0600040F RID: 1039 RVA: 0x0000C7D0 File Offset: 0x0000A9D0
		private static void n_OnAdColonyCustomMessage_Lcom_adcolony_sdk_AdColonyCustomMessage_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			IAdColonyCustomMessageListener @object = Java.Lang.Object.GetObject<IAdColonyCustomMessageListener>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			AdColonyCustomMessage object2 = Java.Lang.Object.GetObject<AdColonyCustomMessage>(native_p0, JniHandleOwnership.DoNotTransfer);
			@object.OnAdColonyCustomMessage(object2);
		}

		// Token: 0x06000410 RID: 1040 RVA: 0x0000C7F4 File Offset: 0x0000A9F4
		public unsafe void OnAdColonyCustomMessage(AdColonyCustomMessage p0)
		{
			if (this.id_onAdColonyCustomMessage_Lcom_adcolony_sdk_AdColonyCustomMessage_ == IntPtr.Zero)
			{
				this.id_onAdColonyCustomMessage_Lcom_adcolony_sdk_AdColonyCustomMessage_ = JNIEnv.GetMethodID(this.class_ref, "onAdColonyCustomMessage", "(Lcom/adcolony/sdk/AdColonyCustomMessage;)V");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((p0 == null) ? IntPtr.Zero : p0.Handle);
			JNIEnv.CallVoidMethod(base.Handle, this.id_onAdColonyCustomMessage_Lcom_adcolony_sdk_AdColonyCustomMessage_, ptr);
		}

		// Token: 0x04000122 RID: 290
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/adcolony/sdk/AdColonyCustomMessageListener", typeof(IAdColonyCustomMessageListenerInvoker));

		// Token: 0x04000123 RID: 291
		private IntPtr class_ref;

		// Token: 0x04000124 RID: 292
		private static Delegate cb_onAdColonyCustomMessage_Lcom_adcolony_sdk_AdColonyCustomMessage_;

		// Token: 0x04000125 RID: 293
		private IntPtr id_onAdColonyCustomMessage_Lcom_adcolony_sdk_AdColonyCustomMessage_;
	}
}
