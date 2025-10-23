using System;
using System.Runtime.CompilerServices;

namespace Java.Interop
{
	// Token: 0x0200003F RID: 63
	[NullableContext(1)]
	[Nullable(0)]
	internal class __TypeRegistrations
	{
		// Token: 0x060000E7 RID: 231 RVA: 0x000020A8 File Offset: 0x000002A8
		public static void RegisterPackages()
		{
			string[] packages = new string[]
			{
				"kotlin/contracts",
				"kotlin/coroutines",
				"kotlin/io/encoding",
				"kotlin/jvm/internal",
				"kotlin",
				"kotlin/random",
				"kotlin/ranges",
				"kotlin/reflect",
				"kotlin/text",
				"kotlin/time"
			};
			Converter<string, Type>[] array = new Converter<string, Type>[10];
			int num = 0;
			Converter<string, Type> converter;
			if ((converter = __TypeRegistrations.<>O.<0>__lookup_kotlin_contracts_package) == null)
			{
				converter = (__TypeRegistrations.<>O.<0>__lookup_kotlin_contracts_package = new Converter<string, Type>(__TypeRegistrations.lookup_kotlin_contracts_package));
			}
			array[num] = converter;
			int num2 = 1;
			Converter<string, Type> converter2;
			if ((converter2 = __TypeRegistrations.<>O.<1>__lookup_kotlin_coroutines_package) == null)
			{
				converter2 = (__TypeRegistrations.<>O.<1>__lookup_kotlin_coroutines_package = new Converter<string, Type>(__TypeRegistrations.lookup_kotlin_coroutines_package));
			}
			array[num2] = converter2;
			int num3 = 2;
			Converter<string, Type> converter3;
			if ((converter3 = __TypeRegistrations.<>O.<2>__lookup_kotlin_io_encoding_package) == null)
			{
				converter3 = (__TypeRegistrations.<>O.<2>__lookup_kotlin_io_encoding_package = new Converter<string, Type>(__TypeRegistrations.lookup_kotlin_io_encoding_package));
			}
			array[num3] = converter3;
			int num4 = 3;
			Converter<string, Type> converter4;
			if ((converter4 = __TypeRegistrations.<>O.<3>__lookup_kotlin_jvm_internal_package) == null)
			{
				converter4 = (__TypeRegistrations.<>O.<3>__lookup_kotlin_jvm_internal_package = new Converter<string, Type>(__TypeRegistrations.lookup_kotlin_jvm_internal_package));
			}
			array[num4] = converter4;
			int num5 = 4;
			Converter<string, Type> converter5;
			if ((converter5 = __TypeRegistrations.<>O.<4>__lookup_kotlin_package) == null)
			{
				converter5 = (__TypeRegistrations.<>O.<4>__lookup_kotlin_package = new Converter<string, Type>(__TypeRegistrations.lookup_kotlin_package));
			}
			array[num5] = converter5;
			int num6 = 5;
			Converter<string, Type> converter6;
			if ((converter6 = __TypeRegistrations.<>O.<5>__lookup_kotlin_random_package) == null)
			{
				converter6 = (__TypeRegistrations.<>O.<5>__lookup_kotlin_random_package = new Converter<string, Type>(__TypeRegistrations.lookup_kotlin_random_package));
			}
			array[num6] = converter6;
			int num7 = 6;
			Converter<string, Type> converter7;
			if ((converter7 = __TypeRegistrations.<>O.<6>__lookup_kotlin_ranges_package) == null)
			{
				converter7 = (__TypeRegistrations.<>O.<6>__lookup_kotlin_ranges_package = new Converter<string, Type>(__TypeRegistrations.lookup_kotlin_ranges_package));
			}
			array[num7] = converter7;
			int num8 = 7;
			Converter<string, Type> converter8;
			if ((converter8 = __TypeRegistrations.<>O.<7>__lookup_kotlin_reflect_package) == null)
			{
				converter8 = (__TypeRegistrations.<>O.<7>__lookup_kotlin_reflect_package = new Converter<string, Type>(__TypeRegistrations.lookup_kotlin_reflect_package));
			}
			array[num8] = converter8;
			int num9 = 8;
			Converter<string, Type> converter9;
			if ((converter9 = __TypeRegistrations.<>O.<8>__lookup_kotlin_text_package) == null)
			{
				converter9 = (__TypeRegistrations.<>O.<8>__lookup_kotlin_text_package = new Converter<string, Type>(__TypeRegistrations.lookup_kotlin_text_package));
			}
			array[num9] = converter9;
			int num10 = 9;
			Converter<string, Type> converter10;
			if ((converter10 = __TypeRegistrations.<>O.<9>__lookup_kotlin_time_package) == null)
			{
				converter10 = (__TypeRegistrations.<>O.<9>__lookup_kotlin_time_package = new Converter<string, Type>(__TypeRegistrations.lookup_kotlin_time_package));
			}
			array[num10] = converter10;
			TypeManager.RegisterPackages(packages, array);
		}

