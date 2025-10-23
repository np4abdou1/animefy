using System;
using Android.Content;
using Android.Content.Res;
using Android.Graphics;
using Android.Graphics.Drawables;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Android.Views
{
	// Token: 0x02000120 RID: 288
	[Register("android/view/MenuItem", "", "Android.Views.IMenuItemInvoker")]
	public interface IMenuItem : IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000183 RID: 387
		// (get) Token: 0x060007EB RID: 2027
		ActionProvider ActionProvider { get; }

		// Token: 0x17000184 RID: 388
		// (get) Token: 0x060007EC RID: 2028
		View ActionView { get; }

		// Token: 0x17000185 RID: 389
		// (get) Token: 0x060007ED RID: 2029
		char AlphabeticShortcut { get; }

		// Token: 0x17000186 RID: 390
		// (get) Token: 0x060007EE RID: 2030
		int GroupId { get; }

		// Token: 0x17000187 RID: 391
		// (get) Token: 0x060007EF RID: 2031
		bool HasSubMenu { get; }

		// Token: 0x17000188 RID: 392
		// (get) Token: 0x060007F0 RID: 2032
		Drawable Icon { get; }

		// Token: 0x17000189 RID: 393
		// (get) Token: 0x060007F1 RID: 2033
		Intent Intent { get; }

		// Token: 0x1700018A RID: 394
		// (get) Token: 0x060007F2 RID: 2034
		bool IsActionViewExpanded { get; }

		// Token: 0x1700018B RID: 395
		// (get) Token: 0x060007F3 RID: 2035
		bool IsCheckable { get; }

		// Token: 0x1700018C RID: 396
		// (get) Token: 0x060007F4 RID: 2036
		bool IsChecked { get; }

		// Token: 0x1700018D RID: 397
		// (get) Token: 0x060007F5 RID: 2037
		bool IsEnabled { get; }

		// Token: 0x1700018E RID: 398
		// (get) Token: 0x060007F6 RID: 2038
		bool IsVisible { get; }

		// Token: 0x1700018F RID: 399
		// (get) Token: 0x060007F7 RID: 2039
		int ItemId { get; }

		// Token: 0x17000190 RID: 400
		// (get) Token: 0x060007F8 RID: 2040
		IContextMenuContextMenuInfo MenuInfo { get; }

		// Token: 0x17000191 RID: 401
		// (get) Token: 0x060007F9 RID: 2041
		char NumericShortcut { get; }

		// Token: 0x17000192 RID: 402
		// (get) Token: 0x060007FA RID: 2042
		int Order { get; }

		// Token: 0x17000193 RID: 403
		// (get) Token: 0x060007FB RID: 2043
		ISubMenu SubMenu { get; }

		// Token: 0x17000194 RID: 404
		// (get) Token: 0x060007FC RID: 2044
		ICharSequence TitleFormatted { get; }

		// Token: 0x17000195 RID: 405
		// (get) Token: 0x060007FD RID: 2045
		ICharSequence TitleCondensedFormatted { get; }

		// Token: 0x060007FE RID: 2046 RVA: 0x00012D67 File Offset: 0x00010F67
		private static Delegate GetGetAlphabeticModifiersHandler()
		{
			if (IMenuItem.cb_getAlphabeticModifiers == null)
			{
				IMenuItem.cb_getAlphabeticModifiers = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(IMenuItem.n_GetAlphabeticModifiers));
			}
			return IMenuItem.cb_getAlphabeticModifiers;
		}

		// Token: 0x060007FF RID: 2047 RVA: 0x00012D8B File Offset: 0x00010F8B
		private static int n_GetAlphabeticModifiers(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IMenuItem>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).AlphabeticModifiers;
		}

		// Token: 0x17000196 RID: 406
		// (get) Token: 0x06000800 RID: 2048 RVA: 0x00012D9A File Offset: 0x00010F9A
		int AlphabeticModifiers
		{
			get
			{
				return IMenuItem._members.InstanceMethods.InvokeVirtualInt32Method("getAlphabeticModifiers.()I", this, null);
			}
		}

		// Token: 0x06000801 RID: 2049 RVA: 0x00012DB3 File Offset: 0x00010FB3
		private static Delegate GetGetContentDescriptionHandler()
		{
			if (IMenuItem.cb_getContentDescription == null)
			{
				IMenuItem.cb_getContentDescription = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IMenuItem.n_GetContentDescription));
			}
			return IMenuItem.cb_getContentDescription;
		}

		// Token: 0x06000802 RID: 2050 RVA: 0x00012DD7 File Offset: 0x00010FD7
		private static IntPtr n_GetContentDescription(IntPtr jnienv, IntPtr native__this)
		{
			return CharSequence.ToLocalJniHandle(Java.Lang.Object.GetObject<IMenuItem>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ContentDescriptionFormatted);
		}

		// Token: 0x17000197 RID: 407
		// (get) Token: 0x06000803 RID: 2051 RVA: 0x00012DEC File Offset: 0x00010FEC
		ICharSequence ContentDescriptionFormatted
		{
			get
			{
				return Java.Lang.Object.GetObject<ICharSequence>(IMenuItem._members.InstanceMethods.InvokeVirtualObjectMethod("getContentDescription.()Ljava/lang/CharSequence;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000198 RID: 408
		// (get) Token: 0x06000804 RID: 2052 RVA: 0x00012E1E File Offset: 0x0001101E
		string ContentDescription
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

		// Token: 0x06000805 RID: 2053 RVA: 0x00012E35 File Offset: 0x00011035
		private static Delegate GetGetIconTintBlendModeHandler()
		{
			if (IMenuItem.cb_getIconTintBlendMode == null)
			{
				IMenuItem.cb_getIconTintBlendMode = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IMenuItem.n_GetIconTintBlendMode));
			}
			return IMenuItem.cb_getIconTintBlendMode;
		}

		// Token: 0x06000806 RID: 2054 RVA: 0x00012E59 File Offset: 0x00011059
		private static IntPtr n_GetIconTintBlendMode(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IMenuItem>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IconTintBlendMode);
		}

		// Token: 0x17000199 RID: 409
		// (get) Token: 0x06000807 RID: 2055 RVA: 0x00012E70 File Offset: 0x00011070
		BlendMode IconTintBlendMode
		{
			get
			{
				return Java.Lang.Object.GetObject<BlendMode>(IMenuItem._members.InstanceMethods.InvokeVirtualObjectMethod("getIconTintBlendMode.()Landroid/graphics/BlendMode;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06000808 RID: 2056 RVA: 0x00012EA2 File Offset: 0x000110A2
		private static Delegate GetGetIconTintListHandler()
		{
			if (IMenuItem.cb_getIconTintList == null)
			{
				IMenuItem.cb_getIconTintList = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IMenuItem.n_GetIconTintList));
			}
			return IMenuItem.cb_getIconTintList;
		}

		// Token: 0x06000809 RID: 2057 RVA: 0x00012EC6 File Offset: 0x000110C6
		private static IntPtr n_GetIconTintList(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IMenuItem>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IconTintList);
		}

		// Token: 0x1700019A RID: 410
		// (get) Token: 0x0600080A RID: 2058 RVA: 0x00012EDC File Offset: 0x000110DC
		ColorStateList IconTintList
		{
			get
			{
				return Java.Lang.Object.GetObject<ColorStateList>(IMenuItem._members.InstanceMethods.InvokeVirtualObjectMethod("getIconTintList.()Landroid/content/res/ColorStateList;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x0600080B RID: 2059 RVA: 0x00012F0E File Offset: 0x0001110E
		private static Delegate GetGetIconTintModeHandler()
		{
			if (IMenuItem.cb_getIconTintMode == null)
			{
				IMenuItem.cb_getIconTintMode = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IMenuItem.n_GetIconTintMode));
			}
			return IMenuItem.cb_getIconTintMode;
		}

		// Token: 0x0600080C RID: 2060 RVA: 0x00012F32 File Offset: 0x00011132
		private static IntPtr n_GetIconTintMode(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IMenuItem>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IconTintMode);
		}

		// Token: 0x1700019B RID: 411
		// (get) Token: 0x0600080D RID: 2061 RVA: 0x00012F48 File Offset: 0x00011148
		PorterDuff.Mode IconTintMode
		{
			get
			{
				return Java.Lang.Object.GetObject<PorterDuff.Mode>(IMenuItem._members.InstanceMethods.InvokeVirtualObjectMethod("getIconTintMode.()Landroid/graphics/PorterDuff$Mode;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x0600080E RID: 2062 RVA: 0x00012F7A File Offset: 0x0001117A
		private static Delegate GetGetNumericModifiersHandler()
		{
			if (IMenuItem.cb_getNumericModifiers == null)
			{
				IMenuItem.cb_getNumericModifiers = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(IMenuItem.n_GetNumericModifiers));
			}
			return IMenuItem.cb_getNumericModifiers;
		}

		// Token: 0x0600080F RID: 2063 RVA: 0x00012F9E File Offset: 0x0001119E
		private static int n_GetNumericModifiers(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IMenuItem>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).NumericModifiers;
		}

		// Token: 0x1700019C RID: 412
		// (get) Token: 0x06000810 RID: 2064 RVA: 0x00012FAD File Offset: 0x000111AD
		int NumericModifiers
		{
			get
			{
				return IMenuItem._members.InstanceMethods.InvokeVirtualInt32Method("getNumericModifiers.()I", this, null);
			}
		}

		// Token: 0x06000811 RID: 2065 RVA: 0x00012FC6 File Offset: 0x000111C6
		private static Delegate GetGetTooltipTextHandler()
		{
			if (IMenuItem.cb_getTooltipText == null)
			{
				IMenuItem.cb_getTooltipText = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IMenuItem.n_GetTooltipText));
			}
			return IMenuItem.cb_getTooltipText;
		}

		// Token: 0x06000812 RID: 2066 RVA: 0x00012FEA File Offset: 0x000111EA
		private static IntPtr n_GetTooltipText(IntPtr jnienv, IntPtr native__this)
		{
			return CharSequence.ToLocalJniHandle(Java.Lang.Object.GetObject<IMenuItem>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).TooltipTextFormatted);
		}

		// Token: 0x1700019D RID: 413
		// (get) Token: 0x06000813 RID: 2067 RVA: 0x00013000 File Offset: 0x00011200
		ICharSequence TooltipTextFormatted
		{
			get
			{
				return Java.Lang.Object.GetObject<ICharSequence>(IMenuItem._members.InstanceMethods.InvokeVirtualObjectMethod("getTooltipText.()Ljava/lang/CharSequence;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x1700019E RID: 414
		// (get) Token: 0x06000814 RID: 2068 RVA: 0x00013032 File Offset: 0x00011232
		string TooltipText
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

		// Token: 0x06000815 RID: 2069
		bool CollapseActionView();

		// Token: 0x06000816 RID: 2070
		bool ExpandActionView();

		// Token: 0x06000817 RID: 2071
		IMenuItem SetActionProvider(ActionProvider actionProvider);

		// Token: 0x06000818 RID: 2072
		IMenuItem SetActionView(View view);

		// Token: 0x06000819 RID: 2073
		IMenuItem SetActionView(int resId);

		// Token: 0x0600081A RID: 2074
		IMenuItem SetAlphabeticShortcut(char alphaChar);

		// Token: 0x0600081B RID: 2075
		IMenuItem SetCheckable(bool checkable);

		// Token: 0x0600081C RID: 2076
		IMenuItem SetChecked(bool @checked);

		// Token: 0x0600081D RID: 2077
		IMenuItem SetEnabled(bool enabled);

		// Token: 0x0600081E RID: 2078
		IMenuItem SetIcon(Drawable icon);

		// Token: 0x0600081F RID: 2079
		IMenuItem SetIcon(int iconRes);

		// Token: 0x06000820 RID: 2080
		IMenuItem SetIntent(Intent intent);

		// Token: 0x06000821 RID: 2081
		IMenuItem SetNumericShortcut(char numericChar);

		// Token: 0x06000822 RID: 2082
		IMenuItem SetOnActionExpandListener(IMenuItemOnActionExpandListener listener);

		// Token: 0x06000823 RID: 2083
		IMenuItem SetOnMenuItemClickListener(IMenuItemOnMenuItemClickListener menuItemClickListener);

		// Token: 0x06000824 RID: 2084
		IMenuItem SetShortcut(char numericChar, char alphaChar);

		// Token: 0x06000825 RID: 2085
		void SetShowAsAction([GeneratedEnum] ShowAsAction actionEnum);

		// Token: 0x06000826 RID: 2086
		IMenuItem SetShowAsActionFlags([GeneratedEnum] ShowAsAction actionEnum);

		// Token: 0x06000827 RID: 2087
		IMenuItem SetTitle(int title);

		// Token: 0x06000828 RID: 2088
		IMenuItem SetTitle(ICharSequence title);

		// Token: 0x06000829 RID: 2089
		IMenuItem SetTitleCondensed(ICharSequence title);

		// Token: 0x0600082A RID: 2090
		IMenuItem SetVisible(bool visible);

		// Token: 0x0600082B RID: 2091 RVA: 0x00013049 File Offset: 0x00011249
		private static Delegate GetSetAlphabeticShortcut_CIHandler()
		{
			if (IMenuItem.cb_setAlphabeticShortcut_CI == null)
			{
				IMenuItem.cb_setAlphabeticShortcut_CI = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPCI_L(IMenuItem.n_SetAlphabeticShortcut_CI));
			}
			return IMenuItem.cb_setAlphabeticShortcut_CI;
		}

		// Token: 0x0600082C RID: 2092 RVA: 0x0001306D File Offset: 0x0001126D
		private static IntPtr n_SetAlphabeticShortcut_CI(IntPtr jnienv, IntPtr native__this, char alphaChar, int alphaModifiers)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IMenuItem>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SetAlphabeticShortcut(alphaChar, alphaModifiers));
		}

		// Token: 0x0600082D RID: 2093 RVA: 0x00013084 File Offset: 0x00011284
		unsafe IMenuItem SetAlphabeticShortcut(char alphaChar, int alphaModifiers)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(alphaChar);
			ptr[1] = new JniArgumentValue(alphaModifiers);
			return Java.Lang.Object.GetObject<IMenuItem>(IMenuItem._members.InstanceMethods.InvokeVirtualObjectMethod("setAlphabeticShortcut.(CI)Landroid/view/MenuItem;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x0600082E RID: 2094 RVA: 0x000130E0 File Offset: 0x000112E0
		private static Delegate GetSetContentDescription_Ljava_lang_CharSequence_Handler()
		{
			if (IMenuItem.cb_setContentDescription_Ljava_lang_CharSequence_ == null)
			{
				IMenuItem.cb_setContentDescription_Ljava_lang_CharSequence_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(IMenuItem.n_SetContentDescription_Ljava_lang_CharSequence_));
			}
			return IMenuItem.cb_setContentDescription_Ljava_lang_CharSequence_;
		}

		// Token: 0x0600082F RID: 2095 RVA: 0x00013104 File Offset: 0x00011304
		private static IntPtr n_SetContentDescription_Ljava_lang_CharSequence_(IntPtr jnienv, IntPtr native__this, IntPtr native_contentDescription)
		{
			IMenuItem @object = Java.Lang.Object.GetObject<IMenuItem>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ICharSequence object2 = Java.Lang.Object.GetObject<ICharSequence>(native_contentDescription, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.SetContentDescription(object2));
		}

		// Token: 0x06000830 RID: 2096 RVA: 0x0001312C File Offset: 0x0001132C
		unsafe IMenuItem SetContentDescription(ICharSequence contentDescription)
		{
			IntPtr intPtr = CharSequence.ToLocalJniHandle(contentDescription);
			IMenuItem @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<IMenuItem>(IMenuItem._members.InstanceMethods.InvokeVirtualObjectMethod("setContentDescription.(Ljava/lang/CharSequence;)Landroid/view/MenuItem;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(contentDescription);
			}
			return @object;
		}

		// Token: 0x06000831 RID: 2097 RVA: 0x000131A0 File Offset: 0x000113A0
		IMenuItem SetContentDescription(string contentDescription)
		{
			Java.Lang.String @string = (contentDescription == null) ? null : new Java.Lang.String(contentDescription);
			IMenuItem result = this.SetContentDescription(@string);
			if (@string != null)
			{
				@string.Dispose();
			}
			return result;
		}

		// Token: 0x06000832 RID: 2098 RVA: 0x000131CA File Offset: 0x000113CA
		private static Delegate GetSetIconTintBlendMode_Landroid_graphics_BlendMode_Handler()
		{
			if (IMenuItem.cb_setIconTintBlendMode_Landroid_graphics_BlendMode_ == null)
			{
				IMenuItem.cb_setIconTintBlendMode_Landroid_graphics_BlendMode_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(IMenuItem.n_SetIconTintBlendMode_Landroid_graphics_BlendMode_));
			}
			return IMenuItem.cb_setIconTintBlendMode_Landroid_graphics_BlendMode_;
		}

		// Token: 0x06000833 RID: 2099 RVA: 0x000131F0 File Offset: 0x000113F0
		private static IntPtr n_SetIconTintBlendMode_Landroid_graphics_BlendMode_(IntPtr jnienv, IntPtr native__this, IntPtr native_blendMode)
		{
			IMenuItem @object = Java.Lang.Object.GetObject<IMenuItem>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			BlendMode object2 = Java.Lang.Object.GetObject<BlendMode>(native_blendMode, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.SetIconTintBlendMode(object2));
		}

		// Token: 0x06000834 RID: 2100 RVA: 0x00013218 File Offset: 0x00011418
		unsafe IMenuItem SetIconTintBlendMode(BlendMode blendMode)
		{
			IMenuItem @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((blendMode == null) ? IntPtr.Zero : blendMode.Handle);
				@object = Java.Lang.Object.GetObject<IMenuItem>(IMenuItem._members.InstanceMethods.InvokeVirtualObjectMethod("setIconTintBlendMode.(Landroid/graphics/BlendMode;)Landroid/view/MenuItem;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(blendMode);
			}
			return @object;
		}

		// Token: 0x06000835 RID: 2101 RVA: 0x0001328C File Offset: 0x0001148C
		private static Delegate GetSetIconTintList_Landroid_content_res_ColorStateList_Handler()
		{
			if (IMenuItem.cb_setIconTintList_Landroid_content_res_ColorStateList_ == null)
			{
				IMenuItem.cb_setIconTintList_Landroid_content_res_ColorStateList_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(IMenuItem.n_SetIconTintList_Landroid_content_res_ColorStateList_));
			}
			return IMenuItem.cb_setIconTintList_Landroid_content_res_ColorStateList_;
		}

		// Token: 0x06000836 RID: 2102 RVA: 0x000132B0 File Offset: 0x000114B0
		private static IntPtr n_SetIconTintList_Landroid_content_res_ColorStateList_(IntPtr jnienv, IntPtr native__this, IntPtr native_tint)
		{
			IMenuItem @object = Java.Lang.Object.GetObject<IMenuItem>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ColorStateList object2 = Java.Lang.Object.GetObject<ColorStateList>(native_tint, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.SetIconTintList(object2));
		}

		// Token: 0x06000837 RID: 2103 RVA: 0x000132D8 File Offset: 0x000114D8
		unsafe IMenuItem SetIconTintList(ColorStateList tint)
		{
			IMenuItem @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((tint == null) ? IntPtr.Zero : tint.Handle);
				@object = Java.Lang.Object.GetObject<IMenuItem>(IMenuItem._members.InstanceMethods.InvokeVirtualObjectMethod("setIconTintList.(Landroid/content/res/ColorStateList;)Landroid/view/MenuItem;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(tint);
			}
			return @object;
		}

		// Token: 0x06000838 RID: 2104 RVA: 0x0001334C File Offset: 0x0001154C
		private static Delegate GetSetIconTintMode_Landroid_graphics_PorterDuff_Mode_Handler()
		{
			if (IMenuItem.cb_setIconTintMode_Landroid_graphics_PorterDuff_Mode_ == null)
			{
				IMenuItem.cb_setIconTintMode_Landroid_graphics_PorterDuff_Mode_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(IMenuItem.n_SetIconTintMode_Landroid_graphics_PorterDuff_Mode_));
			}
			return IMenuItem.cb_setIconTintMode_Landroid_graphics_PorterDuff_Mode_;
		}

		// Token: 0x06000839 RID: 2105 RVA: 0x00013370 File Offset: 0x00011570
		private static IntPtr n_SetIconTintMode_Landroid_graphics_PorterDuff_Mode_(IntPtr jnienv, IntPtr native__this, IntPtr native_tintMode)
		{
			IMenuItem @object = Java.Lang.Object.GetObject<IMenuItem>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			PorterDuff.Mode object2 = Java.Lang.Object.GetObject<PorterDuff.Mode>(native_tintMode, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.SetIconTintMode(object2));
		}

		// Token: 0x0600083A RID: 2106 RVA: 0x00013398 File Offset: 0x00011598
		unsafe IMenuItem SetIconTintMode(PorterDuff.Mode tintMode)
		{
			IMenuItem @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((tintMode == null) ? IntPtr.Zero : tintMode.Handle);
				@object = Java.Lang.Object.GetObject<IMenuItem>(IMenuItem._members.InstanceMethods.InvokeVirtualObjectMethod("setIconTintMode.(Landroid/graphics/PorterDuff$Mode;)Landroid/view/MenuItem;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(tintMode);
			}
			return @object;
		}

		// Token: 0x0600083B RID: 2107 RVA: 0x0001340C File Offset: 0x0001160C
		private static Delegate GetSetNumericShortcut_CIHandler()
		{
			if (IMenuItem.cb_setNumericShortcut_CI == null)
			{
				IMenuItem.cb_setNumericShortcut_CI = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPCI_L(IMenuItem.n_SetNumericShortcut_CI));
			}
			return IMenuItem.cb_setNumericShortcut_CI;
		}

		// Token: 0x0600083C RID: 2108 RVA: 0x00013430 File Offset: 0x00011630
		private static IntPtr n_SetNumericShortcut_CI(IntPtr jnienv, IntPtr native__this, char numericChar, int numericModifiers)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IMenuItem>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SetNumericShortcut(numericChar, numericModifiers));
		}

		// Token: 0x0600083D RID: 2109 RVA: 0x00013448 File Offset: 0x00011648
		unsafe IMenuItem SetNumericShortcut(char numericChar, int numericModifiers)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(numericChar);
			ptr[1] = new JniArgumentValue(numericModifiers);
			return Java.Lang.Object.GetObject<IMenuItem>(IMenuItem._members.InstanceMethods.InvokeVirtualObjectMethod("setNumericShortcut.(CI)Landroid/view/MenuItem;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x0600083E RID: 2110 RVA: 0x000134A4 File Offset: 0x000116A4
		private static Delegate GetSetShortcut_CCIIHandler()
		{
			if (IMenuItem.cb_setShortcut_CCII == null)
			{
				IMenuItem.cb_setShortcut_CCII = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPCCII_L(IMenuItem.n_SetShortcut_CCII));
			}
			return IMenuItem.cb_setShortcut_CCII;
		}

		// Token: 0x0600083F RID: 2111 RVA: 0x000134C8 File Offset: 0x000116C8
		private static IntPtr n_SetShortcut_CCII(IntPtr jnienv, IntPtr native__this, char numericChar, char alphaChar, int numericModifiers, int alphaModifiers)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IMenuItem>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SetShortcut(numericChar, alphaChar, numericModifiers, alphaModifiers));
		}

		// Token: 0x06000840 RID: 2112 RVA: 0x000134E4 File Offset: 0x000116E4
		unsafe IMenuItem SetShortcut(char numericChar, char alphaChar, int numericModifiers, int alphaModifiers)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(numericChar);
			ptr[1] = new JniArgumentValue(alphaChar);
			ptr[2] = new JniArgumentValue(numericModifiers);
			ptr[3] = new JniArgumentValue(alphaModifiers);
			return Java.Lang.Object.GetObject<IMenuItem>(IMenuItem._members.InstanceMethods.InvokeVirtualObjectMethod("setShortcut.(CCII)Landroid/view/MenuItem;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06000841 RID: 2113 RVA: 0x0001356D File Offset: 0x0001176D
		private static Delegate GetSetTooltipText_Ljava_lang_CharSequence_Handler()
		{
			if (IMenuItem.cb_setTooltipText_Ljava_lang_CharSequence_ == null)
			{
				IMenuItem.cb_setTooltipText_Ljava_lang_CharSequence_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(IMenuItem.n_SetTooltipText_Ljava_lang_CharSequence_));
			}
			return IMenuItem.cb_setTooltipText_Ljava_lang_CharSequence_;
		}

		// Token: 0x06000842 RID: 2114 RVA: 0x00013594 File Offset: 0x00011794
		private static IntPtr n_SetTooltipText_Ljava_lang_CharSequence_(IntPtr jnienv, IntPtr native__this, IntPtr native_tooltipText)
		{
			IMenuItem @object = Java.Lang.Object.GetObject<IMenuItem>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ICharSequence object2 = Java.Lang.Object.GetObject<ICharSequence>(native_tooltipText, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.SetTooltipText(object2));
		}

		// Token: 0x06000843 RID: 2115 RVA: 0x000135BC File Offset: 0x000117BC
		unsafe IMenuItem SetTooltipText(ICharSequence tooltipText)
		{
			IntPtr intPtr = CharSequence.ToLocalJniHandle(tooltipText);
			IMenuItem @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<IMenuItem>(IMenuItem._members.InstanceMethods.InvokeVirtualObjectMethod("setTooltipText.(Ljava/lang/CharSequence;)Landroid/view/MenuItem;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(tooltipText);
			}
			return @object;
		}

		// Token: 0x06000844 RID: 2116 RVA: 0x00013630 File Offset: 0x00011830
		IMenuItem SetTooltipText(string tooltipText)
		{
			Java.Lang.String @string = (tooltipText == null) ? null : new Java.Lang.String(tooltipText);
			IMenuItem result = this.SetTooltipText(@string);
			if (@string != null)
			{
				@string.Dispose();
			}
			return result;
		}

		// Token: 0x04000240 RID: 576
		private static readonly JniPeerMembers _members = new XAPeerMembers("android/view/MenuItem", typeof(IMenuItem), true);

		// Token: 0x04000241 RID: 577
		private static Delegate cb_getAlphabeticModifiers;

		// Token: 0x04000242 RID: 578
		private static Delegate cb_getContentDescription;

		// Token: 0x04000243 RID: 579
		private static Delegate cb_getIconTintBlendMode;

		// Token: 0x04000244 RID: 580
		private static Delegate cb_getIconTintList;

		// Token: 0x04000245 RID: 581
		private static Delegate cb_getIconTintMode;

		// Token: 0x04000246 RID: 582
		private static Delegate cb_getNumericModifiers;

		// Token: 0x04000247 RID: 583
		private static Delegate cb_getTooltipText;

		// Token: 0x04000248 RID: 584
		private static Delegate cb_setAlphabeticShortcut_CI;

		// Token: 0x04000249 RID: 585
		private static Delegate cb_setContentDescription_Ljava_lang_CharSequence_;

		// Token: 0x0400024A RID: 586
		private static Delegate cb_setIconTintBlendMode_Landroid_graphics_BlendMode_;

		// Token: 0x0400024B RID: 587
		private static Delegate cb_setIconTintList_Landroid_content_res_ColorStateList_;

		// Token: 0x0400024C RID: 588
		private static Delegate cb_setIconTintMode_Landroid_graphics_PorterDuff_Mode_;

		// Token: 0x0400024D RID: 589
		private static Delegate cb_setNumericShortcut_CI;

		// Token: 0x0400024E RID: 590
		private static Delegate cb_setShortcut_CCII;

		// Token: 0x0400024F RID: 591
		private static Delegate cb_setTooltipText_Ljava_lang_CharSequence_;
	}
}
