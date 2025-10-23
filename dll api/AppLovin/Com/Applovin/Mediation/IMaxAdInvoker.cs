using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Com.Applovin.Mediation.NativeAds;
using Com.Applovin.Sdk;
using Java.Interop;
using Java.Lang;

namespace Com.Applovin.Mediation
{
	// Token: 0x020000A1 RID: 161
	[Register("com/applovin/mediation/MaxAd", DoNotGenerateAcw = true)]
	internal class IMaxAdInvoker : Java.Lang.Object, IMaxAd, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x170001AE RID: 430
		// (get) Token: 0x0600056F RID: 1391 RVA: 0x0000E100 File Offset: 0x0000C300
		private static IntPtr java_class_ref
		{
			get
			{
				return IMaxAdInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170001AF RID: 431
		// (get) Token: 0x06000570 RID: 1392 RVA: 0x0000E124 File Offset: 0x0000C324
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IMaxAdInvoker._members;
			}
		}

		// Token: 0x170001B0 RID: 432
		// (get) Token: 0x06000571 RID: 1393 RVA: 0x0000E12B File Offset: 0x0000C32B
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x170001B1 RID: 433
		// (get) Token: 0x06000572 RID: 1394 RVA: 0x0000E133 File Offset: 0x0000C333
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IMaxAdInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06000573 RID: 1395 RVA: 0x0000E13F File Offset: 0x0000C33F
		public static IMaxAd GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IMaxAd>(handle, transfer);
		}

		// Token: 0x06000574 RID: 1396 RVA: 0x0000E148 File Offset: 0x0000C348
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IMaxAdInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'com.applovin.mediation.MaxAd'.");
			}
			return handle;
		}

		// Token: 0x06000575 RID: 1397 RVA: 0x0000E173 File Offset: 0x0000C373
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x06000576 RID: 1398 RVA: 0x0000E1A4 File Offset: 0x0000C3A4
		public IMaxAdInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IMaxAdInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x06000577 RID: 1399 RVA: 0x0000E1DC File Offset: 0x0000C3DC
		private static Delegate GetGetAdReviewCreativeIdHandler()
		{
			if (IMaxAdInvoker.cb_getAdReviewCreativeId == null)
			{
				IMaxAdInvoker.cb_getAdReviewCreativeId = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IMaxAdInvoker.n_GetAdReviewCreativeId));
			}
			return IMaxAdInvoker.cb_getAdReviewCreativeId;
		}

		// Token: 0x06000578 RID: 1400 RVA: 0x0000E200 File Offset: 0x0000C400
		private static IntPtr n_GetAdReviewCreativeId(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<IMaxAd>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).AdReviewCreativeId);
		}

		// Token: 0x170001B2 RID: 434
		// (get) Token: 0x06000579 RID: 1401 RVA: 0x0000E214 File Offset: 0x0000C414
		public string AdReviewCreativeId
		{
			get
			{
				if (this.id_getAdReviewCreativeId == IntPtr.Zero)
				{
					this.id_getAdReviewCreativeId = JNIEnv.GetMethodID(this.class_ref, "getAdReviewCreativeId", "()Ljava/lang/String;");
				}
				return JNIEnv.GetString(JNIEnv.CallObjectMethod(base.Handle, this.id_getAdReviewCreativeId), JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x0600057A RID: 1402 RVA: 0x0000E265 File Offset: 0x0000C465
		private static Delegate GetGetAdUnitIdHandler()
		{
			if (IMaxAdInvoker.cb_getAdUnitId == null)
			{
				IMaxAdInvoker.cb_getAdUnitId = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IMaxAdInvoker.n_GetAdUnitId));
			}
			return IMaxAdInvoker.cb_getAdUnitId;
		}

		// Token: 0x0600057B RID: 1403 RVA: 0x0000E289 File Offset: 0x0000C489
		private static IntPtr n_GetAdUnitId(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<IMaxAd>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).AdUnitId);
		}

		// Token: 0x170001B3 RID: 435
		// (get) Token: 0x0600057C RID: 1404 RVA: 0x0000E2A0 File Offset: 0x0000C4A0
		public string AdUnitId
		{
			get
			{
				if (this.id_getAdUnitId == IntPtr.Zero)
				{
					this.id_getAdUnitId = JNIEnv.GetMethodID(this.class_ref, "getAdUnitId", "()Ljava/lang/String;");
				}
				return JNIEnv.GetString(JNIEnv.CallObjectMethod(base.Handle, this.id_getAdUnitId), JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x0600057D RID: 1405 RVA: 0x0000E2F1 File Offset: 0x0000C4F1
		private static Delegate GetGetCreativeIdHandler()
		{
			if (IMaxAdInvoker.cb_getCreativeId == null)
			{
				IMaxAdInvoker.cb_getCreativeId = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IMaxAdInvoker.n_GetCreativeId));
			}
			return IMaxAdInvoker.cb_getCreativeId;
		}

		// Token: 0x0600057E RID: 1406 RVA: 0x0000E315 File Offset: 0x0000C515
		private static IntPtr n_GetCreativeId(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<IMaxAd>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).CreativeId);
		}

		// Token: 0x170001B4 RID: 436
		// (get) Token: 0x0600057F RID: 1407 RVA: 0x0000E32C File Offset: 0x0000C52C
		public string CreativeId
		{
			get
			{
				if (this.id_getCreativeId == IntPtr.Zero)
				{
					this.id_getCreativeId = JNIEnv.GetMethodID(this.class_ref, "getCreativeId", "()Ljava/lang/String;");
				}
				return JNIEnv.GetString(JNIEnv.CallObjectMethod(base.Handle, this.id_getCreativeId), JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06000580 RID: 1408 RVA: 0x0000E37D File Offset: 0x0000C57D
		private static Delegate GetGetDspIdHandler()
		{
			if (IMaxAdInvoker.cb_getDspId == null)
			{
				IMaxAdInvoker.cb_getDspId = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IMaxAdInvoker.n_GetDspId));
			}
			return IMaxAdInvoker.cb_getDspId;
		}

		// Token: 0x06000581 RID: 1409 RVA: 0x0000E3A1 File Offset: 0x0000C5A1
		private static IntPtr n_GetDspId(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<IMaxAd>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).DspId);
		}

		// Token: 0x170001B5 RID: 437
		// (get) Token: 0x06000582 RID: 1410 RVA: 0x0000E3B8 File Offset: 0x0000C5B8
		public string DspId
		{
			get
			{
				if (this.id_getDspId == IntPtr.Zero)
				{
					this.id_getDspId = JNIEnv.GetMethodID(this.class_ref, "getDspId", "()Ljava/lang/String;");
				}
				return JNIEnv.GetString(JNIEnv.CallObjectMethod(base.Handle, this.id_getDspId), JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06000583 RID: 1411 RVA: 0x0000E409 File Offset: 0x0000C609
		private static Delegate GetGetDspNameHandler()
		{
			if (IMaxAdInvoker.cb_getDspName == null)
			{
				IMaxAdInvoker.cb_getDspName = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IMaxAdInvoker.n_GetDspName));
			}
			return IMaxAdInvoker.cb_getDspName;
		}

		// Token: 0x06000584 RID: 1412 RVA: 0x0000E42D File Offset: 0x0000C62D
		private static IntPtr n_GetDspName(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<IMaxAd>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).DspName);
		}

		// Token: 0x170001B6 RID: 438
		// (get) Token: 0x06000585 RID: 1413 RVA: 0x0000E444 File Offset: 0x0000C644
		public string DspName
		{
			get
			{
				if (this.id_getDspName == IntPtr.Zero)
				{
					this.id_getDspName = JNIEnv.GetMethodID(this.class_ref, "getDspName", "()Ljava/lang/String;");
				}
				return JNIEnv.GetString(JNIEnv.CallObjectMethod(base.Handle, this.id_getDspName), JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06000586 RID: 1414 RVA: 0x0000E495 File Offset: 0x0000C695
		private static Delegate GetGetFormatHandler()
		{
			if (IMaxAdInvoker.cb_getFormat == null)
			{
				IMaxAdInvoker.cb_getFormat = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IMaxAdInvoker.n_GetFormat));
			}
			return IMaxAdInvoker.cb_getFormat;
		}

		// Token: 0x06000587 RID: 1415 RVA: 0x0000E4B9 File Offset: 0x0000C6B9
		private static IntPtr n_GetFormat(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IMaxAd>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Format);
		}

		// Token: 0x170001B7 RID: 439
		// (get) Token: 0x06000588 RID: 1416 RVA: 0x0000E4D0 File Offset: 0x0000C6D0
		public MaxAdFormat Format
		{
			get
			{
				if (this.id_getFormat == IntPtr.Zero)
				{
					this.id_getFormat = JNIEnv.GetMethodID(this.class_ref, "getFormat", "()Lcom/applovin/mediation/MaxAdFormat;");
				}
				return Java.Lang.Object.GetObject<MaxAdFormat>(JNIEnv.CallObjectMethod(base.Handle, this.id_getFormat), JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06000589 RID: 1417 RVA: 0x0000E521 File Offset: 0x0000C721
		private static Delegate GetGetNativeAdHandler()
		{
			if (IMaxAdInvoker.cb_getNativeAd == null)
			{
				IMaxAdInvoker.cb_getNativeAd = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IMaxAdInvoker.n_GetNativeAd));
			}
			return IMaxAdInvoker.cb_getNativeAd;
		}

		// Token: 0x0600058A RID: 1418 RVA: 0x0000E545 File Offset: 0x0000C745
		private static IntPtr n_GetNativeAd(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IMaxAd>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).NativeAd);
		}

		// Token: 0x170001B8 RID: 440
		// (get) Token: 0x0600058B RID: 1419 RVA: 0x0000E55C File Offset: 0x0000C75C
		public MaxNativeAd NativeAd
		{
			get
			{
				if (this.id_getNativeAd == IntPtr.Zero)
				{
					this.id_getNativeAd = JNIEnv.GetMethodID(this.class_ref, "getNativeAd", "()Lcom/applovin/mediation/nativeAds/MaxNativeAd;");
				}
				return Java.Lang.Object.GetObject<MaxNativeAd>(JNIEnv.CallObjectMethod(base.Handle, this.id_getNativeAd), JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x0600058C RID: 1420 RVA: 0x0000E5AD File Offset: 0x0000C7AD
		private static Delegate GetGetNetworkNameHandler()
		{
			if (IMaxAdInvoker.cb_getNetworkName == null)
			{
				IMaxAdInvoker.cb_getNetworkName = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IMaxAdInvoker.n_GetNetworkName));
			}
			return IMaxAdInvoker.cb_getNetworkName;
		}

		// Token: 0x0600058D RID: 1421 RVA: 0x0000E5D1 File Offset: 0x0000C7D1
		private static IntPtr n_GetNetworkName(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<IMaxAd>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).NetworkName);
		}

		// Token: 0x170001B9 RID: 441
		// (get) Token: 0x0600058E RID: 1422 RVA: 0x0000E5E8 File Offset: 0x0000C7E8
		public string NetworkName
		{
			get
			{
				if (this.id_getNetworkName == IntPtr.Zero)
				{
					this.id_getNetworkName = JNIEnv.GetMethodID(this.class_ref, "getNetworkName", "()Ljava/lang/String;");
				}
				return JNIEnv.GetString(JNIEnv.CallObjectMethod(base.Handle, this.id_getNetworkName), JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x0600058F RID: 1423 RVA: 0x0000E639 File Offset: 0x0000C839
		private static Delegate GetGetNetworkPlacementHandler()
		{
			if (IMaxAdInvoker.cb_getNetworkPlacement == null)
			{
				IMaxAdInvoker.cb_getNetworkPlacement = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IMaxAdInvoker.n_GetNetworkPlacement));
			}
			return IMaxAdInvoker.cb_getNetworkPlacement;
		}

		// Token: 0x06000590 RID: 1424 RVA: 0x0000E65D File Offset: 0x0000C85D
		private static IntPtr n_GetNetworkPlacement(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<IMaxAd>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).NetworkPlacement);
		}

		// Token: 0x170001BA RID: 442
		// (get) Token: 0x06000591 RID: 1425 RVA: 0x0000E674 File Offset: 0x0000C874
		public string NetworkPlacement
		{
			get
			{
				if (this.id_getNetworkPlacement == IntPtr.Zero)
				{
					this.id_getNetworkPlacement = JNIEnv.GetMethodID(this.class_ref, "getNetworkPlacement", "()Ljava/lang/String;");
				}
				return JNIEnv.GetString(JNIEnv.CallObjectMethod(base.Handle, this.id_getNetworkPlacement), JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06000592 RID: 1426 RVA: 0x0000E6C5 File Offset: 0x0000C8C5
		private static Delegate GetGetPlacementHandler()
		{
			if (IMaxAdInvoker.cb_getPlacement == null)
			{
				IMaxAdInvoker.cb_getPlacement = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IMaxAdInvoker.n_GetPlacement));
			}
			return IMaxAdInvoker.cb_getPlacement;
		}

		// Token: 0x06000593 RID: 1427 RVA: 0x0000E6E9 File Offset: 0x0000C8E9
		private static IntPtr n_GetPlacement(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<IMaxAd>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Placement);
		}

		// Token: 0x170001BB RID: 443
		// (get) Token: 0x06000594 RID: 1428 RVA: 0x0000E700 File Offset: 0x0000C900
		public string Placement
		{
			get
			{
				if (this.id_getPlacement == IntPtr.Zero)
				{
					this.id_getPlacement = JNIEnv.GetMethodID(this.class_ref, "getPlacement", "()Ljava/lang/String;");
				}
				return JNIEnv.GetString(JNIEnv.CallObjectMethod(base.Handle, this.id_getPlacement), JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06000595 RID: 1429 RVA: 0x0000E751 File Offset: 0x0000C951
		private static Delegate GetGetRevenueHandler()
		{
			if (IMaxAdInvoker.cb_getRevenue == null)
			{
				IMaxAdInvoker.cb_getRevenue = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_D(IMaxAdInvoker.n_GetRevenue));
			}
			return IMaxAdInvoker.cb_getRevenue;
		}

		// Token: 0x06000596 RID: 1430 RVA: 0x0000E775 File Offset: 0x0000C975
		private static double n_GetRevenue(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<IMaxAd>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Revenue;
		}

		// Token: 0x170001BC RID: 444
		// (get) Token: 0x06000597 RID: 1431 RVA: 0x0000E784 File Offset: 0x0000C984
		public double Revenue
		{
			get
			{
				if (this.id_getRevenue == IntPtr.Zero)
				{
					this.id_getRevenue = JNIEnv.GetMethodID(this.class_ref, "getRevenue", "()D");
				}
				return JNIEnv.CallDoubleMethod(base.Handle, this.id_getRevenue);
			}
		}

		// Token: 0x06000598 RID: 1432 RVA: 0x0000E7C4 File Offset: 0x0000C9C4
		private static Delegate GetGetRevenuePrecisionHandler()
		{
			if (IMaxAdInvoker.cb_getRevenuePrecision == null)
			{
				IMaxAdInvoker.cb_getRevenuePrecision = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IMaxAdInvoker.n_GetRevenuePrecision));
			}
			return IMaxAdInvoker.cb_getRevenuePrecision;
		}

		// Token: 0x06000599 RID: 1433 RVA: 0x0000E7E8 File Offset: 0x0000C9E8
		private static IntPtr n_GetRevenuePrecision(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.NewString(Java.Lang.Object.GetObject<IMaxAd>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).RevenuePrecision);
		}

		// Token: 0x170001BD RID: 445
		// (get) Token: 0x0600059A RID: 1434 RVA: 0x0000E7FC File Offset: 0x0000C9FC
		public string RevenuePrecision
		{
			get
			{
				if (this.id_getRevenuePrecision == IntPtr.Zero)
				{
					this.id_getRevenuePrecision = JNIEnv.GetMethodID(this.class_ref, "getRevenuePrecision", "()Ljava/lang/String;");
				}
				return JNIEnv.GetString(JNIEnv.CallObjectMethod(base.Handle, this.id_getRevenuePrecision), JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x0600059B RID: 1435 RVA: 0x0000E84D File Offset: 0x0000CA4D
		private static Delegate GetGetSizeHandler()
		{
			if (IMaxAdInvoker.cb_getSize == null)
			{
				IMaxAdInvoker.cb_getSize = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IMaxAdInvoker.n_GetSize));
			}
			return IMaxAdInvoker.cb_getSize;
		}

		// Token: 0x0600059C RID: 1436 RVA: 0x0000E871 File Offset: 0x0000CA71
		private static IntPtr n_GetSize(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IMaxAd>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Size);
		}

		// Token: 0x170001BE RID: 446
		// (get) Token: 0x0600059D RID: 1437 RVA: 0x0000E888 File Offset: 0x0000CA88
		public AppLovinSdkUtils.Size Size
		{
			get
			{
				if (this.id_getSize == IntPtr.Zero)
				{
					this.id_getSize = JNIEnv.GetMethodID(this.class_ref, "getSize", "()Lcom/applovin/sdk/AppLovinSdkUtils$Size;");
				}
				return Java.Lang.Object.GetObject<AppLovinSdkUtils.Size>(JNIEnv.CallObjectMethod(base.Handle, this.id_getSize), JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x0600059E RID: 1438 RVA: 0x0000E8D9 File Offset: 0x0000CAD9
		private static Delegate GetGetWaterfallHandler()
		{
			if (IMaxAdInvoker.cb_getWaterfall == null)
			{
				IMaxAdInvoker.cb_getWaterfall = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IMaxAdInvoker.n_GetWaterfall));
			}
			return IMaxAdInvoker.cb_getWaterfall;
		}

		// Token: 0x0600059F RID: 1439 RVA: 0x0000E8FD File Offset: 0x0000CAFD
		private static IntPtr n_GetWaterfall(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IMaxAd>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Waterfall);
		}

		// Token: 0x170001BF RID: 447
		// (get) Token: 0x060005A0 RID: 1440 RVA: 0x0000E914 File Offset: 0x0000CB14
		public IMaxAdWaterfallInfo Waterfall
		{
			get
			{
				if (this.id_getWaterfall == IntPtr.Zero)
				{
					this.id_getWaterfall = JNIEnv.GetMethodID(this.class_ref, "getWaterfall", "()Lcom/applovin/mediation/MaxAdWaterfallInfo;");
				}
				return Java.Lang.Object.GetObject<IMaxAdWaterfallInfo>(JNIEnv.CallObjectMethod(base.Handle, this.id_getWaterfall), JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x060005A1 RID: 1441 RVA: 0x0000E965 File Offset: 0x0000CB65
		private static Delegate GetGetAdValue_Ljava_lang_String_Handler()
		{
			if (IMaxAdInvoker.cb_getAdValue_Ljava_lang_String_ == null)
			{
				IMaxAdInvoker.cb_getAdValue_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(IMaxAdInvoker.n_GetAdValue_Ljava_lang_String_));
			}
			return IMaxAdInvoker.cb_getAdValue_Ljava_lang_String_;
		}

		// Token: 0x060005A2 RID: 1442 RVA: 0x0000E98C File Offset: 0x0000CB8C
		private static IntPtr n_GetAdValue_Ljava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			IMaxAd @object = Java.Lang.Object.GetObject<IMaxAd>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_p0, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString(@object.GetAdValue(@string));
		}

		// Token: 0x060005A3 RID: 1443 RVA: 0x0000E9B4 File Offset: 0x0000CBB4
		public unsafe string GetAdValue(string p0)
		{
			if (this.id_getAdValue_Ljava_lang_String_ == IntPtr.Zero)
			{
				this.id_getAdValue_Ljava_lang_String_ = JNIEnv.GetMethodID(this.class_ref, "getAdValue", "(Ljava/lang/String;)Ljava/lang/String;");
			}
			IntPtr intPtr = JNIEnv.NewString(p0);
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(intPtr);
			string @string = JNIEnv.GetString(JNIEnv.CallObjectMethod(base.Handle, this.id_getAdValue_Ljava_lang_String_, ptr), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef(intPtr);
			return @string;
		}

		// Token: 0x060005A4 RID: 1444 RVA: 0x0000EA2B File Offset: 0x0000CC2B
		private static Delegate GetGetAdValue_Ljava_lang_String_Ljava_lang_String_Handler()
		{
			if (IMaxAdInvoker.cb_getAdValue_Ljava_lang_String_Ljava_lang_String_ == null)
			{
				IMaxAdInvoker.cb_getAdValue_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_L(IMaxAdInvoker.n_GetAdValue_Ljava_lang_String_Ljava_lang_String_));
			}
			return IMaxAdInvoker.cb_getAdValue_Ljava_lang_String_Ljava_lang_String_;
		}

		// Token: 0x060005A5 RID: 1445 RVA: 0x0000EA50 File Offset: 0x0000CC50
		private static IntPtr n_GetAdValue_Ljava_lang_String_Ljava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			IMaxAd @object = Java.Lang.Object.GetObject<IMaxAd>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_p0, JniHandleOwnership.DoNotTransfer);
			string string2 = JNIEnv.GetString(native_p1, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString(@object.GetAdValue(@string, string2));
		}

		// Token: 0x060005A6 RID: 1446 RVA: 0x0000EA84 File Offset: 0x0000CC84
		public unsafe string GetAdValue(string p0, string p1)
		{
			if (this.id_getAdValue_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
			{
				this.id_getAdValue_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID(this.class_ref, "getAdValue", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;");
			}
			IntPtr intPtr = JNIEnv.NewString(p0);
			IntPtr intPtr2 = JNIEnv.NewString(p1);
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(intPtr);
			ptr[1] = new JValue(intPtr2);
			string @string = JNIEnv.GetString(JNIEnv.CallObjectMethod(base.Handle, this.id_getAdValue_Ljava_lang_String_Ljava_lang_String_, ptr), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef(intPtr);
			JNIEnv.DeleteLocalRef(intPtr2);
			return @string;
		}

		// Token: 0x040001A2 RID: 418
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/applovin/mediation/MaxAd", typeof(IMaxAdInvoker));

		// Token: 0x040001A3 RID: 419
		private IntPtr class_ref;

		// Token: 0x040001A4 RID: 420
		private static Delegate cb_getAdReviewCreativeId;

		// Token: 0x040001A5 RID: 421
		private IntPtr id_getAdReviewCreativeId;

		// Token: 0x040001A6 RID: 422
		private static Delegate cb_getAdUnitId;

		// Token: 0x040001A7 RID: 423
		private IntPtr id_getAdUnitId;

		// Token: 0x040001A8 RID: 424
		private static Delegate cb_getCreativeId;

		// Token: 0x040001A9 RID: 425
		private IntPtr id_getCreativeId;

		// Token: 0x040001AA RID: 426
		private static Delegate cb_getDspId;

		// Token: 0x040001AB RID: 427
		private IntPtr id_getDspId;

		// Token: 0x040001AC RID: 428
		private static Delegate cb_getDspName;

		// Token: 0x040001AD RID: 429
		private IntPtr id_getDspName;

		// Token: 0x040001AE RID: 430
		private static Delegate cb_getFormat;

		// Token: 0x040001AF RID: 431
		private IntPtr id_getFormat;

		// Token: 0x040001B0 RID: 432
		private static Delegate cb_getNativeAd;

		// Token: 0x040001B1 RID: 433
		private IntPtr id_getNativeAd;

		// Token: 0x040001B2 RID: 434
		private static Delegate cb_getNetworkName;

		// Token: 0x040001B3 RID: 435
		private IntPtr id_getNetworkName;

		// Token: 0x040001B4 RID: 436
		private static Delegate cb_getNetworkPlacement;

		// Token: 0x040001B5 RID: 437
		private IntPtr id_getNetworkPlacement;

		// Token: 0x040001B6 RID: 438
		private static Delegate cb_getPlacement;

		// Token: 0x040001B7 RID: 439
		private IntPtr id_getPlacement;

		// Token: 0x040001B8 RID: 440
		private static Delegate cb_getRevenue;

		// Token: 0x040001B9 RID: 441
		private IntPtr id_getRevenue;

		// Token: 0x040001BA RID: 442
		private static Delegate cb_getRevenuePrecision;

		// Token: 0x040001BB RID: 443
		private IntPtr id_getRevenuePrecision;

		// Token: 0x040001BC RID: 444
		private static Delegate cb_getSize;

		// Token: 0x040001BD RID: 445
		private IntPtr id_getSize;

		// Token: 0x040001BE RID: 446
		private static Delegate cb_getWaterfall;

		// Token: 0x040001BF RID: 447
		private IntPtr id_getWaterfall;

		// Token: 0x040001C0 RID: 448
		private static Delegate cb_getAdValue_Ljava_lang_String_;

		// Token: 0x040001C1 RID: 449
		private IntPtr id_getAdValue_Ljava_lang_String_;

		// Token: 0x040001C2 RID: 450
		private static Delegate cb_getAdValue_Ljava_lang_String_Ljava_lang_String_;

		// Token: 0x040001C3 RID: 451
		private IntPtr id_getAdValue_Ljava_lang_String_Ljava_lang_String_;
	}
}
