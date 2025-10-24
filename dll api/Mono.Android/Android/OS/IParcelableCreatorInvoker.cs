using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Android.OS
{
	// Token: 0x020001EB RID: 491
	[Register("android/os/Parcelable$Creator", DoNotGenerateAcw = true)]
	internal class IParcelableCreatorInvoker : Java.Lang.Object, IParcelableCreator, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000398 RID: 920
		// (get) Token: 0x060011EB RID: 4587 RVA: 0x0002F6B8 File Offset: 0x0002D8B8
		private static IntPtr java_class_ref
		{
			get
			{
				return IParcelableCreatorInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000399 RID: 921
		// (get) Token: 0x060011EC RID: 4588 RVA: 0x0002F6DC File Offset: 0x0002D8DC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IParcelableCreatorInvoker._members;
			}
		}

		// Token: 0x1700039A RID: 922
		// (get) Token: 0x060011ED RID: 4589 RVA: 0x0002F6E3 File Offset: 0x0002D8E3
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x1700039B RID: 923
		// (get) Token: 0x060011EE RID: 4590 RVA: 0x0002F6EB File Offset: 0x0002D8EB
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IParcelableCreatorInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x060011EF RID: 4591 RVA: 0x0002F6F7 File Offset: 0x0002D8F7
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IParcelableCreatorInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'android.os.Parcelable.Creator'.");
			}
			return handle;
		}

		// Token: 0x060011F0 RID: 4592 RVA: 0x0002F722 File Offset: 0x0002D922
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x060011F1 RID: 4593 RVA: 0x0002F754 File Offset: 0x0002D954
		public IParcelableCreatorInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IParcelableCreatorInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x060011F2 RID: 4594 RVA: 0x0002F78C File Offset: 0x0002D98C
		private static Delegate GetCreateFromParcel_Landroid_os_Parcel_Handler()
		{
			if (IParcelableCreatorInvoker.cb_createFromParcel_Landroid_os_Parcel_ == null)
			{
				IParcelableCreatorInvoker.cb_createFromParcel_Landroid_os_Parcel_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(IParcelableCreatorInvoker.n_CreateFromParcel_Landroid_os_Parcel_));
			}
			return IParcelableCreatorInvoker.cb_createFromParcel_Landroid_os_Parcel_;
		}

		// Token: 0x060011F3 RID: 4595 RVA: 0x0002F7B0 File Offset: 0x0002D9B0
		private static IntPtr n_CreateFromParcel_Landroid_os_Parcel_(IntPtr jnienv, IntPtr native__this, IntPtr native_source)
		{
			IParcelableCreator @object = Java.Lang.Object.GetObject<IParcelableCreator>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Parcel object2 = Java.Lang.Object.GetObject<Parcel>(native_source, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.CreateFromParcel(object2));
		}

		// Token: 0x060011F4 RID: 4596 RVA: 0x0002F7D8 File Offset: 0x0002D9D8
		public unsafe Java.Lang.Object CreateFromParcel(Parcel source)
		{
			if (this.id_createFromParcel_Landroid_os_Parcel_ == IntPtr.Zero)
			{
				this.id_createFromParcel_Landroid_os_Parcel_ = JNIEnv.GetMethodID(this.class_ref, "createFromParcel", "(Landroid/os/Parcel;)Ljava/lang/Object;");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((source == null) ? IntPtr.Zero : source.Handle);
			return Java.Lang.Object.GetObject<Java.Lang.Object>(JNIEnv.CallObjectMethod(base.Handle, this.id_createFromParcel_Landroid_os_Parcel_, ptr), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x060011F5 RID: 4597 RVA: 0x0002F851 File Offset: 0x0002DA51
		private static Delegate GetNewArray_IHandler()
		{
			if (IParcelableCreatorInvoker.cb_newArray_I == null)
			{
				IParcelableCreatorInvoker.cb_newArray_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_L(IParcelableCreatorInvoker.n_NewArray_I));
			}
			return IParcelableCreatorInvoker.cb_newArray_I;
		}

		// Token: 0x060011F6 RID: 4598 RVA: 0x0002F875 File Offset: 0x0002DA75
		private static IntPtr n_NewArray_I(IntPtr jnienv, IntPtr native__this, int size)
		{
			return JNIEnv.NewArray<Java.Lang.Object>(Java.Lang.Object.GetObject<IParcelableCreator>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).NewArray(size));
		}

		// Token: 0x060011F7 RID: 4599 RVA: 0x0002F88C File Offset: 0x0002DA8C
		public unsafe Java.Lang.Object[] NewArray(int size)
		{
			if (this.id_newArray_I == IntPtr.Zero)
			{
				this.id_newArray_I = JNIEnv.GetMethodID(this.class_ref, "newArray", "(I)[Ljava/lang/Object;");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(size);
			return (Java.Lang.Object[])JNIEnv.GetArray(JNIEnv.CallObjectMethod(base.Handle, this.id_newArray_I, ptr), JniHandleOwnership.TransferLocalRef, typeof(Java.Lang.Object));
		}

		// Token: 0x040007FB RID: 2043
		private static readonly JniPeerMembers _members = new XAPeerMembers("android/os/Parcelable$Creator", typeof(IParcelableCreatorInvoker));

		// Token: 0x040007FC RID: 2044
		private IntPtr class_ref;

		// Token: 0x040007FD RID: 2045
		private static Delegate cb_createFromParcel_Landroid_os_Parcel_;

		// Token: 0x040007FE RID: 2046
		private IntPtr id_createFromParcel_Landroid_os_Parcel_;

		// Token: 0x040007FF RID: 2047
		private static Delegate cb_newArray_I;

		// Token: 0x04000800 RID: 2048
		private IntPtr id_newArray_I;
	}
}
