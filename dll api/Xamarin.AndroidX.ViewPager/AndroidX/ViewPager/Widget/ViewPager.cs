using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Content;
using Android.Graphics.Drawables;
using Android.OS;
using Android.Runtime;
using Android.Util;
using Android.Views;
using Java.Interop;
using Java.Lang;

namespace AndroidX.ViewPager.Widget
{
	// Token: 0x02000020 RID: 32
	[Register("androidx/viewpager/widget/ViewPager", DoNotGenerateAcw = true)]
	public class ViewPager : ViewGroup
	{
		// Token: 0x17000009 RID: 9
		// (get) Token: 0x060000B2 RID: 178 RVA: 0x00002FC8 File Offset: 0x000011C8
		internal static IntPtr class_ref
		{
			get
			{
				return ViewPager._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x060000B3 RID: 179 RVA: 0x00002FEC File Offset: 0x000011EC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return ViewPager._members;
			}
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x060000B4 RID: 180 RVA: 0x00002FF4 File Offset: 0x000011F4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return ViewPager._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x060000B5 RID: 181 RVA: 0x00003018 File Offset: 0x00001218
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return ViewPager._members.ManagedPeerType;
			}
		}

		// Token: 0x060000B6 RID: 182 RVA: 0x00003024 File Offset: 0x00001224
		protected ViewPager(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x060000B7 RID: 183 RVA: 0x00003030 File Offset: 0x00001230
		[Register(".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe ViewPager(Context context) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((context == null) ? IntPtr.Zero : context.Handle);
				base.SetHandle(ViewPager._members.InstanceMethods.StartCreateInstance("(Landroid/content/Context;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				ViewPager._members.InstanceMethods.FinishCreateInstance("(Landroid/content/Context;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(context);
			}
		}

		// Token: 0x060000B8 RID: 184 RVA: 0x000030E0 File Offset: 0x000012E0
		[Register(".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", "")]
		public unsafe ViewPager(Context context, IAttributeSet attrs) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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
				base.SetHandle(ViewPager._members.InstanceMethods.StartCreateInstance("(Landroid/content/Context;Landroid/util/AttributeSet;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				ViewPager._members.InstanceMethods.FinishCreateInstance("(Landroid/content/Context;Landroid/util/AttributeSet;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(context);
				GC.KeepAlive(attrs);
			}
		}

		// Token: 0x060000B9 RID: 185 RVA: 0x000031BC File Offset: 0x000013BC
		private static Delegate GetGetAdapterHandler()
		{
			if (ViewPager.cb_getAdapter == null)
			{
				ViewPager.cb_getAdapter = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(ViewPager.n_GetAdapter));
			}
			return ViewPager.cb_getAdapter;
		}

		// Token: 0x060000BA RID: 186 RVA: 0x000031E0 File Offset: 0x000013E0
		private static IntPtr n_GetAdapter(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<ViewPager>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Adapter);
		}

		// Token: 0x060000BB RID: 187 RVA: 0x000031F4 File Offset: 0x000013F4
		private static Delegate GetSetAdapter_Landroidx_viewpager_widget_PagerAdapter_Handler()
		{
			if (ViewPager.cb_setAdapter_Landroidx_viewpager_widget_PagerAdapter_ == null)
			{
				ViewPager.cb_setAdapter_Landroidx_viewpager_widget_PagerAdapter_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(ViewPager.n_SetAdapter_Landroidx_viewpager_widget_PagerAdapter_));
			}
			return ViewPager.cb_setAdapter_Landroidx_viewpager_widget_PagerAdapter_;
		}

		// Token: 0x060000BC RID: 188 RVA: 0x00003218 File Offset: 0x00001418
		private static void n_SetAdapter_Landroidx_viewpager_widget_PagerAdapter_(IntPtr jnienv, IntPtr native__this, IntPtr native_adapter)
		{
			ViewPager @object = Java.Lang.Object.GetObject<ViewPager>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			PagerAdapter object2 = Java.Lang.Object.GetObject<PagerAdapter>(native_adapter, JniHandleOwnership.DoNotTransfer);
			@object.Adapter = object2;
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x060000BD RID: 189 RVA: 0x0000323C File Offset: 0x0000143C
		// (set) Token: 0x060000BE RID: 190 RVA: 0x00003270 File Offset: 0x00001470
		public unsafe virtual PagerAdapter Adapter
		{
			[Register("getAdapter", "()Landroidx/viewpager/widget/PagerAdapter;", "GetGetAdapterHandler")]
			get
			{
				return Java.Lang.Object.GetObject<PagerAdapter>(ViewPager._members.InstanceMethods.InvokeVirtualObjectMethod("getAdapter.()Landroidx/viewpager/widget/PagerAdapter;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
			[Register("setAdapter", "(Landroidx/viewpager/widget/PagerAdapter;)V", "GetSetAdapter_Landroidx_viewpager_widget_PagerAdapter_Handler")]
			set
			{
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((value == null) ? IntPtr.Zero : value.Handle);
					ViewPager._members.InstanceMethods.InvokeVirtualVoidMethod("setAdapter.(Landroidx/viewpager/widget/PagerAdapter;)V", this, ptr);
				}
				finally
				{
					GC.KeepAlive(value);
				}
			}
		}

		// Token: 0x060000BF RID: 191 RVA: 0x000032D4 File Offset: 0x000014D4
		private static Delegate GetGetCurrentItemHandler()
		{
			if (ViewPager.cb_getCurrentItem == null)
			{
				ViewPager.cb_getCurrentItem = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(ViewPager.n_GetCurrentItem));
			}
			return ViewPager.cb_getCurrentItem;
		}

		// Token: 0x060000C0 RID: 192 RVA: 0x000032F8 File Offset: 0x000014F8
		private static int n_GetCurrentItem(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<ViewPager>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).CurrentItem;
		}

		// Token: 0x060000C1 RID: 193 RVA: 0x00003307 File Offset: 0x00001507
		private static Delegate GetSetCurrentItem_IHandler()
		{
			if (ViewPager.cb_setCurrentItem_I == null)
			{
				ViewPager.cb_setCurrentItem_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_V(ViewPager.n_SetCurrentItem_I));
			}
			return ViewPager.cb_setCurrentItem_I;
		}

		// Token: 0x060000C2 RID: 194 RVA: 0x0000332B File Offset: 0x0000152B
		private static void n_SetCurrentItem_I(IntPtr jnienv, IntPtr native__this, int item)
		{
			Java.Lang.Object.GetObject<ViewPager>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).CurrentItem = item;
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x060000C3 RID: 195 RVA: 0x0000333B File Offset: 0x0000153B
		// (set) Token: 0x060000C4 RID: 196 RVA: 0x00003354 File Offset: 0x00001554
		public unsafe virtual int CurrentItem
		{
			[Register("getCurrentItem", "()I", "GetGetCurrentItemHandler")]
			get
			{
				return ViewPager._members.InstanceMethods.InvokeVirtualInt32Method("getCurrentItem.()I", this, null);
			}
			[Register("setCurrentItem", "(I)V", "GetSetCurrentItem_IHandler")]
			set
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(value);
				ViewPager._members.InstanceMethods.InvokeVirtualVoidMethod("setCurrentItem.(I)V", this, ptr);
			}
		}

		// Token: 0x060000C5 RID: 197 RVA: 0x0000338F File Offset: 0x0000158F
		private static Delegate GetIsFakeDraggingHandler()
		{
			if (ViewPager.cb_isFakeDragging == null)
			{
				ViewPager.cb_isFakeDragging = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(ViewPager.n_IsFakeDragging));
			}
			return ViewPager.cb_isFakeDragging;
		}

		// Token: 0x060000C6 RID: 198 RVA: 0x000033B3 File Offset: 0x000015B3
		private static bool n_IsFakeDragging(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<ViewPager>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsFakeDragging;
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x060000C7 RID: 199 RVA: 0x000033C2 File Offset: 0x000015C2
		public virtual bool IsFakeDragging
		{
			[Register("isFakeDragging", "()Z", "GetIsFakeDraggingHandler")]
			get
			{
				return ViewPager._members.InstanceMethods.InvokeVirtualBooleanMethod("isFakeDragging.()Z", this, null);
			}
		}

		// Token: 0x060000C8 RID: 200 RVA: 0x000033DB File Offset: 0x000015DB
		private static Delegate GetGetOffscreenPageLimitHandler()
		{
			if (ViewPager.cb_getOffscreenPageLimit == null)
			{
				ViewPager.cb_getOffscreenPageLimit = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(ViewPager.n_GetOffscreenPageLimit));
			}
			return ViewPager.cb_getOffscreenPageLimit;
		}

