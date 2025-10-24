using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Content;
using Android.Content.Res;
using Android.Graphics;
using Android.Runtime;
using Android.Util;
using Android.Widget;
using AndroidX.Core.View;
using AndroidX.Core.Widget;
using Java.Interop;
using Java.Lang;

namespace AndroidX.AppCompat.Widget
{
	// Token: 0x02000065 RID: 101
	[Register("androidx/appcompat/widget/AppCompatCheckBox", DoNotGenerateAcw = true)]
	public class AppCompatCheckBox : CheckBox, IEmojiCompatConfigurationView, IJavaObject, IDisposable, IJavaPeerable, ITintableBackgroundView, ITintableCompoundButton, ITintableCompoundDrawablesView
	{
		// Token: 0x170000D5 RID: 213
		// (get) Token: 0x06000660 RID: 1632 RVA: 0x00010D5C File Offset: 0x0000EF5C
		internal static IntPtr class_ref
		{
			get
			{
				return AppCompatCheckBox._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170000D6 RID: 214
		// (get) Token: 0x06000661 RID: 1633 RVA: 0x00010D80 File Offset: 0x0000EF80
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return AppCompatCheckBox._members;
			}
		}

		// Token: 0x170000D7 RID: 215
		// (get) Token: 0x06000662 RID: 1634 RVA: 0x00010D88 File Offset: 0x0000EF88
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return AppCompatCheckBox._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170000D8 RID: 216
		// (get) Token: 0x06000663 RID: 1635 RVA: 0x00010DAC File Offset: 0x0000EFAC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return AppCompatCheckBox._members.ManagedPeerType;
			}
		}

		// Token: 0x06000664 RID: 1636 RVA: 0x00010DB8 File Offset: 0x0000EFB8
		protected AppCompatCheckBox(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000665 RID: 1637 RVA: 0x00010DC4 File Offset: 0x0000EFC4
		[Register(".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe AppCompatCheckBox(Context context) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((context == null) ? IntPtr.Zero : context.Handle);
				base.SetHandle(AppCompatCheckBox._members.InstanceMethods.StartCreateInstance("(Landroid/content/Context;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				AppCompatCheckBox._members.InstanceMethods.FinishCreateInstance("(Landroid/content/Context;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(context);
			}
		}

		// Token: 0x06000666 RID: 1638 RVA: 0x00010E74 File Offset: 0x0000F074
		[Register(".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", "")]
		public unsafe AppCompatCheckBox(Context context, IAttributeSet attrs) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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
				base.SetHandle(AppCompatCheckBox._members.InstanceMethods.StartCreateInstance("(Landroid/content/Context;Landroid/util/AttributeSet;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				AppCompatCheckBox._members.InstanceMethods.FinishCreateInstance("(Landroid/content/Context;Landroid/util/AttributeSet;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(context);
				GC.KeepAlive(attrs);
			}
		}

		// Token: 0x06000667 RID: 1639 RVA: 0x00010F50 File Offset: 0x0000F150
		[Register(".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", "")]
		public unsafe AppCompatCheckBox(Context context, IAttributeSet attrs, int defStyleAttr) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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
				base.SetHandle(AppCompatCheckBox._members.InstanceMethods.StartCreateInstance("(Landroid/content/Context;Landroid/util/AttributeSet;I)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				AppCompatCheckBox._members.InstanceMethods.FinishCreateInstance("(Landroid/content/Context;Landroid/util/AttributeSet;I)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(context);
				GC.KeepAlive(attrs);
			}
		}

		// Token: 0x06000668 RID: 1640 RVA: 0x00011040 File Offset: 0x0000F240
		private static Delegate GetIsEmojiCompatEnabledHandler()
		{
			if (AppCompatCheckBox.cb_isEmojiCompatEnabled == null)
			{
				AppCompatCheckBox.cb_isEmojiCompatEnabled = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(AppCompatCheckBox.n_IsEmojiCompatEnabled));
			}
			return AppCompatCheckBox.cb_isEmojiCompatEnabled;
		}

		// Token: 0x06000669 RID: 1641 RVA: 0x00011064 File Offset: 0x0000F264
		private static bool n_IsEmojiCompatEnabled(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<AppCompatCheckBox>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).EmojiCompatEnabled;
		}

		// Token: 0x0600066A RID: 1642 RVA: 0x00011073 File Offset: 0x0000F273
		private static Delegate GetSetEmojiCompatEnabled_ZHandler()
		{
			if (AppCompatCheckBox.cb_setEmojiCompatEnabled_Z == null)
			{
				AppCompatCheckBox.cb_setEmojiCompatEnabled_Z = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPZ_V(AppCompatCheckBox.n_SetEmojiCompatEnabled_Z));
			}
			return AppCompatCheckBox.cb_setEmojiCompatEnabled_Z;
		}

		// Token: 0x0600066B RID: 1643 RVA: 0x00011097 File Offset: 0x0000F297
		private static void n_SetEmojiCompatEnabled_Z(IntPtr jnienv, IntPtr native__this, bool enabled)
		{
			Java.Lang.Object.GetObject<AppCompatCheckBox>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).EmojiCompatEnabled = enabled;
		}

		// Token: 0x170000D9 RID: 217
		// (get) Token: 0x0600066C RID: 1644 RVA: 0x000110A7 File Offset: 0x0000F2A7
		// (set) Token: 0x0600066D RID: 1645 RVA: 0x000110C0 File Offset: 0x0000F2C0
		public unsafe virtual bool EmojiCompatEnabled
		{
			[Register("isEmojiCompatEnabled", "()Z", "GetIsEmojiCompatEnabledHandler")]
			get
			{
				return AppCompatCheckBox._members.InstanceMethods.InvokeVirtualBooleanMethod("isEmojiCompatEnabled.()Z", this, null);
			}
			[Register("setEmojiCompatEnabled", "(Z)V", "GetSetEmojiCompatEnabled_ZHandler")]
			set
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(value);
				AppCompatCheckBox._members.InstanceMethods.InvokeVirtualVoidMethod("setEmojiCompatEnabled.(Z)V", this, ptr);
			}
		}

		// Token: 0x0600066E RID: 1646 RVA: 0x000110FB File Offset: 0x0000F2FB
		private static Delegate GetGetSupportBackgroundTintListHandler()
		{
			if (AppCompatCheckBox.cb_getSupportBackgroundTintList == null)
			{
				AppCompatCheckBox.cb_getSupportBackgroundTintList = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(AppCompatCheckBox.n_GetSupportBackgroundTintList));
			}
			return AppCompatCheckBox.cb_getSupportBackgroundTintList;
		}

		// Token: 0x0600066F RID: 1647 RVA: 0x0001111F File Offset: 0x0000F31F
		private static IntPtr n_GetSupportBackgroundTintList(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<AppCompatCheckBox>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SupportBackgroundTintList);
		}

		// Token: 0x06000670 RID: 1648 RVA: 0x00011133 File Offset: 0x0000F333
		private static Delegate GetSetSupportBackgroundTintList_Landroid_content_res_ColorStateList_Handler()
		{
			if (AppCompatCheckBox.cb_setSupportBackgroundTintList_Landroid_content_res_ColorStateList_ == null)
			{
				AppCompatCheckBox.cb_setSupportBackgroundTintList_Landroid_content_res_ColorStateList_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(AppCompatCheckBox.n_SetSupportBackgroundTintList_Landroid_content_res_ColorStateList_));
			}
			return AppCompatCheckBox.cb_setSupportBackgroundTintList_Landroid_content_res_ColorStateList_;
		}

		// Token: 0x06000671 RID: 1649 RVA: 0x00011158 File Offset: 0x0000F358
		private static void n_SetSupportBackgroundTintList_Landroid_content_res_ColorStateList_(IntPtr jnienv, IntPtr native__this, IntPtr native_tint)
		{
			AppCompatCheckBox @object = Java.Lang.Object.GetObject<AppCompatCheckBox>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ColorStateList object2 = Java.Lang.Object.GetObject<ColorStateList>(native_tint, JniHandleOwnership.DoNotTransfer);
			@object.SupportBackgroundTintList = object2;
		}

		// Token: 0x170000DA RID: 218
		// (get) Token: 0x06000672 RID: 1650 RVA: 0x0001117C File Offset: 0x0000F37C
		// (set) Token: 0x06000673 RID: 1651 RVA: 0x000111B0 File Offset: 0x0000F3B0
		public unsafe virtual ColorStateList SupportBackgroundTintList
		{
			[Register("getSupportBackgroundTintList", "()Landroid/content/res/ColorStateList;", "GetGetSupportBackgroundTintListHandler")]
			get
			{
				return Java.Lang.Object.GetObject<ColorStateList>(AppCompatCheckBox._members.InstanceMethods.InvokeVirtualObjectMethod("getSupportBackgroundTintList.()Landroid/content/res/ColorStateList;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
			[Register("setSupportBackgroundTintList", "(Landroid/content/res/ColorStateList;)V", "GetSetSupportBackgroundTintList_Landroid_content_res_ColorStateList_Handler")]
			set
			{
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((value == null) ? IntPtr.Zero : value.Handle);
					AppCompatCheckBox._members.InstanceMethods.InvokeVirtualVoidMethod("setSupportBackgroundTintList.(Landroid/content/res/ColorStateList;)V", this, ptr);
				}
				finally
				{
					GC.KeepAlive(value);
				}
			}
		}

		// Token: 0x06000674 RID: 1652 RVA: 0x00011214 File Offset: 0x0000F414
		private static Delegate GetGetSupportBackgroundTintModeHandler()
		{
			if (AppCompatCheckBox.cb_getSupportBackgroundTintMode == null)
			{
				AppCompatCheckBox.cb_getSupportBackgroundTintMode = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(AppCompatCheckBox.n_GetSupportBackgroundTintMode));
			}
			return AppCompatCheckBox.cb_getSupportBackgroundTintMode;
		}

		// Token: 0x06000675 RID: 1653 RVA: 0x00011238 File Offset: 0x0000F438
		private static IntPtr n_GetSupportBackgroundTintMode(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<AppCompatCheckBox>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SupportBackgroundTintMode);
		}

		// Token: 0x06000676 RID: 1654 RVA: 0x0001124C File Offset: 0x0000F44C
		private static Delegate GetSetSupportBackgroundTintMode_Landroid_graphics_PorterDuff_Mode_Handler()
		{
			if (AppCompatCheckBox.cb_setSupportBackgroundTintMode_Landroid_graphics_PorterDuff_Mode_ == null)
			{
				AppCompatCheckBox.cb_setSupportBackgroundTintMode_Landroid_graphics_PorterDuff_Mode_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(AppCompatCheckBox.n_SetSupportBackgroundTintMode_Landroid_graphics_PorterDuff_Mode_));
			}
			return AppCompatCheckBox.cb_setSupportBackgroundTintMode_Landroid_graphics_PorterDuff_Mode_;
		}

		// Token: 0x06000677 RID: 1655 RVA: 0x00011270 File Offset: 0x0000F470
		private static void n_SetSupportBackgroundTintMode_Landroid_graphics_PorterDuff_Mode_(IntPtr jnienv, IntPtr native__this, IntPtr native_tintMode)
		{
			AppCompatCheckBox @object = Java.Lang.Object.GetObject<AppCompatCheckBox>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			PorterDuff.Mode object2 = Java.Lang.Object.GetObject<PorterDuff.Mode>(native_tintMode, JniHandleOwnership.DoNotTransfer);
			@object.SupportBackgroundTintMode = object2;
		}

		// Token: 0x170000DB RID: 219
		// (get) Token: 0x06000678 RID: 1656 RVA: 0x00011294 File Offset: 0x0000F494
		// (set) Token: 0x06000679 RID: 1657 RVA: 0x000112C8 File Offset: 0x0000F4C8
		public unsafe virtual PorterDuff.Mode SupportBackgroundTintMode
		{
			[Register("getSupportBackgroundTintMode", "()Landroid/graphics/PorterDuff$Mode;", "GetGetSupportBackgroundTintModeHandler")]
			get
			{
				return Java.Lang.Object.GetObject<PorterDuff.Mode>(AppCompatCheckBox._members.InstanceMethods.InvokeVirtualObjectMethod("getSupportBackgroundTintMode.()Landroid/graphics/PorterDuff$Mode;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
			[Register("setSupportBackgroundTintMode", "(Landroid/graphics/PorterDuff$Mode;)V", "GetSetSupportBackgroundTintMode_Landroid_graphics_PorterDuff_Mode_Handler")]
			set
			{
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((value == null) ? IntPtr.Zero : value.Handle);
					AppCompatCheckBox._members.InstanceMethods.InvokeVirtualVoidMethod("setSupportBackgroundTintMode.(Landroid/graphics/PorterDuff$Mode;)V", this, ptr);
				}
				finally
				{
					GC.KeepAlive(value);
				}
			}
		}

		// Token: 0x0600067A RID: 1658 RVA: 0x0001132C File Offset: 0x0000F52C
		private static Delegate GetGetSupportButtonTintListHandler()
		{
			if (AppCompatCheckBox.cb_getSupportButtonTintList == null)
			{
				AppCompatCheckBox.cb_getSupportButtonTintList = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(AppCompatCheckBox.n_GetSupportButtonTintList));
			}
			return AppCompatCheckBox.cb_getSupportButtonTintList;
		}

		// Token: 0x0600067B RID: 1659 RVA: 0x00011350 File Offset: 0x0000F550
		private static IntPtr n_GetSupportButtonTintList(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<AppCompatCheckBox>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SupportButtonTintList);
		}

		// Token: 0x0600067C RID: 1660 RVA: 0x00011364 File Offset: 0x0000F564
		private static Delegate GetSetSupportButtonTintList_Landroid_content_res_ColorStateList_Handler()
		{
			if (AppCompatCheckBox.cb_setSupportButtonTintList_Landroid_content_res_ColorStateList_ == null)
			{
				AppCompatCheckBox.cb_setSupportButtonTintList_Landroid_content_res_ColorStateList_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(AppCompatCheckBox.n_SetSupportButtonTintList_Landroid_content_res_ColorStateList_));
			}
			return AppCompatCheckBox.cb_setSupportButtonTintList_Landroid_content_res_ColorStateList_;
		}

		// Token: 0x0600067D RID: 1661 RVA: 0x00011388 File Offset: 0x0000F588
		private static void n_SetSupportButtonTintList_Landroid_content_res_ColorStateList_(IntPtr jnienv, IntPtr native__this, IntPtr native_tint)
		{
			AppCompatCheckBox @object = Java.Lang.Object.GetObject<AppCompatCheckBox>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ColorStateList object2 = Java.Lang.Object.GetObject<ColorStateList>(native_tint, JniHandleOwnership.DoNotTransfer);
			@object.SupportButtonTintList = object2;
		}

		// Token: 0x170000DC RID: 220
		// (get) Token: 0x0600067E RID: 1662 RVA: 0x000113AC File Offset: 0x0000F5AC
		// (set) Token: 0x0600067F RID: 1663 RVA: 0x000113E0 File Offset: 0x0000F5E0
		public unsafe virtual ColorStateList SupportButtonTintList
		{
			[Register("getSupportButtonTintList", "()Landroid/content/res/ColorStateList;", "GetGetSupportButtonTintListHandler")]
			get
			{
				return Java.Lang.Object.GetObject<ColorStateList>(AppCompatCheckBox._members.InstanceMethods.InvokeVirtualObjectMethod("getSupportButtonTintList.()Landroid/content/res/ColorStateList;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
			[Register("setSupportButtonTintList", "(Landroid/content/res/ColorStateList;)V", "GetSetSupportButtonTintList_Landroid_content_res_ColorStateList_Handler")]
			set
			{
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((value == null) ? IntPtr.Zero : value.Handle);
					AppCompatCheckBox._members.InstanceMethods.InvokeVirtualVoidMethod("setSupportButtonTintList.(Landroid/content/res/ColorStateList;)V", this, ptr);
				}
				finally
				{
					GC.KeepAlive(value);
				}
			}
		}

		// Token: 0x06000680 RID: 1664 RVA: 0x00011444 File Offset: 0x0000F644
		private static Delegate GetGetSupportButtonTintModeHandler()
		{
			if (AppCompatCheckBox.cb_getSupportButtonTintMode == null)
			{
				AppCompatCheckBox.cb_getSupportButtonTintMode = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(AppCompatCheckBox.n_GetSupportButtonTintMode));
			}
			return AppCompatCheckBox.cb_getSupportButtonTintMode;
		}

		// Token: 0x06000681 RID: 1665 RVA: 0x00011468 File Offset: 0x0000F668
		private static IntPtr n_GetSupportButtonTintMode(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<AppCompatCheckBox>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SupportButtonTintMode);
		}

		// Token: 0x06000682 RID: 1666 RVA: 0x0001147C File Offset: 0x0000F67C
		private static Delegate GetSetSupportButtonTintMode_Landroid_graphics_PorterDuff_Mode_Handler()
		{
			if (AppCompatCheckBox.cb_setSupportButtonTintMode_Landroid_graphics_PorterDuff_Mode_ == null)
			{
				AppCompatCheckBox.cb_setSupportButtonTintMode_Landroid_graphics_PorterDuff_Mode_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(AppCompatCheckBox.n_SetSupportButtonTintMode_Landroid_graphics_PorterDuff_Mode_));
			}
			return AppCompatCheckBox.cb_setSupportButtonTintMode_Landroid_graphics_PorterDuff_Mode_;
		}

		// Token: 0x06000683 RID: 1667 RVA: 0x000114A0 File Offset: 0x0000F6A0
		private static void n_SetSupportButtonTintMode_Landroid_graphics_PorterDuff_Mode_(IntPtr jnienv, IntPtr native__this, IntPtr native_tintMode)
		{
			AppCompatCheckBox @object = Java.Lang.Object.GetObject<AppCompatCheckBox>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			PorterDuff.Mode object2 = Java.Lang.Object.GetObject<PorterDuff.Mode>(native_tintMode, JniHandleOwnership.DoNotTransfer);
			@object.SupportButtonTintMode = object2;
		}

		// Token: 0x170000DD RID: 221
		// (get) Token: 0x06000684 RID: 1668 RVA: 0x000114C4 File Offset: 0x0000F6C4
		// (set) Token: 0x06000685 RID: 1669 RVA: 0x000114F8 File Offset: 0x0000F6F8
		public unsafe virtual PorterDuff.Mode SupportButtonTintMode
		{
			[Register("getSupportButtonTintMode", "()Landroid/graphics/PorterDuff$Mode;", "GetGetSupportButtonTintModeHandler")]
			get
			{
				return Java.Lang.Object.GetObject<PorterDuff.Mode>(AppCompatCheckBox._members.InstanceMethods.InvokeVirtualObjectMethod("getSupportButtonTintMode.()Landroid/graphics/PorterDuff$Mode;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
			[Register("setSupportButtonTintMode", "(Landroid/graphics/PorterDuff$Mode;)V", "GetSetSupportButtonTintMode_Landroid_graphics_PorterDuff_Mode_Handler")]
			set
			{
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((value == null) ? IntPtr.Zero : value.Handle);
					AppCompatCheckBox._members.InstanceMethods.InvokeVirtualVoidMethod("setSupportButtonTintMode.(Landroid/graphics/PorterDuff$Mode;)V", this, ptr);
				}
				finally
				{
					GC.KeepAlive(value);
				}
			}
		}

		// Token: 0x06000686 RID: 1670 RVA: 0x0001155C File Offset: 0x0000F75C
		private static Delegate GetGetSupportCompoundDrawablesTintListHandler()
		{
			if (AppCompatCheckBox.cb_getSupportCompoundDrawablesTintList == null)
			{
				AppCompatCheckBox.cb_getSupportCompoundDrawablesTintList = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(AppCompatCheckBox.n_GetSupportCompoundDrawablesTintList));
			}
			return AppCompatCheckBox.cb_getSupportCompoundDrawablesTintList;
		}

		// Token: 0x06000687 RID: 1671 RVA: 0x00011580 File Offset: 0x0000F780
		private static IntPtr n_GetSupportCompoundDrawablesTintList(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<AppCompatCheckBox>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SupportCompoundDrawablesTintList);
		}

		// Token: 0x06000688 RID: 1672 RVA: 0x00011594 File Offset: 0x0000F794
		private static Delegate GetSetSupportCompoundDrawablesTintList_Landroid_content_res_ColorStateList_Handler()
		{
			if (AppCompatCheckBox.cb_setSupportCompoundDrawablesTintList_Landroid_content_res_ColorStateList_ == null)
			{
				AppCompatCheckBox.cb_setSupportCompoundDrawablesTintList_Landroid_content_res_ColorStateList_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(AppCompatCheckBox.n_SetSupportCompoundDrawablesTintList_Landroid_content_res_ColorStateList_));
			}
			return AppCompatCheckBox.cb_setSupportCompoundDrawablesTintList_Landroid_content_res_ColorStateList_;
		}

		// Token: 0x06000689 RID: 1673 RVA: 0x000115B8 File Offset: 0x0000F7B8
		private static void n_SetSupportCompoundDrawablesTintList_Landroid_content_res_ColorStateList_(IntPtr jnienv, IntPtr native__this, IntPtr native_tintList)
		{
			AppCompatCheckBox @object = Java.Lang.Object.GetObject<AppCompatCheckBox>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ColorStateList object2 = Java.Lang.Object.GetObject<ColorStateList>(native_tintList, JniHandleOwnership.DoNotTransfer);
			@object.SupportCompoundDrawablesTintList = object2;
		}

		// Token: 0x170000DE RID: 222
		// (get) Token: 0x0600068A RID: 1674 RVA: 0x000115DC File Offset: 0x0000F7DC
		// (set) Token: 0x0600068B RID: 1675 RVA: 0x00011610 File Offset: 0x0000F810
		public unsafe virtual ColorStateList SupportCompoundDrawablesTintList
		{
			[Register("getSupportCompoundDrawablesTintList", "()Landroid/content/res/ColorStateList;", "GetGetSupportCompoundDrawablesTintListHandler")]
			get
			{
				return Java.Lang.Object.GetObject<ColorStateList>(AppCompatCheckBox._members.InstanceMethods.InvokeVirtualObjectMethod("getSupportCompoundDrawablesTintList.()Landroid/content/res/ColorStateList;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
			[Register("setSupportCompoundDrawablesTintList", "(Landroid/content/res/ColorStateList;)V", "GetSetSupportCompoundDrawablesTintList_Landroid_content_res_ColorStateList_Handler")]
			set
			{
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((value == null) ? IntPtr.Zero : value.Handle);
					AppCompatCheckBox._members.InstanceMethods.InvokeVirtualVoidMethod("setSupportCompoundDrawablesTintList.(Landroid/content/res/ColorStateList;)V", this, ptr);
				}
				finally
				{
					GC.KeepAlive(value);
				}
			}
		}

		// Token: 0x0600068C RID: 1676 RVA: 0x00011674 File Offset: 0x0000F874
		private static Delegate GetGetSupportCompoundDrawablesTintModeHandler()
		{
			if (AppCompatCheckBox.cb_getSupportCompoundDrawablesTintMode == null)
			{
				AppCompatCheckBox.cb_getSupportCompoundDrawablesTintMode = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(AppCompatCheckBox.n_GetSupportCompoundDrawablesTintMode));
			}
			return AppCompatCheckBox.cb_getSupportCompoundDrawablesTintMode;
		}

		// Token: 0x0600068D RID: 1677 RVA: 0x00011698 File Offset: 0x0000F898
		private static IntPtr n_GetSupportCompoundDrawablesTintMode(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<AppCompatCheckBox>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SupportCompoundDrawablesTintMode);
		}

		// Token: 0x0600068E RID: 1678 RVA: 0x000116AC File Offset: 0x0000F8AC
		private static Delegate GetSetSupportCompoundDrawablesTintMode_Landroid_graphics_PorterDuff_Mode_Handler()
		{
			if (AppCompatCheckBox.cb_setSupportCompoundDrawablesTintMode_Landroid_graphics_PorterDuff_Mode_ == null)
			{
				AppCompatCheckBox.cb_setSupportCompoundDrawablesTintMode_Landroid_graphics_PorterDuff_Mode_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(AppCompatCheckBox.n_SetSupportCompoundDrawablesTintMode_Landroid_graphics_PorterDuff_Mode_));
			}
			return AppCompatCheckBox.cb_setSupportCompoundDrawablesTintMode_Landroid_graphics_PorterDuff_Mode_;
		}

		// Token: 0x0600068F RID: 1679 RVA: 0x000116D0 File Offset: 0x0000F8D0
		private static void n_SetSupportCompoundDrawablesTintMode_Landroid_graphics_PorterDuff_Mode_(IntPtr jnienv, IntPtr native__this, IntPtr native_tintMode)
		{
			AppCompatCheckBox @object = Java.Lang.Object.GetObject<AppCompatCheckBox>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			PorterDuff.Mode object2 = Java.Lang.Object.GetObject<PorterDuff.Mode>(native_tintMode, JniHandleOwnership.DoNotTransfer);
			@object.SupportCompoundDrawablesTintMode = object2;
		}

		// Token: 0x170000DF RID: 223
		// (get) Token: 0x06000690 RID: 1680 RVA: 0x000116F4 File Offset: 0x0000F8F4
		// (set) Token: 0x06000691 RID: 1681 RVA: 0x00011728 File Offset: 0x0000F928
		public unsafe virtual PorterDuff.Mode SupportCompoundDrawablesTintMode
		{
			[Register("getSupportCompoundDrawablesTintMode", "()Landroid/graphics/PorterDuff$Mode;", "GetGetSupportCompoundDrawablesTintModeHandler")]
			get
			{
				return Java.Lang.Object.GetObject<PorterDuff.Mode>(AppCompatCheckBox._members.InstanceMethods.InvokeVirtualObjectMethod("getSupportCompoundDrawablesTintMode.()Landroid/graphics/PorterDuff$Mode;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
			[Register("setSupportCompoundDrawablesTintMode", "(Landroid/graphics/PorterDuff$Mode;)V", "GetSetSupportCompoundDrawablesTintMode_Landroid_graphics_PorterDuff_Mode_Handler")]
			set
			{
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((value == null) ? IntPtr.Zero : value.Handle);
					AppCompatCheckBox._members.InstanceMethods.InvokeVirtualVoidMethod("setSupportCompoundDrawablesTintMode.(Landroid/graphics/PorterDuff$Mode;)V", this, ptr);
				}
				finally
				{
					GC.KeepAlive(value);
				}
			}
		}

		// Token: 0x0400019C RID: 412
		private static readonly JniPeerMembers _members = new XAPeerMembers("androidx/appcompat/widget/AppCompatCheckBox", typeof(AppCompatCheckBox));

		// Token: 0x0400019D RID: 413
		private static Delegate cb_isEmojiCompatEnabled;

		// Token: 0x0400019E RID: 414
		private static Delegate cb_setEmojiCompatEnabled_Z;

		// Token: 0x0400019F RID: 415
		private static Delegate cb_getSupportBackgroundTintList;

		// Token: 0x040001A0 RID: 416
		private static Delegate cb_setSupportBackgroundTintList_Landroid_content_res_ColorStateList_;

		// Token: 0x040001A1 RID: 417
		private static Delegate cb_getSupportBackgroundTintMode;

		// Token: 0x040001A2 RID: 418
		private static Delegate cb_setSupportBackgroundTintMode_Landroid_graphics_PorterDuff_Mode_;

		// Token: 0x040001A3 RID: 419
		private static Delegate cb_getSupportButtonTintList;

		// Token: 0x040001A4 RID: 420
		private static Delegate cb_setSupportButtonTintList_Landroid_content_res_ColorStateList_;

		// Token: 0x040001A5 RID: 421
		private static Delegate cb_getSupportButtonTintMode;

		// Token: 0x040001A6 RID: 422
		private static Delegate cb_setSupportButtonTintMode_Landroid_graphics_PorterDuff_Mode_;

		// Token: 0x040001A7 RID: 423
		private static Delegate cb_getSupportCompoundDrawablesTintList;

		// Token: 0x040001A8 RID: 424
		private static Delegate cb_setSupportCompoundDrawablesTintList_Landroid_content_res_ColorStateList_;

		// Token: 0x040001A9 RID: 425
		private static Delegate cb_getSupportCompoundDrawablesTintMode;

		// Token: 0x040001AA RID: 426
		private static Delegate cb_setSupportCompoundDrawablesTintMode_Landroid_graphics_PorterDuff_Mode_;
	}
}
