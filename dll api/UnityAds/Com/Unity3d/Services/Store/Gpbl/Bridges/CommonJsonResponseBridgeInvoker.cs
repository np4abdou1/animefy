using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;

namespace Com.Unity3d.Services.Store.Gpbl.Bridges
{
	// Token: 0x02000054 RID: 84
	[Register("com/unity3d/services/store/gpbl/bridges/CommonJsonResponseBridge", DoNotGenerateAcw = true)]
	internal class CommonJsonResponseBridgeInvoker : CommonJsonResponseBridge
	{
		// Token: 0x06000212 RID: 530 RVA: 0x00005CD5 File Offset: 0x00003ED5
		public CommonJsonResponseBridgeInvoker(IntPtr handle, JniHandleOwnership transfer) : base(handle, transfer)
		{
		}

		// Token: 0x1700009E RID: 158
		// (get) Token: 0x06000213 RID: 531 RVA: 0x00005CDF File Offset: 0x00003EDF
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return CommonJsonResponseBridgeInvoker._members;
			}
		}

		// Token: 0x1700009F RID: 159
		// (get) Token: 0x06000214 RID: 532 RVA: 0x00005CE6 File Offset: 0x00003EE6
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return CommonJsonResponseBridgeInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x170000A0 RID: 160
		// (get) Token: 0x06000215 RID: 533 RVA: 0x00005CF4 File Offset: 0x00003EF4
		protected override string ClassName
		{
			[Register("getClassName", "()Ljava/lang/String;", "GetGetClassNameHandler")]
			get
			{
				return JNIEnv.GetString(CommonJsonResponseBridgeInvoker._members.InstanceMethods.InvokeAbstractObjectMethod("getClassName.()Ljava/lang/String;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x0400004E RID: 78
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/services/store/gpbl/bridges/CommonJsonResponseBridge", typeof(CommonJsonResponseBridgeInvoker));
	}
}
