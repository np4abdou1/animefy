using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Kotlin.Jvm.Internal.Unsafe
{
	// Token: 0x020001D3 RID: 467
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlin/jvm/internal/unsafe/MonitorKt", DoNotGenerateAcw = true)]
	public sealed class MonitorKt : Java.Lang.Object
	{
		// Token: 0x1700068D RID: 1677
		// (get) Token: 0x06001759 RID: 5977 RVA: 0x0004CFF4 File Offset: 0x0004B1F4
		internal static IntPtr class_ref
		{
			get
			{
				return MonitorKt._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700068E RID: 1678
		// (get) Token: 0x0600175A RID: 5978 RVA: 0x0004D018 File Offset: 0x0004B218
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return MonitorKt._members;
			}
		}

		// Token: 0x1700068F RID: 1679
		// (get) Token: 0x0600175B RID: 5979 RVA: 0x0004D020 File Offset: 0x0004B220
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return MonitorKt._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000690 RID: 1680
		// (get) Token: 0x0600175C RID: 5980 RVA: 0x0004D044 File Offset: 0x0004B244
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return MonitorKt._members.ManagedPeerType;
			}
		}

		// Token: 0x0600175D RID: 5981 RVA: 0x0004D050 File Offset: 0x0004B250
		internal MonitorKt(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x0400074A RID: 1866
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/jvm/internal/unsafe/MonitorKt", typeof(MonitorKt));
	}
}
