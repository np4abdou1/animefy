using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Kotlin.Jvm.Internal.Markers
{
	// Token: 0x020001D5 RID: 469
	[Register("kotlin/jvm/internal/markers/KMappedMarker", DoNotGenerateAcw = true)]
	internal class IKMappedMarkerInvoker : Java.Lang.Object, IKMappedMarker, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000691 RID: 1681
		// (get) Token: 0x0600175F RID: 5983 RVA: 0x0004D078 File Offset: 0x0004B278
		private static IntPtr java_class_ref
		{
			get
			{
				return IKMappedMarkerInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000692 RID: 1682
		// (get) Token: 0x06001760 RID: 5984 RVA: 0x0004D09C File Offset: 0x0004B29C
		[Nullable(1)]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			[NullableContext(1)]
			get
			{
				return IKMappedMarkerInvoker._members;
			}
		}

		// Token: 0x17000693 RID: 1683
		// (get) Token: 0x06001761 RID: 5985 RVA: 0x0004D0A3 File Offset: 0x0004B2A3
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x17000694 RID: 1684
		// (get) Token: 0x06001762 RID: 5986 RVA: 0x0004D0AB File Offset: 0x0004B2AB
		[Nullable(1)]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			[NullableContext(1)]
			get
			{
				return IKMappedMarkerInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06001763 RID: 5987 RVA: 0x0004D0B7 File Offset: 0x0004B2B7
		[NullableContext(2)]
		public static IKMappedMarker GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IKMappedMarker>(handle, transfer);
		}

		// Token: 0x06001764 RID: 5988 RVA: 0x0004D0C0 File Offset: 0x0004B2C0
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IKMappedMarkerInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'kotlin.jvm.internal.markers.KMappedMarker'.");
			}
			return handle;
		}

		// Token: 0x06001765 RID: 5989 RVA: 0x0004D0EB File Offset: 0x0004B2EB
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x06001766 RID: 5990 RVA: 0x0004D11C File Offset: 0x0004B31C
		public IKMappedMarkerInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IKMappedMarkerInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x0400074B RID: 1867
		[Nullable(1)]
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/jvm/internal/markers/KMappedMarker", typeof(IKMappedMarkerInvoker));

		// Token: 0x0400074C RID: 1868
		private IntPtr class_ref;
	}
}
