using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.OS;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Android.Views
{
	// Token: 0x02000123 RID: 291
	[Register("android/view/InputEvent", DoNotGenerateAcw = true)]
	public abstract class InputEvent : Java.Lang.Object, IParcelable, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x170001B6 RID: 438
		// (get) Token: 0x060008CA RID: 2250 RVA: 0x00014FD9 File Offset: 0x000131D9
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return InputEvent._members;
			}
		}

		// Token: 0x170001B7 RID: 439
		// (get) Token: 0x060008CB RID: 2251 RVA: 0x00014FE0 File Offset: 0x000131E0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return InputEvent._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170001B8 RID: 440
		// (get) Token: 0x060008CC RID: 2252 RVA: 0x00015004 File Offset: 0x00013204
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return InputEvent._members.ManagedPeerType;
			}
		}

		// Token: 0x060008CD RID: 2253 RVA: 0x000021E0 File Offset: 0x000003E0
		protected InputEvent(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x060008CE RID: 2254 RVA: 0x00015010 File Offset: 0x00013210
		private static Delegate GetDescribeContentsHandler()
		{
			if (InputEvent.cb_describeContents == null)
			{
				InputEvent.cb_describeContents = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(InputEvent.n_DescribeContents));
			}
			return InputEvent.cb_describeContents;
		}

		// Token: 0x060008CF RID: 2255 RVA: 0x00015034 File Offset: 0x00013234
		private static int n_DescribeContents(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<InputEvent>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).DescribeContents();
		}

		// Token: 0x060008D0 RID: 2256 RVA: 0x00015043 File Offset: 0x00013243
		public virtual int DescribeContents()
		{
			return InputEvent._members.InstanceMethods.InvokeVirtualInt32Method("describeContents.()I", this, null);
		}

		// Token: 0x060008D1 RID: 2257 RVA: 0x0001505C File Offset: 0x0001325C
		private static Delegate GetWriteToParcel_Landroid_os_Parcel_IHandler()
		{
			if (InputEvent.cb_writeToParcel_Landroid_os_Parcel_I == null)
			{
				InputEvent.cb_writeToParcel_Landroid_os_Parcel_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLI_V(InputEvent.n_WriteToParcel_Landroid_os_Parcel_I));
			}
			return InputEvent.cb_writeToParcel_Landroid_os_Parcel_I;
		}

		// Token: 0x060008D2 RID: 2258 RVA: 0x00015080 File Offset: 0x00013280
		private static void n_WriteToParcel_Landroid_os_Parcel_I(IntPtr jnienv, IntPtr native__this, IntPtr native_dest, int native_flags)
		{
			InputEvent @object = Java.Lang.Object.GetObject<InputEvent>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Parcel object2 = Java.Lang.Object.GetObject<Parcel>(native_dest, JniHandleOwnership.DoNotTransfer);
			@object.WriteToParcel(object2, (ParcelableWriteFlags)native_flags);
		}

		// Token: 0x060008D3 RID: 2259
		public abstract void WriteToParcel(Parcel dest, [GeneratedEnum] ParcelableWriteFlags flags);

		// Token: 0x040002A4 RID: 676
		private static readonly JniPeerMembers _members = new XAPeerMembers("android/view/InputEvent", typeof(InputEvent));

		// Token: 0x040002A5 RID: 677
		private static Delegate cb_describeContents;

		// Token: 0x040002A6 RID: 678
		private static Delegate cb_writeToParcel_Landroid_os_Parcel_I;
	}
}
