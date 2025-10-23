using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Kotlin.Jvm.Internal.Markers
{
	// Token: 0x020001DD RID: 477
	[Register("kotlin/jvm/internal/markers/KMutableList", DoNotGenerateAcw = true)]
	internal class IKMutableListInvoker : Java.Lang.Object, IKMutableList, IKMutableCollection, IKMutableIterable, IKMappedMarker, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x170006A1 RID: 1697
		// (get) Token: 0x06001783 RID: 6019 RVA: 0x0004D458 File Offset: 0x0004B658
		private static IntPtr java_class_ref
		{
			get
			{
				return IKMutableListInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170006A2 RID: 1698
		// (get) Token: 0x06001784 RID: 6020 RVA: 0x0004D47C File Offset: 0x0004B67C
		[Nullable(1)]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			[NullableContext(1)]
			get
			{
				return IKMutableListInvoker._members;
			}
		}

		// Token: 0x170006A3 RID: 1699
		// (get) Token: 0x06001785 RID: 6021 RVA: 0x0004D483 File Offset: 0x0004B683
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x170006A4 RID: 1700
		// (get) Token: 0x06001786 RID: 6022 RVA: 0x0004D48B File Offset: 0x0004B68B
		[Nullable(1)]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			[NullableContext(1)]
			get
			{
				return IKMutableListInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06001787 RID: 6023 RVA: 0x0004D497 File Offset: 0x0004B697
		[NullableContext(2)]
		public static IKMutableList GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IKMutableList>(handle, transfer);
		}

		// Token: 0x06001788 RID: 6024 RVA: 0x0004D4A0 File Offset: 0x0004B6A0
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IKMutableListInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'kotlin.jvm.internal.markers.KMutableList'.");
			}
			return handle;
		}

		// Token: 0x06001789 RID: 6025 RVA: 0x0004D4CB File Offset: 0x0004B6CB
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x0600178A RID: 6026 RVA: 0x0004D4FC File Offset: 0x0004B6FC
		public IKMutableListInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IKMutableListInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x04000753 RID: 1875
		[Nullable(1)]
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/jvm/internal/markers/KMutableList", typeof(IKMutableListInvoker));

		// Token: 0x04000754 RID: 1876
		private IntPtr class_ref;
	}
}
