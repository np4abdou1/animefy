using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Android.Views;
using Java.Interop;
using Java.Lang;

namespace AndroidX.Fragment.App
{
	// Token: 0x0200002C RID: 44
	[Register("androidx/fragment/app/FragmentContainer", DoNotGenerateAcw = true)]
	internal class FragmentContainerInvoker : FragmentContainer
	{
		// Token: 0x06000240 RID: 576 RVA: 0x0000770B File Offset: 0x0000590B
		public FragmentContainerInvoker(IntPtr handle, JniHandleOwnership transfer) : base(handle, transfer)
		{
		}

		// Token: 0x17000049 RID: 73
		// (get) Token: 0x06000241 RID: 577 RVA: 0x00007715 File Offset: 0x00005915
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return FragmentContainerInvoker._members;
			}
		}

		// Token: 0x1700004A RID: 74
		// (get) Token: 0x06000242 RID: 578 RVA: 0x0000771C File Offset: 0x0000591C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return FragmentContainerInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06000243 RID: 579 RVA: 0x00007728 File Offset: 0x00005928
		[Register("onFindViewById", "(I)Landroid/view/View;", "GetOnFindViewById_IHandler")]
		public unsafe override View OnFindViewById(int id)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(id);
			return Java.Lang.Object.GetObject<View>(FragmentContainerInvoker._members.InstanceMethods.InvokeAbstractObjectMethod("onFindViewById.(I)Landroid/view/View;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06000244 RID: 580 RVA: 0x00007771 File Offset: 0x00005971
		[Register("onHasView", "()Z", "GetOnHasViewHandler")]
		public override bool OnHasView()
		{
			return FragmentContainerInvoker._members.InstanceMethods.InvokeAbstractBooleanMethod("onHasView.()Z", this, null);
		}

		// Token: 0x0400007B RID: 123
		private static readonly JniPeerMembers _members = new XAPeerMembers("androidx/fragment/app/FragmentContainer", typeof(FragmentContainerInvoker));
	}
}
