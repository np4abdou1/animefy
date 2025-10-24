using System;
using System.Runtime.CompilerServices;

namespace Newtonsoft.Json.Serialization
{
	// Token: 0x02000105 RID: 261
	public class DefaultNamingStrategy : NamingStrategy
	{
		// Token: 0x060007A0 RID: 1952 RVA: 0x00016B3F File Offset: 0x00014D3F
		[NullableContext(1)]
		protected override string ResolvePropertyName(string name)
		{
			return name;
		}
	}
}
