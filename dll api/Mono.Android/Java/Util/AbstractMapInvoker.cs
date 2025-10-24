using System;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;

namespace Java.Util
{
	// Token: 0x020002FE RID: 766
	[Register("java/util/AbstractMap", DoNotGenerateAcw = true)]
	internal class AbstractMapInvoker : AbstractMap, IMap, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x06001E96 RID: 7830 RVA: 0x000536E9 File Offset: 0x000518E9
		public AbstractMapInvoker(IntPtr handle, JniHandleOwnership transfer) : base(handle, transfer)
		{
		}

		// Token: 0x17000627 RID: 1575
		// (get) Token: 0x06001E97 RID: 7831 RVA: 0x000536F3 File Offset: 0x000518F3
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return AbstractMapInvoker._members;
			}
		}

		// Token: 0x17000628 RID: 1576
		// (get) Token: 0x06001E98 RID: 7832 RVA: 0x000536FA File Offset: 0x000518FA
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return AbstractMapInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06001E99 RID: 7833 RVA: 0x00053708 File Offset: 0x00051908
		public override ICollection EntrySet()
		{
			return JavaSet.FromJniHandle(AbstractMapInvoker._members.InstanceMethods.InvokeAbstractObjectMethod("entrySet.()Ljava/util/Set;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x04000C96 RID: 3222
		private static readonly JniPeerMembers _members = new XAPeerMembers("java/util/AbstractMap", typeof(AbstractMapInvoker));
	}
}
