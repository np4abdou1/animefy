using System;
using System.Security;

namespace System.Runtime.Serialization.Formatters.Binary
{
	// Token: 0x020003CE RID: 974
	internal sealed class BinaryObject
	{
		// Token: 0x06001D98 RID: 7576 RVA: 0x00003ACD File Offset: 0x00001CCD
		internal BinaryObject()
		{
		}

		// Token: 0x06001D99 RID: 7577 RVA: 0x0007CDD0 File Offset: 0x0007AFD0
		internal void Set(int objectId, int mapId)
		{
			this.objectId = objectId;
			this.mapId = mapId;
		}

		// Token: 0x06001D9A RID: 7578 RVA: 0x0007CDE0 File Offset: 0x0007AFE0
		public void Write(__BinaryWriter sout)
		{
			sout.WriteByte(1);
			sout.WriteInt32(this.objectId);
			sout.WriteInt32(this.mapId);
		}

		// Token: 0x06001D9B RID: 7579 RVA: 0x0007CE01 File Offset: 0x0007B001
		[SecurityCritical]
		public void Read(__BinaryParser input)
		{
			this.objectId = input.ReadInt32();
			this.mapId = input.ReadInt32();
		}

		// Token: 0x06001D9C RID: 7580 RVA: 0x00002A7D File Offset: 0x00000C7D
		public void Dump()
		{
		}

		// Token: 0x04000CDE RID: 3294
		internal int objectId;

		// Token: 0x04000CDF RID: 3295
		internal int mapId;
	}
}
