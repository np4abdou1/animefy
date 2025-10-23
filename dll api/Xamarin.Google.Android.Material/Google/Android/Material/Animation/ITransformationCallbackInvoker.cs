using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Google.Android.Material.Animation
{
	// Token: 0x0200009E RID: 158
	[Register("com/google/android/material/animation/TransformationCallback", DoNotGenerateAcw = true)]
	internal class ITransformationCallbackInvoker : Java.Lang.Object, ITransformationCallback, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x170001D7 RID: 471
		// (get) Token: 0x06000B59 RID: 2905 RVA: 0x0001E860 File Offset: 0x0001CA60
		private static IntPtr java_class_ref
		{
			get
			{
				return ITransformationCallbackInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170001D8 RID: 472
		// (get) Token: 0x06000B5A RID: 2906 RVA: 0x0001E884 File Offset: 0x0001CA84
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return ITransformationCallbackInvoker._members;
			}
		}

		// Token: 0x170001D9 RID: 473
		// (get) Token: 0x06000B5B RID: 2907 RVA: 0x0001E88B File Offset: 0x0001CA8B
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x170001DA RID: 474
		// (get) Token: 0x06000B5C RID: 2908 RVA: 0x0001E893 File Offset: 0x0001CA93
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return ITransformationCallbackInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06000B5D RID: 2909 RVA: 0x0001E89F File Offset: 0x0001CA9F
		public static ITransformationCallback GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<ITransformationCallback>(handle, transfer);
		}

		// Token: 0x06000B5E RID: 2910 RVA: 0x0001E8A8 File Offset: 0x0001CAA8
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, ITransformationCallbackInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'com.google.android.material.animation.TransformationCallback'.");
			}
			return handle;
		}

		// Token: 0x06000B5F RID: 2911 RVA: 0x0001E8D3 File Offset: 0x0001CAD3
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x06000B60 RID: 2912 RVA: 0x0001E904 File Offset: 0x0001CB04
		public ITransformationCallbackInvoker(IntPtr handle, JniHandleOwnership transfer) : base(ITransformationCallbackInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x06000B61 RID: 2913 RVA: 0x0001E93C File Offset: 0x0001CB3C
		private static Delegate GetOnScaleChanged_Landroid_view_View_Handler()
		{
			if (ITransformationCallbackInvoker.cb_onScaleChanged_Landroid_view_View_ == null)
			{
				ITransformationCallbackInvoker.cb_onScaleChanged_Landroid_view_View_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(ITransformationCallbackInvoker.n_OnScaleChanged_Landroid_view_View_));
			}
			return ITransformationCallbackInvoker.cb_onScaleChanged_Landroid_view_View_;
		}

		// Token: 0x06000B62 RID: 2914 RVA: 0x0001E960 File Offset: 0x0001CB60
		private static void n_OnScaleChanged_Landroid_view_View_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			ITransformationCallback @object = Java.Lang.Object.GetObject<ITransformationCallback>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_p0, JniHandleOwnership.DoNotTransfer);
			@object.OnScaleChanged(object2);
		}

		// Token: 0x06000B63 RID: 2915 RVA: 0x0001E984 File Offset: 0x0001CB84
		public unsafe void OnScaleChanged(Java.Lang.Object p0)
		{
			if (this.id_onScaleChanged_Landroid_view_View_ == IntPtr.Zero)
			{
				this.id_onScaleChanged_Landroid_view_View_ = JNIEnv.GetMethodID(this.class_ref, "onScaleChanged", "(Landroid/view/View;)V");
			}
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(p0);
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(intPtr);
			JNIEnv.CallVoidMethod(base.Handle, this.id_onScaleChanged_Landroid_view_View_, ptr);
			JNIEnv.DeleteLocalRef(intPtr);
		}

		// Token: 0x06000B64 RID: 2916 RVA: 0x0001E9F5 File Offset: 0x0001CBF5
		private static Delegate GetOnTranslationChanged_Landroid_view_View_Handler()
		{
			if (ITransformationCallbackInvoker.cb_onTranslationChanged_Landroid_view_View_ == null)
			{
				ITransformationCallbackInvoker.cb_onTranslationChanged_Landroid_view_View_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(ITransformationCallbackInvoker.n_OnTranslationChanged_Landroid_view_View_));
			}
			return ITransformationCallbackInvoker.cb_onTranslationChanged_Landroid_view_View_;
		}

		// Token: 0x06000B65 RID: 2917 RVA: 0x0001EA1C File Offset: 0x0001CC1C
		private static void n_OnTranslationChanged_Landroid_view_View_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			ITransformationCallback @object = Java.Lang.Object.GetObject<ITransformationCallback>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_p0, JniHandleOwnership.DoNotTransfer);
			@object.OnTranslationChanged(object2);
		}

		// Token: 0x06000B66 RID: 2918 RVA: 0x0001EA40 File Offset: 0x0001CC40
		public unsafe void OnTranslationChanged(Java.Lang.Object p0)
		{
			if (this.id_onTranslationChanged_Landroid_view_View_ == IntPtr.Zero)
			{
				this.id_onTranslationChanged_Landroid_view_View_ = JNIEnv.GetMethodID(this.class_ref, "onTranslationChanged", "(Landroid/view/View;)V");
			}
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(p0);
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(intPtr);
			JNIEnv.CallVoidMethod(base.Handle, this.id_onTranslationChanged_Landroid_view_View_, ptr);
			JNIEnv.DeleteLocalRef(intPtr);
		}

		// Token: 0x0400034C RID: 844
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/google/android/material/animation/TransformationCallback", typeof(ITransformationCallbackInvoker));

		// Token: 0x0400034D RID: 845
		private IntPtr class_ref;

		// Token: 0x0400034E RID: 846
		private static Delegate cb_onScaleChanged_Landroid_view_View_;

		// Token: 0x0400034F RID: 847
		private IntPtr id_onScaleChanged_Landroid_view_View_;

		// Token: 0x04000350 RID: 848
		private static Delegate cb_onTranslationChanged_Landroid_view_View_;

		// Token: 0x04000351 RID: 849
		private IntPtr id_onTranslationChanged_Landroid_view_View_;
	}
}
