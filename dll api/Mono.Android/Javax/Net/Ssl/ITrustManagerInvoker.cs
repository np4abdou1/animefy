using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Javax.Net.Ssl
{
	// Token: 0x0200008F RID: 143
	[Register("javax/net/ssl/TrustManager", DoNotGenerateAcw = true)]
	internal class ITrustManagerInvoker : Java.Lang.Object, ITrustManager, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000009 RID: 9
		// (get) Token: 0x0600022D RID: 557 RVA: 0x00002258 File Offset: 0x00000458
		private static IntPtr java_class_ref
		{
			get
			{
				return ITrustManagerInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x0600022E RID: 558 RVA: 0x0000227C File Offset: 0x0000047C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return ITrustManagerInvoker._members;
			}
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x0600022F RID: 559 RVA: 0x00002283 File Offset: 0x00000483
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
		// (get) Token: 0x06000230 RID: 560 RVA: 0x0000228B File Offset: 0x0000048B
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return ITrustManagerInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06000231 RID: 561 RVA: 0x00002297 File Offset: 0x00000497
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, ITrustManagerInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'javax.net.ssl.TrustManager'.");
			}
			return handle;
		}

		// Token: 0x06000232 RID: 562 RVA: 0x000022C2 File Offset: 0x000004C2
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x06000233 RID: 563 RVA: 0x000022F4 File Offset: 0x000004F4
		public ITrustManagerInvoker(IntPtr handle, JniHandleOwnership transfer) : base(ITrustManagerInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x04000007 RID: 7
		private static readonly JniPeerMembers _members = new XAPeerMembers("javax/net/ssl/TrustManager", typeof(ITrustManagerInvoker));

		// Token: 0x04000008 RID: 8
		private IntPtr class_ref;
	}
}
