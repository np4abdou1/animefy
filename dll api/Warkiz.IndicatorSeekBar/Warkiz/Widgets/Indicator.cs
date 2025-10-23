using System;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Java.Interop;
using Java.Lang;

namespace Warkiz.Widgets
{
	// Token: 0x02000009 RID: 9
	[Register("com/warkiz/widget/Indicator", DoNotGenerateAcw = true)]
	public class Indicator : Java.Lang.Object
	{
		// Token: 0x17000011 RID: 17
		// (get) Token: 0x060000AF RID: 175 RVA: 0x00003FA4 File Offset: 0x000021A4
		internal static IntPtr class_ref
		{
			get
			{
				return Indicator._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x060000B0 RID: 176 RVA: 0x00003FC8 File Offset: 0x000021C8
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return Indicator._members;
			}
		}

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x060000B1 RID: 177 RVA: 0x00003FD0 File Offset: 0x000021D0
		protected override IntPtr ThresholdClass
		{
			get
			{
				return Indicator._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x060000B2 RID: 178 RVA: 0x00003FF4 File Offset: 0x000021F4
		protected override Type ThresholdType
		{
			get
			{
				return Indicator._members.ManagedPeerType;
			}
		}

		// Token: 0x060000B3 RID: 179 RVA: 0x00002370 File Offset: 0x00000570
		protected Indicator(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x060000B4 RID: 180 RVA: 0x00004000 File Offset: 0x00002200
		[Register(".ctor", "(Landroid/content/Context;Lcom/warkiz/widget/IndicatorSeekBar;IIIILandroid/view/View;Landroid/view/View;)V", "")]
		public unsafe Indicator(Context context, IndicatorSeekBar seekBar, int indicatorColor, [GeneratedEnum] IndicatorTypes indicatorType, int indicatorTextSize, int indicatorTextColor, View indicatorCustomView, View indicatorCustomTopContentView) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue((context == null) ? IntPtr.Zero : context.Handle);
			ptr[1] = new JniArgumentValue((seekBar == null) ? IntPtr.Zero : seekBar.Handle);
			ptr[2] = new JniArgumentValue(indicatorColor);
			ptr[3] = new JniArgumentValue((int)indicatorType);
			ptr[4] = new JniArgumentValue(indicatorTextSize);
			ptr[5] = new JniArgumentValue(indicatorTextColor);
			ptr[6] = new JniArgumentValue((indicatorCustomView == null) ? IntPtr.Zero : indicatorCustomView.Handle);
			ptr[7] = new JniArgumentValue((indicatorCustomTopContentView == null) ? IntPtr.Zero : indicatorCustomTopContentView.Handle);
			base.SetHandle(Indicator._members.InstanceMethods.StartCreateInstance("(Landroid/content/Context;Lcom/warkiz/widget/IndicatorSeekBar;IIIILandroid/view/View;Landroid/view/View;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
			Indicator._members.InstanceMethods.FinishCreateInstance("(Landroid/content/Context;Lcom/warkiz/widget/IndicatorSeekBar;IIIILandroid/view/View;Landroid/view/View;)V", this, ptr);
			GC.KeepAlive(context);
			GC.KeepAlive(seekBar);
			GC.KeepAlive(indicatorCustomView);
			GC.KeepAlive(indicatorCustomTopContentView);
		}

		// Token: 0x060000B5 RID: 181 RVA: 0x0000417C File Offset: 0x0000237C
		private static Delegate GetGetContentViewHandler()
		{
			if (Indicator.cb_getContentView == null)
			{
				Indicator.cb_getContentView = JNINativeWrapper.CreateDelegate(new Func<IntPtr, IntPtr, IntPtr>(Indicator.n_GetContentView));
			}
			return Indicator.cb_getContentView;
		}

		// Token: 0x060000B6 RID: 182 RVA: 0x000041A0 File Offset: 0x000023A0
		private static IntPtr n_GetContentView(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<Indicator>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ContentView);
		}

		// Token: 0x060000B7 RID: 183 RVA: 0x000041B4 File Offset: 0x000023B4
		private static Delegate GetSetContentView_Landroid_view_View_Handler()
		{
			if (Indicator.cb_setContentView_Landroid_view_View_ == null)
			{
				Indicator.cb_setContentView_Landroid_view_View_ = JNINativeWrapper.CreateDelegate(new Action<IntPtr, IntPtr, IntPtr>(Indicator.n_SetContentView_Landroid_view_View_));
			}
			return Indicator.cb_setContentView_Landroid_view_View_;
		}

		// Token: 0x060000B8 RID: 184 RVA: 0x000041D8 File Offset: 0x000023D8
		private static void n_SetContentView_Landroid_view_View_(IntPtr jnienv, IntPtr native__this, IntPtr native_customIndicatorView)
		{
			Indicator @object = Java.Lang.Object.GetObject<Indicator>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			View object2 = Java.Lang.Object.GetObject<View>(native_customIndicatorView, JniHandleOwnership.DoNotTransfer);
			@object.ContentView = object2;
		}

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x060000B9 RID: 185 RVA: 0x000041FC File Offset: 0x000023FC
		// (set) Token: 0x060000BA RID: 186 RVA: 0x00004230 File Offset: 0x00002430
		public unsafe virtual View ContentView
		{
			[Register("getContentView", "()Landroid/view/View;", "GetGetContentViewHandler")]
			get
			{
				return Java.Lang.Object.GetObject<View>(Indicator._members.InstanceMethods.InvokeVirtualObjectMethod("getContentView.()Landroid/view/View;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
			[Register("setContentView", "(Landroid/view/View;)V", "GetSetContentView_Landroid_view_View_Handler")]
			set
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((value == null) ? IntPtr.Zero : value.Handle);
				Indicator._members.InstanceMethods.InvokeVirtualVoidMethod("setContentView.(Landroid/view/View;)V", this, ptr);
				GC.KeepAlive(value);
			}
		}

		// Token: 0x060000BB RID: 187 RVA: 0x00004280 File Offset: 0x00002480
		private static Delegate GetGetTopContentViewHandler()
		{
			if (Indicator.cb_getTopContentView == null)
			{
				Indicator.cb_getTopContentView = JNINativeWrapper.CreateDelegate(new Func<IntPtr, IntPtr, IntPtr>(Indicator.n_GetTopContentView));
			}
			return Indicator.cb_getTopContentView;
		}

		// Token: 0x060000BC RID: 188 RVA: 0x000042A4 File Offset: 0x000024A4
		private static IntPtr n_GetTopContentView(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<Indicator>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).TopContentView);
		}

		// Token: 0x060000BD RID: 189 RVA: 0x000042B8 File Offset: 0x000024B8
		private static Delegate GetSetTopContentView_Landroid_view_View_Handler()
		{
			if (Indicator.cb_setTopContentView_Landroid_view_View_ == null)
			{
				Indicator.cb_setTopContentView_Landroid_view_View_ = JNINativeWrapper.CreateDelegate(new Action<IntPtr, IntPtr, IntPtr>(Indicator.n_SetTopContentView_Landroid_view_View_));
			}
			return Indicator.cb_setTopContentView_Landroid_view_View_;
		}

		// Token: 0x060000BE RID: 190 RVA: 0x000042DC File Offset: 0x000024DC
		private static void n_SetTopContentView_Landroid_view_View_(IntPtr jnienv, IntPtr native__this, IntPtr native_topContentView)
		{
			Indicator @object = Java.Lang.Object.GetObject<Indicator>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			View object2 = Java.Lang.Object.GetObject<View>(native_topContentView, JniHandleOwnership.DoNotTransfer);
			@object.TopContentView = object2;
		}

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x060000BF RID: 191 RVA: 0x00004300 File Offset: 0x00002500
		// (set) Token: 0x060000C0 RID: 192 RVA: 0x00004334 File Offset: 0x00002534
		public unsafe virtual View TopContentView
		{
			[Register("getTopContentView", "()Landroid/view/View;", "GetGetTopContentViewHandler")]
			get
			{
				return Java.Lang.Object.GetObject<View>(Indicator._members.InstanceMethods.InvokeVirtualObjectMethod("getTopContentView.()Landroid/view/View;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
			[Register("setTopContentView", "(Landroid/view/View;)V", "GetSetTopContentView_Landroid_view_View_Handler")]
			set
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((value == null) ? IntPtr.Zero : value.Handle);
				Indicator._members.InstanceMethods.InvokeVirtualVoidMethod("setTopContentView.(Landroid/view/View;)V", this, ptr);
				GC.KeepAlive(value);
			}
		}

		// Token: 0x060000C1 RID: 193 RVA: 0x00004384 File Offset: 0x00002584
		private static Delegate GetSetContentView_Landroid_view_View_Landroid_widget_TextView_Handler()
		{
			if (Indicator.cb_setContentView_Landroid_view_View_Landroid_widget_TextView_ == null)
			{
				Indicator.cb_setContentView_Landroid_view_View_Landroid_widget_TextView_ = JNINativeWrapper.CreateDelegate(new Action<IntPtr, IntPtr, IntPtr, IntPtr>(Indicator.n_SetContentView_Landroid_view_View_Landroid_widget_TextView_));
			}
			return Indicator.cb_setContentView_Landroid_view_View_Landroid_widget_TextView_;
		}

		// Token: 0x060000C2 RID: 194 RVA: 0x000043A8 File Offset: 0x000025A8
		private static void n_SetContentView_Landroid_view_View_Landroid_widget_TextView_(IntPtr jnienv, IntPtr native__this, IntPtr native_customIndicatorView, IntPtr native_progressTextView)
		{
			Indicator @object = Java.Lang.Object.GetObject<Indicator>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			View object2 = Java.Lang.Object.GetObject<View>(native_customIndicatorView, JniHandleOwnership.DoNotTransfer);
			TextView object3 = Java.Lang.Object.GetObject<TextView>(native_progressTextView, JniHandleOwnership.DoNotTransfer);
			@object.SetContentView(object2, object3);
		}

		// Token: 0x060000C3 RID: 195 RVA: 0x000043D4 File Offset: 0x000025D4
		[Register("setContentView", "(Landroid/view/View;Landroid/widget/TextView;)V", "GetSetContentView_Landroid_view_View_Landroid_widget_TextView_Handler")]
		public unsafe virtual void SetContentView(View customIndicatorView, TextView progressTextView)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue((customIndicatorView == null) ? IntPtr.Zero : customIndicatorView.Handle);
			ptr[1] = new JniArgumentValue((progressTextView == null) ? IntPtr.Zero : progressTextView.Handle);
			Indicator._members.InstanceMethods.InvokeVirtualVoidMethod("setContentView.(Landroid/view/View;Landroid/widget/TextView;)V", this, ptr);
			GC.KeepAlive(customIndicatorView);
			GC.KeepAlive(progressTextView);
		}

		// Token: 0x060000C4 RID: 196 RVA: 0x0000444C File Offset: 0x0000264C
		private static Delegate GetSetTopContentView_Landroid_view_View_Landroid_widget_TextView_Handler()
		{
			if (Indicator.cb_setTopContentView_Landroid_view_View_Landroid_widget_TextView_ == null)
			{
				Indicator.cb_setTopContentView_Landroid_view_View_Landroid_widget_TextView_ = JNINativeWrapper.CreateDelegate(new Action<IntPtr, IntPtr, IntPtr, IntPtr>(Indicator.n_SetTopContentView_Landroid_view_View_Landroid_widget_TextView_));
			}
			return Indicator.cb_setTopContentView_Landroid_view_View_Landroid_widget_TextView_;
		}

		// Token: 0x060000C5 RID: 197 RVA: 0x00004470 File Offset: 0x00002670
		private static void n_SetTopContentView_Landroid_view_View_Landroid_widget_TextView_(IntPtr jnienv, IntPtr native__this, IntPtr native_topContentView, IntPtr native_progressTextView)
		{
			Indicator @object = Java.Lang.Object.GetObject<Indicator>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			View object2 = Java.Lang.Object.GetObject<View>(native_topContentView, JniHandleOwnership.DoNotTransfer);
			TextView object3 = Java.Lang.Object.GetObject<TextView>(native_progressTextView, JniHandleOwnership.DoNotTransfer);
			@object.SetTopContentView(object2, object3);
		}

		// Token: 0x060000C6 RID: 198 RVA: 0x0000449C File Offset: 0x0000269C
		[Register("setTopContentView", "(Landroid/view/View;Landroid/widget/TextView;)V", "GetSetTopContentView_Landroid_view_View_Landroid_widget_TextView_Handler")]
		public unsafe virtual void SetTopContentView(View topContentView, TextView progressTextView)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue((topContentView == null) ? IntPtr.Zero : topContentView.Handle);
			ptr[1] = new JniArgumentValue((progressTextView == null) ? IntPtr.Zero : progressTextView.Handle);
			Indicator._members.InstanceMethods.InvokeVirtualVoidMethod("setTopContentView.(Landroid/view/View;Landroid/widget/TextView;)V", this, ptr);
			GC.KeepAlive(topContentView);
			GC.KeepAlive(progressTextView);
		}

		// Token: 0x0400003B RID: 59
		internal static readonly JniPeerMembers _members = new XAPeerMembers("com/warkiz/widget/Indicator", typeof(Indicator));

		// Token: 0x0400003C RID: 60
		private static Delegate cb_getContentView;

		// Token: 0x0400003D RID: 61
		private static Delegate cb_setContentView_Landroid_view_View_;

		// Token: 0x0400003E RID: 62
		private static Delegate cb_getTopContentView;

		// Token: 0x0400003F RID: 63
		private static Delegate cb_setTopContentView_Landroid_view_View_;

		// Token: 0x04000040 RID: 64
		private static Delegate cb_setContentView_Landroid_view_View_Landroid_widget_TextView_;

		// Token: 0x04000041 RID: 65
		private static Delegate cb_setTopContentView_Landroid_view_View_Landroid_widget_TextView_;
	}
}
