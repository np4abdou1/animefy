using System;
using Android.Runtime;
using Java.Interop;
using Java.Lang.Annotation;

namespace Xamarin.KotlinX.Coroutines
{
	// Token: 0x02000063 RID: 99
	[Register("kotlinx/coroutines/FlowPreview", "", "Xamarin.KotlinX.Coroutines.IFlowPreviewInvoker")]
	public interface IFlowPreview : IAnnotation, IJavaObject, IDisposable, IJavaPeerable
	{
	}
}
