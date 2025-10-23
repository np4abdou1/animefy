using System;

namespace System
{
	// Token: 0x02000073 RID: 115
	internal static class NotImplemented
	{
		// Token: 0x060002D8 RID: 728 RVA: 0x0000B917 File Offset: 0x00009B17
		internal static Exception ByDesignWithMessage(string message)
		{
			return new NotImplementedException(message);
		}
	}
}
