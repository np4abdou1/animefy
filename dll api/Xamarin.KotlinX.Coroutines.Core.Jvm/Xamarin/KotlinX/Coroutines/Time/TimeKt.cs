using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Xamarin.KotlinX.Coroutines.Time
{
	// Token: 0x02000087 RID: 135
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlinx/coroutines/time/TimeKt", DoNotGenerateAcw = true)]
	public sealed class TimeKt : Java.Lang.Object
	{
		// Token: 0x170001BD RID: 445
		// (get) Token: 0x060005FF RID: 1535 RVA: 0x00014168 File Offset: 0x00012368
		internal static IntPtr class_ref
		{
			get
			{
				return TimeKt._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170001BE RID: 446
		// (get) Token: 0x06000600 RID: 1536 RVA: 0x0001418C File Offset: 0x0001238C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return TimeKt._members;
			}
		}

		// Token: 0x170001BF RID: 447
		// (get) Token: 0x06000601 RID: 1537 RVA: 0x00014194 File Offset: 0x00012394
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return TimeKt._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170001C0 RID: 448
		// (get) Token: 0x06000602 RID: 1538 RVA: 0x000141B8 File Offset: 0x000123B8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return TimeKt._members.ManagedPeerType;
			}
		}

		// Token: 0x06000603 RID: 1539 RVA: 0x000141C4 File Offset: 0x000123C4
		internal TimeKt(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x04000210 RID: 528
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlinx/coroutines/time/TimeKt", typeof(TimeKt));
	}
}
