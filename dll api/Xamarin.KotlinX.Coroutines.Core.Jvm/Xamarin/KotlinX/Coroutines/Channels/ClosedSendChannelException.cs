using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Xamarin.KotlinX.Coroutines.Channels
{
	// Token: 0x020000C8 RID: 200
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlinx/coroutines/channels/ClosedSendChannelException", DoNotGenerateAcw = true)]
	public sealed class ClosedSendChannelException : IllegalStateException
	{
		// Token: 0x170002B0 RID: 688
		// (get) Token: 0x060008FF RID: 2303 RVA: 0x00021310 File Offset: 0x0001F510
		internal static IntPtr class_ref
		{
			get
			{
				return ClosedSendChannelException._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170002B1 RID: 689
		// (get) Token: 0x06000900 RID: 2304 RVA: 0x00021334 File Offset: 0x0001F534
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return ClosedSendChannelException._members;
			}
		}

		// Token: 0x170002B2 RID: 690
		// (get) Token: 0x06000901 RID: 2305 RVA: 0x0002133C File Offset: 0x0001F53C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return ClosedSendChannelException._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170002B3 RID: 691
		// (get) Token: 0x06000902 RID: 2306 RVA: 0x00021360 File Offset: 0x0001F560
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return ClosedSendChannelException._members.ManagedPeerType;
			}
		}

		// Token: 0x06000903 RID: 2307 RVA: 0x0002136C File Offset: 0x0001F56C
		internal ClosedSendChannelException(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000904 RID: 2308 RVA: 0x00021378 File Offset: 0x0001F578
		[NullableContext(2)]
		[Register(".ctor", "(Ljava/lang/String;)V", "")]
		public unsafe ClosedSendChannelException(string message) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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
				base.SetHandle(ClosedSendChannelException._members.InstanceMethods.StartCreateInstance("(Ljava/lang/String;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				ClosedSendChannelException._members.InstanceMethods.FinishCreateInstance("(Ljava/lang/String;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
		}

		// Token: 0x040002C7 RID: 711
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlinx/coroutines/channels/ClosedSendChannelException", typeof(ClosedSendChannelException));
	}
}
