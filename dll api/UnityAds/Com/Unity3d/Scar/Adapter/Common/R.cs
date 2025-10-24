using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Com.Unity3d.Scar.Adapter.Common
{
	// Token: 0x020002A5 RID: 677
	[Register("com/unity3d/scar/adapter/common/R", DoNotGenerateAcw = true)]
	public sealed class R : Java.Lang.Object
	{
		// Token: 0x17000EB8 RID: 3768
		// (get) Token: 0x060026C0 RID: 9920 RVA: 0x00063C10 File Offset: 0x00061E10
		internal static IntPtr class_ref
		{
			get
			{
				return R._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000EB9 RID: 3769
		// (get) Token: 0x060026C1 RID: 9921 RVA: 0x00063C34 File Offset: 0x00061E34
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return R._members;
			}
		}

		// Token: 0x17000EBA RID: 3770
		// (get) Token: 0x060026C2 RID: 9922 RVA: 0x00063C3C File Offset: 0x00061E3C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return R._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000EBB RID: 3771
		// (get) Token: 0x060026C3 RID: 9923 RVA: 0x00063C60 File Offset: 0x00061E60
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return R._members.ManagedPeerType;
			}
		}

		// Token: 0x060026C4 RID: 9924 RVA: 0x000021E8 File Offset: 0x000003E8
		internal R(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x040007AE RID: 1966
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/scar/adapter/common/R", typeof(R));
	}
}
