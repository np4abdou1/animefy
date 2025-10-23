using System;

namespace Java.Interop
{
	// Token: 0x02000003 RID: 3
	internal class __TypeRegistrations
	{
		// Token: 0x06000002 RID: 2 RVA: 0x00002058 File Offset: 0x00000258
		public static void RegisterPackages()
		{
			TypeManager.RegisterPackages(new string[]
			{
				"com/bumptech/glide/disklrucache"
			}, new Converter<string, Type>[]
			{
				new Converter<string, Type>(__TypeRegistrations.lookup_com_bumptech_glide_disklrucache_package)
			});
		}

		// Token: 0x06000003 RID: 3 RVA: 0x00002084 File Offset: 0x00000284
		private static Type Lookup(string[] mappings, string javaType)
		{
			string text = TypeManager.LookupTypeMapping(mappings, javaType);
			if (text == null)
			{
				return null;
			}
			return Type.GetType(text);
		}

		// Token: 0x06000004 RID: 4 RVA: 0x000020A4 File Offset: 0x000002A4
		private static Type lookup_com_bumptech_glide_disklrucache_package(string klass)
		{
			if (__TypeRegistrations.package_com_bumptech_glide_disklrucache_mappings == null)
			{
				__TypeRegistrations.package_com_bumptech_glide_disklrucache_mappings = new string[]
				{
					"com/bumptech/glide/disklrucache/DiskLruCache:Bumptech.Glide.DiskLruCache.DiskLruCache",
					"com/bumptech/glide/disklrucache/DiskLruCache$Editor:Bumptech.Glide.DiskLruCache.DiskLruCache/Editor",
					"com/bumptech/glide/disklrucache/DiskLruCache$Value:Bumptech.Glide.DiskLruCache.DiskLruCache/Value"
				};
			}
			return __TypeRegistrations.Lookup(__TypeRegistrations.package_com_bumptech_glide_disklrucache_mappings, klass);
		}

		// Token: 0x04000001 RID: 1
		private static string[] package_com_bumptech_glide_disklrucache_mappings;
	}
}
