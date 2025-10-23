using System;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Java.Util
{
	// Token: 0x02000318 RID: 792
	[Register("java/util/Queue", "", "Java.Util.IQueueInvoker")]
	[JavaTypeParameters(new string[]
	{
		"E"
	})]
	public interface IQueue : ICollection, IIterable, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x06002141 RID: 8513
		bool Add(Java.Lang.Object e);

		// Token: 0x06002142 RID: 8514
		Java.Lang.Object Element();

		// Token: 0x06002143 RID: 8515
		bool Offer(Java.Lang.Object e);

		// Token: 0x06002144 RID: 8516
		Java.Lang.Object Peek();

		// Token: 0x06002145 RID: 8517
		Java.Lang.Object Poll();

		// Token: 0x06002146 RID: 8518
		Java.Lang.Object Remove();
	}
}
