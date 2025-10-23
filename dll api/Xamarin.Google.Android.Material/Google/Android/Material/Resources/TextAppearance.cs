using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Content;
using Android.Content.Res;
using Android.Graphics;
using Android.Runtime;
using Android.Text;
using Java.Interop;
using Java.Lang;

namespace Google.Android.Material.Resources
{
	// Token: 0x02000041 RID: 65
	[Register("com/google/android/material/resources/TextAppearance", DoNotGenerateAcw = true)]
	public class TextAppearance : Java.Lang.Object
	{
		// Token: 0x17000036 RID: 54
		// (get) Token: 0x060001A2 RID: 418 RVA: 0x00005058 File Offset: 0x00003258
		// (set) Token: 0x060001A3 RID: 419 RVA: 0x00005088 File Offset: 0x00003288
		[Register("fontFamily")]
		public string FontFamily
		{
			get
			{
				return JNIEnv.GetString(TextAppearance._members.InstanceFields.GetObjectValue("fontFamily.Ljava/lang/String;", this).Handle, JniHandleOwnership.TransferLocalRef);
			}
			set
			{
				IntPtr intPtr = JNIEnv.NewString(value);
				try
				{
					TextAppearance._members.InstanceFields.SetValue("fontFamily.Ljava/lang/String;", this, new JniObjectReference(intPtr, JniObjectReferenceType.Invalid));
				}
				finally
				{
					JNIEnv.DeleteLocalRef(intPtr);
				}
			}
		}

		// Token: 0x17000037 RID: 55
		// (get) Token: 0x060001A4 RID: 420 RVA: 0x000050D4 File Offset: 0x000032D4
		// (set) Token: 0x060001A5 RID: 421 RVA: 0x000050EB File Offset: 0x000032EB
		[Register("hasLetterSpacing")]
		public bool HasLetterSpacing
		{
			get
			{
				return TextAppearance._members.InstanceFields.GetBooleanValue("hasLetterSpacing.Z", this);
			}
			set
			{
				TextAppearance._members.InstanceFields.SetValue("hasLetterSpacing.Z", this, value);
			}
		}

		// Token: 0x17000038 RID: 56
		// (get) Token: 0x060001A6 RID: 422 RVA: 0x00005103 File Offset: 0x00003303
		// (set) Token: 0x060001A7 RID: 423 RVA: 0x0000511A File Offset: 0x0000331A
		[Register("letterSpacing")]
		public float LetterSpacing
		{
			get
			{
				return TextAppearance._members.InstanceFields.GetSingleValue("letterSpacing.F", this);
			}
			set
			{
				TextAppearance._members.InstanceFields.SetValue("letterSpacing.F", this, value);
			}
		}

		// Token: 0x17000039 RID: 57
		// (get) Token: 0x060001A8 RID: 424 RVA: 0x00005134 File Offset: 0x00003334
		// (set) Token: 0x060001A9 RID: 425 RVA: 0x00005164 File Offset: 0x00003364
		[Register("shadowColor")]
		public ColorStateList ShadowColor
		{
			get
			{
				return Java.Lang.Object.GetObject<ColorStateList>(TextAppearance._members.InstanceFields.GetObjectValue("shadowColor.Landroid/content/res/ColorStateList;", this).Handle, JniHandleOwnership.TransferLocalRef);
			}
			set
			{
				IntPtr intPtr = JNIEnv.ToLocalJniHandle(value);
				try
				{
					TextAppearance._members.InstanceFields.SetValue("shadowColor.Landroid/content/res/ColorStateList;", this, new JniObjectReference(intPtr, JniObjectReferenceType.Invalid));
				}
				finally
				{
					JNIEnv.DeleteLocalRef(intPtr);
				}
			}
		}

		// Token: 0x1700003A RID: 58
		// (get) Token: 0x060001AA RID: 426 RVA: 0x000051B0 File Offset: 0x000033B0
		// (set) Token: 0x060001AB RID: 427 RVA: 0x000051C7 File Offset: 0x000033C7
		[Register("shadowDx")]
		public float ShadowDx
		{
			get
			{
				return TextAppearance._members.InstanceFields.GetSingleValue("shadowDx.F", this);
			}
			set
			{
				TextAppearance._members.InstanceFields.SetValue("shadowDx.F", this, value);
			}
		}

