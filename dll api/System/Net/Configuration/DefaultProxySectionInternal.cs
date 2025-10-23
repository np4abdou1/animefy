using System;
using System.Threading;

namespace System.Net.Configuration
{
	// Token: 0x020001F2 RID: 498
	internal sealed class DefaultProxySectionInternal
	{
		// Token: 0x06000D61 RID: 3425 RVA: 0x0004682D File Offset: 0x00044A2D
		private static IWebProxy GetDefaultProxy_UsingOldMonoCode()
		{
			return DefaultProxySectionInternal.GetSystemWebProxy();
		}

		// Token: 0x06000D62 RID: 3426 RVA: 0x00046834 File Offset: 0x00044A34
		private static IWebProxy GetSystemWebProxy()
		{
			return System.Net.WebProxy.CreateDefaultProxy();
		}

		// Token: 0x170002B9 RID: 697
		// (get) Token: 0x06000D63 RID: 3427 RVA: 0x0004683C File Offset: 0x00044A3C
		internal static object ClassSyncObject
		{
			get
			{
				if (DefaultProxySectionInternal.classSyncObject == null)
				{
					object value = new object();
					Interlocked.CompareExchange(ref DefaultProxySectionInternal.classSyncObject, value, null);
				}
				return DefaultProxySectionInternal.classSyncObject;
			}
		}

		// Token: 0x06000D64 RID: 3428 RVA: 0x00046868 File Offset: 0x00044A68
		internal static DefaultProxySectionInternal GetSection()
		{
			object obj = DefaultProxySectionInternal.ClassSyncObject;
			DefaultProxySectionInternal result;
			lock (obj)
			{
				result = new DefaultProxySectionInternal
				{
					webProxy = DefaultProxySectionInternal.GetDefaultProxy_UsingOldMonoCode()
				};
			}
			return result;
		}

		// Token: 0x170002BA RID: 698
		// (get) Token: 0x06000D65 RID: 3429 RVA: 0x000468B4 File Offset: 0x00044AB4
		internal IWebProxy WebProxy
		{
			get
			{
				return this.webProxy;
			}
		}

		// Token: 0x04000A29 RID: 2601
		private IWebProxy webProxy;

		// Token: 0x04000A2A RID: 2602
		private static object classSyncObject;
	}
}
