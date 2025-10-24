using System;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Kotlin.Coroutines;

namespace Xamarin.KotlinX.Coroutines
{
	// Token: 0x02000042 RID: 66
	[Obsolete("This class is obsoleted in this android platform")]
	[Register("kotlinx/coroutines/ChildJob", "", "Xamarin.KotlinX.Coroutines.IChildJobInvoker")]
	public interface IChildJob : IJob, ICoroutineContextElement, ICoroutineContext, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x060001D8 RID: 472
		[NullableContext(1)]
		[Register("parentCancelled", "(Lkotlinx/coroutines/ParentJob;)V", "GetParentCancelled_Lkotlinx_coroutines_ParentJob_Handler:Xamarin.KotlinX.Coroutines.IChildJobInvoker, Xamarin.KotlinX.Coroutines.Core.Jvm")]
		void ParentCancelled(IParentJob parentJob);
	}
}
