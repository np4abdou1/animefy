using System;

namespace Java.Interop
{
	// Token: 0x02000034 RID: 52
	internal class __TypeRegistrations
	{
		// Token: 0x060000BE RID: 190 RVA: 0x00002098 File Offset: 0x00000298
		public static void RegisterPackages()
		{
			TypeManager.RegisterPackages(new string[]
			{
				"com/bumptech/glide",
				"com/bumptech/glide/load/data",
				"com/bumptech/glide/load/data/mediastore",
				"com/bumptech/glide/load",
				"com/bumptech/glide/load/engine/bitmap_recycle",
				"com/bumptech/glide/load/engine/cache",
				"com/bumptech/glide/load/engine",
				"com/bumptech/glide/load/engine/executor",
				"com/bumptech/glide/load/engine/prefill",
				"com/bumptech/glide/load/model",
				"com/bumptech/glide/load/model/stream",
				"com/bumptech/glide/load/resource/bitmap",
				"com/bumptech/glide/load/resource/bytes",
				"com/bumptech/glide/load/resource",
				"com/bumptech/glide/load/resource/drawable",
				"com/bumptech/glide/load/resource/file",
				"com/bumptech/glide/load/resource/gif",
				"com/bumptech/glide/load/resource/transcode",
				"com/bumptech/glide/manager",
				"com/bumptech/glide/module",
				"com/bumptech/glide/provider",
				"com/bumptech/glide/request",
				"com/bumptech/glide/request/target",
				"com/bumptech/glide/request/transition",
				"com/bumptech/glide/signature",
				"com/bumptech/glide/util",
				"com/bumptech/glide/util/pool"
			}, new Converter<string, Type>[]
			{
				new Converter<string, Type>(__TypeRegistrations.lookup_com_bumptech_glide_package),
				new Converter<string, Type>(__TypeRegistrations.lookup_com_bumptech_glide_load_data_package),
				new Converter<string, Type>(__TypeRegistrations.lookup_com_bumptech_glide_load_data_mediastore_package),
				new Converter<string, Type>(__TypeRegistrations.lookup_com_bumptech_glide_load_package),
				new Converter<string, Type>(__TypeRegistrations.lookup_com_bumptech_glide_load_engine_bitmap_recycle_package),
				new Converter<string, Type>(__TypeRegistrations.lookup_com_bumptech_glide_load_engine_cache_package),
				new Converter<string, Type>(__TypeRegistrations.lookup_com_bumptech_glide_load_engine_package),
				new Converter<string, Type>(__TypeRegistrations.lookup_com_bumptech_glide_load_engine_executor_package),
				new Converter<string, Type>(__TypeRegistrations.lookup_com_bumptech_glide_load_engine_prefill_package),
				new Converter<string, Type>(__TypeRegistrations.lookup_com_bumptech_glide_load_model_package),
				new Converter<string, Type>(__TypeRegistrations.lookup_com_bumptech_glide_load_model_stream_package),
				new Converter<string, Type>(__TypeRegistrations.lookup_com_bumptech_glide_load_resource_bitmap_package),
				new Converter<string, Type>(__TypeRegistrations.lookup_com_bumptech_glide_load_resource_bytes_package),
				new Converter<string, Type>(__TypeRegistrations.lookup_com_bumptech_glide_load_resource_package),
				new Converter<string, Type>(__TypeRegistrations.lookup_com_bumptech_glide_load_resource_drawable_package),
				new Converter<string, Type>(__TypeRegistrations.lookup_com_bumptech_glide_load_resource_file_package),
				new Converter<string, Type>(__TypeRegistrations.lookup_com_bumptech_glide_load_resource_gif_package),
				new Converter<string, Type>(__TypeRegistrations.lookup_com_bumptech_glide_load_resource_transcode_package),
				new Converter<string, Type>(__TypeRegistrations.lookup_com_bumptech_glide_manager_package),
				new Converter<string, Type>(__TypeRegistrations.lookup_com_bumptech_glide_module_package),
				new Converter<string, Type>(__TypeRegistrations.lookup_com_bumptech_glide_provider_package),
				new Converter<string, Type>(__TypeRegistrations.lookup_com_bumptech_glide_request_package),
				new Converter<string, Type>(__TypeRegistrations.lookup_com_bumptech_glide_request_target_package),
				new Converter<string, Type>(__TypeRegistrations.lookup_com_bumptech_glide_request_transition_package),
				new Converter<string, Type>(__TypeRegistrations.lookup_com_bumptech_glide_signature_package),
				new Converter<string, Type>(__TypeRegistrations.lookup_com_bumptech_glide_util_package),
				new Converter<string, Type>(__TypeRegistrations.lookup_com_bumptech_glide_util_pool_package)
			});
		}

		// Token: 0x060000BF RID: 191 RVA: 0x0000234C File Offset: 0x0000054C
		private static Type Lookup(string[] mappings, string javaType)
		{
			string text = TypeManager.LookupTypeMapping(mappings, javaType);
			if (text == null)
			{
				return null;
			}
			return Type.GetType(text);
		}

		// Token: 0x060000C0 RID: 192 RVA: 0x0000236C File Offset: 0x0000056C
		private static Type lookup_com_bumptech_glide_package(string klass)
		{
			if (__TypeRegistrations.package_com_bumptech_glide_mappings == null)
			{
				__TypeRegistrations.package_com_bumptech_glide_mappings = new string[]
				{
					"com/bumptech/glide/GeneratedAppGlideModule:Bumptech.Glide.GeneratedAppGlideModule",
					"com/bumptech/glide/GenericTransitionOptions:Bumptech.Glide.GenericTransitionOptions",
					"com/bumptech/glide/Glide:Bumptech.Glide.Glide",
					"com/bumptech/glide/GlideBuilder:Bumptech.Glide.GlideBuilder",
					"com/bumptech/glide/GlideBuilder$LogRequestOrigins:Bumptech.Glide.GlideBuilder/LogRequestOrigins",
					"com/bumptech/glide/GlideBuilder$UseDirectResourceLoader:Bumptech.Glide.GlideBuilder/UseDirectResourceLoader",
					"com/bumptech/glide/GlideBuilder$WaitForFramesAfterTrimMemory:Bumptech.Glide.GlideBuilder/WaitForFramesAfterTrimMemory",
					"com/bumptech/glide/GlideContext:Bumptech.Glide.GlideContext",
					"com/bumptech/glide/GlideExperiments:Bumptech.Glide.GlideExperiments",
					"com/bumptech/glide/ListPreloader:Bumptech.Glide.ListPreloader",
					"com/bumptech/glide/MemoryCategory:Bumptech.Glide.MemoryCategory",
					"com/bumptech/glide/Priority:Bumptech.Glide.Priority",
					"com/bumptech/glide/Registry:Bumptech.Glide.Registry",
					"com/bumptech/glide/Registry$MissingComponentException:Bumptech.Glide.Registry/MissingComponentException",
					"com/bumptech/glide/Registry$NoImageHeaderParserException:Bumptech.Glide.Registry/NoImageHeaderParserException",
					"com/bumptech/glide/Registry$NoModelLoaderAvailableException:Bumptech.Glide.Registry/NoModelLoaderAvailableException",
					"com/bumptech/glide/Registry$NoResultEncoderAvailableException:Bumptech.Glide.Registry/NoResultEncoderAvailableException",
					"com/bumptech/glide/Registry$NoSourceEncoderAvailableException:Bumptech.Glide.Registry/NoSourceEncoderAvailableException",
					"com/bumptech/glide/RequestBuilder:Bumptech.Glide.RequestBuilder",
					"com/bumptech/glide/RequestManager:Bumptech.Glide.RequestManager",
					"com/bumptech/glide/TransitionOptions:Bumptech.Glide.TransitionOptions"
				};
			}
			return __TypeRegistrations.Lookup(__TypeRegistrations.package_com_bumptech_glide_mappings, klass);
		}

