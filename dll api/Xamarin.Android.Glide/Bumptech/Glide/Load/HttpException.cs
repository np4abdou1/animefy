using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.IO;
using Java.Lang;

namespace Bumptech.Glide.Load
{
	// Token: 0x020000CA RID: 202
	[Register("com/bumptech/glide/load/HttpException", DoNotGenerateAcw = true)]
	public sealed class HttpException : IOException
	{
		// Token: 0x1700025E RID: 606
		// (get) Token: 0x06000A79 RID: 2681 RVA: 0x0002083C File Offset: 0x0001EA3C
		internal static IntPtr class_ref
		{
			get
			{
				return HttpException._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700025F RID: 607
		// (get) Token: 0x06000A7A RID: 2682 RVA: 0x00020860 File Offset: 0x0001EA60
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return HttpException._members;
			}
		}

		// Token: 0x17000260 RID: 608
		// (get) Token: 0x06000A7B RID: 2683 RVA: 0x00020868 File Offset: 0x0001EA68
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return HttpException._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000261 RID: 609
		// (get) Token: 0x06000A7C RID: 2684 RVA: 0x0002088C File Offset: 0x0001EA8C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return HttpException._members.ManagedPeerType;
			}
		}

		// Token: 0x06000A7D RID: 2685 RVA: 0x00020898 File Offset: 0x0001EA98
		internal HttpException(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000A7E RID: 2686 RVA: 0x000208A4 File Offset: 0x0001EAA4
		[Register(".ctor", "(I)V", "")]
		public unsafe HttpException(int statusCode) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(statusCode);
			base.SetHandle(HttpException._members.InstanceMethods.StartCreateInstance("(I)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
			HttpException._members.InstanceMethods.FinishCreateInstance("(I)V", this, ptr);
		}

		// Token: 0x06000A7F RID: 2687 RVA: 0x00020928 File Offset: 0x0001EB28
		[Register(".ctor", "(Ljava/lang/String;)V", "")]
		[Obsolete("deprecated")]
		public unsafe HttpException(string message) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			IntPtr intPtr = JNIEnv.NewString(message);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				base.SetHandle(HttpException._members.InstanceMethods.StartCreateInstance("(Ljava/lang/String;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				HttpException._members.InstanceMethods.FinishCreateInstance("(Ljava/lang/String;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
		}

		// Token: 0x06000A80 RID: 2688 RVA: 0x000209CC File Offset: 0x0001EBCC
		[Register(".ctor", "(Ljava/lang/String;I)V", "")]
		public unsafe HttpException(string message, int statusCode) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			IntPtr intPtr = JNIEnv.NewString(message);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(statusCode);
				base.SetHandle(HttpException._members.InstanceMethods.StartCreateInstance("(Ljava/lang/String;I)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				HttpException._members.InstanceMethods.FinishCreateInstance("(Ljava/lang/String;I)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
		}

		// Token: 0x06000A81 RID: 2689 RVA: 0x00020A84 File Offset: 0x0001EC84
		[Register(".ctor", "(Ljava/lang/String;ILjava/lang/Throwable;)V", "")]
		public unsafe HttpException(string message, int statusCode, Throwable cause) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			IntPtr intPtr = JNIEnv.NewString(message);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(statusCode);
				ptr[2] = new JniArgumentValue((cause == null) ? IntPtr.Zero : cause.Handle);
				base.SetHandle(HttpException._members.InstanceMethods.StartCreateInstance("(Ljava/lang/String;ILjava/lang/Throwable;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				HttpException._members.InstanceMethods.FinishCreateInstance("(Ljava/lang/String;ILjava/lang/Throwable;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(cause);
			}
		}

		// Token: 0x17000262 RID: 610
		// (get) Token: 0x06000A82 RID: 2690 RVA: 0x00020B68 File Offset: 0x0001ED68
		public int StatusCode
		{
			[Register("getStatusCode", "()I", "")]
			get
			{
				return HttpException._members.InstanceMethods.InvokeAbstractInt32Method("getStatusCode.()I", this, null);
			}
		}

		// Token: 0x04000291 RID: 657
		[Register("UNKNOWN")]
		public const int Unknown = -1;

		// Token: 0x04000292 RID: 658
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/bumptech/glide/load/HttpException", typeof(HttpException));
	}
}
