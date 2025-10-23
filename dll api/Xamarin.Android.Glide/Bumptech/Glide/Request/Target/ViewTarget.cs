using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Android.Views;
using Java.Interop;
using Java.Lang;

namespace Bumptech.Glide.Request.Target
{
	// Token: 0x020000C5 RID: 197
	[Obsolete("This class is obsoleted in this android platform")]
	[Register("com/bumptech/glide/request/target/ViewTarget", DoNotGenerateAcw = true)]
	[JavaTypeParameters(new string[]
	{
		"T extends android.view.View",
		"Z"
	})]
	public abstract class ViewTarget : BaseTarget
	{
		// Token: 0x1700023F RID: 575
		// (get) Token: 0x06000A3B RID: 2619 RVA: 0x0001FCF8 File Offset: 0x0001DEF8
		// (set) Token: 0x06000A3C RID: 2620 RVA: 0x0001FD28 File Offset: 0x0001DF28
		[Register("view")]
		protected View _view
		{
			get
			{
				return Java.Lang.Object.GetObject<View>(ViewTarget._members.InstanceFields.GetObjectValue("view.Landroid/view/View;", this).Handle, JniHandleOwnership.TransferLocalRef);
			}
			set
			{
				IntPtr intPtr = JNIEnv.ToLocalJniHandle(value);
				try
				{
					ViewTarget._members.InstanceFields.SetValue("view.Landroid/view/View;", this, new JniObjectReference(intPtr, JniObjectReferenceType.Invalid));
				}
				finally
				{
					JNIEnv.DeleteLocalRef(intPtr);
				}
			}
		}

		// Token: 0x17000240 RID: 576
		// (get) Token: 0x06000A3D RID: 2621 RVA: 0x0001FD74 File Offset: 0x0001DF74
		internal new static IntPtr class_ref
		{
			get
			{
				return ViewTarget._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000241 RID: 577
		// (get) Token: 0x06000A3E RID: 2622 RVA: 0x0001FD98 File Offset: 0x0001DF98
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return ViewTarget._members;
			}
		}

