using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Com.Unity3d.Services.Core.Webview.Bridge;
using Java.Interop;
using Java.Lang;

namespace Com.Unity3d.Services.Core.Api
{
	// Token: 0x02000186 RID: 390
	[Register("com/unity3d/services/core/api/ClassDetection", DoNotGenerateAcw = true)]
	public class ClassDetection : Java.Lang.Object
	{
		// Token: 0x1700063B RID: 1595
		// (get) Token: 0x06001198 RID: 4504 RVA: 0x0002FCD8 File Offset: 0x0002DED8
		internal static IntPtr class_ref
		{
			get
			{
				return ClassDetection._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700063C RID: 1596
		// (get) Token: 0x06001199 RID: 4505 RVA: 0x0002FCFC File Offset: 0x0002DEFC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return ClassDetection._members;
			}
		}

		// Token: 0x1700063D RID: 1597
		// (get) Token: 0x0600119A RID: 4506 RVA: 0x0002FD04 File Offset: 0x0002DF04
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return ClassDetection._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700063E RID: 1598
		// (get) Token: 0x0600119B RID: 4507 RVA: 0x0002FD28 File Offset: 0x0002DF28
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return ClassDetection._members.ManagedPeerType;
			}
		}

		// Token: 0x0600119C RID: 4508 RVA: 0x000021E8 File Offset: 0x000003E8
		protected ClassDetection(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x0600119D RID: 4509 RVA: 0x0002FD34 File Offset: 0x0002DF34
		[Register(".ctor", "()V", "")]
		public ClassDetection() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			base.SetHandle(ClassDetection._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
			ClassDetection._members.InstanceMethods.FinishCreateInstance("()V", this, null);
		}

		// Token: 0x0600119E RID: 4510 RVA: 0x0002FDA4 File Offset: 0x0002DFA4
		[Register("isMadeWithUnity", "(Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", "")]
		public unsafe static void IsMadeWithUnity(WebViewCallback callback)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((callback == null) ? IntPtr.Zero : callback.Handle);
				ClassDetection._members.StaticMethods.InvokeVoidMethod("isMadeWithUnity.(Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", ptr);
			}
			finally
			{
				GC.KeepAlive(callback);
			}
		}

		// Token: 0x04000449 RID: 1097
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/services/core/api/ClassDetection", typeof(ClassDetection));
	}
}
