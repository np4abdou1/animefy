using System;
using System.Security;

namespace System.Runtime.Serialization.Formatters.Binary
{
	// Token: 0x020003CD RID: 973
	internal sealed class BinaryCrossAppDomainAssembly
	{
		// Token: 0x06001D95 RID: 7573 RVA: 0x00003ACD File Offset: 0x00001CCD
		internal BinaryCrossAppDomainAssembly()
		{
		}

		// Token: 0x06001D96 RID: 7574 RVA: 0x0007CDB6 File Offset: 0x0007AFB6
		[SecurityCritical]
		public void Read(__BinaryParser input)
		{
			this.assemId = input.ReadInt32();
			this.assemblyIndex = input.ReadInt32();
		}

		// Token: 0x06001D97 RID: 7575 RVA: 0x00002A7D File Offset: 0x00000C7D
		public void Dump()
		{
		}

		// Token: 0x04000CDC RID: 3292
		internal int assemId;

		// Token: 0x04000CDD RID: 3293
		internal int assemblyIndex;
	}
}
