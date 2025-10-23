using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.IO;
using Java.Lang;

namespace Kotlin.IO
{
	// Token: 0x02000222 RID: 546
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlin/io/FileSystemException", DoNotGenerateAcw = true)]
	public class FileSystemException : IOException
	{
		// Token: 0x1700073F RID: 1855
		// (get) Token: 0x06001969 RID: 6505 RVA: 0x000554EC File Offset: 0x000536EC
		internal static IntPtr class_ref
		{
			get
			{
				return FileSystemException._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000740 RID: 1856
		// (get) Token: 0x0600196A RID: 6506 RVA: 0x00055510 File Offset: 0x00053710
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return FileSystemException._members;
			}
		}

		// Token: 0x17000741 RID: 1857
		// (get) Token: 0x0600196B RID: 6507 RVA: 0x00055518 File Offset: 0x00053718
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return FileSystemException._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000742 RID: 1858
		// (get) Token: 0x0600196C RID: 6508 RVA: 0x0005553C File Offset: 0x0005373C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return FileSystemException._members.ManagedPeerType;
			}
		}

		// Token: 0x0600196D RID: 6509 RVA: 0x00055548 File Offset: 0x00053748
		protected FileSystemException(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x0600196E RID: 6510 RVA: 0x00055554 File Offset: 0x00053754
		[NullableContext(2)]
		[Register(".ctor", "(Ljava/io/File;Ljava/io/File;Ljava/lang/String;)V", "")]
		public unsafe FileSystemException([Nullable(1)] File file, File other, string reason) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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
				base.SetHandle(FileSystemException._members.InstanceMethods.StartCreateInstance("(Ljava/io/File;Ljava/io/File;Ljava/lang/String;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				FileSystemException._members.InstanceMethods.FinishCreateInstance("(Ljava/io/File;Ljava/io/File;Ljava/lang/String;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(file);
				GC.KeepAlive(other);
			}
		}

		// Token: 0x17000743 RID: 1859
		// (get) Token: 0x0600196F RID: 6511 RVA: 0x0005564C File Offset: 0x0005384C
		public File File
		{
			[Register("getFile", "()Ljava/io/File;", "")]
			get
			{
				return Java.Lang.Object.GetObject<File>(FileSystemException._members.InstanceMethods.InvokeNonvirtualObjectMethod("getFile.()Ljava/io/File;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000744 RID: 1860
		// (get) Token: 0x06001970 RID: 6512 RVA: 0x00055680 File Offset: 0x00053880
		[Nullable(2)]
		public File Other
		{
			[NullableContext(2)]
			[Register("getOther", "()Ljava/io/File;", "")]
			get
			{
				return Java.Lang.Object.GetObject<File>(FileSystemException._members.InstanceMethods.InvokeNonvirtualObjectMethod("getOther.()Ljava/io/File;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000745 RID: 1861
		// (get) Token: 0x06001971 RID: 6513 RVA: 0x000556B4 File Offset: 0x000538B4
		[Nullable(2)]
		public string Reason
		{
			[NullableContext(2)]
			[Register("getReason", "()Ljava/lang/String;", "")]
			get
			{
				return JNIEnv.GetString(FileSystemException._members.InstanceMethods.InvokeNonvirtualObjectMethod("getReason.()Ljava/lang/String;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x040007D3 RID: 2003
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/io/FileSystemException", typeof(FileSystemException));
	}
}
