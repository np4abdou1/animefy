using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;

namespace Android.Gms.Common.Apis
{
	// Token: 0x02000060 RID: 96
	[Register("com/google/android/gms/common/api/GoogleApi", DoNotGenerateAcw = true)]
	internal class GoogleApiInvoker : GoogleApi, IHasApiKey, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x0600043F RID: 1087 RVA: 0x0000D003 File Offset: 0x0000B203
		public GoogleApiInvoker(IntPtr handle, JniHandleOwnership transfer) : base(handle, transfer)
		{
		}

		// Token: 0x1700011E RID: 286
		// (get) Token: 0x06000440 RID: 1088 RVA: 0x0000D00D File Offset: 0x0000B20D
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return GoogleApiInvoker._members;
			}
		}

		// Token: 0x1700011F RID: 287
		// (get) Token: 0x06000441 RID: 1089 RVA: 0x0000D014 File Offset: 0x0000B214
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return GoogleApiInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x04000101 RID: 257
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/google/android/gms/common/api/GoogleApi", typeof(GoogleApiInvoker));
	}
}
