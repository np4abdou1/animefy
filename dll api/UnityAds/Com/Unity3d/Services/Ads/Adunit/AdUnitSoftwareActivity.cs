using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;

namespace Com.Unity3d.Services.Ads.Adunit
{
	// Token: 0x0200022E RID: 558
	[Register("com/unity3d/services/ads/adunit/AdUnitSoftwareActivity", DoNotGenerateAcw = true)]
	public class AdUnitSoftwareActivity : AdUnitActivity
	{
		// Token: 0x1700091B RID: 2331
		// (get) Token: 0x06001AC1 RID: 6849 RVA: 0x0004E46C File Offset: 0x0004C66C
		internal new static IntPtr class_ref
		{
			get
			{
				return AdUnitSoftwareActivity._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700091C RID: 2332
		// (get) Token: 0x06001AC2 RID: 6850 RVA: 0x0004E490 File Offset: 0x0004C690
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return AdUnitSoftwareActivity._members;
			}
		}

		// Token: 0x1700091D RID: 2333
		// (get) Token: 0x06001AC3 RID: 6851 RVA: 0x0004E498 File Offset: 0x0004C698
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return AdUnitSoftwareActivity._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700091E RID: 2334
		// (get) Token: 0x06001AC4 RID: 6852 RVA: 0x0004E4BC File Offset: 0x0004C6BC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return AdUnitSoftwareActivity._members.ManagedPeerType;
			}
		}

		// Token: 0x06001AC5 RID: 6853 RVA: 0x0004E4C8 File Offset: 0x0004C6C8
		protected AdUnitSoftwareActivity(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06001AC6 RID: 6854 RVA: 0x0004E4D4 File Offset: 0x0004C6D4
		[Register(".ctor", "()V", "")]
		public AdUnitSoftwareActivity() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			base.SetHandle(AdUnitSoftwareActivity._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
			AdUnitSoftwareActivity._members.InstanceMethods.FinishCreateInstance("()V", this, null);
		}

		// Token: 0x0400068A RID: 1674
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/services/ads/adunit/AdUnitSoftwareActivity", typeof(AdUnitSoftwareActivity));
	}
}
