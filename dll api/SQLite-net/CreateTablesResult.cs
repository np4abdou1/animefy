using System;
using System.Collections.Generic;

namespace SQLite
{
	// Token: 0x02000039 RID: 57
	public class CreateTablesResult
	{
		// Token: 0x1700004A RID: 74
		// (get) Token: 0x06000183 RID: 387 RVA: 0x0000719C File Offset: 0x0000539C
		// (set) Token: 0x06000184 RID: 388 RVA: 0x000071A4 File Offset: 0x000053A4
		public Dictionary<Type, CreateTableResult> Results { get; private set; }

		// Token: 0x06000185 RID: 389 RVA: 0x000071AD File Offset: 0x000053AD
		public CreateTablesResult()
		{
			this.Results = new Dictionary<Type, CreateTableResult>();
		}
	}
}
