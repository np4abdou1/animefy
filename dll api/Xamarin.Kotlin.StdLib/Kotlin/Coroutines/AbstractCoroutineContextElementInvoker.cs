using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;

namespace Kotlin.Coroutines
{
	// Token: 0x0200024D RID: 589
	[NullableContext(1)]
	[Nullable(0)]
	[Register("kotlin/coroutines/AbstractCoroutineContextElement", DoNotGenerateAcw = true)]
	internal class AbstractCoroutineContextElementInvoker : AbstractCoroutineContextElement
	{
		// Token: 0x06001B37 RID: 6967 RVA: 0x0005B397 File Offset: 0x00059597
		public AbstractCoroutineContextElementInvoker(IntPtr handle, JniHandleOwnership transfer) : base(handle, transfer)
		{
		}

		// Token: 0x170007CE RID: 1998
		// (get) Token: 0x06001B38 RID: 6968 RVA: 0x0005B3A1 File Offset: 0x000595A1
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return AbstractCoroutineContextElementInvoker._members;
			}
		}

		// Token: 0x170007CF RID: 1999
		// (get) Token: 0x06001B39 RID: 6969 RVA: 0x0005B3A8 File Offset: 0x000595A8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return AbstractCoroutineContextElementInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x04000866 RID: 2150
		private static readonly JniPeerMembers _members = new XAPeerMembers("kotlin/coroutines/AbstractCoroutineContextElement", typeof(AbstractCoroutineContextElementInvoker));
	}
}
