using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Java.Nio
{
	// Token: 0x02000374 RID: 884
	[Register("java/nio/ByteBuffer", DoNotGenerateAcw = true)]
	internal class ByteBufferInvoker : ByteBuffer, Java.Lang.IComparable, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x06002701 RID: 9985 RVA: 0x0006F39D File Offset: 0x0006D59D
		public ByteBufferInvoker(IntPtr handle, JniHandleOwnership transfer) : base(handle, transfer)
		{
		}

		// Token: 0x1700076A RID: 1898
		// (get) Token: 0x06002702 RID: 9986 RVA: 0x0006F3A7 File Offset: 0x0006D5A7
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return ByteBufferInvoker._members;
			}
		}

		// Token: 0x1700076B RID: 1899
		// (get) Token: 0x06002703 RID: 9987 RVA: 0x0006F3AE File Offset: 0x0006D5AE
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return ByteBufferInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x0400100D RID: 4109
		private static readonly JniPeerMembers _members = new XAPeerMembers("java/nio/ByteBuffer", typeof(ByteBufferInvoker));
	}
}
