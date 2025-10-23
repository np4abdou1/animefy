using System;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang.Reflect;
using Kotlin.Reflect;

namespace Kotlin.Jvm.Internal
{
	// Token: 0x020001A3 RID: 419
	[Register("kotlin/jvm/internal/KTypeBase", "", "Kotlin.Jvm.Internal.IKTypeBaseInvoker")]
	public interface IKTypeBase : IKType, IKAnnotatedElement, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x170005D6 RID: 1494
		// (get) Token: 0x0600148F RID: 5263
		[Nullable(2)]
		IType JavaType { [NullableContext(2)] [Register("getJavaType", "()Ljava/lang/reflect/Type;", "GetGetJavaTypeHandler:Kotlin.Jvm.Internal.IKTypeBaseInvoker, Xamarin.Kotlin.StdLib")] get; }
	}
}
