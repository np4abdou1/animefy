using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Com.Unity3d.Services.Core.DI
{
	// Token: 0x02000116 RID: 278
	[Register("com/unity3d/services/core/di/ServiceProvider", DoNotGenerateAcw = true)]
	public sealed class ServiceProvider : Java.Lang.Object, IServiceProvider, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000386 RID: 902
		// (get) Token: 0x06000AC8 RID: 2760 RVA: 0x0001EC9C File Offset: 0x0001CE9C
		[Register("INSTANCE")]
		public static ServiceProvider Instance
		{
			get
			{
				return Java.Lang.Object.GetObject<ServiceProvider>(ServiceProvider._members.StaticFields.GetObjectValue("INSTANCE.Lcom/unity3d/services/core/di/ServiceProvider;").Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000387 RID: 903
		// (get) Token: 0x06000AC9 RID: 2761 RVA: 0x0001ECCC File Offset: 0x0001CECC
		internal static IntPtr class_ref
		{
			get
			{
				return ServiceProvider._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000388 RID: 904
		// (get) Token: 0x06000ACA RID: 2762 RVA: 0x0001ECF0 File Offset: 0x0001CEF0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return ServiceProvider._members;
			}
		}

		// Token: 0x17000389 RID: 905
		// (get) Token: 0x06000ACB RID: 2763 RVA: 0x0001ECF8 File Offset: 0x0001CEF8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return ServiceProvider._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700038A RID: 906
		// (get) Token: 0x06000ACC RID: 2764 RVA: 0x0001ED1C File Offset: 0x0001CF1C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return ServiceProvider._members.ManagedPeerType;
			}
		}

		// Token: 0x06000ACD RID: 2765 RVA: 0x000021E8 File Offset: 0x000003E8
		internal ServiceProvider(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x1700038B RID: 907
		// (get) Token: 0x06000ACE RID: 2766 RVA: 0x0001ED28 File Offset: 0x0001CF28
		public IServicesRegistry Registry
		{
			[Register("getRegistry", "()Lcom/unity3d/services/core/di/IServicesRegistry;", "")]
			get
			{
				return Java.Lang.Object.GetObject<IServicesRegistry>(ServiceProvider._members.InstanceMethods.InvokeAbstractObjectMethod("getRegistry.()Lcom/unity3d/services/core/di/IServicesRegistry;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06000ACF RID: 2767 RVA: 0x0001ED5C File Offset: 0x0001CF5C
		[Register("initialize", "()Lcom/unity3d/services/core/di/IServicesRegistry;", "")]
		public IServicesRegistry Initialize()
		{
			return Java.Lang.Object.GetObject<IServicesRegistry>(ServiceProvider._members.InstanceMethods.InvokeAbstractObjectMethod("initialize.()Lcom/unity3d/services/core/di/IServicesRegistry;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
		}

		// Token: 0x0400028A RID: 650
		[Register("NAMED_SDK")]
		public const string NamedSdk = "sdk";

		// Token: 0x0400028B RID: 651
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/services/core/di/ServiceProvider", typeof(ServiceProvider));
	}
}
