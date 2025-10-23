using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using AndroidX.RecyclerView.Widget;
using Java.Interop;

namespace AndroidX.ViewPager2.Adapter
{
	// Token: 0x02000014 RID: 20
	[Register("androidx/viewpager2/adapter/FragmentViewHolder", DoNotGenerateAcw = true)]
	public sealed class FragmentViewHolder : RecyclerView.ViewHolder
	{
		// Token: 0x1700001E RID: 30
		// (get) Token: 0x0600008C RID: 140 RVA: 0x00003834 File Offset: 0x00001A34
		internal static IntPtr class_ref
		{
			get
			{
				return FragmentViewHolder._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x0600008D RID: 141 RVA: 0x00003858 File Offset: 0x00001A58
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return FragmentViewHolder._members;
			}
		}

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x0600008E RID: 142 RVA: 0x00003860 File Offset: 0x00001A60
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return FragmentViewHolder._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x0600008F RID: 143 RVA: 0x00003884 File Offset: 0x00001A84
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return FragmentViewHolder._members.ManagedPeerType;
			}
		}

		// Token: 0x06000090 RID: 144 RVA: 0x00003890 File Offset: 0x00001A90
		internal FragmentViewHolder(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x04000012 RID: 18
		private static readonly JniPeerMembers _members = new XAPeerMembers("androidx/viewpager2/adapter/FragmentViewHolder", typeof(FragmentViewHolder));
	}
}
