using System;
using System.Globalization;

// Token: 0x0200000D RID: 13
internal static class SR
{
	// Token: 0x06000024 RID: 36 RVA: 0x00002466 File Offset: 0x00000666
	internal static string GetString(string name, params object[] args)
	{
		return SR.GetString(CultureInfo.InvariantCulture, name, args);
	}

	// Token: 0x06000025 RID: 37 RVA: 0x00002474 File Offset: 0x00000674
	internal static string GetString(CultureInfo culture, string name, params object[] args)
	{
		return string.Format(culture, name, args);
	}

	// Token: 0x06000026 RID: 38 RVA: 0x0000245A File Offset: 0x0000065A
	internal static string GetString(string name)
	{
		return name;
	}

	// Token: 0x06000027 RID: 39 RVA: 0x0000247E File Offset: 0x0000067E
	internal static string Format(string resourceFormat, object p1)
	{
		return string.Format(CultureInfo.InvariantCulture, resourceFormat, p1);
	}

	// Token: 0x06000028 RID: 40 RVA: 0x0000248C File Offset: 0x0000068C
	internal static string Format(string resourceFormat, object p1, object p2)
	{
		return string.Format(CultureInfo.InvariantCulture, resourceFormat, p1, p2);
	}

	// Token: 0x06000029 RID: 41 RVA: 0x0000249B File Offset: 0x0000069B
	internal static string Format(string resourceFormat, object p1, object p2, object p3)
	{
		return string.Format(CultureInfo.InvariantCulture, resourceFormat, p1, p2, p3);
	}

	// Token: 0x0600002A RID: 42 RVA: 0x0000245A File Offset: 0x0000065A
	internal static string GetResourceString(string str)
	{
		return str;
	}
}
