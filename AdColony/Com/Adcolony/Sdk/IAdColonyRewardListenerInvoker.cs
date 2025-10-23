using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Com.Adcolony.Sdk
{
	// Token: 0x02000051 RID: 81
	[Register("com/adcolony/sdk/AdColonyRewardListener", DoNotGenerateAcw = true)]
	internal class IAdColonyRewardListenerInvoker : Java.Lang.Object, IAdColonyRewardListener, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x1700011D RID: 285
		// (get) Token: 0x06000418 RID: 1048 RVA: 0x0000C908 File Offset: 0x0000AB08
		private static IntPtr java_class_ref
		{
			get
			{
				return IAdColonyRewardListenerInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700011E RID: 286
		// (get) Token: 0x06000419 RID: 1049 RVA: 0x0000C92C File Offset: 0x0000AB2C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IAdColonyRewardListenerInvoker._members;
			}
		}

		// Token: 0x1700011F RID: 287
		// (get) Token: 0x0600041A RID: 1050 RVA: 0x0000C933 File Offset: 0x0000AB33
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x17000120 RID: 288
		// (get) Token: 0x0600041B RID: 1051 RVA: 0x0000C93B File Offset: 0x0000AB3B
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IAdColonyRewardListenerInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x0600041C RID: 1052 RVA: 0x0000C947 File Offset: 0x0000AB47
		public static IAdColonyRewardListener GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IAdColonyRewardListener>(handle, transfer);
		}

		// Token: 0x0600041D RID: 1053 RVA: 0x0000C950 File Offset: 0x0000AB50
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IAdColonyRewardListenerInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'com.adcolony.sdk.AdColonyRewardListener'.");
			}
			return handle;
		}

		// Token: 0x0600041E RID: 1054 RVA: 0x0000C97B File Offset: 0x0000AB7B
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x0600041F RID: 1055 RVA: 0x0000C9AC File Offset: 0x0000ABAC
		public IAdColonyRewardListenerInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IAdColonyRewardListenerInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x06000420 RID: 1056 RVA: 0x0000C9E4 File Offset: 0x0000ABE4
		private static Delegate GetOnReward_Lcom_adcolony_sdk_AdColonyReward_Handler()
		{
			if (IAdColonyRewardListenerInvoker.cb_onReward_Lcom_adcolony_sdk_AdColonyReward_ == null)
			{
				IAdColonyRewardListenerInvoker.cb_onReward_Lcom_adcolony_sdk_AdColonyReward_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(IAdColonyRewardListenerInvoker.n_OnReward_Lcom_adcolony_sdk_AdColonyReward_));
			}
			return IAdColonyRewardListenerInvoker.cb_onReward_Lcom_adcolony_sdk_AdColonyReward_;
		}

		// Token: 0x06000421 RID: 1057 RVA: 0x0000CA08 File Offset: 0x0000AC08
		private static void n_OnReward_Lcom_adcolony_sdk_AdColonyReward_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			IAdColonyRewardListener @object = Java.Lang.Object.GetObject<IAdColonyRewardListener>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			AdColonyReward object2 = Java.Lang.Object.GetObject<AdColonyReward>(native_p0, JniHandleOwnership.DoNotTransfer);
			@object.OnReward(object2);
		}

		// Token: 0x06000422 RID: 1058 RVA: 0x0000CA2C File Offset: 0x0000AC2C
		public unsafe void OnReward(AdColonyReward p0)
		{
			if (this.id_onReward_Lcom_adcolony_sdk_AdColonyReward_ == IntPtr.Zero)
			{
				this.id_onReward_Lcom_adcolony_sdk_AdColonyReward_ = JNIEnv.GetMethodID(this.class_ref, "onReward", "(Lcom/adcolony/sdk/AdColonyReward;)V");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((p0 == null) ? IntPtr.Zero : p0.Handle);
			JNIEnv.CallVoidMethod(base.Handle, this.id_onReward_Lcom_adcolony_sdk_AdColonyReward_, ptr);
		}

		// Token: 0x04000129 RID: 297
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/adcolony/sdk/AdColonyRewardListener", typeof(IAdColonyRewardListenerInvoker));

		// Token: 0x0400012A RID: 298
		private IntPtr class_ref;

		// Token: 0x0400012B RID: 299
		private static Delegate cb_onReward_Lcom_adcolony_sdk_AdColonyReward_;

		// Token: 0x0400012C RID: 300
		private IntPtr id_onReward_Lcom_adcolony_sdk_AdColonyReward_;
	}
}
