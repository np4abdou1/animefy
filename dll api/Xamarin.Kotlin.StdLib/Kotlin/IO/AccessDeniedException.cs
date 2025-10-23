using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.IO;

namespace Kotlin.IO
{
	// Token: 0x0200021A RID: 538
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlin/io/AccessDeniedException", DoNotGenerateAcw = true)]
	public sealed class AccessDeniedException : FileSystemException
	{
		// Token: 0x1700071F RID: 1823
		// (get) Token: 0x06001908 RID: 6408 RVA: 0x00053508 File Offset: 0x00051708
		internal new static IntPtr class_ref
		{
			get
			{
				return AccessDeniedException._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000720 RID: 1824
		// (get) Token: 0x06001909 RID: 6409 RVA: 0x0005352C File Offset: 0x0005172C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return AccessDeniedException._members;
			}
		}

		// Token: 0x17000721 RID: 1825
		// (get) Token: 0x0600190A RID: 6410 RVA: 0x00053534 File Offset: 0x00051734
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return AccessDeniedException._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000722 RID: 1826
		// (get) Token: 0x0600190B RID: 6411 RVA: 0x00053558 File Offset: 0x00051758
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return AccessDeniedException._members.ManagedPeerType;
			}
		}

		// Token: 0x0600190C RID: 6412 RVA: 0x00053564 File Offset: 0x00051764
		internal AccessDeniedException(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x0600190D RID: 6413 RVA: 0x00053570 File Offset: 0x00051770
		[NullableContext(2)]
		[Register(".ctor", "(Ljava/io/File;Ljava/io/File;Ljava/lang/String;)V", "")]
		public unsafe AccessDeniedException([Nullable(1)] File file, File other, string reason) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			IntPtr intPtr = JNIEnv.NewString(reason);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((file == null) ? IntPtr.Zero : file.Handle);
				ptr[1] = new JniArgumentValue((other == null) ? IntPtr.Zero : other.Handle);
				ptr[2] = new JniArgumentValue(intPtr);
				base.SetHandle(AccessDeniedException._members.InstanceMethods.StartCreateInstance("(Ljava/io/File;Ljava/io/File;Ljava/lang/String;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				AccessDeniedException._members.InstanceMethods.FinishCreateInstance("(Ljava/io/File;Ljava/io/File;Ljava/lang/String;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(file);
				GC.KeepAlive(other);
			}
		}

		// Token: 0x040007CA RID: 1994
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/io/AccessDeniedException", typeof(AccessDeniedException));
	}
}
