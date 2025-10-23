using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Com.Unity3d.Services.Core.Configuration;
using Java.Interop;
using Java.Lang;

namespace Com.Unity3d.Services.Core.Request.Metrics
{
	// Token: 0x020000C0 RID: 192
	[Register("com/unity3d/services/core/request/metrics/MetricCommonTags", DoNotGenerateAcw = true)]
	public class MetricCommonTags : Java.Lang.Object
	{
		// Token: 0x17000247 RID: 583
		// (get) Token: 0x0600072B RID: 1835 RVA: 0x00014338 File Offset: 0x00012538
		internal static IntPtr class_ref
		{
			get
			{
				return MetricCommonTags._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000248 RID: 584
		// (get) Token: 0x0600072C RID: 1836 RVA: 0x0001435C File Offset: 0x0001255C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return MetricCommonTags._members;
			}
		}

		// Token: 0x17000249 RID: 585
		// (get) Token: 0x0600072D RID: 1837 RVA: 0x00014364 File Offset: 0x00012564
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return MetricCommonTags._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700024A RID: 586
		// (get) Token: 0x0600072E RID: 1838 RVA: 0x00014388 File Offset: 0x00012588
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return MetricCommonTags._members.ManagedPeerType;
			}
		}

		// Token: 0x0600072F RID: 1839 RVA: 0x000021E8 File Offset: 0x000003E8
		protected MetricCommonTags(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000730 RID: 1840 RVA: 0x00014394 File Offset: 0x00012594
		[Register(".ctor", "()V", "")]
		public MetricCommonTags() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			base.SetHandle(MetricCommonTags._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
			MetricCommonTags._members.InstanceMethods.FinishCreateInstance("()V", this, null);
		}

		// Token: 0x06000731 RID: 1841 RVA: 0x00014402 File Offset: 0x00012602
		private static Delegate GetAsMapHandler()
		{
			if (MetricCommonTags.cb_asMap == null)
			{
				MetricCommonTags.cb_asMap = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(MetricCommonTags.n_AsMap));
			}
			return MetricCommonTags.cb_asMap;
		}

		// Token: 0x06000732 RID: 1842 RVA: 0x00014426 File Offset: 0x00012626
		private static IntPtr n_AsMap(IntPtr jnienv, IntPtr native__this)
		{
			return JavaDictionary<string, string>.ToLocalJniHandle(Java.Lang.Object.GetObject<MetricCommonTags>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).AsMap());
		}

		// Token: 0x06000733 RID: 1843 RVA: 0x0001443C File Offset: 0x0001263C
		[Register("asMap", "()Ljava/util/Map;", "GetAsMapHandler")]
		public virtual IDictionary<string, string> AsMap()
		{
			return JavaDictionary<string, string>.FromJniHandle(MetricCommonTags._members.InstanceMethods.InvokeVirtualObjectMethod("asMap.()Ljava/util/Map;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x06000734 RID: 1844 RVA: 0x0001446E File Offset: 0x0001266E
		private static Delegate GetShutdownHandler()
		{
			if (MetricCommonTags.cb_shutdown == null)
			{
				MetricCommonTags.cb_shutdown = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(MetricCommonTags.n_Shutdown));
			}
			return MetricCommonTags.cb_shutdown;
		}

		// Token: 0x06000735 RID: 1845 RVA: 0x00014492 File Offset: 0x00012692
		private static void n_Shutdown(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<MetricCommonTags>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Shutdown();
		}

		// Token: 0x06000736 RID: 1846 RVA: 0x000144A1 File Offset: 0x000126A1
		[Register("shutdown", "()V", "GetShutdownHandler")]
		public virtual void Shutdown()
		{
			MetricCommonTags._members.InstanceMethods.InvokeVirtualVoidMethod("shutdown.()V", this, null);
		}

		// Token: 0x06000737 RID: 1847 RVA: 0x000144BA File Offset: 0x000126BA
		private static Delegate GetUpdateWithConfig_Lcom_unity3d_services_core_configuration_Configuration_Handler()
		{
			if (MetricCommonTags.cb_updateWithConfig_Lcom_unity3d_services_core_configuration_Configuration_ == null)
			{
				MetricCommonTags.cb_updateWithConfig_Lcom_unity3d_services_core_configuration_Configuration_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(MetricCommonTags.n_UpdateWithConfig_Lcom_unity3d_services_core_configuration_Configuration_));
			}
			return MetricCommonTags.cb_updateWithConfig_Lcom_unity3d_services_core_configuration_Configuration_;
		}

		// Token: 0x06000738 RID: 1848 RVA: 0x000144E0 File Offset: 0x000126E0
		private static void n_UpdateWithConfig_Lcom_unity3d_services_core_configuration_Configuration_(IntPtr jnienv, IntPtr native__this, IntPtr native_config)
		{
			MetricCommonTags @object = Java.Lang.Object.GetObject<MetricCommonTags>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Configuration object2 = Java.Lang.Object.GetObject<Configuration>(native_config, JniHandleOwnership.DoNotTransfer);
			@object.UpdateWithConfig(object2);
		}

		// Token: 0x06000739 RID: 1849 RVA: 0x00014504 File Offset: 0x00012704
		[Register("updateWithConfig", "(Lcom/unity3d/services/core/configuration/Configuration;)V", "GetUpdateWithConfig_Lcom_unity3d_services_core_configuration_Configuration_Handler")]
		public unsafe virtual void UpdateWithConfig(Configuration config)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((config == null) ? IntPtr.Zero : config.Handle);
				MetricCommonTags._members.InstanceMethods.InvokeVirtualVoidMethod("updateWithConfig.(Lcom/unity3d/services/core/configuration/Configuration;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(config);
			}
		}

		// Token: 0x040001BD RID: 445
		[Register("METRIC_COMMON_TAG_PLATFORM_ANDROID")]
		public const string MetricCommonTagPlatformAndroid = "android";

		// Token: 0x040001BE RID: 446
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/services/core/request/metrics/MetricCommonTags", typeof(MetricCommonTags));

		// Token: 0x040001BF RID: 447
		private static Delegate cb_asMap;

		// Token: 0x040001C0 RID: 448
		private static Delegate cb_shutdown;

		// Token: 0x040001C1 RID: 449
		private static Delegate cb_updateWithConfig_Lcom_unity3d_services_core_configuration_Configuration_;
	}
}
