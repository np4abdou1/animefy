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
	// Token: 0x020001CC RID: 460
	[Register("android/text/style/StyleSpan", DoNotGenerateAcw = true)]
	public class StyleSpan : MetricAffectingSpan, IParcelableSpan, IParcelable, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000340 RID: 832
		// (get) Token: 0x06001075 RID: 4213 RVA: 0x0002AD87 File Offset: 0x00028F87
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return StyleSpan._members;
			}
		}

		// Token: 0x17000341 RID: 833
		// (get) Token: 0x06001076 RID: 4214 RVA: 0x0002AD90 File Offset: 0x00028F90
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return StyleSpan._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000342 RID: 834
		// (get) Token: 0x06001077 RID: 4215 RVA: 0x0002ADB4 File Offset: 0x00028FB4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return StyleSpan._members.ManagedPeerType;
			}
		}

		// Token: 0x06001078 RID: 4216 RVA: 0x0002ACEB File Offset: 0x00028EEB
		protected StyleSpan(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06001079 RID: 4217 RVA: 0x0002ADC0 File Offset: 0x00028FC0
		public unsafe StyleSpan([GeneratedEnum] TypefaceStyle style) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue((int)style);
			base.SetHandle(StyleSpan._members.InstanceMethods.StartCreateInstance("(I)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
			StyleSpan._members.InstanceMethods.FinishCreateInstance("(I)V", this, ptr);
		}

		// Token: 0x0600107A RID: 4218 RVA: 0x0002AE44 File Offset: 0x00029044
		private static Delegate GetGetSpanTypeIdHandler()
		{
			if (StyleSpan.cb_getSpanTypeId == null)
			{
				StyleSpan.cb_getSpanTypeId = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(StyleSpan.n_GetSpanTypeId));
			}
			return StyleSpan.cb_getSpanTypeId;
		}

		// Token: 0x0600107B RID: 4219 RVA: 0x0002AE68 File Offset: 0x00029068
		private static int n_GetSpanTypeId(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<StyleSpan>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SpanTypeId;
		}

		// Token: 0x17000343 RID: 835
		// (get) Token: 0x0600107C RID: 4220 RVA: 0x0002AE77 File Offset: 0x00029077
		public virtual int SpanTypeId
		{
			get
			{
				return StyleSpan._members.InstanceMethods.InvokeVirtualInt32Method("getSpanTypeId.()I", this, null);
			}
		}

		// Token: 0x0600107D RID: 4221 RVA: 0x0002AE90 File Offset: 0x00029090
		private static Delegate GetDescribeContentsHandler()
		{
			if (StyleSpan.cb_describeContents == null)
			{
				StyleSpan.cb_describeContents = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(StyleSpan.n_DescribeContents));
			}
			return StyleSpan.cb_describeContents;
		}

		// Token: 0x0600107E RID: 4222 RVA: 0x0002AEB4 File Offset: 0x000290B4
		private static int n_DescribeContents(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<StyleSpan>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).DescribeContents();
		}

		// Token: 0x0600107F RID: 4223 RVA: 0x0002AEC3 File Offset: 0x000290C3
		public virtual int DescribeContents()
		{
			return StyleSpan._members.InstanceMethods.InvokeVirtualInt32Method("describeContents.()I", this, null);
		}

		// Token: 0x06001080 RID: 4224 RVA: 0x0002AEDC File Offset: 0x000290DC
		private static Delegate GetUpdateDrawState_Landroid_text_TextPaint_Handler()
		{
			if (StyleSpan.cb_updateDrawState_Landroid_text_TextPaint_ == null)
			{
				StyleSpan.cb_updateDrawState_Landroid_text_TextPaint_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(StyleSpan.n_UpdateDrawState_Landroid_text_TextPaint_));
			}
			return StyleSpan.cb_updateDrawState_Landroid_text_TextPaint_;
		}

		// Token: 0x06001081 RID: 4225 RVA: 0x0002AF00 File Offset: 0x00029100
		private static void n_UpdateDrawState_Landroid_text_TextPaint_(IntPtr jnienv, IntPtr native__this, IntPtr native_ds)
		{
			CharacterStyle @object = Java.Lang.Object.GetObject<StyleSpan>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			TextPaint object2 = Java.Lang.Object.GetObject<TextPaint>(native_ds, JniHandleOwnership.DoNotTransfer);
			@object.UpdateDrawState(object2);
		}

		// Token: 0x06001082 RID: 4226 RVA: 0x0002AF24 File Offset: 0x00029124
		public unsafe override void UpdateDrawState(TextPaint ds)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((ds == null) ? IntPtr.Zero : ds.Handle);
				StyleSpan._members.InstanceMethods.InvokeVirtualVoidMethod("updateDrawState.(Landroid/text/TextPaint;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(ds);
			}
		}

		// Token: 0x06001083 RID: 4227 RVA: 0x0002AF88 File Offset: 0x00029188
		private static Delegate GetWriteToParcel_Landroid_os_Parcel_IHandler()
		{
			if (StyleSpan.cb_writeToParcel_Landroid_os_Parcel_I == null)
			{
				StyleSpan.cb_writeToParcel_Landroid_os_Parcel_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLI_V(StyleSpan.n_WriteToParcel_Landroid_os_Parcel_I));
			}
			return StyleSpan.cb_writeToParcel_Landroid_os_Parcel_I;
		}

		// Token: 0x06001084 RID: 4228 RVA: 0x0002AFAC File Offset: 0x000291AC
		private static void n_WriteToParcel_Landroid_os_Parcel_I(IntPtr jnienv, IntPtr native__this, IntPtr native_dest, int native_flags)
		{
			StyleSpan @object = Java.Lang.Object.GetObject<StyleSpan>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Parcel object2 = Java.Lang.Object.GetObject<Parcel>(native_dest, JniHandleOwnership.DoNotTransfer);
			@object.WriteToParcel(object2, (ParcelableWriteFlags)native_flags);
		}

		// Token: 0x06001085 RID: 4229 RVA: 0x0002AFD4 File Offset: 0x000291D4
		public unsafe virtual void WriteToParcel(Parcel dest, [GeneratedEnum] ParcelableWriteFlags flags)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((dest == null) ? IntPtr.Zero : dest.Handle);
				ptr[1] = new JniArgumentValue((int)flags);
				StyleSpan._members.InstanceMethods.InvokeVirtualVoidMethod("writeToParcel.(Landroid/os/Parcel;I)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(dest);
			}
		}

		// Token: 0x04000788 RID: 1928
		private static readonly JniPeerMembers _members = new XAPeerMembers("android/text/style/StyleSpan", typeof(StyleSpan));

		// Token: 0x04000789 RID: 1929
		private static Delegate cb_getSpanTypeId;

		// Token: 0x0400078A RID: 1930
		private static Delegate cb_describeContents;

		// Token: 0x0400078B RID: 1931
		private static Delegate cb_updateDrawState_Landroid_text_TextPaint_;

		// Token: 0x0400078C RID: 1932
		private static Delegate cb_writeToParcel_Landroid_os_Parcel_I;
	}
}
