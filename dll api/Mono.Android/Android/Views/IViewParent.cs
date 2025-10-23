using System;
using Android.Graphics;
using Android.OS;
using Android.Runtime;
using Android.Views.Accessibility;
using Android.Window;
using Java.Interop;
using Java.Lang;

namespace Android.Views
{
	// Token: 0x02000129 RID: 297
	[Register("android/view/ViewParent", "", "Android.Views.IViewParentInvoker")]
	public interface IViewParent : IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x170001C6 RID: 454
		// (get) Token: 0x06000932 RID: 2354
		bool IsLayoutDirectionResolved { get; }

		// Token: 0x170001C7 RID: 455
		// (get) Token: 0x06000933 RID: 2355
		bool IsLayoutRequested { get; }

		// Token: 0x170001C8 RID: 456
		// (get) Token: 0x06000934 RID: 2356
		bool IsTextAlignmentResolved { get; }

		// Token: 0x170001C9 RID: 457
		// (get) Token: 0x06000935 RID: 2357
		bool IsTextDirectionResolved { get; }

		// Token: 0x170001CA RID: 458
		// (get) Token: 0x06000936 RID: 2358
		LayoutDirection LayoutDirection { get; }

		// Token: 0x170001CB RID: 459
		// (get) Token: 0x06000937 RID: 2359
		IViewParent Parent { get; }

		// Token: 0x170001CC RID: 460
		// (get) Token: 0x06000938 RID: 2360
		IViewParent ParentForAccessibility { get; }

		// Token: 0x170001CD RID: 461
		// (get) Token: 0x06000939 RID: 2361
		TextAlignment TextAlignment { get; }

		// Token: 0x170001CE RID: 462
		// (get) Token: 0x0600093A RID: 2362
		TextDirection TextDirection { get; }

		// Token: 0x0600093B RID: 2363
		void BringChildToFront(View child);

		// Token: 0x0600093C RID: 2364
		bool CanResolveLayoutDirection();

		// Token: 0x0600093D RID: 2365
		bool CanResolveTextAlignment();

		// Token: 0x0600093E RID: 2366
		bool CanResolveTextDirection();

		// Token: 0x0600093F RID: 2367
		void ChildDrawableStateChanged(View child);

		// Token: 0x06000940 RID: 2368
		void ChildHasTransientStateChanged(View child, bool hasTransientState);

		// Token: 0x06000941 RID: 2369
		void ClearChildFocus(View child);

		// Token: 0x06000942 RID: 2370
		void CreateContextMenu(IContextMenu menu);

		// Token: 0x06000943 RID: 2371
		void FocusableViewAvailable(View v);

		// Token: 0x06000944 RID: 2372
		View FocusSearch(View v, [GeneratedEnum] FocusSearchDirection direction);

		// Token: 0x06000945 RID: 2373
		bool GetChildVisibleRect(View child, Rect r, Point offset);

		// Token: 0x06000946 RID: 2374
		void InvalidateChild(View child, Rect r);

		// Token: 0x06000947 RID: 2375
		IViewParent InvalidateChildInParent(int[] location, Rect r);

		// Token: 0x06000948 RID: 2376
		View KeyboardNavigationClusterSearch(View currentCluster, [GeneratedEnum] FocusSearchDirection direction);

		// Token: 0x06000949 RID: 2377
		void NotifySubtreeAccessibilityStateChanged(View child, View source, [GeneratedEnum] ContentChangeTypes changeType);

		// Token: 0x0600094A RID: 2378
		bool OnNestedFling(View target, float velocityX, float velocityY, bool consumed);

		// Token: 0x0600094B RID: 2379
		bool OnNestedPreFling(View target, float velocityX, float velocityY);

		// Token: 0x0600094C RID: 2380
		bool OnNestedPrePerformAccessibilityAction(View target, [GeneratedEnum] Android.Views.Accessibility.Action action, Bundle arguments);

		// Token: 0x0600094D RID: 2381
		void OnNestedPreScroll(View target, int dx, int dy, int[] consumed);

		// Token: 0x0600094E RID: 2382
		void OnNestedScroll(View target, int dxConsumed, int dyConsumed, int dxUnconsumed, int dyUnconsumed);

		// Token: 0x0600094F RID: 2383
		void OnNestedScrollAccepted(View child, View target, [GeneratedEnum] ScrollAxis nestedScrollAxes);

		// Token: 0x06000950 RID: 2384
		bool OnStartNestedScroll(View child, View target, [GeneratedEnum] ScrollAxis nestedScrollAxes);

		// Token: 0x06000951 RID: 2385
		void OnStopNestedScroll(View target);

		// Token: 0x06000952 RID: 2386
		void RecomputeViewAttributes(View child);

		// Token: 0x06000953 RID: 2387
		void RequestChildFocus(View child, View focused);

		// Token: 0x06000954 RID: 2388
		bool RequestChildRectangleOnScreen(View child, Rect rectangle, bool immediate);

		// Token: 0x06000955 RID: 2389
		void RequestDisallowInterceptTouchEvent(bool disallowIntercept);

		// Token: 0x06000956 RID: 2390
		void RequestFitSystemWindows();

		// Token: 0x06000957 RID: 2391
		void RequestLayout();

		// Token: 0x06000958 RID: 2392
		bool RequestSendAccessibilityEvent(View child, AccessibilityEvent e);

