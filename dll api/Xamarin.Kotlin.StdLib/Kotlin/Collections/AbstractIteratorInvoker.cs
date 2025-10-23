using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;

namespace Kotlin.Collections
{
	// Token: 0x020002AE RID: 686
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlin/collections/AbstractIterator", DoNotGenerateAcw = true)]
	internal class AbstractIteratorInvoker : AbstractIterator
	{
		// Token: 0x06001FC6 RID: 8134 RVA: 0x0006A5DF File Offset: 0x000687DF
		public AbstractIteratorInvoker(IntPtr handle, JniHandleOwnership transfer) : base(handle, transfer)
		{
		}

		// Token: 0x17000949 RID: 2377
		// (get) Token: 0x06001FC7 RID: 8135 RVA: 0x0006A5E9 File Offset: 0x000687E9
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return AbstractIteratorInvoker._members;
			}
		}

		// Token: 0x1700094A RID: 2378
		// (get) Token: 0x06001FC8 RID: 8136 RVA: 0x0006A5F0 File Offset: 0x000687F0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return AbstractIteratorInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06001FC9 RID: 8137 RVA: 0x0006A5FC File Offset: 0x000687FC
		[Register("computeNext", "()V", "GetComputeNextHandler")]
		protected override void ComputeNext()
		{
			AbstractIteratorInvoker._members.InstanceMethods.InvokeAbstractVoidMethod("computeNext.()V", this, null);
		}

		// Token: 0x0400095D RID: 2397
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/collections/AbstractIterator", typeof(AbstractIteratorInvoker));
	}
}
