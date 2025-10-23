using System;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Xamarin.KotlinX.Coroutines
{
	// Token: 0x0200004D RID: 77
	[Register("kotlinx/coroutines/CopyableThrowable", "", "Xamarin.KotlinX.Coroutines.ICopyableThrowableInvoker")]
	[JavaTypeParameters(new string[]
	{
		"T extends java.lang.Throwable & kotlinx.coroutines.CopyableThrowable<T>"
	})]
	public interface ICopyableThrowable : IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x06000304 RID: 772
		[NullableContext(2)]
		[Register("createCopy", "()Ljava/lang/Throwable;", "GetCreateCopyHandler:Xamarin.KotlinX.Coroutines.ICopyableThrowableInvoker, Xamarin.KotlinX.Coroutines.Core.Jvm")]
		Java.Lang.Object CreateCopy();
	}
}
