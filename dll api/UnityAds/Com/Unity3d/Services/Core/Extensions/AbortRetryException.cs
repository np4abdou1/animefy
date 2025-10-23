using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Com.Unity3d.Services.Core.Extensions
{
	// Token: 0x020000FB RID: 251
	[Register("com/unity3d/services/core/extensions/AbortRetryException", DoNotGenerateAcw = true)]
	public sealed class AbortRetryException : Java.Lang.Exception
	{
		// Token: 0x17000324 RID: 804
		// (get) Token: 0x06000A01 RID: 2561 RVA: 0x0001D284 File Offset: 0x0001B484
		internal static IntPtr class_ref
		{
			get
			{
				return AbortRetryException._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000325 RID: 805
		// (get) Token: 0x06000A02 RID: 2562 RVA: 0x0001D2A8 File Offset: 0x0001B4A8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return AbortRetryException._members;
			}
		}

		// Token: 0x17000326 RID: 806
		// (get) Token: 0x06000A03 RID: 2563 RVA: 0x0001D2B0 File Offset: 0x0001B4B0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return AbortRetryException._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000327 RID: 807
		// (get) Token: 0x06000A04 RID: 2564 RVA: 0x0001D2D4 File Offset: 0x0001B4D4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return AbortRetryException._members.ManagedPeerType;
			}
		}

		// Token: 0x06000A05 RID: 2565 RVA: 0x000111D0 File Offset: 0x0000F3D0
		internal AbortRetryException(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000A06 RID: 2566 RVA: 0x0001D2E0 File Offset: 0x0001B4E0
		[Register(".ctor", "(Ljava/lang/String;)V", "")]
		public unsafe AbortRetryException(string reason) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			IntPtr intPtr = JNIEnv.NewString(reason);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				base.SetHandle(AbortRetryException._members.InstanceMethods.StartCreateInstance("(Ljava/lang/String;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				AbortRetryException._members.InstanceMethods.FinishCreateInstance("(Ljava/lang/String;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
		}

		// Token: 0x04000261 RID: 609
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/services/core/extensions/AbortRetryException", typeof(AbortRetryException));
	}
}
