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
	// Token: 0x02000024 RID: 36
	[Register("androidx/activity/result/ActivityResultRegistry", DoNotGenerateAcw = true)]
	internal class ActivityResultRegistryInvoker : ActivityResultRegistry
	{
		// Token: 0x06000118 RID: 280 RVA: 0x00004C67 File Offset: 0x00002E67
		public ActivityResultRegistryInvoker(IntPtr handle, JniHandleOwnership transfer) : base(handle, transfer)
		{
		}

		// Token: 0x17000046 RID: 70
		// (get) Token: 0x06000119 RID: 281 RVA: 0x00004C71 File Offset: 0x00002E71
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override JniPeerMembers JniPeerMembers
		{
			get
			{
				return ActivityResultRegistryInvoker._members;
			}
		}

		// Token: 0x17000047 RID: 71
		// (get) Token: 0x0600011A RID: 282 RVA: 0x00004C78 File Offset: 0x00002E78
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override Type ThresholdType
		{
			get
			{
				return ActivityResultRegistryInvoker._members.ManagedPeerType;
			}
		}

		// Token: 0x0600011B RID: 283 RVA: 0x00004C84 File Offset: 0x00002E84
		[Register("onLaunch", "(ILandroidx/activity/result/contract/ActivityResultContract;Ljava/lang/Object;Landroidx/core/app/ActivityOptionsCompat;)V", "GetOnLaunch_ILandroidx_activity_result_contract_ActivityResultContract_Ljava_lang_Object_Landroidx_core_app_ActivityOptionsCompat_Handler")]
		[JavaTypeParameters(new string[]
		{
			"I",
			"O"
		})]
		public unsafe override void OnLaunch(int p0, ActivityResultContract p1, Java.Lang.Object p2, ActivityOptionsCompat p3)
		{
			IntPtr intPtr = JNIEnv.ToLocalJniHandle(p2);
			try
			{
				JniArgumentValue* ptr = stackalloc JniArgumentValue[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(JniArgumentValue))];
				*ptr = new JniArgumentValue(p0);
				ptr[1] = new JniArgumentValue((p1 == null) ? IntPtr.Zero : p1.Handle);
				ptr[2] = new JniArgumentValue(intPtr);
				ptr[3] = new JniArgumentValue((p3 == null) ? IntPtr.Zero : p3.Handle);
				ActivityResultRegistryInvoker._members.InstanceMethods.InvokeAbstractVoidMethod("onLaunch.(ILandroidx/activity/result/contract/ActivityResultContract;Ljava/lang/Object;Landroidx/core/app/ActivityOptionsCompat;)V", this, ptr);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(intPtr);
				GC.KeepAlive(p1);
				GC.KeepAlive(p2);
				GC.KeepAlive(p3);
			}
		}

		// Token: 0x0400003F RID: 63
		private static readonly JniPeerMembers _members = new XAPeerMembers("androidx/activity/result/ActivityResultRegistry", typeof(ActivityResultRegistryInvoker));
	}
}
