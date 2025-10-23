using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Com.Unity3d.Services.Core.Configuration
{
	// Token: 0x02000167 RID: 359
	[Register("com/unity3d/services/core/configuration/IInitializationListener", DoNotGenerateAcw = true)]
	internal class IInitializationListenerInvoker : Java.Lang.Object, IInitializationListener, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x170005AA RID: 1450
		// (get) Token: 0x06000F9C RID: 3996 RVA: 0x0002A3CC File Offset: 0x000285CC
		private static IntPtr java_class_ref
		{
			get
			{
				return IInitializationListenerInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170005AB RID: 1451
		// (get) Token: 0x06000F9D RID: 3997 RVA: 0x0002A3F0 File Offset: 0x000285F0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IInitializationListenerInvoker._members;
			}
		}

		// Token: 0x170005AC RID: 1452
		// (get) Token: 0x06000F9E RID: 3998 RVA: 0x0002A3F7 File Offset: 0x000285F7
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x170005AD RID: 1453
		// (get) Token: 0x06000F9F RID: 3999 RVA: 0x0002A3FF File Offset: 0x000285FF
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IInitializationListenerInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06000FA0 RID: 4000 RVA: 0x0002A40B File Offset: 0x0002860B
		public static IInitializationListener GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IInitializationListener>(handle, transfer);
		}

		// Token: 0x06000FA1 RID: 4001 RVA: 0x0002A414 File Offset: 0x00028614
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IInitializationListenerInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'com.unity3d.services.core.configuration.IInitializationListener'.");
			}
			return handle;
		}

		// Token: 0x06000FA2 RID: 4002 RVA: 0x0002A43F File Offset: 0x0002863F
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x06000FA3 RID: 4003 RVA: 0x0002A470 File Offset: 0x00028670
		public IInitializationListenerInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IInitializationListenerInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x06000FA4 RID: 4004 RVA: 0x0002A4A8 File Offset: 0x000286A8
		private static Delegate GetOnSdkInitializationFailed_Ljava_lang_String_Lcom_unity3d_services_core_configuration_ErrorState_IHandler()
		{
			if (IInitializationListenerInvoker.cb_onSdkInitializationFailed_Ljava_lang_String_Lcom_unity3d_services_core_configuration_ErrorState_I == null)
			{
				IInitializationListenerInvoker.cb_onSdkInitializationFailed_Ljava_lang_String_Lcom_unity3d_services_core_configuration_ErrorState_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLLI_V(IInitializationListenerInvoker.n_OnSdkInitializationFailed_Ljava_lang_String_Lcom_unity3d_services_core_configuration_ErrorState_I));
			}
			return IInitializationListenerInvoker.cb_onSdkInitializationFailed_Ljava_lang_String_Lcom_unity3d_services_core_configuration_ErrorState_I;
		}

		// Token: 0x06000FA5 RID: 4005 RVA: 0x0002A4CC File Offset: 0x000286CC
		private static void n_OnSdkInitializationFailed_Ljava_lang_String_Lcom_unity3d_services_core_configuration_ErrorState_I(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, int p2)
		{
			IInitializationListener @object = Java.Lang.Object.GetObject<IInitializationListener>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_p0, JniHandleOwnership.DoNotTransfer);
			ErrorState object2 = Java.Lang.Object.GetObject<ErrorState>(native_p1, JniHandleOwnership.DoNotTransfer);
			@object.OnSdkInitializationFailed(@string, object2, p2);
		}

		// Token: 0x06000FA6 RID: 4006 RVA: 0x0002A4FC File Offset: 0x000286FC
		public unsafe void OnSdkInitializationFailed(string p0, ErrorState p1, int p2)
		{
			if (this.id_onSdkInitializationFailed_Ljava_lang_String_Lcom_unity3d_services_core_configuration_ErrorState_I == IntPtr.Zero)
			{
				this.id_onSdkInitializationFailed_Ljava_lang_String_Lcom_unity3d_services_core_configuration_ErrorState_I = JNIEnv.GetMethodID(this.class_ref, "onSdkInitializationFailed", "(Ljava/lang/String;Lcom/unity3d/services/core/configuration/ErrorState;I)V");
			}
			IntPtr intPtr = JNIEnv.NewString(p0);
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(intPtr);
			ptr[1] = new JValue((p1 == null) ? IntPtr.Zero : p1.Handle);
			ptr[2] = new JValue(p2);
			JNIEnv.CallVoidMethod(base.Handle, this.id_onSdkInitializationFailed_Ljava_lang_String_Lcom_unity3d_services_core_configuration_ErrorState_I, ptr);
			JNIEnv.DeleteLocalRef(intPtr);
		}

		// Token: 0x06000FA7 RID: 4007 RVA: 0x0002A5A5 File Offset: 0x000287A5
		private static Delegate GetOnSdkInitializedHandler()
		{
			if (IInitializationListenerInvoker.cb_onSdkInitialized == null)
			{
				IInitializationListenerInvoker.cb_onSdkInitialized = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(IInitializationListenerInvoker.n_OnSdkInitialized));
			}
			return IInitializationListenerInvoker.cb_onSdkInitialized;
		}

		// Token: 0x06000FA8 RID: 4008 RVA: 0x0002A5C9 File Offset: 0x000287C9
		private static void n_OnSdkInitialized(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<IInitializationListener>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).OnSdkInitialized();
		}

		// Token: 0x06000FA9 RID: 4009 RVA: 0x0002A5D8 File Offset: 0x000287D8
		public void OnSdkInitialized()
		{
			if (this.id_onSdkInitialized == IntPtr.Zero)
			{
				this.id_onSdkInitialized = JNIEnv.GetMethodID(this.class_ref, "onSdkInitialized", "()V");
			}
			JNIEnv.CallVoidMethod(base.Handle, this.id_onSdkInitialized);
		}

		// Token: 0x040003BE RID: 958
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/services/core/configuration/IInitializationListener", typeof(IInitializationListenerInvoker));

		// Token: 0x040003BF RID: 959
		private IntPtr class_ref;

		// Token: 0x040003C0 RID: 960
		private static Delegate cb_onSdkInitializationFailed_Ljava_lang_String_Lcom_unity3d_services_core_configuration_ErrorState_I;

		// Token: 0x040003C1 RID: 961
		private IntPtr id_onSdkInitializationFailed_Ljava_lang_String_Lcom_unity3d_services_core_configuration_ErrorState_I;

		// Token: 0x040003C2 RID: 962
		private static Delegate cb_onSdkInitialized;

		// Token: 0x040003C3 RID: 963
		private IntPtr id_onSdkInitialized;
	}
}
