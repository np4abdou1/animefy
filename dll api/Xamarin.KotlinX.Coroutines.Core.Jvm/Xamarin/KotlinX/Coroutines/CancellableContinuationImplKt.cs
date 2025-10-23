using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Xamarin.KotlinX.Coroutines
{
	// Token: 0x0200001C RID: 28
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlinx/coroutines/CancellableContinuationImplKt", DoNotGenerateAcw = true)]
	public sealed class CancellableContinuationImplKt : Java.Lang.Object
	{
		// Token: 0x17000011 RID: 17
		// (get) Token: 0x0600006C RID: 108 RVA: 0x00002990 File Offset: 0x00000B90
		internal static IntPtr class_ref
		{
			get
			{
				return CancellableContinuationImplKt._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x0600006D RID: 109 RVA: 0x000029B4 File Offset: 0x00000BB4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return CancellableContinuationImplKt._members;
			}
		}

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x0600006E RID: 110 RVA: 0x000029BC File Offset: 0x00000BBC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return CancellableContinuationImplKt._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x0600006F RID: 111 RVA: 0x000029E0 File Offset: 0x00000BE0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return CancellableContinuationImplKt._members.ManagedPeerType;
			}
		}

		// Token: 0x06000070 RID: 112 RVA: 0x000029EC File Offset: 0x00000BEC
		internal CancellableContinuationImplKt(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x04000008 RID: 8
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlinx/coroutines/CancellableContinuationImplKt", typeof(CancellableContinuationImplKt));
	}
}
