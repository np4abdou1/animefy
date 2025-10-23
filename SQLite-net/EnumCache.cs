using System;
using System.Collections.Generic;

namespace SQLite
{
	// Token: 0x0200002A RID: 42
	internal static class EnumCache
	{
		// Token: 0x06000114 RID: 276 RVA: 0x00004F53 File Offset: 0x00003153
		public static EnumCacheInfo GetInfo<T>()
		{
			return EnumCache.GetInfo(typeof(T));
		}

		// Token: 0x06000115 RID: 277 RVA: 0x00004F64 File Offset: 0x00003164
		public static EnumCacheInfo GetInfo(Type type)
		{
			Dictionary<Type, EnumCacheInfo> cache = EnumCache.Cache;
			EnumCacheInfo result;
			lock (cache)
			{
				EnumCacheInfo enumCacheInfo = null;
				if (!EnumCache.Cache.TryGetValue(type, out enumCacheInfo))
				{
					enumCacheInfo = new EnumCacheInfo(type);
					EnumCache.Cache[type] = enumCacheInfo;
				}
				result = enumCacheInfo;
			}
			return result;
		}

		// Token: 0x04000093 RID: 147
		private static readonly Dictionary<Type, EnumCacheInfo> Cache = new Dictionary<Type, EnumCacheInfo>();
	}
}
