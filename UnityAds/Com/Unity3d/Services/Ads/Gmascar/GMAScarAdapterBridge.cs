using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Com.Unity3d.Services.Ads.Gmascar
{
	// Token: 0x02000200 RID: 512
	[Register("com/unity3d/services/ads/gmascar/GMAScarAdapterBridge", DoNotGenerateAcw = true)]
	public class GMAScarAdapterBridge : Java.Lang.Object
	{
		// Token: 0x17000834 RID: 2100
		// (get) Token: 0x060017DF RID: 6111 RVA: 0x000450D8 File Offset: 0x000432D8
		internal static IntPtr class_ref
		{
			get
			{
				return GMAScarAdapterBridge._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000835 RID: 2101
		// (get) Token: 0x060017E0 RID: 6112 RVA: 0x000450FC File Offset: 0x000432FC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return GMAScarAdapterBridge._members;
			}
		}

		// Token: 0x17000836 RID: 2102
		// (get) Token: 0x060017E1 RID: 6113 RVA: 0x00045104 File Offset: 0x00043304
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return GMAScarAdapterBridge._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000837 RID: 2103
		// (get) Token: 0x060017E2 RID: 6114 RVA: 0x00045128 File Offset: 0x00043328
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return GMAScarAdapterBridge._members.ManagedPeerType;
			}
		}

		// Token: 0x060017E3 RID: 6115 RVA: 0x000021E8 File Offset: 0x000003E8
		protected GMAScarAdapterBridge(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x060017E4 RID: 6116 RVA: 0x00045134 File Offset: 0x00043334
		[Register(".ctor", "()V", "")]
		public GMAScarAdapterBridge() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			base.SetHandle(GMAScarAdapterBridge._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
			GMAScarAdapterBridge._members.InstanceMethods.FinishCreateInstance("()V", this, null);
		}

		// Token: 0x060017E5 RID: 6117 RVA: 0x000451A2 File Offset: 0x000433A2
		private static Delegate GetIsInitializedHandler()
		{
			if (GMAScarAdapterBridge.cb_isInitialized == null)
			{
				GMAScarAdapterBridge.cb_isInitialized = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(GMAScarAdapterBridge.n_IsInitialized));
			}
			return GMAScarAdapterBridge.cb_isInitialized;
		}

		// Token: 0x060017E6 RID: 6118 RVA: 0x000451C6 File Offset: 0x000433C6
		private static bool n_IsInitialized(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<GMAScarAdapterBridge>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsInitialized;
		}

		// Token: 0x17000838 RID: 2104
		// (get) Token: 0x060017E7 RID: 6119 RVA: 0x000451D5 File Offset: 0x000433D5
		public virtual bool IsInitialized
		{
			[Register("isInitialized", "()Z", "GetIsInitializedHandler")]
			get
			{
				return GMAScarAdapterBridge._members.InstanceMethods.InvokeVirtualBooleanMethod("isInitialized.()Z", this, null);
			}
		}

		// Token: 0x060017E8 RID: 6120 RVA: 0x000451EE File Offset: 0x000433EE
		private static Delegate GetGetSCARSignals_arrayLjava_lang_String_arrayLjava_lang_String_Handler()
		{
			if (GMAScarAdapterBridge.cb_getSCARSignals_arrayLjava_lang_String_arrayLjava_lang_String_ == null)
			{
				GMAScarAdapterBridge.cb_getSCARSignals_arrayLjava_lang_String_arrayLjava_lang_String_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_V(GMAScarAdapterBridge.n_GetSCARSignals_arrayLjava_lang_String_arrayLjava_lang_String_));
			}
			return GMAScarAdapterBridge.cb_getSCARSignals_arrayLjava_lang_String_arrayLjava_lang_String_;
		}

		// Token: 0x060017E9 RID: 6121 RVA: 0x00045214 File Offset: 0x00043414
		private static void n_GetSCARSignals_arrayLjava_lang_String_arrayLjava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native_interstitialList, IntPtr native_rewardedList)
		{
			GMAScarAdapterBridge @object = Java.Lang.Object.GetObject<GMAScarAdapterBridge>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string[] array = (string[])JNIEnv.GetArray(native_interstitialList, JniHandleOwnership.DoNotTransfer, typeof(string));
			string[] array2 = (string[])JNIEnv.GetArray(native_rewardedList, JniHandleOwnership.DoNotTransfer, typeof(string));
			@object.GetSCARSignals(array, array2);
			if (array != null)
			{
				JNIEnv.CopyArray(array, native_interstitialList);
			}
			if (array2 != null)
			{
				JNIEnv.CopyArray(array2, native_rewardedList);
			}
		}

		// Token: 0x060017EA RID: 6122 RVA: 0x00045274 File Offset: 0x00043474
		[Register("getSCARSignals", "([Ljava/lang/String;[Ljava/lang/String;)V", "GetGetSCARSignals_arrayLjava_lang_String_arrayLjava_lang_String_Handler")]
		public unsafe virtual void GetSCARSignals(string[] interstitialList, string[] rewardedList)
		{
			IntPtr intPtr = JNIEnv.NewArray(interstitialList);
			IntPtr intPtr2 = JNIEnv.NewArray(rewardedList);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(intPtr2);
				GMAScarAdapterBridge._members.InstanceMethods.InvokeVirtualVoidMethod("getSCARSignals.([Ljava/lang/String;[Ljava/lang/String;)V", this, ptr);
			}
			finally
			{
				if (interstitialList != null)
				{
					JNIEnv.CopyArray(intPtr, interstitialList);
					JNIEnv.DeleteLocalRef(intPtr);
				}
				if (rewardedList != null)
				{
					JNIEnv.CopyArray(intPtr2, rewardedList);
					JNIEnv.DeleteLocalRef(intPtr2);
				}
				GC.KeepAlive(interstitialList);
				GC.KeepAlive(rewardedList);
			}
		}

		// Token: 0x060017EB RID: 6123 RVA: 0x00045310 File Offset: 0x00043510
		private static Delegate GetGetVersionHandler()
		{
			if (GMAScarAdapterBridge.cb_getVersion == null)
			{
				GMAScarAdapterBridge.cb_getVersion = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(GMAScarAdapterBridge.n_GetVersion));
			}
			return GMAScarAdapterBridge.cb_getVersion;
		}

		// Token: 0x060017EC RID: 6124 RVA: 0x00045334 File Offset: 0x00043534
		private static void n_GetVersion(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<GMAScarAdapterBridge>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).GetVersion();
		}

		// Token: 0x060017ED RID: 6125 RVA: 0x00045343 File Offset: 0x00043543
		[Register("getVersion", "()V", "GetGetVersionHandler")]
		public virtual void GetVersion()
		{
			GMAScarAdapterBridge._members.InstanceMethods.InvokeVirtualVoidMethod("getVersion.()V", this, null);
		}

		// Token: 0x060017EE RID: 6126 RVA: 0x0004535C File Offset: 0x0004355C
		private static Delegate GetInitializeScarHandler()
		{
			if (GMAScarAdapterBridge.cb_initializeScar == null)
			{
				GMAScarAdapterBridge.cb_initializeScar = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(GMAScarAdapterBridge.n_InitializeScar));
			}
			return GMAScarAdapterBridge.cb_initializeScar;
		}

		// Token: 0x060017EF RID: 6127 RVA: 0x00045380 File Offset: 0x00043580
		private static void n_InitializeScar(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<GMAScarAdapterBridge>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).InitializeScar();
		}

		// Token: 0x060017F0 RID: 6128 RVA: 0x0004538F File Offset: 0x0004358F
		[Register("initializeScar", "()V", "GetInitializeScarHandler")]
		public virtual void InitializeScar()
		{
			GMAScarAdapterBridge._members.InstanceMethods.InvokeVirtualVoidMethod("initializeScar.()V", this, null);
		}

		// Token: 0x060017F1 RID: 6129 RVA: 0x000453A8 File Offset: 0x000435A8
		private static Delegate GetLoad_ZLjava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_IHandler()
		{
			if (GMAScarAdapterBridge.cb_load_ZLjava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_I == null)
			{
				GMAScarAdapterBridge.cb_load_ZLjava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPZLLLLI_V(GMAScarAdapterBridge.n_Load_ZLjava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_I));
			}
			return GMAScarAdapterBridge.cb_load_ZLjava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_I;
		}

		// Token: 0x060017F2 RID: 6130 RVA: 0x000453CC File Offset: 0x000435CC
		private static void n_Load_ZLjava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_I(IntPtr jnienv, IntPtr native__this, bool canSkip, IntPtr native_placementId, IntPtr native_queryId, IntPtr native_adString, IntPtr native_adUnitId, int videoLengthMs)
		{
			GMAScarAdapterBridge @object = Java.Lang.Object.GetObject<GMAScarAdapterBridge>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_placementId, JniHandleOwnership.DoNotTransfer);
			string string2 = JNIEnv.GetString(native_queryId, JniHandleOwnership.DoNotTransfer);
			string string3 = JNIEnv.GetString(native_adString, JniHandleOwnership.DoNotTransfer);
			string string4 = JNIEnv.GetString(native_adUnitId, JniHandleOwnership.DoNotTransfer);
			@object.Load(canSkip, @string, string2, string3, string4, videoLengthMs);
		}

		// Token: 0x060017F3 RID: 6131 RVA: 0x00045410 File Offset: 0x00043610
		[Register("load", "(ZLjava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;I)V", "GetLoad_ZLjava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_IHandler")]
		public unsafe virtual void Load(bool canSkip, string placementId, string queryId, string adString, string adUnitId, int videoLengthMs)
		{
			IntPtr intPtr = JNIEnv.NewString(placementId);
			IntPtr intPtr2 = JNIEnv.NewString(queryId);
			IntPtr intPtr3 = JNIEnv.NewString(adString);
			IntPtr intPtr4 = JNIEnv.NewString(adUnitId);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(canSkip);
				ptr[1] = new JniArgumentValue(intPtr);
				ptr[2] = new JniArgumentValue(intPtr2);
				ptr[3] = new JniArgumentValue(intPtr3);
				ptr[4] = new JniArgumentValue(intPtr4);
				ptr[5] = new JniArgumentValue(videoLengthMs);
				GMAScarAdapterBridge._members.InstanceMethods.InvokeVirtualVoidMethod("load.(ZLjava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;I)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				JNIEnv.DeleteLocalRef(intPtr2);
				JNIEnv.DeleteLocalRef(intPtr3);
				JNIEnv.DeleteLocalRef(intPtr4);
			}
		}

		// Token: 0x060017F4 RID: 6132 RVA: 0x00045508 File Offset: 0x00043708
		private static Delegate GetShow_Ljava_lang_String_Ljava_lang_String_ZHandler()
		{
			if (GMAScarAdapterBridge.cb_show_Ljava_lang_String_Ljava_lang_String_Z == null)
			{
				GMAScarAdapterBridge.cb_show_Ljava_lang_String_Ljava_lang_String_Z = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLLZ_V(GMAScarAdapterBridge.n_Show_Ljava_lang_String_Ljava_lang_String_Z));
			}
			return GMAScarAdapterBridge.cb_show_Ljava_lang_String_Ljava_lang_String_Z;
		}

		// Token: 0x060017F5 RID: 6133 RVA: 0x0004552C File Offset: 0x0004372C
		private static void n_Show_Ljava_lang_String_Ljava_lang_String_Z(IntPtr jnienv, IntPtr native__this, IntPtr native_placementId, IntPtr native_queryId, bool canSkip)
		{
			GMAScarAdapterBridge @object = Java.Lang.Object.GetObject<GMAScarAdapterBridge>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_placementId, JniHandleOwnership.DoNotTransfer);
			string string2 = JNIEnv.GetString(native_queryId, JniHandleOwnership.DoNotTransfer);
			@object.Show(@string, string2, canSkip);
		}

		// Token: 0x060017F6 RID: 6134 RVA: 0x0004555C File Offset: 0x0004375C
		[Register("show", "(Ljava/lang/String;Ljava/lang/String;Z)V", "GetShow_Ljava_lang_String_Ljava_lang_String_ZHandler")]
		public unsafe virtual void Show(string placementId, string queryId, bool canSkip)
		{
			IntPtr intPtr = JNIEnv.NewString(placementId);
			IntPtr intPtr2 = JNIEnv.NewString(queryId);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(intPtr2);
				ptr[2] = new JniArgumentValue(canSkip);
				GMAScarAdapterBridge._members.InstanceMethods.InvokeVirtualVoidMethod("show.(Ljava/lang/String;Ljava/lang/String;Z)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				JNIEnv.DeleteLocalRef(intPtr2);
			}
		}

		// Token: 0x040005CE RID: 1486
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/services/ads/gmascar/GMAScarAdapterBridge", typeof(GMAScarAdapterBridge));

		// Token: 0x040005CF RID: 1487
		private static Delegate cb_isInitialized;

		// Token: 0x040005D0 RID: 1488
		private static Delegate cb_getSCARSignals_arrayLjava_lang_String_arrayLjava_lang_String_;

		// Token: 0x040005D1 RID: 1489
		private static Delegate cb_getVersion;

		// Token: 0x040005D2 RID: 1490
		private static Delegate cb_initializeScar;

		// Token: 0x040005D3 RID: 1491
		private static Delegate cb_load_ZLjava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_I;

		// Token: 0x040005D4 RID: 1492
		private static Delegate cb_show_Ljava_lang_String_Ljava_lang_String_Z;
	}
}
