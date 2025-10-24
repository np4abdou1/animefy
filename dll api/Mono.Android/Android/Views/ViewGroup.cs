using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Content;
using Android.Graphics;
using Android.OS;
using Android.Runtime;
using Android.Util;
using Android.Views.Accessibility;
using Android.Window;
using Java.Interop;
using Java.Lang;

namespace Android.Views
{
	// Token: 0x02000158 RID: 344
	[Register("android/view/ViewGroup", DoNotGenerateAcw = true)]
	public abstract class ViewGroup : View, IViewManager, IJavaObject, IDisposable, IJavaPeerable, IViewParent
	{
		// Token: 0x1700024C RID: 588
		// (get) Token: 0x06000BFC RID: 3068 RVA: 0x0001E2A2 File Offset: 0x0001C4A2
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return ViewGroup._members;
			}
		}

		// Token: 0x1700024D RID: 589
		// (get) Token: 0x06000BFD RID: 3069 RVA: 0x0001E2AC File Offset: 0x0001C4AC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return ViewGroup._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700024E RID: 590
		// (get) Token: 0x06000BFE RID: 3070 RVA: 0x0001E2D0 File Offset: 0x0001C4D0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return ViewGroup._members.ManagedPeerType;
			}
		}

		// Token: 0x06000BFF RID: 3071 RVA: 0x00008888 File Offset: 0x00006A88
		protected ViewGroup(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000C00 RID: 3072 RVA: 0x0001E2DC File Offset: 0x0001C4DC
		public unsafe ViewGroup(Context context, IAttributeSet attrs) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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
				base.SetHandle(ViewGroup._members.InstanceMethods.StartCreateInstance("(Landroid/content/Context;Landroid/util/AttributeSet;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				ViewGroup._members.InstanceMethods.FinishCreateInstance("(Landroid/content/Context;Landroid/util/AttributeSet;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(context);
				GC.KeepAlive(attrs);
			}
		}

		// Token: 0x06000C01 RID: 3073 RVA: 0x0001E3B8 File Offset: 0x0001C5B8
		public unsafe ViewGroup(Context context, IAttributeSet attrs, int defStyleAttr) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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
				base.SetHandle(ViewGroup._members.InstanceMethods.StartCreateInstance("(Landroid/content/Context;Landroid/util/AttributeSet;I)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				ViewGroup._members.InstanceMethods.FinishCreateInstance("(Landroid/content/Context;Landroid/util/AttributeSet;I)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(context);
				GC.KeepAlive(attrs);
			}
		}

		// Token: 0x06000C02 RID: 3074 RVA: 0x0001E4A8 File Offset: 0x0001C6A8
		private static Delegate GetGetFocusedChildHandler()
		{
			if (ViewGroup.cb_getFocusedChild == null)
			{
				ViewGroup.cb_getFocusedChild = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(ViewGroup.n_GetFocusedChild));
			}
			return ViewGroup.cb_getFocusedChild;
		}

		// Token: 0x06000C03 RID: 3075 RVA: 0x0001E4CC File Offset: 0x0001C6CC
		private static IntPtr n_GetFocusedChild(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<ViewGroup>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).FocusedChild);
		}

		// Token: 0x1700024F RID: 591
		// (get) Token: 0x06000C04 RID: 3076 RVA: 0x0001E4E0 File Offset: 0x0001C6E0
		public virtual View FocusedChild
		{
			get
			{
				return Java.Lang.Object.GetObject<View>(ViewGroup._members.InstanceMethods.InvokeVirtualObjectMethod("getFocusedChild.()Landroid/view/View;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06000C05 RID: 3077 RVA: 0x0001E512 File Offset: 0x0001C712
		private static Delegate GetIsLayoutSuppressedHandler()
		{
			if (ViewGroup.cb_isLayoutSuppressed == null)
			{
				ViewGroup.cb_isLayoutSuppressed = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(ViewGroup.n_IsLayoutSuppressed));
			}
			return ViewGroup.cb_isLayoutSuppressed;
		}

		// Token: 0x06000C06 RID: 3078 RVA: 0x0001E536 File Offset: 0x0001C736
		private static bool n_IsLayoutSuppressed(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<ViewGroup>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsLayoutSuppressed;
		}

		// Token: 0x17000250 RID: 592
		// (get) Token: 0x06000C07 RID: 3079 RVA: 0x0001E545 File Offset: 0x0001C745
		public virtual bool IsLayoutSuppressed
		{
			get
			{
				return ViewGroup._members.InstanceMethods.InvokeVirtualBooleanMethod("isLayoutSuppressed.()Z", this, null);
			}
		}

		// Token: 0x06000C08 RID: 3080 RVA: 0x0001E55E File Offset: 0x0001C75E
		private static Delegate GetGetNestedScrollAxesHandler()
		{
			if (ViewGroup.cb_getNestedScrollAxes == null)
			{
				ViewGroup.cb_getNestedScrollAxes = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(ViewGroup.n_GetNestedScrollAxes));
			}
			return ViewGroup.cb_getNestedScrollAxes;
		}

		// Token: 0x06000C09 RID: 3081 RVA: 0x0001E582 File Offset: 0x0001C782
		private static int n_GetNestedScrollAxes(IntPtr jnienv, IntPtr native__this)
		{
			return (int)Java.Lang.Object.GetObject<ViewGroup>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).NestedScrollAxes;
		}

		// Token: 0x17000251 RID: 593
		// (get) Token: 0x06000C0A RID: 3082 RVA: 0x0001E591 File Offset: 0x0001C791
		public virtual ScrollAxis NestedScrollAxes
		{
			get
			{
				return (ScrollAxis)ViewGroup._members.InstanceMethods.InvokeVirtualInt32Method("getNestedScrollAxes.()I", this, null);
			}
		}

		// Token: 0x06000C0B RID: 3083 RVA: 0x0001E5AA File Offset: 0x0001C7AA
		private static Delegate GetAddView_Landroid_view_View_Handler()
		{
			if (ViewGroup.cb_addView_Landroid_view_View_ == null)
			{
				ViewGroup.cb_addView_Landroid_view_View_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(ViewGroup.n_AddView_Landroid_view_View_));
			}
			return ViewGroup.cb_addView_Landroid_view_View_;
		}

		// Token: 0x06000C0C RID: 3084 RVA: 0x0001E5D0 File Offset: 0x0001C7D0
		private static void n_AddView_Landroid_view_View_(IntPtr jnienv, IntPtr native__this, IntPtr native_child)
		{
			ViewGroup @object = Java.Lang.Object.GetObject<ViewGroup>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			View object2 = Java.Lang.Object.GetObject<View>(native_child, JniHandleOwnership.DoNotTransfer);
			@object.AddView(object2);
		}

		// Token: 0x06000C0D RID: 3085 RVA: 0x0001E5F4 File Offset: 0x0001C7F4
		public unsafe virtual void AddView(View child)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((child == null) ? IntPtr.Zero : child.Handle);
				ViewGroup._members.InstanceMethods.InvokeVirtualVoidMethod("addView.(Landroid/view/View;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(child);
			}
		}

		// Token: 0x06000C0E RID: 3086 RVA: 0x0001E658 File Offset: 0x0001C858
		private static Delegate GetAddView_Landroid_view_View_Landroid_view_ViewGroup_LayoutParams_Handler()
		{
			if (ViewGroup.cb_addView_Landroid_view_View_Landroid_view_ViewGroup_LayoutParams_ == null)
			{
				ViewGroup.cb_addView_Landroid_view_View_Landroid_view_ViewGroup_LayoutParams_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_V(ViewGroup.n_AddView_Landroid_view_View_Landroid_view_ViewGroup_LayoutParams_));
			}
			return ViewGroup.cb_addView_Landroid_view_View_Landroid_view_ViewGroup_LayoutParams_;
		}

		// Token: 0x06000C0F RID: 3087 RVA: 0x0001E67C File Offset: 0x0001C87C
		private static void n_AddView_Landroid_view_View_Landroid_view_ViewGroup_LayoutParams_(IntPtr jnienv, IntPtr native__this, IntPtr native_child, IntPtr native__params)
		{
			ViewGroup @object = Java.Lang.Object.GetObject<ViewGroup>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			View object2 = Java.Lang.Object.GetObject<View>(native_child, JniHandleOwnership.DoNotTransfer);
			ViewGroup.LayoutParams object3 = Java.Lang.Object.GetObject<ViewGroup.LayoutParams>(native__params, JniHandleOwnership.DoNotTransfer);
			@object.AddView(object2, object3);
		}

		// Token: 0x06000C10 RID: 3088 RVA: 0x0001E6A8 File Offset: 0x0001C8A8
		public unsafe virtual void AddView(View child, ViewGroup.LayoutParams @params)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((child == null) ? IntPtr.Zero : child.Handle);
				ptr[1] = new JniArgumentValue((@params == null) ? IntPtr.Zero : @params.Handle);
				ViewGroup._members.InstanceMethods.InvokeVirtualVoidMethod("addView.(Landroid/view/View;Landroid/view/ViewGroup$LayoutParams;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(child);
				GC.KeepAlive(@params);
			}
		}

		// Token: 0x06000C11 RID: 3089 RVA: 0x0001E734 File Offset: 0x0001C934
		private static Delegate GetBringChildToFront_Landroid_view_View_Handler()
		{
			if (ViewGroup.cb_bringChildToFront_Landroid_view_View_ == null)
			{
				ViewGroup.cb_bringChildToFront_Landroid_view_View_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(ViewGroup.n_BringChildToFront_Landroid_view_View_));
			}
			return ViewGroup.cb_bringChildToFront_Landroid_view_View_;
		}

		// Token: 0x06000C12 RID: 3090 RVA: 0x0001E758 File Offset: 0x0001C958
		private static void n_BringChildToFront_Landroid_view_View_(IntPtr jnienv, IntPtr native__this, IntPtr native_child)
		{
			ViewGroup @object = Java.Lang.Object.GetObject<ViewGroup>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			View object2 = Java.Lang.Object.GetObject<View>(native_child, JniHandleOwnership.DoNotTransfer);
			@object.BringChildToFront(object2);
		}

		// Token: 0x06000C13 RID: 3091 RVA: 0x0001E77C File Offset: 0x0001C97C
		public unsafe virtual void BringChildToFront(View child)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((child == null) ? IntPtr.Zero : child.Handle);
				ViewGroup._members.InstanceMethods.InvokeVirtualVoidMethod("bringChildToFront.(Landroid/view/View;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(child);
			}
		}

		// Token: 0x06000C14 RID: 3092 RVA: 0x0001E7E0 File Offset: 0x0001C9E0
		private static Delegate GetChildDrawableStateChanged_Landroid_view_View_Handler()
		{
			if (ViewGroup.cb_childDrawableStateChanged_Landroid_view_View_ == null)
			{
				ViewGroup.cb_childDrawableStateChanged_Landroid_view_View_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(ViewGroup.n_ChildDrawableStateChanged_Landroid_view_View_));
			}
			return ViewGroup.cb_childDrawableStateChanged_Landroid_view_View_;
		}

		// Token: 0x06000C15 RID: 3093 RVA: 0x0001E804 File Offset: 0x0001CA04
		private static void n_ChildDrawableStateChanged_Landroid_view_View_(IntPtr jnienv, IntPtr native__this, IntPtr native_child)
		{
			ViewGroup @object = Java.Lang.Object.GetObject<ViewGroup>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			View object2 = Java.Lang.Object.GetObject<View>(native_child, JniHandleOwnership.DoNotTransfer);
			@object.ChildDrawableStateChanged(object2);
		}

		// Token: 0x06000C16 RID: 3094 RVA: 0x0001E828 File Offset: 0x0001CA28
		public unsafe virtual void ChildDrawableStateChanged(View child)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((child == null) ? IntPtr.Zero : child.Handle);
				ViewGroup._members.InstanceMethods.InvokeVirtualVoidMethod("childDrawableStateChanged.(Landroid/view/View;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(child);
			}
		}

		// Token: 0x06000C17 RID: 3095 RVA: 0x0001E88C File Offset: 0x0001CA8C
		private static Delegate GetChildHasTransientStateChanged_Landroid_view_View_ZHandler()
		{
			if (ViewGroup.cb_childHasTransientStateChanged_Landroid_view_View_Z == null)
			{
				ViewGroup.cb_childHasTransientStateChanged_Landroid_view_View_Z = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLZ_V(ViewGroup.n_ChildHasTransientStateChanged_Landroid_view_View_Z));
			}
			return ViewGroup.cb_childHasTransientStateChanged_Landroid_view_View_Z;
		}

		// Token: 0x06000C18 RID: 3096 RVA: 0x0001E8B0 File Offset: 0x0001CAB0
		private static void n_ChildHasTransientStateChanged_Landroid_view_View_Z(IntPtr jnienv, IntPtr native__this, IntPtr native_child, bool childHasTransientState)
		{
			ViewGroup @object = Java.Lang.Object.GetObject<ViewGroup>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			View object2 = Java.Lang.Object.GetObject<View>(native_child, JniHandleOwnership.DoNotTransfer);
			@object.ChildHasTransientStateChanged(object2, childHasTransientState);
		}

		// Token: 0x06000C19 RID: 3097 RVA: 0x0001E8D4 File Offset: 0x0001CAD4
		public unsafe virtual void ChildHasTransientStateChanged(View child, bool childHasTransientState)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((child == null) ? IntPtr.Zero : child.Handle);
				ptr[1] = new JniArgumentValue(childHasTransientState);
				ViewGroup._members.InstanceMethods.InvokeVirtualVoidMethod("childHasTransientStateChanged.(Landroid/view/View;Z)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(child);
			}
		}

		// Token: 0x06000C1A RID: 3098 RVA: 0x0001E94C File Offset: 0x0001CB4C
		private static Delegate GetClearChildFocus_Landroid_view_View_Handler()
		{
			if (ViewGroup.cb_clearChildFocus_Landroid_view_View_ == null)
			{
				ViewGroup.cb_clearChildFocus_Landroid_view_View_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(ViewGroup.n_ClearChildFocus_Landroid_view_View_));
			}
			return ViewGroup.cb_clearChildFocus_Landroid_view_View_;
		}

		// Token: 0x06000C1B RID: 3099 RVA: 0x0001E970 File Offset: 0x0001CB70
		private static void n_ClearChildFocus_Landroid_view_View_(IntPtr jnienv, IntPtr native__this, IntPtr native_child)
		{
			ViewGroup @object = Java.Lang.Object.GetObject<ViewGroup>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			View object2 = Java.Lang.Object.GetObject<View>(native_child, JniHandleOwnership.DoNotTransfer);
			@object.ClearChildFocus(object2);
		}

		// Token: 0x06000C1C RID: 3100 RVA: 0x0001E994 File Offset: 0x0001CB94
		public unsafe virtual void ClearChildFocus(View child)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((child == null) ? IntPtr.Zero : child.Handle);
				ViewGroup._members.InstanceMethods.InvokeVirtualVoidMethod("clearChildFocus.(Landroid/view/View;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(child);
			}
		}

		// Token: 0x06000C1D RID: 3101 RVA: 0x0001E9F8 File Offset: 0x0001CBF8
		private static Delegate GetDrawChild_Landroid_graphics_Canvas_Landroid_view_View_JHandler()
		{
			if (ViewGroup.cb_drawChild_Landroid_graphics_Canvas_Landroid_view_View_J == null)
			{
				ViewGroup.cb_drawChild_Landroid_graphics_Canvas_Landroid_view_View_J = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLLJ_Z(ViewGroup.n_DrawChild_Landroid_graphics_Canvas_Landroid_view_View_J));
			}
			return ViewGroup.cb_drawChild_Landroid_graphics_Canvas_Landroid_view_View_J;
		}

		// Token: 0x06000C1E RID: 3102 RVA: 0x0001EA1C File Offset: 0x0001CC1C
		private static bool n_DrawChild_Landroid_graphics_Canvas_Landroid_view_View_J(IntPtr jnienv, IntPtr native__this, IntPtr native_canvas, IntPtr native_child, long drawingTime)
		{
			ViewGroup @object = Java.Lang.Object.GetObject<ViewGroup>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Canvas object2 = Java.Lang.Object.GetObject<Canvas>(native_canvas, JniHandleOwnership.DoNotTransfer);
			View object3 = Java.Lang.Object.GetObject<View>(native_child, JniHandleOwnership.DoNotTransfer);
			return @object.DrawChild(object2, object3, drawingTime);
		}

		// Token: 0x06000C1F RID: 3103 RVA: 0x0001EA4C File Offset: 0x0001CC4C
		protected unsafe virtual bool DrawChild(Canvas canvas, View child, long drawingTime)
		{
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((canvas == null) ? IntPtr.Zero : canvas.Handle);
				ptr[1] = new JniArgumentValue((child == null) ? IntPtr.Zero : child.Handle);
				ptr[2] = new JniArgumentValue(drawingTime);
				result = ViewGroup._members.InstanceMethods.InvokeVirtualBooleanMethod("drawChild.(Landroid/graphics/Canvas;Landroid/view/View;J)Z", this, ptr);
			}
			finally
			{
				GC.KeepAlive(canvas);
				GC.KeepAlive(child);
			}
			return result;
		}

		// Token: 0x06000C20 RID: 3104 RVA: 0x0001EAF0 File Offset: 0x0001CCF0
		private static Delegate GetFindOnBackInvokedDispatcherForChild_Landroid_view_View_Landroid_view_View_Handler()
		{
			if (ViewGroup.cb_findOnBackInvokedDispatcherForChild_Landroid_view_View_Landroid_view_View_ == null)
			{
				ViewGroup.cb_findOnBackInvokedDispatcherForChild_Landroid_view_View_Landroid_view_View_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_L(ViewGroup.n_FindOnBackInvokedDispatcherForChild_Landroid_view_View_Landroid_view_View_));
			}
			return ViewGroup.cb_findOnBackInvokedDispatcherForChild_Landroid_view_View_Landroid_view_View_;
		}

		// Token: 0x06000C21 RID: 3105 RVA: 0x0001EB14 File Offset: 0x0001CD14
		private static IntPtr n_FindOnBackInvokedDispatcherForChild_Landroid_view_View_Landroid_view_View_(IntPtr jnienv, IntPtr native__this, IntPtr native_child, IntPtr native_requester)
		{
			ViewGroup @object = Java.Lang.Object.GetObject<ViewGroup>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			View object2 = Java.Lang.Object.GetObject<View>(native_child, JniHandleOwnership.DoNotTransfer);
			View object3 = Java.Lang.Object.GetObject<View>(native_requester, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.FindOnBackInvokedDispatcherForChild(object2, object3));
		}

		// Token: 0x06000C22 RID: 3106 RVA: 0x0001EB48 File Offset: 0x0001CD48
		public unsafe virtual IOnBackInvokedDispatcher FindOnBackInvokedDispatcherForChild(View child, View requester)
		{
			IOnBackInvokedDispatcher @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((child == null) ? IntPtr.Zero : child.Handle);
				ptr[1] = new JniArgumentValue((requester == null) ? IntPtr.Zero : requester.Handle);
				@object = Java.Lang.Object.GetObject<IOnBackInvokedDispatcher>(ViewGroup._members.InstanceMethods.InvokeVirtualObjectMethod("findOnBackInvokedDispatcherForChild.(Landroid/view/View;Landroid/view/View;)Landroid/window/OnBackInvokedDispatcher;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(child);
				GC.KeepAlive(requester);
			}
			return @object;
		}

		// Token: 0x06000C23 RID: 3107 RVA: 0x0001EBE4 File Offset: 0x0001CDE4
		private static Delegate GetFocusableViewAvailable_Landroid_view_View_Handler()
		{
			if (ViewGroup.cb_focusableViewAvailable_Landroid_view_View_ == null)
			{
				ViewGroup.cb_focusableViewAvailable_Landroid_view_View_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(ViewGroup.n_FocusableViewAvailable_Landroid_view_View_));
			}
			return ViewGroup.cb_focusableViewAvailable_Landroid_view_View_;
		}

		// Token: 0x06000C24 RID: 3108 RVA: 0x0001EC08 File Offset: 0x0001CE08
		private static void n_FocusableViewAvailable_Landroid_view_View_(IntPtr jnienv, IntPtr native__this, IntPtr native_v)
		{
			ViewGroup @object = Java.Lang.Object.GetObject<ViewGroup>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			View object2 = Java.Lang.Object.GetObject<View>(native_v, JniHandleOwnership.DoNotTransfer);
			@object.FocusableViewAvailable(object2);
		}

		// Token: 0x06000C25 RID: 3109 RVA: 0x0001EC2C File Offset: 0x0001CE2C
		public unsafe virtual void FocusableViewAvailable(View v)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((v == null) ? IntPtr.Zero : v.Handle);
				ViewGroup._members.InstanceMethods.InvokeVirtualVoidMethod("focusableViewAvailable.(Landroid/view/View;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(v);
			}
		}

		// Token: 0x06000C26 RID: 3110 RVA: 0x0001EC90 File Offset: 0x0001CE90
		private static Delegate GetFocusSearch_Landroid_view_View_IHandler()
		{
			if (ViewGroup.cb_focusSearch_Landroid_view_View_I == null)
			{
				ViewGroup.cb_focusSearch_Landroid_view_View_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLI_L(ViewGroup.n_FocusSearch_Landroid_view_View_I));
			}
			return ViewGroup.cb_focusSearch_Landroid_view_View_I;
		}

		// Token: 0x06000C27 RID: 3111 RVA: 0x0001ECB4 File Offset: 0x0001CEB4
		private static IntPtr n_FocusSearch_Landroid_view_View_I(IntPtr jnienv, IntPtr native__this, IntPtr native_focused, int native_direction)
		{
			ViewGroup @object = Java.Lang.Object.GetObject<ViewGroup>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			View object2 = Java.Lang.Object.GetObject<View>(native_focused, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.FocusSearch(object2, (FocusSearchDirection)native_direction));
		}

		// Token: 0x06000C28 RID: 3112 RVA: 0x0001ECE0 File Offset: 0x0001CEE0
		public unsafe virtual View FocusSearch(View focused, [GeneratedEnum] FocusSearchDirection direction)
		{
			View @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((focused == null) ? IntPtr.Zero : focused.Handle);
				ptr[1] = new JniArgumentValue((int)direction);
				@object = Java.Lang.Object.GetObject<View>(ViewGroup._members.InstanceMethods.InvokeVirtualObjectMethod("focusSearch.(Landroid/view/View;I)Landroid/view/View;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(focused);
			}
			return @object;
		}

		// Token: 0x06000C29 RID: 3113 RVA: 0x0001ED68 File Offset: 0x0001CF68
		private static Delegate GetGetChildAt_IHandler()
		{
			if (ViewGroup.cb_getChildAt_I == null)
			{
				ViewGroup.cb_getChildAt_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_L(ViewGroup.n_GetChildAt_I));
			}
			return ViewGroup.cb_getChildAt_I;
		}

		// Token: 0x06000C2A RID: 3114 RVA: 0x0001ED8C File Offset: 0x0001CF8C
		private static IntPtr n_GetChildAt_I(IntPtr jnienv, IntPtr native__this, int index)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<ViewGroup>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).GetChildAt(index));
		}

		// Token: 0x06000C2B RID: 3115 RVA: 0x0001EDA4 File Offset: 0x0001CFA4
		public unsafe virtual View GetChildAt(int index)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(index);
			return Java.Lang.Object.GetObject<View>(ViewGroup._members.InstanceMethods.InvokeVirtualObjectMethod("getChildAt.(I)Landroid/view/View;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06000C2C RID: 3116 RVA: 0x0001EDED File Offset: 0x0001CFED
		private static Delegate GetGetChildVisibleRect_Landroid_view_View_Landroid_graphics_Rect_Landroid_graphics_Point_Handler()
		{
			if (ViewGroup.cb_getChildVisibleRect_Landroid_view_View_Landroid_graphics_Rect_Landroid_graphics_Point_ == null)
			{
				ViewGroup.cb_getChildVisibleRect_Landroid_view_View_Landroid_graphics_Rect_Landroid_graphics_Point_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLLL_Z(ViewGroup.n_GetChildVisibleRect_Landroid_view_View_Landroid_graphics_Rect_Landroid_graphics_Point_));
			}
			return ViewGroup.cb_getChildVisibleRect_Landroid_view_View_Landroid_graphics_Rect_Landroid_graphics_Point_;
		}

		// Token: 0x06000C2D RID: 3117 RVA: 0x0001EE14 File Offset: 0x0001D014
		private static bool n_GetChildVisibleRect_Landroid_view_View_Landroid_graphics_Rect_Landroid_graphics_Point_(IntPtr jnienv, IntPtr native__this, IntPtr native_child, IntPtr native_r, IntPtr native_offset)
		{
			ViewGroup @object = Java.Lang.Object.GetObject<ViewGroup>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			View object2 = Java.Lang.Object.GetObject<View>(native_child, JniHandleOwnership.DoNotTransfer);
			Rect object3 = Java.Lang.Object.GetObject<Rect>(native_r, JniHandleOwnership.DoNotTransfer);
			Point object4 = Java.Lang.Object.GetObject<Point>(native_offset, JniHandleOwnership.DoNotTransfer);
			return @object.GetChildVisibleRect(object2, object3, object4);
		}

		// Token: 0x06000C2E RID: 3118 RVA: 0x0001EE4C File Offset: 0x0001D04C
		public unsafe virtual bool GetChildVisibleRect(View child, Rect r, Point offset)
		{
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((child == null) ? IntPtr.Zero : child.Handle);
				ptr[1] = new JniArgumentValue((r == null) ? IntPtr.Zero : r.Handle);
				ptr[2] = new JniArgumentValue((offset == null) ? IntPtr.Zero : offset.Handle);
				result = ViewGroup._members.InstanceMethods.InvokeVirtualBooleanMethod("getChildVisibleRect.(Landroid/view/View;Landroid/graphics/Rect;Landroid/graphics/Point;)Z", this, ptr);
			}
			finally
			{
				GC.KeepAlive(child);
				GC.KeepAlive(r);
				GC.KeepAlive(offset);
			}
			return result;
		}

		// Token: 0x06000C2F RID: 3119 RVA: 0x0001EF04 File Offset: 0x0001D104
		public unsafe void InvalidateChild(View child, Rect dirty)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((child == null) ? IntPtr.Zero : child.Handle);
				ptr[1] = new JniArgumentValue((dirty == null) ? IntPtr.Zero : dirty.Handle);
				ViewGroup._members.InstanceMethods.InvokeNonvirtualVoidMethod("invalidateChild.(Landroid/view/View;Landroid/graphics/Rect;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(child);
				GC.KeepAlive(dirty);
			}
		}

		// Token: 0x06000C30 RID: 3120 RVA: 0x0001EF90 File Offset: 0x0001D190
		private static Delegate GetInvalidateChildInParent_arrayILandroid_graphics_Rect_Handler()
		{
			if (ViewGroup.cb_invalidateChildInParent_arrayILandroid_graphics_Rect_ == null)
			{
				ViewGroup.cb_invalidateChildInParent_arrayILandroid_graphics_Rect_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_L(ViewGroup.n_InvalidateChildInParent_arrayILandroid_graphics_Rect_));
			}
			return ViewGroup.cb_invalidateChildInParent_arrayILandroid_graphics_Rect_;
		}

		// Token: 0x06000C31 RID: 3121 RVA: 0x0001EFB4 File Offset: 0x0001D1B4
		private static IntPtr n_InvalidateChildInParent_arrayILandroid_graphics_Rect_(IntPtr jnienv, IntPtr native__this, IntPtr native_location, IntPtr native_dirty)
		{
			ViewGroup @object = Java.Lang.Object.GetObject<ViewGroup>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			int[] array = (int[])JNIEnv.GetArray(native_location, JniHandleOwnership.DoNotTransfer, typeof(int));
			Rect object2 = Java.Lang.Object.GetObject<Rect>(native_dirty, JniHandleOwnership.DoNotTransfer);
			IntPtr result = JNIEnv.ToLocalJniHandle(@object.InvalidateChildInParent(array, object2));
			if (array != null)
			{
				JNIEnv.CopyArray(array, native_location);
			}
			return result;
		}

		// Token: 0x06000C32 RID: 3122 RVA: 0x0001F000 File Offset: 0x0001D200
		public unsafe virtual IViewParent InvalidateChildInParent(int[] location, Rect dirty)
		{
			IntPtr intPtr = JNIEnv.NewArray(location);
			IViewParent @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((dirty == null) ? IntPtr.Zero : dirty.Handle);
				@object = Java.Lang.Object.GetObject<IViewParent>(ViewGroup._members.InstanceMethods.InvokeVirtualObjectMethod("invalidateChildInParent.([ILandroid/graphics/Rect;)Landroid/view/ViewParent;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				if (location != null)
				{
					JNIEnv.CopyArray(intPtr, location);
					JNIEnv.DeleteLocalRef(intPtr);
				}
				GC.KeepAlive(location);
				GC.KeepAlive(dirty);
			}
			return @object;
		}

		// Token: 0x06000C33 RID: 3123 RVA: 0x0001F0A4 File Offset: 0x0001D2A4
		private static Delegate GetNotifySubtreeAccessibilityStateChanged_Landroid_view_View_Landroid_view_View_IHandler()
		{
			if (ViewGroup.cb_notifySubtreeAccessibilityStateChanged_Landroid_view_View_Landroid_view_View_I == null)
			{
				ViewGroup.cb_notifySubtreeAccessibilityStateChanged_Landroid_view_View_Landroid_view_View_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLLI_V(ViewGroup.n_NotifySubtreeAccessibilityStateChanged_Landroid_view_View_Landroid_view_View_I));
			}
			return ViewGroup.cb_notifySubtreeAccessibilityStateChanged_Landroid_view_View_Landroid_view_View_I;
		}

		// Token: 0x06000C34 RID: 3124 RVA: 0x0001F0C8 File Offset: 0x0001D2C8
		private static void n_NotifySubtreeAccessibilityStateChanged_Landroid_view_View_Landroid_view_View_I(IntPtr jnienv, IntPtr native__this, IntPtr native_child, IntPtr native_source, int native_changeType)
		{
			ViewGroup @object = Java.Lang.Object.GetObject<ViewGroup>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			View object2 = Java.Lang.Object.GetObject<View>(native_child, JniHandleOwnership.DoNotTransfer);
			View object3 = Java.Lang.Object.GetObject<View>(native_source, JniHandleOwnership.DoNotTransfer);
			@object.NotifySubtreeAccessibilityStateChanged(object2, object3, (ContentChangeTypes)native_changeType);
		}

		// Token: 0x06000C35 RID: 3125 RVA: 0x0001F0F8 File Offset: 0x0001D2F8
		public unsafe virtual void NotifySubtreeAccessibilityStateChanged(View child, View source, [GeneratedEnum] ContentChangeTypes changeType)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((child == null) ? IntPtr.Zero : child.Handle);
				ptr[1] = new JniArgumentValue((source == null) ? IntPtr.Zero : source.Handle);
				ptr[2] = new JniArgumentValue((int)changeType);
				ViewGroup._members.InstanceMethods.InvokeVirtualVoidMethod("notifySubtreeAccessibilityStateChanged.(Landroid/view/View;Landroid/view/View;I)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(child);
				GC.KeepAlive(source);
			}
		}

		// Token: 0x06000C36 RID: 3126 RVA: 0x0001F19C File Offset: 0x0001D39C
		private static Delegate GetOnDescendantInvalidated_Landroid_view_View_Landroid_view_View_Handler()
		{
			if (ViewGroup.cb_onDescendantInvalidated_Landroid_view_View_Landroid_view_View_ == null)
			{
				ViewGroup.cb_onDescendantInvalidated_Landroid_view_View_Landroid_view_View_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_V(ViewGroup.n_OnDescendantInvalidated_Landroid_view_View_Landroid_view_View_));
			}
			return ViewGroup.cb_onDescendantInvalidated_Landroid_view_View_Landroid_view_View_;
		}

		// Token: 0x06000C37 RID: 3127 RVA: 0x0001F1C0 File Offset: 0x0001D3C0
		private static void n_OnDescendantInvalidated_Landroid_view_View_Landroid_view_View_(IntPtr jnienv, IntPtr native__this, IntPtr native_child, IntPtr native_target)
		{
			ViewGroup @object = Java.Lang.Object.GetObject<ViewGroup>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			View object2 = Java.Lang.Object.GetObject<View>(native_child, JniHandleOwnership.DoNotTransfer);
			View object3 = Java.Lang.Object.GetObject<View>(native_target, JniHandleOwnership.DoNotTransfer);
			@object.OnDescendantInvalidated(object2, object3);
		}

		// Token: 0x06000C38 RID: 3128 RVA: 0x0001F1EC File Offset: 0x0001D3EC
		public unsafe virtual void OnDescendantInvalidated(View child, View target)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((child == null) ? IntPtr.Zero : child.Handle);
				ptr[1] = new JniArgumentValue((target == null) ? IntPtr.Zero : target.Handle);
				ViewGroup._members.InstanceMethods.InvokeVirtualVoidMethod("onDescendantInvalidated.(Landroid/view/View;Landroid/view/View;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(child);
				GC.KeepAlive(target);
			}
		}

		// Token: 0x06000C39 RID: 3129 RVA: 0x0001F278 File Offset: 0x0001D478
		private static Delegate GetOnLayout_ZIIIIHandler()
		{
			if (ViewGroup.cb_onLayout_ZIIII == null)
			{
				ViewGroup.cb_onLayout_ZIIII = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPZIIII_V(ViewGroup.n_OnLayout_ZIIII));
			}
			return ViewGroup.cb_onLayout_ZIIII;
		}

		// Token: 0x06000C3A RID: 3130 RVA: 0x0001F29C File Offset: 0x0001D49C
		private static void n_OnLayout_ZIIII(IntPtr jnienv, IntPtr native__this, bool changed, int l, int t, int r, int b)
		{
			Java.Lang.Object.GetObject<ViewGroup>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).OnLayout(changed, l, t, r, b);
		}

		// Token: 0x06000C3B RID: 3131
		protected new abstract void OnLayout(bool changed, int l, int t, int r, int b);

		// Token: 0x06000C3C RID: 3132 RVA: 0x0001F2B3 File Offset: 0x0001D4B3
		private static Delegate GetOnNestedFling_Landroid_view_View_FFZHandler()
		{
			if (ViewGroup.cb_onNestedFling_Landroid_view_View_FFZ == null)
			{
				ViewGroup.cb_onNestedFling_Landroid_view_View_FFZ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLFFZ_Z(ViewGroup.n_OnNestedFling_Landroid_view_View_FFZ));
			}
			return ViewGroup.cb_onNestedFling_Landroid_view_View_FFZ;
		}

		// Token: 0x06000C3D RID: 3133 RVA: 0x0001F2D8 File Offset: 0x0001D4D8
		private static bool n_OnNestedFling_Landroid_view_View_FFZ(IntPtr jnienv, IntPtr native__this, IntPtr native_target, float velocityX, float velocityY, bool consumed)
		{
			ViewGroup @object = Java.Lang.Object.GetObject<ViewGroup>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			View object2 = Java.Lang.Object.GetObject<View>(native_target, JniHandleOwnership.DoNotTransfer);
			return @object.OnNestedFling(object2, velocityX, velocityY, consumed);
		}

		// Token: 0x06000C3E RID: 3134 RVA: 0x0001F300 File Offset: 0x0001D500
		public unsafe virtual bool OnNestedFling(View target, float velocityX, float velocityY, bool consumed)
		{
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((target == null) ? IntPtr.Zero : target.Handle);
				ptr[1] = new JniArgumentValue(velocityX);
				ptr[2] = new JniArgumentValue(velocityY);
				ptr[3] = new JniArgumentValue(consumed);
				result = ViewGroup._members.InstanceMethods.InvokeVirtualBooleanMethod("onNestedFling.(Landroid/view/View;FFZ)Z", this, ptr);
			}
			finally
			{
				GC.KeepAlive(target);
			}
			return result;
		}

		// Token: 0x06000C3F RID: 3135 RVA: 0x0001F3A8 File Offset: 0x0001D5A8
		private static Delegate GetOnNestedPreFling_Landroid_view_View_FFHandler()
		{
			if (ViewGroup.cb_onNestedPreFling_Landroid_view_View_FF == null)
			{
				ViewGroup.cb_onNestedPreFling_Landroid_view_View_FF = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLFF_Z(ViewGroup.n_OnNestedPreFling_Landroid_view_View_FF));
			}
			return ViewGroup.cb_onNestedPreFling_Landroid_view_View_FF;
		}

		// Token: 0x06000C40 RID: 3136 RVA: 0x0001F3CC File Offset: 0x0001D5CC
		private static bool n_OnNestedPreFling_Landroid_view_View_FF(IntPtr jnienv, IntPtr native__this, IntPtr native_target, float velocityX, float velocityY)
		{
			ViewGroup @object = Java.Lang.Object.GetObject<ViewGroup>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			View object2 = Java.Lang.Object.GetObject<View>(native_target, JniHandleOwnership.DoNotTransfer);
			return @object.OnNestedPreFling(object2, velocityX, velocityY);
		}

		// Token: 0x06000C41 RID: 3137 RVA: 0x0001F3F4 File Offset: 0x0001D5F4
		public unsafe virtual bool OnNestedPreFling(View target, float velocityX, float velocityY)
		{
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((target == null) ? IntPtr.Zero : target.Handle);
				ptr[1] = new JniArgumentValue(velocityX);
				ptr[2] = new JniArgumentValue(velocityY);
				result = ViewGroup._members.InstanceMethods.InvokeVirtualBooleanMethod("onNestedPreFling.(Landroid/view/View;FF)Z", this, ptr);
			}
			finally
			{
				GC.KeepAlive(target);
			}
			return result;
		}

		// Token: 0x06000C42 RID: 3138 RVA: 0x0001F484 File Offset: 0x0001D684
		private static Delegate GetOnNestedPrePerformAccessibilityAction_Landroid_view_View_ILandroid_os_Bundle_Handler()
		{
			if (ViewGroup.cb_onNestedPrePerformAccessibilityAction_Landroid_view_View_ILandroid_os_Bundle_ == null)
			{
				ViewGroup.cb_onNestedPrePerformAccessibilityAction_Landroid_view_View_ILandroid_os_Bundle_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLIL_Z(ViewGroup.n_OnNestedPrePerformAccessibilityAction_Landroid_view_View_ILandroid_os_Bundle_));
			}
			return ViewGroup.cb_onNestedPrePerformAccessibilityAction_Landroid_view_View_ILandroid_os_Bundle_;
		}

		// Token: 0x06000C43 RID: 3139 RVA: 0x0001F4A8 File Offset: 0x0001D6A8
		private static bool n_OnNestedPrePerformAccessibilityAction_Landroid_view_View_ILandroid_os_Bundle_(IntPtr jnienv, IntPtr native__this, IntPtr native_target, int native_action, IntPtr native_args)
		{
			ViewGroup @object = Java.Lang.Object.GetObject<ViewGroup>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			View object2 = Java.Lang.Object.GetObject<View>(native_target, JniHandleOwnership.DoNotTransfer);
			Bundle object3 = Java.Lang.Object.GetObject<Bundle>(native_args, JniHandleOwnership.DoNotTransfer);
			return @object.OnNestedPrePerformAccessibilityAction(object2, (Android.Views.Accessibility.Action)native_action, object3);
		}

		// Token: 0x06000C44 RID: 3140 RVA: 0x0001F4D8 File Offset: 0x0001D6D8
		public unsafe virtual bool OnNestedPrePerformAccessibilityAction(View target, [GeneratedEnum] Android.Views.Accessibility.Action action, Bundle args)
		{
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((target == null) ? IntPtr.Zero : target.Handle);
				ptr[1] = new JniArgumentValue((int)action);
				ptr[2] = new JniArgumentValue((args == null) ? IntPtr.Zero : args.Handle);
				result = ViewGroup._members.InstanceMethods.InvokeVirtualBooleanMethod("onNestedPrePerformAccessibilityAction.(Landroid/view/View;ILandroid/os/Bundle;)Z", this, ptr);
			}
			finally
			{
				GC.KeepAlive(target);
				GC.KeepAlive(args);
			}
			return result;
		}

		// Token: 0x06000C45 RID: 3141 RVA: 0x0001F57C File Offset: 0x0001D77C
		private static Delegate GetOnNestedPreScroll_Landroid_view_View_IIarrayIHandler()
		{
			if (ViewGroup.cb_onNestedPreScroll_Landroid_view_View_IIarrayI == null)
			{
				ViewGroup.cb_onNestedPreScroll_Landroid_view_View_IIarrayI = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLIIL_V(ViewGroup.n_OnNestedPreScroll_Landroid_view_View_IIarrayI));
			}
			return ViewGroup.cb_onNestedPreScroll_Landroid_view_View_IIarrayI;
		}

		// Token: 0x06000C46 RID: 3142 RVA: 0x0001F5A0 File Offset: 0x0001D7A0
		private static void n_OnNestedPreScroll_Landroid_view_View_IIarrayI(IntPtr jnienv, IntPtr native__this, IntPtr native_target, int dx, int dy, IntPtr native_consumed)
		{
			ViewGroup @object = Java.Lang.Object.GetObject<ViewGroup>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			View object2 = Java.Lang.Object.GetObject<View>(native_target, JniHandleOwnership.DoNotTransfer);
			int[] array = (int[])JNIEnv.GetArray(native_consumed, JniHandleOwnership.DoNotTransfer, typeof(int));
			@object.OnNestedPreScroll(object2, dx, dy, array);
			if (array != null)
			{
				JNIEnv.CopyArray(array, native_consumed);
			}
		}

		// Token: 0x06000C47 RID: 3143 RVA: 0x0001F5EC File Offset: 0x0001D7EC
		public unsafe virtual void OnNestedPreScroll(View target, int dx, int dy, int[] consumed)
		{
			IntPtr intPtr = JNIEnv.NewArray(consumed);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((target == null) ? IntPtr.Zero : target.Handle);
				ptr[1] = new JniArgumentValue(dx);
				ptr[2] = new JniArgumentValue(dy);
				ptr[3] = new JniArgumentValue(intPtr);
				ViewGroup._members.InstanceMethods.InvokeVirtualVoidMethod("onNestedPreScroll.(Landroid/view/View;II[I)V", this, ptr);
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

		// Token: 0x06000C48 RID: 3144 RVA: 0x0001F6B0 File Offset: 0x0001D8B0
		private static Delegate GetOnNestedScroll_Landroid_view_View_IIIIHandler()
		{
			if (ViewGroup.cb_onNestedScroll_Landroid_view_View_IIII == null)
			{
				ViewGroup.cb_onNestedScroll_Landroid_view_View_IIII = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLIIII_V(ViewGroup.n_OnNestedScroll_Landroid_view_View_IIII));
			}
			return ViewGroup.cb_onNestedScroll_Landroid_view_View_IIII;
		}

		// Token: 0x06000C49 RID: 3145 RVA: 0x0001F6D4 File Offset: 0x0001D8D4
		private static void n_OnNestedScroll_Landroid_view_View_IIII(IntPtr jnienv, IntPtr native__this, IntPtr native_target, int dxConsumed, int dyConsumed, int dxUnconsumed, int dyUnconsumed)
		{
			ViewGroup @object = Java.Lang.Object.GetObject<ViewGroup>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			View object2 = Java.Lang.Object.GetObject<View>(native_target, JniHandleOwnership.DoNotTransfer);
			@object.OnNestedScroll(object2, dxConsumed, dyConsumed, dxUnconsumed, dyUnconsumed);
		}

		// Token: 0x06000C4A RID: 3146 RVA: 0x0001F700 File Offset: 0x0001D900
		public unsafe virtual void OnNestedScroll(View target, int dxConsumed, int dyConsumed, int dxUnconsumed, int dyUnconsumed)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((target == null) ? IntPtr.Zero : target.Handle);
				ptr[1] = new JniArgumentValue(dxConsumed);
				ptr[2] = new JniArgumentValue(dyConsumed);
				ptr[3] = new JniArgumentValue(dxUnconsumed);
				ptr[4] = new JniArgumentValue(dyUnconsumed);
				ViewGroup._members.InstanceMethods.InvokeVirtualVoidMethod("onNestedScroll.(Landroid/view/View;IIII)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(target);
			}
		}

		// Token: 0x06000C4B RID: 3147 RVA: 0x0001F7BC File Offset: 0x0001D9BC
		private static Delegate GetOnNestedScrollAccepted_Landroid_view_View_Landroid_view_View_IHandler()
		{
			if (ViewGroup.cb_onNestedScrollAccepted_Landroid_view_View_Landroid_view_View_I == null)
			{
				ViewGroup.cb_onNestedScrollAccepted_Landroid_view_View_Landroid_view_View_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLLI_V(ViewGroup.n_OnNestedScrollAccepted_Landroid_view_View_Landroid_view_View_I));
			}
			return ViewGroup.cb_onNestedScrollAccepted_Landroid_view_View_Landroid_view_View_I;
		}

		// Token: 0x06000C4C RID: 3148 RVA: 0x0001F7E0 File Offset: 0x0001D9E0
		private static void n_OnNestedScrollAccepted_Landroid_view_View_Landroid_view_View_I(IntPtr jnienv, IntPtr native__this, IntPtr native_child, IntPtr native_target, int native_axes)
		{
			ViewGroup @object = Java.Lang.Object.GetObject<ViewGroup>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			View object2 = Java.Lang.Object.GetObject<View>(native_child, JniHandleOwnership.DoNotTransfer);
			View object3 = Java.Lang.Object.GetObject<View>(native_target, JniHandleOwnership.DoNotTransfer);
			@object.OnNestedScrollAccepted(object2, object3, (ScrollAxis)native_axes);
		}

		// Token: 0x06000C4D RID: 3149 RVA: 0x0001F810 File Offset: 0x0001DA10
		public unsafe virtual void OnNestedScrollAccepted(View child, View target, [GeneratedEnum] ScrollAxis axes)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((child == null) ? IntPtr.Zero : child.Handle);
				ptr[1] = new JniArgumentValue((target == null) ? IntPtr.Zero : target.Handle);
				ptr[2] = new JniArgumentValue((int)axes);
				ViewGroup._members.InstanceMethods.InvokeVirtualVoidMethod("onNestedScrollAccepted.(Landroid/view/View;Landroid/view/View;I)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(child);
				GC.KeepAlive(target);
			}
		}

		// Token: 0x06000C4E RID: 3150 RVA: 0x0001F8B4 File Offset: 0x0001DAB4
		private static Delegate GetOnStartNestedScroll_Landroid_view_View_Landroid_view_View_IHandler()
		{
			if (ViewGroup.cb_onStartNestedScroll_Landroid_view_View_Landroid_view_View_I == null)
			{
				ViewGroup.cb_onStartNestedScroll_Landroid_view_View_Landroid_view_View_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLLI_Z(ViewGroup.n_OnStartNestedScroll_Landroid_view_View_Landroid_view_View_I));
			}
			return ViewGroup.cb_onStartNestedScroll_Landroid_view_View_Landroid_view_View_I;
		}

		// Token: 0x06000C4F RID: 3151 RVA: 0x0001F8D8 File Offset: 0x0001DAD8
		private static bool n_OnStartNestedScroll_Landroid_view_View_Landroid_view_View_I(IntPtr jnienv, IntPtr native__this, IntPtr native_child, IntPtr native_target, int native_nestedScrollAxes)
		{
			ViewGroup @object = Java.Lang.Object.GetObject<ViewGroup>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			View object2 = Java.Lang.Object.GetObject<View>(native_child, JniHandleOwnership.DoNotTransfer);
			View object3 = Java.Lang.Object.GetObject<View>(native_target, JniHandleOwnership.DoNotTransfer);
			return @object.OnStartNestedScroll(object2, object3, (ScrollAxis)native_nestedScrollAxes);
		}

		// Token: 0x06000C50 RID: 3152 RVA: 0x0001F908 File Offset: 0x0001DB08
		public unsafe virtual bool OnStartNestedScroll(View child, View target, [GeneratedEnum] ScrollAxis nestedScrollAxes)
		{
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((child == null) ? IntPtr.Zero : child.Handle);
				ptr[1] = new JniArgumentValue((target == null) ? IntPtr.Zero : target.Handle);
				ptr[2] = new JniArgumentValue((int)nestedScrollAxes);
				result = ViewGroup._members.InstanceMethods.InvokeVirtualBooleanMethod("onStartNestedScroll.(Landroid/view/View;Landroid/view/View;I)Z", this, ptr);
			}
			finally
			{
				GC.KeepAlive(child);
				GC.KeepAlive(target);
			}
			return result;
		}

		// Token: 0x06000C51 RID: 3153 RVA: 0x0001F9AC File Offset: 0x0001DBAC
		private static Delegate GetOnStopNestedScroll_Landroid_view_View_Handler()
		{
			if (ViewGroup.cb_onStopNestedScroll_Landroid_view_View_ == null)
			{
				ViewGroup.cb_onStopNestedScroll_Landroid_view_View_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(ViewGroup.n_OnStopNestedScroll_Landroid_view_View_));
			}
			return ViewGroup.cb_onStopNestedScroll_Landroid_view_View_;
		}

		// Token: 0x06000C52 RID: 3154 RVA: 0x0001F9D0 File Offset: 0x0001DBD0
		private static void n_OnStopNestedScroll_Landroid_view_View_(IntPtr jnienv, IntPtr native__this, IntPtr native_child)
		{
			ViewGroup @object = Java.Lang.Object.GetObject<ViewGroup>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			View object2 = Java.Lang.Object.GetObject<View>(native_child, JniHandleOwnership.DoNotTransfer);
			@object.OnStopNestedScroll(object2);
		}

		// Token: 0x06000C53 RID: 3155 RVA: 0x0001F9F4 File Offset: 0x0001DBF4
		public unsafe virtual void OnStopNestedScroll(View child)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((child == null) ? IntPtr.Zero : child.Handle);
				ViewGroup._members.InstanceMethods.InvokeVirtualVoidMethod("onStopNestedScroll.(Landroid/view/View;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(child);
			}
		}

		// Token: 0x06000C54 RID: 3156 RVA: 0x0001FA58 File Offset: 0x0001DC58
		private static Delegate GetRecomputeViewAttributes_Landroid_view_View_Handler()
		{
			if (ViewGroup.cb_recomputeViewAttributes_Landroid_view_View_ == null)
			{
				ViewGroup.cb_recomputeViewAttributes_Landroid_view_View_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(ViewGroup.n_RecomputeViewAttributes_Landroid_view_View_));
			}
			return ViewGroup.cb_recomputeViewAttributes_Landroid_view_View_;
		}

		// Token: 0x06000C55 RID: 3157 RVA: 0x0001FA7C File Offset: 0x0001DC7C
		private static void n_RecomputeViewAttributes_Landroid_view_View_(IntPtr jnienv, IntPtr native__this, IntPtr native_child)
		{
			ViewGroup @object = Java.Lang.Object.GetObject<ViewGroup>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			View object2 = Java.Lang.Object.GetObject<View>(native_child, JniHandleOwnership.DoNotTransfer);
			@object.RecomputeViewAttributes(object2);
		}

		// Token: 0x06000C56 RID: 3158 RVA: 0x0001FAA0 File Offset: 0x0001DCA0
		public unsafe virtual void RecomputeViewAttributes(View child)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((child == null) ? IntPtr.Zero : child.Handle);
				ViewGroup._members.InstanceMethods.InvokeVirtualVoidMethod("recomputeViewAttributes.(Landroid/view/View;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(child);
			}
		}

		// Token: 0x06000C57 RID: 3159 RVA: 0x0001FB04 File Offset: 0x0001DD04
		private static Delegate GetRemoveView_Landroid_view_View_Handler()
		{
			if (ViewGroup.cb_removeView_Landroid_view_View_ == null)
			{
				ViewGroup.cb_removeView_Landroid_view_View_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(ViewGroup.n_RemoveView_Landroid_view_View_));
			}
			return ViewGroup.cb_removeView_Landroid_view_View_;
		}

		// Token: 0x06000C58 RID: 3160 RVA: 0x0001FB28 File Offset: 0x0001DD28
		private static void n_RemoveView_Landroid_view_View_(IntPtr jnienv, IntPtr native__this, IntPtr native_view)
		{
			ViewGroup @object = Java.Lang.Object.GetObject<ViewGroup>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			View object2 = Java.Lang.Object.GetObject<View>(native_view, JniHandleOwnership.DoNotTransfer);
			@object.RemoveView(object2);
		}

		// Token: 0x06000C59 RID: 3161 RVA: 0x0001FB4C File Offset: 0x0001DD4C
		public unsafe virtual void RemoveView(View view)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((view == null) ? IntPtr.Zero : view.Handle);
				ViewGroup._members.InstanceMethods.InvokeVirtualVoidMethod("removeView.(Landroid/view/View;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(view);
			}
		}

		// Token: 0x06000C5A RID: 3162 RVA: 0x0001FBB0 File Offset: 0x0001DDB0
		private static Delegate GetRequestChildFocus_Landroid_view_View_Landroid_view_View_Handler()
		{
			if (ViewGroup.cb_requestChildFocus_Landroid_view_View_Landroid_view_View_ == null)
			{
				ViewGroup.cb_requestChildFocus_Landroid_view_View_Landroid_view_View_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_V(ViewGroup.n_RequestChildFocus_Landroid_view_View_Landroid_view_View_));
			}
			return ViewGroup.cb_requestChildFocus_Landroid_view_View_Landroid_view_View_;
		}

		// Token: 0x06000C5B RID: 3163 RVA: 0x0001FBD4 File Offset: 0x0001DDD4
		private static void n_RequestChildFocus_Landroid_view_View_Landroid_view_View_(IntPtr jnienv, IntPtr native__this, IntPtr native_child, IntPtr native_focused)
		{
			ViewGroup @object = Java.Lang.Object.GetObject<ViewGroup>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			View object2 = Java.Lang.Object.GetObject<View>(native_child, JniHandleOwnership.DoNotTransfer);
			View object3 = Java.Lang.Object.GetObject<View>(native_focused, JniHandleOwnership.DoNotTransfer);
			@object.RequestChildFocus(object2, object3);
		}

		// Token: 0x06000C5C RID: 3164 RVA: 0x0001FC00 File Offset: 0x0001DE00
		public unsafe virtual void RequestChildFocus(View child, View focused)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((child == null) ? IntPtr.Zero : child.Handle);
				ptr[1] = new JniArgumentValue((focused == null) ? IntPtr.Zero : focused.Handle);
				ViewGroup._members.InstanceMethods.InvokeVirtualVoidMethod("requestChildFocus.(Landroid/view/View;Landroid/view/View;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(child);
				GC.KeepAlive(focused);
			}
		}

		// Token: 0x06000C5D RID: 3165 RVA: 0x0001FC8C File Offset: 0x0001DE8C
		private static Delegate GetRequestChildRectangleOnScreen_Landroid_view_View_Landroid_graphics_Rect_ZHandler()
		{
			if (ViewGroup.cb_requestChildRectangleOnScreen_Landroid_view_View_Landroid_graphics_Rect_Z == null)
			{
				ViewGroup.cb_requestChildRectangleOnScreen_Landroid_view_View_Landroid_graphics_Rect_Z = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLLZ_Z(ViewGroup.n_RequestChildRectangleOnScreen_Landroid_view_View_Landroid_graphics_Rect_Z));
			}
			return ViewGroup.cb_requestChildRectangleOnScreen_Landroid_view_View_Landroid_graphics_Rect_Z;
		}

		// Token: 0x06000C5E RID: 3166 RVA: 0x0001FCB0 File Offset: 0x0001DEB0
		private static bool n_RequestChildRectangleOnScreen_Landroid_view_View_Landroid_graphics_Rect_Z(IntPtr jnienv, IntPtr native__this, IntPtr native_child, IntPtr native_rectangle, bool immediate)
		{
			ViewGroup @object = Java.Lang.Object.GetObject<ViewGroup>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			View object2 = Java.Lang.Object.GetObject<View>(native_child, JniHandleOwnership.DoNotTransfer);
			Rect object3 = Java.Lang.Object.GetObject<Rect>(native_rectangle, JniHandleOwnership.DoNotTransfer);
			return @object.RequestChildRectangleOnScreen(object2, object3, immediate);
		}

		// Token: 0x06000C5F RID: 3167 RVA: 0x0001FCE0 File Offset: 0x0001DEE0
		public unsafe virtual bool RequestChildRectangleOnScreen(View child, Rect rectangle, bool immediate)
		{
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((child == null) ? IntPtr.Zero : child.Handle);
				ptr[1] = new JniArgumentValue((rectangle == null) ? IntPtr.Zero : rectangle.Handle);
				ptr[2] = new JniArgumentValue(immediate);
				result = ViewGroup._members.InstanceMethods.InvokeVirtualBooleanMethod("requestChildRectangleOnScreen.(Landroid/view/View;Landroid/graphics/Rect;Z)Z", this, ptr);
			}
			finally
			{
				GC.KeepAlive(child);
				GC.KeepAlive(rectangle);
			}
			return result;
		}

		// Token: 0x06000C60 RID: 3168 RVA: 0x0001FD84 File Offset: 0x0001DF84
		private static Delegate GetRequestDisallowInterceptTouchEvent_ZHandler()
		{
			if (ViewGroup.cb_requestDisallowInterceptTouchEvent_Z == null)
			{
				ViewGroup.cb_requestDisallowInterceptTouchEvent_Z = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPZ_V(ViewGroup.n_RequestDisallowInterceptTouchEvent_Z));
			}
			return ViewGroup.cb_requestDisallowInterceptTouchEvent_Z;
		}

		// Token: 0x06000C61 RID: 3169 RVA: 0x0001FDA8 File Offset: 0x0001DFA8
		private static void n_RequestDisallowInterceptTouchEvent_Z(IntPtr jnienv, IntPtr native__this, bool disallowIntercept)
		{
			Java.Lang.Object.GetObject<ViewGroup>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).RequestDisallowInterceptTouchEvent(disallowIntercept);
		}

		// Token: 0x06000C62 RID: 3170 RVA: 0x0001FDB8 File Offset: 0x0001DFB8
		public unsafe virtual void RequestDisallowInterceptTouchEvent(bool disallowIntercept)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(disallowIntercept);
			ViewGroup._members.InstanceMethods.InvokeVirtualVoidMethod("requestDisallowInterceptTouchEvent.(Z)V", this, ptr);
		}

		// Token: 0x06000C63 RID: 3171 RVA: 0x0001FDF3 File Offset: 0x0001DFF3
		private static Delegate GetRequestSendAccessibilityEvent_Landroid_view_View_Landroid_view_accessibility_AccessibilityEvent_Handler()
		{
			if (ViewGroup.cb_requestSendAccessibilityEvent_Landroid_view_View_Landroid_view_accessibility_AccessibilityEvent_ == null)
			{
				ViewGroup.cb_requestSendAccessibilityEvent_Landroid_view_View_Landroid_view_accessibility_AccessibilityEvent_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_Z(ViewGroup.n_RequestSendAccessibilityEvent_Landroid_view_View_Landroid_view_accessibility_AccessibilityEvent_));
			}
			return ViewGroup.cb_requestSendAccessibilityEvent_Landroid_view_View_Landroid_view_accessibility_AccessibilityEvent_;
		}

		// Token: 0x06000C64 RID: 3172 RVA: 0x0001FE18 File Offset: 0x0001E018
		private static bool n_RequestSendAccessibilityEvent_Landroid_view_View_Landroid_view_accessibility_AccessibilityEvent_(IntPtr jnienv, IntPtr native__this, IntPtr native_child, IntPtr native_e)
		{
			ViewGroup @object = Java.Lang.Object.GetObject<ViewGroup>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			View object2 = Java.Lang.Object.GetObject<View>(native_child, JniHandleOwnership.DoNotTransfer);
			AccessibilityEvent object3 = Java.Lang.Object.GetObject<AccessibilityEvent>(native_e, JniHandleOwnership.DoNotTransfer);
			return @object.RequestSendAccessibilityEvent(object2, object3);
		}

		// Token: 0x06000C65 RID: 3173 RVA: 0x0001FE44 File Offset: 0x0001E044
		public unsafe virtual bool RequestSendAccessibilityEvent(View child, AccessibilityEvent e)
		{
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((child == null) ? IntPtr.Zero : child.Handle);
				ptr[1] = new JniArgumentValue((e == null) ? IntPtr.Zero : e.Handle);
				result = ViewGroup._members.InstanceMethods.InvokeVirtualBooleanMethod("requestSendAccessibilityEvent.(Landroid/view/View;Landroid/view/accessibility/AccessibilityEvent;)Z", this, ptr);
			}
			finally
			{
				GC.KeepAlive(child);
				GC.KeepAlive(e);
			}
			return result;
		}

		// Token: 0x06000C66 RID: 3174 RVA: 0x0001FED4 File Offset: 0x0001E0D4
		private static Delegate GetRequestTransparentRegion_Landroid_view_View_Handler()
		{
			if (ViewGroup.cb_requestTransparentRegion_Landroid_view_View_ == null)
			{
				ViewGroup.cb_requestTransparentRegion_Landroid_view_View_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(ViewGroup.n_RequestTransparentRegion_Landroid_view_View_));
			}
			return ViewGroup.cb_requestTransparentRegion_Landroid_view_View_;
		}

		// Token: 0x06000C67 RID: 3175 RVA: 0x0001FEF8 File Offset: 0x0001E0F8
		private static void n_RequestTransparentRegion_Landroid_view_View_(IntPtr jnienv, IntPtr native__this, IntPtr native_child)
		{
			ViewGroup @object = Java.Lang.Object.GetObject<ViewGroup>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			View object2 = Java.Lang.Object.GetObject<View>(native_child, JniHandleOwnership.DoNotTransfer);
			@object.RequestTransparentRegion(object2);
		}

		// Token: 0x06000C68 RID: 3176 RVA: 0x0001FF1C File Offset: 0x0001E11C
		public unsafe virtual void RequestTransparentRegion(View child)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((child == null) ? IntPtr.Zero : child.Handle);
				ViewGroup._members.InstanceMethods.InvokeVirtualVoidMethod("requestTransparentRegion.(Landroid/view/View;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(child);
			}
		}

		// Token: 0x06000C69 RID: 3177 RVA: 0x0001FF80 File Offset: 0x0001E180
		private static Delegate GetSetClipChildren_ZHandler()
		{
			if (ViewGroup.cb_setClipChildren_Z == null)
			{
				ViewGroup.cb_setClipChildren_Z = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPZ_V(ViewGroup.n_SetClipChildren_Z));
			}
			return ViewGroup.cb_setClipChildren_Z;
		}

		// Token: 0x06000C6A RID: 3178 RVA: 0x0001FFA4 File Offset: 0x0001E1A4
		private static void n_SetClipChildren_Z(IntPtr jnienv, IntPtr native__this, bool clipChildren)
		{
			Java.Lang.Object.GetObject<ViewGroup>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SetClipChildren(clipChildren);
		}

		// Token: 0x06000C6B RID: 3179 RVA: 0x0001FFB4 File Offset: 0x0001E1B4
		public unsafe virtual void SetClipChildren(bool clipChildren)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(clipChildren);
			ViewGroup._members.InstanceMethods.InvokeVirtualVoidMethod("setClipChildren.(Z)V", this, ptr);
		}

		// Token: 0x06000C6C RID: 3180 RVA: 0x0001FFEF File Offset: 0x0001E1EF
		private static Delegate GetSetClipToPadding_ZHandler()
		{
			if (ViewGroup.cb_setClipToPadding_Z == null)
			{
				ViewGroup.cb_setClipToPadding_Z = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPZ_V(ViewGroup.n_SetClipToPadding_Z));
			}
			return ViewGroup.cb_setClipToPadding_Z;
		}

		// Token: 0x06000C6D RID: 3181 RVA: 0x00020013 File Offset: 0x0001E213
		private static void n_SetClipToPadding_Z(IntPtr jnienv, IntPtr native__this, bool clipToPadding)
		{
			Java.Lang.Object.GetObject<ViewGroup>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SetClipToPadding(clipToPadding);
		}

		// Token: 0x06000C6E RID: 3182 RVA: 0x00020024 File Offset: 0x0001E224
		public unsafe virtual void SetClipToPadding(bool clipToPadding)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(clipToPadding);
			ViewGroup._members.InstanceMethods.InvokeVirtualVoidMethod("setClipToPadding.(Z)V", this, ptr);
		}

		// Token: 0x06000C6F RID: 3183 RVA: 0x0002005F File Offset: 0x0001E25F
		private static Delegate GetShowContextMenuForChild_Landroid_view_View_Handler()
		{
			if (ViewGroup.cb_showContextMenuForChild_Landroid_view_View_ == null)
			{
				ViewGroup.cb_showContextMenuForChild_Landroid_view_View_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(ViewGroup.n_ShowContextMenuForChild_Landroid_view_View_));
			}
			return ViewGroup.cb_showContextMenuForChild_Landroid_view_View_;
		}

		// Token: 0x06000C70 RID: 3184 RVA: 0x00020084 File Offset: 0x0001E284
		private static bool n_ShowContextMenuForChild_Landroid_view_View_(IntPtr jnienv, IntPtr native__this, IntPtr native_originalView)
		{
			ViewGroup @object = Java.Lang.Object.GetObject<ViewGroup>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			View object2 = Java.Lang.Object.GetObject<View>(native_originalView, JniHandleOwnership.DoNotTransfer);
			return @object.ShowContextMenuForChild(object2);
		}

		// Token: 0x06000C71 RID: 3185 RVA: 0x000200A8 File Offset: 0x0001E2A8
		public unsafe virtual bool ShowContextMenuForChild(View originalView)
		{
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((originalView == null) ? IntPtr.Zero : originalView.Handle);
				result = ViewGroup._members.InstanceMethods.InvokeVirtualBooleanMethod("showContextMenuForChild.(Landroid/view/View;)Z", this, ptr);
			}
			finally
			{
				GC.KeepAlive(originalView);
			}
			return result;
		}

		// Token: 0x06000C72 RID: 3186 RVA: 0x00020110 File Offset: 0x0001E310
		private static Delegate GetShowContextMenuForChild_Landroid_view_View_FFHandler()
		{
			if (ViewGroup.cb_showContextMenuForChild_Landroid_view_View_FF == null)
			{
				ViewGroup.cb_showContextMenuForChild_Landroid_view_View_FF = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLFF_Z(ViewGroup.n_ShowContextMenuForChild_Landroid_view_View_FF));
			}
			return ViewGroup.cb_showContextMenuForChild_Landroid_view_View_FF;
		}

		// Token: 0x06000C73 RID: 3187 RVA: 0x00020134 File Offset: 0x0001E334
		private static bool n_ShowContextMenuForChild_Landroid_view_View_FF(IntPtr jnienv, IntPtr native__this, IntPtr native_originalView, float x, float y)
		{
			ViewGroup @object = Java.Lang.Object.GetObject<ViewGroup>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			View object2 = Java.Lang.Object.GetObject<View>(native_originalView, JniHandleOwnership.DoNotTransfer);
			return @object.ShowContextMenuForChild(object2, x, y);
		}

		// Token: 0x06000C74 RID: 3188 RVA: 0x0002015C File Offset: 0x0001E35C
		public unsafe virtual bool ShowContextMenuForChild(View originalView, float x, float y)
		{
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((originalView == null) ? IntPtr.Zero : originalView.Handle);
				ptr[1] = new JniArgumentValue(x);
				ptr[2] = new JniArgumentValue(y);
				result = ViewGroup._members.InstanceMethods.InvokeVirtualBooleanMethod("showContextMenuForChild.(Landroid/view/View;FF)Z", this, ptr);
			}
			finally
			{
				GC.KeepAlive(originalView);
			}
			return result;
		}

		// Token: 0x06000C75 RID: 3189 RVA: 0x000201EC File Offset: 0x0001E3EC
		private static Delegate GetStartActionModeForChild_Landroid_view_View_Landroid_view_ActionMode_Callback_Handler()
		{
			if (ViewGroup.cb_startActionModeForChild_Landroid_view_View_Landroid_view_ActionMode_Callback_ == null)
			{
				ViewGroup.cb_startActionModeForChild_Landroid_view_View_Landroid_view_ActionMode_Callback_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_L(ViewGroup.n_StartActionModeForChild_Landroid_view_View_Landroid_view_ActionMode_Callback_));
			}
			return ViewGroup.cb_startActionModeForChild_Landroid_view_View_Landroid_view_ActionMode_Callback_;
		}

		// Token: 0x06000C76 RID: 3190 RVA: 0x00020210 File Offset: 0x0001E410
		private static IntPtr n_StartActionModeForChild_Landroid_view_View_Landroid_view_ActionMode_Callback_(IntPtr jnienv, IntPtr native__this, IntPtr native_originalView, IntPtr native__callback)
		{
			ViewGroup @object = Java.Lang.Object.GetObject<ViewGroup>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			View object2 = Java.Lang.Object.GetObject<View>(native_originalView, JniHandleOwnership.DoNotTransfer);
			ActionMode.ICallback object3 = Java.Lang.Object.GetObject<ActionMode.ICallback>(native__callback, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.StartActionModeForChild(object2, object3));
		}

		// Token: 0x06000C77 RID: 3191 RVA: 0x00020244 File Offset: 0x0001E444
		public unsafe virtual ActionMode StartActionModeForChild(View originalView, ActionMode.ICallback callback)
		{
			ActionMode @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((originalView == null) ? IntPtr.Zero : originalView.Handle);
				ptr[1] = new JniArgumentValue((callback == null) ? IntPtr.Zero : ((Java.Lang.Object)callback).Handle);
				@object = Java.Lang.Object.GetObject<ActionMode>(ViewGroup._members.InstanceMethods.InvokeVirtualObjectMethod("startActionModeForChild.(Landroid/view/View;Landroid/view/ActionMode$Callback;)Landroid/view/ActionMode;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(originalView);
				GC.KeepAlive(callback);
			}
			return @object;
		}

		// Token: 0x06000C78 RID: 3192 RVA: 0x000202E4 File Offset: 0x0001E4E4
		private static Delegate GetStartActionModeForChild_Landroid_view_View_Landroid_view_ActionMode_Callback_IHandler()
		{
			if (ViewGroup.cb_startActionModeForChild_Landroid_view_View_Landroid_view_ActionMode_Callback_I == null)
			{
				ViewGroup.cb_startActionModeForChild_Landroid_view_View_Landroid_view_ActionMode_Callback_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLLI_L(ViewGroup.n_StartActionModeForChild_Landroid_view_View_Landroid_view_ActionMode_Callback_I));
			}
			return ViewGroup.cb_startActionModeForChild_Landroid_view_View_Landroid_view_ActionMode_Callback_I;
		}

		// Token: 0x06000C79 RID: 3193 RVA: 0x00020308 File Offset: 0x0001E508
		private static IntPtr n_StartActionModeForChild_Landroid_view_View_Landroid_view_ActionMode_Callback_I(IntPtr jnienv, IntPtr native__this, IntPtr native_originalView, IntPtr native__callback, int native_type)
		{
			ViewGroup @object = Java.Lang.Object.GetObject<ViewGroup>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			View object2 = Java.Lang.Object.GetObject<View>(native_originalView, JniHandleOwnership.DoNotTransfer);
			ActionMode.ICallback object3 = Java.Lang.Object.GetObject<ActionMode.ICallback>(native__callback, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.StartActionModeForChild(object2, object3, (ActionModeType)native_type));
		}

		// Token: 0x06000C7A RID: 3194 RVA: 0x00020340 File Offset: 0x0001E540
		public unsafe virtual ActionMode StartActionModeForChild(View originalView, ActionMode.ICallback callback, [GeneratedEnum] ActionModeType type)
		{
			ActionMode @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((originalView == null) ? IntPtr.Zero : originalView.Handle);
				ptr[1] = new JniArgumentValue((callback == null) ? IntPtr.Zero : ((Java.Lang.Object)callback).Handle);
				ptr[2] = new JniArgumentValue((int)type);
				@object = Java.Lang.Object.GetObject<ActionMode>(ViewGroup._members.InstanceMethods.InvokeVirtualObjectMethod("startActionModeForChild.(Landroid/view/View;Landroid/view/ActionMode$Callback;I)Landroid/view/ActionMode;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(originalView);
				GC.KeepAlive(callback);
			}
			return @object;
		}

		// Token: 0x06000C7B RID: 3195 RVA: 0x000203F8 File Offset: 0x0001E5F8
		private static Delegate GetSuppressLayout_ZHandler()
		{
			if (ViewGroup.cb_suppressLayout_Z == null)
			{
				ViewGroup.cb_suppressLayout_Z = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPZ_V(ViewGroup.n_SuppressLayout_Z));
			}
			return ViewGroup.cb_suppressLayout_Z;
		}

		// Token: 0x06000C7C RID: 3196 RVA: 0x0002041C File Offset: 0x0001E61C
		private static void n_SuppressLayout_Z(IntPtr jnienv, IntPtr native__this, bool suppress)
		{
			Java.Lang.Object.GetObject<ViewGroup>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SuppressLayout(suppress);
		}

		// Token: 0x06000C7D RID: 3197 RVA: 0x0002042C File Offset: 0x0001E62C
		public unsafe virtual void SuppressLayout(bool suppress)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(suppress);
			ViewGroup._members.InstanceMethods.InvokeVirtualVoidMethod("suppressLayout.(Z)V", this, ptr);
		}

		// Token: 0x06000C7E RID: 3198 RVA: 0x00020467 File Offset: 0x0001E667
		private static Delegate GetUpdateViewLayout_Landroid_view_View_Landroid_view_ViewGroup_LayoutParams_Handler()
		{
			if (ViewGroup.cb_updateViewLayout_Landroid_view_View_Landroid_view_ViewGroup_LayoutParams_ == null)
			{
				ViewGroup.cb_updateViewLayout_Landroid_view_View_Landroid_view_ViewGroup_LayoutParams_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_V(ViewGroup.n_UpdateViewLayout_Landroid_view_View_Landroid_view_ViewGroup_LayoutParams_));
			}
			return ViewGroup.cb_updateViewLayout_Landroid_view_View_Landroid_view_ViewGroup_LayoutParams_;
		}

		// Token: 0x06000C7F RID: 3199 RVA: 0x0002048C File Offset: 0x0001E68C
		private static void n_UpdateViewLayout_Landroid_view_View_Landroid_view_ViewGroup_LayoutParams_(IntPtr jnienv, IntPtr native__this, IntPtr native_view, IntPtr native__params)
		{
			ViewGroup @object = Java.Lang.Object.GetObject<ViewGroup>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			View object2 = Java.Lang.Object.GetObject<View>(native_view, JniHandleOwnership.DoNotTransfer);
			ViewGroup.LayoutParams object3 = Java.Lang.Object.GetObject<ViewGroup.LayoutParams>(native__params, JniHandleOwnership.DoNotTransfer);
			@object.UpdateViewLayout(object2, object3);
		}

		// Token: 0x06000C80 RID: 3200 RVA: 0x000204B8 File Offset: 0x0001E6B8
		public unsafe virtual void UpdateViewLayout(View view, ViewGroup.LayoutParams @params)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((view == null) ? IntPtr.Zero : view.Handle);
				ptr[1] = new JniArgumentValue((@params == null) ? IntPtr.Zero : @params.Handle);
				ViewGroup._members.InstanceMethods.InvokeVirtualVoidMethod("updateViewLayout.(Landroid/view/View;Landroid/view/ViewGroup$LayoutParams;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(view);
				GC.KeepAlive(@params);
			}
		}

		// Token: 0x040003ED RID: 1005
		private static readonly JniPeerMembers _members = new XAPeerMembers("android/view/ViewGroup", typeof(ViewGroup));

		// Token: 0x040003EE RID: 1006
		private static Delegate cb_getFocusedChild;

		// Token: 0x040003EF RID: 1007
		private static Delegate cb_isLayoutSuppressed;

		// Token: 0x040003F0 RID: 1008
		private static Delegate cb_getNestedScrollAxes;

		// Token: 0x040003F1 RID: 1009
		private static Delegate cb_addView_Landroid_view_View_;

		// Token: 0x040003F2 RID: 1010
		private static Delegate cb_addView_Landroid_view_View_Landroid_view_ViewGroup_LayoutParams_;

		// Token: 0x040003F3 RID: 1011
		private static Delegate cb_bringChildToFront_Landroid_view_View_;

		// Token: 0x040003F4 RID: 1012
		private static Delegate cb_childDrawableStateChanged_Landroid_view_View_;

		// Token: 0x040003F5 RID: 1013
		private static Delegate cb_childHasTransientStateChanged_Landroid_view_View_Z;

		// Token: 0x040003F6 RID: 1014
		private static Delegate cb_clearChildFocus_Landroid_view_View_;

		// Token: 0x040003F7 RID: 1015
		private static Delegate cb_drawChild_Landroid_graphics_Canvas_Landroid_view_View_J;

		// Token: 0x040003F8 RID: 1016
		private static Delegate cb_findOnBackInvokedDispatcherForChild_Landroid_view_View_Landroid_view_View_;

		// Token: 0x040003F9 RID: 1017
		private static Delegate cb_focusableViewAvailable_Landroid_view_View_;

		// Token: 0x040003FA RID: 1018
		private static Delegate cb_focusSearch_Landroid_view_View_I;

		// Token: 0x040003FB RID: 1019
		private static Delegate cb_getChildAt_I;

		// Token: 0x040003FC RID: 1020
		private static Delegate cb_getChildVisibleRect_Landroid_view_View_Landroid_graphics_Rect_Landroid_graphics_Point_;

		// Token: 0x040003FD RID: 1021
		private static Delegate cb_invalidateChildInParent_arrayILandroid_graphics_Rect_;

		// Token: 0x040003FE RID: 1022
		private static Delegate cb_notifySubtreeAccessibilityStateChanged_Landroid_view_View_Landroid_view_View_I;

		// Token: 0x040003FF RID: 1023
		private static Delegate cb_onDescendantInvalidated_Landroid_view_View_Landroid_view_View_;

		// Token: 0x04000400 RID: 1024
		private static Delegate cb_onLayout_ZIIII;

		// Token: 0x04000401 RID: 1025
		private static Delegate cb_onNestedFling_Landroid_view_View_FFZ;

		// Token: 0x04000402 RID: 1026
		private static Delegate cb_onNestedPreFling_Landroid_view_View_FF;

		// Token: 0x04000403 RID: 1027
		private static Delegate cb_onNestedPrePerformAccessibilityAction_Landroid_view_View_ILandroid_os_Bundle_;

		// Token: 0x04000404 RID: 1028
		private static Delegate cb_onNestedPreScroll_Landroid_view_View_IIarrayI;

		// Token: 0x04000405 RID: 1029
		private static Delegate cb_onNestedScroll_Landroid_view_View_IIII;

		// Token: 0x04000406 RID: 1030
		private static Delegate cb_onNestedScrollAccepted_Landroid_view_View_Landroid_view_View_I;

		// Token: 0x04000407 RID: 1031
		private static Delegate cb_onStartNestedScroll_Landroid_view_View_Landroid_view_View_I;

		// Token: 0x04000408 RID: 1032
		private static Delegate cb_onStopNestedScroll_Landroid_view_View_;

		// Token: 0x04000409 RID: 1033
		private static Delegate cb_recomputeViewAttributes_Landroid_view_View_;

		// Token: 0x0400040A RID: 1034
		private static Delegate cb_removeView_Landroid_view_View_;

		// Token: 0x0400040B RID: 1035
		private static Delegate cb_requestChildFocus_Landroid_view_View_Landroid_view_View_;

		// Token: 0x0400040C RID: 1036
		private static Delegate cb_requestChildRectangleOnScreen_Landroid_view_View_Landroid_graphics_Rect_Z;

		// Token: 0x0400040D RID: 1037
		private static Delegate cb_requestDisallowInterceptTouchEvent_Z;

		// Token: 0x0400040E RID: 1038
		private static Delegate cb_requestSendAccessibilityEvent_Landroid_view_View_Landroid_view_accessibility_AccessibilityEvent_;

		// Token: 0x0400040F RID: 1039
		private static Delegate cb_requestTransparentRegion_Landroid_view_View_;

		// Token: 0x04000410 RID: 1040
		private static Delegate cb_setClipChildren_Z;

		// Token: 0x04000411 RID: 1041
		private static Delegate cb_setClipToPadding_Z;

		// Token: 0x04000412 RID: 1042
		private static Delegate cb_showContextMenuForChild_Landroid_view_View_;

		// Token: 0x04000413 RID: 1043
		private static Delegate cb_showContextMenuForChild_Landroid_view_View_FF;

		// Token: 0x04000414 RID: 1044
		private static Delegate cb_startActionModeForChild_Landroid_view_View_Landroid_view_ActionMode_Callback_;

		// Token: 0x04000415 RID: 1045
		private static Delegate cb_startActionModeForChild_Landroid_view_View_Landroid_view_ActionMode_Callback_I;

		// Token: 0x04000416 RID: 1046
		private static Delegate cb_suppressLayout_Z;

		// Token: 0x04000417 RID: 1047
		private static Delegate cb_updateViewLayout_Landroid_view_View_Landroid_view_ViewGroup_LayoutParams_;

		// Token: 0x02000159 RID: 345
		[Register("android/view/ViewGroup$LayoutParams", DoNotGenerateAcw = true)]
		public class LayoutParams : Java.Lang.Object
		{
			// Token: 0x17000252 RID: 594
			// (set) Token: 0x06000C82 RID: 3202 RVA: 0x0002055F File Offset: 0x0001E75F
			[Register("width")]
			public int Width
			{
				set
				{
					ViewGroup.LayoutParams._members.InstanceFields.SetValue("width.I", this, value);
				}
			}

			// Token: 0x17000253 RID: 595
			// (get) Token: 0x06000C83 RID: 3203 RVA: 0x00020577 File Offset: 0x0001E777
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return ViewGroup.LayoutParams._members;
				}
			}

			// Token: 0x17000254 RID: 596
			// (get) Token: 0x06000C84 RID: 3204 RVA: 0x00020580 File Offset: 0x0001E780
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return ViewGroup.LayoutParams._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x17000255 RID: 597
			// (get) Token: 0x06000C85 RID: 3205 RVA: 0x000205A4 File Offset: 0x0001E7A4
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return ViewGroup.LayoutParams._members.ManagedPeerType;
				}
			}

			// Token: 0x06000C86 RID: 3206 RVA: 0x000021E0 File Offset: 0x000003E0
			protected LayoutParams(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
			{
			}

			// Token: 0x06000C87 RID: 3207 RVA: 0x000205B0 File Offset: 0x0001E7B0
			[Register(".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", "")]
			public unsafe LayoutParams(Context c, IAttributeSet attrs) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (base.Handle != IntPtr.Zero)
				{
					return;
				}
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((c == null) ? IntPtr.Zero : c.Handle);
					ptr[1] = new JniArgumentValue((attrs == null) ? IntPtr.Zero : ((Java.Lang.Object)attrs).Handle);
					base.SetHandle(ViewGroup.LayoutParams._members.InstanceMethods.StartCreateInstance("(Landroid/content/Context;Landroid/util/AttributeSet;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
					ViewGroup.LayoutParams._members.InstanceMethods.FinishCreateInstance("(Landroid/content/Context;Landroid/util/AttributeSet;)V", this, ptr);
				}
				finally
				{
					GC.KeepAlive(c);
					GC.KeepAlive(attrs);
				}
			}

			// Token: 0x04000418 RID: 1048
			private static readonly JniPeerMembers _members = new XAPeerMembers("android/view/ViewGroup$LayoutParams", typeof(ViewGroup.LayoutParams));
		}

		// Token: 0x0200015A RID: 346
		[Register("android/view/ViewGroup$MarginLayoutParams", DoNotGenerateAcw = true)]
		public class MarginLayoutParams : ViewGroup.LayoutParams
		{
			// Token: 0x17000256 RID: 598
			// (get) Token: 0x06000C89 RID: 3209 RVA: 0x000206A7 File Offset: 0x0001E8A7
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return ViewGroup.MarginLayoutParams._members;
				}
			}

			// Token: 0x17000257 RID: 599
			// (get) Token: 0x06000C8A RID: 3210 RVA: 0x000206B0 File Offset: 0x0001E8B0
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return ViewGroup.MarginLayoutParams._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x17000258 RID: 600
			// (get) Token: 0x06000C8B RID: 3211 RVA: 0x000206D4 File Offset: 0x0001E8D4
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return ViewGroup.MarginLayoutParams._members.ManagedPeerType;
				}
			}

			// Token: 0x06000C8C RID: 3212 RVA: 0x00018C60 File Offset: 0x00016E60
			protected MarginLayoutParams(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
			{
			}

			// Token: 0x06000C8D RID: 3213 RVA: 0x000206E0 File Offset: 0x0001E8E0
			[Register(".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", "")]
			public unsafe MarginLayoutParams(Context c, IAttributeSet attrs) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (base.Handle != IntPtr.Zero)
				{
					return;
				}
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((c == null) ? IntPtr.Zero : c.Handle);
					ptr[1] = new JniArgumentValue((attrs == null) ? IntPtr.Zero : ((Java.Lang.Object)attrs).Handle);
					base.SetHandle(ViewGroup.MarginLayoutParams._members.InstanceMethods.StartCreateInstance("(Landroid/content/Context;Landroid/util/AttributeSet;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
					ViewGroup.MarginLayoutParams._members.InstanceMethods.FinishCreateInstance("(Landroid/content/Context;Landroid/util/AttributeSet;)V", this, ptr);
				}
				finally
				{
					GC.KeepAlive(c);
					GC.KeepAlive(attrs);
				}
			}

			// Token: 0x04000419 RID: 1049
			private static readonly JniPeerMembers _members = new XAPeerMembers("android/view/ViewGroup$MarginLayoutParams", typeof(ViewGroup.MarginLayoutParams));
		}

		// Token: 0x0200015B RID: 347
		[Register("android/view/ViewGroup$OnHierarchyChangeListener", "", "Android.Views.ViewGroup/IOnHierarchyChangeListenerInvoker")]
		public interface IOnHierarchyChangeListener : IJavaObject, IDisposable, IJavaPeerable
		{
			// Token: 0x06000C8F RID: 3215
			[Register("onChildViewAdded", "(Landroid/view/View;Landroid/view/View;)V", "GetOnChildViewAdded_Landroid_view_View_Landroid_view_View_Handler:Android.Views.ViewGroup/IOnHierarchyChangeListenerInvoker, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null")]
			void OnChildViewAdded(View parent, View child);

			// Token: 0x06000C90 RID: 3216
			[Register("onChildViewRemoved", "(Landroid/view/View;Landroid/view/View;)V", "GetOnChildViewRemoved_Landroid_view_View_Landroid_view_View_Handler:Android.Views.ViewGroup/IOnHierarchyChangeListenerInvoker, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null")]
			void OnChildViewRemoved(View parent, View child);
		}

		// Token: 0x0200015C RID: 348
		[Register("android/view/ViewGroup$OnHierarchyChangeListener", DoNotGenerateAcw = true)]
		internal class IOnHierarchyChangeListenerInvoker : Java.Lang.Object, ViewGroup.IOnHierarchyChangeListener, IJavaObject, IDisposable, IJavaPeerable
		{
			// Token: 0x17000259 RID: 601
			// (get) Token: 0x06000C91 RID: 3217 RVA: 0x000207D8 File Offset: 0x0001E9D8
			private static IntPtr java_class_ref
			{
				get
				{
					return ViewGroup.IOnHierarchyChangeListenerInvoker._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x1700025A RID: 602
			// (get) Token: 0x06000C92 RID: 3218 RVA: 0x000207FC File Offset: 0x0001E9FC
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return ViewGroup.IOnHierarchyChangeListenerInvoker._members;
				}
			}

			// Token: 0x1700025B RID: 603
			// (get) Token: 0x06000C93 RID: 3219 RVA: 0x00020803 File Offset: 0x0001EA03
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return this.class_ref;
				}
			}

			// Token: 0x1700025C RID: 604
			// (get) Token: 0x06000C94 RID: 3220 RVA: 0x0002080B File Offset: 0x0001EA0B
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return ViewGroup.IOnHierarchyChangeListenerInvoker._members.ManagedPeerType;
				}
			}

			// Token: 0x06000C95 RID: 3221 RVA: 0x00020817 File Offset: 0x0001EA17
			private static IntPtr Validate(IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf(handle, ViewGroup.IOnHierarchyChangeListenerInvoker.java_class_ref))
				{
					throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'android.view.ViewGroup.OnHierarchyChangeListener'.");
				}
				return handle;
			}

			// Token: 0x06000C96 RID: 3222 RVA: 0x00020842 File Offset: 0x0001EA42
			protected override void Dispose(bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
				{
					JNIEnv.DeleteGlobalRef(this.class_ref);
				}
				this.class_ref = IntPtr.Zero;
				base.Dispose(disposing);
			}

			// Token: 0x06000C97 RID: 3223 RVA: 0x00020874 File Offset: 0x0001EA74
			public IOnHierarchyChangeListenerInvoker(IntPtr handle, JniHandleOwnership transfer) : base(ViewGroup.IOnHierarchyChangeListenerInvoker.Validate(handle), transfer)
			{
				IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
				this.class_ref = JNIEnv.NewGlobalRef(objectClass);
				JNIEnv.DeleteLocalRef(objectClass);
			}

			// Token: 0x06000C98 RID: 3224 RVA: 0x000208AC File Offset: 0x0001EAAC
			private static Delegate GetOnChildViewAdded_Landroid_view_View_Landroid_view_View_Handler()
			{
				if (ViewGroup.IOnHierarchyChangeListenerInvoker.cb_onChildViewAdded_Landroid_view_View_Landroid_view_View_ == null)
				{
					ViewGroup.IOnHierarchyChangeListenerInvoker.cb_onChildViewAdded_Landroid_view_View_Landroid_view_View_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_V(ViewGroup.IOnHierarchyChangeListenerInvoker.n_OnChildViewAdded_Landroid_view_View_Landroid_view_View_));
				}
				return ViewGroup.IOnHierarchyChangeListenerInvoker.cb_onChildViewAdded_Landroid_view_View_Landroid_view_View_;
			}

			// Token: 0x06000C99 RID: 3225 RVA: 0x000208D0 File Offset: 0x0001EAD0
			private static void n_OnChildViewAdded_Landroid_view_View_Landroid_view_View_(IntPtr jnienv, IntPtr native__this, IntPtr native_parent, IntPtr native_child)
			{
				ViewGroup.IOnHierarchyChangeListener @object = Java.Lang.Object.GetObject<ViewGroup.IOnHierarchyChangeListener>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				View object2 = Java.Lang.Object.GetObject<View>(native_parent, JniHandleOwnership.DoNotTransfer);
				View object3 = Java.Lang.Object.GetObject<View>(native_child, JniHandleOwnership.DoNotTransfer);
				@object.OnChildViewAdded(object2, object3);
			}

			// Token: 0x06000C9A RID: 3226 RVA: 0x000208FC File Offset: 0x0001EAFC
			public unsafe void OnChildViewAdded(View parent, View child)
			{
				if (this.id_onChildViewAdded_Landroid_view_View_Landroid_view_View_ == IntPtr.Zero)
				{
					this.id_onChildViewAdded_Landroid_view_View_Landroid_view_View_ = JNIEnv.GetMethodID(this.class_ref, "onChildViewAdded", "(Landroid/view/View;Landroid/view/View;)V");
				}
				JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JValue))];
				*ptr = new JValue((parent == null) ? IntPtr.Zero : parent.Handle);
				ptr[1] = new JValue((child == null) ? IntPtr.Zero : child.Handle);
				JNIEnv.CallVoidMethod(base.Handle, this.id_onChildViewAdded_Landroid_view_View_Landroid_view_View_, ptr);
			}

			// Token: 0x06000C9B RID: 3227 RVA: 0x00020991 File Offset: 0x0001EB91
			private static Delegate GetOnChildViewRemoved_Landroid_view_View_Landroid_view_View_Handler()
			{
				if (ViewGroup.IOnHierarchyChangeListenerInvoker.cb_onChildViewRemoved_Landroid_view_View_Landroid_view_View_ == null)
				{
					ViewGroup.IOnHierarchyChangeListenerInvoker.cb_onChildViewRemoved_Landroid_view_View_Landroid_view_View_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_V(ViewGroup.IOnHierarchyChangeListenerInvoker.n_OnChildViewRemoved_Landroid_view_View_Landroid_view_View_));
				}
				return ViewGroup.IOnHierarchyChangeListenerInvoker.cb_onChildViewRemoved_Landroid_view_View_Landroid_view_View_;
			}

			// Token: 0x06000C9C RID: 3228 RVA: 0x000209B8 File Offset: 0x0001EBB8
			private static void n_OnChildViewRemoved_Landroid_view_View_Landroid_view_View_(IntPtr jnienv, IntPtr native__this, IntPtr native_parent, IntPtr native_child)
			{
				ViewGroup.IOnHierarchyChangeListener @object = Java.Lang.Object.GetObject<ViewGroup.IOnHierarchyChangeListener>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				View object2 = Java.Lang.Object.GetObject<View>(native_parent, JniHandleOwnership.DoNotTransfer);
				View object3 = Java.Lang.Object.GetObject<View>(native_child, JniHandleOwnership.DoNotTransfer);
				@object.OnChildViewRemoved(object2, object3);
			}

			// Token: 0x06000C9D RID: 3229 RVA: 0x000209E4 File Offset: 0x0001EBE4
			public unsafe void OnChildViewRemoved(View parent, View child)
			{
				if (this.id_onChildViewRemoved_Landroid_view_View_Landroid_view_View_ == IntPtr.Zero)
				{
					this.id_onChildViewRemoved_Landroid_view_View_Landroid_view_View_ = JNIEnv.GetMethodID(this.class_ref, "onChildViewRemoved", "(Landroid/view/View;Landroid/view/View;)V");
				}
				JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JValue))];
				*ptr = new JValue((parent == null) ? IntPtr.Zero : parent.Handle);
				ptr[1] = new JValue((child == null) ? IntPtr.Zero : child.Handle);
				JNIEnv.CallVoidMethod(base.Handle, this.id_onChildViewRemoved_Landroid_view_View_Landroid_view_View_, ptr);
			}

			// Token: 0x0400041A RID: 1050
			private static readonly JniPeerMembers _members = new XAPeerMembers("android/view/ViewGroup$OnHierarchyChangeListener", typeof(ViewGroup.IOnHierarchyChangeListenerInvoker));

			// Token: 0x0400041B RID: 1051
			private IntPtr class_ref;

			// Token: 0x0400041C RID: 1052
			private static Delegate cb_onChildViewAdded_Landroid_view_View_Landroid_view_View_;

			// Token: 0x0400041D RID: 1053
			private IntPtr id_onChildViewAdded_Landroid_view_View_Landroid_view_View_;

			// Token: 0x0400041E RID: 1054
			private static Delegate cb_onChildViewRemoved_Landroid_view_View_Landroid_view_View_;

			// Token: 0x0400041F RID: 1055
			private IntPtr id_onChildViewRemoved_Landroid_view_View_Landroid_view_View_;
		}
	}
}
