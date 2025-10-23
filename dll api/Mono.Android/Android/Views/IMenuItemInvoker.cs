using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Content;
using Android.Graphics.Drawables;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Android.Views
{
	// Token: 0x02000122 RID: 290
	[Register("android/view/MenuItem", DoNotGenerateAcw = true)]
	internal class IMenuItemInvoker : Java.Lang.Object, IMenuItem, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x1700019F RID: 415
		// (get) Token: 0x06000847 RID: 2119 RVA: 0x000136A4 File Offset: 0x000118A4
		private static IntPtr java_class_ref
		{
			get
			{
				return IMenuItemInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170001A0 RID: 416
		// (get) Token: 0x06000848 RID: 2120 RVA: 0x000136C8 File Offset: 0x000118C8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IMenuItemInvoker._members;
			}
		}

		// Token: 0x170001A1 RID: 417
		// (get) Token: 0x06000849 RID: 2121 RVA: 0x000136CF File Offset: 0x000118CF
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x170001A2 RID: 418
		// (get) Token: 0x0600084A RID: 2122 RVA: 0x000136D7 File Offset: 0x000118D7
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IMenuItemInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x0600084B RID: 2123 RVA: 0x000136E3 File Offset: 0x000118E3
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IMenuItemInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'android.view.MenuItem'.");
			}
			return handle;
		}

		// Token: 0x0600084C RID: 2124 RVA: 0x0001370E File Offset: 0x0001190E
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x0600084D RID: 2125 RVA: 0x00013740 File Offset: 0x00011940
		public IMenuItemInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IMenuItemInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x0600084E RID: 2126 RVA: 0x00013778 File Offset: 0x00011978
		private static Delegate GetGetActionProviderHandler()
		{
			if (IMenuItemInvoker.cb_getActionProvider == null)
			{
				IMenuItemInvoker.cb_getActionProvider = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IMenuItemInvoker.n_GetActionProvider));
			}
			return IMenuItemInvoker.cb_getActionProvider;
		}

		// Token: 0x0600084F RID: 2127 RVA: 0x0001379C File Offset: 0x0001199C
		private static IntPtr n_GetActionProvider(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IMenuItem>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ActionProvider);
		}

		// Token: 0x170001A3 RID: 419
		// (get) Token: 0x06000850 RID: 2128 RVA: 0x000137B0 File Offset: 0x000119B0
		public ActionProvider ActionProvider
		{
			get
			{
				if (this.id_getActionProvider == IntPtr.Zero)
				{
					this.id_getActionProvider = JNIEnv.GetMethodID(this.class_ref, "getActionProvider", "()Landroid/view/ActionProvider;");
				}
				return Java.Lang.Object.GetObject<ActionProvider>(JNIEnv.CallObjectMethod(base.Handle, this.id_getActionProvider), JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06000851 RID: 2129 RVA: 0x00013801 File Offset: 0x00011A01
		private static Delegate GetGetActionViewHandler()
		{
			if (IMenuItemInvoker.cb_getActionView == null)
			{
				IMenuItemInvoker.cb_getActionView = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IMenuItemInvoker.n_GetActionView));
			}
			return IMenuItemInvoker.cb_getActionView;
		}

		// Token: 0x06000852 RID: 2130 RVA: 0x00013825 File Offset: 0x00011A25
		private static IntPtr n_GetActionView(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IMenuItem>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ActionView);
		}

		// Token: 0x170001A4 RID: 420
		// (get) Token: 0x06000853 RID: 2131 RVA: 0x0001383C File Offset: 0x00011A3C
		public View ActionView
		{
			get
			{
				if (this.id_getActionView == IntPtr.Zero)
				{
					this.id_getActionView = JNIEnv.GetMethodID(this.class_ref, "getActionView", "()Landroid/view/View;");
				}
				return Java.Lang.Object.GetObject<View>(JNIEnv.CallObjectMethod(base.Handle, this.id_getActionView), JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06000854 RID: 2132 RVA: 0x0001388D File Offset: 0x00011A8D
		private static Delegate GetGetAlphabeticShortcutHandler()
		{
			if (IMenuItemInvoker.cb_getAlphabeticShortcut == null)
			{
				IMenuItemInvoker.cb_getAlphabeticShortcut = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_C(IMenuItemInvoker.n_GetAlphabeticShortcut));
			}
			return IMenuItemInvoker.cb_getAlphabeticShortcut;
		}

		// Token: 0x06000855 RID: 2133 RVA: 0x000138B1 File Offset: 0x00011AB1
		private static char n_GetAlphabeticShortcut(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IMenuItem>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).AlphabeticShortcut;
		}

		// Token: 0x170001A5 RID: 421
		// (get) Token: 0x06000856 RID: 2134 RVA: 0x000138C0 File Offset: 0x00011AC0
		public char AlphabeticShortcut
		{
			get
			{
				if (this.id_getAlphabeticShortcut == IntPtr.Zero)
				{
					this.id_getAlphabeticShortcut = JNIEnv.GetMethodID(this.class_ref, "getAlphabeticShortcut", "()C");
				}
				return JNIEnv.CallCharMethod(base.Handle, this.id_getAlphabeticShortcut);
			}
		}

		// Token: 0x06000857 RID: 2135 RVA: 0x00013900 File Offset: 0x00011B00
		private static Delegate GetGetGroupIdHandler()
		{
			if (IMenuItemInvoker.cb_getGroupId == null)
			{
				IMenuItemInvoker.cb_getGroupId = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(IMenuItemInvoker.n_GetGroupId));
			}
			return IMenuItemInvoker.cb_getGroupId;
		}

		// Token: 0x06000858 RID: 2136 RVA: 0x00013924 File Offset: 0x00011B24
		private static int n_GetGroupId(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IMenuItem>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).GroupId;
		}

		// Token: 0x170001A6 RID: 422
		// (get) Token: 0x06000859 RID: 2137 RVA: 0x00013933 File Offset: 0x00011B33
		public int GroupId
		{
			get
			{
				if (this.id_getGroupId == IntPtr.Zero)
				{
					this.id_getGroupId = JNIEnv.GetMethodID(this.class_ref, "getGroupId", "()I");
				}
				return JNIEnv.CallIntMethod(base.Handle, this.id_getGroupId);
			}
		}

		// Token: 0x0600085A RID: 2138 RVA: 0x00013973 File Offset: 0x00011B73
		private static Delegate GetHasSubMenuHandler()
		{
			if (IMenuItemInvoker.cb_hasSubMenu == null)
			{
				IMenuItemInvoker.cb_hasSubMenu = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(IMenuItemInvoker.n_HasSubMenu));
			}
			return IMenuItemInvoker.cb_hasSubMenu;
		}

		// Token: 0x0600085B RID: 2139 RVA: 0x00013997 File Offset: 0x00011B97
		private static bool n_HasSubMenu(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IMenuItem>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).HasSubMenu;
		}

		// Token: 0x170001A7 RID: 423
		// (get) Token: 0x0600085C RID: 2140 RVA: 0x000139A6 File Offset: 0x00011BA6
		public bool HasSubMenu
		{
			get
			{
				if (this.id_hasSubMenu == IntPtr.Zero)
				{
					this.id_hasSubMenu = JNIEnv.GetMethodID(this.class_ref, "hasSubMenu", "()Z");
				}
				return JNIEnv.CallBooleanMethod(base.Handle, this.id_hasSubMenu);
			}
		}

		// Token: 0x0600085D RID: 2141 RVA: 0x000139E6 File Offset: 0x00011BE6
		private static Delegate GetGetIconHandler()
		{
			if (IMenuItemInvoker.cb_getIcon == null)
			{
				IMenuItemInvoker.cb_getIcon = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IMenuItemInvoker.n_GetIcon));
			}
			return IMenuItemInvoker.cb_getIcon;
		}

		// Token: 0x0600085E RID: 2142 RVA: 0x00013A0A File Offset: 0x00011C0A
		private static IntPtr n_GetIcon(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IMenuItem>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Icon);
		}

		// Token: 0x170001A8 RID: 424
		// (get) Token: 0x0600085F RID: 2143 RVA: 0x00013A20 File Offset: 0x00011C20
		public Drawable Icon
		{
			get
			{
				if (this.id_getIcon == IntPtr.Zero)
				{
					this.id_getIcon = JNIEnv.GetMethodID(this.class_ref, "getIcon", "()Landroid/graphics/drawable/Drawable;");
				}
				return Java.Lang.Object.GetObject<Drawable>(JNIEnv.CallObjectMethod(base.Handle, this.id_getIcon), JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06000860 RID: 2144 RVA: 0x00013A71 File Offset: 0x00011C71
		private static Delegate GetGetIntentHandler()
		{
			if (IMenuItemInvoker.cb_getIntent == null)
			{
				IMenuItemInvoker.cb_getIntent = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IMenuItemInvoker.n_GetIntent));
			}
			return IMenuItemInvoker.cb_getIntent;
		}

		// Token: 0x06000861 RID: 2145 RVA: 0x00013A95 File Offset: 0x00011C95
		private static IntPtr n_GetIntent(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IMenuItem>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Intent);
		}

		// Token: 0x170001A9 RID: 425
		// (get) Token: 0x06000862 RID: 2146 RVA: 0x00013AAC File Offset: 0x00011CAC
		public Intent Intent
		{
			get
			{
				if (this.id_getIntent == IntPtr.Zero)
				{
					this.id_getIntent = JNIEnv.GetMethodID(this.class_ref, "getIntent", "()Landroid/content/Intent;");
				}
				return Java.Lang.Object.GetObject<Intent>(JNIEnv.CallObjectMethod(base.Handle, this.id_getIntent), JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06000863 RID: 2147 RVA: 0x00013AFD File Offset: 0x00011CFD
		private static Delegate GetIsActionViewExpandedHandler()
		{
			if (IMenuItemInvoker.cb_isActionViewExpanded == null)
			{
				IMenuItemInvoker.cb_isActionViewExpanded = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(IMenuItemInvoker.n_IsActionViewExpanded));
			}
			return IMenuItemInvoker.cb_isActionViewExpanded;
		}

		// Token: 0x06000864 RID: 2148 RVA: 0x00013B21 File Offset: 0x00011D21
		private static bool n_IsActionViewExpanded(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IMenuItem>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsActionViewExpanded;
		}

		// Token: 0x170001AA RID: 426
		// (get) Token: 0x06000865 RID: 2149 RVA: 0x00013B30 File Offset: 0x00011D30
		public bool IsActionViewExpanded
		{
			get
			{
				if (this.id_isActionViewExpanded == IntPtr.Zero)
				{
					this.id_isActionViewExpanded = JNIEnv.GetMethodID(this.class_ref, "isActionViewExpanded", "()Z");
				}
				return JNIEnv.CallBooleanMethod(base.Handle, this.id_isActionViewExpanded);
			}
		}

		// Token: 0x06000866 RID: 2150 RVA: 0x00013B70 File Offset: 0x00011D70
		private static Delegate GetIsCheckableHandler()
		{
			if (IMenuItemInvoker.cb_isCheckable == null)
			{
				IMenuItemInvoker.cb_isCheckable = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(IMenuItemInvoker.n_IsCheckable));
			}
			return IMenuItemInvoker.cb_isCheckable;
		}

		// Token: 0x06000867 RID: 2151 RVA: 0x00013B94 File Offset: 0x00011D94
		private static bool n_IsCheckable(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IMenuItem>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsCheckable;
		}

		// Token: 0x170001AB RID: 427
		// (get) Token: 0x06000868 RID: 2152 RVA: 0x00013BA3 File Offset: 0x00011DA3
		public bool IsCheckable
		{
			get
			{
				if (this.id_isCheckable == IntPtr.Zero)
				{
					this.id_isCheckable = JNIEnv.GetMethodID(this.class_ref, "isCheckable", "()Z");
				}
				return JNIEnv.CallBooleanMethod(base.Handle, this.id_isCheckable);
			}
		}

		// Token: 0x06000869 RID: 2153 RVA: 0x00013BE3 File Offset: 0x00011DE3
		private static Delegate GetIsCheckedHandler()
		{
			if (IMenuItemInvoker.cb_isChecked == null)
			{
				IMenuItemInvoker.cb_isChecked = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(IMenuItemInvoker.n_IsChecked));
			}
			return IMenuItemInvoker.cb_isChecked;
		}

		// Token: 0x0600086A RID: 2154 RVA: 0x00013C07 File Offset: 0x00011E07
		private static bool n_IsChecked(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IMenuItem>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsChecked;
		}

		// Token: 0x170001AC RID: 428
		// (get) Token: 0x0600086B RID: 2155 RVA: 0x00013C16 File Offset: 0x00011E16
		public bool IsChecked
		{
			get
			{
				if (this.id_isChecked == IntPtr.Zero)
				{
					this.id_isChecked = JNIEnv.GetMethodID(this.class_ref, "isChecked", "()Z");
				}
				return JNIEnv.CallBooleanMethod(base.Handle, this.id_isChecked);
			}
		}

		// Token: 0x0600086C RID: 2156 RVA: 0x00013C56 File Offset: 0x00011E56
		private static Delegate GetIsEnabledHandler()
		{
			if (IMenuItemInvoker.cb_isEnabled == null)
			{
				IMenuItemInvoker.cb_isEnabled = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(IMenuItemInvoker.n_IsEnabled));
			}
			return IMenuItemInvoker.cb_isEnabled;
		}

		// Token: 0x0600086D RID: 2157 RVA: 0x00013C7A File Offset: 0x00011E7A
		private static bool n_IsEnabled(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IMenuItem>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsEnabled;
		}

		// Token: 0x170001AD RID: 429
		// (get) Token: 0x0600086E RID: 2158 RVA: 0x00013C89 File Offset: 0x00011E89
		public bool IsEnabled
		{
			get
			{
				if (this.id_isEnabled == IntPtr.Zero)
				{
					this.id_isEnabled = JNIEnv.GetMethodID(this.class_ref, "isEnabled", "()Z");
				}
				return JNIEnv.CallBooleanMethod(base.Handle, this.id_isEnabled);
			}
		}

		// Token: 0x0600086F RID: 2159 RVA: 0x00013CC9 File Offset: 0x00011EC9
		private static Delegate GetIsVisibleHandler()
		{
			if (IMenuItemInvoker.cb_isVisible == null)
			{
				IMenuItemInvoker.cb_isVisible = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(IMenuItemInvoker.n_IsVisible));
			}
			return IMenuItemInvoker.cb_isVisible;
		}

		// Token: 0x06000870 RID: 2160 RVA: 0x00013CED File Offset: 0x00011EED
		private static bool n_IsVisible(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IMenuItem>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsVisible;
		}

		// Token: 0x170001AE RID: 430
		// (get) Token: 0x06000871 RID: 2161 RVA: 0x00013CFC File Offset: 0x00011EFC
		public bool IsVisible
		{
			get
			{
				if (this.id_isVisible == IntPtr.Zero)
				{
					this.id_isVisible = JNIEnv.GetMethodID(this.class_ref, "isVisible", "()Z");
				}
				return JNIEnv.CallBooleanMethod(base.Handle, this.id_isVisible);
			}
		}

		// Token: 0x06000872 RID: 2162 RVA: 0x00013D3C File Offset: 0x00011F3C
		private static Delegate GetGetItemIdHandler()
		{
			if (IMenuItemInvoker.cb_getItemId == null)
			{
				IMenuItemInvoker.cb_getItemId = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(IMenuItemInvoker.n_GetItemId));
			}
			return IMenuItemInvoker.cb_getItemId;
		}

		// Token: 0x06000873 RID: 2163 RVA: 0x00013D60 File Offset: 0x00011F60
		private static int n_GetItemId(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IMenuItem>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ItemId;
		}

		// Token: 0x170001AF RID: 431
		// (get) Token: 0x06000874 RID: 2164 RVA: 0x00013D6F File Offset: 0x00011F6F
		public int ItemId
		{
			get
			{
				if (this.id_getItemId == IntPtr.Zero)
				{
					this.id_getItemId = JNIEnv.GetMethodID(this.class_ref, "getItemId", "()I");
				}
				return JNIEnv.CallIntMethod(base.Handle, this.id_getItemId);
			}
		}

		// Token: 0x06000875 RID: 2165 RVA: 0x00013DAF File Offset: 0x00011FAF
		private static Delegate GetGetMenuInfoHandler()
		{
			if (IMenuItemInvoker.cb_getMenuInfo == null)
			{
				IMenuItemInvoker.cb_getMenuInfo = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IMenuItemInvoker.n_GetMenuInfo));
			}
			return IMenuItemInvoker.cb_getMenuInfo;
		}

		// Token: 0x06000876 RID: 2166 RVA: 0x00013DD3 File Offset: 0x00011FD3
		private static IntPtr n_GetMenuInfo(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IMenuItem>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).MenuInfo);
		}

		// Token: 0x170001B0 RID: 432
		// (get) Token: 0x06000877 RID: 2167 RVA: 0x00013DE8 File Offset: 0x00011FE8
		public IContextMenuContextMenuInfo MenuInfo
		{
			get
			{
				if (this.id_getMenuInfo == IntPtr.Zero)
				{
					this.id_getMenuInfo = JNIEnv.GetMethodID(this.class_ref, "getMenuInfo", "()Landroid/view/ContextMenu$ContextMenuInfo;");
				}
				return Java.Lang.Object.GetObject<IContextMenuContextMenuInfo>(JNIEnv.CallObjectMethod(base.Handle, this.id_getMenuInfo), JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06000878 RID: 2168 RVA: 0x00013E39 File Offset: 0x00012039
		private static Delegate GetGetNumericShortcutHandler()
		{
			if (IMenuItemInvoker.cb_getNumericShortcut == null)
			{
				IMenuItemInvoker.cb_getNumericShortcut = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_C(IMenuItemInvoker.n_GetNumericShortcut));
			}
			return IMenuItemInvoker.cb_getNumericShortcut;
		}

		// Token: 0x06000879 RID: 2169 RVA: 0x00013E5D File Offset: 0x0001205D
		private static char n_GetNumericShortcut(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IMenuItem>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).NumericShortcut;
		}

		// Token: 0x170001B1 RID: 433
		// (get) Token: 0x0600087A RID: 2170 RVA: 0x00013E6C File Offset: 0x0001206C
		public char NumericShortcut
		{
			get
			{
				if (this.id_getNumericShortcut == IntPtr.Zero)
				{
					this.id_getNumericShortcut = JNIEnv.GetMethodID(this.class_ref, "getNumericShortcut", "()C");
				}
				return JNIEnv.CallCharMethod(base.Handle, this.id_getNumericShortcut);
			}
		}

		// Token: 0x0600087B RID: 2171 RVA: 0x00013EAC File Offset: 0x000120AC
		private static Delegate GetGetOrderHandler()
		{
			if (IMenuItemInvoker.cb_getOrder == null)
			{
				IMenuItemInvoker.cb_getOrder = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(IMenuItemInvoker.n_GetOrder));
			}
			return IMenuItemInvoker.cb_getOrder;
		}

		// Token: 0x0600087C RID: 2172 RVA: 0x00013ED0 File Offset: 0x000120D0
		private static int n_GetOrder(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IMenuItem>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Order;
		}

		// Token: 0x170001B2 RID: 434
		// (get) Token: 0x0600087D RID: 2173 RVA: 0x00013EDF File Offset: 0x000120DF
		public int Order
		{
			get
			{
				if (this.id_getOrder == IntPtr.Zero)
				{
					this.id_getOrder = JNIEnv.GetMethodID(this.class_ref, "getOrder", "()I");
				}
				return JNIEnv.CallIntMethod(base.Handle, this.id_getOrder);
			}
		}

		// Token: 0x0600087E RID: 2174 RVA: 0x00013F1F File Offset: 0x0001211F
		private static Delegate GetGetSubMenuHandler()
		{
			if (IMenuItemInvoker.cb_getSubMenu == null)
			{
				IMenuItemInvoker.cb_getSubMenu = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IMenuItemInvoker.n_GetSubMenu));
			}
			return IMenuItemInvoker.cb_getSubMenu;
		}

		// Token: 0x0600087F RID: 2175 RVA: 0x00013F43 File Offset: 0x00012143
		private static IntPtr n_GetSubMenu(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IMenuItem>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SubMenu);
		}

		// Token: 0x170001B3 RID: 435
		// (get) Token: 0x06000880 RID: 2176 RVA: 0x00013F58 File Offset: 0x00012158
		public ISubMenu SubMenu
		{
			get
			{
				if (this.id_getSubMenu == IntPtr.Zero)
				{
					this.id_getSubMenu = JNIEnv.GetMethodID(this.class_ref, "getSubMenu", "()Landroid/view/SubMenu;");
				}
				return Java.Lang.Object.GetObject<ISubMenu>(JNIEnv.CallObjectMethod(base.Handle, this.id_getSubMenu), JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06000881 RID: 2177 RVA: 0x00013FA9 File Offset: 0x000121A9
		private static Delegate GetGetTitleHandler()
		{
			if (IMenuItemInvoker.cb_getTitle == null)
			{
				IMenuItemInvoker.cb_getTitle = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IMenuItemInvoker.n_GetTitle));
			}
			return IMenuItemInvoker.cb_getTitle;
		}

		// Token: 0x06000882 RID: 2178 RVA: 0x00013FCD File Offset: 0x000121CD
		private static IntPtr n_GetTitle(IntPtr jnienv, IntPtr native__this)
		{
			return CharSequence.ToLocalJniHandle(Java.Lang.Object.GetObject<IMenuItem>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).TitleFormatted);
		}

		// Token: 0x170001B4 RID: 436
		// (get) Token: 0x06000883 RID: 2179 RVA: 0x00013FE4 File Offset: 0x000121E4
		public ICharSequence TitleFormatted
		{
			get
			{
				if (this.id_getTitle == IntPtr.Zero)
				{
					this.id_getTitle = JNIEnv.GetMethodID(this.class_ref, "getTitle", "()Ljava/lang/CharSequence;");
				}
				return Java.Lang.Object.GetObject<ICharSequence>(JNIEnv.CallObjectMethod(base.Handle, this.id_getTitle), JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06000884 RID: 2180 RVA: 0x00014035 File Offset: 0x00012235
		private static Delegate GetGetTitleCondensedHandler()
		{
			if (IMenuItemInvoker.cb_getTitleCondensed == null)
			{
				IMenuItemInvoker.cb_getTitleCondensed = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IMenuItemInvoker.n_GetTitleCondensed));
			}
			return IMenuItemInvoker.cb_getTitleCondensed;
		}

		// Token: 0x06000885 RID: 2181 RVA: 0x00014059 File Offset: 0x00012259
		private static IntPtr n_GetTitleCondensed(IntPtr jnienv, IntPtr native__this)
		{
			return CharSequence.ToLocalJniHandle(Java.Lang.Object.GetObject<IMenuItem>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).TitleCondensedFormatted);
		}

		// Token: 0x170001B5 RID: 437
		// (get) Token: 0x06000886 RID: 2182 RVA: 0x00014070 File Offset: 0x00012270
		public ICharSequence TitleCondensedFormatted
		{
			get
			{
				if (this.id_getTitleCondensed == IntPtr.Zero)
				{
					this.id_getTitleCondensed = JNIEnv.GetMethodID(this.class_ref, "getTitleCondensed", "()Ljava/lang/CharSequence;");
				}
				return Java.Lang.Object.GetObject<ICharSequence>(JNIEnv.CallObjectMethod(base.Handle, this.id_getTitleCondensed), JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06000887 RID: 2183 RVA: 0x000140C1 File Offset: 0x000122C1
		private static Delegate GetCollapseActionViewHandler()
		{
			if (IMenuItemInvoker.cb_collapseActionView == null)
			{
				IMenuItemInvoker.cb_collapseActionView = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(IMenuItemInvoker.n_CollapseActionView));
			}
			return IMenuItemInvoker.cb_collapseActionView;
		}

		// Token: 0x06000888 RID: 2184 RVA: 0x000140E5 File Offset: 0x000122E5
		private static bool n_CollapseActionView(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IMenuItem>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).CollapseActionView();
		}

		// Token: 0x06000889 RID: 2185 RVA: 0x000140F4 File Offset: 0x000122F4
		public bool CollapseActionView()
		{
			if (this.id_collapseActionView == IntPtr.Zero)
			{
				this.id_collapseActionView = JNIEnv.GetMethodID(this.class_ref, "collapseActionView", "()Z");
			}
			return JNIEnv.CallBooleanMethod(base.Handle, this.id_collapseActionView);
		}

		// Token: 0x0600088A RID: 2186 RVA: 0x00014134 File Offset: 0x00012334
		private static Delegate GetExpandActionViewHandler()
		{
			if (IMenuItemInvoker.cb_expandActionView == null)
			{
				IMenuItemInvoker.cb_expandActionView = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(IMenuItemInvoker.n_ExpandActionView));
			}
			return IMenuItemInvoker.cb_expandActionView;
		}

		// Token: 0x0600088B RID: 2187 RVA: 0x00014158 File Offset: 0x00012358
		private static bool n_ExpandActionView(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IMenuItem>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ExpandActionView();
		}

		// Token: 0x0600088C RID: 2188 RVA: 0x00014167 File Offset: 0x00012367
		public bool ExpandActionView()
		{
			if (this.id_expandActionView == IntPtr.Zero)
			{
				this.id_expandActionView = JNIEnv.GetMethodID(this.class_ref, "expandActionView", "()Z");
			}
			return JNIEnv.CallBooleanMethod(base.Handle, this.id_expandActionView);
		}

		// Token: 0x0600088D RID: 2189 RVA: 0x000141A7 File Offset: 0x000123A7
		private static Delegate GetSetActionProvider_Landroid_view_ActionProvider_Handler()
		{
			if (IMenuItemInvoker.cb_setActionProvider_Landroid_view_ActionProvider_ == null)
			{
				IMenuItemInvoker.cb_setActionProvider_Landroid_view_ActionProvider_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(IMenuItemInvoker.n_SetActionProvider_Landroid_view_ActionProvider_));
			}
			return IMenuItemInvoker.cb_setActionProvider_Landroid_view_ActionProvider_;
		}

		// Token: 0x0600088E RID: 2190 RVA: 0x000141CC File Offset: 0x000123CC
		private static IntPtr n_SetActionProvider_Landroid_view_ActionProvider_(IntPtr jnienv, IntPtr native__this, IntPtr native_actionProvider)
		{
			IMenuItem @object = Java.Lang.Object.GetObject<IMenuItem>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ActionProvider object2 = Java.Lang.Object.GetObject<ActionProvider>(native_actionProvider, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.SetActionProvider(object2));
		}

		// Token: 0x0600088F RID: 2191 RVA: 0x000141F4 File Offset: 0x000123F4
		public unsafe IMenuItem SetActionProvider(ActionProvider actionProvider)
		{
			if (this.id_setActionProvider_Landroid_view_ActionProvider_ == IntPtr.Zero)
			{
				this.id_setActionProvider_Landroid_view_ActionProvider_ = JNIEnv.GetMethodID(this.class_ref, "setActionProvider", "(Landroid/view/ActionProvider;)Landroid/view/MenuItem;");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((actionProvider == null) ? IntPtr.Zero : actionProvider.Handle);
			return Java.Lang.Object.GetObject<IMenuItem>(JNIEnv.CallObjectMethod(base.Handle, this.id_setActionProvider_Landroid_view_ActionProvider_, ptr), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06000890 RID: 2192 RVA: 0x0001426D File Offset: 0x0001246D
		private static Delegate GetSetActionView_Landroid_view_View_Handler()
		{
			if (IMenuItemInvoker.cb_setActionView_Landroid_view_View_ == null)
			{
				IMenuItemInvoker.cb_setActionView_Landroid_view_View_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(IMenuItemInvoker.n_SetActionView_Landroid_view_View_));
			}
			return IMenuItemInvoker.cb_setActionView_Landroid_view_View_;
		}

		// Token: 0x06000891 RID: 2193 RVA: 0x00014294 File Offset: 0x00012494
		private static IntPtr n_SetActionView_Landroid_view_View_(IntPtr jnienv, IntPtr native__this, IntPtr native_view)
		{
			IMenuItem @object = Java.Lang.Object.GetObject<IMenuItem>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			View object2 = Java.Lang.Object.GetObject<View>(native_view, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.SetActionView(object2));
		}

		// Token: 0x06000892 RID: 2194 RVA: 0x000142BC File Offset: 0x000124BC
		public unsafe IMenuItem SetActionView(View view)
		{
			if (this.id_setActionView_Landroid_view_View_ == IntPtr.Zero)
			{
				this.id_setActionView_Landroid_view_View_ = JNIEnv.GetMethodID(this.class_ref, "setActionView", "(Landroid/view/View;)Landroid/view/MenuItem;");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((view == null) ? IntPtr.Zero : view.Handle);
			return Java.Lang.Object.GetObject<IMenuItem>(JNIEnv.CallObjectMethod(base.Handle, this.id_setActionView_Landroid_view_View_, ptr), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06000893 RID: 2195 RVA: 0x00014335 File Offset: 0x00012535
		private static Delegate GetSetActionView_IHandler()
		{
			if (IMenuItemInvoker.cb_setActionView_I == null)
			{
				IMenuItemInvoker.cb_setActionView_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_L(IMenuItemInvoker.n_SetActionView_I));
			}
			return IMenuItemInvoker.cb_setActionView_I;
		}

		// Token: 0x06000894 RID: 2196 RVA: 0x00014359 File Offset: 0x00012559
		private static IntPtr n_SetActionView_I(IntPtr jnienv, IntPtr native__this, int resId)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IMenuItem>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SetActionView(resId));
		}

		// Token: 0x06000895 RID: 2197 RVA: 0x00014370 File Offset: 0x00012570
		public unsafe IMenuItem SetActionView(int resId)
		{
			if (this.id_setActionView_I == IntPtr.Zero)
			{
				this.id_setActionView_I = JNIEnv.GetMethodID(this.class_ref, "setActionView", "(I)Landroid/view/MenuItem;");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(resId);
			return Java.Lang.Object.GetObject<IMenuItem>(JNIEnv.CallObjectMethod(base.Handle, this.id_setActionView_I, ptr), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06000896 RID: 2198 RVA: 0x000143DA File Offset: 0x000125DA
		private static Delegate GetSetAlphabeticShortcut_CHandler()
		{
			if (IMenuItemInvoker.cb_setAlphabeticShortcut_C == null)
			{
				IMenuItemInvoker.cb_setAlphabeticShortcut_C = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPC_L(IMenuItemInvoker.n_SetAlphabeticShortcut_C));
			}
			return IMenuItemInvoker.cb_setAlphabeticShortcut_C;
		}

		// Token: 0x06000897 RID: 2199 RVA: 0x000143FE File Offset: 0x000125FE
		private static IntPtr n_SetAlphabeticShortcut_C(IntPtr jnienv, IntPtr native__this, char alphaChar)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IMenuItem>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SetAlphabeticShortcut(alphaChar));
		}

		// Token: 0x06000898 RID: 2200 RVA: 0x00014414 File Offset: 0x00012614
		public unsafe IMenuItem SetAlphabeticShortcut(char alphaChar)
		{
			if (this.id_setAlphabeticShortcut_C == IntPtr.Zero)
			{
				this.id_setAlphabeticShortcut_C = JNIEnv.GetMethodID(this.class_ref, "setAlphabeticShortcut", "(C)Landroid/view/MenuItem;");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(alphaChar);
			return Java.Lang.Object.GetObject<IMenuItem>(JNIEnv.CallObjectMethod(base.Handle, this.id_setAlphabeticShortcut_C, ptr), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06000899 RID: 2201 RVA: 0x0001447E File Offset: 0x0001267E
		private static Delegate GetSetCheckable_ZHandler()
		{
			if (IMenuItemInvoker.cb_setCheckable_Z == null)
			{
				IMenuItemInvoker.cb_setCheckable_Z = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPZ_L(IMenuItemInvoker.n_SetCheckable_Z));
			}
			return IMenuItemInvoker.cb_setCheckable_Z;
		}

		// Token: 0x0600089A RID: 2202 RVA: 0x000144A2 File Offset: 0x000126A2
		private static IntPtr n_SetCheckable_Z(IntPtr jnienv, IntPtr native__this, bool checkable)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IMenuItem>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SetCheckable(checkable));
		}

		// Token: 0x0600089B RID: 2203 RVA: 0x000144B8 File Offset: 0x000126B8
		public unsafe IMenuItem SetCheckable(bool checkable)
		{
			if (this.id_setCheckable_Z == IntPtr.Zero)
			{
				this.id_setCheckable_Z = JNIEnv.GetMethodID(this.class_ref, "setCheckable", "(Z)Landroid/view/MenuItem;");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(checkable);
			return Java.Lang.Object.GetObject<IMenuItem>(JNIEnv.CallObjectMethod(base.Handle, this.id_setCheckable_Z, ptr), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x0600089C RID: 2204 RVA: 0x00014522 File Offset: 0x00012722
		private static Delegate GetSetChecked_ZHandler()
		{
			if (IMenuItemInvoker.cb_setChecked_Z == null)
			{
				IMenuItemInvoker.cb_setChecked_Z = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPZ_L(IMenuItemInvoker.n_SetChecked_Z));
			}
			return IMenuItemInvoker.cb_setChecked_Z;
		}

		// Token: 0x0600089D RID: 2205 RVA: 0x00014546 File Offset: 0x00012746
		private static IntPtr n_SetChecked_Z(IntPtr jnienv, IntPtr native__this, bool @checked)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IMenuItem>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SetChecked(@checked));
		}

		// Token: 0x0600089E RID: 2206 RVA: 0x0001455C File Offset: 0x0001275C
		public unsafe IMenuItem SetChecked(bool @checked)
		{
			if (this.id_setChecked_Z == IntPtr.Zero)
			{
				this.id_setChecked_Z = JNIEnv.GetMethodID(this.class_ref, "setChecked", "(Z)Landroid/view/MenuItem;");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(@checked);
			return Java.Lang.Object.GetObject<IMenuItem>(JNIEnv.CallObjectMethod(base.Handle, this.id_setChecked_Z, ptr), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x0600089F RID: 2207 RVA: 0x000145C6 File Offset: 0x000127C6
		private static Delegate GetSetEnabled_ZHandler()
		{
			if (IMenuItemInvoker.cb_setEnabled_Z == null)
			{
				IMenuItemInvoker.cb_setEnabled_Z = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPZ_L(IMenuItemInvoker.n_SetEnabled_Z));
			}
			return IMenuItemInvoker.cb_setEnabled_Z;
		}

		// Token: 0x060008A0 RID: 2208 RVA: 0x000145EA File Offset: 0x000127EA
		private static IntPtr n_SetEnabled_Z(IntPtr jnienv, IntPtr native__this, bool enabled)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IMenuItem>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SetEnabled(enabled));
		}

		// Token: 0x060008A1 RID: 2209 RVA: 0x00014600 File Offset: 0x00012800
		public unsafe IMenuItem SetEnabled(bool enabled)
		{
			if (this.id_setEnabled_Z == IntPtr.Zero)
			{
				this.id_setEnabled_Z = JNIEnv.GetMethodID(this.class_ref, "setEnabled", "(Z)Landroid/view/MenuItem;");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(enabled);
			return Java.Lang.Object.GetObject<IMenuItem>(JNIEnv.CallObjectMethod(base.Handle, this.id_setEnabled_Z, ptr), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x060008A2 RID: 2210 RVA: 0x0001466A File Offset: 0x0001286A
		private static Delegate GetSetIcon_Landroid_graphics_drawable_Drawable_Handler()
		{
			if (IMenuItemInvoker.cb_setIcon_Landroid_graphics_drawable_Drawable_ == null)
			{
				IMenuItemInvoker.cb_setIcon_Landroid_graphics_drawable_Drawable_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(IMenuItemInvoker.n_SetIcon_Landroid_graphics_drawable_Drawable_));
			}
			return IMenuItemInvoker.cb_setIcon_Landroid_graphics_drawable_Drawable_;
		}

		// Token: 0x060008A3 RID: 2211 RVA: 0x00014690 File Offset: 0x00012890
		private static IntPtr n_SetIcon_Landroid_graphics_drawable_Drawable_(IntPtr jnienv, IntPtr native__this, IntPtr native_icon)
		{
			IMenuItem @object = Java.Lang.Object.GetObject<IMenuItem>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Drawable object2 = Java.Lang.Object.GetObject<Drawable>(native_icon, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.SetIcon(object2));
		}

		// Token: 0x060008A4 RID: 2212 RVA: 0x000146B8 File Offset: 0x000128B8
		public unsafe IMenuItem SetIcon(Drawable icon)
		{
			if (this.id_setIcon_Landroid_graphics_drawable_Drawable_ == IntPtr.Zero)
			{
				this.id_setIcon_Landroid_graphics_drawable_Drawable_ = JNIEnv.GetMethodID(this.class_ref, "setIcon", "(Landroid/graphics/drawable/Drawable;)Landroid/view/MenuItem;");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((icon == null) ? IntPtr.Zero : icon.Handle);
			return Java.Lang.Object.GetObject<IMenuItem>(JNIEnv.CallObjectMethod(base.Handle, this.id_setIcon_Landroid_graphics_drawable_Drawable_, ptr), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x060008A5 RID: 2213 RVA: 0x00014731 File Offset: 0x00012931
		private static Delegate GetSetIcon_IHandler()
		{
			if (IMenuItemInvoker.cb_setIcon_I == null)
			{
				IMenuItemInvoker.cb_setIcon_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_L(IMenuItemInvoker.n_SetIcon_I));
			}
			return IMenuItemInvoker.cb_setIcon_I;
		}

		// Token: 0x060008A6 RID: 2214 RVA: 0x00014755 File Offset: 0x00012955
		private static IntPtr n_SetIcon_I(IntPtr jnienv, IntPtr native__this, int iconRes)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IMenuItem>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SetIcon(iconRes));
		}

		// Token: 0x060008A7 RID: 2215 RVA: 0x0001476C File Offset: 0x0001296C
		public unsafe IMenuItem SetIcon(int iconRes)
		{
			if (this.id_setIcon_I == IntPtr.Zero)
			{
				this.id_setIcon_I = JNIEnv.GetMethodID(this.class_ref, "setIcon", "(I)Landroid/view/MenuItem;");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(iconRes);
			return Java.Lang.Object.GetObject<IMenuItem>(JNIEnv.CallObjectMethod(base.Handle, this.id_setIcon_I, ptr), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x060008A8 RID: 2216 RVA: 0x000147D6 File Offset: 0x000129D6
		private static Delegate GetSetIntent_Landroid_content_Intent_Handler()
		{
			if (IMenuItemInvoker.cb_setIntent_Landroid_content_Intent_ == null)
			{
				IMenuItemInvoker.cb_setIntent_Landroid_content_Intent_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(IMenuItemInvoker.n_SetIntent_Landroid_content_Intent_));
			}
			return IMenuItemInvoker.cb_setIntent_Landroid_content_Intent_;
		}

		// Token: 0x060008A9 RID: 2217 RVA: 0x000147FC File Offset: 0x000129FC
		private static IntPtr n_SetIntent_Landroid_content_Intent_(IntPtr jnienv, IntPtr native__this, IntPtr native_intent)
		{
			IMenuItem @object = Java.Lang.Object.GetObject<IMenuItem>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Intent object2 = Java.Lang.Object.GetObject<Intent>(native_intent, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.SetIntent(object2));
		}

		// Token: 0x060008AA RID: 2218 RVA: 0x00014824 File Offset: 0x00012A24
		public unsafe IMenuItem SetIntent(Intent intent)
		{
			if (this.id_setIntent_Landroid_content_Intent_ == IntPtr.Zero)
			{
				this.id_setIntent_Landroid_content_Intent_ = JNIEnv.GetMethodID(this.class_ref, "setIntent", "(Landroid/content/Intent;)Landroid/view/MenuItem;");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((intent == null) ? IntPtr.Zero : intent.Handle);
			return Java.Lang.Object.GetObject<IMenuItem>(JNIEnv.CallObjectMethod(base.Handle, this.id_setIntent_Landroid_content_Intent_, ptr), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x060008AB RID: 2219 RVA: 0x0001489D File Offset: 0x00012A9D
		private static Delegate GetSetNumericShortcut_CHandler()
		{
			if (IMenuItemInvoker.cb_setNumericShortcut_C == null)
			{
				IMenuItemInvoker.cb_setNumericShortcut_C = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPC_L(IMenuItemInvoker.n_SetNumericShortcut_C));
			}
			return IMenuItemInvoker.cb_setNumericShortcut_C;
		}

		// Token: 0x060008AC RID: 2220 RVA: 0x000148C1 File Offset: 0x00012AC1
		private static IntPtr n_SetNumericShortcut_C(IntPtr jnienv, IntPtr native__this, char numericChar)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IMenuItem>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SetNumericShortcut(numericChar));
		}

		// Token: 0x060008AD RID: 2221 RVA: 0x000148D8 File Offset: 0x00012AD8
		public unsafe IMenuItem SetNumericShortcut(char numericChar)
		{
			if (this.id_setNumericShortcut_C == IntPtr.Zero)
			{
				this.id_setNumericShortcut_C = JNIEnv.GetMethodID(this.class_ref, "setNumericShortcut", "(C)Landroid/view/MenuItem;");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(numericChar);
			return Java.Lang.Object.GetObject<IMenuItem>(JNIEnv.CallObjectMethod(base.Handle, this.id_setNumericShortcut_C, ptr), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x060008AE RID: 2222 RVA: 0x00014942 File Offset: 0x00012B42
		private static Delegate GetSetOnActionExpandListener_Landroid_view_MenuItem_OnActionExpandListener_Handler()
		{
			if (IMenuItemInvoker.cb_setOnActionExpandListener_Landroid_view_MenuItem_OnActionExpandListener_ == null)
			{
				IMenuItemInvoker.cb_setOnActionExpandListener_Landroid_view_MenuItem_OnActionExpandListener_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(IMenuItemInvoker.n_SetOnActionExpandListener_Landroid_view_MenuItem_OnActionExpandListener_));
			}
			return IMenuItemInvoker.cb_setOnActionExpandListener_Landroid_view_MenuItem_OnActionExpandListener_;
		}

		// Token: 0x060008AF RID: 2223 RVA: 0x00014968 File Offset: 0x00012B68
		private static IntPtr n_SetOnActionExpandListener_Landroid_view_MenuItem_OnActionExpandListener_(IntPtr jnienv, IntPtr native__this, IntPtr native_listener)
		{
			IMenuItem @object = Java.Lang.Object.GetObject<IMenuItem>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IMenuItemOnActionExpandListener object2 = Java.Lang.Object.GetObject<IMenuItemOnActionExpandListener>(native_listener, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.SetOnActionExpandListener(object2));
		}

		// Token: 0x060008B0 RID: 2224 RVA: 0x00014990 File Offset: 0x00012B90
		public unsafe IMenuItem SetOnActionExpandListener(IMenuItemOnActionExpandListener listener)
		{
			if (this.id_setOnActionExpandListener_Landroid_view_MenuItem_OnActionExpandListener_ == IntPtr.Zero)
			{
				this.id_setOnActionExpandListener_Landroid_view_MenuItem_OnActionExpandListener_ = JNIEnv.GetMethodID(this.class_ref, "setOnActionExpandListener", "(Landroid/view/MenuItem$OnActionExpandListener;)Landroid/view/MenuItem;");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((listener == null) ? IntPtr.Zero : ((Java.Lang.Object)listener).Handle);
			return Java.Lang.Object.GetObject<IMenuItem>(JNIEnv.CallObjectMethod(base.Handle, this.id_setOnActionExpandListener_Landroid_view_MenuItem_OnActionExpandListener_, ptr), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x060008B1 RID: 2225 RVA: 0x00014A0E File Offset: 0x00012C0E
		private static Delegate GetSetOnMenuItemClickListener_Landroid_view_MenuItem_OnMenuItemClickListener_Handler()
		{
			if (IMenuItemInvoker.cb_setOnMenuItemClickListener_Landroid_view_MenuItem_OnMenuItemClickListener_ == null)
			{
				IMenuItemInvoker.cb_setOnMenuItemClickListener_Landroid_view_MenuItem_OnMenuItemClickListener_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(IMenuItemInvoker.n_SetOnMenuItemClickListener_Landroid_view_MenuItem_OnMenuItemClickListener_));
			}
			return IMenuItemInvoker.cb_setOnMenuItemClickListener_Landroid_view_MenuItem_OnMenuItemClickListener_;
		}

		// Token: 0x060008B2 RID: 2226 RVA: 0x00014A34 File Offset: 0x00012C34
		private static IntPtr n_SetOnMenuItemClickListener_Landroid_view_MenuItem_OnMenuItemClickListener_(IntPtr jnienv, IntPtr native__this, IntPtr native_menuItemClickListener)
		{
			IMenuItem @object = Java.Lang.Object.GetObject<IMenuItem>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IMenuItemOnMenuItemClickListener object2 = Java.Lang.Object.GetObject<IMenuItemOnMenuItemClickListener>(native_menuItemClickListener, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.SetOnMenuItemClickListener(object2));
		}

		// Token: 0x060008B3 RID: 2227 RVA: 0x00014A5C File Offset: 0x00012C5C
		public unsafe IMenuItem SetOnMenuItemClickListener(IMenuItemOnMenuItemClickListener menuItemClickListener)
		{
			if (this.id_setOnMenuItemClickListener_Landroid_view_MenuItem_OnMenuItemClickListener_ == IntPtr.Zero)
			{
				this.id_setOnMenuItemClickListener_Landroid_view_MenuItem_OnMenuItemClickListener_ = JNIEnv.GetMethodID(this.class_ref, "setOnMenuItemClickListener", "(Landroid/view/MenuItem$OnMenuItemClickListener;)Landroid/view/MenuItem;");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((menuItemClickListener == null) ? IntPtr.Zero : ((Java.Lang.Object)menuItemClickListener).Handle);
			return Java.Lang.Object.GetObject<IMenuItem>(JNIEnv.CallObjectMethod(base.Handle, this.id_setOnMenuItemClickListener_Landroid_view_MenuItem_OnMenuItemClickListener_, ptr), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x060008B4 RID: 2228 RVA: 0x00014ADA File Offset: 0x00012CDA
		private static Delegate GetSetShortcut_CCHandler()
		{
			if (IMenuItemInvoker.cb_setShortcut_CC == null)
			{
				IMenuItemInvoker.cb_setShortcut_CC = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPCC_L(IMenuItemInvoker.n_SetShortcut_CC));
			}
			return IMenuItemInvoker.cb_setShortcut_CC;
		}

		// Token: 0x060008B5 RID: 2229 RVA: 0x00014AFE File Offset: 0x00012CFE
		private static IntPtr n_SetShortcut_CC(IntPtr jnienv, IntPtr native__this, char numericChar, char alphaChar)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IMenuItem>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SetShortcut(numericChar, alphaChar));
		}

		// Token: 0x060008B6 RID: 2230 RVA: 0x00014B14 File Offset: 0x00012D14
		public unsafe IMenuItem SetShortcut(char numericChar, char alphaChar)
		{
			if (this.id_setShortcut_CC == IntPtr.Zero)
			{
				this.id_setShortcut_CC = JNIEnv.GetMethodID(this.class_ref, "setShortcut", "(CC)Landroid/view/MenuItem;");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(numericChar);
			ptr[1] = new JValue(alphaChar);
			return Java.Lang.Object.GetObject<IMenuItem>(JNIEnv.CallObjectMethod(base.Handle, this.id_setShortcut_CC, ptr), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x060008B7 RID: 2231 RVA: 0x00014B91 File Offset: 0x00012D91
		private static Delegate GetSetShowAsAction_IHandler()
		{
			if (IMenuItemInvoker.cb_setShowAsAction_I == null)
			{
				IMenuItemInvoker.cb_setShowAsAction_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_V(IMenuItemInvoker.n_SetShowAsAction_I));
			}
			return IMenuItemInvoker.cb_setShowAsAction_I;
		}

		// Token: 0x060008B8 RID: 2232 RVA: 0x00014BB8 File Offset: 0x00012DB8
		private static void n_SetShowAsAction_I(IntPtr jnienv, IntPtr native__this, int native_actionEnum)
		{
			Java.Lang.Object.GetObject<IMenuItem>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SetShowAsAction((ShowAsAction)native_actionEnum);
		}

		// Token: 0x060008B9 RID: 2233 RVA: 0x00014BD8 File Offset: 0x00012DD8
		public unsafe void SetShowAsAction([GeneratedEnum] ShowAsAction actionEnum)
		{
			if (this.id_setShowAsAction_I == IntPtr.Zero)
			{
				this.id_setShowAsAction_I = JNIEnv.GetMethodID(this.class_ref, "setShowAsAction", "(I)V");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((int)actionEnum);
			JNIEnv.CallVoidMethod(base.Handle, this.id_setShowAsAction_I, ptr);
		}

		// Token: 0x060008BA RID: 2234 RVA: 0x00014C3C File Offset: 0x00012E3C
		private static Delegate GetSetShowAsActionFlags_IHandler()
		{
			if (IMenuItemInvoker.cb_setShowAsActionFlags_I == null)
			{
				IMenuItemInvoker.cb_setShowAsActionFlags_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_L(IMenuItemInvoker.n_SetShowAsActionFlags_I));
			}
			return IMenuItemInvoker.cb_setShowAsActionFlags_I;
		}

		// Token: 0x060008BB RID: 2235 RVA: 0x00014C60 File Offset: 0x00012E60
		private static IntPtr n_SetShowAsActionFlags_I(IntPtr jnienv, IntPtr native__this, int native_actionEnum)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IMenuItem>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SetShowAsActionFlags((ShowAsAction)native_actionEnum));
		}

		// Token: 0x060008BC RID: 2236 RVA: 0x00014C84 File Offset: 0x00012E84
		public unsafe IMenuItem SetShowAsActionFlags([GeneratedEnum] ShowAsAction actionEnum)
		{
			if (this.id_setShowAsActionFlags_I == IntPtr.Zero)
			{
				this.id_setShowAsActionFlags_I = JNIEnv.GetMethodID(this.class_ref, "setShowAsActionFlags", "(I)Landroid/view/MenuItem;");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((int)actionEnum);
			return Java.Lang.Object.GetObject<IMenuItem>(JNIEnv.CallObjectMethod(base.Handle, this.id_setShowAsActionFlags_I, ptr), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x060008BD RID: 2237 RVA: 0x00014CEE File Offset: 0x00012EEE
		private static Delegate GetSetTitle_IHandler()
		{
			if (IMenuItemInvoker.cb_setTitle_I == null)
			{
				IMenuItemInvoker.cb_setTitle_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_L(IMenuItemInvoker.n_SetTitle_I));
			}
			return IMenuItemInvoker.cb_setTitle_I;
		}

		// Token: 0x060008BE RID: 2238 RVA: 0x00014D12 File Offset: 0x00012F12
		private static IntPtr n_SetTitle_I(IntPtr jnienv, IntPtr native__this, int title)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IMenuItem>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SetTitle(title));
		}

		// Token: 0x060008BF RID: 2239 RVA: 0x00014D28 File Offset: 0x00012F28
		public unsafe IMenuItem SetTitle(int title)
		{
			if (this.id_setTitle_I == IntPtr.Zero)
			{
				this.id_setTitle_I = JNIEnv.GetMethodID(this.class_ref, "setTitle", "(I)Landroid/view/MenuItem;");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(title);
			return Java.Lang.Object.GetObject<IMenuItem>(JNIEnv.CallObjectMethod(base.Handle, this.id_setTitle_I, ptr), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x060008C0 RID: 2240 RVA: 0x00014D92 File Offset: 0x00012F92
		private static Delegate GetSetTitle_Ljava_lang_CharSequence_Handler()
		{
			if (IMenuItemInvoker.cb_setTitle_Ljava_lang_CharSequence_ == null)
			{
				IMenuItemInvoker.cb_setTitle_Ljava_lang_CharSequence_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(IMenuItemInvoker.n_SetTitle_Ljava_lang_CharSequence_));
			}
			return IMenuItemInvoker.cb_setTitle_Ljava_lang_CharSequence_;
		}

		// Token: 0x060008C1 RID: 2241 RVA: 0x00014DB8 File Offset: 0x00012FB8
		private static IntPtr n_SetTitle_Ljava_lang_CharSequence_(IntPtr jnienv, IntPtr native__this, IntPtr native_title)
		{
			IMenuItem @object = Java.Lang.Object.GetObject<IMenuItem>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ICharSequence object2 = Java.Lang.Object.GetObject<ICharSequence>(native_title, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.SetTitle(object2));
		}

		// Token: 0x060008C2 RID: 2242 RVA: 0x00014DE0 File Offset: 0x00012FE0
		public unsafe IMenuItem SetTitle(ICharSequence title)
		{
			if (this.id_setTitle_Ljava_lang_CharSequence_ == IntPtr.Zero)
			{
				this.id_setTitle_Ljava_lang_CharSequence_ = JNIEnv.GetMethodID(this.class_ref, "setTitle", "(Ljava/lang/CharSequence;)Landroid/view/MenuItem;");
			}
			IntPtr intPtr = CharSequence.ToLocalJniHandle(title);
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(intPtr);
			IMenuItem @object = Java.Lang.Object.GetObject<IMenuItem>(JNIEnv.CallObjectMethod(base.Handle, this.id_setTitle_Ljava_lang_CharSequence_, ptr), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef(intPtr);
			return @object;
		}

		// Token: 0x060008C3 RID: 2243 RVA: 0x00014E57 File Offset: 0x00013057
		private static Delegate GetSetTitleCondensed_Ljava_lang_CharSequence_Handler()
		{
			if (IMenuItemInvoker.cb_setTitleCondensed_Ljava_lang_CharSequence_ == null)
			{
				IMenuItemInvoker.cb_setTitleCondensed_Ljava_lang_CharSequence_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(IMenuItemInvoker.n_SetTitleCondensed_Ljava_lang_CharSequence_));
			}
			return IMenuItemInvoker.cb_setTitleCondensed_Ljava_lang_CharSequence_;
		}

		// Token: 0x060008C4 RID: 2244 RVA: 0x00014E7C File Offset: 0x0001307C
		private static IntPtr n_SetTitleCondensed_Ljava_lang_CharSequence_(IntPtr jnienv, IntPtr native__this, IntPtr native_title)
		{
			IMenuItem @object = Java.Lang.Object.GetObject<IMenuItem>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ICharSequence object2 = Java.Lang.Object.GetObject<ICharSequence>(native_title, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.SetTitleCondensed(object2));
		}

		// Token: 0x060008C5 RID: 2245 RVA: 0x00014EA4 File Offset: 0x000130A4
		public unsafe IMenuItem SetTitleCondensed(ICharSequence title)
		{
			if (this.id_setTitleCondensed_Ljava_lang_CharSequence_ == IntPtr.Zero)
			{
				this.id_setTitleCondensed_Ljava_lang_CharSequence_ = JNIEnv.GetMethodID(this.class_ref, "setTitleCondensed", "(Ljava/lang/CharSequence;)Landroid/view/MenuItem;");
			}
			IntPtr intPtr = CharSequence.ToLocalJniHandle(title);
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(intPtr);
			IMenuItem @object = Java.Lang.Object.GetObject<IMenuItem>(JNIEnv.CallObjectMethod(base.Handle, this.id_setTitleCondensed_Ljava_lang_CharSequence_, ptr), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef(intPtr);
			return @object;
		}

		// Token: 0x060008C6 RID: 2246 RVA: 0x00014F1B File Offset: 0x0001311B
		private static Delegate GetSetVisible_ZHandler()
		{
			if (IMenuItemInvoker.cb_setVisible_Z == null)
			{
				IMenuItemInvoker.cb_setVisible_Z = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPZ_L(IMenuItemInvoker.n_SetVisible_Z));
			}
			return IMenuItemInvoker.cb_setVisible_Z;
		}

		// Token: 0x060008C7 RID: 2247 RVA: 0x00014F3F File Offset: 0x0001313F
		private static IntPtr n_SetVisible_Z(IntPtr jnienv, IntPtr native__this, bool visible)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IMenuItem>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SetVisible(visible));
		}

		// Token: 0x060008C8 RID: 2248 RVA: 0x00014F54 File Offset: 0x00013154
		public unsafe IMenuItem SetVisible(bool visible)
		{
			if (this.id_setVisible_Z == IntPtr.Zero)
			{
				this.id_setVisible_Z = JNIEnv.GetMethodID(this.class_ref, "setVisible", "(Z)Landroid/view/MenuItem;");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(visible);
			return Java.Lang.Object.GetObject<IMenuItem>(JNIEnv.CallObjectMethod(base.Handle, this.id_setVisible_Z, ptr), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x04000250 RID: 592
		private static readonly JniPeerMembers _members = new XAPeerMembers("android/view/MenuItem", typeof(IMenuItemInvoker));

		// Token: 0x04000251 RID: 593
		private IntPtr class_ref;

		// Token: 0x04000252 RID: 594
		private static Delegate cb_getActionProvider;

		// Token: 0x04000253 RID: 595
		private IntPtr id_getActionProvider;

		// Token: 0x04000254 RID: 596
		private static Delegate cb_getActionView;

		// Token: 0x04000255 RID: 597
		private IntPtr id_getActionView;

		// Token: 0x04000256 RID: 598
		private static Delegate cb_getAlphabeticShortcut;

		// Token: 0x04000257 RID: 599
		private IntPtr id_getAlphabeticShortcut;

		// Token: 0x04000258 RID: 600
		private static Delegate cb_getGroupId;

		// Token: 0x04000259 RID: 601
		private IntPtr id_getGroupId;

		// Token: 0x0400025A RID: 602
		private static Delegate cb_hasSubMenu;

		// Token: 0x0400025B RID: 603
		private IntPtr id_hasSubMenu;

		// Token: 0x0400025C RID: 604
		private static Delegate cb_getIcon;

		// Token: 0x0400025D RID: 605
		private IntPtr id_getIcon;

		// Token: 0x0400025E RID: 606
		private static Delegate cb_getIntent;

		// Token: 0x0400025F RID: 607
		private IntPtr id_getIntent;

		// Token: 0x04000260 RID: 608
		private static Delegate cb_isActionViewExpanded;

		// Token: 0x04000261 RID: 609
		private IntPtr id_isActionViewExpanded;

		// Token: 0x04000262 RID: 610
		private static Delegate cb_isCheckable;

		// Token: 0x04000263 RID: 611
		private IntPtr id_isCheckable;

		// Token: 0x04000264 RID: 612
		private static Delegate cb_isChecked;

		// Token: 0x04000265 RID: 613
		private IntPtr id_isChecked;

		// Token: 0x04000266 RID: 614
		private static Delegate cb_isEnabled;

		// Token: 0x04000267 RID: 615
		private IntPtr id_isEnabled;

		// Token: 0x04000268 RID: 616
		private static Delegate cb_isVisible;

		// Token: 0x04000269 RID: 617
		private IntPtr id_isVisible;

		// Token: 0x0400026A RID: 618
		private static Delegate cb_getItemId;

		// Token: 0x0400026B RID: 619
		private IntPtr id_getItemId;

		// Token: 0x0400026C RID: 620
		private static Delegate cb_getMenuInfo;

		// Token: 0x0400026D RID: 621
		private IntPtr id_getMenuInfo;

		// Token: 0x0400026E RID: 622
		private static Delegate cb_getNumericShortcut;

		// Token: 0x0400026F RID: 623
		private IntPtr id_getNumericShortcut;

		// Token: 0x04000270 RID: 624
		private static Delegate cb_getOrder;

		// Token: 0x04000271 RID: 625
		private IntPtr id_getOrder;

		// Token: 0x04000272 RID: 626
		private static Delegate cb_getSubMenu;

		// Token: 0x04000273 RID: 627
		private IntPtr id_getSubMenu;

		// Token: 0x04000274 RID: 628
		private static Delegate cb_getTitle;

		// Token: 0x04000275 RID: 629
		private IntPtr id_getTitle;

		// Token: 0x04000276 RID: 630
		private static Delegate cb_getTitleCondensed;

		// Token: 0x04000277 RID: 631
		private IntPtr id_getTitleCondensed;

		// Token: 0x04000278 RID: 632
		private static Delegate cb_collapseActionView;

		// Token: 0x04000279 RID: 633
		private IntPtr id_collapseActionView;

		// Token: 0x0400027A RID: 634
		private static Delegate cb_expandActionView;

		// Token: 0x0400027B RID: 635
		private IntPtr id_expandActionView;

		// Token: 0x0400027C RID: 636
		private static Delegate cb_setActionProvider_Landroid_view_ActionProvider_;

		// Token: 0x0400027D RID: 637
		private IntPtr id_setActionProvider_Landroid_view_ActionProvider_;

		// Token: 0x0400027E RID: 638
		private static Delegate cb_setActionView_Landroid_view_View_;

		// Token: 0x0400027F RID: 639
		private IntPtr id_setActionView_Landroid_view_View_;

		// Token: 0x04000280 RID: 640
		private static Delegate cb_setActionView_I;

		// Token: 0x04000281 RID: 641
		private IntPtr id_setActionView_I;

		// Token: 0x04000282 RID: 642
		private static Delegate cb_setAlphabeticShortcut_C;

		// Token: 0x04000283 RID: 643
		private IntPtr id_setAlphabeticShortcut_C;

		// Token: 0x04000284 RID: 644
		private static Delegate cb_setCheckable_Z;

		// Token: 0x04000285 RID: 645
		private IntPtr id_setCheckable_Z;

		// Token: 0x04000286 RID: 646
		private static Delegate cb_setChecked_Z;

		// Token: 0x04000287 RID: 647
		private IntPtr id_setChecked_Z;

		// Token: 0x04000288 RID: 648
		private static Delegate cb_setEnabled_Z;

		// Token: 0x04000289 RID: 649
		private IntPtr id_setEnabled_Z;

		// Token: 0x0400028A RID: 650
		private static Delegate cb_setIcon_Landroid_graphics_drawable_Drawable_;

		// Token: 0x0400028B RID: 651
		private IntPtr id_setIcon_Landroid_graphics_drawable_Drawable_;

		// Token: 0x0400028C RID: 652
		private static Delegate cb_setIcon_I;

		// Token: 0x0400028D RID: 653
		private IntPtr id_setIcon_I;

		// Token: 0x0400028E RID: 654
		private static Delegate cb_setIntent_Landroid_content_Intent_;

		// Token: 0x0400028F RID: 655
		private IntPtr id_setIntent_Landroid_content_Intent_;

		// Token: 0x04000290 RID: 656
		private static Delegate cb_setNumericShortcut_C;

		// Token: 0x04000291 RID: 657
		private IntPtr id_setNumericShortcut_C;

		// Token: 0x04000292 RID: 658
		private static Delegate cb_setOnActionExpandListener_Landroid_view_MenuItem_OnActionExpandListener_;

		// Token: 0x04000293 RID: 659
		private IntPtr id_setOnActionExpandListener_Landroid_view_MenuItem_OnActionExpandListener_;

		// Token: 0x04000294 RID: 660
		private static Delegate cb_setOnMenuItemClickListener_Landroid_view_MenuItem_OnMenuItemClickListener_;

		// Token: 0x04000295 RID: 661
		private IntPtr id_setOnMenuItemClickListener_Landroid_view_MenuItem_OnMenuItemClickListener_;

		// Token: 0x04000296 RID: 662
		private static Delegate cb_setShortcut_CC;

		// Token: 0x04000297 RID: 663
		private IntPtr id_setShortcut_CC;

		// Token: 0x04000298 RID: 664
		private static Delegate cb_setShowAsAction_I;

		// Token: 0x04000299 RID: 665
		private IntPtr id_setShowAsAction_I;

		// Token: 0x0400029A RID: 666
		private static Delegate cb_setShowAsActionFlags_I;

		// Token: 0x0400029B RID: 667
		private IntPtr id_setShowAsActionFlags_I;

		// Token: 0x0400029C RID: 668
		private static Delegate cb_setTitle_I;

		// Token: 0x0400029D RID: 669
		private IntPtr id_setTitle_I;

		// Token: 0x0400029E RID: 670
		private static Delegate cb_setTitle_Ljava_lang_CharSequence_;

		// Token: 0x0400029F RID: 671
		private IntPtr id_setTitle_Ljava_lang_CharSequence_;

		// Token: 0x040002A0 RID: 672
		private static Delegate cb_setTitleCondensed_Ljava_lang_CharSequence_;

		// Token: 0x040002A1 RID: 673
		private IntPtr id_setTitleCondensed_Ljava_lang_CharSequence_;

		// Token: 0x040002A2 RID: 674
		private static Delegate cb_setVisible_Z;

		// Token: 0x040002A3 RID: 675
		private IntPtr id_setVisible_Z;
	}
}