		// Token: 0x060000C1 RID: 193 RVA: 0x00002450 File Offset: 0x00000650
		private static Type lookup_com_bumptech_glide_load_data_package(string klass)
		{
			if (__TypeRegistrations.package_com_bumptech_glide_load_data_mappings == null)
			{
				__TypeRegistrations.package_com_bumptech_glide_load_data_mappings = new string[]
				{
					"com/bumptech/glide/load/data/AssetFileDescriptorLocalUriFetcher:Bumptech.Glide.Load.Data.AssetFileDescriptorLocalUriFetcher",
					"com/bumptech/glide/load/data/AssetPathFetcher:Bumptech.Glide.Load.Data.AssetPathFetcher",
					"com/bumptech/glide/load/data/BufferedOutputStream:Bumptech.Glide.Load.Data.BufferedOutputStream",
					"com/bumptech/glide/load/data/DataRewinderRegistry:Bumptech.Glide.Load.Data.DataRewinderRegistry",
					"com/bumptech/glide/load/data/ExifOrientationStream:Bumptech.Glide.Load.Data.ExifOrientationStream",
					"com/bumptech/glide/load/data/FileDescriptorAssetPathFetcher:Bumptech.Glide.Load.Data.FileDescriptorAssetPathFetcher",
					"com/bumptech/glide/load/data/FileDescriptorLocalUriFetcher:Bumptech.Glide.Load.Data.FileDescriptorLocalUriFetcher",
					"com/bumptech/glide/load/data/HttpUrlFetcher:Bumptech.Glide.Load.Data.HttpUrlFetcher",
					"com/bumptech/glide/load/data/InputStreamRewinder:Bumptech.Glide.Load.Data.InputStreamRewinder",
					"com/bumptech/glide/load/data/InputStreamRewinder$Factory:Bumptech.Glide.Load.Data.InputStreamRewinder/Factory",
					"com/bumptech/glide/load/data/LocalUriFetcher:Bumptech.Glide.Load.Data.LocalUriFetcher",
					"com/bumptech/glide/load/data/ParcelFileDescriptorRewinder:Bumptech.Glide.Load.Data.ParcelFileDescriptorRewinder",
					"com/bumptech/glide/load/data/ParcelFileDescriptorRewinder$Factory:Bumptech.Glide.Load.Data.ParcelFileDescriptorRewinder/Factory",
					"com/bumptech/glide/load/data/StreamAssetPathFetcher:Bumptech.Glide.Load.Data.StreamAssetPathFetcher",
					"com/bumptech/glide/load/data/StreamLocalUriFetcher:Bumptech.Glide.Load.Data.StreamLocalUriFetcher"
				};
			}
			return __TypeRegistrations.Lookup(__TypeRegistrations.package_com_bumptech_glide_load_data_mappings, klass);
		}

		// Token: 0x060000C2 RID: 194 RVA: 0x000024FC File Offset: 0x000006FC
		private static Type lookup_com_bumptech_glide_load_data_mediastore_package(string klass)
		{
			if (__TypeRegistrations.package_com_bumptech_glide_load_data_mediastore_mappings == null)
			{
				__TypeRegistrations.package_com_bumptech_glide_load_data_mediastore_mappings = new string[]
				{
					"com/bumptech/glide/load/data/mediastore/MediaStoreUtil:Bumptech.Glide.Load.Data.Mediastore.MediaStoreUtil",
					"com/bumptech/glide/load/data/mediastore/ThumbFetcher:Bumptech.Glide.Load.Data.Mediastore.ThumbFetcher"
				};
			}
			return __TypeRegistrations.Lookup(__TypeRegistrations.package_com_bumptech_glide_load_data_mediastore_mappings, klass);
		}

		// Token: 0x060000C3 RID: 195 RVA: 0x0000252C File Offset: 0x0000072C
		private static Type lookup_com_bumptech_glide_load_package(string klass)
		{
			if (__TypeRegistrations.package_com_bumptech_glide_load_mappings == null)
			{
				__TypeRegistrations.package_com_bumptech_glide_load_mappings = new string[]
				{
					"com/bumptech/glide/load/DataSource:Bumptech.Glide.Load.DataSource",
					"com/bumptech/glide/load/DecodeFormat:Bumptech.Glide.Load.DecodeFormat",
					"com/bumptech/glide/load/EncodeStrategy:Bumptech.Glide.Load.EncodeStrategy",
					"com/bumptech/glide/load/HttpException:Bumptech.Glide.Load.HttpException",
					"com/bumptech/glide/load/ImageHeaderParser$ImageType:Bumptech.Glide.Load.ImageHeaderParserImageType",
					"com/bumptech/glide/load/ImageHeaderParserUtils:Bumptech.Glide.Load.ImageHeaderParserUtils",
					"com/bumptech/glide/load/MultiTransformation:Bumptech.Glide.Load.MultiTransformation",
					"com/bumptech/glide/load/Option:Bumptech.Glide.Load.Option",
					"com/bumptech/glide/load/Options:Bumptech.Glide.Load.Options",
					"com/bumptech/glide/load/PreferredColorSpace:Bumptech.Glide.Load.PreferredColorSpace"
				};
			}
			return __TypeRegistrations.Lookup(__TypeRegistrations.package_com_bumptech_glide_load_mappings, klass);
		}

		// Token: 0x060000C4 RID: 196 RVA: 0x000025A8 File Offset: 0x000007A8
		private static Type lookup_com_bumptech_glide_load_engine_bitmap_recycle_package(string klass)
		{
			if (__TypeRegistrations.package_com_bumptech_glide_load_engine_bitmap_recycle_mappings == null)
			{
				__TypeRegistrations.package_com_bumptech_glide_load_engine_bitmap_recycle_mappings = new string[]
				{
					"com/bumptech/glide/load/engine/bitmap_recycle/BaseKeyPool:Bumptech.Glide.Load.Engine.BitmapRecycle.BaseKeyPool",
					"com/bumptech/glide/load/engine/bitmap_recycle/BitmapPoolAdapter:Bumptech.Glide.Load.Engine.BitmapRecycle.BitmapPoolAdapter",
					"com/bumptech/glide/load/engine/bitmap_recycle/ByteArrayAdapter:Bumptech.Glide.Load.Engine.BitmapRecycle.ByteArrayAdapter",
					"com/bumptech/glide/load/engine/bitmap_recycle/IntegerArrayAdapter:Bumptech.Glide.Load.Engine.BitmapRecycle.IntegerArrayAdapter",
					"com/bumptech/glide/load/engine/bitmap_recycle/LruArrayPool:Bumptech.Glide.Load.Engine.BitmapRecycle.LruArrayPool",
					"com/bumptech/glide/load/engine/bitmap_recycle/LruBitmapPool:Bumptech.Glide.Load.Engine.BitmapRecycle.LruBitmapPool",
					"com/bumptech/glide/load/engine/bitmap_recycle/SizeConfigStrategy:Bumptech.Glide.Load.Engine.BitmapRecycle.SizeConfigStrategy"
				};
			}
			return __TypeRegistrations.Lookup(__TypeRegistrations.package_com_bumptech_glide_load_engine_bitmap_recycle_mappings, klass);
		}

