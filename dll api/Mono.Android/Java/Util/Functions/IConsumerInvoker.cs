using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Java.Util.Functions
{
	// Token: 0x02000332 RID: 818
	[Register("java/util/function/Consumer", DoNotGenerateAcw = true, ApiSince = 24)]
	internal class IConsumerInvoker : Java.Lang.Object, IConsumer, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x170006B1 RID: 1713
		// (get) Token: 0x060022DD RID: 8925 RVA: 0x000624C0 File Offset: 0x000606C0
		private static IntPtr java_class_ref
		{
			get
			{
				return IConsumerInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170006B2 RID: 1714
		// (get) Token: 0x060022DE RID: 8926 RVA: 0x000624E4 File Offset: 0x000606E4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IConsumerInvoker._members;
			}
		}

		// Token: 0x170006B3 RID: 1715
		// (get) Token: 0x060022DF RID: 8927 RVA: 0x000624EB File Offset: 0x000606EB
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x170006B4 RID: 1716
		// (get) Token: 0x060022E0 RID: 8928 RVA: 0x000624F3 File Offset: 0x000606F3
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IConsumerInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x060022E1 RID: 8929 RVA: 0x000624FF File Offset: 0x000606FF
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IConsumerInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'java.util.function.Consumer'.");
			}
			return handle;
		}

		// Token: 0x060022E2 RID: 8930 RVA: 0x0006252A File Offset: 0x0006072A
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x060022E3 RID: 8931 RVA: 0x0006255C File Offset: 0x0006075C
		public IConsumerInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IConsumerInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x060022E4 RID: 8932 RVA: 0x00062594 File Offset: 0x00060794
		private static Delegate GetAccept_Ljava_lang_Object_Handler()
		{
			if (IConsumerInvoker.cb_accept_Ljava_lang_Object_ == null)
			{
				IConsumerInvoker.cb_accept_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(IConsumerInvoker.n_Accept_Ljava_lang_Object_));
			}
			return IConsumerInvoker.cb_accept_Ljava_lang_Object_;
		}

		// Token: 0x060022E5 RID: 8933 RVA: 0x000625B8 File Offset: 0x000607B8
		private static void n_Accept_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_t)
		{
			IConsumer @object = Java.Lang.Object.GetObject<IConsumer>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_t, JniHandleOwnership.DoNotTransfer);
			@object.Accept(object2);
		}

		// Token: 0x060022E6 RID: 8934 RVA: 0x000625DC File Offset: 0x000607DC
		public unsafe void Accept(Java.Lang.Object t)
		{
			if (this.id_accept_Ljava_lang_Object_ == IntPtr.Zero)
			{
				this.id_accept_Ljava_lang_Object_ = JNIEnv.GetMethodID(this.class_ref, "accept", "(Ljava/lang/Object;)V");
			}
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(t);
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(intPtr);
			JNIEnv.CallVoidMethod(base.Handle, this.id_accept_Ljava_lang_Object_, ptr);
			JNIEnv.DeleteLocalRef(intPtr);
		}

		// Token: 0x04000E65 RID: 3685
		private static readonly JniPeerMembers _members = new XAPeerMembers("java/util/function/Consumer", typeof(IConsumerInvoker));

		// Token: 0x04000E66 RID: 3686
		private IntPtr class_ref;

		// Token: 0x04000E67 RID: 3687
		private static Delegate cb_accept_Ljava_lang_Object_;

		// Token: 0x04000E68 RID: 3688
		private IntPtr id_accept_Ljava_lang_Object_;
	}
}
