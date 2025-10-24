using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Gms.Common.Apis;
using Android.Gms.Common.Internal;
using Android.OS;
using Android.Runtime;
using Java.Interop;
using Java.Lang;
using Java.Lang.Ref;
using Java.Util.Concurrent;

namespace Android.Gms.Common.Api.Internal
{
	// Token: 0x02000021 RID: 33
	[Register("com/google/android/gms/common/api/internal/BasePendingResult", DoNotGenerateAcw = true)]
	[JavaTypeParameters(new string[]
	{
		"R extends com.google.android.gms.common.api.Result"
	})]
	public abstract class BasePendingResult : PendingResult
	{
		// Token: 0x1700004B RID: 75
		// (get) Token: 0x06000121 RID: 289 RVA: 0x00004728 File Offset: 0x00002928
		// (set) Token: 0x06000122 RID: 290 RVA: 0x00004758 File Offset: 0x00002958
		[Register("zac")]
		protected Java.Lang.Ref.WeakReference Zac
		{
			get
			{
				return Java.Lang.Object.GetObject<Java.Lang.Ref.WeakReference>(BasePendingResult._members.InstanceFields.GetObjectValue("zac.Ljava/lang/ref/WeakReference;", this).Handle, JniHandleOwnership.TransferLocalRef);
			}
			set
			{
				IntPtr intPtr = JNIEnv.ToLocalJniHandle(value);
				try
				{
					BasePendingResult._members.InstanceFields.SetValue("zac.Ljava/lang/ref/WeakReference;", this, new JniObjectReference(intPtr, JniObjectReferenceType.Invalid));
				}
				finally
				{
					JNIEnv.DeleteLocalRef(intPtr);
				}
			}
		}

		// Token: 0x1700004C RID: 76
		// (get) Token: 0x06000123 RID: 291 RVA: 0x000047A4 File Offset: 0x000029A4
		[Register("zad")]
		public static int Zad
		{
			get
			{
				return BasePendingResult._members.StaticFields.GetInt32Value("zad.I");
			}
		}

		// Token: 0x1700004D RID: 77
		// (get) Token: 0x06000124 RID: 292 RVA: 0x000047BC File Offset: 0x000029BC
		internal new static IntPtr class_ref
		{
			get
			{
				return BasePendingResult._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700004E RID: 78
		// (get) Token: 0x06000125 RID: 293 RVA: 0x000047E0 File Offset: 0x000029E0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return BasePendingResult._members;
			}
		}

