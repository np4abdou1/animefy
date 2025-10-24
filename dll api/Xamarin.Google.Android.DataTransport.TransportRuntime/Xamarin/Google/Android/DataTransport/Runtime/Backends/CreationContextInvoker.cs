using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Content;
using Android.Runtime;
using Java.Interop;
using Java.Lang;
using Xamarin.Google.Android.DataTransport.Runtime.Time;

namespace Xamarin.Google.Android.DataTransport.Runtime.Backends
{
	// Token: 0x0200008D RID: 141
	[Register("com/google/android/datatransport/runtime/backends/CreationContext", DoNotGenerateAcw = true)]
	internal class CreationContextInvoker : CreationContext
	{
		// Token: 0x06000534 RID: 1332 RVA: 0x0000FB7F File Offset: 0x0000DD7F
		public CreationContextInvoker(IntPtr handle, JniHandleOwnership transfer) : base(handle, transfer)
		{
		}

		// Token: 0x170001C1 RID: 449
		// (get) Token: 0x06000535 RID: 1333 RVA: 0x0000FB89 File Offset: 0x0000DD89
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return CreationContextInvoker._members;
			}
		}

		// Token: 0x170001C2 RID: 450
		// (get) Token: 0x06000536 RID: 1334 RVA: 0x0000FB90 File Offset: 0x0000DD90
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return CreationContextInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x170001C3 RID: 451
		// (get) Token: 0x06000537 RID: 1335 RVA: 0x0000FB9C File Offset: 0x0000DD9C
		public override Context ApplicationContext
		{
			[Register("getApplicationContext", "()Landroid/content/Context;", "GetGetApplicationContextHandler")]
			get
			{
				return Java.Lang.Object.GetObject<Context>(CreationContextInvoker._members.InstanceMethods.InvokeAbstractObjectMethod("getApplicationContext.()Landroid/content/Context;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x170001C4 RID: 452
		// (get) Token: 0x06000538 RID: 1336 RVA: 0x0000FBD0 File Offset: 0x0000DDD0
		public override string BackendName
		{
			[Register("getBackendName", "()Ljava/lang/String;", "GetGetBackendNameHandler")]
			get
			{
				return JNIEnv.GetString(CreationContextInvoker._members.InstanceMethods.InvokeAbstractObjectMethod("getBackendName.()Ljava/lang/String;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x170001C5 RID: 453
		// (get) Token: 0x06000539 RID: 1337 RVA: 0x0000FC04 File Offset: 0x0000DE04
		public override IClock MonotonicClock
		{
			[Register("getMonotonicClock", "()Lcom/google/android/datatransport/runtime/time/Clock;", "GetGetMonotonicClockHandler")]
			get
			{
				return Java.Lang.Object.GetObject<IClock>(CreationContextInvoker._members.InstanceMethods.InvokeAbstractObjectMethod("getMonotonicClock.()Lcom/google/android/datatransport/runtime/time/Clock;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x170001C6 RID: 454
		// (get) Token: 0x0600053A RID: 1338 RVA: 0x0000FC38 File Offset: 0x0000DE38
		public override IClock WallClock
		{
			[Register("getWallClock", "()Lcom/google/android/datatransport/runtime/time/Clock;", "GetGetWallClockHandler")]
			get
			{
				return Java.Lang.Object.GetObject<IClock>(CreationContextInvoker._members.InstanceMethods.InvokeAbstractObjectMethod("getWallClock.()Lcom/google/android/datatransport/runtime/time/Clock;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x0400011C RID: 284
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/google/android/datatransport/runtime/backends/CreationContext", typeof(CreationContextInvoker));
	}
}
