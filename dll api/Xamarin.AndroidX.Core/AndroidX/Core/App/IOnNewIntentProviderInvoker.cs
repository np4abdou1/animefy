using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using AndroidX.Core.Util;
using Java.Interop;
using Java.Lang;

namespace AndroidX.Core.App
{
	// Token: 0x0200006D RID: 109
	[Register("androidx/core/app/OnNewIntentProvider", DoNotGenerateAcw = true)]
	internal class IOnNewIntentProviderInvoker : Java.Lang.Object, IOnNewIntentProvider, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x170000BA RID: 186
		// (get) Token: 0x0600042F RID: 1071 RVA: 0x0000C21C File Offset: 0x0000A41C
		private static IntPtr java_class_ref
		{
			get
			{
				return IOnNewIntentProviderInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170000BB RID: 187
		// (get) Token: 0x06000430 RID: 1072 RVA: 0x0000C240 File Offset: 0x0000A440
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IOnNewIntentProviderInvoker._members;
			}
		}

		// Token: 0x170000BC RID: 188
		// (get) Token: 0x06000431 RID: 1073 RVA: 0x0000C247 File Offset: 0x0000A447
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x170000BD RID: 189
		// (get) Token: 0x06000432 RID: 1074 RVA: 0x0000C24F File Offset: 0x0000A44F
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IOnNewIntentProviderInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06000433 RID: 1075 RVA: 0x0000C25B File Offset: 0x0000A45B
		public static IOnNewIntentProvider GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IOnNewIntentProvider>(handle, transfer);
		}

		// Token: 0x06000434 RID: 1076 RVA: 0x0000C264 File Offset: 0x0000A464
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IOnNewIntentProviderInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'androidx.core.app.OnNewIntentProvider'.");
			}
			return handle;
		}

		// Token: 0x06000435 RID: 1077 RVA: 0x0000C28F File Offset: 0x0000A48F
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x06000436 RID: 1078 RVA: 0x0000C2C0 File Offset: 0x0000A4C0
		public IOnNewIntentProviderInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IOnNewIntentProviderInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x06000437 RID: 1079 RVA: 0x0000C2F8 File Offset: 0x0000A4F8
		private static Delegate GetAddOnNewIntentListener_Landroidx_core_util_Consumer_Handler()
		{
			if (IOnNewIntentProviderInvoker.cb_addOnNewIntentListener_Landroidx_core_util_Consumer_ == null)
			{
				IOnNewIntentProviderInvoker.cb_addOnNewIntentListener_Landroidx_core_util_Consumer_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(IOnNewIntentProviderInvoker.n_AddOnNewIntentListener_Landroidx_core_util_Consumer_));
			}
			return IOnNewIntentProviderInvoker.cb_addOnNewIntentListener_Landroidx_core_util_Consumer_;
		}

		// Token: 0x06000438 RID: 1080 RVA: 0x0000C31C File Offset: 0x0000A51C
		private static void n_AddOnNewIntentListener_Landroidx_core_util_Consumer_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			IOnNewIntentProvider @object = Java.Lang.Object.GetObject<IOnNewIntentProvider>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IConsumer object2 = Java.Lang.Object.GetObject<IConsumer>(native_p0, JniHandleOwnership.DoNotTransfer);
			@object.AddOnNewIntentListener(object2);
		}

		// Token: 0x06000439 RID: 1081 RVA: 0x0000C340 File Offset: 0x0000A540
		public unsafe void AddOnNewIntentListener(IConsumer p0)
		{
			if (this.id_addOnNewIntentListener_Landroidx_core_util_Consumer_ == IntPtr.Zero)
			{
				this.id_addOnNewIntentListener_Landroidx_core_util_Consumer_ = JNIEnv.GetMethodID(this.class_ref, "addOnNewIntentListener", "(Landroidx/core/util/Consumer;)V");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((p0 == null) ? IntPtr.Zero : ((Java.Lang.Object)p0).Handle);
			JNIEnv.CallVoidMethod(base.Handle, this.id_addOnNewIntentListener_Landroidx_core_util_Consumer_, ptr);
		}

		// Token: 0x0600043A RID: 1082 RVA: 0x0000C3B8 File Offset: 0x0000A5B8
		private static Delegate GetRemoveOnNewIntentListener_Landroidx_core_util_Consumer_Handler()
		{
			if (IOnNewIntentProviderInvoker.cb_removeOnNewIntentListener_Landroidx_core_util_Consumer_ == null)
			{
				IOnNewIntentProviderInvoker.cb_removeOnNewIntentListener_Landroidx_core_util_Consumer_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(IOnNewIntentProviderInvoker.n_RemoveOnNewIntentListener_Landroidx_core_util_Consumer_));
			}
			return IOnNewIntentProviderInvoker.cb_removeOnNewIntentListener_Landroidx_core_util_Consumer_;
		}

		// Token: 0x0600043B RID: 1083 RVA: 0x0000C3DC File Offset: 0x0000A5DC
		private static void n_RemoveOnNewIntentListener_Landroidx_core_util_Consumer_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			IOnNewIntentProvider @object = Java.Lang.Object.GetObject<IOnNewIntentProvider>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IConsumer object2 = Java.Lang.Object.GetObject<IConsumer>(native_p0, JniHandleOwnership.DoNotTransfer);
			@object.RemoveOnNewIntentListener(object2);
		}

		// Token: 0x0600043C RID: 1084 RVA: 0x0000C400 File Offset: 0x0000A600
		public unsafe void RemoveOnNewIntentListener(IConsumer p0)
		{
			if (this.id_removeOnNewIntentListener_Landroidx_core_util_Consumer_ == IntPtr.Zero)
			{
				this.id_removeOnNewIntentListener_Landroidx_core_util_Consumer_ = JNIEnv.GetMethodID(this.class_ref, "removeOnNewIntentListener", "(Landroidx/core/util/Consumer;)V");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((p0 == null) ? IntPtr.Zero : ((Java.Lang.Object)p0).Handle);
			JNIEnv.CallVoidMethod(base.Handle, this.id_removeOnNewIntentListener_Landroidx_core_util_Consumer_, ptr);
		}

		// Token: 0x0400011A RID: 282
		private static readonly JniPeerMembers _members = new XAPeerMembers("androidx/core/app/OnNewIntentProvider", typeof(IOnNewIntentProviderInvoker));

		// Token: 0x0400011B RID: 283
		private IntPtr class_ref;

		// Token: 0x0400011C RID: 284
		private static Delegate cb_addOnNewIntentListener_Landroidx_core_util_Consumer_;

		// Token: 0x0400011D RID: 285
		private IntPtr id_addOnNewIntentListener_Landroidx_core_util_Consumer_;

		// Token: 0x0400011E RID: 286
		private static Delegate cb_removeOnNewIntentListener_Landroidx_core_util_Consumer_;

		// Token: 0x0400011F RID: 287
		private IntPtr id_removeOnNewIntentListener_Landroidx_core_util_Consumer_;
	}
}
