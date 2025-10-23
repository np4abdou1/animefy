using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Content;
using Android.Runtime;
using Android.Util;
using Android.Views;
using AndroidX.RecyclerView.Widget;
using Java.Interop;
using Java.Lang;

namespace AndroidX.ViewPager2.Widget
{
	// Token: 0x0200000D RID: 13
	[Register("androidx/viewpager2/widget/ViewPager2", DoNotGenerateAcw = true)]
	public sealed class ViewPager2 : ViewGroup
	{
		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000024 RID: 36 RVA: 0x00002080 File Offset: 0x00000280
		internal static IntPtr class_ref
		{
			get
			{
				return ViewPager2._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000025 RID: 37 RVA: 0x000020A4 File Offset: 0x000002A4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return ViewPager2._members;
			}
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000026 RID: 38 RVA: 0x000020AC File Offset: 0x000002AC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return ViewPager2._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000027 RID: 39 RVA: 0x000020D0 File Offset: 0x000002D0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return ViewPager2._members.ManagedPeerType;
			}
		}

		// Token: 0x06000028 RID: 40 RVA: 0x000020DC File Offset: 0x000002DC
		internal ViewPager2(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000029 RID: 41 RVA: 0x000020E8 File Offset: 0x000002E8
		[Register(".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe ViewPager2(Context context) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((context == null) ? IntPtr.Zero : context.Handle);
				base.SetHandle(ViewPager2._members.InstanceMethods.StartCreateInstance("(Landroid/content/Context;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				ViewPager2._members.InstanceMethods.FinishCreateInstance("(Landroid/content/Context;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(context);
			}
		}

		// Token: 0x0600002A RID: 42 RVA: 0x00002198 File Offset: 0x00000398
		[Register(".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", "")]
		public unsafe ViewPager2(Context context, IAttributeSet attrs) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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
				base.SetHandle(ViewPager2._members.InstanceMethods.StartCreateInstance("(Landroid/content/Context;Landroid/util/AttributeSet;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				ViewPager2._members.InstanceMethods.FinishCreateInstance("(Landroid/content/Context;Landroid/util/AttributeSet;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(context);
				GC.KeepAlive(attrs);
			}
		}

		// Token: 0x0600002B RID: 43 RVA: 0x00002274 File Offset: 0x00000474
		[Register(".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", "")]
		public unsafe ViewPager2(Context context, IAttributeSet attrs, int defStyleAttr) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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
				base.SetHandle(ViewPager2._members.InstanceMethods.StartCreateInstance("(Landroid/content/Context;Landroid/util/AttributeSet;I)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				ViewPager2._members.InstanceMethods.FinishCreateInstance("(Landroid/content/Context;Landroid/util/AttributeSet;I)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(context);
				GC.KeepAlive(attrs);
			}
		}

		// Token: 0x0600002C RID: 44 RVA: 0x00002364 File Offset: 0x00000564
		[Register(".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;II)V", "")]
		public unsafe ViewPager2(Context context, IAttributeSet attrs, int defStyleAttr, int defStyleRes) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((context == null) ? IntPtr.Zero : context.Handle);
				ptr[1] = new JniArgumentValue((attrs == null) ? IntPtr.Zero : ((Java.Lang.Object)attrs).Handle);
				ptr[2] = new JniArgumentValue(defStyleAttr);
				ptr[3] = new JniArgumentValue(defStyleRes);
				base.SetHandle(ViewPager2._members.InstanceMethods.StartCreateInstance("(Landroid/content/Context;Landroid/util/AttributeSet;II)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				ViewPager2._members.InstanceMethods.FinishCreateInstance("(Landroid/content/Context;Landroid/util/AttributeSet;II)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(context);
				GC.KeepAlive(attrs);
			}
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x0600002D RID: 45 RVA: 0x0000246C File Offset: 0x0000066C
		// (set) Token: 0x0600002E RID: 46 RVA: 0x000024A0 File Offset: 0x000006A0
		public unsafe RecyclerView.Adapter Adapter
		{
			[Register("getAdapter", "()Landroidx/recyclerview/widget/RecyclerView$Adapter;", "")]
			get
			{
				return Java.Lang.Object.GetObject<RecyclerView.Adapter>(ViewPager2._members.InstanceMethods.InvokeAbstractObjectMethod("getAdapter.()Landroidx/recyclerview/widget/RecyclerView$Adapter;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
			[Register("setAdapter", "(Landroidx/recyclerview/widget/RecyclerView$Adapter;)V", "")]
			set
			{
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((value == null) ? IntPtr.Zero : value.Handle);
					ViewPager2._members.InstanceMethods.InvokeAbstractVoidMethod("setAdapter.(Landroidx/recyclerview/widget/RecyclerView$Adapter;)V", this, ptr);
				}
				finally
				{
					GC.KeepAlive(value);
				}
			}
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x0600002F RID: 47 RVA: 0x00002504 File Offset: 0x00000704
		// (set) Token: 0x06000030 RID: 48 RVA: 0x00002520 File Offset: 0x00000720
		public unsafe int CurrentItem
		{
			[Register("getCurrentItem", "()I", "")]
			get
			{
				return ViewPager2._members.InstanceMethods.InvokeAbstractInt32Method("getCurrentItem.()I", this, null);
			}
			[Register("setCurrentItem", "(I)V", "")]
			set
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(value);
				ViewPager2._members.InstanceMethods.InvokeAbstractVoidMethod("setCurrentItem.(I)V", this, ptr);
			}
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x06000031 RID: 49 RVA: 0x0000255B File Offset: 0x0000075B
		public bool IsFakeDragging
		{
			[Register("isFakeDragging", "()Z", "")]
			get
			{
				return ViewPager2._members.InstanceMethods.InvokeAbstractBooleanMethod("isFakeDragging.()Z", this, null);
			}
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x06000032 RID: 50 RVA: 0x00002574 File Offset: 0x00000774
		public int ItemDecorationCount
		{
			[Register("getItemDecorationCount", "()I", "")]
			get
			{
				return ViewPager2._members.InstanceMethods.InvokeAbstractInt32Method("getItemDecorationCount.()I", this, null);
			}
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x06000033 RID: 51 RVA: 0x0000258D File Offset: 0x0000078D
		// (set) Token: 0x06000034 RID: 52 RVA: 0x000025A8 File Offset: 0x000007A8
		public unsafe int OffscreenPageLimit
		{
			[Register("getOffscreenPageLimit", "()I", "")]
			get
			{
				return ViewPager2._members.InstanceMethods.InvokeAbstractInt32Method("getOffscreenPageLimit.()I", this, null);
			}
			[Register("setOffscreenPageLimit", "(I)V", "")]
			set
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(value);
				ViewPager2._members.InstanceMethods.InvokeAbstractVoidMethod("setOffscreenPageLimit.(I)V", this, ptr);
			}
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x06000035 RID: 53 RVA: 0x000025E3 File Offset: 0x000007E3
		// (set) Token: 0x06000036 RID: 54 RVA: 0x000025FC File Offset: 0x000007FC
		public unsafe int Orientation
		{
			[Register("getOrientation", "()I", "")]
			get
			{
				return ViewPager2._members.InstanceMethods.InvokeAbstractInt32Method("getOrientation.()I", this, null);
			}
			[Register("setOrientation", "(I)V", "")]
			set
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(value);
				ViewPager2._members.InstanceMethods.InvokeAbstractVoidMethod("setOrientation.(I)V", this, ptr);
			}
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x06000037 RID: 55 RVA: 0x00002637 File Offset: 0x00000837
		public int ScrollState
		{
			[Register("getScrollState", "()I", "")]
			get
			{
				return ViewPager2._members.InstanceMethods.InvokeAbstractInt32Method("getScrollState.()I", this, null);
			}
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x06000038 RID: 56 RVA: 0x00002650 File Offset: 0x00000850
		// (set) Token: 0x06000039 RID: 57 RVA: 0x0000266C File Offset: 0x0000086C
		public unsafe bool UserInputEnabled
		{
			[Register("isUserInputEnabled", "()Z", "")]
			get
			{
				return ViewPager2._members.InstanceMethods.InvokeAbstractBooleanMethod("isUserInputEnabled.()Z", this, null);
			}
			[Register("setUserInputEnabled", "(Z)V", "")]
			set
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(value);
				ViewPager2._members.InstanceMethods.InvokeAbstractVoidMethod("setUserInputEnabled.(Z)V", this, ptr);
			}
		}

		// Token: 0x0600003A RID: 58 RVA: 0x000026A8 File Offset: 0x000008A8
		[Register("addItemDecoration", "(Landroidx/recyclerview/widget/RecyclerView$ItemDecoration;)V", "")]
		public unsafe void AddItemDecoration(RecyclerView.ItemDecoration decor)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((decor == null) ? IntPtr.Zero : decor.Handle);
				ViewPager2._members.InstanceMethods.InvokeAbstractVoidMethod("addItemDecoration.(Landroidx/recyclerview/widget/RecyclerView$ItemDecoration;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(decor);
			}
		}

		// Token: 0x0600003B RID: 59 RVA: 0x0000270C File Offset: 0x0000090C
		[Register("addItemDecoration", "(Landroidx/recyclerview/widget/RecyclerView$ItemDecoration;I)V", "")]
		public unsafe void AddItemDecoration(RecyclerView.ItemDecoration decor, int index)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((decor == null) ? IntPtr.Zero : decor.Handle);
				ptr[1] = new JniArgumentValue(index);
				ViewPager2._members.InstanceMethods.InvokeAbstractVoidMethod("addItemDecoration.(Landroidx/recyclerview/widget/RecyclerView$ItemDecoration;I)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(decor);
			}
		}

		// Token: 0x0600003C RID: 60 RVA: 0x00002784 File Offset: 0x00000984
		[Register("beginFakeDrag", "()Z", "")]
		public bool BeginFakeDrag()
		{
			return ViewPager2._members.InstanceMethods.InvokeAbstractBooleanMethod("beginFakeDrag.()Z", this, null);
		}

		// Token: 0x0600003D RID: 61 RVA: 0x000027A0 File Offset: 0x000009A0
		[Register("dispatchRestoreInstanceState", "(Landroid/util/SparseArray;)V", "")]
		protected unsafe override void DispatchRestoreInstanceState(SparseArray container)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((container == null) ? IntPtr.Zero : container.Handle);
				ViewPager2._members.InstanceMethods.InvokeAbstractVoidMethod("dispatchRestoreInstanceState.(Landroid/util/SparseArray;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(container);
			}
		}

		// Token: 0x0600003E RID: 62 RVA: 0x00002804 File Offset: 0x00000A04
		[Register("endFakeDrag", "()Z", "")]
		public bool EndFakeDrag()
		{
			return ViewPager2._members.InstanceMethods.InvokeAbstractBooleanMethod("endFakeDrag.()Z", this, null);
		}

		// Token: 0x0600003F RID: 63 RVA: 0x00002820 File Offset: 0x00000A20
		[Register("fakeDragBy", "(F)Z", "")]
		public unsafe bool FakeDragBy(float offsetPxFloat)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(offsetPxFloat);
			return ViewPager2._members.InstanceMethods.InvokeAbstractBooleanMethod("fakeDragBy.(F)Z", this, ptr);
		}

		// Token: 0x06000040 RID: 64 RVA: 0x0000285C File Offset: 0x00000A5C
		[Register("getItemDecorationAt", "(I)Landroidx/recyclerview/widget/RecyclerView$ItemDecoration;", "")]
		public unsafe RecyclerView.ItemDecoration GetItemDecorationAt(int index)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(index);
			return Java.Lang.Object.GetObject<RecyclerView.ItemDecoration>(ViewPager2._members.InstanceMethods.InvokeAbstractObjectMethod("getItemDecorationAt.(I)Landroidx/recyclerview/widget/RecyclerView$ItemDecoration;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06000041 RID: 65 RVA: 0x000028A5 File Offset: 0x00000AA5
		[Register("invalidateItemDecorations", "()V", "")]
		public void InvalidateItemDecorations()
		{
			ViewPager2._members.InstanceMethods.InvokeAbstractVoidMethod("invalidateItemDecorations.()V", this, null);
		}

		// Token: 0x06000042 RID: 66 RVA: 0x000028C0 File Offset: 0x00000AC0
		[Register("onLayout", "(ZIIII)V", "")]
		protected unsafe override void OnLayout(bool changed, int l, int t, int r, int b)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(changed);
			ptr[1] = new JniArgumentValue(l);
			ptr[2] = new JniArgumentValue(t);
			ptr[3] = new JniArgumentValue(r);
			ptr[4] = new JniArgumentValue(b);
			ViewPager2._members.InstanceMethods.InvokeAbstractVoidMethod("onLayout.(ZIIII)V", this, ptr);
		}

		// Token: 0x06000043 RID: 67 RVA: 0x00002954 File Offset: 0x00000B54
		[Register("registerOnPageChangeCallback", "(Landroidx/viewpager2/widget/ViewPager2$OnPageChangeCallback;)V", "")]
		public unsafe void RegisterOnPageChangeCallback(ViewPager2.OnPageChangeCallback callback)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((callback == null) ? IntPtr.Zero : callback.Handle);
				ViewPager2._members.InstanceMethods.InvokeAbstractVoidMethod("registerOnPageChangeCallback.(Landroidx/viewpager2/widget/ViewPager2$OnPageChangeCallback;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(callback);
			}
		}

		// Token: 0x06000044 RID: 68 RVA: 0x000029B8 File Offset: 0x00000BB8
		[Register("removeItemDecoration", "(Landroidx/recyclerview/widget/RecyclerView$ItemDecoration;)V", "")]
		public unsafe void RemoveItemDecoration(RecyclerView.ItemDecoration decor)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((decor == null) ? IntPtr.Zero : decor.Handle);
				ViewPager2._members.InstanceMethods.InvokeAbstractVoidMethod("removeItemDecoration.(Landroidx/recyclerview/widget/RecyclerView$ItemDecoration;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(decor);
			}
		}

		// Token: 0x06000045 RID: 69 RVA: 0x00002A1C File Offset: 0x00000C1C
		[Register("removeItemDecorationAt", "(I)V", "")]
		public unsafe void RemoveItemDecorationAt(int index)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(index);
			ViewPager2._members.InstanceMethods.InvokeAbstractVoidMethod("removeItemDecorationAt.(I)V", this, ptr);
		}

		// Token: 0x06000046 RID: 70 RVA: 0x00002A57 File Offset: 0x00000C57
		[Register("requestTransform", "()V", "")]
		public void RequestTransform()
		{
			ViewPager2._members.InstanceMethods.InvokeAbstractVoidMethod("requestTransform.()V", this, null);
		}

		// Token: 0x06000047 RID: 71 RVA: 0x00002A70 File Offset: 0x00000C70
		[Register("setCurrentItem", "(IZ)V", "")]
		public unsafe void SetCurrentItem(int item, bool smoothScroll)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(item);
			ptr[1] = new JniArgumentValue(smoothScroll);
			ViewPager2._members.InstanceMethods.InvokeAbstractVoidMethod("setCurrentItem.(IZ)V", this, ptr);
		}

		// Token: 0x06000048 RID: 72 RVA: 0x00002AC0 File Offset: 0x00000CC0
		[Register("setPageTransformer", "(Landroidx/viewpager2/widget/ViewPager2$PageTransformer;)V", "")]
		public unsafe void SetPageTransformer(ViewPager2.IPageTransformer transformer)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((transformer == null) ? IntPtr.Zero : ((Java.Lang.Object)transformer).Handle);
				ViewPager2._members.InstanceMethods.InvokeAbstractVoidMethod("setPageTransformer.(Landroidx/viewpager2/widget/ViewPager2$PageTransformer;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(transformer);
			}
		}

		// Token: 0x06000049 RID: 73 RVA: 0x00002B28 File Offset: 0x00000D28
		[Register("unregisterOnPageChangeCallback", "(Landroidx/viewpager2/widget/ViewPager2$OnPageChangeCallback;)V", "")]
		public unsafe void UnregisterOnPageChangeCallback(ViewPager2.OnPageChangeCallback callback)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((callback == null) ? IntPtr.Zero : callback.Handle);
				ViewPager2._members.InstanceMethods.InvokeAbstractVoidMethod("unregisterOnPageChangeCallback.(Landroidx/viewpager2/widget/ViewPager2$OnPageChangeCallback;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(callback);
			}
		}

		// Token: 0x04000003 RID: 3
		private static readonly JniPeerMembers _members = new XAPeerMembers("androidx/viewpager2/widget/ViewPager2", typeof(ViewPager2));

		// Token: 0x0200000E RID: 14
		[Register("androidx/viewpager2/widget/ViewPager2$OnPageChangeCallback", DoNotGenerateAcw = true)]
		public abstract class OnPageChangeCallback : Java.Lang.Object
		{
			// Token: 0x1700000D RID: 13
			// (get) Token: 0x0600004B RID: 75 RVA: 0x00002BA8 File Offset: 0x00000DA8
			internal static IntPtr class_ref
			{
				get
				{
					return ViewPager2.OnPageChangeCallback._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x1700000E RID: 14
			// (get) Token: 0x0600004C RID: 76 RVA: 0x00002BCC File Offset: 0x00000DCC
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return ViewPager2.OnPageChangeCallback._members;
				}
			}

			// Token: 0x1700000F RID: 15
			// (get) Token: 0x0600004D RID: 77 RVA: 0x00002BD4 File Offset: 0x00000DD4
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return ViewPager2.OnPageChangeCallback._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x17000010 RID: 16
			// (get) Token: 0x0600004E RID: 78 RVA: 0x00002BF8 File Offset: 0x00000DF8
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return ViewPager2.OnPageChangeCallback._members.ManagedPeerType;
				}
			}

			// Token: 0x0600004F RID: 79 RVA: 0x00002C04 File Offset: 0x00000E04
			protected OnPageChangeCallback(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
			{
			}

			// Token: 0x06000050 RID: 80 RVA: 0x00002C10 File Offset: 0x00000E10
			[Register(".ctor", "()V", "")]
			public OnPageChangeCallback() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (base.Handle != IntPtr.Zero)
				{
					return;
				}
				base.SetHandle(ViewPager2.OnPageChangeCallback._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
				ViewPager2.OnPageChangeCallback._members.InstanceMethods.FinishCreateInstance("()V", this, null);
			}

			// Token: 0x06000051 RID: 81 RVA: 0x00002C7E File Offset: 0x00000E7E
			private static Delegate GetOnPageScrollStateChanged_IHandler()
			{
				if (ViewPager2.OnPageChangeCallback.cb_onPageScrollStateChanged_I == null)
				{
					ViewPager2.OnPageChangeCallback.cb_onPageScrollStateChanged_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_V(ViewPager2.OnPageChangeCallback.n_OnPageScrollStateChanged_I));
				}
				return ViewPager2.OnPageChangeCallback.cb_onPageScrollStateChanged_I;
			}

			// Token: 0x06000052 RID: 82 RVA: 0x00002CA2 File Offset: 0x00000EA2
			private static void n_OnPageScrollStateChanged_I(IntPtr jnienv, IntPtr native__this, int state)
			{
				Java.Lang.Object.GetObject<ViewPager2.OnPageChangeCallback>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).OnPageScrollStateChanged(state);
			}

