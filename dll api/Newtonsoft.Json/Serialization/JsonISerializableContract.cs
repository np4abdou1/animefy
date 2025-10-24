using System;
using System.Runtime.CompilerServices;

namespace Newtonsoft.Json.Serialization
{
	// Token: 0x0200011F RID: 287
	public class JsonISerializableContract : JsonContainerContract
	{
		// Token: 0x17000120 RID: 288
		// (get) Token: 0x06000845 RID: 2117 RVA: 0x00028521 File Offset: 0x00026721
		// (set) Token: 0x06000846 RID: 2118 RVA: 0x00028529 File Offset: 0x00026729
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public ObjectConstructor<object> ISerializableCreator { [return: Nullable(new byte[]
		{
			2,
			1
		})] get; [param: Nullable(new byte[]
		{
			2,
			1
		})] set; }

		// Token: 0x06000847 RID: 2119 RVA: 0x00028532 File Offset: 0x00026732
		[NullableContext(1)]
		public JsonISerializableContract(Type underlyingType) : base(underlyingType)
		{
			this.ContractType = JsonContractType.Serializable;
		}
	}
}
