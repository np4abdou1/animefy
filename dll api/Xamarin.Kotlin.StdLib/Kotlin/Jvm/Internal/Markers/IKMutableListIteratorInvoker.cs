using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Kotlin.Jvm.Internal.Markers
{
	// Token: 0x020001DF RID: 479
	[Register("kotlin/jvm/internal/markers/KMutableListIterator", DoNotGenerateAcw = true)]
	internal class IKMutableListIteratorInvoker : Java.Lang.Object, IKMutableListIterator, IKMutableIterator, IKMappedMarker, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x170006A5 RID: 1701
		// (get) Token: 0x0600178C RID: 6028 RVA: 0x0004D550 File Offset: 0x0004B750
		private static IntPtr java_class_ref
		{
			get
			{
				return IKMutableListIteratorInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170006A6 RID: 1702
		// (get) Token: 0x0600178D RID: 6029 RVA: 0x0004D574 File Offset: 0x0004B774
		[Nullable(1)]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			[NullableContext(1)]
			get
			{
				return IKMutableListIteratorInvoker._members;
			}
		}

		// Token: 0x170006A7 RID: 1703
		// (get) Token: 0x0600178E RID: 6030 RVA: 0x0004D57B File Offset: 0x0004B77B
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x170006A8 RID: 1704
		// (get) Token: 0x0600178F RID: 6031 RVA: 0x0004D583 File Offset: 0x0004B783
		[Nullable(1)]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			[NullableContext(1)]
			get
			{
				return IKMutableListIteratorInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06001790 RID: 6032 RVA: 0x0004D58F File Offset: 0x0004B78F
		[NullableContext(2)]
		public static IKMutableListIterator GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IKMutableListIterator>(handle, transfer);
		}

		// Token: 0x06001791 RID: 6033 RVA: 0x0004D598 File Offset: 0x0004B798
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IKMutableListIteratorInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'kotlin.jvm.internal.markers.KMutableListIterator'.");
			}
			return handle;
		}

		// Token: 0x06001792 RID: 6034 RVA: 0x0004D5C3 File Offset: 0x0004B7C3
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x06001793 RID: 6035 RVA: 0x0004D5F4 File Offset: 0x0004B7F4
		public IKMutableListIteratorInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IKMutableListIteratorInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x04000755 RID: 1877
		[Nullable(1)]
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/jvm/internal/markers/KMutableListIterator", typeof(IKMutableListIteratorInvoker));

		// Token: 0x04000756 RID: 1878
		private IntPtr class_ref;
	}
}
