using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;

namespace Kotlin.Collections
{
	// Token: 0x020002C5 RID: 709
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlin/collections/DoubleIterator", DoNotGenerateAcw = true)]
	internal class DoubleIteratorInvoker : DoubleIterator
	{
		// Token: 0x06002749 RID: 10057 RVA: 0x000AB70B File Offset: 0x000A990B
		public DoubleIteratorInvoker(IntPtr handle, JniHandleOwnership transfer) : base(handle, transfer)
		{
		}

		// Token: 0x170009A1 RID: 2465
		// (get) Token: 0x0600274A RID: 10058 RVA: 0x000AB715 File Offset: 0x000A9915
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return DoubleIteratorInvoker._members;
			}
		}

		// Token: 0x170009A2 RID: 2466
		// (get) Token: 0x0600274B RID: 10059 RVA: 0x000AB71C File Offset: 0x000A991C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return DoubleIteratorInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x0600274C RID: 10060 RVA: 0x000AB728 File Offset: 0x000A9928
		[Register("nextDouble", "()D", "GetNextDoubleHandler")]
		public override double NextDouble()
		{
			return DoubleIteratorInvoker._members.InstanceMethods.InvokeAbstractDoubleMethod("nextDouble.()D", this, null);
		}

		// Token: 0x170009A3 RID: 2467
		// (get) Token: 0x0600274D RID: 10061 RVA: 0x000AB741 File Offset: 0x000A9941
		public override bool HasNext
		{
			[Register("hasNext", "()Z", "GetGetHasNextHandler")]
			get
			{
				return DoubleIteratorInvoker._members.InstanceMethods.InvokeAbstractBooleanMethod("hasNext.()Z", this, null);
			}
		}

		// Token: 0x040009A3 RID: 2467
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/collections/DoubleIterator", typeof(DoubleIteratorInvoker));
	}
}
