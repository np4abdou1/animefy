using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Com.Unity3d.Services.Core.DI;
using Java.Interop;
using Java.Lang;

namespace Com.Unity3d.Services.Core.Domain.Task
{
	// Token: 0x02000105 RID: 261
	[Register("com/unity3d/services/core/domain/task/BaseTask$DefaultImpls", DoNotGenerateAcw = true)]
	public sealed class BaseTaskDefaultImpls : Java.Lang.Object
	{
		// Token: 0x17000345 RID: 837
		// (get) Token: 0x06000A3C RID: 2620 RVA: 0x0001D970 File Offset: 0x0001BB70
		internal static IntPtr class_ref
		{
			get
			{
				return BaseTaskDefaultImpls._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000346 RID: 838
		// (get) Token: 0x06000A3D RID: 2621 RVA: 0x0001D994 File Offset: 0x0001BB94
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return BaseTaskDefaultImpls._members;
			}
		}

		// Token: 0x17000347 RID: 839
		// (get) Token: 0x06000A3E RID: 2622 RVA: 0x0001D99C File Offset: 0x0001BB9C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return BaseTaskDefaultImpls._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000348 RID: 840
		// (get) Token: 0x06000A3F RID: 2623 RVA: 0x0001D9C0 File Offset: 0x0001BBC0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return BaseTaskDefaultImpls._members.ManagedPeerType;
			}
		}

		// Token: 0x06000A40 RID: 2624 RVA: 0x000021E8 File Offset: 0x000003E8
		internal BaseTaskDefaultImpls(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000A41 RID: 2625 RVA: 0x0001D9CC File Offset: 0x0001BBCC
		[Register("getServiceProvider", "(Lcom/unity3d/services/core/domain/task/BaseTask;)Lcom/unity3d/services/core/di/IServiceProvider;", "")]
		[JavaTypeParameters(new string[]
		{
			"P extends com.unity3d.services.core.domain.task.BaseParams",
			"R"
		})]
		public unsafe static Com.Unity3d.Services.Core.DI.IServiceProvider GetServiceProvider(IBaseTask _this)
		{
			Com.Unity3d.Services.Core.DI.IServiceProvider @object;
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((_this == null) ? IntPtr.Zero : ((Java.Lang.Object)_this).Handle);
				@object = Java.Lang.Object.GetObject<Com.Unity3d.Services.Core.DI.IServiceProvider>(BaseTaskDefaultImpls._members.StaticMethods.InvokeObjectMethod("getServiceProvider.(Lcom/unity3d/services/core/domain/task/BaseTask;)Lcom/unity3d/services/core/di/IServiceProvider;", ptr).Handle, JniHandleOwnership.TransferLocalRef);
			}
			finally
			{
				GC.KeepAlive(_this);
			}
			return @object;
		}

		// Token: 0x0400026B RID: 619
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/services/core/domain/task/BaseTask$DefaultImpls", typeof(BaseTaskDefaultImpls));
	}
}
