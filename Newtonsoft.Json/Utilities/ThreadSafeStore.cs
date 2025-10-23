using System;
using System.Collections.Concurrent;
using System.Runtime.CompilerServices;

namespace Newtonsoft.Json.Utilities
{
	// Token: 0x020000F3 RID: 243
	[NullableContext(1)]
	[Nullable(0)]
	internal class ThreadSafeStore<TKey, [Nullable(2)] TValue>
	{
		// Token: 0x0600071F RID: 1823 RVA: 0x00024727 File Offset: 0x00022927
		public ThreadSafeStore(Func<TKey, TValue> creator)
		{
			ValidationUtils.ArgumentNotNull(creator, "creator");
			this._creator = creator;
			this._concurrentStore = new ConcurrentDictionary<TKey, TValue>();
		}

		// Token: 0x06000720 RID: 1824 RVA: 0x0002474C File Offset: 0x0002294C
		public TValue Get(TKey key)
		{
			return this._concurrentStore.GetOrAdd(key, this._creator);
		}

		// Token: 0x040004D6 RID: 1238
		private readonly ConcurrentDictionary<TKey, TValue> _concurrentStore;

		// Token: 0x040004D7 RID: 1239
		private readonly Func<TKey, TValue> _creator;
	}
}