		// Token: 0x060000C5 RID: 197 RVA: 0x0000260C File Offset: 0x0000080C
		private static Type lookup_com_bumptech_glide_load_engine_cache_package(string klass)
		{
			if (__TypeRegistrations.package_com_bumptech_glide_load_engine_cache_mappings == null)
			{
				__TypeRegistrations.package_com_bumptech_glide_load_engine_cache_mappings = new string[]
				{
					"com/bumptech/glide/load/engine/cache/DiskCacheAdapter:Bumptech.Glide.Load.Engine.Cache.DiskCacheAdapter",
					"com/bumptech/glide/load/engine/cache/DiskCacheAdapter$Factory:Bumptech.Glide.Load.Engine.Cache.DiskCacheAdapter/Factory",
					"com/bumptech/glide/load/engine/cache/DiskLruCacheFactory:Bumptech.Glide.Load.Engine.Cache.DiskLruCacheFactory",
					"com/bumptech/glide/load/engine/cache/DiskLruCacheWrapper:Bumptech.Glide.Load.Engine.Cache.DiskLruCacheWrapper",
					"com/bumptech/glide/load/engine/cache/ExternalCacheDiskCacheFactory:Bumptech.Glide.Load.Engine.Cache.ExternalCacheDiskCacheFactory",
					"com/bumptech/glide/load/engine/cache/ExternalPreferredCacheDiskCacheFactory:Bumptech.Glide.Load.Engine.Cache.ExternalPreferredCacheDiskCacheFactory",
					"com/bumptech/glide/load/engine/cache/InternalCacheDiskCacheFactory:Bumptech.Glide.Load.Engine.Cache.InternalCacheDiskCacheFactory",
					"com/bumptech/glide/load/engine/cache/LruResourceCache:Bumptech.Glide.Load.Engine.Cache.LruResourceCache",
					"com/bumptech/glide/load/engine/cache/MemoryCacheAdapter:Bumptech.Glide.Load.Engine.Cache.MemoryCacheAdapter",
					"com/bumptech/glide/load/engine/cache/MemorySizeCalculator:Bumptech.Glide.Load.Engine.Cache.MemorySizeCalculator",
					"com/bumptech/glide/load/engine/cache/MemorySizeCalculator$Builder:Bumptech.Glide.Load.Engine.Cache.MemorySizeCalculator/Builder",
					"com/bumptech/glide/load/engine/cache/SafeKeyGenerator:Bumptech.Glide.Load.Engine.Cache.SafeKeyGenerator"
				};
			}
			return __TypeRegistrations.Lookup(__TypeRegistrations.package_com_bumptech_glide_load_engine_cache_mappings, klass);
		}

		// Token: 0x060000C6 RID: 198 RVA: 0x0000269C File Offset: 0x0000089C
		private static Type lookup_com_bumptech_glide_load_engine_package(string klass)
		{
			if (__TypeRegistrations.package_com_bumptech_glide_load_engine_mappings == null)
			{
				__TypeRegistrations.package_com_bumptech_glide_load_engine_mappings = new string[]
				{
					"com/bumptech/glide/load/engine/DecodePath:Bumptech.Glide.Load.Engine.DecodePath",
					"com/bumptech/glide/load/engine/DiskCacheStrategy:Bumptech.Glide.Load.Engine.DiskCacheStrategy",
					"com/bumptech/glide/load/engine/Engine:Bumptech.Glide.Load.Engine.Engine",
					"com/bumptech/glide/load/engine/Engine$LoadStatus:Bumptech.Glide.Load.Engine.Engine/LoadStatus",
					"com/bumptech/glide/load/engine/GlideException:Bumptech.Glide.Load.Engine.GlideException",
					"com/bumptech/glide/load/engine/LoadPath:Bumptech.Glide.Load.Engine.LoadPath"
				};
			}
			return __TypeRegistrations.Lookup(__TypeRegistrations.package_com_bumptech_glide_load_engine_mappings, klass);
		}

		// Token: 0x060000C7 RID: 199 RVA: 0x000026F6 File Offset: 0x000008F6
		private static Type lookup_com_bumptech_glide_load_engine_executor_package(string klass)
		{
			if (__TypeRegistrations.package_com_bumptech_glide_load_engine_executor_mappings == null)
			{
				__TypeRegistrations.package_com_bumptech_glide_load_engine_executor_mappings = new string[]
				{
					"com/bumptech/glide/load/engine/executor/GlideExecutor:Bumptech.Glide.Load.Engine.Executor.GlideExecutor",
					"com/bumptech/glide/load/engine/executor/GlideExecutor$Builder:Bumptech.Glide.Load.Engine.Executor.GlideExecutor/Builder"
				};
			}
			return __TypeRegistrations.Lookup(__TypeRegistrations.package_com_bumptech_glide_load_engine_executor_mappings, klass);
		}

		// Token: 0x060000C8 RID: 200 RVA: 0x00002725 File Offset: 0x00000925
		private static Type lookup_com_bumptech_glide_load_engine_prefill_package(string klass)
		{
			if (__TypeRegistrations.package_com_bumptech_glide_load_engine_prefill_mappings == null)
			{
				__TypeRegistrations.package_com_bumptech_glide_load_engine_prefill_mappings = new string[]
				{
					"com/bumptech/glide/load/engine/prefill/BitmapPreFiller:Bumptech.Glide.Load.Engine.Prefill.BitmapPreFiller",
					"com/bumptech/glide/load/engine/prefill/PreFillType:Bumptech.Glide.Load.Engine.Prefill.PreFillType",
					"com/bumptech/glide/load/engine/prefill/PreFillType$Builder:Bumptech.Glide.Load.Engine.Prefill.PreFillType/Builder"
				};
			}
			return __TypeRegistrations.Lookup(__TypeRegistrations.package_com_bumptech_glide_load_engine_prefill_mappings, klass);
		}

