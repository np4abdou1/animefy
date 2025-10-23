using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Com.Adcolony.Sdk
{
	// Token: 0x0200004B RID: 75
	[Register("com/adcolony/sdk/AdColonyZone", DoNotGenerateAcw = true)]
	public class AdColonyZone : Java.Lang.Object
	{
		// Token: 0x1700010B RID: 267
		// (get) Token: 0x060003E4 RID: 996 RVA: 0x0000C36C File Offset: 0x0000A56C
		internal static IntPtr class_ref
		{
			get
			{
				return AdColonyZone._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700010C RID: 268
		// (get) Token: 0x060003E5 RID: 997 RVA: 0x0000C390 File Offset: 0x0000A590
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return AdColonyZone._members;
			}
		}

		// Token: 0x1700010D RID: 269
		// (get) Token: 0x060003E6 RID: 998 RVA: 0x0000C398 File Offset: 0x0000A598
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return AdColonyZone._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700010E RID: 270
		// (get) Token: 0x060003E7 RID: 999 RVA: 0x0000C3BC File Offset: 0x0000A5BC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return AdColonyZone._members.ManagedPeerType;
			}
		}

		// Token: 0x060003E8 RID: 1000 RVA: 0x00002128 File Offset: 0x00000328
		protected AdColonyZone(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x060003E9 RID: 1001 RVA: 0x0000C3C8 File Offset: 0x0000A5C8
		private static Delegate GetIsRewardedHandler()
		{
			if (AdColonyZone.cb_isRewarded == null)
			{
				AdColonyZone.cb_isRewarded = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(AdColonyZone.n_IsRewarded));
			}
			return AdColonyZone.cb_isRewarded;
		}

		// Token: 0x060003EA RID: 1002 RVA: 0x0000C3EC File Offset: 0x0000A5EC
		private static bool n_IsRewarded(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<AdColonyZone>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsRewarded;
		}

		// Token: 0x1700010F RID: 271
		// (get) Token: 0x060003EB RID: 1003 RVA: 0x0000C3FB File Offset: 0x0000A5FB
		public virtual bool IsRewarded
		{
			[Register("isRewarded", "()Z", "GetIsRewardedHandler")]
			get
			{
				return AdColonyZone._members.InstanceMethods.InvokeVirtualBooleanMethod("isRewarded.()Z", this, null);
			}
		}

		// Token: 0x060003EC RID: 1004 RVA: 0x0000C414 File Offset: 0x0000A614
		private static Delegate GetIsValidHandler()
		{
			if (AdColonyZone.cb_isValid == null)
			{
				AdColonyZone.cb_isValid = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(AdColonyZone.n_IsValid));
			}
			return AdColonyZone.cb_isValid;
		}

		// Token: 0x060003ED RID: 1005 RVA: 0x0000C438 File Offset: 0x0000A638
		private static bool n_IsValid(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<AdColonyZone>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsValid;
		}

		// Token: 0x17000110 RID: 272
		// (get) Token: 0x060003EE RID: 1006 RVA: 0x0000C447 File Offset: 0x0000A647
		public virtual bool IsValid
		{
			[Register("isValid", "()Z", "GetIsValidHandler")]
			get
			{
				return AdColonyZone._members.InstanceMethods.InvokeVirtualBooleanMethod("isValid.()Z", this, null);
			}
		}

		// Token: 0x060003EF RID: 1007 RVA: 0x0000C460 File Offset: 0x0000A660
		private static Delegate GetGetPlayFrequencyHandler()
		{
			if (AdColonyZone.cb_getPlayFrequency == null)
			{
				AdColonyZone.cb_getPlayFrequency = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(AdColonyZone.n_GetPlayFrequency));
			}
			return AdColonyZone.cb_getPlayFrequency;
		}

		// Token: 0x060003F0 RID: 1008 RVA: 0x0000C484 File Offset: 0x0000A684
		private static int n_GetPlayFrequency(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<AdColonyZone>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).PlayFrequency;
		}

		// Token: 0x17000111 RID: 273
		// (get) Token: 0x060003F1 RID: 1009 RVA: 0x0000C493 File Offset: 0x0000A693
		public virtual int PlayFrequency
		{
			[Register("getPlayFrequency", "()I", "GetGetPlayFrequencyHandler")]
			get
			{
				return AdColonyZone._members.InstanceMethods.InvokeVirtualInt32Method("getPlayFrequency.()I", this, null);
			}
		}

		// Token: 0x060003F2 RID: 1010 RVA: 0x0000C4AC File Offset: 0x0000A6AC
		private static Delegate GetGetRemainingViewsUntilRewardHandler()
		{
			if (AdColonyZone.cb_getRemainingViewsUntilReward == null)
			{
				AdColonyZone.cb_getRemainingViewsUntilReward = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(AdColonyZone.n_GetRemainingViewsUntilReward));
			}
			return AdColonyZone.cb_getRemainingViewsUntilReward;
		}

		// Token: 0x060003F3 RID: 1011 RVA: 0x0000C4D0 File Offset: 0x0000A6D0
		private static int n_GetRemainingViewsUntilReward(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<AdColonyZone>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).RemainingViewsUntilReward;
		}

		// Token: 0x17000112 RID: 274
		// (get) Token: 0x060003F4 RID: 1012 RVA: 0x0000C4DF File Offset: 0x0000A6DF
		public virtual int RemainingViewsUntilReward
		{
			[Register("getRemainingViewsUntilReward", "()I", "GetGetRemainingViewsUntilRewardHandler")]
			get
			{
				return AdColonyZone._members.InstanceMethods.InvokeVirtualInt32Method("getRemainingViewsUntilReward.()I", this, null);
			}
		}

		// Token: 0x060003F5 RID: 1013 RVA: 0x0000C4F8 File Offset: 0x0000A6F8
		private static Delegate GetGetRewardAmountHandler()
		{
			if (AdColonyZone.cb_getRewardAmount == null)
			{
				AdColonyZone.cb_getRewardAmount = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(AdColonyZone.n_GetRewardAmount));
			}
			return AdColonyZone.cb_getRewardAmount;
		}

		// Token: 0x060003F6 RID: 1014 RVA: 0x0000C51C File Offset: 0x0000A71C
		private static int n_GetRewardAmount(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<AdColonyZone>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).RewardAmount;
		}

		// Token: 0x17000113 RID: 275
		// (get) Token: 0x060003F7 RID: 1015 RVA: 0x0000C52B File Offset: 0x0000A72B
		public virtual int RewardAmount
		{
			[Register("getRewardAmount", "()I", "GetGetRewardAmountHandler")]
			get
			{
				return AdColonyZone._members.InstanceMethods.InvokeVirtualInt32Method("getRewardAmount.()I", this, null);
			}
		}

		// Token: 0x060003F8 RID: 1016 RVA: 0x0000C544 File Offset: 0x0000A744
		private static Delegate GetGetRewardNameHandler()
		{
			if (AdColonyZone.cb_getRewardName == null)
			{
				AdColonyZone.cb_getRewardName = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(AdColonyZone.n_GetRewardName));
			}
			return AdColonyZone.cb_getRewardName;
		}

		// Token: 0x060003F9 RID: 1017 RVA: 0x0000C568 File Offset: 0x0000A768
		private static IntPtr n_GetRewardName(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<AdColonyZone>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).RewardName);
		}

		// Token: 0x17000114 RID: 276
		// (get) Token: 0x060003FA RID: 1018 RVA: 0x0000C57C File Offset: 0x0000A77C
		public virtual string RewardName
		{
			[Register("getRewardName", "()Ljava/lang/String;", "GetGetRewardNameHandler")]
			get
			{
				return JNIEnv.GetString(AdColonyZone._members.InstanceMethods.InvokeVirtualObjectMethod("getRewardName.()Ljava/lang/String;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x060003FB RID: 1019 RVA: 0x0000C5AE File Offset: 0x0000A7AE
		private static Delegate GetGetViewsPerRewardHandler()
		{
			if (AdColonyZone.cb_getViewsPerReward == null)
			{
				AdColonyZone.cb_getViewsPerReward = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(AdColonyZone.n_GetViewsPerReward));
			}
			return AdColonyZone.cb_getViewsPerReward;
		}

		// Token: 0x060003FC RID: 1020 RVA: 0x0000C5D2 File Offset: 0x0000A7D2
		private static int n_GetViewsPerReward(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<AdColonyZone>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ViewsPerReward;
		}

		// Token: 0x17000115 RID: 277
		// (get) Token: 0x060003FD RID: 1021 RVA: 0x0000C5E1 File Offset: 0x0000A7E1
		public virtual int ViewsPerReward
		{
			[Register("getViewsPerReward", "()I", "GetGetViewsPerRewardHandler")]
			get
			{
				return AdColonyZone._members.InstanceMethods.InvokeVirtualInt32Method("getViewsPerReward.()I", this, null);
			}
		}

		// Token: 0x060003FE RID: 1022 RVA: 0x0000C5FA File Offset: 0x0000A7FA
		private static Delegate GetGetZoneIDHandler()
		{
			if (AdColonyZone.cb_getZoneID == null)
			{
				AdColonyZone.cb_getZoneID = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(AdColonyZone.n_GetZoneID));
			}
			return AdColonyZone.cb_getZoneID;
		}

		// Token: 0x060003FF RID: 1023 RVA: 0x0000C61E File Offset: 0x0000A81E
		private static IntPtr n_GetZoneID(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<AdColonyZone>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ZoneID);
		}

		// Token: 0x17000116 RID: 278
		// (get) Token: 0x06000400 RID: 1024 RVA: 0x0000C634 File Offset: 0x0000A834
		public virtual string ZoneID
		{
			[Register("getZoneID", "()Ljava/lang/String;", "GetGetZoneIDHandler")]
			get
			{
				return JNIEnv.GetString(AdColonyZone._members.InstanceMethods.InvokeVirtualObjectMethod("getZoneID.()Ljava/lang/String;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06000401 RID: 1025 RVA: 0x0000C666 File Offset: 0x0000A866
		private static Delegate GetGetZoneTypeHandler()
		{
			if (AdColonyZone.cb_getZoneType == null)
			{
				AdColonyZone.cb_getZoneType = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(AdColonyZone.n_GetZoneType));
			}
			return AdColonyZone.cb_getZoneType;
		}

		// Token: 0x06000402 RID: 1026 RVA: 0x0000C68A File Offset: 0x0000A88A
		private static int n_GetZoneType(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<AdColonyZone>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ZoneType;
		}

		// Token: 0x17000117 RID: 279
		// (get) Token: 0x06000403 RID: 1027 RVA: 0x0000C699 File Offset: 0x0000A899
		public virtual int ZoneType
		{
			[Register("getZoneType", "()I", "GetGetZoneTypeHandler")]
			get
			{
				return AdColonyZone._members.InstanceMethods.InvokeVirtualInt32Method("getZoneType.()I", this, null);
			}
		}

		// Token: 0x04000115 RID: 277
		[Register("BANNER")]
		public const int Banner = 1;

		// Token: 0x04000116 RID: 278
		[Register("INTERSTITIAL")]
		public const int Interstitial = 0;

		// Token: 0x04000117 RID: 279
		[Register("NATIVE")]
		[Obsolete("deprecated")]
		public const int Native = 2;

		// Token: 0x04000118 RID: 280
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/adcolony/sdk/AdColonyZone", typeof(AdColonyZone));

		// Token: 0x04000119 RID: 281
		private static Delegate cb_isRewarded;

		// Token: 0x0400011A RID: 282
		private static Delegate cb_isValid;

		// Token: 0x0400011B RID: 283
		private static Delegate cb_getPlayFrequency;

		// Token: 0x0400011C RID: 284
		private static Delegate cb_getRemainingViewsUntilReward;

		// Token: 0x0400011D RID: 285
		private static Delegate cb_getRewardAmount;

		// Token: 0x0400011E RID: 286
		private static Delegate cb_getRewardName;

		// Token: 0x0400011F RID: 287
		private static Delegate cb_getViewsPerReward;

		// Token: 0x04000120 RID: 288
		private static Delegate cb_getZoneID;

		// Token: 0x04000121 RID: 289
		private static Delegate cb_getZoneType;
	}
}
