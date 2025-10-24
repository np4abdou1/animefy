using System;
using System.Security;

namespace System.Runtime.Serialization.Formatters.Binary
{
	// Token: 0x020003D3 RID: 979
	internal sealed class BinaryCrossAppDomainMap
	{
		// Token: 0x06001DB2 RID: 7602 RVA: 0x00003ACD File Offset: 0x00001CCD
		internal BinaryCrossAppDomainMap()
		{
		}

		// Token: 0x06001DB3 RID: 7603 RVA: 0x0007D952 File Offset: 0x0007BB52
		[SecurityCritical]
		public void Read(__BinaryParser input)
		{
			this.crossAppDomainArrayIndex = input.ReadInt32();
		}

		// Token: 0x06001DB4 RID: 7604 RVA: 0x00002A7D File Offset: 0x00000C7D
		public void Dump()
		{
		}

		// Token: 0x04000CFD RID: 3325
		internal int crossAppDomainArrayIndex;
	}
}
