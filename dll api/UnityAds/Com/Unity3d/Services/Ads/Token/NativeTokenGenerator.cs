using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Com.Unity3d.Services.Core.Device.Reader;
using Java.Interop;
using Java.Lang;
using Java.Util.Concurrent;

namespace Com.Unity3d.Services.Ads.Token
{
	// Token: 0x020001DF RID: 479
	[Register("com/unity3d/services/ads/token/NativeTokenGenerator", DoNotGenerateAcw = true)]
	public class NativeTokenGenerator : Java.Lang.Object, INativeTokenGenerator, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x170007A4 RID: 1956
		// (get) Token: 0x060015D8 RID: 5592 RVA: 0x0003EA18 File Offset: 0x0003CC18
		internal static IntPtr class_ref
		{
			get
			{
				return NativeTokenGenerator._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170007A5 RID: 1957
		// (get) Token: 0x060015D9 RID: 5593 RVA: 0x0003EA3C File Offset: 0x0003CC3C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return NativeTokenGenerator._members;
			}
		}

		// Token: 0x170007A6 RID: 1958
		// (get) Token: 0x060015DA RID: 5594 RVA: 0x0003EA44 File Offset: 0x0003CC44
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return NativeTokenGenerator._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170007A7 RID: 1959
		// (get) Token: 0x060015DB RID: 5595 RVA: 0x0003EA68 File Offset: 0x0003CC68
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return NativeTokenGenerator._members.ManagedPeerType;
			}
		}

		// Token: 0x060015DC RID: 5596 RVA: 0x000021E8 File Offset: 0x000003E8
		protected NativeTokenGenerator(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x060015DD RID: 5597 RVA: 0x0003EA74 File Offset: 0x0003CC74
		[Register(".ctor", "(Ljava/util/concurrent/ExecutorService;Lcom/unity3d/services/core/device/reader/DeviceInfoReaderBuilder;)V", "")]
		public unsafe NativeTokenGenerator(IExecutorService executorService, DeviceInfoReaderBuilder deviceInfoReaderBuilder) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((executorService == null) ? IntPtr.Zero : ((Java.Lang.Object)executorService).Handle);
				ptr[1] = new JniArgumentValue((deviceInfoReaderBuilder == null) ? IntPtr.Zero : deviceInfoReaderBuilder.Handle);
				base.SetHandle(NativeTokenGenerator._members.InstanceMethods.StartCreateInstance("(Ljava/util/concurrent/ExecutorService;Lcom/unity3d/services/core/device/reader/DeviceInfoReaderBuilder;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				NativeTokenGenerator._members.InstanceMethods.FinishCreateInstance("(Ljava/util/concurrent/ExecutorService;Lcom/unity3d/services/core/device/reader/DeviceInfoReaderBuilder;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(executorService);
				GC.KeepAlive(deviceInfoReaderBuilder);
			}
		}

		// Token: 0x060015DE RID: 5598 RVA: 0x0003EB50 File Offset: 0x0003CD50
		[Register(".ctor", "(Ljava/util/concurrent/ExecutorService;Lcom/unity3d/services/core/device/reader/DeviceInfoReaderBuilder;Ljava/lang/String;)V", "")]
		public unsafe NativeTokenGenerator(IExecutorService executorService, DeviceInfoReaderBuilder deviceInfoReaderBuilder, string prependStr) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			IntPtr intPtr = JNIEnv.NewString(prependStr);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((executorService == null) ? IntPtr.Zero : ((Java.Lang.Object)executorService).Handle);
				ptr[1] = new JniArgumentValue((deviceInfoReaderBuilder == null) ? IntPtr.Zero : deviceInfoReaderBuilder.Handle);
				ptr[2] = new JniArgumentValue(intPtr);
				base.SetHandle(NativeTokenGenerator._members.InstanceMethods.StartCreateInstance("(Ljava/util/concurrent/ExecutorService;Lcom/unity3d/services/core/device/reader/DeviceInfoReaderBuilder;Ljava/lang/String;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				NativeTokenGenerator._members.InstanceMethods.FinishCreateInstance("(Ljava/util/concurrent/ExecutorService;Lcom/unity3d/services/core/device/reader/DeviceInfoReaderBuilder;Ljava/lang/String;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(executorService);
				GC.KeepAlive(deviceInfoReaderBuilder);
			}
		}

		// Token: 0x060015DF RID: 5599 RVA: 0x0003EC4C File Offset: 0x0003CE4C
		private static Delegate GetGenerateToken_Lcom_unity3d_services_ads_token_INativeTokenGeneratorListener_Handler()
		{
			if (NativeTokenGenerator.cb_generateToken_Lcom_unity3d_services_ads_token_INativeTokenGeneratorListener_ == null)
			{
				NativeTokenGenerator.cb_generateToken_Lcom_unity3d_services_ads_token_INativeTokenGeneratorListener_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(NativeTokenGenerator.n_GenerateToken_Lcom_unity3d_services_ads_token_INativeTokenGeneratorListener_));
			}
			return NativeTokenGenerator.cb_generateToken_Lcom_unity3d_services_ads_token_INativeTokenGeneratorListener_;
		}

		// Token: 0x060015E0 RID: 5600 RVA: 0x0003EC70 File Offset: 0x0003CE70
		private static void n_GenerateToken_Lcom_unity3d_services_ads_token_INativeTokenGeneratorListener_(IntPtr jnienv, IntPtr native__this, IntPtr native__callback)
		{
			NativeTokenGenerator @object = Java.Lang.Object.GetObject<NativeTokenGenerator>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			INativeTokenGeneratorListener object2 = Java.Lang.Object.GetObject<INativeTokenGeneratorListener>(native__callback, JniHandleOwnership.DoNotTransfer);
			@object.GenerateToken(object2);
		}

		// Token: 0x060015E1 RID: 5601 RVA: 0x0003EC94 File Offset: 0x0003CE94
		[Register("generateToken", "(Lcom/unity3d/services/ads/token/INativeTokenGeneratorListener;)V", "GetGenerateToken_Lcom_unity3d_services_ads_token_INativeTokenGeneratorListener_Handler")]
		public unsafe virtual void GenerateToken(INativeTokenGeneratorListener callback)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((callback == null) ? IntPtr.Zero : ((Java.Lang.Object)callback).Handle);
				NativeTokenGenerator._members.InstanceMethods.InvokeVirtualVoidMethod("generateToken.(Lcom/unity3d/services/ads/token/INativeTokenGeneratorListener;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(callback);
			}
		}

		// Token: 0x04000531 RID: 1329
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/services/ads/token/NativeTokenGenerator", typeof(NativeTokenGenerator));

		// Token: 0x04000532 RID: 1330
		private static Delegate cb_generateToken_Lcom_unity3d_services_ads_token_INativeTokenGeneratorListener_;
	}
}
