using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Java.Interop;
using Java.Lang;

namespace AndroidX.Core.View
{
	// Token: 0x02000091 RID: 145
	[Register("androidx/core/view/ActionProvider", DoNotGenerateAcw = true)]
	public abstract class ActionProvider : Java.Lang.Object
	{
		// Token: 0x17000184 RID: 388
		// (get) Token: 0x06000829 RID: 2089 RVA: 0x00018E74 File Offset: 0x00017074
		internal static IntPtr class_ref
		{
			get
			{
				return ActionProvider._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000185 RID: 389
		// (get) Token: 0x0600082A RID: 2090 RVA: 0x00018E98 File Offset: 0x00017098
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return ActionProvider._members;
			}
		}

		// Token: 0x17000186 RID: 390
		// (get) Token: 0x0600082B RID: 2091 RVA: 0x00018EA0 File Offset: 0x000170A0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return ActionProvider._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000187 RID: 391
		// (get) Token: 0x0600082C RID: 2092 RVA: 0x00018EC4 File Offset: 0x000170C4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return ActionProvider._members.ManagedPeerType;
			}
		}

		// Token: 0x0600082D RID: 2093 RVA: 0x00002384 File Offset: 0x00000584
		protected ActionProvider(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x0600082E RID: 2094 RVA: 0x00018ED0 File Offset: 0x000170D0
		[Register(".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe ActionProvider(Context context) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((context == null) ? IntPtr.Zero : context.Handle);
				base.SetHandle(ActionProvider._members.InstanceMethods.StartCreateInstance("(Landroid/content/Context;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				ActionProvider._members.InstanceMethods.FinishCreateInstance("(Landroid/content/Context;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(context);
			}
		}

		// Token: 0x0600082F RID: 2095 RVA: 0x00018F80 File Offset: 0x00017180
		private static Delegate GetGetContextHandler()
		{
			if (ActionProvider.cb_getContext == null)
			{
				ActionProvider.cb_getContext = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(ActionProvider.n_GetContext));
			}
			return ActionProvider.cb_getContext;
		}

		// Token: 0x06000830 RID: 2096 RVA: 0x00018FA4 File Offset: 0x000171A4
		private static IntPtr n_GetContext(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<ActionProvider>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Context);
		}

		// Token: 0x17000188 RID: 392
		// (get) Token: 0x06000831 RID: 2097 RVA: 0x00018FB8 File Offset: 0x000171B8
		public virtual Context Context
		{
			[Register("getContext", "()Landroid/content/Context;", "GetGetContextHandler")]
			get
			{
				return Java.Lang.Object.GetObject<Context>(ActionProvider._members.InstanceMethods.InvokeVirtualObjectMethod("getContext.()Landroid/content/Context;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06000832 RID: 2098 RVA: 0x00018FEA File Offset: 0x000171EA
		private static Delegate GetHasSubMenuHandler()
		{
			if (ActionProvider.cb_hasSubMenu == null)
			{
				ActionProvider.cb_hasSubMenu = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(ActionProvider.n_HasSubMenu));
			}
			return ActionProvider.cb_hasSubMenu;
		}

		// Token: 0x06000833 RID: 2099 RVA: 0x0001900E File Offset: 0x0001720E
		private static bool n_HasSubMenu(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<ActionProvider>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).HasSubMenu;
		}

		// Token: 0x17000189 RID: 393
		// (get) Token: 0x06000834 RID: 2100 RVA: 0x0001901D File Offset: 0x0001721D
		public virtual bool HasSubMenu
		{
			[Register("hasSubMenu", "()Z", "GetHasSubMenuHandler")]
			get
			{
				return ActionProvider._members.InstanceMethods.InvokeVirtualBooleanMethod("hasSubMenu.()Z", this, null);
			}
		}

		// Token: 0x06000835 RID: 2101 RVA: 0x00019036 File Offset: 0x00017236
		private static Delegate GetIsVisibleHandler()
		{
			if (ActionProvider.cb_isVisible == null)
			{
				ActionProvider.cb_isVisible = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(ActionProvider.n_IsVisible));
			}
			return ActionProvider.cb_isVisible;
		}

		// Token: 0x06000836 RID: 2102 RVA: 0x0001905A File Offset: 0x0001725A
		private static bool n_IsVisible(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<ActionProvider>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsVisible;
		}

		// Token: 0x1700018A RID: 394
		// (get) Token: 0x06000837 RID: 2103 RVA: 0x00019069 File Offset: 0x00017269
		public virtual bool IsVisible
		{
			[Register("isVisible", "()Z", "GetIsVisibleHandler")]
			get
			{
				return ActionProvider._members.InstanceMethods.InvokeVirtualBooleanMethod("isVisible.()Z", this, null);
			}
		}

		// Token: 0x06000838 RID: 2104 RVA: 0x00019082 File Offset: 0x00017282
		private static Delegate GetOnCreateActionViewHandler()
		{
			if (ActionProvider.cb_onCreateActionView == null)
			{
				ActionProvider.cb_onCreateActionView = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(ActionProvider.n_OnCreateActionView));
			}
			return ActionProvider.cb_onCreateActionView;
		}

		// Token: 0x06000839 RID: 2105 RVA: 0x000190A6 File Offset: 0x000172A6
		private static IntPtr n_OnCreateActionView(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<ActionProvider>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).OnCreateActionView());
		}

		// Token: 0x0600083A RID: 2106
		[Register("onCreateActionView", "()Landroid/view/View;", "GetOnCreateActionViewHandler")]
		public abstract View OnCreateActionView();

		// Token: 0x0600083B RID: 2107 RVA: 0x000190BA File Offset: 0x000172BA
		private static Delegate GetOnCreateActionView_Landroid_view_MenuItem_Handler()
		{
			if (ActionProvider.cb_onCreateActionView_Landroid_view_MenuItem_ == null)
			{
				ActionProvider.cb_onCreateActionView_Landroid_view_MenuItem_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(ActionProvider.n_OnCreateActionView_Landroid_view_MenuItem_));
			}
			return ActionProvider.cb_onCreateActionView_Landroid_view_MenuItem_;
		}

		// Token: 0x0600083C RID: 2108 RVA: 0x000190E0 File Offset: 0x000172E0
		private static IntPtr n_OnCreateActionView_Landroid_view_MenuItem_(IntPtr jnienv, IntPtr native__this, IntPtr native_forItem)
		{
			ActionProvider @object = Java.Lang.Object.GetObject<ActionProvider>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IMenuItem object2 = Java.Lang.Object.GetObject<IMenuItem>(native_forItem, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.OnCreateActionView(object2));
		}

		// Token: 0x0600083D RID: 2109 RVA: 0x00019108 File Offset: 0x00017308
		[Register("onCreateActionView", "(Landroid/view/MenuItem;)Landroid/view/View;", "GetOnCreateActionView_Landroid_view_MenuItem_Handler")]
		public unsafe virtual View OnCreateActionView(IMenuItem forItem)
		{
			View @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((forItem == null) ? IntPtr.Zero : ((Java.Lang.Object)forItem).Handle);
				@object = Java.Lang.Object.GetObject<View>(ActionProvider._members.InstanceMethods.InvokeVirtualObjectMethod("onCreateActionView.(Landroid/view/MenuItem;)Landroid/view/View;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(forItem);
			}
			return @object;
		}

		// Token: 0x0600083E RID: 2110 RVA: 0x00019180 File Offset: 0x00017380
		private static Delegate GetOnPerformDefaultActionHandler()
		{
			if (ActionProvider.cb_onPerformDefaultAction == null)
			{
				ActionProvider.cb_onPerformDefaultAction = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(ActionProvider.n_OnPerformDefaultAction));
			}
			return ActionProvider.cb_onPerformDefaultAction;
		}

		// Token: 0x0600083F RID: 2111 RVA: 0x000191A4 File Offset: 0x000173A4
		private static bool n_OnPerformDefaultAction(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<ActionProvider>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).OnPerformDefaultAction();
		}

		// Token: 0x06000840 RID: 2112 RVA: 0x000191B3 File Offset: 0x000173B3
		[Register("onPerformDefaultAction", "()Z", "GetOnPerformDefaultActionHandler")]
		public virtual bool OnPerformDefaultAction()
		{
			return ActionProvider._members.InstanceMethods.InvokeVirtualBooleanMethod("onPerformDefaultAction.()Z", this, null);
		}

		// Token: 0x06000841 RID: 2113 RVA: 0x000191CC File Offset: 0x000173CC
		private static Delegate GetOnPrepareSubMenu_Landroid_view_SubMenu_Handler()
		{
			if (ActionProvider.cb_onPrepareSubMenu_Landroid_view_SubMenu_ == null)
			{
				ActionProvider.cb_onPrepareSubMenu_Landroid_view_SubMenu_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(ActionProvider.n_OnPrepareSubMenu_Landroid_view_SubMenu_));
			}
			return ActionProvider.cb_onPrepareSubMenu_Landroid_view_SubMenu_;
		}

		// Token: 0x06000842 RID: 2114 RVA: 0x000191F0 File Offset: 0x000173F0
		private static void n_OnPrepareSubMenu_Landroid_view_SubMenu_(IntPtr jnienv, IntPtr native__this, IntPtr native_subMenu)
		{
			ActionProvider @object = Java.Lang.Object.GetObject<ActionProvider>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ISubMenu object2 = Java.Lang.Object.GetObject<ISubMenu>(native_subMenu, JniHandleOwnership.DoNotTransfer);
			@object.OnPrepareSubMenu(object2);
		}

		// Token: 0x06000843 RID: 2115 RVA: 0x00019214 File Offset: 0x00017414
		[Register("onPrepareSubMenu", "(Landroid/view/SubMenu;)V", "GetOnPrepareSubMenu_Landroid_view_SubMenu_Handler")]
		public unsafe virtual void OnPrepareSubMenu(ISubMenu subMenu)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((subMenu == null) ? IntPtr.Zero : ((Java.Lang.Object)subMenu).Handle);
				ActionProvider._members.InstanceMethods.InvokeVirtualVoidMethod("onPrepareSubMenu.(Landroid/view/SubMenu;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(subMenu);
			}
		}

		// Token: 0x06000844 RID: 2116 RVA: 0x0001927C File Offset: 0x0001747C
		private static Delegate GetOverridesItemVisibilityHandler()
		{
			if (ActionProvider.cb_overridesItemVisibility == null)
			{
				ActionProvider.cb_overridesItemVisibility = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(ActionProvider.n_OverridesItemVisibility));
			}
			return ActionProvider.cb_overridesItemVisibility;
		}

		// Token: 0x06000845 RID: 2117 RVA: 0x000192A0 File Offset: 0x000174A0
		private static bool n_OverridesItemVisibility(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<ActionProvider>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).OverridesItemVisibility();
		}

		// Token: 0x06000846 RID: 2118 RVA: 0x000192AF File Offset: 0x000174AF
		[Register("overridesItemVisibility", "()Z", "GetOverridesItemVisibilityHandler")]
		public virtual bool OverridesItemVisibility()
		{
			return ActionProvider._members.InstanceMethods.InvokeVirtualBooleanMethod("overridesItemVisibility.()Z", this, null);
		}

		// Token: 0x06000847 RID: 2119 RVA: 0x000192C8 File Offset: 0x000174C8
		private static Delegate GetRefreshVisibilityHandler()
		{
			if (ActionProvider.cb_refreshVisibility == null)
			{
				ActionProvider.cb_refreshVisibility = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(ActionProvider.n_RefreshVisibility));
			}
			return ActionProvider.cb_refreshVisibility;
		}

		// Token: 0x06000848 RID: 2120 RVA: 0x000192EC File Offset: 0x000174EC
		private static void n_RefreshVisibility(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<ActionProvider>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).RefreshVisibility();
		}

		// Token: 0x06000849 RID: 2121 RVA: 0x000192FB File Offset: 0x000174FB
		[Register("refreshVisibility", "()V", "GetRefreshVisibilityHandler")]
		public virtual void RefreshVisibility()
		{
			ActionProvider._members.InstanceMethods.InvokeVirtualVoidMethod("refreshVisibility.()V", this, null);
		}

		// Token: 0x0600084A RID: 2122 RVA: 0x00019314 File Offset: 0x00017514
		private static Delegate GetResetHandler()
		{
			if (ActionProvider.cb_reset == null)
			{
				ActionProvider.cb_reset = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(ActionProvider.n_Reset));
			}
			return ActionProvider.cb_reset;
		}

		// Token: 0x0600084B RID: 2123 RVA: 0x00019338 File Offset: 0x00017538
		private static void n_Reset(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<ActionProvider>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Reset();
		}

		// Token: 0x0600084C RID: 2124 RVA: 0x00019347 File Offset: 0x00017547
		[Register("reset", "()V", "GetResetHandler")]
		public virtual void Reset()
		{
			ActionProvider._members.InstanceMethods.InvokeVirtualVoidMethod("reset.()V", this, null);
		}

		// Token: 0x0600084D RID: 2125 RVA: 0x00019360 File Offset: 0x00017560
		private static Delegate GetSetSubUiVisibilityListener_Landroidx_core_view_ActionProvider_SubUiVisibilityListener_Handler()
		{
			if (ActionProvider.cb_setSubUiVisibilityListener_Landroidx_core_view_ActionProvider_SubUiVisibilityListener_ == null)
			{
				ActionProvider.cb_setSubUiVisibilityListener_Landroidx_core_view_ActionProvider_SubUiVisibilityListener_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(ActionProvider.n_SetSubUiVisibilityListener_Landroidx_core_view_ActionProvider_SubUiVisibilityListener_));
			}
			return ActionProvider.cb_setSubUiVisibilityListener_Landroidx_core_view_ActionProvider_SubUiVisibilityListener_;
		}

		// Token: 0x0600084E RID: 2126 RVA: 0x00019384 File Offset: 0x00017584
		private static void n_SetSubUiVisibilityListener_Landroidx_core_view_ActionProvider_SubUiVisibilityListener_(IntPtr jnienv, IntPtr native__this, IntPtr native_listener)
		{
			ActionProvider @object = Java.Lang.Object.GetObject<ActionProvider>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ActionProvider.ISubUiVisibilityListener object2 = Java.Lang.Object.GetObject<ActionProvider.ISubUiVisibilityListener>(native_listener, JniHandleOwnership.DoNotTransfer);
			@object.SetSubUiVisibilityListener(object2);
		}

		// Token: 0x0600084F RID: 2127 RVA: 0x000193A8 File Offset: 0x000175A8
		[Register("setSubUiVisibilityListener", "(Landroidx/core/view/ActionProvider$SubUiVisibilityListener;)V", "GetSetSubUiVisibilityListener_Landroidx_core_view_ActionProvider_SubUiVisibilityListener_Handler")]
		public unsafe virtual void SetSubUiVisibilityListener(ActionProvider.ISubUiVisibilityListener listener)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((listener == null) ? IntPtr.Zero : ((Java.Lang.Object)listener).Handle);
				ActionProvider._members.InstanceMethods.InvokeVirtualVoidMethod("setSubUiVisibilityListener.(Landroidx/core/view/ActionProvider$SubUiVisibilityListener;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(listener);
			}
		}

		// Token: 0x06000850 RID: 2128 RVA: 0x00019410 File Offset: 0x00017610
		private static Delegate GetSetVisibilityListener_Landroidx_core_view_ActionProvider_VisibilityListener_Handler()
		{
			if (ActionProvider.cb_setVisibilityListener_Landroidx_core_view_ActionProvider_VisibilityListener_ == null)
			{
				ActionProvider.cb_setVisibilityListener_Landroidx_core_view_ActionProvider_VisibilityListener_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(ActionProvider.n_SetVisibilityListener_Landroidx_core_view_ActionProvider_VisibilityListener_));
			}
			return ActionProvider.cb_setVisibilityListener_Landroidx_core_view_ActionProvider_VisibilityListener_;
		}

		// Token: 0x06000851 RID: 2129 RVA: 0x00019434 File Offset: 0x00017634
		private static void n_SetVisibilityListener_Landroidx_core_view_ActionProvider_VisibilityListener_(IntPtr jnienv, IntPtr native__this, IntPtr native_listener)
		{
			ActionProvider @object = Java.Lang.Object.GetObject<ActionProvider>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ActionProvider.IVisibilityListener object2 = Java.Lang.Object.GetObject<ActionProvider.IVisibilityListener>(native_listener, JniHandleOwnership.DoNotTransfer);
			@object.SetVisibilityListener(object2);
		}

		// Token: 0x06000852 RID: 2130 RVA: 0x00019458 File Offset: 0x00017658
		[Register("setVisibilityListener", "(Landroidx/core/view/ActionProvider$VisibilityListener;)V", "GetSetVisibilityListener_Landroidx_core_view_ActionProvider_VisibilityListener_Handler")]
		public unsafe virtual void SetVisibilityListener(ActionProvider.IVisibilityListener listener)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((listener == null) ? IntPtr.Zero : ((Java.Lang.Object)listener).Handle);
				ActionProvider._members.InstanceMethods.InvokeVirtualVoidMethod("setVisibilityListener.(Landroidx/core/view/ActionProvider$VisibilityListener;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(listener);
			}
		}

		// Token: 0x06000853 RID: 2131 RVA: 0x000194C0 File Offset: 0x000176C0
		private static Delegate GetSubUiVisibilityChanged_ZHandler()
		{
			if (ActionProvider.cb_subUiVisibilityChanged_Z == null)
			{
				ActionProvider.cb_subUiVisibilityChanged_Z = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPZ_V(ActionProvider.n_SubUiVisibilityChanged_Z));
			}
			return ActionProvider.cb_subUiVisibilityChanged_Z;
		}

		// Token: 0x06000854 RID: 2132 RVA: 0x000194E4 File Offset: 0x000176E4
		private static void n_SubUiVisibilityChanged_Z(IntPtr jnienv, IntPtr native__this, bool isVisible)
		{
			Java.Lang.Object.GetObject<ActionProvider>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SubUiVisibilityChanged(isVisible);
		}

		// Token: 0x06000855 RID: 2133 RVA: 0x000194F4 File Offset: 0x000176F4
		[Register("subUiVisibilityChanged", "(Z)V", "GetSubUiVisibilityChanged_ZHandler")]
		public unsafe virtual void SubUiVisibilityChanged(bool isVisible)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(isVisible);
			ActionProvider._members.InstanceMethods.InvokeVirtualVoidMethod("subUiVisibilityChanged.(Z)V", this, ptr);
		}

		// Token: 0x14000001 RID: 1
		// (add) Token: 0x06000856 RID: 2134 RVA: 0x00019530 File Offset: 0x00017730
		// (remove) Token: 0x06000857 RID: 2135 RVA: 0x0001957C File Offset: 0x0001777C
		public event EventHandler<ActionProvider.SubUiVisibilityEventArgs> SubUiVisibility
		{
			add
			{
				EventHelper.AddEventHandler<ActionProvider.ISubUiVisibilityListener, ActionProvider.ISubUiVisibilityListenerImplementor>(ref this.weak_implementor_SetSubUiVisibilityListener, new Func<ActionProvider.ISubUiVisibilityListenerImplementor>(this.__CreateISubUiVisibilityListenerImplementor), new Action<ActionProvider.ISubUiVisibilityListener>(this.SetSubUiVisibilityListener), delegate(ActionProvider.ISubUiVisibilityListenerImplementor __h)
				{
					__h.Handler = (EventHandler<ActionProvider.SubUiVisibilityEventArgs>)Delegate.Combine(__h.Handler, value);
				});
			}
			remove
			{
				Func<ActionProvider.ISubUiVisibilityListenerImplementor, bool> empty;
				if ((empty = ActionProvider.<>O.<0>____IsEmpty) == null)
				{
					empty = (ActionProvider.<>O.<0>____IsEmpty = new Func<ActionProvider.ISubUiVisibilityListenerImplementor, bool>(ActionProvider.ISubUiVisibilityListenerImplementor.__IsEmpty));
				}
				EventHelper.RemoveEventHandler<ActionProvider.ISubUiVisibilityListener, ActionProvider.ISubUiVisibilityListenerImplementor>(ref this.weak_implementor_SetSubUiVisibilityListener, empty, delegate(ActionProvider.ISubUiVisibilityListener __v)
				{
					this.SetSubUiVisibilityListener(null);
				}, delegate(ActionProvider.ISubUiVisibilityListenerImplementor __h)
				{
					__h.Handler = (EventHandler<ActionProvider.SubUiVisibilityEventArgs>)Delegate.Remove(__h.Handler, value);
				});
			}
		}

		// Token: 0x06000858 RID: 2136 RVA: 0x000195DB File Offset: 0x000177DB
		private ActionProvider.ISubUiVisibilityListenerImplementor __CreateISubUiVisibilityListenerImplementor()
		{
			return new ActionProvider.ISubUiVisibilityListenerImplementor(this);
		}

		// Token: 0x14000002 RID: 2
		// (add) Token: 0x06000859 RID: 2137 RVA: 0x000195E4 File Offset: 0x000177E4
		// (remove) Token: 0x0600085A RID: 2138 RVA: 0x00019630 File Offset: 0x00017830
		public event EventHandler<ActionProvider.VisibilityEventArgs> Visibility
		{
			add
			{
				EventHelper.AddEventHandler<ActionProvider.IVisibilityListener, ActionProvider.IVisibilityListenerImplementor>(ref this.weak_implementor_SetVisibilityListener, new Func<ActionProvider.IVisibilityListenerImplementor>(this.__CreateIVisibilityListenerImplementor), new Action<ActionProvider.IVisibilityListener>(this.SetVisibilityListener), delegate(ActionProvider.IVisibilityListenerImplementor __h)
				{
					__h.Handler = (EventHandler<ActionProvider.VisibilityEventArgs>)Delegate.Combine(__h.Handler, value);
				});
			}
			remove
			{
				Func<ActionProvider.IVisibilityListenerImplementor, bool> empty;
				if ((empty = ActionProvider.<>O.<1>____IsEmpty) == null)
				{
					empty = (ActionProvider.<>O.<1>____IsEmpty = new Func<ActionProvider.IVisibilityListenerImplementor, bool>(ActionProvider.IVisibilityListenerImplementor.__IsEmpty));
				}
				EventHelper.RemoveEventHandler<ActionProvider.IVisibilityListener, ActionProvider.IVisibilityListenerImplementor>(ref this.weak_implementor_SetVisibilityListener, empty, delegate(ActionProvider.IVisibilityListener __v)
				{
					this.SetVisibilityListener(null);
				}, delegate(ActionProvider.IVisibilityListenerImplementor __h)
				{
					__h.Handler = (EventHandler<ActionProvider.VisibilityEventArgs>)Delegate.Remove(__h.Handler, value);
				});
			}
		}

		// Token: 0x0600085B RID: 2139 RVA: 0x0001968F File Offset: 0x0001788F
		private ActionProvider.IVisibilityListenerImplementor __CreateIVisibilityListenerImplementor()
		{
			return new ActionProvider.IVisibilityListenerImplementor(this);
		}

		// Token: 0x04000223 RID: 547
		private static readonly JniPeerMembers _members = new XAPeerMembers("androidx/core/view/ActionProvider", typeof(ActionProvider));

		// Token: 0x04000224 RID: 548
		private static Delegate cb_getContext;

		// Token: 0x04000225 RID: 549
		private static Delegate cb_hasSubMenu;

		// Token: 0x04000226 RID: 550
		private static Delegate cb_isVisible;

		// Token: 0x04000227 RID: 551
		private static Delegate cb_onCreateActionView;

		// Token: 0x04000228 RID: 552
		private static Delegate cb_onCreateActionView_Landroid_view_MenuItem_;

		// Token: 0x04000229 RID: 553
		private static Delegate cb_onPerformDefaultAction;

		// Token: 0x0400022A RID: 554
		private static Delegate cb_onPrepareSubMenu_Landroid_view_SubMenu_;

		// Token: 0x0400022B RID: 555
		private static Delegate cb_overridesItemVisibility;

		// Token: 0x0400022C RID: 556
		private static Delegate cb_refreshVisibility;

		// Token: 0x0400022D RID: 557
		private static Delegate cb_reset;

		// Token: 0x0400022E RID: 558
		private static Delegate cb_setSubUiVisibilityListener_Landroidx_core_view_ActionProvider_SubUiVisibilityListener_;

		// Token: 0x0400022F RID: 559
		private static Delegate cb_setVisibilityListener_Landroidx_core_view_ActionProvider_VisibilityListener_;

		// Token: 0x04000230 RID: 560
		private static Delegate cb_subUiVisibilityChanged_Z;

		// Token: 0x04000231 RID: 561
		private WeakReference weak_implementor_SetSubUiVisibilityListener;

		// Token: 0x04000232 RID: 562
		private WeakReference weak_implementor_SetVisibilityListener;

		// Token: 0x02000092 RID: 146
		[Register("androidx/core/view/ActionProvider$SubUiVisibilityListener", "", "AndroidX.Core.View.ActionProvider/ISubUiVisibilityListenerInvoker")]
		public interface ISubUiVisibilityListener : IJavaObject, IDisposable, IJavaPeerable
		{
			// Token: 0x0600085D RID: 2141
			[Register("onSubUiVisibilityChanged", "(Z)V", "GetOnSubUiVisibilityChanged_ZHandler:AndroidX.Core.View.ActionProvider/ISubUiVisibilityListenerInvoker, Xamarin.AndroidX.Core")]
			void OnSubUiVisibilityChanged(bool isVisible);
		}

		// Token: 0x02000093 RID: 147
		[Register("androidx/core/view/ActionProvider$SubUiVisibilityListener", DoNotGenerateAcw = true)]
		internal class ISubUiVisibilityListenerInvoker : Java.Lang.Object, ActionProvider.ISubUiVisibilityListener, IJavaObject, IDisposable, IJavaPeerable
		{
			// Token: 0x1700018B RID: 395
			// (get) Token: 0x0600085E RID: 2142 RVA: 0x000196B4 File Offset: 0x000178B4
			private static IntPtr java_class_ref
			{
				get
				{
					return ActionProvider.ISubUiVisibilityListenerInvoker._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x1700018C RID: 396
			// (get) Token: 0x0600085F RID: 2143 RVA: 0x000196D8 File Offset: 0x000178D8
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return ActionProvider.ISubUiVisibilityListenerInvoker._members;
				}
			}

			// Token: 0x1700018D RID: 397
			// (get) Token: 0x06000860 RID: 2144 RVA: 0x000196DF File Offset: 0x000178DF
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return this.class_ref;
				}
			}

			// Token: 0x1700018E RID: 398
			// (get) Token: 0x06000861 RID: 2145 RVA: 0x000196E7 File Offset: 0x000178E7
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return ActionProvider.ISubUiVisibilityListenerInvoker._members.ManagedPeerType;
				}
			}

			// Token: 0x06000862 RID: 2146 RVA: 0x000196F3 File Offset: 0x000178F3
			public static ActionProvider.ISubUiVisibilityListener GetObject(IntPtr handle, JniHandleOwnership transfer)
			{
				return Java.Lang.Object.GetObject<ActionProvider.ISubUiVisibilityListener>(handle, transfer);
			}

			// Token: 0x06000863 RID: 2147 RVA: 0x000196FC File Offset: 0x000178FC
			private static IntPtr Validate(IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf(handle, ActionProvider.ISubUiVisibilityListenerInvoker.java_class_ref))
				{
					throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'androidx.core.view.ActionProvider.SubUiVisibilityListener'.");
				}
				return handle;
			}

			// Token: 0x06000864 RID: 2148 RVA: 0x00019727 File Offset: 0x00017927
			protected override void Dispose(bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
				{
					JNIEnv.DeleteGlobalRef(this.class_ref);
				}
				this.class_ref = IntPtr.Zero;
				base.Dispose(disposing);
			}

			// Token: 0x06000865 RID: 2149 RVA: 0x00019758 File Offset: 0x00017958
			public ISubUiVisibilityListenerInvoker(IntPtr handle, JniHandleOwnership transfer) : base(ActionProvider.ISubUiVisibilityListenerInvoker.Validate(handle), transfer)
			{
				IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
				this.class_ref = JNIEnv.NewGlobalRef(objectClass);
				JNIEnv.DeleteLocalRef(objectClass);
			}

			// Token: 0x06000866 RID: 2150 RVA: 0x00019790 File Offset: 0x00017990
			private static Delegate GetOnSubUiVisibilityChanged_ZHandler()
			{
				if (ActionProvider.ISubUiVisibilityListenerInvoker.cb_onSubUiVisibilityChanged_Z == null)
				{
					ActionProvider.ISubUiVisibilityListenerInvoker.cb_onSubUiVisibilityChanged_Z = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPZ_V(ActionProvider.ISubUiVisibilityListenerInvoker.n_OnSubUiVisibilityChanged_Z));
				}
				return ActionProvider.ISubUiVisibilityListenerInvoker.cb_onSubUiVisibilityChanged_Z;
			}

			// Token: 0x06000867 RID: 2151 RVA: 0x000197B4 File Offset: 0x000179B4
			private static void n_OnSubUiVisibilityChanged_Z(IntPtr jnienv, IntPtr native__this, bool isVisible)
			{
				Java.Lang.Object.GetObject<ActionProvider.ISubUiVisibilityListener>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).OnSubUiVisibilityChanged(isVisible);
			}

			// Token: 0x06000868 RID: 2152 RVA: 0x000197C4 File Offset: 0x000179C4
			public unsafe void OnSubUiVisibilityChanged(bool isVisible)
			{
				if (this.id_onSubUiVisibilityChanged_Z == IntPtr.Zero)
				{
					this.id_onSubUiVisibilityChanged_Z = JNIEnv.GetMethodID(this.class_ref, "onSubUiVisibilityChanged", "(Z)V");
				}
				JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
				*ptr = new JValue(isVisible);
				JNIEnv.CallVoidMethod(base.Handle, this.id_onSubUiVisibilityChanged_Z, ptr);
			}

			// Token: 0x04000233 RID: 563
			private static readonly JniPeerMembers _members = new XAPeerMembers("androidx/core/view/ActionProvider$SubUiVisibilityListener", typeof(ActionProvider.ISubUiVisibilityListenerInvoker));

			// Token: 0x04000234 RID: 564
			private IntPtr class_ref;

			// Token: 0x04000235 RID: 565
			private static Delegate cb_onSubUiVisibilityChanged_Z;

			// Token: 0x04000236 RID: 566
			private IntPtr id_onSubUiVisibilityChanged_Z;
		}

		// Token: 0x02000094 RID: 148
		public class SubUiVisibilityEventArgs : EventArgs
		{
			// Token: 0x0600086A RID: 2154 RVA: 0x00019843 File Offset: 0x00017A43
			public SubUiVisibilityEventArgs(bool isVisible)
			{
				this.isVisible = isVisible;
			}

			// Token: 0x04000237 RID: 567
			private bool isVisible;
		}

		// Token: 0x02000095 RID: 149
		[Register("mono/androidx/core/view/ActionProvider_SubUiVisibilityListenerImplementor")]
		internal sealed class ISubUiVisibilityListenerImplementor : Java.Lang.Object, ActionProvider.ISubUiVisibilityListener, IJavaObject, IDisposable, IJavaPeerable
		{
			// Token: 0x0600086B RID: 2155 RVA: 0x00019852 File Offset: 0x00017A52
			public ISubUiVisibilityListenerImplementor(object sender) : base(JNIEnv.StartCreateInstance("mono/androidx/core/view/ActionProvider_SubUiVisibilityListenerImplementor", "()V", Array.Empty<JValue>()), JniHandleOwnership.TransferLocalRef)
			{
				JNIEnv.FinishCreateInstance(base.Handle, "()V", Array.Empty<JValue>());
				this.sender = sender;
			}

			// Token: 0x0600086C RID: 2156 RVA: 0x0001988C File Offset: 0x00017A8C
			public void OnSubUiVisibilityChanged(bool isVisible)
			{
				EventHandler<ActionProvider.SubUiVisibilityEventArgs> handler = this.Handler;
				if (handler != null)
				{
					handler(this.sender, new ActionProvider.SubUiVisibilityEventArgs(isVisible));
				}
			}

			// Token: 0x0600086D RID: 2157 RVA: 0x000198B5 File Offset: 0x00017AB5
			internal static bool __IsEmpty(ActionProvider.ISubUiVisibilityListenerImplementor value)
			{
				return value.Handler == null;
			}

			// Token: 0x04000238 RID: 568
			private object sender;

			// Token: 0x04000239 RID: 569
			public EventHandler<ActionProvider.SubUiVisibilityEventArgs> Handler;
		}

		// Token: 0x02000096 RID: 150
		[Register("androidx/core/view/ActionProvider$VisibilityListener", "", "AndroidX.Core.View.ActionProvider/IVisibilityListenerInvoker")]
		public interface IVisibilityListener : IJavaObject, IDisposable, IJavaPeerable
		{
			// Token: 0x0600086E RID: 2158
			[Register("onActionProviderVisibilityChanged", "(Z)V", "GetOnActionProviderVisibilityChanged_ZHandler:AndroidX.Core.View.ActionProvider/IVisibilityListenerInvoker, Xamarin.AndroidX.Core")]
			void OnActionProviderVisibilityChanged(bool isVisible);
		}

		// Token: 0x02000097 RID: 151
		[Register("androidx/core/view/ActionProvider$VisibilityListener", DoNotGenerateAcw = true)]
		internal class IVisibilityListenerInvoker : Java.Lang.Object, ActionProvider.IVisibilityListener, IJavaObject, IDisposable, IJavaPeerable
		{
			// Token: 0x1700018F RID: 399
			// (get) Token: 0x0600086F RID: 2159 RVA: 0x000198C0 File Offset: 0x00017AC0
			private static IntPtr java_class_ref
			{
				get
				{
					return ActionProvider.IVisibilityListenerInvoker._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x17000190 RID: 400
			// (get) Token: 0x06000870 RID: 2160 RVA: 0x000198E4 File Offset: 0x00017AE4
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return ActionProvider.IVisibilityListenerInvoker._members;
				}
			}

			// Token: 0x17000191 RID: 401
			// (get) Token: 0x06000871 RID: 2161 RVA: 0x000198EB File Offset: 0x00017AEB
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return this.class_ref;
				}
			}

			// Token: 0x17000192 RID: 402
			// (get) Token: 0x06000872 RID: 2162 RVA: 0x000198F3 File Offset: 0x00017AF3
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return ActionProvider.IVisibilityListenerInvoker._members.ManagedPeerType;
				}
			}

			// Token: 0x06000873 RID: 2163 RVA: 0x000198FF File Offset: 0x00017AFF
			public static ActionProvider.IVisibilityListener GetObject(IntPtr handle, JniHandleOwnership transfer)
			{
				return Java.Lang.Object.GetObject<ActionProvider.IVisibilityListener>(handle, transfer);
			}

			// Token: 0x06000874 RID: 2164 RVA: 0x00019908 File Offset: 0x00017B08
			private static IntPtr Validate(IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf(handle, ActionProvider.IVisibilityListenerInvoker.java_class_ref))
				{
					throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'androidx.core.view.ActionProvider.VisibilityListener'.");
				}
				return handle;
			}

			// Token: 0x06000875 RID: 2165 RVA: 0x00019933 File Offset: 0x00017B33
			protected override void Dispose(bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
				{
					JNIEnv.DeleteGlobalRef(this.class_ref);
				}
				this.class_ref = IntPtr.Zero;
				base.Dispose(disposing);
			}

			// Token: 0x06000876 RID: 2166 RVA: 0x00019964 File Offset: 0x00017B64
			public IVisibilityListenerInvoker(IntPtr handle, JniHandleOwnership transfer) : base(ActionProvider.IVisibilityListenerInvoker.Validate(handle), transfer)
			{
				IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
				this.class_ref = JNIEnv.NewGlobalRef(objectClass);
				JNIEnv.DeleteLocalRef(objectClass);
			}

			// Token: 0x06000877 RID: 2167 RVA: 0x0001999C File Offset: 0x00017B9C
			private static Delegate GetOnActionProviderVisibilityChanged_ZHandler()
			{
				if (ActionProvider.IVisibilityListenerInvoker.cb_onActionProviderVisibilityChanged_Z == null)
				{
					ActionProvider.IVisibilityListenerInvoker.cb_onActionProviderVisibilityChanged_Z = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPZ_V(ActionProvider.IVisibilityListenerInvoker.n_OnActionProviderVisibilityChanged_Z));
				}
				return ActionProvider.IVisibilityListenerInvoker.cb_onActionProviderVisibilityChanged_Z;
			}

			// Token: 0x06000878 RID: 2168 RVA: 0x000199C0 File Offset: 0x00017BC0
			private static void n_OnActionProviderVisibilityChanged_Z(IntPtr jnienv, IntPtr native__this, bool isVisible)
			{
				Java.Lang.Object.GetObject<ActionProvider.IVisibilityListener>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).OnActionProviderVisibilityChanged(isVisible);
			}

			// Token: 0x06000879 RID: 2169 RVA: 0x000199D0 File Offset: 0x00017BD0
			public unsafe void OnActionProviderVisibilityChanged(bool isVisible)
			{
				if (this.id_onActionProviderVisibilityChanged_Z == IntPtr.Zero)
				{
					this.id_onActionProviderVisibilityChanged_Z = JNIEnv.GetMethodID(this.class_ref, "onActionProviderVisibilityChanged", "(Z)V");
				}
				JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
				*ptr = new JValue(isVisible);
				JNIEnv.CallVoidMethod(base.Handle, this.id_onActionProviderVisibilityChanged_Z, ptr);
			}

			// Token: 0x0400023A RID: 570
			private static readonly JniPeerMembers _members = new XAPeerMembers("androidx/core/view/ActionProvider$VisibilityListener", typeof(ActionProvider.IVisibilityListenerInvoker));

			// Token: 0x0400023B RID: 571
			private IntPtr class_ref;

			// Token: 0x0400023C RID: 572
			private static Delegate cb_onActionProviderVisibilityChanged_Z;

			// Token: 0x0400023D RID: 573
			private IntPtr id_onActionProviderVisibilityChanged_Z;
		}

		// Token: 0x02000098 RID: 152
		public class VisibilityEventArgs : EventArgs
		{
			// Token: 0x0600087B RID: 2171 RVA: 0x00019A4F File Offset: 0x00017C4F
			public VisibilityEventArgs(bool isVisible)
			{
				this.isVisible = isVisible;
			}

			// Token: 0x0400023E RID: 574
			private bool isVisible;
		}

		// Token: 0x02000099 RID: 153
		[Register("mono/androidx/core/view/ActionProvider_VisibilityListenerImplementor")]
		internal sealed class IVisibilityListenerImplementor : Java.Lang.Object, ActionProvider.IVisibilityListener, IJavaObject, IDisposable, IJavaPeerable
		{
			// Token: 0x0600087C RID: 2172 RVA: 0x00019A5E File Offset: 0x00017C5E
			public IVisibilityListenerImplementor(object sender) : base(JNIEnv.StartCreateInstance("mono/androidx/core/view/ActionProvider_VisibilityListenerImplementor", "()V", Array.Empty<JValue>()), JniHandleOwnership.TransferLocalRef)
			{
				JNIEnv.FinishCreateInstance(base.Handle, "()V", Array.Empty<JValue>());
				this.sender = sender;
			}

			// Token: 0x0600087D RID: 2173 RVA: 0x00019A98 File Offset: 0x00017C98
			public void OnActionProviderVisibilityChanged(bool isVisible)
			{
				EventHandler<ActionProvider.VisibilityEventArgs> handler = this.Handler;
				if (handler != null)
				{
					handler(this.sender, new ActionProvider.VisibilityEventArgs(isVisible));
				}
			}

			// Token: 0x0600087E RID: 2174 RVA: 0x00019AC1 File Offset: 0x00017CC1
			internal static bool __IsEmpty(ActionProvider.IVisibilityListenerImplementor value)
			{
				return value.Handler == null;
			}

			// Token: 0x0400023F RID: 575
			private object sender;

			// Token: 0x04000240 RID: 576
			public EventHandler<ActionProvider.VisibilityEventArgs> Handler;
		}

		// Token: 0x0200009A RID: 154
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04000241 RID: 577
			public static Func<ActionProvider.ISubUiVisibilityListenerImplementor, bool> <0>____IsEmpty;

			// Token: 0x04000242 RID: 578
			public static Func<ActionProvider.IVisibilityListenerImplementor, bool> <1>____IsEmpty;
		}
	}
}
