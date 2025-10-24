using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Android.Views;
using Java.Interop;
using Java.Lang;

namespace AndroidX.Core.View
{
	// Token: 0x020000B6 RID: 182
	[Register("androidx/core/view/ViewPropertyAnimatorListener", DoNotGenerateAcw = true)]
	internal class IViewPropertyAnimatorListenerInvoker : Java.Lang.Object, IViewPropertyAnimatorListener, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x170001DB RID: 475
		// (get) Token: 0x06000A3F RID: 2623 RVA: 0x0001F8EC File Offset: 0x0001DAEC
		private static IntPtr java_class_ref
		{
			get
			{
				return IViewPropertyAnimatorListenerInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170001DC RID: 476
		// (get) Token: 0x06000A40 RID: 2624 RVA: 0x0001F910 File Offset: 0x0001DB10
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IViewPropertyAnimatorListenerInvoker._members;
			}
		}

		// Token: 0x170001DD RID: 477
		// (get) Token: 0x06000A41 RID: 2625 RVA: 0x0001F917 File Offset: 0x0001DB17
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x170001DE RID: 478
		// (get) Token: 0x06000A42 RID: 2626 RVA: 0x0001F91F File Offset: 0x0001DB1F
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IViewPropertyAnimatorListenerInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06000A43 RID: 2627 RVA: 0x0001F92B File Offset: 0x0001DB2B
		public static IViewPropertyAnimatorListener GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IViewPropertyAnimatorListener>(handle, transfer);
		}

		// Token: 0x06000A44 RID: 2628 RVA: 0x0001F934 File Offset: 0x0001DB34
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IViewPropertyAnimatorListenerInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'androidx.core.view.ViewPropertyAnimatorListener'.");
			}
			return handle;
		}

		// Token: 0x06000A45 RID: 2629 RVA: 0x0001F95F File Offset: 0x0001DB5F
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x06000A46 RID: 2630 RVA: 0x0001F990 File Offset: 0x0001DB90
		public IViewPropertyAnimatorListenerInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IViewPropertyAnimatorListenerInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x06000A47 RID: 2631 RVA: 0x0001F9C8 File Offset: 0x0001DBC8
		private static Delegate GetOnAnimationCancel_Landroid_view_View_Handler()
		{
			if (IViewPropertyAnimatorListenerInvoker.cb_onAnimationCancel_Landroid_view_View_ == null)
			{
				IViewPropertyAnimatorListenerInvoker.cb_onAnimationCancel_Landroid_view_View_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(IViewPropertyAnimatorListenerInvoker.n_OnAnimationCancel_Landroid_view_View_));
			}
			return IViewPropertyAnimatorListenerInvoker.cb_onAnimationCancel_Landroid_view_View_;
		}

		// Token: 0x06000A48 RID: 2632 RVA: 0x0001F9EC File Offset: 0x0001DBEC
		private static void n_OnAnimationCancel_Landroid_view_View_(IntPtr jnienv, IntPtr native__this, IntPtr native_view)
		{
			IViewPropertyAnimatorListener @object = Java.Lang.Object.GetObject<IViewPropertyAnimatorListener>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			View object2 = Java.Lang.Object.GetObject<View>(native_view, JniHandleOwnership.DoNotTransfer);
			@object.OnAnimationCancel(object2);
		}

		// Token: 0x06000A49 RID: 2633 RVA: 0x0001FA10 File Offset: 0x0001DC10
		public unsafe void OnAnimationCancel(View view)
		{
			if (this.id_onAnimationCancel_Landroid_view_View_ == IntPtr.Zero)
			{
				this.id_onAnimationCancel_Landroid_view_View_ = JNIEnv.GetMethodID(this.class_ref, "onAnimationCancel", "(Landroid/view/View;)V");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((view == null) ? IntPtr.Zero : view.Handle);
			JNIEnv.CallVoidMethod(base.Handle, this.id_onAnimationCancel_Landroid_view_View_, ptr);
		}

		// Token: 0x06000A4A RID: 2634 RVA: 0x0001FA83 File Offset: 0x0001DC83
		private static Delegate GetOnAnimationEnd_Landroid_view_View_Handler()
		{
			if (IViewPropertyAnimatorListenerInvoker.cb_onAnimationEnd_Landroid_view_View_ == null)
			{
				IViewPropertyAnimatorListenerInvoker.cb_onAnimationEnd_Landroid_view_View_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(IViewPropertyAnimatorListenerInvoker.n_OnAnimationEnd_Landroid_view_View_));
			}
			return IViewPropertyAnimatorListenerInvoker.cb_onAnimationEnd_Landroid_view_View_;
		}

		// Token: 0x06000A4B RID: 2635 RVA: 0x0001FAA8 File Offset: 0x0001DCA8
		private static void n_OnAnimationEnd_Landroid_view_View_(IntPtr jnienv, IntPtr native__this, IntPtr native_view)
		{
			IViewPropertyAnimatorListener @object = Java.Lang.Object.GetObject<IViewPropertyAnimatorListener>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			View object2 = Java.Lang.Object.GetObject<View>(native_view, JniHandleOwnership.DoNotTransfer);
			@object.OnAnimationEnd(object2);
		}

		// Token: 0x06000A4C RID: 2636 RVA: 0x0001FACC File Offset: 0x0001DCCC
		public unsafe void OnAnimationEnd(View view)
		{
			if (this.id_onAnimationEnd_Landroid_view_View_ == IntPtr.Zero)
			{
				this.id_onAnimationEnd_Landroid_view_View_ = JNIEnv.GetMethodID(this.class_ref, "onAnimationEnd", "(Landroid/view/View;)V");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((view == null) ? IntPtr.Zero : view.Handle);
			JNIEnv.CallVoidMethod(base.Handle, this.id_onAnimationEnd_Landroid_view_View_, ptr);
		}

		// Token: 0x06000A4D RID: 2637 RVA: 0x0001FB3F File Offset: 0x0001DD3F
		private static Delegate GetOnAnimationStart_Landroid_view_View_Handler()
		{
			if (IViewPropertyAnimatorListenerInvoker.cb_onAnimationStart_Landroid_view_View_ == null)
			{
				IViewPropertyAnimatorListenerInvoker.cb_onAnimationStart_Landroid_view_View_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(IViewPropertyAnimatorListenerInvoker.n_OnAnimationStart_Landroid_view_View_));
			}
			return IViewPropertyAnimatorListenerInvoker.cb_onAnimationStart_Landroid_view_View_;
		}

		// Token: 0x06000A4E RID: 2638 RVA: 0x0001FB64 File Offset: 0x0001DD64
		private static void n_OnAnimationStart_Landroid_view_View_(IntPtr jnienv, IntPtr native__this, IntPtr native_view)
		{
			IViewPropertyAnimatorListener @object = Java.Lang.Object.GetObject<IViewPropertyAnimatorListener>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			View object2 = Java.Lang.Object.GetObject<View>(native_view, JniHandleOwnership.DoNotTransfer);
			@object.OnAnimationStart(object2);
		}

		// Token: 0x06000A4F RID: 2639 RVA: 0x0001FB88 File Offset: 0x0001DD88
		public unsafe void OnAnimationStart(View view)
		{
			if (this.id_onAnimationStart_Landroid_view_View_ == IntPtr.Zero)
			{
				this.id_onAnimationStart_Landroid_view_View_ = JNIEnv.GetMethodID(this.class_ref, "onAnimationStart", "(Landroid/view/View;)V");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((view == null) ? IntPtr.Zero : view.Handle);
			JNIEnv.CallVoidMethod(base.Handle, this.id_onAnimationStart_Landroid_view_View_, ptr);
		}

		// Token: 0x04000317 RID: 791
		private static readonly JniPeerMembers _members = new XAPeerMembers("androidx/core/view/ViewPropertyAnimatorListener", typeof(IViewPropertyAnimatorListenerInvoker));

		// Token: 0x04000318 RID: 792
		private IntPtr class_ref;

		// Token: 0x04000319 RID: 793
		private static Delegate cb_onAnimationCancel_Landroid_view_View_;

		// Token: 0x0400031A RID: 794
		private IntPtr id_onAnimationCancel_Landroid_view_View_;

		// Token: 0x0400031B RID: 795
		private static Delegate cb_onAnimationEnd_Landroid_view_View_;

		// Token: 0x0400031C RID: 796
		private IntPtr id_onAnimationEnd_Landroid_view_View_;

		// Token: 0x0400031D RID: 797
		private static Delegate cb_onAnimationStart_Landroid_view_View_;

		// Token: 0x0400031E RID: 798
		private IntPtr id_onAnimationStart_Landroid_view_View_;
	}
}
