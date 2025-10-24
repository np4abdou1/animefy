using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Com.Unity3d.Services.Core.DI
{
	// Token: 0x02000118 RID: 280
	[Register("com/unity3d/services/core/di/ServicesRegistryKt", DoNotGenerateAcw = true)]
	public sealed class ServicesRegistryKt : Java.Lang.Object
	{
		// Token: 0x17000390 RID: 912
		// (get) Token: 0x06000AD9 RID: 2777 RVA: 0x0001EF0C File Offset: 0x0001D10C
		internal static IntPtr class_ref
		{
			get
			{
				return ServicesRegistryKt._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000391 RID: 913
		// (get) Token: 0x06000ADA RID: 2778 RVA: 0x0001EF30 File Offset: 0x0001D130
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return ServicesRegistryKt._members;
			}
		}

		// Token: 0x17000392 RID: 914
		// (get) Token: 0x06000ADB RID: 2779 RVA: 0x0001EF38 File Offset: 0x0001D138
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return ServicesRegistryKt._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000393 RID: 915
		// (get) Token: 0x06000ADC RID: 2780 RVA: 0x0001EF5C File Offset: 0x0001D15C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return ServicesRegistryKt._members.ManagedPeerType;
			}
		}

		// Token: 0x06000ADD RID: 2781 RVA: 0x000021E8 File Offset: 0x000003E8
		internal ServicesRegistryKt(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x0400028D RID: 653
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/services/core/di/ServicesRegistryKt", typeof(ServicesRegistryKt));
	}
}
