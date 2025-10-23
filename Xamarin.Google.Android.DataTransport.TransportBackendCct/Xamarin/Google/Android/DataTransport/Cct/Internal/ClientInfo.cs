using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Xamarin.Google.Android.DataTransport.Cct.Internal
{
	// Token: 0x02000011 RID: 17
	[Register("com/google/android/datatransport/cct/internal/ClientInfo", DoNotGenerateAcw = true)]
	public abstract class ClientInfo : Java.Lang.Object
	{
		// Token: 0x1700003F RID: 63
		// (get) Token: 0x060000C3 RID: 195 RVA: 0x00003924 File Offset: 0x00001B24
		internal static IntPtr class_ref
		{
			get
			{
				return ClientInfo._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000040 RID: 64
		// (get) Token: 0x060000C4 RID: 196 RVA: 0x00003948 File Offset: 0x00001B48
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return ClientInfo._members;
			}
		}

		// Token: 0x17000041 RID: 65
		// (get) Token: 0x060000C5 RID: 197 RVA: 0x00003950 File Offset: 0x00001B50
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return ClientInfo._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000042 RID: 66
		// (get) Token: 0x060000C6 RID: 198 RVA: 0x00003974 File Offset: 0x00001B74
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return ClientInfo._members.ManagedPeerType;
			}
		}

		// Token: 0x060000C7 RID: 199 RVA: 0x000020B4 File Offset: 0x000002B4
		protected ClientInfo(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x060000C8 RID: 200 RVA: 0x00003980 File Offset: 0x00001B80
		[Register(".ctor", "()V", "")]
		public ClientInfo() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			base.SetHandle(ClientInfo._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
			ClientInfo._members.InstanceMethods.FinishCreateInstance("()V", this, null);
		}

		// Token: 0x060000C9 RID: 201 RVA: 0x000039EE File Offset: 0x00001BEE
		private static Delegate GetGetAndroidClientInfoHandler()
		{
			if (ClientInfo.cb_getAndroidClientInfo == null)
			{
				ClientInfo.cb_getAndroidClientInfo = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(ClientInfo.n_GetAndroidClientInfo));
			}
			return ClientInfo.cb_getAndroidClientInfo;
		}

		// Token: 0x060000CA RID: 202 RVA: 0x00003A12 File Offset: 0x00001C12
		private static IntPtr n_GetAndroidClientInfo(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<ClientInfo>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).AndroidClientInfo);
		}

		// Token: 0x17000043 RID: 67
		// (get) Token: 0x060000CB RID: 203
		public abstract AndroidClientInfo AndroidClientInfo { [Register("getAndroidClientInfo", "()Lcom/google/android/datatransport/cct/internal/AndroidClientInfo;", "GetGetAndroidClientInfoHandler")] get; }

		// Token: 0x060000CC RID: 204 RVA: 0x00003A28 File Offset: 0x00001C28
		[Register("builder", "()Lcom/google/android/datatransport/cct/internal/ClientInfo$Builder;", "")]
		public static ClientInfo.Builder InvokeBuilder()
		{
			return Java.Lang.Object.GetObject<ClientInfo.Builder>(ClientInfo._members.StaticMethods.InvokeObjectMethod("builder.()Lcom/google/android/datatransport/cct/internal/ClientInfo$Builder;", null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x060000CD RID: 205 RVA: 0x00003A59 File Offset: 0x00001C59
		private static Delegate GetGetClientTypeHandler()
		{
			if (ClientInfo.cb_getClientType == null)
			{
				ClientInfo.cb_getClientType = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(ClientInfo.n_GetClientType));
			}
			return ClientInfo.cb_getClientType;
		}

		// Token: 0x060000CE RID: 206 RVA: 0x00003A7D File Offset: 0x00001C7D
		private static IntPtr n_GetClientType(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<ClientInfo>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).GetClientType());
		}

		// Token: 0x060000CF RID: 207
		[Register("getClientType", "()Lcom/google/android/datatransport/cct/internal/ClientInfo$ClientType;", "GetGetClientTypeHandler")]
		public abstract ClientInfo.ClientType GetClientType();

		// Token: 0x04000025 RID: 37
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/google/android/datatransport/cct/internal/ClientInfo", typeof(ClientInfo));

		// Token: 0x04000026 RID: 38
		private static Delegate cb_getAndroidClientInfo;

		// Token: 0x04000027 RID: 39
		private static Delegate cb_getClientType;

		// Token: 0x02000012 RID: 18
		[Register("com/google/android/datatransport/cct/internal/ClientInfo$Builder", DoNotGenerateAcw = true)]
		public abstract class Builder : Java.Lang.Object
		{
			// Token: 0x17000044 RID: 68
			// (get) Token: 0x060000D1 RID: 209 RVA: 0x00003AAC File Offset: 0x00001CAC
			internal static IntPtr class_ref
			{
				get
				{
					return ClientInfo.Builder._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x17000045 RID: 69
			// (get) Token: 0x060000D2 RID: 210 RVA: 0x00003AD0 File Offset: 0x00001CD0
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return ClientInfo.Builder._members;
				}
			}

			// Token: 0x17000046 RID: 70
			// (get) Token: 0x060000D3 RID: 211 RVA: 0x00003AD8 File Offset: 0x00001CD8
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return ClientInfo.Builder._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x17000047 RID: 71
			// (get) Token: 0x060000D4 RID: 212 RVA: 0x00003AFC File Offset: 0x00001CFC
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return ClientInfo.Builder._members.ManagedPeerType;
				}
			}

			// Token: 0x060000D5 RID: 213 RVA: 0x000020B4 File Offset: 0x000002B4
			protected Builder(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
			{
			}

			// Token: 0x060000D6 RID: 214 RVA: 0x00003B08 File Offset: 0x00001D08
			[Register(".ctor", "()V", "")]
			public Builder() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (base.Handle != IntPtr.Zero)
				{
					return;
				}
				base.SetHandle(ClientInfo.Builder._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
				ClientInfo.Builder._members.InstanceMethods.FinishCreateInstance("()V", this, null);
			}

			// Token: 0x060000D7 RID: 215 RVA: 0x00003B76 File Offset: 0x00001D76
			private static Delegate GetBuildHandler()
			{
				if (ClientInfo.Builder.cb_build == null)
				{
					ClientInfo.Builder.cb_build = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(ClientInfo.Builder.n_Build));
				}
				return ClientInfo.Builder.cb_build;
			}

			// Token: 0x060000D8 RID: 216 RVA: 0x00003B9A File Offset: 0x00001D9A
			private static IntPtr n_Build(IntPtr jnienv, IntPtr native__this)
			{
				return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<ClientInfo.Builder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Build());
			}

			// Token: 0x060000D9 RID: 217
			[Register("build", "()Lcom/google/android/datatransport/cct/internal/ClientInfo;", "GetBuildHandler")]
			public abstract ClientInfo Build();

			// Token: 0x060000DA RID: 218 RVA: 0x00003BAE File Offset: 0x00001DAE
			private static Delegate GetSetAndroidClientInfo_Lcom_google_android_datatransport_cct_internal_AndroidClientInfo_Handler()
			{
				if (ClientInfo.Builder.cb_setAndroidClientInfo_Lcom_google_android_datatransport_cct_internal_AndroidClientInfo_ == null)
				{
					ClientInfo.Builder.cb_setAndroidClientInfo_Lcom_google_android_datatransport_cct_internal_AndroidClientInfo_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(ClientInfo.Builder.n_SetAndroidClientInfo_Lcom_google_android_datatransport_cct_internal_AndroidClientInfo_));
				}
				return ClientInfo.Builder.cb_setAndroidClientInfo_Lcom_google_android_datatransport_cct_internal_AndroidClientInfo_;
			}

			// Token: 0x060000DB RID: 219 RVA: 0x00003BD4 File Offset: 0x00001DD4
			private static IntPtr n_SetAndroidClientInfo_Lcom_google_android_datatransport_cct_internal_AndroidClientInfo_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				ClientInfo.Builder @object = Java.Lang.Object.GetObject<ClientInfo.Builder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				AndroidClientInfo object2 = Java.Lang.Object.GetObject<AndroidClientInfo>(native_p0, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle(@object.SetAndroidClientInfo(object2));
			}

			// Token: 0x060000DC RID: 220
			[Register("setAndroidClientInfo", "(Lcom/google/android/datatransport/cct/internal/AndroidClientInfo;)Lcom/google/android/datatransport/cct/internal/ClientInfo$Builder;", "GetSetAndroidClientInfo_Lcom_google_android_datatransport_cct_internal_AndroidClientInfo_Handler")]
			public abstract ClientInfo.Builder SetAndroidClientInfo(AndroidClientInfo p0);

			// Token: 0x060000DD RID: 221 RVA: 0x00003BFC File Offset: 0x00001DFC
			private static Delegate GetSetClientType_Lcom_google_android_datatransport_cct_internal_ClientInfo_ClientType_Handler()
			{
				if (ClientInfo.Builder.cb_setClientType_Lcom_google_android_datatransport_cct_internal_ClientInfo_ClientType_ == null)
				{
					ClientInfo.Builder.cb_setClientType_Lcom_google_android_datatransport_cct_internal_ClientInfo_ClientType_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(ClientInfo.Builder.n_SetClientType_Lcom_google_android_datatransport_cct_internal_ClientInfo_ClientType_));
				}
				return ClientInfo.Builder.cb_setClientType_Lcom_google_android_datatransport_cct_internal_ClientInfo_ClientType_;
			}

			// Token: 0x060000DE RID: 222 RVA: 0x00003C20 File Offset: 0x00001E20
			private static IntPtr n_SetClientType_Lcom_google_android_datatransport_cct_internal_ClientInfo_ClientType_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				ClientInfo.Builder @object = Java.Lang.Object.GetObject<ClientInfo.Builder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				ClientInfo.ClientType object2 = Java.Lang.Object.GetObject<ClientInfo.ClientType>(native_p0, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle(@object.SetClientType(object2));
			}

			// Token: 0x060000DF RID: 223
			[Register("setClientType", "(Lcom/google/android/datatransport/cct/internal/ClientInfo$ClientType;)Lcom/google/android/datatransport/cct/internal/ClientInfo$Builder;", "GetSetClientType_Lcom_google_android_datatransport_cct_internal_ClientInfo_ClientType_Handler")]
			public abstract ClientInfo.Builder SetClientType(ClientInfo.ClientType p0);

			// Token: 0x04000028 RID: 40
			private static readonly JniPeerMembers _members = new XAPeerMembers("com/google/android/datatransport/cct/internal/ClientInfo$Builder", typeof(ClientInfo.Builder));

			// Token: 0x04000029 RID: 41
			private static Delegate cb_build;

			// Token: 0x0400002A RID: 42
			private static Delegate cb_setAndroidClientInfo_Lcom_google_android_datatransport_cct_internal_AndroidClientInfo_;

			// Token: 0x0400002B RID: 43
			private static Delegate cb_setClientType_Lcom_google_android_datatransport_cct_internal_ClientInfo_ClientType_;
		}

		// Token: 0x02000013 RID: 19
		[Register("com/google/android/datatransport/cct/internal/ClientInfo$Builder", DoNotGenerateAcw = true)]
		internal class BuilderInvoker : ClientInfo.Builder
		{
			// Token: 0x060000E1 RID: 225 RVA: 0x00003C63 File Offset: 0x00001E63
			public BuilderInvoker(IntPtr handle, JniHandleOwnership transfer) : base(handle, transfer)
			{
			}

			// Token: 0x17000048 RID: 72
			// (get) Token: 0x060000E2 RID: 226 RVA: 0x00003C6D File Offset: 0x00001E6D
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return ClientInfo.BuilderInvoker._members;
				}
			}

			// Token: 0x17000049 RID: 73
			// (get) Token: 0x060000E3 RID: 227 RVA: 0x00003C74 File Offset: 0x00001E74
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return ClientInfo.BuilderInvoker._members.ManagedPeerType;
				}
			}

			// Token: 0x060000E4 RID: 228 RVA: 0x00003C80 File Offset: 0x00001E80
			[Register("build", "()Lcom/google/android/datatransport/cct/internal/ClientInfo;", "GetBuildHandler")]
			public override ClientInfo Build()
			{
				return Java.Lang.Object.GetObject<ClientInfo>(ClientInfo.BuilderInvoker._members.InstanceMethods.InvokeAbstractObjectMethod("build.()Lcom/google/android/datatransport/cct/internal/ClientInfo;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}

			// Token: 0x060000E5 RID: 229 RVA: 0x00003CB4 File Offset: 0x00001EB4
			[Register("setAndroidClientInfo", "(Lcom/google/android/datatransport/cct/internal/AndroidClientInfo;)Lcom/google/android/datatransport/cct/internal/ClientInfo$Builder;", "GetSetAndroidClientInfo_Lcom_google_android_datatransport_cct_internal_AndroidClientInfo_Handler")]
			public unsafe override ClientInfo.Builder SetAndroidClientInfo(AndroidClientInfo p0)
			{
				ClientInfo.Builder @object;
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((p0 == null) ? IntPtr.Zero : p0.Handle);
					@object = Java.Lang.Object.GetObject<ClientInfo.Builder>(ClientInfo.BuilderInvoker._members.InstanceMethods.InvokeAbstractObjectMethod("setAndroidClientInfo.(Lcom/google/android/datatransport/cct/internal/AndroidClientInfo;)Lcom/google/android/datatransport/cct/internal/ClientInfo$Builder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
				}
				finally
				{
					GC.KeepAlive(p0);
				}
				return @object;
			}

			// Token: 0x060000E6 RID: 230 RVA: 0x00003D28 File Offset: 0x00001F28
			[Register("setClientType", "(Lcom/google/android/datatransport/cct/internal/ClientInfo$ClientType;)Lcom/google/android/datatransport/cct/internal/ClientInfo$Builder;", "GetSetClientType_Lcom_google_android_datatransport_cct_internal_ClientInfo_ClientType_Handler")]
			public unsafe override ClientInfo.Builder SetClientType(ClientInfo.ClientType p0)
			{
				ClientInfo.Builder @object;
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((p0 == null) ? IntPtr.Zero : p0.Handle);
					@object = Java.Lang.Object.GetObject<ClientInfo.Builder>(ClientInfo.BuilderInvoker._members.InstanceMethods.InvokeAbstractObjectMethod("setClientType.(Lcom/google/android/datatransport/cct/internal/ClientInfo$ClientType;)Lcom/google/android/datatransport/cct/internal/ClientInfo$Builder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
				}
				finally
				{
					GC.KeepAlive(p0);
				}
				return @object;
			}

			// Token: 0x0400002C RID: 44
			private static readonly JniPeerMembers _members = new XAPeerMembers("com/google/android/datatransport/cct/internal/ClientInfo$Builder", typeof(ClientInfo.BuilderInvoker));
		}

		// Token: 0x02000014 RID: 20
		[Register("com/google/android/datatransport/cct/internal/ClientInfo$ClientType", DoNotGenerateAcw = true)]
		public sealed class ClientType : Java.Lang.Enum
		{
			// Token: 0x1700004A RID: 74
			// (get) Token: 0x060000E8 RID: 232 RVA: 0x00003DB8 File Offset: 0x00001FB8
			[Register("ANDROID_FIREBASE")]
			public static ClientInfo.ClientType AndroidFirebase
			{
				get
				{
					return Java.Lang.Object.GetObject<ClientInfo.ClientType>(ClientInfo.ClientType._members.StaticFields.GetObjectValue("ANDROID_FIREBASE.Lcom/google/android/datatransport/cct/internal/ClientInfo$ClientType;").Handle, JniHandleOwnership.TransferLocalRef);
				}
			}

			// Token: 0x1700004B RID: 75
			// (get) Token: 0x060000E9 RID: 233 RVA: 0x00003DE8 File Offset: 0x00001FE8
			[Register("UNKNOWN")]
			public static ClientInfo.ClientType Unknown
			{
				get
				{
					return Java.Lang.Object.GetObject<ClientInfo.ClientType>(ClientInfo.ClientType._members.StaticFields.GetObjectValue("UNKNOWN.Lcom/google/android/datatransport/cct/internal/ClientInfo$ClientType;").Handle, JniHandleOwnership.TransferLocalRef);
				}
			}

			// Token: 0x1700004C RID: 76
			// (get) Token: 0x060000EA RID: 234 RVA: 0x00003E18 File Offset: 0x00002018
			internal static IntPtr class_ref
			{
				get
				{
					return ClientInfo.ClientType._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x1700004D RID: 77
			// (get) Token: 0x060000EB RID: 235 RVA: 0x00003E3C File Offset: 0x0000203C
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return ClientInfo.ClientType._members;
				}
			}

			// Token: 0x1700004E RID: 78
			// (get) Token: 0x060000EC RID: 236 RVA: 0x00003E44 File Offset: 0x00002044
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return ClientInfo.ClientType._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x1700004F RID: 79
			// (get) Token: 0x060000ED RID: 237 RVA: 0x00003E68 File Offset: 0x00002068
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return ClientInfo.ClientType._members.ManagedPeerType;
				}
			}

			// Token: 0x060000EE RID: 238 RVA: 0x00003E74 File Offset: 0x00002074
			internal ClientType(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
			{
			}

			// Token: 0x060000EF RID: 239 RVA: 0x00003E80 File Offset: 0x00002080
			[Register("valueOf", "(Ljava/lang/String;)Lcom/google/android/datatransport/cct/internal/ClientInfo$ClientType;", "")]
			public unsafe static ClientInfo.ClientType ValueOf(string name)
			{
				IntPtr intPtr = JNIEnv.NewString(name);
				ClientInfo.ClientType @object;
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue(intPtr);
					@object = Java.Lang.Object.GetObject<ClientInfo.ClientType>(ClientInfo.ClientType._members.StaticMethods.InvokeObjectMethod("valueOf.(Ljava/lang/String;)Lcom/google/android/datatransport/cct/internal/ClientInfo$ClientType;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
				}
				finally
				{
					JNIEnv.DeleteLocalRef(intPtr);
				}
				return @object;
			}

			// Token: 0x060000F0 RID: 240 RVA: 0x00003EEC File Offset: 0x000020EC
			[Register("values", "()[Lcom/google/android/datatransport/cct/internal/ClientInfo$ClientType;", "")]
			public static ClientInfo.ClientType[] Values()
			{
				return (ClientInfo.ClientType[])JNIEnv.GetArray(ClientInfo.ClientType._members.StaticMethods.InvokeObjectMethod("values.()[Lcom/google/android/datatransport/cct/internal/ClientInfo$ClientType;", null).Handle, JniHandleOwnership.TransferLocalRef, typeof(ClientInfo.ClientType));
			}

			// Token: 0x0400002D RID: 45
			private static readonly JniPeerMembers _members = new XAPeerMembers("com/google/android/datatransport/cct/internal/ClientInfo$ClientType", typeof(ClientInfo.ClientType));
		}
	}
}
