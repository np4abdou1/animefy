using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;

namespace Android.Gms.Ads
{
	// Token: 0x0200000E RID: 14
	[Register("com/google/android/gms/ads/AdInspectorError", DoNotGenerateAcw = true)]
	public sealed class AdInspectorError : AdError
	{
		// Token: 0x17000015 RID: 21
		// (get) Token: 0x0600004F RID: 79 RVA: 0x000026E4 File Offset: 0x000008E4
		internal new static IntPtr class_ref
		{
			get
			{
				return AdInspectorError._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x06000050 RID: 80 RVA: 0x00002708 File Offset: 0x00000908
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return AdInspectorError._members;
			}
		}

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x06000051 RID: 81 RVA: 0x00002710 File Offset: 0x00000910
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return AdInspectorError._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x06000052 RID: 82 RVA: 0x00002734 File Offset: 0x00000934
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return AdInspectorError._members.ManagedPeerType;
			}
		}

		// Token: 0x06000053 RID: 83 RVA: 0x00002740 File Offset: 0x00000940
		internal AdInspectorError(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000054 RID: 84 RVA: 0x0000274C File Offset: 0x0000094C
		[Register(".ctor", "(ILjava/lang/String;Ljava/lang/String;)V", "")]
		public unsafe AdInspectorError(int code, string message, string domain) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			IntPtr intPtr = JNIEnv.NewString(message);
			IntPtr intPtr2 = JNIEnv.NewString(domain);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(code);
				ptr[1] = new JniArgumentValue(intPtr);
				ptr[2] = new JniArgumentValue(intPtr2);
				base.SetHandle(AdInspectorError._members.InstanceMethods.StartCreateInstance("(ILjava/lang/String;Ljava/lang/String;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				AdInspectorError._members.InstanceMethods.FinishCreateInstance("(ILjava/lang/String;Ljava/lang/String;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				JNIEnv.DeleteLocalRef(intPtr2);
			}
		}

		// Token: 0x04000008 RID: 8
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/google/android/gms/ads/AdInspectorError", typeof(AdInspectorError));
	}
}
