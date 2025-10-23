using System;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;
using Java.Util;
using Kotlin.Jvm.Internal.Markers;

namespace Kotlin.Text
{
	// Token: 0x020000E0 RID: 224
	[Register("kotlin/text/MatchGroupCollection", "", "Kotlin.Text.IMatchGroupCollectionInvoker")]
	public interface IMatchGroupCollection : ICollection, IIterable, IJavaObject, IDisposable, IJavaPeerable, IKMappedMarker
	{
		// Token: 0x0600071D RID: 1821
		[NullableContext(2)]
		[Register("get", "(I)Lkotlin/text/MatchGroup;", "GetGet_IHandler:Kotlin.Text.IMatchGroupCollectionInvoker, Xamarin.Kotlin.StdLib")]
		MatchGroup Get(int index);
	}
}
