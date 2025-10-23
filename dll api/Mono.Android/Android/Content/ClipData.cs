using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.OS;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Android.Content
{
	// Token: 0x0200027D RID: 637
	[Register("android/content/ClipData", DoNotGenerateAcw = true)]
	public class ClipData : Java.Lang.Object, IParcelable, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x1700052D RID: 1325
		// (get) Token: 0x0600181E RID: 6174 RVA: 0x0003E63F File Offset: 0x0003C83F
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return ClipData._members;
			}
		}

		// Token: 0x1700052E RID: 1326
		// (get) Token: 0x0600181F RID: 6175 RVA: 0x0003E648 File Offset: 0x0003C848
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return ClipData._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700052F RID: 1327
		// (get) Token: 0x06001820 RID: 6176 RVA: 0x0003E66C File Offset: 0x0003C86C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return ClipData._members.ManagedPeerType;
			}
		}

		// Token: 0x06001821 RID: 6177 RVA: 0x000021E0 File Offset: 0x000003E0
		protected ClipData(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06001822 RID: 6178 RVA: 0x0003E678 File Offset: 0x0003C878
		private static Delegate GetDescribeContentsHandler()
		{
			if (ClipData.cb_describeContents == null)
			{
				ClipData.cb_describeContents = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(ClipData.n_DescribeContents));
			}
			return ClipData.cb_describeContents;
		}

		// Token: 0x06001823 RID: 6179 RVA: 0x0003E69C File Offset: 0x0003C89C
		private static int n_DescribeContents(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<ClipData>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).DescribeContents();
		}

		// Token: 0x06001824 RID: 6180 RVA: 0x0003E6AB File Offset: 0x0003C8AB
		public virtual int DescribeContents()
		{
			return ClipData._members.InstanceMethods.InvokeVirtualInt32Method("describeContents.()I", this, null);
		}

		// Token: 0x06001825 RID: 6181 RVA: 0x0003E6C4 File Offset: 0x0003C8C4
		public unsafe static ClipData NewPlainText(ICharSequence label, ICharSequence text)
		{
			IntPtr intPtr = CharSequence.ToLocalJniHandle(label);
			IntPtr intPtr2 = CharSequence.ToLocalJniHandle(text);
			ClipData @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(intPtr2);
				@object = Java.Lang.Object.GetObject<ClipData>(ClipData._members.StaticMethods.InvokeObjectMethod("newPlainText.(Ljava/lang/CharSequence;Ljava/lang/CharSequence;)Landroid/content/ClipData;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				JNIEnv.DeleteLocalRef(intPtr2);
				GC.KeepAlive(label);
				GC.KeepAlive(text);
			}
			return @object;
		}

		// Token: 0x06001826 RID: 6182 RVA: 0x0003E75C File Offset: 0x0003C95C
		public static ClipData NewPlainText(string label, string text)
		{
			object obj = (label == null) ? null : new Java.Lang.String(label);
			Java.Lang.String @string = (text == null) ? null : new Java.Lang.String(text);
			object obj2 = obj;
			ClipData result = ClipData.NewPlainText(obj2, @string);
			if (obj2 != null)
			{
				obj2.Dispose();
			}
			if (@string != null)
			{
				@string.Dispose();
			}
			return result;
		}

		// Token: 0x06001827 RID: 6183 RVA: 0x0003E79F File Offset: 0x0003C99F
		private static Delegate GetWriteToParcel_Landroid_os_Parcel_IHandler()
		{
			if (ClipData.cb_writeToParcel_Landroid_os_Parcel_I == null)
			{
				ClipData.cb_writeToParcel_Landroid_os_Parcel_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLI_V(ClipData.n_WriteToParcel_Landroid_os_Parcel_I));
			}
			return ClipData.cb_writeToParcel_Landroid_os_Parcel_I;
		}

		// Token: 0x06001828 RID: 6184 RVA: 0x0003E7C4 File Offset: 0x0003C9C4
		private static void n_WriteToParcel_Landroid_os_Parcel_I(IntPtr jnienv, IntPtr native__this, IntPtr native_dest, int native_flags)
		{
			ClipData @object = Java.Lang.Object.GetObject<ClipData>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Parcel object2 = Java.Lang.Object.GetObject<Parcel>(native_dest, JniHandleOwnership.DoNotTransfer);
			@object.WriteToParcel(object2, (ParcelableWriteFlags)native_flags);
		}

		// Token: 0x06001829 RID: 6185 RVA: 0x0003E7EC File Offset: 0x0003C9EC
		public unsafe virtual void WriteToParcel(Parcel dest, [GeneratedEnum] ParcelableWriteFlags flags)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((dest == null) ? IntPtr.Zero : dest.Handle);
				ptr[1] = new JniArgumentValue((int)flags);
				ClipData._members.InstanceMethods.InvokeVirtualVoidMethod("writeToParcel.(Landroid/os/Parcel;I)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(dest);
			}
		}

		// Token: 0x04000A45 RID: 2629
		private static readonly JniPeerMembers _members = new XAPeerMembers("android/content/ClipData", typeof(ClipData));

		// Token: 0x04000A46 RID: 2630
		private static Delegate cb_describeContents;

		// Token: 0x04000A47 RID: 2631
		private static Delegate cb_writeToParcel_Landroid_os_Parcel_I;
	}
}
