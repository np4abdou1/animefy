using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Graphics.Drawables;
using Android.Runtime;
using Android.Views;
using Java.Interop;
using Java.Lang;

namespace Bumptech.Glide.Request.Transition
{
	// Token: 0x020000A0 RID: 160
	[Register("com/bumptech/glide/request/transition/Transition$ViewAdapter", DoNotGenerateAcw = true)]
	internal class ITransitionViewAdapterInvoker : Java.Lang.Object, ITransitionViewAdapter, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x170001C4 RID: 452
		// (get) Token: 0x06000863 RID: 2147 RVA: 0x0001A01C File Offset: 0x0001821C
		private static IntPtr java_class_ref
		{
			get
			{
				return ITransitionViewAdapterInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170001C5 RID: 453
		// (get) Token: 0x06000864 RID: 2148 RVA: 0x0001A040 File Offset: 0x00018240
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return ITransitionViewAdapterInvoker._members;
			}
		}

		// Token: 0x170001C6 RID: 454
		// (get) Token: 0x06000865 RID: 2149 RVA: 0x0001A047 File Offset: 0x00018247
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x170001C7 RID: 455
		// (get) Token: 0x06000866 RID: 2150 RVA: 0x0001A04F File Offset: 0x0001824F
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return ITransitionViewAdapterInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06000867 RID: 2151 RVA: 0x0001A05B File Offset: 0x0001825B
		public static ITransitionViewAdapter GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<ITransitionViewAdapter>(handle, transfer);
		}

		// Token: 0x06000868 RID: 2152 RVA: 0x0001A064 File Offset: 0x00018264
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, ITransitionViewAdapterInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'com.bumptech.glide.request.transition.Transition.ViewAdapter'.");
			}
			return handle;
		}

		// Token: 0x06000869 RID: 2153 RVA: 0x0001A08F File Offset: 0x0001828F
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x0600086A RID: 2154 RVA: 0x0001A0C0 File Offset: 0x000182C0
		public ITransitionViewAdapterInvoker(IntPtr handle, JniHandleOwnership transfer) : base(ITransitionViewAdapterInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x0600086B RID: 2155 RVA: 0x0001A0F8 File Offset: 0x000182F8
		private static Delegate GetGetCurrentDrawableHandler()
		{
			if (ITransitionViewAdapterInvoker.cb_getCurrentDrawable == null)
			{
				ITransitionViewAdapterInvoker.cb_getCurrentDrawable = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(ITransitionViewAdapterInvoker.n_GetCurrentDrawable));
			}
			return ITransitionViewAdapterInvoker.cb_getCurrentDrawable;
		}

		// Token: 0x0600086C RID: 2156 RVA: 0x0001A11C File Offset: 0x0001831C
		private static IntPtr n_GetCurrentDrawable(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<ITransitionViewAdapter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).CurrentDrawable);
		}

		// Token: 0x170001C8 RID: 456
		// (get) Token: 0x0600086D RID: 2157 RVA: 0x0001A130 File Offset: 0x00018330
		public Drawable CurrentDrawable
		{
			get
			{
				if (this.id_getCurrentDrawable == IntPtr.Zero)
				{
					this.id_getCurrentDrawable = JNIEnv.GetMethodID(this.class_ref, "getCurrentDrawable", "()Landroid/graphics/drawable/Drawable;");
				}
				return Java.Lang.Object.GetObject<Drawable>(JNIEnv.CallObjectMethod(base.Handle, this.id_getCurrentDrawable), JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x0600086E RID: 2158 RVA: 0x0001A181 File Offset: 0x00018381
		private static Delegate GetGetViewHandler()
		{
			if (ITransitionViewAdapterInvoker.cb_getView == null)
			{
				ITransitionViewAdapterInvoker.cb_getView = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(ITransitionViewAdapterInvoker.n_GetView));
			}
			return ITransitionViewAdapterInvoker.cb_getView;
		}

		// Token: 0x0600086F RID: 2159 RVA: 0x0001A1A5 File Offset: 0x000183A5
		private static IntPtr n_GetView(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<ITransitionViewAdapter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).View);
		}

		// Token: 0x170001C9 RID: 457
		// (get) Token: 0x06000870 RID: 2160 RVA: 0x0001A1BC File Offset: 0x000183BC
		public View View
		{
			get
			{
				if (this.id_getView == IntPtr.Zero)
				{
					this.id_getView = JNIEnv.GetMethodID(this.class_ref, "getView", "()Landroid/view/View;");
				}
				return Java.Lang.Object.GetObject<View>(JNIEnv.CallObjectMethod(base.Handle, this.id_getView), JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06000871 RID: 2161 RVA: 0x0001A20D File Offset: 0x0001840D
		private static Delegate GetSetDrawable_Landroid_graphics_drawable_Drawable_Handler()
		{
			if (ITransitionViewAdapterInvoker.cb_setDrawable_Landroid_graphics_drawable_Drawable_ == null)
			{
				ITransitionViewAdapterInvoker.cb_setDrawable_Landroid_graphics_drawable_Drawable_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(ITransitionViewAdapterInvoker.n_SetDrawable_Landroid_graphics_drawable_Drawable_));
			}
			return ITransitionViewAdapterInvoker.cb_setDrawable_Landroid_graphics_drawable_Drawable_;
		}

		// Token: 0x06000872 RID: 2162 RVA: 0x0001A234 File Offset: 0x00018434
		private static void n_SetDrawable_Landroid_graphics_drawable_Drawable_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			ITransitionViewAdapter @object = Java.Lang.Object.GetObject<ITransitionViewAdapter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Drawable object2 = Java.Lang.Object.GetObject<Drawable>(native_p0, JniHandleOwnership.DoNotTransfer);
			@object.SetDrawable(object2);
		}

		// Token: 0x06000873 RID: 2163 RVA: 0x0001A258 File Offset: 0x00018458
		public unsafe void SetDrawable(Drawable p0)
		{
			if (this.id_setDrawable_Landroid_graphics_drawable_Drawable_ == IntPtr.Zero)
			{
				this.id_setDrawable_Landroid_graphics_drawable_Drawable_ = JNIEnv.GetMethodID(this.class_ref, "setDrawable", "(Landroid/graphics/drawable/Drawable;)V");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((p0 == null) ? IntPtr.Zero : p0.Handle);
			JNIEnv.CallVoidMethod(base.Handle, this.id_setDrawable_Landroid_graphics_drawable_Drawable_, ptr);
		}

		// Token: 0x04000210 RID: 528
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/bumptech/glide/request/transition/Transition$ViewAdapter", typeof(ITransitionViewAdapterInvoker));

		// Token: 0x04000211 RID: 529
		private IntPtr class_ref;

		// Token: 0x04000212 RID: 530
		private static Delegate cb_getCurrentDrawable;

		// Token: 0x04000213 RID: 531
		private IntPtr id_getCurrentDrawable;

		// Token: 0x04000214 RID: 532
		private static Delegate cb_getView;

		// Token: 0x04000215 RID: 533
		private IntPtr id_getView;

		// Token: 0x04000216 RID: 534
		private static Delegate cb_setDrawable_Landroid_graphics_drawable_Drawable_;

		// Token: 0x04000217 RID: 535
		private IntPtr id_setDrawable_Landroid_graphics_drawable_Drawable_;
	}
}
