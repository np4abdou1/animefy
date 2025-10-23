using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.OS;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Android.Accounts
{
	// Token: 0x02000258 RID: 600
	[Register("android/accounts/Account", DoNotGenerateAcw = true)]
	public class Account : Java.Lang.Object, IParcelable, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x170004CB RID: 1227
		// (get) Token: 0x060015B0 RID: 5552 RVA: 0x0003756E File Offset: 0x0003576E
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return Account._members;
			}
		}

		// Token: 0x170004CC RID: 1228
		// (get) Token: 0x060015B1 RID: 5553 RVA: 0x00037578 File Offset: 0x00035778
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return Account._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170004CD RID: 1229
		// (get) Token: 0x060015B2 RID: 5554 RVA: 0x0003759C File Offset: 0x0003579C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return Account._members.ManagedPeerType;
			}
		}

		// Token: 0x060015B3 RID: 5555 RVA: 0x000021E0 File Offset: 0x000003E0
		protected Account(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x060015B4 RID: 5556 RVA: 0x000375A8 File Offset: 0x000357A8
		private static Delegate GetDescribeContentsHandler()
		{
			if (Account.cb_describeContents == null)
			{
				Account.cb_describeContents = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(Account.n_DescribeContents));
			}
			return Account.cb_describeContents;
		}

		// Token: 0x060015B5 RID: 5557 RVA: 0x000375CC File Offset: 0x000357CC
		private static int n_DescribeContents(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<Account>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).DescribeContents();
		}

		// Token: 0x060015B6 RID: 5558 RVA: 0x000375DB File Offset: 0x000357DB
		public virtual int DescribeContents()
		{
			return Account._members.InstanceMethods.InvokeVirtualInt32Method("describeContents.()I", this, null);
		}

		// Token: 0x060015B7 RID: 5559 RVA: 0x000375F4 File Offset: 0x000357F4
		private static Delegate GetWriteToParcel_Landroid_os_Parcel_IHandler()
		{
			if (Account.cb_writeToParcel_Landroid_os_Parcel_I == null)
			{
				Account.cb_writeToParcel_Landroid_os_Parcel_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLI_V(Account.n_WriteToParcel_Landroid_os_Parcel_I));
			}
			return Account.cb_writeToParcel_Landroid_os_Parcel_I;
		}

		// Token: 0x060015B8 RID: 5560 RVA: 0x00037618 File Offset: 0x00035818
		private static void n_WriteToParcel_Landroid_os_Parcel_I(IntPtr jnienv, IntPtr native__this, IntPtr native_dest, int native_flags)
		{
			Account @object = Java.Lang.Object.GetObject<Account>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Parcel object2 = Java.Lang.Object.GetObject<Parcel>(native_dest, JniHandleOwnership.DoNotTransfer);
			@object.WriteToParcel(object2, (ParcelableWriteFlags)native_flags);
		}

		// Token: 0x060015B9 RID: 5561 RVA: 0x00037640 File Offset: 0x00035840
		public unsafe virtual void WriteToParcel(Parcel dest, [GeneratedEnum] ParcelableWriteFlags flags)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((dest == null) ? IntPtr.Zero : dest.Handle);
				ptr[1] = new JniArgumentValue((int)flags);
				Account._members.InstanceMethods.InvokeVirtualVoidMethod("writeToParcel.(Landroid/os/Parcel;I)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(dest);
			}
		}

		// Token: 0x04000970 RID: 2416
		private static readonly JniPeerMembers _members = new XAPeerMembers("android/accounts/Account", typeof(Account));

		// Token: 0x04000971 RID: 2417
		private static Delegate cb_describeContents;

		// Token: 0x04000972 RID: 2418
		private static Delegate cb_writeToParcel_Landroid_os_Parcel_I;
	}
}
