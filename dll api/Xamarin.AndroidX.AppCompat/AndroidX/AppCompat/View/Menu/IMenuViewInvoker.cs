using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace AndroidX.AppCompat.View.Menu
{
	// Token: 0x02000096 RID: 150
	[Register("androidx/appcompat/view/menu/MenuView", DoNotGenerateAcw = true)]
	internal class IMenuViewInvoker : Java.Lang.Object, IMenuView, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x1700019F RID: 415
		// (get) Token: 0x06000B29 RID: 2857 RVA: 0x0001D2EC File Offset: 0x0001B4EC
		private static IntPtr java_class_ref
		{
			get
			{
				return IMenuViewInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170001A0 RID: 416
		// (get) Token: 0x06000B2A RID: 2858 RVA: 0x0001D310 File Offset: 0x0001B510
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IMenuViewInvoker._members;
			}
		}

		// Token: 0x170001A1 RID: 417
		// (get) Token: 0x06000B2B RID: 2859 RVA: 0x0001D317 File Offset: 0x0001B517
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x170001A2 RID: 418
		// (get) Token: 0x06000B2C RID: 2860 RVA: 0x0001D31F File Offset: 0x0001B51F
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IMenuViewInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06000B2D RID: 2861 RVA: 0x0001D32B File Offset: 0x0001B52B
		public static IMenuView GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IMenuView>(handle, transfer);
		}

		// Token: 0x06000B2E RID: 2862 RVA: 0x0001D334 File Offset: 0x0001B534
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IMenuViewInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'androidx.appcompat.view.menu.MenuView'.");
			}
			return handle;
		}

		// Token: 0x06000B2F RID: 2863 RVA: 0x0001D35F File Offset: 0x0001B55F
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x06000B30 RID: 2864 RVA: 0x0001D390 File Offset: 0x0001B590
		public IMenuViewInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IMenuViewInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x06000B31 RID: 2865 RVA: 0x0001D3C8 File Offset: 0x0001B5C8
		private static Delegate GetGetWindowAnimationsHandler()
		{
			if (IMenuViewInvoker.cb_getWindowAnimations == null)
			{
				IMenuViewInvoker.cb_getWindowAnimations = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(IMenuViewInvoker.n_GetWindowAnimations));
			}
			return IMenuViewInvoker.cb_getWindowAnimations;
		}

		// Token: 0x06000B32 RID: 2866 RVA: 0x0001D3EC File Offset: 0x0001B5EC
		private static int n_GetWindowAnimations(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IMenuView>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).WindowAnimations;
		}

		// Token: 0x170001A3 RID: 419
		// (get) Token: 0x06000B33 RID: 2867 RVA: 0x0001D3FB File Offset: 0x0001B5FB
		public int WindowAnimations
		{
			get
			{
				if (this.id_getWindowAnimations == IntPtr.Zero)
				{
					this.id_getWindowAnimations = JNIEnv.GetMethodID(this.class_ref, "getWindowAnimations", "()I");
				}
				return JNIEnv.CallIntMethod(base.Handle, this.id_getWindowAnimations);
			}
		}

		// Token: 0x06000B34 RID: 2868 RVA: 0x0001D43B File Offset: 0x0001B63B
		private static Delegate GetInitialize_Landroidx_appcompat_view_menu_MenuBuilder_Handler()
		{
			if (IMenuViewInvoker.cb_initialize_Landroidx_appcompat_view_menu_MenuBuilder_ == null)
			{
				IMenuViewInvoker.cb_initialize_Landroidx_appcompat_view_menu_MenuBuilder_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(IMenuViewInvoker.n_Initialize_Landroidx_appcompat_view_menu_MenuBuilder_));
			}
			return IMenuViewInvoker.cb_initialize_Landroidx_appcompat_view_menu_MenuBuilder_;
		}

		// Token: 0x06000B35 RID: 2869 RVA: 0x0001D460 File Offset: 0x0001B660
		private static void n_Initialize_Landroidx_appcompat_view_menu_MenuBuilder_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			IMenuView @object = Java.Lang.Object.GetObject<IMenuView>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			MenuBuilder object2 = Java.Lang.Object.GetObject<MenuBuilder>(native_p0, JniHandleOwnership.DoNotTransfer);
			@object.Initialize(object2);
		}

		// Token: 0x06000B36 RID: 2870 RVA: 0x0001D484 File Offset: 0x0001B684
		public unsafe void Initialize(MenuBuilder p0)
		{
			if (this.id_initialize_Landroidx_appcompat_view_menu_MenuBuilder_ == IntPtr.Zero)
			{
				this.id_initialize_Landroidx_appcompat_view_menu_MenuBuilder_ = JNIEnv.GetMethodID(this.class_ref, "initialize", "(Landroidx/appcompat/view/menu/MenuBuilder;)V");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((p0 == null) ? IntPtr.Zero : p0.Handle);
			JNIEnv.CallVoidMethod(base.Handle, this.id_initialize_Landroidx_appcompat_view_menu_MenuBuilder_, ptr);
		}

		// Token: 0x04000359 RID: 857
		private static readonly JniPeerMembers _members = new XAPeerMembers("androidx/appcompat/view/menu/MenuView", typeof(IMenuViewInvoker));

		// Token: 0x0400035A RID: 858
		private IntPtr class_ref;

		// Token: 0x0400035B RID: 859
		private static Delegate cb_getWindowAnimations;

		// Token: 0x0400035C RID: 860
		private IntPtr id_getWindowAnimations;

		// Token: 0x0400035D RID: 861
		private static Delegate cb_initialize_Landroidx_appcompat_view_menu_MenuBuilder_;

		// Token: 0x0400035E RID: 862
		private IntPtr id_initialize_Landroidx_appcompat_view_menu_MenuBuilder_;
	}
}
