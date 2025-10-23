using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Kotlin.Coroutines.Jvm.Internal
{
	// Token: 0x02000269 RID: 617
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlin/coroutines/jvm/internal/RunSuspendKt", DoNotGenerateAcw = true)]
	public sealed class RunSuspendKt : Java.Lang.Object
	{
		// Token: 0x1700081E RID: 2078
		// (get) Token: 0x06001C27 RID: 7207 RVA: 0x0005DE44 File Offset: 0x0005C044
		internal static IntPtr class_ref
		{
			get
			{
				return RunSuspendKt._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700081F RID: 2079
		// (get) Token: 0x06001C28 RID: 7208 RVA: 0x0005DE68 File Offset: 0x0005C068
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return RunSuspendKt._members;
			}
		}

		// Token: 0x17000820 RID: 2080
		// (get) Token: 0x06001C29 RID: 7209 RVA: 0x0005DE70 File Offset: 0x0005C070
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return RunSuspendKt._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000821 RID: 2081
		// (get) Token: 0x06001C2A RID: 7210 RVA: 0x0005DE94 File Offset: 0x0005C094
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return RunSuspendKt._members.ManagedPeerType;
			}
		}

		// Token: 0x06001C2B RID: 7211 RVA: 0x0005DEA0 File Offset: 0x0005C0A0
		internal RunSuspendKt(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x040008B0 RID: 2224
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/coroutines/jvm/internal/RunSuspendKt", typeof(RunSuspendKt));
	}
}
