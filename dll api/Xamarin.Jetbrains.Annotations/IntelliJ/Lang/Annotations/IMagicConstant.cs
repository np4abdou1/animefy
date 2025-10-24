using System;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang;
using Java.Lang.Annotation;

namespace IntelliJ.Lang.Annotations
{
	// Token: 0x02000051 RID: 81
	[Register("org/intellij/lang/annotations/MagicConstant", "", "IntelliJ.Lang.Annotations.IMagicConstantInvoker")]
	public interface IMagicConstant : IAnnotation, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x06000270 RID: 624
		[NullableContext(2)]
		[Register("flags", "()[J", "GetFlagsHandler:IntelliJ.Lang.Annotations.IMagicConstantInvoker, Xamarin.Jetbrains.Annotations")]
		long[] Flags();

		// Token: 0x06000271 RID: 625
		[NullableContext(2)]
		[Register("flagsFromClass", "()Ljava/lang/Class;", "GetFlagsFromClassHandler:IntelliJ.Lang.Annotations.IMagicConstantInvoker, Xamarin.Jetbrains.Annotations")]
		Class FlagsFromClass();

		// Token: 0x06000272 RID: 626
		[NullableContext(2)]
		[Register("intValues", "()[J", "GetIntValuesHandler:IntelliJ.Lang.Annotations.IMagicConstantInvoker, Xamarin.Jetbrains.Annotations")]
		long[] IntValues();

		// Token: 0x06000273 RID: 627
		[Register("stringValues", "()[Ljava/lang/String;", "GetStringValuesHandler:IntelliJ.Lang.Annotations.IMagicConstantInvoker, Xamarin.Jetbrains.Annotations")]
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		string[] StringValues();

		// Token: 0x06000274 RID: 628
		[NullableContext(2)]
		[Register("valuesFromClass", "()Ljava/lang/Class;", "GetValuesFromClassHandler:IntelliJ.Lang.Annotations.IMagicConstantInvoker, Xamarin.Jetbrains.Annotations")]
		Class ValuesFromClass();
	}
}
