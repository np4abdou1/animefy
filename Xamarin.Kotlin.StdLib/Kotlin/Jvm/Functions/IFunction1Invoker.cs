using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Kotlin.Jvm.Functions
{
	// Token: 0x020001E9 RID: 489
	[Register("kotlin/jvm/functions/Function1", DoNotGenerateAcw = true)]
	internal class IFunction1Invoker : Java.Lang.Object, IFunction1, IFunction, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x170006B9 RID: 1721
		// (get) Token: 0x060017BE RID: 6078 RVA: 0x0004DAB0 File Offset: 0x0004BCB0
		private static IntPtr java_class_ref
		{
			get
			{
				return IFunction1Invoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170006BA RID: 1722
		// (get) Token: 0x060017BF RID: 6079 RVA: 0x0004DAD4 File Offset: 0x0004BCD4
		[Nullable(1)]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			[NullableContext(1)]
			get
			{
				return IFunction1Invoker._members;
			}
		}

		// Token: 0x170006BB RID: 1723
		// (get) Token: 0x060017C0 RID: 6080 RVA: 0x0004DADB File Offset: 0x0004BCDB
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x170006BC RID: 1724
		// (get) Token: 0x060017C1 RID: 6081 RVA: 0x0004DAE3 File Offset: 0x0004BCE3
		[Nullable(1)]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			[NullableContext(1)]
			get
			{
				return IFunction1Invoker._members.ManagedPeerType;
			}
		}

		// Token: 0x060017C2 RID: 6082 RVA: 0x0004DAEF File Offset: 0x0004BCEF
		[NullableContext(2)]
		public static IFunction1 GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IFunction1>(handle, transfer);
		}

		// Token: 0x060017C3 RID: 6083 RVA: 0x0004DAF8 File Offset: 0x0004BCF8
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IFunction1Invoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'kotlin.jvm.functions.Function1'.");
			}
			return handle;
		}

		// Token: 0x060017C4 RID: 6084 RVA: 0x0004DB23 File Offset: 0x0004BD23
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x060017C5 RID: 6085 RVA: 0x0004DB54 File Offset: 0x0004BD54
		public IFunction1Invoker(IntPtr handle, JniHandleOwnership transfer) : base(IFunction1Invoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x060017C6 RID: 6086 RVA: 0x0004DB8C File Offset: 0x0004BD8C
		[NullableContext(1)]
		private static Delegate GetInvoke_Ljava_lang_Object_Handler()
		{
			if (IFunction1Invoker.cb_invoke_Ljava_lang_Object_ == null)
			{
				IFunction1Invoker.cb_invoke_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(IFunction1Invoker.n_Invoke_Ljava_lang_Object_));
			}
			return IFunction1Invoker.cb_invoke_Ljava_lang_Object_;
		}

		// Token: 0x060017C7 RID: 6087 RVA: 0x0004DBB0 File Offset: 0x0004BDB0
		private static IntPtr n_Invoke_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			IFunction1 @object = Java.Lang.Object.GetObject<IFunction1>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_p0, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.Invoke(object2));
		}

		// Token: 0x060017C8 RID: 6088 RVA: 0x0004DBD8 File Offset: 0x0004BDD8
		[NullableContext(2)]
		public unsafe Java.Lang.Object Invoke(Java.Lang.Object p0)
		{
			if (this.id_invoke_Ljava_lang_Object_ == IntPtr.Zero)
			{
				this.id_invoke_Ljava_lang_Object_ = JNIEnv.GetMethodID(this.class_ref, "invoke", "(Ljava/lang/Object;)Ljava/lang/Object;");
			}
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(p0);
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(intPtr);
			Java.Lang.Object @object = Java.Lang.Object.GetObject<Java.Lang.Object>(JNIEnv.CallObjectMethod(base.Handle, this.id_invoke_Ljava_lang_Object_, ptr), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef(intPtr);
			return @object;
		}

		// Token: 0x04000761 RID: 1889
		[Nullable(1)]
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/jvm/functions/Function1", typeof(IFunction1Invoker));

		// Token: 0x04000762 RID: 1890
		private IntPtr class_ref;

		// Token: 0x04000763 RID: 1891
		[Nullable(2)]
		private static Delegate cb_invoke_Ljava_lang_Object_;

		// Token: 0x04000764 RID: 1892
		private IntPtr id_invoke_Ljava_lang_Object_;
	}
}
