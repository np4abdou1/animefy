using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace JavaX.Inject
{
	// Token: 0x0200000C RID: 12
	[Register("javax/inject/Provider", DoNotGenerateAcw = true)]
	internal class IProviderInvoker : Java.Lang.Object, IProvider, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000009 RID: 9
		// (get) Token: 0x0600003E RID: 62 RVA: 0x0000275C File Offset: 0x0000095C
		private static IntPtr java_class_ref
		{
			get
			{
				return IProviderInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x0600003F RID: 63 RVA: 0x00002780 File Offset: 0x00000980
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IProviderInvoker._members;
			}
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x06000040 RID: 64 RVA: 0x00002787 File Offset: 0x00000987
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x06000041 RID: 65 RVA: 0x0000278F File Offset: 0x0000098F
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IProviderInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06000042 RID: 66 RVA: 0x0000279B File Offset: 0x0000099B
		public static IProvider GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IProvider>(handle, transfer);
		}

		// Token: 0x06000043 RID: 67 RVA: 0x000027A4 File Offset: 0x000009A4
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IProviderInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'javax.inject.Provider'.");
			}
			return handle;
		}

		// Token: 0x06000044 RID: 68 RVA: 0x000027CF File Offset: 0x000009CF
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x06000045 RID: 69 RVA: 0x00002800 File Offset: 0x00000A00
		public IProviderInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IProviderInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x06000046 RID: 70 RVA: 0x00002838 File Offset: 0x00000A38
		private static Delegate GetGetHandler()
		{
			if (IProviderInvoker.cb_get == null)
			{
				IProviderInvoker.cb_get = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IProviderInvoker.n_Get));
			}
			return IProviderInvoker.cb_get;
		}

		// Token: 0x06000047 RID: 71 RVA: 0x0000285C File Offset: 0x00000A5C
		private static IntPtr n_Get(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IProvider>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Get());
		}

		// Token: 0x06000048 RID: 72 RVA: 0x00002870 File Offset: 0x00000A70
		public Java.Lang.Object Get()
		{
			if (this.id_get == IntPtr.Zero)
			{
				this.id_get = JNIEnv.GetMethodID(this.class_ref, "get", "()Ljava/lang/Object;");
			}
			return Java.Lang.Object.GetObject<Java.Lang.Object>(JNIEnv.CallObjectMethod(base.Handle, this.id_get), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x04000017 RID: 23
		private static readonly JniPeerMembers _members = new XAPeerMembers("javax/inject/Provider", typeof(IProviderInvoker));

		// Token: 0x04000018 RID: 24
		private IntPtr class_ref;

		// Token: 0x04000019 RID: 25
		private static Delegate cb_get;

		// Token: 0x0400001A RID: 26
		private IntPtr id_get;
	}
}
