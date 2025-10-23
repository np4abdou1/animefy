using System;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json.Bson
{
	// Token: 0x020001D6 RID: 470
	[Obsolete("BSON reading and writing has been moved to its own package. See https://www.nuget.org/packages/Newtonsoft.Json.Bson for more details.")]
	public class BsonObjectId
	{
		// Token: 0x170002AE RID: 686
		// (get) Token: 0x06000FDF RID: 4063 RVA: 0x00045C5D File Offset: 0x00043E5D
		public byte[] Value { get; }

		// Token: 0x06000FE0 RID: 4064 RVA: 0x00045C65 File Offset: 0x00043E65
		public BsonObjectId(byte[] value)
		{
			ValidationUtils.ArgumentNotNull(value, "value");
			if (value.Length != 12)
			{
				throw new ArgumentException("An ObjectId must be 12 bytes", "value");
			}
			this.Value = value;
		}
	}
}
