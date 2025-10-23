using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Com.Unity3d.Services.Core.Reflection
{
	// Token: 0x020000C9 RID: 201
	[Register("com/unity3d/services/core/reflection/GenericListenerProxy", DoNotGenerateAcw = true)]
	internal class GenericListenerProxyInvoker : GenericListenerProxy
	{
		// Token: 0x060007DA RID: 2010 RVA: 0x00004BCC File Offset: 0x00002DCC
		public GenericListenerProxyInvoker(IntPtr handle, JniHandleOwnership transfer) : base(handle, transfer)
		{
		}

		// Token: 0x17000271 RID: 625
		// (get) Token: 0x060007DB RID: 2011 RVA: 0x000168CB File Offset: 0x00014ACB
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return GenericListenerProxyInvoker._members;
			}
		}

		// Token: 0x17000272 RID: 626
		// (get) Token: 0x060007DC RID: 2012 RVA: 0x000168D2 File Offset: 0x00014AD2
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return GenericListenerProxyInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x17000273 RID: 627
		// (get) Token: 0x060007DD RID: 2013 RVA: 0x000168E0 File Offset: 0x00014AE0
		public override Class ProxyClass
		{
			[Register("getProxyClass", "()Ljava/lang/Class;", "GetGetProxyClassHandler")]
			get
			{
				return Java.Lang.Object.GetObject<Class>(GenericListenerProxyInvoker._members.InstanceMethods.InvokeAbstractObjectMethod("getProxyClass.()Ljava/lang/Class;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x040001E5 RID: 485
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/services/core/reflection/GenericListenerProxy", typeof(GenericListenerProxyInvoker));
	}
}
