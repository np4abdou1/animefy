using System;
using System.Runtime.ExceptionServices;

namespace Internal.Runtime.Augments
{
	// Token: 0x0200065F RID: 1631
	internal class RuntimeAugments
	{
		// Token: 0x0600311B RID: 12571 RVA: 0x00087BEB File Offset: 0x00085DEB
		public static void ReportUnhandledException(Exception exception)
		{
			ExceptionDispatchInfo.Capture(exception).Throw();
		}
	}
}
