using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Content;
using Android.Content.Res;
using Android.Graphics.Drawables;
using Android.Runtime;
using Android.Util;
using Android.Views;
using Android.Widget;
using AndroidX.AppCompat.View;
using AndroidX.Fragment.App;
using Java.Interop;
using Java.Lang;

namespace AndroidX.AppCompat.App
{
	// Token: 0x0200003F RID: 63
	[Register("androidx/appcompat/app/ActionBar", DoNotGenerateAcw = true)]
	public abstract class ActionBar : Java.Lang.Object
	{
		// Token: 0x1700001D RID: 29
		// (get) Token: 0x06000203 RID: 515 RVA: 0x00005F74 File Offset: 0x00004174
		internal static IntPtr class_ref
		{
			get
			{
				return ActionBar._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x06000204 RID: 516 RVA: 0x00005F98 File Offset: 0x00004198
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return ActionBar._members;
			}
		}

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x06000205 RID: 517 RVA: 0x00005FA0 File Offset: 0x000041A0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return ActionBar._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x06000206 RID: 518 RVA: 0x00005FC4 File Offset: 0x000041C4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return ActionBar._members.ManagedPeerType;
			}
		}

		// Token: 0x06000207 RID: 519 RVA: 0x000039D4 File Offset: 0x00001BD4
		protected ActionBar(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000208 RID: 520 RVA: 0x00005FD0 File Offset: 0x000041D0
		[Register(".ctor", "()V", "")]
		public ActionBar() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			base.SetHandle(ActionBar._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
			ActionBar._members.InstanceMethods.FinishCreateInstance("()V", this, null);
		}

		// Token: 0x06000209 RID: 521 RVA: 0x0000603E File Offset: 0x0000423E
		private static Delegate GetGetCustomViewHandler()
		{
			if (ActionBar.cb_getCustomView == null)
			{
				ActionBar.cb_getCustomView = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(ActionBar.n_GetCustomView));
			}
			return ActionBar.cb_getCustomView;
		}

		// Token: 0x0600020A RID: 522 RVA: 0x00006062 File Offset: 0x00004262
		private static IntPtr n_GetCustomView(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<ActionBar>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).CustomView);
		}

		// Token: 0x0600020B RID: 523 RVA: 0x00006076 File Offset: 0x00004276
		private static Delegate GetSetCustomView_Landroid_view_View_Handler()
		{
			if (ActionBar.cb_setCustomView_Landroid_view_View_ == null)
			{
				ActionBar.cb_setCustomView_Landroid_view_View_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(ActionBar.n_SetCustomView_Landroid_view_View_));
			}
			return ActionBar.cb_setCustomView_Landroid_view_View_;
		}

		// Token: 0x0600020C RID: 524 RVA: 0x0000609C File Offset: 0x0000429C
		private static void n_SetCustomView_Landroid_view_View_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			ActionBar @object = Java.Lang.Object.GetObject<ActionBar>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			View object2 = Java.Lang.Object.GetObject<View>(native_p0, JniHandleOwnership.DoNotTransfer);
			@object.CustomView = object2;
		}

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x0600020D RID: 525
		// (set) Token: 0x0600020E RID: 526
		public abstract View CustomView { [Register("getCustomView", "()Landroid/view/View;", "GetGetCustomViewHandler")] get; [Register("setCustomView", "(Landroid/view/View;)V", "GetSetCustomView_Landroid_view_View_Handler")] set; }

		// Token: 0x0600020F RID: 527 RVA: 0x000060BF File Offset: 0x000042BF
		private static Delegate GetGetDisplayOptionsHandler()
		{
			if (ActionBar.cb_getDisplayOptions == null)
			{
				ActionBar.cb_getDisplayOptions = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(ActionBar.n_GetDisplayOptions));
			}
			return ActionBar.cb_getDisplayOptions;
		}

		// Token: 0x06000210 RID: 528 RVA: 0x000060E3 File Offset: 0x000042E3
		private static int n_GetDisplayOptions(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<ActionBar>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).DisplayOptions;
		}

		// Token: 0x06000211 RID: 529 RVA: 0x000060F2 File Offset: 0x000042F2
		private static Delegate GetSetDisplayOptions_IHandler()
		{
			if (ActionBar.cb_setDisplayOptions_I == null)
			{
				ActionBar.cb_setDisplayOptions_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_V(ActionBar.n_SetDisplayOptions_I));
			}
			return ActionBar.cb_setDisplayOptions_I;
		}

		// Token: 0x06000212 RID: 530 RVA: 0x00006116 File Offset: 0x00004316
		private static void n_SetDisplayOptions_I(IntPtr jnienv, IntPtr native__this, int p0)
		{
			Java.Lang.Object.GetObject<ActionBar>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).DisplayOptions = p0;
		}

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x06000213 RID: 531
		// (set) Token: 0x06000214 RID: 532
		public abstract int DisplayOptions { [Register("getDisplayOptions", "()I", "GetGetDisplayOptionsHandler")] get; [Register("setDisplayOptions", "(I)V", "GetSetDisplayOptions_IHandler")] set; }

		// Token: 0x06000215 RID: 533 RVA: 0x00006126 File Offset: 0x00004326
		private static Delegate GetGetElevationHandler()
		{
			if (ActionBar.cb_getElevation == null)
			{
				ActionBar.cb_getElevation = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_F(ActionBar.n_GetElevation));
			}
			return ActionBar.cb_getElevation;
		}

		// Token: 0x06000216 RID: 534 RVA: 0x0000614A File Offset: 0x0000434A
		private static float n_GetElevation(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<ActionBar>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Elevation;
		}

		// Token: 0x06000217 RID: 535 RVA: 0x00006159 File Offset: 0x00004359
		private static Delegate GetSetElevation_FHandler()
		{
			if (ActionBar.cb_setElevation_F == null)
			{
				ActionBar.cb_setElevation_F = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPF_V(ActionBar.n_SetElevation_F));
			}
			return ActionBar.cb_setElevation_F;
		}

		// Token: 0x06000218 RID: 536 RVA: 0x0000617D File Offset: 0x0000437D
		private static void n_SetElevation_F(IntPtr jnienv, IntPtr native__this, float elevation)
		{
			Java.Lang.Object.GetObject<ActionBar>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Elevation = elevation;
		}

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x06000219 RID: 537 RVA: 0x0000618D File Offset: 0x0000438D
		// (set) Token: 0x0600021A RID: 538 RVA: 0x000061A8 File Offset: 0x000043A8
		public unsafe virtual float Elevation
		{
			[Register("getElevation", "()F", "GetGetElevationHandler")]
			get
			{
				return ActionBar._members.InstanceMethods.InvokeVirtualSingleMethod("getElevation.()F", this, null);
			}
			[Register("setElevation", "(F)V", "GetSetElevation_FHandler")]
			set
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(value);
				ActionBar._members.InstanceMethods.InvokeVirtualVoidMethod("setElevation.(F)V", this, ptr);
			}
		}

		// Token: 0x0600021B RID: 539 RVA: 0x000061E3 File Offset: 0x000043E3
		private static Delegate GetGetHeightHandler()
		{
			if (ActionBar.cb_getHeight == null)
			{
				ActionBar.cb_getHeight = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(ActionBar.n_GetHeight));
			}
			return ActionBar.cb_getHeight;
		}

		// Token: 0x0600021C RID: 540 RVA: 0x00006207 File Offset: 0x00004407
		private static int n_GetHeight(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<ActionBar>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Height;
		}

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x0600021D RID: 541
		public abstract int Height { [Register("getHeight", "()I", "GetGetHeightHandler")] get; }

		// Token: 0x0600021E RID: 542 RVA: 0x00006216 File Offset: 0x00004416
		private static Delegate GetGetHideOffsetHandler()
		{
			if (ActionBar.cb_getHideOffset == null)
			{
				ActionBar.cb_getHideOffset = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(ActionBar.n_GetHideOffset));
			}
			return ActionBar.cb_getHideOffset;
		}

		// Token: 0x0600021F RID: 543 RVA: 0x0000623A File Offset: 0x0000443A
		private static int n_GetHideOffset(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<ActionBar>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).HideOffset;
		}

		// Token: 0x06000220 RID: 544 RVA: 0x00006249 File Offset: 0x00004449
		private static Delegate GetSetHideOffset_IHandler()
		{
			if (ActionBar.cb_setHideOffset_I == null)
			{
				ActionBar.cb_setHideOffset_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_V(ActionBar.n_SetHideOffset_I));
			}
			return ActionBar.cb_setHideOffset_I;
		}

		// Token: 0x06000221 RID: 545 RVA: 0x0000626D File Offset: 0x0000446D
		private static void n_SetHideOffset_I(IntPtr jnienv, IntPtr native__this, int offset)
		{
			Java.Lang.Object.GetObject<ActionBar>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).HideOffset = offset;
		}

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x06000222 RID: 546 RVA: 0x0000627D File Offset: 0x0000447D
		// (set) Token: 0x06000223 RID: 547 RVA: 0x00006298 File Offset: 0x00004498
		public unsafe virtual int HideOffset
		{
			[Register("getHideOffset", "()I", "GetGetHideOffsetHandler")]
			get
			{
				return ActionBar._members.InstanceMethods.InvokeVirtualInt32Method("getHideOffset.()I", this, null);
			}
			[Register("setHideOffset", "(I)V", "GetSetHideOffset_IHandler")]
			set
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(value);
				ActionBar._members.InstanceMethods.InvokeVirtualVoidMethod("setHideOffset.(I)V", this, ptr);
			}
		}

		// Token: 0x06000224 RID: 548 RVA: 0x000062D3 File Offset: 0x000044D3
		private static Delegate GetIsHideOnContentScrollEnabledHandler()
		{
			if (ActionBar.cb_isHideOnContentScrollEnabled == null)
			{
				ActionBar.cb_isHideOnContentScrollEnabled = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(ActionBar.n_IsHideOnContentScrollEnabled));
			}
			return ActionBar.cb_isHideOnContentScrollEnabled;
		}

		// Token: 0x06000225 RID: 549 RVA: 0x000062F7 File Offset: 0x000044F7
		private static bool n_IsHideOnContentScrollEnabled(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<ActionBar>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).HideOnContentScrollEnabled;
		}

		// Token: 0x06000226 RID: 550 RVA: 0x00006306 File Offset: 0x00004506
		private static Delegate GetSetHideOnContentScrollEnabled_ZHandler()
		{
			if (ActionBar.cb_setHideOnContentScrollEnabled_Z == null)
			{
				ActionBar.cb_setHideOnContentScrollEnabled_Z = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPZ_V(ActionBar.n_SetHideOnContentScrollEnabled_Z));
			}
			return ActionBar.cb_setHideOnContentScrollEnabled_Z;
		}

		// Token: 0x06000227 RID: 551 RVA: 0x0000632A File Offset: 0x0000452A
		private static void n_SetHideOnContentScrollEnabled_Z(IntPtr jnienv, IntPtr native__this, bool hideOnContentScroll)
		{
			Java.Lang.Object.GetObject<ActionBar>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).HideOnContentScrollEnabled = hideOnContentScroll;
		}

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x06000228 RID: 552 RVA: 0x0000633A File Offset: 0x0000453A
		// (set) Token: 0x06000229 RID: 553 RVA: 0x00006354 File Offset: 0x00004554
		public unsafe virtual bool HideOnContentScrollEnabled
		{
			[Register("isHideOnContentScrollEnabled", "()Z", "GetIsHideOnContentScrollEnabledHandler")]
			get
			{
				return ActionBar._members.InstanceMethods.InvokeVirtualBooleanMethod("isHideOnContentScrollEnabled.()Z", this, null);
			}
			[Register("setHideOnContentScrollEnabled", "(Z)V", "GetSetHideOnContentScrollEnabled_ZHandler")]
			set
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(value);
				ActionBar._members.InstanceMethods.InvokeVirtualVoidMethod("setHideOnContentScrollEnabled.(Z)V", this, ptr);
			}
		}

		// Token: 0x0600022A RID: 554 RVA: 0x0000638F File Offset: 0x0000458F
		private static Delegate GetIsShowingHandler()
		{
			if (ActionBar.cb_isShowing == null)
			{
				ActionBar.cb_isShowing = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(ActionBar.n_IsShowing));
			}
			return ActionBar.cb_isShowing;
		}

		// Token: 0x0600022B RID: 555 RVA: 0x000063B3 File Offset: 0x000045B3
		private static bool n_IsShowing(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<ActionBar>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsShowing;
		}

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x0600022C RID: 556
		public abstract bool IsShowing { [Register("isShowing", "()Z", "GetIsShowingHandler")] get; }

		// Token: 0x0600022D RID: 557 RVA: 0x000063C2 File Offset: 0x000045C2
		private static Delegate GetIsTitleTruncatedHandler()
		{
			if (ActionBar.cb_isTitleTruncated == null)
			{
				ActionBar.cb_isTitleTruncated = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(ActionBar.n_IsTitleTruncated));
			}
			return ActionBar.cb_isTitleTruncated;
		}

		// Token: 0x0600022E RID: 558 RVA: 0x000063E6 File Offset: 0x000045E6
		private static bool n_IsTitleTruncated(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<ActionBar>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsTitleTruncated;
		}

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x0600022F RID: 559 RVA: 0x000063F5 File Offset: 0x000045F5
		public virtual bool IsTitleTruncated
		{
			[Register("isTitleTruncated", "()Z", "GetIsTitleTruncatedHandler")]
			get
			{
				return ActionBar._members.InstanceMethods.InvokeVirtualBooleanMethod("isTitleTruncated.()Z", this, null);
			}
		}

		// Token: 0x06000230 RID: 560 RVA: 0x0000640E File Offset: 0x0000460E
		private static Delegate GetGetNavigationItemCountHandler()
		{
			if (ActionBar.cb_getNavigationItemCount == null)
			{
				ActionBar.cb_getNavigationItemCount = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(ActionBar.n_GetNavigationItemCount));
			}
			return ActionBar.cb_getNavigationItemCount;
		}

		// Token: 0x06000231 RID: 561 RVA: 0x00006432 File Offset: 0x00004632
		private static int n_GetNavigationItemCount(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<ActionBar>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).NavigationItemCount;
		}

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x06000232 RID: 562
		public abstract int NavigationItemCount { [Register("getNavigationItemCount", "()I", "GetGetNavigationItemCountHandler")] get; }

		// Token: 0x06000233 RID: 563 RVA: 0x00006441 File Offset: 0x00004641
		private static Delegate GetGetNavigationModeHandler()
		{
			if (ActionBar.cb_getNavigationMode == null)
			{
				ActionBar.cb_getNavigationMode = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(ActionBar.n_GetNavigationMode));
			}
			return ActionBar.cb_getNavigationMode;
		}

		// Token: 0x06000234 RID: 564 RVA: 0x00006465 File Offset: 0x00004665
		private static int n_GetNavigationMode(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<ActionBar>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).NavigationMode;
		}

		// Token: 0x06000235 RID: 565 RVA: 0x00006474 File Offset: 0x00004674
		private static Delegate GetSetNavigationMode_IHandler()
		{
			if (ActionBar.cb_setNavigationMode_I == null)
			{
				ActionBar.cb_setNavigationMode_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_V(ActionBar.n_SetNavigationMode_I));
			}
			return ActionBar.cb_setNavigationMode_I;
		}

		// Token: 0x06000236 RID: 566 RVA: 0x00006498 File Offset: 0x00004698
		private static void n_SetNavigationMode_I(IntPtr jnienv, IntPtr native__this, int p0)
		{
			Java.Lang.Object.GetObject<ActionBar>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).NavigationMode = p0;
		}

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x06000237 RID: 567
		// (set) Token: 0x06000238 RID: 568
		public abstract int NavigationMode { [Register("getNavigationMode", "()I", "GetGetNavigationModeHandler")] get; [Register("setNavigationMode", "(I)V", "GetSetNavigationMode_IHandler")] set; }

		// Token: 0x06000239 RID: 569 RVA: 0x000064A8 File Offset: 0x000046A8
		private static Delegate GetGetSelectedNavigationIndexHandler()
		{
			if (ActionBar.cb_getSelectedNavigationIndex == null)
			{
				ActionBar.cb_getSelectedNavigationIndex = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(ActionBar.n_GetSelectedNavigationIndex));
			}
			return ActionBar.cb_getSelectedNavigationIndex;
		}

		// Token: 0x0600023A RID: 570 RVA: 0x000064CC File Offset: 0x000046CC
		private static int n_GetSelectedNavigationIndex(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<ActionBar>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SelectedNavigationIndex;
		}

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x0600023B RID: 571
		public abstract int SelectedNavigationIndex { [Register("getSelectedNavigationIndex", "()I", "GetGetSelectedNavigationIndexHandler")] get; }

		// Token: 0x0600023C RID: 572 RVA: 0x000064DB File Offset: 0x000046DB
		private static Delegate GetGetSelectedTabHandler()
		{
			if (ActionBar.cb_getSelectedTab == null)
			{
				ActionBar.cb_getSelectedTab = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(ActionBar.n_GetSelectedTab));
			}
			return ActionBar.cb_getSelectedTab;
		}

		// Token: 0x0600023D RID: 573 RVA: 0x000064FF File Offset: 0x000046FF
		private static IntPtr n_GetSelectedTab(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<ActionBar>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SelectedTab);
		}

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x0600023E RID: 574
		public abstract ActionBar.Tab SelectedTab { [Register("getSelectedTab", "()Landroidx/appcompat/app/ActionBar$Tab;", "GetGetSelectedTabHandler")] get; }

		// Token: 0x0600023F RID: 575 RVA: 0x00006513 File Offset: 0x00004713
		private static Delegate GetGetSubtitleHandler()
		{
			if (ActionBar.cb_getSubtitle == null)
			{
				ActionBar.cb_getSubtitle = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(ActionBar.n_GetSubtitle));
			}
			return ActionBar.cb_getSubtitle;
		}

		// Token: 0x06000240 RID: 576 RVA: 0x00006537 File Offset: 0x00004737
		private static IntPtr n_GetSubtitle(IntPtr jnienv, IntPtr native__this)
		{
			return CharSequence.ToLocalJniHandle(Java.Lang.Object.GetObject<ActionBar>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SubtitleFormatted);
		}

		// Token: 0x06000241 RID: 577 RVA: 0x0000654B File Offset: 0x0000474B
		private static Delegate GetSetSubtitle_Ljava_lang_CharSequence_Handler()
		{
			if (ActionBar.cb_setSubtitle_Ljava_lang_CharSequence_ == null)
			{
				ActionBar.cb_setSubtitle_Ljava_lang_CharSequence_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(ActionBar.n_SetSubtitle_Ljava_lang_CharSequence_));
			}
			return ActionBar.cb_setSubtitle_Ljava_lang_CharSequence_;
		}

		// Token: 0x06000242 RID: 578 RVA: 0x00006570 File Offset: 0x00004770
		private static void n_SetSubtitle_Ljava_lang_CharSequence_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			ActionBar @object = Java.Lang.Object.GetObject<ActionBar>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ICharSequence object2 = Java.Lang.Object.GetObject<ICharSequence>(native_p0, JniHandleOwnership.DoNotTransfer);
			@object.SubtitleFormatted = object2;
		}

		// Token: 0x1700002D RID: 45
		// (get) Token: 0x06000243 RID: 579
		// (set) Token: 0x06000244 RID: 580
		public abstract ICharSequence SubtitleFormatted { [Register("getSubtitle", "()Ljava/lang/CharSequence;", "GetGetSubtitleHandler")] get; [Register("setSubtitle", "(Ljava/lang/CharSequence;)V", "GetSetSubtitle_Ljava_lang_CharSequence_Handler")] set; }

		// Token: 0x1700002E RID: 46
		// (get) Token: 0x06000245 RID: 581 RVA: 0x00006593 File Offset: 0x00004793
		// (set) Token: 0x06000246 RID: 582 RVA: 0x000065AC File Offset: 0x000047AC
		public string Subtitle
		{
			get
			{
				if (this.SubtitleFormatted != null)
				{
					return this.SubtitleFormatted.ToString();
				}
				return null;
			}
			set
			{
				Java.Lang.String @string = (value == null) ? null : new Java.Lang.String(value);
				this.SubtitleFormatted = @string;
				if (@string != null)
				{
					@string.Dispose();
				}
			}
		}

		// Token: 0x06000247 RID: 583 RVA: 0x000065D6 File Offset: 0x000047D6
		private static Delegate GetGetTabCountHandler()
		{
			if (ActionBar.cb_getTabCount == null)
			{
				ActionBar.cb_getTabCount = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(ActionBar.n_GetTabCount));
			}
			return ActionBar.cb_getTabCount;
		}

		// Token: 0x06000248 RID: 584 RVA: 0x000065FA File Offset: 0x000047FA
		private static int n_GetTabCount(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<ActionBar>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).TabCount;
		}

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x06000249 RID: 585
		public abstract int TabCount { [Register("getTabCount", "()I", "GetGetTabCountHandler")] get; }

		// Token: 0x0600024A RID: 586 RVA: 0x00006609 File Offset: 0x00004809
		private static Delegate GetGetThemedContextHandler()
		{
			if (ActionBar.cb_getThemedContext == null)
			{
				ActionBar.cb_getThemedContext = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(ActionBar.n_GetThemedContext));
			}
			return ActionBar.cb_getThemedContext;
		}

		// Token: 0x0600024B RID: 587 RVA: 0x0000662D File Offset: 0x0000482D
		private static IntPtr n_GetThemedContext(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<ActionBar>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ThemedContext);
		}

		// Token: 0x17000030 RID: 48
		// (get) Token: 0x0600024C RID: 588 RVA: 0x00006644 File Offset: 0x00004844
		public virtual Context ThemedContext
		{
			[Register("getThemedContext", "()Landroid/content/Context;", "GetGetThemedContextHandler")]
			get
			{
				return Java.Lang.Object.GetObject<Context>(ActionBar._members.InstanceMethods.InvokeVirtualObjectMethod("getThemedContext.()Landroid/content/Context;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x0600024D RID: 589 RVA: 0x00006676 File Offset: 0x00004876
		private static Delegate GetGetTitleHandler()
		{
			if (ActionBar.cb_getTitle == null)
			{
				ActionBar.cb_getTitle = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(ActionBar.n_GetTitle));
			}
			return ActionBar.cb_getTitle;
		}

		// Token: 0x0600024E RID: 590 RVA: 0x0000669A File Offset: 0x0000489A
		private static IntPtr n_GetTitle(IntPtr jnienv, IntPtr native__this)
		{
			return CharSequence.ToLocalJniHandle(Java.Lang.Object.GetObject<ActionBar>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).TitleFormatted);
		}

		// Token: 0x0600024F RID: 591 RVA: 0x000066AE File Offset: 0x000048AE
		private static Delegate GetSetTitle_Ljava_lang_CharSequence_Handler()
		{
			if (ActionBar.cb_setTitle_Ljava_lang_CharSequence_ == null)
			{
				ActionBar.cb_setTitle_Ljava_lang_CharSequence_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(ActionBar.n_SetTitle_Ljava_lang_CharSequence_));
			}
			return ActionBar.cb_setTitle_Ljava_lang_CharSequence_;
		}

		// Token: 0x06000250 RID: 592 RVA: 0x000066D4 File Offset: 0x000048D4
		private static void n_SetTitle_Ljava_lang_CharSequence_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			ActionBar @object = Java.Lang.Object.GetObject<ActionBar>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ICharSequence object2 = Java.Lang.Object.GetObject<ICharSequence>(native_p0, JniHandleOwnership.DoNotTransfer);
			@object.TitleFormatted = object2;
		}

		// Token: 0x17000031 RID: 49
		// (get) Token: 0x06000251 RID: 593
		// (set) Token: 0x06000252 RID: 594
		public abstract ICharSequence TitleFormatted { [Register("getTitle", "()Ljava/lang/CharSequence;", "GetGetTitleHandler")] get; [Register("setTitle", "(Ljava/lang/CharSequence;)V", "GetSetTitle_Ljava_lang_CharSequence_Handler")] set; }

		// Token: 0x17000032 RID: 50
		// (get) Token: 0x06000253 RID: 595 RVA: 0x000066F7 File Offset: 0x000048F7
		// (set) Token: 0x06000254 RID: 596 RVA: 0x00006710 File Offset: 0x00004910
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
			set
			{
				Java.Lang.String @string = (value == null) ? null : new Java.Lang.String(value);
				this.TitleFormatted = @string;
				if (@string != null)
				{
					@string.Dispose();
				}
			}
		}

		// Token: 0x06000255 RID: 597 RVA: 0x0000673A File Offset: 0x0000493A
		private static Delegate GetAddOnMenuVisibilityListener_Landroidx_appcompat_app_ActionBar_OnMenuVisibilityListener_Handler()
		{
			if (ActionBar.cb_addOnMenuVisibilityListener_Landroidx_appcompat_app_ActionBar_OnMenuVisibilityListener_ == null)
			{
				ActionBar.cb_addOnMenuVisibilityListener_Landroidx_appcompat_app_ActionBar_OnMenuVisibilityListener_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(ActionBar.n_AddOnMenuVisibilityListener_Landroidx_appcompat_app_ActionBar_OnMenuVisibilityListener_));
			}
			return ActionBar.cb_addOnMenuVisibilityListener_Landroidx_appcompat_app_ActionBar_OnMenuVisibilityListener_;
		}

		// Token: 0x06000256 RID: 598 RVA: 0x00006760 File Offset: 0x00004960
		private static void n_AddOnMenuVisibilityListener_Landroidx_appcompat_app_ActionBar_OnMenuVisibilityListener_(IntPtr jnienv, IntPtr native__this, IntPtr native_listener)
		{
			ActionBar @object = Java.Lang.Object.GetObject<ActionBar>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ActionBar.IOnMenuVisibilityListener object2 = Java.Lang.Object.GetObject<ActionBar.IOnMenuVisibilityListener>(native_listener, JniHandleOwnership.DoNotTransfer);
			@object.AddOnMenuVisibilityListener(object2);
		}

		// Token: 0x06000257 RID: 599
		[Register("addOnMenuVisibilityListener", "(Landroidx/appcompat/app/ActionBar$OnMenuVisibilityListener;)V", "GetAddOnMenuVisibilityListener_Landroidx_appcompat_app_ActionBar_OnMenuVisibilityListener_Handler")]
		public abstract void AddOnMenuVisibilityListener(ActionBar.IOnMenuVisibilityListener listener);

		// Token: 0x06000258 RID: 600 RVA: 0x00006783 File Offset: 0x00004983
		private static Delegate GetAddTab_Landroidx_appcompat_app_ActionBar_Tab_Handler()
		{
			if (ActionBar.cb_addTab_Landroidx_appcompat_app_ActionBar_Tab_ == null)
			{
				ActionBar.cb_addTab_Landroidx_appcompat_app_ActionBar_Tab_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(ActionBar.n_AddTab_Landroidx_appcompat_app_ActionBar_Tab_));
			}
			return ActionBar.cb_addTab_Landroidx_appcompat_app_ActionBar_Tab_;
		}

		// Token: 0x06000259 RID: 601 RVA: 0x000067A8 File Offset: 0x000049A8
		private static void n_AddTab_Landroidx_appcompat_app_ActionBar_Tab_(IntPtr jnienv, IntPtr native__this, IntPtr native_tab)
		{
			ActionBar @object = Java.Lang.Object.GetObject<ActionBar>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ActionBar.Tab object2 = Java.Lang.Object.GetObject<ActionBar.Tab>(native_tab, JniHandleOwnership.DoNotTransfer);
			@object.AddTab(object2);
		}

		// Token: 0x0600025A RID: 602
		[Register("addTab", "(Landroidx/appcompat/app/ActionBar$Tab;)V", "GetAddTab_Landroidx_appcompat_app_ActionBar_Tab_Handler")]
		public abstract void AddTab(ActionBar.Tab tab);

		// Token: 0x0600025B RID: 603 RVA: 0x000067CB File Offset: 0x000049CB
		private static Delegate GetAddTab_Landroidx_appcompat_app_ActionBar_Tab_ZHandler()
		{
			if (ActionBar.cb_addTab_Landroidx_appcompat_app_ActionBar_Tab_Z == null)
			{
				ActionBar.cb_addTab_Landroidx_appcompat_app_ActionBar_Tab_Z = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLZ_V(ActionBar.n_AddTab_Landroidx_appcompat_app_ActionBar_Tab_Z));
			}
			return ActionBar.cb_addTab_Landroidx_appcompat_app_ActionBar_Tab_Z;
		}

		// Token: 0x0600025C RID: 604 RVA: 0x000067F0 File Offset: 0x000049F0
		private static void n_AddTab_Landroidx_appcompat_app_ActionBar_Tab_Z(IntPtr jnienv, IntPtr native__this, IntPtr native_tab, bool setSelected)
		{
			ActionBar @object = Java.Lang.Object.GetObject<ActionBar>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ActionBar.Tab object2 = Java.Lang.Object.GetObject<ActionBar.Tab>(native_tab, JniHandleOwnership.DoNotTransfer);
			@object.AddTab(object2, setSelected);
		}

		// Token: 0x0600025D RID: 605
		[Register("addTab", "(Landroidx/appcompat/app/ActionBar$Tab;Z)V", "GetAddTab_Landroidx_appcompat_app_ActionBar_Tab_ZHandler")]
		public abstract void AddTab(ActionBar.Tab tab, bool setSelected);

		// Token: 0x0600025E RID: 606 RVA: 0x00006814 File Offset: 0x00004A14
		private static Delegate GetAddTab_Landroidx_appcompat_app_ActionBar_Tab_IHandler()
		{
			if (ActionBar.cb_addTab_Landroidx_appcompat_app_ActionBar_Tab_I == null)
			{
				ActionBar.cb_addTab_Landroidx_appcompat_app_ActionBar_Tab_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLI_V(ActionBar.n_AddTab_Landroidx_appcompat_app_ActionBar_Tab_I));
			}
			return ActionBar.cb_addTab_Landroidx_appcompat_app_ActionBar_Tab_I;
		}

		// Token: 0x0600025F RID: 607 RVA: 0x00006838 File Offset: 0x00004A38
		private static void n_AddTab_Landroidx_appcompat_app_ActionBar_Tab_I(IntPtr jnienv, IntPtr native__this, IntPtr native_tab, int position)
		{
			ActionBar @object = Java.Lang.Object.GetObject<ActionBar>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ActionBar.Tab object2 = Java.Lang.Object.GetObject<ActionBar.Tab>(native_tab, JniHandleOwnership.DoNotTransfer);
			@object.AddTab(object2, position);
		}

		// Token: 0x06000260 RID: 608
		[Register("addTab", "(Landroidx/appcompat/app/ActionBar$Tab;I)V", "GetAddTab_Landroidx_appcompat_app_ActionBar_Tab_IHandler")]
		public abstract void AddTab(ActionBar.Tab tab, int position);

		// Token: 0x06000261 RID: 609 RVA: 0x0000685C File Offset: 0x00004A5C
		private static Delegate GetAddTab_Landroidx_appcompat_app_ActionBar_Tab_IZHandler()
		{
			if (ActionBar.cb_addTab_Landroidx_appcompat_app_ActionBar_Tab_IZ == null)
			{
				ActionBar.cb_addTab_Landroidx_appcompat_app_ActionBar_Tab_IZ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLIZ_V(ActionBar.n_AddTab_Landroidx_appcompat_app_ActionBar_Tab_IZ));
			}
			return ActionBar.cb_addTab_Landroidx_appcompat_app_ActionBar_Tab_IZ;
		}

		// Token: 0x06000262 RID: 610 RVA: 0x00006880 File Offset: 0x00004A80
		private static void n_AddTab_Landroidx_appcompat_app_ActionBar_Tab_IZ(IntPtr jnienv, IntPtr native__this, IntPtr native_tab, int position, bool setSelected)
		{
			ActionBar @object = Java.Lang.Object.GetObject<ActionBar>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ActionBar.Tab object2 = Java.Lang.Object.GetObject<ActionBar.Tab>(native_tab, JniHandleOwnership.DoNotTransfer);
			@object.AddTab(object2, position, setSelected);
		}

		// Token: 0x06000263 RID: 611
		[Register("addTab", "(Landroidx/appcompat/app/ActionBar$Tab;IZ)V", "GetAddTab_Landroidx_appcompat_app_ActionBar_Tab_IZHandler")]
		public abstract void AddTab(ActionBar.Tab tab, int position, bool setSelected);

		// Token: 0x06000264 RID: 612 RVA: 0x000068A6 File Offset: 0x00004AA6
		private static Delegate GetCloseOptionsMenuHandler()
		{
			if (ActionBar.cb_closeOptionsMenu == null)
			{
				ActionBar.cb_closeOptionsMenu = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(ActionBar.n_CloseOptionsMenu));
			}
			return ActionBar.cb_closeOptionsMenu;
		}

		// Token: 0x06000265 RID: 613 RVA: 0x000068CA File Offset: 0x00004ACA
		private static bool n_CloseOptionsMenu(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<ActionBar>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).CloseOptionsMenu();
		}

		// Token: 0x06000266 RID: 614 RVA: 0x000068D9 File Offset: 0x00004AD9
		[Register("closeOptionsMenu", "()Z", "GetCloseOptionsMenuHandler")]
		public virtual bool CloseOptionsMenu()
		{
			return ActionBar._members.InstanceMethods.InvokeVirtualBooleanMethod("closeOptionsMenu.()Z", this, null);
		}

		// Token: 0x06000267 RID: 615 RVA: 0x000068F2 File Offset: 0x00004AF2
		private static Delegate GetCollapseActionViewHandler()
		{
			if (ActionBar.cb_collapseActionView == null)
			{
				ActionBar.cb_collapseActionView = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(ActionBar.n_CollapseActionView));
			}
			return ActionBar.cb_collapseActionView;
		}

		// Token: 0x06000268 RID: 616 RVA: 0x00006916 File Offset: 0x00004B16
		private static bool n_CollapseActionView(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<ActionBar>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).CollapseActionView();
		}

		// Token: 0x06000269 RID: 617 RVA: 0x00006925 File Offset: 0x00004B25
		[Register("collapseActionView", "()Z", "GetCollapseActionViewHandler")]
		public virtual bool CollapseActionView()
		{
			return ActionBar._members.InstanceMethods.InvokeVirtualBooleanMethod("collapseActionView.()Z", this, null);
		}

		// Token: 0x0600026A RID: 618 RVA: 0x0000693E File Offset: 0x00004B3E
		private static Delegate GetDispatchMenuVisibilityChanged_ZHandler()
		{
			if (ActionBar.cb_dispatchMenuVisibilityChanged_Z == null)
			{
				ActionBar.cb_dispatchMenuVisibilityChanged_Z = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPZ_V(ActionBar.n_DispatchMenuVisibilityChanged_Z));
			}
			return ActionBar.cb_dispatchMenuVisibilityChanged_Z;
		}

		// Token: 0x0600026B RID: 619 RVA: 0x00006962 File Offset: 0x00004B62
		private static void n_DispatchMenuVisibilityChanged_Z(IntPtr jnienv, IntPtr native__this, bool visible)
		{
			Java.Lang.Object.GetObject<ActionBar>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).DispatchMenuVisibilityChanged(visible);
		}

		// Token: 0x0600026C RID: 620 RVA: 0x00006974 File Offset: 0x00004B74
		[Register("dispatchMenuVisibilityChanged", "(Z)V", "GetDispatchMenuVisibilityChanged_ZHandler")]
		public unsafe virtual void DispatchMenuVisibilityChanged(bool visible)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(visible);
			ActionBar._members.InstanceMethods.InvokeVirtualVoidMethod("dispatchMenuVisibilityChanged.(Z)V", this, ptr);
		}

		// Token: 0x0600026D RID: 621 RVA: 0x000069AF File Offset: 0x00004BAF
		private static Delegate GetGetTabAt_IHandler()
		{
			if (ActionBar.cb_getTabAt_I == null)
			{
				ActionBar.cb_getTabAt_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_L(ActionBar.n_GetTabAt_I));
			}
			return ActionBar.cb_getTabAt_I;
		}

		// Token: 0x0600026E RID: 622 RVA: 0x000069D3 File Offset: 0x00004BD3
		private static IntPtr n_GetTabAt_I(IntPtr jnienv, IntPtr native__this, int index)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<ActionBar>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).GetTabAt(index));
		}

		// Token: 0x0600026F RID: 623
		[Register("getTabAt", "(I)Landroidx/appcompat/app/ActionBar$Tab;", "GetGetTabAt_IHandler")]
		public abstract ActionBar.Tab GetTabAt(int index);

		// Token: 0x06000270 RID: 624 RVA: 0x000069E8 File Offset: 0x00004BE8
		private static Delegate GetHideHandler()
		{
			if (ActionBar.cb_hide == null)
			{
				ActionBar.cb_hide = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(ActionBar.n_Hide));
			}
			return ActionBar.cb_hide;
		}

		// Token: 0x06000271 RID: 625 RVA: 0x00006A0C File Offset: 0x00004C0C
		private static void n_Hide(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<ActionBar>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Hide();
		}

		// Token: 0x06000272 RID: 626
		[Register("hide", "()V", "GetHideHandler")]
		public abstract void Hide();

		// Token: 0x06000273 RID: 627 RVA: 0x00006A1B File Offset: 0x00004C1B
		private static Delegate GetInvalidateOptionsMenuHandler()
		{
			if (ActionBar.cb_invalidateOptionsMenu == null)
			{
				ActionBar.cb_invalidateOptionsMenu = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(ActionBar.n_InvalidateOptionsMenu));
			}
			return ActionBar.cb_invalidateOptionsMenu;
		}

		// Token: 0x06000274 RID: 628 RVA: 0x00006A3F File Offset: 0x00004C3F
		private static bool n_InvalidateOptionsMenu(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<ActionBar>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).InvalidateOptionsMenu();
		}

		// Token: 0x06000275 RID: 629 RVA: 0x00006A4E File Offset: 0x00004C4E
		[Register("invalidateOptionsMenu", "()Z", "GetInvalidateOptionsMenuHandler")]
		public virtual bool InvalidateOptionsMenu()
		{
			return ActionBar._members.InstanceMethods.InvokeVirtualBooleanMethod("invalidateOptionsMenu.()Z", this, null);
		}

		// Token: 0x06000276 RID: 630 RVA: 0x00006A67 File Offset: 0x00004C67
		private static Delegate GetNewTabHandler()
		{
			if (ActionBar.cb_newTab == null)
			{
				ActionBar.cb_newTab = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(ActionBar.n_NewTab));
			}
			return ActionBar.cb_newTab;
		}

		// Token: 0x06000277 RID: 631 RVA: 0x00006A8B File Offset: 0x00004C8B
		private static IntPtr n_NewTab(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<ActionBar>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).NewTab());
		}

		// Token: 0x06000278 RID: 632
		[Register("newTab", "()Landroidx/appcompat/app/ActionBar$Tab;", "GetNewTabHandler")]
		public abstract ActionBar.Tab NewTab();

		// Token: 0x06000279 RID: 633 RVA: 0x00006A9F File Offset: 0x00004C9F
		private static Delegate GetOnConfigurationChanged_Landroid_content_res_Configuration_Handler()
		{
			if (ActionBar.cb_onConfigurationChanged_Landroid_content_res_Configuration_ == null)
			{
				ActionBar.cb_onConfigurationChanged_Landroid_content_res_Configuration_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(ActionBar.n_OnConfigurationChanged_Landroid_content_res_Configuration_));
			}
			return ActionBar.cb_onConfigurationChanged_Landroid_content_res_Configuration_;
		}

		// Token: 0x0600027A RID: 634 RVA: 0x00006AC4 File Offset: 0x00004CC4
		private static void n_OnConfigurationChanged_Landroid_content_res_Configuration_(IntPtr jnienv, IntPtr native__this, IntPtr native_config)
		{
			ActionBar @object = Java.Lang.Object.GetObject<ActionBar>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Configuration object2 = Java.Lang.Object.GetObject<Configuration>(native_config, JniHandleOwnership.DoNotTransfer);
			@object.OnConfigurationChanged(object2);
		}

		// Token: 0x0600027B RID: 635 RVA: 0x00006AE8 File Offset: 0x00004CE8
		[Register("onConfigurationChanged", "(Landroid/content/res/Configuration;)V", "GetOnConfigurationChanged_Landroid_content_res_Configuration_Handler")]
		public unsafe virtual void OnConfigurationChanged(Configuration config)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((config == null) ? IntPtr.Zero : config.Handle);
				ActionBar._members.InstanceMethods.InvokeVirtualVoidMethod("onConfigurationChanged.(Landroid/content/res/Configuration;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(config);
			}
		}

		// Token: 0x0600027C RID: 636 RVA: 0x00006B4C File Offset: 0x00004D4C
		private static Delegate GetOnKeyShortcut_ILandroid_view_KeyEvent_Handler()
		{
			if (ActionBar.cb_onKeyShortcut_ILandroid_view_KeyEvent_ == null)
			{
				ActionBar.cb_onKeyShortcut_ILandroid_view_KeyEvent_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPIL_Z(ActionBar.n_OnKeyShortcut_ILandroid_view_KeyEvent_));
			}
			return ActionBar.cb_onKeyShortcut_ILandroid_view_KeyEvent_;
		}

		// Token: 0x0600027D RID: 637 RVA: 0x00006B70 File Offset: 0x00004D70
		private static bool n_OnKeyShortcut_ILandroid_view_KeyEvent_(IntPtr jnienv, IntPtr native__this, int keyCode, IntPtr native_ev)
		{
			ActionBar @object = Java.Lang.Object.GetObject<ActionBar>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			KeyEvent object2 = Java.Lang.Object.GetObject<KeyEvent>(native_ev, JniHandleOwnership.DoNotTransfer);
			return @object.OnKeyShortcut(keyCode, object2);
		}

		// Token: 0x0600027E RID: 638 RVA: 0x00006B94 File Offset: 0x00004D94
		[Register("onKeyShortcut", "(ILandroid/view/KeyEvent;)Z", "GetOnKeyShortcut_ILandroid_view_KeyEvent_Handler")]
		public unsafe virtual bool OnKeyShortcut(int keyCode, KeyEvent ev)
		{
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(keyCode);
				ptr[1] = new JniArgumentValue((ev == null) ? IntPtr.Zero : ev.Handle);
				result = ActionBar._members.InstanceMethods.InvokeVirtualBooleanMethod("onKeyShortcut.(ILandroid/view/KeyEvent;)Z", this, ptr);
			}
			finally
			{
				GC.KeepAlive(ev);
			}
			return result;
		}

		// Token: 0x0600027F RID: 639 RVA: 0x00006C0C File Offset: 0x00004E0C
		private static Delegate GetOnMenuKeyEvent_Landroid_view_KeyEvent_Handler()
		{
			if (ActionBar.cb_onMenuKeyEvent_Landroid_view_KeyEvent_ == null)
			{
				ActionBar.cb_onMenuKeyEvent_Landroid_view_KeyEvent_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(ActionBar.n_OnMenuKeyEvent_Landroid_view_KeyEvent_));
			}
			return ActionBar.cb_onMenuKeyEvent_Landroid_view_KeyEvent_;
		}

		// Token: 0x06000280 RID: 640 RVA: 0x00006C30 File Offset: 0x00004E30
		private static bool n_OnMenuKeyEvent_Landroid_view_KeyEvent_(IntPtr jnienv, IntPtr native__this, IntPtr native_e)
		{
			ActionBar @object = Java.Lang.Object.GetObject<ActionBar>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			KeyEvent object2 = Java.Lang.Object.GetObject<KeyEvent>(native_e, JniHandleOwnership.DoNotTransfer);
			return @object.OnMenuKeyEvent(object2);
		}

		// Token: 0x06000281 RID: 641 RVA: 0x00006C54 File Offset: 0x00004E54
		[Register("onMenuKeyEvent", "(Landroid/view/KeyEvent;)Z", "GetOnMenuKeyEvent_Landroid_view_KeyEvent_Handler")]
		public unsafe virtual bool OnMenuKeyEvent(KeyEvent e)
		{
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((e == null) ? IntPtr.Zero : e.Handle);
				result = ActionBar._members.InstanceMethods.InvokeVirtualBooleanMethod("onMenuKeyEvent.(Landroid/view/KeyEvent;)Z", this, ptr);
			}
			finally
			{
				GC.KeepAlive(e);
			}
			return result;
		}

		// Token: 0x06000282 RID: 642 RVA: 0x00006CBC File Offset: 0x00004EBC
		private static Delegate GetOpenOptionsMenuHandler()
		{
			if (ActionBar.cb_openOptionsMenu == null)
			{
				ActionBar.cb_openOptionsMenu = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(ActionBar.n_OpenOptionsMenu));
			}
			return ActionBar.cb_openOptionsMenu;
		}

		// Token: 0x06000283 RID: 643 RVA: 0x00006CE0 File Offset: 0x00004EE0
		private static bool n_OpenOptionsMenu(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<ActionBar>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).OpenOptionsMenu();
		}

		// Token: 0x06000284 RID: 644 RVA: 0x00006CEF File Offset: 0x00004EEF
		[Register("openOptionsMenu", "()Z", "GetOpenOptionsMenuHandler")]
		public virtual bool OpenOptionsMenu()
		{
			return ActionBar._members.InstanceMethods.InvokeVirtualBooleanMethod("openOptionsMenu.()Z", this, null);
		}

		// Token: 0x06000285 RID: 645 RVA: 0x00006D08 File Offset: 0x00004F08
		private static Delegate GetRemoveAllTabsHandler()
		{
			if (ActionBar.cb_removeAllTabs == null)
			{
				ActionBar.cb_removeAllTabs = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(ActionBar.n_RemoveAllTabs));
			}
			return ActionBar.cb_removeAllTabs;
		}

		// Token: 0x06000286 RID: 646 RVA: 0x00006D2C File Offset: 0x00004F2C
		private static void n_RemoveAllTabs(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<ActionBar>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).RemoveAllTabs();
		}

		// Token: 0x06000287 RID: 647
		[Register("removeAllTabs", "()V", "GetRemoveAllTabsHandler")]
		public abstract void RemoveAllTabs();

		// Token: 0x06000288 RID: 648 RVA: 0x00006D3B File Offset: 0x00004F3B
		private static Delegate GetRemoveOnMenuVisibilityListener_Landroidx_appcompat_app_ActionBar_OnMenuVisibilityListener_Handler()
		{
			if (ActionBar.cb_removeOnMenuVisibilityListener_Landroidx_appcompat_app_ActionBar_OnMenuVisibilityListener_ == null)
			{
				ActionBar.cb_removeOnMenuVisibilityListener_Landroidx_appcompat_app_ActionBar_OnMenuVisibilityListener_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(ActionBar.n_RemoveOnMenuVisibilityListener_Landroidx_appcompat_app_ActionBar_OnMenuVisibilityListener_));
			}
			return ActionBar.cb_removeOnMenuVisibilityListener_Landroidx_appcompat_app_ActionBar_OnMenuVisibilityListener_;
		}

		// Token: 0x06000289 RID: 649 RVA: 0x00006D60 File Offset: 0x00004F60
		private static void n_RemoveOnMenuVisibilityListener_Landroidx_appcompat_app_ActionBar_OnMenuVisibilityListener_(IntPtr jnienv, IntPtr native__this, IntPtr native_listener)
		{
			ActionBar @object = Java.Lang.Object.GetObject<ActionBar>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ActionBar.IOnMenuVisibilityListener object2 = Java.Lang.Object.GetObject<ActionBar.IOnMenuVisibilityListener>(native_listener, JniHandleOwnership.DoNotTransfer);
			@object.RemoveOnMenuVisibilityListener(object2);
		}

		// Token: 0x0600028A RID: 650
		[Register("removeOnMenuVisibilityListener", "(Landroidx/appcompat/app/ActionBar$OnMenuVisibilityListener;)V", "GetRemoveOnMenuVisibilityListener_Landroidx_appcompat_app_ActionBar_OnMenuVisibilityListener_Handler")]
		public abstract void RemoveOnMenuVisibilityListener(ActionBar.IOnMenuVisibilityListener listener);

		// Token: 0x0600028B RID: 651 RVA: 0x00006D83 File Offset: 0x00004F83
		private static Delegate GetRemoveTab_Landroidx_appcompat_app_ActionBar_Tab_Handler()
		{
			if (ActionBar.cb_removeTab_Landroidx_appcompat_app_ActionBar_Tab_ == null)
			{
				ActionBar.cb_removeTab_Landroidx_appcompat_app_ActionBar_Tab_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(ActionBar.n_RemoveTab_Landroidx_appcompat_app_ActionBar_Tab_));
			}
			return ActionBar.cb_removeTab_Landroidx_appcompat_app_ActionBar_Tab_;
		}

		// Token: 0x0600028C RID: 652 RVA: 0x00006DA8 File Offset: 0x00004FA8
		private static void n_RemoveTab_Landroidx_appcompat_app_ActionBar_Tab_(IntPtr jnienv, IntPtr native__this, IntPtr native_tab)
		{
			ActionBar @object = Java.Lang.Object.GetObject<ActionBar>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ActionBar.Tab object2 = Java.Lang.Object.GetObject<ActionBar.Tab>(native_tab, JniHandleOwnership.DoNotTransfer);
			@object.RemoveTab(object2);
		}

		// Token: 0x0600028D RID: 653
		[Register("removeTab", "(Landroidx/appcompat/app/ActionBar$Tab;)V", "GetRemoveTab_Landroidx_appcompat_app_ActionBar_Tab_Handler")]
		public abstract void RemoveTab(ActionBar.Tab tab);

		// Token: 0x0600028E RID: 654 RVA: 0x00006DCB File Offset: 0x00004FCB
		private static Delegate GetRemoveTabAt_IHandler()
		{
			if (ActionBar.cb_removeTabAt_I == null)
			{
				ActionBar.cb_removeTabAt_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_V(ActionBar.n_RemoveTabAt_I));
			}
			return ActionBar.cb_removeTabAt_I;
		}

		// Token: 0x0600028F RID: 655 RVA: 0x00006DEF File Offset: 0x00004FEF
		private static void n_RemoveTabAt_I(IntPtr jnienv, IntPtr native__this, int position)
		{
			Java.Lang.Object.GetObject<ActionBar>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).RemoveTabAt(position);
		}

		// Token: 0x06000290 RID: 656
		[Register("removeTabAt", "(I)V", "GetRemoveTabAt_IHandler")]
		public abstract void RemoveTabAt(int position);

		// Token: 0x06000291 RID: 657 RVA: 0x00006DFF File Offset: 0x00004FFF
		private static Delegate GetSelectTab_Landroidx_appcompat_app_ActionBar_Tab_Handler()
		{
			if (ActionBar.cb_selectTab_Landroidx_appcompat_app_ActionBar_Tab_ == null)
			{
				ActionBar.cb_selectTab_Landroidx_appcompat_app_ActionBar_Tab_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(ActionBar.n_SelectTab_Landroidx_appcompat_app_ActionBar_Tab_));
			}
			return ActionBar.cb_selectTab_Landroidx_appcompat_app_ActionBar_Tab_;
		}

		// Token: 0x06000292 RID: 658 RVA: 0x00006E24 File Offset: 0x00005024
		private static void n_SelectTab_Landroidx_appcompat_app_ActionBar_Tab_(IntPtr jnienv, IntPtr native__this, IntPtr native_tab)
		{
			ActionBar @object = Java.Lang.Object.GetObject<ActionBar>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ActionBar.Tab object2 = Java.Lang.Object.GetObject<ActionBar.Tab>(native_tab, JniHandleOwnership.DoNotTransfer);
			@object.SelectTab(object2);
		}

		// Token: 0x06000293 RID: 659
		[Register("selectTab", "(Landroidx/appcompat/app/ActionBar$Tab;)V", "GetSelectTab_Landroidx_appcompat_app_ActionBar_Tab_Handler")]
		public abstract void SelectTab(ActionBar.Tab tab);

		// Token: 0x06000294 RID: 660 RVA: 0x00006E47 File Offset: 0x00005047
		private static Delegate GetSetBackgroundDrawable_Landroid_graphics_drawable_Drawable_Handler()
		{
			if (ActionBar.cb_setBackgroundDrawable_Landroid_graphics_drawable_Drawable_ == null)
			{
				ActionBar.cb_setBackgroundDrawable_Landroid_graphics_drawable_Drawable_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(ActionBar.n_SetBackgroundDrawable_Landroid_graphics_drawable_Drawable_));
			}
			return ActionBar.cb_setBackgroundDrawable_Landroid_graphics_drawable_Drawable_;
		}

		// Token: 0x06000295 RID: 661 RVA: 0x00006E6C File Offset: 0x0000506C
		private static void n_SetBackgroundDrawable_Landroid_graphics_drawable_Drawable_(IntPtr jnienv, IntPtr native__this, IntPtr native_d)
		{
			ActionBar @object = Java.Lang.Object.GetObject<ActionBar>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Drawable object2 = Java.Lang.Object.GetObject<Drawable>(native_d, JniHandleOwnership.DoNotTransfer);
			@object.SetBackgroundDrawable(object2);
		}

		// Token: 0x06000296 RID: 662
		[Register("setBackgroundDrawable", "(Landroid/graphics/drawable/Drawable;)V", "GetSetBackgroundDrawable_Landroid_graphics_drawable_Drawable_Handler")]
		public abstract void SetBackgroundDrawable(Drawable d);

		// Token: 0x06000297 RID: 663 RVA: 0x00006E8F File Offset: 0x0000508F
		private static Delegate GetSetCustomView_Landroid_view_View_Landroidx_appcompat_app_ActionBar_LayoutParams_Handler()
		{
			if (ActionBar.cb_setCustomView_Landroid_view_View_Landroidx_appcompat_app_ActionBar_LayoutParams_ == null)
			{
				ActionBar.cb_setCustomView_Landroid_view_View_Landroidx_appcompat_app_ActionBar_LayoutParams_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_V(ActionBar.n_SetCustomView_Landroid_view_View_Landroidx_appcompat_app_ActionBar_LayoutParams_));
			}
			return ActionBar.cb_setCustomView_Landroid_view_View_Landroidx_appcompat_app_ActionBar_LayoutParams_;
		}

		// Token: 0x06000298 RID: 664 RVA: 0x00006EB4 File Offset: 0x000050B4
		private static void n_SetCustomView_Landroid_view_View_Landroidx_appcompat_app_ActionBar_LayoutParams_(IntPtr jnienv, IntPtr native__this, IntPtr native_view, IntPtr native_layoutParams)
		{
			ActionBar @object = Java.Lang.Object.GetObject<ActionBar>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			View object2 = Java.Lang.Object.GetObject<View>(native_view, JniHandleOwnership.DoNotTransfer);
			ActionBar.LayoutParams object3 = Java.Lang.Object.GetObject<ActionBar.LayoutParams>(native_layoutParams, JniHandleOwnership.DoNotTransfer);
			@object.SetCustomView(object2, object3);
		}

		// Token: 0x06000299 RID: 665
		[Register("setCustomView", "(Landroid/view/View;Landroidx/appcompat/app/ActionBar$LayoutParams;)V", "GetSetCustomView_Landroid_view_View_Landroidx_appcompat_app_ActionBar_LayoutParams_Handler")]
		public abstract void SetCustomView(View view, ActionBar.LayoutParams layoutParams);

		// Token: 0x0600029A RID: 666 RVA: 0x00006EE0 File Offset: 0x000050E0
		private static Delegate GetSetCustomView_IHandler()
		{
			if (ActionBar.cb_setCustomView_I == null)
			{
				ActionBar.cb_setCustomView_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_V(ActionBar.n_SetCustomView_I));
			}
			return ActionBar.cb_setCustomView_I;
		}

		// Token: 0x0600029B RID: 667 RVA: 0x00006F04 File Offset: 0x00005104
		private static void n_SetCustomView_I(IntPtr jnienv, IntPtr native__this, int resId)
		{
			Java.Lang.Object.GetObject<ActionBar>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SetCustomView(resId);
		}

		// Token: 0x0600029C RID: 668
		[Register("setCustomView", "(I)V", "GetSetCustomView_IHandler")]
		public abstract void SetCustomView(int resId);

		// Token: 0x0600029D RID: 669 RVA: 0x00006F14 File Offset: 0x00005114
		private static Delegate GetSetDefaultDisplayHomeAsUpEnabled_ZHandler()
		{
			if (ActionBar.cb_setDefaultDisplayHomeAsUpEnabled_Z == null)
			{
				ActionBar.cb_setDefaultDisplayHomeAsUpEnabled_Z = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPZ_V(ActionBar.n_SetDefaultDisplayHomeAsUpEnabled_Z));
			}
			return ActionBar.cb_setDefaultDisplayHomeAsUpEnabled_Z;
		}

		// Token: 0x0600029E RID: 670 RVA: 0x00006F38 File Offset: 0x00005138
		private static void n_SetDefaultDisplayHomeAsUpEnabled_Z(IntPtr jnienv, IntPtr native__this, bool enabled)
		{
			Java.Lang.Object.GetObject<ActionBar>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SetDefaultDisplayHomeAsUpEnabled(enabled);
		}

		// Token: 0x0600029F RID: 671 RVA: 0x00006F48 File Offset: 0x00005148
		[Register("setDefaultDisplayHomeAsUpEnabled", "(Z)V", "GetSetDefaultDisplayHomeAsUpEnabled_ZHandler")]
		public unsafe virtual void SetDefaultDisplayHomeAsUpEnabled(bool enabled)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(enabled);
			ActionBar._members.InstanceMethods.InvokeVirtualVoidMethod("setDefaultDisplayHomeAsUpEnabled.(Z)V", this, ptr);
		}

		// Token: 0x060002A0 RID: 672 RVA: 0x00006F83 File Offset: 0x00005183
		private static Delegate GetSetDisplayHomeAsUpEnabled_ZHandler()
		{
			if (ActionBar.cb_setDisplayHomeAsUpEnabled_Z == null)
			{
				ActionBar.cb_setDisplayHomeAsUpEnabled_Z = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPZ_V(ActionBar.n_SetDisplayHomeAsUpEnabled_Z));
			}
			return ActionBar.cb_setDisplayHomeAsUpEnabled_Z;
		}

		// Token: 0x060002A1 RID: 673 RVA: 0x00006FA7 File Offset: 0x000051A7
		private static void n_SetDisplayHomeAsUpEnabled_Z(IntPtr jnienv, IntPtr native__this, bool showHomeAsUp)
		{
			Java.Lang.Object.GetObject<ActionBar>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SetDisplayHomeAsUpEnabled(showHomeAsUp);
		}

		// Token: 0x060002A2 RID: 674
		[Register("setDisplayHomeAsUpEnabled", "(Z)V", "GetSetDisplayHomeAsUpEnabled_ZHandler")]
		public abstract void SetDisplayHomeAsUpEnabled(bool showHomeAsUp);

		// Token: 0x060002A3 RID: 675 RVA: 0x00006FB7 File Offset: 0x000051B7
		private static Delegate GetSetDisplayOptions_IIHandler()
		{
			if (ActionBar.cb_setDisplayOptions_II == null)
			{
				ActionBar.cb_setDisplayOptions_II = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPII_V(ActionBar.n_SetDisplayOptions_II));
			}
			return ActionBar.cb_setDisplayOptions_II;
		}

		// Token: 0x060002A4 RID: 676 RVA: 0x00006FDB File Offset: 0x000051DB
		private static void n_SetDisplayOptions_II(IntPtr jnienv, IntPtr native__this, int options, int mask)
		{
			Java.Lang.Object.GetObject<ActionBar>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SetDisplayOptions(options, mask);
		}

		// Token: 0x060002A5 RID: 677
		[Register("setDisplayOptions", "(II)V", "GetSetDisplayOptions_IIHandler")]
		public abstract void SetDisplayOptions(int options, int mask);

		// Token: 0x060002A6 RID: 678 RVA: 0x00006FEC File Offset: 0x000051EC
		private static Delegate GetSetDisplayShowCustomEnabled_ZHandler()
		{
			if (ActionBar.cb_setDisplayShowCustomEnabled_Z == null)
			{
				ActionBar.cb_setDisplayShowCustomEnabled_Z = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPZ_V(ActionBar.n_SetDisplayShowCustomEnabled_Z));
			}
			return ActionBar.cb_setDisplayShowCustomEnabled_Z;
		}

		// Token: 0x060002A7 RID: 679 RVA: 0x00007010 File Offset: 0x00005210
		private static void n_SetDisplayShowCustomEnabled_Z(IntPtr jnienv, IntPtr native__this, bool showCustom)
		{
			Java.Lang.Object.GetObject<ActionBar>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SetDisplayShowCustomEnabled(showCustom);
		}

		// Token: 0x060002A8 RID: 680
		[Register("setDisplayShowCustomEnabled", "(Z)V", "GetSetDisplayShowCustomEnabled_ZHandler")]
		public abstract void SetDisplayShowCustomEnabled(bool showCustom);

		// Token: 0x060002A9 RID: 681 RVA: 0x00007020 File Offset: 0x00005220
		private static Delegate GetSetDisplayShowHomeEnabled_ZHandler()
		{
			if (ActionBar.cb_setDisplayShowHomeEnabled_Z == null)
			{
				ActionBar.cb_setDisplayShowHomeEnabled_Z = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPZ_V(ActionBar.n_SetDisplayShowHomeEnabled_Z));
			}
			return ActionBar.cb_setDisplayShowHomeEnabled_Z;
		}

		// Token: 0x060002AA RID: 682 RVA: 0x00007044 File Offset: 0x00005244
		private static void n_SetDisplayShowHomeEnabled_Z(IntPtr jnienv, IntPtr native__this, bool showHome)
		{
			Java.Lang.Object.GetObject<ActionBar>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SetDisplayShowHomeEnabled(showHome);
		}

		// Token: 0x060002AB RID: 683
		[Register("setDisplayShowHomeEnabled", "(Z)V", "GetSetDisplayShowHomeEnabled_ZHandler")]
		public abstract void SetDisplayShowHomeEnabled(bool showHome);

		// Token: 0x060002AC RID: 684 RVA: 0x00007054 File Offset: 0x00005254
		private static Delegate GetSetDisplayShowTitleEnabled_ZHandler()
		{
			if (ActionBar.cb_setDisplayShowTitleEnabled_Z == null)
			{
				ActionBar.cb_setDisplayShowTitleEnabled_Z = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPZ_V(ActionBar.n_SetDisplayShowTitleEnabled_Z));
			}
			return ActionBar.cb_setDisplayShowTitleEnabled_Z;
		}

		// Token: 0x060002AD RID: 685 RVA: 0x00007078 File Offset: 0x00005278
		private static void n_SetDisplayShowTitleEnabled_Z(IntPtr jnienv, IntPtr native__this, bool showTitle)
		{
			Java.Lang.Object.GetObject<ActionBar>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SetDisplayShowTitleEnabled(showTitle);
		}

		// Token: 0x060002AE RID: 686
		[Register("setDisplayShowTitleEnabled", "(Z)V", "GetSetDisplayShowTitleEnabled_ZHandler")]
		public abstract void SetDisplayShowTitleEnabled(bool showTitle);

		// Token: 0x060002AF RID: 687 RVA: 0x00007088 File Offset: 0x00005288
		private static Delegate GetSetDisplayUseLogoEnabled_ZHandler()
		{
			if (ActionBar.cb_setDisplayUseLogoEnabled_Z == null)
			{
				ActionBar.cb_setDisplayUseLogoEnabled_Z = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPZ_V(ActionBar.n_SetDisplayUseLogoEnabled_Z));
			}
			return ActionBar.cb_setDisplayUseLogoEnabled_Z;
		}

		// Token: 0x060002B0 RID: 688 RVA: 0x000070AC File Offset: 0x000052AC
		private static void n_SetDisplayUseLogoEnabled_Z(IntPtr jnienv, IntPtr native__this, bool useLogo)
		{
			Java.Lang.Object.GetObject<ActionBar>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SetDisplayUseLogoEnabled(useLogo);
		}

		// Token: 0x060002B1 RID: 689
		[Register("setDisplayUseLogoEnabled", "(Z)V", "GetSetDisplayUseLogoEnabled_ZHandler")]
		public abstract void SetDisplayUseLogoEnabled(bool useLogo);

		// Token: 0x060002B2 RID: 690 RVA: 0x000070BC File Offset: 0x000052BC
		private static Delegate GetSetHomeActionContentDescription_IHandler()
		{
			if (ActionBar.cb_setHomeActionContentDescription_I == null)
			{
				ActionBar.cb_setHomeActionContentDescription_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_V(ActionBar.n_SetHomeActionContentDescription_I));
			}
			return ActionBar.cb_setHomeActionContentDescription_I;
		}

		// Token: 0x060002B3 RID: 691 RVA: 0x000070E0 File Offset: 0x000052E0
		private static void n_SetHomeActionContentDescription_I(IntPtr jnienv, IntPtr native__this, int resId)
		{
			Java.Lang.Object.GetObject<ActionBar>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SetHomeActionContentDescription(resId);
		}

		// Token: 0x060002B4 RID: 692 RVA: 0x000070F0 File Offset: 0x000052F0
		[Register("setHomeActionContentDescription", "(I)V", "GetSetHomeActionContentDescription_IHandler")]
		public unsafe virtual void SetHomeActionContentDescription(int resId)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(resId);
			ActionBar._members.InstanceMethods.InvokeVirtualVoidMethod("setHomeActionContentDescription.(I)V", this, ptr);
		}

		// Token: 0x060002B5 RID: 693 RVA: 0x0000712B File Offset: 0x0000532B
		private static Delegate GetSetHomeActionContentDescription_Ljava_lang_CharSequence_Handler()
		{
			if (ActionBar.cb_setHomeActionContentDescription_Ljava_lang_CharSequence_ == null)
			{
				ActionBar.cb_setHomeActionContentDescription_Ljava_lang_CharSequence_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(ActionBar.n_SetHomeActionContentDescription_Ljava_lang_CharSequence_));
			}
			return ActionBar.cb_setHomeActionContentDescription_Ljava_lang_CharSequence_;
		}

		// Token: 0x060002B6 RID: 694 RVA: 0x00007150 File Offset: 0x00005350
		private static void n_SetHomeActionContentDescription_Ljava_lang_CharSequence_(IntPtr jnienv, IntPtr native__this, IntPtr native_description)
		{
			ActionBar @object = Java.Lang.Object.GetObject<ActionBar>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ICharSequence object2 = Java.Lang.Object.GetObject<ICharSequence>(native_description, JniHandleOwnership.DoNotTransfer);
			@object.SetHomeActionContentDescription(object2);
		}

		// Token: 0x060002B7 RID: 695 RVA: 0x00007174 File Offset: 0x00005374
		[Register("setHomeActionContentDescription", "(Ljava/lang/CharSequence;)V", "GetSetHomeActionContentDescription_Ljava_lang_CharSequence_Handler")]
		public unsafe virtual void SetHomeActionContentDescription(ICharSequence description)
		{
			IntPtr intPtr = CharSequence.ToLocalJniHandle(description);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ActionBar._members.InstanceMethods.InvokeVirtualVoidMethod("setHomeActionContentDescription.(Ljava/lang/CharSequence;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(description);
			}
		}

		// Token: 0x060002B8 RID: 696 RVA: 0x000071D8 File Offset: 0x000053D8
		public void SetHomeActionContentDescription(string description)
		{
			Java.Lang.String @string = (description == null) ? null : new Java.Lang.String(description);
			this.SetHomeActionContentDescription(@string);
			if (@string != null)
			{
				@string.Dispose();
			}
		}

		// Token: 0x060002B9 RID: 697 RVA: 0x00007202 File Offset: 0x00005402
		private static Delegate GetSetHomeAsUpIndicator_Landroid_graphics_drawable_Drawable_Handler()
		{
			if (ActionBar.cb_setHomeAsUpIndicator_Landroid_graphics_drawable_Drawable_ == null)
			{
				ActionBar.cb_setHomeAsUpIndicator_Landroid_graphics_drawable_Drawable_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(ActionBar.n_SetHomeAsUpIndicator_Landroid_graphics_drawable_Drawable_));
			}
			return ActionBar.cb_setHomeAsUpIndicator_Landroid_graphics_drawable_Drawable_;
		}

		// Token: 0x060002BA RID: 698 RVA: 0x00007228 File Offset: 0x00005428
		private static void n_SetHomeAsUpIndicator_Landroid_graphics_drawable_Drawable_(IntPtr jnienv, IntPtr native__this, IntPtr native_indicator)
		{
			ActionBar @object = Java.Lang.Object.GetObject<ActionBar>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Drawable object2 = Java.Lang.Object.GetObject<Drawable>(native_indicator, JniHandleOwnership.DoNotTransfer);
			@object.SetHomeAsUpIndicator(object2);
		}

		// Token: 0x060002BB RID: 699 RVA: 0x0000724C File Offset: 0x0000544C
		[Register("setHomeAsUpIndicator", "(Landroid/graphics/drawable/Drawable;)V", "GetSetHomeAsUpIndicator_Landroid_graphics_drawable_Drawable_Handler")]
		public unsafe virtual void SetHomeAsUpIndicator(Drawable indicator)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((indicator == null) ? IntPtr.Zero : indicator.Handle);
				ActionBar._members.InstanceMethods.InvokeVirtualVoidMethod("setHomeAsUpIndicator.(Landroid/graphics/drawable/Drawable;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(indicator);
			}
		}

		// Token: 0x060002BC RID: 700 RVA: 0x000072B0 File Offset: 0x000054B0
		private static Delegate GetSetHomeAsUpIndicator_IHandler()
		{
			if (ActionBar.cb_setHomeAsUpIndicator_I == null)
			{
				ActionBar.cb_setHomeAsUpIndicator_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_V(ActionBar.n_SetHomeAsUpIndicator_I));
			}
			return ActionBar.cb_setHomeAsUpIndicator_I;
		}

		// Token: 0x060002BD RID: 701 RVA: 0x000072D4 File Offset: 0x000054D4
		private static void n_SetHomeAsUpIndicator_I(IntPtr jnienv, IntPtr native__this, int resId)
		{
			Java.Lang.Object.GetObject<ActionBar>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SetHomeAsUpIndicator(resId);
		}

		// Token: 0x060002BE RID: 702 RVA: 0x000072E4 File Offset: 0x000054E4
		[Register("setHomeAsUpIndicator", "(I)V", "GetSetHomeAsUpIndicator_IHandler")]
		public unsafe virtual void SetHomeAsUpIndicator(int resId)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(resId);
			ActionBar._members.InstanceMethods.InvokeVirtualVoidMethod("setHomeAsUpIndicator.(I)V", this, ptr);
		}

		// Token: 0x060002BF RID: 703 RVA: 0x0000731F File Offset: 0x0000551F
		private static Delegate GetSetHomeButtonEnabled_ZHandler()
		{
			if (ActionBar.cb_setHomeButtonEnabled_Z == null)
			{
				ActionBar.cb_setHomeButtonEnabled_Z = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPZ_V(ActionBar.n_SetHomeButtonEnabled_Z));
			}
			return ActionBar.cb_setHomeButtonEnabled_Z;
		}

		// Token: 0x060002C0 RID: 704 RVA: 0x00007343 File Offset: 0x00005543
		private static void n_SetHomeButtonEnabled_Z(IntPtr jnienv, IntPtr native__this, bool enabled)
		{
			Java.Lang.Object.GetObject<ActionBar>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SetHomeButtonEnabled(enabled);
		}

		// Token: 0x060002C1 RID: 705 RVA: 0x00007354 File Offset: 0x00005554
		[Register("setHomeButtonEnabled", "(Z)V", "GetSetHomeButtonEnabled_ZHandler")]
		public unsafe virtual void SetHomeButtonEnabled(bool enabled)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(enabled);
			ActionBar._members.InstanceMethods.InvokeVirtualVoidMethod("setHomeButtonEnabled.(Z)V", this, ptr);
		}

		// Token: 0x060002C2 RID: 706 RVA: 0x0000738F File Offset: 0x0000558F
		private static Delegate GetSetIcon_Landroid_graphics_drawable_Drawable_Handler()
		{
			if (ActionBar.cb_setIcon_Landroid_graphics_drawable_Drawable_ == null)
			{
				ActionBar.cb_setIcon_Landroid_graphics_drawable_Drawable_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(ActionBar.n_SetIcon_Landroid_graphics_drawable_Drawable_));
			}
			return ActionBar.cb_setIcon_Landroid_graphics_drawable_Drawable_;
		}

		// Token: 0x060002C3 RID: 707 RVA: 0x000073B4 File Offset: 0x000055B4
		private static void n_SetIcon_Landroid_graphics_drawable_Drawable_(IntPtr jnienv, IntPtr native__this, IntPtr native_icon)
		{
			ActionBar @object = Java.Lang.Object.GetObject<ActionBar>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Drawable object2 = Java.Lang.Object.GetObject<Drawable>(native_icon, JniHandleOwnership.DoNotTransfer);
			@object.SetIcon(object2);
		}

		// Token: 0x060002C4 RID: 708
		[Register("setIcon", "(Landroid/graphics/drawable/Drawable;)V", "GetSetIcon_Landroid_graphics_drawable_Drawable_Handler")]
		public abstract void SetIcon(Drawable icon);

		// Token: 0x060002C5 RID: 709 RVA: 0x000073D7 File Offset: 0x000055D7
		private static Delegate GetSetIcon_IHandler()
		{
			if (ActionBar.cb_setIcon_I == null)
			{
				ActionBar.cb_setIcon_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_V(ActionBar.n_SetIcon_I));
			}
			return ActionBar.cb_setIcon_I;
		}

		// Token: 0x060002C6 RID: 710 RVA: 0x000073FB File Offset: 0x000055FB
		private static void n_SetIcon_I(IntPtr jnienv, IntPtr native__this, int resId)
		{
			Java.Lang.Object.GetObject<ActionBar>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SetIcon(resId);
		}

		// Token: 0x060002C7 RID: 711
		[Register("setIcon", "(I)V", "GetSetIcon_IHandler")]
		public abstract void SetIcon(int resId);

		// Token: 0x060002C8 RID: 712 RVA: 0x0000740B File Offset: 0x0000560B
		private static Delegate GetSetListNavigationCallbacks_Landroid_widget_SpinnerAdapter_Landroidx_appcompat_app_ActionBar_OnNavigationListener_Handler()
		{
			if (ActionBar.cb_setListNavigationCallbacks_Landroid_widget_SpinnerAdapter_Landroidx_appcompat_app_ActionBar_OnNavigationListener_ == null)
			{
				ActionBar.cb_setListNavigationCallbacks_Landroid_widget_SpinnerAdapter_Landroidx_appcompat_app_ActionBar_OnNavigationListener_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_V(ActionBar.n_SetListNavigationCallbacks_Landroid_widget_SpinnerAdapter_Landroidx_appcompat_app_ActionBar_OnNavigationListener_));
			}
			return ActionBar.cb_setListNavigationCallbacks_Landroid_widget_SpinnerAdapter_Landroidx_appcompat_app_ActionBar_OnNavigationListener_;
		}

		// Token: 0x060002C9 RID: 713 RVA: 0x00007430 File Offset: 0x00005630
		private static void n_SetListNavigationCallbacks_Landroid_widget_SpinnerAdapter_Landroidx_appcompat_app_ActionBar_OnNavigationListener_(IntPtr jnienv, IntPtr native__this, IntPtr native_adapter, IntPtr native_callback)
		{
			ActionBar @object = Java.Lang.Object.GetObject<ActionBar>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ISpinnerAdapter object2 = Java.Lang.Object.GetObject<ISpinnerAdapter>(native_adapter, JniHandleOwnership.DoNotTransfer);
			ActionBar.IOnNavigationListener object3 = Java.Lang.Object.GetObject<ActionBar.IOnNavigationListener>(native_callback, JniHandleOwnership.DoNotTransfer);
			@object.SetListNavigationCallbacks(object2, object3);
		}

		// Token: 0x060002CA RID: 714
		[Register("setListNavigationCallbacks", "(Landroid/widget/SpinnerAdapter;Landroidx/appcompat/app/ActionBar$OnNavigationListener;)V", "GetSetListNavigationCallbacks_Landroid_widget_SpinnerAdapter_Landroidx_appcompat_app_ActionBar_OnNavigationListener_Handler")]
		public abstract void SetListNavigationCallbacks(ISpinnerAdapter adapter, ActionBar.IOnNavigationListener callback_);

		// Token: 0x060002CB RID: 715 RVA: 0x0000745C File Offset: 0x0000565C
		private static Delegate GetSetLogo_Landroid_graphics_drawable_Drawable_Handler()
		{
			if (ActionBar.cb_setLogo_Landroid_graphics_drawable_Drawable_ == null)
			{
				ActionBar.cb_setLogo_Landroid_graphics_drawable_Drawable_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(ActionBar.n_SetLogo_Landroid_graphics_drawable_Drawable_));
			}
			return ActionBar.cb_setLogo_Landroid_graphics_drawable_Drawable_;
		}

		// Token: 0x060002CC RID: 716 RVA: 0x00007480 File Offset: 0x00005680
		private static void n_SetLogo_Landroid_graphics_drawable_Drawable_(IntPtr jnienv, IntPtr native__this, IntPtr native_logo)
		{
			ActionBar @object = Java.Lang.Object.GetObject<ActionBar>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Drawable object2 = Java.Lang.Object.GetObject<Drawable>(native_logo, JniHandleOwnership.DoNotTransfer);
			@object.SetLogo(object2);
		}

		// Token: 0x060002CD RID: 717
		[Register("setLogo", "(Landroid/graphics/drawable/Drawable;)V", "GetSetLogo_Landroid_graphics_drawable_Drawable_Handler")]
		public abstract void SetLogo(Drawable logo);

		// Token: 0x060002CE RID: 718 RVA: 0x000074A3 File Offset: 0x000056A3
		private static Delegate GetSetLogo_IHandler()
		{
			if (ActionBar.cb_setLogo_I == null)
			{
				ActionBar.cb_setLogo_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_V(ActionBar.n_SetLogo_I));
			}
			return ActionBar.cb_setLogo_I;
		}

		// Token: 0x060002CF RID: 719 RVA: 0x000074C7 File Offset: 0x000056C7
		private static void n_SetLogo_I(IntPtr jnienv, IntPtr native__this, int resId)
		{
			Java.Lang.Object.GetObject<ActionBar>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SetLogo(resId);
		}

		// Token: 0x060002D0 RID: 720
		[Register("setLogo", "(I)V", "GetSetLogo_IHandler")]
		public abstract void SetLogo(int resId);

		// Token: 0x060002D1 RID: 721 RVA: 0x000074D7 File Offset: 0x000056D7
		private static Delegate GetSetSelectedNavigationItem_IHandler()
		{
			if (ActionBar.cb_setSelectedNavigationItem_I == null)
			{
				ActionBar.cb_setSelectedNavigationItem_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_V(ActionBar.n_SetSelectedNavigationItem_I));
			}
			return ActionBar.cb_setSelectedNavigationItem_I;
		}

		// Token: 0x060002D2 RID: 722 RVA: 0x000074FB File Offset: 0x000056FB
		private static void n_SetSelectedNavigationItem_I(IntPtr jnienv, IntPtr native__this, int position)
		{
			Java.Lang.Object.GetObject<ActionBar>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SetSelectedNavigationItem(position);
		}

		// Token: 0x060002D3 RID: 723
		[Register("setSelectedNavigationItem", "(I)V", "GetSetSelectedNavigationItem_IHandler")]
		public abstract void SetSelectedNavigationItem(int position);

		// Token: 0x060002D4 RID: 724 RVA: 0x0000750B File Offset: 0x0000570B
		private static Delegate GetSetShowHideAnimationEnabled_ZHandler()
		{
			if (ActionBar.cb_setShowHideAnimationEnabled_Z == null)
			{
				ActionBar.cb_setShowHideAnimationEnabled_Z = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPZ_V(ActionBar.n_SetShowHideAnimationEnabled_Z));
			}
			return ActionBar.cb_setShowHideAnimationEnabled_Z;
		}

		// Token: 0x060002D5 RID: 725 RVA: 0x0000752F File Offset: 0x0000572F
		private static void n_SetShowHideAnimationEnabled_Z(IntPtr jnienv, IntPtr native__this, bool enabled)
		{
			Java.Lang.Object.GetObject<ActionBar>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SetShowHideAnimationEnabled(enabled);
		}

		// Token: 0x060002D6 RID: 726 RVA: 0x00007540 File Offset: 0x00005740
		[Register("setShowHideAnimationEnabled", "(Z)V", "GetSetShowHideAnimationEnabled_ZHandler")]
		public unsafe virtual void SetShowHideAnimationEnabled(bool enabled)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(enabled);
			ActionBar._members.InstanceMethods.InvokeVirtualVoidMethod("setShowHideAnimationEnabled.(Z)V", this, ptr);
		}

		// Token: 0x060002D7 RID: 727 RVA: 0x0000757B File Offset: 0x0000577B
		private static Delegate GetSetSplitBackgroundDrawable_Landroid_graphics_drawable_Drawable_Handler()
		{
			if (ActionBar.cb_setSplitBackgroundDrawable_Landroid_graphics_drawable_Drawable_ == null)
			{
				ActionBar.cb_setSplitBackgroundDrawable_Landroid_graphics_drawable_Drawable_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(ActionBar.n_SetSplitBackgroundDrawable_Landroid_graphics_drawable_Drawable_));
			}
			return ActionBar.cb_setSplitBackgroundDrawable_Landroid_graphics_drawable_Drawable_;
		}

		// Token: 0x060002D8 RID: 728 RVA: 0x000075A0 File Offset: 0x000057A0
		private static void n_SetSplitBackgroundDrawable_Landroid_graphics_drawable_Drawable_(IntPtr jnienv, IntPtr native__this, IntPtr native_d)
		{
			ActionBar @object = Java.Lang.Object.GetObject<ActionBar>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Drawable object2 = Java.Lang.Object.GetObject<Drawable>(native_d, JniHandleOwnership.DoNotTransfer);
			@object.SetSplitBackgroundDrawable(object2);
		}

		// Token: 0x060002D9 RID: 729 RVA: 0x000075C4 File Offset: 0x000057C4
		[Register("setSplitBackgroundDrawable", "(Landroid/graphics/drawable/Drawable;)V", "GetSetSplitBackgroundDrawable_Landroid_graphics_drawable_Drawable_Handler")]
		public unsafe virtual void SetSplitBackgroundDrawable(Drawable d)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((d == null) ? IntPtr.Zero : d.Handle);
				ActionBar._members.InstanceMethods.InvokeVirtualVoidMethod("setSplitBackgroundDrawable.(Landroid/graphics/drawable/Drawable;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(d);
			}
		}

		// Token: 0x060002DA RID: 730 RVA: 0x00007628 File Offset: 0x00005828
		private static Delegate GetSetStackedBackgroundDrawable_Landroid_graphics_drawable_Drawable_Handler()
		{
			if (ActionBar.cb_setStackedBackgroundDrawable_Landroid_graphics_drawable_Drawable_ == null)
			{
				ActionBar.cb_setStackedBackgroundDrawable_Landroid_graphics_drawable_Drawable_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(ActionBar.n_SetStackedBackgroundDrawable_Landroid_graphics_drawable_Drawable_));
			}
			return ActionBar.cb_setStackedBackgroundDrawable_Landroid_graphics_drawable_Drawable_;
		}

		// Token: 0x060002DB RID: 731 RVA: 0x0000764C File Offset: 0x0000584C
		private static void n_SetStackedBackgroundDrawable_Landroid_graphics_drawable_Drawable_(IntPtr jnienv, IntPtr native__this, IntPtr native_d)
		{
			ActionBar @object = Java.Lang.Object.GetObject<ActionBar>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Drawable object2 = Java.Lang.Object.GetObject<Drawable>(native_d, JniHandleOwnership.DoNotTransfer);
			@object.SetStackedBackgroundDrawable(object2);
		}

		// Token: 0x060002DC RID: 732 RVA: 0x00007670 File Offset: 0x00005870
		[Register("setStackedBackgroundDrawable", "(Landroid/graphics/drawable/Drawable;)V", "GetSetStackedBackgroundDrawable_Landroid_graphics_drawable_Drawable_Handler")]
		public unsafe virtual void SetStackedBackgroundDrawable(Drawable d)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((d == null) ? IntPtr.Zero : d.Handle);
				ActionBar._members.InstanceMethods.InvokeVirtualVoidMethod("setStackedBackgroundDrawable.(Landroid/graphics/drawable/Drawable;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(d);
			}
		}

		// Token: 0x060002DD RID: 733 RVA: 0x000076D4 File Offset: 0x000058D4
		private static Delegate GetSetSubtitle_IHandler()
		{
			if (ActionBar.cb_setSubtitle_I == null)
			{
				ActionBar.cb_setSubtitle_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_V(ActionBar.n_SetSubtitle_I));
			}
			return ActionBar.cb_setSubtitle_I;
		}

		// Token: 0x060002DE RID: 734 RVA: 0x000076F8 File Offset: 0x000058F8
		private static void n_SetSubtitle_I(IntPtr jnienv, IntPtr native__this, int resId)
		{
			Java.Lang.Object.GetObject<ActionBar>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SetSubtitle(resId);
		}

		// Token: 0x060002DF RID: 735
		[Register("setSubtitle", "(I)V", "GetSetSubtitle_IHandler")]
		public abstract void SetSubtitle(int resId);

		// Token: 0x060002E0 RID: 736 RVA: 0x00007708 File Offset: 0x00005908
		private static Delegate GetSetTitle_IHandler()
		{
			if (ActionBar.cb_setTitle_I == null)
			{
				ActionBar.cb_setTitle_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_V(ActionBar.n_SetTitle_I));
			}
			return ActionBar.cb_setTitle_I;
		}

		// Token: 0x060002E1 RID: 737 RVA: 0x0000772C File Offset: 0x0000592C
		private static void n_SetTitle_I(IntPtr jnienv, IntPtr native__this, int resId)
		{
			Java.Lang.Object.GetObject<ActionBar>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SetTitle(resId);
		}

		// Token: 0x060002E2 RID: 738
		[Register("setTitle", "(I)V", "GetSetTitle_IHandler")]
		public abstract void SetTitle(int resId);

		// Token: 0x060002E3 RID: 739 RVA: 0x0000773C File Offset: 0x0000593C
		private static Delegate GetSetWindowTitle_Ljava_lang_CharSequence_Handler()
		{
			if (ActionBar.cb_setWindowTitle_Ljava_lang_CharSequence_ == null)
			{
				ActionBar.cb_setWindowTitle_Ljava_lang_CharSequence_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(ActionBar.n_SetWindowTitle_Ljava_lang_CharSequence_));
			}
			return ActionBar.cb_setWindowTitle_Ljava_lang_CharSequence_;
		}

		// Token: 0x060002E4 RID: 740 RVA: 0x00007760 File Offset: 0x00005960
		private static void n_SetWindowTitle_Ljava_lang_CharSequence_(IntPtr jnienv, IntPtr native__this, IntPtr native_title)
		{
			ActionBar @object = Java.Lang.Object.GetObject<ActionBar>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ICharSequence object2 = Java.Lang.Object.GetObject<ICharSequence>(native_title, JniHandleOwnership.DoNotTransfer);
			@object.SetWindowTitle(object2);
		}

		// Token: 0x060002E5 RID: 741 RVA: 0x00007784 File Offset: 0x00005984
		[Register("setWindowTitle", "(Ljava/lang/CharSequence;)V", "GetSetWindowTitle_Ljava_lang_CharSequence_Handler")]
		public unsafe virtual void SetWindowTitle(ICharSequence title)
		{
			IntPtr intPtr = CharSequence.ToLocalJniHandle(title);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ActionBar._members.InstanceMethods.InvokeVirtualVoidMethod("setWindowTitle.(Ljava/lang/CharSequence;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(title);
			}
		}

		// Token: 0x060002E6 RID: 742 RVA: 0x000077E8 File Offset: 0x000059E8
		public void SetWindowTitle(string title)
		{
			Java.Lang.String @string = (title == null) ? null : new Java.Lang.String(title);
			this.SetWindowTitle(@string);
			if (@string != null)
			{
				@string.Dispose();
			}
		}

		// Token: 0x060002E7 RID: 743 RVA: 0x00007812 File Offset: 0x00005A12
		private static Delegate GetShowHandler()
		{
			if (ActionBar.cb_show == null)
			{
				ActionBar.cb_show = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(ActionBar.n_Show));
			}
			return ActionBar.cb_show;
		}

		// Token: 0x060002E8 RID: 744 RVA: 0x00007836 File Offset: 0x00005A36
		private static void n_Show(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<ActionBar>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Show();
		}

		// Token: 0x060002E9 RID: 745
		[Register("show", "()V", "GetShowHandler")]
		public abstract void Show();

		// Token: 0x060002EA RID: 746 RVA: 0x00007845 File Offset: 0x00005A45
		private static Delegate GetStartActionMode_Landroidx_appcompat_view_ActionMode_Callback_Handler()
		{
			if (ActionBar.cb_startActionMode_Landroidx_appcompat_view_ActionMode_Callback_ == null)
			{
				ActionBar.cb_startActionMode_Landroidx_appcompat_view_ActionMode_Callback_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(ActionBar.n_StartActionMode_Landroidx_appcompat_view_ActionMode_Callback_));
			}
			return ActionBar.cb_startActionMode_Landroidx_appcompat_view_ActionMode_Callback_;
		}

		// Token: 0x060002EB RID: 747 RVA: 0x0000786C File Offset: 0x00005A6C
		private static IntPtr n_StartActionMode_Landroidx_appcompat_view_ActionMode_Callback_(IntPtr jnienv, IntPtr native__this, IntPtr native__callback)
		{
			ActionBar @object = Java.Lang.Object.GetObject<ActionBar>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			AndroidX.AppCompat.View.ActionMode.ICallback object2 = Java.Lang.Object.GetObject<AndroidX.AppCompat.View.ActionMode.ICallback>(native__callback, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.StartActionMode(object2));
		}

		// Token: 0x060002EC RID: 748 RVA: 0x00007894 File Offset: 0x00005A94
		[Register("startActionMode", "(Landroidx/appcompat/view/ActionMode$Callback;)Landroidx/appcompat/view/ActionMode;", "GetStartActionMode_Landroidx_appcompat_view_ActionMode_Callback_Handler")]
		public unsafe virtual AndroidX.AppCompat.View.ActionMode StartActionMode(AndroidX.AppCompat.View.ActionMode.ICallback callback)
		{
			AndroidX.AppCompat.View.ActionMode @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((callback == null) ? IntPtr.Zero : ((Java.Lang.Object)callback).Handle);
				@object = Java.Lang.Object.GetObject<AndroidX.AppCompat.View.ActionMode>(ActionBar._members.InstanceMethods.InvokeVirtualObjectMethod("startActionMode.(Landroidx/appcompat/view/ActionMode$Callback;)Landroidx/appcompat/view/ActionMode;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(callback);
			}
			return @object;
		}

		// Token: 0x14000001 RID: 1
		// (add) Token: 0x060002ED RID: 749 RVA: 0x0000790C File Offset: 0x00005B0C
		// (remove) Token: 0x060002EE RID: 750 RVA: 0x00007958 File Offset: 0x00005B58
		public event EventHandler<ActionBar.MenuVisibilityEventArgs> MenuVisibility
		{
			add
			{
				EventHelper.AddEventHandler<ActionBar.IOnMenuVisibilityListener, ActionBar.IOnMenuVisibilityListenerImplementor>(ref this.weak_implementor_AddOnMenuVisibilityListener, new Func<ActionBar.IOnMenuVisibilityListenerImplementor>(this.__CreateIOnMenuVisibilityListenerImplementor), new Action<ActionBar.IOnMenuVisibilityListener>(this.AddOnMenuVisibilityListener), delegate(ActionBar.IOnMenuVisibilityListenerImplementor __h)
				{
					__h.Handler = (EventHandler<ActionBar.MenuVisibilityEventArgs>)Delegate.Combine(__h.Handler, value);
				});
			}
			remove
			{
				Func<ActionBar.IOnMenuVisibilityListenerImplementor, bool> empty;
				if ((empty = ActionBar.<>O.<0>____IsEmpty) == null)
				{
					empty = (ActionBar.<>O.<0>____IsEmpty = new Func<ActionBar.IOnMenuVisibilityListenerImplementor, bool>(ActionBar.IOnMenuVisibilityListenerImplementor.__IsEmpty));
				}
				EventHelper.RemoveEventHandler<ActionBar.IOnMenuVisibilityListener, ActionBar.IOnMenuVisibilityListenerImplementor>(ref this.weak_implementor_AddOnMenuVisibilityListener, empty, delegate(ActionBar.IOnMenuVisibilityListener __v)
				{
					this.RemoveOnMenuVisibilityListener(__v);
				}, delegate(ActionBar.IOnMenuVisibilityListenerImplementor __h)
				{
					__h.Handler = (EventHandler<ActionBar.MenuVisibilityEventArgs>)Delegate.Remove(__h.Handler, value);
				});
			}
		}

		// Token: 0x060002EF RID: 751 RVA: 0x000079B7 File Offset: 0x00005BB7
		private ActionBar.IOnMenuVisibilityListenerImplementor __CreateIOnMenuVisibilityListenerImplementor()
		{
			return new ActionBar.IOnMenuVisibilityListenerImplementor(this);
		}

		// Token: 0x04000055 RID: 85
		private static readonly JniPeerMembers _members = new XAPeerMembers("androidx/appcompat/app/ActionBar", typeof(ActionBar));

		// Token: 0x04000056 RID: 86
		private static Delegate cb_getCustomView;

		// Token: 0x04000057 RID: 87
		private static Delegate cb_setCustomView_Landroid_view_View_;

		// Token: 0x04000058 RID: 88
		private static Delegate cb_getDisplayOptions;

		// Token: 0x04000059 RID: 89
		private static Delegate cb_setDisplayOptions_I;

		// Token: 0x0400005A RID: 90
		private static Delegate cb_getElevation;

		// Token: 0x0400005B RID: 91
		private static Delegate cb_setElevation_F;

		// Token: 0x0400005C RID: 92
		private static Delegate cb_getHeight;

		// Token: 0x0400005D RID: 93
		private static Delegate cb_getHideOffset;

		// Token: 0x0400005E RID: 94
		private static Delegate cb_setHideOffset_I;

		// Token: 0x0400005F RID: 95
		private static Delegate cb_isHideOnContentScrollEnabled;

		// Token: 0x04000060 RID: 96
		private static Delegate cb_setHideOnContentScrollEnabled_Z;

		// Token: 0x04000061 RID: 97
		private static Delegate cb_isShowing;

		// Token: 0x04000062 RID: 98
		private static Delegate cb_isTitleTruncated;

		// Token: 0x04000063 RID: 99
		private static Delegate cb_getNavigationItemCount;

		// Token: 0x04000064 RID: 100
		private static Delegate cb_getNavigationMode;

		// Token: 0x04000065 RID: 101
		private static Delegate cb_setNavigationMode_I;

		// Token: 0x04000066 RID: 102
		private static Delegate cb_getSelectedNavigationIndex;

		// Token: 0x04000067 RID: 103
		private static Delegate cb_getSelectedTab;

		// Token: 0x04000068 RID: 104
		private static Delegate cb_getSubtitle;

		// Token: 0x04000069 RID: 105
		private static Delegate cb_setSubtitle_Ljava_lang_CharSequence_;

		// Token: 0x0400006A RID: 106
		private static Delegate cb_getTabCount;

		// Token: 0x0400006B RID: 107
		private static Delegate cb_getThemedContext;

		// Token: 0x0400006C RID: 108
		private static Delegate cb_getTitle;

		// Token: 0x0400006D RID: 109
		private static Delegate cb_setTitle_Ljava_lang_CharSequence_;

		// Token: 0x0400006E RID: 110
		private static Delegate cb_addOnMenuVisibilityListener_Landroidx_appcompat_app_ActionBar_OnMenuVisibilityListener_;

		// Token: 0x0400006F RID: 111
		private static Delegate cb_addTab_Landroidx_appcompat_app_ActionBar_Tab_;

		// Token: 0x04000070 RID: 112
		private static Delegate cb_addTab_Landroidx_appcompat_app_ActionBar_Tab_Z;

		// Token: 0x04000071 RID: 113
		private static Delegate cb_addTab_Landroidx_appcompat_app_ActionBar_Tab_I;

		// Token: 0x04000072 RID: 114
		private static Delegate cb_addTab_Landroidx_appcompat_app_ActionBar_Tab_IZ;

		// Token: 0x04000073 RID: 115
		private static Delegate cb_closeOptionsMenu;

		// Token: 0x04000074 RID: 116
		private static Delegate cb_collapseActionView;

		// Token: 0x04000075 RID: 117
		private static Delegate cb_dispatchMenuVisibilityChanged_Z;

		// Token: 0x04000076 RID: 118
		private static Delegate cb_getTabAt_I;

		// Token: 0x04000077 RID: 119
		private static Delegate cb_hide;

		// Token: 0x04000078 RID: 120
		private static Delegate cb_invalidateOptionsMenu;

		// Token: 0x04000079 RID: 121
		private static Delegate cb_newTab;

		// Token: 0x0400007A RID: 122
		private static Delegate cb_onConfigurationChanged_Landroid_content_res_Configuration_;

		// Token: 0x0400007B RID: 123
		private static Delegate cb_onKeyShortcut_ILandroid_view_KeyEvent_;

		// Token: 0x0400007C RID: 124
		private static Delegate cb_onMenuKeyEvent_Landroid_view_KeyEvent_;

		// Token: 0x0400007D RID: 125
		private static Delegate cb_openOptionsMenu;

		// Token: 0x0400007E RID: 126
		private static Delegate cb_removeAllTabs;

		// Token: 0x0400007F RID: 127
		private static Delegate cb_removeOnMenuVisibilityListener_Landroidx_appcompat_app_ActionBar_OnMenuVisibilityListener_;

		// Token: 0x04000080 RID: 128
		private static Delegate cb_removeTab_Landroidx_appcompat_app_ActionBar_Tab_;

		// Token: 0x04000081 RID: 129
		private static Delegate cb_removeTabAt_I;

		// Token: 0x04000082 RID: 130
		private static Delegate cb_selectTab_Landroidx_appcompat_app_ActionBar_Tab_;

		// Token: 0x04000083 RID: 131
		private static Delegate cb_setBackgroundDrawable_Landroid_graphics_drawable_Drawable_;

		// Token: 0x04000084 RID: 132
		private static Delegate cb_setCustomView_Landroid_view_View_Landroidx_appcompat_app_ActionBar_LayoutParams_;

		// Token: 0x04000085 RID: 133
		private static Delegate cb_setCustomView_I;

		// Token: 0x04000086 RID: 134
		private static Delegate cb_setDefaultDisplayHomeAsUpEnabled_Z;

		// Token: 0x04000087 RID: 135
		private static Delegate cb_setDisplayHomeAsUpEnabled_Z;

		// Token: 0x04000088 RID: 136
		private static Delegate cb_setDisplayOptions_II;

		// Token: 0x04000089 RID: 137
		private static Delegate cb_setDisplayShowCustomEnabled_Z;

		// Token: 0x0400008A RID: 138
		private static Delegate cb_setDisplayShowHomeEnabled_Z;

		// Token: 0x0400008B RID: 139
		private static Delegate cb_setDisplayShowTitleEnabled_Z;

		// Token: 0x0400008C RID: 140
		private static Delegate cb_setDisplayUseLogoEnabled_Z;

		// Token: 0x0400008D RID: 141
		private static Delegate cb_setHomeActionContentDescription_I;

		// Token: 0x0400008E RID: 142
		private static Delegate cb_setHomeActionContentDescription_Ljava_lang_CharSequence_;

		// Token: 0x0400008F RID: 143
		private static Delegate cb_setHomeAsUpIndicator_Landroid_graphics_drawable_Drawable_;

		// Token: 0x04000090 RID: 144
		private static Delegate cb_setHomeAsUpIndicator_I;

		// Token: 0x04000091 RID: 145
		private static Delegate cb_setHomeButtonEnabled_Z;

		// Token: 0x04000092 RID: 146
		private static Delegate cb_setIcon_Landroid_graphics_drawable_Drawable_;

		// Token: 0x04000093 RID: 147
		private static Delegate cb_setIcon_I;

		// Token: 0x04000094 RID: 148
		private static Delegate cb_setListNavigationCallbacks_Landroid_widget_SpinnerAdapter_Landroidx_appcompat_app_ActionBar_OnNavigationListener_;

		// Token: 0x04000095 RID: 149
		private static Delegate cb_setLogo_Landroid_graphics_drawable_Drawable_;

		// Token: 0x04000096 RID: 150
		private static Delegate cb_setLogo_I;

		// Token: 0x04000097 RID: 151
		private static Delegate cb_setSelectedNavigationItem_I;

		// Token: 0x04000098 RID: 152
		private static Delegate cb_setShowHideAnimationEnabled_Z;

		// Token: 0x04000099 RID: 153
		private static Delegate cb_setSplitBackgroundDrawable_Landroid_graphics_drawable_Drawable_;

		// Token: 0x0400009A RID: 154
		private static Delegate cb_setStackedBackgroundDrawable_Landroid_graphics_drawable_Drawable_;

		// Token: 0x0400009B RID: 155
		private static Delegate cb_setSubtitle_I;

		// Token: 0x0400009C RID: 156
		private static Delegate cb_setTitle_I;

		// Token: 0x0400009D RID: 157
		private static Delegate cb_setWindowTitle_Ljava_lang_CharSequence_;

		// Token: 0x0400009E RID: 158
		private static Delegate cb_show;

		// Token: 0x0400009F RID: 159
		private static Delegate cb_startActionMode_Landroidx_appcompat_view_ActionMode_Callback_;

		// Token: 0x040000A0 RID: 160
		private WeakReference weak_implementor_AddOnMenuVisibilityListener;

		// Token: 0x02000040 RID: 64
		[Register("androidx/appcompat/app/ActionBar$LayoutParams", DoNotGenerateAcw = true)]
		public class LayoutParams : ViewGroup.MarginLayoutParams
		{
			// Token: 0x17000033 RID: 51
			// (get) Token: 0x060002F1 RID: 753 RVA: 0x000079DA File Offset: 0x00005BDA
			// (set) Token: 0x060002F2 RID: 754 RVA: 0x000079F1 File Offset: 0x00005BF1
			[Register("gravity")]
			public int Gravity
			{
				get
				{
					return ActionBar.LayoutParams._members.InstanceFields.GetInt32Value("gravity.I", this);
				}
				set
				{
					ActionBar.LayoutParams._members.InstanceFields.SetValue("gravity.I", this, value);
				}
			}

			// Token: 0x17000034 RID: 52
			// (get) Token: 0x060002F3 RID: 755 RVA: 0x00007A0C File Offset: 0x00005C0C
			internal static IntPtr class_ref
			{
				get
				{
					return ActionBar.LayoutParams._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x17000035 RID: 53
			// (get) Token: 0x060002F4 RID: 756 RVA: 0x00007A30 File Offset: 0x00005C30
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return ActionBar.LayoutParams._members;
				}
			}

			// Token: 0x17000036 RID: 54
			// (get) Token: 0x060002F5 RID: 757 RVA: 0x00007A38 File Offset: 0x00005C38
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return ActionBar.LayoutParams._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x17000037 RID: 55
			// (get) Token: 0x060002F6 RID: 758 RVA: 0x00007A5C File Offset: 0x00005C5C
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return ActionBar.LayoutParams._members.ManagedPeerType;
				}
			}

			// Token: 0x060002F7 RID: 759 RVA: 0x00007A68 File Offset: 0x00005C68
			protected LayoutParams(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
			{
			}

			// Token: 0x060002F8 RID: 760 RVA: 0x00007A74 File Offset: 0x00005C74
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
					base.SetHandle(ActionBar.LayoutParams._members.InstanceMethods.StartCreateInstance("(Landroid/content/Context;Landroid/util/AttributeSet;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
					ActionBar.LayoutParams._members.InstanceMethods.FinishCreateInstance("(Landroid/content/Context;Landroid/util/AttributeSet;)V", this, ptr);
				}
				finally
				{
					GC.KeepAlive(c);
					GC.KeepAlive(attrs);
				}
			}

			// Token: 0x060002F9 RID: 761 RVA: 0x00007B50 File Offset: 0x00005D50
			[Register(".ctor", "(Landroid/view/ViewGroup$LayoutParams;)V", "")]
			public unsafe LayoutParams(ViewGroup.LayoutParams source) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (base.Handle != IntPtr.Zero)
				{
					return;
				}
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((source == null) ? IntPtr.Zero : source.Handle);
					base.SetHandle(ActionBar.LayoutParams._members.InstanceMethods.StartCreateInstance("(Landroid/view/ViewGroup$LayoutParams;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
					ActionBar.LayoutParams._members.InstanceMethods.FinishCreateInstance("(Landroid/view/ViewGroup$LayoutParams;)V", this, ptr);
				}
				finally
				{
					GC.KeepAlive(source);
				}
			}

			// Token: 0x060002FA RID: 762 RVA: 0x00007C00 File Offset: 0x00005E00
			[Register(".ctor", "(Landroidx/appcompat/app/ActionBar$LayoutParams;)V", "")]
			public unsafe LayoutParams(ActionBar.LayoutParams source) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (base.Handle != IntPtr.Zero)
				{
					return;
				}
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((source == null) ? IntPtr.Zero : source.Handle);
					base.SetHandle(ActionBar.LayoutParams._members.InstanceMethods.StartCreateInstance("(Landroidx/appcompat/app/ActionBar$LayoutParams;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
					ActionBar.LayoutParams._members.InstanceMethods.FinishCreateInstance("(Landroidx/appcompat/app/ActionBar$LayoutParams;)V", this, ptr);
				}
				finally
				{
					GC.KeepAlive(source);
				}
			}

			// Token: 0x060002FB RID: 763 RVA: 0x00007CB0 File Offset: 0x00005EB0
			[Register(".ctor", "(I)V", "")]
			public unsafe LayoutParams(int gravity) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (base.Handle != IntPtr.Zero)
				{
					return;
				}
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(gravity);
				base.SetHandle(ActionBar.LayoutParams._members.InstanceMethods.StartCreateInstance("(I)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				ActionBar.LayoutParams._members.InstanceMethods.FinishCreateInstance("(I)V", this, ptr);
			}

			// Token: 0x060002FC RID: 764 RVA: 0x00007D34 File Offset: 0x00005F34
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
				base.SetHandle(ActionBar.LayoutParams._members.InstanceMethods.StartCreateInstance("(II)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				ActionBar.LayoutParams._members.InstanceMethods.FinishCreateInstance("(II)V", this, ptr);
			}

			// Token: 0x060002FD RID: 765 RVA: 0x00007DCC File Offset: 0x00005FCC
			[Register(".ctor", "(III)V", "")]
			public unsafe LayoutParams(int width, int height, int gravity) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (base.Handle != IntPtr.Zero)
				{
					return;
				}
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(width);
				ptr[1] = new JniArgumentValue(height);
				ptr[2] = new JniArgumentValue(gravity);
				base.SetHandle(ActionBar.LayoutParams._members.InstanceMethods.StartCreateInstance("(III)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				ActionBar.LayoutParams._members.InstanceMethods.FinishCreateInstance("(III)V", this, ptr);
			}

			// Token: 0x040000A1 RID: 161
			private static readonly JniPeerMembers _members = new XAPeerMembers("androidx/appcompat/app/ActionBar$LayoutParams", typeof(ActionBar.LayoutParams));
		}

		// Token: 0x02000041 RID: 65
		[Register("androidx/appcompat/app/ActionBar$OnMenuVisibilityListener", "", "AndroidX.AppCompat.App.ActionBar/IOnMenuVisibilityListenerInvoker")]
		public interface IOnMenuVisibilityListener : IJavaObject, IDisposable, IJavaPeerable
		{
			// Token: 0x060002FF RID: 767
			[Register("onMenuVisibilityChanged", "(Z)V", "GetOnMenuVisibilityChanged_ZHandler:AndroidX.AppCompat.App.ActionBar/IOnMenuVisibilityListenerInvoker, Xamarin.AndroidX.AppCompat")]
			void OnMenuVisibilityChanged(bool isVisible);
		}

		// Token: 0x02000042 RID: 66
		[Register("androidx/appcompat/app/ActionBar$OnMenuVisibilityListener", DoNotGenerateAcw = true)]
		internal class IOnMenuVisibilityListenerInvoker : Java.Lang.Object, ActionBar.IOnMenuVisibilityListener, IJavaObject, IDisposable, IJavaPeerable
		{
			// Token: 0x17000038 RID: 56
			// (get) Token: 0x06000300 RID: 768 RVA: 0x00007E94 File Offset: 0x00006094
			private static IntPtr java_class_ref
			{
				get
				{
					return ActionBar.IOnMenuVisibilityListenerInvoker._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x17000039 RID: 57
			// (get) Token: 0x06000301 RID: 769 RVA: 0x00007EB8 File Offset: 0x000060B8
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return ActionBar.IOnMenuVisibilityListenerInvoker._members;
				}
			}

			// Token: 0x1700003A RID: 58
			// (get) Token: 0x06000302 RID: 770 RVA: 0x00007EBF File Offset: 0x000060BF
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return this.class_ref;
				}
			}

			// Token: 0x1700003B RID: 59
			// (get) Token: 0x06000303 RID: 771 RVA: 0x00007EC7 File Offset: 0x000060C7
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return ActionBar.IOnMenuVisibilityListenerInvoker._members.ManagedPeerType;
				}
			}

			// Token: 0x06000304 RID: 772 RVA: 0x00007ED3 File Offset: 0x000060D3
			public static ActionBar.IOnMenuVisibilityListener GetObject(IntPtr handle, JniHandleOwnership transfer)
			{
				return Java.Lang.Object.GetObject<ActionBar.IOnMenuVisibilityListener>(handle, transfer);
			}

			// Token: 0x06000305 RID: 773 RVA: 0x00007EDC File Offset: 0x000060DC
			private static IntPtr Validate(IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf(handle, ActionBar.IOnMenuVisibilityListenerInvoker.java_class_ref))
				{
					throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'androidx.appcompat.app.ActionBar.OnMenuVisibilityListener'.");
				}
				return handle;
			}

			// Token: 0x06000306 RID: 774 RVA: 0x00007F07 File Offset: 0x00006107
			protected override void Dispose(bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
				{
					JNIEnv.DeleteGlobalRef(this.class_ref);
				}
				this.class_ref = IntPtr.Zero;
				base.Dispose(disposing);
			}

			// Token: 0x06000307 RID: 775 RVA: 0x00007F38 File Offset: 0x00006138
			public IOnMenuVisibilityListenerInvoker(IntPtr handle, JniHandleOwnership transfer) : base(ActionBar.IOnMenuVisibilityListenerInvoker.Validate(handle), transfer)
			{
				IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
				this.class_ref = JNIEnv.NewGlobalRef(objectClass);
				JNIEnv.DeleteLocalRef(objectClass);
			}

			// Token: 0x06000308 RID: 776 RVA: 0x00007F70 File Offset: 0x00006170
			private static Delegate GetOnMenuVisibilityChanged_ZHandler()
			{
				if (ActionBar.IOnMenuVisibilityListenerInvoker.cb_onMenuVisibilityChanged_Z == null)
				{
					ActionBar.IOnMenuVisibilityListenerInvoker.cb_onMenuVisibilityChanged_Z = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPZ_V(ActionBar.IOnMenuVisibilityListenerInvoker.n_OnMenuVisibilityChanged_Z));
				}
				return ActionBar.IOnMenuVisibilityListenerInvoker.cb_onMenuVisibilityChanged_Z;
			}

			// Token: 0x06000309 RID: 777 RVA: 0x00007F94 File Offset: 0x00006194
			private static void n_OnMenuVisibilityChanged_Z(IntPtr jnienv, IntPtr native__this, bool isVisible)
			{
				Java.Lang.Object.GetObject<ActionBar.IOnMenuVisibilityListener>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).OnMenuVisibilityChanged(isVisible);
			}

			// Token: 0x0600030A RID: 778 RVA: 0x00007FA4 File Offset: 0x000061A4
			public unsafe void OnMenuVisibilityChanged(bool isVisible)
			{
				if (this.id_onMenuVisibilityChanged_Z == IntPtr.Zero)
				{
					this.id_onMenuVisibilityChanged_Z = JNIEnv.GetMethodID(this.class_ref, "onMenuVisibilityChanged", "(Z)V");
				}
				JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
				*ptr = new JValue(isVisible);
				JNIEnv.CallVoidMethod(base.Handle, this.id_onMenuVisibilityChanged_Z, ptr);
			}

			// Token: 0x040000A2 RID: 162
			private static readonly JniPeerMembers _members = new XAPeerMembers("androidx/appcompat/app/ActionBar$OnMenuVisibilityListener", typeof(ActionBar.IOnMenuVisibilityListenerInvoker));

			// Token: 0x040000A3 RID: 163
			private IntPtr class_ref;

			// Token: 0x040000A4 RID: 164
			private static Delegate cb_onMenuVisibilityChanged_Z;

			// Token: 0x040000A5 RID: 165
			private IntPtr id_onMenuVisibilityChanged_Z;
		}

		// Token: 0x02000043 RID: 67
		public class MenuVisibilityEventArgs : EventArgs
		{
			// Token: 0x0600030C RID: 780 RVA: 0x00008023 File Offset: 0x00006223
			public MenuVisibilityEventArgs(bool isVisible)
			{
				this.isVisible = isVisible;
			}

			// Token: 0x040000A6 RID: 166
			private bool isVisible;
		}

		// Token: 0x02000044 RID: 68
		[Register("mono/androidx/appcompat/app/ActionBar_OnMenuVisibilityListenerImplementor")]
		internal sealed class IOnMenuVisibilityListenerImplementor : Java.Lang.Object, ActionBar.IOnMenuVisibilityListener, IJavaObject, IDisposable, IJavaPeerable
		{
			// Token: 0x0600030D RID: 781 RVA: 0x00008032 File Offset: 0x00006232
			public IOnMenuVisibilityListenerImplementor(object sender) : base(JNIEnv.StartCreateInstance("mono/androidx/appcompat/app/ActionBar_OnMenuVisibilityListenerImplementor", "()V", Array.Empty<JValue>()), JniHandleOwnership.TransferLocalRef)
			{
				JNIEnv.FinishCreateInstance(base.Handle, "()V", Array.Empty<JValue>());
				this.sender = sender;
			}

			// Token: 0x0600030E RID: 782 RVA: 0x0000806C File Offset: 0x0000626C
			public void OnMenuVisibilityChanged(bool isVisible)
			{
				EventHandler<ActionBar.MenuVisibilityEventArgs> handler = this.Handler;
				if (handler != null)
				{
					handler(this.sender, new ActionBar.MenuVisibilityEventArgs(isVisible));
				}
			}

			// Token: 0x0600030F RID: 783 RVA: 0x00008095 File Offset: 0x00006295
			internal static bool __IsEmpty(ActionBar.IOnMenuVisibilityListenerImplementor value)
			{
				return value.Handler == null;
			}

			// Token: 0x040000A7 RID: 167
			private object sender;

			// Token: 0x040000A8 RID: 168
			public EventHandler<ActionBar.MenuVisibilityEventArgs> Handler;
		}

		// Token: 0x02000045 RID: 69
		[Register("androidx/appcompat/app/ActionBar$OnNavigationListener", "", "AndroidX.AppCompat.App.ActionBar/IOnNavigationListenerInvoker")]
		public interface IOnNavigationListener : IJavaObject, IDisposable, IJavaPeerable
		{
			// Token: 0x06000310 RID: 784
			[Register("onNavigationItemSelected", "(IJ)Z", "GetOnNavigationItemSelected_IJHandler:AndroidX.AppCompat.App.ActionBar/IOnNavigationListenerInvoker, Xamarin.AndroidX.AppCompat")]
			bool OnNavigationItemSelected(int itemPosition, long itemId);
		}

		// Token: 0x02000046 RID: 70
		[Register("androidx/appcompat/app/ActionBar$OnNavigationListener", DoNotGenerateAcw = true)]
		internal class IOnNavigationListenerInvoker : Java.Lang.Object, ActionBar.IOnNavigationListener, IJavaObject, IDisposable, IJavaPeerable
		{
			// Token: 0x1700003C RID: 60
			// (get) Token: 0x06000311 RID: 785 RVA: 0x000080A0 File Offset: 0x000062A0
			private static IntPtr java_class_ref
			{
				get
				{
					return ActionBar.IOnNavigationListenerInvoker._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x1700003D RID: 61
			// (get) Token: 0x06000312 RID: 786 RVA: 0x000080C4 File Offset: 0x000062C4
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return ActionBar.IOnNavigationListenerInvoker._members;
				}
			}

			// Token: 0x1700003E RID: 62
			// (get) Token: 0x06000313 RID: 787 RVA: 0x000080CB File Offset: 0x000062CB
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return this.class_ref;
				}
			}

			// Token: 0x1700003F RID: 63
			// (get) Token: 0x06000314 RID: 788 RVA: 0x000080D3 File Offset: 0x000062D3
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return ActionBar.IOnNavigationListenerInvoker._members.ManagedPeerType;
				}
			}

			// Token: 0x06000315 RID: 789 RVA: 0x000080DF File Offset: 0x000062DF
			public static ActionBar.IOnNavigationListener GetObject(IntPtr handle, JniHandleOwnership transfer)
			{
				return Java.Lang.Object.GetObject<ActionBar.IOnNavigationListener>(handle, transfer);
			}

			// Token: 0x06000316 RID: 790 RVA: 0x000080E8 File Offset: 0x000062E8
			private static IntPtr Validate(IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf(handle, ActionBar.IOnNavigationListenerInvoker.java_class_ref))
				{
					throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'androidx.appcompat.app.ActionBar.OnNavigationListener'.");
				}
				return handle;
			}

			// Token: 0x06000317 RID: 791 RVA: 0x00008113 File Offset: 0x00006313
			protected override void Dispose(bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
				{
					JNIEnv.DeleteGlobalRef(this.class_ref);
				}
				this.class_ref = IntPtr.Zero;
				base.Dispose(disposing);
			}

			// Token: 0x06000318 RID: 792 RVA: 0x00008144 File Offset: 0x00006344
			public IOnNavigationListenerInvoker(IntPtr handle, JniHandleOwnership transfer) : base(ActionBar.IOnNavigationListenerInvoker.Validate(handle), transfer)
			{
				IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
				this.class_ref = JNIEnv.NewGlobalRef(objectClass);
				JNIEnv.DeleteLocalRef(objectClass);
			}

			// Token: 0x06000319 RID: 793 RVA: 0x0000817C File Offset: 0x0000637C
			private static Delegate GetOnNavigationItemSelected_IJHandler()
			{
				if (ActionBar.IOnNavigationListenerInvoker.cb_onNavigationItemSelected_IJ == null)
				{
					ActionBar.IOnNavigationListenerInvoker.cb_onNavigationItemSelected_IJ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPIJ_Z(ActionBar.IOnNavigationListenerInvoker.n_OnNavigationItemSelected_IJ));
				}
				return ActionBar.IOnNavigationListenerInvoker.cb_onNavigationItemSelected_IJ;
			}

			// Token: 0x0600031A RID: 794 RVA: 0x000081A0 File Offset: 0x000063A0
			private static bool n_OnNavigationItemSelected_IJ(IntPtr jnienv, IntPtr native__this, int itemPosition, long itemId)
			{
				return Java.Lang.Object.GetObject<ActionBar.IOnNavigationListener>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).OnNavigationItemSelected(itemPosition, itemId);
			}

			// Token: 0x0600031B RID: 795 RVA: 0x000081B4 File Offset: 0x000063B4
			public unsafe bool OnNavigationItemSelected(int itemPosition, long itemId)
			{
				if (this.id_onNavigationItemSelected_IJ == IntPtr.Zero)
				{
					this.id_onNavigationItemSelected_IJ = JNIEnv.GetMethodID(this.class_ref, "onNavigationItemSelected", "(IJ)Z");
				}
				JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JValue))];
				*ptr = new JValue(itemPosition);
				ptr[1] = new JValue(itemId);
				return JNIEnv.CallBooleanMethod(base.Handle, this.id_onNavigationItemSelected_IJ, ptr);
			}

			// Token: 0x040000A9 RID: 169
			private static readonly JniPeerMembers _members = new XAPeerMembers("androidx/appcompat/app/ActionBar$OnNavigationListener", typeof(ActionBar.IOnNavigationListenerInvoker));

			// Token: 0x040000AA RID: 170
			private IntPtr class_ref;

			// Token: 0x040000AB RID: 171
			private static Delegate cb_onNavigationItemSelected_IJ;

			// Token: 0x040000AC RID: 172
			private IntPtr id_onNavigationItemSelected_IJ;
		}

		// Token: 0x02000047 RID: 71
		[Register("androidx/appcompat/app/ActionBar$Tab", DoNotGenerateAcw = true)]
		public abstract class Tab : Java.Lang.Object
		{
			// Token: 0x17000040 RID: 64
			// (get) Token: 0x0600031D RID: 797 RVA: 0x00008248 File Offset: 0x00006448
			internal static IntPtr class_ref
			{
				get
				{
					return ActionBar.Tab._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x17000041 RID: 65
			// (get) Token: 0x0600031E RID: 798 RVA: 0x0000826C File Offset: 0x0000646C
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return ActionBar.Tab._members;
				}
			}

			// Token: 0x17000042 RID: 66
			// (get) Token: 0x0600031F RID: 799 RVA: 0x00008274 File Offset: 0x00006474
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return ActionBar.Tab._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x17000043 RID: 67
			// (get) Token: 0x06000320 RID: 800 RVA: 0x00008298 File Offset: 0x00006498
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return ActionBar.Tab._members.ManagedPeerType;
				}
			}

			// Token: 0x06000321 RID: 801 RVA: 0x000039D4 File Offset: 0x00001BD4
			protected Tab(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
			{
			}

			// Token: 0x06000322 RID: 802 RVA: 0x000082A4 File Offset: 0x000064A4
			[Register(".ctor", "()V", "")]
			public Tab() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (base.Handle != IntPtr.Zero)
				{
					return;
				}
				base.SetHandle(ActionBar.Tab._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
				ActionBar.Tab._members.InstanceMethods.FinishCreateInstance("()V", this, null);
			}

			// Token: 0x06000323 RID: 803 RVA: 0x00008312 File Offset: 0x00006512
			private static Delegate GetGetContentDescriptionHandler()
			{
				if (ActionBar.Tab.cb_getContentDescription == null)
				{
					ActionBar.Tab.cb_getContentDescription = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(ActionBar.Tab.n_GetContentDescription));
				}
				return ActionBar.Tab.cb_getContentDescription;
			}

			// Token: 0x06000324 RID: 804 RVA: 0x00008336 File Offset: 0x00006536
			private static IntPtr n_GetContentDescription(IntPtr jnienv, IntPtr native__this)
			{
				return CharSequence.ToLocalJniHandle(Java.Lang.Object.GetObject<ActionBar.Tab>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ContentDescriptionFormatted);
			}

			// Token: 0x17000044 RID: 68
			// (get) Token: 0x06000325 RID: 805
			public abstract ICharSequence ContentDescriptionFormatted { [Register("getContentDescription", "()Ljava/lang/CharSequence;", "GetGetContentDescriptionHandler")] get; }

			// Token: 0x17000045 RID: 69
			// (get) Token: 0x06000326 RID: 806 RVA: 0x0000834A File Offset: 0x0000654A
			public string ContentDescription
			{
				get
				{
					if (this.ContentDescriptionFormatted != null)
					{
						return this.ContentDescriptionFormatted.ToString();
					}
					return null;
				}
			}

			// Token: 0x06000327 RID: 807 RVA: 0x00008361 File Offset: 0x00006561
			private static Delegate GetGetCustomViewHandler()
			{
				if (ActionBar.Tab.cb_getCustomView == null)
				{
					ActionBar.Tab.cb_getCustomView = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(ActionBar.Tab.n_GetCustomView));
				}
				return ActionBar.Tab.cb_getCustomView;
			}

			// Token: 0x06000328 RID: 808 RVA: 0x00008385 File Offset: 0x00006585
			private static IntPtr n_GetCustomView(IntPtr jnienv, IntPtr native__this)
			{
				return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<ActionBar.Tab>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).CustomView);
			}

			// Token: 0x17000046 RID: 70
			// (get) Token: 0x06000329 RID: 809
			public abstract View CustomView { [Register("getCustomView", "()Landroid/view/View;", "GetGetCustomViewHandler")] get; }

			// Token: 0x0600032A RID: 810 RVA: 0x00008399 File Offset: 0x00006599
			private static Delegate GetGetIconHandler()
			{
				if (ActionBar.Tab.cb_getIcon == null)
				{
					ActionBar.Tab.cb_getIcon = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(ActionBar.Tab.n_GetIcon));
				}
				return ActionBar.Tab.cb_getIcon;
			}

			// Token: 0x0600032B RID: 811 RVA: 0x000083BD File Offset: 0x000065BD
			private static IntPtr n_GetIcon(IntPtr jnienv, IntPtr native__this)
			{
				return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<ActionBar.Tab>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Icon);
			}

			// Token: 0x17000047 RID: 71
			// (get) Token: 0x0600032C RID: 812
			public abstract Drawable Icon { [Register("getIcon", "()Landroid/graphics/drawable/Drawable;", "GetGetIconHandler")] get; }

			// Token: 0x0600032D RID: 813 RVA: 0x000083D1 File Offset: 0x000065D1
			private static Delegate GetGetPositionHandler()
			{
				if (ActionBar.Tab.cb_getPosition == null)
				{
					ActionBar.Tab.cb_getPosition = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(ActionBar.Tab.n_GetPosition));
				}
				return ActionBar.Tab.cb_getPosition;
			}

			// Token: 0x0600032E RID: 814 RVA: 0x000083F5 File Offset: 0x000065F5
			private static int n_GetPosition(IntPtr jnienv, IntPtr native__this)
			{
				return Java.Lang.Object.GetObject<ActionBar.Tab>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Position;
			}

			// Token: 0x17000048 RID: 72
			// (get) Token: 0x0600032F RID: 815
			public abstract int Position { [Register("getPosition", "()I", "GetGetPositionHandler")] get; }

			// Token: 0x06000330 RID: 816 RVA: 0x00008404 File Offset: 0x00006604
			private static Delegate GetGetTagHandler()
			{
				if (ActionBar.Tab.cb_getTag == null)
				{
					ActionBar.Tab.cb_getTag = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(ActionBar.Tab.n_GetTag));
				}
				return ActionBar.Tab.cb_getTag;
			}

			// Token: 0x06000331 RID: 817 RVA: 0x00008428 File Offset: 0x00006628
			private static IntPtr n_GetTag(IntPtr jnienv, IntPtr native__this)
			{
				return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<ActionBar.Tab>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Tag);
			}

			// Token: 0x17000049 RID: 73
			// (get) Token: 0x06000332 RID: 818
			public abstract Java.Lang.Object Tag { [Register("getTag", "()Ljava/lang/Object;", "GetGetTagHandler")] get; }

			// Token: 0x06000333 RID: 819 RVA: 0x0000843C File Offset: 0x0000663C
			private static Delegate GetGetTextHandler()
			{
				if (ActionBar.Tab.cb_getText == null)
				{
					ActionBar.Tab.cb_getText = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(ActionBar.Tab.n_GetText));
				}
				return ActionBar.Tab.cb_getText;
			}

			// Token: 0x06000334 RID: 820 RVA: 0x00008460 File Offset: 0x00006660
			private static IntPtr n_GetText(IntPtr jnienv, IntPtr native__this)
			{
				return CharSequence.ToLocalJniHandle(Java.Lang.Object.GetObject<ActionBar.Tab>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).TextFormatted);
			}

			// Token: 0x1700004A RID: 74
			// (get) Token: 0x06000335 RID: 821
			public abstract ICharSequence TextFormatted { [Register("getText", "()Ljava/lang/CharSequence;", "GetGetTextHandler")] get; }

			// Token: 0x1700004B RID: 75
			// (get) Token: 0x06000336 RID: 822 RVA: 0x00008474 File Offset: 0x00006674
			public string Text
			{
				get
				{
					if (this.TextFormatted != null)
					{
						return this.TextFormatted.ToString();
					}
					return null;
				}
			}

			// Token: 0x06000337 RID: 823 RVA: 0x0000848B File Offset: 0x0000668B
			private static Delegate GetSelectHandler()
			{
				if (ActionBar.Tab.cb_select == null)
				{
					ActionBar.Tab.cb_select = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(ActionBar.Tab.n_Select));
				}
				return ActionBar.Tab.cb_select;
			}

			// Token: 0x06000338 RID: 824 RVA: 0x000084AF File Offset: 0x000066AF
			private static void n_Select(IntPtr jnienv, IntPtr native__this)
			{
				Java.Lang.Object.GetObject<ActionBar.Tab>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Select();
			}

			// Token: 0x06000339 RID: 825
			[Register("select", "()V", "GetSelectHandler")]
			public abstract void Select();

			// Token: 0x0600033A RID: 826 RVA: 0x000084BE File Offset: 0x000066BE
			private static Delegate GetSetContentDescription_IHandler()
			{
				if (ActionBar.Tab.cb_setContentDescription_I == null)
				{
					ActionBar.Tab.cb_setContentDescription_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_L(ActionBar.Tab.n_SetContentDescription_I));
				}
				return ActionBar.Tab.cb_setContentDescription_I;
			}

			// Token: 0x0600033B RID: 827 RVA: 0x000084E2 File Offset: 0x000066E2
			private static IntPtr n_SetContentDescription_I(IntPtr jnienv, IntPtr native__this, int resId)
			{
				return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<ActionBar.Tab>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SetContentDescription(resId));
			}

			// Token: 0x0600033C RID: 828
			[Register("setContentDescription", "(I)Landroidx/appcompat/app/ActionBar$Tab;", "GetSetContentDescription_IHandler")]
			public abstract ActionBar.Tab SetContentDescription(int resId);

			// Token: 0x0600033D RID: 829 RVA: 0x000084F7 File Offset: 0x000066F7
			private static Delegate GetSetContentDescription_Ljava_lang_CharSequence_Handler()
			{
				if (ActionBar.Tab.cb_setContentDescription_Ljava_lang_CharSequence_ == null)
				{
					ActionBar.Tab.cb_setContentDescription_Ljava_lang_CharSequence_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(ActionBar.Tab.n_SetContentDescription_Ljava_lang_CharSequence_));
				}
				return ActionBar.Tab.cb_setContentDescription_Ljava_lang_CharSequence_;
			}

			// Token: 0x0600033E RID: 830 RVA: 0x0000851C File Offset: 0x0000671C
			private static IntPtr n_SetContentDescription_Ljava_lang_CharSequence_(IntPtr jnienv, IntPtr native__this, IntPtr native_contentDesc)
			{
				ActionBar.Tab @object = Java.Lang.Object.GetObject<ActionBar.Tab>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				ICharSequence object2 = Java.Lang.Object.GetObject<ICharSequence>(native_contentDesc, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle(@object.SetContentDescription(object2));
			}

			// Token: 0x0600033F RID: 831
			[Register("setContentDescription", "(Ljava/lang/CharSequence;)Landroidx/appcompat/app/ActionBar$Tab;", "GetSetContentDescription_Ljava_lang_CharSequence_Handler")]
			public abstract ActionBar.Tab SetContentDescription(ICharSequence contentDesc);

			// Token: 0x06000340 RID: 832 RVA: 0x00008544 File Offset: 0x00006744
			public ActionBar.Tab SetContentDescription(string contentDesc)
			{
				Java.Lang.String @string = (contentDesc == null) ? null : new Java.Lang.String(contentDesc);
				ActionBar.Tab result = this.SetContentDescription(@string);
				if (@string != null)
				{
					@string.Dispose();
				}
				return result;
			}

			// Token: 0x06000341 RID: 833 RVA: 0x0000856E File Offset: 0x0000676E
			private static Delegate GetSetCustomView_Landroid_view_View_Handler()
			{
				if (ActionBar.Tab.cb_setCustomView_Landroid_view_View_ == null)
				{
					ActionBar.Tab.cb_setCustomView_Landroid_view_View_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(ActionBar.Tab.n_SetCustomView_Landroid_view_View_));
				}
				return ActionBar.Tab.cb_setCustomView_Landroid_view_View_;
			}

			// Token: 0x06000342 RID: 834 RVA: 0x00008594 File Offset: 0x00006794
			private static IntPtr n_SetCustomView_Landroid_view_View_(IntPtr jnienv, IntPtr native__this, IntPtr native_view)
			{
				ActionBar.Tab @object = Java.Lang.Object.GetObject<ActionBar.Tab>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				View object2 = Java.Lang.Object.GetObject<View>(native_view, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle(@object.SetCustomView(object2));
			}

			// Token: 0x06000343 RID: 835
			[Register("setCustomView", "(Landroid/view/View;)Landroidx/appcompat/app/ActionBar$Tab;", "GetSetCustomView_Landroid_view_View_Handler")]
			public abstract ActionBar.Tab SetCustomView(View view);

			// Token: 0x06000344 RID: 836 RVA: 0x000085BC File Offset: 0x000067BC
			private static Delegate GetSetCustomView_IHandler()
			{
				if (ActionBar.Tab.cb_setCustomView_I == null)
				{
					ActionBar.Tab.cb_setCustomView_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_L(ActionBar.Tab.n_SetCustomView_I));
				}
				return ActionBar.Tab.cb_setCustomView_I;
			}

			// Token: 0x06000345 RID: 837 RVA: 0x000085E0 File Offset: 0x000067E0
			private static IntPtr n_SetCustomView_I(IntPtr jnienv, IntPtr native__this, int layoutResId)
			{
				return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<ActionBar.Tab>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SetCustomView(layoutResId));
			}

			// Token: 0x06000346 RID: 838
			[Register("setCustomView", "(I)Landroidx/appcompat/app/ActionBar$Tab;", "GetSetCustomView_IHandler")]
			public abstract ActionBar.Tab SetCustomView(int layoutResId);

			// Token: 0x06000347 RID: 839 RVA: 0x000085F5 File Offset: 0x000067F5
			private static Delegate GetSetIcon_Landroid_graphics_drawable_Drawable_Handler()
			{
				if (ActionBar.Tab.cb_setIcon_Landroid_graphics_drawable_Drawable_ == null)
				{
					ActionBar.Tab.cb_setIcon_Landroid_graphics_drawable_Drawable_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(ActionBar.Tab.n_SetIcon_Landroid_graphics_drawable_Drawable_));
				}
				return ActionBar.Tab.cb_setIcon_Landroid_graphics_drawable_Drawable_;
			}

			// Token: 0x06000348 RID: 840 RVA: 0x0000861C File Offset: 0x0000681C
			private static IntPtr n_SetIcon_Landroid_graphics_drawable_Drawable_(IntPtr jnienv, IntPtr native__this, IntPtr native_icon)
			{
				ActionBar.Tab @object = Java.Lang.Object.GetObject<ActionBar.Tab>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				Drawable object2 = Java.Lang.Object.GetObject<Drawable>(native_icon, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle(@object.SetIcon(object2));
			}

			// Token: 0x06000349 RID: 841
			[Register("setIcon", "(Landroid/graphics/drawable/Drawable;)Landroidx/appcompat/app/ActionBar$Tab;", "GetSetIcon_Landroid_graphics_drawable_Drawable_Handler")]
			public abstract ActionBar.Tab SetIcon(Drawable icon);

			// Token: 0x0600034A RID: 842 RVA: 0x00008644 File Offset: 0x00006844
			private static Delegate GetSetIcon_IHandler()
			{
				if (ActionBar.Tab.cb_setIcon_I == null)
				{
					ActionBar.Tab.cb_setIcon_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_L(ActionBar.Tab.n_SetIcon_I));
				}
				return ActionBar.Tab.cb_setIcon_I;
			}

			// Token: 0x0600034B RID: 843 RVA: 0x00008668 File Offset: 0x00006868
			private static IntPtr n_SetIcon_I(IntPtr jnienv, IntPtr native__this, int resId)
			{
				return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<ActionBar.Tab>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SetIcon(resId));
			}

			// Token: 0x0600034C RID: 844
			[Register("setIcon", "(I)Landroidx/appcompat/app/ActionBar$Tab;", "GetSetIcon_IHandler")]
			public abstract ActionBar.Tab SetIcon(int resId);

			// Token: 0x0600034D RID: 845 RVA: 0x0000867D File Offset: 0x0000687D
			private static Delegate GetSetTabListener_Landroidx_appcompat_app_ActionBar_TabListener_Handler()
			{
				if (ActionBar.Tab.cb_setTabListener_Landroidx_appcompat_app_ActionBar_TabListener_ == null)
				{
					ActionBar.Tab.cb_setTabListener_Landroidx_appcompat_app_ActionBar_TabListener_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(ActionBar.Tab.n_SetTabListener_Landroidx_appcompat_app_ActionBar_TabListener_));
				}
				return ActionBar.Tab.cb_setTabListener_Landroidx_appcompat_app_ActionBar_TabListener_;
			}

			// Token: 0x0600034E RID: 846 RVA: 0x000086A4 File Offset: 0x000068A4
			private static IntPtr n_SetTabListener_Landroidx_appcompat_app_ActionBar_TabListener_(IntPtr jnienv, IntPtr native__this, IntPtr native_listener)
			{
				ActionBar.Tab @object = Java.Lang.Object.GetObject<ActionBar.Tab>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				ActionBar.ITabListener object2 = Java.Lang.Object.GetObject<ActionBar.ITabListener>(native_listener, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle(@object.SetTabListener(object2));
			}

			// Token: 0x0600034F RID: 847
			[Register("setTabListener", "(Landroidx/appcompat/app/ActionBar$TabListener;)Landroidx/appcompat/app/ActionBar$Tab;", "GetSetTabListener_Landroidx_appcompat_app_ActionBar_TabListener_Handler")]
			public abstract ActionBar.Tab SetTabListener(ActionBar.ITabListener listener);

			// Token: 0x06000350 RID: 848 RVA: 0x000086CC File Offset: 0x000068CC
			private static Delegate GetSetTag_Ljava_lang_Object_Handler()
			{
				if (ActionBar.Tab.cb_setTag_Ljava_lang_Object_ == null)
				{
					ActionBar.Tab.cb_setTag_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(ActionBar.Tab.n_SetTag_Ljava_lang_Object_));
				}
				return ActionBar.Tab.cb_setTag_Ljava_lang_Object_;
			}

			// Token: 0x06000351 RID: 849 RVA: 0x000086F0 File Offset: 0x000068F0
			private static IntPtr n_SetTag_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_obj)
			{
				ActionBar.Tab @object = Java.Lang.Object.GetObject<ActionBar.Tab>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_obj, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle(@object.SetTag(object2));
			}

			// Token: 0x06000352 RID: 850
			[Register("setTag", "(Ljava/lang/Object;)Landroidx/appcompat/app/ActionBar$Tab;", "GetSetTag_Ljava_lang_Object_Handler")]
			public abstract ActionBar.Tab SetTag(Java.Lang.Object obj);

			// Token: 0x06000353 RID: 851 RVA: 0x00008718 File Offset: 0x00006918
			private static Delegate GetSetText_IHandler()
			{
				if (ActionBar.Tab.cb_setText_I == null)
				{
					ActionBar.Tab.cb_setText_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_L(ActionBar.Tab.n_SetText_I));
				}
				return ActionBar.Tab.cb_setText_I;
			}

			// Token: 0x06000354 RID: 852 RVA: 0x0000873C File Offset: 0x0000693C
			private static IntPtr n_SetText_I(IntPtr jnienv, IntPtr native__this, int resId)
			{
				return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<ActionBar.Tab>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SetText(resId));
			}

			// Token: 0x06000355 RID: 853
			[Register("setText", "(I)Landroidx/appcompat/app/ActionBar$Tab;", "GetSetText_IHandler")]
			public abstract ActionBar.Tab SetText(int resId);

			// Token: 0x06000356 RID: 854 RVA: 0x00008751 File Offset: 0x00006951
			private static Delegate GetSetText_Ljava_lang_CharSequence_Handler()
			{
				if (ActionBar.Tab.cb_setText_Ljava_lang_CharSequence_ == null)
				{
					ActionBar.Tab.cb_setText_Ljava_lang_CharSequence_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(ActionBar.Tab.n_SetText_Ljava_lang_CharSequence_));
				}
				return ActionBar.Tab.cb_setText_Ljava_lang_CharSequence_;
			}

			// Token: 0x06000357 RID: 855 RVA: 0x00008778 File Offset: 0x00006978
			private static IntPtr n_SetText_Ljava_lang_CharSequence_(IntPtr jnienv, IntPtr native__this, IntPtr native_text)
			{
				ActionBar.Tab @object = Java.Lang.Object.GetObject<ActionBar.Tab>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				ICharSequence object2 = Java.Lang.Object.GetObject<ICharSequence>(native_text, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle(@object.SetText(object2));
			}

			// Token: 0x06000358 RID: 856
			[Register("setText", "(Ljava/lang/CharSequence;)Landroidx/appcompat/app/ActionBar$Tab;", "GetSetText_Ljava_lang_CharSequence_Handler")]
			public abstract ActionBar.Tab SetText(ICharSequence text);

			// Token: 0x06000359 RID: 857 RVA: 0x000087A0 File Offset: 0x000069A0
			public ActionBar.Tab SetText(string text)
			{
				Java.Lang.String @string = (text == null) ? null : new Java.Lang.String(text);
				ActionBar.Tab result = this.SetText(@string);
				if (@string != null)
				{
					@string.Dispose();
				}
				return result;
			}

			// Token: 0x040000AD RID: 173
			private static readonly JniPeerMembers _members = new XAPeerMembers("androidx/appcompat/app/ActionBar$Tab", typeof(ActionBar.Tab));

			// Token: 0x040000AE RID: 174
			private static Delegate cb_getContentDescription;

			// Token: 0x040000AF RID: 175
			private static Delegate cb_getCustomView;

			// Token: 0x040000B0 RID: 176
			private static Delegate cb_getIcon;

			// Token: 0x040000B1 RID: 177
			private static Delegate cb_getPosition;

			// Token: 0x040000B2 RID: 178
			private static Delegate cb_getTag;

			// Token: 0x040000B3 RID: 179
			private static Delegate cb_getText;

			// Token: 0x040000B4 RID: 180
			private static Delegate cb_select;

			// Token: 0x040000B5 RID: 181
			private static Delegate cb_setContentDescription_I;

			// Token: 0x040000B6 RID: 182
			private static Delegate cb_setContentDescription_Ljava_lang_CharSequence_;

			// Token: 0x040000B7 RID: 183
			private static Delegate cb_setCustomView_Landroid_view_View_;

			// Token: 0x040000B8 RID: 184
			private static Delegate cb_setCustomView_I;

			// Token: 0x040000B9 RID: 185
			private static Delegate cb_setIcon_Landroid_graphics_drawable_Drawable_;

			// Token: 0x040000BA RID: 186
			private static Delegate cb_setIcon_I;

			// Token: 0x040000BB RID: 187
			private static Delegate cb_setTabListener_Landroidx_appcompat_app_ActionBar_TabListener_;

			// Token: 0x040000BC RID: 188
			private static Delegate cb_setTag_Ljava_lang_Object_;

			// Token: 0x040000BD RID: 189
			private static Delegate cb_setText_I;

			// Token: 0x040000BE RID: 190
			private static Delegate cb_setText_Ljava_lang_CharSequence_;
		}

		// Token: 0x02000048 RID: 72
		[Register("androidx/appcompat/app/ActionBar$Tab", DoNotGenerateAcw = true)]
		internal class TabInvoker : ActionBar.Tab
		{
			// Token: 0x0600035B RID: 859 RVA: 0x000087E5 File Offset: 0x000069E5
			public TabInvoker(IntPtr handle, JniHandleOwnership transfer) : base(handle, transfer)
			{
			}

			// Token: 0x1700004C RID: 76
			// (get) Token: 0x0600035C RID: 860 RVA: 0x000087EF File Offset: 0x000069EF
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return ActionBar.TabInvoker._members;
				}
			}

			// Token: 0x1700004D RID: 77
			// (get) Token: 0x0600035D RID: 861 RVA: 0x000087F6 File Offset: 0x000069F6
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return ActionBar.TabInvoker._members.ManagedPeerType;
				}
			}

			// Token: 0x1700004E RID: 78
			// (get) Token: 0x0600035E RID: 862 RVA: 0x00008804 File Offset: 0x00006A04
			public override ICharSequence ContentDescriptionFormatted
			{
				[Register("getContentDescription", "()Ljava/lang/CharSequence;", "GetGetContentDescriptionHandler")]
				get
				{
					return Java.Lang.Object.GetObject<ICharSequence>(ActionBar.TabInvoker._members.InstanceMethods.InvokeAbstractObjectMethod("getContentDescription.()Ljava/lang/CharSequence;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
				}
			}

			// Token: 0x1700004F RID: 79
			// (get) Token: 0x0600035F RID: 863 RVA: 0x00008838 File Offset: 0x00006A38
			public override View CustomView
			{
				[Register("getCustomView", "()Landroid/view/View;", "GetGetCustomViewHandler")]
				get
				{
					return Java.Lang.Object.GetObject<View>(ActionBar.TabInvoker._members.InstanceMethods.InvokeAbstractObjectMethod("getCustomView.()Landroid/view/View;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
				}
			}

			// Token: 0x17000050 RID: 80
			// (get) Token: 0x06000360 RID: 864 RVA: 0x0000886C File Offset: 0x00006A6C
			public override Drawable Icon
			{
				[Register("getIcon", "()Landroid/graphics/drawable/Drawable;", "GetGetIconHandler")]
				get
				{
					return Java.Lang.Object.GetObject<Drawable>(ActionBar.TabInvoker._members.InstanceMethods.InvokeAbstractObjectMethod("getIcon.()Landroid/graphics/drawable/Drawable;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
				}
			}

			// Token: 0x17000051 RID: 81
			// (get) Token: 0x06000361 RID: 865 RVA: 0x0000889E File Offset: 0x00006A9E
			public override int Position
			{
				[Register("getPosition", "()I", "GetGetPositionHandler")]
				get
				{
					return ActionBar.TabInvoker._members.InstanceMethods.InvokeAbstractInt32Method("getPosition.()I", this, null);
				}
			}

			// Token: 0x17000052 RID: 82
			// (get) Token: 0x06000362 RID: 866 RVA: 0x000088B8 File Offset: 0x00006AB8
			public override Java.Lang.Object Tag
			{
				[Register("getTag", "()Ljava/lang/Object;", "GetGetTagHandler")]
				get
				{
					return Java.Lang.Object.GetObject<Java.Lang.Object>(ActionBar.TabInvoker._members.InstanceMethods.InvokeAbstractObjectMethod("getTag.()Ljava/lang/Object;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
				}
			}

			// Token: 0x17000053 RID: 83
			// (get) Token: 0x06000363 RID: 867 RVA: 0x000088EC File Offset: 0x00006AEC
			public override ICharSequence TextFormatted
			{
				[Register("getText", "()Ljava/lang/CharSequence;", "GetGetTextHandler")]
				get
				{
					return Java.Lang.Object.GetObject<ICharSequence>(ActionBar.TabInvoker._members.InstanceMethods.InvokeAbstractObjectMethod("getText.()Ljava/lang/CharSequence;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
				}
			}

			// Token: 0x06000364 RID: 868 RVA: 0x0000891E File Offset: 0x00006B1E
			[Register("select", "()V", "GetSelectHandler")]
			public override void Select()
			{
				ActionBar.TabInvoker._members.InstanceMethods.InvokeAbstractVoidMethod("select.()V", this, null);
			}

			// Token: 0x06000365 RID: 869 RVA: 0x00008938 File Offset: 0x00006B38
			[Register("setContentDescription", "(I)Landroidx/appcompat/app/ActionBar$Tab;", "GetSetContentDescription_IHandler")]
			public unsafe override ActionBar.Tab SetContentDescription(int resId)
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(resId);
				return Java.Lang.Object.GetObject<ActionBar.Tab>(ActionBar.TabInvoker._members.InstanceMethods.InvokeAbstractObjectMethod("setContentDescription.(I)Landroidx/appcompat/app/ActionBar$Tab;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}

			// Token: 0x06000366 RID: 870 RVA: 0x00008984 File Offset: 0x00006B84
			[Register("setContentDescription", "(Ljava/lang/CharSequence;)Landroidx/appcompat/app/ActionBar$Tab;", "GetSetContentDescription_Ljava_lang_CharSequence_Handler")]
			public unsafe override ActionBar.Tab SetContentDescription(ICharSequence contentDesc)
			{
				IntPtr intPtr = CharSequence.ToLocalJniHandle(contentDesc);
				ActionBar.Tab @object;
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue(intPtr);
					@object = Java.Lang.Object.GetObject<ActionBar.Tab>(ActionBar.TabInvoker._members.InstanceMethods.InvokeAbstractObjectMethod("setContentDescription.(Ljava/lang/CharSequence;)Landroidx/appcompat/app/ActionBar$Tab;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
				}
				finally
				{
					JNIEnv.DeleteLocalRef(intPtr);
					GC.KeepAlive(contentDesc);
				}
				return @object;
			}

			// Token: 0x06000367 RID: 871 RVA: 0x000089F8 File Offset: 0x00006BF8
			[Register("setCustomView", "(Landroid/view/View;)Landroidx/appcompat/app/ActionBar$Tab;", "GetSetCustomView_Landroid_view_View_Handler")]
			public unsafe override ActionBar.Tab SetCustomView(View view)
			{
				ActionBar.Tab @object;
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((view == null) ? IntPtr.Zero : view.Handle);
					@object = Java.Lang.Object.GetObject<ActionBar.Tab>(ActionBar.TabInvoker._members.InstanceMethods.InvokeAbstractObjectMethod("setCustomView.(Landroid/view/View;)Landroidx/appcompat/app/ActionBar$Tab;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
				}
				finally
				{
					GC.KeepAlive(view);
				}
				return @object;
			}

			// Token: 0x06000368 RID: 872 RVA: 0x00008A6C File Offset: 0x00006C6C
			[Register("setCustomView", "(I)Landroidx/appcompat/app/ActionBar$Tab;", "GetSetCustomView_IHandler")]
			public unsafe override ActionBar.Tab SetCustomView(int layoutResId)
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(layoutResId);
				return Java.Lang.Object.GetObject<ActionBar.Tab>(ActionBar.TabInvoker._members.InstanceMethods.InvokeAbstractObjectMethod("setCustomView.(I)Landroidx/appcompat/app/ActionBar$Tab;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}

			// Token: 0x06000369 RID: 873 RVA: 0x00008AB8 File Offset: 0x00006CB8
			[Register("setIcon", "(Landroid/graphics/drawable/Drawable;)Landroidx/appcompat/app/ActionBar$Tab;", "GetSetIcon_Landroid_graphics_drawable_Drawable_Handler")]
			public unsafe override ActionBar.Tab SetIcon(Drawable icon)
			{
				ActionBar.Tab @object;
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((icon == null) ? IntPtr.Zero : icon.Handle);
					@object = Java.Lang.Object.GetObject<ActionBar.Tab>(ActionBar.TabInvoker._members.InstanceMethods.InvokeAbstractObjectMethod("setIcon.(Landroid/graphics/drawable/Drawable;)Landroidx/appcompat/app/ActionBar$Tab;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
				}
				finally
				{
					GC.KeepAlive(icon);
				}
				return @object;
			}

			// Token: 0x0600036A RID: 874 RVA: 0x00008B2C File Offset: 0x00006D2C
			[Register("setIcon", "(I)Landroidx/appcompat/app/ActionBar$Tab;", "GetSetIcon_IHandler")]
			public unsafe override ActionBar.Tab SetIcon(int resId)
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(resId);
				return Java.Lang.Object.GetObject<ActionBar.Tab>(ActionBar.TabInvoker._members.InstanceMethods.InvokeAbstractObjectMethod("setIcon.(I)Landroidx/appcompat/app/ActionBar$Tab;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}

			// Token: 0x0600036B RID: 875 RVA: 0x00008B78 File Offset: 0x00006D78
			[Register("setTabListener", "(Landroidx/appcompat/app/ActionBar$TabListener;)Landroidx/appcompat/app/ActionBar$Tab;", "GetSetTabListener_Landroidx_appcompat_app_ActionBar_TabListener_Handler")]
			public unsafe override ActionBar.Tab SetTabListener(ActionBar.ITabListener listener)
			{
				ActionBar.Tab @object;
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((listener == null) ? IntPtr.Zero : ((Java.Lang.Object)listener).Handle);
					@object = Java.Lang.Object.GetObject<ActionBar.Tab>(ActionBar.TabInvoker._members.InstanceMethods.InvokeAbstractObjectMethod("setTabListener.(Landroidx/appcompat/app/ActionBar$TabListener;)Landroidx/appcompat/app/ActionBar$Tab;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
				}
				finally
				{
					GC.KeepAlive(listener);
				}
				return @object;
			}

			// Token: 0x0600036C RID: 876 RVA: 0x00008BF0 File Offset: 0x00006DF0
			[Register("setTag", "(Ljava/lang/Object;)Landroidx/appcompat/app/ActionBar$Tab;", "GetSetTag_Ljava_lang_Object_Handler")]
			public unsafe override ActionBar.Tab SetTag(Java.Lang.Object obj)
			{
				ActionBar.Tab @object;
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((obj == null) ? IntPtr.Zero : obj.Handle);
					@object = Java.Lang.Object.GetObject<ActionBar.Tab>(ActionBar.TabInvoker._members.InstanceMethods.InvokeAbstractObjectMethod("setTag.(Ljava/lang/Object;)Landroidx/appcompat/app/ActionBar$Tab;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
				}
				finally
				{
					GC.KeepAlive(obj);
				}
				return @object;
			}

			// Token: 0x0600036D RID: 877 RVA: 0x00008C64 File Offset: 0x00006E64
			[Register("setText", "(I)Landroidx/appcompat/app/ActionBar$Tab;", "GetSetText_IHandler")]
			public unsafe override ActionBar.Tab SetText(int resId)
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(resId);
				return Java.Lang.Object.GetObject<ActionBar.Tab>(ActionBar.TabInvoker._members.InstanceMethods.InvokeAbstractObjectMethod("setText.(I)Landroidx/appcompat/app/ActionBar$Tab;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}

			// Token: 0x0600036E RID: 878 RVA: 0x00008CB0 File Offset: 0x00006EB0
			[Register("setText", "(Ljava/lang/CharSequence;)Landroidx/appcompat/app/ActionBar$Tab;", "GetSetText_Ljava_lang_CharSequence_Handler")]
			public unsafe override ActionBar.Tab SetText(ICharSequence text)
			{
				IntPtr intPtr = CharSequence.ToLocalJniHandle(text);
				ActionBar.Tab @object;
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue(intPtr);
					@object = Java.Lang.Object.GetObject<ActionBar.Tab>(ActionBar.TabInvoker._members.InstanceMethods.InvokeAbstractObjectMethod("setText.(Ljava/lang/CharSequence;)Landroidx/appcompat/app/ActionBar$Tab;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
				}
				finally
				{
					JNIEnv.DeleteLocalRef(intPtr);
					GC.KeepAlive(text);
				}
				return @object;
			}

			// Token: 0x040000BF RID: 191
			private static readonly JniPeerMembers _members = new XAPeerMembers("androidx/appcompat/app/ActionBar$Tab", typeof(ActionBar.TabInvoker));
		}

		// Token: 0x02000049 RID: 73
		[Register("androidx/appcompat/app/ActionBar$TabListener", "", "AndroidX.AppCompat.App.ActionBar/ITabListenerInvoker")]
		public interface ITabListener : IJavaObject, IDisposable, IJavaPeerable
		{
			// Token: 0x06000370 RID: 880
			[Register("onTabReselected", "(Landroidx/appcompat/app/ActionBar$Tab;Landroidx/fragment/app/FragmentTransaction;)V", "GetOnTabReselected_Landroidx_appcompat_app_ActionBar_Tab_Landroidx_fragment_app_FragmentTransaction_Handler:AndroidX.AppCompat.App.ActionBar/ITabListenerInvoker, Xamarin.AndroidX.AppCompat")]
			void OnTabReselected(ActionBar.Tab tab, FragmentTransaction ft);

			// Token: 0x06000371 RID: 881
			[Register("onTabSelected", "(Landroidx/appcompat/app/ActionBar$Tab;Landroidx/fragment/app/FragmentTransaction;)V", "GetOnTabSelected_Landroidx_appcompat_app_ActionBar_Tab_Landroidx_fragment_app_FragmentTransaction_Handler:AndroidX.AppCompat.App.ActionBar/ITabListenerInvoker, Xamarin.AndroidX.AppCompat")]
			void OnTabSelected(ActionBar.Tab tab, FragmentTransaction ft);

			// Token: 0x06000372 RID: 882
			[Register("onTabUnselected", "(Landroidx/appcompat/app/ActionBar$Tab;Landroidx/fragment/app/FragmentTransaction;)V", "GetOnTabUnselected_Landroidx_appcompat_app_ActionBar_Tab_Landroidx_fragment_app_FragmentTransaction_Handler:AndroidX.AppCompat.App.ActionBar/ITabListenerInvoker, Xamarin.AndroidX.AppCompat")]
			void OnTabUnselected(ActionBar.Tab tab, FragmentTransaction ft);
		}

		// Token: 0x0200004A RID: 74
		[Register("androidx/appcompat/app/ActionBar$TabListener", DoNotGenerateAcw = true)]
		internal class ITabListenerInvoker : Java.Lang.Object, ActionBar.ITabListener, IJavaObject, IDisposable, IJavaPeerable
		{
			// Token: 0x17000054 RID: 84
			// (get) Token: 0x06000373 RID: 883 RVA: 0x00008D40 File Offset: 0x00006F40
			private static IntPtr java_class_ref
			{
				get
				{
					return ActionBar.ITabListenerInvoker._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x17000055 RID: 85
			// (get) Token: 0x06000374 RID: 884 RVA: 0x00008D64 File Offset: 0x00006F64
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return ActionBar.ITabListenerInvoker._members;
				}
			}

			// Token: 0x17000056 RID: 86
			// (get) Token: 0x06000375 RID: 885 RVA: 0x00008D6B File Offset: 0x00006F6B
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return this.class_ref;
				}
			}

			// Token: 0x17000057 RID: 87
			// (get) Token: 0x06000376 RID: 886 RVA: 0x00008D73 File Offset: 0x00006F73
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return ActionBar.ITabListenerInvoker._members.ManagedPeerType;
				}
			}

			// Token: 0x06000377 RID: 887 RVA: 0x00008D7F File Offset: 0x00006F7F
			public static ActionBar.ITabListener GetObject(IntPtr handle, JniHandleOwnership transfer)
			{
				return Java.Lang.Object.GetObject<ActionBar.ITabListener>(handle, transfer);
			}

			// Token: 0x06000378 RID: 888 RVA: 0x00008D88 File Offset: 0x00006F88
			private static IntPtr Validate(IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf(handle, ActionBar.ITabListenerInvoker.java_class_ref))
				{
					throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'androidx.appcompat.app.ActionBar.TabListener'.");
				}
				return handle;
			}

			// Token: 0x06000379 RID: 889 RVA: 0x00008DB3 File Offset: 0x00006FB3
			protected override void Dispose(bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
				{
					JNIEnv.DeleteGlobalRef(this.class_ref);
				}
				this.class_ref = IntPtr.Zero;
				base.Dispose(disposing);
			}

			// Token: 0x0600037A RID: 890 RVA: 0x00008DE4 File Offset: 0x00006FE4
			public ITabListenerInvoker(IntPtr handle, JniHandleOwnership transfer) : base(ActionBar.ITabListenerInvoker.Validate(handle), transfer)
			{
				IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
				this.class_ref = JNIEnv.NewGlobalRef(objectClass);
				JNIEnv.DeleteLocalRef(objectClass);
			}

			// Token: 0x0600037B RID: 891 RVA: 0x00008E1C File Offset: 0x0000701C
			private static Delegate GetOnTabReselected_Landroidx_appcompat_app_ActionBar_Tab_Landroidx_fragment_app_FragmentTransaction_Handler()
			{
				if (ActionBar.ITabListenerInvoker.cb_onTabReselected_Landroidx_appcompat_app_ActionBar_Tab_Landroidx_fragment_app_FragmentTransaction_ == null)
				{
					ActionBar.ITabListenerInvoker.cb_onTabReselected_Landroidx_appcompat_app_ActionBar_Tab_Landroidx_fragment_app_FragmentTransaction_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_V(ActionBar.ITabListenerInvoker.n_OnTabReselected_Landroidx_appcompat_app_ActionBar_Tab_Landroidx_fragment_app_FragmentTransaction_));
				}
				return ActionBar.ITabListenerInvoker.cb_onTabReselected_Landroidx_appcompat_app_ActionBar_Tab_Landroidx_fragment_app_FragmentTransaction_;
			}

			// Token: 0x0600037C RID: 892 RVA: 0x00008E40 File Offset: 0x00007040
			private static void n_OnTabReselected_Landroidx_appcompat_app_ActionBar_Tab_Landroidx_fragment_app_FragmentTransaction_(IntPtr jnienv, IntPtr native__this, IntPtr native_tab, IntPtr native_ft)
			{
				ActionBar.ITabListener @object = Java.Lang.Object.GetObject<ActionBar.ITabListener>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				ActionBar.Tab object2 = Java.Lang.Object.GetObject<ActionBar.Tab>(native_tab, JniHandleOwnership.DoNotTransfer);
				FragmentTransaction object3 = Java.Lang.Object.GetObject<FragmentTransaction>(native_ft, JniHandleOwnership.DoNotTransfer);
				@object.OnTabReselected(object2, object3);
			}

			// Token: 0x0600037D RID: 893 RVA: 0x00008E6C File Offset: 0x0000706C
			public unsafe void OnTabReselected(ActionBar.Tab tab, FragmentTransaction ft)
			{
				if (this.id_onTabReselected_Landroidx_appcompat_app_ActionBar_Tab_Landroidx_fragment_app_FragmentTransaction_ == IntPtr.Zero)
				{
					this.id_onTabReselected_Landroidx_appcompat_app_ActionBar_Tab_Landroidx_fragment_app_FragmentTransaction_ = JNIEnv.GetMethodID(this.class_ref, "onTabReselected", "(Landroidx/appcompat/app/ActionBar$Tab;Landroidx/fragment/app/FragmentTransaction;)V");
				}
				JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JValue))];
				*ptr = new JValue((tab == null) ? IntPtr.Zero : tab.Handle);
				ptr[1] = new JValue((ft == null) ? IntPtr.Zero : ft.Handle);
				JNIEnv.CallVoidMethod(base.Handle, this.id_onTabReselected_Landroidx_appcompat_app_ActionBar_Tab_Landroidx_fragment_app_FragmentTransaction_, ptr);
			}

			// Token: 0x0600037E RID: 894 RVA: 0x00008F01 File Offset: 0x00007101
			private static Delegate GetOnTabSelected_Landroidx_appcompat_app_ActionBar_Tab_Landroidx_fragment_app_FragmentTransaction_Handler()
			{
				if (ActionBar.ITabListenerInvoker.cb_onTabSelected_Landroidx_appcompat_app_ActionBar_Tab_Landroidx_fragment_app_FragmentTransaction_ == null)
				{
					ActionBar.ITabListenerInvoker.cb_onTabSelected_Landroidx_appcompat_app_ActionBar_Tab_Landroidx_fragment_app_FragmentTransaction_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_V(ActionBar.ITabListenerInvoker.n_OnTabSelected_Landroidx_appcompat_app_ActionBar_Tab_Landroidx_fragment_app_FragmentTransaction_));
				}
				return ActionBar.ITabListenerInvoker.cb_onTabSelected_Landroidx_appcompat_app_ActionBar_Tab_Landroidx_fragment_app_FragmentTransaction_;
			}

			// Token: 0x0600037F RID: 895 RVA: 0x00008F28 File Offset: 0x00007128
			private static void n_OnTabSelected_Landroidx_appcompat_app_ActionBar_Tab_Landroidx_fragment_app_FragmentTransaction_(IntPtr jnienv, IntPtr native__this, IntPtr native_tab, IntPtr native_ft)
			{
				ActionBar.ITabListener @object = Java.Lang.Object.GetObject<ActionBar.ITabListener>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				ActionBar.Tab object2 = Java.Lang.Object.GetObject<ActionBar.Tab>(native_tab, JniHandleOwnership.DoNotTransfer);
				FragmentTransaction object3 = Java.Lang.Object.GetObject<FragmentTransaction>(native_ft, JniHandleOwnership.DoNotTransfer);
				@object.OnTabSelected(object2, object3);
			}

			// Token: 0x06000380 RID: 896 RVA: 0x00008F54 File Offset: 0x00007154
			public unsafe void OnTabSelected(ActionBar.Tab tab, FragmentTransaction ft)
			{
				if (this.id_onTabSelected_Landroidx_appcompat_app_ActionBar_Tab_Landroidx_fragment_app_FragmentTransaction_ == IntPtr.Zero)
				{
					this.id_onTabSelected_Landroidx_appcompat_app_ActionBar_Tab_Landroidx_fragment_app_FragmentTransaction_ = JNIEnv.GetMethodID(this.class_ref, "onTabSelected", "(Landroidx/appcompat/app/ActionBar$Tab;Landroidx/fragment/app/FragmentTransaction;)V");
				}
				JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JValue))];
				*ptr = new JValue((tab == null) ? IntPtr.Zero : tab.Handle);
				ptr[1] = new JValue((ft == null) ? IntPtr.Zero : ft.Handle);
				JNIEnv.CallVoidMethod(base.Handle, this.id_onTabSelected_Landroidx_appcompat_app_ActionBar_Tab_Landroidx_fragment_app_FragmentTransaction_, ptr);
			}

			// Token: 0x06000381 RID: 897 RVA: 0x00008FE9 File Offset: 0x000071E9
			private static Delegate GetOnTabUnselected_Landroidx_appcompat_app_ActionBar_Tab_Landroidx_fragment_app_FragmentTransaction_Handler()
			{
				if (ActionBar.ITabListenerInvoker.cb_onTabUnselected_Landroidx_appcompat_app_ActionBar_Tab_Landroidx_fragment_app_FragmentTransaction_ == null)
				{
					ActionBar.ITabListenerInvoker.cb_onTabUnselected_Landroidx_appcompat_app_ActionBar_Tab_Landroidx_fragment_app_FragmentTransaction_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_V(ActionBar.ITabListenerInvoker.n_OnTabUnselected_Landroidx_appcompat_app_ActionBar_Tab_Landroidx_fragment_app_FragmentTransaction_));
				}
				return ActionBar.ITabListenerInvoker.cb_onTabUnselected_Landroidx_appcompat_app_ActionBar_Tab_Landroidx_fragment_app_FragmentTransaction_;
			}

			// Token: 0x06000382 RID: 898 RVA: 0x00009010 File Offset: 0x00007210
			private static void n_OnTabUnselected_Landroidx_appcompat_app_ActionBar_Tab_Landroidx_fragment_app_FragmentTransaction_(IntPtr jnienv, IntPtr native__this, IntPtr native_tab, IntPtr native_ft)
			{
				ActionBar.ITabListener @object = Java.Lang.Object.GetObject<ActionBar.ITabListener>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				ActionBar.Tab object2 = Java.Lang.Object.GetObject<ActionBar.Tab>(native_tab, JniHandleOwnership.DoNotTransfer);
				FragmentTransaction object3 = Java.Lang.Object.GetObject<FragmentTransaction>(native_ft, JniHandleOwnership.DoNotTransfer);
				@object.OnTabUnselected(object2, object3);
			}

			// Token: 0x06000383 RID: 899 RVA: 0x0000903C File Offset: 0x0000723C
			public unsafe void OnTabUnselected(ActionBar.Tab tab, FragmentTransaction ft)
			{
				if (this.id_onTabUnselected_Landroidx_appcompat_app_ActionBar_Tab_Landroidx_fragment_app_FragmentTransaction_ == IntPtr.Zero)
				{
					this.id_onTabUnselected_Landroidx_appcompat_app_ActionBar_Tab_Landroidx_fragment_app_FragmentTransaction_ = JNIEnv.GetMethodID(this.class_ref, "onTabUnselected", "(Landroidx/appcompat/app/ActionBar$Tab;Landroidx/fragment/app/FragmentTransaction;)V");
				}
				JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JValue))];
				*ptr = new JValue((tab == null) ? IntPtr.Zero : tab.Handle);
				ptr[1] = new JValue((ft == null) ? IntPtr.Zero : ft.Handle);
				JNIEnv.CallVoidMethod(base.Handle, this.id_onTabUnselected_Landroidx_appcompat_app_ActionBar_Tab_Landroidx_fragment_app_FragmentTransaction_, ptr);
			}

			// Token: 0x040000C0 RID: 192
			private static readonly JniPeerMembers _members = new XAPeerMembers("androidx/appcompat/app/ActionBar$TabListener", typeof(ActionBar.ITabListenerInvoker));

			// Token: 0x040000C1 RID: 193
			private IntPtr class_ref;

			// Token: 0x040000C2 RID: 194
			private static Delegate cb_onTabReselected_Landroidx_appcompat_app_ActionBar_Tab_Landroidx_fragment_app_FragmentTransaction_;

			// Token: 0x040000C3 RID: 195
			private IntPtr id_onTabReselected_Landroidx_appcompat_app_ActionBar_Tab_Landroidx_fragment_app_FragmentTransaction_;

			// Token: 0x040000C4 RID: 196
			private static Delegate cb_onTabSelected_Landroidx_appcompat_app_ActionBar_Tab_Landroidx_fragment_app_FragmentTransaction_;

			// Token: 0x040000C5 RID: 197
			private IntPtr id_onTabSelected_Landroidx_appcompat_app_ActionBar_Tab_Landroidx_fragment_app_FragmentTransaction_;

			// Token: 0x040000C6 RID: 198
			private static Delegate cb_onTabUnselected_Landroidx_appcompat_app_ActionBar_Tab_Landroidx_fragment_app_FragmentTransaction_;

			// Token: 0x040000C7 RID: 199
			private IntPtr id_onTabUnselected_Landroidx_appcompat_app_ActionBar_Tab_Landroidx_fragment_app_FragmentTransaction_;
		}

		// Token: 0x0200004B RID: 75
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040000C8 RID: 200
			public static Func<ActionBar.IOnMenuVisibilityListenerImplementor, bool> <0>____IsEmpty;
		}
	}
}
