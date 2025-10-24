using System;

// Token: 0x0200000B RID: 11
internal static class InteropErrorExtensions
{
	// Token: 0x06000021 RID: 33 RVA: 0x00002452 File Offset: 0x00000652
	public static Interop.ErrorInfo Info(this Interop.Error error)
	{
		return new Interop.ErrorInfo(error);
	}
}
