using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Android.OS
{
	// Token: 0x020001ED RID: 493
	[Register("android/os/Parcelable", DoNotGenerateAcw = true)]
	internal class IParcelableInvoker : Java.Lang.Object, IParcelable, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x1700039C RID: 924
		// (get) Token: 0x060011FB RID: 4603 RVA: 0x0002F920 File Offset: 0x0002DB20
		private static IntPtr java_class_ref
		{
			get
			{
				return IParcelableInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700039D RID: 925
		// (get) Token: 0x060011FC RID: 4604 RVA: 0x0002F944 File Offset: 0x0002DB44
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IParcelableInvoker._members;
			}
		}

		// Token: 0x1700039E RID: 926
		// (get) Token: 0x060011FD RID: 4605 RVA: 0x0002F94B File Offset: 0x0002DB4B
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x1700039F RID: 927
		// (get) Token: 0x060011FE RID: 4606 RVA: 0x0002F953 File Offset: 0x0002DB53
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IParcelableInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x060011FF RID: 4607 RVA: 0x0002F95F File Offset: 0x0002DB5F
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IParcelableInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'android.os.Parcelable'.");
			}
			return handle;
		}

		// Token: 0x06001200 RID: 4608 RVA: 0x0002F98A File Offset: 0x0002DB8A
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x06001201 RID: 4609 RVA: 0x0002F9BC File Offset: 0x0002DBBC
		public IParcelableInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IParcelableInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x06001202 RID: 4610 RVA: 0x0002F9F4 File Offset: 0x0002DBF4
		private static Delegate GetDescribeContentsHandler()
		{
			if (IParcelableInvoker.cb_describeContents == null)
			{
				IParcelableInvoker.cb_describeContents = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(IParcelableInvoker.n_DescribeContents));
			}
			return IParcelableInvoker.cb_describeContents;
		}

		// Token: 0x06001203 RID: 4611 RVA: 0x0002FA18 File Offset: 0x0002DC18
		private static int n_DescribeContents(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IParcelable>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).DescribeContents();
		}

		// Token: 0x06001204 RID: 4612 RVA: 0x0002FA27 File Offset: 0x0002DC27
		public int DescribeContents()
		{
			if (this.id_describeContents == IntPtr.Zero)
			{
				this.id_describeContents = JNIEnv.GetMethodID(this.class_ref, "describeContents", "()I");
			}
			return JNIEnv.CallIntMethod(base.Handle, this.id_describeContents);
		}

		// Token: 0x06001205 RID: 4613 RVA: 0x0002FA67 File Offset: 0x0002DC67
		private static Delegate GetWriteToParcel_Landroid_os_Parcel_IHandler()
		{
			if (IParcelableInvoker.cb_writeToParcel_Landroid_os_Parcel_I == null)
			{
				IParcelableInvoker.cb_writeToParcel_Landroid_os_Parcel_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLI_V(IParcelableInvoker.n_WriteToParcel_Landroid_os_Parcel_I));
			}
			return IParcelableInvoker.cb_writeToParcel_Landroid_os_Parcel_I;
		}

		// Token: 0x06001206 RID: 4614 RVA: 0x0002FA8C File Offset: 0x0002DC8C
		private static void n_WriteToParcel_Landroid_os_Parcel_I(IntPtr jnienv, IntPtr native__this, IntPtr native_dest, int native_flags)
		{
			IParcelable @object = Java.Lang.Object.GetObject<IParcelable>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Parcel object2 = Java.Lang.Object.GetObject<Parcel>(native_dest, JniHandleOwnership.DoNotTransfer);
			@object.WriteToParcel(object2, (ParcelableWriteFlags)native_flags);
		}

		// Token: 0x06001207 RID: 4615 RVA: 0x0002FAB4 File Offset: 0x0002DCB4
		public unsafe void WriteToParcel(Parcel dest, [GeneratedEnum] ParcelableWriteFlags flags)
		{
			if (this.id_writeToParcel_Landroid_os_Parcel_I == IntPtr.Zero)
			{
				this.id_writeToParcel_Landroid_os_Parcel_I = JNIEnv.GetMethodID(this.class_ref, "writeToParcel", "(Landroid/os/Parcel;I)V");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((dest == null) ? IntPtr.Zero : dest.Handle);
			ptr[1] = new JValue((int)flags);
			JNIEnv.CallVoidMethod(base.Handle, this.id_writeToParcel_Landroid_os_Parcel_I, ptr);
		}

		// Token: 0x04000801 RID: 2049
		private static readonly JniPeerMembers _members = new XAPeerMembers("android/os/Parcelable", typeof(IParcelableInvoker));

		// Token: 0x04000802 RID: 2050
		private IntPtr class_ref;

		// Token: 0x04000803 RID: 2051
		private static Delegate cb_describeContents;

		// Token: 0x04000804 RID: 2052
		private IntPtr id_describeContents;

		// Token: 0x04000805 RID: 2053
		private static Delegate cb_writeToParcel_Landroid_os_Parcel_I;

		// Token: 0x04000806 RID: 2054
		private IntPtr id_writeToParcel_Landroid_os_Parcel_I;
	}
}
