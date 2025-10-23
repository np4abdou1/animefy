using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Com.Unity3d.Services.Core.Request.Metrics
{
	// Token: 0x020000C5 RID: 197
	[Register("com/unity3d/services/core/request/metrics/TSIMetric", DoNotGenerateAcw = true)]
	public class TSIMetric : Java.Lang.Object
	{
		// Token: 0x1700025E RID: 606
		// (get) Token: 0x0600078F RID: 1935 RVA: 0x00015660 File Offset: 0x00013860
		internal static IntPtr class_ref
		{
			get
			{
				return TSIMetric._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700025F RID: 607
		// (get) Token: 0x06000790 RID: 1936 RVA: 0x00015684 File Offset: 0x00013884
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return TSIMetric._members;
			}
		}

		// Token: 0x17000260 RID: 608
		// (get) Token: 0x06000791 RID: 1937 RVA: 0x0001568C File Offset: 0x0001388C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return TSIMetric._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000261 RID: 609
		// (get) Token: 0x06000792 RID: 1938 RVA: 0x000156B0 File Offset: 0x000138B0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return TSIMetric._members.ManagedPeerType;
			}
		}

		// Token: 0x06000793 RID: 1939 RVA: 0x000021E8 File Offset: 0x000003E8
		protected TSIMetric(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000794 RID: 1940 RVA: 0x000156BC File Offset: 0x000138BC
		[Register(".ctor", "()V", "")]
		public TSIMetric() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			base.SetHandle(TSIMetric._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
			TSIMetric._members.InstanceMethods.FinishCreateInstance("()V", this, null);
		}

		// Token: 0x06000795 RID: 1941 RVA: 0x0001572C File Offset: 0x0001392C
		[Register("newAsyncTokenAvailable", "(Ljava/util/Map;)Lcom/unity3d/services/core/request/metrics/Metric;", "")]
		public unsafe static Metric NewAsyncTokenAvailable(IDictionary<string, string> tags)
		{
			IntPtr intPtr = JavaDictionary<string, string>.ToLocalJniHandle(tags);
			Metric @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<Metric>(TSIMetric._members.StaticMethods.InvokeObjectMethod("newAsyncTokenAvailable.(Ljava/util/Map;)Lcom/unity3d/services/core/request/metrics/Metric;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(tags);
			}
			return @object;
		}

		// Token: 0x06000796 RID: 1942 RVA: 0x0001579C File Offset: 0x0001399C
		[Register("newAsyncTokenNull", "(Ljava/util/Map;)Lcom/unity3d/services/core/request/metrics/Metric;", "")]
		public unsafe static Metric NewAsyncTokenNull(IDictionary<string, string> tags)
		{
			IntPtr intPtr = JavaDictionary<string, string>.ToLocalJniHandle(tags);
			Metric @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<Metric>(TSIMetric._members.StaticMethods.InvokeObjectMethod("newAsyncTokenNull.(Ljava/util/Map;)Lcom/unity3d/services/core/request/metrics/Metric;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(tags);
			}
			return @object;
		}

		// Token: 0x06000797 RID: 1943 RVA: 0x0001580C File Offset: 0x00013A0C
		[Register("newConfigRequestLatencyFailure", "(Ljava/lang/Long;)Lcom/unity3d/services/core/request/metrics/Metric;", "")]
		public unsafe static Metric NewConfigRequestLatencyFailure(Long value)
		{
			Metric @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((value == null) ? IntPtr.Zero : value.Handle);
				@object = Java.Lang.Object.GetObject<Metric>(TSIMetric._members.StaticMethods.InvokeObjectMethod("newConfigRequestLatencyFailure.(Ljava/lang/Long;)Lcom/unity3d/services/core/request/metrics/Metric;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(value);
			}
			return @object;
		}

		// Token: 0x06000798 RID: 1944 RVA: 0x00015880 File Offset: 0x00013A80
		[Register("newConfigRequestLatencySuccess", "(Ljava/lang/Long;)Lcom/unity3d/services/core/request/metrics/Metric;", "")]
		public unsafe static Metric NewConfigRequestLatencySuccess(Long value)
		{
			Metric @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((value == null) ? IntPtr.Zero : value.Handle);
				@object = Java.Lang.Object.GetObject<Metric>(TSIMetric._members.StaticMethods.InvokeObjectMethod("newConfigRequestLatencySuccess.(Ljava/lang/Long;)Lcom/unity3d/services/core/request/metrics/Metric;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(value);
			}
			return @object;
		}

		// Token: 0x06000799 RID: 1945 RVA: 0x000158F4 File Offset: 0x00013AF4
		[Register("newDeviceInfoCollectionLatency", "(Ljava/lang/Long;)Lcom/unity3d/services/core/request/metrics/Metric;", "")]
		public unsafe static Metric NewDeviceInfoCollectionLatency(Long value)
		{
			Metric @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((value == null) ? IntPtr.Zero : value.Handle);
				@object = Java.Lang.Object.GetObject<Metric>(TSIMetric._members.StaticMethods.InvokeObjectMethod("newDeviceInfoCollectionLatency.(Ljava/lang/Long;)Lcom/unity3d/services/core/request/metrics/Metric;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(value);
			}
			return @object;
		}

		// Token: 0x0600079A RID: 1946 RVA: 0x00015968 File Offset: 0x00013B68
		[Register("newDeviceInfoCompressionLatency", "(Ljava/lang/Long;)Lcom/unity3d/services/core/request/metrics/Metric;", "")]
		public unsafe static Metric NewDeviceInfoCompressionLatency(Long value)
		{
			Metric @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((value == null) ? IntPtr.Zero : value.Handle);
				@object = Java.Lang.Object.GetObject<Metric>(TSIMetric._members.StaticMethods.InvokeObjectMethod("newDeviceInfoCompressionLatency.(Ljava/lang/Long;)Lcom/unity3d/services/core/request/metrics/Metric;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(value);
			}
			return @object;
		}

		// Token: 0x0600079B RID: 1947 RVA: 0x000159DC File Offset: 0x00013BDC
		[Register("newEmergencySwitchOff", "()Lcom/unity3d/services/core/request/metrics/Metric;", "")]
		public static Metric NewEmergencySwitchOff()
		{
			return Java.Lang.Object.GetObject<Metric>(TSIMetric._members.StaticMethods.InvokeObjectMethod("newEmergencySwitchOff.()Lcom/unity3d/services/core/request/metrics/Metric;", null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x0600079C RID: 1948 RVA: 0x00015A10 File Offset: 0x00013C10
		[Register("newInitStarted", "()Lcom/unity3d/services/core/request/metrics/Metric;", "")]
		public static Metric NewInitStarted()
		{
			return Java.Lang.Object.GetObject<Metric>(TSIMetric._members.StaticMethods.InvokeObjectMethod("newInitStarted.()Lcom/unity3d/services/core/request/metrics/Metric;", null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x0600079D RID: 1949 RVA: 0x00015A44 File Offset: 0x00013C44
		[Register("newInitTimeFailure", "(Ljava/lang/Long;Ljava/util/Map;)Lcom/unity3d/services/core/request/metrics/Metric;", "")]
		public unsafe static Metric NewInitTimeFailure(Long value, IDictionary<string, string> tags)
		{
			IntPtr intPtr = JavaDictionary<string, string>.ToLocalJniHandle(tags);
			Metric @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((value == null) ? IntPtr.Zero : value.Handle);
				ptr[1] = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<Metric>(TSIMetric._members.StaticMethods.InvokeObjectMethod("newInitTimeFailure.(Ljava/lang/Long;Ljava/util/Map;)Lcom/unity3d/services/core/request/metrics/Metric;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(value);
				GC.KeepAlive(tags);
			}
			return @object;
		}

		// Token: 0x0600079E RID: 1950 RVA: 0x00015ADC File Offset: 0x00013CDC
		[Register("newInitTimeSuccess", "(Ljava/lang/Long;Ljava/util/Map;)Lcom/unity3d/services/core/request/metrics/Metric;", "")]
		public unsafe static Metric NewInitTimeSuccess(Long value, IDictionary<string, string> tags)
		{
			IntPtr intPtr = JavaDictionary<string, string>.ToLocalJniHandle(tags);
			Metric @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((value == null) ? IntPtr.Zero : value.Handle);
				ptr[1] = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<Metric>(TSIMetric._members.StaticMethods.InvokeObjectMethod("newInitTimeSuccess.(Ljava/lang/Long;Ljava/util/Map;)Lcom/unity3d/services/core/request/metrics/Metric;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(value);
				GC.KeepAlive(tags);
			}
			return @object;
		}

		// Token: 0x0600079F RID: 1951 RVA: 0x00015B74 File Offset: 0x00013D74
		[Register("newMissingGameSessionId", "()Lcom/unity3d/services/core/request/metrics/Metric;", "")]
		public static Metric NewMissingGameSessionId()
		{
			return Java.Lang.Object.GetObject<Metric>(TSIMetric._members.StaticMethods.InvokeObjectMethod("newMissingGameSessionId.()Lcom/unity3d/services/core/request/metrics/Metric;", null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x060007A0 RID: 1952 RVA: 0x00015BA8 File Offset: 0x00013DA8
		[Register("newMissingStateId", "()Lcom/unity3d/services/core/request/metrics/Metric;", "")]
		public static Metric NewMissingStateId()
		{
			return Java.Lang.Object.GetObject<Metric>(TSIMetric._members.StaticMethods.InvokeObjectMethod("newMissingStateId.()Lcom/unity3d/services/core/request/metrics/Metric;", null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x060007A1 RID: 1953 RVA: 0x00015BDC File Offset: 0x00013DDC
		[Register("newMissingToken", "()Lcom/unity3d/services/core/request/metrics/Metric;", "")]
		public static Metric NewMissingToken()
		{
			return Java.Lang.Object.GetObject<Metric>(TSIMetric._members.StaticMethods.InvokeObjectMethod("newMissingToken.()Lcom/unity3d/services/core/request/metrics/Metric;", null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x060007A2 RID: 1954 RVA: 0x00015C10 File Offset: 0x00013E10
		[Register("newNativeGeneratedTokenAvailable", "(Ljava/util/Map;)Lcom/unity3d/services/core/request/metrics/Metric;", "")]
		public unsafe static Metric NewNativeGeneratedTokenAvailable(IDictionary<string, string> tags)
		{
			IntPtr intPtr = JavaDictionary<string, string>.ToLocalJniHandle(tags);
			Metric @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<Metric>(TSIMetric._members.StaticMethods.InvokeObjectMethod("newNativeGeneratedTokenAvailable.(Ljava/util/Map;)Lcom/unity3d/services/core/request/metrics/Metric;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(tags);
			}
			return @object;
		}

		// Token: 0x060007A3 RID: 1955 RVA: 0x00015C80 File Offset: 0x00013E80
		[Register("newNativeGeneratedTokenNull", "(Ljava/util/Map;)Lcom/unity3d/services/core/request/metrics/Metric;", "")]
		public unsafe static Metric NewNativeGeneratedTokenNull(IDictionary<string, string> tags)
		{
			IntPtr intPtr = JavaDictionary<string, string>.ToLocalJniHandle(tags);
			Metric @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<Metric>(TSIMetric._members.StaticMethods.InvokeObjectMethod("newNativeGeneratedTokenNull.(Ljava/util/Map;)Lcom/unity3d/services/core/request/metrics/Metric;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(tags);
			}
			return @object;
		}

		// Token: 0x060007A4 RID: 1956 RVA: 0x00015CF0 File Offset: 0x00013EF0
		[Register("newPrivacyRequestLatencyFailure", "(Ljava/lang/Long;)Lcom/unity3d/services/core/request/metrics/Metric;", "")]
		public unsafe static Metric NewPrivacyRequestLatencyFailure(Long value)
		{
			Metric @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((value == null) ? IntPtr.Zero : value.Handle);
				@object = Java.Lang.Object.GetObject<Metric>(TSIMetric._members.StaticMethods.InvokeObjectMethod("newPrivacyRequestLatencyFailure.(Ljava/lang/Long;)Lcom/unity3d/services/core/request/metrics/Metric;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(value);
			}
			return @object;
		}

		// Token: 0x060007A5 RID: 1957 RVA: 0x00015D64 File Offset: 0x00013F64
		[Register("newPrivacyRequestLatencySuccess", "(Ljava/lang/Long;)Lcom/unity3d/services/core/request/metrics/Metric;", "")]
		public unsafe static Metric NewPrivacyRequestLatencySuccess(Long value)
		{
			Metric @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((value == null) ? IntPtr.Zero : value.Handle);
				@object = Java.Lang.Object.GetObject<Metric>(TSIMetric._members.StaticMethods.InvokeObjectMethod("newPrivacyRequestLatencySuccess.(Ljava/lang/Long;)Lcom/unity3d/services/core/request/metrics/Metric;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(value);
			}
			return @object;
		}

		// Token: 0x060007A6 RID: 1958 RVA: 0x00015DD8 File Offset: 0x00013FD8
		[Register("newPrivacyResolutionRequestLatencyFailure", "(Ljava/lang/Long;)Lcom/unity3d/services/core/request/metrics/Metric;", "")]
		public unsafe static Metric NewPrivacyResolutionRequestLatencyFailure(Long value)
		{
			Metric @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((value == null) ? IntPtr.Zero : value.Handle);
				@object = Java.Lang.Object.GetObject<Metric>(TSIMetric._members.StaticMethods.InvokeObjectMethod("newPrivacyResolutionRequestLatencyFailure.(Ljava/lang/Long;)Lcom/unity3d/services/core/request/metrics/Metric;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(value);
			}
			return @object;
		}

		// Token: 0x060007A7 RID: 1959 RVA: 0x00015E4C File Offset: 0x0001404C
		[Register("newPrivacyResolutionRequestLatencySuccess", "(Ljava/lang/Long;)Lcom/unity3d/services/core/request/metrics/Metric;", "")]
		public unsafe static Metric NewPrivacyResolutionRequestLatencySuccess(Long value)
		{
			Metric @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((value == null) ? IntPtr.Zero : value.Handle);
				@object = Java.Lang.Object.GetObject<Metric>(TSIMetric._members.StaticMethods.InvokeObjectMethod("newPrivacyResolutionRequestLatencySuccess.(Ljava/lang/Long;)Lcom/unity3d/services/core/request/metrics/Metric;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(value);
			}
			return @object;
		}

		// Token: 0x060007A8 RID: 1960 RVA: 0x00015EC0 File Offset: 0x000140C0
		[Register("newTokenAvailabilityLatencyConfig", "(Ljava/lang/Long;Ljava/util/Map;)Lcom/unity3d/services/core/request/metrics/Metric;", "")]
		public unsafe static Metric NewTokenAvailabilityLatencyConfig(Long value, IDictionary<string, string> tags)
		{
			IntPtr intPtr = JavaDictionary<string, string>.ToLocalJniHandle(tags);
			Metric @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((value == null) ? IntPtr.Zero : value.Handle);
				ptr[1] = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<Metric>(TSIMetric._members.StaticMethods.InvokeObjectMethod("newTokenAvailabilityLatencyConfig.(Ljava/lang/Long;Ljava/util/Map;)Lcom/unity3d/services/core/request/metrics/Metric;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(value);
				GC.KeepAlive(tags);
			}
			return @object;
		}

		// Token: 0x060007A9 RID: 1961 RVA: 0x00015F58 File Offset: 0x00014158
		[Register("newTokenAvailabilityLatencyWebview", "(Ljava/lang/Long;Ljava/util/Map;)Lcom/unity3d/services/core/request/metrics/Metric;", "")]
		public unsafe static Metric NewTokenAvailabilityLatencyWebview(Long value, IDictionary<string, string> tags)
		{
			IntPtr intPtr = JavaDictionary<string, string>.ToLocalJniHandle(tags);
			Metric @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((value == null) ? IntPtr.Zero : value.Handle);
				ptr[1] = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<Metric>(TSIMetric._members.StaticMethods.InvokeObjectMethod("newTokenAvailabilityLatencyWebview.(Ljava/lang/Long;Ljava/util/Map;)Lcom/unity3d/services/core/request/metrics/Metric;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(value);
				GC.KeepAlive(tags);
			}
			return @object;
		}

		// Token: 0x060007AA RID: 1962 RVA: 0x00015FF0 File Offset: 0x000141F0
		[Register("newTokenResolutionRequestLatency", "(Ljava/lang/Long;Ljava/util/Map;)Lcom/unity3d/services/core/request/metrics/Metric;", "")]
		public unsafe static Metric NewTokenResolutionRequestLatency(Long value, IDictionary<string, string> tags)
		{
			IntPtr intPtr = JavaDictionary<string, string>.ToLocalJniHandle(tags);
			Metric @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((value == null) ? IntPtr.Zero : value.Handle);
				ptr[1] = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<Metric>(TSIMetric._members.StaticMethods.InvokeObjectMethod("newTokenResolutionRequestLatency.(Ljava/lang/Long;Ljava/util/Map;)Lcom/unity3d/services/core/request/metrics/Metric;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(value);
				GC.KeepAlive(tags);
			}
			return @object;
		}

		// Token: 0x040001D8 RID: 472
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/services/core/request/metrics/TSIMetric", typeof(TSIMetric));
	}
}
