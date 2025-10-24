using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Xamarin.KotlinX.Coroutines
{
	// Token: 0x02000022 RID: 34
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlinx/coroutines/CompletionStateKt", DoNotGenerateAcw = true)]
	public sealed class CompletionStateKt : Java.Lang.Object
	{
		// Token: 0x17000029 RID: 41
		// (get) Token: 0x06000097 RID: 151 RVA: 0x0000309C File Offset: 0x0000129C
		internal static IntPtr class_ref
		{
			get
			{
				return CompletionStateKt._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x06000098 RID: 152 RVA: 0x000030C0 File Offset: 0x000012C0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return CompletionStateKt._members;
			}
		}

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x06000099 RID: 153 RVA: 0x000030C8 File Offset: 0x000012C8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return CompletionStateKt._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x0600009A RID: 154 RVA: 0x000030EC File Offset: 0x000012EC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return CompletionStateKt._members.ManagedPeerType;
			}
		}

		// Token: 0x0600009B RID: 155 RVA: 0x000030F8 File Offset: 0x000012F8
		internal CompletionStateKt(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x0400000E RID: 14
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlinx/coroutines/CompletionStateKt", typeof(CompletionStateKt));
	}
}
