using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Com.Unity3d.Services.Core.Request
{
	// Token: 0x020000AD RID: 173
	[Register("com/unity3d/services/core/request/ResolveHostError", DoNotGenerateAcw = true)]
	public sealed class ResolveHostError : Java.Lang.Enum
	{
		// Token: 0x170001EC RID: 492
		// (get) Token: 0x06000621 RID: 1569 RVA: 0x0001129C File Offset: 0x0000F49C
		[Register("INVALID_HOST")]
		public static ResolveHostError InvalidHost
		{
			get
			{
				return Java.Lang.Object.GetObject<ResolveHostError>(ResolveHostError._members.StaticFields.GetObjectValue("INVALID_HOST.Lcom/unity3d/services/core/request/ResolveHostError;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x170001ED RID: 493
		// (get) Token: 0x06000622 RID: 1570 RVA: 0x000112CC File Offset: 0x0000F4CC
		[Register("TIMEOUT")]
		public static ResolveHostError Timeout
		{
			get
			{
				return Java.Lang.Object.GetObject<ResolveHostError>(ResolveHostError._members.StaticFields.GetObjectValue("TIMEOUT.Lcom/unity3d/services/core/request/ResolveHostError;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x170001EE RID: 494
		// (get) Token: 0x06000623 RID: 1571 RVA: 0x000112FC File Offset: 0x0000F4FC
		[Register("UNEXPECTED_EXCEPTION")]
		public static ResolveHostError UnexpectedException
		{
			get
			{
				return Java.Lang.Object.GetObject<ResolveHostError>(ResolveHostError._members.StaticFields.GetObjectValue("UNEXPECTED_EXCEPTION.Lcom/unity3d/services/core/request/ResolveHostError;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x170001EF RID: 495
		// (get) Token: 0x06000624 RID: 1572 RVA: 0x0001132C File Offset: 0x0000F52C
		[Register("UNKNOWN_HOST")]
		public static ResolveHostError UnknownHost
		{
			get
			{
				return Java.Lang.Object.GetObject<ResolveHostError>(ResolveHostError._members.StaticFields.GetObjectValue("UNKNOWN_HOST.Lcom/unity3d/services/core/request/ResolveHostError;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x170001F0 RID: 496
		// (get) Token: 0x06000625 RID: 1573 RVA: 0x0001135C File Offset: 0x0000F55C
		internal static IntPtr class_ref
		{
			get
			{
				return ResolveHostError._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170001F1 RID: 497
		// (get) Token: 0x06000626 RID: 1574 RVA: 0x00011380 File Offset: 0x0000F580
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return ResolveHostError._members;
			}
		}

		// Token: 0x170001F2 RID: 498
		// (get) Token: 0x06000627 RID: 1575 RVA: 0x00011388 File Offset: 0x0000F588
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return ResolveHostError._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170001F3 RID: 499
		// (get) Token: 0x06000628 RID: 1576 RVA: 0x000113AC File Offset: 0x0000F5AC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return ResolveHostError._members.ManagedPeerType;
			}
		}

		// Token: 0x06000629 RID: 1577 RVA: 0x0000256C File Offset: 0x0000076C
		internal ResolveHostError(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x0600062A RID: 1578 RVA: 0x000113B8 File Offset: 0x0000F5B8
		[Register("valueOf", "(Ljava/lang/String;)Lcom/unity3d/services/core/request/ResolveHostError;", "")]
		public unsafe static ResolveHostError ValueOf(string name)
		{
			IntPtr intPtr = JNIEnv.NewString(name);
			ResolveHostError @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<ResolveHostError>(ResolveHostError._members.StaticMethods.InvokeObjectMethod("valueOf.(Ljava/lang/String;)Lcom/unity3d/services/core/request/ResolveHostError;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
			return @object;
		}

		// Token: 0x0600062B RID: 1579 RVA: 0x00011424 File Offset: 0x0000F624
		[Register("values", "()[Lcom/unity3d/services/core/request/ResolveHostError;", "")]
		public static ResolveHostError[] Values()
		{
			return (ResolveHostError[])JNIEnv.GetArray(ResolveHostError._members.StaticMethods.InvokeObjectMethod("values.()[Lcom/unity3d/services/core/request/ResolveHostError;", null).Handle, JniHandleOwnership.TransferLocalRef, typeof(ResolveHostError));
		}

		// Token: 0x0400017D RID: 381
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/services/core/request/ResolveHostError", typeof(ResolveHostError));
	}
}
