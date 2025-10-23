using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Android.Animation
{
	// Token: 0x02000255 RID: 597
	[Register("android/animation/ValueAnimator", DoNotGenerateAcw = true)]
	public class ValueAnimator : Animator
	{
		// Token: 0x170004C4 RID: 1220
		// (get) Token: 0x0600159F RID: 5535 RVA: 0x0003736F File Offset: 0x0003556F
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return ValueAnimator._members;
			}
		}

		// Token: 0x170004C5 RID: 1221
		// (get) Token: 0x060015A0 RID: 5536 RVA: 0x00037378 File Offset: 0x00035578
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return ValueAnimator._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170004C6 RID: 1222
		// (get) Token: 0x060015A1 RID: 5537 RVA: 0x0003739C File Offset: 0x0003559C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return ValueAnimator._members.ManagedPeerType;
			}
		}

		// Token: 0x060015A2 RID: 5538 RVA: 0x00036C6A File Offset: 0x00034E6A
		protected ValueAnimator(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x0400096B RID: 2411
		private static readonly JniPeerMembers _members = new XAPeerMembers("android/animation/ValueAnimator", typeof(ValueAnimator));

		// Token: 0x02000256 RID: 598
		[Register("android/animation/ValueAnimator$AnimatorUpdateListener", "", "Android.Animation.ValueAnimator/IAnimatorUpdateListenerInvoker")]
		public interface IAnimatorUpdateListener : IJavaObject, IDisposable, IJavaPeerable
		{
			// Token: 0x060015A4 RID: 5540
			[Register("onAnimationUpdate", "(Landroid/animation/ValueAnimator;)V", "GetOnAnimationUpdate_Landroid_animation_ValueAnimator_Handler:Android.Animation.ValueAnimator/IAnimatorUpdateListenerInvoker, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null")]
			void OnAnimationUpdate(ValueAnimator animation);
		}

		// Token: 0x02000257 RID: 599
		[Register("android/animation/ValueAnimator$AnimatorUpdateListener", DoNotGenerateAcw = true)]
		internal class IAnimatorUpdateListenerInvoker : Java.Lang.Object, ValueAnimator.IAnimatorUpdateListener, IJavaObject, IDisposable, IJavaPeerable
		{
			// Token: 0x170004C7 RID: 1223
			// (get) Token: 0x060015A5 RID: 5541 RVA: 0x000373C4 File Offset: 0x000355C4
			private static IntPtr java_class_ref
			{
				get
				{
					return ValueAnimator.IAnimatorUpdateListenerInvoker._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x170004C8 RID: 1224
			// (get) Token: 0x060015A6 RID: 5542 RVA: 0x000373E8 File Offset: 0x000355E8
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return ValueAnimator.IAnimatorUpdateListenerInvoker._members;
				}
			}

			// Token: 0x170004C9 RID: 1225
			// (get) Token: 0x060015A7 RID: 5543 RVA: 0x000373EF File Offset: 0x000355EF
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return this.class_ref;
				}
			}

			// Token: 0x170004CA RID: 1226
			// (get) Token: 0x060015A8 RID: 5544 RVA: 0x000373F7 File Offset: 0x000355F7
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return ValueAnimator.IAnimatorUpdateListenerInvoker._members.ManagedPeerType;
				}
			}

			// Token: 0x060015A9 RID: 5545 RVA: 0x00037403 File Offset: 0x00035603
			private static IntPtr Validate(IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf(handle, ValueAnimator.IAnimatorUpdateListenerInvoker.java_class_ref))
				{
					throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'android.animation.ValueAnimator.AnimatorUpdateListener'.");
				}
				return handle;
			}

			// Token: 0x060015AA RID: 5546 RVA: 0x0003742E File Offset: 0x0003562E
			protected override void Dispose(bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
				{
					JNIEnv.DeleteGlobalRef(this.class_ref);
				}
				this.class_ref = IntPtr.Zero;
				base.Dispose(disposing);
			}

			// Token: 0x060015AB RID: 5547 RVA: 0x00037460 File Offset: 0x00035660
			public IAnimatorUpdateListenerInvoker(IntPtr handle, JniHandleOwnership transfer) : base(ValueAnimator.IAnimatorUpdateListenerInvoker.Validate(handle), transfer)
			{
				IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
				this.class_ref = JNIEnv.NewGlobalRef(objectClass);
				JNIEnv.DeleteLocalRef(objectClass);
			}

			// Token: 0x060015AC RID: 5548 RVA: 0x00037498 File Offset: 0x00035698
			private static Delegate GetOnAnimationUpdate_Landroid_animation_ValueAnimator_Handler()
			{
				if (ValueAnimator.IAnimatorUpdateListenerInvoker.cb_onAnimationUpdate_Landroid_animation_ValueAnimator_ == null)
				{
					ValueAnimator.IAnimatorUpdateListenerInvoker.cb_onAnimationUpdate_Landroid_animation_ValueAnimator_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(ValueAnimator.IAnimatorUpdateListenerInvoker.n_OnAnimationUpdate_Landroid_animation_ValueAnimator_));
				}
				return ValueAnimator.IAnimatorUpdateListenerInvoker.cb_onAnimationUpdate_Landroid_animation_ValueAnimator_;
			}

			// Token: 0x060015AD RID: 5549 RVA: 0x000374BC File Offset: 0x000356BC
			private static void n_OnAnimationUpdate_Landroid_animation_ValueAnimator_(IntPtr jnienv, IntPtr native__this, IntPtr native_animation)
			{
				ValueAnimator.IAnimatorUpdateListener @object = Java.Lang.Object.GetObject<ValueAnimator.IAnimatorUpdateListener>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				ValueAnimator object2 = Java.Lang.Object.GetObject<ValueAnimator>(native_animation, JniHandleOwnership.DoNotTransfer);
				@object.OnAnimationUpdate(object2);
			}

			// Token: 0x060015AE RID: 5550 RVA: 0x000374E0 File Offset: 0x000356E0
			public unsafe void OnAnimationUpdate(ValueAnimator animation)
			{
				if (this.id_onAnimationUpdate_Landroid_animation_ValueAnimator_ == IntPtr.Zero)
				{
					this.id_onAnimationUpdate_Landroid_animation_ValueAnimator_ = JNIEnv.GetMethodID(this.class_ref, "onAnimationUpdate", "(Landroid/animation/ValueAnimator;)V");
				}
				JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
				*ptr = new JValue((animation == null) ? IntPtr.Zero : animation.Handle);
				JNIEnv.CallVoidMethod(base.Handle, this.id_onAnimationUpdate_Landroid_animation_ValueAnimator_, ptr);
			}

			// Token: 0x0400096C RID: 2412
			private static readonly JniPeerMembers _members = new XAPeerMembers("android/animation/ValueAnimator$AnimatorUpdateListener", typeof(ValueAnimator.IAnimatorUpdateListenerInvoker));

			// Token: 0x0400096D RID: 2413
			private IntPtr class_ref;

			// Token: 0x0400096E RID: 2414
			private static Delegate cb_onAnimationUpdate_Landroid_animation_ValueAnimator_;

			// Token: 0x0400096F RID: 2415
			private IntPtr id_onAnimationUpdate_Landroid_animation_ValueAnimator_;
		}
	}
}
