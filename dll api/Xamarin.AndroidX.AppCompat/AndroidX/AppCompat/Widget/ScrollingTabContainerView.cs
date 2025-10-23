using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Animation;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using AndroidX.AppCompat.App;
using Java.Interop;
using Java.Lang;

namespace AndroidX.AppCompat.Widget
{
	// Token: 0x0200006B RID: 107
	[Register("androidx/appcompat/widget/ScrollingTabContainerView", DoNotGenerateAcw = true)]
	public class ScrollingTabContainerView : HorizontalScrollView, AdapterView.IOnItemSelectedListener, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x1700011E RID: 286
		// (get) Token: 0x060007DF RID: 2015 RVA: 0x000148A4 File Offset: 0x00012AA4
		// (set) Token: 0x060007E0 RID: 2016 RVA: 0x000148D4 File Offset: 0x00012AD4
		[Register("mVisAnimListener")]
		protected ScrollingTabContainerView.VisibilityAnimListener MVisAnimListener
		{
			get
			{
				return Java.Lang.Object.GetObject<ScrollingTabContainerView.VisibilityAnimListener>(ScrollingTabContainerView._members.InstanceFields.GetObjectValue("mVisAnimListener.Landroidx/appcompat/widget/ScrollingTabContainerView$VisibilityAnimListener;", this).Handle, JniHandleOwnership.TransferLocalRef);
			}
			set
			{
				IntPtr intPtr = JNIEnv.ToLocalJniHandle(value);
				try
				{
					ScrollingTabContainerView._members.InstanceFields.SetValue("mVisAnimListener.Landroidx/appcompat/widget/ScrollingTabContainerView$VisibilityAnimListener;", this, new JniObjectReference(intPtr, JniObjectReferenceType.Invalid));
				}
				finally
				{
					JNIEnv.DeleteLocalRef(intPtr);
				}
			}
		}

		// Token: 0x1700011F RID: 287
		// (get) Token: 0x060007E1 RID: 2017 RVA: 0x00014920 File Offset: 0x00012B20
		// (set) Token: 0x060007E2 RID: 2018 RVA: 0x00014950 File Offset: 0x00012B50
		[Register("mVisibilityAnim")]
		protected ViewPropertyAnimator MVisibilityAnim
		{
			get
			{
				return Java.Lang.Object.GetObject<ViewPropertyAnimator>(ScrollingTabContainerView._members.InstanceFields.GetObjectValue("mVisibilityAnim.Landroid/view/ViewPropertyAnimator;", this).Handle, JniHandleOwnership.TransferLocalRef);
			}
			set
			{
				IntPtr intPtr = JNIEnv.ToLocalJniHandle(value);
				try
				{
					ScrollingTabContainerView._members.InstanceFields.SetValue("mVisibilityAnim.Landroid/view/ViewPropertyAnimator;", this, new JniObjectReference(intPtr, JniObjectReferenceType.Invalid));
				}
				finally
				{
					JNIEnv.DeleteLocalRef(intPtr);
				}
			}
		}

		// Token: 0x17000120 RID: 288
		// (get) Token: 0x060007E3 RID: 2019 RVA: 0x0001499C File Offset: 0x00012B9C
		internal static IntPtr class_ref
		{
			get
			{
				return ScrollingTabContainerView._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000121 RID: 289
		// (get) Token: 0x060007E4 RID: 2020 RVA: 0x000149C0 File Offset: 0x00012BC0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return ScrollingTabContainerView._members;
			}
		}

