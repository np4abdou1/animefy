using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace AndroidX.Lifecycle
{
	// Token: 0x0200000A RID: 10
	[Register("androidx/lifecycle/LifecycleObserver", DoNotGenerateAcw = true)]
	internal class ILifecycleObserverInvoker : Java.Lang.Object, ILifecycleObserver, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000010 RID: 16
		// (get) Token: 0x0600002C RID: 44 RVA: 0x0000255C File Offset: 0x0000075C
		private static IntPtr java_class_ref
		{
			get
			{
				return ILifecycleObserverInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x0600002D RID: 45 RVA: 0x00002580 File Offset: 0x00000780
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return ILifecycleObserverInvoker._members;
			}
		}

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x0600002E RID: 46 RVA: 0x00002587 File Offset: 0x00000787
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x0600002F RID: 47 RVA: 0x0000258F File Offset: 0x0000078F
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return ILifecycleObserverInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06000030 RID: 48 RVA: 0x0000259B File Offset: 0x0000079B
		public static ILifecycleObserver GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<ILifecycleObserver>(handle, transfer);
		}

		// Token: 0x06000031 RID: 49 RVA: 0x000025A4 File Offset: 0x000007A4
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, ILifecycleObserverInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'androidx.lifecycle.LifecycleObserver'.");
			}
			return handle;
		}

		// Token: 0x06000032 RID: 50 RVA: 0x000025CF File Offset: 0x000007CF
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x06000033 RID: 51 RVA: 0x00002600 File Offset: 0x00000800
		public ILifecycleObserverInvoker(IntPtr handle, JniHandleOwnership transfer) : base(ILifecycleObserverInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x04000008 RID: 8
		private static readonly JniPeerMembers _members = new XAPeerMembers("androidx/lifecycle/LifecycleObserver", typeof(ILifecycleObserverInvoker));

		// Token: 0x04000009 RID: 9
		private IntPtr class_ref;
	}
}
