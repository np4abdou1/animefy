using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.OS;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Android.Graphics
{
	// Token: 0x0200022C RID: 556
	[Register("android/graphics/Rect", DoNotGenerateAcw = true)]
	public sealed class Rect : Java.Lang.Object, IParcelable, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000444 RID: 1092
		// (set) Token: 0x060013A3 RID: 5027 RVA: 0x00032EAB File Offset: 0x000310AB
		[Register("left")]
		public int Left
		{
			set
			{
				Rect._members.InstanceFields.SetValue("left.I", this, value);
			}
		}

		// Token: 0x17000445 RID: 1093
		// (set) Token: 0x060013A4 RID: 5028 RVA: 0x00032EC3 File Offset: 0x000310C3
		[Register("right")]
		public int Right
		{
			set
			{
				Rect._members.InstanceFields.SetValue("right.I", this, value);
			}
		}

		// Token: 0x17000446 RID: 1094
		// (get) Token: 0x060013A5 RID: 5029 RVA: 0x00032EDB File Offset: 0x000310DB
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return Rect._members;
			}
		}

		// Token: 0x17000447 RID: 1095
		// (get) Token: 0x060013A6 RID: 5030 RVA: 0x00032EE4 File Offset: 0x000310E4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return Rect._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000448 RID: 1096
		// (get) Token: 0x060013A7 RID: 5031 RVA: 0x00032F08 File Offset: 0x00031108
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return Rect._members.ManagedPeerType;
			}
		}

		// Token: 0x060013A8 RID: 5032 RVA: 0x000021E0 File Offset: 0x000003E0
		internal Rect(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x060013A9 RID: 5033 RVA: 0x00032F14 File Offset: 0x00031114
		public int DescribeContents()
		{
			return Rect._members.InstanceMethods.InvokeAbstractInt32Method("describeContents.()I", this, null);
		}

		// Token: 0x060013AA RID: 5034 RVA: 0x00032F30 File Offset: 0x00031130
		public unsafe void WriteToParcel(Parcel @out, [GeneratedEnum] ParcelableWriteFlags flags)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((@out == null) ? IntPtr.Zero : @out.Handle);
				ptr[1] = new JniArgumentValue((int)flags);
				Rect._members.InstanceMethods.InvokeAbstractVoidMethod("writeToParcel.(Landroid/os/Parcel;I)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(@out);
			}
		}

		// Token: 0x040008AA RID: 2218
		private static readonly JniPeerMembers _members = new XAPeerMembers("android/graphics/Rect", typeof(Rect));
	}
}
