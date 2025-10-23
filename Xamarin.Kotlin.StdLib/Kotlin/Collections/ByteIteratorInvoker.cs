using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;

namespace Kotlin.Collections
{
	// Token: 0x020002C0 RID: 704
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlin/collections/ByteIterator", DoNotGenerateAcw = true)]
	internal class ByteIteratorInvoker : ByteIterator
	{
		// Token: 0x06002611 RID: 9745 RVA: 0x000A1AEF File Offset: 0x0009FCEF
		public ByteIteratorInvoker(IntPtr handle, JniHandleOwnership transfer) : base(handle, transfer)
		{
		}

		// Token: 0x1700098D RID: 2445
		// (get) Token: 0x06002612 RID: 9746 RVA: 0x000A1AF9 File Offset: 0x0009FCF9
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return ByteIteratorInvoker._members;
			}
		}

		// Token: 0x1700098E RID: 2446
		// (get) Token: 0x06002613 RID: 9747 RVA: 0x000A1B00 File Offset: 0x0009FD00
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return ByteIteratorInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06002614 RID: 9748 RVA: 0x000A1B0C File Offset: 0x0009FD0C
		[Register("nextByte", "()B", "GetNextByteHandler")]
		public override sbyte NextByte()
		{
			return ByteIteratorInvoker._members.InstanceMethods.InvokeAbstractSByteMethod("nextByte.()B", this, null);
		}

		// Token: 0x1700098F RID: 2447
		// (get) Token: 0x06002615 RID: 9749 RVA: 0x000A1B25 File Offset: 0x0009FD25
		public override bool HasNext
		{
			[Register("hasNext", "()Z", "GetGetHasNextHandler")]
			get
			{
				return ByteIteratorInvoker._members.InstanceMethods.InvokeAbstractBooleanMethod("hasNext.()Z", this, null);
			}
		}

		// Token: 0x04000998 RID: 2456
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/collections/ByteIterator", typeof(ByteIteratorInvoker));
	}
}
