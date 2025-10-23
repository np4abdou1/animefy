using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Com.Unity3d.Services.Core.Webview.Bridge;
using Java.Interop;
using Java.Lang;
using Org.Json;

namespace Com.Unity3d.Services.Store.Core.Api
{
	// Token: 0x0200006C RID: 108
	[Register("com/unity3d/services/store/core/api/Store", DoNotGenerateAcw = true)]
	public class Store : Java.Lang.Object
	{
		// Token: 0x17000105 RID: 261
		// (get) Token: 0x0600035D RID: 861 RVA: 0x000097D8 File Offset: 0x000079D8
		internal static IntPtr class_ref
		{
			get
			{
				return Store._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000106 RID: 262
		// (get) Token: 0x0600035E RID: 862 RVA: 0x000097FC File Offset: 0x000079FC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return Store._members;
			}
		}

		// Token: 0x17000107 RID: 263
		// (get) Token: 0x0600035F RID: 863 RVA: 0x00009804 File Offset: 0x00007A04
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return Store._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000108 RID: 264
		// (get) Token: 0x06000360 RID: 864 RVA: 0x00009828 File Offset: 0x00007A28
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return Store._members.ManagedPeerType;
			}
		}

		// Token: 0x06000361 RID: 865 RVA: 0x000021E8 File Offset: 0x000003E8
		protected Store(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000362 RID: 866 RVA: 0x00009834 File Offset: 0x00007A34
		[Register(".ctor", "()V", "")]
		public Store() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			base.SetHandle(Store._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
			Store._members.InstanceMethods.FinishCreateInstance("()V", this, null);
		}

		// Token: 0x06000363 RID: 867 RVA: 0x000098A4 File Offset: 0x00007AA4
		[Register("getPurchaseHistory", "(Ljava/lang/Integer;Ljava/lang/String;Ljava/lang/Integer;Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", "")]
		public unsafe static void GetPurchaseHistory(Integer operationId, string purchaseType, Integer maxPurchases, WebViewCallback callback)
		{
			IntPtr intPtr = JNIEnv.NewString(purchaseType);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((operationId == null) ? IntPtr.Zero : operationId.Handle);
				ptr[1] = new JniArgumentValue(intPtr);
				ptr[2] = new JniArgumentValue((maxPurchases == null) ? IntPtr.Zero : maxPurchases.Handle);
				ptr[3] = new JniArgumentValue((callback == null) ? IntPtr.Zero : callback.Handle);
				Store._members.StaticMethods.InvokeVoidMethod("getPurchaseHistory.(Ljava/lang/Integer;Ljava/lang/String;Ljava/lang/Integer;Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(operationId);
				GC.KeepAlive(maxPurchases);
				GC.KeepAlive(callback);
			}
		}

		// Token: 0x06000364 RID: 868 RVA: 0x0000997C File Offset: 0x00007B7C
		[Register("getPurchases", "(Ljava/lang/Integer;Ljava/lang/String;Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", "")]
		public unsafe static void GetPurchases(Integer operationId, string purchaseType, WebViewCallback callback)
		{
			IntPtr intPtr = JNIEnv.NewString(purchaseType);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((operationId == null) ? IntPtr.Zero : operationId.Handle);
				ptr[1] = new JniArgumentValue(intPtr);
				ptr[2] = new JniArgumentValue((callback == null) ? IntPtr.Zero : callback.Handle);
				Store._members.StaticMethods.InvokeVoidMethod("getPurchases.(Ljava/lang/Integer;Ljava/lang/String;Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(operationId);
				GC.KeepAlive(callback);
			}
		}

		// Token: 0x06000365 RID: 869 RVA: 0x00009A2C File Offset: 0x00007C2C
		[Register("getSkuDetails", "(Ljava/lang/Integer;Ljava/lang/String;Lorg/json/JSONArray;Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", "")]
		public unsafe static void GetSkuDetails(Integer operationId, string purchaseType, JSONArray skuList, WebViewCallback callback)
		{
			IntPtr intPtr = JNIEnv.NewString(purchaseType);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((operationId == null) ? IntPtr.Zero : operationId.Handle);
				ptr[1] = new JniArgumentValue(intPtr);
				ptr[2] = new JniArgumentValue((skuList == null) ? IntPtr.Zero : skuList.Handle);
				ptr[3] = new JniArgumentValue((callback == null) ? IntPtr.Zero : callback.Handle);
				Store._members.StaticMethods.InvokeVoidMethod("getSkuDetails.(Ljava/lang/Integer;Ljava/lang/String;Lorg/json/JSONArray;Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(operationId);
				GC.KeepAlive(skuList);
				GC.KeepAlive(callback);
			}
		}

		// Token: 0x06000366 RID: 870 RVA: 0x00009B04 File Offset: 0x00007D04
		[Register("initialize", "(Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", "")]
		public unsafe static void Initialize(WebViewCallback callback)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((callback == null) ? IntPtr.Zero : callback.Handle);
				Store._members.StaticMethods.InvokeVoidMethod("initialize.(Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", ptr);
			}
			finally
			{
				GC.KeepAlive(callback);
			}
		}

		// Token: 0x06000367 RID: 871 RVA: 0x00009B68 File Offset: 0x00007D68
		[Register("isFeatureSupported", "(Ljava/lang/Integer;Ljava/lang/String;Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", "")]
		public unsafe static void IsFeatureSupported(Integer operationId, string purchaseType, WebViewCallback callback)
		{
			IntPtr intPtr = JNIEnv.NewString(purchaseType);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((operationId == null) ? IntPtr.Zero : operationId.Handle);
				ptr[1] = new JniArgumentValue(intPtr);
				ptr[2] = new JniArgumentValue((callback == null) ? IntPtr.Zero : callback.Handle);
				Store._members.StaticMethods.InvokeVoidMethod("isFeatureSupported.(Ljava/lang/Integer;Ljava/lang/String;Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(operationId);
				GC.KeepAlive(callback);
			}
		}

		// Token: 0x06000368 RID: 872 RVA: 0x00009C18 File Offset: 0x00007E18
		[Register("startPurchaseTracking", "(Lorg/json/JSONArray;Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", "")]
		public unsafe static void StartPurchaseTracking(JSONArray purchaseTypes, WebViewCallback callback)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((purchaseTypes == null) ? IntPtr.Zero : purchaseTypes.Handle);
				ptr[1] = new JniArgumentValue((callback == null) ? IntPtr.Zero : callback.Handle);
				Store._members.StaticMethods.InvokeVoidMethod("startPurchaseTracking.(Lorg/json/JSONArray;Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", ptr);
			}
			finally
			{
				GC.KeepAlive(purchaseTypes);
				GC.KeepAlive(callback);
			}
		}

		// Token: 0x06000369 RID: 873 RVA: 0x00009CA4 File Offset: 0x00007EA4
		[Register("stopPurchaseTracking", "(Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", "")]
		public unsafe static void StopPurchaseTracking(WebViewCallback callback)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((callback == null) ? IntPtr.Zero : callback.Handle);
				Store._members.StaticMethods.InvokeVoidMethod("stopPurchaseTracking.(Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", ptr);
			}
			finally
			{
				GC.KeepAlive(callback);
			}
		}

		// Token: 0x040000AB RID: 171
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/services/store/core/api/Store", typeof(Store));
	}
}