		// Token: 0x17000242 RID: 578
		// (get) Token: 0x06000A3F RID: 2623 RVA: 0x0001FDA0 File Offset: 0x0001DFA0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return ViewTarget._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000243 RID: 579
		// (get) Token: 0x06000A40 RID: 2624 RVA: 0x0001FDC4 File Offset: 0x0001DFC4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return ViewTarget._members.ManagedPeerType;
			}
		}

		// Token: 0x06000A41 RID: 2625 RVA: 0x0001FDD0 File Offset: 0x0001DFD0
		protected ViewTarget(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000A42 RID: 2626 RVA: 0x0001FDDC File Offset: 0x0001DFDC
		[Register(".ctor", "(Landroid/view/View;)V", "")]
		public unsafe ViewTarget(Java.Lang.Object view) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(view);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				base.SetHandle(ViewTarget._members.InstanceMethods.StartCreateInstance("(Landroid/view/View;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				ViewTarget._members.InstanceMethods.FinishCreateInstance("(Landroid/view/View;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(view);
			}
		}

		// Token: 0x06000A43 RID: 2627 RVA: 0x0001FE88 File Offset: 0x0001E088
		[Register(".ctor", "(Landroid/view/View;Z)V", "")]
		[Obsolete("deprecated")]
		public unsafe ViewTarget(Java.Lang.Object view, bool waitForLayout) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(view);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(waitForLayout);
				base.SetHandle(ViewTarget._members.InstanceMethods.StartCreateInstance("(Landroid/view/View;Z)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				ViewTarget._members.InstanceMethods.FinishCreateInstance("(Landroid/view/View;Z)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(view);
			}
		}

		// Token: 0x06000A44 RID: 2628 RVA: 0x0001FF48 File Offset: 0x0001E148
		private static Delegate GetGetViewHandler()
		{
			if (ViewTarget.cb_getView == null)
			{
				ViewTarget.cb_getView = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(ViewTarget.n_GetView));
			}
			return ViewTarget.cb_getView;
		}

		// Token: 0x06000A45 RID: 2629 RVA: 0x0001FF6C File Offset: 0x0001E16C
		private static IntPtr n_GetView(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<ViewTarget>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).View);
		}

		// Token: 0x17000244 RID: 580
		// (get) Token: 0x06000A46 RID: 2630 RVA: 0x0001FF80 File Offset: 0x0001E180
		public virtual View View
		{
			[Register("getView", "()Landroid/view/View;", "GetGetViewHandler")]
			get
			{
				return Java.Lang.Object.GetObject<View>(ViewTarget._members.InstanceMethods.InvokeVirtualObjectMethod("getView.()Landroid/view/View;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06000A47 RID: 2631 RVA: 0x0001FFB4 File Offset: 0x0001E1B4
		[Register("clearOnDetach", "()Lcom/bumptech/glide/request/target/ViewTarget;", "")]
		public ViewTarget ClearOnDetach()
		{
			return Java.Lang.Object.GetObject<ViewTarget>(ViewTarget._members.InstanceMethods.InvokeNonvirtualObjectMethod("clearOnDetach.()Lcom/bumptech/glide/request/target/ViewTarget;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06000A48 RID: 2632 RVA: 0x0001FFE6 File Offset: 0x0001E1E6
		private static Delegate GetGetSize_Lcom_bumptech_glide_request_target_SizeReadyCallback_Handler()
		{
			if (ViewTarget.cb_getSize_Lcom_bumptech_glide_request_target_SizeReadyCallback_ == null)
			{
				ViewTarget.cb_getSize_Lcom_bumptech_glide_request_target_SizeReadyCallback_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(ViewTarget.n_GetSize_Lcom_bumptech_glide_request_target_SizeReadyCallback_));
			}
			return ViewTarget.cb_getSize_Lcom_bumptech_glide_request_target_SizeReadyCallback_;
		}

		// Token: 0x06000A49 RID: 2633 RVA: 0x0002000C File Offset: 0x0001E20C
		private static void n_GetSize_Lcom_bumptech_glide_request_target_SizeReadyCallback_(IntPtr jnienv, IntPtr native__this, IntPtr native_cb)
		{
			BaseTarget @object = Java.Lang.Object.GetObject<ViewTarget>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ISizeReadyCallback object2 = Java.Lang.Object.GetObject<ISizeReadyCallback>(native_cb, JniHandleOwnership.DoNotTransfer);
			@object.GetSize(object2);
		}

		// Token: 0x06000A4A RID: 2634 RVA: 0x00020030 File Offset: 0x0001E230
		[Register("getSize", "(Lcom/bumptech/glide/request/target/SizeReadyCallback;)V", "GetGetSize_Lcom_bumptech_glide_request_target_SizeReadyCallback_Handler")]
		public unsafe override void GetSize(ISizeReadyCallback cb)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((cb == null) ? IntPtr.Zero : ((Java.Lang.Object)cb).Handle);
				ViewTarget._members.InstanceMethods.InvokeVirtualVoidMethod("getSize.(Lcom/bumptech/glide/request/target/SizeReadyCallback;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(cb);
			}
		}

		// Token: 0x06000A4B RID: 2635 RVA: 0x00020098 File Offset: 0x0001E298
		private static Delegate GetRemoveCallback_Lcom_bumptech_glide_request_target_SizeReadyCallback_Handler()
		{
			if (ViewTarget.cb_removeCallback_Lcom_bumptech_glide_request_target_SizeReadyCallback_ == null)
			{
				ViewTarget.cb_removeCallback_Lcom_bumptech_glide_request_target_SizeReadyCallback_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(ViewTarget.n_RemoveCallback_Lcom_bumptech_glide_request_target_SizeReadyCallback_));
			}
			return ViewTarget.cb_removeCallback_Lcom_bumptech_glide_request_target_SizeReadyCallback_;
		}

		// Token: 0x06000A4C RID: 2636 RVA: 0x000200BC File Offset: 0x0001E2BC
		private static void n_RemoveCallback_Lcom_bumptech_glide_request_target_SizeReadyCallback_(IntPtr jnienv, IntPtr native__this, IntPtr native_cb)
		{
			BaseTarget @object = Java.Lang.Object.GetObject<ViewTarget>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ISizeReadyCallback object2 = Java.Lang.Object.GetObject<ISizeReadyCallback>(native_cb, JniHandleOwnership.DoNotTransfer);
			@object.RemoveCallback(object2);
		}

		// Token: 0x06000A4D RID: 2637 RVA: 0x000200E0 File Offset: 0x0001E2E0
		[Register("removeCallback", "(Lcom/bumptech/glide/request/target/SizeReadyCallback;)V", "GetRemoveCallback_Lcom_bumptech_glide_request_target_SizeReadyCallback_Handler")]
		public unsafe override void RemoveCallback(ISizeReadyCallback cb)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((cb == null) ? IntPtr.Zero : ((Java.Lang.Object)cb).Handle);
				ViewTarget._members.InstanceMethods.InvokeVirtualVoidMethod("removeCallback.(Lcom/bumptech/glide/request/target/SizeReadyCallback;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(cb);
			}
		}

		// Token: 0x06000A4E RID: 2638 RVA: 0x00020148 File Offset: 0x0001E348
		[Obsolete("deprecated")]
		[Register("setTagId", "(I)V", "")]
		public unsafe static void SetTagId(int tagId)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(tagId);
			ViewTarget._members.StaticMethods.InvokeVoidMethod("setTagId.(I)V", ptr);
		}

		// Token: 0x06000A4F RID: 2639 RVA: 0x00020184 File Offset: 0x0001E384
		[Register("waitForLayout", "()Lcom/bumptech/glide/request/target/ViewTarget;", "")]
		public ViewTarget WaitForLayout()
		{
			return Java.Lang.Object.GetObject<ViewTarget>(ViewTarget._members.InstanceMethods.InvokeNonvirtualObjectMethod("waitForLayout.()Lcom/bumptech/glide/request/target/ViewTarget;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x04000289 RID: 649
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/bumptech/glide/request/target/ViewTarget", typeof(ViewTarget));

		// Token: 0x0400028A RID: 650
		private static Delegate cb_getView;

		// Token: 0x0400028B RID: 651
		private static Delegate cb_getSize_Lcom_bumptech_glide_request_target_SizeReadyCallback_;

		// Token: 0x0400028C RID: 652
		private static Delegate cb_removeCallback_Lcom_bumptech_glide_request_target_SizeReadyCallback_;
	}
}
