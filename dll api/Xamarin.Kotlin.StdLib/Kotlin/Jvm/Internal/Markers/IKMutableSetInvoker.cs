using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Kotlin.Jvm.Internal.Markers
{
	// Token: 0x020001E5 RID: 485
	[Register("kotlin/jvm/internal/markers/KMutableSet", DoNotGenerateAcw = true)]
	internal class IKMutableSetInvoker : Java.Lang.Object, IKMutableSet, IKMutableCollection, IKMutableIterable, IKMappedMarker, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x170006B1 RID: 1713
		// (get) Token: 0x060017A7 RID: 6055 RVA: 0x0004D838 File Offset: 0x0004BA38
		private static IntPtr java_class_ref
		{
			get
			{
				return IKMutableSetInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170006B2 RID: 1714
		// (get) Token: 0x060017A8 RID: 6056 RVA: 0x0004D85C File Offset: 0x0004BA5C
		[Nullable(1)]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			[NullableContext(1)]
			get
			{
				return IKMutableSetInvoker._members;
			}
		}

		// Token: 0x170006B3 RID: 1715
		// (get) Token: 0x060017A9 RID: 6057 RVA: 0x0004D863 File Offset: 0x0004BA63
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x170006B4 RID: 1716
		// (get) Token: 0x060017AA RID: 6058 RVA: 0x0004D86B File Offset: 0x0004BA6B
		[Nullable(1)]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			[NullableContext(1)]
			get
			{
				return IKMutableSetInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x060017AB RID: 6059 RVA: 0x0004D877 File Offset: 0x0004BA77
		[NullableContext(2)]
		public static IKMutableSet GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IKMutableSet>(handle, transfer);
		}

		// Token: 0x060017AC RID: 6060 RVA: 0x0004D880 File Offset: 0x0004BA80
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IKMutableSetInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'kotlin.jvm.internal.markers.KMutableSet'.");
			}
			return handle;
		}

		// Token: 0x060017AD RID: 6061 RVA: 0x0004D8AB File Offset: 0x0004BAAB
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x060017AE RID: 6062 RVA: 0x0004D8DC File Offset: 0x0004BADC
		public IKMutableSetInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IKMutableSetInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x0400075B RID: 1883
		[Nullable(1)]
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/jvm/internal/markers/KMutableSet", typeof(IKMutableSetInvoker));

		// Token: 0x0400075C RID: 1884
		private IntPtr class_ref;
	}
}
