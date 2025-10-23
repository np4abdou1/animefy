using System;
using System.Globalization;
using System.Threading;

namespace Android.Runtime
{
	// Token: 0x020002B4 RID: 692
	internal class DynamicMethodNameCounter
	{
		// Token: 0x06001A75 RID: 6773 RVA: 0x00044894 File Offset: 0x00042A94
		internal static string GetUniqueName()
		{
			return Interlocked.Increment(ref DynamicMethodNameCounter.dynamicMethodNameCounter).ToString(CultureInfo.InvariantCulture);
		}

		// Token: 0x04000B5F RID: 2911
		private static long dynamicMethodNameCounter;
	}
}
