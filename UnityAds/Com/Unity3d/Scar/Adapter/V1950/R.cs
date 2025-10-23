using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Com.Unity3d.Scar.Adapter.V1950
{
	// Token: 0x02000265 RID: 613
	[Register("com/unity3d/scar/adapter/v1950/R", DoNotGenerateAcw = true)]
	public sealed class R : Java.Lang.Object
	{
		// Token: 0x17000C1C RID: 3100
		// (get) Token: 0x0600211D RID: 8477 RVA: 0x00059894 File Offset: 0x00057A94
		internal static IntPtr class_ref
		{
			get
			{
				return R._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000C1D RID: 3101
		// (get) Token: 0x0600211E RID: 8478 RVA: 0x000598B8 File Offset: 0x00057AB8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return R._members;
			}
		}

		// Token: 0x17000C1E RID: 3102
		// (get) Token: 0x0600211F RID: 8479 RVA: 0x000598C0 File Offset: 0x00057AC0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return R._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000C1F RID: 3103
		// (get) Token: 0x06002120 RID: 8480 RVA: 0x000598E4 File Offset: 0x00057AE4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return R._members.ManagedPeerType;
			}
		}

		// Token: 0x06002121 RID: 8481 RVA: 0x000021E8 File Offset: 0x000003E8
		internal R(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x04000709 RID: 1801
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/scar/adapter/v1950/R", typeof(R));

		// Token: 0x02000266 RID: 614
		[Register("com/unity3d/scar/adapter/v1950/R$attr", DoNotGenerateAcw = true)]
		public sealed class Attr : Java.Lang.Object
		{
			// Token: 0x17000C20 RID: 3104
			// (get) Token: 0x06002123 RID: 8483 RVA: 0x0005990B File Offset: 0x00057B0B
			// (set) Token: 0x06002124 RID: 8484 RVA: 0x00059921 File Offset: 0x00057B21
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

			// Token: 0x17000C21 RID: 3105
			// (get) Token: 0x06002125 RID: 8485 RVA: 0x00059938 File Offset: 0x00057B38
			// (set) Token: 0x06002126 RID: 8486 RVA: 0x0005994E File Offset: 0x00057B4E
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

			// Token: 0x17000C22 RID: 3106
			// (get) Token: 0x06002127 RID: 8487 RVA: 0x00059965 File Offset: 0x00057B65
			// (set) Token: 0x06002128 RID: 8488 RVA: 0x0005997B File Offset: 0x00057B7B
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

			// Token: 0x17000C23 RID: 3107
			// (get) Token: 0x06002129 RID: 8489 RVA: 0x00059992 File Offset: 0x00057B92
			// (set) Token: 0x0600212A RID: 8490 RVA: 0x000599A8 File Offset: 0x00057BA8
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

			// Token: 0x17000C24 RID: 3108
			// (get) Token: 0x0600212B RID: 8491 RVA: 0x000599BF File Offset: 0x00057BBF
			// (set) Token: 0x0600212C RID: 8492 RVA: 0x000599D5 File Offset: 0x00057BD5
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

			// Token: 0x17000C25 RID: 3109
			// (get) Token: 0x0600212D RID: 8493 RVA: 0x000599EC File Offset: 0x00057BEC
			// (set) Token: 0x0600212E RID: 8494 RVA: 0x00059A02 File Offset: 0x00057C02
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

			// Token: 0x17000C26 RID: 3110
			// (get) Token: 0x0600212F RID: 8495 RVA: 0x00059A19 File Offset: 0x00057C19
			// (set) Token: 0x06002130 RID: 8496 RVA: 0x00059A2F File Offset: 0x00057C2F
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

			// Token: 0x17000C27 RID: 3111
			// (get) Token: 0x06002131 RID: 8497 RVA: 0x00059A46 File Offset: 0x00057C46
			// (set) Token: 0x06002132 RID: 8498 RVA: 0x00059A5C File Offset: 0x00057C5C
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

			// Token: 0x17000C28 RID: 3112
			// (get) Token: 0x06002133 RID: 8499 RVA: 0x00059A73 File Offset: 0x00057C73
			// (set) Token: 0x06002134 RID: 8500 RVA: 0x00059A89 File Offset: 0x00057C89
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

			// Token: 0x17000C29 RID: 3113
			// (get) Token: 0x06002135 RID: 8501 RVA: 0x00059AA0 File Offset: 0x00057CA0
			// (set) Token: 0x06002136 RID: 8502 RVA: 0x00059AB6 File Offset: 0x00057CB6
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

			// Token: 0x17000C2A RID: 3114
			// (get) Token: 0x06002137 RID: 8503 RVA: 0x00059ACD File Offset: 0x00057CCD
			// (set) Token: 0x06002138 RID: 8504 RVA: 0x00059AE3 File Offset: 0x00057CE3
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

			// Token: 0x17000C2B RID: 3115
			// (get) Token: 0x06002139 RID: 8505 RVA: 0x00059AFA File Offset: 0x00057CFA
			// (set) Token: 0x0600213A RID: 8506 RVA: 0x00059B10 File Offset: 0x00057D10
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

			// Token: 0x17000C2C RID: 3116
			// (get) Token: 0x0600213B RID: 8507 RVA: 0x00059B27 File Offset: 0x00057D27
			// (set) Token: 0x0600213C RID: 8508 RVA: 0x00059B3D File Offset: 0x00057D3D
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

			// Token: 0x17000C2D RID: 3117
			// (get) Token: 0x0600213D RID: 8509 RVA: 0x00059B54 File Offset: 0x00057D54
			// (set) Token: 0x0600213E RID: 8510 RVA: 0x00059B6A File Offset: 0x00057D6A
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

			// Token: 0x17000C2E RID: 3118
			// (get) Token: 0x0600213F RID: 8511 RVA: 0x00059B81 File Offset: 0x00057D81
			// (set) Token: 0x06002140 RID: 8512 RVA: 0x00059B97 File Offset: 0x00057D97
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

			// Token: 0x17000C2F RID: 3119
			// (get) Token: 0x06002141 RID: 8513 RVA: 0x00059BAE File Offset: 0x00057DAE
			// (set) Token: 0x06002142 RID: 8514 RVA: 0x00059BC4 File Offset: 0x00057DC4
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

			// Token: 0x17000C30 RID: 3120
			// (get) Token: 0x06002143 RID: 8515 RVA: 0x00059BDB File Offset: 0x00057DDB
			// (set) Token: 0x06002144 RID: 8516 RVA: 0x00059BF1 File Offset: 0x00057DF1
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

			// Token: 0x17000C31 RID: 3121
			// (get) Token: 0x06002145 RID: 8517 RVA: 0x00059C08 File Offset: 0x00057E08
			// (set) Token: 0x06002146 RID: 8518 RVA: 0x00059C1E File Offset: 0x00057E1E
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

			// Token: 0x17000C32 RID: 3122
			// (get) Token: 0x06002147 RID: 8519 RVA: 0x00059C35 File Offset: 0x00057E35
			// (set) Token: 0x06002148 RID: 8520 RVA: 0x00059C4B File Offset: 0x00057E4B
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

			// Token: 0x17000C33 RID: 3123
			// (get) Token: 0x06002149 RID: 8521 RVA: 0x00059C62 File Offset: 0x00057E62
			// (set) Token: 0x0600214A RID: 8522 RVA: 0x00059C78 File Offset: 0x00057E78
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

			// Token: 0x17000C34 RID: 3124
			// (get) Token: 0x0600214B RID: 8523 RVA: 0x00059C8F File Offset: 0x00057E8F
			// (set) Token: 0x0600214C RID: 8524 RVA: 0x00059CA5 File Offset: 0x00057EA5
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

			// Token: 0x17000C35 RID: 3125
			// (get) Token: 0x0600214D RID: 8525 RVA: 0x00059CBC File Offset: 0x00057EBC
			// (set) Token: 0x0600214E RID: 8526 RVA: 0x00059CD2 File Offset: 0x00057ED2
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

			// Token: 0x17000C36 RID: 3126
			// (get) Token: 0x0600214F RID: 8527 RVA: 0x00059CE9 File Offset: 0x00057EE9
			// (set) Token: 0x06002150 RID: 8528 RVA: 0x00059CFF File Offset: 0x00057EFF
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

			// Token: 0x17000C37 RID: 3127
			// (get) Token: 0x06002151 RID: 8529 RVA: 0x00059D16 File Offset: 0x00057F16
			// (set) Token: 0x06002152 RID: 8530 RVA: 0x00059D2C File Offset: 0x00057F2C
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

			// Token: 0x17000C38 RID: 3128
			// (get) Token: 0x06002153 RID: 8531 RVA: 0x00059D44 File Offset: 0x00057F44
			internal static IntPtr class_ref
			{
				get
				{
					return R.Attr._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x17000C39 RID: 3129
			// (get) Token: 0x06002154 RID: 8532 RVA: 0x00059D68 File Offset: 0x00057F68
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return R.Attr._members;
				}
			}

			// Token: 0x17000C3A RID: 3130
			// (get) Token: 0x06002155 RID: 8533 RVA: 0x00059D70 File Offset: 0x00057F70
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return R.Attr._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x17000C3B RID: 3131
			// (get) Token: 0x06002156 RID: 8534 RVA: 0x00059D94 File Offset: 0x00057F94
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return R.Attr._members.ManagedPeerType;
				}
			}

			// Token: 0x06002157 RID: 8535 RVA: 0x000021E8 File Offset: 0x000003E8
			internal Attr(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
			{
			}

			// Token: 0x0400070A RID: 1802
			private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/scar/adapter/v1950/R$attr", typeof(R.Attr));
		}

		// Token: 0x02000267 RID: 615
		[Register("com/unity3d/scar/adapter/v1950/R$bool", DoNotGenerateAcw = true)]
		public sealed class Bool : Java.Lang.Object
		{
			// Token: 0x17000C3C RID: 3132
			// (get) Token: 0x06002159 RID: 8537 RVA: 0x00059DBB File Offset: 0x00057FBB
			// (set) Token: 0x0600215A RID: 8538 RVA: 0x00059DD1 File Offset: 0x00057FD1
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

			// Token: 0x17000C3D RID: 3133
			// (get) Token: 0x0600215B RID: 8539 RVA: 0x00059DE8 File Offset: 0x00057FE8
			// (set) Token: 0x0600215C RID: 8540 RVA: 0x00059DFE File Offset: 0x00057FFE
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

			// Token: 0x17000C3E RID: 3134
			// (get) Token: 0x0600215D RID: 8541 RVA: 0x00059E15 File Offset: 0x00058015
			// (set) Token: 0x0600215E RID: 8542 RVA: 0x00059E2B File Offset: 0x0005802B
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

			// Token: 0x17000C3F RID: 3135
			// (get) Token: 0x0600215F RID: 8543 RVA: 0x00059E44 File Offset: 0x00058044
			internal static IntPtr class_ref
			{
				get
				{
					return R.Bool._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x17000C40 RID: 3136
			// (get) Token: 0x06002160 RID: 8544 RVA: 0x00059E68 File Offset: 0x00058068
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return R.Bool._members;
				}
			}

			// Token: 0x17000C41 RID: 3137
			// (get) Token: 0x06002161 RID: 8545 RVA: 0x00059E70 File Offset: 0x00058070
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return R.Bool._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x17000C42 RID: 3138
			// (get) Token: 0x06002162 RID: 8546 RVA: 0x00059E94 File Offset: 0x00058094
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return R.Bool._members.ManagedPeerType;
				}
			}

			// Token: 0x06002163 RID: 8547 RVA: 0x000021E8 File Offset: 0x000003E8
			internal Bool(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
			{
			}

			// Token: 0x0400070B RID: 1803
			private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/scar/adapter/v1950/R$bool", typeof(R.Bool));
		}

		// Token: 0x02000268 RID: 616
		[Register("com/unity3d/scar/adapter/v1950/R$color", DoNotGenerateAcw = true)]
		public sealed class Color : Java.Lang.Object
		{
			// Token: 0x17000C43 RID: 3139
			// (get) Token: 0x06002165 RID: 8549 RVA: 0x00059EBB File Offset: 0x000580BB
			// (set) Token: 0x06002166 RID: 8550 RVA: 0x00059ED1 File Offset: 0x000580D1
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

			// Token: 0x17000C44 RID: 3140
			// (get) Token: 0x06002167 RID: 8551 RVA: 0x00059EE8 File Offset: 0x000580E8
			// (set) Token: 0x06002168 RID: 8552 RVA: 0x00059EFE File Offset: 0x000580FE
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

			// Token: 0x17000C45 RID: 3141
			// (get) Token: 0x06002169 RID: 8553 RVA: 0x00059F15 File Offset: 0x00058115
			// (set) Token: 0x0600216A RID: 8554 RVA: 0x00059F2B File Offset: 0x0005812B
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

			// Token: 0x17000C46 RID: 3142
			// (get) Token: 0x0600216B RID: 8555 RVA: 0x00059F42 File Offset: 0x00058142
			// (set) Token: 0x0600216C RID: 8556 RVA: 0x00059F58 File Offset: 0x00058158
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

			// Token: 0x17000C47 RID: 3143
			// (get) Token: 0x0600216D RID: 8557 RVA: 0x00059F6F File Offset: 0x0005816F
			// (set) Token: 0x0600216E RID: 8558 RVA: 0x00059F85 File Offset: 0x00058185
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

			// Token: 0x17000C48 RID: 3144
			// (get) Token: 0x0600216F RID: 8559 RVA: 0x00059F9C File Offset: 0x0005819C
			// (set) Token: 0x06002170 RID: 8560 RVA: 0x00059FB2 File Offset: 0x000581B2
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

			// Token: 0x17000C49 RID: 3145
			// (get) Token: 0x06002171 RID: 8561 RVA: 0x00059FC9 File Offset: 0x000581C9
			// (set) Token: 0x06002172 RID: 8562 RVA: 0x00059FDF File Offset: 0x000581DF
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

			// Token: 0x17000C4A RID: 3146
			// (get) Token: 0x06002173 RID: 8563 RVA: 0x00059FF6 File Offset: 0x000581F6
			// (set) Token: 0x06002174 RID: 8564 RVA: 0x0005A00C File Offset: 0x0005820C
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

			// Token: 0x17000C4B RID: 3147
			// (get) Token: 0x06002175 RID: 8565 RVA: 0x0005A024 File Offset: 0x00058224
			internal static IntPtr class_ref
			{
				get
				{
					return R.Color._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x17000C4C RID: 3148
			// (get) Token: 0x06002176 RID: 8566 RVA: 0x0005A048 File Offset: 0x00058248
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return R.Color._members;
				}
			}

			// Token: 0x17000C4D RID: 3149
			// (get) Token: 0x06002177 RID: 8567 RVA: 0x0005A050 File Offset: 0x00058250
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return R.Color._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x17000C4E RID: 3150
			// (get) Token: 0x06002178 RID: 8568 RVA: 0x0005A074 File Offset: 0x00058274
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return R.Color._members.ManagedPeerType;
				}
			}

			// Token: 0x06002179 RID: 8569 RVA: 0x000021E8 File Offset: 0x000003E8
			internal Color(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
			{
			}

			// Token: 0x0400070C RID: 1804
			private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/scar/adapter/v1950/R$color", typeof(R.Color));
		}

		// Token: 0x02000269 RID: 617
		[Register("com/unity3d/scar/adapter/v1950/R$dimen", DoNotGenerateAcw = true)]
		public sealed class Dimen : Java.Lang.Object
		{
			// Token: 0x17000C4F RID: 3151
			// (get) Token: 0x0600217B RID: 8571 RVA: 0x0005A09B File Offset: 0x0005829B
			// (set) Token: 0x0600217C RID: 8572 RVA: 0x0005A0B1 File Offset: 0x000582B1
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

			// Token: 0x17000C50 RID: 3152
			// (get) Token: 0x0600217D RID: 8573 RVA: 0x0005A0C8 File Offset: 0x000582C8
			// (set) Token: 0x0600217E RID: 8574 RVA: 0x0005A0DE File Offset: 0x000582DE
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

			// Token: 0x17000C51 RID: 3153
			// (get) Token: 0x0600217F RID: 8575 RVA: 0x0005A0F5 File Offset: 0x000582F5
			// (set) Token: 0x06002180 RID: 8576 RVA: 0x0005A10B File Offset: 0x0005830B
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

			// Token: 0x17000C52 RID: 3154
			// (get) Token: 0x06002181 RID: 8577 RVA: 0x0005A122 File Offset: 0x00058322
			// (set) Token: 0x06002182 RID: 8578 RVA: 0x0005A138 File Offset: 0x00058338
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

			// Token: 0x17000C53 RID: 3155
			// (get) Token: 0x06002183 RID: 8579 RVA: 0x0005A14F File Offset: 0x0005834F
			// (set) Token: 0x06002184 RID: 8580 RVA: 0x0005A165 File Offset: 0x00058365
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

			// Token: 0x17000C54 RID: 3156
			// (get) Token: 0x06002185 RID: 8581 RVA: 0x0005A17C File Offset: 0x0005837C
			// (set) Token: 0x06002186 RID: 8582 RVA: 0x0005A192 File Offset: 0x00058392
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

			// Token: 0x17000C55 RID: 3157
			// (get) Token: 0x06002187 RID: 8583 RVA: 0x0005A1A9 File Offset: 0x000583A9
			// (set) Token: 0x06002188 RID: 8584 RVA: 0x0005A1BF File Offset: 0x000583BF
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

			// Token: 0x17000C56 RID: 3158
			// (get) Token: 0x06002189 RID: 8585 RVA: 0x0005A1D6 File Offset: 0x000583D6
			// (set) Token: 0x0600218A RID: 8586 RVA: 0x0005A1EC File Offset: 0x000583EC
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

			// Token: 0x17000C57 RID: 3159
			// (get) Token: 0x0600218B RID: 8587 RVA: 0x0005A203 File Offset: 0x00058403
			// (set) Token: 0x0600218C RID: 8588 RVA: 0x0005A219 File Offset: 0x00058419
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

			// Token: 0x17000C58 RID: 3160
			// (get) Token: 0x0600218D RID: 8589 RVA: 0x0005A230 File Offset: 0x00058430
			// (set) Token: 0x0600218E RID: 8590 RVA: 0x0005A246 File Offset: 0x00058446
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

			// Token: 0x17000C59 RID: 3161
			// (get) Token: 0x0600218F RID: 8591 RVA: 0x0005A25D File Offset: 0x0005845D
			// (set) Token: 0x06002190 RID: 8592 RVA: 0x0005A273 File Offset: 0x00058473
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

			// Token: 0x17000C5A RID: 3162
			// (get) Token: 0x06002191 RID: 8593 RVA: 0x0005A28A File Offset: 0x0005848A
			// (set) Token: 0x06002192 RID: 8594 RVA: 0x0005A2A0 File Offset: 0x000584A0
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

			// Token: 0x17000C5B RID: 3163
			// (get) Token: 0x06002193 RID: 8595 RVA: 0x0005A2B7 File Offset: 0x000584B7
			// (set) Token: 0x06002194 RID: 8596 RVA: 0x0005A2CD File Offset: 0x000584CD
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

			// Token: 0x17000C5C RID: 3164
			// (get) Token: 0x06002195 RID: 8597 RVA: 0x0005A2E4 File Offset: 0x000584E4
			// (set) Token: 0x06002196 RID: 8598 RVA: 0x0005A2FA File Offset: 0x000584FA
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

			// Token: 0x17000C5D RID: 3165
			// (get) Token: 0x06002197 RID: 8599 RVA: 0x0005A311 File Offset: 0x00058511
			// (set) Token: 0x06002198 RID: 8600 RVA: 0x0005A327 File Offset: 0x00058527
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

			// Token: 0x17000C5E RID: 3166
			// (get) Token: 0x06002199 RID: 8601 RVA: 0x0005A33E File Offset: 0x0005853E
			// (set) Token: 0x0600219A RID: 8602 RVA: 0x0005A354 File Offset: 0x00058554
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

			// Token: 0x17000C5F RID: 3167
			// (get) Token: 0x0600219B RID: 8603 RVA: 0x0005A36B File Offset: 0x0005856B
			// (set) Token: 0x0600219C RID: 8604 RVA: 0x0005A381 File Offset: 0x00058581
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

			// Token: 0x17000C60 RID: 3168
			// (get) Token: 0x0600219D RID: 8605 RVA: 0x0005A398 File Offset: 0x00058598
			// (set) Token: 0x0600219E RID: 8606 RVA: 0x0005A3AE File Offset: 0x000585AE
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

			// Token: 0x17000C61 RID: 3169
			// (get) Token: 0x0600219F RID: 8607 RVA: 0x0005A3C5 File Offset: 0x000585C5
			// (set) Token: 0x060021A0 RID: 8608 RVA: 0x0005A3DB File Offset: 0x000585DB
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

			// Token: 0x17000C62 RID: 3170
			// (get) Token: 0x060021A1 RID: 8609 RVA: 0x0005A3F2 File Offset: 0x000585F2
			// (set) Token: 0x060021A2 RID: 8610 RVA: 0x0005A408 File Offset: 0x00058608
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

			// Token: 0x17000C63 RID: 3171
			// (get) Token: 0x060021A3 RID: 8611 RVA: 0x0005A41F File Offset: 0x0005861F
			// (set) Token: 0x060021A4 RID: 8612 RVA: 0x0005A435 File Offset: 0x00058635
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

			// Token: 0x17000C64 RID: 3172
			// (get) Token: 0x060021A5 RID: 8613 RVA: 0x0005A44C File Offset: 0x0005864C
			// (set) Token: 0x060021A6 RID: 8614 RVA: 0x0005A462 File Offset: 0x00058662
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

			// Token: 0x17000C65 RID: 3173
			// (get) Token: 0x060021A7 RID: 8615 RVA: 0x0005A479 File Offset: 0x00058679
			// (set) Token: 0x060021A8 RID: 8616 RVA: 0x0005A48F File Offset: 0x0005868F
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

			// Token: 0x17000C66 RID: 3174
			// (get) Token: 0x060021A9 RID: 8617 RVA: 0x0005A4A6 File Offset: 0x000586A6
			// (set) Token: 0x060021AA RID: 8618 RVA: 0x0005A4BC File Offset: 0x000586BC
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

			// Token: 0x17000C67 RID: 3175
			// (get) Token: 0x060021AB RID: 8619 RVA: 0x0005A4D4 File Offset: 0x000586D4
			internal static IntPtr class_ref
			{
				get
				{
					return R.Dimen._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x17000C68 RID: 3176
			// (get) Token: 0x060021AC RID: 8620 RVA: 0x0005A4F8 File Offset: 0x000586F8
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return R.Dimen._members;
				}
			}

			// Token: 0x17000C69 RID: 3177
			// (get) Token: 0x060021AD RID: 8621 RVA: 0x0005A500 File Offset: 0x00058700
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return R.Dimen._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x17000C6A RID: 3178
			// (get) Token: 0x060021AE RID: 8622 RVA: 0x0005A524 File Offset: 0x00058724
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return R.Dimen._members.ManagedPeerType;
				}
			}

			// Token: 0x060021AF RID: 8623 RVA: 0x000021E8 File Offset: 0x000003E8
			internal Dimen(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
			{
			}

			// Token: 0x0400070D RID: 1805
			private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/scar/adapter/v1950/R$dimen", typeof(R.Dimen));
		}

		// Token: 0x0200026A RID: 618
		[Register("com/unity3d/scar/adapter/v1950/R$drawable", DoNotGenerateAcw = true)]
		public sealed class Drawable : Java.Lang.Object
		{
			// Token: 0x17000C6B RID: 3179
			// (get) Token: 0x060021B1 RID: 8625 RVA: 0x0005A54B File Offset: 0x0005874B
			// (set) Token: 0x060021B2 RID: 8626 RVA: 0x0005A561 File Offset: 0x00058761
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

			// Token: 0x17000C6C RID: 3180
			// (get) Token: 0x060021B3 RID: 8627 RVA: 0x0005A578 File Offset: 0x00058778
			// (set) Token: 0x060021B4 RID: 8628 RVA: 0x0005A58E File Offset: 0x0005878E
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

			// Token: 0x17000C6D RID: 3181
			// (get) Token: 0x060021B5 RID: 8629 RVA: 0x0005A5A5 File Offset: 0x000587A5
			// (set) Token: 0x060021B6 RID: 8630 RVA: 0x0005A5BB File Offset: 0x000587BB
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

			// Token: 0x17000C6E RID: 3182
			// (get) Token: 0x060021B7 RID: 8631 RVA: 0x0005A5D2 File Offset: 0x000587D2
			// (set) Token: 0x060021B8 RID: 8632 RVA: 0x0005A5E8 File Offset: 0x000587E8
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

			// Token: 0x17000C6F RID: 3183
			// (get) Token: 0x060021B9 RID: 8633 RVA: 0x0005A5FF File Offset: 0x000587FF
			// (set) Token: 0x060021BA RID: 8634 RVA: 0x0005A615 File Offset: 0x00058815
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

			// Token: 0x17000C70 RID: 3184
			// (get) Token: 0x060021BB RID: 8635 RVA: 0x0005A62C File Offset: 0x0005882C
			// (set) Token: 0x060021BC RID: 8636 RVA: 0x0005A642 File Offset: 0x00058842
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

			// Token: 0x17000C71 RID: 3185
			// (get) Token: 0x060021BD RID: 8637 RVA: 0x0005A659 File Offset: 0x00058859
			// (set) Token: 0x060021BE RID: 8638 RVA: 0x0005A66F File Offset: 0x0005886F
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

			// Token: 0x17000C72 RID: 3186
			// (get) Token: 0x060021BF RID: 8639 RVA: 0x0005A686 File Offset: 0x00058886
			// (set) Token: 0x060021C0 RID: 8640 RVA: 0x0005A69C File Offset: 0x0005889C
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

			// Token: 0x17000C73 RID: 3187
			// (get) Token: 0x060021C1 RID: 8641 RVA: 0x0005A6B3 File Offset: 0x000588B3
			// (set) Token: 0x060021C2 RID: 8642 RVA: 0x0005A6C9 File Offset: 0x000588C9
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

			// Token: 0x17000C74 RID: 3188
			// (get) Token: 0x060021C3 RID: 8643 RVA: 0x0005A6E0 File Offset: 0x000588E0
			// (set) Token: 0x060021C4 RID: 8644 RVA: 0x0005A6F6 File Offset: 0x000588F6
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

			// Token: 0x17000C75 RID: 3189
			// (get) Token: 0x060021C5 RID: 8645 RVA: 0x0005A70D File Offset: 0x0005890D
			// (set) Token: 0x060021C6 RID: 8646 RVA: 0x0005A723 File Offset: 0x00058923
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

			// Token: 0x17000C76 RID: 3190
			// (get) Token: 0x060021C7 RID: 8647 RVA: 0x0005A73A File Offset: 0x0005893A
			// (set) Token: 0x060021C8 RID: 8648 RVA: 0x0005A750 File Offset: 0x00058950
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

			// Token: 0x17000C77 RID: 3191
			// (get) Token: 0x060021C9 RID: 8649 RVA: 0x0005A768 File Offset: 0x00058968
			internal static IntPtr class_ref
			{
				get
				{
					return R.Drawable._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x17000C78 RID: 3192
			// (get) Token: 0x060021CA RID: 8650 RVA: 0x0005A78C File Offset: 0x0005898C
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return R.Drawable._members;
				}
			}

			// Token: 0x17000C79 RID: 3193
			// (get) Token: 0x060021CB RID: 8651 RVA: 0x0005A794 File Offset: 0x00058994
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return R.Drawable._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x17000C7A RID: 3194
			// (get) Token: 0x060021CC RID: 8652 RVA: 0x0005A7B8 File Offset: 0x000589B8
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return R.Drawable._members.ManagedPeerType;
				}
			}

			// Token: 0x060021CD RID: 8653 RVA: 0x000021E8 File Offset: 0x000003E8
			internal Drawable(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
			{
			}

			// Token: 0x0400070E RID: 1806
			private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/scar/adapter/v1950/R$drawable", typeof(R.Drawable));
		}

		// Token: 0x0200026B RID: 619
		[Register("com/unity3d/scar/adapter/v1950/R$id", DoNotGenerateAcw = true)]
		public sealed class Id : Java.Lang.Object
		{
			// Token: 0x17000C7B RID: 3195
			// (get) Token: 0x060021CF RID: 8655 RVA: 0x0005A7DF File Offset: 0x000589DF
			// (set) Token: 0x060021D0 RID: 8656 RVA: 0x0005A7F5 File Offset: 0x000589F5
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

			// Token: 0x17000C7C RID: 3196
			// (get) Token: 0x060021D1 RID: 8657 RVA: 0x0005A80C File Offset: 0x00058A0C
			// (set) Token: 0x060021D2 RID: 8658 RVA: 0x0005A822 File Offset: 0x00058A22
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

			// Token: 0x17000C7D RID: 3197
			// (get) Token: 0x060021D3 RID: 8659 RVA: 0x0005A839 File Offset: 0x00058A39
			// (set) Token: 0x060021D4 RID: 8660 RVA: 0x0005A84F File Offset: 0x00058A4F
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

			// Token: 0x17000C7E RID: 3198
			// (get) Token: 0x060021D5 RID: 8661 RVA: 0x0005A866 File Offset: 0x00058A66
			// (set) Token: 0x060021D6 RID: 8662 RVA: 0x0005A87C File Offset: 0x00058A7C
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

			// Token: 0x17000C7F RID: 3199
			// (get) Token: 0x060021D7 RID: 8663 RVA: 0x0005A893 File Offset: 0x00058A93
			// (set) Token: 0x060021D8 RID: 8664 RVA: 0x0005A8A9 File Offset: 0x00058AA9
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

			// Token: 0x17000C80 RID: 3200
			// (get) Token: 0x060021D9 RID: 8665 RVA: 0x0005A8C0 File Offset: 0x00058AC0
			// (set) Token: 0x060021DA RID: 8666 RVA: 0x0005A8D6 File Offset: 0x00058AD6
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

			// Token: 0x17000C81 RID: 3201
			// (get) Token: 0x060021DB RID: 8667 RVA: 0x0005A8ED File Offset: 0x00058AED
			// (set) Token: 0x060021DC RID: 8668 RVA: 0x0005A903 File Offset: 0x00058B03
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

			// Token: 0x17000C82 RID: 3202
			// (get) Token: 0x060021DD RID: 8669 RVA: 0x0005A91A File Offset: 0x00058B1A
			// (set) Token: 0x060021DE RID: 8670 RVA: 0x0005A930 File Offset: 0x00058B30
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

			// Token: 0x17000C83 RID: 3203
			// (get) Token: 0x060021DF RID: 8671 RVA: 0x0005A947 File Offset: 0x00058B47
			// (set) Token: 0x060021E0 RID: 8672 RVA: 0x0005A95D File Offset: 0x00058B5D
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

			// Token: 0x17000C84 RID: 3204
			// (get) Token: 0x060021E1 RID: 8673 RVA: 0x0005A974 File Offset: 0x00058B74
			// (set) Token: 0x060021E2 RID: 8674 RVA: 0x0005A98A File Offset: 0x00058B8A
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

			// Token: 0x17000C85 RID: 3205
			// (get) Token: 0x060021E3 RID: 8675 RVA: 0x0005A9A1 File Offset: 0x00058BA1
			// (set) Token: 0x060021E4 RID: 8676 RVA: 0x0005A9B7 File Offset: 0x00058BB7
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

			// Token: 0x17000C86 RID: 3206
			// (get) Token: 0x060021E5 RID: 8677 RVA: 0x0005A9CE File Offset: 0x00058BCE
			// (set) Token: 0x060021E6 RID: 8678 RVA: 0x0005A9E4 File Offset: 0x00058BE4
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

			// Token: 0x17000C87 RID: 3207
			// (get) Token: 0x060021E7 RID: 8679 RVA: 0x0005A9FB File Offset: 0x00058BFB
			// (set) Token: 0x060021E8 RID: 8680 RVA: 0x0005AA11 File Offset: 0x00058C11
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

			// Token: 0x17000C88 RID: 3208
			// (get) Token: 0x060021E9 RID: 8681 RVA: 0x0005AA28 File Offset: 0x00058C28
			// (set) Token: 0x060021EA RID: 8682 RVA: 0x0005AA3E File Offset: 0x00058C3E
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

			// Token: 0x17000C89 RID: 3209
			// (get) Token: 0x060021EB RID: 8683 RVA: 0x0005AA55 File Offset: 0x00058C55
			// (set) Token: 0x060021EC RID: 8684 RVA: 0x0005AA6B File Offset: 0x00058C6B
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

			// Token: 0x17000C8A RID: 3210
			// (get) Token: 0x060021ED RID: 8685 RVA: 0x0005AA82 File Offset: 0x00058C82
			// (set) Token: 0x060021EE RID: 8686 RVA: 0x0005AA98 File Offset: 0x00058C98
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

			// Token: 0x17000C8B RID: 3211
			// (get) Token: 0x060021EF RID: 8687 RVA: 0x0005AAAF File Offset: 0x00058CAF
			// (set) Token: 0x060021F0 RID: 8688 RVA: 0x0005AAC5 File Offset: 0x00058CC5
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

			// Token: 0x17000C8C RID: 3212
			// (get) Token: 0x060021F1 RID: 8689 RVA: 0x0005AADC File Offset: 0x00058CDC
			// (set) Token: 0x060021F2 RID: 8690 RVA: 0x0005AAF2 File Offset: 0x00058CF2
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

			// Token: 0x17000C8D RID: 3213
			// (get) Token: 0x060021F3 RID: 8691 RVA: 0x0005AB09 File Offset: 0x00058D09
			// (set) Token: 0x060021F4 RID: 8692 RVA: 0x0005AB1F File Offset: 0x00058D1F
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

			// Token: 0x17000C8E RID: 3214
			// (get) Token: 0x060021F5 RID: 8693 RVA: 0x0005AB36 File Offset: 0x00058D36
			// (set) Token: 0x060021F6 RID: 8694 RVA: 0x0005AB4C File Offset: 0x00058D4C
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

			// Token: 0x17000C8F RID: 3215
			// (get) Token: 0x060021F7 RID: 8695 RVA: 0x0005AB63 File Offset: 0x00058D63
			// (set) Token: 0x060021F8 RID: 8696 RVA: 0x0005AB79 File Offset: 0x00058D79
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

			// Token: 0x17000C90 RID: 3216
			// (get) Token: 0x060021F9 RID: 8697 RVA: 0x0005AB90 File Offset: 0x00058D90
			// (set) Token: 0x060021FA RID: 8698 RVA: 0x0005ABA6 File Offset: 0x00058DA6
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

			// Token: 0x17000C91 RID: 3217
			// (get) Token: 0x060021FB RID: 8699 RVA: 0x0005ABBD File Offset: 0x00058DBD
			// (set) Token: 0x060021FC RID: 8700 RVA: 0x0005ABD3 File Offset: 0x00058DD3
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

			// Token: 0x17000C92 RID: 3218
			// (get) Token: 0x060021FD RID: 8701 RVA: 0x0005ABEA File Offset: 0x00058DEA
			// (set) Token: 0x060021FE RID: 8702 RVA: 0x0005AC00 File Offset: 0x00058E00
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

			// Token: 0x17000C93 RID: 3219
			// (get) Token: 0x060021FF RID: 8703 RVA: 0x0005AC17 File Offset: 0x00058E17
			// (set) Token: 0x06002200 RID: 8704 RVA: 0x0005AC2D File Offset: 0x00058E2D
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

			// Token: 0x17000C94 RID: 3220
			// (get) Token: 0x06002201 RID: 8705 RVA: 0x0005AC44 File Offset: 0x00058E44
			// (set) Token: 0x06002202 RID: 8706 RVA: 0x0005AC5A File Offset: 0x00058E5A
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

			// Token: 0x17000C95 RID: 3221
			// (get) Token: 0x06002203 RID: 8707 RVA: 0x0005AC71 File Offset: 0x00058E71
			// (set) Token: 0x06002204 RID: 8708 RVA: 0x0005AC87 File Offset: 0x00058E87
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

			// Token: 0x17000C96 RID: 3222
			// (get) Token: 0x06002205 RID: 8709 RVA: 0x0005AC9E File Offset: 0x00058E9E
			// (set) Token: 0x06002206 RID: 8710 RVA: 0x0005ACB4 File Offset: 0x00058EB4
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

			// Token: 0x17000C97 RID: 3223
			// (get) Token: 0x06002207 RID: 8711 RVA: 0x0005ACCB File Offset: 0x00058ECB
			// (set) Token: 0x06002208 RID: 8712 RVA: 0x0005ACE1 File Offset: 0x00058EE1
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

			// Token: 0x17000C98 RID: 3224
			// (get) Token: 0x06002209 RID: 8713 RVA: 0x0005ACF8 File Offset: 0x00058EF8
			// (set) Token: 0x0600220A RID: 8714 RVA: 0x0005AD0E File Offset: 0x00058F0E
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

			// Token: 0x17000C99 RID: 3225
			// (get) Token: 0x0600220B RID: 8715 RVA: 0x0005AD25 File Offset: 0x00058F25
			// (set) Token: 0x0600220C RID: 8716 RVA: 0x0005AD3B File Offset: 0x00058F3B
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

			// Token: 0x17000C9A RID: 3226
			// (get) Token: 0x0600220D RID: 8717 RVA: 0x0005AD52 File Offset: 0x00058F52
			// (set) Token: 0x0600220E RID: 8718 RVA: 0x0005AD68 File Offset: 0x00058F68
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

			// Token: 0x17000C9B RID: 3227
			// (get) Token: 0x0600220F RID: 8719 RVA: 0x0005AD7F File Offset: 0x00058F7F
			// (set) Token: 0x06002210 RID: 8720 RVA: 0x0005AD95 File Offset: 0x00058F95
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

			// Token: 0x17000C9C RID: 3228
			// (get) Token: 0x06002211 RID: 8721 RVA: 0x0005ADAC File Offset: 0x00058FAC
			// (set) Token: 0x06002212 RID: 8722 RVA: 0x0005ADC2 File Offset: 0x00058FC2
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

			// Token: 0x17000C9D RID: 3229
			// (get) Token: 0x06002213 RID: 8723 RVA: 0x0005ADD9 File Offset: 0x00058FD9
			// (set) Token: 0x06002214 RID: 8724 RVA: 0x0005ADEF File Offset: 0x00058FEF
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

			// Token: 0x17000C9E RID: 3230
			// (get) Token: 0x06002215 RID: 8725 RVA: 0x0005AE06 File Offset: 0x00059006
			// (set) Token: 0x06002216 RID: 8726 RVA: 0x0005AE1C File Offset: 0x0005901C
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

			// Token: 0x17000C9F RID: 3231
			// (get) Token: 0x06002217 RID: 8727 RVA: 0x0005AE33 File Offset: 0x00059033
			// (set) Token: 0x06002218 RID: 8728 RVA: 0x0005AE49 File Offset: 0x00059049
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

			// Token: 0x17000CA0 RID: 3232
			// (get) Token: 0x06002219 RID: 8729 RVA: 0x0005AE60 File Offset: 0x00059060
			// (set) Token: 0x0600221A RID: 8730 RVA: 0x0005AE76 File Offset: 0x00059076
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

			// Token: 0x17000CA1 RID: 3233
			// (get) Token: 0x0600221B RID: 8731 RVA: 0x0005AE8D File Offset: 0x0005908D
			// (set) Token: 0x0600221C RID: 8732 RVA: 0x0005AEA3 File Offset: 0x000590A3
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

			// Token: 0x17000CA2 RID: 3234
			// (get) Token: 0x0600221D RID: 8733 RVA: 0x0005AEBA File Offset: 0x000590BA
			// (set) Token: 0x0600221E RID: 8734 RVA: 0x0005AED0 File Offset: 0x000590D0
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

			// Token: 0x17000CA3 RID: 3235
			// (get) Token: 0x0600221F RID: 8735 RVA: 0x0005AEE7 File Offset: 0x000590E7
			// (set) Token: 0x06002220 RID: 8736 RVA: 0x0005AEFD File Offset: 0x000590FD
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

			// Token: 0x17000CA4 RID: 3236
			// (get) Token: 0x06002221 RID: 8737 RVA: 0x0005AF14 File Offset: 0x00059114
			// (set) Token: 0x06002222 RID: 8738 RVA: 0x0005AF2A File Offset: 0x0005912A
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

			// Token: 0x17000CA5 RID: 3237
			// (get) Token: 0x06002223 RID: 8739 RVA: 0x0005AF41 File Offset: 0x00059141
			// (set) Token: 0x06002224 RID: 8740 RVA: 0x0005AF57 File Offset: 0x00059157
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

			// Token: 0x17000CA6 RID: 3238
			// (get) Token: 0x06002225 RID: 8741 RVA: 0x0005AF6E File Offset: 0x0005916E
			// (set) Token: 0x06002226 RID: 8742 RVA: 0x0005AF84 File Offset: 0x00059184
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

			// Token: 0x17000CA7 RID: 3239
			// (get) Token: 0x06002227 RID: 8743 RVA: 0x0005AF9B File Offset: 0x0005919B
			// (set) Token: 0x06002228 RID: 8744 RVA: 0x0005AFB1 File Offset: 0x000591B1
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

			// Token: 0x17000CA8 RID: 3240
			// (get) Token: 0x06002229 RID: 8745 RVA: 0x0005AFC8 File Offset: 0x000591C8
			// (set) Token: 0x0600222A RID: 8746 RVA: 0x0005AFDE File Offset: 0x000591DE
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

			// Token: 0x17000CA9 RID: 3241
			// (get) Token: 0x0600222B RID: 8747 RVA: 0x0005AFF5 File Offset: 0x000591F5
			// (set) Token: 0x0600222C RID: 8748 RVA: 0x0005B00B File Offset: 0x0005920B
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

			// Token: 0x17000CAA RID: 3242
			// (get) Token: 0x0600222D RID: 8749 RVA: 0x0005B022 File Offset: 0x00059222
			// (set) Token: 0x0600222E RID: 8750 RVA: 0x0005B038 File Offset: 0x00059238
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

			// Token: 0x17000CAB RID: 3243
			// (get) Token: 0x0600222F RID: 8751 RVA: 0x0005B04F File Offset: 0x0005924F
			// (set) Token: 0x06002230 RID: 8752 RVA: 0x0005B065 File Offset: 0x00059265
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

			// Token: 0x17000CAC RID: 3244
			// (get) Token: 0x06002231 RID: 8753 RVA: 0x0005B07C File Offset: 0x0005927C
			// (set) Token: 0x06002232 RID: 8754 RVA: 0x0005B092 File Offset: 0x00059292
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

			// Token: 0x17000CAD RID: 3245
			// (get) Token: 0x06002233 RID: 8755 RVA: 0x0005B0A9 File Offset: 0x000592A9
			// (set) Token: 0x06002234 RID: 8756 RVA: 0x0005B0BF File Offset: 0x000592BF
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

			// Token: 0x17000CAE RID: 3246
			// (get) Token: 0x06002235 RID: 8757 RVA: 0x0005B0D6 File Offset: 0x000592D6
			// (set) Token: 0x06002236 RID: 8758 RVA: 0x0005B0EC File Offset: 0x000592EC
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

			// Token: 0x17000CAF RID: 3247
			// (get) Token: 0x06002237 RID: 8759 RVA: 0x0005B103 File Offset: 0x00059303
			// (set) Token: 0x06002238 RID: 8760 RVA: 0x0005B119 File Offset: 0x00059319
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

			// Token: 0x17000CB0 RID: 3248
			// (get) Token: 0x06002239 RID: 8761 RVA: 0x0005B130 File Offset: 0x00059330
			// (set) Token: 0x0600223A RID: 8762 RVA: 0x0005B146 File Offset: 0x00059346
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

			// Token: 0x17000CB1 RID: 3249
			// (get) Token: 0x0600223B RID: 8763 RVA: 0x0005B15D File Offset: 0x0005935D
			// (set) Token: 0x0600223C RID: 8764 RVA: 0x0005B173 File Offset: 0x00059373
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

			// Token: 0x17000CB2 RID: 3250
			// (get) Token: 0x0600223D RID: 8765 RVA: 0x0005B18A File Offset: 0x0005938A
			// (set) Token: 0x0600223E RID: 8766 RVA: 0x0005B1A0 File Offset: 0x000593A0
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

			// Token: 0x17000CB3 RID: 3251
			// (get) Token: 0x0600223F RID: 8767 RVA: 0x0005B1B7 File Offset: 0x000593B7
			// (set) Token: 0x06002240 RID: 8768 RVA: 0x0005B1CD File Offset: 0x000593CD
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

			// Token: 0x17000CB4 RID: 3252
			// (get) Token: 0x06002241 RID: 8769 RVA: 0x0005B1E4 File Offset: 0x000593E4
			// (set) Token: 0x06002242 RID: 8770 RVA: 0x0005B1FA File Offset: 0x000593FA
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

			// Token: 0x17000CB5 RID: 3253
			// (get) Token: 0x06002243 RID: 8771 RVA: 0x0005B211 File Offset: 0x00059411
			// (set) Token: 0x06002244 RID: 8772 RVA: 0x0005B227 File Offset: 0x00059427
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

			// Token: 0x17000CB6 RID: 3254
			// (get) Token: 0x06002245 RID: 8773 RVA: 0x0005B23E File Offset: 0x0005943E
			// (set) Token: 0x06002246 RID: 8774 RVA: 0x0005B254 File Offset: 0x00059454
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

			// Token: 0x17000CB7 RID: 3255
			// (get) Token: 0x06002247 RID: 8775 RVA: 0x0005B26B File Offset: 0x0005946B
			// (set) Token: 0x06002248 RID: 8776 RVA: 0x0005B281 File Offset: 0x00059481
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

			// Token: 0x17000CB8 RID: 3256
			// (get) Token: 0x06002249 RID: 8777 RVA: 0x0005B298 File Offset: 0x00059498
			// (set) Token: 0x0600224A RID: 8778 RVA: 0x0005B2AE File Offset: 0x000594AE
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

			// Token: 0x17000CB9 RID: 3257
			// (get) Token: 0x0600224B RID: 8779 RVA: 0x0005B2C5 File Offset: 0x000594C5
			// (set) Token: 0x0600224C RID: 8780 RVA: 0x0005B2DB File Offset: 0x000594DB
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

			// Token: 0x17000CBA RID: 3258
			// (get) Token: 0x0600224D RID: 8781 RVA: 0x0005B2F2 File Offset: 0x000594F2
			// (set) Token: 0x0600224E RID: 8782 RVA: 0x0005B308 File Offset: 0x00059508
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

			// Token: 0x17000CBB RID: 3259
			// (get) Token: 0x0600224F RID: 8783 RVA: 0x0005B31F File Offset: 0x0005951F
			// (set) Token: 0x06002250 RID: 8784 RVA: 0x0005B335 File Offset: 0x00059535
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

			// Token: 0x17000CBC RID: 3260
			// (get) Token: 0x06002251 RID: 8785 RVA: 0x0005B34C File Offset: 0x0005954C
			// (set) Token: 0x06002252 RID: 8786 RVA: 0x0005B362 File Offset: 0x00059562
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

			// Token: 0x17000CBD RID: 3261
			// (get) Token: 0x06002253 RID: 8787 RVA: 0x0005B379 File Offset: 0x00059579
			// (set) Token: 0x06002254 RID: 8788 RVA: 0x0005B38F File Offset: 0x0005958F
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

			// Token: 0x17000CBE RID: 3262
			// (get) Token: 0x06002255 RID: 8789 RVA: 0x0005B3A6 File Offset: 0x000595A6
			// (set) Token: 0x06002256 RID: 8790 RVA: 0x0005B3BC File Offset: 0x000595BC
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

			// Token: 0x17000CBF RID: 3263
			// (get) Token: 0x06002257 RID: 8791 RVA: 0x0005B3D3 File Offset: 0x000595D3
			// (set) Token: 0x06002258 RID: 8792 RVA: 0x0005B3E9 File Offset: 0x000595E9
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

			// Token: 0x17000CC0 RID: 3264
			// (get) Token: 0x06002259 RID: 8793 RVA: 0x0005B400 File Offset: 0x00059600
			// (set) Token: 0x0600225A RID: 8794 RVA: 0x0005B416 File Offset: 0x00059616
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

			// Token: 0x17000CC1 RID: 3265
			// (get) Token: 0x0600225B RID: 8795 RVA: 0x0005B42D File Offset: 0x0005962D
			// (set) Token: 0x0600225C RID: 8796 RVA: 0x0005B443 File Offset: 0x00059643
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

			// Token: 0x17000CC2 RID: 3266
			// (get) Token: 0x0600225D RID: 8797 RVA: 0x0005B45A File Offset: 0x0005965A
			// (set) Token: 0x0600225E RID: 8798 RVA: 0x0005B470 File Offset: 0x00059670
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

			// Token: 0x17000CC3 RID: 3267
			// (get) Token: 0x0600225F RID: 8799 RVA: 0x0005B487 File Offset: 0x00059687
			// (set) Token: 0x06002260 RID: 8800 RVA: 0x0005B49D File Offset: 0x0005969D
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

			// Token: 0x17000CC4 RID: 3268
			// (get) Token: 0x06002261 RID: 8801 RVA: 0x0005B4B4 File Offset: 0x000596B4
			// (set) Token: 0x06002262 RID: 8802 RVA: 0x0005B4CA File Offset: 0x000596CA
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

			// Token: 0x17000CC5 RID: 3269
			// (get) Token: 0x06002263 RID: 8803 RVA: 0x0005B4E1 File Offset: 0x000596E1
			// (set) Token: 0x06002264 RID: 8804 RVA: 0x0005B4F7 File Offset: 0x000596F7
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

			// Token: 0x17000CC6 RID: 3270
			// (get) Token: 0x06002265 RID: 8805 RVA: 0x0005B50E File Offset: 0x0005970E
			// (set) Token: 0x06002266 RID: 8806 RVA: 0x0005B524 File Offset: 0x00059724
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

			// Token: 0x17000CC7 RID: 3271
			// (get) Token: 0x06002267 RID: 8807 RVA: 0x0005B53B File Offset: 0x0005973B
			// (set) Token: 0x06002268 RID: 8808 RVA: 0x0005B551 File Offset: 0x00059751
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

			// Token: 0x17000CC8 RID: 3272
			// (get) Token: 0x06002269 RID: 8809 RVA: 0x0005B568 File Offset: 0x00059768
			// (set) Token: 0x0600226A RID: 8810 RVA: 0x0005B57E File Offset: 0x0005977E
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

			// Token: 0x17000CC9 RID: 3273
			// (get) Token: 0x0600226B RID: 8811 RVA: 0x0005B595 File Offset: 0x00059795
			// (set) Token: 0x0600226C RID: 8812 RVA: 0x0005B5AB File Offset: 0x000597AB
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

			// Token: 0x17000CCA RID: 3274
			// (get) Token: 0x0600226D RID: 8813 RVA: 0x0005B5C4 File Offset: 0x000597C4
			internal static IntPtr class_ref
			{
				get
				{
					return R.Id._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x17000CCB RID: 3275
			// (get) Token: 0x0600226E RID: 8814 RVA: 0x0005B5E8 File Offset: 0x000597E8
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return R.Id._members;
				}
			}

			// Token: 0x17000CCC RID: 3276
			// (get) Token: 0x0600226F RID: 8815 RVA: 0x0005B5F0 File Offset: 0x000597F0
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return R.Id._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x17000CCD RID: 3277
			// (get) Token: 0x06002270 RID: 8816 RVA: 0x0005B614 File Offset: 0x00059814
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return R.Id._members.ManagedPeerType;
				}
			}

			// Token: 0x06002271 RID: 8817 RVA: 0x000021E8 File Offset: 0x000003E8
			internal Id(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
			{
			}

			// Token: 0x0400070F RID: 1807
			private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/scar/adapter/v1950/R$id", typeof(R.Id));
		}

		// Token: 0x0200026C RID: 620
		[Register("com/unity3d/scar/adapter/v1950/R$integer", DoNotGenerateAcw = true)]
		public sealed class Integer : Java.Lang.Object
		{
			// Token: 0x17000CCE RID: 3278
			// (get) Token: 0x06002273 RID: 8819 RVA: 0x0005B63B File Offset: 0x0005983B
			// (set) Token: 0x06002274 RID: 8820 RVA: 0x0005B651 File Offset: 0x00059851
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

			// Token: 0x17000CCF RID: 3279
			// (get) Token: 0x06002275 RID: 8821 RVA: 0x0005B668 File Offset: 0x00059868
			// (set) Token: 0x06002276 RID: 8822 RVA: 0x0005B67E File Offset: 0x0005987E
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

			// Token: 0x17000CD0 RID: 3280
			// (get) Token: 0x06002277 RID: 8823 RVA: 0x0005B698 File Offset: 0x00059898
			internal static IntPtr class_ref
			{
				get
				{
					return R.Integer._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x17000CD1 RID: 3281
			// (get) Token: 0x06002278 RID: 8824 RVA: 0x0005B6BC File Offset: 0x000598BC
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return R.Integer._members;
				}
			}

			// Token: 0x17000CD2 RID: 3282
			// (get) Token: 0x06002279 RID: 8825 RVA: 0x0005B6C4 File Offset: 0x000598C4
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return R.Integer._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x17000CD3 RID: 3283
			// (get) Token: 0x0600227A RID: 8826 RVA: 0x0005B6E8 File Offset: 0x000598E8
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return R.Integer._members.ManagedPeerType;
				}
			}

			// Token: 0x0600227B RID: 8827 RVA: 0x000021E8 File Offset: 0x000003E8
			internal Integer(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
			{
			}

			// Token: 0x04000710 RID: 1808
			private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/scar/adapter/v1950/R$integer", typeof(R.Integer));
		}

		// Token: 0x0200026D RID: 621
		[Register("com/unity3d/scar/adapter/v1950/R$layout", DoNotGenerateAcw = true)]
		public sealed class Layout : Java.Lang.Object
		{
			// Token: 0x17000CD4 RID: 3284
			// (get) Token: 0x0600227D RID: 8829 RVA: 0x0005B70F File Offset: 0x0005990F
			// (set) Token: 0x0600227E RID: 8830 RVA: 0x0005B725 File Offset: 0x00059925
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

			// Token: 0x17000CD5 RID: 3285
			// (get) Token: 0x0600227F RID: 8831 RVA: 0x0005B73C File Offset: 0x0005993C
			// (set) Token: 0x06002280 RID: 8832 RVA: 0x0005B752 File Offset: 0x00059952
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

			// Token: 0x17000CD6 RID: 3286
			// (get) Token: 0x06002281 RID: 8833 RVA: 0x0005B769 File Offset: 0x00059969
			// (set) Token: 0x06002282 RID: 8834 RVA: 0x0005B77F File Offset: 0x0005997F
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

			// Token: 0x17000CD7 RID: 3287
			// (get) Token: 0x06002283 RID: 8835 RVA: 0x0005B796 File Offset: 0x00059996
			// (set) Token: 0x06002284 RID: 8836 RVA: 0x0005B7AC File Offset: 0x000599AC
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

			// Token: 0x17000CD8 RID: 3288
			// (get) Token: 0x06002285 RID: 8837 RVA: 0x0005B7C3 File Offset: 0x000599C3
			// (set) Token: 0x06002286 RID: 8838 RVA: 0x0005B7D9 File Offset: 0x000599D9
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

			// Token: 0x17000CD9 RID: 3289
			// (get) Token: 0x06002287 RID: 8839 RVA: 0x0005B7F0 File Offset: 0x000599F0
			// (set) Token: 0x06002288 RID: 8840 RVA: 0x0005B806 File Offset: 0x00059A06
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

			// Token: 0x17000CDA RID: 3290
			// (get) Token: 0x06002289 RID: 8841 RVA: 0x0005B81D File Offset: 0x00059A1D
			// (set) Token: 0x0600228A RID: 8842 RVA: 0x0005B833 File Offset: 0x00059A33
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

			// Token: 0x17000CDB RID: 3291
			// (get) Token: 0x0600228B RID: 8843 RVA: 0x0005B84A File Offset: 0x00059A4A
			// (set) Token: 0x0600228C RID: 8844 RVA: 0x0005B860 File Offset: 0x00059A60
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

			// Token: 0x17000CDC RID: 3292
			// (get) Token: 0x0600228D RID: 8845 RVA: 0x0005B877 File Offset: 0x00059A77
			// (set) Token: 0x0600228E RID: 8846 RVA: 0x0005B88D File Offset: 0x00059A8D
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

			// Token: 0x17000CDD RID: 3293
			// (get) Token: 0x0600228F RID: 8847 RVA: 0x0005B8A4 File Offset: 0x00059AA4
			internal static IntPtr class_ref
			{
				get
				{
					return R.Layout._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x17000CDE RID: 3294
			// (get) Token: 0x06002290 RID: 8848 RVA: 0x0005B8C8 File Offset: 0x00059AC8
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return R.Layout._members;
				}
			}

			// Token: 0x17000CDF RID: 3295
			// (get) Token: 0x06002291 RID: 8849 RVA: 0x0005B8D0 File Offset: 0x00059AD0
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return R.Layout._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x17000CE0 RID: 3296
			// (get) Token: 0x06002292 RID: 8850 RVA: 0x0005B8F4 File Offset: 0x00059AF4
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return R.Layout._members.ManagedPeerType;
				}
			}

			// Token: 0x06002293 RID: 8851 RVA: 0x000021E8 File Offset: 0x000003E8
			internal Layout(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
			{
			}

			// Token: 0x04000711 RID: 1809
			private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/scar/adapter/v1950/R$layout", typeof(R.Layout));
		}

		// Token: 0x0200026E RID: 622
		[Register("com/unity3d/scar/adapter/v1950/R$string", DoNotGenerateAcw = true)]
		public sealed class String : Java.Lang.Object
		{
			// Token: 0x17000CE1 RID: 3297
			// (get) Token: 0x06002295 RID: 8853 RVA: 0x0005B91B File Offset: 0x00059B1B
			// (set) Token: 0x06002296 RID: 8854 RVA: 0x0005B931 File Offset: 0x00059B31
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

			// Token: 0x17000CE2 RID: 3298
			// (get) Token: 0x06002297 RID: 8855 RVA: 0x0005B948 File Offset: 0x00059B48
			// (set) Token: 0x06002298 RID: 8856 RVA: 0x0005B95E File Offset: 0x00059B5E
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

			// Token: 0x17000CE3 RID: 3299
			// (get) Token: 0x06002299 RID: 8857 RVA: 0x0005B975 File Offset: 0x00059B75
			// (set) Token: 0x0600229A RID: 8858 RVA: 0x0005B98B File Offset: 0x00059B8B
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

			// Token: 0x17000CE4 RID: 3300
			// (get) Token: 0x0600229B RID: 8859 RVA: 0x0005B9A2 File Offset: 0x00059BA2
			// (set) Token: 0x0600229C RID: 8860 RVA: 0x0005B9B8 File Offset: 0x00059BB8
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

			// Token: 0x17000CE5 RID: 3301
			// (get) Token: 0x0600229D RID: 8861 RVA: 0x0005B9CF File Offset: 0x00059BCF
			// (set) Token: 0x0600229E RID: 8862 RVA: 0x0005B9E5 File Offset: 0x00059BE5
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

			// Token: 0x17000CE6 RID: 3302
			// (get) Token: 0x0600229F RID: 8863 RVA: 0x0005B9FC File Offset: 0x00059BFC
			// (set) Token: 0x060022A0 RID: 8864 RVA: 0x0005BA12 File Offset: 0x00059C12
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

			// Token: 0x17000CE7 RID: 3303
			// (get) Token: 0x060022A1 RID: 8865 RVA: 0x0005BA29 File Offset: 0x00059C29
			// (set) Token: 0x060022A2 RID: 8866 RVA: 0x0005BA3F File Offset: 0x00059C3F
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

			// Token: 0x17000CE8 RID: 3304
			// (get) Token: 0x060022A3 RID: 8867 RVA: 0x0005BA56 File Offset: 0x00059C56
			// (set) Token: 0x060022A4 RID: 8868 RVA: 0x0005BA6C File Offset: 0x00059C6C
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

			// Token: 0x17000CE9 RID: 3305
			// (get) Token: 0x060022A5 RID: 8869 RVA: 0x0005BA83 File Offset: 0x00059C83
			// (set) Token: 0x060022A6 RID: 8870 RVA: 0x0005BA99 File Offset: 0x00059C99
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

			// Token: 0x17000CEA RID: 3306
			// (get) Token: 0x060022A7 RID: 8871 RVA: 0x0005BAB0 File Offset: 0x00059CB0
			// (set) Token: 0x060022A8 RID: 8872 RVA: 0x0005BAC6 File Offset: 0x00059CC6
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

			// Token: 0x17000CEB RID: 3307
			// (get) Token: 0x060022A9 RID: 8873 RVA: 0x0005BADD File Offset: 0x00059CDD
			// (set) Token: 0x060022AA RID: 8874 RVA: 0x0005BAF3 File Offset: 0x00059CF3
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

			// Token: 0x17000CEC RID: 3308
			// (get) Token: 0x060022AB RID: 8875 RVA: 0x0005BB0A File Offset: 0x00059D0A
			// (set) Token: 0x060022AC RID: 8876 RVA: 0x0005BB20 File Offset: 0x00059D20
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

			// Token: 0x17000CED RID: 3309
			// (get) Token: 0x060022AD RID: 8877 RVA: 0x0005BB37 File Offset: 0x00059D37
			// (set) Token: 0x060022AE RID: 8878 RVA: 0x0005BB4D File Offset: 0x00059D4D
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

			// Token: 0x17000CEE RID: 3310
			// (get) Token: 0x060022AF RID: 8879 RVA: 0x0005BB64 File Offset: 0x00059D64
			// (set) Token: 0x060022B0 RID: 8880 RVA: 0x0005BB7A File Offset: 0x00059D7A
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

			// Token: 0x17000CEF RID: 3311
			// (get) Token: 0x060022B1 RID: 8881 RVA: 0x0005BB91 File Offset: 0x00059D91
			// (set) Token: 0x060022B2 RID: 8882 RVA: 0x0005BBA7 File Offset: 0x00059DA7
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

			// Token: 0x17000CF0 RID: 3312
			// (get) Token: 0x060022B3 RID: 8883 RVA: 0x0005BBBE File Offset: 0x00059DBE
			// (set) Token: 0x060022B4 RID: 8884 RVA: 0x0005BBD4 File Offset: 0x00059DD4
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

			// Token: 0x17000CF1 RID: 3313
			// (get) Token: 0x060022B5 RID: 8885 RVA: 0x0005BBEC File Offset: 0x00059DEC
			internal static IntPtr class_ref
			{
				get
				{
					return R.String._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x17000CF2 RID: 3314
			// (get) Token: 0x060022B6 RID: 8886 RVA: 0x0005BC10 File Offset: 0x00059E10
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return R.String._members;
				}
			}

			// Token: 0x17000CF3 RID: 3315
			// (get) Token: 0x060022B7 RID: 8887 RVA: 0x0005BC18 File Offset: 0x00059E18
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return R.String._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x17000CF4 RID: 3316
			// (get) Token: 0x060022B8 RID: 8888 RVA: 0x0005BC3C File Offset: 0x00059E3C
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return R.String._members.ManagedPeerType;
				}
			}

			// Token: 0x060022B9 RID: 8889 RVA: 0x000021E8 File Offset: 0x000003E8
			internal String(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
			{
			}

			// Token: 0x04000712 RID: 1810
			private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/scar/adapter/v1950/R$string", typeof(R.String));
		}

		// Token: 0x0200026F RID: 623
		[Register("com/unity3d/scar/adapter/v1950/R$style", DoNotGenerateAcw = true)]
		public sealed class Style : Java.Lang.Object
		{
			// Token: 0x17000CF5 RID: 3317
			// (get) Token: 0x060022BB RID: 8891 RVA: 0x0005BC63 File Offset: 0x00059E63
			// (set) Token: 0x060022BC RID: 8892 RVA: 0x0005BC79 File Offset: 0x00059E79
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

			// Token: 0x17000CF6 RID: 3318
			// (get) Token: 0x060022BD RID: 8893 RVA: 0x0005BC90 File Offset: 0x00059E90
			// (set) Token: 0x060022BE RID: 8894 RVA: 0x0005BCA6 File Offset: 0x00059EA6
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

			// Token: 0x17000CF7 RID: 3319
			// (get) Token: 0x060022BF RID: 8895 RVA: 0x0005BCBD File Offset: 0x00059EBD
			// (set) Token: 0x060022C0 RID: 8896 RVA: 0x0005BCD3 File Offset: 0x00059ED3
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

			// Token: 0x17000CF8 RID: 3320
			// (get) Token: 0x060022C1 RID: 8897 RVA: 0x0005BCEA File Offset: 0x00059EEA
			// (set) Token: 0x060022C2 RID: 8898 RVA: 0x0005BD00 File Offset: 0x00059F00
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

			// Token: 0x17000CF9 RID: 3321
			// (get) Token: 0x060022C3 RID: 8899 RVA: 0x0005BD17 File Offset: 0x00059F17
			// (set) Token: 0x060022C4 RID: 8900 RVA: 0x0005BD2D File Offset: 0x00059F2D
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

			// Token: 0x17000CFA RID: 3322
			// (get) Token: 0x060022C5 RID: 8901 RVA: 0x0005BD44 File Offset: 0x00059F44
			// (set) Token: 0x060022C6 RID: 8902 RVA: 0x0005BD5A File Offset: 0x00059F5A
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

			// Token: 0x17000CFB RID: 3323
			// (get) Token: 0x060022C7 RID: 8903 RVA: 0x0005BD71 File Offset: 0x00059F71
			// (set) Token: 0x060022C8 RID: 8904 RVA: 0x0005BD87 File Offset: 0x00059F87
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

			// Token: 0x17000CFC RID: 3324
			// (get) Token: 0x060022C9 RID: 8905 RVA: 0x0005BD9E File Offset: 0x00059F9E
			// (set) Token: 0x060022CA RID: 8906 RVA: 0x0005BDB4 File Offset: 0x00059FB4
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

			// Token: 0x17000CFD RID: 3325
			// (get) Token: 0x060022CB RID: 8907 RVA: 0x0005BDCB File Offset: 0x00059FCB
			// (set) Token: 0x060022CC RID: 8908 RVA: 0x0005BDE1 File Offset: 0x00059FE1
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

			// Token: 0x17000CFE RID: 3326
			// (get) Token: 0x060022CD RID: 8909 RVA: 0x0005BDF8 File Offset: 0x00059FF8
			internal static IntPtr class_ref
			{
				get
				{
					return R.Style._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x17000CFF RID: 3327
			// (get) Token: 0x060022CE RID: 8910 RVA: 0x0005BE1C File Offset: 0x0005A01C
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return R.Style._members;
				}
			}

			// Token: 0x17000D00 RID: 3328
			// (get) Token: 0x060022CF RID: 8911 RVA: 0x0005BE24 File Offset: 0x0005A024
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return R.Style._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x17000D01 RID: 3329
			// (get) Token: 0x060022D0 RID: 8912 RVA: 0x0005BE48 File Offset: 0x0005A048
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return R.Style._members.ManagedPeerType;
				}
			}

			// Token: 0x060022D1 RID: 8913 RVA: 0x000021E8 File Offset: 0x000003E8
			internal Style(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
			{
			}

			// Token: 0x04000713 RID: 1811
			private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/scar/adapter/v1950/R$style", typeof(R.Style));
		}

		// Token: 0x02000270 RID: 624
		[Register("com/unity3d/scar/adapter/v1950/R$styleable", DoNotGenerateAcw = true)]
		public sealed class Styleable : Java.Lang.Object
		{
			// Token: 0x17000D02 RID: 3330
			// (get) Token: 0x060022D3 RID: 8915 RVA: 0x0005BE70 File Offset: 0x0005A070
			// (set) Token: 0x060022D4 RID: 8916 RVA: 0x0005BEA0 File Offset: 0x0005A0A0
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

			// Token: 0x17000D03 RID: 3331
			// (get) Token: 0x060022D5 RID: 8917 RVA: 0x0005BEE8 File Offset: 0x0005A0E8
			// (set) Token: 0x060022D6 RID: 8918 RVA: 0x0005BEFE File Offset: 0x0005A0FE
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

			// Token: 0x17000D04 RID: 3332
			// (get) Token: 0x060022D7 RID: 8919 RVA: 0x0005BF15 File Offset: 0x0005A115
			// (set) Token: 0x060022D8 RID: 8920 RVA: 0x0005BF2B File Offset: 0x0005A12B
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

			// Token: 0x17000D05 RID: 3333
			// (get) Token: 0x060022D9 RID: 8921 RVA: 0x0005BF42 File Offset: 0x0005A142
			// (set) Token: 0x060022DA RID: 8922 RVA: 0x0005BF58 File Offset: 0x0005A158
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

			// Token: 0x17000D06 RID: 3334
			// (get) Token: 0x060022DB RID: 8923 RVA: 0x0005BF70 File Offset: 0x0005A170
			// (set) Token: 0x060022DC RID: 8924 RVA: 0x0005BFA0 File Offset: 0x0005A1A0
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

			// Token: 0x17000D07 RID: 3335
			// (get) Token: 0x060022DD RID: 8925 RVA: 0x0005BFE8 File Offset: 0x0005A1E8
			// (set) Token: 0x060022DE RID: 8926 RVA: 0x0005BFFE File Offset: 0x0005A1FE
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

			// Token: 0x17000D08 RID: 3336
			// (get) Token: 0x060022DF RID: 8927 RVA: 0x0005C015 File Offset: 0x0005A215
			// (set) Token: 0x060022E0 RID: 8928 RVA: 0x0005C02B File Offset: 0x0005A22B
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

			// Token: 0x17000D09 RID: 3337
			// (get) Token: 0x060022E1 RID: 8929 RVA: 0x0005C042 File Offset: 0x0005A242
			// (set) Token: 0x060022E2 RID: 8930 RVA: 0x0005C058 File Offset: 0x0005A258
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

			// Token: 0x17000D0A RID: 3338
			// (get) Token: 0x060022E3 RID: 8931 RVA: 0x0005C070 File Offset: 0x0005A270
			// (set) Token: 0x060022E4 RID: 8932 RVA: 0x0005C0A0 File Offset: 0x0005A2A0
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

			// Token: 0x17000D0B RID: 3339
			// (get) Token: 0x060022E5 RID: 8933 RVA: 0x0005C0E8 File Offset: 0x0005A2E8
			// (set) Token: 0x060022E6 RID: 8934 RVA: 0x0005C0FE File Offset: 0x0005A2FE
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

			// Token: 0x17000D0C RID: 3340
			// (get) Token: 0x060022E7 RID: 8935 RVA: 0x0005C118 File Offset: 0x0005A318
			// (set) Token: 0x060022E8 RID: 8936 RVA: 0x0005C148 File Offset: 0x0005A348
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

			// Token: 0x17000D0D RID: 3341
			// (get) Token: 0x060022E9 RID: 8937 RVA: 0x0005C190 File Offset: 0x0005A390
			// (set) Token: 0x060022EA RID: 8938 RVA: 0x0005C1A6 File Offset: 0x0005A3A6
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

			// Token: 0x17000D0E RID: 3342
			// (get) Token: 0x060022EB RID: 8939 RVA: 0x0005C1BD File Offset: 0x0005A3BD
			// (set) Token: 0x060022EC RID: 8940 RVA: 0x0005C1D3 File Offset: 0x0005A3D3
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

			// Token: 0x17000D0F RID: 3343
			// (get) Token: 0x060022ED RID: 8941 RVA: 0x0005C1EA File Offset: 0x0005A3EA
			// (set) Token: 0x060022EE RID: 8942 RVA: 0x0005C200 File Offset: 0x0005A400
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

			// Token: 0x17000D10 RID: 3344
			// (get) Token: 0x060022EF RID: 8943 RVA: 0x0005C217 File Offset: 0x0005A417
			// (set) Token: 0x060022F0 RID: 8944 RVA: 0x0005C22D File Offset: 0x0005A42D
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

			// Token: 0x17000D11 RID: 3345
			// (get) Token: 0x060022F1 RID: 8945 RVA: 0x0005C244 File Offset: 0x0005A444
			// (set) Token: 0x060022F2 RID: 8946 RVA: 0x0005C25A File Offset: 0x0005A45A
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

			// Token: 0x17000D12 RID: 3346
			// (get) Token: 0x060022F3 RID: 8947 RVA: 0x0005C271 File Offset: 0x0005A471
			// (set) Token: 0x060022F4 RID: 8948 RVA: 0x0005C287 File Offset: 0x0005A487
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

			// Token: 0x17000D13 RID: 3347
			// (get) Token: 0x060022F5 RID: 8949 RVA: 0x0005C29E File Offset: 0x0005A49E
			// (set) Token: 0x060022F6 RID: 8950 RVA: 0x0005C2B4 File Offset: 0x0005A4B4
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

			// Token: 0x17000D14 RID: 3348
			// (get) Token: 0x060022F7 RID: 8951 RVA: 0x0005C2CB File Offset: 0x0005A4CB
			// (set) Token: 0x060022F8 RID: 8952 RVA: 0x0005C2E1 File Offset: 0x0005A4E1
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

			// Token: 0x17000D15 RID: 3349
			// (get) Token: 0x060022F9 RID: 8953 RVA: 0x0005C2F8 File Offset: 0x0005A4F8
			// (set) Token: 0x060022FA RID: 8954 RVA: 0x0005C328 File Offset: 0x0005A528
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

			// Token: 0x17000D16 RID: 3350
			// (get) Token: 0x060022FB RID: 8955 RVA: 0x0005C370 File Offset: 0x0005A570
			// (set) Token: 0x060022FC RID: 8956 RVA: 0x0005C3A0 File Offset: 0x0005A5A0
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

			// Token: 0x17000D17 RID: 3351
			// (get) Token: 0x060022FD RID: 8957 RVA: 0x0005C3E8 File Offset: 0x0005A5E8
			// (set) Token: 0x060022FE RID: 8958 RVA: 0x0005C3FE File Offset: 0x0005A5FE
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

			// Token: 0x17000D18 RID: 3352
			// (get) Token: 0x060022FF RID: 8959 RVA: 0x0005C415 File Offset: 0x0005A615
			// (set) Token: 0x06002300 RID: 8960 RVA: 0x0005C42B File Offset: 0x0005A62B
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

			// Token: 0x17000D19 RID: 3353
			// (get) Token: 0x06002301 RID: 8961 RVA: 0x0005C442 File Offset: 0x0005A642
			// (set) Token: 0x06002302 RID: 8962 RVA: 0x0005C458 File Offset: 0x0005A658
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

			// Token: 0x17000D1A RID: 3354
			// (get) Token: 0x06002303 RID: 8963 RVA: 0x0005C46F File Offset: 0x0005A66F
			// (set) Token: 0x06002304 RID: 8964 RVA: 0x0005C485 File Offset: 0x0005A685
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

			// Token: 0x17000D1B RID: 3355
			// (get) Token: 0x06002305 RID: 8965 RVA: 0x0005C49C File Offset: 0x0005A69C
			// (set) Token: 0x06002306 RID: 8966 RVA: 0x0005C4B2 File Offset: 0x0005A6B2
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

			// Token: 0x17000D1C RID: 3356
			// (get) Token: 0x06002307 RID: 8967 RVA: 0x0005C4C9 File Offset: 0x0005A6C9
			// (set) Token: 0x06002308 RID: 8968 RVA: 0x0005C4DF File Offset: 0x0005A6DF
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

			// Token: 0x17000D1D RID: 3357
			// (get) Token: 0x06002309 RID: 8969 RVA: 0x0005C4F6 File Offset: 0x0005A6F6
			// (set) Token: 0x0600230A RID: 8970 RVA: 0x0005C50C File Offset: 0x0005A70C
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

			// Token: 0x17000D1E RID: 3358
			// (get) Token: 0x0600230B RID: 8971 RVA: 0x0005C523 File Offset: 0x0005A723
			// (set) Token: 0x0600230C RID: 8972 RVA: 0x0005C539 File Offset: 0x0005A739
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

			// Token: 0x17000D1F RID: 3359
			// (get) Token: 0x0600230D RID: 8973 RVA: 0x0005C550 File Offset: 0x0005A750
			// (set) Token: 0x0600230E RID: 8974 RVA: 0x0005C566 File Offset: 0x0005A766
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

			// Token: 0x17000D20 RID: 3360
			// (get) Token: 0x0600230F RID: 8975 RVA: 0x0005C57D File Offset: 0x0005A77D
			// (set) Token: 0x06002310 RID: 8976 RVA: 0x0005C593 File Offset: 0x0005A793
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

			// Token: 0x17000D21 RID: 3361
			// (get) Token: 0x06002311 RID: 8977 RVA: 0x0005C5AA File Offset: 0x0005A7AA
			// (set) Token: 0x06002312 RID: 8978 RVA: 0x0005C5C0 File Offset: 0x0005A7C0
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

			// Token: 0x17000D22 RID: 3362
			// (get) Token: 0x06002313 RID: 8979 RVA: 0x0005C5D7 File Offset: 0x0005A7D7
			// (set) Token: 0x06002314 RID: 8980 RVA: 0x0005C5ED File Offset: 0x0005A7ED
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

			// Token: 0x17000D23 RID: 3363
			// (get) Token: 0x06002315 RID: 8981 RVA: 0x0005C604 File Offset: 0x0005A804
			// (set) Token: 0x06002316 RID: 8982 RVA: 0x0005C61A File Offset: 0x0005A81A
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

			// Token: 0x17000D24 RID: 3364
			// (get) Token: 0x06002317 RID: 8983 RVA: 0x0005C631 File Offset: 0x0005A831
			// (set) Token: 0x06002318 RID: 8984 RVA: 0x0005C647 File Offset: 0x0005A847
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

			// Token: 0x17000D25 RID: 3365
			// (get) Token: 0x06002319 RID: 8985 RVA: 0x0005C65E File Offset: 0x0005A85E
			// (set) Token: 0x0600231A RID: 8986 RVA: 0x0005C674 File Offset: 0x0005A874
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

			// Token: 0x17000D26 RID: 3366
			// (get) Token: 0x0600231B RID: 8987 RVA: 0x0005C68B File Offset: 0x0005A88B
			// (set) Token: 0x0600231C RID: 8988 RVA: 0x0005C6A1 File Offset: 0x0005A8A1
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

			// Token: 0x17000D27 RID: 3367
			// (get) Token: 0x0600231D RID: 8989 RVA: 0x0005C6B8 File Offset: 0x0005A8B8
			// (set) Token: 0x0600231E RID: 8990 RVA: 0x0005C6E8 File Offset: 0x0005A8E8
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

			// Token: 0x17000D28 RID: 3368
			// (get) Token: 0x0600231F RID: 8991 RVA: 0x0005C730 File Offset: 0x0005A930
			// (set) Token: 0x06002320 RID: 8992 RVA: 0x0005C760 File Offset: 0x0005A960
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

			// Token: 0x17000D29 RID: 3369
			// (get) Token: 0x06002321 RID: 8993 RVA: 0x0005C7A8 File Offset: 0x0005A9A8
			// (set) Token: 0x06002322 RID: 8994 RVA: 0x0005C7BE File Offset: 0x0005A9BE
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

			// Token: 0x17000D2A RID: 3370
			// (get) Token: 0x06002323 RID: 8995 RVA: 0x0005C7D5 File Offset: 0x0005A9D5
			// (set) Token: 0x06002324 RID: 8996 RVA: 0x0005C7EB File Offset: 0x0005A9EB
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

			// Token: 0x17000D2B RID: 3371
			// (get) Token: 0x06002325 RID: 8997 RVA: 0x0005C802 File Offset: 0x0005AA02
			// (set) Token: 0x06002326 RID: 8998 RVA: 0x0005C818 File Offset: 0x0005AA18
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

			// Token: 0x17000D2C RID: 3372
			// (get) Token: 0x06002327 RID: 8999 RVA: 0x0005C82F File Offset: 0x0005AA2F
			// (set) Token: 0x06002328 RID: 9000 RVA: 0x0005C845 File Offset: 0x0005AA45
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

			// Token: 0x17000D2D RID: 3373
			// (get) Token: 0x06002329 RID: 9001 RVA: 0x0005C85C File Offset: 0x0005AA5C
			// (set) Token: 0x0600232A RID: 9002 RVA: 0x0005C872 File Offset: 0x0005AA72
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

			// Token: 0x17000D2E RID: 3374
			// (get) Token: 0x0600232B RID: 9003 RVA: 0x0005C889 File Offset: 0x0005AA89
			// (set) Token: 0x0600232C RID: 9004 RVA: 0x0005C89F File Offset: 0x0005AA9F
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

			// Token: 0x17000D2F RID: 3375
			// (get) Token: 0x0600232D RID: 9005 RVA: 0x0005C8B6 File Offset: 0x0005AAB6
			// (set) Token: 0x0600232E RID: 9006 RVA: 0x0005C8CC File Offset: 0x0005AACC
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

			// Token: 0x17000D30 RID: 3376
			// (get) Token: 0x0600232F RID: 9007 RVA: 0x0005C8E3 File Offset: 0x0005AAE3
			// (set) Token: 0x06002330 RID: 9008 RVA: 0x0005C8F9 File Offset: 0x0005AAF9
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

			// Token: 0x17000D31 RID: 3377
			// (get) Token: 0x06002331 RID: 9009 RVA: 0x0005C910 File Offset: 0x0005AB10
			// (set) Token: 0x06002332 RID: 9010 RVA: 0x0005C926 File Offset: 0x0005AB26
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

			// Token: 0x17000D32 RID: 3378
			// (get) Token: 0x06002333 RID: 9011 RVA: 0x0005C93D File Offset: 0x0005AB3D
			// (set) Token: 0x06002334 RID: 9012 RVA: 0x0005C953 File Offset: 0x0005AB53
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

			// Token: 0x17000D33 RID: 3379
			// (get) Token: 0x06002335 RID: 9013 RVA: 0x0005C96A File Offset: 0x0005AB6A
			// (set) Token: 0x06002336 RID: 9014 RVA: 0x0005C980 File Offset: 0x0005AB80
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

			// Token: 0x17000D34 RID: 3380
			// (get) Token: 0x06002337 RID: 9015 RVA: 0x0005C997 File Offset: 0x0005AB97
			// (set) Token: 0x06002338 RID: 9016 RVA: 0x0005C9AD File Offset: 0x0005ABAD
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

			// Token: 0x17000D35 RID: 3381
			// (get) Token: 0x06002339 RID: 9017 RVA: 0x0005C9C4 File Offset: 0x0005ABC4
			// (set) Token: 0x0600233A RID: 9018 RVA: 0x0005C9DA File Offset: 0x0005ABDA
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

			// Token: 0x17000D36 RID: 3382
			// (get) Token: 0x0600233B RID: 9019 RVA: 0x0005C9F1 File Offset: 0x0005ABF1
			// (set) Token: 0x0600233C RID: 9020 RVA: 0x0005CA07 File Offset: 0x0005AC07
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

			// Token: 0x17000D37 RID: 3383
			// (get) Token: 0x0600233D RID: 9021 RVA: 0x0005CA20 File Offset: 0x0005AC20
			internal static IntPtr class_ref
			{
				get
				{
					return R.Styleable._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x17000D38 RID: 3384
			// (get) Token: 0x0600233E RID: 9022 RVA: 0x0005CA44 File Offset: 0x0005AC44
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return R.Styleable._members;
				}
			}

			// Token: 0x17000D39 RID: 3385
			// (get) Token: 0x0600233F RID: 9023 RVA: 0x0005CA4C File Offset: 0x0005AC4C
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return R.Styleable._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x17000D3A RID: 3386
			// (get) Token: 0x06002340 RID: 9024 RVA: 0x0005CA70 File Offset: 0x0005AC70
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return R.Styleable._members.ManagedPeerType;
				}
			}

			// Token: 0x06002341 RID: 9025 RVA: 0x000021E8 File Offset: 0x000003E8
			internal Styleable(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
			{
			}

			// Token: 0x04000714 RID: 1812
			private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/scar/adapter/v1950/R$styleable", typeof(R.Styleable));
		}
	}
}
