using System;
using Android.Runtime;
using Java.Interop;

namespace Bumptech.Glide.Module
{
	// Token: 0x02000069 RID: 105
	[Obsolete("This class is obsoleted in this android platform")]
	[Register("com/bumptech/glide/module/GlideModule", "", "Bumptech.Glide.Module.IGlideModuleInvoker")]
	public interface IGlideModule : IAppliesOptions, IJavaObject, IDisposable, IJavaPeerable, IRegistersComponents
	{
	}
}
