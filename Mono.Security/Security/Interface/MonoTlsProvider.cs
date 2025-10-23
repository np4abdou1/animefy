using System;

namespace Mono.Security.Interface
{
	// Token: 0x02000042 RID: 66
	public abstract class MonoTlsProvider
	{
		// Token: 0x06000154 RID: 340 RVA: 0x0000531D File Offset: 0x0000351D
		internal MonoTlsProvider()
		{
		}

		// Token: 0x17000063 RID: 99
		// (get) Token: 0x06000155 RID: 341
		public abstract Guid ID { get; }
	}
}
