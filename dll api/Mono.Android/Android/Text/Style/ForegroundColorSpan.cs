using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Graphics;
using Android.OS;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Android.Text.Style
{
	// Token: 0x020001C5 RID: 453
	[Register("android/text/style/ForegroundColorSpan", DoNotGenerateAcw = true)]
	public class ForegroundColorSpan : CharacterStyle, IParcelableSpan, IParcelable, IJavaObject, IDisposable, IJavaPeerable, IUpdateAppearance
	{
		// Token: 0x1700032F RID: 815
		// (get) Token: 0x06001049 RID: 4169 RVA: 0x0002A7CF File Offset: 0x000289CF
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return ForegroundColorSpan._members;
			}
		}

		// Token: 0x17000330 RID: 816
		// (get) Token: 0x0600104A RID: 4170 RVA: 0x0002A7D8 File Offset: 0x000289D8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return ForegroundColorSpan._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000331 RID: 817
		// (get) Token: 0x0600104B RID: 4171 RVA: 0x0002A7FC File Offset: 0x000289FC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return ForegroundColorSpan._members.ManagedPeerType;
			}
		}

		// Token: 0x0600104C RID: 4172 RVA: 0x0002A4DE File Offset: 0x000286DE
		protected ForegroundColorSpan(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x0600104D RID: 4173 RVA: 0x0002A808 File Offset: 0x00028A08
		public unsafe ForegroundColorSpan(Color color) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(color.ToArgb());
			base.SetHandle(ForegroundColorSpan._members.InstanceMethods.StartCreateInstance("(I)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
			ForegroundColorSpan._members.InstanceMethods.FinishCreateInstance("(I)V", this, ptr);
		}

		// Token: 0x0600104E RID: 4174 RVA: 0x0002A892 File Offset: 0x00028A92
		private static Delegate GetGetSpanTypeIdHandler()
		{
			if (ForegroundColorSpan.cb_getSpanTypeId == null)
			{
				ForegroundColorSpan.cb_getSpanTypeId = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(ForegroundColorSpan.n_GetSpanTypeId));
			}
			return ForegroundColorSpan.cb_getSpanTypeId;
		}

		// Token: 0x0600104F RID: 4175 RVA: 0x0002A8B6 File Offset: 0x00028AB6
		private static int n_GetSpanTypeId(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<ForegroundColorSpan>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SpanTypeId;
		}

		// Token: 0x17000332 RID: 818
		// (get) Token: 0x06001050 RID: 4176 RVA: 0x0002A8C5 File Offset: 0x00028AC5
		public virtual int SpanTypeId
		{
			get
			{
				return ForegroundColorSpan._members.InstanceMethods.InvokeVirtualInt32Method("getSpanTypeId.()I", this, null);
			}
		}

		// Token: 0x06001051 RID: 4177 RVA: 0x0002A8DE File Offset: 0x00028ADE
		private static Delegate GetDescribeContentsHandler()
		{
			if (ForegroundColorSpan.cb_describeContents == null)
			{
				ForegroundColorSpan.cb_describeContents = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(ForegroundColorSpan.n_DescribeContents));
			}
			return ForegroundColorSpan.cb_describeContents;
		}

		// Token: 0x06001052 RID: 4178 RVA: 0x0002A902 File Offset: 0x00028B02
		private static int n_DescribeContents(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<ForegroundColorSpan>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).DescribeContents();
		}

		// Token: 0x06001053 RID: 4179 RVA: 0x0002A911 File Offset: 0x00028B11
		public virtual int DescribeContents()
		{
			return ForegroundColorSpan._members.InstanceMethods.InvokeVirtualInt32Method("describeContents.()I", this, null);
		}

		// Token: 0x06001054 RID: 4180 RVA: 0x0002A92A File Offset: 0x00028B2A
		private static Delegate GetUpdateDrawState_Landroid_text_TextPaint_Handler()
		{
			if (ForegroundColorSpan.cb_updateDrawState_Landroid_text_TextPaint_ == null)
			{
				ForegroundColorSpan.cb_updateDrawState_Landroid_text_TextPaint_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(ForegroundColorSpan.n_UpdateDrawState_Landroid_text_TextPaint_));
			}
			return ForegroundColorSpan.cb_updateDrawState_Landroid_text_TextPaint_;
		}

		// Token: 0x06001055 RID: 4181 RVA: 0x0002A950 File Offset: 0x00028B50
		private static void n_UpdateDrawState_Landroid_text_TextPaint_(IntPtr jnienv, IntPtr native__this, IntPtr native_textPaint)
		{
			CharacterStyle @object = Java.Lang.Object.GetObject<ForegroundColorSpan>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			TextPaint object2 = Java.Lang.Object.GetObject<TextPaint>(native_textPaint, JniHandleOwnership.DoNotTransfer);
			@object.UpdateDrawState(object2);
		}

		// Token: 0x06001056 RID: 4182 RVA: 0x0002A974 File Offset: 0x00028B74
		public unsafe override void UpdateDrawState(TextPaint textPaint)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((textPaint == null) ? IntPtr.Zero : textPaint.Handle);
				ForegroundColorSpan._members.InstanceMethods.InvokeVirtualVoidMethod("updateDrawState.(Landroid/text/TextPaint;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(textPaint);
			}
		}

		// Token: 0x06001057 RID: 4183 RVA: 0x0002A9D8 File Offset: 0x00028BD8
		private static Delegate GetWriteToParcel_Landroid_os_Parcel_IHandler()
		{
			if (ForegroundColorSpan.cb_writeToParcel_Landroid_os_Parcel_I == null)
			{
				ForegroundColorSpan.cb_writeToParcel_Landroid_os_Parcel_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLI_V(ForegroundColorSpan.n_WriteToParcel_Landroid_os_Parcel_I));
			}
			return ForegroundColorSpan.cb_writeToParcel_Landroid_os_Parcel_I;
		}

		// Token: 0x06001058 RID: 4184 RVA: 0x0002A9FC File Offset: 0x00028BFC
		private static void n_WriteToParcel_Landroid_os_Parcel_I(IntPtr jnienv, IntPtr native__this, IntPtr native_dest, int native_flags)
		{
			ForegroundColorSpan @object = Java.Lang.Object.GetObject<ForegroundColorSpan>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Parcel object2 = Java.Lang.Object.GetObject<Parcel>(native_dest, JniHandleOwnership.DoNotTransfer);
			@object.WriteToParcel(object2, (ParcelableWriteFlags)native_flags);
		}

		// Token: 0x06001059 RID: 4185 RVA: 0x0002AA24 File Offset: 0x00028C24
		public unsafe virtual void WriteToParcel(Parcel dest, [GeneratedEnum] ParcelableWriteFlags flags)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((dest == null) ? IntPtr.Zero : dest.Handle);
				ptr[1] = new JniArgumentValue((int)flags);
				ForegroundColorSpan._members.InstanceMethods.InvokeVirtualVoidMethod("writeToParcel.(Landroid/os/Parcel;I)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(dest);
			}
		}

		// Token: 0x0400077D RID: 1917
		private static readonly JniPeerMembers _members = new XAPeerMembers("android/text/style/ForegroundColorSpan", typeof(ForegroundColorSpan));

		// Token: 0x0400077E RID: 1918
		private static Delegate cb_getSpanTypeId;

		// Token: 0x0400077F RID: 1919
		private static Delegate cb_describeContents;

		// Token: 0x04000780 RID: 1920
		private static Delegate cb_updateDrawState_Landroid_text_TextPaint_;

		// Token: 0x04000781 RID: 1921
		private static Delegate cb_writeToParcel_Landroid_os_Parcel_I;
	}
}
