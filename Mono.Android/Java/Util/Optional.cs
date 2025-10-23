using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Java.Util
{
	// Token: 0x02000324 RID: 804
	[Register("java/util/Optional", DoNotGenerateAcw = true, ApiSince = 24)]
	[JavaTypeParameters(new string[]
	{
		"T"
	})]
	public sealed class Optional : Java.Lang.Object
	{
		// Token: 0x17000696 RID: 1686
		// (get) Token: 0x06002234 RID: 8756 RVA: 0x0006094F File Offset: 0x0005EB4F
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return Optional._members;
			}
		}

		// Token: 0x17000697 RID: 1687
		// (get) Token: 0x06002235 RID: 8757 RVA: 0x00060958 File Offset: 0x0005EB58
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return Optional._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000698 RID: 1688
		// (get) Token: 0x06002236 RID: 8758 RVA: 0x0006097C File Offset: 0x0005EB7C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return Optional._members.ManagedPeerType;
			}
		}

		// Token: 0x06002237 RID: 8759 RVA: 0x000021E0 File Offset: 0x000003E0
		internal Optional(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x04000E1B RID: 3611
		private static readonly JniPeerMembers _members = new XAPeerMembers("java/util/Optional", typeof(Optional));
	}
}
