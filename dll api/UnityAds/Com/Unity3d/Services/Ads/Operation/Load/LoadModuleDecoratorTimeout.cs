using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Com.Unity3d.Services.Core.Configuration;
using Java.Interop;
using Java.Lang;

namespace Com.Unity3d.Services.Ads.Operation.Load
{
	// Token: 0x020001FD RID: 509
	[Register("com/unity3d/services/ads/operation/load/LoadModuleDecoratorTimeout", DoNotGenerateAcw = true)]
	public class LoadModuleDecoratorTimeout : LoadModuleDecorator
	{
		// Token: 0x17000824 RID: 2084
		// (get) Token: 0x060017B4 RID: 6068 RVA: 0x000447F4 File Offset: 0x000429F4
		internal new static IntPtr class_ref
		{
			get
			{
				return LoadModuleDecoratorTimeout._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000825 RID: 2085
		// (get) Token: 0x060017B5 RID: 6069 RVA: 0x00044818 File Offset: 0x00042A18
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return LoadModuleDecoratorTimeout._members;
			}
		}

		// Token: 0x17000826 RID: 2086
		// (get) Token: 0x060017B6 RID: 6070 RVA: 0x00044820 File Offset: 0x00042A20
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return LoadModuleDecoratorTimeout._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000827 RID: 2087
		// (get) Token: 0x060017B7 RID: 6071 RVA: 0x00044844 File Offset: 0x00042A44
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return LoadModuleDecoratorTimeout._members.ManagedPeerType;
			}
		}

		// Token: 0x060017B8 RID: 6072 RVA: 0x000445B0 File Offset: 0x000427B0
		protected LoadModuleDecoratorTimeout(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x060017B9 RID: 6073 RVA: 0x00044850 File Offset: 0x00042A50
		[Register(".ctor", "(Lcom/unity3d/services/ads/operation/load/ILoadModule;Lcom/unity3d/services/core/configuration/ConfigurationReader;)V", "")]
		public unsafe LoadModuleDecoratorTimeout(ILoadModule loadModule, ConfigurationReader configurationReader) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((loadModule == null) ? IntPtr.Zero : ((Java.Lang.Object)loadModule).Handle);
				ptr[1] = new JniArgumentValue((configurationReader == null) ? IntPtr.Zero : configurationReader.Handle);
				base.SetHandle(LoadModuleDecoratorTimeout._members.InstanceMethods.StartCreateInstance("(Lcom/unity3d/services/ads/operation/load/ILoadModule;Lcom/unity3d/services/core/configuration/ConfigurationReader;)V", base.GetType(), ptr).Handle, JniHandleOwnership.TransferLocalRef);
				LoadModuleDecoratorTimeout._members.InstanceMethods.FinishCreateInstance("(Lcom/unity3d/services/ads/operation/load/ILoadModule;Lcom/unity3d/services/core/configuration/ConfigurationReader;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(loadModule);
				GC.KeepAlive(configurationReader);
			}
		}

		// Token: 0x040005C5 RID: 1477
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/services/ads/operation/load/LoadModuleDecoratorTimeout", typeof(LoadModuleDecoratorTimeout));
	}
}
