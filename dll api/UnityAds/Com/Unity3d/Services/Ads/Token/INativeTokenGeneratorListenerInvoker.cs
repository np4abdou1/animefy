using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Com.Unity3d.Services.Ads.Token
{
	// Token: 0x020001DC RID: 476
	[Register("com/unity3d/services/ads/token/INativeTokenGeneratorListener", DoNotGenerateAcw = true)]
	internal class INativeTokenGeneratorListenerInvoker : Java.Lang.Object, INativeTokenGeneratorListener, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x1700079F RID: 1951
		// (get) Token: 0x060015C7 RID: 5575 RVA: 0x0003E7E4 File Offset: 0x0003C9E4
		private static IntPtr java_class_ref
		{
			get
			{
				return INativeTokenGeneratorListenerInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170007A0 RID: 1952
		// (get) Token: 0x060015C8 RID: 5576 RVA: 0x0003E808 File Offset: 0x0003CA08
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return INativeTokenGeneratorListenerInvoker._members;
			}
		}

		// Token: 0x170007A1 RID: 1953
		// (get) Token: 0x060015C9 RID: 5577 RVA: 0x0003E80F File Offset: 0x0003CA0F
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x170007A2 RID: 1954
		// (get) Token: 0x060015CA RID: 5578 RVA: 0x0003E817 File Offset: 0x0003CA17
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return INativeTokenGeneratorListenerInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x060015CB RID: 5579 RVA: 0x0003E823 File Offset: 0x0003CA23
		public static INativeTokenGeneratorListener GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<INativeTokenGeneratorListener>(handle, transfer);
		}

		// Token: 0x060015CC RID: 5580 RVA: 0x0003E82C File Offset: 0x0003CA2C
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, INativeTokenGeneratorListenerInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'com.unity3d.services.ads.token.INativeTokenGeneratorListener'.");
			}
			return handle;
		}

		// Token: 0x060015CD RID: 5581 RVA: 0x0003E857 File Offset: 0x0003CA57
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x060015CE RID: 5582 RVA: 0x0003E888 File Offset: 0x0003CA88
		public INativeTokenGeneratorListenerInvoker(IntPtr handle, JniHandleOwnership transfer) : base(INativeTokenGeneratorListenerInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x060015CF RID: 5583 RVA: 0x0003E8C0 File Offset: 0x0003CAC0
		private static Delegate GetOnReady_Ljava_lang_String_Handler()
		{
			if (INativeTokenGeneratorListenerInvoker.cb_onReady_Ljava_lang_String_ == null)
			{
				INativeTokenGeneratorListenerInvoker.cb_onReady_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(INativeTokenGeneratorListenerInvoker.n_OnReady_Ljava_lang_String_));
			}
			return INativeTokenGeneratorListenerInvoker.cb_onReady_Ljava_lang_String_;
		}

		// Token: 0x060015D0 RID: 5584 RVA: 0x0003E8E4 File Offset: 0x0003CAE4
		private static void n_OnReady_Ljava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			INativeTokenGeneratorListener @object = Java.Lang.Object.GetObject<INativeTokenGeneratorListener>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_p0, JniHandleOwnership.DoNotTransfer);
			@object.OnReady(@string);
		}

		// Token: 0x060015D1 RID: 5585 RVA: 0x0003E908 File Offset: 0x0003CB08
		public unsafe void OnReady(string p0)
		{
			if (this.id_onReady_Ljava_lang_String_ == IntPtr.Zero)
			{
				this.id_onReady_Ljava_lang_String_ = JNIEnv.GetMethodID(this.class_ref, "onReady", "(Ljava/lang/String;)V");
			}
			IntPtr intPtr = JNIEnv.NewString(p0);
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(intPtr);
			JNIEnv.CallVoidMethod(base.Handle, this.id_onReady_Ljava_lang_String_, ptr);
			JNIEnv.DeleteLocalRef(intPtr);
		}

		// Token: 0x0400052A RID: 1322
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/services/ads/token/INativeTokenGeneratorListener", typeof(INativeTokenGeneratorListenerInvoker));

		// Token: 0x0400052B RID: 1323
		private IntPtr class_ref;

		// Token: 0x0400052C RID: 1324
		private static Delegate cb_onReady_Ljava_lang_String_;

		// Token: 0x0400052D RID: 1325
		private IntPtr id_onReady_Ljava_lang_String_;
	}
}
