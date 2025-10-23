using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Android.Gms.Common.Apis.Internal
{
	// Token: 0x02000022 RID: 34
	[Register("com/google/android/gms/common/api/internal/LifecycleFragment", "", "Android.Gms.Common.Apis.Internal.ILifecycleFragmentInvoker")]
	public interface ILifecycleFragment : IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000054 RID: 84
		// (get) Token: 0x060000F4 RID: 244
		bool IsCreated { [Register("isCreated", "()Z", "GetIsCreatedHandler:Android.Gms.Common.Apis.Internal.ILifecycleFragmentInvoker, Xamarin.GooglePlayServices.Basement")] get; }

		// Token: 0x17000055 RID: 85
		// (get) Token: 0x060000F5 RID: 245
		bool IsStarted { [Register("isStarted", "()Z", "GetIsStartedHandler:Android.Gms.Common.Apis.Internal.ILifecycleFragmentInvoker, Xamarin.GooglePlayServices.Basement")] get; }

		// Token: 0x17000056 RID: 86
		// (get) Token: 0x060000F6 RID: 246
		Activity LifecycleActivity { [Register("getLifecycleActivity", "()Landroid/app/Activity;", "GetGetLifecycleActivityHandler:Android.Gms.Common.Apis.Internal.ILifecycleFragmentInvoker, Xamarin.GooglePlayServices.Basement")] get; }

		// Token: 0x060000F7 RID: 247
		[Register("addCallback", "(Ljava/lang/String;Lcom/google/android/gms/common/api/internal/LifecycleCallback;)V", "GetAddCallback_Ljava_lang_String_Lcom_google_android_gms_common_api_internal_LifecycleCallback_Handler:Android.Gms.Common.Apis.Internal.ILifecycleFragmentInvoker, Xamarin.GooglePlayServices.Basement")]
		void AddCallback(string p0, LifecycleCallback p1);

		// Token: 0x060000F8 RID: 248
		[Register("getCallbackOrNull", "(Ljava/lang/String;Ljava/lang/Class;)Lcom/google/android/gms/common/api/internal/LifecycleCallback;", "GetGetCallbackOrNull_Ljava_lang_String_Ljava_lang_Class_Handler:Android.Gms.Common.Apis.Internal.ILifecycleFragmentInvoker, Xamarin.GooglePlayServices.Basement")]
		[JavaTypeParameters(new string[]
		{
			"T extends com.google.android.gms.common.api.internal.LifecycleCallback"
		})]
		Java.Lang.Object GetCallbackOrNull(string p0, Class p1);

		// Token: 0x060000F9 RID: 249
		[Register("startActivityForResult", "(Landroid/content/Intent;I)V", "GetStartActivityForResult_Landroid_content_Intent_IHandler:Android.Gms.Common.Apis.Internal.ILifecycleFragmentInvoker, Xamarin.GooglePlayServices.Basement")]
		void StartActivityForResult(Intent p0, int p1);
	}
}
