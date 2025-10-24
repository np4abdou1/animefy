using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Android.Views
{
	// Token: 0x02000128 RID: 296
	[Register("android/view/ViewManager", DoNotGenerateAcw = true)]
	internal class IViewManagerInvoker : Java.Lang.Object, IViewManager, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x170001C2 RID: 450
		// (get) Token: 0x06000921 RID: 2337 RVA: 0x0001646C File Offset: 0x0001466C
		private static IntPtr java_class_ref
		{
			get
			{
				return IViewManagerInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170001C3 RID: 451
		// (get) Token: 0x06000922 RID: 2338 RVA: 0x00016490 File Offset: 0x00014690
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IViewManagerInvoker._members;
			}
		}

		// Token: 0x170001C4 RID: 452
		// (get) Token: 0x06000923 RID: 2339 RVA: 0x00016497 File Offset: 0x00014697
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x170001C5 RID: 453
		// (get) Token: 0x06000924 RID: 2340 RVA: 0x0001649F File Offset: 0x0001469F
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IViewManagerInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06000925 RID: 2341 RVA: 0x000164AB File Offset: 0x000146AB
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IViewManagerInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'android.view.ViewManager'.");
			}
			return handle;
		}

		// Token: 0x06000926 RID: 2342 RVA: 0x000164D6 File Offset: 0x000146D6
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x06000927 RID: 2343 RVA: 0x00016508 File Offset: 0x00014708
		public IViewManagerInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IViewManagerInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x06000928 RID: 2344 RVA: 0x00016540 File Offset: 0x00014740
		private static Delegate GetAddView_Landroid_view_View_Landroid_view_ViewGroup_LayoutParams_Handler()
		{
			if (IViewManagerInvoker.cb_addView_Landroid_view_View_Landroid_view_ViewGroup_LayoutParams_ == null)
			{
				IViewManagerInvoker.cb_addView_Landroid_view_View_Landroid_view_ViewGroup_LayoutParams_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_V(IViewManagerInvoker.n_AddView_Landroid_view_View_Landroid_view_ViewGroup_LayoutParams_));
			}
			return IViewManagerInvoker.cb_addView_Landroid_view_View_Landroid_view_ViewGroup_LayoutParams_;
		}

		// Token: 0x06000929 RID: 2345 RVA: 0x00016564 File Offset: 0x00014764
		private static void n_AddView_Landroid_view_View_Landroid_view_ViewGroup_LayoutParams_(IntPtr jnienv, IntPtr native__this, IntPtr native_view, IntPtr native__params)
		{
			IViewManager @object = Java.Lang.Object.GetObject<IViewManager>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			View object2 = Java.Lang.Object.GetObject<View>(native_view, JniHandleOwnership.DoNotTransfer);
			ViewGroup.LayoutParams object3 = Java.Lang.Object.GetObject<ViewGroup.LayoutParams>(native__params, JniHandleOwnership.DoNotTransfer);
			@object.AddView(object2, object3);
		}

		// Token: 0x0600092A RID: 2346 RVA: 0x00016590 File Offset: 0x00014790
		public unsafe void AddView(View view, ViewGroup.LayoutParams @params)
		{
			if (this.id_addView_Landroid_view_View_Landroid_view_ViewGroup_LayoutParams_ == IntPtr.Zero)
			{
				this.id_addView_Landroid_view_View_Landroid_view_ViewGroup_LayoutParams_ = JNIEnv.GetMethodID(this.class_ref, "addView", "(Landroid/view/View;Landroid/view/ViewGroup$LayoutParams;)V");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((view == null) ? IntPtr.Zero : view.Handle);
			ptr[1] = new JValue((@params == null) ? IntPtr.Zero : @params.Handle);
			JNIEnv.CallVoidMethod(base.Handle, this.id_addView_Landroid_view_View_Landroid_view_ViewGroup_LayoutParams_, ptr);
		}

		// Token: 0x0600092B RID: 2347 RVA: 0x00016625 File Offset: 0x00014825
		private static Delegate GetRemoveView_Landroid_view_View_Handler()
		{
			if (IViewManagerInvoker.cb_removeView_Landroid_view_View_ == null)
			{
				IViewManagerInvoker.cb_removeView_Landroid_view_View_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(IViewManagerInvoker.n_RemoveView_Landroid_view_View_));
			}
			return IViewManagerInvoker.cb_removeView_Landroid_view_View_;
		}

		// Token: 0x0600092C RID: 2348 RVA: 0x0001664C File Offset: 0x0001484C
		private static void n_RemoveView_Landroid_view_View_(IntPtr jnienv, IntPtr native__this, IntPtr native_view)
		{
			IViewManager @object = Java.Lang.Object.GetObject<IViewManager>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			View object2 = Java.Lang.Object.GetObject<View>(native_view, JniHandleOwnership.DoNotTransfer);
			@object.RemoveView(object2);
		}

		// Token: 0x0600092D RID: 2349 RVA: 0x00016670 File Offset: 0x00014870
		public unsafe void RemoveView(View view)
		{
			if (this.id_removeView_Landroid_view_View_ == IntPtr.Zero)
			{
				this.id_removeView_Landroid_view_View_ = JNIEnv.GetMethodID(this.class_ref, "removeView", "(Landroid/view/View;)V");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((view == null) ? IntPtr.Zero : view.Handle);
			JNIEnv.CallVoidMethod(base.Handle, this.id_removeView_Landroid_view_View_, ptr);
		}

		// Token: 0x0600092E RID: 2350 RVA: 0x000166E3 File Offset: 0x000148E3
		private static Delegate GetUpdateViewLayout_Landroid_view_View_Landroid_view_ViewGroup_LayoutParams_Handler()
		{
			if (IViewManagerInvoker.cb_updateViewLayout_Landroid_view_View_Landroid_view_ViewGroup_LayoutParams_ == null)
			{
				IViewManagerInvoker.cb_updateViewLayout_Landroid_view_View_Landroid_view_ViewGroup_LayoutParams_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_V(IViewManagerInvoker.n_UpdateViewLayout_Landroid_view_View_Landroid_view_ViewGroup_LayoutParams_));
			}
			return IViewManagerInvoker.cb_updateViewLayout_Landroid_view_View_Landroid_view_ViewGroup_LayoutParams_;
		}

		// Token: 0x0600092F RID: 2351 RVA: 0x00016708 File Offset: 0x00014908
		private static void n_UpdateViewLayout_Landroid_view_View_Landroid_view_ViewGroup_LayoutParams_(IntPtr jnienv, IntPtr native__this, IntPtr native_view, IntPtr native__params)
		{
			IViewManager @object = Java.Lang.Object.GetObject<IViewManager>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			View object2 = Java.Lang.Object.GetObject<View>(native_view, JniHandleOwnership.DoNotTransfer);
			ViewGroup.LayoutParams object3 = Java.Lang.Object.GetObject<ViewGroup.LayoutParams>(native__params, JniHandleOwnership.DoNotTransfer);
			@object.UpdateViewLayout(object2, object3);
		}

		// Token: 0x06000930 RID: 2352 RVA: 0x00016734 File Offset: 0x00014934
		public unsafe void UpdateViewLayout(View view, ViewGroup.LayoutParams @params)
		{
			if (this.id_updateViewLayout_Landroid_view_View_Landroid_view_ViewGroup_LayoutParams_ == IntPtr.Zero)
			{
				this.id_updateViewLayout_Landroid_view_View_Landroid_view_ViewGroup_LayoutParams_ = JNIEnv.GetMethodID(this.class_ref, "updateViewLayout", "(Landroid/view/View;Landroid/view/ViewGroup$LayoutParams;)V");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((view == null) ? IntPtr.Zero : view.Handle);
			ptr[1] = new JValue((@params == null) ? IntPtr.Zero : @params.Handle);
			JNIEnv.CallVoidMethod(base.Handle, this.id_updateViewLayout_Landroid_view_View_Landroid_view_ViewGroup_LayoutParams_, ptr);
		}

		// Token: 0x040002D4 RID: 724
		private static readonly JniPeerMembers _members = new XAPeerMembers("android/view/ViewManager", typeof(IViewManagerInvoker));

		// Token: 0x040002D5 RID: 725
		private IntPtr class_ref;

		// Token: 0x040002D6 RID: 726
		private static Delegate cb_addView_Landroid_view_View_Landroid_view_ViewGroup_LayoutParams_;

		// Token: 0x040002D7 RID: 727
		private IntPtr id_addView_Landroid_view_View_Landroid_view_ViewGroup_LayoutParams_;

		// Token: 0x040002D8 RID: 728
		private static Delegate cb_removeView_Landroid_view_View_;

		// Token: 0x040002D9 RID: 729
		private IntPtr id_removeView_Landroid_view_View_;

		// Token: 0x040002DA RID: 730
		private static Delegate cb_updateViewLayout_Landroid_view_View_Landroid_view_ViewGroup_LayoutParams_;

		// Token: 0x040002DB RID: 731
		private IntPtr id_updateViewLayout_Landroid_view_View_Landroid_view_ViewGroup_LayoutParams_;
	}
}
