using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace AndroidX.Fragment.App
{
	// Token: 0x02000045 RID: 69
	[Register("androidx/fragment/app/FragmentStatePagerAdapter", DoNotGenerateAcw = true)]
	internal class FragmentStatePagerAdapterInvoker : FragmentStatePagerAdapter
	{
		// Token: 0x060003A2 RID: 930 RVA: 0x0000BCCB File Offset: 0x00009ECB
		public FragmentStatePagerAdapterInvoker(IntPtr handle, JniHandleOwnership transfer) : base(handle, transfer)
		{
		}

		// Token: 0x17000082 RID: 130
		// (get) Token: 0x060003A3 RID: 931 RVA: 0x0000BCD5 File Offset: 0x00009ED5
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return FragmentStatePagerAdapterInvoker._members;
			}
		}

		// Token: 0x17000083 RID: 131
		// (get) Token: 0x060003A4 RID: 932 RVA: 0x0000BCDC File Offset: 0x00009EDC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return FragmentStatePagerAdapterInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x060003A5 RID: 933 RVA: 0x0000BCE8 File Offset: 0x00009EE8
		[Register("getItem", "(I)Landroidx/fragment/app/Fragment;", "GetGetItem_IHandler")]
		public unsafe override Fragment GetItem(int position)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(position);
			return Java.Lang.Object.GetObject<Fragment>(FragmentStatePagerAdapterInvoker._members.InstanceMethods.InvokeAbstractObjectMethod("getItem.(I)Landroidx/fragment/app/Fragment;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x17000084 RID: 132
		// (get) Token: 0x060003A6 RID: 934 RVA: 0x0000BD31 File Offset: 0x00009F31
		public override int Count
		{
			[Register("getCount", "()I", "GetGetCountHandler")]
			get
			{
				return FragmentStatePagerAdapterInvoker._members.InstanceMethods.InvokeAbstractInt32Method("getCount.()I", this, null);
			}
		}

		// Token: 0x040000F4 RID: 244
		private static readonly JniPeerMembers _members = new XAPeerMembers("androidx/fragment/app/FragmentStatePagerAdapter", typeof(FragmentStatePagerAdapterInvoker));
	}
}
