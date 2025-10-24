using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Java.Util.Functions
{
	// Token: 0x02000338 RID: 824
	[Register("java/util/function/Predicate", DoNotGenerateAcw = true, ApiSince = 24)]
	internal class IPredicateInvoker : Java.Lang.Object, IPredicate, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x170006BD RID: 1725
		// (get) Token: 0x06002315 RID: 8981 RVA: 0x00062E88 File Offset: 0x00061088
		private static IntPtr java_class_ref
		{
			get
			{
				return IPredicateInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170006BE RID: 1726
		// (get) Token: 0x06002316 RID: 8982 RVA: 0x00062EAC File Offset: 0x000610AC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IPredicateInvoker._members;
			}
		}

		// Token: 0x170006BF RID: 1727
		// (get) Token: 0x06002317 RID: 8983 RVA: 0x00062EB3 File Offset: 0x000610B3
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x170006C0 RID: 1728
		// (get) Token: 0x06002318 RID: 8984 RVA: 0x00062EBB File Offset: 0x000610BB
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IPredicateInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06002319 RID: 8985 RVA: 0x00062EC7 File Offset: 0x000610C7
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IPredicateInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'java.util.function.Predicate'.");
			}
			return handle;
		}

		// Token: 0x0600231A RID: 8986 RVA: 0x00062EF2 File Offset: 0x000610F2
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x0600231B RID: 8987 RVA: 0x00062F24 File Offset: 0x00061124
		public IPredicateInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IPredicateInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x0600231C RID: 8988 RVA: 0x00062F5C File Offset: 0x0006115C
		private static Delegate GetTest_Ljava_lang_Object_Handler()
		{
			if (IPredicateInvoker.cb_test_Ljava_lang_Object_ == null)
			{
				IPredicateInvoker.cb_test_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(IPredicateInvoker.n_Test_Ljava_lang_Object_));
			}
			return IPredicateInvoker.cb_test_Ljava_lang_Object_;
		}

		// Token: 0x0600231D RID: 8989 RVA: 0x00062F80 File Offset: 0x00061180
		private static bool n_Test_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_t)
		{
			IPredicate @object = Java.Lang.Object.GetObject<IPredicate>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_t, JniHandleOwnership.DoNotTransfer);
			return @object.Test(object2);
		}

		// Token: 0x0600231E RID: 8990 RVA: 0x00062FA4 File Offset: 0x000611A4
		public unsafe bool Test(Java.Lang.Object t)
		{
			if (this.id_test_Ljava_lang_Object_ == IntPtr.Zero)
			{
				this.id_test_Ljava_lang_Object_ = JNIEnv.GetMethodID(this.class_ref, "test", "(Ljava/lang/Object;)Z");
			}
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(t);
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(intPtr);
			bool result = JNIEnv.CallBooleanMethod(base.Handle, this.id_test_Ljava_lang_Object_, ptr);
			JNIEnv.DeleteLocalRef(intPtr);
			return result;
		}

		// Token: 0x04000E78 RID: 3704
		private static readonly JniPeerMembers _members = new XAPeerMembers("java/util/function/Predicate", typeof(IPredicateInvoker));

		// Token: 0x04000E79 RID: 3705
		private IntPtr class_ref;

		// Token: 0x04000E7A RID: 3706
		private static Delegate cb_test_Ljava_lang_Object_;

		// Token: 0x04000E7B RID: 3707
		private IntPtr id_test_Ljava_lang_Object_;
	}
}
