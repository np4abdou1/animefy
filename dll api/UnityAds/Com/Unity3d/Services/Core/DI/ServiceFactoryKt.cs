using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Com.Unity3d.Services.Core.DI
{
	// Token: 0x02000114 RID: 276
	[Register("com/unity3d/services/core/di/ServiceFactoryKt", DoNotGenerateAcw = true)]
	public sealed class ServiceFactoryKt : Java.Lang.Object
	{
		// Token: 0x1700037D RID: 893
		// (get) Token: 0x06000ABA RID: 2746 RVA: 0x0001EB44 File Offset: 0x0001CD44
		internal static IntPtr class_ref
		{
			get
			{
				return ServiceFactoryKt._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700037E RID: 894
		// (get) Token: 0x06000ABB RID: 2747 RVA: 0x0001EB68 File Offset: 0x0001CD68
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return ServiceFactoryKt._members;
			}
		}

		// Token: 0x1700037F RID: 895
		// (get) Token: 0x06000ABC RID: 2748 RVA: 0x0001EB70 File Offset: 0x0001CD70
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return ServiceFactoryKt._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000380 RID: 896
		// (get) Token: 0x06000ABD RID: 2749 RVA: 0x0001EB94 File Offset: 0x0001CD94
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return ServiceFactoryKt._members.ManagedPeerType;
			}
		}

		// Token: 0x06000ABE RID: 2750 RVA: 0x000021E8 File Offset: 0x000003E8
		internal ServiceFactoryKt(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x04000288 RID: 648
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/services/core/di/ServiceFactoryKt", typeof(ServiceFactoryKt));
	}
}
