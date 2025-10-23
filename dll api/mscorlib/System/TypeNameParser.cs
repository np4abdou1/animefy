using System;
using System.Reflection;
using System.Threading;

namespace System
{
	// Token: 0x02000166 RID: 358
	internal sealed class TypeNameParser
	{
		// Token: 0x06000E65 RID: 3685 RVA: 0x0003CEC8 File Offset: 0x0003B0C8
		internal static Type GetType(string typeName, Func<AssemblyName, Assembly> assemblyResolver, Func<Assembly, string, bool, Type> typeResolver, bool throwOnError, bool ignoreCase, ref StackCrawlMark stackMark)
		{
			return TypeSpec.Parse(typeName).Resolve(assemblyResolver, typeResolver, throwOnError, ignoreCase, ref stackMark);
		}
	}
}
