using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;

namespace AndroidX.Core.App
{
	// Token: 0x02000085 RID: 133
	[Register("androidx/core/app/SharedElementCallback", DoNotGenerateAcw = true)]
	internal class SharedElementCallbackInvoker : SharedElementCallback
	{
		// Token: 0x0600078D RID: 1933 RVA: 0x00017232 File Offset: 0x00015432
		public SharedElementCallbackInvoker(IntPtr handle, JniHandleOwnership transfer) : base(handle, transfer)
		{
		}

		// Token: 0x1700015B RID: 347
		// (get) Token: 0x0600078E RID: 1934 RVA: 0x0001723C File Offset: 0x0001543C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return SharedElementCallbackInvoker._members;
			}
		}

		// Token: 0x1700015C RID: 348
		// (get) Token: 0x0600078F RID: 1935 RVA: 0x00017243 File Offset: 0x00015443
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return SharedElementCallbackInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x040001F5 RID: 501
		private static readonly JniPeerMembers _members = new XAPeerMembers("androidx/core/app/SharedElementCallback", typeof(SharedElementCallbackInvoker));
	}
}
