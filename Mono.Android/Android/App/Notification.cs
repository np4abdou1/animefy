using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.OS;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Android.App
{
	// Token: 0x02000262 RID: 610
	[Register("android/app/Notification", DoNotGenerateAcw = true)]
	public class Notification : Java.Lang.Object, IParcelable, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x170004F3 RID: 1267
		// (get) Token: 0x06001775 RID: 6005 RVA: 0x0003D036 File Offset: 0x0003B236
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return Notification._members;
			}
		}

		// Token: 0x170004F4 RID: 1268
		// (get) Token: 0x06001776 RID: 6006 RVA: 0x0003D040 File Offset: 0x0003B240
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return Notification._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170004F5 RID: 1269
		// (get) Token: 0x06001777 RID: 6007 RVA: 0x0003D064 File Offset: 0x0003B264
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return Notification._members.ManagedPeerType;
			}
		}

		// Token: 0x06001778 RID: 6008 RVA: 0x000021E0 File Offset: 0x000003E0
		protected Notification(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06001779 RID: 6009 RVA: 0x0003D070 File Offset: 0x0003B270
		private static Delegate GetDescribeContentsHandler()
		{
			if (Notification.cb_describeContents == null)
			{
				Notification.cb_describeContents = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(Notification.n_DescribeContents));
			}
			return Notification.cb_describeContents;
		}

		// Token: 0x0600177A RID: 6010 RVA: 0x0003D094 File Offset: 0x0003B294
		private static int n_DescribeContents(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<Notification>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).DescribeContents();
		}

		// Token: 0x0600177B RID: 6011 RVA: 0x0003D0A3 File Offset: 0x0003B2A3
		public virtual int DescribeContents()
		{
			return Notification._members.InstanceMethods.InvokeVirtualInt32Method("describeContents.()I", this, null);
		}

		// Token: 0x0600177C RID: 6012 RVA: 0x0003D0BC File Offset: 0x0003B2BC
		private static Delegate GetWriteToParcel_Landroid_os_Parcel_IHandler()
		{
			if (Notification.cb_writeToParcel_Landroid_os_Parcel_I == null)
			{
				Notification.cb_writeToParcel_Landroid_os_Parcel_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLI_V(Notification.n_WriteToParcel_Landroid_os_Parcel_I));
			}
			return Notification.cb_writeToParcel_Landroid_os_Parcel_I;
		}

		// Token: 0x0600177D RID: 6013 RVA: 0x0003D0E0 File Offset: 0x0003B2E0
		private static void n_WriteToParcel_Landroid_os_Parcel_I(IntPtr jnienv, IntPtr native__this, IntPtr native_parcel, int native_flags)
		{
			Notification @object = Java.Lang.Object.GetObject<Notification>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Parcel object2 = Java.Lang.Object.GetObject<Parcel>(native_parcel, JniHandleOwnership.DoNotTransfer);
			@object.WriteToParcel(object2, (ParcelableWriteFlags)native_flags);
		}

		// Token: 0x0600177E RID: 6014 RVA: 0x0003D108 File Offset: 0x0003B308
		public unsafe virtual void WriteToParcel(Parcel parcel, [GeneratedEnum] ParcelableWriteFlags flags)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((parcel == null) ? IntPtr.Zero : parcel.Handle);
				ptr[1] = new JniArgumentValue((int)flags);
				Notification._members.InstanceMethods.InvokeVirtualVoidMethod("writeToParcel.(Landroid/os/Parcel;I)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(parcel);
			}
		}

		// Token: 0x04000A08 RID: 2568
		private static readonly JniPeerMembers _members = new XAPeerMembers("android/app/Notification", typeof(Notification));

		// Token: 0x04000A09 RID: 2569
		private static Delegate cb_describeContents;

		// Token: 0x04000A0A RID: 2570
		private static Delegate cb_writeToParcel_Landroid_os_Parcel_I;

		// Token: 0x02000263 RID: 611
		[Register("android/app/Notification$BubbleMetadata", DoNotGenerateAcw = true, ApiSince = 29)]
		public sealed class BubbleMetadata : Java.Lang.Object, IParcelable, IJavaObject, IDisposable, IJavaPeerable
		{
			// Token: 0x170004F6 RID: 1270
			// (get) Token: 0x06001780 RID: 6016 RVA: 0x0003D19B File Offset: 0x0003B39B
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return Notification.BubbleMetadata._members;
				}
			}

			// Token: 0x170004F7 RID: 1271
			// (get) Token: 0x06001781 RID: 6017 RVA: 0x0003D1A4 File Offset: 0x0003B3A4
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return Notification.BubbleMetadata._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x170004F8 RID: 1272
			// (get) Token: 0x06001782 RID: 6018 RVA: 0x0003D1C8 File Offset: 0x0003B3C8
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return Notification.BubbleMetadata._members.ManagedPeerType;
				}
			}

			// Token: 0x06001783 RID: 6019 RVA: 0x000021E0 File Offset: 0x000003E0
			internal BubbleMetadata(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
			{
			}

			// Token: 0x06001784 RID: 6020 RVA: 0x0003D1D4 File Offset: 0x0003B3D4
			[Register("describeContents", "()I", "", ApiSince = 29)]
			public int DescribeContents()
			{
				return Notification.BubbleMetadata._members.InstanceMethods.InvokeAbstractInt32Method("describeContents.()I", this, null);
			}

			// Token: 0x06001785 RID: 6021 RVA: 0x0003D1F0 File Offset: 0x0003B3F0
			[Register("writeToParcel", "(Landroid/os/Parcel;I)V", "", ApiSince = 29)]
			public unsafe void WriteToParcel(Parcel @out, [GeneratedEnum] ParcelableWriteFlags flags)
			{
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((@out == null) ? IntPtr.Zero : @out.Handle);
					ptr[1] = new JniArgumentValue((int)flags);
					Notification.BubbleMetadata._members.InstanceMethods.InvokeAbstractVoidMethod("writeToParcel.(Landroid/os/Parcel;I)V", this, ptr);
				}
				finally
				{
					GC.KeepAlive(@out);
				}
			}

			// Token: 0x04000A0B RID: 2571
			private static readonly JniPeerMembers _members = new XAPeerMembers("android/app/Notification$BubbleMetadata", typeof(Notification.BubbleMetadata));
		}

		// Token: 0x02000264 RID: 612
		[Register("android/app/Notification$Builder", DoNotGenerateAcw = true)]
		public class Builder : Java.Lang.Object
		{
			// Token: 0x170004F9 RID: 1273
			// (get) Token: 0x06001787 RID: 6023 RVA: 0x0003D283 File Offset: 0x0003B483
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return Notification.Builder._members;
				}
			}

			// Token: 0x170004FA RID: 1274
			// (get) Token: 0x06001788 RID: 6024 RVA: 0x0003D28C File Offset: 0x0003B48C
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return Notification.Builder._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x170004FB RID: 1275
			// (get) Token: 0x06001789 RID: 6025 RVA: 0x0003D2B0 File Offset: 0x0003B4B0
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return Notification.Builder._members.ManagedPeerType;
				}
			}

			// Token: 0x0600178A RID: 6026 RVA: 0x000021E0 File Offset: 0x000003E0
			protected Builder(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
			{
			}

			// Token: 0x04000A0C RID: 2572
			private static readonly JniPeerMembers _members = new XAPeerMembers("android/app/Notification$Builder", typeof(Notification.Builder));
		}
	}
}
