using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using Android.Content;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Com.Applovin.Sdk
{
	// Token: 0x0200005F RID: 95
	[Register("com/applovin/sdk/AppLovinSdkSettings", DoNotGenerateAcw = true)]
	public class AppLovinSdkSettings : Java.Lang.Object
	{
		// Token: 0x170000FE RID: 254
		// (get) Token: 0x0600030E RID: 782 RVA: 0x000087F0 File Offset: 0x000069F0
		internal static IntPtr class_ref
		{
			get
			{
				return AppLovinSdkSettings._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170000FF RID: 255
		// (get) Token: 0x0600030F RID: 783 RVA: 0x00008814 File Offset: 0x00006A14
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return AppLovinSdkSettings._members;
			}
		}

		// Token: 0x17000100 RID: 256
		// (get) Token: 0x06000310 RID: 784 RVA: 0x0000881C File Offset: 0x00006A1C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return AppLovinSdkSettings._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000101 RID: 257
		// (get) Token: 0x06000311 RID: 785 RVA: 0x00008840 File Offset: 0x00006A40
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return AppLovinSdkSettings._members.ManagedPeerType;
			}
		}

		// Token: 0x06000312 RID: 786 RVA: 0x000021F0 File Offset: 0x000003F0
		protected AppLovinSdkSettings(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000313 RID: 787 RVA: 0x0000884C File Offset: 0x00006A4C
		[Register(".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe AppLovinSdkSettings(Context p0) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((p0 == null) ? IntPtr.Zero : p0.Handle);
				base.SetHandle(AppLovinSdkSettings._members.InstanceMethods.StartCreateInstance("(Landroid/content/Context;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				AppLovinSdkSettings._members.InstanceMethods.FinishCreateInstance("(Landroid/content/Context;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(p0);
			}
		}

		// Token: 0x06000314 RID: 788 RVA: 0x000088FC File Offset: 0x00006AFC
		private static Delegate GetIsCreativeDebuggerEnabledHandler()
		{
			if (AppLovinSdkSettings.cb_isCreativeDebuggerEnabled == null)
			{
				AppLovinSdkSettings.cb_isCreativeDebuggerEnabled = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(AppLovinSdkSettings.n_IsCreativeDebuggerEnabled));
			}
			return AppLovinSdkSettings.cb_isCreativeDebuggerEnabled;
		}

		// Token: 0x06000315 RID: 789 RVA: 0x00008920 File Offset: 0x00006B20
		private static bool n_IsCreativeDebuggerEnabled(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<AppLovinSdkSettings>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).CreativeDebuggerEnabled;
		}

		// Token: 0x06000316 RID: 790 RVA: 0x0000892F File Offset: 0x00006B2F
		private static Delegate GetSetCreativeDebuggerEnabled_ZHandler()
		{
			if (AppLovinSdkSettings.cb_setCreativeDebuggerEnabled_Z == null)
			{
				AppLovinSdkSettings.cb_setCreativeDebuggerEnabled_Z = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPZ_V(AppLovinSdkSettings.n_SetCreativeDebuggerEnabled_Z));
			}
			return AppLovinSdkSettings.cb_setCreativeDebuggerEnabled_Z;
		}

		// Token: 0x06000317 RID: 791 RVA: 0x00008953 File Offset: 0x00006B53
		private static void n_SetCreativeDebuggerEnabled_Z(IntPtr jnienv, IntPtr native__this, bool p0)
		{
			Java.Lang.Object.GetObject<AppLovinSdkSettings>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).CreativeDebuggerEnabled = p0;
		}

		// Token: 0x17000102 RID: 258
		// (get) Token: 0x06000318 RID: 792 RVA: 0x00008963 File Offset: 0x00006B63
		// (set) Token: 0x06000319 RID: 793 RVA: 0x0000897C File Offset: 0x00006B7C
		public unsafe virtual bool CreativeDebuggerEnabled
		{
			[Register("isCreativeDebuggerEnabled", "()Z", "GetIsCreativeDebuggerEnabledHandler")]
			get
			{
				return AppLovinSdkSettings._members.InstanceMethods.InvokeVirtualBooleanMethod("isCreativeDebuggerEnabled.()Z", this, null);
			}
			[Register("setCreativeDebuggerEnabled", "(Z)V", "GetSetCreativeDebuggerEnabled_ZHandler")]
			set
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(value);
				AppLovinSdkSettings._members.InstanceMethods.InvokeVirtualVoidMethod("setCreativeDebuggerEnabled.(Z)V", this, ptr);
			}
		}

		// Token: 0x0600031A RID: 794 RVA: 0x000089B7 File Offset: 0x00006BB7
		private static Delegate GetIsExceptionHandlerEnabledHandler()
		{
			if (AppLovinSdkSettings.cb_isExceptionHandlerEnabled == null)
			{
				AppLovinSdkSettings.cb_isExceptionHandlerEnabled = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(AppLovinSdkSettings.n_IsExceptionHandlerEnabled));
			}
			return AppLovinSdkSettings.cb_isExceptionHandlerEnabled;
		}

		// Token: 0x0600031B RID: 795 RVA: 0x000089DB File Offset: 0x00006BDB
		private static bool n_IsExceptionHandlerEnabled(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<AppLovinSdkSettings>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ExceptionHandlerEnabled;
		}

		// Token: 0x0600031C RID: 796 RVA: 0x000089EA File Offset: 0x00006BEA
		private static Delegate GetSetExceptionHandlerEnabled_ZHandler()
		{
			if (AppLovinSdkSettings.cb_setExceptionHandlerEnabled_Z == null)
			{
				AppLovinSdkSettings.cb_setExceptionHandlerEnabled_Z = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPZ_V(AppLovinSdkSettings.n_SetExceptionHandlerEnabled_Z));
			}
			return AppLovinSdkSettings.cb_setExceptionHandlerEnabled_Z;
		}

		// Token: 0x0600031D RID: 797 RVA: 0x00008A0E File Offset: 0x00006C0E
		private static void n_SetExceptionHandlerEnabled_Z(IntPtr jnienv, IntPtr native__this, bool p0)
		{
			Java.Lang.Object.GetObject<AppLovinSdkSettings>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ExceptionHandlerEnabled = p0;
		}

		// Token: 0x17000103 RID: 259
		// (get) Token: 0x0600031E RID: 798 RVA: 0x00008A1E File Offset: 0x00006C1E
		// (set) Token: 0x0600031F RID: 799 RVA: 0x00008A38 File Offset: 0x00006C38
		public unsafe virtual bool ExceptionHandlerEnabled
		{
			[Register("isExceptionHandlerEnabled", "()Z", "GetIsExceptionHandlerEnabledHandler")]
			get
			{
				return AppLovinSdkSettings._members.InstanceMethods.InvokeVirtualBooleanMethod("isExceptionHandlerEnabled.()Z", this, null);
			}
			[Register("setExceptionHandlerEnabled", "(Z)V", "GetSetExceptionHandlerEnabled_ZHandler")]
			set
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(value);
				AppLovinSdkSettings._members.InstanceMethods.InvokeVirtualVoidMethod("setExceptionHandlerEnabled.(Z)V", this, ptr);
			}
		}

		// Token: 0x06000320 RID: 800 RVA: 0x00008A73 File Offset: 0x00006C73
		private static Delegate GetGetExtraParametersHandler()
		{
			if (AppLovinSdkSettings.cb_getExtraParameters == null)
			{
				AppLovinSdkSettings.cb_getExtraParameters = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(AppLovinSdkSettings.n_GetExtraParameters));
			}
			return AppLovinSdkSettings.cb_getExtraParameters;
		}

		// Token: 0x06000321 RID: 801 RVA: 0x00008A97 File Offset: 0x00006C97
		private static IntPtr n_GetExtraParameters(IntPtr jnienv, IntPtr native__this)
		{
			return JavaDictionary<string, string>.ToLocalJniHandle(Java.Lang.Object.GetObject<AppLovinSdkSettings>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ExtraParameters);
		}

		// Token: 0x17000104 RID: 260
		// (get) Token: 0x06000322 RID: 802 RVA: 0x00008AAC File Offset: 0x00006CAC
		public virtual IDictionary<string, string> ExtraParameters
		{
			[Register("getExtraParameters", "()Ljava/util/Map;", "GetGetExtraParametersHandler")]
			get
			{
				return JavaDictionary<string, string>.FromJniHandle(AppLovinSdkSettings._members.InstanceMethods.InvokeVirtualObjectMethod("getExtraParameters.()Ljava/util/Map;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06000323 RID: 803 RVA: 0x00008ADE File Offset: 0x00006CDE
		private static Delegate GetGetInitializationAdUnitIdsHandler()
		{
			if (AppLovinSdkSettings.cb_getInitializationAdUnitIds == null)
			{
				AppLovinSdkSettings.cb_getInitializationAdUnitIds = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(AppLovinSdkSettings.n_GetInitializationAdUnitIds));
			}
			return AppLovinSdkSettings.cb_getInitializationAdUnitIds;
		}

		// Token: 0x06000324 RID: 804 RVA: 0x00008B02 File Offset: 0x00006D02
		private static IntPtr n_GetInitializationAdUnitIds(IntPtr jnienv, IntPtr native__this)
		{
			return JavaList<string>.ToLocalJniHandle(Java.Lang.Object.GetObject<AppLovinSdkSettings>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).InitializationAdUnitIds);
		}

		// Token: 0x06000325 RID: 805 RVA: 0x00008B16 File Offset: 0x00006D16
		private static Delegate GetSetInitializationAdUnitIds_Ljava_util_List_Handler()
		{
			if (AppLovinSdkSettings.cb_setInitializationAdUnitIds_Ljava_util_List_ == null)
			{
				AppLovinSdkSettings.cb_setInitializationAdUnitIds_Ljava_util_List_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(AppLovinSdkSettings.n_SetInitializationAdUnitIds_Ljava_util_List_));
			}
			return AppLovinSdkSettings.cb_setInitializationAdUnitIds_Ljava_util_List_;
		}

		// Token: 0x06000326 RID: 806 RVA: 0x00008B3C File Offset: 0x00006D3C
		private static void n_SetInitializationAdUnitIds_Ljava_util_List_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			AppLovinSdkSettings @object = Java.Lang.Object.GetObject<AppLovinSdkSettings>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IList<string> initializationAdUnitIds = JavaList<string>.FromJniHandle(native_p0, JniHandleOwnership.DoNotTransfer);
			@object.InitializationAdUnitIds = initializationAdUnitIds;
		}

		// Token: 0x17000105 RID: 261
		// (get) Token: 0x06000327 RID: 807 RVA: 0x00008B60 File Offset: 0x00006D60
		// (set) Token: 0x06000328 RID: 808 RVA: 0x00008B94 File Offset: 0x00006D94
		public unsafe virtual IList<string> InitializationAdUnitIds
		{
			[Register("getInitializationAdUnitIds", "()Ljava/util/List;", "GetGetInitializationAdUnitIdsHandler")]
			get
			{
				return JavaList<string>.FromJniHandle(AppLovinSdkSettings._members.InstanceMethods.InvokeVirtualObjectMethod("getInitializationAdUnitIds.()Ljava/util/List;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
			[Register("setInitializationAdUnitIds", "(Ljava/util/List;)V", "GetSetInitializationAdUnitIds_Ljava_util_List_Handler")]
			set
			{
				IntPtr intPtr = JavaList<string>.ToLocalJniHandle(value);
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue(intPtr);
					AppLovinSdkSettings._members.InstanceMethods.InvokeVirtualVoidMethod("setInitializationAdUnitIds.(Ljava/util/List;)V", this, ptr);
				}
				finally
				{
					JNIEnv.DeleteLocalRef(intPtr);
					GC.KeepAlive(value);
				}
			}
		}

		// Token: 0x06000329 RID: 809 RVA: 0x00008BF8 File Offset: 0x00006DF8
		private static Delegate GetIsVerboseLoggingEnabledHandler()
		{
			if (AppLovinSdkSettings.cb_isVerboseLoggingEnabled == null)
			{
				AppLovinSdkSettings.cb_isVerboseLoggingEnabled = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(AppLovinSdkSettings.n_IsVerboseLoggingEnabled));
			}
			return AppLovinSdkSettings.cb_isVerboseLoggingEnabled;
		}

		// Token: 0x0600032A RID: 810 RVA: 0x00008C1C File Offset: 0x00006E1C
		private static bool n_IsVerboseLoggingEnabled(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<AppLovinSdkSettings>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsVerboseLoggingEnabled;
		}

		// Token: 0x17000106 RID: 262
		// (get) Token: 0x0600032B RID: 811 RVA: 0x00008C2B File Offset: 0x00006E2B
		public virtual bool IsVerboseLoggingEnabled
		{
			[Register("isVerboseLoggingEnabled", "()Z", "GetIsVerboseLoggingEnabledHandler")]
			get
			{
				return AppLovinSdkSettings._members.InstanceMethods.InvokeVirtualBooleanMethod("isVerboseLoggingEnabled.()Z", this, null);
			}
		}

		// Token: 0x0600032C RID: 812 RVA: 0x00008C44 File Offset: 0x00006E44
		private static Delegate GetIsLocationCollectionEnabledHandler()
		{
			if (AppLovinSdkSettings.cb_isLocationCollectionEnabled == null)
			{
				AppLovinSdkSettings.cb_isLocationCollectionEnabled = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(AppLovinSdkSettings.n_IsLocationCollectionEnabled));
			}
			return AppLovinSdkSettings.cb_isLocationCollectionEnabled;
		}

		// Token: 0x0600032D RID: 813 RVA: 0x00008C68 File Offset: 0x00006E68
		private static bool n_IsLocationCollectionEnabled(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<AppLovinSdkSettings>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).LocationCollectionEnabled;
		}

		// Token: 0x0600032E RID: 814 RVA: 0x00008C77 File Offset: 0x00006E77
		private static Delegate GetSetLocationCollectionEnabled_ZHandler()
		{
			if (AppLovinSdkSettings.cb_setLocationCollectionEnabled_Z == null)
			{
				AppLovinSdkSettings.cb_setLocationCollectionEnabled_Z = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPZ_V(AppLovinSdkSettings.n_SetLocationCollectionEnabled_Z));
			}
			return AppLovinSdkSettings.cb_setLocationCollectionEnabled_Z;
		}

		// Token: 0x0600032F RID: 815 RVA: 0x00008C9B File Offset: 0x00006E9B
		private static void n_SetLocationCollectionEnabled_Z(IntPtr jnienv, IntPtr native__this, bool p0)
		{
			Java.Lang.Object.GetObject<AppLovinSdkSettings>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).LocationCollectionEnabled = p0;
		}

		// Token: 0x17000107 RID: 263
		// (get) Token: 0x06000330 RID: 816 RVA: 0x00008CAB File Offset: 0x00006EAB
		// (set) Token: 0x06000331 RID: 817 RVA: 0x00008CC4 File Offset: 0x00006EC4
		public unsafe virtual bool LocationCollectionEnabled
		{
			[Register("isLocationCollectionEnabled", "()Z", "GetIsLocationCollectionEnabledHandler")]
			get
			{
				return AppLovinSdkSettings._members.InstanceMethods.InvokeVirtualBooleanMethod("isLocationCollectionEnabled.()Z", this, null);
			}
			[Register("setLocationCollectionEnabled", "(Z)V", "GetSetLocationCollectionEnabled_ZHandler")]
			set
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(value);
				AppLovinSdkSettings._members.InstanceMethods.InvokeVirtualVoidMethod("setLocationCollectionEnabled.(Z)V", this, ptr);
			}
		}

		// Token: 0x06000332 RID: 818 RVA: 0x00008CFF File Offset: 0x00006EFF
		private static Delegate GetIsMutedHandler()
		{
			if (AppLovinSdkSettings.cb_isMuted == null)
			{
				AppLovinSdkSettings.cb_isMuted = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(AppLovinSdkSettings.n_IsMuted));
			}
			return AppLovinSdkSettings.cb_isMuted;
		}

		// Token: 0x06000333 RID: 819 RVA: 0x00008D23 File Offset: 0x00006F23
		private static bool n_IsMuted(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<AppLovinSdkSettings>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Muted;
		}

		// Token: 0x06000334 RID: 820 RVA: 0x00008D32 File Offset: 0x00006F32
		private static Delegate GetSetMuted_ZHandler()
		{
			if (AppLovinSdkSettings.cb_setMuted_Z == null)
			{
				AppLovinSdkSettings.cb_setMuted_Z = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPZ_V(AppLovinSdkSettings.n_SetMuted_Z));
			}
			return AppLovinSdkSettings.cb_setMuted_Z;
		}

		// Token: 0x06000335 RID: 821 RVA: 0x00008D56 File Offset: 0x00006F56
		private static void n_SetMuted_Z(IntPtr jnienv, IntPtr native__this, bool p0)
		{
			Java.Lang.Object.GetObject<AppLovinSdkSettings>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Muted = p0;
		}

		// Token: 0x17000108 RID: 264
		// (get) Token: 0x06000336 RID: 822 RVA: 0x00008D66 File Offset: 0x00006F66
		// (set) Token: 0x06000337 RID: 823 RVA: 0x00008D80 File Offset: 0x00006F80
		public unsafe virtual bool Muted
		{
			[Register("isMuted", "()Z", "GetIsMutedHandler")]
			get
			{
				return AppLovinSdkSettings._members.InstanceMethods.InvokeVirtualBooleanMethod("isMuted.()Z", this, null);
			}
			[Register("setMuted", "(Z)V", "GetSetMuted_ZHandler")]
			set
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(value);
				AppLovinSdkSettings._members.InstanceMethods.InvokeVirtualVoidMethod("setMuted.(Z)V", this, ptr);
			}
		}

		// Token: 0x06000338 RID: 824 RVA: 0x00008DBB File Offset: 0x00006FBB
		private static Delegate GetGetTestDeviceAdvertisingIdsHandler()
		{
			if (AppLovinSdkSettings.cb_getTestDeviceAdvertisingIds == null)
			{
				AppLovinSdkSettings.cb_getTestDeviceAdvertisingIds = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(AppLovinSdkSettings.n_GetTestDeviceAdvertisingIds));
			}
			return AppLovinSdkSettings.cb_getTestDeviceAdvertisingIds;
		}

		// Token: 0x06000339 RID: 825 RVA: 0x00008DDF File Offset: 0x00006FDF
		private static IntPtr n_GetTestDeviceAdvertisingIds(IntPtr jnienv, IntPtr native__this)
		{
			return JavaList<string>.ToLocalJniHandle(Java.Lang.Object.GetObject<AppLovinSdkSettings>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).TestDeviceAdvertisingIds);
		}

		// Token: 0x0600033A RID: 826 RVA: 0x00008DF3 File Offset: 0x00006FF3
		private static Delegate GetSetTestDeviceAdvertisingIds_Ljava_util_List_Handler()
		{
			if (AppLovinSdkSettings.cb_setTestDeviceAdvertisingIds_Ljava_util_List_ == null)
			{
				AppLovinSdkSettings.cb_setTestDeviceAdvertisingIds_Ljava_util_List_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(AppLovinSdkSettings.n_SetTestDeviceAdvertisingIds_Ljava_util_List_));
			}
			return AppLovinSdkSettings.cb_setTestDeviceAdvertisingIds_Ljava_util_List_;
		}

		// Token: 0x0600033B RID: 827 RVA: 0x00008E18 File Offset: 0x00007018
		private static void n_SetTestDeviceAdvertisingIds_Ljava_util_List_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			AppLovinSdkSettings @object = Java.Lang.Object.GetObject<AppLovinSdkSettings>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IList<string> testDeviceAdvertisingIds = JavaList<string>.FromJniHandle(native_p0, JniHandleOwnership.DoNotTransfer);
			@object.TestDeviceAdvertisingIds = testDeviceAdvertisingIds;
		}

		// Token: 0x17000109 RID: 265
		// (get) Token: 0x0600033C RID: 828 RVA: 0x00008E3C File Offset: 0x0000703C
		// (set) Token: 0x0600033D RID: 829 RVA: 0x00008E70 File Offset: 0x00007070
		public unsafe virtual IList<string> TestDeviceAdvertisingIds
		{
			[Register("getTestDeviceAdvertisingIds", "()Ljava/util/List;", "GetGetTestDeviceAdvertisingIdsHandler")]
			get
			{
				return JavaList<string>.FromJniHandle(AppLovinSdkSettings._members.InstanceMethods.InvokeVirtualObjectMethod("getTestDeviceAdvertisingIds.()Ljava/util/List;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
			[Register("setTestDeviceAdvertisingIds", "(Ljava/util/List;)V", "GetSetTestDeviceAdvertisingIds_Ljava_util_List_Handler")]
			set
			{
				IntPtr intPtr = JavaList<string>.ToLocalJniHandle(value);
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue(intPtr);
					AppLovinSdkSettings._members.InstanceMethods.InvokeVirtualVoidMethod("setTestDeviceAdvertisingIds.(Ljava/util/List;)V", this, ptr);
				}
				finally
				{
					JNIEnv.DeleteLocalRef(intPtr);
					GC.KeepAlive(value);
				}
			}
		}

		// Token: 0x0600033E RID: 830 RVA: 0x00008ED4 File Offset: 0x000070D4
		private static Delegate GetSetExtraParameter_Ljava_lang_String_Ljava_lang_String_Handler()
		{
			if (AppLovinSdkSettings.cb_setExtraParameter_Ljava_lang_String_Ljava_lang_String_ == null)
			{
				AppLovinSdkSettings.cb_setExtraParameter_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_V(AppLovinSdkSettings.n_SetExtraParameter_Ljava_lang_String_Ljava_lang_String_));
			}
			return AppLovinSdkSettings.cb_setExtraParameter_Ljava_lang_String_Ljava_lang_String_;
		}

		// Token: 0x0600033F RID: 831 RVA: 0x00008EF8 File Offset: 0x000070F8
		private static void n_SetExtraParameter_Ljava_lang_String_Ljava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			AppLovinSdkSettings @object = Java.Lang.Object.GetObject<AppLovinSdkSettings>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_p0, JniHandleOwnership.DoNotTransfer);
			string string2 = JNIEnv.GetString(native_p1, JniHandleOwnership.DoNotTransfer);
			@object.SetExtraParameter(@string, string2);
		}

		// Token: 0x06000340 RID: 832 RVA: 0x00008F24 File Offset: 0x00007124
		[Register("setExtraParameter", "(Ljava/lang/String;Ljava/lang/String;)V", "GetSetExtraParameter_Ljava_lang_String_Ljava_lang_String_Handler")]
		public unsafe virtual void SetExtraParameter(string p0, string p1)
		{
			IntPtr intPtr = JNIEnv.NewString(p0);
			IntPtr intPtr2 = JNIEnv.NewString(p1);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(intPtr2);
				AppLovinSdkSettings._members.InstanceMethods.InvokeVirtualVoidMethod("setExtraParameter.(Ljava/lang/String;Ljava/lang/String;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				JNIEnv.DeleteLocalRef(intPtr2);
			}
		}

		// Token: 0x06000341 RID: 833 RVA: 0x00008FA0 File Offset: 0x000071A0
		private static Delegate GetSetShouldFailAdDisplayIfDontKeepActivitiesIsEnabled_ZHandler()
		{
			if (AppLovinSdkSettings.cb_setShouldFailAdDisplayIfDontKeepActivitiesIsEnabled_Z == null)
			{
				AppLovinSdkSettings.cb_setShouldFailAdDisplayIfDontKeepActivitiesIsEnabled_Z = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPZ_V(AppLovinSdkSettings.n_SetShouldFailAdDisplayIfDontKeepActivitiesIsEnabled_Z));
			}
			return AppLovinSdkSettings.cb_setShouldFailAdDisplayIfDontKeepActivitiesIsEnabled_Z;
		}

		// Token: 0x06000342 RID: 834 RVA: 0x00008FC4 File Offset: 0x000071C4
		private static void n_SetShouldFailAdDisplayIfDontKeepActivitiesIsEnabled_Z(IntPtr jnienv, IntPtr native__this, bool p0)
		{
			Java.Lang.Object.GetObject<AppLovinSdkSettings>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SetShouldFailAdDisplayIfDontKeepActivitiesIsEnabled(p0);
		}

		// Token: 0x06000343 RID: 835 RVA: 0x00008FD4 File Offset: 0x000071D4
		[Register("setShouldFailAdDisplayIfDontKeepActivitiesIsEnabled", "(Z)V", "GetSetShouldFailAdDisplayIfDontKeepActivitiesIsEnabled_ZHandler")]
		public unsafe virtual void SetShouldFailAdDisplayIfDontKeepActivitiesIsEnabled(bool p0)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(p0);
			AppLovinSdkSettings._members.InstanceMethods.InvokeVirtualVoidMethod("setShouldFailAdDisplayIfDontKeepActivitiesIsEnabled.(Z)V", this, ptr);
		}

		// Token: 0x06000344 RID: 836 RVA: 0x0000900F File Offset: 0x0000720F
		private static Delegate GetSetVerboseLogging_ZHandler()
		{
			if (AppLovinSdkSettings.cb_setVerboseLogging_Z == null)
			{
				AppLovinSdkSettings.cb_setVerboseLogging_Z = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPZ_V(AppLovinSdkSettings.n_SetVerboseLogging_Z));
			}
			return AppLovinSdkSettings.cb_setVerboseLogging_Z;
		}

		// Token: 0x06000345 RID: 837 RVA: 0x00009033 File Offset: 0x00007233
		private static void n_SetVerboseLogging_Z(IntPtr jnienv, IntPtr native__this, bool p0)
		{
			Java.Lang.Object.GetObject<AppLovinSdkSettings>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SetVerboseLogging(p0);
		}

		// Token: 0x06000346 RID: 838 RVA: 0x00009044 File Offset: 0x00007244
		[Register("setVerboseLogging", "(Z)V", "GetSetVerboseLogging_ZHandler")]
		public unsafe virtual void SetVerboseLogging(bool p0)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(p0);
			AppLovinSdkSettings._members.InstanceMethods.InvokeVirtualVoidMethod("setVerboseLogging.(Z)V", this, ptr);
		}

		// Token: 0x06000347 RID: 839 RVA: 0x0000907F File Offset: 0x0000727F
		private static Delegate GetShouldFailAdDisplayIfDontKeepActivitiesIsEnabledHandler()
		{
			if (AppLovinSdkSettings.cb_shouldFailAdDisplayIfDontKeepActivitiesIsEnabled == null)
			{
				AppLovinSdkSettings.cb_shouldFailAdDisplayIfDontKeepActivitiesIsEnabled = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(AppLovinSdkSettings.n_ShouldFailAdDisplayIfDontKeepActivitiesIsEnabled));
			}
			return AppLovinSdkSettings.cb_shouldFailAdDisplayIfDontKeepActivitiesIsEnabled;
		}

		// Token: 0x06000348 RID: 840 RVA: 0x000090A3 File Offset: 0x000072A3
		private static bool n_ShouldFailAdDisplayIfDontKeepActivitiesIsEnabled(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<AppLovinSdkSettings>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ShouldFailAdDisplayIfDontKeepActivitiesIsEnabled();
		}

		// Token: 0x06000349 RID: 841 RVA: 0x000090B2 File Offset: 0x000072B2
		[Register("shouldFailAdDisplayIfDontKeepActivitiesIsEnabled", "()Z", "GetShouldFailAdDisplayIfDontKeepActivitiesIsEnabledHandler")]
		public virtual bool ShouldFailAdDisplayIfDontKeepActivitiesIsEnabled()
		{
			return AppLovinSdkSettings._members.InstanceMethods.InvokeVirtualBooleanMethod("shouldFailAdDisplayIfDontKeepActivitiesIsEnabled.()Z", this, null);
		}

		// Token: 0x040000B8 RID: 184
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/applovin/sdk/AppLovinSdkSettings", typeof(AppLovinSdkSettings));

		// Token: 0x040000B9 RID: 185
		private static Delegate cb_isCreativeDebuggerEnabled;

		// Token: 0x040000BA RID: 186
		private static Delegate cb_setCreativeDebuggerEnabled_Z;

		// Token: 0x040000BB RID: 187
		private static Delegate cb_isExceptionHandlerEnabled;

		// Token: 0x040000BC RID: 188
		private static Delegate cb_setExceptionHandlerEnabled_Z;

		// Token: 0x040000BD RID: 189
		private static Delegate cb_getExtraParameters;

		// Token: 0x040000BE RID: 190
		private static Delegate cb_getInitializationAdUnitIds;

		// Token: 0x040000BF RID: 191
		private static Delegate cb_setInitializationAdUnitIds_Ljava_util_List_;

		// Token: 0x040000C0 RID: 192
		private static Delegate cb_isVerboseLoggingEnabled;

		// Token: 0x040000C1 RID: 193
		private static Delegate cb_isLocationCollectionEnabled;

		// Token: 0x040000C2 RID: 194
		private static Delegate cb_setLocationCollectionEnabled_Z;

		// Token: 0x040000C3 RID: 195
		private static Delegate cb_isMuted;

		// Token: 0x040000C4 RID: 196
		private static Delegate cb_setMuted_Z;

		// Token: 0x040000C5 RID: 197
		private static Delegate cb_getTestDeviceAdvertisingIds;

		// Token: 0x040000C6 RID: 198
		private static Delegate cb_setTestDeviceAdvertisingIds_Ljava_util_List_;

		// Token: 0x040000C7 RID: 199
		private static Delegate cb_setExtraParameter_Ljava_lang_String_Ljava_lang_String_;

		// Token: 0x040000C8 RID: 200
		private static Delegate cb_setShouldFailAdDisplayIfDontKeepActivitiesIsEnabled_Z;

		// Token: 0x040000C9 RID: 201
		private static Delegate cb_setVerboseLogging_Z;

		// Token: 0x040000CA RID: 202
		private static Delegate cb_shouldFailAdDisplayIfDontKeepActivitiesIsEnabled;
	}
}
