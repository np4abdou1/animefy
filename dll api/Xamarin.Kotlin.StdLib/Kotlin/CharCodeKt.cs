using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Kotlin
{
	// Token: 0x02000043 RID: 67
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlin/CharCodeKt", DoNotGenerateAcw = true)]
	public sealed class CharCodeKt : Java.Lang.Object
	{
		// Token: 0x17000009 RID: 9
		// (get) Token: 0x06000101 RID: 257 RVA: 0x00002650 File Offset: 0x00000850
		internal static IntPtr class_ref
		{
			get
			{
				return CharCodeKt._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x06000102 RID: 258 RVA: 0x00002674 File Offset: 0x00000874
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return CharCodeKt._members;
			}
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x06000103 RID: 259 RVA: 0x0000267C File Offset: 0x0000087C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return CharCodeKt._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x06000104 RID: 260 RVA: 0x000026A0 File Offset: 0x000008A0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return CharCodeKt._members.ManagedPeerType;
			}
		}

		// Token: 0x06000105 RID: 261 RVA: 0x000026AC File Offset: 0x000008AC
		internal CharCodeKt(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x04000010 RID: 16
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/CharCodeKt", typeof(CharCodeKt));
	}
}
