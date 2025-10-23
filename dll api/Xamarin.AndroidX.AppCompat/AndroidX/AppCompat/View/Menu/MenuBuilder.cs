using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using Android.Content;
using Android.Graphics.Drawables;
using Android.OS;
using Android.Runtime;
using Android.Views;
using AndroidX.Core.Internal.View;
using Java.Interop;
using Java.Lang;

namespace AndroidX.AppCompat.View.Menu
{
	// Token: 0x0200008E RID: 142
	[Register("androidx/appcompat/view/menu/MenuBuilder", DoNotGenerateAcw = true)]
	public class MenuBuilder : Java.Lang.Object, ISupportMenu, IMenu, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x060009E7 RID: 2535 RVA: 0x00019919 File Offset: 0x00017B19
		public void SetGroupDividerEnabled(bool enabled)
		{
			this.GroupDividerEnabled = enabled;
		}

		// Token: 0x1700017E RID: 382
		// (get) Token: 0x060009E8 RID: 2536 RVA: 0x00019924 File Offset: 0x00017B24
		internal static IntPtr class_ref
		{
			get
			{
				return MenuBuilder._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700017F RID: 383
		// (get) Token: 0x060009E9 RID: 2537 RVA: 0x00019948 File Offset: 0x00017B48
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return MenuBuilder._members;
			}
		}

