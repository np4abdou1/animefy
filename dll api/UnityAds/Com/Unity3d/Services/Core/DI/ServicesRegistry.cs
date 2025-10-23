using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Com.Unity3d.Services.Core.DI
{
	// Token: 0x02000117 RID: 279
	[Register("com/unity3d/services/core/di/ServicesRegistry", DoNotGenerateAcw = true)]
	public sealed class ServicesRegistry : Java.Lang.Object, IServicesRegistry, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x1700038C RID: 908
		// (get) Token: 0x06000AD1 RID: 2769 RVA: 0x0001EDAC File Offset: 0x0001CFAC
		internal static IntPtr class_ref
		{
			get
			{
				return ServicesRegistry._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700038D RID: 909
		// (get) Token: 0x06000AD2 RID: 2770 RVA: 0x0001EDD0 File Offset: 0x0001CFD0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return ServicesRegistry._members;
			}
		}

		// Token: 0x1700038E RID: 910
		// (get) Token: 0x06000AD3 RID: 2771 RVA: 0x0001EDD8 File Offset: 0x0001CFD8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return ServicesRegistry._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x1700038F RID: 911
		// (get) Token: 0x06000AD4 RID: 2772 RVA: 0x0001EDFC File Offset: 0x0001CFFC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return ServicesRegistry._members.ManagedPeerType;
			}
		}

		// Token: 0x06000AD5 RID: 2773 RVA: 0x000021E8 File Offset: 0x000003E8
		internal ServicesRegistry(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000AD6 RID: 2774 RVA: 0x0001EE08 File Offset: 0x0001D008
		[Register("resolveService", "(Lcom/unity3d/services/core/di/ServiceKey;)Ljava/lang/Object;", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public unsafe Java.Lang.Object ResolveService(ServiceKey key)
		{
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((key == null) ? IntPtr.Zero : key.Handle);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(ServicesRegistry._members.InstanceMethods.InvokeAbstractObjectMethod("resolveService.(Lcom/unity3d/services/core/di/ServiceKey;)Ljava/lang/Object;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(key);
			}
			return @object;
		}

		// Token: 0x06000AD7 RID: 2775 RVA: 0x0001EE7C File Offset: 0x0001D07C
		[Register("resolveServiceOrNull", "(Lcom/unity3d/services/core/di/ServiceKey;)Ljava/lang/Object;", "")]
		[JavaTypeParameters(new string[]
		{
			"T"
		})]
		public unsafe Java.Lang.Object ResolveServiceOrNull(ServiceKey key)
		{
			Java.Lang.Object @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((key == null) ? IntPtr.Zero : key.Handle);
				@object = Java.Lang.Object.GetObject<Java.Lang.Object>(ServicesRegistry._members.InstanceMethods.InvokeAbstractObjectMethod("resolveServiceOrNull.(Lcom/unity3d/services/core/di/ServiceKey;)Ljava/lang/Object;", this, ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(key);
			}
			return @object;
		}

		// Token: 0x0400028C RID: 652
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/services/core/di/ServicesRegistry", typeof(ServicesRegistry));
	}
}
