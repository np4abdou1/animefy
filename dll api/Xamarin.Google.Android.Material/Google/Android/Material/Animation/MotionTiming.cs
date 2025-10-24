using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Animation;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Google.Android.Material.Animation
{
	// Token: 0x020000A0 RID: 160
	[Register("com/google/android/material/animation/MotionTiming", DoNotGenerateAcw = true)]
	public class MotionTiming : Java.Lang.Object
	{
		// Token: 0x170001E0 RID: 480
		// (get) Token: 0x06000B89 RID: 2953 RVA: 0x0001F2F4 File Offset: 0x0001D4F4
		internal static IntPtr class_ref
		{
			get
			{
				return MotionTiming._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170001E1 RID: 481
		// (get) Token: 0x06000B8A RID: 2954 RVA: 0x0001F318 File Offset: 0x0001D518
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return MotionTiming._members;
			}
		}

		// Token: 0x170001E2 RID: 482
		// (get) Token: 0x06000B8B RID: 2955 RVA: 0x0001F320 File Offset: 0x0001D520
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return MotionTiming._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170001E3 RID: 483
		// (get) Token: 0x06000B8C RID: 2956 RVA: 0x0001F344 File Offset: 0x0001D544
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return MotionTiming._members.ManagedPeerType;
			}
		}

		// Token: 0x06000B8D RID: 2957 RVA: 0x000020DC File Offset: 0x000002DC
		protected MotionTiming(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000B8E RID: 2958 RVA: 0x0001F350 File Offset: 0x0001D550
		[Register(".ctor", "(JJ)V", "")]
		public unsafe MotionTiming(long delay, long duration) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(delay);
			ptr[1] = new JniArgumentValue(duration);
			base.SetHandle(MotionTiming._members.InstanceMethods.StartCreateInstance("(JJ)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
			MotionTiming._members.InstanceMethods.FinishCreateInstance("(JJ)V", this, ptr);
		}

		// Token: 0x06000B8F RID: 2959 RVA: 0x0001F3E8 File Offset: 0x0001D5E8
		[Register(".ctor", "(JJLandroid/animation/TimeInterpolator;)V", "")]
		public unsafe MotionTiming(long delay, long duration, ITimeInterpolator interpolator) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(delay);
				ptr[1] = new JniArgumentValue(duration);
				ptr[2] = new JniArgumentValue((interpolator == null) ? IntPtr.Zero : ((Java.Lang.Object)interpolator).Handle);
				base.SetHandle(MotionTiming._members.InstanceMethods.StartCreateInstance("(JJLandroid/animation/TimeInterpolator;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				MotionTiming._members.InstanceMethods.FinishCreateInstance("(JJLandroid/animation/TimeInterpolator;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(interpolator);
			}
		}

		// Token: 0x06000B90 RID: 2960 RVA: 0x0001F4C4 File Offset: 0x0001D6C4
		private static Delegate GetGetDelayHandler()
		{
			if (MotionTiming.cb_getDelay == null)
			{
				MotionTiming.cb_getDelay = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_J(MotionTiming.n_GetDelay));
			}
			return MotionTiming.cb_getDelay;
		}

		// Token: 0x06000B91 RID: 2961 RVA: 0x0001F4E8 File Offset: 0x0001D6E8
		private static long n_GetDelay(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<MotionTiming>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Delay;
		}

		// Token: 0x170001E4 RID: 484
		// (get) Token: 0x06000B92 RID: 2962 RVA: 0x0001F4F7 File Offset: 0x0001D6F7
		public virtual long Delay
		{
			[Register("getDelay", "()J", "GetGetDelayHandler")]
			get
			{
				return MotionTiming._members.InstanceMethods.InvokeVirtualInt64Method("getDelay.()J", this, null);
			}
		}

		// Token: 0x06000B93 RID: 2963 RVA: 0x0001F510 File Offset: 0x0001D710
		private static Delegate GetGetDurationHandler()
		{
			if (MotionTiming.cb_getDuration == null)
			{
				MotionTiming.cb_getDuration = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_J(MotionTiming.n_GetDuration));
			}
			return MotionTiming.cb_getDuration;
		}

		// Token: 0x06000B94 RID: 2964 RVA: 0x0001F534 File Offset: 0x0001D734
		private static long n_GetDuration(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<MotionTiming>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Duration;
		}

		// Token: 0x170001E5 RID: 485
		// (get) Token: 0x06000B95 RID: 2965 RVA: 0x0001F543 File Offset: 0x0001D743
		public virtual long Duration
		{
			[Register("getDuration", "()J", "GetGetDurationHandler")]
			get
			{
				return MotionTiming._members.InstanceMethods.InvokeVirtualInt64Method("getDuration.()J", this, null);
			}
		}

		// Token: 0x06000B96 RID: 2966 RVA: 0x0001F55C File Offset: 0x0001D75C
		private static Delegate GetGetInterpolatorHandler()
		{
			if (MotionTiming.cb_getInterpolator == null)
			{
				MotionTiming.cb_getInterpolator = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(MotionTiming.n_GetInterpolator));
			}
			return MotionTiming.cb_getInterpolator;
		}

		// Token: 0x06000B97 RID: 2967 RVA: 0x0001F580 File Offset: 0x0001D780
		private static IntPtr n_GetInterpolator(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<MotionTiming>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Interpolator);
		}

		// Token: 0x170001E6 RID: 486
		// (get) Token: 0x06000B98 RID: 2968 RVA: 0x0001F594 File Offset: 0x0001D794
		public virtual ITimeInterpolator Interpolator
		{
			[Register("getInterpolator", "()Landroid/animation/TimeInterpolator;", "GetGetInterpolatorHandler")]
			get
			{
				return Java.Lang.Object.GetObject<ITimeInterpolator>(MotionTiming._members.InstanceMethods.InvokeVirtualObjectMethod("getInterpolator.()Landroid/animation/TimeInterpolator;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06000B99 RID: 2969 RVA: 0x0001F5C6 File Offset: 0x0001D7C6
		private static Delegate GetGetRepeatCountHandler()
		{
			if (MotionTiming.cb_getRepeatCount == null)
			{
				MotionTiming.cb_getRepeatCount = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(MotionTiming.n_GetRepeatCount));
			}
			return MotionTiming.cb_getRepeatCount;
		}

		// Token: 0x06000B9A RID: 2970 RVA: 0x0001F5EA File Offset: 0x0001D7EA
		private static int n_GetRepeatCount(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<MotionTiming>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).RepeatCount;
		}

		// Token: 0x170001E7 RID: 487
		// (get) Token: 0x06000B9B RID: 2971 RVA: 0x0001F5F9 File Offset: 0x0001D7F9
		public virtual int RepeatCount
		{
			[Register("getRepeatCount", "()I", "GetGetRepeatCountHandler")]
			get
			{
				return MotionTiming._members.InstanceMethods.InvokeVirtualInt32Method("getRepeatCount.()I", this, null);
			}
		}

		// Token: 0x06000B9C RID: 2972 RVA: 0x0001F612 File Offset: 0x0001D812
		private static Delegate GetGetRepeatModeHandler()
		{
			if (MotionTiming.cb_getRepeatMode == null)
			{
				MotionTiming.cb_getRepeatMode = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(MotionTiming.n_GetRepeatMode));
			}
			return MotionTiming.cb_getRepeatMode;
		}

		// Token: 0x06000B9D RID: 2973 RVA: 0x0001F636 File Offset: 0x0001D836
		private static int n_GetRepeatMode(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<MotionTiming>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).RepeatMode;
		}

		// Token: 0x170001E8 RID: 488
		// (get) Token: 0x06000B9E RID: 2974 RVA: 0x0001F645 File Offset: 0x0001D845
		public virtual int RepeatMode
		{
			[Register("getRepeatMode", "()I", "GetGetRepeatModeHandler")]
			get
			{
				return MotionTiming._members.InstanceMethods.InvokeVirtualInt32Method("getRepeatMode.()I", this, null);
			}
		}

		// Token: 0x06000B9F RID: 2975 RVA: 0x0001F65E File Offset: 0x0001D85E
		private static Delegate GetApply_Landroid_animation_Animator_Handler()
		{
			if (MotionTiming.cb_apply_Landroid_animation_Animator_ == null)
			{
				MotionTiming.cb_apply_Landroid_animation_Animator_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(MotionTiming.n_Apply_Landroid_animation_Animator_));
			}
			return MotionTiming.cb_apply_Landroid_animation_Animator_;
		}

		// Token: 0x06000BA0 RID: 2976 RVA: 0x0001F684 File Offset: 0x0001D884
		private static void n_Apply_Landroid_animation_Animator_(IntPtr jnienv, IntPtr native__this, IntPtr native_animator)
		{
			MotionTiming @object = Java.Lang.Object.GetObject<MotionTiming>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Animator object2 = Java.Lang.Object.GetObject<Animator>(native_animator, JniHandleOwnership.DoNotTransfer);
			@object.Apply(object2);
		}

		// Token: 0x06000BA1 RID: 2977 RVA: 0x0001F6A8 File Offset: 0x0001D8A8
		[Register("apply", "(Landroid/animation/Animator;)V", "GetApply_Landroid_animation_Animator_Handler")]
		public unsafe virtual void Apply(Animator animator)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((animator == null) ? IntPtr.Zero : animator.Handle);
				MotionTiming._members.InstanceMethods.InvokeVirtualVoidMethod("apply.(Landroid/animation/Animator;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(animator);
			}
		}

		// Token: 0x0400035B RID: 859
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/google/android/material/animation/MotionTiming", typeof(MotionTiming));

		// Token: 0x0400035C RID: 860
		private static Delegate cb_getDelay;

		// Token: 0x0400035D RID: 861
		private static Delegate cb_getDuration;

		// Token: 0x0400035E RID: 862
		private static Delegate cb_getInterpolator;

		// Token: 0x0400035F RID: 863
		private static Delegate cb_getRepeatCount;

		// Token: 0x04000360 RID: 864
		private static Delegate cb_getRepeatMode;

		// Token: 0x04000361 RID: 865
		private static Delegate cb_apply_Landroid_animation_Animator_;
	}
}
