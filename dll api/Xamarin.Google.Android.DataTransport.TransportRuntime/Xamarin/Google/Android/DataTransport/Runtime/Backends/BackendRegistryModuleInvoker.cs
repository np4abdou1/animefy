using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;

namespace Xamarin.Google.Android.DataTransport.Runtime.Backends
{
	// Token: 0x02000084 RID: 132
	[Register("com/google/android/datatransport/runtime/backends/BackendRegistryModule", DoNotGenerateAcw = true)]
	internal class BackendRegistryModuleInvoker : BackendRegistryModule
	{
		// Token: 0x060004CC RID: 1228 RVA: 0x0000ED35 File Offset: 0x0000CF35
		public BackendRegistryModuleInvoker(IntPtr handle, JniHandleOwnership transfer) : base(handle, transfer)
		{
		}

		// Token: 0x17000199 RID: 409
		// (get) Token: 0x060004CD RID: 1229 RVA: 0x0000ED3F File Offset: 0x0000CF3F
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return BackendRegistryModuleInvoker._members;
			}
		}

		// Token: 0x1700019A RID: 410
		// (get) Token: 0x060004CE RID: 1230 RVA: 0x0000ED46 File Offset: 0x0000CF46
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return BackendRegistryModuleInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x04000108 RID: 264
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/google/android/datatransport/runtime/backends/BackendRegistryModule", typeof(BackendRegistryModuleInvoker));
	}
}
