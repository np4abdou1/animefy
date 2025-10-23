using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;

namespace Java.Lang
{
	// Token: 0x020003D6 RID: 982
	[Register("java/lang/Comparable", DoNotGenerateAcw = true)]
	internal class IComparableInvoker : Object, IComparable, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000875 RID: 2165
		// (get) Token: 0x06002B39 RID: 11065 RVA: 0x00078478 File Offset: 0x00076678
		private static IntPtr java_class_ref
		{
			get
			{
				return IComparableInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000876 RID: 2166
		// (get) Token: 0x06002B3A RID: 11066 RVA: 0x0007849C File Offset: 0x0007669C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IComparableInvoker._members;
			}
		}

		// Token: 0x17000877 RID: 2167
		// (get) Token: 0x06002B3B RID: 11067 RVA: 0x000784A3 File Offset: 0x000766A3
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x17000878 RID: 2168
		// (get) Token: 0x06002B3C RID: 11068 RVA: 0x000784AB File Offset: 0x000766AB
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IComparableInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06002B3D RID: 11069 RVA: 0x000784B7 File Offset: 0x000766B7
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IComparableInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'java.lang.Comparable'.");
			}
			return handle;
		}

		// Token: 0x06002B3E RID: 11070 RVA: 0x000784E2 File Offset: 0x000766E2
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x06002B3F RID: 11071 RVA: 0x00078514 File Offset: 0x00076714
		public IComparableInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IComparableInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x06002B40 RID: 11072 RVA: 0x0007854C File Offset: 0x0007674C
		private static Delegate GetCompareTo_Ljava_lang_Object_Handler()
		{
			if (IComparableInvoker.cb_compareTo_Ljava_lang_Object_ == null)
			{
				IComparableInvoker.cb_compareTo_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_I(IComparableInvoker.n_CompareTo_Ljava_lang_Object_));
			}
			return IComparableInvoker.cb_compareTo_Ljava_lang_Object_;
		}

		// Token: 0x06002B41 RID: 11073 RVA: 0x00078570 File Offset: 0x00076770
		private static int n_CompareTo_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_o)
		{
			IComparable @object = Object.GetObject<IComparable>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Object object2 = Object.GetObject<Object>(native_o, JniHandleOwnership.DoNotTransfer);
			return @object.CompareTo(object2);
		}

		// Token: 0x06002B42 RID: 11074 RVA: 0x00078594 File Offset: 0x00076794
		public unsafe int CompareTo(Object o)
		{
			if (this.id_compareTo_Ljava_lang_Object_ == IntPtr.Zero)
			{
				this.id_compareTo_Ljava_lang_Object_ = JNIEnv.GetMethodID(this.class_ref, "compareTo", "(Ljava/lang/Object;)I");
			}
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(o);
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(intPtr);
			int result = JNIEnv.CallIntMethod(base.Handle, this.id_compareTo_Ljava_lang_Object_, ptr);
			JNIEnv.DeleteLocalRef(intPtr);
			return result;
		}

		// Token: 0x0400115A RID: 4442
		private static readonly JniPeerMembers _members = new XAPeerMembers("java/lang/Comparable", typeof(IComparableInvoker));

		// Token: 0x0400115B RID: 4443
		private IntPtr class_ref;

		// Token: 0x0400115C RID: 4444
		private static Delegate cb_compareTo_Ljava_lang_Object_;

		// Token: 0x0400115D RID: 4445
		private IntPtr id_compareTo_Ljava_lang_Object_;
	}
}
