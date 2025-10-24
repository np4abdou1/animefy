using System;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using Android.Runtime;
using Java.Interop;
using Java.IO;

namespace Bumptech.Glide.Util
{
	// Token: 0x02000050 RID: 80
	[Register("com/bumptech/glide/util/MarkEnforcingInputStream", DoNotGenerateAcw = true)]
	public class MarkEnforcingInputStream : FilterInputStream
	{
		// Token: 0x17000087 RID: 135
		// (get) Token: 0x0600039A RID: 922 RVA: 0x0000C094 File Offset: 0x0000A294
		internal static IntPtr class_ref
		{
			get
			{
				return MarkEnforcingInputStream._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000088 RID: 136
		// (get) Token: 0x0600039B RID: 923 RVA: 0x0000C0B8 File Offset: 0x0000A2B8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return MarkEnforcingInputStream._members;
			}
		}

		// Token: 0x17000089 RID: 137
		// (get) Token: 0x0600039C RID: 924 RVA: 0x0000C0C0 File Offset: 0x0000A2C0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return MarkEnforcingInputStream._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700008A RID: 138
		// (get) Token: 0x0600039D RID: 925 RVA: 0x0000C0E4 File Offset: 0x0000A2E4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return MarkEnforcingInputStream._members.ManagedPeerType;
			}
		}

		// Token: 0x0600039E RID: 926 RVA: 0x0000C0F0 File Offset: 0x0000A2F0
		protected MarkEnforcingInputStream(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x0600039F RID: 927 RVA: 0x0000C0FC File Offset: 0x0000A2FC
		[Register(".ctor", "(Ljava/io/InputStream;)V", "")]
		public unsafe MarkEnforcingInputStream(Stream @in) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			IntPtr intPtr = InputStreamAdapter.ToLocalJniHandle(@in);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				base.SetHandle(MarkEnforcingInputStream._members.InstanceMethods.StartCreateInstance("(Ljava/io/InputStream;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				MarkEnforcingInputStream._members.InstanceMethods.FinishCreateInstance("(Ljava/io/InputStream;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(@in);
			}
		}

		// Token: 0x040000C8 RID: 200
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/bumptech/glide/util/MarkEnforcingInputStream", typeof(MarkEnforcingInputStream));
	}
}
