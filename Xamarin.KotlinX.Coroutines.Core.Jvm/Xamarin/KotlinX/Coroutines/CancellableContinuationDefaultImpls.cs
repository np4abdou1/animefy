using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Xamarin.KotlinX.Coroutines
{
	// Token: 0x0200003B RID: 59
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlinx/coroutines/CancellableContinuation$DefaultImpls", DoNotGenerateAcw = true)]
	public sealed class CancellableContinuationDefaultImpls : Java.Lang.Object
	{
		// Token: 0x1700008C RID: 140
		// (get) Token: 0x0600016A RID: 362 RVA: 0x00005594 File Offset: 0x00003794
		internal static IntPtr class_ref
		{
			get
			{
				return CancellableContinuationDefaultImpls._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700008D RID: 141
		// (get) Token: 0x0600016B RID: 363 RVA: 0x000055B8 File Offset: 0x000037B8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return CancellableContinuationDefaultImpls._members;
			}
		}

		// Token: 0x1700008E RID: 142
		// (get) Token: 0x0600016C RID: 364 RVA: 0x000055C0 File Offset: 0x000037C0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return CancellableContinuationDefaultImpls._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700008F RID: 143
		// (get) Token: 0x0600016D RID: 365 RVA: 0x000055E4 File Offset: 0x000037E4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return CancellableContinuationDefaultImpls._members.ManagedPeerType;
			}
		}

		// Token: 0x0600016E RID: 366 RVA: 0x000055F0 File Offset: 0x000037F0
		internal CancellableContinuationDefaultImpls(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x04000031 RID: 49
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlinx/coroutines/CancellableContinuation$DefaultImpls", typeof(CancellableContinuationDefaultImpls));
	}
}
