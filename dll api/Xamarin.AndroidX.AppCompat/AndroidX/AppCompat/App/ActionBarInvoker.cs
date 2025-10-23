using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Graphics.Drawables;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Java.Interop;
using Java.Lang;

namespace AndroidX.AppCompat.App
{
	// Token: 0x0200004E RID: 78
	[Register("androidx/appcompat/app/ActionBar", DoNotGenerateAcw = true)]
	internal class ActionBarInvoker : ActionBar
	{
		// Token: 0x0600038A RID: 906 RVA: 0x0000913E File Offset: 0x0000733E
		public ActionBarInvoker(IntPtr handle, JniHandleOwnership transfer) : base(handle, transfer)
		{
		}

		// Token: 0x17000058 RID: 88
		// (get) Token: 0x0600038B RID: 907 RVA: 0x00009148 File Offset: 0x00007348
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return ActionBarInvoker._members;
			}
		}

		// Token: 0x17000059 RID: 89
		// (get) Token: 0x0600038C RID: 908 RVA: 0x0000914F File Offset: 0x0000734F
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return ActionBarInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x1700005A RID: 90
		// (get) Token: 0x0600038D RID: 909 RVA: 0x0000915C File Offset: 0x0000735C
		// (set) Token: 0x0600038E RID: 910 RVA: 0x00009190 File Offset: 0x00007390
		public unsafe override View CustomView
		{
			[Register("getCustomView", "()Landroid/view/View;", "GetGetCustomViewHandler")]
			get
			{
				return Java.Lang.Object.GetObject<View>(ActionBarInvoker._members.InstanceMethods.InvokeAbstractObjectMethod("getCustomView.()Landroid/view/View;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
			[Register("setCustomView", "(Landroid/view/View;)V", "GetSetCustomView_Landroid_view_View_Handler")]
			set
			{
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((value == null) ? IntPtr.Zero : value.Handle);
					ActionBarInvoker._members.InstanceMethods.InvokeAbstractVoidMethod("setCustomView.(Landroid/view/View;)V", this, ptr);
				}
				finally
				{
					GC.KeepAlive(value);
				}
			}
		}

		// Token: 0x1700005B RID: 91
		// (get) Token: 0x0600038F RID: 911 RVA: 0x000091F4 File Offset: 0x000073F4
		// (set) Token: 0x06000390 RID: 912 RVA: 0x00009210 File Offset: 0x00007410
		public unsafe override int DisplayOptions
		{
			[Register("getDisplayOptions", "()I", "GetGetDisplayOptionsHandler")]
			get
			{
				return ActionBarInvoker._members.InstanceMethods.InvokeAbstractInt32Method("getDisplayOptions.()I", this, null);
			}
			[Register("setDisplayOptions", "(I)V", "GetSetDisplayOptions_IHandler")]
			set
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(value);
				ActionBarInvoker._members.InstanceMethods.InvokeAbstractVoidMethod("setDisplayOptions.(I)V", this, ptr);
			}
		}

		// Token: 0x1700005C RID: 92
		// (get) Token: 0x06000391 RID: 913 RVA: 0x0000924B File Offset: 0x0000744B
		public override int Height
		{
			[Register("getHeight", "()I", "GetGetHeightHandler")]
			get
			{
				return ActionBarInvoker._members.InstanceMethods.InvokeAbstractInt32Method("getHeight.()I", this, null);
			}
		}

		// Token: 0x1700005D RID: 93
		// (get) Token: 0x06000392 RID: 914 RVA: 0x00009264 File Offset: 0x00007464
		public override bool IsShowing
		{
			[Register("isShowing", "()Z", "GetIsShowingHandler")]
			get
			{
				return ActionBarInvoker._members.InstanceMethods.InvokeAbstractBooleanMethod("isShowing.()Z", this, null);
			}
		}

		// Token: 0x1700005E RID: 94
		// (get) Token: 0x06000393 RID: 915 RVA: 0x0000927D File Offset: 0x0000747D
		public override int NavigationItemCount
		{
			[Register("getNavigationItemCount", "()I", "GetGetNavigationItemCountHandler")]
			get
			{
				return ActionBarInvoker._members.InstanceMethods.InvokeAbstractInt32Method("getNavigationItemCount.()I", this, null);
			}
		}

		// Token: 0x1700005F RID: 95
		// (get) Token: 0x06000394 RID: 916 RVA: 0x00009296 File Offset: 0x00007496
		// (set) Token: 0x06000395 RID: 917 RVA: 0x000092B0 File Offset: 0x000074B0
		public unsafe override int NavigationMode
		{
			[Register("getNavigationMode", "()I", "GetGetNavigationModeHandler")]
			get
			{
				return ActionBarInvoker._members.InstanceMethods.InvokeAbstractInt32Method("getNavigationMode.()I", this, null);
			}
			[Register("setNavigationMode", "(I)V", "GetSetNavigationMode_IHandler")]
			set
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(value);
				ActionBarInvoker._members.InstanceMethods.InvokeAbstractVoidMethod("setNavigationMode.(I)V", this, ptr);
			}
		}

		// Token: 0x17000060 RID: 96
		// (get) Token: 0x06000396 RID: 918 RVA: 0x000092EB File Offset: 0x000074EB
		public override int SelectedNavigationIndex
		{
			[Register("getSelectedNavigationIndex", "()I", "GetGetSelectedNavigationIndexHandler")]
			get
			{
				return ActionBarInvoker._members.InstanceMethods.InvokeAbstractInt32Method("getSelectedNavigationIndex.()I", this, null);
			}
		}

		// Token: 0x17000061 RID: 97
		// (get) Token: 0x06000397 RID: 919 RVA: 0x00009304 File Offset: 0x00007504
		public override ActionBar.Tab SelectedTab
		{
			[Register("getSelectedTab", "()Landroidx/appcompat/app/ActionBar$Tab;", "GetGetSelectedTabHandler")]
			get
			{
				return Java.Lang.Object.GetObject<ActionBar.Tab>(ActionBarInvoker._members.InstanceMethods.InvokeAbstractObjectMethod("getSelectedTab.()Landroidx/appcompat/app/ActionBar$Tab;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000062 RID: 98
		// (get) Token: 0x06000398 RID: 920 RVA: 0x00009338 File Offset: 0x00007538
		// (set) Token: 0x06000399 RID: 921 RVA: 0x0000936C File Offset: 0x0000756C
		public unsafe override ICharSequence SubtitleFormatted
		{
			[Register("getSubtitle", "()Ljava/lang/CharSequence;", "GetGetSubtitleHandler")]
			get
			{
				return Java.Lang.Object.GetObject<ICharSequence>(ActionBarInvoker._members.InstanceMethods.InvokeAbstractObjectMethod("getSubtitle.()Ljava/lang/CharSequence;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
			[Register("setSubtitle", "(Ljava/lang/CharSequence;)V", "GetSetSubtitle_Ljava_lang_CharSequence_Handler")]
			set
			{
				IntPtr intPtr = CharSequence.ToLocalJniHandle(value);
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue(intPtr);
					ActionBarInvoker._members.InstanceMethods.InvokeAbstractVoidMethod("setSubtitle.(Ljava/lang/CharSequence;)V", this, ptr);
				}
				finally
				{
					JNIEnv.DeleteLocalRef(intPtr);
					GC.KeepAlive(value);
				}
			}
		}

		// Token: 0x17000063 RID: 99
		// (get) Token: 0x0600039A RID: 922 RVA: 0x000093D0 File Offset: 0x000075D0
		public override int TabCount
		{
			[Register("getTabCount", "()I", "GetGetTabCountHandler")]
			get
			{
				return ActionBarInvoker._members.InstanceMethods.InvokeAbstractInt32Method("getTabCount.()I", this, null);
			}
		}

		// Token: 0x17000064 RID: 100
		// (get) Token: 0x0600039B RID: 923 RVA: 0x000093EC File Offset: 0x000075EC
		// (set) Token: 0x0600039C RID: 924 RVA: 0x00009420 File Offset: 0x00007620
		public unsafe override ICharSequence TitleFormatted
		{
			[Register("getTitle", "()Ljava/lang/CharSequence;", "GetGetTitleHandler")]
			get
			{
				return Java.Lang.Object.GetObject<ICharSequence>(ActionBarInvoker._members.InstanceMethods.InvokeAbstractObjectMethod("getTitle.()Ljava/lang/CharSequence;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
			[Register("setTitle", "(Ljava/lang/CharSequence;)V", "GetSetTitle_Ljava_lang_CharSequence_Handler")]
			set
			{
				IntPtr intPtr = CharSequence.ToLocalJniHandle(value);
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue(intPtr);
					ActionBarInvoker._members.InstanceMethods.InvokeAbstractVoidMethod("setTitle.(Ljava/lang/CharSequence;)V", this, ptr);
				}
				finally
				{
					JNIEnv.DeleteLocalRef(intPtr);
					GC.KeepAlive(value);
				}
			}
		}

		// Token: 0x0600039D RID: 925 RVA: 0x00009484 File Offset: 0x00007684
		[Register("addOnMenuVisibilityListener", "(Landroidx/appcompat/app/ActionBar$OnMenuVisibilityListener;)V", "GetAddOnMenuVisibilityListener_Landroidx_appcompat_app_ActionBar_OnMenuVisibilityListener_Handler")]
		public unsafe override void AddOnMenuVisibilityListener(ActionBar.IOnMenuVisibilityListener listener)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((listener == null) ? IntPtr.Zero : ((Java.Lang.Object)listener).Handle);
				ActionBarInvoker._members.InstanceMethods.InvokeAbstractVoidMethod("addOnMenuVisibilityListener.(Landroidx/appcompat/app/ActionBar$OnMenuVisibilityListener;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(listener);
			}
		}

		// Token: 0x0600039E RID: 926 RVA: 0x000094EC File Offset: 0x000076EC
		[Register("addTab", "(Landroidx/appcompat/app/ActionBar$Tab;)V", "GetAddTab_Landroidx_appcompat_app_ActionBar_Tab_Handler")]
		public unsafe override void AddTab(ActionBar.Tab tab)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((tab == null) ? IntPtr.Zero : tab.Handle);
				ActionBarInvoker._members.InstanceMethods.InvokeAbstractVoidMethod("addTab.(Landroidx/appcompat/app/ActionBar$Tab;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(tab);
			}
		}

		// Token: 0x0600039F RID: 927 RVA: 0x00009550 File Offset: 0x00007750
		[Register("addTab", "(Landroidx/appcompat/app/ActionBar$Tab;Z)V", "GetAddTab_Landroidx_appcompat_app_ActionBar_Tab_ZHandler")]
		public unsafe override void AddTab(ActionBar.Tab tab, bool setSelected)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((tab == null) ? IntPtr.Zero : tab.Handle);
				ptr[1] = new JniArgumentValue(setSelected);
				ActionBarInvoker._members.InstanceMethods.InvokeAbstractVoidMethod("addTab.(Landroidx/appcompat/app/ActionBar$Tab;Z)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(tab);
			}
		}

		// Token: 0x060003A0 RID: 928 RVA: 0x000095C8 File Offset: 0x000077C8
		[Register("addTab", "(Landroidx/appcompat/app/ActionBar$Tab;I)V", "GetAddTab_Landroidx_appcompat_app_ActionBar_Tab_IHandler")]
		public unsafe override void AddTab(ActionBar.Tab tab, int position)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((tab == null) ? IntPtr.Zero : tab.Handle);
				ptr[1] = new JniArgumentValue(position);
				ActionBarInvoker._members.InstanceMethods.InvokeAbstractVoidMethod("addTab.(Landroidx/appcompat/app/ActionBar$Tab;I)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(tab);
			}
		}

		// Token: 0x060003A1 RID: 929 RVA: 0x00009640 File Offset: 0x00007840
		[Register("addTab", "(Landroidx/appcompat/app/ActionBar$Tab;IZ)V", "GetAddTab_Landroidx_appcompat_app_ActionBar_Tab_IZHandler")]
		public unsafe override void AddTab(ActionBar.Tab tab, int position, bool setSelected)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((tab == null) ? IntPtr.Zero : tab.Handle);
				ptr[1] = new JniArgumentValue(position);
				ptr[2] = new JniArgumentValue(setSelected);
				ActionBarInvoker._members.InstanceMethods.InvokeAbstractVoidMethod("addTab.(Landroidx/appcompat/app/ActionBar$Tab;IZ)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(tab);
			}
		}

		// Token: 0x060003A2 RID: 930 RVA: 0x000096CC File Offset: 0x000078CC
		[Register("getTabAt", "(I)Landroidx/appcompat/app/ActionBar$Tab;", "GetGetTabAt_IHandler")]
		public unsafe override ActionBar.Tab GetTabAt(int index)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(index);
			return Java.Lang.Object.GetObject<ActionBar.Tab>(ActionBarInvoker._members.InstanceMethods.InvokeAbstractObjectMethod("getTabAt.(I)Landroidx/appcompat/app/ActionBar$Tab;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x060003A3 RID: 931 RVA: 0x00009715 File Offset: 0x00007915
		[Register("hide", "()V", "GetHideHandler")]
		public override void Hide()
		{
			ActionBarInvoker._members.InstanceMethods.InvokeAbstractVoidMethod("hide.()V", this, null);
		}

		// Token: 0x060003A4 RID: 932 RVA: 0x00009730 File Offset: 0x00007930
		[Register("newTab", "()Landroidx/appcompat/app/ActionBar$Tab;", "GetNewTabHandler")]
		public override ActionBar.Tab NewTab()
		{
			return Java.Lang.Object.GetObject<ActionBar.Tab>(ActionBarInvoker._members.InstanceMethods.InvokeAbstractObjectMethod("newTab.()Landroidx/appcompat/app/ActionBar$Tab;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x060003A5 RID: 933 RVA: 0x00009762 File Offset: 0x00007962
		[Register("removeAllTabs", "()V", "GetRemoveAllTabsHandler")]
		public override void RemoveAllTabs()
		{
			ActionBarInvoker._members.InstanceMethods.InvokeAbstractVoidMethod("removeAllTabs.()V", this, null);
		}

		// Token: 0x060003A6 RID: 934 RVA: 0x0000977C File Offset: 0x0000797C
		[Register("removeOnMenuVisibilityListener", "(Landroidx/appcompat/app/ActionBar$OnMenuVisibilityListener;)V", "GetRemoveOnMenuVisibilityListener_Landroidx_appcompat_app_ActionBar_OnMenuVisibilityListener_Handler")]
		public unsafe override void RemoveOnMenuVisibilityListener(ActionBar.IOnMenuVisibilityListener listener)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((listener == null) ? IntPtr.Zero : ((Java.Lang.Object)listener).Handle);
				ActionBarInvoker._members.InstanceMethods.InvokeAbstractVoidMethod("removeOnMenuVisibilityListener.(Landroidx/appcompat/app/ActionBar$OnMenuVisibilityListener;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(listener);
			}
		}

		// Token: 0x060003A7 RID: 935 RVA: 0x000097E4 File Offset: 0x000079E4
		[Register("removeTab", "(Landroidx/appcompat/app/ActionBar$Tab;)V", "GetRemoveTab_Landroidx_appcompat_app_ActionBar_Tab_Handler")]
		public unsafe override void RemoveTab(ActionBar.Tab tab)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((tab == null) ? IntPtr.Zero : tab.Handle);
				ActionBarInvoker._members.InstanceMethods.InvokeAbstractVoidMethod("removeTab.(Landroidx/appcompat/app/ActionBar$Tab;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(tab);
			}
		}

		// Token: 0x060003A8 RID: 936 RVA: 0x00009848 File Offset: 0x00007A48
		[Register("removeTabAt", "(I)V", "GetRemoveTabAt_IHandler")]
		public unsafe override void RemoveTabAt(int position)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(position);
			ActionBarInvoker._members.InstanceMethods.InvokeAbstractVoidMethod("removeTabAt.(I)V", this, ptr);
		}

		// Token: 0x060003A9 RID: 937 RVA: 0x00009884 File Offset: 0x00007A84
		[Register("selectTab", "(Landroidx/appcompat/app/ActionBar$Tab;)V", "GetSelectTab_Landroidx_appcompat_app_ActionBar_Tab_Handler")]
		public unsafe override void SelectTab(ActionBar.Tab tab)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((tab == null) ? IntPtr.Zero : tab.Handle);
				ActionBarInvoker._members.InstanceMethods.InvokeAbstractVoidMethod("selectTab.(Landroidx/appcompat/app/ActionBar$Tab;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(tab);
			}
		}

		// Token: 0x060003AA RID: 938 RVA: 0x000098E8 File Offset: 0x00007AE8
		[Register("setBackgroundDrawable", "(Landroid/graphics/drawable/Drawable;)V", "GetSetBackgroundDrawable_Landroid_graphics_drawable_Drawable_Handler")]
		public unsafe override void SetBackgroundDrawable(Drawable d)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((d == null) ? IntPtr.Zero : d.Handle);
				ActionBarInvoker._members.InstanceMethods.InvokeAbstractVoidMethod("setBackgroundDrawable.(Landroid/graphics/drawable/Drawable;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(d);
			}
		}

		// Token: 0x060003AB RID: 939 RVA: 0x0000994C File Offset: 0x00007B4C
		[Register("setCustomView", "(Landroid/view/View;Landroidx/appcompat/app/ActionBar$LayoutParams;)V", "GetSetCustomView_Landroid_view_View_Landroidx_appcompat_app_ActionBar_LayoutParams_Handler")]
		public unsafe override void SetCustomView(View view, ActionBar.LayoutParams layoutParams)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((view == null) ? IntPtr.Zero : view.Handle);
				ptr[1] = new JniArgumentValue((layoutParams == null) ? IntPtr.Zero : layoutParams.Handle);
				ActionBarInvoker._members.InstanceMethods.InvokeAbstractVoidMethod("setCustomView.(Landroid/view/View;Landroidx/appcompat/app/ActionBar$LayoutParams;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(view);
				GC.KeepAlive(layoutParams);
			}
		}

		// Token: 0x060003AC RID: 940 RVA: 0x000099D8 File Offset: 0x00007BD8
		[Register("setCustomView", "(I)V", "GetSetCustomView_IHandler")]
		public unsafe override void SetCustomView(int resId)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(resId);
			ActionBarInvoker._members.InstanceMethods.InvokeAbstractVoidMethod("setCustomView.(I)V", this, ptr);
		}

		// Token: 0x060003AD RID: 941 RVA: 0x00009A14 File Offset: 0x00007C14
		[Register("setDisplayHomeAsUpEnabled", "(Z)V", "GetSetDisplayHomeAsUpEnabled_ZHandler")]
		public unsafe override void SetDisplayHomeAsUpEnabled(bool showHomeAsUp)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(showHomeAsUp);
			ActionBarInvoker._members.InstanceMethods.InvokeAbstractVoidMethod("setDisplayHomeAsUpEnabled.(Z)V", this, ptr);
		}

		// Token: 0x060003AE RID: 942 RVA: 0x00009A50 File Offset: 0x00007C50
		[Register("setDisplayOptions", "(II)V", "GetSetDisplayOptions_IIHandler")]
		public unsafe override void SetDisplayOptions(int options, int mask)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(options);
			ptr[1] = new JniArgumentValue(mask);
			ActionBarInvoker._members.InstanceMethods.InvokeAbstractVoidMethod("setDisplayOptions.(II)V", this, ptr);
		}

		// Token: 0x060003AF RID: 943 RVA: 0x00009AA0 File Offset: 0x00007CA0
		[Register("setDisplayShowCustomEnabled", "(Z)V", "GetSetDisplayShowCustomEnabled_ZHandler")]
		public unsafe override void SetDisplayShowCustomEnabled(bool showCustom)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(showCustom);
			ActionBarInvoker._members.InstanceMethods.InvokeAbstractVoidMethod("setDisplayShowCustomEnabled.(Z)V", this, ptr);
		}

		// Token: 0x060003B0 RID: 944 RVA: 0x00009ADC File Offset: 0x00007CDC
		[Register("setDisplayShowHomeEnabled", "(Z)V", "GetSetDisplayShowHomeEnabled_ZHandler")]
		public unsafe override void SetDisplayShowHomeEnabled(bool showHome)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(showHome);
			ActionBarInvoker._members.InstanceMethods.InvokeAbstractVoidMethod("setDisplayShowHomeEnabled.(Z)V", this, ptr);
		}

		// Token: 0x060003B1 RID: 945 RVA: 0x00009B18 File Offset: 0x00007D18
		[Register("setDisplayShowTitleEnabled", "(Z)V", "GetSetDisplayShowTitleEnabled_ZHandler")]
		public unsafe override void SetDisplayShowTitleEnabled(bool showTitle)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(showTitle);
			ActionBarInvoker._members.InstanceMethods.InvokeAbstractVoidMethod("setDisplayShowTitleEnabled.(Z)V", this, ptr);
		}

		// Token: 0x060003B2 RID: 946 RVA: 0x00009B54 File Offset: 0x00007D54
		[Register("setDisplayUseLogoEnabled", "(Z)V", "GetSetDisplayUseLogoEnabled_ZHandler")]
		public unsafe override void SetDisplayUseLogoEnabled(bool useLogo)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(useLogo);
			ActionBarInvoker._members.InstanceMethods.InvokeAbstractVoidMethod("setDisplayUseLogoEnabled.(Z)V", this, ptr);
		}

		// Token: 0x060003B3 RID: 947 RVA: 0x00009B90 File Offset: 0x00007D90
		[Register("setIcon", "(Landroid/graphics/drawable/Drawable;)V", "GetSetIcon_Landroid_graphics_drawable_Drawable_Handler")]
		public unsafe override void SetIcon(Drawable icon)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((icon == null) ? IntPtr.Zero : icon.Handle);
				ActionBarInvoker._members.InstanceMethods.InvokeAbstractVoidMethod("setIcon.(Landroid/graphics/drawable/Drawable;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(icon);
			}
		}

		// Token: 0x060003B4 RID: 948 RVA: 0x00009BF4 File Offset: 0x00007DF4
		[Register("setIcon", "(I)V", "GetSetIcon_IHandler")]
		public unsafe override void SetIcon(int resId)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(resId);
			ActionBarInvoker._members.InstanceMethods.InvokeAbstractVoidMethod("setIcon.(I)V", this, ptr);
		}

		// Token: 0x060003B5 RID: 949 RVA: 0x00009C30 File Offset: 0x00007E30
		[Register("setListNavigationCallbacks", "(Landroid/widget/SpinnerAdapter;Landroidx/appcompat/app/ActionBar$OnNavigationListener;)V", "GetSetListNavigationCallbacks_Landroid_widget_SpinnerAdapter_Landroidx_appcompat_app_ActionBar_OnNavigationListener_Handler")]
		public unsafe override void SetListNavigationCallbacks(ISpinnerAdapter adapter, ActionBar.IOnNavigationListener callback_)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((adapter == null) ? IntPtr.Zero : ((Java.Lang.Object)adapter).Handle);
				ptr[1] = new JniArgumentValue((callback_ == null) ? IntPtr.Zero : ((Java.Lang.Object)callback_).Handle);
				ActionBarInvoker._members.InstanceMethods.InvokeAbstractVoidMethod("setListNavigationCallbacks.(Landroid/widget/SpinnerAdapter;Landroidx/appcompat/app/ActionBar$OnNavigationListener;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(adapter);
				GC.KeepAlive(callback_);
			}
		}

		// Token: 0x060003B6 RID: 950 RVA: 0x00009CC8 File Offset: 0x00007EC8
		[Register("setLogo", "(Landroid/graphics/drawable/Drawable;)V", "GetSetLogo_Landroid_graphics_drawable_Drawable_Handler")]
		public unsafe override void SetLogo(Drawable logo)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((logo == null) ? IntPtr.Zero : logo.Handle);
				ActionBarInvoker._members.InstanceMethods.InvokeAbstractVoidMethod("setLogo.(Landroid/graphics/drawable/Drawable;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(logo);
			}
		}

		// Token: 0x060003B7 RID: 951 RVA: 0x00009D2C File Offset: 0x00007F2C
		[Register("setLogo", "(I)V", "GetSetLogo_IHandler")]
		public unsafe override void SetLogo(int resId)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(resId);
			ActionBarInvoker._members.InstanceMethods.InvokeAbstractVoidMethod("setLogo.(I)V", this, ptr);
		}

		// Token: 0x060003B8 RID: 952 RVA: 0x00009D68 File Offset: 0x00007F68
		[Register("setSelectedNavigationItem", "(I)V", "GetSetSelectedNavigationItem_IHandler")]
		public unsafe override void SetSelectedNavigationItem(int position)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(position);
			ActionBarInvoker._members.InstanceMethods.InvokeAbstractVoidMethod("setSelectedNavigationItem.(I)V", this, ptr);
		}

		// Token: 0x060003B9 RID: 953 RVA: 0x00009DA4 File Offset: 0x00007FA4
		[Register("setSubtitle", "(I)V", "GetSetSubtitle_IHandler")]
		public unsafe override void SetSubtitle(int resId)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(resId);
			ActionBarInvoker._members.InstanceMethods.InvokeAbstractVoidMethod("setSubtitle.(I)V", this, ptr);
		}

		// Token: 0x060003BA RID: 954 RVA: 0x00009DE0 File Offset: 0x00007FE0
		[Register("setTitle", "(I)V", "GetSetTitle_IHandler")]
		public unsafe override void SetTitle(int resId)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(resId);
			ActionBarInvoker._members.InstanceMethods.InvokeAbstractVoidMethod("setTitle.(I)V", this, ptr);
		}

		// Token: 0x060003BB RID: 955 RVA: 0x00009E1B File Offset: 0x0000801B
		[Register("show", "()V", "GetShowHandler")]
		public override void Show()
		{
			ActionBarInvoker._members.InstanceMethods.InvokeAbstractVoidMethod("show.()V", this, null);
		}

		// Token: 0x040000CC RID: 204
		private static readonly JniPeerMembers _members = new XAPeerMembers("androidx/appcompat/app/ActionBar", typeof(ActionBarInvoker));
	}
}
