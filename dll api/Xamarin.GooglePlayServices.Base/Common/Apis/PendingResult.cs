using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;
using Java.Util.Concurrent;

namespace Android.Gms.Common.Apis
{
	// Token: 0x02000064 RID: 100
	[Register("com/google/android/gms/common/api/PendingResult", DoNotGenerateAcw = true)]
	[JavaTypeParameters(new string[]
	{
		"R extends com.google.android.gms.common.api.Result"
	})]
	public abstract class PendingResult : Java.Lang.Object
	{
		// Token: 0x1700012A RID: 298
		// (get) Token: 0x06000466 RID: 1126 RVA: 0x0000D804 File Offset: 0x0000BA04
		internal static IntPtr class_ref
		{
			get
			{
				return PendingResult._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700012B RID: 299
		// (get) Token: 0x06000467 RID: 1127 RVA: 0x0000D828 File Offset: 0x0000BA28
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return PendingResult._members;
			}
		}

		// Token: 0x1700012C RID: 300
		// (get) Token: 0x06000468 RID: 1128 RVA: 0x0000D830 File Offset: 0x0000BA30
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return PendingResult._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700012D RID: 301
		// (get) Token: 0x06000469 RID: 1129 RVA: 0x0000D854 File Offset: 0x0000BA54
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return PendingResult._members.ManagedPeerType;
			}
		}

		// Token: 0x0600046A RID: 1130 RVA: 0x00003280 File Offset: 0x00001480
		protected PendingResult(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x0600046B RID: 1131 RVA: 0x0000D860 File Offset: 0x0000BA60
		[Register(".ctor", "()V", "")]
		public PendingResult() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			base.SetHandle(PendingResult._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
			PendingResult._members.InstanceMethods.FinishCreateInstance("()V", this, null);
		}

		// Token: 0x0600046C RID: 1132 RVA: 0x0000D8CE File Offset: 0x0000BACE
		private static Delegate GetIsCanceledHandler()
		{
			if (PendingResult.cb_isCanceled == null)
			{
				PendingResult.cb_isCanceled = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_Z(PendingResult.n_IsCanceled));
			}
			return PendingResult.cb_isCanceled;
		}

		// Token: 0x0600046D RID: 1133 RVA: 0x0000D8F2 File Offset: 0x0000BAF2
		private static bool n_IsCanceled(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<PendingResult>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).IsCanceled;
		}

		// Token: 0x1700012E RID: 302
		// (get) Token: 0x0600046E RID: 1134
		public abstract bool IsCanceled { [Register("isCanceled", "()Z", "GetIsCanceledHandler")] get; }

		// Token: 0x0600046F RID: 1135 RVA: 0x0000D901 File Offset: 0x0000BB01
		private static Delegate GetAddStatusListener_Lcom_google_android_gms_common_api_PendingResult_StatusListener_Handler()
		{
			if (PendingResult.cb_addStatusListener_Lcom_google_android_gms_common_api_PendingResult_StatusListener_ == null)
			{
				PendingResult.cb_addStatusListener_Lcom_google_android_gms_common_api_PendingResult_StatusListener_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(PendingResult.n_AddStatusListener_Lcom_google_android_gms_common_api_PendingResult_StatusListener_));
			}
			return PendingResult.cb_addStatusListener_Lcom_google_android_gms_common_api_PendingResult_StatusListener_;
		}

		// Token: 0x06000470 RID: 1136 RVA: 0x0000D928 File Offset: 0x0000BB28
		private static void n_AddStatusListener_Lcom_google_android_gms_common_api_PendingResult_StatusListener_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			PendingResult @object = Java.Lang.Object.GetObject<PendingResult>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			PendingResult.IStatusListener object2 = Java.Lang.Object.GetObject<PendingResult.IStatusListener>(native_p0, JniHandleOwnership.DoNotTransfer);
			@object.AddStatusListener(object2);
		}

		// Token: 0x06000471 RID: 1137 RVA: 0x0000D94C File Offset: 0x0000BB4C
		[Register("addStatusListener", "(Lcom/google/android/gms/common/api/PendingResult$StatusListener;)V", "GetAddStatusListener_Lcom_google_android_gms_common_api_PendingResult_StatusListener_Handler")]
		public unsafe virtual void AddStatusListener(PendingResult.IStatusListener p0)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((p0 == null) ? IntPtr.Zero : ((Java.Lang.Object)p0).Handle);
				PendingResult._members.InstanceMethods.InvokeVirtualVoidMethod("addStatusListener.(Lcom/google/android/gms/common/api/PendingResult$StatusListener;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(p0);
			}
		}

		// Token: 0x06000472 RID: 1138 RVA: 0x0000D9B4 File Offset: 0x0000BBB4
		private static Delegate GetAwaitHandler()
		{
			if (PendingResult.cb_await == null)
			{
				PendingResult.cb_await = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(PendingResult.n_Await));
			}
			return PendingResult.cb_await;
		}

		// Token: 0x06000473 RID: 1139 RVA: 0x0000D9D8 File Offset: 0x0000BBD8
		private static IntPtr n_Await(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<PendingResult>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Await());
		}

		// Token: 0x06000474 RID: 1140
		[Register("await", "()Lcom/google/android/gms/common/api/Result;", "GetAwaitHandler")]
		public abstract Java.Lang.Object Await();

		// Token: 0x06000475 RID: 1141 RVA: 0x0000D9EC File Offset: 0x0000BBEC
		private static Delegate GetAwait_JLjava_util_concurrent_TimeUnit_Handler()
		{
			if (PendingResult.cb_await_JLjava_util_concurrent_TimeUnit_ == null)
			{
				PendingResult.cb_await_JLjava_util_concurrent_TimeUnit_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPJL_L(PendingResult.n_Await_JLjava_util_concurrent_TimeUnit_));
			}
			return PendingResult.cb_await_JLjava_util_concurrent_TimeUnit_;
		}

		// Token: 0x06000476 RID: 1142 RVA: 0x0000DA10 File Offset: 0x0000BC10
		private static IntPtr n_Await_JLjava_util_concurrent_TimeUnit_(IntPtr jnienv, IntPtr native__this, long p0, IntPtr native_p1)
		{
			PendingResult @object = Java.Lang.Object.GetObject<PendingResult>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			TimeUnit object2 = Java.Lang.Object.GetObject<TimeUnit>(native_p1, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.Await(p0, object2));
		}

		// Token: 0x06000477 RID: 1143
		[Register("await", "(JLjava/util/concurrent/TimeUnit;)Lcom/google/android/gms/common/api/Result;", "GetAwait_JLjava_util_concurrent_TimeUnit_Handler")]
		public abstract Java.Lang.Object Await(long p0, TimeUnit p1);

		// Token: 0x06000478 RID: 1144 RVA: 0x0000DA39 File Offset: 0x0000BC39
		private static Delegate GetCancelHandler()
		{
			if (PendingResult.cb_cancel == null)
			{
				PendingResult.cb_cancel = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(PendingResult.n_Cancel));
			}
			return PendingResult.cb_cancel;
		}

		// Token: 0x06000479 RID: 1145 RVA: 0x0000DA5D File Offset: 0x0000BC5D
		private static void n_Cancel(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<PendingResult>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Cancel();
		}

		// Token: 0x0600047A RID: 1146
		[Register("cancel", "()V", "GetCancelHandler")]
		public abstract void Cancel();

		// Token: 0x0600047B RID: 1147 RVA: 0x0000DA6C File Offset: 0x0000BC6C
		private static Delegate GetSetResultCallback_Lcom_google_android_gms_common_api_ResultCallback_Handler()
		{
			if (PendingResult.cb_setResultCallback_Lcom_google_android_gms_common_api_ResultCallback_ == null)
			{
				PendingResult.cb_setResultCallback_Lcom_google_android_gms_common_api_ResultCallback_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(PendingResult.n_SetResultCallback_Lcom_google_android_gms_common_api_ResultCallback_));
			}
			return PendingResult.cb_setResultCallback_Lcom_google_android_gms_common_api_ResultCallback_;
		}

		// Token: 0x0600047C RID: 1148 RVA: 0x0000DA90 File Offset: 0x0000BC90
		private static void n_SetResultCallback_Lcom_google_android_gms_common_api_ResultCallback_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			PendingResult @object = Java.Lang.Object.GetObject<PendingResult>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IResultCallback object2 = Java.Lang.Object.GetObject<IResultCallback>(native_p0, JniHandleOwnership.DoNotTransfer);
			@object.SetResultCallback(object2);
		}

		// Token: 0x0600047D RID: 1149
		[Register("setResultCallback", "(Lcom/google/android/gms/common/api/ResultCallback;)V", "GetSetResultCallback_Lcom_google_android_gms_common_api_ResultCallback_Handler")]
		public abstract void SetResultCallback(IResultCallback p0);

		// Token: 0x0600047E RID: 1150 RVA: 0x0000DAB3 File Offset: 0x0000BCB3
		private static Delegate GetSetResultCallback_Lcom_google_android_gms_common_api_ResultCallback_JLjava_util_concurrent_TimeUnit_Handler()
		{
			if (PendingResult.cb_setResultCallback_Lcom_google_android_gms_common_api_ResultCallback_JLjava_util_concurrent_TimeUnit_ == null)
			{
				PendingResult.cb_setResultCallback_Lcom_google_android_gms_common_api_ResultCallback_JLjava_util_concurrent_TimeUnit_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLJL_V(PendingResult.n_SetResultCallback_Lcom_google_android_gms_common_api_ResultCallback_JLjava_util_concurrent_TimeUnit_));
			}
			return PendingResult.cb_setResultCallback_Lcom_google_android_gms_common_api_ResultCallback_JLjava_util_concurrent_TimeUnit_;
		}

		// Token: 0x0600047F RID: 1151 RVA: 0x0000DAD8 File Offset: 0x0000BCD8
		private static void n_SetResultCallback_Lcom_google_android_gms_common_api_ResultCallback_JLjava_util_concurrent_TimeUnit_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, long p1, IntPtr native_p2)
		{
			PendingResult @object = Java.Lang.Object.GetObject<PendingResult>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IResultCallback object2 = Java.Lang.Object.GetObject<IResultCallback>(native_p0, JniHandleOwnership.DoNotTransfer);
			TimeUnit object3 = Java.Lang.Object.GetObject<TimeUnit>(native_p2, JniHandleOwnership.DoNotTransfer);
			@object.SetResultCallback(object2, p1, object3);
		}

		// Token: 0x06000480 RID: 1152
		[Register("setResultCallback", "(Lcom/google/android/gms/common/api/ResultCallback;JLjava/util/concurrent/TimeUnit;)V", "GetSetResultCallback_Lcom_google_android_gms_common_api_ResultCallback_JLjava_util_concurrent_TimeUnit_Handler")]
		public abstract void SetResultCallback(IResultCallback p0, long p1, TimeUnit p2);

		// Token: 0x06000481 RID: 1153 RVA: 0x0000DB06 File Offset: 0x0000BD06
		private static Delegate GetThen_Lcom_google_android_gms_common_api_ResultTransform_Handler()
		{
			if (PendingResult.cb_then_Lcom_google_android_gms_common_api_ResultTransform_ == null)
			{
				PendingResult.cb_then_Lcom_google_android_gms_common_api_ResultTransform_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(PendingResult.n_Then_Lcom_google_android_gms_common_api_ResultTransform_));
			}
			return PendingResult.cb_then_Lcom_google_android_gms_common_api_ResultTransform_;
		}

		// Token: 0x06000482 RID: 1154 RVA: 0x0000DB2C File Offset: 0x0000BD2C
		private static IntPtr n_Then_Lcom_google_android_gms_common_api_ResultTransform_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			PendingResult @object = Java.Lang.Object.GetObject<PendingResult>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ResultTransform object2 = Java.Lang.Object.GetObject<ResultTransform>(native_p0, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.Then(object2));
		}

		// Token: 0x06000483 RID: 1155 RVA: 0x0000DB54 File Offset: 0x0000BD54
		[Register("then", "(Lcom/google/android/gms/common/api/ResultTransform;)Lcom/google/android/gms/common/api/TransformedResult;", "GetThen_Lcom_google_android_gms_common_api_ResultTransform_Handler")]
		[JavaTypeParameters(new string[]
		{
			"S extends com.google.android.gms.common.api.Result"
		})]
		public unsafe virtual TransformedResult Then(ResultTransform p0)
		{
			TransformedResult @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((p0 == null) ? IntPtr.Zero : p0.Handle);
				@object = Java.Lang.Object.GetObject<TransformedResult>(PendingResult._members.InstanceMethods.InvokeVirtualObjectMethod("then.(Lcom/google/android/gms/common/api/ResultTransform;)Lcom/google/android/gms/common/api/TransformedResult;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(p0);
			}
			return @object;
		}

		// Token: 0x14000002 RID: 2
		// (add) Token: 0x06000484 RID: 1156 RVA: 0x0000DBC8 File Offset: 0x0000BDC8
		// (remove) Token: 0x06000485 RID: 1157 RVA: 0x0000DC14 File Offset: 0x0000BE14
		public event EventHandler<PendingResult.StatusEventArgs> Status
		{
			add
			{
				EventHelper.AddEventHandler<PendingResult.IStatusListener, PendingResult.IStatusListenerImplementor>(ref this.weak_implementor_AddStatusListener, new Func<PendingResult.IStatusListenerImplementor>(this.__CreateIStatusListenerImplementor), new Action<PendingResult.IStatusListener>(this.AddStatusListener), delegate(PendingResult.IStatusListenerImplementor __h)
				{
					__h.Handler = (EventHandler<PendingResult.StatusEventArgs>)Delegate.Combine(__h.Handler, value);
				});
			}
			remove
			{
				EventHelper.RemoveEventHandler<PendingResult.IStatusListener, PendingResult.IStatusListenerImplementor>(ref this.weak_implementor_AddStatusListener, new Func<PendingResult.IStatusListenerImplementor, bool>(PendingResult.IStatusListenerImplementor.__IsEmpty), delegate(PendingResult.IStatusListener __v)
				{
					throw new NotSupportedException("Cannot unregister from Android.Gms.Common.Apis.PendingResult.IStatusListener.AddStatusListener");
				}, delegate(PendingResult.IStatusListenerImplementor __h)
				{
					__h.Handler = (EventHandler<PendingResult.StatusEventArgs>)Delegate.Remove(__h.Handler, value);
				});
			}
		}

		// Token: 0x06000486 RID: 1158 RVA: 0x00004FE4 File Offset: 0x000031E4
		private PendingResult.IStatusListenerImplementor __CreateIStatusListenerImplementor()
		{
			return new PendingResult.IStatusListenerImplementor(this);
		}

		// Token: 0x04000107 RID: 263
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/google/android/gms/common/api/PendingResult", typeof(PendingResult));

		// Token: 0x04000108 RID: 264
		private static Delegate cb_isCanceled;

		// Token: 0x04000109 RID: 265
		private static Delegate cb_addStatusListener_Lcom_google_android_gms_common_api_PendingResult_StatusListener_;

		// Token: 0x0400010A RID: 266
		private static Delegate cb_await;

		// Token: 0x0400010B RID: 267
		private static Delegate cb_await_JLjava_util_concurrent_TimeUnit_;

		// Token: 0x0400010C RID: 268
		private static Delegate cb_cancel;

		// Token: 0x0400010D RID: 269
		private static Delegate cb_setResultCallback_Lcom_google_android_gms_common_api_ResultCallback_;

		// Token: 0x0400010E RID: 270
		private static Delegate cb_setResultCallback_Lcom_google_android_gms_common_api_ResultCallback_JLjava_util_concurrent_TimeUnit_;

		// Token: 0x0400010F RID: 271
		private static Delegate cb_then_Lcom_google_android_gms_common_api_ResultTransform_;

		// Token: 0x04000110 RID: 272
		private WeakReference weak_implementor_AddStatusListener;

		// Token: 0x02000065 RID: 101
		[Register("com/google/android/gms/common/api/PendingResult$StatusListener", "", "Android.Gms.Common.Apis.PendingResult/IStatusListenerInvoker")]
		public interface IStatusListener : IJavaObject, IDisposable, IJavaPeerable
		{
			// Token: 0x06000488 RID: 1160
			[Register("onComplete", "(Lcom/google/android/gms/common/api/Status;)V", "GetOnComplete_Lcom_google_android_gms_common_api_Status_Handler:Android.Gms.Common.Apis.PendingResult/IStatusListenerInvoker, Xamarin.GooglePlayServices.Base")]
			void OnComplete(Statuses p0);
		}

		// Token: 0x02000066 RID: 102
		[Register("com/google/android/gms/common/api/PendingResult$StatusListener", DoNotGenerateAcw = true)]
		internal class IStatusListenerInvoker : Java.Lang.Object, PendingResult.IStatusListener, IJavaObject, IDisposable, IJavaPeerable
		{
			// Token: 0x1700012F RID: 303
			// (get) Token: 0x06000489 RID: 1161 RVA: 0x0000DC8C File Offset: 0x0000BE8C
			private static IntPtr java_class_ref
			{
				get
				{
					return PendingResult.IStatusListenerInvoker._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x17000130 RID: 304
			// (get) Token: 0x0600048A RID: 1162 RVA: 0x0000DCB0 File Offset: 0x0000BEB0
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return PendingResult.IStatusListenerInvoker._members;
				}
			}

			// Token: 0x17000131 RID: 305
			// (get) Token: 0x0600048B RID: 1163 RVA: 0x0000DCB7 File Offset: 0x0000BEB7
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return this.class_ref;
				}
			}

			// Token: 0x17000132 RID: 306
			// (get) Token: 0x0600048C RID: 1164 RVA: 0x0000DCBF File Offset: 0x0000BEBF
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return PendingResult.IStatusListenerInvoker._members.ManagedPeerType;
				}
			}

			// Token: 0x0600048D RID: 1165 RVA: 0x0000DCCB File Offset: 0x0000BECB
			public static PendingResult.IStatusListener GetObject(IntPtr handle, JniHandleOwnership transfer)
			{
				return Java.Lang.Object.GetObject<PendingResult.IStatusListener>(handle, transfer);
			}

			// Token: 0x0600048E RID: 1166 RVA: 0x0000DCD4 File Offset: 0x0000BED4
			private static IntPtr Validate(IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf(handle, PendingResult.IStatusListenerInvoker.java_class_ref))
				{
					throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'com.google.android.gms.common.api.PendingResult.StatusListener'.");
				}
				return handle;
			}

			// Token: 0x0600048F RID: 1167 RVA: 0x0000DCFF File Offset: 0x0000BEFF
			protected override void Dispose(bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
				{
					JNIEnv.DeleteGlobalRef(this.class_ref);
				}
				this.class_ref = IntPtr.Zero;
				base.Dispose(disposing);
			}

			// Token: 0x06000490 RID: 1168 RVA: 0x0000DD30 File Offset: 0x0000BF30
			public IStatusListenerInvoker(IntPtr handle, JniHandleOwnership transfer) : base(PendingResult.IStatusListenerInvoker.Validate(handle), transfer)
			{
				IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
				this.class_ref = JNIEnv.NewGlobalRef(objectClass);
				JNIEnv.DeleteLocalRef(objectClass);
			}

			// Token: 0x06000491 RID: 1169 RVA: 0x0000DD68 File Offset: 0x0000BF68
			private static Delegate GetOnComplete_Lcom_google_android_gms_common_api_Status_Handler()
			{
				if (PendingResult.IStatusListenerInvoker.cb_onComplete_Lcom_google_android_gms_common_api_Status_ == null)
				{
					PendingResult.IStatusListenerInvoker.cb_onComplete_Lcom_google_android_gms_common_api_Status_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(PendingResult.IStatusListenerInvoker.n_OnComplete_Lcom_google_android_gms_common_api_Status_));
				}
				return PendingResult.IStatusListenerInvoker.cb_onComplete_Lcom_google_android_gms_common_api_Status_;
			}

			// Token: 0x06000492 RID: 1170 RVA: 0x0000DD8C File Offset: 0x0000BF8C
			private static void n_OnComplete_Lcom_google_android_gms_common_api_Status_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				PendingResult.IStatusListener @object = Java.Lang.Object.GetObject<PendingResult.IStatusListener>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				Statuses object2 = Java.Lang.Object.GetObject<Statuses>(native_p0, JniHandleOwnership.DoNotTransfer);
				@object.OnComplete(object2);
			}

			// Token: 0x06000493 RID: 1171 RVA: 0x0000DDB0 File Offset: 0x0000BFB0
			public unsafe void OnComplete(Statuses p0)
			{
				if (this.id_onComplete_Lcom_google_android_gms_common_api_Status_ == IntPtr.Zero)
				{
					this.id_onComplete_Lcom_google_android_gms_common_api_Status_ = JNIEnv.GetMethodID(this.class_ref, "onComplete", "(Lcom/google/android/gms/common/api/Status;)V");
				}
				JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
				*ptr = new JValue((p0 == null) ? IntPtr.Zero : p0.Handle);
				JNIEnv.CallVoidMethod(base.Handle, this.id_onComplete_Lcom_google_android_gms_common_api_Status_, ptr);
			}

			// Token: 0x04000111 RID: 273
			private static readonly JniPeerMembers _members = new XAPeerMembers("com/google/android/gms/common/api/PendingResult$StatusListener", typeof(PendingResult.IStatusListenerInvoker));

			// Token: 0x04000112 RID: 274
			private IntPtr class_ref;

			// Token: 0x04000113 RID: 275
			private static Delegate cb_onComplete_Lcom_google_android_gms_common_api_Status_;

			// Token: 0x04000114 RID: 276
			private IntPtr id_onComplete_Lcom_google_android_gms_common_api_Status_;
		}

		// Token: 0x02000067 RID: 103
		public class StatusEventArgs : EventArgs
		{
			// Token: 0x06000495 RID: 1173 RVA: 0x0000DE3E File Offset: 0x0000C03E
			public StatusEventArgs(Statuses p0)
			{
				this.p0 = p0;
			}

			// Token: 0x04000115 RID: 277
			private Statuses p0;
		}

		// Token: 0x02000068 RID: 104
		[Register("mono/com/google/android/gms/common/api/PendingResult_StatusListenerImplementor")]
		internal sealed class IStatusListenerImplementor : Java.Lang.Object, PendingResult.IStatusListener, IJavaObject, IDisposable, IJavaPeerable
		{
			// Token: 0x06000496 RID: 1174 RVA: 0x0000DE4D File Offset: 0x0000C04D
			public IStatusListenerImplementor(object sender) : base(JNIEnv.StartCreateInstance("mono/com/google/android/gms/common/api/PendingResult_StatusListenerImplementor", "()V", Array.Empty<JValue>()), JniHandleOwnership.TransferLocalRef)
			{
				JNIEnv.FinishCreateInstance(base.Handle, "()V", Array.Empty<JValue>());
				this.sender = sender;
			}

			// Token: 0x06000497 RID: 1175 RVA: 0x0000DE88 File Offset: 0x0000C088
			public void OnComplete(Statuses p0)
			{
				EventHandler<PendingResult.StatusEventArgs> handler = this.Handler;
				if (handler != null)
				{
					handler(this.sender, new PendingResult.StatusEventArgs(p0));
				}
			}

			// Token: 0x06000498 RID: 1176 RVA: 0x0000DEB1 File Offset: 0x0000C0B1
			internal static bool __IsEmpty(PendingResult.IStatusListenerImplementor value)
			{
				return value.Handler == null;
			}

			// Token: 0x04000116 RID: 278
			private object sender;

			// Token: 0x04000117 RID: 279
			public EventHandler<PendingResult.StatusEventArgs> Handler;
		}
	}
}
