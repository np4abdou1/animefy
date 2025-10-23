using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.OS;
using Android.Runtime;
using Java.Interop;
using Java.Lang;
using Java.Util;

namespace Android.Content.Res
{
	// Token: 0x020002A9 RID: 681
	[Register("android/content/res/Configuration", DoNotGenerateAcw = true)]
	public sealed class Configuration : Java.Lang.Object, IParcelable, IJavaObject, IDisposable, IJavaPeerable, Java.Lang.IComparable
	{
		// Token: 0x1700059C RID: 1436
		// (set) Token: 0x06001A2D RID: 6701 RVA: 0x00043EA4 File Offset: 0x000420A4
		[Register("locale")]
		public Locale Locale
		{
			set
			{
				IntPtr intPtr = JNIEnv.ToLocalJniHandle(value);
				try
				{
					Configuration._members.InstanceFields.SetValue("locale.Ljava/util/Locale;", this, new JniObjectReference(intPtr, JniObjectReferenceType.Invalid));
				}
				finally
				{
					JNIEnv.DeleteLocalRef(intPtr);
				}
			}
		}

		// Token: 0x1700059D RID: 1437
		// (get) Token: 0x06001A2E RID: 6702 RVA: 0x00043EF0 File Offset: 0x000420F0
		[GeneratedEnum]
		[Register("orientation")]
		public Orientation Orientation
		{
			get
			{
				return (Orientation)Configuration._members.InstanceFields.GetInt32Value("orientation.I", this);
			}
		}

		// Token: 0x1700059E RID: 1438
		// (get) Token: 0x06001A2F RID: 6703 RVA: 0x00043F07 File Offset: 0x00042107
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return Configuration._members;
			}
		}

		// Token: 0x1700059F RID: 1439
		// (get) Token: 0x06001A30 RID: 6704 RVA: 0x00043F10 File Offset: 0x00042110
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return Configuration._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170005A0 RID: 1440
		// (get) Token: 0x06001A31 RID: 6705 RVA: 0x00043F34 File Offset: 0x00042134
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return Configuration._members.ManagedPeerType;
			}
		}

		// Token: 0x06001A32 RID: 6706 RVA: 0x000021E0 File Offset: 0x000003E0
		internal Configuration(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06001A33 RID: 6707 RVA: 0x00043F40 File Offset: 0x00042140
		public Configuration() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			base.SetHandle(Configuration._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
			Configuration._members.InstanceMethods.FinishCreateInstance("()V", this, null);
		}

		// Token: 0x06001A34 RID: 6708 RVA: 0x00043FB0 File Offset: 0x000421B0
		public unsafe int CompareTo(Configuration that)
		{
			int result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((that == null) ? IntPtr.Zero : that.Handle);
				result = Configuration._members.InstanceMethods.InvokeAbstractInt32Method("compareTo.(Landroid/content/res/Configuration;)I", this, ptr);
			}
			finally
			{
				GC.KeepAlive(that);
			}
			return result;
		}

		// Token: 0x06001A35 RID: 6709 RVA: 0x00044018 File Offset: 0x00042218
		public int DescribeContents()
		{
			return Configuration._members.InstanceMethods.InvokeAbstractInt32Method("describeContents.()I", this, null);
		}

		// Token: 0x06001A36 RID: 6710 RVA: 0x00044034 File Offset: 0x00042234
		public unsafe void SetLocale(Locale loc)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((loc == null) ? IntPtr.Zero : loc.Handle);
				Configuration._members.InstanceMethods.InvokeAbstractVoidMethod("setLocale.(Ljava/util/Locale;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(loc);
			}
		}

		// Token: 0x06001A37 RID: 6711 RVA: 0x00044098 File Offset: 0x00042298
		public unsafe void WriteToParcel(Parcel dest, [GeneratedEnum] ParcelableWriteFlags flags)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((dest == null) ? IntPtr.Zero : dest.Handle);
				ptr[1] = new JniArgumentValue((int)flags);
				Configuration._members.InstanceMethods.InvokeAbstractVoidMethod("writeToParcel.(Landroid/os/Parcel;I)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(dest);
			}
		}

		// Token: 0x06001A38 RID: 6712 RVA: 0x00044110 File Offset: 0x00042310
		int Java.Lang.IComparable.CompareTo(Java.Lang.Object o)
		{
			return this.CompareTo(o.JavaCast<Configuration>());
		}

		// Token: 0x04000B24 RID: 2852
		private static readonly JniPeerMembers _members = new XAPeerMembers("android/content/res/Configuration", typeof(Configuration));
	}
}
