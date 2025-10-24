using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;

namespace Bumptech.Glide.Util.Pool
{
	// Token: 0x02000059 RID: 89
	[Register("com/bumptech/glide/util/pool/StateVerifier", DoNotGenerateAcw = true)]
	internal class StateVerifierInvoker : StateVerifier
	{
		// Token: 0x0600040C RID: 1036 RVA: 0x0000DC63 File Offset: 0x0000BE63
		public StateVerifierInvoker(IntPtr handle, JniHandleOwnership transfer) : base(handle, transfer)
		{
		}

		// Token: 0x170000A9 RID: 169
		// (get) Token: 0x0600040D RID: 1037 RVA: 0x0000DC6D File Offset: 0x0000BE6D
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return StateVerifierInvoker._members;
			}
		}

		// Token: 0x170000AA RID: 170
		// (get) Token: 0x0600040E RID: 1038 RVA: 0x0000DC74 File Offset: 0x0000BE74
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return StateVerifierInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x0600040F RID: 1039 RVA: 0x0000DC80 File Offset: 0x0000BE80
		[Register("throwIfRecycled", "()V", "GetThrowIfRecycledHandler")]
		public override void ThrowIfRecycled()
		{
			StateVerifierInvoker._members.InstanceMethods.InvokeAbstractVoidMethod("throwIfRecycled.()V", this, null);
		}

		// Token: 0x040000D6 RID: 214
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/bumptech/glide/util/pool/StateVerifier", typeof(StateVerifierInvoker));
	}
}
