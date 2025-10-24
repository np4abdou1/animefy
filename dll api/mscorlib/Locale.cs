using System;

// Token: 0x0200000C RID: 12
internal sealed class Locale
{
	// Token: 0x06000022 RID: 34 RVA: 0x0000245A File Offset: 0x0000065A
	public static string GetText(string msg)
	{
		return msg;
	}

	// Token: 0x06000023 RID: 35 RVA: 0x0000245D File Offset: 0x0000065D
	public static string GetText(string fmt, params object[] args)
	{
		return string.Format(fmt, args);
	}
}
