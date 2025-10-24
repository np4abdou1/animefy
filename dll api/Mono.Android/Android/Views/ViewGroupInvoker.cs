using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;

namespace Android.Views
{
	// Token: 0x0200015D RID: 349
	[Register("android/view/ViewGroup", DoNotGenerateAcw = true)]
	internal class ViewGroupInvoker : ViewGroup
	{
		// Token: 0x06000C9F RID: 3231 RVA: 0x00003AAC File Offset: 0x00001CAC
		public ViewGroupInvoker(IntPtr handle, JniHandleOwnership transfer) : base(handle, transfer)
		{
		}

		// Token: 0x1700025D RID: 605
		// (get) Token: 0x06000CA0 RID: 3232 RVA: 0x00020A94 File Offset: 0x0001EC94
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return ViewGroupInvoker._members;
			}
		}

		// Token: 0x1700025E RID: 606
		// (get) Token: 0x06000CA1 RID: 3233 RVA: 0x00020A9B File Offset: 0x0001EC9B
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return ViewGroupInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06000CA2 RID: 3234 RVA: 0x00020AA8 File Offset: 0x0001ECA8
		protected unsafe override void OnLayout(bool changed, int l, int t, int r, int b)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(changed);
			ptr[1] = new JniArgumentValue(l);
			ptr[2] = new JniArgumentValue(t);
			ptr[3] = new JniArgumentValue(r);
			ptr[4] = new JniArgumentValue(b);
			ViewGroupInvoker._members.InstanceMethods.InvokeAbstractVoidMethod("onLayout.(ZIIII)V", this, ptr);
		}

		// Token: 0x04000420 RID: 1056
		private static readonly JniPeerMembers _members = new XAPeerMembers("android/view/ViewGroup", typeof(ViewGroupInvoker));
	}
}
