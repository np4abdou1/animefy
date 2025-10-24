using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.OS;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Android.Text
{
	// Token: 0x020001A5 RID: 421
	[Register("android/text/ParcelableSpan", DoNotGenerateAcw = true)]
	internal class IParcelableSpanInvoker : Java.Lang.Object, IParcelableSpan, IParcelable, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x170002E8 RID: 744
		// (get) Token: 0x06000ED3 RID: 3795 RVA: 0x000263C8 File Offset: 0x000245C8
		private static IntPtr java_class_ref
		{
			get
			{
				return IParcelableSpanInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170002E9 RID: 745
		// (get) Token: 0x06000ED4 RID: 3796 RVA: 0x000263EC File Offset: 0x000245EC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IParcelableSpanInvoker._members;
			}
		}

		// Token: 0x170002EA RID: 746
		// (get) Token: 0x06000ED5 RID: 3797 RVA: 0x000263F3 File Offset: 0x000245F3
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x170002EB RID: 747
		// (get) Token: 0x06000ED6 RID: 3798 RVA: 0x000263FB File Offset: 0x000245FB
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IParcelableSpanInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06000ED7 RID: 3799 RVA: 0x00026407 File Offset: 0x00024607
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IParcelableSpanInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'android.text.ParcelableSpan'.");
			}
			return handle;
		}

		// Token: 0x06000ED8 RID: 3800 RVA: 0x00026432 File Offset: 0x00024632
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x06000ED9 RID: 3801 RVA: 0x00026464 File Offset: 0x00024664
		public IParcelableSpanInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IParcelableSpanInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x06000EDA RID: 3802 RVA: 0x0002649C File Offset: 0x0002469C
		private static Delegate GetGetSpanTypeIdHandler()
		{
			if (IParcelableSpanInvoker.cb_getSpanTypeId == null)
			{
				IParcelableSpanInvoker.cb_getSpanTypeId = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(IParcelableSpanInvoker.n_GetSpanTypeId));
			}
			return IParcelableSpanInvoker.cb_getSpanTypeId;
		}

		// Token: 0x06000EDB RID: 3803 RVA: 0x000264C0 File Offset: 0x000246C0
		private static int n_GetSpanTypeId(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IParcelableSpan>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SpanTypeId;
		}

		// Token: 0x170002EC RID: 748
		// (get) Token: 0x06000EDC RID: 3804 RVA: 0x000264CF File Offset: 0x000246CF
		public int SpanTypeId
		{
			get
			{
				if (this.id_getSpanTypeId == IntPtr.Zero)
				{
					this.id_getSpanTypeId = JNIEnv.GetMethodID(this.class_ref, "getSpanTypeId", "()I");
				}
				return JNIEnv.CallIntMethod(base.Handle, this.id_getSpanTypeId);
			}
		}

		// Token: 0x06000EDD RID: 3805 RVA: 0x0002650F File Offset: 0x0002470F
		public int DescribeContents()
		{
			if (this.id_describeContents == IntPtr.Zero)
			{
				this.id_describeContents = JNIEnv.GetMethodID(this.class_ref, "describeContents", "()I");
			}
			return JNIEnv.CallIntMethod(base.Handle, this.id_describeContents);
		}

		// Token: 0x06000EDE RID: 3806 RVA: 0x00026550 File Offset: 0x00024750
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

		// Token: 0x040006E5 RID: 1765
		private static readonly JniPeerMembers _members = new XAPeerMembers("android/text/ParcelableSpan", typeof(IParcelableSpanInvoker));

		// Token: 0x040006E6 RID: 1766
		private IntPtr class_ref;

		// Token: 0x040006E7 RID: 1767
		private static Delegate cb_getSpanTypeId;

		// Token: 0x040006E8 RID: 1768
		private IntPtr id_getSpanTypeId;

		// Token: 0x040006E9 RID: 1769
		private IntPtr id_describeContents;

		// Token: 0x040006EA RID: 1770
		private IntPtr id_writeToParcel_Landroid_os_Parcel_I;
	}
}
