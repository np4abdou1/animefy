using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Kotlin.Jvm.Internal.Markers
{
	// Token: 0x020001D9 RID: 473
	[Register("kotlin/jvm/internal/markers/KMutableIterable", DoNotGenerateAcw = true)]
	internal class IKMutableIterableInvoker : Java.Lang.Object, IKMutableIterable, IKMappedMarker, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000699 RID: 1689
		// (get) Token: 0x06001771 RID: 6001 RVA: 0x0004D268 File Offset: 0x0004B468
		private static IntPtr java_class_ref
		{
			get
			{
				return IKMutableIterableInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700069A RID: 1690
		// (get) Token: 0x06001772 RID: 6002 RVA: 0x0004D28C File Offset: 0x0004B48C
		[Nullable(1)]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			[NullableContext(1)]
			get
			{
				return IKMutableIterableInvoker._members;
			}
		}

		// Token: 0x1700069B RID: 1691
		// (get) Token: 0x06001773 RID: 6003 RVA: 0x0004D293 File Offset: 0x0004B493
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x1700069C RID: 1692
		// (get) Token: 0x06001774 RID: 6004 RVA: 0x0004D29B File Offset: 0x0004B49B
		[Nullable(1)]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			[NullableContext(1)]
			get
			{
				return IKMutableIterableInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06001775 RID: 6005 RVA: 0x0004D2A7 File Offset: 0x0004B4A7
		[NullableContext(2)]
		public static IKMutableIterable GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IKMutableIterable>(handle, transfer);
		}

		// Token: 0x06001776 RID: 6006 RVA: 0x0004D2B0 File Offset: 0x0004B4B0
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IKMutableIterableInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'kotlin.jvm.internal.markers.KMutableIterable'.");
			}
			return handle;
		}

		// Token: 0x06001777 RID: 6007 RVA: 0x0004D2DB File Offset: 0x0004B4DB
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x06001778 RID: 6008 RVA: 0x0004D30C File Offset: 0x0004B50C
		public IKMutableIterableInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IKMutableIterableInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x0400074F RID: 1871
		[Nullable(1)]
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/jvm/internal/markers/KMutableIterable", typeof(IKMutableIterableInvoker));

		// Token: 0x04000750 RID: 1872
		private IntPtr class_ref;
	}
}
