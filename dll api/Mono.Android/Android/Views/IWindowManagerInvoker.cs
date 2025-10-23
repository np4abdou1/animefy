using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Android.Views
{
	// Token: 0x0200012D RID: 301
	[Register("android/view/WindowManager", DoNotGenerateAcw = true)]
	internal class IWindowManagerInvoker : Java.Lang.Object, IWindowManager, IViewManager, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x170001E4 RID: 484
		// (get) Token: 0x06000A12 RID: 2578 RVA: 0x00019120 File Offset: 0x00017320
		private static IntPtr java_class_ref
		{
			get
			{
				return IWindowManagerInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170001E5 RID: 485
		// (get) Token: 0x06000A13 RID: 2579 RVA: 0x00019144 File Offset: 0x00017344
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IWindowManagerInvoker._members;
			}
		}

		// Token: 0x170001E6 RID: 486
		// (get) Token: 0x06000A14 RID: 2580 RVA: 0x0001914B File Offset: 0x0001734B
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x170001E7 RID: 487
		// (get) Token: 0x06000A15 RID: 2581 RVA: 0x00019153 File Offset: 0x00017353
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IWindowManagerInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06000A16 RID: 2582 RVA: 0x0001915F File Offset: 0x0001735F
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IWindowManagerInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'android.view.WindowManager'.");
			}
			return handle;
		}

		// Token: 0x06000A17 RID: 2583 RVA: 0x0001918A File Offset: 0x0001738A
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x06000A18 RID: 2584 RVA: 0x000191BC File Offset: 0x000173BC
		public IWindowManagerInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IWindowManagerInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x06000A19 RID: 2585 RVA: 0x000191F4 File Offset: 0x000173F4
		private static Delegate GetGetDefaultDisplayHandler()
		{
			if (IWindowManagerInvoker.cb_getDefaultDisplay == null)
			{
				IWindowManagerInvoker.cb_getDefaultDisplay = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IWindowManagerInvoker.n_GetDefaultDisplay));
			}
			return IWindowManagerInvoker.cb_getDefaultDisplay;
		}

		// Token: 0x06000A1A RID: 2586 RVA: 0x00019218 File Offset: 0x00017418
		private static IntPtr n_GetDefaultDisplay(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IWindowManager>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).DefaultDisplay);
		}

		// Token: 0x170001E8 RID: 488
		// (get) Token: 0x06000A1B RID: 2587 RVA: 0x0001922C File Offset: 0x0001742C
		public Display DefaultDisplay
		{
			get
			{
				if (this.id_getDefaultDisplay == IntPtr.Zero)
				{
					this.id_getDefaultDisplay = JNIEnv.GetMethodID(this.class_ref, "getDefaultDisplay", "()Landroid/view/Display;");
				}
				return Java.Lang.Object.GetObject<Display>(JNIEnv.CallObjectMethod(base.Handle, this.id_getDefaultDisplay), JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06000A1C RID: 2588 RVA: 0x0001927D File Offset: 0x0001747D
		private static Delegate GetRemoveViewImmediate_Landroid_view_View_Handler()
		{
			if (IWindowManagerInvoker.cb_removeViewImmediate_Landroid_view_View_ == null)
			{
				IWindowManagerInvoker.cb_removeViewImmediate_Landroid_view_View_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(IWindowManagerInvoker.n_RemoveViewImmediate_Landroid_view_View_));
			}
			return IWindowManagerInvoker.cb_removeViewImmediate_Landroid_view_View_;
		}

		// Token: 0x06000A1D RID: 2589 RVA: 0x000192A4 File Offset: 0x000174A4
		private static void n_RemoveViewImmediate_Landroid_view_View_(IntPtr jnienv, IntPtr native__this, IntPtr native_view)
		{
			IWindowManager @object = Java.Lang.Object.GetObject<IWindowManager>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			View object2 = Java.Lang.Object.GetObject<View>(native_view, JniHandleOwnership.DoNotTransfer);
			@object.RemoveViewImmediate(object2);
		}

		// Token: 0x06000A1E RID: 2590 RVA: 0x000192C8 File Offset: 0x000174C8
		public unsafe void RemoveViewImmediate(View view)
		{
			if (this.id_removeViewImmediate_Landroid_view_View_ == IntPtr.Zero)
			{
				this.id_removeViewImmediate_Landroid_view_View_ = JNIEnv.GetMethodID(this.class_ref, "removeViewImmediate", "(Landroid/view/View;)V");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((view == null) ? IntPtr.Zero : view.Handle);
			JNIEnv.CallVoidMethod(base.Handle, this.id_removeViewImmediate_Landroid_view_View_, ptr);
		}

		// Token: 0x06000A1F RID: 2591 RVA: 0x0001933C File Offset: 0x0001753C
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

		// Token: 0x06000A20 RID: 2592 RVA: 0x000193D4 File Offset: 0x000175D4
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

		// Token: 0x06000A21 RID: 2593 RVA: 0x00019448 File Offset: 0x00017648
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

		// Token: 0x04000343 RID: 835
		private static readonly JniPeerMembers _members = new XAPeerMembers("android/view/WindowManager", typeof(IWindowManagerInvoker));

		// Token: 0x04000344 RID: 836
		private IntPtr class_ref;

		// Token: 0x04000345 RID: 837
		private static Delegate cb_getDefaultDisplay;

		// Token: 0x04000346 RID: 838
		private IntPtr id_getDefaultDisplay;

		// Token: 0x04000347 RID: 839
		private static Delegate cb_removeViewImmediate_Landroid_view_View_;

		// Token: 0x04000348 RID: 840
		private IntPtr id_removeViewImmediate_Landroid_view_View_;

		// Token: 0x04000349 RID: 841
		private IntPtr id_addView_Landroid_view_View_Landroid_view_ViewGroup_LayoutParams_;

		// Token: 0x0400034A RID: 842
		private IntPtr id_removeView_Landroid_view_View_;

		// Token: 0x0400034B RID: 843
		private IntPtr id_updateViewLayout_Landroid_view_View_Landroid_view_ViewGroup_LayoutParams_;
	}
}
