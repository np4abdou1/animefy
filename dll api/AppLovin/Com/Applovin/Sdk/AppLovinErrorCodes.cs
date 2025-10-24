using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Com.Applovin.Sdk
{
	// Token: 0x02000053 RID: 83
	[Register("com/applovin/sdk/AppLovinErrorCodes", DoNotGenerateAcw = true)]
	public class AppLovinErrorCodes : Java.Lang.Object
	{
		// Token: 0x170000C4 RID: 196
		// (get) Token: 0x06000288 RID: 648 RVA: 0x00006BF0 File Offset: 0x00004DF0
		internal static IntPtr class_ref
		{
			get
			{
				return AppLovinErrorCodes._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170000C5 RID: 197
		// (get) Token: 0x06000289 RID: 649 RVA: 0x00006C14 File Offset: 0x00004E14
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return AppLovinErrorCodes._members;
			}
		}

		// Token: 0x170000C6 RID: 198
		// (get) Token: 0x0600028A RID: 650 RVA: 0x00006C1C File Offset: 0x00004E1C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return AppLovinErrorCodes._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170000C7 RID: 199
		// (get) Token: 0x0600028B RID: 651 RVA: 0x00006C40 File Offset: 0x00004E40
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return AppLovinErrorCodes._members.ManagedPeerType;
			}
		}

		// Token: 0x0600028C RID: 652 RVA: 0x000021F0 File Offset: 0x000003F0
		protected AppLovinErrorCodes(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x0600028D RID: 653 RVA: 0x00006C4C File Offset: 0x00004E4C
		[Register(".ctor", "()V", "")]
		public AppLovinErrorCodes() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			base.SetHandle(AppLovinErrorCodes._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
			AppLovinErrorCodes._members.InstanceMethods.FinishCreateInstance("()V", this, null);
		}

		// Token: 0x04000064 RID: 100
		[Register("FETCH_AD_TIMEOUT")]
		public const int FetchAdTimeout = -1001;

		// Token: 0x04000065 RID: 101
		[Register("INCENTIVIZED_NO_AD_PRELOADED")]
		public const int IncentivizedNoAdPreloaded = -300;

		// Token: 0x04000066 RID: 102
		[Register("INCENTIVIZED_SERVER_TIMEOUT")]
		public const int IncentivizedServerTimeout = -500;

		// Token: 0x04000067 RID: 103
		[Register("INCENTIVIZED_UNKNOWN_SERVER_ERROR")]
		public const int IncentivizedUnknownServerError = -400;

		// Token: 0x04000068 RID: 104
		[Register("INCENTIVIZED_USER_CLOSED_VIDEO")]
		public const int IncentivizedUserClosedVideo = -600;

		// Token: 0x04000069 RID: 105
		[Register("INVALID_AD_TOKEN")]
		public const int InvalidAdToken = -8;

		// Token: 0x0400006A RID: 106
		[Register("INVALID_RESPONSE")]
		public const int InvalidResponse = -800;

		// Token: 0x0400006B RID: 107
		[Register("INVALID_URL")]
		public const int InvalidUrl = -900;

		// Token: 0x0400006C RID: 108
		[Register("INVALID_ZONE")]
		public const int InvalidZone = -7;

		// Token: 0x0400006D RID: 109
		[Register("NO_FILL")]
		public const int NoFill = 204;

		// Token: 0x0400006E RID: 110
		[Register("NO_NETWORK")]
		public const int NoNetwork = -1009;

		// Token: 0x0400006F RID: 111
		[Register("SDK_DISABLED")]
		public const int SdkDisabled = -22;

		// Token: 0x04000070 RID: 112
		[Register("UNABLE_TO_PRECACHE_IMAGE_RESOURCES")]
		public const int UnableToPrecacheImageResources = -201;

		// Token: 0x04000071 RID: 113
		[Register("UNABLE_TO_PRECACHE_RESOURCES")]
		public const int UnableToPrecacheResources = -200;

		// Token: 0x04000072 RID: 114
		[Register("UNABLE_TO_PRECACHE_VIDEO_RESOURCES")]
		public const int UnableToPrecacheVideoResources = -202;

		// Token: 0x04000073 RID: 115
		[Register("UNABLE_TO_RENDER_AD")]
		public const int UnableToRenderAd = -6;

		// Token: 0x04000074 RID: 116
		[Register("UNSPECIFIED_ERROR")]
		public const int UnspecifiedError = -1;

		// Token: 0x04000075 RID: 117
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/applovin/sdk/AppLovinErrorCodes", typeof(AppLovinErrorCodes));
	}
}
