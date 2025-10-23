using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using Android.Content;
using Android.Graphics;
using Android.Graphics.Drawables;
using Android.OS;
using Android.Runtime;
using Android.Util;
using Android.Views;
using AndroidX.Core.View;
using Java.Interop;
using Java.Lang;

namespace AndroidX.CoordinatorLayout.Widget
{
	// Token: 0x0200002A RID: 42
	[Register("androidx/coordinatorlayout/widget/CoordinatorLayout", DoNotGenerateAcw = true)]
	public class CoordinatorLayout : ViewGroup, INestedScrollingParent2, INestedScrollingParent, IJavaObject, IDisposable, IJavaPeerable, INestedScrollingParent3
	{
		// Token: 0x06000098 RID: 152 RVA: 0x00002080 File Offset: 0x00000280
		public virtual void OnNestedScrollAccepted(View child, View target, int nestedScrollAxes, int type)
		{
			this.OnNestedScrollAccepted(child, target, (ScrollAxis)nestedScrollAxes, type);
		}

		// Token: 0x06000099 RID: 153 RVA: 0x0000209C File Offset: 0x0000029C
		public virtual bool OnStartNestedScroll(View child, View target, int axes, int type)
		{
			return this.OnStartNestedScroll(child, target, (ScrollAxis)axes, type);
		}

		// Token: 0x17000001 RID: 1
		// (get) Token: 0x0600009A RID: 154 RVA: 0x000020B8 File Offset: 0x000002B8
		internal static IntPtr class_ref
		{
			get
			{
				return CoordinatorLayout._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x0600009B RID: 155 RVA: 0x000020DC File Offset: 0x000002DC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return CoordinatorLayout._members;
			}
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x0600009C RID: 156 RVA: 0x000020E4 File Offset: 0x000002E4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return CoordinatorLayout._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x0600009D RID: 157 RVA: 0x00002108 File Offset: 0x00000308
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return CoordinatorLayout._members.ManagedPeerType;
			}
		}

		// Token: 0x0600009E RID: 158 RVA: 0x00002114 File Offset: 0x00000314
		protected CoordinatorLayout(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x0600009F RID: 159 RVA: 0x00002120 File Offset: 0x00000320
		[Register(".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe CoordinatorLayout(Context context) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((context == null) ? IntPtr.Zero : context.Handle);
				base.SetHandle(CoordinatorLayout._members.InstanceMethods.StartCreateInstance("(Landroid/content/Context;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				CoordinatorLayout._members.InstanceMethods.FinishCreateInstance("(Landroid/content/Context;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(context);
			}
		}

		// Token: 0x060000A0 RID: 160 RVA: 0x000021D0 File Offset: 0x000003D0
		[Register(".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", "")]
		public unsafe CoordinatorLayout(Context context, IAttributeSet attrs) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((context == null) ? IntPtr.Zero : context.Handle);
				ptr[1] = new JniArgumentValue((attrs == null) ? IntPtr.Zero : ((Java.Lang.Object)attrs).Handle);
				base.SetHandle(CoordinatorLayout._members.InstanceMethods.StartCreateInstance("(Landroid/content/Context;Landroid/util/AttributeSet;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				CoordinatorLayout._members.InstanceMethods.FinishCreateInstance("(Landroid/content/Context;Landroid/util/AttributeSet;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(context);
				GC.KeepAlive(attrs);
			}
		}

		// Token: 0x060000A1 RID: 161 RVA: 0x000022AC File Offset: 0x000004AC
		[Register(".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", "")]
		public unsafe CoordinatorLayout(Context context, IAttributeSet attrs, int defStyleAttr) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((context == null) ? IntPtr.Zero : context.Handle);
				ptr[1] = new JniArgumentValue((attrs == null) ? IntPtr.Zero : ((Java.Lang.Object)attrs).Handle);
				ptr[2] = new JniArgumentValue(defStyleAttr);
				base.SetHandle(CoordinatorLayout._members.InstanceMethods.StartCreateInstance("(Landroid/content/Context;Landroid/util/AttributeSet;I)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				CoordinatorLayout._members.InstanceMethods.FinishCreateInstance("(Landroid/content/Context;Landroid/util/AttributeSet;I)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(context);
				GC.KeepAlive(attrs);
			}
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x060000A2 RID: 162 RVA: 0x0000239C File Offset: 0x0000059C
		public WindowInsetsCompat LastWindowInsets
		{
			[Register("getLastWindowInsets", "()Landroidx/core/view/WindowInsetsCompat;", "")]
			get
			{
				return Java.Lang.Object.GetObject<WindowInsetsCompat>(CoordinatorLayout._members.InstanceMethods.InvokeNonvirtualObjectMethod("getLastWindowInsets.()Landroidx/core/view/WindowInsetsCompat;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x060000A3 RID: 163 RVA: 0x000023CE File Offset: 0x000005CE
		private static Delegate GetGetStatusBarBackgroundHandler()
		{
			if (CoordinatorLayout.cb_getStatusBarBackground == null)
			{
				CoordinatorLayout.cb_getStatusBarBackground = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(CoordinatorLayout.n_GetStatusBarBackground));
			}
			return CoordinatorLayout.cb_getStatusBarBackground;
		}

		// Token: 0x060000A4 RID: 164 RVA: 0x000023F2 File Offset: 0x000005F2
		private static IntPtr n_GetStatusBarBackground(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<CoordinatorLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).StatusBarBackground);
		}

		// Token: 0x060000A5 RID: 165 RVA: 0x00002406 File Offset: 0x00000606
		private static Delegate GetSetStatusBarBackground_Landroid_graphics_drawable_Drawable_Handler()
		{
			if (CoordinatorLayout.cb_setStatusBarBackground_Landroid_graphics_drawable_Drawable_ == null)
			{
				CoordinatorLayout.cb_setStatusBarBackground_Landroid_graphics_drawable_Drawable_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(CoordinatorLayout.n_SetStatusBarBackground_Landroid_graphics_drawable_Drawable_));
			}
			return CoordinatorLayout.cb_setStatusBarBackground_Landroid_graphics_drawable_Drawable_;
		}

		// Token: 0x060000A6 RID: 166 RVA: 0x0000242C File Offset: 0x0000062C
		private static void n_SetStatusBarBackground_Landroid_graphics_drawable_Drawable_(IntPtr jnienv, IntPtr native__this, IntPtr native_bg)
		{
			CoordinatorLayout @object = Java.Lang.Object.GetObject<CoordinatorLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Drawable object2 = Java.Lang.Object.GetObject<Drawable>(native_bg, JniHandleOwnership.DoNotTransfer);
			@object.StatusBarBackground = object2;
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x060000A7 RID: 167 RVA: 0x00002450 File Offset: 0x00000650
		// (set) Token: 0x060000A8 RID: 168 RVA: 0x00002484 File Offset: 0x00000684
		public unsafe virtual Drawable StatusBarBackground
		{
			[Register("getStatusBarBackground", "()Landroid/graphics/drawable/Drawable;", "GetGetStatusBarBackgroundHandler")]
			get
			{
				return Java.Lang.Object.GetObject<Drawable>(CoordinatorLayout._members.InstanceMethods.InvokeVirtualObjectMethod("getStatusBarBackground.()Landroid/graphics/drawable/Drawable;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
			[Register("setStatusBarBackground", "(Landroid/graphics/drawable/Drawable;)V", "GetSetStatusBarBackground_Landroid_graphics_drawable_Drawable_Handler")]
			set
			{
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((value == null) ? IntPtr.Zero : value.Handle);
					CoordinatorLayout._members.InstanceMethods.InvokeVirtualVoidMethod("setStatusBarBackground.(Landroid/graphics/drawable/Drawable;)V", this, ptr);
				}
				finally
				{
					GC.KeepAlive(value);
				}
			}
		}

		// Token: 0x060000A9 RID: 169 RVA: 0x000024E8 File Offset: 0x000006E8
		private static Delegate GetDispatchDependentViewsChanged_Landroid_view_View_Handler()
		{
			if (CoordinatorLayout.cb_dispatchDependentViewsChanged_Landroid_view_View_ == null)
			{
				CoordinatorLayout.cb_dispatchDependentViewsChanged_Landroid_view_View_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(CoordinatorLayout.n_DispatchDependentViewsChanged_Landroid_view_View_));
			}
			return CoordinatorLayout.cb_dispatchDependentViewsChanged_Landroid_view_View_;
		}

		// Token: 0x060000AA RID: 170 RVA: 0x0000250C File Offset: 0x0000070C
		private static void n_DispatchDependentViewsChanged_Landroid_view_View_(IntPtr jnienv, IntPtr native__this, IntPtr native_view)
		{
			CoordinatorLayout @object = Java.Lang.Object.GetObject<CoordinatorLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			View object2 = Java.Lang.Object.GetObject<View>(native_view, JniHandleOwnership.DoNotTransfer);
			@object.DispatchDependentViewsChanged(object2);
		}

		// Token: 0x060000AB RID: 171 RVA: 0x00002530 File Offset: 0x00000730
		[Register("dispatchDependentViewsChanged", "(Landroid/view/View;)V", "GetDispatchDependentViewsChanged_Landroid_view_View_Handler")]
		public unsafe virtual void DispatchDependentViewsChanged(View view)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((view == null) ? IntPtr.Zero : view.Handle);
				CoordinatorLayout._members.InstanceMethods.InvokeVirtualVoidMethod("dispatchDependentViewsChanged.(Landroid/view/View;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(view);
			}
		}

		// Token: 0x060000AC RID: 172 RVA: 0x00002594 File Offset: 0x00000794
		private static Delegate GetDoViewsOverlap_Landroid_view_View_Landroid_view_View_Handler()
		{
			if (CoordinatorLayout.cb_doViewsOverlap_Landroid_view_View_Landroid_view_View_ == null)
			{
				CoordinatorLayout.cb_doViewsOverlap_Landroid_view_View_Landroid_view_View_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_Z(CoordinatorLayout.n_DoViewsOverlap_Landroid_view_View_Landroid_view_View_));
			}
			return CoordinatorLayout.cb_doViewsOverlap_Landroid_view_View_Landroid_view_View_;
		}

		// Token: 0x060000AD RID: 173 RVA: 0x000025B8 File Offset: 0x000007B8
		private static bool n_DoViewsOverlap_Landroid_view_View_Landroid_view_View_(IntPtr jnienv, IntPtr native__this, IntPtr native_first, IntPtr native_second)
		{
			CoordinatorLayout @object = Java.Lang.Object.GetObject<CoordinatorLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			View object2 = Java.Lang.Object.GetObject<View>(native_first, JniHandleOwnership.DoNotTransfer);
			View object3 = Java.Lang.Object.GetObject<View>(native_second, JniHandleOwnership.DoNotTransfer);
			return @object.DoViewsOverlap(object2, object3);
		}

		// Token: 0x060000AE RID: 174 RVA: 0x000025E4 File Offset: 0x000007E4
		[Register("doViewsOverlap", "(Landroid/view/View;Landroid/view/View;)Z", "GetDoViewsOverlap_Landroid_view_View_Landroid_view_View_Handler")]
		public unsafe virtual bool DoViewsOverlap(View first, View second)
		{
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((first == null) ? IntPtr.Zero : first.Handle);
				ptr[1] = new JniArgumentValue((second == null) ? IntPtr.Zero : second.Handle);
				result = CoordinatorLayout._members.InstanceMethods.InvokeVirtualBooleanMethod("doViewsOverlap.(Landroid/view/View;Landroid/view/View;)Z", this, ptr);
			}
			finally
			{
				GC.KeepAlive(first);
				GC.KeepAlive(second);
			}
			return result;
		}

		// Token: 0x060000AF RID: 175 RVA: 0x00002674 File Offset: 0x00000874
		private static Delegate GetGetDependencies_Landroid_view_View_Handler()
		{
			if (CoordinatorLayout.cb_getDependencies_Landroid_view_View_ == null)
			{
				CoordinatorLayout.cb_getDependencies_Landroid_view_View_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(CoordinatorLayout.n_GetDependencies_Landroid_view_View_));
			}
			return CoordinatorLayout.cb_getDependencies_Landroid_view_View_;
		}

		// Token: 0x060000B0 RID: 176 RVA: 0x00002698 File Offset: 0x00000898
		private static IntPtr n_GetDependencies_Landroid_view_View_(IntPtr jnienv, IntPtr native__this, IntPtr native_child)
		{
			CoordinatorLayout @object = Java.Lang.Object.GetObject<CoordinatorLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			View object2 = Java.Lang.Object.GetObject<View>(native_child, JniHandleOwnership.DoNotTransfer);
			return JavaList<View>.ToLocalJniHandle(@object.GetDependencies(object2));
		}

		// Token: 0x060000B1 RID: 177 RVA: 0x000026C0 File Offset: 0x000008C0
		[Register("getDependencies", "(Landroid/view/View;)Ljava/util/List;", "GetGetDependencies_Landroid_view_View_Handler")]
		public unsafe virtual IList<View> GetDependencies(View child)
		{
			IList<View> result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((child == null) ? IntPtr.Zero : child.Handle);
				result = JavaList<View>.FromJniHandle(CoordinatorLayout._members.InstanceMethods.InvokeVirtualObjectMethod("getDependencies.(Landroid/view/View;)Ljava/util/List;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(child);
			}
			return result;
		}

		// Token: 0x060000B2 RID: 178 RVA: 0x00002734 File Offset: 0x00000934
		private static Delegate GetGetDependents_Landroid_view_View_Handler()
		{
			if (CoordinatorLayout.cb_getDependents_Landroid_view_View_ == null)
			{
				CoordinatorLayout.cb_getDependents_Landroid_view_View_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(CoordinatorLayout.n_GetDependents_Landroid_view_View_));
			}
			return CoordinatorLayout.cb_getDependents_Landroid_view_View_;
		}

		// Token: 0x060000B3 RID: 179 RVA: 0x00002758 File Offset: 0x00000958
		private static IntPtr n_GetDependents_Landroid_view_View_(IntPtr jnienv, IntPtr native__this, IntPtr native_child)
		{
			CoordinatorLayout @object = Java.Lang.Object.GetObject<CoordinatorLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			View object2 = Java.Lang.Object.GetObject<View>(native_child, JniHandleOwnership.DoNotTransfer);
			return JavaList<View>.ToLocalJniHandle(@object.GetDependents(object2));
		}

		// Token: 0x060000B4 RID: 180 RVA: 0x00002780 File Offset: 0x00000980
		[Register("getDependents", "(Landroid/view/View;)Ljava/util/List;", "GetGetDependents_Landroid_view_View_Handler")]
		public unsafe virtual IList<View> GetDependents(View child)
		{
			IList<View> result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((child == null) ? IntPtr.Zero : child.Handle);
				result = JavaList<View>.FromJniHandle(CoordinatorLayout._members.InstanceMethods.InvokeVirtualObjectMethod("getDependents.(Landroid/view/View;)Ljava/util/List;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(child);
			}
			return result;
		}

		// Token: 0x060000B5 RID: 181 RVA: 0x000027F4 File Offset: 0x000009F4
		private static Delegate GetIsPointInChildBounds_Landroid_view_View_IIHandler()
		{
			if (CoordinatorLayout.cb_isPointInChildBounds_Landroid_view_View_II == null)
			{
				CoordinatorLayout.cb_isPointInChildBounds_Landroid_view_View_II = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLII_Z(CoordinatorLayout.n_IsPointInChildBounds_Landroid_view_View_II));
			}
			return CoordinatorLayout.cb_isPointInChildBounds_Landroid_view_View_II;
		}

		// Token: 0x060000B6 RID: 182 RVA: 0x00002818 File Offset: 0x00000A18
		private static bool n_IsPointInChildBounds_Landroid_view_View_II(IntPtr jnienv, IntPtr native__this, IntPtr native_child, int x, int y)
		{
			CoordinatorLayout @object = Java.Lang.Object.GetObject<CoordinatorLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			View object2 = Java.Lang.Object.GetObject<View>(native_child, JniHandleOwnership.DoNotTransfer);
			return @object.IsPointInChildBounds(object2, x, y);
		}

		// Token: 0x060000B7 RID: 183 RVA: 0x00002840 File Offset: 0x00000A40
		[Register("isPointInChildBounds", "(Landroid/view/View;II)Z", "GetIsPointInChildBounds_Landroid_view_View_IIHandler")]
		public unsafe virtual bool IsPointInChildBounds(View child, int x, int y)
		{
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((child == null) ? IntPtr.Zero : child.Handle);
				ptr[1] = new JniArgumentValue(x);
				ptr[2] = new JniArgumentValue(y);
				result = CoordinatorLayout._members.InstanceMethods.InvokeVirtualBooleanMethod("isPointInChildBounds.(Landroid/view/View;II)Z", this, ptr);
			}
			finally
			{
				GC.KeepAlive(child);
			}
			return result;
		}

		// Token: 0x060000B8 RID: 184 RVA: 0x000028D0 File Offset: 0x00000AD0
		private static Delegate GetOnAttachedToWindowHandler()
		{
			if (CoordinatorLayout.cb_onAttachedToWindow == null)
			{
				CoordinatorLayout.cb_onAttachedToWindow = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(CoordinatorLayout.n_OnAttachedToWindow));
			}
			return CoordinatorLayout.cb_onAttachedToWindow;
		}

		// Token: 0x060000B9 RID: 185 RVA: 0x000028F4 File Offset: 0x00000AF4
		private static void n_OnAttachedToWindow(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<CoordinatorLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).OnAttachedToWindow();
		}

		// Token: 0x060000BA RID: 186 RVA: 0x00002903 File Offset: 0x00000B03
		[Register("onAttachedToWindow", "()V", "GetOnAttachedToWindowHandler")]
		public new virtual void OnAttachedToWindow()
		{
			CoordinatorLayout._members.InstanceMethods.InvokeVirtualVoidMethod("onAttachedToWindow.()V", this, null);
		}

		// Token: 0x060000BB RID: 187 RVA: 0x0000291C File Offset: 0x00000B1C
		private static Delegate GetOnDetachedFromWindowHandler()
		{
			if (CoordinatorLayout.cb_onDetachedFromWindow == null)
			{
				CoordinatorLayout.cb_onDetachedFromWindow = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(CoordinatorLayout.n_OnDetachedFromWindow));
			}
			return CoordinatorLayout.cb_onDetachedFromWindow;
		}