		// Token: 0x1700003B RID: 59
		// (get) Token: 0x060001AC RID: 428 RVA: 0x000051DF File Offset: 0x000033DF
		// (set) Token: 0x060001AD RID: 429 RVA: 0x000051F6 File Offset: 0x000033F6
		[Register("shadowDy")]
		public float ShadowDy
		{
			get
			{
				return TextAppearance._members.InstanceFields.GetSingleValue("shadowDy.F", this);
			}
			set
			{
				TextAppearance._members.InstanceFields.SetValue("shadowDy.F", this, value);
			}
		}

		// Token: 0x1700003C RID: 60
		// (get) Token: 0x060001AE RID: 430 RVA: 0x0000520E File Offset: 0x0000340E
		// (set) Token: 0x060001AF RID: 431 RVA: 0x00005225 File Offset: 0x00003425
		[Register("shadowRadius")]
		public float ShadowRadius
		{
			get
			{
				return TextAppearance._members.InstanceFields.GetSingleValue("shadowRadius.F", this);
			}
			set
			{
				TextAppearance._members.InstanceFields.SetValue("shadowRadius.F", this, value);
			}
		}

		// Token: 0x1700003D RID: 61
		// (get) Token: 0x060001B0 RID: 432 RVA: 0x0000523D File Offset: 0x0000343D
		// (set) Token: 0x060001B1 RID: 433 RVA: 0x00005254 File Offset: 0x00003454
		[Register("textAllCaps")]
		public bool TextAllCaps
		{
			get
			{
				return TextAppearance._members.InstanceFields.GetBooleanValue("textAllCaps.Z", this);
			}
			set
			{
				TextAppearance._members.InstanceFields.SetValue("textAllCaps.Z", this, value);
			}
		}

		// Token: 0x1700003E RID: 62
		// (get) Token: 0x060001B2 RID: 434 RVA: 0x0000526C File Offset: 0x0000346C
		// (set) Token: 0x060001B3 RID: 435 RVA: 0x0000529C File Offset: 0x0000349C
		[Register("textColorHint")]
		public ColorStateList TextColorHint
		{
			get
			{
				return Java.Lang.Object.GetObject<ColorStateList>(TextAppearance._members.InstanceFields.GetObjectValue("textColorHint.Landroid/content/res/ColorStateList;", this).Handle, JniHandleOwnership.TransferLocalRef);
			}
			set
			{
				IntPtr intPtr = JNIEnv.ToLocalJniHandle(value);
				try
				{
					TextAppearance._members.InstanceFields.SetValue("textColorHint.Landroid/content/res/ColorStateList;", this, new JniObjectReference(intPtr, JniObjectReferenceType.Invalid));
				}
				finally
				{
					JNIEnv.DeleteLocalRef(intPtr);
				}
			}
		}

		// Token: 0x1700003F RID: 63
		// (get) Token: 0x060001B4 RID: 436 RVA: 0x000052E8 File Offset: 0x000034E8
		// (set) Token: 0x060001B5 RID: 437 RVA: 0x00005318 File Offset: 0x00003518
		[Register("textColorLink")]
		public ColorStateList TextColorLink
		{
			get
			{
				return Java.Lang.Object.GetObject<ColorStateList>(TextAppearance._members.InstanceFields.GetObjectValue("textColorLink.Landroid/content/res/ColorStateList;", this).Handle, JniHandleOwnership.TransferLocalRef);
			}
			set
			{
				IntPtr intPtr = JNIEnv.ToLocalJniHandle(value);
				try
				{
					TextAppearance._members.InstanceFields.SetValue("textColorLink.Landroid/content/res/ColorStateList;", this, new JniObjectReference(intPtr, JniObjectReferenceType.Invalid));
				}
				finally
				{
					JNIEnv.DeleteLocalRef(intPtr);
				}
			}
		}

		// Token: 0x17000040 RID: 64
		// (get) Token: 0x060001B6 RID: 438 RVA: 0x00005364 File Offset: 0x00003564
		// (set) Token: 0x060001B7 RID: 439 RVA: 0x0000537B File Offset: 0x0000357B
		[Register("textStyle")]
		public int TextStyle
		{
			get
			{
				return TextAppearance._members.InstanceFields.GetInt32Value("textStyle.I", this);
			}
			set
			{
				TextAppearance._members.InstanceFields.SetValue("textStyle.I", this, value);
			}
		}

