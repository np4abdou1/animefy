using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Com.Applovin.Mediation;
using Java.Interop;
using Java.Lang;

namespace Com.Applovin.Impl.Mediation
{
	// Token: 0x02000154 RID: 340
	[Register("com/applovin/impl/mediation/MaxAdWaterfallInfoImpl", DoNotGenerateAcw = true)]
	public class MaxAdWaterfallInfoImpl : Java.Lang.Object, IMaxAdWaterfallInfo, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x1700043F RID: 1087
		// (get) Token: 0x0600109D RID: 4253 RVA: 0x000300F4 File Offset: 0x0002E2F4
		internal static IntPtr class_ref
		{
			get
			{
				return MaxAdWaterfallInfoImpl._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000440 RID: 1088
		// (get) Token: 0x0600109E RID: 4254 RVA: 0x00030118 File Offset: 0x0002E318
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return MaxAdWaterfallInfoImpl._members;
			}
		}

		// Token: 0x17000441 RID: 1089
		// (get) Token: 0x0600109F RID: 4255 RVA: 0x00030120 File Offset: 0x0002E320
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return MaxAdWaterfallInfoImpl._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000442 RID: 1090
		// (get) Token: 0x060010A0 RID: 4256 RVA: 0x00030144 File Offset: 0x0002E344
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return MaxAdWaterfallInfoImpl._members.ManagedPeerType;
			}
		}

		// Token: 0x060010A1 RID: 4257 RVA: 0x000021F0 File Offset: 0x000003F0
		protected MaxAdWaterfallInfoImpl(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x060010A2 RID: 4258 RVA: 0x00030150 File Offset: 0x0002E350
		private static Delegate GetGetLatencyMillisHandler()
		{
			if (MaxAdWaterfallInfoImpl.cb_getLatencyMillis == null)
			{
				MaxAdWaterfallInfoImpl.cb_getLatencyMillis = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_J(MaxAdWaterfallInfoImpl.n_GetLatencyMillis));
			}
			return MaxAdWaterfallInfoImpl.cb_getLatencyMillis;
		}

		// Token: 0x060010A3 RID: 4259 RVA: 0x00030174 File Offset: 0x0002E374
		private static long n_GetLatencyMillis(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<MaxAdWaterfallInfoImpl>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).LatencyMillis;
		}

		// Token: 0x17000443 RID: 1091
		// (get) Token: 0x060010A4 RID: 4260 RVA: 0x00030183 File Offset: 0x0002E383
		public virtual long LatencyMillis
		{
			[Register("getLatencyMillis", "()J", "GetGetLatencyMillisHandler")]
			get
			{
				return MaxAdWaterfallInfoImpl._members.InstanceMethods.InvokeVirtualInt64Method("getLatencyMillis.()J", this, null);
			}
		}

		// Token: 0x060010A5 RID: 4261 RVA: 0x0003019C File Offset: 0x0002E39C
		private static Delegate GetGetLoadedAdHandler()
		{
			if (MaxAdWaterfallInfoImpl.cb_getLoadedAd == null)
			{
				MaxAdWaterfallInfoImpl.cb_getLoadedAd = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(MaxAdWaterfallInfoImpl.n_GetLoadedAd));
			}
			return MaxAdWaterfallInfoImpl.cb_getLoadedAd;
		}

		// Token: 0x060010A6 RID: 4262 RVA: 0x000301C0 File Offset: 0x0002E3C0
		private static IntPtr n_GetLoadedAd(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<MaxAdWaterfallInfoImpl>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).LoadedAd);
		}

		// Token: 0x17000444 RID: 1092
		// (get) Token: 0x060010A7 RID: 4263 RVA: 0x000301D4 File Offset: 0x0002E3D4
		public virtual IMaxAd LoadedAd
		{
			[Register("getLoadedAd", "()Lcom/applovin/mediation/MaxAd;", "GetGetLoadedAdHandler")]
			get
			{
				return Java.Lang.Object.GetObject<IMaxAd>(MaxAdWaterfallInfoImpl._members.InstanceMethods.InvokeVirtualObjectMethod("getLoadedAd.()Lcom/applovin/mediation/MaxAd;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x060010A8 RID: 4264 RVA: 0x00030206 File Offset: 0x0002E406
		private static Delegate GetGetNameHandler()
		{
			if (MaxAdWaterfallInfoImpl.cb_getName == null)
			{
				MaxAdWaterfallInfoImpl.cb_getName = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(MaxAdWaterfallInfoImpl.n_GetName));
			}
			return MaxAdWaterfallInfoImpl.cb_getName;
		}

		// Token: 0x060010A9 RID: 4265 RVA: 0x0003022A File Offset: 0x0002E42A
		private static IntPtr n_GetName(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<MaxAdWaterfallInfoImpl>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Name);
		}

		// Token: 0x17000445 RID: 1093
		// (get) Token: 0x060010AA RID: 4266 RVA: 0x00030240 File Offset: 0x0002E440
		public virtual string Name
		{
			[Register("getName", "()Ljava/lang/String;", "GetGetNameHandler")]
			get
			{
				return JNIEnv.GetString(MaxAdWaterfallInfoImpl._members.InstanceMethods.InvokeVirtualObjectMethod("getName.()Ljava/lang/String;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x060010AB RID: 4267 RVA: 0x00030272 File Offset: 0x0002E472
		private static Delegate GetGetNetworkResponsesHandler()
		{
			if (MaxAdWaterfallInfoImpl.cb_getNetworkResponses == null)
			{
				MaxAdWaterfallInfoImpl.cb_getNetworkResponses = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(MaxAdWaterfallInfoImpl.n_GetNetworkResponses));
			}
			return MaxAdWaterfallInfoImpl.cb_getNetworkResponses;
		}

		// Token: 0x060010AC RID: 4268 RVA: 0x00030296 File Offset: 0x0002E496
		private static IntPtr n_GetNetworkResponses(IntPtr jnienv, IntPtr native__this)
		{
			return JavaList<IMaxNetworkResponseInfo>.ToLocalJniHandle(Java.Lang.Object.GetObject<MaxAdWaterfallInfoImpl>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).NetworkResponses);
		}

		// Token: 0x17000446 RID: 1094
		// (get) Token: 0x060010AD RID: 4269 RVA: 0x000302AC File Offset: 0x0002E4AC
		public virtual IList<IMaxNetworkResponseInfo> NetworkResponses
		{
			[Register("getNetworkResponses", "()Ljava/util/List;", "GetGetNetworkResponsesHandler")]
			get
			{
				return JavaList<IMaxNetworkResponseInfo>.FromJniHandle(MaxAdWaterfallInfoImpl._members.InstanceMethods.InvokeVirtualObjectMethod("getNetworkResponses.()Ljava/util/List;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x060010AE RID: 4270 RVA: 0x000302DE File Offset: 0x0002E4DE
		private static Delegate GetGetTestNameHandler()
		{
			if (MaxAdWaterfallInfoImpl.cb_getTestName == null)
			{
				MaxAdWaterfallInfoImpl.cb_getTestName = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(MaxAdWaterfallInfoImpl.n_GetTestName));
			}
			return MaxAdWaterfallInfoImpl.cb_getTestName;
		}

		// Token: 0x060010AF RID: 4271 RVA: 0x00030302 File Offset: 0x0002E502
		private static IntPtr n_GetTestName(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<MaxAdWaterfallInfoImpl>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).TestName);
		}

		// Token: 0x17000447 RID: 1095
		// (get) Token: 0x060010B0 RID: 4272 RVA: 0x00030318 File Offset: 0x0002E518
		public virtual string TestName
		{
			[Register("getTestName", "()Ljava/lang/String;", "GetGetTestNameHandler")]
			get
			{
				return JNIEnv.GetString(MaxAdWaterfallInfoImpl._members.InstanceMethods.InvokeVirtualObjectMethod("getTestName.()Ljava/lang/String;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x0400057D RID: 1405
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/applovin/impl/mediation/MaxAdWaterfallInfoImpl", typeof(MaxAdWaterfallInfoImpl));

		// Token: 0x0400057E RID: 1406
		private static Delegate cb_getLatencyMillis;

		// Token: 0x0400057F RID: 1407
		private static Delegate cb_getLoadedAd;

		// Token: 0x04000580 RID: 1408
		private static Delegate cb_getName;

		// Token: 0x04000581 RID: 1409
		private static Delegate cb_getNetworkResponses;

		// Token: 0x04000582 RID: 1410
		private static Delegate cb_getTestName;
	}
}
