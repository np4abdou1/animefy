using System;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Kotlin
{
	// Token: 0x0200006B RID: 107
	[Register("kotlin/Lazy", "", "Kotlin.ILazyInvoker")]
	[JavaTypeParameters(new string[]
	{
		"T"
	})]
	public interface ILazy : IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000060 RID: 96
		// (get) Token: 0x06000255 RID: 597
		bool IsInitialized { [Register("isInitialized", "()Z", "GetIsInitializedHandler:Kotlin.ILazyInvoker, Xamarin.Kotlin.StdLib")] get; }

		// Token: 0x17000061 RID: 97
		// (get) Token: 0x06000256 RID: 598
		[Nullable(2)]
		Java.Lang.Object Value { [NullableContext(2)] [Register("getValue", "()Ljava/lang/Object;", "GetGetValueHandler:Kotlin.ILazyInvoker, Xamarin.Kotlin.StdLib")] get; }
	}
}
