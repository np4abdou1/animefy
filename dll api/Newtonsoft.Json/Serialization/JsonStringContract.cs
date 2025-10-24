using System;
using System.Runtime.CompilerServices;

namespace Newtonsoft.Json.Serialization
{
	// Token: 0x0200012E RID: 302
	public class JsonStringContract : JsonPrimitiveContract
	{
		// Token: 0x0600095A RID: 2394 RVA: 0x0002E981 File Offset: 0x0002CB81
		[NullableContext(1)]
		public JsonStringContract(Type underlyingType) : base(underlyingType)
		{
			this.ContractType = JsonContractType.String;
		}
	}
}
