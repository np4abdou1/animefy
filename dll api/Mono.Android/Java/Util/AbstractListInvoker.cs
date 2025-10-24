using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Java.Util
{
	// Token: 0x020002FC RID: 764
	[Register("java/util/AbstractList", DoNotGenerateAcw = true)]
	internal class AbstractListInvoker : AbstractList, IList, ICollection, IIterable, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x06001E67 RID: 7783 RVA: 0x00052F8B File Offset: 0x0005118B
		public AbstractListInvoker(IntPtr handle, JniHandleOwnership transfer) : base(handle, transfer)
		{
		}

		// Token: 0x17000621 RID: 1569
		// (get) Token: 0x06001E68 RID: 7784 RVA: 0x00052F95 File Offset: 0x00051195
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return AbstractListInvoker._members;
			}
		}

		// Token: 0x17000622 RID: 1570
		// (get) Token: 0x06001E69 RID: 7785 RVA: 0x00052F9C File Offset: 0x0005119C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return AbstractListInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06001E6A RID: 7786 RVA: 0x00052FA8 File Offset: 0x000511A8
		public unsafe override Java.Lang.Object Get(int index)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(index);
			return Java.Lang.Object.GetObject<Java.Lang.Object>(AbstractListInvoker._members.InstanceMethods.InvokeAbstractObjectMethod("get.(I)Ljava/lang/Object;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06001E6B RID: 7787 RVA: 0x00052FF1 File Offset: 0x000511F1
		public override int Size()
		{
			return AbstractListInvoker._members.InstanceMethods.InvokeAbstractInt32Method("size.()I", this, null);
		}

		// Token: 0x04000C88 RID: 3208
		private static readonly JniPeerMembers _members = new XAPeerMembers("java/util/AbstractList", typeof(AbstractListInvoker));
	}
}
