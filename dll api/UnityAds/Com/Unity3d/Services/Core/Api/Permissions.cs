using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Com.Unity3d.Services.Core.Webview.Bridge;
using Java.Interop;
using Java.Lang;
using Org.Json;

namespace Com.Unity3d.Services.Core.Api
{
	// Token: 0x0200018F RID: 399
	[Register("com/unity3d/services/core/api/Permissions", DoNotGenerateAcw = true)]
	public class Permissions : Java.Lang.Object
	{
		// Token: 0x1700066D RID: 1645
		// (get) Token: 0x0600122F RID: 4655 RVA: 0x000325EC File Offset: 0x000307EC
		internal static IntPtr class_ref
		{
			get
			{
				return Permissions._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700066E RID: 1646
		// (get) Token: 0x06001230 RID: 4656 RVA: 0x00032610 File Offset: 0x00030810
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return Permissions._members;
			}
		}

		// Token: 0x1700066F RID: 1647
		// (get) Token: 0x06001231 RID: 4657 RVA: 0x00032618 File Offset: 0x00030818
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return Permissions._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000670 RID: 1648
		// (get) Token: 0x06001232 RID: 4658 RVA: 0x0003263C File Offset: 0x0003083C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return Permissions._members.ManagedPeerType;
			}
		}

		// Token: 0x06001233 RID: 4659 RVA: 0x000021E8 File Offset: 0x000003E8
		protected Permissions(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06001234 RID: 4660 RVA: 0x00032648 File Offset: 0x00030848
		[Register(".ctor", "()V", "")]
		public Permissions() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			base.SetHandle(Permissions._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
			Permissions._members.InstanceMethods.FinishCreateInstance("()V", this, null);
		}

		// Token: 0x06001235 RID: 4661 RVA: 0x000326B8 File Offset: 0x000308B8
		[Register("checkPermission", "(Ljava/lang/String;Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", "")]
		public unsafe static void CheckPermission(string permission, WebViewCallback callback)
		{
			IntPtr intPtr = JNIEnv.NewString(permission);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((callback == null) ? IntPtr.Zero : callback.Handle);
				Permissions._members.StaticMethods.InvokeVoidMethod("checkPermission.(Ljava/lang/String;Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(callback);
			}
		}

		// Token: 0x06001236 RID: 4662 RVA: 0x0003273C File Offset: 0x0003093C
		[Register("getPermissions", "(Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", "")]
		public unsafe static void GetPermissions(WebViewCallback callback)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((callback == null) ? IntPtr.Zero : callback.Handle);
				Permissions._members.StaticMethods.InvokeVoidMethod("getPermissions.(Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", ptr);
			}
			finally
			{
				GC.KeepAlive(callback);
			}
		}

		// Token: 0x06001237 RID: 4663 RVA: 0x000327A0 File Offset: 0x000309A0
		[Register("requestPermissions", "(Lorg/json/JSONArray;Ljava/lang/Integer;Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", "")]
		public unsafe static void RequestPermissions(JSONArray permissions, Integer requestCode, WebViewCallback callback)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((permissions == null) ? IntPtr.Zero : permissions.Handle);
				ptr[1] = new JniArgumentValue((requestCode == null) ? IntPtr.Zero : requestCode.Handle);
				ptr[2] = new JniArgumentValue((callback == null) ? IntPtr.Zero : callback.Handle);
				Permissions._members.StaticMethods.InvokeVoidMethod("requestPermissions.(Lorg/json/JSONArray;Ljava/lang/Integer;Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", ptr);
			}
			finally
			{
				GC.KeepAlive(permissions);
				GC.KeepAlive(requestCode);
				GC.KeepAlive(callback);
			}
		}

		// Token: 0x04000452 RID: 1106
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/services/core/api/Permissions", typeof(Permissions));
	}
}
