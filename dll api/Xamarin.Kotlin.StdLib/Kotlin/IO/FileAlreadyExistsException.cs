using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.IO;

namespace Kotlin.IO
{
	// Token: 0x02000220 RID: 544
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlin/io/FileAlreadyExistsException", DoNotGenerateAcw = true)]
	public sealed class FileAlreadyExistsException : FileSystemException
	{
		// Token: 0x17000737 RID: 1847
		// (get) Token: 0x06001934 RID: 6452 RVA: 0x00053BD8 File Offset: 0x00051DD8
		internal new static IntPtr class_ref
		{
			get
			{
				return FileAlreadyExistsException._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000738 RID: 1848
		// (get) Token: 0x06001935 RID: 6453 RVA: 0x00053BFC File Offset: 0x00051DFC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return FileAlreadyExistsException._members;
			}
		}

		// Token: 0x17000739 RID: 1849
		// (get) Token: 0x06001936 RID: 6454 RVA: 0x00053C04 File Offset: 0x00051E04
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return FileAlreadyExistsException._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700073A RID: 1850
		// (get) Token: 0x06001937 RID: 6455 RVA: 0x00053C28 File Offset: 0x00051E28
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return FileAlreadyExistsException._members.ManagedPeerType;
			}
		}

		// Token: 0x06001938 RID: 6456 RVA: 0x00053C34 File Offset: 0x00051E34
		internal FileAlreadyExistsException(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06001939 RID: 6457 RVA: 0x00053C40 File Offset: 0x00051E40
		[NullableContext(2)]
		[Register(".ctor", "(Ljava/io/File;Ljava/io/File;Ljava/lang/String;)V", "")]
		public unsafe FileAlreadyExistsException([Nullable(1)] File file, File other, string reason) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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
				base.SetHandle(FileAlreadyExistsException._members.InstanceMethods.StartCreateInstance("(Ljava/io/File;Ljava/io/File;Ljava/lang/String;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				FileAlreadyExistsException._members.InstanceMethods.FinishCreateInstance("(Ljava/io/File;Ljava/io/File;Ljava/lang/String;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(file);
				GC.KeepAlive(other);
			}
		}

		// Token: 0x040007D1 RID: 2001
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/io/FileAlreadyExistsException", typeof(FileAlreadyExistsException));
	}
}
