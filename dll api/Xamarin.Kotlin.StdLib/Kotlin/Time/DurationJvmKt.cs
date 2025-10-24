using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Kotlin.Time
{
	// Token: 0x020000C0 RID: 192
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlin/time/DurationJvmKt", DoNotGenerateAcw = true)]
	public sealed class DurationJvmKt : Java.Lang.Object
	{
		// Token: 0x1700017C RID: 380
		// (get) Token: 0x0600058F RID: 1423 RVA: 0x0000DC48 File Offset: 0x0000BE48
		internal static IntPtr class_ref
		{
			get
			{
				return DurationJvmKt._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700017D RID: 381
		// (get) Token: 0x06000590 RID: 1424 RVA: 0x0000DC6C File Offset: 0x0000BE6C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return DurationJvmKt._members;
			}
		}

		// Token: 0x1700017E RID: 382
		// (get) Token: 0x06000591 RID: 1425 RVA: 0x0000DC74 File Offset: 0x0000BE74
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return DurationJvmKt._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700017F RID: 383
		// (get) Token: 0x06000592 RID: 1426 RVA: 0x0000DC98 File Offset: 0x0000BE98
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return DurationJvmKt._members.ManagedPeerType;
			}
		}

		// Token: 0x06000593 RID: 1427 RVA: 0x0000DCA4 File Offset: 0x0000BEA4
		internal DurationJvmKt(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x04000188 RID: 392
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/time/DurationJvmKt", typeof(DurationJvmKt));
	}
}
