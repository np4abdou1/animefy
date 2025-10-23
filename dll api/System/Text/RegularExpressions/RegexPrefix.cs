using System;

namespace System.Text.RegularExpressions
{
	// Token: 0x020000B5 RID: 181
	internal readonly struct RegexPrefix
	{
		// Token: 0x06000578 RID: 1400 RVA: 0x000227DC File Offset: 0x000209DC
		internal RegexPrefix(string prefix, bool ci)
		{
			this.Prefix = prefix;
			this.CaseInsensitive = ci;
		}

		// Token: 0x170000B7 RID: 183
		// (get) Token: 0x06000579 RID: 1401 RVA: 0x000227EC File Offset: 0x000209EC
		internal bool CaseInsensitive { get; }

		// Token: 0x170000B8 RID: 184
		// (get) Token: 0x0600057A RID: 1402 RVA: 0x000227F4 File Offset: 0x000209F4
		internal static RegexPrefix Empty { get; } = new RegexPrefix(string.Empty, false);

		// Token: 0x170000B9 RID: 185
		// (get) Token: 0x0600057B RID: 1403 RVA: 0x000227FB File Offset: 0x000209FB
		internal string Prefix { get; }
	}
}
