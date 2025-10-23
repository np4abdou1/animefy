using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Com.Unity3d.Services.Core.Api;
using Java.Interop;
using Java.Lang;

namespace Com.Unity3d.Services.Core.Configuration
{
	// Token: 0x02000172 RID: 370
	[Register("com/unity3d/services/core/configuration/InitializeThread", DoNotGenerateAcw = true)]
	public class InitializeThread : Thread
	{
		// Token: 0x170005CA RID: 1482
		// (get) Token: 0x06001095 RID: 4245 RVA: 0x0002C8B4 File Offset: 0x0002AAB4
		internal static IntPtr class_ref
		{
			get
			{
				return InitializeThread._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170005CB RID: 1483
		// (get) Token: 0x06001096 RID: 4246 RVA: 0x0002C8D8 File Offset: 0x0002AAD8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return InitializeThread._members;
			}
		}

		// Token: 0x170005CC RID: 1484
		// (get) Token: 0x06001097 RID: 4247 RVA: 0x0002C8E0 File Offset: 0x0002AAE0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return InitializeThread._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170005CD RID: 1485
		// (get) Token: 0x06001098 RID: 4248 RVA: 0x0002C904 File Offset: 0x0002AB04
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return InitializeThread._members.ManagedPeerType;
			}
		}

		// Token: 0x06001099 RID: 4249 RVA: 0x0002C910 File Offset: 0x0002AB10
		protected InitializeThread(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x0600109A RID: 4250 RVA: 0x0002C91C File Offset: 0x0002AB1C
		[Register("downloadLatestWebView", "()Lcom/unity3d/services/core/api/DownloadLatestWebViewStatus;", "")]
		public static DownloadLatestWebViewStatus DownloadLatestWebView()
		{
			return Java.Lang.Object.GetObject<DownloadLatestWebViewStatus>(InitializeThread._members.StaticMethods.InvokeObjectMethod("downloadLatestWebView.()Lcom/unity3d/services/core/api/DownloadLatestWebViewStatus;", null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x0600109B RID: 4251 RVA: 0x0002C950 File Offset: 0x0002AB50
		[Register("initialize", "(Lcom/unity3d/services/core/configuration/Configuration;)V", "")]
		public unsafe static void Initialize(Configuration configuration)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((configuration == null) ? IntPtr.Zero : configuration.Handle);
				InitializeThread._members.StaticMethods.InvokeVoidMethod("initialize.(Lcom/unity3d/services/core/configuration/Configuration;)V", ptr);
			}
			finally
			{
				GC.KeepAlive(configuration);
			}
		}

		// Token: 0x0600109C RID: 4252 RVA: 0x0002C9B4 File Offset: 0x0002ABB4
		private static Delegate GetQuitHandler()
		{
			if (InitializeThread.cb_quit == null)
			{
				InitializeThread.cb_quit = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(InitializeThread.n_Quit));
			}
			return InitializeThread.cb_quit;
		}

		// Token: 0x0600109D RID: 4253 RVA: 0x0002C9D8 File Offset: 0x0002ABD8
		private static void n_Quit(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<InitializeThread>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Quit();
		}

		// Token: 0x0600109E RID: 4254 RVA: 0x0002C9E7 File Offset: 0x0002ABE7
		[Register("quit", "()V", "GetQuitHandler")]
		public virtual void Quit()
		{
			InitializeThread._members.InstanceMethods.InvokeVirtualVoidMethod("quit.()V", this, null);
		}

		// Token: 0x0600109F RID: 4255 RVA: 0x0002CA00 File Offset: 0x0002AC00
		[Register("reset", "()V", "")]
		public static void Reset()
		{
			InitializeThread._members.StaticMethods.InvokeVoidMethod("reset.()V", null);
		}

		// Token: 0x04000421 RID: 1057
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/services/core/configuration/InitializeThread", typeof(InitializeThread));

		// Token: 0x04000422 RID: 1058
		private static Delegate cb_quit;
	}
}
