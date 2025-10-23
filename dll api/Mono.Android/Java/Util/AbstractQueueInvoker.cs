using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Java.Util
{
	// Token: 0x02000300 RID: 768
	[Register("java/util/AbstractQueue", DoNotGenerateAcw = true)]
	internal class AbstractQueueInvoker : AbstractQueue, IQueue, ICollection, IIterable, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x06001EAF RID: 7855 RVA: 0x00053936 File Offset: 0x00051B36
		public AbstractQueueInvoker(IntPtr handle, JniHandleOwnership transfer) : base(handle, transfer)
		{
		}

		// Token: 0x1700062C RID: 1580
		// (get) Token: 0x06001EB0 RID: 7856 RVA: 0x00053940 File Offset: 0x00051B40
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return AbstractQueueInvoker._members;
			}
		}

		// Token: 0x1700062D RID: 1581
		// (get) Token: 0x06001EB1 RID: 7857 RVA: 0x00053947 File Offset: 0x00051B47
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return AbstractQueueInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06001EB2 RID: 7858 RVA: 0x00053954 File Offset: 0x00051B54
		public unsafe override bool Offer(Java.Lang.Object e)
		{
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((e == null) ? IntPtr.Zero : e.Handle);
				result = AbstractQueueInvoker._members.InstanceMethods.InvokeAbstractBooleanMethod("offer.(Ljava/lang/Object;)Z", this, ptr);
			}
			finally
			{
				GC.KeepAlive(e);
			}
			return result;
		}

		// Token: 0x06001EB3 RID: 7859 RVA: 0x000539BC File Offset: 0x00051BBC
		public override Java.Lang.Object Peek()
		{
			return Java.Lang.Object.GetObject<Java.Lang.Object>(AbstractQueueInvoker._members.InstanceMethods.InvokeAbstractObjectMethod("peek.()Ljava/lang/Object;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06001EB4 RID: 7860 RVA: 0x000539F0 File Offset: 0x00051BF0
		public override Java.Lang.Object Poll()
		{
			return Java.Lang.Object.GetObject<Java.Lang.Object>(AbstractQueueInvoker._members.InstanceMethods.InvokeAbstractObjectMethod("poll.()Ljava/lang/Object;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06001EB5 RID: 7861 RVA: 0x00053A24 File Offset: 0x00051C24
		public override IIterator Iterator()
		{
			return Java.Lang.Object.GetObject<IIterator>(AbstractQueueInvoker._members.InstanceMethods.InvokeAbstractObjectMethod("iterator.()Ljava/util/Iterator;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06001EB6 RID: 7862 RVA: 0x00053A56 File Offset: 0x00051C56
		public override int Size()
		{
			return AbstractQueueInvoker._members.InstanceMethods.InvokeAbstractInt32Method("size.()I", this, null);
		}

		// Token: 0x04000C9D RID: 3229
		private static readonly JniPeerMembers _members = new XAPeerMembers("java/util/AbstractQueue", typeof(AbstractQueueInvoker));
	}
}
