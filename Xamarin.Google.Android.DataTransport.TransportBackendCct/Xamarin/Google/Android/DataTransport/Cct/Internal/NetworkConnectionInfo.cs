using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Xamarin.Google.Android.DataTransport.Cct.Internal
{
	// Token: 0x02000020 RID: 32
	[Register("com/google/android/datatransport/cct/internal/NetworkConnectionInfo", DoNotGenerateAcw = true)]
	public abstract class NetworkConnectionInfo : Java.Lang.Object
	{
		// Token: 0x1700008D RID: 141
		// (get) Token: 0x060001A5 RID: 421 RVA: 0x00005520 File Offset: 0x00003720
		internal static IntPtr class_ref
		{
			get
			{
				return NetworkConnectionInfo._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700008E RID: 142
		// (get) Token: 0x060001A6 RID: 422 RVA: 0x00005544 File Offset: 0x00003744
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return NetworkConnectionInfo._members;
			}
		}

		// Token: 0x1700008F RID: 143
		// (get) Token: 0x060001A7 RID: 423 RVA: 0x0000554C File Offset: 0x0000374C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return NetworkConnectionInfo._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000090 RID: 144
		// (get) Token: 0x060001A8 RID: 424 RVA: 0x00005570 File Offset: 0x00003770
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return NetworkConnectionInfo._members.ManagedPeerType;
			}
		}

		// Token: 0x060001A9 RID: 425 RVA: 0x000020B4 File Offset: 0x000002B4
		protected NetworkConnectionInfo(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x060001AA RID: 426 RVA: 0x0000557C File Offset: 0x0000377C
		[Register(".ctor", "()V", "")]
		public NetworkConnectionInfo() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			base.SetHandle(NetworkConnectionInfo._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
			NetworkConnectionInfo._members.InstanceMethods.FinishCreateInstance("()V", this, null);
		}

		// Token: 0x060001AB RID: 427 RVA: 0x000055EC File Offset: 0x000037EC
		[Register("builder", "()Lcom/google/android/datatransport/cct/internal/NetworkConnectionInfo$Builder;", "")]
		public static NetworkConnectionInfo.Builder InvokeBuilder()
		{
			return Java.Lang.Object.GetObject<NetworkConnectionInfo.Builder>(NetworkConnectionInfo._members.StaticMethods.InvokeObjectMethod("builder.()Lcom/google/android/datatransport/cct/internal/NetworkConnectionInfo$Builder;", null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x060001AC RID: 428 RVA: 0x0000561D File Offset: 0x0000381D
		private static Delegate GetGetMobileSubtypeHandler()
		{
			if (NetworkConnectionInfo.cb_getMobileSubtype == null)
			{
				NetworkConnectionInfo.cb_getMobileSubtype = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(NetworkConnectionInfo.n_GetMobileSubtype));
			}
			return NetworkConnectionInfo.cb_getMobileSubtype;
		}

		// Token: 0x060001AD RID: 429 RVA: 0x00005641 File Offset: 0x00003841
		private static IntPtr n_GetMobileSubtype(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<NetworkConnectionInfo>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).GetMobileSubtype());
		}

		// Token: 0x060001AE RID: 430
		[Register("getMobileSubtype", "()Lcom/google/android/datatransport/cct/internal/NetworkConnectionInfo$MobileSubtype;", "GetGetMobileSubtypeHandler")]
		public abstract NetworkConnectionInfo.MobileSubtype GetMobileSubtype();

		// Token: 0x060001AF RID: 431 RVA: 0x00005655 File Offset: 0x00003855
		private static Delegate GetGetNetworkTypeHandler()
		{
			if (NetworkConnectionInfo.cb_getNetworkType == null)
			{
				NetworkConnectionInfo.cb_getNetworkType = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(NetworkConnectionInfo.n_GetNetworkType));
			}
			return NetworkConnectionInfo.cb_getNetworkType;
		}

		// Token: 0x060001B0 RID: 432 RVA: 0x00005679 File Offset: 0x00003879
		private static IntPtr n_GetNetworkType(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<NetworkConnectionInfo>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).GetNetworkType());
		}

		// Token: 0x060001B1 RID: 433
		[Register("getNetworkType", "()Lcom/google/android/datatransport/cct/internal/NetworkConnectionInfo$NetworkType;", "GetGetNetworkTypeHandler")]
		public abstract NetworkConnectionInfo.NetworkType GetNetworkType();

		// Token: 0x04000056 RID: 86
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/google/android/datatransport/cct/internal/NetworkConnectionInfo", typeof(NetworkConnectionInfo));

		// Token: 0x04000057 RID: 87
		private static Delegate cb_getMobileSubtype;

		// Token: 0x04000058 RID: 88
		private static Delegate cb_getNetworkType;

		// Token: 0x02000021 RID: 33
		[Register("com/google/android/datatransport/cct/internal/NetworkConnectionInfo$Builder", DoNotGenerateAcw = true)]
		public abstract class Builder : Java.Lang.Object
		{
			// Token: 0x17000091 RID: 145
			// (get) Token: 0x060001B3 RID: 435 RVA: 0x000056A8 File Offset: 0x000038A8
			internal static IntPtr class_ref
			{
				get
				{
					return NetworkConnectionInfo.Builder._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x17000092 RID: 146
			// (get) Token: 0x060001B4 RID: 436 RVA: 0x000056CC File Offset: 0x000038CC
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return NetworkConnectionInfo.Builder._members;
				}
			}

			// Token: 0x17000093 RID: 147
			// (get) Token: 0x060001B5 RID: 437 RVA: 0x000056D4 File Offset: 0x000038D4
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return NetworkConnectionInfo.Builder._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x17000094 RID: 148
			// (get) Token: 0x060001B6 RID: 438 RVA: 0x000056F8 File Offset: 0x000038F8
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return NetworkConnectionInfo.Builder._members.ManagedPeerType;
				}
			}

			// Token: 0x060001B7 RID: 439 RVA: 0x000020B4 File Offset: 0x000002B4
			protected Builder(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
			{
			}

			// Token: 0x060001B8 RID: 440 RVA: 0x00005704 File Offset: 0x00003904
			[Register(".ctor", "()V", "")]
			public Builder() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (base.Handle != IntPtr.Zero)
				{
					return;
				}
				base.SetHandle(NetworkConnectionInfo.Builder._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
				NetworkConnectionInfo.Builder._members.InstanceMethods.FinishCreateInstance("()V", this, null);
			}

			// Token: 0x060001B9 RID: 441 RVA: 0x00005772 File Offset: 0x00003972
			private static Delegate GetBuildHandler()
			{
				if (NetworkConnectionInfo.Builder.cb_build == null)
				{
					NetworkConnectionInfo.Builder.cb_build = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(NetworkConnectionInfo.Builder.n_Build));
				}
				return NetworkConnectionInfo.Builder.cb_build;
			}

			// Token: 0x060001BA RID: 442 RVA: 0x00005796 File Offset: 0x00003996
			private static IntPtr n_Build(IntPtr jnienv, IntPtr native__this)
			{
				return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<NetworkConnectionInfo.Builder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Build());
			}

			// Token: 0x060001BB RID: 443
			[Register("build", "()Lcom/google/android/datatransport/cct/internal/NetworkConnectionInfo;", "GetBuildHandler")]
			public abstract NetworkConnectionInfo Build();

			// Token: 0x060001BC RID: 444 RVA: 0x000057AA File Offset: 0x000039AA
			private static Delegate GetSetMobileSubtype_Lcom_google_android_datatransport_cct_internal_NetworkConnectionInfo_MobileSubtype_Handler()
			{
				if (NetworkConnectionInfo.Builder.cb_setMobileSubtype_Lcom_google_android_datatransport_cct_internal_NetworkConnectionInfo_MobileSubtype_ == null)
				{
					NetworkConnectionInfo.Builder.cb_setMobileSubtype_Lcom_google_android_datatransport_cct_internal_NetworkConnectionInfo_MobileSubtype_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(NetworkConnectionInfo.Builder.n_SetMobileSubtype_Lcom_google_android_datatransport_cct_internal_NetworkConnectionInfo_MobileSubtype_));
				}
				return NetworkConnectionInfo.Builder.cb_setMobileSubtype_Lcom_google_android_datatransport_cct_internal_NetworkConnectionInfo_MobileSubtype_;
			}

			// Token: 0x060001BD RID: 445 RVA: 0x000057D0 File Offset: 0x000039D0
			private static IntPtr n_SetMobileSubtype_Lcom_google_android_datatransport_cct_internal_NetworkConnectionInfo_MobileSubtype_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				NetworkConnectionInfo.Builder @object = Java.Lang.Object.GetObject<NetworkConnectionInfo.Builder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				NetworkConnectionInfo.MobileSubtype object2 = Java.Lang.Object.GetObject<NetworkConnectionInfo.MobileSubtype>(native_p0, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle(@object.SetMobileSubtype(object2));
			}

			// Token: 0x060001BE RID: 446
			[Register("setMobileSubtype", "(Lcom/google/android/datatransport/cct/internal/NetworkConnectionInfo$MobileSubtype;)Lcom/google/android/datatransport/cct/internal/NetworkConnectionInfo$Builder;", "GetSetMobileSubtype_Lcom_google_android_datatransport_cct_internal_NetworkConnectionInfo_MobileSubtype_Handler")]
			public abstract NetworkConnectionInfo.Builder SetMobileSubtype(NetworkConnectionInfo.MobileSubtype p0);

			// Token: 0x060001BF RID: 447 RVA: 0x000057F8 File Offset: 0x000039F8
			private static Delegate GetSetNetworkType_Lcom_google_android_datatransport_cct_internal_NetworkConnectionInfo_NetworkType_Handler()
			{
				if (NetworkConnectionInfo.Builder.cb_setNetworkType_Lcom_google_android_datatransport_cct_internal_NetworkConnectionInfo_NetworkType_ == null)
				{
					NetworkConnectionInfo.Builder.cb_setNetworkType_Lcom_google_android_datatransport_cct_internal_NetworkConnectionInfo_NetworkType_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(NetworkConnectionInfo.Builder.n_SetNetworkType_Lcom_google_android_datatransport_cct_internal_NetworkConnectionInfo_NetworkType_));
				}
				return NetworkConnectionInfo.Builder.cb_setNetworkType_Lcom_google_android_datatransport_cct_internal_NetworkConnectionInfo_NetworkType_;
			}

			// Token: 0x060001C0 RID: 448 RVA: 0x0000581C File Offset: 0x00003A1C
			private static IntPtr n_SetNetworkType_Lcom_google_android_datatransport_cct_internal_NetworkConnectionInfo_NetworkType_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				NetworkConnectionInfo.Builder @object = Java.Lang.Object.GetObject<NetworkConnectionInfo.Builder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				NetworkConnectionInfo.NetworkType object2 = Java.Lang.Object.GetObject<NetworkConnectionInfo.NetworkType>(native_p0, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle(@object.SetNetworkType(object2));
			}

			// Token: 0x060001C1 RID: 449
			[Register("setNetworkType", "(Lcom/google/android/datatransport/cct/internal/NetworkConnectionInfo$NetworkType;)Lcom/google/android/datatransport/cct/internal/NetworkConnectionInfo$Builder;", "GetSetNetworkType_Lcom_google_android_datatransport_cct_internal_NetworkConnectionInfo_NetworkType_Handler")]
			public abstract NetworkConnectionInfo.Builder SetNetworkType(NetworkConnectionInfo.NetworkType p0);

			// Token: 0x04000059 RID: 89
			private static readonly JniPeerMembers _members = new XAPeerMembers("com/google/android/datatransport/cct/internal/NetworkConnectionInfo$Builder", typeof(NetworkConnectionInfo.Builder));

			// Token: 0x0400005A RID: 90
			private static Delegate cb_build;

			// Token: 0x0400005B RID: 91
			private static Delegate cb_setMobileSubtype_Lcom_google_android_datatransport_cct_internal_NetworkConnectionInfo_MobileSubtype_;

			// Token: 0x0400005C RID: 92
			private static Delegate cb_setNetworkType_Lcom_google_android_datatransport_cct_internal_NetworkConnectionInfo_NetworkType_;
		}

		// Token: 0x02000022 RID: 34
		[Register("com/google/android/datatransport/cct/internal/NetworkConnectionInfo$Builder", DoNotGenerateAcw = true)]
		internal class BuilderInvoker : NetworkConnectionInfo.Builder
		{
			// Token: 0x060001C3 RID: 451 RVA: 0x0000585F File Offset: 0x00003A5F
			public BuilderInvoker(IntPtr handle, JniHandleOwnership transfer) : base(handle, transfer)
			{
			}

			// Token: 0x17000095 RID: 149
			// (get) Token: 0x060001C4 RID: 452 RVA: 0x00005869 File Offset: 0x00003A69
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return NetworkConnectionInfo.BuilderInvoker._members;
				}
			}

			// Token: 0x17000096 RID: 150
			// (get) Token: 0x060001C5 RID: 453 RVA: 0x00005870 File Offset: 0x00003A70
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return NetworkConnectionInfo.BuilderInvoker._members.ManagedPeerType;
				}
			}

			// Token: 0x060001C6 RID: 454 RVA: 0x0000587C File Offset: 0x00003A7C
			[Register("build", "()Lcom/google/android/datatransport/cct/internal/NetworkConnectionInfo;", "GetBuildHandler")]
			public override NetworkConnectionInfo Build()
			{
				return Java.Lang.Object.GetObject<NetworkConnectionInfo>(NetworkConnectionInfo.BuilderInvoker._members.InstanceMethods.InvokeAbstractObjectMethod("build.()Lcom/google/android/datatransport/cct/internal/NetworkConnectionInfo;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}

			// Token: 0x060001C7 RID: 455 RVA: 0x000058B0 File Offset: 0x00003AB0
			[Register("setMobileSubtype", "(Lcom/google/android/datatransport/cct/internal/NetworkConnectionInfo$MobileSubtype;)Lcom/google/android/datatransport/cct/internal/NetworkConnectionInfo$Builder;", "GetSetMobileSubtype_Lcom_google_android_datatransport_cct_internal_NetworkConnectionInfo_MobileSubtype_Handler")]
			public unsafe override NetworkConnectionInfo.Builder SetMobileSubtype(NetworkConnectionInfo.MobileSubtype p0)
			{
				NetworkConnectionInfo.Builder @object;
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((p0 == null) ? IntPtr.Zero : p0.Handle);
					@object = Java.Lang.Object.GetObject<NetworkConnectionInfo.Builder>(NetworkConnectionInfo.BuilderInvoker._members.InstanceMethods.InvokeAbstractObjectMethod("setMobileSubtype.(Lcom/google/android/datatransport/cct/internal/NetworkConnectionInfo$MobileSubtype;)Lcom/google/android/datatransport/cct/internal/NetworkConnectionInfo$Builder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
				}
				finally
				{
					GC.KeepAlive(p0);
				}
				return @object;
			}

			// Token: 0x060001C8 RID: 456 RVA: 0x00005924 File Offset: 0x00003B24
			[Register("setNetworkType", "(Lcom/google/android/datatransport/cct/internal/NetworkConnectionInfo$NetworkType;)Lcom/google/android/datatransport/cct/internal/NetworkConnectionInfo$Builder;", "GetSetNetworkType_Lcom_google_android_datatransport_cct_internal_NetworkConnectionInfo_NetworkType_Handler")]
			public unsafe override NetworkConnectionInfo.Builder SetNetworkType(NetworkConnectionInfo.NetworkType p0)
			{
				NetworkConnectionInfo.Builder @object;
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((p0 == null) ? IntPtr.Zero : p0.Handle);
					@object = Java.Lang.Object.GetObject<NetworkConnectionInfo.Builder>(NetworkConnectionInfo.BuilderInvoker._members.InstanceMethods.InvokeAbstractObjectMethod("setNetworkType.(Lcom/google/android/datatransport/cct/internal/NetworkConnectionInfo$NetworkType;)Lcom/google/android/datatransport/cct/internal/NetworkConnectionInfo$Builder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
				}
				finally
				{
					GC.KeepAlive(p0);
				}
				return @object;
			}

			// Token: 0x0400005D RID: 93
			private static readonly JniPeerMembers _members = new XAPeerMembers("com/google/android/datatransport/cct/internal/NetworkConnectionInfo$Builder", typeof(NetworkConnectionInfo.BuilderInvoker));
		}

		// Token: 0x02000023 RID: 35
		[Register("com/google/android/datatransport/cct/internal/NetworkConnectionInfo$MobileSubtype", DoNotGenerateAcw = true)]
		public sealed class MobileSubtype : Java.Lang.Enum
		{
			// Token: 0x17000097 RID: 151
			// (get) Token: 0x060001CA RID: 458 RVA: 0x000059B4 File Offset: 0x00003BB4
			[Register("CDMA")]
			public static NetworkConnectionInfo.MobileSubtype Cdma
			{
				get
				{
					return Java.Lang.Object.GetObject<NetworkConnectionInfo.MobileSubtype>(NetworkConnectionInfo.MobileSubtype._members.StaticFields.GetObjectValue("CDMA.Lcom/google/android/datatransport/cct/internal/NetworkConnectionInfo$MobileSubtype;").Handle, JniHandleOwnership.TransferLocalRef);
				}
			}

			// Token: 0x17000098 RID: 152
			// (get) Token: 0x060001CB RID: 459 RVA: 0x000059E4 File Offset: 0x00003BE4
			[Register("COMBINED")]
			public static NetworkConnectionInfo.MobileSubtype Combined
			{
				get
				{
					return Java.Lang.Object.GetObject<NetworkConnectionInfo.MobileSubtype>(NetworkConnectionInfo.MobileSubtype._members.StaticFields.GetObjectValue("COMBINED.Lcom/google/android/datatransport/cct/internal/NetworkConnectionInfo$MobileSubtype;").Handle, JniHandleOwnership.TransferLocalRef);
				}
			}

			// Token: 0x17000099 RID: 153
			// (get) Token: 0x060001CC RID: 460 RVA: 0x00005A14 File Offset: 0x00003C14
			[Register("EDGE")]
			public static NetworkConnectionInfo.MobileSubtype Edge
			{
				get
				{
					return Java.Lang.Object.GetObject<NetworkConnectionInfo.MobileSubtype>(NetworkConnectionInfo.MobileSubtype._members.StaticFields.GetObjectValue("EDGE.Lcom/google/android/datatransport/cct/internal/NetworkConnectionInfo$MobileSubtype;").Handle, JniHandleOwnership.TransferLocalRef);
				}
			}

			// Token: 0x1700009A RID: 154
			// (get) Token: 0x060001CD RID: 461 RVA: 0x00005A44 File Offset: 0x00003C44
			[Register("EHRPD")]
			public static NetworkConnectionInfo.MobileSubtype Ehrpd
			{
				get
				{
					return Java.Lang.Object.GetObject<NetworkConnectionInfo.MobileSubtype>(NetworkConnectionInfo.MobileSubtype._members.StaticFields.GetObjectValue("EHRPD.Lcom/google/android/datatransport/cct/internal/NetworkConnectionInfo$MobileSubtype;").Handle, JniHandleOwnership.TransferLocalRef);
				}
			}

			// Token: 0x1700009B RID: 155
			// (get) Token: 0x060001CE RID: 462 RVA: 0x00005A74 File Offset: 0x00003C74
			[Register("EVDO_0")]
			public static NetworkConnectionInfo.MobileSubtype Evdo0
			{
				get
				{
					return Java.Lang.Object.GetObject<NetworkConnectionInfo.MobileSubtype>(NetworkConnectionInfo.MobileSubtype._members.StaticFields.GetObjectValue("EVDO_0.Lcom/google/android/datatransport/cct/internal/NetworkConnectionInfo$MobileSubtype;").Handle, JniHandleOwnership.TransferLocalRef);
				}
			}

			// Token: 0x1700009C RID: 156
			// (get) Token: 0x060001CF RID: 463 RVA: 0x00005AA4 File Offset: 0x00003CA4
			[Register("EVDO_A")]
			public static NetworkConnectionInfo.MobileSubtype EvdoA
			{
				get
				{
					return Java.Lang.Object.GetObject<NetworkConnectionInfo.MobileSubtype>(NetworkConnectionInfo.MobileSubtype._members.StaticFields.GetObjectValue("EVDO_A.Lcom/google/android/datatransport/cct/internal/NetworkConnectionInfo$MobileSubtype;").Handle, JniHandleOwnership.TransferLocalRef);
				}
			}

			// Token: 0x1700009D RID: 157
			// (get) Token: 0x060001D0 RID: 464 RVA: 0x00005AD4 File Offset: 0x00003CD4
			[Register("EVDO_B")]
			public static NetworkConnectionInfo.MobileSubtype EvdoB
			{
				get
				{
					return Java.Lang.Object.GetObject<NetworkConnectionInfo.MobileSubtype>(NetworkConnectionInfo.MobileSubtype._members.StaticFields.GetObjectValue("EVDO_B.Lcom/google/android/datatransport/cct/internal/NetworkConnectionInfo$MobileSubtype;").Handle, JniHandleOwnership.TransferLocalRef);
				}
			}

			// Token: 0x1700009E RID: 158
			// (get) Token: 0x060001D1 RID: 465 RVA: 0x00005B04 File Offset: 0x00003D04
			[Register("GPRS")]
			public static NetworkConnectionInfo.MobileSubtype Gprs
			{
				get
				{
					return Java.Lang.Object.GetObject<NetworkConnectionInfo.MobileSubtype>(NetworkConnectionInfo.MobileSubtype._members.StaticFields.GetObjectValue("GPRS.Lcom/google/android/datatransport/cct/internal/NetworkConnectionInfo$MobileSubtype;").Handle, JniHandleOwnership.TransferLocalRef);
				}
			}

			// Token: 0x1700009F RID: 159
			// (get) Token: 0x060001D2 RID: 466 RVA: 0x00005B34 File Offset: 0x00003D34
			[Register("GSM")]
			public static NetworkConnectionInfo.MobileSubtype Gsm
			{
				get
				{
					return Java.Lang.Object.GetObject<NetworkConnectionInfo.MobileSubtype>(NetworkConnectionInfo.MobileSubtype._members.StaticFields.GetObjectValue("GSM.Lcom/google/android/datatransport/cct/internal/NetworkConnectionInfo$MobileSubtype;").Handle, JniHandleOwnership.TransferLocalRef);
				}
			}

			// Token: 0x170000A0 RID: 160
			// (get) Token: 0x060001D3 RID: 467 RVA: 0x00005B64 File Offset: 0x00003D64
			[Register("HSDPA")]
			public static NetworkConnectionInfo.MobileSubtype Hsdpa
			{
				get
				{
					return Java.Lang.Object.GetObject<NetworkConnectionInfo.MobileSubtype>(NetworkConnectionInfo.MobileSubtype._members.StaticFields.GetObjectValue("HSDPA.Lcom/google/android/datatransport/cct/internal/NetworkConnectionInfo$MobileSubtype;").Handle, JniHandleOwnership.TransferLocalRef);
				}
			}

			// Token: 0x170000A1 RID: 161
			// (get) Token: 0x060001D4 RID: 468 RVA: 0x00005B94 File Offset: 0x00003D94
			[Register("HSPA")]
			public static NetworkConnectionInfo.MobileSubtype Hspa
			{
				get
				{
					return Java.Lang.Object.GetObject<NetworkConnectionInfo.MobileSubtype>(NetworkConnectionInfo.MobileSubtype._members.StaticFields.GetObjectValue("HSPA.Lcom/google/android/datatransport/cct/internal/NetworkConnectionInfo$MobileSubtype;").Handle, JniHandleOwnership.TransferLocalRef);
				}
			}

			// Token: 0x170000A2 RID: 162
			// (get) Token: 0x060001D5 RID: 469 RVA: 0x00005BC4 File Offset: 0x00003DC4
			[Register("HSPAP")]
			public static NetworkConnectionInfo.MobileSubtype Hspap
			{
				get
				{
					return Java.Lang.Object.GetObject<NetworkConnectionInfo.MobileSubtype>(NetworkConnectionInfo.MobileSubtype._members.StaticFields.GetObjectValue("HSPAP.Lcom/google/android/datatransport/cct/internal/NetworkConnectionInfo$MobileSubtype;").Handle, JniHandleOwnership.TransferLocalRef);
				}
			}

			// Token: 0x170000A3 RID: 163
			// (get) Token: 0x060001D6 RID: 470 RVA: 0x00005BF4 File Offset: 0x00003DF4
			[Register("HSUPA")]
			public static NetworkConnectionInfo.MobileSubtype Hsupa
			{
				get
				{
					return Java.Lang.Object.GetObject<NetworkConnectionInfo.MobileSubtype>(NetworkConnectionInfo.MobileSubtype._members.StaticFields.GetObjectValue("HSUPA.Lcom/google/android/datatransport/cct/internal/NetworkConnectionInfo$MobileSubtype;").Handle, JniHandleOwnership.TransferLocalRef);
				}
			}

			// Token: 0x170000A4 RID: 164
			// (get) Token: 0x060001D7 RID: 471 RVA: 0x00005C24 File Offset: 0x00003E24
			[Register("IDEN")]
			public static NetworkConnectionInfo.MobileSubtype Iden
			{
				get
				{
					return Java.Lang.Object.GetObject<NetworkConnectionInfo.MobileSubtype>(NetworkConnectionInfo.MobileSubtype._members.StaticFields.GetObjectValue("IDEN.Lcom/google/android/datatransport/cct/internal/NetworkConnectionInfo$MobileSubtype;").Handle, JniHandleOwnership.TransferLocalRef);
				}
			}

			// Token: 0x170000A5 RID: 165
			// (get) Token: 0x060001D8 RID: 472 RVA: 0x00005C54 File Offset: 0x00003E54
			[Register("IWLAN")]
			public static NetworkConnectionInfo.MobileSubtype Iwlan
			{
				get
				{
					return Java.Lang.Object.GetObject<NetworkConnectionInfo.MobileSubtype>(NetworkConnectionInfo.MobileSubtype._members.StaticFields.GetObjectValue("IWLAN.Lcom/google/android/datatransport/cct/internal/NetworkConnectionInfo$MobileSubtype;").Handle, JniHandleOwnership.TransferLocalRef);
				}
			}

			// Token: 0x170000A6 RID: 166
			// (get) Token: 0x060001D9 RID: 473 RVA: 0x00005C84 File Offset: 0x00003E84
			[Register("LTE")]
			public static NetworkConnectionInfo.MobileSubtype Lte
			{
				get
				{
					return Java.Lang.Object.GetObject<NetworkConnectionInfo.MobileSubtype>(NetworkConnectionInfo.MobileSubtype._members.StaticFields.GetObjectValue("LTE.Lcom/google/android/datatransport/cct/internal/NetworkConnectionInfo$MobileSubtype;").Handle, JniHandleOwnership.TransferLocalRef);
				}
			}

			// Token: 0x170000A7 RID: 167
			// (get) Token: 0x060001DA RID: 474 RVA: 0x00005CB4 File Offset: 0x00003EB4
			[Register("LTE_CA")]
			public static NetworkConnectionInfo.MobileSubtype LteCa
			{
				get
				{
					return Java.Lang.Object.GetObject<NetworkConnectionInfo.MobileSubtype>(NetworkConnectionInfo.MobileSubtype._members.StaticFields.GetObjectValue("LTE_CA.Lcom/google/android/datatransport/cct/internal/NetworkConnectionInfo$MobileSubtype;").Handle, JniHandleOwnership.TransferLocalRef);
				}
			}

			// Token: 0x170000A8 RID: 168
			// (get) Token: 0x060001DB RID: 475 RVA: 0x00005CE4 File Offset: 0x00003EE4
			[Register("RTT")]
			public static NetworkConnectionInfo.MobileSubtype Rtt
			{
				get
				{
					return Java.Lang.Object.GetObject<NetworkConnectionInfo.MobileSubtype>(NetworkConnectionInfo.MobileSubtype._members.StaticFields.GetObjectValue("RTT.Lcom/google/android/datatransport/cct/internal/NetworkConnectionInfo$MobileSubtype;").Handle, JniHandleOwnership.TransferLocalRef);
				}
			}

			// Token: 0x170000A9 RID: 169
			// (get) Token: 0x060001DC RID: 476 RVA: 0x00005D14 File Offset: 0x00003F14
			[Register("TD_SCDMA")]
			public static NetworkConnectionInfo.MobileSubtype TdScdma
			{
				get
				{
					return Java.Lang.Object.GetObject<NetworkConnectionInfo.MobileSubtype>(NetworkConnectionInfo.MobileSubtype._members.StaticFields.GetObjectValue("TD_SCDMA.Lcom/google/android/datatransport/cct/internal/NetworkConnectionInfo$MobileSubtype;").Handle, JniHandleOwnership.TransferLocalRef);
				}
			}

			// Token: 0x170000AA RID: 170
			// (get) Token: 0x060001DD RID: 477 RVA: 0x00005D44 File Offset: 0x00003F44
			[Register("UMTS")]
			public static NetworkConnectionInfo.MobileSubtype Umts
			{
				get
				{
					return Java.Lang.Object.GetObject<NetworkConnectionInfo.MobileSubtype>(NetworkConnectionInfo.MobileSubtype._members.StaticFields.GetObjectValue("UMTS.Lcom/google/android/datatransport/cct/internal/NetworkConnectionInfo$MobileSubtype;").Handle, JniHandleOwnership.TransferLocalRef);
				}
			}

			// Token: 0x170000AB RID: 171
			// (get) Token: 0x060001DE RID: 478 RVA: 0x00005D74 File Offset: 0x00003F74
			[Register("UNKNOWN_MOBILE_SUBTYPE")]
			public static NetworkConnectionInfo.MobileSubtype UnknownMobileSubtype
			{
				get
				{
					return Java.Lang.Object.GetObject<NetworkConnectionInfo.MobileSubtype>(NetworkConnectionInfo.MobileSubtype._members.StaticFields.GetObjectValue("UNKNOWN_MOBILE_SUBTYPE.Lcom/google/android/datatransport/cct/internal/NetworkConnectionInfo$MobileSubtype;").Handle, JniHandleOwnership.TransferLocalRef);
				}
			}

			// Token: 0x170000AC RID: 172
			// (get) Token: 0x060001DF RID: 479 RVA: 0x00005DA4 File Offset: 0x00003FA4
			internal static IntPtr class_ref
			{
				get
				{
					return NetworkConnectionInfo.MobileSubtype._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x170000AD RID: 173
			// (get) Token: 0x060001E0 RID: 480 RVA: 0x00005DC8 File Offset: 0x00003FC8
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return NetworkConnectionInfo.MobileSubtype._members;
				}
			}

			// Token: 0x170000AE RID: 174
			// (get) Token: 0x060001E1 RID: 481 RVA: 0x00005DD0 File Offset: 0x00003FD0
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return NetworkConnectionInfo.MobileSubtype._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x170000AF RID: 175
			// (get) Token: 0x060001E2 RID: 482 RVA: 0x00005DF4 File Offset: 0x00003FF4
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return NetworkConnectionInfo.MobileSubtype._members.ManagedPeerType;
				}
			}

			// Token: 0x060001E3 RID: 483 RVA: 0x00003E74 File Offset: 0x00002074
			internal MobileSubtype(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
			{
			}

			// Token: 0x170000B0 RID: 176
			// (get) Token: 0x060001E4 RID: 484 RVA: 0x00005E00 File Offset: 0x00004000
			public int Value
			{
				[Register("getValue", "()I", "")]
				get
				{
					return NetworkConnectionInfo.MobileSubtype._members.InstanceMethods.InvokeAbstractInt32Method("getValue.()I", this, null);
				}
			}

			// Token: 0x060001E5 RID: 485 RVA: 0x00005E1C File Offset: 0x0000401C
			[Register("forNumber", "(I)Lcom/google/android/datatransport/cct/internal/NetworkConnectionInfo$MobileSubtype;", "")]
			public unsafe static NetworkConnectionInfo.MobileSubtype ForNumber(int value)
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(value);
				return Java.Lang.Object.GetObject<NetworkConnectionInfo.MobileSubtype>(NetworkConnectionInfo.MobileSubtype._members.StaticMethods.InvokeObjectMethod("forNumber.(I)Lcom/google/android/datatransport/cct/internal/NetworkConnectionInfo$MobileSubtype;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}

			// Token: 0x060001E6 RID: 486 RVA: 0x00005E64 File Offset: 0x00004064
			[Register("valueOf", "(Ljava/lang/String;)Lcom/google/android/datatransport/cct/internal/NetworkConnectionInfo$MobileSubtype;", "")]
			public unsafe static NetworkConnectionInfo.MobileSubtype ValueOf(string name)
			{
				IntPtr intPtr = JNIEnv.NewString(name);
				NetworkConnectionInfo.MobileSubtype @object;
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue(intPtr);
					@object = Java.Lang.Object.GetObject<NetworkConnectionInfo.MobileSubtype>(NetworkConnectionInfo.MobileSubtype._members.StaticMethods.InvokeObjectMethod("valueOf.(Ljava/lang/String;)Lcom/google/android/datatransport/cct/internal/NetworkConnectionInfo$MobileSubtype;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
				}
				finally
				{
					JNIEnv.DeleteLocalRef(intPtr);
				}
				return @object;
			}

			// Token: 0x060001E7 RID: 487 RVA: 0x00005ED0 File Offset: 0x000040D0
			[Register("values", "()[Lcom/google/android/datatransport/cct/internal/NetworkConnectionInfo$MobileSubtype;", "")]
			public static NetworkConnectionInfo.MobileSubtype[] Values()
			{
				return (NetworkConnectionInfo.MobileSubtype[])JNIEnv.GetArray(NetworkConnectionInfo.MobileSubtype._members.StaticMethods.InvokeObjectMethod("values.()[Lcom/google/android/datatransport/cct/internal/NetworkConnectionInfo$MobileSubtype;", null).Handle, JniHandleOwnership.TransferLocalRef, typeof(NetworkConnectionInfo.MobileSubtype));
			}

			// Token: 0x0400005E RID: 94
			private static readonly JniPeerMembers _members = new XAPeerMembers("com/google/android/datatransport/cct/internal/NetworkConnectionInfo$MobileSubtype", typeof(NetworkConnectionInfo.MobileSubtype));
		}

		// Token: 0x02000024 RID: 36
		[Register("com/google/android/datatransport/cct/internal/NetworkConnectionInfo$NetworkType", DoNotGenerateAcw = true)]
		public sealed class NetworkType : Java.Lang.Enum
		{
			// Token: 0x170000B1 RID: 177
			// (get) Token: 0x060001E9 RID: 489 RVA: 0x00005F2C File Offset: 0x0000412C
			[Register("BLUETOOTH")]
			public static NetworkConnectionInfo.NetworkType Bluetooth
			{
				get
				{
					return Java.Lang.Object.GetObject<NetworkConnectionInfo.NetworkType>(NetworkConnectionInfo.NetworkType._members.StaticFields.GetObjectValue("BLUETOOTH.Lcom/google/android/datatransport/cct/internal/NetworkConnectionInfo$NetworkType;").Handle, JniHandleOwnership.TransferLocalRef);
				}
			}

			// Token: 0x170000B2 RID: 178
			// (get) Token: 0x060001EA RID: 490 RVA: 0x00005F5C File Offset: 0x0000415C
			[Register("DUMMY")]
			public static NetworkConnectionInfo.NetworkType Dummy
			{
				get
				{
					return Java.Lang.Object.GetObject<NetworkConnectionInfo.NetworkType>(NetworkConnectionInfo.NetworkType._members.StaticFields.GetObjectValue("DUMMY.Lcom/google/android/datatransport/cct/internal/NetworkConnectionInfo$NetworkType;").Handle, JniHandleOwnership.TransferLocalRef);
				}
			}

			// Token: 0x170000B3 RID: 179
			// (get) Token: 0x060001EB RID: 491 RVA: 0x00005F8C File Offset: 0x0000418C
			[Register("ETHERNET")]
			public static NetworkConnectionInfo.NetworkType Ethernet
			{
				get
				{
					return Java.Lang.Object.GetObject<NetworkConnectionInfo.NetworkType>(NetworkConnectionInfo.NetworkType._members.StaticFields.GetObjectValue("ETHERNET.Lcom/google/android/datatransport/cct/internal/NetworkConnectionInfo$NetworkType;").Handle, JniHandleOwnership.TransferLocalRef);
				}
			}

			// Token: 0x170000B4 RID: 180
			// (get) Token: 0x060001EC RID: 492 RVA: 0x00005FBC File Offset: 0x000041BC
			[Register("MOBILE")]
			public static NetworkConnectionInfo.NetworkType Mobile
			{
				get
				{
					return Java.Lang.Object.GetObject<NetworkConnectionInfo.NetworkType>(NetworkConnectionInfo.NetworkType._members.StaticFields.GetObjectValue("MOBILE.Lcom/google/android/datatransport/cct/internal/NetworkConnectionInfo$NetworkType;").Handle, JniHandleOwnership.TransferLocalRef);
				}
			}

			// Token: 0x170000B5 RID: 181
			// (get) Token: 0x060001ED RID: 493 RVA: 0x00005FEC File Offset: 0x000041EC
			[Register("MOBILE_CBS")]
			public static NetworkConnectionInfo.NetworkType MobileCbs
			{
				get
				{
					return Java.Lang.Object.GetObject<NetworkConnectionInfo.NetworkType>(NetworkConnectionInfo.NetworkType._members.StaticFields.GetObjectValue("MOBILE_CBS.Lcom/google/android/datatransport/cct/internal/NetworkConnectionInfo$NetworkType;").Handle, JniHandleOwnership.TransferLocalRef);
				}
			}

			// Token: 0x170000B6 RID: 182
			// (get) Token: 0x060001EE RID: 494 RVA: 0x0000601C File Offset: 0x0000421C
			[Register("MOBILE_DUN")]
			public static NetworkConnectionInfo.NetworkType MobileDun
			{
				get
				{
					return Java.Lang.Object.GetObject<NetworkConnectionInfo.NetworkType>(NetworkConnectionInfo.NetworkType._members.StaticFields.GetObjectValue("MOBILE_DUN.Lcom/google/android/datatransport/cct/internal/NetworkConnectionInfo$NetworkType;").Handle, JniHandleOwnership.TransferLocalRef);
				}
			}

			// Token: 0x170000B7 RID: 183
			// (get) Token: 0x060001EF RID: 495 RVA: 0x0000604C File Offset: 0x0000424C
			[Register("MOBILE_EMERGENCY")]
			public static NetworkConnectionInfo.NetworkType MobileEmergency
			{
				get
				{
					return Java.Lang.Object.GetObject<NetworkConnectionInfo.NetworkType>(NetworkConnectionInfo.NetworkType._members.StaticFields.GetObjectValue("MOBILE_EMERGENCY.Lcom/google/android/datatransport/cct/internal/NetworkConnectionInfo$NetworkType;").Handle, JniHandleOwnership.TransferLocalRef);
				}
			}

			// Token: 0x170000B8 RID: 184
			// (get) Token: 0x060001F0 RID: 496 RVA: 0x0000607C File Offset: 0x0000427C
			[Register("MOBILE_FOTA")]
			public static NetworkConnectionInfo.NetworkType MobileFota
			{
				get
				{
					return Java.Lang.Object.GetObject<NetworkConnectionInfo.NetworkType>(NetworkConnectionInfo.NetworkType._members.StaticFields.GetObjectValue("MOBILE_FOTA.Lcom/google/android/datatransport/cct/internal/NetworkConnectionInfo$NetworkType;").Handle, JniHandleOwnership.TransferLocalRef);
				}
			}

			// Token: 0x170000B9 RID: 185
			// (get) Token: 0x060001F1 RID: 497 RVA: 0x000060AC File Offset: 0x000042AC
			[Register("MOBILE_HIPRI")]
			public static NetworkConnectionInfo.NetworkType MobileHipri
			{
				get
				{
					return Java.Lang.Object.GetObject<NetworkConnectionInfo.NetworkType>(NetworkConnectionInfo.NetworkType._members.StaticFields.GetObjectValue("MOBILE_HIPRI.Lcom/google/android/datatransport/cct/internal/NetworkConnectionInfo$NetworkType;").Handle, JniHandleOwnership.TransferLocalRef);
				}
			}

			// Token: 0x170000BA RID: 186
			// (get) Token: 0x060001F2 RID: 498 RVA: 0x000060DC File Offset: 0x000042DC
			[Register("MOBILE_IA")]
			public static NetworkConnectionInfo.NetworkType MobileIa
			{
				get
				{
					return Java.Lang.Object.GetObject<NetworkConnectionInfo.NetworkType>(NetworkConnectionInfo.NetworkType._members.StaticFields.GetObjectValue("MOBILE_IA.Lcom/google/android/datatransport/cct/internal/NetworkConnectionInfo$NetworkType;").Handle, JniHandleOwnership.TransferLocalRef);
				}
			}

			// Token: 0x170000BB RID: 187
			// (get) Token: 0x060001F3 RID: 499 RVA: 0x0000610C File Offset: 0x0000430C
			[Register("MOBILE_IMS")]
			public static NetworkConnectionInfo.NetworkType MobileIms
			{
				get
				{
					return Java.Lang.Object.GetObject<NetworkConnectionInfo.NetworkType>(NetworkConnectionInfo.NetworkType._members.StaticFields.GetObjectValue("MOBILE_IMS.Lcom/google/android/datatransport/cct/internal/NetworkConnectionInfo$NetworkType;").Handle, JniHandleOwnership.TransferLocalRef);
				}
			}

			// Token: 0x170000BC RID: 188
			// (get) Token: 0x060001F4 RID: 500 RVA: 0x0000613C File Offset: 0x0000433C
			[Register("MOBILE_MMS")]
			public static NetworkConnectionInfo.NetworkType MobileMms
			{
				get
				{
					return Java.Lang.Object.GetObject<NetworkConnectionInfo.NetworkType>(NetworkConnectionInfo.NetworkType._members.StaticFields.GetObjectValue("MOBILE_MMS.Lcom/google/android/datatransport/cct/internal/NetworkConnectionInfo$NetworkType;").Handle, JniHandleOwnership.TransferLocalRef);
				}
			}

			// Token: 0x170000BD RID: 189
			// (get) Token: 0x060001F5 RID: 501 RVA: 0x0000616C File Offset: 0x0000436C
			[Register("MOBILE_SUPL")]
			public static NetworkConnectionInfo.NetworkType MobileSupl
			{
				get
				{
					return Java.Lang.Object.GetObject<NetworkConnectionInfo.NetworkType>(NetworkConnectionInfo.NetworkType._members.StaticFields.GetObjectValue("MOBILE_SUPL.Lcom/google/android/datatransport/cct/internal/NetworkConnectionInfo$NetworkType;").Handle, JniHandleOwnership.TransferLocalRef);
				}
			}

			// Token: 0x170000BE RID: 190
			// (get) Token: 0x060001F6 RID: 502 RVA: 0x0000619C File Offset: 0x0000439C
			[Register("NONE")]
			public static NetworkConnectionInfo.NetworkType None
			{
				get
				{
					return Java.Lang.Object.GetObject<NetworkConnectionInfo.NetworkType>(NetworkConnectionInfo.NetworkType._members.StaticFields.GetObjectValue("NONE.Lcom/google/android/datatransport/cct/internal/NetworkConnectionInfo$NetworkType;").Handle, JniHandleOwnership.TransferLocalRef);
				}
			}

			// Token: 0x170000BF RID: 191
			// (get) Token: 0x060001F7 RID: 503 RVA: 0x000061CC File Offset: 0x000043CC
			[Register("PROXY")]
			public static NetworkConnectionInfo.NetworkType Proxy
			{
				get
				{
					return Java.Lang.Object.GetObject<NetworkConnectionInfo.NetworkType>(NetworkConnectionInfo.NetworkType._members.StaticFields.GetObjectValue("PROXY.Lcom/google/android/datatransport/cct/internal/NetworkConnectionInfo$NetworkType;").Handle, JniHandleOwnership.TransferLocalRef);
				}
			}

			// Token: 0x170000C0 RID: 192
			// (get) Token: 0x060001F8 RID: 504 RVA: 0x000061FC File Offset: 0x000043FC
			[Register("VPN")]
			public static NetworkConnectionInfo.NetworkType Vpn
			{
				get
				{
					return Java.Lang.Object.GetObject<NetworkConnectionInfo.NetworkType>(NetworkConnectionInfo.NetworkType._members.StaticFields.GetObjectValue("VPN.Lcom/google/android/datatransport/cct/internal/NetworkConnectionInfo$NetworkType;").Handle, JniHandleOwnership.TransferLocalRef);
				}
			}

			// Token: 0x170000C1 RID: 193
			// (get) Token: 0x060001F9 RID: 505 RVA: 0x0000622C File Offset: 0x0000442C
			[Register("WIFI")]
			public static NetworkConnectionInfo.NetworkType Wifi
			{
				get
				{
					return Java.Lang.Object.GetObject<NetworkConnectionInfo.NetworkType>(NetworkConnectionInfo.NetworkType._members.StaticFields.GetObjectValue("WIFI.Lcom/google/android/datatransport/cct/internal/NetworkConnectionInfo$NetworkType;").Handle, JniHandleOwnership.TransferLocalRef);
				}
			}

			// Token: 0x170000C2 RID: 194
			// (get) Token: 0x060001FA RID: 506 RVA: 0x0000625C File Offset: 0x0000445C
			[Register("WIFI_P2P")]
			public static NetworkConnectionInfo.NetworkType WifiP2p
			{
				get
				{
					return Java.Lang.Object.GetObject<NetworkConnectionInfo.NetworkType>(NetworkConnectionInfo.NetworkType._members.StaticFields.GetObjectValue("WIFI_P2P.Lcom/google/android/datatransport/cct/internal/NetworkConnectionInfo$NetworkType;").Handle, JniHandleOwnership.TransferLocalRef);
				}
			}

			// Token: 0x170000C3 RID: 195
			// (get) Token: 0x060001FB RID: 507 RVA: 0x0000628C File Offset: 0x0000448C
			[Register("WIMAX")]
			public static NetworkConnectionInfo.NetworkType Wimax
			{
				get
				{
					return Java.Lang.Object.GetObject<NetworkConnectionInfo.NetworkType>(NetworkConnectionInfo.NetworkType._members.StaticFields.GetObjectValue("WIMAX.Lcom/google/android/datatransport/cct/internal/NetworkConnectionInfo$NetworkType;").Handle, JniHandleOwnership.TransferLocalRef);
				}
			}

			// Token: 0x170000C4 RID: 196
			// (get) Token: 0x060001FC RID: 508 RVA: 0x000062BC File Offset: 0x000044BC
			internal static IntPtr class_ref
			{
				get
				{
					return NetworkConnectionInfo.NetworkType._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x170000C5 RID: 197
			// (get) Token: 0x060001FD RID: 509 RVA: 0x000062E0 File Offset: 0x000044E0
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return NetworkConnectionInfo.NetworkType._members;
				}
			}

			// Token: 0x170000C6 RID: 198
			// (get) Token: 0x060001FE RID: 510 RVA: 0x000062E8 File Offset: 0x000044E8
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return NetworkConnectionInfo.NetworkType._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x170000C7 RID: 199
			// (get) Token: 0x060001FF RID: 511 RVA: 0x0000630C File Offset: 0x0000450C
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return NetworkConnectionInfo.NetworkType._members.ManagedPeerType;
				}
			}

			// Token: 0x06000200 RID: 512 RVA: 0x00003E74 File Offset: 0x00002074
			internal NetworkType(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
			{
			}

			// Token: 0x170000C8 RID: 200
			// (get) Token: 0x06000201 RID: 513 RVA: 0x00006318 File Offset: 0x00004518
			public int Value
			{
				[Register("getValue", "()I", "")]
				get
				{
					return NetworkConnectionInfo.NetworkType._members.InstanceMethods.InvokeAbstractInt32Method("getValue.()I", this, null);
				}
			}

			// Token: 0x06000202 RID: 514 RVA: 0x00006334 File Offset: 0x00004534
			[Register("forNumber", "(I)Lcom/google/android/datatransport/cct/internal/NetworkConnectionInfo$NetworkType;", "")]
			public unsafe static NetworkConnectionInfo.NetworkType ForNumber(int value)
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(value);
				return Java.Lang.Object.GetObject<NetworkConnectionInfo.NetworkType>(NetworkConnectionInfo.NetworkType._members.StaticMethods.InvokeObjectMethod("forNumber.(I)Lcom/google/android/datatransport/cct/internal/NetworkConnectionInfo$NetworkType;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}

			// Token: 0x06000203 RID: 515 RVA: 0x0000637C File Offset: 0x0000457C
			[Register("valueOf", "(Ljava/lang/String;)Lcom/google/android/datatransport/cct/internal/NetworkConnectionInfo$NetworkType;", "")]
			public unsafe static NetworkConnectionInfo.NetworkType ValueOf(string name)
			{
				IntPtr intPtr = JNIEnv.NewString(name);
				NetworkConnectionInfo.NetworkType @object;
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue(intPtr);
					@object = Java.Lang.Object.GetObject<NetworkConnectionInfo.NetworkType>(NetworkConnectionInfo.NetworkType._members.StaticMethods.InvokeObjectMethod("valueOf.(Ljava/lang/String;)Lcom/google/android/datatransport/cct/internal/NetworkConnectionInfo$NetworkType;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
				}
				finally
				{
					JNIEnv.DeleteLocalRef(intPtr);
				}
				return @object;
			}

			// Token: 0x06000204 RID: 516 RVA: 0x000063E8 File Offset: 0x000045E8
			[Register("values", "()[Lcom/google/android/datatransport/cct/internal/NetworkConnectionInfo$NetworkType;", "")]
			public static NetworkConnectionInfo.NetworkType[] Values()
			{
				return (NetworkConnectionInfo.NetworkType[])JNIEnv.GetArray(NetworkConnectionInfo.NetworkType._members.StaticMethods.InvokeObjectMethod("values.()[Lcom/google/android/datatransport/cct/internal/NetworkConnectionInfo$NetworkType;", null).Handle, JniHandleOwnership.TransferLocalRef, typeof(NetworkConnectionInfo.NetworkType));
			}

			// Token: 0x0400005F RID: 95
			private static readonly JniPeerMembers _members = new XAPeerMembers("com/google/android/datatransport/cct/internal/NetworkConnectionInfo$NetworkType", typeof(NetworkConnectionInfo.NetworkType));
		}
	}
}
