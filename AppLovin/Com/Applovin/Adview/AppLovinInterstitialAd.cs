using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Content;
using Android.Runtime;
using Com.Applovin.Sdk;
using Java.Interop;
using Java.Lang;

namespace Com.Applovin.Adview
{
	// Token: 0x02000192 RID: 402
	[Register("com/applovin/adview/AppLovinInterstitialAd", DoNotGenerateAcw = true)]
	public class AppLovinInterstitialAd : Java.Lang.Object
	{
		// Token: 0x170004DA RID: 1242
		// (get) Token: 0x060012CE RID: 4814 RVA: 0x000365FC File Offset: 0x000347FC
		internal static IntPtr class_ref
		{
			get
			{
				return AppLovinInterstitialAd._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170004DB RID: 1243
		// (get) Token: 0x060012CF RID: 4815 RVA: 0x00036620 File Offset: 0x00034820
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return AppLovinInterstitialAd._members;
			}
		}

		// Token: 0x170004DC RID: 1244
		// (get) Token: 0x060012D0 RID: 4816 RVA: 0x00036628 File Offset: 0x00034828
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return AppLovinInterstitialAd._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170004DD RID: 1245
		// (get) Token: 0x060012D1 RID: 4817 RVA: 0x0003664C File Offset: 0x0003484C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return AppLovinInterstitialAd._members.ManagedPeerType;
			}
		}

		// Token: 0x060012D2 RID: 4818 RVA: 0x000021F0 File Offset: 0x000003F0
		protected AppLovinInterstitialAd(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x060012D3 RID: 4819 RVA: 0x00036658 File Offset: 0x00034858
		[Register(".ctor", "()V", "")]
		public AppLovinInterstitialAd() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			base.SetHandle(AppLovinInterstitialAd._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
			AppLovinInterstitialAd._members.InstanceMethods.FinishCreateInstance("()V", this, null);
		}

		// Token: 0x060012D4 RID: 4820 RVA: 0x000366C8 File Offset: 0x000348C8
		[Register("create", "(Lcom/applovin/sdk/AppLovinSdk;Landroid/content/Context;)Lcom/applovin/adview/AppLovinInterstitialAdDialog;", "")]
		public unsafe static IAppLovinInterstitialAdDialog Create(AppLovinSdk p0, Context p1)
		{
			IAppLovinInterstitialAdDialog @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((p0 == null) ? IntPtr.Zero : p0.Handle);
				ptr[1] = new JniArgumentValue((p1 == null) ? IntPtr.Zero : p1.Handle);
				@object = Java.Lang.Object.GetObject<IAppLovinInterstitialAdDialog>(AppLovinInterstitialAd._members.StaticMethods.InvokeObjectMethod("create.(Lcom/applovin/sdk/AppLovinSdk;Landroid/content/Context;)Lcom/applovin/adview/AppLovinInterstitialAdDialog;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(p0);
				GC.KeepAlive(p1);
			}
			return @object;
		}

		// Token: 0x04000625 RID: 1573
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/applovin/adview/AppLovinInterstitialAd", typeof(AppLovinInterstitialAd));
	}
}
