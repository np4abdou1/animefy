using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Kotlin.Jvm.Functions
{
	// Token: 0x020001FF RID: 511
	[Register("kotlin/jvm/functions/Function2", DoNotGenerateAcw = true)]
	internal class IFunction2Invoker : Java.Lang.Object, IFunction2, IFunction, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x170006E5 RID: 1765
		// (get) Token: 0x0600184D RID: 6221 RVA: 0x000508D8 File Offset: 0x0004EAD8
		private static IntPtr java_class_ref
		{
			get
			{
				return IFunction2Invoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170006E6 RID: 1766
		// (get) Token: 0x0600184E RID: 6222 RVA: 0x000508FC File Offset: 0x0004EAFC
		[Nullable(1)]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			[NullableContext(1)]
			get
			{
				return IFunction2Invoker._members;
			}
		}

		// Token: 0x170006E7 RID: 1767
		// (get) Token: 0x0600184F RID: 6223 RVA: 0x00050903 File Offset: 0x0004EB03
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x170006E8 RID: 1768
		// (get) Token: 0x06001850 RID: 6224 RVA: 0x0005090B File Offset: 0x0004EB0B
		[Nullable(1)]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			[NullableContext(1)]
			get
			{
				return IFunction2Invoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06001851 RID: 6225 RVA: 0x00050917 File Offset: 0x0004EB17
		[NullableContext(2)]
		public static IFunction2 GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IFunction2>(handle, transfer);
		}

		// Token: 0x06001852 RID: 6226 RVA: 0x00050920 File Offset: 0x0004EB20
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IFunction2Invoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'kotlin.jvm.functions.Function2'.");
			}
			return handle;
		}

		// Token: 0x06001853 RID: 6227 RVA: 0x0005094B File Offset: 0x0004EB4B
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x06001854 RID: 6228 RVA: 0x0005097C File Offset: 0x0004EB7C
		public IFunction2Invoker(IntPtr handle, JniHandleOwnership transfer) : base(IFunction2Invoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x06001855 RID: 6229 RVA: 0x000509B4 File Offset: 0x0004EBB4
		[NullableContext(1)]
		private static Delegate GetInvoke_Ljava_lang_Object_Ljava_lang_Object_Handler()
		{
			if (IFunction2Invoker.cb_invoke_Ljava_lang_Object_Ljava_lang_Object_ == null)
			{
				IFunction2Invoker.cb_invoke_Ljava_lang_Object_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_L(IFunction2Invoker.n_Invoke_Ljava_lang_Object_Ljava_lang_Object_));
			}
			return IFunction2Invoker.cb_invoke_Ljava_lang_Object_Ljava_lang_Object_;
		}

		// Token: 0x06001856 RID: 6230 RVA: 0x000509D8 File Offset: 0x0004EBD8
		private static IntPtr n_Invoke_Ljava_lang_Object_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			IFunction2 @object = Java.Lang.Object.GetObject<IFunction2>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_p0, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object3 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_p1, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.Invoke(object2, object3));
		}

		// Token: 0x06001857 RID: 6231 RVA: 0x00050A0C File Offset: 0x0004EC0C
		[NullableContext(2)]
		public unsafe Java.Lang.Object Invoke(Java.Lang.Object p0, Java.Lang.Object p1)
		{
			if (this.id_invoke_Ljava_lang_Object_Ljava_lang_Object_ == IntPtr.Zero)
			{
				this.id_invoke_Ljava_lang_Object_Ljava_lang_Object_ = JNIEnv.GetMethodID(this.class_ref, "invoke", "(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;");
			}
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(p0);
			IntPtr intPtr2 = JNIEnv.ToLocalJniHandle(p1);
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(intPtr);
			ptr[1] = new JValue(intPtr2);
			Java.Lang.Object @object = Java.Lang.Object.GetObject<Java.Lang.Object>(JNIEnv.CallObjectMethod(base.Handle, this.id_invoke_Ljava_lang_Object_Ljava_lang_Object_, ptr), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef(intPtr);
			JNIEnv.DeleteLocalRef(intPtr2);
			return @object;
		}

		// Token: 0x0400078D RID: 1933
		[Nullable(1)]
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/jvm/functions/Function2", typeof(IFunction2Invoker));

		// Token: 0x0400078E RID: 1934
		private IntPtr class_ref;

		// Token: 0x0400078F RID: 1935
		[Nullable(2)]
		private static Delegate cb_invoke_Ljava_lang_Object_Ljava_lang_Object_;

		// Token: 0x04000790 RID: 1936
		private IntPtr id_invoke_Ljava_lang_Object_Ljava_lang_Object_;
	}
}
