using System;
using Java.Interop;

namespace Android.Runtime
{
	// Token: 0x020002F7 RID: 759
	public static class TypeManager
	{
		// Token: 0x06001E04 RID: 7684 RVA: 0x00051F48 File Offset: 0x00050148
		public static string LookupTypeMapping(string[] mappings, string javaType)
		{
			return TypeManager.LookupTypeMapping(mappings, javaType);
		}

		// Token: 0x06001E05 RID: 7685 RVA: 0x00051F51 File Offset: 0x00050151
		public static void RegisterType(string java_class, Type t)
		{
			TypeManager.RegisterType(java_class, t);
		}

		// Token: 0x06001E06 RID: 7686 RVA: 0x00051F5A File Offset: 0x0005015A
		public static void RegisterPackage(string package, Converter<string, Type> lookup)
		{
			TypeManager.RegisterPackage(package, lookup);
		}

		// Token: 0x06001E07 RID: 7687 RVA: 0x00051F63 File Offset: 0x00050163
		public static void RegisterPackages(string[] packages, Converter<string, Type>[] lookups)
		{
			TypeManager.RegisterPackages(packages, lookups);
		}
	}
}
