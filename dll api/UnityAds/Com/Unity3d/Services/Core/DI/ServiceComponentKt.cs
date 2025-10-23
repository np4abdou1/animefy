using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Com.Unity3d.Services.Core.DI
{
	// Token: 0x02000113 RID: 275
	[Register("com/unity3d/services/core/di/ServiceComponentKt", DoNotGenerateAcw = true)]
	public sealed class ServiceComponentKt : Java.Lang.Object
	{
		// Token: 0x17000379 RID: 889
		// (get) Token: 0x06000AB4 RID: 2740 RVA: 0x0001EACC File Offset: 0x0001CCCC
		internal static IntPtr class_ref
		{
			get
			{
				return ServiceComponentKt._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700037A RID: 890
		// (get) Token: 0x06000AB5 RID: 2741 RVA: 0x0001EAF0 File Offset: 0x0001CCF0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return ServiceComponentKt._members;
			}
		}

		// Token: 0x1700037B RID: 891
		// (get) Token: 0x06000AB6 RID: 2742 RVA: 0x0001EAF8 File Offset: 0x0001CCF8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return ServiceComponentKt._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700037C RID: 892
		// (get) Token: 0x06000AB7 RID: 2743 RVA: 0x0001EB1C File Offset: 0x0001CD1C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return ServiceComponentKt._members.ManagedPeerType;
			}
		}

		// Token: 0x06000AB8 RID: 2744 RVA: 0x000021E8 File Offset: 0x000003E8
		internal ServiceComponentKt(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x04000287 RID: 647
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/services/core/di/ServiceComponentKt", typeof(ServiceComponentKt));
	}
}
