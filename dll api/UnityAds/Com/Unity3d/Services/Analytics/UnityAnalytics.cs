using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;
using Org.Json;

namespace Com.Unity3d.Services.Analytics
{
	// Token: 0x020001C4 RID: 452
	[Register("com/unity3d/services/analytics/UnityAnalytics", DoNotGenerateAcw = true)]
	public class UnityAnalytics : Java.Lang.Object
	{
		// Token: 0x17000700 RID: 1792
		// (get) Token: 0x06001431 RID: 5169 RVA: 0x00039754 File Offset: 0x00037954
		// (set) Token: 0x06001432 RID: 5170 RVA: 0x00039784 File Offset: 0x00037984
		[Register("eventQueue")]
		protected static JSONArray EventQueue
		{
			get
			{
				return Java.Lang.Object.GetObject<JSONArray>(UnityAnalytics._members.StaticFields.GetObjectValue("eventQueue.Lorg/json/JSONArray;").Handle, JniHandleOwnership.TransferLocalRef);
			}
			set
			{
				IntPtr intPtr = JNIEnv.ToLocalJniHandle(value);
				try
				{
					UnityAnalytics._members.StaticFields.SetValue("eventQueue.Lorg/json/JSONArray;", new JniObjectReference(intPtr, JniObjectReferenceType.Invalid));
				}
				finally
				{
					JNIEnv.DeleteLocalRef(intPtr);
				}
			}
		}

		// Token: 0x17000701 RID: 1793
		// (get) Token: 0x06001433 RID: 5171 RVA: 0x000397CC File Offset: 0x000379CC
		internal static IntPtr class_ref
		{
			get
			{
				return UnityAnalytics._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000702 RID: 1794
		// (get) Token: 0x06001434 RID: 5172 RVA: 0x000397F0 File Offset: 0x000379F0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return UnityAnalytics._members;
			}
		}

