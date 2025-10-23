using System;
using System.Runtime.CompilerServices;

namespace Java.Interop
{
	// Token: 0x02000003 RID: 3
	internal class __TypeRegistrations
	{
		// Token: 0x06000006 RID: 6 RVA: 0x0000208A File Offset: 0x0000028A
		public static void RegisterPackages()
		{
			string[] packages = new string[]
			{
				"de/hdodenhof/circleimageview"
			};
			Converter<string, Type>[] array = new Converter<string, Type>[1];
			int num = 0;
			if (__TypeRegistrations.<>f__mg$cache0 == null)
			{
				__TypeRegistrations.<>f__mg$cache0 = new Converter<string, Type>(__TypeRegistrations.lookup_de_hdodenhof_circleimageview_package);
			}
			array[num] = __TypeRegistrations.<>f__mg$cache0;
			TypeManager.RegisterPackages(packages, array);
		}

		// Token: 0x06000007 RID: 7 RVA: 0x000020C8 File Offset: 0x000002C8
		private static Type Lookup(string[] mappings, string javaType)
		{
			string text = TypeManager.LookupTypeMapping(mappings, javaType);
			if (text == null)
			{
				return null;
			}
			return Type.GetType(text);
		}

		// Token: 0x06000008 RID: 8 RVA: 0x000020EB File Offset: 0x000002EB
		private static Type lookup_de_hdodenhof_circleimageview_package(string klass)
		{
			if (__TypeRegistrations.package_de_hdodenhof_circleimageview_mappings == null)
			{
				__TypeRegistrations.package_de_hdodenhof_circleimageview_mappings = new string[]
				{
					"de/hdodenhof/circleimageview/BuildConfig:Refractored.Controls.BuildConfig",
					"de/hdodenhof/circleimageview/CircleImageView:Refractored.Controls._BaseCircleImageView"
				};
			}
			return __TypeRegistrations.Lookup(__TypeRegistrations.package_de_hdodenhof_circleimageview_mappings, klass);
		}

		// Token: 0x04000001 RID: 1
		private static string[] package_de_hdodenhof_circleimageview_mappings;

		// Token: 0x04000002 RID: 2
		[CompilerGenerated]
		private static Converter<string, Type> <>f__mg$cache0;
	}
}
