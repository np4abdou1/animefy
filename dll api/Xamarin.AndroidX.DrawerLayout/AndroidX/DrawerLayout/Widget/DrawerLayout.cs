using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Content;
using Android.Graphics;
using Android.Graphics.Drawables;
using Android.Runtime;
using Android.Util;
using Android.Views;
using AndroidX.Core.View;
using AndroidX.CustomView.Widget;
using Java.Interop;
using Java.Lang;

namespace AndroidX.DrawerLayout.Widget
{
	// Token: 0x02000019 RID: 25
	[Register("androidx/drawerlayout/widget/DrawerLayout", DoNotGenerateAcw = true)]
	public class DrawerLayout : ViewGroup, IOpenable, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000054 RID: 84 RVA: 0x00002080 File Offset: 0x00000280
		internal static IntPtr class_ref
		{
			get
			{
				return DrawerLayout._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000055 RID: 85 RVA: 0x000020A4 File Offset: 0x000002A4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return DrawerLayout._members;
			}
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000056 RID: 86 RVA: 0x000020AC File Offset: 0x000002AC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return DrawerLayout._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000057 RID: 87 RVA: 0x000020D0 File Offset: 0x000002D0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return DrawerLayout._members.ManagedPeerType;
			}
		}

		// Token: 0x06000058 RID: 88 RVA: 0x000020DC File Offset: 0x000002DC
		protected DrawerLayout(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000059 RID: 89 RVA: 0x000020E8 File Offset: 0x000002E8
		[Register(".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe DrawerLayout(Context context) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((context == null) ? IntPtr.Zero : context.Handle);
				base.SetHandle(DrawerLayout._members.InstanceMethods.StartCreateInstance("(Landroid/content/Context;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				DrawerLayout._members.InstanceMethods.FinishCreateInstance("(Landroid/content/Context;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(context);
			}
		}

		// Token: 0x0600005A RID: 90 RVA: 0x00002198 File Offset: 0x00000398
		[Register(".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", "")]
		public unsafe DrawerLayout(Context context, IAttributeSet attrs) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((context == null) ? IntPtr.Zero : context.Handle);
				ptr[1] = new JniArgumentValue((attrs == null) ? IntPtr.Zero : ((Java.Lang.Object)attrs).Handle);
				base.SetHandle(DrawerLayout._members.InstanceMethods.StartCreateInstance("(Landroid/content/Context;Landroid/util/AttributeSet;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				DrawerLayout._members.InstanceMethods.FinishCreateInstance("(Landroid/content/Context;Landroid/util/AttributeSet;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(context);
				GC.KeepAlive(attrs);
			}
		}

		// Token: 0x0600005B RID: 91 RVA: 0x00002274 File Offset: 0x00000474
		[Register(".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", "")]
		public unsafe DrawerLayout(Context context, IAttributeSet attrs, int defStyleAttr) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((context == null) ? IntPtr.Zero : context.Handle);
				ptr[1] = new JniArgumentValue((attrs == null) ? IntPtr.Zero : ((Java.Lang.Object)attrs).Handle);
				ptr[2] = new JniArgumentValue(defStyleAttr);
				base.SetHandle(DrawerLayout._members.InstanceMethods.StartCreateInstance("(Landroid/content/Context;Landroid/util/AttributeSet;I)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				DrawerLayout._members.InstanceMethods.FinishCreateInstance("(Landroid/content/Context;Landroid/util/AttributeSet;I)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(context);
				GC.KeepAlive(attrs);
			}
		}

		// Token: 0x0600005C RID: 92 RVA: 0x00002364 File Offset: 0x00000564
		private static Delegate GetGetDrawerElevationHandler()
		{
			if (DrawerLayout.cb_getDrawerElevation == null)
			{
				DrawerLayout.cb_getDrawerElevation = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_F(DrawerLayout.n_GetDrawerElevation));
			}
			return DrawerLayout.cb_getDrawerElevation;
		}

		// Token: 0x0600005D RID: 93 RVA: 0x00002388 File Offset: 0x00000588
		private static float n_GetDrawerElevation(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<DrawerLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).DrawerElevation;
		}

		// Token: 0x0600005E RID: 94 RVA: 0x00002397 File Offset: 0x00000597
		private static Delegate GetSetDrawerElevation_FHandler()
		{
			if (DrawerLayout.cb_setDrawerElevation_F == null)
			{
				DrawerLayout.cb_setDrawerElevation_F = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPF_V(DrawerLayout.n_SetDrawerElevation_F));
			}
			return DrawerLayout.cb_setDrawerElevation_F;
		}

		// Token: 0x0600005F RID: 95 RVA: 0x000023BB File Offset: 0x000005BB
		private static void n_SetDrawerElevation_F(IntPtr jnienv, IntPtr native__this, float elevation)
		{
			Java.Lang.Object.GetObject<DrawerLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).DrawerElevation = elevation;
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000060 RID: 96 RVA: 0x000023CB File Offset: 0x000005CB
		// (set) Token: 0x06000061 RID: 97 RVA: 0x000023E4 File Offset: 0x000005E4
		public unsafe virtual float DrawerElevation
		{
			[Register("getDrawerElevation", "()F", "GetGetDrawerElevationHandler")]
			get
			{
				return DrawerLayout._members.InstanceMethods.InvokeVirtualSingleMethod("getDrawerElevation.()F", this, null);
			}
			[Register("setDrawerElevation", "(F)V", "GetSetDrawerElevation_FHandler")]
			set
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(value);
				DrawerLayout._members.InstanceMethods.InvokeVirtualVoidMethod("setDrawerElevation.(F)V", this, ptr);
			}
		}

		// Token: 0x06000062 RID: 98 RVA: 0x0000241F File Offset: 0x0000061F
		private static Delegate GetIsOpenHandler()
		{
			if (DrawerLayout.cb_isOpen == null)
			{
				DrawerLayout.cb_isOpen = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(DrawerLayout.n_IsOpen));
			}
			return DrawerLayout.cb_isOpen;
		}

		// Token: 0x06000063 RID: 99 RVA: 0x00002443 File Offset: 0x00000643
		private static bool n_IsOpen(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<DrawerLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsOpen;
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x06000064 RID: 100 RVA: 0x00002452 File Offset: 0x00000652
		public virtual bool IsOpen
		{
			[Register("isOpen", "()Z", "GetIsOpenHandler")]
			get
			{
				return DrawerLayout._members.InstanceMethods.InvokeVirtualBooleanMethod("isOpen.()Z", this, null);
			}
		}

		// Token: 0x06000065 RID: 101 RVA: 0x0000246B File Offset: 0x0000066B
		private static Delegate GetGetStatusBarBackgroundDrawableHandler()
		{
			if (DrawerLayout.cb_getStatusBarBackgroundDrawable == null)
			{
				DrawerLayout.cb_getStatusBarBackgroundDrawable = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(DrawerLayout.n_GetStatusBarBackgroundDrawable));
			}
			return DrawerLayout.cb_getStatusBarBackgroundDrawable;
		}

		// Token: 0x06000066 RID: 102 RVA: 0x0000248F File Offset: 0x0000068F
		private static IntPtr n_GetStatusBarBackgroundDrawable(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<DrawerLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).StatusBarBackgroundDrawable);
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x06000067 RID: 103 RVA: 0x000024A4 File Offset: 0x000006A4
		public virtual Drawable StatusBarBackgroundDrawable
		{
			[Register("getStatusBarBackgroundDrawable", "()Landroid/graphics/drawable/Drawable;", "GetGetStatusBarBackgroundDrawableHandler")]
			get
			{
				return Java.Lang.Object.GetObject<Drawable>(DrawerLayout._members.InstanceMethods.InvokeVirtualObjectMethod("getStatusBarBackgroundDrawable.()Landroid/graphics/drawable/Drawable;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06000068 RID: 104 RVA: 0x000024D6 File Offset: 0x000006D6
		private static Delegate GetAddDrawerListener_Landroidx_drawerlayout_widget_DrawerLayout_DrawerListener_Handler()
		{
			if (DrawerLayout.cb_addDrawerListener_Landroidx_drawerlayout_widget_DrawerLayout_DrawerListener_ == null)
			{
				DrawerLayout.cb_addDrawerListener_Landroidx_drawerlayout_widget_DrawerLayout_DrawerListener_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(DrawerLayout.n_AddDrawerListener_Landroidx_drawerlayout_widget_DrawerLayout_DrawerListener_));
			}
			return DrawerLayout.cb_addDrawerListener_Landroidx_drawerlayout_widget_DrawerLayout_DrawerListener_;
		}

		// Token: 0x06000069 RID: 105 RVA: 0x000024FC File Offset: 0x000006FC
		private static void n_AddDrawerListener_Landroidx_drawerlayout_widget_DrawerLayout_DrawerListener_(IntPtr jnienv, IntPtr native__this, IntPtr native_listener)
		{
			DrawerLayout @object = Java.Lang.Object.GetObject<DrawerLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			DrawerLayout.IDrawerListener object2 = Java.Lang.Object.GetObject<DrawerLayout.IDrawerListener>(native_listener, JniHandleOwnership.DoNotTransfer);
			@object.AddDrawerListener(object2);
		}

		// Token: 0x0600006A RID: 106 RVA: 0x00002520 File Offset: 0x00000720
		[Register("addDrawerListener", "(Landroidx/drawerlayout/widget/DrawerLayout$DrawerListener;)V", "GetAddDrawerListener_Landroidx_drawerlayout_widget_DrawerLayout_DrawerListener_Handler")]
		public unsafe virtual void AddDrawerListener(DrawerLayout.IDrawerListener listener)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((listener == null) ? IntPtr.Zero : ((Java.Lang.Object)listener).Handle);
				DrawerLayout._members.InstanceMethods.InvokeVirtualVoidMethod("addDrawerListener.(Landroidx/drawerlayout/widget/DrawerLayout$DrawerListener;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(listener);
			}
		}

		// Token: 0x0600006B RID: 107 RVA: 0x00002588 File Offset: 0x00000788
		private static Delegate GetAddFocusables_Ljava_util_ArrayList_IIHandler()
		{
			if (DrawerLayout.cb_addFocusables_Ljava_util_ArrayList_II == null)
			{
				DrawerLayout.cb_addFocusables_Ljava_util_ArrayList_II = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLII_V(DrawerLayout.n_AddFocusables_Ljava_util_ArrayList_II));
			}
			return DrawerLayout.cb_addFocusables_Ljava_util_ArrayList_II;
		}

		// Token: 0x0600006C RID: 108 RVA: 0x000025AC File Offset: 0x000007AC
		private static void n_AddFocusables_Ljava_util_ArrayList_II(IntPtr jnienv, IntPtr native__this, IntPtr native_views, int direction, int focusableMode)
		{
			DrawerLayout @object = Java.Lang.Object.GetObject<DrawerLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IList<View> views = JavaList<View>.FromJniHandle(native_views, JniHandleOwnership.DoNotTransfer);
			@object.AddFocusables(views, direction, focusableMode);
		}

		// Token: 0x0600006D RID: 109 RVA: 0x000025D4 File Offset: 0x000007D4
		[Register("addFocusables", "(Ljava/util/ArrayList;II)V", "GetAddFocusables_Ljava_util_ArrayList_IIHandler")]
		public unsafe virtual void AddFocusables(IList<View> views, int direction, int focusableMode)
		{
			IntPtr intPtr = JavaList<View>.ToLocalJniHandle(views);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(direction);
				ptr[2] = new JniArgumentValue(focusableMode);
				DrawerLayout._members.InstanceMethods.InvokeVirtualVoidMethod("addFocusables.(Ljava/util/ArrayList;II)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(views);
			}
		}

		// Token: 0x0600006E RID: 110 RVA: 0x00002660 File Offset: 0x00000860
		private static Delegate GetCloseHandler()
		{
			if (DrawerLayout.cb_close == null)
			{
				DrawerLayout.cb_close = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(DrawerLayout.n_Close));
			}
			return DrawerLayout.cb_close;
		}

		// Token: 0x0600006F RID: 111 RVA: 0x00002684 File Offset: 0x00000884
		private static void n_Close(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<DrawerLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Close();
		}

		// Token: 0x06000070 RID: 112 RVA: 0x00002693 File Offset: 0x00000893
		[Register("close", "()V", "GetCloseHandler")]
		public virtual void Close()
		{
			DrawerLayout._members.InstanceMethods.InvokeVirtualVoidMethod("close.()V", this, null);
		}

		// Token: 0x06000071 RID: 113 RVA: 0x000026AC File Offset: 0x000008AC
		private static Delegate GetCloseDrawer_Landroid_view_View_Handler()
		{
			if (DrawerLayout.cb_closeDrawer_Landroid_view_View_ == null)
			{
				DrawerLayout.cb_closeDrawer_Landroid_view_View_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(DrawerLayout.n_CloseDrawer_Landroid_view_View_));
			}
			return DrawerLayout.cb_closeDrawer_Landroid_view_View_;
		}

		// Token: 0x06000072 RID: 114 RVA: 0x000026D0 File Offset: 0x000008D0
		private static void n_CloseDrawer_Landroid_view_View_(IntPtr jnienv, IntPtr native__this, IntPtr native_drawerView)
		{
			DrawerLayout @object = Java.Lang.Object.GetObject<DrawerLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			View object2 = Java.Lang.Object.GetObject<View>(native_drawerView, JniHandleOwnership.DoNotTransfer);
			@object.CloseDrawer(object2);
		}

		// Token: 0x06000073 RID: 115 RVA: 0x000026F4 File Offset: 0x000008F4
		[Register("closeDrawer", "(Landroid/view/View;)V", "GetCloseDrawer_Landroid_view_View_Handler")]
		public unsafe virtual void CloseDrawer(View drawerView)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((drawerView == null) ? IntPtr.Zero : drawerView.Handle);
				DrawerLayout._members.InstanceMethods.InvokeVirtualVoidMethod("closeDrawer.(Landroid/view/View;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(drawerView);
			}
		}

		// Token: 0x06000074 RID: 116 RVA: 0x00002758 File Offset: 0x00000958
		private static Delegate GetCloseDrawer_Landroid_view_View_ZHandler()
		{
			if (DrawerLayout.cb_closeDrawer_Landroid_view_View_Z == null)
			{
				DrawerLayout.cb_closeDrawer_Landroid_view_View_Z = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLZ_V(DrawerLayout.n_CloseDrawer_Landroid_view_View_Z));
			}
			return DrawerLayout.cb_closeDrawer_Landroid_view_View_Z;
		}

		// Token: 0x06000075 RID: 117 RVA: 0x0000277C File Offset: 0x0000097C
		private static void n_CloseDrawer_Landroid_view_View_Z(IntPtr jnienv, IntPtr native__this, IntPtr native_drawerView, bool animate)
		{
			DrawerLayout @object = Java.Lang.Object.GetObject<DrawerLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			View object2 = Java.Lang.Object.GetObject<View>(native_drawerView, JniHandleOwnership.DoNotTransfer);
			@object.CloseDrawer(object2, animate);
		}

		// Token: 0x06000076 RID: 118 RVA: 0x000027A0 File Offset: 0x000009A0
		[Register("closeDrawer", "(Landroid/view/View;Z)V", "GetCloseDrawer_Landroid_view_View_ZHandler")]
		public unsafe virtual void CloseDrawer(View drawerView, bool animate)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((drawerView == null) ? IntPtr.Zero : drawerView.Handle);
				ptr[1] = new JniArgumentValue(animate);
				DrawerLayout._members.InstanceMethods.InvokeVirtualVoidMethod("closeDrawer.(Landroid/view/View;Z)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(drawerView);
			}
		}

		// Token: 0x06000077 RID: 119 RVA: 0x00002818 File Offset: 0x00000A18
		private static Delegate GetCloseDrawer_IHandler()
		{
			if (DrawerLayout.cb_closeDrawer_I == null)
			{
				DrawerLayout.cb_closeDrawer_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_V(DrawerLayout.n_CloseDrawer_I));
			}
			return DrawerLayout.cb_closeDrawer_I;
		}

		// Token: 0x06000078 RID: 120 RVA: 0x0000283C File Offset: 0x00000A3C
		private static void n_CloseDrawer_I(IntPtr jnienv, IntPtr native__this, int gravity)
		{
			Java.Lang.Object.GetObject<DrawerLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).CloseDrawer(gravity);
		}

		// Token: 0x06000079 RID: 121 RVA: 0x0000284C File Offset: 0x00000A4C
		[Register("closeDrawer", "(I)V", "GetCloseDrawer_IHandler")]
		public unsafe virtual void CloseDrawer(int gravity)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(gravity);
			DrawerLayout._members.InstanceMethods.InvokeVirtualVoidMethod("closeDrawer.(I)V", this, ptr);
		}

		// Token: 0x0600007A RID: 122 RVA: 0x00002887 File Offset: 0x00000A87
		private static Delegate GetCloseDrawer_IZHandler()
		{
			if (DrawerLayout.cb_closeDrawer_IZ == null)
			{
				DrawerLayout.cb_closeDrawer_IZ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPIZ_V(DrawerLayout.n_CloseDrawer_IZ));
			}
			return DrawerLayout.cb_closeDrawer_IZ;
		}

		// Token: 0x0600007B RID: 123 RVA: 0x000028AB File Offset: 0x00000AAB
		private static void n_CloseDrawer_IZ(IntPtr jnienv, IntPtr native__this, int gravity, bool animate)
		{
			Java.Lang.Object.GetObject<DrawerLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).CloseDrawer(gravity, animate);
		}

		// Token: 0x0600007C RID: 124 RVA: 0x000028BC File Offset: 0x00000ABC
		[Register("closeDrawer", "(IZ)V", "GetCloseDrawer_IZHandler")]
		public unsafe virtual void CloseDrawer(int gravity, bool animate)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(gravity);
			ptr[1] = new JniArgumentValue(animate);
			DrawerLayout._members.InstanceMethods.InvokeVirtualVoidMethod("closeDrawer.(IZ)V", this, ptr);
		}

		// Token: 0x0600007D RID: 125 RVA: 0x0000290A File Offset: 0x00000B0A
		private static Delegate GetCloseDrawersHandler()
		{
			if (DrawerLayout.cb_closeDrawers == null)
			{
				DrawerLayout.cb_closeDrawers = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(DrawerLayout.n_CloseDrawers));
			}
			return DrawerLayout.cb_closeDrawers;
		}

		// Token: 0x0600007E RID: 126 RVA: 0x0000292E File Offset: 0x00000B2E
		private static void n_CloseDrawers(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<DrawerLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).CloseDrawers();
		}

		// Token: 0x0600007F RID: 127 RVA: 0x0000293D File Offset: 0x00000B3D
		[Register("closeDrawers", "()V", "GetCloseDrawersHandler")]
		public virtual void CloseDrawers()
		{
			DrawerLayout._members.InstanceMethods.InvokeVirtualVoidMethod("closeDrawers.()V", this, null);
		}

		// Token: 0x06000080 RID: 128 RVA: 0x00002956 File Offset: 0x00000B56
		private static Delegate GetGetDrawerLockMode_Landroid_view_View_Handler()
		{
			if (DrawerLayout.cb_getDrawerLockMode_Landroid_view_View_ == null)
			{
				DrawerLayout.cb_getDrawerLockMode_Landroid_view_View_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_I(DrawerLayout.n_GetDrawerLockMode_Landroid_view_View_));
			}
			return DrawerLayout.cb_getDrawerLockMode_Landroid_view_View_;
		}

		// Token: 0x06000081 RID: 129 RVA: 0x0000297C File Offset: 0x00000B7C
		private static int n_GetDrawerLockMode_Landroid_view_View_(IntPtr jnienv, IntPtr native__this, IntPtr native_drawerView)
		{
			DrawerLayout @object = Java.Lang.Object.GetObject<DrawerLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			View object2 = Java.Lang.Object.GetObject<View>(native_drawerView, JniHandleOwnership.DoNotTransfer);
			return @object.GetDrawerLockMode(object2);
		}

		// Token: 0x06000082 RID: 130 RVA: 0x000029A0 File Offset: 0x00000BA0
		[Register("getDrawerLockMode", "(Landroid/view/View;)I", "GetGetDrawerLockMode_Landroid_view_View_Handler")]
		public unsafe virtual int GetDrawerLockMode(View drawerView)
		{
			int result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((drawerView == null) ? IntPtr.Zero : drawerView.Handle);
				result = DrawerLayout._members.InstanceMethods.InvokeVirtualInt32Method("getDrawerLockMode.(Landroid/view/View;)I", this, ptr);
			}
			finally
			{
				GC.KeepAlive(drawerView);
			}
			return result;
		}

		// Token: 0x06000083 RID: 131 RVA: 0x00002A08 File Offset: 0x00000C08
		private static Delegate GetGetDrawerLockMode_IHandler()
		{
			if (DrawerLayout.cb_getDrawerLockMode_I == null)
			{
				DrawerLayout.cb_getDrawerLockMode_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_I(DrawerLayout.n_GetDrawerLockMode_I));
			}
			return DrawerLayout.cb_getDrawerLockMode_I;
		}

		// Token: 0x06000084 RID: 132 RVA: 0x00002A2C File Offset: 0x00000C2C
		private static int n_GetDrawerLockMode_I(IntPtr jnienv, IntPtr native__this, int edgeGravity)
		{
			return Java.Lang.Object.GetObject<DrawerLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).GetDrawerLockMode(edgeGravity);
		}

		// Token: 0x06000085 RID: 133 RVA: 0x00002A3C File Offset: 0x00000C3C
		[Register("getDrawerLockMode", "(I)I", "GetGetDrawerLockMode_IHandler")]
		public unsafe virtual int GetDrawerLockMode(int edgeGravity)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(edgeGravity);
			return DrawerLayout._members.InstanceMethods.InvokeVirtualInt32Method("getDrawerLockMode.(I)I", this, ptr);
		}

		// Token: 0x06000086 RID: 134 RVA: 0x00002A77 File Offset: 0x00000C77
		private static Delegate GetGetDrawerTitle_IHandler()
		{
			if (DrawerLayout.cb_getDrawerTitle_I == null)
			{
				DrawerLayout.cb_getDrawerTitle_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_L(DrawerLayout.n_GetDrawerTitle_I));
			}
			return DrawerLayout.cb_getDrawerTitle_I;
		}

		// Token: 0x06000087 RID: 135 RVA: 0x00002A9B File Offset: 0x00000C9B
		private static IntPtr n_GetDrawerTitle_I(IntPtr jnienv, IntPtr native__this, int edgeGravity)
		{
			return CharSequence.ToLocalJniHandle(Java.Lang.Object.GetObject<DrawerLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).GetDrawerTitleFormatted(edgeGravity));
		}

		// Token: 0x06000088 RID: 136 RVA: 0x00002AB0 File Offset: 0x00000CB0
		[Register("getDrawerTitle", "(I)Ljava/lang/CharSequence;", "GetGetDrawerTitle_IHandler")]
		public unsafe virtual ICharSequence GetDrawerTitleFormatted(int edgeGravity)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(edgeGravity);
			return Java.Lang.Object.GetObject<ICharSequence>(DrawerLayout._members.InstanceMethods.InvokeVirtualObjectMethod("getDrawerTitle.(I)Ljava/lang/CharSequence;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06000089 RID: 137 RVA: 0x00002AF9 File Offset: 0x00000CF9
		public string GetDrawerTitle(int edgeGravity)
		{
			ICharSequence drawerTitleFormatted = this.GetDrawerTitleFormatted(edgeGravity);
			if (drawerTitleFormatted == null)
			{
				return null;
			}
			return drawerTitleFormatted.ToString();
		}

		// Token: 0x0600008A RID: 138 RVA: 0x00002B0D File Offset: 0x00000D0D
		private static Delegate GetIsDrawerOpen_Landroid_view_View_Handler()
		{
			if (DrawerLayout.cb_isDrawerOpen_Landroid_view_View_ == null)
			{
				DrawerLayout.cb_isDrawerOpen_Landroid_view_View_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(DrawerLayout.n_IsDrawerOpen_Landroid_view_View_));
			}
			return DrawerLayout.cb_isDrawerOpen_Landroid_view_View_;
		}

		// Token: 0x0600008B RID: 139 RVA: 0x00002B34 File Offset: 0x00000D34
		private static bool n_IsDrawerOpen_Landroid_view_View_(IntPtr jnienv, IntPtr native__this, IntPtr native_drawer)
		{
			DrawerLayout @object = Java.Lang.Object.GetObject<DrawerLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			View object2 = Java.Lang.Object.GetObject<View>(native_drawer, JniHandleOwnership.DoNotTransfer);
			return @object.IsDrawerOpen(object2);
		}

		// Token: 0x0600008C RID: 140 RVA: 0x00002B58 File Offset: 0x00000D58
		[Register("isDrawerOpen", "(Landroid/view/View;)Z", "GetIsDrawerOpen_Landroid_view_View_Handler")]
		public unsafe virtual bool IsDrawerOpen(View drawer)
		{
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((drawer == null) ? IntPtr.Zero : drawer.Handle);
				result = DrawerLayout._members.InstanceMethods.InvokeVirtualBooleanMethod("isDrawerOpen.(Landroid/view/View;)Z", this, ptr);
			}
			finally
			{
				GC.KeepAlive(drawer);
			}
			return result;
		}

		// Token: 0x0600008D RID: 141 RVA: 0x00002BC0 File Offset: 0x00000DC0
		private static Delegate GetIsDrawerOpen_IHandler()
		{
			if (DrawerLayout.cb_isDrawerOpen_I == null)
			{
				DrawerLayout.cb_isDrawerOpen_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_Z(DrawerLayout.n_IsDrawerOpen_I));
			}
			return DrawerLayout.cb_isDrawerOpen_I;
		}

		// Token: 0x0600008E RID: 142 RVA: 0x00002BE4 File Offset: 0x00000DE4
		private static bool n_IsDrawerOpen_I(IntPtr jnienv, IntPtr native__this, int drawerGravity)
		{
			return Java.Lang.Object.GetObject<DrawerLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsDrawerOpen(drawerGravity);
		}

		// Token: 0x0600008F RID: 143 RVA: 0x00002BF4 File Offset: 0x00000DF4
		[Register("isDrawerOpen", "(I)Z", "GetIsDrawerOpen_IHandler")]
		public unsafe virtual bool IsDrawerOpen(int drawerGravity)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(drawerGravity);
			return DrawerLayout._members.InstanceMethods.InvokeVirtualBooleanMethod("isDrawerOpen.(I)Z", this, ptr);
		}

		// Token: 0x06000090 RID: 144 RVA: 0x00002C2F File Offset: 0x00000E2F
		private static Delegate GetIsDrawerVisible_Landroid_view_View_Handler()
		{
			if (DrawerLayout.cb_isDrawerVisible_Landroid_view_View_ == null)
			{
				DrawerLayout.cb_isDrawerVisible_Landroid_view_View_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(DrawerLayout.n_IsDrawerVisible_Landroid_view_View_));
			}
			return DrawerLayout.cb_isDrawerVisible_Landroid_view_View_;
		}

		// Token: 0x06000091 RID: 145 RVA: 0x00002C54 File Offset: 0x00000E54
		private static bool n_IsDrawerVisible_Landroid_view_View_(IntPtr jnienv, IntPtr native__this, IntPtr native_drawer)
		{
			DrawerLayout @object = Java.Lang.Object.GetObject<DrawerLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			View object2 = Java.Lang.Object.GetObject<View>(native_drawer, JniHandleOwnership.DoNotTransfer);
			return @object.IsDrawerVisible(object2);
		}

		// Token: 0x06000092 RID: 146 RVA: 0x00002C78 File Offset: 0x00000E78
		[Register("isDrawerVisible", "(Landroid/view/View;)Z", "GetIsDrawerVisible_Landroid_view_View_Handler")]
		public unsafe virtual bool IsDrawerVisible(View drawer)
		{
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((drawer == null) ? IntPtr.Zero : drawer.Handle);
				result = DrawerLayout._members.InstanceMethods.InvokeVirtualBooleanMethod("isDrawerVisible.(Landroid/view/View;)Z", this, ptr);
			}
			finally
			{
				GC.KeepAlive(drawer);
			}
			return result;
		}

		// Token: 0x06000093 RID: 147 RVA: 0x00002CE0 File Offset: 0x00000EE0
		private static Delegate GetIsDrawerVisible_IHandler()
		{
			if (DrawerLayout.cb_isDrawerVisible_I == null)
			{
				DrawerLayout.cb_isDrawerVisible_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_Z(DrawerLayout.n_IsDrawerVisible_I));
			}
			return DrawerLayout.cb_isDrawerVisible_I;
		}

		// Token: 0x06000094 RID: 148 RVA: 0x00002D04 File Offset: 0x00000F04
		private static bool n_IsDrawerVisible_I(IntPtr jnienv, IntPtr native__this, int drawerGravity)
		{
			return Java.Lang.Object.GetObject<DrawerLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsDrawerVisible(drawerGravity);
		}

		// Token: 0x06000095 RID: 149 RVA: 0x00002D14 File Offset: 0x00000F14
		[Register("isDrawerVisible", "(I)Z", "GetIsDrawerVisible_IHandler")]
		public unsafe virtual bool IsDrawerVisible(int drawerGravity)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(drawerGravity);
			return DrawerLayout._members.InstanceMethods.InvokeVirtualBooleanMethod("isDrawerVisible.(I)Z", this, ptr);
		}

		// Token: 0x06000096 RID: 150 RVA: 0x00002D4F File Offset: 0x00000F4F
		private static Delegate GetOnDraw_Landroid_graphics_Canvas_Handler()
		{
			if (DrawerLayout.cb_onDraw_Landroid_graphics_Canvas_ == null)
			{
				DrawerLayout.cb_onDraw_Landroid_graphics_Canvas_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(DrawerLayout.n_OnDraw_Landroid_graphics_Canvas_));
			}
			return DrawerLayout.cb_onDraw_Landroid_graphics_Canvas_;
		}

		// Token: 0x06000097 RID: 151 RVA: 0x00002D74 File Offset: 0x00000F74
		private static void n_OnDraw_Landroid_graphics_Canvas_(IntPtr jnienv, IntPtr native__this, IntPtr native_c)
		{
			DrawerLayout @object = Java.Lang.Object.GetObject<DrawerLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Canvas object2 = Java.Lang.Object.GetObject<Canvas>(native_c, JniHandleOwnership.DoNotTransfer);
			@object.OnDraw(object2);
		}

		// Token: 0x06000098 RID: 152 RVA: 0x00002D98 File Offset: 0x00000F98
		[Register("onDraw", "(Landroid/graphics/Canvas;)V", "GetOnDraw_Landroid_graphics_Canvas_Handler")]
		public new unsafe virtual void OnDraw(Canvas c)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((c == null) ? IntPtr.Zero : c.Handle);
				DrawerLayout._members.InstanceMethods.InvokeVirtualVoidMethod("onDraw.(Landroid/graphics/Canvas;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(c);
			}
		}

		// Token: 0x06000099 RID: 153 RVA: 0x00002DFC File Offset: 0x00000FFC
		private static Delegate GetOnLayout_ZIIIIHandler()
		{
			if (DrawerLayout.cb_onLayout_ZIIII == null)
			{
				DrawerLayout.cb_onLayout_ZIIII = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPZIIII_V(DrawerLayout.n_OnLayout_ZIIII));
			}
			return DrawerLayout.cb_onLayout_ZIIII;
		}

		// Token: 0x0600009A RID: 154 RVA: 0x00002E20 File Offset: 0x00001020
		private static void n_OnLayout_ZIIII(IntPtr jnienv, IntPtr native__this, bool changed, int l, int t, int r, int b)
		{
			Java.Lang.Object.GetObject<DrawerLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).OnLayout(changed, l, t, r, b);
		}

		// Token: 0x0600009B RID: 155 RVA: 0x00002E38 File Offset: 0x00001038
		[Register("onLayout", "(ZIIII)V", "GetOnLayout_ZIIIIHandler")]
		protected unsafe override void OnLayout(bool changed, int l, int t, int r, int b)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(changed);
			ptr[1] = new JniArgumentValue(l);
			ptr[2] = new JniArgumentValue(t);
			ptr[3] = new JniArgumentValue(r);
			ptr[4] = new JniArgumentValue(b);
			DrawerLayout._members.InstanceMethods.InvokeVirtualVoidMethod("onLayout.(ZIIII)V", this, ptr);
		}

		// Token: 0x0600009C RID: 156 RVA: 0x00002ECA File Offset: 0x000010CA
		private static Delegate GetOpenHandler()
		{
			if (DrawerLayout.cb_open == null)
			{
				DrawerLayout.cb_open = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(DrawerLayout.n_Open));
			}
			return DrawerLayout.cb_open;
		}

		// Token: 0x0600009D RID: 157 RVA: 0x00002EEE File Offset: 0x000010EE
		private static void n_Open(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<DrawerLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Open();
		}

		// Token: 0x0600009E RID: 158 RVA: 0x00002EFD File Offset: 0x000010FD
		[Register("open", "()V", "GetOpenHandler")]
		public virtual void Open()
		{
			DrawerLayout._members.InstanceMethods.InvokeVirtualVoidMethod("open.()V", this, null);
		}

		// Token: 0x0600009F RID: 159 RVA: 0x00002F16 File Offset: 0x00001116
		private static Delegate GetOpenDrawer_Landroid_view_View_Handler()
		{
			if (DrawerLayout.cb_openDrawer_Landroid_view_View_ == null)
			{
				DrawerLayout.cb_openDrawer_Landroid_view_View_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(DrawerLayout.n_OpenDrawer_Landroid_view_View_));
			}
			return DrawerLayout.cb_openDrawer_Landroid_view_View_;
		}

		// Token: 0x060000A0 RID: 160 RVA: 0x00002F3C File Offset: 0x0000113C
		private static void n_OpenDrawer_Landroid_view_View_(IntPtr jnienv, IntPtr native__this, IntPtr native_drawerView)
		{
			DrawerLayout @object = Java.Lang.Object.GetObject<DrawerLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			View object2 = Java.Lang.Object.GetObject<View>(native_drawerView, JniHandleOwnership.DoNotTransfer);
			@object.OpenDrawer(object2);
		}

		// Token: 0x060000A1 RID: 161 RVA: 0x00002F60 File Offset: 0x00001160
		[Register("openDrawer", "(Landroid/view/View;)V", "GetOpenDrawer_Landroid_view_View_Handler")]
		public unsafe virtual void OpenDrawer(View drawerView)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((drawerView == null) ? IntPtr.Zero : drawerView.Handle);
				DrawerLayout._members.InstanceMethods.InvokeVirtualVoidMethod("openDrawer.(Landroid/view/View;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(drawerView);
			}
		}

		// Token: 0x060000A2 RID: 162 RVA: 0x00002FC4 File Offset: 0x000011C4
		private static Delegate GetOpenDrawer_Landroid_view_View_ZHandler()
		{
			if (DrawerLayout.cb_openDrawer_Landroid_view_View_Z == null)
			{
				DrawerLayout.cb_openDrawer_Landroid_view_View_Z = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLZ_V(DrawerLayout.n_OpenDrawer_Landroid_view_View_Z));
			}
			return DrawerLayout.cb_openDrawer_Landroid_view_View_Z;
		}

		// Token: 0x060000A3 RID: 163 RVA: 0x00002FE8 File Offset: 0x000011E8
		private static void n_OpenDrawer_Landroid_view_View_Z(IntPtr jnienv, IntPtr native__this, IntPtr native_drawerView, bool animate)
		{
			DrawerLayout @object = Java.Lang.Object.GetObject<DrawerLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			View object2 = Java.Lang.Object.GetObject<View>(native_drawerView, JniHandleOwnership.DoNotTransfer);
			@object.OpenDrawer(object2, animate);
		}

		// Token: 0x060000A4 RID: 164 RVA: 0x0000300C File Offset: 0x0000120C
		[Register("openDrawer", "(Landroid/view/View;Z)V", "GetOpenDrawer_Landroid_view_View_ZHandler")]
		public unsafe virtual void OpenDrawer(View drawerView, bool animate)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((drawerView == null) ? IntPtr.Zero : drawerView.Handle);
				ptr[1] = new JniArgumentValue(animate);
				DrawerLayout._members.InstanceMethods.InvokeVirtualVoidMethod("openDrawer.(Landroid/view/View;Z)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(drawerView);
			}
		}

		// Token: 0x060000A5 RID: 165 RVA: 0x00003084 File Offset: 0x00001284
		private static Delegate GetOpenDrawer_IHandler()
		{
			if (DrawerLayout.cb_openDrawer_I == null)
			{
				DrawerLayout.cb_openDrawer_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_V(DrawerLayout.n_OpenDrawer_I));
			}
			return DrawerLayout.cb_openDrawer_I;
		}

		// Token: 0x060000A6 RID: 166 RVA: 0x000030A8 File Offset: 0x000012A8
		private static void n_OpenDrawer_I(IntPtr jnienv, IntPtr native__this, int gravity)
		{
			Java.Lang.Object.GetObject<DrawerLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).OpenDrawer(gravity);
		}

		// Token: 0x060000A7 RID: 167 RVA: 0x000030B8 File Offset: 0x000012B8
		[Register("openDrawer", "(I)V", "GetOpenDrawer_IHandler")]
		public unsafe virtual void OpenDrawer(int gravity)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(gravity);
			DrawerLayout._members.InstanceMethods.InvokeVirtualVoidMethod("openDrawer.(I)V", this, ptr);
		}

		// Token: 0x060000A8 RID: 168 RVA: 0x000030F3 File Offset: 0x000012F3
		private static Delegate GetOpenDrawer_IZHandler()
		{
			if (DrawerLayout.cb_openDrawer_IZ == null)
			{
				DrawerLayout.cb_openDrawer_IZ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPIZ_V(DrawerLayout.n_OpenDrawer_IZ));
			}
			return DrawerLayout.cb_openDrawer_IZ;
		}

		// Token: 0x060000A9 RID: 169 RVA: 0x00003117 File Offset: 0x00001317
		private static void n_OpenDrawer_IZ(IntPtr jnienv, IntPtr native__this, int gravity, bool animate)
		{
			Java.Lang.Object.GetObject<DrawerLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).OpenDrawer(gravity, animate);
		}

		// Token: 0x060000AA RID: 170 RVA: 0x00003128 File Offset: 0x00001328
		[Register("openDrawer", "(IZ)V", "GetOpenDrawer_IZHandler")]
		public unsafe virtual void OpenDrawer(int gravity, bool animate)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(gravity);
			ptr[1] = new JniArgumentValue(animate);
			DrawerLayout._members.InstanceMethods.InvokeVirtualVoidMethod("openDrawer.(IZ)V", this, ptr);
		}

		// Token: 0x060000AB RID: 171 RVA: 0x00003176 File Offset: 0x00001376
		private static Delegate GetRemoveDrawerListener_Landroidx_drawerlayout_widget_DrawerLayout_DrawerListener_Handler()
		{
			if (DrawerLayout.cb_removeDrawerListener_Landroidx_drawerlayout_widget_DrawerLayout_DrawerListener_ == null)
			{
				DrawerLayout.cb_removeDrawerListener_Landroidx_drawerlayout_widget_DrawerLayout_DrawerListener_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(DrawerLayout.n_RemoveDrawerListener_Landroidx_drawerlayout_widget_DrawerLayout_DrawerListener_));
			}
			return DrawerLayout.cb_removeDrawerListener_Landroidx_drawerlayout_widget_DrawerLayout_DrawerListener_;
		}

		// Token: 0x060000AC RID: 172 RVA: 0x0000319C File Offset: 0x0000139C
		private static void n_RemoveDrawerListener_Landroidx_drawerlayout_widget_DrawerLayout_DrawerListener_(IntPtr jnienv, IntPtr native__this, IntPtr native_listener)
		{
			DrawerLayout @object = Java.Lang.Object.GetObject<DrawerLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			DrawerLayout.IDrawerListener object2 = Java.Lang.Object.GetObject<DrawerLayout.IDrawerListener>(native_listener, JniHandleOwnership.DoNotTransfer);
			@object.RemoveDrawerListener(object2);
		}

		// Token: 0x060000AD RID: 173 RVA: 0x000031C0 File Offset: 0x000013C0
		[Register("removeDrawerListener", "(Landroidx/drawerlayout/widget/DrawerLayout$DrawerListener;)V", "GetRemoveDrawerListener_Landroidx_drawerlayout_widget_DrawerLayout_DrawerListener_Handler")]
		public unsafe virtual void RemoveDrawerListener(DrawerLayout.IDrawerListener listener)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((listener == null) ? IntPtr.Zero : ((Java.Lang.Object)listener).Handle);
				DrawerLayout._members.InstanceMethods.InvokeVirtualVoidMethod("removeDrawerListener.(Landroidx/drawerlayout/widget/DrawerLayout$DrawerListener;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(listener);
			}
		}

		// Token: 0x060000AE RID: 174 RVA: 0x00003228 File Offset: 0x00001428
		private static Delegate GetSetChildInsets_Landroidx_core_view_WindowInsetsCompat_ZHandler()
		{
			if (DrawerLayout.cb_setChildInsets_Landroidx_core_view_WindowInsetsCompat_Z == null)
			{
				DrawerLayout.cb_setChildInsets_Landroidx_core_view_WindowInsetsCompat_Z = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLZ_V(DrawerLayout.n_SetChildInsets_Landroidx_core_view_WindowInsetsCompat_Z));
			}
			return DrawerLayout.cb_setChildInsets_Landroidx_core_view_WindowInsetsCompat_Z;
		}

		// Token: 0x060000AF RID: 175 RVA: 0x0000324C File Offset: 0x0000144C
		private static void n_SetChildInsets_Landroidx_core_view_WindowInsetsCompat_Z(IntPtr jnienv, IntPtr native__this, IntPtr native_insets, bool draw)
		{
			DrawerLayout @object = Java.Lang.Object.GetObject<DrawerLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			WindowInsetsCompat object2 = Java.Lang.Object.GetObject<WindowInsetsCompat>(native_insets, JniHandleOwnership.DoNotTransfer);
			@object.SetChildInsets(object2, draw);
		}

		// Token: 0x060000B0 RID: 176 RVA: 0x00003270 File Offset: 0x00001470
		[Register("setChildInsets", "(Landroidx/core/view/WindowInsetsCompat;Z)V", "GetSetChildInsets_Landroidx_core_view_WindowInsetsCompat_ZHandler")]
		public unsafe virtual void SetChildInsets(WindowInsetsCompat insets, bool draw)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((insets == null) ? IntPtr.Zero : insets.Handle);
				ptr[1] = new JniArgumentValue(draw);
				DrawerLayout._members.InstanceMethods.InvokeVirtualVoidMethod("setChildInsets.(Landroidx/core/view/WindowInsetsCompat;Z)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(insets);
			}
		}

		// Token: 0x060000B1 RID: 177 RVA: 0x000032E8 File Offset: 0x000014E8
		private static Delegate GetSetDrawerListener_Landroidx_drawerlayout_widget_DrawerLayout_DrawerListener_Handler()
		{
			if (DrawerLayout.cb_setDrawerListener_Landroidx_drawerlayout_widget_DrawerLayout_DrawerListener_ == null)
			{
				DrawerLayout.cb_setDrawerListener_Landroidx_drawerlayout_widget_DrawerLayout_DrawerListener_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(DrawerLayout.n_SetDrawerListener_Landroidx_drawerlayout_widget_DrawerLayout_DrawerListener_));
			}
			return DrawerLayout.cb_setDrawerListener_Landroidx_drawerlayout_widget_DrawerLayout_DrawerListener_;
		}

		// Token: 0x060000B2 RID: 178 RVA: 0x0000330C File Offset: 0x0000150C
		private static void n_SetDrawerListener_Landroidx_drawerlayout_widget_DrawerLayout_DrawerListener_(IntPtr jnienv, IntPtr native__this, IntPtr native_listener)
		{
			DrawerLayout @object = Java.Lang.Object.GetObject<DrawerLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			DrawerLayout.IDrawerListener object2 = Java.Lang.Object.GetObject<DrawerLayout.IDrawerListener>(native_listener, JniHandleOwnership.DoNotTransfer);
			@object.SetDrawerListener(object2);
		}

		// Token: 0x060000B3 RID: 179 RVA: 0x00003330 File Offset: 0x00001530
		[Register("setDrawerListener", "(Landroidx/drawerlayout/widget/DrawerLayout$DrawerListener;)V", "GetSetDrawerListener_Landroidx_drawerlayout_widget_DrawerLayout_DrawerListener_Handler")]
		public unsafe virtual void SetDrawerListener(DrawerLayout.IDrawerListener listener)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((listener == null) ? IntPtr.Zero : ((Java.Lang.Object)listener).Handle);
				DrawerLayout._members.InstanceMethods.InvokeVirtualVoidMethod("setDrawerListener.(Landroidx/drawerlayout/widget/DrawerLayout$DrawerListener;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(listener);
			}
		}

		// Token: 0x060000B4 RID: 180 RVA: 0x00003398 File Offset: 0x00001598
		private static Delegate GetSetDrawerLockMode_IHandler()
		{
			if (DrawerLayout.cb_setDrawerLockMode_I == null)
			{
				DrawerLayout.cb_setDrawerLockMode_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_V(DrawerLayout.n_SetDrawerLockMode_I));
			}
			return DrawerLayout.cb_setDrawerLockMode_I;
		}

		// Token: 0x060000B5 RID: 181 RVA: 0x000033BC File Offset: 0x000015BC
		private static void n_SetDrawerLockMode_I(IntPtr jnienv, IntPtr native__this, int lockMode)
		{
			Java.Lang.Object.GetObject<DrawerLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SetDrawerLockMode(lockMode);
		}

		// Token: 0x060000B6 RID: 182 RVA: 0x000033CC File Offset: 0x000015CC
		[Register("setDrawerLockMode", "(I)V", "GetSetDrawerLockMode_IHandler")]
		public unsafe virtual void SetDrawerLockMode(int lockMode)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(lockMode);
			DrawerLayout._members.InstanceMethods.InvokeVirtualVoidMethod("setDrawerLockMode.(I)V", this, ptr);
		}

		// Token: 0x060000B7 RID: 183 RVA: 0x00003407 File Offset: 0x00001607
		private static Delegate GetSetDrawerLockMode_ILandroid_view_View_Handler()
		{
			if (DrawerLayout.cb_setDrawerLockMode_ILandroid_view_View_ == null)
			{
				DrawerLayout.cb_setDrawerLockMode_ILandroid_view_View_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPIL_V(DrawerLayout.n_SetDrawerLockMode_ILandroid_view_View_));
			}
			return DrawerLayout.cb_setDrawerLockMode_ILandroid_view_View_;
		}

		// Token: 0x060000B8 RID: 184 RVA: 0x0000342C File Offset: 0x0000162C
		private static void n_SetDrawerLockMode_ILandroid_view_View_(IntPtr jnienv, IntPtr native__this, int lockMode, IntPtr native_drawerView)
		{
			DrawerLayout @object = Java.Lang.Object.GetObject<DrawerLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			View object2 = Java.Lang.Object.GetObject<View>(native_drawerView, JniHandleOwnership.DoNotTransfer);
			@object.SetDrawerLockMode(lockMode, object2);
		}

		// Token: 0x060000B9 RID: 185 RVA: 0x00003450 File Offset: 0x00001650
		[Register("setDrawerLockMode", "(ILandroid/view/View;)V", "GetSetDrawerLockMode_ILandroid_view_View_Handler")]
		public unsafe virtual void SetDrawerLockMode(int lockMode, View drawerView)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(lockMode);
				ptr[1] = new JniArgumentValue((drawerView == null) ? IntPtr.Zero : drawerView.Handle);
				DrawerLayout._members.InstanceMethods.InvokeVirtualVoidMethod("setDrawerLockMode.(ILandroid/view/View;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(drawerView);
			}
		}

		// Token: 0x060000BA RID: 186 RVA: 0x000034C8 File Offset: 0x000016C8
		private static Delegate GetSetDrawerLockMode_IIHandler()
		{
			if (DrawerLayout.cb_setDrawerLockMode_II == null)
			{
				DrawerLayout.cb_setDrawerLockMode_II = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPII_V(DrawerLayout.n_SetDrawerLockMode_II));
			}
			return DrawerLayout.cb_setDrawerLockMode_II;
		}

		// Token: 0x060000BB RID: 187 RVA: 0x000034EC File Offset: 0x000016EC
		private static void n_SetDrawerLockMode_II(IntPtr jnienv, IntPtr native__this, int lockMode, int edgeGravity)
		{
			Java.Lang.Object.GetObject<DrawerLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SetDrawerLockMode(lockMode, edgeGravity);
		}

		// Token: 0x060000BC RID: 188 RVA: 0x00003500 File Offset: 0x00001700
		[Register("setDrawerLockMode", "(II)V", "GetSetDrawerLockMode_IIHandler")]
		public unsafe virtual void SetDrawerLockMode(int lockMode, int edgeGravity)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(lockMode);
			ptr[1] = new JniArgumentValue(edgeGravity);
			DrawerLayout._members.InstanceMethods.InvokeVirtualVoidMethod("setDrawerLockMode.(II)V", this, ptr);
		}

		// Token: 0x060000BD RID: 189 RVA: 0x0000354E File Offset: 0x0000174E
		private static Delegate GetSetDrawerShadow_Landroid_graphics_drawable_Drawable_IHandler()
		{
			if (DrawerLayout.cb_setDrawerShadow_Landroid_graphics_drawable_Drawable_I == null)
			{
				DrawerLayout.cb_setDrawerShadow_Landroid_graphics_drawable_Drawable_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLI_V(DrawerLayout.n_SetDrawerShadow_Landroid_graphics_drawable_Drawable_I));
			}
			return DrawerLayout.cb_setDrawerShadow_Landroid_graphics_drawable_Drawable_I;
		}

		// Token: 0x060000BE RID: 190 RVA: 0x00003574 File Offset: 0x00001774
		private static void n_SetDrawerShadow_Landroid_graphics_drawable_Drawable_I(IntPtr jnienv, IntPtr native__this, IntPtr native_shadowDrawable, int gravity)
		{
			DrawerLayout @object = Java.Lang.Object.GetObject<DrawerLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Drawable object2 = Java.Lang.Object.GetObject<Drawable>(native_shadowDrawable, JniHandleOwnership.DoNotTransfer);
			@object.SetDrawerShadow(object2, gravity);
		}

		// Token: 0x060000BF RID: 191 RVA: 0x00003598 File Offset: 0x00001798
		[Register("setDrawerShadow", "(Landroid/graphics/drawable/Drawable;I)V", "GetSetDrawerShadow_Landroid_graphics_drawable_Drawable_IHandler")]
		public unsafe virtual void SetDrawerShadow(Drawable shadowDrawable, int gravity)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((shadowDrawable == null) ? IntPtr.Zero : shadowDrawable.Handle);
				ptr[1] = new JniArgumentValue(gravity);
				DrawerLayout._members.InstanceMethods.InvokeVirtualVoidMethod("setDrawerShadow.(Landroid/graphics/drawable/Drawable;I)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(shadowDrawable);
			}
		}

		// Token: 0x060000C0 RID: 192 RVA: 0x00003610 File Offset: 0x00001810
		private static Delegate GetSetDrawerShadow_IIHandler()
		{
			if (DrawerLayout.cb_setDrawerShadow_II == null)
			{
				DrawerLayout.cb_setDrawerShadow_II = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPII_V(DrawerLayout.n_SetDrawerShadow_II));
			}
			return DrawerLayout.cb_setDrawerShadow_II;
		}

		// Token: 0x060000C1 RID: 193 RVA: 0x00003634 File Offset: 0x00001834
		private static void n_SetDrawerShadow_II(IntPtr jnienv, IntPtr native__this, int resId, int gravity)
		{
			Java.Lang.Object.GetObject<DrawerLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SetDrawerShadow(resId, gravity);
		}

		// Token: 0x060000C2 RID: 194 RVA: 0x00003648 File Offset: 0x00001848
		[Register("setDrawerShadow", "(II)V", "GetSetDrawerShadow_IIHandler")]
		public unsafe virtual void SetDrawerShadow(int resId, int gravity)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(resId);
			ptr[1] = new JniArgumentValue(gravity);
			DrawerLayout._members.InstanceMethods.InvokeVirtualVoidMethod("setDrawerShadow.(II)V", this, ptr);
		}

		// Token: 0x060000C3 RID: 195 RVA: 0x00003696 File Offset: 0x00001896
		private static Delegate GetSetDrawerTitle_ILjava_lang_CharSequence_Handler()
		{
			if (DrawerLayout.cb_setDrawerTitle_ILjava_lang_CharSequence_ == null)
			{
				DrawerLayout.cb_setDrawerTitle_ILjava_lang_CharSequence_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPIL_V(DrawerLayout.n_SetDrawerTitle_ILjava_lang_CharSequence_));
			}
			return DrawerLayout.cb_setDrawerTitle_ILjava_lang_CharSequence_;
		}

		// Token: 0x060000C4 RID: 196 RVA: 0x000036BC File Offset: 0x000018BC
		private static void n_SetDrawerTitle_ILjava_lang_CharSequence_(IntPtr jnienv, IntPtr native__this, int edgeGravity, IntPtr native_title)
		{
			DrawerLayout @object = Java.Lang.Object.GetObject<DrawerLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ICharSequence object2 = Java.Lang.Object.GetObject<ICharSequence>(native_title, JniHandleOwnership.DoNotTransfer);
			@object.SetDrawerTitle(edgeGravity, object2);
		}

		// Token: 0x060000C5 RID: 197 RVA: 0x000036E0 File Offset: 0x000018E0
		[Register("setDrawerTitle", "(ILjava/lang/CharSequence;)V", "GetSetDrawerTitle_ILjava_lang_CharSequence_Handler")]
		public unsafe virtual void SetDrawerTitle(int edgeGravity, ICharSequence title)
		{
			IntPtr intPtr = CharSequence.ToLocalJniHandle(title);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(edgeGravity);
				ptr[1] = new JniArgumentValue(intPtr);
				DrawerLayout._members.InstanceMethods.InvokeVirtualVoidMethod("setDrawerTitle.(ILjava/lang/CharSequence;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(title);
			}
		}

		// Token: 0x060000C6 RID: 198 RVA: 0x00003754 File Offset: 0x00001954
		public void SetDrawerTitle(int edgeGravity, string title)
		{
			Java.Lang.String @string = (title == null) ? null : new Java.Lang.String(title);
			this.SetDrawerTitle(edgeGravity, @string);
			if (@string != null)
			{
				@string.Dispose();
			}
		}

		// Token: 0x060000C7 RID: 199 RVA: 0x0000377F File Offset: 0x0000197F
		private static Delegate GetSetScrimColor_IHandler()
		{
			if (DrawerLayout.cb_setScrimColor_I == null)
			{
				DrawerLayout.cb_setScrimColor_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_V(DrawerLayout.n_SetScrimColor_I));
			}
			return DrawerLayout.cb_setScrimColor_I;
		}

		// Token: 0x060000C8 RID: 200 RVA: 0x000037A3 File Offset: 0x000019A3
		private static void n_SetScrimColor_I(IntPtr jnienv, IntPtr native__this, int color)
		{
			Java.Lang.Object.GetObject<DrawerLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SetScrimColor(color);
		}

		// Token: 0x060000C9 RID: 201 RVA: 0x000037B4 File Offset: 0x000019B4
		[Register("setScrimColor", "(I)V", "GetSetScrimColor_IHandler")]
		public unsafe virtual void SetScrimColor(int color)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(color);
			DrawerLayout._members.InstanceMethods.InvokeVirtualVoidMethod("setScrimColor.(I)V", this, ptr);
		}

		// Token: 0x060000CA RID: 202 RVA: 0x000037EF File Offset: 0x000019EF
		private static Delegate GetSetStatusBarBackground_Landroid_graphics_drawable_Drawable_Handler()
		{
			if (DrawerLayout.cb_setStatusBarBackground_Landroid_graphics_drawable_Drawable_ == null)
			{
				DrawerLayout.cb_setStatusBarBackground_Landroid_graphics_drawable_Drawable_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(DrawerLayout.n_SetStatusBarBackground_Landroid_graphics_drawable_Drawable_));
			}
			return DrawerLayout.cb_setStatusBarBackground_Landroid_graphics_drawable_Drawable_;
		}

		// Token: 0x060000CB RID: 203 RVA: 0x00003814 File Offset: 0x00001A14
		private static void n_SetStatusBarBackground_Landroid_graphics_drawable_Drawable_(IntPtr jnienv, IntPtr native__this, IntPtr native_bg)
		{
			DrawerLayout @object = Java.Lang.Object.GetObject<DrawerLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Drawable object2 = Java.Lang.Object.GetObject<Drawable>(native_bg, JniHandleOwnership.DoNotTransfer);
			@object.SetStatusBarBackground(object2);
		}

		// Token: 0x060000CC RID: 204 RVA: 0x00003838 File Offset: 0x00001A38
		[Register("setStatusBarBackground", "(Landroid/graphics/drawable/Drawable;)V", "GetSetStatusBarBackground_Landroid_graphics_drawable_Drawable_Handler")]
		public unsafe virtual void SetStatusBarBackground(Drawable bg)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((bg == null) ? IntPtr.Zero : bg.Handle);
				DrawerLayout._members.InstanceMethods.InvokeVirtualVoidMethod("setStatusBarBackground.(Landroid/graphics/drawable/Drawable;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(bg);
			}
		}

		// Token: 0x060000CD RID: 205 RVA: 0x0000389C File Offset: 0x00001A9C
		private static Delegate GetSetStatusBarBackground_IHandler()
		{
			if (DrawerLayout.cb_setStatusBarBackground_I == null)
			{
				DrawerLayout.cb_setStatusBarBackground_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_V(DrawerLayout.n_SetStatusBarBackground_I));
			}
			return DrawerLayout.cb_setStatusBarBackground_I;
		}

		// Token: 0x060000CE RID: 206 RVA: 0x000038C0 File Offset: 0x00001AC0
		private static void n_SetStatusBarBackground_I(IntPtr jnienv, IntPtr native__this, int resId)
		{
			Java.Lang.Object.GetObject<DrawerLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SetStatusBarBackground(resId);
		}

		// Token: 0x060000CF RID: 207 RVA: 0x000038D0 File Offset: 0x00001AD0
		[Register("setStatusBarBackground", "(I)V", "GetSetStatusBarBackground_IHandler")]
		public unsafe virtual void SetStatusBarBackground(int resId)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(resId);
			DrawerLayout._members.InstanceMethods.InvokeVirtualVoidMethod("setStatusBarBackground.(I)V", this, ptr);
		}

		// Token: 0x060000D0 RID: 208 RVA: 0x0000390B File Offset: 0x00001B0B
		private static Delegate GetSetStatusBarBackgroundColor_IHandler()
		{
			if (DrawerLayout.cb_setStatusBarBackgroundColor_I == null)
			{
				DrawerLayout.cb_setStatusBarBackgroundColor_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_V(DrawerLayout.n_SetStatusBarBackgroundColor_I));
			}
			return DrawerLayout.cb_setStatusBarBackgroundColor_I;
		}

		// Token: 0x060000D1 RID: 209 RVA: 0x0000392F File Offset: 0x00001B2F
		private static void n_SetStatusBarBackgroundColor_I(IntPtr jnienv, IntPtr native__this, int color)
		{
			Java.Lang.Object.GetObject<DrawerLayout>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SetStatusBarBackgroundColor(color);
		}

		// Token: 0x060000D2 RID: 210 RVA: 0x00003940 File Offset: 0x00001B40
		[Register("setStatusBarBackgroundColor", "(I)V", "GetSetStatusBarBackgroundColor_IHandler")]
		public unsafe virtual void SetStatusBarBackgroundColor(int color)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(color);
			DrawerLayout._members.InstanceMethods.InvokeVirtualVoidMethod("setStatusBarBackgroundColor.(I)V", this, ptr);
		}

		// Token: 0x14000001 RID: 1
		// (add) Token: 0x060000D3 RID: 211 RVA: 0x0000397C File Offset: 0x00001B7C
		// (remove) Token: 0x060000D4 RID: 212 RVA: 0x000039C8 File Offset: 0x00001BC8
		public event EventHandler<DrawerLayout.DrawerClosedEventArgs> DrawerClosed
		{
			add
			{
				EventHelper.AddEventHandler<DrawerLayout.IDrawerListener, DrawerLayout.IDrawerListenerImplementor>(ref this.weak_implementor_AddDrawerListener, new Func<DrawerLayout.IDrawerListenerImplementor>(this.__CreateIDrawerListenerImplementor), new Action<DrawerLayout.IDrawerListener>(this.AddDrawerListener), delegate(DrawerLayout.IDrawerListenerImplementor __h)
				{
					__h.OnDrawerClosedHandler = (EventHandler<DrawerLayout.DrawerClosedEventArgs>)Delegate.Combine(__h.OnDrawerClosedHandler, value);
				});
			}
			remove
			{
				Func<DrawerLayout.IDrawerListenerImplementor, bool> empty;
				if ((empty = DrawerLayout.<>O.<0>____IsEmpty) == null)
				{
					empty = (DrawerLayout.<>O.<0>____IsEmpty = new Func<DrawerLayout.IDrawerListenerImplementor, bool>(DrawerLayout.IDrawerListenerImplementor.__IsEmpty));
				}
				EventHelper.RemoveEventHandler<DrawerLayout.IDrawerListener, DrawerLayout.IDrawerListenerImplementor>(ref this.weak_implementor_AddDrawerListener, empty, delegate(DrawerLayout.IDrawerListener __v)
				{
					this.RemoveDrawerListener(__v);
				}, delegate(DrawerLayout.IDrawerListenerImplementor __h)
				{
					__h.OnDrawerClosedHandler = (EventHandler<DrawerLayout.DrawerClosedEventArgs>)Delegate.Remove(__h.OnDrawerClosedHandler, value);
				});
			}
		}

		// Token: 0x14000002 RID: 2
		// (add) Token: 0x060000D5 RID: 213 RVA: 0x00003A28 File Offset: 0x00001C28
		// (remove) Token: 0x060000D6 RID: 214 RVA: 0x00003A74 File Offset: 0x00001C74
		public event EventHandler<DrawerLayout.DrawerOpenedEventArgs> DrawerOpened
		{
			add
			{
				EventHelper.AddEventHandler<DrawerLayout.IDrawerListener, DrawerLayout.IDrawerListenerImplementor>(ref this.weak_implementor_AddDrawerListener, new Func<DrawerLayout.IDrawerListenerImplementor>(this.__CreateIDrawerListenerImplementor), new Action<DrawerLayout.IDrawerListener>(this.AddDrawerListener), delegate(DrawerLayout.IDrawerListenerImplementor __h)
				{
					__h.OnDrawerOpenedHandler = (EventHandler<DrawerLayout.DrawerOpenedEventArgs>)Delegate.Combine(__h.OnDrawerOpenedHandler, value);
				});
			}
			remove
			{
				Func<DrawerLayout.IDrawerListenerImplementor, bool> empty;
				if ((empty = DrawerLayout.<>O.<0>____IsEmpty) == null)
				{
					empty = (DrawerLayout.<>O.<0>____IsEmpty = new Func<DrawerLayout.IDrawerListenerImplementor, bool>(DrawerLayout.IDrawerListenerImplementor.__IsEmpty));
				}
				EventHelper.RemoveEventHandler<DrawerLayout.IDrawerListener, DrawerLayout.IDrawerListenerImplementor>(ref this.weak_implementor_AddDrawerListener, empty, delegate(DrawerLayout.IDrawerListener __v)
				{
					this.RemoveDrawerListener(__v);
				}, delegate(DrawerLayout.IDrawerListenerImplementor __h)
				{
					__h.OnDrawerOpenedHandler = (EventHandler<DrawerLayout.DrawerOpenedEventArgs>)Delegate.Remove(__h.OnDrawerOpenedHandler, value);
				});
			}
		}

		// Token: 0x14000003 RID: 3
		// (add) Token: 0x060000D7 RID: 215 RVA: 0x00003AD4 File Offset: 0x00001CD4
		// (remove) Token: 0x060000D8 RID: 216 RVA: 0x00003B20 File Offset: 0x00001D20
		public event EventHandler<DrawerLayout.DrawerSlideEventArgs> DrawerSlide
		{
			add
			{
				EventHelper.AddEventHandler<DrawerLayout.IDrawerListener, DrawerLayout.IDrawerListenerImplementor>(ref this.weak_implementor_AddDrawerListener, new Func<DrawerLayout.IDrawerListenerImplementor>(this.__CreateIDrawerListenerImplementor), new Action<DrawerLayout.IDrawerListener>(this.AddDrawerListener), delegate(DrawerLayout.IDrawerListenerImplementor __h)
				{
					__h.OnDrawerSlideHandler = (EventHandler<DrawerLayout.DrawerSlideEventArgs>)Delegate.Combine(__h.OnDrawerSlideHandler, value);
				});
			}
			remove
			{
				Func<DrawerLayout.IDrawerListenerImplementor, bool> empty;
				if ((empty = DrawerLayout.<>O.<0>____IsEmpty) == null)
				{
					empty = (DrawerLayout.<>O.<0>____IsEmpty = new Func<DrawerLayout.IDrawerListenerImplementor, bool>(DrawerLayout.IDrawerListenerImplementor.__IsEmpty));
				}
				EventHelper.RemoveEventHandler<DrawerLayout.IDrawerListener, DrawerLayout.IDrawerListenerImplementor>(ref this.weak_implementor_AddDrawerListener, empty, delegate(DrawerLayout.IDrawerListener __v)
				{
					this.RemoveDrawerListener(__v);
				}, delegate(DrawerLayout.IDrawerListenerImplementor __h)
				{
					__h.OnDrawerSlideHandler = (EventHandler<DrawerLayout.DrawerSlideEventArgs>)Delegate.Remove(__h.OnDrawerSlideHandler, value);
				});
			}
		}

		// Token: 0x14000004 RID: 4
		// (add) Token: 0x060000D9 RID: 217 RVA: 0x00003B80 File Offset: 0x00001D80
		// (remove) Token: 0x060000DA RID: 218 RVA: 0x00003BCC File Offset: 0x00001DCC
		public event EventHandler<DrawerLayout.DrawerStateChangedEventArgs> DrawerStateChanged
		{
			add
			{
				EventHelper.AddEventHandler<DrawerLayout.IDrawerListener, DrawerLayout.IDrawerListenerImplementor>(ref this.weak_implementor_AddDrawerListener, new Func<DrawerLayout.IDrawerListenerImplementor>(this.__CreateIDrawerListenerImplementor), new Action<DrawerLayout.IDrawerListener>(this.AddDrawerListener), delegate(DrawerLayout.IDrawerListenerImplementor __h)
				{
					__h.OnDrawerStateChangedHandler = (EventHandler<DrawerLayout.DrawerStateChangedEventArgs>)Delegate.Combine(__h.OnDrawerStateChangedHandler, value);
				});
			}
			remove
			{
				Func<DrawerLayout.IDrawerListenerImplementor, bool> empty;
				if ((empty = DrawerLayout.<>O.<0>____IsEmpty) == null)
				{
					empty = (DrawerLayout.<>O.<0>____IsEmpty = new Func<DrawerLayout.IDrawerListenerImplementor, bool>(DrawerLayout.IDrawerListenerImplementor.__IsEmpty));
				}
				EventHelper.RemoveEventHandler<DrawerLayout.IDrawerListener, DrawerLayout.IDrawerListenerImplementor>(ref this.weak_implementor_AddDrawerListener, empty, delegate(DrawerLayout.IDrawerListener __v)
				{
					this.RemoveDrawerListener(__v);
				}, delegate(DrawerLayout.IDrawerListenerImplementor __h)
				{
					__h.OnDrawerStateChangedHandler = (EventHandler<DrawerLayout.DrawerStateChangedEventArgs>)Delegate.Remove(__h.OnDrawerStateChangedHandler, value);
				});
			}
		}

		// Token: 0x060000DB RID: 219 RVA: 0x00003C2B File Offset: 0x00001E2B
		private DrawerLayout.IDrawerListenerImplementor __CreateIDrawerListenerImplementor()
		{
			return new DrawerLayout.IDrawerListenerImplementor(this);
		}

		// Token: 0x04000003 RID: 3
		private static readonly JniPeerMembers _members = new XAPeerMembers("androidx/drawerlayout/widget/DrawerLayout", typeof(DrawerLayout));

		// Token: 0x04000004 RID: 4
		private static Delegate cb_getDrawerElevation;

		// Token: 0x04000005 RID: 5
		private static Delegate cb_setDrawerElevation_F;

		// Token: 0x04000006 RID: 6
		private static Delegate cb_isOpen;

		// Token: 0x04000007 RID: 7
		private static Delegate cb_getStatusBarBackgroundDrawable;

		// Token: 0x04000008 RID: 8
		private static Delegate cb_addDrawerListener_Landroidx_drawerlayout_widget_DrawerLayout_DrawerListener_;

		// Token: 0x04000009 RID: 9
		private static Delegate cb_addFocusables_Ljava_util_ArrayList_II;

		// Token: 0x0400000A RID: 10
		private static Delegate cb_close;

		// Token: 0x0400000B RID: 11
		private static Delegate cb_closeDrawer_Landroid_view_View_;

		// Token: 0x0400000C RID: 12
		private static Delegate cb_closeDrawer_Landroid_view_View_Z;

		// Token: 0x0400000D RID: 13
		private static Delegate cb_closeDrawer_I;

		// Token: 0x0400000E RID: 14
		private static Delegate cb_closeDrawer_IZ;

		// Token: 0x0400000F RID: 15
		private static Delegate cb_closeDrawers;

		// Token: 0x04000010 RID: 16
		private static Delegate cb_getDrawerLockMode_Landroid_view_View_;

		// Token: 0x04000011 RID: 17
		private static Delegate cb_getDrawerLockMode_I;

		// Token: 0x04000012 RID: 18
		private static Delegate cb_getDrawerTitle_I;

		// Token: 0x04000013 RID: 19
		private static Delegate cb_isDrawerOpen_Landroid_view_View_;

		// Token: 0x04000014 RID: 20
		private static Delegate cb_isDrawerOpen_I;

		// Token: 0x04000015 RID: 21
		private static Delegate cb_isDrawerVisible_Landroid_view_View_;

		// Token: 0x04000016 RID: 22
		private static Delegate cb_isDrawerVisible_I;

		// Token: 0x04000017 RID: 23
		private static Delegate cb_onDraw_Landroid_graphics_Canvas_;

		// Token: 0x04000018 RID: 24
		private static Delegate cb_onLayout_ZIIII;

		// Token: 0x04000019 RID: 25
		private static Delegate cb_open;

		// Token: 0x0400001A RID: 26
		private static Delegate cb_openDrawer_Landroid_view_View_;

		// Token: 0x0400001B RID: 27
		private static Delegate cb_openDrawer_Landroid_view_View_Z;

		// Token: 0x0400001C RID: 28
		private static Delegate cb_openDrawer_I;

		// Token: 0x0400001D RID: 29
		private static Delegate cb_openDrawer_IZ;

		// Token: 0x0400001E RID: 30
		private static Delegate cb_removeDrawerListener_Landroidx_drawerlayout_widget_DrawerLayout_DrawerListener_;

		// Token: 0x0400001F RID: 31
		private static Delegate cb_setChildInsets_Landroidx_core_view_WindowInsetsCompat_Z;

		// Token: 0x04000020 RID: 32
		private static Delegate cb_setDrawerListener_Landroidx_drawerlayout_widget_DrawerLayout_DrawerListener_;

		// Token: 0x04000021 RID: 33
		private static Delegate cb_setDrawerLockMode_I;

		// Token: 0x04000022 RID: 34
		private static Delegate cb_setDrawerLockMode_ILandroid_view_View_;

		// Token: 0x04000023 RID: 35
		private static Delegate cb_setDrawerLockMode_II;

		// Token: 0x04000024 RID: 36
		private static Delegate cb_setDrawerShadow_Landroid_graphics_drawable_Drawable_I;

		// Token: 0x04000025 RID: 37
		private static Delegate cb_setDrawerShadow_II;

		// Token: 0x04000026 RID: 38
		private static Delegate cb_setDrawerTitle_ILjava_lang_CharSequence_;

		// Token: 0x04000027 RID: 39
		private static Delegate cb_setScrimColor_I;

		// Token: 0x04000028 RID: 40
		private static Delegate cb_setStatusBarBackground_Landroid_graphics_drawable_Drawable_;

		// Token: 0x04000029 RID: 41
		private static Delegate cb_setStatusBarBackground_I;

		// Token: 0x0400002A RID: 42
		private static Delegate cb_setStatusBarBackgroundColor_I;

		// Token: 0x0400002B RID: 43
		private WeakReference weak_implementor_AddDrawerListener;

		// Token: 0x0200001A RID: 26
		[Register("androidx/drawerlayout/widget/DrawerLayout$DrawerListener", "", "AndroidX.DrawerLayout.Widget.DrawerLayout/IDrawerListenerInvoker")]
		public interface IDrawerListener : IJavaObject, IDisposable, IJavaPeerable
		{
			// Token: 0x060000DD RID: 221
			[Register("onDrawerClosed", "(Landroid/view/View;)V", "GetOnDrawerClosed_Landroid_view_View_Handler:AndroidX.DrawerLayout.Widget.DrawerLayout/IDrawerListenerInvoker, Xamarin.AndroidX.DrawerLayout")]
			void OnDrawerClosed(View drawerView);

			// Token: 0x060000DE RID: 222
			[Register("onDrawerOpened", "(Landroid/view/View;)V", "GetOnDrawerOpened_Landroid_view_View_Handler:AndroidX.DrawerLayout.Widget.DrawerLayout/IDrawerListenerInvoker, Xamarin.AndroidX.DrawerLayout")]
			void OnDrawerOpened(View drawerView);

			// Token: 0x060000DF RID: 223
			[Register("onDrawerSlide", "(Landroid/view/View;F)V", "GetOnDrawerSlide_Landroid_view_View_FHandler:AndroidX.DrawerLayout.Widget.DrawerLayout/IDrawerListenerInvoker, Xamarin.AndroidX.DrawerLayout")]
			void OnDrawerSlide(View drawerView, float slideOffset);

			// Token: 0x060000E0 RID: 224
			[Register("onDrawerStateChanged", "(I)V", "GetOnDrawerStateChanged_IHandler:AndroidX.DrawerLayout.Widget.DrawerLayout/IDrawerListenerInvoker, Xamarin.AndroidX.DrawerLayout")]
			void OnDrawerStateChanged(int newState);
		}

		// Token: 0x0200001B RID: 27
		[Register("androidx/drawerlayout/widget/DrawerLayout$DrawerListener", DoNotGenerateAcw = true)]
		internal class IDrawerListenerInvoker : Java.Lang.Object, DrawerLayout.IDrawerListener, IJavaObject, IDisposable, IJavaPeerable
		{
			// Token: 0x17000008 RID: 8
			// (get) Token: 0x060000E1 RID: 225 RVA: 0x00003C50 File Offset: 0x00001E50
			private static IntPtr java_class_ref
			{
				get
				{
					return DrawerLayout.IDrawerListenerInvoker._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x17000009 RID: 9
			// (get) Token: 0x060000E2 RID: 226 RVA: 0x00003C74 File Offset: 0x00001E74
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return DrawerLayout.IDrawerListenerInvoker._members;
				}
			}

			// Token: 0x1700000A RID: 10
			// (get) Token: 0x060000E3 RID: 227 RVA: 0x00003C7B File Offset: 0x00001E7B
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return this.class_ref;
				}
			}

			// Token: 0x1700000B RID: 11
			// (get) Token: 0x060000E4 RID: 228 RVA: 0x00003C83 File Offset: 0x00001E83
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return DrawerLayout.IDrawerListenerInvoker._members.ManagedPeerType;
				}
			}

			// Token: 0x060000E5 RID: 229 RVA: 0x00003C8F File Offset: 0x00001E8F
			public static DrawerLayout.IDrawerListener GetObject(IntPtr handle, JniHandleOwnership transfer)
			{
				return Java.Lang.Object.GetObject<DrawerLayout.IDrawerListener>(handle, transfer);
			}

			// Token: 0x060000E6 RID: 230 RVA: 0x00003C98 File Offset: 0x00001E98
			private static IntPtr Validate(IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf(handle, DrawerLayout.IDrawerListenerInvoker.java_class_ref))
				{
					throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'androidx.drawerlayout.widget.DrawerLayout.DrawerListener'.");
				}
				return handle;
			}

			// Token: 0x060000E7 RID: 231 RVA: 0x00003CC3 File Offset: 0x00001EC3
			protected override void Dispose(bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
				{
					JNIEnv.DeleteGlobalRef(this.class_ref);
				}
				this.class_ref = IntPtr.Zero;
				base.Dispose(disposing);
			}

			// Token: 0x060000E8 RID: 232 RVA: 0x00003CF4 File Offset: 0x00001EF4
			public IDrawerListenerInvoker(IntPtr handle, JniHandleOwnership transfer) : base(DrawerLayout.IDrawerListenerInvoker.Validate(handle), transfer)
			{
				IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
				this.class_ref = JNIEnv.NewGlobalRef(objectClass);
				JNIEnv.DeleteLocalRef(objectClass);
			}

			// Token: 0x060000E9 RID: 233 RVA: 0x00003D2C File Offset: 0x00001F2C
			private static Delegate GetOnDrawerClosed_Landroid_view_View_Handler()
			{
				if (DrawerLayout.IDrawerListenerInvoker.cb_onDrawerClosed_Landroid_view_View_ == null)
				{
					DrawerLayout.IDrawerListenerInvoker.cb_onDrawerClosed_Landroid_view_View_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(DrawerLayout.IDrawerListenerInvoker.n_OnDrawerClosed_Landroid_view_View_));
				}
				return DrawerLayout.IDrawerListenerInvoker.cb_onDrawerClosed_Landroid_view_View_;
			}

			// Token: 0x060000EA RID: 234 RVA: 0x00003D50 File Offset: 0x00001F50
			private static void n_OnDrawerClosed_Landroid_view_View_(IntPtr jnienv, IntPtr native__this, IntPtr native_drawerView)
			{
				DrawerLayout.IDrawerListener @object = Java.Lang.Object.GetObject<DrawerLayout.IDrawerListener>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				View object2 = Java.Lang.Object.GetObject<View>(native_drawerView, JniHandleOwnership.DoNotTransfer);
				@object.OnDrawerClosed(object2);
			}

			// Token: 0x060000EB RID: 235 RVA: 0x00003D74 File Offset: 0x00001F74
			public unsafe void OnDrawerClosed(View drawerView)
			{
				if (this.id_onDrawerClosed_Landroid_view_View_ == IntPtr.Zero)
				{
					this.id_onDrawerClosed_Landroid_view_View_ = JNIEnv.GetMethodID(this.class_ref, "onDrawerClosed", "(Landroid/view/View;)V");
				}
				JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
				*ptr = new JValue((drawerView == null) ? IntPtr.Zero : drawerView.Handle);
				JNIEnv.CallVoidMethod(base.Handle, this.id_onDrawerClosed_Landroid_view_View_, ptr);
			}

			// Token: 0x060000EC RID: 236 RVA: 0x00003DE7 File Offset: 0x00001FE7
			private static Delegate GetOnDrawerOpened_Landroid_view_View_Handler()
			{
				if (DrawerLayout.IDrawerListenerInvoker.cb_onDrawerOpened_Landroid_view_View_ == null)
				{
					DrawerLayout.IDrawerListenerInvoker.cb_onDrawerOpened_Landroid_view_View_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(DrawerLayout.IDrawerListenerInvoker.n_OnDrawerOpened_Landroid_view_View_));
				}
				return DrawerLayout.IDrawerListenerInvoker.cb_onDrawerOpened_Landroid_view_View_;
			}

			// Token: 0x060000ED RID: 237 RVA: 0x00003E0C File Offset: 0x0000200C
			private static void n_OnDrawerOpened_Landroid_view_View_(IntPtr jnienv, IntPtr native__this, IntPtr native_drawerView)
			{
				DrawerLayout.IDrawerListener @object = Java.Lang.Object.GetObject<DrawerLayout.IDrawerListener>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				View object2 = Java.Lang.Object.GetObject<View>(native_drawerView, JniHandleOwnership.DoNotTransfer);
				@object.OnDrawerOpened(object2);
			}

			// Token: 0x060000EE RID: 238 RVA: 0x00003E30 File Offset: 0x00002030
			public unsafe void OnDrawerOpened(View drawerView)
			{
				if (this.id_onDrawerOpened_Landroid_view_View_ == IntPtr.Zero)
				{
					this.id_onDrawerOpened_Landroid_view_View_ = JNIEnv.GetMethodID(this.class_ref, "onDrawerOpened", "(Landroid/view/View;)V");
				}
				JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
				*ptr = new JValue((drawerView == null) ? IntPtr.Zero : drawerView.Handle);
				JNIEnv.CallVoidMethod(base.Handle, this.id_onDrawerOpened_Landroid_view_View_, ptr);
			}

			// Token: 0x060000EF RID: 239 RVA: 0x00003EA3 File Offset: 0x000020A3
			private static Delegate GetOnDrawerSlide_Landroid_view_View_FHandler()
			{
				if (DrawerLayout.IDrawerListenerInvoker.cb_onDrawerSlide_Landroid_view_View_F == null)
				{
					DrawerLayout.IDrawerListenerInvoker.cb_onDrawerSlide_Landroid_view_View_F = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLF_V(DrawerLayout.IDrawerListenerInvoker.n_OnDrawerSlide_Landroid_view_View_F));
				}
				return DrawerLayout.IDrawerListenerInvoker.cb_onDrawerSlide_Landroid_view_View_F;
			}

			// Token: 0x060000F0 RID: 240 RVA: 0x00003EC8 File Offset: 0x000020C8
			private static void n_OnDrawerSlide_Landroid_view_View_F(IntPtr jnienv, IntPtr native__this, IntPtr native_drawerView, float slideOffset)
			{
				DrawerLayout.IDrawerListener @object = Java.Lang.Object.GetObject<DrawerLayout.IDrawerListener>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				View object2 = Java.Lang.Object.GetObject<View>(native_drawerView, JniHandleOwnership.DoNotTransfer);
				@object.OnDrawerSlide(object2, slideOffset);
			}

			// Token: 0x060000F1 RID: 241 RVA: 0x00003EEC File Offset: 0x000020EC
			public unsafe void OnDrawerSlide(View drawerView, float slideOffset)
			{
				if (this.id_onDrawerSlide_Landroid_view_View_F == IntPtr.Zero)
				{
					this.id_onDrawerSlide_Landroid_view_View_F = JNIEnv.GetMethodID(this.class_ref, "onDrawerSlide", "(Landroid/view/View;F)V");
				}
				JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JValue))];
				*ptr = new JValue((drawerView == null) ? IntPtr.Zero : drawerView.Handle);
				ptr[1] = new JValue(slideOffset);
				JNIEnv.CallVoidMethod(base.Handle, this.id_onDrawerSlide_Landroid_view_View_F, ptr);
			}

			// Token: 0x060000F2 RID: 242 RVA: 0x00003F72 File Offset: 0x00002172
			private static Delegate GetOnDrawerStateChanged_IHandler()
			{
				if (DrawerLayout.IDrawerListenerInvoker.cb_onDrawerStateChanged_I == null)
				{
					DrawerLayout.IDrawerListenerInvoker.cb_onDrawerStateChanged_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_V(DrawerLayout.IDrawerListenerInvoker.n_OnDrawerStateChanged_I));
				}
				return DrawerLayout.IDrawerListenerInvoker.cb_onDrawerStateChanged_I;
			}

			// Token: 0x060000F3 RID: 243 RVA: 0x00003F96 File Offset: 0x00002196
			private static void n_OnDrawerStateChanged_I(IntPtr jnienv, IntPtr native__this, int newState)
			{
				Java.Lang.Object.GetObject<DrawerLayout.IDrawerListener>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).OnDrawerStateChanged(newState);
			}

			// Token: 0x060000F4 RID: 244 RVA: 0x00003FA8 File Offset: 0x000021A8
			public unsafe void OnDrawerStateChanged(int newState)
			{
				if (this.id_onDrawerStateChanged_I == IntPtr.Zero)
				{
					this.id_onDrawerStateChanged_I = JNIEnv.GetMethodID(this.class_ref, "onDrawerStateChanged", "(I)V");
				}
				JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
				*ptr = new JValue(newState);
				JNIEnv.CallVoidMethod(base.Handle, this.id_onDrawerStateChanged_I, ptr);
			}

			// Token: 0x0400002C RID: 44
			private static readonly JniPeerMembers _members = new XAPeerMembers("androidx/drawerlayout/widget/DrawerLayout$DrawerListener", typeof(DrawerLayout.IDrawerListenerInvoker));

			// Token: 0x0400002D RID: 45
			private IntPtr class_ref;

			// Token: 0x0400002E RID: 46
			private static Delegate cb_onDrawerClosed_Landroid_view_View_;

			// Token: 0x0400002F RID: 47
			private IntPtr id_onDrawerClosed_Landroid_view_View_;

			// Token: 0x04000030 RID: 48
			private static Delegate cb_onDrawerOpened_Landroid_view_View_;

			// Token: 0x04000031 RID: 49
			private IntPtr id_onDrawerOpened_Landroid_view_View_;

			// Token: 0x04000032 RID: 50
			private static Delegate cb_onDrawerSlide_Landroid_view_View_F;

			// Token: 0x04000033 RID: 51
			private IntPtr id_onDrawerSlide_Landroid_view_View_F;

			// Token: 0x04000034 RID: 52
			private static Delegate cb_onDrawerStateChanged_I;

			// Token: 0x04000035 RID: 53
			private IntPtr id_onDrawerStateChanged_I;
		}

		// Token: 0x0200001C RID: 28
		public class DrawerClosedEventArgs : EventArgs
		{
			// Token: 0x060000F6 RID: 246 RVA: 0x00004027 File Offset: 0x00002227
			public DrawerClosedEventArgs(View drawerView)
			{
				this.drawerView = drawerView;
			}

			// Token: 0x04000036 RID: 54
			private View drawerView;
		}

		// Token: 0x0200001D RID: 29
		public class DrawerOpenedEventArgs : EventArgs
		{
			// Token: 0x060000F7 RID: 247 RVA: 0x00004036 File Offset: 0x00002236
			public DrawerOpenedEventArgs(View drawerView)
			{
				this.drawerView = drawerView;
			}

			// Token: 0x04000037 RID: 55
			private View drawerView;
		}

		// Token: 0x0200001E RID: 30
		public class DrawerSlideEventArgs : EventArgs
		{
			// Token: 0x060000F8 RID: 248 RVA: 0x00004045 File Offset: 0x00002245
			public DrawerSlideEventArgs(View drawerView, float slideOffset)
			{
				this.drawerView = drawerView;
				this.slideOffset = slideOffset;
			}

			// Token: 0x04000038 RID: 56
			private View drawerView;

			// Token: 0x04000039 RID: 57
			private float slideOffset;
		}

		// Token: 0x0200001F RID: 31
		public class DrawerStateChangedEventArgs : EventArgs
		{
			// Token: 0x060000F9 RID: 249 RVA: 0x0000405B File Offset: 0x0000225B
			public DrawerStateChangedEventArgs(int newState)
			{
				this.newState = newState;
			}

			// Token: 0x0400003A RID: 58
			private int newState;
		}

		// Token: 0x02000020 RID: 32
		[Register("mono/androidx/drawerlayout/widget/DrawerLayout_DrawerListenerImplementor")]
		internal sealed class IDrawerListenerImplementor : Java.Lang.Object, DrawerLayout.IDrawerListener, IJavaObject, IDisposable, IJavaPeerable
		{
			// Token: 0x060000FA RID: 250 RVA: 0x0000406A File Offset: 0x0000226A
			public IDrawerListenerImplementor(object sender) : base(JNIEnv.StartCreateInstance("mono/androidx/drawerlayout/widget/DrawerLayout_DrawerListenerImplementor", "()V", Array.Empty<JValue>()), JniHandleOwnership.TransferLocalRef)
			{
				JNIEnv.FinishCreateInstance(base.Handle, "()V", Array.Empty<JValue>());
				this.sender = sender;
			}

			// Token: 0x060000FB RID: 251 RVA: 0x000040A4 File Offset: 0x000022A4
			public void OnDrawerClosed(View drawerView)
			{
				EventHandler<DrawerLayout.DrawerClosedEventArgs> onDrawerClosedHandler = this.OnDrawerClosedHandler;
				if (onDrawerClosedHandler != null)
				{
					onDrawerClosedHandler(this.sender, new DrawerLayout.DrawerClosedEventArgs(drawerView));
				}
			}

			// Token: 0x060000FC RID: 252 RVA: 0x000040D0 File Offset: 0x000022D0
			public void OnDrawerOpened(View drawerView)
			{
				EventHandler<DrawerLayout.DrawerOpenedEventArgs> onDrawerOpenedHandler = this.OnDrawerOpenedHandler;
				if (onDrawerOpenedHandler != null)
				{
					onDrawerOpenedHandler(this.sender, new DrawerLayout.DrawerOpenedEventArgs(drawerView));
				}
			}

			// Token: 0x060000FD RID: 253 RVA: 0x000040FC File Offset: 0x000022FC
			public void OnDrawerSlide(View drawerView, float slideOffset)
			{
				EventHandler<DrawerLayout.DrawerSlideEventArgs> onDrawerSlideHandler = this.OnDrawerSlideHandler;
				if (onDrawerSlideHandler != null)
				{
					onDrawerSlideHandler(this.sender, new DrawerLayout.DrawerSlideEventArgs(drawerView, slideOffset));
				}
			}

			// Token: 0x060000FE RID: 254 RVA: 0x00004128 File Offset: 0x00002328
			public void OnDrawerStateChanged(int newState)
			{
				EventHandler<DrawerLayout.DrawerStateChangedEventArgs> onDrawerStateChangedHandler = this.OnDrawerStateChangedHandler;
				if (onDrawerStateChangedHandler != null)
				{
					onDrawerStateChangedHandler(this.sender, new DrawerLayout.DrawerStateChangedEventArgs(newState));
				}
			}

			// Token: 0x060000FF RID: 255 RVA: 0x00004151 File Offset: 0x00002351
			internal static bool __IsEmpty(DrawerLayout.IDrawerListenerImplementor value)
			{
				return value.OnDrawerClosedHandler == null && value.OnDrawerOpenedHandler == null && value.OnDrawerSlideHandler == null && value.OnDrawerStateChangedHandler == null;
			}

			// Token: 0x0400003B RID: 59
			private object sender;

			// Token: 0x0400003C RID: 60
			public EventHandler<DrawerLayout.DrawerClosedEventArgs> OnDrawerClosedHandler;

			// Token: 0x0400003D RID: 61
			public EventHandler<DrawerLayout.DrawerOpenedEventArgs> OnDrawerOpenedHandler;

			// Token: 0x0400003E RID: 62
			public EventHandler<DrawerLayout.DrawerSlideEventArgs> OnDrawerSlideHandler;

			// Token: 0x0400003F RID: 63
			public EventHandler<DrawerLayout.DrawerStateChangedEventArgs> OnDrawerStateChangedHandler;
		}

		// Token: 0x02000021 RID: 33
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04000040 RID: 64
			public static Func<DrawerLayout.IDrawerListenerImplementor, bool> <0>____IsEmpty;
		}
	}
}
