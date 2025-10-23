using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Com.Unity3d.Services.Core.Request
{
	// Token: 0x0200009F RID: 159
	[Register("com/unity3d/services/core/request/IResolveHostListener", DoNotGenerateAcw = true)]
	internal class IResolveHostListenerInvoker : Java.Lang.Object, IResolveHostListener, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x170001CA RID: 458
		// (get) Token: 0x060005C5 RID: 1477 RVA: 0x00010564 File Offset: 0x0000E764
		private static IntPtr java_class_ref
		{
			get
			{
				return IResolveHostListenerInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170001CB RID: 459
		// (get) Token: 0x060005C6 RID: 1478 RVA: 0x00010588 File Offset: 0x0000E788
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IResolveHostListenerInvoker._members;
			}
		}

		// Token: 0x170001CC RID: 460
		// (get) Token: 0x060005C7 RID: 1479 RVA: 0x0001058F File Offset: 0x0000E78F
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x170001CD RID: 461
		// (get) Token: 0x060005C8 RID: 1480 RVA: 0x00010597 File Offset: 0x0000E797
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IResolveHostListenerInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x060005C9 RID: 1481 RVA: 0x000105A3 File Offset: 0x0000E7A3
		public static IResolveHostListener GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IResolveHostListener>(handle, transfer);
		}

		// Token: 0x060005CA RID: 1482 RVA: 0x000105AC File Offset: 0x0000E7AC
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IResolveHostListenerInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'com.unity3d.services.core.request.IResolveHostListener'.");
			}
			return handle;
		}

		// Token: 0x060005CB RID: 1483 RVA: 0x000105D7 File Offset: 0x0000E7D7
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x060005CC RID: 1484 RVA: 0x00010608 File Offset: 0x0000E808
		public IResolveHostListenerInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IResolveHostListenerInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x060005CD RID: 1485 RVA: 0x00010640 File Offset: 0x0000E840
		private static Delegate GetOnFailed_Ljava_lang_String_Lcom_unity3d_services_core_request_ResolveHostError_Ljava_lang_String_Handler()
		{
			if (IResolveHostListenerInvoker.cb_onFailed_Ljava_lang_String_Lcom_unity3d_services_core_request_ResolveHostError_Ljava_lang_String_ == null)
			{
				IResolveHostListenerInvoker.cb_onFailed_Ljava_lang_String_Lcom_unity3d_services_core_request_ResolveHostError_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLLL_V(IResolveHostListenerInvoker.n_OnFailed_Ljava_lang_String_Lcom_unity3d_services_core_request_ResolveHostError_Ljava_lang_String_));
			}
			return IResolveHostListenerInvoker.cb_onFailed_Ljava_lang_String_Lcom_unity3d_services_core_request_ResolveHostError_Ljava_lang_String_;
		}

		// Token: 0x060005CE RID: 1486 RVA: 0x00010664 File Offset: 0x0000E864
		private static void n_OnFailed_Ljava_lang_String_Lcom_unity3d_services_core_request_ResolveHostError_Ljava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			IResolveHostListener @object = Java.Lang.Object.GetObject<IResolveHostListener>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_p0, JniHandleOwnership.DoNotTransfer);
			ResolveHostError object2 = Java.Lang.Object.GetObject<ResolveHostError>(native_p1, JniHandleOwnership.DoNotTransfer);
			string string2 = JNIEnv.GetString(native_p2, JniHandleOwnership.DoNotTransfer);
			@object.OnFailed(@string, object2, string2);
		}

		// Token: 0x060005CF RID: 1487 RVA: 0x0001069C File Offset: 0x0000E89C
		public unsafe void OnFailed(string p0, ResolveHostError p1, string p2)
		{
			if (this.id_onFailed_Ljava_lang_String_Lcom_unity3d_services_core_request_ResolveHostError_Ljava_lang_String_ == IntPtr.Zero)
			{
				this.id_onFailed_Ljava_lang_String_Lcom_unity3d_services_core_request_ResolveHostError_Ljava_lang_String_ = JNIEnv.GetMethodID(this.class_ref, "onFailed", "(Ljava/lang/String;Lcom/unity3d/services/core/request/ResolveHostError;Ljava/lang/String;)V");
			}
			IntPtr intPtr = JNIEnv.NewString(p0);
			IntPtr intPtr2 = JNIEnv.NewString(p2);
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(intPtr);
			ptr[1] = new JValue((p1 == null) ? IntPtr.Zero : p1.Handle);
			ptr[2] = new JValue(intPtr2);
			JNIEnv.CallVoidMethod(base.Handle, this.id_onFailed_Ljava_lang_String_Lcom_unity3d_services_core_request_ResolveHostError_Ljava_lang_String_, ptr);
			JNIEnv.DeleteLocalRef(intPtr);
			JNIEnv.DeleteLocalRef(intPtr2);
		}

		// Token: 0x060005D0 RID: 1488 RVA: 0x00010752 File Offset: 0x0000E952
		private static Delegate GetOnResolve_Ljava_lang_String_Ljava_lang_String_Handler()
		{
			if (IResolveHostListenerInvoker.cb_onResolve_Ljava_lang_String_Ljava_lang_String_ == null)
			{
				IResolveHostListenerInvoker.cb_onResolve_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_V(IResolveHostListenerInvoker.n_OnResolve_Ljava_lang_String_Ljava_lang_String_));
			}
			return IResolveHostListenerInvoker.cb_onResolve_Ljava_lang_String_Ljava_lang_String_;
		}

		// Token: 0x060005D1 RID: 1489 RVA: 0x00010778 File Offset: 0x0000E978
		private static void n_OnResolve_Ljava_lang_String_Ljava_lang_String_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			IResolveHostListener @object = Java.Lang.Object.GetObject<IResolveHostListener>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_p0, JniHandleOwnership.DoNotTransfer);
			string string2 = JNIEnv.GetString(native_p1, JniHandleOwnership.DoNotTransfer);
			@object.OnResolve(@string, string2);
		}

		// Token: 0x060005D2 RID: 1490 RVA: 0x000107A4 File Offset: 0x0000E9A4
		public unsafe void OnResolve(string p0, string p1)
		{
			if (this.id_onResolve_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
			{
				this.id_onResolve_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID(this.class_ref, "onResolve", "(Ljava/lang/String;Ljava/lang/String;)V");
			}
			IntPtr intPtr = JNIEnv.NewString(p0);
			IntPtr intPtr2 = JNIEnv.NewString(p1);
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(intPtr);
			ptr[1] = new JValue(intPtr2);
			JNIEnv.CallVoidMethod(base.Handle, this.id_onResolve_Ljava_lang_String_Ljava_lang_String_, ptr);
			JNIEnv.DeleteLocalRef(intPtr);
			JNIEnv.DeleteLocalRef(intPtr2);
		}

		// Token: 0x0400014F RID: 335
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/services/core/request/IResolveHostListener", typeof(IResolveHostListenerInvoker));

		// Token: 0x04000150 RID: 336
		private IntPtr class_ref;

		// Token: 0x04000151 RID: 337
		private static Delegate cb_onFailed_Ljava_lang_String_Lcom_unity3d_services_core_request_ResolveHostError_Ljava_lang_String_;

		// Token: 0x04000152 RID: 338
		private IntPtr id_onFailed_Ljava_lang_String_Lcom_unity3d_services_core_request_ResolveHostError_Ljava_lang_String_;

		// Token: 0x04000153 RID: 339
		private static Delegate cb_onResolve_Ljava_lang_String_Ljava_lang_String_;

		// Token: 0x04000154 RID: 340
		private IntPtr id_onResolve_Ljava_lang_String_Ljava_lang_String_;
	}
}
