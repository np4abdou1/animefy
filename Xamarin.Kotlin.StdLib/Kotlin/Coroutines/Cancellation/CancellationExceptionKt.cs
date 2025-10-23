using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Kotlin.Coroutines.Cancellation
{
	// Token: 0x0200026B RID: 619
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlin/coroutines/cancellation/CancellationExceptionKt", DoNotGenerateAcw = true)]
	public sealed class CancellationExceptionKt : Java.Lang.Object
	{
		// Token: 0x17000827 RID: 2087
		// (get) Token: 0x06001C3A RID: 7226 RVA: 0x0005E3D8 File Offset: 0x0005C5D8
		internal static IntPtr class_ref
		{
			get
			{
				return CancellationExceptionKt._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000828 RID: 2088
		// (get) Token: 0x06001C3B RID: 7227 RVA: 0x0005E3FC File Offset: 0x0005C5FC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return CancellationExceptionKt._members;
			}
		}

		// Token: 0x17000829 RID: 2089
		// (get) Token: 0x06001C3C RID: 7228 RVA: 0x0005E404 File Offset: 0x0005C604
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return CancellationExceptionKt._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700082A RID: 2090
		// (get) Token: 0x06001C3D RID: 7229 RVA: 0x0005E428 File Offset: 0x0005C628
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return CancellationExceptionKt._members.ManagedPeerType;
			}
		}

		// Token: 0x06001C3E RID: 7230 RVA: 0x0005E434 File Offset: 0x0005C634
		internal CancellationExceptionKt(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x040008B2 RID: 2226
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/coroutines/cancellation/CancellationExceptionKt", typeof(CancellationExceptionKt));
	}
}
