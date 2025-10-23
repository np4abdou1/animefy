using System;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;
using Java.Util;
using Kotlin.Jvm.Internal.Markers;

namespace Kotlin.Text
{
	// Token: 0x020000E2 RID: 226
	[Register("kotlin/text/MatchNamedGroupCollection", "", "Kotlin.Text.IMatchNamedGroupCollectionInvoker")]
	public interface IMatchNamedGroupCollection : IMatchGroupCollection, ICollection, IIterable, IJavaObject, IDisposable, IJavaPeerable, IKMappedMarker
	{
		// Token: 0x06000757 RID: 1879
		[NullableContext(1)]
		[Register("get", "(Ljava/lang/String;)Lkotlin/text/MatchGroup;", "GetGet_Ljava_lang_String_Handler:Kotlin.Text.IMatchNamedGroupCollectionInvoker, Xamarin.Kotlin.StdLib")]
		[return: Nullable(2)]
		MatchGroup Get(string name);
	}
}
