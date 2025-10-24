using System;

namespace Newtonsoft.Json.Linq
{
	// Token: 0x0200017F RID: 383
	public class JsonSelectSettings
	{
		// Token: 0x17000212 RID: 530
		// (get) Token: 0x06000CA8 RID: 3240 RVA: 0x00038819 File Offset: 0x00036A19
		// (set) Token: 0x06000CA9 RID: 3241 RVA: 0x00038821 File Offset: 0x00036A21
		public TimeSpan? RegexMatchTimeout { get; set; }

		// Token: 0x17000213 RID: 531
		// (get) Token: 0x06000CAA RID: 3242 RVA: 0x0003882A File Offset: 0x00036A2A
		// (set) Token: 0x06000CAB RID: 3243 RVA: 0x00038832 File Offset: 0x00036A32
		public bool ErrorWhenNoMatch { get; set; }
	}
}
