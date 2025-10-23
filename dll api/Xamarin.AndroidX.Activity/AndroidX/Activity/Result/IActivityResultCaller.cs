using System;
using Android.Runtime;
using AndroidX.Activity.Result.Contract;
using Java.Interop;

namespace AndroidX.Activity.Result
{
	// Token: 0x02000027 RID: 39
	[Register("androidx/activity/result/ActivityResultCaller", "", "AndroidX.Activity.Result.IActivityResultCallerInvoker")]
	public interface IActivityResultCaller : IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x0600012A RID: 298
		[Register("registerForActivityResult", "(Landroidx/activity/result/contract/ActivityResultContract;Landroidx/activity/result/ActivityResultCallback;)Landroidx/activity/result/ActivityResultLauncher;", "GetRegisterForActivityResult_Landroidx_activity_result_contract_ActivityResultContract_Landroidx_activity_result_ActivityResultCallback_Handler:AndroidX.Activity.Result.IActivityResultCallerInvoker, Xamarin.AndroidX.Activity")]
		[JavaTypeParameters(new string[]
		{
			"I",
			"O"
		})]
		ActivityResultLauncher RegisterForActivityResult(ActivityResultContract p0, IActivityResultCallback p1);

		// Token: 0x0600012B RID: 299
		[Register("registerForActivityResult", "(Landroidx/activity/result/contract/ActivityResultContract;Landroidx/activity/result/ActivityResultRegistry;Landroidx/activity/result/ActivityResultCallback;)Landroidx/activity/result/ActivityResultLauncher;", "GetRegisterForActivityResult_Landroidx_activity_result_contract_ActivityResultContract_Landroidx_activity_result_ActivityResultRegistry_Landroidx_activity_result_ActivityResultCallback_Handler:AndroidX.Activity.Result.IActivityResultCallerInvoker, Xamarin.AndroidX.Activity")]
		[JavaTypeParameters(new string[]
		{
			"I",
			"O"
		})]
		ActivityResultLauncher RegisterForActivityResult(ActivityResultContract p0, ActivityResultRegistry p1, IActivityResultCallback p2);
	}
}
