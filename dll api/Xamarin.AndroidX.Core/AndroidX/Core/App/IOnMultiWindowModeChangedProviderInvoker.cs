using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using AndroidX.Core.Util;
using Java.Interop;
using Java.Lang;

namespace AndroidX.Core.App
{
	// Token: 0x0200006B RID: 107
	[Register("androidx/core/app/OnMultiWindowModeChangedProvider", DoNotGenerateAcw = true)]
	internal class IOnMultiWindowModeChangedProviderInvoker : Java.Lang.Object, IOnMultiWindowModeChangedProvider, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x170000B6 RID: 182
		// (get) Token: 0x0600041E RID: 1054 RVA: 0x0000BFA4 File Offset: 0x0000A1A4
		private static IntPtr java_class_ref
		{
			get
			{
				return IOnMultiWindowModeChangedProviderInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170000B7 RID: 183
		// (get) Token: 0x0600041F RID: 1055 RVA: 0x0000BFC8 File Offset: 0x0000A1C8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IOnMultiWindowModeChangedProviderInvoker._members;
			}
		}

		// Token: 0x170000B8 RID: 184
		// (get) Token: 0x06000420 RID: 1056 RVA: 0x0000BFCF File Offset: 0x0000A1CF
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x170000B9 RID: 185
		// (get) Token: 0x06000421 RID: 1057 RVA: 0x0000BFD7 File Offset: 0x0000A1D7
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IOnMultiWindowModeChangedProviderInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06000422 RID: 1058 RVA: 0x0000BFE3 File Offset: 0x0000A1E3
		public static IOnMultiWindowModeChangedProvider GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IOnMultiWindowModeChangedProvider>(handle, transfer);
		}

		// Token: 0x06000423 RID: 1059 RVA: 0x0000BFEC File Offset: 0x0000A1EC
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IOnMultiWindowModeChangedProviderInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'androidx.core.app.OnMultiWindowModeChangedProvider'.");
			}
			return handle;
		}

		// Token: 0x06000424 RID: 1060 RVA: 0x0000C017 File Offset: 0x0000A217
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x06000425 RID: 1061 RVA: 0x0000C048 File Offset: 0x0000A248
		public IOnMultiWindowModeChangedProviderInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IOnMultiWindowModeChangedProviderInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x06000426 RID: 1062 RVA: 0x0000C080 File Offset: 0x0000A280
		private static Delegate GetAddOnMultiWindowModeChangedListener_Landroidx_core_util_Consumer_Handler()
		{
			if (IOnMultiWindowModeChangedProviderInvoker.cb_addOnMultiWindowModeChangedListener_Landroidx_core_util_Consumer_ == null)
			{
				IOnMultiWindowModeChangedProviderInvoker.cb_addOnMultiWindowModeChangedListener_Landroidx_core_util_Consumer_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(IOnMultiWindowModeChangedProviderInvoker.n_AddOnMultiWindowModeChangedListener_Landroidx_core_util_Consumer_));
			}
			return IOnMultiWindowModeChangedProviderInvoker.cb_addOnMultiWindowModeChangedListener_Landroidx_core_util_Consumer_;
		}

		// Token: 0x06000427 RID: 1063 RVA: 0x0000C0A4 File Offset: 0x0000A2A4
		private static void n_AddOnMultiWindowModeChangedListener_Landroidx_core_util_Consumer_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			IOnMultiWindowModeChangedProvider @object = Java.Lang.Object.GetObject<IOnMultiWindowModeChangedProvider>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IConsumer object2 = Java.Lang.Object.GetObject<IConsumer>(native_p0, JniHandleOwnership.DoNotTransfer);
			@object.AddOnMultiWindowModeChangedListener(object2);
		}

		// Token: 0x06000428 RID: 1064 RVA: 0x0000C0C8 File Offset: 0x0000A2C8
		public unsafe void AddOnMultiWindowModeChangedListener(IConsumer p0)
		{
			if (this.id_addOnMultiWindowModeChangedListener_Landroidx_core_util_Consumer_ == IntPtr.Zero)
			{
				this.id_addOnMultiWindowModeChangedListener_Landroidx_core_util_Consumer_ = JNIEnv.GetMethodID(this.class_ref, "addOnMultiWindowModeChangedListener", "(Landroidx/core/util/Consumer;)V");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((p0 == null) ? IntPtr.Zero : ((Java.Lang.Object)p0).Handle);
			JNIEnv.CallVoidMethod(base.Handle, this.id_addOnMultiWindowModeChangedListener_Landroidx_core_util_Consumer_, ptr);
		}

		// Token: 0x06000429 RID: 1065 RVA: 0x0000C140 File Offset: 0x0000A340
		private static Delegate GetRemoveOnMultiWindowModeChangedListener_Landroidx_core_util_Consumer_Handler()
		{
			if (IOnMultiWindowModeChangedProviderInvoker.cb_removeOnMultiWindowModeChangedListener_Landroidx_core_util_Consumer_ == null)
			{
				IOnMultiWindowModeChangedProviderInvoker.cb_removeOnMultiWindowModeChangedListener_Landroidx_core_util_Consumer_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(IOnMultiWindowModeChangedProviderInvoker.n_RemoveOnMultiWindowModeChangedListener_Landroidx_core_util_Consumer_));
			}
			return IOnMultiWindowModeChangedProviderInvoker.cb_removeOnMultiWindowModeChangedListener_Landroidx_core_util_Consumer_;
		}

		// Token: 0x0600042A RID: 1066 RVA: 0x0000C164 File Offset: 0x0000A364
		private static void n_RemoveOnMultiWindowModeChangedListener_Landroidx_core_util_Consumer_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			IOnMultiWindowModeChangedProvider @object = Java.Lang.Object.GetObject<IOnMultiWindowModeChangedProvider>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IConsumer object2 = Java.Lang.Object.GetObject<IConsumer>(native_p0, JniHandleOwnership.DoNotTransfer);
			@object.RemoveOnMultiWindowModeChangedListener(object2);
		}

		// Token: 0x0600042B RID: 1067 RVA: 0x0000C188 File Offset: 0x0000A388
		public unsafe void RemoveOnMultiWindowModeChangedListener(IConsumer p0)
		{
			if (this.id_removeOnMultiWindowModeChangedListener_Landroidx_core_util_Consumer_ == IntPtr.Zero)
			{
				this.id_removeOnMultiWindowModeChangedListener_Landroidx_core_util_Consumer_ = JNIEnv.GetMethodID(this.class_ref, "removeOnMultiWindowModeChangedListener", "(Landroidx/core/util/Consumer;)V");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((p0 == null) ? IntPtr.Zero : ((Java.Lang.Object)p0).Handle);
			JNIEnv.CallVoidMethod(base.Handle, this.id_removeOnMultiWindowModeChangedListener_Landroidx_core_util_Consumer_, ptr);
		}

		// Token: 0x04000114 RID: 276
		private static readonly JniPeerMembers _members = new XAPeerMembers("androidx/core/app/OnMultiWindowModeChangedProvider", typeof(IOnMultiWindowModeChangedProviderInvoker));

		// Token: 0x04000115 RID: 277
		private IntPtr class_ref;

		// Token: 0x04000116 RID: 278
		private static Delegate cb_addOnMultiWindowModeChangedListener_Landroidx_core_util_Consumer_;

		// Token: 0x04000117 RID: 279
		private IntPtr id_addOnMultiWindowModeChangedListener_Landroidx_core_util_Consumer_;

		// Token: 0x04000118 RID: 280
		private static Delegate cb_removeOnMultiWindowModeChangedListener_Landroidx_core_util_Consumer_;

		// Token: 0x04000119 RID: 281
		private IntPtr id_removeOnMultiWindowModeChangedListener_Landroidx_core_util_Consumer_;
	}
}
