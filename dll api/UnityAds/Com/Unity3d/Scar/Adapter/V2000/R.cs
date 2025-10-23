using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Com.Unity3d.Scar.Adapter.V2000
{
	// Token: 0x0200024F RID: 591
	[Register("com/unity3d/scar/adapter/v2000/R", DoNotGenerateAcw = true)]
	public sealed class R : Java.Lang.Object
	{
		// Token: 0x17000AD9 RID: 2777
		// (get) Token: 0x06001E9C RID: 7836 RVA: 0x00055758 File Offset: 0x00053958
		internal static IntPtr class_ref
		{
			get
			{
				return R._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000ADA RID: 2778
		// (get) Token: 0x06001E9D RID: 7837 RVA: 0x0005577C File Offset: 0x0005397C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return R._members;
			}
		}

		// Token: 0x17000ADB RID: 2779
		// (get) Token: 0x06001E9E RID: 7838 RVA: 0x00055784 File Offset: 0x00053984
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return R._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000ADC RID: 2780
		// (get) Token: 0x06001E9F RID: 7839 RVA: 0x000557A8 File Offset: 0x000539A8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return R._members.ManagedPeerType;
			}
		}

		// Token: 0x06001EA0 RID: 7840 RVA: 0x000021E8 File Offset: 0x000003E8
		internal R(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x040006E7 RID: 1767
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/scar/adapter/v2000/R", typeof(R));

		// Token: 0x02000250 RID: 592
		[Register("com/unity3d/scar/adapter/v2000/R$attr", DoNotGenerateAcw = true)]
		public sealed class Attr : Java.Lang.Object
		{
			// Token: 0x17000ADD RID: 2781
			// (get) Token: 0x06001EA2 RID: 7842 RVA: 0x000557CF File Offset: 0x000539CF
			// (set) Token: 0x06001EA3 RID: 7843 RVA: 0x000557E5 File Offset: 0x000539E5
			[Register("adSize")]
			public static int AdSize
			{
				get
				{
					return R.Attr._members.StaticFields.GetInt32Value("adSize.I");
				}
				set
				{
					R.Attr._members.StaticFields.SetValue("adSize.I", value);
				}
			}

			// Token: 0x17000ADE RID: 2782
			// (get) Token: 0x06001EA4 RID: 7844 RVA: 0x000557FC File Offset: 0x000539FC
			// (set) Token: 0x06001EA5 RID: 7845 RVA: 0x00055812 File Offset: 0x00053A12
			[Register("adSizes")]
			public static int AdSizes
			{
				get
				{
					return R.Attr._members.StaticFields.GetInt32Value("adSizes.I");
				}
				set
				{
					R.Attr._members.StaticFields.SetValue("adSizes.I", value);
				}
			}

			// Token: 0x17000ADF RID: 2783
			// (get) Token: 0x06001EA6 RID: 7846 RVA: 0x00055829 File Offset: 0x00053A29
			// (set) Token: 0x06001EA7 RID: 7847 RVA: 0x0005583F File Offset: 0x00053A3F
			[Register("adUnitId")]
			public static int AdUnitId
			{
				get
				{
					return R.Attr._members.StaticFields.GetInt32Value("adUnitId.I");
				}
				set
				{
					R.Attr._members.StaticFields.SetValue("adUnitId.I", value);
				}
			}

			// Token: 0x17000AE0 RID: 2784
			// (get) Token: 0x06001EA8 RID: 7848 RVA: 0x00055856 File Offset: 0x00053A56
			// (set) Token: 0x06001EA9 RID: 7849 RVA: 0x0005586C File Offset: 0x00053A6C
			[Register("alpha")]
			public static int Alpha
			{
				get
				{
					return R.Attr._members.StaticFields.GetInt32Value("alpha.I");
				}
				set
				{
					R.Attr._members.StaticFields.SetValue("alpha.I", value);
				}
			}

			// Token: 0x17000AE1 RID: 2785
			// (get) Token: 0x06001EAA RID: 7850 RVA: 0x00055883 File Offset: 0x00053A83
			// (set) Token: 0x06001EAB RID: 7851 RVA: 0x00055899 File Offset: 0x00053A99
			[Register("coordinatorLayoutStyle")]
			public static int CoordinatorLayoutStyle
			{
				get
				{
					return R.Attr._members.StaticFields.GetInt32Value("coordinatorLayoutStyle.I");
				}
				set
				{
					R.Attr._members.StaticFields.SetValue("coordinatorLayoutStyle.I", value);
				}
			}

			// Token: 0x17000AE2 RID: 2786
			// (get) Token: 0x06001EAC RID: 7852 RVA: 0x000558B0 File Offset: 0x00053AB0
			// (set) Token: 0x06001EAD RID: 7853 RVA: 0x000558C6 File Offset: 0x00053AC6
			[Register("font")]
			public static int Font
			{
				get
				{
					return R.Attr._members.StaticFields.GetInt32Value("font.I");
				}
				set
				{
					R.Attr._members.StaticFields.SetValue("font.I", value);
				}
			}

			// Token: 0x17000AE3 RID: 2787
			// (get) Token: 0x06001EAE RID: 7854 RVA: 0x000558DD File Offset: 0x00053ADD
			// (set) Token: 0x06001EAF RID: 7855 RVA: 0x000558F3 File Offset: 0x00053AF3
			[Register("fontProviderAuthority")]
			public static int FontProviderAuthority
			{
				get
				{
					return R.Attr._members.StaticFields.GetInt32Value("fontProviderAuthority.I");
				}
				set
				{
					R.Attr._members.StaticFields.SetValue("fontProviderAuthority.I", value);
				}
			}

			// Token: 0x17000AE4 RID: 2788
			// (get) Token: 0x06001EB0 RID: 7856 RVA: 0x0005590A File Offset: 0x00053B0A
			// (set) Token: 0x06001EB1 RID: 7857 RVA: 0x00055920 File Offset: 0x00053B20
			[Register("fontProviderCerts")]
			public static int FontProviderCerts
			{
				get
				{
					return R.Attr._members.StaticFields.GetInt32Value("fontProviderCerts.I");
				}
				set
				{
					R.Attr._members.StaticFields.SetValue("fontProviderCerts.I", value);
				}
			}

			// Token: 0x17000AE5 RID: 2789
			// (get) Token: 0x06001EB2 RID: 7858 RVA: 0x00055937 File Offset: 0x00053B37
			// (set) Token: 0x06001EB3 RID: 7859 RVA: 0x0005594D File Offset: 0x00053B4D
			[Register("fontProviderFetchStrategy")]
			public static int FontProviderFetchStrategy
			{
				get
				{
					return R.Attr._members.StaticFields.GetInt32Value("fontProviderFetchStrategy.I");
				}
				set
				{
					R.Attr._members.StaticFields.SetValue("fontProviderFetchStrategy.I", value);
				}
			}

			// Token: 0x17000AE6 RID: 2790
			// (get) Token: 0x06001EB4 RID: 7860 RVA: 0x00055964 File Offset: 0x00053B64
			// (set) Token: 0x06001EB5 RID: 7861 RVA: 0x0005597A File Offset: 0x00053B7A
			[Register("fontProviderFetchTimeout")]
			public static int FontProviderFetchTimeout
			{
				get
				{
					return R.Attr._members.StaticFields.GetInt32Value("fontProviderFetchTimeout.I");
				}
				set
				{
					R.Attr._members.StaticFields.SetValue("fontProviderFetchTimeout.I", value);
				}
			}

			// Token: 0x17000AE7 RID: 2791
			// (get) Token: 0x06001EB6 RID: 7862 RVA: 0x00055991 File Offset: 0x00053B91
			// (set) Token: 0x06001EB7 RID: 7863 RVA: 0x000559A7 File Offset: 0x00053BA7
			[Register("fontProviderPackage")]
			public static int FontProviderPackage
			{
				get
				{
					return R.Attr._members.StaticFields.GetInt32Value("fontProviderPackage.I");
				}
				set
				{
					R.Attr._members.StaticFields.SetValue("fontProviderPackage.I", value);
				}
			}

			// Token: 0x17000AE8 RID: 2792
			// (get) Token: 0x06001EB8 RID: 7864 RVA: 0x000559BE File Offset: 0x00053BBE
			// (set) Token: 0x06001EB9 RID: 7865 RVA: 0x000559D4 File Offset: 0x00053BD4
			[Register("fontProviderQuery")]
			public static int FontProviderQuery
			{
				get
				{
					return R.Attr._members.StaticFields.GetInt32Value("fontProviderQuery.I");
				}
				set
				{
					R.Attr._members.StaticFields.SetValue("fontProviderQuery.I", value);
				}
			}

			// Token: 0x17000AE9 RID: 2793
			// (get) Token: 0x06001EBA RID: 7866 RVA: 0x000559EB File Offset: 0x00053BEB
			// (set) Token: 0x06001EBB RID: 7867 RVA: 0x00055A01 File Offset: 0x00053C01
			[Register("fontStyle")]
			public static int FontStyle
			{
				get
				{
					return R.Attr._members.StaticFields.GetInt32Value("fontStyle.I");
				}
				set
				{
					R.Attr._members.StaticFields.SetValue("fontStyle.I", value);
				}
			}

			// Token: 0x17000AEA RID: 2794
			// (get) Token: 0x06001EBC RID: 7868 RVA: 0x00055A18 File Offset: 0x00053C18
			// (set) Token: 0x06001EBD RID: 7869 RVA: 0x00055A2E File Offset: 0x00053C2E
			[Register("fontVariationSettings")]
			public static int FontVariationSettings
			{
				get
				{
					return R.Attr._members.StaticFields.GetInt32Value("fontVariationSettings.I");
				}
				set
				{
					R.Attr._members.StaticFields.SetValue("fontVariationSettings.I", value);
				}
			}

			// Token: 0x17000AEB RID: 2795
			// (get) Token: 0x06001EBE RID: 7870 RVA: 0x00055A45 File Offset: 0x00053C45
			// (set) Token: 0x06001EBF RID: 7871 RVA: 0x00055A5B File Offset: 0x00053C5B
			[Register("fontWeight")]
			public static int FontWeight
			{
				get
				{
					return R.Attr._members.StaticFields.GetInt32Value("fontWeight.I");
				}
				set
				{
					R.Attr._members.StaticFields.SetValue("fontWeight.I", value);
				}
			}

			// Token: 0x17000AEC RID: 2796
			// (get) Token: 0x06001EC0 RID: 7872 RVA: 0x00055A72 File Offset: 0x00053C72
			// (set) Token: 0x06001EC1 RID: 7873 RVA: 0x00055A88 File Offset: 0x00053C88
			[Register("keylines")]
			public static int Keylines
			{
				get
				{
					return R.Attr._members.StaticFields.GetInt32Value("keylines.I");
				}
				set
				{
					R.Attr._members.StaticFields.SetValue("keylines.I", value);
				}
			}

			// Token: 0x17000AED RID: 2797
			// (get) Token: 0x06001EC2 RID: 7874 RVA: 0x00055A9F File Offset: 0x00053C9F
			// (set) Token: 0x06001EC3 RID: 7875 RVA: 0x00055AB5 File Offset: 0x00053CB5
			[Register("layout_anchor")]
			public static int LayoutAnchor
			{
				get
				{
					return R.Attr._members.StaticFields.GetInt32Value("layout_anchor.I");
				}
				set
				{
					R.Attr._members.StaticFields.SetValue("layout_anchor.I", value);
				}
			}

			// Token: 0x17000AEE RID: 2798
			// (get) Token: 0x06001EC4 RID: 7876 RVA: 0x00055ACC File Offset: 0x00053CCC
			// (set) Token: 0x06001EC5 RID: 7877 RVA: 0x00055AE2 File Offset: 0x00053CE2
			[Register("layout_anchorGravity")]
			public static int LayoutAnchorGravity
			{
				get
				{
					return R.Attr._members.StaticFields.GetInt32Value("layout_anchorGravity.I");
				}
				set
				{
					R.Attr._members.StaticFields.SetValue("layout_anchorGravity.I", value);
				}
			}

			// Token: 0x17000AEF RID: 2799
			// (get) Token: 0x06001EC6 RID: 7878 RVA: 0x00055AF9 File Offset: 0x00053CF9
			// (set) Token: 0x06001EC7 RID: 7879 RVA: 0x00055B0F File Offset: 0x00053D0F
			[Register("layout_behavior")]
			public static int LayoutBehavior
			{
				get
				{
					return R.Attr._members.StaticFields.GetInt32Value("layout_behavior.I");
				}
				set
				{
					R.Attr._members.StaticFields.SetValue("layout_behavior.I", value);
				}
			}

			// Token: 0x17000AF0 RID: 2800
			// (get) Token: 0x06001EC8 RID: 7880 RVA: 0x00055B26 File Offset: 0x00053D26
			// (set) Token: 0x06001EC9 RID: 7881 RVA: 0x00055B3C File Offset: 0x00053D3C
			[Register("layout_dodgeInsetEdges")]
			public static int LayoutDodgeInsetEdges
			{
				get
				{
					return R.Attr._members.StaticFields.GetInt32Value("layout_dodgeInsetEdges.I");
				}
				set
				{
					R.Attr._members.StaticFields.SetValue("layout_dodgeInsetEdges.I", value);
				}
			}

			// Token: 0x17000AF1 RID: 2801
			// (get) Token: 0x06001ECA RID: 7882 RVA: 0x00055B53 File Offset: 0x00053D53
			// (set) Token: 0x06001ECB RID: 7883 RVA: 0x00055B69 File Offset: 0x00053D69
			[Register("layout_insetEdge")]
			public static int LayoutInsetEdge
			{
				get
				{
					return R.Attr._members.StaticFields.GetInt32Value("layout_insetEdge.I");
				}
				set
				{
					R.Attr._members.StaticFields.SetValue("layout_insetEdge.I", value);
				}
			}

			// Token: 0x17000AF2 RID: 2802
			// (get) Token: 0x06001ECC RID: 7884 RVA: 0x00055B80 File Offset: 0x00053D80
			// (set) Token: 0x06001ECD RID: 7885 RVA: 0x00055B96 File Offset: 0x00053D96
			[Register("layout_keyline")]
			public static int LayoutKeyline
			{
				get
				{
					return R.Attr._members.StaticFields.GetInt32Value("layout_keyline.I");
				}
				set
				{
					R.Attr._members.StaticFields.SetValue("layout_keyline.I", value);
				}
			}

			// Token: 0x17000AF3 RID: 2803
			// (get) Token: 0x06001ECE RID: 7886 RVA: 0x00055BAD File Offset: 0x00053DAD
			// (set) Token: 0x06001ECF RID: 7887 RVA: 0x00055BC3 File Offset: 0x00053DC3
			[Register("statusBarBackground")]
			public static int StatusBarBackground
			{
				get
				{
					return R.Attr._members.StaticFields.GetInt32Value("statusBarBackground.I");
				}
				set
				{
					R.Attr._members.StaticFields.SetValue("statusBarBackground.I", value);
				}
			}

			// Token: 0x17000AF4 RID: 2804
			// (get) Token: 0x06001ED0 RID: 7888 RVA: 0x00055BDA File Offset: 0x00053DDA
			// (set) Token: 0x06001ED1 RID: 7889 RVA: 0x00055BF0 File Offset: 0x00053DF0
			[Register("ttcIndex")]
			public static int TtcIndex
			{
				get
				{
					return R.Attr._members.StaticFields.GetInt32Value("ttcIndex.I");
				}
				set
				{
					R.Attr._members.StaticFields.SetValue("ttcIndex.I", value);
				}
			}

			// Token: 0x17000AF5 RID: 2805
			// (get) Token: 0x06001ED2 RID: 7890 RVA: 0x00055C08 File Offset: 0x00053E08
			internal static IntPtr class_ref
			{
				get
				{
					return R.Attr._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x17000AF6 RID: 2806
			// (get) Token: 0x06001ED3 RID: 7891 RVA: 0x00055C2C File Offset: 0x00053E2C
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return R.Attr._members;
				}
			}

			// Token: 0x17000AF7 RID: 2807
			// (get) Token: 0x06001ED4 RID: 7892 RVA: 0x00055C34 File Offset: 0x00053E34
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return R.Attr._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x17000AF8 RID: 2808
			// (get) Token: 0x06001ED5 RID: 7893 RVA: 0x00055C58 File Offset: 0x00053E58
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return R.Attr._members.ManagedPeerType;
				}
			}

			// Token: 0x06001ED6 RID: 7894 RVA: 0x000021E8 File Offset: 0x000003E8
			internal Attr(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
			{
			}

			// Token: 0x040006E8 RID: 1768
			private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/scar/adapter/v2000/R$attr", typeof(R.Attr));
		}

		// Token: 0x02000251 RID: 593
		[Register("com/unity3d/scar/adapter/v2000/R$bool", DoNotGenerateAcw = true)]
		public sealed class Bool : Java.Lang.Object
		{
			// Token: 0x17000AF9 RID: 2809
			// (get) Token: 0x06001ED8 RID: 7896 RVA: 0x00055C7F File Offset: 0x00053E7F
			// (set) Token: 0x06001ED9 RID: 7897 RVA: 0x00055C95 File Offset: 0x00053E95
			[Register("enable_system_alarm_service_default")]
			public static int EnableSystemAlarmServiceDefault
			{
				get
				{
					return R.Bool._members.StaticFields.GetInt32Value("enable_system_alarm_service_default.I");
				}
				set
				{
					R.Bool._members.StaticFields.SetValue("enable_system_alarm_service_default.I", value);
				}
			}

			// Token: 0x17000AFA RID: 2810
			// (get) Token: 0x06001EDA RID: 7898 RVA: 0x00055CAC File Offset: 0x00053EAC
			// (set) Token: 0x06001EDB RID: 7899 RVA: 0x00055CC2 File Offset: 0x00053EC2
			[Register("enable_system_job_service_default")]
			public static int EnableSystemJobServiceDefault
			{
				get
				{
					return R.Bool._members.StaticFields.GetInt32Value("enable_system_job_service_default.I");
				}
				set
				{
					R.Bool._members.StaticFields.SetValue("enable_system_job_service_default.I", value);
				}
			}

			// Token: 0x17000AFB RID: 2811
			// (get) Token: 0x06001EDC RID: 7900 RVA: 0x00055CD9 File Offset: 0x00053ED9
			// (set) Token: 0x06001EDD RID: 7901 RVA: 0x00055CEF File Offset: 0x00053EEF
			[Register("workmanager_test_configuration")]
			public static int WorkmanagerTestConfiguration
			{
				get
				{
					return R.Bool._members.StaticFields.GetInt32Value("workmanager_test_configuration.I");
				}
				set
				{
					R.Bool._members.StaticFields.SetValue("workmanager_test_configuration.I", value);
				}
			}

			// Token: 0x17000AFC RID: 2812
			// (get) Token: 0x06001EDE RID: 7902 RVA: 0x00055D08 File Offset: 0x00053F08
			internal static IntPtr class_ref
			{
				get
				{
					return R.Bool._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x17000AFD RID: 2813
			// (get) Token: 0x06001EDF RID: 7903 RVA: 0x00055D2C File Offset: 0x00053F2C
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return R.Bool._members;
				}
			}

			// Token: 0x17000AFE RID: 2814
			// (get) Token: 0x06001EE0 RID: 7904 RVA: 0x00055D34 File Offset: 0x00053F34
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return R.Bool._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x17000AFF RID: 2815
			// (get) Token: 0x06001EE1 RID: 7905 RVA: 0x00055D58 File Offset: 0x00053F58
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return R.Bool._members.ManagedPeerType;
				}
			}

			// Token: 0x06001EE2 RID: 7906 RVA: 0x000021E8 File Offset: 0x000003E8
			internal Bool(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
			{
			}

			// Token: 0x040006E9 RID: 1769
			private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/scar/adapter/v2000/R$bool", typeof(R.Bool));
		}

		// Token: 0x02000252 RID: 594
		[Register("com/unity3d/scar/adapter/v2000/R$color", DoNotGenerateAcw = true)]
		public sealed class Color : Java.Lang.Object
		{
			// Token: 0x17000B00 RID: 2816
			// (get) Token: 0x06001EE4 RID: 7908 RVA: 0x00055D7F File Offset: 0x00053F7F
			// (set) Token: 0x06001EE5 RID: 7909 RVA: 0x00055D95 File Offset: 0x00053F95
			[Register("browser_actions_bg_grey")]
			public static int BrowserActionsBgGrey
			{
				get
				{
					return R.Color._members.StaticFields.GetInt32Value("browser_actions_bg_grey.I");
				}
				set
				{
					R.Color._members.StaticFields.SetValue("browser_actions_bg_grey.I", value);
				}
			}

			// Token: 0x17000B01 RID: 2817
			// (get) Token: 0x06001EE6 RID: 7910 RVA: 0x00055DAC File Offset: 0x00053FAC
			// (set) Token: 0x06001EE7 RID: 7911 RVA: 0x00055DC2 File Offset: 0x00053FC2
			[Register("browser_actions_divider_color")]
			public static int BrowserActionsDividerColor
			{
				get
				{
					return R.Color._members.StaticFields.GetInt32Value("browser_actions_divider_color.I");
				}
				set
				{
					R.Color._members.StaticFields.SetValue("browser_actions_divider_color.I", value);
				}
			}

			// Token: 0x17000B02 RID: 2818
			// (get) Token: 0x06001EE8 RID: 7912 RVA: 0x00055DD9 File Offset: 0x00053FD9
			// (set) Token: 0x06001EE9 RID: 7913 RVA: 0x00055DEF File Offset: 0x00053FEF
			[Register("browser_actions_text_color")]
			public static int BrowserActionsTextColor
			{
				get
				{
					return R.Color._members.StaticFields.GetInt32Value("browser_actions_text_color.I");
				}
				set
				{
					R.Color._members.StaticFields.SetValue("browser_actions_text_color.I", value);
				}
			}

			// Token: 0x17000B03 RID: 2819
			// (get) Token: 0x06001EEA RID: 7914 RVA: 0x00055E06 File Offset: 0x00054006
			// (set) Token: 0x06001EEB RID: 7915 RVA: 0x00055E1C File Offset: 0x0005401C
			[Register("browser_actions_title_color")]
			public static int BrowserActionsTitleColor
			{
				get
				{
					return R.Color._members.StaticFields.GetInt32Value("browser_actions_title_color.I");
				}
				set
				{
					R.Color._members.StaticFields.SetValue("browser_actions_title_color.I", value);
				}
			}

			// Token: 0x17000B04 RID: 2820
			// (get) Token: 0x06001EEC RID: 7916 RVA: 0x00055E33 File Offset: 0x00054033
			// (set) Token: 0x06001EED RID: 7917 RVA: 0x00055E49 File Offset: 0x00054049
			[Register("notification_action_color_filter")]
			public static int NotificationActionColorFilter
			{
				get
				{
					return R.Color._members.StaticFields.GetInt32Value("notification_action_color_filter.I");
				}
				set
				{
					R.Color._members.StaticFields.SetValue("notification_action_color_filter.I", value);
				}
			}

			// Token: 0x17000B05 RID: 2821
			// (get) Token: 0x06001EEE RID: 7918 RVA: 0x00055E60 File Offset: 0x00054060
			// (set) Token: 0x06001EEF RID: 7919 RVA: 0x00055E76 File Offset: 0x00054076
			[Register("notification_icon_bg_color")]
			public static int NotificationIconBgColor
			{
				get
				{
					return R.Color._members.StaticFields.GetInt32Value("notification_icon_bg_color.I");
				}
				set
				{
					R.Color._members.StaticFields.SetValue("notification_icon_bg_color.I", value);
				}
			}

			// Token: 0x17000B06 RID: 2822
			// (get) Token: 0x06001EF0 RID: 7920 RVA: 0x00055E8D File Offset: 0x0005408D
			// (set) Token: 0x06001EF1 RID: 7921 RVA: 0x00055EA3 File Offset: 0x000540A3
			[Register("ripple_material_light")]
			public static int RippleMaterialLight
			{
				get
				{
					return R.Color._members.StaticFields.GetInt32Value("ripple_material_light.I");
				}
				set
				{
					R.Color._members.StaticFields.SetValue("ripple_material_light.I", value);
				}
			}

			// Token: 0x17000B07 RID: 2823
			// (get) Token: 0x06001EF2 RID: 7922 RVA: 0x00055EBA File Offset: 0x000540BA
			// (set) Token: 0x06001EF3 RID: 7923 RVA: 0x00055ED0 File Offset: 0x000540D0
			[Register("secondary_text_default_material_light")]
			public static int SecondaryTextDefaultMaterialLight
			{
				get
				{
					return R.Color._members.StaticFields.GetInt32Value("secondary_text_default_material_light.I");
				}
				set
				{
					R.Color._members.StaticFields.SetValue("secondary_text_default_material_light.I", value);
				}
			}

			// Token: 0x17000B08 RID: 2824
			// (get) Token: 0x06001EF4 RID: 7924 RVA: 0x00055EE8 File Offset: 0x000540E8
			internal static IntPtr class_ref
			{
				get
				{
					return R.Color._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x17000B09 RID: 2825
			// (get) Token: 0x06001EF5 RID: 7925 RVA: 0x00055F0C File Offset: 0x0005410C
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return R.Color._members;
				}
			}

			// Token: 0x17000B0A RID: 2826
			// (get) Token: 0x06001EF6 RID: 7926 RVA: 0x00055F14 File Offset: 0x00054114
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return R.Color._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x17000B0B RID: 2827
			// (get) Token: 0x06001EF7 RID: 7927 RVA: 0x00055F38 File Offset: 0x00054138
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return R.Color._members.ManagedPeerType;
				}
			}

			// Token: 0x06001EF8 RID: 7928 RVA: 0x000021E8 File Offset: 0x000003E8
			internal Color(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
			{
			}

			// Token: 0x040006EA RID: 1770
			private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/scar/adapter/v2000/R$color", typeof(R.Color));
		}

		// Token: 0x02000253 RID: 595
		[Register("com/unity3d/scar/adapter/v2000/R$dimen", DoNotGenerateAcw = true)]
		public sealed class Dimen : Java.Lang.Object
		{
			// Token: 0x17000B0C RID: 2828
			// (get) Token: 0x06001EFA RID: 7930 RVA: 0x00055F5F File Offset: 0x0005415F
			// (set) Token: 0x06001EFB RID: 7931 RVA: 0x00055F75 File Offset: 0x00054175
			[Register("browser_actions_context_menu_max_width")]
			public static int BrowserActionsContextMenuMaxWidth
			{
				get
				{
					return R.Dimen._members.StaticFields.GetInt32Value("browser_actions_context_menu_max_width.I");
				}
				set
				{
					R.Dimen._members.StaticFields.SetValue("browser_actions_context_menu_max_width.I", value);
				}
			}

			// Token: 0x17000B0D RID: 2829
			// (get) Token: 0x06001EFC RID: 7932 RVA: 0x00055F8C File Offset: 0x0005418C
			// (set) Token: 0x06001EFD RID: 7933 RVA: 0x00055FA2 File Offset: 0x000541A2
			[Register("browser_actions_context_menu_min_padding")]
			public static int BrowserActionsContextMenuMinPadding
			{
				get
				{
					return R.Dimen._members.StaticFields.GetInt32Value("browser_actions_context_menu_min_padding.I");
				}
				set
				{
					R.Dimen._members.StaticFields.SetValue("browser_actions_context_menu_min_padding.I", value);
				}
			}

			// Token: 0x17000B0E RID: 2830
			// (get) Token: 0x06001EFE RID: 7934 RVA: 0x00055FB9 File Offset: 0x000541B9
			// (set) Token: 0x06001EFF RID: 7935 RVA: 0x00055FCF File Offset: 0x000541CF
			[Register("compat_button_inset_horizontal_material")]
			public static int CompatButtonInsetHorizontalMaterial
			{
				get
				{
					return R.Dimen._members.StaticFields.GetInt32Value("compat_button_inset_horizontal_material.I");
				}
				set
				{
					R.Dimen._members.StaticFields.SetValue("compat_button_inset_horizontal_material.I", value);
				}
			}

			// Token: 0x17000B0F RID: 2831
			// (get) Token: 0x06001F00 RID: 7936 RVA: 0x00055FE6 File Offset: 0x000541E6
			// (set) Token: 0x06001F01 RID: 7937 RVA: 0x00055FFC File Offset: 0x000541FC
			[Register("compat_button_inset_vertical_material")]
			public static int CompatButtonInsetVerticalMaterial
			{
				get
				{
					return R.Dimen._members.StaticFields.GetInt32Value("compat_button_inset_vertical_material.I");
				}
				set
				{
					R.Dimen._members.StaticFields.SetValue("compat_button_inset_vertical_material.I", value);
				}
			}

			// Token: 0x17000B10 RID: 2832
			// (get) Token: 0x06001F02 RID: 7938 RVA: 0x00056013 File Offset: 0x00054213
			// (set) Token: 0x06001F03 RID: 7939 RVA: 0x00056029 File Offset: 0x00054229
			[Register("compat_button_padding_horizontal_material")]
			public static int CompatButtonPaddingHorizontalMaterial
			{
				get
				{
					return R.Dimen._members.StaticFields.GetInt32Value("compat_button_padding_horizontal_material.I");
				}
				set
				{
					R.Dimen._members.StaticFields.SetValue("compat_button_padding_horizontal_material.I", value);
				}
			}

			// Token: 0x17000B11 RID: 2833
			// (get) Token: 0x06001F04 RID: 7940 RVA: 0x00056040 File Offset: 0x00054240
			// (set) Token: 0x06001F05 RID: 7941 RVA: 0x00056056 File Offset: 0x00054256
			[Register("compat_button_padding_vertical_material")]
			public static int CompatButtonPaddingVerticalMaterial
			{
				get
				{
					return R.Dimen._members.StaticFields.GetInt32Value("compat_button_padding_vertical_material.I");
				}
				set
				{
					R.Dimen._members.StaticFields.SetValue("compat_button_padding_vertical_material.I", value);
				}
			}

			// Token: 0x17000B12 RID: 2834
			// (get) Token: 0x06001F06 RID: 7942 RVA: 0x0005606D File Offset: 0x0005426D
			// (set) Token: 0x06001F07 RID: 7943 RVA: 0x00056083 File Offset: 0x00054283
			[Register("compat_control_corner_material")]
			public static int CompatControlCornerMaterial
			{
				get
				{
					return R.Dimen._members.StaticFields.GetInt32Value("compat_control_corner_material.I");
				}
				set
				{
					R.Dimen._members.StaticFields.SetValue("compat_control_corner_material.I", value);
				}
			}

			// Token: 0x17000B13 RID: 2835
			// (get) Token: 0x06001F08 RID: 7944 RVA: 0x0005609A File Offset: 0x0005429A
			// (set) Token: 0x06001F09 RID: 7945 RVA: 0x000560B0 File Offset: 0x000542B0
			[Register("compat_notification_large_icon_max_height")]
			public static int CompatNotificationLargeIconMaxHeight
			{
				get
				{
					return R.Dimen._members.StaticFields.GetInt32Value("compat_notification_large_icon_max_height.I");
				}
				set
				{
					R.Dimen._members.StaticFields.SetValue("compat_notification_large_icon_max_height.I", value);
				}
			}

			// Token: 0x17000B14 RID: 2836
			// (get) Token: 0x06001F0A RID: 7946 RVA: 0x000560C7 File Offset: 0x000542C7
			// (set) Token: 0x06001F0B RID: 7947 RVA: 0x000560DD File Offset: 0x000542DD
			[Register("compat_notification_large_icon_max_width")]
			public static int CompatNotificationLargeIconMaxWidth
			{
				get
				{
					return R.Dimen._members.StaticFields.GetInt32Value("compat_notification_large_icon_max_width.I");
				}
				set
				{
					R.Dimen._members.StaticFields.SetValue("compat_notification_large_icon_max_width.I", value);
				}
			}

			// Token: 0x17000B15 RID: 2837
			// (get) Token: 0x06001F0C RID: 7948 RVA: 0x000560F4 File Offset: 0x000542F4
			// (set) Token: 0x06001F0D RID: 7949 RVA: 0x0005610A File Offset: 0x0005430A
			[Register("notification_action_icon_size")]
			public static int NotificationActionIconSize
			{
				get
				{
					return R.Dimen._members.StaticFields.GetInt32Value("notification_action_icon_size.I");
				}
				set
				{
					R.Dimen._members.StaticFields.SetValue("notification_action_icon_size.I", value);
				}
			}

			// Token: 0x17000B16 RID: 2838
			// (get) Token: 0x06001F0E RID: 7950 RVA: 0x00056121 File Offset: 0x00054321
			// (set) Token: 0x06001F0F RID: 7951 RVA: 0x00056137 File Offset: 0x00054337
			[Register("notification_action_text_size")]
			public static int NotificationActionTextSize
			{
				get
				{
					return R.Dimen._members.StaticFields.GetInt32Value("notification_action_text_size.I");
				}
				set
				{
					R.Dimen._members.StaticFields.SetValue("notification_action_text_size.I", value);
				}
			}

			// Token: 0x17000B17 RID: 2839
			// (get) Token: 0x06001F10 RID: 7952 RVA: 0x0005614E File Offset: 0x0005434E
			// (set) Token: 0x06001F11 RID: 7953 RVA: 0x00056164 File Offset: 0x00054364
			[Register("notification_big_circle_margin")]
			public static int NotificationBigCircleMargin
			{
				get
				{
					return R.Dimen._members.StaticFields.GetInt32Value("notification_big_circle_margin.I");
				}
				set
				{
					R.Dimen._members.StaticFields.SetValue("notification_big_circle_margin.I", value);
				}
			}

			// Token: 0x17000B18 RID: 2840
			// (get) Token: 0x06001F12 RID: 7954 RVA: 0x0005617B File Offset: 0x0005437B
			// (set) Token: 0x06001F13 RID: 7955 RVA: 0x00056191 File Offset: 0x00054391
			[Register("notification_content_margin_start")]
			public static int NotificationContentMarginStart
			{
				get
				{
					return R.Dimen._members.StaticFields.GetInt32Value("notification_content_margin_start.I");
				}
				set
				{
					R.Dimen._members.StaticFields.SetValue("notification_content_margin_start.I", value);
				}
			}

			// Token: 0x17000B19 RID: 2841
			// (get) Token: 0x06001F14 RID: 7956 RVA: 0x000561A8 File Offset: 0x000543A8
			// (set) Token: 0x06001F15 RID: 7957 RVA: 0x000561BE File Offset: 0x000543BE
			[Register("notification_large_icon_height")]
			public static int NotificationLargeIconHeight
			{
				get
				{
					return R.Dimen._members.StaticFields.GetInt32Value("notification_large_icon_height.I");
				}
				set
				{
					R.Dimen._members.StaticFields.SetValue("notification_large_icon_height.I", value);
				}
			}

			// Token: 0x17000B1A RID: 2842
			// (get) Token: 0x06001F16 RID: 7958 RVA: 0x000561D5 File Offset: 0x000543D5
			// (set) Token: 0x06001F17 RID: 7959 RVA: 0x000561EB File Offset: 0x000543EB
			[Register("notification_large_icon_width")]
			public static int NotificationLargeIconWidth
			{
				get
				{
					return R.Dimen._members.StaticFields.GetInt32Value("notification_large_icon_width.I");
				}
				set
				{
					R.Dimen._members.StaticFields.SetValue("notification_large_icon_width.I", value);
				}
			}

			// Token: 0x17000B1B RID: 2843
			// (get) Token: 0x06001F18 RID: 7960 RVA: 0x00056202 File Offset: 0x00054402
			// (set) Token: 0x06001F19 RID: 7961 RVA: 0x00056218 File Offset: 0x00054418
			[Register("notification_main_column_padding_top")]
			public static int NotificationMainColumnPaddingTop
			{
				get
				{
					return R.Dimen._members.StaticFields.GetInt32Value("notification_main_column_padding_top.I");
				}
				set
				{
					R.Dimen._members.StaticFields.SetValue("notification_main_column_padding_top.I", value);
				}
			}

			// Token: 0x17000B1C RID: 2844
			// (get) Token: 0x06001F1A RID: 7962 RVA: 0x0005622F File Offset: 0x0005442F
			// (set) Token: 0x06001F1B RID: 7963 RVA: 0x00056245 File Offset: 0x00054445
			[Register("notification_media_narrow_margin")]
			public static int NotificationMediaNarrowMargin
			{
				get
				{
					return R.Dimen._members.StaticFields.GetInt32Value("notification_media_narrow_margin.I");
				}
				set
				{
					R.Dimen._members.StaticFields.SetValue("notification_media_narrow_margin.I", value);
				}
			}

			// Token: 0x17000B1D RID: 2845
			// (get) Token: 0x06001F1C RID: 7964 RVA: 0x0005625C File Offset: 0x0005445C
			// (set) Token: 0x06001F1D RID: 7965 RVA: 0x00056272 File Offset: 0x00054472
			[Register("notification_right_icon_size")]
			public static int NotificationRightIconSize
			{
				get
				{
					return R.Dimen._members.StaticFields.GetInt32Value("notification_right_icon_size.I");
				}
				set
				{
					R.Dimen._members.StaticFields.SetValue("notification_right_icon_size.I", value);
				}
			}

			// Token: 0x17000B1E RID: 2846
			// (get) Token: 0x06001F1E RID: 7966 RVA: 0x00056289 File Offset: 0x00054489
			// (set) Token: 0x06001F1F RID: 7967 RVA: 0x0005629F File Offset: 0x0005449F
			[Register("notification_right_side_padding_top")]
			public static int NotificationRightSidePaddingTop
			{
				get
				{
					return R.Dimen._members.StaticFields.GetInt32Value("notification_right_side_padding_top.I");
				}
				set
				{
					R.Dimen._members.StaticFields.SetValue("notification_right_side_padding_top.I", value);
				}
			}

			// Token: 0x17000B1F RID: 2847
			// (get) Token: 0x06001F20 RID: 7968 RVA: 0x000562B6 File Offset: 0x000544B6
			// (set) Token: 0x06001F21 RID: 7969 RVA: 0x000562CC File Offset: 0x000544CC
			[Register("notification_small_icon_background_padding")]
			public static int NotificationSmallIconBackgroundPadding
			{
				get
				{
					return R.Dimen._members.StaticFields.GetInt32Value("notification_small_icon_background_padding.I");
				}
				set
				{
					R.Dimen._members.StaticFields.SetValue("notification_small_icon_background_padding.I", value);
				}
			}

			// Token: 0x17000B20 RID: 2848
			// (get) Token: 0x06001F22 RID: 7970 RVA: 0x000562E3 File Offset: 0x000544E3
			// (set) Token: 0x06001F23 RID: 7971 RVA: 0x000562F9 File Offset: 0x000544F9
			[Register("notification_small_icon_size_as_large")]
			public static int NotificationSmallIconSizeAsLarge
			{
				get
				{
					return R.Dimen._members.StaticFields.GetInt32Value("notification_small_icon_size_as_large.I");
				}
				set
				{
					R.Dimen._members.StaticFields.SetValue("notification_small_icon_size_as_large.I", value);
				}
			}

			// Token: 0x17000B21 RID: 2849
			// (get) Token: 0x06001F24 RID: 7972 RVA: 0x00056310 File Offset: 0x00054510
			// (set) Token: 0x06001F25 RID: 7973 RVA: 0x00056326 File Offset: 0x00054526
			[Register("notification_subtext_size")]
			public static int NotificationSubtextSize
			{
				get
				{
					return R.Dimen._members.StaticFields.GetInt32Value("notification_subtext_size.I");
				}
				set
				{
					R.Dimen._members.StaticFields.SetValue("notification_subtext_size.I", value);
				}
			}

			// Token: 0x17000B22 RID: 2850
			// (get) Token: 0x06001F26 RID: 7974 RVA: 0x0005633D File Offset: 0x0005453D
			// (set) Token: 0x06001F27 RID: 7975 RVA: 0x00056353 File Offset: 0x00054553
			[Register("notification_top_pad")]
			public static int NotificationTopPad
			{
				get
				{
					return R.Dimen._members.StaticFields.GetInt32Value("notification_top_pad.I");
				}
				set
				{
					R.Dimen._members.StaticFields.SetValue("notification_top_pad.I", value);
				}
			}

			// Token: 0x17000B23 RID: 2851
			// (get) Token: 0x06001F28 RID: 7976 RVA: 0x0005636A File Offset: 0x0005456A
			// (set) Token: 0x06001F29 RID: 7977 RVA: 0x00056380 File Offset: 0x00054580
			[Register("notification_top_pad_large_text")]
			public static int NotificationTopPadLargeText
			{
				get
				{
					return R.Dimen._members.StaticFields.GetInt32Value("notification_top_pad_large_text.I");
				}
				set
				{
					R.Dimen._members.StaticFields.SetValue("notification_top_pad_large_text.I", value);
				}
			}

			// Token: 0x17000B24 RID: 2852
			// (get) Token: 0x06001F2A RID: 7978 RVA: 0x00056398 File Offset: 0x00054598
			internal static IntPtr class_ref
			{
				get
				{
					return R.Dimen._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x17000B25 RID: 2853
			// (get) Token: 0x06001F2B RID: 7979 RVA: 0x000563BC File Offset: 0x000545BC
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return R.Dimen._members;
				}
			}

			// Token: 0x17000B26 RID: 2854
			// (get) Token: 0x06001F2C RID: 7980 RVA: 0x000563C4 File Offset: 0x000545C4
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return R.Dimen._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x17000B27 RID: 2855
			// (get) Token: 0x06001F2D RID: 7981 RVA: 0x000563E8 File Offset: 0x000545E8
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return R.Dimen._members.ManagedPeerType;
				}
			}

			// Token: 0x06001F2E RID: 7982 RVA: 0x000021E8 File Offset: 0x000003E8
			internal Dimen(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
			{
			}

			// Token: 0x040006EB RID: 1771
			private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/scar/adapter/v2000/R$dimen", typeof(R.Dimen));
		}

		// Token: 0x02000254 RID: 596
		[Register("com/unity3d/scar/adapter/v2000/R$drawable", DoNotGenerateAcw = true)]
		public sealed class Drawable : Java.Lang.Object
		{
			// Token: 0x17000B28 RID: 2856
			// (get) Token: 0x06001F30 RID: 7984 RVA: 0x0005640F File Offset: 0x0005460F
			// (set) Token: 0x06001F31 RID: 7985 RVA: 0x00056425 File Offset: 0x00054625
			[Register("notification_action_background")]
			public static int NotificationActionBackground
			{
				get
				{
					return R.Drawable._members.StaticFields.GetInt32Value("notification_action_background.I");
				}
				set
				{
					R.Drawable._members.StaticFields.SetValue("notification_action_background.I", value);
				}
			}

			// Token: 0x17000B29 RID: 2857
			// (get) Token: 0x06001F32 RID: 7986 RVA: 0x0005643C File Offset: 0x0005463C
			// (set) Token: 0x06001F33 RID: 7987 RVA: 0x00056452 File Offset: 0x00054652
			[Register("notification_bg")]
			public static int NotificationBg
			{
				get
				{
					return R.Drawable._members.StaticFields.GetInt32Value("notification_bg.I");
				}
				set
				{
					R.Drawable._members.StaticFields.SetValue("notification_bg.I", value);
				}
			}

			// Token: 0x17000B2A RID: 2858
			// (get) Token: 0x06001F34 RID: 7988 RVA: 0x00056469 File Offset: 0x00054669
			// (set) Token: 0x06001F35 RID: 7989 RVA: 0x0005647F File Offset: 0x0005467F
			[Register("notification_bg_low")]
			public static int NotificationBgLow
			{
				get
				{
					return R.Drawable._members.StaticFields.GetInt32Value("notification_bg_low.I");
				}
				set
				{
					R.Drawable._members.StaticFields.SetValue("notification_bg_low.I", value);
				}
			}

			// Token: 0x17000B2B RID: 2859
			// (get) Token: 0x06001F36 RID: 7990 RVA: 0x00056496 File Offset: 0x00054696
			// (set) Token: 0x06001F37 RID: 7991 RVA: 0x000564AC File Offset: 0x000546AC
			[Register("notification_bg_low_normal")]
			public static int NotificationBgLowNormal
			{
				get
				{
					return R.Drawable._members.StaticFields.GetInt32Value("notification_bg_low_normal.I");
				}
				set
				{
					R.Drawable._members.StaticFields.SetValue("notification_bg_low_normal.I", value);
				}
			}

			// Token: 0x17000B2C RID: 2860
			// (get) Token: 0x06001F38 RID: 7992 RVA: 0x000564C3 File Offset: 0x000546C3
			// (set) Token: 0x06001F39 RID: 7993 RVA: 0x000564D9 File Offset: 0x000546D9
			[Register("notification_bg_low_pressed")]
			public static int NotificationBgLowPressed
			{
				get
				{
					return R.Drawable._members.StaticFields.GetInt32Value("notification_bg_low_pressed.I");
				}
				set
				{
					R.Drawable._members.StaticFields.SetValue("notification_bg_low_pressed.I", value);
				}
			}

			// Token: 0x17000B2D RID: 2861
			// (get) Token: 0x06001F3A RID: 7994 RVA: 0x000564F0 File Offset: 0x000546F0
			// (set) Token: 0x06001F3B RID: 7995 RVA: 0x00056506 File Offset: 0x00054706
			[Register("notification_bg_normal")]
			public static int NotificationBgNormal
			{
				get
				{
					return R.Drawable._members.StaticFields.GetInt32Value("notification_bg_normal.I");
				}
				set
				{
					R.Drawable._members.StaticFields.SetValue("notification_bg_normal.I", value);
				}
			}

			// Token: 0x17000B2E RID: 2862
			// (get) Token: 0x06001F3C RID: 7996 RVA: 0x0005651D File Offset: 0x0005471D
			// (set) Token: 0x06001F3D RID: 7997 RVA: 0x00056533 File Offset: 0x00054733
			[Register("notification_bg_normal_pressed")]
			public static int NotificationBgNormalPressed
			{
				get
				{
					return R.Drawable._members.StaticFields.GetInt32Value("notification_bg_normal_pressed.I");
				}
				set
				{
					R.Drawable._members.StaticFields.SetValue("notification_bg_normal_pressed.I", value);
				}
			}

			// Token: 0x17000B2F RID: 2863
			// (get) Token: 0x06001F3E RID: 7998 RVA: 0x0005654A File Offset: 0x0005474A
			// (set) Token: 0x06001F3F RID: 7999 RVA: 0x00056560 File Offset: 0x00054760
			[Register("notification_icon_background")]
			public static int NotificationIconBackground
			{
				get
				{
					return R.Drawable._members.StaticFields.GetInt32Value("notification_icon_background.I");
				}
				set
				{
					R.Drawable._members.StaticFields.SetValue("notification_icon_background.I", value);
				}
			}

			// Token: 0x17000B30 RID: 2864
			// (get) Token: 0x06001F40 RID: 8000 RVA: 0x00056577 File Offset: 0x00054777
			// (set) Token: 0x06001F41 RID: 8001 RVA: 0x0005658D File Offset: 0x0005478D
			[Register("notification_template_icon_bg")]
			public static int NotificationTemplateIconBg
			{
				get
				{
					return R.Drawable._members.StaticFields.GetInt32Value("notification_template_icon_bg.I");
				}
				set
				{
					R.Drawable._members.StaticFields.SetValue("notification_template_icon_bg.I", value);
				}
			}

			// Token: 0x17000B31 RID: 2865
			// (get) Token: 0x06001F42 RID: 8002 RVA: 0x000565A4 File Offset: 0x000547A4
			// (set) Token: 0x06001F43 RID: 8003 RVA: 0x000565BA File Offset: 0x000547BA
			[Register("notification_template_icon_low_bg")]
			public static int NotificationTemplateIconLowBg
			{
				get
				{
					return R.Drawable._members.StaticFields.GetInt32Value("notification_template_icon_low_bg.I");
				}
				set
				{
					R.Drawable._members.StaticFields.SetValue("notification_template_icon_low_bg.I", value);
				}
			}

			// Token: 0x17000B32 RID: 2866
			// (get) Token: 0x06001F44 RID: 8004 RVA: 0x000565D1 File Offset: 0x000547D1
			// (set) Token: 0x06001F45 RID: 8005 RVA: 0x000565E7 File Offset: 0x000547E7
			[Register("notification_tile_bg")]
			public static int NotificationTileBg
			{
				get
				{
					return R.Drawable._members.StaticFields.GetInt32Value("notification_tile_bg.I");
				}
				set
				{
					R.Drawable._members.StaticFields.SetValue("notification_tile_bg.I", value);
				}
			}

			// Token: 0x17000B33 RID: 2867
			// (get) Token: 0x06001F46 RID: 8006 RVA: 0x000565FE File Offset: 0x000547FE
			// (set) Token: 0x06001F47 RID: 8007 RVA: 0x00056614 File Offset: 0x00054814
			[Register("notify_panel_notification_icon_bg")]
			public static int NotifyPanelNotificationIconBg
			{
				get
				{
					return R.Drawable._members.StaticFields.GetInt32Value("notify_panel_notification_icon_bg.I");
				}
				set
				{
					R.Drawable._members.StaticFields.SetValue("notify_panel_notification_icon_bg.I", value);
				}
			}

			// Token: 0x17000B34 RID: 2868
			// (get) Token: 0x06001F48 RID: 8008 RVA: 0x0005662C File Offset: 0x0005482C
			internal static IntPtr class_ref
			{
				get
				{
					return R.Drawable._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x17000B35 RID: 2869
			// (get) Token: 0x06001F49 RID: 8009 RVA: 0x00056650 File Offset: 0x00054850
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return R.Drawable._members;
				}
			}

			// Token: 0x17000B36 RID: 2870
			// (get) Token: 0x06001F4A RID: 8010 RVA: 0x00056658 File Offset: 0x00054858
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return R.Drawable._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x17000B37 RID: 2871
			// (get) Token: 0x06001F4B RID: 8011 RVA: 0x0005667C File Offset: 0x0005487C
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return R.Drawable._members.ManagedPeerType;
				}
			}

			// Token: 0x06001F4C RID: 8012 RVA: 0x000021E8 File Offset: 0x000003E8
			internal Drawable(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
			{
			}

			// Token: 0x040006EC RID: 1772
			private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/scar/adapter/v2000/R$drawable", typeof(R.Drawable));
		}

		// Token: 0x02000255 RID: 597
		[Register("com/unity3d/scar/adapter/v2000/R$id", DoNotGenerateAcw = true)]
		public sealed class Id : Java.Lang.Object
		{
			// Token: 0x17000B38 RID: 2872
			// (get) Token: 0x06001F4E RID: 8014 RVA: 0x000566A3 File Offset: 0x000548A3
			// (set) Token: 0x06001F4F RID: 8015 RVA: 0x000566B9 File Offset: 0x000548B9
			[Register("accessibility_action_clickable_span")]
			public static int AccessibilityActionClickableSpan
			{
				get
				{
					return R.Id._members.StaticFields.GetInt32Value("accessibility_action_clickable_span.I");
				}
				set
				{
					R.Id._members.StaticFields.SetValue("accessibility_action_clickable_span.I", value);
				}
			}

			// Token: 0x17000B39 RID: 2873
			// (get) Token: 0x06001F50 RID: 8016 RVA: 0x000566D0 File Offset: 0x000548D0
			// (set) Token: 0x06001F51 RID: 8017 RVA: 0x000566E6 File Offset: 0x000548E6
			[Register("accessibility_custom_action_0")]
			public static int AccessibilityCustomAction0
			{
				get
				{
					return R.Id._members.StaticFields.GetInt32Value("accessibility_custom_action_0.I");
				}
				set
				{
					R.Id._members.StaticFields.SetValue("accessibility_custom_action_0.I", value);
				}
			}

			// Token: 0x17000B3A RID: 2874
			// (get) Token: 0x06001F52 RID: 8018 RVA: 0x000566FD File Offset: 0x000548FD
			// (set) Token: 0x06001F53 RID: 8019 RVA: 0x00056713 File Offset: 0x00054913
			[Register("accessibility_custom_action_1")]
			public static int AccessibilityCustomAction1
			{
				get
				{
					return R.Id._members.StaticFields.GetInt32Value("accessibility_custom_action_1.I");
				}
				set
				{
					R.Id._members.StaticFields.SetValue("accessibility_custom_action_1.I", value);
				}
			}

			// Token: 0x17000B3B RID: 2875
			// (get) Token: 0x06001F54 RID: 8020 RVA: 0x0005672A File Offset: 0x0005492A
			// (set) Token: 0x06001F55 RID: 8021 RVA: 0x00056740 File Offset: 0x00054940
			[Register("accessibility_custom_action_10")]
			public static int AccessibilityCustomAction10
			{
				get
				{
					return R.Id._members.StaticFields.GetInt32Value("accessibility_custom_action_10.I");
				}
				set
				{
					R.Id._members.StaticFields.SetValue("accessibility_custom_action_10.I", value);
				}
			}

			// Token: 0x17000B3C RID: 2876
			// (get) Token: 0x06001F56 RID: 8022 RVA: 0x00056757 File Offset: 0x00054957
			// (set) Token: 0x06001F57 RID: 8023 RVA: 0x0005676D File Offset: 0x0005496D
			[Register("accessibility_custom_action_11")]
			public static int AccessibilityCustomAction11
			{
				get
				{
					return R.Id._members.StaticFields.GetInt32Value("accessibility_custom_action_11.I");
				}
				set
				{
					R.Id._members.StaticFields.SetValue("accessibility_custom_action_11.I", value);
				}
			}

			// Token: 0x17000B3D RID: 2877
			// (get) Token: 0x06001F58 RID: 8024 RVA: 0x00056784 File Offset: 0x00054984
			// (set) Token: 0x06001F59 RID: 8025 RVA: 0x0005679A File Offset: 0x0005499A
			[Register("accessibility_custom_action_12")]
			public static int AccessibilityCustomAction12
			{
				get
				{
					return R.Id._members.StaticFields.GetInt32Value("accessibility_custom_action_12.I");
				}
				set
				{
					R.Id._members.StaticFields.SetValue("accessibility_custom_action_12.I", value);
				}
			}

			// Token: 0x17000B3E RID: 2878
			// (get) Token: 0x06001F5A RID: 8026 RVA: 0x000567B1 File Offset: 0x000549B1
			// (set) Token: 0x06001F5B RID: 8027 RVA: 0x000567C7 File Offset: 0x000549C7
			[Register("accessibility_custom_action_13")]
			public static int AccessibilityCustomAction13
			{
				get
				{
					return R.Id._members.StaticFields.GetInt32Value("accessibility_custom_action_13.I");
				}
				set
				{
					R.Id._members.StaticFields.SetValue("accessibility_custom_action_13.I", value);
				}
			}

			// Token: 0x17000B3F RID: 2879
			// (get) Token: 0x06001F5C RID: 8028 RVA: 0x000567DE File Offset: 0x000549DE
			// (set) Token: 0x06001F5D RID: 8029 RVA: 0x000567F4 File Offset: 0x000549F4
			[Register("accessibility_custom_action_14")]
			public static int AccessibilityCustomAction14
			{
				get
				{
					return R.Id._members.StaticFields.GetInt32Value("accessibility_custom_action_14.I");
				}
				set
				{
					R.Id._members.StaticFields.SetValue("accessibility_custom_action_14.I", value);
				}
			}

			// Token: 0x17000B40 RID: 2880
			// (get) Token: 0x06001F5E RID: 8030 RVA: 0x0005680B File Offset: 0x00054A0B
			// (set) Token: 0x06001F5F RID: 8031 RVA: 0x00056821 File Offset: 0x00054A21
			[Register("accessibility_custom_action_15")]
			public static int AccessibilityCustomAction15
			{
				get
				{
					return R.Id._members.StaticFields.GetInt32Value("accessibility_custom_action_15.I");
				}
				set
				{
					R.Id._members.StaticFields.SetValue("accessibility_custom_action_15.I", value);
				}
			}

			// Token: 0x17000B41 RID: 2881
			// (get) Token: 0x06001F60 RID: 8032 RVA: 0x00056838 File Offset: 0x00054A38
			// (set) Token: 0x06001F61 RID: 8033 RVA: 0x0005684E File Offset: 0x00054A4E
			[Register("accessibility_custom_action_16")]
			public static int AccessibilityCustomAction16
			{
				get
				{
					return R.Id._members.StaticFields.GetInt32Value("accessibility_custom_action_16.I");
				}
				set
				{
					R.Id._members.StaticFields.SetValue("accessibility_custom_action_16.I", value);
				}
			}

			// Token: 0x17000B42 RID: 2882
			// (get) Token: 0x06001F62 RID: 8034 RVA: 0x00056865 File Offset: 0x00054A65
			// (set) Token: 0x06001F63 RID: 8035 RVA: 0x0005687B File Offset: 0x00054A7B
			[Register("accessibility_custom_action_17")]
			public static int AccessibilityCustomAction17
			{
				get
				{
					return R.Id._members.StaticFields.GetInt32Value("accessibility_custom_action_17.I");
				}
				set
				{
					R.Id._members.StaticFields.SetValue("accessibility_custom_action_17.I", value);
				}
			}

			// Token: 0x17000B43 RID: 2883
			// (get) Token: 0x06001F64 RID: 8036 RVA: 0x00056892 File Offset: 0x00054A92
			// (set) Token: 0x06001F65 RID: 8037 RVA: 0x000568A8 File Offset: 0x00054AA8
			[Register("accessibility_custom_action_18")]
			public static int AccessibilityCustomAction18
			{
				get
				{
					return R.Id._members.StaticFields.GetInt32Value("accessibility_custom_action_18.I");
				}
				set
				{
					R.Id._members.StaticFields.SetValue("accessibility_custom_action_18.I", value);
				}
			}

			// Token: 0x17000B44 RID: 2884
			// (get) Token: 0x06001F66 RID: 8038 RVA: 0x000568BF File Offset: 0x00054ABF
			// (set) Token: 0x06001F67 RID: 8039 RVA: 0x000568D5 File Offset: 0x00054AD5
			[Register("accessibility_custom_action_19")]
			public static int AccessibilityCustomAction19
			{
				get
				{
					return R.Id._members.StaticFields.GetInt32Value("accessibility_custom_action_19.I");
				}
				set
				{
					R.Id._members.StaticFields.SetValue("accessibility_custom_action_19.I", value);
				}
			}

			// Token: 0x17000B45 RID: 2885
			// (get) Token: 0x06001F68 RID: 8040 RVA: 0x000568EC File Offset: 0x00054AEC
			// (set) Token: 0x06001F69 RID: 8041 RVA: 0x00056902 File Offset: 0x00054B02
			[Register("accessibility_custom_action_2")]
			public static int AccessibilityCustomAction2
			{
				get
				{
					return R.Id._members.StaticFields.GetInt32Value("accessibility_custom_action_2.I");
				}
				set
				{
					R.Id._members.StaticFields.SetValue("accessibility_custom_action_2.I", value);
				}
			}

			// Token: 0x17000B46 RID: 2886
			// (get) Token: 0x06001F6A RID: 8042 RVA: 0x00056919 File Offset: 0x00054B19
			// (set) Token: 0x06001F6B RID: 8043 RVA: 0x0005692F File Offset: 0x00054B2F
			[Register("accessibility_custom_action_20")]
			public static int AccessibilityCustomAction20
			{
				get
				{
					return R.Id._members.StaticFields.GetInt32Value("accessibility_custom_action_20.I");
				}
				set
				{
					R.Id._members.StaticFields.SetValue("accessibility_custom_action_20.I", value);
				}
			}

			// Token: 0x17000B47 RID: 2887
			// (get) Token: 0x06001F6C RID: 8044 RVA: 0x00056946 File Offset: 0x00054B46
			// (set) Token: 0x06001F6D RID: 8045 RVA: 0x0005695C File Offset: 0x00054B5C
			[Register("accessibility_custom_action_21")]
			public static int AccessibilityCustomAction21
			{
				get
				{
					return R.Id._members.StaticFields.GetInt32Value("accessibility_custom_action_21.I");
				}
				set
				{
					R.Id._members.StaticFields.SetValue("accessibility_custom_action_21.I", value);
				}
			}

			// Token: 0x17000B48 RID: 2888
			// (get) Token: 0x06001F6E RID: 8046 RVA: 0x00056973 File Offset: 0x00054B73
			// (set) Token: 0x06001F6F RID: 8047 RVA: 0x00056989 File Offset: 0x00054B89
			[Register("accessibility_custom_action_22")]
			public static int AccessibilityCustomAction22
			{
				get
				{
					return R.Id._members.StaticFields.GetInt32Value("accessibility_custom_action_22.I");
				}
				set
				{
					R.Id._members.StaticFields.SetValue("accessibility_custom_action_22.I", value);
				}
			}

			// Token: 0x17000B49 RID: 2889
			// (get) Token: 0x06001F70 RID: 8048 RVA: 0x000569A0 File Offset: 0x00054BA0
			// (set) Token: 0x06001F71 RID: 8049 RVA: 0x000569B6 File Offset: 0x00054BB6
			[Register("accessibility_custom_action_23")]
			public static int AccessibilityCustomAction23
			{
				get
				{
					return R.Id._members.StaticFields.GetInt32Value("accessibility_custom_action_23.I");
				}
				set
				{
					R.Id._members.StaticFields.SetValue("accessibility_custom_action_23.I", value);
				}
			}

			// Token: 0x17000B4A RID: 2890
			// (get) Token: 0x06001F72 RID: 8050 RVA: 0x000569CD File Offset: 0x00054BCD
			// (set) Token: 0x06001F73 RID: 8051 RVA: 0x000569E3 File Offset: 0x00054BE3
			[Register("accessibility_custom_action_24")]
			public static int AccessibilityCustomAction24
			{
				get
				{
					return R.Id._members.StaticFields.GetInt32Value("accessibility_custom_action_24.I");
				}
				set
				{
					R.Id._members.StaticFields.SetValue("accessibility_custom_action_24.I", value);
				}
			}

			// Token: 0x17000B4B RID: 2891
			// (get) Token: 0x06001F74 RID: 8052 RVA: 0x000569FA File Offset: 0x00054BFA
			// (set) Token: 0x06001F75 RID: 8053 RVA: 0x00056A10 File Offset: 0x00054C10
			[Register("accessibility_custom_action_25")]
			public static int AccessibilityCustomAction25
			{
				get
				{
					return R.Id._members.StaticFields.GetInt32Value("accessibility_custom_action_25.I");
				}
				set
				{
					R.Id._members.StaticFields.SetValue("accessibility_custom_action_25.I", value);
				}
			}

			// Token: 0x17000B4C RID: 2892
			// (get) Token: 0x06001F76 RID: 8054 RVA: 0x00056A27 File Offset: 0x00054C27
			// (set) Token: 0x06001F77 RID: 8055 RVA: 0x00056A3D File Offset: 0x00054C3D
			[Register("accessibility_custom_action_26")]
			public static int AccessibilityCustomAction26
			{
				get
				{
					return R.Id._members.StaticFields.GetInt32Value("accessibility_custom_action_26.I");
				}
				set
				{
					R.Id._members.StaticFields.SetValue("accessibility_custom_action_26.I", value);
				}
			}

			// Token: 0x17000B4D RID: 2893
			// (get) Token: 0x06001F78 RID: 8056 RVA: 0x00056A54 File Offset: 0x00054C54
			// (set) Token: 0x06001F79 RID: 8057 RVA: 0x00056A6A File Offset: 0x00054C6A
			[Register("accessibility_custom_action_27")]
			public static int AccessibilityCustomAction27
			{
				get
				{
					return R.Id._members.StaticFields.GetInt32Value("accessibility_custom_action_27.I");
				}
				set
				{
					R.Id._members.StaticFields.SetValue("accessibility_custom_action_27.I", value);
				}
			}

			// Token: 0x17000B4E RID: 2894
			// (get) Token: 0x06001F7A RID: 8058 RVA: 0x00056A81 File Offset: 0x00054C81
			// (set) Token: 0x06001F7B RID: 8059 RVA: 0x00056A97 File Offset: 0x00054C97
			[Register("accessibility_custom_action_28")]
			public static int AccessibilityCustomAction28
			{
				get
				{
					return R.Id._members.StaticFields.GetInt32Value("accessibility_custom_action_28.I");
				}
				set
				{
					R.Id._members.StaticFields.SetValue("accessibility_custom_action_28.I", value);
				}
			}

			// Token: 0x17000B4F RID: 2895
			// (get) Token: 0x06001F7C RID: 8060 RVA: 0x00056AAE File Offset: 0x00054CAE
			// (set) Token: 0x06001F7D RID: 8061 RVA: 0x00056AC4 File Offset: 0x00054CC4
			[Register("accessibility_custom_action_29")]
			public static int AccessibilityCustomAction29
			{
				get
				{
					return R.Id._members.StaticFields.GetInt32Value("accessibility_custom_action_29.I");
				}
				set
				{
					R.Id._members.StaticFields.SetValue("accessibility_custom_action_29.I", value);
				}
			}

			// Token: 0x17000B50 RID: 2896
			// (get) Token: 0x06001F7E RID: 8062 RVA: 0x00056ADB File Offset: 0x00054CDB
			// (set) Token: 0x06001F7F RID: 8063 RVA: 0x00056AF1 File Offset: 0x00054CF1
			[Register("accessibility_custom_action_3")]
			public static int AccessibilityCustomAction3
			{
				get
				{
					return R.Id._members.StaticFields.GetInt32Value("accessibility_custom_action_3.I");
				}
				set
				{
					R.Id._members.StaticFields.SetValue("accessibility_custom_action_3.I", value);
				}
			}

			// Token: 0x17000B51 RID: 2897
			// (get) Token: 0x06001F80 RID: 8064 RVA: 0x00056B08 File Offset: 0x00054D08
			// (set) Token: 0x06001F81 RID: 8065 RVA: 0x00056B1E File Offset: 0x00054D1E
			[Register("accessibility_custom_action_30")]
			public static int AccessibilityCustomAction30
			{
				get
				{
					return R.Id._members.StaticFields.GetInt32Value("accessibility_custom_action_30.I");
				}
				set
				{
					R.Id._members.StaticFields.SetValue("accessibility_custom_action_30.I", value);
				}
			}

			// Token: 0x17000B52 RID: 2898
			// (get) Token: 0x06001F82 RID: 8066 RVA: 0x00056B35 File Offset: 0x00054D35
			// (set) Token: 0x06001F83 RID: 8067 RVA: 0x00056B4B File Offset: 0x00054D4B
			[Register("accessibility_custom_action_31")]
			public static int AccessibilityCustomAction31
			{
				get
				{
					return R.Id._members.StaticFields.GetInt32Value("accessibility_custom_action_31.I");
				}
				set
				{
					R.Id._members.StaticFields.SetValue("accessibility_custom_action_31.I", value);
				}
			}

			// Token: 0x17000B53 RID: 2899
			// (get) Token: 0x06001F84 RID: 8068 RVA: 0x00056B62 File Offset: 0x00054D62
			// (set) Token: 0x06001F85 RID: 8069 RVA: 0x00056B78 File Offset: 0x00054D78
			[Register("accessibility_custom_action_4")]
			public static int AccessibilityCustomAction4
			{
				get
				{
					return R.Id._members.StaticFields.GetInt32Value("accessibility_custom_action_4.I");
				}
				set
				{
					R.Id._members.StaticFields.SetValue("accessibility_custom_action_4.I", value);
				}
			}

			// Token: 0x17000B54 RID: 2900
			// (get) Token: 0x06001F86 RID: 8070 RVA: 0x00056B8F File Offset: 0x00054D8F
			// (set) Token: 0x06001F87 RID: 8071 RVA: 0x00056BA5 File Offset: 0x00054DA5
			[Register("accessibility_custom_action_5")]
			public static int AccessibilityCustomAction5
			{
				get
				{
					return R.Id._members.StaticFields.GetInt32Value("accessibility_custom_action_5.I");
				}
				set
				{
					R.Id._members.StaticFields.SetValue("accessibility_custom_action_5.I", value);
				}
			}

			// Token: 0x17000B55 RID: 2901
			// (get) Token: 0x06001F88 RID: 8072 RVA: 0x00056BBC File Offset: 0x00054DBC
			// (set) Token: 0x06001F89 RID: 8073 RVA: 0x00056BD2 File Offset: 0x00054DD2
			[Register("accessibility_custom_action_6")]
			public static int AccessibilityCustomAction6
			{
				get
				{
					return R.Id._members.StaticFields.GetInt32Value("accessibility_custom_action_6.I");
				}
				set
				{
					R.Id._members.StaticFields.SetValue("accessibility_custom_action_6.I", value);
				}
			}

			// Token: 0x17000B56 RID: 2902
			// (get) Token: 0x06001F8A RID: 8074 RVA: 0x00056BE9 File Offset: 0x00054DE9
			// (set) Token: 0x06001F8B RID: 8075 RVA: 0x00056BFF File Offset: 0x00054DFF
			[Register("accessibility_custom_action_7")]
			public static int AccessibilityCustomAction7
			{
				get
				{
					return R.Id._members.StaticFields.GetInt32Value("accessibility_custom_action_7.I");
				}
				set
				{
					R.Id._members.StaticFields.SetValue("accessibility_custom_action_7.I", value);
				}
			}

			// Token: 0x17000B57 RID: 2903
			// (get) Token: 0x06001F8C RID: 8076 RVA: 0x00056C16 File Offset: 0x00054E16
			// (set) Token: 0x06001F8D RID: 8077 RVA: 0x00056C2C File Offset: 0x00054E2C
			[Register("accessibility_custom_action_8")]
			public static int AccessibilityCustomAction8
			{
				get
				{
					return R.Id._members.StaticFields.GetInt32Value("accessibility_custom_action_8.I");
				}
				set
				{
					R.Id._members.StaticFields.SetValue("accessibility_custom_action_8.I", value);
				}
			}

			// Token: 0x17000B58 RID: 2904
			// (get) Token: 0x06001F8E RID: 8078 RVA: 0x00056C43 File Offset: 0x00054E43
			// (set) Token: 0x06001F8F RID: 8079 RVA: 0x00056C59 File Offset: 0x00054E59
			[Register("accessibility_custom_action_9")]
			public static int AccessibilityCustomAction9
			{
				get
				{
					return R.Id._members.StaticFields.GetInt32Value("accessibility_custom_action_9.I");
				}
				set
				{
					R.Id._members.StaticFields.SetValue("accessibility_custom_action_9.I", value);
				}
			}

			// Token: 0x17000B59 RID: 2905
			// (get) Token: 0x06001F90 RID: 8080 RVA: 0x00056C70 File Offset: 0x00054E70
			// (set) Token: 0x06001F91 RID: 8081 RVA: 0x00056C86 File Offset: 0x00054E86
			[Register("actions")]
			public static int Actions
			{
				get
				{
					return R.Id._members.StaticFields.GetInt32Value("actions.I");
				}
				set
				{
					R.Id._members.StaticFields.SetValue("actions.I", value);
				}
			}

			// Token: 0x17000B5A RID: 2906
			// (get) Token: 0x06001F92 RID: 8082 RVA: 0x00056C9D File Offset: 0x00054E9D
			// (set) Token: 0x06001F93 RID: 8083 RVA: 0x00056CB3 File Offset: 0x00054EB3
			[Register("action_container")]
			public static int ActionContainer
			{
				get
				{
					return R.Id._members.StaticFields.GetInt32Value("action_container.I");
				}
				set
				{
					R.Id._members.StaticFields.SetValue("action_container.I", value);
				}
			}

			// Token: 0x17000B5B RID: 2907
			// (get) Token: 0x06001F94 RID: 8084 RVA: 0x00056CCA File Offset: 0x00054ECA
			// (set) Token: 0x06001F95 RID: 8085 RVA: 0x00056CE0 File Offset: 0x00054EE0
			[Register("action_divider")]
			public static int ActionDivider
			{
				get
				{
					return R.Id._members.StaticFields.GetInt32Value("action_divider.I");
				}
				set
				{
					R.Id._members.StaticFields.SetValue("action_divider.I", value);
				}
			}

			// Token: 0x17000B5C RID: 2908
			// (get) Token: 0x06001F96 RID: 8086 RVA: 0x00056CF7 File Offset: 0x00054EF7
			// (set) Token: 0x06001F97 RID: 8087 RVA: 0x00056D0D File Offset: 0x00054F0D
			[Register("action_image")]
			public static int ActionImage
			{
				get
				{
					return R.Id._members.StaticFields.GetInt32Value("action_image.I");
				}
				set
				{
					R.Id._members.StaticFields.SetValue("action_image.I", value);
				}
			}

			// Token: 0x17000B5D RID: 2909
			// (get) Token: 0x06001F98 RID: 8088 RVA: 0x00056D24 File Offset: 0x00054F24
			// (set) Token: 0x06001F99 RID: 8089 RVA: 0x00056D3A File Offset: 0x00054F3A
			[Register("action_text")]
			public static int ActionText
			{
				get
				{
					return R.Id._members.StaticFields.GetInt32Value("action_text.I");
				}
				set
				{
					R.Id._members.StaticFields.SetValue("action_text.I", value);
				}
			}

			// Token: 0x17000B5E RID: 2910
			// (get) Token: 0x06001F9A RID: 8090 RVA: 0x00056D51 File Offset: 0x00054F51
			// (set) Token: 0x06001F9B RID: 8091 RVA: 0x00056D67 File Offset: 0x00054F67
			[Register("async")]
			public static int Async
			{
				get
				{
					return R.Id._members.StaticFields.GetInt32Value("async.I");
				}
				set
				{
					R.Id._members.StaticFields.SetValue("async.I", value);
				}
			}

			// Token: 0x17000B5F RID: 2911
			// (get) Token: 0x06001F9C RID: 8092 RVA: 0x00056D7E File Offset: 0x00054F7E
			// (set) Token: 0x06001F9D RID: 8093 RVA: 0x00056D94 File Offset: 0x00054F94
			[Register("blocking")]
			public static int Blocking
			{
				get
				{
					return R.Id._members.StaticFields.GetInt32Value("blocking.I");
				}
				set
				{
					R.Id._members.StaticFields.SetValue("blocking.I", value);
				}
			}

			// Token: 0x17000B60 RID: 2912
			// (get) Token: 0x06001F9E RID: 8094 RVA: 0x00056DAB File Offset: 0x00054FAB
			// (set) Token: 0x06001F9F RID: 8095 RVA: 0x00056DC1 File Offset: 0x00054FC1
			[Register("bottom")]
			public static int Bottom
			{
				get
				{
					return R.Id._members.StaticFields.GetInt32Value("bottom.I");
				}
				set
				{
					R.Id._members.StaticFields.SetValue("bottom.I", value);
				}
			}

			// Token: 0x17000B61 RID: 2913
			// (get) Token: 0x06001FA0 RID: 8096 RVA: 0x00056DD8 File Offset: 0x00054FD8
			// (set) Token: 0x06001FA1 RID: 8097 RVA: 0x00056DEE File Offset: 0x00054FEE
			[Register("browser_actions_header_text")]
			public static int BrowserActionsHeaderText
			{
				get
				{
					return R.Id._members.StaticFields.GetInt32Value("browser_actions_header_text.I");
				}
				set
				{
					R.Id._members.StaticFields.SetValue("browser_actions_header_text.I", value);
				}
			}

			// Token: 0x17000B62 RID: 2914
			// (get) Token: 0x06001FA2 RID: 8098 RVA: 0x00056E05 File Offset: 0x00055005
			// (set) Token: 0x06001FA3 RID: 8099 RVA: 0x00056E1B File Offset: 0x0005501B
			[Register("browser_actions_menu_items")]
			public static int BrowserActionsMenuItems
			{
				get
				{
					return R.Id._members.StaticFields.GetInt32Value("browser_actions_menu_items.I");
				}
				set
				{
					R.Id._members.StaticFields.SetValue("browser_actions_menu_items.I", value);
				}
			}

			// Token: 0x17000B63 RID: 2915
			// (get) Token: 0x06001FA4 RID: 8100 RVA: 0x00056E32 File Offset: 0x00055032
			// (set) Token: 0x06001FA5 RID: 8101 RVA: 0x00056E48 File Offset: 0x00055048
			[Register("browser_actions_menu_item_icon")]
			public static int BrowserActionsMenuItemIcon
			{
				get
				{
					return R.Id._members.StaticFields.GetInt32Value("browser_actions_menu_item_icon.I");
				}
				set
				{
					R.Id._members.StaticFields.SetValue("browser_actions_menu_item_icon.I", value);
				}
			}

			// Token: 0x17000B64 RID: 2916
			// (get) Token: 0x06001FA6 RID: 8102 RVA: 0x00056E5F File Offset: 0x0005505F
			// (set) Token: 0x06001FA7 RID: 8103 RVA: 0x00056E75 File Offset: 0x00055075
			[Register("browser_actions_menu_item_text")]
			public static int BrowserActionsMenuItemText
			{
				get
				{
					return R.Id._members.StaticFields.GetInt32Value("browser_actions_menu_item_text.I");
				}
				set
				{
					R.Id._members.StaticFields.SetValue("browser_actions_menu_item_text.I", value);
				}
			}

			// Token: 0x17000B65 RID: 2917
			// (get) Token: 0x06001FA8 RID: 8104 RVA: 0x00056E8C File Offset: 0x0005508C
			// (set) Token: 0x06001FA9 RID: 8105 RVA: 0x00056EA2 File Offset: 0x000550A2
			[Register("browser_actions_menu_view")]
			public static int BrowserActionsMenuView
			{
				get
				{
					return R.Id._members.StaticFields.GetInt32Value("browser_actions_menu_view.I");
				}
				set
				{
					R.Id._members.StaticFields.SetValue("browser_actions_menu_view.I", value);
				}
			}

			// Token: 0x17000B66 RID: 2918
			// (get) Token: 0x06001FAA RID: 8106 RVA: 0x00056EB9 File Offset: 0x000550B9
			// (set) Token: 0x06001FAB RID: 8107 RVA: 0x00056ECF File Offset: 0x000550CF
			[Register("chronometer")]
			public static int Chronometer
			{
				get
				{
					return R.Id._members.StaticFields.GetInt32Value("chronometer.I");
				}
				set
				{
					R.Id._members.StaticFields.SetValue("chronometer.I", value);
				}
			}

			// Token: 0x17000B67 RID: 2919
			// (get) Token: 0x06001FAC RID: 8108 RVA: 0x00056EE6 File Offset: 0x000550E6
			// (set) Token: 0x06001FAD RID: 8109 RVA: 0x00056EFC File Offset: 0x000550FC
			[Register("dialog_button")]
			public static int DialogButton
			{
				get
				{
					return R.Id._members.StaticFields.GetInt32Value("dialog_button.I");
				}
				set
				{
					R.Id._members.StaticFields.SetValue("dialog_button.I", value);
				}
			}

			// Token: 0x17000B68 RID: 2920
			// (get) Token: 0x06001FAE RID: 8110 RVA: 0x00056F13 File Offset: 0x00055113
			// (set) Token: 0x06001FAF RID: 8111 RVA: 0x00056F29 File Offset: 0x00055129
			[Register("end")]
			public static int End
			{
				get
				{
					return R.Id._members.StaticFields.GetInt32Value("end.I");
				}
				set
				{
					R.Id._members.StaticFields.SetValue("end.I", value);
				}
			}

			// Token: 0x17000B69 RID: 2921
			// (get) Token: 0x06001FB0 RID: 8112 RVA: 0x00056F40 File Offset: 0x00055140
			// (set) Token: 0x06001FB1 RID: 8113 RVA: 0x00056F56 File Offset: 0x00055156
			[Register("forever")]
			public static int Forever
			{
				get
				{
					return R.Id._members.StaticFields.GetInt32Value("forever.I");
				}
				set
				{
					R.Id._members.StaticFields.SetValue("forever.I", value);
				}
			}

			// Token: 0x17000B6A RID: 2922
			// (get) Token: 0x06001FB2 RID: 8114 RVA: 0x00056F6D File Offset: 0x0005516D
			// (set) Token: 0x06001FB3 RID: 8115 RVA: 0x00056F83 File Offset: 0x00055183
			[Register("icon")]
			public static int Icon
			{
				get
				{
					return R.Id._members.StaticFields.GetInt32Value("icon.I");
				}
				set
				{
					R.Id._members.StaticFields.SetValue("icon.I", value);
				}
			}

			// Token: 0x17000B6B RID: 2923
			// (get) Token: 0x06001FB4 RID: 8116 RVA: 0x00056F9A File Offset: 0x0005519A
			// (set) Token: 0x06001FB5 RID: 8117 RVA: 0x00056FB0 File Offset: 0x000551B0
			[Register("icon_group")]
			public static int IconGroup
			{
				get
				{
					return R.Id._members.StaticFields.GetInt32Value("icon_group.I");
				}
				set
				{
					R.Id._members.StaticFields.SetValue("icon_group.I", value);
				}
			}

			// Token: 0x17000B6C RID: 2924
			// (get) Token: 0x06001FB6 RID: 8118 RVA: 0x00056FC7 File Offset: 0x000551C7
			// (set) Token: 0x06001FB7 RID: 8119 RVA: 0x00056FDD File Offset: 0x000551DD
			[Register("info")]
			public static int Info
			{
				get
				{
					return R.Id._members.StaticFields.GetInt32Value("info.I");
				}
				set
				{
					R.Id._members.StaticFields.SetValue("info.I", value);
				}
			}

			// Token: 0x17000B6D RID: 2925
			// (get) Token: 0x06001FB8 RID: 8120 RVA: 0x00056FF4 File Offset: 0x000551F4
			// (set) Token: 0x06001FB9 RID: 8121 RVA: 0x0005700A File Offset: 0x0005520A
			[Register("italic")]
			public static int Italic
			{
				get
				{
					return R.Id._members.StaticFields.GetInt32Value("italic.I");
				}
				set
				{
					R.Id._members.StaticFields.SetValue("italic.I", value);
				}
			}

			// Token: 0x17000B6E RID: 2926
			// (get) Token: 0x06001FBA RID: 8122 RVA: 0x00057021 File Offset: 0x00055221
			// (set) Token: 0x06001FBB RID: 8123 RVA: 0x00057037 File Offset: 0x00055237
			[Register("left")]
			public static int Left
			{
				get
				{
					return R.Id._members.StaticFields.GetInt32Value("left.I");
				}
				set
				{
					R.Id._members.StaticFields.SetValue("left.I", value);
				}
			}

			// Token: 0x17000B6F RID: 2927
			// (get) Token: 0x06001FBC RID: 8124 RVA: 0x0005704E File Offset: 0x0005524E
			// (set) Token: 0x06001FBD RID: 8125 RVA: 0x00057064 File Offset: 0x00055264
			[Register("line1")]
			public static int Line1
			{
				get
				{
					return R.Id._members.StaticFields.GetInt32Value("line1.I");
				}
				set
				{
					R.Id._members.StaticFields.SetValue("line1.I", value);
				}
			}

			// Token: 0x17000B70 RID: 2928
			// (get) Token: 0x06001FBE RID: 8126 RVA: 0x0005707B File Offset: 0x0005527B
			// (set) Token: 0x06001FBF RID: 8127 RVA: 0x00057091 File Offset: 0x00055291
			[Register("line3")]
			public static int Line3
			{
				get
				{
					return R.Id._members.StaticFields.GetInt32Value("line3.I");
				}
				set
				{
					R.Id._members.StaticFields.SetValue("line3.I", value);
				}
			}

			// Token: 0x17000B71 RID: 2929
			// (get) Token: 0x06001FC0 RID: 8128 RVA: 0x000570A8 File Offset: 0x000552A8
			// (set) Token: 0x06001FC1 RID: 8129 RVA: 0x000570BE File Offset: 0x000552BE
			[Register("none")]
			public static int None
			{
				get
				{
					return R.Id._members.StaticFields.GetInt32Value("none.I");
				}
				set
				{
					R.Id._members.StaticFields.SetValue("none.I", value);
				}
			}

			// Token: 0x17000B72 RID: 2930
			// (get) Token: 0x06001FC2 RID: 8130 RVA: 0x000570D5 File Offset: 0x000552D5
			// (set) Token: 0x06001FC3 RID: 8131 RVA: 0x000570EB File Offset: 0x000552EB
			[Register("normal")]
			public static int Normal
			{
				get
				{
					return R.Id._members.StaticFields.GetInt32Value("normal.I");
				}
				set
				{
					R.Id._members.StaticFields.SetValue("normal.I", value);
				}
			}

			// Token: 0x17000B73 RID: 2931
			// (get) Token: 0x06001FC4 RID: 8132 RVA: 0x00057102 File Offset: 0x00055302
			// (set) Token: 0x06001FC5 RID: 8133 RVA: 0x00057118 File Offset: 0x00055318
			[Register("notification_background")]
			public static int NotificationBackground
			{
				get
				{
					return R.Id._members.StaticFields.GetInt32Value("notification_background.I");
				}
				set
				{
					R.Id._members.StaticFields.SetValue("notification_background.I", value);
				}
			}

			// Token: 0x17000B74 RID: 2932
			// (get) Token: 0x06001FC6 RID: 8134 RVA: 0x0005712F File Offset: 0x0005532F
			// (set) Token: 0x06001FC7 RID: 8135 RVA: 0x00057145 File Offset: 0x00055345
			[Register("notification_main_column")]
			public static int NotificationMainColumn
			{
				get
				{
					return R.Id._members.StaticFields.GetInt32Value("notification_main_column.I");
				}
				set
				{
					R.Id._members.StaticFields.SetValue("notification_main_column.I", value);
				}
			}

			// Token: 0x17000B75 RID: 2933
			// (get) Token: 0x06001FC8 RID: 8136 RVA: 0x0005715C File Offset: 0x0005535C
			// (set) Token: 0x06001FC9 RID: 8137 RVA: 0x00057172 File Offset: 0x00055372
			[Register("notification_main_column_container")]
			public static int NotificationMainColumnContainer
			{
				get
				{
					return R.Id._members.StaticFields.GetInt32Value("notification_main_column_container.I");
				}
				set
				{
					R.Id._members.StaticFields.SetValue("notification_main_column_container.I", value);
				}
			}

			// Token: 0x17000B76 RID: 2934
			// (get) Token: 0x06001FCA RID: 8138 RVA: 0x00057189 File Offset: 0x00055389
			// (set) Token: 0x06001FCB RID: 8139 RVA: 0x0005719F File Offset: 0x0005539F
			[Register("right")]
			public static int Right
			{
				get
				{
					return R.Id._members.StaticFields.GetInt32Value("right.I");
				}
				set
				{
					R.Id._members.StaticFields.SetValue("right.I", value);
				}
			}

			// Token: 0x17000B77 RID: 2935
			// (get) Token: 0x06001FCC RID: 8140 RVA: 0x000571B6 File Offset: 0x000553B6
			// (set) Token: 0x06001FCD RID: 8141 RVA: 0x000571CC File Offset: 0x000553CC
			[Register("right_icon")]
			public static int RightIcon
			{
				get
				{
					return R.Id._members.StaticFields.GetInt32Value("right_icon.I");
				}
				set
				{
					R.Id._members.StaticFields.SetValue("right_icon.I", value);
				}
			}

			// Token: 0x17000B78 RID: 2936
			// (get) Token: 0x06001FCE RID: 8142 RVA: 0x000571E3 File Offset: 0x000553E3
			// (set) Token: 0x06001FCF RID: 8143 RVA: 0x000571F9 File Offset: 0x000553F9
			[Register("right_side")]
			public static int RightSide
			{
				get
				{
					return R.Id._members.StaticFields.GetInt32Value("right_side.I");
				}
				set
				{
					R.Id._members.StaticFields.SetValue("right_side.I", value);
				}
			}

			// Token: 0x17000B79 RID: 2937
			// (get) Token: 0x06001FD0 RID: 8144 RVA: 0x00057210 File Offset: 0x00055410
			// (set) Token: 0x06001FD1 RID: 8145 RVA: 0x00057226 File Offset: 0x00055426
			[Register("start")]
			public static int Start
			{
				get
				{
					return R.Id._members.StaticFields.GetInt32Value("start.I");
				}
				set
				{
					R.Id._members.StaticFields.SetValue("start.I", value);
				}
			}

			// Token: 0x17000B7A RID: 2938
			// (get) Token: 0x06001FD2 RID: 8146 RVA: 0x0005723D File Offset: 0x0005543D
			// (set) Token: 0x06001FD3 RID: 8147 RVA: 0x00057253 File Offset: 0x00055453
			[Register("tag_accessibility_actions")]
			public static int TagAccessibilityActions
			{
				get
				{
					return R.Id._members.StaticFields.GetInt32Value("tag_accessibility_actions.I");
				}
				set
				{
					R.Id._members.StaticFields.SetValue("tag_accessibility_actions.I", value);
				}
			}

			// Token: 0x17000B7B RID: 2939
			// (get) Token: 0x06001FD4 RID: 8148 RVA: 0x0005726A File Offset: 0x0005546A
			// (set) Token: 0x06001FD5 RID: 8149 RVA: 0x00057280 File Offset: 0x00055480
			[Register("tag_accessibility_clickable_spans")]
			public static int TagAccessibilityClickableSpans
			{
				get
				{
					return R.Id._members.StaticFields.GetInt32Value("tag_accessibility_clickable_spans.I");
				}
				set
				{
					R.Id._members.StaticFields.SetValue("tag_accessibility_clickable_spans.I", value);
				}
			}

			// Token: 0x17000B7C RID: 2940
			// (get) Token: 0x06001FD6 RID: 8150 RVA: 0x00057297 File Offset: 0x00055497
			// (set) Token: 0x06001FD7 RID: 8151 RVA: 0x000572AD File Offset: 0x000554AD
			[Register("tag_accessibility_heading")]
			public static int TagAccessibilityHeading
			{
				get
				{
					return R.Id._members.StaticFields.GetInt32Value("tag_accessibility_heading.I");
				}
				set
				{
					R.Id._members.StaticFields.SetValue("tag_accessibility_heading.I", value);
				}
			}

			// Token: 0x17000B7D RID: 2941
			// (get) Token: 0x06001FD8 RID: 8152 RVA: 0x000572C4 File Offset: 0x000554C4
			// (set) Token: 0x06001FD9 RID: 8153 RVA: 0x000572DA File Offset: 0x000554DA
			[Register("tag_accessibility_pane_title")]
			public static int TagAccessibilityPaneTitle
			{
				get
				{
					return R.Id._members.StaticFields.GetInt32Value("tag_accessibility_pane_title.I");
				}
				set
				{
					R.Id._members.StaticFields.SetValue("tag_accessibility_pane_title.I", value);
				}
			}

			// Token: 0x17000B7E RID: 2942
			// (get) Token: 0x06001FDA RID: 8154 RVA: 0x000572F1 File Offset: 0x000554F1
			// (set) Token: 0x06001FDB RID: 8155 RVA: 0x00057307 File Offset: 0x00055507
			[Register("tag_screen_reader_focusable")]
			public static int TagScreenReaderFocusable
			{
				get
				{
					return R.Id._members.StaticFields.GetInt32Value("tag_screen_reader_focusable.I");
				}
				set
				{
					R.Id._members.StaticFields.SetValue("tag_screen_reader_focusable.I", value);
				}
			}

			// Token: 0x17000B7F RID: 2943
			// (get) Token: 0x06001FDC RID: 8156 RVA: 0x0005731E File Offset: 0x0005551E
			// (set) Token: 0x06001FDD RID: 8157 RVA: 0x00057334 File Offset: 0x00055534
			[Register("tag_transition_group")]
			public static int TagTransitionGroup
			{
				get
				{
					return R.Id._members.StaticFields.GetInt32Value("tag_transition_group.I");
				}
				set
				{
					R.Id._members.StaticFields.SetValue("tag_transition_group.I", value);
				}
			}

			// Token: 0x17000B80 RID: 2944
			// (get) Token: 0x06001FDE RID: 8158 RVA: 0x0005734B File Offset: 0x0005554B
			// (set) Token: 0x06001FDF RID: 8159 RVA: 0x00057361 File Offset: 0x00055561
			[Register("tag_unhandled_key_event_manager")]
			public static int TagUnhandledKeyEventManager
			{
				get
				{
					return R.Id._members.StaticFields.GetInt32Value("tag_unhandled_key_event_manager.I");
				}
				set
				{
					R.Id._members.StaticFields.SetValue("tag_unhandled_key_event_manager.I", value);
				}
			}

			// Token: 0x17000B81 RID: 2945
			// (get) Token: 0x06001FE0 RID: 8160 RVA: 0x00057378 File Offset: 0x00055578
			// (set) Token: 0x06001FE1 RID: 8161 RVA: 0x0005738E File Offset: 0x0005558E
			[Register("tag_unhandled_key_listeners")]
			public static int TagUnhandledKeyListeners
			{
				get
				{
					return R.Id._members.StaticFields.GetInt32Value("tag_unhandled_key_listeners.I");
				}
				set
				{
					R.Id._members.StaticFields.SetValue("tag_unhandled_key_listeners.I", value);
				}
			}

			// Token: 0x17000B82 RID: 2946
			// (get) Token: 0x06001FE2 RID: 8162 RVA: 0x000573A5 File Offset: 0x000555A5
			// (set) Token: 0x06001FE3 RID: 8163 RVA: 0x000573BB File Offset: 0x000555BB
			[Register("text")]
			public static int Text
			{
				get
				{
					return R.Id._members.StaticFields.GetInt32Value("text.I");
				}
				set
				{
					R.Id._members.StaticFields.SetValue("text.I", value);
				}
			}

			// Token: 0x17000B83 RID: 2947
			// (get) Token: 0x06001FE4 RID: 8164 RVA: 0x000573D2 File Offset: 0x000555D2
			// (set) Token: 0x06001FE5 RID: 8165 RVA: 0x000573E8 File Offset: 0x000555E8
			[Register("text2")]
			public static int Text2
			{
				get
				{
					return R.Id._members.StaticFields.GetInt32Value("text2.I");
				}
				set
				{
					R.Id._members.StaticFields.SetValue("text2.I", value);
				}
			}

			// Token: 0x17000B84 RID: 2948
			// (get) Token: 0x06001FE6 RID: 8166 RVA: 0x000573FF File Offset: 0x000555FF
			// (set) Token: 0x06001FE7 RID: 8167 RVA: 0x00057415 File Offset: 0x00055615
			[Register("time")]
			public static int Time
			{
				get
				{
					return R.Id._members.StaticFields.GetInt32Value("time.I");
				}
				set
				{
					R.Id._members.StaticFields.SetValue("time.I", value);
				}
			}

			// Token: 0x17000B85 RID: 2949
			// (get) Token: 0x06001FE8 RID: 8168 RVA: 0x0005742C File Offset: 0x0005562C
			// (set) Token: 0x06001FE9 RID: 8169 RVA: 0x00057442 File Offset: 0x00055642
			[Register("title")]
			public static int Title
			{
				get
				{
					return R.Id._members.StaticFields.GetInt32Value("title.I");
				}
				set
				{
					R.Id._members.StaticFields.SetValue("title.I", value);
				}
			}

			// Token: 0x17000B86 RID: 2950
			// (get) Token: 0x06001FEA RID: 8170 RVA: 0x00057459 File Offset: 0x00055659
			// (set) Token: 0x06001FEB RID: 8171 RVA: 0x0005746F File Offset: 0x0005566F
			[Register("top")]
			public static int Top
			{
				get
				{
					return R.Id._members.StaticFields.GetInt32Value("top.I");
				}
				set
				{
					R.Id._members.StaticFields.SetValue("top.I", value);
				}
			}

			// Token: 0x17000B87 RID: 2951
			// (get) Token: 0x06001FEC RID: 8172 RVA: 0x00057488 File Offset: 0x00055688
			internal static IntPtr class_ref
			{
				get
				{
					return R.Id._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x17000B88 RID: 2952
			// (get) Token: 0x06001FED RID: 8173 RVA: 0x000574AC File Offset: 0x000556AC
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return R.Id._members;
				}
			}

			// Token: 0x17000B89 RID: 2953
			// (get) Token: 0x06001FEE RID: 8174 RVA: 0x000574B4 File Offset: 0x000556B4
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return R.Id._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x17000B8A RID: 2954
			// (get) Token: 0x06001FEF RID: 8175 RVA: 0x000574D8 File Offset: 0x000556D8
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return R.Id._members.ManagedPeerType;
				}
			}

			// Token: 0x06001FF0 RID: 8176 RVA: 0x000021E8 File Offset: 0x000003E8
			internal Id(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
			{
			}

			// Token: 0x040006ED RID: 1773
			private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/scar/adapter/v2000/R$id", typeof(R.Id));
		}

		// Token: 0x02000256 RID: 598
		[Register("com/unity3d/scar/adapter/v2000/R$integer", DoNotGenerateAcw = true)]
		public sealed class Integer : Java.Lang.Object
		{
			// Token: 0x17000B8B RID: 2955
			// (get) Token: 0x06001FF2 RID: 8178 RVA: 0x000574FF File Offset: 0x000556FF
			// (set) Token: 0x06001FF3 RID: 8179 RVA: 0x00057515 File Offset: 0x00055715
			[Register("google_play_services_version")]
			public static int GooglePlayServicesVersion
			{
				get
				{
					return R.Integer._members.StaticFields.GetInt32Value("google_play_services_version.I");
				}
				set
				{
					R.Integer._members.StaticFields.SetValue("google_play_services_version.I", value);
				}
			}

			// Token: 0x17000B8C RID: 2956
			// (get) Token: 0x06001FF4 RID: 8180 RVA: 0x0005752C File Offset: 0x0005572C
			// (set) Token: 0x06001FF5 RID: 8181 RVA: 0x00057542 File Offset: 0x00055742
			[Register("status_bar_notification_info_maxnum")]
			public static int StatusBarNotificationInfoMaxnum
			{
				get
				{
					return R.Integer._members.StaticFields.GetInt32Value("status_bar_notification_info_maxnum.I");
				}
				set
				{
					R.Integer._members.StaticFields.SetValue("status_bar_notification_info_maxnum.I", value);
				}
			}

			// Token: 0x17000B8D RID: 2957
			// (get) Token: 0x06001FF6 RID: 8182 RVA: 0x0005755C File Offset: 0x0005575C
			internal static IntPtr class_ref
			{
				get
				{
					return R.Integer._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x17000B8E RID: 2958
			// (get) Token: 0x06001FF7 RID: 8183 RVA: 0x00057580 File Offset: 0x00055780
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return R.Integer._members;
				}
			}

			// Token: 0x17000B8F RID: 2959
			// (get) Token: 0x06001FF8 RID: 8184 RVA: 0x00057588 File Offset: 0x00055788
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return R.Integer._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x17000B90 RID: 2960
			// (get) Token: 0x06001FF9 RID: 8185 RVA: 0x000575AC File Offset: 0x000557AC
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return R.Integer._members.ManagedPeerType;
				}
			}

			// Token: 0x06001FFA RID: 8186 RVA: 0x000021E8 File Offset: 0x000003E8
			internal Integer(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
			{
			}

			// Token: 0x040006EE RID: 1774
			private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/scar/adapter/v2000/R$integer", typeof(R.Integer));
		}

		// Token: 0x02000257 RID: 599
		[Register("com/unity3d/scar/adapter/v2000/R$layout", DoNotGenerateAcw = true)]
		public sealed class Layout : Java.Lang.Object
		{
			// Token: 0x17000B91 RID: 2961
			// (get) Token: 0x06001FFC RID: 8188 RVA: 0x000575D3 File Offset: 0x000557D3
			// (set) Token: 0x06001FFD RID: 8189 RVA: 0x000575E9 File Offset: 0x000557E9
			[Register("browser_actions_context_menu_page")]
			public static int BrowserActionsContextMenuPage
			{
				get
				{
					return R.Layout._members.StaticFields.GetInt32Value("browser_actions_context_menu_page.I");
				}
				set
				{
					R.Layout._members.StaticFields.SetValue("browser_actions_context_menu_page.I", value);
				}
			}

			// Token: 0x17000B92 RID: 2962
			// (get) Token: 0x06001FFE RID: 8190 RVA: 0x00057600 File Offset: 0x00055800
			// (set) Token: 0x06001FFF RID: 8191 RVA: 0x00057616 File Offset: 0x00055816
			[Register("browser_actions_context_menu_row")]
			public static int BrowserActionsContextMenuRow
			{
				get
				{
					return R.Layout._members.StaticFields.GetInt32Value("browser_actions_context_menu_row.I");
				}
				set
				{
					R.Layout._members.StaticFields.SetValue("browser_actions_context_menu_row.I", value);
				}
			}

			// Token: 0x17000B93 RID: 2963
			// (get) Token: 0x06002000 RID: 8192 RVA: 0x0005762D File Offset: 0x0005582D
			// (set) Token: 0x06002001 RID: 8193 RVA: 0x00057643 File Offset: 0x00055843
			[Register("custom_dialog")]
			public static int CustomDialog
			{
				get
				{
					return R.Layout._members.StaticFields.GetInt32Value("custom_dialog.I");
				}
				set
				{
					R.Layout._members.StaticFields.SetValue("custom_dialog.I", value);
				}
			}

			// Token: 0x17000B94 RID: 2964
			// (get) Token: 0x06002002 RID: 8194 RVA: 0x0005765A File Offset: 0x0005585A
			// (set) Token: 0x06002003 RID: 8195 RVA: 0x00057670 File Offset: 0x00055870
			[Register("notification_action")]
			public static int NotificationAction
			{
				get
				{
					return R.Layout._members.StaticFields.GetInt32Value("notification_action.I");
				}
				set
				{
					R.Layout._members.StaticFields.SetValue("notification_action.I", value);
				}
			}

			// Token: 0x17000B95 RID: 2965
			// (get) Token: 0x06002004 RID: 8196 RVA: 0x00057687 File Offset: 0x00055887
			// (set) Token: 0x06002005 RID: 8197 RVA: 0x0005769D File Offset: 0x0005589D
			[Register("notification_action_tombstone")]
			public static int NotificationActionTombstone
			{
				get
				{
					return R.Layout._members.StaticFields.GetInt32Value("notification_action_tombstone.I");
				}
				set
				{
					R.Layout._members.StaticFields.SetValue("notification_action_tombstone.I", value);
				}
			}

			// Token: 0x17000B96 RID: 2966
			// (get) Token: 0x06002006 RID: 8198 RVA: 0x000576B4 File Offset: 0x000558B4
			// (set) Token: 0x06002007 RID: 8199 RVA: 0x000576CA File Offset: 0x000558CA
			[Register("notification_template_custom_big")]
			public static int NotificationTemplateCustomBig
			{
				get
				{
					return R.Layout._members.StaticFields.GetInt32Value("notification_template_custom_big.I");
				}
				set
				{
					R.Layout._members.StaticFields.SetValue("notification_template_custom_big.I", value);
				}
			}

			// Token: 0x17000B97 RID: 2967
			// (get) Token: 0x06002008 RID: 8200 RVA: 0x000576E1 File Offset: 0x000558E1
			// (set) Token: 0x06002009 RID: 8201 RVA: 0x000576F7 File Offset: 0x000558F7
			[Register("notification_template_icon_group")]
			public static int NotificationTemplateIconGroup
			{
				get
				{
					return R.Layout._members.StaticFields.GetInt32Value("notification_template_icon_group.I");
				}
				set
				{
					R.Layout._members.StaticFields.SetValue("notification_template_icon_group.I", value);
				}
			}

			// Token: 0x17000B98 RID: 2968
			// (get) Token: 0x0600200A RID: 8202 RVA: 0x0005770E File Offset: 0x0005590E
			// (set) Token: 0x0600200B RID: 8203 RVA: 0x00057724 File Offset: 0x00055924
			[Register("notification_template_part_chronometer")]
			public static int NotificationTemplatePartChronometer
			{
				get
				{
					return R.Layout._members.StaticFields.GetInt32Value("notification_template_part_chronometer.I");
				}
				set
				{
					R.Layout._members.StaticFields.SetValue("notification_template_part_chronometer.I", value);
				}
			}

			// Token: 0x17000B99 RID: 2969
			// (get) Token: 0x0600200C RID: 8204 RVA: 0x0005773B File Offset: 0x0005593B
			// (set) Token: 0x0600200D RID: 8205 RVA: 0x00057751 File Offset: 0x00055951
			[Register("notification_template_part_time")]
			public static int NotificationTemplatePartTime
			{
				get
				{
					return R.Layout._members.StaticFields.GetInt32Value("notification_template_part_time.I");
				}
				set
				{
					R.Layout._members.StaticFields.SetValue("notification_template_part_time.I", value);
				}
			}

			// Token: 0x17000B9A RID: 2970
			// (get) Token: 0x0600200E RID: 8206 RVA: 0x00057768 File Offset: 0x00055968
			internal static IntPtr class_ref
			{
				get
				{
					return R.Layout._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x17000B9B RID: 2971
			// (get) Token: 0x0600200F RID: 8207 RVA: 0x0005778C File Offset: 0x0005598C
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return R.Layout._members;
				}
			}

			// Token: 0x17000B9C RID: 2972
			// (get) Token: 0x06002010 RID: 8208 RVA: 0x00057794 File Offset: 0x00055994
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return R.Layout._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x17000B9D RID: 2973
			// (get) Token: 0x06002011 RID: 8209 RVA: 0x000577B8 File Offset: 0x000559B8
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return R.Layout._members.ManagedPeerType;
				}
			}

			// Token: 0x06002012 RID: 8210 RVA: 0x000021E8 File Offset: 0x000003E8
			internal Layout(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
			{
			}

			// Token: 0x040006EF RID: 1775
			private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/scar/adapter/v2000/R$layout", typeof(R.Layout));
		}

		// Token: 0x02000258 RID: 600
		[Register("com/unity3d/scar/adapter/v2000/R$string", DoNotGenerateAcw = true)]
		public sealed class String : Java.Lang.Object
		{
			// Token: 0x17000B9E RID: 2974
			// (get) Token: 0x06002014 RID: 8212 RVA: 0x000577DF File Offset: 0x000559DF
			// (set) Token: 0x06002015 RID: 8213 RVA: 0x000577F5 File Offset: 0x000559F5
			[Register("common_google_play_services_unknown_issue")]
			public static int CommonGooglePlayServicesUnknownIssue
			{
				get
				{
					return R.String._members.StaticFields.GetInt32Value("common_google_play_services_unknown_issue.I");
				}
				set
				{
					R.String._members.StaticFields.SetValue("common_google_play_services_unknown_issue.I", value);
				}
			}

			// Token: 0x17000B9F RID: 2975
			// (get) Token: 0x06002016 RID: 8214 RVA: 0x0005780C File Offset: 0x00055A0C
			// (set) Token: 0x06002017 RID: 8215 RVA: 0x00057822 File Offset: 0x00055A22
			[Register("offline_notification_text")]
			public static int OfflineNotificationText
			{
				get
				{
					return R.String._members.StaticFields.GetInt32Value("offline_notification_text.I");
				}
				set
				{
					R.String._members.StaticFields.SetValue("offline_notification_text.I", value);
				}
			}

			// Token: 0x17000BA0 RID: 2976
			// (get) Token: 0x06002018 RID: 8216 RVA: 0x00057839 File Offset: 0x00055A39
			// (set) Token: 0x06002019 RID: 8217 RVA: 0x0005784F File Offset: 0x00055A4F
			[Register("offline_notification_title")]
			public static int OfflineNotificationTitle
			{
				get
				{
					return R.String._members.StaticFields.GetInt32Value("offline_notification_title.I");
				}
				set
				{
					R.String._members.StaticFields.SetValue("offline_notification_title.I", value);
				}
			}

			// Token: 0x17000BA1 RID: 2977
			// (get) Token: 0x0600201A RID: 8218 RVA: 0x00057866 File Offset: 0x00055A66
			// (set) Token: 0x0600201B RID: 8219 RVA: 0x0005787C File Offset: 0x00055A7C
			[Register("offline_opt_in_confirm")]
			public static int OfflineOptInConfirm
			{
				get
				{
					return R.String._members.StaticFields.GetInt32Value("offline_opt_in_confirm.I");
				}
				set
				{
					R.String._members.StaticFields.SetValue("offline_opt_in_confirm.I", value);
				}
			}

			// Token: 0x17000BA2 RID: 2978
			// (get) Token: 0x0600201C RID: 8220 RVA: 0x00057893 File Offset: 0x00055A93
			// (set) Token: 0x0600201D RID: 8221 RVA: 0x000578A9 File Offset: 0x00055AA9
			[Register("offline_opt_in_confirmation")]
			public static int OfflineOptInConfirmation
			{
				get
				{
					return R.String._members.StaticFields.GetInt32Value("offline_opt_in_confirmation.I");
				}
				set
				{
					R.String._members.StaticFields.SetValue("offline_opt_in_confirmation.I", value);
				}
			}

			// Token: 0x17000BA3 RID: 2979
			// (get) Token: 0x0600201E RID: 8222 RVA: 0x000578C0 File Offset: 0x00055AC0
			// (set) Token: 0x0600201F RID: 8223 RVA: 0x000578D6 File Offset: 0x00055AD6
			[Register("offline_opt_in_decline")]
			public static int OfflineOptInDecline
			{
				get
				{
					return R.String._members.StaticFields.GetInt32Value("offline_opt_in_decline.I");
				}
				set
				{
					R.String._members.StaticFields.SetValue("offline_opt_in_decline.I", value);
				}
			}

			// Token: 0x17000BA4 RID: 2980
			// (get) Token: 0x06002020 RID: 8224 RVA: 0x000578ED File Offset: 0x00055AED
			// (set) Token: 0x06002021 RID: 8225 RVA: 0x00057903 File Offset: 0x00055B03
			[Register("offline_opt_in_message")]
			public static int OfflineOptInMessage
			{
				get
				{
					return R.String._members.StaticFields.GetInt32Value("offline_opt_in_message.I");
				}
				set
				{
					R.String._members.StaticFields.SetValue("offline_opt_in_message.I", value);
				}
			}

			// Token: 0x17000BA5 RID: 2981
			// (get) Token: 0x06002022 RID: 8226 RVA: 0x0005791A File Offset: 0x00055B1A
			// (set) Token: 0x06002023 RID: 8227 RVA: 0x00057930 File Offset: 0x00055B30
			[Register("offline_opt_in_title")]
			public static int OfflineOptInTitle
			{
				get
				{
					return R.String._members.StaticFields.GetInt32Value("offline_opt_in_title.I");
				}
				set
				{
					R.String._members.StaticFields.SetValue("offline_opt_in_title.I", value);
				}
			}

			// Token: 0x17000BA6 RID: 2982
			// (get) Token: 0x06002024 RID: 8228 RVA: 0x00057947 File Offset: 0x00055B47
			// (set) Token: 0x06002025 RID: 8229 RVA: 0x0005795D File Offset: 0x00055B5D
			[Register("s1")]
			public static int S1
			{
				get
				{
					return R.String._members.StaticFields.GetInt32Value("s1.I");
				}
				set
				{
					R.String._members.StaticFields.SetValue("s1.I", value);
				}
			}

			// Token: 0x17000BA7 RID: 2983
			// (get) Token: 0x06002026 RID: 8230 RVA: 0x00057974 File Offset: 0x00055B74
			// (set) Token: 0x06002027 RID: 8231 RVA: 0x0005798A File Offset: 0x00055B8A
			[Register("s2")]
			public static int S2
			{
				get
				{
					return R.String._members.StaticFields.GetInt32Value("s2.I");
				}
				set
				{
					R.String._members.StaticFields.SetValue("s2.I", value);
				}
			}

			// Token: 0x17000BA8 RID: 2984
			// (get) Token: 0x06002028 RID: 8232 RVA: 0x000579A1 File Offset: 0x00055BA1
			// (set) Token: 0x06002029 RID: 8233 RVA: 0x000579B7 File Offset: 0x00055BB7
			[Register("s3")]
			public static int S3
			{
				get
				{
					return R.String._members.StaticFields.GetInt32Value("s3.I");
				}
				set
				{
					R.String._members.StaticFields.SetValue("s3.I", value);
				}
			}

			// Token: 0x17000BA9 RID: 2985
			// (get) Token: 0x0600202A RID: 8234 RVA: 0x000579CE File Offset: 0x00055BCE
			// (set) Token: 0x0600202B RID: 8235 RVA: 0x000579E4 File Offset: 0x00055BE4
			[Register("s4")]
			public static int S4
			{
				get
				{
					return R.String._members.StaticFields.GetInt32Value("s4.I");
				}
				set
				{
					R.String._members.StaticFields.SetValue("s4.I", value);
				}
			}

			// Token: 0x17000BAA RID: 2986
			// (get) Token: 0x0600202C RID: 8236 RVA: 0x000579FB File Offset: 0x00055BFB
			// (set) Token: 0x0600202D RID: 8237 RVA: 0x00057A11 File Offset: 0x00055C11
			[Register("s5")]
			public static int S5
			{
				get
				{
					return R.String._members.StaticFields.GetInt32Value("s5.I");
				}
				set
				{
					R.String._members.StaticFields.SetValue("s5.I", value);
				}
			}

			// Token: 0x17000BAB RID: 2987
			// (get) Token: 0x0600202E RID: 8238 RVA: 0x00057A28 File Offset: 0x00055C28
			// (set) Token: 0x0600202F RID: 8239 RVA: 0x00057A3E File Offset: 0x00055C3E
			[Register("s6")]
			public static int S6
			{
				get
				{
					return R.String._members.StaticFields.GetInt32Value("s6.I");
				}
				set
				{
					R.String._members.StaticFields.SetValue("s6.I", value);
				}
			}

			// Token: 0x17000BAC RID: 2988
			// (get) Token: 0x06002030 RID: 8240 RVA: 0x00057A55 File Offset: 0x00055C55
			// (set) Token: 0x06002031 RID: 8241 RVA: 0x00057A6B File Offset: 0x00055C6B
			[Register("s7")]
			public static int S7
			{
				get
				{
					return R.String._members.StaticFields.GetInt32Value("s7.I");
				}
				set
				{
					R.String._members.StaticFields.SetValue("s7.I", value);
				}
			}

			// Token: 0x17000BAD RID: 2989
			// (get) Token: 0x06002032 RID: 8242 RVA: 0x00057A82 File Offset: 0x00055C82
			// (set) Token: 0x06002033 RID: 8243 RVA: 0x00057A98 File Offset: 0x00055C98
			[Register("status_bar_notification_info_overflow")]
			public static int StatusBarNotificationInfoOverflow
			{
				get
				{
					return R.String._members.StaticFields.GetInt32Value("status_bar_notification_info_overflow.I");
				}
				set
				{
					R.String._members.StaticFields.SetValue("status_bar_notification_info_overflow.I", value);
				}
			}

			// Token: 0x17000BAE RID: 2990
			// (get) Token: 0x06002034 RID: 8244 RVA: 0x00057AB0 File Offset: 0x00055CB0
			internal static IntPtr class_ref
			{
				get
				{
					return R.String._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x17000BAF RID: 2991
			// (get) Token: 0x06002035 RID: 8245 RVA: 0x00057AD4 File Offset: 0x00055CD4
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return R.String._members;
				}
			}

			// Token: 0x17000BB0 RID: 2992
			// (get) Token: 0x06002036 RID: 8246 RVA: 0x00057ADC File Offset: 0x00055CDC
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return R.String._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x17000BB1 RID: 2993
			// (get) Token: 0x06002037 RID: 8247 RVA: 0x00057B00 File Offset: 0x00055D00
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return R.String._members.ManagedPeerType;
				}
			}

			// Token: 0x06002038 RID: 8248 RVA: 0x000021E8 File Offset: 0x000003E8
			internal String(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
			{
			}

			// Token: 0x040006F0 RID: 1776
			private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/scar/adapter/v2000/R$string", typeof(R.String));
		}

		// Token: 0x02000259 RID: 601
		[Register("com/unity3d/scar/adapter/v2000/R$style", DoNotGenerateAcw = true)]
		public sealed class Style : Java.Lang.Object
		{
			// Token: 0x17000BB2 RID: 2994
			// (get) Token: 0x0600203A RID: 8250 RVA: 0x00057B27 File Offset: 0x00055D27
			// (set) Token: 0x0600203B RID: 8251 RVA: 0x00057B3D File Offset: 0x00055D3D
			[Register("TextAppearance_Compat_Notification")]
			public static int TextAppearanceCompatNotification
			{
				get
				{
					return R.Style._members.StaticFields.GetInt32Value("TextAppearance_Compat_Notification.I");
				}
				set
				{
					R.Style._members.StaticFields.SetValue("TextAppearance_Compat_Notification.I", value);
				}
			}

			// Token: 0x17000BB3 RID: 2995
			// (get) Token: 0x0600203C RID: 8252 RVA: 0x00057B54 File Offset: 0x00055D54
			// (set) Token: 0x0600203D RID: 8253 RVA: 0x00057B6A File Offset: 0x00055D6A
			[Register("TextAppearance_Compat_Notification_Info")]
			public static int TextAppearanceCompatNotificationInfo
			{
				get
				{
					return R.Style._members.StaticFields.GetInt32Value("TextAppearance_Compat_Notification_Info.I");
				}
				set
				{
					R.Style._members.StaticFields.SetValue("TextAppearance_Compat_Notification_Info.I", value);
				}
			}

			// Token: 0x17000BB4 RID: 2996
			// (get) Token: 0x0600203E RID: 8254 RVA: 0x00057B81 File Offset: 0x00055D81
			// (set) Token: 0x0600203F RID: 8255 RVA: 0x00057B97 File Offset: 0x00055D97
			[Register("TextAppearance_Compat_Notification_Line2")]
			public static int TextAppearanceCompatNotificationLine2
			{
				get
				{
					return R.Style._members.StaticFields.GetInt32Value("TextAppearance_Compat_Notification_Line2.I");
				}
				set
				{
					R.Style._members.StaticFields.SetValue("TextAppearance_Compat_Notification_Line2.I", value);
				}
			}

			// Token: 0x17000BB5 RID: 2997
			// (get) Token: 0x06002040 RID: 8256 RVA: 0x00057BAE File Offset: 0x00055DAE
			// (set) Token: 0x06002041 RID: 8257 RVA: 0x00057BC4 File Offset: 0x00055DC4
			[Register("TextAppearance_Compat_Notification_Time")]
			public static int TextAppearanceCompatNotificationTime
			{
				get
				{
					return R.Style._members.StaticFields.GetInt32Value("TextAppearance_Compat_Notification_Time.I");
				}
				set
				{
					R.Style._members.StaticFields.SetValue("TextAppearance_Compat_Notification_Time.I", value);
				}
			}

			// Token: 0x17000BB6 RID: 2998
			// (get) Token: 0x06002042 RID: 8258 RVA: 0x00057BDB File Offset: 0x00055DDB
			// (set) Token: 0x06002043 RID: 8259 RVA: 0x00057BF1 File Offset: 0x00055DF1
			[Register("TextAppearance_Compat_Notification_Title")]
			public static int TextAppearanceCompatNotificationTitle
			{
				get
				{
					return R.Style._members.StaticFields.GetInt32Value("TextAppearance_Compat_Notification_Title.I");
				}
				set
				{
					R.Style._members.StaticFields.SetValue("TextAppearance_Compat_Notification_Title.I", value);
				}
			}

			// Token: 0x17000BB7 RID: 2999
			// (get) Token: 0x06002044 RID: 8260 RVA: 0x00057C08 File Offset: 0x00055E08
			// (set) Token: 0x06002045 RID: 8261 RVA: 0x00057C1E File Offset: 0x00055E1E
			[Register("Theme_IAPTheme")]
			public static int ThemeIAPTheme
			{
				get
				{
					return R.Style._members.StaticFields.GetInt32Value("Theme_IAPTheme.I");
				}
				set
				{
					R.Style._members.StaticFields.SetValue("Theme_IAPTheme.I", value);
				}
			}

			// Token: 0x17000BB8 RID: 3000
			// (get) Token: 0x06002046 RID: 8262 RVA: 0x00057C35 File Offset: 0x00055E35
			// (set) Token: 0x06002047 RID: 8263 RVA: 0x00057C4B File Offset: 0x00055E4B
			[Register("Widget_Compat_NotificationActionContainer")]
			public static int WidgetCompatNotificationActionContainer
			{
				get
				{
					return R.Style._members.StaticFields.GetInt32Value("Widget_Compat_NotificationActionContainer.I");
				}
				set
				{
					R.Style._members.StaticFields.SetValue("Widget_Compat_NotificationActionContainer.I", value);
				}
			}

			// Token: 0x17000BB9 RID: 3001
			// (get) Token: 0x06002048 RID: 8264 RVA: 0x00057C62 File Offset: 0x00055E62
			// (set) Token: 0x06002049 RID: 8265 RVA: 0x00057C78 File Offset: 0x00055E78
			[Register("Widget_Compat_NotificationActionText")]
			public static int WidgetCompatNotificationActionText
			{
				get
				{
					return R.Style._members.StaticFields.GetInt32Value("Widget_Compat_NotificationActionText.I");
				}
				set
				{
					R.Style._members.StaticFields.SetValue("Widget_Compat_NotificationActionText.I", value);
				}
			}

			// Token: 0x17000BBA RID: 3002
			// (get) Token: 0x0600204A RID: 8266 RVA: 0x00057C8F File Offset: 0x00055E8F
			// (set) Token: 0x0600204B RID: 8267 RVA: 0x00057CA5 File Offset: 0x00055EA5
			[Register("Widget_Support_CoordinatorLayout")]
			public static int WidgetSupportCoordinatorLayout
			{
				get
				{
					return R.Style._members.StaticFields.GetInt32Value("Widget_Support_CoordinatorLayout.I");
				}
				set
				{
					R.Style._members.StaticFields.SetValue("Widget_Support_CoordinatorLayout.I", value);
				}
			}

			// Token: 0x17000BBB RID: 3003
			// (get) Token: 0x0600204C RID: 8268 RVA: 0x00057CBC File Offset: 0x00055EBC
			internal static IntPtr class_ref
			{
				get
				{
					return R.Style._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x17000BBC RID: 3004
			// (get) Token: 0x0600204D RID: 8269 RVA: 0x00057CE0 File Offset: 0x00055EE0
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return R.Style._members;
				}
			}

			// Token: 0x17000BBD RID: 3005
			// (get) Token: 0x0600204E RID: 8270 RVA: 0x00057CE8 File Offset: 0x00055EE8
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return R.Style._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x17000BBE RID: 3006
			// (get) Token: 0x0600204F RID: 8271 RVA: 0x00057D0C File Offset: 0x00055F0C
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return R.Style._members.ManagedPeerType;
				}
			}

			// Token: 0x06002050 RID: 8272 RVA: 0x000021E8 File Offset: 0x000003E8
			internal Style(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
			{
			}

			// Token: 0x040006F1 RID: 1777
			private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/scar/adapter/v2000/R$style", typeof(R.Style));
		}

		// Token: 0x0200025A RID: 602
		[Register("com/unity3d/scar/adapter/v2000/R$styleable", DoNotGenerateAcw = true)]
		public sealed class Styleable : Java.Lang.Object
		{
			// Token: 0x17000BBF RID: 3007
			// (get) Token: 0x06002052 RID: 8274 RVA: 0x00057D34 File Offset: 0x00055F34
			// (set) Token: 0x06002053 RID: 8275 RVA: 0x00057D64 File Offset: 0x00055F64
			[Register("AdsAttrs")]
			public static IList<int> AdsAttrs
			{
				get
				{
					return Android.Runtime.JavaArray<int>.FromJniHandle(R.Styleable._members.StaticFields.GetObjectValue("AdsAttrs.[I").Handle, JniHandleOwnership.TransferLocalRef);
				}
				set
				{
					IntPtr intPtr = Android.Runtime.JavaArray<int>.ToLocalJniHandle(value);
					try
					{
						R.Styleable._members.StaticFields.SetValue("AdsAttrs.[I", new JniObjectReference(intPtr, JniObjectReferenceType.Invalid));
					}
					finally
					{
						JNIEnv.DeleteLocalRef(intPtr);
					}
				}
			}

			// Token: 0x17000BC0 RID: 3008
			// (get) Token: 0x06002054 RID: 8276 RVA: 0x00057DAC File Offset: 0x00055FAC
			// (set) Token: 0x06002055 RID: 8277 RVA: 0x00057DC2 File Offset: 0x00055FC2
			[Register("AdsAttrs_adSize")]
			public static int AdsAttrsAdSize
			{
				get
				{
					return R.Styleable._members.StaticFields.GetInt32Value("AdsAttrs_adSize.I");
				}
				set
				{
					R.Styleable._members.StaticFields.SetValue("AdsAttrs_adSize.I", value);
				}
			}

			// Token: 0x17000BC1 RID: 3009
			// (get) Token: 0x06002056 RID: 8278 RVA: 0x00057DD9 File Offset: 0x00055FD9
			// (set) Token: 0x06002057 RID: 8279 RVA: 0x00057DEF File Offset: 0x00055FEF
			[Register("AdsAttrs_adSizes")]
			public static int AdsAttrsAdSizes
			{
				get
				{
					return R.Styleable._members.StaticFields.GetInt32Value("AdsAttrs_adSizes.I");
				}
				set
				{
					R.Styleable._members.StaticFields.SetValue("AdsAttrs_adSizes.I", value);
				}
			}

			// Token: 0x17000BC2 RID: 3010
			// (get) Token: 0x06002058 RID: 8280 RVA: 0x00057E06 File Offset: 0x00056006
			// (set) Token: 0x06002059 RID: 8281 RVA: 0x00057E1C File Offset: 0x0005601C
			[Register("AdsAttrs_adUnitId")]
			public static int AdsAttrsAdUnitId
			{
				get
				{
					return R.Styleable._members.StaticFields.GetInt32Value("AdsAttrs_adUnitId.I");
				}
				set
				{
					R.Styleable._members.StaticFields.SetValue("AdsAttrs_adUnitId.I", value);
				}
			}

			// Token: 0x17000BC3 RID: 3011
			// (get) Token: 0x0600205A RID: 8282 RVA: 0x00057E34 File Offset: 0x00056034
			// (set) Token: 0x0600205B RID: 8283 RVA: 0x00057E64 File Offset: 0x00056064
			[Register("ColorStateListItem")]
			public static IList<int> ColorStateListItem
			{
				get
				{
					return Android.Runtime.JavaArray<int>.FromJniHandle(R.Styleable._members.StaticFields.GetObjectValue("ColorStateListItem.[I").Handle, JniHandleOwnership.TransferLocalRef);
				}
				set
				{
					IntPtr intPtr = Android.Runtime.JavaArray<int>.ToLocalJniHandle(value);
					try
					{
						R.Styleable._members.StaticFields.SetValue("ColorStateListItem.[I", new JniObjectReference(intPtr, JniObjectReferenceType.Invalid));
					}
					finally
					{
						JNIEnv.DeleteLocalRef(intPtr);
					}
				}
			}

			// Token: 0x17000BC4 RID: 3012
			// (get) Token: 0x0600205C RID: 8284 RVA: 0x00057EAC File Offset: 0x000560AC
			// (set) Token: 0x0600205D RID: 8285 RVA: 0x00057EC2 File Offset: 0x000560C2
			[Register("ColorStateListItem_alpha")]
			public static int ColorStateListItemAlpha
			{
				get
				{
					return R.Styleable._members.StaticFields.GetInt32Value("ColorStateListItem_alpha.I");
				}
				set
				{
					R.Styleable._members.StaticFields.SetValue("ColorStateListItem_alpha.I", value);
				}
			}

			// Token: 0x17000BC5 RID: 3013
			// (get) Token: 0x0600205E RID: 8286 RVA: 0x00057ED9 File Offset: 0x000560D9
			// (set) Token: 0x0600205F RID: 8287 RVA: 0x00057EEF File Offset: 0x000560EF
			[Register("ColorStateListItem_android_alpha")]
			public static int ColorStateListItemAndroidAlpha
			{
				get
				{
					return R.Styleable._members.StaticFields.GetInt32Value("ColorStateListItem_android_alpha.I");
				}
				set
				{
					R.Styleable._members.StaticFields.SetValue("ColorStateListItem_android_alpha.I", value);
				}
			}

			// Token: 0x17000BC6 RID: 3014
			// (get) Token: 0x06002060 RID: 8288 RVA: 0x00057F06 File Offset: 0x00056106
			// (set) Token: 0x06002061 RID: 8289 RVA: 0x00057F1C File Offset: 0x0005611C
			[Register("ColorStateListItem_android_color")]
			public static int ColorStateListItemAndroidColor
			{
				get
				{
					return R.Styleable._members.StaticFields.GetInt32Value("ColorStateListItem_android_color.I");
				}
				set
				{
					R.Styleable._members.StaticFields.SetValue("ColorStateListItem_android_color.I", value);
				}
			}

			// Token: 0x17000BC7 RID: 3015
			// (get) Token: 0x06002062 RID: 8290 RVA: 0x00057F34 File Offset: 0x00056134
			// (set) Token: 0x06002063 RID: 8291 RVA: 0x00057F64 File Offset: 0x00056164
			[Register("CoordinatorLayout")]
			public static IList<int> CoordinatorLayout
			{
				get
				{
					return Android.Runtime.JavaArray<int>.FromJniHandle(R.Styleable._members.StaticFields.GetObjectValue("CoordinatorLayout.[I").Handle, JniHandleOwnership.TransferLocalRef);
				}
				set
				{
					IntPtr intPtr = Android.Runtime.JavaArray<int>.ToLocalJniHandle(value);
					try
					{
						R.Styleable._members.StaticFields.SetValue("CoordinatorLayout.[I", new JniObjectReference(intPtr, JniObjectReferenceType.Invalid));
					}
					finally
					{
						JNIEnv.DeleteLocalRef(intPtr);
					}
				}
			}

			// Token: 0x17000BC8 RID: 3016
			// (get) Token: 0x06002064 RID: 8292 RVA: 0x00057FAC File Offset: 0x000561AC
			// (set) Token: 0x06002065 RID: 8293 RVA: 0x00057FC2 File Offset: 0x000561C2
			[Register("CoordinatorLayout_keylines")]
			public static int CoordinatorLayoutKeylines
			{
				get
				{
					return R.Styleable._members.StaticFields.GetInt32Value("CoordinatorLayout_keylines.I");
				}
				set
				{
					R.Styleable._members.StaticFields.SetValue("CoordinatorLayout_keylines.I", value);
				}
			}

			// Token: 0x17000BC9 RID: 3017
			// (get) Token: 0x06002066 RID: 8294 RVA: 0x00057FDC File Offset: 0x000561DC
			// (set) Token: 0x06002067 RID: 8295 RVA: 0x0005800C File Offset: 0x0005620C
			[Register("CoordinatorLayout_Layout")]
			public static IList<int> CoordinatorLayoutLayout
			{
				get
				{
					return Android.Runtime.JavaArray<int>.FromJniHandle(R.Styleable._members.StaticFields.GetObjectValue("CoordinatorLayout_Layout.[I").Handle, JniHandleOwnership.TransferLocalRef);
				}
				set
				{
					IntPtr intPtr = Android.Runtime.JavaArray<int>.ToLocalJniHandle(value);
					try
					{
						R.Styleable._members.StaticFields.SetValue("CoordinatorLayout_Layout.[I", new JniObjectReference(intPtr, JniObjectReferenceType.Invalid));
					}
					finally
					{
						JNIEnv.DeleteLocalRef(intPtr);
					}
				}
			}

			// Token: 0x17000BCA RID: 3018
			// (get) Token: 0x06002068 RID: 8296 RVA: 0x00058054 File Offset: 0x00056254
			// (set) Token: 0x06002069 RID: 8297 RVA: 0x0005806A File Offset: 0x0005626A
			[Register("CoordinatorLayout_Layout_android_layout_gravity")]
			public static int CoordinatorLayoutLayoutAndroidLayoutGravity
			{
				get
				{
					return R.Styleable._members.StaticFields.GetInt32Value("CoordinatorLayout_Layout_android_layout_gravity.I");
				}
				set
				{
					R.Styleable._members.StaticFields.SetValue("CoordinatorLayout_Layout_android_layout_gravity.I", value);
				}
			}

			// Token: 0x17000BCB RID: 3019
			// (get) Token: 0x0600206A RID: 8298 RVA: 0x00058081 File Offset: 0x00056281
			// (set) Token: 0x0600206B RID: 8299 RVA: 0x00058097 File Offset: 0x00056297
			[Register("CoordinatorLayout_Layout_layout_anchor")]
			public static int CoordinatorLayoutLayoutLayoutAnchor
			{
				get
				{
					return R.Styleable._members.StaticFields.GetInt32Value("CoordinatorLayout_Layout_layout_anchor.I");
				}
				set
				{
					R.Styleable._members.StaticFields.SetValue("CoordinatorLayout_Layout_layout_anchor.I", value);
				}
			}

			// Token: 0x17000BCC RID: 3020
			// (get) Token: 0x0600206C RID: 8300 RVA: 0x000580AE File Offset: 0x000562AE
			// (set) Token: 0x0600206D RID: 8301 RVA: 0x000580C4 File Offset: 0x000562C4
			[Register("CoordinatorLayout_Layout_layout_anchorGravity")]
			public static int CoordinatorLayoutLayoutLayoutAnchorGravity
			{
				get
				{
					return R.Styleable._members.StaticFields.GetInt32Value("CoordinatorLayout_Layout_layout_anchorGravity.I");
				}
				set
				{
					R.Styleable._members.StaticFields.SetValue("CoordinatorLayout_Layout_layout_anchorGravity.I", value);
				}
			}

			// Token: 0x17000BCD RID: 3021
			// (get) Token: 0x0600206E RID: 8302 RVA: 0x000580DB File Offset: 0x000562DB
			// (set) Token: 0x0600206F RID: 8303 RVA: 0x000580F1 File Offset: 0x000562F1
			[Register("CoordinatorLayout_Layout_layout_behavior")]
			public static int CoordinatorLayoutLayoutLayoutBehavior
			{
				get
				{
					return R.Styleable._members.StaticFields.GetInt32Value("CoordinatorLayout_Layout_layout_behavior.I");
				}
				set
				{
					R.Styleable._members.StaticFields.SetValue("CoordinatorLayout_Layout_layout_behavior.I", value);
				}
			}

			// Token: 0x17000BCE RID: 3022
			// (get) Token: 0x06002070 RID: 8304 RVA: 0x00058108 File Offset: 0x00056308
			// (set) Token: 0x06002071 RID: 8305 RVA: 0x0005811E File Offset: 0x0005631E
			[Register("CoordinatorLayout_Layout_layout_dodgeInsetEdges")]
			public static int CoordinatorLayoutLayoutLayoutDodgeInsetEdges
			{
				get
				{
					return R.Styleable._members.StaticFields.GetInt32Value("CoordinatorLayout_Layout_layout_dodgeInsetEdges.I");
				}
				set
				{
					R.Styleable._members.StaticFields.SetValue("CoordinatorLayout_Layout_layout_dodgeInsetEdges.I", value);
				}
			}

			// Token: 0x17000BCF RID: 3023
			// (get) Token: 0x06002072 RID: 8306 RVA: 0x00058135 File Offset: 0x00056335
			// (set) Token: 0x06002073 RID: 8307 RVA: 0x0005814B File Offset: 0x0005634B
			[Register("CoordinatorLayout_Layout_layout_insetEdge")]
			public static int CoordinatorLayoutLayoutLayoutInsetEdge
			{
				get
				{
					return R.Styleable._members.StaticFields.GetInt32Value("CoordinatorLayout_Layout_layout_insetEdge.I");
				}
				set
				{
					R.Styleable._members.StaticFields.SetValue("CoordinatorLayout_Layout_layout_insetEdge.I", value);
				}
			}

			// Token: 0x17000BD0 RID: 3024
			// (get) Token: 0x06002074 RID: 8308 RVA: 0x00058162 File Offset: 0x00056362
			// (set) Token: 0x06002075 RID: 8309 RVA: 0x00058178 File Offset: 0x00056378
			[Register("CoordinatorLayout_Layout_layout_keyline")]
			public static int CoordinatorLayoutLayoutLayoutKeyline
			{
				get
				{
					return R.Styleable._members.StaticFields.GetInt32Value("CoordinatorLayout_Layout_layout_keyline.I");
				}
				set
				{
					R.Styleable._members.StaticFields.SetValue("CoordinatorLayout_Layout_layout_keyline.I", value);
				}
			}

			// Token: 0x17000BD1 RID: 3025
			// (get) Token: 0x06002076 RID: 8310 RVA: 0x0005818F File Offset: 0x0005638F
			// (set) Token: 0x06002077 RID: 8311 RVA: 0x000581A5 File Offset: 0x000563A5
			[Register("CoordinatorLayout_statusBarBackground")]
			public static int CoordinatorLayoutStatusBarBackground
			{
				get
				{
					return R.Styleable._members.StaticFields.GetInt32Value("CoordinatorLayout_statusBarBackground.I");
				}
				set
				{
					R.Styleable._members.StaticFields.SetValue("CoordinatorLayout_statusBarBackground.I", value);
				}
			}

			// Token: 0x17000BD2 RID: 3026
			// (get) Token: 0x06002078 RID: 8312 RVA: 0x000581BC File Offset: 0x000563BC
			// (set) Token: 0x06002079 RID: 8313 RVA: 0x000581EC File Offset: 0x000563EC
			[Register("FontFamily")]
			public static IList<int> FontFamily
			{
				get
				{
					return Android.Runtime.JavaArray<int>.FromJniHandle(R.Styleable._members.StaticFields.GetObjectValue("FontFamily.[I").Handle, JniHandleOwnership.TransferLocalRef);
				}
				set
				{
					IntPtr intPtr = Android.Runtime.JavaArray<int>.ToLocalJniHandle(value);
					try
					{
						R.Styleable._members.StaticFields.SetValue("FontFamily.[I", new JniObjectReference(intPtr, JniObjectReferenceType.Invalid));
					}
					finally
					{
						JNIEnv.DeleteLocalRef(intPtr);
					}
				}
			}

			// Token: 0x17000BD3 RID: 3027
			// (get) Token: 0x0600207A RID: 8314 RVA: 0x00058234 File Offset: 0x00056434
			// (set) Token: 0x0600207B RID: 8315 RVA: 0x00058264 File Offset: 0x00056464
			[Register("FontFamilyFont")]
			public static IList<int> FontFamilyFont
			{
				get
				{
					return Android.Runtime.JavaArray<int>.FromJniHandle(R.Styleable._members.StaticFields.GetObjectValue("FontFamilyFont.[I").Handle, JniHandleOwnership.TransferLocalRef);
				}
				set
				{
					IntPtr intPtr = Android.Runtime.JavaArray<int>.ToLocalJniHandle(value);
					try
					{
						R.Styleable._members.StaticFields.SetValue("FontFamilyFont.[I", new JniObjectReference(intPtr, JniObjectReferenceType.Invalid));
					}
					finally
					{
						JNIEnv.DeleteLocalRef(intPtr);
					}
				}
			}

			// Token: 0x17000BD4 RID: 3028
			// (get) Token: 0x0600207C RID: 8316 RVA: 0x000582AC File Offset: 0x000564AC
			// (set) Token: 0x0600207D RID: 8317 RVA: 0x000582C2 File Offset: 0x000564C2
			[Register("FontFamilyFont_android_font")]
			public static int FontFamilyFontAndroidFont
			{
				get
				{
					return R.Styleable._members.StaticFields.GetInt32Value("FontFamilyFont_android_font.I");
				}
				set
				{
					R.Styleable._members.StaticFields.SetValue("FontFamilyFont_android_font.I", value);
				}
			}

			// Token: 0x17000BD5 RID: 3029
			// (get) Token: 0x0600207E RID: 8318 RVA: 0x000582D9 File Offset: 0x000564D9
			// (set) Token: 0x0600207F RID: 8319 RVA: 0x000582EF File Offset: 0x000564EF
			[Register("FontFamilyFont_android_fontStyle")]
			public static int FontFamilyFontAndroidFontStyle
			{
				get
				{
					return R.Styleable._members.StaticFields.GetInt32Value("FontFamilyFont_android_fontStyle.I");
				}
				set
				{
					R.Styleable._members.StaticFields.SetValue("FontFamilyFont_android_fontStyle.I", value);
				}
			}

			// Token: 0x17000BD6 RID: 3030
			// (get) Token: 0x06002080 RID: 8320 RVA: 0x00058306 File Offset: 0x00056506
			// (set) Token: 0x06002081 RID: 8321 RVA: 0x0005831C File Offset: 0x0005651C
			[Register("FontFamilyFont_android_fontVariationSettings")]
			public static int FontFamilyFontAndroidFontVariationSettings
			{
				get
				{
					return R.Styleable._members.StaticFields.GetInt32Value("FontFamilyFont_android_fontVariationSettings.I");
				}
				set
				{
					R.Styleable._members.StaticFields.SetValue("FontFamilyFont_android_fontVariationSettings.I", value);
				}
			}

			// Token: 0x17000BD7 RID: 3031
			// (get) Token: 0x06002082 RID: 8322 RVA: 0x00058333 File Offset: 0x00056533
			// (set) Token: 0x06002083 RID: 8323 RVA: 0x00058349 File Offset: 0x00056549
			[Register("FontFamilyFont_android_fontWeight")]
			public static int FontFamilyFontAndroidFontWeight
			{
				get
				{
					return R.Styleable._members.StaticFields.GetInt32Value("FontFamilyFont_android_fontWeight.I");
				}
				set
				{
					R.Styleable._members.StaticFields.SetValue("FontFamilyFont_android_fontWeight.I", value);
				}
			}

			// Token: 0x17000BD8 RID: 3032
			// (get) Token: 0x06002084 RID: 8324 RVA: 0x00058360 File Offset: 0x00056560
			// (set) Token: 0x06002085 RID: 8325 RVA: 0x00058376 File Offset: 0x00056576
			[Register("FontFamilyFont_android_ttcIndex")]
			public static int FontFamilyFontAndroidTtcIndex
			{
				get
				{
					return R.Styleable._members.StaticFields.GetInt32Value("FontFamilyFont_android_ttcIndex.I");
				}
				set
				{
					R.Styleable._members.StaticFields.SetValue("FontFamilyFont_android_ttcIndex.I", value);
				}
			}

			// Token: 0x17000BD9 RID: 3033
			// (get) Token: 0x06002086 RID: 8326 RVA: 0x0005838D File Offset: 0x0005658D
			// (set) Token: 0x06002087 RID: 8327 RVA: 0x000583A3 File Offset: 0x000565A3
			[Register("FontFamilyFont_font")]
			public static int FontFamilyFontFont
			{
				get
				{
					return R.Styleable._members.StaticFields.GetInt32Value("FontFamilyFont_font.I");
				}
				set
				{
					R.Styleable._members.StaticFields.SetValue("FontFamilyFont_font.I", value);
				}
			}

			// Token: 0x17000BDA RID: 3034
			// (get) Token: 0x06002088 RID: 8328 RVA: 0x000583BA File Offset: 0x000565BA
			// (set) Token: 0x06002089 RID: 8329 RVA: 0x000583D0 File Offset: 0x000565D0
			[Register("FontFamilyFont_fontStyle")]
			public static int FontFamilyFontFontStyle
			{
				get
				{
					return R.Styleable._members.StaticFields.GetInt32Value("FontFamilyFont_fontStyle.I");
				}
				set
				{
					R.Styleable._members.StaticFields.SetValue("FontFamilyFont_fontStyle.I", value);
				}
			}

			// Token: 0x17000BDB RID: 3035
			// (get) Token: 0x0600208A RID: 8330 RVA: 0x000583E7 File Offset: 0x000565E7
			// (set) Token: 0x0600208B RID: 8331 RVA: 0x000583FD File Offset: 0x000565FD
			[Register("FontFamilyFont_fontVariationSettings")]
			public static int FontFamilyFontFontVariationSettings
			{
				get
				{
					return R.Styleable._members.StaticFields.GetInt32Value("FontFamilyFont_fontVariationSettings.I");
				}
				set
				{
					R.Styleable._members.StaticFields.SetValue("FontFamilyFont_fontVariationSettings.I", value);
				}
			}

			// Token: 0x17000BDC RID: 3036
			// (get) Token: 0x0600208C RID: 8332 RVA: 0x00058414 File Offset: 0x00056614
			// (set) Token: 0x0600208D RID: 8333 RVA: 0x0005842A File Offset: 0x0005662A
			[Register("FontFamilyFont_fontWeight")]
			public static int FontFamilyFontFontWeight
			{
				get
				{
					return R.Styleable._members.StaticFields.GetInt32Value("FontFamilyFont_fontWeight.I");
				}
				set
				{
					R.Styleable._members.StaticFields.SetValue("FontFamilyFont_fontWeight.I", value);
				}
			}

			// Token: 0x17000BDD RID: 3037
			// (get) Token: 0x0600208E RID: 8334 RVA: 0x00058441 File Offset: 0x00056641
			// (set) Token: 0x0600208F RID: 8335 RVA: 0x00058457 File Offset: 0x00056657
			[Register("FontFamilyFont_ttcIndex")]
			public static int FontFamilyFontTtcIndex
			{
				get
				{
					return R.Styleable._members.StaticFields.GetInt32Value("FontFamilyFont_ttcIndex.I");
				}
				set
				{
					R.Styleable._members.StaticFields.SetValue("FontFamilyFont_ttcIndex.I", value);
				}
			}

			// Token: 0x17000BDE RID: 3038
			// (get) Token: 0x06002090 RID: 8336 RVA: 0x0005846E File Offset: 0x0005666E
			// (set) Token: 0x06002091 RID: 8337 RVA: 0x00058484 File Offset: 0x00056684
			[Register("FontFamily_fontProviderAuthority")]
			public static int FontFamilyFontProviderAuthority
			{
				get
				{
					return R.Styleable._members.StaticFields.GetInt32Value("FontFamily_fontProviderAuthority.I");
				}
				set
				{
					R.Styleable._members.StaticFields.SetValue("FontFamily_fontProviderAuthority.I", value);
				}
			}

			// Token: 0x17000BDF RID: 3039
			// (get) Token: 0x06002092 RID: 8338 RVA: 0x0005849B File Offset: 0x0005669B
			// (set) Token: 0x06002093 RID: 8339 RVA: 0x000584B1 File Offset: 0x000566B1
			[Register("FontFamily_fontProviderCerts")]
			public static int FontFamilyFontProviderCerts
			{
				get
				{
					return R.Styleable._members.StaticFields.GetInt32Value("FontFamily_fontProviderCerts.I");
				}
				set
				{
					R.Styleable._members.StaticFields.SetValue("FontFamily_fontProviderCerts.I", value);
				}
			}

			// Token: 0x17000BE0 RID: 3040
			// (get) Token: 0x06002094 RID: 8340 RVA: 0x000584C8 File Offset: 0x000566C8
			// (set) Token: 0x06002095 RID: 8341 RVA: 0x000584DE File Offset: 0x000566DE
			[Register("FontFamily_fontProviderFetchStrategy")]
			public static int FontFamilyFontProviderFetchStrategy
			{
				get
				{
					return R.Styleable._members.StaticFields.GetInt32Value("FontFamily_fontProviderFetchStrategy.I");
				}
				set
				{
					R.Styleable._members.StaticFields.SetValue("FontFamily_fontProviderFetchStrategy.I", value);
				}
			}

			// Token: 0x17000BE1 RID: 3041
			// (get) Token: 0x06002096 RID: 8342 RVA: 0x000584F5 File Offset: 0x000566F5
			// (set) Token: 0x06002097 RID: 8343 RVA: 0x0005850B File Offset: 0x0005670B
			[Register("FontFamily_fontProviderFetchTimeout")]
			public static int FontFamilyFontProviderFetchTimeout
			{
				get
				{
					return R.Styleable._members.StaticFields.GetInt32Value("FontFamily_fontProviderFetchTimeout.I");
				}
				set
				{
					R.Styleable._members.StaticFields.SetValue("FontFamily_fontProviderFetchTimeout.I", value);
				}
			}

			// Token: 0x17000BE2 RID: 3042
			// (get) Token: 0x06002098 RID: 8344 RVA: 0x00058522 File Offset: 0x00056722
			// (set) Token: 0x06002099 RID: 8345 RVA: 0x00058538 File Offset: 0x00056738
			[Register("FontFamily_fontProviderPackage")]
			public static int FontFamilyFontProviderPackage
			{
				get
				{
					return R.Styleable._members.StaticFields.GetInt32Value("FontFamily_fontProviderPackage.I");
				}
				set
				{
					R.Styleable._members.StaticFields.SetValue("FontFamily_fontProviderPackage.I", value);
				}
			}

			// Token: 0x17000BE3 RID: 3043
			// (get) Token: 0x0600209A RID: 8346 RVA: 0x0005854F File Offset: 0x0005674F
			// (set) Token: 0x0600209B RID: 8347 RVA: 0x00058565 File Offset: 0x00056765
			[Register("FontFamily_fontProviderQuery")]
			public static int FontFamilyFontProviderQuery
			{
				get
				{
					return R.Styleable._members.StaticFields.GetInt32Value("FontFamily_fontProviderQuery.I");
				}
				set
				{
					R.Styleable._members.StaticFields.SetValue("FontFamily_fontProviderQuery.I", value);
				}
			}

			// Token: 0x17000BE4 RID: 3044
			// (get) Token: 0x0600209C RID: 8348 RVA: 0x0005857C File Offset: 0x0005677C
			// (set) Token: 0x0600209D RID: 8349 RVA: 0x000585AC File Offset: 0x000567AC
			[Register("GradientColor")]
			public static IList<int> GradientColor
			{
				get
				{
					return Android.Runtime.JavaArray<int>.FromJniHandle(R.Styleable._members.StaticFields.GetObjectValue("GradientColor.[I").Handle, JniHandleOwnership.TransferLocalRef);
				}
				set
				{
					IntPtr intPtr = Android.Runtime.JavaArray<int>.ToLocalJniHandle(value);
					try
					{
						R.Styleable._members.StaticFields.SetValue("GradientColor.[I", new JniObjectReference(intPtr, JniObjectReferenceType.Invalid));
					}
					finally
					{
						JNIEnv.DeleteLocalRef(intPtr);
					}
				}
			}

			// Token: 0x17000BE5 RID: 3045
			// (get) Token: 0x0600209E RID: 8350 RVA: 0x000585F4 File Offset: 0x000567F4
			// (set) Token: 0x0600209F RID: 8351 RVA: 0x00058624 File Offset: 0x00056824
			[Register("GradientColorItem")]
			public static IList<int> GradientColorItem
			{
				get
				{
					return Android.Runtime.JavaArray<int>.FromJniHandle(R.Styleable._members.StaticFields.GetObjectValue("GradientColorItem.[I").Handle, JniHandleOwnership.TransferLocalRef);
				}
				set
				{
					IntPtr intPtr = Android.Runtime.JavaArray<int>.ToLocalJniHandle(value);
					try
					{
						R.Styleable._members.StaticFields.SetValue("GradientColorItem.[I", new JniObjectReference(intPtr, JniObjectReferenceType.Invalid));
					}
					finally
					{
						JNIEnv.DeleteLocalRef(intPtr);
					}
				}
			}

			// Token: 0x17000BE6 RID: 3046
			// (get) Token: 0x060020A0 RID: 8352 RVA: 0x0005866C File Offset: 0x0005686C
			// (set) Token: 0x060020A1 RID: 8353 RVA: 0x00058682 File Offset: 0x00056882
			[Register("GradientColorItem_android_color")]
			public static int GradientColorItemAndroidColor
			{
				get
				{
					return R.Styleable._members.StaticFields.GetInt32Value("GradientColorItem_android_color.I");
				}
				set
				{
					R.Styleable._members.StaticFields.SetValue("GradientColorItem_android_color.I", value);
				}
			}

			// Token: 0x17000BE7 RID: 3047
			// (get) Token: 0x060020A2 RID: 8354 RVA: 0x00058699 File Offset: 0x00056899
			// (set) Token: 0x060020A3 RID: 8355 RVA: 0x000586AF File Offset: 0x000568AF
			[Register("GradientColorItem_android_offset")]
			public static int GradientColorItemAndroidOffset
			{
				get
				{
					return R.Styleable._members.StaticFields.GetInt32Value("GradientColorItem_android_offset.I");
				}
				set
				{
					R.Styleable._members.StaticFields.SetValue("GradientColorItem_android_offset.I", value);
				}
			}

			// Token: 0x17000BE8 RID: 3048
			// (get) Token: 0x060020A4 RID: 8356 RVA: 0x000586C6 File Offset: 0x000568C6
			// (set) Token: 0x060020A5 RID: 8357 RVA: 0x000586DC File Offset: 0x000568DC
			[Register("GradientColor_android_centerColor")]
			public static int GradientColorAndroidCenterColor
			{
				get
				{
					return R.Styleable._members.StaticFields.GetInt32Value("GradientColor_android_centerColor.I");
				}
				set
				{
					R.Styleable._members.StaticFields.SetValue("GradientColor_android_centerColor.I", value);
				}
			}

			// Token: 0x17000BE9 RID: 3049
			// (get) Token: 0x060020A6 RID: 8358 RVA: 0x000586F3 File Offset: 0x000568F3
			// (set) Token: 0x060020A7 RID: 8359 RVA: 0x00058709 File Offset: 0x00056909
			[Register("GradientColor_android_centerX")]
			public static int GradientColorAndroidCenterX
			{
				get
				{
					return R.Styleable._members.StaticFields.GetInt32Value("GradientColor_android_centerX.I");
				}
				set
				{
					R.Styleable._members.StaticFields.SetValue("GradientColor_android_centerX.I", value);
				}
			}

			// Token: 0x17000BEA RID: 3050
			// (get) Token: 0x060020A8 RID: 8360 RVA: 0x00058720 File Offset: 0x00056920
			// (set) Token: 0x060020A9 RID: 8361 RVA: 0x00058736 File Offset: 0x00056936
			[Register("GradientColor_android_centerY")]
			public static int GradientColorAndroidCenterY
			{
				get
				{
					return R.Styleable._members.StaticFields.GetInt32Value("GradientColor_android_centerY.I");
				}
				set
				{
					R.Styleable._members.StaticFields.SetValue("GradientColor_android_centerY.I", value);
				}
			}

			// Token: 0x17000BEB RID: 3051
			// (get) Token: 0x060020AA RID: 8362 RVA: 0x0005874D File Offset: 0x0005694D
			// (set) Token: 0x060020AB RID: 8363 RVA: 0x00058763 File Offset: 0x00056963
			[Register("GradientColor_android_endColor")]
			public static int GradientColorAndroidEndColor
			{
				get
				{
					return R.Styleable._members.StaticFields.GetInt32Value("GradientColor_android_endColor.I");
				}
				set
				{
					R.Styleable._members.StaticFields.SetValue("GradientColor_android_endColor.I", value);
				}
			}

			// Token: 0x17000BEC RID: 3052
			// (get) Token: 0x060020AC RID: 8364 RVA: 0x0005877A File Offset: 0x0005697A
			// (set) Token: 0x060020AD RID: 8365 RVA: 0x00058790 File Offset: 0x00056990
			[Register("GradientColor_android_endX")]
			public static int GradientColorAndroidEndX
			{
				get
				{
					return R.Styleable._members.StaticFields.GetInt32Value("GradientColor_android_endX.I");
				}
				set
				{
					R.Styleable._members.StaticFields.SetValue("GradientColor_android_endX.I", value);
				}
			}

			// Token: 0x17000BED RID: 3053
			// (get) Token: 0x060020AE RID: 8366 RVA: 0x000587A7 File Offset: 0x000569A7
			// (set) Token: 0x060020AF RID: 8367 RVA: 0x000587BD File Offset: 0x000569BD
			[Register("GradientColor_android_endY")]
			public static int GradientColorAndroidEndY
			{
				get
				{
					return R.Styleable._members.StaticFields.GetInt32Value("GradientColor_android_endY.I");
				}
				set
				{
					R.Styleable._members.StaticFields.SetValue("GradientColor_android_endY.I", value);
				}
			}

			// Token: 0x17000BEE RID: 3054
			// (get) Token: 0x060020B0 RID: 8368 RVA: 0x000587D4 File Offset: 0x000569D4
			// (set) Token: 0x060020B1 RID: 8369 RVA: 0x000587EA File Offset: 0x000569EA
			[Register("GradientColor_android_gradientRadius")]
			public static int GradientColorAndroidGradientRadius
			{
				get
				{
					return R.Styleable._members.StaticFields.GetInt32Value("GradientColor_android_gradientRadius.I");
				}
				set
				{
					R.Styleable._members.StaticFields.SetValue("GradientColor_android_gradientRadius.I", value);
				}
			}

			// Token: 0x17000BEF RID: 3055
			// (get) Token: 0x060020B2 RID: 8370 RVA: 0x00058801 File Offset: 0x00056A01
			// (set) Token: 0x060020B3 RID: 8371 RVA: 0x00058817 File Offset: 0x00056A17
			[Register("GradientColor_android_startColor")]
			public static int GradientColorAndroidStartColor
			{
				get
				{
					return R.Styleable._members.StaticFields.GetInt32Value("GradientColor_android_startColor.I");
				}
				set
				{
					R.Styleable._members.StaticFields.SetValue("GradientColor_android_startColor.I", value);
				}
			}

			// Token: 0x17000BF0 RID: 3056
			// (get) Token: 0x060020B4 RID: 8372 RVA: 0x0005882E File Offset: 0x00056A2E
			// (set) Token: 0x060020B5 RID: 8373 RVA: 0x00058844 File Offset: 0x00056A44
			[Register("GradientColor_android_startX")]
			public static int GradientColorAndroidStartX
			{
				get
				{
					return R.Styleable._members.StaticFields.GetInt32Value("GradientColor_android_startX.I");
				}
				set
				{
					R.Styleable._members.StaticFields.SetValue("GradientColor_android_startX.I", value);
				}
			}

			// Token: 0x17000BF1 RID: 3057
			// (get) Token: 0x060020B6 RID: 8374 RVA: 0x0005885B File Offset: 0x00056A5B
			// (set) Token: 0x060020B7 RID: 8375 RVA: 0x00058871 File Offset: 0x00056A71
			[Register("GradientColor_android_startY")]
			public static int GradientColorAndroidStartY
			{
				get
				{
					return R.Styleable._members.StaticFields.GetInt32Value("GradientColor_android_startY.I");
				}
				set
				{
					R.Styleable._members.StaticFields.SetValue("GradientColor_android_startY.I", value);
				}
			}

			// Token: 0x17000BF2 RID: 3058
			// (get) Token: 0x060020B8 RID: 8376 RVA: 0x00058888 File Offset: 0x00056A88
			// (set) Token: 0x060020B9 RID: 8377 RVA: 0x0005889E File Offset: 0x00056A9E
			[Register("GradientColor_android_tileMode")]
			public static int GradientColorAndroidTileMode
			{
				get
				{
					return R.Styleable._members.StaticFields.GetInt32Value("GradientColor_android_tileMode.I");
				}
				set
				{
					R.Styleable._members.StaticFields.SetValue("GradientColor_android_tileMode.I", value);
				}
			}

			// Token: 0x17000BF3 RID: 3059
			// (get) Token: 0x060020BA RID: 8378 RVA: 0x000588B5 File Offset: 0x00056AB5
			// (set) Token: 0x060020BB RID: 8379 RVA: 0x000588CB File Offset: 0x00056ACB
			[Register("GradientColor_android_type")]
			public static int GradientColorAndroidType
			{
				get
				{
					return R.Styleable._members.StaticFields.GetInt32Value("GradientColor_android_type.I");
				}
				set
				{
					R.Styleable._members.StaticFields.SetValue("GradientColor_android_type.I", value);
				}
			}

			// Token: 0x17000BF4 RID: 3060
			// (get) Token: 0x060020BC RID: 8380 RVA: 0x000588E4 File Offset: 0x00056AE4
			internal static IntPtr class_ref
			{
				get
				{
					return R.Styleable._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x17000BF5 RID: 3061
			// (get) Token: 0x060020BD RID: 8381 RVA: 0x00058908 File Offset: 0x00056B08
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return R.Styleable._members;
				}
			}

			// Token: 0x17000BF6 RID: 3062
			// (get) Token: 0x060020BE RID: 8382 RVA: 0x00058910 File Offset: 0x00056B10
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return R.Styleable._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x17000BF7 RID: 3063
			// (get) Token: 0x060020BF RID: 8383 RVA: 0x00058934 File Offset: 0x00056B34
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return R.Styleable._members.ManagedPeerType;
				}
			}

			// Token: 0x060020C0 RID: 8384 RVA: 0x000021E8 File Offset: 0x000003E8
			internal Styleable(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
			{
			}

			// Token: 0x040006F2 RID: 1778
			private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/scar/adapter/v2000/R$styleable", typeof(R.Styleable));
		}
	}
}
