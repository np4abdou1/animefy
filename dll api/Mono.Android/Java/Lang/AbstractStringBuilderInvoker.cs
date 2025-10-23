using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;

namespace Java.Lang
{
	// Token: 0x020003BD RID: 957
	[Register("java/lang/AbstractStringBuilder", DoNotGenerateAcw = true)]
	internal class AbstractStringBuilderInvoker : AbstractStringBuilder
	{
		// Token: 0x06002A24 RID: 10788 RVA: 0x000764C2 File Offset: 0x000746C2
		public AbstractStringBuilderInvoker(IntPtr handle, JniHandleOwnership transfer) : base(handle, transfer)
		{
		}

		// Token: 0x17000837 RID: 2103
		// (get) Token: 0x06002A25 RID: 10789 RVA: 0x000764CC File Offset: 0x000746CC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return AbstractStringBuilderInvoker._members;
			}
		}

		// Token: 0x17000838 RID: 2104
		// (get) Token: 0x06002A26 RID: 10790 RVA: 0x000764D3 File Offset: 0x000746D3
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return AbstractStringBuilderInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06002A27 RID: 10791 RVA: 0x000764E0 File Offset: 0x000746E0
		public override string ToString()
		{
			return JNIEnv.GetString(AbstractStringBuilderInvoker._members.InstanceMethods.InvokeAbstractObjectMethod("toString.()Ljava/lang/String;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x0400112B RID: 4395
		private static readonly JniPeerMembers _members = new XAPeerMembers("java/lang/AbstractStringBuilder", typeof(AbstractStringBuilderInvoker));
	}
}
