using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.OS;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Android.Views
{
	// Token: 0x02000115 RID: 277
	[Register("android/view/DragEvent", DoNotGenerateAcw = true)]
	public class DragEvent : Java.Lang.Object, IParcelable, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000169 RID: 361
		// (get) Token: 0x06000718 RID: 1816 RVA: 0x00010243 File Offset: 0x0000E443
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return DragEvent._members;
			}
		}

		// Token: 0x1700016A RID: 362
		// (get) Token: 0x06000719 RID: 1817 RVA: 0x0001024C File Offset: 0x0000E44C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return DragEvent._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700016B RID: 363
		// (get) Token: 0x0600071A RID: 1818 RVA: 0x00010270 File Offset: 0x0000E470
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return DragEvent._members.ManagedPeerType;
			}
		}

		// Token: 0x0600071B RID: 1819 RVA: 0x000021E0 File Offset: 0x000003E0
		protected DragEvent(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x0600071C RID: 1820 RVA: 0x0001027C File Offset: 0x0000E47C
		private static Delegate GetDescribeContentsHandler()
		{
			if (DragEvent.cb_describeContents == null)
			{
				DragEvent.cb_describeContents = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(DragEvent.n_DescribeContents));
			}
			return DragEvent.cb_describeContents;
		}

		// Token: 0x0600071D RID: 1821 RVA: 0x000102A0 File Offset: 0x0000E4A0
		private static int n_DescribeContents(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<DragEvent>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).DescribeContents();
		}

		// Token: 0x0600071E RID: 1822 RVA: 0x000102AF File Offset: 0x0000E4AF
		public virtual int DescribeContents()
		{
			return DragEvent._members.InstanceMethods.InvokeVirtualInt32Method("describeContents.()I", this, null);
		}

		// Token: 0x0600071F RID: 1823 RVA: 0x000102C8 File Offset: 0x0000E4C8
		private static Delegate GetWriteToParcel_Landroid_os_Parcel_IHandler()
		{
			if (DragEvent.cb_writeToParcel_Landroid_os_Parcel_I == null)
			{
				DragEvent.cb_writeToParcel_Landroid_os_Parcel_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLI_V(DragEvent.n_WriteToParcel_Landroid_os_Parcel_I));
			}
			return DragEvent.cb_writeToParcel_Landroid_os_Parcel_I;
		}

		// Token: 0x06000720 RID: 1824 RVA: 0x000102EC File Offset: 0x0000E4EC
		private static void n_WriteToParcel_Landroid_os_Parcel_I(IntPtr jnienv, IntPtr native__this, IntPtr native_dest, int native_flags)
		{
			DragEvent @object = Java.Lang.Object.GetObject<DragEvent>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Parcel object2 = Java.Lang.Object.GetObject<Parcel>(native_dest, JniHandleOwnership.DoNotTransfer);
			@object.WriteToParcel(object2, (ParcelableWriteFlags)native_flags);
		}

		// Token: 0x06000721 RID: 1825 RVA: 0x00010314 File Offset: 0x0000E514
		public unsafe virtual void WriteToParcel(Parcel dest, [GeneratedEnum] ParcelableWriteFlags flags)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((dest == null) ? IntPtr.Zero : dest.Handle);
				ptr[1] = new JniArgumentValue((int)flags);
				DragEvent._members.InstanceMethods.InvokeVirtualVoidMethod("writeToParcel.(Landroid/os/Parcel;I)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(dest);
			}
		}

		// Token: 0x040001D7 RID: 471
		private static readonly JniPeerMembers _members = new XAPeerMembers("android/view/DragEvent", typeof(DragEvent));

		// Token: 0x040001D8 RID: 472
		private static Delegate cb_describeContents;

		// Token: 0x040001D9 RID: 473
		private static Delegate cb_writeToParcel_Landroid_os_Parcel_I;
	}
}
