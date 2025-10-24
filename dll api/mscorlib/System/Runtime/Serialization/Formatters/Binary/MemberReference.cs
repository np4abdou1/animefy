using System;
using System.Security;

namespace System.Runtime.Serialization.Formatters.Binary
{
	// Token: 0x020003D9 RID: 985
	internal sealed class MemberReference
	{
		// Token: 0x06001DD0 RID: 7632 RVA: 0x00003ACD File Offset: 0x00001CCD
		internal MemberReference()
		{
		}

		// Token: 0x06001DD1 RID: 7633 RVA: 0x0007E18C File Offset: 0x0007C38C
		internal void Set(int idRef)
		{
			this.idRef = idRef;
		}

		// Token: 0x06001DD2 RID: 7634 RVA: 0x0007E195 File Offset: 0x0007C395
		public void Write(__BinaryWriter sout)
		{
			sout.WriteByte(9);
			sout.WriteInt32(this.idRef);
		}

		// Token: 0x06001DD3 RID: 7635 RVA: 0x0007E1AB File Offset: 0x0007C3AB
		[SecurityCritical]
		public void Read(__BinaryParser input)
		{
			this.idRef = input.ReadInt32();
		}

		// Token: 0x06001DD4 RID: 7636 RVA: 0x00002A7D File Offset: 0x00000C7D
		public void Dump()
		{
		}

		// Token: 0x04000D1A RID: 3354
		internal int idRef;
	}
}