		// Token: 0x17000703 RID: 1795
		// (get) Token: 0x06001435 RID: 5173 RVA: 0x000397F8 File Offset: 0x000379F8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return UnityAnalytics._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000704 RID: 1796
		// (get) Token: 0x06001436 RID: 5174 RVA: 0x0003981C File Offset: 0x00037A1C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return UnityAnalytics._members.ManagedPeerType;
			}
		}

		// Token: 0x06001437 RID: 5175 RVA: 0x000021E8 File Offset: 0x000003E8
		protected UnityAnalytics(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06001438 RID: 5176 RVA: 0x00039828 File Offset: 0x00037A28
		[Register(".ctor", "()V", "")]
		public UnityAnalytics() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			base.SetHandle(UnityAnalytics._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
			UnityAnalytics._members.InstanceMethods.FinishCreateInstance("()V", this, null);
		}

		// Token: 0x06001439 RID: 5177 RVA: 0x00039898 File Offset: 0x00037A98
		[Register("onAdComplete", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/Boolean;)V", "")]
		public unsafe static void OnAdComplete(string network, string placementId, Java.Lang.Boolean rewarded)
		{
			IntPtr intPtr = JNIEnv.NewString(network);
			IntPtr intPtr2 = JNIEnv.NewString(placementId);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(intPtr2);
				ptr[2] = new JniArgumentValue((rewarded == null) ? IntPtr.Zero : rewarded.Handle);
				UnityAnalytics._members.StaticMethods.InvokeVoidMethod("onAdComplete.(Ljava/lang/String;Ljava/lang/String;Ljava/lang/Boolean;)V", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				JNIEnv.DeleteLocalRef(intPtr2);
				GC.KeepAlive(rewarded);
			}
		}

		// Token: 0x0600143A RID: 5178 RVA: 0x00039940 File Offset: 0x00037B40
		[Register("onEvent", "(Lorg/json/JSONObject;)V", "")]
		public unsafe static void OnEvent(JSONObject jsonEvent)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((jsonEvent == null) ? IntPtr.Zero : jsonEvent.Handle);
				UnityAnalytics._members.StaticMethods.InvokeVoidMethod("onEvent.(Lorg/json/JSONObject;)V", ptr);
			}
			finally
			{
				GC.KeepAlive(jsonEvent);
			}
		}

		// Token: 0x0600143B RID: 5179 RVA: 0x000399A4 File Offset: 0x00037BA4
		[Register("onIapTransaction", "(Ljava/lang/String;Ljava/lang/Float;Ljava/lang/String;Ljava/lang/Boolean;Ljava/lang/String;)V", "")]
		public unsafe static void OnIapTransaction(string productId, Float amount, string currency, Java.Lang.Boolean isPromo, string receipt)
		{
			IntPtr intPtr = JNIEnv.NewString(productId);
			IntPtr intPtr2 = JNIEnv.NewString(currency);
			IntPtr intPtr3 = JNIEnv.NewString(receipt);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((amount == null) ? IntPtr.Zero : amount.Handle);
				ptr[2] = new JniArgumentValue(intPtr2);
				ptr[3] = new JniArgumentValue((isPromo == null) ? IntPtr.Zero : isPromo.Handle);
				ptr[4] = new JniArgumentValue(intPtr3);
				UnityAnalytics._members.StaticMethods.InvokeVoidMethod("onIapTransaction.(Ljava/lang/String;Ljava/lang/Float;Ljava/lang/String;Ljava/lang/Boolean;Ljava/lang/String;)V", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				JNIEnv.DeleteLocalRef(intPtr2);
				JNIEnv.DeleteLocalRef(intPtr3);
				GC.KeepAlive(amount);
				GC.KeepAlive(isPromo);
			}
		}

		// Token: 0x0600143C RID: 5180 RVA: 0x00039A98 File Offset: 0x00037C98
		[Register("onItemAcquired", "(Ljava/lang/String;Ljava/lang/Float;Ljava/lang/String;Ljava/lang/Float;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Lcom/unity3d/services/analytics/AcquisitionType;)V", "")]
		public unsafe static void OnItemAcquired(string transactionContext, Float amount, string itemId, Float balance, string itemType, string level, string transactionId, AcquisitionType acquisitionType)
		{
			IntPtr intPtr = JNIEnv.NewString(transactionContext);
			IntPtr intPtr2 = JNIEnv.NewString(itemId);
			IntPtr intPtr3 = JNIEnv.NewString(itemType);
			IntPtr intPtr4 = JNIEnv.NewString(level);
			IntPtr intPtr5 = JNIEnv.NewString(transactionId);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((amount == null) ? IntPtr.Zero : amount.Handle);
				ptr[2] = new JniArgumentValue(intPtr2);
				ptr[3] = new JniArgumentValue((balance == null) ? IntPtr.Zero : balance.Handle);
				ptr[4] = new JniArgumentValue(intPtr3);
				ptr[5] = new JniArgumentValue(intPtr4);
				ptr[6] = new JniArgumentValue(intPtr5);
				ptr[7] = new JniArgumentValue((acquisitionType == null) ? IntPtr.Zero : acquisitionType.Handle);
				UnityAnalytics._members.StaticMethods.InvokeVoidMethod("onItemAcquired.(Ljava/lang/String;Ljava/lang/Float;Ljava/lang/String;Ljava/lang/Float;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Lcom/unity3d/services/analytics/AcquisitionType;)V", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				JNIEnv.DeleteLocalRef(intPtr2);
				JNIEnv.DeleteLocalRef(intPtr3);
				JNIEnv.DeleteLocalRef(intPtr4);
				JNIEnv.DeleteLocalRef(intPtr5);
				GC.KeepAlive(amount);
				GC.KeepAlive(balance);
				GC.KeepAlive(acquisitionType);
			}
		}

		// Token: 0x0600143D RID: 5181 RVA: 0x00039C1C File Offset: 0x00037E1C
		[Register("onItemSpent", "(Ljava/lang/String;Ljava/lang/Float;Ljava/lang/String;Ljava/lang/Float;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Lcom/unity3d/services/analytics/AcquisitionType;)V", "")]
		public unsafe static void OnItemSpent(string transactionContext, Float amount, string itemId, Float balance, string itemType, string level, string transactionId, AcquisitionType acquisitionType)
		{
			IntPtr intPtr = JNIEnv.NewString(transactionContext);
			IntPtr intPtr2 = JNIEnv.NewString(itemId);
			IntPtr intPtr3 = JNIEnv.NewString(itemType);
			IntPtr intPtr4 = JNIEnv.NewString(level);
			IntPtr intPtr5 = JNIEnv.NewString(transactionId);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((amount == null) ? IntPtr.Zero : amount.Handle);
				ptr[2] = new JniArgumentValue(intPtr2);
				ptr[3] = new JniArgumentValue((balance == null) ? IntPtr.Zero : balance.Handle);
				ptr[4] = new JniArgumentValue(intPtr3);
				ptr[5] = new JniArgumentValue(intPtr4);
				ptr[6] = new JniArgumentValue(intPtr5);
				ptr[7] = new JniArgumentValue((acquisitionType == null) ? IntPtr.Zero : acquisitionType.Handle);
				UnityAnalytics._members.StaticMethods.InvokeVoidMethod("onItemSpent.(Ljava/lang/String;Ljava/lang/Float;Ljava/lang/String;Ljava/lang/Float;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Lcom/unity3d/services/analytics/AcquisitionType;)V", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				JNIEnv.DeleteLocalRef(intPtr2);
				JNIEnv.DeleteLocalRef(intPtr3);
				JNIEnv.DeleteLocalRef(intPtr4);
				JNIEnv.DeleteLocalRef(intPtr5);
				GC.KeepAlive(amount);
				GC.KeepAlive(balance);
				GC.KeepAlive(acquisitionType);
			}
		}

		// Token: 0x0600143E RID: 5182 RVA: 0x00039DA0 File Offset: 0x00037FA0
		[Register("onLevelFail", "(Ljava/lang/String;)V", "")]
		public unsafe static void OnLevelFail(string levelIndex)
		{
			IntPtr intPtr = JNIEnv.NewString(levelIndex);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				UnityAnalytics._members.StaticMethods.InvokeVoidMethod("onLevelFail.(Ljava/lang/String;)V", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
		}

		// Token: 0x0600143F RID: 5183 RVA: 0x00039DFC File Offset: 0x00037FFC
		[Register("onLevelUp", "(Ljava/lang/String;)V", "")]
		public unsafe static void OnLevelUp(string newLevelIndex)
		{
			IntPtr intPtr = JNIEnv.NewString(newLevelIndex);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				UnityAnalytics._members.StaticMethods.InvokeVoidMethod("onLevelUp.(Ljava/lang/String;)V", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
		}

		// Token: 0x040004D4 RID: 1236
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/services/analytics/UnityAnalytics", typeof(UnityAnalytics));
	}
}
