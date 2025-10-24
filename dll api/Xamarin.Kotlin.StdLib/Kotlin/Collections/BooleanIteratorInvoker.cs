using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;

namespace Kotlin.Collections
{
	// Token: 0x020002BE RID: 702
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlin/collections/BooleanIterator", DoNotGenerateAcw = true)]
	internal class BooleanIteratorInvoker : BooleanIterator
	{
		// Token: 0x060025FA RID: 9722 RVA: 0x000A18AB File Offset: 0x0009FAAB
		public BooleanIteratorInvoker(IntPtr handle, JniHandleOwnership transfer) : base(handle, transfer)
		{
		}

		// Token: 0x17000985 RID: 2437
		// (get) Token: 0x060025FB RID: 9723 RVA: 0x000A18B5 File Offset: 0x0009FAB5
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return BooleanIteratorInvoker._members;
			}
		}

		// Token: 0x17000986 RID: 2438
		// (get) Token: 0x060025FC RID: 9724 RVA: 0x000A18BC File Offset: 0x0009FABC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return BooleanIteratorInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x060025FD RID: 9725 RVA: 0x000A18C8 File Offset: 0x0009FAC8
		[Register("nextBoolean", "()Z", "GetNextBooleanHandler")]
		public override bool NextBoolean()
		{
			return BooleanIteratorInvoker._members.InstanceMethods.InvokeAbstractBooleanMethod("nextBoolean.()Z", this, null);
		}

		// Token: 0x17000987 RID: 2439
		// (get) Token: 0x060025FE RID: 9726 RVA: 0x000A18E1 File Offset: 0x0009FAE1
		public override bool HasNext
		{
			[Register("hasNext", "()Z", "GetGetHasNextHandler")]
			get
			{
				return BooleanIteratorInvoker._members.InstanceMethods.InvokeAbstractBooleanMethod("hasNext.()Z", this, null);
			}
		}

		// Token: 0x04000993 RID: 2451
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/collections/BooleanIterator", typeof(BooleanIteratorInvoker));
	}
}
