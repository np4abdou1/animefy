using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Graphics;
using Android.Runtime;
using Android.Views;
using Java.Interop;
using Java.Lang;

namespace AndroidX.RecyclerView.Widget
{
	// Token: 0x0200004E RID: 78
	[Register("androidx/recyclerview/widget/ItemTouchUIUtil", DoNotGenerateAcw = true)]
	internal class IItemTouchUIUtilInvoker : Java.Lang.Object, IItemTouchUIUtil, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x1700000F RID: 15
		// (get) Token: 0x0600015E RID: 350 RVA: 0x00002B00 File Offset: 0x00000D00
		private static IntPtr java_class_ref
		{
			get
			{
				return IItemTouchUIUtilInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x0600015F RID: 351 RVA: 0x00002B24 File Offset: 0x00000D24
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IItemTouchUIUtilInvoker._members;
			}
		}

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x06000160 RID: 352 RVA: 0x00002B2B File Offset: 0x00000D2B
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x06000161 RID: 353 RVA: 0x00002B33 File Offset: 0x00000D33
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IItemTouchUIUtilInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06000162 RID: 354 RVA: 0x00002B3F File Offset: 0x00000D3F
		public static IItemTouchUIUtil GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IItemTouchUIUtil>(handle, transfer);
		}

		// Token: 0x06000163 RID: 355 RVA: 0x00002B48 File Offset: 0x00000D48
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IItemTouchUIUtilInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'androidx.recyclerview.widget.ItemTouchUIUtil'.");
			}
			return handle;
		}

		// Token: 0x06000164 RID: 356 RVA: 0x00002B73 File Offset: 0x00000D73
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x06000165 RID: 357 RVA: 0x00002BA4 File Offset: 0x00000DA4
		public IItemTouchUIUtilInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IItemTouchUIUtilInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x06000166 RID: 358 RVA: 0x00002BDC File Offset: 0x00000DDC
		private static Delegate GetClearView_Landroid_view_View_Handler()
		{
			if (IItemTouchUIUtilInvoker.cb_clearView_Landroid_view_View_ == null)
			{
				IItemTouchUIUtilInvoker.cb_clearView_Landroid_view_View_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(IItemTouchUIUtilInvoker.n_ClearView_Landroid_view_View_));
			}
			return IItemTouchUIUtilInvoker.cb_clearView_Landroid_view_View_;
		}

		// Token: 0x06000167 RID: 359 RVA: 0x00002C00 File Offset: 0x00000E00
		private static void n_ClearView_Landroid_view_View_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			IItemTouchUIUtil @object = Java.Lang.Object.GetObject<IItemTouchUIUtil>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			View object2 = Java.Lang.Object.GetObject<View>(native_p0, JniHandleOwnership.DoNotTransfer);
			@object.ClearView(object2);
		}

		// Token: 0x06000168 RID: 360 RVA: 0x00002C24 File Offset: 0x00000E24
		public unsafe void ClearView(View p0)
		{
			if (this.id_clearView_Landroid_view_View_ == IntPtr.Zero)
			{
				this.id_clearView_Landroid_view_View_ = JNIEnv.GetMethodID(this.class_ref, "clearView", "(Landroid/view/View;)V");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((p0 == null) ? IntPtr.Zero : p0.Handle);
			JNIEnv.CallVoidMethod(base.Handle, this.id_clearView_Landroid_view_View_, ptr);
		}

		// Token: 0x06000169 RID: 361 RVA: 0x00002C97 File Offset: 0x00000E97
		private static Delegate GetOnDraw_Landroid_graphics_Canvas_Landroidx_recyclerview_widget_RecyclerView_Landroid_view_View_FFIZHandler()
		{
			if (IItemTouchUIUtilInvoker.cb_onDraw_Landroid_graphics_Canvas_Landroidx_recyclerview_widget_RecyclerView_Landroid_view_View_FFIZ == null)
			{
				IItemTouchUIUtilInvoker.cb_onDraw_Landroid_graphics_Canvas_Landroidx_recyclerview_widget_RecyclerView_Landroid_view_View_FFIZ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLLLFFIZ_V(IItemTouchUIUtilInvoker.n_OnDraw_Landroid_graphics_Canvas_Landroidx_recyclerview_widget_RecyclerView_Landroid_view_View_FFIZ));
			}
			return IItemTouchUIUtilInvoker.cb_onDraw_Landroid_graphics_Canvas_Landroidx_recyclerview_widget_RecyclerView_Landroid_view_View_FFIZ;
		}

		// Token: 0x0600016A RID: 362 RVA: 0x00002CBC File Offset: 0x00000EBC
		private static void n_OnDraw_Landroid_graphics_Canvas_Landroidx_recyclerview_widget_RecyclerView_Landroid_view_View_FFIZ(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, float p3, float p4, int p5, bool p6)
		{
			IItemTouchUIUtil @object = Java.Lang.Object.GetObject<IItemTouchUIUtil>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Canvas object2 = Java.Lang.Object.GetObject<Canvas>(native_p0, JniHandleOwnership.DoNotTransfer);
			RecyclerView object3 = Java.Lang.Object.GetObject<RecyclerView>(native_p1, JniHandleOwnership.DoNotTransfer);
			View object4 = Java.Lang.Object.GetObject<View>(native_p2, JniHandleOwnership.DoNotTransfer);
			@object.OnDraw(object2, object3, object4, p3, p4, p5, p6);
		}

		// Token: 0x0600016B RID: 363 RVA: 0x00002CFC File Offset: 0x00000EFC
		public unsafe void OnDraw(Canvas p0, RecyclerView p1, View p2, float p3, float p4, int p5, bool p6)
		{
			if (this.id_onDraw_Landroid_graphics_Canvas_Landroidx_recyclerview_widget_RecyclerView_Landroid_view_View_FFIZ == IntPtr.Zero)
			{
				this.id_onDraw_Landroid_graphics_Canvas_Landroidx_recyclerview_widget_RecyclerView_Landroid_view_View_FFIZ = JNIEnv.GetMethodID(this.class_ref, "onDraw", "(Landroid/graphics/Canvas;Landroidx/recyclerview/widget/RecyclerView;Landroid/view/View;FFIZ)V");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((p0 == null) ? IntPtr.Zero : p0.Handle);
			ptr[1] = new JValue((p1 == null) ? IntPtr.Zero : p1.Handle);
			ptr[2] = new JValue((p2 == null) ? IntPtr.Zero : p2.Handle);
			ptr[3] = new JValue(p3);
			ptr[4] = new JValue(p4);
			ptr[5] = new JValue(p5);
			ptr[6] = new JValue(p6);
			JNIEnv.CallVoidMethod(base.Handle, this.id_onDraw_Landroid_graphics_Canvas_Landroidx_recyclerview_widget_RecyclerView_Landroid_view_View_FFIZ, ptr);
		}

		// Token: 0x0600016C RID: 364 RVA: 0x00002E12 File Offset: 0x00001012
		private static Delegate GetOnDrawOver_Landroid_graphics_Canvas_Landroidx_recyclerview_widget_RecyclerView_Landroid_view_View_FFIZHandler()
		{
			if (IItemTouchUIUtilInvoker.cb_onDrawOver_Landroid_graphics_Canvas_Landroidx_recyclerview_widget_RecyclerView_Landroid_view_View_FFIZ == null)
			{
				IItemTouchUIUtilInvoker.cb_onDrawOver_Landroid_graphics_Canvas_Landroidx_recyclerview_widget_RecyclerView_Landroid_view_View_FFIZ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLLLFFIZ_V(IItemTouchUIUtilInvoker.n_OnDrawOver_Landroid_graphics_Canvas_Landroidx_recyclerview_widget_RecyclerView_Landroid_view_View_FFIZ));
			}
			return IItemTouchUIUtilInvoker.cb_onDrawOver_Landroid_graphics_Canvas_Landroidx_recyclerview_widget_RecyclerView_Landroid_view_View_FFIZ;
		}

		// Token: 0x0600016D RID: 365 RVA: 0x00002E38 File Offset: 0x00001038
		private static void n_OnDrawOver_Landroid_graphics_Canvas_Landroidx_recyclerview_widget_RecyclerView_Landroid_view_View_FFIZ(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, float p3, float p4, int p5, bool p6)
		{
			IItemTouchUIUtil @object = Java.Lang.Object.GetObject<IItemTouchUIUtil>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Canvas object2 = Java.Lang.Object.GetObject<Canvas>(native_p0, JniHandleOwnership.DoNotTransfer);
			RecyclerView object3 = Java.Lang.Object.GetObject<RecyclerView>(native_p1, JniHandleOwnership.DoNotTransfer);
			View object4 = Java.Lang.Object.GetObject<View>(native_p2, JniHandleOwnership.DoNotTransfer);
			@object.OnDrawOver(object2, object3, object4, p3, p4, p5, p6);
		}

		// Token: 0x0600016E RID: 366 RVA: 0x00002E78 File Offset: 0x00001078
		public unsafe void OnDrawOver(Canvas p0, RecyclerView p1, View p2, float p3, float p4, int p5, bool p6)
		{
			if (this.id_onDrawOver_Landroid_graphics_Canvas_Landroidx_recyclerview_widget_RecyclerView_Landroid_view_View_FFIZ == IntPtr.Zero)
			{
				this.id_onDrawOver_Landroid_graphics_Canvas_Landroidx_recyclerview_widget_RecyclerView_Landroid_view_View_FFIZ = JNIEnv.GetMethodID(this.class_ref, "onDrawOver", "(Landroid/graphics/Canvas;Landroidx/recyclerview/widget/RecyclerView;Landroid/view/View;FFIZ)V");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((p0 == null) ? IntPtr.Zero : p0.Handle);
			ptr[1] = new JValue((p1 == null) ? IntPtr.Zero : p1.Handle);
			ptr[2] = new JValue((p2 == null) ? IntPtr.Zero : p2.Handle);
			ptr[3] = new JValue(p3);
			ptr[4] = new JValue(p4);
			ptr[5] = new JValue(p5);
			ptr[6] = new JValue(p6);
			JNIEnv.CallVoidMethod(base.Handle, this.id_onDrawOver_Landroid_graphics_Canvas_Landroidx_recyclerview_widget_RecyclerView_Landroid_view_View_FFIZ, ptr);
		}

		// Token: 0x0600016F RID: 367 RVA: 0x00002F8E File Offset: 0x0000118E
		private static Delegate GetOnSelected_Landroid_view_View_Handler()
		{
			if (IItemTouchUIUtilInvoker.cb_onSelected_Landroid_view_View_ == null)
			{
				IItemTouchUIUtilInvoker.cb_onSelected_Landroid_view_View_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(IItemTouchUIUtilInvoker.n_OnSelected_Landroid_view_View_));
			}
			return IItemTouchUIUtilInvoker.cb_onSelected_Landroid_view_View_;
		}

		// Token: 0x06000170 RID: 368 RVA: 0x00002FB4 File Offset: 0x000011B4
		private static void n_OnSelected_Landroid_view_View_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			IItemTouchUIUtil @object = Java.Lang.Object.GetObject<IItemTouchUIUtil>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			View object2 = Java.Lang.Object.GetObject<View>(native_p0, JniHandleOwnership.DoNotTransfer);
			@object.OnSelected(object2);
		}

		// Token: 0x06000171 RID: 369 RVA: 0x00002FD8 File Offset: 0x000011D8
		public unsafe void OnSelected(View p0)
		{
			if (this.id_onSelected_Landroid_view_View_ == IntPtr.Zero)
			{
				this.id_onSelected_Landroid_view_View_ = JNIEnv.GetMethodID(this.class_ref, "onSelected", "(Landroid/view/View;)V");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((p0 == null) ? IntPtr.Zero : p0.Handle);
			JNIEnv.CallVoidMethod(base.Handle, this.id_onSelected_Landroid_view_View_, ptr);
		}

		// Token: 0x04000015 RID: 21
		private static readonly JniPeerMembers _members = new XAPeerMembers("androidx/recyclerview/widget/ItemTouchUIUtil", typeof(IItemTouchUIUtilInvoker));

		// Token: 0x04000016 RID: 22
		private IntPtr class_ref;

		// Token: 0x04000017 RID: 23
		private static Delegate cb_clearView_Landroid_view_View_;

		// Token: 0x04000018 RID: 24
		private IntPtr id_clearView_Landroid_view_View_;

		// Token: 0x04000019 RID: 25
		private static Delegate cb_onDraw_Landroid_graphics_Canvas_Landroidx_recyclerview_widget_RecyclerView_Landroid_view_View_FFIZ;

		// Token: 0x0400001A RID: 26
		private IntPtr id_onDraw_Landroid_graphics_Canvas_Landroidx_recyclerview_widget_RecyclerView_Landroid_view_View_FFIZ;

		// Token: 0x0400001B RID: 27
		private static Delegate cb_onDrawOver_Landroid_graphics_Canvas_Landroidx_recyclerview_widget_RecyclerView_Landroid_view_View_FFIZ;

		// Token: 0x0400001C RID: 28
		private IntPtr id_onDrawOver_Landroid_graphics_Canvas_Landroidx_recyclerview_widget_RecyclerView_Landroid_view_View_FFIZ;

		// Token: 0x0400001D RID: 29
		private static Delegate cb_onSelected_Landroid_view_View_;

		// Token: 0x0400001E RID: 30
		private IntPtr id_onSelected_Landroid_view_View_;
	}
}
