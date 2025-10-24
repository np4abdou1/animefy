using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.OS;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Com.Applovin.Impl.Communicator
{
	// Token: 0x0200015D RID: 349
	[Register("com/applovin/impl/communicator/CommunicatorMessageImpl", DoNotGenerateAcw = true)]
	internal class CommunicatorMessageImplInvoker : CommunicatorMessageImpl
	{
		// Token: 0x06001145 RID: 4421 RVA: 0x00031E4B File Offset: 0x0003004B
		public CommunicatorMessageImplInvoker(IntPtr handle, JniHandleOwnership transfer) : base(handle, transfer)
		{
		}

		// Token: 0x1700047D RID: 1149
		// (get) Token: 0x06001146 RID: 4422 RVA: 0x00031E55 File Offset: 0x00030055
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return CommunicatorMessageImplInvoker._members;
			}
		}

		// Token: 0x1700047E RID: 1150
		// (get) Token: 0x06001147 RID: 4423 RVA: 0x00031E5C File Offset: 0x0003005C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return CommunicatorMessageImplInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x1700047F RID: 1151
		// (get) Token: 0x06001148 RID: 4424 RVA: 0x00031E68 File Offset: 0x00030068
		public override Bundle MessageData
		{
			[Register("getMessageData", "()Landroid/os/Bundle;", "GetGetMessageDataHandler")]
			get
			{
				return Java.Lang.Object.GetObject<Bundle>(CommunicatorMessageImplInvoker._members.InstanceMethods.InvokeAbstractObjectMethod("getMessageData.()Landroid/os/Bundle;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000480 RID: 1152
		// (get) Token: 0x06001149 RID: 4425 RVA: 0x00031E9C File Offset: 0x0003009C
		public override string PublisherId
		{
			[Register("getPublisherId", "()Ljava/lang/String;", "GetGetPublisherIdHandler")]
			get
			{
				return JNIEnv.GetString(CommunicatorMessageImplInvoker._members.InstanceMethods.InvokeAbstractObjectMethod("getPublisherId.()Ljava/lang/String;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000481 RID: 1153
		// (get) Token: 0x0600114A RID: 4426 RVA: 0x00031ED0 File Offset: 0x000300D0
		public override string Topic
		{
			[Register("getTopic", "()Ljava/lang/String;", "GetGetTopicHandler")]
			get
			{
				return JNIEnv.GetString(CommunicatorMessageImplInvoker._members.InstanceMethods.InvokeAbstractObjectMethod("getTopic.()Ljava/lang/String;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x040005A9 RID: 1449
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/applovin/impl/communicator/CommunicatorMessageImpl", typeof(CommunicatorMessageImplInvoker));
	}
}
