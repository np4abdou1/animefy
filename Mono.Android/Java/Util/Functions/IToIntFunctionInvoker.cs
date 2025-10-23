using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Java.Util.Functions
{
	// Token: 0x0200033C RID: 828
	[Register("java/util/function/ToIntFunction", DoNotGenerateAcw = true, ApiSince = 24)]
	internal class IToIntFunctionInvoker : Java.Lang.Object, IToIntFunction, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x170006C5 RID: 1733
		// (get) Token: 0x0600232D RID: 9005 RVA: 0x000631D8 File Offset: 0x000613D8
		private static IntPtr java_class_ref
		{
			get
			{
				return IToIntFunctionInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170006C6 RID: 1734
		// (get) Token: 0x0600232E RID: 9006 RVA: 0x000631FC File Offset: 0x000613FC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IToIntFunctionInvoker._members;
			}
		}

		// Token: 0x170006C7 RID: 1735
		// (get) Token: 0x0600232F RID: 9007 RVA: 0x00063203 File Offset: 0x00061403
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x170006C8 RID: 1736
		// (get) Token: 0x06002330 RID: 9008 RVA: 0x0006320B File Offset: 0x0006140B
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IToIntFunctionInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06002331 RID: 9009 RVA: 0x00063217 File Offset: 0x00061417
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IToIntFunctionInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'java.util.function.ToIntFunction'.");
			}
			return handle;
		}

		// Token: 0x06002332 RID: 9010 RVA: 0x00063242 File Offset: 0x00061442
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x06002333 RID: 9011 RVA: 0x00063274 File Offset: 0x00061474
		public IToIntFunctionInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IToIntFunctionInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x06002334 RID: 9012 RVA: 0x000632AC File Offset: 0x000614AC
		private static Delegate GetApplyAsInt_Ljava_lang_Object_Handler()
		{
			if (IToIntFunctionInvoker.cb_applyAsInt_Ljava_lang_Object_ == null)
			{
				IToIntFunctionInvoker.cb_applyAsInt_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_I(IToIntFunctionInvoker.n_ApplyAsInt_Ljava_lang_Object_));
			}
			return IToIntFunctionInvoker.cb_applyAsInt_Ljava_lang_Object_;
		}

		// Token: 0x06002335 RID: 9013 RVA: 0x000632D0 File Offset: 0x000614D0
		private static int n_ApplyAsInt_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_value)
		{
			IToIntFunction @object = Java.Lang.Object.GetObject<IToIntFunction>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_value, JniHandleOwnership.DoNotTransfer);
			return @object.ApplyAsInt(object2);
		}

		// Token: 0x06002336 RID: 9014 RVA: 0x000632F4 File Offset: 0x000614F4
		public unsafe int ApplyAsInt(Java.Lang.Object value)
		{
			if (this.id_applyAsInt_Ljava_lang_Object_ == IntPtr.Zero)
			{
				this.id_applyAsInt_Ljava_lang_Object_ = JNIEnv.GetMethodID(this.class_ref, "applyAsInt", "(Ljava/lang/Object;)I");
			}
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(value);
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(intPtr);
			int result = JNIEnv.CallIntMethod(base.Handle, this.id_applyAsInt_Ljava_lang_Object_, ptr);
			JNIEnv.DeleteLocalRef(intPtr);
			return result;
		}

		// Token: 0x04000E80 RID: 3712
		private static readonly JniPeerMembers _members = new XAPeerMembers("java/util/function/ToIntFunction", typeof(IToIntFunctionInvoker));

		// Token: 0x04000E81 RID: 3713
		private IntPtr class_ref;

		// Token: 0x04000E82 RID: 3714
		private static Delegate cb_applyAsInt_Ljava_lang_Object_;

		// Token: 0x04000E83 RID: 3715
		private IntPtr id_applyAsInt_Ljava_lang_Object_;
	}
}
