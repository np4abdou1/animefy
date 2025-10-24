using System;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang.Annotation;

namespace Kotlin.Jvm.Internal
{
	// Token: 0x020001AA RID: 426
	[Register("kotlin/jvm/internal/SerializedIr", "", "Kotlin.Jvm.Internal.ISerializedIrInvoker")]
	public interface ISerializedIr : IAnnotation, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x06001502 RID: 5378
		[Register("b", "()[Ljava/lang/String;", "GetBHandler:Kotlin.Jvm.Internal.ISerializedIrInvoker, Xamarin.Kotlin.StdLib")]
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		string[] B();
	}
}
