using System;
using System.IO;
using System.Security;

namespace System.Runtime.Serialization.Formatters.Binary
{
	// Token: 0x020003DB RID: 987
	internal sealed class MessageEnd
	{
		// Token: 0x06001DDA RID: 7642 RVA: 0x00003ACD File Offset: 0x00001CCD
		internal MessageEnd()
		{
		}

		// Token: 0x06001DDB RID: 7643 RVA: 0x0007E268 File Offset: 0x0007C468
		public void Write(__BinaryWriter sout)
		{
			sout.WriteByte(11);
		}

		// Token: 0x06001DDC RID: 7644 RVA: 0x00002A7D File Offset: 0x00000C7D
		[SecurityCritical]
		public void Read(__BinaryParser input)
		{
		}

		// Token: 0x06001DDD RID: 7645 RVA: 0x00002A7D File Offset: 0x00000C7D
		public void Dump()
		{
		}

		// Token: 0x06001DDE RID: 7646 RVA: 0x00002A7D File Offset: 0x00000C7D
		public void Dump(Stream sout)
		{
		}
	}
}
