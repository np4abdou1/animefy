using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;
using Java.Util;

namespace Kotlin.Collections
{
	// Token: 0x020002AC RID: 684
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlin/collections/AbstractCollection", DoNotGenerateAcw = true)]
	internal class AbstractCollectionInvoker : AbstractCollection
	{
		// Token: 0x06001FAB RID: 8107 RVA: 0x0006A2AF File Offset: 0x000684AF
		public AbstractCollectionInvoker(IntPtr handle, JniHandleOwnership transfer) : base(handle, transfer)
		{
		}

		// Token: 0x17000942 RID: 2370
		// (get) Token: 0x06001FAC RID: 8108 RVA: 0x0006A2B9 File Offset: 0x000684B9
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return AbstractCollectionInvoker._members;
			}
		}

		// Token: 0x17000943 RID: 2371
		// (get) Token: 0x06001FAD RID: 8109 RVA: 0x0006A2C0 File Offset: 0x000684C0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return AbstractCollectionInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06001FAE RID: 8110 RVA: 0x0006A2CC File Offset: 0x000684CC
		[Register("getSize", "()I", "GetGetSizeHandler")]
		public override int GetSize()
		{
			return AbstractCollectionInvoker._members.InstanceMethods.InvokeAbstractInt32Method("getSize.()I", this, null);
		}

		// Token: 0x06001FAF RID: 8111 RVA: 0x0006A2E8 File Offset: 0x000684E8
		[Register("iterator", "()Ljava/util/Iterator;", "GetIteratorHandler")]
		public override IIterator Iterator()
		{
			return Java.Lang.Object.GetObject<IIterator>(AbstractCollectionInvoker._members.InstanceMethods.InvokeAbstractObjectMethod("iterator.()Ljava/util/Iterator;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x04000957 RID: 2391
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/collections/AbstractCollection", typeof(AbstractCollectionInvoker));
	}
}
