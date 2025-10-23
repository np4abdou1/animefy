using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Xamarin.KotlinX.Coroutines.Sync
{
	// Token: 0x02000088 RID: 136
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlinx/coroutines/sync/Mutex$DefaultImpls", DoNotGenerateAcw = true)]
	public sealed class MutexDefaultImpls : Java.Lang.Object
	{
		// Token: 0x170001C1 RID: 449
		// (get) Token: 0x06000605 RID: 1541 RVA: 0x000141EC File Offset: 0x000123EC
		internal static IntPtr class_ref
		{
			get
			{
				return MutexDefaultImpls._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170001C2 RID: 450
		// (get) Token: 0x06000606 RID: 1542 RVA: 0x00014210 File Offset: 0x00012410
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return MutexDefaultImpls._members;
			}
		}

		// Token: 0x170001C3 RID: 451
		// (get) Token: 0x06000607 RID: 1543 RVA: 0x00014218 File Offset: 0x00012418
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return MutexDefaultImpls._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170001C4 RID: 452
		// (get) Token: 0x06000608 RID: 1544 RVA: 0x0001423C File Offset: 0x0001243C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return MutexDefaultImpls._members.ManagedPeerType;
			}
		}

		// Token: 0x06000609 RID: 1545 RVA: 0x00014248 File Offset: 0x00012448
		internal MutexDefaultImpls(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x04000211 RID: 529
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlinx/coroutines/sync/Mutex$DefaultImpls", typeof(MutexDefaultImpls));
	}
}
