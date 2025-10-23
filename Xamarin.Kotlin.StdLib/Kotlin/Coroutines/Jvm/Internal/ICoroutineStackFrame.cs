using System;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Kotlin.Coroutines.Jvm.Internal
{
	// Token: 0x02000267 RID: 615
	[NullableContext(2)]
	[Register("kotlin/coroutines/jvm/internal/CoroutineStackFrame", "", "Kotlin.Coroutines.Jvm.Internal.ICoroutineStackFrameInvoker")]
	public interface ICoroutineStackFrame : IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000816 RID: 2070
		// (get) Token: 0x06001C16 RID: 7190
		ICoroutineStackFrame CallerFrame { [Register("getCallerFrame", "()Lkotlin/coroutines/jvm/internal/CoroutineStackFrame;", "GetGetCallerFrameHandler:Kotlin.Coroutines.Jvm.Internal.ICoroutineStackFrameInvoker, Xamarin.Kotlin.StdLib")] get; }

		// Token: 0x17000817 RID: 2071
		// (get) Token: 0x06001C17 RID: 7191
		StackTraceElement StackTraceElement { [Register("getStackTraceElement", "()Ljava/lang/StackTraceElement;", "GetGetStackTraceElementHandler:Kotlin.Coroutines.Jvm.Internal.ICoroutineStackFrameInvoker, Xamarin.Kotlin.StdLib")] get; }
	}
}
