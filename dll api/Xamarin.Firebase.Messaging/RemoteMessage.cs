using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using Android.Content;
using Android.Gms.Common.Internal.SafeParcel;
using Android.Net;
using Android.OS;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Firebase.Messaging
{
	// Token: 0x02000009 RID: 9
	[Register("com/google/firebase/messaging/RemoteMessage", DoNotGenerateAcw = true)]
	public sealed class RemoteMessage : AbstractSafeParcelable
	{
		// Token: 0x17000009 RID: 9
		// (get) Token: 0x06000042 RID: 66 RVA: 0x00002678 File Offset: 0x00000878
		[Register("CREATOR")]
		public static IParcelableCreator Creator
		{
			get
			{
				return Java.Lang.Object.GetObject<IParcelableCreator>(RemoteMessage._members.StaticFields.GetObjectValue("CREATOR.Landroid/os/Parcelable$Creator;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x06000043 RID: 67 RVA: 0x000026A8 File Offset: 0x000008A8
		internal static IntPtr class_ref
		{
			get
			{
				return RemoteMessage._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x06000044 RID: 68 RVA: 0x000026CC File Offset: 0x000008CC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return RemoteMessage._members;
			}
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x06000045 RID: 69 RVA: 0x000026D4 File Offset: 0x000008D4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return RemoteMessage._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x06000046 RID: 70 RVA: 0x000026F8 File Offset: 0x000008F8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return RemoteMessage._members.ManagedPeerType;
			}
		}

		// Token: 0x06000047 RID: 71 RVA: 0x00002704 File Offset: 0x00000904
		internal RemoteMessage(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000048 RID: 72 RVA: 0x00002710 File Offset: 0x00000910
		[Register(".ctor", "(Landroid/os/Bundle;)V", "")]
		public unsafe RemoteMessage(Bundle bundle) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((bundle == null) ? IntPtr.Zero : bundle.Handle);
				base.SetHandle(RemoteMessage._members.InstanceMethods.StartCreateInstance("(Landroid/os/Bundle;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				RemoteMessage._members.InstanceMethods.FinishCreateInstance("(Landroid/os/Bundle;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(bundle);
			}
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x06000049 RID: 73 RVA: 0x000027C0 File Offset: 0x000009C0
		public string CollapseKey
		{
			[Register("getCollapseKey", "()Ljava/lang/String;", "")]
			get
			{
				return JNIEnv.GetString(RemoteMessage._members.InstanceMethods.InvokeAbstractObjectMethod("getCollapseKey.()Ljava/lang/String;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x0600004A RID: 74 RVA: 0x000027F4 File Offset: 0x000009F4
		public IDictionary<string, string> Data
		{
			[Register("getData", "()Ljava/util/Map;", "")]
			get
			{
				return JavaDictionary<string, string>.FromJniHandle(RemoteMessage._members.InstanceMethods.InvokeAbstractObjectMethod("getData.()Ljava/util/Map;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x0600004B RID: 75 RVA: 0x00002828 File Offset: 0x00000A28
		public string From
		{
			[Register("getFrom", "()Ljava/lang/String;", "")]
			get
			{
				return JNIEnv.GetString(RemoteMessage._members.InstanceMethods.InvokeAbstractObjectMethod("getFrom.()Ljava/lang/String;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x0600004C RID: 76 RVA: 0x0000285C File Offset: 0x00000A5C
		public string MessageId
		{
			[Register("getMessageId", "()Ljava/lang/String;", "")]
			get
			{
				return JNIEnv.GetString(RemoteMessage._members.InstanceMethods.InvokeAbstractObjectMethod("getMessageId.()Ljava/lang/String;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x0600004D RID: 77 RVA: 0x00002890 File Offset: 0x00000A90
		public string MessageType
		{
			[Register("getMessageType", "()Ljava/lang/String;", "")]
			get
			{
				return JNIEnv.GetString(RemoteMessage._members.InstanceMethods.InvokeAbstractObjectMethod("getMessageType.()Ljava/lang/String;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x0600004E RID: 78 RVA: 0x000028C2 File Offset: 0x00000AC2
		public int OriginalPriority
		{
			[Register("getOriginalPriority", "()I", "")]
			get
			{
				return RemoteMessage._members.InstanceMethods.InvokeAbstractInt32Method("getOriginalPriority.()I", this, null);
			}
		}

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x0600004F RID: 79 RVA: 0x000028DB File Offset: 0x00000ADB
		public int Priority
		{
			[Register("getPriority", "()I", "")]
			get
			{
				return RemoteMessage._members.InstanceMethods.InvokeAbstractInt32Method("getPriority.()I", this, null);
			}
		}

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x06000050 RID: 80 RVA: 0x000028F4 File Offset: 0x00000AF4
		public string SenderId
		{
			[Register("getSenderId", "()Ljava/lang/String;", "")]
			get
			{
				return JNIEnv.GetString(RemoteMessage._members.InstanceMethods.InvokeAbstractObjectMethod("getSenderId.()Ljava/lang/String;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x06000051 RID: 81 RVA: 0x00002926 File Offset: 0x00000B26
		public long SentTime
		{
			[Register("getSentTime", "()J", "")]
			get
			{
				return RemoteMessage._members.InstanceMethods.InvokeAbstractInt64Method("getSentTime.()J", this, null);
			}
		}

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x06000052 RID: 82 RVA: 0x00002940 File Offset: 0x00000B40
		public string To
		{
			[Register("getTo", "()Ljava/lang/String;", "")]
			get
			{
				return JNIEnv.GetString(RemoteMessage._members.InstanceMethods.InvokeAbstractObjectMethod("getTo.()Ljava/lang/String;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x06000053 RID: 83 RVA: 0x00002972 File Offset: 0x00000B72
		public int Ttl
		{
			[Register("getTtl", "()I", "")]
			get
			{
				return RemoteMessage._members.InstanceMethods.InvokeAbstractInt32Method("getTtl.()I", this, null);
			}
		}

		// Token: 0x06000054 RID: 84 RVA: 0x0000298C File Offset: 0x00000B8C
		[Register("getNotification", "()Lcom/google/firebase/messaging/RemoteMessage$Notification;", "")]
		public RemoteMessage.Notification GetNotification()
		{
			return Java.Lang.Object.GetObject<RemoteMessage.Notification>(RemoteMessage._members.InstanceMethods.InvokeAbstractObjectMethod("getNotification.()Lcom/google/firebase/messaging/RemoteMessage$Notification;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06000055 RID: 85 RVA: 0x000029C0 File Offset: 0x00000BC0
		[Register("getRawData", "()[B", "")]
		public byte[] GetRawData()
		{
			return (byte[])JNIEnv.GetArray(RemoteMessage._members.InstanceMethods.InvokeAbstractObjectMethod("getRawData.()[B", this, null).Handle, JniHandleOwnership.TransferLocalRef, typeof(byte));
		}

		// Token: 0x06000056 RID: 86 RVA: 0x00002A04 File Offset: 0x00000C04
		[Register("toIntent", "()Landroid/content/Intent;", "")]
		public Intent ToIntent()
		{
			return Java.Lang.Object.GetObject<Intent>(RemoteMessage._members.InstanceMethods.InvokeAbstractObjectMethod("toIntent.()Landroid/content/Intent;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06000057 RID: 87 RVA: 0x00002A38 File Offset: 0x00000C38
		[Register("writeToParcel", "(Landroid/os/Parcel;I)V", "")]
		public unsafe override void WriteToParcel(Parcel @out, [GeneratedEnum] ParcelableWriteFlags flags)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((@out == null) ? IntPtr.Zero : @out.Handle);
				ptr[1] = new JniArgumentValue((int)flags);
				RemoteMessage._members.InstanceMethods.InvokeAbstractVoidMethod("writeToParcel.(Landroid/os/Parcel;I)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(@out);
			}
		}

		// Token: 0x0400000D RID: 13
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/google/firebase/messaging/RemoteMessage", typeof(RemoteMessage));

		// Token: 0x0200000A RID: 10
		[Register("com/google/firebase/messaging/RemoteMessage$Notification", DoNotGenerateAcw = true)]
		public class Notification : Java.Lang.Object
		{
			// Token: 0x17000019 RID: 25
			// (get) Token: 0x06000059 RID: 89 RVA: 0x00002ACC File Offset: 0x00000CCC
			internal static IntPtr class_ref
			{
				get
				{
					return RemoteMessage.Notification._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x1700001A RID: 26
			// (get) Token: 0x0600005A RID: 90 RVA: 0x00002AF0 File Offset: 0x00000CF0
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return RemoteMessage.Notification._members;
				}
			}

			// Token: 0x1700001B RID: 27
			// (get) Token: 0x0600005B RID: 91 RVA: 0x00002AF8 File Offset: 0x00000CF8
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return RemoteMessage.Notification._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x1700001C RID: 28
			// (get) Token: 0x0600005C RID: 92 RVA: 0x00002B1C File Offset: 0x00000D1C
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return RemoteMessage.Notification._members.ManagedPeerType;
				}
			}

			// Token: 0x0600005D RID: 93 RVA: 0x000020AC File Offset: 0x000002AC
			protected Notification(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
			{
			}

			// Token: 0x0600005E RID: 94 RVA: 0x00002B28 File Offset: 0x00000D28
			private static Delegate GetGetBodyHandler()
			{
				if (RemoteMessage.Notification.cb_getBody == null)
				{
					RemoteMessage.Notification.cb_getBody = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(RemoteMessage.Notification.n_GetBody));
				}
				return RemoteMessage.Notification.cb_getBody;
			}

			// Token: 0x0600005F RID: 95 RVA: 0x00002B4C File Offset: 0x00000D4C
			private static IntPtr n_GetBody(IntPtr jnienv, IntPtr native__this)
			{
				return JNIEnv.NewString(Java.Lang.Object.GetObject<RemoteMessage.Notification>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Body);
			}

			// Token: 0x1700001D RID: 29
			// (get) Token: 0x06000060 RID: 96 RVA: 0x00002B60 File Offset: 0x00000D60
			public virtual string Body
			{
				[Register("getBody", "()Ljava/lang/String;", "GetGetBodyHandler")]
				get
				{
					return JNIEnv.GetString(RemoteMessage.Notification._members.InstanceMethods.InvokeVirtualObjectMethod("getBody.()Ljava/lang/String;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
				}
			}

			// Token: 0x06000061 RID: 97 RVA: 0x00002B92 File Offset: 0x00000D92
			private static Delegate GetGetBodyLocalizationKeyHandler()
			{
				if (RemoteMessage.Notification.cb_getBodyLocalizationKey == null)
				{
					RemoteMessage.Notification.cb_getBodyLocalizationKey = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(RemoteMessage.Notification.n_GetBodyLocalizationKey));
				}
				return RemoteMessage.Notification.cb_getBodyLocalizationKey;
			}

			// Token: 0x06000062 RID: 98 RVA: 0x00002BB6 File Offset: 0x00000DB6
			private static IntPtr n_GetBodyLocalizationKey(IntPtr jnienv, IntPtr native__this)
			{
				return JNIEnv.NewString(Java.Lang.Object.GetObject<RemoteMessage.Notification>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).BodyLocalizationKey);
			}

			// Token: 0x1700001E RID: 30
			// (get) Token: 0x06000063 RID: 99 RVA: 0x00002BCC File Offset: 0x00000DCC
			public virtual string BodyLocalizationKey
			{
				[Register("getBodyLocalizationKey", "()Ljava/lang/String;", "GetGetBodyLocalizationKeyHandler")]
				get
				{
					return JNIEnv.GetString(RemoteMessage.Notification._members.InstanceMethods.InvokeVirtualObjectMethod("getBodyLocalizationKey.()Ljava/lang/String;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
				}
			}

			// Token: 0x06000064 RID: 100 RVA: 0x00002BFE File Offset: 0x00000DFE
			private static Delegate GetGetChannelIdHandler()
			{
				if (RemoteMessage.Notification.cb_getChannelId == null)
				{
					RemoteMessage.Notification.cb_getChannelId = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(RemoteMessage.Notification.n_GetChannelId));
				}
				return RemoteMessage.Notification.cb_getChannelId;
			}

			// Token: 0x06000065 RID: 101 RVA: 0x00002C22 File Offset: 0x00000E22
			private static IntPtr n_GetChannelId(IntPtr jnienv, IntPtr native__this)
			{
				return JNIEnv.NewString(Java.Lang.Object.GetObject<RemoteMessage.Notification>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ChannelId);
			}

			// Token: 0x1700001F RID: 31
			// (get) Token: 0x06000066 RID: 102 RVA: 0x00002C38 File Offset: 0x00000E38
			public virtual string ChannelId
			{
				[Register("getChannelId", "()Ljava/lang/String;", "GetGetChannelIdHandler")]
				get
				{
					return JNIEnv.GetString(RemoteMessage.Notification._members.InstanceMethods.InvokeVirtualObjectMethod("getChannelId.()Ljava/lang/String;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
				}
			}

			// Token: 0x06000067 RID: 103 RVA: 0x00002C6A File Offset: 0x00000E6A
			private static Delegate GetGetClickActionHandler()
			{
				if (RemoteMessage.Notification.cb_getClickAction == null)
				{
					RemoteMessage.Notification.cb_getClickAction = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(RemoteMessage.Notification.n_GetClickAction));
				}
				return RemoteMessage.Notification.cb_getClickAction;
			}

			// Token: 0x06000068 RID: 104 RVA: 0x00002C8E File Offset: 0x00000E8E
			private static IntPtr n_GetClickAction(IntPtr jnienv, IntPtr native__this)
			{
				return JNIEnv.NewString(Java.Lang.Object.GetObject<RemoteMessage.Notification>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ClickAction);
			}

			// Token: 0x17000020 RID: 32
			// (get) Token: 0x06000069 RID: 105 RVA: 0x00002CA4 File Offset: 0x00000EA4
			public virtual string ClickAction
			{
				[Register("getClickAction", "()Ljava/lang/String;", "GetGetClickActionHandler")]
				get
				{
					return JNIEnv.GetString(RemoteMessage.Notification._members.InstanceMethods.InvokeVirtualObjectMethod("getClickAction.()Ljava/lang/String;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
				}
			}

			// Token: 0x0600006A RID: 106 RVA: 0x00002CD6 File Offset: 0x00000ED6
			private static Delegate GetGetColorHandler()
			{
				if (RemoteMessage.Notification.cb_getColor == null)
				{
					RemoteMessage.Notification.cb_getColor = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(RemoteMessage.Notification.n_GetColor));
				}
				return RemoteMessage.Notification.cb_getColor;
			}

			// Token: 0x0600006B RID: 107 RVA: 0x00002CFA File Offset: 0x00000EFA
			private static IntPtr n_GetColor(IntPtr jnienv, IntPtr native__this)
			{
				return JNIEnv.NewString(Java.Lang.Object.GetObject<RemoteMessage.Notification>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Color);
			}

			// Token: 0x17000021 RID: 33
			// (get) Token: 0x0600006C RID: 108 RVA: 0x00002D10 File Offset: 0x00000F10
			public virtual string Color
			{
				[Register("getColor", "()Ljava/lang/String;", "GetGetColorHandler")]
				get
				{
					return JNIEnv.GetString(RemoteMessage.Notification._members.InstanceMethods.InvokeVirtualObjectMethod("getColor.()Ljava/lang/String;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
				}
			}

			// Token: 0x0600006D RID: 109 RVA: 0x00002D42 File Offset: 0x00000F42
			private static Delegate GetGetDefaultLightSettingsHandler()
			{
				if (RemoteMessage.Notification.cb_getDefaultLightSettings == null)
				{
					RemoteMessage.Notification.cb_getDefaultLightSettings = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(RemoteMessage.Notification.n_GetDefaultLightSettings));
				}
				return RemoteMessage.Notification.cb_getDefaultLightSettings;
			}

			// Token: 0x0600006E RID: 110 RVA: 0x00002D66 File Offset: 0x00000F66
			private static bool n_GetDefaultLightSettings(IntPtr jnienv, IntPtr native__this)
			{
				return Java.Lang.Object.GetObject<RemoteMessage.Notification>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).DefaultLightSettings;
			}

			// Token: 0x17000022 RID: 34
			// (get) Token: 0x0600006F RID: 111 RVA: 0x00002D75 File Offset: 0x00000F75
			public virtual bool DefaultLightSettings
			{
				[Register("getDefaultLightSettings", "()Z", "GetGetDefaultLightSettingsHandler")]
				get
				{
					return RemoteMessage.Notification._members.InstanceMethods.InvokeVirtualBooleanMethod("getDefaultLightSettings.()Z", this, null);
				}
			}

			// Token: 0x06000070 RID: 112 RVA: 0x00002D8E File Offset: 0x00000F8E
			private static Delegate GetGetDefaultSoundHandler()
			{
				if (RemoteMessage.Notification.cb_getDefaultSound == null)
				{
					RemoteMessage.Notification.cb_getDefaultSound = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(RemoteMessage.Notification.n_GetDefaultSound));
				}
				return RemoteMessage.Notification.cb_getDefaultSound;
			}

			// Token: 0x06000071 RID: 113 RVA: 0x00002DB2 File Offset: 0x00000FB2
			private static bool n_GetDefaultSound(IntPtr jnienv, IntPtr native__this)
			{
				return Java.Lang.Object.GetObject<RemoteMessage.Notification>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).DefaultSound;
			}

			// Token: 0x17000023 RID: 35
			// (get) Token: 0x06000072 RID: 114 RVA: 0x00002DC1 File Offset: 0x00000FC1
			public virtual bool DefaultSound
			{
				[Register("getDefaultSound", "()Z", "GetGetDefaultSoundHandler")]
				get
				{
					return RemoteMessage.Notification._members.InstanceMethods.InvokeVirtualBooleanMethod("getDefaultSound.()Z", this, null);
				}
			}

			// Token: 0x06000073 RID: 115 RVA: 0x00002DDA File Offset: 0x00000FDA
			private static Delegate GetGetDefaultVibrateSettingsHandler()
			{
				if (RemoteMessage.Notification.cb_getDefaultVibrateSettings == null)
				{
					RemoteMessage.Notification.cb_getDefaultVibrateSettings = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(RemoteMessage.Notification.n_GetDefaultVibrateSettings));
				}
				return RemoteMessage.Notification.cb_getDefaultVibrateSettings;
			}

			// Token: 0x06000074 RID: 116 RVA: 0x00002DFE File Offset: 0x00000FFE
			private static bool n_GetDefaultVibrateSettings(IntPtr jnienv, IntPtr native__this)
			{
				return Java.Lang.Object.GetObject<RemoteMessage.Notification>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).DefaultVibrateSettings;
			}

			// Token: 0x17000024 RID: 36
			// (get) Token: 0x06000075 RID: 117 RVA: 0x00002E0D File Offset: 0x0000100D
			public virtual bool DefaultVibrateSettings
			{
				[Register("getDefaultVibrateSettings", "()Z", "GetGetDefaultVibrateSettingsHandler")]
				get
				{
					return RemoteMessage.Notification._members.InstanceMethods.InvokeVirtualBooleanMethod("getDefaultVibrateSettings.()Z", this, null);
				}
			}

			// Token: 0x06000076 RID: 118 RVA: 0x00002E26 File Offset: 0x00001026
			private static Delegate GetGetEventTimeHandler()
			{
				if (RemoteMessage.Notification.cb_getEventTime == null)
				{
					RemoteMessage.Notification.cb_getEventTime = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(RemoteMessage.Notification.n_GetEventTime));
				}
				return RemoteMessage.Notification.cb_getEventTime;
			}

			// Token: 0x06000077 RID: 119 RVA: 0x00002E4A File Offset: 0x0000104A
			private static IntPtr n_GetEventTime(IntPtr jnienv, IntPtr native__this)
			{
				return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<RemoteMessage.Notification>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).EventTime);
			}

			// Token: 0x17000025 RID: 37
			// (get) Token: 0x06000078 RID: 120 RVA: 0x00002E60 File Offset: 0x00001060
			public virtual Long EventTime
			{
				[Register("getEventTime", "()Ljava/lang/Long;", "GetGetEventTimeHandler")]
				get
				{
					return Java.Lang.Object.GetObject<Long>(RemoteMessage.Notification._members.InstanceMethods.InvokeVirtualObjectMethod("getEventTime.()Ljava/lang/Long;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
				}
			}

			// Token: 0x06000079 RID: 121 RVA: 0x00002E92 File Offset: 0x00001092
			private static Delegate GetGetIconHandler()
			{
				if (RemoteMessage.Notification.cb_getIcon == null)
				{
					RemoteMessage.Notification.cb_getIcon = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(RemoteMessage.Notification.n_GetIcon));
				}
				return RemoteMessage.Notification.cb_getIcon;
			}

			// Token: 0x0600007A RID: 122 RVA: 0x00002EB6 File Offset: 0x000010B6
			private static IntPtr n_GetIcon(IntPtr jnienv, IntPtr native__this)
			{
				return JNIEnv.NewString(Java.Lang.Object.GetObject<RemoteMessage.Notification>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Icon);
			}

			// Token: 0x17000026 RID: 38
			// (get) Token: 0x0600007B RID: 123 RVA: 0x00002ECC File Offset: 0x000010CC
			public virtual string Icon
			{
				[Register("getIcon", "()Ljava/lang/String;", "GetGetIconHandler")]
				get
				{
					return JNIEnv.GetString(RemoteMessage.Notification._members.InstanceMethods.InvokeVirtualObjectMethod("getIcon.()Ljava/lang/String;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
				}
			}

			// Token: 0x0600007C RID: 124 RVA: 0x00002EFE File Offset: 0x000010FE
			private static Delegate GetGetImageUrlHandler()
			{
				if (RemoteMessage.Notification.cb_getImageUrl == null)
				{
					RemoteMessage.Notification.cb_getImageUrl = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(RemoteMessage.Notification.n_GetImageUrl));
				}
				return RemoteMessage.Notification.cb_getImageUrl;
			}

			// Token: 0x0600007D RID: 125 RVA: 0x00002F22 File Offset: 0x00001122
			private static IntPtr n_GetImageUrl(IntPtr jnienv, IntPtr native__this)
			{
				return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<RemoteMessage.Notification>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ImageUrl);
			}

			// Token: 0x17000027 RID: 39
			// (get) Token: 0x0600007E RID: 126 RVA: 0x00002F38 File Offset: 0x00001138
			public virtual Android.Net.Uri ImageUrl
			{
				[Register("getImageUrl", "()Landroid/net/Uri;", "GetGetImageUrlHandler")]
				get
				{
					return Java.Lang.Object.GetObject<Android.Net.Uri>(RemoteMessage.Notification._members.InstanceMethods.InvokeVirtualObjectMethod("getImageUrl.()Landroid/net/Uri;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
				}
			}

			// Token: 0x0600007F RID: 127 RVA: 0x00002F6A File Offset: 0x0000116A
			private static Delegate GetGetLinkHandler()
			{
				if (RemoteMessage.Notification.cb_getLink == null)
				{
					RemoteMessage.Notification.cb_getLink = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(RemoteMessage.Notification.n_GetLink));
				}
				return RemoteMessage.Notification.cb_getLink;
			}

			// Token: 0x06000080 RID: 128 RVA: 0x00002F8E File Offset: 0x0000118E
			private static IntPtr n_GetLink(IntPtr jnienv, IntPtr native__this)
			{
				return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<RemoteMessage.Notification>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Link);
			}

			// Token: 0x17000028 RID: 40
			// (get) Token: 0x06000081 RID: 129 RVA: 0x00002FA4 File Offset: 0x000011A4
			public virtual Android.Net.Uri Link
			{
				[Register("getLink", "()Landroid/net/Uri;", "GetGetLinkHandler")]
				get
				{
					return Java.Lang.Object.GetObject<Android.Net.Uri>(RemoteMessage.Notification._members.InstanceMethods.InvokeVirtualObjectMethod("getLink.()Landroid/net/Uri;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
				}
			}

			// Token: 0x06000082 RID: 130 RVA: 0x00002FD6 File Offset: 0x000011D6
			private static Delegate GetGetLocalOnlyHandler()
			{
				if (RemoteMessage.Notification.cb_getLocalOnly == null)
				{
					RemoteMessage.Notification.cb_getLocalOnly = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(RemoteMessage.Notification.n_GetLocalOnly));
				}
				return RemoteMessage.Notification.cb_getLocalOnly;
			}

			// Token: 0x06000083 RID: 131 RVA: 0x00002FFA File Offset: 0x000011FA
			private static bool n_GetLocalOnly(IntPtr jnienv, IntPtr native__this)
			{
				return Java.Lang.Object.GetObject<RemoteMessage.Notification>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).LocalOnly;
			}

			// Token: 0x17000029 RID: 41
			// (get) Token: 0x06000084 RID: 132 RVA: 0x00003009 File Offset: 0x00001209
			public virtual bool LocalOnly
			{
				[Register("getLocalOnly", "()Z", "GetGetLocalOnlyHandler")]
				get
				{
					return RemoteMessage.Notification._members.InstanceMethods.InvokeVirtualBooleanMethod("getLocalOnly.()Z", this, null);
				}
			}

			// Token: 0x06000085 RID: 133 RVA: 0x00003022 File Offset: 0x00001222
			private static Delegate GetGetNotificationCountHandler()
			{
				if (RemoteMessage.Notification.cb_getNotificationCount == null)
				{
					RemoteMessage.Notification.cb_getNotificationCount = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(RemoteMessage.Notification.n_GetNotificationCount));
				}
				return RemoteMessage.Notification.cb_getNotificationCount;
			}

			// Token: 0x06000086 RID: 134 RVA: 0x00003046 File Offset: 0x00001246
			private static IntPtr n_GetNotificationCount(IntPtr jnienv, IntPtr native__this)
			{
				return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<RemoteMessage.Notification>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).NotificationCount);
			}

			// Token: 0x1700002A RID: 42
			// (get) Token: 0x06000087 RID: 135 RVA: 0x0000305C File Offset: 0x0000125C
			public virtual Integer NotificationCount
			{
				[Register("getNotificationCount", "()Ljava/lang/Integer;", "GetGetNotificationCountHandler")]
				get
				{
					return Java.Lang.Object.GetObject<Integer>(RemoteMessage.Notification._members.InstanceMethods.InvokeVirtualObjectMethod("getNotificationCount.()Ljava/lang/Integer;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
				}
			}

			// Token: 0x06000088 RID: 136 RVA: 0x0000308E File Offset: 0x0000128E
			private static Delegate GetGetNotificationPriorityHandler()
			{
				if (RemoteMessage.Notification.cb_getNotificationPriority == null)
				{
					RemoteMessage.Notification.cb_getNotificationPriority = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(RemoteMessage.Notification.n_GetNotificationPriority));
				}
				return RemoteMessage.Notification.cb_getNotificationPriority;
			}

			// Token: 0x06000089 RID: 137 RVA: 0x000030B2 File Offset: 0x000012B2
			private static IntPtr n_GetNotificationPriority(IntPtr jnienv, IntPtr native__this)
			{
				return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<RemoteMessage.Notification>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).NotificationPriority);
			}

			// Token: 0x1700002B RID: 43
			// (get) Token: 0x0600008A RID: 138 RVA: 0x000030C8 File Offset: 0x000012C8
			public virtual Integer NotificationPriority
			{
				[Register("getNotificationPriority", "()Ljava/lang/Integer;", "GetGetNotificationPriorityHandler")]
				get
				{
					return Java.Lang.Object.GetObject<Integer>(RemoteMessage.Notification._members.InstanceMethods.InvokeVirtualObjectMethod("getNotificationPriority.()Ljava/lang/Integer;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
				}
			}

			// Token: 0x0600008B RID: 139 RVA: 0x000030FA File Offset: 0x000012FA
			private static Delegate GetGetSoundHandler()
			{
				if (RemoteMessage.Notification.cb_getSound == null)
				{
					RemoteMessage.Notification.cb_getSound = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(RemoteMessage.Notification.n_GetSound));
				}
				return RemoteMessage.Notification.cb_getSound;
			}

			// Token: 0x0600008C RID: 140 RVA: 0x0000311E File Offset: 0x0000131E
			private static IntPtr n_GetSound(IntPtr jnienv, IntPtr native__this)
			{
				return JNIEnv.NewString(Java.Lang.Object.GetObject<RemoteMessage.Notification>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Sound);
			}

			// Token: 0x1700002C RID: 44
			// (get) Token: 0x0600008D RID: 141 RVA: 0x00003134 File Offset: 0x00001334
			public virtual string Sound
			{
				[Register("getSound", "()Ljava/lang/String;", "GetGetSoundHandler")]
				get
				{
					return JNIEnv.GetString(RemoteMessage.Notification._members.InstanceMethods.InvokeVirtualObjectMethod("getSound.()Ljava/lang/String;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
				}
			}

			// Token: 0x0600008E RID: 142 RVA: 0x00003166 File Offset: 0x00001366
			private static Delegate GetGetStickyHandler()
			{
				if (RemoteMessage.Notification.cb_getSticky == null)
				{
					RemoteMessage.Notification.cb_getSticky = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(RemoteMessage.Notification.n_GetSticky));
				}
				return RemoteMessage.Notification.cb_getSticky;
			}

			// Token: 0x0600008F RID: 143 RVA: 0x0000318A File Offset: 0x0000138A
			private static bool n_GetSticky(IntPtr jnienv, IntPtr native__this)
			{
				return Java.Lang.Object.GetObject<RemoteMessage.Notification>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Sticky;
			}

			// Token: 0x1700002D RID: 45
			// (get) Token: 0x06000090 RID: 144 RVA: 0x00003199 File Offset: 0x00001399
			public virtual bool Sticky
			{
				[Register("getSticky", "()Z", "GetGetStickyHandler")]
				get
				{
					return RemoteMessage.Notification._members.InstanceMethods.InvokeVirtualBooleanMethod("getSticky.()Z", this, null);
				}
			}

			// Token: 0x06000091 RID: 145 RVA: 0x000031B2 File Offset: 0x000013B2
			private static Delegate GetGetTagHandler()
			{
				if (RemoteMessage.Notification.cb_getTag == null)
				{
					RemoteMessage.Notification.cb_getTag = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(RemoteMessage.Notification.n_GetTag));
				}
				return RemoteMessage.Notification.cb_getTag;
			}

			// Token: 0x06000092 RID: 146 RVA: 0x000031D6 File Offset: 0x000013D6
			private static IntPtr n_GetTag(IntPtr jnienv, IntPtr native__this)
			{
				return JNIEnv.NewString(Java.Lang.Object.GetObject<RemoteMessage.Notification>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Tag);
			}

			// Token: 0x1700002E RID: 46
			// (get) Token: 0x06000093 RID: 147 RVA: 0x000031EC File Offset: 0x000013EC
			public virtual string Tag
			{
				[Register("getTag", "()Ljava/lang/String;", "GetGetTagHandler")]
				get
				{
					return JNIEnv.GetString(RemoteMessage.Notification._members.InstanceMethods.InvokeVirtualObjectMethod("getTag.()Ljava/lang/String;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
				}
			}

			// Token: 0x06000094 RID: 148 RVA: 0x0000321E File Offset: 0x0000141E
			private static Delegate GetGetTickerHandler()
			{
				if (RemoteMessage.Notification.cb_getTicker == null)
				{
					RemoteMessage.Notification.cb_getTicker = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(RemoteMessage.Notification.n_GetTicker));
				}
				return RemoteMessage.Notification.cb_getTicker;
			}

			// Token: 0x06000095 RID: 149 RVA: 0x00003242 File Offset: 0x00001442
			private static IntPtr n_GetTicker(IntPtr jnienv, IntPtr native__this)
			{
				return JNIEnv.NewString(Java.Lang.Object.GetObject<RemoteMessage.Notification>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Ticker);
			}

			// Token: 0x1700002F RID: 47
			// (get) Token: 0x06000096 RID: 150 RVA: 0x00003258 File Offset: 0x00001458
			public virtual string Ticker
			{
				[Register("getTicker", "()Ljava/lang/String;", "GetGetTickerHandler")]
				get
				{
					return JNIEnv.GetString(RemoteMessage.Notification._members.InstanceMethods.InvokeVirtualObjectMethod("getTicker.()Ljava/lang/String;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
				}
			}

			// Token: 0x06000097 RID: 151 RVA: 0x0000328A File Offset: 0x0000148A
			private static Delegate GetGetTitleHandler()
			{
				if (RemoteMessage.Notification.cb_getTitle == null)
				{
					RemoteMessage.Notification.cb_getTitle = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(RemoteMessage.Notification.n_GetTitle));
				}
				return RemoteMessage.Notification.cb_getTitle;
			}

			// Token: 0x06000098 RID: 152 RVA: 0x000032AE File Offset: 0x000014AE
			private static IntPtr n_GetTitle(IntPtr jnienv, IntPtr native__this)
			{
				return JNIEnv.NewString(Java.Lang.Object.GetObject<RemoteMessage.Notification>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Title);
			}

			// Token: 0x17000030 RID: 48
			// (get) Token: 0x06000099 RID: 153 RVA: 0x000032C4 File Offset: 0x000014C4
			public virtual string Title
			{
				[Register("getTitle", "()Ljava/lang/String;", "GetGetTitleHandler")]
				get
				{
					return JNIEnv.GetString(RemoteMessage.Notification._members.InstanceMethods.InvokeVirtualObjectMethod("getTitle.()Ljava/lang/String;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
				}
			}

			// Token: 0x0600009A RID: 154 RVA: 0x000032F6 File Offset: 0x000014F6
			private static Delegate GetGetTitleLocalizationKeyHandler()
			{
				if (RemoteMessage.Notification.cb_getTitleLocalizationKey == null)
				{
					RemoteMessage.Notification.cb_getTitleLocalizationKey = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(RemoteMessage.Notification.n_GetTitleLocalizationKey));
				}
				return RemoteMessage.Notification.cb_getTitleLocalizationKey;
			}

			// Token: 0x0600009B RID: 155 RVA: 0x0000331A File Offset: 0x0000151A
			private static IntPtr n_GetTitleLocalizationKey(IntPtr jnienv, IntPtr native__this)
			{
				return JNIEnv.NewString(Java.Lang.Object.GetObject<RemoteMessage.Notification>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).TitleLocalizationKey);
			}

			// Token: 0x17000031 RID: 49
			// (get) Token: 0x0600009C RID: 156 RVA: 0x00003330 File Offset: 0x00001530
			public virtual string TitleLocalizationKey
			{
				[Register("getTitleLocalizationKey", "()Ljava/lang/String;", "GetGetTitleLocalizationKeyHandler")]
				get
				{
					return JNIEnv.GetString(RemoteMessage.Notification._members.InstanceMethods.InvokeVirtualObjectMethod("getTitleLocalizationKey.()Ljava/lang/String;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
				}
			}

			// Token: 0x0600009D RID: 157 RVA: 0x00003362 File Offset: 0x00001562
			private static Delegate GetGetVisibilityHandler()
			{
				if (RemoteMessage.Notification.cb_getVisibility == null)
				{
					RemoteMessage.Notification.cb_getVisibility = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(RemoteMessage.Notification.n_GetVisibility));
				}
				return RemoteMessage.Notification.cb_getVisibility;
			}

			// Token: 0x0600009E RID: 158 RVA: 0x00003386 File Offset: 0x00001586
			private static IntPtr n_GetVisibility(IntPtr jnienv, IntPtr native__this)
			{
				return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<RemoteMessage.Notification>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Visibility);
			}

			// Token: 0x17000032 RID: 50
			// (get) Token: 0x0600009F RID: 159 RVA: 0x0000339C File Offset: 0x0000159C
			public virtual Integer Visibility
			{
				[Register("getVisibility", "()Ljava/lang/Integer;", "GetGetVisibilityHandler")]
				get
				{
					return Java.Lang.Object.GetObject<Integer>(RemoteMessage.Notification._members.InstanceMethods.InvokeVirtualObjectMethod("getVisibility.()Ljava/lang/Integer;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
				}
			}

			// Token: 0x060000A0 RID: 160 RVA: 0x000033CE File Offset: 0x000015CE
			private static Delegate GetGetBodyLocalizationArgsHandler()
			{
				if (RemoteMessage.Notification.cb_getBodyLocalizationArgs == null)
				{
					RemoteMessage.Notification.cb_getBodyLocalizationArgs = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(RemoteMessage.Notification.n_GetBodyLocalizationArgs));
				}
				return RemoteMessage.Notification.cb_getBodyLocalizationArgs;
			}

			// Token: 0x060000A1 RID: 161 RVA: 0x000033F2 File Offset: 0x000015F2
			private static IntPtr n_GetBodyLocalizationArgs(IntPtr jnienv, IntPtr native__this)
			{
				return JNIEnv.NewArray(Java.Lang.Object.GetObject<RemoteMessage.Notification>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).GetBodyLocalizationArgs());
			}

			// Token: 0x060000A2 RID: 162 RVA: 0x00003408 File Offset: 0x00001608
			[Register("getBodyLocalizationArgs", "()[Ljava/lang/String;", "GetGetBodyLocalizationArgsHandler")]
			public virtual string[] GetBodyLocalizationArgs()
			{
				return (string[])JNIEnv.GetArray(RemoteMessage.Notification._members.InstanceMethods.InvokeVirtualObjectMethod("getBodyLocalizationArgs.()[Ljava/lang/String;", this, null).Handle, JniHandleOwnership.TransferLocalRef, typeof(string));
			}

			// Token: 0x060000A3 RID: 163 RVA: 0x00003449 File Offset: 0x00001649
			private static Delegate GetGetLightSettingsHandler()
			{
				if (RemoteMessage.Notification.cb_getLightSettings == null)
				{
					RemoteMessage.Notification.cb_getLightSettings = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(RemoteMessage.Notification.n_GetLightSettings));
				}
				return RemoteMessage.Notification.cb_getLightSettings;
			}

			// Token: 0x060000A4 RID: 164 RVA: 0x0000346D File Offset: 0x0000166D
			private static IntPtr n_GetLightSettings(IntPtr jnienv, IntPtr native__this)
			{
				return JNIEnv.NewArray(Java.Lang.Object.GetObject<RemoteMessage.Notification>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).GetLightSettings());
			}

			// Token: 0x060000A5 RID: 165 RVA: 0x00003484 File Offset: 0x00001684
			[Register("getLightSettings", "()[I", "GetGetLightSettingsHandler")]
			public virtual int[] GetLightSettings()
			{
				return (int[])JNIEnv.GetArray(RemoteMessage.Notification._members.InstanceMethods.InvokeVirtualObjectMethod("getLightSettings.()[I", this, null).Handle, JniHandleOwnership.TransferLocalRef, typeof(int));
			}

			// Token: 0x060000A6 RID: 166 RVA: 0x000034C5 File Offset: 0x000016C5
			private static Delegate GetGetTitleLocalizationArgsHandler()
			{
				if (RemoteMessage.Notification.cb_getTitleLocalizationArgs == null)
				{
					RemoteMessage.Notification.cb_getTitleLocalizationArgs = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(RemoteMessage.Notification.n_GetTitleLocalizationArgs));
				}
				return RemoteMessage.Notification.cb_getTitleLocalizationArgs;
			}

			// Token: 0x060000A7 RID: 167 RVA: 0x000034E9 File Offset: 0x000016E9
			private static IntPtr n_GetTitleLocalizationArgs(IntPtr jnienv, IntPtr native__this)
			{
				return JNIEnv.NewArray(Java.Lang.Object.GetObject<RemoteMessage.Notification>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).GetTitleLocalizationArgs());
			}

			// Token: 0x060000A8 RID: 168 RVA: 0x00003500 File Offset: 0x00001700
			[Register("getTitleLocalizationArgs", "()[Ljava/lang/String;", "GetGetTitleLocalizationArgsHandler")]
			public virtual string[] GetTitleLocalizationArgs()
			{
				return (string[])JNIEnv.GetArray(RemoteMessage.Notification._members.InstanceMethods.InvokeVirtualObjectMethod("getTitleLocalizationArgs.()[Ljava/lang/String;", this, null).Handle, JniHandleOwnership.TransferLocalRef, typeof(string));
			}

			// Token: 0x060000A9 RID: 169 RVA: 0x00003541 File Offset: 0x00001741
			private static Delegate GetGetVibrateTimingsHandler()
			{
				if (RemoteMessage.Notification.cb_getVibrateTimings == null)
				{
					RemoteMessage.Notification.cb_getVibrateTimings = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(RemoteMessage.Notification.n_GetVibrateTimings));
				}
				return RemoteMessage.Notification.cb_getVibrateTimings;
			}

			// Token: 0x060000AA RID: 170 RVA: 0x00003565 File Offset: 0x00001765
			private static IntPtr n_GetVibrateTimings(IntPtr jnienv, IntPtr native__this)
			{
				return JNIEnv.NewArray(Java.Lang.Object.GetObject<RemoteMessage.Notification>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).GetVibrateTimings());
			}

			// Token: 0x060000AB RID: 171 RVA: 0x0000357C File Offset: 0x0000177C
			[Register("getVibrateTimings", "()[J", "GetGetVibrateTimingsHandler")]
			public virtual long[] GetVibrateTimings()
			{
				return (long[])JNIEnv.GetArray(RemoteMessage.Notification._members.InstanceMethods.InvokeVirtualObjectMethod("getVibrateTimings.()[J", this, null).Handle, JniHandleOwnership.TransferLocalRef, typeof(long));
			}

			// Token: 0x0400000E RID: 14
			private static readonly JniPeerMembers _members = new XAPeerMembers("com/google/firebase/messaging/RemoteMessage$Notification", typeof(RemoteMessage.Notification));

			// Token: 0x0400000F RID: 15
			private static Delegate cb_getBody;

			// Token: 0x04000010 RID: 16
			private static Delegate cb_getBodyLocalizationKey;

			// Token: 0x04000011 RID: 17
			private static Delegate cb_getChannelId;

			// Token: 0x04000012 RID: 18
			private static Delegate cb_getClickAction;

			// Token: 0x04000013 RID: 19
			private static Delegate cb_getColor;

			// Token: 0x04000014 RID: 20
			private static Delegate cb_getDefaultLightSettings;

			// Token: 0x04000015 RID: 21
			private static Delegate cb_getDefaultSound;

			// Token: 0x04000016 RID: 22
			private static Delegate cb_getDefaultVibrateSettings;

			// Token: 0x04000017 RID: 23
			private static Delegate cb_getEventTime;

			// Token: 0x04000018 RID: 24
			private static Delegate cb_getIcon;

			// Token: 0x04000019 RID: 25
			private static Delegate cb_getImageUrl;

			// Token: 0x0400001A RID: 26
			private static Delegate cb_getLink;

			// Token: 0x0400001B RID: 27
			private static Delegate cb_getLocalOnly;

			// Token: 0x0400001C RID: 28
			private static Delegate cb_getNotificationCount;

			// Token: 0x0400001D RID: 29
			private static Delegate cb_getNotificationPriority;

			// Token: 0x0400001E RID: 30
			private static Delegate cb_getSound;

			// Token: 0x0400001F RID: 31
			private static Delegate cb_getSticky;

			// Token: 0x04000020 RID: 32
			private static Delegate cb_getTag;

			// Token: 0x04000021 RID: 33
			private static Delegate cb_getTicker;

			// Token: 0x04000022 RID: 34
			private static Delegate cb_getTitle;

			// Token: 0x04000023 RID: 35
			private static Delegate cb_getTitleLocalizationKey;

			// Token: 0x04000024 RID: 36
			private static Delegate cb_getVisibility;

			// Token: 0x04000025 RID: 37
			private static Delegate cb_getBodyLocalizationArgs;

			// Token: 0x04000026 RID: 38
			private static Delegate cb_getLightSettings;

			// Token: 0x04000027 RID: 39
			private static Delegate cb_getTitleLocalizationArgs;

			// Token: 0x04000028 RID: 40
			private static Delegate cb_getVibrateTimings;
		}
	}
}
