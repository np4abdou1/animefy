using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Gms.Common.Api.Internal;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Android.Gms.Common.Apis
{
	// Token: 0x02000063 RID: 99
	[Register("com/google/android/gms/common/api/HasApiKey", DoNotGenerateAcw = true)]
	internal class IHasApiKeyInvoker : Java.Lang.Object, IHasApiKey, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000125 RID: 293
		// (get) Token: 0x0600045A RID: 1114 RVA: 0x0000D684 File Offset: 0x0000B884
		private static IntPtr java_class_ref
		{
			get
			{
				return IHasApiKeyInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000126 RID: 294
		// (get) Token: 0x0600045B RID: 1115 RVA: 0x0000D6A8 File Offset: 0x0000B8A8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IHasApiKeyInvoker._members;
			}
		}

		// Token: 0x17000127 RID: 295
		// (get) Token: 0x0600045C RID: 1116 RVA: 0x0000D6AF File Offset: 0x0000B8AF
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x17000128 RID: 296
		// (get) Token: 0x0600045D RID: 1117 RVA: 0x0000D6B7 File Offset: 0x0000B8B7
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IHasApiKeyInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x0600045E RID: 1118 RVA: 0x0000D6C3 File Offset: 0x0000B8C3
		public static IHasApiKey GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IHasApiKey>(handle, transfer);
		}

		// Token: 0x0600045F RID: 1119 RVA: 0x0000D6CC File Offset: 0x0000B8CC
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IHasApiKeyInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'com.google.android.gms.common.api.HasApiKey'.");
			}
			return handle;
		}

		// Token: 0x06000460 RID: 1120 RVA: 0x0000D6F7 File Offset: 0x0000B8F7
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x06000461 RID: 1121 RVA: 0x0000D728 File Offset: 0x0000B928
		public IHasApiKeyInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IHasApiKeyInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x06000462 RID: 1122 RVA: 0x0000D760 File Offset: 0x0000B960
		private static Delegate GetGetApiKeyHandler()
		{
			if (IHasApiKeyInvoker.cb_getApiKey == null)
			{
				IHasApiKeyInvoker.cb_getApiKey = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IHasApiKeyInvoker.n_GetApiKey));
			}
			return IHasApiKeyInvoker.cb_getApiKey;
		}

		// Token: 0x06000463 RID: 1123 RVA: 0x0000D784 File Offset: 0x0000B984
		private static IntPtr n_GetApiKey(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IHasApiKey>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).ApiKey);
		}

		// Token: 0x17000129 RID: 297
		// (get) Token: 0x06000464 RID: 1124 RVA: 0x0000D798 File Offset: 0x0000B998
		public ApiKey ApiKey
		{
			get
			{
				if (this.id_getApiKey == IntPtr.Zero)
				{
					this.id_getApiKey = JNIEnv.GetMethodID(this.class_ref, "getApiKey", "()Lcom/google/android/gms/common/api/internal/ApiKey;");
				}
				return Java.Lang.Object.GetObject<ApiKey>(JNIEnv.CallObjectMethod(base.Handle, this.id_getApiKey), JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x04000103 RID: 259
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/google/android/gms/common/api/HasApiKey", typeof(IHasApiKeyInvoker));

		// Token: 0x04000104 RID: 260
		private IntPtr class_ref;

		// Token: 0x04000105 RID: 261
		private static Delegate cb_getApiKey;

		// Token: 0x04000106 RID: 262
		private IntPtr id_getApiKey;
	}
}
