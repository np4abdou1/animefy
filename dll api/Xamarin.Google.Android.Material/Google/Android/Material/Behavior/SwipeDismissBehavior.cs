using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Android.Views;
using AndroidX.CoordinatorLayout.Widget;
using Java.Interop;
using Java.Lang;

namespace Google.Android.Material.Behavior
{
	// Token: 0x02000057 RID: 87
	[Register("com/google/android/material/behavior/SwipeDismissBehavior", DoNotGenerateAcw = true)]
	[JavaTypeParameters(new string[]
	{
		"V extends android.view.View"
	})]
	public class SwipeDismissBehavior : CoordinatorLayout.Behavior
	{
		// Token: 0x170000A7 RID: 167
		// (get) Token: 0x060003F7 RID: 1015 RVA: 0x0000B6B8 File Offset: 0x000098B8
		internal static IntPtr class_ref
		{
			get
			{
				return SwipeDismissBehavior._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170000A8 RID: 168
		// (get) Token: 0x060003F8 RID: 1016 RVA: 0x0000B6DC File Offset: 0x000098DC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return SwipeDismissBehavior._members;
			}
		}

		// Token: 0x170000A9 RID: 169
		// (get) Token: 0x060003F9 RID: 1017 RVA: 0x0000B6E4 File Offset: 0x000098E4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return SwipeDismissBehavior._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170000AA RID: 170
		// (get) Token: 0x060003FA RID: 1018 RVA: 0x0000B708 File Offset: 0x00009908
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return SwipeDismissBehavior._members.ManagedPeerType;
			}
		}

		// Token: 0x060003FB RID: 1019 RVA: 0x000092AC File Offset: 0x000074AC
		protected SwipeDismissBehavior(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x060003FC RID: 1020 RVA: 0x0000B714 File Offset: 0x00009914
		[Register(".ctor", "()V", "")]
		public SwipeDismissBehavior() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			base.SetHandle(SwipeDismissBehavior._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
			SwipeDismissBehavior._members.InstanceMethods.FinishCreateInstance("()V", this, null);
		}

		// Token: 0x060003FD RID: 1021 RVA: 0x0000B782 File Offset: 0x00009982
		private static Delegate GetGetDragStateHandler()
		{
			if (SwipeDismissBehavior.cb_getDragState == null)
			{
				SwipeDismissBehavior.cb_getDragState = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(SwipeDismissBehavior.n_GetDragState));
			}
			return SwipeDismissBehavior.cb_getDragState;
		}

		// Token: 0x060003FE RID: 1022 RVA: 0x0000B7A6 File Offset: 0x000099A6
		private static int n_GetDragState(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<SwipeDismissBehavior>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).DragState;
		}

		// Token: 0x170000AB RID: 171
		// (get) Token: 0x060003FF RID: 1023 RVA: 0x0000B7B5 File Offset: 0x000099B5
		public virtual int DragState
		{
			[Register("getDragState", "()I", "GetGetDragStateHandler")]
			get
			{
				return SwipeDismissBehavior._members.InstanceMethods.InvokeVirtualInt32Method("getDragState.()I", this, null);
			}
		}

		// Token: 0x06000400 RID: 1024 RVA: 0x0000B7CE File Offset: 0x000099CE
		private static Delegate GetGetListenerHandler()
		{
			if (SwipeDismissBehavior.cb_getListener == null)
			{
				SwipeDismissBehavior.cb_getListener = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(SwipeDismissBehavior.n_GetListener));
			}
			return SwipeDismissBehavior.cb_getListener;
		}

		// Token: 0x06000401 RID: 1025 RVA: 0x0000B7F2 File Offset: 0x000099F2
		private static IntPtr n_GetListener(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<SwipeDismissBehavior>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Listener);
		}

		// Token: 0x06000402 RID: 1026 RVA: 0x0000B806 File Offset: 0x00009A06
		private static Delegate GetSetListener_Lcom_google_android_material_behavior_SwipeDismissBehavior_OnDismissListener_Handler()
		{
			if (SwipeDismissBehavior.cb_setListener_Lcom_google_android_material_behavior_SwipeDismissBehavior_OnDismissListener_ == null)
			{
				SwipeDismissBehavior.cb_setListener_Lcom_google_android_material_behavior_SwipeDismissBehavior_OnDismissListener_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(SwipeDismissBehavior.n_SetListener_Lcom_google_android_material_behavior_SwipeDismissBehavior_OnDismissListener_));
			}
			return SwipeDismissBehavior.cb_setListener_Lcom_google_android_material_behavior_SwipeDismissBehavior_OnDismissListener_;
		}

		// Token: 0x06000403 RID: 1027 RVA: 0x0000B82C File Offset: 0x00009A2C
		private static void n_SetListener_Lcom_google_android_material_behavior_SwipeDismissBehavior_OnDismissListener_(IntPtr jnienv, IntPtr native__this, IntPtr native_listener)
		{
			SwipeDismissBehavior @object = Java.Lang.Object.GetObject<SwipeDismissBehavior>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			SwipeDismissBehavior.IOnDismissListener object2 = Java.Lang.Object.GetObject<SwipeDismissBehavior.IOnDismissListener>(native_listener, JniHandleOwnership.DoNotTransfer);
			@object.Listener = object2;
		}

		// Token: 0x170000AC RID: 172
		// (get) Token: 0x06000404 RID: 1028 RVA: 0x0000B850 File Offset: 0x00009A50
		// (set) Token: 0x06000405 RID: 1029 RVA: 0x0000B884 File Offset: 0x00009A84
		public unsafe virtual SwipeDismissBehavior.IOnDismissListener Listener
		{
			[Register("getListener", "()Lcom/google/android/material/behavior/SwipeDismissBehavior$OnDismissListener;", "GetGetListenerHandler")]
			get
			{
				return Java.Lang.Object.GetObject<SwipeDismissBehavior.IOnDismissListener>(SwipeDismissBehavior._members.InstanceMethods.InvokeVirtualObjectMethod("getListener.()Lcom/google/android/material/behavior/SwipeDismissBehavior$OnDismissListener;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
			[Register("setListener", "(Lcom/google/android/material/behavior/SwipeDismissBehavior$OnDismissListener;)V", "GetSetListener_Lcom_google_android_material_behavior_SwipeDismissBehavior_OnDismissListener_Handler")]
			set
			{
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((value == null) ? IntPtr.Zero : ((Java.Lang.Object)value).Handle);
					SwipeDismissBehavior._members.InstanceMethods.InvokeVirtualVoidMethod("setListener.(Lcom/google/android/material/behavior/SwipeDismissBehavior$OnDismissListener;)V", this, ptr);
				}
				finally
				{
					GC.KeepAlive(value);
				}
			}
		}

		// Token: 0x06000406 RID: 1030 RVA: 0x0000B8EC File Offset: 0x00009AEC
		private static Delegate GetCanSwipeDismissView_Landroid_view_View_Handler()
		{
			if (SwipeDismissBehavior.cb_canSwipeDismissView_Landroid_view_View_ == null)
			{
				SwipeDismissBehavior.cb_canSwipeDismissView_Landroid_view_View_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(SwipeDismissBehavior.n_CanSwipeDismissView_Landroid_view_View_));
			}
			return SwipeDismissBehavior.cb_canSwipeDismissView_Landroid_view_View_;
		}

		// Token: 0x06000407 RID: 1031 RVA: 0x0000B910 File Offset: 0x00009B10
		private static bool n_CanSwipeDismissView_Landroid_view_View_(IntPtr jnienv, IntPtr native__this, IntPtr native_view)
		{
			SwipeDismissBehavior @object = Java.Lang.Object.GetObject<SwipeDismissBehavior>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			View object2 = Java.Lang.Object.GetObject<View>(native_view, JniHandleOwnership.DoNotTransfer);
			return @object.CanSwipeDismissView(object2);
		}

		// Token: 0x06000408 RID: 1032 RVA: 0x0000B934 File Offset: 0x00009B34
		[Register("canSwipeDismissView", "(Landroid/view/View;)Z", "GetCanSwipeDismissView_Landroid_view_View_Handler")]
		public unsafe virtual bool CanSwipeDismissView(View view)
		{
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((view == null) ? IntPtr.Zero : view.Handle);
				result = SwipeDismissBehavior._members.InstanceMethods.InvokeVirtualBooleanMethod("canSwipeDismissView.(Landroid/view/View;)Z", this, ptr);
			}
			finally
			{
				GC.KeepAlive(view);
			}
			return result;
		}

		// Token: 0x06000409 RID: 1033 RVA: 0x0000B99C File Offset: 0x00009B9C
		private static Delegate GetOnInterceptTouchEvent_Landroidx_coordinatorlayout_widget_CoordinatorLayout_Landroid_view_View_Landroid_view_MotionEvent_Handler()
		{
			if (SwipeDismissBehavior.cb_onInterceptTouchEvent_Landroidx_coordinatorlayout_widget_CoordinatorLayout_Landroid_view_View_Landroid_view_MotionEvent_ == null)
			{
				SwipeDismissBehavior.cb_onInterceptTouchEvent_Landroidx_coordinatorlayout_widget_CoordinatorLayout_Landroid_view_View_Landroid_view_MotionEvent_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLLL_Z(SwipeDismissBehavior.n_OnInterceptTouchEvent_Landroidx_coordinatorlayout_widget_CoordinatorLayout_Landroid_view_View_Landroid_view_MotionEvent_));
			}
			return SwipeDismissBehavior.cb_onInterceptTouchEvent_Landroidx_coordinatorlayout_widget_CoordinatorLayout_Landroid_view_View_Landroid_view_MotionEvent_;
		}

		// Token: 0x0600040A RID: 1034 RVA: 0x0000B9C0 File Offset: 0x00009BC0
		private static bool n_OnInterceptTouchEvent_Landroidx_coordinatorlayout_widget_CoordinatorLayout_Landroid_view_View_Landroid_view_MotionEvent_(IntPtr jnienv, IntPtr native__this, IntPtr native_parent, IntPtr native_child, IntPtr native_e)
		{
			CoordinatorLayout.Behavior @object = Java.Lang.Object.GetObject<SwipeDismissBehavior>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			CoordinatorLayout object2 = Java.Lang.Object.GetObject<CoordinatorLayout>(native_parent, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object3 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_child, JniHandleOwnership.DoNotTransfer);
			MotionEvent object4 = Java.Lang.Object.GetObject<MotionEvent>(native_e, JniHandleOwnership.DoNotTransfer);
			return @object.OnInterceptTouchEvent(object2, object3, object4);
		}

		// Token: 0x0600040B RID: 1035 RVA: 0x0000B9F8 File Offset: 0x00009BF8
		[Register("onInterceptTouchEvent", "(Landroidx/coordinatorlayout/widget/CoordinatorLayout;Landroid/view/View;Landroid/view/MotionEvent;)Z", "GetOnInterceptTouchEvent_Landroidx_coordinatorlayout_widget_CoordinatorLayout_Landroid_view_View_Landroid_view_MotionEvent_Handler")]
		public unsafe override bool OnInterceptTouchEvent(CoordinatorLayout parent, Java.Lang.Object child, MotionEvent e)
		{
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(child);
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((parent == null) ? IntPtr.Zero : parent.Handle);
				ptr[1] = new JniArgumentValue(intPtr);
				ptr[2] = new JniArgumentValue((e == null) ? IntPtr.Zero : e.Handle);
				result = SwipeDismissBehavior._members.InstanceMethods.InvokeVirtualBooleanMethod("onInterceptTouchEvent.(Landroidx/coordinatorlayout/widget/CoordinatorLayout;Landroid/view/View;Landroid/view/MotionEvent;)Z", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(parent);
				GC.KeepAlive(child);
				GC.KeepAlive(e);
			}
			return result;
		}

		// Token: 0x0600040C RID: 1036 RVA: 0x0000BAB0 File Offset: 0x00009CB0
		private static Delegate GetOnLayoutChild_Landroidx_coordinatorlayout_widget_CoordinatorLayout_Landroid_view_View_IHandler()
		{
			if (SwipeDismissBehavior.cb_onLayoutChild_Landroidx_coordinatorlayout_widget_CoordinatorLayout_Landroid_view_View_I == null)
			{
				SwipeDismissBehavior.cb_onLayoutChild_Landroidx_coordinatorlayout_widget_CoordinatorLayout_Landroid_view_View_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLLI_Z(SwipeDismissBehavior.n_OnLayoutChild_Landroidx_coordinatorlayout_widget_CoordinatorLayout_Landroid_view_View_I));
			}
			return SwipeDismissBehavior.cb_onLayoutChild_Landroidx_coordinatorlayout_widget_CoordinatorLayout_Landroid_view_View_I;
		}

		// Token: 0x0600040D RID: 1037 RVA: 0x0000BAD4 File Offset: 0x00009CD4
		private static bool n_OnLayoutChild_Landroidx_coordinatorlayout_widget_CoordinatorLayout_Landroid_view_View_I(IntPtr jnienv, IntPtr native__this, IntPtr native_parent, IntPtr native_child, int layoutDirection)
		{
			CoordinatorLayout.Behavior @object = Java.Lang.Object.GetObject<SwipeDismissBehavior>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			CoordinatorLayout object2 = Java.Lang.Object.GetObject<CoordinatorLayout>(native_parent, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object3 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_child, JniHandleOwnership.DoNotTransfer);
			return @object.OnLayoutChild(object2, object3, layoutDirection);
		}

		// Token: 0x0600040E RID: 1038 RVA: 0x0000BB04 File Offset: 0x00009D04
		[Register("onLayoutChild", "(Landroidx/coordinatorlayout/widget/CoordinatorLayout;Landroid/view/View;I)Z", "GetOnLayoutChild_Landroidx_coordinatorlayout_widget_CoordinatorLayout_Landroid_view_View_IHandler")]
		public unsafe override bool OnLayoutChild(CoordinatorLayout parent, Java.Lang.Object child, int layoutDirection)
		{
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(child);
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((parent == null) ? IntPtr.Zero : parent.Handle);
				ptr[1] = new JniArgumentValue(intPtr);
				ptr[2] = new JniArgumentValue(layoutDirection);
				result = SwipeDismissBehavior._members.InstanceMethods.InvokeVirtualBooleanMethod("onLayoutChild.(Landroidx/coordinatorlayout/widget/CoordinatorLayout;Landroid/view/View;I)Z", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(parent);
				GC.KeepAlive(child);
			}
			return result;
		}

		// Token: 0x0600040F RID: 1039 RVA: 0x0000BBA8 File Offset: 0x00009DA8
		private static Delegate GetOnTouchEvent_Landroidx_coordinatorlayout_widget_CoordinatorLayout_Landroid_view_View_Landroid_view_MotionEvent_Handler()
		{
			if (SwipeDismissBehavior.cb_onTouchEvent_Landroidx_coordinatorlayout_widget_CoordinatorLayout_Landroid_view_View_Landroid_view_MotionEvent_ == null)
			{
				SwipeDismissBehavior.cb_onTouchEvent_Landroidx_coordinatorlayout_widget_CoordinatorLayout_Landroid_view_View_Landroid_view_MotionEvent_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLLL_Z(SwipeDismissBehavior.n_OnTouchEvent_Landroidx_coordinatorlayout_widget_CoordinatorLayout_Landroid_view_View_Landroid_view_MotionEvent_));
			}
			return SwipeDismissBehavior.cb_onTouchEvent_Landroidx_coordinatorlayout_widget_CoordinatorLayout_Landroid_view_View_Landroid_view_MotionEvent_;
		}

		// Token: 0x06000410 RID: 1040 RVA: 0x0000BBCC File Offset: 0x00009DCC
		private static bool n_OnTouchEvent_Landroidx_coordinatorlayout_widget_CoordinatorLayout_Landroid_view_View_Landroid_view_MotionEvent_(IntPtr jnienv, IntPtr native__this, IntPtr native_parent, IntPtr native_child, IntPtr native_e)
		{
			CoordinatorLayout.Behavior @object = Java.Lang.Object.GetObject<SwipeDismissBehavior>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			CoordinatorLayout object2 = Java.Lang.Object.GetObject<CoordinatorLayout>(native_parent, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object3 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_child, JniHandleOwnership.DoNotTransfer);
			MotionEvent object4 = Java.Lang.Object.GetObject<MotionEvent>(native_e, JniHandleOwnership.DoNotTransfer);
			return @object.OnTouchEvent(object2, object3, object4);
		}

		// Token: 0x06000411 RID: 1041 RVA: 0x0000BC04 File Offset: 0x00009E04
		[Register("onTouchEvent", "(Landroidx/coordinatorlayout/widget/CoordinatorLayout;Landroid/view/View;Landroid/view/MotionEvent;)Z", "GetOnTouchEvent_Landroidx_coordinatorlayout_widget_CoordinatorLayout_Landroid_view_View_Landroid_view_MotionEvent_Handler")]
		public unsafe override bool OnTouchEvent(CoordinatorLayout parent, Java.Lang.Object child, MotionEvent e)
		{
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(child);
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((parent == null) ? IntPtr.Zero : parent.Handle);
				ptr[1] = new JniArgumentValue(intPtr);
				ptr[2] = new JniArgumentValue((e == null) ? IntPtr.Zero : e.Handle);
				result = SwipeDismissBehavior._members.InstanceMethods.InvokeVirtualBooleanMethod("onTouchEvent.(Landroidx/coordinatorlayout/widget/CoordinatorLayout;Landroid/view/View;Landroid/view/MotionEvent;)Z", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(parent);
				GC.KeepAlive(child);
				GC.KeepAlive(e);
			}
			return result;
		}

		// Token: 0x06000412 RID: 1042 RVA: 0x0000BCBC File Offset: 0x00009EBC
		private static Delegate GetSetDragDismissDistance_FHandler()
		{
			if (SwipeDismissBehavior.cb_setDragDismissDistance_F == null)
			{
				SwipeDismissBehavior.cb_setDragDismissDistance_F = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPF_V(SwipeDismissBehavior.n_SetDragDismissDistance_F));
			}
			return SwipeDismissBehavior.cb_setDragDismissDistance_F;
		}

		// Token: 0x06000413 RID: 1043 RVA: 0x0000BCE0 File Offset: 0x00009EE0
		private static void n_SetDragDismissDistance_F(IntPtr jnienv, IntPtr native__this, float distance)
		{
			Java.Lang.Object.GetObject<SwipeDismissBehavior>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SetDragDismissDistance(distance);
		}

		// Token: 0x06000414 RID: 1044 RVA: 0x0000BCF0 File Offset: 0x00009EF0
		[Register("setDragDismissDistance", "(F)V", "GetSetDragDismissDistance_FHandler")]
		public unsafe virtual void SetDragDismissDistance(float distance)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(distance);
			SwipeDismissBehavior._members.InstanceMethods.InvokeVirtualVoidMethod("setDragDismissDistance.(F)V", this, ptr);
		}

		// Token: 0x06000415 RID: 1045 RVA: 0x0000BD2B File Offset: 0x00009F2B
		private static Delegate GetSetEndAlphaSwipeDistance_FHandler()
		{
			if (SwipeDismissBehavior.cb_setEndAlphaSwipeDistance_F == null)
			{
				SwipeDismissBehavior.cb_setEndAlphaSwipeDistance_F = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPF_V(SwipeDismissBehavior.n_SetEndAlphaSwipeDistance_F));
			}
			return SwipeDismissBehavior.cb_setEndAlphaSwipeDistance_F;
		}

		// Token: 0x06000416 RID: 1046 RVA: 0x0000BD4F File Offset: 0x00009F4F
		private static void n_SetEndAlphaSwipeDistance_F(IntPtr jnienv, IntPtr native__this, float fraction)
		{
			Java.Lang.Object.GetObject<SwipeDismissBehavior>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SetEndAlphaSwipeDistance(fraction);
		}

		// Token: 0x06000417 RID: 1047 RVA: 0x0000BD60 File Offset: 0x00009F60
		[Register("setEndAlphaSwipeDistance", "(F)V", "GetSetEndAlphaSwipeDistance_FHandler")]
		public unsafe virtual void SetEndAlphaSwipeDistance(float fraction)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(fraction);
			SwipeDismissBehavior._members.InstanceMethods.InvokeVirtualVoidMethod("setEndAlphaSwipeDistance.(F)V", this, ptr);
		}

		// Token: 0x06000418 RID: 1048 RVA: 0x0000BD9B File Offset: 0x00009F9B
		private static Delegate GetSetSensitivity_FHandler()
		{
			if (SwipeDismissBehavior.cb_setSensitivity_F == null)
			{
				SwipeDismissBehavior.cb_setSensitivity_F = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPF_V(SwipeDismissBehavior.n_SetSensitivity_F));
			}
			return SwipeDismissBehavior.cb_setSensitivity_F;
		}

		// Token: 0x06000419 RID: 1049 RVA: 0x0000BDBF File Offset: 0x00009FBF
		private static void n_SetSensitivity_F(IntPtr jnienv, IntPtr native__this, float sensitivity)
		{
			Java.Lang.Object.GetObject<SwipeDismissBehavior>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SetSensitivity(sensitivity);
		}

		// Token: 0x0600041A RID: 1050 RVA: 0x0000BDD0 File Offset: 0x00009FD0
		[Register("setSensitivity", "(F)V", "GetSetSensitivity_FHandler")]
		public unsafe virtual void SetSensitivity(float sensitivity)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(sensitivity);
			SwipeDismissBehavior._members.InstanceMethods.InvokeVirtualVoidMethod("setSensitivity.(F)V", this, ptr);
		}

		// Token: 0x0600041B RID: 1051 RVA: 0x0000BE0B File Offset: 0x0000A00B
		private static Delegate GetSetStartAlphaSwipeDistance_FHandler()
		{
			if (SwipeDismissBehavior.cb_setStartAlphaSwipeDistance_F == null)
			{
				SwipeDismissBehavior.cb_setStartAlphaSwipeDistance_F = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPF_V(SwipeDismissBehavior.n_SetStartAlphaSwipeDistance_F));
			}
			return SwipeDismissBehavior.cb_setStartAlphaSwipeDistance_F;
		}

		// Token: 0x0600041C RID: 1052 RVA: 0x0000BE2F File Offset: 0x0000A02F
		private static void n_SetStartAlphaSwipeDistance_F(IntPtr jnienv, IntPtr native__this, float fraction)
		{
			Java.Lang.Object.GetObject<SwipeDismissBehavior>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SetStartAlphaSwipeDistance(fraction);
		}

		// Token: 0x0600041D RID: 1053 RVA: 0x0000BE40 File Offset: 0x0000A040
		[Register("setStartAlphaSwipeDistance", "(F)V", "GetSetStartAlphaSwipeDistance_FHandler")]
		public unsafe virtual void SetStartAlphaSwipeDistance(float fraction)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(fraction);
			SwipeDismissBehavior._members.InstanceMethods.InvokeVirtualVoidMethod("setStartAlphaSwipeDistance.(F)V", this, ptr);
		}

		// Token: 0x0600041E RID: 1054 RVA: 0x0000BE7B File Offset: 0x0000A07B
		private static Delegate GetSetSwipeDirection_IHandler()
		{
			if (SwipeDismissBehavior.cb_setSwipeDirection_I == null)
			{
				SwipeDismissBehavior.cb_setSwipeDirection_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_V(SwipeDismissBehavior.n_SetSwipeDirection_I));
			}
			return SwipeDismissBehavior.cb_setSwipeDirection_I;
		}

		// Token: 0x0600041F RID: 1055 RVA: 0x0000BE9F File Offset: 0x0000A09F
		private static void n_SetSwipeDirection_I(IntPtr jnienv, IntPtr native__this, int direction)
		{
			Java.Lang.Object.GetObject<SwipeDismissBehavior>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SetSwipeDirection(direction);
		}

		// Token: 0x06000420 RID: 1056 RVA: 0x0000BEB0 File Offset: 0x0000A0B0
		[Register("setSwipeDirection", "(I)V", "GetSetSwipeDirection_IHandler")]
		public unsafe virtual void SetSwipeDirection(int direction)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(direction);
			SwipeDismissBehavior._members.InstanceMethods.InvokeVirtualVoidMethod("setSwipeDirection.(I)V", this, ptr);
		}

		// Token: 0x06000421 RID: 1057 RVA: 0x0000BEEB File Offset: 0x0000A0EB
		private SwipeDismissBehavior.IOnDismissListenerImplementor __CreateIOnDismissListenerImplementor()
		{
			return new SwipeDismissBehavior.IOnDismissListenerImplementor(this);
		}

		// Token: 0x040000EB RID: 235
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/google/android/material/behavior/SwipeDismissBehavior", typeof(SwipeDismissBehavior));

		// Token: 0x040000EC RID: 236
		private static Delegate cb_getDragState;

		// Token: 0x040000ED RID: 237
		private static Delegate cb_getListener;

		// Token: 0x040000EE RID: 238
		private static Delegate cb_setListener_Lcom_google_android_material_behavior_SwipeDismissBehavior_OnDismissListener_;

		// Token: 0x040000EF RID: 239
		private static Delegate cb_canSwipeDismissView_Landroid_view_View_;

		// Token: 0x040000F0 RID: 240
		private static Delegate cb_onInterceptTouchEvent_Landroidx_coordinatorlayout_widget_CoordinatorLayout_Landroid_view_View_Landroid_view_MotionEvent_;

		// Token: 0x040000F1 RID: 241
		private static Delegate cb_onLayoutChild_Landroidx_coordinatorlayout_widget_CoordinatorLayout_Landroid_view_View_I;

		// Token: 0x040000F2 RID: 242
		private static Delegate cb_onTouchEvent_Landroidx_coordinatorlayout_widget_CoordinatorLayout_Landroid_view_View_Landroid_view_MotionEvent_;

		// Token: 0x040000F3 RID: 243
		private static Delegate cb_setDragDismissDistance_F;

		// Token: 0x040000F4 RID: 244
		private static Delegate cb_setEndAlphaSwipeDistance_F;

		// Token: 0x040000F5 RID: 245
		private static Delegate cb_setSensitivity_F;

		// Token: 0x040000F6 RID: 246
		private static Delegate cb_setStartAlphaSwipeDistance_F;

		// Token: 0x040000F7 RID: 247
		private static Delegate cb_setSwipeDirection_I;

		// Token: 0x02000058 RID: 88
		[Register("com/google/android/material/behavior/SwipeDismissBehavior$OnDismissListener", "", "Google.Android.Material.Behavior.SwipeDismissBehavior/IOnDismissListenerInvoker")]
		public interface IOnDismissListener : IJavaObject, IDisposable, IJavaPeerable
		{
			// Token: 0x06000423 RID: 1059
			[Register("onDismiss", "(Landroid/view/View;)V", "GetOnDismiss_Landroid_view_View_Handler:Google.Android.Material.Behavior.SwipeDismissBehavior/IOnDismissListenerInvoker, Xamarin.Google.Android.Material")]
			void OnDismiss(View view);

			// Token: 0x06000424 RID: 1060
			[Register("onDragStateChanged", "(I)V", "GetOnDragStateChanged_IHandler:Google.Android.Material.Behavior.SwipeDismissBehavior/IOnDismissListenerInvoker, Xamarin.Google.Android.Material")]
			void OnDragStateChanged(int state);
		}

		// Token: 0x02000059 RID: 89
		[Register("com/google/android/material/behavior/SwipeDismissBehavior$OnDismissListener", DoNotGenerateAcw = true)]
		internal class IOnDismissListenerInvoker : Java.Lang.Object, SwipeDismissBehavior.IOnDismissListener, IJavaObject, IDisposable, IJavaPeerable
		{
			// Token: 0x170000AD RID: 173
			// (get) Token: 0x06000425 RID: 1061 RVA: 0x0000BF10 File Offset: 0x0000A110
			private static IntPtr java_class_ref
			{
				get
				{
					return SwipeDismissBehavior.IOnDismissListenerInvoker._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x170000AE RID: 174
			// (get) Token: 0x06000426 RID: 1062 RVA: 0x0000BF34 File Offset: 0x0000A134
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return SwipeDismissBehavior.IOnDismissListenerInvoker._members;
				}
			}

			// Token: 0x170000AF RID: 175
			// (get) Token: 0x06000427 RID: 1063 RVA: 0x0000BF3B File Offset: 0x0000A13B
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return this.class_ref;
				}
			}

			// Token: 0x170000B0 RID: 176
			// (get) Token: 0x06000428 RID: 1064 RVA: 0x0000BF43 File Offset: 0x0000A143
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return SwipeDismissBehavior.IOnDismissListenerInvoker._members.ManagedPeerType;
				}
			}

			// Token: 0x06000429 RID: 1065 RVA: 0x0000BF4F File Offset: 0x0000A14F
			public static SwipeDismissBehavior.IOnDismissListener GetObject(IntPtr handle, JniHandleOwnership transfer)
			{
				return Java.Lang.Object.GetObject<SwipeDismissBehavior.IOnDismissListener>(handle, transfer);
			}

			// Token: 0x0600042A RID: 1066 RVA: 0x0000BF58 File Offset: 0x0000A158
			private static IntPtr Validate(IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf(handle, SwipeDismissBehavior.IOnDismissListenerInvoker.java_class_ref))
				{
					throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'com.google.android.material.behavior.SwipeDismissBehavior.OnDismissListener'.");
				}
				return handle;
			}

			// Token: 0x0600042B RID: 1067 RVA: 0x0000BF83 File Offset: 0x0000A183
			protected override void Dispose(bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
				{
					JNIEnv.DeleteGlobalRef(this.class_ref);
				}
				this.class_ref = IntPtr.Zero;
				base.Dispose(disposing);
			}

			// Token: 0x0600042C RID: 1068 RVA: 0x0000BFB4 File Offset: 0x0000A1B4
			public IOnDismissListenerInvoker(IntPtr handle, JniHandleOwnership transfer) : base(SwipeDismissBehavior.IOnDismissListenerInvoker.Validate(handle), transfer)
			{
				IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
				this.class_ref = JNIEnv.NewGlobalRef(objectClass);
				JNIEnv.DeleteLocalRef(objectClass);
			}

			// Token: 0x0600042D RID: 1069 RVA: 0x0000BFEC File Offset: 0x0000A1EC
			private static Delegate GetOnDismiss_Landroid_view_View_Handler()
			{
				if (SwipeDismissBehavior.IOnDismissListenerInvoker.cb_onDismiss_Landroid_view_View_ == null)
				{
					SwipeDismissBehavior.IOnDismissListenerInvoker.cb_onDismiss_Landroid_view_View_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(SwipeDismissBehavior.IOnDismissListenerInvoker.n_OnDismiss_Landroid_view_View_));
				}
				return SwipeDismissBehavior.IOnDismissListenerInvoker.cb_onDismiss_Landroid_view_View_;
			}

			// Token: 0x0600042E RID: 1070 RVA: 0x0000C010 File Offset: 0x0000A210
			private static void n_OnDismiss_Landroid_view_View_(IntPtr jnienv, IntPtr native__this, IntPtr native_view)
			{
				SwipeDismissBehavior.IOnDismissListener @object = Java.Lang.Object.GetObject<SwipeDismissBehavior.IOnDismissListener>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				View object2 = Java.Lang.Object.GetObject<View>(native_view, JniHandleOwnership.DoNotTransfer);
				@object.OnDismiss(object2);
			}

			// Token: 0x0600042F RID: 1071 RVA: 0x0000C034 File Offset: 0x0000A234
			public unsafe void OnDismiss(View view)
			{
				if (this.id_onDismiss_Landroid_view_View_ == IntPtr.Zero)
				{
					this.id_onDismiss_Landroid_view_View_ = JNIEnv.GetMethodID(this.class_ref, "onDismiss", "(Landroid/view/View;)V");
				}
				JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
				*ptr = new JValue((view == null) ? IntPtr.Zero : view.Handle);
				JNIEnv.CallVoidMethod(base.Handle, this.id_onDismiss_Landroid_view_View_, ptr);
			}

			// Token: 0x06000430 RID: 1072 RVA: 0x0000C0A7 File Offset: 0x0000A2A7
			private static Delegate GetOnDragStateChanged_IHandler()
			{
				if (SwipeDismissBehavior.IOnDismissListenerInvoker.cb_onDragStateChanged_I == null)
				{
					SwipeDismissBehavior.IOnDismissListenerInvoker.cb_onDragStateChanged_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_V(SwipeDismissBehavior.IOnDismissListenerInvoker.n_OnDragStateChanged_I));
				}
				return SwipeDismissBehavior.IOnDismissListenerInvoker.cb_onDragStateChanged_I;
			}

			// Token: 0x06000431 RID: 1073 RVA: 0x0000C0CB File Offset: 0x0000A2CB
			private static void n_OnDragStateChanged_I(IntPtr jnienv, IntPtr native__this, int state)
			{
				Java.Lang.Object.GetObject<SwipeDismissBehavior.IOnDismissListener>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).OnDragStateChanged(state);
			}

			// Token: 0x06000432 RID: 1074 RVA: 0x0000C0DC File Offset: 0x0000A2DC
			public unsafe void OnDragStateChanged(int state)
			{
				if (this.id_onDragStateChanged_I == IntPtr.Zero)
				{
					this.id_onDragStateChanged_I = JNIEnv.GetMethodID(this.class_ref, "onDragStateChanged", "(I)V");
				}
				JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
				*ptr = new JValue(state);
				JNIEnv.CallVoidMethod(base.Handle, this.id_onDragStateChanged_I, ptr);
			}

			// Token: 0x040000F8 RID: 248
			private static readonly JniPeerMembers _members = new XAPeerMembers("com/google/android/material/behavior/SwipeDismissBehavior$OnDismissListener", typeof(SwipeDismissBehavior.IOnDismissListenerInvoker));

			// Token: 0x040000F9 RID: 249
			private IntPtr class_ref;

			// Token: 0x040000FA RID: 250
			private static Delegate cb_onDismiss_Landroid_view_View_;

			// Token: 0x040000FB RID: 251
			private IntPtr id_onDismiss_Landroid_view_View_;

			// Token: 0x040000FC RID: 252
			private static Delegate cb_onDragStateChanged_I;

			// Token: 0x040000FD RID: 253
			private IntPtr id_onDragStateChanged_I;
		}

		// Token: 0x0200005A RID: 90
		public class DismissEventArgs : EventArgs
		{
			// Token: 0x06000434 RID: 1076 RVA: 0x0000C15B File Offset: 0x0000A35B
			public DismissEventArgs(View view)
			{
				this.view = view;
			}

			// Token: 0x040000FE RID: 254
			private View view;
		}

		// Token: 0x0200005B RID: 91
		public class DragStateChangedEventArgs : EventArgs
		{
			// Token: 0x06000435 RID: 1077 RVA: 0x0000C16A File Offset: 0x0000A36A
			public DragStateChangedEventArgs(int state)
			{
				this.state = state;
			}

			// Token: 0x040000FF RID: 255
			private int state;
		}

		// Token: 0x0200005C RID: 92
		[Register("mono/com/google/android/material/behavior/SwipeDismissBehavior_OnDismissListenerImplementor")]
		internal sealed class IOnDismissListenerImplementor : Java.Lang.Object, SwipeDismissBehavior.IOnDismissListener, IJavaObject, IDisposable, IJavaPeerable
		{
			// Token: 0x06000436 RID: 1078 RVA: 0x0000C179 File Offset: 0x0000A379
			public IOnDismissListenerImplementor(object sender) : base(JNIEnv.StartCreateInstance("mono/com/google/android/material/behavior/SwipeDismissBehavior_OnDismissListenerImplementor", "()V", Array.Empty<JValue>()), JniHandleOwnership.TransferLocalRef)
			{
				JNIEnv.FinishCreateInstance(base.Handle, "()V", Array.Empty<JValue>());
				this.sender = sender;
			}

			// Token: 0x06000437 RID: 1079 RVA: 0x0000C1B4 File Offset: 0x0000A3B4
			public void OnDismiss(View view)
			{
				EventHandler<SwipeDismissBehavior.DismissEventArgs> onDismissHandler = this.OnDismissHandler;
				if (onDismissHandler != null)
				{
					onDismissHandler(this.sender, new SwipeDismissBehavior.DismissEventArgs(view));
				}
			}

			// Token: 0x06000438 RID: 1080 RVA: 0x0000C1E0 File Offset: 0x0000A3E0
			public void OnDragStateChanged(int state)
			{
				EventHandler<SwipeDismissBehavior.DragStateChangedEventArgs> onDragStateChangedHandler = this.OnDragStateChangedHandler;
				if (onDragStateChangedHandler != null)
				{
					onDragStateChangedHandler(this.sender, new SwipeDismissBehavior.DragStateChangedEventArgs(state));
				}
			}

			// Token: 0x06000439 RID: 1081 RVA: 0x0000C209 File Offset: 0x0000A409
			internal static bool __IsEmpty(SwipeDismissBehavior.IOnDismissListenerImplementor value)
			{
				return value.OnDismissHandler == null && value.OnDragStateChangedHandler == null;
			}

			// Token: 0x04000100 RID: 256
			private object sender;

			// Token: 0x04000101 RID: 257
			public EventHandler<SwipeDismissBehavior.DismissEventArgs> OnDismissHandler;

			// Token: 0x04000102 RID: 258
			public EventHandler<SwipeDismissBehavior.DragStateChangedEventArgs> OnDragStateChangedHandler;
		}
	}
}
