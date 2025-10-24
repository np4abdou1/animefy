using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.OS;
using Android.Runtime;
using Com.Applovin.Mediation;
using Java.Interop;
using Java.Lang;

namespace Com.Applovin.Impl.Mediation
{
	// Token: 0x02000157 RID: 343
	[Register("com/applovin/impl/mediation/MaxNetworkResponseInfoImpl", DoNotGenerateAcw = true)]
	public class MaxNetworkResponseInfoImpl : Java.Lang.Object, IMaxNetworkResponseInfo, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x1700045B RID: 1115
		// (get) Token: 0x060010EC RID: 4332 RVA: 0x00030D44 File Offset: 0x0002EF44
		internal static IntPtr class_ref
		{
			get
			{
				return MaxNetworkResponseInfoImpl._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700045C RID: 1116
		// (get) Token: 0x060010ED RID: 4333 RVA: 0x00030D68 File Offset: 0x0002EF68
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return MaxNetworkResponseInfoImpl._members;
			}
		}

		// Token: 0x1700045D RID: 1117
		// (get) Token: 0x060010EE RID: 4334 RVA: 0x00030D70 File Offset: 0x0002EF70
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return MaxNetworkResponseInfoImpl._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700045E RID: 1118
		// (get) Token: 0x060010EF RID: 4335 RVA: 0x00030D94 File Offset: 0x0002EF94
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return MaxNetworkResponseInfoImpl._members.ManagedPeerType;
			}
		}

		// Token: 0x060010F0 RID: 4336 RVA: 0x000021F0 File Offset: 0x000003F0
		protected MaxNetworkResponseInfoImpl(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x060010F1 RID: 4337 RVA: 0x00030DA0 File Offset: 0x0002EFA0
		[Register(".ctor", "(Lcom/applovin/mediation/MaxNetworkResponseInfo$AdLoadState;Landroid/os/Bundle;Lcom/applovin/mediation/MaxMediatedNetworkInfo;JLcom/applovin/mediation/MaxError;)V", "")]
		public unsafe MaxNetworkResponseInfoImpl(MaxNetworkResponseInfoAdLoadState p0, Bundle p1, IMaxMediatedNetworkInfo p2, long p3, IMaxError p4) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((p0 == null) ? IntPtr.Zero : p0.Handle);
				ptr[1] = new JniArgumentValue((p1 == null) ? IntPtr.Zero : p1.Handle);
				ptr[2] = new JniArgumentValue((p2 == null) ? IntPtr.Zero : ((Java.Lang.Object)p2).Handle);
				ptr[3] = new JniArgumentValue(p3);
				ptr[4] = new JniArgumentValue((p4 == null) ? IntPtr.Zero : ((Java.Lang.Object)p4).Handle);
				base.SetHandle(MaxNetworkResponseInfoImpl._members.InstanceMethods.StartCreateInstance("(Lcom/applovin/mediation/MaxNetworkResponseInfo$AdLoadState;Landroid/os/Bundle;Lcom/applovin/mediation/MaxMediatedNetworkInfo;JLcom/applovin/mediation/MaxError;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				MaxNetworkResponseInfoImpl._members.InstanceMethods.FinishCreateInstance("(Lcom/applovin/mediation/MaxNetworkResponseInfo$AdLoadState;Landroid/os/Bundle;Lcom/applovin/mediation/MaxMediatedNetworkInfo;JLcom/applovin/mediation/MaxError;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(p0);
				GC.KeepAlive(p1);
				GC.KeepAlive(p2);
				GC.KeepAlive(p4);
			}
		}

		// Token: 0x060010F2 RID: 4338 RVA: 0x00030EF0 File Offset: 0x0002F0F0
		private static Delegate GetGetAdLoadStateHandler()
		{
			if (MaxNetworkResponseInfoImpl.cb_getAdLoadState == null)
			{
				MaxNetworkResponseInfoImpl.cb_getAdLoadState = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(MaxNetworkResponseInfoImpl.n_GetAdLoadState));
			}
			return MaxNetworkResponseInfoImpl.cb_getAdLoadState;
		}

		// Token: 0x060010F3 RID: 4339 RVA: 0x00030F14 File Offset: 0x0002F114
		private static IntPtr n_GetAdLoadState(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<MaxNetworkResponseInfoImpl>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).AdLoadState);
		}

		// Token: 0x1700045F RID: 1119
		// (get) Token: 0x060010F4 RID: 4340 RVA: 0x00030F28 File Offset: 0x0002F128
		public virtual MaxNetworkResponseInfoAdLoadState AdLoadState
		{
			[Register("getAdLoadState", "()Lcom/applovin/mediation/MaxNetworkResponseInfo$AdLoadState;", "GetGetAdLoadStateHandler")]
			get
			{
				return Java.Lang.Object.GetObject<MaxNetworkResponseInfoAdLoadState>(MaxNetworkResponseInfoImpl._members.InstanceMethods.InvokeVirtualObjectMethod("getAdLoadState.()Lcom/applovin/mediation/MaxNetworkResponseInfo$AdLoadState;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x060010F5 RID: 4341 RVA: 0x00030F5A File Offset: 0x0002F15A
		private static Delegate GetGetCredentialsHandler()
		{
			if (MaxNetworkResponseInfoImpl.cb_getCredentials == null)
			{
				MaxNetworkResponseInfoImpl.cb_getCredentials = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(MaxNetworkResponseInfoImpl.n_GetCredentials));
			}
			return MaxNetworkResponseInfoImpl.cb_getCredentials;
		}

		// Token: 0x060010F6 RID: 4342 RVA: 0x00030F7E File Offset: 0x0002F17E
		private static IntPtr n_GetCredentials(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<MaxNetworkResponseInfoImpl>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Credentials);
		}

		// Token: 0x17000460 RID: 1120
		// (get) Token: 0x060010F7 RID: 4343 RVA: 0x00030F94 File Offset: 0x0002F194
		public virtual Bundle Credentials
		{
			[Register("getCredentials", "()Landroid/os/Bundle;", "GetGetCredentialsHandler")]
			get
			{
				return Java.Lang.Object.GetObject<Bundle>(MaxNetworkResponseInfoImpl._members.InstanceMethods.InvokeVirtualObjectMethod("getCredentials.()Landroid/os/Bundle;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x060010F8 RID: 4344 RVA: 0x00030FC6 File Offset: 0x0002F1C6
		private static Delegate GetGetErrorHandler()
		{
			if (MaxNetworkResponseInfoImpl.cb_getError == null)
			{
				MaxNetworkResponseInfoImpl.cb_getError = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(MaxNetworkResponseInfoImpl.n_GetError));
			}
			return MaxNetworkResponseInfoImpl.cb_getError;
		}

		// Token: 0x060010F9 RID: 4345 RVA: 0x00030FEA File Offset: 0x0002F1EA
		private static IntPtr n_GetError(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<MaxNetworkResponseInfoImpl>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Error);
		}

		// Token: 0x17000461 RID: 1121
		// (get) Token: 0x060010FA RID: 4346 RVA: 0x00031000 File Offset: 0x0002F200
		public virtual IMaxError Error
		{
			[Register("getError", "()Lcom/applovin/mediation/MaxError;", "GetGetErrorHandler")]
			get
			{
				return Java.Lang.Object.GetObject<IMaxError>(MaxNetworkResponseInfoImpl._members.InstanceMethods.InvokeVirtualObjectMethod("getError.()Lcom/applovin/mediation/MaxError;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x060010FB RID: 4347 RVA: 0x00031032 File Offset: 0x0002F232
		private static Delegate GetGetLatencyMillisHandler()
		{
			if (MaxNetworkResponseInfoImpl.cb_getLatencyMillis == null)
			{
				MaxNetworkResponseInfoImpl.cb_getLatencyMillis = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_J(MaxNetworkResponseInfoImpl.n_GetLatencyMillis));
			}
			return MaxNetworkResponseInfoImpl.cb_getLatencyMillis;
		}

		// Token: 0x060010FC RID: 4348 RVA: 0x00031056 File Offset: 0x0002F256
		private static long n_GetLatencyMillis(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<MaxNetworkResponseInfoImpl>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).LatencyMillis;
		}

		// Token: 0x17000462 RID: 1122
		// (get) Token: 0x060010FD RID: 4349 RVA: 0x00031065 File Offset: 0x0002F265
		public virtual long LatencyMillis
		{
			[Register("getLatencyMillis", "()J", "GetGetLatencyMillisHandler")]
			get
			{
				return MaxNetworkResponseInfoImpl._members.InstanceMethods.InvokeVirtualInt64Method("getLatencyMillis.()J", this, null);
			}
		}

		// Token: 0x060010FE RID: 4350 RVA: 0x0003107E File Offset: 0x0002F27E
		private static Delegate GetGetMediatedNetworkHandler()
		{
			if (MaxNetworkResponseInfoImpl.cb_getMediatedNetwork == null)
			{
				MaxNetworkResponseInfoImpl.cb_getMediatedNetwork = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(MaxNetworkResponseInfoImpl.n_GetMediatedNetwork));
			}
			return MaxNetworkResponseInfoImpl.cb_getMediatedNetwork;
		}

		// Token: 0x060010FF RID: 4351 RVA: 0x000310A2 File Offset: 0x0002F2A2
		private static IntPtr n_GetMediatedNetwork(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<MaxNetworkResponseInfoImpl>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).MediatedNetwork);
		}

		// Token: 0x17000463 RID: 1123
		// (get) Token: 0x06001100 RID: 4352 RVA: 0x000310B8 File Offset: 0x0002F2B8
		public virtual IMaxMediatedNetworkInfo MediatedNetwork
		{
			[Register("getMediatedNetwork", "()Lcom/applovin/mediation/MaxMediatedNetworkInfo;", "GetGetMediatedNetworkHandler")]
			get
			{
				return Java.Lang.Object.GetObject<IMaxMediatedNetworkInfo>(MaxNetworkResponseInfoImpl._members.InstanceMethods.InvokeVirtualObjectMethod("getMediatedNetwork.()Lcom/applovin/mediation/MaxMediatedNetworkInfo;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x04000593 RID: 1427
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/applovin/impl/mediation/MaxNetworkResponseInfoImpl", typeof(MaxNetworkResponseInfoImpl));

		// Token: 0x04000594 RID: 1428
		private static Delegate cb_getAdLoadState;

		// Token: 0x04000595 RID: 1429
		private static Delegate cb_getCredentials;

		// Token: 0x04000596 RID: 1430
		private static Delegate cb_getError;

		// Token: 0x04000597 RID: 1431
		private static Delegate cb_getLatencyMillis;

		// Token: 0x04000598 RID: 1432
		private static Delegate cb_getMediatedNetwork;
	}
}
