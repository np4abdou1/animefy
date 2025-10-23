using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Com.Unity3d.Services.Core.Webview.Bridge;
using Java.Interop;
using Java.Lang;

namespace Com.Unity3d.Services.Core.Api
{
	// Token: 0x02000188 RID: 392
	[Register("com/unity3d/services/core/api/DeviceInfo", DoNotGenerateAcw = true)]
	public class DeviceInfo : Java.Lang.Object
	{
		// Token: 0x17000643 RID: 1603
		// (get) Token: 0x060011A8 RID: 4520 RVA: 0x0002FF98 File Offset: 0x0002E198
		internal static IntPtr class_ref
		{
			get
			{
				return DeviceInfo._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000644 RID: 1604
		// (get) Token: 0x060011A9 RID: 4521 RVA: 0x0002FFBC File Offset: 0x0002E1BC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return DeviceInfo._members;
			}
		}

		// Token: 0x17000645 RID: 1605
		// (get) Token: 0x060011AA RID: 4522 RVA: 0x0002FFC4 File Offset: 0x0002E1C4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return DeviceInfo._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000646 RID: 1606
		// (get) Token: 0x060011AB RID: 4523 RVA: 0x0002FFE8 File Offset: 0x0002E1E8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return DeviceInfo._members.ManagedPeerType;
			}
		}

		// Token: 0x060011AC RID: 4524 RVA: 0x000021E8 File Offset: 0x000003E8
		protected DeviceInfo(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x060011AD RID: 4525 RVA: 0x0002FFF4 File Offset: 0x0002E1F4
		[Register(".ctor", "()V", "")]
		public DeviceInfo() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			base.SetHandle(DeviceInfo._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
			DeviceInfo._members.InstanceMethods.FinishCreateInstance("()V", this, null);
		}

		// Token: 0x060011AE RID: 4526 RVA: 0x00030064 File Offset: 0x0002E264
		[Register("getAdvertisingTrackingId", "(Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", "")]
		public unsafe static void GetAdvertisingTrackingId(WebViewCallback callback)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((callback == null) ? IntPtr.Zero : callback.Handle);
				DeviceInfo._members.StaticMethods.InvokeVoidMethod("getAdvertisingTrackingId.(Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", ptr);
			}
			finally
			{
				GC.KeepAlive(callback);
			}
		}

		// Token: 0x060011AF RID: 4527 RVA: 0x000300C8 File Offset: 0x0002E2C8
		[Register("getApiLevel", "(Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", "")]
		public unsafe static void GetApiLevel(WebViewCallback callback)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((callback == null) ? IntPtr.Zero : callback.Handle);
				DeviceInfo._members.StaticMethods.InvokeVoidMethod("getApiLevel.(Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", ptr);
			}
			finally
			{
				GC.KeepAlive(callback);
			}
		}

		// Token: 0x060011B0 RID: 4528 RVA: 0x0003012C File Offset: 0x0002E32C
		[Register("getApkDigest", "(Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", "")]
		public unsafe static void GetApkDigest(WebViewCallback callback)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((callback == null) ? IntPtr.Zero : callback.Handle);
				DeviceInfo._members.StaticMethods.InvokeVoidMethod("getApkDigest.(Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", ptr);
			}
			finally
			{
				GC.KeepAlive(callback);
			}
		}

		// Token: 0x060011B1 RID: 4529 RVA: 0x00030190 File Offset: 0x0002E390
		[Register("getBatteryLevel", "(Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", "")]
		public unsafe static void GetBatteryLevel(WebViewCallback callback)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((callback == null) ? IntPtr.Zero : callback.Handle);
				DeviceInfo._members.StaticMethods.InvokeVoidMethod("getBatteryLevel.(Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", ptr);
			}
			finally
			{
				GC.KeepAlive(callback);
			}
		}

		// Token: 0x060011B2 RID: 4530 RVA: 0x000301F4 File Offset: 0x0002E3F4
		[Register("getBatteryStatus", "(Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", "")]
		public unsafe static void GetBatteryStatus(WebViewCallback callback)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((callback == null) ? IntPtr.Zero : callback.Handle);
				DeviceInfo._members.StaticMethods.InvokeVoidMethod("getBatteryStatus.(Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", ptr);
			}
			finally
			{
				GC.KeepAlive(callback);
			}
		}

		// Token: 0x060011B3 RID: 4531 RVA: 0x00030258 File Offset: 0x0002E458
		[Register("getBoard", "(Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", "")]
		public unsafe static void GetBoard(WebViewCallback callback)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((callback == null) ? IntPtr.Zero : callback.Handle);
				DeviceInfo._members.StaticMethods.InvokeVoidMethod("getBoard.(Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", ptr);
			}
			finally
			{
				GC.KeepAlive(callback);
			}
		}

		// Token: 0x060011B4 RID: 4532 RVA: 0x000302BC File Offset: 0x0002E4BC
		[Register("getBootloader", "(Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", "")]
		public unsafe static void GetBootloader(WebViewCallback callback)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((callback == null) ? IntPtr.Zero : callback.Handle);
				DeviceInfo._members.StaticMethods.InvokeVoidMethod("getBootloader.(Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", ptr);
			}
			finally
			{
				GC.KeepAlive(callback);
			}
		}

		// Token: 0x060011B5 RID: 4533 RVA: 0x00030320 File Offset: 0x0002E520
		[Register("getBrand", "(Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", "")]
		public unsafe static void GetBrand(WebViewCallback callback)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((callback == null) ? IntPtr.Zero : callback.Handle);
				DeviceInfo._members.StaticMethods.InvokeVoidMethod("getBrand.(Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", ptr);
			}
			finally
			{
				GC.KeepAlive(callback);
			}
		}

		// Token: 0x060011B6 RID: 4534 RVA: 0x00030384 File Offset: 0x0002E584
		[Register("getBuildId", "(Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", "")]
		public unsafe static void GetBuildId(WebViewCallback callback)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((callback == null) ? IntPtr.Zero : callback.Handle);
				DeviceInfo._members.StaticMethods.InvokeVoidMethod("getBuildId.(Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", ptr);
			}
			finally
			{
				GC.KeepAlive(callback);
			}
		}

		// Token: 0x060011B7 RID: 4535 RVA: 0x000303E8 File Offset: 0x0002E5E8
		[Register("getBuildVersionIncremental", "(Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", "")]
		public unsafe static void GetBuildVersionIncremental(WebViewCallback callback)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((callback == null) ? IntPtr.Zero : callback.Handle);
				DeviceInfo._members.StaticMethods.InvokeVoidMethod("getBuildVersionIncremental.(Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", ptr);
			}
			finally
			{
				GC.KeepAlive(callback);
			}
		}

		// Token: 0x060011B8 RID: 4536 RVA: 0x0003044C File Offset: 0x0002E64C
		[Register("getCPUCount", "(Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", "")]
		public unsafe static void GetCPUCount(WebViewCallback callback)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((callback == null) ? IntPtr.Zero : callback.Handle);
				DeviceInfo._members.StaticMethods.InvokeVoidMethod("getCPUCount.(Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", ptr);
			}
			finally
			{
				GC.KeepAlive(callback);
			}
		}

		// Token: 0x060011B9 RID: 4537 RVA: 0x000304B0 File Offset: 0x0002E6B0
		[Register("getCertificateFingerprint", "(Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", "")]
		public unsafe static void GetCertificateFingerprint(WebViewCallback callback)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((callback == null) ? IntPtr.Zero : callback.Handle);
				DeviceInfo._members.StaticMethods.InvokeVoidMethod("getCertificateFingerprint.(Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", ptr);
			}
			finally
			{
				GC.KeepAlive(callback);
			}
		}

		// Token: 0x060011BA RID: 4538 RVA: 0x00030514 File Offset: 0x0002E714
		[Register("getConnectionType", "(Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", "")]
		public unsafe static void GetConnectionType(WebViewCallback callback)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((callback == null) ? IntPtr.Zero : callback.Handle);
				DeviceInfo._members.StaticMethods.InvokeVoidMethod("getConnectionType.(Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", ptr);
			}
			finally
			{
				GC.KeepAlive(callback);
			}
		}

		// Token: 0x060011BB RID: 4539 RVA: 0x00030578 File Offset: 0x0002E778
		[Register("getDevice", "(Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", "")]
		public unsafe static void GetDevice(WebViewCallback callback)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((callback == null) ? IntPtr.Zero : callback.Handle);
				DeviceInfo._members.StaticMethods.InvokeVoidMethod("getDevice.(Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", ptr);
			}
			finally
			{
				GC.KeepAlive(callback);
			}
		}

		// Token: 0x060011BC RID: 4540 RVA: 0x000305DC File Offset: 0x0002E7DC
		[Register("getDeviceMaxVolume", "(Ljava/lang/Integer;Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", "")]
		public unsafe static void GetDeviceMaxVolume(Integer streamType, WebViewCallback callback)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((streamType == null) ? IntPtr.Zero : streamType.Handle);
				ptr[1] = new JniArgumentValue((callback == null) ? IntPtr.Zero : callback.Handle);
				DeviceInfo._members.StaticMethods.InvokeVoidMethod("getDeviceMaxVolume.(Ljava/lang/Integer;Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", ptr);
			}
			finally
			{
				GC.KeepAlive(streamType);
				GC.KeepAlive(callback);
			}
		}

		// Token: 0x060011BD RID: 4541 RVA: 0x00030668 File Offset: 0x0002E868
		[Register("getDeviceVolume", "(Ljava/lang/Integer;Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", "")]
		public unsafe static void GetDeviceVolume(Integer streamType, WebViewCallback callback)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((streamType == null) ? IntPtr.Zero : streamType.Handle);
				ptr[1] = new JniArgumentValue((callback == null) ? IntPtr.Zero : callback.Handle);
				DeviceInfo._members.StaticMethods.InvokeVoidMethod("getDeviceVolume.(Ljava/lang/Integer;Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", ptr);
			}
			finally
			{
				GC.KeepAlive(streamType);
				GC.KeepAlive(callback);
			}
		}

		// Token: 0x060011BE RID: 4542 RVA: 0x000306F4 File Offset: 0x0002E8F4
		[Register("getDisplayMetricDensity", "(Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", "")]
		public unsafe static void GetDisplayMetricDensity(WebViewCallback callback)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((callback == null) ? IntPtr.Zero : callback.Handle);
				DeviceInfo._members.StaticMethods.InvokeVoidMethod("getDisplayMetricDensity.(Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", ptr);
			}
			finally
			{
				GC.KeepAlive(callback);
			}
		}

		// Token: 0x060011BF RID: 4543 RVA: 0x00030758 File Offset: 0x0002E958
		[Register("getElapsedRealtime", "(Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", "")]
		public unsafe static void GetElapsedRealtime(WebViewCallback callback)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((callback == null) ? IntPtr.Zero : callback.Handle);
				DeviceInfo._members.StaticMethods.InvokeVoidMethod("getElapsedRealtime.(Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", ptr);
			}
			finally
			{
				GC.KeepAlive(callback);
			}
		}

		// Token: 0x060011C0 RID: 4544 RVA: 0x000307BC File Offset: 0x0002E9BC
		[Register("getFingerprint", "(Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", "")]
		public unsafe static void GetFingerprint(WebViewCallback callback)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((callback == null) ? IntPtr.Zero : callback.Handle);
				DeviceInfo._members.StaticMethods.InvokeVoidMethod("getFingerprint.(Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", ptr);
			}
			finally
			{
				GC.KeepAlive(callback);
			}
		}

		// Token: 0x060011C1 RID: 4545 RVA: 0x00030820 File Offset: 0x0002EA20
		[Register("getFreeMemory", "(Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", "")]
		public unsafe static void GetFreeMemory(WebViewCallback callback)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((callback == null) ? IntPtr.Zero : callback.Handle);
				DeviceInfo._members.StaticMethods.InvokeVoidMethod("getFreeMemory.(Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", ptr);
			}
			finally
			{
				GC.KeepAlive(callback);
			}
		}

		// Token: 0x060011C2 RID: 4546 RVA: 0x00030884 File Offset: 0x0002EA84
		[Register("getFreeSpace", "(Ljava/lang/String;Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", "")]
		public unsafe static void GetFreeSpace(string storageType, WebViewCallback callback)
		{
			IntPtr intPtr = JNIEnv.NewString(storageType);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((callback == null) ? IntPtr.Zero : callback.Handle);
				DeviceInfo._members.StaticMethods.InvokeVoidMethod("getFreeSpace.(Ljava/lang/String;Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(callback);
			}
		}

		// Token: 0x060011C3 RID: 4547 RVA: 0x00030908 File Offset: 0x0002EB08
		[Register("getGLVersion", "(Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", "")]
		public unsafe static void GetGLVersion(WebViewCallback callback)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((callback == null) ? IntPtr.Zero : callback.Handle);
				DeviceInfo._members.StaticMethods.InvokeVoidMethod("getGLVersion.(Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", ptr);
			}
			finally
			{
				GC.KeepAlive(callback);
			}
		}

		// Token: 0x060011C4 RID: 4548 RVA: 0x0003096C File Offset: 0x0002EB6C
		[Register("getHardware", "(Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", "")]
		public unsafe static void GetHardware(WebViewCallback callback)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((callback == null) ? IntPtr.Zero : callback.Handle);
				DeviceInfo._members.StaticMethods.InvokeVoidMethod("getHardware.(Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", ptr);
			}
			finally
			{
				GC.KeepAlive(callback);
			}
		}

		// Token: 0x060011C5 RID: 4549 RVA: 0x000309D0 File Offset: 0x0002EBD0
		[Register("getHeadset", "(Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", "")]
		public unsafe static void GetHeadset(WebViewCallback callback)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((callback == null) ? IntPtr.Zero : callback.Handle);
				DeviceInfo._members.StaticMethods.InvokeVoidMethod("getHeadset.(Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", ptr);
			}
			finally
			{
				GC.KeepAlive(callback);
			}
		}

		// Token: 0x060011C6 RID: 4550 RVA: 0x00030A34 File Offset: 0x0002EC34
		[Register("getHost", "(Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", "")]
		public unsafe static void GetHost(WebViewCallback callback)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((callback == null) ? IntPtr.Zero : callback.Handle);
				DeviceInfo._members.StaticMethods.InvokeVoidMethod("getHost.(Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", ptr);
			}
			finally
			{
				GC.KeepAlive(callback);
			}
		}

		// Token: 0x060011C7 RID: 4551 RVA: 0x00030A98 File Offset: 0x0002EC98
		[Register("getLimitAdTrackingFlag", "(Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", "")]
		public unsafe static void GetLimitAdTrackingFlag(WebViewCallback callback)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((callback == null) ? IntPtr.Zero : callback.Handle);
				DeviceInfo._members.StaticMethods.InvokeVoidMethod("getLimitAdTrackingFlag.(Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", ptr);
			}
			finally
			{
				GC.KeepAlive(callback);
			}
		}

		// Token: 0x060011C8 RID: 4552 RVA: 0x00030AFC File Offset: 0x0002ECFC
		[Register("getLimitOpenAdTrackingFlag", "(Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", "")]
		public unsafe static void GetLimitOpenAdTrackingFlag(WebViewCallback callback)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((callback == null) ? IntPtr.Zero : callback.Handle);
				DeviceInfo._members.StaticMethods.InvokeVoidMethod("getLimitOpenAdTrackingFlag.(Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", ptr);
			}
			finally
			{
				GC.KeepAlive(callback);
			}
		}

		// Token: 0x060011C9 RID: 4553 RVA: 0x00030B60 File Offset: 0x0002ED60
		[Register("getManufacturer", "(Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", "")]
		public unsafe static void GetManufacturer(WebViewCallback callback)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((callback == null) ? IntPtr.Zero : callback.Handle);
				DeviceInfo._members.StaticMethods.InvokeVoidMethod("getManufacturer.(Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", ptr);
			}
			finally
			{
				GC.KeepAlive(callback);
			}
		}

		// Token: 0x060011CA RID: 4554 RVA: 0x00030BC4 File Offset: 0x0002EDC4
		[Register("getModel", "(Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", "")]
		public unsafe static void GetModel(WebViewCallback callback)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((callback == null) ? IntPtr.Zero : callback.Handle);
				DeviceInfo._members.StaticMethods.InvokeVoidMethod("getModel.(Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", ptr);
			}
			finally
			{
				GC.KeepAlive(callback);
			}
		}

		// Token: 0x060011CB RID: 4555 RVA: 0x00030C28 File Offset: 0x0002EE28
		[Register("getNetworkCountryISO", "(Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", "")]
		public unsafe static void GetNetworkCountryISO(WebViewCallback callback)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((callback == null) ? IntPtr.Zero : callback.Handle);
				DeviceInfo._members.StaticMethods.InvokeVoidMethod("getNetworkCountryISO.(Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", ptr);
			}
			finally
			{
				GC.KeepAlive(callback);
			}
		}

		// Token: 0x060011CC RID: 4556 RVA: 0x00030C8C File Offset: 0x0002EE8C
		[Register("getNetworkMetered", "(Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", "")]
		public unsafe static void GetNetworkMetered(WebViewCallback callback)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((callback == null) ? IntPtr.Zero : callback.Handle);
				DeviceInfo._members.StaticMethods.InvokeVoidMethod("getNetworkMetered.(Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", ptr);
			}
			finally
			{
				GC.KeepAlive(callback);
			}
		}

		// Token: 0x060011CD RID: 4557 RVA: 0x00030CF0 File Offset: 0x0002EEF0
		[Register("getNetworkOperator", "(Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", "")]
		public unsafe static void GetNetworkOperator(WebViewCallback callback)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((callback == null) ? IntPtr.Zero : callback.Handle);
				DeviceInfo._members.StaticMethods.InvokeVoidMethod("getNetworkOperator.(Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", ptr);
			}
			finally
			{
				GC.KeepAlive(callback);
			}
		}

		// Token: 0x060011CE RID: 4558 RVA: 0x00030D54 File Offset: 0x0002EF54
		[Register("getNetworkOperatorName", "(Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", "")]
		public unsafe static void GetNetworkOperatorName(WebViewCallback callback)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((callback == null) ? IntPtr.Zero : callback.Handle);
				DeviceInfo._members.StaticMethods.InvokeVoidMethod("getNetworkOperatorName.(Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", ptr);
			}
			finally
			{
				GC.KeepAlive(callback);
			}
		}

		// Token: 0x060011CF RID: 4559 RVA: 0x00030DB8 File Offset: 0x0002EFB8
		[Register("getNetworkType", "(Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", "")]
		public unsafe static void GetNetworkType(WebViewCallback callback)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((callback == null) ? IntPtr.Zero : callback.Handle);
				DeviceInfo._members.StaticMethods.InvokeVoidMethod("getNetworkType.(Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", ptr);
			}
			finally
			{
				GC.KeepAlive(callback);
			}
		}

		// Token: 0x060011D0 RID: 4560 RVA: 0x00030E1C File Offset: 0x0002F01C
		[Register("getOpenAdvertisingTrackingId", "(Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", "")]
		public unsafe static void GetOpenAdvertisingTrackingId(WebViewCallback callback)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((callback == null) ? IntPtr.Zero : callback.Handle);
				DeviceInfo._members.StaticMethods.InvokeVoidMethod("getOpenAdvertisingTrackingId.(Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", ptr);
			}
			finally
			{
				GC.KeepAlive(callback);
			}
		}

		// Token: 0x060011D1 RID: 4561 RVA: 0x00030E80 File Offset: 0x0002F080
		[Register("getOsVersion", "(Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", "")]
		public unsafe static void GetOsVersion(WebViewCallback callback)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((callback == null) ? IntPtr.Zero : callback.Handle);
				DeviceInfo._members.StaticMethods.InvokeVoidMethod("getOsVersion.(Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", ptr);
			}
			finally
			{
				GC.KeepAlive(callback);
			}
		}

		// Token: 0x060011D2 RID: 4562 RVA: 0x00030EE4 File Offset: 0x0002F0E4
		[Register("getPackageInfo", "(Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", "")]
		public unsafe static void GetPackageInfo(WebViewCallback callback)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((callback == null) ? IntPtr.Zero : callback.Handle);
				DeviceInfo._members.StaticMethods.InvokeVoidMethod("getPackageInfo.(Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", ptr);
			}
			finally
			{
				GC.KeepAlive(callback);
			}
		}

		// Token: 0x060011D3 RID: 4563 RVA: 0x00030F48 File Offset: 0x0002F148
		[Register("getProcessInfo", "(Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", "")]
		public unsafe static void GetProcessInfo(WebViewCallback callback)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((callback == null) ? IntPtr.Zero : callback.Handle);
				DeviceInfo._members.StaticMethods.InvokeVoidMethod("getProcessInfo.(Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", ptr);
			}
			finally
			{
				GC.KeepAlive(callback);
			}
		}

		// Token: 0x060011D4 RID: 4564 RVA: 0x00030FAC File Offset: 0x0002F1AC
		[Register("getProduct", "(Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", "")]
		public unsafe static void GetProduct(WebViewCallback callback)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((callback == null) ? IntPtr.Zero : callback.Handle);
				DeviceInfo._members.StaticMethods.InvokeVoidMethod("getProduct.(Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", ptr);
			}
			finally
			{
				GC.KeepAlive(callback);
			}
		}

		// Token: 0x060011D5 RID: 4565 RVA: 0x00031010 File Offset: 0x0002F210
		[Register("getRingerMode", "(Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", "")]
		public unsafe static void GetRingerMode(WebViewCallback callback)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((callback == null) ? IntPtr.Zero : callback.Handle);
				DeviceInfo._members.StaticMethods.InvokeVoidMethod("getRingerMode.(Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", ptr);
			}
			finally
			{
				GC.KeepAlive(callback);
			}
		}

		// Token: 0x060011D6 RID: 4566 RVA: 0x00031074 File Offset: 0x0002F274
		[Register("getScreenBrightness", "(Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", "")]
		public unsafe static void GetScreenBrightness(WebViewCallback callback)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((callback == null) ? IntPtr.Zero : callback.Handle);
				DeviceInfo._members.StaticMethods.InvokeVoidMethod("getScreenBrightness.(Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", ptr);
			}
			finally
			{
				GC.KeepAlive(callback);
			}
		}

		// Token: 0x060011D7 RID: 4567 RVA: 0x000310D8 File Offset: 0x0002F2D8
		[Register("getScreenDensity", "(Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", "")]
		public unsafe static void GetScreenDensity(WebViewCallback callback)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((callback == null) ? IntPtr.Zero : callback.Handle);
				DeviceInfo._members.StaticMethods.InvokeVoidMethod("getScreenDensity.(Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", ptr);
			}
			finally
			{
				GC.KeepAlive(callback);
			}
		}

		// Token: 0x060011D8 RID: 4568 RVA: 0x0003113C File Offset: 0x0002F33C
		[Register("getScreenHeight", "(Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", "")]
		public unsafe static void GetScreenHeight(WebViewCallback callback)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((callback == null) ? IntPtr.Zero : callback.Handle);
				DeviceInfo._members.StaticMethods.InvokeVoidMethod("getScreenHeight.(Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", ptr);
			}
			finally
			{
				GC.KeepAlive(callback);
			}
		}

		// Token: 0x060011D9 RID: 4569 RVA: 0x000311A0 File Offset: 0x0002F3A0
		[Register("getScreenLayout", "(Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", "")]
		public unsafe static void GetScreenLayout(WebViewCallback callback)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((callback == null) ? IntPtr.Zero : callback.Handle);
				DeviceInfo._members.StaticMethods.InvokeVoidMethod("getScreenLayout.(Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", ptr);
			}
			finally
			{
				GC.KeepAlive(callback);
			}
		}

		// Token: 0x060011DA RID: 4570 RVA: 0x00031204 File Offset: 0x0002F404
		[Register("getScreenWidth", "(Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", "")]
		public unsafe static void GetScreenWidth(WebViewCallback callback)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((callback == null) ? IntPtr.Zero : callback.Handle);
				DeviceInfo._members.StaticMethods.InvokeVoidMethod("getScreenWidth.(Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", ptr);
			}
			finally
			{
				GC.KeepAlive(callback);
			}
		}

		// Token: 0x060011DB RID: 4571 RVA: 0x00031268 File Offset: 0x0002F468
		[Register("getSensorList", "(Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", "")]
		public unsafe static void GetSensorList(WebViewCallback callback)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((callback == null) ? IntPtr.Zero : callback.Handle);
				DeviceInfo._members.StaticMethods.InvokeVoidMethod("getSensorList.(Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", ptr);
			}
			finally
			{
				GC.KeepAlive(callback);
			}
		}

		// Token: 0x060011DC RID: 4572 RVA: 0x000312CC File Offset: 0x0002F4CC
		[Register("getSupportedAbis", "(Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", "")]
		public unsafe static void GetSupportedAbis(WebViewCallback callback)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((callback == null) ? IntPtr.Zero : callback.Handle);
				DeviceInfo._members.StaticMethods.InvokeVoidMethod("getSupportedAbis.(Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", ptr);
			}
			finally
			{
				GC.KeepAlive(callback);
			}
		}

		// Token: 0x060011DD RID: 4573 RVA: 0x00031330 File Offset: 0x0002F530
		[Register("getSystemLanguage", "(Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", "")]
		public unsafe static void GetSystemLanguage(WebViewCallback callback)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((callback == null) ? IntPtr.Zero : callback.Handle);
				DeviceInfo._members.StaticMethods.InvokeVoidMethod("getSystemLanguage.(Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", ptr);
			}
			finally
			{
				GC.KeepAlive(callback);
			}
		}

		// Token: 0x060011DE RID: 4574 RVA: 0x00031394 File Offset: 0x0002F594
		[Register("getSystemProperty", "(Ljava/lang/String;Ljava/lang/String;Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", "")]
		public unsafe static void GetSystemProperty(string propertyName, string defaultValue, WebViewCallback callback)
		{
			IntPtr intPtr = JNIEnv.NewString(propertyName);
			IntPtr intPtr2 = JNIEnv.NewString(defaultValue);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(intPtr2);
				ptr[2] = new JniArgumentValue((callback == null) ? IntPtr.Zero : callback.Handle);
				DeviceInfo._members.StaticMethods.InvokeVoidMethod("getSystemProperty.(Ljava/lang/String;Ljava/lang/String;Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				JNIEnv.DeleteLocalRef(intPtr2);
				GC.KeepAlive(callback);
			}
		}

		// Token: 0x060011DF RID: 4575 RVA: 0x0003143C File Offset: 0x0002F63C
		[Register("getTimeZone", "(Ljava/lang/Boolean;Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", "")]
		public unsafe static void GetTimeZone(Java.Lang.Boolean dst, WebViewCallback callback)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((dst == null) ? IntPtr.Zero : dst.Handle);
				ptr[1] = new JniArgumentValue((callback == null) ? IntPtr.Zero : callback.Handle);
				DeviceInfo._members.StaticMethods.InvokeVoidMethod("getTimeZone.(Ljava/lang/Boolean;Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", ptr);
			}
			finally
			{
				GC.KeepAlive(dst);
				GC.KeepAlive(callback);
			}
		}

		// Token: 0x060011E0 RID: 4576 RVA: 0x000314C8 File Offset: 0x0002F6C8
		[Register("getTimeZoneOffset", "(Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", "")]
		public unsafe static void GetTimeZoneOffset(WebViewCallback callback)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((callback == null) ? IntPtr.Zero : callback.Handle);
				DeviceInfo._members.StaticMethods.InvokeVoidMethod("getTimeZoneOffset.(Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", ptr);
			}
			finally
			{
				GC.KeepAlive(callback);
			}
		}

		// Token: 0x060011E1 RID: 4577 RVA: 0x0003152C File Offset: 0x0002F72C
		[Register("getTotalMemory", "(Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", "")]
		public unsafe static void GetTotalMemory(WebViewCallback callback)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((callback == null) ? IntPtr.Zero : callback.Handle);
				DeviceInfo._members.StaticMethods.InvokeVoidMethod("getTotalMemory.(Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", ptr);
			}
			finally
			{
				GC.KeepAlive(callback);
			}
		}

		// Token: 0x060011E2 RID: 4578 RVA: 0x00031590 File Offset: 0x0002F790
		[Register("getTotalSpace", "(Ljava/lang/String;Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", "")]
		public unsafe static void GetTotalSpace(string storageType, WebViewCallback callback)
		{
			IntPtr intPtr = JNIEnv.NewString(storageType);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((callback == null) ? IntPtr.Zero : callback.Handle);
				DeviceInfo._members.StaticMethods.InvokeVoidMethod("getTotalSpace.(Ljava/lang/String;Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(callback);
			}
		}

		// Token: 0x060011E3 RID: 4579 RVA: 0x00031614 File Offset: 0x0002F814
		[Register("getUniqueEventId", "(Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", "")]
		public unsafe static void GetUniqueEventId(WebViewCallback callback)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((callback == null) ? IntPtr.Zero : callback.Handle);
				DeviceInfo._members.StaticMethods.InvokeVoidMethod("getUniqueEventId.(Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", ptr);
			}
			finally
			{
				GC.KeepAlive(callback);
			}
		}

		// Token: 0x060011E4 RID: 4580 RVA: 0x00031678 File Offset: 0x0002F878
		[Register("getUptime", "(Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", "")]
		public unsafe static void GetUptime(WebViewCallback callback)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((callback == null) ? IntPtr.Zero : callback.Handle);
				DeviceInfo._members.StaticMethods.InvokeVoidMethod("getUptime.(Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", ptr);
			}
			finally
			{
				GC.KeepAlive(callback);
			}
		}

		// Token: 0x060011E5 RID: 4581 RVA: 0x000316DC File Offset: 0x0002F8DC
		[Register("isAdbEnabled", "(Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", "")]
		public unsafe static void IsAdbEnabled(WebViewCallback callback)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((callback == null) ? IntPtr.Zero : callback.Handle);
				DeviceInfo._members.StaticMethods.InvokeVoidMethod("isAdbEnabled.(Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", ptr);
			}
			finally
			{
				GC.KeepAlive(callback);
			}
		}

		// Token: 0x060011E6 RID: 4582 RVA: 0x00031740 File Offset: 0x0002F940
		[Register("isRooted", "(Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", "")]
		public unsafe static void IsRooted(WebViewCallback callback)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((callback == null) ? IntPtr.Zero : callback.Handle);
				DeviceInfo._members.StaticMethods.InvokeVoidMethod("isRooted.(Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", ptr);
			}
			finally
			{
				GC.KeepAlive(callback);
			}
		}

		// Token: 0x060011E7 RID: 4583 RVA: 0x000317A4 File Offset: 0x0002F9A4
		[Register("isUSBConnected", "(Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", "")]
		public unsafe static void IsUSBConnected(WebViewCallback callback)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((callback == null) ? IntPtr.Zero : callback.Handle);
				DeviceInfo._members.StaticMethods.InvokeVoidMethod("isUSBConnected.(Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", ptr);
			}
			finally
			{
				GC.KeepAlive(callback);
			}
		}

		// Token: 0x060011E8 RID: 4584 RVA: 0x00031808 File Offset: 0x0002FA08
		[Register("registerVolumeChangeListener", "(Ljava/lang/Integer;Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", "")]
		public unsafe static void RegisterVolumeChangeListener(Integer streamType, WebViewCallback callback)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((streamType == null) ? IntPtr.Zero : streamType.Handle);
				ptr[1] = new JniArgumentValue((callback == null) ? IntPtr.Zero : callback.Handle);
				DeviceInfo._members.StaticMethods.InvokeVoidMethod("registerVolumeChangeListener.(Ljava/lang/Integer;Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", ptr);
			}
			finally
			{
				GC.KeepAlive(streamType);
				GC.KeepAlive(callback);
			}
		}

		// Token: 0x060011E9 RID: 4585 RVA: 0x00031894 File Offset: 0x0002FA94
		[Register("unregisterVolumeChangeListener", "(Ljava/lang/Integer;Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", "")]
		public unsafe static void UnregisterVolumeChangeListener(Integer streamType, WebViewCallback callback)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((streamType == null) ? IntPtr.Zero : streamType.Handle);
				ptr[1] = new JniArgumentValue((callback == null) ? IntPtr.Zero : callback.Handle);
				DeviceInfo._members.StaticMethods.InvokeVoidMethod("unregisterVolumeChangeListener.(Ljava/lang/Integer;Lcom/unity3d/services/core/webview/bridge/WebViewCallback;)V", ptr);
			}
			finally
			{
				GC.KeepAlive(streamType);
				GC.KeepAlive(callback);
			}
		}

		// Token: 0x0400044B RID: 1099
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/services/core/api/DeviceInfo", typeof(DeviceInfo));

		// Token: 0x02000189 RID: 393
		[Register("com/unity3d/services/core/api/DeviceInfo$DeviceInfoEvent", DoNotGenerateAcw = true)]
		public sealed class DeviceInfoEvent : Java.Lang.Enum
		{
			// Token: 0x17000647 RID: 1607
			// (get) Token: 0x060011EB RID: 4587 RVA: 0x0003193C File Offset: 0x0002FB3C
			[Register("VOLUME_CHANGED")]
			public static DeviceInfo.DeviceInfoEvent VolumeChanged
			{
				get
				{
					return Java.Lang.Object.GetObject<DeviceInfo.DeviceInfoEvent>(DeviceInfo.DeviceInfoEvent._members.StaticFields.GetObjectValue("VOLUME_CHANGED.Lcom/unity3d/services/core/api/DeviceInfo$DeviceInfoEvent;").Handle, JniHandleOwnership.TransferLocalRef);
				}
			}

			// Token: 0x17000648 RID: 1608
			// (get) Token: 0x060011EC RID: 4588 RVA: 0x0003196C File Offset: 0x0002FB6C
			internal static IntPtr class_ref
			{
				get
				{
					return DeviceInfo.DeviceInfoEvent._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x17000649 RID: 1609
			// (get) Token: 0x060011ED RID: 4589 RVA: 0x00031990 File Offset: 0x0002FB90
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return DeviceInfo.DeviceInfoEvent._members;
				}
			}

			// Token: 0x1700064A RID: 1610
			// (get) Token: 0x060011EE RID: 4590 RVA: 0x00031998 File Offset: 0x0002FB98
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return DeviceInfo.DeviceInfoEvent._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x1700064B RID: 1611
			// (get) Token: 0x060011EF RID: 4591 RVA: 0x000319BC File Offset: 0x0002FBBC
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return DeviceInfo.DeviceInfoEvent._members.ManagedPeerType;
				}
			}

			// Token: 0x060011F0 RID: 4592 RVA: 0x0000256C File Offset: 0x0000076C
			internal DeviceInfoEvent(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
			{
			}

			// Token: 0x060011F1 RID: 4593 RVA: 0x000319C8 File Offset: 0x0002FBC8
			[Register("valueOf", "(Ljava/lang/String;)Lcom/unity3d/services/core/api/DeviceInfo$DeviceInfoEvent;", "")]
			public unsafe static DeviceInfo.DeviceInfoEvent ValueOf(string name)
			{
				IntPtr intPtr = JNIEnv.NewString(name);
				DeviceInfo.DeviceInfoEvent @object;
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue(intPtr);
					@object = Java.Lang.Object.GetObject<DeviceInfo.DeviceInfoEvent>(DeviceInfo.DeviceInfoEvent._members.StaticMethods.InvokeObjectMethod("valueOf.(Ljava/lang/String;)Lcom/unity3d/services/core/api/DeviceInfo$DeviceInfoEvent;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
				}
				finally
				{
					JNIEnv.DeleteLocalRef(intPtr);
				}
				return @object;
			}

			// Token: 0x060011F2 RID: 4594 RVA: 0x00031A34 File Offset: 0x0002FC34
			[Register("values", "()[Lcom/unity3d/services/core/api/DeviceInfo$DeviceInfoEvent;", "")]
			public static DeviceInfo.DeviceInfoEvent[] Values()
			{
				return (DeviceInfo.DeviceInfoEvent[])JNIEnv.GetArray(DeviceInfo.DeviceInfoEvent._members.StaticMethods.InvokeObjectMethod("values.()[Lcom/unity3d/services/core/api/DeviceInfo$DeviceInfoEvent;", null).Handle, JniHandleOwnership.TransferLocalRef, typeof(DeviceInfo.DeviceInfoEvent));
			}

			// Token: 0x0400044C RID: 1100
			private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/services/core/api/DeviceInfo$DeviceInfoEvent", typeof(DeviceInfo.DeviceInfoEvent));
		}

		// Token: 0x0200018A RID: 394
		[Register("com/unity3d/services/core/api/DeviceInfo$StorageType", DoNotGenerateAcw = true)]
		public sealed class StorageType : Java.Lang.Enum
		{
			// Token: 0x1700064C RID: 1612
			// (get) Token: 0x060011F4 RID: 4596 RVA: 0x00031A90 File Offset: 0x0002FC90
			[Register("EXTERNAL")]
			public static DeviceInfo.StorageType External
			{
				get
				{
					return Java.Lang.Object.GetObject<DeviceInfo.StorageType>(DeviceInfo.StorageType._members.StaticFields.GetObjectValue("EXTERNAL.Lcom/unity3d/services/core/api/DeviceInfo$StorageType;").Handle, JniHandleOwnership.TransferLocalRef);
				}
			}

			// Token: 0x1700064D RID: 1613
			// (get) Token: 0x060011F5 RID: 4597 RVA: 0x00031AC0 File Offset: 0x0002FCC0
			[Register("INTERNAL")]
			public static DeviceInfo.StorageType Internal
			{
				get
				{
					return Java.Lang.Object.GetObject<DeviceInfo.StorageType>(DeviceInfo.StorageType._members.StaticFields.GetObjectValue("INTERNAL.Lcom/unity3d/services/core/api/DeviceInfo$StorageType;").Handle, JniHandleOwnership.TransferLocalRef);
				}
			}

			// Token: 0x1700064E RID: 1614
			// (get) Token: 0x060011F6 RID: 4598 RVA: 0x00031AF0 File Offset: 0x0002FCF0
			internal static IntPtr class_ref
			{
				get
				{
					return DeviceInfo.StorageType._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x1700064F RID: 1615
			// (get) Token: 0x060011F7 RID: 4599 RVA: 0x00031B14 File Offset: 0x0002FD14
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return DeviceInfo.StorageType._members;
				}
			}

			// Token: 0x17000650 RID: 1616
			// (get) Token: 0x060011F8 RID: 4600 RVA: 0x00031B1C File Offset: 0x0002FD1C
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return DeviceInfo.StorageType._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x17000651 RID: 1617
			// (get) Token: 0x060011F9 RID: 4601 RVA: 0x00031B40 File Offset: 0x0002FD40
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return DeviceInfo.StorageType._members.ManagedPeerType;
				}
			}

			// Token: 0x060011FA RID: 4602 RVA: 0x0000256C File Offset: 0x0000076C
			internal StorageType(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
			{
			}

			// Token: 0x060011FB RID: 4603 RVA: 0x00031B4C File Offset: 0x0002FD4C
			[Register("valueOf", "(Ljava/lang/String;)Lcom/unity3d/services/core/api/DeviceInfo$StorageType;", "")]
			public unsafe static DeviceInfo.StorageType ValueOf(string name)
			{
				IntPtr intPtr = JNIEnv.NewString(name);
				DeviceInfo.StorageType @object;
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue(intPtr);
					@object = Java.Lang.Object.GetObject<DeviceInfo.StorageType>(DeviceInfo.StorageType._members.StaticMethods.InvokeObjectMethod("valueOf.(Ljava/lang/String;)Lcom/unity3d/services/core/api/DeviceInfo$StorageType;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
				}
				finally
				{
					JNIEnv.DeleteLocalRef(intPtr);
				}
				return @object;
			}

			// Token: 0x060011FC RID: 4604 RVA: 0x00031BB8 File Offset: 0x0002FDB8
			[Register("values", "()[Lcom/unity3d/services/core/api/DeviceInfo$StorageType;", "")]
			public static DeviceInfo.StorageType[] Values()
			{
				return (DeviceInfo.StorageType[])JNIEnv.GetArray(DeviceInfo.StorageType._members.StaticMethods.InvokeObjectMethod("values.()[Lcom/unity3d/services/core/api/DeviceInfo$StorageType;", null).Handle, JniHandleOwnership.TransferLocalRef, typeof(DeviceInfo.StorageType));
			}

			// Token: 0x0400044D RID: 1101
			private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/services/core/api/DeviceInfo$StorageType", typeof(DeviceInfo.StorageType));
		}
	}
}
