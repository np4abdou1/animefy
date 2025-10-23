using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Com.Unity3d.Services.Core.Broadcast
{
	// Token: 0x02000180 RID: 384
	[Register("com/unity3d/services/core/broadcast/BroadcastError", DoNotGenerateAcw = true)]
	public sealed class BroadcastError : Java.Lang.Enum
	{
		// Token: 0x17000621 RID: 1569
		// (get) Token: 0x0600114C RID: 4428 RVA: 0x0002E798 File Offset: 0x0002C998
		[Register("JSON_ERROR")]
		public static BroadcastError JsonError
		{
			get
			{
				return Java.Lang.Object.GetObject<BroadcastError>(BroadcastError._members.StaticFields.GetObjectValue("JSON_ERROR.Lcom/unity3d/services/core/broadcast/BroadcastError;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000622 RID: 1570
		// (get) Token: 0x0600114D RID: 4429 RVA: 0x0002E7C8 File Offset: 0x0002C9C8
		internal static IntPtr class_ref
		{
			get
			{
				return BroadcastError._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000623 RID: 1571
		// (get) Token: 0x0600114E RID: 4430 RVA: 0x0002E7EC File Offset: 0x0002C9EC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return BroadcastError._members;
			}
		}

		// Token: 0x17000624 RID: 1572
		// (get) Token: 0x0600114F RID: 4431 RVA: 0x0002E7F4 File Offset: 0x0002C9F4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return BroadcastError._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000625 RID: 1573
		// (get) Token: 0x06001150 RID: 4432 RVA: 0x0002E818 File Offset: 0x0002CA18
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return BroadcastError._members.ManagedPeerType;
			}
		}

		// Token: 0x06001151 RID: 4433 RVA: 0x0000256C File Offset: 0x0000076C
		internal BroadcastError(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06001152 RID: 4434 RVA: 0x0002E824 File Offset: 0x0002CA24
		[Register("valueOf", "(Ljava/lang/String;)Lcom/unity3d/services/core/broadcast/BroadcastError;", "")]
		public unsafe static BroadcastError ValueOf(string name)
		{
			IntPtr intPtr = JNIEnv.NewString(name);
			BroadcastError @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<BroadcastError>(BroadcastError._members.StaticMethods.InvokeObjectMethod("valueOf.(Ljava/lang/String;)Lcom/unity3d/services/core/broadcast/BroadcastError;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
			return @object;
		}

		// Token: 0x06001153 RID: 4435 RVA: 0x0002E890 File Offset: 0x0002CA90
		[Register("values", "()[Lcom/unity3d/services/core/broadcast/BroadcastError;", "")]
		public static BroadcastError[] Values()
		{
			return (BroadcastError[])JNIEnv.GetArray(BroadcastError._members.StaticMethods.InvokeObjectMethod("values.()[Lcom/unity3d/services/core/broadcast/BroadcastError;", null).Handle, JniHandleOwnership.TransferLocalRef, typeof(BroadcastError));
		}

		// Token: 0x04000442 RID: 1090
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/services/core/broadcast/BroadcastError", typeof(BroadcastError));
	}
}
