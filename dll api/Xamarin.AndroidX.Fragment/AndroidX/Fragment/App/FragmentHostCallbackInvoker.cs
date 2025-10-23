using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace AndroidX.Fragment.App
{
	// Token: 0x0200002F RID: 47
	[Register("androidx/fragment/app/FragmentHostCallback", DoNotGenerateAcw = true)]
	internal class FragmentHostCallbackInvoker : FragmentHostCallback
	{
		// Token: 0x06000285 RID: 645 RVA: 0x000085F3 File Offset: 0x000067F3
		public FragmentHostCallbackInvoker(IntPtr handle, JniHandleOwnership transfer) : base(handle, transfer)
		{
		}

		// Token: 0x17000054 RID: 84
		// (get) Token: 0x06000286 RID: 646 RVA: 0x000085FD File Offset: 0x000067FD
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return FragmentHostCallbackInvoker._members;
			}
		}

		// Token: 0x17000055 RID: 85
		// (get) Token: 0x06000287 RID: 647 RVA: 0x00008604 File Offset: 0x00006804
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return FragmentHostCallbackInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06000288 RID: 648 RVA: 0x00008610 File Offset: 0x00006810
		[Register("onGetHost", "()Ljava/lang/Object;", "GetOnGetHostHandler")]
		public override Java.Lang.Object OnGetHost()
		{
			return Java.Lang.Object.GetObject<Java.Lang.Object>(FragmentHostCallbackInvoker._members.InstanceMethods.InvokeAbstractObjectMethod("onGetHost.()Ljava/lang/Object;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x0400008E RID: 142
		private static readonly JniPeerMembers _members = new XAPeerMembers("androidx/fragment/app/FragmentHostCallback", typeof(FragmentHostCallbackInvoker));
	}
}
