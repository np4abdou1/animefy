using System;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang.Annotation;

namespace Kotlin
{
	// Token: 0x0200006E RID: 110
	[Register("kotlin/Metadata", "", "Kotlin.IMetadataInvoker")]
	public interface IMetadata : IAnnotation, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x0600026C RID: 620
		[NullableContext(2)]
		[Obsolete("deprecated")]
		[Register("bv", "()[I", "GetBvHandler:Kotlin.IMetadataInvoker, Xamarin.Kotlin.StdLib")]
		int[] Bv();

		// Token: 0x0600026D RID: 621
		[Register("d1", "()[Ljava/lang/String;", "GetD1Handler:Kotlin.IMetadataInvoker, Xamarin.Kotlin.StdLib")]
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		string[] D1();

		// Token: 0x0600026E RID: 622
		[Register("d2", "()[Ljava/lang/String;", "GetD2Handler:Kotlin.IMetadataInvoker, Xamarin.Kotlin.StdLib")]
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		string[] D2();

		// Token: 0x0600026F RID: 623
		[Register("k", "()I", "GetKHandler:Kotlin.IMetadataInvoker, Xamarin.Kotlin.StdLib")]
		int K();

		// Token: 0x06000270 RID: 624
		[NullableContext(2)]
		[Register("mv", "()[I", "GetMvHandler:Kotlin.IMetadataInvoker, Xamarin.Kotlin.StdLib")]
		int[] Mv();

		// Token: 0x06000271 RID: 625
		[NullableContext(2)]
		[Register("pn", "()Ljava/lang/String;", "GetPnHandler:Kotlin.IMetadataInvoker, Xamarin.Kotlin.StdLib")]
		string Pn();

		// Token: 0x06000272 RID: 626
		[Register("xi", "()I", "GetXiHandler:Kotlin.IMetadataInvoker, Xamarin.Kotlin.StdLib")]
		int Xi();

		// Token: 0x06000273 RID: 627
		[NullableContext(2)]
		[Register("xs", "()Ljava/lang/String;", "GetXsHandler:Kotlin.IMetadataInvoker, Xamarin.Kotlin.StdLib")]
		string Xs();
	}
}
