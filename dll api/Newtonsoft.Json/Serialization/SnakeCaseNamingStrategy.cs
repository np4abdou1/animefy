using System;
using System.Runtime.CompilerServices;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json.Serialization
{
	// Token: 0x0200013A RID: 314
	public class SnakeCaseNamingStrategy : NamingStrategy
	{
		// Token: 0x0600099B RID: 2459 RVA: 0x00024905 File Offset: 0x00022B05
		public SnakeCaseNamingStrategy(bool processDictionaryKeys, bool overrideSpecifiedNames)
		{
			base.ProcessDictionaryKeys = processDictionaryKeys;
			base.OverrideSpecifiedNames = overrideSpecifiedNames;
		}

		// Token: 0x0600099C RID: 2460 RVA: 0x0002F3DA File Offset: 0x0002D5DA
		public SnakeCaseNamingStrategy(bool processDictionaryKeys, bool overrideSpecifiedNames, bool processExtensionDataNames) : this(processDictionaryKeys, overrideSpecifiedNames)
		{
			base.ProcessExtensionDataNames = processExtensionDataNames;
		}

		// Token: 0x0600099D RID: 2461 RVA: 0x0002492C File Offset: 0x00022B2C
		public SnakeCaseNamingStrategy()
		{
		}

		// Token: 0x0600099E RID: 2462 RVA: 0x0002F3EB File Offset: 0x0002D5EB
		[NullableContext(1)]
		protected override string ResolvePropertyName(string name)
		{
			return StringUtils.ToSnakeCase(name);
		}
	}
}
