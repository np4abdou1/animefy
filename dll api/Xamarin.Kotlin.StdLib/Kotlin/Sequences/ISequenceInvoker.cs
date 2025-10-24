using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;
using Java.Util;

namespace Kotlin.Sequences
{
	// Token: 0x020000F7 RID: 247
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlin/sequences/Sequence", DoNotGenerateAcw = true)]
	internal class ISequenceInvoker : Java.Lang.Object, ISequence, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x170002A2 RID: 674
		// (get) Token: 0x06000A09 RID: 2569 RVA: 0x00021BC8 File Offset: 0x0001FDC8
		private static IntPtr java_class_ref
		{
			get
			{
				return ISequenceInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170002A3 RID: 675
		// (get) Token: 0x06000A0A RID: 2570 RVA: 0x00021BEC File Offset: 0x0001FDEC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return ISequenceInvoker._members;
			}
		}

		// Token: 0x170002A4 RID: 676
		// (get) Token: 0x06000A0B RID: 2571 RVA: 0x00021BF3 File Offset: 0x0001FDF3
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x170002A5 RID: 677
		// (get) Token: 0x06000A0C RID: 2572 RVA: 0x00021BFB File Offset: 0x0001FDFB
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return ISequenceInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06000A0D RID: 2573 RVA: 0x00021C07 File Offset: 0x0001FE07
		[NullableContext(2)]
		public static ISequence GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return Java.Lang.Object.GetObject<ISequence>(handle, transfer);
		}

		// Token: 0x06000A0E RID: 2574 RVA: 0x00021C10 File Offset: 0x0001FE10
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, ISequenceInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'kotlin.sequences.Sequence'.");
			}
			return handle;
		}

		// Token: 0x06000A0F RID: 2575 RVA: 0x00021C3B File Offset: 0x0001FE3B
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x06000A10 RID: 2576 RVA: 0x00021C6C File Offset: 0x0001FE6C
		public ISequenceInvoker(IntPtr handle, JniHandleOwnership transfer) : base(ISequenceInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x06000A11 RID: 2577 RVA: 0x00021CA4 File Offset: 0x0001FEA4
		private static Delegate GetIteratorHandler()
		{
			if (ISequenceInvoker.cb_iterator == null)
			{
				ISequenceInvoker.cb_iterator = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(ISequenceInvoker.n_Iterator));
			}
			return ISequenceInvoker.cb_iterator;
		}

		// Token: 0x06000A12 RID: 2578 RVA: 0x00021CC8 File Offset: 0x0001FEC8
		private static IntPtr n_Iterator(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<ISequence>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Iterator());
		}

		// Token: 0x06000A13 RID: 2579 RVA: 0x00021CDC File Offset: 0x0001FEDC
		public IIterator Iterator()
		{
			if (this.id_iterator == IntPtr.Zero)
			{
				this.id_iterator = JNIEnv.GetMethodID(this.class_ref, "iterator", "()Ljava/util/Iterator;");
			}
			return Java.Lang.Object.GetObject<IIterator>(JNIEnv.CallObjectMethod(base.Handle, this.id_iterator), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x0400025E RID: 606
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/sequences/Sequence", typeof(ISequenceInvoker));

		// Token: 0x0400025F RID: 607
		private IntPtr class_ref;

		// Token: 0x04000260 RID: 608
		[Nullable(2)]
		private static Delegate cb_iterator;

		// Token: 0x04000261 RID: 609
		private IntPtr id_iterator;
	}
}
