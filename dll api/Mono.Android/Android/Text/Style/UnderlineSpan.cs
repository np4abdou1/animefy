using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.OS;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Android.Text.Style
{
	// Token: 0x020001CD RID: 461
	[Register("android/text/style/UnderlineSpan", DoNotGenerateAcw = true)]
	public class UnderlineSpan : CharacterStyle, IParcelableSpan, IParcelable, IJavaObject, IDisposable, IJavaPeerable, IUpdateAppearance
	{
		// Token: 0x17000344 RID: 836
		// (get) Token: 0x06001087 RID: 4231 RVA: 0x0002B067 File Offset: 0x00029267
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return UnderlineSpan._members;
			}
		}

		// Token: 0x17000345 RID: 837
		// (get) Token: 0x06001088 RID: 4232 RVA: 0x0002B070 File Offset: 0x00029270
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return UnderlineSpan._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000346 RID: 838
		// (get) Token: 0x06001089 RID: 4233 RVA: 0x0002B094 File Offset: 0x00029294
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return UnderlineSpan._members.ManagedPeerType;
			}
		}

		// Token: 0x0600108A RID: 4234 RVA: 0x0002A4DE File Offset: 0x000286DE
		protected UnderlineSpan(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x0600108B RID: 4235 RVA: 0x0002B0A0 File Offset: 0x000292A0
		public UnderlineSpan() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			base.SetHandle(UnderlineSpan._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
			UnderlineSpan._members.InstanceMethods.FinishCreateInstance("()V", this, null);
		}

		// Token: 0x0600108C RID: 4236 RVA: 0x0002B10E File Offset: 0x0002930E
		private static Delegate GetGetSpanTypeIdHandler()
		{
			if (UnderlineSpan.cb_getSpanTypeId == null)
			{
				UnderlineSpan.cb_getSpanTypeId = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(UnderlineSpan.n_GetSpanTypeId));
			}
			return UnderlineSpan.cb_getSpanTypeId;
		}

		// Token: 0x0600108D RID: 4237 RVA: 0x0002B132 File Offset: 0x00029332
		private static int n_GetSpanTypeId(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<UnderlineSpan>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SpanTypeId;
		}

		// Token: 0x17000347 RID: 839
		// (get) Token: 0x0600108E RID: 4238 RVA: 0x0002B141 File Offset: 0x00029341
		public virtual int SpanTypeId
		{
			get
			{
				return UnderlineSpan._members.InstanceMethods.InvokeVirtualInt32Method("getSpanTypeId.()I", this, null);
			}
		}

		// Token: 0x0600108F RID: 4239 RVA: 0x0002B15A File Offset: 0x0002935A
		private static Delegate GetDescribeContentsHandler()
		{
			if (UnderlineSpan.cb_describeContents == null)
			{
				UnderlineSpan.cb_describeContents = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(UnderlineSpan.n_DescribeContents));
			}
			return UnderlineSpan.cb_describeContents;
		}

		// Token: 0x06001090 RID: 4240 RVA: 0x0002B17E File Offset: 0x0002937E
		private static int n_DescribeContents(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<UnderlineSpan>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).DescribeContents();
		}

		// Token: 0x06001091 RID: 4241 RVA: 0x0002B18D File Offset: 0x0002938D
		public virtual int DescribeContents()
		{
			return UnderlineSpan._members.InstanceMethods.InvokeVirtualInt32Method("describeContents.()I", this, null);
		}

		// Token: 0x06001092 RID: 4242 RVA: 0x0002B1A6 File Offset: 0x000293A6
		private static Delegate GetUpdateDrawState_Landroid_text_TextPaint_Handler()
		{
			if (UnderlineSpan.cb_updateDrawState_Landroid_text_TextPaint_ == null)
			{
				UnderlineSpan.cb_updateDrawState_Landroid_text_TextPaint_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(UnderlineSpan.n_UpdateDrawState_Landroid_text_TextPaint_));
			}
			return UnderlineSpan.cb_updateDrawState_Landroid_text_TextPaint_;
		}

		// Token: 0x06001093 RID: 4243 RVA: 0x0002B1CC File Offset: 0x000293CC
		private static void n_UpdateDrawState_Landroid_text_TextPaint_(IntPtr jnienv, IntPtr native__this, IntPtr native_ds)
		{
			CharacterStyle @object = Java.Lang.Object.GetObject<UnderlineSpan>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			TextPaint object2 = Java.Lang.Object.GetObject<TextPaint>(native_ds, JniHandleOwnership.DoNotTransfer);
			@object.UpdateDrawState(object2);
		}

		// Token: 0x06001094 RID: 4244 RVA: 0x0002B1F0 File Offset: 0x000293F0
		public unsafe override void UpdateDrawState(TextPaint ds)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((ds == null) ? IntPtr.Zero : ds.Handle);
				UnderlineSpan._members.InstanceMethods.InvokeVirtualVoidMethod("updateDrawState.(Landroid/text/TextPaint;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(ds);
			}
		}

		// Token: 0x06001095 RID: 4245 RVA: 0x0002B254 File Offset: 0x00029454
		private static Delegate GetWriteToParcel_Landroid_os_Parcel_IHandler()
		{
			if (UnderlineSpan.cb_writeToParcel_Landroid_os_Parcel_I == null)
			{
				UnderlineSpan.cb_writeToParcel_Landroid_os_Parcel_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLI_V(UnderlineSpan.n_WriteToParcel_Landroid_os_Parcel_I));
			}
			return UnderlineSpan.cb_writeToParcel_Landroid_os_Parcel_I;
		}

		// Token: 0x06001096 RID: 4246 RVA: 0x0002B278 File Offset: 0x00029478
		private static void n_WriteToParcel_Landroid_os_Parcel_I(IntPtr jnienv, IntPtr native__this, IntPtr native_dest, int native_flags)
		{
			UnderlineSpan @object = Java.Lang.Object.GetObject<UnderlineSpan>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Parcel object2 = Java.Lang.Object.GetObject<Parcel>(native_dest, JniHandleOwnership.DoNotTransfer);
			@object.WriteToParcel(object2, (ParcelableWriteFlags)native_flags);
		}

		// Token: 0x06001097 RID: 4247 RVA: 0x0002B2A0 File Offset: 0x000294A0
		public unsafe virtual void WriteToParcel(Parcel dest, [GeneratedEnum] ParcelableWriteFlags flags)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((dest == null) ? IntPtr.Zero : dest.Handle);
				ptr[1] = new JniArgumentValue((int)flags);
				UnderlineSpan._members.InstanceMethods.InvokeVirtualVoidMethod("writeToParcel.(Landroid/os/Parcel;I)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(dest);
			}
		}

		// Token: 0x0400078D RID: 1933
		private static readonly JniPeerMembers _members = new XAPeerMembers("android/text/style/UnderlineSpan", typeof(UnderlineSpan));

		// Token: 0x0400078E RID: 1934
		private static Delegate cb_getSpanTypeId;

		// Token: 0x0400078F RID: 1935
		private static Delegate cb_describeContents;

		// Token: 0x04000790 RID: 1936
		private static Delegate cb_updateDrawState_Landroid_text_TextPaint_;

		// Token: 0x04000791 RID: 1937
		private static Delegate cb_writeToParcel_Landroid_os_Parcel_I;
	}
}
