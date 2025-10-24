using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Com.Unity3d.Services.Core.DI
{
	// Token: 0x02000110 RID: 272
	[Register("com/unity3d/services/core/di/IServicesRegistry$DefaultImpls", DoNotGenerateAcw = true)]
	public sealed class ServicesRegistryDefaultImpls : Java.Lang.Object
	{
		// Token: 0x17000371 RID: 881
		// (get) Token: 0x06000A9D RID: 2717 RVA: 0x0001E7D0 File Offset: 0x0001C9D0
		internal static IntPtr class_ref
		{
			get
			{
				return ServicesRegistryDefaultImpls._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000372 RID: 882
		// (get) Token: 0x06000A9E RID: 2718 RVA: 0x0001E7F4 File Offset: 0x0001C9F4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return ServicesRegistryDefaultImpls._members;
			}
		}

		// Token: 0x17000373 RID: 883
		// (get) Token: 0x06000A9F RID: 2719 RVA: 0x0001E7FC File Offset: 0x0001C9FC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return ServicesRegistryDefaultImpls._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000374 RID: 884
		// (get) Token: 0x06000AA0 RID: 2720 RVA: 0x0001E820 File Offset: 0x0001CA20
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return ServicesRegistryDefaultImpls._members.ManagedPeerType;
			}
		}

		// Token: 0x06000AA1 RID: 2721 RVA: 0x000021E8 File Offset: 0x000003E8
		internal ServicesRegistryDefaultImpls(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x04000280 RID: 640
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/services/core/di/IServicesRegistry$DefaultImpls", typeof(ServicesRegistryDefaultImpls));
	}
}
