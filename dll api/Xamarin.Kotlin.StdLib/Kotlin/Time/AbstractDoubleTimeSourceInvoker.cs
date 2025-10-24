using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;

namespace Kotlin.Time
{
	// Token: 0x020000BC RID: 188
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlin/time/AbstractDoubleTimeSource", DoNotGenerateAcw = true)]
	internal class AbstractDoubleTimeSourceInvoker : AbstractDoubleTimeSource
	{
		// Token: 0x06000564 RID: 1380 RVA: 0x0000D54C File Offset: 0x0000B74C
		public AbstractDoubleTimeSourceInvoker(IntPtr handle, JniHandleOwnership transfer) : base(handle, transfer)
		{
		}

		// Token: 0x1700016E RID: 366
		// (get) Token: 0x06000565 RID: 1381 RVA: 0x0000D556 File Offset: 0x0000B756
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return AbstractDoubleTimeSourceInvoker._members;
			}
		}

		// Token: 0x1700016F RID: 367
		// (get) Token: 0x06000566 RID: 1382 RVA: 0x0000D55D File Offset: 0x0000B75D
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return AbstractDoubleTimeSourceInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06000567 RID: 1383 RVA: 0x0000D569 File Offset: 0x0000B769
		[Register("read", "()D", "GetReadHandler")]
		protected override double Read()
		{
			return AbstractDoubleTimeSourceInvoker._members.InstanceMethods.InvokeAbstractDoubleMethod("read.()D", this, null);
		}

		// Token: 0x04000182 RID: 386
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/time/AbstractDoubleTimeSource", typeof(AbstractDoubleTimeSourceInvoker));
	}
}
