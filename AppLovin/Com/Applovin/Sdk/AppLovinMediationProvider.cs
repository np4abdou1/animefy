using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Com.Applovin.Sdk
{
	// Token: 0x02000058 RID: 88
	[Register("com/applovin/sdk/AppLovinMediationProvider", DoNotGenerateAcw = true)]
	public sealed class AppLovinMediationProvider : Java.Lang.Object
	{
		// Token: 0x170000DC RID: 220
		// (get) Token: 0x060002C2 RID: 706 RVA: 0x000077E8 File Offset: 0x000059E8
		internal static IntPtr class_ref
		{
			get
			{
				return AppLovinMediationProvider._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170000DD RID: 221
		// (get) Token: 0x060002C3 RID: 707 RVA: 0x0000780C File Offset: 0x00005A0C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return AppLovinMediationProvider._members;
			}
		}

		// Token: 0x170000DE RID: 222
		// (get) Token: 0x060002C4 RID: 708 RVA: 0x00007814 File Offset: 0x00005A14
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return AppLovinMediationProvider._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170000DF RID: 223
		// (get) Token: 0x060002C5 RID: 709 RVA: 0x00007838 File Offset: 0x00005A38
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return AppLovinMediationProvider._members.ManagedPeerType;
			}
		}

		// Token: 0x060002C6 RID: 710 RVA: 0x000021F0 File Offset: 0x000003F0
		internal AppLovinMediationProvider(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x060002C7 RID: 711 RVA: 0x00007844 File Offset: 0x00005A44
		[Register(".ctor", "()V", "")]
		public AppLovinMediationProvider() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			base.SetHandle(AppLovinMediationProvider._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
			AppLovinMediationProvider._members.InstanceMethods.FinishCreateInstance("()V", this, null);
		}

		// Token: 0x040000A2 RID: 162
		[Register("ADMARVEL")]
		public const string Admarvel = "admarvel";

		// Token: 0x040000A3 RID: 163
		[Register("ADMOB")]
		public const string Admob = "admob";

		// Token: 0x040000A4 RID: 164
		[Register("AERSERV")]
		public const string Aerserv = "aerserv";

		// Token: 0x040000A5 RID: 165
		[Register("APPODEAL")]
		public const string Appodeal = "appodeal";

		// Token: 0x040000A6 RID: 166
		[Register("FUSEPOWERED")]
		public const string Fusepowered = "fusepowered";

		// Token: 0x040000A7 RID: 167
		[Register("FYBER")]
		public const string Fyber = "fyber";

		// Token: 0x040000A8 RID: 168
		[Register("HEYZAP")]
		public const string Heyzap = "heyzap";

		// Token: 0x040000A9 RID: 169
		[Register("HYPERMX")]
		public const string Hypermx = "hypermx";

		// Token: 0x040000AA RID: 170
		[Register("IRONSOURCE")]
		public const string Ironsource = "ironsource";

		// Token: 0x040000AB RID: 171
		[Register("MAX")]
		public const string Max = "max";

		// Token: 0x040000AC RID: 172
		[Register("MOPUB")]
		public const string Mopub = "mopub";

		// Token: 0x040000AD RID: 173
		[Register("TAPDAQ")]
		public const string Tapdaq = "tapdaq";

		// Token: 0x040000AE RID: 174
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/applovin/sdk/AppLovinMediationProvider", typeof(AppLovinMediationProvider));
	}
}