		// Token: 0x06000959 RID: 2393
		void RequestTransparentRegion(View child);

		// Token: 0x0600095A RID: 2394
		bool ShowContextMenuForChild(View originalView);

		// Token: 0x0600095B RID: 2395
		bool ShowContextMenuForChild(View originalView, float x, float y);

		// Token: 0x0600095C RID: 2396
		ActionMode StartActionModeForChild(View originalView, ActionMode.ICallback callback);

		// Token: 0x0600095D RID: 2397
		ActionMode StartActionModeForChild(View originalView, ActionMode.ICallback callback, [GeneratedEnum] ActionModeType type);

		// Token: 0x0600095E RID: 2398 RVA: 0x000167E4 File Offset: 0x000149E4
		private static Delegate GetFindOnBackInvokedDispatcherForChild_Landroid_view_View_Landroid_view_View_Handler()
		{
			if (IViewParent.cb_findOnBackInvokedDispatcherForChild_Landroid_view_View_Landroid_view_View_ == null)
			{
				IViewParent.cb_findOnBackInvokedDispatcherForChild_Landroid_view_View_Landroid_view_View_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_L(IViewParent.n_FindOnBackInvokedDispatcherForChild_Landroid_view_View_Landroid_view_View_));
			}
			return IViewParent.cb_findOnBackInvokedDispatcherForChild_Landroid_view_View_Landroid_view_View_;
		}

		// Token: 0x0600095F RID: 2399 RVA: 0x00016808 File Offset: 0x00014A08
		private static IntPtr n_FindOnBackInvokedDispatcherForChild_Landroid_view_View_Landroid_view_View_(IntPtr jnienv, IntPtr native__this, IntPtr native_child, IntPtr native_requester)
		{
			IViewParent @object = Java.Lang.Object.GetObject<IViewParent>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			View object2 = Java.Lang.Object.GetObject<View>(native_child, JniHandleOwnership.DoNotTransfer);
			View object3 = Java.Lang.Object.GetObject<View>(native_requester, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.FindOnBackInvokedDispatcherForChild(object2, object3));
		}

		// Token: 0x06000960 RID: 2400 RVA: 0x0001683C File Offset: 0x00014A3C
		unsafe IOnBackInvokedDispatcher FindOnBackInvokedDispatcherForChild(View child, View requester)
		{
			IOnBackInvokedDispatcher @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((child == null) ? IntPtr.Zero : child.Handle);
				ptr[1] = new JniArgumentValue((requester == null) ? IntPtr.Zero : requester.Handle);
				@object = Java.Lang.Object.GetObject<IOnBackInvokedDispatcher>(IViewParent._members.InstanceMethods.InvokeVirtualObjectMethod("findOnBackInvokedDispatcherForChild.(Landroid/view/View;Landroid/view/View;)Landroid/window/OnBackInvokedDispatcher;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(child);
				GC.KeepAlive(requester);
			}
			return @object;
		}

		// Token: 0x06000961 RID: 2401 RVA: 0x000168D8 File Offset: 0x00014AD8
		private static Delegate GetOnDescendantInvalidated_Landroid_view_View_Landroid_view_View_Handler()
		{
			if (IViewParent.cb_onDescendantInvalidated_Landroid_view_View_Landroid_view_View_ == null)
			{
				IViewParent.cb_onDescendantInvalidated_Landroid_view_View_Landroid_view_View_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_V(IViewParent.n_OnDescendantInvalidated_Landroid_view_View_Landroid_view_View_));
			}
			return IViewParent.cb_onDescendantInvalidated_Landroid_view_View_Landroid_view_View_;
		}

		// Token: 0x06000962 RID: 2402 RVA: 0x000168FC File Offset: 0x00014AFC
		private static void n_OnDescendantInvalidated_Landroid_view_View_Landroid_view_View_(IntPtr jnienv, IntPtr native__this, IntPtr native_child, IntPtr native_target)
		{
			IViewParent @object = Java.Lang.Object.GetObject<IViewParent>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			View object2 = Java.Lang.Object.GetObject<View>(native_child, JniHandleOwnership.DoNotTransfer);
			View object3 = Java.Lang.Object.GetObject<View>(native_target, JniHandleOwnership.DoNotTransfer);
			@object.OnDescendantInvalidated(object2, object3);
		}

		// Token: 0x06000963 RID: 2403 RVA: 0x00016928 File Offset: 0x00014B28
		unsafe void OnDescendantInvalidated(View child, View target)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((child == null) ? IntPtr.Zero : child.Handle);
				ptr[1] = new JniArgumentValue((target == null) ? IntPtr.Zero : target.Handle);
				IViewParent._members.InstanceMethods.InvokeVirtualVoidMethod("onDescendantInvalidated.(Landroid/view/View;Landroid/view/View;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(child);
				GC.KeepAlive(target);
			}
		}

		// Token: 0x040002DC RID: 732
		private static readonly JniPeerMembers _members = new XAPeerMembers("android/view/ViewParent", typeof(IViewParent), true);

		// Token: 0x040002DD RID: 733
		private static Delegate cb_findOnBackInvokedDispatcherForChild_Landroid_view_View_Landroid_view_View_;

		// Token: 0x040002DE RID: 734
		private static Delegate cb_onDescendantInvalidated_Landroid_view_View_Landroid_view_View_;
	}
}