		// Token: 0x060000BC RID: 188 RVA: 0x00002940 File Offset: 0x00000B40
		private static void n_OnDetachedFromWindow(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<CoordinatorLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).OnDetachedFromWindow();
		}

		// Token: 0x060000BD RID: 189 RVA: 0x0000294F File Offset: 0x00000B4F
		[Register("onDetachedFromWindow", "()V", "GetOnDetachedFromWindowHandler")]
		public new virtual void OnDetachedFromWindow()
		{
			CoordinatorLayout._members.InstanceMethods.InvokeVirtualVoidMethod("onDetachedFromWindow.()V", this, null);
		}

		// Token: 0x060000BE RID: 190 RVA: 0x00002968 File Offset: 0x00000B68
		private static Delegate GetOnDraw_Landroid_graphics_Canvas_Handler()
		{
			if (CoordinatorLayout.cb_onDraw_Landroid_graphics_Canvas_ == null)
			{
				CoordinatorLayout.cb_onDraw_Landroid_graphics_Canvas_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(CoordinatorLayout.n_OnDraw_Landroid_graphics_Canvas_));
			}
			return CoordinatorLayout.cb_onDraw_Landroid_graphics_Canvas_;
		}

		// Token: 0x060000BF RID: 191 RVA: 0x0000298C File Offset: 0x00000B8C
		private static void n_OnDraw_Landroid_graphics_Canvas_(IntPtr jnienv, IntPtr native__this, IntPtr native_c)
		{
			CoordinatorLayout @object = Java.Lang.Object.GetObject<CoordinatorLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Canvas object2 = Java.Lang.Object.GetObject<Canvas>(native_c, JniHandleOwnership.DoNotTransfer);
			@object.OnDraw(object2);
		}

		// Token: 0x060000C0 RID: 192 RVA: 0x000029B0 File Offset: 0x00000BB0
		[Register("onDraw", "(Landroid/graphics/Canvas;)V", "GetOnDraw_Landroid_graphics_Canvas_Handler")]
		public new unsafe virtual void OnDraw(Canvas c)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((c == null) ? IntPtr.Zero : c.Handle);
				CoordinatorLayout._members.InstanceMethods.InvokeVirtualVoidMethod("onDraw.(Landroid/graphics/Canvas;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(c);
			}
		}

		// Token: 0x060000C1 RID: 193 RVA: 0x00002A14 File Offset: 0x00000C14
		private static Delegate GetOnLayout_ZIIIIHandler()
		{
			if (CoordinatorLayout.cb_onLayout_ZIIII == null)
			{
				CoordinatorLayout.cb_onLayout_ZIIII = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPZIIII_V(CoordinatorLayout.n_OnLayout_ZIIII));
			}
			return CoordinatorLayout.cb_onLayout_ZIIII;
		}

		// Token: 0x060000C2 RID: 194 RVA: 0x00002A38 File Offset: 0x00000C38
		private static void n_OnLayout_ZIIII(IntPtr jnienv, IntPtr native__this, bool changed, int l, int t, int r, int b)
		{
			Java.Lang.Object.GetObject<CoordinatorLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).OnLayout(changed, l, t, r, b);
		}

		// Token: 0x060000C3 RID: 195 RVA: 0x00002A50 File Offset: 0x00000C50
		[Register("onLayout", "(ZIIII)V", "GetOnLayout_ZIIIIHandler")]
		protected unsafe override void OnLayout(bool changed, int l, int t, int r, int b)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(changed);
			ptr[1] = new JniArgumentValue(l);
			ptr[2] = new JniArgumentValue(t);
			ptr[3] = new JniArgumentValue(r);
			ptr[4] = new JniArgumentValue(b);
			CoordinatorLayout._members.InstanceMethods.InvokeVirtualVoidMethod("onLayout.(ZIIII)V", this, ptr);
		}

		// Token: 0x060000C4 RID: 196 RVA: 0x00002AE2 File Offset: 0x00000CE2
		private static Delegate GetOnLayoutChild_Landroid_view_View_IHandler()
		{
			if (CoordinatorLayout.cb_onLayoutChild_Landroid_view_View_I == null)
			{
				CoordinatorLayout.cb_onLayoutChild_Landroid_view_View_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLI_V(CoordinatorLayout.n_OnLayoutChild_Landroid_view_View_I));
			}
			return CoordinatorLayout.cb_onLayoutChild_Landroid_view_View_I;
		}

		// Token: 0x060000C5 RID: 197 RVA: 0x00002B08 File Offset: 0x00000D08
		private static void n_OnLayoutChild_Landroid_view_View_I(IntPtr jnienv, IntPtr native__this, IntPtr native_child, int layoutDirection)
		{
			CoordinatorLayout @object = Java.Lang.Object.GetObject<CoordinatorLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			View object2 = Java.Lang.Object.GetObject<View>(native_child, JniHandleOwnership.DoNotTransfer);
			@object.OnLayoutChild(object2, layoutDirection);
		}

		// Token: 0x060000C6 RID: 198 RVA: 0x00002B2C File Offset: 0x00000D2C
		[Register("onLayoutChild", "(Landroid/view/View;I)V", "GetOnLayoutChild_Landroid_view_View_IHandler")]
		public unsafe virtual void OnLayoutChild(View child, int layoutDirection)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((child == null) ? IntPtr.Zero : child.Handle);
				ptr[1] = new JniArgumentValue(layoutDirection);
				CoordinatorLayout._members.InstanceMethods.InvokeVirtualVoidMethod("onLayoutChild.(Landroid/view/View;I)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(child);
			}
		}

		// Token: 0x060000C7 RID: 199 RVA: 0x00002BA4 File Offset: 0x00000DA4
		private static Delegate GetOnMeasureChild_Landroid_view_View_IIIIHandler()
		{
			if (CoordinatorLayout.cb_onMeasureChild_Landroid_view_View_IIII == null)
			{
				CoordinatorLayout.cb_onMeasureChild_Landroid_view_View_IIII = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLIIII_V(CoordinatorLayout.n_OnMeasureChild_Landroid_view_View_IIII));
			}
			return CoordinatorLayout.cb_onMeasureChild_Landroid_view_View_IIII;
		}

		// Token: 0x060000C8 RID: 200 RVA: 0x00002BC8 File Offset: 0x00000DC8
		private static void n_OnMeasureChild_Landroid_view_View_IIII(IntPtr jnienv, IntPtr native__this, IntPtr native_child, int parentWidthMeasureSpec, int widthUsed, int parentHeightMeasureSpec, int heightUsed)
		{
			CoordinatorLayout @object = Java.Lang.Object.GetObject<CoordinatorLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			View object2 = Java.Lang.Object.GetObject<View>(native_child, JniHandleOwnership.DoNotTransfer);
			@object.OnMeasureChild(object2, parentWidthMeasureSpec, widthUsed, parentHeightMeasureSpec, heightUsed);
		}

		// Token: 0x060000C9 RID: 201 RVA: 0x00002BF4 File Offset: 0x00000DF4
		[Register("onMeasureChild", "(Landroid/view/View;IIII)V", "GetOnMeasureChild_Landroid_view_View_IIIIHandler")]
		public unsafe virtual void OnMeasureChild(View child, int parentWidthMeasureSpec, int widthUsed, int parentHeightMeasureSpec, int heightUsed)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((child == null) ? IntPtr.Zero : child.Handle);
				ptr[1] = new JniArgumentValue(parentWidthMeasureSpec);
				ptr[2] = new JniArgumentValue(widthUsed);
				ptr[3] = new JniArgumentValue(parentHeightMeasureSpec);
				ptr[4] = new JniArgumentValue(heightUsed);
				CoordinatorLayout._members.InstanceMethods.InvokeVirtualVoidMethod("onMeasureChild.(Landroid/view/View;IIII)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(child);
			}
		}

		// Token: 0x060000CA RID: 202 RVA: 0x00002CB0 File Offset: 0x00000EB0
		private static Delegate GetOnNestedPreScroll_Landroid_view_View_IIarrayIIHandler()
		{
			if (CoordinatorLayout.cb_onNestedPreScroll_Landroid_view_View_IIarrayII == null)
			{
				CoordinatorLayout.cb_onNestedPreScroll_Landroid_view_View_IIarrayII = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLIILI_V(CoordinatorLayout.n_OnNestedPreScroll_Landroid_view_View_IIarrayII));
			}
			return CoordinatorLayout.cb_onNestedPreScroll_Landroid_view_View_IIarrayII;
		}

		// Token: 0x060000CB RID: 203 RVA: 0x00002CD4 File Offset: 0x00000ED4
		private static void n_OnNestedPreScroll_Landroid_view_View_IIarrayII(IntPtr jnienv, IntPtr native__this, IntPtr native_target, int dx, int dy, IntPtr native_consumed, int type)
		{
			CoordinatorLayout @object = Java.Lang.Object.GetObject<CoordinatorLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			View object2 = Java.Lang.Object.GetObject<View>(native_target, JniHandleOwnership.DoNotTransfer);
			int[] array = (int[])JNIEnv.GetArray(native_consumed, JniHandleOwnership.DoNotTransfer, typeof(int));
			@object.OnNestedPreScroll(object2, dx, dy, array, type);
			if (array != null)
			{
				JNIEnv.CopyArray(array, native_consumed);
			}
		}

		// Token: 0x060000CC RID: 204 RVA: 0x00002D20 File Offset: 0x00000F20
		[Register("onNestedPreScroll", "(Landroid/view/View;II[II)V", "GetOnNestedPreScroll_Landroid_view_View_IIarrayIIHandler")]
		public unsafe virtual void OnNestedPreScroll(View target, int dx, int dy, int[] consumed, int type)
		{
			IntPtr intPtr = JNIEnv.NewArray(consumed);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((target == null) ? IntPtr.Zero : target.Handle);
				ptr[1] = new JniArgumentValue(dx);
				ptr[2] = new JniArgumentValue(dy);
				ptr[3] = new JniArgumentValue(intPtr);
				ptr[4] = new JniArgumentValue(type);
				CoordinatorLayout._members.InstanceMethods.InvokeVirtualVoidMethod("onNestedPreScroll.(Landroid/view/View;II[II)V", this, ptr);
			}
			finally
			{
				if (consumed != null)
				{
					JNIEnv.CopyArray(intPtr, consumed);
					JNIEnv.DeleteLocalRef(intPtr);
				}
				GC.KeepAlive(target);
				GC.KeepAlive(consumed);
			}
		}

		// Token: 0x060000CD RID: 205 RVA: 0x00002DFC File Offset: 0x00000FFC
		private static Delegate GetOnNestedScroll_Landroid_view_View_IIIIIHandler()
		{
			if (CoordinatorLayout.cb_onNestedScroll_Landroid_view_View_IIIII == null)
			{
				CoordinatorLayout.cb_onNestedScroll_Landroid_view_View_IIIII = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLIIIII_V(CoordinatorLayout.n_OnNestedScroll_Landroid_view_View_IIIII));
			}
			return CoordinatorLayout.cb_onNestedScroll_Landroid_view_View_IIIII;
		}

		// Token: 0x060000CE RID: 206 RVA: 0x00002E20 File Offset: 0x00001020
		private static void n_OnNestedScroll_Landroid_view_View_IIIII(IntPtr jnienv, IntPtr native__this, IntPtr native_target, int dxConsumed, int dyConsumed, int dxUnconsumed, int dyUnconsumed, int type)
		{
			CoordinatorLayout @object = Java.Lang.Object.GetObject<CoordinatorLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			View object2 = Java.Lang.Object.GetObject<View>(native_target, JniHandleOwnership.DoNotTransfer);
			@object.OnNestedScroll(object2, dxConsumed, dyConsumed, dxUnconsumed, dyUnconsumed, type);
		}

		// Token: 0x060000CF RID: 207 RVA: 0x00002E4C File Offset: 0x0000104C
		[Register("onNestedScroll", "(Landroid/view/View;IIIII)V", "GetOnNestedScroll_Landroid_view_View_IIIIIHandler")]
		public unsafe virtual void OnNestedScroll(View target, int dxConsumed, int dyConsumed, int dxUnconsumed, int dyUnconsumed, int type)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((target == null) ? IntPtr.Zero : target.Handle);
				ptr[1] = new JniArgumentValue(dxConsumed);
				ptr[2] = new JniArgumentValue(dyConsumed);
				ptr[3] = new JniArgumentValue(dxUnconsumed);
				ptr[4] = new JniArgumentValue(dyUnconsumed);
				ptr[5] = new JniArgumentValue(type);
				CoordinatorLayout._members.InstanceMethods.InvokeVirtualVoidMethod("onNestedScroll.(Landroid/view/View;IIIII)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(target);
			}
		}

		// Token: 0x060000D0 RID: 208 RVA: 0x00002F20 File Offset: 0x00001120
		private static Delegate GetOnNestedScroll_Landroid_view_View_IIIIIarrayIHandler()
		{
			if (CoordinatorLayout.cb_onNestedScroll_Landroid_view_View_IIIIIarrayI == null)
			{
				CoordinatorLayout.cb_onNestedScroll_Landroid_view_View_IIIIIarrayI = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLIIIIIL_V(CoordinatorLayout.n_OnNestedScroll_Landroid_view_View_IIIIIarrayI));
			}
			return CoordinatorLayout.cb_onNestedScroll_Landroid_view_View_IIIIIarrayI;
		}

		// Token: 0x060000D1 RID: 209 RVA: 0x00002F44 File Offset: 0x00001144
		private static void n_OnNestedScroll_Landroid_view_View_IIIIIarrayI(IntPtr jnienv, IntPtr native__this, IntPtr native_target, int dxConsumed, int dyConsumed, int dxUnconsumed, int dyUnconsumed, int type, IntPtr native_consumed)
		{
			CoordinatorLayout @object = Java.Lang.Object.GetObject<CoordinatorLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			View object2 = Java.Lang.Object.GetObject<View>(native_target, JniHandleOwnership.DoNotTransfer);
			int[] array = (int[])JNIEnv.GetArray(native_consumed, JniHandleOwnership.DoNotTransfer, typeof(int));
			@object.OnNestedScroll(object2, dxConsumed, dyConsumed, dxUnconsumed, dyUnconsumed, type, array);
			if (array != null)
			{
				JNIEnv.CopyArray(array, native_consumed);
			}
		}

		// Token: 0x060000D2 RID: 210 RVA: 0x00002F94 File Offset: 0x00001194
		[Register("onNestedScroll", "(Landroid/view/View;IIIII[I)V", "GetOnNestedScroll_Landroid_view_View_IIIIIarrayIHandler")]
		public unsafe virtual void OnNestedScroll(View target, int dxConsumed, int dyConsumed, int dxUnconsumed, int dyUnconsumed, int type, int[] consumed)
		{
			IntPtr intPtr = JNIEnv.NewArray(consumed);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((target == null) ? IntPtr.Zero : target.Handle);
				ptr[1] = new JniArgumentValue(dxConsumed);
				ptr[2] = new JniArgumentValue(dyConsumed);
				ptr[3] = new JniArgumentValue(dxUnconsumed);
				ptr[4] = new JniArgumentValue(dyUnconsumed);
				ptr[5] = new JniArgumentValue(type);
				ptr[6] = new JniArgumentValue(intPtr);
				CoordinatorLayout._members.InstanceMethods.InvokeVirtualVoidMethod("onNestedScroll.(Landroid/view/View;IIIII[I)V", this, ptr);
			}
			finally
			{
				if (consumed != null)
				{
					JNIEnv.CopyArray(intPtr, consumed);
					JNIEnv.DeleteLocalRef(intPtr);
				}
				GC.KeepAlive(target);
				GC.KeepAlive(consumed);
			}
		}

		// Token: 0x060000D3 RID: 211 RVA: 0x0000309C File Offset: 0x0000129C
		private static Delegate GetOnNestedScrollAccepted_Landroid_view_View_Landroid_view_View_IIHandler()
		{
			if (CoordinatorLayout.cb_onNestedScrollAccepted_Landroid_view_View_Landroid_view_View_II == null)
			{
				CoordinatorLayout.cb_onNestedScrollAccepted_Landroid_view_View_Landroid_view_View_II = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLLII_V(CoordinatorLayout.n_OnNestedScrollAccepted_Landroid_view_View_Landroid_view_View_II));
			}
			return CoordinatorLayout.cb_onNestedScrollAccepted_Landroid_view_View_Landroid_view_View_II;
		}

		// Token: 0x060000D4 RID: 212 RVA: 0x000030C0 File Offset: 0x000012C0
		private static void n_OnNestedScrollAccepted_Landroid_view_View_Landroid_view_View_II(IntPtr jnienv, IntPtr native__this, IntPtr native_child, IntPtr native_target, int native_axes, int type)
		{
			CoordinatorLayout @object = Java.Lang.Object.GetObject<CoordinatorLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			View object2 = Java.Lang.Object.GetObject<View>(native_child, JniHandleOwnership.DoNotTransfer);
			View object3 = Java.Lang.Object.GetObject<View>(native_target, JniHandleOwnership.DoNotTransfer);
			@object.OnNestedScrollAccepted(object2, object3, (ScrollAxis)native_axes, type);
		}

		// Token: 0x060000D5 RID: 213 RVA: 0x000030F4 File Offset: 0x000012F4
		[Register("onNestedScrollAccepted", "(Landroid/view/View;Landroid/view/View;II)V", "GetOnNestedScrollAccepted_Landroid_view_View_Landroid_view_View_IIHandler")]
		public unsafe virtual void OnNestedScrollAccepted(View child, View target, [GeneratedEnum] ScrollAxis axes, int type)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((child == null) ? IntPtr.Zero : child.Handle);
				ptr[1] = new JniArgumentValue((target == null) ? IntPtr.Zero : target.Handle);
				ptr[2] = new JniArgumentValue((int)axes);
				ptr[3] = new JniArgumentValue(type);
				CoordinatorLayout._members.InstanceMethods.InvokeVirtualVoidMethod("onNestedScrollAccepted.(Landroid/view/View;Landroid/view/View;II)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(child);
				GC.KeepAlive(target);
			}
		}

		// Token: 0x060000D6 RID: 214 RVA: 0x000031AC File Offset: 0x000013AC
		private static Delegate GetOnStartNestedScroll_Landroid_view_View_Landroid_view_View_IIHandler()
		{
			if (CoordinatorLayout.cb_onStartNestedScroll_Landroid_view_View_Landroid_view_View_II == null)
			{
				CoordinatorLayout.cb_onStartNestedScroll_Landroid_view_View_Landroid_view_View_II = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLLII_Z(CoordinatorLayout.n_OnStartNestedScroll_Landroid_view_View_Landroid_view_View_II));
			}
			return CoordinatorLayout.cb_onStartNestedScroll_Landroid_view_View_Landroid_view_View_II;
		}

		// Token: 0x060000D7 RID: 215 RVA: 0x000031D0 File Offset: 0x000013D0
		private static bool n_OnStartNestedScroll_Landroid_view_View_Landroid_view_View_II(IntPtr jnienv, IntPtr native__this, IntPtr native_child, IntPtr native_target, int native_axes, int type)
		{
			CoordinatorLayout @object = Java.Lang.Object.GetObject<CoordinatorLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			View object2 = Java.Lang.Object.GetObject<View>(native_child, JniHandleOwnership.DoNotTransfer);
			View object3 = Java.Lang.Object.GetObject<View>(native_target, JniHandleOwnership.DoNotTransfer);
			return @object.OnStartNestedScroll(object2, object3, (ScrollAxis)native_axes, type);
		}

		// Token: 0x060000D8 RID: 216 RVA: 0x00003204 File Offset: 0x00001404
		[Register("onStartNestedScroll", "(Landroid/view/View;Landroid/view/View;II)Z", "GetOnStartNestedScroll_Landroid_view_View_Landroid_view_View_IIHandler")]
		public unsafe virtual bool OnStartNestedScroll(View child, View target, [GeneratedEnum] ScrollAxis axes, int type)
		{
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((child == null) ? IntPtr.Zero : child.Handle);
				ptr[1] = new JniArgumentValue((target == null) ? IntPtr.Zero : target.Handle);
				ptr[2] = new JniArgumentValue((int)axes);
				ptr[3] = new JniArgumentValue(type);
				result = CoordinatorLayout._members.InstanceMethods.InvokeVirtualBooleanMethod("onStartNestedScroll.(Landroid/view/View;Landroid/view/View;II)Z", this, ptr);
			}
			finally
			{
				GC.KeepAlive(child);
				GC.KeepAlive(target);
			}
			return result;
		}

		// Token: 0x060000D9 RID: 217 RVA: 0x000032C0 File Offset: 0x000014C0
		private static Delegate GetOnStopNestedScroll_Landroid_view_View_IHandler()
		{
			if (CoordinatorLayout.cb_onStopNestedScroll_Landroid_view_View_I == null)
			{
				CoordinatorLayout.cb_onStopNestedScroll_Landroid_view_View_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLI_V(CoordinatorLayout.n_OnStopNestedScroll_Landroid_view_View_I));
			}
			return CoordinatorLayout.cb_onStopNestedScroll_Landroid_view_View_I;
		}

		// Token: 0x060000DA RID: 218 RVA: 0x000032E4 File Offset: 0x000014E4
		private static void n_OnStopNestedScroll_Landroid_view_View_I(IntPtr jnienv, IntPtr native__this, IntPtr native_target, int type)
		{
			CoordinatorLayout @object = Java.Lang.Object.GetObject<CoordinatorLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			View object2 = Java.Lang.Object.GetObject<View>(native_target, JniHandleOwnership.DoNotTransfer);
			@object.OnStopNestedScroll(object2, type);
		}

		// Token: 0x060000DB RID: 219 RVA: 0x00003308 File Offset: 0x00001508
		[Register("onStopNestedScroll", "(Landroid/view/View;I)V", "GetOnStopNestedScroll_Landroid_view_View_IHandler")]
		public unsafe virtual void OnStopNestedScroll(View target, int type)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((target == null) ? IntPtr.Zero : target.Handle);
				ptr[1] = new JniArgumentValue(type);
				CoordinatorLayout._members.InstanceMethods.InvokeVirtualVoidMethod("onStopNestedScroll.(Landroid/view/View;I)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(target);
			}
		}

		// Token: 0x060000DC RID: 220 RVA: 0x00003380 File Offset: 0x00001580
		private static Delegate GetSetStatusBarBackgroundColor_IHandler()
		{
			if (CoordinatorLayout.cb_setStatusBarBackgroundColor_I == null)
			{
				CoordinatorLayout.cb_setStatusBarBackgroundColor_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_V(CoordinatorLayout.n_SetStatusBarBackgroundColor_I));
			}
			return CoordinatorLayout.cb_setStatusBarBackgroundColor_I;
		}

		// Token: 0x060000DD RID: 221 RVA: 0x000033A4 File Offset: 0x000015A4
		private static void n_SetStatusBarBackgroundColor_I(IntPtr jnienv, IntPtr native__this, int color)
		{
			Java.Lang.Object.GetObject<CoordinatorLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SetStatusBarBackgroundColor(color);
		}

		// Token: 0x060000DE RID: 222 RVA: 0x000033B4 File Offset: 0x000015B4
		[Register("setStatusBarBackgroundColor", "(I)V", "GetSetStatusBarBackgroundColor_IHandler")]
		public unsafe virtual void SetStatusBarBackgroundColor(int color)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(color);
			CoordinatorLayout._members.InstanceMethods.InvokeVirtualVoidMethod("setStatusBarBackgroundColor.(I)V", this, ptr);
		}

		// Token: 0x060000DF RID: 223 RVA: 0x000033EF File Offset: 0x000015EF
		private static Delegate GetSetStatusBarBackgroundResource_IHandler()
		{
			if (CoordinatorLayout.cb_setStatusBarBackgroundResource_I == null)
			{
				CoordinatorLayout.cb_setStatusBarBackgroundResource_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_V(CoordinatorLayout.n_SetStatusBarBackgroundResource_I));
			}
			return CoordinatorLayout.cb_setStatusBarBackgroundResource_I;
		}

		// Token: 0x060000E0 RID: 224 RVA: 0x00003413 File Offset: 0x00001613
		private static void n_SetStatusBarBackgroundResource_I(IntPtr jnienv, IntPtr native__this, int resId)
		{
			Java.Lang.Object.GetObject<CoordinatorLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SetStatusBarBackgroundResource(resId);
		}

		// Token: 0x060000E1 RID: 225 RVA: 0x00003424 File Offset: 0x00001624
		[Register("setStatusBarBackgroundResource", "(I)V", "GetSetStatusBarBackgroundResource_IHandler")]
		public unsafe virtual void SetStatusBarBackgroundResource(int resId)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(resId);
			CoordinatorLayout._members.InstanceMethods.InvokeVirtualVoidMethod("setStatusBarBackgroundResource.(I)V", this, ptr);
		}

		// Token: 0x04000003 RID: 3
		private static readonly JniPeerMembers _members = new XAPeerMembers("androidx/coordinatorlayout/widget/CoordinatorLayout", typeof(CoordinatorLayout));

		// Token: 0x04000004 RID: 4
		private static Delegate cb_getStatusBarBackground;

		// Token: 0x04000005 RID: 5
		private static Delegate cb_setStatusBarBackground_Landroid_graphics_drawable_Drawable_;

		// Token: 0x04000006 RID: 6
		private static Delegate cb_dispatchDependentViewsChanged_Landroid_view_View_;

		// Token: 0x04000007 RID: 7
		private static Delegate cb_doViewsOverlap_Landroid_view_View_Landroid_view_View_;

		// Token: 0x04000008 RID: 8
		private static Delegate cb_getDependencies_Landroid_view_View_;

		// Token: 0x04000009 RID: 9
		private static Delegate cb_getDependents_Landroid_view_View_;

		// Token: 0x0400000A RID: 10
		private static Delegate cb_isPointInChildBounds_Landroid_view_View_II;

		// Token: 0x0400000B RID: 11
		private static Delegate cb_onAttachedToWindow;

		// Token: 0x0400000C RID: 12
		private static Delegate cb_onDetachedFromWindow;

		// Token: 0x0400000D RID: 13
		private static Delegate cb_onDraw_Landroid_graphics_Canvas_;

		// Token: 0x0400000E RID: 14
		private static Delegate cb_onLayout_ZIIII;

		// Token: 0x0400000F RID: 15
		private static Delegate cb_onLayoutChild_Landroid_view_View_I;

		// Token: 0x04000010 RID: 16
		private static Delegate cb_onMeasureChild_Landroid_view_View_IIII;

		// Token: 0x04000011 RID: 17
		private static Delegate cb_onNestedPreScroll_Landroid_view_View_IIarrayII;

		// Token: 0x04000012 RID: 18
		private static Delegate cb_onNestedScroll_Landroid_view_View_IIIII;

		// Token: 0x04000013 RID: 19
		private static Delegate cb_onNestedScroll_Landroid_view_View_IIIIIarrayI;

		// Token: 0x04000014 RID: 20
		private static Delegate cb_onNestedScrollAccepted_Landroid_view_View_Landroid_view_View_II;

		// Token: 0x04000015 RID: 21
		private static Delegate cb_onStartNestedScroll_Landroid_view_View_Landroid_view_View_II;

		// Token: 0x04000016 RID: 22
		private static Delegate cb_onStopNestedScroll_Landroid_view_View_I;

		// Token: 0x04000017 RID: 23
		private static Delegate cb_setStatusBarBackgroundColor_I;

		// Token: 0x04000018 RID: 24
		private static Delegate cb_setStatusBarBackgroundResource_I;

		// Token: 0x0200002B RID: 43
		[Register("androidx/coordinatorlayout/widget/CoordinatorLayout$AttachedBehavior", "", "AndroidX.CoordinatorLayout.Widget.CoordinatorLayout/IAttachedBehaviorInvoker")]
		public interface IAttachedBehavior : IJavaObject, IDisposable, IJavaPeerable
		{
			// Token: 0x060000E3 RID: 227
			[Register("getBehavior", "()Landroidx/coordinatorlayout/widget/CoordinatorLayout$Behavior;", "GetGetBehaviorHandler:AndroidX.CoordinatorLayout.Widget.CoordinatorLayout/IAttachedBehaviorInvoker, Xamarin.AndroidX.CoordinatorLayout")]
			CoordinatorLayout.Behavior GetBehavior();
		}

		// Token: 0x0200002C RID: 44
		[Register("androidx/coordinatorlayout/widget/CoordinatorLayout$AttachedBehavior", DoNotGenerateAcw = true)]
		internal class IAttachedBehaviorInvoker : Java.Lang.Object, CoordinatorLayout.IAttachedBehavior, IJavaObject, IDisposable, IJavaPeerable
		{
			// Token: 0x17000007 RID: 7
			// (get) Token: 0x060000E4 RID: 228 RVA: 0x0000347C File Offset: 0x0000167C
			private static IntPtr java_class_ref
			{
				get
				{
					return CoordinatorLayout.IAttachedBehaviorInvoker._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x17000008 RID: 8
			// (get) Token: 0x060000E5 RID: 229 RVA: 0x000034A0 File Offset: 0x000016A0
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return CoordinatorLayout.IAttachedBehaviorInvoker._members;
				}
			}

			// Token: 0x17000009 RID: 9
			// (get) Token: 0x060000E6 RID: 230 RVA: 0x000034A7 File Offset: 0x000016A7
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return this.class_ref;
				}
			}

			// Token: 0x1700000A RID: 10
			// (get) Token: 0x060000E7 RID: 231 RVA: 0x000034AF File Offset: 0x000016AF
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return CoordinatorLayout.IAttachedBehaviorInvoker._members.ManagedPeerType;
				}
			}

			// Token: 0x060000E8 RID: 232 RVA: 0x000034BB File Offset: 0x000016BB
			public static CoordinatorLayout.IAttachedBehavior GetObject(IntPtr handle, JniHandleOwnership transfer)
			{
				return Java.Lang.Object.GetObject<CoordinatorLayout.IAttachedBehavior>(handle, transfer);
			}

			// Token: 0x060000E9 RID: 233 RVA: 0x000034C4 File Offset: 0x000016C4
			private static IntPtr Validate(IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf(handle, CoordinatorLayout.IAttachedBehaviorInvoker.java_class_ref))
				{
					throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'androidx.coordinatorlayout.widget.CoordinatorLayout.AttachedBehavior'.");
				}
				return handle;
			}

			// Token: 0x060000EA RID: 234 RVA: 0x000034EF File Offset: 0x000016EF
			protected override void Dispose(bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
				{
					JNIEnv.DeleteGlobalRef(this.class_ref);
				}
				this.class_ref = IntPtr.Zero;
				base.Dispose(disposing);
			}

			// Token: 0x060000EB RID: 235 RVA: 0x00003520 File Offset: 0x00001720
			public IAttachedBehaviorInvoker(IntPtr handle, JniHandleOwnership transfer) : base(CoordinatorLayout.IAttachedBehaviorInvoker.Validate(handle), transfer)
			{
				IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
				this.class_ref = JNIEnv.NewGlobalRef(objectClass);
				JNIEnv.DeleteLocalRef(objectClass);
			}

			// Token: 0x060000EC RID: 236 RVA: 0x00003558 File Offset: 0x00001758
			private static Delegate GetGetBehaviorHandler()
			{
				if (CoordinatorLayout.IAttachedBehaviorInvoker.cb_getBehavior == null)
				{
					CoordinatorLayout.IAttachedBehaviorInvoker.cb_getBehavior = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(CoordinatorLayout.IAttachedBehaviorInvoker.n_GetBehavior));
				}
				return CoordinatorLayout.IAttachedBehaviorInvoker.cb_getBehavior;
			}

			// Token: 0x060000ED RID: 237 RVA: 0x0000357C File Offset: 0x0000177C
			private static IntPtr n_GetBehavior(IntPtr jnienv, IntPtr native__this)
			{
				return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<CoordinatorLayout.IAttachedBehavior>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).GetBehavior());
			}

			// Token: 0x060000EE RID: 238 RVA: 0x00003590 File Offset: 0x00001790
			public CoordinatorLayout.Behavior GetBehavior()
			{
				if (this.id_getBehavior == IntPtr.Zero)
				{
					this.id_getBehavior = JNIEnv.GetMethodID(this.class_ref, "getBehavior", "()Landroidx/coordinatorlayout/widget/CoordinatorLayout$Behavior;");
				}
				return Java.Lang.Object.GetObject<CoordinatorLayout.Behavior>(JNIEnv.CallObjectMethod(base.Handle, this.id_getBehavior), JniHandleOwnership.TransferLocalRef);
			}

			// Token: 0x04000019 RID: 25
			private static readonly JniPeerMembers _members = new XAPeerMembers("androidx/coordinatorlayout/widget/CoordinatorLayout$AttachedBehavior", typeof(CoordinatorLayout.IAttachedBehaviorInvoker));

			// Token: 0x0400001A RID: 26
			private IntPtr class_ref;

			// Token: 0x0400001B RID: 27
			private static Delegate cb_getBehavior;

			// Token: 0x0400001C RID: 28
			private IntPtr id_getBehavior;
		}

		// Token: 0x0200002D RID: 45
		[Register("androidx/coordinatorlayout/widget/CoordinatorLayout$Behavior", DoNotGenerateAcw = true)]
		[JavaTypeParameters(new string[]
		{
			"V extends android.view.View"
		})]
		public abstract class Behavior : Java.Lang.Object
		{
			// Token: 0x1700000B RID: 11
			// (get) Token: 0x060000F0 RID: 240 RVA: 0x000035FC File Offset: 0x000017FC
			internal static IntPtr class_ref
			{
				get
				{
					return CoordinatorLayout.Behavior._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x1700000C RID: 12
			// (get) Token: 0x060000F1 RID: 241 RVA: 0x00003620 File Offset: 0x00001820
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return CoordinatorLayout.Behavior._members;
				}
			}

			// Token: 0x1700000D RID: 13
			// (get) Token: 0x060000F2 RID: 242 RVA: 0x00003628 File Offset: 0x00001828
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return CoordinatorLayout.Behavior._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x1700000E RID: 14
			// (get) Token: 0x060000F3 RID: 243 RVA: 0x0000364C File Offset: 0x0000184C
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return CoordinatorLayout.Behavior._members.ManagedPeerType;
				}
			}

			// Token: 0x060000F4 RID: 244 RVA: 0x00003658 File Offset: 0x00001858
			protected Behavior(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
			{
			}

			// Token: 0x060000F5 RID: 245 RVA: 0x00003664 File Offset: 0x00001864
			[Register(".ctor", "()V", "")]
			public Behavior() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (base.Handle != IntPtr.Zero)
				{
					return;
				}
				base.SetHandle(CoordinatorLayout.Behavior._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
				CoordinatorLayout.Behavior._members.InstanceMethods.FinishCreateInstance("()V", this, null);
			}

			// Token: 0x060000F6 RID: 246 RVA: 0x000036D4 File Offset: 0x000018D4
			[Register(".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", "")]
			public unsafe Behavior(Context context, IAttributeSet attrs) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (base.Handle != IntPtr.Zero)
				{
					return;
				}
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((context == null) ? IntPtr.Zero : context.Handle);
					ptr[1] = new JniArgumentValue((attrs == null) ? IntPtr.Zero : ((Java.Lang.Object)attrs).Handle);
					base.SetHandle(CoordinatorLayout.Behavior._members.InstanceMethods.StartCreateInstance("(Landroid/content/Context;Landroid/util/AttributeSet;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
					CoordinatorLayout.Behavior._members.InstanceMethods.FinishCreateInstance("(Landroid/content/Context;Landroid/util/AttributeSet;)V", this, ptr);
				}
				finally
				{
					GC.KeepAlive(context);
					GC.KeepAlive(attrs);
				}
			}

			// Token: 0x060000F7 RID: 247 RVA: 0x000037B0 File Offset: 0x000019B0
			private static Delegate GetBlocksInteractionBelow_Landroidx_coordinatorlayout_widget_CoordinatorLayout_Landroid_view_View_Handler()
			{
				if (CoordinatorLayout.Behavior.cb_blocksInteractionBelow_Landroidx_coordinatorlayout_widget_CoordinatorLayout_Landroid_view_View_ == null)
				{
					CoordinatorLayout.Behavior.cb_blocksInteractionBelow_Landroidx_coordinatorlayout_widget_CoordinatorLayout_Landroid_view_View_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_Z(CoordinatorLayout.Behavior.n_BlocksInteractionBelow_Landroidx_coordinatorlayout_widget_CoordinatorLayout_Landroid_view_View_));
				}
				return CoordinatorLayout.Behavior.cb_blocksInteractionBelow_Landroidx_coordinatorlayout_widget_CoordinatorLayout_Landroid_view_View_;
			}

			// Token: 0x060000F8 RID: 248 RVA: 0x000037D4 File Offset: 0x000019D4
			private static bool n_BlocksInteractionBelow_Landroidx_coordinatorlayout_widget_CoordinatorLayout_Landroid_view_View_(IntPtr jnienv, IntPtr native__this, IntPtr native_parent, IntPtr native_child)
			{
				CoordinatorLayout.Behavior @object = Java.Lang.Object.GetObject<CoordinatorLayout.Behavior>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				CoordinatorLayout object2 = Java.Lang.Object.GetObject<CoordinatorLayout>(native_parent, JniHandleOwnership.DoNotTransfer);
				Java.Lang.Object object3 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_child, JniHandleOwnership.DoNotTransfer);
				return @object.BlocksInteractionBelow(object2, object3);
			}

			// Token: 0x060000F9 RID: 249 RVA: 0x00003800 File Offset: 0x00001A00
			[Register("blocksInteractionBelow", "(Landroidx/coordinatorlayout/widget/CoordinatorLayout;Landroid/view/View;)Z", "GetBlocksInteractionBelow_Landroidx_coordinatorlayout_widget_CoordinatorLayout_Landroid_view_View_Handler")]
			public unsafe virtual bool BlocksInteractionBelow(CoordinatorLayout parent, Java.Lang.Object child)
			{
				IntPtr intPtr = JNIEnv.ToLocalJniHandle(child);
				bool result;
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((parent == null) ? IntPtr.Zero : parent.Handle);
					ptr[1] = new JniArgumentValue(intPtr);
					result = CoordinatorLayout.Behavior._members.InstanceMethods.InvokeVirtualBooleanMethod("blocksInteractionBelow.(Landroidx/coordinatorlayout/widget/CoordinatorLayout;Landroid/view/View;)Z", this, ptr);
				}
				finally
				{
					JNIEnv.DeleteLocalRef(intPtr);
					GC.KeepAlive(parent);
					GC.KeepAlive(child);
				}
				return result;
			}

			// Token: 0x060000FA RID: 250 RVA: 0x0000388C File Offset: 0x00001A8C
			private static Delegate GetGetInsetDodgeRect_Landroidx_coordinatorlayout_widget_CoordinatorLayout_Landroid_view_View_Landroid_graphics_Rect_Handler()
			{
				if (CoordinatorLayout.Behavior.cb_getInsetDodgeRect_Landroidx_coordinatorlayout_widget_CoordinatorLayout_Landroid_view_View_Landroid_graphics_Rect_ == null)
				{
					CoordinatorLayout.Behavior.cb_getInsetDodgeRect_Landroidx_coordinatorlayout_widget_CoordinatorLayout_Landroid_view_View_Landroid_graphics_Rect_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLLL_Z(CoordinatorLayout.Behavior.n_GetInsetDodgeRect_Landroidx_coordinatorlayout_widget_CoordinatorLayout_Landroid_view_View_Landroid_graphics_Rect_));
				}
				return CoordinatorLayout.Behavior.cb_getInsetDodgeRect_Landroidx_coordinatorlayout_widget_CoordinatorLayout_Landroid_view_View_Landroid_graphics_Rect_;
			}

			// Token: 0x060000FB RID: 251 RVA: 0x000038B0 File Offset: 0x00001AB0
			private static bool n_GetInsetDodgeRect_Landroidx_coordinatorlayout_widget_CoordinatorLayout_Landroid_view_View_Landroid_graphics_Rect_(IntPtr jnienv, IntPtr native__this, IntPtr native_parent, IntPtr native_child, IntPtr native_rect)
			{
				CoordinatorLayout.Behavior @object = Java.Lang.Object.GetObject<CoordinatorLayout.Behavior>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				CoordinatorLayout object2 = Java.Lang.Object.GetObject<CoordinatorLayout>(native_parent, JniHandleOwnership.DoNotTransfer);
				Java.Lang.Object object3 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_child, JniHandleOwnership.DoNotTransfer);
				Rect object4 = Java.Lang.Object.GetObject<Rect>(native_rect, JniHandleOwnership.DoNotTransfer);
				return @object.GetInsetDodgeRect(object2, object3, object4);
			}

			// Token: 0x060000FC RID: 252 RVA: 0x000038E8 File Offset: 0x00001AE8
			[Register("getInsetDodgeRect", "(Landroidx/coordinatorlayout/widget/CoordinatorLayout;Landroid/view/View;Landroid/graphics/Rect;)Z", "GetGetInsetDodgeRect_Landroidx_coordinatorlayout_widget_CoordinatorLayout_Landroid_view_View_Landroid_graphics_Rect_Handler")]
			public unsafe virtual bool GetInsetDodgeRect(CoordinatorLayout parent, Java.Lang.Object child, Rect rect)
			{
				IntPtr intPtr = JNIEnv.ToLocalJniHandle(child);
				bool result;
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((parent == null) ? IntPtr.Zero : parent.Handle);
					ptr[1] = new JniArgumentValue(intPtr);
					ptr[2] = new JniArgumentValue((rect == null) ? IntPtr.Zero : rect.Handle);
					result = CoordinatorLayout.Behavior._members.InstanceMethods.InvokeVirtualBooleanMethod("getInsetDodgeRect.(Landroidx/coordinatorlayout/widget/CoordinatorLayout;Landroid/view/View;Landroid/graphics/Rect;)Z", this, ptr);
				}
				finally
				{
					JNIEnv.DeleteLocalRef(intPtr);
					GC.KeepAlive(parent);
					GC.KeepAlive(child);
					GC.KeepAlive(rect);
				}
				return result;
			}

			// Token: 0x060000FD RID: 253 RVA: 0x000039A0 File Offset: 0x00001BA0
			private static Delegate GetGetScrimColor_Landroidx_coordinatorlayout_widget_CoordinatorLayout_Landroid_view_View_Handler()
			{
				if (CoordinatorLayout.Behavior.cb_getScrimColor_Landroidx_coordinatorlayout_widget_CoordinatorLayout_Landroid_view_View_ == null)
				{
					CoordinatorLayout.Behavior.cb_getScrimColor_Landroidx_coordinatorlayout_widget_CoordinatorLayout_Landroid_view_View_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_I(CoordinatorLayout.Behavior.n_GetScrimColor_Landroidx_coordinatorlayout_widget_CoordinatorLayout_Landroid_view_View_));
				}
				return CoordinatorLayout.Behavior.cb_getScrimColor_Landroidx_coordinatorlayout_widget_CoordinatorLayout_Landroid_view_View_;
			}

			// Token: 0x060000FE RID: 254 RVA: 0x000039C4 File Offset: 0x00001BC4
			private static int n_GetScrimColor_Landroidx_coordinatorlayout_widget_CoordinatorLayout_Landroid_view_View_(IntPtr jnienv, IntPtr native__this, IntPtr native_parent, IntPtr native_child)
			{
				CoordinatorLayout.Behavior @object = Java.Lang.Object.GetObject<CoordinatorLayout.Behavior>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				CoordinatorLayout object2 = Java.Lang.Object.GetObject<CoordinatorLayout>(native_parent, JniHandleOwnership.DoNotTransfer);
				Java.Lang.Object object3 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_child, JniHandleOwnership.DoNotTransfer);
				return @object.GetScrimColor(object2, object3);
			}

			// Token: 0x060000FF RID: 255 RVA: 0x000039F0 File Offset: 0x00001BF0
			[Register("getScrimColor", "(Landroidx/coordinatorlayout/widget/CoordinatorLayout;Landroid/view/View;)I", "GetGetScrimColor_Landroidx_coordinatorlayout_widget_CoordinatorLayout_Landroid_view_View_Handler")]
			public unsafe virtual int GetScrimColor(CoordinatorLayout parent, Java.Lang.Object child)
			{
				IntPtr intPtr = JNIEnv.ToLocalJniHandle(child);
				int result;
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((parent == null) ? IntPtr.Zero : parent.Handle);
					ptr[1] = new JniArgumentValue(intPtr);
					result = CoordinatorLayout.Behavior._members.InstanceMethods.InvokeVirtualInt32Method("getScrimColor.(Landroidx/coordinatorlayout/widget/CoordinatorLayout;Landroid/view/View;)I", this, ptr);
				}
				finally
				{
					JNIEnv.DeleteLocalRef(intPtr);
					GC.KeepAlive(parent);
					GC.KeepAlive(child);
				}
				return result;
			}

			// Token: 0x06000100 RID: 256 RVA: 0x00003A7C File Offset: 0x00001C7C
			private static Delegate GetGetScrimOpacity_Landroidx_coordinatorlayout_widget_CoordinatorLayout_Landroid_view_View_Handler()
			{
				if (CoordinatorLayout.Behavior.cb_getScrimOpacity_Landroidx_coordinatorlayout_widget_CoordinatorLayout_Landroid_view_View_ == null)
				{
					CoordinatorLayout.Behavior.cb_getScrimOpacity_Landroidx_coordinatorlayout_widget_CoordinatorLayout_Landroid_view_View_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_F(CoordinatorLayout.Behavior.n_GetScrimOpacity_Landroidx_coordinatorlayout_widget_CoordinatorLayout_Landroid_view_View_));
				}
				return CoordinatorLayout.Behavior.cb_getScrimOpacity_Landroidx_coordinatorlayout_widget_CoordinatorLayout_Landroid_view_View_;
			}

			// Token: 0x06000101 RID: 257 RVA: 0x00003AA0 File Offset: 0x00001CA0
			private static float n_GetScrimOpacity_Landroidx_coordinatorlayout_widget_CoordinatorLayout_Landroid_view_View_(IntPtr jnienv, IntPtr native__this, IntPtr native_parent, IntPtr native_child)
			{
				CoordinatorLayout.Behavior @object = Java.Lang.Object.GetObject<CoordinatorLayout.Behavior>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				CoordinatorLayout object2 = Java.Lang.Object.GetObject<CoordinatorLayout>(native_parent, JniHandleOwnership.DoNotTransfer);
				Java.Lang.Object object3 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_child, JniHandleOwnership.DoNotTransfer);
				return @object.GetScrimOpacity(object2, object3);
			}

			// Token: 0x06000102 RID: 258 RVA: 0x00003ACC File Offset: 0x00001CCC
			[Register("getScrimOpacity", "(Landroidx/coordinatorlayout/widget/CoordinatorLayout;Landroid/view/View;)F", "GetGetScrimOpacity_Landroidx_coordinatorlayout_widget_CoordinatorLayout_Landroid_view_View_Handler")]
			public unsafe virtual float GetScrimOpacity(CoordinatorLayout parent, Java.Lang.Object child)
			{
				IntPtr intPtr = JNIEnv.ToLocalJniHandle(child);
				float result;
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((parent == null) ? IntPtr.Zero : parent.Handle);
					ptr[1] = new JniArgumentValue(intPtr);
					result = CoordinatorLayout.Behavior._members.InstanceMethods.InvokeVirtualSingleMethod("getScrimOpacity.(Landroidx/coordinatorlayout/widget/CoordinatorLayout;Landroid/view/View;)F", this, ptr);
				}
				finally
				{
					JNIEnv.DeleteLocalRef(intPtr);
					GC.KeepAlive(parent);
					GC.KeepAlive(child);
				}
				return result;
			}

			// Token: 0x06000103 RID: 259 RVA: 0x00003B58 File Offset: 0x00001D58
			[Register("getTag", "(Landroid/view/View;)Ljava/lang/Object;", "")]
			public unsafe static Java.Lang.Object GetTag(View child)
			{
				Java.Lang.Object @object;
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((child == null) ? IntPtr.Zero : child.Handle);
					@object = Java.Lang.Object.GetObject<Java.Lang.Object>(CoordinatorLayout.Behavior._members.StaticMethods.InvokeObjectMethod("getTag.(Landroid/view/View;)Ljava/lang/Object;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
				}
				finally
				{
					GC.KeepAlive(child);
				}
				return @object;
			}

			// Token: 0x06000104 RID: 260 RVA: 0x00003BCC File Offset: 0x00001DCC
			private static Delegate GetLayoutDependsOn_Landroidx_coordinatorlayout_widget_CoordinatorLayout_Landroid_view_View_Landroid_view_View_Handler()
			{
				if (CoordinatorLayout.Behavior.cb_layoutDependsOn_Landroidx_coordinatorlayout_widget_CoordinatorLayout_Landroid_view_View_Landroid_view_View_ == null)
				{
					CoordinatorLayout.Behavior.cb_layoutDependsOn_Landroidx_coordinatorlayout_widget_CoordinatorLayout_Landroid_view_View_Landroid_view_View_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLLL_Z(CoordinatorLayout.Behavior.n_LayoutDependsOn_Landroidx_coordinatorlayout_widget_CoordinatorLayout_Landroid_view_View_Landroid_view_View_));
				}
				return CoordinatorLayout.Behavior.cb_layoutDependsOn_Landroidx_coordinatorlayout_widget_CoordinatorLayout_Landroid_view_View_Landroid_view_View_;
			}

			// Token: 0x06000105 RID: 261 RVA: 0x00003BF0 File Offset: 0x00001DF0
			private static bool n_LayoutDependsOn_Landroidx_coordinatorlayout_widget_CoordinatorLayout_Landroid_view_View_Landroid_view_View_(IntPtr jnienv, IntPtr native__this, IntPtr native_parent, IntPtr native_child, IntPtr native_dependency)
			{
				CoordinatorLayout.Behavior @object = Java.Lang.Object.GetObject<CoordinatorLayout.Behavior>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				CoordinatorLayout object2 = Java.Lang.Object.GetObject<CoordinatorLayout>(native_parent, JniHandleOwnership.DoNotTransfer);
				Java.Lang.Object object3 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_child, JniHandleOwnership.DoNotTransfer);
				View object4 = Java.Lang.Object.GetObject<View>(native_dependency, JniHandleOwnership.DoNotTransfer);
				return @object.LayoutDependsOn(object2, object3, object4);
			}

			// Token: 0x06000106 RID: 262 RVA: 0x00003C28 File Offset: 0x00001E28
			[Register("layoutDependsOn", "(Landroidx/coordinatorlayout/widget/CoordinatorLayout;Landroid/view/View;Landroid/view/View;)Z", "GetLayoutDependsOn_Landroidx_coordinatorlayout_widget_CoordinatorLayout_Landroid_view_View_Landroid_view_View_Handler")]
			public unsafe virtual bool LayoutDependsOn(CoordinatorLayout parent, Java.Lang.Object child, View dependency)
			{
				IntPtr intPtr = JNIEnv.ToLocalJniHandle(child);
				bool result;
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((parent == null) ? IntPtr.Zero : parent.Handle);
					ptr[1] = new JniArgumentValue(intPtr);
					ptr[2] = new JniArgumentValue((dependency == null) ? IntPtr.Zero : dependency.Handle);
					result = CoordinatorLayout.Behavior._members.InstanceMethods.InvokeVirtualBooleanMethod("layoutDependsOn.(Landroidx/coordinatorlayout/widget/CoordinatorLayout;Landroid/view/View;Landroid/view/View;)Z", this, ptr);
				}
				finally
				{
					JNIEnv.DeleteLocalRef(intPtr);
					GC.KeepAlive(parent);
					GC.KeepAlive(child);
					GC.KeepAlive(dependency);
				}
				return result;
			}

			// Token: 0x06000107 RID: 263 RVA: 0x00003CE0 File Offset: 0x00001EE0
			private static Delegate GetOnApplyWindowInsets_Landroidx_coordinatorlayout_widget_CoordinatorLayout_Landroid_view_View_Landroidx_core_view_WindowInsetsCompat_Handler()
			{
				if (CoordinatorLayout.Behavior.cb_onApplyWindowInsets_Landroidx_coordinatorlayout_widget_CoordinatorLayout_Landroid_view_View_Landroidx_core_view_WindowInsetsCompat_ == null)
				{
					CoordinatorLayout.Behavior.cb_onApplyWindowInsets_Landroidx_coordinatorlayout_widget_CoordinatorLayout_Landroid_view_View_Landroidx_core_view_WindowInsetsCompat_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLLL_L(CoordinatorLayout.Behavior.n_OnApplyWindowInsets_Landroidx_coordinatorlayout_widget_CoordinatorLayout_Landroid_view_View_Landroidx_core_view_WindowInsetsCompat_));
				}
				return CoordinatorLayout.Behavior.cb_onApplyWindowInsets_Landroidx_coordinatorlayout_widget_CoordinatorLayout_Landroid_view_View_Landroidx_core_view_WindowInsetsCompat_;
			}

			// Token: 0x06000108 RID: 264 RVA: 0x00003D04 File Offset: 0x00001F04
			private static IntPtr n_OnApplyWindowInsets_Landroidx_coordinatorlayout_widget_CoordinatorLayout_Landroid_view_View_Landroidx_core_view_WindowInsetsCompat_(IntPtr jnienv, IntPtr native__this, IntPtr native_coordinatorLayout, IntPtr native_child, IntPtr native_insets)
			{
				CoordinatorLayout.Behavior @object = Java.Lang.Object.GetObject<CoordinatorLayout.Behavior>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				CoordinatorLayout object2 = Java.Lang.Object.GetObject<CoordinatorLayout>(native_coordinatorLayout, JniHandleOwnership.DoNotTransfer);
				Java.Lang.Object object3 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_child, JniHandleOwnership.DoNotTransfer);
				WindowInsetsCompat object4 = Java.Lang.Object.GetObject<WindowInsetsCompat>(native_insets, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle(@object.OnApplyWindowInsets(object2, object3, object4));
			}

			// Token: 0x06000109 RID: 265 RVA: 0x00003D40 File Offset: 0x00001F40
			[Register("onApplyWindowInsets", "(Landroidx/coordinatorlayout/widget/CoordinatorLayout;Landroid/view/View;Landroidx/core/view/WindowInsetsCompat;)Landroidx/core/view/WindowInsetsCompat;", "GetOnApplyWindowInsets_Landroidx_coordinatorlayout_widget_CoordinatorLayout_Landroid_view_View_Landroidx_core_view_WindowInsetsCompat_Handler")]
			public unsafe virtual WindowInsetsCompat OnApplyWindowInsets(CoordinatorLayout coordinatorLayout, Java.Lang.Object child, WindowInsetsCompat insets)
			{
				IntPtr intPtr = JNIEnv.ToLocalJniHandle(child);
				WindowInsetsCompat @object;
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((coordinatorLayout == null) ? IntPtr.Zero : coordinatorLayout.Handle);
					ptr[1] = new JniArgumentValue(intPtr);
					ptr[2] = new JniArgumentValue((insets == null) ? IntPtr.Zero : insets.Handle);
					@object = Java.Lang.Object.GetObject<WindowInsetsCompat>(CoordinatorLayout.Behavior._members.InstanceMethods.InvokeVirtualObjectMethod("onApplyWindowInsets.(Landroidx/coordinatorlayout/widget/CoordinatorLayout;Landroid/view/View;Landroidx/core/view/WindowInsetsCompat;)Landroidx/core/view/WindowInsetsCompat;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
				}
				finally
				{
					JNIEnv.DeleteLocalRef(intPtr);
					GC.KeepAlive(coordinatorLayout);
					GC.KeepAlive(child);
					GC.KeepAlive(insets);
				}
				return @object;
			}

			// Token: 0x0600010A RID: 266 RVA: 0x00003E04 File Offset: 0x00002004
			private static Delegate GetOnAttachedToLayoutParams_Landroidx_coordinatorlayout_widget_CoordinatorLayout_LayoutParams_Handler()
			{
				if (CoordinatorLayout.Behavior.cb_onAttachedToLayoutParams_Landroidx_coordinatorlayout_widget_CoordinatorLayout_LayoutParams_ == null)
				{
					CoordinatorLayout.Behavior.cb_onAttachedToLayoutParams_Landroidx_coordinatorlayout_widget_CoordinatorLayout_LayoutParams_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(CoordinatorLayout.Behavior.n_OnAttachedToLayoutParams_Landroidx_coordinatorlayout_widget_CoordinatorLayout_LayoutParams_));
				}
				return CoordinatorLayout.Behavior.cb_onAttachedToLayoutParams_Landroidx_coordinatorlayout_widget_CoordinatorLayout_LayoutParams_;
			}

			// Token: 0x0600010B RID: 267 RVA: 0x00003E28 File Offset: 0x00002028
			private static void n_OnAttachedToLayoutParams_Landroidx_coordinatorlayout_widget_CoordinatorLayout_LayoutParams_(IntPtr jnienv, IntPtr native__this, IntPtr native__params)
			{
				CoordinatorLayout.Behavior @object = Java.Lang.Object.GetObject<CoordinatorLayout.Behavior>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				CoordinatorLayout.LayoutParams object2 = Java.Lang.Object.GetObject<CoordinatorLayout.LayoutParams>(native__params, JniHandleOwnership.DoNotTransfer);
				@object.OnAttachedToLayoutParams(object2);
			}

			// Token: 0x0600010C RID: 268 RVA: 0x00003E4C File Offset: 0x0000204C
			[Register("onAttachedToLayoutParams", "(Landroidx/coordinatorlayout/widget/CoordinatorLayout$LayoutParams;)V", "GetOnAttachedToLayoutParams_Landroidx_coordinatorlayout_widget_CoordinatorLayout_LayoutParams_Handler")]
			public unsafe virtual void OnAttachedToLayoutParams(CoordinatorLayout.LayoutParams @params)
			{
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((@params == null) ? IntPtr.Zero : @params.Handle);
					CoordinatorLayout.Behavior._members.InstanceMethods.InvokeVirtualVoidMethod("onAttachedToLayoutParams.(Landroidx/coordinatorlayout/widget/CoordinatorLayout$LayoutParams;)V", this, ptr);
				}
				finally
				{
					GC.KeepAlive(@params);
				}
			}

			// Token: 0x0600010D RID: 269 RVA: 0x00003EB0 File Offset: 0x000020B0
			private static Delegate GetOnDependentViewChanged_Landroidx_coordinatorlayout_widget_CoordinatorLayout_Landroid_view_View_Landroid_view_View_Handler()
			{
				if (CoordinatorLayout.Behavior.cb_onDependentViewChanged_Landroidx_coordinatorlayout_widget_CoordinatorLayout_Landroid_view_View_Landroid_view_View_ == null)
				{
					CoordinatorLayout.Behavior.cb_onDependentViewChanged_Landroidx_coordinatorlayout_widget_CoordinatorLayout_Landroid_view_View_Landroid_view_View_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLLL_Z(CoordinatorLayout.Behavior.n_OnDependentViewChanged_Landroidx_coordinatorlayout_widget_CoordinatorLayout_Landroid_view_View_Landroid_view_View_));
				}
				return CoordinatorLayout.Behavior.cb_onDependentViewChanged_Landroidx_coordinatorlayout_widget_CoordinatorLayout_Landroid_view_View_Landroid_view_View_;
			}

			// Token: 0x0600010E RID: 270 RVA: 0x00003ED4 File Offset: 0x000020D4
			private static bool n_OnDependentViewChanged_Landroidx_coordinatorlayout_widget_CoordinatorLayout_Landroid_view_View_Landroid_view_View_(IntPtr jnienv, IntPtr native__this, IntPtr native_parent, IntPtr native_child, IntPtr native_dependency)
			{
				CoordinatorLayout.Behavior @object = Java.Lang.Object.GetObject<CoordinatorLayout.Behavior>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				CoordinatorLayout object2 = Java.Lang.Object.GetObject<CoordinatorLayout>(native_parent, JniHandleOwnership.DoNotTransfer);
				Java.Lang.Object object3 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_child, JniHandleOwnership.DoNotTransfer);
				View object4 = Java.Lang.Object.GetObject<View>(native_dependency, JniHandleOwnership.DoNotTransfer);
				return @object.OnDependentViewChanged(object2, object3, object4);
			}

			// Token: 0x0600010F RID: 271 RVA: 0x00003F0C File Offset: 0x0000210C
			[Register("onDependentViewChanged", "(Landroidx/coordinatorlayout/widget/CoordinatorLayout;Landroid/view/View;Landroid/view/View;)Z", "GetOnDependentViewChanged_Landroidx_coordinatorlayout_widget_CoordinatorLayout_Landroid_view_View_Landroid_view_View_Handler")]
			public unsafe virtual bool OnDependentViewChanged(CoordinatorLayout parent, Java.Lang.Object child, View dependency)
			{
				IntPtr intPtr = JNIEnv.ToLocalJniHandle(child);
				bool result;
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((parent == null) ? IntPtr.Zero : parent.Handle);
					ptr[1] = new JniArgumentValue(intPtr);
					ptr[2] = new JniArgumentValue((dependency == null) ? IntPtr.Zero : dependency.Handle);
					result = CoordinatorLayout.Behavior._members.InstanceMethods.InvokeVirtualBooleanMethod("onDependentViewChanged.(Landroidx/coordinatorlayout/widget/CoordinatorLayout;Landroid/view/View;Landroid/view/View;)Z", this, ptr);
				}
				finally
				{
					JNIEnv.DeleteLocalRef(intPtr);
					GC.KeepAlive(parent);
					GC.KeepAlive(child);
					GC.KeepAlive(dependency);
				}
				return result;
			}

			// Token: 0x06000110 RID: 272 RVA: 0x00003FC4 File Offset: 0x000021C4
			private static Delegate GetOnDependentViewRemoved_Landroidx_coordinatorlayout_widget_CoordinatorLayout_Landroid_view_View_Landroid_view_View_Handler()
			{
				if (CoordinatorLayout.Behavior.cb_onDependentViewRemoved_Landroidx_coordinatorlayout_widget_CoordinatorLayout_Landroid_view_View_Landroid_view_View_ == null)
				{
					CoordinatorLayout.Behavior.cb_onDependentViewRemoved_Landroidx_coordinatorlayout_widget_CoordinatorLayout_Landroid_view_View_Landroid_view_View_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLLL_V(CoordinatorLayout.Behavior.n_OnDependentViewRemoved_Landroidx_coordinatorlayout_widget_CoordinatorLayout_Landroid_view_View_Landroid_view_View_));
				}
				return CoordinatorLayout.Behavior.cb_onDependentViewRemoved_Landroidx_coordinatorlayout_widget_CoordinatorLayout_Landroid_view_View_Landroid_view_View_;
			}

			// Token: 0x06000111 RID: 273 RVA: 0x00003FE8 File Offset: 0x000021E8
			private static void n_OnDependentViewRemoved_Landroidx_coordinatorlayout_widget_CoordinatorLayout_Landroid_view_View_Landroid_view_View_(IntPtr jnienv, IntPtr native__this, IntPtr native_parent, IntPtr native_child, IntPtr native_dependency)
			{
				CoordinatorLayout.Behavior @object = Java.Lang.Object.GetObject<CoordinatorLayout.Behavior>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				CoordinatorLayout object2 = Java.Lang.Object.GetObject<CoordinatorLayout>(native_parent, JniHandleOwnership.DoNotTransfer);
				Java.Lang.Object object3 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_child, JniHandleOwnership.DoNotTransfer);
				View object4 = Java.Lang.Object.GetObject<View>(native_dependency, JniHandleOwnership.DoNotTransfer);
				@object.OnDependentViewRemoved(object2, object3, object4);
			}

			// Token: 0x06000112 RID: 274 RVA: 0x00004020 File Offset: 0x00002220
			[Register("onDependentViewRemoved", "(Landroidx/coordinatorlayout/widget/CoordinatorLayout;Landroid/view/View;Landroid/view/View;)V", "GetOnDependentViewRemoved_Landroidx_coordinatorlayout_widget_CoordinatorLayout_Landroid_view_View_Landroid_view_View_Handler")]
			public unsafe virtual void OnDependentViewRemoved(CoordinatorLayout parent, Java.Lang.Object child, View dependency)
			{
				IntPtr intPtr = JNIEnv.ToLocalJniHandle(child);
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((parent == null) ? IntPtr.Zero : parent.Handle);
					ptr[1] = new JniArgumentValue(intPtr);
					ptr[2] = new JniArgumentValue((dependency == null) ? IntPtr.Zero : dependency.Handle);
					CoordinatorLayout.Behavior._members.InstanceMethods.InvokeVirtualVoidMethod("onDependentViewRemoved.(Landroidx/coordinatorlayout/widget/CoordinatorLayout;Landroid/view/View;Landroid/view/View;)V", this, ptr);
				}
				finally
				{
					JNIEnv.DeleteLocalRef(intPtr);
					GC.KeepAlive(parent);
					GC.KeepAlive(child);
					GC.KeepAlive(dependency);
				}
			}

			// Token: 0x06000113 RID: 275 RVA: 0x000040D4 File Offset: 0x000022D4
			private static Delegate GetOnDetachedFromLayoutParamsHandler()
			{
				if (CoordinatorLayout.Behavior.cb_onDetachedFromLayoutParams == null)
				{
					CoordinatorLayout.Behavior.cb_onDetachedFromLayoutParams = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(CoordinatorLayout.Behavior.n_OnDetachedFromLayoutParams));
				}
				return CoordinatorLayout.Behavior.cb_onDetachedFromLayoutParams;
			}

			// Token: 0x06000114 RID: 276 RVA: 0x000040F8 File Offset: 0x000022F8
			private static void n_OnDetachedFromLayoutParams(IntPtr jnienv, IntPtr native__this)
			{
				Java.Lang.Object.GetObject<CoordinatorLayout.Behavior>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).OnDetachedFromLayoutParams();
			}

			// Token: 0x06000115 RID: 277 RVA: 0x00004107 File Offset: 0x00002307
			[Register("onDetachedFromLayoutParams", "()V", "GetOnDetachedFromLayoutParamsHandler")]
			public virtual void OnDetachedFromLayoutParams()
			{
				CoordinatorLayout.Behavior._members.InstanceMethods.InvokeVirtualVoidMethod("onDetachedFromLayoutParams.()V", this, null);
			}

			// Token: 0x06000116 RID: 278 RVA: 0x00004120 File Offset: 0x00002320
			private static Delegate GetOnInterceptTouchEvent_Landroidx_coordinatorlayout_widget_CoordinatorLayout_Landroid_view_View_Landroid_view_MotionEvent_Handler()
			{
				if (CoordinatorLayout.Behavior.cb_onInterceptTouchEvent_Landroidx_coordinatorlayout_widget_CoordinatorLayout_Landroid_view_View_Landroid_view_MotionEvent_ == null)
				{
					CoordinatorLayout.Behavior.cb_onInterceptTouchEvent_Landroidx_coordinatorlayout_widget_CoordinatorLayout_Landroid_view_View_Landroid_view_MotionEvent_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLLL_Z(CoordinatorLayout.Behavior.n_OnInterceptTouchEvent_Landroidx_coordinatorlayout_widget_CoordinatorLayout_Landroid_view_View_Landroid_view_MotionEvent_));
				}
				return CoordinatorLayout.Behavior.cb_onInterceptTouchEvent_Landroidx_coordinatorlayout_widget_CoordinatorLayout_Landroid_view_View_Landroid_view_MotionEvent_;
			}

			// Token: 0x06000117 RID: 279 RVA: 0x00004144 File Offset: 0x00002344
			private static bool n_OnInterceptTouchEvent_Landroidx_coordinatorlayout_widget_CoordinatorLayout_Landroid_view_View_Landroid_view_MotionEvent_(IntPtr jnienv, IntPtr native__this, IntPtr native_parent, IntPtr native_child, IntPtr native_ev)
			{
				CoordinatorLayout.Behavior @object = Java.Lang.Object.GetObject<CoordinatorLayout.Behavior>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				CoordinatorLayout object2 = Java.Lang.Object.GetObject<CoordinatorLayout>(native_parent, JniHandleOwnership.DoNotTransfer);
				Java.Lang.Object object3 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_child, JniHandleOwnership.DoNotTransfer);
				MotionEvent object4 = Java.Lang.Object.GetObject<MotionEvent>(native_ev, JniHandleOwnership.DoNotTransfer);
				return @object.OnInterceptTouchEvent(object2, object3, object4);
			}

			// Token: 0x06000118 RID: 280 RVA: 0x0000417C File Offset: 0x0000237C
			[Register("onInterceptTouchEvent", "(Landroidx/coordinatorlayout/widget/CoordinatorLayout;Landroid/view/View;Landroid/view/MotionEvent;)Z", "GetOnInterceptTouchEvent_Landroidx_coordinatorlayout_widget_CoordinatorLayout_Landroid_view_View_Landroid_view_MotionEvent_Handler")]
			public unsafe virtual bool OnInterceptTouchEvent(CoordinatorLayout parent, Java.Lang.Object child, MotionEvent ev)
			{
				IntPtr intPtr = JNIEnv.ToLocalJniHandle(child);
				bool result;
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((parent == null) ? IntPtr.Zero : parent.Handle);
					ptr[1] = new JniArgumentValue(intPtr);
					ptr[2] = new JniArgumentValue((ev == null) ? IntPtr.Zero : ev.Handle);
					result = CoordinatorLayout.Behavior._members.InstanceMethods.InvokeVirtualBooleanMethod("onInterceptTouchEvent.(Landroidx/coordinatorlayout/widget/CoordinatorLayout;Landroid/view/View;Landroid/view/MotionEvent;)Z", this, ptr);
				}
				finally
				{
					JNIEnv.DeleteLocalRef(intPtr);
					GC.KeepAlive(parent);
					GC.KeepAlive(child);
					GC.KeepAlive(ev);
				}
				return result;
			}

			// Token: 0x06000119 RID: 281 RVA: 0x00004234 File Offset: 0x00002434
			private static Delegate GetOnLayoutChild_Landroidx_coordinatorlayout_widget_CoordinatorLayout_Landroid_view_View_IHandler()
			{
				if (CoordinatorLayout.Behavior.cb_onLayoutChild_Landroidx_coordinatorlayout_widget_CoordinatorLayout_Landroid_view_View_I == null)
				{
					CoordinatorLayout.Behavior.cb_onLayoutChild_Landroidx_coordinatorlayout_widget_CoordinatorLayout_Landroid_view_View_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLLI_Z(CoordinatorLayout.Behavior.n_OnLayoutChild_Landroidx_coordinatorlayout_widget_CoordinatorLayout_Landroid_view_View_I));
				}
				return CoordinatorLayout.Behavior.cb_onLayoutChild_Landroidx_coordinatorlayout_widget_CoordinatorLayout_Landroid_view_View_I;
			}

			// Token: 0x0600011A RID: 282 RVA: 0x00004258 File Offset: 0x00002458
			private static bool n_OnLayoutChild_Landroidx_coordinatorlayout_widget_CoordinatorLayout_Landroid_view_View_I(IntPtr jnienv, IntPtr native__this, IntPtr native_parent, IntPtr native_child, int layoutDirection)
			{
				CoordinatorLayout.Behavior @object = Java.Lang.Object.GetObject<CoordinatorLayout.Behavior>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				CoordinatorLayout object2 = Java.Lang.Object.GetObject<CoordinatorLayout>(native_parent, JniHandleOwnership.DoNotTransfer);
				Java.Lang.Object object3 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_child, JniHandleOwnership.DoNotTransfer);
				return @object.OnLayoutChild(object2, object3, layoutDirection);
			}

			// Token: 0x0600011B RID: 283 RVA: 0x00004288 File Offset: 0x00002488
			[Register("onLayoutChild", "(Landroidx/coordinatorlayout/widget/CoordinatorLayout;Landroid/view/View;I)Z", "GetOnLayoutChild_Landroidx_coordinatorlayout_widget_CoordinatorLayout_Landroid_view_View_IHandler")]
			public unsafe virtual bool OnLayoutChild(CoordinatorLayout parent, Java.Lang.Object child, int layoutDirection)
			{
				IntPtr intPtr = JNIEnv.ToLocalJniHandle(child);
				bool result;
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((parent == null) ? IntPtr.Zero : parent.Handle);
					ptr[1] = new JniArgumentValue(intPtr);
					ptr[2] = new JniArgumentValue(layoutDirection);
					result = CoordinatorLayout.Behavior._members.InstanceMethods.InvokeVirtualBooleanMethod("onLayoutChild.(Landroidx/coordinatorlayout/widget/CoordinatorLayout;Landroid/view/View;I)Z", this, ptr);
				}
				finally
				{
					JNIEnv.DeleteLocalRef(intPtr);
					GC.KeepAlive(parent);
					GC.KeepAlive(child);
				}
				return result;
			}

			// Token: 0x0600011C RID: 284 RVA: 0x0000432C File Offset: 0x0000252C
			private static Delegate GetOnMeasureChild_Landroidx_coordinatorlayout_widget_CoordinatorLayout_Landroid_view_View_IIIIHandler()
			{
				if (CoordinatorLayout.Behavior.cb_onMeasureChild_Landroidx_coordinatorlayout_widget_CoordinatorLayout_Landroid_view_View_IIII == null)
				{
					CoordinatorLayout.Behavior.cb_onMeasureChild_Landroidx_coordinatorlayout_widget_CoordinatorLayout_Landroid_view_View_IIII = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLLIIII_Z(CoordinatorLayout.Behavior.n_OnMeasureChild_Landroidx_coordinatorlayout_widget_CoordinatorLayout_Landroid_view_View_IIII));
				}
				return CoordinatorLayout.Behavior.cb_onMeasureChild_Landroidx_coordinatorlayout_widget_CoordinatorLayout_Landroid_view_View_IIII;
			}

			// Token: 0x0600011D RID: 285 RVA: 0x00004350 File Offset: 0x00002550
			private static bool n_OnMeasureChild_Landroidx_coordinatorlayout_widget_CoordinatorLayout_Landroid_view_View_IIII(IntPtr jnienv, IntPtr native__this, IntPtr native_parent, IntPtr native_child, int parentWidthMeasureSpec, int widthUsed, int parentHeightMeasureSpec, int heightUsed)
			{
				CoordinatorLayout.Behavior @object = Java.Lang.Object.GetObject<CoordinatorLayout.Behavior>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				CoordinatorLayout object2 = Java.Lang.Object.GetObject<CoordinatorLayout>(native_parent, JniHandleOwnership.DoNotTransfer);
				Java.Lang.Object object3 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_child, JniHandleOwnership.DoNotTransfer);
				return @object.OnMeasureChild(object2, object3, parentWidthMeasureSpec, widthUsed, parentHeightMeasureSpec, heightUsed);
			}

			// Token: 0x0600011E RID: 286 RVA: 0x00004384 File Offset: 0x00002584
			[Register("onMeasureChild", "(Landroidx/coordinatorlayout/widget/CoordinatorLayout;Landroid/view/View;IIII)Z", "GetOnMeasureChild_Landroidx_coordinatorlayout_widget_CoordinatorLayout_Landroid_view_View_IIIIHandler")]
			public unsafe virtual bool OnMeasureChild(CoordinatorLayout parent, Java.Lang.Object child, int parentWidthMeasureSpec, int widthUsed, int parentHeightMeasureSpec, int heightUsed)
			{
				IntPtr intPtr = JNIEnv.ToLocalJniHandle(child);
				bool result;
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((parent == null) ? IntPtr.Zero : parent.Handle);
					ptr[1] = new JniArgumentValue(intPtr);
					ptr[2] = new JniArgumentValue(parentWidthMeasureSpec);
					ptr[3] = new JniArgumentValue(widthUsed);
					ptr[4] = new JniArgumentValue(parentHeightMeasureSpec);
					ptr[5] = new JniArgumentValue(heightUsed);
					result = CoordinatorLayout.Behavior._members.InstanceMethods.InvokeVirtualBooleanMethod("onMeasureChild.(Landroidx/coordinatorlayout/widget/CoordinatorLayout;Landroid/view/View;IIII)Z", this, ptr);
				}
				finally
				{
					JNIEnv.DeleteLocalRef(intPtr);
					GC.KeepAlive(parent);
					GC.KeepAlive(child);
				}
				return result;
			}

			// Token: 0x0600011F RID: 287 RVA: 0x0000446C File Offset: 0x0000266C
			private static Delegate GetOnNestedFling_Landroidx_coordinatorlayout_widget_CoordinatorLayout_Landroid_view_View_Landroid_view_View_FFZHandler()
			{
				if (CoordinatorLayout.Behavior.cb_onNestedFling_Landroidx_coordinatorlayout_widget_CoordinatorLayout_Landroid_view_View_Landroid_view_View_FFZ == null)
				{
					CoordinatorLayout.Behavior.cb_onNestedFling_Landroidx_coordinatorlayout_widget_CoordinatorLayout_Landroid_view_View_Landroid_view_View_FFZ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLLLFFZ_Z(CoordinatorLayout.Behavior.n_OnNestedFling_Landroidx_coordinatorlayout_widget_CoordinatorLayout_Landroid_view_View_Landroid_view_View_FFZ));
				}
				return CoordinatorLayout.Behavior.cb_onNestedFling_Landroidx_coordinatorlayout_widget_CoordinatorLayout_Landroid_view_View_Landroid_view_View_FFZ;
			}

			// Token: 0x06000120 RID: 288 RVA: 0x00004490 File Offset: 0x00002690
			private static bool n_OnNestedFling_Landroidx_coordinatorlayout_widget_CoordinatorLayout_Landroid_view_View_Landroid_view_View_FFZ(IntPtr jnienv, IntPtr native__this, IntPtr native_coordinatorLayout, IntPtr native_child, IntPtr native_target, float velocityX, float velocityY, bool consumed)
			{
				CoordinatorLayout.Behavior @object = Java.Lang.Object.GetObject<CoordinatorLayout.Behavior>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				CoordinatorLayout object2 = Java.Lang.Object.GetObject<CoordinatorLayout>(native_coordinatorLayout, JniHandleOwnership.DoNotTransfer);
				Java.Lang.Object object3 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_child, JniHandleOwnership.DoNotTransfer);
				View object4 = Java.Lang.Object.GetObject<View>(native_target, JniHandleOwnership.DoNotTransfer);
				return @object.OnNestedFling(object2, object3, object4, velocityX, velocityY, consumed);
			}

			// Token: 0x06000121 RID: 289 RVA: 0x000044CC File Offset: 0x000026CC
			[Register("onNestedFling", "(Landroidx/coordinatorlayout/widget/CoordinatorLayout;Landroid/view/View;Landroid/view/View;FFZ)Z", "GetOnNestedFling_Landroidx_coordinatorlayout_widget_CoordinatorLayout_Landroid_view_View_Landroid_view_View_FFZHandler")]
			public unsafe virtual bool OnNestedFling(CoordinatorLayout coordinatorLayout, Java.Lang.Object child, View target, float velocityX, float velocityY, bool consumed)
			{
				IntPtr intPtr = JNIEnv.ToLocalJniHandle(child);
				bool result;
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((coordinatorLayout == null) ? IntPtr.Zero : coordinatorLayout.Handle);
					ptr[1] = new JniArgumentValue(intPtr);
					ptr[2] = new JniArgumentValue((target == null) ? IntPtr.Zero : target.Handle);
					ptr[3] = new JniArgumentValue(velocityX);
					ptr[4] = new JniArgumentValue(velocityY);
					ptr[5] = new JniArgumentValue(consumed);
					result = CoordinatorLayout.Behavior._members.InstanceMethods.InvokeVirtualBooleanMethod("onNestedFling.(Landroidx/coordinatorlayout/widget/CoordinatorLayout;Landroid/view/View;Landroid/view/View;FFZ)Z", this, ptr);
				}
				finally
				{
					JNIEnv.DeleteLocalRef(intPtr);
					GC.KeepAlive(coordinatorLayout);
					GC.KeepAlive(child);
					GC.KeepAlive(target);
				}
				return result;
			}

			// Token: 0x06000122 RID: 290 RVA: 0x000045C8 File Offset: 0x000027C8
			private static Delegate GetOnNestedPreFling_Landroidx_coordinatorlayout_widget_CoordinatorLayout_Landroid_view_View_Landroid_view_View_FFHandler()
			{
				if (CoordinatorLayout.Behavior.cb_onNestedPreFling_Landroidx_coordinatorlayout_widget_CoordinatorLayout_Landroid_view_View_Landroid_view_View_FF == null)
				{
					CoordinatorLayout.Behavior.cb_onNestedPreFling_Landroidx_coordinatorlayout_widget_CoordinatorLayout_Landroid_view_View_Landroid_view_View_FF = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLLLFF_Z(CoordinatorLayout.Behavior.n_OnNestedPreFling_Landroidx_coordinatorlayout_widget_CoordinatorLayout_Landroid_view_View_Landroid_view_View_FF));
				}
				return CoordinatorLayout.Behavior.cb_onNestedPreFling_Landroidx_coordinatorlayout_widget_CoordinatorLayout_Landroid_view_View_Landroid_view_View_FF;
			}

			// Token: 0x06000123 RID: 291 RVA: 0x000045EC File Offset: 0x000027EC
			private static bool n_OnNestedPreFling_Landroidx_coordinatorlayout_widget_CoordinatorLayout_Landroid_view_View_Landroid_view_View_FF(IntPtr jnienv, IntPtr native__this, IntPtr native_coordinatorLayout, IntPtr native_child, IntPtr native_target, float velocityX, float velocityY)
			{
				CoordinatorLayout.Behavior @object = Java.Lang.Object.GetObject<CoordinatorLayout.Behavior>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				CoordinatorLayout object2 = Java.Lang.Object.GetObject<CoordinatorLayout>(native_coordinatorLayout, JniHandleOwnership.DoNotTransfer);
				Java.Lang.Object object3 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_child, JniHandleOwnership.DoNotTransfer);
				View object4 = Java.Lang.Object.GetObject<View>(native_target, JniHandleOwnership.DoNotTransfer);
				return @object.OnNestedPreFling(object2, object3, object4, velocityX, velocityY);
			}

			// Token: 0x06000124 RID: 292 RVA: 0x00004628 File Offset: 0x00002828
			[Register("onNestedPreFling", "(Landroidx/coordinatorlayout/widget/CoordinatorLayout;Landroid/view/View;Landroid/view/View;FF)Z", "GetOnNestedPreFling_Landroidx_coordinatorlayout_widget_CoordinatorLayout_Landroid_view_View_Landroid_view_View_FFHandler")]
			public unsafe virtual bool OnNestedPreFling(CoordinatorLayout coordinatorLayout, Java.Lang.Object child, View target, float velocityX, float velocityY)
			{
				IntPtr intPtr = JNIEnv.ToLocalJniHandle(child);
				bool result;
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((coordinatorLayout == null) ? IntPtr.Zero : coordinatorLayout.Handle);
					ptr[1] = new JniArgumentValue(intPtr);
					ptr[2] = new JniArgumentValue((target == null) ? IntPtr.Zero : target.Handle);
					ptr[3] = new JniArgumentValue(velocityX);
					ptr[4] = new JniArgumentValue(velocityY);
					result = CoordinatorLayout.Behavior._members.InstanceMethods.InvokeVirtualBooleanMethod("onNestedPreFling.(Landroidx/coordinatorlayout/widget/CoordinatorLayout;Landroid/view/View;Landroid/view/View;FF)Z", this, ptr);
				}
				finally
				{
					JNIEnv.DeleteLocalRef(intPtr);
					GC.KeepAlive(coordinatorLayout);
					GC.KeepAlive(child);
					GC.KeepAlive(target);
				}
				return result;
			}

			// Token: 0x06000125 RID: 293 RVA: 0x0000470C File Offset: 0x0000290C
			private static Delegate GetOnNestedPreScroll_Landroidx_coordinatorlayout_widget_CoordinatorLayout_Landroid_view_View_Landroid_view_View_IIarrayIHandler()
			{
				if (CoordinatorLayout.Behavior.cb_onNestedPreScroll_Landroidx_coordinatorlayout_widget_CoordinatorLayout_Landroid_view_View_Landroid_view_View_IIarrayI == null)
				{
					CoordinatorLayout.Behavior.cb_onNestedPreScroll_Landroidx_coordinatorlayout_widget_CoordinatorLayout_Landroid_view_View_Landroid_view_View_IIarrayI = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLLLIIL_V(CoordinatorLayout.Behavior.n_OnNestedPreScroll_Landroidx_coordinatorlayout_widget_CoordinatorLayout_Landroid_view_View_Landroid_view_View_IIarrayI));
				}
				return CoordinatorLayout.Behavior.cb_onNestedPreScroll_Landroidx_coordinatorlayout_widget_CoordinatorLayout_Landroid_view_View_Landroid_view_View_IIarrayI;
			}

			// Token: 0x06000126 RID: 294 RVA: 0x00004730 File Offset: 0x00002930
			private static void n_OnNestedPreScroll_Landroidx_coordinatorlayout_widget_CoordinatorLayout_Landroid_view_View_Landroid_view_View_IIarrayI(IntPtr jnienv, IntPtr native__this, IntPtr native_coordinatorLayout, IntPtr native_child, IntPtr native_target, int dx, int dy, IntPtr native_consumed)
			{
				CoordinatorLayout.Behavior @object = Java.Lang.Object.GetObject<CoordinatorLayout.Behavior>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				CoordinatorLayout object2 = Java.Lang.Object.GetObject<CoordinatorLayout>(native_coordinatorLayout, JniHandleOwnership.DoNotTransfer);
				Java.Lang.Object object3 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_child, JniHandleOwnership.DoNotTransfer);
				View object4 = Java.Lang.Object.GetObject<View>(native_target, JniHandleOwnership.DoNotTransfer);
				int[] array = (int[])JNIEnv.GetArray(native_consumed, JniHandleOwnership.DoNotTransfer, typeof(int));
				@object.OnNestedPreScroll(object2, object3, object4, dx, dy, array);
				if (array != null)
				{
					JNIEnv.CopyArray(array, native_consumed);
				}
			}

			// Token: 0x06000127 RID: 295 RVA: 0x00004790 File Offset: 0x00002990
			[Register("onNestedPreScroll", "(Landroidx/coordinatorlayout/widget/CoordinatorLayout;Landroid/view/View;Landroid/view/View;II[I)V", "GetOnNestedPreScroll_Landroidx_coordinatorlayout_widget_CoordinatorLayout_Landroid_view_View_Landroid_view_View_IIarrayIHandler")]
			public unsafe virtual void OnNestedPreScroll(CoordinatorLayout coordinatorLayout, Java.Lang.Object child, View target, int dx, int dy, int[] consumed)
			{
				IntPtr intPtr = JNIEnv.ToLocalJniHandle(child);
				IntPtr intPtr2 = JNIEnv.NewArray(consumed);
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((coordinatorLayout == null) ? IntPtr.Zero : coordinatorLayout.Handle);
					ptr[1] = new JniArgumentValue(intPtr);
					ptr[2] = new JniArgumentValue((target == null) ? IntPtr.Zero : target.Handle);
					ptr[3] = new JniArgumentValue(dx);
					ptr[4] = new JniArgumentValue(dy);
					ptr[5] = new JniArgumentValue(intPtr2);
					CoordinatorLayout.Behavior._members.InstanceMethods.InvokeVirtualVoidMethod("onNestedPreScroll.(Landroidx/coordinatorlayout/widget/CoordinatorLayout;Landroid/view/View;Landroid/view/View;II[I)V", this, ptr);
				}
				finally
				{
					JNIEnv.DeleteLocalRef(intPtr);
					if (consumed != null)
					{
						JNIEnv.CopyArray(intPtr2, consumed);
						JNIEnv.DeleteLocalRef(intPtr2);
					}
					GC.KeepAlive(coordinatorLayout);
					GC.KeepAlive(child);
					GC.KeepAlive(target);
					GC.KeepAlive(consumed);
				}
			}

			// Token: 0x06000128 RID: 296 RVA: 0x000048AC File Offset: 0x00002AAC
			private static Delegate GetOnNestedPreScroll_Landroidx_coordinatorlayout_widget_CoordinatorLayout_Landroid_view_View_Landroid_view_View_IIarrayIIHandler()
			{
				if (CoordinatorLayout.Behavior.cb_onNestedPreScroll_Landroidx_coordinatorlayout_widget_CoordinatorLayout_Landroid_view_View_Landroid_view_View_IIarrayII == null)
				{
					CoordinatorLayout.Behavior.cb_onNestedPreScroll_Landroidx_coordinatorlayout_widget_CoordinatorLayout_Landroid_view_View_Landroid_view_View_IIarrayII = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLLLIILI_V(CoordinatorLayout.Behavior.n_OnNestedPreScroll_Landroidx_coordinatorlayout_widget_CoordinatorLayout_Landroid_view_View_Landroid_view_View_IIarrayII));
				}
				return CoordinatorLayout.Behavior.cb_onNestedPreScroll_Landroidx_coordinatorlayout_widget_CoordinatorLayout_Landroid_view_View_Landroid_view_View_IIarrayII;
			}

			// Token: 0x06000129 RID: 297 RVA: 0x000048D0 File Offset: 0x00002AD0
			private static void n_OnNestedPreScroll_Landroidx_coordinatorlayout_widget_CoordinatorLayout_Landroid_view_View_Landroid_view_View_IIarrayII(IntPtr jnienv, IntPtr native__this, IntPtr native_coordinatorLayout, IntPtr native_child, IntPtr native_target, int dx, int dy, IntPtr native_consumed, int type)
			{
				CoordinatorLayout.Behavior @object = Java.Lang.Object.GetObject<CoordinatorLayout.Behavior>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				CoordinatorLayout object2 = Java.Lang.Object.GetObject<CoordinatorLayout>(native_coordinatorLayout, JniHandleOwnership.DoNotTransfer);
				Java.Lang.Object object3 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_child, JniHandleOwnership.DoNotTransfer);
				View object4 = Java.Lang.Object.GetObject<View>(native_target, JniHandleOwnership.DoNotTransfer);
				int[] array = (int[])JNIEnv.GetArray(native_consumed, JniHandleOwnership.DoNotTransfer, typeof(int));
				@object.OnNestedPreScroll(object2, object3, object4, dx, dy, array, type);
				if (array != null)
				{
					JNIEnv.CopyArray(array, native_consumed);
				}
			}

			// Token: 0x0600012A RID: 298 RVA: 0x00004930 File Offset: 0x00002B30
			[Register("onNestedPreScroll", "(Landroidx/coordinatorlayout/widget/CoordinatorLayout;Landroid/view/View;Landroid/view/View;II[II)V", "GetOnNestedPreScroll_Landroidx_coordinatorlayout_widget_CoordinatorLayout_Landroid_view_View_Landroid_view_View_IIarrayIIHandler")]
			public unsafe virtual void OnNestedPreScroll(CoordinatorLayout coordinatorLayout, Java.Lang.Object child, View target, int dx, int dy, int[] consumed, int type)
			{
				IntPtr intPtr = JNIEnv.ToLocalJniHandle(child);
				IntPtr intPtr2 = JNIEnv.NewArray(consumed);
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((coordinatorLayout == null) ? IntPtr.Zero : coordinatorLayout.Handle);
					ptr[1] = new JniArgumentValue(intPtr);
					ptr[2] = new JniArgumentValue((target == null) ? IntPtr.Zero : target.Handle);
					ptr[3] = new JniArgumentValue(dx);
					ptr[4] = new JniArgumentValue(dy);
					ptr[5] = new JniArgumentValue(intPtr2);
					ptr[6] = new JniArgumentValue(type);
					CoordinatorLayout.Behavior._members.InstanceMethods.InvokeVirtualVoidMethod("onNestedPreScroll.(Landroidx/coordinatorlayout/widget/CoordinatorLayout;Landroid/view/View;Landroid/view/View;II[II)V", this, ptr);
				}
				finally
				{
					JNIEnv.DeleteLocalRef(intPtr);
					if (consumed != null)
					{
						JNIEnv.CopyArray(intPtr2, consumed);
						JNIEnv.DeleteLocalRef(intPtr2);
					}
					GC.KeepAlive(coordinatorLayout);
					GC.KeepAlive(child);
					GC.KeepAlive(target);
					GC.KeepAlive(consumed);
				}
			}

			// Token: 0x0600012B RID: 299 RVA: 0x00004A60 File Offset: 0x00002C60
			private static Delegate GetOnNestedScroll_Landroidx_coordinatorlayout_widget_CoordinatorLayout_Landroid_view_View_Landroid_view_View_IIIIHandler()
			{
				if (CoordinatorLayout.Behavior.cb_onNestedScroll_Landroidx_coordinatorlayout_widget_CoordinatorLayout_Landroid_view_View_Landroid_view_View_IIII == null)
				{
					CoordinatorLayout.Behavior.cb_onNestedScroll_Landroidx_coordinatorlayout_widget_CoordinatorLayout_Landroid_view_View_Landroid_view_View_IIII = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLLLIIII_V(CoordinatorLayout.Behavior.n_OnNestedScroll_Landroidx_coordinatorlayout_widget_CoordinatorLayout_Landroid_view_View_Landroid_view_View_IIII));
				}
				return CoordinatorLayout.Behavior.cb_onNestedScroll_Landroidx_coordinatorlayout_widget_CoordinatorLayout_Landroid_view_View_Landroid_view_View_IIII;
			}

			// Token: 0x0600012C RID: 300 RVA: 0x00004A84 File Offset: 0x00002C84
			private static void n_OnNestedScroll_Landroidx_coordinatorlayout_widget_CoordinatorLayout_Landroid_view_View_Landroid_view_View_IIII(IntPtr jnienv, IntPtr native__this, IntPtr native_coordinatorLayout, IntPtr native_child, IntPtr native_target, int dxConsumed, int dyConsumed, int dxUnconsumed, int dyUnconsumed)
			{
				CoordinatorLayout.Behavior @object = Java.Lang.Object.GetObject<CoordinatorLayout.Behavior>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				CoordinatorLayout object2 = Java.Lang.Object.GetObject<CoordinatorLayout>(native_coordinatorLayout, JniHandleOwnership.DoNotTransfer);
				Java.Lang.Object object3 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_child, JniHandleOwnership.DoNotTransfer);
				View object4 = Java.Lang.Object.GetObject<View>(native_target, JniHandleOwnership.DoNotTransfer);
				@object.OnNestedScroll(object2, object3, object4, dxConsumed, dyConsumed, dxUnconsumed, dyUnconsumed);
			}

			// Token: 0x0600012D RID: 301 RVA: 0x00004AC4 File Offset: 0x00002CC4
			[Register("onNestedScroll", "(Landroidx/coordinatorlayout/widget/CoordinatorLayout;Landroid/view/View;Landroid/view/View;IIII)V", "GetOnNestedScroll_Landroidx_coordinatorlayout_widget_CoordinatorLayout_Landroid_view_View_Landroid_view_View_IIIIHandler")]
			public unsafe virtual void OnNestedScroll(CoordinatorLayout coordinatorLayout, Java.Lang.Object child, View target, int dxConsumed, int dyConsumed, int dxUnconsumed, int dyUnconsumed)
			{
				IntPtr intPtr = JNIEnv.ToLocalJniHandle(child);
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((coordinatorLayout == null) ? IntPtr.Zero : coordinatorLayout.Handle);
					ptr[1] = new JniArgumentValue(intPtr);
					ptr[2] = new JniArgumentValue((target == null) ? IntPtr.Zero : target.Handle);
					ptr[3] = new JniArgumentValue(dxConsumed);
					ptr[4] = new JniArgumentValue(dyConsumed);
					ptr[5] = new JniArgumentValue(dxUnconsumed);
					ptr[6] = new JniArgumentValue(dyUnconsumed);
					CoordinatorLayout.Behavior._members.InstanceMethods.InvokeVirtualVoidMethod("onNestedScroll.(Landroidx/coordinatorlayout/widget/CoordinatorLayout;Landroid/view/View;Landroid/view/View;IIII)V", this, ptr);
				}
				finally
				{
					JNIEnv.DeleteLocalRef(intPtr);
					GC.KeepAlive(coordinatorLayout);
					GC.KeepAlive(child);
					GC.KeepAlive(target);
				}
			}

			// Token: 0x0600012E RID: 302 RVA: 0x00004BD4 File Offset: 0x00002DD4
			private static Delegate GetOnNestedScroll_Landroidx_coordinatorlayout_widget_CoordinatorLayout_Landroid_view_View_Landroid_view_View_IIIIIHandler()
			{
				if (CoordinatorLayout.Behavior.cb_onNestedScroll_Landroidx_coordinatorlayout_widget_CoordinatorLayout_Landroid_view_View_Landroid_view_View_IIIII == null)
				{
					CoordinatorLayout.Behavior.cb_onNestedScroll_Landroidx_coordinatorlayout_widget_CoordinatorLayout_Landroid_view_View_Landroid_view_View_IIIII = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLLLIIIII_V(CoordinatorLayout.Behavior.n_OnNestedScroll_Landroidx_coordinatorlayout_widget_CoordinatorLayout_Landroid_view_View_Landroid_view_View_IIIII));
				}
				return CoordinatorLayout.Behavior.cb_onNestedScroll_Landroidx_coordinatorlayout_widget_CoordinatorLayout_Landroid_view_View_Landroid_view_View_IIIII;
			}

			// Token: 0x0600012F RID: 303 RVA: 0x00004BF8 File Offset: 0x00002DF8
			private static void n_OnNestedScroll_Landroidx_coordinatorlayout_widget_CoordinatorLayout_Landroid_view_View_Landroid_view_View_IIIII(IntPtr jnienv, IntPtr native__this, IntPtr native_coordinatorLayout, IntPtr native_child, IntPtr native_target, int dxConsumed, int dyConsumed, int dxUnconsumed, int dyUnconsumed, int type)
			{
				CoordinatorLayout.Behavior @object = Java.Lang.Object.GetObject<CoordinatorLayout.Behavior>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				CoordinatorLayout object2 = Java.Lang.Object.GetObject<CoordinatorLayout>(native_coordinatorLayout, JniHandleOwnership.DoNotTransfer);
				Java.Lang.Object object3 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_child, JniHandleOwnership.DoNotTransfer);
				View object4 = Java.Lang.Object.GetObject<View>(native_target, JniHandleOwnership.DoNotTransfer);
				@object.OnNestedScroll(object2, object3, object4, dxConsumed, dyConsumed, dxUnconsumed, dyUnconsumed, type);
			}

			// Token: 0x06000130 RID: 304 RVA: 0x00004C38 File Offset: 0x00002E38
			[Register("onNestedScroll", "(Landroidx/coordinatorlayout/widget/CoordinatorLayout;Landroid/view/View;Landroid/view/View;IIIII)V", "GetOnNestedScroll_Landroidx_coordinatorlayout_widget_CoordinatorLayout_Landroid_view_View_Landroid_view_View_IIIIIHandler")]
			public unsafe virtual void OnNestedScroll(CoordinatorLayout coordinatorLayout, Java.Lang.Object child, View target, int dxConsumed, int dyConsumed, int dxUnconsumed, int dyUnconsumed, int type)
			{
				IntPtr intPtr = JNIEnv.ToLocalJniHandle(child);
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((coordinatorLayout == null) ? IntPtr.Zero : coordinatorLayout.Handle);
					ptr[1] = new JniArgumentValue(intPtr);
					ptr[2] = new JniArgumentValue((target == null) ? IntPtr.Zero : target.Handle);
					ptr[3] = new JniArgumentValue(dxConsumed);
					ptr[4] = new JniArgumentValue(dyConsumed);
					ptr[5] = new JniArgumentValue(dxUnconsumed);
					ptr[6] = new JniArgumentValue(dyUnconsumed);
					ptr[7] = new JniArgumentValue(type);
					CoordinatorLayout.Behavior._members.InstanceMethods.InvokeVirtualVoidMethod("onNestedScroll.(Landroidx/coordinatorlayout/widget/CoordinatorLayout;Landroid/view/View;Landroid/view/View;IIIII)V", this, ptr);
				}
				finally
				{
					JNIEnv.DeleteLocalRef(intPtr);
					GC.KeepAlive(coordinatorLayout);
					GC.KeepAlive(child);
					GC.KeepAlive(target);
				}
			}

			// Token: 0x06000131 RID: 305 RVA: 0x00004D60 File Offset: 0x00002F60
			private static Delegate GetOnNestedScroll_Landroidx_coordinatorlayout_widget_CoordinatorLayout_Landroid_view_View_Landroid_view_View_IIIIIarrayIHandler()
			{
				if (CoordinatorLayout.Behavior.cb_onNestedScroll_Landroidx_coordinatorlayout_widget_CoordinatorLayout_Landroid_view_View_Landroid_view_View_IIIIIarrayI == null)
				{
					CoordinatorLayout.Behavior.cb_onNestedScroll_Landroidx_coordinatorlayout_widget_CoordinatorLayout_Landroid_view_View_Landroid_view_View_IIIIIarrayI = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLLLIIIIIL_V(CoordinatorLayout.Behavior.n_OnNestedScroll_Landroidx_coordinatorlayout_widget_CoordinatorLayout_Landroid_view_View_Landroid_view_View_IIIIIarrayI));
				}
				return CoordinatorLayout.Behavior.cb_onNestedScroll_Landroidx_coordinatorlayout_widget_CoordinatorLayout_Landroid_view_View_Landroid_view_View_IIIIIarrayI;
			}

			// Token: 0x06000132 RID: 306 RVA: 0x00004D84 File Offset: 0x00002F84
			private static void n_OnNestedScroll_Landroidx_coordinatorlayout_widget_CoordinatorLayout_Landroid_view_View_Landroid_view_View_IIIIIarrayI(IntPtr jnienv, IntPtr native__this, IntPtr native_coordinatorLayout, IntPtr native_child, IntPtr native_target, int dxConsumed, int dyConsumed, int dxUnconsumed, int dyUnconsumed, int type, IntPtr native_consumed)
			{
				CoordinatorLayout.Behavior @object = Java.Lang.Object.GetObject<CoordinatorLayout.Behavior>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				CoordinatorLayout object2 = Java.Lang.Object.GetObject<CoordinatorLayout>(native_coordinatorLayout, JniHandleOwnership.DoNotTransfer);
				Java.Lang.Object object3 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_child, JniHandleOwnership.DoNotTransfer);
				View object4 = Java.Lang.Object.GetObject<View>(native_target, JniHandleOwnership.DoNotTransfer);
				int[] array = (int[])JNIEnv.GetArray(native_consumed, JniHandleOwnership.DoNotTransfer, typeof(int));
				@object.OnNestedScroll(object2, object3, object4, dxConsumed, dyConsumed, dxUnconsumed, dyUnconsumed, type, array);
				if (array != null)
				{
					JNIEnv.CopyArray(array, native_consumed);
				}
			}

			// Token: 0x06000133 RID: 307 RVA: 0x00004DE8 File Offset: 0x00002FE8
			[Register("onNestedScroll", "(Landroidx/coordinatorlayout/widget/CoordinatorLayout;Landroid/view/View;Landroid/view/View;IIIII[I)V", "GetOnNestedScroll_Landroidx_coordinatorlayout_widget_CoordinatorLayout_Landroid_view_View_Landroid_view_View_IIIIIarrayIHandler")]
			public unsafe virtual void OnNestedScroll(CoordinatorLayout coordinatorLayout, Java.Lang.Object child, View target, int dxConsumed, int dyConsumed, int dxUnconsumed, int dyUnconsumed, int type, int[] consumed)
			{
				IntPtr intPtr = JNIEnv.ToLocalJniHandle(child);
				IntPtr intPtr2 = JNIEnv.NewArray(consumed);
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)9) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((coordinatorLayout == null) ? IntPtr.Zero : coordinatorLayout.Handle);
					ptr[1] = new JniArgumentValue(intPtr);
					ptr[2] = new JniArgumentValue((target == null) ? IntPtr.Zero : target.Handle);
					ptr[3] = new JniArgumentValue(dxConsumed);
					ptr[4] = new JniArgumentValue(dyConsumed);
					ptr[5] = new JniArgumentValue(dxUnconsumed);
					ptr[6] = new JniArgumentValue(dyUnconsumed);
					ptr[7] = new JniArgumentValue(type);
					ptr[8] = new JniArgumentValue(intPtr2);
					CoordinatorLayout.Behavior._members.InstanceMethods.InvokeVirtualVoidMethod("onNestedScroll.(Landroidx/coordinatorlayout/widget/CoordinatorLayout;Landroid/view/View;Landroid/view/View;IIIII[I)V", this, ptr);
				}
				finally
				{
					JNIEnv.DeleteLocalRef(intPtr);
					if (consumed != null)
					{
						JNIEnv.CopyArray(intPtr2, consumed);
						JNIEnv.DeleteLocalRef(intPtr2);
					}
					GC.KeepAlive(coordinatorLayout);
					GC.KeepAlive(child);
					GC.KeepAlive(target);
					GC.KeepAlive(consumed);
				}
			}

			// Token: 0x06000134 RID: 308 RVA: 0x00004F54 File Offset: 0x00003154
			private static Delegate GetOnNestedScrollAccepted_Landroidx_coordinatorlayout_widget_CoordinatorLayout_Landroid_view_View_Landroid_view_View_Landroid_view_View_IHandler()
			{
				if (CoordinatorLayout.Behavior.cb_onNestedScrollAccepted_Landroidx_coordinatorlayout_widget_CoordinatorLayout_Landroid_view_View_Landroid_view_View_Landroid_view_View_I == null)
				{
					CoordinatorLayout.Behavior.cb_onNestedScrollAccepted_Landroidx_coordinatorlayout_widget_CoordinatorLayout_Landroid_view_View_Landroid_view_View_Landroid_view_View_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLLLLI_V(CoordinatorLayout.Behavior.n_OnNestedScrollAccepted_Landroidx_coordinatorlayout_widget_CoordinatorLayout_Landroid_view_View_Landroid_view_View_Landroid_view_View_I));
				}
				return CoordinatorLayout.Behavior.cb_onNestedScrollAccepted_Landroidx_coordinatorlayout_widget_CoordinatorLayout_Landroid_view_View_Landroid_view_View_Landroid_view_View_I;
			}

			// Token: 0x06000135 RID: 309 RVA: 0x00004F78 File Offset: 0x00003178
			private static void n_OnNestedScrollAccepted_Landroidx_coordinatorlayout_widget_CoordinatorLayout_Landroid_view_View_Landroid_view_View_Landroid_view_View_I(IntPtr jnienv, IntPtr native__this, IntPtr native_coordinatorLayout, IntPtr native_child, IntPtr native_directTargetChild, IntPtr native_target, int axes)
			{
				CoordinatorLayout.Behavior @object = Java.Lang.Object.GetObject<CoordinatorLayout.Behavior>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				CoordinatorLayout object2 = Java.Lang.Object.GetObject<CoordinatorLayout>(native_coordinatorLayout, JniHandleOwnership.DoNotTransfer);
				Java.Lang.Object object3 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_child, JniHandleOwnership.DoNotTransfer);
				View object4 = Java.Lang.Object.GetObject<View>(native_directTargetChild, JniHandleOwnership.DoNotTransfer);
				View object5 = Java.Lang.Object.GetObject<View>(native_target, JniHandleOwnership.DoNotTransfer);
				@object.OnNestedScrollAccepted(object2, object3, object4, object5, axes);
			}

			// Token: 0x06000136 RID: 310 RVA: 0x00004FBC File Offset: 0x000031BC
			[Register("onNestedScrollAccepted", "(Landroidx/coordinatorlayout/widget/CoordinatorLayout;Landroid/view/View;Landroid/view/View;Landroid/view/View;I)V", "GetOnNestedScrollAccepted_Landroidx_coordinatorlayout_widget_CoordinatorLayout_Landroid_view_View_Landroid_view_View_Landroid_view_View_IHandler")]
			public unsafe virtual void OnNestedScrollAccepted(CoordinatorLayout coordinatorLayout, Java.Lang.Object child, View directTargetChild, View target, int axes)
			{
				IntPtr intPtr = JNIEnv.ToLocalJniHandle(child);
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((coordinatorLayout == null) ? IntPtr.Zero : coordinatorLayout.Handle);
					ptr[1] = new JniArgumentValue(intPtr);
					ptr[2] = new JniArgumentValue((directTargetChild == null) ? IntPtr.Zero : directTargetChild.Handle);
					ptr[3] = new JniArgumentValue((target == null) ? IntPtr.Zero : target.Handle);
					ptr[4] = new JniArgumentValue(axes);
					CoordinatorLayout.Behavior._members.InstanceMethods.InvokeVirtualVoidMethod("onNestedScrollAccepted.(Landroidx/coordinatorlayout/widget/CoordinatorLayout;Landroid/view/View;Landroid/view/View;Landroid/view/View;I)V", this, ptr);
				}
				finally
				{
					JNIEnv.DeleteLocalRef(intPtr);
					GC.KeepAlive(coordinatorLayout);
					GC.KeepAlive(child);
					GC.KeepAlive(directTargetChild);
					GC.KeepAlive(target);
				}
			}

			// Token: 0x06000137 RID: 311 RVA: 0x000050B8 File Offset: 0x000032B8
			private static Delegate GetOnNestedScrollAccepted_Landroidx_coordinatorlayout_widget_CoordinatorLayout_Landroid_view_View_Landroid_view_View_Landroid_view_View_IIHandler()
			{
				if (CoordinatorLayout.Behavior.cb_onNestedScrollAccepted_Landroidx_coordinatorlayout_widget_CoordinatorLayout_Landroid_view_View_Landroid_view_View_Landroid_view_View_II == null)
				{
					CoordinatorLayout.Behavior.cb_onNestedScrollAccepted_Landroidx_coordinatorlayout_widget_CoordinatorLayout_Landroid_view_View_Landroid_view_View_Landroid_view_View_II = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLLLLII_V(CoordinatorLayout.Behavior.n_OnNestedScrollAccepted_Landroidx_coordinatorlayout_widget_CoordinatorLayout_Landroid_view_View_Landroid_view_View_Landroid_view_View_II));
				}
				return CoordinatorLayout.Behavior.cb_onNestedScrollAccepted_Landroidx_coordinatorlayout_widget_CoordinatorLayout_Landroid_view_View_Landroid_view_View_Landroid_view_View_II;
			}

			// Token: 0x06000138 RID: 312 RVA: 0x000050DC File Offset: 0x000032DC
			private static void n_OnNestedScrollAccepted_Landroidx_coordinatorlayout_widget_CoordinatorLayout_Landroid_view_View_Landroid_view_View_Landroid_view_View_II(IntPtr jnienv, IntPtr native__this, IntPtr native_coordinatorLayout, IntPtr native_child, IntPtr native_directTargetChild, IntPtr native_target, int axes, int type)
			{
				CoordinatorLayout.Behavior @object = Java.Lang.Object.GetObject<CoordinatorLayout.Behavior>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				CoordinatorLayout object2 = Java.Lang.Object.GetObject<CoordinatorLayout>(native_coordinatorLayout, JniHandleOwnership.DoNotTransfer);
				Java.Lang.Object object3 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_child, JniHandleOwnership.DoNotTransfer);
				View object4 = Java.Lang.Object.GetObject<View>(native_directTargetChild, JniHandleOwnership.DoNotTransfer);
				View object5 = Java.Lang.Object.GetObject<View>(native_target, JniHandleOwnership.DoNotTransfer);
				@object.OnNestedScrollAccepted(object2, object3, object4, object5, axes, type);
			}

			// Token: 0x06000139 RID: 313 RVA: 0x00005120 File Offset: 0x00003320
			[Register("onNestedScrollAccepted", "(Landroidx/coordinatorlayout/widget/CoordinatorLayout;Landroid/view/View;Landroid/view/View;Landroid/view/View;II)V", "GetOnNestedScrollAccepted_Landroidx_coordinatorlayout_widget_CoordinatorLayout_Landroid_view_View_Landroid_view_View_Landroid_view_View_IIHandler")]
			public unsafe virtual void OnNestedScrollAccepted(CoordinatorLayout coordinatorLayout, Java.Lang.Object child, View directTargetChild, View target, int axes, int type)
			{
				IntPtr intPtr = JNIEnv.ToLocalJniHandle(child);
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((coordinatorLayout == null) ? IntPtr.Zero : coordinatorLayout.Handle);
					ptr[1] = new JniArgumentValue(intPtr);
					ptr[2] = new JniArgumentValue((directTargetChild == null) ? IntPtr.Zero : directTargetChild.Handle);
					ptr[3] = new JniArgumentValue((target == null) ? IntPtr.Zero : target.Handle);
					ptr[4] = new JniArgumentValue(axes);
					ptr[5] = new JniArgumentValue(type);
					CoordinatorLayout.Behavior._members.InstanceMethods.InvokeVirtualVoidMethod("onNestedScrollAccepted.(Landroidx/coordinatorlayout/widget/CoordinatorLayout;Landroid/view/View;Landroid/view/View;Landroid/view/View;II)V", this, ptr);
				}
				finally
				{
					JNIEnv.DeleteLocalRef(intPtr);
					GC.KeepAlive(coordinatorLayout);
					GC.KeepAlive(child);
					GC.KeepAlive(directTargetChild);
					GC.KeepAlive(target);
				}
			}

			// Token: 0x0600013A RID: 314 RVA: 0x00005230 File Offset: 0x00003430
			private static Delegate GetOnRequestChildRectangleOnScreen_Landroidx_coordinatorlayout_widget_CoordinatorLayout_Landroid_view_View_Landroid_graphics_Rect_ZHandler()
			{
				if (CoordinatorLayout.Behavior.cb_onRequestChildRectangleOnScreen_Landroidx_coordinatorlayout_widget_CoordinatorLayout_Landroid_view_View_Landroid_graphics_Rect_Z == null)
				{
					CoordinatorLayout.Behavior.cb_onRequestChildRectangleOnScreen_Landroidx_coordinatorlayout_widget_CoordinatorLayout_Landroid_view_View_Landroid_graphics_Rect_Z = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLLLZ_Z(CoordinatorLayout.Behavior.n_OnRequestChildRectangleOnScreen_Landroidx_coordinatorlayout_widget_CoordinatorLayout_Landroid_view_View_Landroid_graphics_Rect_Z));
				}
				return CoordinatorLayout.Behavior.cb_onRequestChildRectangleOnScreen_Landroidx_coordinatorlayout_widget_CoordinatorLayout_Landroid_view_View_Landroid_graphics_Rect_Z;
			}

			// Token: 0x0600013B RID: 315 RVA: 0x00005254 File Offset: 0x00003454
			private static bool n_OnRequestChildRectangleOnScreen_Landroidx_coordinatorlayout_widget_CoordinatorLayout_Landroid_view_View_Landroid_graphics_Rect_Z(IntPtr jnienv, IntPtr native__this, IntPtr native_coordinatorLayout, IntPtr native_child, IntPtr native_rectangle, bool immediate)
			{
				CoordinatorLayout.Behavior @object = Java.Lang.Object.GetObject<CoordinatorLayout.Behavior>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				CoordinatorLayout object2 = Java.Lang.Object.GetObject<CoordinatorLayout>(native_coordinatorLayout, JniHandleOwnership.DoNotTransfer);
				Java.Lang.Object object3 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_child, JniHandleOwnership.DoNotTransfer);
				Rect object4 = Java.Lang.Object.GetObject<Rect>(native_rectangle, JniHandleOwnership.DoNotTransfer);
				return @object.OnRequestChildRectangleOnScreen(object2, object3, object4, immediate);
			}

			// Token: 0x0600013C RID: 316 RVA: 0x0000528C File Offset: 0x0000348C
			[Register("onRequestChildRectangleOnScreen", "(Landroidx/coordinatorlayout/widget/CoordinatorLayout;Landroid/view/View;Landroid/graphics/Rect;Z)Z", "GetOnRequestChildRectangleOnScreen_Landroidx_coordinatorlayout_widget_CoordinatorLayout_Landroid_view_View_Landroid_graphics_Rect_ZHandler")]
			public unsafe virtual bool OnRequestChildRectangleOnScreen(CoordinatorLayout coordinatorLayout, Java.Lang.Object child, Rect rectangle, bool immediate)
			{
				IntPtr intPtr = JNIEnv.ToLocalJniHandle(child);
				bool result;
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((coordinatorLayout == null) ? IntPtr.Zero : coordinatorLayout.Handle);
					ptr[1] = new JniArgumentValue(intPtr);
					ptr[2] = new JniArgumentValue((rectangle == null) ? IntPtr.Zero : rectangle.Handle);
					ptr[3] = new JniArgumentValue(immediate);
					result = CoordinatorLayout.Behavior._members.InstanceMethods.InvokeVirtualBooleanMethod("onRequestChildRectangleOnScreen.(Landroidx/coordinatorlayout/widget/CoordinatorLayout;Landroid/view/View;Landroid/graphics/Rect;Z)Z", this, ptr);
				}
				finally
				{
					JNIEnv.DeleteLocalRef(intPtr);
					GC.KeepAlive(coordinatorLayout);
					GC.KeepAlive(child);
					GC.KeepAlive(rectangle);
				}
				return result;
			}

			// Token: 0x0600013D RID: 317 RVA: 0x0000535C File Offset: 0x0000355C
			private static Delegate GetOnRestoreInstanceState_Landroidx_coordinatorlayout_widget_CoordinatorLayout_Landroid_view_View_Landroid_os_Parcelable_Handler()
			{
				if (CoordinatorLayout.Behavior.cb_onRestoreInstanceState_Landroidx_coordinatorlayout_widget_CoordinatorLayout_Landroid_view_View_Landroid_os_Parcelable_ == null)
				{
					CoordinatorLayout.Behavior.cb_onRestoreInstanceState_Landroidx_coordinatorlayout_widget_CoordinatorLayout_Landroid_view_View_Landroid_os_Parcelable_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLLL_V(CoordinatorLayout.Behavior.n_OnRestoreInstanceState_Landroidx_coordinatorlayout_widget_CoordinatorLayout_Landroid_view_View_Landroid_os_Parcelable_));
				}
				return CoordinatorLayout.Behavior.cb_onRestoreInstanceState_Landroidx_coordinatorlayout_widget_CoordinatorLayout_Landroid_view_View_Landroid_os_Parcelable_;
			}

			// Token: 0x0600013E RID: 318 RVA: 0x00005380 File Offset: 0x00003580
			private static void n_OnRestoreInstanceState_Landroidx_coordinatorlayout_widget_CoordinatorLayout_Landroid_view_View_Landroid_os_Parcelable_(IntPtr jnienv, IntPtr native__this, IntPtr native_parent, IntPtr native_child, IntPtr native_state)
			{
				CoordinatorLayout.Behavior @object = Java.Lang.Object.GetObject<CoordinatorLayout.Behavior>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				CoordinatorLayout object2 = Java.Lang.Object.GetObject<CoordinatorLayout>(native_parent, JniHandleOwnership.DoNotTransfer);
				Java.Lang.Object object3 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_child, JniHandleOwnership.DoNotTransfer);
				IParcelable object4 = Java.Lang.Object.GetObject<IParcelable>(native_state, JniHandleOwnership.DoNotTransfer);
				@object.OnRestoreInstanceState(object2, object3, object4);
			}

			// Token: 0x0600013F RID: 319 RVA: 0x000053B8 File Offset: 0x000035B8
			[Register("onRestoreInstanceState", "(Landroidx/coordinatorlayout/widget/CoordinatorLayout;Landroid/view/View;Landroid/os/Parcelable;)V", "GetOnRestoreInstanceState_Landroidx_coordinatorlayout_widget_CoordinatorLayout_Landroid_view_View_Landroid_os_Parcelable_Handler")]
			public unsafe virtual void OnRestoreInstanceState(CoordinatorLayout parent, Java.Lang.Object child, IParcelable state)
			{
				IntPtr intPtr = JNIEnv.ToLocalJniHandle(child);
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((parent == null) ? IntPtr.Zero : parent.Handle);
					ptr[1] = new JniArgumentValue(intPtr);
					ptr[2] = new JniArgumentValue((state == null) ? IntPtr.Zero : ((Java.Lang.Object)state).Handle);
					CoordinatorLayout.Behavior._members.InstanceMethods.InvokeVirtualVoidMethod("onRestoreInstanceState.(Landroidx/coordinatorlayout/widget/CoordinatorLayout;Landroid/view/View;Landroid/os/Parcelable;)V", this, ptr);
				}
				finally
				{
					JNIEnv.DeleteLocalRef(intPtr);
					GC.KeepAlive(parent);
					GC.KeepAlive(child);
					GC.KeepAlive(state);
				}
			}

			// Token: 0x06000140 RID: 320 RVA: 0x00005474 File Offset: 0x00003674
			private static Delegate GetOnSaveInstanceState_Landroidx_coordinatorlayout_widget_CoordinatorLayout_Landroid_view_View_Handler()
			{
				if (CoordinatorLayout.Behavior.cb_onSaveInstanceState_Landroidx_coordinatorlayout_widget_CoordinatorLayout_Landroid_view_View_ == null)
				{
					CoordinatorLayout.Behavior.cb_onSaveInstanceState_Landroidx_coordinatorlayout_widget_CoordinatorLayout_Landroid_view_View_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_L(CoordinatorLayout.Behavior.n_OnSaveInstanceState_Landroidx_coordinatorlayout_widget_CoordinatorLayout_Landroid_view_View_));
				}
				return CoordinatorLayout.Behavior.cb_onSaveInstanceState_Landroidx_coordinatorlayout_widget_CoordinatorLayout_Landroid_view_View_;
			}

			// Token: 0x06000141 RID: 321 RVA: 0x00005498 File Offset: 0x00003698
			private static IntPtr n_OnSaveInstanceState_Landroidx_coordinatorlayout_widget_CoordinatorLayout_Landroid_view_View_(IntPtr jnienv, IntPtr native__this, IntPtr native_parent, IntPtr native_child)
			{
				CoordinatorLayout.Behavior @object = Java.Lang.Object.GetObject<CoordinatorLayout.Behavior>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				CoordinatorLayout object2 = Java.Lang.Object.GetObject<CoordinatorLayout>(native_parent, JniHandleOwnership.DoNotTransfer);
				Java.Lang.Object object3 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_child, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle(@object.OnSaveInstanceState(object2, object3));
			}

			// Token: 0x06000142 RID: 322 RVA: 0x000054CC File Offset: 0x000036CC
			[Register("onSaveInstanceState", "(Landroidx/coordinatorlayout/widget/CoordinatorLayout;Landroid/view/View;)Landroid/os/Parcelable;", "GetOnSaveInstanceState_Landroidx_coordinatorlayout_widget_CoordinatorLayout_Landroid_view_View_Handler")]
			public unsafe virtual IParcelable OnSaveInstanceState(CoordinatorLayout parent, Java.Lang.Object child)
			{
				IntPtr intPtr = JNIEnv.ToLocalJniHandle(child);
				IParcelable @object;
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((parent == null) ? IntPtr.Zero : parent.Handle);
					ptr[1] = new JniArgumentValue(intPtr);
					@object = Java.Lang.Object.GetObject<IParcelable>(CoordinatorLayout.Behavior._members.InstanceMethods.InvokeVirtualObjectMethod("onSaveInstanceState.(Landroidx/coordinatorlayout/widget/CoordinatorLayout;Landroid/view/View;)Landroid/os/Parcelable;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
				}
				finally
				{
					JNIEnv.DeleteLocalRef(intPtr);
					GC.KeepAlive(parent);
					GC.KeepAlive(child);
				}
				return @object;
			}

			// Token: 0x06000143 RID: 323 RVA: 0x00005568 File Offset: 0x00003768
			private static Delegate GetOnStartNestedScroll_Landroidx_coordinatorlayout_widget_CoordinatorLayout_Landroid_view_View_Landroid_view_View_Landroid_view_View_IHandler()
			{
				if (CoordinatorLayout.Behavior.cb_onStartNestedScroll_Landroidx_coordinatorlayout_widget_CoordinatorLayout_Landroid_view_View_Landroid_view_View_Landroid_view_View_I == null)
				{
					CoordinatorLayout.Behavior.cb_onStartNestedScroll_Landroidx_coordinatorlayout_widget_CoordinatorLayout_Landroid_view_View_Landroid_view_View_Landroid_view_View_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLLLLI_Z(CoordinatorLayout.Behavior.n_OnStartNestedScroll_Landroidx_coordinatorlayout_widget_CoordinatorLayout_Landroid_view_View_Landroid_view_View_Landroid_view_View_I));
				}
				return CoordinatorLayout.Behavior.cb_onStartNestedScroll_Landroidx_coordinatorlayout_widget_CoordinatorLayout_Landroid_view_View_Landroid_view_View_Landroid_view_View_I;
			}

			// Token: 0x06000144 RID: 324 RVA: 0x0000558C File Offset: 0x0000378C
			private static bool n_OnStartNestedScroll_Landroidx_coordinatorlayout_widget_CoordinatorLayout_Landroid_view_View_Landroid_view_View_Landroid_view_View_I(IntPtr jnienv, IntPtr native__this, IntPtr native_coordinatorLayout, IntPtr native_child, IntPtr native_directTargetChild, IntPtr native_target, int axes)
			{
				CoordinatorLayout.Behavior @object = Java.Lang.Object.GetObject<CoordinatorLayout.Behavior>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				CoordinatorLayout object2 = Java.Lang.Object.GetObject<CoordinatorLayout>(native_coordinatorLayout, JniHandleOwnership.DoNotTransfer);
				Java.Lang.Object object3 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_child, JniHandleOwnership.DoNotTransfer);
				View object4 = Java.Lang.Object.GetObject<View>(native_directTargetChild, JniHandleOwnership.DoNotTransfer);
				View object5 = Java.Lang.Object.GetObject<View>(native_target, JniHandleOwnership.DoNotTransfer);
				return @object.OnStartNestedScroll(object2, object3, object4, object5, axes);
			}

			// Token: 0x06000145 RID: 325 RVA: 0x000055D0 File Offset: 0x000037D0
			[Register("onStartNestedScroll", "(Landroidx/coordinatorlayout/widget/CoordinatorLayout;Landroid/view/View;Landroid/view/View;Landroid/view/View;I)Z", "GetOnStartNestedScroll_Landroidx_coordinatorlayout_widget_CoordinatorLayout_Landroid_view_View_Landroid_view_View_Landroid_view_View_IHandler")]
			public unsafe virtual bool OnStartNestedScroll(CoordinatorLayout coordinatorLayout, Java.Lang.Object child, View directTargetChild, View target, int axes)
			{
				IntPtr intPtr = JNIEnv.ToLocalJniHandle(child);
				bool result;
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((coordinatorLayout == null) ? IntPtr.Zero : coordinatorLayout.Handle);
					ptr[1] = new JniArgumentValue(intPtr);
					ptr[2] = new JniArgumentValue((directTargetChild == null) ? IntPtr.Zero : directTargetChild.Handle);
					ptr[3] = new JniArgumentValue((target == null) ? IntPtr.Zero : target.Handle);
					ptr[4] = new JniArgumentValue(axes);
					result = CoordinatorLayout.Behavior._members.InstanceMethods.InvokeVirtualBooleanMethod("onStartNestedScroll.(Landroidx/coordinatorlayout/widget/CoordinatorLayout;Landroid/view/View;Landroid/view/View;Landroid/view/View;I)Z", this, ptr);
				}
				finally
				{
					JNIEnv.DeleteLocalRef(intPtr);
					GC.KeepAlive(coordinatorLayout);
					GC.KeepAlive(child);
					GC.KeepAlive(directTargetChild);
					GC.KeepAlive(target);
				}
				return result;
			}

			// Token: 0x06000146 RID: 326 RVA: 0x000056CC File Offset: 0x000038CC
			private static Delegate GetOnStartNestedScroll_Landroidx_coordinatorlayout_widget_CoordinatorLayout_Landroid_view_View_Landroid_view_View_Landroid_view_View_IIHandler()
			{
				if (CoordinatorLayout.Behavior.cb_onStartNestedScroll_Landroidx_coordinatorlayout_widget_CoordinatorLayout_Landroid_view_View_Landroid_view_View_Landroid_view_View_II == null)
				{
					CoordinatorLayout.Behavior.cb_onStartNestedScroll_Landroidx_coordinatorlayout_widget_CoordinatorLayout_Landroid_view_View_Landroid_view_View_Landroid_view_View_II = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLLLLII_Z(CoordinatorLayout.Behavior.n_OnStartNestedScroll_Landroidx_coordinatorlayout_widget_CoordinatorLayout_Landroid_view_View_Landroid_view_View_Landroid_view_View_II));
				}
				return CoordinatorLayout.Behavior.cb_onStartNestedScroll_Landroidx_coordinatorlayout_widget_CoordinatorLayout_Landroid_view_View_Landroid_view_View_Landroid_view_View_II;
			}

			// Token: 0x06000147 RID: 327 RVA: 0x000056F0 File Offset: 0x000038F0
			private static bool n_OnStartNestedScroll_Landroidx_coordinatorlayout_widget_CoordinatorLayout_Landroid_view_View_Landroid_view_View_Landroid_view_View_II(IntPtr jnienv, IntPtr native__this, IntPtr native_coordinatorLayout, IntPtr native_child, IntPtr native_directTargetChild, IntPtr native_target, int axes, int type)
			{
				CoordinatorLayout.Behavior @object = Java.Lang.Object.GetObject<CoordinatorLayout.Behavior>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				CoordinatorLayout object2 = Java.Lang.Object.GetObject<CoordinatorLayout>(native_coordinatorLayout, JniHandleOwnership.DoNotTransfer);
				Java.Lang.Object object3 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_child, JniHandleOwnership.DoNotTransfer);
				View object4 = Java.Lang.Object.GetObject<View>(native_directTargetChild, JniHandleOwnership.DoNotTransfer);
				View object5 = Java.Lang.Object.GetObject<View>(native_target, JniHandleOwnership.DoNotTransfer);
				return @object.OnStartNestedScroll(object2, object3, object4, object5, axes, type);
			}

			// Token: 0x06000148 RID: 328 RVA: 0x00005734 File Offset: 0x00003934
			[Register("onStartNestedScroll", "(Landroidx/coordinatorlayout/widget/CoordinatorLayout;Landroid/view/View;Landroid/view/View;Landroid/view/View;II)Z", "GetOnStartNestedScroll_Landroidx_coordinatorlayout_widget_CoordinatorLayout_Landroid_view_View_Landroid_view_View_Landroid_view_View_IIHandler")]
			public unsafe virtual bool OnStartNestedScroll(CoordinatorLayout coordinatorLayout, Java.Lang.Object child, View directTargetChild, View target, int axes, int type)
			{
				IntPtr intPtr = JNIEnv.ToLocalJniHandle(child);
				bool result;
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((coordinatorLayout == null) ? IntPtr.Zero : coordinatorLayout.Handle);
					ptr[1] = new JniArgumentValue(intPtr);
					ptr[2] = new JniArgumentValue((directTargetChild == null) ? IntPtr.Zero : directTargetChild.Handle);
					ptr[3] = new JniArgumentValue((target == null) ? IntPtr.Zero : target.Handle);
					ptr[4] = new JniArgumentValue(axes);
					ptr[5] = new JniArgumentValue(type);
					result = CoordinatorLayout.Behavior._members.InstanceMethods.InvokeVirtualBooleanMethod("onStartNestedScroll.(Landroidx/coordinatorlayout/widget/CoordinatorLayout;Landroid/view/View;Landroid/view/View;Landroid/view/View;II)Z", this, ptr);
				}
				finally
				{
					JNIEnv.DeleteLocalRef(intPtr);
					GC.KeepAlive(coordinatorLayout);
					GC.KeepAlive(child);
					GC.KeepAlive(directTargetChild);
					GC.KeepAlive(target);
				}
				return result;
			}

			// Token: 0x06000149 RID: 329 RVA: 0x00005848 File Offset: 0x00003A48
			private static Delegate GetOnStopNestedScroll_Landroidx_coordinatorlayout_widget_CoordinatorLayout_Landroid_view_View_Landroid_view_View_Handler()
			{
				if (CoordinatorLayout.Behavior.cb_onStopNestedScroll_Landroidx_coordinatorlayout_widget_CoordinatorLayout_Landroid_view_View_Landroid_view_View_ == null)
				{
					CoordinatorLayout.Behavior.cb_onStopNestedScroll_Landroidx_coordinatorlayout_widget_CoordinatorLayout_Landroid_view_View_Landroid_view_View_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLLL_V(CoordinatorLayout.Behavior.n_OnStopNestedScroll_Landroidx_coordinatorlayout_widget_CoordinatorLayout_Landroid_view_View_Landroid_view_View_));
				}
				return CoordinatorLayout.Behavior.cb_onStopNestedScroll_Landroidx_coordinatorlayout_widget_CoordinatorLayout_Landroid_view_View_Landroid_view_View_;
			}

			// Token: 0x0600014A RID: 330 RVA: 0x0000586C File Offset: 0x00003A6C
			private static void n_OnStopNestedScroll_Landroidx_coordinatorlayout_widget_CoordinatorLayout_Landroid_view_View_Landroid_view_View_(IntPtr jnienv, IntPtr native__this, IntPtr native_coordinatorLayout, IntPtr native_child, IntPtr native_target)
			{
				CoordinatorLayout.Behavior @object = Java.Lang.Object.GetObject<CoordinatorLayout.Behavior>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				CoordinatorLayout object2 = Java.Lang.Object.GetObject<CoordinatorLayout>(native_coordinatorLayout, JniHandleOwnership.DoNotTransfer);
				Java.Lang.Object object3 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_child, JniHandleOwnership.DoNotTransfer);
				View object4 = Java.Lang.Object.GetObject<View>(native_target, JniHandleOwnership.DoNotTransfer);
				@object.OnStopNestedScroll(object2, object3, object4);
			}

			// Token: 0x0600014B RID: 331 RVA: 0x000058A4 File Offset: 0x00003AA4
			[Register("onStopNestedScroll", "(Landroidx/coordinatorlayout/widget/CoordinatorLayout;Landroid/view/View;Landroid/view/View;)V", "GetOnStopNestedScroll_Landroidx_coordinatorlayout_widget_CoordinatorLayout_Landroid_view_View_Landroid_view_View_Handler")]
			public unsafe virtual void OnStopNestedScroll(CoordinatorLayout coordinatorLayout, Java.Lang.Object child, View target)
			{
				IntPtr intPtr = JNIEnv.ToLocalJniHandle(child);
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((coordinatorLayout == null) ? IntPtr.Zero : coordinatorLayout.Handle);
					ptr[1] = new JniArgumentValue(intPtr);
					ptr[2] = new JniArgumentValue((target == null) ? IntPtr.Zero : target.Handle);
					CoordinatorLayout.Behavior._members.InstanceMethods.InvokeVirtualVoidMethod("onStopNestedScroll.(Landroidx/coordinatorlayout/widget/CoordinatorLayout;Landroid/view/View;Landroid/view/View;)V", this, ptr);
				}
				finally
				{
					JNIEnv.DeleteLocalRef(intPtr);
					GC.KeepAlive(coordinatorLayout);
					GC.KeepAlive(child);
					GC.KeepAlive(target);
				}
			}

			// Token: 0x0600014C RID: 332 RVA: 0x00005958 File Offset: 0x00003B58
			private static Delegate GetOnStopNestedScroll_Landroidx_coordinatorlayout_widget_CoordinatorLayout_Landroid_view_View_Landroid_view_View_IHandler()
			{
				if (CoordinatorLayout.Behavior.cb_onStopNestedScroll_Landroidx_coordinatorlayout_widget_CoordinatorLayout_Landroid_view_View_Landroid_view_View_I == null)
				{
					CoordinatorLayout.Behavior.cb_onStopNestedScroll_Landroidx_coordinatorlayout_widget_CoordinatorLayout_Landroid_view_View_Landroid_view_View_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLLLI_V(CoordinatorLayout.Behavior.n_OnStopNestedScroll_Landroidx_coordinatorlayout_widget_CoordinatorLayout_Landroid_view_View_Landroid_view_View_I));
				}
				return CoordinatorLayout.Behavior.cb_onStopNestedScroll_Landroidx_coordinatorlayout_widget_CoordinatorLayout_Landroid_view_View_Landroid_view_View_I;
			}

			// Token: 0x0600014D RID: 333 RVA: 0x0000597C File Offset: 0x00003B7C
			private static void n_OnStopNestedScroll_Landroidx_coordinatorlayout_widget_CoordinatorLayout_Landroid_view_View_Landroid_view_View_I(IntPtr jnienv, IntPtr native__this, IntPtr native_coordinatorLayout, IntPtr native_child, IntPtr native_target, int type)
			{
				CoordinatorLayout.Behavior @object = Java.Lang.Object.GetObject<CoordinatorLayout.Behavior>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				CoordinatorLayout object2 = Java.Lang.Object.GetObject<CoordinatorLayout>(native_coordinatorLayout, JniHandleOwnership.DoNotTransfer);
				Java.Lang.Object object3 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_child, JniHandleOwnership.DoNotTransfer);
				View object4 = Java.Lang.Object.GetObject<View>(native_target, JniHandleOwnership.DoNotTransfer);
				@object.OnStopNestedScroll(object2, object3, object4, type);
			}

			// Token: 0x0600014E RID: 334 RVA: 0x000059B4 File Offset: 0x00003BB4
			[Register("onStopNestedScroll", "(Landroidx/coordinatorlayout/widget/CoordinatorLayout;Landroid/view/View;Landroid/view/View;I)V", "GetOnStopNestedScroll_Landroidx_coordinatorlayout_widget_CoordinatorLayout_Landroid_view_View_Landroid_view_View_IHandler")]
			public unsafe virtual void OnStopNestedScroll(CoordinatorLayout coordinatorLayout, Java.Lang.Object child, View target, int type)
			{
				IntPtr intPtr = JNIEnv.ToLocalJniHandle(child);
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((coordinatorLayout == null) ? IntPtr.Zero : coordinatorLayout.Handle);
					ptr[1] = new JniArgumentValue(intPtr);
					ptr[2] = new JniArgumentValue((target == null) ? IntPtr.Zero : target.Handle);
					ptr[3] = new JniArgumentValue(type);
					CoordinatorLayout.Behavior._members.InstanceMethods.InvokeVirtualVoidMethod("onStopNestedScroll.(Landroidx/coordinatorlayout/widget/CoordinatorLayout;Landroid/view/View;Landroid/view/View;I)V", this, ptr);
				}
				finally
				{
					JNIEnv.DeleteLocalRef(intPtr);
					GC.KeepAlive(coordinatorLayout);
					GC.KeepAlive(child);
					GC.KeepAlive(target);
				}
			}

			// Token: 0x0600014F RID: 335 RVA: 0x00005A80 File Offset: 0x00003C80
			private static Delegate GetOnTouchEvent_Landroidx_coordinatorlayout_widget_CoordinatorLayout_Landroid_view_View_Landroid_view_MotionEvent_Handler()
			{
				if (CoordinatorLayout.Behavior.cb_onTouchEvent_Landroidx_coordinatorlayout_widget_CoordinatorLayout_Landroid_view_View_Landroid_view_MotionEvent_ == null)
				{
					CoordinatorLayout.Behavior.cb_onTouchEvent_Landroidx_coordinatorlayout_widget_CoordinatorLayout_Landroid_view_View_Landroid_view_MotionEvent_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLLL_Z(CoordinatorLayout.Behavior.n_OnTouchEvent_Landroidx_coordinatorlayout_widget_CoordinatorLayout_Landroid_view_View_Landroid_view_MotionEvent_));
				}
				return CoordinatorLayout.Behavior.cb_onTouchEvent_Landroidx_coordinatorlayout_widget_CoordinatorLayout_Landroid_view_View_Landroid_view_MotionEvent_;
			}

			// Token: 0x06000150 RID: 336 RVA: 0x00005AA4 File Offset: 0x00003CA4
			private static bool n_OnTouchEvent_Landroidx_coordinatorlayout_widget_CoordinatorLayout_Landroid_view_View_Landroid_view_MotionEvent_(IntPtr jnienv, IntPtr native__this, IntPtr native_parent, IntPtr native_child, IntPtr native_ev)
			{
				CoordinatorLayout.Behavior @object = Java.Lang.Object.GetObject<CoordinatorLayout.Behavior>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				CoordinatorLayout object2 = Java.Lang.Object.GetObject<CoordinatorLayout>(native_parent, JniHandleOwnership.DoNotTransfer);
				Java.Lang.Object object3 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_child, JniHandleOwnership.DoNotTransfer);
				MotionEvent object4 = Java.Lang.Object.GetObject<MotionEvent>(native_ev, JniHandleOwnership.DoNotTransfer);
				return @object.OnTouchEvent(object2, object3, object4);
			}

			// Token: 0x06000151 RID: 337 RVA: 0x00005ADC File Offset: 0x00003CDC
			[Register("onTouchEvent", "(Landroidx/coordinatorlayout/widget/CoordinatorLayout;Landroid/view/View;Landroid/view/MotionEvent;)Z", "GetOnTouchEvent_Landroidx_coordinatorlayout_widget_CoordinatorLayout_Landroid_view_View_Landroid_view_MotionEvent_Handler")]
			public unsafe virtual bool OnTouchEvent(CoordinatorLayout parent, Java.Lang.Object child, MotionEvent ev)
			{
				IntPtr intPtr = JNIEnv.ToLocalJniHandle(child);
				bool result;
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((parent == null) ? IntPtr.Zero : parent.Handle);
					ptr[1] = new JniArgumentValue(intPtr);
					ptr[2] = new JniArgumentValue((ev == null) ? IntPtr.Zero : ev.Handle);
					result = CoordinatorLayout.Behavior._members.InstanceMethods.InvokeVirtualBooleanMethod("onTouchEvent.(Landroidx/coordinatorlayout/widget/CoordinatorLayout;Landroid/view/View;Landroid/view/MotionEvent;)Z", this, ptr);
				}
				finally
				{
					JNIEnv.DeleteLocalRef(intPtr);
					GC.KeepAlive(parent);
					GC.KeepAlive(child);
					GC.KeepAlive(ev);
				}
				return result;
			}

			// Token: 0x06000152 RID: 338 RVA: 0x00005B94 File Offset: 0x00003D94
			[Register("setTag", "(Landroid/view/View;Ljava/lang/Object;)V", "")]
			public unsafe static void SetTag(View child, Java.Lang.Object tag)
			{
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((child == null) ? IntPtr.Zero : child.Handle);
					ptr[1] = new JniArgumentValue((tag == null) ? IntPtr.Zero : tag.Handle);
					CoordinatorLayout.Behavior._members.StaticMethods.InvokeVoidMethod("setTag.(Landroid/view/View;Ljava/lang/Object;)V", ptr);
				}
				finally
				{
					GC.KeepAlive(child);
					GC.KeepAlive(tag);
				}
			}

			// Token: 0x0400001D RID: 29
			private static readonly JniPeerMembers _members = new XAPeerMembers("androidx/coordinatorlayout/widget/CoordinatorLayout$Behavior", typeof(CoordinatorLayout.Behavior));

			// Token: 0x0400001E RID: 30
			private static Delegate cb_blocksInteractionBelow_Landroidx_coordinatorlayout_widget_CoordinatorLayout_Landroid_view_View_;

			// Token: 0x0400001F RID: 31
			private static Delegate cb_getInsetDodgeRect_Landroidx_coordinatorlayout_widget_CoordinatorLayout_Landroid_view_View_Landroid_graphics_Rect_;

			// Token: 0x04000020 RID: 32
			private static Delegate cb_getScrimColor_Landroidx_coordinatorlayout_widget_CoordinatorLayout_Landroid_view_View_;

			// Token: 0x04000021 RID: 33
			private static Delegate cb_getScrimOpacity_Landroidx_coordinatorlayout_widget_CoordinatorLayout_Landroid_view_View_;

			// Token: 0x04000022 RID: 34
			private static Delegate cb_layoutDependsOn_Landroidx_coordinatorlayout_widget_CoordinatorLayout_Landroid_view_View_Landroid_view_View_;

			// Token: 0x04000023 RID: 35
			private static Delegate cb_onApplyWindowInsets_Landroidx_coordinatorlayout_widget_CoordinatorLayout_Landroid_view_View_Landroidx_core_view_WindowInsetsCompat_;

			// Token: 0x04000024 RID: 36
			private static Delegate cb_onAttachedToLayoutParams_Landroidx_coordinatorlayout_widget_CoordinatorLayout_LayoutParams_;

			// Token: 0x04000025 RID: 37
			private static Delegate cb_onDependentViewChanged_Landroidx_coordinatorlayout_widget_CoordinatorLayout_Landroid_view_View_Landroid_view_View_;

			// Token: 0x04000026 RID: 38
			private static Delegate cb_onDependentViewRemoved_Landroidx_coordinatorlayout_widget_CoordinatorLayout_Landroid_view_View_Landroid_view_View_;

			// Token: 0x04000027 RID: 39
			private static Delegate cb_onDetachedFromLayoutParams;

			// Token: 0x04000028 RID: 40
			private static Delegate cb_onInterceptTouchEvent_Landroidx_coordinatorlayout_widget_CoordinatorLayout_Landroid_view_View_Landroid_view_MotionEvent_;

			// Token: 0x04000029 RID: 41
			private static Delegate cb_onLayoutChild_Landroidx_coordinatorlayout_widget_CoordinatorLayout_Landroid_view_View_I;

			// Token: 0x0400002A RID: 42
			private static Delegate cb_onMeasureChild_Landroidx_coordinatorlayout_widget_CoordinatorLayout_Landroid_view_View_IIII;

			// Token: 0x0400002B RID: 43
			private static Delegate cb_onNestedFling_Landroidx_coordinatorlayout_widget_CoordinatorLayout_Landroid_view_View_Landroid_view_View_FFZ;

			// Token: 0x0400002C RID: 44
			private static Delegate cb_onNestedPreFling_Landroidx_coordinatorlayout_widget_CoordinatorLayout_Landroid_view_View_Landroid_view_View_FF;

			// Token: 0x0400002D RID: 45
			private static Delegate cb_onNestedPreScroll_Landroidx_coordinatorlayout_widget_CoordinatorLayout_Landroid_view_View_Landroid_view_View_IIarrayI;

			// Token: 0x0400002E RID: 46
			private static Delegate cb_onNestedPreScroll_Landroidx_coordinatorlayout_widget_CoordinatorLayout_Landroid_view_View_Landroid_view_View_IIarrayII;

			// Token: 0x0400002F RID: 47
			private static Delegate cb_onNestedScroll_Landroidx_coordinatorlayout_widget_CoordinatorLayout_Landroid_view_View_Landroid_view_View_IIII;

			// Token: 0x04000030 RID: 48
			private static Delegate cb_onNestedScroll_Landroidx_coordinatorlayout_widget_CoordinatorLayout_Landroid_view_View_Landroid_view_View_IIIII;

			// Token: 0x04000031 RID: 49
			private static Delegate cb_onNestedScroll_Landroidx_coordinatorlayout_widget_CoordinatorLayout_Landroid_view_View_Landroid_view_View_IIIIIarrayI;

			// Token: 0x04000032 RID: 50
			private static Delegate cb_onNestedScrollAccepted_Landroidx_coordinatorlayout_widget_CoordinatorLayout_Landroid_view_View_Landroid_view_View_Landroid_view_View_I;

			// Token: 0x04000033 RID: 51
			private static Delegate cb_onNestedScrollAccepted_Landroidx_coordinatorlayout_widget_CoordinatorLayout_Landroid_view_View_Landroid_view_View_Landroid_view_View_II;

			// Token: 0x04000034 RID: 52
			private static Delegate cb_onRequestChildRectangleOnScreen_Landroidx_coordinatorlayout_widget_CoordinatorLayout_Landroid_view_View_Landroid_graphics_Rect_Z;

			// Token: 0x04000035 RID: 53
			private static Delegate cb_onRestoreInstanceState_Landroidx_coordinatorlayout_widget_CoordinatorLayout_Landroid_view_View_Landroid_os_Parcelable_;

			// Token: 0x04000036 RID: 54
			private static Delegate cb_onSaveInstanceState_Landroidx_coordinatorlayout_widget_CoordinatorLayout_Landroid_view_View_;

			// Token: 0x04000037 RID: 55
			private static Delegate cb_onStartNestedScroll_Landroidx_coordinatorlayout_widget_CoordinatorLayout_Landroid_view_View_Landroid_view_View_Landroid_view_View_I;

			// Token: 0x04000038 RID: 56
			private static Delegate cb_onStartNestedScroll_Landroidx_coordinatorlayout_widget_CoordinatorLayout_Landroid_view_View_Landroid_view_View_Landroid_view_View_II;

			// Token: 0x04000039 RID: 57
			private static Delegate cb_onStopNestedScroll_Landroidx_coordinatorlayout_widget_CoordinatorLayout_Landroid_view_View_Landroid_view_View_;

			// Token: 0x0400003A RID: 58
			private static Delegate cb_onStopNestedScroll_Landroidx_coordinatorlayout_widget_CoordinatorLayout_Landroid_view_View_Landroid_view_View_I;

			// Token: 0x0400003B RID: 59
			private static Delegate cb_onTouchEvent_Landroidx_coordinatorlayout_widget_CoordinatorLayout_Landroid_view_View_Landroid_view_MotionEvent_;
		}

		// Token: 0x0200002E RID: 46
		[Register("androidx/coordinatorlayout/widget/CoordinatorLayout$Behavior", DoNotGenerateAcw = true)]
		internal class BehaviorInvoker : CoordinatorLayout.Behavior
		{
			// Token: 0x06000154 RID: 340 RVA: 0x00005C3B File Offset: 0x00003E3B
			public BehaviorInvoker(IntPtr handle, JniHandleOwnership transfer) : base(handle, transfer)
			{
			}

			// Token: 0x1700000F RID: 15
			// (get) Token: 0x06000155 RID: 341 RVA: 0x00005C45 File Offset: 0x00003E45
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return CoordinatorLayout.BehaviorInvoker._members;
				}
			}

			// Token: 0x17000010 RID: 16
			// (get) Token: 0x06000156 RID: 342 RVA: 0x00005C4C File Offset: 0x00003E4C
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return CoordinatorLayout.BehaviorInvoker._members.ManagedPeerType;
				}
			}

			// Token: 0x0400003C RID: 60
			private static readonly JniPeerMembers _members = new XAPeerMembers("androidx/coordinatorlayout/widget/CoordinatorLayout$Behavior", typeof(CoordinatorLayout.BehaviorInvoker));
		}

		// Token: 0x0200002F RID: 47
		[Register("androidx/coordinatorlayout/widget/CoordinatorLayout$LayoutParams", DoNotGenerateAcw = true)]
		public new class LayoutParams : ViewGroup.MarginLayoutParams
		{
			// Token: 0x17000011 RID: 17
			// (get) Token: 0x06000158 RID: 344 RVA: 0x00005C73 File Offset: 0x00003E73
			// (set) Token: 0x06000159 RID: 345 RVA: 0x00005C8A File Offset: 0x00003E8A
			[Register("anchorGravity")]
			public int AnchorGravity
			{
				get
				{
					return CoordinatorLayout.LayoutParams._members.InstanceFields.GetInt32Value("anchorGravity.I", this);
				}
				set
				{
					CoordinatorLayout.LayoutParams._members.InstanceFields.SetValue("anchorGravity.I", this, value);
				}
			}

			// Token: 0x17000012 RID: 18
			// (get) Token: 0x0600015A RID: 346 RVA: 0x00005CA2 File Offset: 0x00003EA2
			// (set) Token: 0x0600015B RID: 347 RVA: 0x00005CB9 File Offset: 0x00003EB9
			[Register("dodgeInsetEdges")]
			public int DodgeInsetEdges
			{
				get
				{
					return CoordinatorLayout.LayoutParams._members.InstanceFields.GetInt32Value("dodgeInsetEdges.I", this);
				}
				set
				{
					CoordinatorLayout.LayoutParams._members.InstanceFields.SetValue("dodgeInsetEdges.I", this, value);
				}
			}

			// Token: 0x17000013 RID: 19
			// (get) Token: 0x0600015C RID: 348 RVA: 0x00005CD1 File Offset: 0x00003ED1
			// (set) Token: 0x0600015D RID: 349 RVA: 0x00005CE8 File Offset: 0x00003EE8
			[Register("gravity")]
			public int Gravity
			{
				get
				{
					return CoordinatorLayout.LayoutParams._members.InstanceFields.GetInt32Value("gravity.I", this);
				}
				set
				{
					CoordinatorLayout.LayoutParams._members.InstanceFields.SetValue("gravity.I", this, value);
				}
			}

			// Token: 0x17000014 RID: 20
			// (get) Token: 0x0600015E RID: 350 RVA: 0x00005D00 File Offset: 0x00003F00
			// (set) Token: 0x0600015F RID: 351 RVA: 0x00005D17 File Offset: 0x00003F17
			[Register("insetEdge")]
			public int InsetEdge
			{
				get
				{
					return CoordinatorLayout.LayoutParams._members.InstanceFields.GetInt32Value("insetEdge.I", this);
				}
				set
				{
					CoordinatorLayout.LayoutParams._members.InstanceFields.SetValue("insetEdge.I", this, value);
				}
			}

			// Token: 0x17000015 RID: 21
			// (get) Token: 0x06000160 RID: 352 RVA: 0x00005D2F File Offset: 0x00003F2F
			// (set) Token: 0x06000161 RID: 353 RVA: 0x00005D46 File Offset: 0x00003F46
			[Register("keyline")]
			public int Keyline
			{
				get
				{
					return CoordinatorLayout.LayoutParams._members.InstanceFields.GetInt32Value("keyline.I", this);
				}
				set
				{
					CoordinatorLayout.LayoutParams._members.InstanceFields.SetValue("keyline.I", this, value);
				}
			}

			// Token: 0x17000016 RID: 22
			// (get) Token: 0x06000162 RID: 354 RVA: 0x00005D60 File Offset: 0x00003F60
			internal static IntPtr class_ref
			{
				get
				{
					return CoordinatorLayout.LayoutParams._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x17000017 RID: 23
			// (get) Token: 0x06000163 RID: 355 RVA: 0x00005D84 File Offset: 0x00003F84
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return CoordinatorLayout.LayoutParams._members;
				}
			}

			// Token: 0x17000018 RID: 24
			// (get) Token: 0x06000164 RID: 356 RVA: 0x00005D8C File Offset: 0x00003F8C
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return CoordinatorLayout.LayoutParams._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x17000019 RID: 25
			// (get) Token: 0x06000165 RID: 357 RVA: 0x00005DB0 File Offset: 0x00003FB0
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return CoordinatorLayout.LayoutParams._members.ManagedPeerType;
				}
			}

			// Token: 0x06000166 RID: 358 RVA: 0x00005DBC File Offset: 0x00003FBC
			protected LayoutParams(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
			{
			}

			// Token: 0x06000167 RID: 359 RVA: 0x00005DC8 File Offset: 0x00003FC8
			[Register(".ctor", "(Landroid/view/ViewGroup$LayoutParams;)V", "")]
			public unsafe LayoutParams(ViewGroup.LayoutParams p) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (base.Handle != IntPtr.Zero)
				{
					return;
				}
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((p == null) ? IntPtr.Zero : p.Handle);
					base.SetHandle(CoordinatorLayout.LayoutParams._members.InstanceMethods.StartCreateInstance("(Landroid/view/ViewGroup$LayoutParams;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
					CoordinatorLayout.LayoutParams._members.InstanceMethods.FinishCreateInstance("(Landroid/view/ViewGroup$LayoutParams;)V", this, ptr);
				}
				finally
				{
					GC.KeepAlive(p);
				}
			}

			// Token: 0x06000168 RID: 360 RVA: 0x00005E78 File Offset: 0x00004078
			[Register(".ctor", "(Landroid/view/ViewGroup$MarginLayoutParams;)V", "")]
			public unsafe LayoutParams(ViewGroup.MarginLayoutParams p) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (base.Handle != IntPtr.Zero)
				{
					return;
				}
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((p == null) ? IntPtr.Zero : p.Handle);
					base.SetHandle(CoordinatorLayout.LayoutParams._members.InstanceMethods.StartCreateInstance("(Landroid/view/ViewGroup$MarginLayoutParams;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
					CoordinatorLayout.LayoutParams._members.InstanceMethods.FinishCreateInstance("(Landroid/view/ViewGroup$MarginLayoutParams;)V", this, ptr);
				}
				finally
				{
					GC.KeepAlive(p);
				}
			}

			// Token: 0x06000169 RID: 361 RVA: 0x00005F28 File Offset: 0x00004128
			[Register(".ctor", "(Landroidx/coordinatorlayout/widget/CoordinatorLayout$LayoutParams;)V", "")]
			public unsafe LayoutParams(CoordinatorLayout.LayoutParams p) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (base.Handle != IntPtr.Zero)
				{
					return;
				}
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((p == null) ? IntPtr.Zero : p.Handle);
					base.SetHandle(CoordinatorLayout.LayoutParams._members.InstanceMethods.StartCreateInstance("(Landroidx/coordinatorlayout/widget/CoordinatorLayout$LayoutParams;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
					CoordinatorLayout.LayoutParams._members.InstanceMethods.FinishCreateInstance("(Landroidx/coordinatorlayout/widget/CoordinatorLayout$LayoutParams;)V", this, ptr);
				}
				finally
				{
					GC.KeepAlive(p);
				}
			}

			// Token: 0x0600016A RID: 362 RVA: 0x00005FD8 File Offset: 0x000041D8
			[Register(".ctor", "(II)V", "")]
			public unsafe LayoutParams(int width, int height) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (base.Handle != IntPtr.Zero)
				{
					return;
				}
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(width);
				ptr[1] = new JniArgumentValue(height);
				base.SetHandle(CoordinatorLayout.LayoutParams._members.InstanceMethods.StartCreateInstance("(II)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				CoordinatorLayout.LayoutParams._members.InstanceMethods.FinishCreateInstance("(II)V", this, ptr);
			}

			// Token: 0x0600016B RID: 363 RVA: 0x0000606F File Offset: 0x0000426F
			private static Delegate GetGetAnchorIdHandler()
			{
				if (CoordinatorLayout.LayoutParams.cb_getAnchorId == null)
				{
					CoordinatorLayout.LayoutParams.cb_getAnchorId = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(CoordinatorLayout.LayoutParams.n_GetAnchorId));
				}
				return CoordinatorLayout.LayoutParams.cb_getAnchorId;
			}

			// Token: 0x0600016C RID: 364 RVA: 0x00006093 File Offset: 0x00004293
			private static int n_GetAnchorId(IntPtr jnienv, IntPtr native__this)
			{
				return Java.Lang.Object.GetObject<CoordinatorLayout.LayoutParams>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).AnchorId;
			}

			// Token: 0x0600016D RID: 365 RVA: 0x000060A2 File Offset: 0x000042A2
			private static Delegate GetSetAnchorId_IHandler()
			{
				if (CoordinatorLayout.LayoutParams.cb_setAnchorId_I == null)
				{
					CoordinatorLayout.LayoutParams.cb_setAnchorId_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_V(CoordinatorLayout.LayoutParams.n_SetAnchorId_I));
				}
				return CoordinatorLayout.LayoutParams.cb_setAnchorId_I;
			}

			// Token: 0x0600016E RID: 366 RVA: 0x000060C6 File Offset: 0x000042C6
			private static void n_SetAnchorId_I(IntPtr jnienv, IntPtr native__this, int id)
			{
				Java.Lang.Object.GetObject<CoordinatorLayout.LayoutParams>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).AnchorId = id;
			}

			// Token: 0x1700001A RID: 26
			// (get) Token: 0x0600016F RID: 367 RVA: 0x000060D6 File Offset: 0x000042D6
			// (set) Token: 0x06000170 RID: 368 RVA: 0x000060F0 File Offset: 0x000042F0
			public unsafe virtual int AnchorId
			{
				[Register("getAnchorId", "()I", "GetGetAnchorIdHandler")]
				get
				{
					return CoordinatorLayout.LayoutParams._members.InstanceMethods.InvokeVirtualInt32Method("getAnchorId.()I", this, null);
				}
				[Register("setAnchorId", "(I)V", "GetSetAnchorId_IHandler")]
				set
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue(value);
					CoordinatorLayout.LayoutParams._members.InstanceMethods.InvokeVirtualVoidMethod("setAnchorId.(I)V", this, ptr);
				}
			}

			// Token: 0x06000171 RID: 369 RVA: 0x0000612B File Offset: 0x0000432B
			private static Delegate GetGetBehaviorHandler()
			{
				if (CoordinatorLayout.LayoutParams.cb_getBehavior == null)
				{
					CoordinatorLayout.LayoutParams.cb_getBehavior = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(CoordinatorLayout.LayoutParams.n_GetBehavior));
				}
				return CoordinatorLayout.LayoutParams.cb_getBehavior;
			}

			// Token: 0x06000172 RID: 370 RVA: 0x0000614F File Offset: 0x0000434F
			private static IntPtr n_GetBehavior(IntPtr jnienv, IntPtr native__this)
			{
				return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<CoordinatorLayout.LayoutParams>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Behavior);
			}

			// Token: 0x06000173 RID: 371 RVA: 0x00006163 File Offset: 0x00004363
			private static Delegate GetSetBehavior_Landroidx_coordinatorlayout_widget_CoordinatorLayout_Behavior_Handler()
			{
				if (CoordinatorLayout.LayoutParams.cb_setBehavior_Landroidx_coordinatorlayout_widget_CoordinatorLayout_Behavior_ == null)
				{
					CoordinatorLayout.LayoutParams.cb_setBehavior_Landroidx_coordinatorlayout_widget_CoordinatorLayout_Behavior_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(CoordinatorLayout.LayoutParams.n_SetBehavior_Landroidx_coordinatorlayout_widget_CoordinatorLayout_Behavior_));
				}
				return CoordinatorLayout.LayoutParams.cb_setBehavior_Landroidx_coordinatorlayout_widget_CoordinatorLayout_Behavior_;
			}

			// Token: 0x06000174 RID: 372 RVA: 0x00006188 File Offset: 0x00004388
			private static void n_SetBehavior_Landroidx_coordinatorlayout_widget_CoordinatorLayout_Behavior_(IntPtr jnienv, IntPtr native__this, IntPtr native_behavior)
			{
				CoordinatorLayout.LayoutParams @object = Java.Lang.Object.GetObject<CoordinatorLayout.LayoutParams>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				CoordinatorLayout.Behavior object2 = Java.Lang.Object.GetObject<CoordinatorLayout.Behavior>(native_behavior, JniHandleOwnership.DoNotTransfer);
				@object.Behavior = object2;
			}

			// Token: 0x1700001B RID: 27
			// (get) Token: 0x06000175 RID: 373 RVA: 0x000061AC File Offset: 0x000043AC
			// (set) Token: 0x06000176 RID: 374 RVA: 0x000061E0 File Offset: 0x000043E0
			public unsafe virtual CoordinatorLayout.Behavior Behavior
			{
				[Register("getBehavior", "()Landroidx/coordinatorlayout/widget/CoordinatorLayout$Behavior;", "GetGetBehaviorHandler")]
				get
				{
					return Java.Lang.Object.GetObject<CoordinatorLayout.Behavior>(CoordinatorLayout.LayoutParams._members.InstanceMethods.InvokeVirtualObjectMethod("getBehavior.()Landroidx/coordinatorlayout/widget/CoordinatorLayout$Behavior;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
				}
				[Register("setBehavior", "(Landroidx/coordinatorlayout/widget/CoordinatorLayout$Behavior;)V", "GetSetBehavior_Landroidx_coordinatorlayout_widget_CoordinatorLayout_Behavior_Handler")]
				set
				{
					try
					{
						JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
						*ptr = new JniArgumentValue((value == null) ? IntPtr.Zero : value.Handle);
						CoordinatorLayout.LayoutParams._members.InstanceMethods.InvokeVirtualVoidMethod("setBehavior.(Landroidx/coordinatorlayout/widget/CoordinatorLayout$Behavior;)V", this, ptr);
					}
					finally
					{
						GC.KeepAlive(value);
					}
				}
			}

			// Token: 0x0400003D RID: 61
			private static readonly JniPeerMembers _members = new XAPeerMembers("androidx/coordinatorlayout/widget/CoordinatorLayout$LayoutParams", typeof(CoordinatorLayout.LayoutParams));

			// Token: 0x0400003E RID: 62
			private static Delegate cb_getAnchorId;

			// Token: 0x0400003F RID: 63
			private static Delegate cb_setAnchorId_I;

			// Token: 0x04000040 RID: 64
			private static Delegate cb_getBehavior;

			// Token: 0x04000041 RID: 65
			private static Delegate cb_setBehavior_Landroidx_coordinatorlayout_widget_CoordinatorLayout_Behavior_;
		}
	}
}
