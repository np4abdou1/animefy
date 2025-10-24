using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using Android.Content;
using Android.Graphics;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Java.Interop;
using Java.Lang;

namespace AndroidX.Core.App
{
	// Token: 0x02000082 RID: 130
	[Register("androidx/core/app/SharedElementCallback", DoNotGenerateAcw = true)]
	public abstract class SharedElementCallback : Java.Lang.Object
	{
		// Token: 0x17000153 RID: 339
		// (get) Token: 0x06000764 RID: 1892 RVA: 0x00016910 File Offset: 0x00014B10
		internal static IntPtr class_ref
		{
			get
			{
				return SharedElementCallback._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000154 RID: 340
		// (get) Token: 0x06000765 RID: 1893 RVA: 0x00016934 File Offset: 0x00014B34
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return SharedElementCallback._members;
			}
		}

		// Token: 0x17000155 RID: 341
		// (get) Token: 0x06000766 RID: 1894 RVA: 0x0001693C File Offset: 0x00014B3C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return SharedElementCallback._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000156 RID: 342
		// (get) Token: 0x06000767 RID: 1895 RVA: 0x00016960 File Offset: 0x00014B60
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return SharedElementCallback._members.ManagedPeerType;
			}
		}

		// Token: 0x06000768 RID: 1896 RVA: 0x00002384 File Offset: 0x00000584
		protected SharedElementCallback(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000769 RID: 1897 RVA: 0x0001696C File Offset: 0x00014B6C
		[Register(".ctor", "()V", "")]
		public SharedElementCallback() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			base.SetHandle(SharedElementCallback._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
			SharedElementCallback._members.InstanceMethods.FinishCreateInstance("()V", this, null);
		}

		// Token: 0x0600076A RID: 1898 RVA: 0x000169DA File Offset: 0x00014BDA
		private static Delegate GetOnCaptureSharedElementSnapshot_Landroid_view_View_Landroid_graphics_Matrix_Landroid_graphics_RectF_Handler()
		{
			if (SharedElementCallback.cb_onCaptureSharedElementSnapshot_Landroid_view_View_Landroid_graphics_Matrix_Landroid_graphics_RectF_ == null)
			{
				SharedElementCallback.cb_onCaptureSharedElementSnapshot_Landroid_view_View_Landroid_graphics_Matrix_Landroid_graphics_RectF_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLLL_L(SharedElementCallback.n_OnCaptureSharedElementSnapshot_Landroid_view_View_Landroid_graphics_Matrix_Landroid_graphics_RectF_));
			}
			return SharedElementCallback.cb_onCaptureSharedElementSnapshot_Landroid_view_View_Landroid_graphics_Matrix_Landroid_graphics_RectF_;
		}

		// Token: 0x0600076B RID: 1899 RVA: 0x00016A00 File Offset: 0x00014C00
		private static IntPtr n_OnCaptureSharedElementSnapshot_Landroid_view_View_Landroid_graphics_Matrix_Landroid_graphics_RectF_(IntPtr jnienv, IntPtr native__this, IntPtr native_sharedElement, IntPtr native_viewToGlobalMatrix, IntPtr native_screenBounds)
		{
			SharedElementCallback @object = Java.Lang.Object.GetObject<SharedElementCallback>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			View object2 = Java.Lang.Object.GetObject<View>(native_sharedElement, JniHandleOwnership.DoNotTransfer);
			Matrix object3 = Java.Lang.Object.GetObject<Matrix>(native_viewToGlobalMatrix, JniHandleOwnership.DoNotTransfer);
			RectF object4 = Java.Lang.Object.GetObject<RectF>(native_screenBounds, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.OnCaptureSharedElementSnapshot(object2, object3, object4));
		}

		// Token: 0x0600076C RID: 1900 RVA: 0x00016A3C File Offset: 0x00014C3C
		[Register("onCaptureSharedElementSnapshot", "(Landroid/view/View;Landroid/graphics/Matrix;Landroid/graphics/RectF;)Landroid/os/Parcelable;", "GetOnCaptureSharedElementSnapshot_Landroid_view_View_Landroid_graphics_Matrix_Landroid_graphics_RectF_Handler")]
		public unsafe virtual IParcelable OnCaptureSharedElementSnapshot(View sharedElement, Matrix viewToGlobalMatrix, RectF screenBounds)
		{
			IParcelable @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((sharedElement == null) ? IntPtr.Zero : sharedElement.Handle);
				ptr[1] = new JniArgumentValue((viewToGlobalMatrix == null) ? IntPtr.Zero : viewToGlobalMatrix.Handle);
				ptr[2] = new JniArgumentValue((screenBounds == null) ? IntPtr.Zero : screenBounds.Handle);
				@object = Java.Lang.Object.GetObject<IParcelable>(SharedElementCallback._members.InstanceMethods.InvokeVirtualObjectMethod("onCaptureSharedElementSnapshot.(Landroid/view/View;Landroid/graphics/Matrix;Landroid/graphics/RectF;)Landroid/os/Parcelable;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(sharedElement);
				GC.KeepAlive(viewToGlobalMatrix);
				GC.KeepAlive(screenBounds);
			}
			return @object;
		}

		// Token: 0x0600076D RID: 1901 RVA: 0x00016B04 File Offset: 0x00014D04
		private static Delegate GetOnCreateSnapshotView_Landroid_content_Context_Landroid_os_Parcelable_Handler()
		{
			if (SharedElementCallback.cb_onCreateSnapshotView_Landroid_content_Context_Landroid_os_Parcelable_ == null)
			{
				SharedElementCallback.cb_onCreateSnapshotView_Landroid_content_Context_Landroid_os_Parcelable_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_L(SharedElementCallback.n_OnCreateSnapshotView_Landroid_content_Context_Landroid_os_Parcelable_));
			}
			return SharedElementCallback.cb_onCreateSnapshotView_Landroid_content_Context_Landroid_os_Parcelable_;
		}

		// Token: 0x0600076E RID: 1902 RVA: 0x00016B28 File Offset: 0x00014D28
		private static IntPtr n_OnCreateSnapshotView_Landroid_content_Context_Landroid_os_Parcelable_(IntPtr jnienv, IntPtr native__this, IntPtr native_context, IntPtr native_snapshot)
		{
			SharedElementCallback @object = Java.Lang.Object.GetObject<SharedElementCallback>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Context object2 = Java.Lang.Object.GetObject<Context>(native_context, JniHandleOwnership.DoNotTransfer);
			IParcelable object3 = Java.Lang.Object.GetObject<IParcelable>(native_snapshot, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.OnCreateSnapshotView(object2, object3));
		}

		// Token: 0x0600076F RID: 1903 RVA: 0x00016B5C File Offset: 0x00014D5C
		[Register("onCreateSnapshotView", "(Landroid/content/Context;Landroid/os/Parcelable;)Landroid/view/View;", "GetOnCreateSnapshotView_Landroid_content_Context_Landroid_os_Parcelable_Handler")]
		public unsafe virtual View OnCreateSnapshotView(Context context, IParcelable snapshot)
		{
			View @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((context == null) ? IntPtr.Zero : context.Handle);
				ptr[1] = new JniArgumentValue((snapshot == null) ? IntPtr.Zero : ((Java.Lang.Object)snapshot).Handle);
				@object = Java.Lang.Object.GetObject<View>(SharedElementCallback._members.InstanceMethods.InvokeVirtualObjectMethod("onCreateSnapshotView.(Landroid/content/Context;Landroid/os/Parcelable;)Landroid/view/View;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(context);
				GC.KeepAlive(snapshot);
			}
			return @object;
		}

		// Token: 0x06000770 RID: 1904 RVA: 0x00016BFC File Offset: 0x00014DFC
		private static Delegate GetOnMapSharedElements_Ljava_util_List_Ljava_util_Map_Handler()
		{
			if (SharedElementCallback.cb_onMapSharedElements_Ljava_util_List_Ljava_util_Map_ == null)
			{
				SharedElementCallback.cb_onMapSharedElements_Ljava_util_List_Ljava_util_Map_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_V(SharedElementCallback.n_OnMapSharedElements_Ljava_util_List_Ljava_util_Map_));
			}
			return SharedElementCallback.cb_onMapSharedElements_Ljava_util_List_Ljava_util_Map_;
		}

		// Token: 0x06000771 RID: 1905 RVA: 0x00016C20 File Offset: 0x00014E20
		private static void n_OnMapSharedElements_Ljava_util_List_Ljava_util_Map_(IntPtr jnienv, IntPtr native__this, IntPtr native_names, IntPtr native_sharedElements)
		{
			SharedElementCallback @object = Java.Lang.Object.GetObject<SharedElementCallback>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IList<string> names = JavaList<string>.FromJniHandle(native_names, JniHandleOwnership.DoNotTransfer);
			IDictionary<string, View> sharedElements = JavaDictionary<string, View>.FromJniHandle(native_sharedElements, JniHandleOwnership.DoNotTransfer);
			@object.OnMapSharedElements(names, sharedElements);
		}

		// Token: 0x06000772 RID: 1906 RVA: 0x00016C4C File Offset: 0x00014E4C
		[Register("onMapSharedElements", "(Ljava/util/List;Ljava/util/Map;)V", "GetOnMapSharedElements_Ljava_util_List_Ljava_util_Map_Handler")]
		public unsafe virtual void OnMapSharedElements(IList<string> names, IDictionary<string, View> sharedElements)
		{
			IntPtr intPtr = JavaList<string>.ToLocalJniHandle(names);
			IntPtr intPtr2 = JavaDictionary<string, View>.ToLocalJniHandle(sharedElements);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(intPtr2);
				SharedElementCallback._members.InstanceMethods.InvokeVirtualVoidMethod("onMapSharedElements.(Ljava/util/List;Ljava/util/Map;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				JNIEnv.DeleteLocalRef(intPtr2);
				GC.KeepAlive(names);
				GC.KeepAlive(sharedElements);
			}
		}

		// Token: 0x06000773 RID: 1907 RVA: 0x00016CD4 File Offset: 0x00014ED4
		private static Delegate GetOnRejectSharedElements_Ljava_util_List_Handler()
		{
			if (SharedElementCallback.cb_onRejectSharedElements_Ljava_util_List_ == null)
			{
				SharedElementCallback.cb_onRejectSharedElements_Ljava_util_List_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(SharedElementCallback.n_OnRejectSharedElements_Ljava_util_List_));
			}
			return SharedElementCallback.cb_onRejectSharedElements_Ljava_util_List_;
		}

		// Token: 0x06000774 RID: 1908 RVA: 0x00016CF8 File Offset: 0x00014EF8
		private static void n_OnRejectSharedElements_Ljava_util_List_(IntPtr jnienv, IntPtr native__this, IntPtr native_rejectedSharedElements)
		{
			SharedElementCallback @object = Java.Lang.Object.GetObject<SharedElementCallback>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IList<View> rejectedSharedElements = JavaList<View>.FromJniHandle(native_rejectedSharedElements, JniHandleOwnership.DoNotTransfer);
			@object.OnRejectSharedElements(rejectedSharedElements);
		}

		// Token: 0x06000775 RID: 1909 RVA: 0x00016D1C File Offset: 0x00014F1C
		[Register("onRejectSharedElements", "(Ljava/util/List;)V", "GetOnRejectSharedElements_Ljava_util_List_Handler")]
		public unsafe virtual void OnRejectSharedElements(IList<View> rejectedSharedElements)
		{
			IntPtr intPtr = JavaList<View>.ToLocalJniHandle(rejectedSharedElements);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				SharedElementCallback._members.InstanceMethods.InvokeVirtualVoidMethod("onRejectSharedElements.(Ljava/util/List;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(rejectedSharedElements);
			}
		}

		// Token: 0x06000776 RID: 1910 RVA: 0x00016D80 File Offset: 0x00014F80
		private static Delegate GetOnSharedElementEnd_Ljava_util_List_Ljava_util_List_Ljava_util_List_Handler()
		{
			if (SharedElementCallback.cb_onSharedElementEnd_Ljava_util_List_Ljava_util_List_Ljava_util_List_ == null)
			{
				SharedElementCallback.cb_onSharedElementEnd_Ljava_util_List_Ljava_util_List_Ljava_util_List_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLLL_V(SharedElementCallback.n_OnSharedElementEnd_Ljava_util_List_Ljava_util_List_Ljava_util_List_));
			}
			return SharedElementCallback.cb_onSharedElementEnd_Ljava_util_List_Ljava_util_List_Ljava_util_List_;
		}

		// Token: 0x06000777 RID: 1911 RVA: 0x00016DA4 File Offset: 0x00014FA4
		private static void n_OnSharedElementEnd_Ljava_util_List_Ljava_util_List_Ljava_util_List_(IntPtr jnienv, IntPtr native__this, IntPtr native_sharedElementNames, IntPtr native_sharedElements, IntPtr native_sharedElementSnapshots)
		{
			SharedElementCallback @object = Java.Lang.Object.GetObject<SharedElementCallback>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IList<string> sharedElementNames = JavaList<string>.FromJniHandle(native_sharedElementNames, JniHandleOwnership.DoNotTransfer);
			IList<View> sharedElements = JavaList<View>.FromJniHandle(native_sharedElements, JniHandleOwnership.DoNotTransfer);
			IList<View> sharedElementSnapshots = JavaList<View>.FromJniHandle(native_sharedElementSnapshots, JniHandleOwnership.DoNotTransfer);
			@object.OnSharedElementEnd(sharedElementNames, sharedElements, sharedElementSnapshots);
		}

		// Token: 0x06000778 RID: 1912 RVA: 0x00016DDC File Offset: 0x00014FDC
		[Register("onSharedElementEnd", "(Ljava/util/List;Ljava/util/List;Ljava/util/List;)V", "GetOnSharedElementEnd_Ljava_util_List_Ljava_util_List_Ljava_util_List_Handler")]
		public unsafe virtual void OnSharedElementEnd(IList<string> sharedElementNames, IList<View> sharedElements, IList<View> sharedElementSnapshots)
		{
			IntPtr intPtr = JavaList<string>.ToLocalJniHandle(sharedElementNames);
			IntPtr intPtr2 = JavaList<View>.ToLocalJniHandle(sharedElements);
			IntPtr intPtr3 = JavaList<View>.ToLocalJniHandle(sharedElementSnapshots);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(intPtr2);
				ptr[2] = new JniArgumentValue(intPtr3);
				SharedElementCallback._members.InstanceMethods.InvokeVirtualVoidMethod("onSharedElementEnd.(Ljava/util/List;Ljava/util/List;Ljava/util/List;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				JNIEnv.DeleteLocalRef(intPtr2);
				JNIEnv.DeleteLocalRef(intPtr3);
				GC.KeepAlive(sharedElementNames);
				GC.KeepAlive(sharedElements);
				GC.KeepAlive(sharedElementSnapshots);
			}
		}

		// Token: 0x06000779 RID: 1913 RVA: 0x00016E8C File Offset: 0x0001508C
		private static Delegate GetOnSharedElementStart_Ljava_util_List_Ljava_util_List_Ljava_util_List_Handler()
		{
			if (SharedElementCallback.cb_onSharedElementStart_Ljava_util_List_Ljava_util_List_Ljava_util_List_ == null)
			{
				SharedElementCallback.cb_onSharedElementStart_Ljava_util_List_Ljava_util_List_Ljava_util_List_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLLL_V(SharedElementCallback.n_OnSharedElementStart_Ljava_util_List_Ljava_util_List_Ljava_util_List_));
			}
			return SharedElementCallback.cb_onSharedElementStart_Ljava_util_List_Ljava_util_List_Ljava_util_List_;
		}

		// Token: 0x0600077A RID: 1914 RVA: 0x00016EB0 File Offset: 0x000150B0
		private static void n_OnSharedElementStart_Ljava_util_List_Ljava_util_List_Ljava_util_List_(IntPtr jnienv, IntPtr native__this, IntPtr native_sharedElementNames, IntPtr native_sharedElements, IntPtr native_sharedElementSnapshots)
		{
			SharedElementCallback @object = Java.Lang.Object.GetObject<SharedElementCallback>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IList<string> sharedElementNames = JavaList<string>.FromJniHandle(native_sharedElementNames, JniHandleOwnership.DoNotTransfer);
			IList<View> sharedElements = JavaList<View>.FromJniHandle(native_sharedElements, JniHandleOwnership.DoNotTransfer);
			IList<View> sharedElementSnapshots = JavaList<View>.FromJniHandle(native_sharedElementSnapshots, JniHandleOwnership.DoNotTransfer);
			@object.OnSharedElementStart(sharedElementNames, sharedElements, sharedElementSnapshots);
		}

		// Token: 0x0600077B RID: 1915 RVA: 0x00016EE8 File Offset: 0x000150E8
		[Register("onSharedElementStart", "(Ljava/util/List;Ljava/util/List;Ljava/util/List;)V", "GetOnSharedElementStart_Ljava_util_List_Ljava_util_List_Ljava_util_List_Handler")]
		public unsafe virtual void OnSharedElementStart(IList<string> sharedElementNames, IList<View> sharedElements, IList<View> sharedElementSnapshots)
		{
			IntPtr intPtr = JavaList<string>.ToLocalJniHandle(sharedElementNames);
			IntPtr intPtr2 = JavaList<View>.ToLocalJniHandle(sharedElements);
			IntPtr intPtr3 = JavaList<View>.ToLocalJniHandle(sharedElementSnapshots);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(intPtr2);
				ptr[2] = new JniArgumentValue(intPtr3);
				SharedElementCallback._members.InstanceMethods.InvokeVirtualVoidMethod("onSharedElementStart.(Ljava/util/List;Ljava/util/List;Ljava/util/List;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				JNIEnv.DeleteLocalRef(intPtr2);
				JNIEnv.DeleteLocalRef(intPtr3);
				GC.KeepAlive(sharedElementNames);
				GC.KeepAlive(sharedElements);
				GC.KeepAlive(sharedElementSnapshots);
			}
		}

		// Token: 0x0600077C RID: 1916 RVA: 0x00016F98 File Offset: 0x00015198
		private static Delegate GetOnSharedElementsArrived_Ljava_util_List_Ljava_util_List_Landroidx_core_app_SharedElementCallback_OnSharedElementsReadyListener_Handler()
		{
			if (SharedElementCallback.cb_onSharedElementsArrived_Ljava_util_List_Ljava_util_List_Landroidx_core_app_SharedElementCallback_OnSharedElementsReadyListener_ == null)
			{
				SharedElementCallback.cb_onSharedElementsArrived_Ljava_util_List_Ljava_util_List_Landroidx_core_app_SharedElementCallback_OnSharedElementsReadyListener_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLLL_V(SharedElementCallback.n_OnSharedElementsArrived_Ljava_util_List_Ljava_util_List_Landroidx_core_app_SharedElementCallback_OnSharedElementsReadyListener_));
			}
			return SharedElementCallback.cb_onSharedElementsArrived_Ljava_util_List_Ljava_util_List_Landroidx_core_app_SharedElementCallback_OnSharedElementsReadyListener_;
		}

		// Token: 0x0600077D RID: 1917 RVA: 0x00016FBC File Offset: 0x000151BC
		private static void n_OnSharedElementsArrived_Ljava_util_List_Ljava_util_List_Landroidx_core_app_SharedElementCallback_OnSharedElementsReadyListener_(IntPtr jnienv, IntPtr native__this, IntPtr native_sharedElementNames, IntPtr native_sharedElements, IntPtr native_listener)
		{
			SharedElementCallback @object = Java.Lang.Object.GetObject<SharedElementCallback>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IList<string> sharedElementNames = JavaList<string>.FromJniHandle(native_sharedElementNames, JniHandleOwnership.DoNotTransfer);
			IList<View> sharedElements = JavaList<View>.FromJniHandle(native_sharedElements, JniHandleOwnership.DoNotTransfer);
			SharedElementCallback.IOnSharedElementsReadyListener object2 = Java.Lang.Object.GetObject<SharedElementCallback.IOnSharedElementsReadyListener>(native_listener, JniHandleOwnership.DoNotTransfer);
			@object.OnSharedElementsArrived(sharedElementNames, sharedElements, object2);
		}

		// Token: 0x0600077E RID: 1918 RVA: 0x00016FF4 File Offset: 0x000151F4
		[Register("onSharedElementsArrived", "(Ljava/util/List;Ljava/util/List;Landroidx/core/app/SharedElementCallback$OnSharedElementsReadyListener;)V", "GetOnSharedElementsArrived_Ljava_util_List_Ljava_util_List_Landroidx_core_app_SharedElementCallback_OnSharedElementsReadyListener_Handler")]
		public unsafe virtual void OnSharedElementsArrived(IList<string> sharedElementNames, IList<View> sharedElements, SharedElementCallback.IOnSharedElementsReadyListener listener)
		{
			IntPtr intPtr = JavaList<string>.ToLocalJniHandle(sharedElementNames);
			IntPtr intPtr2 = JavaList<View>.ToLocalJniHandle(sharedElements);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(intPtr2);
				ptr[2] = new JniArgumentValue((listener == null) ? IntPtr.Zero : ((Java.Lang.Object)listener).Handle);
				SharedElementCallback._members.InstanceMethods.InvokeVirtualVoidMethod("onSharedElementsArrived.(Ljava/util/List;Ljava/util/List;Landroidx/core/app/SharedElementCallback$OnSharedElementsReadyListener;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				JNIEnv.DeleteLocalRef(intPtr2);
				GC.KeepAlive(sharedElementNames);
				GC.KeepAlive(sharedElements);
				GC.KeepAlive(listener);
			}
		}

		// Token: 0x040001E9 RID: 489
		private static readonly JniPeerMembers _members = new XAPeerMembers("androidx/core/app/SharedElementCallback", typeof(SharedElementCallback));

		// Token: 0x040001EA RID: 490
		private static Delegate cb_onCaptureSharedElementSnapshot_Landroid_view_View_Landroid_graphics_Matrix_Landroid_graphics_RectF_;

		// Token: 0x040001EB RID: 491
		private static Delegate cb_onCreateSnapshotView_Landroid_content_Context_Landroid_os_Parcelable_;

		// Token: 0x040001EC RID: 492
		private static Delegate cb_onMapSharedElements_Ljava_util_List_Ljava_util_Map_;

		// Token: 0x040001ED RID: 493
		private static Delegate cb_onRejectSharedElements_Ljava_util_List_;

		// Token: 0x040001EE RID: 494
		private static Delegate cb_onSharedElementEnd_Ljava_util_List_Ljava_util_List_Ljava_util_List_;

		// Token: 0x040001EF RID: 495
		private static Delegate cb_onSharedElementStart_Ljava_util_List_Ljava_util_List_Ljava_util_List_;

		// Token: 0x040001F0 RID: 496
		private static Delegate cb_onSharedElementsArrived_Ljava_util_List_Ljava_util_List_Landroidx_core_app_SharedElementCallback_OnSharedElementsReadyListener_;

		// Token: 0x02000083 RID: 131
		[Register("androidx/core/app/SharedElementCallback$OnSharedElementsReadyListener", "", "AndroidX.Core.App.SharedElementCallback/IOnSharedElementsReadyListenerInvoker")]
		public interface IOnSharedElementsReadyListener : IJavaObject, IDisposable, IJavaPeerable
		{
			// Token: 0x06000780 RID: 1920
			[Register("onSharedElementsReady", "()V", "GetOnSharedElementsReadyHandler:AndroidX.Core.App.SharedElementCallback/IOnSharedElementsReadyListenerInvoker, Xamarin.AndroidX.Core")]
			void OnSharedElementsReady();
		}

		// Token: 0x02000084 RID: 132
		[Register("androidx/core/app/SharedElementCallback$OnSharedElementsReadyListener", DoNotGenerateAcw = true)]
		internal class IOnSharedElementsReadyListenerInvoker : Java.Lang.Object, SharedElementCallback.IOnSharedElementsReadyListener, IJavaObject, IDisposable, IJavaPeerable
		{
			// Token: 0x17000157 RID: 343
			// (get) Token: 0x06000781 RID: 1921 RVA: 0x000170C8 File Offset: 0x000152C8
			private static IntPtr java_class_ref
			{
				get
				{
					return SharedElementCallback.IOnSharedElementsReadyListenerInvoker._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x17000158 RID: 344
			// (get) Token: 0x06000782 RID: 1922 RVA: 0x000170EC File Offset: 0x000152EC
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return SharedElementCallback.IOnSharedElementsReadyListenerInvoker._members;
				}
			}

			// Token: 0x17000159 RID: 345
			// (get) Token: 0x06000783 RID: 1923 RVA: 0x000170F3 File Offset: 0x000152F3
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return this.class_ref;
				}
			}

			// Token: 0x1700015A RID: 346
			// (get) Token: 0x06000784 RID: 1924 RVA: 0x000170FB File Offset: 0x000152FB
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return SharedElementCallback.IOnSharedElementsReadyListenerInvoker._members.ManagedPeerType;
				}
			}

			// Token: 0x06000785 RID: 1925 RVA: 0x00017107 File Offset: 0x00015307
			public static SharedElementCallback.IOnSharedElementsReadyListener GetObject(IntPtr handle, JniHandleOwnership transfer)
			{
				return Java.Lang.Object.GetObject<SharedElementCallback.IOnSharedElementsReadyListener>(handle, transfer);
			}

			// Token: 0x06000786 RID: 1926 RVA: 0x00017110 File Offset: 0x00015310
			private static IntPtr Validate(IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf(handle, SharedElementCallback.IOnSharedElementsReadyListenerInvoker.java_class_ref))
				{
					throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'androidx.core.app.SharedElementCallback.OnSharedElementsReadyListener'.");
				}
				return handle;
			}

			// Token: 0x06000787 RID: 1927 RVA: 0x0001713B File Offset: 0x0001533B
			protected override void Dispose(bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
				{
					JNIEnv.DeleteGlobalRef(this.class_ref);
				}
				this.class_ref = IntPtr.Zero;
				base.Dispose(disposing);
			}

			// Token: 0x06000788 RID: 1928 RVA: 0x0001716C File Offset: 0x0001536C
			public IOnSharedElementsReadyListenerInvoker(IntPtr handle, JniHandleOwnership transfer) : base(SharedElementCallback.IOnSharedElementsReadyListenerInvoker.Validate(handle), transfer)
			{
				IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
				this.class_ref = JNIEnv.NewGlobalRef(objectClass);
				JNIEnv.DeleteLocalRef(objectClass);
			}

			// Token: 0x06000789 RID: 1929 RVA: 0x000171A4 File Offset: 0x000153A4
			private static Delegate GetOnSharedElementsReadyHandler()
			{
				if (SharedElementCallback.IOnSharedElementsReadyListenerInvoker.cb_onSharedElementsReady == null)
				{
					SharedElementCallback.IOnSharedElementsReadyListenerInvoker.cb_onSharedElementsReady = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(SharedElementCallback.IOnSharedElementsReadyListenerInvoker.n_OnSharedElementsReady));
				}
				return SharedElementCallback.IOnSharedElementsReadyListenerInvoker.cb_onSharedElementsReady;
			}

			// Token: 0x0600078A RID: 1930 RVA: 0x000171C8 File Offset: 0x000153C8
			private static void n_OnSharedElementsReady(IntPtr jnienv, IntPtr native__this)
			{
				Java.Lang.Object.GetObject<SharedElementCallback.IOnSharedElementsReadyListener>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).OnSharedElementsReady();
			}

			// Token: 0x0600078B RID: 1931 RVA: 0x000171D7 File Offset: 0x000153D7
			public void OnSharedElementsReady()
			{
				if (this.id_onSharedElementsReady == IntPtr.Zero)
				{
					this.id_onSharedElementsReady = JNIEnv.GetMethodID(this.class_ref, "onSharedElementsReady", "()V");
				}
				JNIEnv.CallVoidMethod(base.Handle, this.id_onSharedElementsReady);
			}

			// Token: 0x040001F1 RID: 497
			private static readonly JniPeerMembers _members = new XAPeerMembers("androidx/core/app/SharedElementCallback$OnSharedElementsReadyListener", typeof(SharedElementCallback.IOnSharedElementsReadyListenerInvoker));

			// Token: 0x040001F2 RID: 498
			private IntPtr class_ref;

			// Token: 0x040001F3 RID: 499
			private static Delegate cb_onSharedElementsReady;

			// Token: 0x040001F4 RID: 500
			private IntPtr id_onSharedElementsReady;
		}
	}
}
