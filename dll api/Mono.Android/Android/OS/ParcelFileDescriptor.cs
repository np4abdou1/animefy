using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.IO;
using Java.Lang;

namespace Android.OS
{
	// Token: 0x020001F2 RID: 498
	[Register("android/os/ParcelFileDescriptor", DoNotGenerateAcw = true)]
	public class ParcelFileDescriptor : Java.Lang.Object, IParcelable, IJavaObject, IDisposable, IJavaPeerable, ICloseable
	{
		// Token: 0x170003AD RID: 941
		// (get) Token: 0x06001223 RID: 4643 RVA: 0x0002FE2F File Offset: 0x0002E02F
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return ParcelFileDescriptor._members;
			}
		}

		// Token: 0x170003AE RID: 942
		// (get) Token: 0x06001224 RID: 4644 RVA: 0x0002FE38 File Offset: 0x0002E038
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return ParcelFileDescriptor._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170003AF RID: 943
		// (get) Token: 0x06001225 RID: 4645 RVA: 0x0002FE5C File Offset: 0x0002E05C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return ParcelFileDescriptor._members.ManagedPeerType;
			}
		}

		// Token: 0x06001226 RID: 4646 RVA: 0x000021E0 File Offset: 0x000003E0
		protected ParcelFileDescriptor(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06001227 RID: 4647 RVA: 0x0002FE68 File Offset: 0x0002E068
		private static Delegate GetCloseHandler()
		{
			if (ParcelFileDescriptor.cb_close == null)
			{
				ParcelFileDescriptor.cb_close = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(ParcelFileDescriptor.n_Close));
			}
			return ParcelFileDescriptor.cb_close;
		}

		// Token: 0x06001228 RID: 4648 RVA: 0x0002FE8C File Offset: 0x0002E08C
		private static void n_Close(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<ParcelFileDescriptor>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Close();
		}

		// Token: 0x06001229 RID: 4649 RVA: 0x0002FE9B File Offset: 0x0002E09B
		public virtual void Close()
		{
			ParcelFileDescriptor._members.InstanceMethods.InvokeVirtualVoidMethod("close.()V", this, null);
		}

		// Token: 0x0600122A RID: 4650 RVA: 0x0002FEB4 File Offset: 0x0002E0B4
		private static Delegate GetDescribeContentsHandler()
		{
			if (ParcelFileDescriptor.cb_describeContents == null)
			{
				ParcelFileDescriptor.cb_describeContents = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(ParcelFileDescriptor.n_DescribeContents));
			}
			return ParcelFileDescriptor.cb_describeContents;
		}

		// Token: 0x0600122B RID: 4651 RVA: 0x0002FED8 File Offset: 0x0002E0D8
		private static int n_DescribeContents(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<ParcelFileDescriptor>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).DescribeContents();
		}

		// Token: 0x0600122C RID: 4652 RVA: 0x0002FEE7 File Offset: 0x0002E0E7
		public virtual int DescribeContents()
		{
			return ParcelFileDescriptor._members.InstanceMethods.InvokeVirtualInt32Method("describeContents.()I", this, null);
		}

		// Token: 0x0600122D RID: 4653 RVA: 0x0002FF00 File Offset: 0x0002E100
		private static Delegate GetWriteToParcel_Landroid_os_Parcel_IHandler()
		{
			if (ParcelFileDescriptor.cb_writeToParcel_Landroid_os_Parcel_I == null)
			{
				ParcelFileDescriptor.cb_writeToParcel_Landroid_os_Parcel_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLI_V(ParcelFileDescriptor.n_WriteToParcel_Landroid_os_Parcel_I));
			}
			return ParcelFileDescriptor.cb_writeToParcel_Landroid_os_Parcel_I;
		}

		// Token: 0x0600122E RID: 4654 RVA: 0x0002FF24 File Offset: 0x0002E124
		private static void n_WriteToParcel_Landroid_os_Parcel_I(IntPtr jnienv, IntPtr native__this, IntPtr native__out, int native_flags)
		{
			ParcelFileDescriptor @object = Java.Lang.Object.GetObject<ParcelFileDescriptor>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Parcel object2 = Java.Lang.Object.GetObject<Parcel>(native__out, JniHandleOwnership.DoNotTransfer);
			@object.WriteToParcel(object2, (ParcelableWriteFlags)native_flags);
		}

		// Token: 0x0600122F RID: 4655 RVA: 0x0002FF4C File Offset: 0x0002E14C
		public unsafe virtual void WriteToParcel(Parcel @out, [GeneratedEnum] ParcelableWriteFlags flags)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((@out == null) ? IntPtr.Zero : @out.Handle);
				ptr[1] = new JniArgumentValue((int)flags);
				ParcelFileDescriptor._members.InstanceMethods.InvokeVirtualVoidMethod("writeToParcel.(Landroid/os/Parcel;I)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(@out);
			}
		}

		// Token: 0x0400080B RID: 2059
		private static readonly JniPeerMembers _members = new XAPeerMembers("android/os/ParcelFileDescriptor", typeof(ParcelFileDescriptor));

		// Token: 0x0400080C RID: 2060
		private static Delegate cb_close;

		// Token: 0x0400080D RID: 2061
		private static Delegate cb_describeContents;

		// Token: 0x0400080E RID: 2062
		private static Delegate cb_writeToParcel_Landroid_os_Parcel_I;
	}
}
