using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Java.Interop;
using Java.Lang;

namespace Android.Widget
{
	// Token: 0x020000F1 RID: 241
	[Register("android/widget/RemoteViews", DoNotGenerateAcw = true)]
	public class RemoteViews : Java.Lang.Object, IParcelable, IJavaObject, IDisposable, IJavaPeerable, LayoutInflater.IFilter
	{
		// Token: 0x170000F3 RID: 243
		// (get) Token: 0x0600057A RID: 1402 RVA: 0x0000BB97 File Offset: 0x00009D97
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return RemoteViews._members;
			}
		}

		// Token: 0x170000F4 RID: 244
		// (get) Token: 0x0600057B RID: 1403 RVA: 0x0000BBA0 File Offset: 0x00009DA0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return RemoteViews._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170000F5 RID: 245
		// (get) Token: 0x0600057C RID: 1404 RVA: 0x0000BBC4 File Offset: 0x00009DC4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return RemoteViews._members.ManagedPeerType;
			}
		}

		// Token: 0x0600057D RID: 1405 RVA: 0x000021E0 File Offset: 0x000003E0
		protected RemoteViews(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x0600057E RID: 1406 RVA: 0x0000BBD0 File Offset: 0x00009DD0
		private static Delegate GetDescribeContentsHandler()
		{
			if (RemoteViews.cb_describeContents == null)
			{
				RemoteViews.cb_describeContents = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(RemoteViews.n_DescribeContents));
			}
			return RemoteViews.cb_describeContents;
		}

		// Token: 0x0600057F RID: 1407 RVA: 0x0000BBF4 File Offset: 0x00009DF4
		private static int n_DescribeContents(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<RemoteViews>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).DescribeContents();
		}

		// Token: 0x06000580 RID: 1408 RVA: 0x0000BC03 File Offset: 0x00009E03
		public virtual int DescribeContents()
		{
			return RemoteViews._members.InstanceMethods.InvokeVirtualInt32Method("describeContents.()I", this, null);
		}

		// Token: 0x06000581 RID: 1409 RVA: 0x0000BC1C File Offset: 0x00009E1C
		private static Delegate GetOnLoadClass_Ljava_lang_Class_Handler()
		{
			if (RemoteViews.cb_onLoadClass_Ljava_lang_Class_ == null)
			{
				RemoteViews.cb_onLoadClass_Ljava_lang_Class_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(RemoteViews.n_OnLoadClass_Ljava_lang_Class_));
			}
			return RemoteViews.cb_onLoadClass_Ljava_lang_Class_;
		}

		// Token: 0x06000582 RID: 1410 RVA: 0x0000BC40 File Offset: 0x00009E40
		private static bool n_OnLoadClass_Ljava_lang_Class_(IntPtr jnienv, IntPtr native__this, IntPtr native_clazz)
		{
			RemoteViews @object = Java.Lang.Object.GetObject<RemoteViews>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Class object2 = Java.Lang.Object.GetObject<Class>(native_clazz, JniHandleOwnership.DoNotTransfer);
			return @object.OnLoadClass(object2);
		}

		// Token: 0x06000583 RID: 1411 RVA: 0x0000BC64 File Offset: 0x00009E64
		public unsafe virtual bool OnLoadClass(Class clazz)
		{
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((clazz == null) ? IntPtr.Zero : clazz.Handle);
				result = RemoteViews._members.InstanceMethods.InvokeVirtualBooleanMethod("onLoadClass.(Ljava/lang/Class;)Z", this, ptr);
			}
			finally
			{
				GC.KeepAlive(clazz);
			}
			return result;
		}

		// Token: 0x06000584 RID: 1412 RVA: 0x0000BCCC File Offset: 0x00009ECC
		private static Delegate GetWriteToParcel_Landroid_os_Parcel_IHandler()
		{
			if (RemoteViews.cb_writeToParcel_Landroid_os_Parcel_I == null)
			{
				RemoteViews.cb_writeToParcel_Landroid_os_Parcel_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLI_V(RemoteViews.n_WriteToParcel_Landroid_os_Parcel_I));
			}
			return RemoteViews.cb_writeToParcel_Landroid_os_Parcel_I;
		}

		// Token: 0x06000585 RID: 1413 RVA: 0x0000BCF0 File Offset: 0x00009EF0
		private static void n_WriteToParcel_Landroid_os_Parcel_I(IntPtr jnienv, IntPtr native__this, IntPtr native_dest, int native_flags)
		{
			RemoteViews @object = Java.Lang.Object.GetObject<RemoteViews>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Parcel object2 = Java.Lang.Object.GetObject<Parcel>(native_dest, JniHandleOwnership.DoNotTransfer);
			@object.WriteToParcel(object2, (ParcelableWriteFlags)native_flags);
		}

		// Token: 0x06000586 RID: 1414 RVA: 0x0000BD18 File Offset: 0x00009F18
		public unsafe virtual void WriteToParcel(Parcel dest, [GeneratedEnum] ParcelableWriteFlags flags)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((dest == null) ? IntPtr.Zero : dest.Handle);
				ptr[1] = new JniArgumentValue((int)flags);
				RemoteViews._members.InstanceMethods.InvokeVirtualVoidMethod("writeToParcel.(Landroid/os/Parcel;I)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(dest);
			}
		}

		// Token: 0x0400014C RID: 332
		private static readonly JniPeerMembers _members = new XAPeerMembers("android/widget/RemoteViews", typeof(RemoteViews));

		// Token: 0x0400014D RID: 333
		private static Delegate cb_describeContents;

		// Token: 0x0400014E RID: 334
		private static Delegate cb_onLoadClass_Ljava_lang_Class_;

		// Token: 0x0400014F RID: 335
		private static Delegate cb_writeToParcel_Landroid_os_Parcel_I;
	}
}
