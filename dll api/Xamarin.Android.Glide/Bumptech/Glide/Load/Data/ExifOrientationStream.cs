using System;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using Android.Runtime;
using Java.Interop;
using Java.IO;

namespace Bumptech.Glide.Load.Data
{
	// Token: 0x0200018F RID: 399
	[Register("com/bumptech/glide/load/data/ExifOrientationStream", DoNotGenerateAcw = true)]
	public sealed class ExifOrientationStream : FilterInputStream
	{
		// Token: 0x17000551 RID: 1361
		// (get) Token: 0x06001433 RID: 5171 RVA: 0x00040A1C File Offset: 0x0003EC1C
		internal static IntPtr class_ref
		{
			get
			{
				return ExifOrientationStream._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000552 RID: 1362
		// (get) Token: 0x06001434 RID: 5172 RVA: 0x00040A40 File Offset: 0x0003EC40
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return ExifOrientationStream._members;
			}
		}

		// Token: 0x17000553 RID: 1363
		// (get) Token: 0x06001435 RID: 5173 RVA: 0x00040A48 File Offset: 0x0003EC48
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return ExifOrientationStream._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000554 RID: 1364
		// (get) Token: 0x06001436 RID: 5174 RVA: 0x00040A6C File Offset: 0x0003EC6C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return ExifOrientationStream._members.ManagedPeerType;
			}
		}

		// Token: 0x06001437 RID: 5175 RVA: 0x00040A78 File Offset: 0x0003EC78
		internal ExifOrientationStream(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06001438 RID: 5176 RVA: 0x00040A84 File Offset: 0x0003EC84
		[Register(".ctor", "(Ljava/io/InputStream;I)V", "")]
		public unsafe ExifOrientationStream(Stream @in, int orientation) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			IntPtr intPtr = InputStreamAdapter.ToLocalJniHandle(@in);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(orientation);
				base.SetHandle(ExifOrientationStream._members.InstanceMethods.StartCreateInstance("(Ljava/io/InputStream;I)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				ExifOrientationStream._members.InstanceMethods.FinishCreateInstance("(Ljava/io/InputStream;I)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(@in);
			}
		}

		// Token: 0x040004C4 RID: 1220
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/bumptech/glide/load/data/ExifOrientationStream", typeof(ExifOrientationStream));
	}
}
