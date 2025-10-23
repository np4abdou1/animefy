using System;
using Android.Content;
using Android.Runtime;
using Java.Interop;

namespace Bumptech.Glide.Module
{
	// Token: 0x0200006B RID: 107
	[Obsolete("This class is obsoleted in this android platform")]
	[Register("com/bumptech/glide/module/RegistersComponents", "", "Bumptech.Glide.Module.IRegistersComponentsInvoker")]
	public interface IRegistersComponents : IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x060004C6 RID: 1222
		[Register("registerComponents", "(Landroid/content/Context;Lcom/bumptech/glide/Glide;Lcom/bumptech/glide/Registry;)V", "GetRegisterComponents_Landroid_content_Context_Lcom_bumptech_glide_Glide_Lcom_bumptech_glide_Registry_Handler:Bumptech.Glide.Module.IRegistersComponentsInvoker, Xamarin.Android.Glide")]
		void RegisterComponents(Context p0, Glide p1, Registry p2);
	}
}
