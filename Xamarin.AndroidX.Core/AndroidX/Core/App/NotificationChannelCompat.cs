using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Media;
using Android.Net;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace AndroidX.Core.App
{
	// Token: 0x02000070 RID: 112
	[Register("androidx/core/app/NotificationChannelCompat", DoNotGenerateAcw = true)]
	public class NotificationChannelCompat : Java.Lang.Object
	{
		// Token: 0x170000C2 RID: 194
		// (get) Token: 0x0600044F RID: 1103 RVA: 0x0000C70C File Offset: 0x0000A90C
		internal static IntPtr class_ref
		{
			get
			{
				return NotificationChannelCompat._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170000C3 RID: 195
		// (get) Token: 0x06000450 RID: 1104 RVA: 0x0000C730 File Offset: 0x0000A930
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return NotificationChannelCompat._members;
			}
		}

		// Token: 0x170000C4 RID: 196
		// (get) Token: 0x06000451 RID: 1105 RVA: 0x0000C738 File Offset: 0x0000A938
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return NotificationChannelCompat._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170000C5 RID: 197
		// (get) Token: 0x06000452 RID: 1106 RVA: 0x0000C75C File Offset: 0x0000A95C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return NotificationChannelCompat._members.ManagedPeerType;
			}
		}

		// Token: 0x06000453 RID: 1107 RVA: 0x00002384 File Offset: 0x00000584
		protected NotificationChannelCompat(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000454 RID: 1108 RVA: 0x0000C768 File Offset: 0x0000A968
		private static Delegate GetGetAudioAttributesHandler()
		{
			if (NotificationChannelCompat.cb_getAudioAttributes == null)
			{
				NotificationChannelCompat.cb_getAudioAttributes = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(NotificationChannelCompat.n_GetAudioAttributes));
			}
			return NotificationChannelCompat.cb_getAudioAttributes;
		}

		// Token: 0x06000455 RID: 1109 RVA: 0x0000C78C File Offset: 0x0000A98C
		private static IntPtr n_GetAudioAttributes(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<NotificationChannelCompat>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).AudioAttributes);
		}

		// Token: 0x170000C6 RID: 198
		// (get) Token: 0x06000456 RID: 1110 RVA: 0x0000C7A0 File Offset: 0x0000A9A0
		public virtual AudioAttributes AudioAttributes
		{
			[Register("getAudioAttributes", "()Landroid/media/AudioAttributes;", "GetGetAudioAttributesHandler")]
			get
			{
				return Java.Lang.Object.GetObject<AudioAttributes>(NotificationChannelCompat._members.InstanceMethods.InvokeVirtualObjectMethod("getAudioAttributes.()Landroid/media/AudioAttributes;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06000457 RID: 1111 RVA: 0x0000C7D2 File Offset: 0x0000A9D2
		private static Delegate GetGetConversationIdHandler()
		{
			if (NotificationChannelCompat.cb_getConversationId == null)
			{
				NotificationChannelCompat.cb_getConversationId = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(NotificationChannelCompat.n_GetConversationId));
			}
			return NotificationChannelCompat.cb_getConversationId;
		}

		// Token: 0x06000458 RID: 1112 RVA: 0x0000C7F6 File Offset: 0x0000A9F6
		private static IntPtr n_GetConversationId(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<NotificationChannelCompat>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ConversationId);
		}

		// Token: 0x170000C7 RID: 199
		// (get) Token: 0x06000459 RID: 1113 RVA: 0x0000C80C File Offset: 0x0000AA0C
		public virtual string ConversationId
		{
			[Register("getConversationId", "()Ljava/lang/String;", "GetGetConversationIdHandler")]
			get
			{
				return JNIEnv.GetString(NotificationChannelCompat._members.InstanceMethods.InvokeVirtualObjectMethod("getConversationId.()Ljava/lang/String;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x0600045A RID: 1114 RVA: 0x0000C83E File Offset: 0x0000AA3E
		private static Delegate GetGetDescriptionHandler()
		{
			if (NotificationChannelCompat.cb_getDescription == null)
			{
				NotificationChannelCompat.cb_getDescription = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(NotificationChannelCompat.n_GetDescription));
			}
			return NotificationChannelCompat.cb_getDescription;
		}

		// Token: 0x0600045B RID: 1115 RVA: 0x0000C862 File Offset: 0x0000AA62
		private static IntPtr n_GetDescription(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<NotificationChannelCompat>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Description);
		}

		// Token: 0x170000C8 RID: 200
		// (get) Token: 0x0600045C RID: 1116 RVA: 0x0000C878 File Offset: 0x0000AA78
		public virtual string Description
		{
			[Register("getDescription", "()Ljava/lang/String;", "GetGetDescriptionHandler")]
			get
			{
				return JNIEnv.GetString(NotificationChannelCompat._members.InstanceMethods.InvokeVirtualObjectMethod("getDescription.()Ljava/lang/String;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x0600045D RID: 1117 RVA: 0x0000C8AA File Offset: 0x0000AAAA
		private static Delegate GetGetGroupHandler()
		{
			if (NotificationChannelCompat.cb_getGroup == null)
			{
				NotificationChannelCompat.cb_getGroup = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(NotificationChannelCompat.n_GetGroup));
			}
			return NotificationChannelCompat.cb_getGroup;
		}

		// Token: 0x0600045E RID: 1118 RVA: 0x0000C8CE File Offset: 0x0000AACE
		private static IntPtr n_GetGroup(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<NotificationChannelCompat>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Group);
		}

		// Token: 0x170000C9 RID: 201
		// (get) Token: 0x0600045F RID: 1119 RVA: 0x0000C8E4 File Offset: 0x0000AAE4
		public virtual string Group
		{
			[Register("getGroup", "()Ljava/lang/String;", "GetGetGroupHandler")]
			get
			{
				return JNIEnv.GetString(NotificationChannelCompat._members.InstanceMethods.InvokeVirtualObjectMethod("getGroup.()Ljava/lang/String;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06000460 RID: 1120 RVA: 0x0000C916 File Offset: 0x0000AB16
		private static Delegate GetGetIdHandler()
		{
			if (NotificationChannelCompat.cb_getId == null)
			{
				NotificationChannelCompat.cb_getId = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(NotificationChannelCompat.n_GetId));
			}
			return NotificationChannelCompat.cb_getId;
		}

		// Token: 0x06000461 RID: 1121 RVA: 0x0000C93A File Offset: 0x0000AB3A
		private static IntPtr n_GetId(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<NotificationChannelCompat>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Id);
		}

		// Token: 0x170000CA RID: 202
		// (get) Token: 0x06000462 RID: 1122 RVA: 0x0000C950 File Offset: 0x0000AB50
		public virtual string Id
		{
			[Register("getId", "()Ljava/lang/String;", "GetGetIdHandler")]
			get
			{
				return JNIEnv.GetString(NotificationChannelCompat._members.InstanceMethods.InvokeVirtualObjectMethod("getId.()Ljava/lang/String;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06000463 RID: 1123 RVA: 0x0000C982 File Offset: 0x0000AB82
		private static Delegate GetGetImportanceHandler()
		{
			if (NotificationChannelCompat.cb_getImportance == null)
			{
				NotificationChannelCompat.cb_getImportance = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(NotificationChannelCompat.n_GetImportance));
			}
			return NotificationChannelCompat.cb_getImportance;
		}

		// Token: 0x06000464 RID: 1124 RVA: 0x0000C9A6 File Offset: 0x0000ABA6
		private static int n_GetImportance(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<NotificationChannelCompat>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Importance;
		}

		// Token: 0x170000CB RID: 203
		// (get) Token: 0x06000465 RID: 1125 RVA: 0x0000C9B5 File Offset: 0x0000ABB5
		public virtual int Importance
		{
			[Register("getImportance", "()I", "GetGetImportanceHandler")]
			get
			{
				return NotificationChannelCompat._members.InstanceMethods.InvokeVirtualInt32Method("getImportance.()I", this, null);
			}
		}

		// Token: 0x06000466 RID: 1126 RVA: 0x0000C9CE File Offset: 0x0000ABCE
		private static Delegate GetIsImportantConversationHandler()
		{
			if (NotificationChannelCompat.cb_isImportantConversation == null)
			{
				NotificationChannelCompat.cb_isImportantConversation = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(NotificationChannelCompat.n_IsImportantConversation));
			}
			return NotificationChannelCompat.cb_isImportantConversation;
		}

		// Token: 0x06000467 RID: 1127 RVA: 0x0000C9F2 File Offset: 0x0000ABF2
		private static bool n_IsImportantConversation(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<NotificationChannelCompat>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsImportantConversation;
		}

		// Token: 0x170000CC RID: 204
		// (get) Token: 0x06000468 RID: 1128 RVA: 0x0000CA01 File Offset: 0x0000AC01
		public virtual bool IsImportantConversation
		{
			[Register("isImportantConversation", "()Z", "GetIsImportantConversationHandler")]
			get
			{
				return NotificationChannelCompat._members.InstanceMethods.InvokeVirtualBooleanMethod("isImportantConversation.()Z", this, null);
			}
		}

		// Token: 0x06000469 RID: 1129 RVA: 0x0000CA1A File Offset: 0x0000AC1A
		private static Delegate GetGetLightColorHandler()
		{
			if (NotificationChannelCompat.cb_getLightColor == null)
			{
				NotificationChannelCompat.cb_getLightColor = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(NotificationChannelCompat.n_GetLightColor));
			}
			return NotificationChannelCompat.cb_getLightColor;
		}

		// Token: 0x0600046A RID: 1130 RVA: 0x0000CA3E File Offset: 0x0000AC3E
		private static int n_GetLightColor(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<NotificationChannelCompat>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).LightColor;
		}

		// Token: 0x170000CD RID: 205
		// (get) Token: 0x0600046B RID: 1131 RVA: 0x0000CA4D File Offset: 0x0000AC4D
		public virtual int LightColor
		{
			[Register("getLightColor", "()I", "GetGetLightColorHandler")]
			get
			{
				return NotificationChannelCompat._members.InstanceMethods.InvokeVirtualInt32Method("getLightColor.()I", this, null);
			}
		}

		// Token: 0x0600046C RID: 1132 RVA: 0x0000CA66 File Offset: 0x0000AC66
		private static Delegate GetGetLockscreenVisibilityHandler()
		{
			if (NotificationChannelCompat.cb_getLockscreenVisibility == null)
			{
				NotificationChannelCompat.cb_getLockscreenVisibility = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(NotificationChannelCompat.n_GetLockscreenVisibility));
			}
			return NotificationChannelCompat.cb_getLockscreenVisibility;
		}

		// Token: 0x0600046D RID: 1133 RVA: 0x0000CA8A File Offset: 0x0000AC8A
		private static int n_GetLockscreenVisibility(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<NotificationChannelCompat>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).LockscreenVisibility;
		}

		// Token: 0x170000CE RID: 206
		// (get) Token: 0x0600046E RID: 1134 RVA: 0x0000CA99 File Offset: 0x0000AC99
		public virtual int LockscreenVisibility
		{
			[Register("getLockscreenVisibility", "()I", "GetGetLockscreenVisibilityHandler")]
			get
			{
				return NotificationChannelCompat._members.InstanceMethods.InvokeVirtualInt32Method("getLockscreenVisibility.()I", this, null);
			}
		}

		// Token: 0x0600046F RID: 1135 RVA: 0x0000CAB2 File Offset: 0x0000ACB2
		private static Delegate GetGetNameHandler()
		{
			if (NotificationChannelCompat.cb_getName == null)
			{
				NotificationChannelCompat.cb_getName = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(NotificationChannelCompat.n_GetName));
			}
			return NotificationChannelCompat.cb_getName;
		}

		// Token: 0x06000470 RID: 1136 RVA: 0x0000CAD6 File Offset: 0x0000ACD6
		private static IntPtr n_GetName(IntPtr jnienv, IntPtr native__this)
		{
			return CharSequence.ToLocalJniHandle(Java.Lang.Object.GetObject<NotificationChannelCompat>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).NameFormatted);
		}

		// Token: 0x170000CF RID: 207
		// (get) Token: 0x06000471 RID: 1137 RVA: 0x0000CAEC File Offset: 0x0000ACEC
		public virtual ICharSequence NameFormatted
		{
			[Register("getName", "()Ljava/lang/CharSequence;", "GetGetNameHandler")]
			get
			{
				return Java.Lang.Object.GetObject<ICharSequence>(NotificationChannelCompat._members.InstanceMethods.InvokeVirtualObjectMethod("getName.()Ljava/lang/CharSequence;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x170000D0 RID: 208
		// (get) Token: 0x06000472 RID: 1138 RVA: 0x0000CB1E File Offset: 0x0000AD1E
		public string Name
		{
			get
			{
				if (this.NameFormatted != null)
				{
					return this.NameFormatted.ToString();
				}
				return null;
			}
		}

		// Token: 0x06000473 RID: 1139 RVA: 0x0000CB35 File Offset: 0x0000AD35
		private static Delegate GetGetParentChannelIdHandler()
		{
			if (NotificationChannelCompat.cb_getParentChannelId == null)
			{
				NotificationChannelCompat.cb_getParentChannelId = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(NotificationChannelCompat.n_GetParentChannelId));
			}
			return NotificationChannelCompat.cb_getParentChannelId;
		}

		// Token: 0x06000474 RID: 1140 RVA: 0x0000CB59 File Offset: 0x0000AD59
		private static IntPtr n_GetParentChannelId(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<NotificationChannelCompat>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ParentChannelId);
		}

		// Token: 0x170000D1 RID: 209
		// (get) Token: 0x06000475 RID: 1141 RVA: 0x0000CB70 File Offset: 0x0000AD70
		public virtual string ParentChannelId
		{
			[Register("getParentChannelId", "()Ljava/lang/String;", "GetGetParentChannelIdHandler")]
			get
			{
				return JNIEnv.GetString(NotificationChannelCompat._members.InstanceMethods.InvokeVirtualObjectMethod("getParentChannelId.()Ljava/lang/String;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06000476 RID: 1142 RVA: 0x0000CBA2 File Offset: 0x0000ADA2
		private static Delegate GetGetSoundHandler()
		{
			if (NotificationChannelCompat.cb_getSound == null)
			{
				NotificationChannelCompat.cb_getSound = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(NotificationChannelCompat.n_GetSound));
			}
			return NotificationChannelCompat.cb_getSound;
		}

		// Token: 0x06000477 RID: 1143 RVA: 0x0000CBC6 File Offset: 0x0000ADC6
		private static IntPtr n_GetSound(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<NotificationChannelCompat>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Sound);
		}

		// Token: 0x170000D2 RID: 210
		// (get) Token: 0x06000478 RID: 1144 RVA: 0x0000CBDC File Offset: 0x0000ADDC
		public virtual Android.Net.Uri Sound
		{
			[Register("getSound", "()Landroid/net/Uri;", "GetGetSoundHandler")]
			get
			{
				return Java.Lang.Object.GetObject<Android.Net.Uri>(NotificationChannelCompat._members.InstanceMethods.InvokeVirtualObjectMethod("getSound.()Landroid/net/Uri;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06000479 RID: 1145 RVA: 0x0000CC0E File Offset: 0x0000AE0E
		private static Delegate GetCanBubbleHandler()
		{
			if (NotificationChannelCompat.cb_canBubble == null)
			{
				NotificationChannelCompat.cb_canBubble = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(NotificationChannelCompat.n_CanBubble));
			}
			return NotificationChannelCompat.cb_canBubble;
		}

		// Token: 0x0600047A RID: 1146 RVA: 0x0000CC32 File Offset: 0x0000AE32
		private static bool n_CanBubble(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<NotificationChannelCompat>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).CanBubble();
		}

		// Token: 0x0600047B RID: 1147 RVA: 0x0000CC41 File Offset: 0x0000AE41
		[Register("canBubble", "()Z", "GetCanBubbleHandler")]
		public virtual bool CanBubble()
		{
			return NotificationChannelCompat._members.InstanceMethods.InvokeVirtualBooleanMethod("canBubble.()Z", this, null);
		}

		// Token: 0x0600047C RID: 1148 RVA: 0x0000CC5A File Offset: 0x0000AE5A
		private static Delegate GetCanBypassDndHandler()
		{
			if (NotificationChannelCompat.cb_canBypassDnd == null)
			{
				NotificationChannelCompat.cb_canBypassDnd = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(NotificationChannelCompat.n_CanBypassDnd));
			}
			return NotificationChannelCompat.cb_canBypassDnd;
		}

		// Token: 0x0600047D RID: 1149 RVA: 0x0000CC7E File Offset: 0x0000AE7E
		private static bool n_CanBypassDnd(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<NotificationChannelCompat>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).CanBypassDnd();
		}

		// Token: 0x0600047E RID: 1150 RVA: 0x0000CC8D File Offset: 0x0000AE8D
		[Register("canBypassDnd", "()Z", "GetCanBypassDndHandler")]
		public virtual bool CanBypassDnd()
		{
			return NotificationChannelCompat._members.InstanceMethods.InvokeVirtualBooleanMethod("canBypassDnd.()Z", this, null);
		}

		// Token: 0x0600047F RID: 1151 RVA: 0x0000CCA6 File Offset: 0x0000AEA6
		private static Delegate GetCanShowBadgeHandler()
		{
			if (NotificationChannelCompat.cb_canShowBadge == null)
			{
				NotificationChannelCompat.cb_canShowBadge = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(NotificationChannelCompat.n_CanShowBadge));
			}
			return NotificationChannelCompat.cb_canShowBadge;
		}

		// Token: 0x06000480 RID: 1152 RVA: 0x0000CCCA File Offset: 0x0000AECA
		private static bool n_CanShowBadge(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<NotificationChannelCompat>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).CanShowBadge();
		}

		// Token: 0x06000481 RID: 1153 RVA: 0x0000CCD9 File Offset: 0x0000AED9
		[Register("canShowBadge", "()Z", "GetCanShowBadgeHandler")]
		public virtual bool CanShowBadge()
		{
			return NotificationChannelCompat._members.InstanceMethods.InvokeVirtualBooleanMethod("canShowBadge.()Z", this, null);
		}

		// Token: 0x06000482 RID: 1154 RVA: 0x0000CCF2 File Offset: 0x0000AEF2
		private static Delegate GetGetVibrationPatternHandler()
		{
			if (NotificationChannelCompat.cb_getVibrationPattern == null)
			{
				NotificationChannelCompat.cb_getVibrationPattern = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(NotificationChannelCompat.n_GetVibrationPattern));
			}
			return NotificationChannelCompat.cb_getVibrationPattern;
		}

		// Token: 0x06000483 RID: 1155 RVA: 0x0000CD16 File Offset: 0x0000AF16
		private static IntPtr n_GetVibrationPattern(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewArray(Java.Lang.Object.GetObject<NotificationChannelCompat>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).GetVibrationPattern());
		}

		// Token: 0x06000484 RID: 1156 RVA: 0x0000CD2C File Offset: 0x0000AF2C
		[Register("getVibrationPattern", "()[J", "GetGetVibrationPatternHandler")]
		public virtual long[] GetVibrationPattern()
		{
			return (long[])JNIEnv.GetArray(NotificationChannelCompat._members.InstanceMethods.InvokeVirtualObjectMethod("getVibrationPattern.()[J", this, null).Handle, JniHandleOwnership.TransferLocalRef, typeof(long));
		}

		// Token: 0x06000485 RID: 1157 RVA: 0x0000CD6D File Offset: 0x0000AF6D
		private static Delegate GetShouldShowLightsHandler()
		{
			if (NotificationChannelCompat.cb_shouldShowLights == null)
			{
				NotificationChannelCompat.cb_shouldShowLights = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(NotificationChannelCompat.n_ShouldShowLights));
			}
			return NotificationChannelCompat.cb_shouldShowLights;
		}

		// Token: 0x06000486 RID: 1158 RVA: 0x0000CD91 File Offset: 0x0000AF91
		private static bool n_ShouldShowLights(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<NotificationChannelCompat>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ShouldShowLights();
		}

		// Token: 0x06000487 RID: 1159 RVA: 0x0000CDA0 File Offset: 0x0000AFA0
		[Register("shouldShowLights", "()Z", "GetShouldShowLightsHandler")]
		public virtual bool ShouldShowLights()
		{
			return NotificationChannelCompat._members.InstanceMethods.InvokeVirtualBooleanMethod("shouldShowLights.()Z", this, null);
		}

		// Token: 0x06000488 RID: 1160 RVA: 0x0000CDB9 File Offset: 0x0000AFB9
		private static Delegate GetShouldVibrateHandler()
		{
			if (NotificationChannelCompat.cb_shouldVibrate == null)
			{
				NotificationChannelCompat.cb_shouldVibrate = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(NotificationChannelCompat.n_ShouldVibrate));
			}
			return NotificationChannelCompat.cb_shouldVibrate;
		}

		// Token: 0x06000489 RID: 1161 RVA: 0x0000CDDD File Offset: 0x0000AFDD
		private static bool n_ShouldVibrate(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<NotificationChannelCompat>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ShouldVibrate();
		}

		// Token: 0x0600048A RID: 1162 RVA: 0x0000CDEC File Offset: 0x0000AFEC
		[Register("shouldVibrate", "()Z", "GetShouldVibrateHandler")]
		public virtual bool ShouldVibrate()
		{
			return NotificationChannelCompat._members.InstanceMethods.InvokeVirtualBooleanMethod("shouldVibrate.()Z", this, null);
		}

		// Token: 0x0600048B RID: 1163 RVA: 0x0000CE05 File Offset: 0x0000B005
		private static Delegate GetToBuilderHandler()
		{
			if (NotificationChannelCompat.cb_toBuilder == null)
			{
				NotificationChannelCompat.cb_toBuilder = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(NotificationChannelCompat.n_ToBuilder));
			}
			return NotificationChannelCompat.cb_toBuilder;
		}

		// Token: 0x0600048C RID: 1164 RVA: 0x0000CE29 File Offset: 0x0000B029
		private static IntPtr n_ToBuilder(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<NotificationChannelCompat>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ToBuilder());
		}

		// Token: 0x0600048D RID: 1165 RVA: 0x0000CE40 File Offset: 0x0000B040
		[Register("toBuilder", "()Landroidx/core/app/NotificationChannelCompat$Builder;", "GetToBuilderHandler")]
		public virtual NotificationChannelCompat.Builder ToBuilder()
		{
			return Java.Lang.Object.GetObject<NotificationChannelCompat.Builder>(NotificationChannelCompat._members.InstanceMethods.InvokeVirtualObjectMethod("toBuilder.()Landroidx/core/app/NotificationChannelCompat$Builder;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x04000126 RID: 294
		private static readonly JniPeerMembers _members = new XAPeerMembers("androidx/core/app/NotificationChannelCompat", typeof(NotificationChannelCompat));

		// Token: 0x04000127 RID: 295
		private static Delegate cb_getAudioAttributes;

		// Token: 0x04000128 RID: 296
		private static Delegate cb_getConversationId;

		// Token: 0x04000129 RID: 297
		private static Delegate cb_getDescription;

		// Token: 0x0400012A RID: 298
		private static Delegate cb_getGroup;

		// Token: 0x0400012B RID: 299
		private static Delegate cb_getId;

		// Token: 0x0400012C RID: 300
		private static Delegate cb_getImportance;

		// Token: 0x0400012D RID: 301
		private static Delegate cb_isImportantConversation;

		// Token: 0x0400012E RID: 302
		private static Delegate cb_getLightColor;

		// Token: 0x0400012F RID: 303
		private static Delegate cb_getLockscreenVisibility;

		// Token: 0x04000130 RID: 304
		private static Delegate cb_getName;

		// Token: 0x04000131 RID: 305
		private static Delegate cb_getParentChannelId;

		// Token: 0x04000132 RID: 306
		private static Delegate cb_getSound;

		// Token: 0x04000133 RID: 307
		private static Delegate cb_canBubble;

		// Token: 0x04000134 RID: 308
		private static Delegate cb_canBypassDnd;

		// Token: 0x04000135 RID: 309
		private static Delegate cb_canShowBadge;

		// Token: 0x04000136 RID: 310
		private static Delegate cb_getVibrationPattern;

		// Token: 0x04000137 RID: 311
		private static Delegate cb_shouldShowLights;

		// Token: 0x04000138 RID: 312
		private static Delegate cb_shouldVibrate;

		// Token: 0x04000139 RID: 313
		private static Delegate cb_toBuilder;

		// Token: 0x02000071 RID: 113
		[Register("androidx/core/app/NotificationChannelCompat$Builder", DoNotGenerateAcw = true)]
		public class Builder : Java.Lang.Object
		{
			// Token: 0x170000D3 RID: 211
			// (get) Token: 0x0600048F RID: 1167 RVA: 0x0000CE90 File Offset: 0x0000B090
			internal static IntPtr class_ref
			{
				get
				{
					return NotificationChannelCompat.Builder._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x170000D4 RID: 212
			// (get) Token: 0x06000490 RID: 1168 RVA: 0x0000CEB4 File Offset: 0x0000B0B4
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return NotificationChannelCompat.Builder._members;
				}
			}

			// Token: 0x170000D5 RID: 213
			// (get) Token: 0x06000491 RID: 1169 RVA: 0x0000CEBC File Offset: 0x0000B0BC
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return NotificationChannelCompat.Builder._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x170000D6 RID: 214
			// (get) Token: 0x06000492 RID: 1170 RVA: 0x0000CEE0 File Offset: 0x0000B0E0
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return NotificationChannelCompat.Builder._members.ManagedPeerType;
				}
			}

			// Token: 0x06000493 RID: 1171 RVA: 0x00002384 File Offset: 0x00000584
			protected Builder(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
			{
			}

			// Token: 0x06000494 RID: 1172 RVA: 0x0000CEEC File Offset: 0x0000B0EC
			[Register(".ctor", "(Ljava/lang/String;I)V", "")]
			public unsafe Builder(string id, int importance) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (base.Handle != IntPtr.Zero)
				{
					return;
				}
				IntPtr intPtr = JNIEnv.NewString(id);
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue(intPtr);
					ptr[1] = new JniArgumentValue(importance);
					base.SetHandle(NotificationChannelCompat.Builder._members.InstanceMethods.StartCreateInstance("(Ljava/lang/String;I)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
					NotificationChannelCompat.Builder._members.InstanceMethods.FinishCreateInstance("(Ljava/lang/String;I)V", this, ptr);
				}
				finally
				{
					JNIEnv.DeleteLocalRef(intPtr);
				}
			}

			// Token: 0x06000495 RID: 1173 RVA: 0x0000CFA4 File Offset: 0x0000B1A4
			private static Delegate GetBuildHandler()
			{
				if (NotificationChannelCompat.Builder.cb_build == null)
				{
					NotificationChannelCompat.Builder.cb_build = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(NotificationChannelCompat.Builder.n_Build));
				}
				return NotificationChannelCompat.Builder.cb_build;
			}

			// Token: 0x06000496 RID: 1174 RVA: 0x0000CFC8 File Offset: 0x0000B1C8
			private static IntPtr n_Build(IntPtr jnienv, IntPtr native__this)
			{
				return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<NotificationChannelCompat.Builder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Build());
			}

			// Token: 0x06000497 RID: 1175 RVA: 0x0000CFDC File Offset: 0x0000B1DC
			[Register("build", "()Landroidx/core/app/NotificationChannelCompat;", "GetBuildHandler")]
			public virtual NotificationChannelCompat Build()
			{
				return Java.Lang.Object.GetObject<NotificationChannelCompat>(NotificationChannelCompat.Builder._members.InstanceMethods.InvokeVirtualObjectMethod("build.()Landroidx/core/app/NotificationChannelCompat;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}

			// Token: 0x06000498 RID: 1176 RVA: 0x0000D00E File Offset: 0x0000B20E
			private static Delegate GetSetConversationId_Ljava_lang_String_Ljava_lang_String_Handler()
			{
				if (NotificationChannelCompat.Builder.cb_setConversationId_Ljava_lang_String_Ljava_lang_String_ == null)
				{
					NotificationChannelCompat.Builder.cb_setConversationId_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_L(NotificationChannelCompat.Builder.n_SetConversationId_Ljava_lang_String_Ljava_lang_String_));
				}
				return NotificationChannelCompat.Builder.cb_setConversationId_Ljava_lang_String_Ljava_lang_String_;
			}

			// Token: 0x06000499 RID: 1177 RVA: 0x0000D034 File Offset: 0x0000B234
			private static IntPtr n_SetConversationId_Ljava_lang_String_Ljava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native_parentChannelId, IntPtr native_conversationId)
			{
				NotificationChannelCompat.Builder @object = Java.Lang.Object.GetObject<NotificationChannelCompat.Builder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string @string = JNIEnv.GetString(native_parentChannelId, JniHandleOwnership.DoNotTransfer);
				string string2 = JNIEnv.GetString(native_conversationId, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle(@object.SetConversationId(@string, string2));
			}

			// Token: 0x0600049A RID: 1178 RVA: 0x0000D068 File Offset: 0x0000B268
			[Register("setConversationId", "(Ljava/lang/String;Ljava/lang/String;)Landroidx/core/app/NotificationChannelCompat$Builder;", "GetSetConversationId_Ljava_lang_String_Ljava_lang_String_Handler")]
			public unsafe virtual NotificationChannelCompat.Builder SetConversationId(string parentChannelId, string conversationId)
			{
				IntPtr intPtr = JNIEnv.NewString(parentChannelId);
				IntPtr intPtr2 = JNIEnv.NewString(conversationId);
				NotificationChannelCompat.Builder @object;
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue(intPtr);
					ptr[1] = new JniArgumentValue(intPtr2);
					@object = Java.Lang.Object.GetObject<NotificationChannelCompat.Builder>(NotificationChannelCompat.Builder._members.InstanceMethods.InvokeVirtualObjectMethod("setConversationId.(Ljava/lang/String;Ljava/lang/String;)Landroidx/core/app/NotificationChannelCompat$Builder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
				}
				finally
				{
					JNIEnv.DeleteLocalRef(intPtr);
					JNIEnv.DeleteLocalRef(intPtr2);
				}
				return @object;
			}

			// Token: 0x0600049B RID: 1179 RVA: 0x0000D0F8 File Offset: 0x0000B2F8
			private static Delegate GetSetDescription_Ljava_lang_String_Handler()
			{
				if (NotificationChannelCompat.Builder.cb_setDescription_Ljava_lang_String_ == null)
				{
					NotificationChannelCompat.Builder.cb_setDescription_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(NotificationChannelCompat.Builder.n_SetDescription_Ljava_lang_String_));
				}
				return NotificationChannelCompat.Builder.cb_setDescription_Ljava_lang_String_;
			}

			// Token: 0x0600049C RID: 1180 RVA: 0x0000D11C File Offset: 0x0000B31C
			private static IntPtr n_SetDescription_Ljava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native_description)
			{
				NotificationChannelCompat.Builder @object = Java.Lang.Object.GetObject<NotificationChannelCompat.Builder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string @string = JNIEnv.GetString(native_description, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle(@object.SetDescription(@string));
			}

			// Token: 0x0600049D RID: 1181 RVA: 0x0000D144 File Offset: 0x0000B344
			[Register("setDescription", "(Ljava/lang/String;)Landroidx/core/app/NotificationChannelCompat$Builder;", "GetSetDescription_Ljava_lang_String_Handler")]
			public unsafe virtual NotificationChannelCompat.Builder SetDescription(string description)
			{
				IntPtr intPtr = JNIEnv.NewString(description);
				NotificationChannelCompat.Builder @object;
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue(intPtr);
					@object = Java.Lang.Object.GetObject<NotificationChannelCompat.Builder>(NotificationChannelCompat.Builder._members.InstanceMethods.InvokeVirtualObjectMethod("setDescription.(Ljava/lang/String;)Landroidx/core/app/NotificationChannelCompat$Builder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
				}
				finally
				{
					JNIEnv.DeleteLocalRef(intPtr);
				}
				return @object;
			}

			// Token: 0x0600049E RID: 1182 RVA: 0x0000D1B0 File Offset: 0x0000B3B0
			private static Delegate GetSetGroup_Ljava_lang_String_Handler()
			{
				if (NotificationChannelCompat.Builder.cb_setGroup_Ljava_lang_String_ == null)
				{
					NotificationChannelCompat.Builder.cb_setGroup_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(NotificationChannelCompat.Builder.n_SetGroup_Ljava_lang_String_));
				}
				return NotificationChannelCompat.Builder.cb_setGroup_Ljava_lang_String_;
			}

			// Token: 0x0600049F RID: 1183 RVA: 0x0000D1D4 File Offset: 0x0000B3D4
			private static IntPtr n_SetGroup_Ljava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native_groupId)
			{
				NotificationChannelCompat.Builder @object = Java.Lang.Object.GetObject<NotificationChannelCompat.Builder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string @string = JNIEnv.GetString(native_groupId, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle(@object.SetGroup(@string));
			}

			// Token: 0x060004A0 RID: 1184 RVA: 0x0000D1FC File Offset: 0x0000B3FC
			[Register("setGroup", "(Ljava/lang/String;)Landroidx/core/app/NotificationChannelCompat$Builder;", "GetSetGroup_Ljava_lang_String_Handler")]
			public unsafe virtual NotificationChannelCompat.Builder SetGroup(string groupId)
			{
				IntPtr intPtr = JNIEnv.NewString(groupId);
				NotificationChannelCompat.Builder @object;
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue(intPtr);
					@object = Java.Lang.Object.GetObject<NotificationChannelCompat.Builder>(NotificationChannelCompat.Builder._members.InstanceMethods.InvokeVirtualObjectMethod("setGroup.(Ljava/lang/String;)Landroidx/core/app/NotificationChannelCompat$Builder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
				}
				finally
				{
					JNIEnv.DeleteLocalRef(intPtr);
				}
				return @object;
			}

			// Token: 0x060004A1 RID: 1185 RVA: 0x0000D268 File Offset: 0x0000B468
			private static Delegate GetSetImportance_IHandler()
			{
				if (NotificationChannelCompat.Builder.cb_setImportance_I == null)
				{
					NotificationChannelCompat.Builder.cb_setImportance_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_L(NotificationChannelCompat.Builder.n_SetImportance_I));
				}
				return NotificationChannelCompat.Builder.cb_setImportance_I;
			}

			// Token: 0x060004A2 RID: 1186 RVA: 0x0000D28C File Offset: 0x0000B48C
			private static IntPtr n_SetImportance_I(IntPtr jnienv, IntPtr native__this, int importance)
			{
				return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<NotificationChannelCompat.Builder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SetImportance(importance));
			}

			// Token: 0x060004A3 RID: 1187 RVA: 0x0000D2A4 File Offset: 0x0000B4A4
			[Register("setImportance", "(I)Landroidx/core/app/NotificationChannelCompat$Builder;", "GetSetImportance_IHandler")]
			public unsafe virtual NotificationChannelCompat.Builder SetImportance(int importance)
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(importance);
				return Java.Lang.Object.GetObject<NotificationChannelCompat.Builder>(NotificationChannelCompat.Builder._members.InstanceMethods.InvokeVirtualObjectMethod("setImportance.(I)Landroidx/core/app/NotificationChannelCompat$Builder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}

			// Token: 0x060004A4 RID: 1188 RVA: 0x0000D2ED File Offset: 0x0000B4ED
			private static Delegate GetSetLightColor_IHandler()
			{
				if (NotificationChannelCompat.Builder.cb_setLightColor_I == null)
				{
					NotificationChannelCompat.Builder.cb_setLightColor_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_L(NotificationChannelCompat.Builder.n_SetLightColor_I));
				}
				return NotificationChannelCompat.Builder.cb_setLightColor_I;
			}

			// Token: 0x060004A5 RID: 1189 RVA: 0x0000D311 File Offset: 0x0000B511
			private static IntPtr n_SetLightColor_I(IntPtr jnienv, IntPtr native__this, int argb)
			{
				return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<NotificationChannelCompat.Builder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SetLightColor(argb));
			}

			// Token: 0x060004A6 RID: 1190 RVA: 0x0000D328 File Offset: 0x0000B528
			[Register("setLightColor", "(I)Landroidx/core/app/NotificationChannelCompat$Builder;", "GetSetLightColor_IHandler")]
			public unsafe virtual NotificationChannelCompat.Builder SetLightColor(int argb)
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(argb);
				return Java.Lang.Object.GetObject<NotificationChannelCompat.Builder>(NotificationChannelCompat.Builder._members.InstanceMethods.InvokeVirtualObjectMethod("setLightColor.(I)Landroidx/core/app/NotificationChannelCompat$Builder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}

			// Token: 0x060004A7 RID: 1191 RVA: 0x0000D371 File Offset: 0x0000B571
			private static Delegate GetSetLightsEnabled_ZHandler()
			{
				if (NotificationChannelCompat.Builder.cb_setLightsEnabled_Z == null)
				{
					NotificationChannelCompat.Builder.cb_setLightsEnabled_Z = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPZ_L(NotificationChannelCompat.Builder.n_SetLightsEnabled_Z));
				}
				return NotificationChannelCompat.Builder.cb_setLightsEnabled_Z;
			}

			// Token: 0x060004A8 RID: 1192 RVA: 0x0000D395 File Offset: 0x0000B595
			private static IntPtr n_SetLightsEnabled_Z(IntPtr jnienv, IntPtr native__this, bool lights)
			{
				return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<NotificationChannelCompat.Builder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SetLightsEnabled(lights));
			}

			// Token: 0x060004A9 RID: 1193 RVA: 0x0000D3AC File Offset: 0x0000B5AC
			[Register("setLightsEnabled", "(Z)Landroidx/core/app/NotificationChannelCompat$Builder;", "GetSetLightsEnabled_ZHandler")]
			public unsafe virtual NotificationChannelCompat.Builder SetLightsEnabled(bool lights)
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(lights);
				return Java.Lang.Object.GetObject<NotificationChannelCompat.Builder>(NotificationChannelCompat.Builder._members.InstanceMethods.InvokeVirtualObjectMethod("setLightsEnabled.(Z)Landroidx/core/app/NotificationChannelCompat$Builder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}

			// Token: 0x060004AA RID: 1194 RVA: 0x0000D3F5 File Offset: 0x0000B5F5
			private static Delegate GetSetName_Ljava_lang_CharSequence_Handler()
			{
				if (NotificationChannelCompat.Builder.cb_setName_Ljava_lang_CharSequence_ == null)
				{
					NotificationChannelCompat.Builder.cb_setName_Ljava_lang_CharSequence_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(NotificationChannelCompat.Builder.n_SetName_Ljava_lang_CharSequence_));
				}
				return NotificationChannelCompat.Builder.cb_setName_Ljava_lang_CharSequence_;
			}

			// Token: 0x060004AB RID: 1195 RVA: 0x0000D41C File Offset: 0x0000B61C
			private static IntPtr n_SetName_Ljava_lang_CharSequence_(IntPtr jnienv, IntPtr native__this, IntPtr native_name)
			{
				NotificationChannelCompat.Builder @object = Java.Lang.Object.GetObject<NotificationChannelCompat.Builder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				ICharSequence object2 = Java.Lang.Object.GetObject<ICharSequence>(native_name, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle(@object.SetName(object2));
			}

			// Token: 0x060004AC RID: 1196 RVA: 0x0000D444 File Offset: 0x0000B644
			[Register("setName", "(Ljava/lang/CharSequence;)Landroidx/core/app/NotificationChannelCompat$Builder;", "GetSetName_Ljava_lang_CharSequence_Handler")]
			public unsafe virtual NotificationChannelCompat.Builder SetName(ICharSequence name)
			{
				IntPtr intPtr = CharSequence.ToLocalJniHandle(name);
				NotificationChannelCompat.Builder @object;
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue(intPtr);
					@object = Java.Lang.Object.GetObject<NotificationChannelCompat.Builder>(NotificationChannelCompat.Builder._members.InstanceMethods.InvokeVirtualObjectMethod("setName.(Ljava/lang/CharSequence;)Landroidx/core/app/NotificationChannelCompat$Builder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
				}
				finally
				{
					JNIEnv.DeleteLocalRef(intPtr);
					GC.KeepAlive(name);
				}
				return @object;
			}

			// Token: 0x060004AD RID: 1197 RVA: 0x0000D4B8 File Offset: 0x0000B6B8
			public NotificationChannelCompat.Builder SetName(string name)
			{
				Java.Lang.String @string = (name == null) ? null : new Java.Lang.String(name);
				NotificationChannelCompat.Builder result = this.SetName(@string);
				if (@string != null)
				{
					@string.Dispose();
				}
				return result;
			}

			// Token: 0x060004AE RID: 1198 RVA: 0x0000D4E2 File Offset: 0x0000B6E2
			private static Delegate GetSetShowBadge_ZHandler()
			{
				if (NotificationChannelCompat.Builder.cb_setShowBadge_Z == null)
				{
					NotificationChannelCompat.Builder.cb_setShowBadge_Z = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPZ_L(NotificationChannelCompat.Builder.n_SetShowBadge_Z));
				}
				return NotificationChannelCompat.Builder.cb_setShowBadge_Z;
			}

			// Token: 0x060004AF RID: 1199 RVA: 0x0000D506 File Offset: 0x0000B706
			private static IntPtr n_SetShowBadge_Z(IntPtr jnienv, IntPtr native__this, bool showBadge)
			{
				return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<NotificationChannelCompat.Builder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SetShowBadge(showBadge));
			}

			// Token: 0x060004B0 RID: 1200 RVA: 0x0000D51C File Offset: 0x0000B71C
			[Register("setShowBadge", "(Z)Landroidx/core/app/NotificationChannelCompat$Builder;", "GetSetShowBadge_ZHandler")]
			public unsafe virtual NotificationChannelCompat.Builder SetShowBadge(bool showBadge)
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(showBadge);
				return Java.Lang.Object.GetObject<NotificationChannelCompat.Builder>(NotificationChannelCompat.Builder._members.InstanceMethods.InvokeVirtualObjectMethod("setShowBadge.(Z)Landroidx/core/app/NotificationChannelCompat$Builder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}

			// Token: 0x060004B1 RID: 1201 RVA: 0x0000D565 File Offset: 0x0000B765
			private static Delegate GetSetSound_Landroid_net_Uri_Landroid_media_AudioAttributes_Handler()
			{
				if (NotificationChannelCompat.Builder.cb_setSound_Landroid_net_Uri_Landroid_media_AudioAttributes_ == null)
				{
					NotificationChannelCompat.Builder.cb_setSound_Landroid_net_Uri_Landroid_media_AudioAttributes_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_L(NotificationChannelCompat.Builder.n_SetSound_Landroid_net_Uri_Landroid_media_AudioAttributes_));
				}
				return NotificationChannelCompat.Builder.cb_setSound_Landroid_net_Uri_Landroid_media_AudioAttributes_;
			}

			// Token: 0x060004B2 RID: 1202 RVA: 0x0000D58C File Offset: 0x0000B78C
			private static IntPtr n_SetSound_Landroid_net_Uri_Landroid_media_AudioAttributes_(IntPtr jnienv, IntPtr native__this, IntPtr native_sound, IntPtr native_audioAttributes)
			{
				NotificationChannelCompat.Builder @object = Java.Lang.Object.GetObject<NotificationChannelCompat.Builder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				Android.Net.Uri object2 = Java.Lang.Object.GetObject<Android.Net.Uri>(native_sound, JniHandleOwnership.DoNotTransfer);
				AudioAttributes object3 = Java.Lang.Object.GetObject<AudioAttributes>(native_audioAttributes, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle(@object.SetSound(object2, object3));
			}

			// Token: 0x060004B3 RID: 1203 RVA: 0x0000D5C0 File Offset: 0x0000B7C0
			[Register("setSound", "(Landroid/net/Uri;Landroid/media/AudioAttributes;)Landroidx/core/app/NotificationChannelCompat$Builder;", "GetSetSound_Landroid_net_Uri_Landroid_media_AudioAttributes_Handler")]
			public unsafe virtual NotificationChannelCompat.Builder SetSound(Android.Net.Uri sound, AudioAttributes audioAttributes)
			{
				NotificationChannelCompat.Builder @object;
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((sound == null) ? IntPtr.Zero : sound.Handle);
					ptr[1] = new JniArgumentValue((audioAttributes == null) ? IntPtr.Zero : audioAttributes.Handle);
					@object = Java.Lang.Object.GetObject<NotificationChannelCompat.Builder>(NotificationChannelCompat.Builder._members.InstanceMethods.InvokeVirtualObjectMethod("setSound.(Landroid/net/Uri;Landroid/media/AudioAttributes;)Landroidx/core/app/NotificationChannelCompat$Builder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
				}
				finally
				{
					GC.KeepAlive(sound);
					GC.KeepAlive(audioAttributes);
				}
				return @object;
			}

			// Token: 0x060004B4 RID: 1204 RVA: 0x0000D65C File Offset: 0x0000B85C
			private static Delegate GetSetVibrationEnabled_ZHandler()
			{
				if (NotificationChannelCompat.Builder.cb_setVibrationEnabled_Z == null)
				{
					NotificationChannelCompat.Builder.cb_setVibrationEnabled_Z = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPZ_L(NotificationChannelCompat.Builder.n_SetVibrationEnabled_Z));
				}
				return NotificationChannelCompat.Builder.cb_setVibrationEnabled_Z;
			}

			// Token: 0x060004B5 RID: 1205 RVA: 0x0000D680 File Offset: 0x0000B880
			private static IntPtr n_SetVibrationEnabled_Z(IntPtr jnienv, IntPtr native__this, bool vibration)
			{
				return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<NotificationChannelCompat.Builder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SetVibrationEnabled(vibration));
			}

			// Token: 0x060004B6 RID: 1206 RVA: 0x0000D698 File Offset: 0x0000B898
			[Register("setVibrationEnabled", "(Z)Landroidx/core/app/NotificationChannelCompat$Builder;", "GetSetVibrationEnabled_ZHandler")]
			public unsafe virtual NotificationChannelCompat.Builder SetVibrationEnabled(bool vibration)
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(vibration);
				return Java.Lang.Object.GetObject<NotificationChannelCompat.Builder>(NotificationChannelCompat.Builder._members.InstanceMethods.InvokeVirtualObjectMethod("setVibrationEnabled.(Z)Landroidx/core/app/NotificationChannelCompat$Builder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}

			// Token: 0x060004B7 RID: 1207 RVA: 0x0000D6E1 File Offset: 0x0000B8E1
			private static Delegate GetSetVibrationPattern_arrayJHandler()
			{
				if (NotificationChannelCompat.Builder.cb_setVibrationPattern_arrayJ == null)
				{
					NotificationChannelCompat.Builder.cb_setVibrationPattern_arrayJ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(NotificationChannelCompat.Builder.n_SetVibrationPattern_arrayJ));
				}
				return NotificationChannelCompat.Builder.cb_setVibrationPattern_arrayJ;
			}

			// Token: 0x060004B8 RID: 1208 RVA: 0x0000D708 File Offset: 0x0000B908
			private static IntPtr n_SetVibrationPattern_arrayJ(IntPtr jnienv, IntPtr native__this, IntPtr native_vibrationPattern)
			{
				NotificationChannelCompat.Builder @object = Java.Lang.Object.GetObject<NotificationChannelCompat.Builder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				long[] array = (long[])JNIEnv.GetArray(native_vibrationPattern, JniHandleOwnership.DoNotTransfer, typeof(long));
				IntPtr result = JNIEnv.ToLocalJniHandle(@object.SetVibrationPattern(array));
				if (array != null)
				{
					JNIEnv.CopyArray(array, native_vibrationPattern);
				}
				return result;
			}

			// Token: 0x060004B9 RID: 1209 RVA: 0x0000D74C File Offset: 0x0000B94C
			[Register("setVibrationPattern", "([J)Landroidx/core/app/NotificationChannelCompat$Builder;", "GetSetVibrationPattern_arrayJHandler")]
			public unsafe virtual NotificationChannelCompat.Builder SetVibrationPattern(long[] vibrationPattern)
			{
				IntPtr intPtr = JNIEnv.NewArray(vibrationPattern);
				NotificationChannelCompat.Builder @object;
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue(intPtr);
					@object = Java.Lang.Object.GetObject<NotificationChannelCompat.Builder>(NotificationChannelCompat.Builder._members.InstanceMethods.InvokeVirtualObjectMethod("setVibrationPattern.([J)Landroidx/core/app/NotificationChannelCompat$Builder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
				}
				finally
				{
					if (vibrationPattern != null)
					{
						JNIEnv.CopyArray(intPtr, vibrationPattern);
						JNIEnv.DeleteLocalRef(intPtr);
					}
					GC.KeepAlive(vibrationPattern);
				}
				return @object;
			}

			// Token: 0x0400013A RID: 314
			private static readonly JniPeerMembers _members = new XAPeerMembers("androidx/core/app/NotificationChannelCompat$Builder", typeof(NotificationChannelCompat.Builder));

			// Token: 0x0400013B RID: 315
			private static Delegate cb_build;

			// Token: 0x0400013C RID: 316
			private static Delegate cb_setConversationId_Ljava_lang_String_Ljava_lang_String_;

			// Token: 0x0400013D RID: 317
			private static Delegate cb_setDescription_Ljava_lang_String_;

			// Token: 0x0400013E RID: 318
			private static Delegate cb_setGroup_Ljava_lang_String_;

			// Token: 0x0400013F RID: 319
			private static Delegate cb_setImportance_I;

			// Token: 0x04000140 RID: 320
			private static Delegate cb_setLightColor_I;

			// Token: 0x04000141 RID: 321
			private static Delegate cb_setLightsEnabled_Z;

			// Token: 0x04000142 RID: 322
			private static Delegate cb_setName_Ljava_lang_CharSequence_;

			// Token: 0x04000143 RID: 323
			private static Delegate cb_setShowBadge_Z;

			// Token: 0x04000144 RID: 324
			private static Delegate cb_setSound_Landroid_net_Uri_Landroid_media_AudioAttributes_;

			// Token: 0x04000145 RID: 325
			private static Delegate cb_setVibrationEnabled_Z;

			// Token: 0x04000146 RID: 326
			private static Delegate cb_setVibrationPattern_arrayJ;
		}
	}
}
