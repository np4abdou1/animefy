using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Android.Graphics
{
	// Token: 0x0200021A RID: 538
	[Register("android/graphics/BlendMode", DoNotGenerateAcw = true, ApiSince = 29)]
	public sealed class BlendMode : Java.Lang.Enum
	{
		// Token: 0x17000410 RID: 1040
		// (get) Token: 0x06001337 RID: 4919 RVA: 0x0003241F File Offset: 0x0003061F
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return BlendMode._members;
			}
		}

		// Token: 0x17000411 RID: 1041
		// (get) Token: 0x06001338 RID: 4920 RVA: 0x00032428 File Offset: 0x00030628
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return BlendMode._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000412 RID: 1042
		// (get) Token: 0x06001339 RID: 4921 RVA: 0x0003244C File Offset: 0x0003064C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return BlendMode._members.ManagedPeerType;
			}
		}

		// Token: 0x0600133A RID: 4922 RVA: 0x00008BD0 File Offset: 0x00006DD0
		internal BlendMode(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x04000892 RID: 2194
		private static readonly JniPeerMembers _members = new XAPeerMembers("android/graphics/BlendMode", typeof(BlendMode));
	}
}
