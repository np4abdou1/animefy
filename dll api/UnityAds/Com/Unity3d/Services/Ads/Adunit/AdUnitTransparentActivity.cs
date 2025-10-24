using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;

namespace Com.Unity3d.Services.Ads.Adunit
{
	// Token: 0x0200022F RID: 559
	[Register("com/unity3d/services/ads/adunit/AdUnitTransparentActivity", DoNotGenerateAcw = true)]
	public class AdUnitTransparentActivity : AdUnitActivity
	{
		// Token: 0x1700091F RID: 2335
		// (get) Token: 0x06001AC8 RID: 6856 RVA: 0x0004E560 File Offset: 0x0004C760
		internal new static IntPtr class_ref
		{
			get
			{
				return AdUnitTransparentActivity._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000920 RID: 2336
		// (get) Token: 0x06001AC9 RID: 6857 RVA: 0x0004E584 File Offset: 0x0004C784
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return AdUnitTransparentActivity._members;
			}
		}

		// Token: 0x17000921 RID: 2337
		// (get) Token: 0x06001ACA RID: 6858 RVA: 0x0004E58C File Offset: 0x0004C78C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return AdUnitTransparentActivity._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000922 RID: 2338
		// (get) Token: 0x06001ACB RID: 6859 RVA: 0x0004E5B0 File Offset: 0x0004C7B0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return AdUnitTransparentActivity._members.ManagedPeerType;
			}
		}

		// Token: 0x06001ACC RID: 6860 RVA: 0x0004E4C8 File Offset: 0x0004C6C8
		protected AdUnitTransparentActivity(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06001ACD RID: 6861 RVA: 0x0004E5BC File Offset: 0x0004C7BC
		[Register(".ctor", "()V", "")]
		public AdUnitTransparentActivity() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			base.SetHandle(AdUnitTransparentActivity._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
			AdUnitTransparentActivity._members.InstanceMethods.FinishCreateInstance("()V", this, null);
		}

		// Token: 0x0400068B RID: 1675
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/services/ads/adunit/AdUnitTransparentActivity", typeof(AdUnitTransparentActivity));
	}
}
