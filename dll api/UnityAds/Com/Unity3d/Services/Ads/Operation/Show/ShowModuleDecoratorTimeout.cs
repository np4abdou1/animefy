using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Com.Unity3d.Services.Core.Configuration;
using Java.Interop;
using Java.Lang;

namespace Com.Unity3d.Services.Ads.Operation.Show
{
	// Token: 0x020001F3 RID: 499
	[Register("com/unity3d/services/ads/operation/show/ShowModuleDecoratorTimeout", DoNotGenerateAcw = true)]
	public class ShowModuleDecoratorTimeout : ShowModuleDecorator
	{
		// Token: 0x170007F9 RID: 2041
		// (get) Token: 0x06001705 RID: 5893 RVA: 0x00042390 File Offset: 0x00040590
		internal new static IntPtr class_ref
		{
			get
			{
				return ShowModuleDecoratorTimeout._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170007FA RID: 2042
		// (get) Token: 0x06001706 RID: 5894 RVA: 0x000423B4 File Offset: 0x000405B4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return ShowModuleDecoratorTimeout._members;
			}
		}

		// Token: 0x170007FB RID: 2043
		// (get) Token: 0x06001707 RID: 5895 RVA: 0x000423BC File Offset: 0x000405BC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return ShowModuleDecoratorTimeout._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170007FC RID: 2044
		// (get) Token: 0x06001708 RID: 5896 RVA: 0x000423E0 File Offset: 0x000405E0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return ShowModuleDecoratorTimeout._members.ManagedPeerType;
			}
		}

		// Token: 0x06001709 RID: 5897 RVA: 0x000423EC File Offset: 0x000405EC
		protected ShowModuleDecoratorTimeout(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x0600170A RID: 5898 RVA: 0x000423F8 File Offset: 0x000405F8
		[Register(".ctor", "(Lcom/unity3d/services/ads/operation/show/IShowModule;Lcom/unity3d/services/core/configuration/ConfigurationReader;)V", "")]
		public unsafe ShowModuleDecoratorTimeout(IShowModule showModule, ConfigurationReader configurationReader) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((showModule == null) ? IntPtr.Zero : ((Java.Lang.Object)showModule).Handle);
				ptr[1] = new JniArgumentValue((configurationReader == null) ? IntPtr.Zero : configurationReader.Handle);
				base.SetHandle(ShowModuleDecoratorTimeout._members.InstanceMethods.StartCreateInstance("(Lcom/unity3d/services/ads/operation/show/IShowModule;Lcom/unity3d/services/core/configuration/ConfigurationReader;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				ShowModuleDecoratorTimeout._members.InstanceMethods.FinishCreateInstance("(Lcom/unity3d/services/ads/operation/show/IShowModule;Lcom/unity3d/services/core/configuration/ConfigurationReader;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(showModule);
				GC.KeepAlive(configurationReader);
			}
		}

		// Token: 0x0400058D RID: 1421
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/services/ads/operation/show/ShowModuleDecoratorTimeout", typeof(ShowModuleDecoratorTimeout));
	}
}
