using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;

namespace Com.Unity3d.Services.Core.Misc
{
	// Token: 0x020000E4 RID: 228
	[Register("com/unity3d/services/core/misc/Observable", DoNotGenerateAcw = true)]
	internal class ObservableInvoker : Observable
	{
		// Token: 0x0600090B RID: 2315 RVA: 0x0001A297 File Offset: 0x00018497
		public ObservableInvoker(IntPtr handle, JniHandleOwnership transfer) : base(handle, transfer)
		{
		}

		// Token: 0x170002DD RID: 733
		// (get) Token: 0x0600090C RID: 2316 RVA: 0x0001A2A1 File Offset: 0x000184A1
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return ObservableInvoker._members;
			}
		}

		// Token: 0x170002DE RID: 734
		// (get) Token: 0x0600090D RID: 2317 RVA: 0x0001A2A8 File Offset: 0x000184A8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return ObservableInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x04000226 RID: 550
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/services/core/misc/Observable", typeof(ObservableInvoker));
	}
}
