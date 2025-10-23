using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Com.Unity3d.Services.Core.Connectivity
{
	// Token: 0x02000148 RID: 328
	[Register("com/unity3d/services/core/connectivity/ConnectivityEvent", DoNotGenerateAcw = true)]
	public sealed class ConnectivityEvent : Java.Lang.Enum
	{
		// Token: 0x170004B9 RID: 1209
		// (get) Token: 0x06000D22 RID: 3362 RVA: 0x00024E60 File Offset: 0x00023060
		[Register("CONNECTED")]
		public static ConnectivityEvent Connected
		{
			get
			{
				return Java.Lang.Object.GetObject<ConnectivityEvent>(ConnectivityEvent._members.StaticFields.GetObjectValue("CONNECTED.Lcom/unity3d/services/core/connectivity/ConnectivityEvent;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x170004BA RID: 1210
		// (get) Token: 0x06000D23 RID: 3363 RVA: 0x00024E90 File Offset: 0x00023090
		[Register("DISCONNECTED")]
		public static ConnectivityEvent Disconnected
		{
			get
			{
				return Java.Lang.Object.GetObject<ConnectivityEvent>(ConnectivityEvent._members.StaticFields.GetObjectValue("DISCONNECTED.Lcom/unity3d/services/core/connectivity/ConnectivityEvent;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x170004BB RID: 1211
		// (get) Token: 0x06000D24 RID: 3364 RVA: 0x00024EC0 File Offset: 0x000230C0
		[Register("NETWORK_CHANGE")]
		public static ConnectivityEvent NetworkChange
		{
			get
			{
				return Java.Lang.Object.GetObject<ConnectivityEvent>(ConnectivityEvent._members.StaticFields.GetObjectValue("NETWORK_CHANGE.Lcom/unity3d/services/core/connectivity/ConnectivityEvent;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x170004BC RID: 1212
		// (get) Token: 0x06000D25 RID: 3365 RVA: 0x00024EF0 File Offset: 0x000230F0
		internal static IntPtr class_ref
		{
			get
			{
				return ConnectivityEvent._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170004BD RID: 1213
		// (get) Token: 0x06000D26 RID: 3366 RVA: 0x00024F14 File Offset: 0x00023114
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return ConnectivityEvent._members;
			}
		}

		// Token: 0x170004BE RID: 1214
		// (get) Token: 0x06000D27 RID: 3367 RVA: 0x00024F1C File Offset: 0x0002311C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return ConnectivityEvent._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170004BF RID: 1215
		// (get) Token: 0x06000D28 RID: 3368 RVA: 0x00024F40 File Offset: 0x00023140
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return ConnectivityEvent._members.ManagedPeerType;
			}
		}

		// Token: 0x06000D29 RID: 3369 RVA: 0x0000256C File Offset: 0x0000076C
		internal ConnectivityEvent(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000D2A RID: 3370 RVA: 0x00024F4C File Offset: 0x0002314C
		[Register("valueOf", "(Ljava/lang/String;)Lcom/unity3d/services/core/connectivity/ConnectivityEvent;", "")]
		public unsafe static ConnectivityEvent ValueOf(string name)
		{
			IntPtr intPtr = JNIEnv.NewString(name);
			ConnectivityEvent @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<ConnectivityEvent>(ConnectivityEvent._members.StaticMethods.InvokeObjectMethod("valueOf.(Ljava/lang/String;)Lcom/unity3d/services/core/connectivity/ConnectivityEvent;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
			return @object;
		}

		// Token: 0x06000D2B RID: 3371 RVA: 0x00024FB8 File Offset: 0x000231B8
		[Register("values", "()[Lcom/unity3d/services/core/connectivity/ConnectivityEvent;", "")]
		public static ConnectivityEvent[] Values()
		{
			return (ConnectivityEvent[])JNIEnv.GetArray(ConnectivityEvent._members.StaticMethods.InvokeObjectMethod("values.()[Lcom/unity3d/services/core/connectivity/ConnectivityEvent;", null).Handle, JniHandleOwnership.TransferLocalRef, typeof(ConnectivityEvent));
		}

		// Token: 0x04000307 RID: 775
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/services/core/connectivity/ConnectivityEvent", typeof(ConnectivityEvent));
	}
}
