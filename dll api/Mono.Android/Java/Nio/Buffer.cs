using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Java.Nio
{
	// Token: 0x02000371 RID: 881
	[Register("java/nio/Buffer", DoNotGenerateAcw = true)]
	public abstract class Buffer : Java.Lang.Object
	{
		// Token: 0x17000762 RID: 1890
		// (get) Token: 0x060026EF RID: 9967 RVA: 0x0006F201 File Offset: 0x0006D401
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return Buffer._members;
			}
		}

		// Token: 0x17000763 RID: 1891
		// (get) Token: 0x060026F0 RID: 9968 RVA: 0x0006F208 File Offset: 0x0006D408
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return Buffer._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000764 RID: 1892
		// (get) Token: 0x060026F1 RID: 9969 RVA: 0x0006F22C File Offset: 0x0006D42C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return Buffer._members.ManagedPeerType;
			}
		}

		// Token: 0x060026F2 RID: 9970 RVA: 0x000021E0 File Offset: 0x000003E0
		protected Buffer(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x04001009 RID: 4105
		private static readonly JniPeerMembers _members = new XAPeerMembers("java/nio/Buffer", typeof(Buffer));
	}
}
