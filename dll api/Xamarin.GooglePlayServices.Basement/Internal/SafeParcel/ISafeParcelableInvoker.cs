using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.OS;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Android.Gms.Common.Internal.SafeParcel
{
	// Token: 0x02000019 RID: 25
	[Register("com/google/android/gms/common/internal/safeparcel/SafeParcelable", DoNotGenerateAcw = true)]
	internal class ISafeParcelableInvoker : Java.Lang.Object, ISafeParcelable, IParcelable, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000025 RID: 37
		// (get) Token: 0x0600008F RID: 143 RVA: 0x00003060 File Offset: 0x00001260
		private static IntPtr java_class_ref
		{
			get
			{
				return ISafeParcelableInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x06000090 RID: 144 RVA: 0x00003084 File Offset: 0x00001284
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return ISafeParcelableInvoker._members;
			}
		}

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x06000091 RID: 145 RVA: 0x0000308B File Offset: 0x0000128B
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x06000092 RID: 146 RVA: 0x00003093 File Offset: 0x00001293
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return ISafeParcelableInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06000093 RID: 147 RVA: 0x0000309F File Offset: 0x0000129F
		public static ISafeParcelable GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<ISafeParcelable>(handle, transfer);
		}

		// Token: 0x06000094 RID: 148 RVA: 0x000030A8 File Offset: 0x000012A8
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, ISafeParcelableInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'com.google.android.gms.common.internal.safeparcel.SafeParcelable'.");
			}
			return handle;
		}

		// Token: 0x06000095 RID: 149 RVA: 0x000030D3 File Offset: 0x000012D3
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x06000096 RID: 150 RVA: 0x00003104 File Offset: 0x00001304
		public ISafeParcelableInvoker(IntPtr handle, JniHandleOwnership transfer) : base(ISafeParcelableInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x06000097 RID: 151 RVA: 0x0000313C File Offset: 0x0000133C
		private static Delegate GetDescribeContentsHandler()
		{
			if (ISafeParcelableInvoker.cb_describeContents == null)
			{
				ISafeParcelableInvoker.cb_describeContents = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(ISafeParcelableInvoker.n_DescribeContents));
			}
			return ISafeParcelableInvoker.cb_describeContents;
		}

		// Token: 0x06000098 RID: 152 RVA: 0x00003160 File Offset: 0x00001360
		private static int n_DescribeContents(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<ISafeParcelable>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).DescribeContents();
		}

		// Token: 0x06000099 RID: 153 RVA: 0x0000316F File Offset: 0x0000136F
		public int DescribeContents()
		{
			if (this.id_describeContents == IntPtr.Zero)
			{
				this.id_describeContents = JNIEnv.GetMethodID(this.class_ref, "describeContents", "()I");
			}
			return JNIEnv.CallIntMethod(base.Handle, this.id_describeContents);
		}

		// Token: 0x0600009A RID: 154 RVA: 0x000031AF File Offset: 0x000013AF
		private static Delegate GetWriteToParcel_Landroid_os_Parcel_IHandler()
		{
			if (ISafeParcelableInvoker.cb_writeToParcel_Landroid_os_Parcel_I == null)
			{
				ISafeParcelableInvoker.cb_writeToParcel_Landroid_os_Parcel_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLI_V(ISafeParcelableInvoker.n_WriteToParcel_Landroid_os_Parcel_I));
			}
			return ISafeParcelableInvoker.cb_writeToParcel_Landroid_os_Parcel_I;
		}

		// Token: 0x0600009B RID: 155 RVA: 0x000031D4 File Offset: 0x000013D4
		private static void n_WriteToParcel_Landroid_os_Parcel_I(IntPtr jnienv, IntPtr native__this, IntPtr native_dest, int native_flags)
		{
			IParcelable @object = Java.Lang.Object.GetObject<ISafeParcelable>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Parcel object2 = Java.Lang.Object.GetObject<Parcel>(native_dest, JniHandleOwnership.DoNotTransfer);
			@object.WriteToParcel(object2, (ParcelableWriteFlags)native_flags);
		}

		// Token: 0x0600009C RID: 156 RVA: 0x000031FC File Offset: 0x000013FC
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

		// Token: 0x04000016 RID: 22
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/google/android/gms/common/internal/safeparcel/SafeParcelable", typeof(ISafeParcelableInvoker));

		// Token: 0x04000017 RID: 23
		private IntPtr class_ref;

		// Token: 0x04000018 RID: 24
		private static Delegate cb_describeContents;

		// Token: 0x04000019 RID: 25
		private IntPtr id_describeContents;

		// Token: 0x0400001A RID: 26
		private static Delegate cb_writeToParcel_Landroid_os_Parcel_I;

		// Token: 0x0400001B RID: 27
		private IntPtr id_writeToParcel_Landroid_os_Parcel_I;
	}
}
