using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Java.Util
{
	// Token: 0x020002FA RID: 762
	[Register("java/util/AbstractCollection", DoNotGenerateAcw = true)]
	internal class AbstractCollectionInvoker : AbstractCollection, ICollection, IIterable, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x06001E3B RID: 7739 RVA: 0x0005284F File Offset: 0x00050A4F
		public AbstractCollectionInvoker(IntPtr handle, JniHandleOwnership transfer) : base(handle, transfer)
		{
		}

		// Token: 0x1700061C RID: 1564
		// (get) Token: 0x06001E3C RID: 7740 RVA: 0x00052859 File Offset: 0x00050A59
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return AbstractCollectionInvoker._members;
			}
		}

		// Token: 0x1700061D RID: 1565
		// (get) Token: 0x06001E3D RID: 7741 RVA: 0x00052860 File Offset: 0x00050A60
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return AbstractCollectionInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06001E3E RID: 7742 RVA: 0x0005286C File Offset: 0x00050A6C
		public override IIterator Iterator()
		{
			return Java.Lang.Object.GetObject<IIterator>(AbstractCollectionInvoker._members.InstanceMethods.InvokeAbstractObjectMethod("iterator.()Ljava/util/Iterator;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06001E3F RID: 7743 RVA: 0x0005289E File Offset: 0x00050A9E
		public override int Size()
		{
			return AbstractCollectionInvoker._members.InstanceMethods.InvokeAbstractInt32Method("size.()I", this, null);
		}

		// Token: 0x04000C7B RID: 3195
		private static readonly JniPeerMembers _members = new XAPeerMembers("java/util/AbstractCollection", typeof(AbstractCollectionInvoker));
	}
}
