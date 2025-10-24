using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Android.Util
{
	// Token: 0x02000197 RID: 407
	[Register("android/util/SparseIntArray", DoNotGenerateAcw = true)]
	public class SparseIntArray : Java.Lang.Object, Java.Lang.ICloneable, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x170002CB RID: 715
		// (get) Token: 0x06000E4C RID: 3660 RVA: 0x00024A5B File Offset: 0x00022C5B
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return SparseIntArray._members;
			}
		}

		// Token: 0x170002CC RID: 716
		// (get) Token: 0x06000E4D RID: 3661 RVA: 0x00024A64 File Offset: 0x00022C64
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return SparseIntArray._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170002CD RID: 717
		// (get) Token: 0x06000E4E RID: 3662 RVA: 0x00024A88 File Offset: 0x00022C88
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return SparseIntArray._members.ManagedPeerType;
			}
		}

		// Token: 0x06000E4F RID: 3663 RVA: 0x000021E0 File Offset: 0x000003E0
		protected SparseIntArray(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x040006A6 RID: 1702
		private static readonly JniPeerMembers _members = new XAPeerMembers("android/util/SparseIntArray", typeof(SparseIntArray));
	}
}
