using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Com.Unity3d.Services.Core.Lifecycle
{
	// Token: 0x020000EC RID: 236
	[Register("com/unity3d/services/core/lifecycle/IAppActiveListener", DoNotGenerateAcw = true)]
	internal class IAppActiveListenerInvoker : Java.Lang.Object, IAppActiveListener, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x170002FE RID: 766
		// (get) Token: 0x06000964 RID: 2404 RVA: 0x0001B790 File Offset: 0x00019990
		private static IntPtr java_class_ref
		{
			get
			{
				return IAppActiveListenerInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170002FF RID: 767
		// (get) Token: 0x06000965 RID: 2405 RVA: 0x0001B7B4 File Offset: 0x000199B4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IAppActiveListenerInvoker._members;
			}
		}

		// Token: 0x17000300 RID: 768
		// (get) Token: 0x06000966 RID: 2406 RVA: 0x0001B7BB File Offset: 0x000199BB
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x17000301 RID: 769
		// (get) Token: 0x06000967 RID: 2407 RVA: 0x0001B7C3 File Offset: 0x000199C3
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IAppActiveListenerInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06000968 RID: 2408 RVA: 0x0001B7CF File Offset: 0x000199CF
		public static IAppActiveListener GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IAppActiveListener>(handle, transfer);
		}

		// Token: 0x06000969 RID: 2409 RVA: 0x0001B7D8 File Offset: 0x000199D8
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IAppActiveListenerInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'com.unity3d.services.core.lifecycle.IAppActiveListener'.");
			}
			return handle;
		}

		// Token: 0x0600096A RID: 2410 RVA: 0x0001B803 File Offset: 0x00019A03
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x0600096B RID: 2411 RVA: 0x0001B834 File Offset: 0x00019A34
		public IAppActiveListenerInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IAppActiveListenerInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x0600096C RID: 2412 RVA: 0x0001B86C File Offset: 0x00019A6C
		private static Delegate GetOnAppStateChanged_ZHandler()
		{
			if (IAppActiveListenerInvoker.cb_onAppStateChanged_Z == null)
			{
				IAppActiveListenerInvoker.cb_onAppStateChanged_Z = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPZ_V(IAppActiveListenerInvoker.n_OnAppStateChanged_Z));
			}
			return IAppActiveListenerInvoker.cb_onAppStateChanged_Z;
		}

		// Token: 0x0600096D RID: 2413 RVA: 0x0001B890 File Offset: 0x00019A90
		private static void n_OnAppStateChanged_Z(IntPtr jnienv, IntPtr native__this, bool p0)
		{
			Java.Lang.Object.GetObject<IAppActiveListener>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).OnAppStateChanged(p0);
		}

		// Token: 0x0600096E RID: 2414 RVA: 0x0001B8A0 File Offset: 0x00019AA0
		public unsafe void OnAppStateChanged(bool p0)
		{
			if (this.id_onAppStateChanged_Z == IntPtr.Zero)
			{
				this.id_onAppStateChanged_Z = JNIEnv.GetMethodID(this.class_ref, "onAppStateChanged", "(Z)V");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(p0);
			JNIEnv.CallVoidMethod(base.Handle, this.id_onAppStateChanged_Z, ptr);
		}

		// Token: 0x04000231 RID: 561
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/services/core/lifecycle/IAppActiveListener", typeof(IAppActiveListenerInvoker));

		// Token: 0x04000232 RID: 562
		private IntPtr class_ref;

		// Token: 0x04000233 RID: 563
		private static Delegate cb_onAppStateChanged_Z;

		// Token: 0x04000234 RID: 564
		private IntPtr id_onAppStateChanged_Z;
	}
}
