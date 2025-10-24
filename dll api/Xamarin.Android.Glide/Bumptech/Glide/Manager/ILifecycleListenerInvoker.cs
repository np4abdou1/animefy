using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Bumptech.Glide.Manager
{
	// Token: 0x0200007C RID: 124
	[Register("com/bumptech/glide/manager/LifecycleListener", DoNotGenerateAcw = true)]
	internal class ILifecycleListenerInvoker : Java.Lang.Object, ILifecycleListener, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x1700010A RID: 266
		// (get) Token: 0x06000538 RID: 1336 RVA: 0x000111A8 File Offset: 0x0000F3A8
		private static IntPtr java_class_ref
		{
			get
			{
				return ILifecycleListenerInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700010B RID: 267
		// (get) Token: 0x06000539 RID: 1337 RVA: 0x000111CC File Offset: 0x0000F3CC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return ILifecycleListenerInvoker._members;
			}
		}

		// Token: 0x1700010C RID: 268
		// (get) Token: 0x0600053A RID: 1338 RVA: 0x000111D3 File Offset: 0x0000F3D3
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x1700010D RID: 269
		// (get) Token: 0x0600053B RID: 1339 RVA: 0x000111DB File Offset: 0x0000F3DB
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return ILifecycleListenerInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x0600053C RID: 1340 RVA: 0x000111E7 File Offset: 0x0000F3E7
		public static ILifecycleListener GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<ILifecycleListener>(handle, transfer);
		}

		// Token: 0x0600053D RID: 1341 RVA: 0x000111F0 File Offset: 0x0000F3F0
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, ILifecycleListenerInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'com.bumptech.glide.manager.LifecycleListener'.");
			}
			return handle;
		}

		// Token: 0x0600053E RID: 1342 RVA: 0x0001121B File Offset: 0x0000F41B
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x0600053F RID: 1343 RVA: 0x0001124C File Offset: 0x0000F44C
		public ILifecycleListenerInvoker(IntPtr handle, JniHandleOwnership transfer) : base(ILifecycleListenerInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x06000540 RID: 1344 RVA: 0x00011284 File Offset: 0x0000F484
		private static Delegate GetOnDestroyHandler()
		{
			if (ILifecycleListenerInvoker.cb_onDestroy == null)
			{
				ILifecycleListenerInvoker.cb_onDestroy = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(ILifecycleListenerInvoker.n_OnDestroy));
			}
			return ILifecycleListenerInvoker.cb_onDestroy;
		}

		// Token: 0x06000541 RID: 1345 RVA: 0x000112A8 File Offset: 0x0000F4A8
		private static void n_OnDestroy(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<ILifecycleListener>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).OnDestroy();
		}

		// Token: 0x06000542 RID: 1346 RVA: 0x000112B7 File Offset: 0x0000F4B7
		public void OnDestroy()
		{
			if (this.id_onDestroy == IntPtr.Zero)
			{
				this.id_onDestroy = JNIEnv.GetMethodID(this.class_ref, "onDestroy", "()V");
			}
			JNIEnv.CallVoidMethod(base.Handle, this.id_onDestroy);
		}

		// Token: 0x06000543 RID: 1347 RVA: 0x000112F7 File Offset: 0x0000F4F7
		private static Delegate GetOnStartHandler()
		{
			if (ILifecycleListenerInvoker.cb_onStart == null)
			{
				ILifecycleListenerInvoker.cb_onStart = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(ILifecycleListenerInvoker.n_OnStart));
			}
			return ILifecycleListenerInvoker.cb_onStart;
		}

		// Token: 0x06000544 RID: 1348 RVA: 0x0001131B File Offset: 0x0000F51B
		private static void n_OnStart(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<ILifecycleListener>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).OnStart();
		}

		// Token: 0x06000545 RID: 1349 RVA: 0x0001132A File Offset: 0x0000F52A
		public void OnStart()
		{
			if (this.id_onStart == IntPtr.Zero)
			{
				this.id_onStart = JNIEnv.GetMethodID(this.class_ref, "onStart", "()V");
			}
			JNIEnv.CallVoidMethod(base.Handle, this.id_onStart);
		}

		// Token: 0x06000546 RID: 1350 RVA: 0x0001136A File Offset: 0x0000F56A
		private static Delegate GetOnStopHandler()
		{
			if (ILifecycleListenerInvoker.cb_onStop == null)
			{
				ILifecycleListenerInvoker.cb_onStop = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(ILifecycleListenerInvoker.n_OnStop));
			}
			return ILifecycleListenerInvoker.cb_onStop;
		}

		// Token: 0x06000547 RID: 1351 RVA: 0x0001138E File Offset: 0x0000F58E
		private static void n_OnStop(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<ILifecycleListener>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).OnStop();
		}

		// Token: 0x06000548 RID: 1352 RVA: 0x0001139D File Offset: 0x0000F59D
		public void OnStop()
		{
			if (this.id_onStop == IntPtr.Zero)
			{
				this.id_onStop = JNIEnv.GetMethodID(this.class_ref, "onStop", "()V");
			}
			JNIEnv.CallVoidMethod(base.Handle, this.id_onStop);
		}

		// Token: 0x04000125 RID: 293
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/bumptech/glide/manager/LifecycleListener", typeof(ILifecycleListenerInvoker));

		// Token: 0x04000126 RID: 294
		private IntPtr class_ref;

		// Token: 0x04000127 RID: 295
		private static Delegate cb_onDestroy;

		// Token: 0x04000128 RID: 296
		private IntPtr id_onDestroy;

		// Token: 0x04000129 RID: 297
		private static Delegate cb_onStart;

		// Token: 0x0400012A RID: 298
		private IntPtr id_onStart;

		// Token: 0x0400012B RID: 299
		private static Delegate cb_onStop;

		// Token: 0x0400012C RID: 300
		private IntPtr id_onStop;
	}
}
