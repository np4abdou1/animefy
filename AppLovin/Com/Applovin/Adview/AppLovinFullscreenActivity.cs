using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.App;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Com.Applovin.Adview
{
	// Token: 0x02000190 RID: 400
	[Register("com/applovin/adview/AppLovinFullscreenActivity", DoNotGenerateAcw = true)]
	public class AppLovinFullscreenActivity : Activity
	{
		// Token: 0x170004D0 RID: 1232
		// (get) Token: 0x0600129D RID: 4765 RVA: 0x000357C4 File Offset: 0x000339C4
		internal static IntPtr class_ref
		{
			get
			{
				return AppLovinFullscreenActivity._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170004D1 RID: 1233
		// (get) Token: 0x0600129E RID: 4766 RVA: 0x000357E8 File Offset: 0x000339E8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return AppLovinFullscreenActivity._members;
			}
		}

		// Token: 0x170004D2 RID: 1234
		// (get) Token: 0x0600129F RID: 4767 RVA: 0x000357F0 File Offset: 0x000339F0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return AppLovinFullscreenActivity._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170004D3 RID: 1235
		// (get) Token: 0x060012A0 RID: 4768 RVA: 0x00035814 File Offset: 0x00033A14
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return AppLovinFullscreenActivity._members.ManagedPeerType;
			}
		}

		// Token: 0x060012A1 RID: 4769 RVA: 0x00009950 File Offset: 0x00007B50
		protected AppLovinFullscreenActivity(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x060012A2 RID: 4770 RVA: 0x00035820 File Offset: 0x00033A20
		[Register(".ctor", "()V", "")]
		public AppLovinFullscreenActivity() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			base.SetHandle(AppLovinFullscreenActivity._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
			AppLovinFullscreenActivity._members.InstanceMethods.FinishCreateInstance("()V", this, null);
		}

		// Token: 0x060012A3 RID: 4771 RVA: 0x0003588E File Offset: 0x00033A8E
		private static Delegate GetDismissHandler()
		{
			if (AppLovinFullscreenActivity.cb_dismiss == null)
			{
				AppLovinFullscreenActivity.cb_dismiss = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(AppLovinFullscreenActivity.n_Dismiss));
			}
			return AppLovinFullscreenActivity.cb_dismiss;
		}

		// Token: 0x060012A4 RID: 4772 RVA: 0x000358B2 File Offset: 0x00033AB2
		private static void n_Dismiss(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<AppLovinFullscreenActivity>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Dismiss();
		}

		// Token: 0x060012A5 RID: 4773 RVA: 0x000358C1 File Offset: 0x00033AC1
		[Register("dismiss", "()V", "GetDismissHandler")]
		public virtual void Dismiss()
		{
			AppLovinFullscreenActivity._members.InstanceMethods.InvokeVirtualVoidMethod("dismiss.()V", this, null);
		}

		// Token: 0x04000619 RID: 1561
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/applovin/adview/AppLovinFullscreenActivity", typeof(AppLovinFullscreenActivity));

		// Token: 0x0400061A RID: 1562
		private static Delegate cb_dismiss;
	}
}
