using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Content;
using Android.Content.Res;
using Android.Graphics;
using Android.Graphics.Drawables;
using Android.Runtime;
using Android.Views;
using AndroidX.Core.Internal.View;
using AndroidX.Core.View;
using Java.Interop;
using Java.Lang;

namespace AndroidX.AppCompat.View.Menu
{
	// Token: 0x02000097 RID: 151
	[Register("androidx/appcompat/view/menu/MenuItemImpl", DoNotGenerateAcw = true)]
	public sealed class MenuItemImpl : Java.Lang.Object, ISupportMenuItem, IMenuItem, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x170001A4 RID: 420
		// (get) Token: 0x06000B38 RID: 2872 RVA: 0x0001D514 File Offset: 0x0001B714
		internal static IntPtr class_ref
		{
			get
			{
				return MenuItemImpl._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170001A5 RID: 421
		// (get) Token: 0x06000B39 RID: 2873 RVA: 0x0001D538 File Offset: 0x0001B738
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return MenuItemImpl._members;
			}
		}

		// Token: 0x170001A6 RID: 422
		// (get) Token: 0x06000B3A RID: 2874 RVA: 0x0001D540 File Offset: 0x0001B740
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return MenuItemImpl._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170001A7 RID: 423
		// (get) Token: 0x06000B3B RID: 2875 RVA: 0x0001D564 File Offset: 0x0001B764
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return MenuItemImpl._members.ManagedPeerType;
			}
		}

		// Token: 0x06000B3C RID: 2876 RVA: 0x000039D4 File Offset: 0x00001BD4
		internal MenuItemImpl(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x170001A8 RID: 424
		// (get) Token: 0x06000B3D RID: 2877 RVA: 0x0001D570 File Offset: 0x0001B770
		public Android.Views.ActionProvider ActionProvider
		{
			[Register("getActionProvider", "()Landroid/view/ActionProvider;", "")]
			get
			{
				return Java.Lang.Object.GetObject<Android.Views.ActionProvider>(MenuItemImpl._members.InstanceMethods.InvokeAbstractObjectMethod("getActionProvider.()Landroid/view/ActionProvider;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x170001A9 RID: 425
		// (get) Token: 0x06000B3E RID: 2878 RVA: 0x0001D5A4 File Offset: 0x0001B7A4
		public View ActionView
		{
			[Register("getActionView", "()Landroid/view/View;", "")]
			get
			{
				return Java.Lang.Object.GetObject<View>(MenuItemImpl._members.InstanceMethods.InvokeAbstractObjectMethod("getActionView.()Landroid/view/View;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x170001AA RID: 426
		// (get) Token: 0x06000B3F RID: 2879 RVA: 0x0001D5D6 File Offset: 0x0001B7D6
		public int AlphabeticModifiers
		{
			[Register("getAlphabeticModifiers", "()I", "")]
			get
			{
				return MenuItemImpl._members.InstanceMethods.InvokeAbstractInt32Method("getAlphabeticModifiers.()I", this, null);
			}
		}

		// Token: 0x170001AB RID: 427
		// (get) Token: 0x06000B40 RID: 2880 RVA: 0x0001D5EF File Offset: 0x0001B7EF
		public char AlphabeticShortcut
		{
			[Register("getAlphabeticShortcut", "()C", "")]
			get
			{
				return MenuItemImpl._members.InstanceMethods.InvokeAbstractCharMethod("getAlphabeticShortcut.()C", this, null);
			}
		}

		// Token: 0x170001AC RID: 428
		// (get) Token: 0x06000B41 RID: 2881 RVA: 0x0001D608 File Offset: 0x0001B808
		public ICharSequence ContentDescriptionFormatted
		{
			[Register("getContentDescription", "()Ljava/lang/CharSequence;", "")]
			get
			{
				return Java.Lang.Object.GetObject<ICharSequence>(MenuItemImpl._members.InstanceMethods.InvokeAbstractObjectMethod("getContentDescription.()Ljava/lang/CharSequence;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x170001AD RID: 429
		// (get) Token: 0x06000B42 RID: 2882 RVA: 0x0001D63A File Offset: 0x0001B83A
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

		// Token: 0x170001AE RID: 430
		// (get) Token: 0x06000B43 RID: 2883 RVA: 0x0001D651 File Offset: 0x0001B851
		// (set) Token: 0x06000B44 RID: 2884 RVA: 0x0001D66C File Offset: 0x0001B86C
		public unsafe bool ExclusiveCheckable
		{
			[Register("isExclusiveCheckable", "()Z", "")]
			get
			{
				return MenuItemImpl._members.InstanceMethods.InvokeAbstractBooleanMethod("isExclusiveCheckable.()Z", this, null);
			}
			[Register("setExclusiveCheckable", "(Z)V", "")]
			set
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(value);
				MenuItemImpl._members.InstanceMethods.InvokeAbstractVoidMethod("setExclusiveCheckable.(Z)V", this, ptr);
			}
		}

		// Token: 0x170001AF RID: 431
		// (get) Token: 0x06000B45 RID: 2885 RVA: 0x0001D6A7 File Offset: 0x0001B8A7
		public int GroupId
		{
			[Register("getGroupId", "()I", "")]
			get
			{
				return MenuItemImpl._members.InstanceMethods.InvokeAbstractInt32Method("getGroupId.()I", this, null);
			}
		}

		// Token: 0x170001B0 RID: 432
		// (get) Token: 0x06000B46 RID: 2886 RVA: 0x0001D6C0 File Offset: 0x0001B8C0
		public bool HasCollapsibleActionView
		{
			[Register("hasCollapsibleActionView", "()Z", "")]
			get
			{
				return MenuItemImpl._members.InstanceMethods.InvokeAbstractBooleanMethod("hasCollapsibleActionView.()Z", this, null);
			}
		}

		// Token: 0x170001B1 RID: 433
		// (get) Token: 0x06000B47 RID: 2887 RVA: 0x0001D6D9 File Offset: 0x0001B8D9
		public bool HasSubMenu
		{
			[Register("hasSubMenu", "()Z", "")]
			get
			{
				return MenuItemImpl._members.InstanceMethods.InvokeAbstractBooleanMethod("hasSubMenu.()Z", this, null);
			}
		}

		// Token: 0x170001B2 RID: 434
		// (get) Token: 0x06000B48 RID: 2888 RVA: 0x0001D6F4 File Offset: 0x0001B8F4
		public Drawable Icon
		{
			[Register("getIcon", "()Landroid/graphics/drawable/Drawable;", "")]
			get
			{
				return Java.Lang.Object.GetObject<Drawable>(MenuItemImpl._members.InstanceMethods.InvokeAbstractObjectMethod("getIcon.()Landroid/graphics/drawable/Drawable;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x170001B3 RID: 435
		// (get) Token: 0x06000B49 RID: 2889 RVA: 0x0001D728 File Offset: 0x0001B928
		public ColorStateList IconTintList
		{
			[Register("getIconTintList", "()Landroid/content/res/ColorStateList;", "")]
			get
			{
				return Java.Lang.Object.GetObject<ColorStateList>(MenuItemImpl._members.InstanceMethods.InvokeAbstractObjectMethod("getIconTintList.()Landroid/content/res/ColorStateList;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x170001B4 RID: 436
		// (get) Token: 0x06000B4A RID: 2890 RVA: 0x0001D75C File Offset: 0x0001B95C
		public PorterDuff.Mode IconTintMode
		{
			[Register("getIconTintMode", "()Landroid/graphics/PorterDuff$Mode;", "")]
			get
			{
				return Java.Lang.Object.GetObject<PorterDuff.Mode>(MenuItemImpl._members.InstanceMethods.InvokeAbstractObjectMethod("getIconTintMode.()Landroid/graphics/PorterDuff$Mode;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x170001B5 RID: 437
		// (get) Token: 0x06000B4B RID: 2891 RVA: 0x0001D790 File Offset: 0x0001B990
		public Intent Intent
		{
			[Register("getIntent", "()Landroid/content/Intent;", "")]
			get
			{
				return Java.Lang.Object.GetObject<Intent>(MenuItemImpl._members.InstanceMethods.InvokeAbstractObjectMethod("getIntent.()Landroid/content/Intent;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x170001B6 RID: 438
		// (get) Token: 0x06000B4C RID: 2892 RVA: 0x0001D7C2 File Offset: 0x0001B9C2
		// (set) Token: 0x06000B4D RID: 2893 RVA: 0x0001D7DC File Offset: 0x0001B9DC
		public unsafe bool IsActionButton
		{
			[Register("isActionButton", "()Z", "")]
			get
			{
				return MenuItemImpl._members.InstanceMethods.InvokeAbstractBooleanMethod("isActionButton.()Z", this, null);
			}
			[Register("setIsActionButton", "(Z)V", "")]
			set
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(value);
				MenuItemImpl._members.InstanceMethods.InvokeAbstractVoidMethod("setIsActionButton.(Z)V", this, ptr);
			}
		}

		// Token: 0x170001B7 RID: 439
		// (get) Token: 0x06000B4E RID: 2894 RVA: 0x0001D817 File Offset: 0x0001BA17
		public bool IsActionViewExpanded
		{
			[Register("isActionViewExpanded", "()Z", "")]
			get
			{
				return MenuItemImpl._members.InstanceMethods.InvokeAbstractBooleanMethod("isActionViewExpanded.()Z", this, null);
			}
		}

		// Token: 0x170001B8 RID: 440
		// (get) Token: 0x06000B4F RID: 2895 RVA: 0x0001D830 File Offset: 0x0001BA30
		public bool IsCheckable
		{
			[Register("isCheckable", "()Z", "")]
			get
			{
				return MenuItemImpl._members.InstanceMethods.InvokeAbstractBooleanMethod("isCheckable.()Z", this, null);
			}
		}

		// Token: 0x170001B9 RID: 441
		// (get) Token: 0x06000B50 RID: 2896 RVA: 0x0001D849 File Offset: 0x0001BA49
		public bool IsChecked
		{
			[Register("isChecked", "()Z", "")]
			get
			{
				return MenuItemImpl._members.InstanceMethods.InvokeAbstractBooleanMethod("isChecked.()Z", this, null);
			}
		}

		// Token: 0x170001BA RID: 442
		// (get) Token: 0x06000B51 RID: 2897 RVA: 0x0001D862 File Offset: 0x0001BA62
		public bool IsEnabled
		{
			[Register("isEnabled", "()Z", "")]
			get
			{
				return MenuItemImpl._members.InstanceMethods.InvokeAbstractBooleanMethod("isEnabled.()Z", this, null);
			}
		}

		// Token: 0x170001BB RID: 443
		// (get) Token: 0x06000B52 RID: 2898 RVA: 0x0001D87B File Offset: 0x0001BA7B
		public bool IsVisible
		{
			[Register("isVisible", "()Z", "")]
			get
			{
				return MenuItemImpl._members.InstanceMethods.InvokeAbstractBooleanMethod("isVisible.()Z", this, null);
			}
		}

		// Token: 0x170001BC RID: 444
		// (get) Token: 0x06000B53 RID: 2899 RVA: 0x0001D894 File Offset: 0x0001BA94
		public int ItemId
		{
			[Register("getItemId", "()I", "")]
			get
			{
				return MenuItemImpl._members.InstanceMethods.InvokeAbstractInt32Method("getItemId.()I", this, null);
			}
		}

		// Token: 0x170001BD RID: 445
		// (get) Token: 0x06000B54 RID: 2900 RVA: 0x0001D8B0 File Offset: 0x0001BAB0
		public IContextMenuContextMenuInfo MenuInfo
		{
			[Register("getMenuInfo", "()Landroid/view/ContextMenu$ContextMenuInfo;", "")]
			get
			{
				return Java.Lang.Object.GetObject<IContextMenuContextMenuInfo>(MenuItemImpl._members.InstanceMethods.InvokeAbstractObjectMethod("getMenuInfo.()Landroid/view/ContextMenu$ContextMenuInfo;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x170001BE RID: 446
		// (get) Token: 0x06000B55 RID: 2901 RVA: 0x0001D8E2 File Offset: 0x0001BAE2
		public int NumericModifiers
		{
			[Register("getNumericModifiers", "()I", "")]
			get
			{
				return MenuItemImpl._members.InstanceMethods.InvokeAbstractInt32Method("getNumericModifiers.()I", this, null);
			}
		}

		// Token: 0x170001BF RID: 447
		// (get) Token: 0x06000B56 RID: 2902 RVA: 0x0001D8FB File Offset: 0x0001BAFB
		public char NumericShortcut
		{
			[Register("getNumericShortcut", "()C", "")]
			get
			{
				return MenuItemImpl._members.InstanceMethods.InvokeAbstractCharMethod("getNumericShortcut.()C", this, null);
			}
		}

		// Token: 0x170001C0 RID: 448
		// (get) Token: 0x06000B57 RID: 2903 RVA: 0x0001D914 File Offset: 0x0001BB14
		public int Order
		{
			[Register("getOrder", "()I", "")]
			get
			{
				return MenuItemImpl._members.InstanceMethods.InvokeAbstractInt32Method("getOrder.()I", this, null);
			}
		}

		// Token: 0x170001C1 RID: 449
		// (get) Token: 0x06000B58 RID: 2904 RVA: 0x0001D92D File Offset: 0x0001BB2D
		public int Ordering
		{
			[Register("getOrdering", "()I", "")]
			get
			{
				return MenuItemImpl._members.InstanceMethods.InvokeAbstractInt32Method("getOrdering.()I", this, null);
			}
		}

		// Token: 0x170001C2 RID: 450
		// (get) Token: 0x06000B59 RID: 2905 RVA: 0x0001D948 File Offset: 0x0001BB48
		public ISubMenu SubMenu
		{
			[Register("getSubMenu", "()Landroid/view/SubMenu;", "")]
			get
			{
				return Java.Lang.Object.GetObject<ISubMenu>(MenuItemImpl._members.InstanceMethods.InvokeAbstractObjectMethod("getSubMenu.()Landroid/view/SubMenu;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x170001C3 RID: 451
		// (get) Token: 0x06000B5A RID: 2906 RVA: 0x0001D97C File Offset: 0x0001BB7C
		public AndroidX.Core.View.ActionProvider SupportActionProvider
		{
			[Register("getSupportActionProvider", "()Landroidx/core/view/ActionProvider;", "")]
			get
			{
				return Java.Lang.Object.GetObject<AndroidX.Core.View.ActionProvider>(MenuItemImpl._members.InstanceMethods.InvokeAbstractObjectMethod("getSupportActionProvider.()Landroidx/core/view/ActionProvider;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x170001C4 RID: 452
		// (get) Token: 0x06000B5B RID: 2907 RVA: 0x0001D9B0 File Offset: 0x0001BBB0
		public ICharSequence TitleFormatted
		{
			[Register("getTitle", "()Ljava/lang/CharSequence;", "")]
			get
			{
				return Java.Lang.Object.GetObject<ICharSequence>(MenuItemImpl._members.InstanceMethods.InvokeAbstractObjectMethod("getTitle.()Ljava/lang/CharSequence;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x170001C5 RID: 453
		// (get) Token: 0x06000B5C RID: 2908 RVA: 0x0001D9E2 File Offset: 0x0001BBE2
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

		// Token: 0x170001C6 RID: 454
		// (get) Token: 0x06000B5D RID: 2909 RVA: 0x0001D9FC File Offset: 0x0001BBFC
		public ICharSequence TitleCondensedFormatted
		{
			[Register("getTitleCondensed", "()Ljava/lang/CharSequence;", "")]
			get
			{
				return Java.Lang.Object.GetObject<ICharSequence>(MenuItemImpl._members.InstanceMethods.InvokeAbstractObjectMethod("getTitleCondensed.()Ljava/lang/CharSequence;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x170001C7 RID: 455
		// (get) Token: 0x06000B5E RID: 2910 RVA: 0x0001DA2E File Offset: 0x0001BC2E
		public string TitleCondensed
		{
			get
			{
				if (this.TitleCondensedFormatted != null)
				{
					return this.TitleCondensedFormatted.ToString();
				}
				return null;
			}
		}

		// Token: 0x170001C8 RID: 456
		// (get) Token: 0x06000B5F RID: 2911 RVA: 0x0001DA48 File Offset: 0x0001BC48
		public ICharSequence TooltipTextFormatted
		{
			[Register("getTooltipText", "()Ljava/lang/CharSequence;", "")]
			get
			{
				return Java.Lang.Object.GetObject<ICharSequence>(MenuItemImpl._members.InstanceMethods.InvokeAbstractObjectMethod("getTooltipText.()Ljava/lang/CharSequence;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x170001C9 RID: 457
		// (get) Token: 0x06000B60 RID: 2912 RVA: 0x0001DA7A File Offset: 0x0001BC7A
		public string TooltipText
		{
			get
			{
				if (this.TooltipTextFormatted != null)
				{
					return this.TooltipTextFormatted.ToString();
				}
				return null;
			}
		}

		// Token: 0x06000B61 RID: 2913 RVA: 0x0001DA91 File Offset: 0x0001BC91
		[Register("actionFormatChanged", "()V", "")]
		public void ActionFormatChanged()
		{
			MenuItemImpl._members.InstanceMethods.InvokeAbstractVoidMethod("actionFormatChanged.()V", this, null);
		}

		// Token: 0x06000B62 RID: 2914 RVA: 0x0001DAAA File Offset: 0x0001BCAA
		[Register("collapseActionView", "()Z", "")]
		public bool CollapseActionView()
		{
			return MenuItemImpl._members.InstanceMethods.InvokeAbstractBooleanMethod("collapseActionView.()Z", this, null);
		}

		// Token: 0x06000B63 RID: 2915 RVA: 0x0001DAC3 File Offset: 0x0001BCC3
		[Register("expandActionView", "()Z", "")]
		public bool ExpandActionView()
		{
			return MenuItemImpl._members.InstanceMethods.InvokeAbstractBooleanMethod("expandActionView.()Z", this, null);
		}

		// Token: 0x06000B64 RID: 2916 RVA: 0x0001DADC File Offset: 0x0001BCDC
		[Register("invoke", "()Z", "")]
		public bool Invoke()
		{
			return MenuItemImpl._members.InstanceMethods.InvokeAbstractBooleanMethod("invoke.()Z", this, null);
		}

		// Token: 0x06000B65 RID: 2917 RVA: 0x0001DAF5 File Offset: 0x0001BCF5
		[Register("requestsActionButton", "()Z", "")]
		public bool RequestsActionButton()
		{
			return MenuItemImpl._members.InstanceMethods.InvokeAbstractBooleanMethod("requestsActionButton.()Z", this, null);
		}

		// Token: 0x06000B66 RID: 2918 RVA: 0x0001DB0E File Offset: 0x0001BD0E
		[Register("requiresActionButton", "()Z", "")]
		public bool RequiresActionButton()
		{
			return MenuItemImpl._members.InstanceMethods.InvokeAbstractBooleanMethod("requiresActionButton.()Z", this, null);
		}

		// Token: 0x06000B67 RID: 2919 RVA: 0x0001DB27 File Offset: 0x0001BD27
		[Register("requiresOverflow", "()Z", "")]
		public bool RequiresOverflow()
		{
			return MenuItemImpl._members.InstanceMethods.InvokeAbstractBooleanMethod("requiresOverflow.()Z", this, null);
		}

		// Token: 0x06000B68 RID: 2920 RVA: 0x0001DB40 File Offset: 0x0001BD40
		[Register("setActionProvider", "(Landroid/view/ActionProvider;)Landroid/view/MenuItem;", "")]
		public unsafe IMenuItem SetActionProvider(Android.Views.ActionProvider actionProvider)
		{
			IMenuItem @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((actionProvider == null) ? IntPtr.Zero : actionProvider.Handle);
				@object = Java.Lang.Object.GetObject<IMenuItem>(MenuItemImpl._members.InstanceMethods.InvokeAbstractObjectMethod("setActionProvider.(Landroid/view/ActionProvider;)Landroid/view/MenuItem;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(actionProvider);
			}
			return @object;
		}

		// Token: 0x06000B69 RID: 2921 RVA: 0x0001DBB4 File Offset: 0x0001BDB4
		[Register("setActionView", "(Landroid/view/View;)Landroidx/core/internal/view/SupportMenuItem;", "")]
		public unsafe IMenuItem SetActionView(View view)
		{
			IMenuItem @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((view == null) ? IntPtr.Zero : view.Handle);
				@object = Java.Lang.Object.GetObject<IMenuItem>(MenuItemImpl._members.InstanceMethods.InvokeAbstractObjectMethod("setActionView.(Landroid/view/View;)Landroidx/core/internal/view/SupportMenuItem;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(view);
			}
			return @object;
		}

		// Token: 0x06000B6A RID: 2922 RVA: 0x0001DC28 File Offset: 0x0001BE28
		[Register("setActionView", "(I)Landroidx/core/internal/view/SupportMenuItem;", "")]
		public unsafe IMenuItem SetActionView(int resId)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(resId);
			return Java.Lang.Object.GetObject<IMenuItem>(MenuItemImpl._members.InstanceMethods.InvokeAbstractObjectMethod("setActionView.(I)Landroidx/core/internal/view/SupportMenuItem;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06000B6B RID: 2923 RVA: 0x0001DC74 File Offset: 0x0001BE74
		[Register("setActionViewExpanded", "(Z)V", "")]
		public unsafe void SetActionViewExpanded(bool isExpanded)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(isExpanded);
			MenuItemImpl._members.InstanceMethods.InvokeAbstractVoidMethod("setActionViewExpanded.(Z)V", this, ptr);
		}

		// Token: 0x06000B6C RID: 2924 RVA: 0x0001DCB0 File Offset: 0x0001BEB0
		[Register("setAlphabeticShortcut", "(C)Landroid/view/MenuItem;", "")]
		public unsafe IMenuItem SetAlphabeticShortcut(char alphaChar)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(alphaChar);
			return Java.Lang.Object.GetObject<IMenuItem>(MenuItemImpl._members.InstanceMethods.InvokeAbstractObjectMethod("setAlphabeticShortcut.(C)Landroid/view/MenuItem;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06000B6D RID: 2925 RVA: 0x0001DCFC File Offset: 0x0001BEFC
		[Register("setAlphabeticShortcut", "(CI)Landroid/view/MenuItem;", "")]
		public unsafe IMenuItem SetAlphabeticShortcut(char alphaChar, int alphaModifiers)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(alphaChar);
			ptr[1] = new JniArgumentValue(alphaModifiers);
			return Java.Lang.Object.GetObject<IMenuItem>(MenuItemImpl._members.InstanceMethods.InvokeAbstractObjectMethod("setAlphabeticShortcut.(CI)Landroid/view/MenuItem;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06000B6E RID: 2926 RVA: 0x0001DD58 File Offset: 0x0001BF58
		[Register("setCallback", "(Ljava/lang/Runnable;)Landroid/view/MenuItem;", "")]
		public unsafe IMenuItem SetCallback(IRunnable callback)
		{
			IMenuItem @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((callback == null) ? IntPtr.Zero : ((Java.Lang.Object)callback).Handle);
				@object = Java.Lang.Object.GetObject<IMenuItem>(MenuItemImpl._members.InstanceMethods.InvokeAbstractObjectMethod("setCallback.(Ljava/lang/Runnable;)Landroid/view/MenuItem;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(callback);
			}
			return @object;
		}

		// Token: 0x06000B6F RID: 2927 RVA: 0x0001DDD0 File Offset: 0x0001BFD0
		[Register("setCheckable", "(Z)Landroid/view/MenuItem;", "")]
		public unsafe IMenuItem SetCheckable(bool checkable)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(checkable);
			return Java.Lang.Object.GetObject<IMenuItem>(MenuItemImpl._members.InstanceMethods.InvokeAbstractObjectMethod("setCheckable.(Z)Landroid/view/MenuItem;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06000B70 RID: 2928 RVA: 0x0001DE1C File Offset: 0x0001C01C
		[Register("setChecked", "(Z)Landroid/view/MenuItem;", "")]
		public unsafe IMenuItem SetChecked(bool @checked)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(@checked);
			return Java.Lang.Object.GetObject<IMenuItem>(MenuItemImpl._members.InstanceMethods.InvokeAbstractObjectMethod("setChecked.(Z)Landroid/view/MenuItem;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06000B71 RID: 2929 RVA: 0x0001DE68 File Offset: 0x0001C068
		[Register("setContentDescription", "(Ljava/lang/CharSequence;)Landroidx/core/internal/view/SupportMenuItem;", "")]
		public unsafe ISupportMenuItem SetContentDescription(ICharSequence contentDescription)
		{
			IntPtr intPtr = CharSequence.ToLocalJniHandle(contentDescription);
			ISupportMenuItem @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<ISupportMenuItem>(MenuItemImpl._members.InstanceMethods.InvokeAbstractObjectMethod("setContentDescription.(Ljava/lang/CharSequence;)Landroidx/core/internal/view/SupportMenuItem;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(contentDescription);
			}
			return @object;
		}

		// Token: 0x06000B72 RID: 2930 RVA: 0x0001DEDC File Offset: 0x0001C0DC
		public ISupportMenuItem SetContentDescription(string contentDescription)
		{
			Java.Lang.String @string = (contentDescription == null) ? null : new Java.Lang.String(contentDescription);
			ISupportMenuItem result = this.SetContentDescription(@string);
			if (@string != null)
			{
				@string.Dispose();
			}
			return result;
		}

		// Token: 0x06000B73 RID: 2931 RVA: 0x0001DF08 File Offset: 0x0001C108
		[Register("setEnabled", "(Z)Landroid/view/MenuItem;", "")]
		public unsafe IMenuItem SetEnabled(bool enabled)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(enabled);
			return Java.Lang.Object.GetObject<IMenuItem>(MenuItemImpl._members.InstanceMethods.InvokeAbstractObjectMethod("setEnabled.(Z)Landroid/view/MenuItem;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06000B74 RID: 2932 RVA: 0x0001DF54 File Offset: 0x0001C154
		[Register("setIcon", "(Landroid/graphics/drawable/Drawable;)Landroid/view/MenuItem;", "")]
		public unsafe IMenuItem SetIcon(Drawable icon)
		{
			IMenuItem @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((icon == null) ? IntPtr.Zero : icon.Handle);
				@object = Java.Lang.Object.GetObject<IMenuItem>(MenuItemImpl._members.InstanceMethods.InvokeAbstractObjectMethod("setIcon.(Landroid/graphics/drawable/Drawable;)Landroid/view/MenuItem;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(icon);
			}
			return @object;
		}

		// Token: 0x06000B75 RID: 2933 RVA: 0x0001DFC8 File Offset: 0x0001C1C8
		[Register("setIcon", "(I)Landroid/view/MenuItem;", "")]
		public unsafe IMenuItem SetIcon(int iconResId)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(iconResId);
			return Java.Lang.Object.GetObject<IMenuItem>(MenuItemImpl._members.InstanceMethods.InvokeAbstractObjectMethod("setIcon.(I)Landroid/view/MenuItem;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06000B76 RID: 2934 RVA: 0x0001E014 File Offset: 0x0001C214
		[Register("setIconTintList", "(Landroid/content/res/ColorStateList;)Landroid/view/MenuItem;", "")]
		public unsafe IMenuItem SetIconTintList(ColorStateList iconTintList)
		{
			IMenuItem @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((iconTintList == null) ? IntPtr.Zero : iconTintList.Handle);
				@object = Java.Lang.Object.GetObject<IMenuItem>(MenuItemImpl._members.InstanceMethods.InvokeAbstractObjectMethod("setIconTintList.(Landroid/content/res/ColorStateList;)Landroid/view/MenuItem;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(iconTintList);
			}
			return @object;
		}

		// Token: 0x06000B77 RID: 2935 RVA: 0x0001E088 File Offset: 0x0001C288
		[Register("setIconTintMode", "(Landroid/graphics/PorterDuff$Mode;)Landroid/view/MenuItem;", "")]
		public unsafe IMenuItem SetIconTintMode(PorterDuff.Mode iconTintMode)
		{
			IMenuItem @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((iconTintMode == null) ? IntPtr.Zero : iconTintMode.Handle);
				@object = Java.Lang.Object.GetObject<IMenuItem>(MenuItemImpl._members.InstanceMethods.InvokeAbstractObjectMethod("setIconTintMode.(Landroid/graphics/PorterDuff$Mode;)Landroid/view/MenuItem;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(iconTintMode);
			}
			return @object;
		}

		// Token: 0x06000B78 RID: 2936 RVA: 0x0001E0FC File Offset: 0x0001C2FC
		[Register("setIntent", "(Landroid/content/Intent;)Landroid/view/MenuItem;", "")]
		public unsafe IMenuItem SetIntent(Intent intent)
		{
			IMenuItem @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((intent == null) ? IntPtr.Zero : intent.Handle);
				@object = Java.Lang.Object.GetObject<IMenuItem>(MenuItemImpl._members.InstanceMethods.InvokeAbstractObjectMethod("setIntent.(Landroid/content/Intent;)Landroid/view/MenuItem;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(intent);
			}
			return @object;
		}

		// Token: 0x06000B79 RID: 2937 RVA: 0x0001E170 File Offset: 0x0001C370
		[Register("setNumericShortcut", "(C)Landroid/view/MenuItem;", "")]
		public unsafe IMenuItem SetNumericShortcut(char numericChar)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(numericChar);
			return Java.Lang.Object.GetObject<IMenuItem>(MenuItemImpl._members.InstanceMethods.InvokeAbstractObjectMethod("setNumericShortcut.(C)Landroid/view/MenuItem;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06000B7A RID: 2938 RVA: 0x0001E1BC File Offset: 0x0001C3BC
		[Register("setNumericShortcut", "(CI)Landroid/view/MenuItem;", "")]
		public unsafe IMenuItem SetNumericShortcut(char numericChar, int numericModifiers)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(numericChar);
			ptr[1] = new JniArgumentValue(numericModifiers);
			return Java.Lang.Object.GetObject<IMenuItem>(MenuItemImpl._members.InstanceMethods.InvokeAbstractObjectMethod("setNumericShortcut.(CI)Landroid/view/MenuItem;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06000B7B RID: 2939 RVA: 0x0001E218 File Offset: 0x0001C418
		[Register("setOnActionExpandListener", "(Landroid/view/MenuItem$OnActionExpandListener;)Landroid/view/MenuItem;", "")]
		public unsafe IMenuItem SetOnActionExpandListener(IMenuItemOnActionExpandListener listener)
		{
			IMenuItem @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((listener == null) ? IntPtr.Zero : ((Java.Lang.Object)listener).Handle);
				@object = Java.Lang.Object.GetObject<IMenuItem>(MenuItemImpl._members.InstanceMethods.InvokeAbstractObjectMethod("setOnActionExpandListener.(Landroid/view/MenuItem$OnActionExpandListener;)Landroid/view/MenuItem;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(listener);
			}
			return @object;
		}

		// Token: 0x06000B7C RID: 2940 RVA: 0x0001E290 File Offset: 0x0001C490
		[Register("setOnMenuItemClickListener", "(Landroid/view/MenuItem$OnMenuItemClickListener;)Landroid/view/MenuItem;", "")]
		public unsafe IMenuItem SetOnMenuItemClickListener(IMenuItemOnMenuItemClickListener clickListener)
		{
			IMenuItem @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((clickListener == null) ? IntPtr.Zero : ((Java.Lang.Object)clickListener).Handle);
				@object = Java.Lang.Object.GetObject<IMenuItem>(MenuItemImpl._members.InstanceMethods.InvokeAbstractObjectMethod("setOnMenuItemClickListener.(Landroid/view/MenuItem$OnMenuItemClickListener;)Landroid/view/MenuItem;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(clickListener);
			}
			return @object;
		}

		// Token: 0x06000B7D RID: 2941 RVA: 0x0001E308 File Offset: 0x0001C508
		[Register("setShortcut", "(CC)Landroid/view/MenuItem;", "")]
		public unsafe IMenuItem SetShortcut(char numericChar, char alphaChar)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(numericChar);
			ptr[1] = new JniArgumentValue(alphaChar);
			return Java.Lang.Object.GetObject<IMenuItem>(MenuItemImpl._members.InstanceMethods.InvokeAbstractObjectMethod("setShortcut.(CC)Landroid/view/MenuItem;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06000B7E RID: 2942 RVA: 0x0001E364 File Offset: 0x0001C564
		[Register("setShortcut", "(CCII)Landroid/view/MenuItem;", "")]
		public unsafe IMenuItem SetShortcut(char numericChar, char alphaChar, int numericModifiers, int alphaModifiers)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(numericChar);
			ptr[1] = new JniArgumentValue(alphaChar);
			ptr[2] = new JniArgumentValue(numericModifiers);
			ptr[3] = new JniArgumentValue(alphaModifiers);
			return Java.Lang.Object.GetObject<IMenuItem>(MenuItemImpl._members.InstanceMethods.InvokeAbstractObjectMethod("setShortcut.(CCII)Landroid/view/MenuItem;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06000B7F RID: 2943 RVA: 0x0001E3F0 File Offset: 0x0001C5F0
		[Register("setShowAsAction", "(I)V", "")]
		public unsafe void SetShowAsAction([GeneratedEnum] ShowAsAction actionEnum)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue((int)actionEnum);
			MenuItemImpl._members.InstanceMethods.InvokeAbstractVoidMethod("setShowAsAction.(I)V", this, ptr);
		}

		// Token: 0x06000B80 RID: 2944 RVA: 0x0001E42C File Offset: 0x0001C62C
		[Register("setShowAsActionFlags", "(I)Landroidx/core/internal/view/SupportMenuItem;", "")]
		public unsafe IMenuItem SetShowAsActionFlags([GeneratedEnum] ShowAsAction actionEnum)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue((int)actionEnum);
			return Java.Lang.Object.GetObject<IMenuItem>(MenuItemImpl._members.InstanceMethods.InvokeAbstractObjectMethod("setShowAsActionFlags.(I)Landroidx/core/internal/view/SupportMenuItem;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06000B81 RID: 2945 RVA: 0x0001E478 File Offset: 0x0001C678
		[Register("setSubMenu", "(Landroidx/appcompat/view/menu/SubMenuBuilder;)V", "")]
		public unsafe void SetSubMenu(SubMenuBuilder subMenu)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((subMenu == null) ? IntPtr.Zero : subMenu.Handle);
				MenuItemImpl._members.InstanceMethods.InvokeAbstractVoidMethod("setSubMenu.(Landroidx/appcompat/view/menu/SubMenuBuilder;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(subMenu);
			}
		}

		// Token: 0x06000B82 RID: 2946 RVA: 0x0001E4DC File Offset: 0x0001C6DC
		[Register("setSupportActionProvider", "(Landroidx/core/view/ActionProvider;)Landroidx/core/internal/view/SupportMenuItem;", "")]
		public unsafe ISupportMenuItem SetSupportActionProvider(AndroidX.Core.View.ActionProvider actionProvider)
		{
			ISupportMenuItem @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((actionProvider == null) ? IntPtr.Zero : actionProvider.Handle);
				@object = Java.Lang.Object.GetObject<ISupportMenuItem>(MenuItemImpl._members.InstanceMethods.InvokeAbstractObjectMethod("setSupportActionProvider.(Landroidx/core/view/ActionProvider;)Landroidx/core/internal/view/SupportMenuItem;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(actionProvider);
			}
			return @object;
		}

		// Token: 0x06000B83 RID: 2947 RVA: 0x0001E550 File Offset: 0x0001C750
		[Register("setTitle", "(I)Landroid/view/MenuItem;", "")]
		public unsafe IMenuItem SetTitle(int title)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(title);
			return Java.Lang.Object.GetObject<IMenuItem>(MenuItemImpl._members.InstanceMethods.InvokeAbstractObjectMethod("setTitle.(I)Landroid/view/MenuItem;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06000B84 RID: 2948 RVA: 0x0001E59C File Offset: 0x0001C79C
		[Register("setTitle", "(Ljava/lang/CharSequence;)Landroid/view/MenuItem;", "")]
		public unsafe IMenuItem SetTitle(ICharSequence title)
		{
			IntPtr intPtr = CharSequence.ToLocalJniHandle(title);
			IMenuItem @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<IMenuItem>(MenuItemImpl._members.InstanceMethods.InvokeAbstractObjectMethod("setTitle.(Ljava/lang/CharSequence;)Landroid/view/MenuItem;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(title);
			}
			return @object;
		}

		// Token: 0x06000B85 RID: 2949 RVA: 0x0001E610 File Offset: 0x0001C810
		public IMenuItem SetTitle(string title)
		{
			Java.Lang.String @string = (title == null) ? null : new Java.Lang.String(title);
			IMenuItem result = this.SetTitle(@string);
			if (@string != null)
			{
				@string.Dispose();
			}
			return result;
		}

		// Token: 0x06000B86 RID: 2950 RVA: 0x0001E63C File Offset: 0x0001C83C
		[Register("setTitleCondensed", "(Ljava/lang/CharSequence;)Landroid/view/MenuItem;", "")]
		public unsafe IMenuItem SetTitleCondensed(ICharSequence title)
		{
			IntPtr intPtr = CharSequence.ToLocalJniHandle(title);
			IMenuItem @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<IMenuItem>(MenuItemImpl._members.InstanceMethods.InvokeAbstractObjectMethod("setTitleCondensed.(Ljava/lang/CharSequence;)Landroid/view/MenuItem;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(title);
			}
			return @object;
		}

		// Token: 0x06000B87 RID: 2951 RVA: 0x0001E6B0 File Offset: 0x0001C8B0
		public IMenuItem SetTitleCondensed(string title)
		{
			Java.Lang.String @string = (title == null) ? null : new Java.Lang.String(title);
			IMenuItem result = this.SetTitleCondensed(@string);
			if (@string != null)
			{
				@string.Dispose();
			}
			return result;
		}

		// Token: 0x06000B88 RID: 2952 RVA: 0x0001E6DC File Offset: 0x0001C8DC
		[Register("setTooltipText", "(Ljava/lang/CharSequence;)Landroidx/core/internal/view/SupportMenuItem;", "")]
		public unsafe ISupportMenuItem SetTooltipText(ICharSequence tooltipText)
		{
			IntPtr intPtr = CharSequence.ToLocalJniHandle(tooltipText);
			ISupportMenuItem @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<ISupportMenuItem>(MenuItemImpl._members.InstanceMethods.InvokeAbstractObjectMethod("setTooltipText.(Ljava/lang/CharSequence;)Landroidx/core/internal/view/SupportMenuItem;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(tooltipText);
			}
			return @object;
		}

		// Token: 0x06000B89 RID: 2953 RVA: 0x0001E750 File Offset: 0x0001C950
		public ISupportMenuItem SetTooltipText(string tooltipText)
		{
			Java.Lang.String @string = (tooltipText == null) ? null : new Java.Lang.String(tooltipText);
			ISupportMenuItem result = this.SetTooltipText(@string);
			if (@string != null)
			{
				@string.Dispose();
			}
			return result;
		}

		// Token: 0x06000B8A RID: 2954 RVA: 0x0001E77C File Offset: 0x0001C97C
		[Register("setVisible", "(Z)Landroid/view/MenuItem;", "")]
		public unsafe IMenuItem SetVisible(bool shown)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(shown);
			return Java.Lang.Object.GetObject<IMenuItem>(MenuItemImpl._members.InstanceMethods.InvokeAbstractObjectMethod("setVisible.(Z)Landroid/view/MenuItem;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06000B8B RID: 2955 RVA: 0x0001E7C5 File Offset: 0x0001C9C5
		[Register("shouldShowIcon", "()Z", "")]
		public bool ShouldShowIcon()
		{
			return MenuItemImpl._members.InstanceMethods.InvokeAbstractBooleanMethod("shouldShowIcon.()Z", this, null);
		}

		// Token: 0x06000B8C RID: 2956 RVA: 0x0001E7DE File Offset: 0x0001C9DE
		[Register("showsTextAsAction", "()Z", "")]
		public bool ShowsTextAsAction()
		{
			return MenuItemImpl._members.InstanceMethods.InvokeAbstractBooleanMethod("showsTextAsAction.()Z", this, null);
		}

		// Token: 0x0400035F RID: 863
		private static readonly JniPeerMembers _members = new XAPeerMembers("androidx/appcompat/view/menu/MenuItemImpl", typeof(MenuItemImpl));
	}
}
