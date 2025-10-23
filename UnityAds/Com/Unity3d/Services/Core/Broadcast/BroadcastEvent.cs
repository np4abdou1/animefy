using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Com.Unity3d.Services.Core.Broadcast
{
	// Token: 0x02000181 RID: 385
	[Register("com/unity3d/services/core/broadcast/BroadcastEvent", DoNotGenerateAcw = true)]
	public sealed class BroadcastEvent : Java.Lang.Enum
	{
		// Token: 0x17000626 RID: 1574
		// (get) Token: 0x06001155 RID: 4437 RVA: 0x0002E8EC File Offset: 0x0002CAEC
		[Register("ACTION")]
		public static BroadcastEvent Action
		{
			get
			{
				return Java.Lang.Object.GetObject<BroadcastEvent>(BroadcastEvent._members.StaticFields.GetObjectValue("ACTION.Lcom/unity3d/services/core/broadcast/BroadcastEvent;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000627 RID: 1575
		// (get) Token: 0x06001156 RID: 4438 RVA: 0x0002E91C File Offset: 0x0002CB1C
		internal static IntPtr class_ref
		{
			get
			{
				return BroadcastEvent._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000628 RID: 1576
		// (get) Token: 0x06001157 RID: 4439 RVA: 0x0002E940 File Offset: 0x0002CB40
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return BroadcastEvent._members;
			}
		}

		// Token: 0x17000629 RID: 1577
		// (get) Token: 0x06001158 RID: 4440 RVA: 0x0002E948 File Offset: 0x0002CB48
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return BroadcastEvent._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700062A RID: 1578
		// (get) Token: 0x06001159 RID: 4441 RVA: 0x0002E96C File Offset: 0x0002CB6C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return BroadcastEvent._members.ManagedPeerType;
			}
		}

		// Token: 0x0600115A RID: 4442 RVA: 0x0000256C File Offset: 0x0000076C
		internal BroadcastEvent(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x0600115B RID: 4443 RVA: 0x0002E978 File Offset: 0x0002CB78
		[Register("valueOf", "(Ljava/lang/String;)Lcom/unity3d/services/core/broadcast/BroadcastEvent;", "")]
		public unsafe static BroadcastEvent ValueOf(string name)
		{
			IntPtr intPtr = JNIEnv.NewString(name);
			BroadcastEvent @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<BroadcastEvent>(BroadcastEvent._members.StaticMethods.InvokeObjectMethod("valueOf.(Ljava/lang/String;)Lcom/unity3d/services/core/broadcast/BroadcastEvent;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
			return @object;
		}

		// Token: 0x0600115C RID: 4444 RVA: 0x0002E9E4 File Offset: 0x0002CBE4
		[Register("values", "()[Lcom/unity3d/services/core/broadcast/BroadcastEvent;", "")]
		public static BroadcastEvent[] Values()
		{
			return (BroadcastEvent[])JNIEnv.GetArray(BroadcastEvent._members.StaticMethods.InvokeObjectMethod("values.()[Lcom/unity3d/services/core/broadcast/BroadcastEvent;", null).Handle, JniHandleOwnership.TransferLocalRef, typeof(BroadcastEvent));
		}

		// Token: 0x04000443 RID: 1091
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/services/core/broadcast/BroadcastEvent", typeof(BroadcastEvent));
	}
}
