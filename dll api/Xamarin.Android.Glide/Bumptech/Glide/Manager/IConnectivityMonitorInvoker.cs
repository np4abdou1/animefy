using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Bumptech.Glide.Manager
{
	// Token: 0x02000076 RID: 118
	[Register("com/bumptech/glide/manager/ConnectivityMonitor", DoNotGenerateAcw = true)]
	internal class IConnectivityMonitorInvoker : Java.Lang.Object, IConnectivityMonitor, ILifecycleListener, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x170000FE RID: 254
		// (get) Token: 0x06000505 RID: 1285 RVA: 0x00010AF0 File Offset: 0x0000ECF0
		private static IntPtr java_class_ref
		{
			get
			{
				return IConnectivityMonitorInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170000FF RID: 255
		// (get) Token: 0x06000506 RID: 1286 RVA: 0x00010B14 File Offset: 0x0000ED14
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IConnectivityMonitorInvoker._members;
			}
		}

		// Token: 0x17000100 RID: 256
		// (get) Token: 0x06000507 RID: 1287 RVA: 0x00010B1B File Offset: 0x0000ED1B
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x17000101 RID: 257
		// (get) Token: 0x06000508 RID: 1288 RVA: 0x00010B23 File Offset: 0x0000ED23
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IConnectivityMonitorInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06000509 RID: 1289 RVA: 0x00010B2F File Offset: 0x0000ED2F
		public static IConnectivityMonitor GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IConnectivityMonitor>(handle, transfer);
		}

		// Token: 0x0600050A RID: 1290 RVA: 0x00010B38 File Offset: 0x0000ED38
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IConnectivityMonitorInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'com.bumptech.glide.manager.ConnectivityMonitor'.");
			}
			return handle;
		}

		// Token: 0x0600050B RID: 1291 RVA: 0x00010B63 File Offset: 0x0000ED63
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x0600050C RID: 1292 RVA: 0x00010B94 File Offset: 0x0000ED94
		public IConnectivityMonitorInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IConnectivityMonitorInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x0600050D RID: 1293 RVA: 0x00010BCC File Offset: 0x0000EDCC
		private static Delegate GetOnDestroyHandler()
		{
			if (IConnectivityMonitorInvoker.cb_onDestroy == null)
			{
				IConnectivityMonitorInvoker.cb_onDestroy = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(IConnectivityMonitorInvoker.n_OnDestroy));
			}
			return IConnectivityMonitorInvoker.cb_onDestroy;
		}

		// Token: 0x0600050E RID: 1294 RVA: 0x00010BF0 File Offset: 0x0000EDF0
		private static void n_OnDestroy(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<IConnectivityMonitor>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).OnDestroy();
		}

		// Token: 0x0600050F RID: 1295 RVA: 0x00010BFF File Offset: 0x0000EDFF
		public void OnDestroy()
		{
			if (this.id_onDestroy == IntPtr.Zero)
			{
				this.id_onDestroy = JNIEnv.GetMethodID(this.class_ref, "onDestroy", "()V");
			}
			JNIEnv.CallVoidMethod(base.Handle, this.id_onDestroy);
		}

		// Token: 0x06000510 RID: 1296 RVA: 0x00010C3F File Offset: 0x0000EE3F
		private static Delegate GetOnStartHandler()
		{
			if (IConnectivityMonitorInvoker.cb_onStart == null)
			{
				IConnectivityMonitorInvoker.cb_onStart = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(IConnectivityMonitorInvoker.n_OnStart));
			}
			return IConnectivityMonitorInvoker.cb_onStart;
		}

		// Token: 0x06000511 RID: 1297 RVA: 0x00010C63 File Offset: 0x0000EE63
		private static void n_OnStart(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<IConnectivityMonitor>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).OnStart();
		}

		// Token: 0x06000512 RID: 1298 RVA: 0x00010C72 File Offset: 0x0000EE72
		public void OnStart()
		{
			if (this.id_onStart == IntPtr.Zero)
			{
				this.id_onStart = JNIEnv.GetMethodID(this.class_ref, "onStart", "()V");
			}
			JNIEnv.CallVoidMethod(base.Handle, this.id_onStart);
		}

		// Token: 0x06000513 RID: 1299 RVA: 0x00010CB2 File Offset: 0x0000EEB2
		private static Delegate GetOnStopHandler()
		{
			if (IConnectivityMonitorInvoker.cb_onStop == null)
			{
				IConnectivityMonitorInvoker.cb_onStop = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(IConnectivityMonitorInvoker.n_OnStop));
			}
			return IConnectivityMonitorInvoker.cb_onStop;
		}

		// Token: 0x06000514 RID: 1300 RVA: 0x00010CD6 File Offset: 0x0000EED6
		private static void n_OnStop(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<IConnectivityMonitor>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).OnStop();
		}

		// Token: 0x06000515 RID: 1301 RVA: 0x00010CE5 File Offset: 0x0000EEE5
		public void OnStop()
		{
			if (this.id_onStop == IntPtr.Zero)
			{
				this.id_onStop = JNIEnv.GetMethodID(this.class_ref, "onStop", "()V");
			}
			JNIEnv.CallVoidMethod(base.Handle, this.id_onStop);
		}

		// Token: 0x04000113 RID: 275
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/bumptech/glide/manager/ConnectivityMonitor", typeof(IConnectivityMonitorInvoker));

		// Token: 0x04000114 RID: 276
		private IntPtr class_ref;

		// Token: 0x04000115 RID: 277
		private static Delegate cb_onDestroy;

		// Token: 0x04000116 RID: 278
		private IntPtr id_onDestroy;

		// Token: 0x04000117 RID: 279
		private static Delegate cb_onStart;

		// Token: 0x04000118 RID: 280
		private IntPtr id_onStart;

		// Token: 0x04000119 RID: 281
		private static Delegate cb_onStop;

		// Token: 0x0400011A RID: 282
		private IntPtr id_onStop;
	}
}
