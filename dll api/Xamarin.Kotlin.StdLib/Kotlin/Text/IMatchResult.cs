using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Kotlin.Ranges;

namespace Kotlin.Text
{
	// Token: 0x020000E6 RID: 230
	[NullableContext(1)]
	[Register("kotlin/text/MatchResult", "", "Kotlin.Text.IMatchResultInvoker")]
	public interface IMatchResult : IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x1700024C RID: 588
		// (get) Token: 0x060007A3 RID: 1955
		MatchResultDestructured Destructured { [Register("getDestructured", "()Lkotlin/text/MatchResult$Destructured;", "GetGetDestructuredHandler:Kotlin.Text.IMatchResultInvoker, Xamarin.Kotlin.StdLib")] get; }

		// Token: 0x1700024D RID: 589
		// (get) Token: 0x060007A4 RID: 1956
		IList<string> GroupValues { [Register("getGroupValues", "()Ljava/util/List;", "GetGetGroupValuesHandler:Kotlin.Text.IMatchResultInvoker, Xamarin.Kotlin.StdLib")] get; }

		// Token: 0x1700024E RID: 590
		// (get) Token: 0x060007A5 RID: 1957
		IMatchGroupCollection Groups { [Register("getGroups", "()Lkotlin/text/MatchGroupCollection;", "GetGetGroupsHandler:Kotlin.Text.IMatchResultInvoker, Xamarin.Kotlin.StdLib")] get; }

		// Token: 0x1700024F RID: 591
		// (get) Token: 0x060007A6 RID: 1958
		IntRange Range { [Register("getRange", "()Lkotlin/ranges/IntRange;", "GetGetRangeHandler:Kotlin.Text.IMatchResultInvoker, Xamarin.Kotlin.StdLib")] get; }

		// Token: 0x17000250 RID: 592
		// (get) Token: 0x060007A7 RID: 1959
		string Value { [Register("getValue", "()Ljava/lang/String;", "GetGetValueHandler:Kotlin.Text.IMatchResultInvoker, Xamarin.Kotlin.StdLib")] get; }

		// Token: 0x060007A8 RID: 1960
		[NullableContext(2)]
		[Register("next", "()Lkotlin/text/MatchResult;", "GetNextHandler:Kotlin.Text.IMatchResultInvoker, Xamarin.Kotlin.StdLib")]
		IMatchResult Next();
	}
}
