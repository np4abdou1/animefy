using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using AndroidX.Core.Util;
using Java.Interop;
using Java.Lang;

namespace AndroidX.Core.App
{
	// Token: 0x0200006F RID: 111
	[Register("androidx/core/app/OnPictureInPictureModeChangedProvider", DoNotGenerateAcw = true)]
	internal class IOnPictureInPictureModeChangedProviderInvoker : Java.Lang.Object, IOnPictureInPictureModeChangedProvider, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x170000BE RID: 190
		// (get) Token: 0x06000440 RID: 1088 RVA: 0x0000C494 File Offset: 0x0000A694
		private static IntPtr java_class_ref
		{
			get
			{
				return IOnPictureInPictureModeChangedProviderInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170000BF RID: 191
		// (get) Token: 0x06000441 RID: 1089 RVA: 0x0000C4B8 File Offset: 0x0000A6B8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IOnPictureInPictureModeChangedProviderInvoker._members;
			}
		}

		// Token: 0x170000C0 RID: 192
		// (get) Token: 0x06000442 RID: 1090 RVA: 0x0000C4BF File Offset: 0x0000A6BF
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x170000C1 RID: 193
		// (get) Token: 0x06000443 RID: 1091 RVA: 0x0000C4C7 File Offset: 0x0000A6C7
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IOnPictureInPictureModeChangedProviderInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06000444 RID: 1092 RVA: 0x0000C4D3 File Offset: 0x0000A6D3
		public static IOnPictureInPictureModeChangedProvider GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IOnPictureInPictureModeChangedProvider>(handle, transfer);
		}

		// Token: 0x06000445 RID: 1093 RVA: 0x0000C4DC File Offset: 0x0000A6DC
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IOnPictureInPictureModeChangedProviderInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'androidx.core.app.OnPictureInPictureModeChangedProvider'.");
			}
			return handle;
		}

		// Token: 0x06000446 RID: 1094 RVA: 0x0000C507 File Offset: 0x0000A707
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x06000447 RID: 1095 RVA: 0x0000C538 File Offset: 0x0000A738
		public IOnPictureInPictureModeChangedProviderInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IOnPictureInPictureModeChangedProviderInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x06000448 RID: 1096 RVA: 0x0000C570 File Offset: 0x0000A770
		private static Delegate GetAddOnPictureInPictureModeChangedListener_Landroidx_core_util_Consumer_Handler()
		{
			if (IOnPictureInPictureModeChangedProviderInvoker.cb_addOnPictureInPictureModeChangedListener_Landroidx_core_util_Consumer_ == null)
			{
				IOnPictureInPictureModeChangedProviderInvoker.cb_addOnPictureInPictureModeChangedListener_Landroidx_core_util_Consumer_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(IOnPictureInPictureModeChangedProviderInvoker.n_AddOnPictureInPictureModeChangedListener_Landroidx_core_util_Consumer_));
			}
			return IOnPictureInPictureModeChangedProviderInvoker.cb_addOnPictureInPictureModeChangedListener_Landroidx_core_util_Consumer_;
		}

		// Token: 0x06000449 RID: 1097 RVA: 0x0000C594 File Offset: 0x0000A794
		private static void n_AddOnPictureInPictureModeChangedListener_Landroidx_core_util_Consumer_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			IOnPictureInPictureModeChangedProvider @object = Java.Lang.Object.GetObject<IOnPictureInPictureModeChangedProvider>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IConsumer object2 = Java.Lang.Object.GetObject<IConsumer>(native_p0, JniHandleOwnership.DoNotTransfer);
			@object.AddOnPictureInPictureModeChangedListener(object2);
		}

		// Token: 0x0600044A RID: 1098 RVA: 0x0000C5B8 File Offset: 0x0000A7B8
		public unsafe void AddOnPictureInPictureModeChangedListener(IConsumer p0)
		{
			if (this.id_addOnPictureInPictureModeChangedListener_Landroidx_core_util_Consumer_ == IntPtr.Zero)
			{
				this.id_addOnPictureInPictureModeChangedListener_Landroidx_core_util_Consumer_ = JNIEnv.GetMethodID(this.class_ref, "addOnPictureInPictureModeChangedListener", "(Landroidx/core/util/Consumer;)V");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((p0 == null) ? IntPtr.Zero : ((Java.Lang.Object)p0).Handle);
			JNIEnv.CallVoidMethod(base.Handle, this.id_addOnPictureInPictureModeChangedListener_Landroidx_core_util_Consumer_, ptr);
		}

		// Token: 0x0600044B RID: 1099 RVA: 0x0000C630 File Offset: 0x0000A830
		private static Delegate GetRemoveOnPictureInPictureModeChangedListener_Landroidx_core_util_Consumer_Handler()
		{
			if (IOnPictureInPictureModeChangedProviderInvoker.cb_removeOnPictureInPictureModeChangedListener_Landroidx_core_util_Consumer_ == null)
			{
				IOnPictureInPictureModeChangedProviderInvoker.cb_removeOnPictureInPictureModeChangedListener_Landroidx_core_util_Consumer_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(IOnPictureInPictureModeChangedProviderInvoker.n_RemoveOnPictureInPictureModeChangedListener_Landroidx_core_util_Consumer_));
			}
			return IOnPictureInPictureModeChangedProviderInvoker.cb_removeOnPictureInPictureModeChangedListener_Landroidx_core_util_Consumer_;
		}

		// Token: 0x0600044C RID: 1100 RVA: 0x0000C654 File Offset: 0x0000A854
		private static void n_RemoveOnPictureInPictureModeChangedListener_Landroidx_core_util_Consumer_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			IOnPictureInPictureModeChangedProvider @object = Java.Lang.Object.GetObject<IOnPictureInPictureModeChangedProvider>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			IConsumer object2 = Java.Lang.Object.GetObject<IConsumer>(native_p0, JniHandleOwnership.DoNotTransfer);
			@object.RemoveOnPictureInPictureModeChangedListener(object2);
		}

		// Token: 0x0600044D RID: 1101 RVA: 0x0000C678 File Offset: 0x0000A878
		public unsafe void RemoveOnPictureInPictureModeChangedListener(IConsumer p0)
		{
			if (this.id_removeOnPictureInPictureModeChangedListener_Landroidx_core_util_Consumer_ == IntPtr.Zero)
			{
				this.id_removeOnPictureInPictureModeChangedListener_Landroidx_core_util_Consumer_ = JNIEnv.GetMethodID(this.class_ref, "removeOnPictureInPictureModeChangedListener", "(Landroidx/core/util/Consumer;)V");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((p0 == null) ? IntPtr.Zero : ((Java.Lang.Object)p0).Handle);
			JNIEnv.CallVoidMethod(base.Handle, this.id_removeOnPictureInPictureModeChangedListener_Landroidx_core_util_Consumer_, ptr);
		}

		// Token: 0x04000120 RID: 288
		private static readonly JniPeerMembers _members = new XAPeerMembers("androidx/core/app/OnPictureInPictureModeChangedProvider", typeof(IOnPictureInPictureModeChangedProviderInvoker));

		// Token: 0x04000121 RID: 289
		private IntPtr class_ref;

		// Token: 0x04000122 RID: 290
		private static Delegate cb_addOnPictureInPictureModeChangedListener_Landroidx_core_util_Consumer_;

		// Token: 0x04000123 RID: 291
		private IntPtr id_addOnPictureInPictureModeChangedListener_Landroidx_core_util_Consumer_;

		// Token: 0x04000124 RID: 292
		private static Delegate cb_removeOnPictureInPictureModeChangedListener_Landroidx_core_util_Consumer_;

		// Token: 0x04000125 RID: 293
		private IntPtr id_removeOnPictureInPictureModeChangedListener_Landroidx_core_util_Consumer_;
	}
}
