using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Java.Util.Functions
{
	// Token: 0x0200032E RID: 814
	[Register("java/util/function/BiConsumer", DoNotGenerateAcw = true, ApiSince = 24)]
	internal class IBiConsumerInvoker : Java.Lang.Object, IBiConsumer, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x170006A9 RID: 1705
		// (get) Token: 0x060022BD RID: 8893 RVA: 0x00061F50 File Offset: 0x00060150
		private static IntPtr java_class_ref
		{
			get
			{
				return IBiConsumerInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170006AA RID: 1706
		// (get) Token: 0x060022BE RID: 8894 RVA: 0x00061F74 File Offset: 0x00060174
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IBiConsumerInvoker._members;
			}
		}

		// Token: 0x170006AB RID: 1707
		// (get) Token: 0x060022BF RID: 8895 RVA: 0x00061F7B File Offset: 0x0006017B
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x170006AC RID: 1708
		// (get) Token: 0x060022C0 RID: 8896 RVA: 0x00061F83 File Offset: 0x00060183
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IBiConsumerInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x060022C1 RID: 8897 RVA: 0x00061F8F File Offset: 0x0006018F
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IBiConsumerInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'java.util.function.BiConsumer'.");
			}
			return handle;
		}

		// Token: 0x060022C2 RID: 8898 RVA: 0x00061FBA File Offset: 0x000601BA
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x060022C3 RID: 8899 RVA: 0x00061FEC File Offset: 0x000601EC
		public IBiConsumerInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IBiConsumerInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x060022C4 RID: 8900 RVA: 0x00062024 File Offset: 0x00060224
		private static Delegate GetAccept_Ljava_lang_Object_Ljava_lang_Object_Handler()
		{
			if (IBiConsumerInvoker.cb_accept_Ljava_lang_Object_Ljava_lang_Object_ == null)
			{
				IBiConsumerInvoker.cb_accept_Ljava_lang_Object_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_V(IBiConsumerInvoker.n_Accept_Ljava_lang_Object_Ljava_lang_Object_));
			}
			return IBiConsumerInvoker.cb_accept_Ljava_lang_Object_Ljava_lang_Object_;
		}

		// Token: 0x060022C5 RID: 8901 RVA: 0x00062048 File Offset: 0x00060248
		private static void n_Accept_Ljava_lang_Object_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_t, IntPtr native_u)
		{
			IBiConsumer @object = Java.Lang.Object.GetObject<IBiConsumer>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_t, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object3 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_u, JniHandleOwnership.DoNotTransfer);
			@object.Accept(object2, object3);
		}

		// Token: 0x060022C6 RID: 8902 RVA: 0x00062074 File Offset: 0x00060274
		public unsafe void Accept(Java.Lang.Object t, Java.Lang.Object u)
		{
			if (this.id_accept_Ljava_lang_Object_Ljava_lang_Object_ == IntPtr.Zero)
			{
				this.id_accept_Ljava_lang_Object_Ljava_lang_Object_ = JNIEnv.GetMethodID(this.class_ref, "accept", "(Ljava/lang/Object;Ljava/lang/Object;)V");
			}
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(t);
			IntPtr intPtr2 = JNIEnv.ToLocalJniHandle(u);
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(intPtr);
			ptr[1] = new JValue(intPtr2);
			JNIEnv.CallVoidMethod(base.Handle, this.id_accept_Ljava_lang_Object_Ljava_lang_Object_, ptr);
			JNIEnv.DeleteLocalRef(intPtr);
			JNIEnv.DeleteLocalRef(intPtr2);
		}

		// Token: 0x04000E59 RID: 3673
		private static readonly JniPeerMembers _members = new XAPeerMembers("java/util/function/BiConsumer", typeof(IBiConsumerInvoker));

		// Token: 0x04000E5A RID: 3674
		private IntPtr class_ref;

		// Token: 0x04000E5B RID: 3675
		private static Delegate cb_accept_Ljava_lang_Object_Ljava_lang_Object_;

		// Token: 0x04000E5C RID: 3676
		private IntPtr id_accept_Ljava_lang_Object_Ljava_lang_Object_;
	}
}
