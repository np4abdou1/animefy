using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Com.Applovin.Mediation
{
	// Token: 0x020000BF RID: 191
	[Register("com/applovin/mediation/MaxNetworkResponseInfo$AdLoadState", DoNotGenerateAcw = true)]
	public sealed class MaxNetworkResponseInfoAdLoadState : Java.Lang.Enum
	{
		// Token: 0x17000205 RID: 517
		// (get) Token: 0x06000681 RID: 1665 RVA: 0x000109F4 File Offset: 0x0000EBF4
		[Register("AD_LOADED")]
		public static MaxNetworkResponseInfoAdLoadState AdLoaded
		{
			get
			{
				return Java.Lang.Object.GetObject<MaxNetworkResponseInfoAdLoadState>(MaxNetworkResponseInfoAdLoadState._members.StaticFields.GetObjectValue("AD_LOADED.Lcom/applovin/mediation/MaxNetworkResponseInfo$AdLoadState;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000206 RID: 518
		// (get) Token: 0x06000682 RID: 1666 RVA: 0x00010A24 File Offset: 0x0000EC24
		[Register("AD_LOAD_NOT_ATTEMPTED")]
		public static MaxNetworkResponseInfoAdLoadState AdLoadNotAttempted
		{
			get
			{
				return Java.Lang.Object.GetObject<MaxNetworkResponseInfoAdLoadState>(MaxNetworkResponseInfoAdLoadState._members.StaticFields.GetObjectValue("AD_LOAD_NOT_ATTEMPTED.Lcom/applovin/mediation/MaxNetworkResponseInfo$AdLoadState;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000207 RID: 519
		// (get) Token: 0x06000683 RID: 1667 RVA: 0x00010A54 File Offset: 0x0000EC54
		[Register("FAILED_TO_LOAD")]
		public static MaxNetworkResponseInfoAdLoadState FailedToLoad
		{
			get
			{
				return Java.Lang.Object.GetObject<MaxNetworkResponseInfoAdLoadState>(MaxNetworkResponseInfoAdLoadState._members.StaticFields.GetObjectValue("FAILED_TO_LOAD.Lcom/applovin/mediation/MaxNetworkResponseInfo$AdLoadState;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000208 RID: 520
		// (get) Token: 0x06000684 RID: 1668 RVA: 0x00010A84 File Offset: 0x0000EC84
		internal static IntPtr class_ref
		{
			get
			{
				return MaxNetworkResponseInfoAdLoadState._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000209 RID: 521
		// (get) Token: 0x06000685 RID: 1669 RVA: 0x00010AA8 File Offset: 0x0000ECA8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return MaxNetworkResponseInfoAdLoadState._members;
			}
		}

		// Token: 0x1700020A RID: 522
		// (get) Token: 0x06000686 RID: 1670 RVA: 0x00010AB0 File Offset: 0x0000ECB0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return MaxNetworkResponseInfoAdLoadState._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700020B RID: 523
		// (get) Token: 0x06000687 RID: 1671 RVA: 0x00010AD4 File Offset: 0x0000ECD4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return MaxNetworkResponseInfoAdLoadState._members.ManagedPeerType;
			}
		}

		// Token: 0x06000688 RID: 1672 RVA: 0x000048B4 File Offset: 0x00002AB4
		internal MaxNetworkResponseInfoAdLoadState(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000689 RID: 1673 RVA: 0x00010AE0 File Offset: 0x0000ECE0
		[Register("valueOf", "(Ljava/lang/String;)Lcom/applovin/mediation/MaxNetworkResponseInfo$AdLoadState;", "")]
		public unsafe static MaxNetworkResponseInfoAdLoadState ValueOf(string p0)
		{
			IntPtr intPtr = JNIEnv.NewString(p0);
			MaxNetworkResponseInfoAdLoadState @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<MaxNetworkResponseInfoAdLoadState>(MaxNetworkResponseInfoAdLoadState._members.StaticMethods.InvokeObjectMethod("valueOf.(Ljava/lang/String;)Lcom/applovin/mediation/MaxNetworkResponseInfo$AdLoadState;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
			return @object;
		}

		// Token: 0x0600068A RID: 1674 RVA: 0x00010B4C File Offset: 0x0000ED4C
		[Register("values", "()[Lcom/applovin/mediation/MaxNetworkResponseInfo$AdLoadState;", "")]
		public static MaxNetworkResponseInfoAdLoadState[] Values()
		{
			return (MaxNetworkResponseInfoAdLoadState[])JNIEnv.GetArray(MaxNetworkResponseInfoAdLoadState._members.StaticMethods.InvokeObjectMethod("values.()[Lcom/applovin/mediation/MaxNetworkResponseInfo$AdLoadState;", null).Handle, JniHandleOwnership.TransferLocalRef, typeof(MaxNetworkResponseInfoAdLoadState));
		}

		// Token: 0x0400022E RID: 558
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/applovin/mediation/MaxNetworkResponseInfo$AdLoadState", typeof(MaxNetworkResponseInfoAdLoadState));
	}
}
