using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Content;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Com.Unity3d.Services.Core.Device
{
	// Token: 0x02000120 RID: 288
	[Register("com/unity3d/services/core/device/OpenAdvertisingId", DoNotGenerateAcw = true)]
	public class OpenAdvertisingId : Java.Lang.Object
	{
		// Token: 0x170003F0 RID: 1008
		// (get) Token: 0x06000B61 RID: 2913 RVA: 0x00020444 File Offset: 0x0001E644
		internal static IntPtr class_ref
		{
			get
			{
				return OpenAdvertisingId._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170003F1 RID: 1009
		// (get) Token: 0x06000B62 RID: 2914 RVA: 0x00020468 File Offset: 0x0001E668
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return OpenAdvertisingId._members;
			}
		}

		// Token: 0x170003F2 RID: 1010
		// (get) Token: 0x06000B63 RID: 2915 RVA: 0x00020470 File Offset: 0x0001E670
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get
			{
				return OpenAdvertisingId._members.JniPeerType.PeerReference.Handle;
			}
		}

		// Token: 0x170003F3 RID: 1011
		// (get) Token: 0x06000B64 RID: 2916 RVA: 0x00020494 File Offset: 0x0001E694
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return OpenAdvertisingId._members.ManagedPeerType;
			}
		}

		// Token: 0x06000B65 RID: 2917 RVA: 0x000021E8 File Offset: 0x000003E8
		protected OpenAdvertisingId(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Token: 0x06000B66 RID: 2918 RVA: 0x000204A0 File Offset: 0x0001E6A0
		[Register(".ctor", "()V", "")]
		public OpenAdvertisingId() : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (base.Handle != IntPtr.Zero)
			{
				return;
			}
			base.SetHandle(OpenAdvertisingId._members.InstanceMethods.StartCreateInstance("()V", base.GetType(), null).Handle, JniHandleOwnership.TransferLocalRef);
			OpenAdvertisingId._members.InstanceMethods.FinishCreateInstance("()V", this, null);
		}

		// Token: 0x170003F4 RID: 1012
		// (get) Token: 0x06000B67 RID: 2919 RVA: 0x0002050E File Offset: 0x0001E70E
		public static bool LimitedOpenAdTracking
		{
			[Register("getLimitedOpenAdTracking", "()Z", "")]
			get
			{
				return OpenAdvertisingId._members.StaticMethods.InvokeBooleanMethod("getLimitedOpenAdTracking.()Z", null);
			}
		}

		// Token: 0x170003F5 RID: 1013
		// (get) Token: 0x06000B68 RID: 2920 RVA: 0x00020528 File Offset: 0x0001E728
		public static string OpenAdvertisingTrackingId
		{
			[Register("getOpenAdvertisingTrackingId", "()Ljava/lang/String;", "")]
			get
			{
				return JNIEnv.GetString(OpenAdvertisingId._members.StaticMethods.InvokeObjectMethod("getOpenAdvertisingTrackingId.()Ljava/lang/String;", null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06000B69 RID: 2921 RVA: 0x0002055C File Offset: 0x0001E75C
		[Register("init", "(Landroid/content/Context;)V", "")]
		public unsafe static void Init(Context context)
		{
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue((context == null) ? IntPtr.Zero : context.Handle);
				OpenAdvertisingId._members.StaticMethods.InvokeVoidMethod("init.(Landroid/content/Context;)V", ptr);
			}
			finally
			{
				GC.KeepAlive(context);
			}
		}

		// Token: 0x0400029E RID: 670
		private static readonly JniPeerMembers _members = new XAPeerMembers("com/unity3d/services/core/device/OpenAdvertisingId", typeof(OpenAdvertisingId));
	}
}