		// Token: 0x060000E8 RID: 232 RVA: 0x00002248 File Offset: 0x00000448
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

		// Token: 0x060000E9 RID: 233 RVA: 0x00002268 File Offset: 0x00000468
		[return: Nullable(2)]
		private static Type lookup_kotlin_contracts_package(string klass)
		{
			if (__TypeRegistrations.package_kotlin_contracts_mappings == null)
			{
				__TypeRegistrations.package_kotlin_contracts_mappings = new string[]
				{
					"kotlin/contracts/ContractBuilder$DefaultImpls:Kotlin.Contracts.ContractBuilderDefaultImpls"
				};
			}
			return __TypeRegistrations.Lookup(__TypeRegistrations.package_kotlin_contracts_mappings, klass);
		}

		// Token: 0x060000EA RID: 234 RVA: 0x0000228F File Offset: 0x0000048F
		[return: Nullable(2)]
		private static Type lookup_kotlin_coroutines_package(string klass)
		{
			if (__TypeRegistrations.package_kotlin_coroutines_mappings == null)
			{
				__TypeRegistrations.package_kotlin_coroutines_mappings = new string[]
				{
					"kotlin/coroutines/ContinuationInterceptor$DefaultImpls:Kotlin.Coroutines.ContinuationInterceptorDefaultImpls",
					"kotlin/coroutines/ContinuationInterceptor$Key:Kotlin.Coroutines.ContinuationInterceptorKey",
					"kotlin/coroutines/CoroutineContext$DefaultImpls:Kotlin.Coroutines.CoroutineContextDefaultImpls",
					"kotlin/coroutines/CoroutineContext$Element$DefaultImpls:Kotlin.Coroutines.CoroutineContextElementDefaultImpls"
				};
			}
			return __TypeRegistrations.Lookup(__TypeRegistrations.package_kotlin_coroutines_mappings, klass);
		}

		// Token: 0x060000EB RID: 235 RVA: 0x000022CE File Offset: 0x000004CE
		[return: Nullable(2)]
		private static Type lookup_kotlin_io_encoding_package(string klass)
		{
			if (__TypeRegistrations.package_kotlin_io_encoding_mappings == null)
			{
				__TypeRegistrations.package_kotlin_io_encoding_mappings = new string[]
				{
					"kotlin/io/encoding/Base64$Default:Kotlin.IO.Encoding.Base64/DefaultStatic"
				};
			}
			return __TypeRegistrations.Lookup(__TypeRegistrations.package_kotlin_io_encoding_mappings, klass);
		}

		// Token: 0x060000EC RID: 236 RVA: 0x000022F5 File Offset: 0x000004F5
		[return: Nullable(2)]
		private static Type lookup_kotlin_jvm_internal_package(string klass)
		{
			if (__TypeRegistrations.package_kotlin_jvm_internal_mappings == null)
			{
				__TypeRegistrations.package_kotlin_jvm_internal_mappings = new string[]
				{
					"kotlin/jvm/internal/ClassReference$Companion:Kotlin.Jvm.Internal.ClassReference/CompanionStatic",
					"kotlin/jvm/internal/TypeParameterReference$Companion:Kotlin.Jvm.Internal.TypeParameterReference/CompanionStatic",
					"kotlin/jvm/internal/TypeParameterReference$Companion$WhenMappings:Kotlin.Jvm.Internal.TypeParameterReference/CompanionStatic/WhenMappings"
				};
			}
			return __TypeRegistrations.Lookup(__TypeRegistrations.package_kotlin_jvm_internal_mappings, klass);
		}

		// Token: 0x060000ED RID: 237 RVA: 0x0000232C File Offset: 0x0000052C
		[return: Nullable(2)]
		private static Type lookup_kotlin_package(string klass)
		{
			if (__TypeRegistrations.package_kotlin_mappings == null)
			{
				__TypeRegistrations.package_kotlin_mappings = new string[]
				{
					"kotlin/Metadata$DefaultImpls:Kotlin.MetadataDefaultImpls",
					"kotlin/RequiresOptIn$Level:Kotlin.RequiresOptInLevel"
				};
			}
			return __TypeRegistrations.Lookup(__TypeRegistrations.package_kotlin_mappings, klass);
		}

