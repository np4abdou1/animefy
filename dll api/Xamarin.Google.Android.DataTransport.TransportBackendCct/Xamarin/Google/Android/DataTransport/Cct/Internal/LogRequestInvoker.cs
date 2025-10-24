using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Xamarin.Google.Android.DataTransport.Cct.Internal
{
	// Token: 0x0200001D RID: 29
	[Register("com/google/android/datatransport/cct/internal/LogRequest", DoNotGenerateAcw = true)]
	internal class LogRequestInvoker : LogRequest
	{
		// Token: 0x0600018A RID: 394 RVA: 0x000051D0 File Offset: 0x000033D0
		public LogRequestInvoker(IntPtr handle, JniHandleOwnership transfer) : base(handle, transfer)
		{
		}

		// Token: 0x1700007C RID: 124
		// (get) Token: 0x0600018B RID: 395 RVA: 0x000051DA File Offset: 0x000033DA
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return LogRequestInvoker._members;
			}
		}

		// Token: 0x1700007D RID: 125
		// (get) Token: 0x0600018C RID: 396 RVA: 0x000051E1 File Offset: 0x000033E1
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return LogRequestInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x1700007E RID: 126
		// (get) Token: 0x0600018D RID: 397 RVA: 0x000051F0 File Offset: 0x000033F0
		public override ClientInfo ClientInfo
		{
			[Register("getClientInfo", "()Lcom/google/android/datatransport/cct/internal/ClientInfo;", "GetGetClientInfoHandler")]
			get
			{
				return Java.Lang.Object.GetObject<ClientInfo>(LogRequestInvoker._members.InstanceMethods.InvokeAbstractObjectMethod("getClientInfo.()Lcom/google/android/datatransport/cct/internal/ClientInfo;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x1700007F RID: 127
		// (get) Token: 0x0600018E RID: 398 RVA: 0x00005224 File Offset: 0x00003424
		public override IList<LogEvent> LogEvents
		{
			[Register("getLogEvents", "()Ljava/util/List;", "GetGetLogEventsHandler")]
			get
			{
				return JavaList<LogEvent>.FromJniHandle(LogRequestInvoker._members.InstanceMethods.InvokeAbstractObjectMethod("getLogEvents.()Ljava/util/List;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000080 RID: 128
		// (get) Token: 0x0600018F RID: 399 RVA: 0x00005258 File Offset: 0x00003458
		public override Integer LogSource
		{
			[Register("getLogSource", "()Ljava/lang/Integer;", "GetGetLogSourceHandler")]
			get
			{
				return Java.Lang.Object.GetObject<Integer>(LogRequestInvoker._members.InstanceMethods.InvokeAbstractObjectMethod("getLogSource.()Ljava/lang/Integer;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000081 RID: 129
		// (get) Token: 0x06000190 RID: 400 RVA: 0x0000528C File Offset: 0x0000348C
		public override string LogSourceName
		{
			[Register("getLogSourceName", "()Ljava/lang/String;", "GetGetLogSourceNameHandler")]
			get
			{
				return JNIEnv.GetString(LogRequestInvoker._members.InstanceMethods.InvokeAbstractObjectMethod("getLogSourceName.()Ljava/lang/String;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000082 RID: 130
		// (get) Token: 0x06000191 RID: 401 RVA: 0x000052C0 File Offset: 0x000034C0
		public override QosTier QosTier
		{
			[Register("getQosTier", "()Lcom/google/android/datatransport/cct/internal/QosTier;", "GetGetQosTierHandler")]
			get
			{
				return Java.Lang.Object.GetObject<QosTier>(LogRequestInvoker._members.InstanceMethods.InvokeAbstractObjectMethod("getQosTier.()Lcom/google/android/datatransport/cct/internal/QosTier;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000083 RID: 131
		// (get) Token: 0x06000192 RID: 402 RVA: 0x000052F2 File Offset: 0x000034F2
		public override long RequestTimeMs
		{
			[Register("getRequestTimeMs", "()J", "GetGetRequestTimeMsHandler")]
			get
			{
				return LogRequestInvoker._members.InstanceMethods.InvokeAbstractInt64Method("getRequestTimeMs.()J", this, null);
			}
		}

		// Token: 0x17000084 RID: 132
		// (get) Token: 0x06000193 RID: 403 RVA: 0x0000530B File Offset: 0x0000350B
		public override long RequestUptimeMs
		{
			[Register("getRequestUptimeMs", "()J", "GetGetRequestUptimeMsHandler")]
			get
			{
				return LogRequestInvoker._members.InstanceMethods.InvokeAbstractInt64Method("getRequestUptimeMs.()J", this, null);
			}
		}

		// Token: 0x04000052 RID: 82
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/google/android/datatransport/cct/internal/LogRequest", typeof(LogRequestInvoker));
	}
}
