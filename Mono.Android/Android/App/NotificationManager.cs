using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Android.App
{
	// Token: 0x02000267 RID: 615
	[Register("android/app/NotificationManager", DoNotGenerateAcw = true)]
	public class NotificationManager : Java.Lang.Object
	{
		// Token: 0x17000503 RID: 1283
		// (get) Token: 0x0600179C RID: 6044 RVA: 0x0003D5E3 File Offset: 0x0003B7E3
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return NotificationManager._members;
			}
		}

		// Token: 0x17000504 RID: 1284
		// (get) Token: 0x0600179D RID: 6045 RVA: 0x0003D5EC File Offset: 0x0003B7EC
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return NotificationManager._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000505 RID: 1285
		// (get) Token: 0x0600179E RID: 6046 RVA: 0x0003D610 File Offset: 0x0003B810
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return NotificationManager._members.ManagedPeerType;
			}
		}

		// Token: 0x0600179F RID: 6047 RVA: 0x000021E0 File Offset: 0x000003E0
		protected NotificationManager(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x060017A0 RID: 6048 RVA: 0x0003D61C File Offset: 0x0003B81C
		private static Delegate GetCreateNotificationChannel_Landroid_app_NotificationChannel_Handler()
		{
			if (NotificationManager.cb_createNotificationChannel_Landroid_app_NotificationChannel_ == null)
			{
				NotificationManager.cb_createNotificationChannel_Landroid_app_NotificationChannel_ = JNINativeWrapper.CreateDelegate(new _JniMarshal_PPL_V(NotificationManager.n_CreateNotificationChannel_Landroid_app_NotificationChannel_));
			}
			return NotificationManager.cb_createNotificationChannel_Landroid_app_NotificationChannel_;
		}

		// Token: 0x060017A1 RID: 6049 RVA: 0x0003D640 File Offset: 0x0003B840
		private static void n_CreateNotificationChannel_Landroid_app_NotificationChannel_(IntPtr jnienv, IntPtr native__this, IntPtr native_channel)
		{
			NotificationManager @object = Java.Lang.Object.GetObject<NotificationManager>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			NotificationChannel object2 = Java.Lang.Object.GetObject<NotificationChannel>(native_channel, JniHandleOwnership.DoNotTransfer);
			@object.CreateNotificationChannel(object2);
		}

		// Token: 0x060017A2 RID: 6050 RVA: 0x0003D664 File Offset: 0x0003B864
		public unsafe virtual void CreateNotificationChannel(NotificationChannel channel)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((channel == null) ? IntPtr.Zero : channel.Handle);
				NotificationManager._members.InstanceMethods.InvokeVirtualVoidMethod("createNotificationChannel.(Landroid/app/NotificationChannel;)V", this, ptr);
			}
			finally
			{
				GC.KeepAlive(channel);
			}
		}

		// Token: 0x04000A0F RID: 2575
		private static readonly JniPeerMembers _members = new XAPeerMembers("android/app/NotificationManager", typeof(NotificationManager));

		// Token: 0x04000A10 RID: 2576
		private static Delegate cb_createNotificationChannel_Landroid_app_NotificationChannel_;
	}
}
