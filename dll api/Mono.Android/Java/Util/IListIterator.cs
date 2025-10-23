using System;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Java.Util
{
	// Token: 0x02000310 RID: 784
	[Register("java/util/ListIterator", "", "Java.Util.IListIteratorInvoker")]
	[JavaTypeParameters(new string[]
	{
		"E"
	})]
	public interface IListIterator : IIterator, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x17000658 RID: 1624
		// (get) Token: 0x0600202F RID: 8239
		bool HasNext { get; }

		// Token: 0x17000659 RID: 1625
		// (get) Token: 0x06002030 RID: 8240
		bool HasPrevious { get; }

		// Token: 0x06002031 RID: 8241
		void Add(Java.Lang.Object e);

		// Token: 0x06002032 RID: 8242
		Java.Lang.Object Next();

		// Token: 0x06002033 RID: 8243
		int NextIndex();

		// Token: 0x06002034 RID: 8244
		Java.Lang.Object Previous();

		// Token: 0x06002035 RID: 8245
		int PreviousIndex();

		// Token: 0x06002036 RID: 8246
		void Remove();

		// Token: 0x06002037 RID: 8247
		void Set(Java.Lang.Object e);
	}
}
