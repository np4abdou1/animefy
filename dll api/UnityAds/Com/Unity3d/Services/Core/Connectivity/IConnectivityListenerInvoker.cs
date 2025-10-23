using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Com.Unity3d.Services.Core.Connectivity
{
	// Token: 0x0200014C RID: 332
	[Register("com/unity3d/services/core/connectivity/IConnectivityListener", DoNotGenerateAcw = true)]
	internal class IConnectivityListenerInvoker : Java.Lang.Object, IConnectivityListener, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x170004C8 RID: 1224
		// (get) Token: 0x06000D47 RID: 3399 RVA: 0x00025394 File Offset: 0x00023594
		private static IntPtr java_class_ref
		{
			get
			{
				return IConnectivityListenerInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170004C9 RID: 1225
		// (get) Token: 0x06000D48 RID: 3400 RVA: 0x000253B8 File Offset: 0x000235B8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IConnectivityListenerInvoker._members;
			}
		}

		// Token: 0x170004CA RID: 1226
		// (get) Token: 0x06000D49 RID: 3401 RVA: 0x000253BF File Offset: 0x000235BF
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x170004CB RID: 1227
		// (get) Token: 0x06000D4A RID: 3402 RVA: 0x000253C7 File Offset: 0x000235C7
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IConnectivityListenerInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06000D4B RID: 3403 RVA: 0x000253D3 File Offset: 0x000235D3
		public static IConnectivityListener GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IConnectivityListener>(handle, transfer);
		}

		// Token: 0x06000D4C RID: 3404 RVA: 0x000253DC File Offset: 0x000235DC
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IConnectivityListenerInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'com.unity3d.services.core.connectivity.IConnectivityListener'.");
			}
			return handle;
		}

		// Token: 0x06000D4D RID: 3405 RVA: 0x00025407 File Offset: 0x00023607
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x06000D4E RID: 3406 RVA: 0x00025438 File Offset: 0x00023638
		public IConnectivityListenerInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IConnectivityListenerInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x06000D4F RID: 3407 RVA: 0x00025470 File Offset: 0x00023670
		private static Delegate GetOnConnectedHandler()
		{
			if (IConnectivityListenerInvoker.cb_onConnected == null)
			{
				IConnectivityListenerInvoker.cb_onConnected = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(IConnectivityListenerInvoker.n_OnConnected));
			}
			return IConnectivityListenerInvoker.cb_onConnected;
		}

		// Token: 0x06000D50 RID: 3408 RVA: 0x00025494 File Offset: 0x00023694
		private static void n_OnConnected(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<IConnectivityListener>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).OnConnected();
		}

		// Token: 0x06000D51 RID: 3409 RVA: 0x000254A3 File Offset: 0x000236A3
		public void OnConnected()
		{
			if (this.id_onConnected == IntPtr.Zero)
			{
				this.id_onConnected = JNIEnv.GetMethodID(this.class_ref, "onConnected", "()V");
			}
			JNIEnv.CallVoidMethod(base.Handle, this.id_onConnected);
		}

		// Token: 0x06000D52 RID: 3410 RVA: 0x000254E3 File Offset: 0x000236E3
		private static Delegate GetOnDisconnectedHandler()
		{
			if (IConnectivityListenerInvoker.cb_onDisconnected == null)
			{
				IConnectivityListenerInvoker.cb_onDisconnected = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(IConnectivityListenerInvoker.n_OnDisconnected));
			}
			return IConnectivityListenerInvoker.cb_onDisconnected;
		}

		// Token: 0x06000D53 RID: 3411 RVA: 0x00025507 File Offset: 0x00023707
		private static void n_OnDisconnected(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<IConnectivityListener>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).OnDisconnected();
		}

		// Token: 0x06000D54 RID: 3412 RVA: 0x00025516 File Offset: 0x00023716
		public void OnDisconnected()
		{
			if (this.id_onDisconnected == IntPtr.Zero)
			{
				this.id_onDisconnected = JNIEnv.GetMethodID(this.class_ref, "onDisconnected", "()V");
			}
			JNIEnv.CallVoidMethod(base.Handle, this.id_onDisconnected);
		}

		// Token: 0x0400030A RID: 778
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/services/core/connectivity/IConnectivityListener", typeof(IConnectivityListenerInvoker));

		// Token: 0x0400030B RID: 779
		private IntPtr class_ref;

		// Token: 0x0400030C RID: 780
		private static Delegate cb_onConnected;

		// Token: 0x0400030D RID: 781
		private IntPtr id_onConnected;

		// Token: 0x0400030E RID: 782
		private static Delegate cb_onDisconnected;

		// Token: 0x0400030F RID: 783
		private IntPtr id_onDisconnected;
	}
}
