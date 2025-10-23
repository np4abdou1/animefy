using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Com.Unity3d.Services.Core.Extensions
{
	// Token: 0x020000FD RID: 253
	[Register("com/unity3d/services/core/extensions/TaskExtensionsKt", DoNotGenerateAcw = true)]
	public sealed class TaskExtensionsKt : Java.Lang.Object
	{
		// Token: 0x1700032C RID: 812
		// (get) Token: 0x06000A0E RID: 2574 RVA: 0x0001D418 File Offset: 0x0001B618
		internal static IntPtr class_ref
		{
			get
			{
				return TaskExtensionsKt._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700032D RID: 813
		// (get) Token: 0x06000A0F RID: 2575 RVA: 0x0001D43C File Offset: 0x0001B63C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return TaskExtensionsKt._members;
			}
		}

		// Token: 0x1700032E RID: 814
		// (get) Token: 0x06000A10 RID: 2576 RVA: 0x0001D444 File Offset: 0x0001B644
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return TaskExtensionsKt._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700032F RID: 815
		// (get) Token: 0x06000A11 RID: 2577 RVA: 0x0001D468 File Offset: 0x0001B668
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return TaskExtensionsKt._members.ManagedPeerType;
			}
		}

		// Token: 0x06000A12 RID: 2578 RVA: 0x000021E8 File Offset: 0x000003E8
		internal TaskExtensionsKt(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x04000263 RID: 611
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/services/core/extensions/TaskExtensionsKt", typeof(TaskExtensionsKt));
	}
}
