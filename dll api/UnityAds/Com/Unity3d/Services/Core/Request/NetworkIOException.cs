using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Com.Unity3d.Services.Core.Request
{
	// Token: 0x020000AC RID: 172
	[Register("com/unity3d/services/core/request/NetworkIOException", DoNotGenerateAcw = true)]
	public class NetworkIOException : Java.Lang.Exception
	{
		// Token: 0x170001E8 RID: 488
		// (get) Token: 0x0600061A RID: 1562 RVA: 0x00011174 File Offset: 0x0000F374
		internal static IntPtr class_ref
		{
			get
			{
				return NetworkIOException._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170001E9 RID: 489
		// (get) Token: 0x0600061B RID: 1563 RVA: 0x00011198 File Offset: 0x0000F398
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return NetworkIOException._members;
			}
		}

		// Token: 0x170001EA RID: 490
		// (get) Token: 0x0600061C RID: 1564 RVA: 0x000111A0 File Offset: 0x0000F3A0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return NetworkIOException._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170001EB RID: 491
		// (get) Token: 0x0600061D RID: 1565 RVA: 0x000111C4 File Offset: 0x0000F3C4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return NetworkIOException._members.ManagedPeerType;
			}
		}

		// Token: 0x0600061E RID: 1566 RVA: 0x000111D0 File Offset: 0x0000F3D0
		protected NetworkIOException(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x0600061F RID: 1567 RVA: 0x000111DC File Offset: 0x0000F3DC
		[Register(".ctor", "(Ljava/lang/String;)V", "")]
		public unsafe NetworkIOException(string message) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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
				base.SetHandle(NetworkIOException._members.InstanceMethods.StartCreateInstance("(Ljava/lang/String;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				NetworkIOException._members.InstanceMethods.FinishCreateInstance("(Ljava/lang/String;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
		}

		// Token: 0x0400017C RID: 380
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/services/core/request/NetworkIOException", typeof(NetworkIOException));
	}
}
