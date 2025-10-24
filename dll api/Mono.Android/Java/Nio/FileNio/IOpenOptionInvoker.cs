using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Java.Nio.FileNio
{
	// Token: 0x02000380 RID: 896
	[Register("java/nio/file/OpenOption", DoNotGenerateAcw = true, ApiSince = 26)]
	internal class IOpenOptionInvoker : Java.Lang.Object, IOpenOption, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000783 RID: 1923
		// (get) Token: 0x06002761 RID: 10081 RVA: 0x000700A0 File Offset: 0x0006E2A0
		private static IntPtr java_class_ref
		{
			get
			{
				return IOpenOptionInvoker._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000784 RID: 1924
		// (get) Token: 0x06002762 RID: 10082 RVA: 0x000700C4 File Offset: 0x0006E2C4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IOpenOptionInvoker._members;
			}
		}

		// Token: 0x17000785 RID: 1925
		// (get) Token: 0x06002763 RID: 10083 RVA: 0x000700CB File Offset: 0x0006E2CB
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return this.class_ref;
			}
		}

		// Token: 0x17000786 RID: 1926
		// (get) Token: 0x06002764 RID: 10084 RVA: 0x000700D3 File Offset: 0x0006E2D3
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IOpenOptionInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06002765 RID: 10085 RVA: 0x000700DF File Offset: 0x0006E2DF
		private static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, IOpenOptionInvoker.java_class_ref))
			{
				throw new InvalidCastException("Unable to convert instance of type '" + JNIEnv.GetClassNameFromInstance(handle) + "' to type 'java.nio.file.OpenOption'.");
			}
			return handle;
		}

		// Token: 0x06002766 RID: 10086 RVA: 0x0007010A File Offset: 0x0006E30A
		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
			{
				JNIEnv.DeleteGlobalRef(this.class_ref);
			}
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		// Token: 0x06002767 RID: 10087 RVA: 0x0007013C File Offset: 0x0006E33C
		public IOpenOptionInvoker(IntPtr handle, JniHandleOwnership transfer) : base(IOpenOptionInvoker.Validate(handle), transfer)
		{
			IntPtr objectClass = JNIEnv.GetObjectClass(base.Handle);
			this.class_ref = JNIEnv.NewGlobalRef(objectClass);
			JNIEnv.DeleteLocalRef(objectClass);
		}

		// Token: 0x0400102A RID: 4138
		private static readonly JniPeerMembers _members = new XAPeerMembers("java/nio/file/OpenOption", typeof(IOpenOptionInvoker));

		// Token: 0x0400102B RID: 4139
		private IntPtr class_ref;
	}
}
