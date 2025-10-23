using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.OS;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Android.Views
{
	// Token: 0x0200012B RID: 299
	[Register("android/view/WindowManager$LayoutParams", DoNotGenerateAcw = true)]
	public class WindowManagerLayoutParams : ViewGroup.LayoutParams, IParcelable, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x170001DC RID: 476
		// (set) Token: 0x060009F1 RID: 2545 RVA: 0x00018C11 File Offset: 0x00016E11
		[Register("windowAnimations")]
		public int WindowAnimations
		{
			set
			{
				WindowManagerLayoutParams._members.InstanceFields.SetValue("windowAnimations.I", this, value);
			}
		}

		// Token: 0x170001DD RID: 477
		// (get) Token: 0x060009F2 RID: 2546 RVA: 0x00018C29 File Offset: 0x00016E29
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return WindowManagerLayoutParams._members;
			}
		}

		// Token: 0x170001DE RID: 478
		// (get) Token: 0x060009F3 RID: 2547 RVA: 0x00018C30 File Offset: 0x00016E30
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return WindowManagerLayoutParams._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170001DF RID: 479
		// (get) Token: 0x060009F4 RID: 2548 RVA: 0x00018C54 File Offset: 0x00016E54
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return WindowManagerLayoutParams._members.ManagedPeerType;
			}
		}

		// Token: 0x060009F5 RID: 2549 RVA: 0x00018C60 File Offset: 0x00016E60
		protected WindowManagerLayoutParams(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x060009F6 RID: 2550 RVA: 0x00018C6A File Offset: 0x00016E6A
		private static Delegate GetDescribeContentsHandler()
		{
			if (WindowManagerLayoutParams.cb_describeContents == null)
			{
				WindowManagerLayoutParams.cb_describeContents = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(WindowManagerLayoutParams.n_DescribeContents));
			}
			return WindowManagerLayoutParams.cb_describeContents;
		}

		// Token: 0x060009F7 RID: 2551 RVA: 0x00018C8E File Offset: 0x00016E8E
		private static int n_DescribeContents(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<WindowManagerLayoutParams>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).DescribeContents();
		}

		// Token: 0x060009F8 RID: 2552 RVA: 0x00018C9D File Offset: 0x00016E9D
		public virtual int DescribeContents()
		{
			return WindowManagerLayoutParams._members.InstanceMethods.InvokeVirtualInt32Method("describeContents.()I", this, null);
		}

		// Token: 0x060009F9 RID: 2553 RVA: 0x00018CB6 File Offset: 0x00016EB6
		private static Delegate GetWriteToParcel_Landroid_os_Parcel_IHandler()
		{
			if (WindowManagerLayoutParams.cb_writeToParcel_Landroid_os_Parcel_I == null)
			{
				WindowManagerLayoutParams.cb_writeToParcel_Landroid_os_Parcel_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLI_V(WindowManagerLayoutParams.n_WriteToParcel_Landroid_os_Parcel_I));
			}
			return WindowManagerLayoutParams.cb_writeToParcel_Landroid_os_Parcel_I;
		}

		// Token: 0x060009FA RID: 2554 RVA: 0x00018CDC File Offset: 0x00016EDC
		private static void n_WriteToParcel_Landroid_os_Parcel_I(IntPtr jnienv, IntPtr native__this, IntPtr native__out, int native_parcelableFlags)
		{
			WindowManagerLayoutParams @object = Java.Lang.Object.GetObject<WindowManagerLayoutParams>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Parcel object2 = Java.Lang.Object.GetObject<Parcel>(native__out, JniHandleOwnership.DoNotTransfer);
			@object.WriteToParcel(object2, (ParcelableWriteFlags)native_parcelableFlags);
		}

		// Token: 0x060009FB RID: 2555 RVA: 0x00018D04 File Offset: 0x00016F04
		public unsafe virtual void WriteToParcel(Parcel @out, [GeneratedEnum] ParcelableWriteFlags parcelableFlags)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((@out == null) ? IntPtr.Zero : @out.Handle);
				ptr[1] = new JniArgumentValue((int)parcelableFlags);
				WindowManagerLayoutParams._members.InstanceMethods.InvokeVirtualVoidMethod("writeToParcel.(Landroid/os/Parcel;I)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(@out);
			}
		}

		// Token: 0x04000339 RID: 825
		private static readonly JniPeerMembers _members = new XAPeerMembers("android/view/WindowManager$LayoutParams", typeof(WindowManagerLayoutParams));

		// Token: 0x0400033A RID: 826
		private static Delegate cb_describeContents;

		// Token: 0x0400033B RID: 827
		private static Delegate cb_writeToParcel_Landroid_os_Parcel_I;
	}
}
