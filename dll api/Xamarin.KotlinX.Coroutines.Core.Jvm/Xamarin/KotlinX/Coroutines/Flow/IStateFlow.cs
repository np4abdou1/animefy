using System;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Xamarin.KotlinX.Coroutines.Flow
{
	// Token: 0x020000B8 RID: 184
	[Register("kotlinx/coroutines/flow/StateFlow", "", "Xamarin.KotlinX.Coroutines.Flow.IStateFlowInvoker")]
	[JavaTypeParameters(new string[]
	{
		"T"
	})]
	public interface IStateFlow : ISharedFlow, IFlow, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x1700026B RID: 619
		// (get) Token: 0x06000863 RID: 2147
		[Nullable(2)]
		Java.Lang.Object Value { [NullableContext(2)] [Register("getValue", "()Ljava/lang/Object;", "GetGetValueHandler:Xamarin.KotlinX.Coroutines.Flow.IStateFlowInvoker, Xamarin.KotlinX.Coroutines.Core.Jvm")] get; }
	}
}
