using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Com.Unity3d.Services.Core.Request
{
	// Token: 0x020000AE RID: 174
	[Register("com/unity3d/services/core/request/ResolveHostEvent", DoNotGenerateAcw = true)]
	public sealed class ResolveHostEvent : Java.Lang.Enum
	{
		// Token: 0x170001F4 RID: 500
		// (get) Token: 0x0600062D RID: 1581 RVA: 0x00011480 File Offset: 0x0000F680
		[Register("COMPLETE")]
		public static ResolveHostEvent Complete
		{
			get
			{
				return Java.Lang.Object.GetObject<ResolveHostEvent>(ResolveHostEvent._members.StaticFields.GetObjectValue("COMPLETE.Lcom/unity3d/services/core/request/ResolveHostEvent;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x170001F5 RID: 501
		// (get) Token: 0x0600062E RID: 1582 RVA: 0x000114B0 File Offset: 0x0000F6B0
		[Register("FAILED")]
		public static ResolveHostEvent Failed
		{
			get
			{
				return Java.Lang.Object.GetObject<ResolveHostEvent>(ResolveHostEvent._members.StaticFields.GetObjectValue("FAILED.Lcom/unity3d/services/core/request/ResolveHostEvent;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x170001F6 RID: 502
		// (get) Token: 0x0600062F RID: 1583 RVA: 0x000114E0 File Offset: 0x0000F6E0
		internal static IntPtr class_ref
		{
			get
			{
				return ResolveHostEvent._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170001F7 RID: 503
		// (get) Token: 0x06000630 RID: 1584 RVA: 0x00011504 File Offset: 0x0000F704
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return ResolveHostEvent._members;
			}
		}

		// Token: 0x170001F8 RID: 504
		// (get) Token: 0x06000631 RID: 1585 RVA: 0x0001150C File Offset: 0x0000F70C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return ResolveHostEvent._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170001F9 RID: 505
		// (get) Token: 0x06000632 RID: 1586 RVA: 0x00011530 File Offset: 0x0000F730
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return ResolveHostEvent._members.ManagedPeerType;
			}
		}

		// Token: 0x06000633 RID: 1587 RVA: 0x0000256C File Offset: 0x0000076C
		internal ResolveHostEvent(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000634 RID: 1588 RVA: 0x0001153C File Offset: 0x0000F73C
		[Register("valueOf", "(Ljava/lang/String;)Lcom/unity3d/services/core/request/ResolveHostEvent;", "")]
		public unsafe static ResolveHostEvent ValueOf(string name)
		{
			IntPtr intPtr = JNIEnv.NewString(name);
			ResolveHostEvent @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<ResolveHostEvent>(ResolveHostEvent._members.StaticMethods.InvokeObjectMethod("valueOf.(Ljava/lang/String;)Lcom/unity3d/services/core/request/ResolveHostEvent;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
			return @object;
		}

		// Token: 0x06000635 RID: 1589 RVA: 0x000115A8 File Offset: 0x0000F7A8
		[Register("values", "()[Lcom/unity3d/services/core/request/ResolveHostEvent;", "")]
		public static ResolveHostEvent[] Values()
		{
			return (ResolveHostEvent[])JNIEnv.GetArray(ResolveHostEvent._members.StaticMethods.InvokeObjectMethod("values.()[Lcom/unity3d/services/core/request/ResolveHostEvent;", null).Handle, JniHandleOwnership.TransferLocalRef, typeof(ResolveHostEvent));
		}

		// Token: 0x0400017E RID: 382
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/services/core/request/ResolveHostEvent", typeof(ResolveHostEvent));
	}
}
