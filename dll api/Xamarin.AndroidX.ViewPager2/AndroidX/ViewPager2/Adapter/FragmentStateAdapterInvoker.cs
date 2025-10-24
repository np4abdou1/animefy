using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Android.Views;
using AndroidX.Fragment.App;
using AndroidX.RecyclerView.Widget;
using Java.Interop;
using Java.Lang;

namespace AndroidX.ViewPager2.Adapter
{
	// Token: 0x02000013 RID: 19
	[Register("androidx/viewpager2/adapter/FragmentStateAdapter", DoNotGenerateAcw = true)]
	internal class FragmentStateAdapterInvoker : FragmentStateAdapter
	{
		// Token: 0x06000085 RID: 133 RVA: 0x0000370F File Offset: 0x0000190F
		public FragmentStateAdapterInvoker(IntPtr handle, JniHandleOwnership transfer) : base(handle, transfer)
		{
		}

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x06000086 RID: 134 RVA: 0x00003719 File Offset: 0x00001919
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return FragmentStateAdapterInvoker._members;
			}
		}

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x06000087 RID: 135 RVA: 0x00003720 File Offset: 0x00001920
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return FragmentStateAdapterInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06000088 RID: 136 RVA: 0x0000372C File Offset: 0x0000192C
		[Register("createFragment", "(I)Landroidx/fragment/app/Fragment;", "GetCreateFragment_IHandler")]
		public unsafe override Fragment CreateFragment(int p0)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(p0);
			return Java.Lang.Object.GetObject<Fragment>(FragmentStateAdapterInvoker._members.InstanceMethods.InvokeAbstractObjectMethod("createFragment.(I)Landroidx/fragment/app/Fragment;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x06000089 RID: 137 RVA: 0x00003775 File Offset: 0x00001975
		public override int ItemCount
		{
			[Register("getItemCount", "()I", "GetGetItemCountHandler")]
			get
			{
				return FragmentStateAdapterInvoker._members.InstanceMethods.InvokeAbstractInt32Method("getItemCount.()I", this, null);
			}
		}

		// Token: 0x0600008A RID: 138 RVA: 0x00003790 File Offset: 0x00001990
		[Register("onCreateViewHolder", "(Landroid/view/ViewGroup;I)Landroidx/recyclerview/widget/RecyclerView$ViewHolder;", "GetOnCreateViewHolder_Landroid_view_ViewGroup_IHandler")]
		public unsafe override RecyclerView.ViewHolder OnCreateViewHolder(ViewGroup parent, int viewType)
		{
			RecyclerView.ViewHolder @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((parent == null) ? IntPtr.Zero : parent.Handle);
				ptr[1] = new JniArgumentValue(viewType);
				@object = Java.Lang.Object.GetObject<RecyclerView.ViewHolder>(FragmentStateAdapterInvoker._members.InstanceMethods.InvokeAbstractObjectMethod("onCreateViewHolder.(Landroid/view/ViewGroup;I)Landroidx/recyclerview/widget/RecyclerView$ViewHolder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(parent);
			}
			return @object;
		}

		// Token: 0x04000011 RID: 17
		private static readonly JniPeerMembers _members = new XAPeerMembers("androidx/viewpager2/adapter/FragmentStateAdapter", typeof(FragmentStateAdapterInvoker));
	}
}