		// Token: 0x060000EE RID: 238 RVA: 0x0000235B File Offset: 0x0000055B
		[return: Nullable(2)]
		private static Type lookup_kotlin_random_package(string klass)
		{
			if (__TypeRegistrations.package_kotlin_random_mappings == null)
			{
				__TypeRegistrations.package_kotlin_random_mappings = new string[]
				{
					"kotlin/random/Random$Default:Kotlin.Random.Random/DefaultStatic"
				};
			}
			return __TypeRegistrations.Lookup(__TypeRegistrations.package_kotlin_random_mappings, klass);
		}

		// Token: 0x060000EF RID: 239 RVA: 0x00002384 File Offset: 0x00000584
		[return: Nullable(2)]
		private static Type lookup_kotlin_ranges_package(string klass)
		{
			if (__TypeRegistrations.package_kotlin_ranges_mappings == null)
			{
				__TypeRegistrations.package_kotlin_ranges_mappings = new string[]
				{
					"kotlin/ranges/CharProgression$Companion:Kotlin.Ranges.CharProgression/CompanionStatic",
					"kotlin/ranges/CharRange$Companion:Kotlin.Ranges.CharRange/CompanionStatic",
					"kotlin/ranges/ClosedFloatingPointRange$DefaultImpls:Kotlin.Ranges.ClosedFloatingPointRangeDefaultImpls",
					"kotlin/ranges/ClosedRange$DefaultImpls:Kotlin.Ranges.ClosedRangeDefaultImpls",
					"kotlin/ranges/IntProgression$Companion:Kotlin.Ranges.IntProgression/CompanionStatic",
					"kotlin/ranges/IntRange$Companion:Kotlin.Ranges.IntRange/CompanionStatic",
					"kotlin/ranges/LongProgression$Companion:Kotlin.Ranges.LongProgression/CompanionStatic",
					"kotlin/ranges/LongRange$Companion:Kotlin.Ranges.LongRange/CompanionStatic",
					"kotlin/ranges/OpenEndRange$DefaultImpls:Kotlin.Ranges.OpenEndRangeDefaultImpls",
					"kotlin/ranges/UIntProgression$Companion:Kotlin.Ranges.UIntProgression/CompanionStatic",
					"kotlin/ranges/UIntRange$Companion:Kotlin.Ranges.UIntRange/CompanionStatic",
					"kotlin/ranges/ULongProgression$Companion:Kotlin.Ranges.ULongProgression/CompanionStatic",
					"kotlin/ranges/ULongRange$Companion:Kotlin.Ranges.ULongRange/CompanionStatic"
				};
			}
			return __TypeRegistrations.Lookup(__TypeRegistrations.package_kotlin_ranges_mappings, klass);
		}

		// Token: 0x060000F0 RID: 240 RVA: 0x0000241C File Offset: 0x0000061C
		[return: Nullable(2)]
		private static Type lookup_kotlin_reflect_package(string klass)
		{
			if (__TypeRegistrations.package_kotlin_reflect_mappings == null)
			{
				__TypeRegistrations.package_kotlin_reflect_mappings = new string[]
				{
					"kotlin/reflect/KCallable$DefaultImpls:Kotlin.Reflect.KCallableDefaultImpls",
					"kotlin/reflect/KClass$DefaultImpls:Kotlin.Reflect.KClassDefaultImpls",
					"kotlin/reflect/KFunction$DefaultImpls:Kotlin.Reflect.KFunctionDefaultImpls",
					"kotlin/reflect/KParameter$DefaultImpls:Kotlin.Reflect.KParameterDefaultImpls",
					"kotlin/reflect/KParameter$Kind:Kotlin.Reflect.KParameterKind",
					"kotlin/reflect/KProperty$DefaultImpls:Kotlin.Reflect.KPropertyDefaultImpls",
					"kotlin/reflect/KType$DefaultImpls:Kotlin.Reflect.KTypeDefaultImpls",
					"kotlin/reflect/KTypeProjection$Companion:Kotlin.Reflect.KTypeProjection/CompanionStatic"
				};
			}
			return __TypeRegistrations.Lookup(__TypeRegistrations.package_kotlin_reflect_mappings, klass);
		}

		// Token: 0x060000F1 RID: 241 RVA: 0x00002488 File Offset: 0x00000688
		[return: Nullable(2)]
		private static Type lookup_kotlin_text_package(string klass)
		{
			if (__TypeRegistrations.package_kotlin_text_mappings == null)
			{
				__TypeRegistrations.package_kotlin_text_mappings = new string[]
				{
					"kotlin/text/CharCategory$Companion:Kotlin.Text.CharCategory/CompanionStatic",
					"kotlin/text/CharDirectionality$Companion:Kotlin.Text.CharDirectionality/CompanionStatic",
					"kotlin/text/HexFormat$Companion:Kotlin.Text.HexFormat/CompanionStatic",
					"kotlin/text/MatchResult$DefaultImpls:Kotlin.Text.MatchResultDefaultImpls",
					"kotlin/text/MatchResult$Destructured:Kotlin.Text.MatchResultDestructured",
					"kotlin/text/Regex$Companion:Kotlin.Text.Regex/CompanionStatic"
				};
			}
			return __TypeRegistrations.Lookup(__TypeRegistrations.package_kotlin_text_mappings, klass);
		}

