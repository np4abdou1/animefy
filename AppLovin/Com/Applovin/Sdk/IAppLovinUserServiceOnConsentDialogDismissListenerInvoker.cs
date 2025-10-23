using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Com.Applovin.Sdk
{
	// Token: 0x02000096 RID: 150
	[Register("com/applovin/sdk/AppLovinUserService$OnConsentDialogDismissListener", DoNotGenerateAcw = true)]
	internal class IAppLovinUserServiceOnConsentDialogDismissListenerInvoker : Java.Lang.Object, IAppLovinUserServiceOnConsentDialogDismissListener, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x1700018F RID: 399
		// (get) Token: 0x0600050C RID: 1292 RVA: 0x0000D530 File Offset: 0x0000B730
		private static IntPtr java_class_ref
		{
			get
			{
				return IAppLovinUserServiceOnConsentDialogDismissListenerInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000190 RID: 400
		// (get) Token: 0x0600050D RID: 1293 RVA: 0x0000D554 File Offset: 0x0000B754
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IAppLovinUserServiceOnConsentDialogDismissListenerInvoker._members;
			}
		}

		// Token: 0x17000191 RID: 401
		// (get) Token: 0x0600050E RID: 1294 RVA: 0x0000D55B File Offset: 0x0000B75B
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x17000192 RID: 402
		// (get) Token: 0x0600050F RID: 1295 RVA: 0x0000D563 File Offset: 0x0000B763
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IAppLovinUserServiceOnConsentDialogDismissListenerInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06000510 RID: 1296 RVA: 0x0000D56F File Offset: 0x0000B76F
		public static IAppLovinUserServiceOnConsentDialogDismissListener GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IAppLovinUserServiceOnConsentDialogDismissListener>(handle, transfer);
		}

		// Token: 0x06000511 RID: 1297 RVA: 0x0000D578 File Offset: 0x0000B778
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IAppLovinUserServiceOnConsentDialogDismissListenerInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'com.applovin.sdk.AppLovinUserService.OnConsentDialogDismissListener'.");
			}
			return handle;
		}

		// Token: 0x06000512 RID: 1298 RVA: 0x0000D5A3 File Offset: 0x0000B7A3
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x06000513 RID: 1299 RVA: 0x0000D5D4 File Offset: 0x0000B7D4
		public IAppLovinUserServiceOnConsentDialogDismissListenerInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IAppLovinUserServiceOnConsentDialogDismissListenerInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x06000514 RID: 1300 RVA: 0x0000D60C File Offset: 0x0000B80C
		private static Delegate GetOnDismissHandler()
		{
			if (IAppLovinUserServiceOnConsentDialogDismissListenerInvoker.cb_onDismiss == null)
			{
				IAppLovinUserServiceOnConsentDialogDismissListenerInvoker.cb_onDismiss = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(IAppLovinUserServiceOnConsentDialogDismissListenerInvoker.n_OnDismiss));
			}
			return IAppLovinUserServiceOnConsentDialogDismissListenerInvoker.cb_onDismiss;
		}

		// Token: 0x06000515 RID: 1301 RVA: 0x0000D630 File Offset: 0x0000B830
		private static void n_OnDismiss(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<IAppLovinUserServiceOnConsentDialogDismissListener>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).OnDismiss();
		}

		// Token: 0x06000516 RID: 1302 RVA: 0x0000D63F File Offset: 0x0000B83F
		public void OnDismiss()
		{
			if (this.id_onDismiss == IntPtr.Zero)
			{
				this.id_onDismiss = JNIEnv.GetMethodID(this.class_ref, "onDismiss", "()V");
			}
			JNIEnv.CallVoidMethod(base.Handle, this.id_onDismiss);
		}

		// Token: 0x04000181 RID: 385
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/applovin/sdk/AppLovinUserService$OnConsentDialogDismissListener", typeof(IAppLovinUserServiceOnConsentDialogDismissListenerInvoker));

		// Token: 0x04000182 RID: 386
		private IntPtr class_ref;

		// Token: 0x04000183 RID: 387
		private static Delegate cb_onDismiss;

		// Token: 0x04000184 RID: 388
		private IntPtr id_onDismiss;
	}
}
