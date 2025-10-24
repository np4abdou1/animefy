using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Util;

namespace Xamarin.KotlinX.Coroutines.Channels
{
	// Token: 0x020000C7 RID: 199
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlinx/coroutines/channels/ClosedReceiveChannelException", DoNotGenerateAcw = true)]
	public sealed class ClosedReceiveChannelException : NoSuchElementException
	{
		// Token: 0x170002AC RID: 684
		// (get) Token: 0x060008F8 RID: 2296 RVA: 0x000211E8 File Offset: 0x0001F3E8
		internal static IntPtr class_ref
		{
			get
			{
				return ClosedReceiveChannelException._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170002AD RID: 685
		// (get) Token: 0x060008F9 RID: 2297 RVA: 0x0002120C File Offset: 0x0001F40C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return ClosedReceiveChannelException._members;
			}
		}

		// Token: 0x170002AE RID: 686
		// (get) Token: 0x060008FA RID: 2298 RVA: 0x00021214 File Offset: 0x0001F414
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return ClosedReceiveChannelException._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170002AF RID: 687
		// (get) Token: 0x060008FB RID: 2299 RVA: 0x00021238 File Offset: 0x0001F438
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return ClosedReceiveChannelException._members.ManagedPeerType;
			}
		}

		// Token: 0x060008FC RID: 2300 RVA: 0x00021244 File Offset: 0x0001F444
		internal ClosedReceiveChannelException(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x060008FD RID: 2301 RVA: 0x00021250 File Offset: 0x0001F450
		[NullableContext(2)]
		[Register(".ctor", "(Ljava/lang/String;)V", "")]
		public unsafe ClosedReceiveChannelException(string message) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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
				base.SetHandle(ClosedReceiveChannelException._members.InstanceMethods.StartCreateInstance("(Ljava/lang/String;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				ClosedReceiveChannelException._members.InstanceMethods.FinishCreateInstance("(Ljava/lang/String;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
		}

		// Token: 0x040002C6 RID: 710
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlinx/coroutines/channels/ClosedReceiveChannelException", typeof(ClosedReceiveChannelException));
	}
}
