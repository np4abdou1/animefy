using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Com.Applovin.Mediation
{
	// Token: 0x020000B6 RID: 182
	[Register("com/applovin/mediation/MaxAdWaterfallInfo", DoNotGenerateAcw = true)]
	internal class IMaxAdWaterfallInfoInvoker : Java.Lang.Object, IMaxAdWaterfallInfo, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x170001E0 RID: 480
		// (get) Token: 0x0600062C RID: 1580 RVA: 0x0000FF28 File Offset: 0x0000E128
		private static IntPtr java_class_ref
		{
			get
			{
				return IMaxAdWaterfallInfoInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170001E1 RID: 481
		// (get) Token: 0x0600062D RID: 1581 RVA: 0x0000FF4C File Offset: 0x0000E14C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IMaxAdWaterfallInfoInvoker._members;
			}
		}

		// Token: 0x170001E2 RID: 482
		// (get) Token: 0x0600062E RID: 1582 RVA: 0x0000FF53 File Offset: 0x0000E153
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x170001E3 RID: 483
		// (get) Token: 0x0600062F RID: 1583 RVA: 0x0000FF5B File Offset: 0x0000E15B
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IMaxAdWaterfallInfoInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06000630 RID: 1584 RVA: 0x0000FF67 File Offset: 0x0000E167
		public static IMaxAdWaterfallInfo GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IMaxAdWaterfallInfo>(handle, transfer);
		}

		// Token: 0x06000631 RID: 1585 RVA: 0x0000FF70 File Offset: 0x0000E170
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IMaxAdWaterfallInfoInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'com.applovin.mediation.MaxAdWaterfallInfo'.");
			}
			return handle;
		}

		// Token: 0x06000632 RID: 1586 RVA: 0x0000FF9B File Offset: 0x0000E19B
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x06000633 RID: 1587 RVA: 0x0000FFCC File Offset: 0x0000E1CC
		public IMaxAdWaterfallInfoInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IMaxAdWaterfallInfoInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x06000634 RID: 1588 RVA: 0x00010004 File Offset: 0x0000E204
		private static Delegate GetGetLatencyMillisHandler()
		{
			if (IMaxAdWaterfallInfoInvoker.cb_getLatencyMillis == null)
			{
				IMaxAdWaterfallInfoInvoker.cb_getLatencyMillis = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_J(IMaxAdWaterfallInfoInvoker.n_GetLatencyMillis));
			}
			return IMaxAdWaterfallInfoInvoker.cb_getLatencyMillis;
		}

		// Token: 0x06000635 RID: 1589 RVA: 0x00010028 File Offset: 0x0000E228
		private static long n_GetLatencyMillis(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IMaxAdWaterfallInfo>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).LatencyMillis;
		}

		// Token: 0x170001E4 RID: 484
		// (get) Token: 0x06000636 RID: 1590 RVA: 0x00010037 File Offset: 0x0000E237
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

		// Token: 0x06000637 RID: 1591 RVA: 0x00010077 File Offset: 0x0000E277
		private static Delegate GetGetLoadedAdHandler()
		{
			if (IMaxAdWaterfallInfoInvoker.cb_getLoadedAd == null)
			{
				IMaxAdWaterfallInfoInvoker.cb_getLoadedAd = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IMaxAdWaterfallInfoInvoker.n_GetLoadedAd));
			}
			return IMaxAdWaterfallInfoInvoker.cb_getLoadedAd;
		}

		// Token: 0x06000638 RID: 1592 RVA: 0x0001009B File Offset: 0x0000E29B
		private static IntPtr n_GetLoadedAd(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IMaxAdWaterfallInfo>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).LoadedAd);
		}

		// Token: 0x170001E5 RID: 485
		// (get) Token: 0x06000639 RID: 1593 RVA: 0x000100B0 File Offset: 0x0000E2B0
		public IMaxAd LoadedAd
		{
			get
			{
				if (this.id_getLoadedAd == IntPtr.Zero)
				{
					this.id_getLoadedAd = JNIEnv.GetMethodID(this.class_ref, "getLoadedAd", "()Lcom/applovin/mediation/MaxAd;");
				}
				return Java.Lang.Object.GetObject<IMaxAd>(JNIEnv.CallObjectMethod(base.Handle, this.id_getLoadedAd), JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x0600063A RID: 1594 RVA: 0x00010101 File Offset: 0x0000E301
		private static Delegate GetGetNameHandler()
		{
			if (IMaxAdWaterfallInfoInvoker.cb_getName == null)
			{
				IMaxAdWaterfallInfoInvoker.cb_getName = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IMaxAdWaterfallInfoInvoker.n_GetName));
			}
			return IMaxAdWaterfallInfoInvoker.cb_getName;
		}

		// Token: 0x0600063B RID: 1595 RVA: 0x00010125 File Offset: 0x0000E325
		private static IntPtr n_GetName(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<IMaxAdWaterfallInfo>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Name);
		}

		// Token: 0x170001E6 RID: 486
		// (get) Token: 0x0600063C RID: 1596 RVA: 0x0001013C File Offset: 0x0000E33C
		public string Name
		{
			get
			{
				if (this.id_getName == IntPtr.Zero)
				{
					this.id_getName = JNIEnv.GetMethodID(this.class_ref, "getName", "()Ljava/lang/String;");
				}
				return JNIEnv.GetString(JNIEnv.CallObjectMethod(base.Handle, this.id_getName), JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x0600063D RID: 1597 RVA: 0x0001018D File Offset: 0x0000E38D
		private static Delegate GetGetNetworkResponsesHandler()
		{
			if (IMaxAdWaterfallInfoInvoker.cb_getNetworkResponses == null)
			{
				IMaxAdWaterfallInfoInvoker.cb_getNetworkResponses = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IMaxAdWaterfallInfoInvoker.n_GetNetworkResponses));
			}
			return IMaxAdWaterfallInfoInvoker.cb_getNetworkResponses;
		}

		// Token: 0x0600063E RID: 1598 RVA: 0x000101B1 File Offset: 0x0000E3B1
		private static IntPtr n_GetNetworkResponses(IntPtr jnienv, IntPtr native__this)
		{
			return JavaList<IMaxNetworkResponseInfo>.ToLocalJniHandle(Java.Lang.Object.GetObject<IMaxAdWaterfallInfo>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).NetworkResponses);
		}

		// Token: 0x170001E7 RID: 487
		// (get) Token: 0x0600063F RID: 1599 RVA: 0x000101C8 File Offset: 0x0000E3C8
		public IList<IMaxNetworkResponseInfo> NetworkResponses
		{
			get
			{
				if (this.id_getNetworkResponses == IntPtr.Zero)
				{
					this.id_getNetworkResponses = JNIEnv.GetMethodID(this.class_ref, "getNetworkResponses", "()Ljava/util/List;");
				}
				return JavaList<IMaxNetworkResponseInfo>.FromJniHandle(JNIEnv.CallObjectMethod(base.Handle, this.id_getNetworkResponses), JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06000640 RID: 1600 RVA: 0x00010219 File Offset: 0x0000E419
		private static Delegate GetGetTestNameHandler()
		{
			if (IMaxAdWaterfallInfoInvoker.cb_getTestName == null)
			{
				IMaxAdWaterfallInfoInvoker.cb_getTestName = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IMaxAdWaterfallInfoInvoker.n_GetTestName));
			}
			return IMaxAdWaterfallInfoInvoker.cb_getTestName;
		}

		// Token: 0x06000641 RID: 1601 RVA: 0x0001023D File Offset: 0x0000E43D
		private static IntPtr n_GetTestName(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<IMaxAdWaterfallInfo>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).TestName);
		}

		// Token: 0x170001E8 RID: 488
		// (get) Token: 0x06000642 RID: 1602 RVA: 0x00010254 File Offset: 0x0000E454
		public string TestName
		{
			get
			{
				if (this.id_getTestName == IntPtr.Zero)
				{
					this.id_getTestName = JNIEnv.GetMethodID(this.class_ref, "getTestName", "()Ljava/lang/String;");
				}
				return JNIEnv.GetString(JNIEnv.CallObjectMethod(base.Handle, this.id_getTestName), JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x04000202 RID: 514
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/applovin/mediation/MaxAdWaterfallInfo", typeof(IMaxAdWaterfallInfoInvoker));

		// Token: 0x04000203 RID: 515
		private IntPtr class_ref;

		// Token: 0x04000204 RID: 516
		private static Delegate cb_getLatencyMillis;

		// Token: 0x04000205 RID: 517
		private IntPtr id_getLatencyMillis;

		// Token: 0x04000206 RID: 518
		private static Delegate cb_getLoadedAd;

		// Token: 0x04000207 RID: 519
		private IntPtr id_getLoadedAd;

		// Token: 0x04000208 RID: 520
		private static Delegate cb_getName;

		// Token: 0x04000209 RID: 521
		private IntPtr id_getName;

		// Token: 0x0400020A RID: 522
		private static Delegate cb_getNetworkResponses;

		// Token: 0x0400020B RID: 523
		private IntPtr id_getNetworkResponses;

		// Token: 0x0400020C RID: 524
		private static Delegate cb_getTestName;

		// Token: 0x0400020D RID: 525
		private IntPtr id_getTestName;
	}
}
