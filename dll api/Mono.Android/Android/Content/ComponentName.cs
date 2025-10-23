using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.OS;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Android.Content
{
	// Token: 0x0200027E RID: 638
	[Register("android/content/ComponentName", DoNotGenerateAcw = true)]
	public sealed class ComponentName : Java.Lang.Object, IParcelable, IJavaObject, IDisposable, IJavaPeerable, Java.Lang.ICloneable, Java.Lang.IComparable
	{
		// Token: 0x17000530 RID: 1328
		// (get) Token: 0x0600182B RID: 6187 RVA: 0x0003E87F File Offset: 0x0003CA7F
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return ComponentName._members;
			}
		}

		// Token: 0x17000531 RID: 1329
		// (get) Token: 0x0600182C RID: 6188 RVA: 0x0003E888 File Offset: 0x0003CA88
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return ComponentName._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000532 RID: 1330
		// (get) Token: 0x0600182D RID: 6189 RVA: 0x0003E8AC File Offset: 0x0003CAAC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return ComponentName._members.ManagedPeerType;
			}
		}

		// Token: 0x0600182E RID: 6190 RVA: 0x000021E0 File Offset: 0x000003E0
		internal ComponentName(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x0600182F RID: 6191 RVA: 0x0003E8B8 File Offset: 0x0003CAB8
		public unsafe int CompareTo(ComponentName that)
		{
			int result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((that == null) ? IntPtr.Zero : that.Handle);
				result = ComponentName._members.InstanceMethods.InvokeAbstractInt32Method("compareTo.(Landroid/content/ComponentName;)I", this, ptr);
			}
			finally
			{
				GC.KeepAlive(that);
			}
			return result;
		}

		// Token: 0x06001830 RID: 6192 RVA: 0x0003E920 File Offset: 0x0003CB20
		public int DescribeContents()
		{
			return ComponentName._members.InstanceMethods.InvokeAbstractInt32Method("describeContents.()I", this, null);
		}

		// Token: 0x06001831 RID: 6193 RVA: 0x0003E93C File Offset: 0x0003CB3C
		public unsafe void WriteToParcel(Parcel @out, [GeneratedEnum] ParcelableWriteFlags flags)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((@out == null) ? IntPtr.Zero : @out.Handle);
				ptr[1] = new JniArgumentValue((int)flags);
				ComponentName._members.InstanceMethods.InvokeAbstractVoidMethod("writeToParcel.(Landroid/os/Parcel;I)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(@out);
			}
		}

		// Token: 0x06001832 RID: 6194 RVA: 0x0003E9B4 File Offset: 0x0003CBB4
		int Java.Lang.IComparable.CompareTo(Java.Lang.Object o)
		{
			return this.CompareTo(o.JavaCast<ComponentName>());
		}

		// Token: 0x04000A48 RID: 2632
		private static readonly JniPeerMembers _members = new XAPeerMembers("android/content/ComponentName", typeof(ComponentName));
	}
}
