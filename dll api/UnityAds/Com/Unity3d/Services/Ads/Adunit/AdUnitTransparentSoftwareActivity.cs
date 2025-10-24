using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;

namespace Com.Unity3d.Services.Ads.Adunit
{
	// Token: 0x02000230 RID: 560
	[Register("com/unity3d/services/ads/adunit/AdUnitTransparentSoftwareActivity", DoNotGenerateAcw = true)]
	public class AdUnitTransparentSoftwareActivity : AdUnitTransparentActivity
	{
		// Token: 0x17000923 RID: 2339
		// (get) Token: 0x06001ACF RID: 6863 RVA: 0x0004E648 File Offset: 0x0004C848
		internal new static IntPtr class_ref
		{
			get
			{
				return AdUnitTransparentSoftwareActivity._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000924 RID: 2340
		// (get) Token: 0x06001AD0 RID: 6864 RVA: 0x0004E66C File Offset: 0x0004C86C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return AdUnitTransparentSoftwareActivity._members;
			}
		}

		// Token: 0x17000925 RID: 2341
		// (get) Token: 0x06001AD1 RID: 6865 RVA: 0x0004E674 File Offset: 0x0004C874
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return AdUnitTransparentSoftwareActivity._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000926 RID: 2342
		// (get) Token: 0x06001AD2 RID: 6866 RVA: 0x0004E698 File Offset: 0x0004C898
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return AdUnitTransparentSoftwareActivity._members.ManagedPeerType;
			}
		}

		// Token: 0x06001AD3 RID: 6867 RVA: 0x0004E6A4 File Offset: 0x0004C8A4
		protected AdUnitTransparentSoftwareActivity(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06001AD4 RID: 6868 RVA: 0x0004E6B0 File Offset: 0x0004C8B0
		[Register(".ctor", "()V", "")]
		public AdUnitTransparentSoftwareActivity() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			base.SetHandle(AdUnitTransparentSoftwareActivity._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
			AdUnitTransparentSoftwareActivity._members.InstanceMethods.FinishCreateInstance("()V", this, null);
		}

		// Token: 0x0400068C RID: 1676
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/services/ads/adunit/AdUnitTransparentSoftwareActivity", typeof(AdUnitTransparentSoftwareActivity));
	}
}
