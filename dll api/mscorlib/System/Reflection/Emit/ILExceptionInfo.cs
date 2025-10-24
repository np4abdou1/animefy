using System;

namespace System.Reflection.Emit
{
	// Token: 0x02000502 RID: 1282
	internal struct ILExceptionInfo
	{
		// Token: 0x0600253A RID: 9530 RVA: 0x00090A68 File Offset: 0x0008EC68
		internal void AddCatch(Type extype, int offset)
		{
			this.End(offset);
			this.add_block(offset);
			int num = this.handlers.Length - 1;
			this.handlers[num].type = 0;
			this.handlers[num].start = offset;
			this.handlers[num].extype = extype;
		}

		// Token: 0x0600253B RID: 9531 RVA: 0x00090AC4 File Offset: 0x0008ECC4
		internal void AddFinally(int offset)
		{
			this.End(offset);
			this.add_block(offset);
			int num = this.handlers.Length - 1;
			this.handlers[num].type = 2;
			this.handlers[num].start = offset;
			this.handlers[num].extype = null;
		}

		// Token: 0x0600253C RID: 9532 RVA: 0x00090B20 File Offset: 0x0008ED20
		internal void AddFault(int offset)
		{
			this.End(offset);
			this.add_block(offset);
			int num = this.handlers.Length - 1;
			this.handlers[num].type = 4;
			this.handlers[num].start = offset;
			this.handlers[num].extype = null;
		}

		// Token: 0x0600253D RID: 9533 RVA: 0x00090B7C File Offset: 0x0008ED7C
		internal void AddFilter(int offset)
		{
			this.End(offset);
			this.add_block(offset);
			int num = this.handlers.Length - 1;
			this.handlers[num].type = -1;
			this.handlers[num].extype = null;
			this.handlers[num].filter_offset = offset;
		}

		// Token: 0x0600253E RID: 9534 RVA: 0x00090BD8 File Offset: 0x0008EDD8
		internal void End(int offset)
		{
			if (this.handlers == null)
			{
				return;
			}
			int num = this.handlers.Length - 1;
			if (num >= 0)
			{
				this.handlers[num].len = offset - this.handlers[num].start;
			}
		}

		// Token: 0x0600253F RID: 9535 RVA: 0x00090C21 File Offset: 0x0008EE21
		internal int LastClauseType()
		{
			if (this.handlers != null)
			{
				return this.handlers[this.handlers.Length - 1].type;
			}
			return 0;
		}

		// Token: 0x06002540 RID: 9536 RVA: 0x00090C48 File Offset: 0x0008EE48
		internal void PatchFilterClause(int start)
		{
			if (this.handlers != null && this.handlers.Length != 0)
			{
				this.handlers[this.handlers.Length - 1].start = start;
				this.handlers[this.handlers.Length - 1].type = 1;
			}
		}

		// Token: 0x06002541 RID: 9537 RVA: 0x00002A7D File Offset: 0x00000C7D
		internal void Debug(int b)
		{
		}

		// Token: 0x06002542 RID: 9538 RVA: 0x00090C9C File Offset: 0x0008EE9C
		private void add_block(int offset)
		{
			if (this.handlers != null)
			{
				int num = this.handlers.Length;
				ILExceptionBlock[] destinationArray = new ILExceptionBlock[num + 1];
				Array.Copy(this.handlers, destinationArray, num);
				this.handlers = destinationArray;
				this.handlers[num].len = offset - this.handlers[num].start;
				return;
			}
			this.handlers = new ILExceptionBlock[1];
			this.len = offset - this.start;
		}

		// Token: 0x04001239 RID: 4665
		internal ILExceptionBlock[] handlers;

		// Token: 0x0400123A RID: 4666
		internal int start;

		// Token: 0x0400123B RID: 4667
		internal int len;

		// Token: 0x0400123C RID: 4668
		internal Label end;
	}
}
