using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Bumptech.Glide.Load.Engine
{
	// Token: 0x02000155 RID: 341
	[Register("com/bumptech/glide/load/engine/Initializable", DoNotGenerateAcw = true)]
	internal class IInitializableInvoker : Java.Lang.Object, IInitializable, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x1700048B RID: 1163
		// (get) Token: 0x06001131 RID: 4401 RVA: 0x00037CDC File Offset: 0x00035EDC
		private static IntPtr java_class_ref
		{
			get
			{
				return IInitializableInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700048C RID: 1164
		// (get) Token: 0x06001132 RID: 4402 RVA: 0x00037D00 File Offset: 0x00035F00
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IInitializableInvoker._members;
			}
		}

		// Token: 0x1700048D RID: 1165
		// (get) Token: 0x06001133 RID: 4403 RVA: 0x00037D07 File Offset: 0x00035F07
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x1700048E RID: 1166
		// (get) Token: 0x06001134 RID: 4404 RVA: 0x00037D0F File Offset: 0x00035F0F
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IInitializableInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06001135 RID: 4405 RVA: 0x00037D1B File Offset: 0x00035F1B
		public static IInitializable GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IInitializable>(handle, transfer);
		}

		// Token: 0x06001136 RID: 4406 RVA: 0x00037D24 File Offset: 0x00035F24
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IInitializableInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'com.bumptech.glide.load.engine.Initializable'.");
			}
			return handle;
		}

		// Token: 0x06001137 RID: 4407 RVA: 0x00037D4F File Offset: 0x00035F4F
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x06001138 RID: 4408 RVA: 0x00037D80 File Offset: 0x00035F80
		public IInitializableInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IInitializableInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x06001139 RID: 4409 RVA: 0x00037DB8 File Offset: 0x00035FB8
		private static Delegate GetInitializeHandler()
		{
			if (IInitializableInvoker.cb_initialize == null)
			{
				IInitializableInvoker.cb_initialize = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(IInitializableInvoker.n_Initialize));
			}
			return IInitializableInvoker.cb_initialize;
		}

		// Token: 0x0600113A RID: 4410 RVA: 0x00037DDC File Offset: 0x00035FDC
		private static void n_Initialize(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<IInitializable>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Initialize();
		}

		// Token: 0x0600113B RID: 4411 RVA: 0x00037DEB File Offset: 0x00035FEB
		public void Initialize()
		{
			if (this.id_initialize == IntPtr.Zero)
			{
				this.id_initialize = JNIEnv.GetMethodID(this.class_ref, "initialize", "()V");
			}
			JNIEnv.CallVoidMethod(base.Handle, this.id_initialize);
		}

		// Token: 0x040003F0 RID: 1008
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/bumptech/glide/load/engine/Initializable", typeof(IInitializableInvoker));

		// Token: 0x040003F1 RID: 1009
		private IntPtr class_ref;

		// Token: 0x040003F2 RID: 1010
		private static Delegate cb_initialize;

		// Token: 0x040003F3 RID: 1011
		private IntPtr id_initialize;
	}
}
