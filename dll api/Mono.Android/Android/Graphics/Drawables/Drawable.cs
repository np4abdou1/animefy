using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Android.Graphics.Drawables
{
	// Token: 0x02000236 RID: 566
	[Register("android/graphics/drawable/Drawable", DoNotGenerateAcw = true)]
	public abstract class Drawable : Java.Lang.Object
	{
		// Token: 0x17000461 RID: 1121
		// (get) Token: 0x06001401 RID: 5121 RVA: 0x00033ABB File Offset: 0x00031CBB
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return Drawable._members;
			}
		}

		// Token: 0x17000462 RID: 1122
		// (get) Token: 0x06001402 RID: 5122 RVA: 0x00033AC4 File Offset: 0x00031CC4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return Drawable._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000463 RID: 1123
		// (get) Token: 0x06001403 RID: 5123 RVA: 0x00033AE8 File Offset: 0x00031CE8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return Drawable._members.ManagedPeerType;
			}
		}

		// Token: 0x06001404 RID: 5124 RVA: 0x000021E0 File Offset: 0x000003E0
		protected Drawable(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06001405 RID: 5125 RVA: 0x00033AF4 File Offset: 0x00031CF4
		private static Delegate GetGetOpacityHandler()
		{
			if (Drawable.cb_getOpacity == null)
			{
				Drawable.cb_getOpacity = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(Drawable.n_GetOpacity));
			}
			return Drawable.cb_getOpacity;
		}

		// Token: 0x06001406 RID: 5126 RVA: 0x00033B18 File Offset: 0x00031D18
		private static int n_GetOpacity(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<Drawable>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Opacity;
		}

		// Token: 0x17000464 RID: 1124
		// (get) Token: 0x06001407 RID: 5127
		public abstract int Opacity { get; }

		// Token: 0x06001408 RID: 5128 RVA: 0x00033B27 File Offset: 0x00031D27
		private static Delegate GetDraw_Landroid_graphics_Canvas_Handler()
		{
			if (Drawable.cb_draw_Landroid_graphics_Canvas_ == null)
			{
				Drawable.cb_draw_Landroid_graphics_Canvas_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(Drawable.n_Draw_Landroid_graphics_Canvas_));
			}
			return Drawable.cb_draw_Landroid_graphics_Canvas_;
		}

		// Token: 0x06001409 RID: 5129 RVA: 0x00033B4C File Offset: 0x00031D4C
		private static void n_Draw_Landroid_graphics_Canvas_(IntPtr jnienv, IntPtr native__this, IntPtr native_canvas)
		{
			Drawable @object = Java.Lang.Object.GetObject<Drawable>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Canvas object2 = Java.Lang.Object.GetObject<Canvas>(native_canvas, JniHandleOwnership.DoNotTransfer);
			@object.Draw(object2);
		}

		// Token: 0x0600140A RID: 5130
		public abstract void Draw(Canvas canvas);

		// Token: 0x0600140B RID: 5131 RVA: 0x00033B6F File Offset: 0x00031D6F
		private static Delegate GetGetStateHandler()
		{
			if (Drawable.cb_getState == null)
			{
				Drawable.cb_getState = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(Drawable.n_GetState));
			}
			return Drawable.cb_getState;
		}

		// Token: 0x0600140C RID: 5132 RVA: 0x00033B93 File Offset: 0x00031D93
		private static IntPtr n_GetState(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewArray(Java.Lang.Object.GetObject<Drawable>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).GetState());
		}

		// Token: 0x0600140D RID: 5133 RVA: 0x00033BA8 File Offset: 0x00031DA8
		public virtual int[] GetState()
		{
			return (int[])JNIEnv.GetArray(Drawable._members.InstanceMethods.InvokeVirtualObjectMethod("getState.()[I", this, null).Handle, JniHandleOwnership.TransferLocalRef, typeof(int));
		}

		// Token: 0x0600140E RID: 5134 RVA: 0x00033BE9 File Offset: 0x00031DE9
		private static Delegate GetOnStateChange_arrayIHandler()
		{
			if (Drawable.cb_onStateChange_arrayI == null)
			{
				Drawable.cb_onStateChange_arrayI = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(Drawable.n_OnStateChange_arrayI));
			}
			return Drawable.cb_onStateChange_arrayI;
		}

		// Token: 0x0600140F RID: 5135 RVA: 0x00033C10 File Offset: 0x00031E10
		private static bool n_OnStateChange_arrayI(IntPtr jnienv, IntPtr native__this, IntPtr native_state)
		{
			Drawable @object = Java.Lang.Object.GetObject<Drawable>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			int[] array = (int[])JNIEnv.GetArray(native_state, JniHandleOwnership.DoNotTransfer, typeof(int));
			bool result = @object.OnStateChange(array);
			if (array != null)
			{
				JNIEnv.CopyArray(array, native_state);
			}
			return result;
		}

		// Token: 0x06001410 RID: 5136 RVA: 0x00033C4C File Offset: 0x00031E4C
		protected unsafe virtual bool OnStateChange(int[] state)
		{
			IntPtr intPtr = JNIEnv.NewArray(state);
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				result = Drawable._members.InstanceMethods.InvokeVirtualBooleanMethod("onStateChange.([I)Z", this, ptr);
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

		// Token: 0x06001411 RID: 5137 RVA: 0x00033CBC File Offset: 0x00031EBC
		private static Delegate GetSetAlpha_IHandler()
		{
			if (Drawable.cb_setAlpha_I == null)
			{
				Drawable.cb_setAlpha_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_V(Drawable.n_SetAlpha_I));
			}
			return Drawable.cb_setAlpha_I;
		}

		// Token: 0x06001412 RID: 5138 RVA: 0x00033CE0 File Offset: 0x00031EE0
		private static void n_SetAlpha_I(IntPtr jnienv, IntPtr native__this, int alpha)
		{
			Java.Lang.Object.GetObject<Drawable>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SetAlpha(alpha);
		}

		// Token: 0x06001413 RID: 5139
		public abstract void SetAlpha(int alpha);

		// Token: 0x06001414 RID: 5140 RVA: 0x00033CF0 File Offset: 0x00031EF0
		private static Delegate GetSetColorFilter_Landroid_graphics_ColorFilter_Handler()
		{
			if (Drawable.cb_setColorFilter_Landroid_graphics_ColorFilter_ == null)
			{
				Drawable.cb_setColorFilter_Landroid_graphics_ColorFilter_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(Drawable.n_SetColorFilter_Landroid_graphics_ColorFilter_));
			}
			return Drawable.cb_setColorFilter_Landroid_graphics_ColorFilter_;
		}

		// Token: 0x06001415 RID: 5141 RVA: 0x00033D14 File Offset: 0x00031F14
		private static void n_SetColorFilter_Landroid_graphics_ColorFilter_(IntPtr jnienv, IntPtr native__this, IntPtr native_colorFilter)
		{
			Drawable @object = Java.Lang.Object.GetObject<Drawable>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ColorFilter object2 = Java.Lang.Object.GetObject<ColorFilter>(native_colorFilter, JniHandleOwnership.DoNotTransfer);
			@object.SetColorFilter(object2);
		}

		// Token: 0x06001416 RID: 5142
		public abstract void SetColorFilter(ColorFilter colorFilter);

		// Token: 0x040008C7 RID: 2247
		private static readonly JniPeerMembers _members = new XAPeerMembers("android/graphics/drawable/Drawable", typeof(Drawable));

		// Token: 0x040008C8 RID: 2248
		private static Delegate cb_getOpacity;

		// Token: 0x040008C9 RID: 2249
		private static Delegate cb_draw_Landroid_graphics_Canvas_;

		// Token: 0x040008CA RID: 2250
		private static Delegate cb_getState;

		// Token: 0x040008CB RID: 2251
		private static Delegate cb_onStateChange_arrayI;

		// Token: 0x040008CC RID: 2252
		private static Delegate cb_setAlpha_I;

		// Token: 0x040008CD RID: 2253
		private static Delegate cb_setColorFilter_Landroid_graphics_ColorFilter_;

		// Token: 0x02000237 RID: 567
		[Register("android/graphics/drawable/Drawable$Callback", "", "Android.Graphics.Drawables.Drawable/ICallbackInvoker")]
		public interface ICallback : IJavaObject, IDisposable, IJavaPeerable
		{
			// Token: 0x06001418 RID: 5144
			[Register("invalidateDrawable", "(Landroid/graphics/drawable/Drawable;)V", "GetInvalidateDrawable_Landroid_graphics_drawable_Drawable_Handler:Android.Graphics.Drawables.Drawable/ICallbackInvoker, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null")]
			void InvalidateDrawable(Drawable who);

			// Token: 0x06001419 RID: 5145
			[Register("scheduleDrawable", "(Landroid/graphics/drawable/Drawable;Ljava/lang/Runnable;J)V", "GetScheduleDrawable_Landroid_graphics_drawable_Drawable_Ljava_lang_Runnable_JHandler:Android.Graphics.Drawables.Drawable/ICallbackInvoker, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null")]
			void ScheduleDrawable(Drawable who, IRunnable what, long when);

			// Token: 0x0600141A RID: 5146
			[Register("unscheduleDrawable", "(Landroid/graphics/drawable/Drawable;Ljava/lang/Runnable;)V", "GetUnscheduleDrawable_Landroid_graphics_drawable_Drawable_Ljava_lang_Runnable_Handler:Android.Graphics.Drawables.Drawable/ICallbackInvoker, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null")]
			void UnscheduleDrawable(Drawable who, IRunnable what);
		}

		// Token: 0x02000238 RID: 568
		[Register("android/graphics/drawable/Drawable$Callback", DoNotGenerateAcw = true)]
		internal class ICallbackInvoker : Java.Lang.Object, Drawable.ICallback, IJavaObject, IDisposable, IJavaPeerable
		{
			// Token: 0x17000465 RID: 1125
			// (get) Token: 0x0600141B RID: 5147 RVA: 0x00033D54 File Offset: 0x00031F54
			private static IntPtr java_class_ref
			{
				get
				{
					return Drawable.ICallbackInvoker._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x17000466 RID: 1126
			// (get) Token: 0x0600141C RID: 5148 RVA: 0x00033D78 File Offset: 0x00031F78
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return Drawable.ICallbackInvoker._members;
				}
			}

			// Token: 0x17000467 RID: 1127
			// (get) Token: 0x0600141D RID: 5149 RVA: 0x00033D7F File Offset: 0x00031F7F
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return this.class_ref;
				}
			}

			// Token: 0x17000468 RID: 1128
			// (get) Token: 0x0600141E RID: 5150 RVA: 0x00033D87 File Offset: 0x00031F87
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return Drawable.ICallbackInvoker._members.ManagedPeerType;
				}
			}

			// Token: 0x0600141F RID: 5151 RVA: 0x00033D93 File Offset: 0x00031F93
			private static IntPtr Validate(IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf(handle, Drawable.ICallbackInvoker.java_class_ref))
				{
					throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'android.graphics.drawable.Drawable.Callback'.");
				}
				return handle;
			}

			// Token: 0x06001420 RID: 5152 RVA: 0x00033DBE File Offset: 0x00031FBE
			protected override void Dispose(bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
				{
					JNIEnv.DeleteGlobalRef(this.class_ref);
				}
				this.class_ref = IntPtr.Zero;
				base.Dispose(disposing);
			}

			// Token: 0x06001421 RID: 5153 RVA: 0x00033DF0 File Offset: 0x00031FF0
			public ICallbackInvoker(IntPtr handle, JniHandleOwnership transfer) : base(Drawable.ICallbackInvoker.Validate(handle), transfer)
			{
				IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
				this.class_ref = JNIEnv.NewGlobalRef(objectClass);
				JNIEnv.DeleteLocalRef(objectClass);
			}

			// Token: 0x06001422 RID: 5154 RVA: 0x00033E28 File Offset: 0x00032028
			private static Delegate GetInvalidateDrawable_Landroid_graphics_drawable_Drawable_Handler()
			{
				if (Drawable.ICallbackInvoker.cb_invalidateDrawable_Landroid_graphics_drawable_Drawable_ == null)
				{
					Drawable.ICallbackInvoker.cb_invalidateDrawable_Landroid_graphics_drawable_Drawable_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(Drawable.ICallbackInvoker.n_InvalidateDrawable_Landroid_graphics_drawable_Drawable_));
				}
				return Drawable.ICallbackInvoker.cb_invalidateDrawable_Landroid_graphics_drawable_Drawable_;
			}

			// Token: 0x06001423 RID: 5155 RVA: 0x00033E4C File Offset: 0x0003204C
			private static void n_InvalidateDrawable_Landroid_graphics_drawable_Drawable_(IntPtr jnienv, IntPtr native__this, IntPtr native_who)
			{
				Drawable.ICallback @object = Java.Lang.Object.GetObject<Drawable.ICallback>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				Drawable object2 = Java.Lang.Object.GetObject<Drawable>(native_who, JniHandleOwnership.DoNotTransfer);
				@object.InvalidateDrawable(object2);
			}

			// Token: 0x06001424 RID: 5156 RVA: 0x00033E70 File Offset: 0x00032070
			public unsafe void InvalidateDrawable(Drawable who)
			{
				if (this.id_invalidateDrawable_Landroid_graphics_drawable_Drawable_ == IntPtr.Zero)
				{
					this.id_invalidateDrawable_Landroid_graphics_drawable_Drawable_ = JNIEnv.GetMethodID(this.class_ref, "invalidateDrawable", "(Landroid/graphics/drawable/Drawable;)V");
				}
				JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
				*ptr = new JValue((who == null) ? IntPtr.Zero : who.Handle);
				JNIEnv.CallVoidMethod(base.Handle, this.id_invalidateDrawable_Landroid_graphics_drawable_Drawable_, ptr);
			}

			// Token: 0x06001425 RID: 5157 RVA: 0x00033EE3 File Offset: 0x000320E3
			private static Delegate GetScheduleDrawable_Landroid_graphics_drawable_Drawable_Ljava_lang_Runnable_JHandler()
			{
				if (Drawable.ICallbackInvoker.cb_scheduleDrawable_Landroid_graphics_drawable_Drawable_Ljava_lang_Runnable_J == null)
				{
					Drawable.ICallbackInvoker.cb_scheduleDrawable_Landroid_graphics_drawable_Drawable_Ljava_lang_Runnable_J = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLLJ_V(Drawable.ICallbackInvoker.n_ScheduleDrawable_Landroid_graphics_drawable_Drawable_Ljava_lang_Runnable_J));
				}
				return Drawable.ICallbackInvoker.cb_scheduleDrawable_Landroid_graphics_drawable_Drawable_Ljava_lang_Runnable_J;
			}

			// Token: 0x06001426 RID: 5158 RVA: 0x00033F08 File Offset: 0x00032108
			private static void n_ScheduleDrawable_Landroid_graphics_drawable_Drawable_Ljava_lang_Runnable_J(IntPtr jnienv, IntPtr native__this, IntPtr native_who, IntPtr native_what, long when)
			{
				Drawable.ICallback @object = Java.Lang.Object.GetObject<Drawable.ICallback>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				Drawable object2 = Java.Lang.Object.GetObject<Drawable>(native_who, JniHandleOwnership.DoNotTransfer);
				IRunnable object3 = Java.Lang.Object.GetObject<IRunnable>(native_what, JniHandleOwnership.DoNotTransfer);
				@object.ScheduleDrawable(object2, object3, when);
			}

			// Token: 0x06001427 RID: 5159 RVA: 0x00033F38 File Offset: 0x00032138
			public unsafe void ScheduleDrawable(Drawable who, IRunnable what, long when)
			{
				if (this.id_scheduleDrawable_Landroid_graphics_drawable_Drawable_Ljava_lang_Runnable_J == IntPtr.Zero)
				{
					this.id_scheduleDrawable_Landroid_graphics_drawable_Drawable_Ljava_lang_Runnable_J = JNIEnv.GetMethodID(this.class_ref, "scheduleDrawable", "(Landroid/graphics/drawable/Drawable;Ljava/lang/Runnable;J)V");
				}
				JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JValue))];
				*ptr = new JValue((who == null) ? IntPtr.Zero : who.Handle);
				ptr[1] = new JValue((what == null) ? IntPtr.Zero : ((Java.Lang.Object)what).Handle);
				ptr[2] = new JValue(when);
				JNIEnv.CallVoidMethod(base.Handle, this.id_scheduleDrawable_Landroid_graphics_drawable_Drawable_Ljava_lang_Runnable_J, ptr);
			}

			// Token: 0x06001428 RID: 5160 RVA: 0x00033FE8 File Offset: 0x000321E8
			private static Delegate GetUnscheduleDrawable_Landroid_graphics_drawable_Drawable_Ljava_lang_Runnable_Handler()
			{
				if (Drawable.ICallbackInvoker.cb_unscheduleDrawable_Landroid_graphics_drawable_Drawable_Ljava_lang_Runnable_ == null)
				{
					Drawable.ICallbackInvoker.cb_unscheduleDrawable_Landroid_graphics_drawable_Drawable_Ljava_lang_Runnable_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_V(Drawable.ICallbackInvoker.n_UnscheduleDrawable_Landroid_graphics_drawable_Drawable_Ljava_lang_Runnable_));
				}
				return Drawable.ICallbackInvoker.cb_unscheduleDrawable_Landroid_graphics_drawable_Drawable_Ljava_lang_Runnable_;
			}

			// Token: 0x06001429 RID: 5161 RVA: 0x0003400C File Offset: 0x0003220C
			private static void n_UnscheduleDrawable_Landroid_graphics_drawable_Drawable_Ljava_lang_Runnable_(IntPtr jnienv, IntPtr native__this, IntPtr native_who, IntPtr native_what)
			{
				Drawable.ICallback @object = Java.Lang.Object.GetObject<Drawable.ICallback>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				Drawable object2 = Java.Lang.Object.GetObject<Drawable>(native_who, JniHandleOwnership.DoNotTransfer);
				IRunnable object3 = Java.Lang.Object.GetObject<IRunnable>(native_what, JniHandleOwnership.DoNotTransfer);
				@object.UnscheduleDrawable(object2, object3);
			}

			// Token: 0x0600142A RID: 5162 RVA: 0x00034038 File Offset: 0x00032238
			public unsafe void UnscheduleDrawable(Drawable who, IRunnable what)
			{
				if (this.id_unscheduleDrawable_Landroid_graphics_drawable_Drawable_Ljava_lang_Runnable_ == IntPtr.Zero)
				{
					this.id_unscheduleDrawable_Landroid_graphics_drawable_Drawable_Ljava_lang_Runnable_ = JNIEnv.GetMethodID(this.class_ref, "unscheduleDrawable", "(Landroid/graphics/drawable/Drawable;Ljava/lang/Runnable;)V");
				}
				JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JValue))];
				*ptr = new JValue((who == null) ? IntPtr.Zero : who.Handle);
				ptr[1] = new JValue((what == null) ? IntPtr.Zero : ((Java.Lang.Object)what).Handle);
				JNIEnv.CallVoidMethod(base.Handle, this.id_unscheduleDrawable_Landroid_graphics_drawable_Drawable_Ljava_lang_Runnable_, ptr);
			}

			// Token: 0x040008CE RID: 2254
			private static readonly JniPeerMembers _members = new XAPeerMembers("android/graphics/drawable/Drawable$Callback", typeof(Drawable.ICallbackInvoker));

			// Token: 0x040008CF RID: 2255
			private IntPtr class_ref;

			// Token: 0x040008D0 RID: 2256
			private static Delegate cb_invalidateDrawable_Landroid_graphics_drawable_Drawable_;

			// Token: 0x040008D1 RID: 2257
			private IntPtr id_invalidateDrawable_Landroid_graphics_drawable_Drawable_;

			// Token: 0x040008D2 RID: 2258
			private static Delegate cb_scheduleDrawable_Landroid_graphics_drawable_Drawable_Ljava_lang_Runnable_J;

			// Token: 0x040008D3 RID: 2259
			private IntPtr id_scheduleDrawable_Landroid_graphics_drawable_Drawable_Ljava_lang_Runnable_J;

			// Token: 0x040008D4 RID: 2260
			private static Delegate cb_unscheduleDrawable_Landroid_graphics_drawable_Drawable_Ljava_lang_Runnable_;

			// Token: 0x040008D5 RID: 2261
			private IntPtr id_unscheduleDrawable_Landroid_graphics_drawable_Drawable_Ljava_lang_Runnable_;
		}
	}
}
