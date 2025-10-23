using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.OS;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Android.Media
{
	// Token: 0x02000209 RID: 521
	[Register("android/media/VolumeShaper", DoNotGenerateAcw = true, ApiSince = 26)]
	public sealed class VolumeShaper : Java.Lang.Object, IAutoCloseable, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x170003E6 RID: 998
		// (get) Token: 0x060012D3 RID: 4819 RVA: 0x0003169A File Offset: 0x0002F89A
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return VolumeShaper._members;
			}
		}

		// Token: 0x170003E7 RID: 999
		// (get) Token: 0x060012D4 RID: 4820 RVA: 0x000316A4 File Offset: 0x0002F8A4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return VolumeShaper._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170003E8 RID: 1000
		// (get) Token: 0x060012D5 RID: 4821 RVA: 0x000316C8 File Offset: 0x0002F8C8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return VolumeShaper._members.ManagedPeerType;
			}
		}

		// Token: 0x060012D6 RID: 4822 RVA: 0x000021E0 File Offset: 0x000003E0
		internal VolumeShaper(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x060012D7 RID: 4823 RVA: 0x000316D4 File Offset: 0x0002F8D4
		public void Close()
		{
			VolumeShaper._members.InstanceMethods.InvokeAbstractVoidMethod("close.()V", this, null);
		}

		// Token: 0x04000867 RID: 2151
		private static readonly JniPeerMembers _members = new XAPeerMembers("android/media/VolumeShaper", typeof(VolumeShaper));

		// Token: 0x0200020A RID: 522
		[Register("android/media/VolumeShaper$Configuration", DoNotGenerateAcw = true, ApiSince = 26)]
		public sealed class Configuration : Java.Lang.Object, IParcelable, IJavaObject, IDisposable, IJavaPeerable
		{
			// Token: 0x170003E9 RID: 1001
			// (get) Token: 0x060012D9 RID: 4825 RVA: 0x00031708 File Offset: 0x0002F908
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return VolumeShaper.Configuration._members;
				}
			}

			// Token: 0x170003EA RID: 1002
			// (get) Token: 0x060012DA RID: 4826 RVA: 0x00031710 File Offset: 0x0002F910
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return VolumeShaper.Configuration._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x170003EB RID: 1003
			// (get) Token: 0x060012DB RID: 4827 RVA: 0x00031734 File Offset: 0x0002F934
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return VolumeShaper.Configuration._members.ManagedPeerType;
				}
			}

			// Token: 0x060012DC RID: 4828 RVA: 0x000021E0 File Offset: 0x000003E0
			internal Configuration(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
			{
			}

			// Token: 0x060012DD RID: 4829 RVA: 0x00031740 File Offset: 0x0002F940
			[Register("describeContents", "()I", "", ApiSince = 26)]
			public int DescribeContents()
			{
				return VolumeShaper.Configuration._members.InstanceMethods.InvokeAbstractInt32Method("describeContents.()I", this, null);
			}

			// Token: 0x060012DE RID: 4830 RVA: 0x0003175C File Offset: 0x0002F95C
			[Register("writeToParcel", "(Landroid/os/Parcel;I)V", "", ApiSince = 26)]
			public unsafe void WriteToParcel(Parcel dest, [GeneratedEnum] ParcelableWriteFlags flags)
			{
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((dest == null) ? IntPtr.Zero : dest.Handle);
					ptr[1] = new JniArgumentValue((int)flags);
					VolumeShaper.Configuration._members.InstanceMethods.InvokeAbstractVoidMethod("writeToParcel.(Landroid/os/Parcel;I)V", this, ptr);
				}
				finally
				{
					GC.KeepAlive(dest);
				}
			}

			// Token: 0x04000868 RID: 2152
			private static readonly JniPeerMembers _members = new XAPeerMembers("android/media/VolumeShaper$Configuration", typeof(VolumeShaper.Configuration));
		}
	}
}
