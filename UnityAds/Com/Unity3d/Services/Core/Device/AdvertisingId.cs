using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Content;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Com.Unity3d.Services.Core.Device
{
	// Token: 0x02000119 RID: 281
	[Register("com/unity3d/services/core/device/AdvertisingId", DoNotGenerateAcw = true)]
	public class AdvertisingId : Java.Lang.Object
	{
		// Token: 0x17000394 RID: 916
		// (get) Token: 0x06000ADF RID: 2783 RVA: 0x0001EF84 File Offset: 0x0001D184
		internal static IntPtr class_ref
		{
			get
			{
				return AdvertisingId._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000395 RID: 917
		// (get) Token: 0x06000AE0 RID: 2784 RVA: 0x0001EFA8 File Offset: 0x0001D1A8
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return AdvertisingId._members;
			}
		}

		// Token: 0x17000396 RID: 918
		// (get) Token: 0x06000AE1 RID: 2785 RVA: 0x0001EFB0 File Offset: 0x0001D1B0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return AdvertisingId._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x17000397 RID: 919
		// (get) Token: 0x06000AE2 RID: 2786 RVA: 0x0001EFD4 File Offset: 0x0001D1D4
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return AdvertisingId._members.ManagedPeerType;
			}
		}

		// Token: 0x06000AE3 RID: 2787 RVA: 0x000021E8 File Offset: 0x000003E8
		protected AdvertisingId(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000AE4 RID: 2788 RVA: 0x0001EFE0 File Offset: 0x0001D1E0
		[Register(".ctor", "()V", "")]
		public AdvertisingId() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			base.SetHandle(AdvertisingId._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
			AdvertisingId._members.InstanceMethods.FinishCreateInstance("()V", this, null);
		}

		// Token: 0x17000398 RID: 920
		// (get) Token: 0x06000AE5 RID: 2789 RVA: 0x0001F050 File Offset: 0x0001D250
		public static string AdvertisingTrackingId
		{
			[Register("getAdvertisingTrackingId", "()Ljava/lang/String;", "")]
			get
			{
				return JNIEnv.GetString(AdvertisingId._members.StaticMethods.InvokeObjectMethod("getAdvertisingTrackingId.()Ljava/lang/String;", null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x17000399 RID: 921
		// (get) Token: 0x06000AE6 RID: 2790 RVA: 0x0001F081 File Offset: 0x0001D281
		public static bool LimitedAdTracking
		{
			[Register("getLimitedAdTracking", "()Z", "")]
			get
			{
				return AdvertisingId._members.StaticMethods.InvokeBooleanMethod("getLimitedAdTracking.()Z", null);
			}
		}

		// Token: 0x06000AE7 RID: 2791 RVA: 0x0001F09C File Offset: 0x0001D29C
		[Register("init", "(Landroid/content/Context;)V", "")]
		public unsafe static void Init(Context context)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((context == null) ? IntPtr.Zero : context.Handle);
				AdvertisingId._members.StaticMethods.InvokeVoidMethod("init.(Landroid/content/Context;)V", ptr);
			}
			finally
			{
				GC.KeepAlive(context);
			}
		}

		// Token: 0x0400028E RID: 654
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/services/core/device/AdvertisingId", typeof(AdvertisingId));
	}
}
