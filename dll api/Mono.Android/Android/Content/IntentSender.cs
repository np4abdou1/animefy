using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.OS;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Android.Content
{
	// Token: 0x0200029B RID: 667
	[Register("android/content/IntentSender", DoNotGenerateAcw = true)]
	public class IntentSender : Java.Lang.Object, IParcelable, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x1700057F RID: 1407
		// (get) Token: 0x0600198C RID: 6540 RVA: 0x00042537 File Offset: 0x00040737
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IntentSender._members;
			}
		}

		// Token: 0x17000580 RID: 1408
		// (get) Token: 0x0600198D RID: 6541 RVA: 0x00042540 File Offset: 0x00040740
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return IntentSender._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000581 RID: 1409
		// (get) Token: 0x0600198E RID: 6542 RVA: 0x00042564 File Offset: 0x00040764
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IntentSender._members.ManagedPeerType;
			}
		}

		// Token: 0x0600198F RID: 6543 RVA: 0x000021E0 File Offset: 0x000003E0
		protected IntentSender(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06001990 RID: 6544 RVA: 0x00042570 File Offset: 0x00040770
		private static Delegate GetDescribeContentsHandler()
		{
			if (IntentSender.cb_describeContents == null)
			{
				IntentSender.cb_describeContents = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(IntentSender.n_DescribeContents));
			}
			return IntentSender.cb_describeContents;
		}

		// Token: 0x06001991 RID: 6545 RVA: 0x00042594 File Offset: 0x00040794
		private static int n_DescribeContents(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IntentSender>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).DescribeContents();
		}

		// Token: 0x06001992 RID: 6546 RVA: 0x000425A3 File Offset: 0x000407A3
		public virtual int DescribeContents()
		{
			return IntentSender._members.InstanceMethods.InvokeVirtualInt32Method("describeContents.()I", this, null);
		}

		// Token: 0x06001993 RID: 6547 RVA: 0x000425BC File Offset: 0x000407BC
		private static Delegate GetWriteToParcel_Landroid_os_Parcel_IHandler()
		{
			if (IntentSender.cb_writeToParcel_Landroid_os_Parcel_I == null)
			{
				IntentSender.cb_writeToParcel_Landroid_os_Parcel_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLI_V(IntentSender.n_WriteToParcel_Landroid_os_Parcel_I));
			}
			return IntentSender.cb_writeToParcel_Landroid_os_Parcel_I;
		}

		// Token: 0x06001994 RID: 6548 RVA: 0x000425E0 File Offset: 0x000407E0
		private static void n_WriteToParcel_Landroid_os_Parcel_I(IntPtr jnienv, IntPtr native__this, IntPtr native__out, int native_flags)
		{
			IntentSender @object = Java.Lang.Object.GetObject<IntentSender>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Parcel object2 = Java.Lang.Object.GetObject<Parcel>(native__out, JniHandleOwnership.DoNotTransfer);
			@object.WriteToParcel(object2, (ParcelableWriteFlags)native_flags);
		}

		// Token: 0x06001995 RID: 6549 RVA: 0x00042608 File Offset: 0x00040808
		public unsafe virtual void WriteToParcel(Parcel @out, [GeneratedEnum] ParcelableWriteFlags flags)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((@out == null) ? IntPtr.Zero : @out.Handle);
				ptr[1] = new JniArgumentValue((int)flags);
				IntentSender._members.InstanceMethods.InvokeVirtualVoidMethod("writeToParcel.(Landroid/os/Parcel;I)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(@out);
			}
		}

		// Token: 0x04000AB0 RID: 2736
		private static readonly JniPeerMembers _members = new XAPeerMembers("android/content/IntentSender", typeof(IntentSender));

		// Token: 0x04000AB1 RID: 2737
		private static Delegate cb_describeContents;

		// Token: 0x04000AB2 RID: 2738
		private static Delegate cb_writeToParcel_Landroid_os_Parcel_I;
	}
}
