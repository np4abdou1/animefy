﻿using System;

// Token: 0x02000002 RID: 2
internal sealed class Locale
{
	// Token: 0x06000001 RID: 1 RVA: 0x00002050 File Offset: 0x00000250
	public static string GetText(string msg)
	{
		return msg;
	}

	// Token: 0x06000002 RID: 2 RVA: 0x00002053 File Offset: 0x00000253
	public static string GetText(string fmt, params object[] args)
	{
		return string.Format(fmt, args);
	}
}
