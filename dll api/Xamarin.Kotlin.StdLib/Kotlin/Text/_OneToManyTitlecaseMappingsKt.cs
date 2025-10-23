using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Kotlin.Text
{
	// Token: 0x020000F1 RID: 241
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlin/text/_OneToManyTitlecaseMappingsKt", DoNotGenerateAcw = true)]
	public sealed class _OneToManyTitlecaseMappingsKt : Java.Lang.Object
	{
		// Token: 0x1700028E RID: 654
		// (get) Token: 0x060009E7 RID: 2535 RVA: 0x000217C4 File Offset: 0x0001F9C4
		internal static IntPtr class_ref
		{
			get
			{
				return _OneToManyTitlecaseMappingsKt._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700028F RID: 655
		// (get) Token: 0x060009E8 RID: 2536 RVA: 0x000217E8 File Offset: 0x0001F9E8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return _OneToManyTitlecaseMappingsKt._members;
			}
		}

		// Token: 0x17000290 RID: 656
		// (get) Token: 0x060009E9 RID: 2537 RVA: 0x000217F0 File Offset: 0x0001F9F0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return _OneToManyTitlecaseMappingsKt._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000291 RID: 657
		// (get) Token: 0x060009EA RID: 2538 RVA: 0x00021814 File Offset: 0x0001FA14
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return _OneToManyTitlecaseMappingsKt._members.ManagedPeerType;
			}
		}

		// Token: 0x060009EB RID: 2539 RVA: 0x00021820 File Offset: 0x0001FA20
		internal _OneToManyTitlecaseMappingsKt(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x04000259 RID: 601
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/text/_OneToManyTitlecaseMappingsKt", typeof(_OneToManyTitlecaseMappingsKt));
	}
}
