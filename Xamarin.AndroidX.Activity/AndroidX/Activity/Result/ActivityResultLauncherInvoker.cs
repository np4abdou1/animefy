using System;
using System.ComponentModel;
using System.Diagnostics;
using Android.Runtime;
using AndroidX.Activity.Result.Contract;
using AndroidX.Core.App;
using Java.Interop;
using Java.Lang;

namespace AndroidX.Activity.Result
{
	// Token: 0x02000022 RID: 34
	[Register("androidx/activity/result/ActivityResultLauncher", DoNotGenerateAcw = true)]
	internal class ActivityResultLauncherInvoker : ActivityResultLauncher
	{
		// Token: 0x06000101 RID: 257 RVA: 0x00004686 File Offset: 0x00002886
		public ActivityResultLauncherInvoker(IntPtr handle, JniHandleOwnership transfer) : base(handle, transfer)
		{
		}

		// Token: 0x1700003F RID: 63
		// (get) Token: 0x06000102 RID: 258 RVA: 0x00004690 File Offset: 0x00002890
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return ActivityResultLauncherInvoker._members;
			}
		}

		// Token: 0x17000040 RID: 64
		// (get) Token: 0x06000103 RID: 259 RVA: 0x00004697 File Offset: 0x00002897
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return ActivityResultLauncherInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x17000041 RID: 65
		// (get) Token: 0x06000104 RID: 260 RVA: 0x000046A4 File Offset: 0x000028A4
		protected override ActivityResultContract RawContract
		{
			[Register("getContract", "()Landroidx/activity/result/contract/ActivityResultContract;", "GetGetContractHandler")]
			get
			{
				return Java.Lang.Object.GetObject<ActivityResultContract>(ActivityResultLauncherInvoker._members.InstanceMethods.InvokeAbstractObjectMethod("getContract.()Landroidx/activity/result/contract/ActivityResultContract;", this, null).Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Token: 0x06000105 RID: 261 RVA: 0x000046D8 File Offset: 0x000028D8
		[Register("launch", "(Ljava/lang/Object;Landroidx/core/app/ActivityOptionsCompat;)V", "GetLaunch_Ljava_lang_Object_Landroidx_core_app_ActivityOptionsCompat_Handler")]
		public unsafe override void Launch(Java.Lang.Object p0, ActivityOptionsCompat p1)
		{
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(p0);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(intPtr);
				ptr[1] = new JniArgumentValue((p1 == null) ? IntPtr.Zero : p1.Handle);
				ActivityResultLauncherInvoker._members.InstanceMethods.InvokeAbstractVoidMethod("launch.(Ljava/lang/Object;Landroidx/core/app/ActivityOptionsCompat;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(p0);
				GC.KeepAlive(p1);
			}
		}

		// Token: 0x06000106 RID: 262 RVA: 0x00004764 File Offset: 0x00002964
		[Register("unregister", "()V", "GetUnregisterHandler")]
		public override void Unregister()
		{
			ActivityResultLauncherInvoker._members.InstanceMethods.InvokeAbstractVoidMethod("unregister.()V", this, null);
		}

		// Token: 0x0400003C RID: 60
		private static readonly JniPeerMembers _members = new XAPeerMembers("androidx/activity/result/ActivityResultLauncher", typeof(ActivityResultLauncherInvoker));
	}
}