		// Token: 0x060000C9 RID: 201 RVA: 0x0000275C File Offset: 0x0000095C
		private static Type lookup_com_bumptech_glide_load_model_package(string klass)
		{
			if (__TypeRegistrations.package_com_bumptech_glide_load_model_mappings == null)
			{
				__TypeRegistrations.package_com_bumptech_glide_load_model_mappings = new string[]
				{
					"com/bumptech/glide/load/model/AssetUriLoader:Bumptech.Glide.Load.Model.AssetUriLoader",
					"com/bumptech/glide/load/model/AssetUriLoader$FileDescriptorFactory:Bumptech.Glide.Load.Model.AssetUriLoader/FileDescriptorFactory",
					"com/bumptech/glide/load/model/AssetUriLoader$StreamFactory:Bumptech.Glide.Load.Model.AssetUriLoader/StreamFactory",
					"com/bumptech/glide/load/model/ByteArrayLoader:Bumptech.Glide.Load.Model.ByteArrayLoader",
					"com/bumptech/glide/load/model/ByteArrayLoader$ByteBufferFactory:Bumptech.Glide.Load.Model.ByteArrayLoader/ByteBufferFactory",
					"com/bumptech/glide/load/model/ByteArrayLoader$StreamFactory:Bumptech.Glide.Load.Model.ByteArrayLoader/StreamFactory",
					"com/bumptech/glide/load/model/ByteBufferEncoder:Bumptech.Glide.Load.Model.ByteBufferEncoder",
					"com/bumptech/glide/load/model/ByteBufferFileLoader:Bumptech.Glide.Load.Model.ByteBufferFileLoader",
					"com/bumptech/glide/load/model/ByteBufferFileLoader$Factory:Bumptech.Glide.Load.Model.ByteBufferFileLoader/Factory",
					"com/bumptech/glide/load/model/DataUrlLoader:Bumptech.Glide.Load.Model.DataUrlLoader",
					"com/bumptech/glide/load/model/DataUrlLoader$StreamFactory:Bumptech.Glide.Load.Model.DataUrlLoader/StreamFactory",
					"com/bumptech/glide/load/model/DirectResourceLoader:Bumptech.Glide.Load.Model.DirectResourceLoader",
					"com/bumptech/glide/load/model/FileLoader:Bumptech.Glide.Load.Model.FileLoader",
					"com/bumptech/glide/load/model/FileLoader$Factory:Bumptech.Glide.Load.Model.FileLoader/Factory",
					"com/bumptech/glide/load/model/FileLoader$FileDescriptorFactory:Bumptech.Glide.Load.Model.FileLoader/FileDescriptorFactory",
					"com/bumptech/glide/load/model/FileLoader$StreamFactory:Bumptech.Glide.Load.Model.FileLoader/StreamFactory",
					"com/bumptech/glide/load/model/GlideUrl:Bumptech.Glide.Load.Model.GlideUrl",
					"com/bumptech/glide/load/model/LazyHeaders:Bumptech.Glide.Load.Model.LazyHeaders",
					"com/bumptech/glide/load/model/LazyHeaders$Builder:Bumptech.Glide.Load.Model.LazyHeaders/Builder",
					"com/bumptech/glide/load/model/MediaStoreFileLoader:Bumptech.Glide.Load.Model.MediaStoreFileLoader",
					"com/bumptech/glide/load/model/MediaStoreFileLoader$Factory:Bumptech.Glide.Load.Model.MediaStoreFileLoader/Factory",
					"com/bumptech/glide/load/model/ModelCache:Bumptech.Glide.Load.Model.ModelCache",
					"com/bumptech/glide/load/model/ModelLoader$LoadData:Bumptech.Glide.Load.Model.ModelLoaderLoadData",
					"com/bumptech/glide/load/model/ModelLoaderRegistry:Bumptech.Glide.Load.Model.ModelLoaderRegistry",
					"com/bumptech/glide/load/model/MultiModelLoaderFactory:Bumptech.Glide.Load.Model.MultiModelLoaderFactory",
					"com/bumptech/glide/load/model/ResourceLoader:Bumptech.Glide.Load.Model.ResourceLoader",
					"com/bumptech/glide/load/model/ResourceLoader$AssetFileDescriptorFactory:Bumptech.Glide.Load.Model.ResourceLoader/AssetFileDescriptorFactory",
					"com/bumptech/glide/load/model/ResourceLoader$FileDescriptorFactory:Bumptech.Glide.Load.Model.ResourceLoader/FileDescriptorFactory",
					"com/bumptech/glide/load/model/ResourceLoader$StreamFactory:Bumptech.Glide.Load.Model.ResourceLoader/StreamFactory",
					"com/bumptech/glide/load/model/ResourceLoader$UriFactory:Bumptech.Glide.Load.Model.ResourceLoader/UriFactory",
					"com/bumptech/glide/load/model/ResourceUriLoader:Bumptech.Glide.Load.Model.ResourceUriLoader",
					"com/bumptech/glide/load/model/StreamEncoder:Bumptech.Glide.Load.Model.StreamEncoder",
					"com/bumptech/glide/load/model/StringLoader:Bumptech.Glide.Load.Model.StringLoader",
					"com/bumptech/glide/load/model/StringLoader$AssetFileDescriptorFactory:Bumptech.Glide.Load.Model.StringLoader/AssetFileDescriptorFactory",
					"com/bumptech/glide/load/model/StringLoader$FileDescriptorFactory:Bumptech.Glide.Load.Model.StringLoader/FileDescriptorFactory",
					"com/bumptech/glide/load/model/StringLoader$StreamFactory:Bumptech.Glide.Load.Model.StringLoader/StreamFactory",
					"com/bumptech/glide/load/model/UnitModelLoader:Bumptech.Glide.Load.Model.UnitModelLoader",
					"com/bumptech/glide/load/model/UnitModelLoader$Factory:Bumptech.Glide.Load.Model.UnitModelLoader/Factory",
					"com/bumptech/glide/load/model/UriLoader:Bumptech.Glide.Load.Model.UriLoader",
					"com/bumptech/glide/load/model/UriLoader$AssetFileDescriptorFactory:Bumptech.Glide.Load.Model.UriLoader/AssetFileDescriptorFactory",
					"com/bumptech/glide/load/model/UriLoader$FileDescriptorFactory:Bumptech.Glide.Load.Model.UriLoader/FileDescriptorFactory",
					"com/bumptech/glide/load/model/UriLoader$StreamFactory:Bumptech.Glide.Load.Model.UriLoader/StreamFactory",
					"com/bumptech/glide/load/model/UrlUriLoader:Bumptech.Glide.Load.Model.UrlUriLoader",
					"com/bumptech/glide/load/model/UrlUriLoader$StreamFactory:Bumptech.Glide.Load.Model.UrlUriLoader/StreamFactory"
				};
			}
			return __TypeRegistrations.Lookup(__TypeRegistrations.package_com_bumptech_glide_load_model_mappings, klass);
		}

		// Token: 0x060000CA RID: 202 RVA: 0x00002910 File Offset: 0x00000B10
		private static Type lookup_com_bumptech_glide_load_model_stream_package(string klass)
		{
			if (__TypeRegistrations.package_com_bumptech_glide_load_model_stream_mappings == null)
			{
				__TypeRegistrations.package_com_bumptech_glide_load_model_stream_mappings = new string[]
				{
					"com/bumptech/glide/load/model/stream/BaseGlideUrlLoader:Bumptech.Glide.Load.Model.Stream.BaseGlideUrlLoader",
					"com/bumptech/glide/load/model/stream/HttpGlideUrlLoader:Bumptech.Glide.Load.Model.Stream.HttpGlideUrlLoader",
					"com/bumptech/glide/load/model/stream/HttpGlideUrlLoader$Factory:Bumptech.Glide.Load.Model.Stream.HttpGlideUrlLoader/Factory",
					"com/bumptech/glide/load/model/stream/HttpUriLoader:Bumptech.Glide.Load.Model.Stream.HttpUriLoader",
					"com/bumptech/glide/load/model/stream/HttpUriLoader$Factory:Bumptech.Glide.Load.Model.Stream.HttpUriLoader/Factory",
					"com/bumptech/glide/load/model/stream/MediaStoreImageThumbLoader:Bumptech.Glide.Load.Model.Stream.MediaStoreImageThumbLoader",
					"com/bumptech/glide/load/model/stream/MediaStoreImageThumbLoader$Factory:Bumptech.Glide.Load.Model.Stream.MediaStoreImageThumbLoader/Factory",
					"com/bumptech/glide/load/model/stream/MediaStoreVideoThumbLoader:Bumptech.Glide.Load.Model.Stream.MediaStoreVideoThumbLoader",
					"com/bumptech/glide/load/model/stream/MediaStoreVideoThumbLoader$Factory:Bumptech.Glide.Load.Model.Stream.MediaStoreVideoThumbLoader/Factory",
					"com/bumptech/glide/load/model/stream/QMediaStoreUriLoader:Bumptech.Glide.Load.Model.Stream.QMediaStoreUriLoader",
					"com/bumptech/glide/load/model/stream/UrlLoader:Bumptech.Glide.Load.Model.Stream.UrlLoader",
					"com/bumptech/glide/load/model/stream/UrlLoader$StreamFactory:Bumptech.Glide.Load.Model.Stream.UrlLoader/StreamFactory"
				};
			}
			return __TypeRegistrations.Lookup(__TypeRegistrations.package_com_bumptech_glide_load_model_stream_mappings, klass);
		}

