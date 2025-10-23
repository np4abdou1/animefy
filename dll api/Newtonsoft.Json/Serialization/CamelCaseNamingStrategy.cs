using System;
using System.Runtime.CompilerServices;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json.Serialization
{
	// Token: 0x020000F7 RID: 247
	public class CamelCaseNamingStrategy : NamingStrategy
	{
		// Token: 0x06000736 RID: 1846 RVA: 0x00024905 File Offset: 0x00022B05
		public CamelCaseNamingStrategy(bool processDictionaryKeys, bool overrideSpecifiedNames)
		{
			base.ProcessDictionaryKeys = processDictionaryKeys;
			base.OverrideSpecifiedNames = overrideSpecifiedNames;
		}

		// Token: 0x06000737 RID: 1847 RVA: 0x0002491B File Offset: 0x00022B1B
		public CamelCaseNamingStrategy(bool processDictionaryKeys, bool overrideSpecifiedNames, bool processExtensionDataNames) : this(processDictionaryKeys, overrideSpecifiedNames)
		{
			base.ProcessExtensionDataNames = processExtensionDataNames;
		}

		// Token: 0x06000738 RID: 1848 RVA: 0x0002492C File Offset: 0x00022B2C
		public CamelCaseNamingStrategy()
		{
		}

		// Token: 0x06000739 RID: 1849 RVA: 0x00024934 File Offset: 0x00022B34
		[NullableContext(1)]
		protected override string ResolvePropertyName(string name)
		{
			return StringUtils.ToCamelCase(name);
		}
	}
}
