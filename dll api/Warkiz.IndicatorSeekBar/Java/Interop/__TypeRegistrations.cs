using System;

namespace Java.Interop
{
	// Token: 0x0200001E RID: 30
	internal class __TypeRegistrations
	{
		// Token: 0x06000195 RID: 405 RVA: 0x00006689 File Offset: 0x00004889
		public static void RegisterPackages()
		{
			TypeManager.RegisterPackages(new string[]
			{
				"com/warkiz/widget"
			}, new Converter<string, Type>[]
			{
				new Converter<string, Type>(__TypeRegistrations.lookup_com_warkiz_widget_package)
			});
		}

		// Token: 0x06000196 RID: 406 RVA: 0x000066B4 File Offset: 0x000048B4
		private static Type Lookup(string[] mappings, string javaType)
		{
			string text = TypeManager.LookupTypeMapping(mappings, javaType);
			if (text == null)
			{
				return null;
			}
			return Type.GetType(text);
		}

		// Token: 0x06000197 RID: 407 RVA: 0x000066D4 File Offset: 0x000048D4
		private static Type lookup_com_warkiz_widget_package(string klass)
		{
			if (__TypeRegistrations.package_com_warkiz_widget_mappings == null)
			{
				__TypeRegistrations.package_com_warkiz_widget_mappings = new string[]
				{
					"com/warkiz/widget/ArrowView:Warkiz.Widgets.ArrowView",
					"com/warkiz/widget/Builder:Warkiz.Widgets.Builder",
					"com/warkiz/widget/CircleBubbleView:Warkiz.Widgets.CircleBubbleView",
					"com/warkiz/widget/Indicator:Warkiz.Widgets.Indicator",
					"com/warkiz/widget/IndicatorSeekBar:Warkiz.Widgets.IndicatorSeekBar",
					"com/warkiz/widget/IndicatorStayLayout:Warkiz.Widgets.IndicatorStayLayout",
					"com/warkiz/widget/SeekParams:Warkiz.Widgets.SeekParams",
					"com/warkiz/widget/SizeUtils:Warkiz.Widgets.SizeUtils"
				};
			}
			return __TypeRegistrations.Lookup(__TypeRegistrations.package_com_warkiz_widget_mappings, klass);
		}

		// Token: 0x04000092 RID: 146
		private static string[] package_com_warkiz_widget_mappings;
	}
}
