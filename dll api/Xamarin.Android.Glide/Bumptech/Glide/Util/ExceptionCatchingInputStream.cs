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
	// Token: 0x02000047 RID: 71
	[Obsolete("This class is obsoleted in this android platform")]
	[Register("com/bumptech/glide/util/ExceptionCatchingInputStream", DoNotGenerateAcw = true)]
	public class ExceptionCatchingInputStream : InputStream
	{
		// Token: 0x17000062 RID: 98
		// (get) Token: 0x0600031E RID: 798 RVA: 0x0000AD08 File Offset: 0x00008F08
		internal static IntPtr class_ref
		{
			get
			{
				return ExceptionCatchingInputStream._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000063 RID: 99
		// (get) Token: 0x0600031F RID: 799 RVA: 0x0000AD2C File Offset: 0x00008F2C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return ExceptionCatchingInputStream._members;
			}
		}

		// Token: 0x17000064 RID: 100
		// (get) Token: 0x06000320 RID: 800 RVA: 0x0000AD34 File Offset: 0x00008F34
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return ExceptionCatchingInputStream._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000065 RID: 101
		// (get) Token: 0x06000321 RID: 801 RVA: 0x0000AD58 File Offset: 0x00008F58
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return ExceptionCatchingInputStream._members.ManagedPeerType;
			}
		}

		// Token: 0x06000322 RID: 802 RVA: 0x0000AD64 File Offset: 0x00008F64
		protected ExceptionCatchingInputStream(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000323 RID: 803 RVA: 0x0000AD6E File Offset: 0x00008F6E
		private static Delegate GetGetExceptionHandler()
		{
			if (ExceptionCatchingInputStream.cb_getException == null)
			{
				ExceptionCatchingInputStream.cb_getException = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_L(ExceptionCatchingInputStream.n_GetException));
			}
			return ExceptionCatchingInputStream.cb_getException;
		}

		// Token: 0x06000324 RID: 804 RVA: 0x0000AD92 File Offset: 0x00008F92
		private static IntPtr n_GetException(IntPtr jnienv, IntPtr native__this)
		{
			return JNIEnv.ToLocalJniHandle(Java.Lang.Object.GetObject<ExceptionCatchingInputStream>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Exception);
		}

		// Token: 0x17000066 RID: 102
		// (get) Token: 0x06000325 RID: 805 RVA: 0x0000ADA8 File Offset: 0x00008FA8
		public virtual Java.IO.IOException Exception
		{
			[Register("getException", "()Ljava/io/IOException;", "GetGetExceptionHandler")]
			get
			{
				return Java.Lang.Object.GetObject<Java.IO.IOException>(ExceptionCatchingInputStream._members.InstanceMethods.InvokeVirtualObjectMethod("getException.()Ljava/io/IOException;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06000326 RID: 806 RVA: 0x0000ADDC File Offset: 0x00008FDC
		[Register("obtain", "(Ljava/io/InputStream;)Lcom/bumptech/glide/util/ExceptionCatchingInputStream;", "")]
		public unsafe static ExceptionCatchingInputStream Obtain(Stream toWrap)
		{
			IntPtr intPtr = InputStreamAdapter.ToLocalJniHandle(toWrap);
			ExceptionCatchingInputStream @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				@object = Java.Lang.Object.GetObject<ExceptionCatchingInputStream>(ExceptionCatchingInputStream._members.StaticMethods.InvokeObjectMethod("obtain.(Ljava/io/InputStream;)Lcom/bumptech/glide/util/ExceptionCatchingInputStream;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(toWrap);
			}
			return @object;
		}

		// Token: 0x06000327 RID: 807 RVA: 0x0000AE4C File Offset: 0x0000904C
		private static Delegate GetReadHandler()
		{
			if (ExceptionCatchingInputStream.cb_read == null)
			{
				ExceptionCatchingInputStream.cb_read = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_I(ExceptionCatchingInputStream.n_Read));
			}
			return ExceptionCatchingInputStream.cb_read;
		}

		// Token: 0x06000328 RID: 808 RVA: 0x0000AE70 File Offset: 0x00009070
		private static int n_Read(IntPtr jnienv, IntPtr native__this)
		{
			return Java.Lang.Object.GetObject<ExceptionCatchingInputStream>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Read();
		}

		// Token: 0x06000329 RID: 809 RVA: 0x0000AE7F File Offset: 0x0000907F
		[Register("read", "()I", "GetReadHandler")]
		public override int Read()
		{
			return ExceptionCatchingInputStream._members.InstanceMethods.InvokeVirtualInt32Method("read.()I", this, null);
		}

		// Token: 0x0600032A RID: 810 RVA: 0x0000AE98 File Offset: 0x00009098
		private static Delegate GetReleaseHandler()
		{
			if (ExceptionCatchingInputStream.cb_release == null)
			{
				ExceptionCatchingInputStream.cb_release = JNINativeWrapper.CreateDelegate(new _JniMarshal_PP_V(ExceptionCatchingInputStream.n_Release));
			}
			return ExceptionCatchingInputStream.cb_release;
		}

		// Token: 0x0600032B RID: 811 RVA: 0x0000AEBC File Offset: 0x000090BC
		private static void n_Release(IntPtr jnienv, IntPtr native__this)
		{
			Java.Lang.Object.GetObject<ExceptionCatchingInputStream>(jnienv, native__this, JniHandleOwnership.DoNotTransfer).Release();
		}

		// Token: 0x0600032C RID: 812 RVA: 0x0000AECB File Offset: 0x000090CB
		[Register("release", "()V", "GetReleaseHandler")]
		public virtual void Release()
		{
			ExceptionCatchingInputStream._members.InstanceMethods.InvokeVirtualVoidMethod("release.()V", this, null);
		}

		// Token: 0x040000A7 RID: 167
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/bumptech/glide/util/ExceptionCatchingInputStream", typeof(ExceptionCatchingInputStream));

		// Token: 0x040000A8 RID: 168
		private static Delegate cb_getException;

		// Token: 0x040000A9 RID: 169
		private static Delegate cb_read;

		// Token: 0x040000AA RID: 170
		private static Delegate cb_release;
	}
}
