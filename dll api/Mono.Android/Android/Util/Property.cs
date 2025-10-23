using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Android.Util
{
	// Token: 0x02000194 RID: 404
	[Register("android/util/Property", DoNotGenerateAcw = true)]
	[JavaTypeParameters(new string[]
	{
		"T",
		"V"
	})]
	public abstract class Property : Java.Lang.Object
	{
		// Token: 0x170002C3 RID: 707
		// (get) Token: 0x06000E3E RID: 3646 RVA: 0x0002497B File Offset: 0x00022B7B
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return Property._members;
			}
		}

		// Token: 0x170002C4 RID: 708
		// (get) Token: 0x06000E3F RID: 3647 RVA: 0x00024984 File Offset: 0x00022B84
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return Property._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170002C5 RID: 709
		// (get) Token: 0x06000E40 RID: 3648 RVA: 0x000249A8 File Offset: 0x00022BA8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return Property._members.ManagedPeerType;
			}
		}

		// Token: 0x06000E41 RID: 3649 RVA: 0x000021E0 File Offset: 0x000003E0
		protected Property(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x040006A3 RID: 1699
		private static readonly JniPeerMembers _members = new XAPeerMembers("android/util/Property", typeof(Property));
	}
}
