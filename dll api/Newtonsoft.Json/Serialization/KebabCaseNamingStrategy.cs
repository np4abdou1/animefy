using System;
using System.Runtime.CompilerServices;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json.Serialization
{
	// Token: 0x02000132 RID: 306
	public class KebabCaseNamingStrategy : NamingStrategy
	{
		// Token: 0x06000975 RID: 2421 RVA: 0x00024905 File Offset: 0x00022B05
		public KebabCaseNamingStrategy(bool processDictionaryKeys, bool overrideSpecifiedNames)
		{
			base.ProcessDictionaryKeys = processDictionaryKeys;
			base.OverrideSpecifiedNames = overrideSpecifiedNames;
		}

		// Token: 0x06000976 RID: 2422 RVA: 0x0002EF98 File Offset: 0x0002D198
		public KebabCaseNamingStrategy(bool processDictionaryKeys, bool overrideSpecifiedNames, bool processExtensionDataNames) : this(processDictionaryKeys, overrideSpecifiedNames)
		{
			base.ProcessExtensionDataNames = processExtensionDataNames;
		}

		// Token: 0x06000977 RID: 2423 RVA: 0x0002492C File Offset: 0x00022B2C
		public KebabCaseNamingStrategy()
		{
		}

		// Token: 0x06000978 RID: 2424 RVA: 0x0002EFA9 File Offset: 0x0002D1A9
		[NullableContext(1)]
		protected override string ResolvePropertyName(string name)
		{
			return StringUtils.ToKebabCase(name);
		}
	}
}
