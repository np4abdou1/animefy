using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Com.Unity3d.Services.Core.DI;
using Java.Interop;
using Java.Lang;

namespace Com.Unity3d.Services
{
	// Token: 0x02000032 RID: 50
	[Register("com/unity3d/services/UnityAdsSDK", DoNotGenerateAcw = true)]
	public sealed class UnityAdsSDK : Java.Lang.Object, IServiceComponent, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000001 RID: 1
		// (get) Token: 0x060000B7 RID: 183 RVA: 0x0000215C File Offset: 0x0000035C
		[Register("INSTANCE")]
		public static UnityAdsSDK Instance
		{
			get
			{
				return Java.Lang.Object.GetObject<UnityAdsSDK>(UnityAdsSDK._members.StaticFields.GetObjectValue("INSTANCE.Lcom/unity3d/services/UnityAdsSDK;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x060000B8 RID: 184 RVA: 0x0000218C File Offset: 0x0000038C
		internal static IntPtr class_ref
		{
			get
			{
				return UnityAdsSDK._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x060000B9 RID: 185 RVA: 0x000021B0 File Offset: 0x000003B0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return UnityAdsSDK._members;
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x060000BA RID: 186 RVA: 0x000021B8 File Offset: 0x000003B8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return UnityAdsSDK._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x060000BB RID: 187 RVA: 0x000021DC File Offset: 0x000003DC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return UnityAdsSDK._members.ManagedPeerType;
			}
		}

		// Token: 0x060000BC RID: 188 RVA: 0x000021E8 File Offset: 0x000003E8
		internal UnityAdsSDK(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x060000BD RID: 189 RVA: 0x000021F4 File Offset: 0x000003F4
		public Com.Unity3d.Services.Core.DI.IServiceProvider ServiceProvider
		{
			[Register("getServiceProvider", "()Lcom/unity3d/services/core/di/IServiceProvider;", "")]
			get
			{
				return Java.Lang.Object.GetObject<Com.Unity3d.Services.Core.DI.IServiceProvider>(UnityAdsSDK._members.InstanceMethods.InvokeAbstractObjectMethod("getServiceProvider.()Lcom/unity3d/services/core/di/IServiceProvider;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x060000BE RID: 190 RVA: 0x00002226 File Offset: 0x00000426
		ServiceProvider IServiceComponent.ServiceProvider
		{
			get
			{
				throw new NotImplementedException();
			}
		}

		// Token: 0x04000005 RID: 5
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/services/UnityAdsSDK", typeof(UnityAdsSDK));
	}
}
