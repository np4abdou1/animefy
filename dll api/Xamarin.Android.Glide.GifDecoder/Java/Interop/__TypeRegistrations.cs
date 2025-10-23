using System;

namespace Java.Interop
{
	// Token: 0x02000011 RID: 17
	internal class __TypeRegistrations
	{
		// Token: 0x0600003A RID: 58 RVA: 0x00002058 File Offset: 0x00000258
		public static void RegisterPackages()
		{
			TypeManager.RegisterPackages(new string[]
			{
				"com/bumptech/glide/gifdecoder"
			}, new Converter<string, Type>[]
			{
				new Converter<string, Type>(__TypeRegistrations.lookup_com_bumptech_glide_gifdecoder_package)
			});
		}

		// Token: 0x0600003B RID: 59 RVA: 0x00002084 File Offset: 0x00000284
		private static Type Lookup(string[] mappings, string javaType)
		{
			string text = TypeManager.LookupTypeMapping(mappings, javaType);
			if (text == null)
			{
				return null;
			}
			return Type.GetType(text);
		}

		// Token: 0x0600003C RID: 60 RVA: 0x000020A4 File Offset: 0x000002A4
		private static Type lookup_com_bumptech_glide_gifdecoder_package(string klass)
		{
			if (__TypeRegistrations.package_com_bumptech_glide_gifdecoder_mappings == null)
			{
				__TypeRegistrations.package_com_bumptech_glide_gifdecoder_mappings = new string[]
				{
					"com/bumptech/glide/gifdecoder/GifHeader:Bumptech.Glide.GifDecoder.GifHeader",
					"com/bumptech/glide/gifdecoder/GifHeaderParser:Bumptech.Glide.GifDecoder.GifHeaderParser",
					"com/bumptech/glide/gifdecoder/StandardGifDecoder:Bumptech.Glide.GifDecoder.StandardGifDecoder"
				};
			}
			return __TypeRegistrations.Lookup(__TypeRegistrations.package_com_bumptech_glide_gifdecoder_mappings, klass);
		}

		// Token: 0x04000001 RID: 1
		private static string[] package_com_bumptech_glide_gifdecoder_mappings;
	}
}