		// Token: 0x060000CB RID: 203 RVA: 0x000029A0 File Offset: 0x00000BA0
		private static Type lookup_com_bumptech_glide_load_resource_bitmap_package(string klass)
		{
			if (__TypeRegistrations.package_com_bumptech_glide_load_resource_bitmap_mappings == null)
			{
				__TypeRegistrations.package_com_bumptech_glide_load_resource_bitmap_mappings = new string[]
				{
					"com/bumptech/glide/load/resource/bitmap/BitmapDrawableDecoder:Bumptech.Glide.Load.Resource.Bitmap.BitmapDrawableDecoder",
					"com/bumptech/glide/load/resource/bitmap/BitmapDrawableEncoder:Bumptech.Glide.Load.Resource.Bitmap.BitmapDrawableEncoder",
					"com/bumptech/glide/load/resource/bitmap/BitmapDrawableResource:Bumptech.Glide.Load.Resource.Bitmap.BitmapDrawableResource",
					"com/bumptech/glide/load/resource/bitmap/BitmapDrawableTransformation:Bumptech.Glide.Load.Resource.Bitmap.BitmapDrawableTransformation",
					"com/bumptech/glide/load/resource/bitmap/BitmapEncoder:Bumptech.Glide.Load.Resource.Bitmap.BitmapEncoder",
					"com/bumptech/glide/load/resource/bitmap/BitmapImageDecoderResourceDecoder:Bumptech.Glide.Load.Resource.Bitmap.BitmapImageDecoderResourceDecoder",
					"com/bumptech/glide/load/resource/bitmap/BitmapResource:Bumptech.Glide.Load.Resource.Bitmap.BitmapResource",
					"com/bumptech/glide/load/resource/bitmap/BitmapTransformation:Bumptech.Glide.Load.Resource.Bitmap.BitmapTransformation",
					"com/bumptech/glide/load/resource/bitmap/BitmapTransitionOptions:Bumptech.Glide.Load.Resource.Bitmap.BitmapTransitionOptions",
					"com/bumptech/glide/load/resource/bitmap/ByteBufferBitmapDecoder:Bumptech.Glide.Load.Resource.Bitmap.ByteBufferBitmapDecoder",
					"com/bumptech/glide/load/resource/bitmap/ByteBufferBitmapImageDecoderResourceDecoder:Bumptech.Glide.Load.Resource.Bitmap.ByteBufferBitmapImageDecoderResourceDecoder",
					"com/bumptech/glide/load/resource/bitmap/CenterCrop:Bumptech.Glide.Load.Resource.Bitmap.CenterCrop",
					"com/bumptech/glide/load/resource/bitmap/CenterInside:Bumptech.Glide.Load.Resource.Bitmap.CenterInside",
					"com/bumptech/glide/load/resource/bitmap/CircleCrop:Bumptech.Glide.Load.Resource.Bitmap.CircleCrop",
					"com/bumptech/glide/load/resource/bitmap/DefaultImageHeaderParser:Bumptech.Glide.Load.Resource.Bitmap.DefaultImageHeaderParser",
					"com/bumptech/glide/load/resource/bitmap/DownsampleStrategy:Bumptech.Glide.Load.Resource.Bitmap.DownsampleStrategy",
					"com/bumptech/glide/load/resource/bitmap/DownsampleStrategy$SampleSizeRounding:Bumptech.Glide.Load.Resource.Bitmap.DownsampleStrategy/SampleSizeRounding",
					"com/bumptech/glide/load/resource/bitmap/Downsampler:Bumptech.Glide.Load.Resource.Bitmap.Downsampler",
					"com/bumptech/glide/load/resource/bitmap/DrawableTransformation:Bumptech.Glide.Load.Resource.Bitmap.DrawableTransformation",
					"com/bumptech/glide/load/resource/bitmap/ExifInterfaceImageHeaderParser:Bumptech.Glide.Load.Resource.Bitmap.ExifInterfaceImageHeaderParser",
					"com/bumptech/glide/load/resource/bitmap/FitCenter:Bumptech.Glide.Load.Resource.Bitmap.FitCenter",
					"com/bumptech/glide/load/resource/bitmap/GranularRoundedCorners:Bumptech.Glide.Load.Resource.Bitmap.GranularRoundedCorners",
					"com/bumptech/glide/load/resource/bitmap/HardwareConfigState:Bumptech.Glide.Load.Resource.Bitmap.HardwareConfigState",
					"com/bumptech/glide/load/resource/bitmap/InputStreamBitmapImageDecoderResourceDecoder:Bumptech.Glide.Load.Resource.Bitmap.InputStreamBitmapImageDecoderResourceDecoder",
					"com/bumptech/glide/load/resource/bitmap/LazyBitmapDrawableResource:Bumptech.Glide.Load.Resource.Bitmap.LazyBitmapDrawableResource",
					"com/bumptech/glide/load/resource/bitmap/ParcelFileDescriptorBitmapDecoder:Bumptech.Glide.Load.Resource.Bitmap.ParcelFileDescriptorBitmapDecoder",
					"com/bumptech/glide/load/resource/bitmap/RecyclableBufferedInputStream:Bumptech.Glide.Load.Resource.Bitmap.RecyclableBufferedInputStream",
					"com/bumptech/glide/load/resource/bitmap/ResourceBitmapDecoder:Bumptech.Glide.Load.Resource.Bitmap.ResourceBitmapDecoder",
					"com/bumptech/glide/load/resource/bitmap/Rotate:Bumptech.Glide.Load.Resource.Bitmap.Rotate",
					"com/bumptech/glide/load/resource/bitmap/RoundedCorners:Bumptech.Glide.Load.Resource.Bitmap.RoundedCorners",
					"com/bumptech/glide/load/resource/bitmap/StreamBitmapDecoder:Bumptech.Glide.Load.Resource.Bitmap.StreamBitmapDecoder",
					"com/bumptech/glide/load/resource/bitmap/TransformationUtils:Bumptech.Glide.Load.Resource.Bitmap.TransformationUtils",
					"com/bumptech/glide/load/resource/bitmap/UnitBitmapDecoder:Bumptech.Glide.Load.Resource.Bitmap.UnitBitmapDecoder",
					"com/bumptech/glide/load/resource/bitmap/VideoBitmapDecoder:Bumptech.Glide.Load.Resource.Bitmap.VideoBitmapDecoder",
					"com/bumptech/glide/load/resource/bitmap/VideoDecoder:Bumptech.Glide.Load.Resource.Bitmap.VideoDecoder"
				};
			}
			return __TypeRegistrations.Lookup(__TypeRegistrations.package_com_bumptech_glide_load_resource_bitmap_mappings, klass);
		}

		// Token: 0x060000CC RID: 204 RVA: 0x00002B00 File Offset: 0x00000D00
		private static Type lookup_com_bumptech_glide_load_resource_bytes_package(string klass)
		{
			if (__TypeRegistrations.package_com_bumptech_glide_load_resource_bytes_mappings == null)
			{
				__TypeRegistrations.package_com_bumptech_glide_load_resource_bytes_mappings = new string[]
				{
					"com/bumptech/glide/load/resource/bytes/ByteBufferRewinder:Bumptech.Glide.Load.Resource.Bytes.ByteBufferRewinder",
					"com/bumptech/glide/load/resource/bytes/ByteBufferRewinder$Factory:Bumptech.Glide.Load.Resource.Bytes.ByteBufferRewinder/Factory",
					"com/bumptech/glide/load/resource/bytes/BytesResource:Bumptech.Glide.Load.Resource.Bytes.BytesResource"
				};
			}
			return __TypeRegistrations.Lookup(__TypeRegistrations.package_com_bumptech_glide_load_resource_bytes_mappings, klass);
		}

		// Token: 0x060000CD RID: 205 RVA: 0x00002B37 File Offset: 0x00000D37
		private static Type lookup_com_bumptech_glide_load_resource_package(string klass)
		{
			if (__TypeRegistrations.package_com_bumptech_glide_load_resource_mappings == null)
			{
				__TypeRegistrations.package_com_bumptech_glide_load_resource_mappings = new string[]
				{
					"com/bumptech/glide/load/resource/DefaultOnHeaderDecodedListener:Bumptech.Glide.Load.Resource.DefaultOnHeaderDecodedListener",
					"com/bumptech/glide/load/resource/SimpleResource:Bumptech.Glide.Load.Resource.SimpleResource",
					"com/bumptech/glide/load/resource/UnitTransformation:Bumptech.Glide.Load.Resource.UnitTransformation"
				};
			}
			return __TypeRegistrations.Lookup(__TypeRegistrations.package_com_bumptech_glide_load_resource_mappings, klass);
		}

