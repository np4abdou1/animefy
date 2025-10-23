using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Xamarin.Google.Android.DataTransport.Runtime.Synchronization
{
	// Token: 0x02000044 RID: 68
	[Register("com/google/android/datatransport/runtime/synchronization/SynchronizationException", DoNotGenerateAcw = true)]
	public class SynchronizationException : RuntimeException
	{
		// Token: 0x17000099 RID: 153
		// (get) Token: 0x0600021C RID: 540 RVA: 0x00006644 File Offset: 0x00004844
		internal static IntPtr class_ref
		{
			get
			{
				return SynchronizationException._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700009A RID: 154
		// (get) Token: 0x0600021D RID: 541 RVA: 0x00006668 File Offset: 0x00004868
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return SynchronizationException._members;
			}
		}

		// Token: 0x1700009B RID: 155
		// (get) Token: 0x0600021E RID: 542 RVA: 0x00006670 File Offset: 0x00004870
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return SynchronizationException._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700009C RID: 156
		// (get) Token: 0x0600021F RID: 543 RVA: 0x00006694 File Offset: 0x00004894
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return SynchronizationException._members.ManagedPeerType;
			}
		}

		// Token: 0x06000220 RID: 544 RVA: 0x000066A0 File Offset: 0x000048A0
		protected SynchronizationException(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000221 RID: 545 RVA: 0x000066AC File Offset: 0x000048AC
		[Register(".ctor", "(Ljava/lang/String;Ljava/lang/Throwable;)V", "")]
		public unsafe SynchronizationException(string message, Throwable cause) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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
				base.SetHandle(SynchronizationException._members.InstanceMethods.StartCreateInstance("(Ljava/lang/String;Ljava/lang/Throwable;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				SynchronizationException._members.InstanceMethods.FinishCreateInstance("(Ljava/lang/String;Ljava/lang/Throwable;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(cause);
			}
		}

		// Token: 0x0400007C RID: 124
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/google/android/datatransport/runtime/synchronization/SynchronizationException", typeof(SynchronizationException));
	}
}
