using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Content;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Xamarin.Google.Android.DataTransport.Runtime.Scheduling.JobScheduling
{
	// Token: 0x02000050 RID: 80
	[Register("com/google/android/datatransport/runtime/scheduling/jobscheduling/AlarmManagerSchedulerBroadcastReceiver", DoNotGenerateAcw = true)]
	public class AlarmManagerSchedulerBroadcastReceiver : BroadcastReceiver
	{
		// Token: 0x170000C1 RID: 193
		// (get) Token: 0x0600027B RID: 635 RVA: 0x00007D24 File Offset: 0x00005F24
		internal static IntPtr class_ref
		{
			get
			{
				return AlarmManagerSchedulerBroadcastReceiver._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170000C2 RID: 194
		// (get) Token: 0x0600027C RID: 636 RVA: 0x00007D48 File Offset: 0x00005F48
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return AlarmManagerSchedulerBroadcastReceiver._members;
			}
		}

		// Token: 0x170000C3 RID: 195
		// (get) Token: 0x0600027D RID: 637 RVA: 0x00007D50 File Offset: 0x00005F50
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return AlarmManagerSchedulerBroadcastReceiver._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170000C4 RID: 196
		// (get) Token: 0x0600027E RID: 638 RVA: 0x00007D74 File Offset: 0x00005F74
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return AlarmManagerSchedulerBroadcastReceiver._members.ManagedPeerType;
			}
		}

		// Token: 0x0600027F RID: 639 RVA: 0x00007D80 File Offset: 0x00005F80
		protected AlarmManagerSchedulerBroadcastReceiver(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000280 RID: 640 RVA: 0x00007D8C File Offset: 0x00005F8C
		[Register(".ctor", "()V", "")]
		public AlarmManagerSchedulerBroadcastReceiver() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			base.SetHandle(AlarmManagerSchedulerBroadcastReceiver._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
			AlarmManagerSchedulerBroadcastReceiver._members.InstanceMethods.FinishCreateInstance("()V", this, null);
		}

		// Token: 0x06000281 RID: 641 RVA: 0x00007DFA File Offset: 0x00005FFA
		private static Delegate GetOnReceive_Landroid_content_Context_Landroid_content_Intent_Handler()
		{
			if (AlarmManagerSchedulerBroadcastReceiver.cb_onReceive_Landroid_content_Context_Landroid_content_Intent_ == null)
			{
				AlarmManagerSchedulerBroadcastReceiver.cb_onReceive_Landroid_content_Context_Landroid_content_Intent_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPLL_V(AlarmManagerSchedulerBroadcastReceiver.n_OnReceive_Landroid_content_Context_Landroid_content_Intent_));
			}
			return AlarmManagerSchedulerBroadcastReceiver.cb_onReceive_Landroid_content_Context_Landroid_content_Intent_;
		}

		// Token: 0x06000282 RID: 642 RVA: 0x00007E20 File Offset: 0x00006020
		private static void n_OnReceive_Landroid_content_Context_Landroid_content_Intent_(IntPtr jnienv, IntPtr native__this, IntPtr native_context, IntPtr native_intent)
		{
			BroadcastReceiver @object = Java.Lang.Object.GetObject<AlarmManagerSchedulerBroadcastReceiver>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			Context object2 = Java.Lang.Object.GetObject<Context>(native_context, JniHandleOwnership.DoNotTransfer);
			Intent object3 = Java.Lang.Object.GetObject<Intent>(native_intent, JniHandleOwnership.DoNotTransfer);
			@object.OnReceive(object2, object3);
		}

		// Token: 0x06000283 RID: 643 RVA: 0x00007E4C File Offset: 0x0000604C
		[Register("onReceive", "(Landroid/content/Context;Landroid/content/Intent;)V", "GetOnReceive_Landroid_content_Context_Landroid_content_Intent_Handler")]
		public unsafe override void OnReceive(Context context, Intent intent)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((context == null) ? IntPtr.Zero : context.Handle);
				ptr[1] = new JniArgumentValue((intent == null) ? IntPtr.Zero : intent.Handle);
				AlarmManagerSchedulerBroadcastReceiver._members.InstanceMethods.InvokeVirtualVoidMethod("onReceive.(Landroid/content/Context;Landroid/content/Intent;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(context);
				GC.KeepAlive(intent);
			}
		}

		// Token: 0x0400008D RID: 141
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/google/android/datatransport/runtime/scheduling/jobscheduling/AlarmManagerSchedulerBroadcastReceiver", typeof(AlarmManagerSchedulerBroadcastReceiver));

		// Token: 0x0400008E RID: 142
		private static Delegate cb_onReceive_Landroid_content_Context_Landroid_content_Intent_;
	}
}
