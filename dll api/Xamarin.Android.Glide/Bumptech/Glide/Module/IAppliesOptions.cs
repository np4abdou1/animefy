using System;
using Android.Content;
using Android.Runtime;
using Java.Interop;

namespace Bumptech.Glide.Module
{
	// Token: 0x02000067 RID: 103
	[Obsolete("This class is obsoleted in this android platform")]
	[Register("com/bumptech/glide/module/AppliesOptions", "", "Bumptech.Glide.Module.IAppliesOptionsInvoker")]
	public interface IAppliesOptions : IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x060004AA RID: 1194
		[Register("applyOptions", "(Landroid/content/Context;Lcom/bumptech/glide/GlideBuilder;)V", "GetApplyOptions_Landroid_content_Context_Lcom_bumptech_glide_GlideBuilder_Handler:Bumptech.Glide.Module.IAppliesOptionsInvoker, Xamarin.Android.Glide")]
		void ApplyOptions(Context p0, GlideBuilder p1);
	}
}
