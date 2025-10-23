using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Android.Animation
{
	// Token: 0x0200024F RID: 591
	[Register("android/animation/AnimatorListenerAdapter", DoNotGenerateAcw = true)]
	public abstract class AnimatorListenerAdapter : Java.Lang.Object, Animator.IAnimatorListener, IJavaObject, IDisposable, IJavaPeerable, Animator.IAnimatorPauseListener
	{
		// Token: 0x170004B5 RID: 1205
		// (get) Token: 0x0600156E RID: 5486 RVA: 0x00036CA2 File Offset: 0x00034EA2
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return AnimatorListenerAdapter._members;
			}
		}

		// Token: 0x170004B6 RID: 1206
		// (get) Token: 0x0600156F RID: 5487 RVA: 0x00036CAC File Offset: 0x00034EAC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return AnimatorListenerAdapter._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170004B7 RID: 1207
		// (get) Token: 0x06001570 RID: 5488 RVA: 0x00036CD0 File Offset: 0x00034ED0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return AnimatorListenerAdapter._members.ManagedPeerType;
			}
		}

		// Token: 0x06001571 RID: 5489 RVA: 0x000021E0 File Offset: 0x000003E0
		protected AnimatorListenerAdapter(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06001572 RID: 5490 RVA: 0x00036CDC File Offset: 0x00034EDC
		private static Delegate GetOnAnimationCancel_Landroid_animation_Animator_Handler()
		{
			if (AnimatorListenerAdapter.cb_onAnimationCancel_Landroid_animation_Animator_ == null)
			{
				AnimatorListenerAdapter.cb_onAnimationCancel_Landroid_animation_Animator_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(AnimatorListenerAdapter.n_OnAnimationCancel_Landroid_animation_Animator_));
			}
			return AnimatorListenerAdapter.cb_onAnimationCancel_Landroid_animation_Animator_;
		}

		// Token: 0x06001573 RID: 5491 RVA: 0x00036D00 File Offset: 0x00034F00
		private static void n_OnAnimationCancel_Landroid_animation_Animator_(IntPtr jnienv, IntPtr native__this, IntPtr native_animation)
		{
			AnimatorListenerAdapter @object = Java.Lang.Object.GetObject<AnimatorListenerAdapter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Animator object2 = Java.Lang.Object.GetObject<Animator>(native_animation, JniHandleOwnership.DoNotTransfer);
			@object.OnAnimationCancel(object2);
		}

		// Token: 0x06001574 RID: 5492 RVA: 0x00036D24 File Offset: 0x00034F24
		public unsafe virtual void OnAnimationCancel(Animator animation)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((animation == null) ? IntPtr.Zero : animation.Handle);
				AnimatorListenerAdapter._members.InstanceMethods.InvokeVirtualVoidMethod("onAnimationCancel.(Landroid/animation/Animator;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(animation);
			}
		}

		// Token: 0x06001575 RID: 5493 RVA: 0x00036D88 File Offset: 0x00034F88
		private static Delegate GetOnAnimationEnd_Landroid_animation_Animator_Handler()
		{
			if (AnimatorListenerAdapter.cb_onAnimationEnd_Landroid_animation_Animator_ == null)
			{
				AnimatorListenerAdapter.cb_onAnimationEnd_Landroid_animation_Animator_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(AnimatorListenerAdapter.n_OnAnimationEnd_Landroid_animation_Animator_));
			}
			return AnimatorListenerAdapter.cb_onAnimationEnd_Landroid_animation_Animator_;
		}

		// Token: 0x06001576 RID: 5494 RVA: 0x00036DAC File Offset: 0x00034FAC
		private static void n_OnAnimationEnd_Landroid_animation_Animator_(IntPtr jnienv, IntPtr native__this, IntPtr native_animation)
		{
			AnimatorListenerAdapter @object = Java.Lang.Object.GetObject<AnimatorListenerAdapter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Animator object2 = Java.Lang.Object.GetObject<Animator>(native_animation, JniHandleOwnership.DoNotTransfer);
			@object.OnAnimationEnd(object2);
		}

		// Token: 0x06001577 RID: 5495 RVA: 0x00036DD0 File Offset: 0x00034FD0
		public unsafe virtual void OnAnimationEnd(Animator animation)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((animation == null) ? IntPtr.Zero : animation.Handle);
				AnimatorListenerAdapter._members.InstanceMethods.InvokeVirtualVoidMethod("onAnimationEnd.(Landroid/animation/Animator;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(animation);
			}
		}

		// Token: 0x06001578 RID: 5496 RVA: 0x00036E34 File Offset: 0x00035034
		private static Delegate GetOnAnimationPause_Landroid_animation_Animator_Handler()
		{
			if (AnimatorListenerAdapter.cb_onAnimationPause_Landroid_animation_Animator_ == null)
			{
				AnimatorListenerAdapter.cb_onAnimationPause_Landroid_animation_Animator_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(AnimatorListenerAdapter.n_OnAnimationPause_Landroid_animation_Animator_));
			}
			return AnimatorListenerAdapter.cb_onAnimationPause_Landroid_animation_Animator_;
		}

		// Token: 0x06001579 RID: 5497 RVA: 0x00036E58 File Offset: 0x00035058
		private static void n_OnAnimationPause_Landroid_animation_Animator_(IntPtr jnienv, IntPtr native__this, IntPtr native_animation)
		{
			AnimatorListenerAdapter @object = Java.Lang.Object.GetObject<AnimatorListenerAdapter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Animator object2 = Java.Lang.Object.GetObject<Animator>(native_animation, JniHandleOwnership.DoNotTransfer);
			@object.OnAnimationPause(object2);
		}

		// Token: 0x0600157A RID: 5498 RVA: 0x00036E7C File Offset: 0x0003507C
		public unsafe virtual void OnAnimationPause(Animator animation)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((animation == null) ? IntPtr.Zero : animation.Handle);
				AnimatorListenerAdapter._members.InstanceMethods.InvokeVirtualVoidMethod("onAnimationPause.(Landroid/animation/Animator;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(animation);
			}
		}

		// Token: 0x0600157B RID: 5499 RVA: 0x00036EE0 File Offset: 0x000350E0
		private static Delegate GetOnAnimationRepeat_Landroid_animation_Animator_Handler()
		{
			if (AnimatorListenerAdapter.cb_onAnimationRepeat_Landroid_animation_Animator_ == null)
			{
				AnimatorListenerAdapter.cb_onAnimationRepeat_Landroid_animation_Animator_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(AnimatorListenerAdapter.n_OnAnimationRepeat_Landroid_animation_Animator_));
			}
			return AnimatorListenerAdapter.cb_onAnimationRepeat_Landroid_animation_Animator_;
		}

		// Token: 0x0600157C RID: 5500 RVA: 0x00036F04 File Offset: 0x00035104
		private static void n_OnAnimationRepeat_Landroid_animation_Animator_(IntPtr jnienv, IntPtr native__this, IntPtr native_animation)
		{
			AnimatorListenerAdapter @object = Java.Lang.Object.GetObject<AnimatorListenerAdapter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Animator object2 = Java.Lang.Object.GetObject<Animator>(native_animation, JniHandleOwnership.DoNotTransfer);
			@object.OnAnimationRepeat(object2);
		}

		// Token: 0x0600157D RID: 5501 RVA: 0x00036F28 File Offset: 0x00035128
		public unsafe virtual void OnAnimationRepeat(Animator animation)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((animation == null) ? IntPtr.Zero : animation.Handle);
				AnimatorListenerAdapter._members.InstanceMethods.InvokeVirtualVoidMethod("onAnimationRepeat.(Landroid/animation/Animator;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(animation);
			}
		}

		// Token: 0x0600157E RID: 5502 RVA: 0x00036F8C File Offset: 0x0003518C
		private static Delegate GetOnAnimationResume_Landroid_animation_Animator_Handler()
		{
			if (AnimatorListenerAdapter.cb_onAnimationResume_Landroid_animation_Animator_ == null)
			{
				AnimatorListenerAdapter.cb_onAnimationResume_Landroid_animation_Animator_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(AnimatorListenerAdapter.n_OnAnimationResume_Landroid_animation_Animator_));
			}
			return AnimatorListenerAdapter.cb_onAnimationResume_Landroid_animation_Animator_;
		}

		// Token: 0x0600157F RID: 5503 RVA: 0x00036FB0 File Offset: 0x000351B0
		private static void n_OnAnimationResume_Landroid_animation_Animator_(IntPtr jnienv, IntPtr native__this, IntPtr native_animation)
		{
			AnimatorListenerAdapter @object = Java.Lang.Object.GetObject<AnimatorListenerAdapter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Animator object2 = Java.Lang.Object.GetObject<Animator>(native_animation, JniHandleOwnership.DoNotTransfer);
			@object.OnAnimationResume(object2);
		}

		// Token: 0x06001580 RID: 5504 RVA: 0x00036FD4 File Offset: 0x000351D4
		public unsafe virtual void OnAnimationResume(Animator animation)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((animation == null) ? IntPtr.Zero : animation.Handle);
				AnimatorListenerAdapter._members.InstanceMethods.InvokeVirtualVoidMethod("onAnimationResume.(Landroid/animation/Animator;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(animation);
			}
		}

		// Token: 0x06001581 RID: 5505 RVA: 0x00037038 File Offset: 0x00035238
		private static Delegate GetOnAnimationStart_Landroid_animation_Animator_Handler()
		{
			if (AnimatorListenerAdapter.cb_onAnimationStart_Landroid_animation_Animator_ == null)
			{
				AnimatorListenerAdapter.cb_onAnimationStart_Landroid_animation_Animator_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(AnimatorListenerAdapter.n_OnAnimationStart_Landroid_animation_Animator_));
			}
			return AnimatorListenerAdapter.cb_onAnimationStart_Landroid_animation_Animator_;
		}

		// Token: 0x06001582 RID: 5506 RVA: 0x0003705C File Offset: 0x0003525C
		private static void n_OnAnimationStart_Landroid_animation_Animator_(IntPtr jnienv, IntPtr native__this, IntPtr native_animation)
		{
			AnimatorListenerAdapter @object = Java.Lang.Object.GetObject<AnimatorListenerAdapter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Animator object2 = Java.Lang.Object.GetObject<Animator>(native_animation, JniHandleOwnership.DoNotTransfer);
			@object.OnAnimationStart(object2);
		}

		// Token: 0x06001583 RID: 5507 RVA: 0x00037080 File Offset: 0x00035280
		public unsafe virtual void OnAnimationStart(Animator animation)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((animation == null) ? IntPtr.Zero : animation.Handle);
				AnimatorListenerAdapter._members.InstanceMethods.InvokeVirtualVoidMethod("onAnimationStart.(Landroid/animation/Animator;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(animation);
			}
		}

		// Token: 0x0400095D RID: 2397
		private static readonly JniPeerMembers _members = new XAPeerMembers("android/animation/AnimatorListenerAdapter", typeof(AnimatorListenerAdapter));

		// Token: 0x0400095E RID: 2398
		private static Delegate cb_onAnimationCancel_Landroid_animation_Animator_;

		// Token: 0x0400095F RID: 2399
		private static Delegate cb_onAnimationEnd_Landroid_animation_Animator_;

		// Token: 0x04000960 RID: 2400
		private static Delegate cb_onAnimationPause_Landroid_animation_Animator_;

		// Token: 0x04000961 RID: 2401
		private static Delegate cb_onAnimationRepeat_Landroid_animation_Animator_;

		// Token: 0x04000962 RID: 2402
		private static Delegate cb_onAnimationResume_Landroid_animation_Animator_;

		// Token: 0x04000963 RID: 2403
		private static Delegate cb_onAnimationStart_Landroid_animation_Animator_;
	}
}
