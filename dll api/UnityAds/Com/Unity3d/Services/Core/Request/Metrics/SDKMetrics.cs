using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Com.Unity3d.Services.Core.Configuration;
using Java.Interop;
using Java.Lang;

namespace Com.Unity3d.Services.Core.Request.Metrics
{
	// Token: 0x020000C4 RID: 196
	[Register("com/unity3d/services/core/request/metrics/SDKMetrics", DoNotGenerateAcw = true)]
	public sealed class SDKMetrics : Java.Lang.Object
	{
		// Token: 0x17000259 RID: 601
		// (get) Token: 0x06000786 RID: 1926 RVA: 0x000154E0 File Offset: 0x000136E0
		internal static IntPtr class_ref
		{
			get
			{
				return SDKMetrics._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700025A RID: 602
		// (get) Token: 0x06000787 RID: 1927 RVA: 0x00015504 File Offset: 0x00013704
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return SDKMetrics._members;
			}
		}

		// Token: 0x1700025B RID: 603
		// (get) Token: 0x06000788 RID: 1928 RVA: 0x0001550C File Offset: 0x0001370C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return SDKMetrics._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700025C RID: 604
		// (get) Token: 0x06000789 RID: 1929 RVA: 0x00015530 File Offset: 0x00013730
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return SDKMetrics._members.ManagedPeerType;
			}
		}

		// Token: 0x0600078A RID: 1930 RVA: 0x000021E8 File Offset: 0x000003E8
		internal SDKMetrics(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x0600078B RID: 1931 RVA: 0x0001553C File Offset: 0x0001373C
		[Register(".ctor", "()V", "")]
		public SDKMetrics() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			base.SetHandle(SDKMetrics._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
			SDKMetrics._members.InstanceMethods.FinishCreateInstance("()V", this, null);
		}

		// Token: 0x1700025D RID: 605
		// (get) Token: 0x0600078C RID: 1932 RVA: 0x000155AC File Offset: 0x000137AC
		public static ISDKMetrics Instance
		{
			[Register("getInstance", "()Lcom/unity3d/services/core/request/metrics/ISDKMetrics;", "")]
			get
			{
				return Java.Lang.Object.GetObject<ISDKMetrics>(SDKMetrics._members.StaticMethods.InvokeObjectMethod("getInstance.()Lcom/unity3d/services/core/request/metrics/ISDKMetrics;", null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x0600078D RID: 1933 RVA: 0x000155E0 File Offset: 0x000137E0
		[Register("setConfiguration", "(Lcom/unity3d/services/core/configuration/Configuration;)V", "")]
		public unsafe static void SetConfiguration(Configuration configuration)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((configuration == null) ? IntPtr.Zero : configuration.Handle);
				SDKMetrics._members.StaticMethods.InvokeVoidMethod("setConfiguration.(Lcom/unity3d/services/core/configuration/Configuration;)V", ptr);
			}
			finally
			{
				GC.KeepAlive(configuration);
			}
		}

		// Token: 0x040001D7 RID: 471
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/services/core/request/metrics/SDKMetrics", typeof(SDKMetrics));
	}
}
