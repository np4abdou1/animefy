using System;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using Android.Runtime;
using Java.Interop;
using Java.IO;
using Java.Lang;

namespace Bumptech.Glide.Util
{
	// Token: 0x02000048 RID: 72
	[Register("com/bumptech/glide/util/ExceptionPassthroughInputStream", DoNotGenerateAcw = true)]
	public sealed class ExceptionPassthroughInputStream : InputStream
	{
		// Token: 0x17000067 RID: 103
		// (get) Token: 0x0600032E RID: 814 RVA: 0x0000AF00 File Offset: 0x00009100
		internal static IntPtr class_ref
		{
			get
			{
				return ExceptionPassthroughInputStream._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000068 RID: 104
		// (get) Token: 0x0600032F RID: 815 RVA: 0x0000AF24 File Offset: 0x00009124
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return ExceptionPassthroughInputStream._members;
			}
		}

		// Token: 0x17000069 RID: 105
		// (get) Token: 0x06000330 RID: 816 RVA: 0x0000AF2C File Offset: 0x0000912C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return ExceptionPassthroughInputStream._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700006A RID: 106
		// (get) Token: 0x06000331 RID: 817 RVA: 0x0000AF50 File Offset: 0x00009150
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return ExceptionPassthroughInputStream._members.ManagedPeerType;
			}
		}

		// Token: 0x06000332 RID: 818 RVA: 0x0000AF5C File Offset: 0x0000915C
		internal ExceptionPassthroughInputStream(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x1700006B RID: 107
		// (get) Token: 0x06000333 RID: 819 RVA: 0x0000AF68 File Offset: 0x00009168
		public Java.IO.IOException Exception
		{
			[Register("getException", "()Ljava/io/IOException;", "")]
			get
			{
				return Java.Lang.Object.GetObject<Java.IO.IOException>(ExceptionPassthroughInputStream._members.InstanceMethods.InvokeAbstractObjectMethod("getException.()Ljava/io/IOException;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06000334 RID: 820 RVA: 0x0000AF9C File Offset: 0x0000919C
		[Register("obtain", "(Ljava/io/InputStream;)Lcom/bumptech/glide/util/ExceptionPassthroughInputStream;", "")]
		public unsafe static ExceptionPassthroughInputStream Obtain(Stream toWrap)
		{
			IntPtr intPtr = InputStreamAdapter.ToLocalJniHandle(toWrap);
			ExceptionPassthroughInputStream @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<ExceptionPassthroughInputStream>(ExceptionPassthroughInputStream._members.StaticMethods.InvokeObjectMethod("obtain.(Ljava/io/InputStream;)Lcom/bumptech/glide/util/ExceptionPassthroughInputStream;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(toWrap);
			}
			return @object;
		}

		// Token: 0x06000335 RID: 821 RVA: 0x0000B00C File Offset: 0x0000920C
		[Register("read", "()I", "")]
		public override int Read()
		{
			return ExceptionPassthroughInputStream._members.InstanceMethods.InvokeAbstractInt32Method("read.()I", this, null);
		}

		// Token: 0x06000336 RID: 822 RVA: 0x0000B025 File Offset: 0x00009225
		[Register("release", "()V", "")]
		public void Release()
		{
			ExceptionPassthroughInputStream._members.InstanceMethods.InvokeAbstractVoidMethod("release.()V", this, null);
		}

		// Token: 0x040000AB RID: 171
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/bumptech/glide/util/ExceptionPassthroughInputStream", typeof(ExceptionPassthroughInputStream));
	}
}
