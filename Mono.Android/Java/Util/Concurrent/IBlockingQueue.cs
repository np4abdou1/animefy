using System;
using System.Collections;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Java.Util.Concurrent
{
	// Token: 0x02000345 RID: 837
	[Register("java/util/concurrent/BlockingQueue", "", "Java.Util.Concurrent.IBlockingQueueInvoker")]
	[JavaTypeParameters(new string[]
	{
		"E"
	})]
	public interface IBlockingQueue : IQueue, ICollection, IIterable, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x06002411 RID: 9233
		bool Add(Java.Lang.Object e);

		// Token: 0x06002412 RID: 9234
		bool Contains(Java.Lang.Object o);

		// Token: 0x06002413 RID: 9235
		int DrainTo(ICollection c);

		// Token: 0x06002414 RID: 9236
		int DrainTo(ICollection c, int maxElements);

		// Token: 0x06002415 RID: 9237
		bool Offer(Java.Lang.Object e);

		// Token: 0x06002416 RID: 9238
		bool Offer(Java.Lang.Object e, long timeout, TimeUnit unit);

		// Token: 0x06002417 RID: 9239
		Java.Lang.Object Poll(long timeout, TimeUnit unit);

		// Token: 0x06002418 RID: 9240
		void Put(Java.Lang.Object e);

		// Token: 0x06002419 RID: 9241
		int RemainingCapacity();

		// Token: 0x0600241A RID: 9242
		bool Remove(Java.Lang.Object o);

		// Token: 0x0600241B RID: 9243
		Java.Lang.Object Take();
	}
}
