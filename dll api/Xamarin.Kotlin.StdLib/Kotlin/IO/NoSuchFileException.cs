using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.IO;

namespace Kotlin.IO
{
	// Token: 0x02000225 RID: 549
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlin/io/NoSuchFileException", DoNotGenerateAcw = true)]
	public sealed class NoSuchFileException : FileSystemException
	{
		// Token: 0x17000751 RID: 1873
		// (get) Token: 0x06001989 RID: 6537 RVA: 0x00055B34 File Offset: 0x00053D34
		internal new static IntPtr class_ref
		{
			get
			{
				return NoSuchFileException._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000752 RID: 1874
		// (get) Token: 0x0600198A RID: 6538 RVA: 0x00055B58 File Offset: 0x00053D58
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return NoSuchFileException._members;
			}
		}

		// Token: 0x17000753 RID: 1875
		// (get) Token: 0x0600198B RID: 6539 RVA: 0x00055B60 File Offset: 0x00053D60
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return NoSuchFileException._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000754 RID: 1876
		// (get) Token: 0x0600198C RID: 6540 RVA: 0x00055B84 File Offset: 0x00053D84
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return NoSuchFileException._members.ManagedPeerType;
			}
		}

		// Token: 0x0600198D RID: 6541 RVA: 0x00055B90 File Offset: 0x00053D90
		internal NoSuchFileException(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x0600198E RID: 6542 RVA: 0x00055B9C File Offset: 0x00053D9C
		[NullableContext(2)]
		[Register(".ctor", "(Ljava/io/File;Ljava/io/File;Ljava/lang/String;)V", "")]
		public unsafe NoSuchFileException([Nullable(1)] File file, File other, string reason) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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
				base.SetHandle(NoSuchFileException._members.InstanceMethods.StartCreateInstance("(Ljava/io/File;Ljava/io/File;Ljava/lang/String;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				NoSuchFileException._members.InstanceMethods.FinishCreateInstance("(Ljava/io/File;Ljava/io/File;Ljava/lang/String;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(file);
				GC.KeepAlive(other);
			}
		}

		// Token: 0x040007D6 RID: 2006
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/io/NoSuchFileException", typeof(NoSuchFileException));
	}
}
