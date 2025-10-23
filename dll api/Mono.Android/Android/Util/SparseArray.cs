using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Android.Util
{
	// Token: 0x02000196 RID: 406
	[Register("android/util/SparseArray", DoNotGenerateAcw = true)]
	[JavaTypeParameters(new string[]
	{
		"E"
	})]
	public class SparseArray : Java.Lang.Object, Java.Lang.ICloneable, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x170002C8 RID: 712
		// (get) Token: 0x06000E47 RID: 3655 RVA: 0x00024A07 File Offset: 0x00022C07
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return SparseArray._members;
			}
		}

		// Token: 0x170002C9 RID: 713
		// (get) Token: 0x06000E48 RID: 3656 RVA: 0x00024A10 File Offset: 0x00022C10
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return SparseArray._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170002CA RID: 714
		// (get) Token: 0x06000E49 RID: 3657 RVA: 0x00024A34 File Offset: 0x00022C34
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return SparseArray._members.ManagedPeerType;
			}
		}

		// Token: 0x06000E4A RID: 3658 RVA: 0x000021E0 File Offset: 0x000003E0
		protected SparseArray(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x040006A5 RID: 1701
		private static readonly JniPeerMembers _members = new XAPeerMembers("android/util/SparseArray", typeof(SparseArray));
	}
}
