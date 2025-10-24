using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.OS;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Android.Net
{
	// Token: 0x020001FB RID: 507
	[Register("android/net/Uri", DoNotGenerateAcw = true)]
	public abstract class Uri : Java.Lang.Object, IParcelable, IJavaObject, IDisposable, IJavaPeerable, Java.Lang.IComparable
	{
		// Token: 0x170003BF RID: 959
		// (get) Token: 0x06001251 RID: 4689 RVA: 0x0003042F File Offset: 0x0002E62F
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return Uri._members;
			}
		}

		// Token: 0x170003C0 RID: 960
		// (get) Token: 0x06001252 RID: 4690 RVA: 0x00030438 File Offset: 0x0002E638
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return Uri._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170003C1 RID: 961
		// (get) Token: 0x06001253 RID: 4691 RVA: 0x0003045C File Offset: 0x0002E65C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return Uri._members.ManagedPeerType;
			}
		}

		// Token: 0x06001254 RID: 4692 RVA: 0x000021E0 File Offset: 0x000003E0
		protected Uri(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06001255 RID: 4693 RVA: 0x00030468 File Offset: 0x0002E668
		private static Delegate GetCompareTo_Landroid_net_Uri_Handler()
		{
			if (Uri.cb_compareTo_Landroid_net_Uri_ == null)
			{
				Uri.cb_compareTo_Landroid_net_Uri_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_I(Uri.n_CompareTo_Landroid_net_Uri_));
			}
			return Uri.cb_compareTo_Landroid_net_Uri_;
		}

		// Token: 0x06001256 RID: 4694 RVA: 0x0003048C File Offset: 0x0002E68C
		private static int n_CompareTo_Landroid_net_Uri_(IntPtr jnienv, IntPtr native__this, IntPtr native_other)
		{
			Uri @object = Java.Lang.Object.GetObject<Uri>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Uri object2 = Java.Lang.Object.GetObject<Uri>(native_other, JniHandleOwnership.DoNotTransfer);
			return @object.CompareTo(object2);
		}

		// Token: 0x06001257 RID: 4695 RVA: 0x000304B0 File Offset: 0x0002E6B0
		public unsafe virtual int CompareTo(Uri other)
		{
			int result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((other == null) ? IntPtr.Zero : other.Handle);
				result = Uri._members.InstanceMethods.InvokeVirtualInt32Method("compareTo.(Landroid/net/Uri;)I", this, ptr);
			}
			finally
			{
				GC.KeepAlive(other);
			}
			return result;
		}

		// Token: 0x06001258 RID: 4696 RVA: 0x00030518 File Offset: 0x0002E718
		public unsafe static Uri Parse(string uriString)
		{
			IntPtr intPtr = JNIEnv.NewString(uriString);
			Uri @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<Uri>(Uri._members.StaticMethods.InvokeObjectMethod("parse.(Ljava/lang/String;)Landroid/net/Uri;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
			return @object;
		}

		// Token: 0x06001259 RID: 4697 RVA: 0x00030584 File Offset: 0x0002E784
		private static Delegate GetToStringHandler()
		{
			if (Uri.cb_toString == null)
			{
				Uri.cb_toString = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(Uri.n_ToString));
			}
			return Uri.cb_toString;
		}

		// Token: 0x0600125A RID: 4698 RVA: 0x000305A8 File Offset: 0x0002E7A8
		private static IntPtr n_ToString(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<Uri>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ToString());
		}

		// Token: 0x0600125B RID: 4699
		public new abstract string ToString();

		// Token: 0x0600125C RID: 4700 RVA: 0x000305BC File Offset: 0x0002E7BC
		private static Delegate GetDescribeContentsHandler()
		{
			if (Uri.cb_describeContents == null)
			{
				Uri.cb_describeContents = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(Uri.n_DescribeContents));
			}
			return Uri.cb_describeContents;
		}

		// Token: 0x0600125D RID: 4701 RVA: 0x000305E0 File Offset: 0x0002E7E0
		private static int n_DescribeContents(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<Uri>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).DescribeContents();
		}

		// Token: 0x0600125E RID: 4702
		public abstract int DescribeContents();

		// Token: 0x0600125F RID: 4703 RVA: 0x000305EF File Offset: 0x0002E7EF
		private static Delegate GetWriteToParcel_Landroid_os_Parcel_IHandler()
		{
			if (Uri.cb_writeToParcel_Landroid_os_Parcel_I == null)
			{
				Uri.cb_writeToParcel_Landroid_os_Parcel_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLI_V(Uri.n_WriteToParcel_Landroid_os_Parcel_I));
			}
			return Uri.cb_writeToParcel_Landroid_os_Parcel_I;
		}

		// Token: 0x06001260 RID: 4704 RVA: 0x00030614 File Offset: 0x0002E814
		private static void n_WriteToParcel_Landroid_os_Parcel_I(IntPtr jnienv, IntPtr native__this, IntPtr native_dest, int native_flags)
		{
			Uri @object = Java.Lang.Object.GetObject<Uri>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Parcel object2 = Java.Lang.Object.GetObject<Parcel>(native_dest, JniHandleOwnership.DoNotTransfer);
			@object.WriteToParcel(object2, (ParcelableWriteFlags)native_flags);
		}

		// Token: 0x06001261 RID: 4705
		public abstract void WriteToParcel(Parcel dest, [GeneratedEnum] ParcelableWriteFlags flags);

		// Token: 0x06001262 RID: 4706 RVA: 0x0003063A File Offset: 0x0002E83A
		int Java.Lang.IComparable.CompareTo(Java.Lang.Object o)
		{
			return this.CompareTo(o.JavaCast<Uri>());
		}

		// Token: 0x0400083F RID: 2111
		private static readonly JniPeerMembers _members = new XAPeerMembers("android/net/Uri", typeof(Uri));

		// Token: 0x04000840 RID: 2112
		private static Delegate cb_compareTo_Landroid_net_Uri_;

		// Token: 0x04000841 RID: 2113
		private static Delegate cb_toString;

		// Token: 0x04000842 RID: 2114
		private static Delegate cb_describeContents;

		// Token: 0x04000843 RID: 2115
		private static Delegate cb_writeToParcel_Landroid_os_Parcel_I;
	}
}