		// Token: 0x060000F2 RID: 242 RVA: 0x000024E4 File Offset: 0x000006E4
		[return: Nullable(2)]
		private static Type lookup_kotlin_time_package(string klass)
		{
			if (__TypeRegistrations.package_kotlin_time_mappings == null)
			{
				__TypeRegistrations.package_kotlin_time_mappings = new string[]
				{
					"kotlin/time/ComparableTimeMark$DefaultImpls:Kotlin.Time.ComparableTimeMarkDefaultImpls",
					"kotlin/time/Duration$Companion:Kotlin.Time.Duration/CompanionStatic",
					"kotlin/time/TimeMark$DefaultImpls:Kotlin.Time.TimeMarkDefaultImpls",
					"kotlin/time/TimeSource$Monotonic:Kotlin.Time.TimeSourceMonotonic",
					"kotlin/time/TimeSource$Monotonic$ValueTimeMark:Kotlin.Time.TimeSourceMonotonic/ValueTimeMark"
				};
			}
			return __TypeRegistrations.Lookup(__TypeRegistrations.package_kotlin_time_mappings, klass);
		}

		// Token: 0x04000004 RID: 4
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private static string[] package_kotlin_contracts_mappings;

		// Token: 0x04000005 RID: 5
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private static string[] package_kotlin_coroutines_mappings;

		// Token: 0x04000006 RID: 6
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private static string[] package_kotlin_io_encoding_mappings;

		// Token: 0x04000007 RID: 7
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private static string[] package_kotlin_jvm_internal_mappings;

		// Token: 0x04000008 RID: 8
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private static string[] package_kotlin_mappings;

		// Token: 0x04000009 RID: 9
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private static string[] package_kotlin_random_mappings;

		// Token: 0x0400000A RID: 10
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private static string[] package_kotlin_ranges_mappings;

		// Token: 0x0400000B RID: 11
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private static string[] package_kotlin_reflect_mappings;

		// Token: 0x0400000C RID: 12
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private static string[] package_kotlin_text_mappings;

		// Token: 0x0400000D RID: 13
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private static string[] package_kotlin_time_mappings;

		// Token: 0x020002DC RID: 732
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040009CA RID: 2506
			[Nullable(new byte[]
			{
				0,
				1,
				2
			})]
			public static Converter<string, Type> <0>__lookup_kotlin_contracts_package;

			// Token: 0x040009CB RID: 2507
			[Nullable(new byte[]
			{
				0,
				1,
				2
			})]
			public static Converter<string, Type> <1>__lookup_kotlin_coroutines_package;

			// Token: 0x040009CC RID: 2508
			[Nullable(new byte[]
			{
				0,
				1,
				2
			})]
			public static Converter<string, Type> <2>__lookup_kotlin_io_encoding_package;

			// Token: 0x040009CD RID: 2509
			[Nullable(new byte[]
			{
				0,
				1,
				2
			})]
			public static Converter<string, Type> <3>__lookup_kotlin_jvm_internal_package;

			// Token: 0x040009CE RID: 2510
			[Nullable(new byte[]
			{
				0,
				1,
				2
			})]
			public static Converter<string, Type> <4>__lookup_kotlin_package;

			// Token: 0x040009CF RID: 2511
			[Nullable(new byte[]
			{
				0,
				1,
				2
			})]
			public static Converter<string, Type> <5>__lookup_kotlin_random_package;

			// Token: 0x040009D0 RID: 2512
			[Nullable(new byte[]
			{
				0,
				1,
				2
			})]
			public static Converter<string, Type> <6>__lookup_kotlin_ranges_package;

			// Token: 0x040009D1 RID: 2513
			[Nullable(new byte[]
			{
				0,
				1,
				2
			})]
			public static Converter<string, Type> <7>__lookup_kotlin_reflect_package;

			// Token: 0x040009D2 RID: 2514
			[Nullable(new byte[]
			{
				0,
				1,
				2
			})]
			public static Converter<string, Type> <8>__lookup_kotlin_text_package;

			// Token: 0x040009D3 RID: 2515
			[Nullable(new byte[]
			{
				0,
				1,
				2
			})]
			public static Converter<string, Type> <9>__lookup_kotlin_time_package;
		}
	}
}
