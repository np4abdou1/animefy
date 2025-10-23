using System;
using System.Security;

namespace System.Runtime.Serialization.Formatters.Binary
{
	// Token: 0x020003D2 RID: 978
	internal sealed class BinaryCrossAppDomainString
	{
		// Token: 0x06001DAF RID: 7599 RVA: 0x00003ACD File Offset: 0x00001CCD
		internal BinaryCrossAppDomainString()
		{
		}

		// Token: 0x06001DB0 RID: 7600 RVA: 0x0007D938 File Offset: 0x0007BB38
		[SecurityCritical]
		public void Read(__BinaryParser input)
		{
			this.objectId = input.ReadInt32();
			this.value = input.ReadInt32();
		}

		// Token: 0x06001DB1 RID: 7601 RVA: 0x00002A7D File Offset: 0x00000C7D
		public void Dump()
		{
		}

		// Token: 0x04000CFB RID: 3323
		internal int objectId;

		// Token: 0x04000CFC RID: 3324
		internal int value;
	}
}
