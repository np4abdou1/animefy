using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Bumptech.Glide.Manager
{
	// Token: 0x0200007A RID: 122
	[Register("com/bumptech/glide/manager/Lifecycle", DoNotGenerateAcw = true)]
	internal class ILifecycleInvoker : Java.Lang.Object, ILifecycle, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000106 RID: 262
		// (get) Token: 0x06000526 RID: 1318 RVA: 0x00010F30 File Offset: 0x0000F130
		private static IntPtr java_class_ref
		{
			get
			{
				return ILifecycleInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000107 RID: 263
		// (get) Token: 0x06000527 RID: 1319 RVA: 0x00010F54 File Offset: 0x0000F154
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return ILifecycleInvoker._members;
			}
		}

		// Token: 0x17000108 RID: 264
		// (get) Token: 0x06000528 RID: 1320 RVA: 0x00010F5B File Offset: 0x0000F15B
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x17000109 RID: 265
		// (get) Token: 0x06000529 RID: 1321 RVA: 0x00010F63 File Offset: 0x0000F163
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return ILifecycleInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x0600052A RID: 1322 RVA: 0x00010F6F File Offset: 0x0000F16F
		public static ILifecycle GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<ILifecycle>(handle, transfer);
		}

		// Token: 0x0600052B RID: 1323 RVA: 0x00010F78 File Offset: 0x0000F178
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, ILifecycleInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'com.bumptech.glide.manager.Lifecycle'.");
			}
			return handle;
		}

		// Token: 0x0600052C RID: 1324 RVA: 0x00010FA3 File Offset: 0x0000F1A3
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x0600052D RID: 1325 RVA: 0x00010FD4 File Offset: 0x0000F1D4
		public ILifecycleInvoker(IntPtr handle, JniHandleOwnership transfer) : base(ILifecycleInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x0600052E RID: 1326 RVA: 0x0001100C File Offset: 0x0000F20C
		private static Delegate GetAddListener_Lcom_bumptech_glide_manager_LifecycleListener_Handler()
		{
			if (ILifecycleInvoker.cb_addListener_Lcom_bumptech_glide_manager_LifecycleListener_ == null)
			{
				ILifecycleInvoker.cb_addListener_Lcom_bumptech_glide_manager_LifecycleListener_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(ILifecycleInvoker.n_AddListener_Lcom_bumptech_glide_manager_LifecycleListener_));
			}
			return ILifecycleInvoker.cb_addListener_Lcom_bumptech_glide_manager_LifecycleListener_;
		}

		// Token: 0x0600052F RID: 1327 RVA: 0x00011030 File Offset: 0x0000F230
		private static void n_AddListener_Lcom_bumptech_glide_manager_LifecycleListener_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			ILifecycle @object = Java.Lang.Object.GetObject<ILifecycle>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ILifecycleListener object2 = Java.Lang.Object.GetObject<ILifecycleListener>(native_p0, JniHandleOwnership.DoNotTransfer);
			@object.AddListener(object2);
		}

		// Token: 0x06000530 RID: 1328 RVA: 0x00011054 File Offset: 0x0000F254
		public unsafe void AddListener(ILifecycleListener p0)
		{
			if (this.id_addListener_Lcom_bumptech_glide_manager_LifecycleListener_ == IntPtr.Zero)
			{
				this.id_addListener_Lcom_bumptech_glide_manager_LifecycleListener_ = JNIEnv.GetMethodID(this.class_ref, "addListener", "(Lcom/bumptech/glide/manager/LifecycleListener;)V");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((p0 == null) ? IntPtr.Zero : ((Java.Lang.Object)p0).Handle);
			JNIEnv.CallVoidMethod(base.Handle, this.id_addListener_Lcom_bumptech_glide_manager_LifecycleListener_, ptr);
		}

		// Token: 0x06000531 RID: 1329 RVA: 0x000110CC File Offset: 0x0000F2CC
		private static Delegate GetRemoveListener_Lcom_bumptech_glide_manager_LifecycleListener_Handler()
		{
			if (ILifecycleInvoker.cb_removeListener_Lcom_bumptech_glide_manager_LifecycleListener_ == null)
			{
				ILifecycleInvoker.cb_removeListener_Lcom_bumptech_glide_manager_LifecycleListener_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(ILifecycleInvoker.n_RemoveListener_Lcom_bumptech_glide_manager_LifecycleListener_));
			}
			return ILifecycleInvoker.cb_removeListener_Lcom_bumptech_glide_manager_LifecycleListener_;
		}

		// Token: 0x06000532 RID: 1330 RVA: 0x000110F0 File Offset: 0x0000F2F0
		private static void n_RemoveListener_Lcom_bumptech_glide_manager_LifecycleListener_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			ILifecycle @object = Java.Lang.Object.GetObject<ILifecycle>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			ILifecycleListener object2 = Java.Lang.Object.GetObject<ILifecycleListener>(native_p0, JniHandleOwnership.DoNotTransfer);
			@object.RemoveListener(object2);
		}

		// Token: 0x06000533 RID: 1331 RVA: 0x00011114 File Offset: 0x0000F314
		public unsafe void RemoveListener(ILifecycleListener p0)
		{
			if (this.id_removeListener_Lcom_bumptech_glide_manager_LifecycleListener_ == IntPtr.Zero)
			{
				this.id_removeListener_Lcom_bumptech_glide_manager_LifecycleListener_ = JNIEnv.GetMethodID(this.class_ref, "removeListener", "(Lcom/bumptech/glide/manager/LifecycleListener;)V");
			}
			JValue* ptr = stackalloc JValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JValue))];
			*ptr = new JValue((p0 == null) ? IntPtr.Zero : ((Java.Lang.Object)p0).Handle);
			JNIEnv.CallVoidMethod(base.Handle, this.id_removeListener_Lcom_bumptech_glide_manager_LifecycleListener_, ptr);
		}

		// Token: 0x0400011F RID: 287
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/bumptech/glide/manager/Lifecycle", typeof(ILifecycleInvoker));

		// Token: 0x04000120 RID: 288
		private IntPtr class_ref;

		// Token: 0x04000121 RID: 289
		private static Delegate cb_addListener_Lcom_bumptech_glide_manager_LifecycleListener_;

		// Token: 0x04000122 RID: 290
		private IntPtr id_addListener_Lcom_bumptech_glide_manager_LifecycleListener_;

		// Token: 0x04000123 RID: 291
		private static Delegate cb_removeListener_Lcom_bumptech_glide_manager_LifecycleListener_;

		// Token: 0x04000124 RID: 292
		private IntPtr id_removeListener_Lcom_bumptech_glide_manager_LifecycleListener_;
	}
}
