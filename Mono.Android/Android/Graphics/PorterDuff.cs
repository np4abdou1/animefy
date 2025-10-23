using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Android.Graphics
{
	// Token: 0x0200022A RID: 554
	[Register("android/graphics/PorterDuff", DoNotGenerateAcw = true)]
	public class PorterDuff : Java.Lang.Object
	{
		// Token: 0x1700043E RID: 1086
		// (get) Token: 0x06001399 RID: 5017 RVA: 0x00032E03 File Offset: 0x00031003
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return PorterDuff._members;
			}
		}

		// Token: 0x1700043F RID: 1087
		// (get) Token: 0x0600139A RID: 5018 RVA: 0x00032E0C File Offset: 0x0003100C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return PorterDuff._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000440 RID: 1088
		// (get) Token: 0x0600139B RID: 5019 RVA: 0x00032E30 File Offset: 0x00031030
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return PorterDuff._members.ManagedPeerType;
			}
		}

		// Token: 0x0600139C RID: 5020 RVA: 0x000021E0 File Offset: 0x000003E0
		protected PorterDuff(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x040008A8 RID: 2216
		private static readonly JniPeerMembers _members = new XAPeerMembers("android/graphics/PorterDuff", typeof(PorterDuff));

		// Token: 0x0200022B RID: 555
		[Register("android/graphics/PorterDuff$Mode", DoNotGenerateAcw = true)]
		public sealed class Mode : Java.Lang.Enum
		{
			// Token: 0x17000441 RID: 1089
			// (get) Token: 0x0600139E RID: 5022 RVA: 0x00032E57 File Offset: 0x00031057
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return PorterDuff.Mode._members;
				}
			}

			// Token: 0x17000442 RID: 1090
			// (get) Token: 0x0600139F RID: 5023 RVA: 0x00032E60 File Offset: 0x00031060
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return PorterDuff.Mode._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x17000443 RID: 1091
			// (get) Token: 0x060013A0 RID: 5024 RVA: 0x00032E84 File Offset: 0x00031084
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return PorterDuff.Mode._members.ManagedPeerType;
				}
			}

			// Token: 0x060013A1 RID: 5025 RVA: 0x00008BD0 File Offset: 0x00006DD0
			internal Mode(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
			{
			}

			// Token: 0x040008A9 RID: 2217
			private static readonly JniPeerMembers _members = new XAPeerMembers("android/graphics/PorterDuff$Mode", typeof(PorterDuff.Mode));
		}
	}
}