		// Token: 0x17000122 RID: 290
		// (get) Token: 0x060007E5 RID: 2021 RVA: 0x000149C8 File Offset: 0x00012BC8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return ScrollingTabContainerView._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000123 RID: 291
		// (get) Token: 0x060007E6 RID: 2022 RVA: 0x000149EC File Offset: 0x00012BEC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return ScrollingTabContainerView._members.ManagedPeerType;
			}
		}

		// Token: 0x060007E7 RID: 2023 RVA: 0x000149F8 File Offset: 0x00012BF8
		protected ScrollingTabContainerView(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x060007E8 RID: 2024 RVA: 0x00014A04 File Offset: 0x00012C04
		[Register(".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe ScrollingTabContainerView(Context context) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((context == null) ? IntPtr.Zero : context.Handle);
				base.SetHandle(ScrollingTabContainerView._members.InstanceMethods.StartCreateInstance("(Landroid/content/Context;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				ScrollingTabContainerView._members.InstanceMethods.FinishCreateInstance("(Landroid/content/Context;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(context);
			}
		}

		// Token: 0x060007E9 RID: 2025 RVA: 0x00014AB4 File Offset: 0x00012CB4
		private static Delegate GetAddTab_Landroidx_appcompat_app_ActionBar_Tab_ZHandler()
		{
			if (ScrollingTabContainerView.cb_addTab_Landroidx_appcompat_app_ActionBar_Tab_Z == null)
			{
				ScrollingTabContainerView.cb_addTab_Landroidx_appcompat_app_ActionBar_Tab_Z = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLZ_V(ScrollingTabContainerView.n_AddTab_Landroidx_appcompat_app_ActionBar_Tab_Z));
			}
			return ScrollingTabContainerView.cb_addTab_Landroidx_appcompat_app_ActionBar_Tab_Z;
		}

		// Token: 0x060007EA RID: 2026 RVA: 0x00014AD8 File Offset: 0x00012CD8
		private static void n_AddTab_Landroidx_appcompat_app_ActionBar_Tab_Z(IntPtr jnienv, IntPtr native__this, IntPtr native_tab, bool setSelected)
		{
			ScrollingTabContainerView @object = Java.Lang.Object.GetObject<ScrollingTabContainerView>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ActionBar.Tab object2 = Java.Lang.Object.GetObject<ActionBar.Tab>(native_tab, JniHandleOwnership.DoNotTransfer);
			@object.AddTab(object2, setSelected);
		}

		// Token: 0x060007EB RID: 2027 RVA: 0x00014AFC File Offset: 0x00012CFC
		[Register("addTab", "(Landroidx/appcompat/app/ActionBar$Tab;Z)V", "GetAddTab_Landroidx_appcompat_app_ActionBar_Tab_ZHandler")]
		public unsafe virtual void AddTab(ActionBar.Tab tab, bool setSelected)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((tab == null) ? IntPtr.Zero : tab.Handle);
				ptr[1] = new JniArgumentValue(setSelected);
				ScrollingTabContainerView._members.InstanceMethods.InvokeVirtualVoidMethod("addTab.(Landroidx/appcompat/app/ActionBar$Tab;Z)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(tab);
			}
		}

		// Token: 0x060007EC RID: 2028 RVA: 0x00014B74 File Offset: 0x00012D74
		private static Delegate GetAddTab_Landroidx_appcompat_app_ActionBar_Tab_IZHandler()
		{
			if (ScrollingTabContainerView.cb_addTab_Landroidx_appcompat_app_ActionBar_Tab_IZ == null)
			{
				ScrollingTabContainerView.cb_addTab_Landroidx_appcompat_app_ActionBar_Tab_IZ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLIZ_V(ScrollingTabContainerView.n_AddTab_Landroidx_appcompat_app_ActionBar_Tab_IZ));
			}
			return ScrollingTabContainerView.cb_addTab_Landroidx_appcompat_app_ActionBar_Tab_IZ;
		}

		// Token: 0x060007ED RID: 2029 RVA: 0x00014B98 File Offset: 0x00012D98
		private static void n_AddTab_Landroidx_appcompat_app_ActionBar_Tab_IZ(IntPtr jnienv, IntPtr native__this, IntPtr native_tab, int position, bool setSelected)
		{
			ScrollingTabContainerView @object = Java.Lang.Object.GetObject<ScrollingTabContainerView>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ActionBar.Tab object2 = Java.Lang.Object.GetObject<ActionBar.Tab>(native_tab, JniHandleOwnership.DoNotTransfer);
			@object.AddTab(object2, position, setSelected);
		}

		// Token: 0x060007EE RID: 2030 RVA: 0x00014BC0 File Offset: 0x00012DC0
		[Register("addTab", "(Landroidx/appcompat/app/ActionBar$Tab;IZ)V", "GetAddTab_Landroidx_appcompat_app_ActionBar_Tab_IZHandler")]
		public unsafe virtual void AddTab(ActionBar.Tab tab, int position, bool setSelected)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((tab == null) ? IntPtr.Zero : tab.Handle);
				ptr[1] = new JniArgumentValue(position);
				ptr[2] = new JniArgumentValue(setSelected);
				ScrollingTabContainerView._members.InstanceMethods.InvokeVirtualVoidMethod("addTab.(Landroidx/appcompat/app/ActionBar$Tab;IZ)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(tab);
			}
		}

		// Token: 0x060007EF RID: 2031 RVA: 0x00014C4C File Offset: 0x00012E4C
		private static Delegate GetAnimateToTab_IHandler()
		{
			if (ScrollingTabContainerView.cb_animateToTab_I == null)
			{
				ScrollingTabContainerView.cb_animateToTab_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_V(ScrollingTabContainerView.n_AnimateToTab_I));
			}
			return ScrollingTabContainerView.cb_animateToTab_I;
		}

		// Token: 0x060007F0 RID: 2032 RVA: 0x00014C70 File Offset: 0x00012E70
		private static void n_AnimateToTab_I(IntPtr jnienv, IntPtr native__this, int position)
		{
			Java.Lang.Object.GetObject<ScrollingTabContainerView>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).AnimateToTab(position);
		}

		// Token: 0x060007F1 RID: 2033 RVA: 0x00014C80 File Offset: 0x00012E80
		[Register("animateToTab", "(I)V", "GetAnimateToTab_IHandler")]
		public unsafe virtual void AnimateToTab(int position)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(position);
			ScrollingTabContainerView._members.InstanceMethods.InvokeVirtualVoidMethod("animateToTab.(I)V", this, ptr);
		}

		// Token: 0x060007F2 RID: 2034 RVA: 0x00014CBB File Offset: 0x00012EBB
		private static Delegate GetAnimateToVisibility_IHandler()
		{
			if (ScrollingTabContainerView.cb_animateToVisibility_I == null)
			{
				ScrollingTabContainerView.cb_animateToVisibility_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_V(ScrollingTabContainerView.n_AnimateToVisibility_I));
			}
			return ScrollingTabContainerView.cb_animateToVisibility_I;
		}

		// Token: 0x060007F3 RID: 2035 RVA: 0x00014CDF File Offset: 0x00012EDF
		private static void n_AnimateToVisibility_I(IntPtr jnienv, IntPtr native__this, int visibility)
		{
			Java.Lang.Object.GetObject<ScrollingTabContainerView>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).AnimateToVisibility(visibility);
		}

		// Token: 0x060007F4 RID: 2036 RVA: 0x00014CF0 File Offset: 0x00012EF0
		[Register("animateToVisibility", "(I)V", "GetAnimateToVisibility_IHandler")]
		public unsafe virtual void AnimateToVisibility(int visibility)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(visibility);
			ScrollingTabContainerView._members.InstanceMethods.InvokeVirtualVoidMethod("animateToVisibility.(I)V", this, ptr);
		}

		// Token: 0x060007F5 RID: 2037 RVA: 0x00014D2B File Offset: 0x00012F2B
		private static Delegate GetOnAttachedToWindowHandler()
		{
			if (ScrollingTabContainerView.cb_onAttachedToWindow == null)
			{
				ScrollingTabContainerView.cb_onAttachedToWindow = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(ScrollingTabContainerView.n_OnAttachedToWindow));
			}
			return ScrollingTabContainerView.cb_onAttachedToWindow;
		}

		// Token: 0x060007F6 RID: 2038 RVA: 0x00014D4F File Offset: 0x00012F4F
		private static void n_OnAttachedToWindow(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<ScrollingTabContainerView>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).OnAttachedToWindow();
		}

		// Token: 0x060007F7 RID: 2039 RVA: 0x00014D5E File Offset: 0x00012F5E
		[Register("onAttachedToWindow", "()V", "GetOnAttachedToWindowHandler")]
		public new virtual void OnAttachedToWindow()
		{
			ScrollingTabContainerView._members.InstanceMethods.InvokeVirtualVoidMethod("onAttachedToWindow.()V", this, null);
		}

		// Token: 0x060007F8 RID: 2040 RVA: 0x00014D77 File Offset: 0x00012F77
		private static Delegate GetOnDetachedFromWindowHandler()
		{
			if (ScrollingTabContainerView.cb_onDetachedFromWindow == null)
			{
				ScrollingTabContainerView.cb_onDetachedFromWindow = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(ScrollingTabContainerView.n_OnDetachedFromWindow));
			}
			return ScrollingTabContainerView.cb_onDetachedFromWindow;
		}

		// Token: 0x060007F9 RID: 2041 RVA: 0x00014D9B File Offset: 0x00012F9B
		private static void n_OnDetachedFromWindow(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<ScrollingTabContainerView>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).OnDetachedFromWindow();
		}

		// Token: 0x060007FA RID: 2042 RVA: 0x00014DAA File Offset: 0x00012FAA
		[Register("onDetachedFromWindow", "()V", "GetOnDetachedFromWindowHandler")]
		public new virtual void OnDetachedFromWindow()
		{
			ScrollingTabContainerView._members.InstanceMethods.InvokeVirtualVoidMethod("onDetachedFromWindow.()V", this, null);
		}

		// Token: 0x060007FB RID: 2043 RVA: 0x00014DC3 File Offset: 0x00012FC3
		private static Delegate GetOnItemSelected_Landroid_widget_AdapterView_Landroid_view_View_IJHandler()
		{
			if (ScrollingTabContainerView.cb_onItemSelected_Landroid_widget_AdapterView_Landroid_view_View_IJ == null)
			{
				ScrollingTabContainerView.cb_onItemSelected_Landroid_widget_AdapterView_Landroid_view_View_IJ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLLIJ_V(ScrollingTabContainerView.n_OnItemSelected_Landroid_widget_AdapterView_Landroid_view_View_IJ));
			}
			return ScrollingTabContainerView.cb_onItemSelected_Landroid_widget_AdapterView_Landroid_view_View_IJ;
		}

		// Token: 0x060007FC RID: 2044 RVA: 0x00014DE8 File Offset: 0x00012FE8
		private static void n_OnItemSelected_Landroid_widget_AdapterView_Landroid_view_View_IJ(IntPtr jnienv, IntPtr native__this, IntPtr native_adapterView, IntPtr native_view, int position, long id)
		{
			ScrollingTabContainerView @object = Java.Lang.Object.GetObject<ScrollingTabContainerView>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			AdapterView object2 = Java.Lang.Object.GetObject<AdapterView>(native_adapterView, JniHandleOwnership.DoNotTransfer);
			View object3 = Java.Lang.Object.GetObject<View>(native_view, JniHandleOwnership.DoNotTransfer);
			@object.OnItemSelected(object2, object3, position, id);
		}

		// Token: 0x060007FD RID: 2045 RVA: 0x00014E18 File Offset: 0x00013018
		[Register("onItemSelected", "(Landroid/widget/AdapterView;Landroid/view/View;IJ)V", "GetOnItemSelected_Landroid_widget_AdapterView_Landroid_view_View_IJHandler")]
		public unsafe virtual void OnItemSelected(AdapterView adapterView, View view, int position, long id)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((adapterView == null) ? IntPtr.Zero : adapterView.Handle);
				ptr[1] = new JniArgumentValue((view == null) ? IntPtr.Zero : view.Handle);
				ptr[2] = new JniArgumentValue(position);
				ptr[3] = new JniArgumentValue(id);
				ScrollingTabContainerView._members.InstanceMethods.InvokeVirtualVoidMethod("onItemSelected.(Landroid/widget/AdapterView;Landroid/view/View;IJ)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(adapterView);
				GC.KeepAlive(view);
			}
		}

		// Token: 0x060007FE RID: 2046 RVA: 0x00014ED0 File Offset: 0x000130D0
		private static Delegate GetOnMeasure_IIHandler()
		{
			if (ScrollingTabContainerView.cb_onMeasure_II == null)
			{
				ScrollingTabContainerView.cb_onMeasure_II = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPII_V(ScrollingTabContainerView.n_OnMeasure_II));
			}
			return ScrollingTabContainerView.cb_onMeasure_II;
		}

		// Token: 0x060007FF RID: 2047 RVA: 0x00014EF4 File Offset: 0x000130F4
		private static void n_OnMeasure_II(IntPtr jnienv, IntPtr native__this, int widthMeasureSpec, int heightMeasureSpec)
		{
			Java.Lang.Object.GetObject<ScrollingTabContainerView>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).OnMeasure(widthMeasureSpec, heightMeasureSpec);
		}

		// Token: 0x06000800 RID: 2048 RVA: 0x00014F08 File Offset: 0x00013108
		[Register("onMeasure", "(II)V", "GetOnMeasure_IIHandler")]
		public new unsafe virtual void OnMeasure(int widthMeasureSpec, int heightMeasureSpec)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(widthMeasureSpec);
			ptr[1] = new JniArgumentValue(heightMeasureSpec);
			ScrollingTabContainerView._members.InstanceMethods.InvokeVirtualVoidMethod("onMeasure.(II)V", this, ptr);
		}

		// Token: 0x06000801 RID: 2049 RVA: 0x00014F56 File Offset: 0x00013156
		private static Delegate GetOnNothingSelected_Landroid_widget_AdapterView_Handler()
		{
			if (ScrollingTabContainerView.cb_onNothingSelected_Landroid_widget_AdapterView_ == null)
			{
				ScrollingTabContainerView.cb_onNothingSelected_Landroid_widget_AdapterView_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(ScrollingTabContainerView.n_OnNothingSelected_Landroid_widget_AdapterView_));
			}
			return ScrollingTabContainerView.cb_onNothingSelected_Landroid_widget_AdapterView_;
		}

		// Token: 0x06000802 RID: 2050 RVA: 0x00014F7C File Offset: 0x0001317C
		private static void n_OnNothingSelected_Landroid_widget_AdapterView_(IntPtr jnienv, IntPtr native__this, IntPtr native_adapterView)
		{
			ScrollingTabContainerView @object = Java.Lang.Object.GetObject<ScrollingTabContainerView>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			AdapterView object2 = Java.Lang.Object.GetObject<AdapterView>(native_adapterView, JniHandleOwnership.DoNotTransfer);
			@object.OnNothingSelected(object2);
		}

		// Token: 0x06000803 RID: 2051 RVA: 0x00014FA0 File Offset: 0x000131A0
		[Register("onNothingSelected", "(Landroid/widget/AdapterView;)V", "GetOnNothingSelected_Landroid_widget_AdapterView_Handler")]
		public unsafe virtual void OnNothingSelected(AdapterView adapterView)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((adapterView == null) ? IntPtr.Zero : adapterView.Handle);
				ScrollingTabContainerView._members.InstanceMethods.InvokeVirtualVoidMethod("onNothingSelected.(Landroid/widget/AdapterView;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(adapterView);
			}
		}

		// Token: 0x06000804 RID: 2052 RVA: 0x00015004 File Offset: 0x00013204
		private static Delegate GetRemoveAllTabsHandler()
		{
			if (ScrollingTabContainerView.cb_removeAllTabs == null)
			{
				ScrollingTabContainerView.cb_removeAllTabs = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(ScrollingTabContainerView.n_RemoveAllTabs));
			}
			return ScrollingTabContainerView.cb_removeAllTabs;
		}

		// Token: 0x06000805 RID: 2053 RVA: 0x00015028 File Offset: 0x00013228
		private static void n_RemoveAllTabs(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<ScrollingTabContainerView>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).RemoveAllTabs();
		}

		// Token: 0x06000806 RID: 2054 RVA: 0x00015037 File Offset: 0x00013237
		[Register("removeAllTabs", "()V", "GetRemoveAllTabsHandler")]
		public virtual void RemoveAllTabs()
		{
			ScrollingTabContainerView._members.InstanceMethods.InvokeVirtualVoidMethod("removeAllTabs.()V", this, null);
		}

		// Token: 0x06000807 RID: 2055 RVA: 0x00015050 File Offset: 0x00013250
		private static Delegate GetRemoveTabAt_IHandler()
		{
			if (ScrollingTabContainerView.cb_removeTabAt_I == null)
			{
				ScrollingTabContainerView.cb_removeTabAt_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_V(ScrollingTabContainerView.n_RemoveTabAt_I));
			}
			return ScrollingTabContainerView.cb_removeTabAt_I;
		}

		// Token: 0x06000808 RID: 2056 RVA: 0x00015074 File Offset: 0x00013274
		private static void n_RemoveTabAt_I(IntPtr jnienv, IntPtr native__this, int position)
		{
			Java.Lang.Object.GetObject<ScrollingTabContainerView>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).RemoveTabAt(position);
		}

		// Token: 0x06000809 RID: 2057 RVA: 0x00015084 File Offset: 0x00013284
		[Register("removeTabAt", "(I)V", "GetRemoveTabAt_IHandler")]
		public unsafe virtual void RemoveTabAt(int position)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(position);
			ScrollingTabContainerView._members.InstanceMethods.InvokeVirtualVoidMethod("removeTabAt.(I)V", this, ptr);
		}

		// Token: 0x0600080A RID: 2058 RVA: 0x000150BF File Offset: 0x000132BF
		private static Delegate GetSetAllowCollapse_ZHandler()
		{
			if (ScrollingTabContainerView.cb_setAllowCollapse_Z == null)
			{
				ScrollingTabContainerView.cb_setAllowCollapse_Z = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPZ_V(ScrollingTabContainerView.n_SetAllowCollapse_Z));
			}
			return ScrollingTabContainerView.cb_setAllowCollapse_Z;
		}

		// Token: 0x0600080B RID: 2059 RVA: 0x000150E3 File Offset: 0x000132E3
		private static void n_SetAllowCollapse_Z(IntPtr jnienv, IntPtr native__this, bool allowCollapse)
		{
			Java.Lang.Object.GetObject<ScrollingTabContainerView>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SetAllowCollapse(allowCollapse);
		}

		// Token: 0x0600080C RID: 2060 RVA: 0x000150F4 File Offset: 0x000132F4
		[Register("setAllowCollapse", "(Z)V", "GetSetAllowCollapse_ZHandler")]
		public unsafe virtual void SetAllowCollapse(bool allowCollapse)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(allowCollapse);
			ScrollingTabContainerView._members.InstanceMethods.InvokeVirtualVoidMethod("setAllowCollapse.(Z)V", this, ptr);
		}

		// Token: 0x0600080D RID: 2061 RVA: 0x0001512F File Offset: 0x0001332F
		private static Delegate GetSetContentHeight_IHandler()
		{
			if (ScrollingTabContainerView.cb_setContentHeight_I == null)
			{
				ScrollingTabContainerView.cb_setContentHeight_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_V(ScrollingTabContainerView.n_SetContentHeight_I));
			}
			return ScrollingTabContainerView.cb_setContentHeight_I;
		}

		// Token: 0x0600080E RID: 2062 RVA: 0x00015153 File Offset: 0x00013353
		private static void n_SetContentHeight_I(IntPtr jnienv, IntPtr native__this, int contentHeight)
		{
			Java.Lang.Object.GetObject<ScrollingTabContainerView>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SetContentHeight(contentHeight);
		}

		// Token: 0x0600080F RID: 2063 RVA: 0x00015164 File Offset: 0x00013364
		[Register("setContentHeight", "(I)V", "GetSetContentHeight_IHandler")]
		public unsafe virtual void SetContentHeight(int contentHeight)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(contentHeight);
			ScrollingTabContainerView._members.InstanceMethods.InvokeVirtualVoidMethod("setContentHeight.(I)V", this, ptr);
		}

		// Token: 0x06000810 RID: 2064 RVA: 0x0001519F File Offset: 0x0001339F
		private static Delegate GetSetTabSelected_IHandler()
		{
			if (ScrollingTabContainerView.cb_setTabSelected_I == null)
			{
				ScrollingTabContainerView.cb_setTabSelected_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_V(ScrollingTabContainerView.n_SetTabSelected_I));
			}
			return ScrollingTabContainerView.cb_setTabSelected_I;
		}

		// Token: 0x06000811 RID: 2065 RVA: 0x000151C3 File Offset: 0x000133C3
		private static void n_SetTabSelected_I(IntPtr jnienv, IntPtr native__this, int position)
		{
			Java.Lang.Object.GetObject<ScrollingTabContainerView>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SetTabSelected(position);
		}

		// Token: 0x06000812 RID: 2066 RVA: 0x000151D4 File Offset: 0x000133D4
		[Register("setTabSelected", "(I)V", "GetSetTabSelected_IHandler")]
		public unsafe virtual void SetTabSelected(int position)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(position);
			ScrollingTabContainerView._members.InstanceMethods.InvokeVirtualVoidMethod("setTabSelected.(I)V", this, ptr);
		}

		// Token: 0x06000813 RID: 2067 RVA: 0x0001520F File Offset: 0x0001340F
		private static Delegate GetUpdateTab_IHandler()
		{
			if (ScrollingTabContainerView.cb_updateTab_I == null)
			{
				ScrollingTabContainerView.cb_updateTab_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_V(ScrollingTabContainerView.n_UpdateTab_I));
			}
			return ScrollingTabContainerView.cb_updateTab_I;
		}

		// Token: 0x06000814 RID: 2068 RVA: 0x00015233 File Offset: 0x00013433
		private static void n_UpdateTab_I(IntPtr jnienv, IntPtr native__this, int position)
		{
			Java.Lang.Object.GetObject<ScrollingTabContainerView>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).UpdateTab(position);
		}

		// Token: 0x06000815 RID: 2069 RVA: 0x00015244 File Offset: 0x00013444
		[Register("updateTab", "(I)V", "GetUpdateTab_IHandler")]
		public unsafe virtual void UpdateTab(int position)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(position);
			ScrollingTabContainerView._members.InstanceMethods.InvokeVirtualVoidMethod("updateTab.(I)V", this, ptr);
		}

		// Token: 0x0400023D RID: 573
		private static readonly JniPeerMembers _members = new XAPeerMembers("androidx/appcompat/widget/ScrollingTabContainerView", typeof(ScrollingTabContainerView));

		// Token: 0x0400023E RID: 574
		private static Delegate cb_addTab_Landroidx_appcompat_app_ActionBar_Tab_Z;

		// Token: 0x0400023F RID: 575
		private static Delegate cb_addTab_Landroidx_appcompat_app_ActionBar_Tab_IZ;

		// Token: 0x04000240 RID: 576
		private static Delegate cb_animateToTab_I;

		// Token: 0x04000241 RID: 577
		private static Delegate cb_animateToVisibility_I;

		// Token: 0x04000242 RID: 578
		private static Delegate cb_onAttachedToWindow;

		// Token: 0x04000243 RID: 579
		private static Delegate cb_onDetachedFromWindow;

		// Token: 0x04000244 RID: 580
		private static Delegate cb_onItemSelected_Landroid_widget_AdapterView_Landroid_view_View_IJ;

		// Token: 0x04000245 RID: 581
		private static Delegate cb_onMeasure_II;

		// Token: 0x04000246 RID: 582
		private static Delegate cb_onNothingSelected_Landroid_widget_AdapterView_;

		// Token: 0x04000247 RID: 583
		private static Delegate cb_removeAllTabs;

		// Token: 0x04000248 RID: 584
		private static Delegate cb_removeTabAt_I;

		// Token: 0x04000249 RID: 585
		private static Delegate cb_setAllowCollapse_Z;

		// Token: 0x0400024A RID: 586
		private static Delegate cb_setContentHeight_I;

		// Token: 0x0400024B RID: 587
		private static Delegate cb_setTabSelected_I;

		// Token: 0x0400024C RID: 588
		private static Delegate cb_updateTab_I;

		// Token: 0x0200006C RID: 108
		[Register("androidx/appcompat/widget/ScrollingTabContainerView$VisibilityAnimListener", DoNotGenerateAcw = true)]
		protected internal class VisibilityAnimListener : AnimatorListenerAdapter
		{
			// Token: 0x17000124 RID: 292
			// (get) Token: 0x06000817 RID: 2071 RVA: 0x0001529C File Offset: 0x0001349C
			internal static IntPtr class_ref
			{
				get
				{
					return ScrollingTabContainerView.VisibilityAnimListener._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x17000125 RID: 293
			// (get) Token: 0x06000818 RID: 2072 RVA: 0x000152C0 File Offset: 0x000134C0
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return ScrollingTabContainerView.VisibilityAnimListener._members;
				}
			}

			// Token: 0x17000126 RID: 294
			// (get) Token: 0x06000819 RID: 2073 RVA: 0x000152C8 File Offset: 0x000134C8
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return ScrollingTabContainerView.VisibilityAnimListener._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x17000127 RID: 295
			// (get) Token: 0x0600081A RID: 2074 RVA: 0x000152EC File Offset: 0x000134EC
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return ScrollingTabContainerView.VisibilityAnimListener._members.ManagedPeerType;
				}
			}

			// Token: 0x0600081B RID: 2075 RVA: 0x000152F8 File Offset: 0x000134F8
			protected VisibilityAnimListener(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
			{
			}

			// Token: 0x0600081C RID: 2076 RVA: 0x00015304 File Offset: 0x00013504
			[Register(".ctor", "(Landroidx/appcompat/widget/ScrollingTabContainerView;)V", "")]
			protected unsafe VisibilityAnimListener(ScrollingTabContainerView __self) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				string constructorSignature = "(L" + JNIEnv.GetJniName(base.GetType().DeclaringType) + ";)V";
				if (base.Handle != IntPtr.Zero)
				{
					return;
				}
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((__self == null) ? IntPtr.Zero : __self.Handle);
					base.SetHandle(ScrollingTabContainerView.VisibilityAnimListener._members.InstanceMethods.StartCreateInstance(constructorSignature, base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
					ScrollingTabContainerView.VisibilityAnimListener._members.InstanceMethods.FinishCreateInstance(constructorSignature, this, ptr);
				}
				finally
				{
					GC.KeepAlive(__self);
				}
			}

			// Token: 0x0600081D RID: 2077 RVA: 0x000153CC File Offset: 0x000135CC
			private static Delegate GetWithFinalVisibility_Landroid_view_ViewPropertyAnimator_IHandler()
			{
				if (ScrollingTabContainerView.VisibilityAnimListener.cb_withFinalVisibility_Landroid_view_ViewPropertyAnimator_I == null)
				{
					ScrollingTabContainerView.VisibilityAnimListener.cb_withFinalVisibility_Landroid_view_ViewPropertyAnimator_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLI_L(ScrollingTabContainerView.VisibilityAnimListener.n_WithFinalVisibility_Landroid_view_ViewPropertyAnimator_I));
				}
				return ScrollingTabContainerView.VisibilityAnimListener.cb_withFinalVisibility_Landroid_view_ViewPropertyAnimator_I;
			}

			// Token: 0x0600081E RID: 2078 RVA: 0x000153F0 File Offset: 0x000135F0
			private static IntPtr n_WithFinalVisibility_Landroid_view_ViewPropertyAnimator_I(IntPtr jnienv, IntPtr native__this, IntPtr native_animation, int visibility)
			{
				ScrollingTabContainerView.VisibilityAnimListener @object = Java.Lang.Object.GetObject<ScrollingTabContainerView.VisibilityAnimListener>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				ViewPropertyAnimator object2 = Java.Lang.Object.GetObject<ViewPropertyAnimator>(native_animation, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle(@object.WithFinalVisibility(object2, visibility));
			}

			// Token: 0x0600081F RID: 2079 RVA: 0x0001541C File Offset: 0x0001361C
			[Register("withFinalVisibility", "(Landroid/view/ViewPropertyAnimator;I)Landroid/animation/AnimatorListenerAdapter;", "GetWithFinalVisibility_Landroid_view_ViewPropertyAnimator_IHandler")]
			public unsafe virtual AnimatorListenerAdapter WithFinalVisibility(ViewPropertyAnimator animation, int visibility)
			{
				AnimatorListenerAdapter @object;
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((animation == null) ? IntPtr.Zero : animation.Handle);
					ptr[1] = new JniArgumentValue(visibility);
					@object = Java.Lang.Object.GetObject<AnimatorListenerAdapter>(ScrollingTabContainerView.VisibilityAnimListener._members.InstanceMethods.InvokeVirtualObjectMethod("withFinalVisibility.(Landroid/view/ViewPropertyAnimator;I)Landroid/animation/AnimatorListenerAdapter;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
				}
				finally
				{
					GC.KeepAlive(animation);
				}
				return @object;
			}

			// Token: 0x0400024D RID: 589
			private static readonly JniPeerMembers _members = new XAPeerMembers("androidx/appcompat/widget/ScrollingTabContainerView$VisibilityAnimListener", typeof(ScrollingTabContainerView.VisibilityAnimListener));

			// Token: 0x0400024E RID: 590
			private static Delegate cb_withFinalVisibility_Landroid_view_ViewPropertyAnimator_I;
		}
	}
}
