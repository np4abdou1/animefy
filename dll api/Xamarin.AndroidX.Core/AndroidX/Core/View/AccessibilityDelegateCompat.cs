using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Views.Accessibility;
using AndroidX.Core.View.Accessibility;
using Java.Interop;
using Java.Lang;

namespace AndroidX.Core.View
{
	// Token: 0x02000090 RID: 144
	[Register("androidx/core/view/AccessibilityDelegateCompat", DoNotGenerateAcw = true)]
	public class AccessibilityDelegateCompat : Java.Lang.Object
	{
		// Token: 0x17000180 RID: 384
		// (get) Token: 0x06000806 RID: 2054 RVA: 0x00018500 File Offset: 0x00016700
		internal static IntPtr class_ref
		{
			get
			{
				return AccessibilityDelegateCompat._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000181 RID: 385
		// (get) Token: 0x06000807 RID: 2055 RVA: 0x00018524 File Offset: 0x00016724
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return AccessibilityDelegateCompat._members;
			}
		}

		// Token: 0x17000182 RID: 386
		// (get) Token: 0x06000808 RID: 2056 RVA: 0x0001852C File Offset: 0x0001672C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return AccessibilityDelegateCompat._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000183 RID: 387
		// (get) Token: 0x06000809 RID: 2057 RVA: 0x00018550 File Offset: 0x00016750
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return AccessibilityDelegateCompat._members.ManagedPeerType;
			}
		}

		// Token: 0x0600080A RID: 2058 RVA: 0x00002384 File Offset: 0x00000584
		protected AccessibilityDelegateCompat(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x0600080B RID: 2059 RVA: 0x0001855C File Offset: 0x0001675C
		[Register(".ctor", "()V", "")]
		public AccessibilityDelegateCompat() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			base.SetHandle(AccessibilityDelegateCompat._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
			AccessibilityDelegateCompat._members.InstanceMethods.FinishCreateInstance("()V", this, null);
		}

		// Token: 0x0600080C RID: 2060 RVA: 0x000185CC File Offset: 0x000167CC
		[Register(".ctor", "(Landroid/view/View$AccessibilityDelegate;)V", "")]
		public unsafe AccessibilityDelegateCompat(View.AccessibilityDelegate originalDelegate) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((originalDelegate == null) ? IntPtr.Zero : originalDelegate.Handle);
				base.SetHandle(AccessibilityDelegateCompat._members.InstanceMethods.StartCreateInstance("(Landroid/view/View$AccessibilityDelegate;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				AccessibilityDelegateCompat._members.InstanceMethods.FinishCreateInstance("(Landroid/view/View$AccessibilityDelegate;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(originalDelegate);
			}
		}

		// Token: 0x0600080D RID: 2061 RVA: 0x0001867C File Offset: 0x0001687C
		private static Delegate GetDispatchPopulateAccessibilityEvent_Landroid_view_View_Landroid_view_accessibility_AccessibilityEvent_Handler()
		{
			if (AccessibilityDelegateCompat.cb_dispatchPopulateAccessibilityEvent_Landroid_view_View_Landroid_view_accessibility_AccessibilityEvent_ == null)
			{
				AccessibilityDelegateCompat.cb_dispatchPopulateAccessibilityEvent_Landroid_view_View_Landroid_view_accessibility_AccessibilityEvent_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_Z(AccessibilityDelegateCompat.n_DispatchPopulateAccessibilityEvent_Landroid_view_View_Landroid_view_accessibility_AccessibilityEvent_));
			}
			return AccessibilityDelegateCompat.cb_dispatchPopulateAccessibilityEvent_Landroid_view_View_Landroid_view_accessibility_AccessibilityEvent_;
		}

		// Token: 0x0600080E RID: 2062 RVA: 0x000186A0 File Offset: 0x000168A0
		private static bool n_DispatchPopulateAccessibilityEvent_Landroid_view_View_Landroid_view_accessibility_AccessibilityEvent_(IntPtr jnienv, IntPtr native__this, IntPtr native_host, IntPtr native_e)
		{
			AccessibilityDelegateCompat @object = Java.Lang.Object.GetObject<AccessibilityDelegateCompat>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			View object2 = Java.Lang.Object.GetObject<View>(native_host, JniHandleOwnership.DoNotTransfer);
			AccessibilityEvent object3 = Java.Lang.Object.GetObject<AccessibilityEvent>(native_e, JniHandleOwnership.DoNotTransfer);
			return @object.DispatchPopulateAccessibilityEvent(object2, object3);
		}

		// Token: 0x0600080F RID: 2063 RVA: 0x000186CC File Offset: 0x000168CC
		[Register("dispatchPopulateAccessibilityEvent", "(Landroid/view/View;Landroid/view/accessibility/AccessibilityEvent;)Z", "GetDispatchPopulateAccessibilityEvent_Landroid_view_View_Landroid_view_accessibility_AccessibilityEvent_Handler")]
		public unsafe virtual bool DispatchPopulateAccessibilityEvent(View host, AccessibilityEvent e)
		{
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((host == null) ? IntPtr.Zero : host.Handle);
				ptr[1] = new JniArgumentValue((e == null) ? IntPtr.Zero : e.Handle);
				result = AccessibilityDelegateCompat._members.InstanceMethods.InvokeVirtualBooleanMethod("dispatchPopulateAccessibilityEvent.(Landroid/view/View;Landroid/view/accessibility/AccessibilityEvent;)Z", this, ptr);
			}
			finally
			{
				GC.KeepAlive(host);
				GC.KeepAlive(e);
			}
			return result;
		}

		// Token: 0x06000810 RID: 2064 RVA: 0x0001875C File Offset: 0x0001695C
		private static Delegate GetGetAccessibilityNodeProvider_Landroid_view_View_Handler()
		{
			if (AccessibilityDelegateCompat.cb_getAccessibilityNodeProvider_Landroid_view_View_ == null)
			{
				AccessibilityDelegateCompat.cb_getAccessibilityNodeProvider_Landroid_view_View_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(AccessibilityDelegateCompat.n_GetAccessibilityNodeProvider_Landroid_view_View_));
			}
			return AccessibilityDelegateCompat.cb_getAccessibilityNodeProvider_Landroid_view_View_;
		}

		// Token: 0x06000811 RID: 2065 RVA: 0x00018780 File Offset: 0x00016980
		private static IntPtr n_GetAccessibilityNodeProvider_Landroid_view_View_(IntPtr jnienv, IntPtr native__this, IntPtr native_host)
		{
			AccessibilityDelegateCompat @object = Java.Lang.Object.GetObject<AccessibilityDelegateCompat>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			View object2 = Java.Lang.Object.GetObject<View>(native_host, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.GetAccessibilityNodeProvider(object2));
		}

		// Token: 0x06000812 RID: 2066 RVA: 0x000187A8 File Offset: 0x000169A8
		[Register("getAccessibilityNodeProvider", "(Landroid/view/View;)Landroidx/core/view/accessibility/AccessibilityNodeProviderCompat;", "GetGetAccessibilityNodeProvider_Landroid_view_View_Handler")]
		public unsafe virtual AccessibilityNodeProviderCompat GetAccessibilityNodeProvider(View host)
		{
			AccessibilityNodeProviderCompat @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((host == null) ? IntPtr.Zero : host.Handle);
				@object = Java.Lang.Object.GetObject<AccessibilityNodeProviderCompat>(AccessibilityDelegateCompat._members.InstanceMethods.InvokeVirtualObjectMethod("getAccessibilityNodeProvider.(Landroid/view/View;)Landroidx/core/view/accessibility/AccessibilityNodeProviderCompat;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(host);
			}
			return @object;
		}

		// Token: 0x06000813 RID: 2067 RVA: 0x0001881C File Offset: 0x00016A1C
		private static Delegate GetOnInitializeAccessibilityEvent_Landroid_view_View_Landroid_view_accessibility_AccessibilityEvent_Handler()
		{
			if (AccessibilityDelegateCompat.cb_onInitializeAccessibilityEvent_Landroid_view_View_Landroid_view_accessibility_AccessibilityEvent_ == null)
			{
				AccessibilityDelegateCompat.cb_onInitializeAccessibilityEvent_Landroid_view_View_Landroid_view_accessibility_AccessibilityEvent_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_V(AccessibilityDelegateCompat.n_OnInitializeAccessibilityEvent_Landroid_view_View_Landroid_view_accessibility_AccessibilityEvent_));
			}
			return AccessibilityDelegateCompat.cb_onInitializeAccessibilityEvent_Landroid_view_View_Landroid_view_accessibility_AccessibilityEvent_;
		}

		// Token: 0x06000814 RID: 2068 RVA: 0x00018840 File Offset: 0x00016A40
		private static void n_OnInitializeAccessibilityEvent_Landroid_view_View_Landroid_view_accessibility_AccessibilityEvent_(IntPtr jnienv, IntPtr native__this, IntPtr native_host, IntPtr native_e)
		{
			AccessibilityDelegateCompat @object = Java.Lang.Object.GetObject<AccessibilityDelegateCompat>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			View object2 = Java.Lang.Object.GetObject<View>(native_host, JniHandleOwnership.DoNotTransfer);
			AccessibilityEvent object3 = Java.Lang.Object.GetObject<AccessibilityEvent>(native_e, JniHandleOwnership.DoNotTransfer);
			@object.OnInitializeAccessibilityEvent(object2, object3);
		}

		// Token: 0x06000815 RID: 2069 RVA: 0x0001886C File Offset: 0x00016A6C
		[Register("onInitializeAccessibilityEvent", "(Landroid/view/View;Landroid/view/accessibility/AccessibilityEvent;)V", "GetOnInitializeAccessibilityEvent_Landroid_view_View_Landroid_view_accessibility_AccessibilityEvent_Handler")]
		public unsafe virtual void OnInitializeAccessibilityEvent(View host, AccessibilityEvent e)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((host == null) ? IntPtr.Zero : host.Handle);
				ptr[1] = new JniArgumentValue((e == null) ? IntPtr.Zero : e.Handle);
				AccessibilityDelegateCompat._members.InstanceMethods.InvokeVirtualVoidMethod("onInitializeAccessibilityEvent.(Landroid/view/View;Landroid/view/accessibility/AccessibilityEvent;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(host);
				GC.KeepAlive(e);
			}
		}

		// Token: 0x06000816 RID: 2070 RVA: 0x000188F8 File Offset: 0x00016AF8
		private static Delegate GetOnInitializeAccessibilityNodeInfo_Landroid_view_View_Landroidx_core_view_accessibility_AccessibilityNodeInfoCompat_Handler()
		{
			if (AccessibilityDelegateCompat.cb_onInitializeAccessibilityNodeInfo_Landroid_view_View_Landroidx_core_view_accessibility_AccessibilityNodeInfoCompat_ == null)
			{
				AccessibilityDelegateCompat.cb_onInitializeAccessibilityNodeInfo_Landroid_view_View_Landroidx_core_view_accessibility_AccessibilityNodeInfoCompat_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_V(AccessibilityDelegateCompat.n_OnInitializeAccessibilityNodeInfo_Landroid_view_View_Landroidx_core_view_accessibility_AccessibilityNodeInfoCompat_));
			}
			return AccessibilityDelegateCompat.cb_onInitializeAccessibilityNodeInfo_Landroid_view_View_Landroidx_core_view_accessibility_AccessibilityNodeInfoCompat_;
		}

		// Token: 0x06000817 RID: 2071 RVA: 0x0001891C File Offset: 0x00016B1C
		private static void n_OnInitializeAccessibilityNodeInfo_Landroid_view_View_Landroidx_core_view_accessibility_AccessibilityNodeInfoCompat_(IntPtr jnienv, IntPtr native__this, IntPtr native_host, IntPtr native_info)
		{
			AccessibilityDelegateCompat @object = Java.Lang.Object.GetObject<AccessibilityDelegateCompat>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			View object2 = Java.Lang.Object.GetObject<View>(native_host, JniHandleOwnership.DoNotTransfer);
			AccessibilityNodeInfoCompat object3 = Java.Lang.Object.GetObject<AccessibilityNodeInfoCompat>(native_info, JniHandleOwnership.DoNotTransfer);
			@object.OnInitializeAccessibilityNodeInfo(object2, object3);
		}

		// Token: 0x06000818 RID: 2072 RVA: 0x00018948 File Offset: 0x00016B48
		[Register("onInitializeAccessibilityNodeInfo", "(Landroid/view/View;Landroidx/core/view/accessibility/AccessibilityNodeInfoCompat;)V", "GetOnInitializeAccessibilityNodeInfo_Landroid_view_View_Landroidx_core_view_accessibility_AccessibilityNodeInfoCompat_Handler")]
		public unsafe virtual void OnInitializeAccessibilityNodeInfo(View host, AccessibilityNodeInfoCompat info)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((host == null) ? IntPtr.Zero : host.Handle);
				ptr[1] = new JniArgumentValue((info == null) ? IntPtr.Zero : info.Handle);
				AccessibilityDelegateCompat._members.InstanceMethods.InvokeVirtualVoidMethod("onInitializeAccessibilityNodeInfo.(Landroid/view/View;Landroidx/core/view/accessibility/AccessibilityNodeInfoCompat;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(host);
				GC.KeepAlive(info);
			}
		}

		// Token: 0x06000819 RID: 2073 RVA: 0x000189D4 File Offset: 0x00016BD4
		private static Delegate GetOnPopulateAccessibilityEvent_Landroid_view_View_Landroid_view_accessibility_AccessibilityEvent_Handler()
		{
			if (AccessibilityDelegateCompat.cb_onPopulateAccessibilityEvent_Landroid_view_View_Landroid_view_accessibility_AccessibilityEvent_ == null)
			{
				AccessibilityDelegateCompat.cb_onPopulateAccessibilityEvent_Landroid_view_View_Landroid_view_accessibility_AccessibilityEvent_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_V(AccessibilityDelegateCompat.n_OnPopulateAccessibilityEvent_Landroid_view_View_Landroid_view_accessibility_AccessibilityEvent_));
			}
			return AccessibilityDelegateCompat.cb_onPopulateAccessibilityEvent_Landroid_view_View_Landroid_view_accessibility_AccessibilityEvent_;
		}

		// Token: 0x0600081A RID: 2074 RVA: 0x000189F8 File Offset: 0x00016BF8
		private static void n_OnPopulateAccessibilityEvent_Landroid_view_View_Landroid_view_accessibility_AccessibilityEvent_(IntPtr jnienv, IntPtr native__this, IntPtr native_host, IntPtr native_e)
		{
			AccessibilityDelegateCompat @object = Java.Lang.Object.GetObject<AccessibilityDelegateCompat>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			View object2 = Java.Lang.Object.GetObject<View>(native_host, JniHandleOwnership.DoNotTransfer);
			AccessibilityEvent object3 = Java.Lang.Object.GetObject<AccessibilityEvent>(native_e, JniHandleOwnership.DoNotTransfer);
			@object.OnPopulateAccessibilityEvent(object2, object3);
		}

		// Token: 0x0600081B RID: 2075 RVA: 0x00018A24 File Offset: 0x00016C24
		[Register("onPopulateAccessibilityEvent", "(Landroid/view/View;Landroid/view/accessibility/AccessibilityEvent;)V", "GetOnPopulateAccessibilityEvent_Landroid_view_View_Landroid_view_accessibility_AccessibilityEvent_Handler")]
		public unsafe virtual void OnPopulateAccessibilityEvent(View host, AccessibilityEvent e)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((host == null) ? IntPtr.Zero : host.Handle);
				ptr[1] = new JniArgumentValue((e == null) ? IntPtr.Zero : e.Handle);
				AccessibilityDelegateCompat._members.InstanceMethods.InvokeVirtualVoidMethod("onPopulateAccessibilityEvent.(Landroid/view/View;Landroid/view/accessibility/AccessibilityEvent;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(host);
				GC.KeepAlive(e);
			}
		}

		// Token: 0x0600081C RID: 2076 RVA: 0x00018AB0 File Offset: 0x00016CB0
		private static Delegate GetOnRequestSendAccessibilityEvent_Landroid_view_ViewGroup_Landroid_view_View_Landroid_view_accessibility_AccessibilityEvent_Handler()
		{
			if (AccessibilityDelegateCompat.cb_onRequestSendAccessibilityEvent_Landroid_view_ViewGroup_Landroid_view_View_Landroid_view_accessibility_AccessibilityEvent_ == null)
			{
				AccessibilityDelegateCompat.cb_onRequestSendAccessibilityEvent_Landroid_view_ViewGroup_Landroid_view_View_Landroid_view_accessibility_AccessibilityEvent_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLLL_Z(AccessibilityDelegateCompat.n_OnRequestSendAccessibilityEvent_Landroid_view_ViewGroup_Landroid_view_View_Landroid_view_accessibility_AccessibilityEvent_));
			}
			return AccessibilityDelegateCompat.cb_onRequestSendAccessibilityEvent_Landroid_view_ViewGroup_Landroid_view_View_Landroid_view_accessibility_AccessibilityEvent_;
		}

		// Token: 0x0600081D RID: 2077 RVA: 0x00018AD4 File Offset: 0x00016CD4
		private static bool n_OnRequestSendAccessibilityEvent_Landroid_view_ViewGroup_Landroid_view_View_Landroid_view_accessibility_AccessibilityEvent_(IntPtr jnienv, IntPtr native__this, IntPtr native_host, IntPtr native_child, IntPtr native_e)
		{
			AccessibilityDelegateCompat @object = Java.Lang.Object.GetObject<AccessibilityDelegateCompat>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ViewGroup object2 = Java.Lang.Object.GetObject<ViewGroup>(native_host, JniHandleOwnership.DoNotTransfer);
			View object3 = Java.Lang.Object.GetObject<View>(native_child, JniHandleOwnership.DoNotTransfer);
			AccessibilityEvent object4 = Java.Lang.Object.GetObject<AccessibilityEvent>(native_e, JniHandleOwnership.DoNotTransfer);
			return @object.OnRequestSendAccessibilityEvent(object2, object3, object4);
		}

		// Token: 0x0600081E RID: 2078 RVA: 0x00018B0C File Offset: 0x00016D0C
		[Register("onRequestSendAccessibilityEvent", "(Landroid/view/ViewGroup;Landroid/view/View;Landroid/view/accessibility/AccessibilityEvent;)Z", "GetOnRequestSendAccessibilityEvent_Landroid_view_ViewGroup_Landroid_view_View_Landroid_view_accessibility_AccessibilityEvent_Handler")]
		public unsafe virtual bool OnRequestSendAccessibilityEvent(ViewGroup host, View child, AccessibilityEvent e)
		{
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((host == null) ? IntPtr.Zero : host.Handle);
				ptr[1] = new JniArgumentValue((child == null) ? IntPtr.Zero : child.Handle);
				ptr[2] = new JniArgumentValue((e == null) ? IntPtr.Zero : e.Handle);
				result = AccessibilityDelegateCompat._members.InstanceMethods.InvokeVirtualBooleanMethod("onRequestSendAccessibilityEvent.(Landroid/view/ViewGroup;Landroid/view/View;Landroid/view/accessibility/AccessibilityEvent;)Z", this, ptr);
			}
			finally
			{
				GC.KeepAlive(host);
				GC.KeepAlive(child);
				GC.KeepAlive(e);
			}
			return result;
		}

		// Token: 0x0600081F RID: 2079 RVA: 0x00018BC4 File Offset: 0x00016DC4
		private static Delegate GetPerformAccessibilityAction_Landroid_view_View_ILandroid_os_Bundle_Handler()
		{
			if (AccessibilityDelegateCompat.cb_performAccessibilityAction_Landroid_view_View_ILandroid_os_Bundle_ == null)
			{
				AccessibilityDelegateCompat.cb_performAccessibilityAction_Landroid_view_View_ILandroid_os_Bundle_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLIL_Z(AccessibilityDelegateCompat.n_PerformAccessibilityAction_Landroid_view_View_ILandroid_os_Bundle_));
			}
			return AccessibilityDelegateCompat.cb_performAccessibilityAction_Landroid_view_View_ILandroid_os_Bundle_;
		}

		// Token: 0x06000820 RID: 2080 RVA: 0x00018BE8 File Offset: 0x00016DE8
		private static bool n_PerformAccessibilityAction_Landroid_view_View_ILandroid_os_Bundle_(IntPtr jnienv, IntPtr native__this, IntPtr native_host, int action, IntPtr native_args)
		{
			AccessibilityDelegateCompat @object = Java.Lang.Object.GetObject<AccessibilityDelegateCompat>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			View object2 = Java.Lang.Object.GetObject<View>(native_host, JniHandleOwnership.DoNotTransfer);
			Bundle object3 = Java.Lang.Object.GetObject<Bundle>(native_args, JniHandleOwnership.DoNotTransfer);
			return @object.PerformAccessibilityAction(object2, action, object3);
		}

		// Token: 0x06000821 RID: 2081 RVA: 0x00018C18 File Offset: 0x00016E18
		[Register("performAccessibilityAction", "(Landroid/view/View;ILandroid/os/Bundle;)Z", "GetPerformAccessibilityAction_Landroid_view_View_ILandroid_os_Bundle_Handler")]
		public unsafe virtual bool PerformAccessibilityAction(View host, int action, Bundle args)
		{
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((host == null) ? IntPtr.Zero : host.Handle);
				ptr[1] = new JniArgumentValue(action);
				ptr[2] = new JniArgumentValue((args == null) ? IntPtr.Zero : args.Handle);
				result = AccessibilityDelegateCompat._members.InstanceMethods.InvokeVirtualBooleanMethod("performAccessibilityAction.(Landroid/view/View;ILandroid/os/Bundle;)Z", this, ptr);
			}
			finally
			{
				GC.KeepAlive(host);
				GC.KeepAlive(args);
			}
			return result;
		}

		// Token: 0x06000822 RID: 2082 RVA: 0x00018CBC File Offset: 0x00016EBC
		private static Delegate GetSendAccessibilityEvent_Landroid_view_View_IHandler()
		{
			if (AccessibilityDelegateCompat.cb_sendAccessibilityEvent_Landroid_view_View_I == null)
			{
				AccessibilityDelegateCompat.cb_sendAccessibilityEvent_Landroid_view_View_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLI_V(AccessibilityDelegateCompat.n_SendAccessibilityEvent_Landroid_view_View_I));
			}
			return AccessibilityDelegateCompat.cb_sendAccessibilityEvent_Landroid_view_View_I;
		}

		// Token: 0x06000823 RID: 2083 RVA: 0x00018CE0 File Offset: 0x00016EE0
		private static void n_SendAccessibilityEvent_Landroid_view_View_I(IntPtr jnienv, IntPtr native__this, IntPtr native_host, int eventType)
		{
			AccessibilityDelegateCompat @object = Java.Lang.Object.GetObject<AccessibilityDelegateCompat>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			View object2 = Java.Lang.Object.GetObject<View>(native_host, JniHandleOwnership.DoNotTransfer);
			@object.SendAccessibilityEvent(object2, eventType);
		}

		// Token: 0x06000824 RID: 2084 RVA: 0x00018D04 File Offset: 0x00016F04
		[Register("sendAccessibilityEvent", "(Landroid/view/View;I)V", "GetSendAccessibilityEvent_Landroid_view_View_IHandler")]
		public unsafe virtual void SendAccessibilityEvent(View host, int eventType)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((host == null) ? IntPtr.Zero : host.Handle);
				ptr[1] = new JniArgumentValue(eventType);
				AccessibilityDelegateCompat._members.InstanceMethods.InvokeVirtualVoidMethod("sendAccessibilityEvent.(Landroid/view/View;I)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(host);
			}
		}

		// Token: 0x06000825 RID: 2085 RVA: 0x00018D7C File Offset: 0x00016F7C
		private static Delegate GetSendAccessibilityEventUnchecked_Landroid_view_View_Landroid_view_accessibility_AccessibilityEvent_Handler()
		{
			if (AccessibilityDelegateCompat.cb_sendAccessibilityEventUnchecked_Landroid_view_View_Landroid_view_accessibility_AccessibilityEvent_ == null)
			{
				AccessibilityDelegateCompat.cb_sendAccessibilityEventUnchecked_Landroid_view_View_Landroid_view_accessibility_AccessibilityEvent_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_V(AccessibilityDelegateCompat.n_SendAccessibilityEventUnchecked_Landroid_view_View_Landroid_view_accessibility_AccessibilityEvent_));
			}
			return AccessibilityDelegateCompat.cb_sendAccessibilityEventUnchecked_Landroid_view_View_Landroid_view_accessibility_AccessibilityEvent_;
		}

		// Token: 0x06000826 RID: 2086 RVA: 0x00018DA0 File Offset: 0x00016FA0
		private static void n_SendAccessibilityEventUnchecked_Landroid_view_View_Landroid_view_accessibility_AccessibilityEvent_(IntPtr jnienv, IntPtr native__this, IntPtr native_host, IntPtr native_e)
		{
			AccessibilityDelegateCompat @object = Java.Lang.Object.GetObject<AccessibilityDelegateCompat>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			View object2 = Java.Lang.Object.GetObject<View>(native_host, JniHandleOwnership.DoNotTransfer);
			AccessibilityEvent object3 = Java.Lang.Object.GetObject<AccessibilityEvent>(native_e, JniHandleOwnership.DoNotTransfer);
			@object.SendAccessibilityEventUnchecked(object2, object3);
		}

		// Token: 0x06000827 RID: 2087 RVA: 0x00018DCC File Offset: 0x00016FCC
		[Register("sendAccessibilityEventUnchecked", "(Landroid/view/View;Landroid/view/accessibility/AccessibilityEvent;)V", "GetSendAccessibilityEventUnchecked_Landroid_view_View_Landroid_view_accessibility_AccessibilityEvent_Handler")]
		public unsafe virtual void SendAccessibilityEventUnchecked(View host, AccessibilityEvent e)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((host == null) ? IntPtr.Zero : host.Handle);
				ptr[1] = new JniArgumentValue((e == null) ? IntPtr.Zero : e.Handle);
				AccessibilityDelegateCompat._members.InstanceMethods.InvokeVirtualVoidMethod("sendAccessibilityEventUnchecked.(Landroid/view/View;Landroid/view/accessibility/AccessibilityEvent;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(host);
				GC.KeepAlive(e);
			}
		}

		// Token: 0x04000219 RID: 537
		private static readonly JniPeerMembers _members = new XAPeerMembers("androidx/core/view/AccessibilityDelegateCompat", typeof(AccessibilityDelegateCompat));

		// Token: 0x0400021A RID: 538
		private static Delegate cb_dispatchPopulateAccessibilityEvent_Landroid_view_View_Landroid_view_accessibility_AccessibilityEvent_;

		// Token: 0x0400021B RID: 539
		private static Delegate cb_getAccessibilityNodeProvider_Landroid_view_View_;

		// Token: 0x0400021C RID: 540
		private static Delegate cb_onInitializeAccessibilityEvent_Landroid_view_View_Landroid_view_accessibility_AccessibilityEvent_;

		// Token: 0x0400021D RID: 541
		private static Delegate cb_onInitializeAccessibilityNodeInfo_Landroid_view_View_Landroidx_core_view_accessibility_AccessibilityNodeInfoCompat_;

		// Token: 0x0400021E RID: 542
		private static Delegate cb_onPopulateAccessibilityEvent_Landroid_view_View_Landroid_view_accessibility_AccessibilityEvent_;

		// Token: 0x0400021F RID: 543
		private static Delegate cb_onRequestSendAccessibilityEvent_Landroid_view_ViewGroup_Landroid_view_View_Landroid_view_accessibility_AccessibilityEvent_;

		// Token: 0x04000220 RID: 544
		private static Delegate cb_performAccessibilityAction_Landroid_view_View_ILandroid_os_Bundle_;

		// Token: 0x04000221 RID: 545
		private static Delegate cb_sendAccessibilityEvent_Landroid_view_View_I;

		// Token: 0x04000222 RID: 546
		private static Delegate cb_sendAccessibilityEventUnchecked_Landroid_view_View_Landroid_view_accessibility_AccessibilityEvent_;
	}
}
