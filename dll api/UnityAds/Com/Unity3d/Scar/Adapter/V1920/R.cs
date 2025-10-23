using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Com.Unity3d.Scar.Adapter.V1920
{
	// Token: 0x0200027E RID: 638
	[Register("com/unity3d/scar/adapter/v1920/R", DoNotGenerateAcw = true)]
	public sealed class R : Java.Lang.Object
	{
		// Token: 0x17000D60 RID: 3424
		// (get) Token: 0x060023AB RID: 9131 RVA: 0x0005DA9C File Offset: 0x0005BC9C
		internal static IntPtr class_ref
		{
			get
			{
				return R._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000D61 RID: 3425
		// (get) Token: 0x060023AC RID: 9132 RVA: 0x0005DAC0 File Offset: 0x0005BCC0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return R._members;
			}
		}

		// Token: 0x17000D62 RID: 3426
		// (get) Token: 0x060023AD RID: 9133 RVA: 0x0005DAC8 File Offset: 0x0005BCC8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return R._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000D63 RID: 3427
		// (get) Token: 0x060023AE RID: 9134 RVA: 0x0005DAEC File Offset: 0x0005BCEC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return R._members.ManagedPeerType;
			}
		}

		// Token: 0x060023AF RID: 9135 RVA: 0x000021E8 File Offset: 0x000003E8
		internal R(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x04000732 RID: 1842
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/scar/adapter/v1920/R", typeof(R));

		// Token: 0x0200027F RID: 639
		[Register("com/unity3d/scar/adapter/v1920/R$attr", DoNotGenerateAcw = true)]
		public sealed class Attr : Java.Lang.Object
		{
			// Token: 0x17000D64 RID: 3428
			// (get) Token: 0x060023B1 RID: 9137 RVA: 0x0005DB13 File Offset: 0x0005BD13
			// (set) Token: 0x060023B2 RID: 9138 RVA: 0x0005DB29 File Offset: 0x0005BD29
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

			// Token: 0x17000D65 RID: 3429
			// (get) Token: 0x060023B3 RID: 9139 RVA: 0x0005DB40 File Offset: 0x0005BD40
			// (set) Token: 0x060023B4 RID: 9140 RVA: 0x0005DB56 File Offset: 0x0005BD56
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

			// Token: 0x17000D66 RID: 3430
			// (get) Token: 0x060023B5 RID: 9141 RVA: 0x0005DB6D File Offset: 0x0005BD6D
			// (set) Token: 0x060023B6 RID: 9142 RVA: 0x0005DB83 File Offset: 0x0005BD83
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

			// Token: 0x17000D67 RID: 3431
			// (get) Token: 0x060023B7 RID: 9143 RVA: 0x0005DB9A File Offset: 0x0005BD9A
			// (set) Token: 0x060023B8 RID: 9144 RVA: 0x0005DBB0 File Offset: 0x0005BDB0
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

			// Token: 0x17000D68 RID: 3432
			// (get) Token: 0x060023B9 RID: 9145 RVA: 0x0005DBC7 File Offset: 0x0005BDC7
			// (set) Token: 0x060023BA RID: 9146 RVA: 0x0005DBDD File Offset: 0x0005BDDD
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

			// Token: 0x17000D69 RID: 3433
			// (get) Token: 0x060023BB RID: 9147 RVA: 0x0005DBF4 File Offset: 0x0005BDF4
			// (set) Token: 0x060023BC RID: 9148 RVA: 0x0005DC0A File Offset: 0x0005BE0A
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

			// Token: 0x17000D6A RID: 3434
			// (get) Token: 0x060023BD RID: 9149 RVA: 0x0005DC21 File Offset: 0x0005BE21
			// (set) Token: 0x060023BE RID: 9150 RVA: 0x0005DC37 File Offset: 0x0005BE37
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

			// Token: 0x17000D6B RID: 3435
			// (get) Token: 0x060023BF RID: 9151 RVA: 0x0005DC4E File Offset: 0x0005BE4E
			// (set) Token: 0x060023C0 RID: 9152 RVA: 0x0005DC64 File Offset: 0x0005BE64
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

			// Token: 0x17000D6C RID: 3436
			// (get) Token: 0x060023C1 RID: 9153 RVA: 0x0005DC7B File Offset: 0x0005BE7B
			// (set) Token: 0x060023C2 RID: 9154 RVA: 0x0005DC91 File Offset: 0x0005BE91
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

			// Token: 0x17000D6D RID: 3437
			// (get) Token: 0x060023C3 RID: 9155 RVA: 0x0005DCA8 File Offset: 0x0005BEA8
			// (set) Token: 0x060023C4 RID: 9156 RVA: 0x0005DCBE File Offset: 0x0005BEBE
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

			// Token: 0x17000D6E RID: 3438
			// (get) Token: 0x060023C5 RID: 9157 RVA: 0x0005DCD5 File Offset: 0x0005BED5
			// (set) Token: 0x060023C6 RID: 9158 RVA: 0x0005DCEB File Offset: 0x0005BEEB
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

			// Token: 0x17000D6F RID: 3439
			// (get) Token: 0x060023C7 RID: 9159 RVA: 0x0005DD02 File Offset: 0x0005BF02
			// (set) Token: 0x060023C8 RID: 9160 RVA: 0x0005DD18 File Offset: 0x0005BF18
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

			// Token: 0x17000D70 RID: 3440
			// (get) Token: 0x060023C9 RID: 9161 RVA: 0x0005DD2F File Offset: 0x0005BF2F
			// (set) Token: 0x060023CA RID: 9162 RVA: 0x0005DD45 File Offset: 0x0005BF45
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

			// Token: 0x17000D71 RID: 3441
			// (get) Token: 0x060023CB RID: 9163 RVA: 0x0005DD5C File Offset: 0x0005BF5C
			// (set) Token: 0x060023CC RID: 9164 RVA: 0x0005DD72 File Offset: 0x0005BF72
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

			// Token: 0x17000D72 RID: 3442
			// (get) Token: 0x060023CD RID: 9165 RVA: 0x0005DD89 File Offset: 0x0005BF89
			// (set) Token: 0x060023CE RID: 9166 RVA: 0x0005DD9F File Offset: 0x0005BF9F
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

			// Token: 0x17000D73 RID: 3443
			// (get) Token: 0x060023CF RID: 9167 RVA: 0x0005DDB6 File Offset: 0x0005BFB6
			// (set) Token: 0x060023D0 RID: 9168 RVA: 0x0005DDCC File Offset: 0x0005BFCC
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

			// Token: 0x17000D74 RID: 3444
			// (get) Token: 0x060023D1 RID: 9169 RVA: 0x0005DDE3 File Offset: 0x0005BFE3
			// (set) Token: 0x060023D2 RID: 9170 RVA: 0x0005DDF9 File Offset: 0x0005BFF9
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

			// Token: 0x17000D75 RID: 3445
			// (get) Token: 0x060023D3 RID: 9171 RVA: 0x0005DE10 File Offset: 0x0005C010
			// (set) Token: 0x060023D4 RID: 9172 RVA: 0x0005DE26 File Offset: 0x0005C026
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

			// Token: 0x17000D76 RID: 3446
			// (get) Token: 0x060023D5 RID: 9173 RVA: 0x0005DE3D File Offset: 0x0005C03D
			// (set) Token: 0x060023D6 RID: 9174 RVA: 0x0005DE53 File Offset: 0x0005C053
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

			// Token: 0x17000D77 RID: 3447
			// (get) Token: 0x060023D7 RID: 9175 RVA: 0x0005DE6A File Offset: 0x0005C06A
			// (set) Token: 0x060023D8 RID: 9176 RVA: 0x0005DE80 File Offset: 0x0005C080
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

			// Token: 0x17000D78 RID: 3448
			// (get) Token: 0x060023D9 RID: 9177 RVA: 0x0005DE97 File Offset: 0x0005C097
			// (set) Token: 0x060023DA RID: 9178 RVA: 0x0005DEAD File Offset: 0x0005C0AD
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

			// Token: 0x17000D79 RID: 3449
			// (get) Token: 0x060023DB RID: 9179 RVA: 0x0005DEC4 File Offset: 0x0005C0C4
			// (set) Token: 0x060023DC RID: 9180 RVA: 0x0005DEDA File Offset: 0x0005C0DA
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

			// Token: 0x17000D7A RID: 3450
			// (get) Token: 0x060023DD RID: 9181 RVA: 0x0005DEF1 File Offset: 0x0005C0F1
			// (set) Token: 0x060023DE RID: 9182 RVA: 0x0005DF07 File Offset: 0x0005C107
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

			// Token: 0x17000D7B RID: 3451
			// (get) Token: 0x060023DF RID: 9183 RVA: 0x0005DF1E File Offset: 0x0005C11E
			// (set) Token: 0x060023E0 RID: 9184 RVA: 0x0005DF34 File Offset: 0x0005C134
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

			// Token: 0x17000D7C RID: 3452
			// (get) Token: 0x060023E1 RID: 9185 RVA: 0x0005DF4C File Offset: 0x0005C14C
			internal static IntPtr class_ref
			{
				get
				{
					return R.Attr._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x17000D7D RID: 3453
			// (get) Token: 0x060023E2 RID: 9186 RVA: 0x0005DF70 File Offset: 0x0005C170
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return R.Attr._members;
				}
			}

			// Token: 0x17000D7E RID: 3454
			// (get) Token: 0x060023E3 RID: 9187 RVA: 0x0005DF78 File Offset: 0x0005C178
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return R.Attr._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x17000D7F RID: 3455
			// (get) Token: 0x060023E4 RID: 9188 RVA: 0x0005DF9C File Offset: 0x0005C19C
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return R.Attr._members.ManagedPeerType;
				}
			}

			// Token: 0x060023E5 RID: 9189 RVA: 0x000021E8 File Offset: 0x000003E8
			internal Attr(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
			{
			}

			// Token: 0x04000733 RID: 1843
			private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/scar/adapter/v1920/R$attr", typeof(R.Attr));
		}

		// Token: 0x02000280 RID: 640
		[Register("com/unity3d/scar/adapter/v1920/R$color", DoNotGenerateAcw = true)]
		public sealed class Color : Java.Lang.Object
		{
			// Token: 0x17000D80 RID: 3456
			// (get) Token: 0x060023E7 RID: 9191 RVA: 0x0005DFC3 File Offset: 0x0005C1C3
			// (set) Token: 0x060023E8 RID: 9192 RVA: 0x0005DFD9 File Offset: 0x0005C1D9
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

			// Token: 0x17000D81 RID: 3457
			// (get) Token: 0x060023E9 RID: 9193 RVA: 0x0005DFF0 File Offset: 0x0005C1F0
			// (set) Token: 0x060023EA RID: 9194 RVA: 0x0005E006 File Offset: 0x0005C206
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

			// Token: 0x17000D82 RID: 3458
			// (get) Token: 0x060023EB RID: 9195 RVA: 0x0005E01D File Offset: 0x0005C21D
			// (set) Token: 0x060023EC RID: 9196 RVA: 0x0005E033 File Offset: 0x0005C233
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

			// Token: 0x17000D83 RID: 3459
			// (get) Token: 0x060023ED RID: 9197 RVA: 0x0005E04A File Offset: 0x0005C24A
			// (set) Token: 0x060023EE RID: 9198 RVA: 0x0005E060 File Offset: 0x0005C260
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

			// Token: 0x17000D84 RID: 3460
			// (get) Token: 0x060023EF RID: 9199 RVA: 0x0005E077 File Offset: 0x0005C277
			// (set) Token: 0x060023F0 RID: 9200 RVA: 0x0005E08D File Offset: 0x0005C28D
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

			// Token: 0x17000D85 RID: 3461
			// (get) Token: 0x060023F1 RID: 9201 RVA: 0x0005E0A4 File Offset: 0x0005C2A4
			// (set) Token: 0x060023F2 RID: 9202 RVA: 0x0005E0BA File Offset: 0x0005C2BA
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

			// Token: 0x17000D86 RID: 3462
			// (get) Token: 0x060023F3 RID: 9203 RVA: 0x0005E0D1 File Offset: 0x0005C2D1
			// (set) Token: 0x060023F4 RID: 9204 RVA: 0x0005E0E7 File Offset: 0x0005C2E7
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

			// Token: 0x17000D87 RID: 3463
			// (get) Token: 0x060023F5 RID: 9205 RVA: 0x0005E0FE File Offset: 0x0005C2FE
			// (set) Token: 0x060023F6 RID: 9206 RVA: 0x0005E114 File Offset: 0x0005C314
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

			// Token: 0x17000D88 RID: 3464
			// (get) Token: 0x060023F7 RID: 9207 RVA: 0x0005E12C File Offset: 0x0005C32C
			internal static IntPtr class_ref
			{
				get
				{
					return R.Color._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x17000D89 RID: 3465
			// (get) Token: 0x060023F8 RID: 9208 RVA: 0x0005E150 File Offset: 0x0005C350
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return R.Color._members;
				}
			}

			// Token: 0x17000D8A RID: 3466
			// (get) Token: 0x060023F9 RID: 9209 RVA: 0x0005E158 File Offset: 0x0005C358
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return R.Color._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x17000D8B RID: 3467
			// (get) Token: 0x060023FA RID: 9210 RVA: 0x0005E17C File Offset: 0x0005C37C
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return R.Color._members.ManagedPeerType;
				}
			}

			// Token: 0x060023FB RID: 9211 RVA: 0x000021E8 File Offset: 0x000003E8
			internal Color(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
			{
			}

			// Token: 0x04000734 RID: 1844
			private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/scar/adapter/v1920/R$color", typeof(R.Color));
		}

		// Token: 0x02000281 RID: 641
		[Register("com/unity3d/scar/adapter/v1920/R$dimen", DoNotGenerateAcw = true)]
		public sealed class Dimen : Java.Lang.Object
		{
			// Token: 0x17000D8C RID: 3468
			// (get) Token: 0x060023FD RID: 9213 RVA: 0x0005E1A3 File Offset: 0x0005C3A3
			// (set) Token: 0x060023FE RID: 9214 RVA: 0x0005E1B9 File Offset: 0x0005C3B9
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

			// Token: 0x17000D8D RID: 3469
			// (get) Token: 0x060023FF RID: 9215 RVA: 0x0005E1D0 File Offset: 0x0005C3D0
			// (set) Token: 0x06002400 RID: 9216 RVA: 0x0005E1E6 File Offset: 0x0005C3E6
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

			// Token: 0x17000D8E RID: 3470
			// (get) Token: 0x06002401 RID: 9217 RVA: 0x0005E1FD File Offset: 0x0005C3FD
			// (set) Token: 0x06002402 RID: 9218 RVA: 0x0005E213 File Offset: 0x0005C413
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

			// Token: 0x17000D8F RID: 3471
			// (get) Token: 0x06002403 RID: 9219 RVA: 0x0005E22A File Offset: 0x0005C42A
			// (set) Token: 0x06002404 RID: 9220 RVA: 0x0005E240 File Offset: 0x0005C440
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

			// Token: 0x17000D90 RID: 3472
			// (get) Token: 0x06002405 RID: 9221 RVA: 0x0005E257 File Offset: 0x0005C457
			// (set) Token: 0x06002406 RID: 9222 RVA: 0x0005E26D File Offset: 0x0005C46D
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

			// Token: 0x17000D91 RID: 3473
			// (get) Token: 0x06002407 RID: 9223 RVA: 0x0005E284 File Offset: 0x0005C484
			// (set) Token: 0x06002408 RID: 9224 RVA: 0x0005E29A File Offset: 0x0005C49A
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

			// Token: 0x17000D92 RID: 3474
			// (get) Token: 0x06002409 RID: 9225 RVA: 0x0005E2B1 File Offset: 0x0005C4B1
			// (set) Token: 0x0600240A RID: 9226 RVA: 0x0005E2C7 File Offset: 0x0005C4C7
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

			// Token: 0x17000D93 RID: 3475
			// (get) Token: 0x0600240B RID: 9227 RVA: 0x0005E2DE File Offset: 0x0005C4DE
			// (set) Token: 0x0600240C RID: 9228 RVA: 0x0005E2F4 File Offset: 0x0005C4F4
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

			// Token: 0x17000D94 RID: 3476
			// (get) Token: 0x0600240D RID: 9229 RVA: 0x0005E30B File Offset: 0x0005C50B
			// (set) Token: 0x0600240E RID: 9230 RVA: 0x0005E321 File Offset: 0x0005C521
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

			// Token: 0x17000D95 RID: 3477
			// (get) Token: 0x0600240F RID: 9231 RVA: 0x0005E338 File Offset: 0x0005C538
			// (set) Token: 0x06002410 RID: 9232 RVA: 0x0005E34E File Offset: 0x0005C54E
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

			// Token: 0x17000D96 RID: 3478
			// (get) Token: 0x06002411 RID: 9233 RVA: 0x0005E365 File Offset: 0x0005C565
			// (set) Token: 0x06002412 RID: 9234 RVA: 0x0005E37B File Offset: 0x0005C57B
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

			// Token: 0x17000D97 RID: 3479
			// (get) Token: 0x06002413 RID: 9235 RVA: 0x0005E392 File Offset: 0x0005C592
			// (set) Token: 0x06002414 RID: 9236 RVA: 0x0005E3A8 File Offset: 0x0005C5A8
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

			// Token: 0x17000D98 RID: 3480
			// (get) Token: 0x06002415 RID: 9237 RVA: 0x0005E3BF File Offset: 0x0005C5BF
			// (set) Token: 0x06002416 RID: 9238 RVA: 0x0005E3D5 File Offset: 0x0005C5D5
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

			// Token: 0x17000D99 RID: 3481
			// (get) Token: 0x06002417 RID: 9239 RVA: 0x0005E3EC File Offset: 0x0005C5EC
			// (set) Token: 0x06002418 RID: 9240 RVA: 0x0005E402 File Offset: 0x0005C602
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

			// Token: 0x17000D9A RID: 3482
			// (get) Token: 0x06002419 RID: 9241 RVA: 0x0005E419 File Offset: 0x0005C619
			// (set) Token: 0x0600241A RID: 9242 RVA: 0x0005E42F File Offset: 0x0005C62F
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

			// Token: 0x17000D9B RID: 3483
			// (get) Token: 0x0600241B RID: 9243 RVA: 0x0005E446 File Offset: 0x0005C646
			// (set) Token: 0x0600241C RID: 9244 RVA: 0x0005E45C File Offset: 0x0005C65C
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

			// Token: 0x17000D9C RID: 3484
			// (get) Token: 0x0600241D RID: 9245 RVA: 0x0005E473 File Offset: 0x0005C673
			// (set) Token: 0x0600241E RID: 9246 RVA: 0x0005E489 File Offset: 0x0005C689
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

			// Token: 0x17000D9D RID: 3485
			// (get) Token: 0x0600241F RID: 9247 RVA: 0x0005E4A0 File Offset: 0x0005C6A0
			// (set) Token: 0x06002420 RID: 9248 RVA: 0x0005E4B6 File Offset: 0x0005C6B6
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

			// Token: 0x17000D9E RID: 3486
			// (get) Token: 0x06002421 RID: 9249 RVA: 0x0005E4CD File Offset: 0x0005C6CD
			// (set) Token: 0x06002422 RID: 9250 RVA: 0x0005E4E3 File Offset: 0x0005C6E3
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

			// Token: 0x17000D9F RID: 3487
			// (get) Token: 0x06002423 RID: 9251 RVA: 0x0005E4FA File Offset: 0x0005C6FA
			// (set) Token: 0x06002424 RID: 9252 RVA: 0x0005E510 File Offset: 0x0005C710
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

			// Token: 0x17000DA0 RID: 3488
			// (get) Token: 0x06002425 RID: 9253 RVA: 0x0005E527 File Offset: 0x0005C727
			// (set) Token: 0x06002426 RID: 9254 RVA: 0x0005E53D File Offset: 0x0005C73D
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

			// Token: 0x17000DA1 RID: 3489
			// (get) Token: 0x06002427 RID: 9255 RVA: 0x0005E554 File Offset: 0x0005C754
			// (set) Token: 0x06002428 RID: 9256 RVA: 0x0005E56A File Offset: 0x0005C76A
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

			// Token: 0x17000DA2 RID: 3490
			// (get) Token: 0x06002429 RID: 9257 RVA: 0x0005E581 File Offset: 0x0005C781
			// (set) Token: 0x0600242A RID: 9258 RVA: 0x0005E597 File Offset: 0x0005C797
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

			// Token: 0x17000DA3 RID: 3491
			// (get) Token: 0x0600242B RID: 9259 RVA: 0x0005E5AE File Offset: 0x0005C7AE
			// (set) Token: 0x0600242C RID: 9260 RVA: 0x0005E5C4 File Offset: 0x0005C7C4
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

			// Token: 0x17000DA4 RID: 3492
			// (get) Token: 0x0600242D RID: 9261 RVA: 0x0005E5DC File Offset: 0x0005C7DC
			internal static IntPtr class_ref
			{
				get
				{
					return R.Dimen._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x17000DA5 RID: 3493
			// (get) Token: 0x0600242E RID: 9262 RVA: 0x0005E600 File Offset: 0x0005C800
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return R.Dimen._members;
				}
			}

			// Token: 0x17000DA6 RID: 3494
			// (get) Token: 0x0600242F RID: 9263 RVA: 0x0005E608 File Offset: 0x0005C808
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return R.Dimen._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x17000DA7 RID: 3495
			// (get) Token: 0x06002430 RID: 9264 RVA: 0x0005E62C File Offset: 0x0005C82C
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return R.Dimen._members.ManagedPeerType;
				}
			}

			// Token: 0x06002431 RID: 9265 RVA: 0x000021E8 File Offset: 0x000003E8
			internal Dimen(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
			{
			}

			// Token: 0x04000735 RID: 1845
			private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/scar/adapter/v1920/R$dimen", typeof(R.Dimen));
		}

		// Token: 0x02000282 RID: 642
		[Register("com/unity3d/scar/adapter/v1920/R$drawable", DoNotGenerateAcw = true)]
		public sealed class Drawable : Java.Lang.Object
		{
			// Token: 0x17000DA8 RID: 3496
			// (get) Token: 0x06002433 RID: 9267 RVA: 0x0005E653 File Offset: 0x0005C853
			// (set) Token: 0x06002434 RID: 9268 RVA: 0x0005E669 File Offset: 0x0005C869
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

			// Token: 0x17000DA9 RID: 3497
			// (get) Token: 0x06002435 RID: 9269 RVA: 0x0005E680 File Offset: 0x0005C880
			// (set) Token: 0x06002436 RID: 9270 RVA: 0x0005E696 File Offset: 0x0005C896
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

			// Token: 0x17000DAA RID: 3498
			// (get) Token: 0x06002437 RID: 9271 RVA: 0x0005E6AD File Offset: 0x0005C8AD
			// (set) Token: 0x06002438 RID: 9272 RVA: 0x0005E6C3 File Offset: 0x0005C8C3
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

			// Token: 0x17000DAB RID: 3499
			// (get) Token: 0x06002439 RID: 9273 RVA: 0x0005E6DA File Offset: 0x0005C8DA
			// (set) Token: 0x0600243A RID: 9274 RVA: 0x0005E6F0 File Offset: 0x0005C8F0
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

			// Token: 0x17000DAC RID: 3500
			// (get) Token: 0x0600243B RID: 9275 RVA: 0x0005E707 File Offset: 0x0005C907
			// (set) Token: 0x0600243C RID: 9276 RVA: 0x0005E71D File Offset: 0x0005C91D
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

			// Token: 0x17000DAD RID: 3501
			// (get) Token: 0x0600243D RID: 9277 RVA: 0x0005E734 File Offset: 0x0005C934
			// (set) Token: 0x0600243E RID: 9278 RVA: 0x0005E74A File Offset: 0x0005C94A
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

			// Token: 0x17000DAE RID: 3502
			// (get) Token: 0x0600243F RID: 9279 RVA: 0x0005E761 File Offset: 0x0005C961
			// (set) Token: 0x06002440 RID: 9280 RVA: 0x0005E777 File Offset: 0x0005C977
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

			// Token: 0x17000DAF RID: 3503
			// (get) Token: 0x06002441 RID: 9281 RVA: 0x0005E78E File Offset: 0x0005C98E
			// (set) Token: 0x06002442 RID: 9282 RVA: 0x0005E7A4 File Offset: 0x0005C9A4
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

			// Token: 0x17000DB0 RID: 3504
			// (get) Token: 0x06002443 RID: 9283 RVA: 0x0005E7BB File Offset: 0x0005C9BB
			// (set) Token: 0x06002444 RID: 9284 RVA: 0x0005E7D1 File Offset: 0x0005C9D1
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

			// Token: 0x17000DB1 RID: 3505
			// (get) Token: 0x06002445 RID: 9285 RVA: 0x0005E7E8 File Offset: 0x0005C9E8
			// (set) Token: 0x06002446 RID: 9286 RVA: 0x0005E7FE File Offset: 0x0005C9FE
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

			// Token: 0x17000DB2 RID: 3506
			// (get) Token: 0x06002447 RID: 9287 RVA: 0x0005E815 File Offset: 0x0005CA15
			// (set) Token: 0x06002448 RID: 9288 RVA: 0x0005E82B File Offset: 0x0005CA2B
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

			// Token: 0x17000DB3 RID: 3507
			// (get) Token: 0x06002449 RID: 9289 RVA: 0x0005E842 File Offset: 0x0005CA42
			// (set) Token: 0x0600244A RID: 9290 RVA: 0x0005E858 File Offset: 0x0005CA58
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

			// Token: 0x17000DB4 RID: 3508
			// (get) Token: 0x0600244B RID: 9291 RVA: 0x0005E870 File Offset: 0x0005CA70
			internal static IntPtr class_ref
			{
				get
				{
					return R.Drawable._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x17000DB5 RID: 3509
			// (get) Token: 0x0600244C RID: 9292 RVA: 0x0005E894 File Offset: 0x0005CA94
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return R.Drawable._members;
				}
			}

			// Token: 0x17000DB6 RID: 3510
			// (get) Token: 0x0600244D RID: 9293 RVA: 0x0005E89C File Offset: 0x0005CA9C
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return R.Drawable._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x17000DB7 RID: 3511
			// (get) Token: 0x0600244E RID: 9294 RVA: 0x0005E8C0 File Offset: 0x0005CAC0
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return R.Drawable._members.ManagedPeerType;
				}
			}

			// Token: 0x0600244F RID: 9295 RVA: 0x000021E8 File Offset: 0x000003E8
			internal Drawable(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
			{
			}

			// Token: 0x04000736 RID: 1846
			private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/scar/adapter/v1920/R$drawable", typeof(R.Drawable));
		}

		// Token: 0x02000283 RID: 643
		[Register("com/unity3d/scar/adapter/v1920/R$id", DoNotGenerateAcw = true)]
		public sealed class Id : Java.Lang.Object
		{
			// Token: 0x17000DB8 RID: 3512
			// (get) Token: 0x06002451 RID: 9297 RVA: 0x0005E8E7 File Offset: 0x0005CAE7
			// (set) Token: 0x06002452 RID: 9298 RVA: 0x0005E8FD File Offset: 0x0005CAFD
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

			// Token: 0x17000DB9 RID: 3513
			// (get) Token: 0x06002453 RID: 9299 RVA: 0x0005E914 File Offset: 0x0005CB14
			// (set) Token: 0x06002454 RID: 9300 RVA: 0x0005E92A File Offset: 0x0005CB2A
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

			// Token: 0x17000DBA RID: 3514
			// (get) Token: 0x06002455 RID: 9301 RVA: 0x0005E941 File Offset: 0x0005CB41
			// (set) Token: 0x06002456 RID: 9302 RVA: 0x0005E957 File Offset: 0x0005CB57
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

			// Token: 0x17000DBB RID: 3515
			// (get) Token: 0x06002457 RID: 9303 RVA: 0x0005E96E File Offset: 0x0005CB6E
			// (set) Token: 0x06002458 RID: 9304 RVA: 0x0005E984 File Offset: 0x0005CB84
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

			// Token: 0x17000DBC RID: 3516
			// (get) Token: 0x06002459 RID: 9305 RVA: 0x0005E99B File Offset: 0x0005CB9B
			// (set) Token: 0x0600245A RID: 9306 RVA: 0x0005E9B1 File Offset: 0x0005CBB1
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

			// Token: 0x17000DBD RID: 3517
			// (get) Token: 0x0600245B RID: 9307 RVA: 0x0005E9C8 File Offset: 0x0005CBC8
			// (set) Token: 0x0600245C RID: 9308 RVA: 0x0005E9DE File Offset: 0x0005CBDE
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

			// Token: 0x17000DBE RID: 3518
			// (get) Token: 0x0600245D RID: 9309 RVA: 0x0005E9F5 File Offset: 0x0005CBF5
			// (set) Token: 0x0600245E RID: 9310 RVA: 0x0005EA0B File Offset: 0x0005CC0B
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

			// Token: 0x17000DBF RID: 3519
			// (get) Token: 0x0600245F RID: 9311 RVA: 0x0005EA22 File Offset: 0x0005CC22
			// (set) Token: 0x06002460 RID: 9312 RVA: 0x0005EA38 File Offset: 0x0005CC38
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

			// Token: 0x17000DC0 RID: 3520
			// (get) Token: 0x06002461 RID: 9313 RVA: 0x0005EA4F File Offset: 0x0005CC4F
			// (set) Token: 0x06002462 RID: 9314 RVA: 0x0005EA65 File Offset: 0x0005CC65
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

			// Token: 0x17000DC1 RID: 3521
			// (get) Token: 0x06002463 RID: 9315 RVA: 0x0005EA7C File Offset: 0x0005CC7C
			// (set) Token: 0x06002464 RID: 9316 RVA: 0x0005EA92 File Offset: 0x0005CC92
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

			// Token: 0x17000DC2 RID: 3522
			// (get) Token: 0x06002465 RID: 9317 RVA: 0x0005EAA9 File Offset: 0x0005CCA9
			// (set) Token: 0x06002466 RID: 9318 RVA: 0x0005EABF File Offset: 0x0005CCBF
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

			// Token: 0x17000DC3 RID: 3523
			// (get) Token: 0x06002467 RID: 9319 RVA: 0x0005EAD6 File Offset: 0x0005CCD6
			// (set) Token: 0x06002468 RID: 9320 RVA: 0x0005EAEC File Offset: 0x0005CCEC
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

			// Token: 0x17000DC4 RID: 3524
			// (get) Token: 0x06002469 RID: 9321 RVA: 0x0005EB03 File Offset: 0x0005CD03
			// (set) Token: 0x0600246A RID: 9322 RVA: 0x0005EB19 File Offset: 0x0005CD19
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

			// Token: 0x17000DC5 RID: 3525
			// (get) Token: 0x0600246B RID: 9323 RVA: 0x0005EB30 File Offset: 0x0005CD30
			// (set) Token: 0x0600246C RID: 9324 RVA: 0x0005EB46 File Offset: 0x0005CD46
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

			// Token: 0x17000DC6 RID: 3526
			// (get) Token: 0x0600246D RID: 9325 RVA: 0x0005EB5D File Offset: 0x0005CD5D
			// (set) Token: 0x0600246E RID: 9326 RVA: 0x0005EB73 File Offset: 0x0005CD73
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

			// Token: 0x17000DC7 RID: 3527
			// (get) Token: 0x0600246F RID: 9327 RVA: 0x0005EB8A File Offset: 0x0005CD8A
			// (set) Token: 0x06002470 RID: 9328 RVA: 0x0005EBA0 File Offset: 0x0005CDA0
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

			// Token: 0x17000DC8 RID: 3528
			// (get) Token: 0x06002471 RID: 9329 RVA: 0x0005EBB7 File Offset: 0x0005CDB7
			// (set) Token: 0x06002472 RID: 9330 RVA: 0x0005EBCD File Offset: 0x0005CDCD
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

			// Token: 0x17000DC9 RID: 3529
			// (get) Token: 0x06002473 RID: 9331 RVA: 0x0005EBE4 File Offset: 0x0005CDE4
			// (set) Token: 0x06002474 RID: 9332 RVA: 0x0005EBFA File Offset: 0x0005CDFA
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

			// Token: 0x17000DCA RID: 3530
			// (get) Token: 0x06002475 RID: 9333 RVA: 0x0005EC11 File Offset: 0x0005CE11
			// (set) Token: 0x06002476 RID: 9334 RVA: 0x0005EC27 File Offset: 0x0005CE27
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

			// Token: 0x17000DCB RID: 3531
			// (get) Token: 0x06002477 RID: 9335 RVA: 0x0005EC3E File Offset: 0x0005CE3E
			// (set) Token: 0x06002478 RID: 9336 RVA: 0x0005EC54 File Offset: 0x0005CE54
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

			// Token: 0x17000DCC RID: 3532
			// (get) Token: 0x06002479 RID: 9337 RVA: 0x0005EC6B File Offset: 0x0005CE6B
			// (set) Token: 0x0600247A RID: 9338 RVA: 0x0005EC81 File Offset: 0x0005CE81
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

			// Token: 0x17000DCD RID: 3533
			// (get) Token: 0x0600247B RID: 9339 RVA: 0x0005EC98 File Offset: 0x0005CE98
			// (set) Token: 0x0600247C RID: 9340 RVA: 0x0005ECAE File Offset: 0x0005CEAE
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

			// Token: 0x17000DCE RID: 3534
			// (get) Token: 0x0600247D RID: 9341 RVA: 0x0005ECC5 File Offset: 0x0005CEC5
			// (set) Token: 0x0600247E RID: 9342 RVA: 0x0005ECDB File Offset: 0x0005CEDB
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

			// Token: 0x17000DCF RID: 3535
			// (get) Token: 0x0600247F RID: 9343 RVA: 0x0005ECF2 File Offset: 0x0005CEF2
			// (set) Token: 0x06002480 RID: 9344 RVA: 0x0005ED08 File Offset: 0x0005CF08
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

			// Token: 0x17000DD0 RID: 3536
			// (get) Token: 0x06002481 RID: 9345 RVA: 0x0005ED1F File Offset: 0x0005CF1F
			// (set) Token: 0x06002482 RID: 9346 RVA: 0x0005ED35 File Offset: 0x0005CF35
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

			// Token: 0x17000DD1 RID: 3537
			// (get) Token: 0x06002483 RID: 9347 RVA: 0x0005ED4C File Offset: 0x0005CF4C
			// (set) Token: 0x06002484 RID: 9348 RVA: 0x0005ED62 File Offset: 0x0005CF62
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

			// Token: 0x17000DD2 RID: 3538
			// (get) Token: 0x06002485 RID: 9349 RVA: 0x0005ED79 File Offset: 0x0005CF79
			// (set) Token: 0x06002486 RID: 9350 RVA: 0x0005ED8F File Offset: 0x0005CF8F
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

			// Token: 0x17000DD3 RID: 3539
			// (get) Token: 0x06002487 RID: 9351 RVA: 0x0005EDA6 File Offset: 0x0005CFA6
			// (set) Token: 0x06002488 RID: 9352 RVA: 0x0005EDBC File Offset: 0x0005CFBC
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

			// Token: 0x17000DD4 RID: 3540
			// (get) Token: 0x06002489 RID: 9353 RVA: 0x0005EDD3 File Offset: 0x0005CFD3
			// (set) Token: 0x0600248A RID: 9354 RVA: 0x0005EDE9 File Offset: 0x0005CFE9
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

			// Token: 0x17000DD5 RID: 3541
			// (get) Token: 0x0600248B RID: 9355 RVA: 0x0005EE00 File Offset: 0x0005D000
			// (set) Token: 0x0600248C RID: 9356 RVA: 0x0005EE16 File Offset: 0x0005D016
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

			// Token: 0x17000DD6 RID: 3542
			// (get) Token: 0x0600248D RID: 9357 RVA: 0x0005EE2D File Offset: 0x0005D02D
			// (set) Token: 0x0600248E RID: 9358 RVA: 0x0005EE43 File Offset: 0x0005D043
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

			// Token: 0x17000DD7 RID: 3543
			// (get) Token: 0x0600248F RID: 9359 RVA: 0x0005EE5A File Offset: 0x0005D05A
			// (set) Token: 0x06002490 RID: 9360 RVA: 0x0005EE70 File Offset: 0x0005D070
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

			// Token: 0x17000DD8 RID: 3544
			// (get) Token: 0x06002491 RID: 9361 RVA: 0x0005EE87 File Offset: 0x0005D087
			// (set) Token: 0x06002492 RID: 9362 RVA: 0x0005EE9D File Offset: 0x0005D09D
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

			// Token: 0x17000DD9 RID: 3545
			// (get) Token: 0x06002493 RID: 9363 RVA: 0x0005EEB4 File Offset: 0x0005D0B4
			// (set) Token: 0x06002494 RID: 9364 RVA: 0x0005EECA File Offset: 0x0005D0CA
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

			// Token: 0x17000DDA RID: 3546
			// (get) Token: 0x06002495 RID: 9365 RVA: 0x0005EEE1 File Offset: 0x0005D0E1
			// (set) Token: 0x06002496 RID: 9366 RVA: 0x0005EEF7 File Offset: 0x0005D0F7
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

			// Token: 0x17000DDB RID: 3547
			// (get) Token: 0x06002497 RID: 9367 RVA: 0x0005EF0E File Offset: 0x0005D10E
			// (set) Token: 0x06002498 RID: 9368 RVA: 0x0005EF24 File Offset: 0x0005D124
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

			// Token: 0x17000DDC RID: 3548
			// (get) Token: 0x06002499 RID: 9369 RVA: 0x0005EF3B File Offset: 0x0005D13B
			// (set) Token: 0x0600249A RID: 9370 RVA: 0x0005EF51 File Offset: 0x0005D151
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

			// Token: 0x17000DDD RID: 3549
			// (get) Token: 0x0600249B RID: 9371 RVA: 0x0005EF68 File Offset: 0x0005D168
			// (set) Token: 0x0600249C RID: 9372 RVA: 0x0005EF7E File Offset: 0x0005D17E
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

			// Token: 0x17000DDE RID: 3550
			// (get) Token: 0x0600249D RID: 9373 RVA: 0x0005EF95 File Offset: 0x0005D195
			// (set) Token: 0x0600249E RID: 9374 RVA: 0x0005EFAB File Offset: 0x0005D1AB
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

			// Token: 0x17000DDF RID: 3551
			// (get) Token: 0x0600249F RID: 9375 RVA: 0x0005EFC2 File Offset: 0x0005D1C2
			// (set) Token: 0x060024A0 RID: 9376 RVA: 0x0005EFD8 File Offset: 0x0005D1D8
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

			// Token: 0x17000DE0 RID: 3552
			// (get) Token: 0x060024A1 RID: 9377 RVA: 0x0005EFF0 File Offset: 0x0005D1F0
			internal static IntPtr class_ref
			{
				get
				{
					return R.Id._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x17000DE1 RID: 3553
			// (get) Token: 0x060024A2 RID: 9378 RVA: 0x0005F014 File Offset: 0x0005D214
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return R.Id._members;
				}
			}

			// Token: 0x17000DE2 RID: 3554
			// (get) Token: 0x060024A3 RID: 9379 RVA: 0x0005F01C File Offset: 0x0005D21C
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return R.Id._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x17000DE3 RID: 3555
			// (get) Token: 0x060024A4 RID: 9380 RVA: 0x0005F040 File Offset: 0x0005D240
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return R.Id._members.ManagedPeerType;
				}
			}

			// Token: 0x060024A5 RID: 9381 RVA: 0x000021E8 File Offset: 0x000003E8
			internal Id(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
			{
			}

			// Token: 0x04000737 RID: 1847
			private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/scar/adapter/v1920/R$id", typeof(R.Id));
		}

		// Token: 0x02000284 RID: 644
		[Register("com/unity3d/scar/adapter/v1920/R$integer", DoNotGenerateAcw = true)]
		public sealed class Integer : Java.Lang.Object
		{
			// Token: 0x17000DE4 RID: 3556
			// (get) Token: 0x060024A7 RID: 9383 RVA: 0x0005F067 File Offset: 0x0005D267
			// (set) Token: 0x060024A8 RID: 9384 RVA: 0x0005F07D File Offset: 0x0005D27D
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

			// Token: 0x17000DE5 RID: 3557
			// (get) Token: 0x060024A9 RID: 9385 RVA: 0x0005F094 File Offset: 0x0005D294
			// (set) Token: 0x060024AA RID: 9386 RVA: 0x0005F0AA File Offset: 0x0005D2AA
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

			// Token: 0x17000DE6 RID: 3558
			// (get) Token: 0x060024AB RID: 9387 RVA: 0x0005F0C4 File Offset: 0x0005D2C4
			internal static IntPtr class_ref
			{
				get
				{
					return R.Integer._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x17000DE7 RID: 3559
			// (get) Token: 0x060024AC RID: 9388 RVA: 0x0005F0E8 File Offset: 0x0005D2E8
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return R.Integer._members;
				}
			}

			// Token: 0x17000DE8 RID: 3560
			// (get) Token: 0x060024AD RID: 9389 RVA: 0x0005F0F0 File Offset: 0x0005D2F0
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return R.Integer._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x17000DE9 RID: 3561
			// (get) Token: 0x060024AE RID: 9390 RVA: 0x0005F114 File Offset: 0x0005D314
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return R.Integer._members.ManagedPeerType;
				}
			}

			// Token: 0x060024AF RID: 9391 RVA: 0x000021E8 File Offset: 0x000003E8
			internal Integer(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
			{
			}

			// Token: 0x04000738 RID: 1848
			private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/scar/adapter/v1920/R$integer", typeof(R.Integer));
		}

		// Token: 0x02000285 RID: 645
		[Register("com/unity3d/scar/adapter/v1920/R$layout", DoNotGenerateAcw = true)]
		public sealed class Layout : Java.Lang.Object
		{
			// Token: 0x17000DEA RID: 3562
			// (get) Token: 0x060024B1 RID: 9393 RVA: 0x0005F13B File Offset: 0x0005D33B
			// (set) Token: 0x060024B2 RID: 9394 RVA: 0x0005F151 File Offset: 0x0005D351
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

			// Token: 0x17000DEB RID: 3563
			// (get) Token: 0x060024B3 RID: 9395 RVA: 0x0005F168 File Offset: 0x0005D368
			// (set) Token: 0x060024B4 RID: 9396 RVA: 0x0005F17E File Offset: 0x0005D37E
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

			// Token: 0x17000DEC RID: 3564
			// (get) Token: 0x060024B5 RID: 9397 RVA: 0x0005F195 File Offset: 0x0005D395
			// (set) Token: 0x060024B6 RID: 9398 RVA: 0x0005F1AB File Offset: 0x0005D3AB
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

			// Token: 0x17000DED RID: 3565
			// (get) Token: 0x060024B7 RID: 9399 RVA: 0x0005F1C2 File Offset: 0x0005D3C2
			// (set) Token: 0x060024B8 RID: 9400 RVA: 0x0005F1D8 File Offset: 0x0005D3D8
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

			// Token: 0x17000DEE RID: 3566
			// (get) Token: 0x060024B9 RID: 9401 RVA: 0x0005F1EF File Offset: 0x0005D3EF
			// (set) Token: 0x060024BA RID: 9402 RVA: 0x0005F205 File Offset: 0x0005D405
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

			// Token: 0x17000DEF RID: 3567
			// (get) Token: 0x060024BB RID: 9403 RVA: 0x0005F21C File Offset: 0x0005D41C
			// (set) Token: 0x060024BC RID: 9404 RVA: 0x0005F232 File Offset: 0x0005D432
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

			// Token: 0x17000DF0 RID: 3568
			// (get) Token: 0x060024BD RID: 9405 RVA: 0x0005F249 File Offset: 0x0005D449
			// (set) Token: 0x060024BE RID: 9406 RVA: 0x0005F25F File Offset: 0x0005D45F
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

			// Token: 0x17000DF1 RID: 3569
			// (get) Token: 0x060024BF RID: 9407 RVA: 0x0005F276 File Offset: 0x0005D476
			// (set) Token: 0x060024C0 RID: 9408 RVA: 0x0005F28C File Offset: 0x0005D48C
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

			// Token: 0x17000DF2 RID: 3570
			// (get) Token: 0x060024C1 RID: 9409 RVA: 0x0005F2A4 File Offset: 0x0005D4A4
			internal static IntPtr class_ref
			{
				get
				{
					return R.Layout._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x17000DF3 RID: 3571
			// (get) Token: 0x060024C2 RID: 9410 RVA: 0x0005F2C8 File Offset: 0x0005D4C8
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return R.Layout._members;
				}
			}

			// Token: 0x17000DF4 RID: 3572
			// (get) Token: 0x060024C3 RID: 9411 RVA: 0x0005F2D0 File Offset: 0x0005D4D0
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return R.Layout._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x17000DF5 RID: 3573
			// (get) Token: 0x060024C4 RID: 9412 RVA: 0x0005F2F4 File Offset: 0x0005D4F4
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return R.Layout._members.ManagedPeerType;
				}
			}

			// Token: 0x060024C5 RID: 9413 RVA: 0x000021E8 File Offset: 0x000003E8
			internal Layout(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
			{
			}

			// Token: 0x04000739 RID: 1849
			private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/scar/adapter/v1920/R$layout", typeof(R.Layout));
		}

		// Token: 0x02000286 RID: 646
		[Register("com/unity3d/scar/adapter/v1920/R$string", DoNotGenerateAcw = true)]
		public sealed class String : Java.Lang.Object
		{
			// Token: 0x17000DF6 RID: 3574
			// (get) Token: 0x060024C7 RID: 9415 RVA: 0x0005F31B File Offset: 0x0005D51B
			// (set) Token: 0x060024C8 RID: 9416 RVA: 0x0005F331 File Offset: 0x0005D531
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

			// Token: 0x17000DF7 RID: 3575
			// (get) Token: 0x060024C9 RID: 9417 RVA: 0x0005F348 File Offset: 0x0005D548
			// (set) Token: 0x060024CA RID: 9418 RVA: 0x0005F35E File Offset: 0x0005D55E
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

			// Token: 0x17000DF8 RID: 3576
			// (get) Token: 0x060024CB RID: 9419 RVA: 0x0005F375 File Offset: 0x0005D575
			// (set) Token: 0x060024CC RID: 9420 RVA: 0x0005F38B File Offset: 0x0005D58B
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

			// Token: 0x17000DF9 RID: 3577
			// (get) Token: 0x060024CD RID: 9421 RVA: 0x0005F3A2 File Offset: 0x0005D5A2
			// (set) Token: 0x060024CE RID: 9422 RVA: 0x0005F3B8 File Offset: 0x0005D5B8
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

			// Token: 0x17000DFA RID: 3578
			// (get) Token: 0x060024CF RID: 9423 RVA: 0x0005F3CF File Offset: 0x0005D5CF
			// (set) Token: 0x060024D0 RID: 9424 RVA: 0x0005F3E5 File Offset: 0x0005D5E5
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

			// Token: 0x17000DFB RID: 3579
			// (get) Token: 0x060024D1 RID: 9425 RVA: 0x0005F3FC File Offset: 0x0005D5FC
			// (set) Token: 0x060024D2 RID: 9426 RVA: 0x0005F412 File Offset: 0x0005D612
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

			// Token: 0x17000DFC RID: 3580
			// (get) Token: 0x060024D3 RID: 9427 RVA: 0x0005F429 File Offset: 0x0005D629
			// (set) Token: 0x060024D4 RID: 9428 RVA: 0x0005F43F File Offset: 0x0005D63F
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

			// Token: 0x17000DFD RID: 3581
			// (get) Token: 0x060024D5 RID: 9429 RVA: 0x0005F456 File Offset: 0x0005D656
			// (set) Token: 0x060024D6 RID: 9430 RVA: 0x0005F46C File Offset: 0x0005D66C
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

			// Token: 0x17000DFE RID: 3582
			// (get) Token: 0x060024D7 RID: 9431 RVA: 0x0005F483 File Offset: 0x0005D683
			// (set) Token: 0x060024D8 RID: 9432 RVA: 0x0005F499 File Offset: 0x0005D699
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

			// Token: 0x17000DFF RID: 3583
			// (get) Token: 0x060024D9 RID: 9433 RVA: 0x0005F4B0 File Offset: 0x0005D6B0
			internal static IntPtr class_ref
			{
				get
				{
					return R.String._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x17000E00 RID: 3584
			// (get) Token: 0x060024DA RID: 9434 RVA: 0x0005F4D4 File Offset: 0x0005D6D4
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return R.String._members;
				}
			}

			// Token: 0x17000E01 RID: 3585
			// (get) Token: 0x060024DB RID: 9435 RVA: 0x0005F4DC File Offset: 0x0005D6DC
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return R.String._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x17000E02 RID: 3586
			// (get) Token: 0x060024DC RID: 9436 RVA: 0x0005F500 File Offset: 0x0005D700
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return R.String._members.ManagedPeerType;
				}
			}

			// Token: 0x060024DD RID: 9437 RVA: 0x000021E8 File Offset: 0x000003E8
			internal String(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
			{
			}

			// Token: 0x0400073A RID: 1850
			private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/scar/adapter/v1920/R$string", typeof(R.String));
		}

		// Token: 0x02000287 RID: 647
		[Register("com/unity3d/scar/adapter/v1920/R$style", DoNotGenerateAcw = true)]
		public sealed class Style : Java.Lang.Object
		{
			// Token: 0x17000E03 RID: 3587
			// (get) Token: 0x060024DF RID: 9439 RVA: 0x0005F527 File Offset: 0x0005D727
			// (set) Token: 0x060024E0 RID: 9440 RVA: 0x0005F53D File Offset: 0x0005D73D
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

			// Token: 0x17000E04 RID: 3588
			// (get) Token: 0x060024E1 RID: 9441 RVA: 0x0005F554 File Offset: 0x0005D754
			// (set) Token: 0x060024E2 RID: 9442 RVA: 0x0005F56A File Offset: 0x0005D76A
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

			// Token: 0x17000E05 RID: 3589
			// (get) Token: 0x060024E3 RID: 9443 RVA: 0x0005F581 File Offset: 0x0005D781
			// (set) Token: 0x060024E4 RID: 9444 RVA: 0x0005F597 File Offset: 0x0005D797
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

			// Token: 0x17000E06 RID: 3590
			// (get) Token: 0x060024E5 RID: 9445 RVA: 0x0005F5AE File Offset: 0x0005D7AE
			// (set) Token: 0x060024E6 RID: 9446 RVA: 0x0005F5C4 File Offset: 0x0005D7C4
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

			// Token: 0x17000E07 RID: 3591
			// (get) Token: 0x060024E7 RID: 9447 RVA: 0x0005F5DB File Offset: 0x0005D7DB
			// (set) Token: 0x060024E8 RID: 9448 RVA: 0x0005F5F1 File Offset: 0x0005D7F1
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

			// Token: 0x17000E08 RID: 3592
			// (get) Token: 0x060024E9 RID: 9449 RVA: 0x0005F608 File Offset: 0x0005D808
			// (set) Token: 0x060024EA RID: 9450 RVA: 0x0005F61E File Offset: 0x0005D81E
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

			// Token: 0x17000E09 RID: 3593
			// (get) Token: 0x060024EB RID: 9451 RVA: 0x0005F635 File Offset: 0x0005D835
			// (set) Token: 0x060024EC RID: 9452 RVA: 0x0005F64B File Offset: 0x0005D84B
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

			// Token: 0x17000E0A RID: 3594
			// (get) Token: 0x060024ED RID: 9453 RVA: 0x0005F662 File Offset: 0x0005D862
			// (set) Token: 0x060024EE RID: 9454 RVA: 0x0005F678 File Offset: 0x0005D878
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

			// Token: 0x17000E0B RID: 3595
			// (get) Token: 0x060024EF RID: 9455 RVA: 0x0005F68F File Offset: 0x0005D88F
			// (set) Token: 0x060024F0 RID: 9456 RVA: 0x0005F6A5 File Offset: 0x0005D8A5
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

			// Token: 0x17000E0C RID: 3596
			// (get) Token: 0x060024F1 RID: 9457 RVA: 0x0005F6BC File Offset: 0x0005D8BC
			internal static IntPtr class_ref
			{
				get
				{
					return R.Style._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x17000E0D RID: 3597
			// (get) Token: 0x060024F2 RID: 9458 RVA: 0x0005F6E0 File Offset: 0x0005D8E0
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return R.Style._members;
				}
			}

			// Token: 0x17000E0E RID: 3598
			// (get) Token: 0x060024F3 RID: 9459 RVA: 0x0005F6E8 File Offset: 0x0005D8E8
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return R.Style._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x17000E0F RID: 3599
			// (get) Token: 0x060024F4 RID: 9460 RVA: 0x0005F70C File Offset: 0x0005D90C
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return R.Style._members.ManagedPeerType;
				}
			}

			// Token: 0x060024F5 RID: 9461 RVA: 0x000021E8 File Offset: 0x000003E8
			internal Style(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
			{
			}

			// Token: 0x0400073B RID: 1851
			private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/scar/adapter/v1920/R$style", typeof(R.Style));
		}

		// Token: 0x02000288 RID: 648
		[Register("com/unity3d/scar/adapter/v1920/R$styleable", DoNotGenerateAcw = true)]
		public sealed class Styleable : Java.Lang.Object
		{
			// Token: 0x17000E10 RID: 3600
			// (get) Token: 0x060024F7 RID: 9463 RVA: 0x0005F734 File Offset: 0x0005D934
			// (set) Token: 0x060024F8 RID: 9464 RVA: 0x0005F764 File Offset: 0x0005D964
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

			// Token: 0x17000E11 RID: 3601
			// (get) Token: 0x060024F9 RID: 9465 RVA: 0x0005F7AC File Offset: 0x0005D9AC
			// (set) Token: 0x060024FA RID: 9466 RVA: 0x0005F7C2 File Offset: 0x0005D9C2
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

			// Token: 0x17000E12 RID: 3602
			// (get) Token: 0x060024FB RID: 9467 RVA: 0x0005F7D9 File Offset: 0x0005D9D9
			// (set) Token: 0x060024FC RID: 9468 RVA: 0x0005F7EF File Offset: 0x0005D9EF
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

			// Token: 0x17000E13 RID: 3603
			// (get) Token: 0x060024FD RID: 9469 RVA: 0x0005F806 File Offset: 0x0005DA06
			// (set) Token: 0x060024FE RID: 9470 RVA: 0x0005F81C File Offset: 0x0005DA1C
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

			// Token: 0x17000E14 RID: 3604
			// (get) Token: 0x060024FF RID: 9471 RVA: 0x0005F834 File Offset: 0x0005DA34
			// (set) Token: 0x06002500 RID: 9472 RVA: 0x0005F864 File Offset: 0x0005DA64
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

			// Token: 0x17000E15 RID: 3605
			// (get) Token: 0x06002501 RID: 9473 RVA: 0x0005F8AC File Offset: 0x0005DAAC
			// (set) Token: 0x06002502 RID: 9474 RVA: 0x0005F8C2 File Offset: 0x0005DAC2
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

			// Token: 0x17000E16 RID: 3606
			// (get) Token: 0x06002503 RID: 9475 RVA: 0x0005F8D9 File Offset: 0x0005DAD9
			// (set) Token: 0x06002504 RID: 9476 RVA: 0x0005F8EF File Offset: 0x0005DAEF
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

			// Token: 0x17000E17 RID: 3607
			// (get) Token: 0x06002505 RID: 9477 RVA: 0x0005F906 File Offset: 0x0005DB06
			// (set) Token: 0x06002506 RID: 9478 RVA: 0x0005F91C File Offset: 0x0005DB1C
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

			// Token: 0x17000E18 RID: 3608
			// (get) Token: 0x06002507 RID: 9479 RVA: 0x0005F934 File Offset: 0x0005DB34
			// (set) Token: 0x06002508 RID: 9480 RVA: 0x0005F964 File Offset: 0x0005DB64
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

			// Token: 0x17000E19 RID: 3609
			// (get) Token: 0x06002509 RID: 9481 RVA: 0x0005F9AC File Offset: 0x0005DBAC
			// (set) Token: 0x0600250A RID: 9482 RVA: 0x0005F9C2 File Offset: 0x0005DBC2
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

			// Token: 0x17000E1A RID: 3610
			// (get) Token: 0x0600250B RID: 9483 RVA: 0x0005F9DC File Offset: 0x0005DBDC
			// (set) Token: 0x0600250C RID: 9484 RVA: 0x0005FA0C File Offset: 0x0005DC0C
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

			// Token: 0x17000E1B RID: 3611
			// (get) Token: 0x0600250D RID: 9485 RVA: 0x0005FA54 File Offset: 0x0005DC54
			// (set) Token: 0x0600250E RID: 9486 RVA: 0x0005FA6A File Offset: 0x0005DC6A
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

			// Token: 0x17000E1C RID: 3612
			// (get) Token: 0x0600250F RID: 9487 RVA: 0x0005FA81 File Offset: 0x0005DC81
			// (set) Token: 0x06002510 RID: 9488 RVA: 0x0005FA97 File Offset: 0x0005DC97
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

			// Token: 0x17000E1D RID: 3613
			// (get) Token: 0x06002511 RID: 9489 RVA: 0x0005FAAE File Offset: 0x0005DCAE
			// (set) Token: 0x06002512 RID: 9490 RVA: 0x0005FAC4 File Offset: 0x0005DCC4
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

			// Token: 0x17000E1E RID: 3614
			// (get) Token: 0x06002513 RID: 9491 RVA: 0x0005FADB File Offset: 0x0005DCDB
			// (set) Token: 0x06002514 RID: 9492 RVA: 0x0005FAF1 File Offset: 0x0005DCF1
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

			// Token: 0x17000E1F RID: 3615
			// (get) Token: 0x06002515 RID: 9493 RVA: 0x0005FB08 File Offset: 0x0005DD08
			// (set) Token: 0x06002516 RID: 9494 RVA: 0x0005FB1E File Offset: 0x0005DD1E
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

			// Token: 0x17000E20 RID: 3616
			// (get) Token: 0x06002517 RID: 9495 RVA: 0x0005FB35 File Offset: 0x0005DD35
			// (set) Token: 0x06002518 RID: 9496 RVA: 0x0005FB4B File Offset: 0x0005DD4B
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

			// Token: 0x17000E21 RID: 3617
			// (get) Token: 0x06002519 RID: 9497 RVA: 0x0005FB62 File Offset: 0x0005DD62
			// (set) Token: 0x0600251A RID: 9498 RVA: 0x0005FB78 File Offset: 0x0005DD78
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

			// Token: 0x17000E22 RID: 3618
			// (get) Token: 0x0600251B RID: 9499 RVA: 0x0005FB8F File Offset: 0x0005DD8F
			// (set) Token: 0x0600251C RID: 9500 RVA: 0x0005FBA5 File Offset: 0x0005DDA5
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

			// Token: 0x17000E23 RID: 3619
			// (get) Token: 0x0600251D RID: 9501 RVA: 0x0005FBBC File Offset: 0x0005DDBC
			// (set) Token: 0x0600251E RID: 9502 RVA: 0x0005FBEC File Offset: 0x0005DDEC
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

			// Token: 0x17000E24 RID: 3620
			// (get) Token: 0x0600251F RID: 9503 RVA: 0x0005FC34 File Offset: 0x0005DE34
			// (set) Token: 0x06002520 RID: 9504 RVA: 0x0005FC64 File Offset: 0x0005DE64
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

			// Token: 0x17000E25 RID: 3621
			// (get) Token: 0x06002521 RID: 9505 RVA: 0x0005FCAC File Offset: 0x0005DEAC
			// (set) Token: 0x06002522 RID: 9506 RVA: 0x0005FCC2 File Offset: 0x0005DEC2
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

			// Token: 0x17000E26 RID: 3622
			// (get) Token: 0x06002523 RID: 9507 RVA: 0x0005FCD9 File Offset: 0x0005DED9
			// (set) Token: 0x06002524 RID: 9508 RVA: 0x0005FCEF File Offset: 0x0005DEEF
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

			// Token: 0x17000E27 RID: 3623
			// (get) Token: 0x06002525 RID: 9509 RVA: 0x0005FD06 File Offset: 0x0005DF06
			// (set) Token: 0x06002526 RID: 9510 RVA: 0x0005FD1C File Offset: 0x0005DF1C
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

			// Token: 0x17000E28 RID: 3624
			// (get) Token: 0x06002527 RID: 9511 RVA: 0x0005FD33 File Offset: 0x0005DF33
			// (set) Token: 0x06002528 RID: 9512 RVA: 0x0005FD49 File Offset: 0x0005DF49
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

			// Token: 0x17000E29 RID: 3625
			// (get) Token: 0x06002529 RID: 9513 RVA: 0x0005FD60 File Offset: 0x0005DF60
			// (set) Token: 0x0600252A RID: 9514 RVA: 0x0005FD76 File Offset: 0x0005DF76
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

			// Token: 0x17000E2A RID: 3626
			// (get) Token: 0x0600252B RID: 9515 RVA: 0x0005FD8D File Offset: 0x0005DF8D
			// (set) Token: 0x0600252C RID: 9516 RVA: 0x0005FDA3 File Offset: 0x0005DFA3
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

			// Token: 0x17000E2B RID: 3627
			// (get) Token: 0x0600252D RID: 9517 RVA: 0x0005FDBA File Offset: 0x0005DFBA
			// (set) Token: 0x0600252E RID: 9518 RVA: 0x0005FDD0 File Offset: 0x0005DFD0
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

			// Token: 0x17000E2C RID: 3628
			// (get) Token: 0x0600252F RID: 9519 RVA: 0x0005FDE7 File Offset: 0x0005DFE7
			// (set) Token: 0x06002530 RID: 9520 RVA: 0x0005FDFD File Offset: 0x0005DFFD
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

			// Token: 0x17000E2D RID: 3629
			// (get) Token: 0x06002531 RID: 9521 RVA: 0x0005FE14 File Offset: 0x0005E014
			// (set) Token: 0x06002532 RID: 9522 RVA: 0x0005FE2A File Offset: 0x0005E02A
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

			// Token: 0x17000E2E RID: 3630
			// (get) Token: 0x06002533 RID: 9523 RVA: 0x0005FE41 File Offset: 0x0005E041
			// (set) Token: 0x06002534 RID: 9524 RVA: 0x0005FE57 File Offset: 0x0005E057
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

			// Token: 0x17000E2F RID: 3631
			// (get) Token: 0x06002535 RID: 9525 RVA: 0x0005FE6E File Offset: 0x0005E06E
			// (set) Token: 0x06002536 RID: 9526 RVA: 0x0005FE84 File Offset: 0x0005E084
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

			// Token: 0x17000E30 RID: 3632
			// (get) Token: 0x06002537 RID: 9527 RVA: 0x0005FE9B File Offset: 0x0005E09B
			// (set) Token: 0x06002538 RID: 9528 RVA: 0x0005FEB1 File Offset: 0x0005E0B1
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

			// Token: 0x17000E31 RID: 3633
			// (get) Token: 0x06002539 RID: 9529 RVA: 0x0005FEC8 File Offset: 0x0005E0C8
			// (set) Token: 0x0600253A RID: 9530 RVA: 0x0005FEDE File Offset: 0x0005E0DE
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

			// Token: 0x17000E32 RID: 3634
			// (get) Token: 0x0600253B RID: 9531 RVA: 0x0005FEF5 File Offset: 0x0005E0F5
			// (set) Token: 0x0600253C RID: 9532 RVA: 0x0005FF0B File Offset: 0x0005E10B
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

			// Token: 0x17000E33 RID: 3635
			// (get) Token: 0x0600253D RID: 9533 RVA: 0x0005FF22 File Offset: 0x0005E122
			// (set) Token: 0x0600253E RID: 9534 RVA: 0x0005FF38 File Offset: 0x0005E138
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

			// Token: 0x17000E34 RID: 3636
			// (get) Token: 0x0600253F RID: 9535 RVA: 0x0005FF4F File Offset: 0x0005E14F
			// (set) Token: 0x06002540 RID: 9536 RVA: 0x0005FF65 File Offset: 0x0005E165
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

			// Token: 0x17000E35 RID: 3637
			// (get) Token: 0x06002541 RID: 9537 RVA: 0x0005FF7C File Offset: 0x0005E17C
			// (set) Token: 0x06002542 RID: 9538 RVA: 0x0005FFAC File Offset: 0x0005E1AC
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

			// Token: 0x17000E36 RID: 3638
			// (get) Token: 0x06002543 RID: 9539 RVA: 0x0005FFF4 File Offset: 0x0005E1F4
			// (set) Token: 0x06002544 RID: 9540 RVA: 0x00060024 File Offset: 0x0005E224
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

			// Token: 0x17000E37 RID: 3639
			// (get) Token: 0x06002545 RID: 9541 RVA: 0x0006006C File Offset: 0x0005E26C
			// (set) Token: 0x06002546 RID: 9542 RVA: 0x00060082 File Offset: 0x0005E282
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

			// Token: 0x17000E38 RID: 3640
			// (get) Token: 0x06002547 RID: 9543 RVA: 0x00060099 File Offset: 0x0005E299
			// (set) Token: 0x06002548 RID: 9544 RVA: 0x000600AF File Offset: 0x0005E2AF
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

			// Token: 0x17000E39 RID: 3641
			// (get) Token: 0x06002549 RID: 9545 RVA: 0x000600C6 File Offset: 0x0005E2C6
			// (set) Token: 0x0600254A RID: 9546 RVA: 0x000600DC File Offset: 0x0005E2DC
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

			// Token: 0x17000E3A RID: 3642
			// (get) Token: 0x0600254B RID: 9547 RVA: 0x000600F3 File Offset: 0x0005E2F3
			// (set) Token: 0x0600254C RID: 9548 RVA: 0x00060109 File Offset: 0x0005E309
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

			// Token: 0x17000E3B RID: 3643
			// (get) Token: 0x0600254D RID: 9549 RVA: 0x00060120 File Offset: 0x0005E320
			// (set) Token: 0x0600254E RID: 9550 RVA: 0x00060136 File Offset: 0x0005E336
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

			// Token: 0x17000E3C RID: 3644
			// (get) Token: 0x0600254F RID: 9551 RVA: 0x0006014D File Offset: 0x0005E34D
			// (set) Token: 0x06002550 RID: 9552 RVA: 0x00060163 File Offset: 0x0005E363
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

			// Token: 0x17000E3D RID: 3645
			// (get) Token: 0x06002551 RID: 9553 RVA: 0x0006017A File Offset: 0x0005E37A
			// (set) Token: 0x06002552 RID: 9554 RVA: 0x00060190 File Offset: 0x0005E390
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

			// Token: 0x17000E3E RID: 3646
			// (get) Token: 0x06002553 RID: 9555 RVA: 0x000601A7 File Offset: 0x0005E3A7
			// (set) Token: 0x06002554 RID: 9556 RVA: 0x000601BD File Offset: 0x0005E3BD
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

			// Token: 0x17000E3F RID: 3647
			// (get) Token: 0x06002555 RID: 9557 RVA: 0x000601D4 File Offset: 0x0005E3D4
			// (set) Token: 0x06002556 RID: 9558 RVA: 0x000601EA File Offset: 0x0005E3EA
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

			// Token: 0x17000E40 RID: 3648
			// (get) Token: 0x06002557 RID: 9559 RVA: 0x00060201 File Offset: 0x0005E401
			// (set) Token: 0x06002558 RID: 9560 RVA: 0x00060217 File Offset: 0x0005E417
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

			// Token: 0x17000E41 RID: 3649
			// (get) Token: 0x06002559 RID: 9561 RVA: 0x0006022E File Offset: 0x0005E42E
			// (set) Token: 0x0600255A RID: 9562 RVA: 0x00060244 File Offset: 0x0005E444
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

			// Token: 0x17000E42 RID: 3650
			// (get) Token: 0x0600255B RID: 9563 RVA: 0x0006025B File Offset: 0x0005E45B
			// (set) Token: 0x0600255C RID: 9564 RVA: 0x00060271 File Offset: 0x0005E471
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

			// Token: 0x17000E43 RID: 3651
			// (get) Token: 0x0600255D RID: 9565 RVA: 0x00060288 File Offset: 0x0005E488
			// (set) Token: 0x0600255E RID: 9566 RVA: 0x0006029E File Offset: 0x0005E49E
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

			// Token: 0x17000E44 RID: 3652
			// (get) Token: 0x0600255F RID: 9567 RVA: 0x000602B5 File Offset: 0x0005E4B5
			// (set) Token: 0x06002560 RID: 9568 RVA: 0x000602CB File Offset: 0x0005E4CB
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

			// Token: 0x17000E45 RID: 3653
			// (get) Token: 0x06002561 RID: 9569 RVA: 0x000602E4 File Offset: 0x0005E4E4
			internal static IntPtr class_ref
			{
				get
				{
					return R.Styleable._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x17000E46 RID: 3654
			// (get) Token: 0x06002562 RID: 9570 RVA: 0x00060308 File Offset: 0x0005E508
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return R.Styleable._members;
				}
			}

			// Token: 0x17000E47 RID: 3655
			// (get) Token: 0x06002563 RID: 9571 RVA: 0x00060310 File Offset: 0x0005E510
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return R.Styleable._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x17000E48 RID: 3656
			// (get) Token: 0x06002564 RID: 9572 RVA: 0x00060334 File Offset: 0x0005E534
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return R.Styleable._members.ManagedPeerType;
				}
			}

			// Token: 0x06002565 RID: 9573 RVA: 0x000021E8 File Offset: 0x000003E8
			internal Styleable(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
			{
			}

			// Token: 0x0400073C RID: 1852
			private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/scar/adapter/v1920/R$styleable", typeof(R.Styleable));
		}
	}
}
