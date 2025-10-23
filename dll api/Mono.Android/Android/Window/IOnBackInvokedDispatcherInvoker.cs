using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Android.Window
{
	// Token: 0x0200009F RID: 159
	[Register("android/window/OnBackInvokedDispatcher", DoNotGenerateAcw = true, ApiSince = 33)]
	internal class IOnBackInvokedDispatcherInvoker : Java.Lang.Object, IOnBackInvokedDispatcher, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x1700001E RID: 30
		// (get) Token: 0x06000277 RID: 631 RVA: 0x00002CAC File Offset: 0x00000EAC
		private static IntPtr java_class_ref
		{
			get
			{
				return IOnBackInvokedDispatcherInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x06000278 RID: 632 RVA: 0x00002CD0 File Offset: 0x00000ED0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IOnBackInvokedDispatcherInvoker._members;
			}
		}

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x06000279 RID: 633 RVA: 0x00002CD7 File Offset: 0x00000ED7
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x0600027A RID: 634 RVA: 0x00002CDF File Offset: 0x00000EDF
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IOnBackInvokedDispatcherInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x0600027B RID: 635 RVA: 0x00002CEB File Offset: 0x00000EEB
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IOnBackInvokedDispatcherInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'android.window.OnBackInvokedDispatcher'.");
			}
			return handle;
		}

		// Token: 0x0600027C RID: 636 RVA: 0x00002D16 File Offset: 0x00000F16
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x0600027D RID: 637 RVA: 0x00002D48 File Offset: 0x00000F48
		public IOnBackInvokedDispatcherInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IOnBackInvokedDispatcherInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x0600027E RID: 638 RVA: 0x00002D80 File Offset: 0x00000F80
		private static Delegate GetRegisterOnBackInvokedCallback_ILandroid_window_OnBackInvokedCallback_Handler()
		{
			if (IOnBackInvokedDispatcherInvoker.cb_registerOnBackInvokedCallback_ILandroid_window_OnBackInvokedCallback_ == null)
			{
				IOnBackInvokedDispatcherInvoker.cb_registerOnBackInvokedCallback_ILandroid_window_OnBackInvokedCallback_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPIL_V(IOnBackInvokedDispatcherInvoker.n_RegisterOnBackInvokedCallback_ILandroid_window_OnBackInvokedCallback_));
			}
			return IOnBackInvokedDispatcherInvoker.cb_registerOnBackInvokedCallback_ILandroid_window_OnBackInvokedCallback_;
		}

		// Token: 0x0600027F RID: 639 RVA: 0x00002DA4 File Offset: 0x00000FA4
		private static void n_RegisterOnBackInvokedCallback_ILandroid_window_OnBackInvokedCallback_(IntPtr jnienv, IntPtr native__this, int priority, IntPtr native__callback)
		{
			IOnBackInvokedDispatcher @object = Java.Lang.Object.GetObject<IOnBackInvokedDispatcher>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IOnBackInvokedCallback object2 = Java.Lang.Object.GetObject<IOnBackInvokedCallback>(native__callback, JniHandleOwnership.DoNotTransfer);
			@object.RegisterOnBackInvokedCallback(priority, object2);
		}

		// Token: 0x06000280 RID: 640 RVA: 0x00002DC8 File Offset: 0x00000FC8
		public unsafe void RegisterOnBackInvokedCallback([IntDef(Type = "Android.Window.IOnBackInvokedDispatcher", Fields = new string[]
		{
			"PriorityDefault",
			"PriorityOverlay"
		})] int priority, IOnBackInvokedCallback callback)
		{
			if (this.id_registerOnBackInvokedCallback_ILandroid_window_OnBackInvokedCallback_ == IntPtr.Zero)
			{
				this.id_registerOnBackInvokedCallback_ILandroid_window_OnBackInvokedCallback_ = JNIEnv.GetMethodID(this.class_ref, "registerOnBackInvokedCallback", "(ILandroid/window/OnBackInvokedCallback;)V");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(priority);
			ptr[1] = new JValue((callback == null) ? IntPtr.Zero : ((Java.Lang.Object)callback).Handle);
			JNIEnv.CallVoidMethod(base.Handle, this.id_registerOnBackInvokedCallback_ILandroid_window_OnBackInvokedCallback_, ptr);
		}

		// Token: 0x06000281 RID: 641 RVA: 0x00002E53 File Offset: 0x00001053
		private static Delegate GetUnregisterOnBackInvokedCallback_Landroid_window_OnBackInvokedCallback_Handler()
		{
			if (IOnBackInvokedDispatcherInvoker.cb_unregisterOnBackInvokedCallback_Landroid_window_OnBackInvokedCallback_ == null)
			{
				IOnBackInvokedDispatcherInvoker.cb_unregisterOnBackInvokedCallback_Landroid_window_OnBackInvokedCallback_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(IOnBackInvokedDispatcherInvoker.n_UnregisterOnBackInvokedCallback_Landroid_window_OnBackInvokedCallback_));
			}
			return IOnBackInvokedDispatcherInvoker.cb_unregisterOnBackInvokedCallback_Landroid_window_OnBackInvokedCallback_;
		}

		// Token: 0x06000282 RID: 642 RVA: 0x00002E78 File Offset: 0x00001078
		private static void n_UnregisterOnBackInvokedCallback_Landroid_window_OnBackInvokedCallback_(IntPtr jnienv, IntPtr native__this, IntPtr native__callback)
		{
			IOnBackInvokedDispatcher @object = Java.Lang.Object.GetObject<IOnBackInvokedDispatcher>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IOnBackInvokedCallback object2 = Java.Lang.Object.GetObject<IOnBackInvokedCallback>(native__callback, JniHandleOwnership.DoNotTransfer);
			@object.UnregisterOnBackInvokedCallback(object2);
		}

		// Token: 0x06000283 RID: 643 RVA: 0x00002E9C File Offset: 0x0000109C
		public unsafe void UnregisterOnBackInvokedCallback(IOnBackInvokedCallback callback)
		{
			if (this.id_unregisterOnBackInvokedCallback_Landroid_window_OnBackInvokedCallback_ == IntPtr.Zero)
			{
				this.id_unregisterOnBackInvokedCallback_Landroid_window_OnBackInvokedCallback_ = JNIEnv.GetMethodID(this.class_ref, "unregisterOnBackInvokedCallback", "(Landroid/window/OnBackInvokedCallback;)V");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((callback == null) ? IntPtr.Zero : ((Java.Lang.Object)callback).Handle);
			JNIEnv.CallVoidMethod(base.Handle, this.id_unregisterOnBackInvokedCallback_Landroid_window_OnBackInvokedCallback_, ptr);
		}

		// Token: 0x04000036 RID: 54
		private static readonly JniPeerMembers _members = new XAPeerMembers("android/window/OnBackInvokedDispatcher", typeof(IOnBackInvokedDispatcherInvoker));

		// Token: 0x04000037 RID: 55
		private IntPtr class_ref;

		// Token: 0x04000038 RID: 56
		private static Delegate cb_registerOnBackInvokedCallback_ILandroid_window_OnBackInvokedCallback_;

		// Token: 0x04000039 RID: 57
		private IntPtr id_registerOnBackInvokedCallback_ILandroid_window_OnBackInvokedCallback_;

		// Token: 0x0400003A RID: 58
		private static Delegate cb_unregisterOnBackInvokedCallback_Landroid_window_OnBackInvokedCallback_;

		// Token: 0x0400003B RID: 59
		private IntPtr id_unregisterOnBackInvokedCallback_Landroid_window_OnBackInvokedCallback_;
	}
}
