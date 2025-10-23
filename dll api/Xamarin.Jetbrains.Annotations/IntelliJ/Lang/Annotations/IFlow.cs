using System;
using System.Runtime.CompilerServices;
using Android.Runtime;
using Java.Interop;
using Java.Lang.Annotation;

namespace IntelliJ.Lang.Annotations
{
	// Token: 0x0200004B RID: 75
	[Register("org/intellij/lang/annotations/Flow", "", "IntelliJ.Lang.Annotations.IFlowInvoker")]
	public interface IFlow : IAnnotation, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x06000215 RID: 533
		[NullableContext(2)]
		[Register("source", "()Ljava/lang/String;", "GetSourceHandler:IntelliJ.Lang.Annotations.IFlowInvoker, Xamarin.Jetbrains.Annotations")]
		string Source();

		// Token: 0x06000216 RID: 534
		[Register("sourceIsContainer", "()Z", "GetSourceIsContainerHandler:IntelliJ.Lang.Annotations.IFlowInvoker, Xamarin.Jetbrains.Annotations")]
		bool SourceIsContainer();

		// Token: 0x06000217 RID: 535
		[NullableContext(2)]
		[Register("target", "()Ljava/lang/String;", "GetTargetHandler:IntelliJ.Lang.Annotations.IFlowInvoker, Xamarin.Jetbrains.Annotations")]
		string Target();

		// Token: 0x06000218 RID: 536
		[Register("targetIsContainer", "()Z", "GetTargetIsContainerHandler:IntelliJ.Lang.Annotations.IFlowInvoker, Xamarin.Jetbrains.Annotations")]
		bool TargetIsContainer();
	}
}
