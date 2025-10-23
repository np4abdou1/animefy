using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;

namespace Android.Database
{
	// Token: 0x02000243 RID: 579
	[Register("android/database/DataSetObserver", DoNotGenerateAcw = true)]
	internal class DataSetObserverInvoker : DataSetObserver
	{
		// Token: 0x06001481 RID: 5249 RVA: 0x00034BEB File Offset: 0x00032DEB
		public DataSetObserverInvoker(IntPtr handle, JniHandleOwnership transfer) : base(handle, transfer)
		{
		}

		// Token: 0x17000487 RID: 1159
		// (get) Token: 0x06001482 RID: 5250 RVA: 0x00034BF5 File Offset: 0x00032DF5
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return DataSetObserverInvoker._members;
			}
		}

		// Token: 0x17000488 RID: 1160
		// (get) Token: 0x06001483 RID: 5251 RVA: 0x00034BFC File Offset: 0x00032DFC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return DataSetObserverInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x040008ED RID: 2285
		private static readonly JniPeerMembers _members = new XAPeerMembers("android/database/DataSetObserver", typeof(DataSetObserverInvoker));
	}
}
