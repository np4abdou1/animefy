using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Kotlin.Coroutines
{
	// Token: 0x02000254 RID: 596
	[Register("kotlin/coroutines/ContinuationInterceptor$Key", DoNotGenerateAcw = true)]
	public sealed class ContinuationInterceptorKey : Java.Lang.Object, ICoroutineContextKey, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x170007E7 RID: 2023
		// (get) Token: 0x06001B74 RID: 7028 RVA: 0x0005C1B8 File Offset: 0x0005A3B8
		internal static IntPtr class_ref
		{
			get
			{
				return ContinuationInterceptorKey._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170007E8 RID: 2024
		// (get) Token: 0x06001B75 RID: 7029 RVA: 0x0005C1DC File Offset: 0x0005A3DC
		[Nullable(1)]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			[NullableContext(1)]
			get
			{
				return ContinuationInterceptorKey._members;
			}
		}

		// Token: 0x170007E9 RID: 2025
		// (get) Token: 0x06001B76 RID: 7030 RVA: 0x0005C1E4 File Offset: 0x0005A3E4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return ContinuationInterceptorKey._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170007EA RID: 2026
		// (get) Token: 0x06001B77 RID: 7031 RVA: 0x0005C208 File Offset: 0x0005A408
		[Nullable(1)]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			[NullableContext(1)]
			get
			{
				return ContinuationInterceptorKey._members.ManagedPeerType;
			}
		}

		// Token: 0x06001B78 RID: 7032 RVA: 0x0005C214 File Offset: 0x0005A414
		internal ContinuationInterceptorKey(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x04000871 RID: 2161
		[Nullable(1)]
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/coroutines/ContinuationInterceptor$Key", typeof(ContinuationInterceptorKey));
	}
}
