using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Kotlin
{
	// Token: 0x020000B1 RID: 177
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlin/ULongKt", DoNotGenerateAcw = true)]
	public sealed class ULongKt : Java.Lang.Object
	{
		// Token: 0x17000142 RID: 322
		// (get) Token: 0x06000507 RID: 1287 RVA: 0x0000C584 File Offset: 0x0000A784
		internal static IntPtr class_ref
		{
			get
			{
				return ULongKt._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000143 RID: 323
		// (get) Token: 0x06000508 RID: 1288 RVA: 0x0000C5A8 File Offset: 0x0000A7A8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return ULongKt._members;
			}
		}

		// Token: 0x17000144 RID: 324
		// (get) Token: 0x06000509 RID: 1289 RVA: 0x0000C5B0 File Offset: 0x0000A7B0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return ULongKt._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000145 RID: 325
		// (get) Token: 0x0600050A RID: 1290 RVA: 0x0000C5D4 File Offset: 0x0000A7D4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return ULongKt._members.ManagedPeerType;
			}
		}

		// Token: 0x0600050B RID: 1291 RVA: 0x0000C5E0 File Offset: 0x0000A7E0
		internal ULongKt(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x04000172 RID: 370
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/ULongKt", typeof(ULongKt));
	}
}
