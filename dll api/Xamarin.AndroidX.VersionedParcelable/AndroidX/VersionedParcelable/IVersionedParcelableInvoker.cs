using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace AndroidX.VersionedParcelable
{
	// Token: 0x0200000A RID: 10
	[Register("androidx/versionedparcelable/VersionedParcelable", DoNotGenerateAcw = true)]
	internal class IVersionedParcelableInvoker : Java.Lang.Object, IVersionedParcelable, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000007 RID: 7
		// (get) Token: 0x0600001D RID: 29 RVA: 0x00002268 File Offset: 0x00000468
		private static IntPtr java_class_ref
		{
			get
			{
				return IVersionedParcelableInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x0600001E RID: 30 RVA: 0x0000228C File Offset: 0x0000048C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IVersionedParcelableInvoker._members;
			}
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x0600001F RID: 31 RVA: 0x00002293 File Offset: 0x00000493
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x06000020 RID: 32 RVA: 0x0000229B File Offset: 0x0000049B
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IVersionedParcelableInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06000021 RID: 33 RVA: 0x000022A7 File Offset: 0x000004A7
		public static IVersionedParcelable GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IVersionedParcelable>(handle, transfer);
		}

		// Token: 0x06000022 RID: 34 RVA: 0x000022B0 File Offset: 0x000004B0
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IVersionedParcelableInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'androidx.versionedparcelable.VersionedParcelable'.");
			}
			return handle;
		}

		// Token: 0x06000023 RID: 35 RVA: 0x000022DB File Offset: 0x000004DB
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x06000024 RID: 36 RVA: 0x0000230C File Offset: 0x0000050C
		public IVersionedParcelableInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IVersionedParcelableInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x04000007 RID: 7
		private static readonly JniPeerMembers _members = new XAPeerMembers("androidx/versionedparcelable/VersionedParcelable", typeof(IVersionedParcelableInvoker));

		// Token: 0x04000008 RID: 8
		private IntPtr class_ref;
	}
}
