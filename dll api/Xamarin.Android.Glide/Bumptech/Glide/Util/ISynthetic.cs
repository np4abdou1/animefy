using System;
using Android.Runtime;
using Java.Interop;
using Java.Lang.Annotation;

namespace Bumptech.Glide.Util
{
	// Token: 0x0200004C RID: 76
	[Register("com/bumptech/glide/util/Synthetic", "", "Bumptech.Glide.Util.ISyntheticInvoker")]
	public interface ISynthetic : IAnnotation, IJavaObject, IDisposable, IJavaPeerable
	{
	}
}
