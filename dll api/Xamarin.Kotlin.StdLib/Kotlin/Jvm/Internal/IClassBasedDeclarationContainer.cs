using System;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;
using Kotlin.Reflect;

namespace Kotlin.Jvm.Internal
{
	// Token: 0x0200019D RID: 413
	[Register("kotlin/jvm/internal/ClassBasedDeclarationContainer", "", "Kotlin.Jvm.Internal.IClassBasedDeclarationContainerInvoker")]
	public interface IClassBasedDeclarationContainer : IKDeclarationContainer, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x170005C3 RID: 1475
		// (get) Token: 0x06001465 RID: 5221
		[Nullable(1)]
		Class JClass { [NullableContext(1)] [Register("getJClass", "()Ljava/lang/Class;", "GetGetJClassHandler:Kotlin.Jvm.Internal.IClassBasedDeclarationContainerInvoker, Xamarin.Kotlin.StdLib")] get; }
	}
}
