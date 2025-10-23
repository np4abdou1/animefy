using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Android.Views;
using Java.Interop;
using Java.Lang;

namespace Android.Widget
{
	// Token: 0x020000B4 RID: 180
	[Register("android/widget/BaseAdapter", DoNotGenerateAcw = true)]
	internal class BaseAdapterInvoker : BaseAdapter
	{
		// Token: 0x0600036C RID: 876 RVA: 0x00004C7C File Offset: 0x00002E7C
		public BaseAdapterInvoker(IntPtr handle, JniHandleOwnership transfer) : base(handle, transfer)
		{
		}

		// Token: 0x17000053 RID: 83
		// (get) Token: 0x0600036D RID: 877 RVA: 0x00005851 File Offset: 0x00003A51
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return BaseAdapterInvoker._members;
			}
		}

		// Token: 0x17000054 RID: 84
		// (get) Token: 0x0600036E RID: 878 RVA: 0x00005858 File Offset: 0x00003A58
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return BaseAdapterInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x17000055 RID: 85
		// (get) Token: 0x0600036F RID: 879 RVA: 0x00005864 File Offset: 0x00003A64
		public override int Count
		{
			get
			{
				return BaseAdapterInvoker._members.InstanceMethods.InvokeAbstractInt32Method("getCount.()I", this, null);
			}
		}

		// Token: 0x06000370 RID: 880 RVA: 0x00005880 File Offset: 0x00003A80
		public unsafe override Java.Lang.Object GetItem(int position)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(position);
			return Java.Lang.Object.GetObject<Java.Lang.Object>(BaseAdapterInvoker._members.InstanceMethods.InvokeAbstractObjectMethod("getItem.(I)Ljava/lang/Object;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06000371 RID: 881 RVA: 0x000058CC File Offset: 0x00003ACC
		public unsafe override long GetItemId(int position)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(position);
			return BaseAdapterInvoker._members.InstanceMethods.InvokeAbstractInt64Method("getItemId.(I)J", this, ptr);
		}

		// Token: 0x06000372 RID: 882 RVA: 0x00005908 File Offset: 0x00003B08
		public unsafe override View GetView(int position, View convertView, ViewGroup parent)
		{
			View @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(position);
				ptr[1] = new JniArgumentValue((convertView == null) ? IntPtr.Zero : convertView.Handle);
				ptr[2] = new JniArgumentValue((parent == null) ? IntPtr.Zero : parent.Handle);
				@object = Java.Lang.Object.GetObject<View>(BaseAdapterInvoker._members.InstanceMethods.InvokeAbstractObjectMethod("getView.(ILandroid/view/View;Landroid/view/ViewGroup;)Landroid/view/View;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(convertView);
				GC.KeepAlive(parent);
			}
			return @object;
		}

		// Token: 0x04000089 RID: 137
		private static readonly JniPeerMembers _members = new XAPeerMembers("android/widget/BaseAdapter", typeof(BaseAdapterInvoker));
	}
}
