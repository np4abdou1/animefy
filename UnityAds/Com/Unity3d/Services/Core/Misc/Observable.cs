using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Com.Unity3d.Services.Core.Misc
{
	// Token: 0x020000E3 RID: 227
	[Register("com/unity3d/services/core/misc/Observable", DoNotGenerateAcw = true)]
	[JavaTypeParameters(new string[]
	{
		"T"
	})]
	public abstract class Observable : Java.Lang.Object
	{
		// Token: 0x170002D9 RID: 729
		// (get) Token: 0x060008FB RID: 2299 RVA: 0x00019FA4 File Offset: 0x000181A4
		internal static IntPtr class_ref
		{
			get
			{
				return Observable._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170002DA RID: 730
		// (get) Token: 0x060008FC RID: 2300 RVA: 0x00019FC8 File Offset: 0x000181C8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return Observable._members;
			}
		}

		// Token: 0x170002DB RID: 731
		// (get) Token: 0x060008FD RID: 2301 RVA: 0x00019FD0 File Offset: 0x000181D0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return Observable._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170002DC RID: 732
		// (get) Token: 0x060008FE RID: 2302 RVA: 0x00019FF4 File Offset: 0x000181F4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return Observable._members.ManagedPeerType;
			}
		}

		// Token: 0x060008FF RID: 2303 RVA: 0x000021E8 File Offset: 0x000003E8
		protected Observable(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000900 RID: 2304 RVA: 0x0001A000 File Offset: 0x00018200
		[Register(".ctor", "()V", "")]
		public Observable() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			base.SetHandle(Observable._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
			Observable._members.InstanceMethods.FinishCreateInstance("()V", this, null);
		}

		// Token: 0x06000901 RID: 2305 RVA: 0x0001A06E File Offset: 0x0001826E
		private static Delegate GetNotifyObservers_Ljava_lang_Object_Handler()
		{
			if (Observable.cb_notifyObservers_Ljava_lang_Object_ == null)
			{
				Observable.cb_notifyObservers_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(Observable.n_NotifyObservers_Ljava_lang_Object_));
			}
			return Observable.cb_notifyObservers_Ljava_lang_Object_;
		}

		// Token: 0x06000902 RID: 2306 RVA: 0x0001A094 File Offset: 0x00018294
		private static void n_NotifyObservers_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_value)
		{
			Observable @object = Java.Lang.Object.GetObject<Observable>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Java.Lang.Object object2 = Java.Lang.Object.GetObject<Java.Lang.Object>(native_value, JniHandleOwnership.DoNotTransfer);
			@object.NotifyObservers(object2);
		}

		// Token: 0x06000903 RID: 2307 RVA: 0x0001A0B8 File Offset: 0x000182B8
		[Register("notifyObservers", "(Ljava/lang/Object;)V", "GetNotifyObservers_Ljava_lang_Object_Handler")]
		protected unsafe virtual void NotifyObservers(Java.Lang.Object value)
		{
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(value);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				Observable._members.InstanceMethods.InvokeVirtualVoidMethod("notifyObservers.(Ljava/lang/Object;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(value);
			}
		}

		// Token: 0x06000904 RID: 2308 RVA: 0x0001A11C File Offset: 0x0001831C
		private static Delegate GetRegisterObserver_Lcom_unity3d_services_core_misc_IObserver_Handler()
		{
			if (Observable.cb_registerObserver_Lcom_unity3d_services_core_misc_IObserver_ == null)
			{
				Observable.cb_registerObserver_Lcom_unity3d_services_core_misc_IObserver_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(Observable.n_RegisterObserver_Lcom_unity3d_services_core_misc_IObserver_));
			}
			return Observable.cb_registerObserver_Lcom_unity3d_services_core_misc_IObserver_;
		}

		// Token: 0x06000905 RID: 2309 RVA: 0x0001A140 File Offset: 0x00018340
		private static void n_RegisterObserver_Lcom_unity3d_services_core_misc_IObserver_(IntPtr jnienv, IntPtr native__this, IntPtr native_observer)
		{
			Observable @object = Java.Lang.Object.GetObject<Observable>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IObserver object2 = Java.Lang.Object.GetObject<IObserver>(native_observer, JniHandleOwnership.DoNotTransfer);
			@object.RegisterObserver(object2);
		}

		// Token: 0x06000906 RID: 2310 RVA: 0x0001A164 File Offset: 0x00018364
		[Register("registerObserver", "(Lcom/unity3d/services/core/misc/IObserver;)V", "GetRegisterObserver_Lcom_unity3d_services_core_misc_IObserver_Handler")]
		public unsafe virtual void RegisterObserver(IObserver observer)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((observer == null) ? IntPtr.Zero : ((Java.Lang.Object)observer).Handle);
				Observable._members.InstanceMethods.InvokeVirtualVoidMethod("registerObserver.(Lcom/unity3d/services/core/misc/IObserver;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(observer);
			}
		}

		// Token: 0x06000907 RID: 2311 RVA: 0x0001A1CC File Offset: 0x000183CC
		private static Delegate GetUnregisterObserver_Lcom_unity3d_services_core_misc_IObserver_Handler()
		{
			if (Observable.cb_unregisterObserver_Lcom_unity3d_services_core_misc_IObserver_ == null)
			{
				Observable.cb_unregisterObserver_Lcom_unity3d_services_core_misc_IObserver_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(Observable.n_UnregisterObserver_Lcom_unity3d_services_core_misc_IObserver_));
			}
			return Observable.cb_unregisterObserver_Lcom_unity3d_services_core_misc_IObserver_;
		}

		// Token: 0x06000908 RID: 2312 RVA: 0x0001A1F0 File Offset: 0x000183F0
		private static void n_UnregisterObserver_Lcom_unity3d_services_core_misc_IObserver_(IntPtr jnienv, IntPtr native__this, IntPtr native_observer)
		{
			Observable @object = Java.Lang.Object.GetObject<Observable>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IObserver object2 = Java.Lang.Object.GetObject<IObserver>(native_observer, JniHandleOwnership.DoNotTransfer);
			@object.UnregisterObserver(object2);
		}

		// Token: 0x06000909 RID: 2313 RVA: 0x0001A214 File Offset: 0x00018414
		[Register("unregisterObserver", "(Lcom/unity3d/services/core/misc/IObserver;)V", "GetUnregisterObserver_Lcom_unity3d_services_core_misc_IObserver_Handler")]
		public unsafe virtual void UnregisterObserver(IObserver observer)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((observer == null) ? IntPtr.Zero : ((Java.Lang.Object)observer).Handle);
				Observable._members.InstanceMethods.InvokeVirtualVoidMethod("unregisterObserver.(Lcom/unity3d/services/core/misc/IObserver;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(observer);
			}
		}

		// Token: 0x04000222 RID: 546
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/services/core/misc/Observable", typeof(Observable));

		// Token: 0x04000223 RID: 547
		private static Delegate cb_notifyObservers_Ljava_lang_Object_;

		// Token: 0x04000224 RID: 548
		private static Delegate cb_registerObserver_Lcom_unity3d_services_core_misc_IObserver_;

		// Token: 0x04000225 RID: 549
		private static Delegate cb_unregisterObserver_Lcom_unity3d_services_core_misc_IObserver_;
	}
}