		// Token: 0x060000CE RID: 206 RVA: 0x00002B70 File Offset: 0x00000D70
		private static Type lookup_com_bumptech_glide_load_resource_drawable_package(string klass)
		{
			if (__TypeRegistrations.package_com_bumptech_glide_load_resource_drawable_mappings == null)
			{
				__TypeRegistrations.package_com_bumptech_glide_load_resource_drawable_mappings = new string[]
				{
					"com/bumptech/glide/load/resource/drawable/AnimatedImageDecoder:Bumptech.Glide.Load.Resource.Drawable.AnimatedImageDecoder",
					"com/bumptech/glide/load/resource/drawable/AnimatedWebpDecoder:Bumptech.Glide.Load.Resource.Drawable.AnimatedWebpDecoder",
					"com/bumptech/glide/load/resource/drawable/DrawableDecoderCompat:Bumptech.Glide.Load.Resource.Drawable.DrawableDecoderCompat",
					"com/bumptech/glide/load/resource/drawable/DrawableResource:Bumptech.Glide.Load.Resource.Drawable.DrawableResource",
					"com/bumptech/glide/load/resource/drawable/DrawableTransitionOptions:Bumptech.Glide.Load.Resource.Drawable.DrawableTransitionOptions",
					"com/bumptech/glide/load/resource/drawable/ResourceDrawableDecoder:Bumptech.Glide.Load.Resource.Drawable.ResourceDrawableDecoder",
					"com/bumptech/glide/load/resource/drawable/UnitDrawableDecoder:Bumptech.Glide.Load.Resource.Drawable.UnitDrawableDecoder"
				};
			}
			return __TypeRegistrations.Lookup(__TypeRegistrations.package_com_bumptech_glide_load_resource_drawable_mappings, klass);
		}

		// Token: 0x060000CF RID: 207 RVA: 0x00002BD2 File Offset: 0x00000DD2
		private static Type lookup_com_bumptech_glide_load_resource_file_package(string klass)
		{
			if (__TypeRegistrations.package_com_bumptech_glide_load_resource_file_mappings == null)
			{
				__TypeRegistrations.package_com_bumptech_glide_load_resource_file_mappings = new string[]
				{
					"com/bumptech/glide/load/resource/file/FileDecoder:Bumptech.Glide.Load.Resource.File.FileDecoder",
					"com/bumptech/glide/load/resource/file/FileResource:Bumptech.Glide.Load.Resource.File.FileResource"
				};
			}
			return __TypeRegistrations.Lookup(__TypeRegistrations.package_com_bumptech_glide_load_resource_file_mappings, klass);
		}

		// Token: 0x060000D0 RID: 208 RVA: 0x00002C04 File Offset: 0x00000E04
		private static Type lookup_com_bumptech_glide_load_resource_gif_package(string klass)
		{
			if (__TypeRegistrations.package_com_bumptech_glide_load_resource_gif_mappings == null)
			{
				__TypeRegistrations.package_com_bumptech_glide_load_resource_gif_mappings = new string[]
				{
					"com/bumptech/glide/load/resource/gif/ByteBufferGifDecoder:Bumptech.Glide.Load.Resource.Gif.ByteBufferGifDecoder",
					"com/bumptech/glide/load/resource/gif/GifBitmapProvider:Bumptech.Glide.Load.Resource.Gif.GifBitmapProvider",
					"com/bumptech/glide/load/resource/gif/GifDrawable:Bumptech.Glide.Load.Resource.Gif.GifDrawable",
					"com/bumptech/glide/load/resource/gif/GifDrawableEncoder:Bumptech.Glide.Load.Resource.Gif.GifDrawableEncoder",
					"com/bumptech/glide/load/resource/gif/GifDrawableResource:Bumptech.Glide.Load.Resource.Gif.GifDrawableResource",
					"com/bumptech/glide/load/resource/gif/GifDrawableTransformation:Bumptech.Glide.Load.Resource.Gif.GifDrawableTransformation",
					"com/bumptech/glide/load/resource/gif/GifFrameResourceDecoder:Bumptech.Glide.Load.Resource.Gif.GifFrameResourceDecoder",
					"com/bumptech/glide/load/resource/gif/GifOptions:Bumptech.Glide.Load.Resource.Gif.GifOptions",
					"com/bumptech/glide/load/resource/gif/StreamGifDecoder:Bumptech.Glide.Load.Resource.Gif.StreamGifDecoder"
				};
			}
			return __TypeRegistrations.Lookup(__TypeRegistrations.package_com_bumptech_glide_load_resource_gif_mappings, klass);
		}

		// Token: 0x060000D1 RID: 209 RVA: 0x00002C78 File Offset: 0x00000E78
		private static Type lookup_com_bumptech_glide_load_resource_transcode_package(string klass)
		{
			if (__TypeRegistrations.package_com_bumptech_glide_load_resource_transcode_mappings == null)
			{
				__TypeRegistrations.package_com_bumptech_glide_load_resource_transcode_mappings = new string[]
				{
					"com/bumptech/glide/load/resource/transcode/BitmapBytesTranscoder:Bumptech.Glide.Load.Resource.Transcode.BitmapBytesTranscoder",
					"com/bumptech/glide/load/resource/transcode/BitmapDrawableTranscoder:Bumptech.Glide.Load.Resource.Transcode.BitmapDrawableTranscoder",
					"com/bumptech/glide/load/resource/transcode/DrawableBytesTranscoder:Bumptech.Glide.Load.Resource.Transcode.DrawableBytesTranscoder",
					"com/bumptech/glide/load/resource/transcode/GifDrawableBytesTranscoder:Bumptech.Glide.Load.Resource.Transcode.GifDrawableBytesTranscoder",
					"com/bumptech/glide/load/resource/transcode/TranscoderRegistry:Bumptech.Glide.Load.Resource.Transcode.TranscoderRegistry",
					"com/bumptech/glide/load/resource/transcode/UnitTranscoder:Bumptech.Glide.Load.Resource.Transcode.UnitTranscoder"
				};
			}
			return __TypeRegistrations.Lookup(__TypeRegistrations.package_com_bumptech_glide_load_resource_transcode_mappings, klass);
		}

		// Token: 0x060000D2 RID: 210 RVA: 0x00002CD4 File Offset: 0x00000ED4
		private static Type lookup_com_bumptech_glide_manager_package(string klass)
		{
			if (__TypeRegistrations.package_com_bumptech_glide_manager_mappings == null)
			{
				__TypeRegistrations.package_com_bumptech_glide_manager_mappings = new string[]
				{
					"com/bumptech/glide/manager/DefaultConnectivityMonitorFactory:Bumptech.Glide.Manager.DefaultConnectivityMonitorFactory",
					"com/bumptech/glide/manager/RequestManagerFragment:Bumptech.Glide.Manager.RequestManagerFragment",
					"com/bumptech/glide/manager/RequestManagerRetriever:Bumptech.Glide.Manager.RequestManagerRetriever",
					"com/bumptech/glide/manager/RequestTracker:Bumptech.Glide.Manager.RequestTracker",
					"com/bumptech/glide/manager/SupportRequestManagerFragment:Bumptech.Glide.Manager.SupportRequestManagerFragment",
					"com/bumptech/glide/manager/TargetTracker:Bumptech.Glide.Manager.TargetTracker"
				};
			}
			return __TypeRegistrations.Lookup(__TypeRegistrations.package_com_bumptech_glide_manager_mappings, klass);
		}

