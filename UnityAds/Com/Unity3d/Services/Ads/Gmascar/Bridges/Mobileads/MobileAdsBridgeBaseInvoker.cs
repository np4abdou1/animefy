using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Com.Unity3d.Services.Ads.Gmascar.Finder;
using Java.Interop;
using Java.Lang;

namespace Com.Unity3d.Services.Ads.Gmascar.Bridges.Mobileads
{
	// Token: 0x0200021A RID: 538
	[Register("com/unity3d/services/ads/gmascar/bridges/mobileads/MobileAdsBridgeBase", DoNotGenerateAcw = true)]
	internal class MobileAdsBridgeBaseInvoker : MobileAdsBridgeBase
	{
		// Token: 0x06001945 RID: 6469 RVA: 0x00048200 File Offset: 0x00046400
		public MobileAdsBridgeBaseInvoker(IntPtr handle, JniHandleOwnership transfer) : base(handle, transfer)
		{
		}

		// Token: 0x170008A2 RID: 2210
		// (get) Token: 0x06001946 RID: 6470 RVA: 0x00048836 File Offset: 0x00046A36
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return MobileAdsBridgeBaseInvoker._members;
			}
		}

		// Token: 0x170008A3 RID: 2211
		// (get) Token: 0x06001947 RID: 6471 RVA: 0x0004883D File Offset: 0x00046A3D
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return MobileAdsBridgeBaseInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x170008A4 RID: 2212
		// (get) Token: 0x06001948 RID: 6472 RVA: 0x00048849 File Offset: 0x00046A49
		public override int VersionCodeIndex
		{
			[Register("getVersionCodeIndex", "()I", "GetGetVersionCodeIndexHandler")]
			get
			{
				return MobileAdsBridgeBaseInvoker._members.InstanceMethods.InvokeAbstractInt32Method("getVersionCodeIndex.()I", this, null);
			}
		}

		// Token: 0x170008A5 RID: 2213
		// (get) Token: 0x06001949 RID: 6473 RVA: 0x00048864 File Offset: 0x00046A64
		public override string VersionMethodName
		{
			[Register("getVersionMethodName", "()Ljava/lang/String;", "GetGetVersionMethodNameHandler")]
			get
			{
				return JNIEnv.GetString(MobileAdsBridgeBaseInvoker._members.InstanceMethods.InvokeAbstractObjectMethod("getVersionMethodName.()Ljava/lang/String;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x0600194A RID: 6474 RVA: 0x00048898 File Offset: 0x00046A98
		[Register("getAdapterVersion", "(I)Lcom/unity3d/services/ads/gmascar/finder/ScarAdapterVersion;", "GetGetAdapterVersion_IHandler")]
		public unsafe override ScarAdapterVersion GetAdapterVersion(int p0)
		{
			JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
			*ptr = new JniArgumentValue(p0);
			return Java.Lang.Object.GetObject<ScarAdapterVersion>(MobileAdsBridgeBaseInvoker._members.InstanceMethods.InvokeAbstractObjectMethod("getAdapterVersion.(I)Lcom/unity3d/services/ads/gmascar/finder/ScarAdapterVersion;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x0600194B RID: 6475 RVA: 0x000488E1 File Offset: 0x00046AE1
		[Register("shouldInitialize", "()Z", "GetShouldInitializeHandler")]
		public override bool ShouldInitialize()
		{
			return MobileAdsBridgeBaseInvoker._members.InstanceMethods.InvokeAbstractBooleanMethod("shouldInitialize.()Z", this, null);
		}

		// Token: 0x04000633 RID: 1587
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/services/ads/gmascar/bridges/mobileads/MobileAdsBridgeBase", typeof(MobileAdsBridgeBaseInvoker));
	}
}
