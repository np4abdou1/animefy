using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Com.Unity3d.Services.Core.DI
{
	// Token: 0x0200010D RID: 269
	[Register("com/unity3d/services/core/di/IServiceComponentKt", DoNotGenerateAcw = true)]
	public sealed class IServiceComponentKt : Java.Lang.Object
	{
		// Token: 0x17000367 RID: 871
		// (get) Token: 0x06000A86 RID: 2694 RVA: 0x0001E54C File Offset: 0x0001C74C
		internal static IntPtr class_ref
		{
			get
			{
				return IServiceComponentKt._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000368 RID: 872
		// (get) Token: 0x06000A87 RID: 2695 RVA: 0x0001E570 File Offset: 0x0001C770
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return IServiceComponentKt._members;
			}
		}

		// Token: 0x17000369 RID: 873
		// (get) Token: 0x06000A88 RID: 2696 RVA: 0x0001E578 File Offset: 0x0001C778
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return IServiceComponentKt._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700036A RID: 874
		// (get) Token: 0x06000A89 RID: 2697 RVA: 0x0001E59C File Offset: 0x0001C79C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return IServiceComponentKt._members.ManagedPeerType;
			}
		}

		// Token: 0x06000A8A RID: 2698 RVA: 0x000021E8 File Offset: 0x000003E8
		internal IServiceComponentKt(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x04000279 RID: 633
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/services/core/di/IServiceComponentKt", typeof(IServiceComponentKt));
	}
}
