using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Mono.Btls;

namespace Mono.Net.Security
{
	// Token: 0x02000021 RID: 33
	internal static class MonoTlsProviderFactory
	{
		// Token: 0x060000D2 RID: 210 RVA: 0x00004E44 File Offset: 0x00003044
		internal static MobileTlsProvider GetProviderInternal()
		{
			object obj = MonoTlsProviderFactory.locker;
			MobileTlsProvider result;
			lock (obj)
			{
				MonoTlsProviderFactory.InitializeInternal();
				result = MonoTlsProviderFactory.defaultProvider;
			}
			return result;
		}

		// Token: 0x060000D3 RID: 211 RVA: 0x00004E8C File Offset: 0x0000308C
		internal static void InitializeInternal()
		{
			object obj = MonoTlsProviderFactory.locker;
			lock (obj)
			{
				if (!MonoTlsProviderFactory.initialized)
				{
					SystemDependencyProvider.Initialize();
					MonoTlsProviderFactory.InitializeProviderRegistration();
					MobileTlsProvider mobileTlsProvider;
					try
					{
						mobileTlsProvider = MonoTlsProviderFactory.CreateDefaultProviderImpl();
					}
					catch (Exception innerException)
					{
						throw new NotSupportedException("TLS Support not available.", innerException);
					}
					if (mobileTlsProvider == null)
					{
						throw new NotSupportedException("TLS Support not available.");
					}
					if (!MonoTlsProviderFactory.providerCache.ContainsKey(mobileTlsProvider.ID))
					{
						MonoTlsProviderFactory.providerCache.Add(mobileTlsProvider.ID, mobileTlsProvider);
					}
					MonoTlsProviderFactory.defaultProvider = mobileTlsProvider;
					MonoTlsProviderFactory.initialized = true;
				}
			}
		}

		// Token: 0x060000D4 RID: 212 RVA: 0x00004F38 File Offset: 0x00003138
		private static void InitializeProviderRegistration()
		{
			object obj = MonoTlsProviderFactory.locker;
			lock (obj)
			{
				if (MonoTlsProviderFactory.providerRegistration == null)
				{
					MonoTlsProviderFactory.providerRegistration = new Dictionary<string, Tuple<Guid, string>>();
					MonoTlsProviderFactory.providerCache = new Dictionary<Guid, MobileTlsProvider>();
					MonoTlsProviderFactory.PopulateProviders();
				}
			}
		}

		// Token: 0x060000D5 RID: 213 RVA: 0x00004F94 File Offset: 0x00003194
		private static void PopulateProviders()
		{
			Tuple<Guid, string> value = new Tuple<Guid, string>(MonoTlsProviderFactory.BtlsId, typeof(MonoBtlsProvider).FullName);
			MonoTlsProviderFactory.providerRegistration.Add("default", value);
			MonoTlsProviderFactory.providerRegistration.Add("legacy", value);
			MonoTlsProviderFactory.providerRegistration.Add("btls", value);
		}

		// Token: 0x060000D6 RID: 214
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern bool IsBtlsSupported();

		// Token: 0x060000D7 RID: 215 RVA: 0x00004FEC File Offset: 0x000031EC
		private static MobileTlsProvider CreateDefaultProviderImpl()
		{
			string environmentVariable = Environment.GetEnvironmentVariable("XA_TLS_PROVIDER");
			if (environmentVariable != null && !(environmentVariable == "default") && !(environmentVariable == "legacy") && !(environmentVariable == "btls"))
			{
				throw new NotSupportedException("Invalid TLS Provider: `" + environmentVariable + "'.");
			}
			if (!MonoTlsProviderFactory.IsBtlsSupported())
			{
				throw new NotSupportedException("BTLS in not supported!");
			}
			return new MonoBtlsProvider();
		}

		// Token: 0x060000D8 RID: 216 RVA: 0x0000505B File Offset: 0x0000325B
		internal static MobileTlsProvider GetProvider()
		{
			return MonoTlsProviderFactory.GetProviderInternal();
		}

		// Token: 0x04000083 RID: 131
		private static object locker = new object();

		// Token: 0x04000084 RID: 132
		private static bool initialized;

		// Token: 0x04000085 RID: 133
		private static MobileTlsProvider defaultProvider;

		// Token: 0x04000086 RID: 134
		private static Dictionary<string, Tuple<Guid, string>> providerRegistration;

		// Token: 0x04000087 RID: 135
		private static Dictionary<Guid, MobileTlsProvider> providerCache;

		// Token: 0x04000088 RID: 136
		internal static readonly Guid AppleTlsId = new Guid("981af8af-a3a3-419a-9f01-a518e3a17c1c");

		// Token: 0x04000089 RID: 137
		internal static readonly Guid BtlsId = new Guid("432d18c9-9348-4b90-bfbf-9f2a10e1f15b");
	}
}