		// Token: 0x17000041 RID: 65
		// (get) Token: 0x060001B8 RID: 440 RVA: 0x00005393 File Offset: 0x00003593
		// (set) Token: 0x060001B9 RID: 441 RVA: 0x000053AA File Offset: 0x000035AA
		[Register("typeface")]
		public int Typeface
		{
			get
			{
				return TextAppearance._members.InstanceFields.GetInt32Value("typeface.I", this);
			}
			set
			{
				TextAppearance._members.InstanceFields.SetValue("typeface.I", this, value);
			}
		}

		// Token: 0x17000042 RID: 66
		// (get) Token: 0x060001BA RID: 442 RVA: 0x000053C4 File Offset: 0x000035C4
		internal static IntPtr class_ref
		{
			get
			{
				return TextAppearance._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000043 RID: 67
		// (get) Token: 0x060001BB RID: 443 RVA: 0x000053E8 File Offset: 0x000035E8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return TextAppearance._members;
			}
		}

		// Token: 0x17000044 RID: 68
		// (get) Token: 0x060001BC RID: 444 RVA: 0x000053F0 File Offset: 0x000035F0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return TextAppearance._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000045 RID: 69
		// (get) Token: 0x060001BD RID: 445 RVA: 0x00005414 File Offset: 0x00003614
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return TextAppearance._members.ManagedPeerType;
			}
		}

		// Token: 0x060001BE RID: 446 RVA: 0x000020DC File Offset: 0x000002DC
		protected TextAppearance(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x060001BF RID: 447 RVA: 0x00005420 File Offset: 0x00003620
		[Register(".ctor", "(Landroid/content/Context;I)V", "")]
		public unsafe TextAppearance(Context context, int id) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((context == null) ? IntPtr.Zero : context.Handle);
				ptr[1] = new JniArgumentValue(id);
				base.SetHandle(TextAppearance._members.InstanceMethods.StartCreateInstance("(Landroid/content/Context;I)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				TextAppearance._members.InstanceMethods.FinishCreateInstance("(Landroid/content/Context;I)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(context);
			}
		}

		// Token: 0x060001C0 RID: 448 RVA: 0x000054E0 File Offset: 0x000036E0
		private static Delegate GetGetFallbackFontHandler()
		{
			if (TextAppearance.cb_getFallbackFont == null)
			{
				TextAppearance.cb_getFallbackFont = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(TextAppearance.n_GetFallbackFont));
			}
			return TextAppearance.cb_getFallbackFont;
		}

		// Token: 0x060001C1 RID: 449 RVA: 0x00005504 File Offset: 0x00003704
		private static IntPtr n_GetFallbackFont(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<TextAppearance>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).FallbackFont);
		}

		// Token: 0x17000046 RID: 70
		// (get) Token: 0x060001C2 RID: 450 RVA: 0x00005518 File Offset: 0x00003718
		public virtual Typeface FallbackFont
		{
			[Register("getFallbackFont", "()Landroid/graphics/Typeface;", "GetGetFallbackFontHandler")]
			get
			{
				return Java.Lang.Object.GetObject<Typeface>(TextAppearance._members.InstanceMethods.InvokeVirtualObjectMethod("getFallbackFont.()Landroid/graphics/Typeface;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x060001C3 RID: 451 RVA: 0x0000554A File Offset: 0x0000374A
		private static Delegate GetGetTextColorHandler()
		{
			if (TextAppearance.cb_getTextColor == null)
			{
				TextAppearance.cb_getTextColor = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(TextAppearance.n_GetTextColor));
			}
			return TextAppearance.cb_getTextColor;
		}

		// Token: 0x060001C4 RID: 452 RVA: 0x0000556E File Offset: 0x0000376E
		private static IntPtr n_GetTextColor(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<TextAppearance>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).TextColor);
		}

		// Token: 0x060001C5 RID: 453 RVA: 0x00005582 File Offset: 0x00003782
		private static Delegate GetSetTextColor_Landroid_content_res_ColorStateList_Handler()
		{
			if (TextAppearance.cb_setTextColor_Landroid_content_res_ColorStateList_ == null)
			{
				TextAppearance.cb_setTextColor_Landroid_content_res_ColorStateList_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(TextAppearance.n_SetTextColor_Landroid_content_res_ColorStateList_));
			}
			return TextAppearance.cb_setTextColor_Landroid_content_res_ColorStateList_;
		}

		// Token: 0x060001C6 RID: 454 RVA: 0x000055A8 File Offset: 0x000037A8
		private static void n_SetTextColor_Landroid_content_res_ColorStateList_(IntPtr jnienv, IntPtr native__this, IntPtr native_textColor)
		{
			TextAppearance @object = Java.Lang.Object.GetObject<TextAppearance>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ColorStateList object2 = Java.Lang.Object.GetObject<ColorStateList>(native_textColor, JniHandleOwnership.DoNotTransfer);
			@object.TextColor = object2;
		}

		// Token: 0x17000047 RID: 71
		// (get) Token: 0x060001C7 RID: 455 RVA: 0x000055CC File Offset: 0x000037CC
		// (set) Token: 0x060001C8 RID: 456 RVA: 0x00005600 File Offset: 0x00003800
		public unsafe virtual ColorStateList TextColor
		{
			[Register("getTextColor", "()Landroid/content/res/ColorStateList;", "GetGetTextColorHandler")]
			get
			{
				return Java.Lang.Object.GetObject<ColorStateList>(TextAppearance._members.InstanceMethods.InvokeVirtualObjectMethod("getTextColor.()Landroid/content/res/ColorStateList;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
			[Register("setTextColor", "(Landroid/content/res/ColorStateList;)V", "GetSetTextColor_Landroid_content_res_ColorStateList_Handler")]
			set
			{
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((value == null) ? IntPtr.Zero : value.Handle);
					TextAppearance._members.InstanceMethods.InvokeVirtualVoidMethod("setTextColor.(Landroid/content/res/ColorStateList;)V", this, ptr);
				}
				finally
				{
					GC.KeepAlive(value);
				}
			}
		}

		// Token: 0x060001C9 RID: 457 RVA: 0x00005664 File Offset: 0x00003864
		private static Delegate GetGetTextSizeHandler()
		{
			if (TextAppearance.cb_getTextSize == null)
			{
				TextAppearance.cb_getTextSize = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_F(TextAppearance.n_GetTextSize));
			}
			return TextAppearance.cb_getTextSize;
		}

		// Token: 0x060001CA RID: 458 RVA: 0x00005688 File Offset: 0x00003888
		private static float n_GetTextSize(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<TextAppearance>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).TextSize;
		}

		// Token: 0x060001CB RID: 459 RVA: 0x00005697 File Offset: 0x00003897
		private static Delegate GetSetTextSize_FHandler()
		{
			if (TextAppearance.cb_setTextSize_F == null)
			{
				TextAppearance.cb_setTextSize_F = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPF_V(TextAppearance.n_SetTextSize_F));
			}
			return TextAppearance.cb_setTextSize_F;
		}

		// Token: 0x060001CC RID: 460 RVA: 0x000056BB File Offset: 0x000038BB
		private static void n_SetTextSize_F(IntPtr jnienv, IntPtr native__this, float textSize)
		{
			Java.Lang.Object.GetObject<TextAppearance>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).TextSize = textSize;
		}

		// Token: 0x17000048 RID: 72
		// (get) Token: 0x060001CD RID: 461 RVA: 0x000056CB File Offset: 0x000038CB
		// (set) Token: 0x060001CE RID: 462 RVA: 0x000056E4 File Offset: 0x000038E4
		public unsafe virtual float TextSize
		{
			[Register("getTextSize", "()F", "GetGetTextSizeHandler")]
			get
			{
				return TextAppearance._members.InstanceMethods.InvokeVirtualSingleMethod("getTextSize.()F", this, null);
			}
			[Register("setTextSize", "(F)V", "GetSetTextSize_FHandler")]
			set
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(value);
				TextAppearance._members.InstanceMethods.InvokeVirtualVoidMethod("setTextSize.(F)V", this, ptr);
			}
		}

		// Token: 0x060001CF RID: 463 RVA: 0x0000571F File Offset: 0x0000391F
		private static Delegate GetGetFont_Landroid_content_Context_Handler()
		{
			if (TextAppearance.cb_getFont_Landroid_content_Context_ == null)
			{
				TextAppearance.cb_getFont_Landroid_content_Context_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(TextAppearance.n_GetFont_Landroid_content_Context_));
			}
			return TextAppearance.cb_getFont_Landroid_content_Context_;
		}

		// Token: 0x060001D0 RID: 464 RVA: 0x00005744 File Offset: 0x00003944
		private static IntPtr n_GetFont_Landroid_content_Context_(IntPtr jnienv, IntPtr native__this, IntPtr native_context)
		{
			TextAppearance @object = Java.Lang.Object.GetObject<TextAppearance>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Context object2 = Java.Lang.Object.GetObject<Context>(native_context, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.GetFont(object2));
		}

		// Token: 0x060001D1 RID: 465 RVA: 0x0000576C File Offset: 0x0000396C
		[Register("getFont", "(Landroid/content/Context;)Landroid/graphics/Typeface;", "GetGetFont_Landroid_content_Context_Handler")]
		public unsafe virtual Typeface GetFont(Context context)
		{
			Typeface @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((context == null) ? IntPtr.Zero : context.Handle);
				@object = Java.Lang.Object.GetObject<Typeface>(TextAppearance._members.InstanceMethods.InvokeVirtualObjectMethod("getFont.(Landroid/content/Context;)Landroid/graphics/Typeface;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(context);
			}
			return @object;
		}

		// Token: 0x060001D2 RID: 466 RVA: 0x000057E0 File Offset: 0x000039E0
		private static Delegate GetGetFontAsync_Landroid_content_Context_Landroid_text_TextPaint_Lcom_google_android_material_resources_TextAppearanceFontCallback_Handler()
		{
			if (TextAppearance.cb_getFontAsync_Landroid_content_Context_Landroid_text_TextPaint_Lcom_google_android_material_resources_TextAppearanceFontCallback_ == null)
			{
				TextAppearance.cb_getFontAsync_Landroid_content_Context_Landroid_text_TextPaint_Lcom_google_android_material_resources_TextAppearanceFontCallback_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLLL_V(TextAppearance.n_GetFontAsync_Landroid_content_Context_Landroid_text_TextPaint_Lcom_google_android_material_resources_TextAppearanceFontCallback_));
			}
			return TextAppearance.cb_getFontAsync_Landroid_content_Context_Landroid_text_TextPaint_Lcom_google_android_material_resources_TextAppearanceFontCallback_;
		}

		// Token: 0x060001D3 RID: 467 RVA: 0x00005804 File Offset: 0x00003A04
		private static void n_GetFontAsync_Landroid_content_Context_Landroid_text_TextPaint_Lcom_google_android_material_resources_TextAppearanceFontCallback_(IntPtr jnienv, IntPtr native__this, IntPtr native_context, IntPtr native_textPaint, IntPtr native__callback)
		{
			TextAppearance @object = Java.Lang.Object.GetObject<TextAppearance>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Context object2 = Java.Lang.Object.GetObject<Context>(native_context, JniHandleOwnership.DoNotTransfer);
			TextPaint object3 = Java.Lang.Object.GetObject<TextPaint>(native_textPaint, JniHandleOwnership.DoNotTransfer);
			TextAppearanceFontCallback object4 = Java.Lang.Object.GetObject<TextAppearanceFontCallback>(native__callback, JniHandleOwnership.DoNotTransfer);
			@object.GetFontAsync(object2, object3, object4);
		}

		// Token: 0x060001D4 RID: 468 RVA: 0x0000583C File Offset: 0x00003A3C
		[Register("getFontAsync", "(Landroid/content/Context;Landroid/text/TextPaint;Lcom/google/android/material/resources/TextAppearanceFontCallback;)V", "GetGetFontAsync_Landroid_content_Context_Landroid_text_TextPaint_Lcom_google_android_material_resources_TextAppearanceFontCallback_Handler")]
		public unsafe virtual void GetFontAsync(Context context, TextPaint textPaint, TextAppearanceFontCallback callback)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((context == null) ? IntPtr.Zero : context.Handle);
				ptr[1] = new JniArgumentValue((textPaint == null) ? IntPtr.Zero : textPaint.Handle);
				ptr[2] = new JniArgumentValue((callback == null) ? IntPtr.Zero : callback.Handle);
				TextAppearance._members.InstanceMethods.InvokeVirtualVoidMethod("getFontAsync.(Landroid/content/Context;Landroid/text/TextPaint;Lcom/google/android/material/resources/TextAppearanceFontCallback;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(context);
				GC.KeepAlive(textPaint);
				GC.KeepAlive(callback);
			}
		}

		// Token: 0x060001D5 RID: 469 RVA: 0x000058F4 File Offset: 0x00003AF4
		private static Delegate GetGetFontAsync_Landroid_content_Context_Lcom_google_android_material_resources_TextAppearanceFontCallback_Handler()
		{
			if (TextAppearance.cb_getFontAsync_Landroid_content_Context_Lcom_google_android_material_resources_TextAppearanceFontCallback_ == null)
			{
				TextAppearance.cb_getFontAsync_Landroid_content_Context_Lcom_google_android_material_resources_TextAppearanceFontCallback_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_V(TextAppearance.n_GetFontAsync_Landroid_content_Context_Lcom_google_android_material_resources_TextAppearanceFontCallback_));
			}
			return TextAppearance.cb_getFontAsync_Landroid_content_Context_Lcom_google_android_material_resources_TextAppearanceFontCallback_;
		}

		// Token: 0x060001D6 RID: 470 RVA: 0x00005918 File Offset: 0x00003B18
		private static void n_GetFontAsync_Landroid_content_Context_Lcom_google_android_material_resources_TextAppearanceFontCallback_(IntPtr jnienv, IntPtr native__this, IntPtr native_context, IntPtr native__callback)
		{
			TextAppearance @object = Java.Lang.Object.GetObject<TextAppearance>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Context object2 = Java.Lang.Object.GetObject<Context>(native_context, JniHandleOwnership.DoNotTransfer);
			TextAppearanceFontCallback object3 = Java.Lang.Object.GetObject<TextAppearanceFontCallback>(native__callback, JniHandleOwnership.DoNotTransfer);
			@object.GetFontAsync(object2, object3);
		}

		// Token: 0x060001D7 RID: 471 RVA: 0x00005944 File Offset: 0x00003B44
		[Register("getFontAsync", "(Landroid/content/Context;Lcom/google/android/material/resources/TextAppearanceFontCallback;)V", "GetGetFontAsync_Landroid_content_Context_Lcom_google_android_material_resources_TextAppearanceFontCallback_Handler")]
		public unsafe virtual void GetFontAsync(Context context, TextAppearanceFontCallback callback)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((context == null) ? IntPtr.Zero : context.Handle);
				ptr[1] = new JniArgumentValue((callback == null) ? IntPtr.Zero : callback.Handle);
				TextAppearance._members.InstanceMethods.InvokeVirtualVoidMethod("getFontAsync.(Landroid/content/Context;Lcom/google/android/material/resources/TextAppearanceFontCallback;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(context);
				GC.KeepAlive(callback);
			}
		}

		// Token: 0x060001D8 RID: 472 RVA: 0x000059D0 File Offset: 0x00003BD0
		private static Delegate GetUpdateDrawState_Landroid_content_Context_Landroid_text_TextPaint_Lcom_google_android_material_resources_TextAppearanceFontCallback_Handler()
		{
			if (TextAppearance.cb_updateDrawState_Landroid_content_Context_Landroid_text_TextPaint_Lcom_google_android_material_resources_TextAppearanceFontCallback_ == null)
			{
				TextAppearance.cb_updateDrawState_Landroid_content_Context_Landroid_text_TextPaint_Lcom_google_android_material_resources_TextAppearanceFontCallback_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLLL_V(TextAppearance.n_UpdateDrawState_Landroid_content_Context_Landroid_text_TextPaint_Lcom_google_android_material_resources_TextAppearanceFontCallback_));
			}
			return TextAppearance.cb_updateDrawState_Landroid_content_Context_Landroid_text_TextPaint_Lcom_google_android_material_resources_TextAppearanceFontCallback_;
		}

		// Token: 0x060001D9 RID: 473 RVA: 0x000059F4 File Offset: 0x00003BF4
		private static void n_UpdateDrawState_Landroid_content_Context_Landroid_text_TextPaint_Lcom_google_android_material_resources_TextAppearanceFontCallback_(IntPtr jnienv, IntPtr native__this, IntPtr native_context, IntPtr native_textPaint, IntPtr native__callback)
		{
			TextAppearance @object = Java.Lang.Object.GetObject<TextAppearance>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Context object2 = Java.Lang.Object.GetObject<Context>(native_context, JniHandleOwnership.DoNotTransfer);
			TextPaint object3 = Java.Lang.Object.GetObject<TextPaint>(native_textPaint, JniHandleOwnership.DoNotTransfer);
			TextAppearanceFontCallback object4 = Java.Lang.Object.GetObject<TextAppearanceFontCallback>(native__callback, JniHandleOwnership.DoNotTransfer);
			@object.UpdateDrawState(object2, object3, object4);
		}

		// Token: 0x060001DA RID: 474 RVA: 0x00005A2C File Offset: 0x00003C2C
		[Register("updateDrawState", "(Landroid/content/Context;Landroid/text/TextPaint;Lcom/google/android/material/resources/TextAppearanceFontCallback;)V", "GetUpdateDrawState_Landroid_content_Context_Landroid_text_TextPaint_Lcom_google_android_material_resources_TextAppearanceFontCallback_Handler")]
		public unsafe virtual void UpdateDrawState(Context context, TextPaint textPaint, TextAppearanceFontCallback callback)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((context == null) ? IntPtr.Zero : context.Handle);
				ptr[1] = new JniArgumentValue((textPaint == null) ? IntPtr.Zero : textPaint.Handle);
				ptr[2] = new JniArgumentValue((callback == null) ? IntPtr.Zero : callback.Handle);
				TextAppearance._members.InstanceMethods.InvokeVirtualVoidMethod("updateDrawState.(Landroid/content/Context;Landroid/text/TextPaint;Lcom/google/android/material/resources/TextAppearanceFontCallback;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(context);
				GC.KeepAlive(textPaint);
				GC.KeepAlive(callback);
			}
		}

		// Token: 0x060001DB RID: 475 RVA: 0x00005AE4 File Offset: 0x00003CE4
		private static Delegate GetUpdateMeasureState_Landroid_content_Context_Landroid_text_TextPaint_Lcom_google_android_material_resources_TextAppearanceFontCallback_Handler()
		{
			if (TextAppearance.cb_updateMeasureState_Landroid_content_Context_Landroid_text_TextPaint_Lcom_google_android_material_resources_TextAppearanceFontCallback_ == null)
			{
				TextAppearance.cb_updateMeasureState_Landroid_content_Context_Landroid_text_TextPaint_Lcom_google_android_material_resources_TextAppearanceFontCallback_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLLL_V(TextAppearance.n_UpdateMeasureState_Landroid_content_Context_Landroid_text_TextPaint_Lcom_google_android_material_resources_TextAppearanceFontCallback_));
			}
			return TextAppearance.cb_updateMeasureState_Landroid_content_Context_Landroid_text_TextPaint_Lcom_google_android_material_resources_TextAppearanceFontCallback_;
		}

		// Token: 0x060001DC RID: 476 RVA: 0x00005B08 File Offset: 0x00003D08
		private static void n_UpdateMeasureState_Landroid_content_Context_Landroid_text_TextPaint_Lcom_google_android_material_resources_TextAppearanceFontCallback_(IntPtr jnienv, IntPtr native__this, IntPtr native_context, IntPtr native_textPaint, IntPtr native__callback)
		{
			TextAppearance @object = Java.Lang.Object.GetObject<TextAppearance>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Context object2 = Java.Lang.Object.GetObject<Context>(native_context, JniHandleOwnership.DoNotTransfer);
			TextPaint object3 = Java.Lang.Object.GetObject<TextPaint>(native_textPaint, JniHandleOwnership.DoNotTransfer);
			TextAppearanceFontCallback object4 = Java.Lang.Object.GetObject<TextAppearanceFontCallback>(native__callback, JniHandleOwnership.DoNotTransfer);
			@object.UpdateMeasureState(object2, object3, object4);
		}

		// Token: 0x060001DD RID: 477 RVA: 0x00005B40 File Offset: 0x00003D40
		[Register("updateMeasureState", "(Landroid/content/Context;Landroid/text/TextPaint;Lcom/google/android/material/resources/TextAppearanceFontCallback;)V", "GetUpdateMeasureState_Landroid_content_Context_Landroid_text_TextPaint_Lcom_google_android_material_resources_TextAppearanceFontCallback_Handler")]
		public unsafe virtual void UpdateMeasureState(Context context, TextPaint textPaint, TextAppearanceFontCallback callback)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((context == null) ? IntPtr.Zero : context.Handle);
				ptr[1] = new JniArgumentValue((textPaint == null) ? IntPtr.Zero : textPaint.Handle);
				ptr[2] = new JniArgumentValue((callback == null) ? IntPtr.Zero : callback.Handle);
				TextAppearance._members.InstanceMethods.InvokeVirtualVoidMethod("updateMeasureState.(Landroid/content/Context;Landroid/text/TextPaint;Lcom/google/android/material/resources/TextAppearanceFontCallback;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(context);
				GC.KeepAlive(textPaint);
				GC.KeepAlive(callback);
			}
		}

		// Token: 0x060001DE RID: 478 RVA: 0x00005BF8 File Offset: 0x00003DF8
		private static Delegate GetUpdateTextPaintMeasureState_Landroid_content_Context_Landroid_text_TextPaint_Landroid_graphics_Typeface_Handler()
		{
			if (TextAppearance.cb_updateTextPaintMeasureState_Landroid_content_Context_Landroid_text_TextPaint_Landroid_graphics_Typeface_ == null)
			{
				TextAppearance.cb_updateTextPaintMeasureState_Landroid_content_Context_Landroid_text_TextPaint_Landroid_graphics_Typeface_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLLL_V(TextAppearance.n_UpdateTextPaintMeasureState_Landroid_content_Context_Landroid_text_TextPaint_Landroid_graphics_Typeface_));
			}
			return TextAppearance.cb_updateTextPaintMeasureState_Landroid_content_Context_Landroid_text_TextPaint_Landroid_graphics_Typeface_;
		}

		// Token: 0x060001DF RID: 479 RVA: 0x00005C1C File Offset: 0x00003E1C
		private static void n_UpdateTextPaintMeasureState_Landroid_content_Context_Landroid_text_TextPaint_Landroid_graphics_Typeface_(IntPtr jnienv, IntPtr native__this, IntPtr native_context, IntPtr native_textPaint, IntPtr native_typeface)
		{
			TextAppearance @object = Java.Lang.Object.GetObject<TextAppearance>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Context object2 = Java.Lang.Object.GetObject<Context>(native_context, JniHandleOwnership.DoNotTransfer);
			TextPaint object3 = Java.Lang.Object.GetObject<TextPaint>(native_textPaint, JniHandleOwnership.DoNotTransfer);
			Typeface object4 = Java.Lang.Object.GetObject<Typeface>(native_typeface, JniHandleOwnership.DoNotTransfer);
			@object.UpdateTextPaintMeasureState(object2, object3, object4);
		}

		// Token: 0x060001E0 RID: 480 RVA: 0x00005C54 File Offset: 0x00003E54
		[Register("updateTextPaintMeasureState", "(Landroid/content/Context;Landroid/text/TextPaint;Landroid/graphics/Typeface;)V", "GetUpdateTextPaintMeasureState_Landroid_content_Context_Landroid_text_TextPaint_Landroid_graphics_Typeface_Handler")]
		public unsafe virtual void UpdateTextPaintMeasureState(Context context, TextPaint textPaint, Typeface typeface)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((context == null) ? IntPtr.Zero : context.Handle);
				ptr[1] = new JniArgumentValue((textPaint == null) ? IntPtr.Zero : textPaint.Handle);
				ptr[2] = new JniArgumentValue((typeface == null) ? IntPtr.Zero : typeface.Handle);
				TextAppearance._members.InstanceMethods.InvokeVirtualVoidMethod("updateTextPaintMeasureState.(Landroid/content/Context;Landroid/text/TextPaint;Landroid/graphics/Typeface;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(context);
				GC.KeepAlive(textPaint);
				GC.KeepAlive(typeface);
			}
		}

		// Token: 0x04000034 RID: 52
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/google/android/material/resources/TextAppearance", typeof(TextAppearance));

		// Token: 0x04000035 RID: 53
		private static Delegate cb_getFallbackFont;

		// Token: 0x04000036 RID: 54
		private static Delegate cb_getTextColor;

		// Token: 0x04000037 RID: 55
		private static Delegate cb_setTextColor_Landroid_content_res_ColorStateList_;

		// Token: 0x04000038 RID: 56
		private static Delegate cb_getTextSize;

		// Token: 0x04000039 RID: 57
		private static Delegate cb_setTextSize_F;

		// Token: 0x0400003A RID: 58
		private static Delegate cb_getFont_Landroid_content_Context_;

		// Token: 0x0400003B RID: 59
		private static Delegate cb_getFontAsync_Landroid_content_Context_Landroid_text_TextPaint_Lcom_google_android_material_resources_TextAppearanceFontCallback_;

		// Token: 0x0400003C RID: 60
		private static Delegate cb_getFontAsync_Landroid_content_Context_Lcom_google_android_material_resources_TextAppearanceFontCallback_;

		// Token: 0x0400003D RID: 61
		private static Delegate cb_updateDrawState_Landroid_content_Context_Landroid_text_TextPaint_Lcom_google_android_material_resources_TextAppearanceFontCallback_;

		// Token: 0x0400003E RID: 62
		private static Delegate cb_updateMeasureState_Landroid_content_Context_Landroid_text_TextPaint_Lcom_google_android_material_resources_TextAppearanceFontCallback_;

		// Token: 0x0400003F RID: 63
		private static Delegate cb_updateTextPaintMeasureState_Landroid_content_Context_Landroid_text_TextPaint_Landroid_graphics_Typeface_;
	}
}
