using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Com.Unity3d.Services.Ads.Token
{
	// Token: 0x020001DA RID: 474
	[Register("com/unity3d/services/ads/token/INativeTokenGenerator", DoNotGenerateAcw = true)]
	internal class INativeTokenGeneratorInvoker : Java.Lang.Object, INativeTokenGenerator, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x1700079B RID: 1947
		// (get) Token: 0x060015BA RID: 5562 RVA: 0x0003E62C File Offset: 0x0003C82C
		private static IntPtr java_class_ref
		{
			get
			{
				return INativeTokenGeneratorInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700079C RID: 1948
		// (get) Token: 0x060015BB RID: 5563 RVA: 0x0003E650 File Offset: 0x0003C850
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return INativeTokenGeneratorInvoker._members;
			}
		}

		// Token: 0x1700079D RID: 1949
		// (get) Token: 0x060015BC RID: 5564 RVA: 0x0003E657 File Offset: 0x0003C857
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x1700079E RID: 1950
		// (get) Token: 0x060015BD RID: 5565 RVA: 0x0003E65F File Offset: 0x0003C85F
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return INativeTokenGeneratorInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x060015BE RID: 5566 RVA: 0x0003E66B File Offset: 0x0003C86B
		public static INativeTokenGenerator GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<INativeTokenGenerator>(handle, transfer);
		}

		// Token: 0x060015BF RID: 5567 RVA: 0x0003E674 File Offset: 0x0003C874
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, INativeTokenGeneratorInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'com.unity3d.services.ads.token.INativeTokenGenerator'.");
			}
			return handle;
		}

		// Token: 0x060015C0 RID: 5568 RVA: 0x0003E69F File Offset: 0x0003C89F
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x060015C1 RID: 5569 RVA: 0x0003E6D0 File Offset: 0x0003C8D0
		public INativeTokenGeneratorInvoker(IntPtr handle, JniHandleOwnership transfer) : base(INativeTokenGeneratorInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x060015C2 RID: 5570 RVA: 0x0003E708 File Offset: 0x0003C908
		private static Delegate GetGenerateToken_Lcom_unity3d_services_ads_token_INativeTokenGeneratorListener_Handler()
		{
			if (INativeTokenGeneratorInvoker.cb_generateToken_Lcom_unity3d_services_ads_token_INativeTokenGeneratorListener_ == null)
			{
				INativeTokenGeneratorInvoker.cb_generateToken_Lcom_unity3d_services_ads_token_INativeTokenGeneratorListener_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(INativeTokenGeneratorInvoker.n_GenerateToken_Lcom_unity3d_services_ads_token_INativeTokenGeneratorListener_));
			}
			return INativeTokenGeneratorInvoker.cb_generateToken_Lcom_unity3d_services_ads_token_INativeTokenGeneratorListener_;
		}

		// Token: 0x060015C3 RID: 5571 RVA: 0x0003E72C File Offset: 0x0003C92C
		private static void n_GenerateToken_Lcom_unity3d_services_ads_token_INativeTokenGeneratorListener_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			INativeTokenGenerator @object = Java.Lang.Object.GetObject<INativeTokenGenerator>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			INativeTokenGeneratorListener object2 = Java.Lang.Object.GetObject<INativeTokenGeneratorListener>(native_p0, JniHandleOwnership.DoNotTransfer);
			@object.GenerateToken(object2);
		}

		// Token: 0x060015C4 RID: 5572 RVA: 0x0003E750 File Offset: 0x0003C950
		public unsafe void GenerateToken(INativeTokenGeneratorListener p0)
		{
			if (this.id_generateToken_Lcom_unity3d_services_ads_token_INativeTokenGeneratorListener_ == IntPtr.Zero)
			{
				this.id_generateToken_Lcom_unity3d_services_ads_token_INativeTokenGeneratorListener_ = JNIEnv.GetMethodID(this.class_ref, "generateToken", "(Lcom/unity3d/services/ads/token/INativeTokenGeneratorListener;)V");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((p0 == null) ? IntPtr.Zero : ((Java.Lang.Object)p0).Handle);
			JNIEnv.CallVoidMethod(base.Handle, this.id_generateToken_Lcom_unity3d_services_ads_token_INativeTokenGeneratorListener_, ptr);
		}

		// Token: 0x04000526 RID: 1318
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/services/ads/token/INativeTokenGenerator", typeof(INativeTokenGeneratorInvoker));

		// Token: 0x04000527 RID: 1319
		private IntPtr class_ref;

		// Token: 0x04000528 RID: 1320
		private static Delegate cb_generateToken_Lcom_unity3d_services_ads_token_INativeTokenGeneratorListener_;

		// Token: 0x04000529 RID: 1321
		private IntPtr id_generateToken_Lcom_unity3d_services_ads_token_INativeTokenGeneratorListener_;
	}
}
