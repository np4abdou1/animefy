using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Xamarin.KotlinX.Coroutines.Intrinsics
{
	// Token: 0x020000A6 RID: 166
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlinx/coroutines/intrinsics/UndispatchedKt", DoNotGenerateAcw = true)]
	public sealed class UndispatchedKt : Java.Lang.Object
	{
		// Token: 0x17000235 RID: 565
		// (get) Token: 0x0600072F RID: 1839 RVA: 0x0001701C File Offset: 0x0001521C
		internal static IntPtr class_ref
		{
			get
			{
				return UndispatchedKt._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000236 RID: 566
		// (get) Token: 0x06000730 RID: 1840 RVA: 0x00017040 File Offset: 0x00015240
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return UndispatchedKt._members;
			}
		}

		// Token: 0x17000237 RID: 567
		// (get) Token: 0x06000731 RID: 1841 RVA: 0x00017048 File Offset: 0x00015248
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return UndispatchedKt._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000238 RID: 568
		// (get) Token: 0x06000732 RID: 1842 RVA: 0x0001706C File Offset: 0x0001526C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return UndispatchedKt._members.ManagedPeerType;
			}
		}

		// Token: 0x06000733 RID: 1843 RVA: 0x00017078 File Offset: 0x00015278
		internal UndispatchedKt(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x04000275 RID: 629
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlinx/coroutines/intrinsics/UndispatchedKt", typeof(UndispatchedKt));
	}
}
