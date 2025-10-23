using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.OS;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Com.Applovin.Mediation
{
	// Token: 0x020000C1 RID: 193
	[Register("com/applovin/mediation/MaxNetworkResponseInfo", DoNotGenerateAcw = true)]
	internal class IMaxNetworkResponseInfoInvoker : Java.Lang.Object, IMaxNetworkResponseInfo, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000211 RID: 529
		// (get) Token: 0x06000691 RID: 1681 RVA: 0x00010BA8 File Offset: 0x0000EDA8
		private static IntPtr java_class_ref
		{
			get
			{
				return IMaxNetworkResponseInfoInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000212 RID: 530
		// (get) Token: 0x06000692 RID: 1682 RVA: 0x00010BCC File Offset: 0x0000EDCC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IMaxNetworkResponseInfoInvoker._members;
			}
		}

		// Token: 0x17000213 RID: 531
		// (get) Token: 0x06000693 RID: 1683 RVA: 0x00010BD3 File Offset: 0x0000EDD3
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x17000214 RID: 532
		// (get) Token: 0x06000694 RID: 1684 RVA: 0x00010BDB File Offset: 0x0000EDDB
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IMaxNetworkResponseInfoInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06000695 RID: 1685 RVA: 0x00010BE7 File Offset: 0x0000EDE7
		public static IMaxNetworkResponseInfo GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IMaxNetworkResponseInfo>(handle, transfer);
		}

		// Token: 0x06000696 RID: 1686 RVA: 0x00010BF0 File Offset: 0x0000EDF0
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IMaxNetworkResponseInfoInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'com.applovin.mediation.MaxNetworkResponseInfo'.");
			}
			return handle;
		}

		// Token: 0x06000697 RID: 1687 RVA: 0x00010C1B File Offset: 0x0000EE1B
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x06000698 RID: 1688 RVA: 0x00010C4C File Offset: 0x0000EE4C
		public IMaxNetworkResponseInfoInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IMaxNetworkResponseInfoInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x06000699 RID: 1689 RVA: 0x00010C84 File Offset: 0x0000EE84
		private static Delegate GetGetAdLoadStateHandler()
		{
			if (IMaxNetworkResponseInfoInvoker.cb_getAdLoadState == null)
			{
				IMaxNetworkResponseInfoInvoker.cb_getAdLoadState = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IMaxNetworkResponseInfoInvoker.n_GetAdLoadState));
			}
			return IMaxNetworkResponseInfoInvoker.cb_getAdLoadState;
		}

		// Token: 0x0600069A RID: 1690 RVA: 0x00010CA8 File Offset: 0x0000EEA8
		private static IntPtr n_GetAdLoadState(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IMaxNetworkResponseInfo>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).AdLoadState);
		}

		// Token: 0x17000215 RID: 533
		// (get) Token: 0x0600069B RID: 1691 RVA: 0x00010CBC File Offset: 0x0000EEBC
		public MaxNetworkResponseInfoAdLoadState AdLoadState
		{
			get
			{
				if (this.id_getAdLoadState == IntPtr.Zero)
				{
					this.id_getAdLoadState = JNIEnv.GetMethodID(this.class_ref, "getAdLoadState", "()Lcom/applovin/mediation/MaxNetworkResponseInfo$AdLoadState;");
				}
				return Java.Lang.Object.GetObject<MaxNetworkResponseInfoAdLoadState>(JNIEnv.CallObjectMethod(base.Handle, this.id_getAdLoadState), JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x0600069C RID: 1692 RVA: 0x00010D0D File Offset: 0x0000EF0D
		private static Delegate GetGetCredentialsHandler()
		{
			if (IMaxNetworkResponseInfoInvoker.cb_getCredentials == null)
			{
				IMaxNetworkResponseInfoInvoker.cb_getCredentials = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IMaxNetworkResponseInfoInvoker.n_GetCredentials));
			}
			return IMaxNetworkResponseInfoInvoker.cb_getCredentials;
		}

		// Token: 0x0600069D RID: 1693 RVA: 0x00010D31 File Offset: 0x0000EF31
		private static IntPtr n_GetCredentials(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IMaxNetworkResponseInfo>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Credentials);
		}

		// Token: 0x17000216 RID: 534
		// (get) Token: 0x0600069E RID: 1694 RVA: 0x00010D48 File Offset: 0x0000EF48
		public Bundle Credentials
		{
			get
			{
				if (this.id_getCredentials == IntPtr.Zero)
				{
					this.id_getCredentials = JNIEnv.GetMethodID(this.class_ref, "getCredentials", "()Landroid/os/Bundle;");
				}
				return Java.Lang.Object.GetObject<Bundle>(JNIEnv.CallObjectMethod(base.Handle, this.id_getCredentials), JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x0600069F RID: 1695 RVA: 0x00010D99 File Offset: 0x0000EF99
		private static Delegate GetGetErrorHandler()
		{
			if (IMaxNetworkResponseInfoInvoker.cb_getError == null)
			{
				IMaxNetworkResponseInfoInvoker.cb_getError = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IMaxNetworkResponseInfoInvoker.n_GetError));
			}
			return IMaxNetworkResponseInfoInvoker.cb_getError;
		}

		// Token: 0x060006A0 RID: 1696 RVA: 0x00010DBD File Offset: 0x0000EFBD
		private static IntPtr n_GetError(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IMaxNetworkResponseInfo>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Error);
		}

		// Token: 0x17000217 RID: 535
		// (get) Token: 0x060006A1 RID: 1697 RVA: 0x00010DD4 File Offset: 0x0000EFD4
		public IMaxError Error
		{
			get
			{
				if (this.id_getError == IntPtr.Zero)
				{
					this.id_getError = JNIEnv.GetMethodID(this.class_ref, "getError", "()Lcom/applovin/mediation/MaxError;");
				}
				return Java.Lang.Object.GetObject<IMaxError>(JNIEnv.CallObjectMethod(base.Handle, this.id_getError), JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x060006A2 RID: 1698 RVA: 0x00010E25 File Offset: 0x0000F025
		private static Delegate GetGetLatencyMillisHandler()
		{
			if (IMaxNetworkResponseInfoInvoker.cb_getLatencyMillis == null)
			{
				IMaxNetworkResponseInfoInvoker.cb_getLatencyMillis = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_J(IMaxNetworkResponseInfoInvoker.n_GetLatencyMillis));
			}
			return IMaxNetworkResponseInfoInvoker.cb_getLatencyMillis;
		}

		// Token: 0x060006A3 RID: 1699 RVA: 0x00010E49 File Offset: 0x0000F049
		private static long n_GetLatencyMillis(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IMaxNetworkResponseInfo>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).LatencyMillis;
		}

		// Token: 0x17000218 RID: 536
		// (get) Token: 0x060006A4 RID: 1700 RVA: 0x00010E58 File Offset: 0x0000F058
		public long LatencyMillis
		{
			get
			{
				if (this.id_getLatencyMillis == IntPtr.Zero)
				{
					this.id_getLatencyMillis = JNIEnv.GetMethodID(this.class_ref, "getLatencyMillis", "()J");
				}
				return JNIEnv.CallLongMethod(base.Handle, this.id_getLatencyMillis);
			}
		}

		// Token: 0x060006A5 RID: 1701 RVA: 0x00010E98 File Offset: 0x0000F098
		private static Delegate GetGetMediatedNetworkHandler()
		{
			if (IMaxNetworkResponseInfoInvoker.cb_getMediatedNetwork == null)
			{
				IMaxNetworkResponseInfoInvoker.cb_getMediatedNetwork = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IMaxNetworkResponseInfoInvoker.n_GetMediatedNetwork));
			}
			return IMaxNetworkResponseInfoInvoker.cb_getMediatedNetwork;
		}

		// Token: 0x060006A6 RID: 1702 RVA: 0x00010EBC File Offset: 0x0000F0BC
		private static IntPtr n_GetMediatedNetwork(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IMaxNetworkResponseInfo>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).MediatedNetwork);
		}

		// Token: 0x17000219 RID: 537
		// (get) Token: 0x060006A7 RID: 1703 RVA: 0x00010ED0 File Offset: 0x0000F0D0
		public IMaxMediatedNetworkInfo MediatedNetwork
		{
			get
			{
				if (this.id_getMediatedNetwork == IntPtr.Zero)
				{
					this.id_getMediatedNetwork = JNIEnv.GetMethodID(this.class_ref, "getMediatedNetwork", "()Lcom/applovin/mediation/MaxMediatedNetworkInfo;");
				}
				return Java.Lang.Object.GetObject<IMaxMediatedNetworkInfo>(JNIEnv.CallObjectMethod(base.Handle, this.id_getMediatedNetwork), JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x0400022F RID: 559
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/applovin/mediation/MaxNetworkResponseInfo", typeof(IMaxNetworkResponseInfoInvoker));

		// Token: 0x04000230 RID: 560
		private IntPtr class_ref;

		// Token: 0x04000231 RID: 561
		private static Delegate cb_getAdLoadState;

		// Token: 0x04000232 RID: 562
		private IntPtr id_getAdLoadState;

		// Token: 0x04000233 RID: 563
		private static Delegate cb_getCredentials;

		// Token: 0x04000234 RID: 564
		private IntPtr id_getCredentials;

		// Token: 0x04000235 RID: 565
		private static Delegate cb_getError;

		// Token: 0x04000236 RID: 566
		private IntPtr id_getError;

		// Token: 0x04000237 RID: 567
		private static Delegate cb_getLatencyMillis;

		// Token: 0x04000238 RID: 568
		private IntPtr id_getLatencyMillis;

		// Token: 0x04000239 RID: 569
		private static Delegate cb_getMediatedNetwork;

		// Token: 0x0400023A RID: 570
		private IntPtr id_getMediatedNetwork;
	}
}
