using System;
using System.Collections.Generic;

namespace System.Net
{
	// Token: 0x02000193 RID: 403
	internal class AutoWebProxyScriptEngine
	{
		// Token: 0x06000B11 RID: 2833 RVA: 0x0003A550 File Offset: 0x00038750
		public bool GetProxies(Uri destination, out IList<string> proxyList)
		{
			int num = 0;
			return this.GetProxies(destination, out proxyList, ref num);
		}

		// Token: 0x06000B12 RID: 2834 RVA: 0x0003A569 File Offset: 0x00038769
		public bool GetProxies(Uri destination, out IList<string> proxyList, ref int syncStatus)
		{
			proxyList = null;
			return false;
		}
	}
}
