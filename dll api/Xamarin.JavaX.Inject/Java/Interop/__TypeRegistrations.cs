using System;

namespace Java.Interop
{
	// Token: 0x02000017 RID: 23
	internal class __TypeRegistrations
	{
		// Token: 0x0600008F RID: 143 RVA: 0x000032A1 File Offset: 0x000014A1
		public static void RegisterPackages()
		{
			TypeManager.RegisterPackages(new string[0], new Converter<string, Type>[0]);
		}

		// Token: 0x06000090 RID: 144 RVA: 0x000032B4 File Offset: 0x000014B4
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
