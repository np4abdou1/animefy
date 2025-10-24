using System;

namespace System.Net
{
	// Token: 0x02000110 RID: 272
	internal static class TcpValidationHelpers
	{
		// Token: 0x060007C2 RID: 1986 RVA: 0x0002C17C File Offset: 0x0002A37C
		public static bool ValidatePortNumber(int port)
		{
			return port >= 0 && port <= 65535;
		}
	}
}
