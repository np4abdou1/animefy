using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Bumptech.Glide.Manager
{
	// Token: 0x02000072 RID: 114
	[Register("com/bumptech/glide/manager/ConnectivityMonitor$ConnectivityListener", DoNotGenerateAcw = true)]
	internal class IConnectivityMonitorConnectivityListenerInvoker : Java.Lang.Object, IConnectivityMonitorConnectivityListener, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x170000F9 RID: 249
		// (get) Token: 0x060004F4 RID: 1268 RVA: 0x000108DC File Offset: 0x0000EADC
		private static IntPtr java_class_ref
		{
			get
			{
				return IConnectivityMonitorConnectivityListenerInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170000FA RID: 250
		// (get) Token: 0x060004F5 RID: 1269 RVA: 0x00010900 File Offset: 0x0000EB00
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IConnectivityMonitorConnectivityListenerInvoker._members;
			}
		}

		// Token: 0x170000FB RID: 251
		// (get) Token: 0x060004F6 RID: 1270 RVA: 0x00010907 File Offset: 0x0000EB07
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x170000FC RID: 252
		// (get) Token: 0x060004F7 RID: 1271 RVA: 0x0001090F File Offset: 0x0000EB0F
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IConnectivityMonitorConnectivityListenerInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x060004F8 RID: 1272 RVA: 0x0001091B File Offset: 0x0000EB1B
		public static IConnectivityMonitorConnectivityListener GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IConnectivityMonitorConnectivityListener>(handle, transfer);
		}

		// Token: 0x060004F9 RID: 1273 RVA: 0x00010924 File Offset: 0x0000EB24
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IConnectivityMonitorConnectivityListenerInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'com.bumptech.glide.manager.ConnectivityMonitor.ConnectivityListener'.");
			}
			return handle;
		}

		// Token: 0x060004FA RID: 1274 RVA: 0x0001094F File Offset: 0x0000EB4F
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x060004FB RID: 1275 RVA: 0x00010980 File Offset: 0x0000EB80
		public IConnectivityMonitorConnectivityListenerInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IConnectivityMonitorConnectivityListenerInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x060004FC RID: 1276 RVA: 0x000109B8 File Offset: 0x0000EBB8
		private static Delegate GetOnConnectivityChanged_ZHandler()
		{
			if (IConnectivityMonitorConnectivityListenerInvoker.cb_onConnectivityChanged_Z == null)
			{
				IConnectivityMonitorConnectivityListenerInvoker.cb_onConnectivityChanged_Z = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPZ_V(IConnectivityMonitorConnectivityListenerInvoker.n_OnConnectivityChanged_Z));
			}
			return IConnectivityMonitorConnectivityListenerInvoker.cb_onConnectivityChanged_Z;
		}

		// Token: 0x060004FD RID: 1277 RVA: 0x000109DC File Offset: 0x0000EBDC
		private static void n_OnConnectivityChanged_Z(IntPtr jnienv, IntPtr native__this, bool p0)
		{
			Java.Lang.Object.GetObject<IConnectivityMonitorConnectivityListener>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).OnConnectivityChanged(p0);
		}

		// Token: 0x060004FE RID: 1278 RVA: 0x000109EC File Offset: 0x0000EBEC
		public unsafe void OnConnectivityChanged(bool p0)
		{
			if (this.id_onConnectivityChanged_Z == IntPtr.Zero)
			{
				this.id_onConnectivityChanged_Z = JNIEnv.GetMethodID(this.class_ref, "onConnectivityChanged", "(Z)V");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue(p0);
			JNIEnv.CallVoidMethod(base.Handle, this.id_onConnectivityChanged_Z, ptr);
		}

		// Token: 0x0400010C RID: 268
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/bumptech/glide/manager/ConnectivityMonitor$ConnectivityListener", typeof(IConnectivityMonitorConnectivityListenerInvoker));

		// Token: 0x0400010D RID: 269
		private IntPtr class_ref;

		// Token: 0x0400010E RID: 270
		private static Delegate cb_onConnectivityChanged_Z;

		// Token: 0x0400010F RID: 271
		private IntPtr id_onConnectivityChanged_Z;
	}
}
