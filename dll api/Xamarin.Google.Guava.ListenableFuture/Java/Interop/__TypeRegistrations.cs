using System;
using System.Runtime.CompilerServices;

namespace Java.Interop
{
	// Token: 0x0200000C RID: 12
	internal class __TypeRegistrations
	{
		// Token: 0x0600001B RID: 27 RVA: 0x000020A5 File Offset: 0x000002A5
		public static void RegisterPackages()
		{
			TypeManager.RegisterPackages(new string[0], new Converter<string, Type>[0]);
		}

		// Token: 0x0600001C RID: 28 RVA: 0x000020B8 File Offset: 0x000002B8
		[NullableContext(1)]
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
	}
}