		// Token: 0x060000C9 RID: 201 RVA: 0x000033FF File Offset: 0x000015FF
		private static int n_GetOffscreenPageLimit(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<ViewPager>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).OffscreenPageLimit;
		}

		// Token: 0x060000CA RID: 202 RVA: 0x0000340E File Offset: 0x0000160E
		private static Delegate GetSetOffscreenPageLimit_IHandler()
		{
			if (ViewPager.cb_setOffscreenPageLimit_I == null)
			{
				ViewPager.cb_setOffscreenPageLimit_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_V(ViewPager.n_SetOffscreenPageLimit_I));
			}
			return ViewPager.cb_setOffscreenPageLimit_I;
		}

		// Token: 0x060000CB RID: 203 RVA: 0x00003432 File Offset: 0x00001632
		private static void n_SetOffscreenPageLimit_I(IntPtr jnienv, IntPtr native__this, int limit)
		{
			Java.Lang.Object.GetObject<ViewPager>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).OffscreenPageLimit = limit;
		}

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x060000CC RID: 204 RVA: 0x00003442 File Offset: 0x00001642
		// (set) Token: 0x060000CD RID: 205 RVA: 0x0000345C File Offset: 0x0000165C
		public unsafe virtual int OffscreenPageLimit
		{
			[Register("getOffscreenPageLimit", "()I", "GetGetOffscreenPageLimitHandler")]
			get
			{
				return ViewPager._members.InstanceMethods.InvokeVirtualInt32Method("getOffscreenPageLimit.()I", this, null);
			}
			[Register("setOffscreenPageLimit", "(I)V", "GetSetOffscreenPageLimit_IHandler")]
			set
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(value);
				ViewPager._members.InstanceMethods.InvokeVirtualVoidMethod("setOffscreenPageLimit.(I)V", this, ptr);
			}
		}

		// Token: 0x060000CE RID: 206 RVA: 0x00003497 File Offset: 0x00001697
		private static Delegate GetGetPageMarginHandler()
		{
			if (ViewPager.cb_getPageMargin == null)
			{
				ViewPager.cb_getPageMargin = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(ViewPager.n_GetPageMargin));
			}
			return ViewPager.cb_getPageMargin;
		}

		// Token: 0x060000CF RID: 207 RVA: 0x000034BB File Offset: 0x000016BB
		private static int n_GetPageMargin(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<ViewPager>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).PageMargin;
		}

		// Token: 0x060000D0 RID: 208 RVA: 0x000034CA File Offset: 0x000016CA
		private static Delegate GetSetPageMargin_IHandler()
		{
			if (ViewPager.cb_setPageMargin_I == null)
			{
				ViewPager.cb_setPageMargin_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_V(ViewPager.n_SetPageMargin_I));
			}
			return ViewPager.cb_setPageMargin_I;
		}

		// Token: 0x060000D1 RID: 209 RVA: 0x000034EE File Offset: 0x000016EE
		private static void n_SetPageMargin_I(IntPtr jnienv, IntPtr native__this, int marginPixels)
		{
			Java.Lang.Object.GetObject<ViewPager>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).PageMargin = marginPixels;
		}

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x060000D2 RID: 210 RVA: 0x000034FE File Offset: 0x000016FE
		// (set) Token: 0x060000D3 RID: 211 RVA: 0x00003518 File Offset: 0x00001718
		public unsafe virtual int PageMargin
		{
			[Register("getPageMargin", "()I", "GetGetPageMarginHandler")]
			get
			{
				return ViewPager._members.InstanceMethods.InvokeVirtualInt32Method("getPageMargin.()I", this, null);
			}
			[Register("setPageMargin", "(I)V", "GetSetPageMargin_IHandler")]
			set
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(value);
				ViewPager._members.InstanceMethods.InvokeVirtualVoidMethod("setPageMargin.(I)V", this, ptr);
			}
		}

		// Token: 0x060000D4 RID: 212 RVA: 0x00003553 File Offset: 0x00001753
		private static Delegate GetAddFocusables_Ljava_util_ArrayList_IIHandler()
		{
			if (ViewPager.cb_addFocusables_Ljava_util_ArrayList_II == null)
			{
				ViewPager.cb_addFocusables_Ljava_util_ArrayList_II = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLII_V(ViewPager.n_AddFocusables_Ljava_util_ArrayList_II));
			}
			return ViewPager.cb_addFocusables_Ljava_util_ArrayList_II;
		}

		// Token: 0x060000D5 RID: 213 RVA: 0x00003578 File Offset: 0x00001778
		private static void n_AddFocusables_Ljava_util_ArrayList_II(IntPtr jnienv, IntPtr native__this, IntPtr native_views, int direction, int focusableMode)
		{
			ViewPager @object = Java.Lang.Object.GetObject<ViewPager>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IList<View> views = JavaList<View>.FromJniHandle(native_views, JniHandleOwnership.DoNotTransfer);
			@object.AddFocusables(views, direction, focusableMode);
		}

		// Token: 0x060000D6 RID: 214 RVA: 0x000035A0 File Offset: 0x000017A0
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
				ViewPager._members.InstanceMethods.InvokeVirtualVoidMethod("addFocusables.(Ljava/util/ArrayList;II)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(views);
			}
		}

		// Token: 0x060000D7 RID: 215 RVA: 0x0000362C File Offset: 0x0000182C
		private static Delegate GetAddOnAdapterChangeListener_Landroidx_viewpager_widget_ViewPager_OnAdapterChangeListener_Handler()
		{
			if (ViewPager.cb_addOnAdapterChangeListener_Landroidx_viewpager_widget_ViewPager_OnAdapterChangeListener_ == null)
			{
				ViewPager.cb_addOnAdapterChangeListener_Landroidx_viewpager_widget_ViewPager_OnAdapterChangeListener_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(ViewPager.n_AddOnAdapterChangeListener_Landroidx_viewpager_widget_ViewPager_OnAdapterChangeListener_));
			}
			return ViewPager.cb_addOnAdapterChangeListener_Landroidx_viewpager_widget_ViewPager_OnAdapterChangeListener_;
		}

		// Token: 0x060000D8 RID: 216 RVA: 0x00003650 File Offset: 0x00001850
		private static void n_AddOnAdapterChangeListener_Landroidx_viewpager_widget_ViewPager_OnAdapterChangeListener_(IntPtr jnienv, IntPtr native__this, IntPtr native_listener)
		{
			ViewPager @object = Java.Lang.Object.GetObject<ViewPager>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ViewPager.IOnAdapterChangeListener object2 = Java.Lang.Object.GetObject<ViewPager.IOnAdapterChangeListener>(native_listener, JniHandleOwnership.DoNotTransfer);
			@object.AddOnAdapterChangeListener(object2);
		}

		// Token: 0x060000D9 RID: 217 RVA: 0x00003674 File Offset: 0x00001874
		[Register("addOnAdapterChangeListener", "(Landroidx/viewpager/widget/ViewPager$OnAdapterChangeListener;)V", "GetAddOnAdapterChangeListener_Landroidx_viewpager_widget_ViewPager_OnAdapterChangeListener_Handler")]
		public unsafe virtual void AddOnAdapterChangeListener(ViewPager.IOnAdapterChangeListener listener)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((listener == null) ? IntPtr.Zero : ((Java.Lang.Object)listener).Handle);
				ViewPager._members.InstanceMethods.InvokeVirtualVoidMethod("addOnAdapterChangeListener.(Landroidx/viewpager/widget/ViewPager$OnAdapterChangeListener;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(listener);
			}
		}

		// Token: 0x060000DA RID: 218 RVA: 0x000036DC File Offset: 0x000018DC
		private static Delegate GetAddOnPageChangeListener_Landroidx_viewpager_widget_ViewPager_OnPageChangeListener_Handler()
		{
			if (ViewPager.cb_addOnPageChangeListener_Landroidx_viewpager_widget_ViewPager_OnPageChangeListener_ == null)
			{
				ViewPager.cb_addOnPageChangeListener_Landroidx_viewpager_widget_ViewPager_OnPageChangeListener_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(ViewPager.n_AddOnPageChangeListener_Landroidx_viewpager_widget_ViewPager_OnPageChangeListener_));
			}
			return ViewPager.cb_addOnPageChangeListener_Landroidx_viewpager_widget_ViewPager_OnPageChangeListener_;
		}

		// Token: 0x060000DB RID: 219 RVA: 0x00003700 File Offset: 0x00001900
		private static void n_AddOnPageChangeListener_Landroidx_viewpager_widget_ViewPager_OnPageChangeListener_(IntPtr jnienv, IntPtr native__this, IntPtr native_listener)
		{
			ViewPager @object = Java.Lang.Object.GetObject<ViewPager>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ViewPager.IOnPageChangeListener object2 = Java.Lang.Object.GetObject<ViewPager.IOnPageChangeListener>(native_listener, JniHandleOwnership.DoNotTransfer);
			@object.AddOnPageChangeListener(object2);
		}

		// Token: 0x060000DC RID: 220 RVA: 0x00003724 File Offset: 0x00001924
		[Register("addOnPageChangeListener", "(Landroidx/viewpager/widget/ViewPager$OnPageChangeListener;)V", "GetAddOnPageChangeListener_Landroidx_viewpager_widget_ViewPager_OnPageChangeListener_Handler")]
		public unsafe virtual void AddOnPageChangeListener(ViewPager.IOnPageChangeListener listener)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((listener == null) ? IntPtr.Zero : ((Java.Lang.Object)listener).Handle);
				ViewPager._members.InstanceMethods.InvokeVirtualVoidMethod("addOnPageChangeListener.(Landroidx/viewpager/widget/ViewPager$OnPageChangeListener;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(listener);
			}
		}

		// Token: 0x060000DD RID: 221 RVA: 0x0000378C File Offset: 0x0000198C
		private static Delegate GetAddTouchables_Ljava_util_ArrayList_Handler()
		{
			if (ViewPager.cb_addTouchables_Ljava_util_ArrayList_ == null)
			{
				ViewPager.cb_addTouchables_Ljava_util_ArrayList_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(ViewPager.n_AddTouchables_Ljava_util_ArrayList_));
			}
			return ViewPager.cb_addTouchables_Ljava_util_ArrayList_;
		}

		// Token: 0x060000DE RID: 222 RVA: 0x000037B0 File Offset: 0x000019B0
		private static void n_AddTouchables_Ljava_util_ArrayList_(IntPtr jnienv, IntPtr native__this, IntPtr native_views)
		{
			ViewPager @object = Java.Lang.Object.GetObject<ViewPager>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IList<View> views = JavaList<View>.FromJniHandle(native_views, JniHandleOwnership.DoNotTransfer);
			@object.AddTouchables(views);
		}

		// Token: 0x060000DF RID: 223 RVA: 0x000037D4 File Offset: 0x000019D4
		[Register("addTouchables", "(Ljava/util/ArrayList;)V", "GetAddTouchables_Ljava_util_ArrayList_Handler")]
		public new unsafe virtual void AddTouchables(IList<View> views)
		{
			IntPtr intPtr = JavaList<View>.ToLocalJniHandle(views);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ViewPager._members.InstanceMethods.InvokeVirtualVoidMethod("addTouchables.(Ljava/util/ArrayList;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(views);
			}
		}

		// Token: 0x060000E0 RID: 224 RVA: 0x00003838 File Offset: 0x00001A38
		private static Delegate GetArrowScroll_IHandler()
		{
			if (ViewPager.cb_arrowScroll_I == null)
			{
				ViewPager.cb_arrowScroll_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_Z(ViewPager.n_ArrowScroll_I));
			}
			return ViewPager.cb_arrowScroll_I;
		}

		// Token: 0x060000E1 RID: 225 RVA: 0x0000385C File Offset: 0x00001A5C
		private static bool n_ArrowScroll_I(IntPtr jnienv, IntPtr native__this, int direction)
		{
			return Java.Lang.Object.GetObject<ViewPager>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ArrowScroll(direction);
		}

		// Token: 0x060000E2 RID: 226 RVA: 0x0000386C File Offset: 0x00001A6C
		[Register("arrowScroll", "(I)Z", "GetArrowScroll_IHandler")]
		public unsafe virtual bool ArrowScroll(int direction)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(direction);
			return ViewPager._members.InstanceMethods.InvokeVirtualBooleanMethod("arrowScroll.(I)Z", this, ptr);
		}

		// Token: 0x060000E3 RID: 227 RVA: 0x000038A7 File Offset: 0x00001AA7
		private static Delegate GetBeginFakeDragHandler()
		{
			if (ViewPager.cb_beginFakeDrag == null)
			{
				ViewPager.cb_beginFakeDrag = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(ViewPager.n_BeginFakeDrag));
			}
			return ViewPager.cb_beginFakeDrag;
		}

		// Token: 0x060000E4 RID: 228 RVA: 0x000038CB File Offset: 0x00001ACB
		private static bool n_BeginFakeDrag(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<ViewPager>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).BeginFakeDrag();
		}

		// Token: 0x060000E5 RID: 229 RVA: 0x000038DA File Offset: 0x00001ADA
		[Register("beginFakeDrag", "()Z", "GetBeginFakeDragHandler")]
		public virtual bool BeginFakeDrag()
		{
			return ViewPager._members.InstanceMethods.InvokeVirtualBooleanMethod("beginFakeDrag.()Z", this, null);
		}

		// Token: 0x060000E6 RID: 230 RVA: 0x000038F3 File Offset: 0x00001AF3
		private static Delegate GetCanScroll_Landroid_view_View_ZIIIHandler()
		{
			if (ViewPager.cb_canScroll_Landroid_view_View_ZIII == null)
			{
				ViewPager.cb_canScroll_Landroid_view_View_ZIII = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLZIII_Z(ViewPager.n_CanScroll_Landroid_view_View_ZIII));
			}
			return ViewPager.cb_canScroll_Landroid_view_View_ZIII;
		}

		// Token: 0x060000E7 RID: 231 RVA: 0x00003918 File Offset: 0x00001B18
		private static bool n_CanScroll_Landroid_view_View_ZIII(IntPtr jnienv, IntPtr native__this, IntPtr native_v, bool checkV, int dx, int x, int y)
		{
			ViewPager @object = Java.Lang.Object.GetObject<ViewPager>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			View object2 = Java.Lang.Object.GetObject<View>(native_v, JniHandleOwnership.DoNotTransfer);
			return @object.CanScroll(object2, checkV, dx, x, y);
		}

		// Token: 0x060000E8 RID: 232 RVA: 0x00003944 File Offset: 0x00001B44
		[Register("canScroll", "(Landroid/view/View;ZIII)Z", "GetCanScroll_Landroid_view_View_ZIIIHandler")]
		protected unsafe virtual bool CanScroll(View v, bool checkV, int dx, int x, int y)
		{
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((v == null) ? IntPtr.Zero : v.Handle);
				ptr[1] = new JniArgumentValue(checkV);
				ptr[2] = new JniArgumentValue(dx);
				ptr[3] = new JniArgumentValue(x);
				ptr[4] = new JniArgumentValue(y);
				result = ViewPager._members.InstanceMethods.InvokeVirtualBooleanMethod("canScroll.(Landroid/view/View;ZIII)Z", this, ptr);
			}
			finally
			{
				GC.KeepAlive(v);
			}
			return result;
		}

		// Token: 0x060000E9 RID: 233 RVA: 0x00003A00 File Offset: 0x00001C00
		private static Delegate GetClearOnPageChangeListenersHandler()
		{
			if (ViewPager.cb_clearOnPageChangeListeners == null)
			{
				ViewPager.cb_clearOnPageChangeListeners = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(ViewPager.n_ClearOnPageChangeListeners));
			}
			return ViewPager.cb_clearOnPageChangeListeners;
		}

		// Token: 0x060000EA RID: 234 RVA: 0x00003A24 File Offset: 0x00001C24
		private static void n_ClearOnPageChangeListeners(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<ViewPager>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ClearOnPageChangeListeners();
		}

		// Token: 0x060000EB RID: 235 RVA: 0x00003A33 File Offset: 0x00001C33
		[Register("clearOnPageChangeListeners", "()V", "GetClearOnPageChangeListenersHandler")]
		public virtual void ClearOnPageChangeListeners()
		{
			ViewPager._members.InstanceMethods.InvokeVirtualVoidMethod("clearOnPageChangeListeners.()V", this, null);
		}

		// Token: 0x060000EC RID: 236 RVA: 0x00003A4C File Offset: 0x00001C4C
		private static Delegate GetEndFakeDragHandler()
		{
			if (ViewPager.cb_endFakeDrag == null)
			{
				ViewPager.cb_endFakeDrag = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(ViewPager.n_EndFakeDrag));
			}
			return ViewPager.cb_endFakeDrag;
		}

		// Token: 0x060000ED RID: 237 RVA: 0x00003A70 File Offset: 0x00001C70
		private static void n_EndFakeDrag(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<ViewPager>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).EndFakeDrag();
		}

		// Token: 0x060000EE RID: 238 RVA: 0x00003A7F File Offset: 0x00001C7F
		[Register("endFakeDrag", "()V", "GetEndFakeDragHandler")]
		public virtual void EndFakeDrag()
		{
			ViewPager._members.InstanceMethods.InvokeVirtualVoidMethod("endFakeDrag.()V", this, null);
		}

		// Token: 0x060000EF RID: 239 RVA: 0x00003A98 File Offset: 0x00001C98
		private static Delegate GetExecuteKeyEvent_Landroid_view_KeyEvent_Handler()
		{
			if (ViewPager.cb_executeKeyEvent_Landroid_view_KeyEvent_ == null)
			{
				ViewPager.cb_executeKeyEvent_Landroid_view_KeyEvent_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_Z(ViewPager.n_ExecuteKeyEvent_Landroid_view_KeyEvent_));
			}
			return ViewPager.cb_executeKeyEvent_Landroid_view_KeyEvent_;
		}

		// Token: 0x060000F0 RID: 240 RVA: 0x00003ABC File Offset: 0x00001CBC
		private static bool n_ExecuteKeyEvent_Landroid_view_KeyEvent_(IntPtr jnienv, IntPtr native__this, IntPtr native_e)
		{
			ViewPager @object = Java.Lang.Object.GetObject<ViewPager>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			KeyEvent object2 = Java.Lang.Object.GetObject<KeyEvent>(native_e, JniHandleOwnership.DoNotTransfer);
			return @object.ExecuteKeyEvent(object2);
		}

		// Token: 0x060000F1 RID: 241 RVA: 0x00003AE0 File Offset: 0x00001CE0
		[Register("executeKeyEvent", "(Landroid/view/KeyEvent;)Z", "GetExecuteKeyEvent_Landroid_view_KeyEvent_Handler")]
		public unsafe virtual bool ExecuteKeyEvent(KeyEvent e)
		{
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((e == null) ? IntPtr.Zero : e.Handle);
				result = ViewPager._members.InstanceMethods.InvokeVirtualBooleanMethod("executeKeyEvent.(Landroid/view/KeyEvent;)Z", this, ptr);
			}
			finally
			{
				GC.KeepAlive(e);
			}
			return result;
		}

		// Token: 0x060000F2 RID: 242 RVA: 0x00003B48 File Offset: 0x00001D48
		private static Delegate GetFakeDragBy_FHandler()
		{
			if (ViewPager.cb_fakeDragBy_F == null)
			{
				ViewPager.cb_fakeDragBy_F = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPF_V(ViewPager.n_FakeDragBy_F));
			}
			return ViewPager.cb_fakeDragBy_F;
		}

		// Token: 0x060000F3 RID: 243 RVA: 0x00003B6C File Offset: 0x00001D6C
		private static void n_FakeDragBy_F(IntPtr jnienv, IntPtr native__this, float xOffset)
		{
			Java.Lang.Object.GetObject<ViewPager>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).FakeDragBy(xOffset);
		}

		// Token: 0x060000F4 RID: 244 RVA: 0x00003B7C File Offset: 0x00001D7C
		[Register("fakeDragBy", "(F)V", "GetFakeDragBy_FHandler")]
		public unsafe virtual void FakeDragBy(float xOffset)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(xOffset);
			ViewPager._members.InstanceMethods.InvokeVirtualVoidMethod("fakeDragBy.(F)V", this, ptr);
		}

		// Token: 0x060000F5 RID: 245 RVA: 0x00003BB7 File Offset: 0x00001DB7
		private static Delegate GetOnLayout_ZIIIIHandler()
		{
			if (ViewPager.cb_onLayout_ZIIII == null)
			{
				ViewPager.cb_onLayout_ZIIII = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPZIIII_V(ViewPager.n_OnLayout_ZIIII));
			}
			return ViewPager.cb_onLayout_ZIIII;
		}

		// Token: 0x060000F6 RID: 246 RVA: 0x00003BDB File Offset: 0x00001DDB
		private static void n_OnLayout_ZIIII(IntPtr jnienv, IntPtr native__this, bool changed, int l, int t, int r, int b)
		{
			Java.Lang.Object.GetObject<ViewPager>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).OnLayout(changed, l, t, r, b);
		}

		// Token: 0x060000F7 RID: 247 RVA: 0x00003BF4 File Offset: 0x00001DF4
		[Register("onLayout", "(ZIIII)V", "GetOnLayout_ZIIIIHandler")]
		protected unsafe override void OnLayout(bool changed, int l, int t, int r, int b)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(changed);
			ptr[1] = new JniArgumentValue(l);
			ptr[2] = new JniArgumentValue(t);
			ptr[3] = new JniArgumentValue(r);
			ptr[4] = new JniArgumentValue(b);
			ViewPager._members.InstanceMethods.InvokeVirtualVoidMethod("onLayout.(ZIIII)V", this, ptr);
		}

		// Token: 0x060000F8 RID: 248 RVA: 0x00003C86 File Offset: 0x00001E86
		private static Delegate GetOnPageScrolled_IFIHandler()
		{
			if (ViewPager.cb_onPageScrolled_IFI == null)
			{
				ViewPager.cb_onPageScrolled_IFI = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPIFI_V(ViewPager.n_OnPageScrolled_IFI));
			}
			return ViewPager.cb_onPageScrolled_IFI;
		}

		// Token: 0x060000F9 RID: 249 RVA: 0x00003CAA File Offset: 0x00001EAA
		private static void n_OnPageScrolled_IFI(IntPtr jnienv, IntPtr native__this, int position, float offset, int offsetPixels)
		{
			Java.Lang.Object.GetObject<ViewPager>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).OnPageScrolled(position, offset, offsetPixels);
		}

		// Token: 0x060000FA RID: 250 RVA: 0x00003CC0 File Offset: 0x00001EC0
		[Register("onPageScrolled", "(IFI)V", "GetOnPageScrolled_IFIHandler")]
		protected unsafe virtual void OnPageScrolled(int position, float offset, int offsetPixels)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(position);
			ptr[1] = new JniArgumentValue(offset);
			ptr[2] = new JniArgumentValue(offsetPixels);
			ViewPager._members.InstanceMethods.InvokeVirtualVoidMethod("onPageScrolled.(IFI)V", this, ptr);
		}

		// Token: 0x060000FB RID: 251 RVA: 0x00003D24 File Offset: 0x00001F24
		private static Delegate GetOnRestoreInstanceState_Landroid_os_Parcelable_Handler()
		{
			if (ViewPager.cb_onRestoreInstanceState_Landroid_os_Parcelable_ == null)
			{
				ViewPager.cb_onRestoreInstanceState_Landroid_os_Parcelable_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(ViewPager.n_OnRestoreInstanceState_Landroid_os_Parcelable_));
			}
			return ViewPager.cb_onRestoreInstanceState_Landroid_os_Parcelable_;
		}

		// Token: 0x060000FC RID: 252 RVA: 0x00003D48 File Offset: 0x00001F48
		private static void n_OnRestoreInstanceState_Landroid_os_Parcelable_(IntPtr jnienv, IntPtr native__this, IntPtr native_state)
		{
			ViewPager @object = Java.Lang.Object.GetObject<ViewPager>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IParcelable object2 = Java.Lang.Object.GetObject<IParcelable>(native_state, JniHandleOwnership.DoNotTransfer);
			@object.OnRestoreInstanceState(object2);
		}

		// Token: 0x060000FD RID: 253 RVA: 0x00003D6C File Offset: 0x00001F6C
		[Register("onRestoreInstanceState", "(Landroid/os/Parcelable;)V", "GetOnRestoreInstanceState_Landroid_os_Parcelable_Handler")]
		public new unsafe virtual void OnRestoreInstanceState(IParcelable state)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((state == null) ? IntPtr.Zero : ((Java.Lang.Object)state).Handle);
				ViewPager._members.InstanceMethods.InvokeVirtualVoidMethod("onRestoreInstanceState.(Landroid/os/Parcelable;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(state);
			}
		}

		// Token: 0x060000FE RID: 254 RVA: 0x00003DD4 File Offset: 0x00001FD4
		private static Delegate GetOnSaveInstanceStateHandler()
		{
			if (ViewPager.cb_onSaveInstanceState == null)
			{
				ViewPager.cb_onSaveInstanceState = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(ViewPager.n_OnSaveInstanceState));
			}
			return ViewPager.cb_onSaveInstanceState;
		}

		// Token: 0x060000FF RID: 255 RVA: 0x00003DF8 File Offset: 0x00001FF8
		private static IntPtr n_OnSaveInstanceState(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<ViewPager>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).OnSaveInstanceState());
		}

		// Token: 0x06000100 RID: 256 RVA: 0x00003E0C File Offset: 0x0000200C
		[Register("onSaveInstanceState", "()Landroid/os/Parcelable;", "GetOnSaveInstanceStateHandler")]
		public new virtual IParcelable OnSaveInstanceState()
		{
			return Java.Lang.Object.GetObject<IParcelable>(ViewPager._members.InstanceMethods.InvokeVirtualObjectMethod("onSaveInstanceState.()Landroid/os/Parcelable;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06000101 RID: 257 RVA: 0x00003E3E File Offset: 0x0000203E
		private static Delegate GetRemoveOnAdapterChangeListener_Landroidx_viewpager_widget_ViewPager_OnAdapterChangeListener_Handler()
		{
			if (ViewPager.cb_removeOnAdapterChangeListener_Landroidx_viewpager_widget_ViewPager_OnAdapterChangeListener_ == null)
			{
				ViewPager.cb_removeOnAdapterChangeListener_Landroidx_viewpager_widget_ViewPager_OnAdapterChangeListener_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(ViewPager.n_RemoveOnAdapterChangeListener_Landroidx_viewpager_widget_ViewPager_OnAdapterChangeListener_));
			}
			return ViewPager.cb_removeOnAdapterChangeListener_Landroidx_viewpager_widget_ViewPager_OnAdapterChangeListener_;
		}

		// Token: 0x06000102 RID: 258 RVA: 0x00003E64 File Offset: 0x00002064
		private static void n_RemoveOnAdapterChangeListener_Landroidx_viewpager_widget_ViewPager_OnAdapterChangeListener_(IntPtr jnienv, IntPtr native__this, IntPtr native_listener)
		{
			ViewPager @object = Java.Lang.Object.GetObject<ViewPager>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ViewPager.IOnAdapterChangeListener object2 = Java.Lang.Object.GetObject<ViewPager.IOnAdapterChangeListener>(native_listener, JniHandleOwnership.DoNotTransfer);
			@object.RemoveOnAdapterChangeListener(object2);
		}

		// Token: 0x06000103 RID: 259 RVA: 0x00003E88 File Offset: 0x00002088
		[Register("removeOnAdapterChangeListener", "(Landroidx/viewpager/widget/ViewPager$OnAdapterChangeListener;)V", "GetRemoveOnAdapterChangeListener_Landroidx_viewpager_widget_ViewPager_OnAdapterChangeListener_Handler")]
		public unsafe virtual void RemoveOnAdapterChangeListener(ViewPager.IOnAdapterChangeListener listener)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((listener == null) ? IntPtr.Zero : ((Java.Lang.Object)listener).Handle);
				ViewPager._members.InstanceMethods.InvokeVirtualVoidMethod("removeOnAdapterChangeListener.(Landroidx/viewpager/widget/ViewPager$OnAdapterChangeListener;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(listener);
			}
		}

		// Token: 0x06000104 RID: 260 RVA: 0x00003EF0 File Offset: 0x000020F0
		private static Delegate GetRemoveOnPageChangeListener_Landroidx_viewpager_widget_ViewPager_OnPageChangeListener_Handler()
		{
			if (ViewPager.cb_removeOnPageChangeListener_Landroidx_viewpager_widget_ViewPager_OnPageChangeListener_ == null)
			{
				ViewPager.cb_removeOnPageChangeListener_Landroidx_viewpager_widget_ViewPager_OnPageChangeListener_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(ViewPager.n_RemoveOnPageChangeListener_Landroidx_viewpager_widget_ViewPager_OnPageChangeListener_));
			}
			return ViewPager.cb_removeOnPageChangeListener_Landroidx_viewpager_widget_ViewPager_OnPageChangeListener_;
		}

		// Token: 0x06000105 RID: 261 RVA: 0x00003F14 File Offset: 0x00002114
		private static void n_RemoveOnPageChangeListener_Landroidx_viewpager_widget_ViewPager_OnPageChangeListener_(IntPtr jnienv, IntPtr native__this, IntPtr native_listener)
		{
			ViewPager @object = Java.Lang.Object.GetObject<ViewPager>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ViewPager.IOnPageChangeListener object2 = Java.Lang.Object.GetObject<ViewPager.IOnPageChangeListener>(native_listener, JniHandleOwnership.DoNotTransfer);
			@object.RemoveOnPageChangeListener(object2);
		}

		// Token: 0x06000106 RID: 262 RVA: 0x00003F38 File Offset: 0x00002138
		[Register("removeOnPageChangeListener", "(Landroidx/viewpager/widget/ViewPager$OnPageChangeListener;)V", "GetRemoveOnPageChangeListener_Landroidx_viewpager_widget_ViewPager_OnPageChangeListener_Handler")]
		public unsafe virtual void RemoveOnPageChangeListener(ViewPager.IOnPageChangeListener listener)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((listener == null) ? IntPtr.Zero : ((Java.Lang.Object)listener).Handle);
				ViewPager._members.InstanceMethods.InvokeVirtualVoidMethod("removeOnPageChangeListener.(Landroidx/viewpager/widget/ViewPager$OnPageChangeListener;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(listener);
			}
		}

		// Token: 0x06000107 RID: 263 RVA: 0x00003FA0 File Offset: 0x000021A0
		private static Delegate GetSetCurrentItem_IZHandler()
		{
			if (ViewPager.cb_setCurrentItem_IZ == null)
			{
				ViewPager.cb_setCurrentItem_IZ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPIZ_V(ViewPager.n_SetCurrentItem_IZ));
			}
			return ViewPager.cb_setCurrentItem_IZ;
		}

		// Token: 0x06000108 RID: 264 RVA: 0x00003FC4 File Offset: 0x000021C4
		private static void n_SetCurrentItem_IZ(IntPtr jnienv, IntPtr native__this, int item, bool smoothScroll)
		{
			Java.Lang.Object.GetObject<ViewPager>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SetCurrentItem(item, smoothScroll);
		}

		// Token: 0x06000109 RID: 265 RVA: 0x00003FD8 File Offset: 0x000021D8
		[Register("setCurrentItem", "(IZ)V", "GetSetCurrentItem_IZHandler")]
		public unsafe virtual void SetCurrentItem(int item, bool smoothScroll)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(item);
			ptr[1] = new JniArgumentValue(smoothScroll);
			ViewPager._members.InstanceMethods.InvokeVirtualVoidMethod("setCurrentItem.(IZ)V", this, ptr);
		}

		// Token: 0x0600010A RID: 266 RVA: 0x00004026 File Offset: 0x00002226
		private static Delegate GetSetOnPageChangeListener_Landroidx_viewpager_widget_ViewPager_OnPageChangeListener_Handler()
		{
			if (ViewPager.cb_setOnPageChangeListener_Landroidx_viewpager_widget_ViewPager_OnPageChangeListener_ == null)
			{
				ViewPager.cb_setOnPageChangeListener_Landroidx_viewpager_widget_ViewPager_OnPageChangeListener_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(ViewPager.n_SetOnPageChangeListener_Landroidx_viewpager_widget_ViewPager_OnPageChangeListener_));
			}
			return ViewPager.cb_setOnPageChangeListener_Landroidx_viewpager_widget_ViewPager_OnPageChangeListener_;
		}

		// Token: 0x0600010B RID: 267 RVA: 0x0000404C File Offset: 0x0000224C
		private static void n_SetOnPageChangeListener_Landroidx_viewpager_widget_ViewPager_OnPageChangeListener_(IntPtr jnienv, IntPtr native__this, IntPtr native_listener)
		{
			ViewPager @object = Java.Lang.Object.GetObject<ViewPager>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ViewPager.IOnPageChangeListener object2 = Java.Lang.Object.GetObject<ViewPager.IOnPageChangeListener>(native_listener, JniHandleOwnership.DoNotTransfer);
			@object.SetOnPageChangeListener(object2);
		}

		// Token: 0x0600010C RID: 268 RVA: 0x00004070 File Offset: 0x00002270
		[Register("setOnPageChangeListener", "(Landroidx/viewpager/widget/ViewPager$OnPageChangeListener;)V", "GetSetOnPageChangeListener_Landroidx_viewpager_widget_ViewPager_OnPageChangeListener_Handler")]
		public unsafe virtual void SetOnPageChangeListener(ViewPager.IOnPageChangeListener listener)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((listener == null) ? IntPtr.Zero : ((Java.Lang.Object)listener).Handle);
				ViewPager._members.InstanceMethods.InvokeVirtualVoidMethod("setOnPageChangeListener.(Landroidx/viewpager/widget/ViewPager$OnPageChangeListener;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(listener);
			}
		}

		// Token: 0x0600010D RID: 269 RVA: 0x000040D8 File Offset: 0x000022D8
		private static Delegate GetSetPageMarginDrawable_Landroid_graphics_drawable_Drawable_Handler()
		{
			if (ViewPager.cb_setPageMarginDrawable_Landroid_graphics_drawable_Drawable_ == null)
			{
				ViewPager.cb_setPageMarginDrawable_Landroid_graphics_drawable_Drawable_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(ViewPager.n_SetPageMarginDrawable_Landroid_graphics_drawable_Drawable_));
			}
			return ViewPager.cb_setPageMarginDrawable_Landroid_graphics_drawable_Drawable_;
		}

		// Token: 0x0600010E RID: 270 RVA: 0x000040FC File Offset: 0x000022FC
		private static void n_SetPageMarginDrawable_Landroid_graphics_drawable_Drawable_(IntPtr jnienv, IntPtr native__this, IntPtr native_d)
		{
			ViewPager @object = Java.Lang.Object.GetObject<ViewPager>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Drawable object2 = Java.Lang.Object.GetObject<Drawable>(native_d, JniHandleOwnership.DoNotTransfer);
			@object.SetPageMarginDrawable(object2);
		}

		// Token: 0x0600010F RID: 271 RVA: 0x00004120 File Offset: 0x00002320
		[Register("setPageMarginDrawable", "(Landroid/graphics/drawable/Drawable;)V", "GetSetPageMarginDrawable_Landroid_graphics_drawable_Drawable_Handler")]
		public unsafe virtual void SetPageMarginDrawable(Drawable d)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((d == null) ? IntPtr.Zero : d.Handle);
				ViewPager._members.InstanceMethods.InvokeVirtualVoidMethod("setPageMarginDrawable.(Landroid/graphics/drawable/Drawable;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(d);
			}
		}

		// Token: 0x06000110 RID: 272 RVA: 0x00004184 File Offset: 0x00002384
		private static Delegate GetSetPageMarginDrawable_IHandler()
		{
			if (ViewPager.cb_setPageMarginDrawable_I == null)
			{
				ViewPager.cb_setPageMarginDrawable_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_V(ViewPager.n_SetPageMarginDrawable_I));
			}
			return ViewPager.cb_setPageMarginDrawable_I;
		}

		// Token: 0x06000111 RID: 273 RVA: 0x000041A8 File Offset: 0x000023A8
		private static void n_SetPageMarginDrawable_I(IntPtr jnienv, IntPtr native__this, int resId)
		{
			Java.Lang.Object.GetObject<ViewPager>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SetPageMarginDrawable(resId);
		}

		// Token: 0x06000112 RID: 274 RVA: 0x000041B8 File Offset: 0x000023B8
		[Register("setPageMarginDrawable", "(I)V", "GetSetPageMarginDrawable_IHandler")]
		public unsafe virtual void SetPageMarginDrawable(int resId)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(resId);
			ViewPager._members.InstanceMethods.InvokeVirtualVoidMethod("setPageMarginDrawable.(I)V", this, ptr);
		}

		// Token: 0x06000113 RID: 275 RVA: 0x000041F3 File Offset: 0x000023F3
		private static Delegate GetSetPageTransformer_ZLandroidx_viewpager_widget_ViewPager_PageTransformer_Handler()
		{
			if (ViewPager.cb_setPageTransformer_ZLandroidx_viewpager_widget_ViewPager_PageTransformer_ == null)
			{
				ViewPager.cb_setPageTransformer_ZLandroidx_viewpager_widget_ViewPager_PageTransformer_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPZL_V(ViewPager.n_SetPageTransformer_ZLandroidx_viewpager_widget_ViewPager_PageTransformer_));
			}
			return ViewPager.cb_setPageTransformer_ZLandroidx_viewpager_widget_ViewPager_PageTransformer_;
		}

		// Token: 0x06000114 RID: 276 RVA: 0x00004218 File Offset: 0x00002418
		private static void n_SetPageTransformer_ZLandroidx_viewpager_widget_ViewPager_PageTransformer_(IntPtr jnienv, IntPtr native__this, bool reverseDrawingOrder, IntPtr native_transformer)
		{
			ViewPager @object = Java.Lang.Object.GetObject<ViewPager>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ViewPager.IPageTransformer object2 = Java.Lang.Object.GetObject<ViewPager.IPageTransformer>(native_transformer, JniHandleOwnership.DoNotTransfer);
			@object.SetPageTransformer(reverseDrawingOrder, object2);
		}

		// Token: 0x06000115 RID: 277 RVA: 0x0000423C File Offset: 0x0000243C
		[Register("setPageTransformer", "(ZLandroidx/viewpager/widget/ViewPager$PageTransformer;)V", "GetSetPageTransformer_ZLandroidx_viewpager_widget_ViewPager_PageTransformer_Handler")]
		public unsafe virtual void SetPageTransformer(bool reverseDrawingOrder, ViewPager.IPageTransformer transformer)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(reverseDrawingOrder);
				ptr[1] = new JniArgumentValue((transformer == null) ? IntPtr.Zero : ((Java.Lang.Object)transformer).Handle);
				ViewPager._members.InstanceMethods.InvokeVirtualVoidMethod("setPageTransformer.(ZLandroidx/viewpager/widget/ViewPager$PageTransformer;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(transformer);
			}
		}

		// Token: 0x06000116 RID: 278 RVA: 0x000042B8 File Offset: 0x000024B8
		private static Delegate GetSetPageTransformer_ZLandroidx_viewpager_widget_ViewPager_PageTransformer_IHandler()
		{
			if (ViewPager.cb_setPageTransformer_ZLandroidx_viewpager_widget_ViewPager_PageTransformer_I == null)
			{
				ViewPager.cb_setPageTransformer_ZLandroidx_viewpager_widget_ViewPager_PageTransformer_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPZLI_V(ViewPager.n_SetPageTransformer_ZLandroidx_viewpager_widget_ViewPager_PageTransformer_I));
			}
			return ViewPager.cb_setPageTransformer_ZLandroidx_viewpager_widget_ViewPager_PageTransformer_I;
		}

		// Token: 0x06000117 RID: 279 RVA: 0x000042DC File Offset: 0x000024DC
		private static void n_SetPageTransformer_ZLandroidx_viewpager_widget_ViewPager_PageTransformer_I(IntPtr jnienv, IntPtr native__this, bool reverseDrawingOrder, IntPtr native_transformer, int pageLayerType)
		{
			ViewPager @object = Java.Lang.Object.GetObject<ViewPager>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ViewPager.IPageTransformer object2 = Java.Lang.Object.GetObject<ViewPager.IPageTransformer>(native_transformer, JniHandleOwnership.DoNotTransfer);
			@object.SetPageTransformer(reverseDrawingOrder, object2, pageLayerType);
		}

		// Token: 0x06000118 RID: 280 RVA: 0x00004304 File Offset: 0x00002504
		[Register("setPageTransformer", "(ZLandroidx/viewpager/widget/ViewPager$PageTransformer;I)V", "GetSetPageTransformer_ZLandroidx_viewpager_widget_ViewPager_PageTransformer_IHandler")]
		public unsafe virtual void SetPageTransformer(bool reverseDrawingOrder, ViewPager.IPageTransformer transformer, int pageLayerType)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(reverseDrawingOrder);
				ptr[1] = new JniArgumentValue((transformer == null) ? IntPtr.Zero : ((Java.Lang.Object)transformer).Handle);
				ptr[2] = new JniArgumentValue(pageLayerType);
				ViewPager._members.InstanceMethods.InvokeVirtualVoidMethod("setPageTransformer.(ZLandroidx/viewpager/widget/ViewPager$PageTransformer;I)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(transformer);
			}
		}

		// Token: 0x14000001 RID: 1
		// (add) Token: 0x06000119 RID: 281 RVA: 0x00004398 File Offset: 0x00002598
		// (remove) Token: 0x0600011A RID: 282 RVA: 0x000043E4 File Offset: 0x000025E4
		public event EventHandler<ViewPager.AdapterChangeEventArgs> AdapterChange
		{
			add
			{
				EventHelper.AddEventHandler<ViewPager.IOnAdapterChangeListener, ViewPager.IOnAdapterChangeListenerImplementor>(ref this.weak_implementor_AddOnAdapterChangeListener, new Func<ViewPager.IOnAdapterChangeListenerImplementor>(this.__CreateIOnAdapterChangeListenerImplementor), new Action<ViewPager.IOnAdapterChangeListener>(this.AddOnAdapterChangeListener), delegate(ViewPager.IOnAdapterChangeListenerImplementor __h)
				{
					__h.Handler = (EventHandler<ViewPager.AdapterChangeEventArgs>)Delegate.Combine(__h.Handler, value);
				});
			}
			remove
			{
				Func<ViewPager.IOnAdapterChangeListenerImplementor, bool> empty;
				if ((empty = ViewPager.<>O.<0>____IsEmpty) == null)
				{
					empty = (ViewPager.<>O.<0>____IsEmpty = new Func<ViewPager.IOnAdapterChangeListenerImplementor, bool>(ViewPager.IOnAdapterChangeListenerImplementor.__IsEmpty));
				}
				EventHelper.RemoveEventHandler<ViewPager.IOnAdapterChangeListener, ViewPager.IOnAdapterChangeListenerImplementor>(ref this.weak_implementor_AddOnAdapterChangeListener, empty, delegate(ViewPager.IOnAdapterChangeListener __v)
				{
					this.RemoveOnAdapterChangeListener(__v);
				}, delegate(ViewPager.IOnAdapterChangeListenerImplementor __h)
				{
					__h.Handler = (EventHandler<ViewPager.AdapterChangeEventArgs>)Delegate.Remove(__h.Handler, value);
				});
			}
		}

		// Token: 0x0600011B RID: 283 RVA: 0x00004443 File Offset: 0x00002643
		private ViewPager.IOnAdapterChangeListenerImplementor __CreateIOnAdapterChangeListenerImplementor()
		{
			return new ViewPager.IOnAdapterChangeListenerImplementor(this);
		}

		// Token: 0x14000002 RID: 2
		// (add) Token: 0x0600011C RID: 284 RVA: 0x0000444C File Offset: 0x0000264C
		// (remove) Token: 0x0600011D RID: 285 RVA: 0x00004498 File Offset: 0x00002698
		public event EventHandler<ViewPager.PageScrollStateChangedEventArgs> PageScrollStateChanged
		{
			add
			{
				EventHelper.AddEventHandler<ViewPager.IOnPageChangeListener, ViewPager.IOnPageChangeListenerImplementor>(ref this.weak_implementor_AddOnPageChangeListener, new Func<ViewPager.IOnPageChangeListenerImplementor>(this.__CreateIOnPageChangeListenerImplementor), new Action<ViewPager.IOnPageChangeListener>(this.AddOnPageChangeListener), delegate(ViewPager.IOnPageChangeListenerImplementor __h)
				{
					__h.OnPageScrollStateChangedHandler = (EventHandler<ViewPager.PageScrollStateChangedEventArgs>)Delegate.Combine(__h.OnPageScrollStateChangedHandler, value);
				});
			}
			remove
			{
				Func<ViewPager.IOnPageChangeListenerImplementor, bool> empty;
				if ((empty = ViewPager.<>O.<1>____IsEmpty) == null)
				{
					empty = (ViewPager.<>O.<1>____IsEmpty = new Func<ViewPager.IOnPageChangeListenerImplementor, bool>(ViewPager.IOnPageChangeListenerImplementor.__IsEmpty));
				}
				EventHelper.RemoveEventHandler<ViewPager.IOnPageChangeListener, ViewPager.IOnPageChangeListenerImplementor>(ref this.weak_implementor_AddOnPageChangeListener, empty, delegate(ViewPager.IOnPageChangeListener __v)
				{
					this.RemoveOnPageChangeListener(__v);
				}, delegate(ViewPager.IOnPageChangeListenerImplementor __h)
				{
					__h.OnPageScrollStateChangedHandler = (EventHandler<ViewPager.PageScrollStateChangedEventArgs>)Delegate.Remove(__h.OnPageScrollStateChangedHandler, value);
				});
			}
		}

		// Token: 0x14000003 RID: 3
		// (add) Token: 0x0600011E RID: 286 RVA: 0x000044F8 File Offset: 0x000026F8
		// (remove) Token: 0x0600011F RID: 287 RVA: 0x00004544 File Offset: 0x00002744
		public event EventHandler<ViewPager.PageScrolledEventArgs> PageScrolled
		{
			add
			{
				EventHelper.AddEventHandler<ViewPager.IOnPageChangeListener, ViewPager.IOnPageChangeListenerImplementor>(ref this.weak_implementor_AddOnPageChangeListener, new Func<ViewPager.IOnPageChangeListenerImplementor>(this.__CreateIOnPageChangeListenerImplementor), new Action<ViewPager.IOnPageChangeListener>(this.AddOnPageChangeListener), delegate(ViewPager.IOnPageChangeListenerImplementor __h)
				{
					__h.OnPageScrolledHandler = (EventHandler<ViewPager.PageScrolledEventArgs>)Delegate.Combine(__h.OnPageScrolledHandler, value);
				});
			}
			remove
			{
				Func<ViewPager.IOnPageChangeListenerImplementor, bool> empty;
				if ((empty = ViewPager.<>O.<1>____IsEmpty) == null)
				{
					empty = (ViewPager.<>O.<1>____IsEmpty = new Func<ViewPager.IOnPageChangeListenerImplementor, bool>(ViewPager.IOnPageChangeListenerImplementor.__IsEmpty));
				}
				EventHelper.RemoveEventHandler<ViewPager.IOnPageChangeListener, ViewPager.IOnPageChangeListenerImplementor>(ref this.weak_implementor_AddOnPageChangeListener, empty, delegate(ViewPager.IOnPageChangeListener __v)
				{
					this.RemoveOnPageChangeListener(__v);
				}, delegate(ViewPager.IOnPageChangeListenerImplementor __h)
				{
					__h.OnPageScrolledHandler = (EventHandler<ViewPager.PageScrolledEventArgs>)Delegate.Remove(__h.OnPageScrolledHandler, value);
				});
			}
		}

		// Token: 0x14000004 RID: 4
		// (add) Token: 0x06000120 RID: 288 RVA: 0x000045A4 File Offset: 0x000027A4
		// (remove) Token: 0x06000121 RID: 289 RVA: 0x000045F0 File Offset: 0x000027F0
		public event EventHandler<ViewPager.PageSelectedEventArgs> PageSelected
		{
			add
			{
				EventHelper.AddEventHandler<ViewPager.IOnPageChangeListener, ViewPager.IOnPageChangeListenerImplementor>(ref this.weak_implementor_AddOnPageChangeListener, new Func<ViewPager.IOnPageChangeListenerImplementor>(this.__CreateIOnPageChangeListenerImplementor), new Action<ViewPager.IOnPageChangeListener>(this.AddOnPageChangeListener), delegate(ViewPager.IOnPageChangeListenerImplementor __h)
				{
					__h.OnPageSelectedHandler = (EventHandler<ViewPager.PageSelectedEventArgs>)Delegate.Combine(__h.OnPageSelectedHandler, value);
				});
			}
			remove
			{
				Func<ViewPager.IOnPageChangeListenerImplementor, bool> empty;
				if ((empty = ViewPager.<>O.<1>____IsEmpty) == null)
				{
					empty = (ViewPager.<>O.<1>____IsEmpty = new Func<ViewPager.IOnPageChangeListenerImplementor, bool>(ViewPager.IOnPageChangeListenerImplementor.__IsEmpty));
				}
				EventHelper.RemoveEventHandler<ViewPager.IOnPageChangeListener, ViewPager.IOnPageChangeListenerImplementor>(ref this.weak_implementor_AddOnPageChangeListener, empty, delegate(ViewPager.IOnPageChangeListener __v)
				{
					this.RemoveOnPageChangeListener(__v);
				}, delegate(ViewPager.IOnPageChangeListenerImplementor __h)
				{
					__h.OnPageSelectedHandler = (EventHandler<ViewPager.PageSelectedEventArgs>)Delegate.Remove(__h.OnPageSelectedHandler, value);
				});
			}
		}

		// Token: 0x06000122 RID: 290 RVA: 0x0000464F File Offset: 0x0000284F
		private ViewPager.IOnPageChangeListenerImplementor __CreateIOnPageChangeListenerImplementor()
		{
			return new ViewPager.IOnPageChangeListenerImplementor(this);
		}

		// Token: 0x04000019 RID: 25
		private static readonly JniPeerMembers _members = new XAPeerMembers("androidx/viewpager/widget/ViewPager", typeof(ViewPager));

		// Token: 0x0400001A RID: 26
		private static Delegate cb_getAdapter;

		// Token: 0x0400001B RID: 27
		private static Delegate cb_setAdapter_Landroidx_viewpager_widget_PagerAdapter_;

		// Token: 0x0400001C RID: 28
		private static Delegate cb_getCurrentItem;

		// Token: 0x0400001D RID: 29
		private static Delegate cb_setCurrentItem_I;

		// Token: 0x0400001E RID: 30
		private static Delegate cb_isFakeDragging;

		// Token: 0x0400001F RID: 31
		private static Delegate cb_getOffscreenPageLimit;

		// Token: 0x04000020 RID: 32
		private static Delegate cb_setOffscreenPageLimit_I;

		// Token: 0x04000021 RID: 33
		private static Delegate cb_getPageMargin;

		// Token: 0x04000022 RID: 34
		private static Delegate cb_setPageMargin_I;

		// Token: 0x04000023 RID: 35
		private static Delegate cb_addFocusables_Ljava_util_ArrayList_II;

		// Token: 0x04000024 RID: 36
		private static Delegate cb_addOnAdapterChangeListener_Landroidx_viewpager_widget_ViewPager_OnAdapterChangeListener_;

		// Token: 0x04000025 RID: 37
		private static Delegate cb_addOnPageChangeListener_Landroidx_viewpager_widget_ViewPager_OnPageChangeListener_;

		// Token: 0x04000026 RID: 38
		private static Delegate cb_addTouchables_Ljava_util_ArrayList_;

		// Token: 0x04000027 RID: 39
		private static Delegate cb_arrowScroll_I;

		// Token: 0x04000028 RID: 40
		private static Delegate cb_beginFakeDrag;

		// Token: 0x04000029 RID: 41
		private static Delegate cb_canScroll_Landroid_view_View_ZIII;

		// Token: 0x0400002A RID: 42
		private static Delegate cb_clearOnPageChangeListeners;

		// Token: 0x0400002B RID: 43
		private static Delegate cb_endFakeDrag;

		// Token: 0x0400002C RID: 44
		private static Delegate cb_executeKeyEvent_Landroid_view_KeyEvent_;

		// Token: 0x0400002D RID: 45
		private static Delegate cb_fakeDragBy_F;

		// Token: 0x0400002E RID: 46
		private static Delegate cb_onLayout_ZIIII;

		// Token: 0x0400002F RID: 47
		private static Delegate cb_onPageScrolled_IFI;

		// Token: 0x04000030 RID: 48
		private static Delegate cb_onRestoreInstanceState_Landroid_os_Parcelable_;

		// Token: 0x04000031 RID: 49
		private static Delegate cb_onSaveInstanceState;

		// Token: 0x04000032 RID: 50
		private static Delegate cb_removeOnAdapterChangeListener_Landroidx_viewpager_widget_ViewPager_OnAdapterChangeListener_;

		// Token: 0x04000033 RID: 51
		private static Delegate cb_removeOnPageChangeListener_Landroidx_viewpager_widget_ViewPager_OnPageChangeListener_;

		// Token: 0x04000034 RID: 52
		private static Delegate cb_setCurrentItem_IZ;

		// Token: 0x04000035 RID: 53
		private static Delegate cb_setOnPageChangeListener_Landroidx_viewpager_widget_ViewPager_OnPageChangeListener_;

		// Token: 0x04000036 RID: 54
		private static Delegate cb_setPageMarginDrawable_Landroid_graphics_drawable_Drawable_;

		// Token: 0x04000037 RID: 55
		private static Delegate cb_setPageMarginDrawable_I;

		// Token: 0x04000038 RID: 56
		private static Delegate cb_setPageTransformer_ZLandroidx_viewpager_widget_ViewPager_PageTransformer_;

		// Token: 0x04000039 RID: 57
		private static Delegate cb_setPageTransformer_ZLandroidx_viewpager_widget_ViewPager_PageTransformer_I;

		// Token: 0x0400003A RID: 58
		private WeakReference weak_implementor_AddOnAdapterChangeListener;

		// Token: 0x0400003B RID: 59
		private WeakReference weak_implementor_AddOnPageChangeListener;

		// Token: 0x02000021 RID: 33
		[Register("androidx/viewpager/widget/ViewPager$OnAdapterChangeListener", "", "AndroidX.ViewPager.Widget.ViewPager/IOnAdapterChangeListenerInvoker")]
		public interface IOnAdapterChangeListener : IJavaObject, IDisposable, IJavaPeerable
		{
			// Token: 0x06000124 RID: 292
			[Register("onAdapterChanged", "(Landroidx/viewpager/widget/ViewPager;Landroidx/viewpager/widget/PagerAdapter;Landroidx/viewpager/widget/PagerAdapter;)V", "GetOnAdapterChanged_Landroidx_viewpager_widget_ViewPager_Landroidx_viewpager_widget_PagerAdapter_Landroidx_viewpager_widget_PagerAdapter_Handler:AndroidX.ViewPager.Widget.ViewPager/IOnAdapterChangeListenerInvoker, Xamarin.AndroidX.ViewPager")]
			void OnAdapterChanged(ViewPager viewPager, PagerAdapter oldAdapter, PagerAdapter newAdapter);
		}

		// Token: 0x02000022 RID: 34
		[Register("androidx/viewpager/widget/ViewPager$OnAdapterChangeListener", DoNotGenerateAcw = true)]
		internal class IOnAdapterChangeListenerInvoker : Java.Lang.Object, ViewPager.IOnAdapterChangeListener, IJavaObject, IDisposable, IJavaPeerable
		{
			// Token: 0x17000012 RID: 18
			// (get) Token: 0x06000125 RID: 293 RVA: 0x00004674 File Offset: 0x00002874
			private static IntPtr java_class_ref
			{
				get
				{
					return ViewPager.IOnAdapterChangeListenerInvoker._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x17000013 RID: 19
			// (get) Token: 0x06000126 RID: 294 RVA: 0x00004698 File Offset: 0x00002898
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return ViewPager.IOnAdapterChangeListenerInvoker._members;
				}
			}

			// Token: 0x17000014 RID: 20
			// (get) Token: 0x06000127 RID: 295 RVA: 0x0000469F File Offset: 0x0000289F
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return this.class_ref;
				}
			}

			// Token: 0x17000015 RID: 21
			// (get) Token: 0x06000128 RID: 296 RVA: 0x000046A7 File Offset: 0x000028A7
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return ViewPager.IOnAdapterChangeListenerInvoker._members.ManagedPeerType;
				}
			}

			// Token: 0x06000129 RID: 297 RVA: 0x000046B3 File Offset: 0x000028B3
			public static ViewPager.IOnAdapterChangeListener GetObject(IntPtr handle, JniHandleOwnership transfer)
			{
				return Java.Lang.Object.GetObject<ViewPager.IOnAdapterChangeListener>(handle, transfer);
			}

			// Token: 0x0600012A RID: 298 RVA: 0x000046BC File Offset: 0x000028BC
			private static IntPtr Validate(IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf(handle, ViewPager.IOnAdapterChangeListenerInvoker.java_class_ref))
				{
					throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'androidx.viewpager.widget.ViewPager.OnAdapterChangeListener'.");
				}
				return handle;
			}

			// Token: 0x0600012B RID: 299 RVA: 0x000046E7 File Offset: 0x000028E7
			protected override void Dispose(bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
				{
					JNIEnv.DeleteGlobalRef(this.class_ref);
				}
				this.class_ref = IntPtr.Zero;
				base.Dispose(disposing);
			}

			// Token: 0x0600012C RID: 300 RVA: 0x00004718 File Offset: 0x00002918
			public IOnAdapterChangeListenerInvoker(IntPtr handle, JniHandleOwnership transfer) : base(ViewPager.IOnAdapterChangeListenerInvoker.Validate(handle), transfer)
			{
				IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
				this.class_ref = JNIEnv.NewGlobalRef(objectClass);
				JNIEnv.DeleteLocalRef(objectClass);
			}

			// Token: 0x0600012D RID: 301 RVA: 0x00004750 File Offset: 0x00002950
			private static Delegate GetOnAdapterChanged_Landroidx_viewpager_widget_ViewPager_Landroidx_viewpager_widget_PagerAdapter_Landroidx_viewpager_widget_PagerAdapter_Handler()
			{
				if (ViewPager.IOnAdapterChangeListenerInvoker.cb_onAdapterChanged_Landroidx_viewpager_widget_ViewPager_Landroidx_viewpager_widget_PagerAdapter_Landroidx_viewpager_widget_PagerAdapter_ == null)
				{
					ViewPager.IOnAdapterChangeListenerInvoker.cb_onAdapterChanged_Landroidx_viewpager_widget_ViewPager_Landroidx_viewpager_widget_PagerAdapter_Landroidx_viewpager_widget_PagerAdapter_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLLL_V(ViewPager.IOnAdapterChangeListenerInvoker.n_OnAdapterChanged_Landroidx_viewpager_widget_ViewPager_Landroidx_viewpager_widget_PagerAdapter_Landroidx_viewpager_widget_PagerAdapter_));
				}
				return ViewPager.IOnAdapterChangeListenerInvoker.cb_onAdapterChanged_Landroidx_viewpager_widget_ViewPager_Landroidx_viewpager_widget_PagerAdapter_Landroidx_viewpager_widget_PagerAdapter_;
			}

			// Token: 0x0600012E RID: 302 RVA: 0x00004774 File Offset: 0x00002974
			private static void n_OnAdapterChanged_Landroidx_viewpager_widget_ViewPager_Landroidx_viewpager_widget_PagerAdapter_Landroidx_viewpager_widget_PagerAdapter_(IntPtr jnienv, IntPtr native__this, IntPtr native_viewPager, IntPtr native_oldAdapter, IntPtr native_newAdapter)
			{
				ViewPager.IOnAdapterChangeListener @object = Java.Lang.Object.GetObject<ViewPager.IOnAdapterChangeListener>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				ViewPager object2 = Java.Lang.Object.GetObject<ViewPager>(native_viewPager, JniHandleOwnership.DoNotTransfer);
				PagerAdapter object3 = Java.Lang.Object.GetObject<PagerAdapter>(native_oldAdapter, JniHandleOwnership.DoNotTransfer);
				PagerAdapter object4 = Java.Lang.Object.GetObject<PagerAdapter>(native_newAdapter, JniHandleOwnership.DoNotTransfer);
				@object.OnAdapterChanged(object2, object3, object4);
			}

			// Token: 0x0600012F RID: 303 RVA: 0x000047AC File Offset: 0x000029AC
			public unsafe void OnAdapterChanged(ViewPager viewPager, PagerAdapter oldAdapter, PagerAdapter newAdapter)
			{
				if (this.id_onAdapterChanged_Landroidx_viewpager_widget_ViewPager_Landroidx_viewpager_widget_PagerAdapter_Landroidx_viewpager_widget_PagerAdapter_ == IntPtr.Zero)
				{
					this.id_onAdapterChanged_Landroidx_viewpager_widget_ViewPager_Landroidx_viewpager_widget_PagerAdapter_Landroidx_viewpager_widget_PagerAdapter_ = JNIEnv.GetMethodID(this.class_ref, "onAdapterChanged", "(Landroidx/viewpager/widget/ViewPager;Landroidx/viewpager/widget/PagerAdapter;Landroidx/viewpager/widget/PagerAdapter;)V");
				}
				JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JValue))];
				*ptr = new JValue((viewPager == null) ? IntPtr.Zero : viewPager.Handle);
				ptr[1] = new JValue((oldAdapter == null) ? IntPtr.Zero : oldAdapter.Handle);
				ptr[2] = new JValue((newAdapter == null) ? IntPtr.Zero : newAdapter.Handle);
				JNIEnv.CallVoidMethod(base.Handle, this.id_onAdapterChanged_Landroidx_viewpager_widget_ViewPager_Landroidx_viewpager_widget_PagerAdapter_Landroidx_viewpager_widget_PagerAdapter_, ptr);
			}

			// Token: 0x0400003C RID: 60
			private static readonly JniPeerMembers _members = new XAPeerMembers("androidx/viewpager/widget/ViewPager$OnAdapterChangeListener", typeof(ViewPager.IOnAdapterChangeListenerInvoker));

			// Token: 0x0400003D RID: 61
			private IntPtr class_ref;

			// Token: 0x0400003E RID: 62
			private static Delegate cb_onAdapterChanged_Landroidx_viewpager_widget_ViewPager_Landroidx_viewpager_widget_PagerAdapter_Landroidx_viewpager_widget_PagerAdapter_;

			// Token: 0x0400003F RID: 63
			private IntPtr id_onAdapterChanged_Landroidx_viewpager_widget_ViewPager_Landroidx_viewpager_widget_PagerAdapter_Landroidx_viewpager_widget_PagerAdapter_;
		}

		// Token: 0x02000023 RID: 35
		public class AdapterChangeEventArgs : EventArgs
		{
			// Token: 0x06000131 RID: 305 RVA: 0x00004881 File Offset: 0x00002A81
			public AdapterChangeEventArgs(ViewPager viewPager, PagerAdapter oldAdapter, PagerAdapter newAdapter)
			{
				this.viewPager = viewPager;
				this.oldAdapter = oldAdapter;
				this.newAdapter = newAdapter;
			}

			// Token: 0x04000040 RID: 64
			private ViewPager viewPager;

			// Token: 0x04000041 RID: 65
			private PagerAdapter oldAdapter;

			// Token: 0x04000042 RID: 66
			private PagerAdapter newAdapter;
		}

		// Token: 0x02000024 RID: 36
		[Register("mono/androidx/viewpager/widget/ViewPager_OnAdapterChangeListenerImplementor")]
		internal sealed class IOnAdapterChangeListenerImplementor : Java.Lang.Object, ViewPager.IOnAdapterChangeListener, IJavaObject, IDisposable, IJavaPeerable
		{
			// Token: 0x06000132 RID: 306 RVA: 0x0000489E File Offset: 0x00002A9E
			public IOnAdapterChangeListenerImplementor(object sender) : base(JNIEnv.StartCreateInstance("mono/androidx/viewpager/widget/ViewPager_OnAdapterChangeListenerImplementor", "()V", Array.Empty<JValue>()), JniHandleOwnership.TransferLocalRef)
			{
				JNIEnv.FinishCreateInstance(base.Handle, "()V", Array.Empty<JValue>());
				this.sender = sender;
			}

			// Token: 0x06000133 RID: 307 RVA: 0x000048D8 File Offset: 0x00002AD8
			public void OnAdapterChanged(ViewPager viewPager, PagerAdapter oldAdapter, PagerAdapter newAdapter)
			{
				EventHandler<ViewPager.AdapterChangeEventArgs> handler = this.Handler;
				if (handler != null)
				{
					handler(this.sender, new ViewPager.AdapterChangeEventArgs(viewPager, oldAdapter, newAdapter));
				}
			}

			// Token: 0x06000134 RID: 308 RVA: 0x00004903 File Offset: 0x00002B03
			internal static bool __IsEmpty(ViewPager.IOnAdapterChangeListenerImplementor value)
			{
				return value.Handler == null;
			}

			// Token: 0x04000043 RID: 67
			private object sender;

			// Token: 0x04000044 RID: 68
			public EventHandler<ViewPager.AdapterChangeEventArgs> Handler;
		}

		// Token: 0x02000025 RID: 37
		[Register("androidx/viewpager/widget/ViewPager$OnPageChangeListener", "", "AndroidX.ViewPager.Widget.ViewPager/IOnPageChangeListenerInvoker")]
		public interface IOnPageChangeListener : IJavaObject, IDisposable, IJavaPeerable
		{
			// Token: 0x06000135 RID: 309
			[Register("onPageScrollStateChanged", "(I)V", "GetOnPageScrollStateChanged_IHandler:AndroidX.ViewPager.Widget.ViewPager/IOnPageChangeListenerInvoker, Xamarin.AndroidX.ViewPager")]
			void OnPageScrollStateChanged(int state);

			// Token: 0x06000136 RID: 310
			[Register("onPageScrolled", "(IFI)V", "GetOnPageScrolled_IFIHandler:AndroidX.ViewPager.Widget.ViewPager/IOnPageChangeListenerInvoker, Xamarin.AndroidX.ViewPager")]
			void OnPageScrolled(int position, float positionOffset, int positionOffsetPixels);

			// Token: 0x06000137 RID: 311
			[Register("onPageSelected", "(I)V", "GetOnPageSelected_IHandler:AndroidX.ViewPager.Widget.ViewPager/IOnPageChangeListenerInvoker, Xamarin.AndroidX.ViewPager")]
			void OnPageSelected(int position);
		}

		// Token: 0x02000026 RID: 38
		[Register("androidx/viewpager/widget/ViewPager$OnPageChangeListener", DoNotGenerateAcw = true)]
		internal class IOnPageChangeListenerInvoker : Java.Lang.Object, ViewPager.IOnPageChangeListener, IJavaObject, IDisposable, IJavaPeerable
		{
			// Token: 0x17000016 RID: 22
			// (get) Token: 0x06000138 RID: 312 RVA: 0x00004910 File Offset: 0x00002B10
			private static IntPtr java_class_ref
			{
				get
				{
					return ViewPager.IOnPageChangeListenerInvoker._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x17000017 RID: 23
			// (get) Token: 0x06000139 RID: 313 RVA: 0x00004934 File Offset: 0x00002B34
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return ViewPager.IOnPageChangeListenerInvoker._members;
				}
			}

			// Token: 0x17000018 RID: 24
			// (get) Token: 0x0600013A RID: 314 RVA: 0x0000493B File Offset: 0x00002B3B
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return this.class_ref;
				}
			}

			// Token: 0x17000019 RID: 25
			// (get) Token: 0x0600013B RID: 315 RVA: 0x00004943 File Offset: 0x00002B43
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return ViewPager.IOnPageChangeListenerInvoker._members.ManagedPeerType;
				}
			}

			// Token: 0x0600013C RID: 316 RVA: 0x0000494F File Offset: 0x00002B4F
			public static ViewPager.IOnPageChangeListener GetObject(IntPtr handle, JniHandleOwnership transfer)
			{
				return Java.Lang.Object.GetObject<ViewPager.IOnPageChangeListener>(handle, transfer);
			}

			// Token: 0x0600013D RID: 317 RVA: 0x00004958 File Offset: 0x00002B58
			private static IntPtr Validate(IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf(handle, ViewPager.IOnPageChangeListenerInvoker.java_class_ref))
				{
					throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'androidx.viewpager.widget.ViewPager.OnPageChangeListener'.");
				}
				return handle;
			}

			// Token: 0x0600013E RID: 318 RVA: 0x00004983 File Offset: 0x00002B83
			protected override void Dispose(bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
				{
					JNIEnv.DeleteGlobalRef(this.class_ref);
				}
				this.class_ref = IntPtr.Zero;
				base.Dispose(disposing);
			}

			// Token: 0x0600013F RID: 319 RVA: 0x000049B4 File Offset: 0x00002BB4
			public IOnPageChangeListenerInvoker(IntPtr handle, JniHandleOwnership transfer) : base(ViewPager.IOnPageChangeListenerInvoker.Validate(handle), transfer)
			{
				IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
				this.class_ref = JNIEnv.NewGlobalRef(objectClass);
				JNIEnv.DeleteLocalRef(objectClass);
			}

			// Token: 0x06000140 RID: 320 RVA: 0x000049EC File Offset: 0x00002BEC
			private static Delegate GetOnPageScrollStateChanged_IHandler()
			{
				if (ViewPager.IOnPageChangeListenerInvoker.cb_onPageScrollStateChanged_I == null)
				{
					ViewPager.IOnPageChangeListenerInvoker.cb_onPageScrollStateChanged_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_V(ViewPager.IOnPageChangeListenerInvoker.n_OnPageScrollStateChanged_I));
				}
				return ViewPager.IOnPageChangeListenerInvoker.cb_onPageScrollStateChanged_I;
			}

			// Token: 0x06000141 RID: 321 RVA: 0x00004A10 File Offset: 0x00002C10
			private static void n_OnPageScrollStateChanged_I(IntPtr jnienv, IntPtr native__this, int state)
			{
				Java.Lang.Object.GetObject<ViewPager.IOnPageChangeListener>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).OnPageScrollStateChanged(state);
			}

			// Token: 0x06000142 RID: 322 RVA: 0x00004A20 File Offset: 0x00002C20
			public unsafe void OnPageScrollStateChanged(int state)
			{
				if (this.id_onPageScrollStateChanged_I == IntPtr.Zero)
				{
					this.id_onPageScrollStateChanged_I = JNIEnv.GetMethodID(this.class_ref, "onPageScrollStateChanged", "(I)V");
				}
				JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
				*ptr = new JValue(state);
				JNIEnv.CallVoidMethod(base.Handle, this.id_onPageScrollStateChanged_I, ptr);
			}

			// Token: 0x06000143 RID: 323 RVA: 0x00004A84 File Offset: 0x00002C84
			private static Delegate GetOnPageScrolled_IFIHandler()
			{
				if (ViewPager.IOnPageChangeListenerInvoker.cb_onPageScrolled_IFI == null)
				{
					ViewPager.IOnPageChangeListenerInvoker.cb_onPageScrolled_IFI = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPIFI_V(ViewPager.IOnPageChangeListenerInvoker.n_OnPageScrolled_IFI));
				}
				return ViewPager.IOnPageChangeListenerInvoker.cb_onPageScrolled_IFI;
			}

			// Token: 0x06000144 RID: 324 RVA: 0x00004AA8 File Offset: 0x00002CA8
			private static void n_OnPageScrolled_IFI(IntPtr jnienv, IntPtr native__this, int position, float positionOffset, int positionOffsetPixels)
			{
				Java.Lang.Object.GetObject<ViewPager.IOnPageChangeListener>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).OnPageScrolled(position, positionOffset, positionOffsetPixels);
			}

			// Token: 0x06000145 RID: 325 RVA: 0x00004ABC File Offset: 0x00002CBC
			public unsafe void OnPageScrolled(int position, float positionOffset, int positionOffsetPixels)
			{
				if (this.id_onPageScrolled_IFI == IntPtr.Zero)
				{
					this.id_onPageScrolled_IFI = JNIEnv.GetMethodID(this.class_ref, "onPageScrolled", "(IFI)V");
				}
				JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JValue))];
				*ptr = new JValue(position);
				ptr[1] = new JValue(positionOffset);
				ptr[2] = new JValue(positionOffsetPixels);
				JNIEnv.CallVoidMethod(base.Handle, this.id_onPageScrolled_IFI, ptr);
			}

			// Token: 0x06000146 RID: 326 RVA: 0x00004B49 File Offset: 0x00002D49
			private static Delegate GetOnPageSelected_IHandler()
			{
				if (ViewPager.IOnPageChangeListenerInvoker.cb_onPageSelected_I == null)
				{
					ViewPager.IOnPageChangeListenerInvoker.cb_onPageSelected_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_V(ViewPager.IOnPageChangeListenerInvoker.n_OnPageSelected_I));
				}
				return ViewPager.IOnPageChangeListenerInvoker.cb_onPageSelected_I;
			}

			// Token: 0x06000147 RID: 327 RVA: 0x00004B6D File Offset: 0x00002D6D
			private static void n_OnPageSelected_I(IntPtr jnienv, IntPtr native__this, int position)
			{
				Java.Lang.Object.GetObject<ViewPager.IOnPageChangeListener>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).OnPageSelected(position);
			}

			// Token: 0x06000148 RID: 328 RVA: 0x00004B80 File Offset: 0x00002D80
			public unsafe void OnPageSelected(int position)
			{
				if (this.id_onPageSelected_I == IntPtr.Zero)
				{
					this.id_onPageSelected_I = JNIEnv.GetMethodID(this.class_ref, "onPageSelected", "(I)V");
				}
				JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
				*ptr = new JValue(position);
				JNIEnv.CallVoidMethod(base.Handle, this.id_onPageSelected_I, ptr);
			}

			// Token: 0x04000045 RID: 69
			private static readonly JniPeerMembers _members = new XAPeerMembers("androidx/viewpager/widget/ViewPager$OnPageChangeListener", typeof(ViewPager.IOnPageChangeListenerInvoker));

			// Token: 0x04000046 RID: 70
			private IntPtr class_ref;

			// Token: 0x04000047 RID: 71
			private static Delegate cb_onPageScrollStateChanged_I;

			// Token: 0x04000048 RID: 72
			private IntPtr id_onPageScrollStateChanged_I;

			// Token: 0x04000049 RID: 73
			private static Delegate cb_onPageScrolled_IFI;

			// Token: 0x0400004A RID: 74
			private IntPtr id_onPageScrolled_IFI;

			// Token: 0x0400004B RID: 75
			private static Delegate cb_onPageSelected_I;

			// Token: 0x0400004C RID: 76
			private IntPtr id_onPageSelected_I;
		}

		// Token: 0x02000027 RID: 39
		public class PageScrollStateChangedEventArgs : EventArgs
		{
			// Token: 0x0600014A RID: 330 RVA: 0x00004BFF File Offset: 0x00002DFF
			public PageScrollStateChangedEventArgs(int state)
			{
				this.state = state;
			}

			// Token: 0x0400004D RID: 77
			private int state;
		}

		// Token: 0x02000028 RID: 40
		public class PageScrolledEventArgs : EventArgs
		{
			// Token: 0x0600014B RID: 331 RVA: 0x00004C0E File Offset: 0x00002E0E
			public PageScrolledEventArgs(int position, float positionOffset, int positionOffsetPixels)
			{
				this.position = position;
				this.positionOffset = positionOffset;
				this.positionOffsetPixels = positionOffsetPixels;
			}

			// Token: 0x0400004E RID: 78
			private int position;

			// Token: 0x0400004F RID: 79
			private float positionOffset;

			// Token: 0x04000050 RID: 80
			private int positionOffsetPixels;
		}

		// Token: 0x02000029 RID: 41
		public class PageSelectedEventArgs : EventArgs
		{
			// Token: 0x0600014C RID: 332 RVA: 0x00004C2B File Offset: 0x00002E2B
			public PageSelectedEventArgs(int position)
			{
				this.position = position;
			}

			// Token: 0x04000051 RID: 81
			private int position;
		}

		// Token: 0x0200002A RID: 42
		[Register("mono/androidx/viewpager/widget/ViewPager_OnPageChangeListenerImplementor")]
		internal sealed class IOnPageChangeListenerImplementor : Java.Lang.Object, ViewPager.IOnPageChangeListener, IJavaObject, IDisposable, IJavaPeerable
		{
			// Token: 0x0600014D RID: 333 RVA: 0x00004C3A File Offset: 0x00002E3A
			public IOnPageChangeListenerImplementor(object sender) : base(JNIEnv.StartCreateInstance("mono/androidx/viewpager/widget/ViewPager_OnPageChangeListenerImplementor", "()V", Array.Empty<JValue>()), JniHandleOwnership.TransferLocalRef)
			{
				JNIEnv.FinishCreateInstance(base.Handle, "()V", Array.Empty<JValue>());
				this.sender = sender;
			}

			// Token: 0x0600014E RID: 334 RVA: 0x00004C74 File Offset: 0x00002E74
			public void OnPageScrollStateChanged(int state)
			{
				EventHandler<ViewPager.PageScrollStateChangedEventArgs> onPageScrollStateChangedHandler = this.OnPageScrollStateChangedHandler;
				if (onPageScrollStateChangedHandler != null)
				{
					onPageScrollStateChangedHandler(this.sender, new ViewPager.PageScrollStateChangedEventArgs(state));
				}
			}

			// Token: 0x0600014F RID: 335 RVA: 0x00004CA0 File Offset: 0x00002EA0
			public void OnPageScrolled(int position, float positionOffset, int positionOffsetPixels)
			{
				EventHandler<ViewPager.PageScrolledEventArgs> onPageScrolledHandler = this.OnPageScrolledHandler;
				if (onPageScrolledHandler != null)
				{
					onPageScrolledHandler(this.sender, new ViewPager.PageScrolledEventArgs(position, positionOffset, positionOffsetPixels));
				}
			}

			// Token: 0x06000150 RID: 336 RVA: 0x00004CCC File Offset: 0x00002ECC
			public void OnPageSelected(int position)
			{
				EventHandler<ViewPager.PageSelectedEventArgs> onPageSelectedHandler = this.OnPageSelectedHandler;
				if (onPageSelectedHandler != null)
				{
					onPageSelectedHandler(this.sender, new ViewPager.PageSelectedEventArgs(position));
				}
			}

			// Token: 0x06000151 RID: 337 RVA: 0x00004CF5 File Offset: 0x00002EF5
			internal static bool __IsEmpty(ViewPager.IOnPageChangeListenerImplementor value)
			{
				return value.OnPageScrollStateChangedHandler == null && value.OnPageScrolledHandler == null && value.OnPageSelectedHandler == null;
			}

			// Token: 0x04000052 RID: 82
			private object sender;

			// Token: 0x04000053 RID: 83
			public EventHandler<ViewPager.PageScrollStateChangedEventArgs> OnPageScrollStateChangedHandler;

			// Token: 0x04000054 RID: 84
			public EventHandler<ViewPager.PageScrolledEventArgs> OnPageScrolledHandler;

			// Token: 0x04000055 RID: 85
			public EventHandler<ViewPager.PageSelectedEventArgs> OnPageSelectedHandler;
		}

		// Token: 0x0200002B RID: 43
		[Register("androidx/viewpager/widget/ViewPager$PageTransformer", "", "AndroidX.ViewPager.Widget.ViewPager/IPageTransformerInvoker")]
		public interface IPageTransformer : IJavaObject, IDisposable, IJavaPeerable
		{
			// Token: 0x06000152 RID: 338
			[Register("transformPage", "(Landroid/view/View;F)V", "GetTransformPage_Landroid_view_View_FHandler:AndroidX.ViewPager.Widget.ViewPager/IPageTransformerInvoker, Xamarin.AndroidX.ViewPager")]
			void TransformPage(View page, float position);
		}

		// Token: 0x0200002C RID: 44
		[Register("androidx/viewpager/widget/ViewPager$PageTransformer", DoNotGenerateAcw = true)]
		internal class IPageTransformerInvoker : Java.Lang.Object, ViewPager.IPageTransformer, IJavaObject, IDisposable, IJavaPeerable
		{
			// Token: 0x1700001A RID: 26
			// (get) Token: 0x06000153 RID: 339 RVA: 0x00004D14 File Offset: 0x00002F14
			private static IntPtr java_class_ref
			{
				get
				{
					return ViewPager.IPageTransformerInvoker._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x1700001B RID: 27
			// (get) Token: 0x06000154 RID: 340 RVA: 0x00004D38 File Offset: 0x00002F38
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return ViewPager.IPageTransformerInvoker._members;
				}
			}

			// Token: 0x1700001C RID: 28
			// (get) Token: 0x06000155 RID: 341 RVA: 0x00004D3F File Offset: 0x00002F3F
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return this.class_ref;
				}
			}

			// Token: 0x1700001D RID: 29
			// (get) Token: 0x06000156 RID: 342 RVA: 0x00004D47 File Offset: 0x00002F47
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return ViewPager.IPageTransformerInvoker._members.ManagedPeerType;
				}
			}

			// Token: 0x06000157 RID: 343 RVA: 0x00004D53 File Offset: 0x00002F53
			public static ViewPager.IPageTransformer GetObject(IntPtr handle, JniHandleOwnership transfer)
			{
				return Java.Lang.Object.GetObject<ViewPager.IPageTransformer>(handle, transfer);
			}

			// Token: 0x06000158 RID: 344 RVA: 0x00004D5C File Offset: 0x00002F5C
			private static IntPtr Validate(IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf(handle, ViewPager.IPageTransformerInvoker.java_class_ref))
				{
					throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'androidx.viewpager.widget.ViewPager.PageTransformer'.");
				}
				return handle;
			}

			// Token: 0x06000159 RID: 345 RVA: 0x00004D87 File Offset: 0x00002F87
			protected override void Dispose(bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
				{
					JNIEnv.DeleteGlobalRef(this.class_ref);
				}
				this.class_ref = IntPtr.Zero;
				base.Dispose(disposing);
			}

			// Token: 0x0600015A RID: 346 RVA: 0x00004DB8 File Offset: 0x00002FB8
			public IPageTransformerInvoker(IntPtr handle, JniHandleOwnership transfer) : base(ViewPager.IPageTransformerInvoker.Validate(handle), transfer)
			{
				IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
				this.class_ref = JNIEnv.NewGlobalRef(objectClass);
				JNIEnv.DeleteLocalRef(objectClass);
			}

			// Token: 0x0600015B RID: 347 RVA: 0x00004DF0 File Offset: 0x00002FF0
			private static Delegate GetTransformPage_Landroid_view_View_FHandler()
			{
				if (ViewPager.IPageTransformerInvoker.cb_transformPage_Landroid_view_View_F == null)
				{
					ViewPager.IPageTransformerInvoker.cb_transformPage_Landroid_view_View_F = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLF_V(ViewPager.IPageTransformerInvoker.n_TransformPage_Landroid_view_View_F));
				}
				return ViewPager.IPageTransformerInvoker.cb_transformPage_Landroid_view_View_F;
			}

			// Token: 0x0600015C RID: 348 RVA: 0x00004E14 File Offset: 0x00003014
			private static void n_TransformPage_Landroid_view_View_F(IntPtr jnienv, IntPtr native__this, IntPtr native_page, float position)
			{
				ViewPager.IPageTransformer @object = Java.Lang.Object.GetObject<ViewPager.IPageTransformer>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				View object2 = Java.Lang.Object.GetObject<View>(native_page, JniHandleOwnership.DoNotTransfer);
				@object.TransformPage(object2, position);
			}

			// Token: 0x0600015D RID: 349 RVA: 0x00004E38 File Offset: 0x00003038
			public unsafe void TransformPage(View page, float position)
			{
				if (this.id_transformPage_Landroid_view_View_F == IntPtr.Zero)
				{
					this.id_transformPage_Landroid_view_View_F = JNIEnv.GetMethodID(this.class_ref, "transformPage", "(Landroid/view/View;F)V");
				}
				JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JValue))];
				*ptr = new JValue((page == null) ? IntPtr.Zero : page.Handle);
				ptr[1] = new JValue(position);
				JNIEnv.CallVoidMethod(base.Handle, this.id_transformPage_Landroid_view_View_F, ptr);
			}

			// Token: 0x04000056 RID: 86
			private static readonly JniPeerMembers _members = new XAPeerMembers("androidx/viewpager/widget/ViewPager$PageTransformer", typeof(ViewPager.IPageTransformerInvoker));

			// Token: 0x04000057 RID: 87
			private IntPtr class_ref;

			// Token: 0x04000058 RID: 88
			private static Delegate cb_transformPage_Landroid_view_View_F;

			// Token: 0x04000059 RID: 89
			private IntPtr id_transformPage_Landroid_view_View_F;
		}

		// Token: 0x0200002D RID: 45
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0400005A RID: 90
			public static Func<ViewPager.IOnAdapterChangeListenerImplementor, bool> <0>____IsEmpty;

			// Token: 0x0400005B RID: 91
			public static Func<ViewPager.IOnPageChangeListenerImplementor, bool> <1>____IsEmpty;
		}
	}
}
