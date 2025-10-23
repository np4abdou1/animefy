using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Kotlin
{
	// Token: 0x0200009D RID: 157
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlin/StandardKt", DoNotGenerateAcw = true)]
	public sealed class StandardKt : Java.Lang.Object
	{
		// Token: 0x170000EF RID: 239
		// (get) Token: 0x0600044F RID: 1103 RVA: 0x0000A378 File Offset: 0x00008578
		internal static IntPtr class_ref
		{
			get
			{
				return StandardKt._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170000F0 RID: 240
		// (get) Token: 0x06000450 RID: 1104 RVA: 0x0000A39C File Offset: 0x0000859C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return StandardKt._members;
			}
		}

		// Token: 0x170000F1 RID: 241
		// (get) Token: 0x06000451 RID: 1105 RVA: 0x0000A3A4 File Offset: 0x000085A4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return StandardKt._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170000F2 RID: 242
		// (get) Token: 0x06000452 RID: 1106 RVA: 0x0000A3C8 File Offset: 0x000085C8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return StandardKt._members.ManagedPeerType;
			}
		}

		// Token: 0x06000453 RID: 1107 RVA: 0x0000A3D4 File Offset: 0x000085D4
		internal StandardKt(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x04000152 RID: 338
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/StandardKt", typeof(StandardKt));
	}
}
