using System;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using Android.Runtime;
using Java.Interop;
using Java.IO;

namespace Bumptech.Glide.Util
{
	// Token: 0x02000046 RID: 70
	[Register("com/bumptech/glide/util/ContentLengthInputStream", DoNotGenerateAcw = true)]
	public sealed class ContentLengthInputStream : FilterInputStream
	{
		// Token: 0x1700005E RID: 94
		// (get) Token: 0x06000316 RID: 790 RVA: 0x0000AB6C File Offset: 0x00008D6C
		internal static IntPtr class_ref
		{
			get
			{
				return ContentLengthInputStream._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700005F RID: 95
		// (get) Token: 0x06000317 RID: 791 RVA: 0x0000AB90 File Offset: 0x00008D90
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return ContentLengthInputStream._members;
			}
		}

		// Token: 0x17000060 RID: 96
		// (get) Token: 0x06000318 RID: 792 RVA: 0x0000AB98 File Offset: 0x00008D98
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return ContentLengthInputStream._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000061 RID: 97
		// (get) Token: 0x06000319 RID: 793 RVA: 0x0000ABBC File Offset: 0x00008DBC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return ContentLengthInputStream._members.ManagedPeerType;
			}
		}

		// Token: 0x0600031A RID: 794 RVA: 0x0000ABC8 File Offset: 0x00008DC8
		internal ContentLengthInputStream(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x0600031B RID: 795 RVA: 0x0000ABD4 File Offset: 0x00008DD4
		[Register("obtain", "(Ljava/io/InputStream;Ljava/lang/String;)Ljava/io/InputStream;", "")]
		public unsafe static Stream Obtain(Stream other, string contentLengthHeader)
		{
			IntPtr intPtr = InputStreamAdapter.ToLocalJniHandle(other);
			IntPtr intPtr2 = JNIEnv.NewString(contentLengthHeader);
			Stream result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(intPtr2);
				result = InputStreamInvoker.FromJniHandle(ContentLengthInputStream._members.StaticMethods.InvokeObjectMethod("obtain.(Ljava/io/InputStream;Ljava/lang/String;)Ljava/io/InputStream;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				JNIEnv.DeleteLocalRef(intPtr2);
				GC.KeepAlive(other);
			}
			return result;
		}

		// Token: 0x0600031C RID: 796 RVA: 0x0000AC68 File Offset: 0x00008E68
		[Register("obtain", "(Ljava/io/InputStream;J)Ljava/io/InputStream;", "")]
		public unsafe static Stream Obtain(Stream other, long contentLength)
		{
			IntPtr intPtr = InputStreamAdapter.ToLocalJniHandle(other);
			Stream result;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(contentLength);
				result = InputStreamInvoker.FromJniHandle(ContentLengthInputStream._members.StaticMethods.InvokeObjectMethod("obtain.(Ljava/io/InputStream;J)Ljava/io/InputStream;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(other);
			}
			return result;
		}

		// Token: 0x040000A6 RID: 166
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/bumptech/glide/util/ContentLengthInputStream", typeof(ContentLengthInputStream));
	}
}
