using System;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Xamarin.KotlinX.Coroutines
{
	// Token: 0x0200003F RID: 63
	[Obsolete("This class is obsoleted in this android platform")]
	[Register("kotlinx/coroutines/ChildHandle", "", "Xamarin.KotlinX.Coroutines.IChildHandleInvoker")]
	public interface IChildHandle : IDisposableHandle, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x1700009F RID: 159
		// (get) Token: 0x060001B9 RID: 441
		[Nullable(2)]
		IJob Parent { [NullableContext(2)] [Register("getParent", "()Lkotlinx/coroutines/Job;", "GetGetParentHandler:Xamarin.KotlinX.Coroutines.IChildHandleInvoker, Xamarin.KotlinX.Coroutines.Core.Jvm")] get; }

		// Token: 0x060001BA RID: 442
		[NullableContext(1)]
		[Register("childCancelled", "(Ljava/lang/Throwable;)Z", "GetChildCancelled_Ljava_lang_Throwable_Handler:Xamarin.KotlinX.Coroutines.IChildHandleInvoker, Xamarin.KotlinX.Coroutines.Core.Jvm")]
		bool ChildCancelled(Throwable cause);
	}
}
