using System;
using System.Security;

namespace System.Runtime.Serialization.Formatters.Binary
{
	// Token: 0x020003CC RID: 972
	internal sealed class BinaryAssembly
	{
		// Token: 0x06001D90 RID: 7568 RVA: 0x00003ACD File Offset: 0x00001CCD
		internal BinaryAssembly()
		{
		}

		// Token: 0x06001D91 RID: 7569 RVA: 0x0007CD6A File Offset: 0x0007AF6A
		internal void Set(int assemId, string assemblyString)
		{
			this.assemId = assemId;
			this.assemblyString = assemblyString;
		}

		// Token: 0x06001D92 RID: 7570 RVA: 0x0007CD7A File Offset: 0x0007AF7A
		public void Write(__BinaryWriter sout)
		{
			sout.WriteByte(12);
			sout.WriteInt32(this.assemId);
			sout.WriteString(this.assemblyString);
		}

		// Token: 0x06001D93 RID: 7571 RVA: 0x0007CD9C File Offset: 0x0007AF9C
		[SecurityCritical]
		public void Read(__BinaryParser input)
		{
			this.assemId = input.ReadInt32();
			this.assemblyString = input.ReadString();
		}

		// Token: 0x06001D94 RID: 7572 RVA: 0x00002A7D File Offset: 0x00000C7D
		public void Dump()
		{
		}

		// Token: 0x04000CDA RID: 3290
		internal int assemId;

		// Token: 0x04000CDB RID: 3291
		internal string assemblyString;
	}
}
