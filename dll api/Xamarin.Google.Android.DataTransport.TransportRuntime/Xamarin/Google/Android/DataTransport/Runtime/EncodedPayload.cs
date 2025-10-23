using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Xamarin.Google.Android.DataTransport.Runtime
{
	// Token: 0x0200001B RID: 27
	[Register("com/google/android/datatransport/runtime/EncodedPayload", DoNotGenerateAcw = true)]
	public sealed class EncodedPayload : Java.Lang.Object
	{
		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000070 RID: 112 RVA: 0x0000275C File Offset: 0x0000095C
		internal static IntPtr class_ref
		{
			get
			{
				return EncodedPayload._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x06000071 RID: 113 RVA: 0x00002780 File Offset: 0x00000980
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return EncodedPayload._members;
			}
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x06000072 RID: 114 RVA: 0x00002788 File Offset: 0x00000988
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return EncodedPayload._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x06000073 RID: 115 RVA: 0x000027AC File Offset: 0x000009AC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return EncodedPayload._members.ManagedPeerType;
			}
		}

		// Token: 0x06000074 RID: 116 RVA: 0x000026C4 File Offset: 0x000008C4
		internal EncodedPayload(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000075 RID: 117 RVA: 0x000027B8 File Offset: 0x000009B8
		[Register(".ctor", "(Lcom/google/android/datatransport/Encoding;[B)V", "")]
		public unsafe EncodedPayload(Encoding encoding, byte[] bytes) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			IntPtr intPtr = JNIEnv.NewArray(bytes);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((encoding == null) ? IntPtr.Zero : encoding.Handle);
				ptr[1] = new JniArgumentValue(intPtr);
				base.SetHandle(EncodedPayload._members.InstanceMethods.StartCreateInstance("(Lcom/google/android/datatransport/Encoding;[B)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				EncodedPayload._members.InstanceMethods.FinishCreateInstance("(Lcom/google/android/datatransport/Encoding;[B)V", this, ptr);
			}
			finally
			{
				if (bytes != null)
				{
					JNIEnv.CopyArray(intPtr, bytes);
					JNIEnv.DeleteLocalRef(intPtr);
				}
				GC.KeepAlive(encoding);
				GC.KeepAlive(bytes);
			}
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x06000076 RID: 118 RVA: 0x00002894 File Offset: 0x00000A94
		public Encoding Encoding
		{
			[Register("getEncoding", "()Lcom/google/android/datatransport/Encoding;", "")]
			get
			{
				return Java.Lang.Object.GetObject<Encoding>(EncodedPayload._members.InstanceMethods.InvokeAbstractObjectMethod("getEncoding.()Lcom/google/android/datatransport/Encoding;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06000077 RID: 119 RVA: 0x000028C8 File Offset: 0x00000AC8
		[Register("getBytes", "()[B", "")]
		public byte[] GetBytes()
		{
			return (byte[])JNIEnv.GetArray(EncodedPayload._members.InstanceMethods.InvokeAbstractObjectMethod("getBytes.()[B", this, null).Handle, JniHandleOwnership.TransferLocalRef, typeof(byte));
		}

		// Token: 0x04000012 RID: 18
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/google/android/datatransport/runtime/EncodedPayload", typeof(EncodedPayload));
	}
}
