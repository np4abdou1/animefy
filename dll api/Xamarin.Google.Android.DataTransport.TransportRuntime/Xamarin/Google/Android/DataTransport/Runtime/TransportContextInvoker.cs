using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Xamarin.Google.Android.DataTransport.Runtime
{
	// Token: 0x0200002B RID: 43
	[Register("com/google/android/datatransport/runtime/TransportContext", DoNotGenerateAcw = true)]
	internal class TransportContextInvoker : TransportContext
	{
		// Token: 0x0600014E RID: 334 RVA: 0x0000478B File Offset: 0x0000298B
		public TransportContextInvoker(IntPtr handle, JniHandleOwnership transfer) : base(handle, transfer)
		{
		}

		// Token: 0x1700004E RID: 78
		// (get) Token: 0x0600014F RID: 335 RVA: 0x00004795 File Offset: 0x00002995
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return TransportContextInvoker._members;
			}
		}

		// Token: 0x1700004F RID: 79
		// (get) Token: 0x06000150 RID: 336 RVA: 0x0000479C File Offset: 0x0000299C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return TransportContextInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x17000050 RID: 80
		// (get) Token: 0x06000151 RID: 337 RVA: 0x000047A8 File Offset: 0x000029A8
		public override string BackendName
		{
			[Register("getBackendName", "()Ljava/lang/String;", "GetGetBackendNameHandler")]
			get
			{
				return JNIEnv.GetString(TransportContextInvoker._members.InstanceMethods.InvokeAbstractObjectMethod("getBackendName.()Ljava/lang/String;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000051 RID: 81
		// (get) Token: 0x06000152 RID: 338 RVA: 0x000047DC File Offset: 0x000029DC
		public override Priority Priority
		{
			[Register("getPriority", "()Lcom/google/android/datatransport/Priority;", "GetGetPriorityHandler")]
			get
			{
				return Java.Lang.Object.GetObject<Priority>(TransportContextInvoker._members.InstanceMethods.InvokeAbstractObjectMethod("getPriority.()Lcom/google/android/datatransport/Priority;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06000153 RID: 339 RVA: 0x00004810 File Offset: 0x00002A10
		[Register("getExtras", "()[B", "GetGetExtrasHandler")]
		public override byte[] GetExtras()
		{
			return (byte[])JNIEnv.GetArray(TransportContextInvoker._members.InstanceMethods.InvokeAbstractObjectMethod("getExtras.()[B", this, null).Handle, JniHandleOwnership.TransferLocalRef, typeof(byte));
		}

		// Token: 0x04000046 RID: 70
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/google/android/datatransport/runtime/TransportContext", typeof(TransportContextInvoker));
	}
}
