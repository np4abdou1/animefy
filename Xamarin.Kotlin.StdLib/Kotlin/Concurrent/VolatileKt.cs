using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Kotlin.Concurrent
{
	// Token: 0x02000283 RID: 643
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlin/concurrent/VolatileKt", DoNotGenerateAcw = true)]
	public sealed class VolatileKt : Java.Lang.Object
	{
		// Token: 0x17000868 RID: 2152
		// (get) Token: 0x06001CDB RID: 7387 RVA: 0x0005F8F4 File Offset: 0x0005DAF4
		internal static IntPtr class_ref
		{
			get
			{
				return VolatileKt._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000869 RID: 2153
		// (get) Token: 0x06001CDC RID: 7388 RVA: 0x0005F918 File Offset: 0x0005DB18
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return VolatileKt._members;
			}
		}

		// Token: 0x1700086A RID: 2154
		// (get) Token: 0x06001CDD RID: 7389 RVA: 0x0005F920 File Offset: 0x0005DB20
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return VolatileKt._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700086B RID: 2155
		// (get) Token: 0x06001CDE RID: 7390 RVA: 0x0005F944 File Offset: 0x0005DB44
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return VolatileKt._members.ManagedPeerType;
			}
		}

		// Token: 0x06001CDF RID: 7391 RVA: 0x0005F950 File Offset: 0x0005DB50
		internal VolatileKt(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x040008DF RID: 2271
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/concurrent/VolatileKt", typeof(VolatileKt));
	}
}
