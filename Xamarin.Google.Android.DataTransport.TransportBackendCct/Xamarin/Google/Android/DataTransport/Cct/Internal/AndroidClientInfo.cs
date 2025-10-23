using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Xamarin.Google.Android.DataTransport.Cct.Internal
{
	// Token: 0x0200000B RID: 11
	[Register("com/google/android/datatransport/cct/internal/AndroidClientInfo", DoNotGenerateAcw = true)]
	public abstract class AndroidClientInfo : Java.Lang.Object
	{
		// Token: 0x17000013 RID: 19
		// (get) Token: 0x06000037 RID: 55 RVA: 0x00002660 File Offset: 0x00000860
		internal static IntPtr class_ref
		{
			get
			{
				return AndroidClientInfo._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x06000038 RID: 56 RVA: 0x00002684 File Offset: 0x00000884
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return AndroidClientInfo._members;
			}
		}

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x06000039 RID: 57 RVA: 0x0000268C File Offset: 0x0000088C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return AndroidClientInfo._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x0600003A RID: 58 RVA: 0x000026B0 File Offset: 0x000008B0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return AndroidClientInfo._members.ManagedPeerType;
			}
		}

		// Token: 0x0600003B RID: 59 RVA: 0x000020B4 File Offset: 0x000002B4
		protected AndroidClientInfo(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x0600003C RID: 60 RVA: 0x000026BC File Offset: 0x000008BC
		[Register(".ctor", "()V", "")]
		public AndroidClientInfo() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			base.SetHandle(AndroidClientInfo._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
			AndroidClientInfo._members.InstanceMethods.FinishCreateInstance("()V", this, null);
		}

		// Token: 0x0600003D RID: 61 RVA: 0x0000272A File Offset: 0x0000092A
		private static Delegate GetGetApplicationBuildHandler()
		{
			if (AndroidClientInfo.cb_getApplicationBuild == null)
			{
				AndroidClientInfo.cb_getApplicationBuild = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(AndroidClientInfo.n_GetApplicationBuild));
			}
			return AndroidClientInfo.cb_getApplicationBuild;
		}

		// Token: 0x0600003E RID: 62 RVA: 0x0000274E File Offset: 0x0000094E
		private static IntPtr n_GetApplicationBuild(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<AndroidClientInfo>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ApplicationBuild);
		}

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x0600003F RID: 63
		public abstract string ApplicationBuild { [Register("getApplicationBuild", "()Ljava/lang/String;", "GetGetApplicationBuildHandler")] get; }

		// Token: 0x06000040 RID: 64 RVA: 0x00002762 File Offset: 0x00000962
		private static Delegate GetGetCountryHandler()
		{
			if (AndroidClientInfo.cb_getCountry == null)
			{
				AndroidClientInfo.cb_getCountry = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(AndroidClientInfo.n_GetCountry));
			}
			return AndroidClientInfo.cb_getCountry;
		}

		// Token: 0x06000041 RID: 65 RVA: 0x00002786 File Offset: 0x00000986
		private static IntPtr n_GetCountry(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<AndroidClientInfo>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Country);
		}

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x06000042 RID: 66
		public abstract string Country { [Register("getCountry", "()Ljava/lang/String;", "GetGetCountryHandler")] get; }

		// Token: 0x06000043 RID: 67 RVA: 0x0000279A File Offset: 0x0000099A
		private static Delegate GetGetDeviceHandler()
		{
			if (AndroidClientInfo.cb_getDevice == null)
			{
				AndroidClientInfo.cb_getDevice = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(AndroidClientInfo.n_GetDevice));
			}
			return AndroidClientInfo.cb_getDevice;
		}

		// Token: 0x06000044 RID: 68 RVA: 0x000027BE File Offset: 0x000009BE
		private static IntPtr n_GetDevice(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<AndroidClientInfo>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Device);
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x06000045 RID: 69
		public abstract string Device { [Register("getDevice", "()Ljava/lang/String;", "GetGetDeviceHandler")] get; }

		// Token: 0x06000046 RID: 70 RVA: 0x000027D2 File Offset: 0x000009D2
		private static Delegate GetGetFingerprintHandler()
		{
			if (AndroidClientInfo.cb_getFingerprint == null)
			{
				AndroidClientInfo.cb_getFingerprint = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(AndroidClientInfo.n_GetFingerprint));
			}
			return AndroidClientInfo.cb_getFingerprint;
		}

		// Token: 0x06000047 RID: 71 RVA: 0x000027F6 File Offset: 0x000009F6
		private static IntPtr n_GetFingerprint(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<AndroidClientInfo>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Fingerprint);
		}

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x06000048 RID: 72
		public abstract string Fingerprint { [Register("getFingerprint", "()Ljava/lang/String;", "GetGetFingerprintHandler")] get; }

		// Token: 0x06000049 RID: 73 RVA: 0x0000280A File Offset: 0x00000A0A
		private static Delegate GetGetHardwareHandler()
		{
			if (AndroidClientInfo.cb_getHardware == null)
			{
				AndroidClientInfo.cb_getHardware = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(AndroidClientInfo.n_GetHardware));
			}
			return AndroidClientInfo.cb_getHardware;
		}

		// Token: 0x0600004A RID: 74 RVA: 0x0000282E File Offset: 0x00000A2E
		private static IntPtr n_GetHardware(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<AndroidClientInfo>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Hardware);
		}

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x0600004B RID: 75
		public abstract string Hardware { [Register("getHardware", "()Ljava/lang/String;", "GetGetHardwareHandler")] get; }

		// Token: 0x0600004C RID: 76 RVA: 0x00002842 File Offset: 0x00000A42
		private static Delegate GetGetLocaleHandler()
		{
			if (AndroidClientInfo.cb_getLocale == null)
			{
				AndroidClientInfo.cb_getLocale = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(AndroidClientInfo.n_GetLocale));
			}
			return AndroidClientInfo.cb_getLocale;
		}

		// Token: 0x0600004D RID: 77 RVA: 0x00002866 File Offset: 0x00000A66
		private static IntPtr n_GetLocale(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<AndroidClientInfo>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Locale);
		}

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x0600004E RID: 78
		public abstract string Locale { [Register("getLocale", "()Ljava/lang/String;", "GetGetLocaleHandler")] get; }

		// Token: 0x0600004F RID: 79 RVA: 0x0000287A File Offset: 0x00000A7A
		private static Delegate GetGetManufacturerHandler()
		{
			if (AndroidClientInfo.cb_getManufacturer == null)
			{
				AndroidClientInfo.cb_getManufacturer = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(AndroidClientInfo.n_GetManufacturer));
			}
			return AndroidClientInfo.cb_getManufacturer;
		}

		// Token: 0x06000050 RID: 80 RVA: 0x0000289E File Offset: 0x00000A9E
		private static IntPtr n_GetManufacturer(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<AndroidClientInfo>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Manufacturer);
		}

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x06000051 RID: 81
		public abstract string Manufacturer { [Register("getManufacturer", "()Ljava/lang/String;", "GetGetManufacturerHandler")] get; }

		// Token: 0x06000052 RID: 82 RVA: 0x000028B2 File Offset: 0x00000AB2
		private static Delegate GetGetMccMncHandler()
		{
			if (AndroidClientInfo.cb_getMccMnc == null)
			{
				AndroidClientInfo.cb_getMccMnc = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(AndroidClientInfo.n_GetMccMnc));
			}
			return AndroidClientInfo.cb_getMccMnc;
		}

		// Token: 0x06000053 RID: 83 RVA: 0x000028D6 File Offset: 0x00000AD6
		private static IntPtr n_GetMccMnc(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<AndroidClientInfo>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).MccMnc);
		}

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x06000054 RID: 84
		public abstract string MccMnc { [Register("getMccMnc", "()Ljava/lang/String;", "GetGetMccMncHandler")] get; }

		// Token: 0x06000055 RID: 85 RVA: 0x000028EA File Offset: 0x00000AEA
		private static Delegate GetGetModelHandler()
		{
			if (AndroidClientInfo.cb_getModel == null)
			{
				AndroidClientInfo.cb_getModel = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(AndroidClientInfo.n_GetModel));
			}
			return AndroidClientInfo.cb_getModel;
		}

		// Token: 0x06000056 RID: 86 RVA: 0x0000290E File Offset: 0x00000B0E
		private static IntPtr n_GetModel(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<AndroidClientInfo>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Model);
		}

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x06000057 RID: 87
		public abstract string Model { [Register("getModel", "()Ljava/lang/String;", "GetGetModelHandler")] get; }

		// Token: 0x06000058 RID: 88 RVA: 0x00002922 File Offset: 0x00000B22
		private static Delegate GetGetOsBuildHandler()
		{
			if (AndroidClientInfo.cb_getOsBuild == null)
			{
				AndroidClientInfo.cb_getOsBuild = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(AndroidClientInfo.n_GetOsBuild));
			}
			return AndroidClientInfo.cb_getOsBuild;
		}

		// Token: 0x06000059 RID: 89 RVA: 0x00002946 File Offset: 0x00000B46
		private static IntPtr n_GetOsBuild(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<AndroidClientInfo>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).OsBuild);
		}

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x0600005A RID: 90
		public abstract string OsBuild { [Register("getOsBuild", "()Ljava/lang/String;", "GetGetOsBuildHandler")] get; }

		// Token: 0x0600005B RID: 91 RVA: 0x0000295A File Offset: 0x00000B5A
		private static Delegate GetGetProductHandler()
		{
			if (AndroidClientInfo.cb_getProduct == null)
			{
				AndroidClientInfo.cb_getProduct = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(AndroidClientInfo.n_GetProduct));
			}
			return AndroidClientInfo.cb_getProduct;
		}

		// Token: 0x0600005C RID: 92 RVA: 0x0000297E File Offset: 0x00000B7E
		private static IntPtr n_GetProduct(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<AndroidClientInfo>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Product);
		}

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x0600005D RID: 93
		public abstract string Product { [Register("getProduct", "()Ljava/lang/String;", "GetGetProductHandler")] get; }

		// Token: 0x0600005E RID: 94 RVA: 0x00002992 File Offset: 0x00000B92
		private static Delegate GetGetSdkVersionHandler()
		{
			if (AndroidClientInfo.cb_getSdkVersion == null)
			{
				AndroidClientInfo.cb_getSdkVersion = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(AndroidClientInfo.n_GetSdkVersion));
			}
			return AndroidClientInfo.cb_getSdkVersion;
		}

		// Token: 0x0600005F RID: 95 RVA: 0x000029B6 File Offset: 0x00000BB6
		private static IntPtr n_GetSdkVersion(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<AndroidClientInfo>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SdkVersion);
		}

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x06000060 RID: 96
		public abstract Integer SdkVersion { [Register("getSdkVersion", "()Ljava/lang/Integer;", "GetGetSdkVersionHandler")] get; }

		// Token: 0x06000061 RID: 97 RVA: 0x000029CC File Offset: 0x00000BCC
		[Register("builder", "()Lcom/google/android/datatransport/cct/internal/AndroidClientInfo$Builder;", "")]
		public static AndroidClientInfo.Builder InvokeBuilder()
		{
			return Java.Lang.Object.GetObject<AndroidClientInfo.Builder>(AndroidClientInfo._members.StaticMethods.InvokeObjectMethod("builder.()Lcom/google/android/datatransport/cct/internal/AndroidClientInfo$Builder;", null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x04000005 RID: 5
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/google/android/datatransport/cct/internal/AndroidClientInfo", typeof(AndroidClientInfo));

		// Token: 0x04000006 RID: 6
		private static Delegate cb_getApplicationBuild;

		// Token: 0x04000007 RID: 7
		private static Delegate cb_getCountry;

		// Token: 0x04000008 RID: 8
		private static Delegate cb_getDevice;

		// Token: 0x04000009 RID: 9
		private static Delegate cb_getFingerprint;

		// Token: 0x0400000A RID: 10
		private static Delegate cb_getHardware;

		// Token: 0x0400000B RID: 11
		private static Delegate cb_getLocale;

		// Token: 0x0400000C RID: 12
		private static Delegate cb_getManufacturer;

		// Token: 0x0400000D RID: 13
		private static Delegate cb_getMccMnc;

		// Token: 0x0400000E RID: 14
		private static Delegate cb_getModel;

		// Token: 0x0400000F RID: 15
		private static Delegate cb_getOsBuild;

		// Token: 0x04000010 RID: 16
		private static Delegate cb_getProduct;

		// Token: 0x04000011 RID: 17
		private static Delegate cb_getSdkVersion;

		// Token: 0x0200000C RID: 12
		[Register("com/google/android/datatransport/cct/internal/AndroidClientInfo$Builder", DoNotGenerateAcw = true)]
		public abstract class Builder : Java.Lang.Object
		{
			// Token: 0x17000023 RID: 35
			// (get) Token: 0x06000063 RID: 99 RVA: 0x00002A18 File Offset: 0x00000C18
			internal static IntPtr class_ref
			{
				get
				{
					return AndroidClientInfo.Builder._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x17000024 RID: 36
			// (get) Token: 0x06000064 RID: 100 RVA: 0x00002A3C File Offset: 0x00000C3C
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return AndroidClientInfo.Builder._members;
				}
			}

			// Token: 0x17000025 RID: 37
			// (get) Token: 0x06000065 RID: 101 RVA: 0x00002A44 File Offset: 0x00000C44
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return AndroidClientInfo.Builder._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x17000026 RID: 38
			// (get) Token: 0x06000066 RID: 102 RVA: 0x00002A68 File Offset: 0x00000C68
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return AndroidClientInfo.Builder._members.ManagedPeerType;
				}
			}

			// Token: 0x06000067 RID: 103 RVA: 0x000020B4 File Offset: 0x000002B4
			protected Builder(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
			{
			}

			// Token: 0x06000068 RID: 104 RVA: 0x00002A74 File Offset: 0x00000C74
			[Register(".ctor", "()V", "")]
			public Builder() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (base.Handle != IntPtr.Zero)
				{
					return;
				}
				base.SetHandle(AndroidClientInfo.Builder._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
				AndroidClientInfo.Builder._members.InstanceMethods.FinishCreateInstance("()V", this, null);
			}

			// Token: 0x06000069 RID: 105 RVA: 0x00002AE2 File Offset: 0x00000CE2
			private static Delegate GetBuildHandler()
			{
				if (AndroidClientInfo.Builder.cb_build == null)
				{
					AndroidClientInfo.Builder.cb_build = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(AndroidClientInfo.Builder.n_Build));
				}
				return AndroidClientInfo.Builder.cb_build;
			}

			// Token: 0x0600006A RID: 106 RVA: 0x00002B06 File Offset: 0x00000D06
			private static IntPtr n_Build(IntPtr jnienv, IntPtr native__this)
			{
				return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<AndroidClientInfo.Builder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Build());
			}

			// Token: 0x0600006B RID: 107
			[Register("build", "()Lcom/google/android/datatransport/cct/internal/AndroidClientInfo;", "GetBuildHandler")]
			public abstract AndroidClientInfo Build();

			// Token: 0x0600006C RID: 108 RVA: 0x00002B1A File Offset: 0x00000D1A
			private static Delegate GetSetApplicationBuild_Ljava_lang_String_Handler()
			{
				if (AndroidClientInfo.Builder.cb_setApplicationBuild_Ljava_lang_String_ == null)
				{
					AndroidClientInfo.Builder.cb_setApplicationBuild_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(AndroidClientInfo.Builder.n_SetApplicationBuild_Ljava_lang_String_));
				}
				return AndroidClientInfo.Builder.cb_setApplicationBuild_Ljava_lang_String_;
			}

			// Token: 0x0600006D RID: 109 RVA: 0x00002B40 File Offset: 0x00000D40
			private static IntPtr n_SetApplicationBuild_Ljava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				AndroidClientInfo.Builder @object = Java.Lang.Object.GetObject<AndroidClientInfo.Builder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string @string = JNIEnv.GetString(native_p0, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle(@object.SetApplicationBuild(@string));
			}

			// Token: 0x0600006E RID: 110
			[Register("setApplicationBuild", "(Ljava/lang/String;)Lcom/google/android/datatransport/cct/internal/AndroidClientInfo$Builder;", "GetSetApplicationBuild_Ljava_lang_String_Handler")]
			public abstract AndroidClientInfo.Builder SetApplicationBuild(string p0);

			// Token: 0x0600006F RID: 111 RVA: 0x00002B68 File Offset: 0x00000D68
			private static Delegate GetSetCountry_Ljava_lang_String_Handler()
			{
				if (AndroidClientInfo.Builder.cb_setCountry_Ljava_lang_String_ == null)
				{
					AndroidClientInfo.Builder.cb_setCountry_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(AndroidClientInfo.Builder.n_SetCountry_Ljava_lang_String_));
				}
				return AndroidClientInfo.Builder.cb_setCountry_Ljava_lang_String_;
			}

			// Token: 0x06000070 RID: 112 RVA: 0x00002B8C File Offset: 0x00000D8C
			private static IntPtr n_SetCountry_Ljava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				AndroidClientInfo.Builder @object = Java.Lang.Object.GetObject<AndroidClientInfo.Builder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string @string = JNIEnv.GetString(native_p0, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle(@object.SetCountry(@string));
			}

			// Token: 0x06000071 RID: 113
			[Register("setCountry", "(Ljava/lang/String;)Lcom/google/android/datatransport/cct/internal/AndroidClientInfo$Builder;", "GetSetCountry_Ljava_lang_String_Handler")]
			public abstract AndroidClientInfo.Builder SetCountry(string p0);

			// Token: 0x06000072 RID: 114 RVA: 0x00002BB4 File Offset: 0x00000DB4
			private static Delegate GetSetDevice_Ljava_lang_String_Handler()
			{
				if (AndroidClientInfo.Builder.cb_setDevice_Ljava_lang_String_ == null)
				{
					AndroidClientInfo.Builder.cb_setDevice_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(AndroidClientInfo.Builder.n_SetDevice_Ljava_lang_String_));
				}
				return AndroidClientInfo.Builder.cb_setDevice_Ljava_lang_String_;
			}

			// Token: 0x06000073 RID: 115 RVA: 0x00002BD8 File Offset: 0x00000DD8
			private static IntPtr n_SetDevice_Ljava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				AndroidClientInfo.Builder @object = Java.Lang.Object.GetObject<AndroidClientInfo.Builder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string @string = JNIEnv.GetString(native_p0, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle(@object.SetDevice(@string));
			}

			// Token: 0x06000074 RID: 116
			[Register("setDevice", "(Ljava/lang/String;)Lcom/google/android/datatransport/cct/internal/AndroidClientInfo$Builder;", "GetSetDevice_Ljava_lang_String_Handler")]
			public abstract AndroidClientInfo.Builder SetDevice(string p0);

			// Token: 0x06000075 RID: 117 RVA: 0x00002C00 File Offset: 0x00000E00
			private static Delegate GetSetFingerprint_Ljava_lang_String_Handler()
			{
				if (AndroidClientInfo.Builder.cb_setFingerprint_Ljava_lang_String_ == null)
				{
					AndroidClientInfo.Builder.cb_setFingerprint_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(AndroidClientInfo.Builder.n_SetFingerprint_Ljava_lang_String_));
				}
				return AndroidClientInfo.Builder.cb_setFingerprint_Ljava_lang_String_;
			}

			// Token: 0x06000076 RID: 118 RVA: 0x00002C24 File Offset: 0x00000E24
			private static IntPtr n_SetFingerprint_Ljava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				AndroidClientInfo.Builder @object = Java.Lang.Object.GetObject<AndroidClientInfo.Builder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string @string = JNIEnv.GetString(native_p0, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle(@object.SetFingerprint(@string));
			}

			// Token: 0x06000077 RID: 119
			[Register("setFingerprint", "(Ljava/lang/String;)Lcom/google/android/datatransport/cct/internal/AndroidClientInfo$Builder;", "GetSetFingerprint_Ljava_lang_String_Handler")]
			public abstract AndroidClientInfo.Builder SetFingerprint(string p0);

			// Token: 0x06000078 RID: 120 RVA: 0x00002C4C File Offset: 0x00000E4C
			private static Delegate GetSetHardware_Ljava_lang_String_Handler()
			{
				if (AndroidClientInfo.Builder.cb_setHardware_Ljava_lang_String_ == null)
				{
					AndroidClientInfo.Builder.cb_setHardware_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(AndroidClientInfo.Builder.n_SetHardware_Ljava_lang_String_));
				}
				return AndroidClientInfo.Builder.cb_setHardware_Ljava_lang_String_;
			}

			// Token: 0x06000079 RID: 121 RVA: 0x00002C70 File Offset: 0x00000E70
			private static IntPtr n_SetHardware_Ljava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				AndroidClientInfo.Builder @object = Java.Lang.Object.GetObject<AndroidClientInfo.Builder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string @string = JNIEnv.GetString(native_p0, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle(@object.SetHardware(@string));
			}

			// Token: 0x0600007A RID: 122
			[Register("setHardware", "(Ljava/lang/String;)Lcom/google/android/datatransport/cct/internal/AndroidClientInfo$Builder;", "GetSetHardware_Ljava_lang_String_Handler")]
			public abstract AndroidClientInfo.Builder SetHardware(string p0);

			// Token: 0x0600007B RID: 123 RVA: 0x00002C98 File Offset: 0x00000E98
			private static Delegate GetSetLocale_Ljava_lang_String_Handler()
			{
				if (AndroidClientInfo.Builder.cb_setLocale_Ljava_lang_String_ == null)
				{
					AndroidClientInfo.Builder.cb_setLocale_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(AndroidClientInfo.Builder.n_SetLocale_Ljava_lang_String_));
				}
				return AndroidClientInfo.Builder.cb_setLocale_Ljava_lang_String_;
			}

			// Token: 0x0600007C RID: 124 RVA: 0x00002CBC File Offset: 0x00000EBC
			private static IntPtr n_SetLocale_Ljava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				AndroidClientInfo.Builder @object = Java.Lang.Object.GetObject<AndroidClientInfo.Builder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string @string = JNIEnv.GetString(native_p0, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle(@object.SetLocale(@string));
			}

			// Token: 0x0600007D RID: 125
			[Register("setLocale", "(Ljava/lang/String;)Lcom/google/android/datatransport/cct/internal/AndroidClientInfo$Builder;", "GetSetLocale_Ljava_lang_String_Handler")]
			public abstract AndroidClientInfo.Builder SetLocale(string p0);

			// Token: 0x0600007E RID: 126 RVA: 0x00002CE4 File Offset: 0x00000EE4
			private static Delegate GetSetManufacturer_Ljava_lang_String_Handler()
			{
				if (AndroidClientInfo.Builder.cb_setManufacturer_Ljava_lang_String_ == null)
				{
					AndroidClientInfo.Builder.cb_setManufacturer_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(AndroidClientInfo.Builder.n_SetManufacturer_Ljava_lang_String_));
				}
				return AndroidClientInfo.Builder.cb_setManufacturer_Ljava_lang_String_;
			}

			// Token: 0x0600007F RID: 127 RVA: 0x00002D08 File Offset: 0x00000F08
			private static IntPtr n_SetManufacturer_Ljava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				AndroidClientInfo.Builder @object = Java.Lang.Object.GetObject<AndroidClientInfo.Builder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string @string = JNIEnv.GetString(native_p0, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle(@object.SetManufacturer(@string));
			}

			// Token: 0x06000080 RID: 128
			[Register("setManufacturer", "(Ljava/lang/String;)Lcom/google/android/datatransport/cct/internal/AndroidClientInfo$Builder;", "GetSetManufacturer_Ljava_lang_String_Handler")]
			public abstract AndroidClientInfo.Builder SetManufacturer(string p0);

			// Token: 0x06000081 RID: 129 RVA: 0x00002D30 File Offset: 0x00000F30
			private static Delegate GetSetMccMnc_Ljava_lang_String_Handler()
			{
				if (AndroidClientInfo.Builder.cb_setMccMnc_Ljava_lang_String_ == null)
				{
					AndroidClientInfo.Builder.cb_setMccMnc_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(AndroidClientInfo.Builder.n_SetMccMnc_Ljava_lang_String_));
				}
				return AndroidClientInfo.Builder.cb_setMccMnc_Ljava_lang_String_;
			}

			// Token: 0x06000082 RID: 130 RVA: 0x00002D54 File Offset: 0x00000F54
			private static IntPtr n_SetMccMnc_Ljava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				AndroidClientInfo.Builder @object = Java.Lang.Object.GetObject<AndroidClientInfo.Builder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string @string = JNIEnv.GetString(native_p0, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle(@object.SetMccMnc(@string));
			}

			// Token: 0x06000083 RID: 131
			[Register("setMccMnc", "(Ljava/lang/String;)Lcom/google/android/datatransport/cct/internal/AndroidClientInfo$Builder;", "GetSetMccMnc_Ljava_lang_String_Handler")]
			public abstract AndroidClientInfo.Builder SetMccMnc(string p0);

			// Token: 0x06000084 RID: 132 RVA: 0x00002D7C File Offset: 0x00000F7C
			private static Delegate GetSetModel_Ljava_lang_String_Handler()
			{
				if (AndroidClientInfo.Builder.cb_setModel_Ljava_lang_String_ == null)
				{
					AndroidClientInfo.Builder.cb_setModel_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(AndroidClientInfo.Builder.n_SetModel_Ljava_lang_String_));
				}
				return AndroidClientInfo.Builder.cb_setModel_Ljava_lang_String_;
			}

			// Token: 0x06000085 RID: 133 RVA: 0x00002DA0 File Offset: 0x00000FA0
			private static IntPtr n_SetModel_Ljava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				AndroidClientInfo.Builder @object = Java.Lang.Object.GetObject<AndroidClientInfo.Builder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string @string = JNIEnv.GetString(native_p0, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle(@object.SetModel(@string));
			}

			// Token: 0x06000086 RID: 134
			[Register("setModel", "(Ljava/lang/String;)Lcom/google/android/datatransport/cct/internal/AndroidClientInfo$Builder;", "GetSetModel_Ljava_lang_String_Handler")]
			public abstract AndroidClientInfo.Builder SetModel(string p0);

			// Token: 0x06000087 RID: 135 RVA: 0x00002DC8 File Offset: 0x00000FC8
			private static Delegate GetSetOsBuild_Ljava_lang_String_Handler()
			{
				if (AndroidClientInfo.Builder.cb_setOsBuild_Ljava_lang_String_ == null)
				{
					AndroidClientInfo.Builder.cb_setOsBuild_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(AndroidClientInfo.Builder.n_SetOsBuild_Ljava_lang_String_));
				}
				return AndroidClientInfo.Builder.cb_setOsBuild_Ljava_lang_String_;
			}

			// Token: 0x06000088 RID: 136 RVA: 0x00002DEC File Offset: 0x00000FEC
			private static IntPtr n_SetOsBuild_Ljava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				AndroidClientInfo.Builder @object = Java.Lang.Object.GetObject<AndroidClientInfo.Builder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string @string = JNIEnv.GetString(native_p0, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle(@object.SetOsBuild(@string));
			}

			// Token: 0x06000089 RID: 137
			[Register("setOsBuild", "(Ljava/lang/String;)Lcom/google/android/datatransport/cct/internal/AndroidClientInfo$Builder;", "GetSetOsBuild_Ljava_lang_String_Handler")]
			public abstract AndroidClientInfo.Builder SetOsBuild(string p0);

			// Token: 0x0600008A RID: 138 RVA: 0x00002E14 File Offset: 0x00001014
			private static Delegate GetSetProduct_Ljava_lang_String_Handler()
			{
				if (AndroidClientInfo.Builder.cb_setProduct_Ljava_lang_String_ == null)
				{
					AndroidClientInfo.Builder.cb_setProduct_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(AndroidClientInfo.Builder.n_SetProduct_Ljava_lang_String_));
				}
				return AndroidClientInfo.Builder.cb_setProduct_Ljava_lang_String_;
			}

			// Token: 0x0600008B RID: 139 RVA: 0x00002E38 File Offset: 0x00001038
			private static IntPtr n_SetProduct_Ljava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				AndroidClientInfo.Builder @object = Java.Lang.Object.GetObject<AndroidClientInfo.Builder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string @string = JNIEnv.GetString(native_p0, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle(@object.SetProduct(@string));
			}

			// Token: 0x0600008C RID: 140
			[Register("setProduct", "(Ljava/lang/String;)Lcom/google/android/datatransport/cct/internal/AndroidClientInfo$Builder;", "GetSetProduct_Ljava_lang_String_Handler")]
			public abstract AndroidClientInfo.Builder SetProduct(string p0);

			// Token: 0x0600008D RID: 141 RVA: 0x00002E60 File Offset: 0x00001060
			private static Delegate GetSetSdkVersion_Ljava_lang_Integer_Handler()
			{
				if (AndroidClientInfo.Builder.cb_setSdkVersion_Ljava_lang_Integer_ == null)
				{
					AndroidClientInfo.Builder.cb_setSdkVersion_Ljava_lang_Integer_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(AndroidClientInfo.Builder.n_SetSdkVersion_Ljava_lang_Integer_));
				}
				return AndroidClientInfo.Builder.cb_setSdkVersion_Ljava_lang_Integer_;
			}

			// Token: 0x0600008E RID: 142 RVA: 0x00002E84 File Offset: 0x00001084
			private static IntPtr n_SetSdkVersion_Ljava_lang_Integer_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				AndroidClientInfo.Builder @object = Java.Lang.Object.GetObject<AndroidClientInfo.Builder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				Integer object2 = Java.Lang.Object.GetObject<Integer>(native_p0, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle(@object.SetSdkVersion(object2));
			}

			// Token: 0x0600008F RID: 143
			[Register("setSdkVersion", "(Ljava/lang/Integer;)Lcom/google/android/datatransport/cct/internal/AndroidClientInfo$Builder;", "GetSetSdkVersion_Ljava_lang_Integer_Handler")]
			public abstract AndroidClientInfo.Builder SetSdkVersion(Integer p0);

			// Token: 0x04000012 RID: 18
			private static readonly JniPeerMembers _members = new XAPeerMembers("com/google/android/datatransport/cct/internal/AndroidClientInfo$Builder", typeof(AndroidClientInfo.Builder));

			// Token: 0x04000013 RID: 19
			private static Delegate cb_build;

			// Token: 0x04000014 RID: 20
			private static Delegate cb_setApplicationBuild_Ljava_lang_String_;

			// Token: 0x04000015 RID: 21
			private static Delegate cb_setCountry_Ljava_lang_String_;

			// Token: 0x04000016 RID: 22
			private static Delegate cb_setDevice_Ljava_lang_String_;

			// Token: 0x04000017 RID: 23
			private static Delegate cb_setFingerprint_Ljava_lang_String_;

			// Token: 0x04000018 RID: 24
			private static Delegate cb_setHardware_Ljava_lang_String_;

			// Token: 0x04000019 RID: 25
			private static Delegate cb_setLocale_Ljava_lang_String_;

			// Token: 0x0400001A RID: 26
			private static Delegate cb_setManufacturer_Ljava_lang_String_;

			// Token: 0x0400001B RID: 27
			private static Delegate cb_setMccMnc_Ljava_lang_String_;

			// Token: 0x0400001C RID: 28
			private static Delegate cb_setModel_Ljava_lang_String_;

			// Token: 0x0400001D RID: 29
			private static Delegate cb_setOsBuild_Ljava_lang_String_;

			// Token: 0x0400001E RID: 30
			private static Delegate cb_setProduct_Ljava_lang_String_;

			// Token: 0x0400001F RID: 31
			private static Delegate cb_setSdkVersion_Ljava_lang_Integer_;
		}

		// Token: 0x0200000D RID: 13
		[Register("com/google/android/datatransport/cct/internal/AndroidClientInfo$Builder", DoNotGenerateAcw = true)]
		internal class BuilderInvoker : AndroidClientInfo.Builder
		{
			// Token: 0x06000091 RID: 145 RVA: 0x00002EC7 File Offset: 0x000010C7
			public BuilderInvoker(IntPtr handle, JniHandleOwnership transfer) : base(handle, transfer)
			{
			}

			// Token: 0x17000027 RID: 39
			// (get) Token: 0x06000092 RID: 146 RVA: 0x00002ED1 File Offset: 0x000010D1
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return AndroidClientInfo.BuilderInvoker._members;
				}
			}

			// Token: 0x17000028 RID: 40
			// (get) Token: 0x06000093 RID: 147 RVA: 0x00002ED8 File Offset: 0x000010D8
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return AndroidClientInfo.BuilderInvoker._members.ManagedPeerType;
				}
			}

			// Token: 0x06000094 RID: 148 RVA: 0x00002EE4 File Offset: 0x000010E4
			[Register("build", "()Lcom/google/android/datatransport/cct/internal/AndroidClientInfo;", "GetBuildHandler")]
			public override AndroidClientInfo Build()
			{
				return Java.Lang.Object.GetObject<AndroidClientInfo>(AndroidClientInfo.BuilderInvoker._members.InstanceMethods.InvokeAbstractObjectMethod("build.()Lcom/google/android/datatransport/cct/internal/AndroidClientInfo;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}

			// Token: 0x06000095 RID: 149 RVA: 0x00002F18 File Offset: 0x00001118
			[Register("setApplicationBuild", "(Ljava/lang/String;)Lcom/google/android/datatransport/cct/internal/AndroidClientInfo$Builder;", "GetSetApplicationBuild_Ljava_lang_String_Handler")]
			public unsafe override AndroidClientInfo.Builder SetApplicationBuild(string p0)
			{
				IntPtr intPtr = JNIEnv.NewString(p0);
				AndroidClientInfo.Builder @object;
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue(intPtr);
					@object = Java.Lang.Object.GetObject<AndroidClientInfo.Builder>(AndroidClientInfo.BuilderInvoker._members.InstanceMethods.InvokeAbstractObjectMethod("setApplicationBuild.(Ljava/lang/String;)Lcom/google/android/datatransport/cct/internal/AndroidClientInfo$Builder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
				}
				finally
				{
					JNIEnv.DeleteLocalRef(intPtr);
				}
				return @object;
			}

			// Token: 0x06000096 RID: 150 RVA: 0x00002F84 File Offset: 0x00001184
			[Register("setCountry", "(Ljava/lang/String;)Lcom/google/android/datatransport/cct/internal/AndroidClientInfo$Builder;", "GetSetCountry_Ljava_lang_String_Handler")]
			public unsafe override AndroidClientInfo.Builder SetCountry(string p0)
			{
				IntPtr intPtr = JNIEnv.NewString(p0);
				AndroidClientInfo.Builder @object;
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue(intPtr);
					@object = Java.Lang.Object.GetObject<AndroidClientInfo.Builder>(AndroidClientInfo.BuilderInvoker._members.InstanceMethods.InvokeAbstractObjectMethod("setCountry.(Ljava/lang/String;)Lcom/google/android/datatransport/cct/internal/AndroidClientInfo$Builder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
				}
				finally
				{
					JNIEnv.DeleteLocalRef(intPtr);
				}
				return @object;
			}

			// Token: 0x06000097 RID: 151 RVA: 0x00002FF0 File Offset: 0x000011F0
			[Register("setDevice", "(Ljava/lang/String;)Lcom/google/android/datatransport/cct/internal/AndroidClientInfo$Builder;", "GetSetDevice_Ljava_lang_String_Handler")]
			public unsafe override AndroidClientInfo.Builder SetDevice(string p0)
			{
				IntPtr intPtr = JNIEnv.NewString(p0);
				AndroidClientInfo.Builder @object;
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue(intPtr);
					@object = Java.Lang.Object.GetObject<AndroidClientInfo.Builder>(AndroidClientInfo.BuilderInvoker._members.InstanceMethods.InvokeAbstractObjectMethod("setDevice.(Ljava/lang/String;)Lcom/google/android/datatransport/cct/internal/AndroidClientInfo$Builder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
				}
				finally
				{
					JNIEnv.DeleteLocalRef(intPtr);
				}
				return @object;
			}

			// Token: 0x06000098 RID: 152 RVA: 0x0000305C File Offset: 0x0000125C
			[Register("setFingerprint", "(Ljava/lang/String;)Lcom/google/android/datatransport/cct/internal/AndroidClientInfo$Builder;", "GetSetFingerprint_Ljava_lang_String_Handler")]
			public unsafe override AndroidClientInfo.Builder SetFingerprint(string p0)
			{
				IntPtr intPtr = JNIEnv.NewString(p0);
				AndroidClientInfo.Builder @object;
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue(intPtr);
					@object = Java.Lang.Object.GetObject<AndroidClientInfo.Builder>(AndroidClientInfo.BuilderInvoker._members.InstanceMethods.InvokeAbstractObjectMethod("setFingerprint.(Ljava/lang/String;)Lcom/google/android/datatransport/cct/internal/AndroidClientInfo$Builder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
				}
				finally
				{
					JNIEnv.DeleteLocalRef(intPtr);
				}
				return @object;
			}

			// Token: 0x06000099 RID: 153 RVA: 0x000030C8 File Offset: 0x000012C8
			[Register("setHardware", "(Ljava/lang/String;)Lcom/google/android/datatransport/cct/internal/AndroidClientInfo$Builder;", "GetSetHardware_Ljava_lang_String_Handler")]
			public unsafe override AndroidClientInfo.Builder SetHardware(string p0)
			{
				IntPtr intPtr = JNIEnv.NewString(p0);
				AndroidClientInfo.Builder @object;
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue(intPtr);
					@object = Java.Lang.Object.GetObject<AndroidClientInfo.Builder>(AndroidClientInfo.BuilderInvoker._members.InstanceMethods.InvokeAbstractObjectMethod("setHardware.(Ljava/lang/String;)Lcom/google/android/datatransport/cct/internal/AndroidClientInfo$Builder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
				}
				finally
				{
					JNIEnv.DeleteLocalRef(intPtr);
				}
				return @object;
			}

			// Token: 0x0600009A RID: 154 RVA: 0x00003134 File Offset: 0x00001334
			[Register("setLocale", "(Ljava/lang/String;)Lcom/google/android/datatransport/cct/internal/AndroidClientInfo$Builder;", "GetSetLocale_Ljava_lang_String_Handler")]
			public unsafe override AndroidClientInfo.Builder SetLocale(string p0)
			{
				IntPtr intPtr = JNIEnv.NewString(p0);
				AndroidClientInfo.Builder @object;
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue(intPtr);
					@object = Java.Lang.Object.GetObject<AndroidClientInfo.Builder>(AndroidClientInfo.BuilderInvoker._members.InstanceMethods.InvokeAbstractObjectMethod("setLocale.(Ljava/lang/String;)Lcom/google/android/datatransport/cct/internal/AndroidClientInfo$Builder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
				}
				finally
				{
					JNIEnv.DeleteLocalRef(intPtr);
				}
				return @object;
			}

			// Token: 0x0600009B RID: 155 RVA: 0x000031A0 File Offset: 0x000013A0
			[Register("setManufacturer", "(Ljava/lang/String;)Lcom/google/android/datatransport/cct/internal/AndroidClientInfo$Builder;", "GetSetManufacturer_Ljava_lang_String_Handler")]
			public unsafe override AndroidClientInfo.Builder SetManufacturer(string p0)
			{
				IntPtr intPtr = JNIEnv.NewString(p0);
				AndroidClientInfo.Builder @object;
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue(intPtr);
					@object = Java.Lang.Object.GetObject<AndroidClientInfo.Builder>(AndroidClientInfo.BuilderInvoker._members.InstanceMethods.InvokeAbstractObjectMethod("setManufacturer.(Ljava/lang/String;)Lcom/google/android/datatransport/cct/internal/AndroidClientInfo$Builder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
				}
				finally
				{
					JNIEnv.DeleteLocalRef(intPtr);
				}
				return @object;
			}

			// Token: 0x0600009C RID: 156 RVA: 0x0000320C File Offset: 0x0000140C
			[Register("setMccMnc", "(Ljava/lang/String;)Lcom/google/android/datatransport/cct/internal/AndroidClientInfo$Builder;", "GetSetMccMnc_Ljava_lang_String_Handler")]
			public unsafe override AndroidClientInfo.Builder SetMccMnc(string p0)
			{
				IntPtr intPtr = JNIEnv.NewString(p0);
				AndroidClientInfo.Builder @object;
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue(intPtr);
					@object = Java.Lang.Object.GetObject<AndroidClientInfo.Builder>(AndroidClientInfo.BuilderInvoker._members.InstanceMethods.InvokeAbstractObjectMethod("setMccMnc.(Ljava/lang/String;)Lcom/google/android/datatransport/cct/internal/AndroidClientInfo$Builder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
				}
				finally
				{
					JNIEnv.DeleteLocalRef(intPtr);
				}
				return @object;
			}

			// Token: 0x0600009D RID: 157 RVA: 0x00003278 File Offset: 0x00001478
			[Register("setModel", "(Ljava/lang/String;)Lcom/google/android/datatransport/cct/internal/AndroidClientInfo$Builder;", "GetSetModel_Ljava_lang_String_Handler")]
			public unsafe override AndroidClientInfo.Builder SetModel(string p0)
			{
				IntPtr intPtr = JNIEnv.NewString(p0);
				AndroidClientInfo.Builder @object;
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue(intPtr);
					@object = Java.Lang.Object.GetObject<AndroidClientInfo.Builder>(AndroidClientInfo.BuilderInvoker._members.InstanceMethods.InvokeAbstractObjectMethod("setModel.(Ljava/lang/String;)Lcom/google/android/datatransport/cct/internal/AndroidClientInfo$Builder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
				}
				finally
				{
					JNIEnv.DeleteLocalRef(intPtr);
				}
				return @object;
			}

			// Token: 0x0600009E RID: 158 RVA: 0x000032E4 File Offset: 0x000014E4
			[Register("setOsBuild", "(Ljava/lang/String;)Lcom/google/android/datatransport/cct/internal/AndroidClientInfo$Builder;", "GetSetOsBuild_Ljava_lang_String_Handler")]
			public unsafe override AndroidClientInfo.Builder SetOsBuild(string p0)
			{
				IntPtr intPtr = JNIEnv.NewString(p0);
				AndroidClientInfo.Builder @object;
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue(intPtr);
					@object = Java.Lang.Object.GetObject<AndroidClientInfo.Builder>(AndroidClientInfo.BuilderInvoker._members.InstanceMethods.InvokeAbstractObjectMethod("setOsBuild.(Ljava/lang/String;)Lcom/google/android/datatransport/cct/internal/AndroidClientInfo$Builder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
				}
				finally
				{
					JNIEnv.DeleteLocalRef(intPtr);
				}
				return @object;
			}

			// Token: 0x0600009F RID: 159 RVA: 0x00003350 File Offset: 0x00001550
			[Register("setProduct", "(Ljava/lang/String;)Lcom/google/android/datatransport/cct/internal/AndroidClientInfo$Builder;", "GetSetProduct_Ljava_lang_String_Handler")]
			public unsafe override AndroidClientInfo.Builder SetProduct(string p0)
			{
				IntPtr intPtr = JNIEnv.NewString(p0);
				AndroidClientInfo.Builder @object;
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue(intPtr);
					@object = Java.Lang.Object.GetObject<AndroidClientInfo.Builder>(AndroidClientInfo.BuilderInvoker._members.InstanceMethods.InvokeAbstractObjectMethod("setProduct.(Ljava/lang/String;)Lcom/google/android/datatransport/cct/internal/AndroidClientInfo$Builder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
				}
				finally
				{
					JNIEnv.DeleteLocalRef(intPtr);
				}
				return @object;
			}

			// Token: 0x060000A0 RID: 160 RVA: 0x000033BC File Offset: 0x000015BC
			[Register("setSdkVersion", "(Ljava/lang/Integer;)Lcom/google/android/datatransport/cct/internal/AndroidClientInfo$Builder;", "GetSetSdkVersion_Ljava_lang_Integer_Handler")]
			public unsafe override AndroidClientInfo.Builder SetSdkVersion(Integer p0)
			{
				AndroidClientInfo.Builder @object;
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((p0 == null) ? IntPtr.Zero : p0.Handle);
					@object = Java.Lang.Object.GetObject<AndroidClientInfo.Builder>(AndroidClientInfo.BuilderInvoker._members.InstanceMethods.InvokeAbstractObjectMethod("setSdkVersion.(Ljava/lang/Integer;)Lcom/google/android/datatransport/cct/internal/AndroidClientInfo$Builder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
				}
				finally
				{
					GC.KeepAlive(p0);
				}
				return @object;
			}

			// Token: 0x04000020 RID: 32
			private static readonly JniPeerMembers _members = new XAPeerMembers("com/google/android/datatransport/cct/internal/AndroidClientInfo$Builder", typeof(AndroidClientInfo.BuilderInvoker));
		}
	}
}
