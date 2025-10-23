using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Com.Unity3d.Services.Core.Configuration;
using Com.Unity3d.Services.Core.Webview.Bridge;
using Java.Interop;
using Java.Lang;
using Org.Json;

namespace Com.Unity3d.Services.Ads.Adunit
{
	// Token: 0x0200022C RID: 556
	[Register("com/unity3d/services/ads/adunit/AdUnitOpen", DoNotGenerateAcw = true)]
	public class AdUnitOpen : Java.Lang.Object
	{
		// Token: 0x17000911 RID: 2321
		// (get) Token: 0x06001A9B RID: 6811 RVA: 0x0004DDF0 File Offset: 0x0004BFF0
		internal static IntPtr class_ref
		{
			get
			{
				return AdUnitOpen._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000912 RID: 2322
		// (get) Token: 0x06001A9C RID: 6812 RVA: 0x0004DE14 File Offset: 0x0004C014
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return AdUnitOpen._members;
			}
		}

		// Token: 0x17000913 RID: 2323
		// (get) Token: 0x06001A9D RID: 6813 RVA: 0x0004DE1C File Offset: 0x0004C01C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return AdUnitOpen._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000914 RID: 2324
		// (get) Token: 0x06001A9E RID: 6814 RVA: 0x0004DE40 File Offset: 0x0004C040
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return AdUnitOpen._members.ManagedPeerType;
			}
		}

		// Token: 0x06001A9F RID: 6815 RVA: 0x000021E8 File Offset: 0x000003E8
		protected AdUnitOpen(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06001AA0 RID: 6816 RVA: 0x0004DE4C File Offset: 0x0004C04C
		[Register(".ctor", "()V", "")]
		public AdUnitOpen() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			base.SetHandle(AdUnitOpen._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
			AdUnitOpen._members.InstanceMethods.FinishCreateInstance("()V", this, null);
		}

		// Token: 0x06001AA1 RID: 6817 RVA: 0x0004DEBC File Offset: 0x0004C0BC
		[Register("open", "(Ljava/lang/String;Lorg/json/JSONObject;)Z", "")]
		public unsafe static bool Open(string placementId, JSONObject options)
		{
			IntPtr intPtr = JNIEnv.NewString(placementId);
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((options == null) ? IntPtr.Zero : options.Handle);
				result = AdUnitOpen._members.StaticMethods.InvokeBooleanMethod("open.(Ljava/lang/String;Lorg/json/JSONObject;)Z", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(options);
			}
			return result;
		}

		// Token: 0x06001AA2 RID: 6818 RVA: 0x0004DF40 File Offset: 0x0004C140
		[Register("setConfiguration", "(Lcom/unity3d/services/core/configuration/Configuration;)V", "")]
		public unsafe static void SetConfiguration(Configuration configuration)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((configuration == null) ? IntPtr.Zero : configuration.Handle);
				AdUnitOpen._members.StaticMethods.InvokeVoidMethod("setConfiguration.(Lcom/unity3d/services/core/configuration/Configuration;)V", ptr);
			}
			finally
			{
				GC.KeepAlive(configuration);
			}
		}

		// Token: 0x06001AA3 RID: 6819 RVA: 0x0004DFA4 File Offset: 0x0004C1A4
		[Register("showCallback", "(Lcom/unity3d/services/core/webview/bridge/CallbackStatus;)V", "")]
		public unsafe static void ShowCallback(CallbackStatus status)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((status == null) ? IntPtr.Zero : status.Handle);
				AdUnitOpen._members.StaticMethods.InvokeVoidMethod("showCallback.(Lcom/unity3d/services/core/webview/bridge/CallbackStatus;)V", ptr);
			}
			finally
			{
				GC.KeepAlive(status);
			}
		}

		// Token: 0x04000681 RID: 1665
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/services/ads/adunit/AdUnitOpen", typeof(AdUnitOpen));
	}
}
