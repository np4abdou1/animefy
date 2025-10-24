using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.OS;
using Android.Runtime;
using Java.Interop;
using Java.IO;
using Java.Lang;

namespace Android.Content.Res
{
	// Token: 0x020002A6 RID: 678
	[Register("android/content/res/AssetFileDescriptor", DoNotGenerateAcw = true)]
	public class AssetFileDescriptor : Java.Lang.Object, IParcelable, IJavaObject, IDisposable, IJavaPeerable, ICloseable
	{
		// Token: 0x17000593 RID: 1427
		// (get) Token: 0x06001A0E RID: 6670 RVA: 0x00043B23 File Offset: 0x00041D23
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return AssetFileDescriptor._members;
			}
		}

		// Token: 0x17000594 RID: 1428
		// (get) Token: 0x06001A0F RID: 6671 RVA: 0x00043B2C File Offset: 0x00041D2C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return AssetFileDescriptor._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000595 RID: 1429
		// (get) Token: 0x06001A10 RID: 6672 RVA: 0x00043B50 File Offset: 0x00041D50
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return AssetFileDescriptor._members.ManagedPeerType;
			}
		}

		// Token: 0x06001A11 RID: 6673 RVA: 0x000021E0 File Offset: 0x000003E0
		protected AssetFileDescriptor(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06001A12 RID: 6674 RVA: 0x00043B5C File Offset: 0x00041D5C
		private static Delegate GetCloseHandler()
		{
			if (AssetFileDescriptor.cb_close == null)
			{
				AssetFileDescriptor.cb_close = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(AssetFileDescriptor.n_Close));
			}
			return AssetFileDescriptor.cb_close;
		}

		// Token: 0x06001A13 RID: 6675 RVA: 0x00043B80 File Offset: 0x00041D80
		private static void n_Close(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<AssetFileDescriptor>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Close();
		}

		// Token: 0x06001A14 RID: 6676 RVA: 0x00043B8F File Offset: 0x00041D8F
		public virtual void Close()
		{
			AssetFileDescriptor._members.InstanceMethods.InvokeVirtualVoidMethod("close.()V", this, null);
		}

		// Token: 0x06001A15 RID: 6677 RVA: 0x00043BA8 File Offset: 0x00041DA8
		private static Delegate GetDescribeContentsHandler()
		{
			if (AssetFileDescriptor.cb_describeContents == null)
			{
				AssetFileDescriptor.cb_describeContents = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(AssetFileDescriptor.n_DescribeContents));
			}
			return AssetFileDescriptor.cb_describeContents;
		}

		// Token: 0x06001A16 RID: 6678 RVA: 0x00043BCC File Offset: 0x00041DCC
		private static int n_DescribeContents(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<AssetFileDescriptor>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).DescribeContents();
		}

		// Token: 0x06001A17 RID: 6679 RVA: 0x00043BDB File Offset: 0x00041DDB
		public virtual int DescribeContents()
		{
			return AssetFileDescriptor._members.InstanceMethods.InvokeVirtualInt32Method("describeContents.()I", this, null);
		}

		// Token: 0x06001A18 RID: 6680 RVA: 0x00043BF4 File Offset: 0x00041DF4
		private static Delegate GetWriteToParcel_Landroid_os_Parcel_IHandler()
		{
			if (AssetFileDescriptor.cb_writeToParcel_Landroid_os_Parcel_I == null)
			{
				AssetFileDescriptor.cb_writeToParcel_Landroid_os_Parcel_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLI_V(AssetFileDescriptor.n_WriteToParcel_Landroid_os_Parcel_I));
			}
			return AssetFileDescriptor.cb_writeToParcel_Landroid_os_Parcel_I;
		}

		// Token: 0x06001A19 RID: 6681 RVA: 0x00043C18 File Offset: 0x00041E18
		private static void n_WriteToParcel_Landroid_os_Parcel_I(IntPtr jnienv, IntPtr native__this, IntPtr native__out, int native_flags)
		{
			AssetFileDescriptor @object = Java.Lang.Object.GetObject<AssetFileDescriptor>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Parcel object2 = Java.Lang.Object.GetObject<Parcel>(native__out, JniHandleOwnership.DoNotTransfer);
			@object.WriteToParcel(object2, (ParcelableWriteFlags)native_flags);
		}

		// Token: 0x06001A1A RID: 6682 RVA: 0x00043C40 File Offset: 0x00041E40
		public unsafe virtual void WriteToParcel(Parcel @out, [GeneratedEnum] ParcelableWriteFlags flags)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((@out == null) ? IntPtr.Zero : @out.Handle);
				ptr[1] = new JniArgumentValue((int)flags);
				AssetFileDescriptor._members.InstanceMethods.InvokeVirtualVoidMethod("writeToParcel.(Landroid/os/Parcel;I)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(@out);
			}
		}

		// Token: 0x04000B1C RID: 2844
		private static readonly JniPeerMembers _members = new XAPeerMembers("android/content/res/AssetFileDescriptor", typeof(AssetFileDescriptor));

		// Token: 0x04000B1D RID: 2845
		private static Delegate cb_close;

		// Token: 0x04000B1E RID: 2846
		private static Delegate cb_describeContents;

		// Token: 0x04000B1F RID: 2847
		private static Delegate cb_writeToParcel_Landroid_os_Parcel_I;
	}
}
