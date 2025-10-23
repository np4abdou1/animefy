using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;

namespace Kotlin.Time
{
	// Token: 0x020000BE RID: 190
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlin/time/AbstractLongTimeSource", DoNotGenerateAcw = true)]
	internal class AbstractLongTimeSourceInvoker : AbstractLongTimeSource
	{
		// Token: 0x06000577 RID: 1399 RVA: 0x0000D7A4 File Offset: 0x0000B9A4
		public AbstractLongTimeSourceInvoker(IntPtr handle, JniHandleOwnership transfer) : base(handle, transfer)
		{
		}

		// Token: 0x17000175 RID: 373
		// (get) Token: 0x06000578 RID: 1400 RVA: 0x0000D7AE File Offset: 0x0000B9AE
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return AbstractLongTimeSourceInvoker._members;
			}
		}

		// Token: 0x17000176 RID: 374
		// (get) Token: 0x06000579 RID: 1401 RVA: 0x0000D7B5 File Offset: 0x0000B9B5
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return AbstractLongTimeSourceInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x0600057A RID: 1402 RVA: 0x0000D7C1 File Offset: 0x0000B9C1
		[Register("read", "()J", "GetReadHandler")]
		protected override long Read()
		{
			return AbstractLongTimeSourceInvoker._members.InstanceMethods.InvokeAbstractInt64Method("read.()J", this, null);
		}

		// Token: 0x04000186 RID: 390
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/time/AbstractLongTimeSource", typeof(AbstractLongTimeSourceInvoker));
	}
}
