using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.App;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Com.Adcolony.Sdk
{
	// Token: 0x0200003B RID: 59
	[Register("com/adcolony/sdk/AdColony", DoNotGenerateAcw = true)]
	public class AdColony : Java.Lang.Object
	{
		// Token: 0x170000A6 RID: 166
		// (get) Token: 0x06000201 RID: 513 RVA: 0x0000642C File Offset: 0x0000462C
		internal static IntPtr class_ref
		{
			get
			{
				return AdColony._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170000A7 RID: 167
		// (get) Token: 0x06000202 RID: 514 RVA: 0x00006450 File Offset: 0x00004650
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return AdColony._members;
			}
		}

		// Token: 0x170000A8 RID: 168
		// (get) Token: 0x06000203 RID: 515 RVA: 0x00006458 File Offset: 0x00004658
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return AdColony._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170000A9 RID: 169
		// (get) Token: 0x06000204 RID: 516 RVA: 0x0000647C File Offset: 0x0000467C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return AdColony._members.ManagedPeerType;
			}
		}

		// Token: 0x06000205 RID: 517 RVA: 0x00002128 File Offset: 0x00000328
		protected AdColony(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000206 RID: 518 RVA: 0x00006488 File Offset: 0x00004688
		[Register(".ctor", "()V", "")]
		public AdColony() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			base.SetHandle(AdColony._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
			AdColony._members.InstanceMethods.FinishCreateInstance("()V", this, null);
		}

		// Token: 0x170000AA RID: 170
		// (get) Token: 0x06000207 RID: 519 RVA: 0x000064F8 File Offset: 0x000046F8
		public static AdColonyAppOptions AppOptions
		{
			[Register("getAppOptions", "()Lcom/adcolony/sdk/AdColonyAppOptions;", "")]
			get
			{
				return Java.Lang.Object.GetObject<AdColonyAppOptions>(AdColony._members.StaticMethods.InvokeObjectMethod("getAppOptions.()Lcom/adcolony/sdk/AdColonyAppOptions;", null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x170000AB RID: 171
		// (get) Token: 0x06000208 RID: 520 RVA: 0x0000652C File Offset: 0x0000472C
		public static IAdColonyRewardListener RewardListener
		{
			[Register("getRewardListener", "()Lcom/adcolony/sdk/AdColonyRewardListener;", "")]
			get
			{
				return Java.Lang.Object.GetObject<IAdColonyRewardListener>(AdColony._members.StaticMethods.InvokeObjectMethod("getRewardListener.()Lcom/adcolony/sdk/AdColonyRewardListener;", null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x170000AC RID: 172
		// (get) Token: 0x06000209 RID: 521 RVA: 0x00006560 File Offset: 0x00004760
		public static string SDKVersion
		{
			[Register("getSDKVersion", "()Ljava/lang/String;", "")]
			get
			{
				return JNIEnv.GetString(AdColony._members.StaticMethods.InvokeObjectMethod("getSDKVersion.()Ljava/lang/String;", null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x0600020A RID: 522 RVA: 0x00006594 File Offset: 0x00004794
		[Register("addCustomMessageListener", "(Lcom/adcolony/sdk/AdColonyCustomMessageListener;Ljava/lang/String;)Z", "")]
		public unsafe static bool AddCustomMessageListener(IAdColonyCustomMessageListener listener, string type)
		{
			IntPtr intPtr = JNIEnv.NewString(type);
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((listener == null) ? IntPtr.Zero : ((Java.Lang.Object)listener).Handle);
				ptr[1] = new JniArgumentValue(intPtr);
				result = AdColony._members.StaticMethods.InvokeBooleanMethod("addCustomMessageListener.(Lcom/adcolony/sdk/AdColonyCustomMessageListener;Ljava/lang/String;)Z", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(listener);
			}
			return result;
		}

		// Token: 0x0600020B RID: 523 RVA: 0x00006620 File Offset: 0x00004820
		[Register("clearCustomMessageListeners", "()Z", "")]
		public static bool ClearCustomMessageListeners()
		{
			return AdColony._members.StaticMethods.InvokeBooleanMethod("clearCustomMessageListeners.()Z", null);
		}

		// Token: 0x0600020C RID: 524 RVA: 0x00006638 File Offset: 0x00004838
		[Obsolete("deprecated")]
		[Register("collectSignals", "()Ljava/lang/String;", "")]
		public static string CollectSignals()
		{
			return JNIEnv.GetString(AdColony._members.StaticMethods.InvokeObjectMethod("collectSignals.()Ljava/lang/String;", null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x0600020D RID: 525 RVA: 0x0000666C File Offset: 0x0000486C
		[Register("collectSignals", "(Lcom/adcolony/sdk/AdColonySignalsListener;)V", "")]
		public unsafe static void CollectSignals(AdColonySignalsListener listener)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((listener == null) ? IntPtr.Zero : listener.Handle);
				AdColony._members.StaticMethods.InvokeVoidMethod("collectSignals.(Lcom/adcolony/sdk/AdColonySignalsListener;)V", ptr);
			}
			finally
			{
				GC.KeepAlive(listener);
			}
		}

		// Token: 0x0600020E RID: 526 RVA: 0x000066D0 File Offset: 0x000048D0
		[Register("configure", "(Landroid/app/Activity;Lcom/adcolony/sdk/AdColonyAppOptions;Ljava/lang/String;)Z", "")]
		public unsafe static bool Configure(Activity activity, AdColonyAppOptions options, string appId)
		{
			IntPtr intPtr = JNIEnv.NewString(appId);
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((activity == null) ? IntPtr.Zero : activity.Handle);
				ptr[1] = new JniArgumentValue((options == null) ? IntPtr.Zero : options.Handle);
				ptr[2] = new JniArgumentValue(intPtr);
				result = AdColony._members.StaticMethods.InvokeBooleanMethod("configure.(Landroid/app/Activity;Lcom/adcolony/sdk/AdColonyAppOptions;Ljava/lang/String;)Z", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(activity);
				GC.KeepAlive(options);
			}
			return result;
		}

		// Token: 0x0600020F RID: 527 RVA: 0x00006780 File Offset: 0x00004980
		[Obsolete("deprecated")]
		[Register("configure", "(Landroid/app/Activity;Lcom/adcolony/sdk/AdColonyAppOptions;Ljava/lang/String;[Ljava/lang/String;)Z", "")]
		public unsafe static bool Configure(Activity activity, AdColonyAppOptions options, string appId, params string[] zoneIds)
		{
			IntPtr intPtr = JNIEnv.NewString(appId);
			IntPtr intPtr2 = JNIEnv.NewArray(zoneIds);
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((activity == null) ? IntPtr.Zero : activity.Handle);
				ptr[1] = new JniArgumentValue((options == null) ? IntPtr.Zero : options.Handle);
				ptr[2] = new JniArgumentValue(intPtr);
				ptr[3] = new JniArgumentValue(intPtr2);
				result = AdColony._members.StaticMethods.InvokeBooleanMethod("configure.(Landroid/app/Activity;Lcom/adcolony/sdk/AdColonyAppOptions;Ljava/lang/String;[Ljava/lang/String;)Z", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				if (zoneIds != null)
				{
					JNIEnv.CopyArray(intPtr2, zoneIds);
					JNIEnv.DeleteLocalRef(intPtr2);
				}
				GC.KeepAlive(activity);
				GC.KeepAlive(options);
				GC.KeepAlive(zoneIds);
			}
			return result;
		}

		// Token: 0x06000210 RID: 528 RVA: 0x00006864 File Offset: 0x00004A64
		[Register("configure", "(Landroid/app/Activity;Ljava/lang/String;)Z", "")]
		public unsafe static bool Configure(Activity activity, string appId)
		{
			IntPtr intPtr = JNIEnv.NewString(appId);
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((activity == null) ? IntPtr.Zero : activity.Handle);
				ptr[1] = new JniArgumentValue(intPtr);
				result = AdColony._members.StaticMethods.InvokeBooleanMethod("configure.(Landroid/app/Activity;Ljava/lang/String;)Z", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(activity);
			}
			return result;
		}

		// Token: 0x06000211 RID: 529 RVA: 0x000068E8 File Offset: 0x00004AE8
		[Obsolete("deprecated")]
		[Register("configure", "(Landroid/app/Activity;Ljava/lang/String;[Ljava/lang/String;)Z", "")]
		public unsafe static bool Configure(Activity activity, string appId, params string[] zoneIds)
		{
			IntPtr intPtr = JNIEnv.NewString(appId);
			IntPtr intPtr2 = JNIEnv.NewArray(zoneIds);
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((activity == null) ? IntPtr.Zero : activity.Handle);
				ptr[1] = new JniArgumentValue(intPtr);
				ptr[2] = new JniArgumentValue(intPtr2);
				result = AdColony._members.StaticMethods.InvokeBooleanMethod("configure.(Landroid/app/Activity;Ljava/lang/String;[Ljava/lang/String;)Z", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				if (zoneIds != null)
				{
					JNIEnv.CopyArray(intPtr2, zoneIds);
					JNIEnv.DeleteLocalRef(intPtr2);
				}
				GC.KeepAlive(activity);
				GC.KeepAlive(zoneIds);
			}
			return result;
		}

		// Token: 0x06000212 RID: 530 RVA: 0x000069A0 File Offset: 0x00004BA0
		[Register("configure", "(Landroid/app/Application;Lcom/adcolony/sdk/AdColonyAppOptions;Ljava/lang/String;)Z", "")]
		public unsafe static bool Configure(Application app, AdColonyAppOptions options, string appId)
		{
			IntPtr intPtr = JNIEnv.NewString(appId);
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((app == null) ? IntPtr.Zero : app.Handle);
				ptr[1] = new JniArgumentValue((options == null) ? IntPtr.Zero : options.Handle);
				ptr[2] = new JniArgumentValue(intPtr);
				result = AdColony._members.StaticMethods.InvokeBooleanMethod("configure.(Landroid/app/Application;Lcom/adcolony/sdk/AdColonyAppOptions;Ljava/lang/String;)Z", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(app);
				GC.KeepAlive(options);
			}
			return result;
		}

		// Token: 0x06000213 RID: 531 RVA: 0x00006A50 File Offset: 0x00004C50
		[Obsolete("deprecated")]
		[Register("configure", "(Landroid/app/Application;Lcom/adcolony/sdk/AdColonyAppOptions;Ljava/lang/String;[Ljava/lang/String;)Z", "")]
		public unsafe static bool Configure(Application app, AdColonyAppOptions options, string appId, params string[] zoneIds)
		{
			IntPtr intPtr = JNIEnv.NewString(appId);
			IntPtr intPtr2 = JNIEnv.NewArray(zoneIds);
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((app == null) ? IntPtr.Zero : app.Handle);
				ptr[1] = new JniArgumentValue((options == null) ? IntPtr.Zero : options.Handle);
				ptr[2] = new JniArgumentValue(intPtr);
				ptr[3] = new JniArgumentValue(intPtr2);
				result = AdColony._members.StaticMethods.InvokeBooleanMethod("configure.(Landroid/app/Application;Lcom/adcolony/sdk/AdColonyAppOptions;Ljava/lang/String;[Ljava/lang/String;)Z", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				if (zoneIds != null)
				{
					JNIEnv.CopyArray(intPtr2, zoneIds);
					JNIEnv.DeleteLocalRef(intPtr2);
				}
				GC.KeepAlive(app);
				GC.KeepAlive(options);
				GC.KeepAlive(zoneIds);
			}
			return result;
		}

		// Token: 0x06000214 RID: 532 RVA: 0x00006B34 File Offset: 0x00004D34
		[Register("configure", "(Landroid/app/Application;Ljava/lang/String;)Z", "")]
		public unsafe static bool Configure(Application app, string appId)
		{
			IntPtr intPtr = JNIEnv.NewString(appId);
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((app == null) ? IntPtr.Zero : app.Handle);
				ptr[1] = new JniArgumentValue(intPtr);
				result = AdColony._members.StaticMethods.InvokeBooleanMethod("configure.(Landroid/app/Application;Ljava/lang/String;)Z", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(app);
			}
			return result;
		}

		// Token: 0x06000215 RID: 533 RVA: 0x00006BB8 File Offset: 0x00004DB8
		[Obsolete("deprecated")]
		[Register("configure", "(Landroid/app/Application;Ljava/lang/String;[Ljava/lang/String;)Z", "")]
		public unsafe static bool Configure(Application app, string appId, params string[] zoneIds)
		{
			IntPtr intPtr = JNIEnv.NewString(appId);
			IntPtr intPtr2 = JNIEnv.NewArray(zoneIds);
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((app == null) ? IntPtr.Zero : app.Handle);
				ptr[1] = new JniArgumentValue(intPtr);
				ptr[2] = new JniArgumentValue(intPtr2);
				result = AdColony._members.StaticMethods.InvokeBooleanMethod("configure.(Landroid/app/Application;Ljava/lang/String;[Ljava/lang/String;)Z", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				if (zoneIds != null)
				{
					JNIEnv.CopyArray(intPtr2, zoneIds);
					JNIEnv.DeleteLocalRef(intPtr2);
				}
				GC.KeepAlive(app);
				GC.KeepAlive(zoneIds);
			}
			return result;
		}

		// Token: 0x06000216 RID: 534 RVA: 0x00006C70 File Offset: 0x00004E70
		[Register("disable", "()Z", "")]
		public static bool Disable()
		{
			return AdColony._members.StaticMethods.InvokeBooleanMethod("disable.()Z", null);
		}

		// Token: 0x06000217 RID: 535 RVA: 0x00006C88 File Offset: 0x00004E88
		[Register("getCustomMessageListener", "(Ljava/lang/String;)Lcom/adcolony/sdk/AdColonyCustomMessageListener;", "")]
		public unsafe static IAdColonyCustomMessageListener GetCustomMessageListener(string type)
		{
			IntPtr intPtr = JNIEnv.NewString(type);
			IAdColonyCustomMessageListener @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<IAdColonyCustomMessageListener>(AdColony._members.StaticMethods.InvokeObjectMethod("getCustomMessageListener.(Ljava/lang/String;)Lcom/adcolony/sdk/AdColonyCustomMessageListener;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
			return @object;
		}

		// Token: 0x06000218 RID: 536 RVA: 0x00006CF4 File Offset: 0x00004EF4
		[Register("getZone", "(Ljava/lang/String;)Lcom/adcolony/sdk/AdColonyZone;", "")]
		public unsafe static AdColonyZone GetZone(string zoneId)
		{
			IntPtr intPtr = JNIEnv.NewString(zoneId);
			AdColonyZone @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<AdColonyZone>(AdColony._members.StaticMethods.InvokeObjectMethod("getZone.(Ljava/lang/String;)Lcom/adcolony/sdk/AdColonyZone;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
			return @object;
		}

		// Token: 0x06000219 RID: 537 RVA: 0x00006D60 File Offset: 0x00004F60
		[Register("notifyIAPComplete", "(Ljava/lang/String;Ljava/lang/String;)Z", "")]
		public unsafe static bool NotifyIAPComplete(string productId, string transId)
		{
			IntPtr intPtr = JNIEnv.NewString(productId);
			IntPtr intPtr2 = JNIEnv.NewString(transId);
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(intPtr2);
				result = AdColony._members.StaticMethods.InvokeBooleanMethod("notifyIAPComplete.(Ljava/lang/String;Ljava/lang/String;)Z", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				JNIEnv.DeleteLocalRef(intPtr2);
			}
			return result;
		}

		// Token: 0x0600021A RID: 538 RVA: 0x00006DDC File Offset: 0x00004FDC
		[Register("notifyIAPComplete", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;D)Z", "")]
		public unsafe static bool NotifyIAPComplete(string productId, string transId, string currencyCode, double price)
		{
			IntPtr intPtr = JNIEnv.NewString(productId);
			IntPtr intPtr2 = JNIEnv.NewString(transId);
			IntPtr intPtr3 = JNIEnv.NewString(currencyCode);
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(intPtr2);
				ptr[2] = new JniArgumentValue(intPtr3);
				ptr[3] = new JniArgumentValue(price);
				result = AdColony._members.StaticMethods.InvokeBooleanMethod("notifyIAPComplete.(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;D)Z", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				JNIEnv.DeleteLocalRef(intPtr2);
				JNIEnv.DeleteLocalRef(intPtr3);
			}
			return result;
		}

		// Token: 0x0600021B RID: 539 RVA: 0x00006E94 File Offset: 0x00005094
		[Register("removeCustomMessageListener", "(Ljava/lang/String;)Z", "")]
		public unsafe static bool RemoveCustomMessageListener(string type)
		{
			IntPtr intPtr = JNIEnv.NewString(type);
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				result = AdColony._members.StaticMethods.InvokeBooleanMethod("removeCustomMessageListener.(Ljava/lang/String;)Z", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
			return result;
		}

		// Token: 0x0600021C RID: 540 RVA: 0x00006EF0 File Offset: 0x000050F0
		[Register("removeRewardListener", "()Z", "")]
		public static bool RemoveRewardListener()
		{
			return AdColony._members.StaticMethods.InvokeBooleanMethod("removeRewardListener.()Z", null);
		}

		// Token: 0x0600021D RID: 541 RVA: 0x00006F08 File Offset: 0x00005108
		[Register("requestAdView", "(Ljava/lang/String;Lcom/adcolony/sdk/AdColonyAdViewListener;Lcom/adcolony/sdk/AdColonyAdSize;)Z", "")]
		public unsafe static bool RequestAdView(string zoneId, AdColonyAdViewListener listener, AdColonyAdSize size)
		{
			IntPtr intPtr = JNIEnv.NewString(zoneId);
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((listener == null) ? IntPtr.Zero : listener.Handle);
				ptr[2] = new JniArgumentValue((size == null) ? IntPtr.Zero : size.Handle);
				result = AdColony._members.StaticMethods.InvokeBooleanMethod("requestAdView.(Ljava/lang/String;Lcom/adcolony/sdk/AdColonyAdViewListener;Lcom/adcolony/sdk/AdColonyAdSize;)Z", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(listener);
				GC.KeepAlive(size);
			}
			return result;
		}

		// Token: 0x0600021E RID: 542 RVA: 0x00006FB8 File Offset: 0x000051B8
		[Register("requestAdView", "(Ljava/lang/String;Lcom/adcolony/sdk/AdColonyAdViewListener;Lcom/adcolony/sdk/AdColonyAdSize;Lcom/adcolony/sdk/AdColonyAdOptions;)Z", "")]
		public unsafe static bool RequestAdView(string zoneId, AdColonyAdViewListener listener, AdColonyAdSize size, AdColonyAdOptions options)
		{
			IntPtr intPtr = JNIEnv.NewString(zoneId);
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((listener == null) ? IntPtr.Zero : listener.Handle);
				ptr[2] = new JniArgumentValue((size == null) ? IntPtr.Zero : size.Handle);
				ptr[3] = new JniArgumentValue((options == null) ? IntPtr.Zero : options.Handle);
				result = AdColony._members.StaticMethods.InvokeBooleanMethod("requestAdView.(Ljava/lang/String;Lcom/adcolony/sdk/AdColonyAdViewListener;Lcom/adcolony/sdk/AdColonyAdSize;Lcom/adcolony/sdk/AdColonyAdOptions;)Z", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(listener);
				GC.KeepAlive(size);
				GC.KeepAlive(options);
			}
			return result;
		}

		// Token: 0x0600021F RID: 543 RVA: 0x00007094 File Offset: 0x00005294
		[Register("requestInterstitial", "(Ljava/lang/String;Lcom/adcolony/sdk/AdColonyInterstitialListener;)Z", "")]
		public unsafe static bool RequestInterstitial(string zoneId, AdColonyInterstitialListener listener)
		{
			IntPtr intPtr = JNIEnv.NewString(zoneId);
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((listener == null) ? IntPtr.Zero : listener.Handle);
				result = AdColony._members.StaticMethods.InvokeBooleanMethod("requestInterstitial.(Ljava/lang/String;Lcom/adcolony/sdk/AdColonyInterstitialListener;)Z", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(listener);
			}
			return result;
		}

		// Token: 0x06000220 RID: 544 RVA: 0x00007118 File Offset: 0x00005318
		[Register("requestInterstitial", "(Ljava/lang/String;Lcom/adcolony/sdk/AdColonyInterstitialListener;Lcom/adcolony/sdk/AdColonyAdOptions;)Z", "")]
		public unsafe static bool RequestInterstitial(string zoneId, AdColonyInterstitialListener listener, AdColonyAdOptions options)
		{
			IntPtr intPtr = JNIEnv.NewString(zoneId);
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((listener == null) ? IntPtr.Zero : listener.Handle);
				ptr[2] = new JniArgumentValue((options == null) ? IntPtr.Zero : options.Handle);
				result = AdColony._members.StaticMethods.InvokeBooleanMethod("requestInterstitial.(Ljava/lang/String;Lcom/adcolony/sdk/AdColonyInterstitialListener;Lcom/adcolony/sdk/AdColonyAdOptions;)Z", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(listener);
				GC.KeepAlive(options);
			}
			return result;
		}

		// Token: 0x06000221 RID: 545 RVA: 0x000071C8 File Offset: 0x000053C8
		[Register("setAppOptions", "(Lcom/adcolony/sdk/AdColonyAppOptions;)Z", "")]
		public unsafe static bool SetAppOptions(AdColonyAppOptions options)
		{
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((options == null) ? IntPtr.Zero : options.Handle);
				result = AdColony._members.StaticMethods.InvokeBooleanMethod("setAppOptions.(Lcom/adcolony/sdk/AdColonyAppOptions;)Z", ptr);
			}
			finally
			{
				GC.KeepAlive(options);
			}
			return result;
		}

		// Token: 0x06000222 RID: 546 RVA: 0x0000722C File Offset: 0x0000542C
		[Register("setRewardListener", "(Lcom/adcolony/sdk/AdColonyRewardListener;)Z", "")]
		public unsafe static bool SetRewardListener(IAdColonyRewardListener listener)
		{
			bool result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((listener == null) ? IntPtr.Zero : ((Java.Lang.Object)listener).Handle);
				result = AdColony._members.StaticMethods.InvokeBooleanMethod("setRewardListener.(Lcom/adcolony/sdk/AdColonyRewardListener;)Z", ptr);
			}
			finally
			{
				GC.KeepAlive(listener);
			}
			return result;
		}

		// Token: 0x04000059 RID: 89
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/adcolony/sdk/AdColony", typeof(AdColony));
	}
}
