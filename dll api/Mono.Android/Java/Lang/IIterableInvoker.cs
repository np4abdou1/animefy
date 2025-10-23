using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Util;

namespace Java.Lang
{
	// Token: 0x020003D8 RID: 984
	[Register("java/lang/Iterable", DoNotGenerateAcw = true)]
	internal class IIterableInvoker : Object, IIterable, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000879 RID: 2169
		// (get) Token: 0x06002B4C RID: 11084 RVA: 0x00078758 File Offset: 0x00076958
		private static IntPtr java_class_ref
		{
			get
			{
				return IIterableInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700087A RID: 2170
		// (get) Token: 0x06002B4D RID: 11085 RVA: 0x0007877C File Offset: 0x0007697C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IIterableInvoker._members;
			}
		}

		// Token: 0x1700087B RID: 2171
		// (get) Token: 0x06002B4E RID: 11086 RVA: 0x00078783 File Offset: 0x00076983
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x1700087C RID: 2172
		// (get) Token: 0x06002B4F RID: 11087 RVA: 0x0007878B File Offset: 0x0007698B
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IIterableInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06002B50 RID: 11088 RVA: 0x00078797 File Offset: 0x00076997
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IIterableInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'java.lang.Iterable'.");
			}
			return handle;
		}

		// Token: 0x06002B51 RID: 11089 RVA: 0x000787C2 File Offset: 0x000769C2
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x06002B52 RID: 11090 RVA: 0x000787F4 File Offset: 0x000769F4
		public IIterableInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IIterableInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x06002B53 RID: 11091 RVA: 0x0007882C File Offset: 0x00076A2C
		private static Delegate GetIteratorHandler()
		{
			if (IIterableInvoker.cb_iterator == null)
			{
				IIterableInvoker.cb_iterator = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(IIterableInvoker.n_Iterator));
			}
			return IIterableInvoker.cb_iterator;
		}

		// Token: 0x06002B54 RID: 11092 RVA: 0x00078850 File Offset: 0x00076A50
		private static IntPtr n_Iterator(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Object.GetObject<IIterable>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Iterator());
		}

		// Token: 0x06002B55 RID: 11093 RVA: 0x00078864 File Offset: 0x00076A64
		public IIterator Iterator()
		{
			if (this.id_iterator == IntPtr.Zero)
			{
				this.id_iterator = JNIEnv.GetMethodID(this.class_ref, "iterator", "()Ljava/util/Iterator;");
			}
			return Object.GetObject<IIterator>(JNIEnv.CallObjectMethod(base.Handle, this.id_iterator), JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x04001161 RID: 4449
		private static readonly JniPeerMembers _members = new XAPeerMembers("java/lang/Iterable", typeof(IIterableInvoker));

		// Token: 0x04001162 RID: 4450
		private IntPtr class_ref;

		// Token: 0x04001163 RID: 4451
		private static Delegate cb_iterator;

		// Token: 0x04001164 RID: 4452
		private IntPtr id_iterator;
	}
}
