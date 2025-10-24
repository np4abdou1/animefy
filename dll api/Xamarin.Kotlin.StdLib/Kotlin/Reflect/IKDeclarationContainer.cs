using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;

namespace Kotlin.Reflect
{
	// Token: 0x02000106 RID: 262
	[Register("kotlin/reflect/KDeclarationContainer", "", "Kotlin.Reflect.IKDeclarationContainerInvoker")]
	public interface IKDeclarationContainer : IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000308 RID: 776
		// (get) Token: 0x06000BA4 RID: 2980
		[Nullable(1)]
		ICollection<IKCallable> Members { [NullableContext(1)] [Register("getMembers", "()Ljava/util/Collection;", "GetGetMembersHandler:Kotlin.Reflect.IKDeclarationContainerInvoker, Xamarin.Kotlin.StdLib")] get; }
	}
}
