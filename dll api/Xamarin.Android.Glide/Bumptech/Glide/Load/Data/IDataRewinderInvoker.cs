using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Bumptech.Glide.Load.Data
{
	// Token: 0x02000198 RID: 408
	[Register("com/bumptech/glide/load/data/DataRewinder", DoNotGenerateAcw = true)]
	internal class IDataRewinderInvoker : Java.Lang.Object, IDataRewinder, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x1700056D RID: 1389
		// (get) Token: 0x06001492 RID: 5266 RVA: 0x0004179C File Offset: 0x0003F99C
		private static IntPtr java_class_ref
		{
			get
			{
				return IDataRewinderInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700056E RID: 1390
		// (get) Token: 0x06001493 RID: 5267 RVA: 0x000417C0 File Offset: 0x0003F9C0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IDataRewinderInvoker._members;
			}
		}

		// Token: 0x1700056F RID: 1391
		// (get) Token: 0x06001494 RID: 5268 RVA: 0x000417C7 File Offset: 0x0003F9C7
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x17000570 RID: 1392
		// (get) Token: 0x06001495 RID: 5269 RVA: 0x000417CF File Offset: 0x0003F9CF
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IDataRewinderInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06001496 RID: 5270 RVA: 0x000417DB File Offset: 0x0003F9DB
		public static IDataRewinder GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IDataRewinder>(handle, transfer);
		}

		// Token: 0x06001497 RID: 5271 RVA: 0x000417E4 File Offset: 0x0003F9E4
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IDataRewinderInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'com.bumptech.glide.load.data.DataRewinder'.");
			}
			return handle;
		}

		// Token: 0x06001498 RID: 5272 RVA: 0x0004180F File Offset: 0x0003FA0F
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x06001499 RID: 5273 RVA: 0x00041840 File Offset: 0x0003FA40
		public IDataRewinderInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IDataRewinderInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x0600149A RID: 5274 RVA: 0x00041878 File Offset: 0x0003FA78
		private static Delegate GetCleanupHandler()
		{
			if (IDataRewinderInvoker.cb_cleanup == null)
			{
				IDataRewinderInvoker.cb_cleanup = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(IDataRewinderInvoker.n_Cleanup));
			}
			return IDataRewinderInvoker.cb_cleanup;
		}

		// Token: 0x0600149B RID: 5275 RVA: 0x0004189C File Offset: 0x0003FA9C
		private static void n_Cleanup(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<IDataRewinder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Cleanup();
		}

		// Token: 0x0600149C RID: 5276 RVA: 0x000418AB File Offset: 0x0003FAAB
		public void Cleanup()
		{
			if (this.id_cleanup == IntPtr.Zero)
			{
				this.id_cleanup = JNIEnv.GetMethodID(this.class_ref, "cleanup", "()V");
			}
			JNIEnv.CallVoidMethod(base.Handle, this.id_cleanup);
		}

		// Token: 0x0600149D RID: 5277 RVA: 0x000418EB File Offset: 0x0003FAEB
		private static Delegate GetRewindAndGetHandler()
		{
			if (IDataRewinderInvoker.cb_rewindAndGet == null)
			{
				IDataRewinderInvoker.cb_rewindAndGet = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IDataRewinderInvoker.n_RewindAndGet));
			}
			return IDataRewinderInvoker.cb_rewindAndGet;
		}

		// Token: 0x0600149E RID: 5278 RVA: 0x0004190F File Offset: 0x0003FB0F
		private static IntPtr n_RewindAndGet(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<IDataRewinder>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).RewindAndGet());
		}

		// Token: 0x0600149F RID: 5279 RVA: 0x00041924 File Offset: 0x0003FB24
		public Java.Lang.Object RewindAndGet()
		{
			if (this.id_rewindAndGet == IntPtr.Zero)
			{
				this.id_rewindAndGet = JNIEnv.GetMethodID(this.class_ref, "rewindAndGet", "()Ljava/lang/Object;");
			}
			return Java.Lang.Object.GetObject<Java.Lang.Object>(JNIEnv.CallObjectMethod(base.Handle, this.id_rewindAndGet), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x040004E3 RID: 1251
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/bumptech/glide/load/data/DataRewinder", typeof(IDataRewinderInvoker));

		// Token: 0x040004E4 RID: 1252
		private IntPtr class_ref;

		// Token: 0x040004E5 RID: 1253
		private static Delegate cb_cleanup;

		// Token: 0x040004E6 RID: 1254
		private IntPtr id_cleanup;

		// Token: 0x040004E7 RID: 1255
		private static Delegate cb_rewindAndGet;

		// Token: 0x040004E8 RID: 1256
		private IntPtr id_rewindAndGet;
	}
}
