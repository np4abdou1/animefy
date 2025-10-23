using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Graphics.Drawables;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace AndroidX.VectorDrawable.Graphics.Drawable
{
	// Token: 0x0200000C RID: 12
	[Register("androidx/vectordrawable/graphics/drawable/Animatable2Compat", DoNotGenerateAcw = true)]
	internal class IAnimatable2CompatInvoker : Java.Lang.Object, IAnimatable2Compat, IAnimatable, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000007 RID: 7
		// (get) Token: 0x06000028 RID: 40 RVA: 0x00002304 File Offset: 0x00000504
		private static IntPtr java_class_ref
		{
			get
			{
				return IAnimatable2CompatInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x06000029 RID: 41 RVA: 0x00002328 File Offset: 0x00000528
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IAnimatable2CompatInvoker._members;
			}
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x0600002A RID: 42 RVA: 0x0000232F File Offset: 0x0000052F
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x0600002B RID: 43 RVA: 0x00002337 File Offset: 0x00000537
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IAnimatable2CompatInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x0600002C RID: 44 RVA: 0x00002343 File Offset: 0x00000543
		public static IAnimatable2Compat GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IAnimatable2Compat>(handle, transfer);
		}

		// Token: 0x0600002D RID: 45 RVA: 0x0000234C File Offset: 0x0000054C
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IAnimatable2CompatInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'androidx.vectordrawable.graphics.drawable.Animatable2Compat'.");
			}
			return handle;
		}

		// Token: 0x0600002E RID: 46 RVA: 0x00002377 File Offset: 0x00000577
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x0600002F RID: 47 RVA: 0x000023A8 File Offset: 0x000005A8
		public IAnimatable2CompatInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IAnimatable2CompatInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x06000030 RID: 48 RVA: 0x000023E0 File Offset: 0x000005E0
		private static Delegate GetClearAnimationCallbacksHandler()
		{
			if (IAnimatable2CompatInvoker.cb_clearAnimationCallbacks == null)
			{
				IAnimatable2CompatInvoker.cb_clearAnimationCallbacks = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(IAnimatable2CompatInvoker.n_ClearAnimationCallbacks));
			}
			return IAnimatable2CompatInvoker.cb_clearAnimationCallbacks;
		}

		// Token: 0x06000031 RID: 49 RVA: 0x00002404 File Offset: 0x00000604
		private static void n_ClearAnimationCallbacks(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<IAnimatable2Compat>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ClearAnimationCallbacks();
		}

		// Token: 0x06000032 RID: 50 RVA: 0x00002413 File Offset: 0x00000613
		public void ClearAnimationCallbacks()
		{
			if (this.id_clearAnimationCallbacks == IntPtr.Zero)
			{
				this.id_clearAnimationCallbacks = JNIEnv.GetMethodID(this.class_ref, "clearAnimationCallbacks", "()V");
			}
			JNIEnv.CallVoidMethod(base.Handle, this.id_clearAnimationCallbacks);
		}

		// Token: 0x06000033 RID: 51 RVA: 0x00002453 File Offset: 0x00000653
		private static Delegate GetRegisterAnimationCallback_Landroidx_vectordrawable_graphics_drawable_Animatable2Compat_AnimationCallback_Handler()
		{
			if (IAnimatable2CompatInvoker.cb_registerAnimationCallback_Landroidx_vectordrawable_graphics_drawable_Animatable2Compat_AnimationCallback_ == null)
			{
				IAnimatable2CompatInvoker.cb_registerAnimationCallback_Landroidx_vectordrawable_graphics_drawable_Animatable2Compat_AnimationCallback_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(IAnimatable2CompatInvoker.n_RegisterAnimationCallback_Landroidx_vectordrawable_graphics_drawable_Animatable2Compat_AnimationCallback_));
			}
			return IAnimatable2CompatInvoker.cb_registerAnimationCallback_Landroidx_vectordrawable_graphics_drawable_Animatable2Compat_AnimationCallback_;
		}

		// Token: 0x06000034 RID: 52 RVA: 0x00002478 File Offset: 0x00000678
		private static void n_RegisterAnimationCallback_Landroidx_vectordrawable_graphics_drawable_Animatable2Compat_AnimationCallback_(IntPtr jnienv, IntPtr native__this, IntPtr native_callback)
		{
			IAnimatable2Compat @object = Java.Lang.Object.GetObject<IAnimatable2Compat>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Animatable2CompatAnimationCallback object2 = Java.Lang.Object.GetObject<Animatable2CompatAnimationCallback>(native_callback, JniHandleOwnership.DoNotTransfer);
			@object.RegisterAnimationCallback(object2);
		}

		// Token: 0x06000035 RID: 53 RVA: 0x0000249C File Offset: 0x0000069C
		public unsafe void RegisterAnimationCallback(Animatable2CompatAnimationCallback callback_)
		{
			if (this.id_registerAnimationCallback_Landroidx_vectordrawable_graphics_drawable_Animatable2Compat_AnimationCallback_ == IntPtr.Zero)
			{
				this.id_registerAnimationCallback_Landroidx_vectordrawable_graphics_drawable_Animatable2Compat_AnimationCallback_ = JNIEnv.GetMethodID(this.class_ref, "registerAnimationCallback", "(Landroidx/vectordrawable/graphics/drawable/Animatable2Compat$AnimationCallback;)V");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((callback_ == null) ? IntPtr.Zero : callback_.Handle);
			JNIEnv.CallVoidMethod(base.Handle, this.id_registerAnimationCallback_Landroidx_vectordrawable_graphics_drawable_Animatable2Compat_AnimationCallback_, ptr);
		}

		// Token: 0x06000036 RID: 54 RVA: 0x0000250F File Offset: 0x0000070F
		private static Delegate GetUnregisterAnimationCallback_Landroidx_vectordrawable_graphics_drawable_Animatable2Compat_AnimationCallback_Handler()
		{
			if (IAnimatable2CompatInvoker.cb_unregisterAnimationCallback_Landroidx_vectordrawable_graphics_drawable_Animatable2Compat_AnimationCallback_ == null)
			{
				IAnimatable2CompatInvoker.cb_unregisterAnimationCallback_Landroidx_vectordrawable_graphics_drawable_Animatable2Compat_AnimationCallback_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(IAnimatable2CompatInvoker.n_UnregisterAnimationCallback_Landroidx_vectordrawable_graphics_drawable_Animatable2Compat_AnimationCallback_));
			}
			return IAnimatable2CompatInvoker.cb_unregisterAnimationCallback_Landroidx_vectordrawable_graphics_drawable_Animatable2Compat_AnimationCallback_;
		}

		// Token: 0x06000037 RID: 55 RVA: 0x00002534 File Offset: 0x00000734
		private static bool n_UnregisterAnimationCallback_Landroidx_vectordrawable_graphics_drawable_Animatable2Compat_AnimationCallback_(IntPtr jnienv, IntPtr native__this, IntPtr native_callback)
		{
			IAnimatable2Compat @object = Java.Lang.Object.GetObject<IAnimatable2Compat>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Animatable2CompatAnimationCallback object2 = Java.Lang.Object.GetObject<Animatable2CompatAnimationCallback>(native_callback, JniHandleOwnership.DoNotTransfer);
			return @object.UnregisterAnimationCallback(object2);
		}

		// Token: 0x06000038 RID: 56 RVA: 0x00002558 File Offset: 0x00000758
		public unsafe bool UnregisterAnimationCallback(Animatable2CompatAnimationCallback callback_)
		{
			if (this.id_unregisterAnimationCallback_Landroidx_vectordrawable_graphics_drawable_Animatable2Compat_AnimationCallback_ == IntPtr.Zero)
			{
				this.id_unregisterAnimationCallback_Landroidx_vectordrawable_graphics_drawable_Animatable2Compat_AnimationCallback_ = JNIEnv.GetMethodID(this.class_ref, "unregisterAnimationCallback", "(Landroidx/vectordrawable/graphics/drawable/Animatable2Compat$AnimationCallback;)Z");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((callback_ == null) ? IntPtr.Zero : callback_.Handle);
			return JNIEnv.CallBooleanMethod(base.Handle, this.id_unregisterAnimationCallback_Landroidx_vectordrawable_graphics_drawable_Animatable2Compat_AnimationCallback_, ptr);
		}

		// Token: 0x06000039 RID: 57 RVA: 0x000025CB File Offset: 0x000007CB
		private static Delegate GetIsRunningHandler()
		{
			if (IAnimatable2CompatInvoker.cb_isRunning == null)
			{
				IAnimatable2CompatInvoker.cb_isRunning = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(IAnimatable2CompatInvoker.n_IsRunning));
			}
			return IAnimatable2CompatInvoker.cb_isRunning;
		}

		// Token: 0x0600003A RID: 58 RVA: 0x000025EF File Offset: 0x000007EF
		private static bool n_IsRunning(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IAnimatable2Compat>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsRunning;
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x0600003B RID: 59 RVA: 0x000025FE File Offset: 0x000007FE
		public bool IsRunning
		{
			get
			{
				if (this.id_isRunning == IntPtr.Zero)
				{
					this.id_isRunning = JNIEnv.GetMethodID(this.class_ref, "isRunning", "()Z");
				}
				return JNIEnv.CallBooleanMethod(base.Handle, this.id_isRunning);
			}
		}

		// Token: 0x0600003C RID: 60 RVA: 0x0000263E File Offset: 0x0000083E
		private static Delegate GetStartHandler()
		{
			if (IAnimatable2CompatInvoker.cb_start == null)
			{
				IAnimatable2CompatInvoker.cb_start = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(IAnimatable2CompatInvoker.n_Start));
			}
			return IAnimatable2CompatInvoker.cb_start;
		}

		// Token: 0x0600003D RID: 61 RVA: 0x00002662 File Offset: 0x00000862
		private static void n_Start(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<IAnimatable2Compat>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Start();
		}

		// Token: 0x0600003E RID: 62 RVA: 0x00002671 File Offset: 0x00000871
		public void Start()
		{
			if (this.id_start == IntPtr.Zero)
			{
				this.id_start = JNIEnv.GetMethodID(this.class_ref, "start", "()V");
			}
			JNIEnv.CallVoidMethod(base.Handle, this.id_start);
		}

		// Token: 0x0600003F RID: 63 RVA: 0x000026B1 File Offset: 0x000008B1
		private static Delegate GetStopHandler()
		{
			if (IAnimatable2CompatInvoker.cb_stop == null)
			{
				IAnimatable2CompatInvoker.cb_stop = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(IAnimatable2CompatInvoker.n_Stop));
			}
			return IAnimatable2CompatInvoker.cb_stop;
		}

		// Token: 0x06000040 RID: 64 RVA: 0x000026D5 File Offset: 0x000008D5
		private static void n_Stop(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<IAnimatable2Compat>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Stop();
		}

		// Token: 0x06000041 RID: 65 RVA: 0x000026E4 File Offset: 0x000008E4
		public void Stop()
		{
			if (this.id_stop == IntPtr.Zero)
			{
				this.id_stop = JNIEnv.GetMethodID(this.class_ref, "stop", "()V");
			}
			JNIEnv.CallVoidMethod(base.Handle, this.id_stop);
		}

		// Token: 0x04000007 RID: 7
		private static readonly JniPeerMembers _members = new XAPeerMembers("androidx/vectordrawable/graphics/drawable/Animatable2Compat", typeof(IAnimatable2CompatInvoker));

		// Token: 0x04000008 RID: 8
		private IntPtr class_ref;

		// Token: 0x04000009 RID: 9
		private static Delegate cb_clearAnimationCallbacks;

		// Token: 0x0400000A RID: 10
		private IntPtr id_clearAnimationCallbacks;

		// Token: 0x0400000B RID: 11
		private static Delegate cb_registerAnimationCallback_Landroidx_vectordrawable_graphics_drawable_Animatable2Compat_AnimationCallback_;

		// Token: 0x0400000C RID: 12
		private IntPtr id_registerAnimationCallback_Landroidx_vectordrawable_graphics_drawable_Animatable2Compat_AnimationCallback_;

		// Token: 0x0400000D RID: 13
		private static Delegate cb_unregisterAnimationCallback_Landroidx_vectordrawable_graphics_drawable_Animatable2Compat_AnimationCallback_;

		// Token: 0x0400000E RID: 14
		private IntPtr id_unregisterAnimationCallback_Landroidx_vectordrawable_graphics_drawable_Animatable2Compat_AnimationCallback_;

		// Token: 0x0400000F RID: 15
		private static Delegate cb_isRunning;

		// Token: 0x04000010 RID: 16
		private IntPtr id_isRunning;

		// Token: 0x04000011 RID: 17
		private static Delegate cb_start;

		// Token: 0x04000012 RID: 18
		private IntPtr id_start;

		// Token: 0x04000013 RID: 19
		private static Delegate cb_stop;

		// Token: 0x04000014 RID: 20
		private IntPtr id_stop;
	}
}
