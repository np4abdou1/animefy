using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Com.Applovin.Mediation
{
	// Token: 0x020000C9 RID: 201
	[Register("com/applovin/mediation/MaxErrorCodes", DoNotGenerateAcw = true)]
	public class MaxErrorCodes : Java.Lang.Object
	{
		// Token: 0x17000237 RID: 567
		// (get) Token: 0x06000707 RID: 1799 RVA: 0x00011F50 File Offset: 0x00010150
		internal static IntPtr class_ref
		{
			get
			{
				return MaxErrorCodes._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000238 RID: 568
		// (get) Token: 0x06000708 RID: 1800 RVA: 0x00011F74 File Offset: 0x00010174
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return MaxErrorCodes._members;
			}
		}

		// Token: 0x17000239 RID: 569
		// (get) Token: 0x06000709 RID: 1801 RVA: 0x00011F7C File Offset: 0x0001017C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return MaxErrorCodes._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700023A RID: 570
		// (get) Token: 0x0600070A RID: 1802 RVA: 0x00011FA0 File Offset: 0x000101A0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return MaxErrorCodes._members.ManagedPeerType;
			}
		}

		// Token: 0x0600070B RID: 1803 RVA: 0x000021F0 File Offset: 0x000003F0
		protected MaxErrorCodes(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x0600070C RID: 1804 RVA: 0x00011FAC File Offset: 0x000101AC
		[Register(".ctor", "()V", "")]
		public MaxErrorCodes() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			base.SetHandle(MaxErrorCodes._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
			MaxErrorCodes._members.InstanceMethods.FinishCreateInstance("()V", this, null);
		}

		// Token: 0x0400025F RID: 607
		[Register("DONT_KEEP_ACTIVITIES_ENABLED")]
		public const int DontKeepActivitiesEnabled = -5602;

		// Token: 0x04000260 RID: 608
		[Register("FULLSCREEN_AD_ALREADY_SHOWING")]
		public const int FullscreenAdAlreadyShowing = -23;

		// Token: 0x04000261 RID: 609
		[Register("INVALID_INTERNAL_STATE")]
		public const int InvalidInternalState = -5201;

		// Token: 0x04000262 RID: 610
		[Register("MEDIATION_ADAPTER_LOAD_FAILED")]
		public const int MediationAdapterLoadFailed = -5001;

		// Token: 0x04000263 RID: 611
		[Register("NO_ACTIVITY")]
		public const int NoActivity = -5601;

		// Token: 0x04000264 RID: 612
		[Register("NO_FILL")]
		public const int NoFill = 204;

		// Token: 0x04000265 RID: 613
		[Register("UNSPECIFIED_ERROR")]
		public const int UnspecifiedError = -1;

		// Token: 0x04000266 RID: 614
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/applovin/mediation/MaxErrorCodes", typeof(MaxErrorCodes));
	}
}
