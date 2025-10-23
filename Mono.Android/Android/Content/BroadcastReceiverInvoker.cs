using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;

namespace Android.Content
{
	// Token: 0x0200027B RID: 635
	[Register("android/content/BroadcastReceiver", DoNotGenerateAcw = true)]
	internal class BroadcastReceiverInvoker : BroadcastReceiver
	{
		// Token: 0x06001811 RID: 6161 RVA: 0x0003E47B File Offset: 0x0003C67B
		public BroadcastReceiverInvoker(IntPtr handle, JniHandleOwnership transfer) : base(handle, transfer)
		{
		}

		// Token: 0x17000527 RID: 1319
		// (get) Token: 0x06001812 RID: 6162 RVA: 0x0003E485 File Offset: 0x0003C685
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return BroadcastReceiverInvoker._members;
			}
		}

		// Token: 0x17000528 RID: 1320
		// (get) Token: 0x06001813 RID: 6163 RVA: 0x0003E48C File Offset: 0x0003C68C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return BroadcastReceiverInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x06001814 RID: 6164 RVA: 0x0003E498 File Offset: 0x0003C698
		public unsafe override void OnReceive(Context context, Intent intent)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((context == null) ? IntPtr.Zero : context.Handle);
				ptr[1] = new JniArgumentValue((intent == null) ? IntPtr.Zero : intent.Handle);
				BroadcastReceiverInvoker._members.InstanceMethods.InvokeAbstractVoidMethod("onReceive.(Landroid/content/Context;Landroid/content/Intent;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(context);
				GC.KeepAlive(intent);
			}
		}

		// Token: 0x04000A42 RID: 2626
		private static readonly JniPeerMembers _members = new XAPeerMembers("android/content/BroadcastReceiver", typeof(BroadcastReceiverInvoker));
	}
}
