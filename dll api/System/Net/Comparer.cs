using System;
using System.Collections;

namespace System.Net
{
	// Token: 0x02000184 RID: 388
	internal class Comparer : IComparer
	{
		// Token: 0x06000A8C RID: 2700 RVA: 0x00037D38 File Offset: 0x00035F38
		int IComparer.Compare(object ol, object or)
		{
			Cookie cookie = (Cookie)ol;
			Cookie cookie2 = (Cookie)or;
			int result;
			if ((result = string.Compare(cookie.Name, cookie2.Name, StringComparison.OrdinalIgnoreCase)) != 0)
			{
				return result;
			}
			if ((result = string.Compare(cookie.Domain, cookie2.Domain, StringComparison.OrdinalIgnoreCase)) != 0)
			{
				return result;
			}
			if ((result = string.Compare(cookie.Path, cookie2.Path, StringComparison.Ordinal)) != 0)
			{
				return result;
			}
			return 0;
		}
	}
}