		// Token: 0x060000D3 RID: 211 RVA: 0x00002D2E File Offset: 0x00000F2E
		private static Type lookup_com_bumptech_glide_module_package(string klass)
		{
			if (__TypeRegistrations.package_com_bumptech_glide_module_mappings == null)
			{
				__TypeRegistrations.package_com_bumptech_glide_module_mappings = new string[]
				{
					"com/bumptech/glide/module/AppGlideModule:Bumptech.Glide.Module.AppGlideModule",
					"com/bumptech/glide/module/LibraryGlideModule:Bumptech.Glide.Module.LibraryGlideModule",
					"com/bumptech/glide/module/ManifestParser:Bumptech.Glide.Module.ManifestParser"
				};
			}
			return __TypeRegistrations.Lookup(__TypeRegistrations.package_com_bumptech_glide_module_mappings, klass);
		}

		// Token: 0x060000D4 RID: 212 RVA: 0x00002D68 File Offset: 0x00000F68
		private static Type lookup_com_bumptech_glide_provider_package(string klass)
		{
			if (__TypeRegistrations.package_com_bumptech_glide_provider_mappings == null)
			{
				__TypeRegistrations.package_com_bumptech_glide_provider_mappings = new string[]
				{
					"com/bumptech/glide/provider/EncoderRegistry:Bumptech.Glide.Provider.EncoderRegistry",
					"com/bumptech/glide/provider/ImageHeaderParserRegistry:Bumptech.Glide.Provider.ImageHeaderParserRegistry",
					"com/bumptech/glide/provider/LoadPathCache:Bumptech.Glide.Provider.LoadPathCache",
					"com/bumptech/glide/provider/ModelToResourceClassCache:Bumptech.Glide.Provider.ModelToResourceClassCache",
					"com/bumptech/glide/provider/ResourceDecoderRegistry:Bumptech.Glide.Provider.ResourceDecoderRegistry",
					"com/bumptech/glide/provider/ResourceEncoderRegistry:Bumptech.Glide.Provider.ResourceEncoderRegistry"
				};
			}
			return __TypeRegistrations.Lookup(__TypeRegistrations.package_com_bumptech_glide_provider_mappings, klass);
		}

		// Token: 0x060000D5 RID: 213 RVA: 0x00002DC4 File Offset: 0x00000FC4
		private static Type lookup_com_bumptech_glide_request_package(string klass)
		{
			if (__TypeRegistrations.package_com_bumptech_glide_request_mappings == null)
			{
				__TypeRegistrations.package_com_bumptech_glide_request_mappings = new string[]
				{
					"com/bumptech/glide/request/BaseRequestOptions:Bumptech.Glide.Request.BaseRequestOptions",
					"com/bumptech/glide/request/ErrorRequestCoordinator:Bumptech.Glide.Request.ErrorRequestCoordinator",
					"com/bumptech/glide/request/RequestCoordinator$RequestState:Bumptech.Glide.Request.RequestCoordinatorRequestState",
					"com/bumptech/glide/request/RequestFutureTarget:Bumptech.Glide.Request.RequestFutureTarget",
					"com/bumptech/glide/request/RequestOptions:Bumptech.Glide.Request.RequestOptions",
					"com/bumptech/glide/request/SingleRequest:Bumptech.Glide.Request.SingleRequest",
					"com/bumptech/glide/request/ThumbnailRequestCoordinator:Bumptech.Glide.Request.ThumbnailRequestCoordinator"
				};
			}
			return __TypeRegistrations.Lookup(__TypeRegistrations.package_com_bumptech_glide_request_mappings, klass);
		}

		// Token: 0x060000D6 RID: 214 RVA: 0x00002E28 File Offset: 0x00001028
		private static Type lookup_com_bumptech_glide_request_target_package(string klass)
		{
			if (__TypeRegistrations.package_com_bumptech_glide_request_target_mappings == null)
			{
				__TypeRegistrations.package_com_bumptech_glide_request_target_mappings = new string[]
				{
					"com/bumptech/glide/request/target/AppWidgetTarget:Bumptech.Glide.Request.Target.AppWidgetTarget",
					"com/bumptech/glide/request/target/BaseTarget:Bumptech.Glide.Request.Target.BaseTarget",
					"com/bumptech/glide/request/target/BitmapImageViewTarget:Bumptech.Glide.Request.Target.BitmapImageViewTarget",
					"com/bumptech/glide/request/target/BitmapThumbnailImageViewTarget:Bumptech.Glide.Request.Target.BitmapThumbnailImageViewTarget",
					"com/bumptech/glide/request/target/CustomTarget:Bumptech.Glide.Request.Target.CustomTarget",
					"com/bumptech/glide/request/target/CustomViewTarget:Bumptech.Glide.Request.Target.CustomViewTarget",
					"com/bumptech/glide/request/target/DrawableImageViewTarget:Bumptech.Glide.Request.Target.DrawableImageViewTarget",
					"com/bumptech/glide/request/target/DrawableThumbnailImageViewTarget:Bumptech.Glide.Request.Target.DrawableThumbnailImageViewTarget",
					"com/bumptech/glide/request/target/FixedSizeDrawable:Bumptech.Glide.Request.Target.FixedSizeDrawable",
					"com/bumptech/glide/request/target/ImageViewTarget:Bumptech.Glide.Request.Target.ImageViewTarget",
					"com/bumptech/glide/request/target/ImageViewTargetFactory:Bumptech.Glide.Request.Target.ImageViewTargetFactory",
					"com/bumptech/glide/request/target/NotificationTarget:Bumptech.Glide.Request.Target.NotificationTarget",
					"com/bumptech/glide/request/target/PreloadTarget:Bumptech.Glide.Request.Target.PreloadTarget",
					"com/bumptech/glide/request/target/SimpleTarget:Bumptech.Glide.Request.Target.SimpleTarget",
					"com/bumptech/glide/request/target/ThumbnailImageViewTarget:Bumptech.Glide.Request.Target.ThumbnailImageViewTarget",
					"com/bumptech/glide/request/target/ViewTarget:Bumptech.Glide.Request.Target.ViewTarget"
				};
			}
			return __TypeRegistrations.Lookup(__TypeRegistrations.package_com_bumptech_glide_request_target_mappings, klass);
		}

		// Token: 0x060000D7 RID: 215 RVA: 0x00002EE0 File Offset: 0x000010E0
		private static Type lookup_com_bumptech_glide_request_transition_package(string klass)
		{
			if (__TypeRegistrations.package_com_bumptech_glide_request_transition_mappings == null)
			{
				__TypeRegistrations.package_com_bumptech_glide_request_transition_mappings = new string[]
				{
					"com/bumptech/glide/request/transition/BitmapContainerTransitionFactory:Bumptech.Glide.Request.Transition.BitmapContainerTransitionFactory",
					"com/bumptech/glide/request/transition/BitmapTransitionFactory:Bumptech.Glide.Request.Transition.BitmapTransitionFactory",
					"com/bumptech/glide/request/transition/DrawableCrossFadeFactory:Bumptech.Glide.Request.Transition.DrawableCrossFadeFactory",
					"com/bumptech/glide/request/transition/DrawableCrossFadeFactory$Builder:Bumptech.Glide.Request.Transition.DrawableCrossFadeFactory/Builder",
					"com/bumptech/glide/request/transition/DrawableCrossFadeTransition:Bumptech.Glide.Request.Transition.DrawableCrossFadeTransition",
					"com/bumptech/glide/request/transition/NoTransition:Bumptech.Glide.Request.Transition.NoTransition",
					"com/bumptech/glide/request/transition/NoTransition$NoAnimationFactory:Bumptech.Glide.Request.Transition.NoTransition/NoAnimationFactory",
					"com/bumptech/glide/request/transition/ViewAnimationFactory:Bumptech.Glide.Request.Transition.ViewAnimationFactory",
					"com/bumptech/glide/request/transition/ViewPropertyAnimationFactory:Bumptech.Glide.Request.Transition.ViewPropertyAnimationFactory",
					"com/bumptech/glide/request/transition/ViewPropertyTransition:Bumptech.Glide.Request.Transition.ViewPropertyTransition",
					"com/bumptech/glide/request/transition/ViewTransition:Bumptech.Glide.Request.Transition.ViewTransition"
				};
			}
			return __TypeRegistrations.Lookup(__TypeRegistrations.package_com_bumptech_glide_request_transition_mappings, klass);
		}

