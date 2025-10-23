using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;

namespace Com.Unity3d.Services.Core.Reflection
{
	// Token: 0x020000C7 RID: 199
	[Register("com/unity3d/services/core/reflection/GenericBridge", DoNotGenerateAcw = true)]
	internal class GenericBridgeInvoker : GenericBridge
	{
		// Token: 0x060007C5 RID: 1989 RVA: 0x000058C0 File Offset: 0x00003AC0
		public GenericBridgeInvoker(IntPtr handle, JniHandleOwnership transfer) : base(handle, transfer)
		{
		}

		// Token: 0x17000268 RID: 616
		// (get) Token: 0x060007C6 RID: 1990 RVA: 0x00016591 File Offset: 0x00014791
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return GenericBridgeInvoker._members;
			}
		}

		// Token: 0x17000269 RID: 617
		// (get) Token: 0x060007C7 RID: 1991 RVA: 0x00016598 File Offset: 0x00014798
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return GenericBridgeInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x1700026A RID: 618
		// (get) Token: 0x060007C8 RID: 1992 RVA: 0x000165A4 File Offset: 0x000147A4
		protected override string ClassName
		{
			[Register("getClassName", "()Ljava/lang/String;", "GetGetClassNameHandler")]
			get
			{
				return JNIEnv.GetString(GenericBridgeInvoker._members.InstanceMethods.InvokeAbstractObjectMethod("getClassName.()Ljava/lang/String;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x040001E0 RID: 480
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/services/core/reflection/GenericBridge", typeof(GenericBridgeInvoker));
	}
}
