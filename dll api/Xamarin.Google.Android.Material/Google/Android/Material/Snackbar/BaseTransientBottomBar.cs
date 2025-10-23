using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Content;
using Android.Runtime;
using Android.Views;
using AndroidX.CoordinatorLayout.Widget;
using Google.Android.Material.Behavior;
using Java.Interop;
using Java.Lang;

namespace Google.Android.Material.Snackbar
{
	// Token: 0x0200008C RID: 140
	[Register("com/google/android/material/snackbar/BaseTransientBottomBar", DoNotGenerateAcw = true)]
	[JavaTypeParameters(new string[]
	{
		"B extends com.google.android.material.snackbar.BaseTransientBottomBar<B>"
	})]
	public abstract class BaseTransientBottomBar : Java.Lang.Object
	{
		// Token: 0x17000179 RID: 377
		// (get) Token: 0x06000986 RID: 2438 RVA: 0x00019DB8 File Offset: 0x00017FB8
		internal static IntPtr class_ref
		{
			get
			{
				return BaseTransientBottomBar._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700017A RID: 378
		// (get) Token: 0x06000987 RID: 2439 RVA: 0x00019DDC File Offset: 0x00017FDC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return BaseTransientBottomBar._members;
			}
		}

		// Token: 0x1700017B RID: 379
		// (get) Token: 0x06000988 RID: 2440 RVA: 0x00019DE4 File Offset: 0x00017FE4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return BaseTransientBottomBar._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700017C RID: 380
		// (get) Token: 0x06000989 RID: 2441 RVA: 0x00019E08 File Offset: 0x00018008
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return BaseTransientBottomBar._members.ManagedPeerType;
			}
		}

		// Token: 0x0600098A RID: 2442 RVA: 0x000020DC File Offset: 0x000002DC
		protected BaseTransientBottomBar(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x0600098B RID: 2443 RVA: 0x00019E14 File Offset: 0x00018014
		[Register(".ctor", "(Landroid/content/Context;Landroid/view/ViewGroup;Landroid/view/View;Lcom/google/android/material/snackbar/ContentViewCallback;)V", "")]
		protected unsafe BaseTransientBottomBar(Context context, ViewGroup parent, View content, IContentViewCallback contentViewCallback) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((context == null) ? IntPtr.Zero : context.Handle);
				ptr[1] = new JniArgumentValue((parent == null) ? IntPtr.Zero : parent.Handle);
				ptr[2] = new JniArgumentValue((content == null) ? IntPtr.Zero : content.Handle);
				ptr[3] = new JniArgumentValue((contentViewCallback == null) ? IntPtr.Zero : ((Java.Lang.Object)contentViewCallback).Handle);
				base.SetHandle(BaseTransientBottomBar._members.InstanceMethods.StartCreateInstance("(Landroid/content/Context;Landroid/view/ViewGroup;Landroid/view/View;Lcom/google/android/material/snackbar/ContentViewCallback;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				BaseTransientBottomBar._members.InstanceMethods.FinishCreateInstance("(Landroid/content/Context;Landroid/view/ViewGroup;Landroid/view/View;Lcom/google/android/material/snackbar/ContentViewCallback;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(context);
				GC.KeepAlive(parent);
				GC.KeepAlive(content);
				GC.KeepAlive(contentViewCallback);
			}
		}

		// Token: 0x0600098C RID: 2444 RVA: 0x00019F48 File Offset: 0x00018148
		[Register(".ctor", "(Landroid/view/ViewGroup;Landroid/view/View;Lcom/google/android/material/snackbar/ContentViewCallback;)V", "")]
		protected unsafe BaseTransientBottomBar(ViewGroup parent, View content, IContentViewCallback contentViewCallback) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((parent == null) ? IntPtr.Zero : parent.Handle);
				ptr[1] = new JniArgumentValue((content == null) ? IntPtr.Zero : content.Handle);
				ptr[2] = new JniArgumentValue((contentViewCallback == null) ? IntPtr.Zero : ((Java.Lang.Object)contentViewCallback).Handle);
				base.SetHandle(BaseTransientBottomBar._members.InstanceMethods.StartCreateInstance("(Landroid/view/ViewGroup;Landroid/view/View;Lcom/google/android/material/snackbar/ContentViewCallback;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				BaseTransientBottomBar._members.InstanceMethods.FinishCreateInstance("(Landroid/view/ViewGroup;Landroid/view/View;Lcom/google/android/material/snackbar/ContentViewCallback;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(parent);
				GC.KeepAlive(content);
				GC.KeepAlive(contentViewCallback);
			}
		}

		// Token: 0x0600098D RID: 2445 RVA: 0x0001A050 File Offset: 0x00018250
		private static Delegate GetGetAnchorViewHandler()
		{
			if (BaseTransientBottomBar.cb_getAnchorView == null)
			{
				BaseTransientBottomBar.cb_getAnchorView = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(BaseTransientBottomBar.n_GetAnchorView));
			}
			return BaseTransientBottomBar.cb_getAnchorView;
		}

		// Token: 0x0600098E RID: 2446 RVA: 0x0001A074 File Offset: 0x00018274
		private static IntPtr n_GetAnchorView(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<BaseTransientBottomBar>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).AnchorView);
		}

		// Token: 0x1700017D RID: 381
		// (get) Token: 0x0600098F RID: 2447 RVA: 0x0001A088 File Offset: 0x00018288
		public virtual View AnchorView
		{
			[Register("getAnchorView", "()Landroid/view/View;", "GetGetAnchorViewHandler")]
			get
			{
				return Java.Lang.Object.GetObject<View>(BaseTransientBottomBar._members.InstanceMethods.InvokeVirtualObjectMethod("getAnchorView.()Landroid/view/View;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06000990 RID: 2448 RVA: 0x0001A0BA File Offset: 0x000182BA
		private static Delegate GetIsAnchorViewLayoutListenerEnabledHandler()
		{
			if (BaseTransientBottomBar.cb_isAnchorViewLayoutListenerEnabled == null)
			{
				BaseTransientBottomBar.cb_isAnchorViewLayoutListenerEnabled = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(BaseTransientBottomBar.n_IsAnchorViewLayoutListenerEnabled));
			}
			return BaseTransientBottomBar.cb_isAnchorViewLayoutListenerEnabled;
		}

		// Token: 0x06000991 RID: 2449 RVA: 0x0001A0DE File Offset: 0x000182DE
		private static bool n_IsAnchorViewLayoutListenerEnabled(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<BaseTransientBottomBar>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).AnchorViewLayoutListenerEnabled;
		}

		// Token: 0x06000992 RID: 2450 RVA: 0x0001A0ED File Offset: 0x000182ED
		private static Delegate GetSetAnchorViewLayoutListenerEnabled_ZHandler()
		{
			if (BaseTransientBottomBar.cb_setAnchorViewLayoutListenerEnabled_Z == null)
			{
				BaseTransientBottomBar.cb_setAnchorViewLayoutListenerEnabled_Z = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPZ_V(BaseTransientBottomBar.n_SetAnchorViewLayoutListenerEnabled_Z));
			}
			return BaseTransientBottomBar.cb_setAnchorViewLayoutListenerEnabled_Z;
		}

		// Token: 0x06000993 RID: 2451 RVA: 0x0001A111 File Offset: 0x00018311
		private static void n_SetAnchorViewLayoutListenerEnabled_Z(IntPtr jnienv, IntPtr native__this, bool anchorViewLayoutListenerEnabled)
		{
			Java.Lang.Object.GetObject<BaseTransientBottomBar>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).AnchorViewLayoutListenerEnabled = anchorViewLayoutListenerEnabled;
		}

		// Token: 0x1700017E RID: 382
		// (get) Token: 0x06000994 RID: 2452 RVA: 0x0001A121 File Offset: 0x00018321
		// (set) Token: 0x06000995 RID: 2453 RVA: 0x0001A13C File Offset: 0x0001833C
		public unsafe virtual bool AnchorViewLayoutListenerEnabled
		{
			[Register("isAnchorViewLayoutListenerEnabled", "()Z", "GetIsAnchorViewLayoutListenerEnabledHandler")]
			get
			{
				return BaseTransientBottomBar._members.InstanceMethods.InvokeVirtualBooleanMethod("isAnchorViewLayoutListenerEnabled.()Z", this, null);
			}
			[Register("setAnchorViewLayoutListenerEnabled", "(Z)V", "GetSetAnchorViewLayoutListenerEnabled_ZHandler")]
			set
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(value);
				BaseTransientBottomBar._members.InstanceMethods.InvokeVirtualVoidMethod("setAnchorViewLayoutListenerEnabled.(Z)V", this, ptr);
			}
		}

		// Token: 0x06000996 RID: 2454 RVA: 0x0001A177 File Offset: 0x00018377
		private static Delegate GetGetAnimationModeHandler()
		{
			if (BaseTransientBottomBar.cb_getAnimationMode == null)
			{
				BaseTransientBottomBar.cb_getAnimationMode = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(BaseTransientBottomBar.n_GetAnimationMode));
			}
			return BaseTransientBottomBar.cb_getAnimationMode;
		}

		// Token: 0x06000997 RID: 2455 RVA: 0x0001A19B File Offset: 0x0001839B
		private static int n_GetAnimationMode(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<BaseTransientBottomBar>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).AnimationMode;
		}

		// Token: 0x1700017F RID: 383
		// (get) Token: 0x06000998 RID: 2456 RVA: 0x0001A1AA File Offset: 0x000183AA
		public virtual int AnimationMode
		{
			[Register("getAnimationMode", "()I", "GetGetAnimationModeHandler")]
			get
			{
				return BaseTransientBottomBar._members.InstanceMethods.InvokeVirtualInt32Method("getAnimationMode.()I", this, null);
			}
		}

		// Token: 0x06000999 RID: 2457 RVA: 0x0001A1C3 File Offset: 0x000183C3
		private static Delegate GetGetContextHandler()
		{
			if (BaseTransientBottomBar.cb_getContext == null)
			{
				BaseTransientBottomBar.cb_getContext = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(BaseTransientBottomBar.n_GetContext));
			}
			return BaseTransientBottomBar.cb_getContext;
		}

		// Token: 0x0600099A RID: 2458 RVA: 0x0001A1E7 File Offset: 0x000183E7
		private static IntPtr n_GetContext(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<BaseTransientBottomBar>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Context);
		}

		// Token: 0x17000180 RID: 384
		// (get) Token: 0x0600099B RID: 2459 RVA: 0x0001A1FC File Offset: 0x000183FC
		public virtual Context Context
		{
			[Register("getContext", "()Landroid/content/Context;", "GetGetContextHandler")]
			get
			{
				return Java.Lang.Object.GetObject<Context>(BaseTransientBottomBar._members.InstanceMethods.InvokeVirtualObjectMethod("getContext.()Landroid/content/Context;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x0600099C RID: 2460 RVA: 0x0001A22E File Offset: 0x0001842E
		private static Delegate GetGetDurationHandler()
		{
			if (BaseTransientBottomBar.cb_getDuration == null)
			{
				BaseTransientBottomBar.cb_getDuration = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(BaseTransientBottomBar.n_GetDuration));
			}
			return BaseTransientBottomBar.cb_getDuration;
		}

		// Token: 0x0600099D RID: 2461 RVA: 0x0001A252 File Offset: 0x00018452
		private static int n_GetDuration(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<BaseTransientBottomBar>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Duration;
		}

		// Token: 0x17000181 RID: 385
		// (get) Token: 0x0600099E RID: 2462 RVA: 0x0001A261 File Offset: 0x00018461
		public virtual int Duration
		{
			[Register("getDuration", "()I", "GetGetDurationHandler")]
			get
			{
				return BaseTransientBottomBar._members.InstanceMethods.InvokeVirtualInt32Method("getDuration.()I", this, null);
			}
		}

		// Token: 0x0600099F RID: 2463 RVA: 0x0001A27A File Offset: 0x0001847A
		private static Delegate GetHasSnackbarStyleAttrHandler()
		{
			if (BaseTransientBottomBar.cb_hasSnackbarStyleAttr == null)
			{
				BaseTransientBottomBar.cb_hasSnackbarStyleAttr = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(BaseTransientBottomBar.n_HasSnackbarStyleAttr));
			}
			return BaseTransientBottomBar.cb_hasSnackbarStyleAttr;
		}

		// Token: 0x060009A0 RID: 2464 RVA: 0x0001A29E File Offset: 0x0001849E
		private static bool n_HasSnackbarStyleAttr(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<BaseTransientBottomBar>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).HasSnackbarStyleAttr;
		}

		// Token: 0x17000182 RID: 386
		// (get) Token: 0x060009A1 RID: 2465 RVA: 0x0001A2AD File Offset: 0x000184AD
		protected virtual bool HasSnackbarStyleAttr
		{
			[Register("hasSnackbarStyleAttr", "()Z", "GetHasSnackbarStyleAttrHandler")]
			get
			{
				return BaseTransientBottomBar._members.InstanceMethods.InvokeVirtualBooleanMethod("hasSnackbarStyleAttr.()Z", this, null);
			}
		}

		// Token: 0x060009A2 RID: 2466 RVA: 0x0001A2C6 File Offset: 0x000184C6
		private static Delegate GetIsGestureInsetBottomIgnoredHandler()
		{
			if (BaseTransientBottomBar.cb_isGestureInsetBottomIgnored == null)
			{
				BaseTransientBottomBar.cb_isGestureInsetBottomIgnored = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(BaseTransientBottomBar.n_IsGestureInsetBottomIgnored));
			}
			return BaseTransientBottomBar.cb_isGestureInsetBottomIgnored;
		}

		// Token: 0x060009A3 RID: 2467 RVA: 0x0001A2EA File Offset: 0x000184EA
		private static bool n_IsGestureInsetBottomIgnored(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<BaseTransientBottomBar>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsGestureInsetBottomIgnored;
		}

		// Token: 0x17000183 RID: 387
		// (get) Token: 0x060009A4 RID: 2468 RVA: 0x0001A2F9 File Offset: 0x000184F9
		public virtual bool IsGestureInsetBottomIgnored
		{
			[Register("isGestureInsetBottomIgnored", "()Z", "GetIsGestureInsetBottomIgnoredHandler")]
			get
			{
				return BaseTransientBottomBar._members.InstanceMethods.InvokeVirtualBooleanMethod("isGestureInsetBottomIgnored.()Z", this, null);
			}
		}

		// Token: 0x060009A5 RID: 2469 RVA: 0x0001A312 File Offset: 0x00018512
		private static Delegate GetIsShownHandler()
		{
			if (BaseTransientBottomBar.cb_isShown == null)
			{
				BaseTransientBottomBar.cb_isShown = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(BaseTransientBottomBar.n_IsShown));
			}
			return BaseTransientBottomBar.cb_isShown;
		}

		// Token: 0x060009A6 RID: 2470 RVA: 0x0001A336 File Offset: 0x00018536
		private static bool n_IsShown(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<BaseTransientBottomBar>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsShown;
		}

		// Token: 0x17000184 RID: 388
		// (get) Token: 0x060009A7 RID: 2471 RVA: 0x0001A345 File Offset: 0x00018545
		public virtual bool IsShown
		{
			[Register("isShown", "()Z", "GetIsShownHandler")]
			get
			{
				return BaseTransientBottomBar._members.InstanceMethods.InvokeVirtualBooleanMethod("isShown.()Z", this, null);
			}
		}

		// Token: 0x060009A8 RID: 2472 RVA: 0x0001A35E File Offset: 0x0001855E
		private static Delegate GetIsShownOrQueuedHandler()
		{
			if (BaseTransientBottomBar.cb_isShownOrQueued == null)
			{
				BaseTransientBottomBar.cb_isShownOrQueued = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(BaseTransientBottomBar.n_IsShownOrQueued));
			}
			return BaseTransientBottomBar.cb_isShownOrQueued;
		}

		// Token: 0x060009A9 RID: 2473 RVA: 0x0001A382 File Offset: 0x00018582
		private static bool n_IsShownOrQueued(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<BaseTransientBottomBar>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsShownOrQueued;
		}

		// Token: 0x17000185 RID: 389
		// (get) Token: 0x060009AA RID: 2474 RVA: 0x0001A391 File Offset: 0x00018591
		public virtual bool IsShownOrQueued
		{
			[Register("isShownOrQueued", "()Z", "GetIsShownOrQueuedHandler")]
			get
			{
				return BaseTransientBottomBar._members.InstanceMethods.InvokeVirtualBooleanMethod("isShownOrQueued.()Z", this, null);
			}
		}

		// Token: 0x060009AB RID: 2475 RVA: 0x0001A3AA File Offset: 0x000185AA
		private static Delegate GetGetNewBehaviorHandler()
		{
			if (BaseTransientBottomBar.cb_getNewBehavior == null)
			{
				BaseTransientBottomBar.cb_getNewBehavior = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(BaseTransientBottomBar.n_GetNewBehavior));
			}
			return BaseTransientBottomBar.cb_getNewBehavior;
		}

		// Token: 0x060009AC RID: 2476 RVA: 0x0001A3CE File Offset: 0x000185CE
		private static IntPtr n_GetNewBehavior(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<BaseTransientBottomBar>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).NewBehavior);
		}

		// Token: 0x17000186 RID: 390
		// (get) Token: 0x060009AD RID: 2477 RVA: 0x0001A3E4 File Offset: 0x000185E4
		protected virtual SwipeDismissBehavior NewBehavior
		{
			[Register("getNewBehavior", "()Lcom/google/android/material/behavior/SwipeDismissBehavior;", "GetGetNewBehaviorHandler")]
			get
			{
				return Java.Lang.Object.GetObject<SwipeDismissBehavior>(BaseTransientBottomBar._members.InstanceMethods.InvokeVirtualObjectMethod("getNewBehavior.()Lcom/google/android/material/behavior/SwipeDismissBehavior;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x060009AE RID: 2478 RVA: 0x0001A416 File Offset: 0x00018616
		private static Delegate GetGetSnackbarBaseLayoutResIdHandler()
		{
			if (BaseTransientBottomBar.cb_getSnackbarBaseLayoutResId == null)
			{
				BaseTransientBottomBar.cb_getSnackbarBaseLayoutResId = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(BaseTransientBottomBar.n_GetSnackbarBaseLayoutResId));
			}
			return BaseTransientBottomBar.cb_getSnackbarBaseLayoutResId;
		}

		// Token: 0x060009AF RID: 2479 RVA: 0x0001A43A File Offset: 0x0001863A
		private static int n_GetSnackbarBaseLayoutResId(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<BaseTransientBottomBar>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SnackbarBaseLayoutResId;
		}

		// Token: 0x17000187 RID: 391
		// (get) Token: 0x060009B0 RID: 2480 RVA: 0x0001A449 File Offset: 0x00018649
		protected virtual int SnackbarBaseLayoutResId
		{
			[Register("getSnackbarBaseLayoutResId", "()I", "GetGetSnackbarBaseLayoutResIdHandler")]
			get
			{
				return BaseTransientBottomBar._members.InstanceMethods.InvokeVirtualInt32Method("getSnackbarBaseLayoutResId.()I", this, null);
			}
		}

		// Token: 0x060009B1 RID: 2481 RVA: 0x0001A462 File Offset: 0x00018662
		private static Delegate GetGetViewHandler()
		{
			if (BaseTransientBottomBar.cb_getView == null)
			{
				BaseTransientBottomBar.cb_getView = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(BaseTransientBottomBar.n_GetView));
			}
			return BaseTransientBottomBar.cb_getView;
		}

		// Token: 0x060009B2 RID: 2482 RVA: 0x0001A486 File Offset: 0x00018686
		private static IntPtr n_GetView(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<BaseTransientBottomBar>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).View);
		}

		// Token: 0x17000188 RID: 392
		// (get) Token: 0x060009B3 RID: 2483 RVA: 0x0001A49C File Offset: 0x0001869C
		public virtual View View
		{
			[Register("getView", "()Landroid/view/View;", "GetGetViewHandler")]
			get
			{
				return Java.Lang.Object.GetObject<View>(BaseTransientBottomBar._members.InstanceMethods.InvokeVirtualObjectMethod("getView.()Landroid/view/View;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x060009B4 RID: 2484 RVA: 0x0001A4CE File Offset: 0x000186CE
		private static Delegate GetAddCallback_Lcom_google_android_material_snackbar_BaseTransientBottomBar_BaseCallback_Handler()
		{
			if (BaseTransientBottomBar.cb_addCallback_Lcom_google_android_material_snackbar_BaseTransientBottomBar_BaseCallback_ == null)
			{
				BaseTransientBottomBar.cb_addCallback_Lcom_google_android_material_snackbar_BaseTransientBottomBar_BaseCallback_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(BaseTransientBottomBar.n_AddCallback_Lcom_google_android_material_snackbar_BaseTransientBottomBar_BaseCallback_));
			}
			return BaseTransientBottomBar.cb_addCallback_Lcom_google_android_material_snackbar_BaseTransientBottomBar_BaseCallback_;
		}

		// Token: 0x060009B5 RID: 2485 RVA: 0x0001A4F4 File Offset: 0x000186F4
		private static IntPtr n_AddCallback_Lcom_google_android_material_snackbar_BaseTransientBottomBar_BaseCallback_(IntPtr jnienv, IntPtr native__this, IntPtr native__callback)
		{
			BaseTransientBottomBar @object = Java.Lang.Object.GetObject<BaseTransientBottomBar>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			BaseTransientBottomBar.BaseCallback object2 = Java.Lang.Object.GetObject<BaseTransientBottomBar.BaseCallback>(native__callback, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.AddCallback(object2));
		}

		// Token: 0x060009B6 RID: 2486 RVA: 0x0001A51C File Offset: 0x0001871C
		[Register("addCallback", "(Lcom/google/android/material/snackbar/BaseTransientBottomBar$BaseCallback;)Lcom/google/android/material/snackbar/BaseTransientBottomBar;", "GetAddCallback_Lcom_google_android_material_snackbar_BaseTransientBottomBar_BaseCallback_Handler")]
		public unsafe virtual Java.Lang.Object AddCallback(BaseTransientBottomBar.BaseCallback callback)
		{
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((callback == null) ? IntPtr.Zero : callback.Handle);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(BaseTransientBottomBar._members.InstanceMethods.InvokeVirtualObjectMethod("addCallback.(Lcom/google/android/material/snackbar/BaseTransientBottomBar$BaseCallback;)Lcom/google/android/material/snackbar/BaseTransientBottomBar;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(callback);
			}
			return @object;
		}

		// Token: 0x060009B7 RID: 2487 RVA: 0x0001A590 File Offset: 0x00018790
		private static Delegate GetDismissHandler()
		{
			if (BaseTransientBottomBar.cb_dismiss == null)
			{
				BaseTransientBottomBar.cb_dismiss = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(BaseTransientBottomBar.n_Dismiss));
			}
			return BaseTransientBottomBar.cb_dismiss;
		}

		// Token: 0x060009B8 RID: 2488 RVA: 0x0001A5B4 File Offset: 0x000187B4
		private static void n_Dismiss(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<BaseTransientBottomBar>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Dismiss();
		}

		// Token: 0x060009B9 RID: 2489 RVA: 0x0001A5C3 File Offset: 0x000187C3
		[Register("dismiss", "()V", "GetDismissHandler")]
		public virtual void Dismiss()
		{
			BaseTransientBottomBar._members.InstanceMethods.InvokeVirtualVoidMethod("dismiss.()V", this, null);
		}

		// Token: 0x060009BA RID: 2490 RVA: 0x0001A5DC File Offset: 0x000187DC
		private static Delegate GetDispatchDismiss_IHandler()
		{
			if (BaseTransientBottomBar.cb_dispatchDismiss_I == null)
			{
				BaseTransientBottomBar.cb_dispatchDismiss_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_V(BaseTransientBottomBar.n_DispatchDismiss_I));
			}
			return BaseTransientBottomBar.cb_dispatchDismiss_I;
		}

		// Token: 0x060009BB RID: 2491 RVA: 0x0001A600 File Offset: 0x00018800
		private static void n_DispatchDismiss_I(IntPtr jnienv, IntPtr native__this, int e)
		{
			Java.Lang.Object.GetObject<BaseTransientBottomBar>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).DispatchDismiss(e);
		}

		// Token: 0x060009BC RID: 2492 RVA: 0x0001A610 File Offset: 0x00018810
		[Register("dispatchDismiss", "(I)V", "GetDispatchDismiss_IHandler")]
		protected unsafe virtual void DispatchDismiss(int e)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(e);
			BaseTransientBottomBar._members.InstanceMethods.InvokeVirtualVoidMethod("dispatchDismiss.(I)V", this, ptr);
		}

		// Token: 0x060009BD RID: 2493 RVA: 0x0001A64B File Offset: 0x0001884B
		private static Delegate GetGetBehaviorHandler()
		{
			if (BaseTransientBottomBar.cb_getBehavior == null)
			{
				BaseTransientBottomBar.cb_getBehavior = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(BaseTransientBottomBar.n_GetBehavior));
			}
			return BaseTransientBottomBar.cb_getBehavior;
		}

		// Token: 0x060009BE RID: 2494 RVA: 0x0001A66F File Offset: 0x0001886F
		private static IntPtr n_GetBehavior(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<BaseTransientBottomBar>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).GetBehavior());
		}

		// Token: 0x060009BF RID: 2495 RVA: 0x0001A684 File Offset: 0x00018884
		[Register("getBehavior", "()Lcom/google/android/material/snackbar/BaseTransientBottomBar$Behavior;", "GetGetBehaviorHandler")]
		public virtual BaseTransientBottomBar.Behavior GetBehavior()
		{
			return Java.Lang.Object.GetObject<BaseTransientBottomBar.Behavior>(BaseTransientBottomBar._members.InstanceMethods.InvokeVirtualObjectMethod("getBehavior.()Lcom/google/android/material/snackbar/BaseTransientBottomBar$Behavior;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x060009C0 RID: 2496 RVA: 0x0001A6B6 File Offset: 0x000188B6
		private static Delegate GetRemoveCallback_Lcom_google_android_material_snackbar_BaseTransientBottomBar_BaseCallback_Handler()
		{
			if (BaseTransientBottomBar.cb_removeCallback_Lcom_google_android_material_snackbar_BaseTransientBottomBar_BaseCallback_ == null)
			{
				BaseTransientBottomBar.cb_removeCallback_Lcom_google_android_material_snackbar_BaseTransientBottomBar_BaseCallback_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(BaseTransientBottomBar.n_RemoveCallback_Lcom_google_android_material_snackbar_BaseTransientBottomBar_BaseCallback_));
			}
			return BaseTransientBottomBar.cb_removeCallback_Lcom_google_android_material_snackbar_BaseTransientBottomBar_BaseCallback_;
		}

		// Token: 0x060009C1 RID: 2497 RVA: 0x0001A6DC File Offset: 0x000188DC
		private static IntPtr n_RemoveCallback_Lcom_google_android_material_snackbar_BaseTransientBottomBar_BaseCallback_(IntPtr jnienv, IntPtr native__this, IntPtr native__callback)
		{
			BaseTransientBottomBar @object = Java.Lang.Object.GetObject<BaseTransientBottomBar>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			BaseTransientBottomBar.BaseCallback object2 = Java.Lang.Object.GetObject<BaseTransientBottomBar.BaseCallback>(native__callback, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.RemoveCallback(object2));
		}

		// Token: 0x060009C2 RID: 2498 RVA: 0x0001A704 File Offset: 0x00018904
		[Register("removeCallback", "(Lcom/google/android/material/snackbar/BaseTransientBottomBar$BaseCallback;)Lcom/google/android/material/snackbar/BaseTransientBottomBar;", "GetRemoveCallback_Lcom_google_android_material_snackbar_BaseTransientBottomBar_BaseCallback_Handler")]
		public unsafe virtual Java.Lang.Object RemoveCallback(BaseTransientBottomBar.BaseCallback callback)
		{
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((callback == null) ? IntPtr.Zero : callback.Handle);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(BaseTransientBottomBar._members.InstanceMethods.InvokeVirtualObjectMethod("removeCallback.(Lcom/google/android/material/snackbar/BaseTransientBottomBar$BaseCallback;)Lcom/google/android/material/snackbar/BaseTransientBottomBar;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(callback);
			}
			return @object;
		}

		// Token: 0x060009C3 RID: 2499 RVA: 0x0001A778 File Offset: 0x00018978
		private static Delegate GetSetAnchorView_Landroid_view_View_Handler()
		{
			if (BaseTransientBottomBar.cb_setAnchorView_Landroid_view_View_ == null)
			{
				BaseTransientBottomBar.cb_setAnchorView_Landroid_view_View_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(BaseTransientBottomBar.n_SetAnchorView_Landroid_view_View_));
			}
			return BaseTransientBottomBar.cb_setAnchorView_Landroid_view_View_;
		}

		// Token: 0x060009C4 RID: 2500 RVA: 0x0001A79C File Offset: 0x0001899C
		private static IntPtr n_SetAnchorView_Landroid_view_View_(IntPtr jnienv, IntPtr native__this, IntPtr native_anchorView)
		{
			BaseTransientBottomBar @object = Java.Lang.Object.GetObject<BaseTransientBottomBar>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			View object2 = Java.Lang.Object.GetObject<View>(native_anchorView, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.SetAnchorView(object2));
		}

		// Token: 0x060009C5 RID: 2501 RVA: 0x0001A7C4 File Offset: 0x000189C4
		[Register("setAnchorView", "(Landroid/view/View;)Lcom/google/android/material/snackbar/BaseTransientBottomBar;", "GetSetAnchorView_Landroid_view_View_Handler")]
		public unsafe virtual Java.Lang.Object SetAnchorView(View anchorView)
		{
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((anchorView == null) ? IntPtr.Zero : anchorView.Handle);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(BaseTransientBottomBar._members.InstanceMethods.InvokeVirtualObjectMethod("setAnchorView.(Landroid/view/View;)Lcom/google/android/material/snackbar/BaseTransientBottomBar;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(anchorView);
			}
			return @object;
		}

		// Token: 0x060009C6 RID: 2502 RVA: 0x0001A838 File Offset: 0x00018A38
		private static Delegate GetSetAnchorView_IHandler()
		{
			if (BaseTransientBottomBar.cb_setAnchorView_I == null)
			{
				BaseTransientBottomBar.cb_setAnchorView_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_L(BaseTransientBottomBar.n_SetAnchorView_I));
			}
			return BaseTransientBottomBar.cb_setAnchorView_I;
		}

		// Token: 0x060009C7 RID: 2503 RVA: 0x0001A85C File Offset: 0x00018A5C
		private static IntPtr n_SetAnchorView_I(IntPtr jnienv, IntPtr native__this, int anchorViewId)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<BaseTransientBottomBar>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SetAnchorView(anchorViewId));
		}

		// Token: 0x060009C8 RID: 2504 RVA: 0x0001A874 File Offset: 0x00018A74
		[Register("setAnchorView", "(I)Lcom/google/android/material/snackbar/BaseTransientBottomBar;", "GetSetAnchorView_IHandler")]
		public unsafe virtual Java.Lang.Object SetAnchorView(int anchorViewId)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(anchorViewId);
			return Java.Lang.Object.GetObject<Java.Lang.Object>(BaseTransientBottomBar._members.InstanceMethods.InvokeVirtualObjectMethod("setAnchorView.(I)Lcom/google/android/material/snackbar/BaseTransientBottomBar;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x060009C9 RID: 2505 RVA: 0x0001A8BD File Offset: 0x00018ABD
		private static Delegate GetSetAnimationMode_IHandler()
		{
			if (BaseTransientBottomBar.cb_setAnimationMode_I == null)
			{
				BaseTransientBottomBar.cb_setAnimationMode_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_L(BaseTransientBottomBar.n_SetAnimationMode_I));
			}
			return BaseTransientBottomBar.cb_setAnimationMode_I;
		}

		// Token: 0x060009CA RID: 2506 RVA: 0x0001A8E1 File Offset: 0x00018AE1
		private static IntPtr n_SetAnimationMode_I(IntPtr jnienv, IntPtr native__this, int animationMode)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<BaseTransientBottomBar>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SetAnimationMode(animationMode));
		}

		// Token: 0x060009CB RID: 2507 RVA: 0x0001A8F8 File Offset: 0x00018AF8
		[Register("setAnimationMode", "(I)Lcom/google/android/material/snackbar/BaseTransientBottomBar;", "GetSetAnimationMode_IHandler")]
		public unsafe virtual Java.Lang.Object SetAnimationMode(int animationMode)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(animationMode);
			return Java.Lang.Object.GetObject<Java.Lang.Object>(BaseTransientBottomBar._members.InstanceMethods.InvokeVirtualObjectMethod("setAnimationMode.(I)Lcom/google/android/material/snackbar/BaseTransientBottomBar;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x060009CC RID: 2508 RVA: 0x0001A941 File Offset: 0x00018B41
		private static Delegate GetSetBehavior_Lcom_google_android_material_snackbar_BaseTransientBottomBar_Behavior_Handler()
		{
			if (BaseTransientBottomBar.cb_setBehavior_Lcom_google_android_material_snackbar_BaseTransientBottomBar_Behavior_ == null)
			{
				BaseTransientBottomBar.cb_setBehavior_Lcom_google_android_material_snackbar_BaseTransientBottomBar_Behavior_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(BaseTransientBottomBar.n_SetBehavior_Lcom_google_android_material_snackbar_BaseTransientBottomBar_Behavior_));
			}
			return BaseTransientBottomBar.cb_setBehavior_Lcom_google_android_material_snackbar_BaseTransientBottomBar_Behavior_;
		}

		// Token: 0x060009CD RID: 2509 RVA: 0x0001A968 File Offset: 0x00018B68
		private static IntPtr n_SetBehavior_Lcom_google_android_material_snackbar_BaseTransientBottomBar_Behavior_(IntPtr jnienv, IntPtr native__this, IntPtr native_behavior)
		{
			BaseTransientBottomBar @object = Java.Lang.Object.GetObject<BaseTransientBottomBar>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			BaseTransientBottomBar.Behavior object2 = Java.Lang.Object.GetObject<BaseTransientBottomBar.Behavior>(native_behavior, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.SetBehavior(object2));
		}

		// Token: 0x060009CE RID: 2510 RVA: 0x0001A990 File Offset: 0x00018B90
		[Register("setBehavior", "(Lcom/google/android/material/snackbar/BaseTransientBottomBar$Behavior;)Lcom/google/android/material/snackbar/BaseTransientBottomBar;", "GetSetBehavior_Lcom_google_android_material_snackbar_BaseTransientBottomBar_Behavior_Handler")]
		public unsafe virtual Java.Lang.Object SetBehavior(BaseTransientBottomBar.Behavior behavior)
		{
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((behavior == null) ? IntPtr.Zero : behavior.Handle);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(BaseTransientBottomBar._members.InstanceMethods.InvokeVirtualObjectMethod("setBehavior.(Lcom/google/android/material/snackbar/BaseTransientBottomBar$Behavior;)Lcom/google/android/material/snackbar/BaseTransientBottomBar;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(behavior);
			}
			return @object;
		}

		// Token: 0x060009CF RID: 2511 RVA: 0x0001AA04 File Offset: 0x00018C04
		private static Delegate GetSetDuration_IHandler()
		{
			if (BaseTransientBottomBar.cb_setDuration_I == null)
			{
				BaseTransientBottomBar.cb_setDuration_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_L(BaseTransientBottomBar.n_SetDuration_I));
			}
			return BaseTransientBottomBar.cb_setDuration_I;
		}

		// Token: 0x060009D0 RID: 2512 RVA: 0x0001AA28 File Offset: 0x00018C28
		private static IntPtr n_SetDuration_I(IntPtr jnienv, IntPtr native__this, int duration)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<BaseTransientBottomBar>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SetDuration(duration));
		}

		// Token: 0x060009D1 RID: 2513 RVA: 0x0001AA40 File Offset: 0x00018C40
		[Register("setDuration", "(I)Lcom/google/android/material/snackbar/BaseTransientBottomBar;", "GetSetDuration_IHandler")]
		public unsafe virtual Java.Lang.Object SetDuration(int duration)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(duration);
			return Java.Lang.Object.GetObject<Java.Lang.Object>(BaseTransientBottomBar._members.InstanceMethods.InvokeVirtualObjectMethod("setDuration.(I)Lcom/google/android/material/snackbar/BaseTransientBottomBar;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x060009D2 RID: 2514 RVA: 0x0001AA89 File Offset: 0x00018C89
		private static Delegate GetSetGestureInsetBottomIgnored_ZHandler()
		{
			if (BaseTransientBottomBar.cb_setGestureInsetBottomIgnored_Z == null)
			{
				BaseTransientBottomBar.cb_setGestureInsetBottomIgnored_Z = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPZ_L(BaseTransientBottomBar.n_SetGestureInsetBottomIgnored_Z));
			}
			return BaseTransientBottomBar.cb_setGestureInsetBottomIgnored_Z;
		}

		// Token: 0x060009D3 RID: 2515 RVA: 0x0001AAAD File Offset: 0x00018CAD
		private static IntPtr n_SetGestureInsetBottomIgnored_Z(IntPtr jnienv, IntPtr native__this, bool gestureInsetBottomIgnored)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<BaseTransientBottomBar>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SetGestureInsetBottomIgnored(gestureInsetBottomIgnored));
		}

		// Token: 0x060009D4 RID: 2516 RVA: 0x0001AAC4 File Offset: 0x00018CC4
		[Register("setGestureInsetBottomIgnored", "(Z)Lcom/google/android/material/snackbar/BaseTransientBottomBar;", "GetSetGestureInsetBottomIgnored_ZHandler")]
		public unsafe virtual Java.Lang.Object SetGestureInsetBottomIgnored(bool gestureInsetBottomIgnored)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(gestureInsetBottomIgnored);
			return Java.Lang.Object.GetObject<Java.Lang.Object>(BaseTransientBottomBar._members.InstanceMethods.InvokeVirtualObjectMethod("setGestureInsetBottomIgnored.(Z)Lcom/google/android/material/snackbar/BaseTransientBottomBar;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x060009D5 RID: 2517 RVA: 0x0001AB0D File Offset: 0x00018D0D
		private static Delegate GetShowHandler()
		{
			if (BaseTransientBottomBar.cb_show == null)
			{
				BaseTransientBottomBar.cb_show = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(BaseTransientBottomBar.n_Show));
			}
			return BaseTransientBottomBar.cb_show;
		}

		// Token: 0x060009D6 RID: 2518 RVA: 0x0001AB31 File Offset: 0x00018D31
		private static void n_Show(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<BaseTransientBottomBar>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Show();
		}

		// Token: 0x060009D7 RID: 2519 RVA: 0x0001AB40 File Offset: 0x00018D40
		[Register("show", "()V", "GetShowHandler")]
		public virtual void Show()
		{
			BaseTransientBottomBar._members.InstanceMethods.InvokeVirtualVoidMethod("show.()V", this, null);
		}

		// Token: 0x040002C0 RID: 704
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/google/android/material/snackbar/BaseTransientBottomBar", typeof(BaseTransientBottomBar));

		// Token: 0x040002C1 RID: 705
		private static Delegate cb_getAnchorView;

		// Token: 0x040002C2 RID: 706
		private static Delegate cb_isAnchorViewLayoutListenerEnabled;

		// Token: 0x040002C3 RID: 707
		private static Delegate cb_setAnchorViewLayoutListenerEnabled_Z;

		// Token: 0x040002C4 RID: 708
		private static Delegate cb_getAnimationMode;

		// Token: 0x040002C5 RID: 709
		private static Delegate cb_getContext;

		// Token: 0x040002C6 RID: 710
		private static Delegate cb_getDuration;

		// Token: 0x040002C7 RID: 711
		private static Delegate cb_hasSnackbarStyleAttr;

		// Token: 0x040002C8 RID: 712
		private static Delegate cb_isGestureInsetBottomIgnored;

		// Token: 0x040002C9 RID: 713
		private static Delegate cb_isShown;

		// Token: 0x040002CA RID: 714
		private static Delegate cb_isShownOrQueued;

		// Token: 0x040002CB RID: 715
		private static Delegate cb_getNewBehavior;

		// Token: 0x040002CC RID: 716
		private static Delegate cb_getSnackbarBaseLayoutResId;

		// Token: 0x040002CD RID: 717
		private static Delegate cb_getView;

		// Token: 0x040002CE RID: 718
		private static Delegate cb_addCallback_Lcom_google_android_material_snackbar_BaseTransientBottomBar_BaseCallback_;

		// Token: 0x040002CF RID: 719
		private static Delegate cb_dismiss;

		// Token: 0x040002D0 RID: 720
		private static Delegate cb_dispatchDismiss_I;

		// Token: 0x040002D1 RID: 721
		private static Delegate cb_getBehavior;

		// Token: 0x040002D2 RID: 722
		private static Delegate cb_removeCallback_Lcom_google_android_material_snackbar_BaseTransientBottomBar_BaseCallback_;

		// Token: 0x040002D3 RID: 723
		private static Delegate cb_setAnchorView_Landroid_view_View_;

		// Token: 0x040002D4 RID: 724
		private static Delegate cb_setAnchorView_I;

		// Token: 0x040002D5 RID: 725
		private static Delegate cb_setAnimationMode_I;

		// Token: 0x040002D6 RID: 726
		private static Delegate cb_setBehavior_Lcom_google_android_material_snackbar_BaseTransientBottomBar_Behavior_;

		// Token: 0x040002D7 RID: 727
		private static Delegate cb_setDuration_I;

		// Token: 0x040002D8 RID: 728
		private static Delegate cb_setGestureInsetBottomIgnored_Z;

		// Token: 0x040002D9 RID: 729
		private static Delegate cb_show;

		// Token: 0x0200008D RID: 141
		[Register("com/google/android/material/snackbar/BaseTransientBottomBar$BaseCallback", DoNotGenerateAcw = true)]
		[JavaTypeParameters(new string[]
		{
			"B"
		})]
		public abstract class BaseCallback : Java.Lang.Object
		{
			// Token: 0x17000189 RID: 393
			// (get) Token: 0x060009D9 RID: 2521 RVA: 0x0001AB74 File Offset: 0x00018D74
			internal static IntPtr class_ref
			{
				get
				{
					return BaseTransientBottomBar.BaseCallback._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x1700018A RID: 394
			// (get) Token: 0x060009DA RID: 2522 RVA: 0x0001AB98 File Offset: 0x00018D98
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return BaseTransientBottomBar.BaseCallback._members;
				}
			}

			// Token: 0x1700018B RID: 395
			// (get) Token: 0x060009DB RID: 2523 RVA: 0x0001ABA0 File Offset: 0x00018DA0
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return BaseTransientBottomBar.BaseCallback._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x1700018C RID: 396
			// (get) Token: 0x060009DC RID: 2524 RVA: 0x0001ABC4 File Offset: 0x00018DC4
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return BaseTransientBottomBar.BaseCallback._members.ManagedPeerType;
				}
			}

			// Token: 0x060009DD RID: 2525 RVA: 0x000020DC File Offset: 0x000002DC
			protected BaseCallback(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
			{
			}

			// Token: 0x060009DE RID: 2526 RVA: 0x0001ABD0 File Offset: 0x00018DD0
			[Register(".ctor", "()V", "")]
			public BaseCallback() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (base.Handle != IntPtr.Zero)
				{
					return;
				}
				base.SetHandle(BaseTransientBottomBar.BaseCallback._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
				BaseTransientBottomBar.BaseCallback._members.InstanceMethods.FinishCreateInstance("()V", this, null);
			}

			// Token: 0x060009DF RID: 2527 RVA: 0x0001AC3E File Offset: 0x00018E3E
			private static Delegate GetOnDismissed_Ljava_lang_Object_IHandler()
			{
				if (BaseTransientBottomBar.BaseCallback.cb_onDismissed_Ljava_lang_Object_I == null)
				{
					BaseTransientBottomBar.BaseCallback.cb_onDismissed_Ljava_lang_Object_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLI_V(BaseTransientBottomBar.BaseCallback.n_OnDismissed_Ljava_lang_Object_I));
				}
				return BaseTransientBottomBar.BaseCallback.cb_onDismissed_Ljava_lang_Object_I;
			}

			// Token: 0x060009E0 RID: 2528 RVA: 0x0001AC64 File Offset: 0x00018E64
			private static void n_OnDismissed_Ljava_lang_Object_I(IntPtr jnienv, IntPtr native__this, IntPtr native_transientBottomBar, int e)
			{
				BaseTransientBottomBar.BaseCallback @object = Java.Lang.Object.GetObject<BaseTransientBottomBar.BaseCallback>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_transientBottomBar, JniHandleOwnership.DoNotTransfer);
				@object.OnDismissed(object2, e);
			}

			// Token: 0x060009E1 RID: 2529 RVA: 0x0001AC88 File Offset: 0x00018E88
			[Register("onDismissed", "(Ljava/lang/Object;I)V", "GetOnDismissed_Ljava_lang_Object_IHandler")]
			public unsafe virtual void OnDismissed(Java.Lang.Object transientBottomBar, int e)
			{
				IntPtr intPtr = JNIEnv.ToLocalJniHandle(transientBottomBar);
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue(intPtr);
					ptr[1] = new JniArgumentValue(e);
					BaseTransientBottomBar.BaseCallback._members.InstanceMethods.InvokeVirtualVoidMethod("onDismissed.(Ljava/lang/Object;I)V", this, ptr);
				}
				finally
				{
					JNIEnv.DeleteLocalRef(intPtr);
					GC.KeepAlive(transientBottomBar);
				}
			}

			// Token: 0x060009E2 RID: 2530 RVA: 0x0001ACFC File Offset: 0x00018EFC
			private static Delegate GetOnShown_Ljava_lang_Object_Handler()
			{
				if (BaseTransientBottomBar.BaseCallback.cb_onShown_Ljava_lang_Object_ == null)
				{
					BaseTransientBottomBar.BaseCallback.cb_onShown_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(BaseTransientBottomBar.BaseCallback.n_OnShown_Ljava_lang_Object_));
				}
				return BaseTransientBottomBar.BaseCallback.cb_onShown_Ljava_lang_Object_;
			}

			// Token: 0x060009E3 RID: 2531 RVA: 0x0001AD20 File Offset: 0x00018F20
			private static void n_OnShown_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_transientBottomBar)
			{
				BaseTransientBottomBar.BaseCallback @object = Java.Lang.Object.GetObject<BaseTransientBottomBar.BaseCallback>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_transientBottomBar, JniHandleOwnership.DoNotTransfer);
				@object.OnShown(object2);
			}

			// Token: 0x060009E4 RID: 2532 RVA: 0x0001AD44 File Offset: 0x00018F44
			[Register("onShown", "(Ljava/lang/Object;)V", "GetOnShown_Ljava_lang_Object_Handler")]
			public unsafe virtual void OnShown(Java.Lang.Object transientBottomBar)
			{
				IntPtr intPtr = JNIEnv.ToLocalJniHandle(transientBottomBar);
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue(intPtr);
					BaseTransientBottomBar.BaseCallback._members.InstanceMethods.InvokeVirtualVoidMethod("onShown.(Ljava/lang/Object;)V", this, ptr);
				}
				finally
				{
					JNIEnv.DeleteLocalRef(intPtr);
					GC.KeepAlive(transientBottomBar);
				}
			}

			// Token: 0x040002DA RID: 730
			private static readonly JniPeerMembers _members = new XAPeerMembers("com/google/android/material/snackbar/BaseTransientBottomBar$BaseCallback", typeof(BaseTransientBottomBar.BaseCallback));

			// Token: 0x040002DB RID: 731
			private static Delegate cb_onDismissed_Ljava_lang_Object_I;

			// Token: 0x040002DC RID: 732
			private static Delegate cb_onShown_Ljava_lang_Object_;
		}

		// Token: 0x0200008E RID: 142
		[Register("com/google/android/material/snackbar/BaseTransientBottomBar$BaseCallback", DoNotGenerateAcw = true)]
		internal class BaseCallbackInvoker : BaseTransientBottomBar.BaseCallback
		{
			// Token: 0x060009E6 RID: 2534 RVA: 0x00019BB4 File Offset: 0x00017DB4
			public BaseCallbackInvoker(IntPtr handle, JniHandleOwnership transfer) : base(handle, transfer)
			{
			}

			// Token: 0x1700018D RID: 397
			// (get) Token: 0x060009E7 RID: 2535 RVA: 0x0001ADC3 File Offset: 0x00018FC3
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return BaseTransientBottomBar.BaseCallbackInvoker._members;
				}
			}

			// Token: 0x1700018E RID: 398
			// (get) Token: 0x060009E8 RID: 2536 RVA: 0x0001ADCA File Offset: 0x00018FCA
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return BaseTransientBottomBar.BaseCallbackInvoker._members.ManagedPeerType;
				}
			}

			// Token: 0x040002DD RID: 733
			private static readonly JniPeerMembers _members = new XAPeerMembers("com/google/android/material/snackbar/BaseTransientBottomBar$BaseCallback", typeof(BaseTransientBottomBar.BaseCallbackInvoker));
		}

		// Token: 0x0200008F RID: 143
		[Register("com/google/android/material/snackbar/BaseTransientBottomBar$Behavior", DoNotGenerateAcw = true)]
		public class Behavior : SwipeDismissBehavior
		{
			// Token: 0x1700018F RID: 399
			// (get) Token: 0x060009EA RID: 2538 RVA: 0x0001ADF4 File Offset: 0x00018FF4
			internal new static IntPtr class_ref
			{
				get
				{
					return BaseTransientBottomBar.Behavior._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x17000190 RID: 400
			// (get) Token: 0x060009EB RID: 2539 RVA: 0x0001AE18 File Offset: 0x00019018
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return BaseTransientBottomBar.Behavior._members;
				}
			}

			// Token: 0x17000191 RID: 401
			// (get) Token: 0x060009EC RID: 2540 RVA: 0x0001AE20 File Offset: 0x00019020
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return BaseTransientBottomBar.Behavior._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x17000192 RID: 402
			// (get) Token: 0x060009ED RID: 2541 RVA: 0x0001AE44 File Offset: 0x00019044
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return BaseTransientBottomBar.Behavior._members.ManagedPeerType;
				}
			}

			// Token: 0x060009EE RID: 2542 RVA: 0x0001AE50 File Offset: 0x00019050
			protected Behavior(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
			{
			}

			// Token: 0x060009EF RID: 2543 RVA: 0x0001AE5C File Offset: 0x0001905C
			[Register(".ctor", "()V", "")]
			public Behavior() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (base.Handle != IntPtr.Zero)
				{
					return;
				}
				base.SetHandle(BaseTransientBottomBar.Behavior._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
				BaseTransientBottomBar.Behavior._members.InstanceMethods.FinishCreateInstance("()V", this, null);
			}

			// Token: 0x060009F0 RID: 2544 RVA: 0x0001AECA File Offset: 0x000190CA
			private static Delegate GetOnInterceptTouchEvent_Landroidx_coordinatorlayout_widget_CoordinatorLayout_Landroid_view_View_Landroid_view_MotionEvent_Handler()
			{
				if (BaseTransientBottomBar.Behavior.cb_onInterceptTouchEvent_Landroidx_coordinatorlayout_widget_CoordinatorLayout_Landroid_view_View_Landroid_view_MotionEvent_ == null)
				{
					BaseTransientBottomBar.Behavior.cb_onInterceptTouchEvent_Landroidx_coordinatorlayout_widget_CoordinatorLayout_Landroid_view_View_Landroid_view_MotionEvent_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLLL_Z(BaseTransientBottomBar.Behavior.n_OnInterceptTouchEvent_Landroidx_coordinatorlayout_widget_CoordinatorLayout_Landroid_view_View_Landroid_view_MotionEvent_));
				}
				return BaseTransientBottomBar.Behavior.cb_onInterceptTouchEvent_Landroidx_coordinatorlayout_widget_CoordinatorLayout_Landroid_view_View_Landroid_view_MotionEvent_;
			}

			// Token: 0x060009F1 RID: 2545 RVA: 0x0001AEF0 File Offset: 0x000190F0
			private static bool n_OnInterceptTouchEvent_Landroidx_coordinatorlayout_widget_CoordinatorLayout_Landroid_view_View_Landroid_view_MotionEvent_(IntPtr jnienv, IntPtr native__this, IntPtr native_parent, IntPtr native_child, IntPtr native_e)
			{
				CoordinatorLayout.Behavior @object = Java.Lang.Object.GetObject<BaseTransientBottomBar.Behavior>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				CoordinatorLayout object2 = Java.Lang.Object.GetObject<CoordinatorLayout>(native_parent, JniHandleOwnership.DoNotTransfer);
				View object3 = Java.Lang.Object.GetObject<View>(native_child, JniHandleOwnership.DoNotTransfer);
				MotionEvent object4 = Java.Lang.Object.GetObject<MotionEvent>(native_e, JniHandleOwnership.DoNotTransfer);
				return @object.OnInterceptTouchEvent(object2, object3, object4);
			}

			// Token: 0x060009F2 RID: 2546 RVA: 0x0001AF28 File Offset: 0x00019128
			[Register("onInterceptTouchEvent", "(Landroidx/coordinatorlayout/widget/CoordinatorLayout;Landroid/view/View;Landroid/view/MotionEvent;)Z", "GetOnInterceptTouchEvent_Landroidx_coordinatorlayout_widget_CoordinatorLayout_Landroid_view_View_Landroid_view_MotionEvent_Handler")]
			public unsafe override bool OnInterceptTouchEvent(CoordinatorLayout parent, Java.Lang.Object child, MotionEvent e)
			{
				bool result;
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((parent == null) ? IntPtr.Zero : parent.Handle);
					ptr[1] = new JniArgumentValue((child == null) ? IntPtr.Zero : child.Handle);
					ptr[2] = new JniArgumentValue((e == null) ? IntPtr.Zero : e.Handle);
					result = BaseTransientBottomBar.Behavior._members.InstanceMethods.InvokeVirtualBooleanMethod("onInterceptTouchEvent.(Landroidx/coordinatorlayout/widget/CoordinatorLayout;Landroid/view/View;Landroid/view/MotionEvent;)Z", this, ptr);
				}
				finally
				{
					GC.KeepAlive(parent);
					GC.KeepAlive(child);
					GC.KeepAlive(e);
				}
				return result;
			}

			// Token: 0x040002DE RID: 734
			private static readonly JniPeerMembers _members = new XAPeerMembers("com/google/android/material/snackbar/BaseTransientBottomBar$Behavior", typeof(BaseTransientBottomBar.Behavior));

			// Token: 0x040002DF RID: 735
			private static Delegate cb_onInterceptTouchEvent_Landroidx_coordinatorlayout_widget_CoordinatorLayout_Landroid_view_View_Landroid_view_MotionEvent_;
		}
	}
}
