using System;

namespace Java.Interop
{
	// Token: 0x02000019 RID: 25
	internal class __TypeRegistrations
	{
		// Token: 0x06000052 RID: 82 RVA: 0x0000208E File Offset: 0x0000028E
		public static void RegisterPackages()
		{
			TypeManager.RegisterPackages(new string[0], new Converter<string, Type>[0]);
		}

		// Token: 0x06000053 RID: 83 RVA: 0x000020A4 File Offset: 0x000002A4
		private static Type Lookup(string[] mappings, string javaType)
		{
			string text = TypeManager.LookupTypeMapping(mappings, javaType);
			if (text == null)
			{
				return null;
			}
			return Type.GetType(text);
		}
	}
}
