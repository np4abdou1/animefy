using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using Android.Content;
using Android.Runtime;
using Com.Applovin.Mediation;
using Java.Interop;
using Java.Lang;

namespace Com.Applovin.Sdk
{
	// Token: 0x0200005A RID: 90
	[Register("com/applovin/sdk/AppLovinSdk", DoNotGenerateAcw = true)]
	public sealed class AppLovinSdk : Java.Lang.Object
	{
		// Token: 0x170000E4 RID: 228
		// (get) Token: 0x060002D9 RID: 729 RVA: 0x00007D78 File Offset: 0x00005F78
		[Register("VERSION")]
		public static string Version
		{
			get
			{
				return JNIEnv.GetString(AppLovinSdk._members.StaticFields.GetObjectValue("VERSION.Ljava/lang/String;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x170000E5 RID: 229
		// (get) Token: 0x060002DA RID: 730 RVA: 0x00007DA7 File Offset: 0x00005FA7
		[Register("VERSION_CODE")]
		public static int VersionCode
		{
			get
			{
				return AppLovinSdk._members.StaticFields.GetInt32Value("VERSION_CODE.I");
			}
		}

		// Token: 0x170000E6 RID: 230
		// (get) Token: 0x060002DB RID: 731 RVA: 0x00007DC0 File Offset: 0x00005FC0
		internal static IntPtr class_ref
		{
			get
			{
				return AppLovinSdk._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170000E7 RID: 231
		// (get) Token: 0x060002DC RID: 732 RVA: 0x00007DE4 File Offset: 0x00005FE4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return AppLovinSdk._members;
			}
		}

		// Token: 0x170000E8 RID: 232
		// (get) Token: 0x060002DD RID: 733 RVA: 0x00007DEC File Offset: 0x00005FEC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return AppLovinSdk._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170000E9 RID: 233
		// (get) Token: 0x060002DE RID: 734 RVA: 0x00007E10 File Offset: 0x00006010
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return AppLovinSdk._members.ManagedPeerType;
			}
		}

		// Token: 0x060002DF RID: 735 RVA: 0x000021F0 File Offset: 0x000003F0
		internal AppLovinSdk(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x170000EA RID: 234
		// (get) Token: 0x060002E0 RID: 736 RVA: 0x00007E1C File Offset: 0x0000601C
		public IAppLovinAdService AdService
		{
			[Register("getAdService", "()Lcom/applovin/sdk/AppLovinAdService;", "")]
			get
			{
				return Java.Lang.Object.GetObject<IAppLovinAdService>(AppLovinSdk._members.InstanceMethods.InvokeAbstractObjectMethod("getAdService.()Lcom/applovin/sdk/AppLovinAdService;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x170000EB RID: 235
		// (get) Token: 0x060002E1 RID: 737 RVA: 0x00007E50 File Offset: 0x00006050
		public IList<IMaxMediatedNetworkInfo> AvailableMediatedNetworks
		{
			[Register("getAvailableMediatedNetworks", "()Ljava/util/List;", "")]
			get
			{
				return JavaList<IMaxMediatedNetworkInfo>.FromJniHandle(AppLovinSdk._members.InstanceMethods.InvokeAbstractObjectMethod("getAvailableMediatedNetworks.()Ljava/util/List;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x170000EC RID: 236
		// (get) Token: 0x060002E2 RID: 738 RVA: 0x00007E84 File Offset: 0x00006084
		public IAppLovinSdkConfiguration Configuration
		{
			[Register("getConfiguration", "()Lcom/applovin/sdk/AppLovinSdkConfiguration;", "")]
			get
			{
				return Java.Lang.Object.GetObject<IAppLovinSdkConfiguration>(AppLovinSdk._members.InstanceMethods.InvokeAbstractObjectMethod("getConfiguration.()Lcom/applovin/sdk/AppLovinSdkConfiguration;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x170000ED RID: 237
		// (get) Token: 0x060002E3 RID: 739 RVA: 0x00007EB8 File Offset: 0x000060B8
		public IAppLovinEventService EventService
		{
			[Register("getEventService", "()Lcom/applovin/sdk/AppLovinEventService;", "")]
			get
			{
				return Java.Lang.Object.GetObject<IAppLovinEventService>(AppLovinSdk._members.InstanceMethods.InvokeAbstractObjectMethod("getEventService.()Lcom/applovin/sdk/AppLovinEventService;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x170000EE RID: 238
		// (get) Token: 0x060002E4 RID: 740 RVA: 0x00007EEA File Offset: 0x000060EA
		public bool IsEnabled
		{
			[Register("isEnabled", "()Z", "")]
			get
			{
				return AppLovinSdk._members.InstanceMethods.InvokeAbstractBooleanMethod("isEnabled.()Z", this, null);
			}
		}

		// Token: 0x170000EF RID: 239
		// (get) Token: 0x060002E5 RID: 741 RVA: 0x00007F03 File Offset: 0x00006103
		public bool IsInitialized
		{
			[Register("isInitialized", "()Z", "")]
			get
			{
				return AppLovinSdk._members.InstanceMethods.InvokeAbstractBooleanMethod("isInitialized.()Z", this, null);
			}
		}

		// Token: 0x170000F0 RID: 240
		// (get) Token: 0x060002E6 RID: 742 RVA: 0x00007F1C File Offset: 0x0000611C
		// (set) Token: 0x060002E7 RID: 743 RVA: 0x00007F50 File Offset: 0x00006150
		public unsafe string MediationProvider
		{
			[Register("getMediationProvider", "()Ljava/lang/String;", "")]
			get
			{
				return JNIEnv.GetString(AppLovinSdk._members.InstanceMethods.InvokeAbstractObjectMethod("getMediationProvider.()Ljava/lang/String;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
			[Register("setMediationProvider", "(Ljava/lang/String;)V", "")]
			set
			{
				IntPtr intPtr = JNIEnv.NewString(value);
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue(intPtr);
					AppLovinSdk._members.InstanceMethods.InvokeAbstractVoidMethod("setMediationProvider.(Ljava/lang/String;)V", this, ptr);
				}
				finally
				{
					JNIEnv.DeleteLocalRef(intPtr);
				}
			}
		}

		// Token: 0x170000F1 RID: 241
		// (get) Token: 0x060002E8 RID: 744 RVA: 0x00007FAC File Offset: 0x000061AC
		public IAppLovinPostbackService PostbackService
		{
			[Register("getPostbackService", "()Lcom/applovin/sdk/AppLovinPostbackService;", "")]
			get
			{
				return Java.Lang.Object.GetObject<IAppLovinPostbackService>(AppLovinSdk._members.InstanceMethods.InvokeAbstractObjectMethod("getPostbackService.()Lcom/applovin/sdk/AppLovinPostbackService;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x170000F2 RID: 242
		// (get) Token: 0x060002E9 RID: 745 RVA: 0x00007FE0 File Offset: 0x000061E0
		public string SdkKey
		{
			[Register("getSdkKey", "()Ljava/lang/String;", "")]
			get
			{
				return JNIEnv.GetString(AppLovinSdk._members.InstanceMethods.InvokeAbstractObjectMethod("getSdkKey.()Ljava/lang/String;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x170000F3 RID: 243
		// (get) Token: 0x060002EA RID: 746 RVA: 0x00008014 File Offset: 0x00006214
		public AppLovinSdkSettings Settings
		{
			[Register("getSettings", "()Lcom/applovin/sdk/AppLovinSdkSettings;", "")]
			get
			{
				return Java.Lang.Object.GetObject<AppLovinSdkSettings>(AppLovinSdk._members.InstanceMethods.InvokeAbstractObjectMethod("getSettings.()Lcom/applovin/sdk/AppLovinSdkSettings;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x170000F4 RID: 244
		// (get) Token: 0x060002EB RID: 747 RVA: 0x00008048 File Offset: 0x00006248
		public IAppLovinTargetingData TargetingData
		{
			[Register("getTargetingData", "()Lcom/applovin/sdk/AppLovinTargetingData;", "")]
			get
			{
				return Java.Lang.Object.GetObject<IAppLovinTargetingData>(AppLovinSdk._members.InstanceMethods.InvokeAbstractObjectMethod("getTargetingData.()Lcom/applovin/sdk/AppLovinTargetingData;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x170000F5 RID: 245
		// (get) Token: 0x060002EC RID: 748 RVA: 0x0000807C File Offset: 0x0000627C
		// (set) Token: 0x060002ED RID: 749 RVA: 0x000080B0 File Offset: 0x000062B0
		public unsafe string UserIdentifier
		{
			[Register("getUserIdentifier", "()Ljava/lang/String;", "")]
			get
			{
				return JNIEnv.GetString(AppLovinSdk._members.InstanceMethods.InvokeAbstractObjectMethod("getUserIdentifier.()Ljava/lang/String;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
			[Register("setUserIdentifier", "(Ljava/lang/String;)V", "")]
			set
			{
				IntPtr intPtr = JNIEnv.NewString(value);
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue(intPtr);
					AppLovinSdk._members.InstanceMethods.InvokeAbstractVoidMethod("setUserIdentifier.(Ljava/lang/String;)V", this, ptr);
				}
				finally
				{
					JNIEnv.DeleteLocalRef(intPtr);
				}
			}
		}

		// Token: 0x170000F6 RID: 246
		// (get) Token: 0x060002EE RID: 750 RVA: 0x0000810C File Offset: 0x0000630C
		public IAppLovinUserSegment UserSegment
		{
			[Register("getUserSegment", "()Lcom/applovin/sdk/AppLovinUserSegment;", "")]
			get
			{
				return Java.Lang.Object.GetObject<IAppLovinUserSegment>(AppLovinSdk._members.InstanceMethods.InvokeAbstractObjectMethod("getUserSegment.()Lcom/applovin/sdk/AppLovinUserSegment;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x170000F7 RID: 247
		// (get) Token: 0x060002EF RID: 751 RVA: 0x00008140 File Offset: 0x00006340
		public IAppLovinUserService UserService
		{
			[Register("getUserService", "()Lcom/applovin/sdk/AppLovinUserService;", "")]
			get
			{
				return Java.Lang.Object.GetObject<IAppLovinUserService>(AppLovinSdk._members.InstanceMethods.InvokeAbstractObjectMethod("getUserService.()Lcom/applovin/sdk/AppLovinUserService;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x170000F8 RID: 248
		// (get) Token: 0x060002F0 RID: 752 RVA: 0x00008174 File Offset: 0x00006374
		public IAppLovinVariableService VariableService
		{
			[Register("getVariableService", "()Lcom/applovin/sdk/AppLovinVariableService;", "")]
			get
			{
				return Java.Lang.Object.GetObject<IAppLovinVariableService>(AppLovinSdk._members.InstanceMethods.InvokeAbstractObjectMethod("getVariableService.()Lcom/applovin/sdk/AppLovinVariableService;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x060002F1 RID: 753 RVA: 0x000081A8 File Offset: 0x000063A8
		[Register("a", "()Ljava/util/List;", "")]
		public static IList<AppLovinSdk> A()
		{
			return JavaList<AppLovinSdk>.FromJniHandle(AppLovinSdk._members.StaticMethods.InvokeObjectMethod("a.()Ljava/util/List;", null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x060002F2 RID: 754 RVA: 0x000081DC File Offset: 0x000063DC
		[Register("getInstance", "(Landroid/content/Context;)Lcom/applovin/sdk/AppLovinSdk;", "")]
		public unsafe static AppLovinSdk GetInstance(Context p0)
		{
			AppLovinSdk @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((p0 == null) ? IntPtr.Zero : p0.Handle);
				@object = Java.Lang.Object.GetObject<AppLovinSdk>(AppLovinSdk._members.StaticMethods.InvokeObjectMethod("getInstance.(Landroid/content/Context;)Lcom/applovin/sdk/AppLovinSdk;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(p0);
			}
			return @object;
		}

		// Token: 0x060002F3 RID: 755 RVA: 0x00008250 File Offset: 0x00006450
		[Register("getInstance", "(Lcom/applovin/sdk/AppLovinSdkSettings;Landroid/content/Context;)Lcom/applovin/sdk/AppLovinSdk;", "")]
		public unsafe static AppLovinSdk GetInstance(AppLovinSdkSettings p0, Context p1)
		{
			AppLovinSdk @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((p0 == null) ? IntPtr.Zero : p0.Handle);
				ptr[1] = new JniArgumentValue((p1 == null) ? IntPtr.Zero : p1.Handle);
				@object = Java.Lang.Object.GetObject<AppLovinSdk>(AppLovinSdk._members.StaticMethods.InvokeObjectMethod("getInstance.(Lcom/applovin/sdk/AppLovinSdkSettings;Landroid/content/Context;)Lcom/applovin/sdk/AppLovinSdk;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(p0);
				GC.KeepAlive(p1);
			}
			return @object;
		}

		// Token: 0x060002F4 RID: 756 RVA: 0x000082EC File Offset: 0x000064EC
		[Register("getInstance", "(Ljava/lang/String;Lcom/applovin/sdk/AppLovinSdkSettings;Landroid/content/Context;)Lcom/applovin/sdk/AppLovinSdk;", "")]
		public unsafe static AppLovinSdk GetInstance(string p0, AppLovinSdkSettings p1, Context p2)
		{
			IntPtr intPtr = JNIEnv.NewString(p0);
			AppLovinSdk @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((p1 == null) ? IntPtr.Zero : p1.Handle);
				ptr[2] = new JniArgumentValue((p2 == null) ? IntPtr.Zero : p2.Handle);
				@object = Java.Lang.Object.GetObject<AppLovinSdk>(AppLovinSdk._members.StaticMethods.InvokeObjectMethod("getInstance.(Ljava/lang/String;Lcom/applovin/sdk/AppLovinSdkSettings;Landroid/content/Context;)Lcom/applovin/sdk/AppLovinSdk;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(p1);
				GC.KeepAlive(p2);
			}
			return @object;
		}

		// Token: 0x060002F5 RID: 757 RVA: 0x000083AC File Offset: 0x000065AC
		[Register("initializeSdk", "()V", "")]
		public void InitializeSdk()
		{
			AppLovinSdk._members.InstanceMethods.InvokeAbstractVoidMethod("initializeSdk.()V", this, null);
		}

		// Token: 0x060002F6 RID: 758 RVA: 0x000083C8 File Offset: 0x000065C8
		[Register("initializeSdk", "(Landroid/content/Context;)V", "")]
		public unsafe static void InitializeSdk(Context p0)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((p0 == null) ? IntPtr.Zero : p0.Handle);
				AppLovinSdk._members.StaticMethods.InvokeVoidMethod("initializeSdk.(Landroid/content/Context;)V", ptr);
			}
			finally
			{
				GC.KeepAlive(p0);
			}
		}

		// Token: 0x060002F7 RID: 759 RVA: 0x0000842C File Offset: 0x0000662C
		[Register("initializeSdk", "(Landroid/content/Context;Lcom/applovin/sdk/AppLovinSdk$SdkInitializationListener;)V", "")]
		public unsafe static void InitializeSdk(Context p0, AppLovinSdk.ISdkInitializationListener p1)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((p0 == null) ? IntPtr.Zero : p0.Handle);
				ptr[1] = new JniArgumentValue((p1 == null) ? IntPtr.Zero : ((Java.Lang.Object)p1).Handle);
				AppLovinSdk._members.StaticMethods.InvokeVoidMethod("initializeSdk.(Landroid/content/Context;Lcom/applovin/sdk/AppLovinSdk$SdkInitializationListener;)V", ptr);
			}
			finally
			{
				GC.KeepAlive(p0);
				GC.KeepAlive(p1);
			}
		}

		// Token: 0x060002F8 RID: 760 RVA: 0x000084BC File Offset: 0x000066BC
		[Register("initializeSdk", "(Lcom/applovin/sdk/AppLovinSdk$SdkInitializationListener;)V", "")]
		public unsafe void InitializeSdk(AppLovinSdk.ISdkInitializationListener p0)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((p0 == null) ? IntPtr.Zero : ((Java.Lang.Object)p0).Handle);
				AppLovinSdk._members.InstanceMethods.InvokeAbstractVoidMethod("initializeSdk.(Lcom/applovin/sdk/AppLovinSdk$SdkInitializationListener;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(p0);
			}
		}

		// Token: 0x060002F9 RID: 761 RVA: 0x00008524 File Offset: 0x00006724
		[Register("setPluginVersion", "(Ljava/lang/String;)V", "")]
		public unsafe void SetPluginVersion(string p0)
		{
			IntPtr intPtr = JNIEnv.NewString(p0);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				AppLovinSdk._members.InstanceMethods.InvokeAbstractVoidMethod("setPluginVersion.(Ljava/lang/String;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
		}

		// Token: 0x060002FA RID: 762 RVA: 0x00008580 File Offset: 0x00006780
		[Register("showMediationDebugger", "()V", "")]
		public void ShowMediationDebugger()
		{
			AppLovinSdk._members.InstanceMethods.InvokeAbstractVoidMethod("showMediationDebugger.()V", this, null);
		}

		// Token: 0x040000B0 RID: 176
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/applovin/sdk/AppLovinSdk", typeof(AppLovinSdk));

		// Token: 0x0200005B RID: 91
		[Register("com/applovin/sdk/AppLovinSdk$SdkInitializationListener", "", "Com.Applovin.Sdk.AppLovinSdk/ISdkInitializationListenerInvoker")]
		public interface ISdkInitializationListener : IJavaObject, IDisposable, IJavaPeerable
		{
			// Token: 0x060002FC RID: 764
			[Register("onSdkInitialized", "(Lcom/applovin/sdk/AppLovinSdkConfiguration;)V", "GetOnSdkInitialized_Lcom_applovin_sdk_AppLovinSdkConfiguration_Handler:Com.Applovin.Sdk.AppLovinSdk/ISdkInitializationListenerInvoker, AppLovin")]
			void OnSdkInitialized(IAppLovinSdkConfiguration p0);
		}

		// Token: 0x0200005C RID: 92
		[Register("com/applovin/sdk/AppLovinSdk$SdkInitializationListener", DoNotGenerateAcw = true)]
		internal class ISdkInitializationListenerInvoker : Java.Lang.Object, AppLovinSdk.ISdkInitializationListener, IJavaObject, IDisposable, IJavaPeerable
		{
			// Token: 0x170000F9 RID: 249
			// (get) Token: 0x060002FD RID: 765 RVA: 0x000085B4 File Offset: 0x000067B4
			private static IntPtr java_class_ref
			{
				get
				{
					return AppLovinSdk.ISdkInitializationListenerInvoker._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x170000FA RID: 250
			// (get) Token: 0x060002FE RID: 766 RVA: 0x000085D8 File Offset: 0x000067D8
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return AppLovinSdk.ISdkInitializationListenerInvoker._members;
				}
			}

			// Token: 0x170000FB RID: 251
			// (get) Token: 0x060002FF RID: 767 RVA: 0x000085DF File Offset: 0x000067DF
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return this.class_ref;
				}
			}

			// Token: 0x170000FC RID: 252
			// (get) Token: 0x06000300 RID: 768 RVA: 0x000085E7 File Offset: 0x000067E7
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return AppLovinSdk.ISdkInitializationListenerInvoker._members.ManagedPeerType;
				}
			}

			// Token: 0x06000301 RID: 769 RVA: 0x000085F3 File Offset: 0x000067F3
			public static AppLovinSdk.ISdkInitializationListener GetObject(IntPtr handle, JniHandleOwnership transfer)
			{
				return Java.Lang.Object.GetObject<AppLovinSdk.ISdkInitializationListener>(handle, transfer);
			}

			// Token: 0x06000302 RID: 770 RVA: 0x000085FC File Offset: 0x000067FC
			private static IntPtr Validate(IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf(handle, AppLovinSdk.ISdkInitializationListenerInvoker.java_class_ref))
				{
					throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'com.applovin.sdk.AppLovinSdk.SdkInitializationListener'.");
				}
				return handle;
			}

			// Token: 0x06000303 RID: 771 RVA: 0x00008627 File Offset: 0x00006827
			protected override void Dispose(bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
				{
					JNIEnv.DeleteGlobalRef(this.class_ref);
				}
				this.class_ref = IntPtr.Zero;
				base.Dispose(disposing);
			}

			// Token: 0x06000304 RID: 772 RVA: 0x00008658 File Offset: 0x00006858
			public ISdkInitializationListenerInvoker(IntPtr handle, JniHandleOwnership transfer) : base(AppLovinSdk.ISdkInitializationListenerInvoker.Validate(handle), transfer)
			{
				IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
				this.class_ref = JNIEnv.NewGlobalRef(objectClass);
				JNIEnv.DeleteLocalRef(objectClass);
			}

			// Token: 0x06000305 RID: 773 RVA: 0x00008690 File Offset: 0x00006890
			private static Delegate GetOnSdkInitialized_Lcom_applovin_sdk_AppLovinSdkConfiguration_Handler()
			{
				if (AppLovinSdk.ISdkInitializationListenerInvoker.cb_onSdkInitialized_Lcom_applovin_sdk_AppLovinSdkConfiguration_ == null)
				{
					AppLovinSdk.ISdkInitializationListenerInvoker.cb_onSdkInitialized_Lcom_applovin_sdk_AppLovinSdkConfiguration_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(AppLovinSdk.ISdkInitializationListenerInvoker.n_OnSdkInitialized_Lcom_applovin_sdk_AppLovinSdkConfiguration_));
				}
				return AppLovinSdk.ISdkInitializationListenerInvoker.cb_onSdkInitialized_Lcom_applovin_sdk_AppLovinSdkConfiguration_;
			}

			// Token: 0x06000306 RID: 774 RVA: 0x000086B4 File Offset: 0x000068B4
			private static void n_OnSdkInitialized_Lcom_applovin_sdk_AppLovinSdkConfiguration_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				AppLovinSdk.ISdkInitializationListener @object = Java.Lang.Object.GetObject<AppLovinSdk.ISdkInitializationListener>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				IAppLovinSdkConfiguration object2 = Java.Lang.Object.GetObject<IAppLovinSdkConfiguration>(native_p0, JniHandleOwnership.DoNotTransfer);
				@object.OnSdkInitialized(object2);
			}

			// Token: 0x06000307 RID: 775 RVA: 0x000086D8 File Offset: 0x000068D8
			public unsafe void OnSdkInitialized(IAppLovinSdkConfiguration p0)
			{
				if (this.id_onSdkInitialized_Lcom_applovin_sdk_AppLovinSdkConfiguration_ == IntPtr.Zero)
				{
					this.id_onSdkInitialized_Lcom_applovin_sdk_AppLovinSdkConfiguration_ = JNIEnv.GetMethodID(this.class_ref, "onSdkInitialized", "(Lcom/applovin/sdk/AppLovinSdkConfiguration;)V");
				}
				JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
				*ptr = new JValue((p0 == null) ? IntPtr.Zero : ((Java.Lang.Object)p0).Handle);
				JNIEnv.CallVoidMethod(base.Handle, this.id_onSdkInitialized_Lcom_applovin_sdk_AppLovinSdkConfiguration_, ptr);
			}

			// Token: 0x040000B1 RID: 177
			private static readonly JniPeerMembers _members = new XAPeerMembers("com/applovin/sdk/AppLovinSdk$SdkInitializationListener", typeof(AppLovinSdk.ISdkInitializationListenerInvoker));

			// Token: 0x040000B2 RID: 178
			private IntPtr class_ref;

			// Token: 0x040000B3 RID: 179
			private static Delegate cb_onSdkInitialized_Lcom_applovin_sdk_AppLovinSdkConfiguration_;

			// Token: 0x040000B4 RID: 180
			private IntPtr id_onSdkInitialized_Lcom_applovin_sdk_AppLovinSdkConfiguration_;
		}

		// Token: 0x0200005D RID: 93
		public class SdkInitializationEventArgs : EventArgs
		{
			// Token: 0x06000309 RID: 777 RVA: 0x0000876B File Offset: 0x0000696B
			public SdkInitializationEventArgs(IAppLovinSdkConfiguration p0)
			{
				this.p0 = p0;
			}

			// Token: 0x170000FD RID: 253
			// (get) Token: 0x0600030A RID: 778 RVA: 0x0000877A File Offset: 0x0000697A
			public IAppLovinSdkConfiguration P0
			{
				get
				{
					return this.p0;
				}
			}

			// Token: 0x040000B5 RID: 181
			private IAppLovinSdkConfiguration p0;
		}

		// Token: 0x0200005E RID: 94
		[Register("mono/com/applovin/sdk/AppLovinSdk_SdkInitializationListenerImplementor")]
		internal sealed class ISdkInitializationListenerImplementor : Java.Lang.Object, AppLovinSdk.ISdkInitializationListener, IJavaObject, IDisposable, IJavaPeerable
		{
			// Token: 0x0600030B RID: 779 RVA: 0x00008782 File Offset: 0x00006982
			public ISdkInitializationListenerImplementor(object sender) : base(JNIEnv.StartCreateInstance("mono/com/applovin/sdk/AppLovinSdk_SdkInitializationListenerImplementor", "()V", Array.Empty<JValue>()), JniHandleOwnership.TransferLocalRef)
			{
				JNIEnv.FinishCreateInstance(base.Handle, "()V", Array.Empty<JValue>());
				this.sender = sender;
			}

			// Token: 0x0600030C RID: 780 RVA: 0x000087BC File Offset: 0x000069BC
			public void OnSdkInitialized(IAppLovinSdkConfiguration p0)
			{
				EventHandler<AppLovinSdk.SdkInitializationEventArgs> handler = this.Handler;
				if (handler != null)
				{
					handler(this.sender, new AppLovinSdk.SdkInitializationEventArgs(p0));
				}
			}

			// Token: 0x0600030D RID: 781 RVA: 0x000087E5 File Offset: 0x000069E5
			internal static bool __IsEmpty(AppLovinSdk.ISdkInitializationListenerImplementor value)
			{
				return value.Handler == null;
			}

			// Token: 0x040000B6 RID: 182
			private object sender;

			// Token: 0x040000B7 RID: 183
			public EventHandler<AppLovinSdk.SdkInitializationEventArgs> Handler;
		}
	}
}
