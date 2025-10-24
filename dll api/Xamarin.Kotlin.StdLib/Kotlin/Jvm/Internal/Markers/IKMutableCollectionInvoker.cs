using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Kotlin.Jvm.Internal.Markers
{
	// Token: 0x020001D7 RID: 471
	[Register("kotlin/jvm/internal/markers/KMutableCollection", DoNotGenerateAcw = true)]
	internal class IKMutableCollectionInvoker : Java.Lang.Object, IKMutableCollection, IKMutableIterable, IKMappedMarker, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000695 RID: 1685
		// (get) Token: 0x06001768 RID: 5992 RVA: 0x0004D170 File Offset: 0x0004B370
		private static IntPtr java_class_ref
		{
			get
			{
				return IKMutableCollectionInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000696 RID: 1686
		// (get) Token: 0x06001769 RID: 5993 RVA: 0x0004D194 File Offset: 0x0004B394
		[Nullable(1)]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			[NullableContext(1)]
			get
			{
				return IKMutableCollectionInvoker._members;
			}
		}

		// Token: 0x17000697 RID: 1687
		// (get) Token: 0x0600176A RID: 5994 RVA: 0x0004D19B File Offset: 0x0004B39B
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x17000698 RID: 1688
		// (get) Token: 0x0600176B RID: 5995 RVA: 0x0004D1A3 File Offset: 0x0004B3A3
		[Nullable(1)]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			[NullableContext(1)]
			get
			{
				return IKMutableCollectionInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x0600176C RID: 5996 RVA: 0x0004D1AF File Offset: 0x0004B3AF
		[NullableContext(2)]
		public static IKMutableCollection GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IKMutableCollection>(handle, transfer);
		}

		// Token: 0x0600176D RID: 5997 RVA: 0x0004D1B8 File Offset: 0x0004B3B8
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IKMutableCollectionInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'kotlin.jvm.internal.markers.KMutableCollection'.");
			}
			return handle;
		}

		// Token: 0x0600176E RID: 5998 RVA: 0x0004D1E3 File Offset: 0x0004B3E3
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x0600176F RID: 5999 RVA: 0x0004D214 File Offset: 0x0004B414
		public IKMutableCollectionInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IKMutableCollectionInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x0400074D RID: 1869
		[Nullable(1)]
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/jvm/internal/markers/KMutableCollection", typeof(IKMutableCollectionInvoker));

		// Token: 0x0400074E RID: 1870
		private IntPtr class_ref;
	}
}
