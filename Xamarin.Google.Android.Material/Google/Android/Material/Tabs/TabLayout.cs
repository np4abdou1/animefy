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
using AndroidX.ViewPager.Widget;
using Google.Android.Material.Badge;
using Java.Interop;
using Java.Lang;

namespace Google.Android.Material.Tabs
{
	// Token: 0x02000077 RID: 119
	[Register("com/google/android/material/tabs/TabLayout", DoNotGenerateAcw = true)]
	public class TabLayout : HorizontalScrollView
	{
		// Token: 0x1700013E RID: 318
		// (get) Token: 0x060007DF RID: 2015 RVA: 0x00015310 File Offset: 0x00013510
		internal static IntPtr class_ref
		{
			get
			{
				return TabLayout._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700013F RID: 319
		// (get) Token: 0x060007E0 RID: 2016 RVA: 0x00015334 File Offset: 0x00013534
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return TabLayout._members;
			}
		}

		// Token: 0x17000140 RID: 320
		// (get) Token: 0x060007E1 RID: 2017 RVA: 0x0001533C File Offset: 0x0001353C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return TabLayout._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000141 RID: 321
		// (get) Token: 0x060007E2 RID: 2018 RVA: 0x00015360 File Offset: 0x00013560
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return TabLayout._members.ManagedPeerType;
			}
		}

		// Token: 0x060007E3 RID: 2019 RVA: 0x0001536C File Offset: 0x0001356C
		protected TabLayout(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x060007E4 RID: 2020 RVA: 0x00015378 File Offset: 0x00013578
		[Register(".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe TabLayout(Context context) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((context == null) ? IntPtr.Zero : context.Handle);
				base.SetHandle(TabLayout._members.InstanceMethods.StartCreateInstance("(Landroid/content/Context;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				TabLayout._members.InstanceMethods.FinishCreateInstance("(Landroid/content/Context;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(context);
			}
		}

		// Token: 0x060007E5 RID: 2021 RVA: 0x00015428 File Offset: 0x00013628
		[Register(".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", "")]
		public unsafe TabLayout(Context context, IAttributeSet attrs) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((context == null) ? IntPtr.Zero : context.Handle);
				ptr[1] = new JniArgumentValue((attrs == null) ? IntPtr.Zero : ((Java.Lang.Object)attrs).Handle);
				base.SetHandle(TabLayout._members.InstanceMethods.StartCreateInstance("(Landroid/content/Context;Landroid/util/AttributeSet;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				TabLayout._members.InstanceMethods.FinishCreateInstance("(Landroid/content/Context;Landroid/util/AttributeSet;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(context);
				GC.KeepAlive(attrs);
			}
		}

		// Token: 0x060007E6 RID: 2022 RVA: 0x00015504 File Offset: 0x00013704
		[Register(".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", "")]
		public unsafe TabLayout(Context context, IAttributeSet attrs, int defStyleAttr) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((context == null) ? IntPtr.Zero : context.Handle);
				ptr[1] = new JniArgumentValue((attrs == null) ? IntPtr.Zero : ((Java.Lang.Object)attrs).Handle);
				ptr[2] = new JniArgumentValue(defStyleAttr);
				base.SetHandle(TabLayout._members.InstanceMethods.StartCreateInstance("(Landroid/content/Context;Landroid/util/AttributeSet;I)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				TabLayout._members.InstanceMethods.FinishCreateInstance("(Landroid/content/Context;Landroid/util/AttributeSet;I)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(context);
				GC.KeepAlive(attrs);
			}
		}

		// Token: 0x060007E7 RID: 2023 RVA: 0x000155F4 File Offset: 0x000137F4
		private static Delegate GetHasUnboundedRippleHandler()
		{
			if (TabLayout.cb_hasUnboundedRipple == null)
			{
				TabLayout.cb_hasUnboundedRipple = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(TabLayout.n_HasUnboundedRipple));
			}
			return TabLayout.cb_hasUnboundedRipple;
		}

		// Token: 0x060007E8 RID: 2024 RVA: 0x00015618 File Offset: 0x00013818
		private static bool n_HasUnboundedRipple(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<TabLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).HasUnboundedRipple;
		}

		// Token: 0x17000142 RID: 322
		// (get) Token: 0x060007E9 RID: 2025 RVA: 0x00015627 File Offset: 0x00013827
		public virtual bool HasUnboundedRipple
		{
			[Register("hasUnboundedRipple", "()Z", "GetHasUnboundedRippleHandler")]
			get
			{
				return TabLayout._members.InstanceMethods.InvokeVirtualBooleanMethod("hasUnboundedRipple.()Z", this, null);
			}
		}

		// Token: 0x060007EA RID: 2026 RVA: 0x00015640 File Offset: 0x00013840
		private static Delegate GetIsInlineLabelHandler()
		{
			if (TabLayout.cb_isInlineLabel == null)
			{
				TabLayout.cb_isInlineLabel = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(TabLayout.n_IsInlineLabel));
			}
			return TabLayout.cb_isInlineLabel;
		}

		// Token: 0x060007EB RID: 2027 RVA: 0x00015664 File Offset: 0x00013864
		private static bool n_IsInlineLabel(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<TabLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).InlineLabel;
		}

		// Token: 0x060007EC RID: 2028 RVA: 0x00015673 File Offset: 0x00013873
		private static Delegate GetSetInlineLabel_ZHandler()
		{
			if (TabLayout.cb_setInlineLabel_Z == null)
			{
				TabLayout.cb_setInlineLabel_Z = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPZ_V(TabLayout.n_SetInlineLabel_Z));
			}
			return TabLayout.cb_setInlineLabel_Z;
		}

		// Token: 0x060007ED RID: 2029 RVA: 0x00015697 File Offset: 0x00013897
		private static void n_SetInlineLabel_Z(IntPtr jnienv, IntPtr native__this, bool inline)
		{
			Java.Lang.Object.GetObject<TabLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).InlineLabel = inline;
		}

		// Token: 0x17000143 RID: 323
		// (get) Token: 0x060007EE RID: 2030 RVA: 0x000156A7 File Offset: 0x000138A7
		// (set) Token: 0x060007EF RID: 2031 RVA: 0x000156C0 File Offset: 0x000138C0
		public unsafe virtual bool InlineLabel
		{
			[Register("isInlineLabel", "()Z", "GetIsInlineLabelHandler")]
			get
			{
				return TabLayout._members.InstanceMethods.InvokeVirtualBooleanMethod("isInlineLabel.()Z", this, null);
			}
			[Register("setInlineLabel", "(Z)V", "GetSetInlineLabel_ZHandler")]
			set
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(value);
				TabLayout._members.InstanceMethods.InvokeVirtualVoidMethod("setInlineLabel.(Z)V", this, ptr);
			}
		}

		// Token: 0x060007F0 RID: 2032 RVA: 0x000156FB File Offset: 0x000138FB
		private static Delegate GetGetSelectedTabPositionHandler()
		{
			if (TabLayout.cb_getSelectedTabPosition == null)
			{
				TabLayout.cb_getSelectedTabPosition = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(TabLayout.n_GetSelectedTabPosition));
			}
			return TabLayout.cb_getSelectedTabPosition;
		}

		// Token: 0x060007F1 RID: 2033 RVA: 0x0001571F File Offset: 0x0001391F
		private static int n_GetSelectedTabPosition(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<TabLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SelectedTabPosition;
		}

		// Token: 0x17000144 RID: 324
		// (get) Token: 0x060007F2 RID: 2034 RVA: 0x0001572E File Offset: 0x0001392E
		public virtual int SelectedTabPosition
		{
			[Register("getSelectedTabPosition", "()I", "GetGetSelectedTabPositionHandler")]
			get
			{
				return TabLayout._members.InstanceMethods.InvokeVirtualInt32Method("getSelectedTabPosition.()I", this, null);
			}
		}

		// Token: 0x060007F3 RID: 2035 RVA: 0x00015747 File Offset: 0x00013947
		private static Delegate GetGetTabCountHandler()
		{
			if (TabLayout.cb_getTabCount == null)
			{
				TabLayout.cb_getTabCount = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(TabLayout.n_GetTabCount));
			}
			return TabLayout.cb_getTabCount;
		}

		// Token: 0x060007F4 RID: 2036 RVA: 0x0001576B File Offset: 0x0001396B
		private static int n_GetTabCount(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<TabLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).TabCount;
		}

		// Token: 0x17000145 RID: 325
		// (get) Token: 0x060007F5 RID: 2037 RVA: 0x0001577A File Offset: 0x0001397A
		public virtual int TabCount
		{
			[Register("getTabCount", "()I", "GetGetTabCountHandler")]
			get
			{
				return TabLayout._members.InstanceMethods.InvokeVirtualInt32Method("getTabCount.()I", this, null);
			}
		}

		// Token: 0x060007F6 RID: 2038 RVA: 0x00015793 File Offset: 0x00013993
		private static Delegate GetGetTabGravityHandler()
		{
			if (TabLayout.cb_getTabGravity == null)
			{
				TabLayout.cb_getTabGravity = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(TabLayout.n_GetTabGravity));
			}
			return TabLayout.cb_getTabGravity;
		}

		// Token: 0x060007F7 RID: 2039 RVA: 0x000157B7 File Offset: 0x000139B7
		private static int n_GetTabGravity(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<TabLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).TabGravity;
		}

		// Token: 0x060007F8 RID: 2040 RVA: 0x000157C6 File Offset: 0x000139C6
		private static Delegate GetSetTabGravity_IHandler()
		{
			if (TabLayout.cb_setTabGravity_I == null)
			{
				TabLayout.cb_setTabGravity_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_V(TabLayout.n_SetTabGravity_I));
			}
			return TabLayout.cb_setTabGravity_I;
		}

		// Token: 0x060007F9 RID: 2041 RVA: 0x000157EA File Offset: 0x000139EA
		private static void n_SetTabGravity_I(IntPtr jnienv, IntPtr native__this, int gravity)
		{
			Java.Lang.Object.GetObject<TabLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).TabGravity = gravity;
		}

		// Token: 0x17000146 RID: 326
		// (get) Token: 0x060007FA RID: 2042 RVA: 0x000157FA File Offset: 0x000139FA
		// (set) Token: 0x060007FB RID: 2043 RVA: 0x00015814 File Offset: 0x00013A14
		public unsafe virtual int TabGravity
		{
			[Register("getTabGravity", "()I", "GetGetTabGravityHandler")]
			get
			{
				return TabLayout._members.InstanceMethods.InvokeVirtualInt32Method("getTabGravity.()I", this, null);
			}
			[Register("setTabGravity", "(I)V", "GetSetTabGravity_IHandler")]
			set
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(value);
				TabLayout._members.InstanceMethods.InvokeVirtualVoidMethod("setTabGravity.(I)V", this, ptr);
			}
		}

		// Token: 0x060007FC RID: 2044 RVA: 0x0001584F File Offset: 0x00013A4F
		private static Delegate GetGetTabIconTintHandler()
		{
			if (TabLayout.cb_getTabIconTint == null)
			{
				TabLayout.cb_getTabIconTint = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(TabLayout.n_GetTabIconTint));
			}
			return TabLayout.cb_getTabIconTint;
		}

		// Token: 0x060007FD RID: 2045 RVA: 0x00015873 File Offset: 0x00013A73
		private static IntPtr n_GetTabIconTint(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<TabLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).TabIconTint);
		}

		// Token: 0x060007FE RID: 2046 RVA: 0x00015887 File Offset: 0x00013A87
		private static Delegate GetSetTabIconTint_Landroid_content_res_ColorStateList_Handler()
		{
			if (TabLayout.cb_setTabIconTint_Landroid_content_res_ColorStateList_ == null)
			{
				TabLayout.cb_setTabIconTint_Landroid_content_res_ColorStateList_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(TabLayout.n_SetTabIconTint_Landroid_content_res_ColorStateList_));
			}
			return TabLayout.cb_setTabIconTint_Landroid_content_res_ColorStateList_;
		}

		// Token: 0x060007FF RID: 2047 RVA: 0x000158AC File Offset: 0x00013AAC
		private static void n_SetTabIconTint_Landroid_content_res_ColorStateList_(IntPtr jnienv, IntPtr native__this, IntPtr native_iconTint)
		{
			TabLayout @object = Java.Lang.Object.GetObject<TabLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ColorStateList object2 = Java.Lang.Object.GetObject<ColorStateList>(native_iconTint, JniHandleOwnership.DoNotTransfer);
			@object.TabIconTint = object2;
		}

		// Token: 0x17000147 RID: 327
		// (get) Token: 0x06000800 RID: 2048 RVA: 0x000158D0 File Offset: 0x00013AD0
		// (set) Token: 0x06000801 RID: 2049 RVA: 0x00015904 File Offset: 0x00013B04
		public unsafe virtual ColorStateList TabIconTint
		{
			[Register("getTabIconTint", "()Landroid/content/res/ColorStateList;", "GetGetTabIconTintHandler")]
			get
			{
				return Java.Lang.Object.GetObject<ColorStateList>(TabLayout._members.InstanceMethods.InvokeVirtualObjectMethod("getTabIconTint.()Landroid/content/res/ColorStateList;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
			[Register("setTabIconTint", "(Landroid/content/res/ColorStateList;)V", "GetSetTabIconTint_Landroid_content_res_ColorStateList_Handler")]
			set
			{
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((value == null) ? IntPtr.Zero : value.Handle);
					TabLayout._members.InstanceMethods.InvokeVirtualVoidMethod("setTabIconTint.(Landroid/content/res/ColorStateList;)V", this, ptr);
				}
				finally
				{
					GC.KeepAlive(value);
				}
			}
		}

		// Token: 0x06000802 RID: 2050 RVA: 0x00015968 File Offset: 0x00013B68
		private static Delegate GetGetTabIndicatorAnimationModeHandler()
		{
			if (TabLayout.cb_getTabIndicatorAnimationMode == null)
			{
				TabLayout.cb_getTabIndicatorAnimationMode = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(TabLayout.n_GetTabIndicatorAnimationMode));
			}
			return TabLayout.cb_getTabIndicatorAnimationMode;
		}

		// Token: 0x06000803 RID: 2051 RVA: 0x0001598C File Offset: 0x00013B8C
		private static int n_GetTabIndicatorAnimationMode(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<TabLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).TabIndicatorAnimationMode;
		}

		// Token: 0x06000804 RID: 2052 RVA: 0x0001599B File Offset: 0x00013B9B
		private static Delegate GetSetTabIndicatorAnimationMode_IHandler()
		{
			if (TabLayout.cb_setTabIndicatorAnimationMode_I == null)
			{
				TabLayout.cb_setTabIndicatorAnimationMode_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_V(TabLayout.n_SetTabIndicatorAnimationMode_I));
			}
			return TabLayout.cb_setTabIndicatorAnimationMode_I;
		}

		// Token: 0x06000805 RID: 2053 RVA: 0x000159BF File Offset: 0x00013BBF
		private static void n_SetTabIndicatorAnimationMode_I(IntPtr jnienv, IntPtr native__this, int tabIndicatorAnimationMode)
		{
			Java.Lang.Object.GetObject<TabLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).TabIndicatorAnimationMode = tabIndicatorAnimationMode;
		}

		// Token: 0x17000148 RID: 328
		// (get) Token: 0x06000806 RID: 2054 RVA: 0x000159CF File Offset: 0x00013BCF
		// (set) Token: 0x06000807 RID: 2055 RVA: 0x000159E8 File Offset: 0x00013BE8
		public unsafe virtual int TabIndicatorAnimationMode
		{
			[Register("getTabIndicatorAnimationMode", "()I", "GetGetTabIndicatorAnimationModeHandler")]
			get
			{
				return TabLayout._members.InstanceMethods.InvokeVirtualInt32Method("getTabIndicatorAnimationMode.()I", this, null);
			}
			[Register("setTabIndicatorAnimationMode", "(I)V", "GetSetTabIndicatorAnimationMode_IHandler")]
			set
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(value);
				TabLayout._members.InstanceMethods.InvokeVirtualVoidMethod("setTabIndicatorAnimationMode.(I)V", this, ptr);
			}
		}

		// Token: 0x06000808 RID: 2056 RVA: 0x00015A23 File Offset: 0x00013C23
		private static Delegate GetIsTabIndicatorFullWidthHandler()
		{
			if (TabLayout.cb_isTabIndicatorFullWidth == null)
			{
				TabLayout.cb_isTabIndicatorFullWidth = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(TabLayout.n_IsTabIndicatorFullWidth));
			}
			return TabLayout.cb_isTabIndicatorFullWidth;
		}

		// Token: 0x06000809 RID: 2057 RVA: 0x00015A47 File Offset: 0x00013C47
		private static bool n_IsTabIndicatorFullWidth(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<TabLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).TabIndicatorFullWidth;
		}

		// Token: 0x0600080A RID: 2058 RVA: 0x00015A56 File Offset: 0x00013C56
		private static Delegate GetSetTabIndicatorFullWidth_ZHandler()
		{
			if (TabLayout.cb_setTabIndicatorFullWidth_Z == null)
			{
				TabLayout.cb_setTabIndicatorFullWidth_Z = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPZ_V(TabLayout.n_SetTabIndicatorFullWidth_Z));
			}
			return TabLayout.cb_setTabIndicatorFullWidth_Z;
		}

		// Token: 0x0600080B RID: 2059 RVA: 0x00015A7A File Offset: 0x00013C7A
		private static void n_SetTabIndicatorFullWidth_Z(IntPtr jnienv, IntPtr native__this, bool tabIndicatorFullWidth)
		{
			Java.Lang.Object.GetObject<TabLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).TabIndicatorFullWidth = tabIndicatorFullWidth;
		}

		// Token: 0x17000149 RID: 329
		// (get) Token: 0x0600080C RID: 2060 RVA: 0x00015A8A File Offset: 0x00013C8A
		// (set) Token: 0x0600080D RID: 2061 RVA: 0x00015AA4 File Offset: 0x00013CA4
		public unsafe virtual bool TabIndicatorFullWidth
		{
			[Register("isTabIndicatorFullWidth", "()Z", "GetIsTabIndicatorFullWidthHandler")]
			get
			{
				return TabLayout._members.InstanceMethods.InvokeVirtualBooleanMethod("isTabIndicatorFullWidth.()Z", this, null);
			}
			[Register("setTabIndicatorFullWidth", "(Z)V", "GetSetTabIndicatorFullWidth_ZHandler")]
			set
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(value);
				TabLayout._members.InstanceMethods.InvokeVirtualVoidMethod("setTabIndicatorFullWidth.(Z)V", this, ptr);
			}
		}

		// Token: 0x0600080E RID: 2062 RVA: 0x00015ADF File Offset: 0x00013CDF
		private static Delegate GetGetTabIndicatorGravityHandler()
		{
			if (TabLayout.cb_getTabIndicatorGravity == null)
			{
				TabLayout.cb_getTabIndicatorGravity = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(TabLayout.n_GetTabIndicatorGravity));
			}
			return TabLayout.cb_getTabIndicatorGravity;
		}

		// Token: 0x0600080F RID: 2063 RVA: 0x00015B03 File Offset: 0x00013D03
		private static int n_GetTabIndicatorGravity(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<TabLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).TabIndicatorGravity;
		}

		// Token: 0x1700014A RID: 330
		// (get) Token: 0x06000810 RID: 2064 RVA: 0x00015B12 File Offset: 0x00013D12
		public virtual int TabIndicatorGravity
		{
			[Register("getTabIndicatorGravity", "()I", "GetGetTabIndicatorGravityHandler")]
			get
			{
				return TabLayout._members.InstanceMethods.InvokeVirtualInt32Method("getTabIndicatorGravity.()I", this, null);
			}
		}

		// Token: 0x06000811 RID: 2065 RVA: 0x00015B2B File Offset: 0x00013D2B
		private static Delegate GetGetTabModeHandler()
		{
			if (TabLayout.cb_getTabMode == null)
			{
				TabLayout.cb_getTabMode = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(TabLayout.n_GetTabMode));
			}
			return TabLayout.cb_getTabMode;
		}

		// Token: 0x06000812 RID: 2066 RVA: 0x00015B4F File Offset: 0x00013D4F
		private static int n_GetTabMode(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<TabLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).TabMode;
		}

		// Token: 0x06000813 RID: 2067 RVA: 0x00015B5E File Offset: 0x00013D5E
		private static Delegate GetSetTabMode_IHandler()
		{
			if (TabLayout.cb_setTabMode_I == null)
			{
				TabLayout.cb_setTabMode_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_V(TabLayout.n_SetTabMode_I));
			}
			return TabLayout.cb_setTabMode_I;
		}

		// Token: 0x06000814 RID: 2068 RVA: 0x00015B82 File Offset: 0x00013D82
		private static void n_SetTabMode_I(IntPtr jnienv, IntPtr native__this, int mode)
		{
			Java.Lang.Object.GetObject<TabLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).TabMode = mode;
		}

		// Token: 0x1700014B RID: 331
		// (get) Token: 0x06000815 RID: 2069 RVA: 0x00015B92 File Offset: 0x00013D92
		// (set) Token: 0x06000816 RID: 2070 RVA: 0x00015BAC File Offset: 0x00013DAC
		public unsafe virtual int TabMode
		{
			[Register("getTabMode", "()I", "GetGetTabModeHandler")]
			get
			{
				return TabLayout._members.InstanceMethods.InvokeVirtualInt32Method("getTabMode.()I", this, null);
			}
			[Register("setTabMode", "(I)V", "GetSetTabMode_IHandler")]
			set
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(value);
				TabLayout._members.InstanceMethods.InvokeVirtualVoidMethod("setTabMode.(I)V", this, ptr);
			}
		}

		// Token: 0x06000817 RID: 2071 RVA: 0x00015BE7 File Offset: 0x00013DE7
		private static Delegate GetGetTabRippleColorHandler()
		{
			if (TabLayout.cb_getTabRippleColor == null)
			{
				TabLayout.cb_getTabRippleColor = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(TabLayout.n_GetTabRippleColor));
			}
			return TabLayout.cb_getTabRippleColor;
		}

		// Token: 0x06000818 RID: 2072 RVA: 0x00015C0B File Offset: 0x00013E0B
		private static IntPtr n_GetTabRippleColor(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<TabLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).TabRippleColor);
		}

		// Token: 0x06000819 RID: 2073 RVA: 0x00015C1F File Offset: 0x00013E1F
		private static Delegate GetSetTabRippleColor_Landroid_content_res_ColorStateList_Handler()
		{
			if (TabLayout.cb_setTabRippleColor_Landroid_content_res_ColorStateList_ == null)
			{
				TabLayout.cb_setTabRippleColor_Landroid_content_res_ColorStateList_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(TabLayout.n_SetTabRippleColor_Landroid_content_res_ColorStateList_));
			}
			return TabLayout.cb_setTabRippleColor_Landroid_content_res_ColorStateList_;
		}

		// Token: 0x0600081A RID: 2074 RVA: 0x00015C44 File Offset: 0x00013E44
		private static void n_SetTabRippleColor_Landroid_content_res_ColorStateList_(IntPtr jnienv, IntPtr native__this, IntPtr native_color)
		{
			TabLayout @object = Java.Lang.Object.GetObject<TabLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ColorStateList object2 = Java.Lang.Object.GetObject<ColorStateList>(native_color, JniHandleOwnership.DoNotTransfer);
			@object.TabRippleColor = object2;
		}

		// Token: 0x1700014C RID: 332
		// (get) Token: 0x0600081B RID: 2075 RVA: 0x00015C68 File Offset: 0x00013E68
		// (set) Token: 0x0600081C RID: 2076 RVA: 0x00015C9C File Offset: 0x00013E9C
		public unsafe virtual ColorStateList TabRippleColor
		{
			[Register("getTabRippleColor", "()Landroid/content/res/ColorStateList;", "GetGetTabRippleColorHandler")]
			get
			{
				return Java.Lang.Object.GetObject<ColorStateList>(TabLayout._members.InstanceMethods.InvokeVirtualObjectMethod("getTabRippleColor.()Landroid/content/res/ColorStateList;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
			[Register("setTabRippleColor", "(Landroid/content/res/ColorStateList;)V", "GetSetTabRippleColor_Landroid_content_res_ColorStateList_Handler")]
			set
			{
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((value == null) ? IntPtr.Zero : value.Handle);
					TabLayout._members.InstanceMethods.InvokeVirtualVoidMethod("setTabRippleColor.(Landroid/content/res/ColorStateList;)V", this, ptr);
				}
				finally
				{
					GC.KeepAlive(value);
				}
			}
		}

		// Token: 0x0600081D RID: 2077 RVA: 0x00015D00 File Offset: 0x00013F00
		private static Delegate GetGetTabSelectedIndicatorHandler()
		{
			if (TabLayout.cb_getTabSelectedIndicator == null)
			{
				TabLayout.cb_getTabSelectedIndicator = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(TabLayout.n_GetTabSelectedIndicator));
			}
			return TabLayout.cb_getTabSelectedIndicator;
		}

		// Token: 0x0600081E RID: 2078 RVA: 0x00015D24 File Offset: 0x00013F24
		private static IntPtr n_GetTabSelectedIndicator(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<TabLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).TabSelectedIndicator);
		}

		// Token: 0x1700014D RID: 333
		// (get) Token: 0x0600081F RID: 2079 RVA: 0x00015D38 File Offset: 0x00013F38
		public virtual Drawable TabSelectedIndicator
		{
			[Register("getTabSelectedIndicator", "()Landroid/graphics/drawable/Drawable;", "GetGetTabSelectedIndicatorHandler")]
			get
			{
				return Java.Lang.Object.GetObject<Drawable>(TabLayout._members.InstanceMethods.InvokeVirtualObjectMethod("getTabSelectedIndicator.()Landroid/graphics/drawable/Drawable;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06000820 RID: 2080 RVA: 0x00015D6A File Offset: 0x00013F6A
		private static Delegate GetGetTabTextColorsHandler()
		{
			if (TabLayout.cb_getTabTextColors == null)
			{
				TabLayout.cb_getTabTextColors = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(TabLayout.n_GetTabTextColors));
			}
			return TabLayout.cb_getTabTextColors;
		}

		// Token: 0x06000821 RID: 2081 RVA: 0x00015D8E File Offset: 0x00013F8E
		private static IntPtr n_GetTabTextColors(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<TabLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).TabTextColors);
		}

		// Token: 0x06000822 RID: 2082 RVA: 0x00015DA2 File Offset: 0x00013FA2
		private static Delegate GetSetTabTextColors_Landroid_content_res_ColorStateList_Handler()
		{
			if (TabLayout.cb_setTabTextColors_Landroid_content_res_ColorStateList_ == null)
			{
				TabLayout.cb_setTabTextColors_Landroid_content_res_ColorStateList_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(TabLayout.n_SetTabTextColors_Landroid_content_res_ColorStateList_));
			}
			return TabLayout.cb_setTabTextColors_Landroid_content_res_ColorStateList_;
		}

		// Token: 0x06000823 RID: 2083 RVA: 0x00015DC8 File Offset: 0x00013FC8
		private static void n_SetTabTextColors_Landroid_content_res_ColorStateList_(IntPtr jnienv, IntPtr native__this, IntPtr native_textColor)
		{
			TabLayout @object = Java.Lang.Object.GetObject<TabLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ColorStateList object2 = Java.Lang.Object.GetObject<ColorStateList>(native_textColor, JniHandleOwnership.DoNotTransfer);
			@object.TabTextColors = object2;
		}

		// Token: 0x1700014E RID: 334
		// (get) Token: 0x06000824 RID: 2084 RVA: 0x00015DEC File Offset: 0x00013FEC
		// (set) Token: 0x06000825 RID: 2085 RVA: 0x00015E20 File Offset: 0x00014020
		public unsafe virtual ColorStateList TabTextColors
		{
			[Register("getTabTextColors", "()Landroid/content/res/ColorStateList;", "GetGetTabTextColorsHandler")]
			get
			{
				return Java.Lang.Object.GetObject<ColorStateList>(TabLayout._members.InstanceMethods.InvokeVirtualObjectMethod("getTabTextColors.()Landroid/content/res/ColorStateList;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
			[Register("setTabTextColors", "(Landroid/content/res/ColorStateList;)V", "GetSetTabTextColors_Landroid_content_res_ColorStateList_Handler")]
			set
			{
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((value == null) ? IntPtr.Zero : value.Handle);
					TabLayout._members.InstanceMethods.InvokeVirtualVoidMethod("setTabTextColors.(Landroid/content/res/ColorStateList;)V", this, ptr);
				}
				finally
				{
					GC.KeepAlive(value);
				}
			}
		}

		// Token: 0x06000826 RID: 2086 RVA: 0x00015E84 File Offset: 0x00014084
		private static Delegate GetAddOnTabSelectedListener_Lcom_google_android_material_tabs_TabLayout_BaseOnTabSelectedListener_Handler()
		{
			if (TabLayout.cb_addOnTabSelectedListener_Lcom_google_android_material_tabs_TabLayout_BaseOnTabSelectedListener_ == null)
			{
				TabLayout.cb_addOnTabSelectedListener_Lcom_google_android_material_tabs_TabLayout_BaseOnTabSelectedListener_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(TabLayout.n_AddOnTabSelectedListener_Lcom_google_android_material_tabs_TabLayout_BaseOnTabSelectedListener_));
			}
			return TabLayout.cb_addOnTabSelectedListener_Lcom_google_android_material_tabs_TabLayout_BaseOnTabSelectedListener_;
		}

		// Token: 0x06000827 RID: 2087 RVA: 0x00015EA8 File Offset: 0x000140A8
		private static void n_AddOnTabSelectedListener_Lcom_google_android_material_tabs_TabLayout_BaseOnTabSelectedListener_(IntPtr jnienv, IntPtr native__this, IntPtr native_listener)
		{
			TabLayout @object = Java.Lang.Object.GetObject<TabLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			TabLayout.IOnTabSelectedListener object2 = Java.Lang.Object.GetObject<TabLayout.IOnTabSelectedListener>(native_listener, JniHandleOwnership.DoNotTransfer);
			@object.AddOnTabSelectedListener(object2);
		}

		// Token: 0x06000828 RID: 2088 RVA: 0x00015ECC File Offset: 0x000140CC
		[Register("addOnTabSelectedListener", "(Lcom/google/android/material/tabs/TabLayout$BaseOnTabSelectedListener;)V", "GetAddOnTabSelectedListener_Lcom_google_android_material_tabs_TabLayout_BaseOnTabSelectedListener_Handler")]
		public unsafe virtual void AddOnTabSelectedListener(TabLayout.IOnTabSelectedListener listener)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((listener == null) ? IntPtr.Zero : ((Java.Lang.Object)listener).Handle);
				TabLayout._members.InstanceMethods.InvokeVirtualVoidMethod("addOnTabSelectedListener.(Lcom/google/android/material/tabs/TabLayout$BaseOnTabSelectedListener;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(listener);
			}
		}

		// Token: 0x06000829 RID: 2089 RVA: 0x00015F34 File Offset: 0x00014134
		private static Delegate GetAddOnTabSelectedListener_Lcom_google_android_material_tabs_TabLayout_OnTabSelectedListener_Handler()
		{
			if (TabLayout.cb_addOnTabSelectedListener_Lcom_google_android_material_tabs_TabLayout_OnTabSelectedListener_ == null)
			{
				TabLayout.cb_addOnTabSelectedListener_Lcom_google_android_material_tabs_TabLayout_OnTabSelectedListener_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(TabLayout.n_AddOnTabSelectedListener_Lcom_google_android_material_tabs_TabLayout_OnTabSelectedListener_));
			}
			return TabLayout.cb_addOnTabSelectedListener_Lcom_google_android_material_tabs_TabLayout_OnTabSelectedListener_;
		}

		// Token: 0x0600082A RID: 2090 RVA: 0x00015F58 File Offset: 0x00014158
		private static void n_AddOnTabSelectedListener_Lcom_google_android_material_tabs_TabLayout_OnTabSelectedListener_(IntPtr jnienv, IntPtr native__this, IntPtr native_listener)
		{
			TabLayout @object = Java.Lang.Object.GetObject<TabLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			TabLayout.IOnTabSelectedListener2 object2 = Java.Lang.Object.GetObject<TabLayout.IOnTabSelectedListener2>(native_listener, JniHandleOwnership.DoNotTransfer);
			@object.AddOnTabSelectedListener(object2);
		}

		// Token: 0x0600082B RID: 2091 RVA: 0x00015F7C File Offset: 0x0001417C
		[Register("addOnTabSelectedListener", "(Lcom/google/android/material/tabs/TabLayout$OnTabSelectedListener;)V", "GetAddOnTabSelectedListener_Lcom_google_android_material_tabs_TabLayout_OnTabSelectedListener_Handler")]
		public unsafe virtual void AddOnTabSelectedListener(TabLayout.IOnTabSelectedListener2 listener)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((listener == null) ? IntPtr.Zero : ((Java.Lang.Object)listener).Handle);
				TabLayout._members.InstanceMethods.InvokeVirtualVoidMethod("addOnTabSelectedListener.(Lcom/google/android/material/tabs/TabLayout$OnTabSelectedListener;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(listener);
			}
		}

		// Token: 0x0600082C RID: 2092 RVA: 0x00015FE4 File Offset: 0x000141E4
		private static Delegate GetAddTab_Lcom_google_android_material_tabs_TabLayout_Tab_Handler()
		{
			if (TabLayout.cb_addTab_Lcom_google_android_material_tabs_TabLayout_Tab_ == null)
			{
				TabLayout.cb_addTab_Lcom_google_android_material_tabs_TabLayout_Tab_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(TabLayout.n_AddTab_Lcom_google_android_material_tabs_TabLayout_Tab_));
			}
			return TabLayout.cb_addTab_Lcom_google_android_material_tabs_TabLayout_Tab_;
		}

		// Token: 0x0600082D RID: 2093 RVA: 0x00016008 File Offset: 0x00014208
		private static void n_AddTab_Lcom_google_android_material_tabs_TabLayout_Tab_(IntPtr jnienv, IntPtr native__this, IntPtr native_tab)
		{
			TabLayout @object = Java.Lang.Object.GetObject<TabLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			TabLayout.Tab object2 = Java.Lang.Object.GetObject<TabLayout.Tab>(native_tab, JniHandleOwnership.DoNotTransfer);
			@object.AddTab(object2);
		}

		// Token: 0x0600082E RID: 2094 RVA: 0x0001602C File Offset: 0x0001422C
		[Register("addTab", "(Lcom/google/android/material/tabs/TabLayout$Tab;)V", "GetAddTab_Lcom_google_android_material_tabs_TabLayout_Tab_Handler")]
		public unsafe virtual void AddTab(TabLayout.Tab tab)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((tab == null) ? IntPtr.Zero : tab.Handle);
				TabLayout._members.InstanceMethods.InvokeVirtualVoidMethod("addTab.(Lcom/google/android/material/tabs/TabLayout$Tab;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(tab);
			}
		}

		// Token: 0x0600082F RID: 2095 RVA: 0x00016090 File Offset: 0x00014290
		private static Delegate GetAddTab_Lcom_google_android_material_tabs_TabLayout_Tab_ZHandler()
		{
			if (TabLayout.cb_addTab_Lcom_google_android_material_tabs_TabLayout_Tab_Z == null)
			{
				TabLayout.cb_addTab_Lcom_google_android_material_tabs_TabLayout_Tab_Z = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLZ_V(TabLayout.n_AddTab_Lcom_google_android_material_tabs_TabLayout_Tab_Z));
			}
			return TabLayout.cb_addTab_Lcom_google_android_material_tabs_TabLayout_Tab_Z;
		}

		// Token: 0x06000830 RID: 2096 RVA: 0x000160B4 File Offset: 0x000142B4
		private static void n_AddTab_Lcom_google_android_material_tabs_TabLayout_Tab_Z(IntPtr jnienv, IntPtr native__this, IntPtr native_tab, bool setSelected)
		{
			TabLayout @object = Java.Lang.Object.GetObject<TabLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			TabLayout.Tab object2 = Java.Lang.Object.GetObject<TabLayout.Tab>(native_tab, JniHandleOwnership.DoNotTransfer);
			@object.AddTab(object2, setSelected);
		}

		// Token: 0x06000831 RID: 2097 RVA: 0x000160D8 File Offset: 0x000142D8
		[Register("addTab", "(Lcom/google/android/material/tabs/TabLayout$Tab;Z)V", "GetAddTab_Lcom_google_android_material_tabs_TabLayout_Tab_ZHandler")]
		public unsafe virtual void AddTab(TabLayout.Tab tab, bool setSelected)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((tab == null) ? IntPtr.Zero : tab.Handle);
				ptr[1] = new JniArgumentValue(setSelected);
				TabLayout._members.InstanceMethods.InvokeVirtualVoidMethod("addTab.(Lcom/google/android/material/tabs/TabLayout$Tab;Z)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(tab);
			}
		}

		// Token: 0x06000832 RID: 2098 RVA: 0x00016150 File Offset: 0x00014350
		private static Delegate GetAddTab_Lcom_google_android_material_tabs_TabLayout_Tab_IHandler()
		{
			if (TabLayout.cb_addTab_Lcom_google_android_material_tabs_TabLayout_Tab_I == null)
			{
				TabLayout.cb_addTab_Lcom_google_android_material_tabs_TabLayout_Tab_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLI_V(TabLayout.n_AddTab_Lcom_google_android_material_tabs_TabLayout_Tab_I));
			}
			return TabLayout.cb_addTab_Lcom_google_android_material_tabs_TabLayout_Tab_I;
		}

		// Token: 0x06000833 RID: 2099 RVA: 0x00016174 File Offset: 0x00014374
		private static void n_AddTab_Lcom_google_android_material_tabs_TabLayout_Tab_I(IntPtr jnienv, IntPtr native__this, IntPtr native_tab, int position)
		{
			TabLayout @object = Java.Lang.Object.GetObject<TabLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			TabLayout.Tab object2 = Java.Lang.Object.GetObject<TabLayout.Tab>(native_tab, JniHandleOwnership.DoNotTransfer);
			@object.AddTab(object2, position);
		}

		// Token: 0x06000834 RID: 2100 RVA: 0x00016198 File Offset: 0x00014398
		[Register("addTab", "(Lcom/google/android/material/tabs/TabLayout$Tab;I)V", "GetAddTab_Lcom_google_android_material_tabs_TabLayout_Tab_IHandler")]
		public unsafe virtual void AddTab(TabLayout.Tab tab, int position)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((tab == null) ? IntPtr.Zero : tab.Handle);
				ptr[1] = new JniArgumentValue(position);
				TabLayout._members.InstanceMethods.InvokeVirtualVoidMethod("addTab.(Lcom/google/android/material/tabs/TabLayout$Tab;I)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(tab);
			}
		}

		// Token: 0x06000835 RID: 2101 RVA: 0x00016210 File Offset: 0x00014410
		private static Delegate GetAddTab_Lcom_google_android_material_tabs_TabLayout_Tab_IZHandler()
		{
			if (TabLayout.cb_addTab_Lcom_google_android_material_tabs_TabLayout_Tab_IZ == null)
			{
				TabLayout.cb_addTab_Lcom_google_android_material_tabs_TabLayout_Tab_IZ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLIZ_V(TabLayout.n_AddTab_Lcom_google_android_material_tabs_TabLayout_Tab_IZ));
			}
			return TabLayout.cb_addTab_Lcom_google_android_material_tabs_TabLayout_Tab_IZ;
		}

		// Token: 0x06000836 RID: 2102 RVA: 0x00016234 File Offset: 0x00014434
		private static void n_AddTab_Lcom_google_android_material_tabs_TabLayout_Tab_IZ(IntPtr jnienv, IntPtr native__this, IntPtr native_tab, int position, bool setSelected)
		{
			TabLayout @object = Java.Lang.Object.GetObject<TabLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			TabLayout.Tab object2 = Java.Lang.Object.GetObject<TabLayout.Tab>(native_tab, JniHandleOwnership.DoNotTransfer);
			@object.AddTab(object2, position, setSelected);
		}

		// Token: 0x06000837 RID: 2103 RVA: 0x0001625C File Offset: 0x0001445C
		[Register("addTab", "(Lcom/google/android/material/tabs/TabLayout$Tab;IZ)V", "GetAddTab_Lcom_google_android_material_tabs_TabLayout_Tab_IZHandler")]
		public unsafe virtual void AddTab(TabLayout.Tab tab, int position, bool setSelected)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((tab == null) ? IntPtr.Zero : tab.Handle);
				ptr[1] = new JniArgumentValue(position);
				ptr[2] = new JniArgumentValue(setSelected);
				TabLayout._members.InstanceMethods.InvokeVirtualVoidMethod("addTab.(Lcom/google/android/material/tabs/TabLayout$Tab;IZ)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(tab);
			}
		}

		// Token: 0x06000838 RID: 2104 RVA: 0x000162E8 File Offset: 0x000144E8
		private static Delegate GetClearOnTabSelectedListenersHandler()
		{
			if (TabLayout.cb_clearOnTabSelectedListeners == null)
			{
				TabLayout.cb_clearOnTabSelectedListeners = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(TabLayout.n_ClearOnTabSelectedListeners));
			}
			return TabLayout.cb_clearOnTabSelectedListeners;
		}

		// Token: 0x06000839 RID: 2105 RVA: 0x0001630C File Offset: 0x0001450C
		private static void n_ClearOnTabSelectedListeners(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<TabLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ClearOnTabSelectedListeners();
		}

		// Token: 0x0600083A RID: 2106 RVA: 0x0001631B File Offset: 0x0001451B
		[Register("clearOnTabSelectedListeners", "()V", "GetClearOnTabSelectedListenersHandler")]
		public virtual void ClearOnTabSelectedListeners()
		{
			TabLayout._members.InstanceMethods.InvokeVirtualVoidMethod("clearOnTabSelectedListeners.()V", this, null);
		}

		// Token: 0x0600083B RID: 2107 RVA: 0x00016334 File Offset: 0x00014534
		private static Delegate GetCreateTabFromPoolHandler()
		{
			if (TabLayout.cb_createTabFromPool == null)
			{
				TabLayout.cb_createTabFromPool = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(TabLayout.n_CreateTabFromPool));
			}
			return TabLayout.cb_createTabFromPool;
		}

		// Token: 0x0600083C RID: 2108 RVA: 0x00016358 File Offset: 0x00014558
		private static IntPtr n_CreateTabFromPool(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<TabLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).CreateTabFromPool());
		}

		// Token: 0x0600083D RID: 2109 RVA: 0x0001636C File Offset: 0x0001456C
		[Register("createTabFromPool", "()Lcom/google/android/material/tabs/TabLayout$Tab;", "GetCreateTabFromPoolHandler")]
		protected virtual TabLayout.Tab CreateTabFromPool()
		{
			return Java.Lang.Object.GetObject<TabLayout.Tab>(TabLayout._members.InstanceMethods.InvokeVirtualObjectMethod("createTabFromPool.()Lcom/google/android/material/tabs/TabLayout$Tab;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x0600083E RID: 2110 RVA: 0x0001639E File Offset: 0x0001459E
		private static Delegate GetGetTabAt_IHandler()
		{
			if (TabLayout.cb_getTabAt_I == null)
			{
				TabLayout.cb_getTabAt_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_L(TabLayout.n_GetTabAt_I));
			}
			return TabLayout.cb_getTabAt_I;
		}

		// Token: 0x0600083F RID: 2111 RVA: 0x000163C2 File Offset: 0x000145C2
		private static IntPtr n_GetTabAt_I(IntPtr jnienv, IntPtr native__this, int index)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<TabLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).GetTabAt(index));
		}

		// Token: 0x06000840 RID: 2112 RVA: 0x000163D8 File Offset: 0x000145D8
		[Register("getTabAt", "(I)Lcom/google/android/material/tabs/TabLayout$Tab;", "GetGetTabAt_IHandler")]
		public unsafe virtual TabLayout.Tab GetTabAt(int index)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(index);
			return Java.Lang.Object.GetObject<TabLayout.Tab>(TabLayout._members.InstanceMethods.InvokeVirtualObjectMethod("getTabAt.(I)Lcom/google/android/material/tabs/TabLayout$Tab;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06000841 RID: 2113 RVA: 0x00016421 File Offset: 0x00014621
		private static Delegate GetNewTabHandler()
		{
			if (TabLayout.cb_newTab == null)
			{
				TabLayout.cb_newTab = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(TabLayout.n_NewTab));
			}
			return TabLayout.cb_newTab;
		}

		// Token: 0x06000842 RID: 2114 RVA: 0x00016445 File Offset: 0x00014645
		private static IntPtr n_NewTab(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<TabLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).NewTab());
		}

		// Token: 0x06000843 RID: 2115 RVA: 0x0001645C File Offset: 0x0001465C
		[Register("newTab", "()Lcom/google/android/material/tabs/TabLayout$Tab;", "GetNewTabHandler")]
		public virtual TabLayout.Tab NewTab()
		{
			return Java.Lang.Object.GetObject<TabLayout.Tab>(TabLayout._members.InstanceMethods.InvokeVirtualObjectMethod("newTab.()Lcom/google/android/material/tabs/TabLayout$Tab;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06000844 RID: 2116 RVA: 0x0001648E File Offset: 0x0001468E
		private static Delegate GetReleaseFromTabPool_Lcom_google_android_material_tabs_TabLayout_Tab_Handler()
		{
			if (TabLayout.cb_releaseFromTabPool_Lcom_google_android_material_tabs_TabLayout_Tab_ == null)
			{
				TabLayout.cb_releaseFromTabPool_Lcom_google_android_material_tabs_TabLayout_Tab_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(TabLayout.n_ReleaseFromTabPool_Lcom_google_android_material_tabs_TabLayout_Tab_));
			}
			return TabLayout.cb_releaseFromTabPool_Lcom_google_android_material_tabs_TabLayout_Tab_;
		}

		// Token: 0x06000845 RID: 2117 RVA: 0x000164B4 File Offset: 0x000146B4
		private static bool n_ReleaseFromTabPool_Lcom_google_android_material_tabs_TabLayout_Tab_(IntPtr jnienv, IntPtr native__this, IntPtr native_tab)
		{
			TabLayout @object = Java.Lang.Object.GetObject<TabLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			TabLayout.Tab object2 = Java.Lang.Object.GetObject<TabLayout.Tab>(native_tab, JniHandleOwnership.DoNotTransfer);
			return @object.ReleaseFromTabPool(object2);
		}

		// Token: 0x06000846 RID: 2118 RVA: 0x000164D8 File Offset: 0x000146D8
		[Register("releaseFromTabPool", "(Lcom/google/android/material/tabs/TabLayout$Tab;)Z", "GetReleaseFromTabPool_Lcom_google_android_material_tabs_TabLayout_Tab_Handler")]
		protected unsafe virtual bool ReleaseFromTabPool(TabLayout.Tab tab)
		{
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((tab == null) ? IntPtr.Zero : tab.Handle);
				result = TabLayout._members.InstanceMethods.InvokeVirtualBooleanMethod("releaseFromTabPool.(Lcom/google/android/material/tabs/TabLayout$Tab;)Z", this, ptr);
			}
			finally
			{
				GC.KeepAlive(tab);
			}
			return result;
		}

		// Token: 0x06000847 RID: 2119 RVA: 0x00016540 File Offset: 0x00014740
		private static Delegate GetRemoveAllTabsHandler()
		{
			if (TabLayout.cb_removeAllTabs == null)
			{
				TabLayout.cb_removeAllTabs = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(TabLayout.n_RemoveAllTabs));
			}
			return TabLayout.cb_removeAllTabs;
		}

		// Token: 0x06000848 RID: 2120 RVA: 0x00016564 File Offset: 0x00014764
		private static void n_RemoveAllTabs(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<TabLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).RemoveAllTabs();
		}

		// Token: 0x06000849 RID: 2121 RVA: 0x00016573 File Offset: 0x00014773
		[Register("removeAllTabs", "()V", "GetRemoveAllTabsHandler")]
		public virtual void RemoveAllTabs()
		{
			TabLayout._members.InstanceMethods.InvokeVirtualVoidMethod("removeAllTabs.()V", this, null);
		}

		// Token: 0x0600084A RID: 2122 RVA: 0x0001658C File Offset: 0x0001478C
		private static Delegate GetRemoveOnTabSelectedListener_Lcom_google_android_material_tabs_TabLayout_BaseOnTabSelectedListener_Handler()
		{
			if (TabLayout.cb_removeOnTabSelectedListener_Lcom_google_android_material_tabs_TabLayout_BaseOnTabSelectedListener_ == null)
			{
				TabLayout.cb_removeOnTabSelectedListener_Lcom_google_android_material_tabs_TabLayout_BaseOnTabSelectedListener_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(TabLayout.n_RemoveOnTabSelectedListener_Lcom_google_android_material_tabs_TabLayout_BaseOnTabSelectedListener_));
			}
			return TabLayout.cb_removeOnTabSelectedListener_Lcom_google_android_material_tabs_TabLayout_BaseOnTabSelectedListener_;
		}

		// Token: 0x0600084B RID: 2123 RVA: 0x000165B0 File Offset: 0x000147B0
		private static void n_RemoveOnTabSelectedListener_Lcom_google_android_material_tabs_TabLayout_BaseOnTabSelectedListener_(IntPtr jnienv, IntPtr native__this, IntPtr native_listener)
		{
			TabLayout @object = Java.Lang.Object.GetObject<TabLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			TabLayout.IOnTabSelectedListener object2 = Java.Lang.Object.GetObject<TabLayout.IOnTabSelectedListener>(native_listener, JniHandleOwnership.DoNotTransfer);
			@object.RemoveOnTabSelectedListener(object2);
		}

		// Token: 0x0600084C RID: 2124 RVA: 0x000165D4 File Offset: 0x000147D4
		[Register("removeOnTabSelectedListener", "(Lcom/google/android/material/tabs/TabLayout$BaseOnTabSelectedListener;)V", "GetRemoveOnTabSelectedListener_Lcom_google_android_material_tabs_TabLayout_BaseOnTabSelectedListener_Handler")]
		public unsafe virtual void RemoveOnTabSelectedListener(TabLayout.IOnTabSelectedListener listener)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((listener == null) ? IntPtr.Zero : ((Java.Lang.Object)listener).Handle);
				TabLayout._members.InstanceMethods.InvokeVirtualVoidMethod("removeOnTabSelectedListener.(Lcom/google/android/material/tabs/TabLayout$BaseOnTabSelectedListener;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(listener);
			}
		}

		// Token: 0x0600084D RID: 2125 RVA: 0x0001663C File Offset: 0x0001483C
		private static Delegate GetRemoveOnTabSelectedListener_Lcom_google_android_material_tabs_TabLayout_OnTabSelectedListener_Handler()
		{
			if (TabLayout.cb_removeOnTabSelectedListener_Lcom_google_android_material_tabs_TabLayout_OnTabSelectedListener_ == null)
			{
				TabLayout.cb_removeOnTabSelectedListener_Lcom_google_android_material_tabs_TabLayout_OnTabSelectedListener_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(TabLayout.n_RemoveOnTabSelectedListener_Lcom_google_android_material_tabs_TabLayout_OnTabSelectedListener_));
			}
			return TabLayout.cb_removeOnTabSelectedListener_Lcom_google_android_material_tabs_TabLayout_OnTabSelectedListener_;
		}

		// Token: 0x0600084E RID: 2126 RVA: 0x00016660 File Offset: 0x00014860
		private static void n_RemoveOnTabSelectedListener_Lcom_google_android_material_tabs_TabLayout_OnTabSelectedListener_(IntPtr jnienv, IntPtr native__this, IntPtr native_listener)
		{
			TabLayout @object = Java.Lang.Object.GetObject<TabLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			TabLayout.IOnTabSelectedListener2 object2 = Java.Lang.Object.GetObject<TabLayout.IOnTabSelectedListener2>(native_listener, JniHandleOwnership.DoNotTransfer);
			@object.RemoveOnTabSelectedListener(object2);
		}

		// Token: 0x0600084F RID: 2127 RVA: 0x00016684 File Offset: 0x00014884
		[Register("removeOnTabSelectedListener", "(Lcom/google/android/material/tabs/TabLayout$OnTabSelectedListener;)V", "GetRemoveOnTabSelectedListener_Lcom_google_android_material_tabs_TabLayout_OnTabSelectedListener_Handler")]
		public unsafe virtual void RemoveOnTabSelectedListener(TabLayout.IOnTabSelectedListener2 listener)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((listener == null) ? IntPtr.Zero : ((Java.Lang.Object)listener).Handle);
				TabLayout._members.InstanceMethods.InvokeVirtualVoidMethod("removeOnTabSelectedListener.(Lcom/google/android/material/tabs/TabLayout$OnTabSelectedListener;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(listener);
			}
		}

		// Token: 0x06000850 RID: 2128 RVA: 0x000166EC File Offset: 0x000148EC
		private static Delegate GetRemoveTab_Lcom_google_android_material_tabs_TabLayout_Tab_Handler()
		{
			if (TabLayout.cb_removeTab_Lcom_google_android_material_tabs_TabLayout_Tab_ == null)
			{
				TabLayout.cb_removeTab_Lcom_google_android_material_tabs_TabLayout_Tab_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(TabLayout.n_RemoveTab_Lcom_google_android_material_tabs_TabLayout_Tab_));
			}
			return TabLayout.cb_removeTab_Lcom_google_android_material_tabs_TabLayout_Tab_;
		}

		// Token: 0x06000851 RID: 2129 RVA: 0x00016710 File Offset: 0x00014910
		private static void n_RemoveTab_Lcom_google_android_material_tabs_TabLayout_Tab_(IntPtr jnienv, IntPtr native__this, IntPtr native_tab)
		{
			TabLayout @object = Java.Lang.Object.GetObject<TabLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			TabLayout.Tab object2 = Java.Lang.Object.GetObject<TabLayout.Tab>(native_tab, JniHandleOwnership.DoNotTransfer);
			@object.RemoveTab(object2);
		}

		// Token: 0x06000852 RID: 2130 RVA: 0x00016734 File Offset: 0x00014934
		[Register("removeTab", "(Lcom/google/android/material/tabs/TabLayout$Tab;)V", "GetRemoveTab_Lcom_google_android_material_tabs_TabLayout_Tab_Handler")]
		public unsafe virtual void RemoveTab(TabLayout.Tab tab)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((tab == null) ? IntPtr.Zero : tab.Handle);
				TabLayout._members.InstanceMethods.InvokeVirtualVoidMethod("removeTab.(Lcom/google/android/material/tabs/TabLayout$Tab;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(tab);
			}
		}

		// Token: 0x06000853 RID: 2131 RVA: 0x00016798 File Offset: 0x00014998
		private static Delegate GetRemoveTabAt_IHandler()
		{
			if (TabLayout.cb_removeTabAt_I == null)
			{
				TabLayout.cb_removeTabAt_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_V(TabLayout.n_RemoveTabAt_I));
			}
			return TabLayout.cb_removeTabAt_I;
		}

		// Token: 0x06000854 RID: 2132 RVA: 0x000167BC File Offset: 0x000149BC
		private static void n_RemoveTabAt_I(IntPtr jnienv, IntPtr native__this, int position)
		{
			Java.Lang.Object.GetObject<TabLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).RemoveTabAt(position);
		}

		// Token: 0x06000855 RID: 2133 RVA: 0x000167CC File Offset: 0x000149CC
		[Register("removeTabAt", "(I)V", "GetRemoveTabAt_IHandler")]
		public unsafe virtual void RemoveTabAt(int position)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(position);
			TabLayout._members.InstanceMethods.InvokeVirtualVoidMethod("removeTabAt.(I)V", this, ptr);
		}

		// Token: 0x06000856 RID: 2134 RVA: 0x00016807 File Offset: 0x00014A07
		private static Delegate GetSelectTab_Lcom_google_android_material_tabs_TabLayout_Tab_Handler()
		{
			if (TabLayout.cb_selectTab_Lcom_google_android_material_tabs_TabLayout_Tab_ == null)
			{
				TabLayout.cb_selectTab_Lcom_google_android_material_tabs_TabLayout_Tab_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(TabLayout.n_SelectTab_Lcom_google_android_material_tabs_TabLayout_Tab_));
			}
			return TabLayout.cb_selectTab_Lcom_google_android_material_tabs_TabLayout_Tab_;
		}

		// Token: 0x06000857 RID: 2135 RVA: 0x0001682C File Offset: 0x00014A2C
		private static void n_SelectTab_Lcom_google_android_material_tabs_TabLayout_Tab_(IntPtr jnienv, IntPtr native__this, IntPtr native_tab)
		{
			TabLayout @object = Java.Lang.Object.GetObject<TabLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			TabLayout.Tab object2 = Java.Lang.Object.GetObject<TabLayout.Tab>(native_tab, JniHandleOwnership.DoNotTransfer);
			@object.SelectTab(object2);
		}

		// Token: 0x06000858 RID: 2136 RVA: 0x00016850 File Offset: 0x00014A50
		[Register("selectTab", "(Lcom/google/android/material/tabs/TabLayout$Tab;)V", "GetSelectTab_Lcom_google_android_material_tabs_TabLayout_Tab_Handler")]
		public unsafe virtual void SelectTab(TabLayout.Tab tab)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((tab == null) ? IntPtr.Zero : tab.Handle);
				TabLayout._members.InstanceMethods.InvokeVirtualVoidMethod("selectTab.(Lcom/google/android/material/tabs/TabLayout$Tab;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(tab);
			}
		}

		// Token: 0x06000859 RID: 2137 RVA: 0x000168B4 File Offset: 0x00014AB4
		private static Delegate GetSelectTab_Lcom_google_android_material_tabs_TabLayout_Tab_ZHandler()
		{
			if (TabLayout.cb_selectTab_Lcom_google_android_material_tabs_TabLayout_Tab_Z == null)
			{
				TabLayout.cb_selectTab_Lcom_google_android_material_tabs_TabLayout_Tab_Z = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLZ_V(TabLayout.n_SelectTab_Lcom_google_android_material_tabs_TabLayout_Tab_Z));
			}
			return TabLayout.cb_selectTab_Lcom_google_android_material_tabs_TabLayout_Tab_Z;
		}

		// Token: 0x0600085A RID: 2138 RVA: 0x000168D8 File Offset: 0x00014AD8
		private static void n_SelectTab_Lcom_google_android_material_tabs_TabLayout_Tab_Z(IntPtr jnienv, IntPtr native__this, IntPtr native_tab, bool updateIndicator)
		{
			TabLayout @object = Java.Lang.Object.GetObject<TabLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			TabLayout.Tab object2 = Java.Lang.Object.GetObject<TabLayout.Tab>(native_tab, JniHandleOwnership.DoNotTransfer);
			@object.SelectTab(object2, updateIndicator);
		}

		// Token: 0x0600085B RID: 2139 RVA: 0x000168FC File Offset: 0x00014AFC
		[Register("selectTab", "(Lcom/google/android/material/tabs/TabLayout$Tab;Z)V", "GetSelectTab_Lcom_google_android_material_tabs_TabLayout_Tab_ZHandler")]
		public unsafe virtual void SelectTab(TabLayout.Tab tab, bool updateIndicator)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((tab == null) ? IntPtr.Zero : tab.Handle);
				ptr[1] = new JniArgumentValue(updateIndicator);
				TabLayout._members.InstanceMethods.InvokeVirtualVoidMethod("selectTab.(Lcom/google/android/material/tabs/TabLayout$Tab;Z)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(tab);
			}
		}

		// Token: 0x0600085C RID: 2140 RVA: 0x00016974 File Offset: 0x00014B74
		private static Delegate GetSetInlineLabelResource_IHandler()
		{
			if (TabLayout.cb_setInlineLabelResource_I == null)
			{
				TabLayout.cb_setInlineLabelResource_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_V(TabLayout.n_SetInlineLabelResource_I));
			}
			return TabLayout.cb_setInlineLabelResource_I;
		}

		// Token: 0x0600085D RID: 2141 RVA: 0x00016998 File Offset: 0x00014B98
		private static void n_SetInlineLabelResource_I(IntPtr jnienv, IntPtr native__this, int inlineResourceId)
		{
			Java.Lang.Object.GetObject<TabLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SetInlineLabelResource(inlineResourceId);
		}

		// Token: 0x0600085E RID: 2142 RVA: 0x000169A8 File Offset: 0x00014BA8
		[Register("setInlineLabelResource", "(I)V", "GetSetInlineLabelResource_IHandler")]
		public unsafe virtual void SetInlineLabelResource(int inlineResourceId)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(inlineResourceId);
			TabLayout._members.InstanceMethods.InvokeVirtualVoidMethod("setInlineLabelResource.(I)V", this, ptr);
		}

		// Token: 0x0600085F RID: 2143 RVA: 0x000169E3 File Offset: 0x00014BE3
		private static Delegate GetSetOnTabSelectedListener_Lcom_google_android_material_tabs_TabLayout_BaseOnTabSelectedListener_Handler()
		{
			if (TabLayout.cb_setOnTabSelectedListener_Lcom_google_android_material_tabs_TabLayout_BaseOnTabSelectedListener_ == null)
			{
				TabLayout.cb_setOnTabSelectedListener_Lcom_google_android_material_tabs_TabLayout_BaseOnTabSelectedListener_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(TabLayout.n_SetOnTabSelectedListener_Lcom_google_android_material_tabs_TabLayout_BaseOnTabSelectedListener_));
			}
			return TabLayout.cb_setOnTabSelectedListener_Lcom_google_android_material_tabs_TabLayout_BaseOnTabSelectedListener_;
		}

		// Token: 0x06000860 RID: 2144 RVA: 0x00016A08 File Offset: 0x00014C08
		private static void n_SetOnTabSelectedListener_Lcom_google_android_material_tabs_TabLayout_BaseOnTabSelectedListener_(IntPtr jnienv, IntPtr native__this, IntPtr native_listener)
		{
			TabLayout @object = Java.Lang.Object.GetObject<TabLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			TabLayout.IOnTabSelectedListener object2 = Java.Lang.Object.GetObject<TabLayout.IOnTabSelectedListener>(native_listener, JniHandleOwnership.DoNotTransfer);
			@object.SetOnTabSelectedListener(object2);
		}

		// Token: 0x06000861 RID: 2145 RVA: 0x00016A2C File Offset: 0x00014C2C
		[Register("setOnTabSelectedListener", "(Lcom/google/android/material/tabs/TabLayout$BaseOnTabSelectedListener;)V", "GetSetOnTabSelectedListener_Lcom_google_android_material_tabs_TabLayout_BaseOnTabSelectedListener_Handler")]
		public unsafe virtual void SetOnTabSelectedListener(TabLayout.IOnTabSelectedListener listener)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((listener == null) ? IntPtr.Zero : ((Java.Lang.Object)listener).Handle);
				TabLayout._members.InstanceMethods.InvokeVirtualVoidMethod("setOnTabSelectedListener.(Lcom/google/android/material/tabs/TabLayout$BaseOnTabSelectedListener;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(listener);
			}
		}

		// Token: 0x06000862 RID: 2146 RVA: 0x00016A94 File Offset: 0x00014C94
		private static Delegate GetSetOnTabSelectedListener_Lcom_google_android_material_tabs_TabLayout_OnTabSelectedListener_Handler()
		{
			if (TabLayout.cb_setOnTabSelectedListener_Lcom_google_android_material_tabs_TabLayout_OnTabSelectedListener_ == null)
			{
				TabLayout.cb_setOnTabSelectedListener_Lcom_google_android_material_tabs_TabLayout_OnTabSelectedListener_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(TabLayout.n_SetOnTabSelectedListener_Lcom_google_android_material_tabs_TabLayout_OnTabSelectedListener_));
			}
			return TabLayout.cb_setOnTabSelectedListener_Lcom_google_android_material_tabs_TabLayout_OnTabSelectedListener_;
		}

		// Token: 0x06000863 RID: 2147 RVA: 0x00016AB8 File Offset: 0x00014CB8
		private static void n_SetOnTabSelectedListener_Lcom_google_android_material_tabs_TabLayout_OnTabSelectedListener_(IntPtr jnienv, IntPtr native__this, IntPtr native_listener)
		{
			TabLayout @object = Java.Lang.Object.GetObject<TabLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			TabLayout.IOnTabSelectedListener2 object2 = Java.Lang.Object.GetObject<TabLayout.IOnTabSelectedListener2>(native_listener, JniHandleOwnership.DoNotTransfer);
			@object.SetOnTabSelectedListener(object2);
		}

		// Token: 0x06000864 RID: 2148 RVA: 0x00016ADC File Offset: 0x00014CDC
		[Register("setOnTabSelectedListener", "(Lcom/google/android/material/tabs/TabLayout$OnTabSelectedListener;)V", "GetSetOnTabSelectedListener_Lcom_google_android_material_tabs_TabLayout_OnTabSelectedListener_Handler")]
		public unsafe virtual void SetOnTabSelectedListener(TabLayout.IOnTabSelectedListener2 listener)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((listener == null) ? IntPtr.Zero : ((Java.Lang.Object)listener).Handle);
				TabLayout._members.InstanceMethods.InvokeVirtualVoidMethod("setOnTabSelectedListener.(Lcom/google/android/material/tabs/TabLayout$OnTabSelectedListener;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(listener);
			}
		}

		// Token: 0x06000865 RID: 2149 RVA: 0x00016B44 File Offset: 0x00014D44
		private static Delegate GetSetScrollPosition_IFZHandler()
		{
			if (TabLayout.cb_setScrollPosition_IFZ == null)
			{
				TabLayout.cb_setScrollPosition_IFZ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPIFZ_V(TabLayout.n_SetScrollPosition_IFZ));
			}
			return TabLayout.cb_setScrollPosition_IFZ;
		}

		// Token: 0x06000866 RID: 2150 RVA: 0x00016B68 File Offset: 0x00014D68
		private static void n_SetScrollPosition_IFZ(IntPtr jnienv, IntPtr native__this, int position, float positionOffset, bool updateSelectedTabView)
		{
			Java.Lang.Object.GetObject<TabLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SetScrollPosition(position, positionOffset, updateSelectedTabView);
		}

		// Token: 0x06000867 RID: 2151 RVA: 0x00016B7C File Offset: 0x00014D7C
		[Register("setScrollPosition", "(IFZ)V", "GetSetScrollPosition_IFZHandler")]
		public unsafe virtual void SetScrollPosition(int position, float positionOffset, bool updateSelectedTabView)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(position);
			ptr[1] = new JniArgumentValue(positionOffset);
			ptr[2] = new JniArgumentValue(updateSelectedTabView);
			TabLayout._members.InstanceMethods.InvokeVirtualVoidMethod("setScrollPosition.(IFZ)V", this, ptr);
		}

		// Token: 0x06000868 RID: 2152 RVA: 0x00016BE0 File Offset: 0x00014DE0
		private static Delegate GetSetScrollPosition_IFZZHandler()
		{
			if (TabLayout.cb_setScrollPosition_IFZZ == null)
			{
				TabLayout.cb_setScrollPosition_IFZZ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPIFZZ_V(TabLayout.n_SetScrollPosition_IFZZ));
			}
			return TabLayout.cb_setScrollPosition_IFZZ;
		}

		// Token: 0x06000869 RID: 2153 RVA: 0x00016C04 File Offset: 0x00014E04
		private static void n_SetScrollPosition_IFZZ(IntPtr jnienv, IntPtr native__this, int position, float positionOffset, bool updateSelectedTabView, bool updateIndicatorPosition)
		{
			Java.Lang.Object.GetObject<TabLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SetScrollPosition(position, positionOffset, updateSelectedTabView, updateIndicatorPosition);
		}

		// Token: 0x0600086A RID: 2154 RVA: 0x00016C1C File Offset: 0x00014E1C
		[Register("setScrollPosition", "(IFZZ)V", "GetSetScrollPosition_IFZZHandler")]
		public unsafe virtual void SetScrollPosition(int position, float positionOffset, bool updateSelectedTabView, bool updateIndicatorPosition)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(position);
			ptr[1] = new JniArgumentValue(positionOffset);
			ptr[2] = new JniArgumentValue(updateSelectedTabView);
			ptr[3] = new JniArgumentValue(updateIndicatorPosition);
			TabLayout._members.InstanceMethods.InvokeVirtualVoidMethod("setScrollPosition.(IFZZ)V", this, ptr);
		}

		// Token: 0x0600086B RID: 2155 RVA: 0x00016C97 File Offset: 0x00014E97
		private static Delegate GetSetSelectedTabIndicator_Landroid_graphics_drawable_Drawable_Handler()
		{
			if (TabLayout.cb_setSelectedTabIndicator_Landroid_graphics_drawable_Drawable_ == null)
			{
				TabLayout.cb_setSelectedTabIndicator_Landroid_graphics_drawable_Drawable_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(TabLayout.n_SetSelectedTabIndicator_Landroid_graphics_drawable_Drawable_));
			}
			return TabLayout.cb_setSelectedTabIndicator_Landroid_graphics_drawable_Drawable_;
		}

		// Token: 0x0600086C RID: 2156 RVA: 0x00016CBC File Offset: 0x00014EBC
		private static void n_SetSelectedTabIndicator_Landroid_graphics_drawable_Drawable_(IntPtr jnienv, IntPtr native__this, IntPtr native_tabSelectedIndicator)
		{
			TabLayout @object = Java.Lang.Object.GetObject<TabLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Drawable object2 = Java.Lang.Object.GetObject<Drawable>(native_tabSelectedIndicator, JniHandleOwnership.DoNotTransfer);
			@object.SetSelectedTabIndicator(object2);
		}

		// Token: 0x0600086D RID: 2157 RVA: 0x00016CE0 File Offset: 0x00014EE0
		[Register("setSelectedTabIndicator", "(Landroid/graphics/drawable/Drawable;)V", "GetSetSelectedTabIndicator_Landroid_graphics_drawable_Drawable_Handler")]
		public unsafe virtual void SetSelectedTabIndicator(Drawable tabSelectedIndicator)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((tabSelectedIndicator == null) ? IntPtr.Zero : tabSelectedIndicator.Handle);
				TabLayout._members.InstanceMethods.InvokeVirtualVoidMethod("setSelectedTabIndicator.(Landroid/graphics/drawable/Drawable;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(tabSelectedIndicator);
			}
		}

		// Token: 0x0600086E RID: 2158 RVA: 0x00016D44 File Offset: 0x00014F44
		private static Delegate GetSetSelectedTabIndicator_IHandler()
		{
			if (TabLayout.cb_setSelectedTabIndicator_I == null)
			{
				TabLayout.cb_setSelectedTabIndicator_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_V(TabLayout.n_SetSelectedTabIndicator_I));
			}
			return TabLayout.cb_setSelectedTabIndicator_I;
		}

		// Token: 0x0600086F RID: 2159 RVA: 0x00016D68 File Offset: 0x00014F68
		private static void n_SetSelectedTabIndicator_I(IntPtr jnienv, IntPtr native__this, int tabSelectedIndicatorResourceId)
		{
			Java.Lang.Object.GetObject<TabLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SetSelectedTabIndicator(tabSelectedIndicatorResourceId);
		}

		// Token: 0x06000870 RID: 2160 RVA: 0x00016D78 File Offset: 0x00014F78
		[Register("setSelectedTabIndicator", "(I)V", "GetSetSelectedTabIndicator_IHandler")]
		public unsafe virtual void SetSelectedTabIndicator(int tabSelectedIndicatorResourceId)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(tabSelectedIndicatorResourceId);
			TabLayout._members.InstanceMethods.InvokeVirtualVoidMethod("setSelectedTabIndicator.(I)V", this, ptr);
		}

		// Token: 0x06000871 RID: 2161 RVA: 0x00016DB3 File Offset: 0x00014FB3
		private static Delegate GetSetSelectedTabIndicatorColor_IHandler()
		{
			if (TabLayout.cb_setSelectedTabIndicatorColor_I == null)
			{
				TabLayout.cb_setSelectedTabIndicatorColor_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_V(TabLayout.n_SetSelectedTabIndicatorColor_I));
			}
			return TabLayout.cb_setSelectedTabIndicatorColor_I;
		}

		// Token: 0x06000872 RID: 2162 RVA: 0x00016DD7 File Offset: 0x00014FD7
		private static void n_SetSelectedTabIndicatorColor_I(IntPtr jnienv, IntPtr native__this, int color)
		{
			Java.Lang.Object.GetObject<TabLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SetSelectedTabIndicatorColor(color);
		}

		// Token: 0x06000873 RID: 2163 RVA: 0x00016DE8 File Offset: 0x00014FE8
		[Register("setSelectedTabIndicatorColor", "(I)V", "GetSetSelectedTabIndicatorColor_IHandler")]
		public unsafe virtual void SetSelectedTabIndicatorColor(int color)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(color);
			TabLayout._members.InstanceMethods.InvokeVirtualVoidMethod("setSelectedTabIndicatorColor.(I)V", this, ptr);
		}

		// Token: 0x06000874 RID: 2164 RVA: 0x00016E23 File Offset: 0x00015023
		private static Delegate GetSetSelectedTabIndicatorGravity_IHandler()
		{
			if (TabLayout.cb_setSelectedTabIndicatorGravity_I == null)
			{
				TabLayout.cb_setSelectedTabIndicatorGravity_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_V(TabLayout.n_SetSelectedTabIndicatorGravity_I));
			}
			return TabLayout.cb_setSelectedTabIndicatorGravity_I;
		}

		// Token: 0x06000875 RID: 2165 RVA: 0x00016E47 File Offset: 0x00015047
		private static void n_SetSelectedTabIndicatorGravity_I(IntPtr jnienv, IntPtr native__this, int indicatorGravity)
		{
			Java.Lang.Object.GetObject<TabLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SetSelectedTabIndicatorGravity(indicatorGravity);
		}

		// Token: 0x06000876 RID: 2166 RVA: 0x00016E58 File Offset: 0x00015058
		[Register("setSelectedTabIndicatorGravity", "(I)V", "GetSetSelectedTabIndicatorGravity_IHandler")]
		public unsafe virtual void SetSelectedTabIndicatorGravity(int indicatorGravity)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(indicatorGravity);
			TabLayout._members.InstanceMethods.InvokeVirtualVoidMethod("setSelectedTabIndicatorGravity.(I)V", this, ptr);
		}

		// Token: 0x06000877 RID: 2167 RVA: 0x00016E93 File Offset: 0x00015093
		private static Delegate GetSetSelectedTabIndicatorHeight_IHandler()
		{
			if (TabLayout.cb_setSelectedTabIndicatorHeight_I == null)
			{
				TabLayout.cb_setSelectedTabIndicatorHeight_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_V(TabLayout.n_SetSelectedTabIndicatorHeight_I));
			}
			return TabLayout.cb_setSelectedTabIndicatorHeight_I;
		}

		// Token: 0x06000878 RID: 2168 RVA: 0x00016EB7 File Offset: 0x000150B7
		private static void n_SetSelectedTabIndicatorHeight_I(IntPtr jnienv, IntPtr native__this, int height)
		{
			Java.Lang.Object.GetObject<TabLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SetSelectedTabIndicatorHeight(height);
		}

		// Token: 0x06000879 RID: 2169 RVA: 0x00016EC8 File Offset: 0x000150C8
		[Register("setSelectedTabIndicatorHeight", "(I)V", "GetSetSelectedTabIndicatorHeight_IHandler")]
		public unsafe virtual void SetSelectedTabIndicatorHeight(int height)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(height);
			TabLayout._members.InstanceMethods.InvokeVirtualVoidMethod("setSelectedTabIndicatorHeight.(I)V", this, ptr);
		}

		// Token: 0x0600087A RID: 2170 RVA: 0x00016F03 File Offset: 0x00015103
		private static Delegate GetSetTabIconTintResource_IHandler()
		{
			if (TabLayout.cb_setTabIconTintResource_I == null)
			{
				TabLayout.cb_setTabIconTintResource_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_V(TabLayout.n_SetTabIconTintResource_I));
			}
			return TabLayout.cb_setTabIconTintResource_I;
		}

		// Token: 0x0600087B RID: 2171 RVA: 0x00016F27 File Offset: 0x00015127
		private static void n_SetTabIconTintResource_I(IntPtr jnienv, IntPtr native__this, int iconTintResourceId)
		{
			Java.Lang.Object.GetObject<TabLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SetTabIconTintResource(iconTintResourceId);
		}

		// Token: 0x0600087C RID: 2172 RVA: 0x00016F38 File Offset: 0x00015138
		[Register("setTabIconTintResource", "(I)V", "GetSetTabIconTintResource_IHandler")]
		public unsafe virtual void SetTabIconTintResource(int iconTintResourceId)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(iconTintResourceId);
			TabLayout._members.InstanceMethods.InvokeVirtualVoidMethod("setTabIconTintResource.(I)V", this, ptr);
		}

		// Token: 0x0600087D RID: 2173 RVA: 0x00016F73 File Offset: 0x00015173
		private static Delegate GetSetTabRippleColorResource_IHandler()
		{
			if (TabLayout.cb_setTabRippleColorResource_I == null)
			{
				TabLayout.cb_setTabRippleColorResource_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_V(TabLayout.n_SetTabRippleColorResource_I));
			}
			return TabLayout.cb_setTabRippleColorResource_I;
		}

		// Token: 0x0600087E RID: 2174 RVA: 0x00016F97 File Offset: 0x00015197
		private static void n_SetTabRippleColorResource_I(IntPtr jnienv, IntPtr native__this, int tabRippleColorResourceId)
		{
			Java.Lang.Object.GetObject<TabLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SetTabRippleColorResource(tabRippleColorResourceId);
		}

		// Token: 0x0600087F RID: 2175 RVA: 0x00016FA8 File Offset: 0x000151A8
		[Register("setTabRippleColorResource", "(I)V", "GetSetTabRippleColorResource_IHandler")]
		public unsafe virtual void SetTabRippleColorResource(int tabRippleColorResourceId)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(tabRippleColorResourceId);
			TabLayout._members.InstanceMethods.InvokeVirtualVoidMethod("setTabRippleColorResource.(I)V", this, ptr);
		}

		// Token: 0x06000880 RID: 2176 RVA: 0x00016FE3 File Offset: 0x000151E3
		private static Delegate GetSetTabTextColors_IIHandler()
		{
			if (TabLayout.cb_setTabTextColors_II == null)
			{
				TabLayout.cb_setTabTextColors_II = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPII_V(TabLayout.n_SetTabTextColors_II));
			}
			return TabLayout.cb_setTabTextColors_II;
		}

		// Token: 0x06000881 RID: 2177 RVA: 0x00017007 File Offset: 0x00015207
		private static void n_SetTabTextColors_II(IntPtr jnienv, IntPtr native__this, int normalColor, int selectedColor)
		{
			Java.Lang.Object.GetObject<TabLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SetTabTextColors(normalColor, selectedColor);
		}

		// Token: 0x06000882 RID: 2178 RVA: 0x00017018 File Offset: 0x00015218
		[Register("setTabTextColors", "(II)V", "GetSetTabTextColors_IIHandler")]
		public unsafe virtual void SetTabTextColors(int normalColor, int selectedColor)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(normalColor);
			ptr[1] = new JniArgumentValue(selectedColor);
			TabLayout._members.InstanceMethods.InvokeVirtualVoidMethod("setTabTextColors.(II)V", this, ptr);
		}

		// Token: 0x06000883 RID: 2179 RVA: 0x00017066 File Offset: 0x00015266
		private static Delegate GetSetTabsFromPagerAdapter_Landroidx_viewpager_widget_PagerAdapter_Handler()
		{
			if (TabLayout.cb_setTabsFromPagerAdapter_Landroidx_viewpager_widget_PagerAdapter_ == null)
			{
				TabLayout.cb_setTabsFromPagerAdapter_Landroidx_viewpager_widget_PagerAdapter_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(TabLayout.n_SetTabsFromPagerAdapter_Landroidx_viewpager_widget_PagerAdapter_));
			}
			return TabLayout.cb_setTabsFromPagerAdapter_Landroidx_viewpager_widget_PagerAdapter_;
		}

		// Token: 0x06000884 RID: 2180 RVA: 0x0001708C File Offset: 0x0001528C
		private static void n_SetTabsFromPagerAdapter_Landroidx_viewpager_widget_PagerAdapter_(IntPtr jnienv, IntPtr native__this, IntPtr native_adapter)
		{
			TabLayout @object = Java.Lang.Object.GetObject<TabLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			PagerAdapter object2 = Java.Lang.Object.GetObject<PagerAdapter>(native_adapter, JniHandleOwnership.DoNotTransfer);
			@object.SetTabsFromPagerAdapter(object2);
		}

		// Token: 0x06000885 RID: 2181 RVA: 0x000170B0 File Offset: 0x000152B0
		[Register("setTabsFromPagerAdapter", "(Landroidx/viewpager/widget/PagerAdapter;)V", "GetSetTabsFromPagerAdapter_Landroidx_viewpager_widget_PagerAdapter_Handler")]
		public unsafe virtual void SetTabsFromPagerAdapter(PagerAdapter adapter)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((adapter == null) ? IntPtr.Zero : adapter.Handle);
				TabLayout._members.InstanceMethods.InvokeVirtualVoidMethod("setTabsFromPagerAdapter.(Landroidx/viewpager/widget/PagerAdapter;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(adapter);
			}
		}

		// Token: 0x06000886 RID: 2182 RVA: 0x00017114 File Offset: 0x00015314
		private static Delegate GetSetUnboundedRipple_ZHandler()
		{
			if (TabLayout.cb_setUnboundedRipple_Z == null)
			{
				TabLayout.cb_setUnboundedRipple_Z = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPZ_V(TabLayout.n_SetUnboundedRipple_Z));
			}
			return TabLayout.cb_setUnboundedRipple_Z;
		}

		// Token: 0x06000887 RID: 2183 RVA: 0x00017138 File Offset: 0x00015338
		private static void n_SetUnboundedRipple_Z(IntPtr jnienv, IntPtr native__this, bool unboundedRipple)
		{
			Java.Lang.Object.GetObject<TabLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SetUnboundedRipple(unboundedRipple);
		}

		// Token: 0x06000888 RID: 2184 RVA: 0x00017148 File Offset: 0x00015348
		[Register("setUnboundedRipple", "(Z)V", "GetSetUnboundedRipple_ZHandler")]
		public unsafe virtual void SetUnboundedRipple(bool unboundedRipple)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(unboundedRipple);
			TabLayout._members.InstanceMethods.InvokeVirtualVoidMethod("setUnboundedRipple.(Z)V", this, ptr);
		}

		// Token: 0x06000889 RID: 2185 RVA: 0x00017183 File Offset: 0x00015383
		private static Delegate GetSetUnboundedRippleResource_IHandler()
		{
			if (TabLayout.cb_setUnboundedRippleResource_I == null)
			{
				TabLayout.cb_setUnboundedRippleResource_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_V(TabLayout.n_SetUnboundedRippleResource_I));
			}
			return TabLayout.cb_setUnboundedRippleResource_I;
		}

		// Token: 0x0600088A RID: 2186 RVA: 0x000171A7 File Offset: 0x000153A7
		private static void n_SetUnboundedRippleResource_I(IntPtr jnienv, IntPtr native__this, int unboundedRippleResourceId)
		{
			Java.Lang.Object.GetObject<TabLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SetUnboundedRippleResource(unboundedRippleResourceId);
		}

		// Token: 0x0600088B RID: 2187 RVA: 0x000171B8 File Offset: 0x000153B8
		[Register("setUnboundedRippleResource", "(I)V", "GetSetUnboundedRippleResource_IHandler")]
		public unsafe virtual void SetUnboundedRippleResource(int unboundedRippleResourceId)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(unboundedRippleResourceId);
			TabLayout._members.InstanceMethods.InvokeVirtualVoidMethod("setUnboundedRippleResource.(I)V", this, ptr);
		}

		// Token: 0x0600088C RID: 2188 RVA: 0x000171F3 File Offset: 0x000153F3
		private static Delegate GetSetupWithViewPager_Landroidx_viewpager_widget_ViewPager_Handler()
		{
			if (TabLayout.cb_setupWithViewPager_Landroidx_viewpager_widget_ViewPager_ == null)
			{
				TabLayout.cb_setupWithViewPager_Landroidx_viewpager_widget_ViewPager_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(TabLayout.n_SetupWithViewPager_Landroidx_viewpager_widget_ViewPager_));
			}
			return TabLayout.cb_setupWithViewPager_Landroidx_viewpager_widget_ViewPager_;
		}

		// Token: 0x0600088D RID: 2189 RVA: 0x00017218 File Offset: 0x00015418
		private static void n_SetupWithViewPager_Landroidx_viewpager_widget_ViewPager_(IntPtr jnienv, IntPtr native__this, IntPtr native_viewPager)
		{
			TabLayout @object = Java.Lang.Object.GetObject<TabLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ViewPager object2 = Java.Lang.Object.GetObject<ViewPager>(native_viewPager, JniHandleOwnership.DoNotTransfer);
			@object.SetupWithViewPager(object2);
		}

		// Token: 0x0600088E RID: 2190 RVA: 0x0001723C File Offset: 0x0001543C
		[Register("setupWithViewPager", "(Landroidx/viewpager/widget/ViewPager;)V", "GetSetupWithViewPager_Landroidx_viewpager_widget_ViewPager_Handler")]
		public unsafe virtual void SetupWithViewPager(ViewPager viewPager)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((viewPager == null) ? IntPtr.Zero : viewPager.Handle);
				TabLayout._members.InstanceMethods.InvokeVirtualVoidMethod("setupWithViewPager.(Landroidx/viewpager/widget/ViewPager;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(viewPager);
			}
		}

		// Token: 0x0600088F RID: 2191 RVA: 0x000172A0 File Offset: 0x000154A0
		private static Delegate GetSetupWithViewPager_Landroidx_viewpager_widget_ViewPager_ZHandler()
		{
			if (TabLayout.cb_setupWithViewPager_Landroidx_viewpager_widget_ViewPager_Z == null)
			{
				TabLayout.cb_setupWithViewPager_Landroidx_viewpager_widget_ViewPager_Z = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLZ_V(TabLayout.n_SetupWithViewPager_Landroidx_viewpager_widget_ViewPager_Z));
			}
			return TabLayout.cb_setupWithViewPager_Landroidx_viewpager_widget_ViewPager_Z;
		}

		// Token: 0x06000890 RID: 2192 RVA: 0x000172C4 File Offset: 0x000154C4
		private static void n_SetupWithViewPager_Landroidx_viewpager_widget_ViewPager_Z(IntPtr jnienv, IntPtr native__this, IntPtr native_viewPager, bool autoRefresh)
		{
			TabLayout @object = Java.Lang.Object.GetObject<TabLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ViewPager object2 = Java.Lang.Object.GetObject<ViewPager>(native_viewPager, JniHandleOwnership.DoNotTransfer);
			@object.SetupWithViewPager(object2, autoRefresh);
		}

		// Token: 0x06000891 RID: 2193 RVA: 0x000172E8 File Offset: 0x000154E8
		[Register("setupWithViewPager", "(Landroidx/viewpager/widget/ViewPager;Z)V", "GetSetupWithViewPager_Landroidx_viewpager_widget_ViewPager_ZHandler")]
		public unsafe virtual void SetupWithViewPager(ViewPager viewPager, bool autoRefresh)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((viewPager == null) ? IntPtr.Zero : viewPager.Handle);
				ptr[1] = new JniArgumentValue(autoRefresh);
				TabLayout._members.InstanceMethods.InvokeVirtualVoidMethod("setupWithViewPager.(Landroidx/viewpager/widget/ViewPager;Z)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(viewPager);
			}
		}

		// Token: 0x14000005 RID: 5
		// (add) Token: 0x06000892 RID: 2194 RVA: 0x00017360 File Offset: 0x00015560
		// (remove) Token: 0x06000893 RID: 2195 RVA: 0x000173AC File Offset: 0x000155AC
		public event EventHandler<TabLayout.TabReselectedEventArgs> TabReselected
		{
			add
			{
				EventHelper.AddEventHandler<TabLayout.IOnTabSelectedListener, TabLayout.IOnTabSelectedListenerImplementor>(ref this.weak_implementor_AddOnTabSelectedListener, new Func<TabLayout.IOnTabSelectedListenerImplementor>(this.__CreateIOnTabSelectedListenerImplementor), new Action<TabLayout.IOnTabSelectedListener>(this.AddOnTabSelectedListener), delegate(TabLayout.IOnTabSelectedListenerImplementor __h)
				{
					__h.OnTabReselectedHandler = (EventHandler<TabLayout.TabReselectedEventArgs>)Delegate.Combine(__h.OnTabReselectedHandler, value);
				});
			}
			remove
			{
				Func<TabLayout.IOnTabSelectedListenerImplementor, bool> empty;
				if ((empty = TabLayout.<>O.<0>____IsEmpty) == null)
				{
					empty = (TabLayout.<>O.<0>____IsEmpty = new Func<TabLayout.IOnTabSelectedListenerImplementor, bool>(TabLayout.IOnTabSelectedListenerImplementor.__IsEmpty));
				}
				EventHelper.RemoveEventHandler<TabLayout.IOnTabSelectedListener, TabLayout.IOnTabSelectedListenerImplementor>(ref this.weak_implementor_AddOnTabSelectedListener, empty, delegate(TabLayout.IOnTabSelectedListener __v)
				{
					this.RemoveOnTabSelectedListener(__v);
				}, delegate(TabLayout.IOnTabSelectedListenerImplementor __h)
				{
					__h.OnTabReselectedHandler = (EventHandler<TabLayout.TabReselectedEventArgs>)Delegate.Remove(__h.OnTabReselectedHandler, value);
				});
			}
		}

		// Token: 0x14000006 RID: 6
		// (add) Token: 0x06000894 RID: 2196 RVA: 0x0001740C File Offset: 0x0001560C
		// (remove) Token: 0x06000895 RID: 2197 RVA: 0x00017458 File Offset: 0x00015658
		public event EventHandler<TabLayout.TabSelectedEventArgs> TabSelected
		{
			add
			{
				EventHelper.AddEventHandler<TabLayout.IOnTabSelectedListener, TabLayout.IOnTabSelectedListenerImplementor>(ref this.weak_implementor_AddOnTabSelectedListener, new Func<TabLayout.IOnTabSelectedListenerImplementor>(this.__CreateIOnTabSelectedListenerImplementor), new Action<TabLayout.IOnTabSelectedListener>(this.AddOnTabSelectedListener), delegate(TabLayout.IOnTabSelectedListenerImplementor __h)
				{
					__h.OnTabSelectedHandler = (EventHandler<TabLayout.TabSelectedEventArgs>)Delegate.Combine(__h.OnTabSelectedHandler, value);
				});
			}
			remove
			{
				Func<TabLayout.IOnTabSelectedListenerImplementor, bool> empty;
				if ((empty = TabLayout.<>O.<0>____IsEmpty) == null)
				{
					empty = (TabLayout.<>O.<0>____IsEmpty = new Func<TabLayout.IOnTabSelectedListenerImplementor, bool>(TabLayout.IOnTabSelectedListenerImplementor.__IsEmpty));
				}
				EventHelper.RemoveEventHandler<TabLayout.IOnTabSelectedListener, TabLayout.IOnTabSelectedListenerImplementor>(ref this.weak_implementor_AddOnTabSelectedListener, empty, delegate(TabLayout.IOnTabSelectedListener __v)
				{
					this.RemoveOnTabSelectedListener(__v);
				}, delegate(TabLayout.IOnTabSelectedListenerImplementor __h)
				{
					__h.OnTabSelectedHandler = (EventHandler<TabLayout.TabSelectedEventArgs>)Delegate.Remove(__h.OnTabSelectedHandler, value);
				});
			}
		}

		// Token: 0x14000007 RID: 7
		// (add) Token: 0x06000896 RID: 2198 RVA: 0x000174B8 File Offset: 0x000156B8
		// (remove) Token: 0x06000897 RID: 2199 RVA: 0x00017504 File Offset: 0x00015704
		public event EventHandler<TabLayout.TabUnselectedEventArgs> TabUnselected
		{
			add
			{
				EventHelper.AddEventHandler<TabLayout.IOnTabSelectedListener, TabLayout.IOnTabSelectedListenerImplementor>(ref this.weak_implementor_AddOnTabSelectedListener, new Func<TabLayout.IOnTabSelectedListenerImplementor>(this.__CreateIOnTabSelectedListenerImplementor), new Action<TabLayout.IOnTabSelectedListener>(this.AddOnTabSelectedListener), delegate(TabLayout.IOnTabSelectedListenerImplementor __h)
				{
					__h.OnTabUnselectedHandler = (EventHandler<TabLayout.TabUnselectedEventArgs>)Delegate.Combine(__h.OnTabUnselectedHandler, value);
				});
			}
			remove
			{
				Func<TabLayout.IOnTabSelectedListenerImplementor, bool> empty;
				if ((empty = TabLayout.<>O.<0>____IsEmpty) == null)
				{
					empty = (TabLayout.<>O.<0>____IsEmpty = new Func<TabLayout.IOnTabSelectedListenerImplementor, bool>(TabLayout.IOnTabSelectedListenerImplementor.__IsEmpty));
				}
				EventHelper.RemoveEventHandler<TabLayout.IOnTabSelectedListener, TabLayout.IOnTabSelectedListenerImplementor>(ref this.weak_implementor_AddOnTabSelectedListener, empty, delegate(TabLayout.IOnTabSelectedListener __v)
				{
					this.RemoveOnTabSelectedListener(__v);
				}, delegate(TabLayout.IOnTabSelectedListenerImplementor __h)
				{
					__h.OnTabUnselectedHandler = (EventHandler<TabLayout.TabUnselectedEventArgs>)Delegate.Remove(__h.OnTabUnselectedHandler, value);
				});
			}
		}

		// Token: 0x06000898 RID: 2200 RVA: 0x00017563 File Offset: 0x00015763
		private TabLayout.IOnTabSelectedListenerImplementor __CreateIOnTabSelectedListenerImplementor()
		{
			return new TabLayout.IOnTabSelectedListenerImplementor(this);
		}

		// Token: 0x04000237 RID: 567
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/google/android/material/tabs/TabLayout", typeof(TabLayout));

		// Token: 0x04000238 RID: 568
		private static Delegate cb_hasUnboundedRipple;

		// Token: 0x04000239 RID: 569
		private static Delegate cb_isInlineLabel;

		// Token: 0x0400023A RID: 570
		private static Delegate cb_setInlineLabel_Z;

		// Token: 0x0400023B RID: 571
		private static Delegate cb_getSelectedTabPosition;

		// Token: 0x0400023C RID: 572
		private static Delegate cb_getTabCount;

		// Token: 0x0400023D RID: 573
		private static Delegate cb_getTabGravity;

		// Token: 0x0400023E RID: 574
		private static Delegate cb_setTabGravity_I;

		// Token: 0x0400023F RID: 575
		private static Delegate cb_getTabIconTint;

		// Token: 0x04000240 RID: 576
		private static Delegate cb_setTabIconTint_Landroid_content_res_ColorStateList_;

		// Token: 0x04000241 RID: 577
		private static Delegate cb_getTabIndicatorAnimationMode;

		// Token: 0x04000242 RID: 578
		private static Delegate cb_setTabIndicatorAnimationMode_I;

		// Token: 0x04000243 RID: 579
		private static Delegate cb_isTabIndicatorFullWidth;

		// Token: 0x04000244 RID: 580
		private static Delegate cb_setTabIndicatorFullWidth_Z;

		// Token: 0x04000245 RID: 581
		private static Delegate cb_getTabIndicatorGravity;

		// Token: 0x04000246 RID: 582
		private static Delegate cb_getTabMode;

		// Token: 0x04000247 RID: 583
		private static Delegate cb_setTabMode_I;

		// Token: 0x04000248 RID: 584
		private static Delegate cb_getTabRippleColor;

		// Token: 0x04000249 RID: 585
		private static Delegate cb_setTabRippleColor_Landroid_content_res_ColorStateList_;

		// Token: 0x0400024A RID: 586
		private static Delegate cb_getTabSelectedIndicator;

		// Token: 0x0400024B RID: 587
		private static Delegate cb_getTabTextColors;

		// Token: 0x0400024C RID: 588
		private static Delegate cb_setTabTextColors_Landroid_content_res_ColorStateList_;

		// Token: 0x0400024D RID: 589
		private static Delegate cb_addOnTabSelectedListener_Lcom_google_android_material_tabs_TabLayout_BaseOnTabSelectedListener_;

		// Token: 0x0400024E RID: 590
		private static Delegate cb_addOnTabSelectedListener_Lcom_google_android_material_tabs_TabLayout_OnTabSelectedListener_;

		// Token: 0x0400024F RID: 591
		private static Delegate cb_addTab_Lcom_google_android_material_tabs_TabLayout_Tab_;

		// Token: 0x04000250 RID: 592
		private static Delegate cb_addTab_Lcom_google_android_material_tabs_TabLayout_Tab_Z;

		// Token: 0x04000251 RID: 593
		private static Delegate cb_addTab_Lcom_google_android_material_tabs_TabLayout_Tab_I;

		// Token: 0x04000252 RID: 594
		private static Delegate cb_addTab_Lcom_google_android_material_tabs_TabLayout_Tab_IZ;

		// Token: 0x04000253 RID: 595
		private static Delegate cb_clearOnTabSelectedListeners;

		// Token: 0x04000254 RID: 596
		private static Delegate cb_createTabFromPool;

		// Token: 0x04000255 RID: 597
		private static Delegate cb_getTabAt_I;

		// Token: 0x04000256 RID: 598
		private static Delegate cb_newTab;

		// Token: 0x04000257 RID: 599
		private static Delegate cb_releaseFromTabPool_Lcom_google_android_material_tabs_TabLayout_Tab_;

		// Token: 0x04000258 RID: 600
		private static Delegate cb_removeAllTabs;

		// Token: 0x04000259 RID: 601
		private static Delegate cb_removeOnTabSelectedListener_Lcom_google_android_material_tabs_TabLayout_BaseOnTabSelectedListener_;

		// Token: 0x0400025A RID: 602
		private static Delegate cb_removeOnTabSelectedListener_Lcom_google_android_material_tabs_TabLayout_OnTabSelectedListener_;

		// Token: 0x0400025B RID: 603
		private static Delegate cb_removeTab_Lcom_google_android_material_tabs_TabLayout_Tab_;

		// Token: 0x0400025C RID: 604
		private static Delegate cb_removeTabAt_I;

		// Token: 0x0400025D RID: 605
		private static Delegate cb_selectTab_Lcom_google_android_material_tabs_TabLayout_Tab_;

		// Token: 0x0400025E RID: 606
		private static Delegate cb_selectTab_Lcom_google_android_material_tabs_TabLayout_Tab_Z;

		// Token: 0x0400025F RID: 607
		private static Delegate cb_setInlineLabelResource_I;

		// Token: 0x04000260 RID: 608
		private static Delegate cb_setOnTabSelectedListener_Lcom_google_android_material_tabs_TabLayout_BaseOnTabSelectedListener_;

		// Token: 0x04000261 RID: 609
		private static Delegate cb_setOnTabSelectedListener_Lcom_google_android_material_tabs_TabLayout_OnTabSelectedListener_;

		// Token: 0x04000262 RID: 610
		private static Delegate cb_setScrollPosition_IFZ;

		// Token: 0x04000263 RID: 611
		private static Delegate cb_setScrollPosition_IFZZ;

		// Token: 0x04000264 RID: 612
		private static Delegate cb_setSelectedTabIndicator_Landroid_graphics_drawable_Drawable_;

		// Token: 0x04000265 RID: 613
		private static Delegate cb_setSelectedTabIndicator_I;

		// Token: 0x04000266 RID: 614
		private static Delegate cb_setSelectedTabIndicatorColor_I;

		// Token: 0x04000267 RID: 615
		private static Delegate cb_setSelectedTabIndicatorGravity_I;

		// Token: 0x04000268 RID: 616
		private static Delegate cb_setSelectedTabIndicatorHeight_I;

		// Token: 0x04000269 RID: 617
		private static Delegate cb_setTabIconTintResource_I;

		// Token: 0x0400026A RID: 618
		private static Delegate cb_setTabRippleColorResource_I;

		// Token: 0x0400026B RID: 619
		private static Delegate cb_setTabTextColors_II;

		// Token: 0x0400026C RID: 620
		private static Delegate cb_setTabsFromPagerAdapter_Landroidx_viewpager_widget_PagerAdapter_;

		// Token: 0x0400026D RID: 621
		private static Delegate cb_setUnboundedRipple_Z;

		// Token: 0x0400026E RID: 622
		private static Delegate cb_setUnboundedRippleResource_I;

		// Token: 0x0400026F RID: 623
		private static Delegate cb_setupWithViewPager_Landroidx_viewpager_widget_ViewPager_;

		// Token: 0x04000270 RID: 624
		private static Delegate cb_setupWithViewPager_Landroidx_viewpager_widget_ViewPager_Z;

		// Token: 0x04000271 RID: 625
		private WeakReference weak_implementor_AddOnTabSelectedListener;

		// Token: 0x02000078 RID: 120
		[Register("com/google/android/material/tabs/TabLayout$TabView", DoNotGenerateAcw = true)]
		public sealed class TabView : LinearLayout
		{
			// Token: 0x1700014F RID: 335
			// (get) Token: 0x0600089A RID: 2202 RVA: 0x00017586 File Offset: 0x00015786
			// (set) Token: 0x0600089B RID: 2203 RVA: 0x0001758E File Offset: 0x0001578E
			public override bool Selected
			{
				get
				{
					return base.Selected;
				}
				set
				{
					base.Selected = value;
				}
			}

			// Token: 0x0600089C RID: 2204 RVA: 0x00017597 File Offset: 0x00015797
			public void SetSelected(bool selected)
			{
				this.Selected = selected;
			}

			// Token: 0x17000150 RID: 336
			// (get) Token: 0x0600089D RID: 2205 RVA: 0x000175A0 File Offset: 0x000157A0
			internal static IntPtr class_ref
			{
				get
				{
					return TabLayout.TabView._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x17000151 RID: 337
			// (get) Token: 0x0600089E RID: 2206 RVA: 0x000175C4 File Offset: 0x000157C4
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return TabLayout.TabView._members;
				}
			}

			// Token: 0x17000152 RID: 338
			// (get) Token: 0x0600089F RID: 2207 RVA: 0x000175CC File Offset: 0x000157CC
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return TabLayout.TabView._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x17000153 RID: 339
			// (get) Token: 0x060008A0 RID: 2208 RVA: 0x000175F0 File Offset: 0x000157F0
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return TabLayout.TabView._members.ManagedPeerType;
				}
			}

			// Token: 0x060008A1 RID: 2209 RVA: 0x000086B0 File Offset: 0x000068B0
			internal TabView(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
			{
			}

			// Token: 0x060008A2 RID: 2210 RVA: 0x000175FC File Offset: 0x000157FC
			[Register(".ctor", "(Lcom/google/android/material/tabs/TabLayout;Landroid/content/Context;)V", "")]
			public unsafe TabView(TabLayout __self, Context context) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				string constructorSignature = "(L" + JNIEnv.GetJniName(base.GetType().DeclaringType) + ";Landroid/content/Context;)V";
				if (base.Handle != IntPtr.Zero)
				{
					return;
				}
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((__self == null) ? IntPtr.Zero : __self.Handle);
					ptr[1] = new JniArgumentValue((context == null) ? IntPtr.Zero : context.Handle);
					base.SetHandle(TabLayout.TabView._members.InstanceMethods.StartCreateInstance(constructorSignature, base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
					TabLayout.TabView._members.InstanceMethods.FinishCreateInstance(constructorSignature, this, ptr);
				}
				finally
				{
					GC.KeepAlive(__self);
					GC.KeepAlive(context);
				}
			}

			// Token: 0x17000154 RID: 340
			// (get) Token: 0x060008A3 RID: 2211 RVA: 0x000176EC File Offset: 0x000158EC
			public TabLayout.Tab Tab
			{
				[Register("getTab", "()Lcom/google/android/material/tabs/TabLayout$Tab;", "")]
				get
				{
					return Java.Lang.Object.GetObject<TabLayout.Tab>(TabLayout.TabView._members.InstanceMethods.InvokeAbstractObjectMethod("getTab.()Lcom/google/android/material/tabs/TabLayout$Tab;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
				}
			}

			// Token: 0x060008A4 RID: 2212 RVA: 0x00017720 File Offset: 0x00015920
			[Register("onMeasure", "(II)V", "")]
			public new unsafe void OnMeasure(int origWidthMeasureSpec, int origHeightMeasureSpec)
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(origWidthMeasureSpec);
				ptr[1] = new JniArgumentValue(origHeightMeasureSpec);
				TabLayout.TabView._members.InstanceMethods.InvokeAbstractVoidMethod("onMeasure.(II)V", this, ptr);
			}

			// Token: 0x04000272 RID: 626
			private static readonly JniPeerMembers _members = new XAPeerMembers("com/google/android/material/tabs/TabLayout$TabView", typeof(TabLayout.TabView));
		}

		// Token: 0x02000079 RID: 121
		[Register("com/google/android/material/tabs/TabLayout$BaseOnTabSelectedListener", "", "Google.Android.Material.Tabs.TabLayout/IOnTabSelectedListenerInvoker")]
		[JavaTypeParameters(new string[]
		{
			"T extends com.google.android.material.tabs.TabLayout.Tab"
		})]
		public interface IOnTabSelectedListener : IJavaObject, IDisposable, IJavaPeerable
		{
			// Token: 0x060008A6 RID: 2214
			[Register("onTabReselected", "(Lcom/google/android/material/tabs/TabLayout$Tab;)V", "GetOnTabReselected_Lcom_google_android_material_tabs_TabLayout_Tab_Handler:Google.Android.Material.Tabs.TabLayout/IOnTabSelectedListenerInvoker, Xamarin.Google.Android.Material")]
			void OnTabReselected(TabLayout.Tab tab);

			// Token: 0x060008A7 RID: 2215
			[Register("onTabSelected", "(Lcom/google/android/material/tabs/TabLayout$Tab;)V", "GetOnTabSelected_Lcom_google_android_material_tabs_TabLayout_Tab_Handler:Google.Android.Material.Tabs.TabLayout/IOnTabSelectedListenerInvoker, Xamarin.Google.Android.Material")]
			void OnTabSelected(TabLayout.Tab tab);

			// Token: 0x060008A8 RID: 2216
			[Register("onTabUnselected", "(Lcom/google/android/material/tabs/TabLayout$Tab;)V", "GetOnTabUnselected_Lcom_google_android_material_tabs_TabLayout_Tab_Handler:Google.Android.Material.Tabs.TabLayout/IOnTabSelectedListenerInvoker, Xamarin.Google.Android.Material")]
			void OnTabUnselected(TabLayout.Tab tab);
		}

		// Token: 0x0200007A RID: 122
		[Register("com/google/android/material/tabs/TabLayout$BaseOnTabSelectedListener", DoNotGenerateAcw = true)]
		internal class IOnTabSelectedListenerInvoker : Java.Lang.Object, TabLayout.IOnTabSelectedListener, IJavaObject, IDisposable, IJavaPeerable
		{
			// Token: 0x17000155 RID: 341
			// (get) Token: 0x060008A9 RID: 2217 RVA: 0x0001778C File Offset: 0x0001598C
			private static IntPtr java_class_ref
			{
				get
				{
					return TabLayout.IOnTabSelectedListenerInvoker._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x17000156 RID: 342
			// (get) Token: 0x060008AA RID: 2218 RVA: 0x000177B0 File Offset: 0x000159B0
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return TabLayout.IOnTabSelectedListenerInvoker._members;
				}
			}

			// Token: 0x17000157 RID: 343
			// (get) Token: 0x060008AB RID: 2219 RVA: 0x000177B7 File Offset: 0x000159B7
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return this.class_ref;
				}
			}

			// Token: 0x17000158 RID: 344
			// (get) Token: 0x060008AC RID: 2220 RVA: 0x000177BF File Offset: 0x000159BF
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return TabLayout.IOnTabSelectedListenerInvoker._members.ManagedPeerType;
				}
			}

			// Token: 0x060008AD RID: 2221 RVA: 0x000177CB File Offset: 0x000159CB
			public static TabLayout.IOnTabSelectedListener GetObject(IntPtr handle, JniHandleOwnership transfer)
			{
				return Java.Lang.Object.GetObject<TabLayout.IOnTabSelectedListener>(handle, transfer);
			}

			// Token: 0x060008AE RID: 2222 RVA: 0x000177D4 File Offset: 0x000159D4
			private static IntPtr Validate(IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf(handle, TabLayout.IOnTabSelectedListenerInvoker.java_class_ref))
				{
					throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'com.google.android.material.tabs.TabLayout.BaseOnTabSelectedListener'.");
				}
				return handle;
			}

			// Token: 0x060008AF RID: 2223 RVA: 0x000177FF File Offset: 0x000159FF
			protected override void Dispose(bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
				{
					JNIEnv.DeleteGlobalRef(this.class_ref);
				}
				this.class_ref = IntPtr.Zero;
				base.Dispose(disposing);
			}

			// Token: 0x060008B0 RID: 2224 RVA: 0x00017830 File Offset: 0x00015A30
			public IOnTabSelectedListenerInvoker(IntPtr handle, JniHandleOwnership transfer) : base(TabLayout.IOnTabSelectedListenerInvoker.Validate(handle), transfer)
			{
				IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
				this.class_ref = JNIEnv.NewGlobalRef(objectClass);
				JNIEnv.DeleteLocalRef(objectClass);
			}

			// Token: 0x060008B1 RID: 2225 RVA: 0x00017868 File Offset: 0x00015A68
			private static Delegate GetOnTabReselected_Lcom_google_android_material_tabs_TabLayout_Tab_Handler()
			{
				if (TabLayout.IOnTabSelectedListenerInvoker.cb_onTabReselected_Lcom_google_android_material_tabs_TabLayout_Tab_ == null)
				{
					TabLayout.IOnTabSelectedListenerInvoker.cb_onTabReselected_Lcom_google_android_material_tabs_TabLayout_Tab_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(TabLayout.IOnTabSelectedListenerInvoker.n_OnTabReselected_Lcom_google_android_material_tabs_TabLayout_Tab_));
				}
				return TabLayout.IOnTabSelectedListenerInvoker.cb_onTabReselected_Lcom_google_android_material_tabs_TabLayout_Tab_;
			}

			// Token: 0x060008B2 RID: 2226 RVA: 0x0001788C File Offset: 0x00015A8C
			private static void n_OnTabReselected_Lcom_google_android_material_tabs_TabLayout_Tab_(IntPtr jnienv, IntPtr native__this, IntPtr native_tab)
			{
				TabLayout.IOnTabSelectedListener @object = Java.Lang.Object.GetObject<TabLayout.IOnTabSelectedListener>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				TabLayout.Tab object2 = Java.Lang.Object.GetObject<TabLayout.Tab>(native_tab, JniHandleOwnership.DoNotTransfer);
				@object.OnTabReselected(object2);
			}

			// Token: 0x060008B3 RID: 2227 RVA: 0x000178B0 File Offset: 0x00015AB0
			public unsafe void OnTabReselected(TabLayout.Tab tab)
			{
				if (this.id_onTabReselected_Lcom_google_android_material_tabs_TabLayout_Tab_ == IntPtr.Zero)
				{
					this.id_onTabReselected_Lcom_google_android_material_tabs_TabLayout_Tab_ = JNIEnv.GetMethodID(this.class_ref, "onTabReselected", "(Lcom/google/android/material/tabs/TabLayout$Tab;)V");
				}
				JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
				*ptr = new JValue((tab == null) ? IntPtr.Zero : tab.Handle);
				JNIEnv.CallVoidMethod(base.Handle, this.id_onTabReselected_Lcom_google_android_material_tabs_TabLayout_Tab_, ptr);
			}

			// Token: 0x060008B4 RID: 2228 RVA: 0x00017923 File Offset: 0x00015B23
			private static Delegate GetOnTabSelected_Lcom_google_android_material_tabs_TabLayout_Tab_Handler()
			{
				if (TabLayout.IOnTabSelectedListenerInvoker.cb_onTabSelected_Lcom_google_android_material_tabs_TabLayout_Tab_ == null)
				{
					TabLayout.IOnTabSelectedListenerInvoker.cb_onTabSelected_Lcom_google_android_material_tabs_TabLayout_Tab_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(TabLayout.IOnTabSelectedListenerInvoker.n_OnTabSelected_Lcom_google_android_material_tabs_TabLayout_Tab_));
				}
				return TabLayout.IOnTabSelectedListenerInvoker.cb_onTabSelected_Lcom_google_android_material_tabs_TabLayout_Tab_;
			}

			// Token: 0x060008B5 RID: 2229 RVA: 0x00017948 File Offset: 0x00015B48
			private static void n_OnTabSelected_Lcom_google_android_material_tabs_TabLayout_Tab_(IntPtr jnienv, IntPtr native__this, IntPtr native_tab)
			{
				TabLayout.IOnTabSelectedListener @object = Java.Lang.Object.GetObject<TabLayout.IOnTabSelectedListener>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				TabLayout.Tab object2 = Java.Lang.Object.GetObject<TabLayout.Tab>(native_tab, JniHandleOwnership.DoNotTransfer);
				@object.OnTabSelected(object2);
			}

			// Token: 0x060008B6 RID: 2230 RVA: 0x0001796C File Offset: 0x00015B6C
			public unsafe void OnTabSelected(TabLayout.Tab tab)
			{
				if (this.id_onTabSelected_Lcom_google_android_material_tabs_TabLayout_Tab_ == IntPtr.Zero)
				{
					this.id_onTabSelected_Lcom_google_android_material_tabs_TabLayout_Tab_ = JNIEnv.GetMethodID(this.class_ref, "onTabSelected", "(Lcom/google/android/material/tabs/TabLayout$Tab;)V");
				}
				JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
				*ptr = new JValue((tab == null) ? IntPtr.Zero : tab.Handle);
				JNIEnv.CallVoidMethod(base.Handle, this.id_onTabSelected_Lcom_google_android_material_tabs_TabLayout_Tab_, ptr);
			}

			// Token: 0x060008B7 RID: 2231 RVA: 0x000179DF File Offset: 0x00015BDF
			private static Delegate GetOnTabUnselected_Lcom_google_android_material_tabs_TabLayout_Tab_Handler()
			{
				if (TabLayout.IOnTabSelectedListenerInvoker.cb_onTabUnselected_Lcom_google_android_material_tabs_TabLayout_Tab_ == null)
				{
					TabLayout.IOnTabSelectedListenerInvoker.cb_onTabUnselected_Lcom_google_android_material_tabs_TabLayout_Tab_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(TabLayout.IOnTabSelectedListenerInvoker.n_OnTabUnselected_Lcom_google_android_material_tabs_TabLayout_Tab_));
				}
				return TabLayout.IOnTabSelectedListenerInvoker.cb_onTabUnselected_Lcom_google_android_material_tabs_TabLayout_Tab_;
			}

			// Token: 0x060008B8 RID: 2232 RVA: 0x00017A04 File Offset: 0x00015C04
			private static void n_OnTabUnselected_Lcom_google_android_material_tabs_TabLayout_Tab_(IntPtr jnienv, IntPtr native__this, IntPtr native_tab)
			{
				TabLayout.IOnTabSelectedListener @object = Java.Lang.Object.GetObject<TabLayout.IOnTabSelectedListener>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				TabLayout.Tab object2 = Java.Lang.Object.GetObject<TabLayout.Tab>(native_tab, JniHandleOwnership.DoNotTransfer);
				@object.OnTabUnselected(object2);
			}

			// Token: 0x060008B9 RID: 2233 RVA: 0x00017A28 File Offset: 0x00015C28
			public unsafe void OnTabUnselected(TabLayout.Tab tab)
			{
				if (this.id_onTabUnselected_Lcom_google_android_material_tabs_TabLayout_Tab_ == IntPtr.Zero)
				{
					this.id_onTabUnselected_Lcom_google_android_material_tabs_TabLayout_Tab_ = JNIEnv.GetMethodID(this.class_ref, "onTabUnselected", "(Lcom/google/android/material/tabs/TabLayout$Tab;)V");
				}
				JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
				*ptr = new JValue((tab == null) ? IntPtr.Zero : tab.Handle);
				JNIEnv.CallVoidMethod(base.Handle, this.id_onTabUnselected_Lcom_google_android_material_tabs_TabLayout_Tab_, ptr);
			}

			// Token: 0x04000273 RID: 627
			private static readonly JniPeerMembers _members = new XAPeerMembers("com/google/android/material/tabs/TabLayout$BaseOnTabSelectedListener", typeof(TabLayout.IOnTabSelectedListenerInvoker));

			// Token: 0x04000274 RID: 628
			private IntPtr class_ref;

			// Token: 0x04000275 RID: 629
			private static Delegate cb_onTabReselected_Lcom_google_android_material_tabs_TabLayout_Tab_;

			// Token: 0x04000276 RID: 630
			private IntPtr id_onTabReselected_Lcom_google_android_material_tabs_TabLayout_Tab_;

			// Token: 0x04000277 RID: 631
			private static Delegate cb_onTabSelected_Lcom_google_android_material_tabs_TabLayout_Tab_;

			// Token: 0x04000278 RID: 632
			private IntPtr id_onTabSelected_Lcom_google_android_material_tabs_TabLayout_Tab_;

			// Token: 0x04000279 RID: 633
			private static Delegate cb_onTabUnselected_Lcom_google_android_material_tabs_TabLayout_Tab_;

			// Token: 0x0400027A RID: 634
			private IntPtr id_onTabUnselected_Lcom_google_android_material_tabs_TabLayout_Tab_;
		}

		// Token: 0x0200007B RID: 123
		public class TabReselectedEventArgs : EventArgs
		{
			// Token: 0x060008BB RID: 2235 RVA: 0x00017AB6 File Offset: 0x00015CB6
			public TabReselectedEventArgs(TabLayout.Tab tab)
			{
				this.tab = tab;
			}

			// Token: 0x0400027B RID: 635
			private TabLayout.Tab tab;
		}

		// Token: 0x0200007C RID: 124
		public class TabSelectedEventArgs : EventArgs
		{
			// Token: 0x060008BC RID: 2236 RVA: 0x00017AC5 File Offset: 0x00015CC5
			public TabSelectedEventArgs(TabLayout.Tab tab)
			{
				this.tab = tab;
			}

			// Token: 0x17000159 RID: 345
			// (get) Token: 0x060008BD RID: 2237 RVA: 0x00017AD4 File Offset: 0x00015CD4
			public TabLayout.Tab Tab
			{
				get
				{
					return this.tab;
				}
			}

			// Token: 0x0400027C RID: 636
			private TabLayout.Tab tab;
		}

		// Token: 0x0200007D RID: 125
		public class TabUnselectedEventArgs : EventArgs
		{
			// Token: 0x060008BE RID: 2238 RVA: 0x00017ADC File Offset: 0x00015CDC
			public TabUnselectedEventArgs(TabLayout.Tab tab)
			{
				this.tab = tab;
			}

			// Token: 0x0400027D RID: 637
			private TabLayout.Tab tab;
		}

		// Token: 0x0200007E RID: 126
		[Register("mono/com/google/android/material/tabs/TabLayout_BaseOnTabSelectedListenerImplementor")]
		internal sealed class IOnTabSelectedListenerImplementor : Java.Lang.Object, TabLayout.IOnTabSelectedListener, IJavaObject, IDisposable, IJavaPeerable
		{
			// Token: 0x060008BF RID: 2239 RVA: 0x00017AEB File Offset: 0x00015CEB
			public IOnTabSelectedListenerImplementor(object sender) : base(JNIEnv.StartCreateInstance("mono/com/google/android/material/tabs/TabLayout_BaseOnTabSelectedListenerImplementor", "()V", Array.Empty<JValue>()), JniHandleOwnership.TransferLocalRef)
			{
				JNIEnv.FinishCreateInstance(base.Handle, "()V", Array.Empty<JValue>());
				this.sender = sender;
			}

			// Token: 0x060008C0 RID: 2240 RVA: 0x00017B24 File Offset: 0x00015D24
			public void OnTabReselected(TabLayout.Tab tab)
			{
				EventHandler<TabLayout.TabReselectedEventArgs> onTabReselectedHandler = this.OnTabReselectedHandler;
				if (onTabReselectedHandler != null)
				{
					onTabReselectedHandler(this.sender, new TabLayout.TabReselectedEventArgs(tab));
				}
			}

			// Token: 0x060008C1 RID: 2241 RVA: 0x00017B50 File Offset: 0x00015D50
			public void OnTabSelected(TabLayout.Tab tab)
			{
				EventHandler<TabLayout.TabSelectedEventArgs> onTabSelectedHandler = this.OnTabSelectedHandler;
				if (onTabSelectedHandler != null)
				{
					onTabSelectedHandler(this.sender, new TabLayout.TabSelectedEventArgs(tab));
				}
			}

			// Token: 0x060008C2 RID: 2242 RVA: 0x00017B7C File Offset: 0x00015D7C
			public void OnTabUnselected(TabLayout.Tab tab)
			{
				EventHandler<TabLayout.TabUnselectedEventArgs> onTabUnselectedHandler = this.OnTabUnselectedHandler;
				if (onTabUnselectedHandler != null)
				{
					onTabUnselectedHandler(this.sender, new TabLayout.TabUnselectedEventArgs(tab));
				}
			}

			// Token: 0x060008C3 RID: 2243 RVA: 0x00017BA5 File Offset: 0x00015DA5
			internal static bool __IsEmpty(TabLayout.IOnTabSelectedListenerImplementor value)
			{
				return value.OnTabReselectedHandler == null && value.OnTabSelectedHandler == null && value.OnTabUnselectedHandler == null;
			}

			// Token: 0x0400027E RID: 638
			private object sender;

			// Token: 0x0400027F RID: 639
			public EventHandler<TabLayout.TabReselectedEventArgs> OnTabReselectedHandler;

			// Token: 0x04000280 RID: 640
			public EventHandler<TabLayout.TabSelectedEventArgs> OnTabSelectedHandler;

			// Token: 0x04000281 RID: 641
			public EventHandler<TabLayout.TabUnselectedEventArgs> OnTabUnselectedHandler;
		}

		// Token: 0x0200007F RID: 127
		[Register("com/google/android/material/tabs/TabLayout$OnTabSelectedListener", "", "Google.Android.Material.Tabs.TabLayout/IOnTabSelectedListener2Invoker")]
		public interface IOnTabSelectedListener2 : TabLayout.IOnTabSelectedListener, IJavaObject, IDisposable, IJavaPeerable
		{
		}

		// Token: 0x02000080 RID: 128
		[Register("com/google/android/material/tabs/TabLayout$OnTabSelectedListener", DoNotGenerateAcw = true)]
		internal class IOnTabSelectedListener2Invoker : Java.Lang.Object, TabLayout.IOnTabSelectedListener2, TabLayout.IOnTabSelectedListener, IJavaObject, IDisposable, IJavaPeerable
		{
			// Token: 0x1700015A RID: 346
			// (get) Token: 0x060008C4 RID: 2244 RVA: 0x00017BC4 File Offset: 0x00015DC4
			private static IntPtr java_class_ref
			{
				get
				{
					return TabLayout.IOnTabSelectedListener2Invoker._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x1700015B RID: 347
			// (get) Token: 0x060008C5 RID: 2245 RVA: 0x00017BE8 File Offset: 0x00015DE8
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return TabLayout.IOnTabSelectedListener2Invoker._members;
				}
			}

			// Token: 0x1700015C RID: 348
			// (get) Token: 0x060008C6 RID: 2246 RVA: 0x00017BEF File Offset: 0x00015DEF
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return this.class_ref;
				}
			}

			// Token: 0x1700015D RID: 349
			// (get) Token: 0x060008C7 RID: 2247 RVA: 0x00017BF7 File Offset: 0x00015DF7
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return TabLayout.IOnTabSelectedListener2Invoker._members.ManagedPeerType;
				}
			}

			// Token: 0x060008C8 RID: 2248 RVA: 0x00017C03 File Offset: 0x00015E03
			public static TabLayout.IOnTabSelectedListener2 GetObject(IntPtr handle, JniHandleOwnership transfer)
			{
				return Java.Lang.Object.GetObject<TabLayout.IOnTabSelectedListener2>(handle, transfer);
			}

			// Token: 0x060008C9 RID: 2249 RVA: 0x00017C0C File Offset: 0x00015E0C
			private static IntPtr Validate(IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf(handle, TabLayout.IOnTabSelectedListener2Invoker.java_class_ref))
				{
					throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'com.google.android.material.tabs.TabLayout.OnTabSelectedListener'.");
				}
				return handle;
			}

			// Token: 0x060008CA RID: 2250 RVA: 0x00017C37 File Offset: 0x00015E37
			protected override void Dispose(bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
				{
					JNIEnv.DeleteGlobalRef(this.class_ref);
				}
				this.class_ref = IntPtr.Zero;
				base.Dispose(disposing);
			}

			// Token: 0x060008CB RID: 2251 RVA: 0x00017C68 File Offset: 0x00015E68
			public IOnTabSelectedListener2Invoker(IntPtr handle, JniHandleOwnership transfer) : base(TabLayout.IOnTabSelectedListener2Invoker.Validate(handle), transfer)
			{
				IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
				this.class_ref = JNIEnv.NewGlobalRef(objectClass);
				JNIEnv.DeleteLocalRef(objectClass);
			}

			// Token: 0x060008CC RID: 2252 RVA: 0x00017CA0 File Offset: 0x00015EA0
			private static Delegate GetOnTabReselected_Lcom_google_android_material_tabs_TabLayout_Tab_Handler()
			{
				if (TabLayout.IOnTabSelectedListener2Invoker.cb_onTabReselected_Lcom_google_android_material_tabs_TabLayout_Tab_ == null)
				{
					TabLayout.IOnTabSelectedListener2Invoker.cb_onTabReselected_Lcom_google_android_material_tabs_TabLayout_Tab_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(TabLayout.IOnTabSelectedListener2Invoker.n_OnTabReselected_Lcom_google_android_material_tabs_TabLayout_Tab_));
				}
				return TabLayout.IOnTabSelectedListener2Invoker.cb_onTabReselected_Lcom_google_android_material_tabs_TabLayout_Tab_;
			}

			// Token: 0x060008CD RID: 2253 RVA: 0x00017CC4 File Offset: 0x00015EC4
			private static void n_OnTabReselected_Lcom_google_android_material_tabs_TabLayout_Tab_(IntPtr jnienv, IntPtr native__this, IntPtr native_tab)
			{
				TabLayout.IOnTabSelectedListener @object = Java.Lang.Object.GetObject<TabLayout.IOnTabSelectedListener2>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				TabLayout.Tab object2 = Java.Lang.Object.GetObject<TabLayout.Tab>(native_tab, JniHandleOwnership.DoNotTransfer);
				@object.OnTabReselected(object2);
			}

			// Token: 0x060008CE RID: 2254 RVA: 0x00017CE8 File Offset: 0x00015EE8
			public unsafe void OnTabReselected(TabLayout.Tab tab)
			{
				if (this.id_onTabReselected_Lcom_google_android_material_tabs_TabLayout_Tab_ == IntPtr.Zero)
				{
					this.id_onTabReselected_Lcom_google_android_material_tabs_TabLayout_Tab_ = JNIEnv.GetMethodID(this.class_ref, "onTabReselected", "(Lcom/google/android/material/tabs/TabLayout$Tab;)V");
				}
				JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
				*ptr = new JValue((tab == null) ? IntPtr.Zero : tab.Handle);
				JNIEnv.CallVoidMethod(base.Handle, this.id_onTabReselected_Lcom_google_android_material_tabs_TabLayout_Tab_, ptr);
			}

			// Token: 0x060008CF RID: 2255 RVA: 0x00017D5B File Offset: 0x00015F5B
			private static Delegate GetOnTabSelected_Lcom_google_android_material_tabs_TabLayout_Tab_Handler()
			{
				if (TabLayout.IOnTabSelectedListener2Invoker.cb_onTabSelected_Lcom_google_android_material_tabs_TabLayout_Tab_ == null)
				{
					TabLayout.IOnTabSelectedListener2Invoker.cb_onTabSelected_Lcom_google_android_material_tabs_TabLayout_Tab_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(TabLayout.IOnTabSelectedListener2Invoker.n_OnTabSelected_Lcom_google_android_material_tabs_TabLayout_Tab_));
				}
				return TabLayout.IOnTabSelectedListener2Invoker.cb_onTabSelected_Lcom_google_android_material_tabs_TabLayout_Tab_;
			}

			// Token: 0x060008D0 RID: 2256 RVA: 0x00017D80 File Offset: 0x00015F80
			private static void n_OnTabSelected_Lcom_google_android_material_tabs_TabLayout_Tab_(IntPtr jnienv, IntPtr native__this, IntPtr native_tab)
			{
				TabLayout.IOnTabSelectedListener @object = Java.Lang.Object.GetObject<TabLayout.IOnTabSelectedListener2>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				TabLayout.Tab object2 = Java.Lang.Object.GetObject<TabLayout.Tab>(native_tab, JniHandleOwnership.DoNotTransfer);
				@object.OnTabSelected(object2);
			}

			// Token: 0x060008D1 RID: 2257 RVA: 0x00017DA4 File Offset: 0x00015FA4
			public unsafe void OnTabSelected(TabLayout.Tab tab)
			{
				if (this.id_onTabSelected_Lcom_google_android_material_tabs_TabLayout_Tab_ == IntPtr.Zero)
				{
					this.id_onTabSelected_Lcom_google_android_material_tabs_TabLayout_Tab_ = JNIEnv.GetMethodID(this.class_ref, "onTabSelected", "(Lcom/google/android/material/tabs/TabLayout$Tab;)V");
				}
				JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
				*ptr = new JValue((tab == null) ? IntPtr.Zero : tab.Handle);
				JNIEnv.CallVoidMethod(base.Handle, this.id_onTabSelected_Lcom_google_android_material_tabs_TabLayout_Tab_, ptr);
			}

			// Token: 0x060008D2 RID: 2258 RVA: 0x00017E17 File Offset: 0x00016017
			private static Delegate GetOnTabUnselected_Lcom_google_android_material_tabs_TabLayout_Tab_Handler()
			{
				if (TabLayout.IOnTabSelectedListener2Invoker.cb_onTabUnselected_Lcom_google_android_material_tabs_TabLayout_Tab_ == null)
				{
					TabLayout.IOnTabSelectedListener2Invoker.cb_onTabUnselected_Lcom_google_android_material_tabs_TabLayout_Tab_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(TabLayout.IOnTabSelectedListener2Invoker.n_OnTabUnselected_Lcom_google_android_material_tabs_TabLayout_Tab_));
				}
				return TabLayout.IOnTabSelectedListener2Invoker.cb_onTabUnselected_Lcom_google_android_material_tabs_TabLayout_Tab_;
			}

			// Token: 0x060008D3 RID: 2259 RVA: 0x00017E3C File Offset: 0x0001603C
			private static void n_OnTabUnselected_Lcom_google_android_material_tabs_TabLayout_Tab_(IntPtr jnienv, IntPtr native__this, IntPtr native_tab)
			{
				TabLayout.IOnTabSelectedListener @object = Java.Lang.Object.GetObject<TabLayout.IOnTabSelectedListener2>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				TabLayout.Tab object2 = Java.Lang.Object.GetObject<TabLayout.Tab>(native_tab, JniHandleOwnership.DoNotTransfer);
				@object.OnTabUnselected(object2);
			}

			// Token: 0x060008D4 RID: 2260 RVA: 0x00017E60 File Offset: 0x00016060
			public unsafe void OnTabUnselected(TabLayout.Tab tab)
			{
				if (this.id_onTabUnselected_Lcom_google_android_material_tabs_TabLayout_Tab_ == IntPtr.Zero)
				{
					this.id_onTabUnselected_Lcom_google_android_material_tabs_TabLayout_Tab_ = JNIEnv.GetMethodID(this.class_ref, "onTabUnselected", "(Lcom/google/android/material/tabs/TabLayout$Tab;)V");
				}
				JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
				*ptr = new JValue((tab == null) ? IntPtr.Zero : tab.Handle);
				JNIEnv.CallVoidMethod(base.Handle, this.id_onTabUnselected_Lcom_google_android_material_tabs_TabLayout_Tab_, ptr);
			}

			// Token: 0x04000282 RID: 642
			private static readonly JniPeerMembers _members = new XAPeerMembers("com/google/android/material/tabs/TabLayout$OnTabSelectedListener", typeof(TabLayout.IOnTabSelectedListener2Invoker));

			// Token: 0x04000283 RID: 643
			private IntPtr class_ref;

			// Token: 0x04000284 RID: 644
			private static Delegate cb_onTabReselected_Lcom_google_android_material_tabs_TabLayout_Tab_;

			// Token: 0x04000285 RID: 645
			private IntPtr id_onTabReselected_Lcom_google_android_material_tabs_TabLayout_Tab_;

			// Token: 0x04000286 RID: 646
			private static Delegate cb_onTabSelected_Lcom_google_android_material_tabs_TabLayout_Tab_;

			// Token: 0x04000287 RID: 647
			private IntPtr id_onTabSelected_Lcom_google_android_material_tabs_TabLayout_Tab_;

			// Token: 0x04000288 RID: 648
			private static Delegate cb_onTabUnselected_Lcom_google_android_material_tabs_TabLayout_Tab_;

			// Token: 0x04000289 RID: 649
			private IntPtr id_onTabUnselected_Lcom_google_android_material_tabs_TabLayout_Tab_;
		}

		// Token: 0x02000081 RID: 129
		[Register("com/google/android/material/tabs/TabLayout$Tab", DoNotGenerateAcw = true)]
		public class Tab : Java.Lang.Object
		{
			// Token: 0x1700015E RID: 350
			// (get) Token: 0x060008D6 RID: 2262 RVA: 0x00017EF0 File Offset: 0x000160F0
			// (set) Token: 0x060008D7 RID: 2263 RVA: 0x00017F20 File Offset: 0x00016120
			[Register("parent")]
			public TabLayout Parent
			{
				get
				{
					return Java.Lang.Object.GetObject<TabLayout>(TabLayout.Tab._members.InstanceFields.GetObjectValue("parent.Lcom/google/android/material/tabs/TabLayout;", this).Handle, JniHandleOwnership.TransferLocalRef);
				}
				set
				{
					IntPtr intPtr = JNIEnv.ToLocalJniHandle(value);
					try
					{
						TabLayout.Tab._members.InstanceFields.SetValue("parent.Lcom/google/android/material/tabs/TabLayout;", this, new JniObjectReference(intPtr, JniObjectReferenceType.Invalid));
					}
					finally
					{
						JNIEnv.DeleteLocalRef(intPtr);
					}
				}
			}

			// Token: 0x1700015F RID: 351
			// (get) Token: 0x060008D8 RID: 2264 RVA: 0x00017F6C File Offset: 0x0001616C
			// (set) Token: 0x060008D9 RID: 2265 RVA: 0x00017F9C File Offset: 0x0001619C
			[Register("view")]
			public TabLayout.TabView View
			{
				get
				{
					return Java.Lang.Object.GetObject<TabLayout.TabView>(TabLayout.Tab._members.InstanceFields.GetObjectValue("view.Lcom/google/android/material/tabs/TabLayout$TabView;", this).Handle, JniHandleOwnership.TransferLocalRef);
				}
				set
				{
					IntPtr intPtr = JNIEnv.ToLocalJniHandle(value);
					try
					{
						TabLayout.Tab._members.InstanceFields.SetValue("view.Lcom/google/android/material/tabs/TabLayout$TabView;", this, new JniObjectReference(intPtr, JniObjectReferenceType.Invalid));
					}
					finally
					{
						JNIEnv.DeleteLocalRef(intPtr);
					}
				}
			}

			// Token: 0x17000160 RID: 352
			// (get) Token: 0x060008DA RID: 2266 RVA: 0x00017FE8 File Offset: 0x000161E8
			internal static IntPtr class_ref
			{
				get
				{
					return TabLayout.Tab._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x17000161 RID: 353
			// (get) Token: 0x060008DB RID: 2267 RVA: 0x0001800C File Offset: 0x0001620C
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return TabLayout.Tab._members;
				}
			}

			// Token: 0x17000162 RID: 354
			// (get) Token: 0x060008DC RID: 2268 RVA: 0x00018014 File Offset: 0x00016214
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return TabLayout.Tab._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x17000163 RID: 355
			// (get) Token: 0x060008DD RID: 2269 RVA: 0x00018038 File Offset: 0x00016238
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return TabLayout.Tab._members.ManagedPeerType;
				}
			}

			// Token: 0x060008DE RID: 2270 RVA: 0x000020DC File Offset: 0x000002DC
			protected Tab(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
			{
			}

			// Token: 0x060008DF RID: 2271 RVA: 0x00018044 File Offset: 0x00016244
			[Register(".ctor", "()V", "")]
			public Tab() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (base.Handle != IntPtr.Zero)
				{
					return;
				}
				base.SetHandle(TabLayout.Tab._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
				TabLayout.Tab._members.InstanceMethods.FinishCreateInstance("()V", this, null);
			}

			// Token: 0x060008E0 RID: 2272 RVA: 0x000180B2 File Offset: 0x000162B2
			private static Delegate GetGetBadgeHandler()
			{
				if (TabLayout.Tab.cb_getBadge == null)
				{
					TabLayout.Tab.cb_getBadge = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(TabLayout.Tab.n_GetBadge));
				}
				return TabLayout.Tab.cb_getBadge;
			}

			// Token: 0x060008E1 RID: 2273 RVA: 0x000180D6 File Offset: 0x000162D6
			private static IntPtr n_GetBadge(IntPtr jnienv, IntPtr native__this)
			{
				return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<TabLayout.Tab>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Badge);
			}

			// Token: 0x17000164 RID: 356
			// (get) Token: 0x060008E2 RID: 2274 RVA: 0x000180EC File Offset: 0x000162EC
			public virtual BadgeDrawable Badge
			{
				[Register("getBadge", "()Lcom/google/android/material/badge/BadgeDrawable;", "GetGetBadgeHandler")]
				get
				{
					return Java.Lang.Object.GetObject<BadgeDrawable>(TabLayout.Tab._members.InstanceMethods.InvokeVirtualObjectMethod("getBadge.()Lcom/google/android/material/badge/BadgeDrawable;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
				}
			}

			// Token: 0x060008E3 RID: 2275 RVA: 0x0001811E File Offset: 0x0001631E
			private static Delegate GetGetContentDescriptionHandler()
			{
				if (TabLayout.Tab.cb_getContentDescription == null)
				{
					TabLayout.Tab.cb_getContentDescription = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(TabLayout.Tab.n_GetContentDescription));
				}
				return TabLayout.Tab.cb_getContentDescription;
			}

			// Token: 0x060008E4 RID: 2276 RVA: 0x00018142 File Offset: 0x00016342
			private static IntPtr n_GetContentDescription(IntPtr jnienv, IntPtr native__this)
			{
				return CharSequence.ToLocalJniHandle(Java.Lang.Object.GetObject<TabLayout.Tab>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ContentDescriptionFormatted);
			}

			// Token: 0x17000165 RID: 357
			// (get) Token: 0x060008E5 RID: 2277 RVA: 0x00018158 File Offset: 0x00016358
			public virtual ICharSequence ContentDescriptionFormatted
			{
				[Register("getContentDescription", "()Ljava/lang/CharSequence;", "GetGetContentDescriptionHandler")]
				get
				{
					return Java.Lang.Object.GetObject<ICharSequence>(TabLayout.Tab._members.InstanceMethods.InvokeVirtualObjectMethod("getContentDescription.()Ljava/lang/CharSequence;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
				}
			}

			// Token: 0x17000166 RID: 358
			// (get) Token: 0x060008E6 RID: 2278 RVA: 0x0001818A File Offset: 0x0001638A
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

			// Token: 0x060008E7 RID: 2279 RVA: 0x000181A1 File Offset: 0x000163A1
			private static Delegate GetGetCustomViewHandler()
			{
				if (TabLayout.Tab.cb_getCustomView == null)
				{
					TabLayout.Tab.cb_getCustomView = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(TabLayout.Tab.n_GetCustomView));
				}
				return TabLayout.Tab.cb_getCustomView;
			}

			// Token: 0x060008E8 RID: 2280 RVA: 0x000181C5 File Offset: 0x000163C5
			private static IntPtr n_GetCustomView(IntPtr jnienv, IntPtr native__this)
			{
				return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<TabLayout.Tab>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).CustomView);
			}

			// Token: 0x17000167 RID: 359
			// (get) Token: 0x060008E9 RID: 2281 RVA: 0x000181DC File Offset: 0x000163DC
			public virtual View CustomView
			{
				[Register("getCustomView", "()Landroid/view/View;", "GetGetCustomViewHandler")]
				get
				{
					return Java.Lang.Object.GetObject<View>(TabLayout.Tab._members.InstanceMethods.InvokeVirtualObjectMethod("getCustomView.()Landroid/view/View;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
				}
			}

			// Token: 0x060008EA RID: 2282 RVA: 0x0001820E File Offset: 0x0001640E
			private static Delegate GetGetIconHandler()
			{
				if (TabLayout.Tab.cb_getIcon == null)
				{
					TabLayout.Tab.cb_getIcon = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(TabLayout.Tab.n_GetIcon));
				}
				return TabLayout.Tab.cb_getIcon;
			}

			// Token: 0x060008EB RID: 2283 RVA: 0x00018232 File Offset: 0x00016432
			private static IntPtr n_GetIcon(IntPtr jnienv, IntPtr native__this)
			{
				return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<TabLayout.Tab>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Icon);
			}

			// Token: 0x17000168 RID: 360
			// (get) Token: 0x060008EC RID: 2284 RVA: 0x00018248 File Offset: 0x00016448
			public virtual Drawable Icon
			{
				[Register("getIcon", "()Landroid/graphics/drawable/Drawable;", "GetGetIconHandler")]
				get
				{
					return Java.Lang.Object.GetObject<Drawable>(TabLayout.Tab._members.InstanceMethods.InvokeVirtualObjectMethod("getIcon.()Landroid/graphics/drawable/Drawable;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
				}
			}

			// Token: 0x060008ED RID: 2285 RVA: 0x0001827A File Offset: 0x0001647A
			private static Delegate GetGetIdHandler()
			{
				if (TabLayout.Tab.cb_getId == null)
				{
					TabLayout.Tab.cb_getId = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(TabLayout.Tab.n_GetId));
				}
				return TabLayout.Tab.cb_getId;
			}

			// Token: 0x060008EE RID: 2286 RVA: 0x0001829E File Offset: 0x0001649E
			private static int n_GetId(IntPtr jnienv, IntPtr native__this)
			{
				return Java.Lang.Object.GetObject<TabLayout.Tab>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Id;
			}

			// Token: 0x17000169 RID: 361
			// (get) Token: 0x060008EF RID: 2287 RVA: 0x000182AD File Offset: 0x000164AD
			public virtual int Id
			{
				[Register("getId", "()I", "GetGetIdHandler")]
				get
				{
					return TabLayout.Tab._members.InstanceMethods.InvokeVirtualInt32Method("getId.()I", this, null);
				}
			}

			// Token: 0x060008F0 RID: 2288 RVA: 0x000182C6 File Offset: 0x000164C6
			private static Delegate GetIsSelectedHandler()
			{
				if (TabLayout.Tab.cb_isSelected == null)
				{
					TabLayout.Tab.cb_isSelected = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(TabLayout.Tab.n_IsSelected));
				}
				return TabLayout.Tab.cb_isSelected;
			}

			// Token: 0x060008F1 RID: 2289 RVA: 0x000182EA File Offset: 0x000164EA
			private static bool n_IsSelected(IntPtr jnienv, IntPtr native__this)
			{
				return Java.Lang.Object.GetObject<TabLayout.Tab>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsSelected;
			}

			// Token: 0x1700016A RID: 362
			// (get) Token: 0x060008F2 RID: 2290 RVA: 0x000182F9 File Offset: 0x000164F9
			public virtual bool IsSelected
			{
				[Register("isSelected", "()Z", "GetIsSelectedHandler")]
				get
				{
					return TabLayout.Tab._members.InstanceMethods.InvokeVirtualBooleanMethod("isSelected.()Z", this, null);
				}
			}

			// Token: 0x060008F3 RID: 2291 RVA: 0x00018312 File Offset: 0x00016512
			private static Delegate GetGetOrCreateBadgeHandler()
			{
				if (TabLayout.Tab.cb_getOrCreateBadge == null)
				{
					TabLayout.Tab.cb_getOrCreateBadge = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(TabLayout.Tab.n_GetOrCreateBadge));
				}
				return TabLayout.Tab.cb_getOrCreateBadge;
			}

			// Token: 0x060008F4 RID: 2292 RVA: 0x00018336 File Offset: 0x00016536
			private static IntPtr n_GetOrCreateBadge(IntPtr jnienv, IntPtr native__this)
			{
				return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<TabLayout.Tab>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).OrCreateBadge);
			}

			// Token: 0x1700016B RID: 363
			// (get) Token: 0x060008F5 RID: 2293 RVA: 0x0001834C File Offset: 0x0001654C
			public virtual BadgeDrawable OrCreateBadge
			{
				[Register("getOrCreateBadge", "()Lcom/google/android/material/badge/BadgeDrawable;", "GetGetOrCreateBadgeHandler")]
				get
				{
					return Java.Lang.Object.GetObject<BadgeDrawable>(TabLayout.Tab._members.InstanceMethods.InvokeVirtualObjectMethod("getOrCreateBadge.()Lcom/google/android/material/badge/BadgeDrawable;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
				}
			}

			// Token: 0x060008F6 RID: 2294 RVA: 0x0001837E File Offset: 0x0001657E
			private static Delegate GetGetPositionHandler()
			{
				if (TabLayout.Tab.cb_getPosition == null)
				{
					TabLayout.Tab.cb_getPosition = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(TabLayout.Tab.n_GetPosition));
				}
				return TabLayout.Tab.cb_getPosition;
			}

			// Token: 0x060008F7 RID: 2295 RVA: 0x000183A2 File Offset: 0x000165A2
			private static int n_GetPosition(IntPtr jnienv, IntPtr native__this)
			{
				return Java.Lang.Object.GetObject<TabLayout.Tab>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Position;
			}

			// Token: 0x1700016C RID: 364
			// (get) Token: 0x060008F8 RID: 2296 RVA: 0x000183B1 File Offset: 0x000165B1
			public virtual int Position
			{
				[Register("getPosition", "()I", "GetGetPositionHandler")]
				get
				{
					return TabLayout.Tab._members.InstanceMethods.InvokeVirtualInt32Method("getPosition.()I", this, null);
				}
			}

			// Token: 0x060008F9 RID: 2297 RVA: 0x000183CA File Offset: 0x000165CA
			private static Delegate GetGetTabLabelVisibilityHandler()
			{
				if (TabLayout.Tab.cb_getTabLabelVisibility == null)
				{
					TabLayout.Tab.cb_getTabLabelVisibility = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(TabLayout.Tab.n_GetTabLabelVisibility));
				}
				return TabLayout.Tab.cb_getTabLabelVisibility;
			}

			// Token: 0x060008FA RID: 2298 RVA: 0x000183EE File Offset: 0x000165EE
			private static int n_GetTabLabelVisibility(IntPtr jnienv, IntPtr native__this)
			{
				return Java.Lang.Object.GetObject<TabLayout.Tab>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).TabLabelVisibility;
			}

			// Token: 0x1700016D RID: 365
			// (get) Token: 0x060008FB RID: 2299 RVA: 0x000183FD File Offset: 0x000165FD
			public virtual int TabLabelVisibility
			{
				[Register("getTabLabelVisibility", "()I", "GetGetTabLabelVisibilityHandler")]
				get
				{
					return TabLayout.Tab._members.InstanceMethods.InvokeVirtualInt32Method("getTabLabelVisibility.()I", this, null);
				}
			}

			// Token: 0x060008FC RID: 2300 RVA: 0x00018416 File Offset: 0x00016616
			private static Delegate GetGetTagHandler()
			{
				if (TabLayout.Tab.cb_getTag == null)
				{
					TabLayout.Tab.cb_getTag = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(TabLayout.Tab.n_GetTag));
				}
				return TabLayout.Tab.cb_getTag;
			}

			// Token: 0x060008FD RID: 2301 RVA: 0x0001843A File Offset: 0x0001663A
			private static IntPtr n_GetTag(IntPtr jnienv, IntPtr native__this)
			{
				return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<TabLayout.Tab>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Tag);
			}

			// Token: 0x1700016E RID: 366
			// (get) Token: 0x060008FE RID: 2302 RVA: 0x00018450 File Offset: 0x00016650
			public virtual Java.Lang.Object Tag
			{
				[Register("getTag", "()Ljava/lang/Object;", "GetGetTagHandler")]
				get
				{
					return Java.Lang.Object.GetObject<Java.Lang.Object>(TabLayout.Tab._members.InstanceMethods.InvokeVirtualObjectMethod("getTag.()Ljava/lang/Object;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
				}
			}

			// Token: 0x060008FF RID: 2303 RVA: 0x00018482 File Offset: 0x00016682
			private static Delegate GetGetTextHandler()
			{
				if (TabLayout.Tab.cb_getText == null)
				{
					TabLayout.Tab.cb_getText = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(TabLayout.Tab.n_GetText));
				}
				return TabLayout.Tab.cb_getText;
			}

			// Token: 0x06000900 RID: 2304 RVA: 0x000184A6 File Offset: 0x000166A6
			private static IntPtr n_GetText(IntPtr jnienv, IntPtr native__this)
			{
				return CharSequence.ToLocalJniHandle(Java.Lang.Object.GetObject<TabLayout.Tab>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).TextFormatted);
			}

			// Token: 0x1700016F RID: 367
			// (get) Token: 0x06000901 RID: 2305 RVA: 0x000184BC File Offset: 0x000166BC
			public virtual ICharSequence TextFormatted
			{
				[Register("getText", "()Ljava/lang/CharSequence;", "GetGetTextHandler")]
				get
				{
					return Java.Lang.Object.GetObject<ICharSequence>(TabLayout.Tab._members.InstanceMethods.InvokeVirtualObjectMethod("getText.()Ljava/lang/CharSequence;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
				}
			}

			// Token: 0x17000170 RID: 368
			// (get) Token: 0x06000902 RID: 2306 RVA: 0x000184EE File Offset: 0x000166EE
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

			// Token: 0x06000903 RID: 2307 RVA: 0x00018505 File Offset: 0x00016705
			private static Delegate GetRemoveBadgeHandler()
			{
				if (TabLayout.Tab.cb_removeBadge == null)
				{
					TabLayout.Tab.cb_removeBadge = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(TabLayout.Tab.n_RemoveBadge));
				}
				return TabLayout.Tab.cb_removeBadge;
			}

			// Token: 0x06000904 RID: 2308 RVA: 0x00018529 File Offset: 0x00016729
			private static void n_RemoveBadge(IntPtr jnienv, IntPtr native__this)
			{
				Java.Lang.Object.GetObject<TabLayout.Tab>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).RemoveBadge();
			}

			// Token: 0x06000905 RID: 2309 RVA: 0x00018538 File Offset: 0x00016738
			[Register("removeBadge", "()V", "GetRemoveBadgeHandler")]
			public virtual void RemoveBadge()
			{
				TabLayout.Tab._members.InstanceMethods.InvokeVirtualVoidMethod("removeBadge.()V", this, null);
			}

			// Token: 0x06000906 RID: 2310 RVA: 0x00018551 File Offset: 0x00016751
			private static Delegate GetSelectHandler()
			{
				if (TabLayout.Tab.cb_select == null)
				{
					TabLayout.Tab.cb_select = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(TabLayout.Tab.n_Select));
				}
				return TabLayout.Tab.cb_select;
			}

			// Token: 0x06000907 RID: 2311 RVA: 0x00018575 File Offset: 0x00016775
			private static void n_Select(IntPtr jnienv, IntPtr native__this)
			{
				Java.Lang.Object.GetObject<TabLayout.Tab>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Select();
			}

			// Token: 0x06000908 RID: 2312 RVA: 0x00018584 File Offset: 0x00016784
			[Register("select", "()V", "GetSelectHandler")]
			public virtual void Select()
			{
				TabLayout.Tab._members.InstanceMethods.InvokeVirtualVoidMethod("select.()V", this, null);
			}

			// Token: 0x06000909 RID: 2313 RVA: 0x0001859D File Offset: 0x0001679D
			private static Delegate GetSetContentDescription_IHandler()
			{
				if (TabLayout.Tab.cb_setContentDescription_I == null)
				{
					TabLayout.Tab.cb_setContentDescription_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_L(TabLayout.Tab.n_SetContentDescription_I));
				}
				return TabLayout.Tab.cb_setContentDescription_I;
			}

			// Token: 0x0600090A RID: 2314 RVA: 0x000185C1 File Offset: 0x000167C1
			private static IntPtr n_SetContentDescription_I(IntPtr jnienv, IntPtr native__this, int resId)
			{
				return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<TabLayout.Tab>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SetContentDescription(resId));
			}

			// Token: 0x0600090B RID: 2315 RVA: 0x000185D8 File Offset: 0x000167D8
			[Register("setContentDescription", "(I)Lcom/google/android/material/tabs/TabLayout$Tab;", "GetSetContentDescription_IHandler")]
			public unsafe virtual TabLayout.Tab SetContentDescription(int resId)
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(resId);
				return Java.Lang.Object.GetObject<TabLayout.Tab>(TabLayout.Tab._members.InstanceMethods.InvokeVirtualObjectMethod("setContentDescription.(I)Lcom/google/android/material/tabs/TabLayout$Tab;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}

			// Token: 0x0600090C RID: 2316 RVA: 0x00018621 File Offset: 0x00016821
			private static Delegate GetSetContentDescription_Ljava_lang_CharSequence_Handler()
			{
				if (TabLayout.Tab.cb_setContentDescription_Ljava_lang_CharSequence_ == null)
				{
					TabLayout.Tab.cb_setContentDescription_Ljava_lang_CharSequence_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(TabLayout.Tab.n_SetContentDescription_Ljava_lang_CharSequence_));
				}
				return TabLayout.Tab.cb_setContentDescription_Ljava_lang_CharSequence_;
			}

			// Token: 0x0600090D RID: 2317 RVA: 0x00018648 File Offset: 0x00016848
			private static IntPtr n_SetContentDescription_Ljava_lang_CharSequence_(IntPtr jnienv, IntPtr native__this, IntPtr native_contentDesc)
			{
				TabLayout.Tab @object = Java.Lang.Object.GetObject<TabLayout.Tab>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				ICharSequence object2 = Java.Lang.Object.GetObject<ICharSequence>(native_contentDesc, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle(@object.SetContentDescription(object2));
			}

			// Token: 0x0600090E RID: 2318 RVA: 0x00018670 File Offset: 0x00016870
			[Register("setContentDescription", "(Ljava/lang/CharSequence;)Lcom/google/android/material/tabs/TabLayout$Tab;", "GetSetContentDescription_Ljava_lang_CharSequence_Handler")]
			public unsafe virtual TabLayout.Tab SetContentDescription(ICharSequence contentDesc)
			{
				IntPtr intPtr = CharSequence.ToLocalJniHandle(contentDesc);
				TabLayout.Tab @object;
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue(intPtr);
					@object = Java.Lang.Object.GetObject<TabLayout.Tab>(TabLayout.Tab._members.InstanceMethods.InvokeVirtualObjectMethod("setContentDescription.(Ljava/lang/CharSequence;)Lcom/google/android/material/tabs/TabLayout$Tab;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
				}
				finally
				{
					JNIEnv.DeleteLocalRef(intPtr);
					GC.KeepAlive(contentDesc);
				}
				return @object;
			}

			// Token: 0x0600090F RID: 2319 RVA: 0x000186E4 File Offset: 0x000168E4
			public TabLayout.Tab SetContentDescription(string contentDesc)
			{
				Java.Lang.String @string = (contentDesc == null) ? null : new Java.Lang.String(contentDesc);
				TabLayout.Tab result = this.SetContentDescription(@string);
				if (@string != null)
				{
					@string.Dispose();
				}
				return result;
			}

			// Token: 0x06000910 RID: 2320 RVA: 0x0001870E File Offset: 0x0001690E
			private static Delegate GetSetCustomView_Landroid_view_View_Handler()
			{
				if (TabLayout.Tab.cb_setCustomView_Landroid_view_View_ == null)
				{
					TabLayout.Tab.cb_setCustomView_Landroid_view_View_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(TabLayout.Tab.n_SetCustomView_Landroid_view_View_));
				}
				return TabLayout.Tab.cb_setCustomView_Landroid_view_View_;
			}

			// Token: 0x06000911 RID: 2321 RVA: 0x00018734 File Offset: 0x00016934
			private static IntPtr n_SetCustomView_Landroid_view_View_(IntPtr jnienv, IntPtr native__this, IntPtr native_view)
			{
				TabLayout.Tab @object = Java.Lang.Object.GetObject<TabLayout.Tab>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				View object2 = Java.Lang.Object.GetObject<View>(native_view, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle(@object.SetCustomView(object2));
			}

			// Token: 0x06000912 RID: 2322 RVA: 0x0001875C File Offset: 0x0001695C
			[Register("setCustomView", "(Landroid/view/View;)Lcom/google/android/material/tabs/TabLayout$Tab;", "GetSetCustomView_Landroid_view_View_Handler")]
			public unsafe virtual TabLayout.Tab SetCustomView(View view)
			{
				TabLayout.Tab @object;
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((view == null) ? IntPtr.Zero : view.Handle);
					@object = Java.Lang.Object.GetObject<TabLayout.Tab>(TabLayout.Tab._members.InstanceMethods.InvokeVirtualObjectMethod("setCustomView.(Landroid/view/View;)Lcom/google/android/material/tabs/TabLayout$Tab;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
				}
				finally
				{
					GC.KeepAlive(view);
				}
				return @object;
			}

			// Token: 0x06000913 RID: 2323 RVA: 0x000187D0 File Offset: 0x000169D0
			private static Delegate GetSetCustomView_IHandler()
			{
				if (TabLayout.Tab.cb_setCustomView_I == null)
				{
					TabLayout.Tab.cb_setCustomView_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_L(TabLayout.Tab.n_SetCustomView_I));
				}
				return TabLayout.Tab.cb_setCustomView_I;
			}

			// Token: 0x06000914 RID: 2324 RVA: 0x000187F4 File Offset: 0x000169F4
			private static IntPtr n_SetCustomView_I(IntPtr jnienv, IntPtr native__this, int resId)
			{
				return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<TabLayout.Tab>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SetCustomView(resId));
			}

			// Token: 0x06000915 RID: 2325 RVA: 0x0001880C File Offset: 0x00016A0C
			[Register("setCustomView", "(I)Lcom/google/android/material/tabs/TabLayout$Tab;", "GetSetCustomView_IHandler")]
			public unsafe virtual TabLayout.Tab SetCustomView(int resId)
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(resId);
				return Java.Lang.Object.GetObject<TabLayout.Tab>(TabLayout.Tab._members.InstanceMethods.InvokeVirtualObjectMethod("setCustomView.(I)Lcom/google/android/material/tabs/TabLayout$Tab;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}

			// Token: 0x06000916 RID: 2326 RVA: 0x00018855 File Offset: 0x00016A55
			private static Delegate GetSetIcon_Landroid_graphics_drawable_Drawable_Handler()
			{
				if (TabLayout.Tab.cb_setIcon_Landroid_graphics_drawable_Drawable_ == null)
				{
					TabLayout.Tab.cb_setIcon_Landroid_graphics_drawable_Drawable_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(TabLayout.Tab.n_SetIcon_Landroid_graphics_drawable_Drawable_));
				}
				return TabLayout.Tab.cb_setIcon_Landroid_graphics_drawable_Drawable_;
			}

			// Token: 0x06000917 RID: 2327 RVA: 0x0001887C File Offset: 0x00016A7C
			private static IntPtr n_SetIcon_Landroid_graphics_drawable_Drawable_(IntPtr jnienv, IntPtr native__this, IntPtr native_icon)
			{
				TabLayout.Tab @object = Java.Lang.Object.GetObject<TabLayout.Tab>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				Drawable object2 = Java.Lang.Object.GetObject<Drawable>(native_icon, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle(@object.SetIcon(object2));
			}

			// Token: 0x06000918 RID: 2328 RVA: 0x000188A4 File Offset: 0x00016AA4
			[Register("setIcon", "(Landroid/graphics/drawable/Drawable;)Lcom/google/android/material/tabs/TabLayout$Tab;", "GetSetIcon_Landroid_graphics_drawable_Drawable_Handler")]
			public unsafe virtual TabLayout.Tab SetIcon(Drawable icon)
			{
				TabLayout.Tab @object;
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((icon == null) ? IntPtr.Zero : icon.Handle);
					@object = Java.Lang.Object.GetObject<TabLayout.Tab>(TabLayout.Tab._members.InstanceMethods.InvokeVirtualObjectMethod("setIcon.(Landroid/graphics/drawable/Drawable;)Lcom/google/android/material/tabs/TabLayout$Tab;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
				}
				finally
				{
					GC.KeepAlive(icon);
				}
				return @object;
			}

			// Token: 0x06000919 RID: 2329 RVA: 0x00018918 File Offset: 0x00016B18
			private static Delegate GetSetIcon_IHandler()
			{
				if (TabLayout.Tab.cb_setIcon_I == null)
				{
					TabLayout.Tab.cb_setIcon_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_L(TabLayout.Tab.n_SetIcon_I));
				}
				return TabLayout.Tab.cb_setIcon_I;
			}

			// Token: 0x0600091A RID: 2330 RVA: 0x0001893C File Offset: 0x00016B3C
			private static IntPtr n_SetIcon_I(IntPtr jnienv, IntPtr native__this, int resId)
			{
				return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<TabLayout.Tab>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SetIcon(resId));
			}

			// Token: 0x0600091B RID: 2331 RVA: 0x00018954 File Offset: 0x00016B54
			[Register("setIcon", "(I)Lcom/google/android/material/tabs/TabLayout$Tab;", "GetSetIcon_IHandler")]
			public unsafe virtual TabLayout.Tab SetIcon(int resId)
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(resId);
				return Java.Lang.Object.GetObject<TabLayout.Tab>(TabLayout.Tab._members.InstanceMethods.InvokeVirtualObjectMethod("setIcon.(I)Lcom/google/android/material/tabs/TabLayout$Tab;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}

			// Token: 0x0600091C RID: 2332 RVA: 0x0001899D File Offset: 0x00016B9D
			private static Delegate GetSetId_IHandler()
			{
				if (TabLayout.Tab.cb_setId_I == null)
				{
					TabLayout.Tab.cb_setId_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_L(TabLayout.Tab.n_SetId_I));
				}
				return TabLayout.Tab.cb_setId_I;
			}

			// Token: 0x0600091D RID: 2333 RVA: 0x000189C1 File Offset: 0x00016BC1
			private static IntPtr n_SetId_I(IntPtr jnienv, IntPtr native__this, int id)
			{
				return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<TabLayout.Tab>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SetId(id));
			}

			// Token: 0x0600091E RID: 2334 RVA: 0x000189D8 File Offset: 0x00016BD8
			[Register("setId", "(I)Lcom/google/android/material/tabs/TabLayout$Tab;", "GetSetId_IHandler")]
			public unsafe virtual TabLayout.Tab SetId(int id)
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(id);
				return Java.Lang.Object.GetObject<TabLayout.Tab>(TabLayout.Tab._members.InstanceMethods.InvokeVirtualObjectMethod("setId.(I)Lcom/google/android/material/tabs/TabLayout$Tab;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}

			// Token: 0x0600091F RID: 2335 RVA: 0x00018A21 File Offset: 0x00016C21
			private static Delegate GetSetTabLabelVisibility_IHandler()
			{
				if (TabLayout.Tab.cb_setTabLabelVisibility_I == null)
				{
					TabLayout.Tab.cb_setTabLabelVisibility_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_L(TabLayout.Tab.n_SetTabLabelVisibility_I));
				}
				return TabLayout.Tab.cb_setTabLabelVisibility_I;
			}

			// Token: 0x06000920 RID: 2336 RVA: 0x00018A45 File Offset: 0x00016C45
			private static IntPtr n_SetTabLabelVisibility_I(IntPtr jnienv, IntPtr native__this, int mode)
			{
				return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<TabLayout.Tab>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SetTabLabelVisibility(mode));
			}

			// Token: 0x06000921 RID: 2337 RVA: 0x00018A5C File Offset: 0x00016C5C
			[Register("setTabLabelVisibility", "(I)Lcom/google/android/material/tabs/TabLayout$Tab;", "GetSetTabLabelVisibility_IHandler")]
			public unsafe virtual TabLayout.Tab SetTabLabelVisibility(int mode)
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(mode);
				return Java.Lang.Object.GetObject<TabLayout.Tab>(TabLayout.Tab._members.InstanceMethods.InvokeVirtualObjectMethod("setTabLabelVisibility.(I)Lcom/google/android/material/tabs/TabLayout$Tab;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}

			// Token: 0x06000922 RID: 2338 RVA: 0x00018AA5 File Offset: 0x00016CA5
			private static Delegate GetSetTag_Ljava_lang_Object_Handler()
			{
				if (TabLayout.Tab.cb_setTag_Ljava_lang_Object_ == null)
				{
					TabLayout.Tab.cb_setTag_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(TabLayout.Tab.n_SetTag_Ljava_lang_Object_));
				}
				return TabLayout.Tab.cb_setTag_Ljava_lang_Object_;
			}

			// Token: 0x06000923 RID: 2339 RVA: 0x00018ACC File Offset: 0x00016CCC
			private static IntPtr n_SetTag_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_tag)
			{
				TabLayout.Tab @object = Java.Lang.Object.GetObject<TabLayout.Tab>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_tag, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle(@object.SetTag(object2));
			}

			// Token: 0x06000924 RID: 2340 RVA: 0x00018AF4 File Offset: 0x00016CF4
			[Register("setTag", "(Ljava/lang/Object;)Lcom/google/android/material/tabs/TabLayout$Tab;", "GetSetTag_Ljava_lang_Object_Handler")]
			public unsafe virtual TabLayout.Tab SetTag(Java.Lang.Object tag)
			{
				TabLayout.Tab @object;
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((tag == null) ? IntPtr.Zero : tag.Handle);
					@object = Java.Lang.Object.GetObject<TabLayout.Tab>(TabLayout.Tab._members.InstanceMethods.InvokeVirtualObjectMethod("setTag.(Ljava/lang/Object;)Lcom/google/android/material/tabs/TabLayout$Tab;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
				}
				finally
				{
					GC.KeepAlive(tag);
				}
				return @object;
			}

			// Token: 0x06000925 RID: 2341 RVA: 0x00018B68 File Offset: 0x00016D68
			private static Delegate GetSetText_IHandler()
			{
				if (TabLayout.Tab.cb_setText_I == null)
				{
					TabLayout.Tab.cb_setText_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_L(TabLayout.Tab.n_SetText_I));
				}
				return TabLayout.Tab.cb_setText_I;
			}

			// Token: 0x06000926 RID: 2342 RVA: 0x00018B8C File Offset: 0x00016D8C
			private static IntPtr n_SetText_I(IntPtr jnienv, IntPtr native__this, int resId)
			{
				return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<TabLayout.Tab>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SetText(resId));
			}

			// Token: 0x06000927 RID: 2343 RVA: 0x00018BA4 File Offset: 0x00016DA4
			[Register("setText", "(I)Lcom/google/android/material/tabs/TabLayout$Tab;", "GetSetText_IHandler")]
			public unsafe virtual TabLayout.Tab SetText(int resId)
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(resId);
				return Java.Lang.Object.GetObject<TabLayout.Tab>(TabLayout.Tab._members.InstanceMethods.InvokeVirtualObjectMethod("setText.(I)Lcom/google/android/material/tabs/TabLayout$Tab;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}

			// Token: 0x06000928 RID: 2344 RVA: 0x00018BED File Offset: 0x00016DED
			private static Delegate GetSetText_Ljava_lang_CharSequence_Handler()
			{
				if (TabLayout.Tab.cb_setText_Ljava_lang_CharSequence_ == null)
				{
					TabLayout.Tab.cb_setText_Ljava_lang_CharSequence_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(TabLayout.Tab.n_SetText_Ljava_lang_CharSequence_));
				}
				return TabLayout.Tab.cb_setText_Ljava_lang_CharSequence_;
			}

			// Token: 0x06000929 RID: 2345 RVA: 0x00018C14 File Offset: 0x00016E14
			private static IntPtr n_SetText_Ljava_lang_CharSequence_(IntPtr jnienv, IntPtr native__this, IntPtr native_text)
			{
				TabLayout.Tab @object = Java.Lang.Object.GetObject<TabLayout.Tab>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				ICharSequence object2 = Java.Lang.Object.GetObject<ICharSequence>(native_text, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle(@object.SetText(object2));
			}

			// Token: 0x0600092A RID: 2346 RVA: 0x00018C3C File Offset: 0x00016E3C
			[Register("setText", "(Ljava/lang/CharSequence;)Lcom/google/android/material/tabs/TabLayout$Tab;", "GetSetText_Ljava_lang_CharSequence_Handler")]
			public unsafe virtual TabLayout.Tab SetText(ICharSequence text)
			{
				IntPtr intPtr = CharSequence.ToLocalJniHandle(text);
				TabLayout.Tab @object;
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue(intPtr);
					@object = Java.Lang.Object.GetObject<TabLayout.Tab>(TabLayout.Tab._members.InstanceMethods.InvokeVirtualObjectMethod("setText.(Ljava/lang/CharSequence;)Lcom/google/android/material/tabs/TabLayout$Tab;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
				}
				finally
				{
					JNIEnv.DeleteLocalRef(intPtr);
					GC.KeepAlive(text);
				}
				return @object;
			}

			// Token: 0x0600092B RID: 2347 RVA: 0x00018CB0 File Offset: 0x00016EB0
			public TabLayout.Tab SetText(string text)
			{
				Java.Lang.String @string = (text == null) ? null : new Java.Lang.String(text);
				TabLayout.Tab result = this.SetText(@string);
				if (@string != null)
				{
					@string.Dispose();
				}
				return result;
			}

			// Token: 0x0400028A RID: 650
			private static readonly JniPeerMembers _members = new XAPeerMembers("com/google/android/material/tabs/TabLayout$Tab", typeof(TabLayout.Tab));

			// Token: 0x0400028B RID: 651
			private static Delegate cb_getBadge;

			// Token: 0x0400028C RID: 652
			private static Delegate cb_getContentDescription;

			// Token: 0x0400028D RID: 653
			private static Delegate cb_getCustomView;

			// Token: 0x0400028E RID: 654
			private static Delegate cb_getIcon;

			// Token: 0x0400028F RID: 655
			private static Delegate cb_getId;

			// Token: 0x04000290 RID: 656
			private static Delegate cb_isSelected;

			// Token: 0x04000291 RID: 657
			private static Delegate cb_getOrCreateBadge;

			// Token: 0x04000292 RID: 658
			private static Delegate cb_getPosition;

			// Token: 0x04000293 RID: 659
			private static Delegate cb_getTabLabelVisibility;

			// Token: 0x04000294 RID: 660
			private static Delegate cb_getTag;

			// Token: 0x04000295 RID: 661
			private static Delegate cb_getText;

			// Token: 0x04000296 RID: 662
			private static Delegate cb_removeBadge;

			// Token: 0x04000297 RID: 663
			private static Delegate cb_select;

			// Token: 0x04000298 RID: 664
			private static Delegate cb_setContentDescription_I;

			// Token: 0x04000299 RID: 665
			private static Delegate cb_setContentDescription_Ljava_lang_CharSequence_;

			// Token: 0x0400029A RID: 666
			private static Delegate cb_setCustomView_Landroid_view_View_;

			// Token: 0x0400029B RID: 667
			private static Delegate cb_setCustomView_I;

			// Token: 0x0400029C RID: 668
			private static Delegate cb_setIcon_Landroid_graphics_drawable_Drawable_;

			// Token: 0x0400029D RID: 669
			private static Delegate cb_setIcon_I;

			// Token: 0x0400029E RID: 670
			private static Delegate cb_setId_I;

			// Token: 0x0400029F RID: 671
			private static Delegate cb_setTabLabelVisibility_I;

			// Token: 0x040002A0 RID: 672
			private static Delegate cb_setTag_Ljava_lang_Object_;

			// Token: 0x040002A1 RID: 673
			private static Delegate cb_setText_I;

			// Token: 0x040002A2 RID: 674
			private static Delegate cb_setText_Ljava_lang_CharSequence_;
		}

		// Token: 0x02000082 RID: 130
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040002A3 RID: 675
			public static Func<TabLayout.IOnTabSelectedListenerImplementor, bool> <0>____IsEmpty;
		}
	}
}
