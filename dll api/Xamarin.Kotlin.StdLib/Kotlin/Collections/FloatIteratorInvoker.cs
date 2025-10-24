using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;

namespace Kotlin.Collections
{
	// Token: 0x020002C7 RID: 711
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlin/collections/FloatIterator", DoNotGenerateAcw = true)]
	internal class FloatIteratorInvoker : FloatIterator
	{
		// Token: 0x06002760 RID: 10080 RVA: 0x000AB94F File Offset: 0x000A9B4F
		public FloatIteratorInvoker(IntPtr handle, JniHandleOwnership transfer) : base(handle, transfer)
		{
		}

		// Token: 0x170009A9 RID: 2473
		// (get) Token: 0x06002761 RID: 10081 RVA: 0x000AB959 File Offset: 0x000A9B59
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return FloatIteratorInvoker._members;
			}
		}

		// Token: 0x170009AA RID: 2474
		// (get) Token: 0x06002762 RID: 10082 RVA: 0x000AB960 File Offset: 0x000A9B60
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return FloatIteratorInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06002763 RID: 10083 RVA: 0x000AB96C File Offset: 0x000A9B6C
		[Register("nextFloat", "()F", "GetNextFloatHandler")]
		public override float NextFloat()
		{
			return FloatIteratorInvoker._members.InstanceMethods.InvokeAbstractSingleMethod("nextFloat.()F", this, null);
		}

		// Token: 0x170009AB RID: 2475
		// (get) Token: 0x06002764 RID: 10084 RVA: 0x000AB985 File Offset: 0x000A9B85
		public override bool HasNext
		{
			[Register("hasNext", "()Z", "GetGetHasNextHandler")]
			get
			{
				return FloatIteratorInvoker._members.InstanceMethods.InvokeAbstractBooleanMethod("hasNext.()Z", this, null);
			}
		}

		// Token: 0x040009A8 RID: 2472
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/collections/FloatIterator", typeof(FloatIteratorInvoker));
	}
}
