using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Android.Views;
using Java.Interop;
using Java.Lang;

namespace Bumptech.Glide.Request.Transition
{
	// Token: 0x020000A8 RID: 168
	[Register("com/bumptech/glide/request/transition/ViewPropertyTransition", DoNotGenerateAcw = true)]
	[JavaTypeParameters(new string[]
	{
		"R"
	})]
	public class ViewPropertyTransition : Java.Lang.Object, ITransition, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x170001DF RID: 479
		// (get) Token: 0x060008B0 RID: 2224 RVA: 0x0001AD7C File Offset: 0x00018F7C
		internal static IntPtr class_ref
		{
			get
			{
				return ViewPropertyTransition._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170001E0 RID: 480
		// (get) Token: 0x060008B1 RID: 2225 RVA: 0x0001ADA0 File Offset: 0x00018FA0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return ViewPropertyTransition._members;
			}
		}

		// Token: 0x170001E1 RID: 481
		// (get) Token: 0x060008B2 RID: 2226 RVA: 0x0001ADA8 File Offset: 0x00018FA8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return ViewPropertyTransition._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170001E2 RID: 482
		// (get) Token: 0x060008B3 RID: 2227 RVA: 0x0001ADCC File Offset: 0x00018FCC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return ViewPropertyTransition._members.ManagedPeerType;
			}
		}

		// Token: 0x060008B4 RID: 2228 RVA: 0x0001ADD8 File Offset: 0x00018FD8
		protected ViewPropertyTransition(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x060008B5 RID: 2229 RVA: 0x0001ADE4 File Offset: 0x00018FE4
		[Register(".ctor", "(Lcom/bumptech/glide/request/transition/ViewPropertyTransition$Animator;)V", "")]
		public unsafe ViewPropertyTransition(ViewPropertyTransition.IAnimator animator) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((animator == null) ? IntPtr.Zero : ((Java.Lang.Object)animator).Handle);
				base.SetHandle(ViewPropertyTransition._members.InstanceMethods.StartCreateInstance("(Lcom/bumptech/glide/request/transition/ViewPropertyTransition$Animator;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				ViewPropertyTransition._members.InstanceMethods.FinishCreateInstance("(Lcom/bumptech/glide/request/transition/ViewPropertyTransition$Animator;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(animator);
			}
		}

		// Token: 0x060008B6 RID: 2230 RVA: 0x0001AE98 File Offset: 0x00019098
		private static Delegate GetTransition_Ljava_lang_Object_Lcom_bumptech_glide_request_transition_Transition_ViewAdapter_Handler()
		{
			if (ViewPropertyTransition.cb_transition_Ljava_lang_Object_Lcom_bumptech_glide_request_transition_Transition_ViewAdapter_ == null)
			{
				ViewPropertyTransition.cb_transition_Ljava_lang_Object_Lcom_bumptech_glide_request_transition_Transition_ViewAdapter_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_Z(ViewPropertyTransition.n_Transition_Ljava_lang_Object_Lcom_bumptech_glide_request_transition_Transition_ViewAdapter_));
			}
			return ViewPropertyTransition.cb_transition_Ljava_lang_Object_Lcom_bumptech_glide_request_transition_Transition_ViewAdapter_;
		}

		// Token: 0x060008B7 RID: 2231 RVA: 0x0001AEBC File Offset: 0x000190BC
		private static bool n_Transition_Ljava_lang_Object_Lcom_bumptech_glide_request_transition_Transition_ViewAdapter_(IntPtr jnienv, IntPtr native__this, IntPtr native_current, IntPtr native_adapter)
		{
			ViewPropertyTransition @object = Java.Lang.Object.GetObject<ViewPropertyTransition>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_current, JniHandleOwnership.DoNotTransfer);
			ITransitionViewAdapter object3 = Java.Lang.Object.GetObject<ITransitionViewAdapter>(native_adapter, JniHandleOwnership.DoNotTransfer);
			return @object.Transition(object2, object3);
		}

		// Token: 0x060008B8 RID: 2232 RVA: 0x0001AEE8 File Offset: 0x000190E8
		[Register("transition", "(Ljava/lang/Object;Lcom/bumptech/glide/request/transition/Transition$ViewAdapter;)Z", "GetTransition_Ljava_lang_Object_Lcom_bumptech_glide_request_transition_Transition_ViewAdapter_Handler")]
		public unsafe virtual bool Transition(Java.Lang.Object current, ITransitionViewAdapter adapter)
		{
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(current);
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((adapter == null) ? IntPtr.Zero : ((Java.Lang.Object)adapter).Handle);
				result = ViewPropertyTransition._members.InstanceMethods.InvokeVirtualBooleanMethod("transition.(Ljava/lang/Object;Lcom/bumptech/glide/request/transition/Transition$ViewAdapter;)Z", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(current);
				GC.KeepAlive(adapter);
			}
			return result;
		}

		// Token: 0x04000226 RID: 550
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/bumptech/glide/request/transition/ViewPropertyTransition", typeof(ViewPropertyTransition));

		// Token: 0x04000227 RID: 551
		private static Delegate cb_transition_Ljava_lang_Object_Lcom_bumptech_glide_request_transition_Transition_ViewAdapter_;

		// Token: 0x020001BF RID: 447
		[Register("com/bumptech/glide/request/transition/ViewPropertyTransition$Animator", "", "Bumptech.Glide.Request.Transition.ViewPropertyTransition/IAnimatorInvoker")]
		public interface IAnimator : IJavaObject, IDisposable, IJavaPeerable
		{
			// Token: 0x060015C7 RID: 5575
			[Register("animate", "(Landroid/view/View;)V", "GetAnimate_Landroid_view_View_Handler:Bumptech.Glide.Request.Transition.ViewPropertyTransition/IAnimatorInvoker, Xamarin.Android.Glide")]
			void Animate(View p0);
		}

		// Token: 0x020001C0 RID: 448
		[Register("com/bumptech/glide/request/transition/ViewPropertyTransition$Animator", DoNotGenerateAcw = true)]
		internal class IAnimatorInvoker : Java.Lang.Object, ViewPropertyTransition.IAnimator, IJavaObject, IDisposable, IJavaPeerable
		{
			// Token: 0x170005DF RID: 1503
			// (get) Token: 0x060015C8 RID: 5576 RVA: 0x00044720 File Offset: 0x00042920
			private static IntPtr java_class_ref
			{
				get
				{
					return ViewPropertyTransition.IAnimatorInvoker._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x170005E0 RID: 1504
			// (get) Token: 0x060015C9 RID: 5577 RVA: 0x00044744 File Offset: 0x00042944
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return ViewPropertyTransition.IAnimatorInvoker._members;
				}
			}

			// Token: 0x170005E1 RID: 1505
			// (get) Token: 0x060015CA RID: 5578 RVA: 0x0004474B File Offset: 0x0004294B
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return this.class_ref;
				}
			}

			// Token: 0x170005E2 RID: 1506
			// (get) Token: 0x060015CB RID: 5579 RVA: 0x00044753 File Offset: 0x00042953
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return ViewPropertyTransition.IAnimatorInvoker._members.ManagedPeerType;
				}
			}

			// Token: 0x060015CC RID: 5580 RVA: 0x0004475F File Offset: 0x0004295F
			public static ViewPropertyTransition.IAnimator GetObject(IntPtr handle, JniHandleOwnership transfer)
			{
				return Java.Lang.Object.GetObject<ViewPropertyTransition.IAnimator>(handle, transfer);
			}

			// Token: 0x060015CD RID: 5581 RVA: 0x00044768 File Offset: 0x00042968
			private static IntPtr Validate(IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf(handle, ViewPropertyTransition.IAnimatorInvoker.java_class_ref))
				{
					throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'com.bumptech.glide.request.transition.ViewPropertyTransition.Animator'.");
				}
				return handle;
			}

			// Token: 0x060015CE RID: 5582 RVA: 0x00044793 File Offset: 0x00042993
			protected override void Dispose(bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
				{
					JNIEnv.DeleteGlobalRef(this.class_ref);
				}
				this.class_ref = IntPtr.Zero;
				base.Dispose(disposing);
			}

			// Token: 0x060015CF RID: 5583 RVA: 0x000447C4 File Offset: 0x000429C4
			public IAnimatorInvoker(IntPtr handle, JniHandleOwnership transfer) : base(ViewPropertyTransition.IAnimatorInvoker.Validate(handle), transfer)
			{
				IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
				this.class_ref = JNIEnv.NewGlobalRef(objectClass);
				JNIEnv.DeleteLocalRef(objectClass);
			}

			// Token: 0x060015D0 RID: 5584 RVA: 0x000447FC File Offset: 0x000429FC
			private static Delegate GetAnimate_Landroid_view_View_Handler()
			{
				if (ViewPropertyTransition.IAnimatorInvoker.cb_animate_Landroid_view_View_ == null)
				{
					ViewPropertyTransition.IAnimatorInvoker.cb_animate_Landroid_view_View_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(ViewPropertyTransition.IAnimatorInvoker.n_Animate_Landroid_view_View_));
				}
				return ViewPropertyTransition.IAnimatorInvoker.cb_animate_Landroid_view_View_;
			}

			// Token: 0x060015D1 RID: 5585 RVA: 0x00044820 File Offset: 0x00042A20
			private static void n_Animate_Landroid_view_View_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				ViewPropertyTransition.IAnimator @object = Java.Lang.Object.GetObject<ViewPropertyTransition.IAnimator>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				View object2 = Java.Lang.Object.GetObject<View>(native_p0, JniHandleOwnership.DoNotTransfer);
				@object.Animate(object2);
			}

			// Token: 0x060015D2 RID: 5586 RVA: 0x00044844 File Offset: 0x00042A44
			public unsafe void Animate(View p0)
			{
				if (this.id_animate_Landroid_view_View_ == IntPtr.Zero)
				{
					this.id_animate_Landroid_view_View_ = JNIEnv.GetMethodID(this.class_ref, "animate", "(Landroid/view/View;)V");
				}
				JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
				*ptr = new JValue((p0 == null) ? IntPtr.Zero : p0.Handle);
				JNIEnv.CallVoidMethod(base.Handle, this.id_animate_Landroid_view_View_, ptr);
			}

			// Token: 0x04000531 RID: 1329
			private static readonly JniPeerMembers _members = new XAPeerMembers("com/bumptech/glide/request/transition/ViewPropertyTransition$Animator", typeof(ViewPropertyTransition.IAnimatorInvoker));

			// Token: 0x04000532 RID: 1330
			private IntPtr class_ref;

			// Token: 0x04000533 RID: 1331
			private static Delegate cb_animate_Landroid_view_View_;

			// Token: 0x04000534 RID: 1332
			private IntPtr id_animate_Landroid_view_View_;
		}
	}
}
