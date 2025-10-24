using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;

namespace Kotlin.Collections
{
	// Token: 0x020002D4 RID: 724
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlin/collections/ShortIterator", DoNotGenerateAcw = true)]
	internal class ShortIteratorInvoker : ShortIterator
	{
		// Token: 0x06002843 RID: 10307 RVA: 0x000B034B File Offset: 0x000AE54B
		public ShortIteratorInvoker(IntPtr handle, JniHandleOwnership transfer) : base(handle, transfer)
		{
		}

		// Token: 0x170009DB RID: 2523
		// (get) Token: 0x06002844 RID: 10308 RVA: 0x000B0355 File Offset: 0x000AE555
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return ShortIteratorInvoker._members;
			}
		}

		// Token: 0x170009DC RID: 2524
		// (get) Token: 0x06002845 RID: 10309 RVA: 0x000B035C File Offset: 0x000AE55C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return ShortIteratorInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06002846 RID: 10310 RVA: 0x000B0368 File Offset: 0x000AE568
		[Register("nextShort", "()S", "GetNextShortHandler")]
		public override short NextShort()
		{
			return ShortIteratorInvoker._members.InstanceMethods.InvokeAbstractInt16Method("nextShort.()S", this, null);
		}

		// Token: 0x170009DD RID: 2525
		// (get) Token: 0x06002847 RID: 10311 RVA: 0x000B0381 File Offset: 0x000AE581
		public override bool HasNext
		{
			[Register("hasNext", "()Z", "GetGetHasNextHandler")]
			get
			{
				return ShortIteratorInvoker._members.InstanceMethods.InvokeAbstractBooleanMethod("hasNext.()Z", this, null);
			}
		}

		// Token: 0x040009C2 RID: 2498
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/collections/ShortIterator", typeof(ShortIteratorInvoker));
	}
}
