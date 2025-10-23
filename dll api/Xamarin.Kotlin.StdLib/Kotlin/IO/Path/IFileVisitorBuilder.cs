using System;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Kotlin.Jvm.Functions;

namespace Kotlin.IO.Path
{
	// Token: 0x0200022F RID: 559
	[NullableContext(1)]
	[Register("kotlin/io/path/FileVisitorBuilder", "", "Kotlin.IO.Path.IFileVisitorBuilderInvoker")]
	public interface IFileVisitorBuilder : IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x060019DD RID: 6621
		[Register("onPostVisitDirectory", "(Lkotlin/jvm/functions/Function2;)V", "GetOnPostVisitDirectory_Lkotlin_jvm_functions_Function2_Handler:Kotlin.IO.Path.IFileVisitorBuilderInvoker, Xamarin.Kotlin.StdLib")]
		void OnPostVisitDirectory(IFunction2 function);

		// Token: 0x060019DE RID: 6622
		[Register("onPreVisitDirectory", "(Lkotlin/jvm/functions/Function2;)V", "GetOnPreVisitDirectory_Lkotlin_jvm_functions_Function2_Handler:Kotlin.IO.Path.IFileVisitorBuilderInvoker, Xamarin.Kotlin.StdLib")]
		void OnPreVisitDirectory(IFunction2 function);

		// Token: 0x060019DF RID: 6623
		[Register("onVisitFile", "(Lkotlin/jvm/functions/Function2;)V", "GetOnVisitFile_Lkotlin_jvm_functions_Function2_Handler:Kotlin.IO.Path.IFileVisitorBuilderInvoker, Xamarin.Kotlin.StdLib")]
		void OnVisitFile(IFunction2 function);

		// Token: 0x060019E0 RID: 6624
		[Register("onVisitFileFailed", "(Lkotlin/jvm/functions/Function2;)V", "GetOnVisitFileFailed_Lkotlin_jvm_functions_Function2_Handler:Kotlin.IO.Path.IFileVisitorBuilderInvoker, Xamarin.Kotlin.StdLib")]
		void OnVisitFileFailed(IFunction2 function);
	}
}
