using System;
using Android.Content;
using Android.Runtime;
using Android.Util;
using Android.Views;
using Java.Lang;

namespace Com.Wang.Avi
{
	// Token: 0x02000003 RID: 3
	[Register("com/wang/avi/AVLoadingIndicatorView", DoNotGenerateAcw = true)]
	public class AVLoadingIndicatorView : View
	{
		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000004 RID: 4 RVA: 0x0000208C File Offset: 0x0000028C
		internal static IntPtr class_ref
		{
			get
			{
				return JNIEnv.FindClass("com/wang/avi/AVLoadingIndicatorView", ref AVLoadingIndicatorView.java_class_handle);
			}
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000005 RID: 5 RVA: 0x0000209D File Offset: 0x0000029D
		protected override IntPtr ThresholdClass
		{
			get
			{
				return AVLoadingIndicatorView.class_ref;
			}
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000006 RID: 6 RVA: 0x000020A4 File Offset: 0x000002A4
		protected override Type ThresholdType
		{
			get
			{
				return typeof(AVLoadingIndicatorView);
			}
		}

		// Token: 0x06000007 RID: 7 RVA: 0x000020B0 File Offset: 0x000002B0
		protected AVLoadingIndicatorView(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000008 RID: 8 RVA: 0x000020BC File Offset: 0x000002BC
		[Register(".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;II)V", "")]
		public unsafe AVLoadingIndicatorView(Context p0, IAttributeSet p1, int p2, int p3) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(p0);
			ptr[1] = new JValue(p1);
			ptr[2] = new JValue(p2);
			ptr[3] = new JValue(p3);
			if (base.GetType() != typeof(AVLoadingIndicatorView))
			{
				base.SetHandle(JNIEnv.StartCreateInstance(base.GetType(), "(Landroid/content/Context;Landroid/util/AttributeSet;II)V", ptr), JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance(base.Handle, "(Landroid/content/Context;Landroid/util/AttributeSet;II)V", ptr);
				return;
			}
			if (AVLoadingIndicatorView.id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_II == IntPtr.Zero)
			{
				AVLoadingIndicatorView.id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_II = JNIEnv.GetMethodID(AVLoadingIndicatorView.class_ref, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;II)V");
			}
			base.SetHandle(JNIEnv.StartCreateInstance(AVLoadingIndicatorView.class_ref, AVLoadingIndicatorView.id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_II, ptr), JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance(base.Handle, AVLoadingIndicatorView.class_ref, AVLoadingIndicatorView.id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_II, ptr);
			GC.KeepAlive(p0);
			GC.KeepAlive(p1);
		}

		// Token: 0x06000009 RID: 9 RVA: 0x000021E4 File Offset: 0x000003E4
		[Register(".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", "")]
		public unsafe AVLoadingIndicatorView(Context p0, IAttributeSet p1, int p2) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(p0);
			ptr[1] = new JValue(p1);
			ptr[2] = new JValue(p2);
			if (base.GetType() != typeof(AVLoadingIndicatorView))
			{
				base.SetHandle(JNIEnv.StartCreateInstance(base.GetType(), "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", ptr), JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance(base.Handle, "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", ptr);
				return;
			}
			if (AVLoadingIndicatorView.id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_I == IntPtr.Zero)
			{
				AVLoadingIndicatorView.id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_I = JNIEnv.GetMethodID(AVLoadingIndicatorView.class_ref, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V");
			}
			base.SetHandle(JNIEnv.StartCreateInstance(AVLoadingIndicatorView.class_ref, AVLoadingIndicatorView.id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_I, ptr), JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance(base.Handle, AVLoadingIndicatorView.class_ref, AVLoadingIndicatorView.id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_I, ptr);
			GC.KeepAlive(p0);
			GC.KeepAlive(p1);
		}

		// Token: 0x0600000A RID: 10 RVA: 0x000022F8 File Offset: 0x000004F8
		[Register(".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", "")]
		public unsafe AVLoadingIndicatorView(Context p0, IAttributeSet p1) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(p0);
			ptr[1] = new JValue(p1);
			if (base.GetType() != typeof(AVLoadingIndicatorView))
			{
				base.SetHandle(JNIEnv.StartCreateInstance(base.GetType(), "(Landroid/content/Context;Landroid/util/AttributeSet;)V", ptr), JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance(base.Handle, "(Landroid/content/Context;Landroid/util/AttributeSet;)V", ptr);
				return;
			}
			if (AVLoadingIndicatorView.id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_ == IntPtr.Zero)
			{
				AVLoadingIndicatorView.id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_ = JNIEnv.GetMethodID(AVLoadingIndicatorView.class_ref, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
			}
			base.SetHandle(JNIEnv.StartCreateInstance(AVLoadingIndicatorView.class_ref, AVLoadingIndicatorView.id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_, ptr), JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance(base.Handle, AVLoadingIndicatorView.class_ref, AVLoadingIndicatorView.id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_, ptr);
			GC.KeepAlive(p0);
			GC.KeepAlive(p1);
		}

		// Token: 0x0600000B RID: 11 RVA: 0x000023F4 File Offset: 0x000005F4
		[Register(".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe AVLoadingIndicatorView(Context p0) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(p0);
			if (base.GetType() != typeof(AVLoadingIndicatorView))
			{
				base.SetHandle(JNIEnv.StartCreateInstance(base.GetType(), "(Landroid/content/Context;)V", ptr), JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance(base.Handle, "(Landroid/content/Context;)V", ptr);
				return;
			}
			if (AVLoadingIndicatorView.id_ctor_Landroid_content_Context_ == IntPtr.Zero)
			{
				AVLoadingIndicatorView.id_ctor_Landroid_content_Context_ = JNIEnv.GetMethodID(AVLoadingIndicatorView.class_ref, "<init>", "(Landroid/content/Context;)V");
			}
			base.SetHandle(JNIEnv.StartCreateInstance(AVLoadingIndicatorView.class_ref, AVLoadingIndicatorView.id_ctor_Landroid_content_Context_, ptr), JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance(base.Handle, AVLoadingIndicatorView.class_ref, AVLoadingIndicatorView.id_ctor_Landroid_content_Context_, ptr);
			GC.KeepAlive(p0);
		}

		// Token: 0x0600000C RID: 12 RVA: 0x000024D6 File Offset: 0x000006D6
		private static Delegate GetGetIndicatorHandler()
		{
			if (AVLoadingIndicatorView.cb_getIndicator == null)
			{
				AVLoadingIndicatorView.cb_getIndicator = JNINativeWrapper.CreateDelegate(new Func<IntPtr, IntPtr, IntPtr>(AVLoadingIndicatorView.n_GetIndicator));
			}
			return AVLoadingIndicatorView.cb_getIndicator;
		}

		// Token: 0x0600000D RID: 13 RVA: 0x000024FC File Offset: 0x000006FC
		private static IntPtr n_GetIndicator(IntPtr jnienv, IntPtr native__this)
		{
			AVLoadingIndicatorView @object = Java.Lang.Object.GetObject<AVLoadingIndicatorView>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.Indicator);
		}

		// Token: 0x0600000E RID: 14 RVA: 0x0000251D File Offset: 0x0000071D
		private static Delegate GetSetIndicator_Lcom_wang_avi_Indicator_Handler()
		{
			if (AVLoadingIndicatorView.cb_setIndicator_Lcom_wang_avi_Indicator_ == null)
			{
				AVLoadingIndicatorView.cb_setIndicator_Lcom_wang_avi_Indicator_ = JNINativeWrapper.CreateDelegate(new Action<IntPtr, IntPtr, IntPtr>(AVLoadingIndicatorView.n_SetIndicator_Lcom_wang_avi_Indicator_));
			}
			return AVLoadingIndicatorView.cb_setIndicator_Lcom_wang_avi_Indicator_;
		}

		// Token: 0x0600000F RID: 15 RVA: 0x00002544 File Offset: 0x00000744
		private static void n_SetIndicator_Lcom_wang_avi_Indicator_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			AVLoadingIndicatorView @object = Java.Lang.Object.GetObject<AVLoadingIndicatorView>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Indicator object2 = Java.Lang.Object.GetObject<Indicator>(native_p0, JniHandleOwnership.DoNotTransfer);
			@object.Indicator = object2;
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000010 RID: 16 RVA: 0x0000256C File Offset: 0x0000076C
		// (set) Token: 0x06000011 RID: 17 RVA: 0x000025FC File Offset: 0x000007FC
		public unsafe virtual Indicator Indicator
		{
			[Register("getIndicator", "()Lcom/wang/avi/Indicator;", "GetGetIndicatorHandler")]
			get
			{
				if (AVLoadingIndicatorView.id_getIndicator == IntPtr.Zero)
				{
					AVLoadingIndicatorView.id_getIndicator = JNIEnv.GetMethodID(AVLoadingIndicatorView.class_ref, "getIndicator", "()Lcom/wang/avi/Indicator;");
				}
				if (base.GetType() == this.ThresholdType)
				{
					return Java.Lang.Object.GetObject<Indicator>(JNIEnv.CallObjectMethod(base.Handle, AVLoadingIndicatorView.id_getIndicator), JniHandleOwnership.TransferLocalRef);
				}
				return Java.Lang.Object.GetObject<Indicator>(JNIEnv.CallNonvirtualObjectMethod(base.Handle, this.ThresholdClass, JNIEnv.GetMethodID(this.ThresholdClass, "getIndicator", "()Lcom/wang/avi/Indicator;")), JniHandleOwnership.TransferLocalRef);
			}
			[Register("setIndicator", "(Lcom/wang/avi/Indicator;)V", "GetSetIndicator_Lcom_wang_avi_Indicator_Handler")]
			set
			{
				if (AVLoadingIndicatorView.id_setIndicator_Lcom_wang_avi_Indicator_ == IntPtr.Zero)
				{
					AVLoadingIndicatorView.id_setIndicator_Lcom_wang_avi_Indicator_ = JNIEnv.GetMethodID(AVLoadingIndicatorView.class_ref, "setIndicator", "(Lcom/wang/avi/Indicator;)V");
				}
				JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
				*ptr = new JValue(value);
				if (base.GetType() == this.ThresholdType)
				{
					JNIEnv.CallVoidMethod(base.Handle, AVLoadingIndicatorView.id_setIndicator_Lcom_wang_avi_Indicator_, ptr);
					return;
				}
				JNIEnv.CallNonvirtualVoidMethod(base.Handle, this.ThresholdClass, JNIEnv.GetMethodID(this.ThresholdClass, "setIndicator", "(Lcom/wang/avi/Indicator;)V"), ptr);
				GC.KeepAlive(value);
			}
		}

		// Token: 0x06000012 RID: 18 RVA: 0x0000269D File Offset: 0x0000089D
		private static Delegate GetHideHandler()
		{
			if (AVLoadingIndicatorView.cb_hide == null)
			{
				AVLoadingIndicatorView.cb_hide = JNINativeWrapper.CreateDelegate(new Action<IntPtr, IntPtr>(AVLoadingIndicatorView.n_Hide));
			}
			return AVLoadingIndicatorView.cb_hide;
		}

		// Token: 0x06000013 RID: 19 RVA: 0x000026C4 File Offset: 0x000008C4
		private static void n_Hide(IntPtr jnienv, IntPtr native__this)
		{
			AVLoadingIndicatorView @object = Java.Lang.Object.GetObject<AVLoadingIndicatorView>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			@object.Hide();
		}

		// Token: 0x06000014 RID: 20 RVA: 0x000026E0 File Offset: 0x000008E0
		[Register("hide", "()V", "GetHideHandler")]
		public virtual void Hide()
		{
			if (AVLoadingIndicatorView.id_hide == IntPtr.Zero)
			{
				AVLoadingIndicatorView.id_hide = JNIEnv.GetMethodID(AVLoadingIndicatorView.class_ref, "hide", "()V");
			}
			if (base.GetType() == this.ThresholdType)
			{
				JNIEnv.CallVoidMethod(base.Handle, AVLoadingIndicatorView.id_hide);
				return;
			}
			JNIEnv.CallNonvirtualVoidMethod(base.Handle, this.ThresholdClass, JNIEnv.GetMethodID(this.ThresholdClass, "hide", "()V"));
		}

		// Token: 0x06000015 RID: 21 RVA: 0x00002761 File Offset: 0x00000961
		private static Delegate GetSetIndicator_Ljava_lang_String_Handler()
		{
			if (AVLoadingIndicatorView.cb_setIndicator_Ljava_lang_String_ == null)
			{
				AVLoadingIndicatorView.cb_setIndicator_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate(new Action<IntPtr, IntPtr, IntPtr>(AVLoadingIndicatorView.n_SetIndicator_Ljava_lang_String_));
			}
			return AVLoadingIndicatorView.cb_setIndicator_Ljava_lang_String_;
		}

		// Token: 0x06000016 RID: 22 RVA: 0x00002788 File Offset: 0x00000988
		private static void n_SetIndicator_Ljava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			AVLoadingIndicatorView @object = Java.Lang.Object.GetObject<AVLoadingIndicatorView>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_p0, JniHandleOwnership.DoNotTransfer);
			@object.SetIndicator(@string);
		}

		// Token: 0x06000017 RID: 23 RVA: 0x000027B0 File Offset: 0x000009B0
		[Register("setIndicator", "(Ljava/lang/String;)V", "GetSetIndicator_Ljava_lang_String_Handler")]
		public unsafe virtual void SetIndicator(string p0)
		{
			if (AVLoadingIndicatorView.id_setIndicator_Ljava_lang_String_ == IntPtr.Zero)
			{
				AVLoadingIndicatorView.id_setIndicator_Ljava_lang_String_ = JNIEnv.GetMethodID(AVLoadingIndicatorView.class_ref, "setIndicator", "(Ljava/lang/String;)V");
			}
			IntPtr intPtr = JNIEnv.NewString(p0);
			try
			{
				JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
				*ptr = new JValue(intPtr);
				if (base.GetType() == this.ThresholdType)
				{
					JNIEnv.CallVoidMethod(base.Handle, AVLoadingIndicatorView.id_setIndicator_Ljava_lang_String_, ptr);
				}
				else
				{
					JNIEnv.CallNonvirtualVoidMethod(base.Handle, this.ThresholdClass, JNIEnv.GetMethodID(this.ThresholdClass, "setIndicator", "(Ljava/lang/String;)V"), ptr);
				}
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
		}

		// Token: 0x06000018 RID: 24 RVA: 0x0000286C File Offset: 0x00000A6C
		private static Delegate GetSetIndicatorColor_IHandler()
		{
			if (AVLoadingIndicatorView.cb_setIndicatorColor_I == null)
			{
				AVLoadingIndicatorView.cb_setIndicatorColor_I = JNINativeWrapper.CreateDelegate(new Action<IntPtr, IntPtr, int>(AVLoadingIndicatorView.n_SetIndicatorColor_I));
			}
			return AVLoadingIndicatorView.cb_setIndicatorColor_I;
		}

		// Token: 0x06000019 RID: 25 RVA: 0x00002890 File Offset: 0x00000A90
		private static void n_SetIndicatorColor_I(IntPtr jnienv, IntPtr native__this, int p0)
		{
			AVLoadingIndicatorView @object = Java.Lang.Object.GetObject<AVLoadingIndicatorView>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			@object.SetIndicatorColor(p0);
		}

		// Token: 0x0600001A RID: 26 RVA: 0x000028B0 File Offset: 0x00000AB0
		[Register("setIndicatorColor", "(I)V", "GetSetIndicatorColor_IHandler")]
		public unsafe virtual void SetIndicatorColor(int p0)
		{
			if (AVLoadingIndicatorView.id_setIndicatorColor_I == IntPtr.Zero)
			{
				AVLoadingIndicatorView.id_setIndicatorColor_I = JNIEnv.GetMethodID(AVLoadingIndicatorView.class_ref, "setIndicatorColor", "(I)V");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(p0);
			if (base.GetType() == this.ThresholdType)
			{
				JNIEnv.CallVoidMethod(base.Handle, AVLoadingIndicatorView.id_setIndicatorColor_I, ptr);
				return;
			}
			JNIEnv.CallNonvirtualVoidMethod(base.Handle, this.ThresholdClass, JNIEnv.GetMethodID(this.ThresholdClass, "setIndicatorColor", "(I)V"), ptr);
		}

		// Token: 0x0600001B RID: 27 RVA: 0x0000294B File Offset: 0x00000B4B
		private static Delegate GetShowHandler()
		{
			if (AVLoadingIndicatorView.cb_show == null)
			{
				AVLoadingIndicatorView.cb_show = JNINativeWrapper.CreateDelegate(new Action<IntPtr, IntPtr>(AVLoadingIndicatorView.n_Show));
			}
			return AVLoadingIndicatorView.cb_show;
		}

		// Token: 0x0600001C RID: 28 RVA: 0x00002970 File Offset: 0x00000B70
		private static void n_Show(IntPtr jnienv, IntPtr native__this)
		{
			AVLoadingIndicatorView @object = Java.Lang.Object.GetObject<AVLoadingIndicatorView>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			@object.Show();
		}

		// Token: 0x0600001D RID: 29 RVA: 0x0000298C File Offset: 0x00000B8C
		[Register("show", "()V", "GetShowHandler")]
		public virtual void Show()
		{
			if (AVLoadingIndicatorView.id_show == IntPtr.Zero)
			{
				AVLoadingIndicatorView.id_show = JNIEnv.GetMethodID(AVLoadingIndicatorView.class_ref, "show", "()V");
			}
			if (base.GetType() == this.ThresholdType)
			{
				JNIEnv.CallVoidMethod(base.Handle, AVLoadingIndicatorView.id_show);
				return;
			}
			JNIEnv.CallNonvirtualVoidMethod(base.Handle, this.ThresholdClass, JNIEnv.GetMethodID(this.ThresholdClass, "show", "()V"));
		}

		// Token: 0x0600001E RID: 30 RVA: 0x00002A0D File Offset: 0x00000C0D
		private static Delegate GetSmoothToHideHandler()
		{
			if (AVLoadingIndicatorView.cb_smoothToHide == null)
			{
				AVLoadingIndicatorView.cb_smoothToHide = JNINativeWrapper.CreateDelegate(new Action<IntPtr, IntPtr>(AVLoadingIndicatorView.n_SmoothToHide));
			}
			return AVLoadingIndicatorView.cb_smoothToHide;
		}

		// Token: 0x0600001F RID: 31 RVA: 0x00002A34 File Offset: 0x00000C34
		private static void n_SmoothToHide(IntPtr jnienv, IntPtr native__this)
		{
			AVLoadingIndicatorView @object = Java.Lang.Object.GetObject<AVLoadingIndicatorView>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			@object.SmoothToHide();
		}

		// Token: 0x06000020 RID: 32 RVA: 0x00002A50 File Offset: 0x00000C50
		[Register("smoothToHide", "()V", "GetSmoothToHideHandler")]
		public virtual void SmoothToHide()
		{
			if (AVLoadingIndicatorView.id_smoothToHide == IntPtr.Zero)
			{
				AVLoadingIndicatorView.id_smoothToHide = JNIEnv.GetMethodID(AVLoadingIndicatorView.class_ref, "smoothToHide", "()V");
			}
			if (base.GetType() == this.ThresholdType)
			{
				JNIEnv.CallVoidMethod(base.Handle, AVLoadingIndicatorView.id_smoothToHide);
				return;
			}
			JNIEnv.CallNonvirtualVoidMethod(base.Handle, this.ThresholdClass, JNIEnv.GetMethodID(this.ThresholdClass, "smoothToHide", "()V"));
		}

		// Token: 0x06000021 RID: 33 RVA: 0x00002AD1 File Offset: 0x00000CD1
		private static Delegate GetSmoothToShowHandler()
		{
			if (AVLoadingIndicatorView.cb_smoothToShow == null)
			{
				AVLoadingIndicatorView.cb_smoothToShow = JNINativeWrapper.CreateDelegate(new Action<IntPtr, IntPtr>(AVLoadingIndicatorView.n_SmoothToShow));
			}
			return AVLoadingIndicatorView.cb_smoothToShow;
		}

		// Token: 0x06000022 RID: 34 RVA: 0x00002AF8 File Offset: 0x00000CF8
		private static void n_SmoothToShow(IntPtr jnienv, IntPtr native__this)
		{
			AVLoadingIndicatorView @object = Java.Lang.Object.GetObject<AVLoadingIndicatorView>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			@object.SmoothToShow();
		}

		// Token: 0x06000023 RID: 35 RVA: 0x00002B14 File Offset: 0x00000D14
		[Register("smoothToShow", "()V", "GetSmoothToShowHandler")]
		public virtual void SmoothToShow()
		{
			if (AVLoadingIndicatorView.id_smoothToShow == IntPtr.Zero)
			{
				AVLoadingIndicatorView.id_smoothToShow = JNIEnv.GetMethodID(AVLoadingIndicatorView.class_ref, "smoothToShow", "()V");
			}
			if (base.GetType() == this.ThresholdType)
			{
				JNIEnv.CallVoidMethod(base.Handle, AVLoadingIndicatorView.id_smoothToShow);
				return;
			}
			JNIEnv.CallNonvirtualVoidMethod(base.Handle, this.ThresholdClass, JNIEnv.GetMethodID(this.ThresholdClass, "smoothToShow", "()V"));
		}

		// Token: 0x04000001 RID: 1
		internal static IntPtr java_class_handle;

		// Token: 0x04000002 RID: 2
		private static IntPtr id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_II;

		// Token: 0x04000003 RID: 3
		private static IntPtr id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_I;

		// Token: 0x04000004 RID: 4
		private static IntPtr id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_;

		// Token: 0x04000005 RID: 5
		private static IntPtr id_ctor_Landroid_content_Context_;

		// Token: 0x04000006 RID: 6
		private static Delegate cb_getIndicator;

		// Token: 0x04000007 RID: 7
		private static Delegate cb_setIndicator_Lcom_wang_avi_Indicator_;

		// Token: 0x04000008 RID: 8
		private static IntPtr id_getIndicator;

		// Token: 0x04000009 RID: 9
		private static IntPtr id_setIndicator_Lcom_wang_avi_Indicator_;

		// Token: 0x0400000A RID: 10
		private static Delegate cb_hide;

		// Token: 0x0400000B RID: 11
		private static IntPtr id_hide;

		// Token: 0x0400000C RID: 12
		private static Delegate cb_setIndicator_Ljava_lang_String_;

		// Token: 0x0400000D RID: 13
		private static IntPtr id_setIndicator_Ljava_lang_String_;

		// Token: 0x0400000E RID: 14
		private static Delegate cb_setIndicatorColor_I;

		// Token: 0x0400000F RID: 15
		private static IntPtr id_setIndicatorColor_I;

		// Token: 0x04000010 RID: 16
		private static Delegate cb_show;

		// Token: 0x04000011 RID: 17
		private static IntPtr id_show;

		// Token: 0x04000012 RID: 18
		private static Delegate cb_smoothToHide;

		// Token: 0x04000013 RID: 19
		private static IntPtr id_smoothToHide;

		// Token: 0x04000014 RID: 20
		private static Delegate cb_smoothToShow;

		// Token: 0x04000015 RID: 21
		private static IntPtr id_smoothToShow;
	}
}
