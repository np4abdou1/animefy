using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Com.Unity3d.Scar.Adapter.V2100
{
	// Token: 0x02000238 RID: 568
	[Register("com/unity3d/scar/adapter/v2100/R", DoNotGenerateAcw = true)]
	public sealed class R : Java.Lang.Object
	{
		// Token: 0x17000946 RID: 2374
		// (get) Token: 0x06001B7A RID: 7034 RVA: 0x00050488 File Offset: 0x0004E688
		internal static IntPtr class_ref
		{
			get
			{
				return R._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000947 RID: 2375
		// (get) Token: 0x06001B7B RID: 7035 RVA: 0x000504AC File Offset: 0x0004E6AC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return R._members;
			}
		}

		// Token: 0x17000948 RID: 2376
		// (get) Token: 0x06001B7C RID: 7036 RVA: 0x000504B4 File Offset: 0x0004E6B4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return R._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000949 RID: 2377
		// (get) Token: 0x06001B7D RID: 7037 RVA: 0x000504D8 File Offset: 0x0004E6D8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return R._members.ManagedPeerType;
			}
		}

		// Token: 0x06001B7E RID: 7038 RVA: 0x000021E8 File Offset: 0x000003E8
		internal R(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x040006C4 RID: 1732
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/scar/adapter/v2100/R", typeof(R));

		// Token: 0x02000239 RID: 569
		[Register("com/unity3d/scar/adapter/v2100/R$attr", DoNotGenerateAcw = true)]
		public sealed class Attr : Java.Lang.Object
		{
			// Token: 0x1700094A RID: 2378
			// (get) Token: 0x06001B80 RID: 7040 RVA: 0x000504FF File Offset: 0x0004E6FF
			// (set) Token: 0x06001B81 RID: 7041 RVA: 0x00050515 File Offset: 0x0004E715
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

			// Token: 0x1700094B RID: 2379
			// (get) Token: 0x06001B82 RID: 7042 RVA: 0x0005052C File Offset: 0x0004E72C
			// (set) Token: 0x06001B83 RID: 7043 RVA: 0x00050542 File Offset: 0x0004E742
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

			// Token: 0x1700094C RID: 2380
			// (get) Token: 0x06001B84 RID: 7044 RVA: 0x00050559 File Offset: 0x0004E759
			// (set) Token: 0x06001B85 RID: 7045 RVA: 0x0005056F File Offset: 0x0004E76F
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

			// Token: 0x1700094D RID: 2381
			// (get) Token: 0x06001B86 RID: 7046 RVA: 0x00050586 File Offset: 0x0004E786
			// (set) Token: 0x06001B87 RID: 7047 RVA: 0x0005059C File Offset: 0x0004E79C
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

			// Token: 0x1700094E RID: 2382
			// (get) Token: 0x06001B88 RID: 7048 RVA: 0x000505B3 File Offset: 0x0004E7B3
			// (set) Token: 0x06001B89 RID: 7049 RVA: 0x000505C9 File Offset: 0x0004E7C9
			[Register("buttonSize")]
			public static int ButtonSize
			{
				get
				{
					return R.Attr._members.StaticFields.GetInt32Value("buttonSize.I");
				}
				set
				{
					R.Attr._members.StaticFields.SetValue("buttonSize.I", value);
				}
			}

			// Token: 0x1700094F RID: 2383
			// (get) Token: 0x06001B8A RID: 7050 RVA: 0x000505E0 File Offset: 0x0004E7E0
			// (set) Token: 0x06001B8B RID: 7051 RVA: 0x000505F6 File Offset: 0x0004E7F6
			[Register("circleCrop")]
			public static int CircleCrop
			{
				get
				{
					return R.Attr._members.StaticFields.GetInt32Value("circleCrop.I");
				}
				set
				{
					R.Attr._members.StaticFields.SetValue("circleCrop.I", value);
				}
			}

			// Token: 0x17000950 RID: 2384
			// (get) Token: 0x06001B8C RID: 7052 RVA: 0x0005060D File Offset: 0x0004E80D
			// (set) Token: 0x06001B8D RID: 7053 RVA: 0x00050623 File Offset: 0x0004E823
			[Register("colorScheme")]
			public static int ColorScheme
			{
				get
				{
					return R.Attr._members.StaticFields.GetInt32Value("colorScheme.I");
				}
				set
				{
					R.Attr._members.StaticFields.SetValue("colorScheme.I", value);
				}
			}

			// Token: 0x17000951 RID: 2385
			// (get) Token: 0x06001B8E RID: 7054 RVA: 0x0005063A File Offset: 0x0004E83A
			// (set) Token: 0x06001B8F RID: 7055 RVA: 0x00050650 File Offset: 0x0004E850
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

			// Token: 0x17000952 RID: 2386
			// (get) Token: 0x06001B90 RID: 7056 RVA: 0x00050667 File Offset: 0x0004E867
			// (set) Token: 0x06001B91 RID: 7057 RVA: 0x0005067D File Offset: 0x0004E87D
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

			// Token: 0x17000953 RID: 2387
			// (get) Token: 0x06001B92 RID: 7058 RVA: 0x00050694 File Offset: 0x0004E894
			// (set) Token: 0x06001B93 RID: 7059 RVA: 0x000506AA File Offset: 0x0004E8AA
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

			// Token: 0x17000954 RID: 2388
			// (get) Token: 0x06001B94 RID: 7060 RVA: 0x000506C1 File Offset: 0x0004E8C1
			// (set) Token: 0x06001B95 RID: 7061 RVA: 0x000506D7 File Offset: 0x0004E8D7
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

			// Token: 0x17000955 RID: 2389
			// (get) Token: 0x06001B96 RID: 7062 RVA: 0x000506EE File Offset: 0x0004E8EE
			// (set) Token: 0x06001B97 RID: 7063 RVA: 0x00050704 File Offset: 0x0004E904
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

			// Token: 0x17000956 RID: 2390
			// (get) Token: 0x06001B98 RID: 7064 RVA: 0x0005071B File Offset: 0x0004E91B
			// (set) Token: 0x06001B99 RID: 7065 RVA: 0x00050731 File Offset: 0x0004E931
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

			// Token: 0x17000957 RID: 2391
			// (get) Token: 0x06001B9A RID: 7066 RVA: 0x00050748 File Offset: 0x0004E948
			// (set) Token: 0x06001B9B RID: 7067 RVA: 0x0005075E File Offset: 0x0004E95E
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

			// Token: 0x17000958 RID: 2392
			// (get) Token: 0x06001B9C RID: 7068 RVA: 0x00050775 File Offset: 0x0004E975
			// (set) Token: 0x06001B9D RID: 7069 RVA: 0x0005078B File Offset: 0x0004E98B
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

			// Token: 0x17000959 RID: 2393
			// (get) Token: 0x06001B9E RID: 7070 RVA: 0x000507A2 File Offset: 0x0004E9A2
			// (set) Token: 0x06001B9F RID: 7071 RVA: 0x000507B8 File Offset: 0x0004E9B8
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

			// Token: 0x1700095A RID: 2394
			// (get) Token: 0x06001BA0 RID: 7072 RVA: 0x000507CF File Offset: 0x0004E9CF
			// (set) Token: 0x06001BA1 RID: 7073 RVA: 0x000507E5 File Offset: 0x0004E9E5
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

			// Token: 0x1700095B RID: 2395
			// (get) Token: 0x06001BA2 RID: 7074 RVA: 0x000507FC File Offset: 0x0004E9FC
			// (set) Token: 0x06001BA3 RID: 7075 RVA: 0x00050812 File Offset: 0x0004EA12
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

			// Token: 0x1700095C RID: 2396
			// (get) Token: 0x06001BA4 RID: 7076 RVA: 0x00050829 File Offset: 0x0004EA29
			// (set) Token: 0x06001BA5 RID: 7077 RVA: 0x0005083F File Offset: 0x0004EA3F
			[Register("imageAspectRatio")]
			public static int ImageAspectRatio
			{
				get
				{
					return R.Attr._members.StaticFields.GetInt32Value("imageAspectRatio.I");
				}
				set
				{
					R.Attr._members.StaticFields.SetValue("imageAspectRatio.I", value);
				}
			}

			// Token: 0x1700095D RID: 2397
			// (get) Token: 0x06001BA6 RID: 7078 RVA: 0x00050856 File Offset: 0x0004EA56
			// (set) Token: 0x06001BA7 RID: 7079 RVA: 0x0005086C File Offset: 0x0004EA6C
			[Register("imageAspectRatioAdjust")]
			public static int ImageAspectRatioAdjust
			{
				get
				{
					return R.Attr._members.StaticFields.GetInt32Value("imageAspectRatioAdjust.I");
				}
				set
				{
					R.Attr._members.StaticFields.SetValue("imageAspectRatioAdjust.I", value);
				}
			}

			// Token: 0x1700095E RID: 2398
			// (get) Token: 0x06001BA8 RID: 7080 RVA: 0x00050883 File Offset: 0x0004EA83
			// (set) Token: 0x06001BA9 RID: 7081 RVA: 0x00050899 File Offset: 0x0004EA99
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

			// Token: 0x1700095F RID: 2399
			// (get) Token: 0x06001BAA RID: 7082 RVA: 0x000508B0 File Offset: 0x0004EAB0
			// (set) Token: 0x06001BAB RID: 7083 RVA: 0x000508C6 File Offset: 0x0004EAC6
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

			// Token: 0x17000960 RID: 2400
			// (get) Token: 0x06001BAC RID: 7084 RVA: 0x000508DD File Offset: 0x0004EADD
			// (set) Token: 0x06001BAD RID: 7085 RVA: 0x000508F3 File Offset: 0x0004EAF3
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

			// Token: 0x17000961 RID: 2401
			// (get) Token: 0x06001BAE RID: 7086 RVA: 0x0005090A File Offset: 0x0004EB0A
			// (set) Token: 0x06001BAF RID: 7087 RVA: 0x00050920 File Offset: 0x0004EB20
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

			// Token: 0x17000962 RID: 2402
			// (get) Token: 0x06001BB0 RID: 7088 RVA: 0x00050937 File Offset: 0x0004EB37
			// (set) Token: 0x06001BB1 RID: 7089 RVA: 0x0005094D File Offset: 0x0004EB4D
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

			// Token: 0x17000963 RID: 2403
			// (get) Token: 0x06001BB2 RID: 7090 RVA: 0x00050964 File Offset: 0x0004EB64
			// (set) Token: 0x06001BB3 RID: 7091 RVA: 0x0005097A File Offset: 0x0004EB7A
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

			// Token: 0x17000964 RID: 2404
			// (get) Token: 0x06001BB4 RID: 7092 RVA: 0x00050991 File Offset: 0x0004EB91
			// (set) Token: 0x06001BB5 RID: 7093 RVA: 0x000509A7 File Offset: 0x0004EBA7
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

			// Token: 0x17000965 RID: 2405
			// (get) Token: 0x06001BB6 RID: 7094 RVA: 0x000509BE File Offset: 0x0004EBBE
			// (set) Token: 0x06001BB7 RID: 7095 RVA: 0x000509D4 File Offset: 0x0004EBD4
			[Register("scopeUris")]
			public static int ScopeUris
			{
				get
				{
					return R.Attr._members.StaticFields.GetInt32Value("scopeUris.I");
				}
				set
				{
					R.Attr._members.StaticFields.SetValue("scopeUris.I", value);
				}
			}

			// Token: 0x17000966 RID: 2406
			// (get) Token: 0x06001BB8 RID: 7096 RVA: 0x000509EB File Offset: 0x0004EBEB
			// (set) Token: 0x06001BB9 RID: 7097 RVA: 0x00050A01 File Offset: 0x0004EC01
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

			// Token: 0x17000967 RID: 2407
			// (get) Token: 0x06001BBA RID: 7098 RVA: 0x00050A18 File Offset: 0x0004EC18
			// (set) Token: 0x06001BBB RID: 7099 RVA: 0x00050A2E File Offset: 0x0004EC2E
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

			// Token: 0x17000968 RID: 2408
			// (get) Token: 0x06001BBC RID: 7100 RVA: 0x00050A48 File Offset: 0x0004EC48
			internal static IntPtr class_ref
			{
				get
				{
					return R.Attr._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x17000969 RID: 2409
			// (get) Token: 0x06001BBD RID: 7101 RVA: 0x00050A6C File Offset: 0x0004EC6C
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return R.Attr._members;
				}
			}

			// Token: 0x1700096A RID: 2410
			// (get) Token: 0x06001BBE RID: 7102 RVA: 0x00050A74 File Offset: 0x0004EC74
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return R.Attr._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x1700096B RID: 2411
			// (get) Token: 0x06001BBF RID: 7103 RVA: 0x00050A98 File Offset: 0x0004EC98
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return R.Attr._members.ManagedPeerType;
				}
			}

			// Token: 0x06001BC0 RID: 7104 RVA: 0x000021E8 File Offset: 0x000003E8
			internal Attr(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
			{
			}

			// Token: 0x040006C5 RID: 1733
			private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/scar/adapter/v2100/R$attr", typeof(R.Attr));
		}

		// Token: 0x0200023A RID: 570
		[Register("com/unity3d/scar/adapter/v2100/R$bool", DoNotGenerateAcw = true)]
		public sealed class Bool : Java.Lang.Object
		{
			// Token: 0x1700096C RID: 2412
			// (get) Token: 0x06001BC2 RID: 7106 RVA: 0x00050ABF File Offset: 0x0004ECBF
			// (set) Token: 0x06001BC3 RID: 7107 RVA: 0x00050AD5 File Offset: 0x0004ECD5
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

			// Token: 0x1700096D RID: 2413
			// (get) Token: 0x06001BC4 RID: 7108 RVA: 0x00050AEC File Offset: 0x0004ECEC
			// (set) Token: 0x06001BC5 RID: 7109 RVA: 0x00050B02 File Offset: 0x0004ED02
			[Register("enable_system_foreground_service_default")]
			public static int EnableSystemForegroundServiceDefault
			{
				get
				{
					return R.Bool._members.StaticFields.GetInt32Value("enable_system_foreground_service_default.I");
				}
				set
				{
					R.Bool._members.StaticFields.SetValue("enable_system_foreground_service_default.I", value);
				}
			}

			// Token: 0x1700096E RID: 2414
			// (get) Token: 0x06001BC6 RID: 7110 RVA: 0x00050B19 File Offset: 0x0004ED19
			// (set) Token: 0x06001BC7 RID: 7111 RVA: 0x00050B2F File Offset: 0x0004ED2F
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

			// Token: 0x1700096F RID: 2415
			// (get) Token: 0x06001BC8 RID: 7112 RVA: 0x00050B46 File Offset: 0x0004ED46
			// (set) Token: 0x06001BC9 RID: 7113 RVA: 0x00050B5C File Offset: 0x0004ED5C
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

			// Token: 0x17000970 RID: 2416
			// (get) Token: 0x06001BCA RID: 7114 RVA: 0x00050B74 File Offset: 0x0004ED74
			internal static IntPtr class_ref
			{
				get
				{
					return R.Bool._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x17000971 RID: 2417
			// (get) Token: 0x06001BCB RID: 7115 RVA: 0x00050B98 File Offset: 0x0004ED98
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return R.Bool._members;
				}
			}

			// Token: 0x17000972 RID: 2418
			// (get) Token: 0x06001BCC RID: 7116 RVA: 0x00050BA0 File Offset: 0x0004EDA0
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return R.Bool._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x17000973 RID: 2419
			// (get) Token: 0x06001BCD RID: 7117 RVA: 0x00050BC4 File Offset: 0x0004EDC4
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return R.Bool._members.ManagedPeerType;
				}
			}

			// Token: 0x06001BCE RID: 7118 RVA: 0x000021E8 File Offset: 0x000003E8
			internal Bool(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
			{
			}

			// Token: 0x040006C6 RID: 1734
			private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/scar/adapter/v2100/R$bool", typeof(R.Bool));
		}

		// Token: 0x0200023B RID: 571
		[Register("com/unity3d/scar/adapter/v2100/R$color", DoNotGenerateAcw = true)]
		public sealed class Color : Java.Lang.Object
		{
			// Token: 0x17000974 RID: 2420
			// (get) Token: 0x06001BD0 RID: 7120 RVA: 0x00050BEB File Offset: 0x0004EDEB
			// (set) Token: 0x06001BD1 RID: 7121 RVA: 0x00050C01 File Offset: 0x0004EE01
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

			// Token: 0x17000975 RID: 2421
			// (get) Token: 0x06001BD2 RID: 7122 RVA: 0x00050C18 File Offset: 0x0004EE18
			// (set) Token: 0x06001BD3 RID: 7123 RVA: 0x00050C2E File Offset: 0x0004EE2E
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

			// Token: 0x17000976 RID: 2422
			// (get) Token: 0x06001BD4 RID: 7124 RVA: 0x00050C45 File Offset: 0x0004EE45
			// (set) Token: 0x06001BD5 RID: 7125 RVA: 0x00050C5B File Offset: 0x0004EE5B
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

			// Token: 0x17000977 RID: 2423
			// (get) Token: 0x06001BD6 RID: 7126 RVA: 0x00050C72 File Offset: 0x0004EE72
			// (set) Token: 0x06001BD7 RID: 7127 RVA: 0x00050C88 File Offset: 0x0004EE88
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

			// Token: 0x17000978 RID: 2424
			// (get) Token: 0x06001BD8 RID: 7128 RVA: 0x00050C9F File Offset: 0x0004EE9F
			// (set) Token: 0x06001BD9 RID: 7129 RVA: 0x00050CB5 File Offset: 0x0004EEB5
			[Register("common_google_signin_btn_text_dark")]
			public static int CommonGoogleSigninBtnTextDark
			{
				get
				{
					return R.Color._members.StaticFields.GetInt32Value("common_google_signin_btn_text_dark.I");
				}
				set
				{
					R.Color._members.StaticFields.SetValue("common_google_signin_btn_text_dark.I", value);
				}
			}

			// Token: 0x17000979 RID: 2425
			// (get) Token: 0x06001BDA RID: 7130 RVA: 0x00050CCC File Offset: 0x0004EECC
			// (set) Token: 0x06001BDB RID: 7131 RVA: 0x00050CE2 File Offset: 0x0004EEE2
			[Register("common_google_signin_btn_text_dark_default")]
			public static int CommonGoogleSigninBtnTextDarkDefault
			{
				get
				{
					return R.Color._members.StaticFields.GetInt32Value("common_google_signin_btn_text_dark_default.I");
				}
				set
				{
					R.Color._members.StaticFields.SetValue("common_google_signin_btn_text_dark_default.I", value);
				}
			}

			// Token: 0x1700097A RID: 2426
			// (get) Token: 0x06001BDC RID: 7132 RVA: 0x00050CF9 File Offset: 0x0004EEF9
			// (set) Token: 0x06001BDD RID: 7133 RVA: 0x00050D0F File Offset: 0x0004EF0F
			[Register("common_google_signin_btn_text_dark_disabled")]
			public static int CommonGoogleSigninBtnTextDarkDisabled
			{
				get
				{
					return R.Color._members.StaticFields.GetInt32Value("common_google_signin_btn_text_dark_disabled.I");
				}
				set
				{
					R.Color._members.StaticFields.SetValue("common_google_signin_btn_text_dark_disabled.I", value);
				}
			}

			// Token: 0x1700097B RID: 2427
			// (get) Token: 0x06001BDE RID: 7134 RVA: 0x00050D26 File Offset: 0x0004EF26
			// (set) Token: 0x06001BDF RID: 7135 RVA: 0x00050D3C File Offset: 0x0004EF3C
			[Register("common_google_signin_btn_text_dark_focused")]
			public static int CommonGoogleSigninBtnTextDarkFocused
			{
				get
				{
					return R.Color._members.StaticFields.GetInt32Value("common_google_signin_btn_text_dark_focused.I");
				}
				set
				{
					R.Color._members.StaticFields.SetValue("common_google_signin_btn_text_dark_focused.I", value);
				}
			}

			// Token: 0x1700097C RID: 2428
			// (get) Token: 0x06001BE0 RID: 7136 RVA: 0x00050D53 File Offset: 0x0004EF53
			// (set) Token: 0x06001BE1 RID: 7137 RVA: 0x00050D69 File Offset: 0x0004EF69
			[Register("common_google_signin_btn_text_dark_pressed")]
			public static int CommonGoogleSigninBtnTextDarkPressed
			{
				get
				{
					return R.Color._members.StaticFields.GetInt32Value("common_google_signin_btn_text_dark_pressed.I");
				}
				set
				{
					R.Color._members.StaticFields.SetValue("common_google_signin_btn_text_dark_pressed.I", value);
				}
			}

			// Token: 0x1700097D RID: 2429
			// (get) Token: 0x06001BE2 RID: 7138 RVA: 0x00050D80 File Offset: 0x0004EF80
			// (set) Token: 0x06001BE3 RID: 7139 RVA: 0x00050D96 File Offset: 0x0004EF96
			[Register("common_google_signin_btn_text_light")]
			public static int CommonGoogleSigninBtnTextLight
			{
				get
				{
					return R.Color._members.StaticFields.GetInt32Value("common_google_signin_btn_text_light.I");
				}
				set
				{
					R.Color._members.StaticFields.SetValue("common_google_signin_btn_text_light.I", value);
				}
			}

			// Token: 0x1700097E RID: 2430
			// (get) Token: 0x06001BE4 RID: 7140 RVA: 0x00050DAD File Offset: 0x0004EFAD
			// (set) Token: 0x06001BE5 RID: 7141 RVA: 0x00050DC3 File Offset: 0x0004EFC3
			[Register("common_google_signin_btn_text_light_default")]
			public static int CommonGoogleSigninBtnTextLightDefault
			{
				get
				{
					return R.Color._members.StaticFields.GetInt32Value("common_google_signin_btn_text_light_default.I");
				}
				set
				{
					R.Color._members.StaticFields.SetValue("common_google_signin_btn_text_light_default.I", value);
				}
			}

			// Token: 0x1700097F RID: 2431
			// (get) Token: 0x06001BE6 RID: 7142 RVA: 0x00050DDA File Offset: 0x0004EFDA
			// (set) Token: 0x06001BE7 RID: 7143 RVA: 0x00050DF0 File Offset: 0x0004EFF0
			[Register("common_google_signin_btn_text_light_disabled")]
			public static int CommonGoogleSigninBtnTextLightDisabled
			{
				get
				{
					return R.Color._members.StaticFields.GetInt32Value("common_google_signin_btn_text_light_disabled.I");
				}
				set
				{
					R.Color._members.StaticFields.SetValue("common_google_signin_btn_text_light_disabled.I", value);
				}
			}

			// Token: 0x17000980 RID: 2432
			// (get) Token: 0x06001BE8 RID: 7144 RVA: 0x00050E07 File Offset: 0x0004F007
			// (set) Token: 0x06001BE9 RID: 7145 RVA: 0x00050E1D File Offset: 0x0004F01D
			[Register("common_google_signin_btn_text_light_focused")]
			public static int CommonGoogleSigninBtnTextLightFocused
			{
				get
				{
					return R.Color._members.StaticFields.GetInt32Value("common_google_signin_btn_text_light_focused.I");
				}
				set
				{
					R.Color._members.StaticFields.SetValue("common_google_signin_btn_text_light_focused.I", value);
				}
			}

			// Token: 0x17000981 RID: 2433
			// (get) Token: 0x06001BEA RID: 7146 RVA: 0x00050E34 File Offset: 0x0004F034
			// (set) Token: 0x06001BEB RID: 7147 RVA: 0x00050E4A File Offset: 0x0004F04A
			[Register("common_google_signin_btn_text_light_pressed")]
			public static int CommonGoogleSigninBtnTextLightPressed
			{
				get
				{
					return R.Color._members.StaticFields.GetInt32Value("common_google_signin_btn_text_light_pressed.I");
				}
				set
				{
					R.Color._members.StaticFields.SetValue("common_google_signin_btn_text_light_pressed.I", value);
				}
			}

			// Token: 0x17000982 RID: 2434
			// (get) Token: 0x06001BEC RID: 7148 RVA: 0x00050E61 File Offset: 0x0004F061
			// (set) Token: 0x06001BED RID: 7149 RVA: 0x00050E77 File Offset: 0x0004F077
			[Register("common_google_signin_btn_tint")]
			public static int CommonGoogleSigninBtnTint
			{
				get
				{
					return R.Color._members.StaticFields.GetInt32Value("common_google_signin_btn_tint.I");
				}
				set
				{
					R.Color._members.StaticFields.SetValue("common_google_signin_btn_tint.I", value);
				}
			}

			// Token: 0x17000983 RID: 2435
			// (get) Token: 0x06001BEE RID: 7150 RVA: 0x00050E8E File Offset: 0x0004F08E
			// (set) Token: 0x06001BEF RID: 7151 RVA: 0x00050EA4 File Offset: 0x0004F0A4
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

			// Token: 0x17000984 RID: 2436
			// (get) Token: 0x06001BF0 RID: 7152 RVA: 0x00050EBB File Offset: 0x0004F0BB
			// (set) Token: 0x06001BF1 RID: 7153 RVA: 0x00050ED1 File Offset: 0x0004F0D1
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

			// Token: 0x17000985 RID: 2437
			// (get) Token: 0x06001BF2 RID: 7154 RVA: 0x00050EE8 File Offset: 0x0004F0E8
			// (set) Token: 0x06001BF3 RID: 7155 RVA: 0x00050EFE File Offset: 0x0004F0FE
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

			// Token: 0x17000986 RID: 2438
			// (get) Token: 0x06001BF4 RID: 7156 RVA: 0x00050F15 File Offset: 0x0004F115
			// (set) Token: 0x06001BF5 RID: 7157 RVA: 0x00050F2B File Offset: 0x0004F12B
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

			// Token: 0x17000987 RID: 2439
			// (get) Token: 0x06001BF6 RID: 7158 RVA: 0x00050F44 File Offset: 0x0004F144
			internal static IntPtr class_ref
			{
				get
				{
					return R.Color._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x17000988 RID: 2440
			// (get) Token: 0x06001BF7 RID: 7159 RVA: 0x00050F68 File Offset: 0x0004F168
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return R.Color._members;
				}
			}

			// Token: 0x17000989 RID: 2441
			// (get) Token: 0x06001BF8 RID: 7160 RVA: 0x00050F70 File Offset: 0x0004F170
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return R.Color._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x1700098A RID: 2442
			// (get) Token: 0x06001BF9 RID: 7161 RVA: 0x00050F94 File Offset: 0x0004F194
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return R.Color._members.ManagedPeerType;
				}
			}

			// Token: 0x06001BFA RID: 7162 RVA: 0x000021E8 File Offset: 0x000003E8
			internal Color(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
			{
			}

			// Token: 0x040006C7 RID: 1735
			private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/scar/adapter/v2100/R$color", typeof(R.Color));
		}

		// Token: 0x0200023C RID: 572
		[Register("com/unity3d/scar/adapter/v2100/R$dimen", DoNotGenerateAcw = true)]
		public sealed class Dimen : Java.Lang.Object
		{
			// Token: 0x1700098B RID: 2443
			// (get) Token: 0x06001BFC RID: 7164 RVA: 0x00050FBB File Offset: 0x0004F1BB
			// (set) Token: 0x06001BFD RID: 7165 RVA: 0x00050FD1 File Offset: 0x0004F1D1
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

			// Token: 0x1700098C RID: 2444
			// (get) Token: 0x06001BFE RID: 7166 RVA: 0x00050FE8 File Offset: 0x0004F1E8
			// (set) Token: 0x06001BFF RID: 7167 RVA: 0x00050FFE File Offset: 0x0004F1FE
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

			// Token: 0x1700098D RID: 2445
			// (get) Token: 0x06001C00 RID: 7168 RVA: 0x00051015 File Offset: 0x0004F215
			// (set) Token: 0x06001C01 RID: 7169 RVA: 0x0005102B File Offset: 0x0004F22B
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

			// Token: 0x1700098E RID: 2446
			// (get) Token: 0x06001C02 RID: 7170 RVA: 0x00051042 File Offset: 0x0004F242
			// (set) Token: 0x06001C03 RID: 7171 RVA: 0x00051058 File Offset: 0x0004F258
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

			// Token: 0x1700098F RID: 2447
			// (get) Token: 0x06001C04 RID: 7172 RVA: 0x0005106F File Offset: 0x0004F26F
			// (set) Token: 0x06001C05 RID: 7173 RVA: 0x00051085 File Offset: 0x0004F285
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

			// Token: 0x17000990 RID: 2448
			// (get) Token: 0x06001C06 RID: 7174 RVA: 0x0005109C File Offset: 0x0004F29C
			// (set) Token: 0x06001C07 RID: 7175 RVA: 0x000510B2 File Offset: 0x0004F2B2
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

			// Token: 0x17000991 RID: 2449
			// (get) Token: 0x06001C08 RID: 7176 RVA: 0x000510C9 File Offset: 0x0004F2C9
			// (set) Token: 0x06001C09 RID: 7177 RVA: 0x000510DF File Offset: 0x0004F2DF
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

			// Token: 0x17000992 RID: 2450
			// (get) Token: 0x06001C0A RID: 7178 RVA: 0x000510F6 File Offset: 0x0004F2F6
			// (set) Token: 0x06001C0B RID: 7179 RVA: 0x0005110C File Offset: 0x0004F30C
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

			// Token: 0x17000993 RID: 2451
			// (get) Token: 0x06001C0C RID: 7180 RVA: 0x00051123 File Offset: 0x0004F323
			// (set) Token: 0x06001C0D RID: 7181 RVA: 0x00051139 File Offset: 0x0004F339
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

			// Token: 0x17000994 RID: 2452
			// (get) Token: 0x06001C0E RID: 7182 RVA: 0x00051150 File Offset: 0x0004F350
			// (set) Token: 0x06001C0F RID: 7183 RVA: 0x00051166 File Offset: 0x0004F366
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

			// Token: 0x17000995 RID: 2453
			// (get) Token: 0x06001C10 RID: 7184 RVA: 0x0005117D File Offset: 0x0004F37D
			// (set) Token: 0x06001C11 RID: 7185 RVA: 0x00051193 File Offset: 0x0004F393
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

			// Token: 0x17000996 RID: 2454
			// (get) Token: 0x06001C12 RID: 7186 RVA: 0x000511AA File Offset: 0x0004F3AA
			// (set) Token: 0x06001C13 RID: 7187 RVA: 0x000511C0 File Offset: 0x0004F3C0
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

			// Token: 0x17000997 RID: 2455
			// (get) Token: 0x06001C14 RID: 7188 RVA: 0x000511D7 File Offset: 0x0004F3D7
			// (set) Token: 0x06001C15 RID: 7189 RVA: 0x000511ED File Offset: 0x0004F3ED
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

			// Token: 0x17000998 RID: 2456
			// (get) Token: 0x06001C16 RID: 7190 RVA: 0x00051204 File Offset: 0x0004F404
			// (set) Token: 0x06001C17 RID: 7191 RVA: 0x0005121A File Offset: 0x0004F41A
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

			// Token: 0x17000999 RID: 2457
			// (get) Token: 0x06001C18 RID: 7192 RVA: 0x00051231 File Offset: 0x0004F431
			// (set) Token: 0x06001C19 RID: 7193 RVA: 0x00051247 File Offset: 0x0004F447
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

			// Token: 0x1700099A RID: 2458
			// (get) Token: 0x06001C1A RID: 7194 RVA: 0x0005125E File Offset: 0x0004F45E
			// (set) Token: 0x06001C1B RID: 7195 RVA: 0x00051274 File Offset: 0x0004F474
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

			// Token: 0x1700099B RID: 2459
			// (get) Token: 0x06001C1C RID: 7196 RVA: 0x0005128B File Offset: 0x0004F48B
			// (set) Token: 0x06001C1D RID: 7197 RVA: 0x000512A1 File Offset: 0x0004F4A1
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

			// Token: 0x1700099C RID: 2460
			// (get) Token: 0x06001C1E RID: 7198 RVA: 0x000512B8 File Offset: 0x0004F4B8
			// (set) Token: 0x06001C1F RID: 7199 RVA: 0x000512CE File Offset: 0x0004F4CE
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

			// Token: 0x1700099D RID: 2461
			// (get) Token: 0x06001C20 RID: 7200 RVA: 0x000512E5 File Offset: 0x0004F4E5
			// (set) Token: 0x06001C21 RID: 7201 RVA: 0x000512FB File Offset: 0x0004F4FB
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

			// Token: 0x1700099E RID: 2462
			// (get) Token: 0x06001C22 RID: 7202 RVA: 0x00051312 File Offset: 0x0004F512
			// (set) Token: 0x06001C23 RID: 7203 RVA: 0x00051328 File Offset: 0x0004F528
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

			// Token: 0x1700099F RID: 2463
			// (get) Token: 0x06001C24 RID: 7204 RVA: 0x0005133F File Offset: 0x0004F53F
			// (set) Token: 0x06001C25 RID: 7205 RVA: 0x00051355 File Offset: 0x0004F555
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

			// Token: 0x170009A0 RID: 2464
			// (get) Token: 0x06001C26 RID: 7206 RVA: 0x0005136C File Offset: 0x0004F56C
			// (set) Token: 0x06001C27 RID: 7207 RVA: 0x00051382 File Offset: 0x0004F582
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

			// Token: 0x170009A1 RID: 2465
			// (get) Token: 0x06001C28 RID: 7208 RVA: 0x00051399 File Offset: 0x0004F599
			// (set) Token: 0x06001C29 RID: 7209 RVA: 0x000513AF File Offset: 0x0004F5AF
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

			// Token: 0x170009A2 RID: 2466
			// (get) Token: 0x06001C2A RID: 7210 RVA: 0x000513C6 File Offset: 0x0004F5C6
			// (set) Token: 0x06001C2B RID: 7211 RVA: 0x000513DC File Offset: 0x0004F5DC
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

			// Token: 0x170009A3 RID: 2467
			// (get) Token: 0x06001C2C RID: 7212 RVA: 0x000513F4 File Offset: 0x0004F5F4
			internal static IntPtr class_ref
			{
				get
				{
					return R.Dimen._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x170009A4 RID: 2468
			// (get) Token: 0x06001C2D RID: 7213 RVA: 0x00051418 File Offset: 0x0004F618
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return R.Dimen._members;
				}
			}

			// Token: 0x170009A5 RID: 2469
			// (get) Token: 0x06001C2E RID: 7214 RVA: 0x00051420 File Offset: 0x0004F620
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return R.Dimen._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x170009A6 RID: 2470
			// (get) Token: 0x06001C2F RID: 7215 RVA: 0x00051444 File Offset: 0x0004F644
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return R.Dimen._members.ManagedPeerType;
				}
			}

			// Token: 0x06001C30 RID: 7216 RVA: 0x000021E8 File Offset: 0x000003E8
			internal Dimen(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
			{
			}

			// Token: 0x040006C8 RID: 1736
			private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/scar/adapter/v2100/R$dimen", typeof(R.Dimen));
		}

		// Token: 0x0200023D RID: 573
		[Register("com/unity3d/scar/adapter/v2100/R$drawable", DoNotGenerateAcw = true)]
		public sealed class Drawable : Java.Lang.Object
		{
			// Token: 0x170009A7 RID: 2471
			// (get) Token: 0x06001C32 RID: 7218 RVA: 0x0005146B File Offset: 0x0004F66B
			// (set) Token: 0x06001C33 RID: 7219 RVA: 0x00051481 File Offset: 0x0004F681
			[Register("admob_close_button_black_circle_white_cross")]
			public static int AdmobCloseButtonBlackCircleWhiteCross
			{
				get
				{
					return R.Drawable._members.StaticFields.GetInt32Value("admob_close_button_black_circle_white_cross.I");
				}
				set
				{
					R.Drawable._members.StaticFields.SetValue("admob_close_button_black_circle_white_cross.I", value);
				}
			}

			// Token: 0x170009A8 RID: 2472
			// (get) Token: 0x06001C34 RID: 7220 RVA: 0x00051498 File Offset: 0x0004F698
			// (set) Token: 0x06001C35 RID: 7221 RVA: 0x000514AE File Offset: 0x0004F6AE
			[Register("admob_close_button_white_circle_black_cross")]
			public static int AdmobCloseButtonWhiteCircleBlackCross
			{
				get
				{
					return R.Drawable._members.StaticFields.GetInt32Value("admob_close_button_white_circle_black_cross.I");
				}
				set
				{
					R.Drawable._members.StaticFields.SetValue("admob_close_button_white_circle_black_cross.I", value);
				}
			}

			// Token: 0x170009A9 RID: 2473
			// (get) Token: 0x06001C36 RID: 7222 RVA: 0x000514C5 File Offset: 0x0004F6C5
			// (set) Token: 0x06001C37 RID: 7223 RVA: 0x000514DB File Offset: 0x0004F6DB
			[Register("common_full_open_on_phone")]
			public static int CommonFullOpenOnPhone
			{
				get
				{
					return R.Drawable._members.StaticFields.GetInt32Value("common_full_open_on_phone.I");
				}
				set
				{
					R.Drawable._members.StaticFields.SetValue("common_full_open_on_phone.I", value);
				}
			}

			// Token: 0x170009AA RID: 2474
			// (get) Token: 0x06001C38 RID: 7224 RVA: 0x000514F2 File Offset: 0x0004F6F2
			// (set) Token: 0x06001C39 RID: 7225 RVA: 0x00051508 File Offset: 0x0004F708
			[Register("common_google_signin_btn_icon_dark")]
			public static int CommonGoogleSigninBtnIconDark
			{
				get
				{
					return R.Drawable._members.StaticFields.GetInt32Value("common_google_signin_btn_icon_dark.I");
				}
				set
				{
					R.Drawable._members.StaticFields.SetValue("common_google_signin_btn_icon_dark.I", value);
				}
			}

			// Token: 0x170009AB RID: 2475
			// (get) Token: 0x06001C3A RID: 7226 RVA: 0x0005151F File Offset: 0x0004F71F
			// (set) Token: 0x06001C3B RID: 7227 RVA: 0x00051535 File Offset: 0x0004F735
			[Register("common_google_signin_btn_icon_dark_focused")]
			public static int CommonGoogleSigninBtnIconDarkFocused
			{
				get
				{
					return R.Drawable._members.StaticFields.GetInt32Value("common_google_signin_btn_icon_dark_focused.I");
				}
				set
				{
					R.Drawable._members.StaticFields.SetValue("common_google_signin_btn_icon_dark_focused.I", value);
				}
			}

			// Token: 0x170009AC RID: 2476
			// (get) Token: 0x06001C3C RID: 7228 RVA: 0x0005154C File Offset: 0x0004F74C
			// (set) Token: 0x06001C3D RID: 7229 RVA: 0x00051562 File Offset: 0x0004F762
			[Register("common_google_signin_btn_icon_dark_normal")]
			public static int CommonGoogleSigninBtnIconDarkNormal
			{
				get
				{
					return R.Drawable._members.StaticFields.GetInt32Value("common_google_signin_btn_icon_dark_normal.I");
				}
				set
				{
					R.Drawable._members.StaticFields.SetValue("common_google_signin_btn_icon_dark_normal.I", value);
				}
			}

			// Token: 0x170009AD RID: 2477
			// (get) Token: 0x06001C3E RID: 7230 RVA: 0x00051579 File Offset: 0x0004F779
			// (set) Token: 0x06001C3F RID: 7231 RVA: 0x0005158F File Offset: 0x0004F78F
			[Register("common_google_signin_btn_icon_dark_normal_background")]
			public static int CommonGoogleSigninBtnIconDarkNormalBackground
			{
				get
				{
					return R.Drawable._members.StaticFields.GetInt32Value("common_google_signin_btn_icon_dark_normal_background.I");
				}
				set
				{
					R.Drawable._members.StaticFields.SetValue("common_google_signin_btn_icon_dark_normal_background.I", value);
				}
			}

			// Token: 0x170009AE RID: 2478
			// (get) Token: 0x06001C40 RID: 7232 RVA: 0x000515A6 File Offset: 0x0004F7A6
			// (set) Token: 0x06001C41 RID: 7233 RVA: 0x000515BC File Offset: 0x0004F7BC
			[Register("common_google_signin_btn_icon_disabled")]
			public static int CommonGoogleSigninBtnIconDisabled
			{
				get
				{
					return R.Drawable._members.StaticFields.GetInt32Value("common_google_signin_btn_icon_disabled.I");
				}
				set
				{
					R.Drawable._members.StaticFields.SetValue("common_google_signin_btn_icon_disabled.I", value);
				}
			}

			// Token: 0x170009AF RID: 2479
			// (get) Token: 0x06001C42 RID: 7234 RVA: 0x000515D3 File Offset: 0x0004F7D3
			// (set) Token: 0x06001C43 RID: 7235 RVA: 0x000515E9 File Offset: 0x0004F7E9
			[Register("common_google_signin_btn_icon_light")]
			public static int CommonGoogleSigninBtnIconLight
			{
				get
				{
					return R.Drawable._members.StaticFields.GetInt32Value("common_google_signin_btn_icon_light.I");
				}
				set
				{
					R.Drawable._members.StaticFields.SetValue("common_google_signin_btn_icon_light.I", value);
				}
			}

			// Token: 0x170009B0 RID: 2480
			// (get) Token: 0x06001C44 RID: 7236 RVA: 0x00051600 File Offset: 0x0004F800
			// (set) Token: 0x06001C45 RID: 7237 RVA: 0x00051616 File Offset: 0x0004F816
			[Register("common_google_signin_btn_icon_light_focused")]
			public static int CommonGoogleSigninBtnIconLightFocused
			{
				get
				{
					return R.Drawable._members.StaticFields.GetInt32Value("common_google_signin_btn_icon_light_focused.I");
				}
				set
				{
					R.Drawable._members.StaticFields.SetValue("common_google_signin_btn_icon_light_focused.I", value);
				}
			}

			// Token: 0x170009B1 RID: 2481
			// (get) Token: 0x06001C46 RID: 7238 RVA: 0x0005162D File Offset: 0x0004F82D
			// (set) Token: 0x06001C47 RID: 7239 RVA: 0x00051643 File Offset: 0x0004F843
			[Register("common_google_signin_btn_icon_light_normal")]
			public static int CommonGoogleSigninBtnIconLightNormal
			{
				get
				{
					return R.Drawable._members.StaticFields.GetInt32Value("common_google_signin_btn_icon_light_normal.I");
				}
				set
				{
					R.Drawable._members.StaticFields.SetValue("common_google_signin_btn_icon_light_normal.I", value);
				}
			}

			// Token: 0x170009B2 RID: 2482
			// (get) Token: 0x06001C48 RID: 7240 RVA: 0x0005165A File Offset: 0x0004F85A
			// (set) Token: 0x06001C49 RID: 7241 RVA: 0x00051670 File Offset: 0x0004F870
			[Register("common_google_signin_btn_icon_light_normal_background")]
			public static int CommonGoogleSigninBtnIconLightNormalBackground
			{
				get
				{
					return R.Drawable._members.StaticFields.GetInt32Value("common_google_signin_btn_icon_light_normal_background.I");
				}
				set
				{
					R.Drawable._members.StaticFields.SetValue("common_google_signin_btn_icon_light_normal_background.I", value);
				}
			}

			// Token: 0x170009B3 RID: 2483
			// (get) Token: 0x06001C4A RID: 7242 RVA: 0x00051687 File Offset: 0x0004F887
			// (set) Token: 0x06001C4B RID: 7243 RVA: 0x0005169D File Offset: 0x0004F89D
			[Register("common_google_signin_btn_text_dark")]
			public static int CommonGoogleSigninBtnTextDark
			{
				get
				{
					return R.Drawable._members.StaticFields.GetInt32Value("common_google_signin_btn_text_dark.I");
				}
				set
				{
					R.Drawable._members.StaticFields.SetValue("common_google_signin_btn_text_dark.I", value);
				}
			}

			// Token: 0x170009B4 RID: 2484
			// (get) Token: 0x06001C4C RID: 7244 RVA: 0x000516B4 File Offset: 0x0004F8B4
			// (set) Token: 0x06001C4D RID: 7245 RVA: 0x000516CA File Offset: 0x0004F8CA
			[Register("common_google_signin_btn_text_dark_focused")]
			public static int CommonGoogleSigninBtnTextDarkFocused
			{
				get
				{
					return R.Drawable._members.StaticFields.GetInt32Value("common_google_signin_btn_text_dark_focused.I");
				}
				set
				{
					R.Drawable._members.StaticFields.SetValue("common_google_signin_btn_text_dark_focused.I", value);
				}
			}

			// Token: 0x170009B5 RID: 2485
			// (get) Token: 0x06001C4E RID: 7246 RVA: 0x000516E1 File Offset: 0x0004F8E1
			// (set) Token: 0x06001C4F RID: 7247 RVA: 0x000516F7 File Offset: 0x0004F8F7
			[Register("common_google_signin_btn_text_dark_normal")]
			public static int CommonGoogleSigninBtnTextDarkNormal
			{
				get
				{
					return R.Drawable._members.StaticFields.GetInt32Value("common_google_signin_btn_text_dark_normal.I");
				}
				set
				{
					R.Drawable._members.StaticFields.SetValue("common_google_signin_btn_text_dark_normal.I", value);
				}
			}

			// Token: 0x170009B6 RID: 2486
			// (get) Token: 0x06001C50 RID: 7248 RVA: 0x0005170E File Offset: 0x0004F90E
			// (set) Token: 0x06001C51 RID: 7249 RVA: 0x00051724 File Offset: 0x0004F924
			[Register("common_google_signin_btn_text_dark_normal_background")]
			public static int CommonGoogleSigninBtnTextDarkNormalBackground
			{
				get
				{
					return R.Drawable._members.StaticFields.GetInt32Value("common_google_signin_btn_text_dark_normal_background.I");
				}
				set
				{
					R.Drawable._members.StaticFields.SetValue("common_google_signin_btn_text_dark_normal_background.I", value);
				}
			}

			// Token: 0x170009B7 RID: 2487
			// (get) Token: 0x06001C52 RID: 7250 RVA: 0x0005173B File Offset: 0x0004F93B
			// (set) Token: 0x06001C53 RID: 7251 RVA: 0x00051751 File Offset: 0x0004F951
			[Register("common_google_signin_btn_text_disabled")]
			public static int CommonGoogleSigninBtnTextDisabled
			{
				get
				{
					return R.Drawable._members.StaticFields.GetInt32Value("common_google_signin_btn_text_disabled.I");
				}
				set
				{
					R.Drawable._members.StaticFields.SetValue("common_google_signin_btn_text_disabled.I", value);
				}
			}

			// Token: 0x170009B8 RID: 2488
			// (get) Token: 0x06001C54 RID: 7252 RVA: 0x00051768 File Offset: 0x0004F968
			// (set) Token: 0x06001C55 RID: 7253 RVA: 0x0005177E File Offset: 0x0004F97E
			[Register("common_google_signin_btn_text_light")]
			public static int CommonGoogleSigninBtnTextLight
			{
				get
				{
					return R.Drawable._members.StaticFields.GetInt32Value("common_google_signin_btn_text_light.I");
				}
				set
				{
					R.Drawable._members.StaticFields.SetValue("common_google_signin_btn_text_light.I", value);
				}
			}

			// Token: 0x170009B9 RID: 2489
			// (get) Token: 0x06001C56 RID: 7254 RVA: 0x00051795 File Offset: 0x0004F995
			// (set) Token: 0x06001C57 RID: 7255 RVA: 0x000517AB File Offset: 0x0004F9AB
			[Register("common_google_signin_btn_text_light_focused")]
			public static int CommonGoogleSigninBtnTextLightFocused
			{
				get
				{
					return R.Drawable._members.StaticFields.GetInt32Value("common_google_signin_btn_text_light_focused.I");
				}
				set
				{
					R.Drawable._members.StaticFields.SetValue("common_google_signin_btn_text_light_focused.I", value);
				}
			}

			// Token: 0x170009BA RID: 2490
			// (get) Token: 0x06001C58 RID: 7256 RVA: 0x000517C2 File Offset: 0x0004F9C2
			// (set) Token: 0x06001C59 RID: 7257 RVA: 0x000517D8 File Offset: 0x0004F9D8
			[Register("common_google_signin_btn_text_light_normal")]
			public static int CommonGoogleSigninBtnTextLightNormal
			{
				get
				{
					return R.Drawable._members.StaticFields.GetInt32Value("common_google_signin_btn_text_light_normal.I");
				}
				set
				{
					R.Drawable._members.StaticFields.SetValue("common_google_signin_btn_text_light_normal.I", value);
				}
			}

			// Token: 0x170009BB RID: 2491
			// (get) Token: 0x06001C5A RID: 7258 RVA: 0x000517EF File Offset: 0x0004F9EF
			// (set) Token: 0x06001C5B RID: 7259 RVA: 0x00051805 File Offset: 0x0004FA05
			[Register("common_google_signin_btn_text_light_normal_background")]
			public static int CommonGoogleSigninBtnTextLightNormalBackground
			{
				get
				{
					return R.Drawable._members.StaticFields.GetInt32Value("common_google_signin_btn_text_light_normal_background.I");
				}
				set
				{
					R.Drawable._members.StaticFields.SetValue("common_google_signin_btn_text_light_normal_background.I", value);
				}
			}

			// Token: 0x170009BC RID: 2492
			// (get) Token: 0x06001C5C RID: 7260 RVA: 0x0005181C File Offset: 0x0004FA1C
			// (set) Token: 0x06001C5D RID: 7261 RVA: 0x00051832 File Offset: 0x0004FA32
			[Register("googleg_disabled_color_18")]
			public static int GooglegDisabledColor18
			{
				get
				{
					return R.Drawable._members.StaticFields.GetInt32Value("googleg_disabled_color_18.I");
				}
				set
				{
					R.Drawable._members.StaticFields.SetValue("googleg_disabled_color_18.I", value);
				}
			}

			// Token: 0x170009BD RID: 2493
			// (get) Token: 0x06001C5E RID: 7262 RVA: 0x00051849 File Offset: 0x0004FA49
			// (set) Token: 0x06001C5F RID: 7263 RVA: 0x0005185F File Offset: 0x0004FA5F
			[Register("googleg_standard_color_18")]
			public static int GooglegStandardColor18
			{
				get
				{
					return R.Drawable._members.StaticFields.GetInt32Value("googleg_standard_color_18.I");
				}
				set
				{
					R.Drawable._members.StaticFields.SetValue("googleg_standard_color_18.I", value);
				}
			}

			// Token: 0x170009BE RID: 2494
			// (get) Token: 0x06001C60 RID: 7264 RVA: 0x00051876 File Offset: 0x0004FA76
			// (set) Token: 0x06001C61 RID: 7265 RVA: 0x0005188C File Offset: 0x0004FA8C
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

			// Token: 0x170009BF RID: 2495
			// (get) Token: 0x06001C62 RID: 7266 RVA: 0x000518A3 File Offset: 0x0004FAA3
			// (set) Token: 0x06001C63 RID: 7267 RVA: 0x000518B9 File Offset: 0x0004FAB9
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

			// Token: 0x170009C0 RID: 2496
			// (get) Token: 0x06001C64 RID: 7268 RVA: 0x000518D0 File Offset: 0x0004FAD0
			// (set) Token: 0x06001C65 RID: 7269 RVA: 0x000518E6 File Offset: 0x0004FAE6
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

			// Token: 0x170009C1 RID: 2497
			// (get) Token: 0x06001C66 RID: 7270 RVA: 0x000518FD File Offset: 0x0004FAFD
			// (set) Token: 0x06001C67 RID: 7271 RVA: 0x00051913 File Offset: 0x0004FB13
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

			// Token: 0x170009C2 RID: 2498
			// (get) Token: 0x06001C68 RID: 7272 RVA: 0x0005192A File Offset: 0x0004FB2A
			// (set) Token: 0x06001C69 RID: 7273 RVA: 0x00051940 File Offset: 0x0004FB40
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

			// Token: 0x170009C3 RID: 2499
			// (get) Token: 0x06001C6A RID: 7274 RVA: 0x00051957 File Offset: 0x0004FB57
			// (set) Token: 0x06001C6B RID: 7275 RVA: 0x0005196D File Offset: 0x0004FB6D
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

			// Token: 0x170009C4 RID: 2500
			// (get) Token: 0x06001C6C RID: 7276 RVA: 0x00051984 File Offset: 0x0004FB84
			// (set) Token: 0x06001C6D RID: 7277 RVA: 0x0005199A File Offset: 0x0004FB9A
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

			// Token: 0x170009C5 RID: 2501
			// (get) Token: 0x06001C6E RID: 7278 RVA: 0x000519B1 File Offset: 0x0004FBB1
			// (set) Token: 0x06001C6F RID: 7279 RVA: 0x000519C7 File Offset: 0x0004FBC7
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

			// Token: 0x170009C6 RID: 2502
			// (get) Token: 0x06001C70 RID: 7280 RVA: 0x000519DE File Offset: 0x0004FBDE
			// (set) Token: 0x06001C71 RID: 7281 RVA: 0x000519F4 File Offset: 0x0004FBF4
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

			// Token: 0x170009C7 RID: 2503
			// (get) Token: 0x06001C72 RID: 7282 RVA: 0x00051A0B File Offset: 0x0004FC0B
			// (set) Token: 0x06001C73 RID: 7283 RVA: 0x00051A21 File Offset: 0x0004FC21
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

			// Token: 0x170009C8 RID: 2504
			// (get) Token: 0x06001C74 RID: 7284 RVA: 0x00051A38 File Offset: 0x0004FC38
			// (set) Token: 0x06001C75 RID: 7285 RVA: 0x00051A4E File Offset: 0x0004FC4E
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

			// Token: 0x170009C9 RID: 2505
			// (get) Token: 0x06001C76 RID: 7286 RVA: 0x00051A65 File Offset: 0x0004FC65
			// (set) Token: 0x06001C77 RID: 7287 RVA: 0x00051A7B File Offset: 0x0004FC7B
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

			// Token: 0x170009CA RID: 2506
			// (get) Token: 0x06001C78 RID: 7288 RVA: 0x00051A94 File Offset: 0x0004FC94
			internal static IntPtr class_ref
			{
				get
				{
					return R.Drawable._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x170009CB RID: 2507
			// (get) Token: 0x06001C79 RID: 7289 RVA: 0x00051AB8 File Offset: 0x0004FCB8
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return R.Drawable._members;
				}
			}

			// Token: 0x170009CC RID: 2508
			// (get) Token: 0x06001C7A RID: 7290 RVA: 0x00051AC0 File Offset: 0x0004FCC0
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return R.Drawable._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x170009CD RID: 2509
			// (get) Token: 0x06001C7B RID: 7291 RVA: 0x00051AE4 File Offset: 0x0004FCE4
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return R.Drawable._members.ManagedPeerType;
				}
			}

			// Token: 0x06001C7C RID: 7292 RVA: 0x000021E8 File Offset: 0x000003E8
			internal Drawable(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
			{
			}

			// Token: 0x040006C9 RID: 1737
			private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/scar/adapter/v2100/R$drawable", typeof(R.Drawable));
		}

		// Token: 0x0200023E RID: 574
		[Register("com/unity3d/scar/adapter/v2100/R$id", DoNotGenerateAcw = true)]
		public sealed class Id : Java.Lang.Object
		{
			// Token: 0x170009CE RID: 2510
			// (get) Token: 0x06001C7E RID: 7294 RVA: 0x00051B0B File Offset: 0x0004FD0B
			// (set) Token: 0x06001C7F RID: 7295 RVA: 0x00051B21 File Offset: 0x0004FD21
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

			// Token: 0x170009CF RID: 2511
			// (get) Token: 0x06001C80 RID: 7296 RVA: 0x00051B38 File Offset: 0x0004FD38
			// (set) Token: 0x06001C81 RID: 7297 RVA: 0x00051B4E File Offset: 0x0004FD4E
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

			// Token: 0x170009D0 RID: 2512
			// (get) Token: 0x06001C82 RID: 7298 RVA: 0x00051B65 File Offset: 0x0004FD65
			// (set) Token: 0x06001C83 RID: 7299 RVA: 0x00051B7B File Offset: 0x0004FD7B
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

			// Token: 0x170009D1 RID: 2513
			// (get) Token: 0x06001C84 RID: 7300 RVA: 0x00051B92 File Offset: 0x0004FD92
			// (set) Token: 0x06001C85 RID: 7301 RVA: 0x00051BA8 File Offset: 0x0004FDA8
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

			// Token: 0x170009D2 RID: 2514
			// (get) Token: 0x06001C86 RID: 7302 RVA: 0x00051BBF File Offset: 0x0004FDBF
			// (set) Token: 0x06001C87 RID: 7303 RVA: 0x00051BD5 File Offset: 0x0004FDD5
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

			// Token: 0x170009D3 RID: 2515
			// (get) Token: 0x06001C88 RID: 7304 RVA: 0x00051BEC File Offset: 0x0004FDEC
			// (set) Token: 0x06001C89 RID: 7305 RVA: 0x00051C02 File Offset: 0x0004FE02
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

			// Token: 0x170009D4 RID: 2516
			// (get) Token: 0x06001C8A RID: 7306 RVA: 0x00051C19 File Offset: 0x0004FE19
			// (set) Token: 0x06001C8B RID: 7307 RVA: 0x00051C2F File Offset: 0x0004FE2F
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

			// Token: 0x170009D5 RID: 2517
			// (get) Token: 0x06001C8C RID: 7308 RVA: 0x00051C46 File Offset: 0x0004FE46
			// (set) Token: 0x06001C8D RID: 7309 RVA: 0x00051C5C File Offset: 0x0004FE5C
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

			// Token: 0x170009D6 RID: 2518
			// (get) Token: 0x06001C8E RID: 7310 RVA: 0x00051C73 File Offset: 0x0004FE73
			// (set) Token: 0x06001C8F RID: 7311 RVA: 0x00051C89 File Offset: 0x0004FE89
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

			// Token: 0x170009D7 RID: 2519
			// (get) Token: 0x06001C90 RID: 7312 RVA: 0x00051CA0 File Offset: 0x0004FEA0
			// (set) Token: 0x06001C91 RID: 7313 RVA: 0x00051CB6 File Offset: 0x0004FEB6
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

			// Token: 0x170009D8 RID: 2520
			// (get) Token: 0x06001C92 RID: 7314 RVA: 0x00051CCD File Offset: 0x0004FECD
			// (set) Token: 0x06001C93 RID: 7315 RVA: 0x00051CE3 File Offset: 0x0004FEE3
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

			// Token: 0x170009D9 RID: 2521
			// (get) Token: 0x06001C94 RID: 7316 RVA: 0x00051CFA File Offset: 0x0004FEFA
			// (set) Token: 0x06001C95 RID: 7317 RVA: 0x00051D10 File Offset: 0x0004FF10
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

			// Token: 0x170009DA RID: 2522
			// (get) Token: 0x06001C96 RID: 7318 RVA: 0x00051D27 File Offset: 0x0004FF27
			// (set) Token: 0x06001C97 RID: 7319 RVA: 0x00051D3D File Offset: 0x0004FF3D
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

			// Token: 0x170009DB RID: 2523
			// (get) Token: 0x06001C98 RID: 7320 RVA: 0x00051D54 File Offset: 0x0004FF54
			// (set) Token: 0x06001C99 RID: 7321 RVA: 0x00051D6A File Offset: 0x0004FF6A
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

			// Token: 0x170009DC RID: 2524
			// (get) Token: 0x06001C9A RID: 7322 RVA: 0x00051D81 File Offset: 0x0004FF81
			// (set) Token: 0x06001C9B RID: 7323 RVA: 0x00051D97 File Offset: 0x0004FF97
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

			// Token: 0x170009DD RID: 2525
			// (get) Token: 0x06001C9C RID: 7324 RVA: 0x00051DAE File Offset: 0x0004FFAE
			// (set) Token: 0x06001C9D RID: 7325 RVA: 0x00051DC4 File Offset: 0x0004FFC4
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

			// Token: 0x170009DE RID: 2526
			// (get) Token: 0x06001C9E RID: 7326 RVA: 0x00051DDB File Offset: 0x0004FFDB
			// (set) Token: 0x06001C9F RID: 7327 RVA: 0x00051DF1 File Offset: 0x0004FFF1
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

			// Token: 0x170009DF RID: 2527
			// (get) Token: 0x06001CA0 RID: 7328 RVA: 0x00051E08 File Offset: 0x00050008
			// (set) Token: 0x06001CA1 RID: 7329 RVA: 0x00051E1E File Offset: 0x0005001E
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

			// Token: 0x170009E0 RID: 2528
			// (get) Token: 0x06001CA2 RID: 7330 RVA: 0x00051E35 File Offset: 0x00050035
			// (set) Token: 0x06001CA3 RID: 7331 RVA: 0x00051E4B File Offset: 0x0005004B
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

			// Token: 0x170009E1 RID: 2529
			// (get) Token: 0x06001CA4 RID: 7332 RVA: 0x00051E62 File Offset: 0x00050062
			// (set) Token: 0x06001CA5 RID: 7333 RVA: 0x00051E78 File Offset: 0x00050078
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

			// Token: 0x170009E2 RID: 2530
			// (get) Token: 0x06001CA6 RID: 7334 RVA: 0x00051E8F File Offset: 0x0005008F
			// (set) Token: 0x06001CA7 RID: 7335 RVA: 0x00051EA5 File Offset: 0x000500A5
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

			// Token: 0x170009E3 RID: 2531
			// (get) Token: 0x06001CA8 RID: 7336 RVA: 0x00051EBC File Offset: 0x000500BC
			// (set) Token: 0x06001CA9 RID: 7337 RVA: 0x00051ED2 File Offset: 0x000500D2
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

			// Token: 0x170009E4 RID: 2532
			// (get) Token: 0x06001CAA RID: 7338 RVA: 0x00051EE9 File Offset: 0x000500E9
			// (set) Token: 0x06001CAB RID: 7339 RVA: 0x00051EFF File Offset: 0x000500FF
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

			// Token: 0x170009E5 RID: 2533
			// (get) Token: 0x06001CAC RID: 7340 RVA: 0x00051F16 File Offset: 0x00050116
			// (set) Token: 0x06001CAD RID: 7341 RVA: 0x00051F2C File Offset: 0x0005012C
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

			// Token: 0x170009E6 RID: 2534
			// (get) Token: 0x06001CAE RID: 7342 RVA: 0x00051F43 File Offset: 0x00050143
			// (set) Token: 0x06001CAF RID: 7343 RVA: 0x00051F59 File Offset: 0x00050159
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

			// Token: 0x170009E7 RID: 2535
			// (get) Token: 0x06001CB0 RID: 7344 RVA: 0x00051F70 File Offset: 0x00050170
			// (set) Token: 0x06001CB1 RID: 7345 RVA: 0x00051F86 File Offset: 0x00050186
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

			// Token: 0x170009E8 RID: 2536
			// (get) Token: 0x06001CB2 RID: 7346 RVA: 0x00051F9D File Offset: 0x0005019D
			// (set) Token: 0x06001CB3 RID: 7347 RVA: 0x00051FB3 File Offset: 0x000501B3
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

			// Token: 0x170009E9 RID: 2537
			// (get) Token: 0x06001CB4 RID: 7348 RVA: 0x00051FCA File Offset: 0x000501CA
			// (set) Token: 0x06001CB5 RID: 7349 RVA: 0x00051FE0 File Offset: 0x000501E0
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

			// Token: 0x170009EA RID: 2538
			// (get) Token: 0x06001CB6 RID: 7350 RVA: 0x00051FF7 File Offset: 0x000501F7
			// (set) Token: 0x06001CB7 RID: 7351 RVA: 0x0005200D File Offset: 0x0005020D
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

			// Token: 0x170009EB RID: 2539
			// (get) Token: 0x06001CB8 RID: 7352 RVA: 0x00052024 File Offset: 0x00050224
			// (set) Token: 0x06001CB9 RID: 7353 RVA: 0x0005203A File Offset: 0x0005023A
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

			// Token: 0x170009EC RID: 2540
			// (get) Token: 0x06001CBA RID: 7354 RVA: 0x00052051 File Offset: 0x00050251
			// (set) Token: 0x06001CBB RID: 7355 RVA: 0x00052067 File Offset: 0x00050267
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

			// Token: 0x170009ED RID: 2541
			// (get) Token: 0x06001CBC RID: 7356 RVA: 0x0005207E File Offset: 0x0005027E
			// (set) Token: 0x06001CBD RID: 7357 RVA: 0x00052094 File Offset: 0x00050294
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

			// Token: 0x170009EE RID: 2542
			// (get) Token: 0x06001CBE RID: 7358 RVA: 0x000520AB File Offset: 0x000502AB
			// (set) Token: 0x06001CBF RID: 7359 RVA: 0x000520C1 File Offset: 0x000502C1
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

			// Token: 0x170009EF RID: 2543
			// (get) Token: 0x06001CC0 RID: 7360 RVA: 0x000520D8 File Offset: 0x000502D8
			// (set) Token: 0x06001CC1 RID: 7361 RVA: 0x000520EE File Offset: 0x000502EE
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

			// Token: 0x170009F0 RID: 2544
			// (get) Token: 0x06001CC2 RID: 7362 RVA: 0x00052105 File Offset: 0x00050305
			// (set) Token: 0x06001CC3 RID: 7363 RVA: 0x0005211B File Offset: 0x0005031B
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

			// Token: 0x170009F1 RID: 2545
			// (get) Token: 0x06001CC4 RID: 7364 RVA: 0x00052132 File Offset: 0x00050332
			// (set) Token: 0x06001CC5 RID: 7365 RVA: 0x00052148 File Offset: 0x00050348
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

			// Token: 0x170009F2 RID: 2546
			// (get) Token: 0x06001CC6 RID: 7366 RVA: 0x0005215F File Offset: 0x0005035F
			// (set) Token: 0x06001CC7 RID: 7367 RVA: 0x00052175 File Offset: 0x00050375
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

			// Token: 0x170009F3 RID: 2547
			// (get) Token: 0x06001CC8 RID: 7368 RVA: 0x0005218C File Offset: 0x0005038C
			// (set) Token: 0x06001CC9 RID: 7369 RVA: 0x000521A2 File Offset: 0x000503A2
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

			// Token: 0x170009F4 RID: 2548
			// (get) Token: 0x06001CCA RID: 7370 RVA: 0x000521B9 File Offset: 0x000503B9
			// (set) Token: 0x06001CCB RID: 7371 RVA: 0x000521CF File Offset: 0x000503CF
			[Register("adjust_height")]
			public static int AdjustHeight
			{
				get
				{
					return R.Id._members.StaticFields.GetInt32Value("adjust_height.I");
				}
				set
				{
					R.Id._members.StaticFields.SetValue("adjust_height.I", value);
				}
			}

			// Token: 0x170009F5 RID: 2549
			// (get) Token: 0x06001CCC RID: 7372 RVA: 0x000521E6 File Offset: 0x000503E6
			// (set) Token: 0x06001CCD RID: 7373 RVA: 0x000521FC File Offset: 0x000503FC
			[Register("adjust_width")]
			public static int AdjustWidth
			{
				get
				{
					return R.Id._members.StaticFields.GetInt32Value("adjust_width.I");
				}
				set
				{
					R.Id._members.StaticFields.SetValue("adjust_width.I", value);
				}
			}

			// Token: 0x170009F6 RID: 2550
			// (get) Token: 0x06001CCE RID: 7374 RVA: 0x00052213 File Offset: 0x00050413
			// (set) Token: 0x06001CCF RID: 7375 RVA: 0x00052229 File Offset: 0x00050429
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

			// Token: 0x170009F7 RID: 2551
			// (get) Token: 0x06001CD0 RID: 7376 RVA: 0x00052240 File Offset: 0x00050440
			// (set) Token: 0x06001CD1 RID: 7377 RVA: 0x00052256 File Offset: 0x00050456
			[Register("auto")]
			public static int Auto
			{
				get
				{
					return R.Id._members.StaticFields.GetInt32Value("auto.I");
				}
				set
				{
					R.Id._members.StaticFields.SetValue("auto.I", value);
				}
			}

			// Token: 0x170009F8 RID: 2552
			// (get) Token: 0x06001CD2 RID: 7378 RVA: 0x0005226D File Offset: 0x0005046D
			// (set) Token: 0x06001CD3 RID: 7379 RVA: 0x00052283 File Offset: 0x00050483
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

			// Token: 0x170009F9 RID: 2553
			// (get) Token: 0x06001CD4 RID: 7380 RVA: 0x0005229A File Offset: 0x0005049A
			// (set) Token: 0x06001CD5 RID: 7381 RVA: 0x000522B0 File Offset: 0x000504B0
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

			// Token: 0x170009FA RID: 2554
			// (get) Token: 0x06001CD6 RID: 7382 RVA: 0x000522C7 File Offset: 0x000504C7
			// (set) Token: 0x06001CD7 RID: 7383 RVA: 0x000522DD File Offset: 0x000504DD
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

			// Token: 0x170009FB RID: 2555
			// (get) Token: 0x06001CD8 RID: 7384 RVA: 0x000522F4 File Offset: 0x000504F4
			// (set) Token: 0x06001CD9 RID: 7385 RVA: 0x0005230A File Offset: 0x0005050A
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

			// Token: 0x170009FC RID: 2556
			// (get) Token: 0x06001CDA RID: 7386 RVA: 0x00052321 File Offset: 0x00050521
			// (set) Token: 0x06001CDB RID: 7387 RVA: 0x00052337 File Offset: 0x00050537
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

			// Token: 0x170009FD RID: 2557
			// (get) Token: 0x06001CDC RID: 7388 RVA: 0x0005234E File Offset: 0x0005054E
			// (set) Token: 0x06001CDD RID: 7389 RVA: 0x00052364 File Offset: 0x00050564
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

			// Token: 0x170009FE RID: 2558
			// (get) Token: 0x06001CDE RID: 7390 RVA: 0x0005237B File Offset: 0x0005057B
			// (set) Token: 0x06001CDF RID: 7391 RVA: 0x00052391 File Offset: 0x00050591
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

			// Token: 0x170009FF RID: 2559
			// (get) Token: 0x06001CE0 RID: 7392 RVA: 0x000523A8 File Offset: 0x000505A8
			// (set) Token: 0x06001CE1 RID: 7393 RVA: 0x000523BE File Offset: 0x000505BE
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

			// Token: 0x17000A00 RID: 2560
			// (get) Token: 0x06001CE2 RID: 7394 RVA: 0x000523D5 File Offset: 0x000505D5
			// (set) Token: 0x06001CE3 RID: 7395 RVA: 0x000523EB File Offset: 0x000505EB
			[Register("dark")]
			public static int Dark
			{
				get
				{
					return R.Id._members.StaticFields.GetInt32Value("dark.I");
				}
				set
				{
					R.Id._members.StaticFields.SetValue("dark.I", value);
				}
			}

			// Token: 0x17000A01 RID: 2561
			// (get) Token: 0x06001CE4 RID: 7396 RVA: 0x00052402 File Offset: 0x00050602
			// (set) Token: 0x06001CE5 RID: 7397 RVA: 0x00052418 File Offset: 0x00050618
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

			// Token: 0x17000A02 RID: 2562
			// (get) Token: 0x06001CE6 RID: 7398 RVA: 0x0005242F File Offset: 0x0005062F
			// (set) Token: 0x06001CE7 RID: 7399 RVA: 0x00052445 File Offset: 0x00050645
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

			// Token: 0x17000A03 RID: 2563
			// (get) Token: 0x06001CE8 RID: 7400 RVA: 0x0005245C File Offset: 0x0005065C
			// (set) Token: 0x06001CE9 RID: 7401 RVA: 0x00052472 File Offset: 0x00050672
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

			// Token: 0x17000A04 RID: 2564
			// (get) Token: 0x06001CEA RID: 7402 RVA: 0x00052489 File Offset: 0x00050689
			// (set) Token: 0x06001CEB RID: 7403 RVA: 0x0005249F File Offset: 0x0005069F
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

			// Token: 0x17000A05 RID: 2565
			// (get) Token: 0x06001CEC RID: 7404 RVA: 0x000524B6 File Offset: 0x000506B6
			// (set) Token: 0x06001CED RID: 7405 RVA: 0x000524CC File Offset: 0x000506CC
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

			// Token: 0x17000A06 RID: 2566
			// (get) Token: 0x06001CEE RID: 7406 RVA: 0x000524E3 File Offset: 0x000506E3
			// (set) Token: 0x06001CEF RID: 7407 RVA: 0x000524F9 File Offset: 0x000506F9
			[Register("icon_only")]
			public static int IconOnly
			{
				get
				{
					return R.Id._members.StaticFields.GetInt32Value("icon_only.I");
				}
				set
				{
					R.Id._members.StaticFields.SetValue("icon_only.I", value);
				}
			}

			// Token: 0x17000A07 RID: 2567
			// (get) Token: 0x06001CF0 RID: 7408 RVA: 0x00052510 File Offset: 0x00050710
			// (set) Token: 0x06001CF1 RID: 7409 RVA: 0x00052526 File Offset: 0x00050726
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

			// Token: 0x17000A08 RID: 2568
			// (get) Token: 0x06001CF2 RID: 7410 RVA: 0x0005253D File Offset: 0x0005073D
			// (set) Token: 0x06001CF3 RID: 7411 RVA: 0x00052553 File Offset: 0x00050753
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

			// Token: 0x17000A09 RID: 2569
			// (get) Token: 0x06001CF4 RID: 7412 RVA: 0x0005256A File Offset: 0x0005076A
			// (set) Token: 0x06001CF5 RID: 7413 RVA: 0x00052580 File Offset: 0x00050780
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

			// Token: 0x17000A0A RID: 2570
			// (get) Token: 0x06001CF6 RID: 7414 RVA: 0x00052597 File Offset: 0x00050797
			// (set) Token: 0x06001CF7 RID: 7415 RVA: 0x000525AD File Offset: 0x000507AD
			[Register("light")]
			public static int Light
			{
				get
				{
					return R.Id._members.StaticFields.GetInt32Value("light.I");
				}
				set
				{
					R.Id._members.StaticFields.SetValue("light.I", value);
				}
			}

			// Token: 0x17000A0B RID: 2571
			// (get) Token: 0x06001CF8 RID: 7416 RVA: 0x000525C4 File Offset: 0x000507C4
			// (set) Token: 0x06001CF9 RID: 7417 RVA: 0x000525DA File Offset: 0x000507DA
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

			// Token: 0x17000A0C RID: 2572
			// (get) Token: 0x06001CFA RID: 7418 RVA: 0x000525F1 File Offset: 0x000507F1
			// (set) Token: 0x06001CFB RID: 7419 RVA: 0x00052607 File Offset: 0x00050807
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

			// Token: 0x17000A0D RID: 2573
			// (get) Token: 0x06001CFC RID: 7420 RVA: 0x0005261E File Offset: 0x0005081E
			// (set) Token: 0x06001CFD RID: 7421 RVA: 0x00052634 File Offset: 0x00050834
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

			// Token: 0x17000A0E RID: 2574
			// (get) Token: 0x06001CFE RID: 7422 RVA: 0x0005264B File Offset: 0x0005084B
			// (set) Token: 0x06001CFF RID: 7423 RVA: 0x00052661 File Offset: 0x00050861
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

			// Token: 0x17000A0F RID: 2575
			// (get) Token: 0x06001D00 RID: 7424 RVA: 0x00052678 File Offset: 0x00050878
			// (set) Token: 0x06001D01 RID: 7425 RVA: 0x0005268E File Offset: 0x0005088E
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

			// Token: 0x17000A10 RID: 2576
			// (get) Token: 0x06001D02 RID: 7426 RVA: 0x000526A5 File Offset: 0x000508A5
			// (set) Token: 0x06001D03 RID: 7427 RVA: 0x000526BB File Offset: 0x000508BB
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

			// Token: 0x17000A11 RID: 2577
			// (get) Token: 0x06001D04 RID: 7428 RVA: 0x000526D2 File Offset: 0x000508D2
			// (set) Token: 0x06001D05 RID: 7429 RVA: 0x000526E8 File Offset: 0x000508E8
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

			// Token: 0x17000A12 RID: 2578
			// (get) Token: 0x06001D06 RID: 7430 RVA: 0x000526FF File Offset: 0x000508FF
			// (set) Token: 0x06001D07 RID: 7431 RVA: 0x00052715 File Offset: 0x00050915
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

			// Token: 0x17000A13 RID: 2579
			// (get) Token: 0x06001D08 RID: 7432 RVA: 0x0005272C File Offset: 0x0005092C
			// (set) Token: 0x06001D09 RID: 7433 RVA: 0x00052742 File Offset: 0x00050942
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

			// Token: 0x17000A14 RID: 2580
			// (get) Token: 0x06001D0A RID: 7434 RVA: 0x00052759 File Offset: 0x00050959
			// (set) Token: 0x06001D0B RID: 7435 RVA: 0x0005276F File Offset: 0x0005096F
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

			// Token: 0x17000A15 RID: 2581
			// (get) Token: 0x06001D0C RID: 7436 RVA: 0x00052786 File Offset: 0x00050986
			// (set) Token: 0x06001D0D RID: 7437 RVA: 0x0005279C File Offset: 0x0005099C
			[Register("standard")]
			public static int Standard
			{
				get
				{
					return R.Id._members.StaticFields.GetInt32Value("standard.I");
				}
				set
				{
					R.Id._members.StaticFields.SetValue("standard.I", value);
				}
			}

			// Token: 0x17000A16 RID: 2582
			// (get) Token: 0x06001D0E RID: 7438 RVA: 0x000527B3 File Offset: 0x000509B3
			// (set) Token: 0x06001D0F RID: 7439 RVA: 0x000527C9 File Offset: 0x000509C9
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

			// Token: 0x17000A17 RID: 2583
			// (get) Token: 0x06001D10 RID: 7440 RVA: 0x000527E0 File Offset: 0x000509E0
			// (set) Token: 0x06001D11 RID: 7441 RVA: 0x000527F6 File Offset: 0x000509F6
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

			// Token: 0x17000A18 RID: 2584
			// (get) Token: 0x06001D12 RID: 7442 RVA: 0x0005280D File Offset: 0x00050A0D
			// (set) Token: 0x06001D13 RID: 7443 RVA: 0x00052823 File Offset: 0x00050A23
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

			// Token: 0x17000A19 RID: 2585
			// (get) Token: 0x06001D14 RID: 7444 RVA: 0x0005283A File Offset: 0x00050A3A
			// (set) Token: 0x06001D15 RID: 7445 RVA: 0x00052850 File Offset: 0x00050A50
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

			// Token: 0x17000A1A RID: 2586
			// (get) Token: 0x06001D16 RID: 7446 RVA: 0x00052867 File Offset: 0x00050A67
			// (set) Token: 0x06001D17 RID: 7447 RVA: 0x0005287D File Offset: 0x00050A7D
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

			// Token: 0x17000A1B RID: 2587
			// (get) Token: 0x06001D18 RID: 7448 RVA: 0x00052894 File Offset: 0x00050A94
			// (set) Token: 0x06001D19 RID: 7449 RVA: 0x000528AA File Offset: 0x00050AAA
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

			// Token: 0x17000A1C RID: 2588
			// (get) Token: 0x06001D1A RID: 7450 RVA: 0x000528C1 File Offset: 0x00050AC1
			// (set) Token: 0x06001D1B RID: 7451 RVA: 0x000528D7 File Offset: 0x00050AD7
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

			// Token: 0x17000A1D RID: 2589
			// (get) Token: 0x06001D1C RID: 7452 RVA: 0x000528EE File Offset: 0x00050AEE
			// (set) Token: 0x06001D1D RID: 7453 RVA: 0x00052904 File Offset: 0x00050B04
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

			// Token: 0x17000A1E RID: 2590
			// (get) Token: 0x06001D1E RID: 7454 RVA: 0x0005291B File Offset: 0x00050B1B
			// (set) Token: 0x06001D1F RID: 7455 RVA: 0x00052931 File Offset: 0x00050B31
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

			// Token: 0x17000A1F RID: 2591
			// (get) Token: 0x06001D20 RID: 7456 RVA: 0x00052948 File Offset: 0x00050B48
			// (set) Token: 0x06001D21 RID: 7457 RVA: 0x0005295E File Offset: 0x00050B5E
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

			// Token: 0x17000A20 RID: 2592
			// (get) Token: 0x06001D22 RID: 7458 RVA: 0x00052975 File Offset: 0x00050B75
			// (set) Token: 0x06001D23 RID: 7459 RVA: 0x0005298B File Offset: 0x00050B8B
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

			// Token: 0x17000A21 RID: 2593
			// (get) Token: 0x06001D24 RID: 7460 RVA: 0x000529A2 File Offset: 0x00050BA2
			// (set) Token: 0x06001D25 RID: 7461 RVA: 0x000529B8 File Offset: 0x00050BB8
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

			// Token: 0x17000A22 RID: 2594
			// (get) Token: 0x06001D26 RID: 7462 RVA: 0x000529CF File Offset: 0x00050BCF
			// (set) Token: 0x06001D27 RID: 7463 RVA: 0x000529E5 File Offset: 0x00050BE5
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

			// Token: 0x17000A23 RID: 2595
			// (get) Token: 0x06001D28 RID: 7464 RVA: 0x000529FC File Offset: 0x00050BFC
			// (set) Token: 0x06001D29 RID: 7465 RVA: 0x00052A12 File Offset: 0x00050C12
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

			// Token: 0x17000A24 RID: 2596
			// (get) Token: 0x06001D2A RID: 7466 RVA: 0x00052A29 File Offset: 0x00050C29
			// (set) Token: 0x06001D2B RID: 7467 RVA: 0x00052A3F File Offset: 0x00050C3F
			[Register("wide")]
			public static int Wide
			{
				get
				{
					return R.Id._members.StaticFields.GetInt32Value("wide.I");
				}
				set
				{
					R.Id._members.StaticFields.SetValue("wide.I", value);
				}
			}

			// Token: 0x17000A25 RID: 2597
			// (get) Token: 0x06001D2C RID: 7468 RVA: 0x00052A58 File Offset: 0x00050C58
			internal static IntPtr class_ref
			{
				get
				{
					return R.Id._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x17000A26 RID: 2598
			// (get) Token: 0x06001D2D RID: 7469 RVA: 0x00052A7C File Offset: 0x00050C7C
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return R.Id._members;
				}
			}

			// Token: 0x17000A27 RID: 2599
			// (get) Token: 0x06001D2E RID: 7470 RVA: 0x00052A84 File Offset: 0x00050C84
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return R.Id._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x17000A28 RID: 2600
			// (get) Token: 0x06001D2F RID: 7471 RVA: 0x00052AA8 File Offset: 0x00050CA8
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return R.Id._members.ManagedPeerType;
				}
			}

			// Token: 0x06001D30 RID: 7472 RVA: 0x000021E8 File Offset: 0x000003E8
			internal Id(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
			{
			}

			// Token: 0x040006CA RID: 1738
			private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/scar/adapter/v2100/R$id", typeof(R.Id));
		}

		// Token: 0x0200023F RID: 575
		[Register("com/unity3d/scar/adapter/v2100/R$integer", DoNotGenerateAcw = true)]
		public sealed class Integer : Java.Lang.Object
		{
			// Token: 0x17000A29 RID: 2601
			// (get) Token: 0x06001D32 RID: 7474 RVA: 0x00052ACF File Offset: 0x00050CCF
			// (set) Token: 0x06001D33 RID: 7475 RVA: 0x00052AE5 File Offset: 0x00050CE5
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

			// Token: 0x17000A2A RID: 2602
			// (get) Token: 0x06001D34 RID: 7476 RVA: 0x00052AFC File Offset: 0x00050CFC
			// (set) Token: 0x06001D35 RID: 7477 RVA: 0x00052B12 File Offset: 0x00050D12
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

			// Token: 0x17000A2B RID: 2603
			// (get) Token: 0x06001D36 RID: 7478 RVA: 0x00052B2C File Offset: 0x00050D2C
			internal static IntPtr class_ref
			{
				get
				{
					return R.Integer._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x17000A2C RID: 2604
			// (get) Token: 0x06001D37 RID: 7479 RVA: 0x00052B50 File Offset: 0x00050D50
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return R.Integer._members;
				}
			}

			// Token: 0x17000A2D RID: 2605
			// (get) Token: 0x06001D38 RID: 7480 RVA: 0x00052B58 File Offset: 0x00050D58
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return R.Integer._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x17000A2E RID: 2606
			// (get) Token: 0x06001D39 RID: 7481 RVA: 0x00052B7C File Offset: 0x00050D7C
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return R.Integer._members.ManagedPeerType;
				}
			}

			// Token: 0x06001D3A RID: 7482 RVA: 0x000021E8 File Offset: 0x000003E8
			internal Integer(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
			{
			}

			// Token: 0x040006CB RID: 1739
			private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/scar/adapter/v2100/R$integer", typeof(R.Integer));
		}

		// Token: 0x02000240 RID: 576
		[Register("com/unity3d/scar/adapter/v2100/R$layout", DoNotGenerateAcw = true)]
		public sealed class Layout : Java.Lang.Object
		{
			// Token: 0x17000A2F RID: 2607
			// (get) Token: 0x06001D3C RID: 7484 RVA: 0x00052BA3 File Offset: 0x00050DA3
			// (set) Token: 0x06001D3D RID: 7485 RVA: 0x00052BB9 File Offset: 0x00050DB9
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

			// Token: 0x17000A30 RID: 2608
			// (get) Token: 0x06001D3E RID: 7486 RVA: 0x00052BD0 File Offset: 0x00050DD0
			// (set) Token: 0x06001D3F RID: 7487 RVA: 0x00052BE6 File Offset: 0x00050DE6
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

			// Token: 0x17000A31 RID: 2609
			// (get) Token: 0x06001D40 RID: 7488 RVA: 0x00052BFD File Offset: 0x00050DFD
			// (set) Token: 0x06001D41 RID: 7489 RVA: 0x00052C13 File Offset: 0x00050E13
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

			// Token: 0x17000A32 RID: 2610
			// (get) Token: 0x06001D42 RID: 7490 RVA: 0x00052C2A File Offset: 0x00050E2A
			// (set) Token: 0x06001D43 RID: 7491 RVA: 0x00052C40 File Offset: 0x00050E40
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

			// Token: 0x17000A33 RID: 2611
			// (get) Token: 0x06001D44 RID: 7492 RVA: 0x00052C57 File Offset: 0x00050E57
			// (set) Token: 0x06001D45 RID: 7493 RVA: 0x00052C6D File Offset: 0x00050E6D
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

			// Token: 0x17000A34 RID: 2612
			// (get) Token: 0x06001D46 RID: 7494 RVA: 0x00052C84 File Offset: 0x00050E84
			// (set) Token: 0x06001D47 RID: 7495 RVA: 0x00052C9A File Offset: 0x00050E9A
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

			// Token: 0x17000A35 RID: 2613
			// (get) Token: 0x06001D48 RID: 7496 RVA: 0x00052CB1 File Offset: 0x00050EB1
			// (set) Token: 0x06001D49 RID: 7497 RVA: 0x00052CC7 File Offset: 0x00050EC7
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

			// Token: 0x17000A36 RID: 2614
			// (get) Token: 0x06001D4A RID: 7498 RVA: 0x00052CDE File Offset: 0x00050EDE
			// (set) Token: 0x06001D4B RID: 7499 RVA: 0x00052CF4 File Offset: 0x00050EF4
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

			// Token: 0x17000A37 RID: 2615
			// (get) Token: 0x06001D4C RID: 7500 RVA: 0x00052D0B File Offset: 0x00050F0B
			// (set) Token: 0x06001D4D RID: 7501 RVA: 0x00052D21 File Offset: 0x00050F21
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

			// Token: 0x17000A38 RID: 2616
			// (get) Token: 0x06001D4E RID: 7502 RVA: 0x00052D38 File Offset: 0x00050F38
			internal static IntPtr class_ref
			{
				get
				{
					return R.Layout._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x17000A39 RID: 2617
			// (get) Token: 0x06001D4F RID: 7503 RVA: 0x00052D5C File Offset: 0x00050F5C
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return R.Layout._members;
				}
			}

			// Token: 0x17000A3A RID: 2618
			// (get) Token: 0x06001D50 RID: 7504 RVA: 0x00052D64 File Offset: 0x00050F64
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return R.Layout._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x17000A3B RID: 2619
			// (get) Token: 0x06001D51 RID: 7505 RVA: 0x00052D88 File Offset: 0x00050F88
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return R.Layout._members.ManagedPeerType;
				}
			}

			// Token: 0x06001D52 RID: 7506 RVA: 0x000021E8 File Offset: 0x000003E8
			internal Layout(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
			{
			}

			// Token: 0x040006CC RID: 1740
			private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/scar/adapter/v2100/R$layout", typeof(R.Layout));
		}

		// Token: 0x02000241 RID: 577
		[Register("com/unity3d/scar/adapter/v2100/R$string", DoNotGenerateAcw = true)]
		public sealed class String : Java.Lang.Object
		{
			// Token: 0x17000A3C RID: 2620
			// (get) Token: 0x06001D54 RID: 7508 RVA: 0x00052DAF File Offset: 0x00050FAF
			// (set) Token: 0x06001D55 RID: 7509 RVA: 0x00052DC5 File Offset: 0x00050FC5
			[Register("androidx_startup")]
			public static int AndroidxStartup
			{
				get
				{
					return R.String._members.StaticFields.GetInt32Value("androidx_startup.I");
				}
				set
				{
					R.String._members.StaticFields.SetValue("androidx_startup.I", value);
				}
			}

			// Token: 0x17000A3D RID: 2621
			// (get) Token: 0x06001D56 RID: 7510 RVA: 0x00052DDC File Offset: 0x00050FDC
			// (set) Token: 0x06001D57 RID: 7511 RVA: 0x00052DF2 File Offset: 0x00050FF2
			[Register("common_google_play_services_enable_button")]
			public static int CommonGooglePlayServicesEnableButton
			{
				get
				{
					return R.String._members.StaticFields.GetInt32Value("common_google_play_services_enable_button.I");
				}
				set
				{
					R.String._members.StaticFields.SetValue("common_google_play_services_enable_button.I", value);
				}
			}

			// Token: 0x17000A3E RID: 2622
			// (get) Token: 0x06001D58 RID: 7512 RVA: 0x00052E09 File Offset: 0x00051009
			// (set) Token: 0x06001D59 RID: 7513 RVA: 0x00052E1F File Offset: 0x0005101F
			[Register("common_google_play_services_enable_text")]
			public static int CommonGooglePlayServicesEnableText
			{
				get
				{
					return R.String._members.StaticFields.GetInt32Value("common_google_play_services_enable_text.I");
				}
				set
				{
					R.String._members.StaticFields.SetValue("common_google_play_services_enable_text.I", value);
				}
			}

			// Token: 0x17000A3F RID: 2623
			// (get) Token: 0x06001D5A RID: 7514 RVA: 0x00052E36 File Offset: 0x00051036
			// (set) Token: 0x06001D5B RID: 7515 RVA: 0x00052E4C File Offset: 0x0005104C
			[Register("common_google_play_services_enable_title")]
			public static int CommonGooglePlayServicesEnableTitle
			{
				get
				{
					return R.String._members.StaticFields.GetInt32Value("common_google_play_services_enable_title.I");
				}
				set
				{
					R.String._members.StaticFields.SetValue("common_google_play_services_enable_title.I", value);
				}
			}

			// Token: 0x17000A40 RID: 2624
			// (get) Token: 0x06001D5C RID: 7516 RVA: 0x00052E63 File Offset: 0x00051063
			// (set) Token: 0x06001D5D RID: 7517 RVA: 0x00052E79 File Offset: 0x00051079
			[Register("common_google_play_services_install_button")]
			public static int CommonGooglePlayServicesInstallButton
			{
				get
				{
					return R.String._members.StaticFields.GetInt32Value("common_google_play_services_install_button.I");
				}
				set
				{
					R.String._members.StaticFields.SetValue("common_google_play_services_install_button.I", value);
				}
			}

			// Token: 0x17000A41 RID: 2625
			// (get) Token: 0x06001D5E RID: 7518 RVA: 0x00052E90 File Offset: 0x00051090
			// (set) Token: 0x06001D5F RID: 7519 RVA: 0x00052EA6 File Offset: 0x000510A6
			[Register("common_google_play_services_install_text")]
			public static int CommonGooglePlayServicesInstallText
			{
				get
				{
					return R.String._members.StaticFields.GetInt32Value("common_google_play_services_install_text.I");
				}
				set
				{
					R.String._members.StaticFields.SetValue("common_google_play_services_install_text.I", value);
				}
			}

			// Token: 0x17000A42 RID: 2626
			// (get) Token: 0x06001D60 RID: 7520 RVA: 0x00052EBD File Offset: 0x000510BD
			// (set) Token: 0x06001D61 RID: 7521 RVA: 0x00052ED3 File Offset: 0x000510D3
			[Register("common_google_play_services_install_title")]
			public static int CommonGooglePlayServicesInstallTitle
			{
				get
				{
					return R.String._members.StaticFields.GetInt32Value("common_google_play_services_install_title.I");
				}
				set
				{
					R.String._members.StaticFields.SetValue("common_google_play_services_install_title.I", value);
				}
			}

			// Token: 0x17000A43 RID: 2627
			// (get) Token: 0x06001D62 RID: 7522 RVA: 0x00052EEA File Offset: 0x000510EA
			// (set) Token: 0x06001D63 RID: 7523 RVA: 0x00052F00 File Offset: 0x00051100
			[Register("common_google_play_services_notification_channel_name")]
			public static int CommonGooglePlayServicesNotificationChannelName
			{
				get
				{
					return R.String._members.StaticFields.GetInt32Value("common_google_play_services_notification_channel_name.I");
				}
				set
				{
					R.String._members.StaticFields.SetValue("common_google_play_services_notification_channel_name.I", value);
				}
			}

			// Token: 0x17000A44 RID: 2628
			// (get) Token: 0x06001D64 RID: 7524 RVA: 0x00052F17 File Offset: 0x00051117
			// (set) Token: 0x06001D65 RID: 7525 RVA: 0x00052F2D File Offset: 0x0005112D
			[Register("common_google_play_services_notification_ticker")]
			public static int CommonGooglePlayServicesNotificationTicker
			{
				get
				{
					return R.String._members.StaticFields.GetInt32Value("common_google_play_services_notification_ticker.I");
				}
				set
				{
					R.String._members.StaticFields.SetValue("common_google_play_services_notification_ticker.I", value);
				}
			}

			// Token: 0x17000A45 RID: 2629
			// (get) Token: 0x06001D66 RID: 7526 RVA: 0x00052F44 File Offset: 0x00051144
			// (set) Token: 0x06001D67 RID: 7527 RVA: 0x00052F5A File Offset: 0x0005115A
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

			// Token: 0x17000A46 RID: 2630
			// (get) Token: 0x06001D68 RID: 7528 RVA: 0x00052F71 File Offset: 0x00051171
			// (set) Token: 0x06001D69 RID: 7529 RVA: 0x00052F87 File Offset: 0x00051187
			[Register("common_google_play_services_unsupported_text")]
			public static int CommonGooglePlayServicesUnsupportedText
			{
				get
				{
					return R.String._members.StaticFields.GetInt32Value("common_google_play_services_unsupported_text.I");
				}
				set
				{
					R.String._members.StaticFields.SetValue("common_google_play_services_unsupported_text.I", value);
				}
			}

			// Token: 0x17000A47 RID: 2631
			// (get) Token: 0x06001D6A RID: 7530 RVA: 0x00052F9E File Offset: 0x0005119E
			// (set) Token: 0x06001D6B RID: 7531 RVA: 0x00052FB4 File Offset: 0x000511B4
			[Register("common_google_play_services_update_button")]
			public static int CommonGooglePlayServicesUpdateButton
			{
				get
				{
					return R.String._members.StaticFields.GetInt32Value("common_google_play_services_update_button.I");
				}
				set
				{
					R.String._members.StaticFields.SetValue("common_google_play_services_update_button.I", value);
				}
			}

			// Token: 0x17000A48 RID: 2632
			// (get) Token: 0x06001D6C RID: 7532 RVA: 0x00052FCB File Offset: 0x000511CB
			// (set) Token: 0x06001D6D RID: 7533 RVA: 0x00052FE1 File Offset: 0x000511E1
			[Register("common_google_play_services_update_text")]
			public static int CommonGooglePlayServicesUpdateText
			{
				get
				{
					return R.String._members.StaticFields.GetInt32Value("common_google_play_services_update_text.I");
				}
				set
				{
					R.String._members.StaticFields.SetValue("common_google_play_services_update_text.I", value);
				}
			}

			// Token: 0x17000A49 RID: 2633
			// (get) Token: 0x06001D6E RID: 7534 RVA: 0x00052FF8 File Offset: 0x000511F8
			// (set) Token: 0x06001D6F RID: 7535 RVA: 0x0005300E File Offset: 0x0005120E
			[Register("common_google_play_services_update_title")]
			public static int CommonGooglePlayServicesUpdateTitle
			{
				get
				{
					return R.String._members.StaticFields.GetInt32Value("common_google_play_services_update_title.I");
				}
				set
				{
					R.String._members.StaticFields.SetValue("common_google_play_services_update_title.I", value);
				}
			}

			// Token: 0x17000A4A RID: 2634
			// (get) Token: 0x06001D70 RID: 7536 RVA: 0x00053025 File Offset: 0x00051225
			// (set) Token: 0x06001D71 RID: 7537 RVA: 0x0005303B File Offset: 0x0005123B
			[Register("common_google_play_services_updating_text")]
			public static int CommonGooglePlayServicesUpdatingText
			{
				get
				{
					return R.String._members.StaticFields.GetInt32Value("common_google_play_services_updating_text.I");
				}
				set
				{
					R.String._members.StaticFields.SetValue("common_google_play_services_updating_text.I", value);
				}
			}

			// Token: 0x17000A4B RID: 2635
			// (get) Token: 0x06001D72 RID: 7538 RVA: 0x00053052 File Offset: 0x00051252
			// (set) Token: 0x06001D73 RID: 7539 RVA: 0x00053068 File Offset: 0x00051268
			[Register("common_google_play_services_wear_update_text")]
			public static int CommonGooglePlayServicesWearUpdateText
			{
				get
				{
					return R.String._members.StaticFields.GetInt32Value("common_google_play_services_wear_update_text.I");
				}
				set
				{
					R.String._members.StaticFields.SetValue("common_google_play_services_wear_update_text.I", value);
				}
			}

			// Token: 0x17000A4C RID: 2636
			// (get) Token: 0x06001D74 RID: 7540 RVA: 0x0005307F File Offset: 0x0005127F
			// (set) Token: 0x06001D75 RID: 7541 RVA: 0x00053095 File Offset: 0x00051295
			[Register("common_open_on_phone")]
			public static int CommonOpenOnPhone
			{
				get
				{
					return R.String._members.StaticFields.GetInt32Value("common_open_on_phone.I");
				}
				set
				{
					R.String._members.StaticFields.SetValue("common_open_on_phone.I", value);
				}
			}

			// Token: 0x17000A4D RID: 2637
			// (get) Token: 0x06001D76 RID: 7542 RVA: 0x000530AC File Offset: 0x000512AC
			// (set) Token: 0x06001D77 RID: 7543 RVA: 0x000530C2 File Offset: 0x000512C2
			[Register("common_signin_button_text")]
			public static int CommonSigninButtonText
			{
				get
				{
					return R.String._members.StaticFields.GetInt32Value("common_signin_button_text.I");
				}
				set
				{
					R.String._members.StaticFields.SetValue("common_signin_button_text.I", value);
				}
			}

			// Token: 0x17000A4E RID: 2638
			// (get) Token: 0x06001D78 RID: 7544 RVA: 0x000530D9 File Offset: 0x000512D9
			// (set) Token: 0x06001D79 RID: 7545 RVA: 0x000530EF File Offset: 0x000512EF
			[Register("common_signin_button_text_long")]
			public static int CommonSigninButtonTextLong
			{
				get
				{
					return R.String._members.StaticFields.GetInt32Value("common_signin_button_text_long.I");
				}
				set
				{
					R.String._members.StaticFields.SetValue("common_signin_button_text_long.I", value);
				}
			}

			// Token: 0x17000A4F RID: 2639
			// (get) Token: 0x06001D7A RID: 7546 RVA: 0x00053106 File Offset: 0x00051306
			// (set) Token: 0x06001D7B RID: 7547 RVA: 0x0005311C File Offset: 0x0005131C
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

			// Token: 0x17000A50 RID: 2640
			// (get) Token: 0x06001D7C RID: 7548 RVA: 0x00053133 File Offset: 0x00051333
			// (set) Token: 0x06001D7D RID: 7549 RVA: 0x00053149 File Offset: 0x00051349
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

			// Token: 0x17000A51 RID: 2641
			// (get) Token: 0x06001D7E RID: 7550 RVA: 0x00053160 File Offset: 0x00051360
			// (set) Token: 0x06001D7F RID: 7551 RVA: 0x00053176 File Offset: 0x00051376
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

			// Token: 0x17000A52 RID: 2642
			// (get) Token: 0x06001D80 RID: 7552 RVA: 0x0005318D File Offset: 0x0005138D
			// (set) Token: 0x06001D81 RID: 7553 RVA: 0x000531A3 File Offset: 0x000513A3
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

			// Token: 0x17000A53 RID: 2643
			// (get) Token: 0x06001D82 RID: 7554 RVA: 0x000531BA File Offset: 0x000513BA
			// (set) Token: 0x06001D83 RID: 7555 RVA: 0x000531D0 File Offset: 0x000513D0
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

			// Token: 0x17000A54 RID: 2644
			// (get) Token: 0x06001D84 RID: 7556 RVA: 0x000531E7 File Offset: 0x000513E7
			// (set) Token: 0x06001D85 RID: 7557 RVA: 0x000531FD File Offset: 0x000513FD
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

			// Token: 0x17000A55 RID: 2645
			// (get) Token: 0x06001D86 RID: 7558 RVA: 0x00053214 File Offset: 0x00051414
			// (set) Token: 0x06001D87 RID: 7559 RVA: 0x0005322A File Offset: 0x0005142A
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

			// Token: 0x17000A56 RID: 2646
			// (get) Token: 0x06001D88 RID: 7560 RVA: 0x00053241 File Offset: 0x00051441
			// (set) Token: 0x06001D89 RID: 7561 RVA: 0x00053257 File Offset: 0x00051457
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

			// Token: 0x17000A57 RID: 2647
			// (get) Token: 0x06001D8A RID: 7562 RVA: 0x0005326E File Offset: 0x0005146E
			// (set) Token: 0x06001D8B RID: 7563 RVA: 0x00053284 File Offset: 0x00051484
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

			// Token: 0x17000A58 RID: 2648
			// (get) Token: 0x06001D8C RID: 7564 RVA: 0x0005329B File Offset: 0x0005149B
			// (set) Token: 0x06001D8D RID: 7565 RVA: 0x000532B1 File Offset: 0x000514B1
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

			// Token: 0x17000A59 RID: 2649
			// (get) Token: 0x06001D8E RID: 7566 RVA: 0x000532C8 File Offset: 0x000514C8
			// (set) Token: 0x06001D8F RID: 7567 RVA: 0x000532DE File Offset: 0x000514DE
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

			// Token: 0x17000A5A RID: 2650
			// (get) Token: 0x06001D90 RID: 7568 RVA: 0x000532F5 File Offset: 0x000514F5
			// (set) Token: 0x06001D91 RID: 7569 RVA: 0x0005330B File Offset: 0x0005150B
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

			// Token: 0x17000A5B RID: 2651
			// (get) Token: 0x06001D92 RID: 7570 RVA: 0x00053322 File Offset: 0x00051522
			// (set) Token: 0x06001D93 RID: 7571 RVA: 0x00053338 File Offset: 0x00051538
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

			// Token: 0x17000A5C RID: 2652
			// (get) Token: 0x06001D94 RID: 7572 RVA: 0x0005334F File Offset: 0x0005154F
			// (set) Token: 0x06001D95 RID: 7573 RVA: 0x00053365 File Offset: 0x00051565
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

			// Token: 0x17000A5D RID: 2653
			// (get) Token: 0x06001D96 RID: 7574 RVA: 0x0005337C File Offset: 0x0005157C
			// (set) Token: 0x06001D97 RID: 7575 RVA: 0x00053392 File Offset: 0x00051592
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

			// Token: 0x17000A5E RID: 2654
			// (get) Token: 0x06001D98 RID: 7576 RVA: 0x000533AC File Offset: 0x000515AC
			internal static IntPtr class_ref
			{
				get
				{
					return R.String._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x17000A5F RID: 2655
			// (get) Token: 0x06001D99 RID: 7577 RVA: 0x000533D0 File Offset: 0x000515D0
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return R.String._members;
				}
			}

			// Token: 0x17000A60 RID: 2656
			// (get) Token: 0x06001D9A RID: 7578 RVA: 0x000533D8 File Offset: 0x000515D8
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return R.String._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x17000A61 RID: 2657
			// (get) Token: 0x06001D9B RID: 7579 RVA: 0x000533FC File Offset: 0x000515FC
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return R.String._members.ManagedPeerType;
				}
			}

			// Token: 0x06001D9C RID: 7580 RVA: 0x000021E8 File Offset: 0x000003E8
			internal String(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
			{
			}

			// Token: 0x040006CD RID: 1741
			private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/scar/adapter/v2100/R$string", typeof(R.String));
		}

		// Token: 0x02000242 RID: 578
		[Register("com/unity3d/scar/adapter/v2100/R$style", DoNotGenerateAcw = true)]
		public sealed class Style : Java.Lang.Object
		{
			// Token: 0x17000A62 RID: 2658
			// (get) Token: 0x06001D9E RID: 7582 RVA: 0x00053423 File Offset: 0x00051623
			// (set) Token: 0x06001D9F RID: 7583 RVA: 0x00053439 File Offset: 0x00051639
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

			// Token: 0x17000A63 RID: 2659
			// (get) Token: 0x06001DA0 RID: 7584 RVA: 0x00053450 File Offset: 0x00051650
			// (set) Token: 0x06001DA1 RID: 7585 RVA: 0x00053466 File Offset: 0x00051666
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

			// Token: 0x17000A64 RID: 2660
			// (get) Token: 0x06001DA2 RID: 7586 RVA: 0x0005347D File Offset: 0x0005167D
			// (set) Token: 0x06001DA3 RID: 7587 RVA: 0x00053493 File Offset: 0x00051693
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

			// Token: 0x17000A65 RID: 2661
			// (get) Token: 0x06001DA4 RID: 7588 RVA: 0x000534AA File Offset: 0x000516AA
			// (set) Token: 0x06001DA5 RID: 7589 RVA: 0x000534C0 File Offset: 0x000516C0
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

			// Token: 0x17000A66 RID: 2662
			// (get) Token: 0x06001DA6 RID: 7590 RVA: 0x000534D7 File Offset: 0x000516D7
			// (set) Token: 0x06001DA7 RID: 7591 RVA: 0x000534ED File Offset: 0x000516ED
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

			// Token: 0x17000A67 RID: 2663
			// (get) Token: 0x06001DA8 RID: 7592 RVA: 0x00053504 File Offset: 0x00051704
			// (set) Token: 0x06001DA9 RID: 7593 RVA: 0x0005351A File Offset: 0x0005171A
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

			// Token: 0x17000A68 RID: 2664
			// (get) Token: 0x06001DAA RID: 7594 RVA: 0x00053531 File Offset: 0x00051731
			// (set) Token: 0x06001DAB RID: 7595 RVA: 0x00053547 File Offset: 0x00051747
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

			// Token: 0x17000A69 RID: 2665
			// (get) Token: 0x06001DAC RID: 7596 RVA: 0x0005355E File Offset: 0x0005175E
			// (set) Token: 0x06001DAD RID: 7597 RVA: 0x00053574 File Offset: 0x00051774
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

			// Token: 0x17000A6A RID: 2666
			// (get) Token: 0x06001DAE RID: 7598 RVA: 0x0005358B File Offset: 0x0005178B
			// (set) Token: 0x06001DAF RID: 7599 RVA: 0x000535A1 File Offset: 0x000517A1
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

			// Token: 0x17000A6B RID: 2667
			// (get) Token: 0x06001DB0 RID: 7600 RVA: 0x000535B8 File Offset: 0x000517B8
			internal static IntPtr class_ref
			{
				get
				{
					return R.Style._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x17000A6C RID: 2668
			// (get) Token: 0x06001DB1 RID: 7601 RVA: 0x000535DC File Offset: 0x000517DC
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return R.Style._members;
				}
			}

			// Token: 0x17000A6D RID: 2669
			// (get) Token: 0x06001DB2 RID: 7602 RVA: 0x000535E4 File Offset: 0x000517E4
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return R.Style._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x17000A6E RID: 2670
			// (get) Token: 0x06001DB3 RID: 7603 RVA: 0x00053608 File Offset: 0x00051808
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return R.Style._members.ManagedPeerType;
				}
			}

			// Token: 0x06001DB4 RID: 7604 RVA: 0x000021E8 File Offset: 0x000003E8
			internal Style(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
			{
			}

			// Token: 0x040006CE RID: 1742
			private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/scar/adapter/v2100/R$style", typeof(R.Style));
		}

		// Token: 0x02000243 RID: 579
		[Register("com/unity3d/scar/adapter/v2100/R$styleable", DoNotGenerateAcw = true)]
		public sealed class Styleable : Java.Lang.Object
		{
			// Token: 0x17000A6F RID: 2671
			// (get) Token: 0x06001DB6 RID: 7606 RVA: 0x00053630 File Offset: 0x00051830
			// (set) Token: 0x06001DB7 RID: 7607 RVA: 0x00053660 File Offset: 0x00051860
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

			// Token: 0x17000A70 RID: 2672
			// (get) Token: 0x06001DB8 RID: 7608 RVA: 0x000536A8 File Offset: 0x000518A8
			// (set) Token: 0x06001DB9 RID: 7609 RVA: 0x000536BE File Offset: 0x000518BE
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

			// Token: 0x17000A71 RID: 2673
			// (get) Token: 0x06001DBA RID: 7610 RVA: 0x000536D5 File Offset: 0x000518D5
			// (set) Token: 0x06001DBB RID: 7611 RVA: 0x000536EB File Offset: 0x000518EB
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

			// Token: 0x17000A72 RID: 2674
			// (get) Token: 0x06001DBC RID: 7612 RVA: 0x00053702 File Offset: 0x00051902
			// (set) Token: 0x06001DBD RID: 7613 RVA: 0x00053718 File Offset: 0x00051918
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

			// Token: 0x17000A73 RID: 2675
			// (get) Token: 0x06001DBE RID: 7614 RVA: 0x00053730 File Offset: 0x00051930
			// (set) Token: 0x06001DBF RID: 7615 RVA: 0x00053760 File Offset: 0x00051960
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

			// Token: 0x17000A74 RID: 2676
			// (get) Token: 0x06001DC0 RID: 7616 RVA: 0x000537A8 File Offset: 0x000519A8
			// (set) Token: 0x06001DC1 RID: 7617 RVA: 0x000537BE File Offset: 0x000519BE
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

			// Token: 0x17000A75 RID: 2677
			// (get) Token: 0x06001DC2 RID: 7618 RVA: 0x000537D5 File Offset: 0x000519D5
			// (set) Token: 0x06001DC3 RID: 7619 RVA: 0x000537EB File Offset: 0x000519EB
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

			// Token: 0x17000A76 RID: 2678
			// (get) Token: 0x06001DC4 RID: 7620 RVA: 0x00053802 File Offset: 0x00051A02
			// (set) Token: 0x06001DC5 RID: 7621 RVA: 0x00053818 File Offset: 0x00051A18
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

			// Token: 0x17000A77 RID: 2679
			// (get) Token: 0x06001DC6 RID: 7622 RVA: 0x00053830 File Offset: 0x00051A30
			// (set) Token: 0x06001DC7 RID: 7623 RVA: 0x00053860 File Offset: 0x00051A60
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

			// Token: 0x17000A78 RID: 2680
			// (get) Token: 0x06001DC8 RID: 7624 RVA: 0x000538A8 File Offset: 0x00051AA8
			// (set) Token: 0x06001DC9 RID: 7625 RVA: 0x000538BE File Offset: 0x00051ABE
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

			// Token: 0x17000A79 RID: 2681
			// (get) Token: 0x06001DCA RID: 7626 RVA: 0x000538D8 File Offset: 0x00051AD8
			// (set) Token: 0x06001DCB RID: 7627 RVA: 0x00053908 File Offset: 0x00051B08
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

			// Token: 0x17000A7A RID: 2682
			// (get) Token: 0x06001DCC RID: 7628 RVA: 0x00053950 File Offset: 0x00051B50
			// (set) Token: 0x06001DCD RID: 7629 RVA: 0x00053966 File Offset: 0x00051B66
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

			// Token: 0x17000A7B RID: 2683
			// (get) Token: 0x06001DCE RID: 7630 RVA: 0x0005397D File Offset: 0x00051B7D
			// (set) Token: 0x06001DCF RID: 7631 RVA: 0x00053993 File Offset: 0x00051B93
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

			// Token: 0x17000A7C RID: 2684
			// (get) Token: 0x06001DD0 RID: 7632 RVA: 0x000539AA File Offset: 0x00051BAA
			// (set) Token: 0x06001DD1 RID: 7633 RVA: 0x000539C0 File Offset: 0x00051BC0
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

			// Token: 0x17000A7D RID: 2685
			// (get) Token: 0x06001DD2 RID: 7634 RVA: 0x000539D7 File Offset: 0x00051BD7
			// (set) Token: 0x06001DD3 RID: 7635 RVA: 0x000539ED File Offset: 0x00051BED
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

			// Token: 0x17000A7E RID: 2686
			// (get) Token: 0x06001DD4 RID: 7636 RVA: 0x00053A04 File Offset: 0x00051C04
			// (set) Token: 0x06001DD5 RID: 7637 RVA: 0x00053A1A File Offset: 0x00051C1A
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

			// Token: 0x17000A7F RID: 2687
			// (get) Token: 0x06001DD6 RID: 7638 RVA: 0x00053A31 File Offset: 0x00051C31
			// (set) Token: 0x06001DD7 RID: 7639 RVA: 0x00053A47 File Offset: 0x00051C47
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

			// Token: 0x17000A80 RID: 2688
			// (get) Token: 0x06001DD8 RID: 7640 RVA: 0x00053A5E File Offset: 0x00051C5E
			// (set) Token: 0x06001DD9 RID: 7641 RVA: 0x00053A74 File Offset: 0x00051C74
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

			// Token: 0x17000A81 RID: 2689
			// (get) Token: 0x06001DDA RID: 7642 RVA: 0x00053A8B File Offset: 0x00051C8B
			// (set) Token: 0x06001DDB RID: 7643 RVA: 0x00053AA1 File Offset: 0x00051CA1
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

			// Token: 0x17000A82 RID: 2690
			// (get) Token: 0x06001DDC RID: 7644 RVA: 0x00053AB8 File Offset: 0x00051CB8
			// (set) Token: 0x06001DDD RID: 7645 RVA: 0x00053AE8 File Offset: 0x00051CE8
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

			// Token: 0x17000A83 RID: 2691
			// (get) Token: 0x06001DDE RID: 7646 RVA: 0x00053B30 File Offset: 0x00051D30
			// (set) Token: 0x06001DDF RID: 7647 RVA: 0x00053B60 File Offset: 0x00051D60
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

			// Token: 0x17000A84 RID: 2692
			// (get) Token: 0x06001DE0 RID: 7648 RVA: 0x00053BA8 File Offset: 0x00051DA8
			// (set) Token: 0x06001DE1 RID: 7649 RVA: 0x00053BBE File Offset: 0x00051DBE
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

			// Token: 0x17000A85 RID: 2693
			// (get) Token: 0x06001DE2 RID: 7650 RVA: 0x00053BD5 File Offset: 0x00051DD5
			// (set) Token: 0x06001DE3 RID: 7651 RVA: 0x00053BEB File Offset: 0x00051DEB
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

			// Token: 0x17000A86 RID: 2694
			// (get) Token: 0x06001DE4 RID: 7652 RVA: 0x00053C02 File Offset: 0x00051E02
			// (set) Token: 0x06001DE5 RID: 7653 RVA: 0x00053C18 File Offset: 0x00051E18
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

			// Token: 0x17000A87 RID: 2695
			// (get) Token: 0x06001DE6 RID: 7654 RVA: 0x00053C2F File Offset: 0x00051E2F
			// (set) Token: 0x06001DE7 RID: 7655 RVA: 0x00053C45 File Offset: 0x00051E45
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

			// Token: 0x17000A88 RID: 2696
			// (get) Token: 0x06001DE8 RID: 7656 RVA: 0x00053C5C File Offset: 0x00051E5C
			// (set) Token: 0x06001DE9 RID: 7657 RVA: 0x00053C72 File Offset: 0x00051E72
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

			// Token: 0x17000A89 RID: 2697
			// (get) Token: 0x06001DEA RID: 7658 RVA: 0x00053C89 File Offset: 0x00051E89
			// (set) Token: 0x06001DEB RID: 7659 RVA: 0x00053C9F File Offset: 0x00051E9F
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

			// Token: 0x17000A8A RID: 2698
			// (get) Token: 0x06001DEC RID: 7660 RVA: 0x00053CB6 File Offset: 0x00051EB6
			// (set) Token: 0x06001DED RID: 7661 RVA: 0x00053CCC File Offset: 0x00051ECC
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

			// Token: 0x17000A8B RID: 2699
			// (get) Token: 0x06001DEE RID: 7662 RVA: 0x00053CE3 File Offset: 0x00051EE3
			// (set) Token: 0x06001DEF RID: 7663 RVA: 0x00053CF9 File Offset: 0x00051EF9
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

			// Token: 0x17000A8C RID: 2700
			// (get) Token: 0x06001DF0 RID: 7664 RVA: 0x00053D10 File Offset: 0x00051F10
			// (set) Token: 0x06001DF1 RID: 7665 RVA: 0x00053D26 File Offset: 0x00051F26
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

			// Token: 0x17000A8D RID: 2701
			// (get) Token: 0x06001DF2 RID: 7666 RVA: 0x00053D3D File Offset: 0x00051F3D
			// (set) Token: 0x06001DF3 RID: 7667 RVA: 0x00053D53 File Offset: 0x00051F53
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

			// Token: 0x17000A8E RID: 2702
			// (get) Token: 0x06001DF4 RID: 7668 RVA: 0x00053D6A File Offset: 0x00051F6A
			// (set) Token: 0x06001DF5 RID: 7669 RVA: 0x00053D80 File Offset: 0x00051F80
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

			// Token: 0x17000A8F RID: 2703
			// (get) Token: 0x06001DF6 RID: 7670 RVA: 0x00053D97 File Offset: 0x00051F97
			// (set) Token: 0x06001DF7 RID: 7671 RVA: 0x00053DAD File Offset: 0x00051FAD
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

			// Token: 0x17000A90 RID: 2704
			// (get) Token: 0x06001DF8 RID: 7672 RVA: 0x00053DC4 File Offset: 0x00051FC4
			// (set) Token: 0x06001DF9 RID: 7673 RVA: 0x00053DDA File Offset: 0x00051FDA
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

			// Token: 0x17000A91 RID: 2705
			// (get) Token: 0x06001DFA RID: 7674 RVA: 0x00053DF1 File Offset: 0x00051FF1
			// (set) Token: 0x06001DFB RID: 7675 RVA: 0x00053E07 File Offset: 0x00052007
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

			// Token: 0x17000A92 RID: 2706
			// (get) Token: 0x06001DFC RID: 7676 RVA: 0x00053E1E File Offset: 0x0005201E
			// (set) Token: 0x06001DFD RID: 7677 RVA: 0x00053E34 File Offset: 0x00052034
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

			// Token: 0x17000A93 RID: 2707
			// (get) Token: 0x06001DFE RID: 7678 RVA: 0x00053E4B File Offset: 0x0005204B
			// (set) Token: 0x06001DFF RID: 7679 RVA: 0x00053E61 File Offset: 0x00052061
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

			// Token: 0x17000A94 RID: 2708
			// (get) Token: 0x06001E00 RID: 7680 RVA: 0x00053E78 File Offset: 0x00052078
			// (set) Token: 0x06001E01 RID: 7681 RVA: 0x00053EA8 File Offset: 0x000520A8
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

			// Token: 0x17000A95 RID: 2709
			// (get) Token: 0x06001E02 RID: 7682 RVA: 0x00053EF0 File Offset: 0x000520F0
			// (set) Token: 0x06001E03 RID: 7683 RVA: 0x00053F20 File Offset: 0x00052120
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

			// Token: 0x17000A96 RID: 2710
			// (get) Token: 0x06001E04 RID: 7684 RVA: 0x00053F68 File Offset: 0x00052168
			// (set) Token: 0x06001E05 RID: 7685 RVA: 0x00053F7E File Offset: 0x0005217E
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

			// Token: 0x17000A97 RID: 2711
			// (get) Token: 0x06001E06 RID: 7686 RVA: 0x00053F95 File Offset: 0x00052195
			// (set) Token: 0x06001E07 RID: 7687 RVA: 0x00053FAB File Offset: 0x000521AB
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

			// Token: 0x17000A98 RID: 2712
			// (get) Token: 0x06001E08 RID: 7688 RVA: 0x00053FC2 File Offset: 0x000521C2
			// (set) Token: 0x06001E09 RID: 7689 RVA: 0x00053FD8 File Offset: 0x000521D8
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

			// Token: 0x17000A99 RID: 2713
			// (get) Token: 0x06001E0A RID: 7690 RVA: 0x00053FEF File Offset: 0x000521EF
			// (set) Token: 0x06001E0B RID: 7691 RVA: 0x00054005 File Offset: 0x00052205
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

			// Token: 0x17000A9A RID: 2714
			// (get) Token: 0x06001E0C RID: 7692 RVA: 0x0005401C File Offset: 0x0005221C
			// (set) Token: 0x06001E0D RID: 7693 RVA: 0x00054032 File Offset: 0x00052232
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

			// Token: 0x17000A9B RID: 2715
			// (get) Token: 0x06001E0E RID: 7694 RVA: 0x00054049 File Offset: 0x00052249
			// (set) Token: 0x06001E0F RID: 7695 RVA: 0x0005405F File Offset: 0x0005225F
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

			// Token: 0x17000A9C RID: 2716
			// (get) Token: 0x06001E10 RID: 7696 RVA: 0x00054076 File Offset: 0x00052276
			// (set) Token: 0x06001E11 RID: 7697 RVA: 0x0005408C File Offset: 0x0005228C
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

			// Token: 0x17000A9D RID: 2717
			// (get) Token: 0x06001E12 RID: 7698 RVA: 0x000540A3 File Offset: 0x000522A3
			// (set) Token: 0x06001E13 RID: 7699 RVA: 0x000540B9 File Offset: 0x000522B9
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

			// Token: 0x17000A9E RID: 2718
			// (get) Token: 0x06001E14 RID: 7700 RVA: 0x000540D0 File Offset: 0x000522D0
			// (set) Token: 0x06001E15 RID: 7701 RVA: 0x000540E6 File Offset: 0x000522E6
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

			// Token: 0x17000A9F RID: 2719
			// (get) Token: 0x06001E16 RID: 7702 RVA: 0x000540FD File Offset: 0x000522FD
			// (set) Token: 0x06001E17 RID: 7703 RVA: 0x00054113 File Offset: 0x00052313
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

			// Token: 0x17000AA0 RID: 2720
			// (get) Token: 0x06001E18 RID: 7704 RVA: 0x0005412A File Offset: 0x0005232A
			// (set) Token: 0x06001E19 RID: 7705 RVA: 0x00054140 File Offset: 0x00052340
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

			// Token: 0x17000AA1 RID: 2721
			// (get) Token: 0x06001E1A RID: 7706 RVA: 0x00054157 File Offset: 0x00052357
			// (set) Token: 0x06001E1B RID: 7707 RVA: 0x0005416D File Offset: 0x0005236D
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

			// Token: 0x17000AA2 RID: 2722
			// (get) Token: 0x06001E1C RID: 7708 RVA: 0x00054184 File Offset: 0x00052384
			// (set) Token: 0x06001E1D RID: 7709 RVA: 0x0005419A File Offset: 0x0005239A
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

			// Token: 0x17000AA3 RID: 2723
			// (get) Token: 0x06001E1E RID: 7710 RVA: 0x000541B1 File Offset: 0x000523B1
			// (set) Token: 0x06001E1F RID: 7711 RVA: 0x000541C7 File Offset: 0x000523C7
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

			// Token: 0x17000AA4 RID: 2724
			// (get) Token: 0x06001E20 RID: 7712 RVA: 0x000541E0 File Offset: 0x000523E0
			// (set) Token: 0x06001E21 RID: 7713 RVA: 0x00054210 File Offset: 0x00052410
			[Register("LoadingImageView")]
			public static IList<int> LoadingImageView
			{
				get
				{
					return Android.Runtime.JavaArray<int>.FromJniHandle(R.Styleable._members.StaticFields.GetObjectValue("LoadingImageView.[I").Handle, JniHandleOwnership.TransferLocalRef);
				}
				set
				{
					IntPtr intPtr = Android.Runtime.JavaArray<int>.ToLocalJniHandle(value);
					try
					{
						R.Styleable._members.StaticFields.SetValue("LoadingImageView.[I", new JniObjectReference(intPtr, JniObjectReferenceType.Invalid));
					}
					finally
					{
						JNIEnv.DeleteLocalRef(intPtr);
					}
				}
			}

			// Token: 0x17000AA5 RID: 2725
			// (get) Token: 0x06001E22 RID: 7714 RVA: 0x00054258 File Offset: 0x00052458
			// (set) Token: 0x06001E23 RID: 7715 RVA: 0x0005426E File Offset: 0x0005246E
			[Register("LoadingImageView_circleCrop")]
			public static int LoadingImageViewCircleCrop
			{
				get
				{
					return R.Styleable._members.StaticFields.GetInt32Value("LoadingImageView_circleCrop.I");
				}
				set
				{
					R.Styleable._members.StaticFields.SetValue("LoadingImageView_circleCrop.I", value);
				}
			}

			// Token: 0x17000AA6 RID: 2726
			// (get) Token: 0x06001E24 RID: 7716 RVA: 0x00054285 File Offset: 0x00052485
			// (set) Token: 0x06001E25 RID: 7717 RVA: 0x0005429B File Offset: 0x0005249B
			[Register("LoadingImageView_imageAspectRatio")]
			public static int LoadingImageViewImageAspectRatio
			{
				get
				{
					return R.Styleable._members.StaticFields.GetInt32Value("LoadingImageView_imageAspectRatio.I");
				}
				set
				{
					R.Styleable._members.StaticFields.SetValue("LoadingImageView_imageAspectRatio.I", value);
				}
			}

			// Token: 0x17000AA7 RID: 2727
			// (get) Token: 0x06001E26 RID: 7718 RVA: 0x000542B2 File Offset: 0x000524B2
			// (set) Token: 0x06001E27 RID: 7719 RVA: 0x000542C8 File Offset: 0x000524C8
			[Register("LoadingImageView_imageAspectRatioAdjust")]
			public static int LoadingImageViewImageAspectRatioAdjust
			{
				get
				{
					return R.Styleable._members.StaticFields.GetInt32Value("LoadingImageView_imageAspectRatioAdjust.I");
				}
				set
				{
					R.Styleable._members.StaticFields.SetValue("LoadingImageView_imageAspectRatioAdjust.I", value);
				}
			}

			// Token: 0x17000AA8 RID: 2728
			// (get) Token: 0x06001E28 RID: 7720 RVA: 0x000542E0 File Offset: 0x000524E0
			// (set) Token: 0x06001E29 RID: 7721 RVA: 0x00054310 File Offset: 0x00052510
			[Register("SignInButton")]
			public static IList<int> SignInButton
			{
				get
				{
					return Android.Runtime.JavaArray<int>.FromJniHandle(R.Styleable._members.StaticFields.GetObjectValue("SignInButton.[I").Handle, JniHandleOwnership.TransferLocalRef);
				}
				set
				{
					IntPtr intPtr = Android.Runtime.JavaArray<int>.ToLocalJniHandle(value);
					try
					{
						R.Styleable._members.StaticFields.SetValue("SignInButton.[I", new JniObjectReference(intPtr, JniObjectReferenceType.Invalid));
					}
					finally
					{
						JNIEnv.DeleteLocalRef(intPtr);
					}
				}
			}

			// Token: 0x17000AA9 RID: 2729
			// (get) Token: 0x06001E2A RID: 7722 RVA: 0x00054358 File Offset: 0x00052558
			// (set) Token: 0x06001E2B RID: 7723 RVA: 0x0005436E File Offset: 0x0005256E
			[Register("SignInButton_buttonSize")]
			public static int SignInButtonButtonSize
			{
				get
				{
					return R.Styleable._members.StaticFields.GetInt32Value("SignInButton_buttonSize.I");
				}
				set
				{
					R.Styleable._members.StaticFields.SetValue("SignInButton_buttonSize.I", value);
				}
			}

			// Token: 0x17000AAA RID: 2730
			// (get) Token: 0x06001E2C RID: 7724 RVA: 0x00054385 File Offset: 0x00052585
			// (set) Token: 0x06001E2D RID: 7725 RVA: 0x0005439B File Offset: 0x0005259B
			[Register("SignInButton_colorScheme")]
			public static int SignInButtonColorScheme
			{
				get
				{
					return R.Styleable._members.StaticFields.GetInt32Value("SignInButton_colorScheme.I");
				}
				set
				{
					R.Styleable._members.StaticFields.SetValue("SignInButton_colorScheme.I", value);
				}
			}

			// Token: 0x17000AAB RID: 2731
			// (get) Token: 0x06001E2E RID: 7726 RVA: 0x000543B2 File Offset: 0x000525B2
			// (set) Token: 0x06001E2F RID: 7727 RVA: 0x000543C8 File Offset: 0x000525C8
			[Register("SignInButton_scopeUris")]
			public static int SignInButtonScopeUris
			{
				get
				{
					return R.Styleable._members.StaticFields.GetInt32Value("SignInButton_scopeUris.I");
				}
				set
				{
					R.Styleable._members.StaticFields.SetValue("SignInButton_scopeUris.I", value);
				}
			}

			// Token: 0x17000AAC RID: 2732
			// (get) Token: 0x06001E30 RID: 7728 RVA: 0x000543E0 File Offset: 0x000525E0
			internal static IntPtr class_ref
			{
				get
				{
					return R.Styleable._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x17000AAD RID: 2733
			// (get) Token: 0x06001E31 RID: 7729 RVA: 0x00054404 File Offset: 0x00052604
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return R.Styleable._members;
				}
			}

			// Token: 0x17000AAE RID: 2734
			// (get) Token: 0x06001E32 RID: 7730 RVA: 0x0005440C File Offset: 0x0005260C
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return R.Styleable._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x17000AAF RID: 2735
			// (get) Token: 0x06001E33 RID: 7731 RVA: 0x00054430 File Offset: 0x00052630
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return R.Styleable._members.ManagedPeerType;
				}
			}

			// Token: 0x06001E34 RID: 7732 RVA: 0x000021E8 File Offset: 0x000003E8
			internal Styleable(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
			{
			}

			// Token: 0x040006CF RID: 1743
			private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/scar/adapter/v2100/R$styleable", typeof(R.Styleable));
		}
	}
}
