using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Gms.Common.Apis;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Android.Gms.Common.Api.Internal
{
	// Token: 0x0200001C RID: 28
	[Register("com/google/android/gms/common/api/internal/BaseImplementation", DoNotGenerateAcw = true)]
	public class BaseImplementation : Java.Lang.Object
	{
		// Token: 0x1700003B RID: 59
		// (get) Token: 0x060000F2 RID: 242 RVA: 0x00003EE0 File Offset: 0x000020E0
		internal static IntPtr class_ref
		{
			get
			{
				return BaseImplementation._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700003C RID: 60
		// (get) Token: 0x060000F3 RID: 243 RVA: 0x00003F04 File Offset: 0x00002104
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return BaseImplementation._members;
			}
		}

		// Token: 0x1700003D RID: 61
		// (get) Token: 0x060000F4 RID: 244 RVA: 0x00003F0C File Offset: 0x0000210C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return BaseImplementation._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700003E RID: 62
		// (get) Token: 0x060000F5 RID: 245 RVA: 0x00003F30 File Offset: 0x00002130
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return BaseImplementation._members.ManagedPeerType;
			}
		}

		// Token: 0x060000F6 RID: 246 RVA: 0x00003280 File Offset: 0x00001480
		protected BaseImplementation(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x060000F7 RID: 247 RVA: 0x00003F3C File Offset: 0x0000213C
		[Register(".ctor", "()V", "")]
		public BaseImplementation() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			base.SetHandle(BaseImplementation._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
			BaseImplementation._members.InstanceMethods.FinishCreateInstance("()V", this, null);
		}

		// Token: 0x04000029 RID: 41
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/google/android/gms/common/api/internal/BaseImplementation", typeof(BaseImplementation));

		// Token: 0x0200001D RID: 29
		[Register("com/google/android/gms/common/api/internal/BaseImplementation$ApiMethodImpl", DoNotGenerateAcw = true)]
		[JavaTypeParameters(new string[]
		{
			"R extends com.google.android.gms.common.api.Result",
			"A extends com.google.android.gms.common.api.Api.AnyClient"
		})]
		public abstract class ApiMethodImpl : BasePendingResult, BaseImplementation.IResultHolder, IJavaObject, IDisposable, IJavaPeerable
		{
			// Token: 0x1700003F RID: 63
			// (get) Token: 0x060000F9 RID: 249 RVA: 0x00003FC8 File Offset: 0x000021C8
			internal new static IntPtr class_ref
			{
				get
				{
					return BaseImplementation.ApiMethodImpl._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x17000040 RID: 64
			// (get) Token: 0x060000FA RID: 250 RVA: 0x00003FEC File Offset: 0x000021EC
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return BaseImplementation.ApiMethodImpl._members;
				}
			}

			// Token: 0x17000041 RID: 65
			// (get) Token: 0x060000FB RID: 251 RVA: 0x00003FF4 File Offset: 0x000021F4
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return BaseImplementation.ApiMethodImpl._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x17000042 RID: 66
			// (get) Token: 0x060000FC RID: 252 RVA: 0x00004018 File Offset: 0x00002218
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return BaseImplementation.ApiMethodImpl._members.ManagedPeerType;
				}
			}

			// Token: 0x060000FD RID: 253 RVA: 0x00004024 File Offset: 0x00002224
			protected ApiMethodImpl(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
			{
			}

			// Token: 0x060000FE RID: 254 RVA: 0x00004030 File Offset: 0x00002230
			[Register(".ctor", "(Lcom/google/android/gms/common/api/Api;Lcom/google/android/gms/common/api/GoogleApiClient;)V", "")]
			protected unsafe ApiMethodImpl(Api api, GoogleApiClient apiClient) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (base.Handle != IntPtr.Zero)
				{
					return;
				}
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((api == null) ? IntPtr.Zero : api.Handle);
					ptr[1] = new JniArgumentValue((apiClient == null) ? IntPtr.Zero : apiClient.Handle);
					base.SetHandle(BaseImplementation.ApiMethodImpl._members.InstanceMethods.StartCreateInstance("(Lcom/google/android/gms/common/api/Api;Lcom/google/android/gms/common/api/GoogleApiClient;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
					BaseImplementation.ApiMethodImpl._members.InstanceMethods.FinishCreateInstance("(Lcom/google/android/gms/common/api/Api;Lcom/google/android/gms/common/api/GoogleApiClient;)V", this, ptr);
				}
				finally
				{
					GC.KeepAlive(api);
					GC.KeepAlive(apiClient);
				}
			}

			// Token: 0x060000FF RID: 255 RVA: 0x00004108 File Offset: 0x00002308
			[Register(".ctor", "(Lcom/google/android/gms/common/api/Api$AnyClientKey;Lcom/google/android/gms/common/api/GoogleApiClient;)V", "")]
			protected unsafe ApiMethodImpl(Api.AnyClientKey clientKey, GoogleApiClient apiClient) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (base.Handle != IntPtr.Zero)
				{
					return;
				}
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((clientKey == null) ? IntPtr.Zero : clientKey.Handle);
					ptr[1] = new JniArgumentValue((apiClient == null) ? IntPtr.Zero : apiClient.Handle);
					base.SetHandle(BaseImplementation.ApiMethodImpl._members.InstanceMethods.StartCreateInstance("(Lcom/google/android/gms/common/api/Api$AnyClientKey;Lcom/google/android/gms/common/api/GoogleApiClient;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
					BaseImplementation.ApiMethodImpl._members.InstanceMethods.FinishCreateInstance("(Lcom/google/android/gms/common/api/Api$AnyClientKey;Lcom/google/android/gms/common/api/GoogleApiClient;)V", this, ptr);
				}
				finally
				{
					GC.KeepAlive(clientKey);
					GC.KeepAlive(apiClient);
				}
			}

			// Token: 0x17000043 RID: 67
			// (get) Token: 0x06000100 RID: 256 RVA: 0x000041E0 File Offset: 0x000023E0
			public Api Api
			{
				[Register("getApi", "()Lcom/google/android/gms/common/api/Api;", "")]
				get
				{
					return Java.Lang.Object.GetObject<Api>(BaseImplementation.ApiMethodImpl._members.InstanceMethods.InvokeNonvirtualObjectMethod("getApi.()Lcom/google/android/gms/common/api/Api;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
				}
			}

			// Token: 0x17000044 RID: 68
			// (get) Token: 0x06000101 RID: 257 RVA: 0x00004214 File Offset: 0x00002414
			public Api.AnyClientKey ClientKey
			{
				[Register("getClientKey", "()Lcom/google/android/gms/common/api/Api$AnyClientKey;", "")]
				get
				{
					return Java.Lang.Object.GetObject<Api.AnyClientKey>(BaseImplementation.ApiMethodImpl._members.InstanceMethods.InvokeNonvirtualObjectMethod("getClientKey.()Lcom/google/android/gms/common/api/Api$AnyClientKey;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
				}
			}

			// Token: 0x06000102 RID: 258 RVA: 0x00004246 File Offset: 0x00002446
			private static Delegate GetDoExecute_Lcom_google_android_gms_common_api_Api_AnyClient_Handler()
			{
				if (BaseImplementation.ApiMethodImpl.cb_doExecute_Lcom_google_android_gms_common_api_Api_AnyClient_ == null)
				{
					BaseImplementation.ApiMethodImpl.cb_doExecute_Lcom_google_android_gms_common_api_Api_AnyClient_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(BaseImplementation.ApiMethodImpl.n_DoExecute_Lcom_google_android_gms_common_api_Api_AnyClient_));
				}
				return BaseImplementation.ApiMethodImpl.cb_doExecute_Lcom_google_android_gms_common_api_Api_AnyClient_;
			}

			// Token: 0x06000103 RID: 259 RVA: 0x0000426C File Offset: 0x0000246C
			private static void n_DoExecute_Lcom_google_android_gms_common_api_Api_AnyClient_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				BaseImplementation.ApiMethodImpl @object = Java.Lang.Object.GetObject<BaseImplementation.ApiMethodImpl>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_p0, JniHandleOwnership.DoNotTransfer);
				@object.DoExecute(object2);
			}

			// Token: 0x06000104 RID: 260
			[Register("doExecute", "(Lcom/google/android/gms/common/api/Api$AnyClient;)V", "GetDoExecute_Lcom_google_android_gms_common_api_Api_AnyClient_Handler")]
			protected abstract void DoExecute(Java.Lang.Object p0);

			// Token: 0x06000105 RID: 261 RVA: 0x0000428F File Offset: 0x0000248F
			private static Delegate GetOnSetFailedResult_Lcom_google_android_gms_common_api_Result_Handler()
			{
				if (BaseImplementation.ApiMethodImpl.cb_onSetFailedResult_Lcom_google_android_gms_common_api_Result_ == null)
				{
					BaseImplementation.ApiMethodImpl.cb_onSetFailedResult_Lcom_google_android_gms_common_api_Result_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(BaseImplementation.ApiMethodImpl.n_OnSetFailedResult_Lcom_google_android_gms_common_api_Result_));
				}
				return BaseImplementation.ApiMethodImpl.cb_onSetFailedResult_Lcom_google_android_gms_common_api_Result_;
			}

			// Token: 0x06000106 RID: 262 RVA: 0x000042B4 File Offset: 0x000024B4
			private static void n_OnSetFailedResult_Lcom_google_android_gms_common_api_Result_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				BaseImplementation.ApiMethodImpl @object = Java.Lang.Object.GetObject<BaseImplementation.ApiMethodImpl>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_p0, JniHandleOwnership.DoNotTransfer);
				@object.OnSetFailedResult(object2);
			}

			// Token: 0x06000107 RID: 263 RVA: 0x000042D8 File Offset: 0x000024D8
			[Register("onSetFailedResult", "(Lcom/google/android/gms/common/api/Result;)V", "GetOnSetFailedResult_Lcom_google_android_gms_common_api_Result_Handler")]
			protected unsafe virtual void OnSetFailedResult(Java.Lang.Object p0)
			{
				IntPtr intPtr = JNIEnv.ToLocalJniHandle(p0);
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue(intPtr);
					BaseImplementation.ApiMethodImpl._members.InstanceMethods.InvokeVirtualVoidMethod("onSetFailedResult.(Lcom/google/android/gms/common/api/Result;)V", this, ptr);
				}
				finally
				{
					JNIEnv.DeleteLocalRef(intPtr);
					GC.KeepAlive(p0);
				}
			}

			// Token: 0x06000108 RID: 264 RVA: 0x0000433C File Offset: 0x0000253C
			[Register("run", "(Lcom/google/android/gms/common/api/Api$AnyClient;)V", "")]
			public unsafe void Run(Java.Lang.Object client)
			{
				IntPtr intPtr = JNIEnv.ToLocalJniHandle(client);
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue(intPtr);
					BaseImplementation.ApiMethodImpl._members.InstanceMethods.InvokeNonvirtualVoidMethod("run.(Lcom/google/android/gms/common/api/Api$AnyClient;)V", this, ptr);
				}
				finally
				{
					JNIEnv.DeleteLocalRef(intPtr);
					GC.KeepAlive(client);
				}
			}

			// Token: 0x06000109 RID: 265 RVA: 0x000043A0 File Offset: 0x000025A0
			[Register("setFailedResult", "(Lcom/google/android/gms/common/api/Status;)V", "")]
			public unsafe void SetFailedResult(Statuses status)
			{
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue((status == null) ? IntPtr.Zero : status.Handle);
					BaseImplementation.ApiMethodImpl._members.InstanceMethods.InvokeNonvirtualVoidMethod("setFailedResult.(Lcom/google/android/gms/common/api/Status;)V", this, ptr);
				}
				finally
				{
					GC.KeepAlive(status);
				}
			}

			// Token: 0x0400002A RID: 42
			private static readonly JniPeerMembers _members = new XAPeerMembers("com/google/android/gms/common/api/internal/BaseImplementation$ApiMethodImpl", typeof(BaseImplementation.ApiMethodImpl));

			// Token: 0x0400002B RID: 43
			private static Delegate cb_doExecute_Lcom_google_android_gms_common_api_Api_AnyClient_;

			// Token: 0x0400002C RID: 44
			private static Delegate cb_onSetFailedResult_Lcom_google_android_gms_common_api_Result_;
		}

		// Token: 0x0200001E RID: 30
		[Register("com/google/android/gms/common/api/internal/BaseImplementation$ApiMethodImpl", DoNotGenerateAcw = true)]
		internal class ApiMethodImplInvoker : BaseImplementation.ApiMethodImpl, BaseImplementation.IResultHolder, IJavaObject, IDisposable, IJavaPeerable
		{
			// Token: 0x0600010B RID: 267 RVA: 0x0000441F File Offset: 0x0000261F
			public ApiMethodImplInvoker(IntPtr handle, JniHandleOwnership transfer) : base(handle, transfer)
			{
			}

			// Token: 0x17000045 RID: 69
			// (get) Token: 0x0600010C RID: 268 RVA: 0x00004429 File Offset: 0x00002629
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return BaseImplementation.ApiMethodImplInvoker._members;
				}
			}

			// Token: 0x17000046 RID: 70
			// (get) Token: 0x0600010D RID: 269 RVA: 0x00004430 File Offset: 0x00002630
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return BaseImplementation.ApiMethodImplInvoker._members.ManagedPeerType;
				}
			}

			// Token: 0x0600010E RID: 270 RVA: 0x0000443C File Offset: 0x0000263C
			[Register("doExecute", "(Lcom/google/android/gms/common/api/Api$AnyClient;)V", "GetDoExecute_Lcom_google_android_gms_common_api_Api_AnyClient_Handler")]
			protected unsafe override void DoExecute(Java.Lang.Object p0)
			{
				IntPtr intPtr = JNIEnv.ToLocalJniHandle(p0);
				try
				{
					JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
					*ptr = new JniArgumentValue(intPtr);
					BaseImplementation.ApiMethodImplInvoker._members.InstanceMethods.InvokeAbstractVoidMethod("doExecute.(Lcom/google/android/gms/common/api/Api$AnyClient;)V", this, ptr);
				}
				finally
				{
					JNIEnv.DeleteLocalRef(intPtr);
					GC.KeepAlive(p0);
				}
			}

			// Token: 0x0400002D RID: 45
			private static readonly JniPeerMembers _members = new XAPeerMembers("com/google/android/gms/common/api/internal/BaseImplementation$ApiMethodImpl", typeof(BaseImplementation.ApiMethodImplInvoker));
		}

		// Token: 0x0200001F RID: 31
		[Register("com/google/android/gms/common/api/internal/BaseImplementation$ResultHolder", "", "Android.Gms.Common.Api.Internal.BaseImplementation/IResultHolderInvoker")]
		[JavaTypeParameters(new string[]
		{
			"R"
		})]
		public interface IResultHolder : IJavaObject, IDisposable, IJavaPeerable
		{
			// Token: 0x06000110 RID: 272
			[Register("setFailedResult", "(Lcom/google/android/gms/common/api/Status;)V", "GetSetFailedResult_Lcom_google_android_gms_common_api_Status_Handler:Android.Gms.Common.Api.Internal.BaseImplementation/IResultHolderInvoker, Xamarin.GooglePlayServices.Base")]
			void SetFailedResult(Statuses p0);

			// Token: 0x06000111 RID: 273
			[Register("setResult", "(Ljava/lang/Object;)V", "GetSetResult_Ljava_lang_Object_Handler:Android.Gms.Common.Api.Internal.BaseImplementation/IResultHolderInvoker, Xamarin.GooglePlayServices.Base")]
			void SetResult(Java.Lang.Object p0);
		}

		// Token: 0x02000020 RID: 32
		[Register("com/google/android/gms/common/api/internal/BaseImplementation$ResultHolder", DoNotGenerateAcw = true)]
		internal class IResultHolderInvoker : Java.Lang.Object, BaseImplementation.IResultHolder, IJavaObject, IDisposable, IJavaPeerable
		{
			// Token: 0x17000047 RID: 71
			// (get) Token: 0x06000112 RID: 274 RVA: 0x000044BC File Offset: 0x000026BC
			private static IntPtr java_class_ref
			{
				get
				{
					return BaseImplementation.IResultHolderInvoker._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x17000048 RID: 72
			// (get) Token: 0x06000113 RID: 275 RVA: 0x000044E0 File Offset: 0x000026E0
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return BaseImplementation.IResultHolderInvoker._members;
				}
			}

			// Token: 0x17000049 RID: 73
			// (get) Token: 0x06000114 RID: 276 RVA: 0x000044E7 File Offset: 0x000026E7
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return this.class_ref;
				}
			}

			// Token: 0x1700004A RID: 74
			// (get) Token: 0x06000115 RID: 277 RVA: 0x000044EF File Offset: 0x000026EF
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return BaseImplementation.IResultHolderInvoker._members.ManagedPeerType;
				}
			}

			// Token: 0x06000116 RID: 278 RVA: 0x000044FB File Offset: 0x000026FB
			public static BaseImplementation.IResultHolder GetObject(IntPtr handle, JniHandleOwnership transfer)
			{
				return Java.Lang.Object.GetObject<BaseImplementation.IResultHolder>(handle, transfer);
			}

			// Token: 0x06000117 RID: 279 RVA: 0x00004504 File Offset: 0x00002704
			private static IntPtr Validate(IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf(handle, BaseImplementation.IResultHolderInvoker.java_class_ref))
				{
					throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'com.google.android.gms.common.api.internal.BaseImplementation.ResultHolder'.");
				}
				return handle;
			}

			// Token: 0x06000118 RID: 280 RVA: 0x0000452F File Offset: 0x0000272F
			protected override void Dispose(bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
				{
					JNIEnv.DeleteGlobalRef(this.class_ref);
				}
				this.class_ref = IntPtr.Zero;
				base.Dispose(disposing);
			}

			// Token: 0x06000119 RID: 281 RVA: 0x00004560 File Offset: 0x00002760
			public IResultHolderInvoker(IntPtr handle, JniHandleOwnership transfer) : base(BaseImplementation.IResultHolderInvoker.Validate(handle), transfer)
			{
				IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
				this.class_ref = JNIEnv.NewGlobalRef(objectClass);
				JNIEnv.DeleteLocalRef(objectClass);
			}

			// Token: 0x0600011A RID: 282 RVA: 0x00004598 File Offset: 0x00002798
			private static Delegate GetSetFailedResult_Lcom_google_android_gms_common_api_Status_Handler()
			{
				if (BaseImplementation.IResultHolderInvoker.cb_setFailedResult_Lcom_google_android_gms_common_api_Status_ == null)
				{
					BaseImplementation.IResultHolderInvoker.cb_setFailedResult_Lcom_google_android_gms_common_api_Status_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(BaseImplementation.IResultHolderInvoker.n_SetFailedResult_Lcom_google_android_gms_common_api_Status_));
				}
				return BaseImplementation.IResultHolderInvoker.cb_setFailedResult_Lcom_google_android_gms_common_api_Status_;
			}

			// Token: 0x0600011B RID: 283 RVA: 0x000045BC File Offset: 0x000027BC
			private static void n_SetFailedResult_Lcom_google_android_gms_common_api_Status_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				BaseImplementation.IResultHolder @object = Java.Lang.Object.GetObject<BaseImplementation.IResultHolder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				Statuses object2 = Java.Lang.Object.GetObject<Statuses>(native_p0, JniHandleOwnership.DoNotTransfer);
				@object.SetFailedResult(object2);
			}

			// Token: 0x0600011C RID: 284 RVA: 0x000045E0 File Offset: 0x000027E0
			public unsafe void SetFailedResult(Statuses p0)
			{
				if (this.id_setFailedResult_Lcom_google_android_gms_common_api_Status_ == IntPtr.Zero)
				{
					this.id_setFailedResult_Lcom_google_android_gms_common_api_Status_ = JNIEnv.GetMethodID(this.class_ref, "setFailedResult", "(Lcom/google/android/gms/common/api/Status;)V");
				}
				JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
				*ptr = new JValue((p0 == null) ? IntPtr.Zero : p0.Handle);
				JNIEnv.CallVoidMethod(base.Handle, this.id_setFailedResult_Lcom_google_android_gms_common_api_Status_, ptr);
			}

			// Token: 0x0600011D RID: 285 RVA: 0x00004653 File Offset: 0x00002853
			private static Delegate GetSetResult_Ljava_lang_Object_Handler()
			{
				if (BaseImplementation.IResultHolderInvoker.cb_setResult_Ljava_lang_Object_ == null)
				{
					BaseImplementation.IResultHolderInvoker.cb_setResult_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(BaseImplementation.IResultHolderInvoker.n_SetResult_Ljava_lang_Object_));
				}
				return BaseImplementation.IResultHolderInvoker.cb_setResult_Ljava_lang_Object_;
			}

			// Token: 0x0600011E RID: 286 RVA: 0x00004678 File Offset: 0x00002878
			private static void n_SetResult_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				BaseImplementation.IResultHolder @object = Java.Lang.Object.GetObject<BaseImplementation.IResultHolder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_p0, JniHandleOwnership.DoNotTransfer);
				@object.SetResult(object2);
			}

			// Token: 0x0600011F RID: 287 RVA: 0x0000469C File Offset: 0x0000289C
			public unsafe void SetResult(Java.Lang.Object p0)
			{
				if (this.id_setResult_Ljava_lang_Object_ == IntPtr.Zero)
				{
					this.id_setResult_Ljava_lang_Object_ = JNIEnv.GetMethodID(this.class_ref, "setResult", "(Ljava/lang/Object;)V");
				}
				IntPtr intPtr = JNIEnv.ToLocalJniHandle(p0);
				JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
				*ptr = new JValue(intPtr);
				JNIEnv.CallVoidMethod(base.Handle, this.id_setResult_Ljava_lang_Object_, ptr);
				JNIEnv.DeleteLocalRef(intPtr);
			}

			// Token: 0x0400002E RID: 46
			private static readonly JniPeerMembers _members = new XAPeerMembers("com/google/android/gms/common/api/internal/BaseImplementation$ResultHolder", typeof(BaseImplementation.IResultHolderInvoker));

			// Token: 0x0400002F RID: 47
			private IntPtr class_ref;

			// Token: 0x04000030 RID: 48
			private static Delegate cb_setFailedResult_Lcom_google_android_gms_common_api_Status_;

			// Token: 0x04000031 RID: 49
			private IntPtr id_setFailedResult_Lcom_google_android_gms_common_api_Status_;

			// Token: 0x04000032 RID: 50
			private static Delegate cb_setResult_Ljava_lang_Object_;

			// Token: 0x04000033 RID: 51
			private IntPtr id_setResult_Ljava_lang_Object_;
		}
	}
}
