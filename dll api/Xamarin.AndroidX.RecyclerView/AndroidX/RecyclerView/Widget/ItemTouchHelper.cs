using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using Android.Graphics;
using Android.Runtime;
using Android.Views;
using Java.Interop;
using Java.Lang;

namespace AndroidX.RecyclerView.Widget
{
	// Token: 0x0200004F RID: 79
	[Register("androidx/recyclerview/widget/ItemTouchHelper", DoNotGenerateAcw = true)]
	public class ItemTouchHelper : RecyclerView.ItemDecoration, RecyclerView.IOnChildAttachStateChangeListener, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000013 RID: 19
		// (get) Token: 0x06000173 RID: 371 RVA: 0x00003068 File Offset: 0x00001268
		internal new static IntPtr class_ref
		{
			get
			{
				return ItemTouchHelper._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x06000174 RID: 372 RVA: 0x0000308C File Offset: 0x0000128C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return ItemTouchHelper._members;
			}
		}

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x06000175 RID: 373 RVA: 0x00003094 File Offset: 0x00001294
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return ItemTouchHelper._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x06000176 RID: 374 RVA: 0x000030B8 File Offset: 0x000012B8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return ItemTouchHelper._members.ManagedPeerType;
			}
		}

		// Token: 0x06000177 RID: 375 RVA: 0x000030C4 File Offset: 0x000012C4
		protected ItemTouchHelper(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000178 RID: 376 RVA: 0x000030D0 File Offset: 0x000012D0
		[Register(".ctor", "(Landroidx/recyclerview/widget/ItemTouchHelper$Callback;)V", "")]
		public unsafe ItemTouchHelper(ItemTouchHelper.Callback callback) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((callback == null) ? IntPtr.Zero : callback.Handle);
				base.SetHandle(ItemTouchHelper._members.InstanceMethods.StartCreateInstance("(Landroidx/recyclerview/widget/ItemTouchHelper$Callback;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				ItemTouchHelper._members.InstanceMethods.FinishCreateInstance("(Landroidx/recyclerview/widget/ItemTouchHelper$Callback;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(callback);
			}
		}

		// Token: 0x06000179 RID: 377 RVA: 0x00003180 File Offset: 0x00001380
		private static Delegate GetAttachToRecyclerView_Landroidx_recyclerview_widget_RecyclerView_Handler()
		{
			if (ItemTouchHelper.cb_attachToRecyclerView_Landroidx_recyclerview_widget_RecyclerView_ == null)
			{
				ItemTouchHelper.cb_attachToRecyclerView_Landroidx_recyclerview_widget_RecyclerView_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(ItemTouchHelper.n_AttachToRecyclerView_Landroidx_recyclerview_widget_RecyclerView_));
			}
			return ItemTouchHelper.cb_attachToRecyclerView_Landroidx_recyclerview_widget_RecyclerView_;
		}

		// Token: 0x0600017A RID: 378 RVA: 0x000031A4 File Offset: 0x000013A4
		private static void n_AttachToRecyclerView_Landroidx_recyclerview_widget_RecyclerView_(IntPtr jnienv, IntPtr native__this, IntPtr native_recyclerView)
		{
			ItemTouchHelper @object = Java.Lang.Object.GetObject<ItemTouchHelper>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			RecyclerView object2 = Java.Lang.Object.GetObject<RecyclerView>(native_recyclerView, JniHandleOwnership.DoNotTransfer);
			@object.AttachToRecyclerView(object2);
		}

		// Token: 0x0600017B RID: 379 RVA: 0x000031C8 File Offset: 0x000013C8
		[Register("attachToRecyclerView", "(Landroidx/recyclerview/widget/RecyclerView;)V", "GetAttachToRecyclerView_Landroidx_recyclerview_widget_RecyclerView_Handler")]
		public unsafe virtual void AttachToRecyclerView(RecyclerView recyclerView)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((recyclerView == null) ? IntPtr.Zero : recyclerView.Handle);
				ItemTouchHelper._members.InstanceMethods.InvokeVirtualVoidMethod("attachToRecyclerView.(Landroidx/recyclerview/widget/RecyclerView;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(recyclerView);
			}
		}

		// Token: 0x0600017C RID: 380 RVA: 0x0000322C File Offset: 0x0000142C
		private static Delegate GetOnChildViewAttachedToWindow_Landroid_view_View_Handler()
		{
			if (ItemTouchHelper.cb_onChildViewAttachedToWindow_Landroid_view_View_ == null)
			{
				ItemTouchHelper.cb_onChildViewAttachedToWindow_Landroid_view_View_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(ItemTouchHelper.n_OnChildViewAttachedToWindow_Landroid_view_View_));
			}
			return ItemTouchHelper.cb_onChildViewAttachedToWindow_Landroid_view_View_;
		}

		// Token: 0x0600017D RID: 381 RVA: 0x00003250 File Offset: 0x00001450
		private static void n_OnChildViewAttachedToWindow_Landroid_view_View_(IntPtr jnienv, IntPtr native__this, IntPtr native_view)
		{
			ItemTouchHelper @object = Java.Lang.Object.GetObject<ItemTouchHelper>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			View object2 = Java.Lang.Object.GetObject<View>(native_view, JniHandleOwnership.DoNotTransfer);
			@object.OnChildViewAttachedToWindow(object2);
		}

		// Token: 0x0600017E RID: 382 RVA: 0x00003274 File Offset: 0x00001474
		[Register("onChildViewAttachedToWindow", "(Landroid/view/View;)V", "GetOnChildViewAttachedToWindow_Landroid_view_View_Handler")]
		public unsafe virtual void OnChildViewAttachedToWindow(View view)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((view == null) ? IntPtr.Zero : view.Handle);
				ItemTouchHelper._members.InstanceMethods.InvokeVirtualVoidMethod("onChildViewAttachedToWindow.(Landroid/view/View;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(view);
			}
		}

		// Token: 0x0600017F RID: 383 RVA: 0x000032D8 File Offset: 0x000014D8
		private static Delegate GetOnChildViewDetachedFromWindow_Landroid_view_View_Handler()
		{
			if (ItemTouchHelper.cb_onChildViewDetachedFromWindow_Landroid_view_View_ == null)
			{
				ItemTouchHelper.cb_onChildViewDetachedFromWindow_Landroid_view_View_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(ItemTouchHelper.n_OnChildViewDetachedFromWindow_Landroid_view_View_));
			}
			return ItemTouchHelper.cb_onChildViewDetachedFromWindow_Landroid_view_View_;
		}

		// Token: 0x06000180 RID: 384 RVA: 0x000032FC File Offset: 0x000014FC
		private static void n_OnChildViewDetachedFromWindow_Landroid_view_View_(IntPtr jnienv, IntPtr native__this, IntPtr native_view)
		{
			ItemTouchHelper @object = Java.Lang.Object.GetObject<ItemTouchHelper>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			View object2 = Java.Lang.Object.GetObject<View>(native_view, JniHandleOwnership.DoNotTransfer);
			@object.OnChildViewDetachedFromWindow(object2);
		}

		// Token: 0x06000181 RID: 385 RVA: 0x00003320 File Offset: 0x00001520
		[Register("onChildViewDetachedFromWindow", "(Landroid/view/View;)V", "GetOnChildViewDetachedFromWindow_Landroid_view_View_Handler")]
		public unsafe virtual void OnChildViewDetachedFromWindow(View view)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((view == null) ? IntPtr.Zero : view.Handle);
				ItemTouchHelper._members.InstanceMethods.InvokeVirtualVoidMethod("onChildViewDetachedFromWindow.(Landroid/view/View;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(view);
			}
		}

		// Token: 0x06000182 RID: 386 RVA: 0x00003384 File Offset: 0x00001584
		private static Delegate GetStartDrag_Landroidx_recyclerview_widget_RecyclerView_ViewHolder_Handler()
		{
			if (ItemTouchHelper.cb_startDrag_Landroidx_recyclerview_widget_RecyclerView_ViewHolder_ == null)
			{
				ItemTouchHelper.cb_startDrag_Landroidx_recyclerview_widget_RecyclerView_ViewHolder_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(ItemTouchHelper.n_StartDrag_Landroidx_recyclerview_widget_RecyclerView_ViewHolder_));
			}
			return ItemTouchHelper.cb_startDrag_Landroidx_recyclerview_widget_RecyclerView_ViewHolder_;
		}

		// Token: 0x06000183 RID: 387 RVA: 0x000033A8 File Offset: 0x000015A8
		private static void n_StartDrag_Landroidx_recyclerview_widget_RecyclerView_ViewHolder_(IntPtr jnienv, IntPtr native__this, IntPtr native_viewHolder)
		{
			ItemTouchHelper @object = Java.Lang.Object.GetObject<ItemTouchHelper>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			RecyclerView.ViewHolder object2 = Java.Lang.Object.GetObject<RecyclerView.ViewHolder>(native_viewHolder, JniHandleOwnership.DoNotTransfer);
			@object.StartDrag(object2);
		}

		// Token: 0x06000184 RID: 388 RVA: 0x000033CC File Offset: 0x000015CC
		[Register("startDrag", "(Landroidx/recyclerview/widget/RecyclerView$ViewHolder;)V", "GetStartDrag_Landroidx_recyclerview_widget_RecyclerView_ViewHolder_Handler")]
		public unsafe virtual void StartDrag(RecyclerView.ViewHolder viewHolder)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((viewHolder == null) ? IntPtr.Zero : viewHolder.Handle);
				ItemTouchHelper._members.InstanceMethods.InvokeVirtualVoidMethod("startDrag.(Landroidx/recyclerview/widget/RecyclerView$ViewHolder;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(viewHolder);
			}
		}

		// Token: 0x06000185 RID: 389 RVA: 0x00003430 File Offset: 0x00001630
		private static Delegate GetStartSwipe_Landroidx_recyclerview_widget_RecyclerView_ViewHolder_Handler()
		{
			if (ItemTouchHelper.cb_startSwipe_Landroidx_recyclerview_widget_RecyclerView_ViewHolder_ == null)
			{
				ItemTouchHelper.cb_startSwipe_Landroidx_recyclerview_widget_RecyclerView_ViewHolder_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(ItemTouchHelper.n_StartSwipe_Landroidx_recyclerview_widget_RecyclerView_ViewHolder_));
			}
			return ItemTouchHelper.cb_startSwipe_Landroidx_recyclerview_widget_RecyclerView_ViewHolder_;
		}

		// Token: 0x06000186 RID: 390 RVA: 0x00003454 File Offset: 0x00001654
		private static void n_StartSwipe_Landroidx_recyclerview_widget_RecyclerView_ViewHolder_(IntPtr jnienv, IntPtr native__this, IntPtr native_viewHolder)
		{
			ItemTouchHelper @object = Java.Lang.Object.GetObject<ItemTouchHelper>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			RecyclerView.ViewHolder object2 = Java.Lang.Object.GetObject<RecyclerView.ViewHolder>(native_viewHolder, JniHandleOwnership.DoNotTransfer);
			@object.StartSwipe(object2);
		}

		// Token: 0x06000187 RID: 391 RVA: 0x00003478 File Offset: 0x00001678
		[Register("startSwipe", "(Landroidx/recyclerview/widget/RecyclerView$ViewHolder;)V", "GetStartSwipe_Landroidx_recyclerview_widget_RecyclerView_ViewHolder_Handler")]
		public unsafe virtual void StartSwipe(RecyclerView.ViewHolder viewHolder)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((viewHolder == null) ? IntPtr.Zero : viewHolder.Handle);
				ItemTouchHelper._members.InstanceMethods.InvokeVirtualVoidMethod("startSwipe.(Landroidx/recyclerview/widget/RecyclerView$ViewHolder;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(viewHolder);
			}
		}

		// Token: 0x0400001F RID: 31
		private static readonly JniPeerMembers _members = new XAPeerMembers("androidx/recyclerview/widget/ItemTouchHelper", typeof(ItemTouchHelper));

		// Token: 0x04000020 RID: 32
		private static Delegate cb_attachToRecyclerView_Landroidx_recyclerview_widget_RecyclerView_;

		// Token: 0x04000021 RID: 33
		private static Delegate cb_onChildViewAttachedToWindow_Landroid_view_View_;

		// Token: 0x04000022 RID: 34
		private static Delegate cb_onChildViewDetachedFromWindow_Landroid_view_View_;

		// Token: 0x04000023 RID: 35
		private static Delegate cb_startDrag_Landroidx_recyclerview_widget_RecyclerView_ViewHolder_;

		// Token: 0x04000024 RID: 36
		private static Delegate cb_startSwipe_Landroidx_recyclerview_widget_RecyclerView_ViewHolder_;

		// Token: 0x02000050 RID: 80
		[Register("androidx/recyclerview/widget/ItemTouchHelper$Callback", DoNotGenerateAcw = true)]
		public abstract class Callback : Java.Lang.Object
		{
			// Token: 0x17000017 RID: 23
			// (get) Token: 0x06000189 RID: 393 RVA: 0x000034F8 File Offset: 0x000016F8
			internal static IntPtr class_ref
			{
				get
				{
					return ItemTouchHelper.Callback._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x17000018 RID: 24
			// (get) Token: 0x0600018A RID: 394 RVA: 0x0000351C File Offset: 0x0000171C
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return ItemTouchHelper.Callback._members;
				}
			}

			// Token: 0x17000019 RID: 25
			// (get) Token: 0x0600018B RID: 395 RVA: 0x00003524 File Offset: 0x00001724
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return ItemTouchHelper.Callback._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x1700001A RID: 26
			// (get) Token: 0x0600018C RID: 396 RVA: 0x00003548 File Offset: 0x00001748
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return ItemTouchHelper.Callback._members.ManagedPeerType;
				}
			}

			// Token: 0x0600018D RID: 397 RVA: 0x000026A8 File Offset: 0x000008A8
			protected Callback(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
			{
			}

			// Token: 0x0600018E RID: 398 RVA: 0x00003554 File Offset: 0x00001754
			[Register(".ctor", "()V", "")]
			public Callback() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (base.Handle != IntPtr.Zero)
				{
					return;
				}
				base.SetHandle(ItemTouchHelper.Callback._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
				ItemTouchHelper.Callback._members.InstanceMethods.FinishCreateInstance("()V", this, null);
			}

			// Token: 0x0600018F RID: 399 RVA: 0x000035C2 File Offset: 0x000017C2
			private static Delegate GetGetBoundingBoxMarginHandler()
			{
				if (ItemTouchHelper.Callback.cb_getBoundingBoxMargin == null)
				{
					ItemTouchHelper.Callback.cb_getBoundingBoxMargin = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(ItemTouchHelper.Callback.n_GetBoundingBoxMargin));
				}
				return ItemTouchHelper.Callback.cb_getBoundingBoxMargin;
			}

			// Token: 0x06000190 RID: 400 RVA: 0x000035E6 File Offset: 0x000017E6
			private static int n_GetBoundingBoxMargin(IntPtr jnienv, IntPtr native__this)
			{
				return Java.Lang.Object.GetObject<ItemTouchHelper.Callback>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).BoundingBoxMargin;
			}

			// Token: 0x1700001B RID: 27
			// (get) Token: 0x06000191 RID: 401 RVA: 0x000035F5 File Offset: 0x000017F5
			public virtual int BoundingBoxMargin
			{
				[Register("getBoundingBoxMargin", "()I", "GetGetBoundingBoxMarginHandler")]
				get
				{
					return ItemTouchHelper.Callback._members.InstanceMethods.InvokeVirtualInt32Method("getBoundingBoxMargin.()I", this, null);
				}
			}

			// Token: 0x1700001C RID: 28
			// (get) Token: 0x06000192 RID: 402 RVA: 0x00003610 File Offset: 0x00001810
			public static IItemTouchUIUtil DefaultUIUtil
			{
				[Register("getDefaultUIUtil", "()Landroidx/recyclerview/widget/ItemTouchUIUtil;", "")]
				get
				{
					return Java.Lang.Object.GetObject<IItemTouchUIUtil>(ItemTouchHelper.Callback._members.StaticMethods.InvokeObjectMethod("getDefaultUIUtil.()Landroidx/recyclerview/widget/ItemTouchUIUtil;", null).Handle, JniHandleOwnership.TransferLocalRef);
				}
			}

			// Token: 0x06000193 RID: 403 RVA: 0x00003641 File Offset: 0x00001841
			private static Delegate GetIsItemViewSwipeEnabledHandler()
			{
				if (ItemTouchHelper.Callback.cb_isItemViewSwipeEnabled == null)
				{
					ItemTouchHelper.Callback.cb_isItemViewSwipeEnabled = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(ItemTouchHelper.Callback.n_IsItemViewSwipeEnabled));
				}
				return ItemTouchHelper.Callback.cb_isItemViewSwipeEnabled;
			}

			// Token: 0x06000194 RID: 404 RVA: 0x00003665 File Offset: 0x00001865
			private static bool n_IsItemViewSwipeEnabled(IntPtr jnienv, IntPtr native__this)
			{
				return Java.Lang.Object.GetObject<ItemTouchHelper.Callback>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsItemViewSwipeEnabled;
			}

			// Token: 0x1700001D RID: 29
			// (get) Token: 0x06000195 RID: 405 RVA: 0x00003674 File Offset: 0x00001874
			public virtual bool IsItemViewSwipeEnabled
			{
				[Register("isItemViewSwipeEnabled", "()Z", "GetIsItemViewSwipeEnabledHandler")]
				get
				{
					return ItemTouchHelper.Callback._members.InstanceMethods.InvokeVirtualBooleanMethod("isItemViewSwipeEnabled.()Z", this, null);
				}
			}

			// Token: 0x06000196 RID: 406 RVA: 0x0000368D File Offset: 0x0000188D
			private static Delegate GetIsLongPressDragEnabledHandler()
			{
				if (ItemTouchHelper.Callback.cb_isLongPressDragEnabled == null)
				{
					ItemTouchHelper.Callback.cb_isLongPressDragEnabled = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(ItemTouchHelper.Callback.n_IsLongPressDragEnabled));
				}
				return ItemTouchHelper.Callback.cb_isLongPressDragEnabled;
			}

			// Token: 0x06000197 RID: 407 RVA: 0x000036B1 File Offset: 0x000018B1
			private static bool n_IsLongPressDragEnabled(IntPtr jnienv, IntPtr native__this)
			{
				return Java.Lang.Object.GetObject<ItemTouchHelper.Callback>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsLongPressDragEnabled;
			}

			// Token: 0x1700001E RID: 30
			// (get) Token: 0x06000198 RID: 408 RVA: 0x000036C0 File Offset: 0x000018C0
			public virtual bool IsLongPressDragEnabled
			{
				[Register("isLongPressDragEnabled", "()Z", "GetIsLongPressDragEnabledHandler")]
				get
				{
					return ItemTouchHelper.Callback._members.InstanceMethods.InvokeVirtualBooleanMethod("isLongPressDragEnabled.()Z", this, null);
				}
			}

			// Token: 0x06000199 RID: 409 RVA: 0x000036D9 File Offset: 0x000018D9
			private static Delegate GetCanDropOver_Landroidx_recyclerview_widget_RecyclerView_Landroidx_recyclerview_widget_RecyclerView_ViewHolder_Landroidx_recyclerview_widget_RecyclerView_ViewHolder_Handler()
			{
				if (ItemTouchHelper.Callback.cb_canDropOver_Landroidx_recyclerview_widget_RecyclerView_Landroidx_recyclerview_widget_RecyclerView_ViewHolder_Landroidx_recyclerview_widget_RecyclerView_ViewHolder_ == null)
				{
					ItemTouchHelper.Callback.cb_canDropOver_Landroidx_recyclerview_widget_RecyclerView_Landroidx_recyclerview_widget_RecyclerView_ViewHolder_Landroidx_recyclerview_widget_RecyclerView_ViewHolder_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLLL_Z(ItemTouchHelper.Callback.n_CanDropOver_Landroidx_recyclerview_widget_RecyclerView_Landroidx_recyclerview_widget_RecyclerView_ViewHolder_Landroidx_recyclerview_widget_RecyclerView_ViewHolder_));
				}
				return ItemTouchHelper.Callback.cb_canDropOver_Landroidx_recyclerview_widget_RecyclerView_Landroidx_recyclerview_widget_RecyclerView_ViewHolder_Landroidx_recyclerview_widget_RecyclerView_ViewHolder_;
			}

			// Token: 0x0600019A RID: 410 RVA: 0x00003700 File Offset: 0x00001900
			private static bool n_CanDropOver_Landroidx_recyclerview_widget_RecyclerView_Landroidx_recyclerview_widget_RecyclerView_ViewHolder_Landroidx_recyclerview_widget_RecyclerView_ViewHolder_(IntPtr jnienv, IntPtr native__this, IntPtr native_recyclerView, IntPtr native_current, IntPtr native_target)
			{
				ItemTouchHelper.Callback @object = Java.Lang.Object.GetObject<ItemTouchHelper.Callback>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				RecyclerView object2 = Java.Lang.Object.GetObject<RecyclerView>(native_recyclerView, JniHandleOwnership.DoNotTransfer);
				RecyclerView.ViewHolder object3 = Java.Lang.Object.GetObject<RecyclerView.ViewHolder>(native_current, JniHandleOwnership.DoNotTransfer);
				RecyclerView.ViewHolder object4 = Java.Lang.Object.GetObject<RecyclerView.ViewHolder>(native_target, JniHandleOwnership.DoNotTransfer);
				return @object.CanDropOver(object2, object3, object4);
			}

			// Token: 0x0600019B RID: 411 RVA: 0x00003738 File Offset: 0x00001938
			[Register("canDropOver", "(Landroidx/recyclerview/widget/RecyclerView;Landroidx/recyclerview/widget/RecyclerView$ViewHolder;Landroidx/recyclerview/widget/RecyclerView$ViewHolder;)Z", "GetCanDropOver_Landroidx_recyclerview_widget_RecyclerView_Landroidx_recyclerview_widget_RecyclerView_ViewHolder_Landroidx_recyclerview_widget_RecyclerView_ViewHolder_Handler")]
			public unsafe virtual bool CanDropOver(RecyclerView recyclerView, RecyclerView.ViewHolder current, RecyclerView.ViewHolder target)
			{
				bool result;
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((recyclerView == null) ? IntPtr.Zero : recyclerView.Handle);
					ptr[1] = new JniArgumentValue((current == null) ? IntPtr.Zero : current.Handle);
					ptr[2] = new JniArgumentValue((target == null) ? IntPtr.Zero : target.Handle);
					result = ItemTouchHelper.Callback._members.InstanceMethods.InvokeVirtualBooleanMethod("canDropOver.(Landroidx/recyclerview/widget/RecyclerView;Landroidx/recyclerview/widget/RecyclerView$ViewHolder;Landroidx/recyclerview/widget/RecyclerView$ViewHolder;)Z", this, ptr);
				}
				finally
				{
					GC.KeepAlive(recyclerView);
					GC.KeepAlive(current);
					GC.KeepAlive(target);
				}
				return result;
			}

			// Token: 0x0600019C RID: 412 RVA: 0x000037F0 File Offset: 0x000019F0
			private static Delegate GetChooseDropTarget_Landroidx_recyclerview_widget_RecyclerView_ViewHolder_Ljava_util_List_IIHandler()
			{
				if (ItemTouchHelper.Callback.cb_chooseDropTarget_Landroidx_recyclerview_widget_RecyclerView_ViewHolder_Ljava_util_List_II == null)
				{
					ItemTouchHelper.Callback.cb_chooseDropTarget_Landroidx_recyclerview_widget_RecyclerView_ViewHolder_Ljava_util_List_II = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLLII_L(ItemTouchHelper.Callback.n_ChooseDropTarget_Landroidx_recyclerview_widget_RecyclerView_ViewHolder_Ljava_util_List_II));
				}
				return ItemTouchHelper.Callback.cb_chooseDropTarget_Landroidx_recyclerview_widget_RecyclerView_ViewHolder_Ljava_util_List_II;
			}

			// Token: 0x0600019D RID: 413 RVA: 0x00003814 File Offset: 0x00001A14
			private static IntPtr n_ChooseDropTarget_Landroidx_recyclerview_widget_RecyclerView_ViewHolder_Ljava_util_List_II(IntPtr jnienv, IntPtr native__this, IntPtr native_selected, IntPtr native_dropTargets, int curX, int curY)
			{
				ItemTouchHelper.Callback @object = Java.Lang.Object.GetObject<ItemTouchHelper.Callback>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				RecyclerView.ViewHolder object2 = Java.Lang.Object.GetObject<RecyclerView.ViewHolder>(native_selected, JniHandleOwnership.DoNotTransfer);
				IList<RecyclerView.ViewHolder> dropTargets = JavaList<RecyclerView.ViewHolder>.FromJniHandle(native_dropTargets, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle(@object.ChooseDropTarget(object2, dropTargets, curX, curY));
			}

			// Token: 0x0600019E RID: 414 RVA: 0x0000384C File Offset: 0x00001A4C
			[Register("chooseDropTarget", "(Landroidx/recyclerview/widget/RecyclerView$ViewHolder;Ljava/util/List;II)Landroidx/recyclerview/widget/RecyclerView$ViewHolder;", "GetChooseDropTarget_Landroidx_recyclerview_widget_RecyclerView_ViewHolder_Ljava_util_List_IIHandler")]
			public unsafe virtual RecyclerView.ViewHolder ChooseDropTarget(RecyclerView.ViewHolder selected, IList<RecyclerView.ViewHolder> dropTargets, int curX, int curY)
			{
				IntPtr intPtr = JavaList<RecyclerView.ViewHolder>.ToLocalJniHandle(dropTargets);
				RecyclerView.ViewHolder @object;
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((selected == null) ? IntPtr.Zero : selected.Handle);
					ptr[1] = new JniArgumentValue(intPtr);
					ptr[2] = new JniArgumentValue(curX);
					ptr[3] = new JniArgumentValue(curY);
					@object = Java.Lang.Object.GetObject<RecyclerView.ViewHolder>(ItemTouchHelper.Callback._members.InstanceMethods.InvokeVirtualObjectMethod("chooseDropTarget.(Landroidx/recyclerview/widget/RecyclerView$ViewHolder;Ljava/util/List;II)Landroidx/recyclerview/widget/RecyclerView$ViewHolder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
				}
				finally
				{
					JNIEnv.DeleteLocalRef(intPtr);
					GC.KeepAlive(selected);
					GC.KeepAlive(dropTargets);
				}
				return @object;
			}

			// Token: 0x0600019F RID: 415 RVA: 0x00003914 File Offset: 0x00001B14
			private static Delegate GetClearView_Landroidx_recyclerview_widget_RecyclerView_Landroidx_recyclerview_widget_RecyclerView_ViewHolder_Handler()
			{
				if (ItemTouchHelper.Callback.cb_clearView_Landroidx_recyclerview_widget_RecyclerView_Landroidx_recyclerview_widget_RecyclerView_ViewHolder_ == null)
				{
					ItemTouchHelper.Callback.cb_clearView_Landroidx_recyclerview_widget_RecyclerView_Landroidx_recyclerview_widget_RecyclerView_ViewHolder_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_V(ItemTouchHelper.Callback.n_ClearView_Landroidx_recyclerview_widget_RecyclerView_Landroidx_recyclerview_widget_RecyclerView_ViewHolder_));
				}
				return ItemTouchHelper.Callback.cb_clearView_Landroidx_recyclerview_widget_RecyclerView_Landroidx_recyclerview_widget_RecyclerView_ViewHolder_;
			}

			// Token: 0x060001A0 RID: 416 RVA: 0x00003938 File Offset: 0x00001B38
			private static void n_ClearView_Landroidx_recyclerview_widget_RecyclerView_Landroidx_recyclerview_widget_RecyclerView_ViewHolder_(IntPtr jnienv, IntPtr native__this, IntPtr native_recyclerView, IntPtr native_viewHolder)
			{
				ItemTouchHelper.Callback @object = Java.Lang.Object.GetObject<ItemTouchHelper.Callback>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				RecyclerView object2 = Java.Lang.Object.GetObject<RecyclerView>(native_recyclerView, JniHandleOwnership.DoNotTransfer);
				RecyclerView.ViewHolder object3 = Java.Lang.Object.GetObject<RecyclerView.ViewHolder>(native_viewHolder, JniHandleOwnership.DoNotTransfer);
				@object.ClearView(object2, object3);
			}

			// Token: 0x060001A1 RID: 417 RVA: 0x00003964 File Offset: 0x00001B64
			[Register("clearView", "(Landroidx/recyclerview/widget/RecyclerView;Landroidx/recyclerview/widget/RecyclerView$ViewHolder;)V", "GetClearView_Landroidx_recyclerview_widget_RecyclerView_Landroidx_recyclerview_widget_RecyclerView_ViewHolder_Handler")]
			public unsafe virtual void ClearView(RecyclerView recyclerView, RecyclerView.ViewHolder viewHolder)
			{
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((recyclerView == null) ? IntPtr.Zero : recyclerView.Handle);
					ptr[1] = new JniArgumentValue((viewHolder == null) ? IntPtr.Zero : viewHolder.Handle);
					ItemTouchHelper.Callback._members.InstanceMethods.InvokeVirtualVoidMethod("clearView.(Landroidx/recyclerview/widget/RecyclerView;Landroidx/recyclerview/widget/RecyclerView$ViewHolder;)V", this, ptr);
				}
				finally
				{
					GC.KeepAlive(recyclerView);
					GC.KeepAlive(viewHolder);
				}
			}

			// Token: 0x060001A2 RID: 418 RVA: 0x000039F0 File Offset: 0x00001BF0
			private static Delegate GetConvertToAbsoluteDirection_IIHandler()
			{
				if (ItemTouchHelper.Callback.cb_convertToAbsoluteDirection_II == null)
				{
					ItemTouchHelper.Callback.cb_convertToAbsoluteDirection_II = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPII_I(ItemTouchHelper.Callback.n_ConvertToAbsoluteDirection_II));
				}
				return ItemTouchHelper.Callback.cb_convertToAbsoluteDirection_II;
			}

			// Token: 0x060001A3 RID: 419 RVA: 0x00003A14 File Offset: 0x00001C14
			private static int n_ConvertToAbsoluteDirection_II(IntPtr jnienv, IntPtr native__this, int flags, int layoutDirection)
			{
				return Java.Lang.Object.GetObject<ItemTouchHelper.Callback>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ConvertToAbsoluteDirection(flags, layoutDirection);
			}

			// Token: 0x060001A4 RID: 420 RVA: 0x00003A28 File Offset: 0x00001C28
			[Register("convertToAbsoluteDirection", "(II)I", "GetConvertToAbsoluteDirection_IIHandler")]
			public unsafe virtual int ConvertToAbsoluteDirection(int flags, int layoutDirection)
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(flags);
				ptr[1] = new JniArgumentValue(layoutDirection);
				return ItemTouchHelper.Callback._members.InstanceMethods.InvokeVirtualInt32Method("convertToAbsoluteDirection.(II)I", this, ptr);
			}

			// Token: 0x060001A5 RID: 421 RVA: 0x00003A78 File Offset: 0x00001C78
			[Register("convertToRelativeDirection", "(II)I", "")]
			public unsafe static int ConvertToRelativeDirection(int flags, int layoutDirection)
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(flags);
				ptr[1] = new JniArgumentValue(layoutDirection);
				return ItemTouchHelper.Callback._members.StaticMethods.InvokeInt32Method("convertToRelativeDirection.(II)I", ptr);
			}

			// Token: 0x060001A6 RID: 422 RVA: 0x00003AC5 File Offset: 0x00001CC5
			private static Delegate GetGetAnimationDuration_Landroidx_recyclerview_widget_RecyclerView_IFFHandler()
			{
				if (ItemTouchHelper.Callback.cb_getAnimationDuration_Landroidx_recyclerview_widget_RecyclerView_IFF == null)
				{
					ItemTouchHelper.Callback.cb_getAnimationDuration_Landroidx_recyclerview_widget_RecyclerView_IFF = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLIFF_J(ItemTouchHelper.Callback.n_GetAnimationDuration_Landroidx_recyclerview_widget_RecyclerView_IFF));
				}
				return ItemTouchHelper.Callback.cb_getAnimationDuration_Landroidx_recyclerview_widget_RecyclerView_IFF;
			}

			// Token: 0x060001A7 RID: 423 RVA: 0x00003AEC File Offset: 0x00001CEC
			private static long n_GetAnimationDuration_Landroidx_recyclerview_widget_RecyclerView_IFF(IntPtr jnienv, IntPtr native__this, IntPtr native_recyclerView, int animationType, float animateDx, float animateDy)
			{
				ItemTouchHelper.Callback @object = Java.Lang.Object.GetObject<ItemTouchHelper.Callback>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				RecyclerView object2 = Java.Lang.Object.GetObject<RecyclerView>(native_recyclerView, JniHandleOwnership.DoNotTransfer);
				return @object.GetAnimationDuration(object2, animationType, animateDx, animateDy);
			}

			// Token: 0x060001A8 RID: 424 RVA: 0x00003B14 File Offset: 0x00001D14
			[Register("getAnimationDuration", "(Landroidx/recyclerview/widget/RecyclerView;IFF)J", "GetGetAnimationDuration_Landroidx_recyclerview_widget_RecyclerView_IFFHandler")]
			public unsafe virtual long GetAnimationDuration(RecyclerView recyclerView, int animationType, float animateDx, float animateDy)
			{
				long result;
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((recyclerView == null) ? IntPtr.Zero : recyclerView.Handle);
					ptr[1] = new JniArgumentValue(animationType);
					ptr[2] = new JniArgumentValue(animateDx);
					ptr[3] = new JniArgumentValue(animateDy);
					result = ItemTouchHelper.Callback._members.InstanceMethods.InvokeVirtualInt64Method("getAnimationDuration.(Landroidx/recyclerview/widget/RecyclerView;IFF)J", this, ptr);
				}
				finally
				{
					GC.KeepAlive(recyclerView);
				}
				return result;
			}

			// Token: 0x060001A9 RID: 425 RVA: 0x00003BBC File Offset: 0x00001DBC
			private static Delegate GetGetMoveThreshold_Landroidx_recyclerview_widget_RecyclerView_ViewHolder_Handler()
			{
				if (ItemTouchHelper.Callback.cb_getMoveThreshold_Landroidx_recyclerview_widget_RecyclerView_ViewHolder_ == null)
				{
					ItemTouchHelper.Callback.cb_getMoveThreshold_Landroidx_recyclerview_widget_RecyclerView_ViewHolder_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_F(ItemTouchHelper.Callback.n_GetMoveThreshold_Landroidx_recyclerview_widget_RecyclerView_ViewHolder_));
				}
				return ItemTouchHelper.Callback.cb_getMoveThreshold_Landroidx_recyclerview_widget_RecyclerView_ViewHolder_;
			}

			// Token: 0x060001AA RID: 426 RVA: 0x00003BE0 File Offset: 0x00001DE0
			private static float n_GetMoveThreshold_Landroidx_recyclerview_widget_RecyclerView_ViewHolder_(IntPtr jnienv, IntPtr native__this, IntPtr native_viewHolder)
			{
				ItemTouchHelper.Callback @object = Java.Lang.Object.GetObject<ItemTouchHelper.Callback>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				RecyclerView.ViewHolder object2 = Java.Lang.Object.GetObject<RecyclerView.ViewHolder>(native_viewHolder, JniHandleOwnership.DoNotTransfer);
				return @object.GetMoveThreshold(object2);
			}

			// Token: 0x060001AB RID: 427 RVA: 0x00003C04 File Offset: 0x00001E04
			[Register("getMoveThreshold", "(Landroidx/recyclerview/widget/RecyclerView$ViewHolder;)F", "GetGetMoveThreshold_Landroidx_recyclerview_widget_RecyclerView_ViewHolder_Handler")]
			public unsafe virtual float GetMoveThreshold(RecyclerView.ViewHolder viewHolder)
			{
				float result;
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((viewHolder == null) ? IntPtr.Zero : viewHolder.Handle);
					result = ItemTouchHelper.Callback._members.InstanceMethods.InvokeVirtualSingleMethod("getMoveThreshold.(Landroidx/recyclerview/widget/RecyclerView$ViewHolder;)F", this, ptr);
				}
				finally
				{
					GC.KeepAlive(viewHolder);
				}
				return result;
			}

			// Token: 0x060001AC RID: 428 RVA: 0x00003C6C File Offset: 0x00001E6C
			private static Delegate GetGetMovementFlags_Landroidx_recyclerview_widget_RecyclerView_Landroidx_recyclerview_widget_RecyclerView_ViewHolder_Handler()
			{
				if (ItemTouchHelper.Callback.cb_getMovementFlags_Landroidx_recyclerview_widget_RecyclerView_Landroidx_recyclerview_widget_RecyclerView_ViewHolder_ == null)
				{
					ItemTouchHelper.Callback.cb_getMovementFlags_Landroidx_recyclerview_widget_RecyclerView_Landroidx_recyclerview_widget_RecyclerView_ViewHolder_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_I(ItemTouchHelper.Callback.n_GetMovementFlags_Landroidx_recyclerview_widget_RecyclerView_Landroidx_recyclerview_widget_RecyclerView_ViewHolder_));
				}
				return ItemTouchHelper.Callback.cb_getMovementFlags_Landroidx_recyclerview_widget_RecyclerView_Landroidx_recyclerview_widget_RecyclerView_ViewHolder_;
			}

			// Token: 0x060001AD RID: 429 RVA: 0x00003C90 File Offset: 0x00001E90
			private static int n_GetMovementFlags_Landroidx_recyclerview_widget_RecyclerView_Landroidx_recyclerview_widget_RecyclerView_ViewHolder_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
			{
				ItemTouchHelper.Callback @object = Java.Lang.Object.GetObject<ItemTouchHelper.Callback>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				RecyclerView object2 = Java.Lang.Object.GetObject<RecyclerView>(native_p0, JniHandleOwnership.DoNotTransfer);
				RecyclerView.ViewHolder object3 = Java.Lang.Object.GetObject<RecyclerView.ViewHolder>(native_p1, JniHandleOwnership.DoNotTransfer);
				return @object.GetMovementFlags(object2, object3);
			}

			// Token: 0x060001AE RID: 430
			[Register("getMovementFlags", "(Landroidx/recyclerview/widget/RecyclerView;Landroidx/recyclerview/widget/RecyclerView$ViewHolder;)I", "GetGetMovementFlags_Landroidx_recyclerview_widget_RecyclerView_Landroidx_recyclerview_widget_RecyclerView_ViewHolder_Handler")]
			public abstract int GetMovementFlags(RecyclerView p0, RecyclerView.ViewHolder p1);

			// Token: 0x060001AF RID: 431 RVA: 0x00003CBC File Offset: 0x00001EBC
			private static Delegate GetGetSwipeEscapeVelocity_FHandler()
			{
				if (ItemTouchHelper.Callback.cb_getSwipeEscapeVelocity_F == null)
				{
					ItemTouchHelper.Callback.cb_getSwipeEscapeVelocity_F = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPF_F(ItemTouchHelper.Callback.n_GetSwipeEscapeVelocity_F));
				}
				return ItemTouchHelper.Callback.cb_getSwipeEscapeVelocity_F;
			}

			// Token: 0x060001B0 RID: 432 RVA: 0x00003CE0 File Offset: 0x00001EE0
			private static float n_GetSwipeEscapeVelocity_F(IntPtr jnienv, IntPtr native__this, float defaultValue)
			{
				return Java.Lang.Object.GetObject<ItemTouchHelper.Callback>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).GetSwipeEscapeVelocity(defaultValue);
			}

			// Token: 0x060001B1 RID: 433 RVA: 0x00003CF0 File Offset: 0x00001EF0
			[Register("getSwipeEscapeVelocity", "(F)F", "GetGetSwipeEscapeVelocity_FHandler")]
			public unsafe virtual float GetSwipeEscapeVelocity(float defaultValue)
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(defaultValue);
				return ItemTouchHelper.Callback._members.InstanceMethods.InvokeVirtualSingleMethod("getSwipeEscapeVelocity.(F)F", this, ptr);
			}

			// Token: 0x060001B2 RID: 434 RVA: 0x00003D2B File Offset: 0x00001F2B
			private static Delegate GetGetSwipeThreshold_Landroidx_recyclerview_widget_RecyclerView_ViewHolder_Handler()
			{
				if (ItemTouchHelper.Callback.cb_getSwipeThreshold_Landroidx_recyclerview_widget_RecyclerView_ViewHolder_ == null)
				{
					ItemTouchHelper.Callback.cb_getSwipeThreshold_Landroidx_recyclerview_widget_RecyclerView_ViewHolder_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_F(ItemTouchHelper.Callback.n_GetSwipeThreshold_Landroidx_recyclerview_widget_RecyclerView_ViewHolder_));
				}
				return ItemTouchHelper.Callback.cb_getSwipeThreshold_Landroidx_recyclerview_widget_RecyclerView_ViewHolder_;
			}

			// Token: 0x060001B3 RID: 435 RVA: 0x00003D50 File Offset: 0x00001F50
			private static float n_GetSwipeThreshold_Landroidx_recyclerview_widget_RecyclerView_ViewHolder_(IntPtr jnienv, IntPtr native__this, IntPtr native_viewHolder)
			{
				ItemTouchHelper.Callback @object = Java.Lang.Object.GetObject<ItemTouchHelper.Callback>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				RecyclerView.ViewHolder object2 = Java.Lang.Object.GetObject<RecyclerView.ViewHolder>(native_viewHolder, JniHandleOwnership.DoNotTransfer);
				return @object.GetSwipeThreshold(object2);
			}

			// Token: 0x060001B4 RID: 436 RVA: 0x00003D74 File Offset: 0x00001F74
			[Register("getSwipeThreshold", "(Landroidx/recyclerview/widget/RecyclerView$ViewHolder;)F", "GetGetSwipeThreshold_Landroidx_recyclerview_widget_RecyclerView_ViewHolder_Handler")]
			public unsafe virtual float GetSwipeThreshold(RecyclerView.ViewHolder viewHolder)
			{
				float result;
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((viewHolder == null) ? IntPtr.Zero : viewHolder.Handle);
					result = ItemTouchHelper.Callback._members.InstanceMethods.InvokeVirtualSingleMethod("getSwipeThreshold.(Landroidx/recyclerview/widget/RecyclerView$ViewHolder;)F", this, ptr);
				}
				finally
				{
					GC.KeepAlive(viewHolder);
				}
				return result;
			}

			// Token: 0x060001B5 RID: 437 RVA: 0x00003DDC File Offset: 0x00001FDC
			private static Delegate GetGetSwipeVelocityThreshold_FHandler()
			{
				if (ItemTouchHelper.Callback.cb_getSwipeVelocityThreshold_F == null)
				{
					ItemTouchHelper.Callback.cb_getSwipeVelocityThreshold_F = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPF_F(ItemTouchHelper.Callback.n_GetSwipeVelocityThreshold_F));
				}
				return ItemTouchHelper.Callback.cb_getSwipeVelocityThreshold_F;
			}

			// Token: 0x060001B6 RID: 438 RVA: 0x00003E00 File Offset: 0x00002000
			private static float n_GetSwipeVelocityThreshold_F(IntPtr jnienv, IntPtr native__this, float defaultValue)
			{
				return Java.Lang.Object.GetObject<ItemTouchHelper.Callback>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).GetSwipeVelocityThreshold(defaultValue);
			}

			// Token: 0x060001B7 RID: 439 RVA: 0x00003E10 File Offset: 0x00002010
			[Register("getSwipeVelocityThreshold", "(F)F", "GetGetSwipeVelocityThreshold_FHandler")]
			public unsafe virtual float GetSwipeVelocityThreshold(float defaultValue)
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(defaultValue);
				return ItemTouchHelper.Callback._members.InstanceMethods.InvokeVirtualSingleMethod("getSwipeVelocityThreshold.(F)F", this, ptr);
			}

			// Token: 0x060001B8 RID: 440 RVA: 0x00003E4B File Offset: 0x0000204B
			private static Delegate GetInterpolateOutOfBoundsScroll_Landroidx_recyclerview_widget_RecyclerView_IIIJHandler()
			{
				if (ItemTouchHelper.Callback.cb_interpolateOutOfBoundsScroll_Landroidx_recyclerview_widget_RecyclerView_IIIJ == null)
				{
					ItemTouchHelper.Callback.cb_interpolateOutOfBoundsScroll_Landroidx_recyclerview_widget_RecyclerView_IIIJ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLIIIJ_I(ItemTouchHelper.Callback.n_InterpolateOutOfBoundsScroll_Landroidx_recyclerview_widget_RecyclerView_IIIJ));
				}
				return ItemTouchHelper.Callback.cb_interpolateOutOfBoundsScroll_Landroidx_recyclerview_widget_RecyclerView_IIIJ;
			}

			// Token: 0x060001B9 RID: 441 RVA: 0x00003E70 File Offset: 0x00002070
			private static int n_InterpolateOutOfBoundsScroll_Landroidx_recyclerview_widget_RecyclerView_IIIJ(IntPtr jnienv, IntPtr native__this, IntPtr native_recyclerView, int viewSize, int viewSizeOutOfBounds, int totalSize, long msSinceStartScroll)
			{
				ItemTouchHelper.Callback @object = Java.Lang.Object.GetObject<ItemTouchHelper.Callback>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				RecyclerView object2 = Java.Lang.Object.GetObject<RecyclerView>(native_recyclerView, JniHandleOwnership.DoNotTransfer);
				return @object.InterpolateOutOfBoundsScroll(object2, viewSize, viewSizeOutOfBounds, totalSize, msSinceStartScroll);
			}

			// Token: 0x060001BA RID: 442 RVA: 0x00003E9C File Offset: 0x0000209C
			[Register("interpolateOutOfBoundsScroll", "(Landroidx/recyclerview/widget/RecyclerView;IIIJ)I", "GetInterpolateOutOfBoundsScroll_Landroidx_recyclerview_widget_RecyclerView_IIIJHandler")]
			public unsafe virtual int InterpolateOutOfBoundsScroll(RecyclerView recyclerView, int viewSize, int viewSizeOutOfBounds, int totalSize, long msSinceStartScroll)
			{
				int result;
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((recyclerView == null) ? IntPtr.Zero : recyclerView.Handle);
					ptr[1] = new JniArgumentValue(viewSize);
					ptr[2] = new JniArgumentValue(viewSizeOutOfBounds);
					ptr[3] = new JniArgumentValue(totalSize);
					ptr[4] = new JniArgumentValue(msSinceStartScroll);
					result = ItemTouchHelper.Callback._members.InstanceMethods.InvokeVirtualInt32Method("interpolateOutOfBoundsScroll.(Landroidx/recyclerview/widget/RecyclerView;IIIJ)I", this, ptr);
				}
				finally
				{
					GC.KeepAlive(recyclerView);
				}
				return result;
			}

			// Token: 0x060001BB RID: 443 RVA: 0x00003F58 File Offset: 0x00002158
			[Register("makeFlag", "(II)I", "")]
			public unsafe static int MakeFlag(int actionState, int directions)
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(actionState);
				ptr[1] = new JniArgumentValue(directions);
				return ItemTouchHelper.Callback._members.StaticMethods.InvokeInt32Method("makeFlag.(II)I", ptr);
			}

			// Token: 0x060001BC RID: 444 RVA: 0x00003FA8 File Offset: 0x000021A8
			[Register("makeMovementFlags", "(II)I", "")]
			public unsafe static int MakeMovementFlags(int dragFlags, int swipeFlags)
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(dragFlags);
				ptr[1] = new JniArgumentValue(swipeFlags);
				return ItemTouchHelper.Callback._members.StaticMethods.InvokeInt32Method("makeMovementFlags.(II)I", ptr);
			}

			// Token: 0x060001BD RID: 445 RVA: 0x00003FF5 File Offset: 0x000021F5
			private static Delegate GetOnChildDraw_Landroid_graphics_Canvas_Landroidx_recyclerview_widget_RecyclerView_Landroidx_recyclerview_widget_RecyclerView_ViewHolder_FFIZHandler()
			{
				if (ItemTouchHelper.Callback.cb_onChildDraw_Landroid_graphics_Canvas_Landroidx_recyclerview_widget_RecyclerView_Landroidx_recyclerview_widget_RecyclerView_ViewHolder_FFIZ == null)
				{
					ItemTouchHelper.Callback.cb_onChildDraw_Landroid_graphics_Canvas_Landroidx_recyclerview_widget_RecyclerView_Landroidx_recyclerview_widget_RecyclerView_ViewHolder_FFIZ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLLLFFIZ_V(ItemTouchHelper.Callback.n_OnChildDraw_Landroid_graphics_Canvas_Landroidx_recyclerview_widget_RecyclerView_Landroidx_recyclerview_widget_RecyclerView_ViewHolder_FFIZ));
				}
				return ItemTouchHelper.Callback.cb_onChildDraw_Landroid_graphics_Canvas_Landroidx_recyclerview_widget_RecyclerView_Landroidx_recyclerview_widget_RecyclerView_ViewHolder_FFIZ;
			}

			// Token: 0x060001BE RID: 446 RVA: 0x0000401C File Offset: 0x0000221C
			private static void n_OnChildDraw_Landroid_graphics_Canvas_Landroidx_recyclerview_widget_RecyclerView_Landroidx_recyclerview_widget_RecyclerView_ViewHolder_FFIZ(IntPtr jnienv, IntPtr native__this, IntPtr native_c, IntPtr native_recyclerView, IntPtr native_viewHolder, float dX, float dY, int actionState, bool isCurrentlyActive)
			{
				ItemTouchHelper.Callback @object = Java.Lang.Object.GetObject<ItemTouchHelper.Callback>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				Canvas object2 = Java.Lang.Object.GetObject<Canvas>(native_c, JniHandleOwnership.DoNotTransfer);
				RecyclerView object3 = Java.Lang.Object.GetObject<RecyclerView>(native_recyclerView, JniHandleOwnership.DoNotTransfer);
				RecyclerView.ViewHolder object4 = Java.Lang.Object.GetObject<RecyclerView.ViewHolder>(native_viewHolder, JniHandleOwnership.DoNotTransfer);
				@object.OnChildDraw(object2, object3, object4, dX, dY, actionState, isCurrentlyActive);
			}

			// Token: 0x060001BF RID: 447 RVA: 0x0000405C File Offset: 0x0000225C
			[Register("onChildDraw", "(Landroid/graphics/Canvas;Landroidx/recyclerview/widget/RecyclerView;Landroidx/recyclerview/widget/RecyclerView$ViewHolder;FFIZ)V", "GetOnChildDraw_Landroid_graphics_Canvas_Landroidx_recyclerview_widget_RecyclerView_Landroidx_recyclerview_widget_RecyclerView_ViewHolder_FFIZHandler")]
			public unsafe virtual void OnChildDraw(Canvas c, RecyclerView recyclerView, RecyclerView.ViewHolder viewHolder, float dX, float dY, int actionState, bool isCurrentlyActive)
			{
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((c == null) ? IntPtr.Zero : c.Handle);
					ptr[1] = new JniArgumentValue((recyclerView == null) ? IntPtr.Zero : recyclerView.Handle);
					ptr[2] = new JniArgumentValue((viewHolder == null) ? IntPtr.Zero : viewHolder.Handle);
					ptr[3] = new JniArgumentValue(dX);
					ptr[4] = new JniArgumentValue(dY);
					ptr[5] = new JniArgumentValue(actionState);
					ptr[6] = new JniArgumentValue(isCurrentlyActive);
					ItemTouchHelper.Callback._members.InstanceMethods.InvokeVirtualVoidMethod("onChildDraw.(Landroid/graphics/Canvas;Landroidx/recyclerview/widget/RecyclerView;Landroidx/recyclerview/widget/RecyclerView$ViewHolder;FFIZ)V", this, ptr);
				}
				finally
				{
					GC.KeepAlive(c);
					GC.KeepAlive(recyclerView);
					GC.KeepAlive(viewHolder);
				}
			}

			// Token: 0x060001C0 RID: 448 RVA: 0x00004170 File Offset: 0x00002370
			private static Delegate GetOnChildDrawOver_Landroid_graphics_Canvas_Landroidx_recyclerview_widget_RecyclerView_Landroidx_recyclerview_widget_RecyclerView_ViewHolder_FFIZHandler()
			{
				if (ItemTouchHelper.Callback.cb_onChildDrawOver_Landroid_graphics_Canvas_Landroidx_recyclerview_widget_RecyclerView_Landroidx_recyclerview_widget_RecyclerView_ViewHolder_FFIZ == null)
				{
					ItemTouchHelper.Callback.cb_onChildDrawOver_Landroid_graphics_Canvas_Landroidx_recyclerview_widget_RecyclerView_Landroidx_recyclerview_widget_RecyclerView_ViewHolder_FFIZ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLLLFFIZ_V(ItemTouchHelper.Callback.n_OnChildDrawOver_Landroid_graphics_Canvas_Landroidx_recyclerview_widget_RecyclerView_Landroidx_recyclerview_widget_RecyclerView_ViewHolder_FFIZ));
				}
				return ItemTouchHelper.Callback.cb_onChildDrawOver_Landroid_graphics_Canvas_Landroidx_recyclerview_widget_RecyclerView_Landroidx_recyclerview_widget_RecyclerView_ViewHolder_FFIZ;
			}

			// Token: 0x060001C1 RID: 449 RVA: 0x00004194 File Offset: 0x00002394
			private static void n_OnChildDrawOver_Landroid_graphics_Canvas_Landroidx_recyclerview_widget_RecyclerView_Landroidx_recyclerview_widget_RecyclerView_ViewHolder_FFIZ(IntPtr jnienv, IntPtr native__this, IntPtr native_c, IntPtr native_recyclerView, IntPtr native_viewHolder, float dX, float dY, int actionState, bool isCurrentlyActive)
			{
				ItemTouchHelper.Callback @object = Java.Lang.Object.GetObject<ItemTouchHelper.Callback>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				Canvas object2 = Java.Lang.Object.GetObject<Canvas>(native_c, JniHandleOwnership.DoNotTransfer);
				RecyclerView object3 = Java.Lang.Object.GetObject<RecyclerView>(native_recyclerView, JniHandleOwnership.DoNotTransfer);
				RecyclerView.ViewHolder object4 = Java.Lang.Object.GetObject<RecyclerView.ViewHolder>(native_viewHolder, JniHandleOwnership.DoNotTransfer);
				@object.OnChildDrawOver(object2, object3, object4, dX, dY, actionState, isCurrentlyActive);
			}

			// Token: 0x060001C2 RID: 450 RVA: 0x000041D4 File Offset: 0x000023D4
			[Register("onChildDrawOver", "(Landroid/graphics/Canvas;Landroidx/recyclerview/widget/RecyclerView;Landroidx/recyclerview/widget/RecyclerView$ViewHolder;FFIZ)V", "GetOnChildDrawOver_Landroid_graphics_Canvas_Landroidx_recyclerview_widget_RecyclerView_Landroidx_recyclerview_widget_RecyclerView_ViewHolder_FFIZHandler")]
			public unsafe virtual void OnChildDrawOver(Canvas c, RecyclerView recyclerView, RecyclerView.ViewHolder viewHolder, float dX, float dY, int actionState, bool isCurrentlyActive)
			{
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((c == null) ? IntPtr.Zero : c.Handle);
					ptr[1] = new JniArgumentValue((recyclerView == null) ? IntPtr.Zero : recyclerView.Handle);
					ptr[2] = new JniArgumentValue((viewHolder == null) ? IntPtr.Zero : viewHolder.Handle);
					ptr[3] = new JniArgumentValue(dX);
					ptr[4] = new JniArgumentValue(dY);
					ptr[5] = new JniArgumentValue(actionState);
					ptr[6] = new JniArgumentValue(isCurrentlyActive);
					ItemTouchHelper.Callback._members.InstanceMethods.InvokeVirtualVoidMethod("onChildDrawOver.(Landroid/graphics/Canvas;Landroidx/recyclerview/widget/RecyclerView;Landroidx/recyclerview/widget/RecyclerView$ViewHolder;FFIZ)V", this, ptr);
				}
				finally
				{
					GC.KeepAlive(c);
					GC.KeepAlive(recyclerView);
					GC.KeepAlive(viewHolder);
				}
			}

			// Token: 0x060001C3 RID: 451 RVA: 0x000042E8 File Offset: 0x000024E8
			private static Delegate GetOnMove_Landroidx_recyclerview_widget_RecyclerView_Landroidx_recyclerview_widget_RecyclerView_ViewHolder_Landroidx_recyclerview_widget_RecyclerView_ViewHolder_Handler()
			{
				if (ItemTouchHelper.Callback.cb_onMove_Landroidx_recyclerview_widget_RecyclerView_Landroidx_recyclerview_widget_RecyclerView_ViewHolder_Landroidx_recyclerview_widget_RecyclerView_ViewHolder_ == null)
				{
					ItemTouchHelper.Callback.cb_onMove_Landroidx_recyclerview_widget_RecyclerView_Landroidx_recyclerview_widget_RecyclerView_ViewHolder_Landroidx_recyclerview_widget_RecyclerView_ViewHolder_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLLL_Z(ItemTouchHelper.Callback.n_OnMove_Landroidx_recyclerview_widget_RecyclerView_Landroidx_recyclerview_widget_RecyclerView_ViewHolder_Landroidx_recyclerview_widget_RecyclerView_ViewHolder_));
				}
				return ItemTouchHelper.Callback.cb_onMove_Landroidx_recyclerview_widget_RecyclerView_Landroidx_recyclerview_widget_RecyclerView_ViewHolder_Landroidx_recyclerview_widget_RecyclerView_ViewHolder_;
			}

			// Token: 0x060001C4 RID: 452 RVA: 0x0000430C File Offset: 0x0000250C
			private static bool n_OnMove_Landroidx_recyclerview_widget_RecyclerView_Landroidx_recyclerview_widget_RecyclerView_ViewHolder_Landroidx_recyclerview_widget_RecyclerView_ViewHolder_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
			{
				ItemTouchHelper.Callback @object = Java.Lang.Object.GetObject<ItemTouchHelper.Callback>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				RecyclerView object2 = Java.Lang.Object.GetObject<RecyclerView>(native_p0, JniHandleOwnership.DoNotTransfer);
				RecyclerView.ViewHolder object3 = Java.Lang.Object.GetObject<RecyclerView.ViewHolder>(native_p1, JniHandleOwnership.DoNotTransfer);
				RecyclerView.ViewHolder object4 = Java.Lang.Object.GetObject<RecyclerView.ViewHolder>(native_p2, JniHandleOwnership.DoNotTransfer);
				return @object.OnMove(object2, object3, object4);
			}

			// Token: 0x060001C5 RID: 453
			[Register("onMove", "(Landroidx/recyclerview/widget/RecyclerView;Landroidx/recyclerview/widget/RecyclerView$ViewHolder;Landroidx/recyclerview/widget/RecyclerView$ViewHolder;)Z", "GetOnMove_Landroidx_recyclerview_widget_RecyclerView_Landroidx_recyclerview_widget_RecyclerView_ViewHolder_Landroidx_recyclerview_widget_RecyclerView_ViewHolder_Handler")]
			public abstract bool OnMove(RecyclerView p0, RecyclerView.ViewHolder p1, RecyclerView.ViewHolder p2);

			// Token: 0x060001C6 RID: 454 RVA: 0x00004342 File Offset: 0x00002542
			private static Delegate GetOnMoved_Landroidx_recyclerview_widget_RecyclerView_Landroidx_recyclerview_widget_RecyclerView_ViewHolder_ILandroidx_recyclerview_widget_RecyclerView_ViewHolder_IIIHandler()
			{
				if (ItemTouchHelper.Callback.cb_onMoved_Landroidx_recyclerview_widget_RecyclerView_Landroidx_recyclerview_widget_RecyclerView_ViewHolder_ILandroidx_recyclerview_widget_RecyclerView_ViewHolder_III == null)
				{
					ItemTouchHelper.Callback.cb_onMoved_Landroidx_recyclerview_widget_RecyclerView_Landroidx_recyclerview_widget_RecyclerView_ViewHolder_ILandroidx_recyclerview_widget_RecyclerView_ViewHolder_III = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLLILIII_V(ItemTouchHelper.Callback.n_OnMoved_Landroidx_recyclerview_widget_RecyclerView_Landroidx_recyclerview_widget_RecyclerView_ViewHolder_ILandroidx_recyclerview_widget_RecyclerView_ViewHolder_III));
				}
				return ItemTouchHelper.Callback.cb_onMoved_Landroidx_recyclerview_widget_RecyclerView_Landroidx_recyclerview_widget_RecyclerView_ViewHolder_ILandroidx_recyclerview_widget_RecyclerView_ViewHolder_III;
			}

			// Token: 0x060001C7 RID: 455 RVA: 0x00004368 File Offset: 0x00002568
			private static void n_OnMoved_Landroidx_recyclerview_widget_RecyclerView_Landroidx_recyclerview_widget_RecyclerView_ViewHolder_ILandroidx_recyclerview_widget_RecyclerView_ViewHolder_III(IntPtr jnienv, IntPtr native__this, IntPtr native_recyclerView, IntPtr native_viewHolder, int fromPos, IntPtr native_target, int toPos, int x, int y)
			{
				ItemTouchHelper.Callback @object = Java.Lang.Object.GetObject<ItemTouchHelper.Callback>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				RecyclerView object2 = Java.Lang.Object.GetObject<RecyclerView>(native_recyclerView, JniHandleOwnership.DoNotTransfer);
				RecyclerView.ViewHolder object3 = Java.Lang.Object.GetObject<RecyclerView.ViewHolder>(native_viewHolder, JniHandleOwnership.DoNotTransfer);
				RecyclerView.ViewHolder object4 = Java.Lang.Object.GetObject<RecyclerView.ViewHolder>(native_target, JniHandleOwnership.DoNotTransfer);
				@object.OnMoved(object2, object3, fromPos, object4, toPos, x, y);
			}

			// Token: 0x060001C8 RID: 456 RVA: 0x000043A8 File Offset: 0x000025A8
			[Register("onMoved", "(Landroidx/recyclerview/widget/RecyclerView;Landroidx/recyclerview/widget/RecyclerView$ViewHolder;ILandroidx/recyclerview/widget/RecyclerView$ViewHolder;III)V", "GetOnMoved_Landroidx_recyclerview_widget_RecyclerView_Landroidx_recyclerview_widget_RecyclerView_ViewHolder_ILandroidx_recyclerview_widget_RecyclerView_ViewHolder_IIIHandler")]
			public unsafe virtual void OnMoved(RecyclerView recyclerView, RecyclerView.ViewHolder viewHolder, int fromPos, RecyclerView.ViewHolder target, int toPos, int x, int y)
			{
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((recyclerView == null) ? IntPtr.Zero : recyclerView.Handle);
					ptr[1] = new JniArgumentValue((viewHolder == null) ? IntPtr.Zero : viewHolder.Handle);
					ptr[2] = new JniArgumentValue(fromPos);
					ptr[3] = new JniArgumentValue((target == null) ? IntPtr.Zero : target.Handle);
					ptr[4] = new JniArgumentValue(toPos);
					ptr[5] = new JniArgumentValue(x);
					ptr[6] = new JniArgumentValue(y);
					ItemTouchHelper.Callback._members.InstanceMethods.InvokeVirtualVoidMethod("onMoved.(Landroidx/recyclerview/widget/RecyclerView;Landroidx/recyclerview/widget/RecyclerView$ViewHolder;ILandroidx/recyclerview/widget/RecyclerView$ViewHolder;III)V", this, ptr);
				}
				finally
				{
					GC.KeepAlive(recyclerView);
					GC.KeepAlive(viewHolder);
					GC.KeepAlive(target);
				}
			}

			// Token: 0x060001C9 RID: 457 RVA: 0x000044BC File Offset: 0x000026BC
			private static Delegate GetOnSelectedChanged_Landroidx_recyclerview_widget_RecyclerView_ViewHolder_IHandler()
			{
				if (ItemTouchHelper.Callback.cb_onSelectedChanged_Landroidx_recyclerview_widget_RecyclerView_ViewHolder_I == null)
				{
					ItemTouchHelper.Callback.cb_onSelectedChanged_Landroidx_recyclerview_widget_RecyclerView_ViewHolder_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLI_V(ItemTouchHelper.Callback.n_OnSelectedChanged_Landroidx_recyclerview_widget_RecyclerView_ViewHolder_I));
				}
				return ItemTouchHelper.Callback.cb_onSelectedChanged_Landroidx_recyclerview_widget_RecyclerView_ViewHolder_I;
			}

			// Token: 0x060001CA RID: 458 RVA: 0x000044E0 File Offset: 0x000026E0
			private static void n_OnSelectedChanged_Landroidx_recyclerview_widget_RecyclerView_ViewHolder_I(IntPtr jnienv, IntPtr native__this, IntPtr native_viewHolder, int actionState)
			{
				ItemTouchHelper.Callback @object = Java.Lang.Object.GetObject<ItemTouchHelper.Callback>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				RecyclerView.ViewHolder object2 = Java.Lang.Object.GetObject<RecyclerView.ViewHolder>(native_viewHolder, JniHandleOwnership.DoNotTransfer);
				@object.OnSelectedChanged(object2, actionState);
			}

			// Token: 0x060001CB RID: 459 RVA: 0x00004504 File Offset: 0x00002704
			[Register("onSelectedChanged", "(Landroidx/recyclerview/widget/RecyclerView$ViewHolder;I)V", "GetOnSelectedChanged_Landroidx_recyclerview_widget_RecyclerView_ViewHolder_IHandler")]
			public unsafe virtual void OnSelectedChanged(RecyclerView.ViewHolder viewHolder, int actionState)
			{
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((viewHolder == null) ? IntPtr.Zero : viewHolder.Handle);
					ptr[1] = new JniArgumentValue(actionState);
					ItemTouchHelper.Callback._members.InstanceMethods.InvokeVirtualVoidMethod("onSelectedChanged.(Landroidx/recyclerview/widget/RecyclerView$ViewHolder;I)V", this, ptr);
				}
				finally
				{
					GC.KeepAlive(viewHolder);
				}
			}

			// Token: 0x060001CC RID: 460 RVA: 0x0000457C File Offset: 0x0000277C
			private static Delegate GetOnSwiped_Landroidx_recyclerview_widget_RecyclerView_ViewHolder_IHandler()
			{
				if (ItemTouchHelper.Callback.cb_onSwiped_Landroidx_recyclerview_widget_RecyclerView_ViewHolder_I == null)
				{
					ItemTouchHelper.Callback.cb_onSwiped_Landroidx_recyclerview_widget_RecyclerView_ViewHolder_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLI_V(ItemTouchHelper.Callback.n_OnSwiped_Landroidx_recyclerview_widget_RecyclerView_ViewHolder_I));
				}
				return ItemTouchHelper.Callback.cb_onSwiped_Landroidx_recyclerview_widget_RecyclerView_ViewHolder_I;
			}

			// Token: 0x060001CD RID: 461 RVA: 0x000045A0 File Offset: 0x000027A0
			private static void n_OnSwiped_Landroidx_recyclerview_widget_RecyclerView_ViewHolder_I(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
			{
				ItemTouchHelper.Callback @object = Java.Lang.Object.GetObject<ItemTouchHelper.Callback>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				RecyclerView.ViewHolder object2 = Java.Lang.Object.GetObject<RecyclerView.ViewHolder>(native_p0, JniHandleOwnership.DoNotTransfer);
				@object.OnSwiped(object2, p1);
			}

			// Token: 0x060001CE RID: 462
			[Register("onSwiped", "(Landroidx/recyclerview/widget/RecyclerView$ViewHolder;I)V", "GetOnSwiped_Landroidx_recyclerview_widget_RecyclerView_ViewHolder_IHandler")]
			public abstract void OnSwiped(RecyclerView.ViewHolder p0, int p1);

			// Token: 0x04000025 RID: 37
			private static readonly JniPeerMembers _members = new XAPeerMembers("androidx/recyclerview/widget/ItemTouchHelper$Callback", typeof(ItemTouchHelper.Callback));

			// Token: 0x04000026 RID: 38
			private static Delegate cb_getBoundingBoxMargin;

			// Token: 0x04000027 RID: 39
			private static Delegate cb_isItemViewSwipeEnabled;

			// Token: 0x04000028 RID: 40
			private static Delegate cb_isLongPressDragEnabled;

			// Token: 0x04000029 RID: 41
			private static Delegate cb_canDropOver_Landroidx_recyclerview_widget_RecyclerView_Landroidx_recyclerview_widget_RecyclerView_ViewHolder_Landroidx_recyclerview_widget_RecyclerView_ViewHolder_;

			// Token: 0x0400002A RID: 42
			private static Delegate cb_chooseDropTarget_Landroidx_recyclerview_widget_RecyclerView_ViewHolder_Ljava_util_List_II;

			// Token: 0x0400002B RID: 43
			private static Delegate cb_clearView_Landroidx_recyclerview_widget_RecyclerView_Landroidx_recyclerview_widget_RecyclerView_ViewHolder_;

			// Token: 0x0400002C RID: 44
			private static Delegate cb_convertToAbsoluteDirection_II;

			// Token: 0x0400002D RID: 45
			private static Delegate cb_getAnimationDuration_Landroidx_recyclerview_widget_RecyclerView_IFF;

			// Token: 0x0400002E RID: 46
			private static Delegate cb_getMoveThreshold_Landroidx_recyclerview_widget_RecyclerView_ViewHolder_;

			// Token: 0x0400002F RID: 47
			private static Delegate cb_getMovementFlags_Landroidx_recyclerview_widget_RecyclerView_Landroidx_recyclerview_widget_RecyclerView_ViewHolder_;

			// Token: 0x04000030 RID: 48
			private static Delegate cb_getSwipeEscapeVelocity_F;

			// Token: 0x04000031 RID: 49
			private static Delegate cb_getSwipeThreshold_Landroidx_recyclerview_widget_RecyclerView_ViewHolder_;

			// Token: 0x04000032 RID: 50
			private static Delegate cb_getSwipeVelocityThreshold_F;

			// Token: 0x04000033 RID: 51
			private static Delegate cb_interpolateOutOfBoundsScroll_Landroidx_recyclerview_widget_RecyclerView_IIIJ;

			// Token: 0x04000034 RID: 52
			private static Delegate cb_onChildDraw_Landroid_graphics_Canvas_Landroidx_recyclerview_widget_RecyclerView_Landroidx_recyclerview_widget_RecyclerView_ViewHolder_FFIZ;

			// Token: 0x04000035 RID: 53
			private static Delegate cb_onChildDrawOver_Landroid_graphics_Canvas_Landroidx_recyclerview_widget_RecyclerView_Landroidx_recyclerview_widget_RecyclerView_ViewHolder_FFIZ;

			// Token: 0x04000036 RID: 54
			private static Delegate cb_onMove_Landroidx_recyclerview_widget_RecyclerView_Landroidx_recyclerview_widget_RecyclerView_ViewHolder_Landroidx_recyclerview_widget_RecyclerView_ViewHolder_;

			// Token: 0x04000037 RID: 55
			private static Delegate cb_onMoved_Landroidx_recyclerview_widget_RecyclerView_Landroidx_recyclerview_widget_RecyclerView_ViewHolder_ILandroidx_recyclerview_widget_RecyclerView_ViewHolder_III;

			// Token: 0x04000038 RID: 56
			private static Delegate cb_onSelectedChanged_Landroidx_recyclerview_widget_RecyclerView_ViewHolder_I;

			// Token: 0x04000039 RID: 57
			private static Delegate cb_onSwiped_Landroidx_recyclerview_widget_RecyclerView_ViewHolder_I;
		}

		// Token: 0x02000051 RID: 81
		[Register("androidx/recyclerview/widget/ItemTouchHelper$Callback", DoNotGenerateAcw = true)]
		internal class CallbackInvoker : ItemTouchHelper.Callback
		{
			// Token: 0x060001D0 RID: 464 RVA: 0x000045DF File Offset: 0x000027DF
			public CallbackInvoker(IntPtr handle, JniHandleOwnership transfer) : base(handle, transfer)
			{
			}

			// Token: 0x1700001F RID: 31
			// (get) Token: 0x060001D1 RID: 465 RVA: 0x000045E9 File Offset: 0x000027E9
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return ItemTouchHelper.CallbackInvoker._members;
				}
			}

			// Token: 0x17000020 RID: 32
			// (get) Token: 0x060001D2 RID: 466 RVA: 0x000045F0 File Offset: 0x000027F0
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return ItemTouchHelper.CallbackInvoker._members.ManagedPeerType;
				}
			}

			// Token: 0x060001D3 RID: 467 RVA: 0x000045FC File Offset: 0x000027FC
			[Register("getMovementFlags", "(Landroidx/recyclerview/widget/RecyclerView;Landroidx/recyclerview/widget/RecyclerView$ViewHolder;)I", "GetGetMovementFlags_Landroidx_recyclerview_widget_RecyclerView_Landroidx_recyclerview_widget_RecyclerView_ViewHolder_Handler")]
			public unsafe override int GetMovementFlags(RecyclerView p0, RecyclerView.ViewHolder p1)
			{
				int result;
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((p0 == null) ? IntPtr.Zero : p0.Handle);
					ptr[1] = new JniArgumentValue((p1 == null) ? IntPtr.Zero : p1.Handle);
					result = ItemTouchHelper.CallbackInvoker._members.InstanceMethods.InvokeAbstractInt32Method("getMovementFlags.(Landroidx/recyclerview/widget/RecyclerView;Landroidx/recyclerview/widget/RecyclerView$ViewHolder;)I", this, ptr);
				}
				finally
				{
					GC.KeepAlive(p0);
					GC.KeepAlive(p1);
				}
				return result;
			}

			// Token: 0x060001D4 RID: 468 RVA: 0x0000468C File Offset: 0x0000288C
			[Register("onMove", "(Landroidx/recyclerview/widget/RecyclerView;Landroidx/recyclerview/widget/RecyclerView$ViewHolder;Landroidx/recyclerview/widget/RecyclerView$ViewHolder;)Z", "GetOnMove_Landroidx_recyclerview_widget_RecyclerView_Landroidx_recyclerview_widget_RecyclerView_ViewHolder_Landroidx_recyclerview_widget_RecyclerView_ViewHolder_Handler")]
			public unsafe override bool OnMove(RecyclerView p0, RecyclerView.ViewHolder p1, RecyclerView.ViewHolder p2)
			{
				bool result;
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((p0 == null) ? IntPtr.Zero : p0.Handle);
					ptr[1] = new JniArgumentValue((p1 == null) ? IntPtr.Zero : p1.Handle);
					ptr[2] = new JniArgumentValue((p2 == null) ? IntPtr.Zero : p2.Handle);
					result = ItemTouchHelper.CallbackInvoker._members.InstanceMethods.InvokeAbstractBooleanMethod("onMove.(Landroidx/recyclerview/widget/RecyclerView;Landroidx/recyclerview/widget/RecyclerView$ViewHolder;Landroidx/recyclerview/widget/RecyclerView$ViewHolder;)Z", this, ptr);
				}
				finally
				{
					GC.KeepAlive(p0);
					GC.KeepAlive(p1);
					GC.KeepAlive(p2);
				}
				return result;
			}

			// Token: 0x060001D5 RID: 469 RVA: 0x00004744 File Offset: 0x00002944
			[Register("onSwiped", "(Landroidx/recyclerview/widget/RecyclerView$ViewHolder;I)V", "GetOnSwiped_Landroidx_recyclerview_widget_RecyclerView_ViewHolder_IHandler")]
			public unsafe override void OnSwiped(RecyclerView.ViewHolder p0, int p1)
			{
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((p0 == null) ? IntPtr.Zero : p0.Handle);
					ptr[1] = new JniArgumentValue(p1);
					ItemTouchHelper.CallbackInvoker._members.InstanceMethods.InvokeAbstractVoidMethod("onSwiped.(Landroidx/recyclerview/widget/RecyclerView$ViewHolder;I)V", this, ptr);
				}
				finally
				{
					GC.KeepAlive(p0);
				}
			}

			// Token: 0x0400003A RID: 58
			private static readonly JniPeerMembers _members = new XAPeerMembers("androidx/recyclerview/widget/ItemTouchHelper$Callback", typeof(ItemTouchHelper.CallbackInvoker));
		}

		// Token: 0x02000052 RID: 82
		[Register("androidx/recyclerview/widget/ItemTouchHelper$ViewDropHandler", "", "AndroidX.RecyclerView.Widget.ItemTouchHelper/IViewDropHandlerInvoker")]
		public interface IViewDropHandler : IJavaObject, IDisposable, IJavaPeerable
		{
			// Token: 0x060001D7 RID: 471
			[Register("prepareForDrop", "(Landroid/view/View;Landroid/view/View;II)V", "GetPrepareForDrop_Landroid_view_View_Landroid_view_View_IIHandler:AndroidX.RecyclerView.Widget.ItemTouchHelper/IViewDropHandlerInvoker, Xamarin.AndroidX.RecyclerView")]
			void PrepareForDrop(View p0, View p1, int p2, int p3);
		}

		// Token: 0x02000053 RID: 83
		[Register("androidx/recyclerview/widget/ItemTouchHelper$ViewDropHandler", DoNotGenerateAcw = true)]
		internal class IViewDropHandlerInvoker : Java.Lang.Object, ItemTouchHelper.IViewDropHandler, IJavaObject, IDisposable, IJavaPeerable
		{
			// Token: 0x17000021 RID: 33
			// (get) Token: 0x060001D8 RID: 472 RVA: 0x000047D8 File Offset: 0x000029D8
			private static IntPtr java_class_ref
			{
				get
				{
					return ItemTouchHelper.IViewDropHandlerInvoker._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x17000022 RID: 34
			// (get) Token: 0x060001D9 RID: 473 RVA: 0x000047FC File Offset: 0x000029FC
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return ItemTouchHelper.IViewDropHandlerInvoker._members;
				}
			}

			// Token: 0x17000023 RID: 35
			// (get) Token: 0x060001DA RID: 474 RVA: 0x00004803 File Offset: 0x00002A03
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return this.class_ref;
				}
			}

			// Token: 0x17000024 RID: 36
			// (get) Token: 0x060001DB RID: 475 RVA: 0x0000480B File Offset: 0x00002A0B
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return ItemTouchHelper.IViewDropHandlerInvoker._members.ManagedPeerType;
				}
			}

			// Token: 0x060001DC RID: 476 RVA: 0x00004817 File Offset: 0x00002A17
			public static ItemTouchHelper.IViewDropHandler GetObject(IntPtr handle, JniHandleOwnership transfer)
			{
				return Java.Lang.Object.GetObject<ItemTouchHelper.IViewDropHandler>(handle, transfer);
			}

			// Token: 0x060001DD RID: 477 RVA: 0x00004820 File Offset: 0x00002A20
			private static IntPtr Validate(IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf(handle, ItemTouchHelper.IViewDropHandlerInvoker.java_class_ref))
				{
					throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'androidx.recyclerview.widget.ItemTouchHelper.ViewDropHandler'.");
				}
				return handle;
			}

			// Token: 0x060001DE RID: 478 RVA: 0x0000484B File Offset: 0x00002A4B
			protected override void Dispose(bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
				{
					JNIEnv.DeleteGlobalRef(this.class_ref);
				}
				this.class_ref = IntPtr.Zero;
				base.Dispose(disposing);
			}

			// Token: 0x060001DF RID: 479 RVA: 0x0000487C File Offset: 0x00002A7C
			public IViewDropHandlerInvoker(IntPtr handle, JniHandleOwnership transfer) : base(ItemTouchHelper.IViewDropHandlerInvoker.Validate(handle), transfer)
			{
				IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
				this.class_ref = JNIEnv.NewGlobalRef(objectClass);
				JNIEnv.DeleteLocalRef(objectClass);
			}

			// Token: 0x060001E0 RID: 480 RVA: 0x000048B4 File Offset: 0x00002AB4
			private static Delegate GetPrepareForDrop_Landroid_view_View_Landroid_view_View_IIHandler()
			{
				if (ItemTouchHelper.IViewDropHandlerInvoker.cb_prepareForDrop_Landroid_view_View_Landroid_view_View_II == null)
				{
					ItemTouchHelper.IViewDropHandlerInvoker.cb_prepareForDrop_Landroid_view_View_Landroid_view_View_II = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLLII_V(ItemTouchHelper.IViewDropHandlerInvoker.n_PrepareForDrop_Landroid_view_View_Landroid_view_View_II));
				}
				return ItemTouchHelper.IViewDropHandlerInvoker.cb_prepareForDrop_Landroid_view_View_Landroid_view_View_II;
			}

			// Token: 0x060001E1 RID: 481 RVA: 0x000048D8 File Offset: 0x00002AD8
			private static void n_PrepareForDrop_Landroid_view_View_Landroid_view_View_II(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, int p2, int p3)
			{
				ItemTouchHelper.IViewDropHandler @object = Java.Lang.Object.GetObject<ItemTouchHelper.IViewDropHandler>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				View object2 = Java.Lang.Object.GetObject<View>(native_p0, JniHandleOwnership.DoNotTransfer);
				View object3 = Java.Lang.Object.GetObject<View>(native_p1, JniHandleOwnership.DoNotTransfer);
				@object.PrepareForDrop(object2, object3, p2, p3);
			}

			// Token: 0x060001E2 RID: 482 RVA: 0x00004908 File Offset: 0x00002B08
			public unsafe void PrepareForDrop(View p0, View p1, int p2, int p3)
			{
				if (this.id_prepareForDrop_Landroid_view_View_Landroid_view_View_II == IntPtr.Zero)
				{
					this.id_prepareForDrop_Landroid_view_View_Landroid_view_View_II = JNIEnv.GetMethodID(this.class_ref, "prepareForDrop", "(Landroid/view/View;Landroid/view/View;II)V");
				}
				JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(JValue))];
				*ptr = new JValue((p0 == null) ? IntPtr.Zero : p0.Handle);
				ptr[1] = new JValue((p1 == null) ? IntPtr.Zero : p1.Handle);
				ptr[2] = new JValue(p2);
				ptr[3] = new JValue(p3);
				JNIEnv.CallVoidMethod(base.Handle, this.id_prepareForDrop_Landroid_view_View_Landroid_view_View_II, ptr);
			}

			// Token: 0x0400003B RID: 59
			private static readonly JniPeerMembers _members = new XAPeerMembers("androidx/recyclerview/widget/ItemTouchHelper$ViewDropHandler", typeof(ItemTouchHelper.IViewDropHandlerInvoker));

			// Token: 0x0400003C RID: 60
			private IntPtr class_ref;

			// Token: 0x0400003D RID: 61
			private static Delegate cb_prepareForDrop_Landroid_view_View_Landroid_view_View_II;

			// Token: 0x0400003E RID: 62
			private IntPtr id_prepareForDrop_Landroid_view_View_Landroid_view_View_II;
		}
	}
}
