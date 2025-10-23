using System;
using System.Collections.Concurrent;

namespace System.Runtime.Serialization
{
	// Token: 0x0200039D RID: 925
	internal static class SerializationEventsCache
	{
		// Token: 0x06001CA5 RID: 7333 RVA: 0x00079574 File Offset: 0x00077774
		internal static SerializationEvents GetSerializationEventsForType(Type t)
		{
			return SerializationEventsCache.s_cache.GetOrAdd(t, (Type type) => new SerializationEvents(type));
		}

		// Token: 0x04000BFF RID: 3071
		private static readonly ConcurrentDictionary<Type, SerializationEvents> s_cache = new ConcurrentDictionary<Type, SerializationEvents>();
	}
}
