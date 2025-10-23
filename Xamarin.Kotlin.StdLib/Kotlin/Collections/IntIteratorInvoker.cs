using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;

namespace Kotlin.Collections
{
	// Token: 0x020002CD RID: 717
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlin/collections/IntIterator", DoNotGenerateAcw = true)]
	internal class IntIteratorInvoker : IntIterator
	{
		// Token: 0x060027A4 RID: 10148 RVA: 0x000AC85B File Offset: 0x000AAA5B
		public IntIteratorInvoker(IntPtr handle, JniHandleOwnership transfer) : base(handle, transfer)
		{
		}

		// Token: 0x170009BF RID: 2495
		// (get) Token: 0x060027A5 RID: 10149 RVA: 0x000AC865 File Offset: 0x000AAA65
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IntIteratorInvoker._members;
			}
		}

		// Token: 0x170009C0 RID: 2496
		// (get) Token: 0x060027A6 RID: 10150 RVA: 0x000AC86C File Offset: 0x000AAA6C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IntIteratorInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x060027A7 RID: 10151 RVA: 0x000AC878 File Offset: 0x000AAA78
		[Register("nextInt", "()I", "GetNextIntHandler")]
		public override int NextInt()
		{
			return IntIteratorInvoker._members.InstanceMethods.InvokeAbstractInt32Method("nextInt.()I", this, null);
		}

		// Token: 0x170009C1 RID: 2497
		// (get) Token: 0x060027A8 RID: 10152 RVA: 0x000AC891 File Offset: 0x000AAA91
		public override bool HasNext
		{
			[Register("hasNext", "()Z", "GetGetHasNextHandler")]
			get
			{
				return IntIteratorInvoker._members.InstanceMethods.InvokeAbstractBooleanMethod("hasNext.()Z", this, null);
			}
		}

		// Token: 0x040009B5 RID: 2485
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/collections/IntIterator", typeof(IntIteratorInvoker));
	}
}
