using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace AndroidX.Fragment.App.StrictMode
{
	// Token: 0x02000052 RID: 82
	[Register("androidx/fragment/app/strictmode/Violation", DoNotGenerateAcw = true)]
	public abstract class Violation : RuntimeException
	{
		// Token: 0x170000A4 RID: 164
		// (get) Token: 0x06000470 RID: 1136 RVA: 0x0000E750 File Offset: 0x0000C950
		internal static IntPtr class_ref
		{
			get
			{
				return Violation._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170000A5 RID: 165
		// (get) Token: 0x06000471 RID: 1137 RVA: 0x0000E774 File Offset: 0x0000C974
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return Violation._members;
			}
		}

		// Token: 0x170000A6 RID: 166
		// (get) Token: 0x06000472 RID: 1138 RVA: 0x0000E77C File Offset: 0x0000C97C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return Violation._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170000A7 RID: 167
		// (get) Token: 0x06000473 RID: 1139 RVA: 0x0000E7A0 File Offset: 0x0000C9A0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return Violation._members.ManagedPeerType;
			}
		}

		// Token: 0x06000474 RID: 1140 RVA: 0x0000E7AC File Offset: 0x0000C9AC
		protected Violation(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x170000A8 RID: 168
		// (get) Token: 0x06000475 RID: 1141 RVA: 0x0000E7B8 File Offset: 0x0000C9B8
		public Fragment Fragment
		{
			[Register("getFragment", "()Landroidx/fragment/app/Fragment;", "")]
			get
			{
				return Java.Lang.Object.GetObject<Fragment>(Violation._members.InstanceMethods.InvokeNonvirtualObjectMethod("getFragment.()Landroidx/fragment/app/Fragment;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x0400012F RID: 303
		private static readonly JniPeerMembers _members = new XAPeerMembers("androidx/fragment/app/strictmode/Violation", typeof(Violation));
	}
}
