using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Com.Unity3d.Services.Core.Webview.Bridge;
using Java.Interop;
using Java.Lang;

namespace Com.Unity3d.Services.Core.Api
{
	// Token: 0x02000192 RID: 402
	[Register("com/unity3d/services/core/api/Resolve", DoNotGenerateAcw = true)]
	public class Resolve : Java.Lang.Object
	{
		// Token: 0x17000679 RID: 1657
		// (get) Token: 0x0600125B RID: 4699 RVA: 0x00033918 File Offset: 0x00031B18
		internal static IntPtr class_ref
		{
			get
			{
				return Resolve._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700067A RID: 1658
		// (get) Token: 0x0600125C RID: 4700 RVA: 0x0003393C File Offset: 0x00031B3C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return Resolve._members;
			}
		}

		// Token: 0x1700067B RID: 1659
		// (get) Token: 0x0600125D RID: 4701 RVA: 0x00033944 File Offset: 0x00031B44
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return Resolve._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700067C RID: 1660
		// (get) Token: 0x0600125E RID: 4702 RVA: 0x00033968 File Offset: 0x00031B68
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return Resolve._members.ManagedPeerType;
			}
		}

		// Token: 0x0600125F RID: 4703 RVA: 0x000021E8 File Offset: 0x000003E8
		protected Resolve(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06001260 RID: 4704 RVA: 0x00033974 File Offset: 0x00031B74
		[Register(".ctor", "()V", "")]
		public Resolve() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			base.SetHandle(Resolve._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
			Resolve._members.InstanceMethods.FinishCreateInstance("()V", this, null);
		}

		// Token: 0x06001261 RID: 4705 RVA: 0x000339E4 File Offset: 0x00031BE4
		[Register("resolve", "(Ljava/lang/String;Ljava/lang/String;Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", "")]
		public unsafe static void InvokeResolve(string id, string host, WebViewCallback callback)
		{
			IntPtr intPtr = JNIEnv.NewString(id);
			IntPtr intPtr2 = JNIEnv.NewString(host);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(intPtr2);
				ptr[2] = new JniArgumentValue((callback == null) ? IntPtr.Zero : callback.Handle);
				Resolve._members.StaticMethods.InvokeVoidMethod("resolve.(Ljava/lang/String;Ljava/lang/String;Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				JNIEnv.DeleteLocalRef(intPtr2);
				GC.KeepAlive(callback);
			}
		}

		// Token: 0x04000455 RID: 1109
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/services/core/api/Resolve", typeof(Resolve));
	}
}
