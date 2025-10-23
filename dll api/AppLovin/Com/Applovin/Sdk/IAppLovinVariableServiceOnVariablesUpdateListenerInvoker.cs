using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.OS;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Com.Applovin.Sdk
{
	// Token: 0x0200009B RID: 155
	[Register("com/applovin/sdk/AppLovinVariableService$OnVariablesUpdateListener", DoNotGenerateAcw = true)]
	internal class IAppLovinVariableServiceOnVariablesUpdateListenerInvoker : Java.Lang.Object, IAppLovinVariableServiceOnVariablesUpdateListener, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000197 RID: 407
		// (get) Token: 0x0600052D RID: 1325 RVA: 0x0000D960 File Offset: 0x0000BB60
		private static IntPtr java_class_ref
		{
			get
			{
				return IAppLovinVariableServiceOnVariablesUpdateListenerInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000198 RID: 408
		// (get) Token: 0x0600052E RID: 1326 RVA: 0x0000D984 File Offset: 0x0000BB84
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IAppLovinVariableServiceOnVariablesUpdateListenerInvoker._members;
			}
		}

		// Token: 0x17000199 RID: 409
		// (get) Token: 0x0600052F RID: 1327 RVA: 0x0000D98B File Offset: 0x0000BB8B
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x1700019A RID: 410
		// (get) Token: 0x06000530 RID: 1328 RVA: 0x0000D993 File Offset: 0x0000BB93
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IAppLovinVariableServiceOnVariablesUpdateListenerInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06000531 RID: 1329 RVA: 0x0000D99F File Offset: 0x0000BB9F
		public static IAppLovinVariableServiceOnVariablesUpdateListener GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IAppLovinVariableServiceOnVariablesUpdateListener>(handle, transfer);
		}

		// Token: 0x06000532 RID: 1330 RVA: 0x0000D9A8 File Offset: 0x0000BBA8
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IAppLovinVariableServiceOnVariablesUpdateListenerInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'com.applovin.sdk.AppLovinVariableService.OnVariablesUpdateListener'.");
			}
			return handle;
		}

		// Token: 0x06000533 RID: 1331 RVA: 0x0000D9D3 File Offset: 0x0000BBD3
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x06000534 RID: 1332 RVA: 0x0000DA04 File Offset: 0x0000BC04
		public IAppLovinVariableServiceOnVariablesUpdateListenerInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IAppLovinVariableServiceOnVariablesUpdateListenerInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x06000535 RID: 1333 RVA: 0x0000DA3C File Offset: 0x0000BC3C
		private static Delegate GetOnVariablesUpdate_Landroid_os_Bundle_Handler()
		{
			if (IAppLovinVariableServiceOnVariablesUpdateListenerInvoker.cb_onVariablesUpdate_Landroid_os_Bundle_ == null)
			{
				IAppLovinVariableServiceOnVariablesUpdateListenerInvoker.cb_onVariablesUpdate_Landroid_os_Bundle_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(IAppLovinVariableServiceOnVariablesUpdateListenerInvoker.n_OnVariablesUpdate_Landroid_os_Bundle_));
			}
			return IAppLovinVariableServiceOnVariablesUpdateListenerInvoker.cb_onVariablesUpdate_Landroid_os_Bundle_;
		}

		// Token: 0x06000536 RID: 1334 RVA: 0x0000DA60 File Offset: 0x0000BC60
		private static void n_OnVariablesUpdate_Landroid_os_Bundle_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			IAppLovinVariableServiceOnVariablesUpdateListener @object = Java.Lang.Object.GetObject<IAppLovinVariableServiceOnVariablesUpdateListener>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Bundle object2 = Java.Lang.Object.GetObject<Bundle>(native_p0, JniHandleOwnership.DoNotTransfer);
			@object.OnVariablesUpdate(object2);
		}

		// Token: 0x06000537 RID: 1335 RVA: 0x0000DA84 File Offset: 0x0000BC84
		public unsafe void OnVariablesUpdate(Bundle p0)
		{
			if (this.id_onVariablesUpdate_Landroid_os_Bundle_ == IntPtr.Zero)
			{
				this.id_onVariablesUpdate_Landroid_os_Bundle_ = JNIEnv.GetMethodID(this.class_ref, "onVariablesUpdate", "(Landroid/os/Bundle;)V");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((p0 == null) ? IntPtr.Zero : p0.Handle);
			JNIEnv.CallVoidMethod(base.Handle, this.id_onVariablesUpdate_Landroid_os_Bundle_, ptr);
		}

		// Token: 0x0400018D RID: 397
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/applovin/sdk/AppLovinVariableService$OnVariablesUpdateListener", typeof(IAppLovinVariableServiceOnVariablesUpdateListenerInvoker));

		// Token: 0x0400018E RID: 398
		private IntPtr class_ref;

		// Token: 0x0400018F RID: 399
		private static Delegate cb_onVariablesUpdate_Landroid_os_Bundle_;

		// Token: 0x04000190 RID: 400
		private IntPtr id_onVariablesUpdate_Landroid_os_Bundle_;
	}
}
