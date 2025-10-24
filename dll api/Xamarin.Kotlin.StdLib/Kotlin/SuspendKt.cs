using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Kotlin
{
	// Token: 0x020000A0 RID: 160
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlin/SuspendKt", DoNotGenerateAcw = true)]
	public sealed class SuspendKt : Java.Lang.Object
	{
		// Token: 0x170000F5 RID: 245
		// (get) Token: 0x0600045B RID: 1115 RVA: 0x0000A42C File Offset: 0x0000862C
		internal static IntPtr class_ref
		{
			get
			{
				return SuspendKt._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170000F6 RID: 246
		// (get) Token: 0x0600045C RID: 1116 RVA: 0x0000A450 File Offset: 0x00008650
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return SuspendKt._members;
			}
		}

		// Token: 0x170000F7 RID: 247
		// (get) Token: 0x0600045D RID: 1117 RVA: 0x0000A458 File Offset: 0x00008658
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return SuspendKt._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170000F8 RID: 248
		// (get) Token: 0x0600045E RID: 1118 RVA: 0x0000A47C File Offset: 0x0000867C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return SuspendKt._members.ManagedPeerType;
			}
		}

		// Token: 0x0600045F RID: 1119 RVA: 0x0000A488 File Offset: 0x00008688
		internal SuspendKt(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x04000155 RID: 341
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/SuspendKt", typeof(SuspendKt));
	}
}
