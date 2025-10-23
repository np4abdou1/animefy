using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Com.Unity3d.Services.Ads.Webplayer
{
	// Token: 0x020001D1 RID: 465
	[Register("com/unity3d/services/ads/webplayer/WebPlayerEventBridge", DoNotGenerateAcw = true)]
	public class WebPlayerEventBridge : Java.Lang.Object
	{
		// Token: 0x17000764 RID: 1892
		// (get) Token: 0x06001505 RID: 5381 RVA: 0x0003C358 File Offset: 0x0003A558
		internal static IntPtr class_ref
		{
			get
			{
				return WebPlayerEventBridge._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000765 RID: 1893
		// (get) Token: 0x06001506 RID: 5382 RVA: 0x0003C37C File Offset: 0x0003A57C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return WebPlayerEventBridge._members;
			}
		}

		// Token: 0x17000766 RID: 1894
		// (get) Token: 0x06001507 RID: 5383 RVA: 0x0003C384 File Offset: 0x0003A584
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return WebPlayerEventBridge._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000767 RID: 1895
		// (get) Token: 0x06001508 RID: 5384 RVA: 0x0003C3A8 File Offset: 0x0003A5A8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return WebPlayerEventBridge._members.ManagedPeerType;
			}
		}

		// Token: 0x06001509 RID: 5385 RVA: 0x000021E8 File Offset: 0x000003E8
		protected WebPlayerEventBridge(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x0600150A RID: 5386 RVA: 0x0003C3B4 File Offset: 0x0003A5B4
		[Register(".ctor", "()V", "")]
		public WebPlayerEventBridge() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			base.SetHandle(WebPlayerEventBridge._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
			WebPlayerEventBridge._members.InstanceMethods.FinishCreateInstance("()V", this, null);
		}

		// Token: 0x0600150B RID: 5387 RVA: 0x0003C424 File Offset: 0x0003A624
		[Register("error", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", "")]
		public unsafe static void Error(string viewId, string failingUrl, string errorMessage)
		{
			IntPtr intPtr = JNIEnv.NewString(viewId);
			IntPtr intPtr2 = JNIEnv.NewString(failingUrl);
			IntPtr intPtr3 = JNIEnv.NewString(errorMessage);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(intPtr2);
				ptr[2] = new JniArgumentValue(intPtr3);
				WebPlayerEventBridge._members.StaticMethods.InvokeVoidMethod("error.(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				JNIEnv.DeleteLocalRef(intPtr2);
				JNIEnv.DeleteLocalRef(intPtr3);
			}
		}

		// Token: 0x0600150C RID: 5388 RVA: 0x0003C4C4 File Offset: 0x0003A6C4
		[Register("sendFrameUpdate", "(Ljava/lang/String;IIIIF)V", "")]
		public unsafe static void SendFrameUpdate(string viewId, int x, int y, int width, int height, float alpha)
		{
			IntPtr intPtr = JNIEnv.NewString(viewId);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(x);
				ptr[2] = new JniArgumentValue(y);
				ptr[3] = new JniArgumentValue(width);
				ptr[4] = new JniArgumentValue(height);
				ptr[5] = new JniArgumentValue(alpha);
				WebPlayerEventBridge._members.StaticMethods.InvokeVoidMethod("sendFrameUpdate.(Ljava/lang/String;IIIIF)V", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
		}

		// Token: 0x0600150D RID: 5389 RVA: 0x0003C58C File Offset: 0x0003A78C
		[Register("sendGetFrameResponse", "(Ljava/lang/String;Ljava/lang/String;IIIIF)V", "")]
		public unsafe static void SendGetFrameResponse(string callId, string viewId, int x, int y, int width, int height, float alpha)
		{
			IntPtr intPtr = JNIEnv.NewString(callId);
			IntPtr intPtr2 = JNIEnv.NewString(viewId);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(intPtr2);
				ptr[2] = new JniArgumentValue(x);
				ptr[3] = new JniArgumentValue(y);
				ptr[4] = new JniArgumentValue(width);
				ptr[5] = new JniArgumentValue(height);
				ptr[6] = new JniArgumentValue(alpha);
				WebPlayerEventBridge._members.StaticMethods.InvokeVoidMethod("sendGetFrameResponse.(Ljava/lang/String;Ljava/lang/String;IIIIF)V", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				JNIEnv.DeleteLocalRef(intPtr2);
			}
		}

		// Token: 0x040004FD RID: 1277
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/services/ads/webplayer/WebPlayerEventBridge", typeof(WebPlayerEventBridge));
	}
}
