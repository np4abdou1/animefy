using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Java.Nio.FileNio
{
	// Token: 0x0200037C RID: 892
	[Register("java/nio/file/CopyOption", DoNotGenerateAcw = true, ApiSince = 26)]
	internal class ICopyOptionInvoker : Java.Lang.Object, ICopyOption, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x1700077B RID: 1915
		// (get) Token: 0x06002741 RID: 10049 RVA: 0x0006FAEC File Offset: 0x0006DCEC
		private static IntPtr java_class_ref
		{
			get
			{
				return ICopyOptionInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700077C RID: 1916
		// (get) Token: 0x06002742 RID: 10050 RVA: 0x0006FB10 File Offset: 0x0006DD10
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return ICopyOptionInvoker._members;
			}
		}

		// Token: 0x1700077D RID: 1917
		// (get) Token: 0x06002743 RID: 10051 RVA: 0x0006FB17 File Offset: 0x0006DD17
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x1700077E RID: 1918
		// (get) Token: 0x06002744 RID: 10052 RVA: 0x0006FB1F File Offset: 0x0006DD1F
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return ICopyOptionInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06002745 RID: 10053 RVA: 0x0006FB2B File Offset: 0x0006DD2B
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, ICopyOptionInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'java.nio.file.CopyOption'.");
			}
			return handle;
		}

		// Token: 0x06002746 RID: 10054 RVA: 0x0006FB56 File Offset: 0x0006DD56
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x06002747 RID: 10055 RVA: 0x0006FB88 File Offset: 0x0006DD88
		public ICopyOptionInvoker(IntPtr handle, JniHandleOwnership transfer) : base(ICopyOptionInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x0400101E RID: 4126
		private static readonly JniPeerMembers _members = new XAPeerMembers("java/nio/file/CopyOption", typeof(ICopyOptionInvoker));

		// Token: 0x0400101F RID: 4127
		private IntPtr class_ref;
	}
}
