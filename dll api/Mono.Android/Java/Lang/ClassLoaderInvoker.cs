using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;

namespace Java.Lang
{
	// Token: 0x020003C4 RID: 964
	[Register("java/lang/ClassLoader", DoNotGenerateAcw = true)]
	internal class ClassLoaderInvoker : ClassLoader
	{
		// Token: 0x06002A94 RID: 10900 RVA: 0x0007712B File Offset: 0x0007532B
		public ClassLoaderInvoker(IntPtr handle, JniHandleOwnership transfer) : base(handle, transfer)
		{
		}

		// Token: 0x1700084D RID: 2125
		// (get) Token: 0x06002A95 RID: 10901 RVA: 0x00077135 File Offset: 0x00075335
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return ClassLoaderInvoker._members;
			}
		}

		// Token: 0x1700084E RID: 2126
		// (get) Token: 0x06002A96 RID: 10902 RVA: 0x0007713C File Offset: 0x0007533C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return ClassLoaderInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x04001136 RID: 4406
		private static readonly JniPeerMembers _members = new XAPeerMembers("java/lang/ClassLoader", typeof(ClassLoaderInvoker));
	}
}
