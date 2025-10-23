using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Java.Util
{
	// Token: 0x02000302 RID: 770
	[Register("java/util/AbstractSet", DoNotGenerateAcw = true)]
	internal class AbstractSetInvoker : AbstractSet, ISet, ICollection, IIterable, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x06001EBD RID: 7869 RVA: 0x00053ADF File Offset: 0x00051CDF
		public AbstractSetInvoker(IntPtr handle, JniHandleOwnership transfer) : base(handle, transfer)
		{
		}

		// Token: 0x17000631 RID: 1585
		// (get) Token: 0x06001EBE RID: 7870 RVA: 0x00053AE9 File Offset: 0x00051CE9
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return AbstractSetInvoker._members;
			}
		}

		// Token: 0x17000632 RID: 1586
		// (get) Token: 0x06001EBF RID: 7871 RVA: 0x00053AF0 File Offset: 0x00051CF0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return AbstractSetInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06001EC0 RID: 7872 RVA: 0x00053AFC File Offset: 0x00051CFC
		public override IIterator Iterator()
		{
			return Java.Lang.Object.GetObject<IIterator>(AbstractSetInvoker._members.InstanceMethods.InvokeAbstractObjectMethod("iterator.()Ljava/util/Iterator;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06001EC1 RID: 7873 RVA: 0x00053B2E File Offset: 0x00051D2E
		public override int Size()
		{
			return AbstractSetInvoker._members.InstanceMethods.InvokeAbstractInt32Method("size.()I", this, null);
		}

		// Token: 0x04000C9F RID: 3231
		private static readonly JniPeerMembers _members = new XAPeerMembers("java/util/AbstractSet", typeof(AbstractSetInvoker));
	}
}
