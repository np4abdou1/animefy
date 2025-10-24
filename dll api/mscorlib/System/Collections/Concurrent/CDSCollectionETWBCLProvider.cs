using System;
using System.Diagnostics.Tracing;

namespace System.Collections.Concurrent
{
	// Token: 0x020005FD RID: 1533
	[EventSource(Name = "System.Collections.Concurrent.ConcurrentCollectionsEventSource", Guid = "35167F8E-49B2-4b96-AB86-435B59336B5E")]
	internal sealed class CDSCollectionETWBCLProvider : EventSource
	{
		// Token: 0x06002E47 RID: 11847 RVA: 0x000BD455 File Offset: 0x000BB655
		private CDSCollectionETWBCLProvider()
		{
		}

		// Token: 0x06002E48 RID: 11848 RVA: 0x000BD45D File Offset: 0x000BB65D
		[Event(3, Level = EventLevel.Warning)]
		public void ConcurrentDictionary_AcquiringAllLocks(int numOfBuckets)
		{
			if (base.IsEnabled(EventLevel.Warning, EventKeywords.All))
			{
				base.WriteEvent(3, numOfBuckets);
			}
		}

		// Token: 0x040018C5 RID: 6341
		public static CDSCollectionETWBCLProvider Log = new CDSCollectionETWBCLProvider();
	}
}
