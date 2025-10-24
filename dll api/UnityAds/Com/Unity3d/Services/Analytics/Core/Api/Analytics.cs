using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Com.Unity3d.Services.Analytics.Interfaces;
using Com.Unity3d.Services.Core.Webview.Bridge;
using Java.Interop;
using Java.Lang;

namespace Com.Unity3d.Services.Analytics.Core.Api
{
	// Token: 0x020001CA RID: 458
	[Register("com/unity3d/services/analytics/core/api/Analytics", DoNotGenerateAcw = true)]
	public class Analytics : Java.Lang.Object
	{
		// Token: 0x17000716 RID: 1814
		// (get) Token: 0x06001475 RID: 5237 RVA: 0x0003A748 File Offset: 0x00038948
		// (set) Token: 0x06001476 RID: 5238 RVA: 0x0003A778 File Offset: 0x00038978
		[Register("analyticsInterface")]
		public static IAnalytics AnalyticsInterface
		{
			get
			{
				return Java.Lang.Object.GetObject<IAnalytics>(Analytics._members.StaticFields.GetObjectValue("analyticsInterface.Lcom/unity3d/services/analytics/interfaces/IAnalytics;").Handle, JniHandleOwnership.TransferLocalRef);
			}
			set
			{
				IntPtr intPtr = JNIEnv.ToLocalJniHandle(value);
				try
				{
					Analytics._members.StaticFields.SetValue("analyticsInterface.Lcom/unity3d/services/analytics/interfaces/IAnalytics;", new JniObjectReference(intPtr, JniObjectReferenceType.Invalid));
				}
				finally
				{
					JNIEnv.DeleteLocalRef(intPtr);
				}
			}
		}

		// Token: 0x17000717 RID: 1815
		// (get) Token: 0x06001477 RID: 5239 RVA: 0x0003A7C0 File Offset: 0x000389C0
		internal static IntPtr class_ref
		{
			get
			{
				return Analytics._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000718 RID: 1816
		// (get) Token: 0x06001478 RID: 5240 RVA: 0x0003A7E4 File Offset: 0x000389E4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return Analytics._members;
			}
		}

		// Token: 0x17000719 RID: 1817
		// (get) Token: 0x06001479 RID: 5241 RVA: 0x0003A7EC File Offset: 0x000389EC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return Analytics._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700071A RID: 1818
		// (get) Token: 0x0600147A RID: 5242 RVA: 0x0003A810 File Offset: 0x00038A10
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return Analytics._members.ManagedPeerType;
			}
		}

		// Token: 0x0600147B RID: 5243 RVA: 0x000021E8 File Offset: 0x000003E8
		protected Analytics(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x0600147C RID: 5244 RVA: 0x0003A81C File Offset: 0x00038A1C
		[Register(".ctor", "()V", "")]
		public Analytics() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			base.SetHandle(Analytics._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
			Analytics._members.InstanceMethods.FinishCreateInstance("()V", this, null);
		}

		// Token: 0x0600147D RID: 5245 RVA: 0x0003A88C File Offset: 0x00038A8C
		[Register("addExtras", "(Ljava/lang/String;Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", "")]
		public unsafe static void AddExtras(string extras, WebViewCallback callback)
		{
			IntPtr intPtr = JNIEnv.NewString(extras);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((callback == null) ? IntPtr.Zero : callback.Handle);
				Analytics._members.StaticMethods.InvokeVoidMethod("addExtras.(Ljava/lang/String;Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(callback);
			}
		}

		// Token: 0x0600147E RID: 5246 RVA: 0x0003A910 File Offset: 0x00038B10
		[Register("setAnalyticsInterface", "(Lcom/unity3d/services/analytics/interfaces/IAnalytics;)V", "")]
		public unsafe static void SetAnalyticsInterface(IAnalytics analytics)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((analytics == null) ? IntPtr.Zero : ((Java.Lang.Object)analytics).Handle);
				Analytics._members.StaticMethods.InvokeVoidMethod("setAnalyticsInterface.(Lcom/unity3d/services/analytics/interfaces/IAnalytics;)V", ptr);
			}
			finally
			{
				GC.KeepAlive(analytics);
			}
		}

		// Token: 0x040004E1 RID: 1249
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/services/analytics/core/api/Analytics", typeof(Analytics));
	}
}
