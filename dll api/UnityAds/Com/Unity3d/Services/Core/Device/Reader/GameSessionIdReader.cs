using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Com.Unity3d.Services.Core.Device.Reader
{
	// Token: 0x02000136 RID: 310
	[Register("com/unity3d/services/core/device/reader/GameSessionIdReader", DoNotGenerateAcw = true)]
	public class GameSessionIdReader : Java.Lang.Object, IGameSessionIdReader, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000466 RID: 1126
		// (get) Token: 0x06000C68 RID: 3176 RVA: 0x00023280 File Offset: 0x00021480
		internal static IntPtr class_ref
		{
			get
			{
				return GameSessionIdReader._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000467 RID: 1127
		// (get) Token: 0x06000C69 RID: 3177 RVA: 0x000232A4 File Offset: 0x000214A4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return GameSessionIdReader._members;
			}
		}

		// Token: 0x17000468 RID: 1128
		// (get) Token: 0x06000C6A RID: 3178 RVA: 0x000232AC File Offset: 0x000214AC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return GameSessionIdReader._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000469 RID: 1129
		// (get) Token: 0x06000C6B RID: 3179 RVA: 0x000232D0 File Offset: 0x000214D0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return GameSessionIdReader._members.ManagedPeerType;
			}
		}

		// Token: 0x06000C6C RID: 3180 RVA: 0x000021E8 File Offset: 0x000003E8
		protected GameSessionIdReader(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000C6D RID: 3181 RVA: 0x000232DC File Offset: 0x000214DC
		private static Delegate GetGetGameSessionIdHandler()
		{
			if (GameSessionIdReader.cb_getGameSessionId == null)
			{
				GameSessionIdReader.cb_getGameSessionId = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(GameSessionIdReader.n_GetGameSessionId));
			}
			return GameSessionIdReader.cb_getGameSessionId;
		}

		// Token: 0x06000C6E RID: 3182 RVA: 0x00023300 File Offset: 0x00021500
		private static IntPtr n_GetGameSessionId(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<GameSessionIdReader>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).GameSessionId);
		}

		// Token: 0x1700046A RID: 1130
		// (get) Token: 0x06000C6F RID: 3183 RVA: 0x00023314 File Offset: 0x00021514
		public virtual Long GameSessionId
		{
			[Register("getGameSessionId", "()Ljava/lang/Long;", "GetGetGameSessionIdHandler")]
			get
			{
				return Java.Lang.Object.GetObject<Long>(GameSessionIdReader._members.InstanceMethods.InvokeVirtualObjectMethod("getGameSessionId.()Ljava/lang/Long;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06000C70 RID: 3184 RVA: 0x00023346 File Offset: 0x00021546
		private static Delegate GetGetGameSessionIdAndStoreHandler()
		{
			if (GameSessionIdReader.cb_getGameSessionIdAndStore == null)
			{
				GameSessionIdReader.cb_getGameSessionIdAndStore = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(GameSessionIdReader.n_GetGameSessionIdAndStore));
			}
			return GameSessionIdReader.cb_getGameSessionIdAndStore;
		}

		// Token: 0x06000C71 RID: 3185 RVA: 0x0002336A File Offset: 0x0002156A
		private static IntPtr n_GetGameSessionIdAndStore(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<GameSessionIdReader>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).GameSessionIdAndStore);
		}

		// Token: 0x1700046B RID: 1131
		// (get) Token: 0x06000C72 RID: 3186 RVA: 0x00023380 File Offset: 0x00021580
		public virtual Long GameSessionIdAndStore
		{
			[Register("getGameSessionIdAndStore", "()Ljava/lang/Long;", "GetGetGameSessionIdAndStoreHandler")]
			get
			{
				return Java.Lang.Object.GetObject<Long>(GameSessionIdReader._members.InstanceMethods.InvokeVirtualObjectMethod("getGameSessionIdAndStore.()Ljava/lang/Long;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x1700046C RID: 1132
		// (get) Token: 0x06000C73 RID: 3187 RVA: 0x000233B4 File Offset: 0x000215B4
		public static GameSessionIdReader Instance
		{
			[Register("getInstance", "()Lcom/unity3d/services/core/device/reader/GameSessionIdReader;", "")]
			get
			{
				return Java.Lang.Object.GetObject<GameSessionIdReader>(GameSessionIdReader._members.StaticMethods.InvokeObjectMethod("getInstance.()Lcom/unity3d/services/core/device/reader/GameSessionIdReader;", null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x040002CD RID: 717
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/services/core/device/reader/GameSessionIdReader", typeof(GameSessionIdReader));

		// Token: 0x040002CE RID: 718
		private static Delegate cb_getGameSessionId;

		// Token: 0x040002CF RID: 719
		private static Delegate cb_getGameSessionIdAndStore;
	}
}
