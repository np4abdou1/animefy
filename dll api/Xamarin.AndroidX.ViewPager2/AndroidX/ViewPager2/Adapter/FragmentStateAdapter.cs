using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.OS;
using Android.Runtime;
using Android.Views;
using AndroidX.Fragment.App;
using AndroidX.Lifecycle;
using AndroidX.RecyclerView.Widget;
using Java.Interop;
using Java.Lang;

namespace AndroidX.ViewPager2.Adapter
{
	// Token: 0x02000012 RID: 18
	[Register("androidx/viewpager2/adapter/FragmentStateAdapter", DoNotGenerateAcw = true)]
	public abstract class FragmentStateAdapter : RecyclerView.Adapter, IStatefulAdapter, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000017 RID: 23
		// (get) Token: 0x0600006C RID: 108 RVA: 0x00003018 File Offset: 0x00001218
		internal static IntPtr class_ref
		{
			get
			{
				return FragmentStateAdapter._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x0600006D RID: 109 RVA: 0x0000303C File Offset: 0x0000123C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return FragmentStateAdapter._members;
			}
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x0600006E RID: 110 RVA: 0x00003044 File Offset: 0x00001244
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return FragmentStateAdapter._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x0600006F RID: 111 RVA: 0x00003068 File Offset: 0x00001268
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return FragmentStateAdapter._members.ManagedPeerType;
			}
		}

		// Token: 0x06000070 RID: 112 RVA: 0x00003074 File Offset: 0x00001274
		protected FragmentStateAdapter(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000071 RID: 113 RVA: 0x00003080 File Offset: 0x00001280
		[Register(".ctor", "(Landroidx/fragment/app/Fragment;)V", "")]
		public unsafe FragmentStateAdapter(Fragment fragment) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((fragment == null) ? IntPtr.Zero : fragment.Handle);
				base.SetHandle(FragmentStateAdapter._members.InstanceMethods.StartCreateInstance("(Landroidx/fragment/app/Fragment;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				FragmentStateAdapter._members.InstanceMethods.FinishCreateInstance("(Landroidx/fragment/app/Fragment;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(fragment);
			}
		}

		// Token: 0x06000072 RID: 114 RVA: 0x00003130 File Offset: 0x00001330
		[Register(".ctor", "(Landroidx/fragment/app/FragmentActivity;)V", "")]
		public unsafe FragmentStateAdapter(FragmentActivity fragmentActivity) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((fragmentActivity == null) ? IntPtr.Zero : fragmentActivity.Handle);
				base.SetHandle(FragmentStateAdapter._members.InstanceMethods.StartCreateInstance("(Landroidx/fragment/app/FragmentActivity;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				FragmentStateAdapter._members.InstanceMethods.FinishCreateInstance("(Landroidx/fragment/app/FragmentActivity;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(fragmentActivity);
			}
		}

		// Token: 0x06000073 RID: 115 RVA: 0x000031E0 File Offset: 0x000013E0
		[Register(".ctor", "(Landroidx/fragment/app/FragmentManager;Landroidx/lifecycle/Lifecycle;)V", "")]
		public unsafe FragmentStateAdapter(FragmentManager fragmentManager, Lifecycle lifecycle) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((fragmentManager == null) ? IntPtr.Zero : fragmentManager.Handle);
				ptr[1] = new JniArgumentValue((lifecycle == null) ? IntPtr.Zero : lifecycle.Handle);
				base.SetHandle(FragmentStateAdapter._members.InstanceMethods.StartCreateInstance("(Landroidx/fragment/app/FragmentManager;Landroidx/lifecycle/Lifecycle;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				FragmentStateAdapter._members.InstanceMethods.FinishCreateInstance("(Landroidx/fragment/app/FragmentManager;Landroidx/lifecycle/Lifecycle;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(fragmentManager);
				GC.KeepAlive(lifecycle);
			}
		}

		// Token: 0x06000074 RID: 116 RVA: 0x000032B8 File Offset: 0x000014B8
		private static Delegate GetContainsItem_JHandler()
		{
			if (FragmentStateAdapter.cb_containsItem_J == null)
			{
				FragmentStateAdapter.cb_containsItem_J = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPJ_Z(FragmentStateAdapter.n_ContainsItem_J));
			}
			return FragmentStateAdapter.cb_containsItem_J;
		}

		// Token: 0x06000075 RID: 117 RVA: 0x000032DC File Offset: 0x000014DC
		private static bool n_ContainsItem_J(IntPtr jnienv, IntPtr native__this, long itemId)
		{
			return Java.Lang.Object.GetObject<FragmentStateAdapter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ContainsItem(itemId);
		}

		// Token: 0x06000076 RID: 118 RVA: 0x000032EC File Offset: 0x000014EC
		[Register("containsItem", "(J)Z", "GetContainsItem_JHandler")]
		public unsafe virtual bool ContainsItem(long itemId)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(itemId);
			return FragmentStateAdapter._members.InstanceMethods.InvokeVirtualBooleanMethod("containsItem.(J)Z", this, ptr);
		}

		// Token: 0x06000077 RID: 119 RVA: 0x00003327 File Offset: 0x00001527
		private static Delegate GetCreateFragment_IHandler()
		{
			if (FragmentStateAdapter.cb_createFragment_I == null)
			{
				FragmentStateAdapter.cb_createFragment_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_L(FragmentStateAdapter.n_CreateFragment_I));
			}
			return FragmentStateAdapter.cb_createFragment_I;
		}

		// Token: 0x06000078 RID: 120 RVA: 0x0000334B File Offset: 0x0000154B
		private static IntPtr n_CreateFragment_I(IntPtr jnienv, IntPtr native__this, int p0)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<FragmentStateAdapter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).CreateFragment(p0));
		}

		// Token: 0x06000079 RID: 121
		[Register("createFragment", "(I)Landroidx/fragment/app/Fragment;", "GetCreateFragment_IHandler")]
		public abstract Fragment CreateFragment(int p0);

		// Token: 0x0600007A RID: 122 RVA: 0x00003360 File Offset: 0x00001560
		[Register("onBindViewHolder", "(Landroidx/viewpager2/adapter/FragmentViewHolder;I)V", "")]
		public unsafe void OnBindViewHolder(FragmentViewHolder holder, int position)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((holder == null) ? IntPtr.Zero : holder.Handle);
				ptr[1] = new JniArgumentValue(position);
				FragmentStateAdapter._members.InstanceMethods.InvokeNonvirtualVoidMethod("onBindViewHolder.(Landroidx/viewpager2/adapter/FragmentViewHolder;I)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(holder);
			}
		}

		// Token: 0x0600007B RID: 123 RVA: 0x000033D8 File Offset: 0x000015D8
		private static Delegate GetOnCreateViewHolder_Landroid_view_ViewGroup_IHandler()
		{
			if (FragmentStateAdapter.cb_onCreateViewHolder_Landroid_view_ViewGroup_I == null)
			{
				FragmentStateAdapter.cb_onCreateViewHolder_Landroid_view_ViewGroup_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLI_L(FragmentStateAdapter.n_OnCreateViewHolder_Landroid_view_ViewGroup_I));
			}
			return FragmentStateAdapter.cb_onCreateViewHolder_Landroid_view_ViewGroup_I;
		}

		// Token: 0x0600007C RID: 124 RVA: 0x000033FC File Offset: 0x000015FC
		private static IntPtr n_OnCreateViewHolder_Landroid_view_ViewGroup_I(IntPtr jnienv, IntPtr native__this, IntPtr native_parent, int viewType)
		{
			RecyclerView.Adapter @object = Java.Lang.Object.GetObject<FragmentStateAdapter>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ViewGroup object2 = Java.Lang.Object.GetObject<ViewGroup>(native_parent, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.OnCreateViewHolder(object2, viewType));
		}

		// Token: 0x0600007D RID: 125 RVA: 0x00003428 File Offset: 0x00001628
		[Register("onCreateViewHolder", "(Landroid/view/ViewGroup;I)Landroidx/viewpager2/adapter/FragmentViewHolder;", "GetOnCreateViewHolder_Landroid_view_ViewGroup_IHandler")]
		public unsafe override RecyclerView.ViewHolder OnCreateViewHolder(ViewGroup parent, int viewType)
		{
			RecyclerView.ViewHolder @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((parent == null) ? IntPtr.Zero : parent.Handle);
				ptr[1] = new JniArgumentValue(viewType);
				@object = Java.Lang.Object.GetObject<RecyclerView.ViewHolder>(FragmentStateAdapter._members.InstanceMethods.InvokeVirtualObjectMethod("onCreateViewHolder.(Landroid/view/ViewGroup;I)Landroidx/viewpager2/adapter/FragmentViewHolder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(parent);
			}
			return @object;
		}

		// Token: 0x0600007E RID: 126 RVA: 0x000034B0 File Offset: 0x000016B0
		[Register("onFailedToRecycleView", "(Landroidx/viewpager2/adapter/FragmentViewHolder;)Z", "")]
		public unsafe bool OnFailedToRecycleView(FragmentViewHolder holder)
		{
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((holder == null) ? IntPtr.Zero : holder.Handle);
				result = FragmentStateAdapter._members.InstanceMethods.InvokeNonvirtualBooleanMethod("onFailedToRecycleView.(Landroidx/viewpager2/adapter/FragmentViewHolder;)Z", this, ptr);
			}
			finally
			{
				GC.KeepAlive(holder);
			}
			return result;
		}

		// Token: 0x0600007F RID: 127 RVA: 0x00003518 File Offset: 0x00001718
		[Register("onViewAttachedToWindow", "(Landroidx/viewpager2/adapter/FragmentViewHolder;)V", "")]
		public unsafe void OnViewAttachedToWindow(FragmentViewHolder holder)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((holder == null) ? IntPtr.Zero : holder.Handle);
				FragmentStateAdapter._members.InstanceMethods.InvokeNonvirtualVoidMethod("onViewAttachedToWindow.(Landroidx/viewpager2/adapter/FragmentViewHolder;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(holder);
			}
		}

		// Token: 0x06000080 RID: 128 RVA: 0x0000357C File Offset: 0x0000177C
		[Register("onViewRecycled", "(Landroidx/viewpager2/adapter/FragmentViewHolder;)V", "")]
		public unsafe void OnViewRecycled(FragmentViewHolder holder)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((holder == null) ? IntPtr.Zero : holder.Handle);
				FragmentStateAdapter._members.InstanceMethods.InvokeNonvirtualVoidMethod("onViewRecycled.(Landroidx/viewpager2/adapter/FragmentViewHolder;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(holder);
			}
		}

		// Token: 0x06000081 RID: 129 RVA: 0x000035E0 File Offset: 0x000017E0
		[Register("restoreState", "(Landroid/os/Parcelable;)V", "")]
		public unsafe void RestoreState(IParcelable savedState)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((savedState == null) ? IntPtr.Zero : ((Java.Lang.Object)savedState).Handle);
				FragmentStateAdapter._members.InstanceMethods.InvokeNonvirtualVoidMethod("restoreState.(Landroid/os/Parcelable;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(savedState);
			}
		}

		// Token: 0x06000082 RID: 130 RVA: 0x00003648 File Offset: 0x00001848
		[Register("saveState", "()Landroid/os/Parcelable;", "")]
		public IParcelable SaveState()
		{
			return Java.Lang.Object.GetObject<IParcelable>(FragmentStateAdapter._members.InstanceMethods.InvokeNonvirtualObjectMethod("saveState.()Landroid/os/Parcelable;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06000083 RID: 131 RVA: 0x0000367C File Offset: 0x0000187C
		[Register("onBindViewHolder", "(Landroidx/recyclerview/widget/RecyclerView$ViewHolder;I)V", "")]
		public unsafe sealed override void OnBindViewHolder(RecyclerView.ViewHolder holder, int position)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((holder == null) ? IntPtr.Zero : holder.Handle);
				ptr[1] = new JniArgumentValue(position);
				FragmentStateAdapter._members.InstanceMethods.InvokeNonvirtualVoidMethod("onBindViewHolder.(Landroidx/recyclerview/widget/RecyclerView$ViewHolder;I)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(holder);
			}
		}

		// Token: 0x0400000D RID: 13
		private static readonly JniPeerMembers _members = new XAPeerMembers("androidx/viewpager2/adapter/FragmentStateAdapter", typeof(FragmentStateAdapter));

		// Token: 0x0400000E RID: 14
		private static Delegate cb_containsItem_J;

		// Token: 0x0400000F RID: 15
		private static Delegate cb_createFragment_I;

		// Token: 0x04000010 RID: 16
		private static Delegate cb_onCreateViewHolder_Landroid_view_ViewGroup_I;
	}
}
