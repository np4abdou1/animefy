using System;
using Android.Runtime;
using Android.Text;
using Java.Interop;

namespace Google.Android.Material.Internal
{
	// Token: 0x02000094 RID: 148
	[Register("com/google/android/material/internal/StaticLayoutBuilderConfigurer", "", "Google.Android.Material.Internal.IStaticLayoutBuilderConfigurerInvoker")]
	public interface IStaticLayoutBuilderConfigurer : IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x06000A17 RID: 2583
		[Register("configure", "(Landroid/text/StaticLayout$Builder;)V", "GetConfigure_Landroid_text_StaticLayout_Builder_Handler:Google.Android.Material.Internal.IStaticLayoutBuilderConfigurerInvoker, Xamarin.Google.Android.Material")]
		void Configure(StaticLayout.Builder p0);
	}
}
