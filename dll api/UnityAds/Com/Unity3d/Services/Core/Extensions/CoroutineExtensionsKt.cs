using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Com.Unity3d.Services.Core.Extensions
{
	// Token: 0x020000FC RID: 252
	[Register("com/unity3d/services/core/extensions/CoroutineExtensionsKt", DoNotGenerateAcw = true)]
	public sealed class CoroutineExtensionsKt : Java.Lang.Object
	{
		// Token: 0x17000328 RID: 808
		// (get) Token: 0x06000A08 RID: 2568 RVA: 0x0001D3A0 File Offset: 0x0001B5A0
		internal static IntPtr class_ref
		{
			get
			{
				return CoroutineExtensionsKt._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000329 RID: 809
		// (get) Token: 0x06000A09 RID: 2569 RVA: 0x0001D3C4 File Offset: 0x0001B5C4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return CoroutineExtensionsKt._members;
			}
		}

		// Token: 0x1700032A RID: 810
		// (get) Token: 0x06000A0A RID: 2570 RVA: 0x0001D3CC File Offset: 0x0001B5CC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return CoroutineExtensionsKt._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700032B RID: 811
		// (get) Token: 0x06000A0B RID: 2571 RVA: 0x0001D3F0 File Offset: 0x0001B5F0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return CoroutineExtensionsKt._members.ManagedPeerType;
			}
		}

		// Token: 0x06000A0C RID: 2572 RVA: 0x000021E8 File Offset: 0x000003E8
		internal CoroutineExtensionsKt(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x04000262 RID: 610
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/services/core/extensions/CoroutineExtensionsKt", typeof(CoroutineExtensionsKt));
	}
}
