using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Android.Gms.Ads.Rewarded
{
	// Token: 0x02000031 RID: 49
	[Register("com/google/android/gms/ads/rewarded/ServerSideVerificationOptions", DoNotGenerateAcw = true)]
	public class ServerSideVerificationOptions : Java.Lang.Object
	{
		// Token: 0x17000098 RID: 152
		// (get) Token: 0x060001EB RID: 491 RVA: 0x000066EC File Offset: 0x000048EC
		internal static IntPtr class_ref
		{
			get
			{
				return ServerSideVerificationOptions._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000099 RID: 153
		// (get) Token: 0x060001EC RID: 492 RVA: 0x00006710 File Offset: 0x00004910
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return ServerSideVerificationOptions._members;
			}
		}

		// Token: 0x1700009A RID: 154
		// (get) Token: 0x060001ED RID: 493 RVA: 0x00006718 File Offset: 0x00004918
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return ServerSideVerificationOptions._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700009B RID: 155
		// (get) Token: 0x060001EE RID: 494 RVA: 0x0000673C File Offset: 0x0000493C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return ServerSideVerificationOptions._members.ManagedPeerType;
			}
		}

		// Token: 0x060001EF RID: 495 RVA: 0x000020AC File Offset: 0x000002AC
		protected ServerSideVerificationOptions(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x060001F0 RID: 496 RVA: 0x00006748 File Offset: 0x00004948
		private static Delegate GetGetCustomDataHandler()
		{
			if (ServerSideVerificationOptions.cb_getCustomData == null)
			{
				ServerSideVerificationOptions.cb_getCustomData = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(ServerSideVerificationOptions.n_GetCustomData));
			}
			return ServerSideVerificationOptions.cb_getCustomData;
		}

		// Token: 0x060001F1 RID: 497 RVA: 0x0000676C File Offset: 0x0000496C
		private static IntPtr n_GetCustomData(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<ServerSideVerificationOptions>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).CustomData);
		}

		// Token: 0x1700009C RID: 156
		// (get) Token: 0x060001F2 RID: 498 RVA: 0x00006780 File Offset: 0x00004980
		public virtual string CustomData
		{
			[Register("getCustomData", "()Ljava/lang/String;", "GetGetCustomDataHandler")]
			get
			{
				return JNIEnv.GetString(ServerSideVerificationOptions._members.InstanceMethods.InvokeVirtualObjectMethod("getCustomData.()Ljava/lang/String;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x060001F3 RID: 499 RVA: 0x000067B2 File Offset: 0x000049B2
		private static Delegate GetGetUserIdHandler()
		{
			if (ServerSideVerificationOptions.cb_getUserId == null)
			{
				ServerSideVerificationOptions.cb_getUserId = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(ServerSideVerificationOptions.n_GetUserId));
			}
			return ServerSideVerificationOptions.cb_getUserId;
		}

		// Token: 0x060001F4 RID: 500 RVA: 0x000067D6 File Offset: 0x000049D6
		private static IntPtr n_GetUserId(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<ServerSideVerificationOptions>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).UserId);
		}

		// Token: 0x1700009D RID: 157
		// (get) Token: 0x060001F5 RID: 501 RVA: 0x000067EC File Offset: 0x000049EC
		public virtual string UserId
		{
			[Register("getUserId", "()Ljava/lang/String;", "GetGetUserIdHandler")]
			get
			{
				return JNIEnv.GetString(ServerSideVerificationOptions._members.InstanceMethods.InvokeVirtualObjectMethod("getUserId.()Ljava/lang/String;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x04000073 RID: 115
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/google/android/gms/ads/rewarded/ServerSideVerificationOptions", typeof(ServerSideVerificationOptions));

		// Token: 0x04000074 RID: 116
		private static Delegate cb_getCustomData;

		// Token: 0x04000075 RID: 117
		private static Delegate cb_getUserId;
	}
}
