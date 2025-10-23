using System;
using System.Collections.Generic;
using System.Net;
using Mono;
using Mono.Btls;

namespace System
{
	// Token: 0x0200008E RID: 142
	internal static class AndroidPlatform
	{
		// Token: 0x060003A6 RID: 934 RVA: 0x00015A34 File Offset: 0x00013C34
		static AndroidPlatform()
		{
			Type type = Type.GetType("Android.Runtime.AndroidEnvironment, Mono.Android", true);
			AndroidPlatform.trustEvaluateSsl = (Converter<List<byte[]>, bool>)Delegate.CreateDelegate(typeof(Converter<List<byte[]>, bool>), type, "TrustEvaluateSsl", false, true);
			AndroidPlatform.certStoreLookup = (Func<long, bool, byte[]>)Delegate.CreateDelegate(typeof(Func<long, bool, byte[]>), type, "CertStoreLookup", false, true);
			SystemDependencyProvider.Initialize();
			AndroidPlatform.getDefaultProxy = (Func<IWebProxy>)Delegate.CreateDelegate(typeof(Func<IWebProxy>), type, "GetDefaultProxy", false, true);
			AndroidPlatform.getInterfaceAddresses = (AndroidPlatform.GetInterfaceAddressesDelegate)Delegate.CreateDelegate(typeof(AndroidPlatform.GetInterfaceAddressesDelegate), type, "GetInterfaceAddresses", false, false);
			AndroidPlatform.freeInterfaceAddresses = (AndroidPlatform.FreeInterfaceAddressesDelegate)Delegate.CreateDelegate(typeof(AndroidPlatform.FreeInterfaceAddressesDelegate), type, "FreeInterfaceAddresses", false, false);
		}

		// Token: 0x060003A7 RID: 935 RVA: 0x00015AF8 File Offset: 0x00013CF8
		internal static MonoBtlsX509 CertStoreLookup(MonoBtlsX509Name name)
		{
			long hash = name.GetHash();
			long hashOld = name.GetHashOld();
			byte[] array = AndroidPlatform.certStoreLookup(hash, false);
			if (array == null)
			{
				array = AndroidPlatform.certStoreLookup(hashOld, false);
			}
			if (array == null)
			{
				array = AndroidPlatform.certStoreLookup(hash, true);
			}
			if (array == null)
			{
				array = AndroidPlatform.certStoreLookup(hashOld, true);
			}
			if (array == null)
			{
				return null;
			}
			return MonoBtlsX509.LoadFromData(array, MonoBtlsX509Format.DER);
		}

		// Token: 0x060003A8 RID: 936 RVA: 0x00015B5C File Offset: 0x00013D5C
		internal static IWebProxy GetDefaultProxy()
		{
			return AndroidPlatform.getDefaultProxy();
		}

		// Token: 0x0400027F RID: 639
		private static readonly Converter<List<byte[]>, bool> trustEvaluateSsl;

		// Token: 0x04000280 RID: 640
		private static readonly Func<long, bool, byte[]> certStoreLookup;

		// Token: 0x04000281 RID: 641
		private static readonly Func<IWebProxy> getDefaultProxy;

		// Token: 0x04000282 RID: 642
		private static readonly AndroidPlatform.GetInterfaceAddressesDelegate getInterfaceAddresses;

		// Token: 0x04000283 RID: 643
		private static readonly AndroidPlatform.FreeInterfaceAddressesDelegate freeInterfaceAddresses;

		// Token: 0x0200008F RID: 143
		// (Invoke) Token: 0x060003AA RID: 938
		private delegate int GetInterfaceAddressesDelegate(out IntPtr ifap);

		// Token: 0x02000090 RID: 144
		// (Invoke) Token: 0x060003AE RID: 942
		private delegate void FreeInterfaceAddressesDelegate(IntPtr ifap);
	}
}
