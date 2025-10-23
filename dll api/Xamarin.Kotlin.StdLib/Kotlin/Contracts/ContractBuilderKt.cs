using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Kotlin.Contracts
{
	// Token: 0x0200026C RID: 620
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlin/contracts/ContractBuilderKt", DoNotGenerateAcw = true)]
	public sealed class ContractBuilderKt : Java.Lang.Object
	{
		// Token: 0x1700082B RID: 2091
		// (get) Token: 0x06001C40 RID: 7232 RVA: 0x0005E45C File Offset: 0x0005C65C
		internal static IntPtr class_ref
		{
			get
			{
				return ContractBuilderKt._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700082C RID: 2092
		// (get) Token: 0x06001C41 RID: 7233 RVA: 0x0005E480 File Offset: 0x0005C680
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return ContractBuilderKt._members;
			}
		}

		// Token: 0x1700082D RID: 2093
		// (get) Token: 0x06001C42 RID: 7234 RVA: 0x0005E488 File Offset: 0x0005C688
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return ContractBuilderKt._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700082E RID: 2094
		// (get) Token: 0x06001C43 RID: 7235 RVA: 0x0005E4AC File Offset: 0x0005C6AC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return ContractBuilderKt._members.ManagedPeerType;
			}
		}

		// Token: 0x06001C44 RID: 7236 RVA: 0x0005E4B8 File Offset: 0x0005C6B8
		internal ContractBuilderKt(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x040008B3 RID: 2227
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/contracts/ContractBuilderKt", typeof(ContractBuilderKt));
	}
}
