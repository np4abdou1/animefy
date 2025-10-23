using System;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;
using Java.Util;

namespace Kotlin.Collections
{
	// Token: 0x020002C9 RID: 713
	[Register("kotlin/collections/Grouping", "", "Kotlin.Collections.IGroupingInvoker")]
	[JavaTypeParameters(new string[]
	{
		"T",
		"K"
	})]
	public interface IGrouping : IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x06002776 RID: 10102
		[NullableContext(2)]
		[Register("keyOf", "(Ljava/lang/Object;)Ljava/lang/Object;", "GetKeyOf_Ljava_lang_Object_Handler:Kotlin.Collections.IGroupingInvoker, Xamarin.Kotlin.StdLib")]
		Java.Lang.Object KeyOf(Java.Lang.Object element);

		// Token: 0x06002777 RID: 10103
		[NullableContext(1)]
		[Register("sourceIterator", "()Ljava/util/Iterator;", "GetSourceIteratorHandler:Kotlin.Collections.IGroupingInvoker, Xamarin.Kotlin.StdLib")]
		IIterator SourceIterator();
	}
}
