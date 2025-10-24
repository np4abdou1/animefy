using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Content;
using Android.Runtime;
using Android.Util;
using Android.Views;
using Android.Widget;
using Com.Applovin.Mediation;
using Java.Interop;
using Java.Lang;

namespace Com.Applovin.Impl.Mediation.Debugger.UI.Testmode
{
	// Token: 0x0200015B RID: 347
	[Register("com/applovin/impl/mediation/debugger/ui/testmode/AdControlButton", DoNotGenerateAcw = true)]
	public class AdControlButton : RelativeLayout, View.IOnClickListener, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x1700046F RID: 1135
		// (get) Token: 0x0600111E RID: 4382 RVA: 0x000315D0 File Offset: 0x0002F7D0
		internal static IntPtr class_ref
		{
			get
			{
				return AdControlButton._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000470 RID: 1136
		// (get) Token: 0x0600111F RID: 4383 RVA: 0x000315F4 File Offset: 0x0002F7F4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return AdControlButton._members;
			}
		}

		// Token: 0x17000471 RID: 1137
		// (get) Token: 0x06001120 RID: 4384 RVA: 0x000315FC File Offset: 0x0002F7FC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return AdControlButton._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000472 RID: 1138
		// (get) Token: 0x06001121 RID: 4385 RVA: 0x00031620 File Offset: 0x0002F820
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return AdControlButton._members.ManagedPeerType;
			}
		}

		// Token: 0x06001122 RID: 4386 RVA: 0x00016D4C File Offset: 0x00014F4C
		protected AdControlButton(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06001123 RID: 4387 RVA: 0x0003162C File Offset: 0x0002F82C
		[Register(".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe AdControlButton(Context p0) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((p0 == null) ? IntPtr.Zero : p0.Handle);
				base.SetHandle(AdControlButton._members.InstanceMethods.StartCreateInstance("(Landroid/content/Context;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				AdControlButton._members.InstanceMethods.FinishCreateInstance("(Landroid/content/Context;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(p0);
			}
		}

		// Token: 0x06001124 RID: 4388 RVA: 0x000316DC File Offset: 0x0002F8DC
		[Register(".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", "")]
		public unsafe AdControlButton(Context p0, IAttributeSet p1) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((p0 == null) ? IntPtr.Zero : p0.Handle);
				ptr[1] = new JniArgumentValue((p1 == null) ? IntPtr.Zero : ((Java.Lang.Object)p1).Handle);
				base.SetHandle(AdControlButton._members.InstanceMethods.StartCreateInstance("(Landroid/content/Context;Landroid/util/AttributeSet;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				AdControlButton._members.InstanceMethods.FinishCreateInstance("(Landroid/content/Context;Landroid/util/AttributeSet;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(p0);
				GC.KeepAlive(p1);
			}
		}

		// Token: 0x06001125 RID: 4389 RVA: 0x000317B8 File Offset: 0x0002F9B8
		[Register(".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", "")]
		public unsafe AdControlButton(Context p0, IAttributeSet p1, int p2) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((p0 == null) ? IntPtr.Zero : p0.Handle);
				ptr[1] = new JniArgumentValue((p1 == null) ? IntPtr.Zero : ((Java.Lang.Object)p1).Handle);
				ptr[2] = new JniArgumentValue(p2);
				base.SetHandle(AdControlButton._members.InstanceMethods.StartCreateInstance("(Landroid/content/Context;Landroid/util/AttributeSet;I)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				AdControlButton._members.InstanceMethods.FinishCreateInstance("(Landroid/content/Context;Landroid/util/AttributeSet;I)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(p0);
				GC.KeepAlive(p1);
			}
		}

		// Token: 0x06001126 RID: 4390 RVA: 0x000318A8 File Offset: 0x0002FAA8
		private static Delegate GetGetFormatHandler()
		{
			if (AdControlButton.cb_getFormat == null)
			{
				AdControlButton.cb_getFormat = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(AdControlButton.n_GetFormat));
			}
			return AdControlButton.cb_getFormat;
		}

		// Token: 0x06001127 RID: 4391 RVA: 0x000318CC File Offset: 0x0002FACC
		private static IntPtr n_GetFormat(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<AdControlButton>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Format);
		}

		// Token: 0x06001128 RID: 4392 RVA: 0x000318E0 File Offset: 0x0002FAE0
		private static Delegate GetSetFormat_Lcom_applovin_mediation_MaxAdFormat_Handler()
		{
			if (AdControlButton.cb_setFormat_Lcom_applovin_mediation_MaxAdFormat_ == null)
			{
				AdControlButton.cb_setFormat_Lcom_applovin_mediation_MaxAdFormat_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(AdControlButton.n_SetFormat_Lcom_applovin_mediation_MaxAdFormat_));
			}
			return AdControlButton.cb_setFormat_Lcom_applovin_mediation_MaxAdFormat_;
		}

		// Token: 0x06001129 RID: 4393 RVA: 0x00031904 File Offset: 0x0002FB04
		private static void n_SetFormat_Lcom_applovin_mediation_MaxAdFormat_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			AdControlButton @object = Java.Lang.Object.GetObject<AdControlButton>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			MaxAdFormat object2 = Java.Lang.Object.GetObject<MaxAdFormat>(native_p0, JniHandleOwnership.DoNotTransfer);
			@object.Format = object2;
		}

		// Token: 0x17000473 RID: 1139
		// (get) Token: 0x0600112A RID: 4394 RVA: 0x00031928 File Offset: 0x0002FB28
		// (set) Token: 0x0600112B RID: 4395 RVA: 0x0003195C File Offset: 0x0002FB5C
		public unsafe virtual MaxAdFormat Format
		{
			[Register("getFormat", "()Lcom/applovin/mediation/MaxAdFormat;", "GetGetFormatHandler")]
			get
			{
				return Java.Lang.Object.GetObject<MaxAdFormat>(AdControlButton._members.InstanceMethods.InvokeVirtualObjectMethod("getFormat.()Lcom/applovin/mediation/MaxAdFormat;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
			[Register("setFormat", "(Lcom/applovin/mediation/MaxAdFormat;)V", "GetSetFormat_Lcom_applovin_mediation_MaxAdFormat_Handler")]
			set
			{
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((value == null) ? IntPtr.Zero : value.Handle);
					AdControlButton._members.InstanceMethods.InvokeVirtualVoidMethod("setFormat.(Lcom/applovin/mediation/MaxAdFormat;)V", this, ptr);
				}
				finally
				{
					GC.KeepAlive(value);
				}
			}
		}

		// Token: 0x0600112C RID: 4396 RVA: 0x000319C0 File Offset: 0x0002FBC0
		private static Delegate GetOnClick_Landroid_view_View_Handler()
		{
			if (AdControlButton.cb_onClick_Landroid_view_View_ == null)
			{
				AdControlButton.cb_onClick_Landroid_view_View_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(AdControlButton.n_OnClick_Landroid_view_View_));
			}
			return AdControlButton.cb_onClick_Landroid_view_View_;
		}

		// Token: 0x0600112D RID: 4397 RVA: 0x000319E4 File Offset: 0x0002FBE4
		private static void n_OnClick_Landroid_view_View_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			AdControlButton @object = Java.Lang.Object.GetObject<AdControlButton>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			View object2 = Java.Lang.Object.GetObject<View>(native_p0, JniHandleOwnership.DoNotTransfer);
			@object.OnClick(object2);
		}

		// Token: 0x0600112E RID: 4398 RVA: 0x00031A08 File Offset: 0x0002FC08
		[Register("onClick", "(Landroid/view/View;)V", "GetOnClick_Landroid_view_View_Handler")]
		public unsafe virtual void OnClick(View p0)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((p0 == null) ? IntPtr.Zero : p0.Handle);
				AdControlButton._members.InstanceMethods.InvokeVirtualVoidMethod("onClick.(Landroid/view/View;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(p0);
			}
		}

		// Token: 0x040005A1 RID: 1441
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/applovin/impl/mediation/debugger/ui/testmode/AdControlButton", typeof(AdControlButton));

		// Token: 0x040005A2 RID: 1442
		private static Delegate cb_getFormat;

		// Token: 0x040005A3 RID: 1443
		private static Delegate cb_setFormat_Lcom_applovin_mediation_MaxAdFormat_;

		// Token: 0x040005A4 RID: 1444
		private static Delegate cb_onClick_Landroid_view_View_;
	}
}
