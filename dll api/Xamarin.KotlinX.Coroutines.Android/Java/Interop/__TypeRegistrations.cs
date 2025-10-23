using System;
using System.Runtime.CompilerServices;

namespace Java.Interop
{
	// Token: 0x0200000D RID: 13
	[NullableContext(1)]
	[Nullable(0)]
	internal class __TypeRegistrations
	{
		// Token: 0x06000033 RID: 51 RVA: 0x00002797 File Offset: 0x00000997
		public static void RegisterPackages()
		{
			string[] packages = new string[]
			{
				"kotlinx/coroutines/android"
			};
			Converter<string, Type>[] array = new Converter<string, Type>[1];
			int num = 0;
			Converter<string, Type> converter;
			if ((converter = __TypeRegistrations.<>O.<0>__lookup_kotlinx_coroutines_android_package) == null)
			{
				converter = (__TypeRegistrations.<>O.<0>__lookup_kotlinx_coroutines_android_package = new Converter<string, Type>(__TypeRegistrations.lookup_kotlinx_coroutines_android_package));
			}
			array[num] = converter;
			TypeManager.RegisterPackages(packages, array);
		}

		// Token: 0x06000034 RID: 52 RVA: 0x000027D0 File Offset: 0x000009D0
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

		// Token: 0x06000035 RID: 53 RVA: 0x000027F0 File Offset: 0x000009F0
		[return: Nullable(2)]
		private static Type lookup_kotlinx_coroutines_android_package(string klass)
		{
			if (__TypeRegistrations.package_kotlinx_coroutines_android_mappings == null)
			{
				__TypeRegistrations.package_kotlinx_coroutines_android_mappings = new string[]
				{
					"kotlinx/coroutines/android/HandlerDispatcher:Xamarin.KotlinX.Coroutines.CoroutinesAndroid.HandlerDispatcher",
					"kotlinx/coroutines/android/HandlerDispatcherKt:Xamarin.KotlinX.Coroutines.CoroutinesAndroid.HandlerDispatcherKt"
				};
			}
			return __TypeRegistrations.Lookup(__TypeRegistrations.package_kotlinx_coroutines_android_mappings, klass);
		}

		// Token: 0x0400000A RID: 10
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private static string[] package_kotlinx_coroutines_android_mappings;

		// Token: 0x0200000E RID: 14
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0400000B RID: 11
			[Nullable(new byte[]
			{
				0,
				1,
				2
			})]
			public static Converter<string, Type> <0>__lookup_kotlinx_coroutines_android_package;
		}
	}
}
