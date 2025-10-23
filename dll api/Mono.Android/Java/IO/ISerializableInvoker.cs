using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Java.IO
{
	// Token: 0x0200041F RID: 1055
	[Register("java/io/Serializable", DoNotGenerateAcw = true)]
	internal class ISerializableInvoker : Java.Lang.Object, ISerializable, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x1700095B RID: 2395
		// (get) Token: 0x06002E1A RID: 11802 RVA: 0x0007E394 File Offset: 0x0007C594
		private static IntPtr java_class_ref
		{
			get
			{
				return ISerializableInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700095C RID: 2396
		// (get) Token: 0x06002E1B RID: 11803 RVA: 0x0007E3B8 File Offset: 0x0007C5B8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return ISerializableInvoker._members;
			}
		}

		// Token: 0x1700095D RID: 2397
		// (get) Token: 0x06002E1C RID: 11804 RVA: 0x0007E3BF File Offset: 0x0007C5BF
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x1700095E RID: 2398
		// (get) Token: 0x06002E1D RID: 11805 RVA: 0x0007E3C7 File Offset: 0x0007C5C7
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return ISerializableInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06002E1E RID: 11806 RVA: 0x0007E3D3 File Offset: 0x0007C5D3
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, ISerializableInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'java.io.Serializable'.");
			}
			return handle;
		}

		// Token: 0x06002E1F RID: 11807 RVA: 0x0007E3FE File Offset: 0x0007C5FE
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x06002E20 RID: 11808 RVA: 0x0007E430 File Offset: 0x0007C630
		public ISerializableInvoker(IntPtr handle, JniHandleOwnership transfer) : base(ISerializableInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x0400121D RID: 4637
		private static readonly JniPeerMembers _members = new XAPeerMembers("java/io/Serializable", typeof(ISerializableInvoker));

		// Token: 0x0400121E RID: 4638
		private IntPtr class_ref;
	}
}
