using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Gms.Common.Util;
using Android.Gms.Tasks;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Android.Gms.Common.Api.Internal
{
	// Token: 0x02000039 RID: 57
	[Register("com/google/android/gms/common/api/internal/TaskApiCall", DoNotGenerateAcw = true)]
	[JavaTypeParameters(new string[]
	{
		"A extends com.google.android.gms.common.api.Api.AnyClient",
		"ResultT"
	})]
	public abstract class TaskApiCall : Java.Lang.Object
	{
		// Token: 0x1700008C RID: 140
		// (get) Token: 0x06000217 RID: 535 RVA: 0x0000743C File Offset: 0x0000563C
		internal static IntPtr class_ref
		{
			get
			{
				return TaskApiCall._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700008D RID: 141
		// (get) Token: 0x06000218 RID: 536 RVA: 0x00007460 File Offset: 0x00005660
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return TaskApiCall._members;
			}
		}

		// Token: 0x1700008E RID: 142
		// (get) Token: 0x06000219 RID: 537 RVA: 0x00007468 File Offset: 0x00005668
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return TaskApiCall._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700008F RID: 143
		// (get) Token: 0x0600021A RID: 538 RVA: 0x0000748C File Offset: 0x0000568C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return TaskApiCall._members.ManagedPeerType;
			}
		}

		// Token: 0x0600021B RID: 539 RVA: 0x00003280 File Offset: 0x00001480
		protected TaskApiCall(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x0600021C RID: 540 RVA: 0x00007498 File Offset: 0x00005698
		[Register(".ctor", "()V", "")]
		public TaskApiCall() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			base.SetHandle(TaskApiCall._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
			TaskApiCall._members.InstanceMethods.FinishCreateInstance("()V", this, null);
		}

		// Token: 0x0600021D RID: 541 RVA: 0x00007508 File Offset: 0x00005708
		[Register(".ctor", "([Lcom/google/android/gms/common/Feature;ZI)V", "")]
		protected unsafe TaskApiCall(Feature[] features, bool autoResolveMissingFeatures, int methodKey) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			IntPtr intPtr = JNIEnv.NewArray<Feature>(features);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(autoResolveMissingFeatures);
				ptr[2] = new JniArgumentValue(methodKey);
				base.SetHandle(TaskApiCall._members.InstanceMethods.StartCreateInstance("([Lcom/google/android/gms/common/Feature;ZI)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				TaskApiCall._members.InstanceMethods.FinishCreateInstance("([Lcom/google/android/gms/common/Feature;ZI)V", this, ptr);
			}
			finally
			{
				if (features != null)
				{
					JNIEnv.CopyArray<Feature>(intPtr, features);
					JNIEnv.DeleteLocalRef(intPtr);
				}
				GC.KeepAlive(features);
			}
		}

		// Token: 0x0600021E RID: 542 RVA: 0x000075E8 File Offset: 0x000057E8
		[Register("builder", "()Lcom/google/android/gms/common/api/internal/TaskApiCall$Builder;", "")]
		[JavaTypeParameters(new string[]
		{
			"A extends com.google.android.gms.common.api.Api.AnyClient",
			"ResultT"
		})]
		public static TaskApiCall.Builder InvokeBuilder()
		{
			return Java.Lang.Object.GetObject<TaskApiCall.Builder>(TaskApiCall._members.StaticMethods.InvokeObjectMethod("builder.()Lcom/google/android/gms/common/api/internal/TaskApiCall$Builder;", null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x0600021F RID: 543 RVA: 0x00007619 File Offset: 0x00005819
		private static Delegate GetDoExecute_Lcom_google_android_gms_common_api_Api_AnyClient_Lcom_google_android_gms_tasks_TaskCompletionSource_Handler()
		{
			if (TaskApiCall.cb_doExecute_Lcom_google_android_gms_common_api_Api_AnyClient_Lcom_google_android_gms_tasks_TaskCompletionSource_ == null)
			{
				TaskApiCall.cb_doExecute_Lcom_google_android_gms_common_api_Api_AnyClient_Lcom_google_android_gms_tasks_TaskCompletionSource_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_V(TaskApiCall.n_DoExecute_Lcom_google_android_gms_common_api_Api_AnyClient_Lcom_google_android_gms_tasks_TaskCompletionSource_));
			}
			return TaskApiCall.cb_doExecute_Lcom_google_android_gms_common_api_Api_AnyClient_Lcom_google_android_gms_tasks_TaskCompletionSource_;
		}

		// Token: 0x06000220 RID: 544 RVA: 0x00007640 File Offset: 0x00005840
		private static void n_DoExecute_Lcom_google_android_gms_common_api_Api_AnyClient_Lcom_google_android_gms_tasks_TaskCompletionSource_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			TaskApiCall @object = Java.Lang.Object.GetObject<TaskApiCall>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_p0, JniHandleOwnership.DoNotTransfer);
			TaskCompletionSource object3 = Java.Lang.Object.GetObject<TaskCompletionSource>(native_p1, JniHandleOwnership.DoNotTransfer);
			@object.DoExecute(object2, object3);
		}

		// Token: 0x06000221 RID: 545
		[Register("doExecute", "(Lcom/google/android/gms/common/api/Api$AnyClient;Lcom/google/android/gms/tasks/TaskCompletionSource;)V", "GetDoExecute_Lcom_google_android_gms_common_api_Api_AnyClient_Lcom_google_android_gms_tasks_TaskCompletionSource_Handler")]
		protected abstract void DoExecute(Java.Lang.Object p0, TaskCompletionSource p1);

		// Token: 0x06000222 RID: 546 RVA: 0x0000766C File Offset: 0x0000586C
		private static Delegate GetShouldAutoResolveMissingFeaturesHandler()
		{
			if (TaskApiCall.cb_shouldAutoResolveMissingFeatures == null)
			{
				TaskApiCall.cb_shouldAutoResolveMissingFeatures = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(TaskApiCall.n_ShouldAutoResolveMissingFeatures));
			}
			return TaskApiCall.cb_shouldAutoResolveMissingFeatures;
		}

		// Token: 0x06000223 RID: 547 RVA: 0x00007690 File Offset: 0x00005890
		private static bool n_ShouldAutoResolveMissingFeatures(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<TaskApiCall>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ShouldAutoResolveMissingFeatures();
		}

		// Token: 0x06000224 RID: 548 RVA: 0x0000769F File Offset: 0x0000589F
		[Register("shouldAutoResolveMissingFeatures", "()Z", "GetShouldAutoResolveMissingFeaturesHandler")]
		public virtual bool ShouldAutoResolveMissingFeatures()
		{
			return TaskApiCall._members.InstanceMethods.InvokeVirtualBooleanMethod("shouldAutoResolveMissingFeatures.()Z", this, null);
		}

		// Token: 0x06000225 RID: 549 RVA: 0x000076B8 File Offset: 0x000058B8
		[Register("zaa", "()I", "")]
		public int Zaa()
		{
			return TaskApiCall._members.InstanceMethods.InvokeNonvirtualInt32Method("zaa.()I", this, null);
		}

		// Token: 0x06000226 RID: 550 RVA: 0x000076D4 File Offset: 0x000058D4
		[Register("zab", "()[Lcom/google/android/gms/common/Feature;", "")]
		public Feature[] Zab()
		{
			return (Feature[])JNIEnv.GetArray(TaskApiCall._members.InstanceMethods.InvokeNonvirtualObjectMethod("zab.()[Lcom/google/android/gms/common/Feature;", this, null).Handle, JniHandleOwnership.TransferLocalRef, typeof(Feature));
		}

		// Token: 0x04000070 RID: 112
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/google/android/gms/common/api/internal/TaskApiCall", typeof(TaskApiCall));

		// Token: 0x04000071 RID: 113
		private static Delegate cb_doExecute_Lcom_google_android_gms_common_api_Api_AnyClient_Lcom_google_android_gms_tasks_TaskCompletionSource_;

		// Token: 0x04000072 RID: 114
		private static Delegate cb_shouldAutoResolveMissingFeatures;

		// Token: 0x0200003A RID: 58
		[Register("com/google/android/gms/common/api/internal/TaskApiCall$Builder", DoNotGenerateAcw = true)]
		[JavaTypeParameters(new string[]
		{
			"A extends com.google.android.gms.common.api.Api.AnyClient",
			"ResultT"
		})]
		public class Builder : Java.Lang.Object
		{
			// Token: 0x17000090 RID: 144
			// (get) Token: 0x06000228 RID: 552 RVA: 0x00007730 File Offset: 0x00005930
			internal static IntPtr class_ref
			{
				get
				{
					return TaskApiCall.Builder._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x17000091 RID: 145
			// (get) Token: 0x06000229 RID: 553 RVA: 0x00007754 File Offset: 0x00005954
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return TaskApiCall.Builder._members;
				}
			}

			// Token: 0x17000092 RID: 146
			// (get) Token: 0x0600022A RID: 554 RVA: 0x0000775C File Offset: 0x0000595C
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return TaskApiCall.Builder._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x17000093 RID: 147
			// (get) Token: 0x0600022B RID: 555 RVA: 0x00007780 File Offset: 0x00005980
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return TaskApiCall.Builder._members.ManagedPeerType;
				}
			}

			// Token: 0x0600022C RID: 556 RVA: 0x00003280 File Offset: 0x00001480
			protected Builder(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
			{
			}

			// Token: 0x0600022D RID: 557 RVA: 0x0000778C File Offset: 0x0000598C
			private static Delegate GetBuildHandler()
			{
				if (TaskApiCall.Builder.cb_build == null)
				{
					TaskApiCall.Builder.cb_build = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(TaskApiCall.Builder.n_Build));
				}
				return TaskApiCall.Builder.cb_build;
			}

			// Token: 0x0600022E RID: 558 RVA: 0x000077B0 File Offset: 0x000059B0
			private static IntPtr n_Build(IntPtr jnienv, IntPtr native__this)
			{
				return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<TaskApiCall.Builder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Build());
			}

			// Token: 0x0600022F RID: 559 RVA: 0x000077C4 File Offset: 0x000059C4
			[Register("build", "()Lcom/google/android/gms/common/api/internal/TaskApiCall;", "GetBuildHandler")]
			public virtual TaskApiCall Build()
			{
				return Java.Lang.Object.GetObject<TaskApiCall>(TaskApiCall.Builder._members.InstanceMethods.InvokeVirtualObjectMethod("build.()Lcom/google/android/gms/common/api/internal/TaskApiCall;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}

			// Token: 0x06000230 RID: 560 RVA: 0x000077F6 File Offset: 0x000059F6
			private static Delegate GetExecute_Lcom_google_android_gms_common_util_BiConsumer_Handler()
			{
				if (TaskApiCall.Builder.cb_execute_Lcom_google_android_gms_common_util_BiConsumer_ == null)
				{
					TaskApiCall.Builder.cb_execute_Lcom_google_android_gms_common_util_BiConsumer_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(TaskApiCall.Builder.n_Execute_Lcom_google_android_gms_common_util_BiConsumer_));
				}
				return TaskApiCall.Builder.cb_execute_Lcom_google_android_gms_common_util_BiConsumer_;
			}

			// Token: 0x06000231 RID: 561 RVA: 0x0000781C File Offset: 0x00005A1C
			private static IntPtr n_Execute_Lcom_google_android_gms_common_util_BiConsumer_(IntPtr jnienv, IntPtr native__this, IntPtr native_consumer)
			{
				TaskApiCall.Builder @object = Java.Lang.Object.GetObject<TaskApiCall.Builder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				IBiConsumer object2 = Java.Lang.Object.GetObject<IBiConsumer>(native_consumer, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle(@object.Execute(object2));
			}

			// Token: 0x06000232 RID: 562 RVA: 0x00007844 File Offset: 0x00005A44
			[Register("execute", "(Lcom/google/android/gms/common/util/BiConsumer;)Lcom/google/android/gms/common/api/internal/TaskApiCall$Builder;", "GetExecute_Lcom_google_android_gms_common_util_BiConsumer_Handler")]
			public unsafe virtual TaskApiCall.Builder Execute(IBiConsumer consumer)
			{
				TaskApiCall.Builder @object;
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((consumer == null) ? IntPtr.Zero : ((Java.Lang.Object)consumer).Handle);
					@object = Java.Lang.Object.GetObject<TaskApiCall.Builder>(TaskApiCall.Builder._members.InstanceMethods.InvokeVirtualObjectMethod("execute.(Lcom/google/android/gms/common/util/BiConsumer;)Lcom/google/android/gms/common/api/internal/TaskApiCall$Builder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
				}
				finally
				{
					GC.KeepAlive(consumer);
				}
				return @object;
			}

			// Token: 0x06000233 RID: 563 RVA: 0x000078BC File Offset: 0x00005ABC
			private static Delegate GetRun_Lcom_google_android_gms_common_api_internal_RemoteCall_Handler()
			{
				if (TaskApiCall.Builder.cb_run_Lcom_google_android_gms_common_api_internal_RemoteCall_ == null)
				{
					TaskApiCall.Builder.cb_run_Lcom_google_android_gms_common_api_internal_RemoteCall_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(TaskApiCall.Builder.n_Run_Lcom_google_android_gms_common_api_internal_RemoteCall_));
				}
				return TaskApiCall.Builder.cb_run_Lcom_google_android_gms_common_api_internal_RemoteCall_;
			}

			// Token: 0x06000234 RID: 564 RVA: 0x000078E0 File Offset: 0x00005AE0
			private static IntPtr n_Run_Lcom_google_android_gms_common_api_internal_RemoteCall_(IntPtr jnienv, IntPtr native__this, IntPtr native_consumer)
			{
				TaskApiCall.Builder @object = Java.Lang.Object.GetObject<TaskApiCall.Builder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				IRemoteCall object2 = Java.Lang.Object.GetObject<IRemoteCall>(native_consumer, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle(@object.Run(object2));
			}

			// Token: 0x06000235 RID: 565 RVA: 0x00007908 File Offset: 0x00005B08
			[Register("run", "(Lcom/google/android/gms/common/api/internal/RemoteCall;)Lcom/google/android/gms/common/api/internal/TaskApiCall$Builder;", "GetRun_Lcom_google_android_gms_common_api_internal_RemoteCall_Handler")]
			public unsafe virtual TaskApiCall.Builder Run(IRemoteCall consumer)
			{
				TaskApiCall.Builder @object;
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((consumer == null) ? IntPtr.Zero : ((Java.Lang.Object)consumer).Handle);
					@object = Java.Lang.Object.GetObject<TaskApiCall.Builder>(TaskApiCall.Builder._members.InstanceMethods.InvokeVirtualObjectMethod("run.(Lcom/google/android/gms/common/api/internal/RemoteCall;)Lcom/google/android/gms/common/api/internal/TaskApiCall$Builder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
				}
				finally
				{
					GC.KeepAlive(consumer);
				}
				return @object;
			}

			// Token: 0x06000236 RID: 566 RVA: 0x00007980 File Offset: 0x00005B80
			private static Delegate GetSetAutoResolveMissingFeatures_ZHandler()
			{
				if (TaskApiCall.Builder.cb_setAutoResolveMissingFeatures_Z == null)
				{
					TaskApiCall.Builder.cb_setAutoResolveMissingFeatures_Z = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPZ_L(TaskApiCall.Builder.n_SetAutoResolveMissingFeatures_Z));
				}
				return TaskApiCall.Builder.cb_setAutoResolveMissingFeatures_Z;
			}

			// Token: 0x06000237 RID: 567 RVA: 0x000079A4 File Offset: 0x00005BA4
			private static IntPtr n_SetAutoResolveMissingFeatures_Z(IntPtr jnienv, IntPtr native__this, bool resolveMissingFeatures)
			{
				return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<TaskApiCall.Builder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SetAutoResolveMissingFeatures(resolveMissingFeatures));
			}

			// Token: 0x06000238 RID: 568 RVA: 0x000079BC File Offset: 0x00005BBC
			[Register("setAutoResolveMissingFeatures", "(Z)Lcom/google/android/gms/common/api/internal/TaskApiCall$Builder;", "GetSetAutoResolveMissingFeatures_ZHandler")]
			public unsafe virtual TaskApiCall.Builder SetAutoResolveMissingFeatures(bool resolveMissingFeatures)
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(resolveMissingFeatures);
				return Java.Lang.Object.GetObject<TaskApiCall.Builder>(TaskApiCall.Builder._members.InstanceMethods.InvokeVirtualObjectMethod("setAutoResolveMissingFeatures.(Z)Lcom/google/android/gms/common/api/internal/TaskApiCall$Builder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}

			// Token: 0x06000239 RID: 569 RVA: 0x00007A05 File Offset: 0x00005C05
			private static Delegate GetSetFeatures_arrayLcom_google_android_gms_common_Feature_Handler()
			{
				if (TaskApiCall.Builder.cb_setFeatures_arrayLcom_google_android_gms_common_Feature_ == null)
				{
					TaskApiCall.Builder.cb_setFeatures_arrayLcom_google_android_gms_common_Feature_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(TaskApiCall.Builder.n_SetFeatures_arrayLcom_google_android_gms_common_Feature_));
				}
				return TaskApiCall.Builder.cb_setFeatures_arrayLcom_google_android_gms_common_Feature_;
			}

			// Token: 0x0600023A RID: 570 RVA: 0x00007A2C File Offset: 0x00005C2C
			private static IntPtr n_SetFeatures_arrayLcom_google_android_gms_common_Feature_(IntPtr jnienv, IntPtr native__this, IntPtr native_features)
			{
				TaskApiCall.Builder @object = Java.Lang.Object.GetObject<TaskApiCall.Builder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				Feature[] array = (Feature[])JNIEnv.GetArray(native_features, JniHandleOwnership.DoNotTransfer, typeof(Feature));
				IntPtr result = JNIEnv.ToLocalJniHandle(@object.SetFeatures(array));
				if (array != null)
				{
					JNIEnv.CopyArray<Feature>(array, native_features);
				}
				return result;
			}

			// Token: 0x0600023B RID: 571 RVA: 0x00007A70 File Offset: 0x00005C70
			[Register("setFeatures", "([Lcom/google/android/gms/common/Feature;)Lcom/google/android/gms/common/api/internal/TaskApiCall$Builder;", "GetSetFeatures_arrayLcom_google_android_gms_common_Feature_Handler")]
			public unsafe virtual TaskApiCall.Builder SetFeatures(params Feature[] features)
			{
				IntPtr intPtr = JNIEnv.NewArray<Feature>(features);
				TaskApiCall.Builder @object;
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue(intPtr);
					@object = Java.Lang.Object.GetObject<TaskApiCall.Builder>(TaskApiCall.Builder._members.InstanceMethods.InvokeVirtualObjectMethod("setFeatures.([Lcom/google/android/gms/common/Feature;)Lcom/google/android/gms/common/api/internal/TaskApiCall$Builder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
				}
				finally
				{
					if (features != null)
					{
						JNIEnv.CopyArray<Feature>(intPtr, features);
						JNIEnv.DeleteLocalRef(intPtr);
					}
					GC.KeepAlive(features);
				}
				return @object;
			}

			// Token: 0x0600023C RID: 572 RVA: 0x00007AEC File Offset: 0x00005CEC
			private static Delegate GetSetMethodKey_IHandler()
			{
				if (TaskApiCall.Builder.cb_setMethodKey_I == null)
				{
					TaskApiCall.Builder.cb_setMethodKey_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPI_L(TaskApiCall.Builder.n_SetMethodKey_I));
				}
				return TaskApiCall.Builder.cb_setMethodKey_I;
			}

			// Token: 0x0600023D RID: 573 RVA: 0x00007B10 File Offset: 0x00005D10
			private static IntPtr n_SetMethodKey_I(IntPtr jnienv, IntPtr native__this, int methodKey)
			{
				return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<TaskApiCall.Builder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).SetMethodKey(methodKey));
			}

			// Token: 0x0600023E RID: 574 RVA: 0x00007B28 File Offset: 0x00005D28
			[Register("setMethodKey", "(I)Lcom/google/android/gms/common/api/internal/TaskApiCall$Builder;", "GetSetMethodKey_IHandler")]
			public unsafe virtual TaskApiCall.Builder SetMethodKey(int methodKey)
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(methodKey);
				return Java.Lang.Object.GetObject<TaskApiCall.Builder>(TaskApiCall.Builder._members.InstanceMethods.InvokeVirtualObjectMethod("setMethodKey.(I)Lcom/google/android/gms/common/api/internal/TaskApiCall$Builder;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}

			// Token: 0x04000073 RID: 115
			private static readonly JniPeerMembers _members = new XAPeerMembers("com/google/android/gms/common/api/internal/TaskApiCall$Builder", typeof(TaskApiCall.Builder));

			// Token: 0x04000074 RID: 116
			private static Delegate cb_build;

			// Token: 0x04000075 RID: 117
			private static Delegate cb_execute_Lcom_google_android_gms_common_util_BiConsumer_;

			// Token: 0x04000076 RID: 118
			private static Delegate cb_run_Lcom_google_android_gms_common_api_internal_RemoteCall_;

			// Token: 0x04000077 RID: 119
			private static Delegate cb_setAutoResolveMissingFeatures_Z;

			// Token: 0x04000078 RID: 120
			private static Delegate cb_setFeatures_arrayLcom_google_android_gms_common_Feature_;

			// Token: 0x04000079 RID: 121
			private static Delegate cb_setMethodKey_I;
		}
	}
}
