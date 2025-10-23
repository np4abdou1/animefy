using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Com.Unity3d.Services.Store.Core;
using Java.Interop;
using Java.Lang;

namespace Com.Unity3d.Services.Store
{
	// Token: 0x02000037 RID: 55
	[Register("com/unity3d/services/store/StoreMonitor", DoNotGenerateAcw = true)]
	public class StoreMonitor : Java.Lang.Object
	{
		// Token: 0x17000035 RID: 53
		// (get) Token: 0x060000FE RID: 254 RVA: 0x00002CD8 File Offset: 0x00000ED8
		internal static IntPtr class_ref
		{
			get
			{
				return StoreMonitor._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000036 RID: 54
		// (get) Token: 0x060000FF RID: 255 RVA: 0x00002CFC File Offset: 0x00000EFC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return StoreMonitor._members;
			}
		}

		// Token: 0x17000037 RID: 55
		// (get) Token: 0x06000100 RID: 256 RVA: 0x00002D04 File Offset: 0x00000F04
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return StoreMonitor._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000038 RID: 56
		// (get) Token: 0x06000101 RID: 257 RVA: 0x00002D28 File Offset: 0x00000F28
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return StoreMonitor._members.ManagedPeerType;
			}
		}

		// Token: 0x06000102 RID: 258 RVA: 0x000021E8 File Offset: 0x000003E8
		protected StoreMonitor(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000103 RID: 259 RVA: 0x00002D34 File Offset: 0x00000F34
		[Register(".ctor", "()V", "")]
		public StoreMonitor() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			base.SetHandle(StoreMonitor._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
			StoreMonitor._members.InstanceMethods.FinishCreateInstance("()V", this, null);
		}

		// Token: 0x17000039 RID: 57
		// (get) Token: 0x06000104 RID: 260 RVA: 0x00002DA2 File Offset: 0x00000FA2
		public static bool IsInitialized
		{
			[Register("isInitialized", "()Z", "")]
			get
			{
				return StoreMonitor._members.StaticMethods.InvokeBooleanMethod("isInitialized.()Z", null);
			}
		}

		// Token: 0x06000105 RID: 261 RVA: 0x00002DBC File Offset: 0x00000FBC
		[Register("getPurchaseHistory", "(ILjava/lang/String;I)V", "")]
		public unsafe static void GetPurchaseHistory(int operationId, string purchaseType, int maxPurchases)
		{
			IntPtr intPtr = JNIEnv.NewString(purchaseType);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(operationId);
				ptr[1] = new JniArgumentValue(intPtr);
				ptr[2] = new JniArgumentValue(maxPurchases);
				StoreMonitor._members.StaticMethods.InvokeVoidMethod("getPurchaseHistory.(ILjava/lang/String;I)V", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
		}

		// Token: 0x06000106 RID: 262 RVA: 0x00002E40 File Offset: 0x00001040
		[Register("getPurchases", "(ILjava/lang/String;)V", "")]
		public unsafe static void GetPurchases(int operationId, string purchaseType)
		{
			IntPtr intPtr = JNIEnv.NewString(purchaseType);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(operationId);
				ptr[1] = new JniArgumentValue(intPtr);
				StoreMonitor._members.StaticMethods.InvokeVoidMethod("getPurchases.(ILjava/lang/String;)V", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
		}

		// Token: 0x06000107 RID: 263 RVA: 0x00002EB0 File Offset: 0x000010B0
		[Register("getSkuDetails", "(ILjava/lang/String;Ljava/util/ArrayList;)V", "")]
		public unsafe static void GetSkuDetails(int operationId, string purchaseType, IList<string> skuList)
		{
			IntPtr intPtr = JNIEnv.NewString(purchaseType);
			IntPtr intPtr2 = JavaList<string>.ToLocalJniHandle(skuList);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(operationId);
				ptr[1] = new JniArgumentValue(intPtr);
				ptr[2] = new JniArgumentValue(intPtr2);
				StoreMonitor._members.StaticMethods.InvokeVoidMethod("getSkuDetails.(ILjava/lang/String;Ljava/util/ArrayList;)V", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				JNIEnv.DeleteLocalRef(intPtr2);
				GC.KeepAlive(skuList);
			}
		}

		// Token: 0x06000108 RID: 264 RVA: 0x00002F48 File Offset: 0x00001148
		[Register("initialize", "(Lcom/unity3d/services/store/core/StoreExceptionHandler;)V", "")]
		public unsafe static void Initialize(StoreExceptionHandler storeExceptionHandler)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((storeExceptionHandler == null) ? IntPtr.Zero : storeExceptionHandler.Handle);
				StoreMonitor._members.StaticMethods.InvokeVoidMethod("initialize.(Lcom/unity3d/services/store/core/StoreExceptionHandler;)V", ptr);
			}
			finally
			{
				GC.KeepAlive(storeExceptionHandler);
			}
		}

		// Token: 0x06000109 RID: 265 RVA: 0x00002FAC File Offset: 0x000011AC
		[Register("isFeatureSupported", "(ILjava/lang/String;)I", "")]
		public unsafe static int IsFeatureSupported(int operationId, string purchaseType)
		{
			IntPtr intPtr = JNIEnv.NewString(purchaseType);
			int result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(operationId);
				ptr[1] = new JniArgumentValue(intPtr);
				result = StoreMonitor._members.StaticMethods.InvokeInt32Method("isFeatureSupported.(ILjava/lang/String;)I", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
			return result;
		}

		// Token: 0x0600010A RID: 266 RVA: 0x0000301C File Offset: 0x0000121C
		[Register("startPurchaseTracking", "(Ljava/util/ArrayList;)V", "")]
		public unsafe static void StartPurchaseTracking(IList<string> purchaseTypes)
		{
			IntPtr intPtr = JavaList<string>.ToLocalJniHandle(purchaseTypes);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				StoreMonitor._members.StaticMethods.InvokeVoidMethod("startPurchaseTracking.(Ljava/util/ArrayList;)V", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(purchaseTypes);
			}
		}

		// Token: 0x0600010B RID: 267 RVA: 0x0000307C File Offset: 0x0000127C
		[Register("stopPurchaseTracking", "()V", "")]
		public static void StopPurchaseTracking()
		{
			StoreMonitor._members.StaticMethods.InvokeVoidMethod("stopPurchaseTracking.()V", null);
		}

		// Token: 0x0400000A RID: 10
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/services/store/StoreMonitor", typeof(StoreMonitor));
	}
}
