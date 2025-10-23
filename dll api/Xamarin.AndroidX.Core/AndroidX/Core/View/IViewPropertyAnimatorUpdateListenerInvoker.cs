using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Android.Views;
using Java.Interop;
using Java.Lang;

namespace AndroidX.Core.View
{
	// Token: 0x020000B8 RID: 184
	[Register("androidx/core/view/ViewPropertyAnimatorUpdateListener", DoNotGenerateAcw = true)]
	internal class IViewPropertyAnimatorUpdateListenerInvoker : Java.Lang.Object, IViewPropertyAnimatorUpdateListener, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x170001DF RID: 479
		// (get) Token: 0x06000A52 RID: 2642 RVA: 0x0001FC18 File Offset: 0x0001DE18
		private static IntPtr java_class_ref
		{
			get
			{
				return IViewPropertyAnimatorUpdateListenerInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170001E0 RID: 480
		// (get) Token: 0x06000A53 RID: 2643 RVA: 0x0001FC3C File Offset: 0x0001DE3C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IViewPropertyAnimatorUpdateListenerInvoker._members;
			}
		}

		// Token: 0x170001E1 RID: 481
		// (get) Token: 0x06000A54 RID: 2644 RVA: 0x0001FC43 File Offset: 0x0001DE43
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x170001E2 RID: 482
		// (get) Token: 0x06000A55 RID: 2645 RVA: 0x0001FC4B File Offset: 0x0001DE4B
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IViewPropertyAnimatorUpdateListenerInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06000A56 RID: 2646 RVA: 0x0001FC57 File Offset: 0x0001DE57
		public static IViewPropertyAnimatorUpdateListener GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IViewPropertyAnimatorUpdateListener>(handle, transfer);
		}

		// Token: 0x06000A57 RID: 2647 RVA: 0x0001FC60 File Offset: 0x0001DE60
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IViewPropertyAnimatorUpdateListenerInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'androidx.core.view.ViewPropertyAnimatorUpdateListener'.");
			}
			return handle;
		}

		// Token: 0x06000A58 RID: 2648 RVA: 0x0001FC8B File Offset: 0x0001DE8B
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x06000A59 RID: 2649 RVA: 0x0001FCBC File Offset: 0x0001DEBC
		public IViewPropertyAnimatorUpdateListenerInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IViewPropertyAnimatorUpdateListenerInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x06000A5A RID: 2650 RVA: 0x0001FCF4 File Offset: 0x0001DEF4
		private static Delegate GetOnAnimationUpdate_Landroid_view_View_Handler()
		{
			if (IViewPropertyAnimatorUpdateListenerInvoker.cb_onAnimationUpdate_Landroid_view_View_ == null)
			{
				IViewPropertyAnimatorUpdateListenerInvoker.cb_onAnimationUpdate_Landroid_view_View_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(IViewPropertyAnimatorUpdateListenerInvoker.n_OnAnimationUpdate_Landroid_view_View_));
			}
			return IViewPropertyAnimatorUpdateListenerInvoker.cb_onAnimationUpdate_Landroid_view_View_;
		}

		// Token: 0x06000A5B RID: 2651 RVA: 0x0001FD18 File Offset: 0x0001DF18
		private static void n_OnAnimationUpdate_Landroid_view_View_(IntPtr jnienv, IntPtr native__this, IntPtr native_view)
		{
			IViewPropertyAnimatorUpdateListener @object = Java.Lang.Object.GetObject<IViewPropertyAnimatorUpdateListener>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			View object2 = Java.Lang.Object.GetObject<View>(native_view, JniHandleOwnership.DoNotTransfer);
			@object.OnAnimationUpdate(object2);
		}

		// Token: 0x06000A5C RID: 2652 RVA: 0x0001FD3C File Offset: 0x0001DF3C
		public unsafe void OnAnimationUpdate(View view)
		{
			if (this.id_onAnimationUpdate_Landroid_view_View_ == IntPtr.Zero)
			{
				this.id_onAnimationUpdate_Landroid_view_View_ = JNIEnv.GetMethodID(this.class_ref, "onAnimationUpdate", "(Landroid/view/View;)V");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((view == null) ? IntPtr.Zero : view.Handle);
			JNIEnv.CallVoidMethod(base.Handle, this.id_onAnimationUpdate_Landroid_view_View_, ptr);
		}

		// Token: 0x0400031F RID: 799
		private static readonly JniPeerMembers _members = new XAPeerMembers("androidx/core/view/ViewPropertyAnimatorUpdateListener", typeof(IViewPropertyAnimatorUpdateListenerInvoker));

		// Token: 0x04000320 RID: 800
		private IntPtr class_ref;

		// Token: 0x04000321 RID: 801
		private static Delegate cb_onAnimationUpdate_Landroid_view_View_;

		// Token: 0x04000322 RID: 802
		private IntPtr id_onAnimationUpdate_Landroid_view_View_;
	}
}
