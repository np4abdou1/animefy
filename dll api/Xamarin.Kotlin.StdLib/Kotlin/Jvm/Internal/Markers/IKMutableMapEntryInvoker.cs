using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Kotlin.Jvm.Internal.Markers
{
	// Token: 0x020001E1 RID: 481
	[Register("kotlin/jvm/internal/markers/KMutableMap$Entry", DoNotGenerateAcw = true)]
	internal class IKMutableMapEntryInvoker : Java.Lang.Object, IKMutableMapEntry, IKMappedMarker, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x170006A9 RID: 1705
		// (get) Token: 0x06001795 RID: 6037 RVA: 0x0004D648 File Offset: 0x0004B848
		private static IntPtr java_class_ref
		{
			get
			{
				return IKMutableMapEntryInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170006AA RID: 1706
		// (get) Token: 0x06001796 RID: 6038 RVA: 0x0004D66C File Offset: 0x0004B86C
		[Nullable(1)]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			[NullableContext(1)]
			get
			{
				return IKMutableMapEntryInvoker._members;
			}
		}

		// Token: 0x170006AB RID: 1707
		// (get) Token: 0x06001797 RID: 6039 RVA: 0x0004D673 File Offset: 0x0004B873
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x170006AC RID: 1708
		// (get) Token: 0x06001798 RID: 6040 RVA: 0x0004D67B File Offset: 0x0004B87B
		[Nullable(1)]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			[NullableContext(1)]
			get
			{
				return IKMutableMapEntryInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06001799 RID: 6041 RVA: 0x0004D687 File Offset: 0x0004B887
		[NullableContext(2)]
		public static IKMutableMapEntry GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IKMutableMapEntry>(handle, transfer);
		}

		// Token: 0x0600179A RID: 6042 RVA: 0x0004D690 File Offset: 0x0004B890
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IKMutableMapEntryInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'kotlin.jvm.internal.markers.KMutableMap.Entry'.");
			}
			return handle;
		}

		// Token: 0x0600179B RID: 6043 RVA: 0x0004D6BB File Offset: 0x0004B8BB
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x0600179C RID: 6044 RVA: 0x0004D6EC File Offset: 0x0004B8EC
		public IKMutableMapEntryInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IKMutableMapEntryInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x04000757 RID: 1879
		[Nullable(1)]
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/jvm/internal/markers/KMutableMap$Entry", typeof(IKMutableMapEntryInvoker));

		// Token: 0x04000758 RID: 1880
		private IntPtr class_ref;
	}
}