			// Token: 0x06000053 RID: 83 RVA: 0x00002CB4 File Offset: 0x00000EB4
			[Register("onPageScrollStateChanged", "(I)V", "GetOnPageScrollStateChanged_IHandler")]
			public unsafe virtual void OnPageScrollStateChanged(int state)
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(state);
				ViewPager2.OnPageChangeCallback._members.InstanceMethods.InvokeVirtualVoidMethod("onPageScrollStateChanged.(I)V", this, ptr);
			}

			// Token: 0x06000054 RID: 84 RVA: 0x00002CEF File Offset: 0x00000EEF
			private static Delegate GetOnPageScrolled_IFIHandler()
			{
				if (ViewPager2.OnPageChangeCallback.cb_onPageScrolled_IFI == null)
				{
					ViewPager2.OnPageChangeCallback.cb_onPageScrolled_IFI = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPIFI_V(ViewPager2.OnPageChangeCallback.n_OnPageScrolled_IFI));
				}
				return ViewPager2.OnPageChangeCallback.cb_onPageScrolled_IFI;
			}

			// Token: 0x06000055 RID: 85 RVA: 0x00002D13 File Offset: 0x00000F13
			private static void n_OnPageScrolled_IFI(IntPtr jnienv, IntPtr native__this, int position, float positionOffset, int positionOffsetPixels)
			{
				Java.Lang.Object.GetObject<ViewPager2.OnPageChangeCallback>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).OnPageScrolled(position, positionOffset, positionOffsetPixels);
			}

			// Token: 0x06000056 RID: 86 RVA: 0x00002D28 File Offset: 0x00000F28
			[Register("onPageScrolled", "(IFI)V", "GetOnPageScrolled_IFIHandler")]
			public unsafe virtual void OnPageScrolled(int position, float positionOffset, int positionOffsetPixels)
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(position);
				ptr[1] = new JniArgumentValue(positionOffset);
				ptr[2] = new JniArgumentValue(positionOffsetPixels);
				ViewPager2.OnPageChangeCallback._members.InstanceMethods.InvokeVirtualVoidMethod("onPageScrolled.(IFI)V", this, ptr);
			}

			// Token: 0x06000057 RID: 87 RVA: 0x00002D8C File Offset: 0x00000F8C
			private static Delegate GetOnPageSelected_IHandler()
			{
				if (ViewPager2.OnPageChangeCallback.cb_onPageSelected_I == null)
				{
					ViewPager2.OnPageChangeCallback.cb_onPageSelected_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_V(ViewPager2.OnPageChangeCallback.n_OnPageSelected_I));
				}
				return ViewPager2.OnPageChangeCallback.cb_onPageSelected_I;
			}

			// Token: 0x06000058 RID: 88 RVA: 0x00002DB0 File Offset: 0x00000FB0
			private static void n_OnPageSelected_I(IntPtr jnienv, IntPtr native__this, int position)
			{
				Java.Lang.Object.GetObject<ViewPager2.OnPageChangeCallback>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).OnPageSelected(position);
			}

			// Token: 0x06000059 RID: 89 RVA: 0x00002DC0 File Offset: 0x00000FC0
			[Register("onPageSelected", "(I)V", "GetOnPageSelected_IHandler")]
			public unsafe virtual void OnPageSelected(int position)
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(position);
				ViewPager2.OnPageChangeCallback._members.InstanceMethods.InvokeVirtualVoidMethod("onPageSelected.(I)V", this, ptr);
			}

			// Token: 0x04000004 RID: 4
			private static readonly JniPeerMembers _members = new XAPeerMembers("androidx/viewpager2/widget/ViewPager2$OnPageChangeCallback", typeof(ViewPager2.OnPageChangeCallback));

			// Token: 0x04000005 RID: 5
			private static Delegate cb_onPageScrollStateChanged_I;

			// Token: 0x04000006 RID: 6
			private static Delegate cb_onPageScrolled_IFI;

			// Token: 0x04000007 RID: 7
			private static Delegate cb_onPageSelected_I;
		}

		// Token: 0x0200000F RID: 15
		[Register("androidx/viewpager2/widget/ViewPager2$OnPageChangeCallback", DoNotGenerateAcw = true)]
		internal class OnPageChangeCallbackInvoker : ViewPager2.OnPageChangeCallback
		{
			// Token: 0x0600005B RID: 91 RVA: 0x00002E16 File Offset: 0x00001016
			public OnPageChangeCallbackInvoker(IntPtr handle, JniHandleOwnership transfer) : base(handle, transfer)
			{
			}

			// Token: 0x17000011 RID: 17
			// (get) Token: 0x0600005C RID: 92 RVA: 0x00002E20 File Offset: 0x00001020
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return ViewPager2.OnPageChangeCallbackInvoker._members;
				}
			}

			// Token: 0x17000012 RID: 18
			// (get) Token: 0x0600005D RID: 93 RVA: 0x00002E27 File Offset: 0x00001027
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return ViewPager2.OnPageChangeCallbackInvoker._members.ManagedPeerType;
				}
			}

			// Token: 0x04000008 RID: 8
			private static readonly JniPeerMembers _members = new XAPeerMembers("androidx/viewpager2/widget/ViewPager2$OnPageChangeCallback", typeof(ViewPager2.OnPageChangeCallbackInvoker));
		}

		// Token: 0x02000010 RID: 16
		[Register("androidx/viewpager2/widget/ViewPager2$PageTransformer", "", "AndroidX.ViewPager2.Widget.ViewPager2/IPageTransformerInvoker")]
		public interface IPageTransformer : IJavaObject, IDisposable, IJavaPeerable
		{
			// Token: 0x0600005F RID: 95
			[Register("transformPage", "(Landroid/view/View;F)V", "GetTransformPage_Landroid_view_View_FHandler:AndroidX.ViewPager2.Widget.ViewPager2/IPageTransformerInvoker, Xamarin.AndroidX.ViewPager2")]
			void TransformPage(View p0, float p1);
		}

		// Token: 0x02000011 RID: 17
		[Register("androidx/viewpager2/widget/ViewPager2$PageTransformer", DoNotGenerateAcw = true)]
		internal class IPageTransformerInvoker : Java.Lang.Object, ViewPager2.IPageTransformer, IJavaObject, IDisposable, IJavaPeerable
		{
			// Token: 0x17000013 RID: 19
			// (get) Token: 0x06000060 RID: 96 RVA: 0x00002E50 File Offset: 0x00001050
			private static IntPtr java_class_ref
			{
				get
				{
					return ViewPager2.IPageTransformerInvoker._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x17000014 RID: 20
			// (get) Token: 0x06000061 RID: 97 RVA: 0x00002E74 File Offset: 0x00001074
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return ViewPager2.IPageTransformerInvoker._members;
				}
			}

			// Token: 0x17000015 RID: 21
			// (get) Token: 0x06000062 RID: 98 RVA: 0x00002E7B File Offset: 0x0000107B
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return this.class_ref;
				}
			}

			// Token: 0x17000016 RID: 22
			// (get) Token: 0x06000063 RID: 99 RVA: 0x00002E83 File Offset: 0x00001083
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return ViewPager2.IPageTransformerInvoker._members.ManagedPeerType;
				}
			}

			// Token: 0x06000064 RID: 100 RVA: 0x00002E8F File Offset: 0x0000108F
			public static ViewPager2.IPageTransformer GetObject(IntPtr handle, JniHandleOwnership transfer)
			{
				return Java.Lang.Object.GetObject<ViewPager2.IPageTransformer>(handle, transfer);
			}

			// Token: 0x06000065 RID: 101 RVA: 0x00002E98 File Offset: 0x00001098
			private static IntPtr Validate(IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf(handle, ViewPager2.IPageTransformerInvoker.java_class_ref))
				{
					throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'androidx.viewpager2.widget.ViewPager2.PageTransformer'.");
				}
				return handle;
			}

			// Token: 0x06000066 RID: 102 RVA: 0x00002EC3 File Offset: 0x000010C3
			protected override void Dispose(bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
				{
					JNIEnv.DeleteGlobalRef(this.class_ref);
				}
				this.class_ref = IntPtr.Zero;
				base.Dispose(disposing);
			}

			// Token: 0x06000067 RID: 103 RVA: 0x00002EF4 File Offset: 0x000010F4
			public IPageTransformerInvoker(IntPtr handle, JniHandleOwnership transfer) : base(ViewPager2.IPageTransformerInvoker.Validate(handle), transfer)
			{
				IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
				this.class_ref = JNIEnv.NewGlobalRef(objectClass);
				JNIEnv.DeleteLocalRef(objectClass);
			}

			// Token: 0x06000068 RID: 104 RVA: 0x00002F2C File Offset: 0x0000112C
			private static Delegate GetTransformPage_Landroid_view_View_FHandler()
			{
				if (ViewPager2.IPageTransformerInvoker.cb_transformPage_Landroid_view_View_F == null)
				{
					ViewPager2.IPageTransformerInvoker.cb_transformPage_Landroid_view_View_F = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLF_V(ViewPager2.IPageTransformerInvoker.n_TransformPage_Landroid_view_View_F));
				}
				return ViewPager2.IPageTransformerInvoker.cb_transformPage_Landroid_view_View_F;
			}

			// Token: 0x06000069 RID: 105 RVA: 0x00002F50 File Offset: 0x00001150
			private static void n_TransformPage_Landroid_view_View_F(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, float p1)
			{
				ViewPager2.IPageTransformer @object = Java.Lang.Object.GetObject<ViewPager2.IPageTransformer>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				View object2 = Java.Lang.Object.GetObject<View>(native_p0, JniHandleOwnership.DoNotTransfer);
				@object.TransformPage(object2, p1);
			}

			// Token: 0x0600006A RID: 106 RVA: 0x00002F74 File Offset: 0x00001174
			public unsafe void TransformPage(View p0, float p1)
			{
				if (this.id_transformPage_Landroid_view_View_F == IntPtr.Zero)
				{
					this.id_transformPage_Landroid_view_View_F = JNIEnv.GetMethodID(this.class_ref, "transformPage", "(Landroid/view/View;F)V");
				}
				JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JValue))];
				*ptr = new JValue((p0 == null) ? IntPtr.Zero : p0.Handle);
				ptr[1] = new JValue(p1);
				JNIEnv.CallVoidMethod(base.Handle, this.id_transformPage_Landroid_view_View_F, ptr);
			}

			// Token: 0x04000009 RID: 9
			private static readonly JniPeerMembers _members = new XAPeerMembers("androidx/viewpager2/widget/ViewPager2$PageTransformer", typeof(ViewPager2.IPageTransformerInvoker));

			// Token: 0x0400000A RID: 10
			private IntPtr class_ref;

			// Token: 0x0400000B RID: 11
			private static Delegate cb_transformPage_Landroid_view_View_F;

			// Token: 0x0400000C RID: 12
			private IntPtr id_transformPage_Landroid_view_View_F;
		}
	}
}
