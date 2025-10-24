using System;

namespace System.Xml.Schema
{
	// Token: 0x02000327 RID: 807
	internal class IdRefNode
	{
		// Token: 0x06001AAB RID: 6827 RVA: 0x0009AF59 File Offset: 0x00099159
		internal IdRefNode(IdRefNode next, string id, int lineNo, int linePos)
		{
			this.Id = id;
			this.LineNo = lineNo;
			this.LinePos = linePos;
			this.Next = next;
		}

		// Token: 0x04001158 RID: 4440
		internal string Id;

		// Token: 0x04001159 RID: 4441
		internal int LineNo;

		// Token: 0x0400115A RID: 4442
		internal int LinePos;

		// Token: 0x0400115B RID: 4443
		internal IdRefNode Next;
	}
}
