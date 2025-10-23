using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Kotlin.Jvm.Internal.Markers
{
	// Token: 0x020001DB RID: 475
	[Register("kotlin/jvm/internal/markers/KMutableIterator", DoNotGenerateAcw = true)]
	internal class IKMutableIteratorInvoker : Java.Lang.Object, IKMutableIterator, IKMappedMarker, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x1700069D RID: 1693
		// (get) Token: 0x0600177A RID: 6010 RVA: 0x0004D360 File Offset: 0x0004B560
		private static IntPtr java_class_ref
		{
			get
			{
				return IKMutableIteratorInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700069E RID: 1694
		// (get) Token: 0x0600177B RID: 6011 RVA: 0x0004D384 File Offset: 0x0004B584
		[Nullable(1)]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			[NullableContext(1)]
			get
			{
				return IKMutableIteratorInvoker._members;
			}
		}

		// Token: 0x1700069F RID: 1695
		// (get) Token: 0x0600177C RID: 6012 RVA: 0x0004D38B File Offset: 0x0004B58B
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x170006A0 RID: 1696
		// (get) Token: 0x0600177D RID: 6013 RVA: 0x0004D393 File Offset: 0x0004B593
		[Nullable(1)]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			[NullableContext(1)]
			get
			{
				return IKMutableIteratorInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x0600177E RID: 6014 RVA: 0x0004D39F File Offset: 0x0004B59F
		[NullableContext(2)]
		public static IKMutableIterator GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<IKMutableIterator>(handle, transfer);
		}

		// Token: 0x0600177F RID: 6015 RVA: 0x0004D3A8 File Offset: 0x0004B5A8
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IKMutableIteratorInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'kotlin.jvm.internal.markers.KMutableIterator'.");
			}
			return handle;
		}

		// Token: 0x06001780 RID: 6016 RVA: 0x0004D3D3 File Offset: 0x0004B5D3
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x06001781 RID: 6017 RVA: 0x0004D404 File Offset: 0x0004B604
		public IKMutableIteratorInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IKMutableIteratorInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x04000751 RID: 1873
		[Nullable(1)]
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/jvm/internal/markers/KMutableIterator", typeof(IKMutableIteratorInvoker));

		// Token: 0x04000752 RID: 1874
		private IntPtr class_ref;
	}
}