		// Token: 0x1700004F RID: 79
		// (get) Token: 0x06000126 RID: 294 RVA: 0x000047E8 File Offset: 0x000029E8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return BasePendingResult._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000050 RID: 80
		// (get) Token: 0x06000127 RID: 295 RVA: 0x0000480C File Offset: 0x00002A0C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return BasePendingResult._members.ManagedPeerType;
			}
		}

		// Token: 0x06000128 RID: 296 RVA: 0x00004818 File Offset: 0x00002A18
		protected BasePendingResult(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000129 RID: 297 RVA: 0x00004824 File Offset: 0x00002A24
		[Register(".ctor", "(Landroid/os/Looper;)V", "")]
		protected unsafe BasePendingResult(Looper looper) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((looper == null) ? IntPtr.Zero : looper.Handle);
				base.SetHandle(BasePendingResult._members.InstanceMethods.StartCreateInstance("(Landroid/os/Looper;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				BasePendingResult._members.InstanceMethods.FinishCreateInstance("(Landroid/os/Looper;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(looper);
			}
		}

		// Token: 0x0600012A RID: 298 RVA: 0x000048D4 File Offset: 0x00002AD4
		[Register(".ctor", "(Lcom/google/android/gms/common/api/GoogleApiClient;)V", "")]
		protected unsafe BasePendingResult(GoogleApiClient apiClient) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((apiClient == null) ? IntPtr.Zero : apiClient.Handle);
				base.SetHandle(BasePendingResult._members.InstanceMethods.StartCreateInstance("(Lcom/google/android/gms/common/api/GoogleApiClient;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				BasePendingResult._members.InstanceMethods.FinishCreateInstance("(Lcom/google/android/gms/common/api/GoogleApiClient;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(apiClient);
			}
		}

		// Token: 0x17000051 RID: 81
		// (get) Token: 0x0600012B RID: 299 RVA: 0x00004984 File Offset: 0x00002B84
		public override bool IsCanceled
		{
			[Register("isCanceled", "()Z", "")]
			get
			{
				return BasePendingResult._members.InstanceMethods.InvokeNonvirtualBooleanMethod("isCanceled.()Z", this, null);
			}
		}

		// Token: 0x17000052 RID: 82
		// (get) Token: 0x0600012C RID: 300 RVA: 0x0000499D File Offset: 0x00002B9D
		public bool IsReady
		{
			[Register("isReady", "()Z", "")]
			get
			{
				return BasePendingResult._members.InstanceMethods.InvokeNonvirtualBooleanMethod("isReady.()Z", this, null);
			}
		}

		// Token: 0x0600012D RID: 301 RVA: 0x000049B8 File Offset: 0x00002BB8
		[Register("addStatusListener", "(Lcom/google/android/gms/common/api/PendingResult$StatusListener;)V", "")]
		public unsafe sealed override void AddStatusListener(PendingResult.IStatusListener p0)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((p0 == null) ? IntPtr.Zero : ((Java.Lang.Object)p0).Handle);
				BasePendingResult._members.InstanceMethods.InvokeNonvirtualVoidMethod("addStatusListener.(Lcom/google/android/gms/common/api/PendingResult$StatusListener;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(p0);
			}
		}

		// Token: 0x0600012E RID: 302 RVA: 0x00004A20 File Offset: 0x00002C20
		[Register("await", "()Lcom/google/android/gms/common/api/Result;", "")]
		public sealed override Java.Lang.Object Await()
		{
			return Java.Lang.Object.GetObject<Java.Lang.Object>(BasePendingResult._members.InstanceMethods.InvokeNonvirtualObjectMethod("await.()Lcom/google/android/gms/common/api/Result;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x0600012F RID: 303 RVA: 0x00004A54 File Offset: 0x00002C54
		[Register("await", "(JLjava/util/concurrent/TimeUnit;)Lcom/google/android/gms/common/api/Result;", "")]
		public unsafe sealed override Java.Lang.Object Await(long p0, TimeUnit p1)
		{
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(p0);
				ptr[1] = new JniArgumentValue((p1 == null) ? IntPtr.Zero : p1.Handle);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(BasePendingResult._members.InstanceMethods.InvokeNonvirtualObjectMethod("await.(JLjava/util/concurrent/TimeUnit;)Lcom/google/android/gms/common/api/Result;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(p1);
			}
			return @object;
		}

		// Token: 0x06000130 RID: 304 RVA: 0x00004ADC File Offset: 0x00002CDC
		private static Delegate GetCancelHandler()
		{
			if (BasePendingResult.cb_cancel == null)
			{
				BasePendingResult.cb_cancel = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(BasePendingResult.n_Cancel));
			}
			return BasePendingResult.cb_cancel;
		}

		// Token: 0x06000131 RID: 305 RVA: 0x00004B00 File Offset: 0x00002D00
		private static void n_Cancel(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<BasePendingResult>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Cancel();
		}

		// Token: 0x06000132 RID: 306 RVA: 0x00004B0F File Offset: 0x00002D0F
		[Register("cancel", "()V", "GetCancelHandler")]
		public override void Cancel()
		{
			BasePendingResult._members.InstanceMethods.InvokeVirtualVoidMethod("cancel.()V", this, null);
		}

		// Token: 0x06000133 RID: 307 RVA: 0x00004B28 File Offset: 0x00002D28
		private static Delegate GetCreateFailedResult_Lcom_google_android_gms_common_api_Status_Handler()
		{
			if (BasePendingResult.cb_createFailedResult_Lcom_google_android_gms_common_api_Status_ == null)
			{
				BasePendingResult.cb_createFailedResult_Lcom_google_android_gms_common_api_Status_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(BasePendingResult.n_CreateFailedResult_Lcom_google_android_gms_common_api_Status_));
			}
			return BasePendingResult.cb_createFailedResult_Lcom_google_android_gms_common_api_Status_;
		}

		// Token: 0x06000134 RID: 308 RVA: 0x00004B4C File Offset: 0x00002D4C
		private static IntPtr n_CreateFailedResult_Lcom_google_android_gms_common_api_Status_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			BasePendingResult @object = Java.Lang.Object.GetObject<BasePendingResult>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Statuses object2 = Java.Lang.Object.GetObject<Statuses>(native_p0, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.CreateFailedResult(object2));
		}

		// Token: 0x06000135 RID: 309 RVA: 0x00004B74 File Offset: 0x00002D74
		[Register("createFailedResult", "(Lcom/google/android/gms/common/api/Status;)Lcom/google/android/gms/common/api/Result;", "GetCreateFailedResult_Lcom_google_android_gms_common_api_Status_Handler")]
		protected unsafe virtual Java.Lang.Object CreateFailedResult(Statuses p0)
		{
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((p0 == null) ? IntPtr.Zero : p0.Handle);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(BasePendingResult._members.InstanceMethods.InvokeVirtualObjectMethod("createFailedResult.(Lcom/google/android/gms/common/api/Status;)Lcom/google/android/gms/common/api/Result;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(p0);
			}
			return @object;
		}

		// Token: 0x06000136 RID: 310 RVA: 0x00004BE8 File Offset: 0x00002DE8
		[Register("forceFailureUnlessReady", "(Lcom/google/android/gms/common/api/Status;)V", "")]
		public unsafe void ForceFailureUnlessReady(Statuses status)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((status == null) ? IntPtr.Zero : status.Handle);
				BasePendingResult._members.InstanceMethods.InvokeNonvirtualVoidMethod("forceFailureUnlessReady.(Lcom/google/android/gms/common/api/Status;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(status);
			}
		}

		// Token: 0x06000137 RID: 311 RVA: 0x00004C4C File Offset: 0x00002E4C
		[Register("setCancelToken", "(Lcom/google/android/gms/common/internal/ICancelToken;)V", "")]
		protected unsafe void SetCancelToken(ICancelToken cancelToken)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((cancelToken == null) ? IntPtr.Zero : ((Java.Lang.Object)cancelToken).Handle);
				BasePendingResult._members.InstanceMethods.InvokeNonvirtualVoidMethod("setCancelToken.(Lcom/google/android/gms/common/internal/ICancelToken;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(cancelToken);
			}
		}

		// Token: 0x06000138 RID: 312 RVA: 0x00004CB4 File Offset: 0x00002EB4
		[Register("setResult", "(Lcom/google/android/gms/common/api/Result;)V", "")]
		public unsafe void SetResult(Java.Lang.Object result)
		{
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(result);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				BasePendingResult._members.InstanceMethods.InvokeNonvirtualVoidMethod("setResult.(Lcom/google/android/gms/common/api/Result;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(result);
			}
		}

		// Token: 0x06000139 RID: 313 RVA: 0x00004D18 File Offset: 0x00002F18
		[Register("setResultCallback", "(Lcom/google/android/gms/common/api/ResultCallback;)V", "")]
		public unsafe sealed override void SetResultCallback(IResultCallback callback)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((callback == null) ? IntPtr.Zero : ((Java.Lang.Object)callback).Handle);
				BasePendingResult._members.InstanceMethods.InvokeNonvirtualVoidMethod("setResultCallback.(Lcom/google/android/gms/common/api/ResultCallback;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(callback);
			}
		}

		// Token: 0x0600013A RID: 314 RVA: 0x00004D80 File Offset: 0x00002F80
		[Register("setResultCallback", "(Lcom/google/android/gms/common/api/ResultCallback;JLjava/util/concurrent/TimeUnit;)V", "")]
		public unsafe sealed override void SetResultCallback(IResultCallback callback, long time, TimeUnit units)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((callback == null) ? IntPtr.Zero : ((Java.Lang.Object)callback).Handle);
				ptr[1] = new JniArgumentValue(time);
				ptr[2] = new JniArgumentValue((units == null) ? IntPtr.Zero : units.Handle);
				BasePendingResult._members.InstanceMethods.InvokeNonvirtualVoidMethod("setResultCallback.(Lcom/google/android/gms/common/api/ResultCallback;JLjava/util/concurrent/TimeUnit;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(callback);
				GC.KeepAlive(units);
			}
		}

		// Token: 0x0600013B RID: 315 RVA: 0x00004E28 File Offset: 0x00003028
		[Register("then", "(Lcom/google/android/gms/common/api/ResultTransform;)Lcom/google/android/gms/common/api/TransformedResult;", "")]
		[JavaTypeParameters(new string[]
		{
			"S extends com.google.android.gms.common.api.Result"
		})]
		public unsafe sealed override TransformedResult Then(ResultTransform p0)
		{
			TransformedResult @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((p0 == null) ? IntPtr.Zero : p0.Handle);
				@object = Java.Lang.Object.GetObject<TransformedResult>(BasePendingResult._members.InstanceMethods.InvokeNonvirtualObjectMethod("then.(Lcom/google/android/gms/common/api/ResultTransform;)Lcom/google/android/gms/common/api/TransformedResult;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(p0);
			}
			return @object;
		}

		// Token: 0x0600013C RID: 316 RVA: 0x00004E9C File Offset: 0x0000309C
		[Register("zak", "()V", "")]
		public void Zak()
		{
			BasePendingResult._members.InstanceMethods.InvokeNonvirtualVoidMethod("zak.()V", this, null);
		}

		// Token: 0x0600013D RID: 317 RVA: 0x00004EB8 File Offset: 0x000030B8
		[Register("zal", "(Lcom/google/android/gms/common/api/Result;)V", "")]
		public unsafe static void Zal(IResult p0)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((p0 == null) ? IntPtr.Zero : ((Java.Lang.Object)p0).Handle);
				BasePendingResult._members.StaticMethods.InvokeVoidMethod("zal.(Lcom/google/android/gms/common/api/Result;)V", ptr);
			}
			finally
			{
				GC.KeepAlive(p0);
			}
		}

		// Token: 0x0600013E RID: 318 RVA: 0x00004F20 File Offset: 0x00003120
		[Register("zam", "()Z", "")]
		public bool Zam()
		{
			return BasePendingResult._members.InstanceMethods.InvokeNonvirtualBooleanMethod("zam.()Z", this, null);
		}

		// Token: 0x14000001 RID: 1
		// (add) Token: 0x0600013F RID: 319 RVA: 0x00004F3C File Offset: 0x0000313C
		// (remove) Token: 0x06000140 RID: 320 RVA: 0x00004F88 File Offset: 0x00003188
		public new event EventHandler<PendingResult.StatusEventArgs> Status
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

		// Token: 0x06000141 RID: 321 RVA: 0x00004FE4 File Offset: 0x000031E4
		private PendingResult.IStatusListenerImplementor __CreateIStatusListenerImplementor()
		{
			return new PendingResult.IStatusListenerImplementor(this);
		}

		// Token: 0x04000034 RID: 52
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/google/android/gms/common/api/internal/BasePendingResult", typeof(BasePendingResult));

		// Token: 0x04000035 RID: 53
		private static Delegate cb_cancel;

		// Token: 0x04000036 RID: 54
		private static Delegate cb_createFailedResult_Lcom_google_android_gms_common_api_Status_;

		// Token: 0x04000037 RID: 55
		private System.WeakReference weak_implementor_AddStatusListener;
	}
}
