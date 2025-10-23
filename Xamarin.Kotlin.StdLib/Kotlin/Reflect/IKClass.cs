using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Kotlin.Reflect
{
	// Token: 0x02000102 RID: 258
	[NullableContext(1)]
	[Register("kotlin/reflect/KClass", "", "Kotlin.Reflect.IKClassInvoker")]
	[JavaTypeParameters(new string[]
	{
		"T"
	})]
	public interface IKClass : IKAnnotatedElement, IJavaObject, IDisposable, IJavaPeerable, IKClassifier, IKDeclarationContainer
	{
		// Token: 0x170002D9 RID: 729
		// (get) Token: 0x06000B37 RID: 2871
		ICollection<IKFunction> Constructors { [Register("getConstructors", "()Ljava/util/Collection;", "GetGetConstructorsHandler:Kotlin.Reflect.IKClassInvoker, Xamarin.Kotlin.StdLib")] get; }

		// Token: 0x170002DA RID: 730
		// (get) Token: 0x06000B38 RID: 2872
		bool IsAbstract { [Register("isAbstract", "()Z", "GetIsAbstractHandler:Kotlin.Reflect.IKClassInvoker, Xamarin.Kotlin.StdLib")] get; }

		// Token: 0x170002DB RID: 731
		// (get) Token: 0x06000B39 RID: 2873
		bool IsCompanion { [Register("isCompanion", "()Z", "GetIsCompanionHandler:Kotlin.Reflect.IKClassInvoker, Xamarin.Kotlin.StdLib")] get; }

		// Token: 0x170002DC RID: 732
		// (get) Token: 0x06000B3A RID: 2874
		bool IsData { [Register("isData", "()Z", "GetIsDataHandler:Kotlin.Reflect.IKClassInvoker, Xamarin.Kotlin.StdLib")] get; }

		// Token: 0x170002DD RID: 733
		// (get) Token: 0x06000B3B RID: 2875
		bool IsFinal { [Register("isFinal", "()Z", "GetIsFinalHandler:Kotlin.Reflect.IKClassInvoker, Xamarin.Kotlin.StdLib")] get; }

		// Token: 0x170002DE RID: 734
		// (get) Token: 0x06000B3C RID: 2876
		bool IsFun { [Register("isFun", "()Z", "GetIsFunHandler:Kotlin.Reflect.IKClassInvoker, Xamarin.Kotlin.StdLib")] get; }

		// Token: 0x170002DF RID: 735
		// (get) Token: 0x06000B3D RID: 2877
		bool IsInner { [Register("isInner", "()Z", "GetIsInnerHandler:Kotlin.Reflect.IKClassInvoker, Xamarin.Kotlin.StdLib")] get; }

		// Token: 0x170002E0 RID: 736
		// (get) Token: 0x06000B3E RID: 2878
		bool IsOpen { [Register("isOpen", "()Z", "GetIsOpenHandler:Kotlin.Reflect.IKClassInvoker, Xamarin.Kotlin.StdLib")] get; }

		// Token: 0x170002E1 RID: 737
		// (get) Token: 0x06000B3F RID: 2879
		bool IsSealed { [Register("isSealed", "()Z", "GetIsSealedHandler:Kotlin.Reflect.IKClassInvoker, Xamarin.Kotlin.StdLib")] get; }

		// Token: 0x170002E2 RID: 738
		// (get) Token: 0x06000B40 RID: 2880
		bool IsValue { [Register("isValue", "()Z", "GetIsValueHandler:Kotlin.Reflect.IKClassInvoker, Xamarin.Kotlin.StdLib")] get; }

		// Token: 0x170002E3 RID: 739
		// (get) Token: 0x06000B41 RID: 2881
		ICollection<IKCallable> Members { [Register("getMembers", "()Ljava/util/Collection;", "GetGetMembersHandler:Kotlin.Reflect.IKClassInvoker, Xamarin.Kotlin.StdLib")] get; }

		// Token: 0x170002E4 RID: 740
		// (get) Token: 0x06000B42 RID: 2882
		ICollection<IKClass> NestedClasses { [Register("getNestedClasses", "()Ljava/util/Collection;", "GetGetNestedClassesHandler:Kotlin.Reflect.IKClassInvoker, Xamarin.Kotlin.StdLib")] get; }

		// Token: 0x170002E5 RID: 741
		// (get) Token: 0x06000B43 RID: 2883
		[Nullable(2)]
		Java.Lang.Object ObjectInstance { [NullableContext(2)] [Register("getObjectInstance", "()Ljava/lang/Object;", "GetGetObjectInstanceHandler:Kotlin.Reflect.IKClassInvoker, Xamarin.Kotlin.StdLib")] get; }

		// Token: 0x170002E6 RID: 742
		// (get) Token: 0x06000B44 RID: 2884
		[Nullable(2)]
		string QualifiedName { [NullableContext(2)] [Register("getQualifiedName", "()Ljava/lang/String;", "GetGetQualifiedNameHandler:Kotlin.Reflect.IKClassInvoker, Xamarin.Kotlin.StdLib")] get; }

		// Token: 0x170002E7 RID: 743
		// (get) Token: 0x06000B45 RID: 2885
		IList<IKClass> SealedSubclasses { [Register("getSealedSubclasses", "()Ljava/util/List;", "GetGetSealedSubclassesHandler:Kotlin.Reflect.IKClassInvoker, Xamarin.Kotlin.StdLib")] get; }

		// Token: 0x170002E8 RID: 744
		// (get) Token: 0x06000B46 RID: 2886
		[Nullable(2)]
		string SimpleName { [NullableContext(2)] [Register("getSimpleName", "()Ljava/lang/String;", "GetGetSimpleNameHandler:Kotlin.Reflect.IKClassInvoker, Xamarin.Kotlin.StdLib")] get; }

		// Token: 0x170002E9 RID: 745
		// (get) Token: 0x06000B47 RID: 2887
		IList<IKType> Supertypes { [Register("getSupertypes", "()Ljava/util/List;", "GetGetSupertypesHandler:Kotlin.Reflect.IKClassInvoker, Xamarin.Kotlin.StdLib")] get; }

		// Token: 0x170002EA RID: 746
		// (get) Token: 0x06000B48 RID: 2888
		IList<IKTypeParameter> TypeParameters { [Register("getTypeParameters", "()Ljava/util/List;", "GetGetTypeParametersHandler:Kotlin.Reflect.IKClassInvoker, Xamarin.Kotlin.StdLib")] get; }

		// Token: 0x170002EB RID: 747
		// (get) Token: 0x06000B49 RID: 2889
		[Nullable(2)]
		KVisibility Visibility { [NullableContext(2)] [Register("getVisibility", "()Lkotlin/reflect/KVisibility;", "GetGetVisibilityHandler:Kotlin.Reflect.IKClassInvoker, Xamarin.Kotlin.StdLib")] get; }

		// Token: 0x06000B4A RID: 2890
		[NullableContext(2)]
		[Register("equals", "(Ljava/lang/Object;)Z", "GetEquals_Ljava_lang_Object_Handler:Kotlin.Reflect.IKClassInvoker, Xamarin.Kotlin.StdLib")]
		bool Equals(Java.Lang.Object other);

		// Token: 0x06000B4B RID: 2891
		[Register("hashCode", "()I", "GetGetHashCodeHandler:Kotlin.Reflect.IKClassInvoker, Xamarin.Kotlin.StdLib")]
		int GetHashCode();

		// Token: 0x06000B4C RID: 2892
		[NullableContext(2)]
		[Register("isInstance", "(Ljava/lang/Object;)Z", "GetIsInstance_Ljava_lang_Object_Handler:Kotlin.Reflect.IKClassInvoker, Xamarin.Kotlin.StdLib")]
		bool IsInstance(Java.Lang.Object value);
	}
}
