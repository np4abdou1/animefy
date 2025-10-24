using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Kotlin.IO.Path
{
	// Token: 0x02000233 RID: 563
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlin/io/path/PathTreeWalkKt", DoNotGenerateAcw = true)]
	public sealed class PathTreeWalkKt : Java.Lang.Object
	{
		// Token: 0x17000783 RID: 1923
		// (get) Token: 0x06001A1F RID: 6687 RVA: 0x00057FE4 File Offset: 0x000561E4
		internal static IntPtr class_ref
		{
			get
			{
				return PathTreeWalkKt._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000784 RID: 1924
		// (get) Token: 0x06001A20 RID: 6688 RVA: 0x00058008 File Offset: 0x00056208
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return PathTreeWalkKt._members;
			}
		}

		// Token: 0x17000785 RID: 1925
		// (get) Token: 0x06001A21 RID: 6689 RVA: 0x00058010 File Offset: 0x00056210
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return PathTreeWalkKt._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000786 RID: 1926
		// (get) Token: 0x06001A22 RID: 6690 RVA: 0x00058034 File Offset: 0x00056234
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return PathTreeWalkKt._members.ManagedPeerType;
			}
		}

		// Token: 0x06001A23 RID: 6691 RVA: 0x00058040 File Offset: 0x00056240
		internal PathTreeWalkKt(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x040007F5 RID: 2037
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/io/path/PathTreeWalkKt", typeof(PathTreeWalkKt));
	}
}
