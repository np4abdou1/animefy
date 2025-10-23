using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;

namespace Kotlin.Collections
{
	// Token: 0x020002CF RID: 719
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlin/collections/LongIterator", DoNotGenerateAcw = true)]
	internal class LongIteratorInvoker : LongIterator
	{
		// Token: 0x060027BB RID: 10171 RVA: 0x000ACA9F File Offset: 0x000AAC9F
		public LongIteratorInvoker(IntPtr handle, JniHandleOwnership transfer) : base(handle, transfer)
		{
		}

		// Token: 0x170009C7 RID: 2503
		// (get) Token: 0x060027BC RID: 10172 RVA: 0x000ACAA9 File Offset: 0x000AACA9
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return LongIteratorInvoker._members;
			}
		}

		// Token: 0x170009C8 RID: 2504
		// (get) Token: 0x060027BD RID: 10173 RVA: 0x000ACAB0 File Offset: 0x000AACB0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return LongIteratorInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x060027BE RID: 10174 RVA: 0x000ACABC File Offset: 0x000AACBC
		[Register("nextLong", "()J", "GetNextLongHandler")]
		public override long NextLong()
		{
			return LongIteratorInvoker._members.InstanceMethods.InvokeAbstractInt64Method("nextLong.()J", this, null);
		}

		// Token: 0x170009C9 RID: 2505
		// (get) Token: 0x060027BF RID: 10175 RVA: 0x000ACAD5 File Offset: 0x000AACD5
		public override bool HasNext
		{
			[Register("hasNext", "()Z", "GetGetHasNextHandler")]
			get
			{
				return LongIteratorInvoker._members.InstanceMethods.InvokeAbstractBooleanMethod("hasNext.()Z", this, null);
			}
		}

		// Token: 0x040009BA RID: 2490
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/collections/LongIterator", typeof(LongIteratorInvoker));
	}
}
