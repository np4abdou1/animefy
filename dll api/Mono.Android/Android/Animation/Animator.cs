using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Android.Animation
{
	// Token: 0x02000249 RID: 585
	[Register("android/animation/Animator", DoNotGenerateAcw = true)]
	public abstract class Animator : Java.Lang.Object, Java.Lang.ICloneable, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x170004A8 RID: 1192
		// (get) Token: 0x0600153D RID: 5437 RVA: 0x000365CF File Offset: 0x000347CF
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return Animator._members;
			}
		}

		// Token: 0x170004A9 RID: 1193
		// (get) Token: 0x0600153E RID: 5438 RVA: 0x000365D8 File Offset: 0x000347D8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return Animator._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170004AA RID: 1194
		// (get) Token: 0x0600153F RID: 5439 RVA: 0x000365FC File Offset: 0x000347FC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return Animator._members.ManagedPeerType;
			}
		}

		// Token: 0x06001540 RID: 5440 RVA: 0x000021E0 File Offset: 0x000003E0
		protected Animator(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x0400094B RID: 2379
		private static readonly JniPeerMembers _members = new XAPeerMembers("android/animation/Animator", typeof(Animator));

		// Token: 0x0200024A RID: 586
		[Register("android/animation/Animator$AnimatorListener", "", "Android.Animation.Animator/IAnimatorListenerInvoker")]
		public interface IAnimatorListener : IJavaObject, IDisposable, IJavaPeerable
		{
			// Token: 0x06001542 RID: 5442
			[Register("onAnimationCancel", "(Landroid/animation/Animator;)V", "GetOnAnimationCancel_Landroid_animation_Animator_Handler:Android.Animation.Animator/IAnimatorListenerInvoker, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null")]
			void OnAnimationCancel(Animator animation);

			// Token: 0x06001543 RID: 5443
			[Register("onAnimationEnd", "(Landroid/animation/Animator;)V", "GetOnAnimationEnd_Landroid_animation_Animator_Handler:Android.Animation.Animator/IAnimatorListenerInvoker, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null")]
			void OnAnimationEnd(Animator animation);

			// Token: 0x06001544 RID: 5444
			[Register("onAnimationRepeat", "(Landroid/animation/Animator;)V", "GetOnAnimationRepeat_Landroid_animation_Animator_Handler:Android.Animation.Animator/IAnimatorListenerInvoker, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null")]
			void OnAnimationRepeat(Animator animation);

			// Token: 0x06001545 RID: 5445
			[Register("onAnimationStart", "(Landroid/animation/Animator;)V", "GetOnAnimationStart_Landroid_animation_Animator_Handler:Android.Animation.Animator/IAnimatorListenerInvoker, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null")]
			void OnAnimationStart(Animator animation);
		}

		// Token: 0x0200024B RID: 587
		[Register("android/animation/Animator$AnimatorListener", DoNotGenerateAcw = true)]
		internal class IAnimatorListenerInvoker : Java.Lang.Object, Animator.IAnimatorListener, IJavaObject, IDisposable, IJavaPeerable
		{
			// Token: 0x170004AB RID: 1195
			// (get) Token: 0x06001546 RID: 5446 RVA: 0x00036624 File Offset: 0x00034824
			private static IntPtr java_class_ref
			{
				get
				{
					return Animator.IAnimatorListenerInvoker._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x170004AC RID: 1196
			// (get) Token: 0x06001547 RID: 5447 RVA: 0x00036648 File Offset: 0x00034848
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return Animator.IAnimatorListenerInvoker._members;
				}
			}

			// Token: 0x170004AD RID: 1197
			// (get) Token: 0x06001548 RID: 5448 RVA: 0x0003664F File Offset: 0x0003484F
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return this.class_ref;
				}
			}

			// Token: 0x170004AE RID: 1198
			// (get) Token: 0x06001549 RID: 5449 RVA: 0x00036657 File Offset: 0x00034857
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return Animator.IAnimatorListenerInvoker._members.ManagedPeerType;
				}
			}

			// Token: 0x0600154A RID: 5450 RVA: 0x00036663 File Offset: 0x00034863
			private static IntPtr Validate(IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf(handle, Animator.IAnimatorListenerInvoker.java_class_ref))
				{
					throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'android.animation.Animator.AnimatorListener'.");
				}
				return handle;
			}

			// Token: 0x0600154B RID: 5451 RVA: 0x0003668E File Offset: 0x0003488E
			protected override void Dispose(bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
				{
					JNIEnv.DeleteGlobalRef(this.class_ref);
				}
				this.class_ref = IntPtr.Zero;
				base.Dispose(disposing);
			}

			// Token: 0x0600154C RID: 5452 RVA: 0x000366C0 File Offset: 0x000348C0
			public IAnimatorListenerInvoker(IntPtr handle, JniHandleOwnership transfer) : base(Animator.IAnimatorListenerInvoker.Validate(handle), transfer)
			{
				IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
				this.class_ref = JNIEnv.NewGlobalRef(objectClass);
				JNIEnv.DeleteLocalRef(objectClass);
			}

			// Token: 0x0600154D RID: 5453 RVA: 0x000366F8 File Offset: 0x000348F8
			private static Delegate GetOnAnimationCancel_Landroid_animation_Animator_Handler()
			{
				if (Animator.IAnimatorListenerInvoker.cb_onAnimationCancel_Landroid_animation_Animator_ == null)
				{
					Animator.IAnimatorListenerInvoker.cb_onAnimationCancel_Landroid_animation_Animator_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(Animator.IAnimatorListenerInvoker.n_OnAnimationCancel_Landroid_animation_Animator_));
				}
				return Animator.IAnimatorListenerInvoker.cb_onAnimationCancel_Landroid_animation_Animator_;
			}

			// Token: 0x0600154E RID: 5454 RVA: 0x0003671C File Offset: 0x0003491C
			private static void n_OnAnimationCancel_Landroid_animation_Animator_(IntPtr jnienv, IntPtr native__this, IntPtr native_animation)
			{
				Animator.IAnimatorListener @object = Java.Lang.Object.GetObject<Animator.IAnimatorListener>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				Animator object2 = Java.Lang.Object.GetObject<Animator>(native_animation, JniHandleOwnership.DoNotTransfer);
				@object.OnAnimationCancel(object2);
			}

			// Token: 0x0600154F RID: 5455 RVA: 0x00036740 File Offset: 0x00034940
			public unsafe void OnAnimationCancel(Animator animation)
			{
				if (this.id_onAnimationCancel_Landroid_animation_Animator_ == IntPtr.Zero)
				{
					this.id_onAnimationCancel_Landroid_animation_Animator_ = JNIEnv.GetMethodID(this.class_ref, "onAnimationCancel", "(Landroid/animation/Animator;)V");
				}
				JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
				*ptr = new JValue((animation == null) ? IntPtr.Zero : animation.Handle);
				JNIEnv.CallVoidMethod(base.Handle, this.id_onAnimationCancel_Landroid_animation_Animator_, ptr);
			}

			// Token: 0x06001550 RID: 5456 RVA: 0x000367B3 File Offset: 0x000349B3
			private static Delegate GetOnAnimationEnd_Landroid_animation_Animator_Handler()
			{
				if (Animator.IAnimatorListenerInvoker.cb_onAnimationEnd_Landroid_animation_Animator_ == null)
				{
					Animator.IAnimatorListenerInvoker.cb_onAnimationEnd_Landroid_animation_Animator_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(Animator.IAnimatorListenerInvoker.n_OnAnimationEnd_Landroid_animation_Animator_));
				}
				return Animator.IAnimatorListenerInvoker.cb_onAnimationEnd_Landroid_animation_Animator_;
			}

			// Token: 0x06001551 RID: 5457 RVA: 0x000367D8 File Offset: 0x000349D8
			private static void n_OnAnimationEnd_Landroid_animation_Animator_(IntPtr jnienv, IntPtr native__this, IntPtr native_animation)
			{
				Animator.IAnimatorListener @object = Java.Lang.Object.GetObject<Animator.IAnimatorListener>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				Animator object2 = Java.Lang.Object.GetObject<Animator>(native_animation, JniHandleOwnership.DoNotTransfer);
				@object.OnAnimationEnd(object2);
			}

			// Token: 0x06001552 RID: 5458 RVA: 0x000367FC File Offset: 0x000349FC
			public unsafe void OnAnimationEnd(Animator animation)
			{
				if (this.id_onAnimationEnd_Landroid_animation_Animator_ == IntPtr.Zero)
				{
					this.id_onAnimationEnd_Landroid_animation_Animator_ = JNIEnv.GetMethodID(this.class_ref, "onAnimationEnd", "(Landroid/animation/Animator;)V");
				}
				JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
				*ptr = new JValue((animation == null) ? IntPtr.Zero : animation.Handle);
				JNIEnv.CallVoidMethod(base.Handle, this.id_onAnimationEnd_Landroid_animation_Animator_, ptr);
			}

			// Token: 0x06001553 RID: 5459 RVA: 0x0003686F File Offset: 0x00034A6F
			private static Delegate GetOnAnimationRepeat_Landroid_animation_Animator_Handler()
			{
				if (Animator.IAnimatorListenerInvoker.cb_onAnimationRepeat_Landroid_animation_Animator_ == null)
				{
					Animator.IAnimatorListenerInvoker.cb_onAnimationRepeat_Landroid_animation_Animator_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(Animator.IAnimatorListenerInvoker.n_OnAnimationRepeat_Landroid_animation_Animator_));
				}
				return Animator.IAnimatorListenerInvoker.cb_onAnimationRepeat_Landroid_animation_Animator_;
			}

			// Token: 0x06001554 RID: 5460 RVA: 0x00036894 File Offset: 0x00034A94
			private static void n_OnAnimationRepeat_Landroid_animation_Animator_(IntPtr jnienv, IntPtr native__this, IntPtr native_animation)
			{
				Animator.IAnimatorListener @object = Java.Lang.Object.GetObject<Animator.IAnimatorListener>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				Animator object2 = Java.Lang.Object.GetObject<Animator>(native_animation, JniHandleOwnership.DoNotTransfer);
				@object.OnAnimationRepeat(object2);
			}

			// Token: 0x06001555 RID: 5461 RVA: 0x000368B8 File Offset: 0x00034AB8
			public unsafe void OnAnimationRepeat(Animator animation)
			{
				if (this.id_onAnimationRepeat_Landroid_animation_Animator_ == IntPtr.Zero)
				{
					this.id_onAnimationRepeat_Landroid_animation_Animator_ = JNIEnv.GetMethodID(this.class_ref, "onAnimationRepeat", "(Landroid/animation/Animator;)V");
				}
				JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
				*ptr = new JValue((animation == null) ? IntPtr.Zero : animation.Handle);
				JNIEnv.CallVoidMethod(base.Handle, this.id_onAnimationRepeat_Landroid_animation_Animator_, ptr);
			}

			// Token: 0x06001556 RID: 5462 RVA: 0x0003692B File Offset: 0x00034B2B
			private static Delegate GetOnAnimationStart_Landroid_animation_Animator_Handler()
			{
				if (Animator.IAnimatorListenerInvoker.cb_onAnimationStart_Landroid_animation_Animator_ == null)
				{
					Animator.IAnimatorListenerInvoker.cb_onAnimationStart_Landroid_animation_Animator_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(Animator.IAnimatorListenerInvoker.n_OnAnimationStart_Landroid_animation_Animator_));
				}
				return Animator.IAnimatorListenerInvoker.cb_onAnimationStart_Landroid_animation_Animator_;
			}

			// Token: 0x06001557 RID: 5463 RVA: 0x00036950 File Offset: 0x00034B50
			private static void n_OnAnimationStart_Landroid_animation_Animator_(IntPtr jnienv, IntPtr native__this, IntPtr native_animation)
			{
				Animator.IAnimatorListener @object = Java.Lang.Object.GetObject<Animator.IAnimatorListener>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				Animator object2 = Java.Lang.Object.GetObject<Animator>(native_animation, JniHandleOwnership.DoNotTransfer);
				@object.OnAnimationStart(object2);
			}

			// Token: 0x06001558 RID: 5464 RVA: 0x00036974 File Offset: 0x00034B74
			public unsafe void OnAnimationStart(Animator animation)
			{
				if (this.id_onAnimationStart_Landroid_animation_Animator_ == IntPtr.Zero)
				{
					this.id_onAnimationStart_Landroid_animation_Animator_ = JNIEnv.GetMethodID(this.class_ref, "onAnimationStart", "(Landroid/animation/Animator;)V");
				}
				JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
				*ptr = new JValue((animation == null) ? IntPtr.Zero : animation.Handle);
				JNIEnv.CallVoidMethod(base.Handle, this.id_onAnimationStart_Landroid_animation_Animator_, ptr);
			}

			// Token: 0x0400094C RID: 2380
			private static readonly JniPeerMembers _members = new XAPeerMembers("android/animation/Animator$AnimatorListener", typeof(Animator.IAnimatorListenerInvoker));

			// Token: 0x0400094D RID: 2381
			private IntPtr class_ref;

			// Token: 0x0400094E RID: 2382
			private static Delegate cb_onAnimationCancel_Landroid_animation_Animator_;

			// Token: 0x0400094F RID: 2383
			private IntPtr id_onAnimationCancel_Landroid_animation_Animator_;

			// Token: 0x04000950 RID: 2384
			private static Delegate cb_onAnimationEnd_Landroid_animation_Animator_;

			// Token: 0x04000951 RID: 2385
			private IntPtr id_onAnimationEnd_Landroid_animation_Animator_;

			// Token: 0x04000952 RID: 2386
			private static Delegate cb_onAnimationRepeat_Landroid_animation_Animator_;

			// Token: 0x04000953 RID: 2387
			private IntPtr id_onAnimationRepeat_Landroid_animation_Animator_;

			// Token: 0x04000954 RID: 2388
			private static Delegate cb_onAnimationStart_Landroid_animation_Animator_;

			// Token: 0x04000955 RID: 2389
			private IntPtr id_onAnimationStart_Landroid_animation_Animator_;
		}

		// Token: 0x0200024C RID: 588
		[Register("android/animation/Animator$AnimatorPauseListener", "", "Android.Animation.Animator/IAnimatorPauseListenerInvoker")]
		public interface IAnimatorPauseListener : IJavaObject, IDisposable, IJavaPeerable
		{
			// Token: 0x0600155A RID: 5466
			[Register("onAnimationPause", "(Landroid/animation/Animator;)V", "GetOnAnimationPause_Landroid_animation_Animator_Handler:Android.Animation.Animator/IAnimatorPauseListenerInvoker, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null")]
			void OnAnimationPause(Animator animation);

			// Token: 0x0600155B RID: 5467
			[Register("onAnimationResume", "(Landroid/animation/Animator;)V", "GetOnAnimationResume_Landroid_animation_Animator_Handler:Android.Animation.Animator/IAnimatorPauseListenerInvoker, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null")]
			void OnAnimationResume(Animator animation);
		}

		// Token: 0x0200024D RID: 589
		[Register("android/animation/Animator$AnimatorPauseListener", DoNotGenerateAcw = true)]
		internal class IAnimatorPauseListenerInvoker : Java.Lang.Object, Animator.IAnimatorPauseListener, IJavaObject, IDisposable, IJavaPeerable
		{
			// Token: 0x170004AF RID: 1199
			// (get) Token: 0x0600155C RID: 5468 RVA: 0x00036A04 File Offset: 0x00034C04
			private static IntPtr java_class_ref
			{
				get
				{
					return Animator.IAnimatorPauseListenerInvoker._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x170004B0 RID: 1200
			// (get) Token: 0x0600155D RID: 5469 RVA: 0x00036A28 File Offset: 0x00034C28
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return Animator.IAnimatorPauseListenerInvoker._members;
				}
			}

			// Token: 0x170004B1 RID: 1201
			// (get) Token: 0x0600155E RID: 5470 RVA: 0x00036A2F File Offset: 0x00034C2F
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return this.class_ref;
				}
			}

			// Token: 0x170004B2 RID: 1202
			// (get) Token: 0x0600155F RID: 5471 RVA: 0x00036A37 File Offset: 0x00034C37
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return Animator.IAnimatorPauseListenerInvoker._members.ManagedPeerType;
				}
			}

			// Token: 0x06001560 RID: 5472 RVA: 0x00036A43 File Offset: 0x00034C43
			private static IntPtr Validate(IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf(handle, Animator.IAnimatorPauseListenerInvoker.java_class_ref))
				{
					throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'android.animation.Animator.AnimatorPauseListener'.");
				}
				return handle;
			}

			// Token: 0x06001561 RID: 5473 RVA: 0x00036A6E File Offset: 0x00034C6E
			protected override void Dispose(bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
				{
					JNIEnv.DeleteGlobalRef(this.class_ref);
				}
				this.class_ref = IntPtr.Zero;
				base.Dispose(disposing);
			}

			// Token: 0x06001562 RID: 5474 RVA: 0x00036AA0 File Offset: 0x00034CA0
			public IAnimatorPauseListenerInvoker(IntPtr handle, JniHandleOwnership transfer) : base(Animator.IAnimatorPauseListenerInvoker.Validate(handle), transfer)
			{
				IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
				this.class_ref = JNIEnv.NewGlobalRef(objectClass);
				JNIEnv.DeleteLocalRef(objectClass);
			}

			// Token: 0x06001563 RID: 5475 RVA: 0x00036AD8 File Offset: 0x00034CD8
			private static Delegate GetOnAnimationPause_Landroid_animation_Animator_Handler()
			{
				if (Animator.IAnimatorPauseListenerInvoker.cb_onAnimationPause_Landroid_animation_Animator_ == null)
				{
					Animator.IAnimatorPauseListenerInvoker.cb_onAnimationPause_Landroid_animation_Animator_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(Animator.IAnimatorPauseListenerInvoker.n_OnAnimationPause_Landroid_animation_Animator_));
				}
				return Animator.IAnimatorPauseListenerInvoker.cb_onAnimationPause_Landroid_animation_Animator_;
			}

			// Token: 0x06001564 RID: 5476 RVA: 0x00036AFC File Offset: 0x00034CFC
			private static void n_OnAnimationPause_Landroid_animation_Animator_(IntPtr jnienv, IntPtr native__this, IntPtr native_animation)
			{
				Animator.IAnimatorPauseListener @object = Java.Lang.Object.GetObject<Animator.IAnimatorPauseListener>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				Animator object2 = Java.Lang.Object.GetObject<Animator>(native_animation, JniHandleOwnership.DoNotTransfer);
				@object.OnAnimationPause(object2);
			}

			// Token: 0x06001565 RID: 5477 RVA: 0x00036B20 File Offset: 0x00034D20
			public unsafe void OnAnimationPause(Animator animation)
			{
				if (this.id_onAnimationPause_Landroid_animation_Animator_ == IntPtr.Zero)
				{
					this.id_onAnimationPause_Landroid_animation_Animator_ = JNIEnv.GetMethodID(this.class_ref, "onAnimationPause", "(Landroid/animation/Animator;)V");
				}
				JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
				*ptr = new JValue((animation == null) ? IntPtr.Zero : animation.Handle);
				JNIEnv.CallVoidMethod(base.Handle, this.id_onAnimationPause_Landroid_animation_Animator_, ptr);
			}

			// Token: 0x06001566 RID: 5478 RVA: 0x00036B93 File Offset: 0x00034D93
			private static Delegate GetOnAnimationResume_Landroid_animation_Animator_Handler()
			{
				if (Animator.IAnimatorPauseListenerInvoker.cb_onAnimationResume_Landroid_animation_Animator_ == null)
				{
					Animator.IAnimatorPauseListenerInvoker.cb_onAnimationResume_Landroid_animation_Animator_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(Animator.IAnimatorPauseListenerInvoker.n_OnAnimationResume_Landroid_animation_Animator_));
				}
				return Animator.IAnimatorPauseListenerInvoker.cb_onAnimationResume_Landroid_animation_Animator_;
			}

			// Token: 0x06001567 RID: 5479 RVA: 0x00036BB8 File Offset: 0x00034DB8
			private static void n_OnAnimationResume_Landroid_animation_Animator_(IntPtr jnienv, IntPtr native__this, IntPtr native_animation)
			{
				Animator.IAnimatorPauseListener @object = Java.Lang.Object.GetObject<Animator.IAnimatorPauseListener>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				Animator object2 = Java.Lang.Object.GetObject<Animator>(native_animation, JniHandleOwnership.DoNotTransfer);
				@object.OnAnimationResume(object2);
			}

			// Token: 0x06001568 RID: 5480 RVA: 0x00036BDC File Offset: 0x00034DDC
			public unsafe void OnAnimationResume(Animator animation)
			{
				if (this.id_onAnimationResume_Landroid_animation_Animator_ == IntPtr.Zero)
				{
					this.id_onAnimationResume_Landroid_animation_Animator_ = JNIEnv.GetMethodID(this.class_ref, "onAnimationResume", "(Landroid/animation/Animator;)V");
				}
				JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
				*ptr = new JValue((animation == null) ? IntPtr.Zero : animation.Handle);
				JNIEnv.CallVoidMethod(base.Handle, this.id_onAnimationResume_Landroid_animation_Animator_, ptr);
			}

			// Token: 0x04000956 RID: 2390
			private static readonly JniPeerMembers _members = new XAPeerMembers("android/animation/Animator$AnimatorPauseListener", typeof(Animator.IAnimatorPauseListenerInvoker));

			// Token: 0x04000957 RID: 2391
			private IntPtr class_ref;

			// Token: 0x04000958 RID: 2392
			private static Delegate cb_onAnimationPause_Landroid_animation_Animator_;

			// Token: 0x04000959 RID: 2393
			private IntPtr id_onAnimationPause_Landroid_animation_Animator_;

			// Token: 0x0400095A RID: 2394
			private static Delegate cb_onAnimationResume_Landroid_animation_Animator_;

			// Token: 0x0400095B RID: 2395
			private IntPtr id_onAnimationResume_Landroid_animation_Animator_;
		}
	}
}
