using System;
using System.Runtime.CompilerServices;
using Android.Content;
using Android.Runtime;
using Android.Util;
using Android.Widget;
using Java.Lang;

namespace Refractored.Controls
{
	// Token: 0x02000005 RID: 5
	[Register("de/hdodenhof/circleimageview/CircleImageView", DoNotGenerateAcw = true)]
	public class _BaseCircleImageView : ImageView
	{
		// Token: 0x0600000E RID: 14 RVA: 0x00002248 File Offset: 0x00000448
		protected _BaseCircleImageView(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x0600000F RID: 15 RVA: 0x00002254 File Offset: 0x00000454
		[Register(".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", "")]
		public unsafe _BaseCircleImageView(Context p0, IAttributeSet p1, int p2) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			try
			{
				JValue* ptr = stackalloc JValue[checked(3 * sizeof(JValue))];
				*ptr = new JValue(p0);
				ptr[1] = new JValue(p1);
				ptr[sizeof(JValue) * 2 / sizeof(JValue)] = new JValue(p2);
				if (base.GetType() != typeof(_BaseCircleImageView))
				{
					base.SetHandle(JNIEnv.StartCreateInstance(base.GetType(), "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", ptr), JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance(base.Handle, "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", ptr);
				}
				else
				{
					if (_BaseCircleImageView.id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_I == IntPtr.Zero)
					{
						_BaseCircleImageView.id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_I = JNIEnv.GetMethodID(_BaseCircleImageView.class_ref, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V");
					}
					base.SetHandle(JNIEnv.StartCreateInstance(_BaseCircleImageView.class_ref, _BaseCircleImageView.id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_I, ptr), JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance(base.Handle, _BaseCircleImageView.class_ref, _BaseCircleImageView.id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_I, ptr);
				}
			}
			finally
			{
			}
		}

		// Token: 0x06000010 RID: 16 RVA: 0x00002388 File Offset: 0x00000588
		[Register(".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", "")]
		public unsafe _BaseCircleImageView(Context p0, IAttributeSet p1) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			try
			{
				JValue* ptr = stackalloc JValue[checked(2 * sizeof(JValue))];
				*ptr = new JValue(p0);
				ptr[1] = new JValue(p1);
				if (base.GetType() != typeof(_BaseCircleImageView))
				{
					base.SetHandle(JNIEnv.StartCreateInstance(base.GetType(), "(Landroid/content/Context;Landroid/util/AttributeSet;)V", ptr), JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance(base.Handle, "(Landroid/content/Context;Landroid/util/AttributeSet;)V", ptr);
				}
				else
				{
					if (_BaseCircleImageView.id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_ == IntPtr.Zero)
					{
						_BaseCircleImageView.id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_ = JNIEnv.GetMethodID(_BaseCircleImageView.class_ref, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
					}
					base.SetHandle(JNIEnv.StartCreateInstance(_BaseCircleImageView.class_ref, _BaseCircleImageView.id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_, ptr), JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance(base.Handle, _BaseCircleImageView.class_ref, _BaseCircleImageView.id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_, ptr);
				}
			}
			finally
			{
			}
		}

		// Token: 0x06000011 RID: 17 RVA: 0x000024A8 File Offset: 0x000006A8
		[Register(".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe _BaseCircleImageView(Context p0) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			try
			{
				JValue* ptr = stackalloc JValue[checked(1 * sizeof(JValue))];
				*ptr = new JValue(p0);
				if (base.GetType() != typeof(_BaseCircleImageView))
				{
					base.SetHandle(JNIEnv.StartCreateInstance(base.GetType(), "(Landroid/content/Context;)V", ptr), JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance(base.Handle, "(Landroid/content/Context;)V", ptr);
				}
				else
				{
					if (_BaseCircleImageView.id_ctor_Landroid_content_Context_ == IntPtr.Zero)
					{
						_BaseCircleImageView.id_ctor_Landroid_content_Context_ = JNIEnv.GetMethodID(_BaseCircleImageView.class_ref, "<init>", "(Landroid/content/Context;)V");
					}
					base.SetHandle(JNIEnv.StartCreateInstance(_BaseCircleImageView.class_ref, _BaseCircleImageView.id_ctor_Landroid_content_Context_, ptr), JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance(base.Handle, _BaseCircleImageView.class_ref, _BaseCircleImageView.id_ctor_Landroid_content_Context_, ptr);
				}
			}
			finally
			{
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000012 RID: 18 RVA: 0x000025AC File Offset: 0x000007AC
		internal static IntPtr class_ref
		{
			get
			{
				return JNIEnv.FindClass("de/hdodenhof/circleimageview/CircleImageView", ref _BaseCircleImageView.java_class_handle);
			}
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000013 RID: 19 RVA: 0x000025BD File Offset: 0x000007BD
		protected override IntPtr ThresholdClass
		{
			get
			{
				return _BaseCircleImageView.class_ref;
			}
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x06000014 RID: 20 RVA: 0x000025C4 File Offset: 0x000007C4
		protected override Type ThresholdType
		{
			get
			{
				return typeof(_BaseCircleImageView);
			}
		}

		// Token: 0x06000015 RID: 21 RVA: 0x000025D0 File Offset: 0x000007D0
		private static Delegate GetGetBorderColorHandler()
		{
			if (_BaseCircleImageView.cb_getBorderColor == null)
			{
				if (_BaseCircleImageView.<>f__mg$cache0 == null)
				{
					_BaseCircleImageView.<>f__mg$cache0 = new Func<IntPtr, IntPtr, int>(_BaseCircleImageView.n_GetBorderColor);
				}
				_BaseCircleImageView.cb_getBorderColor = JNINativeWrapper.CreateDelegate(_BaseCircleImageView.<>f__mg$cache0);
			}
			return _BaseCircleImageView.cb_getBorderColor;
		}

		// Token: 0x06000016 RID: 22 RVA: 0x00002608 File Offset: 0x00000808
		private static int n_GetBorderColor(IntPtr jnienv, IntPtr native__this)
		{
			_BaseCircleImageView @object = Java.Lang.Object.GetObject<_BaseCircleImageView>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return @object.BorderColor;
		}

		// Token: 0x06000017 RID: 23 RVA: 0x00002624 File Offset: 0x00000824
		private static Delegate GetSetBorderColor_IHandler()
		{
			if (_BaseCircleImageView.cb_setBorderColor_I == null)
			{
				if (_BaseCircleImageView.<>f__mg$cache1 == null)
				{
					_BaseCircleImageView.<>f__mg$cache1 = new Action<IntPtr, IntPtr, int>(_BaseCircleImageView.n_SetBorderColor_I);
				}
				_BaseCircleImageView.cb_setBorderColor_I = JNINativeWrapper.CreateDelegate(_BaseCircleImageView.<>f__mg$cache1);
			}
			return _BaseCircleImageView.cb_setBorderColor_I;
		}

		// Token: 0x06000018 RID: 24 RVA: 0x0000265C File Offset: 0x0000085C
		private static void n_SetBorderColor_I(IntPtr jnienv, IntPtr native__this, int p0)
		{
			_BaseCircleImageView @object = Java.Lang.Object.GetObject<_BaseCircleImageView>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			@object.BorderColor = p0;
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x06000019 RID: 25 RVA: 0x0000267C File Offset: 0x0000087C
		// (set) Token: 0x0600001A RID: 26 RVA: 0x00002720 File Offset: 0x00000920
		public unsafe virtual int BorderColor
		{
			[Register("getBorderColor", "()I", "GetGetBorderColorHandler")]
			get
			{
				if (_BaseCircleImageView.id_getBorderColor == IntPtr.Zero)
				{
					_BaseCircleImageView.id_getBorderColor = JNIEnv.GetMethodID(_BaseCircleImageView.class_ref, "getBorderColor", "()I");
				}
				int result;
				try
				{
					if (base.GetType() == this.ThresholdType)
					{
						result = JNIEnv.CallIntMethod(base.Handle, _BaseCircleImageView.id_getBorderColor);
					}
					else
					{
						result = JNIEnv.CallNonvirtualIntMethod(base.Handle, this.ThresholdClass, JNIEnv.GetMethodID(this.ThresholdClass, "getBorderColor", "()I"));
					}
				}
				finally
				{
				}
				return result;
			}
			[Register("setBorderColor", "(I)V", "GetSetBorderColor_IHandler")]
			set
			{
				if (_BaseCircleImageView.id_setBorderColor_I == IntPtr.Zero)
				{
					_BaseCircleImageView.id_setBorderColor_I = JNIEnv.GetMethodID(_BaseCircleImageView.class_ref, "setBorderColor", "(I)V");
				}
				try
				{
					JValue* ptr = stackalloc JValue[checked(1 * sizeof(JValue))];
					*ptr = new JValue(value);
					if (base.GetType() == this.ThresholdType)
					{
						JNIEnv.CallVoidMethod(base.Handle, _BaseCircleImageView.id_setBorderColor_I, ptr);
					}
					else
					{
						JNIEnv.CallNonvirtualVoidMethod(base.Handle, this.ThresholdClass, JNIEnv.GetMethodID(this.ThresholdClass, "setBorderColor", "(I)V"), ptr);
					}
				}
				finally
				{
				}
			}
		}

		// Token: 0x0600001B RID: 27 RVA: 0x000027DC File Offset: 0x000009DC
		private static Delegate GetIsBorderOverlayHandler()
		{
			if (_BaseCircleImageView.cb_isBorderOverlay == null)
			{
				if (_BaseCircleImageView.<>f__mg$cache2 == null)
				{
					_BaseCircleImageView.<>f__mg$cache2 = new Func<IntPtr, IntPtr, bool>(_BaseCircleImageView.n_IsBorderOverlay);
				}
				_BaseCircleImageView.cb_isBorderOverlay = JNINativeWrapper.CreateDelegate(_BaseCircleImageView.<>f__mg$cache2);
			}
			return _BaseCircleImageView.cb_isBorderOverlay;
		}

		// Token: 0x0600001C RID: 28 RVA: 0x00002814 File Offset: 0x00000A14
		private static bool n_IsBorderOverlay(IntPtr jnienv, IntPtr native__this)
		{
			_BaseCircleImageView @object = Java.Lang.Object.GetObject<_BaseCircleImageView>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return @object.BorderOverlay;
		}

		// Token: 0x0600001D RID: 29 RVA: 0x00002830 File Offset: 0x00000A30
		private static Delegate GetSetBorderOverlay_ZHandler()
		{
			if (_BaseCircleImageView.cb_setBorderOverlay_Z == null)
			{
				if (_BaseCircleImageView.<>f__mg$cache3 == null)
				{
					_BaseCircleImageView.<>f__mg$cache3 = new Action<IntPtr, IntPtr, bool>(_BaseCircleImageView.n_SetBorderOverlay_Z);
				}
				_BaseCircleImageView.cb_setBorderOverlay_Z = JNINativeWrapper.CreateDelegate(_BaseCircleImageView.<>f__mg$cache3);
			}
			return _BaseCircleImageView.cb_setBorderOverlay_Z;
		}

		// Token: 0x0600001E RID: 30 RVA: 0x00002868 File Offset: 0x00000A68
		private static void n_SetBorderOverlay_Z(IntPtr jnienv, IntPtr native__this, bool p0)
		{
			_BaseCircleImageView @object = Java.Lang.Object.GetObject<_BaseCircleImageView>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			@object.BorderOverlay = p0;
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x0600001F RID: 31 RVA: 0x00002888 File Offset: 0x00000A88
		// (set) Token: 0x06000020 RID: 32 RVA: 0x0000292C File Offset: 0x00000B2C
		public unsafe virtual bool BorderOverlay
		{
			[Register("isBorderOverlay", "()Z", "GetIsBorderOverlayHandler")]
			get
			{
				if (_BaseCircleImageView.id_isBorderOverlay == IntPtr.Zero)
				{
					_BaseCircleImageView.id_isBorderOverlay = JNIEnv.GetMethodID(_BaseCircleImageView.class_ref, "isBorderOverlay", "()Z");
				}
				bool result;
				try
				{
					if (base.GetType() == this.ThresholdType)
					{
						result = JNIEnv.CallBooleanMethod(base.Handle, _BaseCircleImageView.id_isBorderOverlay);
					}
					else
					{
						result = JNIEnv.CallNonvirtualBooleanMethod(base.Handle, this.ThresholdClass, JNIEnv.GetMethodID(this.ThresholdClass, "isBorderOverlay", "()Z"));
					}
				}
				finally
				{
				}
				return result;
			}
			[Register("setBorderOverlay", "(Z)V", "GetSetBorderOverlay_ZHandler")]
			set
			{
				if (_BaseCircleImageView.id_setBorderOverlay_Z == IntPtr.Zero)
				{
					_BaseCircleImageView.id_setBorderOverlay_Z = JNIEnv.GetMethodID(_BaseCircleImageView.class_ref, "setBorderOverlay", "(Z)V");
				}
				try
				{
					JValue* ptr = stackalloc JValue[checked(1 * sizeof(JValue))];
					*ptr = new JValue(value);
					if (base.GetType() == this.ThresholdType)
					{
						JNIEnv.CallVoidMethod(base.Handle, _BaseCircleImageView.id_setBorderOverlay_Z, ptr);
					}
					else
					{
						JNIEnv.CallNonvirtualVoidMethod(base.Handle, this.ThresholdClass, JNIEnv.GetMethodID(this.ThresholdClass, "setBorderOverlay", "(Z)V"), ptr);
					}
				}
				finally
				{
				}
			}
		}

		// Token: 0x06000021 RID: 33 RVA: 0x000029E8 File Offset: 0x00000BE8
		private static Delegate GetGetBorderWidthHandler()
		{
			if (_BaseCircleImageView.cb_getBorderWidth == null)
			{
				if (_BaseCircleImageView.<>f__mg$cache4 == null)
				{
					_BaseCircleImageView.<>f__mg$cache4 = new Func<IntPtr, IntPtr, int>(_BaseCircleImageView.n_GetBorderWidth);
				}
				_BaseCircleImageView.cb_getBorderWidth = JNINativeWrapper.CreateDelegate(_BaseCircleImageView.<>f__mg$cache4);
			}
			return _BaseCircleImageView.cb_getBorderWidth;
		}

		// Token: 0x06000022 RID: 34 RVA: 0x00002A20 File Offset: 0x00000C20
		private static int n_GetBorderWidth(IntPtr jnienv, IntPtr native__this)
		{
			_BaseCircleImageView @object = Java.Lang.Object.GetObject<_BaseCircleImageView>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return @object.BorderWidth;
		}

		// Token: 0x06000023 RID: 35 RVA: 0x00002A3C File Offset: 0x00000C3C
		private static Delegate GetSetBorderWidth_IHandler()
		{
			if (_BaseCircleImageView.cb_setBorderWidth_I == null)
			{
				if (_BaseCircleImageView.<>f__mg$cache5 == null)
				{
					_BaseCircleImageView.<>f__mg$cache5 = new Action<IntPtr, IntPtr, int>(_BaseCircleImageView.n_SetBorderWidth_I);
				}
				_BaseCircleImageView.cb_setBorderWidth_I = JNINativeWrapper.CreateDelegate(_BaseCircleImageView.<>f__mg$cache5);
			}
			return _BaseCircleImageView.cb_setBorderWidth_I;
		}

		// Token: 0x06000024 RID: 36 RVA: 0x00002A74 File Offset: 0x00000C74
		private static void n_SetBorderWidth_I(IntPtr jnienv, IntPtr native__this, int p0)
		{
			_BaseCircleImageView @object = Java.Lang.Object.GetObject<_BaseCircleImageView>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			@object.BorderWidth = p0;
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x06000025 RID: 37 RVA: 0x00002A94 File Offset: 0x00000C94
		// (set) Token: 0x06000026 RID: 38 RVA: 0x00002B38 File Offset: 0x00000D38
		public unsafe virtual int BorderWidth
		{
			[Register("getBorderWidth", "()I", "GetGetBorderWidthHandler")]
			get
			{
				if (_BaseCircleImageView.id_getBorderWidth == IntPtr.Zero)
				{
					_BaseCircleImageView.id_getBorderWidth = JNIEnv.GetMethodID(_BaseCircleImageView.class_ref, "getBorderWidth", "()I");
				}
				int result;
				try
				{
					if (base.GetType() == this.ThresholdType)
					{
						result = JNIEnv.CallIntMethod(base.Handle, _BaseCircleImageView.id_getBorderWidth);
					}
					else
					{
						result = JNIEnv.CallNonvirtualIntMethod(base.Handle, this.ThresholdClass, JNIEnv.GetMethodID(this.ThresholdClass, "getBorderWidth", "()I"));
					}
				}
				finally
				{
				}
				return result;
			}
			[Register("setBorderWidth", "(I)V", "GetSetBorderWidth_IHandler")]
			set
			{
				if (_BaseCircleImageView.id_setBorderWidth_I == IntPtr.Zero)
				{
					_BaseCircleImageView.id_setBorderWidth_I = JNIEnv.GetMethodID(_BaseCircleImageView.class_ref, "setBorderWidth", "(I)V");
				}
				try
				{
					JValue* ptr = stackalloc JValue[checked(1 * sizeof(JValue))];
					*ptr = new JValue(value);
					if (base.GetType() == this.ThresholdType)
					{
						JNIEnv.CallVoidMethod(base.Handle, _BaseCircleImageView.id_setBorderWidth_I, ptr);
					}
					else
					{
						JNIEnv.CallNonvirtualVoidMethod(base.Handle, this.ThresholdClass, JNIEnv.GetMethodID(this.ThresholdClass, "setBorderWidth", "(I)V"), ptr);
					}
				}
				finally
				{
				}
			}
		}

		// Token: 0x06000027 RID: 39 RVA: 0x00002BF4 File Offset: 0x00000DF4
		private static Delegate GetGetFillColorHandler()
		{
			if (_BaseCircleImageView.cb_getFillColor == null)
			{
				if (_BaseCircleImageView.<>f__mg$cache6 == null)
				{
					_BaseCircleImageView.<>f__mg$cache6 = new Func<IntPtr, IntPtr, int>(_BaseCircleImageView.n_GetFillColor);
				}
				_BaseCircleImageView.cb_getFillColor = JNINativeWrapper.CreateDelegate(_BaseCircleImageView.<>f__mg$cache6);
			}
			return _BaseCircleImageView.cb_getFillColor;
		}

		// Token: 0x06000028 RID: 40 RVA: 0x00002C2C File Offset: 0x00000E2C
		private static int n_GetFillColor(IntPtr jnienv, IntPtr native__this)
		{
			_BaseCircleImageView @object = Java.Lang.Object.GetObject<_BaseCircleImageView>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return @object.FillColor;
		}

		// Token: 0x06000029 RID: 41 RVA: 0x00002C48 File Offset: 0x00000E48
		private static Delegate GetSetFillColor_IHandler()
		{
			if (_BaseCircleImageView.cb_setFillColor_I == null)
			{
				if (_BaseCircleImageView.<>f__mg$cache7 == null)
				{
					_BaseCircleImageView.<>f__mg$cache7 = new Action<IntPtr, IntPtr, int>(_BaseCircleImageView.n_SetFillColor_I);
				}
				_BaseCircleImageView.cb_setFillColor_I = JNINativeWrapper.CreateDelegate(_BaseCircleImageView.<>f__mg$cache7);
			}
			return _BaseCircleImageView.cb_setFillColor_I;
		}

		// Token: 0x0600002A RID: 42 RVA: 0x00002C80 File Offset: 0x00000E80
		private static void n_SetFillColor_I(IntPtr jnienv, IntPtr native__this, int p0)
		{
			_BaseCircleImageView @object = Java.Lang.Object.GetObject<_BaseCircleImageView>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			@object.FillColor = p0;
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x0600002B RID: 43 RVA: 0x00002CA0 File Offset: 0x00000EA0
		// (set) Token: 0x0600002C RID: 44 RVA: 0x00002D44 File Offset: 0x00000F44
		public unsafe virtual int FillColor
		{
			[Register("getFillColor", "()I", "GetGetFillColorHandler")]
			get
			{
				if (_BaseCircleImageView.id_getFillColor == IntPtr.Zero)
				{
					_BaseCircleImageView.id_getFillColor = JNIEnv.GetMethodID(_BaseCircleImageView.class_ref, "getFillColor", "()I");
				}
				int result;
				try
				{
					if (base.GetType() == this.ThresholdType)
					{
						result = JNIEnv.CallIntMethod(base.Handle, _BaseCircleImageView.id_getFillColor);
					}
					else
					{
						result = JNIEnv.CallNonvirtualIntMethod(base.Handle, this.ThresholdClass, JNIEnv.GetMethodID(this.ThresholdClass, "getFillColor", "()I"));
					}
				}
				finally
				{
				}
				return result;
			}
			[Register("setFillColor", "(I)V", "GetSetFillColor_IHandler")]
			set
			{
				if (_BaseCircleImageView.id_setFillColor_I == IntPtr.Zero)
				{
					_BaseCircleImageView.id_setFillColor_I = JNIEnv.GetMethodID(_BaseCircleImageView.class_ref, "setFillColor", "(I)V");
				}
				try
				{
					JValue* ptr = stackalloc JValue[checked(1 * sizeof(JValue))];
					*ptr = new JValue(value);
					if (base.GetType() == this.ThresholdType)
					{
						JNIEnv.CallVoidMethod(base.Handle, _BaseCircleImageView.id_setFillColor_I, ptr);
					}
					else
					{
						JNIEnv.CallNonvirtualVoidMethod(base.Handle, this.ThresholdClass, JNIEnv.GetMethodID(this.ThresholdClass, "setFillColor", "(I)V"), ptr);
					}
				}
				finally
				{
				}
			}
		}

		// Token: 0x0600002D RID: 45 RVA: 0x00002E00 File Offset: 0x00001000
		private static Delegate GetSetBorderColorResource_IHandler()
		{
			if (_BaseCircleImageView.cb_setBorderColorResource_I == null)
			{
				if (_BaseCircleImageView.<>f__mg$cache8 == null)
				{
					_BaseCircleImageView.<>f__mg$cache8 = new Action<IntPtr, IntPtr, int>(_BaseCircleImageView.n_SetBorderColorResource_I);
				}
				_BaseCircleImageView.cb_setBorderColorResource_I = JNINativeWrapper.CreateDelegate(_BaseCircleImageView.<>f__mg$cache8);
			}
			return _BaseCircleImageView.cb_setBorderColorResource_I;
		}

		// Token: 0x0600002E RID: 46 RVA: 0x00002E38 File Offset: 0x00001038
		private static void n_SetBorderColorResource_I(IntPtr jnienv, IntPtr native__this, int p0)
		{
			_BaseCircleImageView @object = Java.Lang.Object.GetObject<_BaseCircleImageView>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			@object.SetBorderColorResource(p0);
		}

		// Token: 0x0600002F RID: 47 RVA: 0x00002E58 File Offset: 0x00001058
		[Register("setBorderColorResource", "(I)V", "GetSetBorderColorResource_IHandler")]
		public unsafe virtual void SetBorderColorResource(int p0)
		{
			if (_BaseCircleImageView.id_setBorderColorResource_I == IntPtr.Zero)
			{
				_BaseCircleImageView.id_setBorderColorResource_I = JNIEnv.GetMethodID(_BaseCircleImageView.class_ref, "setBorderColorResource", "(I)V");
			}
			try
			{
				JValue* ptr = stackalloc JValue[checked(1 * sizeof(JValue))];
				*ptr = new JValue(p0);
				if (base.GetType() == this.ThresholdType)
				{
					JNIEnv.CallVoidMethod(base.Handle, _BaseCircleImageView.id_setBorderColorResource_I, ptr);
				}
				else
				{
					JNIEnv.CallNonvirtualVoidMethod(base.Handle, this.ThresholdClass, JNIEnv.GetMethodID(this.ThresholdClass, "setBorderColorResource", "(I)V"), ptr);
				}
			}
			finally
			{
			}
		}

		// Token: 0x06000030 RID: 48 RVA: 0x00002F14 File Offset: 0x00001114
		private static Delegate GetSetFillColorResource_IHandler()
		{
			if (_BaseCircleImageView.cb_setFillColorResource_I == null)
			{
				if (_BaseCircleImageView.<>f__mg$cache9 == null)
				{
					_BaseCircleImageView.<>f__mg$cache9 = new Action<IntPtr, IntPtr, int>(_BaseCircleImageView.n_SetFillColorResource_I);
				}
				_BaseCircleImageView.cb_setFillColorResource_I = JNINativeWrapper.CreateDelegate(_BaseCircleImageView.<>f__mg$cache9);
			}
			return _BaseCircleImageView.cb_setFillColorResource_I;
		}

		// Token: 0x06000031 RID: 49 RVA: 0x00002F4C File Offset: 0x0000114C
		private static void n_SetFillColorResource_I(IntPtr jnienv, IntPtr native__this, int p0)
		{
			_BaseCircleImageView @object = Java.Lang.Object.GetObject<_BaseCircleImageView>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			@object.SetFillColorResource(p0);
		}

		// Token: 0x06000032 RID: 50 RVA: 0x00002F6C File Offset: 0x0000116C
		[Register("setFillColorResource", "(I)V", "GetSetFillColorResource_IHandler")]
		public unsafe virtual void SetFillColorResource(int p0)
		{
			if (_BaseCircleImageView.id_setFillColorResource_I == IntPtr.Zero)
			{
				_BaseCircleImageView.id_setFillColorResource_I = JNIEnv.GetMethodID(_BaseCircleImageView.class_ref, "setFillColorResource", "(I)V");
			}
			try
			{
				JValue* ptr = stackalloc JValue[checked(1 * sizeof(JValue))];
				*ptr = new JValue(p0);
				if (base.GetType() == this.ThresholdType)
				{
					JNIEnv.CallVoidMethod(base.Handle, _BaseCircleImageView.id_setFillColorResource_I, ptr);
				}
				else
				{
					JNIEnv.CallNonvirtualVoidMethod(base.Handle, this.ThresholdClass, JNIEnv.GetMethodID(this.ThresholdClass, "setFillColorResource", "(I)V"), ptr);
				}
			}
			finally
			{
			}
		}

		// Token: 0x0400000B RID: 11
		internal static IntPtr java_class_handle;

		// Token: 0x0400000C RID: 12
		private static IntPtr id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_I;

		// Token: 0x0400000D RID: 13
		private static IntPtr id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_;

		// Token: 0x0400000E RID: 14
		private static IntPtr id_ctor_Landroid_content_Context_;

		// Token: 0x0400000F RID: 15
		private static Delegate cb_getBorderColor;

		// Token: 0x04000010 RID: 16
		private static Delegate cb_setBorderColor_I;

		// Token: 0x04000011 RID: 17
		private static IntPtr id_getBorderColor;

		// Token: 0x04000012 RID: 18
		private static IntPtr id_setBorderColor_I;

		// Token: 0x04000013 RID: 19
		private static Delegate cb_isBorderOverlay;

		// Token: 0x04000014 RID: 20
		private static Delegate cb_setBorderOverlay_Z;

		// Token: 0x04000015 RID: 21
		private static IntPtr id_isBorderOverlay;

		// Token: 0x04000016 RID: 22
		private static IntPtr id_setBorderOverlay_Z;

		// Token: 0x04000017 RID: 23
		private static Delegate cb_getBorderWidth;

		// Token: 0x04000018 RID: 24
		private static Delegate cb_setBorderWidth_I;

		// Token: 0x04000019 RID: 25
		private static IntPtr id_getBorderWidth;

		// Token: 0x0400001A RID: 26
		private static IntPtr id_setBorderWidth_I;

		// Token: 0x0400001B RID: 27
		private static Delegate cb_getFillColor;

		// Token: 0x0400001C RID: 28
		private static Delegate cb_setFillColor_I;

		// Token: 0x0400001D RID: 29
		private static IntPtr id_getFillColor;

		// Token: 0x0400001E RID: 30
		private static IntPtr id_setFillColor_I;

		// Token: 0x0400001F RID: 31
		private static Delegate cb_setBorderColorResource_I;

		// Token: 0x04000020 RID: 32
		private static IntPtr id_setBorderColorResource_I;

		// Token: 0x04000021 RID: 33
		private static Delegate cb_setFillColorResource_I;

		// Token: 0x04000022 RID: 34
		private static IntPtr id_setFillColorResource_I;

		// Token: 0x04000023 RID: 35
		[CompilerGenerated]
		private static Func<IntPtr, IntPtr, int> <>f__mg$cache0;

		// Token: 0x04000024 RID: 36
		[CompilerGenerated]
		private static Action<IntPtr, IntPtr, int> <>f__mg$cache1;

		// Token: 0x04000025 RID: 37
		[CompilerGenerated]
		private static Func<IntPtr, IntPtr, bool> <>f__mg$cache2;

		// Token: 0x04000026 RID: 38
		[CompilerGenerated]
		private static Action<IntPtr, IntPtr, bool> <>f__mg$cache3;

		// Token: 0x04000027 RID: 39
		[CompilerGenerated]
		private static Func<IntPtr, IntPtr, int> <>f__mg$cache4;

		// Token: 0x04000028 RID: 40
		[CompilerGenerated]
		private static Action<IntPtr, IntPtr, int> <>f__mg$cache5;

		// Token: 0x04000029 RID: 41
		[CompilerGenerated]
		private static Func<IntPtr, IntPtr, int> <>f__mg$cache6;

		// Token: 0x0400002A RID: 42
		[CompilerGenerated]
		private static Action<IntPtr, IntPtr, int> <>f__mg$cache7;

		// Token: 0x0400002B RID: 43
		[CompilerGenerated]
		private static Action<IntPtr, IntPtr, int> <>f__mg$cache8;

		// Token: 0x0400002C RID: 44
		[CompilerGenerated]
		private static Action<IntPtr, IntPtr, int> <>f__mg$cache9;
	}
}
