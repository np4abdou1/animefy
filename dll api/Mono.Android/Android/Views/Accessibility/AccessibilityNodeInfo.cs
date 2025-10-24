using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.OS;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Android.Views.Accessibility
{
	// Token: 0x02000188 RID: 392
	[Register("android/view/accessibility/AccessibilityNodeInfo", DoNotGenerateAcw = true)]
	public class AccessibilityNodeInfo : Java.Lang.Object, IParcelable, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x1700029D RID: 669
		// (get) Token: 0x06000DA3 RID: 3491 RVA: 0x000230D7 File Offset: 0x000212D7
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return AccessibilityNodeInfo._members;
			}
		}

		// Token: 0x1700029E RID: 670
		// (get) Token: 0x06000DA4 RID: 3492 RVA: 0x000230E0 File Offset: 0x000212E0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return AccessibilityNodeInfo._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700029F RID: 671
		// (get) Token: 0x06000DA5 RID: 3493 RVA: 0x00023104 File Offset: 0x00021304
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return AccessibilityNodeInfo._members.ManagedPeerType;
			}
		}

		// Token: 0x06000DA6 RID: 3494 RVA: 0x000021E0 File Offset: 0x000003E0
		protected AccessibilityNodeInfo(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000DA7 RID: 3495 RVA: 0x00023110 File Offset: 0x00021310
		private static Delegate GetDescribeContentsHandler()
		{
			if (AccessibilityNodeInfo.cb_describeContents == null)
			{
				AccessibilityNodeInfo.cb_describeContents = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(AccessibilityNodeInfo.n_DescribeContents));
			}
			return AccessibilityNodeInfo.cb_describeContents;
		}

		// Token: 0x06000DA8 RID: 3496 RVA: 0x00023134 File Offset: 0x00021334
		private static int n_DescribeContents(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<AccessibilityNodeInfo>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).DescribeContents();
		}

		// Token: 0x06000DA9 RID: 3497 RVA: 0x00023143 File Offset: 0x00021343
		public virtual int DescribeContents()
		{
			return AccessibilityNodeInfo._members.InstanceMethods.InvokeVirtualInt32Method("describeContents.()I", this, null);
		}

		// Token: 0x06000DAA RID: 3498 RVA: 0x0002315C File Offset: 0x0002135C
		private static Delegate GetWriteToParcel_Landroid_os_Parcel_IHandler()
		{
			if (AccessibilityNodeInfo.cb_writeToParcel_Landroid_os_Parcel_I == null)
			{
				AccessibilityNodeInfo.cb_writeToParcel_Landroid_os_Parcel_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLI_V(AccessibilityNodeInfo.n_WriteToParcel_Landroid_os_Parcel_I));
			}
			return AccessibilityNodeInfo.cb_writeToParcel_Landroid_os_Parcel_I;
		}

		// Token: 0x06000DAB RID: 3499 RVA: 0x00023180 File Offset: 0x00021380
		private static void n_WriteToParcel_Landroid_os_Parcel_I(IntPtr jnienv, IntPtr native__this, IntPtr native_parcel, int native_flags)
		{
			AccessibilityNodeInfo @object = Java.Lang.Object.GetObject<AccessibilityNodeInfo>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Parcel object2 = Java.Lang.Object.GetObject<Parcel>(native_parcel, JniHandleOwnership.DoNotTransfer);
			@object.WriteToParcel(object2, (ParcelableWriteFlags)native_flags);
		}

		// Token: 0x06000DAC RID: 3500 RVA: 0x000231A8 File Offset: 0x000213A8
		public unsafe virtual void WriteToParcel(Parcel parcel, [GeneratedEnum] ParcelableWriteFlags flags)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((parcel == null) ? IntPtr.Zero : parcel.Handle);
				ptr[1] = new JniArgumentValue((int)flags);
				AccessibilityNodeInfo._members.InstanceMethods.InvokeVirtualVoidMethod("writeToParcel.(Landroid/os/Parcel;I)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(parcel);
			}
		}

		// Token: 0x04000627 RID: 1575
		private static readonly JniPeerMembers _members = new XAPeerMembers("android/view/accessibility/AccessibilityNodeInfo", typeof(AccessibilityNodeInfo));

		// Token: 0x04000628 RID: 1576
		private static Delegate cb_describeContents;

		// Token: 0x04000629 RID: 1577
		private static Delegate cb_writeToParcel_Landroid_os_Parcel_I;

		// Token: 0x02000189 RID: 393
		[Register("android/view/accessibility/AccessibilityNodeInfo$ExtraRenderingInfo", DoNotGenerateAcw = true, ApiSince = 30)]
		public sealed class ExtraRenderingInfo : Java.Lang.Object
		{
			// Token: 0x170002A0 RID: 672
			// (get) Token: 0x06000DAE RID: 3502 RVA: 0x0002323B File Offset: 0x0002143B
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return AccessibilityNodeInfo.ExtraRenderingInfo._members;
				}
			}

			// Token: 0x170002A1 RID: 673
			// (get) Token: 0x06000DAF RID: 3503 RVA: 0x00023244 File Offset: 0x00021444
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return AccessibilityNodeInfo.ExtraRenderingInfo._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x170002A2 RID: 674
			// (get) Token: 0x06000DB0 RID: 3504 RVA: 0x00023268 File Offset: 0x00021468
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return AccessibilityNodeInfo.ExtraRenderingInfo._members.ManagedPeerType;
				}
			}

			// Token: 0x06000DB1 RID: 3505 RVA: 0x000021E0 File Offset: 0x000003E0
			internal ExtraRenderingInfo(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
			{
			}

			// Token: 0x0400062A RID: 1578
			private static readonly JniPeerMembers _members = new XAPeerMembers("android/view/accessibility/AccessibilityNodeInfo$ExtraRenderingInfo", typeof(AccessibilityNodeInfo.ExtraRenderingInfo));
		}
	}
}
