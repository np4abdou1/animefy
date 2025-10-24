using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Android.Widget
{
	// Token: 0x020000A4 RID: 164
	[Register("android/widget/AbsListView", DoNotGenerateAcw = true)]
	internal class AbsListViewInvoker : AbsListView
	{
		// Token: 0x060002B7 RID: 695 RVA: 0x0000393D File Offset: 0x00001B3D
		public AbsListViewInvoker(IntPtr handle, JniHandleOwnership transfer) : base(handle, transfer)
		{
		}

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x060002B8 RID: 696 RVA: 0x00003947 File Offset: 0x00001B47
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return AbsListViewInvoker._members;
			}
		}

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x060002B9 RID: 697 RVA: 0x0000394E File Offset: 0x00001B4E
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return AbsListViewInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x1700002C RID: 44
		// (set) Token: 0x060002BA RID: 698 RVA: 0x0000395C File Offset: 0x00001B5C
		protected unsafe override Java.Lang.Object RawAdapter
		{
			set
			{
				IntPtr intPtr = JNIEnv.ToLocalJniHandle(value);
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue(intPtr);
					AbsListViewInvoker._members.InstanceMethods.InvokeAbstractVoidMethod("setAdapter.(Landroid/widget/Adapter;)V", this, ptr);
				}
				finally
				{
					JNIEnv.DeleteLocalRef(intPtr);
					GC.KeepAlive(value);
				}
			}
		}

		// Token: 0x060002BB RID: 699 RVA: 0x000039C0 File Offset: 0x00001BC0
		public unsafe override void SetSelection(int position)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(position);
			AbsListViewInvoker._members.InstanceMethods.InvokeAbstractVoidMethod("setSelection.(I)V", this, ptr);
		}

		// Token: 0x1700002D RID: 45
		// (set) Token: 0x060002BC RID: 700 RVA: 0x000039FC File Offset: 0x00001BFC
		public unsafe override IListAdapter Adapter
		{
			set
			{
				IntPtr intPtr = JNIEnv.ToLocalJniHandle(value);
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue(intPtr);
					AbsListViewInvoker._members.InstanceMethods.InvokeVirtualVoidMethod("setAdapter.(Landroid/widget/Adapter;)V", this, ptr);
				}
				finally
				{
					JNIEnv.DeleteLocalRef(intPtr);
				}
			}
		}

		// Token: 0x0400004D RID: 77
		private static readonly JniPeerMembers _members = new XAPeerMembers("android/widget/AbsListView", typeof(AbsListViewInvoker));
	}
}
