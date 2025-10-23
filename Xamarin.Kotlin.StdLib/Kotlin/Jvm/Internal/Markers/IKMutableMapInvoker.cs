using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Kotlin.Jvm.Internal.Markers
{
	// Token: 0x020001E3 RID: 483
	[Register("kotlin/jvm/internal/markers/KMutableMap", DoNotGenerateAcw = true)]
	internal class IKMutableMapInvoker : Java.Lang.Object, IKMutableMap, IKMappedMarker, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x170006AD RID: 1709
		// (get) Token: 0x0600179E RID: 6046 RVA: 0x0004D740 File Offset: 0x0004B940
		private static IntPtr java_class_ref
		{
			get
			{
				return IKMutableMapInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170006AE RID: 1710
		// (get) Token: 0x0600179F RID: 6047 RVA: 0x0004D764 File Offset: 0x0004B964
		[Nullable(1)]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			[NullableContext(1)]
			get
			{
				return IKMutableMapInvoker._members;
			}
		}

		// Token: 0x170006AF RID: 1711
		// (get) Token: 0x060017A0 RID: 6048 RVA: 0x0004D76B File Offset: 0x0004B96B
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x170006B0 RID: 1712
		// (get) Token: 0x060017A1 RID: 6049 RVA: 0x0004D773 File Offset: 0x0004B973
		[Nullable(1)]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			[NullableContext(1)]
			get
			{
				return IKMutableMapInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x060017A2 RID: 6050 RVA: 0x0004D77F File Offset: 0x0004B97F
		[NullableContext(2)]
		public static IKMutableMap GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IKMutableMap>(handle, transfer);
		}

		// Token: 0x060017A3 RID: 6051 RVA: 0x0004D788 File Offset: 0x0004B988
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IKMutableMapInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'kotlin.jvm.internal.markers.KMutableMap'.");
			}
			return handle;
		}

		// Token: 0x060017A4 RID: 6052 RVA: 0x0004D7B3 File Offset: 0x0004B9B3
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x060017A5 RID: 6053 RVA: 0x0004D7E4 File Offset: 0x0004B9E4
		public IKMutableMapInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IKMutableMapInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x04000759 RID: 1881
		[Nullable(1)]
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/jvm/internal/markers/KMutableMap", typeof(IKMutableMapInvoker));

		// Token: 0x0400075A RID: 1882
		private IntPtr class_ref;
	}
}
