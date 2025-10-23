using System;

namespace Java.Interop
{
	// Token: 0x02000055 RID: 85
	internal class __TypeRegistrations
	{
		// Token: 0x060002C6 RID: 710 RVA: 0x0000833A File Offset: 0x0000653A
		public static void RegisterPackages()
		{
			TypeManager.RegisterPackages(new string[]
			{
				"com/google/errorprone/annotations"
			}, new Converter<string, Type>[]
			{
				new Converter<string, Type>(__TypeRegistrations.lookup_com_google_errorprone_annotations_package)
			});
		}

		// Token: 0x060002C7 RID: 711 RVA: 0x00008364 File Offset: 0x00006564
		private static Type Lookup(string[] mappings, string javaType)
		{
			string text = TypeManager.LookupTypeMapping(mappings, javaType);
			if (text == null)
			{
				return null;
			}
			return Type.GetType(text);
		}

		// Token: 0x060002C8 RID: 712 RVA: 0x00008384 File Offset: 0x00006584
		private static Type lookup_com_google_errorprone_annotations_package(string klass)
		{
			if (__TypeRegistrations.package_com_google_errorprone_annotations_mappings == null)
			{
				__TypeRegistrations.package_com_google_errorprone_annotations_mappings = new string[]
				{
					"com/google/errorprone/annotations/Modifier:Xamarin.Google.ErrorProne.Annotations.Modifier"
				};
			}
			return __TypeRegistrations.Lookup(__TypeRegistrations.package_com_google_errorprone_annotations_mappings, klass);
		}

		// Token: 0x0400013A RID: 314
		private static string[] package_com_google_errorprone_annotations_mappings;
	}
}
