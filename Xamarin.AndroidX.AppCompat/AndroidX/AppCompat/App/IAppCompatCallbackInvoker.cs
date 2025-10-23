using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using AndroidX.AppCompat.View;
using Java.Interop;
using Java.Lang;

namespace AndroidX.AppCompat.App
{
	// Token: 0x0200005A RID: 90
	[Register("androidx/appcompat/app/AppCompatCallback", DoNotGenerateAcw = true)]
	internal class IAppCompatCallbackInvoker : Java.Lang.Object, IAppCompatCallback, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x170000A2 RID: 162
		// (get) Token: 0x06000527 RID: 1319 RVA: 0x0000DB6C File Offset: 0x0000BD6C
		private static IntPtr java_class_ref
		{
			get
			{
				return IAppCompatCallbackInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170000A3 RID: 163
		// (get) Token: 0x06000528 RID: 1320 RVA: 0x0000DB90 File Offset: 0x0000BD90
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IAppCompatCallbackInvoker._members;
			}
		}

		// Token: 0x170000A4 RID: 164
		// (get) Token: 0x06000529 RID: 1321 RVA: 0x0000DB97 File Offset: 0x0000BD97
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x170000A5 RID: 165
		// (get) Token: 0x0600052A RID: 1322 RVA: 0x0000DB9F File Offset: 0x0000BD9F
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IAppCompatCallbackInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x0600052B RID: 1323 RVA: 0x0000DBAB File Offset: 0x0000BDAB
		public static IAppCompatCallback GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IAppCompatCallback>(handle, transfer);
		}

		// Token: 0x0600052C RID: 1324 RVA: 0x0000DBB4 File Offset: 0x0000BDB4
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IAppCompatCallbackInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'androidx.appcompat.app.AppCompatCallback'.");
			}
			return handle;
		}

		// Token: 0x0600052D RID: 1325 RVA: 0x0000DBDF File Offset: 0x0000BDDF
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x0600052E RID: 1326 RVA: 0x0000DC10 File Offset: 0x0000BE10
		public IAppCompatCallbackInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IAppCompatCallbackInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x0600052F RID: 1327 RVA: 0x0000DC48 File Offset: 0x0000BE48
		private static Delegate GetOnSupportActionModeFinished_Landroidx_appcompat_view_ActionMode_Handler()
		{
			if (IAppCompatCallbackInvoker.cb_onSupportActionModeFinished_Landroidx_appcompat_view_ActionMode_ == null)
			{
				IAppCompatCallbackInvoker.cb_onSupportActionModeFinished_Landroidx_appcompat_view_ActionMode_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(IAppCompatCallbackInvoker.n_OnSupportActionModeFinished_Landroidx_appcompat_view_ActionMode_));
			}
			return IAppCompatCallbackInvoker.cb_onSupportActionModeFinished_Landroidx_appcompat_view_ActionMode_;
		}

		// Token: 0x06000530 RID: 1328 RVA: 0x0000DC6C File Offset: 0x0000BE6C
		private static void n_OnSupportActionModeFinished_Landroidx_appcompat_view_ActionMode_(IntPtr jnienv, IntPtr native__this, IntPtr native_mode)
		{
			IAppCompatCallback @object = Java.Lang.Object.GetObject<IAppCompatCallback>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ActionMode object2 = Java.Lang.Object.GetObject<ActionMode>(native_mode, JniHandleOwnership.DoNotTransfer);
			@object.OnSupportActionModeFinished(object2);
		}

		// Token: 0x06000531 RID: 1329 RVA: 0x0000DC90 File Offset: 0x0000BE90
		public unsafe void OnSupportActionModeFinished(ActionMode mode)
		{
			if (this.id_onSupportActionModeFinished_Landroidx_appcompat_view_ActionMode_ == IntPtr.Zero)
			{
				this.id_onSupportActionModeFinished_Landroidx_appcompat_view_ActionMode_ = JNIEnv.GetMethodID(this.class_ref, "onSupportActionModeFinished", "(Landroidx/appcompat/view/ActionMode;)V");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((mode == null) ? IntPtr.Zero : mode.Handle);
			JNIEnv.CallVoidMethod(base.Handle, this.id_onSupportActionModeFinished_Landroidx_appcompat_view_ActionMode_, ptr);
		}

		// Token: 0x06000532 RID: 1330 RVA: 0x0000DD03 File Offset: 0x0000BF03
		private static Delegate GetOnSupportActionModeStarted_Landroidx_appcompat_view_ActionMode_Handler()
		{
			if (IAppCompatCallbackInvoker.cb_onSupportActionModeStarted_Landroidx_appcompat_view_ActionMode_ == null)
			{
				IAppCompatCallbackInvoker.cb_onSupportActionModeStarted_Landroidx_appcompat_view_ActionMode_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(IAppCompatCallbackInvoker.n_OnSupportActionModeStarted_Landroidx_appcompat_view_ActionMode_));
			}
			return IAppCompatCallbackInvoker.cb_onSupportActionModeStarted_Landroidx_appcompat_view_ActionMode_;
		}

		// Token: 0x06000533 RID: 1331 RVA: 0x0000DD28 File Offset: 0x0000BF28
		private static void n_OnSupportActionModeStarted_Landroidx_appcompat_view_ActionMode_(IntPtr jnienv, IntPtr native__this, IntPtr native_mode)
		{
			IAppCompatCallback @object = Java.Lang.Object.GetObject<IAppCompatCallback>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ActionMode object2 = Java.Lang.Object.GetObject<ActionMode>(native_mode, JniHandleOwnership.DoNotTransfer);
			@object.OnSupportActionModeStarted(object2);
		}

		// Token: 0x06000534 RID: 1332 RVA: 0x0000DD4C File Offset: 0x0000BF4C
		public unsafe void OnSupportActionModeStarted(ActionMode mode)
		{
			if (this.id_onSupportActionModeStarted_Landroidx_appcompat_view_ActionMode_ == IntPtr.Zero)
			{
				this.id_onSupportActionModeStarted_Landroidx_appcompat_view_ActionMode_ = JNIEnv.GetMethodID(this.class_ref, "onSupportActionModeStarted", "(Landroidx/appcompat/view/ActionMode;)V");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((mode == null) ? IntPtr.Zero : mode.Handle);
			JNIEnv.CallVoidMethod(base.Handle, this.id_onSupportActionModeStarted_Landroidx_appcompat_view_ActionMode_, ptr);
		}

		// Token: 0x06000535 RID: 1333 RVA: 0x0000DDBF File Offset: 0x0000BFBF
		private static Delegate GetOnWindowStartingSupportActionMode_Landroidx_appcompat_view_ActionMode_Callback_Handler()
		{
			if (IAppCompatCallbackInvoker.cb_onWindowStartingSupportActionMode_Landroidx_appcompat_view_ActionMode_Callback_ == null)
			{
				IAppCompatCallbackInvoker.cb_onWindowStartingSupportActionMode_Landroidx_appcompat_view_ActionMode_Callback_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_L(IAppCompatCallbackInvoker.n_OnWindowStartingSupportActionMode_Landroidx_appcompat_view_ActionMode_Callback_));
			}
			return IAppCompatCallbackInvoker.cb_onWindowStartingSupportActionMode_Landroidx_appcompat_view_ActionMode_Callback_;
		}

		// Token: 0x06000536 RID: 1334 RVA: 0x0000DDE4 File Offset: 0x0000BFE4
		private static IntPtr n_OnWindowStartingSupportActionMode_Landroidx_appcompat_view_ActionMode_Callback_(IntPtr jnienv, IntPtr native__this, IntPtr native_callback)
		{
			IAppCompatCallback @object = Java.Lang.Object.GetObject<IAppCompatCallback>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ActionMode.ICallback object2 = Java.Lang.Object.GetObject<ActionMode.ICallback>(native_callback, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle(@object.OnWindowStartingSupportActionMode(object2));
		}

		// Token: 0x06000537 RID: 1335 RVA: 0x0000DE0C File Offset: 0x0000C00C
		public unsafe ActionMode OnWindowStartingSupportActionMode(ActionMode.ICallback callback_)
		{
			if (this.id_onWindowStartingSupportActionMode_Landroidx_appcompat_view_ActionMode_Callback_ == IntPtr.Zero)
			{
				this.id_onWindowStartingSupportActionMode_Landroidx_appcompat_view_ActionMode_Callback_ = JNIEnv.GetMethodID(this.class_ref, "onWindowStartingSupportActionMode", "(Landroidx/appcompat/view/ActionMode$Callback;)Landroidx/appcompat/view/ActionMode;");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((callback_ == null) ? IntPtr.Zero : ((Java.Lang.Object)callback_).Handle);
			return Java.Lang.Object.GetObject<ActionMode>(JNIEnv.CallObjectMethod(base.Handle, this.id_onWindowStartingSupportActionMode_Landroidx_appcompat_view_ActionMode_Callback_, ptr), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x04000131 RID: 305
		private static readonly JniPeerMembers _members = new XAPeerMembers("androidx/appcompat/app/AppCompatCallback", typeof(IAppCompatCallbackInvoker));

		// Token: 0x04000132 RID: 306
		private IntPtr class_ref;

		// Token: 0x04000133 RID: 307
		private static Delegate cb_onSupportActionModeFinished_Landroidx_appcompat_view_ActionMode_;

		// Token: 0x04000134 RID: 308
		private IntPtr id_onSupportActionModeFinished_Landroidx_appcompat_view_ActionMode_;

		// Token: 0x04000135 RID: 309
		private static Delegate cb_onSupportActionModeStarted_Landroidx_appcompat_view_ActionMode_;

		// Token: 0x04000136 RID: 310
		private IntPtr id_onSupportActionModeStarted_Landroidx_appcompat_view_ActionMode_;

		// Token: 0x04000137 RID: 311
		private static Delegate cb_onWindowStartingSupportActionMode_Landroidx_appcompat_view_ActionMode_Callback_;

		// Token: 0x04000138 RID: 312
		private IntPtr id_onWindowStartingSupportActionMode_Landroidx_appcompat_view_ActionMode_Callback_;
	}
}
