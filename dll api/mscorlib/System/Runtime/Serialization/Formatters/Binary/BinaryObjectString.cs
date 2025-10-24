using System;
using System.Security;

namespace System.Runtime.Serialization.Formatters.Binary
{
	// Token: 0x020003D1 RID: 977
	internal sealed class BinaryObjectString
	{
		// Token: 0x06001DAA RID: 7594 RVA: 0x00003ACD File Offset: 0x00001CCD
		internal BinaryObjectString()
		{
		}

		// Token: 0x06001DAB RID: 7595 RVA: 0x0007D8ED File Offset: 0x0007BAED
		internal void Set(int objectId, string value)
		{
			this.objectId = objectId;
			this.value = value;
		}

		// Token: 0x06001DAC RID: 7596 RVA: 0x0007D8FD File Offset: 0x0007BAFD
		public void Write(__BinaryWriter sout)
		{
			sout.WriteByte(6);
			sout.WriteInt32(this.objectId);
			sout.WriteString(this.value);
		}

		// Token: 0x06001DAD RID: 7597 RVA: 0x0007D91E File Offset: 0x0007BB1E
		[SecurityCritical]
		public void Read(__BinaryParser input)
		{
			this.objectId = input.ReadInt32();
			this.value = input.ReadString();
		}

		// Token: 0x06001DAE RID: 7598 RVA: 0x00002A7D File Offset: 0x00000C7D
		public void Dump()
		{
		}

		// Token: 0x04000CF9 RID: 3321
		internal int objectId;

		// Token: 0x04000CFA RID: 3322
		internal string value;
	}
}
