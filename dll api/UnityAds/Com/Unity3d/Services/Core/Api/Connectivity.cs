using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Com.Unity3d.Services.Core.Webview.Bridge;
using Java.Interop;
using Java.Lang;

namespace Com.Unity3d.Services.Core.Api
{
	// Token: 0x02000187 RID: 391
	[Register("com/unity3d/services/core/api/Connectivity", DoNotGenerateAcw = true)]
	public class Connectivity : Java.Lang.Object
	{
		// Token: 0x1700063F RID: 1599
		// (get) Token: 0x060011A0 RID: 4512 RVA: 0x0002FE24 File Offset: 0x0002E024
		internal static IntPtr class_ref
		{
			get
			{
				return Connectivity._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000640 RID: 1600
		// (get) Token: 0x060011A1 RID: 4513 RVA: 0x0002FE48 File Offset: 0x0002E048
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return Connectivity._members;
			}
		}

		// Token: 0x17000641 RID: 1601
		// (get) Token: 0x060011A2 RID: 4514 RVA: 0x0002FE50 File Offset: 0x0002E050
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return Connectivity._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000642 RID: 1602
		// (get) Token: 0x060011A3 RID: 4515 RVA: 0x0002FE74 File Offset: 0x0002E074
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return Connectivity._members.ManagedPeerType;
			}
		}

		// Token: 0x060011A4 RID: 4516 RVA: 0x000021E8 File Offset: 0x000003E8
		protected Connectivity(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x060011A5 RID: 4517 RVA: 0x0002FE80 File Offset: 0x0002E080
		[Register(".ctor", "()V", "")]
		public Connectivity() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			base.SetHandle(Connectivity._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
			Connectivity._members.InstanceMethods.FinishCreateInstance("()V", this, null);
		}

		// Token: 0x060011A6 RID: 4518 RVA: 0x0002FEF0 File Offset: 0x0002E0F0
		[Register("setConnectionMonitoring", "(Ljava/lang/Boolean;Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", "")]
		public unsafe static void SetConnectionMonitoring(Java.Lang.Boolean monitoring, WebViewCallback callback)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((monitoring == null) ? IntPtr.Zero : monitoring.Handle);
				ptr[1] = new JniArgumentValue((callback == null) ? IntPtr.Zero : callback.Handle);
				Connectivity._members.StaticMethods.InvokeVoidMethod("setConnectionMonitoring.(Ljava/lang/Boolean;Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", ptr);
			}
			finally
			{
				GC.KeepAlive(monitoring);
				GC.KeepAlive(callback);
			}
		}

		// Token: 0x0400044A RID: 1098
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/services/core/api/Connectivity", typeof(Connectivity));
	}
}
