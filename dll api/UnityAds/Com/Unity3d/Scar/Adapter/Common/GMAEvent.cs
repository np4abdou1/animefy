using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Com.Unity3d.Scar.Adapter.Common
{
	// Token: 0x02000298 RID: 664
	[Register("com/unity3d/scar/adapter/common/GMAEvent", DoNotGenerateAcw = true)]
	public sealed class GMAEvent : Java.Lang.Enum
	{
		// Token: 0x17000E76 RID: 3702
		// (get) Token: 0x060025EE RID: 9710 RVA: 0x00061B7C File Offset: 0x0005FD7C
		[Register("AD_CLICKED")]
		public static GMAEvent AdClicked
		{
			get
			{
				return Java.Lang.Object.GetObject<GMAEvent>(GMAEvent._members.StaticFields.GetObjectValue("AD_CLICKED.Lcom/unity3d/scar/adapter/common/GMAEvent;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000E77 RID: 3703
		// (get) Token: 0x060025EF RID: 9711 RVA: 0x00061BAC File Offset: 0x0005FDAC
		[Register("AD_CLOSED")]
		public static GMAEvent AdClosed
		{
			get
			{
				return Java.Lang.Object.GetObject<GMAEvent>(GMAEvent._members.StaticFields.GetObjectValue("AD_CLOSED.Lcom/unity3d/scar/adapter/common/GMAEvent;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000E78 RID: 3704
		// (get) Token: 0x060025F0 RID: 9712 RVA: 0x00061BDC File Offset: 0x0005FDDC
		[Register("AD_EARNED_REWARD")]
		public static GMAEvent AdEarnedReward
		{
			get
			{
				return Java.Lang.Object.GetObject<GMAEvent>(GMAEvent._members.StaticFields.GetObjectValue("AD_EARNED_REWARD.Lcom/unity3d/scar/adapter/common/GMAEvent;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000E79 RID: 3705
		// (get) Token: 0x060025F1 RID: 9713 RVA: 0x00061C0C File Offset: 0x0005FE0C
		[Register("AD_LEFT_APPLICATION")]
		public static GMAEvent AdLeftApplication
		{
			get
			{
				return Java.Lang.Object.GetObject<GMAEvent>(GMAEvent._members.StaticFields.GetObjectValue("AD_LEFT_APPLICATION.Lcom/unity3d/scar/adapter/common/GMAEvent;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000E7A RID: 3706
		// (get) Token: 0x060025F2 RID: 9714 RVA: 0x00061C3C File Offset: 0x0005FE3C
		[Register("AD_LOADED")]
		public static GMAEvent AdLoaded
		{
			get
			{
				return Java.Lang.Object.GetObject<GMAEvent>(GMAEvent._members.StaticFields.GetObjectValue("AD_LOADED.Lcom/unity3d/scar/adapter/common/GMAEvent;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000E7B RID: 3707
		// (get) Token: 0x060025F3 RID: 9715 RVA: 0x00061C6C File Offset: 0x0005FE6C
		[Register("AD_NOT_LOADED_ERROR")]
		public static GMAEvent AdNotLoadedError
		{
			get
			{
				return Java.Lang.Object.GetObject<GMAEvent>(GMAEvent._members.StaticFields.GetObjectValue("AD_NOT_LOADED_ERROR.Lcom/unity3d/scar/adapter/common/GMAEvent;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000E7C RID: 3708
		// (get) Token: 0x060025F4 RID: 9716 RVA: 0x00061C9C File Offset: 0x0005FE9C
		[Register("AD_SKIPPED")]
		public static GMAEvent AdSkipped
		{
			get
			{
				return Java.Lang.Object.GetObject<GMAEvent>(GMAEvent._members.StaticFields.GetObjectValue("AD_SKIPPED.Lcom/unity3d/scar/adapter/common/GMAEvent;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000E7D RID: 3709
		// (get) Token: 0x060025F5 RID: 9717 RVA: 0x00061CCC File Offset: 0x0005FECC
		[Register("AD_STARTED")]
		public static GMAEvent AdStarted
		{
			get
			{
				return Java.Lang.Object.GetObject<GMAEvent>(GMAEvent._members.StaticFields.GetObjectValue("AD_STARTED.Lcom/unity3d/scar/adapter/common/GMAEvent;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000E7E RID: 3710
		// (get) Token: 0x060025F6 RID: 9718 RVA: 0x00061CFC File Offset: 0x0005FEFC
		[Register("ALREADY_INITIALIZED")]
		public static GMAEvent AlreadyInitialized
		{
			get
			{
				return Java.Lang.Object.GetObject<GMAEvent>(GMAEvent._members.StaticFields.GetObjectValue("ALREADY_INITIALIZED.Lcom/unity3d/scar/adapter/common/GMAEvent;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000E7F RID: 3711
		// (get) Token: 0x060025F7 RID: 9719 RVA: 0x00061D2C File Offset: 0x0005FF2C
		[Register("FIRST_QUARTILE")]
		public static GMAEvent FirstQuartile
		{
			get
			{
				return Java.Lang.Object.GetObject<GMAEvent>(GMAEvent._members.StaticFields.GetObjectValue("FIRST_QUARTILE.Lcom/unity3d/scar/adapter/common/GMAEvent;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000E80 RID: 3712
		// (get) Token: 0x060025F8 RID: 9720 RVA: 0x00061D5C File Offset: 0x0005FF5C
		[Register("INIT_ERROR")]
		public static GMAEvent InitError
		{
			get
			{
				return Java.Lang.Object.GetObject<GMAEvent>(GMAEvent._members.StaticFields.GetObjectValue("INIT_ERROR.Lcom/unity3d/scar/adapter/common/GMAEvent;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000E81 RID: 3713
		// (get) Token: 0x060025F9 RID: 9721 RVA: 0x00061D8C File Offset: 0x0005FF8C
		[Register("INIT_SUCCESS")]
		public static GMAEvent InitSuccess
		{
			get
			{
				return Java.Lang.Object.GetObject<GMAEvent>(GMAEvent._members.StaticFields.GetObjectValue("INIT_SUCCESS.Lcom/unity3d/scar/adapter/common/GMAEvent;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000E82 RID: 3714
		// (get) Token: 0x060025FA RID: 9722 RVA: 0x00061DBC File Offset: 0x0005FFBC
		[Register("INTERNAL_LOAD_ERROR")]
		public static GMAEvent InternalLoadError
		{
			get
			{
				return Java.Lang.Object.GetObject<GMAEvent>(GMAEvent._members.StaticFields.GetObjectValue("INTERNAL_LOAD_ERROR.Lcom/unity3d/scar/adapter/common/GMAEvent;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000E83 RID: 3715
		// (get) Token: 0x060025FB RID: 9723 RVA: 0x00061DEC File Offset: 0x0005FFEC
		[Register("INTERNAL_SHOW_ERROR")]
		public static GMAEvent InternalShowError
		{
			get
			{
				return Java.Lang.Object.GetObject<GMAEvent>(GMAEvent._members.StaticFields.GetObjectValue("INTERNAL_SHOW_ERROR.Lcom/unity3d/scar/adapter/common/GMAEvent;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000E84 RID: 3716
		// (get) Token: 0x060025FC RID: 9724 RVA: 0x00061E1C File Offset: 0x0006001C
		[Register("INTERNAL_SIGNALS_ERROR")]
		public static GMAEvent InternalSignalsError
		{
			get
			{
				return Java.Lang.Object.GetObject<GMAEvent>(GMAEvent._members.StaticFields.GetObjectValue("INTERNAL_SIGNALS_ERROR.Lcom/unity3d/scar/adapter/common/GMAEvent;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000E85 RID: 3717
		// (get) Token: 0x060025FD RID: 9725 RVA: 0x00061E4C File Offset: 0x0006004C
		[Register("INTERSTITIAL_IMPRESSION_RECORDED")]
		public static GMAEvent InterstitialImpressionRecorded
		{
			get
			{
				return Java.Lang.Object.GetObject<GMAEvent>(GMAEvent._members.StaticFields.GetObjectValue("INTERSTITIAL_IMPRESSION_RECORDED.Lcom/unity3d/scar/adapter/common/GMAEvent;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000E86 RID: 3718
		// (get) Token: 0x060025FE RID: 9726 RVA: 0x00061E7C File Offset: 0x0006007C
		[Register("INTERSTITIAL_SHOW_ERROR")]
		public static GMAEvent InterstitialShowError
		{
			get
			{
				return Java.Lang.Object.GetObject<GMAEvent>(GMAEvent._members.StaticFields.GetObjectValue("INTERSTITIAL_SHOW_ERROR.Lcom/unity3d/scar/adapter/common/GMAEvent;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000E87 RID: 3719
		// (get) Token: 0x060025FF RID: 9727 RVA: 0x00061EAC File Offset: 0x000600AC
		[Register("LAST_QUARTILE")]
		public static GMAEvent LastQuartile
		{
			get
			{
				return Java.Lang.Object.GetObject<GMAEvent>(GMAEvent._members.StaticFields.GetObjectValue("LAST_QUARTILE.Lcom/unity3d/scar/adapter/common/GMAEvent;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000E88 RID: 3720
		// (get) Token: 0x06002600 RID: 9728 RVA: 0x00061EDC File Offset: 0x000600DC
		[Register("LOAD_ERROR")]
		public static GMAEvent LoadError
		{
			get
			{
				return Java.Lang.Object.GetObject<GMAEvent>(GMAEvent._members.StaticFields.GetObjectValue("LOAD_ERROR.Lcom/unity3d/scar/adapter/common/GMAEvent;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000E89 RID: 3721
		// (get) Token: 0x06002601 RID: 9729 RVA: 0x00061F0C File Offset: 0x0006010C
		[Register("METHOD_ERROR")]
		public static GMAEvent MethodError
		{
			get
			{
				return Java.Lang.Object.GetObject<GMAEvent>(GMAEvent._members.StaticFields.GetObjectValue("METHOD_ERROR.Lcom/unity3d/scar/adapter/common/GMAEvent;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000E8A RID: 3722
		// (get) Token: 0x06002602 RID: 9730 RVA: 0x00061F3C File Offset: 0x0006013C
		[Register("MIDPOINT")]
		public static GMAEvent Midpoint
		{
			get
			{
				return Java.Lang.Object.GetObject<GMAEvent>(GMAEvent._members.StaticFields.GetObjectValue("MIDPOINT.Lcom/unity3d/scar/adapter/common/GMAEvent;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000E8B RID: 3723
		// (get) Token: 0x06002603 RID: 9731 RVA: 0x00061F6C File Offset: 0x0006016C
		[Register("NO_AD_ERROR")]
		public static GMAEvent NoAdError
		{
			get
			{
				return Java.Lang.Object.GetObject<GMAEvent>(GMAEvent._members.StaticFields.GetObjectValue("NO_AD_ERROR.Lcom/unity3d/scar/adapter/common/GMAEvent;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000E8C RID: 3724
		// (get) Token: 0x06002604 RID: 9732 RVA: 0x00061F9C File Offset: 0x0006019C
		[Register("QUERY_NOT_FOUND_ERROR")]
		public static GMAEvent QueryNotFoundError
		{
			get
			{
				return Java.Lang.Object.GetObject<GMAEvent>(GMAEvent._members.StaticFields.GetObjectValue("QUERY_NOT_FOUND_ERROR.Lcom/unity3d/scar/adapter/common/GMAEvent;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000E8D RID: 3725
		// (get) Token: 0x06002605 RID: 9733 RVA: 0x00061FCC File Offset: 0x000601CC
		[Register("REWARDED_IMPRESSION_RECORDED")]
		public static GMAEvent RewardedImpressionRecorded
		{
			get
			{
				return Java.Lang.Object.GetObject<GMAEvent>(GMAEvent._members.StaticFields.GetObjectValue("REWARDED_IMPRESSION_RECORDED.Lcom/unity3d/scar/adapter/common/GMAEvent;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000E8E RID: 3726
		// (get) Token: 0x06002606 RID: 9734 RVA: 0x00061FFC File Offset: 0x000601FC
		[Register("REWARDED_SHOW_ERROR")]
		public static GMAEvent RewardedShowError
		{
			get
			{
				return Java.Lang.Object.GetObject<GMAEvent>(GMAEvent._members.StaticFields.GetObjectValue("REWARDED_SHOW_ERROR.Lcom/unity3d/scar/adapter/common/GMAEvent;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000E8F RID: 3727
		// (get) Token: 0x06002607 RID: 9735 RVA: 0x0006202C File Offset: 0x0006022C
		[Register("SCAR_NOT_PRESENT")]
		public static GMAEvent ScarNotPresent
		{
			get
			{
				return Java.Lang.Object.GetObject<GMAEvent>(GMAEvent._members.StaticFields.GetObjectValue("SCAR_NOT_PRESENT.Lcom/unity3d/scar/adapter/common/GMAEvent;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000E90 RID: 3728
		// (get) Token: 0x06002608 RID: 9736 RVA: 0x0006205C File Offset: 0x0006025C
		[Register("SCAR_PRESENT")]
		public static GMAEvent ScarPresent
		{
			get
			{
				return Java.Lang.Object.GetObject<GMAEvent>(GMAEvent._members.StaticFields.GetObjectValue("SCAR_PRESENT.Lcom/unity3d/scar/adapter/common/GMAEvent;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000E91 RID: 3729
		// (get) Token: 0x06002609 RID: 9737 RVA: 0x0006208C File Offset: 0x0006028C
		[Register("SCAR_UNSUPPORTED")]
		public static GMAEvent ScarUnsupported
		{
			get
			{
				return Java.Lang.Object.GetObject<GMAEvent>(GMAEvent._members.StaticFields.GetObjectValue("SCAR_UNSUPPORTED.Lcom/unity3d/scar/adapter/common/GMAEvent;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000E92 RID: 3730
		// (get) Token: 0x0600260A RID: 9738 RVA: 0x000620BC File Offset: 0x000602BC
		[Register("SIGNALS")]
		public static GMAEvent Signals
		{
			get
			{
				return Java.Lang.Object.GetObject<GMAEvent>(GMAEvent._members.StaticFields.GetObjectValue("SIGNALS.Lcom/unity3d/scar/adapter/common/GMAEvent;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000E93 RID: 3731
		// (get) Token: 0x0600260B RID: 9739 RVA: 0x000620EC File Offset: 0x000602EC
		[Register("SIGNALS_ERROR")]
		public static GMAEvent SignalsError
		{
			get
			{
				return Java.Lang.Object.GetObject<GMAEvent>(GMAEvent._members.StaticFields.GetObjectValue("SIGNALS_ERROR.Lcom/unity3d/scar/adapter/common/GMAEvent;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000E94 RID: 3732
		// (get) Token: 0x0600260C RID: 9740 RVA: 0x0006211C File Offset: 0x0006031C
		[Register("THIRD_QUARTILE")]
		public static GMAEvent ThirdQuartile
		{
			get
			{
				return Java.Lang.Object.GetObject<GMAEvent>(GMAEvent._members.StaticFields.GetObjectValue("THIRD_QUARTILE.Lcom/unity3d/scar/adapter/common/GMAEvent;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000E95 RID: 3733
		// (get) Token: 0x0600260D RID: 9741 RVA: 0x0006214C File Offset: 0x0006034C
		[Register("VERSION")]
		public static GMAEvent Version
		{
			get
			{
				return Java.Lang.Object.GetObject<GMAEvent>(GMAEvent._members.StaticFields.GetObjectValue("VERSION.Lcom/unity3d/scar/adapter/common/GMAEvent;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000E96 RID: 3734
		// (get) Token: 0x0600260E RID: 9742 RVA: 0x0006217C File Offset: 0x0006037C
		internal static IntPtr class_ref
		{
			get
			{
				return GMAEvent._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000E97 RID: 3735
		// (get) Token: 0x0600260F RID: 9743 RVA: 0x000621A0 File Offset: 0x000603A0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return GMAEvent._members;
			}
		}

		// Token: 0x17000E98 RID: 3736
		// (get) Token: 0x06002610 RID: 9744 RVA: 0x000621A8 File Offset: 0x000603A8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return GMAEvent._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000E99 RID: 3737
		// (get) Token: 0x06002611 RID: 9745 RVA: 0x000621CC File Offset: 0x000603CC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return GMAEvent._members.ManagedPeerType;
			}
		}

		// Token: 0x06002612 RID: 9746 RVA: 0x0000256C File Offset: 0x0000076C
		internal GMAEvent(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06002613 RID: 9747 RVA: 0x000621D8 File Offset: 0x000603D8
		[Register("valueOf", "(Ljava/lang/String;)Lcom/unity3d/scar/adapter/common/GMAEvent;", "")]
		public unsafe static GMAEvent ValueOf(string name)
		{
			IntPtr intPtr = JNIEnv.NewString(name);
			GMAEvent @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<GMAEvent>(GMAEvent._members.StaticMethods.InvokeObjectMethod("valueOf.(Ljava/lang/String;)Lcom/unity3d/scar/adapter/common/GMAEvent;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
			return @object;
		}

		// Token: 0x06002614 RID: 9748 RVA: 0x00062244 File Offset: 0x00060444
		[Register("values", "()[Lcom/unity3d/scar/adapter/common/GMAEvent;", "")]
		public static GMAEvent[] Values()
		{
			return (GMAEvent[])JNIEnv.GetArray(GMAEvent._members.StaticMethods.InvokeObjectMethod("values.()[Lcom/unity3d/scar/adapter/common/GMAEvent;", null).Handle, JniHandleOwnership.TransferLocalRef, typeof(GMAEvent));
		}

		// Token: 0x04000761 RID: 1889
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/scar/adapter/common/GMAEvent", typeof(GMAEvent));
	}
}
