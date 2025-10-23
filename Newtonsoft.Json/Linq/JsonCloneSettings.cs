using System;
using System.Runtime.CompilerServices;

namespace Newtonsoft.Json.Linq
{
	// Token: 0x0200017C RID: 380
	public class JsonCloneSettings
	{
		// Token: 0x06000C96 RID: 3222 RVA: 0x000386E2 File Offset: 0x000368E2
		public JsonCloneSettings()
		{
			this.CopyAnnotations = true;
		}

		// Token: 0x1700020B RID: 523
		// (get) Token: 0x06000C97 RID: 3223 RVA: 0x000386F1 File Offset: 0x000368F1
		// (set) Token: 0x06000C98 RID: 3224 RVA: 0x000386F9 File Offset: 0x000368F9
		public bool CopyAnnotations { get; set; }

		// Token: 0x040006FB RID: 1787
		[Nullable(1)]
		internal static readonly JsonCloneSettings SkipCopyAnnotations = new JsonCloneSettings
		{
			CopyAnnotations = false
		};
	}
}
