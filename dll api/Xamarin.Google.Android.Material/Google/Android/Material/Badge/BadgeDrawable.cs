using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Content;
using Android.Graphics;
using Android.Graphics.Drawables;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Google.Android.Material.Internal;
using Java.Interop;
using Java.Lang;
using Java.Util;

namespace Google.Android.Material.Badge
{
	// Token: 0x0200005D RID: 93
	[Register("com/google/android/material/badge/BadgeDrawable", DoNotGenerateAcw = true)]
	public class BadgeDrawable : Drawable, TextDrawableHelper.ITextDrawableDelegate, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x170000B1 RID: 177
		// (get) Token: 0x0600043A RID: 1082 RVA: 0x0000C220 File Offset: 0x0000A420
		internal static IntPtr class_ref
		{
			get
			{
				return BadgeDrawable._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170000B2 RID: 178
		// (get) Token: 0x0600043B RID: 1083 RVA: 0x0000C244 File Offset: 0x0000A444
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return BadgeDrawable._members;
			}
		}

		// Token: 0x170000B3 RID: 179
		// (get) Token: 0x0600043C RID: 1084 RVA: 0x0000C24C File Offset: 0x0000A44C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return BadgeDrawable._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170000B4 RID: 180
		// (get) Token: 0x0600043D RID: 1085 RVA: 0x0000C270 File Offset: 0x0000A470
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return BadgeDrawable._members.ManagedPeerType;
			}
		}

		// Token: 0x0600043E RID: 1086 RVA: 0x0000C27C File Offset: 0x0000A47C
		protected BadgeDrawable(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x0600043F RID: 1087 RVA: 0x0000C286 File Offset: 0x0000A486
		private static Delegate GetGetBackgroundColorHandler()
		{
			if (BadgeDrawable.cb_getBackgroundColor == null)
			{
				BadgeDrawable.cb_getBackgroundColor = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(BadgeDrawable.n_GetBackgroundColor));
			}
			return BadgeDrawable.cb_getBackgroundColor;
		}

		// Token: 0x06000440 RID: 1088 RVA: 0x0000C2AA File Offset: 0x0000A4AA
		private static int n_GetBackgroundColor(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<BadgeDrawable>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).BackgroundColor;
		}

		// Token: 0x06000441 RID: 1089 RVA: 0x0000C2B9 File Offset: 0x0000A4B9
		private static Delegate GetSetBackgroundColor_IHandler()
		{
			if (BadgeDrawable.cb_setBackgroundColor_I == null)
			{
				BadgeDrawable.cb_setBackgroundColor_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_V(BadgeDrawable.n_SetBackgroundColor_I));
			}
			return BadgeDrawable.cb_setBackgroundColor_I;
		}

		// Token: 0x06000442 RID: 1090 RVA: 0x0000C2DD File Offset: 0x0000A4DD
		private static void n_SetBackgroundColor_I(IntPtr jnienv, IntPtr native__this, int backgroundColor)
		{
			Java.Lang.Object.GetObject<BadgeDrawable>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).BackgroundColor = backgroundColor;
		}

		// Token: 0x170000B5 RID: 181
		// (get) Token: 0x06000443 RID: 1091 RVA: 0x0000C2ED File Offset: 0x0000A4ED
		// (set) Token: 0x06000444 RID: 1092 RVA: 0x0000C308 File Offset: 0x0000A508
		public unsafe virtual int BackgroundColor
		{
			[Register("getBackgroundColor", "()I", "GetGetBackgroundColorHandler")]
			get
			{
				return BadgeDrawable._members.InstanceMethods.InvokeVirtualInt32Method("getBackgroundColor.()I", this, null);
			}
			[Register("setBackgroundColor", "(I)V", "GetSetBackgroundColor_IHandler")]
			set
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(value);
				BadgeDrawable._members.InstanceMethods.InvokeVirtualVoidMethod("setBackgroundColor.(I)V", this, ptr);
			}
		}

		// Token: 0x06000445 RID: 1093 RVA: 0x0000C343 File Offset: 0x0000A543
		private static Delegate GetGetBadgeGravityHandler()
		{
			if (BadgeDrawable.cb_getBadgeGravity == null)
			{
				BadgeDrawable.cb_getBadgeGravity = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(BadgeDrawable.n_GetBadgeGravity));
			}
			return BadgeDrawable.cb_getBadgeGravity;
		}

		// Token: 0x06000446 RID: 1094 RVA: 0x0000C367 File Offset: 0x0000A567
		private static int n_GetBadgeGravity(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<BadgeDrawable>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).BadgeGravity;
		}

		// Token: 0x06000447 RID: 1095 RVA: 0x0000C376 File Offset: 0x0000A576
		private static Delegate GetSetBadgeGravity_IHandler()
		{
			if (BadgeDrawable.cb_setBadgeGravity_I == null)
			{
				BadgeDrawable.cb_setBadgeGravity_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_V(BadgeDrawable.n_SetBadgeGravity_I));
			}
			return BadgeDrawable.cb_setBadgeGravity_I;
		}

		// Token: 0x06000448 RID: 1096 RVA: 0x0000C39A File Offset: 0x0000A59A
		private static void n_SetBadgeGravity_I(IntPtr jnienv, IntPtr native__this, int gravity)
		{
			Java.Lang.Object.GetObject<BadgeDrawable>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).BadgeGravity = gravity;
		}

		// Token: 0x170000B6 RID: 182
		// (get) Token: 0x06000449 RID: 1097 RVA: 0x0000C3AA File Offset: 0x0000A5AA
		// (set) Token: 0x0600044A RID: 1098 RVA: 0x0000C3C4 File Offset: 0x0000A5C4
		public unsafe virtual int BadgeGravity
		{
			[Register("getBadgeGravity", "()I", "GetGetBadgeGravityHandler")]
			get
			{
				return BadgeDrawable._members.InstanceMethods.InvokeVirtualInt32Method("getBadgeGravity.()I", this, null);
			}
			[Register("setBadgeGravity", "(I)V", "GetSetBadgeGravity_IHandler")]
			set
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(value);
				BadgeDrawable._members.InstanceMethods.InvokeVirtualVoidMethod("setBadgeGravity.(I)V", this, ptr);
			}
		}

		// Token: 0x0600044B RID: 1099 RVA: 0x0000C3FF File Offset: 0x0000A5FF
		private static Delegate GetGetBadgeNumberLocaleHandler()
		{
			if (BadgeDrawable.cb_getBadgeNumberLocale == null)
			{
				BadgeDrawable.cb_getBadgeNumberLocale = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(BadgeDrawable.n_GetBadgeNumberLocale));
			}
			return BadgeDrawable.cb_getBadgeNumberLocale;
		}

		// Token: 0x0600044C RID: 1100 RVA: 0x0000C423 File Offset: 0x0000A623
		private static IntPtr n_GetBadgeNumberLocale(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<BadgeDrawable>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).BadgeNumberLocale);
		}

		// Token: 0x0600044D RID: 1101 RVA: 0x0000C437 File Offset: 0x0000A637
		private static Delegate GetSetBadgeNumberLocale_Ljava_util_Locale_Handler()
		{
			if (BadgeDrawable.cb_setBadgeNumberLocale_Ljava_util_Locale_ == null)
			{
				BadgeDrawable.cb_setBadgeNumberLocale_Ljava_util_Locale_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(BadgeDrawable.n_SetBadgeNumberLocale_Ljava_util_Locale_));
			}
			return BadgeDrawable.cb_setBadgeNumberLocale_Ljava_util_Locale_;
		}

		// Token: 0x0600044E RID: 1102 RVA: 0x0000C45C File Offset: 0x0000A65C
		private static void n_SetBadgeNumberLocale_Ljava_util_Locale_(IntPtr jnienv, IntPtr native__this, IntPtr native_locale)
		{
			BadgeDrawable @object = Java.Lang.Object.GetObject<BadgeDrawable>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Locale object2 = Java.Lang.Object.GetObject<Locale>(native_locale, JniHandleOwnership.DoNotTransfer);
			@object.BadgeNumberLocale = object2;
		}

		// Token: 0x170000B7 RID: 183
		// (get) Token: 0x0600044F RID: 1103 RVA: 0x0000C480 File Offset: 0x0000A680
		// (set) Token: 0x06000450 RID: 1104 RVA: 0x0000C4B4 File Offset: 0x0000A6B4
		public unsafe virtual Locale BadgeNumberLocale
		{
			[Register("getBadgeNumberLocale", "()Ljava/util/Locale;", "GetGetBadgeNumberLocaleHandler")]
			get
			{
				return Java.Lang.Object.GetObject<Locale>(BadgeDrawable._members.InstanceMethods.InvokeVirtualObjectMethod("getBadgeNumberLocale.()Ljava/util/Locale;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
			[Register("setBadgeNumberLocale", "(Ljava/util/Locale;)V", "GetSetBadgeNumberLocale_Ljava_util_Locale_Handler")]
			set
			{
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((value == null) ? IntPtr.Zero : value.Handle);
					BadgeDrawable._members.InstanceMethods.InvokeVirtualVoidMethod("setBadgeNumberLocale.(Ljava/util/Locale;)V", this, ptr);
				}
				finally
				{
					GC.KeepAlive(value);
				}
			}
		}

		// Token: 0x06000451 RID: 1105 RVA: 0x0000C518 File Offset: 0x0000A718
		private static Delegate GetGetBadgeTextColorHandler()
		{
			if (BadgeDrawable.cb_getBadgeTextColor == null)
			{
				BadgeDrawable.cb_getBadgeTextColor = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(BadgeDrawable.n_GetBadgeTextColor));
			}
			return BadgeDrawable.cb_getBadgeTextColor;
		}

		// Token: 0x06000452 RID: 1106 RVA: 0x0000C53C File Offset: 0x0000A73C
		private static int n_GetBadgeTextColor(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<BadgeDrawable>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).BadgeTextColor;
		}

		// Token: 0x06000453 RID: 1107 RVA: 0x0000C54B File Offset: 0x0000A74B
		private static Delegate GetSetBadgeTextColor_IHandler()
		{
			if (BadgeDrawable.cb_setBadgeTextColor_I == null)
			{
				BadgeDrawable.cb_setBadgeTextColor_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_V(BadgeDrawable.n_SetBadgeTextColor_I));
			}
			return BadgeDrawable.cb_setBadgeTextColor_I;
		}

		// Token: 0x06000454 RID: 1108 RVA: 0x0000C56F File Offset: 0x0000A76F
		private static void n_SetBadgeTextColor_I(IntPtr jnienv, IntPtr native__this, int badgeTextColor)
		{
			Java.Lang.Object.GetObject<BadgeDrawable>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).BadgeTextColor = badgeTextColor;
		}

		// Token: 0x170000B8 RID: 184
		// (get) Token: 0x06000455 RID: 1109 RVA: 0x0000C57F File Offset: 0x0000A77F
		// (set) Token: 0x06000456 RID: 1110 RVA: 0x0000C598 File Offset: 0x0000A798
		public unsafe virtual int BadgeTextColor
		{
			[Register("getBadgeTextColor", "()I", "GetGetBadgeTextColorHandler")]
			get
			{
				return BadgeDrawable._members.InstanceMethods.InvokeVirtualInt32Method("getBadgeTextColor.()I", this, null);
			}
			[Register("setBadgeTextColor", "(I)V", "GetSetBadgeTextColor_IHandler")]
			set
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(value);
				BadgeDrawable._members.InstanceMethods.InvokeVirtualVoidMethod("setBadgeTextColor.(I)V", this, ptr);
			}
		}

		// Token: 0x06000457 RID: 1111 RVA: 0x0000C5D3 File Offset: 0x0000A7D3
		private static Delegate GetGetContentDescriptionHandler()
		{
			if (BadgeDrawable.cb_getContentDescription == null)
			{
				BadgeDrawable.cb_getContentDescription = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(BadgeDrawable.n_GetContentDescription));
			}
			return BadgeDrawable.cb_getContentDescription;
		}

		// Token: 0x06000458 RID: 1112 RVA: 0x0000C5F7 File Offset: 0x0000A7F7
		private static IntPtr n_GetContentDescription(IntPtr jnienv, IntPtr native__this)
		{
			return CharSequence.ToLocalJniHandle(Java.Lang.Object.GetObject<BadgeDrawable>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ContentDescriptionFormatted);
		}

		// Token: 0x170000B9 RID: 185
		// (get) Token: 0x06000459 RID: 1113 RVA: 0x0000C60C File Offset: 0x0000A80C
		public virtual ICharSequence ContentDescriptionFormatted
		{
			[Register("getContentDescription", "()Ljava/lang/CharSequence;", "GetGetContentDescriptionHandler")]
			get
			{
				return Java.Lang.Object.GetObject<ICharSequence>(BadgeDrawable._members.InstanceMethods.InvokeVirtualObjectMethod("getContentDescription.()Ljava/lang/CharSequence;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x170000BA RID: 186
		// (get) Token: 0x0600045A RID: 1114 RVA: 0x0000C63E File Offset: 0x0000A83E
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

		// Token: 0x0600045B RID: 1115 RVA: 0x0000C655 File Offset: 0x0000A855
		private static Delegate GetGetCustomBadgeParentHandler()
		{
			if (BadgeDrawable.cb_getCustomBadgeParent == null)
			{
				BadgeDrawable.cb_getCustomBadgeParent = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(BadgeDrawable.n_GetCustomBadgeParent));
			}
			return BadgeDrawable.cb_getCustomBadgeParent;
		}

		// Token: 0x0600045C RID: 1116 RVA: 0x0000C679 File Offset: 0x0000A879
		private static IntPtr n_GetCustomBadgeParent(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<BadgeDrawable>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).CustomBadgeParent);
		}

		// Token: 0x170000BB RID: 187
		// (get) Token: 0x0600045D RID: 1117 RVA: 0x0000C690 File Offset: 0x0000A890
		public virtual FrameLayout CustomBadgeParent
		{
			[Register("getCustomBadgeParent", "()Landroid/widget/FrameLayout;", "GetGetCustomBadgeParentHandler")]
			get
			{
				return Java.Lang.Object.GetObject<FrameLayout>(BadgeDrawable._members.InstanceMethods.InvokeVirtualObjectMethod("getCustomBadgeParent.()Landroid/widget/FrameLayout;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x0600045E RID: 1118 RVA: 0x0000C6C2 File Offset: 0x0000A8C2
		private static Delegate GetHasNumberHandler()
		{
			if (BadgeDrawable.cb_hasNumber == null)
			{
				BadgeDrawable.cb_hasNumber = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(BadgeDrawable.n_HasNumber));
			}
			return BadgeDrawable.cb_hasNumber;
		}

		// Token: 0x0600045F RID: 1119 RVA: 0x0000C6E6 File Offset: 0x0000A8E6
		private static bool n_HasNumber(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<BadgeDrawable>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).HasNumber;
		}

		// Token: 0x170000BC RID: 188
		// (get) Token: 0x06000460 RID: 1120 RVA: 0x0000C6F5 File Offset: 0x0000A8F5
		public virtual bool HasNumber
		{
			[Register("hasNumber", "()Z", "GetHasNumberHandler")]
			get
			{
				return BadgeDrawable._members.InstanceMethods.InvokeVirtualBooleanMethod("hasNumber.()Z", this, null);
			}
		}

		// Token: 0x06000461 RID: 1121 RVA: 0x0000C70E File Offset: 0x0000A90E
		private static Delegate GetGetHorizontalOffsetHandler()
		{
			if (BadgeDrawable.cb_getHorizontalOffset == null)
			{
				BadgeDrawable.cb_getHorizontalOffset = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(BadgeDrawable.n_GetHorizontalOffset));
			}
			return BadgeDrawable.cb_getHorizontalOffset;
		}

		// Token: 0x06000462 RID: 1122 RVA: 0x0000C732 File Offset: 0x0000A932
		private static int n_GetHorizontalOffset(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<BadgeDrawable>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).HorizontalOffset;
		}

		// Token: 0x06000463 RID: 1123 RVA: 0x0000C741 File Offset: 0x0000A941
		private static Delegate GetSetHorizontalOffset_IHandler()
		{
			if (BadgeDrawable.cb_setHorizontalOffset_I == null)
			{
				BadgeDrawable.cb_setHorizontalOffset_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_V(BadgeDrawable.n_SetHorizontalOffset_I));
			}
			return BadgeDrawable.cb_setHorizontalOffset_I;
		}

		// Token: 0x06000464 RID: 1124 RVA: 0x0000C765 File Offset: 0x0000A965
		private static void n_SetHorizontalOffset_I(IntPtr jnienv, IntPtr native__this, int px)
		{
			Java.Lang.Object.GetObject<BadgeDrawable>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).HorizontalOffset = px;
		}

		// Token: 0x170000BD RID: 189
		// (get) Token: 0x06000465 RID: 1125 RVA: 0x0000C775 File Offset: 0x0000A975
		// (set) Token: 0x06000466 RID: 1126 RVA: 0x0000C790 File Offset: 0x0000A990
		public unsafe virtual int HorizontalOffset
		{
			[Register("getHorizontalOffset", "()I", "GetGetHorizontalOffsetHandler")]
			get
			{
				return BadgeDrawable._members.InstanceMethods.InvokeVirtualInt32Method("getHorizontalOffset.()I", this, null);
			}
			[Register("setHorizontalOffset", "(I)V", "GetSetHorizontalOffset_IHandler")]
			set
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(value);
				BadgeDrawable._members.InstanceMethods.InvokeVirtualVoidMethod("setHorizontalOffset.(I)V", this, ptr);
			}
		}

		// Token: 0x06000467 RID: 1127 RVA: 0x0000C7CB File Offset: 0x0000A9CB
		private static Delegate GetGetHorizontalOffsetWithTextHandler()
		{
			if (BadgeDrawable.cb_getHorizontalOffsetWithText == null)
			{
				BadgeDrawable.cb_getHorizontalOffsetWithText = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(BadgeDrawable.n_GetHorizontalOffsetWithText));
			}
			return BadgeDrawable.cb_getHorizontalOffsetWithText;
		}

		// Token: 0x06000468 RID: 1128 RVA: 0x0000C7EF File Offset: 0x0000A9EF
		private static int n_GetHorizontalOffsetWithText(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<BadgeDrawable>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).HorizontalOffsetWithText;
		}

		// Token: 0x06000469 RID: 1129 RVA: 0x0000C7FE File Offset: 0x0000A9FE
		private static Delegate GetSetHorizontalOffsetWithText_IHandler()
		{
			if (BadgeDrawable.cb_setHorizontalOffsetWithText_I == null)
			{
				BadgeDrawable.cb_setHorizontalOffsetWithText_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_V(BadgeDrawable.n_SetHorizontalOffsetWithText_I));
			}
			return BadgeDrawable.cb_setHorizontalOffsetWithText_I;
		}

		// Token: 0x0600046A RID: 1130 RVA: 0x0000C822 File Offset: 0x0000AA22
		private static void n_SetHorizontalOffsetWithText_I(IntPtr jnienv, IntPtr native__this, int px)
		{
			Java.Lang.Object.GetObject<BadgeDrawable>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).HorizontalOffsetWithText = px;
		}

		// Token: 0x170000BE RID: 190
		// (get) Token: 0x0600046B RID: 1131 RVA: 0x0000C832 File Offset: 0x0000AA32
		// (set) Token: 0x0600046C RID: 1132 RVA: 0x0000C84C File Offset: 0x0000AA4C
		public unsafe virtual int HorizontalOffsetWithText
		{
			[Register("getHorizontalOffsetWithText", "()I", "GetGetHorizontalOffsetWithTextHandler")]
			get
			{
				return BadgeDrawable._members.InstanceMethods.InvokeVirtualInt32Method("getHorizontalOffsetWithText.()I", this, null);
			}
			[Register("setHorizontalOffsetWithText", "(I)V", "GetSetHorizontalOffsetWithText_IHandler")]
			set
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(value);
				BadgeDrawable._members.InstanceMethods.InvokeVirtualVoidMethod("setHorizontalOffsetWithText.(I)V", this, ptr);
			}
		}

		// Token: 0x0600046D RID: 1133 RVA: 0x0000C887 File Offset: 0x0000AA87
		private static Delegate GetGetHorizontalOffsetWithoutTextHandler()
		{
			if (BadgeDrawable.cb_getHorizontalOffsetWithoutText == null)
			{
				BadgeDrawable.cb_getHorizontalOffsetWithoutText = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(BadgeDrawable.n_GetHorizontalOffsetWithoutText));
			}
			return BadgeDrawable.cb_getHorizontalOffsetWithoutText;
		}

		// Token: 0x0600046E RID: 1134 RVA: 0x0000C8AB File Offset: 0x0000AAAB
		private static int n_GetHorizontalOffsetWithoutText(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<BadgeDrawable>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).HorizontalOffsetWithoutText;
		}

		// Token: 0x0600046F RID: 1135 RVA: 0x0000C8BA File Offset: 0x0000AABA
		private static Delegate GetSetHorizontalOffsetWithoutText_IHandler()
		{
			if (BadgeDrawable.cb_setHorizontalOffsetWithoutText_I == null)
			{
				BadgeDrawable.cb_setHorizontalOffsetWithoutText_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_V(BadgeDrawable.n_SetHorizontalOffsetWithoutText_I));
			}
			return BadgeDrawable.cb_setHorizontalOffsetWithoutText_I;
		}

		// Token: 0x06000470 RID: 1136 RVA: 0x0000C8DE File Offset: 0x0000AADE
		private static void n_SetHorizontalOffsetWithoutText_I(IntPtr jnienv, IntPtr native__this, int px)
		{
			Java.Lang.Object.GetObject<BadgeDrawable>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).HorizontalOffsetWithoutText = px;
		}

		// Token: 0x170000BF RID: 191
		// (get) Token: 0x06000471 RID: 1137 RVA: 0x0000C8EE File Offset: 0x0000AAEE
		// (set) Token: 0x06000472 RID: 1138 RVA: 0x0000C908 File Offset: 0x0000AB08
		public unsafe virtual int HorizontalOffsetWithoutText
		{
			[Register("getHorizontalOffsetWithoutText", "()I", "GetGetHorizontalOffsetWithoutTextHandler")]
			get
			{
				return BadgeDrawable._members.InstanceMethods.InvokeVirtualInt32Method("getHorizontalOffsetWithoutText.()I", this, null);
			}
			[Register("setHorizontalOffsetWithoutText", "(I)V", "GetSetHorizontalOffsetWithoutText_IHandler")]
			set
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(value);
				BadgeDrawable._members.InstanceMethods.InvokeVirtualVoidMethod("setHorizontalOffsetWithoutText.(I)V", this, ptr);
			}
		}

		// Token: 0x06000473 RID: 1139 RVA: 0x0000C943 File Offset: 0x0000AB43
		private static Delegate GetGetMaxCharacterCountHandler()
		{
			if (BadgeDrawable.cb_getMaxCharacterCount == null)
			{
				BadgeDrawable.cb_getMaxCharacterCount = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(BadgeDrawable.n_GetMaxCharacterCount));
			}
			return BadgeDrawable.cb_getMaxCharacterCount;
		}

		// Token: 0x06000474 RID: 1140 RVA: 0x0000C967 File Offset: 0x0000AB67
		private static int n_GetMaxCharacterCount(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<BadgeDrawable>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).MaxCharacterCount;
		}

		// Token: 0x06000475 RID: 1141 RVA: 0x0000C976 File Offset: 0x0000AB76
		private static Delegate GetSetMaxCharacterCount_IHandler()
		{
			if (BadgeDrawable.cb_setMaxCharacterCount_I == null)
			{
				BadgeDrawable.cb_setMaxCharacterCount_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_V(BadgeDrawable.n_SetMaxCharacterCount_I));
			}
			return BadgeDrawable.cb_setMaxCharacterCount_I;
		}

		// Token: 0x06000476 RID: 1142 RVA: 0x0000C99A File Offset: 0x0000AB9A
		private static void n_SetMaxCharacterCount_I(IntPtr jnienv, IntPtr native__this, int maxCharacterCount)
		{
			Java.Lang.Object.GetObject<BadgeDrawable>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).MaxCharacterCount = maxCharacterCount;
		}

		// Token: 0x170000C0 RID: 192
		// (get) Token: 0x06000477 RID: 1143 RVA: 0x0000C9AA File Offset: 0x0000ABAA
		// (set) Token: 0x06000478 RID: 1144 RVA: 0x0000C9C4 File Offset: 0x0000ABC4
		public unsafe virtual int MaxCharacterCount
		{
			[Register("getMaxCharacterCount", "()I", "GetGetMaxCharacterCountHandler")]
			get
			{
				return BadgeDrawable._members.InstanceMethods.InvokeVirtualInt32Method("getMaxCharacterCount.()I", this, null);
			}
			[Register("setMaxCharacterCount", "(I)V", "GetSetMaxCharacterCount_IHandler")]
			set
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(value);
				BadgeDrawable._members.InstanceMethods.InvokeVirtualVoidMethod("setMaxCharacterCount.(I)V", this, ptr);
			}
		}

		// Token: 0x06000479 RID: 1145 RVA: 0x0000C9FF File Offset: 0x0000ABFF
		private static Delegate GetGetNumberHandler()
		{
			if (BadgeDrawable.cb_getNumber == null)
			{
				BadgeDrawable.cb_getNumber = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(BadgeDrawable.n_GetNumber));
			}
			return BadgeDrawable.cb_getNumber;
		}

		// Token: 0x0600047A RID: 1146 RVA: 0x0000CA23 File Offset: 0x0000AC23
		private static int n_GetNumber(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<BadgeDrawable>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Number;
		}

		// Token: 0x0600047B RID: 1147 RVA: 0x0000CA32 File Offset: 0x0000AC32
		private static Delegate GetSetNumber_IHandler()
		{
			if (BadgeDrawable.cb_setNumber_I == null)
			{
				BadgeDrawable.cb_setNumber_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_V(BadgeDrawable.n_SetNumber_I));
			}
			return BadgeDrawable.cb_setNumber_I;
		}

		// Token: 0x0600047C RID: 1148 RVA: 0x0000CA56 File Offset: 0x0000AC56
		private static void n_SetNumber_I(IntPtr jnienv, IntPtr native__this, int number)
		{
			Java.Lang.Object.GetObject<BadgeDrawable>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Number = number;
		}

		// Token: 0x170000C1 RID: 193
		// (get) Token: 0x0600047D RID: 1149 RVA: 0x0000CA66 File Offset: 0x0000AC66
		// (set) Token: 0x0600047E RID: 1150 RVA: 0x0000CA80 File Offset: 0x0000AC80
		public unsafe virtual int Number
		{
			[Register("getNumber", "()I", "GetGetNumberHandler")]
			get
			{
				return BadgeDrawable._members.InstanceMethods.InvokeVirtualInt32Method("getNumber.()I", this, null);
			}
			[Register("setNumber", "(I)V", "GetSetNumber_IHandler")]
			set
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(value);
				BadgeDrawable._members.InstanceMethods.InvokeVirtualVoidMethod("setNumber.(I)V", this, ptr);
			}
		}

		// Token: 0x0600047F RID: 1151 RVA: 0x0000CABB File Offset: 0x0000ACBB
		private static Delegate GetGetOpacityHandler()
		{
			if (BadgeDrawable.cb_getOpacity == null)
			{
				BadgeDrawable.cb_getOpacity = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(BadgeDrawable.n_GetOpacity));
			}
			return BadgeDrawable.cb_getOpacity;
		}

		// Token: 0x06000480 RID: 1152 RVA: 0x0000CADF File Offset: 0x0000ACDF
		private static int n_GetOpacity(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<BadgeDrawable>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Opacity;
		}

		// Token: 0x170000C2 RID: 194
		// (get) Token: 0x06000481 RID: 1153 RVA: 0x0000CAEE File Offset: 0x0000ACEE
		public override int Opacity
		{
			[Register("getOpacity", "()I", "GetGetOpacityHandler")]
			get
			{
				return BadgeDrawable._members.InstanceMethods.InvokeVirtualInt32Method("getOpacity.()I", this, null);
			}
		}

		// Token: 0x06000482 RID: 1154 RVA: 0x0000CB07 File Offset: 0x0000AD07
		private static Delegate GetGetVerticalOffsetHandler()
		{
			if (BadgeDrawable.cb_getVerticalOffset == null)
			{
				BadgeDrawable.cb_getVerticalOffset = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(BadgeDrawable.n_GetVerticalOffset));
			}
			return BadgeDrawable.cb_getVerticalOffset;
		}

		// Token: 0x06000483 RID: 1155 RVA: 0x0000CB2B File Offset: 0x0000AD2B
		private static int n_GetVerticalOffset(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<BadgeDrawable>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).VerticalOffset;
		}

		// Token: 0x06000484 RID: 1156 RVA: 0x0000CB3A File Offset: 0x0000AD3A
		private static Delegate GetSetVerticalOffset_IHandler()
		{
			if (BadgeDrawable.cb_setVerticalOffset_I == null)
			{
				BadgeDrawable.cb_setVerticalOffset_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_V(BadgeDrawable.n_SetVerticalOffset_I));
			}
			return BadgeDrawable.cb_setVerticalOffset_I;
		}

		// Token: 0x06000485 RID: 1157 RVA: 0x0000CB5E File Offset: 0x0000AD5E
		private static void n_SetVerticalOffset_I(IntPtr jnienv, IntPtr native__this, int px)
		{
			Java.Lang.Object.GetObject<BadgeDrawable>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).VerticalOffset = px;
		}

		// Token: 0x170000C3 RID: 195
		// (get) Token: 0x06000486 RID: 1158 RVA: 0x0000CB6E File Offset: 0x0000AD6E
		// (set) Token: 0x06000487 RID: 1159 RVA: 0x0000CB88 File Offset: 0x0000AD88
		public unsafe virtual int VerticalOffset
		{
			[Register("getVerticalOffset", "()I", "GetGetVerticalOffsetHandler")]
			get
			{
				return BadgeDrawable._members.InstanceMethods.InvokeVirtualInt32Method("getVerticalOffset.()I", this, null);
			}
			[Register("setVerticalOffset", "(I)V", "GetSetVerticalOffset_IHandler")]
			set
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(value);
				BadgeDrawable._members.InstanceMethods.InvokeVirtualVoidMethod("setVerticalOffset.(I)V", this, ptr);
			}
		}

		// Token: 0x06000488 RID: 1160 RVA: 0x0000CBC3 File Offset: 0x0000ADC3
		private static Delegate GetGetVerticalOffsetWithTextHandler()
		{
			if (BadgeDrawable.cb_getVerticalOffsetWithText == null)
			{
				BadgeDrawable.cb_getVerticalOffsetWithText = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(BadgeDrawable.n_GetVerticalOffsetWithText));
			}
			return BadgeDrawable.cb_getVerticalOffsetWithText;
		}

		// Token: 0x06000489 RID: 1161 RVA: 0x0000CBE7 File Offset: 0x0000ADE7
		private static int n_GetVerticalOffsetWithText(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<BadgeDrawable>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).VerticalOffsetWithText;
		}

		// Token: 0x0600048A RID: 1162 RVA: 0x0000CBF6 File Offset: 0x0000ADF6
		private static Delegate GetSetVerticalOffsetWithText_IHandler()
		{
			if (BadgeDrawable.cb_setVerticalOffsetWithText_I == null)
			{
				BadgeDrawable.cb_setVerticalOffsetWithText_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_V(BadgeDrawable.n_SetVerticalOffsetWithText_I));
			}
			return BadgeDrawable.cb_setVerticalOffsetWithText_I;
		}

		// Token: 0x0600048B RID: 1163 RVA: 0x0000CC1A File Offset: 0x0000AE1A
		private static void n_SetVerticalOffsetWithText_I(IntPtr jnienv, IntPtr native__this, int px)
		{
			Java.Lang.Object.GetObject<BadgeDrawable>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).VerticalOffsetWithText = px;
		}

		// Token: 0x170000C4 RID: 196
		// (get) Token: 0x0600048C RID: 1164 RVA: 0x0000CC2A File Offset: 0x0000AE2A
		// (set) Token: 0x0600048D RID: 1165 RVA: 0x0000CC44 File Offset: 0x0000AE44
		public unsafe virtual int VerticalOffsetWithText
		{
			[Register("getVerticalOffsetWithText", "()I", "GetGetVerticalOffsetWithTextHandler")]
			get
			{
				return BadgeDrawable._members.InstanceMethods.InvokeVirtualInt32Method("getVerticalOffsetWithText.()I", this, null);
			}
			[Register("setVerticalOffsetWithText", "(I)V", "GetSetVerticalOffsetWithText_IHandler")]
			set
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(value);
				BadgeDrawable._members.InstanceMethods.InvokeVirtualVoidMethod("setVerticalOffsetWithText.(I)V", this, ptr);
			}
		}

		// Token: 0x0600048E RID: 1166 RVA: 0x0000CC7F File Offset: 0x0000AE7F
		private static Delegate GetGetVerticalOffsetWithoutTextHandler()
		{
			if (BadgeDrawable.cb_getVerticalOffsetWithoutText == null)
			{
				BadgeDrawable.cb_getVerticalOffsetWithoutText = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(BadgeDrawable.n_GetVerticalOffsetWithoutText));
			}
			return BadgeDrawable.cb_getVerticalOffsetWithoutText;
		}

		// Token: 0x0600048F RID: 1167 RVA: 0x0000CCA3 File Offset: 0x0000AEA3
		private static int n_GetVerticalOffsetWithoutText(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<BadgeDrawable>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).VerticalOffsetWithoutText;
		}

		// Token: 0x06000490 RID: 1168 RVA: 0x0000CCB2 File Offset: 0x0000AEB2
		private static Delegate GetSetVerticalOffsetWithoutText_IHandler()
		{
			if (BadgeDrawable.cb_setVerticalOffsetWithoutText_I == null)
			{
				BadgeDrawable.cb_setVerticalOffsetWithoutText_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_V(BadgeDrawable.n_SetVerticalOffsetWithoutText_I));
			}
			return BadgeDrawable.cb_setVerticalOffsetWithoutText_I;
		}

		// Token: 0x06000491 RID: 1169 RVA: 0x0000CCD6 File Offset: 0x0000AED6
		private static void n_SetVerticalOffsetWithoutText_I(IntPtr jnienv, IntPtr native__this, int px)
		{
			Java.Lang.Object.GetObject<BadgeDrawable>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).VerticalOffsetWithoutText = px;
		}

		// Token: 0x170000C5 RID: 197
		// (get) Token: 0x06000492 RID: 1170 RVA: 0x0000CCE6 File Offset: 0x0000AEE6
		// (set) Token: 0x06000493 RID: 1171 RVA: 0x0000CD00 File Offset: 0x0000AF00
		public unsafe virtual int VerticalOffsetWithoutText
		{
			[Register("getVerticalOffsetWithoutText", "()I", "GetGetVerticalOffsetWithoutTextHandler")]
			get
			{
				return BadgeDrawable._members.InstanceMethods.InvokeVirtualInt32Method("getVerticalOffsetWithoutText.()I", this, null);
			}
			[Register("setVerticalOffsetWithoutText", "(I)V", "GetSetVerticalOffsetWithoutText_IHandler")]
			set
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(value);
				BadgeDrawable._members.InstanceMethods.InvokeVirtualVoidMethod("setVerticalOffsetWithoutText.(I)V", this, ptr);
			}
		}

		// Token: 0x06000494 RID: 1172 RVA: 0x0000CD3B File Offset: 0x0000AF3B
		private static Delegate GetClearNumberHandler()
		{
			if (BadgeDrawable.cb_clearNumber == null)
			{
				BadgeDrawable.cb_clearNumber = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(BadgeDrawable.n_ClearNumber));
			}
			return BadgeDrawable.cb_clearNumber;
		}

		// Token: 0x06000495 RID: 1173 RVA: 0x0000CD5F File Offset: 0x0000AF5F
		private static void n_ClearNumber(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<BadgeDrawable>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ClearNumber();
		}

		// Token: 0x06000496 RID: 1174 RVA: 0x0000CD6E File Offset: 0x0000AF6E
		[Register("clearNumber", "()V", "GetClearNumberHandler")]
		public virtual void ClearNumber()
		{
			BadgeDrawable._members.InstanceMethods.InvokeVirtualVoidMethod("clearNumber.()V", this, null);
		}

		// Token: 0x06000497 RID: 1175 RVA: 0x0000CD88 File Offset: 0x0000AF88
		[Register("create", "(Landroid/content/Context;)Lcom/google/android/material/badge/BadgeDrawable;", "")]
		public unsafe static BadgeDrawable Create(Context context)
		{
			BadgeDrawable @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((context == null) ? IntPtr.Zero : context.Handle);
				@object = Java.Lang.Object.GetObject<BadgeDrawable>(BadgeDrawable._members.StaticMethods.InvokeObjectMethod("create.(Landroid/content/Context;)Lcom/google/android/material/badge/BadgeDrawable;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(context);
			}
			return @object;
		}

		// Token: 0x06000498 RID: 1176 RVA: 0x0000CDFC File Offset: 0x0000AFFC
		[Register("createFromResource", "(Landroid/content/Context;I)Lcom/google/android/material/badge/BadgeDrawable;", "")]
		public unsafe static BadgeDrawable CreateFromResource(Context context, int id)
		{
			BadgeDrawable @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((context == null) ? IntPtr.Zero : context.Handle);
				ptr[1] = new JniArgumentValue(id);
				@object = Java.Lang.Object.GetObject<BadgeDrawable>(BadgeDrawable._members.StaticMethods.InvokeObjectMethod("createFromResource.(Landroid/content/Context;I)Lcom/google/android/material/badge/BadgeDrawable;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(context);
			}
			return @object;
		}

		// Token: 0x06000499 RID: 1177 RVA: 0x0000CE84 File Offset: 0x0000B084
		private static Delegate GetDraw_Landroid_graphics_Canvas_Handler()
		{
			if (BadgeDrawable.cb_draw_Landroid_graphics_Canvas_ == null)
			{
				BadgeDrawable.cb_draw_Landroid_graphics_Canvas_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(BadgeDrawable.n_Draw_Landroid_graphics_Canvas_));
			}
			return BadgeDrawable.cb_draw_Landroid_graphics_Canvas_;
		}

		// Token: 0x0600049A RID: 1178 RVA: 0x0000CEA8 File Offset: 0x0000B0A8
		private static void n_Draw_Landroid_graphics_Canvas_(IntPtr jnienv, IntPtr native__this, IntPtr native_canvas)
		{
			Drawable @object = Java.Lang.Object.GetObject<BadgeDrawable>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Canvas object2 = Java.Lang.Object.GetObject<Canvas>(native_canvas, JniHandleOwnership.DoNotTransfer);
			@object.Draw(object2);
		}

		// Token: 0x0600049B RID: 1179 RVA: 0x0000CECC File Offset: 0x0000B0CC
		[Register("draw", "(Landroid/graphics/Canvas;)V", "GetDraw_Landroid_graphics_Canvas_Handler")]
		public unsafe override void Draw(Canvas canvas)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((canvas == null) ? IntPtr.Zero : canvas.Handle);
				BadgeDrawable._members.InstanceMethods.InvokeVirtualVoidMethod("draw.(Landroid/graphics/Canvas;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(canvas);
			}
		}

		// Token: 0x0600049C RID: 1180 RVA: 0x0000CF30 File Offset: 0x0000B130
		private static Delegate GetOnStateChange_arrayIHandler()
		{
			if (BadgeDrawable.cb_onStateChange_arrayI == null)
			{
				BadgeDrawable.cb_onStateChange_arrayI = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(BadgeDrawable.n_OnStateChange_arrayI));
			}
			return BadgeDrawable.cb_onStateChange_arrayI;
		}

		// Token: 0x0600049D RID: 1181 RVA: 0x0000CF54 File Offset: 0x0000B154
		private static bool n_OnStateChange_arrayI(IntPtr jnienv, IntPtr native__this, IntPtr native_state)
		{
			BadgeDrawable @object = Java.Lang.Object.GetObject<BadgeDrawable>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			int[] array = (int[])JNIEnv.GetArray(native_state, JniHandleOwnership.DoNotTransfer, typeof(int));
			bool result = @object.OnStateChange(array);
			if (array != null)
			{
				JNIEnv.CopyArray(array, native_state);
			}
			return result;
		}

		// Token: 0x0600049E RID: 1182 RVA: 0x0000CF90 File Offset: 0x0000B190
		[Register("onStateChange", "([I)Z", "GetOnStateChange_arrayIHandler")]
		public new unsafe virtual bool OnStateChange(int[] state)
		{
			IntPtr intPtr = JNIEnv.NewArray(state);
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				result = BadgeDrawable._members.InstanceMethods.InvokeVirtualBooleanMethod("onStateChange.([I)Z", this, ptr);
			}
			finally
			{
				if (state != null)
				{
					JNIEnv.CopyArray(intPtr, state);
					JNIEnv.DeleteLocalRef(intPtr);
				}
				GC.KeepAlive(state);
			}
			return result;
		}

		// Token: 0x0600049F RID: 1183 RVA: 0x0000D000 File Offset: 0x0000B200
		private static Delegate GetOnTextSizeChangeHandler()
		{
			if (BadgeDrawable.cb_onTextSizeChange == null)
			{
				BadgeDrawable.cb_onTextSizeChange = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(BadgeDrawable.n_OnTextSizeChange));
			}
			return BadgeDrawable.cb_onTextSizeChange;
		}

		// Token: 0x060004A0 RID: 1184 RVA: 0x0000D024 File Offset: 0x0000B224
		private static void n_OnTextSizeChange(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<BadgeDrawable>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).OnTextSizeChange();
		}

		// Token: 0x060004A1 RID: 1185 RVA: 0x0000D033 File Offset: 0x0000B233
		[Register("onTextSizeChange", "()V", "GetOnTextSizeChangeHandler")]
		public virtual void OnTextSizeChange()
		{
			BadgeDrawable._members.InstanceMethods.InvokeVirtualVoidMethod("onTextSizeChange.()V", this, null);
		}

		// Token: 0x060004A2 RID: 1186 RVA: 0x0000D04C File Offset: 0x0000B24C
		private static Delegate GetSetAlpha_IHandler()
		{
			if (BadgeDrawable.cb_setAlpha_I == null)
			{
				BadgeDrawable.cb_setAlpha_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_V(BadgeDrawable.n_SetAlpha_I));
			}
			return BadgeDrawable.cb_setAlpha_I;
		}

		// Token: 0x060004A3 RID: 1187 RVA: 0x0000D070 File Offset: 0x0000B270
		private static void n_SetAlpha_I(IntPtr jnienv, IntPtr native__this, int alpha)
		{
			Java.Lang.Object.GetObject<BadgeDrawable>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SetAlpha(alpha);
		}

		// Token: 0x060004A4 RID: 1188 RVA: 0x0000D080 File Offset: 0x0000B280
		[Register("setAlpha", "(I)V", "GetSetAlpha_IHandler")]
		public unsafe override void SetAlpha(int alpha)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(alpha);
			BadgeDrawable._members.InstanceMethods.InvokeVirtualVoidMethod("setAlpha.(I)V", this, ptr);
		}

		// Token: 0x060004A5 RID: 1189 RVA: 0x0000D0BB File Offset: 0x0000B2BB
		private static Delegate GetSetBadgeWithTextShapeAppearance_IHandler()
		{
			if (BadgeDrawable.cb_setBadgeWithTextShapeAppearance_I == null)
			{
				BadgeDrawable.cb_setBadgeWithTextShapeAppearance_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_V(BadgeDrawable.n_SetBadgeWithTextShapeAppearance_I));
			}
			return BadgeDrawable.cb_setBadgeWithTextShapeAppearance_I;
		}

		// Token: 0x060004A6 RID: 1190 RVA: 0x0000D0DF File Offset: 0x0000B2DF
		private static void n_SetBadgeWithTextShapeAppearance_I(IntPtr jnienv, IntPtr native__this, int id)
		{
			Java.Lang.Object.GetObject<BadgeDrawable>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SetBadgeWithTextShapeAppearance(id);
		}

		// Token: 0x060004A7 RID: 1191 RVA: 0x0000D0F0 File Offset: 0x0000B2F0
		[Register("setBadgeWithTextShapeAppearance", "(I)V", "GetSetBadgeWithTextShapeAppearance_IHandler")]
		public unsafe virtual void SetBadgeWithTextShapeAppearance(int id)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(id);
			BadgeDrawable._members.InstanceMethods.InvokeVirtualVoidMethod("setBadgeWithTextShapeAppearance.(I)V", this, ptr);
		}

		// Token: 0x060004A8 RID: 1192 RVA: 0x0000D12B File Offset: 0x0000B32B
		private static Delegate GetSetBadgeWithTextShapeAppearanceOverlay_IHandler()
		{
			if (BadgeDrawable.cb_setBadgeWithTextShapeAppearanceOverlay_I == null)
			{
				BadgeDrawable.cb_setBadgeWithTextShapeAppearanceOverlay_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_V(BadgeDrawable.n_SetBadgeWithTextShapeAppearanceOverlay_I));
			}
			return BadgeDrawable.cb_setBadgeWithTextShapeAppearanceOverlay_I;
		}

		// Token: 0x060004A9 RID: 1193 RVA: 0x0000D14F File Offset: 0x0000B34F
		private static void n_SetBadgeWithTextShapeAppearanceOverlay_I(IntPtr jnienv, IntPtr native__this, int id)
		{
			Java.Lang.Object.GetObject<BadgeDrawable>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SetBadgeWithTextShapeAppearanceOverlay(id);
		}

		// Token: 0x060004AA RID: 1194 RVA: 0x0000D160 File Offset: 0x0000B360
		[Register("setBadgeWithTextShapeAppearanceOverlay", "(I)V", "GetSetBadgeWithTextShapeAppearanceOverlay_IHandler")]
		public unsafe virtual void SetBadgeWithTextShapeAppearanceOverlay(int id)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(id);
			BadgeDrawable._members.InstanceMethods.InvokeVirtualVoidMethod("setBadgeWithTextShapeAppearanceOverlay.(I)V", this, ptr);
		}

		// Token: 0x060004AB RID: 1195 RVA: 0x0000D19B File Offset: 0x0000B39B
		private static Delegate GetSetBadgeWithoutTextShapeAppearance_IHandler()
		{
			if (BadgeDrawable.cb_setBadgeWithoutTextShapeAppearance_I == null)
			{
				BadgeDrawable.cb_setBadgeWithoutTextShapeAppearance_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_V(BadgeDrawable.n_SetBadgeWithoutTextShapeAppearance_I));
			}
			return BadgeDrawable.cb_setBadgeWithoutTextShapeAppearance_I;
		}

		// Token: 0x060004AC RID: 1196 RVA: 0x0000D1BF File Offset: 0x0000B3BF
		private static void n_SetBadgeWithoutTextShapeAppearance_I(IntPtr jnienv, IntPtr native__this, int id)
		{
			Java.Lang.Object.GetObject<BadgeDrawable>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SetBadgeWithoutTextShapeAppearance(id);
		}

		// Token: 0x060004AD RID: 1197 RVA: 0x0000D1D0 File Offset: 0x0000B3D0
		[Register("setBadgeWithoutTextShapeAppearance", "(I)V", "GetSetBadgeWithoutTextShapeAppearance_IHandler")]
		public unsafe virtual void SetBadgeWithoutTextShapeAppearance(int id)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(id);
			BadgeDrawable._members.InstanceMethods.InvokeVirtualVoidMethod("setBadgeWithoutTextShapeAppearance.(I)V", this, ptr);
		}

		// Token: 0x060004AE RID: 1198 RVA: 0x0000D20B File Offset: 0x0000B40B
		private static Delegate GetSetBadgeWithoutTextShapeAppearanceOverlay_IHandler()
		{
			if (BadgeDrawable.cb_setBadgeWithoutTextShapeAppearanceOverlay_I == null)
			{
				BadgeDrawable.cb_setBadgeWithoutTextShapeAppearanceOverlay_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_V(BadgeDrawable.n_SetBadgeWithoutTextShapeAppearanceOverlay_I));
			}
			return BadgeDrawable.cb_setBadgeWithoutTextShapeAppearanceOverlay_I;
		}

		// Token: 0x060004AF RID: 1199 RVA: 0x0000D22F File Offset: 0x0000B42F
		private static void n_SetBadgeWithoutTextShapeAppearanceOverlay_I(IntPtr jnienv, IntPtr native__this, int id)
		{
			Java.Lang.Object.GetObject<BadgeDrawable>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SetBadgeWithoutTextShapeAppearanceOverlay(id);
		}

		// Token: 0x060004B0 RID: 1200 RVA: 0x0000D240 File Offset: 0x0000B440
		[Register("setBadgeWithoutTextShapeAppearanceOverlay", "(I)V", "GetSetBadgeWithoutTextShapeAppearanceOverlay_IHandler")]
		public unsafe virtual void SetBadgeWithoutTextShapeAppearanceOverlay(int id)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(id);
			BadgeDrawable._members.InstanceMethods.InvokeVirtualVoidMethod("setBadgeWithoutTextShapeAppearanceOverlay.(I)V", this, ptr);
		}

		// Token: 0x060004B1 RID: 1201 RVA: 0x0000D27B File Offset: 0x0000B47B
		private static Delegate GetSetColorFilter_Landroid_graphics_ColorFilter_Handler()
		{
			if (BadgeDrawable.cb_setColorFilter_Landroid_graphics_ColorFilter_ == null)
			{
				BadgeDrawable.cb_setColorFilter_Landroid_graphics_ColorFilter_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(BadgeDrawable.n_SetColorFilter_Landroid_graphics_ColorFilter_));
			}
			return BadgeDrawable.cb_setColorFilter_Landroid_graphics_ColorFilter_;
		}

		// Token: 0x060004B2 RID: 1202 RVA: 0x0000D2A0 File Offset: 0x0000B4A0
		private static void n_SetColorFilter_Landroid_graphics_ColorFilter_(IntPtr jnienv, IntPtr native__this, IntPtr native_colorFilter)
		{
			Drawable @object = Java.Lang.Object.GetObject<BadgeDrawable>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ColorFilter object2 = Java.Lang.Object.GetObject<ColorFilter>(native_colorFilter, JniHandleOwnership.DoNotTransfer);
			@object.SetColorFilter(object2);
		}

		// Token: 0x060004B3 RID: 1203 RVA: 0x0000D2C4 File Offset: 0x0000B4C4
		[Register("setColorFilter", "(Landroid/graphics/ColorFilter;)V", "GetSetColorFilter_Landroid_graphics_ColorFilter_Handler")]
		public unsafe override void SetColorFilter(ColorFilter colorFilter)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((colorFilter == null) ? IntPtr.Zero : colorFilter.Handle);
				BadgeDrawable._members.InstanceMethods.InvokeVirtualVoidMethod("setColorFilter.(Landroid/graphics/ColorFilter;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(colorFilter);
			}
		}

		// Token: 0x060004B4 RID: 1204 RVA: 0x0000D328 File Offset: 0x0000B528
		private static Delegate GetSetContentDescriptionExceedsMaxBadgeNumberStringResource_IHandler()
		{
			if (BadgeDrawable.cb_setContentDescriptionExceedsMaxBadgeNumberStringResource_I == null)
			{
				BadgeDrawable.cb_setContentDescriptionExceedsMaxBadgeNumberStringResource_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_V(BadgeDrawable.n_SetContentDescriptionExceedsMaxBadgeNumberStringResource_I));
			}
			return BadgeDrawable.cb_setContentDescriptionExceedsMaxBadgeNumberStringResource_I;
		}

		// Token: 0x060004B5 RID: 1205 RVA: 0x0000D34C File Offset: 0x0000B54C
		private static void n_SetContentDescriptionExceedsMaxBadgeNumberStringResource_I(IntPtr jnienv, IntPtr native__this, int stringsResource)
		{
			Java.Lang.Object.GetObject<BadgeDrawable>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SetContentDescriptionExceedsMaxBadgeNumberStringResource(stringsResource);
		}

		// Token: 0x060004B6 RID: 1206 RVA: 0x0000D35C File Offset: 0x0000B55C
		[Register("setContentDescriptionExceedsMaxBadgeNumberStringResource", "(I)V", "GetSetContentDescriptionExceedsMaxBadgeNumberStringResource_IHandler")]
		public unsafe virtual void SetContentDescriptionExceedsMaxBadgeNumberStringResource(int stringsResource)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(stringsResource);
			BadgeDrawable._members.InstanceMethods.InvokeVirtualVoidMethod("setContentDescriptionExceedsMaxBadgeNumberStringResource.(I)V", this, ptr);
		}

		// Token: 0x060004B7 RID: 1207 RVA: 0x0000D397 File Offset: 0x0000B597
		private static Delegate GetSetContentDescriptionNumberless_Ljava_lang_CharSequence_Handler()
		{
			if (BadgeDrawable.cb_setContentDescriptionNumberless_Ljava_lang_CharSequence_ == null)
			{
				BadgeDrawable.cb_setContentDescriptionNumberless_Ljava_lang_CharSequence_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(BadgeDrawable.n_SetContentDescriptionNumberless_Ljava_lang_CharSequence_));
			}
			return BadgeDrawable.cb_setContentDescriptionNumberless_Ljava_lang_CharSequence_;
		}

		// Token: 0x060004B8 RID: 1208 RVA: 0x0000D3BC File Offset: 0x0000B5BC
		private static void n_SetContentDescriptionNumberless_Ljava_lang_CharSequence_(IntPtr jnienv, IntPtr native__this, IntPtr native_charSequence)
		{
			BadgeDrawable @object = Java.Lang.Object.GetObject<BadgeDrawable>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ICharSequence object2 = Java.Lang.Object.GetObject<ICharSequence>(native_charSequence, JniHandleOwnership.DoNotTransfer);
			@object.SetContentDescriptionNumberless(object2);
		}

		// Token: 0x060004B9 RID: 1209 RVA: 0x0000D3E0 File Offset: 0x0000B5E0
		[Register("setContentDescriptionNumberless", "(Ljava/lang/CharSequence;)V", "GetSetContentDescriptionNumberless_Ljava_lang_CharSequence_Handler")]
		public unsafe virtual void SetContentDescriptionNumberless(ICharSequence charSequence)
		{
			IntPtr intPtr = CharSequence.ToLocalJniHandle(charSequence);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				BadgeDrawable._members.InstanceMethods.InvokeVirtualVoidMethod("setContentDescriptionNumberless.(Ljava/lang/CharSequence;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(charSequence);
			}
		}

		// Token: 0x060004BA RID: 1210 RVA: 0x0000D444 File Offset: 0x0000B644
		public void SetContentDescriptionNumberless(string charSequence)
		{
			Java.Lang.String @string = (charSequence == null) ? null : new Java.Lang.String(charSequence);
			this.SetContentDescriptionNumberless(@string);
			if (@string != null)
			{
				@string.Dispose();
			}
		}

		// Token: 0x060004BB RID: 1211 RVA: 0x0000D46E File Offset: 0x0000B66E
		private static Delegate GetSetContentDescriptionQuantityStringsResource_IHandler()
		{
			if (BadgeDrawable.cb_setContentDescriptionQuantityStringsResource_I == null)
			{
				BadgeDrawable.cb_setContentDescriptionQuantityStringsResource_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_V(BadgeDrawable.n_SetContentDescriptionQuantityStringsResource_I));
			}
			return BadgeDrawable.cb_setContentDescriptionQuantityStringsResource_I;
		}

		// Token: 0x060004BC RID: 1212 RVA: 0x0000D492 File Offset: 0x0000B692
		private static void n_SetContentDescriptionQuantityStringsResource_I(IntPtr jnienv, IntPtr native__this, int stringsResource)
		{
			Java.Lang.Object.GetObject<BadgeDrawable>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SetContentDescriptionQuantityStringsResource(stringsResource);
		}

		// Token: 0x060004BD RID: 1213 RVA: 0x0000D4A4 File Offset: 0x0000B6A4
		[Register("setContentDescriptionQuantityStringsResource", "(I)V", "GetSetContentDescriptionQuantityStringsResource_IHandler")]
		public unsafe virtual void SetContentDescriptionQuantityStringsResource(int stringsResource)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(stringsResource);
			BadgeDrawable._members.InstanceMethods.InvokeVirtualVoidMethod("setContentDescriptionQuantityStringsResource.(I)V", this, ptr);
		}

		// Token: 0x060004BE RID: 1214 RVA: 0x0000D4DF File Offset: 0x0000B6DF
		private static Delegate GetSetTextAppearance_IHandler()
		{
			if (BadgeDrawable.cb_setTextAppearance_I == null)
			{
				BadgeDrawable.cb_setTextAppearance_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_V(BadgeDrawable.n_SetTextAppearance_I));
			}
			return BadgeDrawable.cb_setTextAppearance_I;
		}

		// Token: 0x060004BF RID: 1215 RVA: 0x0000D503 File Offset: 0x0000B703
		private static void n_SetTextAppearance_I(IntPtr jnienv, IntPtr native__this, int id)
		{
			Java.Lang.Object.GetObject<BadgeDrawable>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SetTextAppearance(id);
		}

		// Token: 0x060004C0 RID: 1216 RVA: 0x0000D514 File Offset: 0x0000B714
		[Register("setTextAppearance", "(I)V", "GetSetTextAppearance_IHandler")]
		public unsafe virtual void SetTextAppearance(int id)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(id);
			BadgeDrawable._members.InstanceMethods.InvokeVirtualVoidMethod("setTextAppearance.(I)V", this, ptr);
		}

		// Token: 0x060004C1 RID: 1217 RVA: 0x0000D54F File Offset: 0x0000B74F
		private static Delegate GetSetVisible_ZHandler()
		{
			if (BadgeDrawable.cb_setVisible_Z == null)
			{
				BadgeDrawable.cb_setVisible_Z = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPZ_V(BadgeDrawable.n_SetVisible_Z));
			}
			return BadgeDrawable.cb_setVisible_Z;
		}

		// Token: 0x060004C2 RID: 1218 RVA: 0x0000D573 File Offset: 0x0000B773
		private static void n_SetVisible_Z(IntPtr jnienv, IntPtr native__this, bool visible)
		{
			Java.Lang.Object.GetObject<BadgeDrawable>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SetVisible(visible);
		}

		// Token: 0x060004C3 RID: 1219 RVA: 0x0000D584 File Offset: 0x0000B784
		[Register("setVisible", "(Z)V", "GetSetVisible_ZHandler")]
		public unsafe virtual void SetVisible(bool visible)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(visible);
			BadgeDrawable._members.InstanceMethods.InvokeVirtualVoidMethod("setVisible.(Z)V", this, ptr);
		}

		// Token: 0x060004C4 RID: 1220 RVA: 0x0000D5BF File Offset: 0x0000B7BF
		private static Delegate GetUpdateBadgeCoordinates_Landroid_view_View_Handler()
		{
			if (BadgeDrawable.cb_updateBadgeCoordinates_Landroid_view_View_ == null)
			{
				BadgeDrawable.cb_updateBadgeCoordinates_Landroid_view_View_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(BadgeDrawable.n_UpdateBadgeCoordinates_Landroid_view_View_));
			}
			return BadgeDrawable.cb_updateBadgeCoordinates_Landroid_view_View_;
		}

		// Token: 0x060004C5 RID: 1221 RVA: 0x0000D5E4 File Offset: 0x0000B7E4
		private static void n_UpdateBadgeCoordinates_Landroid_view_View_(IntPtr jnienv, IntPtr native__this, IntPtr native_anchorView)
		{
			BadgeDrawable @object = Java.Lang.Object.GetObject<BadgeDrawable>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			View object2 = Java.Lang.Object.GetObject<View>(native_anchorView, JniHandleOwnership.DoNotTransfer);
			@object.UpdateBadgeCoordinates(object2);
		}

		// Token: 0x060004C6 RID: 1222 RVA: 0x0000D608 File Offset: 0x0000B808
		[Register("updateBadgeCoordinates", "(Landroid/view/View;)V", "GetUpdateBadgeCoordinates_Landroid_view_View_Handler")]
		public unsafe virtual void UpdateBadgeCoordinates(View anchorView)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((anchorView == null) ? IntPtr.Zero : anchorView.Handle);
				BadgeDrawable._members.InstanceMethods.InvokeVirtualVoidMethod("updateBadgeCoordinates.(Landroid/view/View;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(anchorView);
			}
		}

		// Token: 0x060004C7 RID: 1223 RVA: 0x0000D66C File Offset: 0x0000B86C
		private static Delegate GetUpdateBadgeCoordinates_Landroid_view_View_Landroid_view_ViewGroup_Handler()
		{
			if (BadgeDrawable.cb_updateBadgeCoordinates_Landroid_view_View_Landroid_view_ViewGroup_ == null)
			{
				BadgeDrawable.cb_updateBadgeCoordinates_Landroid_view_View_Landroid_view_ViewGroup_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_V(BadgeDrawable.n_UpdateBadgeCoordinates_Landroid_view_View_Landroid_view_ViewGroup_));
			}
			return BadgeDrawable.cb_updateBadgeCoordinates_Landroid_view_View_Landroid_view_ViewGroup_;
		}

		// Token: 0x060004C8 RID: 1224 RVA: 0x0000D690 File Offset: 0x0000B890
		private static void n_UpdateBadgeCoordinates_Landroid_view_View_Landroid_view_ViewGroup_(IntPtr jnienv, IntPtr native__this, IntPtr native_anchorView, IntPtr native_customBadgeParent)
		{
			BadgeDrawable @object = Java.Lang.Object.GetObject<BadgeDrawable>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			View object2 = Java.Lang.Object.GetObject<View>(native_anchorView, JniHandleOwnership.DoNotTransfer);
			ViewGroup object3 = Java.Lang.Object.GetObject<ViewGroup>(native_customBadgeParent, JniHandleOwnership.DoNotTransfer);
			@object.UpdateBadgeCoordinates(object2, object3);
		}

		// Token: 0x060004C9 RID: 1225 RVA: 0x0000D6BC File Offset: 0x0000B8BC
		[Register("updateBadgeCoordinates", "(Landroid/view/View;Landroid/view/ViewGroup;)V", "GetUpdateBadgeCoordinates_Landroid_view_View_Landroid_view_ViewGroup_Handler")]
		public unsafe virtual void UpdateBadgeCoordinates(View anchorView, ViewGroup customBadgeParent)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((anchorView == null) ? IntPtr.Zero : anchorView.Handle);
				ptr[1] = new JniArgumentValue((customBadgeParent == null) ? IntPtr.Zero : customBadgeParent.Handle);
				BadgeDrawable._members.InstanceMethods.InvokeVirtualVoidMethod("updateBadgeCoordinates.(Landroid/view/View;Landroid/view/ViewGroup;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(anchorView);
				GC.KeepAlive(customBadgeParent);
			}
		}

		// Token: 0x060004CA RID: 1226 RVA: 0x0000D748 File Offset: 0x0000B948
		private static Delegate GetUpdateBadgeCoordinates_Landroid_view_View_Landroid_widget_FrameLayout_Handler()
		{
			if (BadgeDrawable.cb_updateBadgeCoordinates_Landroid_view_View_Landroid_widget_FrameLayout_ == null)
			{
				BadgeDrawable.cb_updateBadgeCoordinates_Landroid_view_View_Landroid_widget_FrameLayout_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_V(BadgeDrawable.n_UpdateBadgeCoordinates_Landroid_view_View_Landroid_widget_FrameLayout_));
			}
			return BadgeDrawable.cb_updateBadgeCoordinates_Landroid_view_View_Landroid_widget_FrameLayout_;
		}

		// Token: 0x060004CB RID: 1227 RVA: 0x0000D76C File Offset: 0x0000B96C
		private static void n_UpdateBadgeCoordinates_Landroid_view_View_Landroid_widget_FrameLayout_(IntPtr jnienv, IntPtr native__this, IntPtr native_anchorView, IntPtr native_customBadgeParent)
		{
			BadgeDrawable @object = Java.Lang.Object.GetObject<BadgeDrawable>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			View object2 = Java.Lang.Object.GetObject<View>(native_anchorView, JniHandleOwnership.DoNotTransfer);
			FrameLayout object3 = Java.Lang.Object.GetObject<FrameLayout>(native_customBadgeParent, JniHandleOwnership.DoNotTransfer);
			@object.UpdateBadgeCoordinates(object2, object3);
		}

		// Token: 0x060004CC RID: 1228 RVA: 0x0000D798 File Offset: 0x0000B998
		[Register("updateBadgeCoordinates", "(Landroid/view/View;Landroid/widget/FrameLayout;)V", "GetUpdateBadgeCoordinates_Landroid_view_View_Landroid_widget_FrameLayout_Handler")]
		public unsafe virtual void UpdateBadgeCoordinates(View anchorView, FrameLayout customBadgeParent)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((anchorView == null) ? IntPtr.Zero : anchorView.Handle);
				ptr[1] = new JniArgumentValue((customBadgeParent == null) ? IntPtr.Zero : customBadgeParent.Handle);
				BadgeDrawable._members.InstanceMethods.InvokeVirtualVoidMethod("updateBadgeCoordinates.(Landroid/view/View;Landroid/widget/FrameLayout;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(anchorView);
				GC.KeepAlive(customBadgeParent);
			}
		}

		// Token: 0x04000103 RID: 259
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/google/android/material/badge/BadgeDrawable", typeof(BadgeDrawable));

		// Token: 0x04000104 RID: 260
		private static Delegate cb_getBackgroundColor;

		// Token: 0x04000105 RID: 261
		private static Delegate cb_setBackgroundColor_I;

		// Token: 0x04000106 RID: 262
		private static Delegate cb_getBadgeGravity;

		// Token: 0x04000107 RID: 263
		private static Delegate cb_setBadgeGravity_I;

		// Token: 0x04000108 RID: 264
		private static Delegate cb_getBadgeNumberLocale;

		// Token: 0x04000109 RID: 265
		private static Delegate cb_setBadgeNumberLocale_Ljava_util_Locale_;

		// Token: 0x0400010A RID: 266
		private static Delegate cb_getBadgeTextColor;

		// Token: 0x0400010B RID: 267
		private static Delegate cb_setBadgeTextColor_I;

		// Token: 0x0400010C RID: 268
		private static Delegate cb_getContentDescription;

		// Token: 0x0400010D RID: 269
		private static Delegate cb_getCustomBadgeParent;

		// Token: 0x0400010E RID: 270
		private static Delegate cb_hasNumber;

		// Token: 0x0400010F RID: 271
		private static Delegate cb_getHorizontalOffset;

		// Token: 0x04000110 RID: 272
		private static Delegate cb_setHorizontalOffset_I;

		// Token: 0x04000111 RID: 273
		private static Delegate cb_getHorizontalOffsetWithText;

		// Token: 0x04000112 RID: 274
		private static Delegate cb_setHorizontalOffsetWithText_I;

		// Token: 0x04000113 RID: 275
		private static Delegate cb_getHorizontalOffsetWithoutText;

		// Token: 0x04000114 RID: 276
		private static Delegate cb_setHorizontalOffsetWithoutText_I;

		// Token: 0x04000115 RID: 277
		private static Delegate cb_getMaxCharacterCount;

		// Token: 0x04000116 RID: 278
		private static Delegate cb_setMaxCharacterCount_I;

		// Token: 0x04000117 RID: 279
		private static Delegate cb_getNumber;

		// Token: 0x04000118 RID: 280
		private static Delegate cb_setNumber_I;

		// Token: 0x04000119 RID: 281
		private static Delegate cb_getOpacity;

		// Token: 0x0400011A RID: 282
		private static Delegate cb_getVerticalOffset;

		// Token: 0x0400011B RID: 283
		private static Delegate cb_setVerticalOffset_I;

		// Token: 0x0400011C RID: 284
		private static Delegate cb_getVerticalOffsetWithText;

		// Token: 0x0400011D RID: 285
		private static Delegate cb_setVerticalOffsetWithText_I;

		// Token: 0x0400011E RID: 286
		private static Delegate cb_getVerticalOffsetWithoutText;

		// Token: 0x0400011F RID: 287
		private static Delegate cb_setVerticalOffsetWithoutText_I;

		// Token: 0x04000120 RID: 288
		private static Delegate cb_clearNumber;

		// Token: 0x04000121 RID: 289
		private static Delegate cb_draw_Landroid_graphics_Canvas_;

		// Token: 0x04000122 RID: 290
		private static Delegate cb_onStateChange_arrayI;

		// Token: 0x04000123 RID: 291
		private static Delegate cb_onTextSizeChange;

		// Token: 0x04000124 RID: 292
		private static Delegate cb_setAlpha_I;

		// Token: 0x04000125 RID: 293
		private static Delegate cb_setBadgeWithTextShapeAppearance_I;

		// Token: 0x04000126 RID: 294
		private static Delegate cb_setBadgeWithTextShapeAppearanceOverlay_I;

		// Token: 0x04000127 RID: 295
		private static Delegate cb_setBadgeWithoutTextShapeAppearance_I;

		// Token: 0x04000128 RID: 296
		private static Delegate cb_setBadgeWithoutTextShapeAppearanceOverlay_I;

		// Token: 0x04000129 RID: 297
		private static Delegate cb_setColorFilter_Landroid_graphics_ColorFilter_;

		// Token: 0x0400012A RID: 298
		private static Delegate cb_setContentDescriptionExceedsMaxBadgeNumberStringResource_I;

		// Token: 0x0400012B RID: 299
		private static Delegate cb_setContentDescriptionNumberless_Ljava_lang_CharSequence_;

		// Token: 0x0400012C RID: 300
		private static Delegate cb_setContentDescriptionQuantityStringsResource_I;

		// Token: 0x0400012D RID: 301
		private static Delegate cb_setTextAppearance_I;

		// Token: 0x0400012E RID: 302
		private static Delegate cb_setVisible_Z;

		// Token: 0x0400012F RID: 303
		private static Delegate cb_updateBadgeCoordinates_Landroid_view_View_;

		// Token: 0x04000130 RID: 304
		private static Delegate cb_updateBadgeCoordinates_Landroid_view_View_Landroid_view_ViewGroup_;

		// Token: 0x04000131 RID: 305
		private static Delegate cb_updateBadgeCoordinates_Landroid_view_View_Landroid_widget_FrameLayout_;
	}
}
