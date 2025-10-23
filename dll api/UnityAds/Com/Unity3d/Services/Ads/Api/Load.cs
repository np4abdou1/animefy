using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Com.Unity3d.Services.Core.Webview.Bridge;
using Java.Interop;
using Java.Lang;

namespace Com.Unity3d.Services.Ads.Api
{
	// Token: 0x02000223 RID: 547
	[Register("com/unity3d/services/ads/api/Load", DoNotGenerateAcw = true)]
	public class Load : Java.Lang.Object
	{
		// Token: 0x170008C9 RID: 2249
		// (get) Token: 0x060019D7 RID: 6615 RVA: 0x0004AF9C File Offset: 0x0004919C
		internal static IntPtr class_ref
		{
			get
			{
				return Load._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170008CA RID: 2250
		// (get) Token: 0x060019D8 RID: 6616 RVA: 0x0004AFC0 File Offset: 0x000491C0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return Load._members;
			}
		}

		// Token: 0x170008CB RID: 2251
		// (get) Token: 0x060019D9 RID: 6617 RVA: 0x0004AFC8 File Offset: 0x000491C8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return Load._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170008CC RID: 2252
		// (get) Token: 0x060019DA RID: 6618 RVA: 0x0004AFEC File Offset: 0x000491EC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return Load._members.ManagedPeerType;
			}
		}

		// Token: 0x060019DB RID: 6619 RVA: 0x000021E8 File Offset: 0x000003E8
		protected Load(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x060019DC RID: 6620 RVA: 0x0004AFF8 File Offset: 0x000491F8
		[Register(".ctor", "()V", "")]
		public Load() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			base.SetHandle(Load._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
			Load._members.InstanceMethods.FinishCreateInstance("()V", this, null);
		}

		// Token: 0x060019DD RID: 6621 RVA: 0x0004B068 File Offset: 0x00049268
		[Register("sendAdFailedToLoad", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", "")]
		public unsafe static void SendAdFailedToLoad(string placementId, string listenerId, string error, string message, WebViewCallback callback)
		{
			IntPtr intPtr = JNIEnv.NewString(placementId);
			IntPtr intPtr2 = JNIEnv.NewString(listenerId);
			IntPtr intPtr3 = JNIEnv.NewString(error);
			IntPtr intPtr4 = JNIEnv.NewString(message);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(intPtr2);
				ptr[2] = new JniArgumentValue(intPtr3);
				ptr[3] = new JniArgumentValue(intPtr4);
				ptr[4] = new JniArgumentValue((callback == null) ? IntPtr.Zero : callback.Handle);
				Load._members.StaticMethods.InvokeVoidMethod("sendAdFailedToLoad.(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				JNIEnv.DeleteLocalRef(intPtr2);
				JNIEnv.DeleteLocalRef(intPtr3);
				JNIEnv.DeleteLocalRef(intPtr4);
				GC.KeepAlive(callback);
			}
		}

		// Token: 0x060019DE RID: 6622 RVA: 0x0004B160 File Offset: 0x00049360
		[Register("sendAdLoaded", "(Ljava/lang/String;Ljava/lang/String;Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", "")]
		public unsafe static void SendAdLoaded(string placementId, string listenerId, WebViewCallback callback)
		{
			IntPtr intPtr = JNIEnv.NewString(placementId);
			IntPtr intPtr2 = JNIEnv.NewString(listenerId);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(intPtr2);
				ptr[2] = new JniArgumentValue((callback == null) ? IntPtr.Zero : callback.Handle);
				Load._members.StaticMethods.InvokeVoidMethod("sendAdLoaded.(Ljava/lang/String;Ljava/lang/String;Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				JNIEnv.DeleteLocalRef(intPtr2);
				GC.KeepAlive(callback);
			}
		}

		// Token: 0x0400065A RID: 1626
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/services/ads/api/Load", typeof(Load));
	}
}
