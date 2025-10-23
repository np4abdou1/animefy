using System;
using System.Text;

namespace System.Net
{
	// Token: 0x0200011C RID: 284
	internal class ResponseDescription
	{
		// Token: 0x1700015C RID: 348
		// (get) Token: 0x0600081E RID: 2078 RVA: 0x0002D7F6 File Offset: 0x0002B9F6
		internal bool PositiveIntermediate
		{
			get
			{
				return this.Status >= 100 && this.Status <= 199;
			}
		}

		// Token: 0x1700015D RID: 349
		// (get) Token: 0x0600081F RID: 2079 RVA: 0x0002D814 File Offset: 0x0002BA14
		internal bool PositiveCompletion
		{
			get
			{
				return this.Status >= 200 && this.Status <= 299;
			}
		}

		// Token: 0x1700015E RID: 350
		// (get) Token: 0x06000820 RID: 2080 RVA: 0x0002D835 File Offset: 0x0002BA35
		internal bool TransientFailure
		{
			get
			{
				return this.Status >= 400 && this.Status <= 499;
			}
		}

		// Token: 0x1700015F RID: 351
		// (get) Token: 0x06000821 RID: 2081 RVA: 0x0002D856 File Offset: 0x0002BA56
		internal bool PermanentFailure
		{
			get
			{
				return this.Status >= 500 && this.Status <= 599;
			}
		}

		// Token: 0x17000160 RID: 352
		// (get) Token: 0x06000822 RID: 2082 RVA: 0x0002D877 File Offset: 0x0002BA77
		internal bool InvalidStatusCode
		{
			get
			{
				return this.Status < 100 || this.Status > 599;
			}
		}

		// Token: 0x04000598 RID: 1432
		internal bool Multiline;

		// Token: 0x04000599 RID: 1433
		internal int Status = -1;

		// Token: 0x0400059A RID: 1434
		internal string StatusDescription;

		// Token: 0x0400059B RID: 1435
		internal StringBuilder StatusBuffer = new StringBuilder();

		// Token: 0x0400059C RID: 1436
		internal string StatusCodeString;
	}
}
