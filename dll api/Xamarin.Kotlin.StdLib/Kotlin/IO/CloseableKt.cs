using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Kotlin.IO
{
	// Token: 0x0200021C RID: 540
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlin/io/CloseableKt", DoNotGenerateAcw = true)]
	public sealed class CloseableKt : Java.Lang.Object
	{
		// Token: 0x17000727 RID: 1831
		// (get) Token: 0x06001919 RID: 6425 RVA: 0x00053930 File Offset: 0x00051B30
		internal static IntPtr class_ref
		{
			get
			{
				return CloseableKt._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000728 RID: 1832
		// (get) Token: 0x0600191A RID: 6426 RVA: 0x00053954 File Offset: 0x00051B54
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return CloseableKt._members;
			}
		}

		// Token: 0x17000729 RID: 1833
		// (get) Token: 0x0600191B RID: 6427 RVA: 0x0005395C File Offset: 0x00051B5C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return CloseableKt._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700072A RID: 1834
		// (get) Token: 0x0600191C RID: 6428 RVA: 0x00053980 File Offset: 0x00051B80
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return CloseableKt._members.ManagedPeerType;
			}
		}

		// Token: 0x0600191D RID: 6429 RVA: 0x0005398C File Offset: 0x00051B8C
		internal CloseableKt(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x040007CC RID: 1996
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/io/CloseableKt", typeof(CloseableKt));
	}
}
