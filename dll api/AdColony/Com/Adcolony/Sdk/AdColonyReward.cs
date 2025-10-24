using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Com.Adcolony.Sdk
{
	// Token: 0x02000047 RID: 71
	[Register("com/adcolony/sdk/AdColonyReward", DoNotGenerateAcw = true)]
	public class AdColonyReward : Java.Lang.Object
	{
		// Token: 0x170000F3 RID: 243
		// (get) Token: 0x0600037A RID: 890 RVA: 0x0000B24C File Offset: 0x0000944C
		internal static IntPtr class_ref
		{
			get
			{
				return AdColonyReward._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170000F4 RID: 244
		// (get) Token: 0x0600037B RID: 891 RVA: 0x0000B270 File Offset: 0x00009470
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return AdColonyReward._members;
			}
		}

		// Token: 0x170000F5 RID: 245
		// (get) Token: 0x0600037C RID: 892 RVA: 0x0000B278 File Offset: 0x00009478
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return AdColonyReward._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170000F6 RID: 246
		// (get) Token: 0x0600037D RID: 893 RVA: 0x0000B29C File Offset: 0x0000949C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return AdColonyReward._members.ManagedPeerType;
			}
		}

		// Token: 0x0600037E RID: 894 RVA: 0x00002128 File Offset: 0x00000328
		protected AdColonyReward(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x0600037F RID: 895 RVA: 0x0000B2A8 File Offset: 0x000094A8
		private static Delegate GetGetRewardAmountHandler()
		{
			if (AdColonyReward.cb_getRewardAmount == null)
			{
				AdColonyReward.cb_getRewardAmount = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(AdColonyReward.n_GetRewardAmount));
			}
			return AdColonyReward.cb_getRewardAmount;
		}

		// Token: 0x06000380 RID: 896 RVA: 0x0000B2CC File Offset: 0x000094CC
		private static int n_GetRewardAmount(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<AdColonyReward>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).RewardAmount;
		}

		// Token: 0x170000F7 RID: 247
		// (get) Token: 0x06000381 RID: 897 RVA: 0x0000B2DB File Offset: 0x000094DB
		public virtual int RewardAmount
		{
			[Register("getRewardAmount", "()I", "GetGetRewardAmountHandler")]
			get
			{
				return AdColonyReward._members.InstanceMethods.InvokeVirtualInt32Method("getRewardAmount.()I", this, null);
			}
		}

		// Token: 0x06000382 RID: 898 RVA: 0x0000B2F4 File Offset: 0x000094F4
		private static Delegate GetGetRewardNameHandler()
		{
			if (AdColonyReward.cb_getRewardName == null)
			{
				AdColonyReward.cb_getRewardName = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(AdColonyReward.n_GetRewardName));
			}
			return AdColonyReward.cb_getRewardName;
		}

		// Token: 0x06000383 RID: 899 RVA: 0x0000B318 File Offset: 0x00009518
		private static IntPtr n_GetRewardName(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<AdColonyReward>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).RewardName);
		}

		// Token: 0x170000F8 RID: 248
		// (get) Token: 0x06000384 RID: 900 RVA: 0x0000B32C File Offset: 0x0000952C
		public virtual string RewardName
		{
			[Register("getRewardName", "()Ljava/lang/String;", "GetGetRewardNameHandler")]
			get
			{
				return JNIEnv.GetString(AdColonyReward._members.InstanceMethods.InvokeVirtualObjectMethod("getRewardName.()Ljava/lang/String;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06000385 RID: 901 RVA: 0x0000B35E File Offset: 0x0000955E
		private static Delegate GetGetZoneIDHandler()
		{
			if (AdColonyReward.cb_getZoneID == null)
			{
				AdColonyReward.cb_getZoneID = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(AdColonyReward.n_GetZoneID));
			}
			return AdColonyReward.cb_getZoneID;
		}

		// Token: 0x06000386 RID: 902 RVA: 0x0000B382 File Offset: 0x00009582
		private static IntPtr n_GetZoneID(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<AdColonyReward>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ZoneID);
		}

		// Token: 0x170000F9 RID: 249
		// (get) Token: 0x06000387 RID: 903 RVA: 0x0000B398 File Offset: 0x00009598
		public virtual string ZoneID
		{
			[Register("getZoneID", "()Ljava/lang/String;", "GetGetZoneIDHandler")]
			get
			{
				return JNIEnv.GetString(AdColonyReward._members.InstanceMethods.InvokeVirtualObjectMethod("getZoneID.()Ljava/lang/String;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06000388 RID: 904 RVA: 0x0000B3CA File Offset: 0x000095CA
		private static Delegate GetSuccessHandler()
		{
			if (AdColonyReward.cb_success == null)
			{
				AdColonyReward.cb_success = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(AdColonyReward.n_Success));
			}
			return AdColonyReward.cb_success;
		}

		// Token: 0x06000389 RID: 905 RVA: 0x0000B3EE File Offset: 0x000095EE
		private static bool n_Success(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<AdColonyReward>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Success();
		}

		// Token: 0x0600038A RID: 906 RVA: 0x0000B3FD File Offset: 0x000095FD
		[Register("success", "()Z", "GetSuccessHandler")]
		public virtual bool Success()
		{
			return AdColonyReward._members.InstanceMethods.InvokeVirtualBooleanMethod("success.()Z", this, null);
		}

		// Token: 0x040000EB RID: 235
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/adcolony/sdk/AdColonyReward", typeof(AdColonyReward));

		// Token: 0x040000EC RID: 236
		private static Delegate cb_getRewardAmount;

		// Token: 0x040000ED RID: 237
		private static Delegate cb_getRewardName;

		// Token: 0x040000EE RID: 238
		private static Delegate cb_getZoneID;

		// Token: 0x040000EF RID: 239
		private static Delegate cb_success;
	}
}
