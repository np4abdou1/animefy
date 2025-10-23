using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Xamarin.Google.Android.DataTransport.Cct.Internal
{
	// Token: 0x02000019 RID: 25
	[Register("com/google/android/datatransport/cct/internal/LogEvent", DoNotGenerateAcw = true)]
	internal class LogEventInvoker : LogEvent
	{
		// Token: 0x06000139 RID: 313 RVA: 0x000047CC File Offset: 0x000029CC
		public LogEventInvoker(IntPtr handle, JniHandleOwnership transfer) : base(handle, transfer)
		{
		}

		// Token: 0x17000063 RID: 99
		// (get) Token: 0x0600013A RID: 314 RVA: 0x000047D6 File Offset: 0x000029D6
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return LogEventInvoker._members;
			}
		}

		// Token: 0x17000064 RID: 100
		// (get) Token: 0x0600013B RID: 315 RVA: 0x000047DD File Offset: 0x000029DD
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return LogEventInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x17000065 RID: 101
		// (get) Token: 0x0600013C RID: 316 RVA: 0x000047EC File Offset: 0x000029EC
		public override Integer EventCode
		{
			[Register("getEventCode", "()Ljava/lang/Integer;", "GetGetEventCodeHandler")]
			get
			{
				return Java.Lang.Object.GetObject<Integer>(LogEventInvoker._members.InstanceMethods.InvokeAbstractObjectMethod("getEventCode.()Ljava/lang/Integer;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000066 RID: 102
		// (get) Token: 0x0600013D RID: 317 RVA: 0x0000481E File Offset: 0x00002A1E
		public override long EventTimeMs
		{
			[Register("getEventTimeMs", "()J", "GetGetEventTimeMsHandler")]
			get
			{
				return LogEventInvoker._members.InstanceMethods.InvokeAbstractInt64Method("getEventTimeMs.()J", this, null);
			}
		}

		// Token: 0x17000067 RID: 103
		// (get) Token: 0x0600013E RID: 318 RVA: 0x00004837 File Offset: 0x00002A37
		public override long EventUptimeMs
		{
			[Register("getEventUptimeMs", "()J", "GetGetEventUptimeMsHandler")]
			get
			{
				return LogEventInvoker._members.InstanceMethods.InvokeAbstractInt64Method("getEventUptimeMs.()J", this, null);
			}
		}

		// Token: 0x17000068 RID: 104
		// (get) Token: 0x0600013F RID: 319 RVA: 0x00004850 File Offset: 0x00002A50
		public override NetworkConnectionInfo NetworkConnectionInfo
		{
			[Register("getNetworkConnectionInfo", "()Lcom/google/android/datatransport/cct/internal/NetworkConnectionInfo;", "GetGetNetworkConnectionInfoHandler")]
			get
			{
				return Java.Lang.Object.GetObject<NetworkConnectionInfo>(LogEventInvoker._members.InstanceMethods.InvokeAbstractObjectMethod("getNetworkConnectionInfo.()Lcom/google/android/datatransport/cct/internal/NetworkConnectionInfo;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000069 RID: 105
		// (get) Token: 0x06000140 RID: 320 RVA: 0x00004884 File Offset: 0x00002A84
		public override string SourceExtensionJsonProto3
		{
			[Register("getSourceExtensionJsonProto3", "()Ljava/lang/String;", "GetGetSourceExtensionJsonProto3Handler")]
			get
			{
				return JNIEnv.GetString(LogEventInvoker._members.InstanceMethods.InvokeAbstractObjectMethod("getSourceExtensionJsonProto3.()Ljava/lang/String;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x1700006A RID: 106
		// (get) Token: 0x06000141 RID: 321 RVA: 0x000048B6 File Offset: 0x00002AB6
		public override long TimezoneOffsetSeconds
		{
			[Register("getTimezoneOffsetSeconds", "()J", "GetGetTimezoneOffsetSecondsHandler")]
			get
			{
				return LogEventInvoker._members.InstanceMethods.InvokeAbstractInt64Method("getTimezoneOffsetSeconds.()J", this, null);
			}
		}

		// Token: 0x06000142 RID: 322 RVA: 0x000048D0 File Offset: 0x00002AD0
		[Register("getSourceExtension", "()[B", "GetGetSourceExtensionHandler")]
		public override byte[] GetSourceExtension()
		{
			return (byte[])JNIEnv.GetArray(LogEventInvoker._members.InstanceMethods.InvokeAbstractObjectMethod("getSourceExtension.()[B", this, null).Handle, JniHandleOwnership.TransferLocalRef, typeof(byte));
		}

		// Token: 0x0400003F RID: 63
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/google/android/datatransport/cct/internal/LogEvent", typeof(LogEventInvoker));
	}
}
