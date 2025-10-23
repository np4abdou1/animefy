using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Content;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Bumptech.Glide.Manager
{
	// Token: 0x02000078 RID: 120
	[Register("com/bumptech/glide/manager/ConnectivityMonitorFactory", DoNotGenerateAcw = true)]
	internal class IConnectivityMonitorFactoryInvoker : Java.Lang.Object, IConnectivityMonitorFactory, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000102 RID: 258
		// (get) Token: 0x06000518 RID: 1304 RVA: 0x00010D40 File Offset: 0x0000EF40
		private static IntPtr java_class_ref
		{
			get
			{
				return IConnectivityMonitorFactoryInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000103 RID: 259
		// (get) Token: 0x06000519 RID: 1305 RVA: 0x00010D64 File Offset: 0x0000EF64
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IConnectivityMonitorFactoryInvoker._members;
			}
		}

		// Token: 0x17000104 RID: 260
		// (get) Token: 0x0600051A RID: 1306 RVA: 0x00010D6B File Offset: 0x0000EF6B
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x17000105 RID: 261
		// (get) Token: 0x0600051B RID: 1307 RVA: 0x00010D73 File Offset: 0x0000EF73
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IConnectivityMonitorFactoryInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x0600051C RID: 1308 RVA: 0x00010D7F File Offset: 0x0000EF7F
		public static IConnectivityMonitorFactory GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IConnectivityMonitorFactory>(handle, transfer);
		}

		// Token: 0x0600051D RID: 1309 RVA: 0x00010D88 File Offset: 0x0000EF88
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IConnectivityMonitorFactoryInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'com.bumptech.glide.manager.ConnectivityMonitorFactory'.");
			}
			return handle;
		}

		// Token: 0x0600051E RID: 1310 RVA: 0x00010DB3 File Offset: 0x0000EFB3
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x0600051F RID: 1311 RVA: 0x00010DE4 File Offset: 0x0000EFE4
		public IConnectivityMonitorFactoryInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IConnectivityMonitorFactoryInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x06000520 RID: 1312 RVA: 0x00010E1C File Offset: 0x0000F01C
		private static Delegate GetBuild_Landroid_content_Context_Lcom_bumptech_glide_manager_ConnectivityMonitor_ConnectivityListener_Handler()
		{
			if (IConnectivityMonitorFactoryInvoker.cb_build_Landroid_content_Context_Lcom_bumptech_glide_manager_ConnectivityMonitor_ConnectivityListener_ == null)
			{
				IConnectivityMonitorFactoryInvoker.cb_build_Landroid_content_Context_Lcom_bumptech_glide_manager_ConnectivityMonitor_ConnectivityListener_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_L(IConnectivityMonitorFactoryInvoker.n_Build_Landroid_content_Context_Lcom_bumptech_glide_manager_ConnectivityMonitor_ConnectivityListener_));
			}
			return IConnectivityMonitorFactoryInvoker.cb_build_Landroid_content_Context_Lcom_bumptech_glide_manager_ConnectivityMonitor_ConnectivityListener_;
		}

		// Token: 0x06000521 RID: 1313 RVA: 0x00010E40 File Offset: 0x0000F040
		private static IntPtr n_Build_Landroid_content_Context_Lcom_bumptech_glide_manager_ConnectivityMonitor_ConnectivityListener_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			IConnectivityMonitorFactory @object = Java.Lang.Object.GetObject<IConnectivityMonitorFactory>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Context object2 = Java.Lang.Object.GetObject<Context>(native_p0, JniHandleOwnership.DoNotTransfer);
			IConnectivityMonitorConnectivityListener object3 = Java.Lang.Object.GetObject<IConnectivityMonitorConnectivityListener>(native_p1, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.Build(object2, object3));
		}

		// Token: 0x06000522 RID: 1314 RVA: 0x00010E74 File Offset: 0x0000F074
		public unsafe IConnectivityMonitor Build(Context p0, IConnectivityMonitorConnectivityListener p1)
		{
			if (this.id_build_Landroid_content_Context_Lcom_bumptech_glide_manager_ConnectivityMonitor_ConnectivityListener_ == IntPtr.Zero)
			{
				this.id_build_Landroid_content_Context_Lcom_bumptech_glide_manager_ConnectivityMonitor_ConnectivityListener_ = JNIEnv.GetMethodID(this.class_ref, "build", "(Landroid/content/Context;Lcom/bumptech/glide/manager/ConnectivityMonitor$ConnectivityListener;)Lcom/bumptech/glide/manager/ConnectivityMonitor;");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((p0 == null) ? IntPtr.Zero : p0.Handle);
			ptr[1] = new JValue((p1 == null) ? IntPtr.Zero : ((Java.Lang.Object)p1).Handle);
			return Java.Lang.Object.GetObject<IConnectivityMonitor>(JNIEnv.CallObjectMethod(base.Handle, this.id_build_Landroid_content_Context_Lcom_bumptech_glide_manager_ConnectivityMonitor_ConnectivityListener_, ptr), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x0400011B RID: 283
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/bumptech/glide/manager/ConnectivityMonitorFactory", typeof(IConnectivityMonitorFactoryInvoker));

		// Token: 0x0400011C RID: 284
		private IntPtr class_ref;

		// Token: 0x0400011D RID: 285
		private static Delegate cb_build_Landroid_content_Context_Lcom_bumptech_glide_manager_ConnectivityMonitor_ConnectivityListener_;

		// Token: 0x0400011E RID: 286
		private IntPtr id_build_Landroid_content_Context_Lcom_bumptech_glide_manager_ConnectivityMonitor_ConnectivityListener_;
	}
}
