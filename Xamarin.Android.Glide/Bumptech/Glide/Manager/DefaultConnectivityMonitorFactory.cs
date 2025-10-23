using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Content;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Bumptech.Glide.Manager
{
	// Token: 0x02000070 RID: 112
	[Register("com/bumptech/glide/manager/DefaultConnectivityMonitorFactory", DoNotGenerateAcw = true)]
	public class DefaultConnectivityMonitorFactory : Java.Lang.Object, IConnectivityMonitorFactory, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x170000F5 RID: 245
		// (get) Token: 0x060004E9 RID: 1257 RVA: 0x000106F0 File Offset: 0x0000E8F0
		internal static IntPtr class_ref
		{
			get
			{
				return DefaultConnectivityMonitorFactory._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170000F6 RID: 246
		// (get) Token: 0x060004EA RID: 1258 RVA: 0x00010714 File Offset: 0x0000E914
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return DefaultConnectivityMonitorFactory._members;
			}
		}

		// Token: 0x170000F7 RID: 247
		// (get) Token: 0x060004EB RID: 1259 RVA: 0x0001071C File Offset: 0x0000E91C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return DefaultConnectivityMonitorFactory._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170000F8 RID: 248
		// (get) Token: 0x060004EC RID: 1260 RVA: 0x00010740 File Offset: 0x0000E940
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return DefaultConnectivityMonitorFactory._members.ManagedPeerType;
			}
		}

		// Token: 0x060004ED RID: 1261 RVA: 0x0001074C File Offset: 0x0000E94C
		protected DefaultConnectivityMonitorFactory(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x060004EE RID: 1262 RVA: 0x00010758 File Offset: 0x0000E958
		[Register(".ctor", "()V", "")]
		public DefaultConnectivityMonitorFactory() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			base.SetHandle(DefaultConnectivityMonitorFactory._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
			DefaultConnectivityMonitorFactory._members.InstanceMethods.FinishCreateInstance("()V", this, null);
		}

		// Token: 0x060004EF RID: 1263 RVA: 0x000107C6 File Offset: 0x0000E9C6
		private static Delegate GetBuild_Landroid_content_Context_Lcom_bumptech_glide_manager_ConnectivityMonitor_ConnectivityListener_Handler()
		{
			if (DefaultConnectivityMonitorFactory.cb_build_Landroid_content_Context_Lcom_bumptech_glide_manager_ConnectivityMonitor_ConnectivityListener_ == null)
			{
				DefaultConnectivityMonitorFactory.cb_build_Landroid_content_Context_Lcom_bumptech_glide_manager_ConnectivityMonitor_ConnectivityListener_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_L(DefaultConnectivityMonitorFactory.n_Build_Landroid_content_Context_Lcom_bumptech_glide_manager_ConnectivityMonitor_ConnectivityListener_));
			}
			return DefaultConnectivityMonitorFactory.cb_build_Landroid_content_Context_Lcom_bumptech_glide_manager_ConnectivityMonitor_ConnectivityListener_;
		}

		// Token: 0x060004F0 RID: 1264 RVA: 0x000107EC File Offset: 0x0000E9EC
		private static IntPtr n_Build_Landroid_content_Context_Lcom_bumptech_glide_manager_ConnectivityMonitor_ConnectivityListener_(IntPtr jnienv, IntPtr native__this, IntPtr native_context, IntPtr native_listener)
		{
			DefaultConnectivityMonitorFactory @object = Java.Lang.Object.GetObject<DefaultConnectivityMonitorFactory>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Context object2 = Java.Lang.Object.GetObject<Context>(native_context, JniHandleOwnership.DoNotTransfer);
			IConnectivityMonitorConnectivityListener object3 = Java.Lang.Object.GetObject<IConnectivityMonitorConnectivityListener>(native_listener, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.Build(object2, object3));
		}

		// Token: 0x060004F1 RID: 1265 RVA: 0x00010820 File Offset: 0x0000EA20
		[Register("build", "(Landroid/content/Context;Lcom/bumptech/glide/manager/ConnectivityMonitor$ConnectivityListener;)Lcom/bumptech/glide/manager/ConnectivityMonitor;", "GetBuild_Landroid_content_Context_Lcom_bumptech_glide_manager_ConnectivityMonitor_ConnectivityListener_Handler")]
		public unsafe virtual IConnectivityMonitor Build(Context context, IConnectivityMonitorConnectivityListener listener)
		{
			IConnectivityMonitor @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((context == null) ? IntPtr.Zero : context.Handle);
				ptr[1] = new JniArgumentValue((listener == null) ? IntPtr.Zero : ((Java.Lang.Object)listener).Handle);
				@object = Java.Lang.Object.GetObject<IConnectivityMonitor>(DefaultConnectivityMonitorFactory._members.InstanceMethods.InvokeVirtualObjectMethod("build.(Landroid/content/Context;Lcom/bumptech/glide/manager/ConnectivityMonitor$ConnectivityListener;)Lcom/bumptech/glide/manager/ConnectivityMonitor;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(context);
				GC.KeepAlive(listener);
			}
			return @object;
		}

		// Token: 0x0400010A RID: 266
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/bumptech/glide/manager/DefaultConnectivityMonitorFactory", typeof(DefaultConnectivityMonitorFactory));

		// Token: 0x0400010B RID: 267
		private static Delegate cb_build_Landroid_content_Context_Lcom_bumptech_glide_manager_ConnectivityMonitor_ConnectivityListener_;
	}
}
