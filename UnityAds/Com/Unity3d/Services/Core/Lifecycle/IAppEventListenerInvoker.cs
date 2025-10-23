using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Com.Unity3d.Services.Core.Lifecycle
{
	// Token: 0x020000F0 RID: 240
	[Register("com/unity3d/services/core/lifecycle/IAppEventListener", DoNotGenerateAcw = true)]
	internal class IAppEventListenerInvoker : Java.Lang.Object, IAppEventListener, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000303 RID: 771
		// (get) Token: 0x06000976 RID: 2422 RVA: 0x0001B9A4 File Offset: 0x00019BA4
		private static IntPtr java_class_ref
		{
			get
			{
				return IAppEventListenerInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000304 RID: 772
		// (get) Token: 0x06000977 RID: 2423 RVA: 0x0001B9C8 File Offset: 0x00019BC8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IAppEventListenerInvoker._members;
			}
		}

		// Token: 0x17000305 RID: 773
		// (get) Token: 0x06000978 RID: 2424 RVA: 0x0001B9CF File Offset: 0x00019BCF
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x17000306 RID: 774
		// (get) Token: 0x06000979 RID: 2425 RVA: 0x0001B9D7 File Offset: 0x00019BD7
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IAppEventListenerInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x0600097A RID: 2426 RVA: 0x0001B9E3 File Offset: 0x00019BE3
		public static IAppEventListener GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IAppEventListener>(handle, transfer);
		}

		// Token: 0x0600097B RID: 2427 RVA: 0x0001B9EC File Offset: 0x00019BEC
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IAppEventListenerInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'com.unity3d.services.core.lifecycle.IAppEventListener'.");
			}
			return handle;
		}

		// Token: 0x0600097C RID: 2428 RVA: 0x0001BA17 File Offset: 0x00019C17
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x0600097D RID: 2429 RVA: 0x0001BA48 File Offset: 0x00019C48
		public IAppEventListenerInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IAppEventListenerInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x0600097E RID: 2430 RVA: 0x0001BA80 File Offset: 0x00019C80
		private static Delegate GetOnLifecycleEvent_Lcom_unity3d_services_core_lifecycle_LifecycleEvent_Handler()
		{
			if (IAppEventListenerInvoker.cb_onLifecycleEvent_Lcom_unity3d_services_core_lifecycle_LifecycleEvent_ == null)
			{
				IAppEventListenerInvoker.cb_onLifecycleEvent_Lcom_unity3d_services_core_lifecycle_LifecycleEvent_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(IAppEventListenerInvoker.n_OnLifecycleEvent_Lcom_unity3d_services_core_lifecycle_LifecycleEvent_));
			}
			return IAppEventListenerInvoker.cb_onLifecycleEvent_Lcom_unity3d_services_core_lifecycle_LifecycleEvent_;
		}

		// Token: 0x0600097F RID: 2431 RVA: 0x0001BAA4 File Offset: 0x00019CA4
		private static void n_OnLifecycleEvent_Lcom_unity3d_services_core_lifecycle_LifecycleEvent_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			IAppEventListener @object = Java.Lang.Object.GetObject<IAppEventListener>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			LifecycleEvent object2 = Java.Lang.Object.GetObject<LifecycleEvent>(native_p0, JniHandleOwnership.DoNotTransfer);
			@object.OnLifecycleEvent(object2);
		}

		// Token: 0x06000980 RID: 2432 RVA: 0x0001BAC8 File Offset: 0x00019CC8
		public unsafe void OnLifecycleEvent(LifecycleEvent p0)
		{
			if (this.id_onLifecycleEvent_Lcom_unity3d_services_core_lifecycle_LifecycleEvent_ == IntPtr.Zero)
			{
				this.id_onLifecycleEvent_Lcom_unity3d_services_core_lifecycle_LifecycleEvent_ = JNIEnv.GetMethodID(this.class_ref, "onLifecycleEvent", "(Lcom/unity3d/services/core/lifecycle/LifecycleEvent;)V");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((p0 == null) ? IntPtr.Zero : p0.Handle);
			JNIEnv.CallVoidMethod(base.Handle, this.id_onLifecycleEvent_Lcom_unity3d_services_core_lifecycle_LifecycleEvent_, ptr);
		}

		// Token: 0x04000238 RID: 568
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/services/core/lifecycle/IAppEventListener", typeof(IAppEventListenerInvoker));

		// Token: 0x04000239 RID: 569
		private IntPtr class_ref;

		// Token: 0x0400023A RID: 570
		private static Delegate cb_onLifecycleEvent_Lcom_unity3d_services_core_lifecycle_LifecycleEvent_;

		// Token: 0x0400023B RID: 571
		private IntPtr id_onLifecycleEvent_Lcom_unity3d_services_core_lifecycle_LifecycleEvent_;
	}
}
