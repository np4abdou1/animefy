using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;

namespace AndroidX.Fragment.App
{
	// Token: 0x02000047 RID: 71
	[Register("androidx/fragment/app/FragmentTransaction", DoNotGenerateAcw = true)]
	internal class FragmentTransactionInvoker : FragmentTransaction
	{
		// Token: 0x06000416 RID: 1046 RVA: 0x0000D6CF File Offset: 0x0000B8CF
		public FragmentTransactionInvoker(IntPtr handle, JniHandleOwnership transfer) : base(handle, transfer)
		{
		}

		// Token: 0x1700008B RID: 139
		// (get) Token: 0x06000417 RID: 1047 RVA: 0x0000D6D9 File Offset: 0x0000B8D9
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return FragmentTransactionInvoker._members;
			}
		}

		// Token: 0x1700008C RID: 140
		// (get) Token: 0x06000418 RID: 1048 RVA: 0x0000D6E0 File Offset: 0x0000B8E0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return FragmentTransactionInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06000419 RID: 1049 RVA: 0x0000D6EC File Offset: 0x0000B8EC
		[Register("commit", "()I", "GetCommitHandler")]
		public override int Commit()
		{
			return FragmentTransactionInvoker._members.InstanceMethods.InvokeAbstractInt32Method("commit.()I", this, null);
		}

		// Token: 0x0600041A RID: 1050 RVA: 0x0000D705 File Offset: 0x0000B905
		[Register("commitAllowingStateLoss", "()I", "GetCommitAllowingStateLossHandler")]
		public override int CommitAllowingStateLoss()
		{
			return FragmentTransactionInvoker._members.InstanceMethods.InvokeAbstractInt32Method("commitAllowingStateLoss.()I", this, null);
		}

		// Token: 0x0600041B RID: 1051 RVA: 0x0000D71E File Offset: 0x0000B91E
		[Register("commitNow", "()V", "GetCommitNowHandler")]
		public override void CommitNow()
		{
			FragmentTransactionInvoker._members.InstanceMethods.InvokeAbstractVoidMethod("commitNow.()V", this, null);
		}

		// Token: 0x0600041C RID: 1052 RVA: 0x0000D737 File Offset: 0x0000B937
		[Register("commitNowAllowingStateLoss", "()V", "GetCommitNowAllowingStateLossHandler")]
		public override void CommitNowAllowingStateLoss()
		{
			FragmentTransactionInvoker._members.InstanceMethods.InvokeAbstractVoidMethod("commitNowAllowingStateLoss.()V", this, null);
		}

		// Token: 0x04000116 RID: 278
		private static readonly JniPeerMembers _members = new XAPeerMembers("androidx/fragment/app/FragmentTransaction", typeof(FragmentTransactionInvoker));
	}
}
