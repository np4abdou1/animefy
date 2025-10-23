using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.App;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace AndroidX.Core.App
{
	// Token: 0x02000069 RID: 105
	[Register("androidx/core/app/NotificationBuilderWithBuilderAccessor", DoNotGenerateAcw = true)]
	internal class INotificationBuilderWithBuilderAccessorInvoker : Java.Lang.Object, INotificationBuilderWithBuilderAccessor, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x170000B1 RID: 177
		// (get) Token: 0x06000410 RID: 1040 RVA: 0x0000BE24 File Offset: 0x0000A024
		private static IntPtr java_class_ref
		{
			get
			{
				return INotificationBuilderWithBuilderAccessorInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170000B2 RID: 178
		// (get) Token: 0x06000411 RID: 1041 RVA: 0x0000BE48 File Offset: 0x0000A048
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return INotificationBuilderWithBuilderAccessorInvoker._members;
			}
		}

		// Token: 0x170000B3 RID: 179
		// (get) Token: 0x06000412 RID: 1042 RVA: 0x0000BE4F File Offset: 0x0000A04F
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x170000B4 RID: 180
		// (get) Token: 0x06000413 RID: 1043 RVA: 0x0000BE57 File Offset: 0x0000A057
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return INotificationBuilderWithBuilderAccessorInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06000414 RID: 1044 RVA: 0x0000BE63 File Offset: 0x0000A063
		public static INotificationBuilderWithBuilderAccessor GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<INotificationBuilderWithBuilderAccessor>(handle, transfer);
		}

		// Token: 0x06000415 RID: 1045 RVA: 0x0000BE6C File Offset: 0x0000A06C
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, INotificationBuilderWithBuilderAccessorInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'androidx.core.app.NotificationBuilderWithBuilderAccessor'.");
			}
			return handle;
		}

		// Token: 0x06000416 RID: 1046 RVA: 0x0000BE97 File Offset: 0x0000A097
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x06000417 RID: 1047 RVA: 0x0000BEC8 File Offset: 0x0000A0C8
		public INotificationBuilderWithBuilderAccessorInvoker(IntPtr handle, JniHandleOwnership transfer) : base(INotificationBuilderWithBuilderAccessorInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x06000418 RID: 1048 RVA: 0x0000BF00 File Offset: 0x0000A100
		private static Delegate GetGetBuilderHandler()
		{
			if (INotificationBuilderWithBuilderAccessorInvoker.cb_getBuilder == null)
			{
				INotificationBuilderWithBuilderAccessorInvoker.cb_getBuilder = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(INotificationBuilderWithBuilderAccessorInvoker.n_GetBuilder));
			}
			return INotificationBuilderWithBuilderAccessorInvoker.cb_getBuilder;
		}

		// Token: 0x06000419 RID: 1049 RVA: 0x0000BF24 File Offset: 0x0000A124
		private static IntPtr n_GetBuilder(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<INotificationBuilderWithBuilderAccessor>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Builder);
		}

		// Token: 0x170000B5 RID: 181
		// (get) Token: 0x0600041A RID: 1050 RVA: 0x0000BF38 File Offset: 0x0000A138
		public Notification.Builder Builder
		{
			get
			{
				if (this.id_getBuilder == IntPtr.Zero)
				{
					this.id_getBuilder = JNIEnv.GetMethodID(this.class_ref, "getBuilder", "()Landroid/app/Notification$Builder;");
				}
				return Java.Lang.Object.GetObject<Notification.Builder>(JNIEnv.CallObjectMethod(base.Handle, this.id_getBuilder), JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x04000110 RID: 272
		private static readonly JniPeerMembers _members = new XAPeerMembers("androidx/core/app/NotificationBuilderWithBuilderAccessor", typeof(INotificationBuilderWithBuilderAccessorInvoker));

		// Token: 0x04000111 RID: 273
		private IntPtr class_ref;

		// Token: 0x04000112 RID: 274
		private static Delegate cb_getBuilder;

		// Token: 0x04000113 RID: 275
		private IntPtr id_getBuilder;
	}
}
