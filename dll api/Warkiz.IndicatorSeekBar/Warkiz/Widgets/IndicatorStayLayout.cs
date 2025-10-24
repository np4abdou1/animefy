using System;
using Android.Content;
using Android.Runtime;
using Android.Util;
using Android.Widget;
using Java.Interop;
using Java.Lang;

namespace Warkiz.Widgets
{
	// Token: 0x02000011 RID: 17
	[Register("com/warkiz/widget/IndicatorStayLayout", DoNotGenerateAcw = true)]
	public class IndicatorStayLayout : LinearLayout
	{
		// Token: 0x17000022 RID: 34
		// (get) Token: 0x06000148 RID: 328 RVA: 0x000059F4 File Offset: 0x00003BF4
		internal static IntPtr class_ref
		{
			get
			{
				return IndicatorStayLayout._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x06000149 RID: 329 RVA: 0x00005A18 File Offset: 0x00003C18
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IndicatorStayLayout._members;
			}
		}

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x0600014A RID: 330 RVA: 0x00005A20 File Offset: 0x00003C20
		protected override IntPtr ThresholdClass
		{
			get
			{
				return IndicatorStayLayout._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x0600014B RID: 331 RVA: 0x00005A44 File Offset: 0x00003C44
		protected override Type ThresholdType
		{
			get
			{
				return IndicatorStayLayout._members.ManagedPeerType;
			}
		}

		// Token: 0x0600014C RID: 332 RVA: 0x00005A50 File Offset: 0x00003C50
		protected IndicatorStayLayout(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x0600014D RID: 333 RVA: 0x00005A5C File Offset: 0x00003C5C
		[Register(".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe IndicatorStayLayout(Context context) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue((context == null) ? IntPtr.Zero : context.Handle);
			base.SetHandle(IndicatorStayLayout._members.InstanceMethods.StartCreateInstance("(Landroid/content/Context;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
			IndicatorStayLayout._members.InstanceMethods.FinishCreateInstance("(Landroid/content/Context;)V", this, ptr);
			GC.KeepAlive(context);
		}

		// Token: 0x0600014E RID: 334 RVA: 0x00005AF8 File Offset: 0x00003CF8
		[Register(".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", "")]
		public unsafe IndicatorStayLayout(Context context, IAttributeSet attrs) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue((context == null) ? IntPtr.Zero : context.Handle);
			ptr[1] = new JniArgumentValue((attrs == null) ? IntPtr.Zero : ((Java.Lang.Object)attrs).Handle);
			base.SetHandle(IndicatorStayLayout._members.InstanceMethods.StartCreateInstance("(Landroid/content/Context;Landroid/util/AttributeSet;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
			IndicatorStayLayout._members.InstanceMethods.FinishCreateInstance("(Landroid/content/Context;Landroid/util/AttributeSet;)V", this, ptr);
			GC.KeepAlive(context);
			GC.KeepAlive(attrs);
		}

		// Token: 0x0600014F RID: 335 RVA: 0x00005BC0 File Offset: 0x00003DC0
		[Register(".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", "")]
		public unsafe IndicatorStayLayout(Context context, IAttributeSet attrs, int defStyleAttr) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue((context == null) ? IntPtr.Zero : context.Handle);
			ptr[1] = new JniArgumentValue((attrs == null) ? IntPtr.Zero : ((Java.Lang.Object)attrs).Handle);
			ptr[2] = new JniArgumentValue(defStyleAttr);
			base.SetHandle(IndicatorStayLayout._members.InstanceMethods.StartCreateInstance("(Landroid/content/Context;Landroid/util/AttributeSet;I)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
			IndicatorStayLayout._members.InstanceMethods.FinishCreateInstance("(Landroid/content/Context;Landroid/util/AttributeSet;I)V", this, ptr);
			GC.KeepAlive(context);
			GC.KeepAlive(attrs);
		}

		// Token: 0x06000150 RID: 336 RVA: 0x00005C9C File Offset: 0x00003E9C
		private static Delegate GetAttachTo_Lcom_warkiz_widget_IndicatorSeekBar_Handler()
		{
			if (IndicatorStayLayout.cb_attachTo_Lcom_warkiz_widget_IndicatorSeekBar_ == null)
			{
				IndicatorStayLayout.cb_attachTo_Lcom_warkiz_widget_IndicatorSeekBar_ = JNINativeWrapper.CreateDelegate(new Action<IntPtr, IntPtr, IntPtr>(IndicatorStayLayout.n_AttachTo_Lcom_warkiz_widget_IndicatorSeekBar_));
			}
			return IndicatorStayLayout.cb_attachTo_Lcom_warkiz_widget_IndicatorSeekBar_;
		}

		// Token: 0x06000151 RID: 337 RVA: 0x00005CC0 File Offset: 0x00003EC0
		private static void n_AttachTo_Lcom_warkiz_widget_IndicatorSeekBar_(IntPtr jnienv, IntPtr native__this, IntPtr native_seekBar)
		{
			IndicatorStayLayout @object = Java.Lang.Object.GetObject<IndicatorStayLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IndicatorSeekBar object2 = Java.Lang.Object.GetObject<IndicatorSeekBar>(native_seekBar, JniHandleOwnership.DoNotTransfer);
			@object.AttachTo(object2);
		}

		// Token: 0x06000152 RID: 338 RVA: 0x00005CE4 File Offset: 0x00003EE4
		[Register("attachTo", "(Lcom/warkiz/widget/IndicatorSeekBar;)V", "GetAttachTo_Lcom_warkiz_widget_IndicatorSeekBar_Handler")]
		public unsafe virtual void AttachTo(IndicatorSeekBar seekBar)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue((seekBar == null) ? IntPtr.Zero : seekBar.Handle);
			IndicatorStayLayout._members.InstanceMethods.InvokeVirtualVoidMethod("attachTo.(Lcom/warkiz/widget/IndicatorSeekBar;)V", this, ptr);
			GC.KeepAlive(seekBar);
		}

		// Token: 0x06000153 RID: 339 RVA: 0x00005D34 File Offset: 0x00003F34
		private static Delegate GetAttachTo_Lcom_warkiz_widget_IndicatorSeekBar_IHandler()
		{
			if (IndicatorStayLayout.cb_attachTo_Lcom_warkiz_widget_IndicatorSeekBar_I == null)
			{
				IndicatorStayLayout.cb_attachTo_Lcom_warkiz_widget_IndicatorSeekBar_I = JNINativeWrapper.CreateDelegate(new Action<IntPtr, IntPtr, IntPtr, int>(IndicatorStayLayout.n_AttachTo_Lcom_warkiz_widget_IndicatorSeekBar_I));
			}
			return IndicatorStayLayout.cb_attachTo_Lcom_warkiz_widget_IndicatorSeekBar_I;
		}

		// Token: 0x06000154 RID: 340 RVA: 0x00005D58 File Offset: 0x00003F58
		private static void n_AttachTo_Lcom_warkiz_widget_IndicatorSeekBar_I(IntPtr jnienv, IntPtr native__this, IntPtr native_seekBar, int index)
		{
			IndicatorStayLayout @object = Java.Lang.Object.GetObject<IndicatorStayLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IndicatorSeekBar object2 = Java.Lang.Object.GetObject<IndicatorSeekBar>(native_seekBar, JniHandleOwnership.DoNotTransfer);
			@object.AttachTo(object2, index);
		}

		// Token: 0x06000155 RID: 341 RVA: 0x00005D7C File Offset: 0x00003F7C
		[Register("attachTo", "(Lcom/warkiz/widget/IndicatorSeekBar;I)V", "GetAttachTo_Lcom_warkiz_widget_IndicatorSeekBar_IHandler")]
		public unsafe virtual void AttachTo(IndicatorSeekBar seekBar, int index)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue((seekBar == null) ? IntPtr.Zero : seekBar.Handle);
			ptr[1] = new JniArgumentValue(index);
			IndicatorStayLayout._members.InstanceMethods.InvokeVirtualVoidMethod("attachTo.(Lcom/warkiz/widget/IndicatorSeekBar;I)V", this, ptr);
			GC.KeepAlive(seekBar);
		}

		// Token: 0x0400006F RID: 111
		internal static readonly JniPeerMembers _members = new XAPeerMembers("com/warkiz/widget/IndicatorStayLayout", typeof(IndicatorStayLayout));

		// Token: 0x04000070 RID: 112
		private static Delegate cb_attachTo_Lcom_warkiz_widget_IndicatorSeekBar_;

		// Token: 0x04000071 RID: 113
		private static Delegate cb_attachTo_Lcom_warkiz_widget_IndicatorSeekBar_I;
	}
}
