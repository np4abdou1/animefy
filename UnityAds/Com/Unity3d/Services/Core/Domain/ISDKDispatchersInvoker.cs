using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Com.Unity3d.Services.Core.Domain
{
	// Token: 0x020000FF RID: 255
	[Register("com/unity3d/services/core/domain/ISDKDispatchers", DoNotGenerateAcw = true)]
	internal class ISDKDispatchersInvoker : Java.Lang.Object, ISDKDispatchers, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000330 RID: 816
		// (get) Token: 0x06000A14 RID: 2580 RVA: 0x0001D490 File Offset: 0x0001B690
		private static IntPtr java_class_ref
		{
			get
			{
				return ISDKDispatchersInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000331 RID: 817
		// (get) Token: 0x06000A15 RID: 2581 RVA: 0x0001D4B4 File Offset: 0x0001B6B4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return ISDKDispatchersInvoker._members;
			}
		}

		// Token: 0x17000332 RID: 818
		// (get) Token: 0x06000A16 RID: 2582 RVA: 0x0001D4BB File Offset: 0x0001B6BB
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x17000333 RID: 819
		// (get) Token: 0x06000A17 RID: 2583 RVA: 0x0001D4C3 File Offset: 0x0001B6C3
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return ISDKDispatchersInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06000A18 RID: 2584 RVA: 0x0001D4CF File Offset: 0x0001B6CF
		public static ISDKDispatchers GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<ISDKDispatchers>(handle, transfer);
		}

		// Token: 0x06000A19 RID: 2585 RVA: 0x0001D4D8 File Offset: 0x0001B6D8
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, ISDKDispatchersInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'com.unity3d.services.core.domain.ISDKDispatchers'.");
			}
			return handle;
		}

		// Token: 0x06000A1A RID: 2586 RVA: 0x0001D503 File Offset: 0x0001B703
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x06000A1B RID: 2587 RVA: 0x0001D534 File Offset: 0x0001B734
		public ISDKDispatchersInvoker(IntPtr handle, JniHandleOwnership transfer) : base(ISDKDispatchersInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x04000264 RID: 612
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/services/core/domain/ISDKDispatchers", typeof(ISDKDispatchersInvoker));

		// Token: 0x04000265 RID: 613
		private IntPtr class_ref;
	}
}
