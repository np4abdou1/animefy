using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Xamarin.KotlinX.Coroutines
{
	// Token: 0x0200001F RID: 31
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlinx/coroutines/CompletionHandlerException", DoNotGenerateAcw = true)]
	public sealed class CompletionHandlerException : RuntimeException
	{
		// Token: 0x1700001D RID: 29
		// (get) Token: 0x06000083 RID: 131 RVA: 0x00002DD0 File Offset: 0x00000FD0
		internal static IntPtr class_ref
		{
			get
			{
				return CompletionHandlerException._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x06000084 RID: 132 RVA: 0x00002DF4 File Offset: 0x00000FF4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return CompletionHandlerException._members;
			}
		}

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x06000085 RID: 133 RVA: 0x00002DFC File Offset: 0x00000FFC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return CompletionHandlerException._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x06000086 RID: 134 RVA: 0x00002E20 File Offset: 0x00001020
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return CompletionHandlerException._members.ManagedPeerType;
			}
		}

		// Token: 0x06000087 RID: 135 RVA: 0x00002E2C File Offset: 0x0000102C
		internal CompletionHandlerException(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000088 RID: 136 RVA: 0x00002E38 File Offset: 0x00001038
		[Register(".ctor", "(Ljava/lang/String;Ljava/lang/Throwable;)V", "")]
		public unsafe CompletionHandlerException(string message, Throwable cause) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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
				ptr[1] = new JniArgumentValue((cause == null) ? IntPtr.Zero : cause.Handle);
				base.SetHandle(CompletionHandlerException._members.InstanceMethods.StartCreateInstance("(Ljava/lang/String;Ljava/lang/Throwable;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				CompletionHandlerException._members.InstanceMethods.FinishCreateInstance("(Ljava/lang/String;Ljava/lang/Throwable;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(cause);
			}
		}

		// Token: 0x0400000B RID: 11
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlinx/coroutines/CompletionHandlerException", typeof(CompletionHandlerException));
	}
}
