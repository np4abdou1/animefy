using System;
using System.Collections.Concurrent;

namespace System.Runtime.Serialization.Formatters.Binary
{
	// Token: 0x020003F2 RID: 1010
	internal sealed class NameCache
	{
		// Token: 0x06001F0B RID: 7947 RVA: 0x00085E40 File Offset: 0x00084040
		internal object GetCachedValue(string name)
		{
			this.name = name;
			object result;
			if (!NameCache.ht.TryGetValue(name, out result))
			{
				return null;
			}
			return result;
		}

		// Token: 0x06001F0C RID: 7948 RVA: 0x00085E66 File Offset: 0x00084066
		internal void SetCachedValue(object value)
		{
			NameCache.ht[this.name] = value;
		}

		// Token: 0x04000E46 RID: 3654
		private static ConcurrentDictionary<string, object> ht = new ConcurrentDictionary<string, object>();

		// Token: 0x04000E47 RID: 3655
		private string name;
	}
}
