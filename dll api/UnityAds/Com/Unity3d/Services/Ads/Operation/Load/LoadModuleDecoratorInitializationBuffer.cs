using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Com.Unity3d.Services.Core.Configuration;
using Java.Interop;
using Java.Lang;

namespace Com.Unity3d.Services.Ads.Operation.Load
{
	// Token: 0x020001FC RID: 508
	[Register("com/unity3d/services/ads/operation/load/LoadModuleDecoratorInitializationBuffer", DoNotGenerateAcw = true)]
	public class LoadModuleDecoratorInitializationBuffer : LoadModuleDecorator, IInitializationListener, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000820 RID: 2080
		// (get) Token: 0x060017A7 RID: 6055 RVA: 0x00044554 File Offset: 0x00042754
		internal new static IntPtr class_ref
		{
			get
			{
				return LoadModuleDecoratorInitializationBuffer._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000821 RID: 2081
		// (get) Token: 0x060017A8 RID: 6056 RVA: 0x00044578 File Offset: 0x00042778
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return LoadModuleDecoratorInitializationBuffer._members;
			}
		}

		// Token: 0x17000822 RID: 2082
		// (get) Token: 0x060017A9 RID: 6057 RVA: 0x00044580 File Offset: 0x00042780
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return LoadModuleDecoratorInitializationBuffer._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000823 RID: 2083
		// (get) Token: 0x060017AA RID: 6058 RVA: 0x000445A4 File Offset: 0x000427A4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return LoadModuleDecoratorInitializationBuffer._members.ManagedPeerType;
			}
		}

		// Token: 0x060017AB RID: 6059 RVA: 0x000445B0 File Offset: 0x000427B0
		protected LoadModuleDecoratorInitializationBuffer(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x060017AC RID: 6060 RVA: 0x000445BC File Offset: 0x000427BC
		[Register(".ctor", "(Lcom/unity3d/services/ads/operation/load/ILoadModule;Lcom/unity3d/services/core/configuration/IInitializationNotificationCenter;)V", "")]
		public unsafe LoadModuleDecoratorInitializationBuffer(ILoadModule loadModule, IInitializationNotificationCenter initializationNotificationCenter) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((loadModule == null) ? IntPtr.Zero : ((Java.Lang.Object)loadModule).Handle);
				ptr[1] = new JniArgumentValue((initializationNotificationCenter == null) ? IntPtr.Zero : ((Java.Lang.Object)initializationNotificationCenter).Handle);
				base.SetHandle(LoadModuleDecoratorInitializationBuffer._members.InstanceMethods.StartCreateInstance("(Lcom/unity3d/services/ads/operation/load/ILoadModule;Lcom/unity3d/services/core/configuration/IInitializationNotificationCenter;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				LoadModuleDecoratorInitializationBuffer._members.InstanceMethods.FinishCreateInstance("(Lcom/unity3d/services/ads/operation/load/ILoadModule;Lcom/unity3d/services/core/configuration/IInitializationNotificationCenter;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(loadModule);
				GC.KeepAlive(initializationNotificationCenter);
			}
		}

		// Token: 0x060017AD RID: 6061 RVA: 0x0004469C File Offset: 0x0004289C
		private static Delegate GetOnSdkInitializationFailed_Ljava_lang_String_Lcom_unity3d_services_core_configuration_ErrorState_IHandler()
		{
			if (LoadModuleDecoratorInitializationBuffer.cb_onSdkInitializationFailed_Ljava_lang_String_Lcom_unity3d_services_core_configuration_ErrorState_I == null)
			{
				LoadModuleDecoratorInitializationBuffer.cb_onSdkInitializationFailed_Ljava_lang_String_Lcom_unity3d_services_core_configuration_ErrorState_I = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLLI_V(LoadModuleDecoratorInitializationBuffer.n_OnSdkInitializationFailed_Ljava_lang_String_Lcom_unity3d_services_core_configuration_ErrorState_I));
			}
			return LoadModuleDecoratorInitializationBuffer.cb_onSdkInitializationFailed_Ljava_lang_String_Lcom_unity3d_services_core_configuration_ErrorState_I;
		}

		// Token: 0x060017AE RID: 6062 RVA: 0x000446C0 File Offset: 0x000428C0
		private static void n_OnSdkInitializationFailed_Ljava_lang_String_Lcom_unity3d_services_core_configuration_ErrorState_I(IntPtr jnienv, IntPtr native__this, IntPtr native_message, IntPtr native_errorState, int code)
		{
			LoadModuleDecoratorInitializationBuffer @object = Java.Lang.Object.GetObject<LoadModuleDecoratorInitializationBuffer>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string @string = JNIEnv.GetString(native_message, JniHandleOwnership.DoNotTransfer);
			ErrorState object2 = Java.Lang.Object.GetObject<ErrorState>(native_errorState, JniHandleOwnership.DoNotTransfer);
			@object.OnSdkInitializationFailed(@string, object2, code);
		}

		// Token: 0x060017AF RID: 6063 RVA: 0x000446F0 File Offset: 0x000428F0
		[Register("onSdkInitializationFailed", "(Ljava/lang/String;Lcom/unity3d/services/core/configuration/ErrorState;I)V", "GetOnSdkInitializationFailed_Ljava_lang_String_Lcom_unity3d_services_core_configuration_ErrorState_IHandler")]
		public unsafe virtual void OnSdkInitializationFailed(string message, ErrorState errorState, int code)
		{
			IntPtr intPtr = JNIEnv.NewString(message);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((errorState == null) ? IntPtr.Zero : errorState.Handle);
				ptr[2] = new JniArgumentValue(code);
				LoadModuleDecoratorInitializationBuffer._members.InstanceMethods.InvokeVirtualVoidMethod("onSdkInitializationFailed.(Ljava/lang/String;Lcom/unity3d/services/core/configuration/ErrorState;I)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(errorState);
			}
		}

		// Token: 0x060017B0 RID: 6064 RVA: 0x0004478C File Offset: 0x0004298C
		private static Delegate GetOnSdkInitializedHandler()
		{
			if (LoadModuleDecoratorInitializationBuffer.cb_onSdkInitialized == null)
			{
				LoadModuleDecoratorInitializationBuffer.cb_onSdkInitialized = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(LoadModuleDecoratorInitializationBuffer.n_OnSdkInitialized));
			}
			return LoadModuleDecoratorInitializationBuffer.cb_onSdkInitialized;
		}

		// Token: 0x060017B1 RID: 6065 RVA: 0x000447B0 File Offset: 0x000429B0
		private static void n_OnSdkInitialized(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<LoadModuleDecoratorInitializationBuffer>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).OnSdkInitialized();
		}

		// Token: 0x060017B2 RID: 6066 RVA: 0x000447BF File Offset: 0x000429BF
		[Register("onSdkInitialized", "()V", "GetOnSdkInitializedHandler")]
		public virtual void OnSdkInitialized()
		{
			LoadModuleDecoratorInitializationBuffer._members.InstanceMethods.InvokeVirtualVoidMethod("onSdkInitialized.()V", this, null);
		}

		// Token: 0x040005C2 RID: 1474
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/services/ads/operation/load/LoadModuleDecoratorInitializationBuffer", typeof(LoadModuleDecoratorInitializationBuffer));

		// Token: 0x040005C3 RID: 1475
		private static Delegate cb_onSdkInitializationFailed_Ljava_lang_String_Lcom_unity3d_services_core_configuration_ErrorState_I;

		// Token: 0x040005C4 RID: 1476
		private static Delegate cb_onSdkInitialized;
	}
}
