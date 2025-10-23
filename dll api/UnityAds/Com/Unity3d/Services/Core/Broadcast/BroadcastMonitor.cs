using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Com.Unity3d.Services.Core.Broadcast
{
	// Token: 0x02000183 RID: 387
	[Register("com/unity3d/services/core/broadcast/BroadcastMonitor", DoNotGenerateAcw = true)]
	public class BroadcastMonitor : Java.Lang.Object
	{
		// Token: 0x1700062F RID: 1583
		// (get) Token: 0x06001168 RID: 4456 RVA: 0x0002EC38 File Offset: 0x0002CE38
		internal static IntPtr class_ref
		{
			get
			{
				return BroadcastMonitor._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000630 RID: 1584
		// (get) Token: 0x06001169 RID: 4457 RVA: 0x0002EC5C File Offset: 0x0002CE5C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return BroadcastMonitor._members;
			}
		}

		// Token: 0x17000631 RID: 1585
		// (get) Token: 0x0600116A RID: 4458 RVA: 0x0002EC64 File Offset: 0x0002CE64
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return BroadcastMonitor._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000632 RID: 1586
		// (get) Token: 0x0600116B RID: 4459 RVA: 0x0002EC88 File Offset: 0x0002CE88
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return BroadcastMonitor._members.ManagedPeerType;
			}
		}

		// Token: 0x0600116C RID: 4460 RVA: 0x000021E8 File Offset: 0x000003E8
		protected BroadcastMonitor(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x0600116D RID: 4461 RVA: 0x0002EC94 File Offset: 0x0002CE94
		[Register(".ctor", "()V", "")]
		public BroadcastMonitor() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			base.SetHandle(BroadcastMonitor._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
			BroadcastMonitor._members.InstanceMethods.FinishCreateInstance("()V", this, null);
		}

		// Token: 0x0600116E RID: 4462 RVA: 0x0002ED04 File Offset: 0x0002CF04
		[Register("addBroadcastListener", "(Ljava/lang/String;Ljava/lang/String;[Ljava/lang/String;)V", "")]
		public unsafe static void AddBroadcastListener(string name, string dataScheme, string[] actions)
		{
			IntPtr intPtr = JNIEnv.NewString(name);
			IntPtr intPtr2 = JNIEnv.NewString(dataScheme);
			IntPtr intPtr3 = JNIEnv.NewArray(actions);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue(intPtr2);
				ptr[2] = new JniArgumentValue(intPtr3);
				BroadcastMonitor._members.StaticMethods.InvokeVoidMethod("addBroadcastListener.(Ljava/lang/String;Ljava/lang/String;[Ljava/lang/String;)V", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				JNIEnv.DeleteLocalRef(intPtr2);
				if (actions != null)
				{
					JNIEnv.CopyArray(intPtr3, actions);
					JNIEnv.DeleteLocalRef(intPtr3);
				}
				GC.KeepAlive(actions);
			}
		}

		// Token: 0x0600116F RID: 4463 RVA: 0x0002EDB4 File Offset: 0x0002CFB4
		[Register("removeAllBroadcastListeners", "()V", "")]
		public static void RemoveAllBroadcastListeners()
		{
			BroadcastMonitor._members.StaticMethods.InvokeVoidMethod("removeAllBroadcastListeners.()V", null);
		}

		// Token: 0x06001170 RID: 4464 RVA: 0x0002EDCC File Offset: 0x0002CFCC
		[Register("removeBroadcastListener", "(Ljava/lang/String;)V", "")]
		public unsafe static void RemoveBroadcastListener(string name)
		{
			IntPtr intPtr = JNIEnv.NewString(name);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				BroadcastMonitor._members.StaticMethods.InvokeVoidMethod("removeBroadcastListener.(Ljava/lang/String;)V", ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
			}
		}

		// Token: 0x04000446 RID: 1094
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/services/core/broadcast/BroadcastMonitor", typeof(BroadcastMonitor));
	}
}
