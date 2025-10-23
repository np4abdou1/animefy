using System;

namespace Mono
{
	// Token: 0x02000014 RID: 20
	internal struct RuntimeRemoteClassHandle
	{
		// Token: 0x17000006 RID: 6
		// (get) Token: 0x0600003A RID: 58 RVA: 0x00002666 File Offset: 0x00000866
		internal unsafe RuntimeClassHandle ProxyClass
		{
			get
			{
				return new RuntimeClassHandle(this.value->proxy_class);
			}
		}

		// Token: 0x0400008A RID: 138
		private unsafe RuntimeStructs.RemoteClass* value;
	}
}
