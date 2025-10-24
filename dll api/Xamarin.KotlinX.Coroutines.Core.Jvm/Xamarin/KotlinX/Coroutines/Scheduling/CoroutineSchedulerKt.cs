using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Xamarin.KotlinX.Coroutines.Scheduling
{
	// Token: 0x020000A2 RID: 162
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlinx/coroutines/scheduling/CoroutineSchedulerKt", DoNotGenerateAcw = true)]
	public sealed class CoroutineSchedulerKt : Java.Lang.Object
	{
		// Token: 0x17000225 RID: 549
		// (get) Token: 0x06000714 RID: 1812 RVA: 0x00016CB0 File Offset: 0x00014EB0
		internal static IntPtr class_ref
		{
			get
			{
				return CoroutineSchedulerKt._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000226 RID: 550
		// (get) Token: 0x06000715 RID: 1813 RVA: 0x00016CD4 File Offset: 0x00014ED4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return CoroutineSchedulerKt._members;
			}
		}

		// Token: 0x17000227 RID: 551
		// (get) Token: 0x06000716 RID: 1814 RVA: 0x00016CDC File Offset: 0x00014EDC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return CoroutineSchedulerKt._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000228 RID: 552
		// (get) Token: 0x06000717 RID: 1815 RVA: 0x00016D00 File Offset: 0x00014F00
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return CoroutineSchedulerKt._members.ManagedPeerType;
			}
		}

		// Token: 0x06000718 RID: 1816 RVA: 0x00016D0C File Offset: 0x00014F0C
		internal CoroutineSchedulerKt(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x04000271 RID: 625
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlinx/coroutines/scheduling/CoroutineSchedulerKt", typeof(CoroutineSchedulerKt));
	}
}
