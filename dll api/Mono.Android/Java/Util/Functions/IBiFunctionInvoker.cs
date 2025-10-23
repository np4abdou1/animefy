using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Java.Util.Functions
{
	// Token: 0x02000330 RID: 816
	[Register("java/util/function/BiFunction", DoNotGenerateAcw = true, ApiSince = 24)]
	internal class IBiFunctionInvoker : Java.Lang.Object, IBiFunction, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x170006AD RID: 1709
		// (get) Token: 0x060022CD RID: 8909 RVA: 0x00062200 File Offset: 0x00060400
		private static IntPtr java_class_ref
		{
			get
			{
				return IBiFunctionInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170006AE RID: 1710
		// (get) Token: 0x060022CE RID: 8910 RVA: 0x00062224 File Offset: 0x00060424
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IBiFunctionInvoker._members;
			}
		}

		// Token: 0x170006AF RID: 1711
		// (get) Token: 0x060022CF RID: 8911 RVA: 0x0006222B File Offset: 0x0006042B
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x170006B0 RID: 1712
		// (get) Token: 0x060022D0 RID: 8912 RVA: 0x00062233 File Offset: 0x00060433
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IBiFunctionInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x060022D1 RID: 8913 RVA: 0x0006223F File Offset: 0x0006043F
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IBiFunctionInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'java.util.function.BiFunction'.");
			}
			return handle;
		}

		// Token: 0x060022D2 RID: 8914 RVA: 0x0006226A File Offset: 0x0006046A
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x060022D3 RID: 8915 RVA: 0x0006229C File Offset: 0x0006049C
		public IBiFunctionInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IBiFunctionInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x060022D4 RID: 8916 RVA: 0x000622D4 File Offset: 0x000604D4
		private static Delegate GetApply_Ljava_lang_Object_Ljava_lang_Object_Handler()
		{
			if (IBiFunctionInvoker.cb_apply_Ljava_lang_Object_Ljava_lang_Object_ == null)
			{
				IBiFunctionInvoker.cb_apply_Ljava_lang_Object_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_L(IBiFunctionInvoker.n_Apply_Ljava_lang_Object_Ljava_lang_Object_));
			}
			return IBiFunctionInvoker.cb_apply_Ljava_lang_Object_Ljava_lang_Object_;
		}

		// Token: 0x060022D5 RID: 8917 RVA: 0x000622F8 File Offset: 0x000604F8
		private static IntPtr n_Apply_Ljava_lang_Object_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_t, IntPtr native_u)
		{
			IBiFunction @object = Java.Lang.Object.GetObject<IBiFunction>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_t, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object3 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_u, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.Apply(object2, object3));
		}

		// Token: 0x060022D6 RID: 8918 RVA: 0x0006232C File Offset: 0x0006052C
		public unsafe Java.Lang.Object Apply(Java.Lang.Object t, Java.Lang.Object u)
		{
			if (this.id_apply_Ljava_lang_Object_Ljava_lang_Object_ == IntPtr.Zero)
			{
				this.id_apply_Ljava_lang_Object_Ljava_lang_Object_ = JNIEnv.GetMethodID(this.class_ref, "apply", "(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;");
			}
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(t);
			IntPtr intPtr2 = JNIEnv.ToLocalJniHandle(u);
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(intPtr);
			ptr[1] = new JValue(intPtr2);
			Java.Lang.Object @object = Java.Lang.Object.GetObject<Java.Lang.Object>(JNIEnv.CallObjectMethod(base.Handle, this.id_apply_Ljava_lang_Object_Ljava_lang_Object_, ptr), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef(intPtr);
			JNIEnv.DeleteLocalRef(intPtr2);
			return @object;
		}

		// Token: 0x04000E5F RID: 3679
		private static readonly JniPeerMembers _members = new XAPeerMembers("java/util/function/BiFunction", typeof(IBiFunctionInvoker));

		// Token: 0x04000E60 RID: 3680
		private IntPtr class_ref;

		// Token: 0x04000E61 RID: 3681
		private static Delegate cb_apply_Ljava_lang_Object_Ljava_lang_Object_;

		// Token: 0x04000E62 RID: 3682
		private IntPtr id_apply_Ljava_lang_Object_Ljava_lang_Object_;
	}
}
