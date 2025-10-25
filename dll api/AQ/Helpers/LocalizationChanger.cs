using System;
using Android.Content;
using Android.Content.Res;
using Android.OS;
using Java.Util;

namespace AQ.Helpers
{
	// Token: 0x02000091 RID: 145
	public class LocalizationChanger
	{
		// Token: 0x0600068F RID: 1679 RVA: 0x000138F8 File Offset: 0x00011AF8
		public static Context UpdateResources(Context context, string language)
		{
			Locale locale = new Locale(language);
			Locale.Default = locale;
			Configuration configuration = new Configuration();
			if (Build.VERSION.SdkInt >= BuildVersionCodes.JellyBeanMr1)
			{
				configuration.SetLocale(locale);
			}
			else
			{
				configuration.Locale = locale;
			}
			if (Build.VERSION.SdkInt >= BuildVersionCodes.N)
			{
				context = context.CreateConfigurationContext(configuration);
			}
			else
			{
				context.Resources.UpdateConfiguration(configuration, context.Resources.DisplayMetrics);
			}
			return context;
		}
	}
}