		// Token: 0x060000D8 RID: 216 RVA: 0x00002F68 File Offset: 0x00001168
		private static Type lookup_com_bumptech_glide_signature_package(string klass)
		{
			if (__TypeRegistrations.package_com_bumptech_glide_signature_mappings == null)
			{
				__TypeRegistrations.package_com_bumptech_glide_signature_mappings = new string[]
				{
					"com/bumptech/glide/signature/AndroidResourceSignature:Bumptech.Glide.Signature.AndroidResourceSignature",
					"com/bumptech/glide/signature/ApplicationVersionSignature:Bumptech.Glide.Signature.ApplicationVersionSignature",
					"com/bumptech/glide/signature/EmptySignature:Bumptech.Glide.Signature.EmptySignature",
					"com/bumptech/glide/signature/MediaStoreSignature:Bumptech.Glide.Signature.MediaStoreSignature",
					"com/bumptech/glide/signature/ObjectKey:Bumptech.Glide.Signature.ObjectKey"
				};
			}
			return __TypeRegistrations.Lookup(__TypeRegistrations.package_com_bumptech_glide_signature_mappings, klass);
		}

		// Token: 0x060000D9 RID: 217 RVA: 0x00002FBC File Offset: 0x000011BC
		private static Type lookup_com_bumptech_glide_util_package(string klass)
		{
			if (__TypeRegistrations.package_com_bumptech_glide_util_mappings == null)
			{
				__TypeRegistrations.package_com_bumptech_glide_util_mappings = new string[]
				{
					"com/bumptech/glide/util/ByteBufferUtil:Bumptech.Glide.Util.ByteBufferUtil",
					"com/bumptech/glide/util/CachedHashCodeArrayMap:Bumptech.Glide.Util.CachedHashCodeArrayMap",
					"com/bumptech/glide/util/ContentLengthInputStream:Bumptech.Glide.Util.ContentLengthInputStream",
					"com/bumptech/glide/util/ExceptionCatchingInputStream:Bumptech.Glide.Util.ExceptionCatchingInputStream",
					"com/bumptech/glide/util/ExceptionPassthroughInputStream:Bumptech.Glide.Util.ExceptionPassthroughInputStream",
					"com/bumptech/glide/util/Executors:Bumptech.Glide.Util.Executors",
					"com/bumptech/glide/util/FixedPreloadSizeProvider:Bumptech.Glide.Util.FixedPreloadSizeProvider",
					"com/bumptech/glide/util/GlideSuppliers:Bumptech.Glide.Util.GlideSuppliers",
					"com/bumptech/glide/util/LogTime:Bumptech.Glide.Util.LogTime",
					"com/bumptech/glide/util/LruCache:Bumptech.Glide.Util.LruCache",
					"com/bumptech/glide/util/MarkEnforcingInputStream:Bumptech.Glide.Util.MarkEnforcingInputStream",
					"com/bumptech/glide/util/MultiClassKey:Bumptech.Glide.Util.MultiClassKey",
					"com/bumptech/glide/util/Preconditions:Bumptech.Glide.Util.Preconditions",
					"com/bumptech/glide/util/Util:Bumptech.Glide.Util.Util",
					"com/bumptech/glide/util/ViewPreloadSizeProvider:Bumptech.Glide.Util.ViewPreloadSizeProvider"
				};
			}
			return __TypeRegistrations.Lookup(__TypeRegistrations.package_com_bumptech_glide_util_mappings, klass);
		}

		// Token: 0x060000DA RID: 218 RVA: 0x00003068 File Offset: 0x00001268
		private static Type lookup_com_bumptech_glide_util_pool_package(string klass)
		{
			if (__TypeRegistrations.package_com_bumptech_glide_util_pool_mappings == null)
			{
				__TypeRegistrations.package_com_bumptech_glide_util_pool_mappings = new string[]
				{
					"com/bumptech/glide/util/pool/FactoryPools:Bumptech.Glide.Util.Pool.FactoryPools",
					"com/bumptech/glide/util/pool/GlideTrace:Bumptech.Glide.Util.Pool.GlideTrace",
					"com/bumptech/glide/util/pool/StateVerifier:Bumptech.Glide.Util.Pool.StateVerifier"
				};
			}
			return __TypeRegistrations.Lookup(__TypeRegistrations.package_com_bumptech_glide_util_pool_mappings, klass);
		}

		// Token: 0x04000003 RID: 3
		private static string[] package_com_bumptech_glide_mappings;

		// Token: 0x04000004 RID: 4
		private static string[] package_com_bumptech_glide_load_data_mappings;

		// Token: 0x04000005 RID: 5
		private static string[] package_com_bumptech_glide_load_data_mediastore_mappings;

		// Token: 0x04000006 RID: 6
		private static string[] package_com_bumptech_glide_load_mappings;

		// Token: 0x04000007 RID: 7
		private static string[] package_com_bumptech_glide_load_engine_bitmap_recycle_mappings;

		// Token: 0x04000008 RID: 8
		private static string[] package_com_bumptech_glide_load_engine_cache_mappings;

		// Token: 0x04000009 RID: 9
		private static string[] package_com_bumptech_glide_load_engine_mappings;

		// Token: 0x0400000A RID: 10
		private static string[] package_com_bumptech_glide_load_engine_executor_mappings;

		// Token: 0x0400000B RID: 11
		private static string[] package_com_bumptech_glide_load_engine_prefill_mappings;

		// Token: 0x0400000C RID: 12
		private static string[] package_com_bumptech_glide_load_model_mappings;

		// Token: 0x0400000D RID: 13
		private static string[] package_com_bumptech_glide_load_model_stream_mappings;

		// Token: 0x0400000E RID: 14
		private static string[] package_com_bumptech_glide_load_resource_bitmap_mappings;

		// Token: 0x0400000F RID: 15
		private static string[] package_com_bumptech_glide_load_resource_bytes_mappings;

		// Token: 0x04000010 RID: 16
		private static string[] package_com_bumptech_glide_load_resource_mappings;

		// Token: 0x04000011 RID: 17
		private static string[] package_com_bumptech_glide_load_resource_drawable_mappings;

		// Token: 0x04000012 RID: 18
		private static string[] package_com_bumptech_glide_load_resource_file_mappings;

		// Token: 0x04000013 RID: 19
		private static string[] package_com_bumptech_glide_load_resource_gif_mappings;

		// Token: 0x04000014 RID: 20
		private static string[] package_com_bumptech_glide_load_resource_transcode_mappings;

		// Token: 0x04000015 RID: 21
		private static string[] package_com_bumptech_glide_manager_mappings;

		// Token: 0x04000016 RID: 22
		private static string[] package_com_bumptech_glide_module_mappings;

		// Token: 0x04000017 RID: 23
		private static string[] package_com_bumptech_glide_provider_mappings;

		// Token: 0x04000018 RID: 24
		private static string[] package_com_bumptech_glide_request_mappings;

		// Token: 0x04000019 RID: 25
		private static string[] package_com_bumptech_glide_request_target_mappings;

		// Token: 0x0400001A RID: 26
		private static string[] package_com_bumptech_glide_request_transition_mappings;

		// Token: 0x0400001B RID: 27
		private static string[] package_com_bumptech_glide_signature_mappings;

		// Token: 0x0400001C RID: 28
		private static string[] package_com_bumptech_glide_util_mappings;

		// Token: 0x0400001D RID: 29
		private static string[] package_com_bumptech_glide_util_pool_mappings;
	}
}
