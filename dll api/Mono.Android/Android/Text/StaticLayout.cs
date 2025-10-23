using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Android.Text
{
	// Token: 0x020001B8 RID: 440
	[Register("android/text/StaticLayout", DoNotGenerateAcw = true)]
	public class StaticLayout : Layout
	{
		// Token: 0x17000316 RID: 790
		// (get) Token: 0x0600100C RID: 4108 RVA: 0x0002A17E File Offset: 0x0002837E
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return StaticLayout._members;
			}
		}

		// Token: 0x17000317 RID: 791
		// (get) Token: 0x0600100D RID: 4109 RVA: 0x0002A188 File Offset: 0x00028388
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return StaticLayout._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000318 RID: 792
		// (get) Token: 0x0600100E RID: 4110 RVA: 0x0002A1AC File Offset: 0x000283AC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return StaticLayout._members.ManagedPeerType;
			}
		}

		// Token: 0x0600100F RID: 4111 RVA: 0x0002791E File Offset: 0x00025B1E
		protected StaticLayout(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x04000757 RID: 1879
		private static readonly JniPeerMembers _members = new XAPeerMembers("android/text/StaticLayout", typeof(StaticLayout));

		// Token: 0x020001B9 RID: 441
		[Register("android/text/StaticLayout$Builder", DoNotGenerateAcw = true, ApiSince = 23)]
		public sealed class Builder : Java.Lang.Object
		{
			// Token: 0x17000319 RID: 793
			// (get) Token: 0x06001011 RID: 4113 RVA: 0x0002A1D3 File Offset: 0x000283D3
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override JniPeerMembers JniPeerMembers
			{
				get
				{
					return StaticLayout.Builder._members;
				}
			}

			// Token: 0x1700031A RID: 794
			// (get) Token: 0x06001012 RID: 4114 RVA: 0x0002A1DC File Offset: 0x000283DC
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass
			{
				get
				{
					return StaticLayout.Builder._members.JniPeerType.PeerReference.Handle;
				}
			}

			// Token: 0x1700031B RID: 795
			// (get) Token: 0x06001013 RID: 4115 RVA: 0x0002A200 File Offset: 0x00028400
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			protected override Type ThresholdType
			{
				get
				{
					return StaticLayout.Builder._members.ManagedPeerType;
				}
			}

			// Token: 0x06001014 RID: 4116 RVA: 0x000021E0 File Offset: 0x000003E0
			internal Builder(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
			{
			}

			// Token: 0x04000758 RID: 1880
			private static readonly JniPeerMembers _members = new XAPeerMembers("android/text/StaticLayout$Builder", typeof(StaticLayout.Builder));
		}
	}
}
