using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Android.Text
{
	// Token: 0x020001A3 RID: 419
	[Register("android/text/NoCopySpan", DoNotGenerateAcw = true)]
	internal class INoCopySpanInvoker : Java.Lang.Object, INoCopySpan, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x170002E3 RID: 739
		// (get) Token: 0x06000ECA RID: 3786 RVA: 0x000262D8 File Offset: 0x000244D8
		private static IntPtr java_class_ref
		{
			get
			{
				return INoCopySpanInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170002E4 RID: 740
		// (get) Token: 0x06000ECB RID: 3787 RVA: 0x000262FC File Offset: 0x000244FC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return INoCopySpanInvoker._members;
			}
		}

		// Token: 0x170002E5 RID: 741
		// (get) Token: 0x06000ECC RID: 3788 RVA: 0x00026303 File Offset: 0x00024503
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x170002E6 RID: 742
		// (get) Token: 0x06000ECD RID: 3789 RVA: 0x0002630B File Offset: 0x0002450B
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return INoCopySpanInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06000ECE RID: 3790 RVA: 0x00026317 File Offset: 0x00024517
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, INoCopySpanInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'android.text.NoCopySpan'.");
			}
			return handle;
		}

		// Token: 0x06000ECF RID: 3791 RVA: 0x00026342 File Offset: 0x00024542
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x06000ED0 RID: 3792 RVA: 0x00026374 File Offset: 0x00024574
		public INoCopySpanInvoker(IntPtr handle, JniHandleOwnership transfer) : base(INoCopySpanInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x040006E3 RID: 1763
		private static readonly JniPeerMembers _members = new XAPeerMembers("android/text/NoCopySpan", typeof(INoCopySpanInvoker));

		// Token: 0x040006E4 RID: 1764
		private IntPtr class_ref;
	}
}
