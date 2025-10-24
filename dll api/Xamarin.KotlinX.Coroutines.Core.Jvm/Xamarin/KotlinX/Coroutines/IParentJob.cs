using System;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Util.Concurrent;
using Kotlin.Coroutines;

namespace Xamarin.KotlinX.Coroutines
{
	// Token: 0x02000072 RID: 114
	[Obsolete("This class is obsoleted in this android platform")]
	[Register("kotlinx/coroutines/ParentJob", "", "Xamarin.KotlinX.Coroutines.IParentJobInvoker")]
	public interface IParentJob : IJob, ICoroutineContextElement, ICoroutineContext, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000151 RID: 337
		// (get) Token: 0x060004B4 RID: 1204
		[Nullable(1)]
		CancellationException ChildJobCancellationCause { [NullableContext(1)] [Register("getChildJobCancellationCause", "()Ljava/util/concurrent/CancellationException;", "GetGetChildJobCancellationCauseHandler:Xamarin.KotlinX.Coroutines.IParentJobInvoker, Xamarin.KotlinX.Coroutines.Core.Jvm")] get; }
	}
}