		// Token: 0x17000180 RID: 384
		// (get) Token: 0x060009EA RID: 2538 RVA: 0x00019950 File Offset: 0x00017B50
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return MenuBuilder._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000181 RID: 385
		// (get) Token: 0x060009EB RID: 2539 RVA: 0x00019974 File Offset: 0x00017B74
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return MenuBuilder._members.ManagedPeerType;
			}
		}

		// Token: 0x060009EC RID: 2540 RVA: 0x000039D4 File Offset: 0x00001BD4
		protected MenuBuilder(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x060009ED RID: 2541 RVA: 0x00019980 File Offset: 0x00017B80
		[Register(".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe MenuBuilder(Context context) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((context == null) ? IntPtr.Zero : context.Handle);
				base.SetHandle(MenuBuilder._members.InstanceMethods.StartCreateInstance("(Landroid/content/Context;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				MenuBuilder._members.InstanceMethods.FinishCreateInstance("(Landroid/content/Context;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(context);
			}
		}

		// Token: 0x060009EE RID: 2542 RVA: 0x00019A30 File Offset: 0x00017C30
		private static Delegate GetGetActionItemsHandler()
		{
			if (MenuBuilder.cb_getActionItems == null)
			{
				MenuBuilder.cb_getActionItems = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(MenuBuilder.n_GetActionItems));
			}
			return MenuBuilder.cb_getActionItems;
		}

		// Token: 0x060009EF RID: 2543 RVA: 0x00019A54 File Offset: 0x00017C54
		private static IntPtr n_GetActionItems(IntPtr jnienv, IntPtr native__this)
		{
			return JavaList<MenuItemImpl>.ToLocalJniHandle(Java.Lang.Object.GetObject<MenuBuilder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ActionItems);
		}

		// Token: 0x17000182 RID: 386
		// (get) Token: 0x060009F0 RID: 2544 RVA: 0x00019A68 File Offset: 0x00017C68
		public virtual IList<MenuItemImpl> ActionItems
		{
			[Register("getActionItems", "()Ljava/util/ArrayList;", "GetGetActionItemsHandler")]
			get
			{
				return JavaList<MenuItemImpl>.FromJniHandle(MenuBuilder._members.InstanceMethods.InvokeVirtualObjectMethod("getActionItems.()Ljava/util/ArrayList;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x060009F1 RID: 2545 RVA: 0x00019A9A File Offset: 0x00017C9A
		private static Delegate GetGetActionViewStatesKeyHandler()
		{
			if (MenuBuilder.cb_getActionViewStatesKey == null)
			{
				MenuBuilder.cb_getActionViewStatesKey = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(MenuBuilder.n_GetActionViewStatesKey));
			}
			return MenuBuilder.cb_getActionViewStatesKey;
		}

		// Token: 0x060009F2 RID: 2546 RVA: 0x00019ABE File Offset: 0x00017CBE
		private static IntPtr n_GetActionViewStatesKey(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<MenuBuilder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ActionViewStatesKey);
		}

		// Token: 0x17000183 RID: 387
		// (get) Token: 0x060009F3 RID: 2547 RVA: 0x00019AD4 File Offset: 0x00017CD4
		protected virtual string ActionViewStatesKey
		{
			[Register("getActionViewStatesKey", "()Ljava/lang/String;", "GetGetActionViewStatesKeyHandler")]
			get
			{
				return JNIEnv.GetString(MenuBuilder._members.InstanceMethods.InvokeVirtualObjectMethod("getActionViewStatesKey.()Ljava/lang/String;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x060009F4 RID: 2548 RVA: 0x00019B06 File Offset: 0x00017D06
		private static Delegate GetGetContextHandler()
		{
			if (MenuBuilder.cb_getContext == null)
			{
				MenuBuilder.cb_getContext = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(MenuBuilder.n_GetContext));
			}
			return MenuBuilder.cb_getContext;
		}

		// Token: 0x060009F5 RID: 2549 RVA: 0x00019B2A File Offset: 0x00017D2A
		private static IntPtr n_GetContext(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<MenuBuilder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Context);
		}

		// Token: 0x17000184 RID: 388
		// (get) Token: 0x060009F6 RID: 2550 RVA: 0x00019B40 File Offset: 0x00017D40
		public virtual Context Context
		{
			[Register("getContext", "()Landroid/content/Context;", "GetGetContextHandler")]
			get
			{
				return Java.Lang.Object.GetObject<Context>(MenuBuilder._members.InstanceMethods.InvokeVirtualObjectMethod("getContext.()Landroid/content/Context;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x060009F7 RID: 2551 RVA: 0x00019B72 File Offset: 0x00017D72
		private static Delegate GetGetExpandedItemHandler()
		{
			if (MenuBuilder.cb_getExpandedItem == null)
			{
				MenuBuilder.cb_getExpandedItem = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(MenuBuilder.n_GetExpandedItem));
			}
			return MenuBuilder.cb_getExpandedItem;
		}

		// Token: 0x060009F8 RID: 2552 RVA: 0x00019B96 File Offset: 0x00017D96
		private static IntPtr n_GetExpandedItem(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<MenuBuilder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ExpandedItem);
		}

		// Token: 0x17000185 RID: 389
		// (get) Token: 0x060009F9 RID: 2553 RVA: 0x00019BAC File Offset: 0x00017DAC
		public virtual MenuItemImpl ExpandedItem
		{
			[Register("getExpandedItem", "()Landroidx/appcompat/view/menu/MenuItemImpl;", "GetGetExpandedItemHandler")]
			get
			{
				return Java.Lang.Object.GetObject<MenuItemImpl>(MenuBuilder._members.InstanceMethods.InvokeVirtualObjectMethod("getExpandedItem.()Landroidx/appcompat/view/menu/MenuItemImpl;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x060009FA RID: 2554 RVA: 0x00019BDE File Offset: 0x00017DDE
		private static Delegate GetIsGroupDividerEnabledHandler()
		{
			if (MenuBuilder.cb_isGroupDividerEnabled == null)
			{
				MenuBuilder.cb_isGroupDividerEnabled = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(MenuBuilder.n_IsGroupDividerEnabled));
			}
			return MenuBuilder.cb_isGroupDividerEnabled;
		}

		// Token: 0x060009FB RID: 2555 RVA: 0x00019C02 File Offset: 0x00017E02
		private static bool n_IsGroupDividerEnabled(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<MenuBuilder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).GroupDividerEnabled;
		}

		// Token: 0x060009FC RID: 2556 RVA: 0x00019C11 File Offset: 0x00017E11
		private static Delegate GetSetGroupDividerEnabled_ZHandler()
		{
			if (MenuBuilder.cb_setGroupDividerEnabled_Z == null)
			{
				MenuBuilder.cb_setGroupDividerEnabled_Z = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPZ_V(MenuBuilder.n_SetGroupDividerEnabled_Z));
			}
			return MenuBuilder.cb_setGroupDividerEnabled_Z;
		}

		// Token: 0x060009FD RID: 2557 RVA: 0x00019C35 File Offset: 0x00017E35
		private static void n_SetGroupDividerEnabled_Z(IntPtr jnienv, IntPtr native__this, bool enabled)
		{
			Java.Lang.Object.GetObject<MenuBuilder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).GroupDividerEnabled = enabled;
		}

		// Token: 0x17000186 RID: 390
		// (get) Token: 0x060009FE RID: 2558 RVA: 0x00019C45 File Offset: 0x00017E45
		// (set) Token: 0x060009FF RID: 2559 RVA: 0x00019C60 File Offset: 0x00017E60
		public unsafe virtual bool GroupDividerEnabled
		{
			[Register("isGroupDividerEnabled", "()Z", "GetIsGroupDividerEnabledHandler")]
			get
			{
				return MenuBuilder._members.InstanceMethods.InvokeVirtualBooleanMethod("isGroupDividerEnabled.()Z", this, null);
			}
			[Register("setGroupDividerEnabled", "(Z)V", "GetSetGroupDividerEnabled_ZHandler")]
			set
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(value);
				MenuBuilder._members.InstanceMethods.InvokeVirtualVoidMethod("setGroupDividerEnabled.(Z)V", this, ptr);
			}
		}

		// Token: 0x06000A00 RID: 2560 RVA: 0x00019C9B File Offset: 0x00017E9B
		private static Delegate GetHasVisibleItemsHandler()
		{
			if (MenuBuilder.cb_hasVisibleItems == null)
			{
				MenuBuilder.cb_hasVisibleItems = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(MenuBuilder.n_HasVisibleItems));
			}
			return MenuBuilder.cb_hasVisibleItems;
		}

		// Token: 0x06000A01 RID: 2561 RVA: 0x00019CBF File Offset: 0x00017EBF
		private static bool n_HasVisibleItems(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<MenuBuilder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).HasVisibleItems;
		}

		// Token: 0x17000187 RID: 391
		// (get) Token: 0x06000A02 RID: 2562 RVA: 0x00019CCE File Offset: 0x00017ECE
		public virtual bool HasVisibleItems
		{
			[Register("hasVisibleItems", "()Z", "GetHasVisibleItemsHandler")]
			get
			{
				return MenuBuilder._members.InstanceMethods.InvokeVirtualBooleanMethod("hasVisibleItems.()Z", this, null);
			}
		}

		// Token: 0x06000A03 RID: 2563 RVA: 0x00019CE7 File Offset: 0x00017EE7
		private static Delegate GetGetHeaderIconHandler()
		{
			if (MenuBuilder.cb_getHeaderIcon == null)
			{
				MenuBuilder.cb_getHeaderIcon = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(MenuBuilder.n_GetHeaderIcon));
			}
			return MenuBuilder.cb_getHeaderIcon;
		}

		// Token: 0x06000A04 RID: 2564 RVA: 0x00019D0B File Offset: 0x00017F0B
		private static IntPtr n_GetHeaderIcon(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<MenuBuilder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).HeaderIcon);
		}

		// Token: 0x17000188 RID: 392
		// (get) Token: 0x06000A05 RID: 2565 RVA: 0x00019D20 File Offset: 0x00017F20
		public virtual Drawable HeaderIcon
		{
			[Register("getHeaderIcon", "()Landroid/graphics/drawable/Drawable;", "GetGetHeaderIconHandler")]
			get
			{
				return Java.Lang.Object.GetObject<Drawable>(MenuBuilder._members.InstanceMethods.InvokeVirtualObjectMethod("getHeaderIcon.()Landroid/graphics/drawable/Drawable;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06000A06 RID: 2566 RVA: 0x00019D52 File Offset: 0x00017F52
		private static Delegate GetGetHeaderTitleHandler()
		{
			if (MenuBuilder.cb_getHeaderTitle == null)
			{
				MenuBuilder.cb_getHeaderTitle = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(MenuBuilder.n_GetHeaderTitle));
			}
			return MenuBuilder.cb_getHeaderTitle;
		}

		// Token: 0x06000A07 RID: 2567 RVA: 0x00019D76 File Offset: 0x00017F76
		private static IntPtr n_GetHeaderTitle(IntPtr jnienv, IntPtr native__this)
		{
			return CharSequence.ToLocalJniHandle(Java.Lang.Object.GetObject<MenuBuilder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).HeaderTitleFormatted);
		}

		// Token: 0x17000189 RID: 393
		// (get) Token: 0x06000A08 RID: 2568 RVA: 0x00019D8C File Offset: 0x00017F8C
		public virtual ICharSequence HeaderTitleFormatted
		{
			[Register("getHeaderTitle", "()Ljava/lang/CharSequence;", "GetGetHeaderTitleHandler")]
			get
			{
				return Java.Lang.Object.GetObject<ICharSequence>(MenuBuilder._members.InstanceMethods.InvokeVirtualObjectMethod("getHeaderTitle.()Ljava/lang/CharSequence;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x1700018A RID: 394
		// (get) Token: 0x06000A09 RID: 2569 RVA: 0x00019DBE File Offset: 0x00017FBE
		public string HeaderTitle
		{
			get
			{
				if (this.HeaderTitleFormatted != null)
				{
					return this.HeaderTitleFormatted.ToString();
				}
				return null;
			}
		}

		// Token: 0x06000A0A RID: 2570 RVA: 0x00019DD5 File Offset: 0x00017FD5
		private static Delegate GetGetHeaderViewHandler()
		{
			if (MenuBuilder.cb_getHeaderView == null)
			{
				MenuBuilder.cb_getHeaderView = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(MenuBuilder.n_GetHeaderView));
			}
			return MenuBuilder.cb_getHeaderView;
		}

		// Token: 0x06000A0B RID: 2571 RVA: 0x00019DF9 File Offset: 0x00017FF9
		private static IntPtr n_GetHeaderView(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<MenuBuilder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).HeaderView);
		}

		// Token: 0x1700018B RID: 395
		// (get) Token: 0x06000A0C RID: 2572 RVA: 0x00019E10 File Offset: 0x00018010
		public virtual View HeaderView
		{
			[Register("getHeaderView", "()Landroid/view/View;", "GetGetHeaderViewHandler")]
			get
			{
				return Java.Lang.Object.GetObject<View>(MenuBuilder._members.InstanceMethods.InvokeVirtualObjectMethod("getHeaderView.()Landroid/view/View;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06000A0D RID: 2573 RVA: 0x00019E42 File Offset: 0x00018042
		private static Delegate GetGetNonActionItemsHandler()
		{
			if (MenuBuilder.cb_getNonActionItems == null)
			{
				MenuBuilder.cb_getNonActionItems = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(MenuBuilder.n_GetNonActionItems));
			}
			return MenuBuilder.cb_getNonActionItems;
		}

		// Token: 0x06000A0E RID: 2574 RVA: 0x00019E66 File Offset: 0x00018066
		private static IntPtr n_GetNonActionItems(IntPtr jnienv, IntPtr native__this)
		{
			return JavaList<MenuItemImpl>.ToLocalJniHandle(Java.Lang.Object.GetObject<MenuBuilder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).NonActionItems);
		}

		// Token: 0x1700018C RID: 396
		// (get) Token: 0x06000A0F RID: 2575 RVA: 0x00019E7C File Offset: 0x0001807C
		public virtual IList<MenuItemImpl> NonActionItems
		{
			[Register("getNonActionItems", "()Ljava/util/ArrayList;", "GetGetNonActionItemsHandler")]
			get
			{
				return JavaList<MenuItemImpl>.FromJniHandle(MenuBuilder._members.InstanceMethods.InvokeVirtualObjectMethod("getNonActionItems.()Ljava/util/ArrayList;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06000A10 RID: 2576 RVA: 0x00019EAE File Offset: 0x000180AE
		private static Delegate GetGetRootMenuHandler()
		{
			if (MenuBuilder.cb_getRootMenu == null)
			{
				MenuBuilder.cb_getRootMenu = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(MenuBuilder.n_GetRootMenu));
			}
			return MenuBuilder.cb_getRootMenu;
		}

		// Token: 0x06000A11 RID: 2577 RVA: 0x00019ED2 File Offset: 0x000180D2
		private static IntPtr n_GetRootMenu(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<MenuBuilder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).RootMenu);
		}

		// Token: 0x1700018D RID: 397
		// (get) Token: 0x06000A12 RID: 2578 RVA: 0x00019EE8 File Offset: 0x000180E8
		public virtual MenuBuilder RootMenu
		{
			[Register("getRootMenu", "()Landroidx/appcompat/view/menu/MenuBuilder;", "GetGetRootMenuHandler")]
			get
			{
				return Java.Lang.Object.GetObject<MenuBuilder>(MenuBuilder._members.InstanceMethods.InvokeVirtualObjectMethod("getRootMenu.()Landroidx/appcompat/view/menu/MenuBuilder;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06000A13 RID: 2579 RVA: 0x00019F1A File Offset: 0x0001811A
		private static Delegate GetIsShortcutsVisibleHandler()
		{
			if (MenuBuilder.cb_isShortcutsVisible == null)
			{
				MenuBuilder.cb_isShortcutsVisible = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(MenuBuilder.n_IsShortcutsVisible));
			}
			return MenuBuilder.cb_isShortcutsVisible;
		}

		// Token: 0x06000A14 RID: 2580 RVA: 0x00019F3E File Offset: 0x0001813E
		private static bool n_IsShortcutsVisible(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<MenuBuilder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ShortcutsVisible;
		}

		// Token: 0x06000A15 RID: 2581 RVA: 0x00019F4D File Offset: 0x0001814D
		private static Delegate GetSetShortcutsVisible_ZHandler()
		{
			if (MenuBuilder.cb_setShortcutsVisible_Z == null)
			{
				MenuBuilder.cb_setShortcutsVisible_Z = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPZ_V(MenuBuilder.n_SetShortcutsVisible_Z));
			}
			return MenuBuilder.cb_setShortcutsVisible_Z;
		}

		// Token: 0x06000A16 RID: 2582 RVA: 0x00019F71 File Offset: 0x00018171
		private static void n_SetShortcutsVisible_Z(IntPtr jnienv, IntPtr native__this, bool shortcutsVisible)
		{
			Java.Lang.Object.GetObject<MenuBuilder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ShortcutsVisible = shortcutsVisible;
		}

		// Token: 0x1700018E RID: 398
		// (get) Token: 0x06000A17 RID: 2583 RVA: 0x00019F81 File Offset: 0x00018181
		// (set) Token: 0x06000A18 RID: 2584 RVA: 0x00019F9C File Offset: 0x0001819C
		public unsafe virtual bool ShortcutsVisible
		{
			[Register("isShortcutsVisible", "()Z", "GetIsShortcutsVisibleHandler")]
			get
			{
				return MenuBuilder._members.InstanceMethods.InvokeVirtualBooleanMethod("isShortcutsVisible.()Z", this, null);
			}
			[Register("setShortcutsVisible", "(Z)V", "GetSetShortcutsVisible_ZHandler")]
			set
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(value);
				MenuBuilder._members.InstanceMethods.InvokeVirtualVoidMethod("setShortcutsVisible.(Z)V", this, ptr);
			}
		}

		// Token: 0x06000A19 RID: 2585 RVA: 0x00019FD7 File Offset: 0x000181D7
		private static Delegate GetGetVisibleItemsHandler()
		{
			if (MenuBuilder.cb_getVisibleItems == null)
			{
				MenuBuilder.cb_getVisibleItems = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(MenuBuilder.n_GetVisibleItems));
			}
			return MenuBuilder.cb_getVisibleItems;
		}

		// Token: 0x06000A1A RID: 2586 RVA: 0x00019FFB File Offset: 0x000181FB
		private static IntPtr n_GetVisibleItems(IntPtr jnienv, IntPtr native__this)
		{
			return JavaList<MenuItemImpl>.ToLocalJniHandle(Java.Lang.Object.GetObject<MenuBuilder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).VisibleItems);
		}

		// Token: 0x1700018F RID: 399
		// (get) Token: 0x06000A1B RID: 2587 RVA: 0x0001A010 File Offset: 0x00018210
		public virtual IList<MenuItemImpl> VisibleItems
		{
			[Register("getVisibleItems", "()Ljava/util/ArrayList;", "GetGetVisibleItemsHandler")]
			get
			{
				return JavaList<MenuItemImpl>.FromJniHandle(MenuBuilder._members.InstanceMethods.InvokeVirtualObjectMethod("getVisibleItems.()Ljava/util/ArrayList;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06000A1C RID: 2588 RVA: 0x0001A042 File Offset: 0x00018242
		private static Delegate GetAdd_IHandler()
		{
			if (MenuBuilder.cb_add_I == null)
			{
				MenuBuilder.cb_add_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_L(MenuBuilder.n_Add_I));
			}
			return MenuBuilder.cb_add_I;
		}

		// Token: 0x06000A1D RID: 2589 RVA: 0x0001A066 File Offset: 0x00018266
		private static IntPtr n_Add_I(IntPtr jnienv, IntPtr native__this, int titleRes)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<MenuBuilder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Add(titleRes));
		}

		// Token: 0x06000A1E RID: 2590 RVA: 0x0001A07C File Offset: 0x0001827C
		[Register("add", "(I)Landroid/view/MenuItem;", "GetAdd_IHandler")]
		public unsafe virtual IMenuItem Add(int titleRes)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(titleRes);
			return Java.Lang.Object.GetObject<IMenuItem>(MenuBuilder._members.InstanceMethods.InvokeVirtualObjectMethod("add.(I)Landroid/view/MenuItem;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06000A1F RID: 2591 RVA: 0x0001A0C5 File Offset: 0x000182C5
		private static Delegate GetAdd_IIIIHandler()
		{
			if (MenuBuilder.cb_add_IIII == null)
			{
				MenuBuilder.cb_add_IIII = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPIIII_L(MenuBuilder.n_Add_IIII));
			}
			return MenuBuilder.cb_add_IIII;
		}

		// Token: 0x06000A20 RID: 2592 RVA: 0x0001A0E9 File Offset: 0x000182E9
		private static IntPtr n_Add_IIII(IntPtr jnienv, IntPtr native__this, int group, int id, int categoryOrder, int title)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<MenuBuilder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Add(group, id, categoryOrder, title));
		}

		// Token: 0x06000A21 RID: 2593 RVA: 0x0001A104 File Offset: 0x00018304
		[Register("add", "(IIII)Landroid/view/MenuItem;", "GetAdd_IIIIHandler")]
		public unsafe virtual IMenuItem Add(int group, int id, int categoryOrder, int title)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(group);
			ptr[1] = new JniArgumentValue(id);
			ptr[2] = new JniArgumentValue(categoryOrder);
			ptr[3] = new JniArgumentValue(title);
			return Java.Lang.Object.GetObject<IMenuItem>(MenuBuilder._members.InstanceMethods.InvokeVirtualObjectMethod("add.(IIII)Landroid/view/MenuItem;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06000A22 RID: 2594 RVA: 0x0001A18D File Offset: 0x0001838D
		private static Delegate GetAdd_IIILjava_lang_CharSequence_Handler()
		{
			if (MenuBuilder.cb_add_IIILjava_lang_CharSequence_ == null)
			{
				MenuBuilder.cb_add_IIILjava_lang_CharSequence_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPIIIL_L(MenuBuilder.n_Add_IIILjava_lang_CharSequence_));
			}
			return MenuBuilder.cb_add_IIILjava_lang_CharSequence_;
		}

		// Token: 0x06000A23 RID: 2595 RVA: 0x0001A1B4 File Offset: 0x000183B4
		private static IntPtr n_Add_IIILjava_lang_CharSequence_(IntPtr jnienv, IntPtr native__this, int group, int id, int categoryOrder, IntPtr native_title)
		{
			MenuBuilder @object = Java.Lang.Object.GetObject<MenuBuilder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ICharSequence object2 = Java.Lang.Object.GetObject<ICharSequence>(native_title, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.Add(group, id, categoryOrder, object2));
		}

		// Token: 0x06000A24 RID: 2596 RVA: 0x0001A1E4 File Offset: 0x000183E4
		[Register("add", "(IIILjava/lang/CharSequence;)Landroid/view/MenuItem;", "GetAdd_IIILjava_lang_CharSequence_Handler")]
		public unsafe virtual IMenuItem Add(int group, int id, int categoryOrder, ICharSequence title)
		{
			IntPtr intPtr = CharSequence.ToLocalJniHandle(title);
			IMenuItem @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(group);
				ptr[1] = new JniArgumentValue(id);
				ptr[2] = new JniArgumentValue(categoryOrder);
				ptr[3] = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<IMenuItem>(MenuBuilder._members.InstanceMethods.InvokeVirtualObjectMethod("add.(IIILjava/lang/CharSequence;)Landroid/view/MenuItem;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(title);
			}
			return @object;
		}

		// Token: 0x06000A25 RID: 2597 RVA: 0x0001A298 File Offset: 0x00018498
		public IMenuItem Add(int group, int id, int categoryOrder, string title)
		{
			Java.Lang.String @string = (title == null) ? null : new Java.Lang.String(title);
			IMenuItem result = this.Add(group, id, categoryOrder, @string);
			if (@string != null)
			{
				@string.Dispose();
			}
			return result;
		}

		// Token: 0x06000A26 RID: 2598 RVA: 0x0001A2C7 File Offset: 0x000184C7
		private static Delegate GetAdd_Ljava_lang_CharSequence_Handler()
		{
			if (MenuBuilder.cb_add_Ljava_lang_CharSequence_ == null)
			{
				MenuBuilder.cb_add_Ljava_lang_CharSequence_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(MenuBuilder.n_Add_Ljava_lang_CharSequence_));
			}
			return MenuBuilder.cb_add_Ljava_lang_CharSequence_;
		}

		// Token: 0x06000A27 RID: 2599 RVA: 0x0001A2EC File Offset: 0x000184EC
		private static IntPtr n_Add_Ljava_lang_CharSequence_(IntPtr jnienv, IntPtr native__this, IntPtr native_title)
		{
			MenuBuilder @object = Java.Lang.Object.GetObject<MenuBuilder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ICharSequence object2 = Java.Lang.Object.GetObject<ICharSequence>(native_title, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.Add(object2));
		}

		// Token: 0x06000A28 RID: 2600 RVA: 0x0001A314 File Offset: 0x00018514
		[Register("add", "(Ljava/lang/CharSequence;)Landroid/view/MenuItem;", "GetAdd_Ljava_lang_CharSequence_Handler")]
		public unsafe virtual IMenuItem Add(ICharSequence title)
		{
			IntPtr intPtr = CharSequence.ToLocalJniHandle(title);
			IMenuItem @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<IMenuItem>(MenuBuilder._members.InstanceMethods.InvokeVirtualObjectMethod("add.(Ljava/lang/CharSequence;)Landroid/view/MenuItem;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(title);
			}
			return @object;
		}

		// Token: 0x06000A29 RID: 2601 RVA: 0x0001A388 File Offset: 0x00018588
		public IMenuItem Add(string title)
		{
			Java.Lang.String @string = (title == null) ? null : new Java.Lang.String(title);
			IMenuItem result = this.Add(@string);
			if (@string != null)
			{
				@string.Dispose();
			}
			return result;
		}

		// Token: 0x06000A2A RID: 2602 RVA: 0x0001A3B2 File Offset: 0x000185B2
		private static Delegate GetAddIntentOptions_IIILandroid_content_ComponentName_arrayLandroid_content_Intent_Landroid_content_Intent_IarrayLandroid_view_MenuItem_Handler()
		{
			if (MenuBuilder.cb_addIntentOptions_IIILandroid_content_ComponentName_arrayLandroid_content_Intent_Landroid_content_Intent_IarrayLandroid_view_MenuItem_ == null)
			{
				MenuBuilder.cb_addIntentOptions_IIILandroid_content_ComponentName_arrayLandroid_content_Intent_Landroid_content_Intent_IarrayLandroid_view_MenuItem_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPIIILLLIL_I(MenuBuilder.n_AddIntentOptions_IIILandroid_content_ComponentName_arrayLandroid_content_Intent_Landroid_content_Intent_IarrayLandroid_view_MenuItem_));
			}
			return MenuBuilder.cb_addIntentOptions_IIILandroid_content_ComponentName_arrayLandroid_content_Intent_Landroid_content_Intent_IarrayLandroid_view_MenuItem_;
		}

		// Token: 0x06000A2B RID: 2603 RVA: 0x0001A3D8 File Offset: 0x000185D8
		private static int n_AddIntentOptions_IIILandroid_content_ComponentName_arrayLandroid_content_Intent_Landroid_content_Intent_IarrayLandroid_view_MenuItem_(IntPtr jnienv, IntPtr native__this, int group, int id, int categoryOrder, IntPtr native_caller, IntPtr native_specifics, IntPtr native_intent, int native_flags, IntPtr native_outSpecificItems)
		{
			MenuBuilder @object = Java.Lang.Object.GetObject<MenuBuilder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ComponentName object2 = Java.Lang.Object.GetObject<ComponentName>(native_caller, JniHandleOwnership.DoNotTransfer);
			Intent[] array = (Intent[])JNIEnv.GetArray(native_specifics, JniHandleOwnership.DoNotTransfer, typeof(Intent));
			Intent object3 = Java.Lang.Object.GetObject<Intent>(native_intent, JniHandleOwnership.DoNotTransfer);
			IMenuItem[] array2 = (IMenuItem[])JNIEnv.GetArray(native_outSpecificItems, JniHandleOwnership.DoNotTransfer, typeof(IMenuItem));
			int result = @object.AddIntentOptions(group, id, categoryOrder, object2, array, object3, (MenuAppendFlags)native_flags, array2);
			if (array != null)
			{
				JNIEnv.CopyArray<Intent>(array, native_specifics);
			}
			if (array2 != null)
			{
				JNIEnv.CopyArray<IMenuItem>(array2, native_outSpecificItems);
			}
			return result;
		}

		// Token: 0x06000A2C RID: 2604 RVA: 0x0001A45C File Offset: 0x0001865C
		[Register("addIntentOptions", "(IIILandroid/content/ComponentName;[Landroid/content/Intent;Landroid/content/Intent;I[Landroid/view/MenuItem;)I", "GetAddIntentOptions_IIILandroid_content_ComponentName_arrayLandroid_content_Intent_Landroid_content_Intent_IarrayLandroid_view_MenuItem_Handler")]
		public unsafe virtual int AddIntentOptions(int group, int id, int categoryOrder, ComponentName caller, Intent[] specifics, Intent intent, [GeneratedEnum] MenuAppendFlags flags, IMenuItem[] outSpecificItems)
		{
			IntPtr intPtr = JNIEnv.NewArray<Intent>(specifics);
			IntPtr intPtr2 = JNIEnv.NewArray<IMenuItem>(outSpecificItems);
			int result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(group);
				ptr[1] = new JniArgumentValue(id);
				ptr[2] = new JniArgumentValue(categoryOrder);
				ptr[3] = new JniArgumentValue((caller == null) ? IntPtr.Zero : caller.Handle);
				ptr[4] = new JniArgumentValue(intPtr);
				ptr[5] = new JniArgumentValue((intent == null) ? IntPtr.Zero : intent.Handle);
				ptr[6] = new JniArgumentValue((int)flags);
				ptr[7] = new JniArgumentValue(intPtr2);
				result = MenuBuilder._members.InstanceMethods.InvokeVirtualInt32Method("addIntentOptions.(IIILandroid/content/ComponentName;[Landroid/content/Intent;Landroid/content/Intent;I[Landroid/view/MenuItem;)I", this, ptr);
			}
			finally
			{
				if (specifics != null)
				{
					JNIEnv.CopyArray<Intent>(intPtr, specifics);
					JNIEnv.DeleteLocalRef(intPtr);
				}
				if (outSpecificItems != null)
				{
					JNIEnv.CopyArray<IMenuItem>(intPtr2, outSpecificItems);
					JNIEnv.DeleteLocalRef(intPtr2);
				}
				GC.KeepAlive(caller);
				GC.KeepAlive(specifics);
				GC.KeepAlive(intent);
				GC.KeepAlive(outSpecificItems);
			}
			return result;
		}

		// Token: 0x06000A2D RID: 2605 RVA: 0x0001A5B8 File Offset: 0x000187B8
		private static Delegate GetAddInternal_IIILjava_lang_CharSequence_Handler()
		{
			if (MenuBuilder.cb_addInternal_IIILjava_lang_CharSequence_ == null)
			{
				MenuBuilder.cb_addInternal_IIILjava_lang_CharSequence_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPIIIL_L(MenuBuilder.n_AddInternal_IIILjava_lang_CharSequence_));
			}
			return MenuBuilder.cb_addInternal_IIILjava_lang_CharSequence_;
		}

		// Token: 0x06000A2E RID: 2606 RVA: 0x0001A5DC File Offset: 0x000187DC
		private static IntPtr n_AddInternal_IIILjava_lang_CharSequence_(IntPtr jnienv, IntPtr native__this, int group, int id, int categoryOrder, IntPtr native_title)
		{
			MenuBuilder @object = Java.Lang.Object.GetObject<MenuBuilder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ICharSequence object2 = Java.Lang.Object.GetObject<ICharSequence>(native_title, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.AddInternal(group, id, categoryOrder, object2));
		}

		// Token: 0x06000A2F RID: 2607 RVA: 0x0001A60C File Offset: 0x0001880C
		[Register("addInternal", "(IIILjava/lang/CharSequence;)Landroid/view/MenuItem;", "GetAddInternal_IIILjava_lang_CharSequence_Handler")]
		protected unsafe virtual IMenuItem AddInternal(int group, int id, int categoryOrder, ICharSequence title)
		{
			IntPtr intPtr = CharSequence.ToLocalJniHandle(title);
			IMenuItem @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(group);
				ptr[1] = new JniArgumentValue(id);
				ptr[2] = new JniArgumentValue(categoryOrder);
				ptr[3] = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<IMenuItem>(MenuBuilder._members.InstanceMethods.InvokeVirtualObjectMethod("addInternal.(IIILjava/lang/CharSequence;)Landroid/view/MenuItem;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(title);
			}
			return @object;
		}

		// Token: 0x06000A30 RID: 2608 RVA: 0x0001A6C0 File Offset: 0x000188C0
		protected IMenuItem AddInternal(int group, int id, int categoryOrder, string title)
		{
			Java.Lang.String @string = (title == null) ? null : new Java.Lang.String(title);
			IMenuItem result = this.AddInternal(group, id, categoryOrder, @string);
			if (@string != null)
			{
				@string.Dispose();
			}
			return result;
		}

		// Token: 0x06000A31 RID: 2609 RVA: 0x0001A6EF File Offset: 0x000188EF
		private static Delegate GetAddMenuPresenter_Landroidx_appcompat_view_menu_MenuPresenter_Handler()
		{
			if (MenuBuilder.cb_addMenuPresenter_Landroidx_appcompat_view_menu_MenuPresenter_ == null)
			{
				MenuBuilder.cb_addMenuPresenter_Landroidx_appcompat_view_menu_MenuPresenter_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(MenuBuilder.n_AddMenuPresenter_Landroidx_appcompat_view_menu_MenuPresenter_));
			}
			return MenuBuilder.cb_addMenuPresenter_Landroidx_appcompat_view_menu_MenuPresenter_;
		}

		// Token: 0x06000A32 RID: 2610 RVA: 0x0001A714 File Offset: 0x00018914
		private static void n_AddMenuPresenter_Landroidx_appcompat_view_menu_MenuPresenter_(IntPtr jnienv, IntPtr native__this, IntPtr native_presenter)
		{
			MenuBuilder @object = Java.Lang.Object.GetObject<MenuBuilder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IMenuPresenter object2 = Java.Lang.Object.GetObject<IMenuPresenter>(native_presenter, JniHandleOwnership.DoNotTransfer);
			@object.AddMenuPresenter(object2);
		}

		// Token: 0x06000A33 RID: 2611 RVA: 0x0001A738 File Offset: 0x00018938
		[Register("addMenuPresenter", "(Landroidx/appcompat/view/menu/MenuPresenter;)V", "GetAddMenuPresenter_Landroidx_appcompat_view_menu_MenuPresenter_Handler")]
		public unsafe virtual void AddMenuPresenter(IMenuPresenter presenter)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((presenter == null) ? IntPtr.Zero : ((Java.Lang.Object)presenter).Handle);
				MenuBuilder._members.InstanceMethods.InvokeVirtualVoidMethod("addMenuPresenter.(Landroidx/appcompat/view/menu/MenuPresenter;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(presenter);
			}
		}

		// Token: 0x06000A34 RID: 2612 RVA: 0x0001A7A0 File Offset: 0x000189A0
		private static Delegate GetAddMenuPresenter_Landroidx_appcompat_view_menu_MenuPresenter_Landroid_content_Context_Handler()
		{
			if (MenuBuilder.cb_addMenuPresenter_Landroidx_appcompat_view_menu_MenuPresenter_Landroid_content_Context_ == null)
			{
				MenuBuilder.cb_addMenuPresenter_Landroidx_appcompat_view_menu_MenuPresenter_Landroid_content_Context_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_V(MenuBuilder.n_AddMenuPresenter_Landroidx_appcompat_view_menu_MenuPresenter_Landroid_content_Context_));
			}
			return MenuBuilder.cb_addMenuPresenter_Landroidx_appcompat_view_menu_MenuPresenter_Landroid_content_Context_;
		}

		// Token: 0x06000A35 RID: 2613 RVA: 0x0001A7C4 File Offset: 0x000189C4
		private static void n_AddMenuPresenter_Landroidx_appcompat_view_menu_MenuPresenter_Landroid_content_Context_(IntPtr jnienv, IntPtr native__this, IntPtr native_presenter, IntPtr native_menuContext)
		{
			MenuBuilder @object = Java.Lang.Object.GetObject<MenuBuilder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IMenuPresenter object2 = Java.Lang.Object.GetObject<IMenuPresenter>(native_presenter, JniHandleOwnership.DoNotTransfer);
			Context object3 = Java.Lang.Object.GetObject<Context>(native_menuContext, JniHandleOwnership.DoNotTransfer);
			@object.AddMenuPresenter(object2, object3);
		}

		// Token: 0x06000A36 RID: 2614 RVA: 0x0001A7F0 File Offset: 0x000189F0
		[Register("addMenuPresenter", "(Landroidx/appcompat/view/menu/MenuPresenter;Landroid/content/Context;)V", "GetAddMenuPresenter_Landroidx_appcompat_view_menu_MenuPresenter_Landroid_content_Context_Handler")]
		public unsafe virtual void AddMenuPresenter(IMenuPresenter presenter, Context menuContext)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((presenter == null) ? IntPtr.Zero : ((Java.Lang.Object)presenter).Handle);
				ptr[1] = new JniArgumentValue((menuContext == null) ? IntPtr.Zero : menuContext.Handle);
				MenuBuilder._members.InstanceMethods.InvokeVirtualVoidMethod("addMenuPresenter.(Landroidx/appcompat/view/menu/MenuPresenter;Landroid/content/Context;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(presenter);
				GC.KeepAlive(menuContext);
			}
		}

		// Token: 0x06000A37 RID: 2615 RVA: 0x0001A880 File Offset: 0x00018A80
		private static Delegate GetAddSubMenu_IHandler()
		{
			if (MenuBuilder.cb_addSubMenu_I == null)
			{
				MenuBuilder.cb_addSubMenu_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_L(MenuBuilder.n_AddSubMenu_I));
			}
			return MenuBuilder.cb_addSubMenu_I;
		}

		// Token: 0x06000A38 RID: 2616 RVA: 0x0001A8A4 File Offset: 0x00018AA4
		private static IntPtr n_AddSubMenu_I(IntPtr jnienv, IntPtr native__this, int titleRes)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<MenuBuilder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).AddSubMenu(titleRes));
		}

		// Token: 0x06000A39 RID: 2617 RVA: 0x0001A8BC File Offset: 0x00018ABC
		[Register("addSubMenu", "(I)Landroid/view/SubMenu;", "GetAddSubMenu_IHandler")]
		public unsafe virtual ISubMenu AddSubMenu(int titleRes)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(titleRes);
			return Java.Lang.Object.GetObject<ISubMenu>(MenuBuilder._members.InstanceMethods.InvokeVirtualObjectMethod("addSubMenu.(I)Landroid/view/SubMenu;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06000A3A RID: 2618 RVA: 0x0001A905 File Offset: 0x00018B05
		private static Delegate GetAddSubMenu_IIIIHandler()
		{
			if (MenuBuilder.cb_addSubMenu_IIII == null)
			{
				MenuBuilder.cb_addSubMenu_IIII = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPIIII_L(MenuBuilder.n_AddSubMenu_IIII));
			}
			return MenuBuilder.cb_addSubMenu_IIII;
		}

		// Token: 0x06000A3B RID: 2619 RVA: 0x0001A929 File Offset: 0x00018B29
		private static IntPtr n_AddSubMenu_IIII(IntPtr jnienv, IntPtr native__this, int group, int id, int categoryOrder, int title)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<MenuBuilder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).AddSubMenu(group, id, categoryOrder, title));
		}

		// Token: 0x06000A3C RID: 2620 RVA: 0x0001A944 File Offset: 0x00018B44
		[Register("addSubMenu", "(IIII)Landroid/view/SubMenu;", "GetAddSubMenu_IIIIHandler")]
		public unsafe virtual ISubMenu AddSubMenu(int group, int id, int categoryOrder, int title)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(group);
			ptr[1] = new JniArgumentValue(id);
			ptr[2] = new JniArgumentValue(categoryOrder);
			ptr[3] = new JniArgumentValue(title);
			return Java.Lang.Object.GetObject<ISubMenu>(MenuBuilder._members.InstanceMethods.InvokeVirtualObjectMethod("addSubMenu.(IIII)Landroid/view/SubMenu;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06000A3D RID: 2621 RVA: 0x0001A9CD File Offset: 0x00018BCD
		private static Delegate GetAddSubMenu_IIILjava_lang_CharSequence_Handler()
		{
			if (MenuBuilder.cb_addSubMenu_IIILjava_lang_CharSequence_ == null)
			{
				MenuBuilder.cb_addSubMenu_IIILjava_lang_CharSequence_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPIIIL_L(MenuBuilder.n_AddSubMenu_IIILjava_lang_CharSequence_));
			}
			return MenuBuilder.cb_addSubMenu_IIILjava_lang_CharSequence_;
		}

		// Token: 0x06000A3E RID: 2622 RVA: 0x0001A9F4 File Offset: 0x00018BF4
		private static IntPtr n_AddSubMenu_IIILjava_lang_CharSequence_(IntPtr jnienv, IntPtr native__this, int group, int id, int categoryOrder, IntPtr native_title)
		{
			MenuBuilder @object = Java.Lang.Object.GetObject<MenuBuilder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ICharSequence object2 = Java.Lang.Object.GetObject<ICharSequence>(native_title, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.AddSubMenu(group, id, categoryOrder, object2));
		}

		// Token: 0x06000A3F RID: 2623 RVA: 0x0001AA24 File Offset: 0x00018C24
		[Register("addSubMenu", "(IIILjava/lang/CharSequence;)Landroid/view/SubMenu;", "GetAddSubMenu_IIILjava_lang_CharSequence_Handler")]
		public unsafe virtual ISubMenu AddSubMenu(int group, int id, int categoryOrder, ICharSequence title)
		{
			IntPtr intPtr = CharSequence.ToLocalJniHandle(title);
			ISubMenu @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(group);
				ptr[1] = new JniArgumentValue(id);
				ptr[2] = new JniArgumentValue(categoryOrder);
				ptr[3] = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<ISubMenu>(MenuBuilder._members.InstanceMethods.InvokeVirtualObjectMethod("addSubMenu.(IIILjava/lang/CharSequence;)Landroid/view/SubMenu;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(title);
			}
			return @object;
		}

		// Token: 0x06000A40 RID: 2624 RVA: 0x0001AAD8 File Offset: 0x00018CD8
		public ISubMenu AddSubMenu(int group, int id, int categoryOrder, string title)
		{
			Java.Lang.String @string = (title == null) ? null : new Java.Lang.String(title);
			ISubMenu result = this.AddSubMenu(group, id, categoryOrder, @string);
			if (@string != null)
			{
				@string.Dispose();
			}
			return result;
		}

		// Token: 0x06000A41 RID: 2625 RVA: 0x0001AB07 File Offset: 0x00018D07
		private static Delegate GetAddSubMenu_Ljava_lang_CharSequence_Handler()
		{
			if (MenuBuilder.cb_addSubMenu_Ljava_lang_CharSequence_ == null)
			{
				MenuBuilder.cb_addSubMenu_Ljava_lang_CharSequence_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(MenuBuilder.n_AddSubMenu_Ljava_lang_CharSequence_));
			}
			return MenuBuilder.cb_addSubMenu_Ljava_lang_CharSequence_;
		}

		// Token: 0x06000A42 RID: 2626 RVA: 0x0001AB2C File Offset: 0x00018D2C
		private static IntPtr n_AddSubMenu_Ljava_lang_CharSequence_(IntPtr jnienv, IntPtr native__this, IntPtr native_title)
		{
			MenuBuilder @object = Java.Lang.Object.GetObject<MenuBuilder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ICharSequence object2 = Java.Lang.Object.GetObject<ICharSequence>(native_title, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.AddSubMenu(object2));
		}

		// Token: 0x06000A43 RID: 2627 RVA: 0x0001AB54 File Offset: 0x00018D54
		[Register("addSubMenu", "(Ljava/lang/CharSequence;)Landroid/view/SubMenu;", "GetAddSubMenu_Ljava_lang_CharSequence_Handler")]
		public unsafe virtual ISubMenu AddSubMenu(ICharSequence title)
		{
			IntPtr intPtr = CharSequence.ToLocalJniHandle(title);
			ISubMenu @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<ISubMenu>(MenuBuilder._members.InstanceMethods.InvokeVirtualObjectMethod("addSubMenu.(Ljava/lang/CharSequence;)Landroid/view/SubMenu;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(title);
			}
			return @object;
		}

		// Token: 0x06000A44 RID: 2628 RVA: 0x0001ABC8 File Offset: 0x00018DC8
		public ISubMenu AddSubMenu(string title)
		{
			Java.Lang.String @string = (title == null) ? null : new Java.Lang.String(title);
			ISubMenu result = this.AddSubMenu(@string);
			if (@string != null)
			{
				@string.Dispose();
			}
			return result;
		}

		// Token: 0x06000A45 RID: 2629 RVA: 0x0001ABF2 File Offset: 0x00018DF2
		private static Delegate GetChangeMenuModeHandler()
		{
			if (MenuBuilder.cb_changeMenuMode == null)
			{
				MenuBuilder.cb_changeMenuMode = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(MenuBuilder.n_ChangeMenuMode));
			}
			return MenuBuilder.cb_changeMenuMode;
		}

		// Token: 0x06000A46 RID: 2630 RVA: 0x0001AC16 File Offset: 0x00018E16
		private static void n_ChangeMenuMode(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<MenuBuilder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ChangeMenuMode();
		}

		// Token: 0x06000A47 RID: 2631 RVA: 0x0001AC25 File Offset: 0x00018E25
		[Register("changeMenuMode", "()V", "GetChangeMenuModeHandler")]
		public virtual void ChangeMenuMode()
		{
			MenuBuilder._members.InstanceMethods.InvokeVirtualVoidMethod("changeMenuMode.()V", this, null);
		}

		// Token: 0x06000A48 RID: 2632 RVA: 0x0001AC3E File Offset: 0x00018E3E
		private static Delegate GetClearHandler()
		{
			if (MenuBuilder.cb_clear == null)
			{
				MenuBuilder.cb_clear = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(MenuBuilder.n_Clear));
			}
			return MenuBuilder.cb_clear;
		}

		// Token: 0x06000A49 RID: 2633 RVA: 0x0001AC62 File Offset: 0x00018E62
		private static void n_Clear(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<MenuBuilder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Clear();
		}

		// Token: 0x06000A4A RID: 2634 RVA: 0x0001AC71 File Offset: 0x00018E71
		[Register("clear", "()V", "GetClearHandler")]
		public virtual void Clear()
		{
			MenuBuilder._members.InstanceMethods.InvokeVirtualVoidMethod("clear.()V", this, null);
		}

		// Token: 0x06000A4B RID: 2635 RVA: 0x0001AC8A File Offset: 0x00018E8A
		private static Delegate GetClearAllHandler()
		{
			if (MenuBuilder.cb_clearAll == null)
			{
				MenuBuilder.cb_clearAll = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(MenuBuilder.n_ClearAll));
			}
			return MenuBuilder.cb_clearAll;
		}

		// Token: 0x06000A4C RID: 2636 RVA: 0x0001ACAE File Offset: 0x00018EAE
		private static void n_ClearAll(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<MenuBuilder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ClearAll();
		}

		// Token: 0x06000A4D RID: 2637 RVA: 0x0001ACBD File Offset: 0x00018EBD
		[Register("clearAll", "()V", "GetClearAllHandler")]
		public virtual void ClearAll()
		{
			MenuBuilder._members.InstanceMethods.InvokeVirtualVoidMethod("clearAll.()V", this, null);
		}

		// Token: 0x06000A4E RID: 2638 RVA: 0x0001ACD6 File Offset: 0x00018ED6
		private static Delegate GetClearHeaderHandler()
		{
			if (MenuBuilder.cb_clearHeader == null)
			{
				MenuBuilder.cb_clearHeader = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(MenuBuilder.n_ClearHeader));
			}
			return MenuBuilder.cb_clearHeader;
		}

		// Token: 0x06000A4F RID: 2639 RVA: 0x0001ACFA File Offset: 0x00018EFA
		private static void n_ClearHeader(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<MenuBuilder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ClearHeader();
		}

		// Token: 0x06000A50 RID: 2640 RVA: 0x0001AD09 File Offset: 0x00018F09
		[Register("clearHeader", "()V", "GetClearHeaderHandler")]
		public virtual void ClearHeader()
		{
			MenuBuilder._members.InstanceMethods.InvokeVirtualVoidMethod("clearHeader.()V", this, null);
		}

		// Token: 0x06000A51 RID: 2641 RVA: 0x0001AD22 File Offset: 0x00018F22
		private static Delegate GetCloseHandler()
		{
			if (MenuBuilder.cb_close == null)
			{
				MenuBuilder.cb_close = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(MenuBuilder.n_Close));
			}
			return MenuBuilder.cb_close;
		}

		// Token: 0x06000A52 RID: 2642 RVA: 0x0001AD46 File Offset: 0x00018F46
		private static void n_Close(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<MenuBuilder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Close();
		}

		// Token: 0x06000A53 RID: 2643 RVA: 0x0001AD55 File Offset: 0x00018F55
		[Register("close", "()V", "GetCloseHandler")]
		public virtual void Close()
		{
			MenuBuilder._members.InstanceMethods.InvokeVirtualVoidMethod("close.()V", this, null);
		}

		// Token: 0x06000A54 RID: 2644 RVA: 0x0001AD70 File Offset: 0x00018F70
		[Register("close", "(Z)V", "")]
		public unsafe void Close(bool closeAllMenus)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(closeAllMenus);
			MenuBuilder._members.InstanceMethods.InvokeNonvirtualVoidMethod("close.(Z)V", this, ptr);
		}

		// Token: 0x06000A55 RID: 2645 RVA: 0x0001ADAB File Offset: 0x00018FAB
		private static Delegate GetCollapseItemActionView_Landroidx_appcompat_view_menu_MenuItemImpl_Handler()
		{
			if (MenuBuilder.cb_collapseItemActionView_Landroidx_appcompat_view_menu_MenuItemImpl_ == null)
			{
				MenuBuilder.cb_collapseItemActionView_Landroidx_appcompat_view_menu_MenuItemImpl_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(MenuBuilder.n_CollapseItemActionView_Landroidx_appcompat_view_menu_MenuItemImpl_));
			}
			return MenuBuilder.cb_collapseItemActionView_Landroidx_appcompat_view_menu_MenuItemImpl_;
		}

		// Token: 0x06000A56 RID: 2646 RVA: 0x0001ADD0 File Offset: 0x00018FD0
		private static bool n_CollapseItemActionView_Landroidx_appcompat_view_menu_MenuItemImpl_(IntPtr jnienv, IntPtr native__this, IntPtr native_item)
		{
			MenuBuilder @object = Java.Lang.Object.GetObject<MenuBuilder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			MenuItemImpl object2 = Java.Lang.Object.GetObject<MenuItemImpl>(native_item, JniHandleOwnership.DoNotTransfer);
			return @object.CollapseItemActionView(object2);
		}

		// Token: 0x06000A57 RID: 2647 RVA: 0x0001ADF4 File Offset: 0x00018FF4
		[Register("collapseItemActionView", "(Landroidx/appcompat/view/menu/MenuItemImpl;)Z", "GetCollapseItemActionView_Landroidx_appcompat_view_menu_MenuItemImpl_Handler")]
		public unsafe virtual bool CollapseItemActionView(MenuItemImpl item)
		{
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((item == null) ? IntPtr.Zero : item.Handle);
				result = MenuBuilder._members.InstanceMethods.InvokeVirtualBooleanMethod("collapseItemActionView.(Landroidx/appcompat/view/menu/MenuItemImpl;)Z", this, ptr);
			}
			finally
			{
				GC.KeepAlive(item);
			}
			return result;
		}

		// Token: 0x06000A58 RID: 2648 RVA: 0x0001AE5C File Offset: 0x0001905C
		private static Delegate GetExpandItemActionView_Landroidx_appcompat_view_menu_MenuItemImpl_Handler()
		{
			if (MenuBuilder.cb_expandItemActionView_Landroidx_appcompat_view_menu_MenuItemImpl_ == null)
			{
				MenuBuilder.cb_expandItemActionView_Landroidx_appcompat_view_menu_MenuItemImpl_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(MenuBuilder.n_ExpandItemActionView_Landroidx_appcompat_view_menu_MenuItemImpl_));
			}
			return MenuBuilder.cb_expandItemActionView_Landroidx_appcompat_view_menu_MenuItemImpl_;
		}

		// Token: 0x06000A59 RID: 2649 RVA: 0x0001AE80 File Offset: 0x00019080
		private static bool n_ExpandItemActionView_Landroidx_appcompat_view_menu_MenuItemImpl_(IntPtr jnienv, IntPtr native__this, IntPtr native_item)
		{
			MenuBuilder @object = Java.Lang.Object.GetObject<MenuBuilder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			MenuItemImpl object2 = Java.Lang.Object.GetObject<MenuItemImpl>(native_item, JniHandleOwnership.DoNotTransfer);
			return @object.ExpandItemActionView(object2);
		}

		// Token: 0x06000A5A RID: 2650 RVA: 0x0001AEA4 File Offset: 0x000190A4
		[Register("expandItemActionView", "(Landroidx/appcompat/view/menu/MenuItemImpl;)Z", "GetExpandItemActionView_Landroidx_appcompat_view_menu_MenuItemImpl_Handler")]
		public unsafe virtual bool ExpandItemActionView(MenuItemImpl item)
		{
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((item == null) ? IntPtr.Zero : item.Handle);
				result = MenuBuilder._members.InstanceMethods.InvokeVirtualBooleanMethod("expandItemActionView.(Landroidx/appcompat/view/menu/MenuItemImpl;)Z", this, ptr);
			}
			finally
			{
				GC.KeepAlive(item);
			}
			return result;
		}

		// Token: 0x06000A5B RID: 2651 RVA: 0x0001AF0C File Offset: 0x0001910C
		private static Delegate GetFindGroupIndex_IHandler()
		{
			if (MenuBuilder.cb_findGroupIndex_I == null)
			{
				MenuBuilder.cb_findGroupIndex_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_I(MenuBuilder.n_FindGroupIndex_I));
			}
			return MenuBuilder.cb_findGroupIndex_I;
		}

		// Token: 0x06000A5C RID: 2652 RVA: 0x0001AF30 File Offset: 0x00019130
		private static int n_FindGroupIndex_I(IntPtr jnienv, IntPtr native__this, int group)
		{
			return Java.Lang.Object.GetObject<MenuBuilder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).FindGroupIndex(group);
		}

		// Token: 0x06000A5D RID: 2653 RVA: 0x0001AF40 File Offset: 0x00019140
		[Register("findGroupIndex", "(I)I", "GetFindGroupIndex_IHandler")]
		public unsafe virtual int FindGroupIndex(int group)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(group);
			return MenuBuilder._members.InstanceMethods.InvokeVirtualInt32Method("findGroupIndex.(I)I", this, ptr);
		}

		// Token: 0x06000A5E RID: 2654 RVA: 0x0001AF7B File Offset: 0x0001917B
		private static Delegate GetFindGroupIndex_IIHandler()
		{
			if (MenuBuilder.cb_findGroupIndex_II == null)
			{
				MenuBuilder.cb_findGroupIndex_II = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPII_I(MenuBuilder.n_FindGroupIndex_II));
			}
			return MenuBuilder.cb_findGroupIndex_II;
		}

		// Token: 0x06000A5F RID: 2655 RVA: 0x0001AF9F File Offset: 0x0001919F
		private static int n_FindGroupIndex_II(IntPtr jnienv, IntPtr native__this, int group, int start)
		{
			return Java.Lang.Object.GetObject<MenuBuilder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).FindGroupIndex(group, start);
		}

		// Token: 0x06000A60 RID: 2656 RVA: 0x0001AFB0 File Offset: 0x000191B0
		[Register("findGroupIndex", "(II)I", "GetFindGroupIndex_IIHandler")]
		public unsafe virtual int FindGroupIndex(int group, int start)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(group);
			ptr[1] = new JniArgumentValue(start);
			return MenuBuilder._members.InstanceMethods.InvokeVirtualInt32Method("findGroupIndex.(II)I", this, ptr);
		}

		// Token: 0x06000A61 RID: 2657 RVA: 0x0001AFFE File Offset: 0x000191FE
		private static Delegate GetFindItem_IHandler()
		{
			if (MenuBuilder.cb_findItem_I == null)
			{
				MenuBuilder.cb_findItem_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_L(MenuBuilder.n_FindItem_I));
			}
			return MenuBuilder.cb_findItem_I;
		}

		// Token: 0x06000A62 RID: 2658 RVA: 0x0001B022 File Offset: 0x00019222
		private static IntPtr n_FindItem_I(IntPtr jnienv, IntPtr native__this, int id)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<MenuBuilder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).FindItem(id));
		}

		// Token: 0x06000A63 RID: 2659 RVA: 0x0001B038 File Offset: 0x00019238
		[Register("findItem", "(I)Landroid/view/MenuItem;", "GetFindItem_IHandler")]
		public unsafe virtual IMenuItem FindItem(int id)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(id);
			return Java.Lang.Object.GetObject<IMenuItem>(MenuBuilder._members.InstanceMethods.InvokeVirtualObjectMethod("findItem.(I)Landroid/view/MenuItem;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06000A64 RID: 2660 RVA: 0x0001B081 File Offset: 0x00019281
		private static Delegate GetFindItemIndex_IHandler()
		{
			if (MenuBuilder.cb_findItemIndex_I == null)
			{
				MenuBuilder.cb_findItemIndex_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_I(MenuBuilder.n_FindItemIndex_I));
			}
			return MenuBuilder.cb_findItemIndex_I;
		}

		// Token: 0x06000A65 RID: 2661 RVA: 0x0001B0A5 File Offset: 0x000192A5
		private static int n_FindItemIndex_I(IntPtr jnienv, IntPtr native__this, int id)
		{
			return Java.Lang.Object.GetObject<MenuBuilder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).FindItemIndex(id);
		}

		// Token: 0x06000A66 RID: 2662 RVA: 0x0001B0B8 File Offset: 0x000192B8
		[Register("findItemIndex", "(I)I", "GetFindItemIndex_IHandler")]
		public unsafe virtual int FindItemIndex(int id)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(id);
			return MenuBuilder._members.InstanceMethods.InvokeVirtualInt32Method("findItemIndex.(I)I", this, ptr);
		}

		// Token: 0x06000A67 RID: 2663 RVA: 0x0001B0F3 File Offset: 0x000192F3
		private static Delegate GetFlagActionItemsHandler()
		{
			if (MenuBuilder.cb_flagActionItems == null)
			{
				MenuBuilder.cb_flagActionItems = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(MenuBuilder.n_FlagActionItems));
			}
			return MenuBuilder.cb_flagActionItems;
		}

		// Token: 0x06000A68 RID: 2664 RVA: 0x0001B117 File Offset: 0x00019317
		private static void n_FlagActionItems(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<MenuBuilder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).FlagActionItems();
		}

		// Token: 0x06000A69 RID: 2665 RVA: 0x0001B126 File Offset: 0x00019326
		[Register("flagActionItems", "()V", "GetFlagActionItemsHandler")]
		public virtual void FlagActionItems()
		{
			MenuBuilder._members.InstanceMethods.InvokeVirtualVoidMethod("flagActionItems.()V", this, null);
		}

		// Token: 0x06000A6A RID: 2666 RVA: 0x0001B13F File Offset: 0x0001933F
		private static Delegate GetGetItem_IHandler()
		{
			if (MenuBuilder.cb_getItem_I == null)
			{
				MenuBuilder.cb_getItem_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_L(MenuBuilder.n_GetItem_I));
			}
			return MenuBuilder.cb_getItem_I;
		}

		// Token: 0x06000A6B RID: 2667 RVA: 0x0001B163 File Offset: 0x00019363
		private static IntPtr n_GetItem_I(IntPtr jnienv, IntPtr native__this, int index)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<MenuBuilder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).GetItem(index));
		}

		// Token: 0x06000A6C RID: 2668 RVA: 0x0001B178 File Offset: 0x00019378
		[Register("getItem", "(I)Landroid/view/MenuItem;", "GetGetItem_IHandler")]
		public unsafe virtual IMenuItem GetItem(int index)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(index);
			return Java.Lang.Object.GetObject<IMenuItem>(MenuBuilder._members.InstanceMethods.InvokeVirtualObjectMethod("getItem.(I)Landroid/view/MenuItem;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06000A6D RID: 2669 RVA: 0x0001B1C1 File Offset: 0x000193C1
		private static Delegate GetIsShortcutKey_ILandroid_view_KeyEvent_Handler()
		{
			if (MenuBuilder.cb_isShortcutKey_ILandroid_view_KeyEvent_ == null)
			{
				MenuBuilder.cb_isShortcutKey_ILandroid_view_KeyEvent_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPIL_Z(MenuBuilder.n_IsShortcutKey_ILandroid_view_KeyEvent_));
			}
			return MenuBuilder.cb_isShortcutKey_ILandroid_view_KeyEvent_;
		}

		// Token: 0x06000A6E RID: 2670 RVA: 0x0001B1E8 File Offset: 0x000193E8
		private static bool n_IsShortcutKey_ILandroid_view_KeyEvent_(IntPtr jnienv, IntPtr native__this, int native_keyCode, IntPtr native_e)
		{
			MenuBuilder @object = Java.Lang.Object.GetObject<MenuBuilder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			KeyEvent object2 = Java.Lang.Object.GetObject<KeyEvent>(native_e, JniHandleOwnership.DoNotTransfer);
			return @object.IsShortcutKey((Keycode)native_keyCode, object2);
		}

		// Token: 0x06000A6F RID: 2671 RVA: 0x0001B210 File Offset: 0x00019410
		[Register("isShortcutKey", "(ILandroid/view/KeyEvent;)Z", "GetIsShortcutKey_ILandroid_view_KeyEvent_Handler")]
		public unsafe virtual bool IsShortcutKey([GeneratedEnum] Keycode keyCode, KeyEvent e)
		{
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((int)keyCode);
				ptr[1] = new JniArgumentValue((e == null) ? IntPtr.Zero : e.Handle);
				result = MenuBuilder._members.InstanceMethods.InvokeVirtualBooleanMethod("isShortcutKey.(ILandroid/view/KeyEvent;)Z", this, ptr);
			}
			finally
			{
				GC.KeepAlive(e);
			}
			return result;
		}

		// Token: 0x06000A70 RID: 2672 RVA: 0x0001B288 File Offset: 0x00019488
		private static Delegate GetOnItemsChanged_ZHandler()
		{
			if (MenuBuilder.cb_onItemsChanged_Z == null)
			{
				MenuBuilder.cb_onItemsChanged_Z = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPZ_V(MenuBuilder.n_OnItemsChanged_Z));
			}
			return MenuBuilder.cb_onItemsChanged_Z;
		}

		// Token: 0x06000A71 RID: 2673 RVA: 0x0001B2AC File Offset: 0x000194AC
		private static void n_OnItemsChanged_Z(IntPtr jnienv, IntPtr native__this, bool structureChanged)
		{
			Java.Lang.Object.GetObject<MenuBuilder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).OnItemsChanged(structureChanged);
		}

		// Token: 0x06000A72 RID: 2674 RVA: 0x0001B2BC File Offset: 0x000194BC
		[Register("onItemsChanged", "(Z)V", "GetOnItemsChanged_ZHandler")]
		public unsafe virtual void OnItemsChanged(bool structureChanged)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(structureChanged);
			MenuBuilder._members.InstanceMethods.InvokeVirtualVoidMethod("onItemsChanged.(Z)V", this, ptr);
		}

		// Token: 0x06000A73 RID: 2675 RVA: 0x0001B2F7 File Offset: 0x000194F7
		private static Delegate GetPerformIdentifierAction_IIHandler()
		{
			if (MenuBuilder.cb_performIdentifierAction_II == null)
			{
				MenuBuilder.cb_performIdentifierAction_II = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPII_Z(MenuBuilder.n_PerformIdentifierAction_II));
			}
			return MenuBuilder.cb_performIdentifierAction_II;
		}

		// Token: 0x06000A74 RID: 2676 RVA: 0x0001B31C File Offset: 0x0001951C
		private static bool n_PerformIdentifierAction_II(IntPtr jnienv, IntPtr native__this, int id, int native_flags)
		{
			return Java.Lang.Object.GetObject<MenuBuilder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).PerformIdentifierAction(id, (MenuPerformFlags)native_flags);
		}

		// Token: 0x06000A75 RID: 2677 RVA: 0x0001B33C File Offset: 0x0001953C
		[Register("performIdentifierAction", "(II)Z", "GetPerformIdentifierAction_IIHandler")]
		public unsafe virtual bool PerformIdentifierAction(int id, [GeneratedEnum] MenuPerformFlags flags)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(id);
			ptr[1] = new JniArgumentValue((int)flags);
			return MenuBuilder._members.InstanceMethods.InvokeVirtualBooleanMethod("performIdentifierAction.(II)Z", this, ptr);
		}

		// Token: 0x06000A76 RID: 2678 RVA: 0x0001B38A File Offset: 0x0001958A
		private static Delegate GetPerformItemAction_Landroid_view_MenuItem_Landroidx_appcompat_view_menu_MenuPresenter_IHandler()
		{
			if (MenuBuilder.cb_performItemAction_Landroid_view_MenuItem_Landroidx_appcompat_view_menu_MenuPresenter_I == null)
			{
				MenuBuilder.cb_performItemAction_Landroid_view_MenuItem_Landroidx_appcompat_view_menu_MenuPresenter_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLLI_Z(MenuBuilder.n_PerformItemAction_Landroid_view_MenuItem_Landroidx_appcompat_view_menu_MenuPresenter_I));
			}
			return MenuBuilder.cb_performItemAction_Landroid_view_MenuItem_Landroidx_appcompat_view_menu_MenuPresenter_I;
		}

		// Token: 0x06000A77 RID: 2679 RVA: 0x0001B3B0 File Offset: 0x000195B0
		private static bool n_PerformItemAction_Landroid_view_MenuItem_Landroidx_appcompat_view_menu_MenuPresenter_I(IntPtr jnienv, IntPtr native__this, IntPtr native_item, IntPtr native_preferredPresenter, int flags)
		{
			MenuBuilder @object = Java.Lang.Object.GetObject<MenuBuilder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IMenuItem object2 = Java.Lang.Object.GetObject<IMenuItem>(native_item, JniHandleOwnership.DoNotTransfer);
			IMenuPresenter object3 = Java.Lang.Object.GetObject<IMenuPresenter>(native_preferredPresenter, JniHandleOwnership.DoNotTransfer);
			return @object.PerformItemAction(object2, object3, flags);
		}

		// Token: 0x06000A78 RID: 2680 RVA: 0x0001B3E0 File Offset: 0x000195E0
		[Register("performItemAction", "(Landroid/view/MenuItem;Landroidx/appcompat/view/menu/MenuPresenter;I)Z", "GetPerformItemAction_Landroid_view_MenuItem_Landroidx_appcompat_view_menu_MenuPresenter_IHandler")]
		public unsafe virtual bool PerformItemAction(IMenuItem item, IMenuPresenter preferredPresenter, int flags)
		{
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((item == null) ? IntPtr.Zero : ((Java.Lang.Object)item).Handle);
				ptr[1] = new JniArgumentValue((preferredPresenter == null) ? IntPtr.Zero : ((Java.Lang.Object)preferredPresenter).Handle);
				ptr[2] = new JniArgumentValue(flags);
				result = MenuBuilder._members.InstanceMethods.InvokeVirtualBooleanMethod("performItemAction.(Landroid/view/MenuItem;Landroidx/appcompat/view/menu/MenuPresenter;I)Z", this, ptr);
			}
			finally
			{
				GC.KeepAlive(item);
				GC.KeepAlive(preferredPresenter);
			}
			return result;
		}

		// Token: 0x06000A79 RID: 2681 RVA: 0x0001B490 File Offset: 0x00019690
		private static Delegate GetPerformItemAction_Landroid_view_MenuItem_IHandler()
		{
			if (MenuBuilder.cb_performItemAction_Landroid_view_MenuItem_I == null)
			{
				MenuBuilder.cb_performItemAction_Landroid_view_MenuItem_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLI_Z(MenuBuilder.n_PerformItemAction_Landroid_view_MenuItem_I));
			}
			return MenuBuilder.cb_performItemAction_Landroid_view_MenuItem_I;
		}

		// Token: 0x06000A7A RID: 2682 RVA: 0x0001B4B4 File Offset: 0x000196B4
		private static bool n_PerformItemAction_Landroid_view_MenuItem_I(IntPtr jnienv, IntPtr native__this, IntPtr native_item, int flags)
		{
			MenuBuilder @object = Java.Lang.Object.GetObject<MenuBuilder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IMenuItem object2 = Java.Lang.Object.GetObject<IMenuItem>(native_item, JniHandleOwnership.DoNotTransfer);
			return @object.PerformItemAction(object2, flags);
		}

		// Token: 0x06000A7B RID: 2683 RVA: 0x0001B4D8 File Offset: 0x000196D8
		[Register("performItemAction", "(Landroid/view/MenuItem;I)Z", "GetPerformItemAction_Landroid_view_MenuItem_IHandler")]
		public unsafe virtual bool PerformItemAction(IMenuItem item, int flags)
		{
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((item == null) ? IntPtr.Zero : ((Java.Lang.Object)item).Handle);
				ptr[1] = new JniArgumentValue(flags);
				result = MenuBuilder._members.InstanceMethods.InvokeVirtualBooleanMethod("performItemAction.(Landroid/view/MenuItem;I)Z", this, ptr);
			}
			finally
			{
				GC.KeepAlive(item);
			}
			return result;
		}

		// Token: 0x06000A7C RID: 2684 RVA: 0x0001B558 File Offset: 0x00019758
		private static Delegate GetPerformShortcut_ILandroid_view_KeyEvent_IHandler()
		{
			if (MenuBuilder.cb_performShortcut_ILandroid_view_KeyEvent_I == null)
			{
				MenuBuilder.cb_performShortcut_ILandroid_view_KeyEvent_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPILI_Z(MenuBuilder.n_PerformShortcut_ILandroid_view_KeyEvent_I));
			}
			return MenuBuilder.cb_performShortcut_ILandroid_view_KeyEvent_I;
		}

		// Token: 0x06000A7D RID: 2685 RVA: 0x0001B57C File Offset: 0x0001977C
		private static bool n_PerformShortcut_ILandroid_view_KeyEvent_I(IntPtr jnienv, IntPtr native__this, int native_keyCode, IntPtr native_e, int native_flags)
		{
			MenuBuilder @object = Java.Lang.Object.GetObject<MenuBuilder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			KeyEvent object2 = Java.Lang.Object.GetObject<KeyEvent>(native_e, JniHandleOwnership.DoNotTransfer);
			return @object.PerformShortcut((Keycode)native_keyCode, object2, (MenuPerformFlags)native_flags);
		}

		// Token: 0x06000A7E RID: 2686 RVA: 0x0001B5A8 File Offset: 0x000197A8
		[Register("performShortcut", "(ILandroid/view/KeyEvent;I)Z", "GetPerformShortcut_ILandroid_view_KeyEvent_IHandler")]
		public unsafe virtual bool PerformShortcut([GeneratedEnum] Keycode keyCode, KeyEvent e, [GeneratedEnum] MenuPerformFlags flags)
		{
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((int)keyCode);
				ptr[1] = new JniArgumentValue((e == null) ? IntPtr.Zero : e.Handle);
				ptr[2] = new JniArgumentValue((int)flags);
				result = MenuBuilder._members.InstanceMethods.InvokeVirtualBooleanMethod("performShortcut.(ILandroid/view/KeyEvent;I)Z", this, ptr);
			}
			finally
			{
				GC.KeepAlive(e);
			}
			return result;
		}

		// Token: 0x06000A7F RID: 2687 RVA: 0x0001B638 File Offset: 0x00019838
		private static Delegate GetRemoveGroup_IHandler()
		{
			if (MenuBuilder.cb_removeGroup_I == null)
			{
				MenuBuilder.cb_removeGroup_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_V(MenuBuilder.n_RemoveGroup_I));
			}
			return MenuBuilder.cb_removeGroup_I;
		}

		// Token: 0x06000A80 RID: 2688 RVA: 0x0001B65C File Offset: 0x0001985C
		private static void n_RemoveGroup_I(IntPtr jnienv, IntPtr native__this, int group)
		{
			Java.Lang.Object.GetObject<MenuBuilder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).RemoveGroup(group);
		}

		// Token: 0x06000A81 RID: 2689 RVA: 0x0001B66C File Offset: 0x0001986C
		[Register("removeGroup", "(I)V", "GetRemoveGroup_IHandler")]
		public unsafe virtual void RemoveGroup(int group)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(group);
			MenuBuilder._members.InstanceMethods.InvokeVirtualVoidMethod("removeGroup.(I)V", this, ptr);
		}

		// Token: 0x06000A82 RID: 2690 RVA: 0x0001B6A7 File Offset: 0x000198A7
		private static Delegate GetRemoveItem_IHandler()
		{
			if (MenuBuilder.cb_removeItem_I == null)
			{
				MenuBuilder.cb_removeItem_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_V(MenuBuilder.n_RemoveItem_I));
			}
			return MenuBuilder.cb_removeItem_I;
		}

		// Token: 0x06000A83 RID: 2691 RVA: 0x0001B6CB File Offset: 0x000198CB
		private static void n_RemoveItem_I(IntPtr jnienv, IntPtr native__this, int id)
		{
			Java.Lang.Object.GetObject<MenuBuilder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).RemoveItem(id);
		}

		// Token: 0x06000A84 RID: 2692 RVA: 0x0001B6DC File Offset: 0x000198DC
		[Register("removeItem", "(I)V", "GetRemoveItem_IHandler")]
		public unsafe virtual void RemoveItem(int id)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(id);
			MenuBuilder._members.InstanceMethods.InvokeVirtualVoidMethod("removeItem.(I)V", this, ptr);
		}

		// Token: 0x06000A85 RID: 2693 RVA: 0x0001B717 File Offset: 0x00019917
		private static Delegate GetRemoveItemAt_IHandler()
		{
			if (MenuBuilder.cb_removeItemAt_I == null)
			{
				MenuBuilder.cb_removeItemAt_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_V(MenuBuilder.n_RemoveItemAt_I));
			}
			return MenuBuilder.cb_removeItemAt_I;
		}

		// Token: 0x06000A86 RID: 2694 RVA: 0x0001B73B File Offset: 0x0001993B
		private static void n_RemoveItemAt_I(IntPtr jnienv, IntPtr native__this, int index)
		{
			Java.Lang.Object.GetObject<MenuBuilder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).RemoveItemAt(index);
		}

		// Token: 0x06000A87 RID: 2695 RVA: 0x0001B74C File Offset: 0x0001994C
		[Register("removeItemAt", "(I)V", "GetRemoveItemAt_IHandler")]
		public unsafe virtual void RemoveItemAt(int index)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(index);
			MenuBuilder._members.InstanceMethods.InvokeVirtualVoidMethod("removeItemAt.(I)V", this, ptr);
		}

		// Token: 0x06000A88 RID: 2696 RVA: 0x0001B787 File Offset: 0x00019987
		private static Delegate GetRemoveMenuPresenter_Landroidx_appcompat_view_menu_MenuPresenter_Handler()
		{
			if (MenuBuilder.cb_removeMenuPresenter_Landroidx_appcompat_view_menu_MenuPresenter_ == null)
			{
				MenuBuilder.cb_removeMenuPresenter_Landroidx_appcompat_view_menu_MenuPresenter_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(MenuBuilder.n_RemoveMenuPresenter_Landroidx_appcompat_view_menu_MenuPresenter_));
			}
			return MenuBuilder.cb_removeMenuPresenter_Landroidx_appcompat_view_menu_MenuPresenter_;
		}

		// Token: 0x06000A89 RID: 2697 RVA: 0x0001B7AC File Offset: 0x000199AC
		private static void n_RemoveMenuPresenter_Landroidx_appcompat_view_menu_MenuPresenter_(IntPtr jnienv, IntPtr native__this, IntPtr native_presenter)
		{
			MenuBuilder @object = Java.Lang.Object.GetObject<MenuBuilder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IMenuPresenter object2 = Java.Lang.Object.GetObject<IMenuPresenter>(native_presenter, JniHandleOwnership.DoNotTransfer);
			@object.RemoveMenuPresenter(object2);
		}

		// Token: 0x06000A8A RID: 2698 RVA: 0x0001B7D0 File Offset: 0x000199D0
		[Register("removeMenuPresenter", "(Landroidx/appcompat/view/menu/MenuPresenter;)V", "GetRemoveMenuPresenter_Landroidx_appcompat_view_menu_MenuPresenter_Handler")]
		public unsafe virtual void RemoveMenuPresenter(IMenuPresenter presenter)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((presenter == null) ? IntPtr.Zero : ((Java.Lang.Object)presenter).Handle);
				MenuBuilder._members.InstanceMethods.InvokeVirtualVoidMethod("removeMenuPresenter.(Landroidx/appcompat/view/menu/MenuPresenter;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(presenter);
			}
		}

		// Token: 0x06000A8B RID: 2699 RVA: 0x0001B838 File Offset: 0x00019A38
		private static Delegate GetRestoreActionViewStates_Landroid_os_Bundle_Handler()
		{
			if (MenuBuilder.cb_restoreActionViewStates_Landroid_os_Bundle_ == null)
			{
				MenuBuilder.cb_restoreActionViewStates_Landroid_os_Bundle_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(MenuBuilder.n_RestoreActionViewStates_Landroid_os_Bundle_));
			}
			return MenuBuilder.cb_restoreActionViewStates_Landroid_os_Bundle_;
		}

		// Token: 0x06000A8C RID: 2700 RVA: 0x0001B85C File Offset: 0x00019A5C
		private static void n_RestoreActionViewStates_Landroid_os_Bundle_(IntPtr jnienv, IntPtr native__this, IntPtr native_states)
		{
			MenuBuilder @object = Java.Lang.Object.GetObject<MenuBuilder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Bundle object2 = Java.Lang.Object.GetObject<Bundle>(native_states, JniHandleOwnership.DoNotTransfer);
			@object.RestoreActionViewStates(object2);
		}

		// Token: 0x06000A8D RID: 2701 RVA: 0x0001B880 File Offset: 0x00019A80
		[Register("restoreActionViewStates", "(Landroid/os/Bundle;)V", "GetRestoreActionViewStates_Landroid_os_Bundle_Handler")]
		public unsafe virtual void RestoreActionViewStates(Bundle states)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((states == null) ? IntPtr.Zero : states.Handle);
				MenuBuilder._members.InstanceMethods.InvokeVirtualVoidMethod("restoreActionViewStates.(Landroid/os/Bundle;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(states);
			}
		}

		// Token: 0x06000A8E RID: 2702 RVA: 0x0001B8E4 File Offset: 0x00019AE4
		private static Delegate GetRestorePresenterStates_Landroid_os_Bundle_Handler()
		{
			if (MenuBuilder.cb_restorePresenterStates_Landroid_os_Bundle_ == null)
			{
				MenuBuilder.cb_restorePresenterStates_Landroid_os_Bundle_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(MenuBuilder.n_RestorePresenterStates_Landroid_os_Bundle_));
			}
			return MenuBuilder.cb_restorePresenterStates_Landroid_os_Bundle_;
		}

		// Token: 0x06000A8F RID: 2703 RVA: 0x0001B908 File Offset: 0x00019B08
		private static void n_RestorePresenterStates_Landroid_os_Bundle_(IntPtr jnienv, IntPtr native__this, IntPtr native_state)
		{
			MenuBuilder @object = Java.Lang.Object.GetObject<MenuBuilder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Bundle object2 = Java.Lang.Object.GetObject<Bundle>(native_state, JniHandleOwnership.DoNotTransfer);
			@object.RestorePresenterStates(object2);
		}

		// Token: 0x06000A90 RID: 2704 RVA: 0x0001B92C File Offset: 0x00019B2C
		[Register("restorePresenterStates", "(Landroid/os/Bundle;)V", "GetRestorePresenterStates_Landroid_os_Bundle_Handler")]
		public unsafe virtual void RestorePresenterStates(Bundle state)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((state == null) ? IntPtr.Zero : state.Handle);
				MenuBuilder._members.InstanceMethods.InvokeVirtualVoidMethod("restorePresenterStates.(Landroid/os/Bundle;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(state);
			}
		}

		// Token: 0x06000A91 RID: 2705 RVA: 0x0001B990 File Offset: 0x00019B90
		private static Delegate GetSaveActionViewStates_Landroid_os_Bundle_Handler()
		{
			if (MenuBuilder.cb_saveActionViewStates_Landroid_os_Bundle_ == null)
			{
				MenuBuilder.cb_saveActionViewStates_Landroid_os_Bundle_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(MenuBuilder.n_SaveActionViewStates_Landroid_os_Bundle_));
			}
			return MenuBuilder.cb_saveActionViewStates_Landroid_os_Bundle_;
		}

		// Token: 0x06000A92 RID: 2706 RVA: 0x0001B9B4 File Offset: 0x00019BB4
		private static void n_SaveActionViewStates_Landroid_os_Bundle_(IntPtr jnienv, IntPtr native__this, IntPtr native_outStates)
		{
			MenuBuilder @object = Java.Lang.Object.GetObject<MenuBuilder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Bundle object2 = Java.Lang.Object.GetObject<Bundle>(native_outStates, JniHandleOwnership.DoNotTransfer);
			@object.SaveActionViewStates(object2);
		}

		// Token: 0x06000A93 RID: 2707 RVA: 0x0001B9D8 File Offset: 0x00019BD8
		[Register("saveActionViewStates", "(Landroid/os/Bundle;)V", "GetSaveActionViewStates_Landroid_os_Bundle_Handler")]
		public unsafe virtual void SaveActionViewStates(Bundle outStates)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((outStates == null) ? IntPtr.Zero : outStates.Handle);
				MenuBuilder._members.InstanceMethods.InvokeVirtualVoidMethod("saveActionViewStates.(Landroid/os/Bundle;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(outStates);
			}
		}

		// Token: 0x06000A94 RID: 2708 RVA: 0x0001BA3C File Offset: 0x00019C3C
		private static Delegate GetSavePresenterStates_Landroid_os_Bundle_Handler()
		{
			if (MenuBuilder.cb_savePresenterStates_Landroid_os_Bundle_ == null)
			{
				MenuBuilder.cb_savePresenterStates_Landroid_os_Bundle_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(MenuBuilder.n_SavePresenterStates_Landroid_os_Bundle_));
			}
			return MenuBuilder.cb_savePresenterStates_Landroid_os_Bundle_;
		}

		// Token: 0x06000A95 RID: 2709 RVA: 0x0001BA60 File Offset: 0x00019C60
		private static void n_SavePresenterStates_Landroid_os_Bundle_(IntPtr jnienv, IntPtr native__this, IntPtr native_outState)
		{
			MenuBuilder @object = Java.Lang.Object.GetObject<MenuBuilder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Bundle object2 = Java.Lang.Object.GetObject<Bundle>(native_outState, JniHandleOwnership.DoNotTransfer);
			@object.SavePresenterStates(object2);
		}

		// Token: 0x06000A96 RID: 2710 RVA: 0x0001BA84 File Offset: 0x00019C84
		[Register("savePresenterStates", "(Landroid/os/Bundle;)V", "GetSavePresenterStates_Landroid_os_Bundle_Handler")]
		public unsafe virtual void SavePresenterStates(Bundle outState)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((outState == null) ? IntPtr.Zero : outState.Handle);
				MenuBuilder._members.InstanceMethods.InvokeVirtualVoidMethod("savePresenterStates.(Landroid/os/Bundle;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(outState);
			}
		}

		// Token: 0x06000A97 RID: 2711 RVA: 0x0001BAE8 File Offset: 0x00019CE8
		private static Delegate GetSetCallback_Landroidx_appcompat_view_menu_MenuBuilder_Callback_Handler()
		{
			if (MenuBuilder.cb_setCallback_Landroidx_appcompat_view_menu_MenuBuilder_Callback_ == null)
			{
				MenuBuilder.cb_setCallback_Landroidx_appcompat_view_menu_MenuBuilder_Callback_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(MenuBuilder.n_SetCallback_Landroidx_appcompat_view_menu_MenuBuilder_Callback_));
			}
			return MenuBuilder.cb_setCallback_Landroidx_appcompat_view_menu_MenuBuilder_Callback_;
		}

		// Token: 0x06000A98 RID: 2712 RVA: 0x0001BB0C File Offset: 0x00019D0C
		private static void n_SetCallback_Landroidx_appcompat_view_menu_MenuBuilder_Callback_(IntPtr jnienv, IntPtr native__this, IntPtr native_cb)
		{
			MenuBuilder @object = Java.Lang.Object.GetObject<MenuBuilder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			MenuBuilder.ICallback object2 = Java.Lang.Object.GetObject<MenuBuilder.ICallback>(native_cb, JniHandleOwnership.DoNotTransfer);
			@object.SetCallback(object2);
		}

		// Token: 0x06000A99 RID: 2713 RVA: 0x0001BB30 File Offset: 0x00019D30
		[Register("setCallback", "(Landroidx/appcompat/view/menu/MenuBuilder$Callback;)V", "GetSetCallback_Landroidx_appcompat_view_menu_MenuBuilder_Callback_Handler")]
		public unsafe virtual void SetCallback(MenuBuilder.ICallback cb)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((cb == null) ? IntPtr.Zero : ((Java.Lang.Object)cb).Handle);
				MenuBuilder._members.InstanceMethods.InvokeVirtualVoidMethod("setCallback.(Landroidx/appcompat/view/menu/MenuBuilder$Callback;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(cb);
			}
		}

		// Token: 0x06000A9A RID: 2714 RVA: 0x0001BB98 File Offset: 0x00019D98
		private static Delegate GetSetCurrentMenuInfo_Landroid_view_ContextMenu_ContextMenuInfo_Handler()
		{
			if (MenuBuilder.cb_setCurrentMenuInfo_Landroid_view_ContextMenu_ContextMenuInfo_ == null)
			{
				MenuBuilder.cb_setCurrentMenuInfo_Landroid_view_ContextMenu_ContextMenuInfo_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(MenuBuilder.n_SetCurrentMenuInfo_Landroid_view_ContextMenu_ContextMenuInfo_));
			}
			return MenuBuilder.cb_setCurrentMenuInfo_Landroid_view_ContextMenu_ContextMenuInfo_;
		}

		// Token: 0x06000A9B RID: 2715 RVA: 0x0001BBBC File Offset: 0x00019DBC
		private static void n_SetCurrentMenuInfo_Landroid_view_ContextMenu_ContextMenuInfo_(IntPtr jnienv, IntPtr native__this, IntPtr native_menuInfo)
		{
			MenuBuilder @object = Java.Lang.Object.GetObject<MenuBuilder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IContextMenuContextMenuInfo object2 = Java.Lang.Object.GetObject<IContextMenuContextMenuInfo>(native_menuInfo, JniHandleOwnership.DoNotTransfer);
			@object.SetCurrentMenuInfo(object2);
		}

		// Token: 0x06000A9C RID: 2716 RVA: 0x0001BBE0 File Offset: 0x00019DE0
		[Register("setCurrentMenuInfo", "(Landroid/view/ContextMenu$ContextMenuInfo;)V", "GetSetCurrentMenuInfo_Landroid_view_ContextMenu_ContextMenuInfo_Handler")]
		public unsafe virtual void SetCurrentMenuInfo(IContextMenuContextMenuInfo menuInfo)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((menuInfo == null) ? IntPtr.Zero : ((Java.Lang.Object)menuInfo).Handle);
				MenuBuilder._members.InstanceMethods.InvokeVirtualVoidMethod("setCurrentMenuInfo.(Landroid/view/ContextMenu$ContextMenuInfo;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(menuInfo);
			}
		}

		// Token: 0x06000A9D RID: 2717 RVA: 0x0001BC48 File Offset: 0x00019E48
		private static Delegate GetSetDefaultShowAsAction_IHandler()
		{
			if (MenuBuilder.cb_setDefaultShowAsAction_I == null)
			{
				MenuBuilder.cb_setDefaultShowAsAction_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_L(MenuBuilder.n_SetDefaultShowAsAction_I));
			}
			return MenuBuilder.cb_setDefaultShowAsAction_I;
		}

		// Token: 0x06000A9E RID: 2718 RVA: 0x0001BC6C File Offset: 0x00019E6C
		private static IntPtr n_SetDefaultShowAsAction_I(IntPtr jnienv, IntPtr native__this, int defaultShowAsAction)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<MenuBuilder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SetDefaultShowAsAction(defaultShowAsAction));
		}

		// Token: 0x06000A9F RID: 2719 RVA: 0x0001BC84 File Offset: 0x00019E84
		[Register("setDefaultShowAsAction", "(I)Landroidx/appcompat/view/menu/MenuBuilder;", "GetSetDefaultShowAsAction_IHandler")]
		public unsafe virtual MenuBuilder SetDefaultShowAsAction(int defaultShowAsAction)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(defaultShowAsAction);
			return Java.Lang.Object.GetObject<MenuBuilder>(MenuBuilder._members.InstanceMethods.InvokeVirtualObjectMethod("setDefaultShowAsAction.(I)Landroidx/appcompat/view/menu/MenuBuilder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06000AA0 RID: 2720 RVA: 0x0001BCCD File Offset: 0x00019ECD
		private static Delegate GetSetGroupCheckable_IZZHandler()
		{
			if (MenuBuilder.cb_setGroupCheckable_IZZ == null)
			{
				MenuBuilder.cb_setGroupCheckable_IZZ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPIZZ_V(MenuBuilder.n_SetGroupCheckable_IZZ));
			}
			return MenuBuilder.cb_setGroupCheckable_IZZ;
		}

		// Token: 0x06000AA1 RID: 2721 RVA: 0x0001BCF1 File Offset: 0x00019EF1
		private static void n_SetGroupCheckable_IZZ(IntPtr jnienv, IntPtr native__this, int group, bool checkable, bool exclusive)
		{
			Java.Lang.Object.GetObject<MenuBuilder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SetGroupCheckable(group, checkable, exclusive);
		}

		// Token: 0x06000AA2 RID: 2722 RVA: 0x0001BD04 File Offset: 0x00019F04
		[Register("setGroupCheckable", "(IZZ)V", "GetSetGroupCheckable_IZZHandler")]
		public unsafe virtual void SetGroupCheckable(int group, bool checkable, bool exclusive)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(group);
			ptr[1] = new JniArgumentValue(checkable);
			ptr[2] = new JniArgumentValue(exclusive);
			MenuBuilder._members.InstanceMethods.InvokeVirtualVoidMethod("setGroupCheckable.(IZZ)V", this, ptr);
		}

		// Token: 0x06000AA3 RID: 2723 RVA: 0x0001BD68 File Offset: 0x00019F68
		private static Delegate GetSetGroupEnabled_IZHandler()
		{
			if (MenuBuilder.cb_setGroupEnabled_IZ == null)
			{
				MenuBuilder.cb_setGroupEnabled_IZ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPIZ_V(MenuBuilder.n_SetGroupEnabled_IZ));
			}
			return MenuBuilder.cb_setGroupEnabled_IZ;
		}

		// Token: 0x06000AA4 RID: 2724 RVA: 0x0001BD8C File Offset: 0x00019F8C
		private static void n_SetGroupEnabled_IZ(IntPtr jnienv, IntPtr native__this, int group, bool enabled)
		{
			Java.Lang.Object.GetObject<MenuBuilder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SetGroupEnabled(group, enabled);
		}

		// Token: 0x06000AA5 RID: 2725 RVA: 0x0001BDA0 File Offset: 0x00019FA0
		[Register("setGroupEnabled", "(IZ)V", "GetSetGroupEnabled_IZHandler")]
		public unsafe virtual void SetGroupEnabled(int group, bool enabled)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(group);
			ptr[1] = new JniArgumentValue(enabled);
			MenuBuilder._members.InstanceMethods.InvokeVirtualVoidMethod("setGroupEnabled.(IZ)V", this, ptr);
		}

		// Token: 0x06000AA6 RID: 2726 RVA: 0x0001BDEE File Offset: 0x00019FEE
		private static Delegate GetSetGroupVisible_IZHandler()
		{
			if (MenuBuilder.cb_setGroupVisible_IZ == null)
			{
				MenuBuilder.cb_setGroupVisible_IZ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPIZ_V(MenuBuilder.n_SetGroupVisible_IZ));
			}
			return MenuBuilder.cb_setGroupVisible_IZ;
		}

		// Token: 0x06000AA7 RID: 2727 RVA: 0x0001BE12 File Offset: 0x0001A012
		private static void n_SetGroupVisible_IZ(IntPtr jnienv, IntPtr native__this, int group, bool visible)
		{
			Java.Lang.Object.GetObject<MenuBuilder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SetGroupVisible(group, visible);
		}

		// Token: 0x06000AA8 RID: 2728 RVA: 0x0001BE24 File Offset: 0x0001A024
		[Register("setGroupVisible", "(IZ)V", "GetSetGroupVisible_IZHandler")]
		public unsafe virtual void SetGroupVisible(int group, bool visible)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(group);
			ptr[1] = new JniArgumentValue(visible);
			MenuBuilder._members.InstanceMethods.InvokeVirtualVoidMethod("setGroupVisible.(IZ)V", this, ptr);
		}

		// Token: 0x06000AA9 RID: 2729 RVA: 0x0001BE72 File Offset: 0x0001A072
		private static Delegate GetSetHeaderIconInt_Landroid_graphics_drawable_Drawable_Handler()
		{
			if (MenuBuilder.cb_setHeaderIconInt_Landroid_graphics_drawable_Drawable_ == null)
			{
				MenuBuilder.cb_setHeaderIconInt_Landroid_graphics_drawable_Drawable_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(MenuBuilder.n_SetHeaderIconInt_Landroid_graphics_drawable_Drawable_));
			}
			return MenuBuilder.cb_setHeaderIconInt_Landroid_graphics_drawable_Drawable_;
		}

		// Token: 0x06000AAA RID: 2730 RVA: 0x0001BE98 File Offset: 0x0001A098
		private static IntPtr n_SetHeaderIconInt_Landroid_graphics_drawable_Drawable_(IntPtr jnienv, IntPtr native__this, IntPtr native_icon)
		{
			MenuBuilder @object = Java.Lang.Object.GetObject<MenuBuilder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Drawable object2 = Java.Lang.Object.GetObject<Drawable>(native_icon, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.SetHeaderIconInt(object2));
		}

		// Token: 0x06000AAB RID: 2731 RVA: 0x0001BEC0 File Offset: 0x0001A0C0
		[Register("setHeaderIconInt", "(Landroid/graphics/drawable/Drawable;)Landroidx/appcompat/view/menu/MenuBuilder;", "GetSetHeaderIconInt_Landroid_graphics_drawable_Drawable_Handler")]
		protected unsafe virtual MenuBuilder SetHeaderIconInt(Drawable icon)
		{
			MenuBuilder @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((icon == null) ? IntPtr.Zero : icon.Handle);
				@object = Java.Lang.Object.GetObject<MenuBuilder>(MenuBuilder._members.InstanceMethods.InvokeVirtualObjectMethod("setHeaderIconInt.(Landroid/graphics/drawable/Drawable;)Landroidx/appcompat/view/menu/MenuBuilder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(icon);
			}
			return @object;
		}

		// Token: 0x06000AAC RID: 2732 RVA: 0x0001BF34 File Offset: 0x0001A134
		private static Delegate GetSetHeaderIconInt_IHandler()
		{
			if (MenuBuilder.cb_setHeaderIconInt_I == null)
			{
				MenuBuilder.cb_setHeaderIconInt_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_L(MenuBuilder.n_SetHeaderIconInt_I));
			}
			return MenuBuilder.cb_setHeaderIconInt_I;
		}

		// Token: 0x06000AAD RID: 2733 RVA: 0x0001BF58 File Offset: 0x0001A158
		private static IntPtr n_SetHeaderIconInt_I(IntPtr jnienv, IntPtr native__this, int iconRes)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<MenuBuilder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SetHeaderIconInt(iconRes));
		}

		// Token: 0x06000AAE RID: 2734 RVA: 0x0001BF70 File Offset: 0x0001A170
		[Register("setHeaderIconInt", "(I)Landroidx/appcompat/view/menu/MenuBuilder;", "GetSetHeaderIconInt_IHandler")]
		protected unsafe virtual MenuBuilder SetHeaderIconInt(int iconRes)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(iconRes);
			return Java.Lang.Object.GetObject<MenuBuilder>(MenuBuilder._members.InstanceMethods.InvokeVirtualObjectMethod("setHeaderIconInt.(I)Landroidx/appcompat/view/menu/MenuBuilder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06000AAF RID: 2735 RVA: 0x0001BFB9 File Offset: 0x0001A1B9
		private static Delegate GetSetHeaderTitleInt_IHandler()
		{
			if (MenuBuilder.cb_setHeaderTitleInt_I == null)
			{
				MenuBuilder.cb_setHeaderTitleInt_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_L(MenuBuilder.n_SetHeaderTitleInt_I));
			}
			return MenuBuilder.cb_setHeaderTitleInt_I;
		}

		// Token: 0x06000AB0 RID: 2736 RVA: 0x0001BFDD File Offset: 0x0001A1DD
		private static IntPtr n_SetHeaderTitleInt_I(IntPtr jnienv, IntPtr native__this, int titleRes)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<MenuBuilder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SetHeaderTitleInt(titleRes));
		}

		// Token: 0x06000AB1 RID: 2737 RVA: 0x0001BFF4 File Offset: 0x0001A1F4
		[Register("setHeaderTitleInt", "(I)Landroidx/appcompat/view/menu/MenuBuilder;", "GetSetHeaderTitleInt_IHandler")]
		protected unsafe virtual MenuBuilder SetHeaderTitleInt(int titleRes)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(titleRes);
			return Java.Lang.Object.GetObject<MenuBuilder>(MenuBuilder._members.InstanceMethods.InvokeVirtualObjectMethod("setHeaderTitleInt.(I)Landroidx/appcompat/view/menu/MenuBuilder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06000AB2 RID: 2738 RVA: 0x0001C03D File Offset: 0x0001A23D
		private static Delegate GetSetHeaderTitleInt_Ljava_lang_CharSequence_Handler()
		{
			if (MenuBuilder.cb_setHeaderTitleInt_Ljava_lang_CharSequence_ == null)
			{
				MenuBuilder.cb_setHeaderTitleInt_Ljava_lang_CharSequence_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(MenuBuilder.n_SetHeaderTitleInt_Ljava_lang_CharSequence_));
			}
			return MenuBuilder.cb_setHeaderTitleInt_Ljava_lang_CharSequence_;
		}

		// Token: 0x06000AB3 RID: 2739 RVA: 0x0001C064 File Offset: 0x0001A264
		private static IntPtr n_SetHeaderTitleInt_Ljava_lang_CharSequence_(IntPtr jnienv, IntPtr native__this, IntPtr native_title)
		{
			MenuBuilder @object = Java.Lang.Object.GetObject<MenuBuilder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ICharSequence object2 = Java.Lang.Object.GetObject<ICharSequence>(native_title, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.SetHeaderTitleInt(object2));
		}

		// Token: 0x06000AB4 RID: 2740 RVA: 0x0001C08C File Offset: 0x0001A28C
		[Register("setHeaderTitleInt", "(Ljava/lang/CharSequence;)Landroidx/appcompat/view/menu/MenuBuilder;", "GetSetHeaderTitleInt_Ljava_lang_CharSequence_Handler")]
		protected unsafe virtual MenuBuilder SetHeaderTitleInt(ICharSequence title)
		{
			IntPtr intPtr = CharSequence.ToLocalJniHandle(title);
			MenuBuilder @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<MenuBuilder>(MenuBuilder._members.InstanceMethods.InvokeVirtualObjectMethod("setHeaderTitleInt.(Ljava/lang/CharSequence;)Landroidx/appcompat/view/menu/MenuBuilder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(title);
			}
			return @object;
		}

		// Token: 0x06000AB5 RID: 2741 RVA: 0x0001C100 File Offset: 0x0001A300
		protected MenuBuilder SetHeaderTitleInt(string title)
		{
			Java.Lang.String @string = (title == null) ? null : new Java.Lang.String(title);
			MenuBuilder result = this.SetHeaderTitleInt(@string);
			if (@string != null)
			{
				@string.Dispose();
			}
			return result;
		}

		// Token: 0x06000AB6 RID: 2742 RVA: 0x0001C12A File Offset: 0x0001A32A
		private static Delegate GetSetHeaderViewInt_Landroid_view_View_Handler()
		{
			if (MenuBuilder.cb_setHeaderViewInt_Landroid_view_View_ == null)
			{
				MenuBuilder.cb_setHeaderViewInt_Landroid_view_View_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(MenuBuilder.n_SetHeaderViewInt_Landroid_view_View_));
			}
			return MenuBuilder.cb_setHeaderViewInt_Landroid_view_View_;
		}

		// Token: 0x06000AB7 RID: 2743 RVA: 0x0001C150 File Offset: 0x0001A350
		private static IntPtr n_SetHeaderViewInt_Landroid_view_View_(IntPtr jnienv, IntPtr native__this, IntPtr native_view)
		{
			MenuBuilder @object = Java.Lang.Object.GetObject<MenuBuilder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			View object2 = Java.Lang.Object.GetObject<View>(native_view, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.SetHeaderViewInt(object2));
		}

		// Token: 0x06000AB8 RID: 2744 RVA: 0x0001C178 File Offset: 0x0001A378
		[Register("setHeaderViewInt", "(Landroid/view/View;)Landroidx/appcompat/view/menu/MenuBuilder;", "GetSetHeaderViewInt_Landroid_view_View_Handler")]
		protected unsafe virtual MenuBuilder SetHeaderViewInt(View view)
		{
			MenuBuilder @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((view == null) ? IntPtr.Zero : view.Handle);
				@object = Java.Lang.Object.GetObject<MenuBuilder>(MenuBuilder._members.InstanceMethods.InvokeVirtualObjectMethod("setHeaderViewInt.(Landroid/view/View;)Landroidx/appcompat/view/menu/MenuBuilder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(view);
			}
			return @object;
		}

		// Token: 0x06000AB9 RID: 2745 RVA: 0x0001C1EC File Offset: 0x0001A3EC
		private static Delegate GetSetOptionalIconsVisible_ZHandler()
		{
			if (MenuBuilder.cb_setOptionalIconsVisible_Z == null)
			{
				MenuBuilder.cb_setOptionalIconsVisible_Z = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPZ_V(MenuBuilder.n_SetOptionalIconsVisible_Z));
			}
			return MenuBuilder.cb_setOptionalIconsVisible_Z;
		}

		// Token: 0x06000ABA RID: 2746 RVA: 0x0001C210 File Offset: 0x0001A410
		private static void n_SetOptionalIconsVisible_Z(IntPtr jnienv, IntPtr native__this, bool visible)
		{
			Java.Lang.Object.GetObject<MenuBuilder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SetOptionalIconsVisible(visible);
		}

		// Token: 0x06000ABB RID: 2747 RVA: 0x0001C220 File Offset: 0x0001A420
		[Register("setOptionalIconsVisible", "(Z)V", "GetSetOptionalIconsVisible_ZHandler")]
		public unsafe virtual void SetOptionalIconsVisible(bool visible)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(visible);
			MenuBuilder._members.InstanceMethods.InvokeVirtualVoidMethod("setOptionalIconsVisible.(Z)V", this, ptr);
		}

		// Token: 0x06000ABC RID: 2748 RVA: 0x0001C25B File Offset: 0x0001A45B
		private static Delegate GetSetOverrideVisibleItems_ZHandler()
		{
			if (MenuBuilder.cb_setOverrideVisibleItems_Z == null)
			{
				MenuBuilder.cb_setOverrideVisibleItems_Z = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPZ_V(MenuBuilder.n_SetOverrideVisibleItems_Z));
			}
			return MenuBuilder.cb_setOverrideVisibleItems_Z;
		}

		// Token: 0x06000ABD RID: 2749 RVA: 0x0001C27F File Offset: 0x0001A47F
		private static void n_SetOverrideVisibleItems_Z(IntPtr jnienv, IntPtr native__this, bool @override)
		{
			Java.Lang.Object.GetObject<MenuBuilder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SetOverrideVisibleItems(@override);
		}

		// Token: 0x06000ABE RID: 2750 RVA: 0x0001C290 File Offset: 0x0001A490
		[Register("setOverrideVisibleItems", "(Z)V", "GetSetOverrideVisibleItems_ZHandler")]
		public unsafe virtual void SetOverrideVisibleItems(bool @override)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(@override);
			MenuBuilder._members.InstanceMethods.InvokeVirtualVoidMethod("setOverrideVisibleItems.(Z)V", this, ptr);
		}

		// Token: 0x06000ABF RID: 2751 RVA: 0x0001C2CB File Offset: 0x0001A4CB
		private static Delegate GetSetQwertyMode_ZHandler()
		{
			if (MenuBuilder.cb_setQwertyMode_Z == null)
			{
				MenuBuilder.cb_setQwertyMode_Z = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPZ_V(MenuBuilder.n_SetQwertyMode_Z));
			}
			return MenuBuilder.cb_setQwertyMode_Z;
		}

		// Token: 0x06000AC0 RID: 2752 RVA: 0x0001C2EF File Offset: 0x0001A4EF
		private static void n_SetQwertyMode_Z(IntPtr jnienv, IntPtr native__this, bool isQwerty)
		{
			Java.Lang.Object.GetObject<MenuBuilder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SetQwertyMode(isQwerty);
		}

		// Token: 0x06000AC1 RID: 2753 RVA: 0x0001C300 File Offset: 0x0001A500
		[Register("setQwertyMode", "(Z)V", "GetSetQwertyMode_ZHandler")]
		public unsafe virtual void SetQwertyMode(bool isQwerty)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(isQwerty);
			MenuBuilder._members.InstanceMethods.InvokeVirtualVoidMethod("setQwertyMode.(Z)V", this, ptr);
		}

		// Token: 0x06000AC2 RID: 2754 RVA: 0x0001C33B File Offset: 0x0001A53B
		private static Delegate GetSizeHandler()
		{
			if (MenuBuilder.cb_size == null)
			{
				MenuBuilder.cb_size = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(MenuBuilder.n_Size));
			}
			return MenuBuilder.cb_size;
		}

		// Token: 0x06000AC3 RID: 2755 RVA: 0x0001C35F File Offset: 0x0001A55F
		private static int n_Size(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<MenuBuilder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Size();
		}

		// Token: 0x06000AC4 RID: 2756 RVA: 0x0001C36E File Offset: 0x0001A56E
		[Register("size", "()I", "GetSizeHandler")]
		public virtual int Size()
		{
			return MenuBuilder._members.InstanceMethods.InvokeVirtualInt32Method("size.()I", this, null);
		}

		// Token: 0x06000AC5 RID: 2757 RVA: 0x0001C387 File Offset: 0x0001A587
		private static Delegate GetStartDispatchingItemsChangedHandler()
		{
			if (MenuBuilder.cb_startDispatchingItemsChanged == null)
			{
				MenuBuilder.cb_startDispatchingItemsChanged = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(MenuBuilder.n_StartDispatchingItemsChanged));
			}
			return MenuBuilder.cb_startDispatchingItemsChanged;
		}

		// Token: 0x06000AC6 RID: 2758 RVA: 0x0001C3AB File Offset: 0x0001A5AB
		private static void n_StartDispatchingItemsChanged(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<MenuBuilder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).StartDispatchingItemsChanged();
		}

		// Token: 0x06000AC7 RID: 2759 RVA: 0x0001C3BA File Offset: 0x0001A5BA
		[Register("startDispatchingItemsChanged", "()V", "GetStartDispatchingItemsChangedHandler")]
		public virtual void StartDispatchingItemsChanged()
		{
			MenuBuilder._members.InstanceMethods.InvokeVirtualVoidMethod("startDispatchingItemsChanged.()V", this, null);
		}

		// Token: 0x06000AC8 RID: 2760 RVA: 0x0001C3D3 File Offset: 0x0001A5D3
		private static Delegate GetStopDispatchingItemsChangedHandler()
		{
			if (MenuBuilder.cb_stopDispatchingItemsChanged == null)
			{
				MenuBuilder.cb_stopDispatchingItemsChanged = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(MenuBuilder.n_StopDispatchingItemsChanged));
			}
			return MenuBuilder.cb_stopDispatchingItemsChanged;
		}

		// Token: 0x06000AC9 RID: 2761 RVA: 0x0001C3F7 File Offset: 0x0001A5F7
		private static void n_StopDispatchingItemsChanged(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<MenuBuilder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).StopDispatchingItemsChanged();
		}

		// Token: 0x06000ACA RID: 2762 RVA: 0x0001C406 File Offset: 0x0001A606
		[Register("stopDispatchingItemsChanged", "()V", "GetStopDispatchingItemsChangedHandler")]
		public virtual void StopDispatchingItemsChanged()
		{
			MenuBuilder._members.InstanceMethods.InvokeVirtualVoidMethod("stopDispatchingItemsChanged.()V", this, null);
		}

		// Token: 0x040002EB RID: 747
		private static readonly JniPeerMembers _members = new XAPeerMembers("androidx/appcompat/view/menu/MenuBuilder", typeof(MenuBuilder));

		// Token: 0x040002EC RID: 748
		private static Delegate cb_getActionItems;

		// Token: 0x040002ED RID: 749
		private static Delegate cb_getActionViewStatesKey;

		// Token: 0x040002EE RID: 750
		private static Delegate cb_getContext;

		// Token: 0x040002EF RID: 751
		private static Delegate cb_getExpandedItem;

		// Token: 0x040002F0 RID: 752
		private static Delegate cb_isGroupDividerEnabled;

		// Token: 0x040002F1 RID: 753
		private static Delegate cb_setGroupDividerEnabled_Z;

		// Token: 0x040002F2 RID: 754
		private static Delegate cb_hasVisibleItems;

		// Token: 0x040002F3 RID: 755
		private static Delegate cb_getHeaderIcon;

		// Token: 0x040002F4 RID: 756
		private static Delegate cb_getHeaderTitle;

		// Token: 0x040002F5 RID: 757
		private static Delegate cb_getHeaderView;

		// Token: 0x040002F6 RID: 758
		private static Delegate cb_getNonActionItems;

		// Token: 0x040002F7 RID: 759
		private static Delegate cb_getRootMenu;

		// Token: 0x040002F8 RID: 760
		private static Delegate cb_isShortcutsVisible;

		// Token: 0x040002F9 RID: 761
		private static Delegate cb_setShortcutsVisible_Z;

		// Token: 0x040002FA RID: 762
		private static Delegate cb_getVisibleItems;

		// Token: 0x040002FB RID: 763
		private static Delegate cb_add_I;

		// Token: 0x040002FC RID: 764
		private static Delegate cb_add_IIII;

		// Token: 0x040002FD RID: 765
		private static Delegate cb_add_IIILjava_lang_CharSequence_;

		// Token: 0x040002FE RID: 766
		private static Delegate cb_add_Ljava_lang_CharSequence_;

		// Token: 0x040002FF RID: 767
		private static Delegate cb_addIntentOptions_IIILandroid_content_ComponentName_arrayLandroid_content_Intent_Landroid_content_Intent_IarrayLandroid_view_MenuItem_;

		// Token: 0x04000300 RID: 768
		private static Delegate cb_addInternal_IIILjava_lang_CharSequence_;

		// Token: 0x04000301 RID: 769
		private static Delegate cb_addMenuPresenter_Landroidx_appcompat_view_menu_MenuPresenter_;

		// Token: 0x04000302 RID: 770
		private static Delegate cb_addMenuPresenter_Landroidx_appcompat_view_menu_MenuPresenter_Landroid_content_Context_;

		// Token: 0x04000303 RID: 771
		private static Delegate cb_addSubMenu_I;

		// Token: 0x04000304 RID: 772
		private static Delegate cb_addSubMenu_IIII;

		// Token: 0x04000305 RID: 773
		private static Delegate cb_addSubMenu_IIILjava_lang_CharSequence_;

		// Token: 0x04000306 RID: 774
		private static Delegate cb_addSubMenu_Ljava_lang_CharSequence_;

		// Token: 0x04000307 RID: 775
		private static Delegate cb_changeMenuMode;

		// Token: 0x04000308 RID: 776
		private static Delegate cb_clear;

		// Token: 0x04000309 RID: 777
		private static Delegate cb_clearAll;

		// Token: 0x0400030A RID: 778
		private static Delegate cb_clearHeader;

		// Token: 0x0400030B RID: 779
		private static Delegate cb_close;

		// Token: 0x0400030C RID: 780
		private static Delegate cb_collapseItemActionView_Landroidx_appcompat_view_menu_MenuItemImpl_;

		// Token: 0x0400030D RID: 781
		private static Delegate cb_expandItemActionView_Landroidx_appcompat_view_menu_MenuItemImpl_;

		// Token: 0x0400030E RID: 782
		private static Delegate cb_findGroupIndex_I;

		// Token: 0x0400030F RID: 783
		private static Delegate cb_findGroupIndex_II;

		// Token: 0x04000310 RID: 784
		private static Delegate cb_findItem_I;

		// Token: 0x04000311 RID: 785
		private static Delegate cb_findItemIndex_I;

		// Token: 0x04000312 RID: 786
		private static Delegate cb_flagActionItems;

		// Token: 0x04000313 RID: 787
		private static Delegate cb_getItem_I;

		// Token: 0x04000314 RID: 788
		private static Delegate cb_isShortcutKey_ILandroid_view_KeyEvent_;

		// Token: 0x04000315 RID: 789
		private static Delegate cb_onItemsChanged_Z;

		// Token: 0x04000316 RID: 790
		private static Delegate cb_performIdentifierAction_II;

		// Token: 0x04000317 RID: 791
		private static Delegate cb_performItemAction_Landroid_view_MenuItem_Landroidx_appcompat_view_menu_MenuPresenter_I;

		// Token: 0x04000318 RID: 792
		private static Delegate cb_performItemAction_Landroid_view_MenuItem_I;

		// Token: 0x04000319 RID: 793
		private static Delegate cb_performShortcut_ILandroid_view_KeyEvent_I;

		// Token: 0x0400031A RID: 794
		private static Delegate cb_removeGroup_I;

		// Token: 0x0400031B RID: 795
		private static Delegate cb_removeItem_I;

		// Token: 0x0400031C RID: 796
		private static Delegate cb_removeItemAt_I;

		// Token: 0x0400031D RID: 797
		private static Delegate cb_removeMenuPresenter_Landroidx_appcompat_view_menu_MenuPresenter_;

		// Token: 0x0400031E RID: 798
		private static Delegate cb_restoreActionViewStates_Landroid_os_Bundle_;

		// Token: 0x0400031F RID: 799
		private static Delegate cb_restorePresenterStates_Landroid_os_Bundle_;

		// Token: 0x04000320 RID: 800
		private static Delegate cb_saveActionViewStates_Landroid_os_Bundle_;

		// Token: 0x04000321 RID: 801
		private static Delegate cb_savePresenterStates_Landroid_os_Bundle_;

		// Token: 0x04000322 RID: 802
		private static Delegate cb_setCallback_Landroidx_appcompat_view_menu_MenuBuilder_Callback_;

		// Token: 0x04000323 RID: 803
		private static Delegate cb_setCurrentMenuInfo_Landroid_view_ContextMenu_ContextMenuInfo_;

		// Token: 0x04000324 RID: 804
		private static Delegate cb_setDefaultShowAsAction_I;

		// Token: 0x04000325 RID: 805
		private static Delegate cb_setGroupCheckable_IZZ;

		// Token: 0x04000326 RID: 806
		private static Delegate cb_setGroupEnabled_IZ;

		// Token: 0x04000327 RID: 807
		private static Delegate cb_setGroupVisible_IZ;

		// Token: 0x04000328 RID: 808
		private static Delegate cb_setHeaderIconInt_Landroid_graphics_drawable_Drawable_;

		// Token: 0x04000329 RID: 809
		private static Delegate cb_setHeaderIconInt_I;

		// Token: 0x0400032A RID: 810
		private static Delegate cb_setHeaderTitleInt_I;

		// Token: 0x0400032B RID: 811
		private static Delegate cb_setHeaderTitleInt_Ljava_lang_CharSequence_;

		// Token: 0x0400032C RID: 812
		private static Delegate cb_setHeaderViewInt_Landroid_view_View_;

		// Token: 0x0400032D RID: 813
		private static Delegate cb_setOptionalIconsVisible_Z;

		// Token: 0x0400032E RID: 814
		private static Delegate cb_setOverrideVisibleItems_Z;

		// Token: 0x0400032F RID: 815
		private static Delegate cb_setQwertyMode_Z;

		// Token: 0x04000330 RID: 816
		private static Delegate cb_size;

		// Token: 0x04000331 RID: 817
		private static Delegate cb_startDispatchingItemsChanged;

		// Token: 0x04000332 RID: 818
		private static Delegate cb_stopDispatchingItemsChanged;

		// Token: 0x0200008F RID: 143
		[Register("androidx/appcompat/view/menu/MenuBuilder$Callback", "", "AndroidX.AppCompat.View.Menu.MenuBuilder/ICallbackInvoker")]
		public interface ICallback : IJavaObject, IDisposable, IJavaPeerable
		{
			// Token: 0x06000ACC RID: 2764
			[Register("onMenuItemSelected", "(Landroidx/appcompat/view/menu/MenuBuilder;Landroid/view/MenuItem;)Z", "GetOnMenuItemSelected_Landroidx_appcompat_view_menu_MenuBuilder_Landroid_view_MenuItem_Handler:AndroidX.AppCompat.View.Menu.MenuBuilder/ICallbackInvoker, Xamarin.AndroidX.AppCompat")]
			bool OnMenuItemSelected(MenuBuilder p0, IMenuItem p1);

			// Token: 0x06000ACD RID: 2765
			[Register("onMenuModeChange", "(Landroidx/appcompat/view/menu/MenuBuilder;)V", "GetOnMenuModeChange_Landroidx_appcompat_view_menu_MenuBuilder_Handler:AndroidX.AppCompat.View.Menu.MenuBuilder/ICallbackInvoker, Xamarin.AndroidX.AppCompat")]
			void OnMenuModeChange(MenuBuilder p0);
		}

		// Token: 0x02000090 RID: 144
		[Register("androidx/appcompat/view/menu/MenuBuilder$Callback", DoNotGenerateAcw = true)]
		internal class ICallbackInvoker : Java.Lang.Object, MenuBuilder.ICallback, IJavaObject, IDisposable, IJavaPeerable
		{
			// Token: 0x17000190 RID: 400
			// (get) Token: 0x06000ACE RID: 2766 RVA: 0x0001C43C File Offset: 0x0001A63C
			private static IntPtr java_class_ref
			{
				get
				{
					return MenuBuilder.ICallbackInvoker._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x17000191 RID: 401
			// (get) Token: 0x06000ACF RID: 2767 RVA: 0x0001C460 File Offset: 0x0001A660
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return MenuBuilder.ICallbackInvoker._members;
				}
			}

			// Token: 0x17000192 RID: 402
			// (get) Token: 0x06000AD0 RID: 2768 RVA: 0x0001C467 File Offset: 0x0001A667
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return this.class_ref;
				}
			}

			// Token: 0x17000193 RID: 403
			// (get) Token: 0x06000AD1 RID: 2769 RVA: 0x0001C46F File Offset: 0x0001A66F
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return MenuBuilder.ICallbackInvoker._members.ManagedPeerType;
				}
			}

			// Token: 0x06000AD2 RID: 2770 RVA: 0x0001C47B File Offset: 0x0001A67B
			public static MenuBuilder.ICallback GetObject(IntPtr handle, JniHandleOwnership transfer)
			{
				return Java.Lang.Object.GetObject<MenuBuilder.ICallback>(handle, transfer);
			}

			// Token: 0x06000AD3 RID: 2771 RVA: 0x0001C484 File Offset: 0x0001A684
			private static IntPtr Validate(IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf(handle, MenuBuilder.ICallbackInvoker.java_class_ref))
				{
					throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'androidx.appcompat.view.menu.MenuBuilder.Callback'.");
				}
				return handle;
			}

			// Token: 0x06000AD4 RID: 2772 RVA: 0x0001C4AF File Offset: 0x0001A6AF
			protected override void Dispose(bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
				{
					JNIEnv.DeleteGlobalRef(this.class_ref);
				}
				this.class_ref = IntPtr.Zero;
				base.Dispose(disposing);
			}

			// Token: 0x06000AD5 RID: 2773 RVA: 0x0001C4E0 File Offset: 0x0001A6E0
			public ICallbackInvoker(IntPtr handle, JniHandleOwnership transfer) : base(MenuBuilder.ICallbackInvoker.Validate(handle), transfer)
			{
				IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
				this.class_ref = JNIEnv.NewGlobalRef(objectClass);
				JNIEnv.DeleteLocalRef(objectClass);
			}

			// Token: 0x06000AD6 RID: 2774 RVA: 0x0001C518 File Offset: 0x0001A718
			private static Delegate GetOnMenuItemSelected_Landroidx_appcompat_view_menu_MenuBuilder_Landroid_view_MenuItem_Handler()
			{
				if (MenuBuilder.ICallbackInvoker.cb_onMenuItemSelected_Landroidx_appcompat_view_menu_MenuBuilder_Landroid_view_MenuItem_ == null)
				{
					MenuBuilder.ICallbackInvoker.cb_onMenuItemSelected_Landroidx_appcompat_view_menu_MenuBuilder_Landroid_view_MenuItem_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_Z(MenuBuilder.ICallbackInvoker.n_OnMenuItemSelected_Landroidx_appcompat_view_menu_MenuBuilder_Landroid_view_MenuItem_));
				}
				return MenuBuilder.ICallbackInvoker.cb_onMenuItemSelected_Landroidx_appcompat_view_menu_MenuBuilder_Landroid_view_MenuItem_;
			}

			// Token: 0x06000AD7 RID: 2775 RVA: 0x0001C53C File Offset: 0x0001A73C
			private static bool n_OnMenuItemSelected_Landroidx_appcompat_view_menu_MenuBuilder_Landroid_view_MenuItem_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
			{
				MenuBuilder.ICallback @object = Java.Lang.Object.GetObject<MenuBuilder.ICallback>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				MenuBuilder object2 = Java.Lang.Object.GetObject<MenuBuilder>(native_p0, JniHandleOwnership.DoNotTransfer);
				IMenuItem object3 = Java.Lang.Object.GetObject<IMenuItem>(native_p1, JniHandleOwnership.DoNotTransfer);
				return @object.OnMenuItemSelected(object2, object3);
			}

			// Token: 0x06000AD8 RID: 2776 RVA: 0x0001C568 File Offset: 0x0001A768
			public unsafe bool OnMenuItemSelected(MenuBuilder p0, IMenuItem p1)
			{
				if (this.id_onMenuItemSelected_Landroidx_appcompat_view_menu_MenuBuilder_Landroid_view_MenuItem_ == IntPtr.Zero)
				{
					this.id_onMenuItemSelected_Landroidx_appcompat_view_menu_MenuBuilder_Landroid_view_MenuItem_ = JNIEnv.GetMethodID(this.class_ref, "onMenuItemSelected", "(Landroidx/appcompat/view/menu/MenuBuilder;Landroid/view/MenuItem;)Z");
				}
				JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JValue))];
				*ptr = new JValue((p0 == null) ? IntPtr.Zero : p0.Handle);
				ptr[1] = new JValue((p1 == null) ? IntPtr.Zero : ((Java.Lang.Object)p1).Handle);
				return JNIEnv.CallBooleanMethod(base.Handle, this.id_onMenuItemSelected_Landroidx_appcompat_view_menu_MenuBuilder_Landroid_view_MenuItem_, ptr);
			}

			// Token: 0x06000AD9 RID: 2777 RVA: 0x0001C602 File Offset: 0x0001A802
			private static Delegate GetOnMenuModeChange_Landroidx_appcompat_view_menu_MenuBuilder_Handler()
			{
				if (MenuBuilder.ICallbackInvoker.cb_onMenuModeChange_Landroidx_appcompat_view_menu_MenuBuilder_ == null)
				{
					MenuBuilder.ICallbackInvoker.cb_onMenuModeChange_Landroidx_appcompat_view_menu_MenuBuilder_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(MenuBuilder.ICallbackInvoker.n_OnMenuModeChange_Landroidx_appcompat_view_menu_MenuBuilder_));
				}
				return MenuBuilder.ICallbackInvoker.cb_onMenuModeChange_Landroidx_appcompat_view_menu_MenuBuilder_;
			}

			// Token: 0x06000ADA RID: 2778 RVA: 0x0001C628 File Offset: 0x0001A828
			private static void n_OnMenuModeChange_Landroidx_appcompat_view_menu_MenuBuilder_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				MenuBuilder.ICallback @object = Java.Lang.Object.GetObject<MenuBuilder.ICallback>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				MenuBuilder object2 = Java.Lang.Object.GetObject<MenuBuilder>(native_p0, JniHandleOwnership.DoNotTransfer);
				@object.OnMenuModeChange(object2);
			}

			// Token: 0x06000ADB RID: 2779 RVA: 0x0001C64C File Offset: 0x0001A84C
			public unsafe void OnMenuModeChange(MenuBuilder p0)
			{
				if (this.id_onMenuModeChange_Landroidx_appcompat_view_menu_MenuBuilder_ == IntPtr.Zero)
				{
					this.id_onMenuModeChange_Landroidx_appcompat_view_menu_MenuBuilder_ = JNIEnv.GetMethodID(this.class_ref, "onMenuModeChange", "(Landroidx/appcompat/view/menu/MenuBuilder;)V");
				}
				JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
				*ptr = new JValue((p0 == null) ? IntPtr.Zero : p0.Handle);
				JNIEnv.CallVoidMethod(base.Handle, this.id_onMenuModeChange_Landroidx_appcompat_view_menu_MenuBuilder_, ptr);
			}

			// Token: 0x04000333 RID: 819
			private static readonly JniPeerMembers _members = new XAPeerMembers("androidx/appcompat/view/menu/MenuBuilder$Callback", typeof(MenuBuilder.ICallbackInvoker));

			// Token: 0x04000334 RID: 820
			private IntPtr class_ref;

			// Token: 0x04000335 RID: 821
			private static Delegate cb_onMenuItemSelected_Landroidx_appcompat_view_menu_MenuBuilder_Landroid_view_MenuItem_;

			// Token: 0x04000336 RID: 822
			private IntPtr id_onMenuItemSelected_Landroidx_appcompat_view_menu_MenuBuilder_Landroid_view_MenuItem_;

			// Token: 0x04000337 RID: 823
			private static Delegate cb_onMenuModeChange_Landroidx_appcompat_view_menu_MenuBuilder_;

			// Token: 0x04000338 RID: 824
			private IntPtr id_onMenuModeChange_Landroidx_appcompat_view_menu_MenuBuilder_;
		}
	}
}
