using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Graphics;
using Android.Runtime;
using Android.Views.Accessibility;
using AndroidX.Core.OS;
using Java.Interop;
using Java.Lang;

namespace AndroidX.Core.View.Accessibility
{
	// Token: 0x020000C5 RID: 197
	[Register("androidx/core/view/accessibility/AccessibilityWindowInfoCompat", DoNotGenerateAcw = true)]
	public class AccessibilityWindowInfoCompat : Java.Lang.Object
	{
		// Token: 0x170002B5 RID: 693
		// (get) Token: 0x06000DB2 RID: 3506 RVA: 0x00028F90 File Offset: 0x00027190
		internal static IntPtr class_ref
		{
			get
			{
				return AccessibilityWindowInfoCompat._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170002B6 RID: 694
		// (get) Token: 0x06000DB3 RID: 3507 RVA: 0x00028FB4 File Offset: 0x000271B4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return AccessibilityWindowInfoCompat._members;
			}
		}

		// Token: 0x170002B7 RID: 695
		// (get) Token: 0x06000DB4 RID: 3508 RVA: 0x00028FBC File Offset: 0x000271BC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return AccessibilityWindowInfoCompat._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170002B8 RID: 696
		// (get) Token: 0x06000DB5 RID: 3509 RVA: 0x00028FE0 File Offset: 0x000271E0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return AccessibilityWindowInfoCompat._members.ManagedPeerType;
			}
		}

		// Token: 0x06000DB6 RID: 3510 RVA: 0x00002384 File Offset: 0x00000584
		protected AccessibilityWindowInfoCompat(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000DB7 RID: 3511 RVA: 0x00028FEC File Offset: 0x000271EC
		[Register(".ctor", "()V", "")]
		public AccessibilityWindowInfoCompat() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			base.SetHandle(AccessibilityWindowInfoCompat._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
			AccessibilityWindowInfoCompat._members.InstanceMethods.FinishCreateInstance("()V", this, null);
		}

		// Token: 0x06000DB8 RID: 3512 RVA: 0x0002905A File Offset: 0x0002725A
		private static Delegate GetGetAnchorHandler()
		{
			if (AccessibilityWindowInfoCompat.cb_getAnchor == null)
			{
				AccessibilityWindowInfoCompat.cb_getAnchor = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(AccessibilityWindowInfoCompat.n_GetAnchor));
			}
			return AccessibilityWindowInfoCompat.cb_getAnchor;
		}

		// Token: 0x06000DB9 RID: 3513 RVA: 0x0002907E File Offset: 0x0002727E
		private static IntPtr n_GetAnchor(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<AccessibilityWindowInfoCompat>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Anchor);
		}

		// Token: 0x170002B9 RID: 697
		// (get) Token: 0x06000DBA RID: 3514 RVA: 0x00029094 File Offset: 0x00027294
		public virtual AccessibilityNodeInfoCompat Anchor
		{
			[Register("getAnchor", "()Landroidx/core/view/accessibility/AccessibilityNodeInfoCompat;", "GetGetAnchorHandler")]
			get
			{
				return Java.Lang.Object.GetObject<AccessibilityNodeInfoCompat>(AccessibilityWindowInfoCompat._members.InstanceMethods.InvokeVirtualObjectMethod("getAnchor.()Landroidx/core/view/accessibility/AccessibilityNodeInfoCompat;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06000DBB RID: 3515 RVA: 0x000290C6 File Offset: 0x000272C6
		private static Delegate GetGetChildCountHandler()
		{
			if (AccessibilityWindowInfoCompat.cb_getChildCount == null)
			{
				AccessibilityWindowInfoCompat.cb_getChildCount = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(AccessibilityWindowInfoCompat.n_GetChildCount));
			}
			return AccessibilityWindowInfoCompat.cb_getChildCount;
		}

		// Token: 0x06000DBC RID: 3516 RVA: 0x000290EA File Offset: 0x000272EA
		private static int n_GetChildCount(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<AccessibilityWindowInfoCompat>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ChildCount;
		}

		// Token: 0x170002BA RID: 698
		// (get) Token: 0x06000DBD RID: 3517 RVA: 0x000290F9 File Offset: 0x000272F9
		public virtual int ChildCount
		{
			[Register("getChildCount", "()I", "GetGetChildCountHandler")]
			get
			{
				return AccessibilityWindowInfoCompat._members.InstanceMethods.InvokeVirtualInt32Method("getChildCount.()I", this, null);
			}
		}

		// Token: 0x06000DBE RID: 3518 RVA: 0x00029112 File Offset: 0x00027312
		private static Delegate GetGetDisplayIdHandler()
		{
			if (AccessibilityWindowInfoCompat.cb_getDisplayId == null)
			{
				AccessibilityWindowInfoCompat.cb_getDisplayId = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(AccessibilityWindowInfoCompat.n_GetDisplayId));
			}
			return AccessibilityWindowInfoCompat.cb_getDisplayId;
		}

		// Token: 0x06000DBF RID: 3519 RVA: 0x00029136 File Offset: 0x00027336
		private static int n_GetDisplayId(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<AccessibilityWindowInfoCompat>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).DisplayId;
		}

		// Token: 0x170002BB RID: 699
		// (get) Token: 0x06000DC0 RID: 3520 RVA: 0x00029145 File Offset: 0x00027345
		public virtual int DisplayId
		{
			[Register("getDisplayId", "()I", "GetGetDisplayIdHandler")]
			get
			{
				return AccessibilityWindowInfoCompat._members.InstanceMethods.InvokeVirtualInt32Method("getDisplayId.()I", this, null);
			}
		}

		// Token: 0x06000DC1 RID: 3521 RVA: 0x0002915E File Offset: 0x0002735E
		private static Delegate GetGetIdHandler()
		{
			if (AccessibilityWindowInfoCompat.cb_getId == null)
			{
				AccessibilityWindowInfoCompat.cb_getId = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(AccessibilityWindowInfoCompat.n_GetId));
			}
			return AccessibilityWindowInfoCompat.cb_getId;
		}

		// Token: 0x06000DC2 RID: 3522 RVA: 0x00029182 File Offset: 0x00027382
		private static int n_GetId(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<AccessibilityWindowInfoCompat>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Id;
		}

		// Token: 0x170002BC RID: 700
		// (get) Token: 0x06000DC3 RID: 3523 RVA: 0x00029191 File Offset: 0x00027391
		public virtual int Id
		{
			[Register("getId", "()I", "GetGetIdHandler")]
			get
			{
				return AccessibilityWindowInfoCompat._members.InstanceMethods.InvokeVirtualInt32Method("getId.()I", this, null);
			}
		}

		// Token: 0x06000DC4 RID: 3524 RVA: 0x000291AA File Offset: 0x000273AA
		private static Delegate GetIsAccessibilityFocusedHandler()
		{
			if (AccessibilityWindowInfoCompat.cb_isAccessibilityFocused == null)
			{
				AccessibilityWindowInfoCompat.cb_isAccessibilityFocused = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(AccessibilityWindowInfoCompat.n_IsAccessibilityFocused));
			}
			return AccessibilityWindowInfoCompat.cb_isAccessibilityFocused;
		}

		// Token: 0x06000DC5 RID: 3525 RVA: 0x000291CE File Offset: 0x000273CE
		private static bool n_IsAccessibilityFocused(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<AccessibilityWindowInfoCompat>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsAccessibilityFocused;
		}

		// Token: 0x170002BD RID: 701
		// (get) Token: 0x06000DC6 RID: 3526 RVA: 0x000291DD File Offset: 0x000273DD
		public virtual bool IsAccessibilityFocused
		{
			[Register("isAccessibilityFocused", "()Z", "GetIsAccessibilityFocusedHandler")]
			get
			{
				return AccessibilityWindowInfoCompat._members.InstanceMethods.InvokeVirtualBooleanMethod("isAccessibilityFocused.()Z", this, null);
			}
		}

		// Token: 0x06000DC7 RID: 3527 RVA: 0x000291F6 File Offset: 0x000273F6
		private static Delegate GetIsActiveHandler()
		{
			if (AccessibilityWindowInfoCompat.cb_isActive == null)
			{
				AccessibilityWindowInfoCompat.cb_isActive = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(AccessibilityWindowInfoCompat.n_IsActive));
			}
			return AccessibilityWindowInfoCompat.cb_isActive;
		}

		// Token: 0x06000DC8 RID: 3528 RVA: 0x0002921A File Offset: 0x0002741A
		private static bool n_IsActive(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<AccessibilityWindowInfoCompat>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsActive;
		}

		// Token: 0x170002BE RID: 702
		// (get) Token: 0x06000DC9 RID: 3529 RVA: 0x00029229 File Offset: 0x00027429
		public virtual bool IsActive
		{
			[Register("isActive", "()Z", "GetIsActiveHandler")]
			get
			{
				return AccessibilityWindowInfoCompat._members.InstanceMethods.InvokeVirtualBooleanMethod("isActive.()Z", this, null);
			}
		}

		// Token: 0x06000DCA RID: 3530 RVA: 0x00029242 File Offset: 0x00027442
		private static Delegate GetIsFocusedHandler()
		{
			if (AccessibilityWindowInfoCompat.cb_isFocused == null)
			{
				AccessibilityWindowInfoCompat.cb_isFocused = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(AccessibilityWindowInfoCompat.n_IsFocused));
			}
			return AccessibilityWindowInfoCompat.cb_isFocused;
		}

		// Token: 0x06000DCB RID: 3531 RVA: 0x00029266 File Offset: 0x00027466
		private static bool n_IsFocused(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<AccessibilityWindowInfoCompat>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsFocused;
		}

		// Token: 0x170002BF RID: 703
		// (get) Token: 0x06000DCC RID: 3532 RVA: 0x00029275 File Offset: 0x00027475
		public virtual bool IsFocused
		{
			[Register("isFocused", "()Z", "GetIsFocusedHandler")]
			get
			{
				return AccessibilityWindowInfoCompat._members.InstanceMethods.InvokeVirtualBooleanMethod("isFocused.()Z", this, null);
			}
		}

		// Token: 0x06000DCD RID: 3533 RVA: 0x0002928E File Offset: 0x0002748E
		private static Delegate GetIsInPictureInPictureModeHandler()
		{
			if (AccessibilityWindowInfoCompat.cb_isInPictureInPictureMode == null)
			{
				AccessibilityWindowInfoCompat.cb_isInPictureInPictureMode = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(AccessibilityWindowInfoCompat.n_IsInPictureInPictureMode));
			}
			return AccessibilityWindowInfoCompat.cb_isInPictureInPictureMode;
		}

		// Token: 0x06000DCE RID: 3534 RVA: 0x000292B2 File Offset: 0x000274B2
		private static bool n_IsInPictureInPictureMode(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<AccessibilityWindowInfoCompat>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsInPictureInPictureMode;
		}

		// Token: 0x170002C0 RID: 704
		// (get) Token: 0x06000DCF RID: 3535 RVA: 0x000292C1 File Offset: 0x000274C1
		public virtual bool IsInPictureInPictureMode
		{
			[Register("isInPictureInPictureMode", "()Z", "GetIsInPictureInPictureModeHandler")]
			get
			{
				return AccessibilityWindowInfoCompat._members.InstanceMethods.InvokeVirtualBooleanMethod("isInPictureInPictureMode.()Z", this, null);
			}
		}

		// Token: 0x06000DD0 RID: 3536 RVA: 0x000292DA File Offset: 0x000274DA
		private static Delegate GetGetLayerHandler()
		{
			if (AccessibilityWindowInfoCompat.cb_getLayer == null)
			{
				AccessibilityWindowInfoCompat.cb_getLayer = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(AccessibilityWindowInfoCompat.n_GetLayer));
			}
			return AccessibilityWindowInfoCompat.cb_getLayer;
		}

		// Token: 0x06000DD1 RID: 3537 RVA: 0x000292FE File Offset: 0x000274FE
		private static int n_GetLayer(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<AccessibilityWindowInfoCompat>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Layer;
		}

		// Token: 0x170002C1 RID: 705
		// (get) Token: 0x06000DD2 RID: 3538 RVA: 0x0002930D File Offset: 0x0002750D
		public virtual int Layer
		{
			[Register("getLayer", "()I", "GetGetLayerHandler")]
			get
			{
				return AccessibilityWindowInfoCompat._members.InstanceMethods.InvokeVirtualInt32Method("getLayer.()I", this, null);
			}
		}

		// Token: 0x06000DD3 RID: 3539 RVA: 0x00029326 File Offset: 0x00027526
		private static Delegate GetGetLocalesHandler()
		{
			if (AccessibilityWindowInfoCompat.cb_getLocales == null)
			{
				AccessibilityWindowInfoCompat.cb_getLocales = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(AccessibilityWindowInfoCompat.n_GetLocales));
			}
			return AccessibilityWindowInfoCompat.cb_getLocales;
		}

		// Token: 0x06000DD4 RID: 3540 RVA: 0x0002934A File Offset: 0x0002754A
		private static IntPtr n_GetLocales(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<AccessibilityWindowInfoCompat>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Locales);
		}

		// Token: 0x170002C2 RID: 706
		// (get) Token: 0x06000DD5 RID: 3541 RVA: 0x00029360 File Offset: 0x00027560
		public virtual LocaleListCompat Locales
		{
			[Register("getLocales", "()Landroidx/core/os/LocaleListCompat;", "GetGetLocalesHandler")]
			get
			{
				return Java.Lang.Object.GetObject<LocaleListCompat>(AccessibilityWindowInfoCompat._members.InstanceMethods.InvokeVirtualObjectMethod("getLocales.()Landroidx/core/os/LocaleListCompat;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06000DD6 RID: 3542 RVA: 0x00029392 File Offset: 0x00027592
		private static Delegate GetGetParentHandler()
		{
			if (AccessibilityWindowInfoCompat.cb_getParent == null)
			{
				AccessibilityWindowInfoCompat.cb_getParent = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(AccessibilityWindowInfoCompat.n_GetParent));
			}
			return AccessibilityWindowInfoCompat.cb_getParent;
		}

		// Token: 0x06000DD7 RID: 3543 RVA: 0x000293B6 File Offset: 0x000275B6
		private static IntPtr n_GetParent(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<AccessibilityWindowInfoCompat>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Parent);
		}

		// Token: 0x170002C3 RID: 707
		// (get) Token: 0x06000DD8 RID: 3544 RVA: 0x000293CC File Offset: 0x000275CC
		public virtual AccessibilityWindowInfoCompat Parent
		{
			[Register("getParent", "()Landroidx/core/view/accessibility/AccessibilityWindowInfoCompat;", "GetGetParentHandler")]
			get
			{
				return Java.Lang.Object.GetObject<AccessibilityWindowInfoCompat>(AccessibilityWindowInfoCompat._members.InstanceMethods.InvokeVirtualObjectMethod("getParent.()Landroidx/core/view/accessibility/AccessibilityWindowInfoCompat;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06000DD9 RID: 3545 RVA: 0x000293FE File Offset: 0x000275FE
		private static Delegate GetGetRootHandler()
		{
			if (AccessibilityWindowInfoCompat.cb_getRoot == null)
			{
				AccessibilityWindowInfoCompat.cb_getRoot = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(AccessibilityWindowInfoCompat.n_GetRoot));
			}
			return AccessibilityWindowInfoCompat.cb_getRoot;
		}

		// Token: 0x06000DDA RID: 3546 RVA: 0x00029422 File Offset: 0x00027622
		private static IntPtr n_GetRoot(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<AccessibilityWindowInfoCompat>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Root);
		}

		// Token: 0x170002C4 RID: 708
		// (get) Token: 0x06000DDB RID: 3547 RVA: 0x00029438 File Offset: 0x00027638
		public virtual AccessibilityNodeInfoCompat Root
		{
			[Register("getRoot", "()Landroidx/core/view/accessibility/AccessibilityNodeInfoCompat;", "GetGetRootHandler")]
			get
			{
				return Java.Lang.Object.GetObject<AccessibilityNodeInfoCompat>(AccessibilityWindowInfoCompat._members.InstanceMethods.InvokeVirtualObjectMethod("getRoot.()Landroidx/core/view/accessibility/AccessibilityNodeInfoCompat;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06000DDC RID: 3548 RVA: 0x0002946A File Offset: 0x0002766A
		private static Delegate GetGetTitleHandler()
		{
			if (AccessibilityWindowInfoCompat.cb_getTitle == null)
			{
				AccessibilityWindowInfoCompat.cb_getTitle = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(AccessibilityWindowInfoCompat.n_GetTitle));
			}
			return AccessibilityWindowInfoCompat.cb_getTitle;
		}

		// Token: 0x06000DDD RID: 3549 RVA: 0x0002948E File Offset: 0x0002768E
		private static IntPtr n_GetTitle(IntPtr jnienv, IntPtr native__this)
		{
			return CharSequence.ToLocalJniHandle(Java.Lang.Object.GetObject<AccessibilityWindowInfoCompat>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).TitleFormatted);
		}

		// Token: 0x170002C5 RID: 709
		// (get) Token: 0x06000DDE RID: 3550 RVA: 0x000294A4 File Offset: 0x000276A4
		public virtual ICharSequence TitleFormatted
		{
			[Register("getTitle", "()Ljava/lang/CharSequence;", "GetGetTitleHandler")]
			get
			{
				return Java.Lang.Object.GetObject<ICharSequence>(AccessibilityWindowInfoCompat._members.InstanceMethods.InvokeVirtualObjectMethod("getTitle.()Ljava/lang/CharSequence;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x170002C6 RID: 710
		// (get) Token: 0x06000DDF RID: 3551 RVA: 0x000294D6 File Offset: 0x000276D6
		public string Title
		{
			get
			{
				if (this.TitleFormatted != null)
				{
					return this.TitleFormatted.ToString();
				}
				return null;
			}
		}

		// Token: 0x06000DE0 RID: 3552 RVA: 0x000294ED File Offset: 0x000276ED
		private static Delegate GetGetTransitionTimeMillisHandler()
		{
			if (AccessibilityWindowInfoCompat.cb_getTransitionTimeMillis == null)
			{
				AccessibilityWindowInfoCompat.cb_getTransitionTimeMillis = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_J(AccessibilityWindowInfoCompat.n_GetTransitionTimeMillis));
			}
			return AccessibilityWindowInfoCompat.cb_getTransitionTimeMillis;
		}

		// Token: 0x06000DE1 RID: 3553 RVA: 0x00029511 File Offset: 0x00027711
		private static long n_GetTransitionTimeMillis(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<AccessibilityWindowInfoCompat>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).TransitionTimeMillis;
		}

		// Token: 0x170002C7 RID: 711
		// (get) Token: 0x06000DE2 RID: 3554 RVA: 0x00029520 File Offset: 0x00027720
		public virtual long TransitionTimeMillis
		{
			[Register("getTransitionTimeMillis", "()J", "GetGetTransitionTimeMillisHandler")]
			get
			{
				return AccessibilityWindowInfoCompat._members.InstanceMethods.InvokeVirtualInt64Method("getTransitionTimeMillis.()J", this, null);
			}
		}

		// Token: 0x06000DE3 RID: 3555 RVA: 0x00029539 File Offset: 0x00027739
		private static Delegate GetGetTypeHandler()
		{
			if (AccessibilityWindowInfoCompat.cb_getType == null)
			{
				AccessibilityWindowInfoCompat.cb_getType = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(AccessibilityWindowInfoCompat.n_GetType));
			}
			return AccessibilityWindowInfoCompat.cb_getType;
		}

		// Token: 0x06000DE4 RID: 3556 RVA: 0x0002955D File Offset: 0x0002775D
		private static int n_GetType(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<AccessibilityWindowInfoCompat>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Type;
		}

		// Token: 0x170002C8 RID: 712
		// (get) Token: 0x06000DE5 RID: 3557 RVA: 0x0002956C File Offset: 0x0002776C
		public virtual int Type
		{
			[Register("getType", "()I", "GetGetTypeHandler")]
			get
			{
				return AccessibilityWindowInfoCompat._members.InstanceMethods.InvokeVirtualInt32Method("getType.()I", this, null);
			}
		}

		// Token: 0x06000DE6 RID: 3558 RVA: 0x00029585 File Offset: 0x00027785
		private static Delegate GetGetBoundsInScreen_Landroid_graphics_Rect_Handler()
		{
			if (AccessibilityWindowInfoCompat.cb_getBoundsInScreen_Landroid_graphics_Rect_ == null)
			{
				AccessibilityWindowInfoCompat.cb_getBoundsInScreen_Landroid_graphics_Rect_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(AccessibilityWindowInfoCompat.n_GetBoundsInScreen_Landroid_graphics_Rect_));
			}
			return AccessibilityWindowInfoCompat.cb_getBoundsInScreen_Landroid_graphics_Rect_;
		}

		// Token: 0x06000DE7 RID: 3559 RVA: 0x000295AC File Offset: 0x000277AC
		private static void n_GetBoundsInScreen_Landroid_graphics_Rect_(IntPtr jnienv, IntPtr native__this, IntPtr native_outBounds)
		{
			AccessibilityWindowInfoCompat @object = Java.Lang.Object.GetObject<AccessibilityWindowInfoCompat>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Rect object2 = Java.Lang.Object.GetObject<Rect>(native_outBounds, JniHandleOwnership.DoNotTransfer);
			@object.GetBoundsInScreen(object2);
		}

		// Token: 0x06000DE8 RID: 3560 RVA: 0x000295D0 File Offset: 0x000277D0
		[Register("getBoundsInScreen", "(Landroid/graphics/Rect;)V", "GetGetBoundsInScreen_Landroid_graphics_Rect_Handler")]
		public unsafe virtual void GetBoundsInScreen(Rect outBounds)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((outBounds == null) ? IntPtr.Zero : outBounds.Handle);
				AccessibilityWindowInfoCompat._members.InstanceMethods.InvokeVirtualVoidMethod("getBoundsInScreen.(Landroid/graphics/Rect;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(outBounds);
			}
		}

		// Token: 0x06000DE9 RID: 3561 RVA: 0x00029634 File Offset: 0x00027834
		private static Delegate GetGetChild_IHandler()
		{
			if (AccessibilityWindowInfoCompat.cb_getChild_I == null)
			{
				AccessibilityWindowInfoCompat.cb_getChild_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_L(AccessibilityWindowInfoCompat.n_GetChild_I));
			}
			return AccessibilityWindowInfoCompat.cb_getChild_I;
		}

		// Token: 0x06000DEA RID: 3562 RVA: 0x00029658 File Offset: 0x00027858
		private static IntPtr n_GetChild_I(IntPtr jnienv, IntPtr native__this, int index)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<AccessibilityWindowInfoCompat>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).GetChild(index));
		}

		// Token: 0x06000DEB RID: 3563 RVA: 0x00029670 File Offset: 0x00027870
		[Register("getChild", "(I)Landroidx/core/view/accessibility/AccessibilityWindowInfoCompat;", "GetGetChild_IHandler")]
		public unsafe virtual AccessibilityWindowInfoCompat GetChild(int index)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(index);
			return Java.Lang.Object.GetObject<AccessibilityWindowInfoCompat>(AccessibilityWindowInfoCompat._members.InstanceMethods.InvokeVirtualObjectMethod("getChild.(I)Landroidx/core/view/accessibility/AccessibilityWindowInfoCompat;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06000DEC RID: 3564 RVA: 0x000296B9 File Offset: 0x000278B9
		private static Delegate GetGetRegionInScreen_Landroid_graphics_Region_Handler()
		{
			if (AccessibilityWindowInfoCompat.cb_getRegionInScreen_Landroid_graphics_Region_ == null)
			{
				AccessibilityWindowInfoCompat.cb_getRegionInScreen_Landroid_graphics_Region_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(AccessibilityWindowInfoCompat.n_GetRegionInScreen_Landroid_graphics_Region_));
			}
			return AccessibilityWindowInfoCompat.cb_getRegionInScreen_Landroid_graphics_Region_;
		}

		// Token: 0x06000DED RID: 3565 RVA: 0x000296E0 File Offset: 0x000278E0
		private static void n_GetRegionInScreen_Landroid_graphics_Region_(IntPtr jnienv, IntPtr native__this, IntPtr native_outRegion)
		{
			AccessibilityWindowInfoCompat @object = Java.Lang.Object.GetObject<AccessibilityWindowInfoCompat>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Region object2 = Java.Lang.Object.GetObject<Region>(native_outRegion, JniHandleOwnership.DoNotTransfer);
			@object.GetRegionInScreen(object2);
		}

		// Token: 0x06000DEE RID: 3566 RVA: 0x00029704 File Offset: 0x00027904
		[Register("getRegionInScreen", "(Landroid/graphics/Region;)V", "GetGetRegionInScreen_Landroid_graphics_Region_Handler")]
		public unsafe virtual void GetRegionInScreen(Region outRegion)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((outRegion == null) ? IntPtr.Zero : outRegion.Handle);
				AccessibilityWindowInfoCompat._members.InstanceMethods.InvokeVirtualVoidMethod("getRegionInScreen.(Landroid/graphics/Region;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(outRegion);
			}
		}

		// Token: 0x06000DEF RID: 3567 RVA: 0x00029768 File Offset: 0x00027968
		private static Delegate GetGetRoot_IHandler()
		{
			if (AccessibilityWindowInfoCompat.cb_getRoot_I == null)
			{
				AccessibilityWindowInfoCompat.cb_getRoot_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_L(AccessibilityWindowInfoCompat.n_GetRoot_I));
			}
			return AccessibilityWindowInfoCompat.cb_getRoot_I;
		}

		// Token: 0x06000DF0 RID: 3568 RVA: 0x0002978C File Offset: 0x0002798C
		private static IntPtr n_GetRoot_I(IntPtr jnienv, IntPtr native__this, int prefetchingStrategy)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<AccessibilityWindowInfoCompat>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).GetRoot(prefetchingStrategy));
		}

		// Token: 0x06000DF1 RID: 3569 RVA: 0x000297A4 File Offset: 0x000279A4
		[Register("getRoot", "(I)Landroidx/core/view/accessibility/AccessibilityNodeInfoCompat;", "GetGetRoot_IHandler")]
		public unsafe virtual AccessibilityNodeInfoCompat GetRoot(int prefetchingStrategy)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(prefetchingStrategy);
			return Java.Lang.Object.GetObject<AccessibilityNodeInfoCompat>(AccessibilityWindowInfoCompat._members.InstanceMethods.InvokeVirtualObjectMethod("getRoot.(I)Landroidx/core/view/accessibility/AccessibilityNodeInfoCompat;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06000DF2 RID: 3570 RVA: 0x000297F0 File Offset: 0x000279F0
		[Register("obtain", "()Landroidx/core/view/accessibility/AccessibilityWindowInfoCompat;", "")]
		public static AccessibilityWindowInfoCompat Obtain()
		{
			return Java.Lang.Object.GetObject<AccessibilityWindowInfoCompat>(AccessibilityWindowInfoCompat._members.StaticMethods.InvokeObjectMethod("obtain.()Landroidx/core/view/accessibility/AccessibilityWindowInfoCompat;", null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06000DF3 RID: 3571 RVA: 0x00029824 File Offset: 0x00027A24
		[Register("obtain", "(Landroidx/core/view/accessibility/AccessibilityWindowInfoCompat;)Landroidx/core/view/accessibility/AccessibilityWindowInfoCompat;", "")]
		public unsafe static AccessibilityWindowInfoCompat Obtain(AccessibilityWindowInfoCompat info)
		{
			AccessibilityWindowInfoCompat @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((info == null) ? IntPtr.Zero : info.Handle);
				@object = Java.Lang.Object.GetObject<AccessibilityWindowInfoCompat>(AccessibilityWindowInfoCompat._members.StaticMethods.InvokeObjectMethod("obtain.(Landroidx/core/view/accessibility/AccessibilityWindowInfoCompat;)Landroidx/core/view/accessibility/AccessibilityWindowInfoCompat;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(info);
			}
			return @object;
		}

		// Token: 0x06000DF4 RID: 3572 RVA: 0x00029898 File Offset: 0x00027A98
		private static Delegate GetRecycleHandler()
		{
			if (AccessibilityWindowInfoCompat.cb_recycle == null)
			{
				AccessibilityWindowInfoCompat.cb_recycle = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(AccessibilityWindowInfoCompat.n_Recycle));
			}
			return AccessibilityWindowInfoCompat.cb_recycle;
		}

		// Token: 0x06000DF5 RID: 3573 RVA: 0x000298BC File Offset: 0x00027ABC
		private static void n_Recycle(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<AccessibilityWindowInfoCompat>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Recycle();
		}

		// Token: 0x06000DF6 RID: 3574 RVA: 0x000298CB File Offset: 0x00027ACB
		[Register("recycle", "()V", "GetRecycleHandler")]
		public virtual void Recycle()
		{
			AccessibilityWindowInfoCompat._members.InstanceMethods.InvokeVirtualVoidMethod("recycle.()V", this, null);
		}

		// Token: 0x06000DF7 RID: 3575 RVA: 0x000298E4 File Offset: 0x00027AE4
		private static Delegate GetUnwrapHandler()
		{
			if (AccessibilityWindowInfoCompat.cb_unwrap == null)
			{
				AccessibilityWindowInfoCompat.cb_unwrap = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(AccessibilityWindowInfoCompat.n_Unwrap));
			}
			return AccessibilityWindowInfoCompat.cb_unwrap;
		}

		// Token: 0x06000DF8 RID: 3576 RVA: 0x00029908 File Offset: 0x00027B08
		private static IntPtr n_Unwrap(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<AccessibilityWindowInfoCompat>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Unwrap());
		}

		// Token: 0x06000DF9 RID: 3577 RVA: 0x0002991C File Offset: 0x00027B1C
		[Register("unwrap", "()Landroid/view/accessibility/AccessibilityWindowInfo;", "GetUnwrapHandler")]
		public virtual AccessibilityWindowInfo Unwrap()
		{
			return Java.Lang.Object.GetObject<AccessibilityWindowInfo>(AccessibilityWindowInfoCompat._members.InstanceMethods.InvokeVirtualObjectMethod("unwrap.()Landroid/view/accessibility/AccessibilityWindowInfo;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x04000406 RID: 1030
		private static readonly JniPeerMembers _members = new XAPeerMembers("androidx/core/view/accessibility/AccessibilityWindowInfoCompat", typeof(AccessibilityWindowInfoCompat));

		// Token: 0x04000407 RID: 1031
		private static Delegate cb_getAnchor;

		// Token: 0x04000408 RID: 1032
		private static Delegate cb_getChildCount;

		// Token: 0x04000409 RID: 1033
		private static Delegate cb_getDisplayId;

		// Token: 0x0400040A RID: 1034
		private static Delegate cb_getId;

		// Token: 0x0400040B RID: 1035
		private static Delegate cb_isAccessibilityFocused;

		// Token: 0x0400040C RID: 1036
		private static Delegate cb_isActive;

		// Token: 0x0400040D RID: 1037
		private static Delegate cb_isFocused;

		// Token: 0x0400040E RID: 1038
		private static Delegate cb_isInPictureInPictureMode;

		// Token: 0x0400040F RID: 1039
		private static Delegate cb_getLayer;

		// Token: 0x04000410 RID: 1040
		private static Delegate cb_getLocales;

		// Token: 0x04000411 RID: 1041
		private static Delegate cb_getParent;

		// Token: 0x04000412 RID: 1042
		private static Delegate cb_getRoot;

		// Token: 0x04000413 RID: 1043
		private static Delegate cb_getTitle;

		// Token: 0x04000414 RID: 1044
		private static Delegate cb_getTransitionTimeMillis;

		// Token: 0x04000415 RID: 1045
		private static Delegate cb_getType;

		// Token: 0x04000416 RID: 1046
		private static Delegate cb_getBoundsInScreen_Landroid_graphics_Rect_;

		// Token: 0x04000417 RID: 1047
		private static Delegate cb_getChild_I;

		// Token: 0x04000418 RID: 1048
		private static Delegate cb_getRegionInScreen_Landroid_graphics_Region_;

		// Token: 0x04000419 RID: 1049
		private static Delegate cb_getRoot_I;

		// Token: 0x0400041A RID: 1050
		private static Delegate cb_recycle;

		// Token: 0x0400041B RID: 1051
		private static Delegate cb_unwrap;
	}
}
