using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Com.Unity3d.Services.Core.Request.Metrics
{
	// Token: 0x020000B9 RID: 185
	[Register("com/unity3d/services/core/request/metrics/AdOperationError", DoNotGenerateAcw = true)]
	public sealed class AdOperationError : Java.Lang.Enum
	{
		// Token: 0x17000221 RID: 545
		// (get) Token: 0x060006C2 RID: 1730 RVA: 0x00012FC8 File Offset: 0x000111C8
		[Register("already_showing")]
		public static AdOperationError AlreadyShowing
		{
			get
			{
				return Java.Lang.Object.GetObject<AdOperationError>(AdOperationError._members.StaticFields.GetObjectValue("already_showing.Lcom/unity3d/services/core/request/metrics/AdOperationError;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000222 RID: 546
		// (get) Token: 0x060006C3 RID: 1731 RVA: 0x00012FF8 File Offset: 0x000111F8
		[Register("callback_error")]
		public static AdOperationError CallbackError
		{
			get
			{
				return Java.Lang.Object.GetObject<AdOperationError>(AdOperationError._members.StaticFields.GetObjectValue("callback_error.Lcom/unity3d/services/core/request/metrics/AdOperationError;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000223 RID: 547
		// (get) Token: 0x060006C4 RID: 1732 RVA: 0x00013028 File Offset: 0x00011228
		[Register("callback_timeout")]
		public static AdOperationError CallbackTimeout
		{
			get
			{
				return Java.Lang.Object.GetObject<AdOperationError>(AdOperationError._members.StaticFields.GetObjectValue("callback_timeout.Lcom/unity3d/services/core/request/metrics/AdOperationError;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000224 RID: 548
		// (get) Token: 0x060006C5 RID: 1733 RVA: 0x00013058 File Offset: 0x00011258
		[Register("init_failed")]
		public static AdOperationError InitFailed
		{
			get
			{
				return Java.Lang.Object.GetObject<AdOperationError>(AdOperationError._members.StaticFields.GetObjectValue("init_failed.Lcom/unity3d/services/core/request/metrics/AdOperationError;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000225 RID: 549
		// (get) Token: 0x060006C6 RID: 1734 RVA: 0x00013088 File Offset: 0x00011288
		[Register("internal")]
		public static AdOperationError Internal
		{
			get
			{
				return Java.Lang.Object.GetObject<AdOperationError>(AdOperationError._members.StaticFields.GetObjectValue("internal.Lcom/unity3d/services/core/request/metrics/AdOperationError;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000226 RID: 550
		// (get) Token: 0x060006C7 RID: 1735 RVA: 0x000130B8 File Offset: 0x000112B8
		[Register("invalid")]
		public static AdOperationError Invalid
		{
			get
			{
				return Java.Lang.Object.GetObject<AdOperationError>(AdOperationError._members.StaticFields.GetObjectValue("invalid.Lcom/unity3d/services/core/request/metrics/AdOperationError;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000227 RID: 551
		// (get) Token: 0x060006C8 RID: 1736 RVA: 0x000130E8 File Offset: 0x000112E8
		[Register("not_ready")]
		public static AdOperationError NotReady
		{
			get
			{
				return Java.Lang.Object.GetObject<AdOperationError>(AdOperationError._members.StaticFields.GetObjectValue("not_ready.Lcom/unity3d/services/core/request/metrics/AdOperationError;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000228 RID: 552
		// (get) Token: 0x060006C9 RID: 1737 RVA: 0x00013118 File Offset: 0x00011318
		[Register("no_connection")]
		public static AdOperationError NoConnection
		{
			get
			{
				return Java.Lang.Object.GetObject<AdOperationError>(AdOperationError._members.StaticFields.GetObjectValue("no_connection.Lcom/unity3d/services/core/request/metrics/AdOperationError;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000229 RID: 553
		// (get) Token: 0x060006CA RID: 1738 RVA: 0x00013148 File Offset: 0x00011348
		[Register("no_fill")]
		public static AdOperationError NoFill
		{
			get
			{
				return Java.Lang.Object.GetObject<AdOperationError>(AdOperationError._members.StaticFields.GetObjectValue("no_fill.Lcom/unity3d/services/core/request/metrics/AdOperationError;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x1700022A RID: 554
		// (get) Token: 0x060006CB RID: 1739 RVA: 0x00013178 File Offset: 0x00011378
		[Register("player")]
		public static AdOperationError Player
		{
			get
			{
				return Java.Lang.Object.GetObject<AdOperationError>(AdOperationError._members.StaticFields.GetObjectValue("player.Lcom/unity3d/services/core/request/metrics/AdOperationError;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x1700022B RID: 555
		// (get) Token: 0x060006CC RID: 1740 RVA: 0x000131A8 File Offset: 0x000113A8
		[Register("timeout")]
		public static AdOperationError Timeout
		{
			get
			{
				return Java.Lang.Object.GetObject<AdOperationError>(AdOperationError._members.StaticFields.GetObjectValue("timeout.Lcom/unity3d/services/core/request/metrics/AdOperationError;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x1700022C RID: 556
		// (get) Token: 0x060006CD RID: 1741 RVA: 0x000131D8 File Offset: 0x000113D8
		internal static IntPtr class_ref
		{
			get
			{
				return AdOperationError._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700022D RID: 557
		// (get) Token: 0x060006CE RID: 1742 RVA: 0x000131FC File Offset: 0x000113FC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return AdOperationError._members;
			}
		}

		// Token: 0x1700022E RID: 558
		// (get) Token: 0x060006CF RID: 1743 RVA: 0x00013204 File Offset: 0x00011404
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return AdOperationError._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700022F RID: 559
		// (get) Token: 0x060006D0 RID: 1744 RVA: 0x00013228 File Offset: 0x00011428
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return AdOperationError._members.ManagedPeerType;
			}
		}

		// Token: 0x060006D1 RID: 1745 RVA: 0x0000256C File Offset: 0x0000076C
		internal AdOperationError(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x060006D2 RID: 1746 RVA: 0x00013234 File Offset: 0x00011434
		[Register("valueOf", "(Ljava/lang/String;)Lcom/unity3d/services/core/request/metrics/AdOperationError;", "")]
		public unsafe static AdOperationError ValueOf(string name)
		{
			IntPtr intPtr = JNIEnv.NewString(name);
			AdOperationError @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<AdOperationError>(AdOperationError._members.StaticMethods.InvokeObjectMethod("valueOf.(Ljava/lang/String;)Lcom/unity3d/services/core/request/metrics/AdOperationError;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
			return @object;
		}

		// Token: 0x060006D3 RID: 1747 RVA: 0x000132A0 File Offset: 0x000114A0
		[Register("values", "()[Lcom/unity3d/services/core/request/metrics/AdOperationError;", "")]
		public static AdOperationError[] Values()
		{
			return (AdOperationError[])JNIEnv.GetArray(AdOperationError._members.StaticMethods.InvokeObjectMethod("values.()[Lcom/unity3d/services/core/request/metrics/AdOperationError;", null).Handle, JniHandleOwnership.TransferLocalRef, typeof(AdOperationError));
		}

		// Token: 0x040001A1 RID: 417
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/services/core/request/metrics/AdOperationError", typeof(AdOperationError));
	}
}
