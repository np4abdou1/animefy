using System;

namespace Java.Interop
{
	// Token: 0x02000002 RID: 2
	internal class __TypeRegistrations
	{
		// Token: 0x06000001 RID: 1 RVA: 0x00002050 File Offset: 0x00000250
		public static void RegisterPackages()
		{
			TypeManager.RegisterPackages(new string[0], new Converter<string, Type>[0]);
		}

		// Token: 0x06000002 RID: 2 RVA: 0x00002064 File Offset: 0x00000264
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
