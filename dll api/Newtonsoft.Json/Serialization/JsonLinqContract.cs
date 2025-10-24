using System;
using System.Runtime.CompilerServices;

namespace Newtonsoft.Json.Serialization
{
	// Token: 0x02000120 RID: 288
	public class JsonLinqContract : JsonContract
	{
		// Token: 0x06000848 RID: 2120 RVA: 0x00028542 File Offset: 0x00026742
		[NullableContext(1)]
		public JsonLinqContract(Type underlyingType) : base(underlyingType)
		{
			this.ContractType = JsonContractType.Linq;
		}
	}
}
