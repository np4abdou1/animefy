using System;
using System.Runtime.CompilerServices;

namespace Java.Interop
{
	// Token: 0x02000046 RID: 70
	[NullableContext(1)]
	[Nullable(0)]
	internal class __TypeRegistrations
	{
		// Token: 0x06000204 RID: 516 RVA: 0x0000651C File Offset: 0x0000471C
		public static void RegisterPackages()
		{
			string[] packages = new string[]
			{
				"org/intellij/lang/annotations",
				"org/jetbrains/annotations"
			};
			Converter<string, Type>[] array = new Converter<string, Type>[2];
			int num = 0;
			Converter<string, Type> converter;
			if ((converter = __TypeRegistrations.<>O.<0>__lookup_org_intellij_lang_annotations_package) == null)
			{
				converter = (__TypeRegistrations.<>O.<0>__lookup_org_intellij_lang_annotations_package = new Converter<string, Type>(__TypeRegistrations.lookup_org_intellij_lang_annotations_package));
			}
			array[num] = converter;
			int num2 = 1;
			Converter<string, Type> converter2;
			if ((converter2 = __TypeRegistrations.<>O.<1>__lookup_org_jetbrains_annotations_package) == null)
			{
				converter2 = (__TypeRegistrations.<>O.<1>__lookup_org_jetbrains_annotations_package = new Converter<string, Type>(__TypeRegistrations.lookup_org_jetbrains_annotations_package));
			}
			array[num2] = converter2;
			TypeManager.RegisterPackages(packages, array);
		}

		// Token: 0x06000205 RID: 517 RVA: 0x00006588 File Offset: 0x00004788
		[return: Nullable(2)]
		private static Type Lookup(string[] mappings, string javaType)
		{
			string text = TypeManager.LookupTypeMapping(mappings, javaType);
			if (text == null)
			{
				return null;
			}
			return Type.GetType(text);
		}

		// Token: 0x06000206 RID: 518 RVA: 0x000065A8 File Offset: 0x000047A8
		[return: Nullable(2)]
		private static Type lookup_org_intellij_lang_annotations_package(string klass)
		{
			if (__TypeRegistrations.package_org_intellij_lang_annotations_mappings == null)
			{
				__TypeRegistrations.package_org_intellij_lang_annotations_mappings = new string[]
				{
					"org/intellij/lang/annotations/JdkConstants:IntelliJ.Lang.Annotations.JdkConstants"
				};
			}
			return __TypeRegistrations.Lookup(__TypeRegistrations.package_org_intellij_lang_annotations_mappings, klass);
		}

		// Token: 0x06000207 RID: 519 RVA: 0x000065CF File Offset: 0x000047CF
		[return: Nullable(2)]
		private static Type lookup_org_jetbrains_annotations_package(string klass)
		{
			if (__TypeRegistrations.package_org_jetbrains_annotations_mappings == null)
			{
				__TypeRegistrations.package_org_jetbrains_annotations_mappings = new string[]
				{
					"org/jetbrains/annotations/ApiStatus:JetBrains.Annotations.ApiStatus",
					"org/jetbrains/annotations/Async:JetBrains.Annotations.Async",
					"org/jetbrains/annotations/Debug:JetBrains.Annotations.Debug",
					"org/jetbrains/annotations/Nls$Capitalization:JetBrains.Annotations.NlsCapitalization"
				};
			}
			return __TypeRegistrations.Lookup(__TypeRegistrations.package_org_jetbrains_annotations_mappings, klass);
		}

		// Token: 0x040000DC RID: 220
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private static string[] package_org_intellij_lang_annotations_mappings;

		// Token: 0x040000DD RID: 221
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private static string[] package_org_jetbrains_annotations_mappings;

		// Token: 0x02000076 RID: 118
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040001D4 RID: 468
			[Nullable(new byte[]
			{
				0,
				1,
				2
			})]
			public static Converter<string, Type> <0>__lookup_org_intellij_lang_annotations_package;

			// Token: 0x040001D5 RID: 469
			[Nullable(new byte[]
			{
				0,
				1,
				2
			})]
			public static Converter<string, Type> <1>__lookup_org_jetbrains_annotations_package;
		}
	}
}
