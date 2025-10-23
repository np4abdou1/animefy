using System;
using Android.Runtime;
using Java.Interop;
using Java.Lang;

namespace Java.Util
{
	// Token: 0x02000316 RID: 790
	[Register("java/util/NavigableSet", "", "Java.Util.INavigableSetInvoker")]
	[JavaTypeParameters(new string[]
	{
		"E"
	})]
	public interface INavigableSet : ISortedSet, ISet, ICollection, IIterable, IJavaObject, IDisposable, IJavaPeerable
	{
		// Token: 0x060020EC RID: 8428
		Java.Lang.Object Ceiling(Java.Lang.Object e);

		// Token: 0x060020ED RID: 8429
		IIterator DescendingIterator();

		// Token: 0x060020EE RID: 8430
		INavigableSet DescendingSet();

		// Token: 0x060020EF RID: 8431
		Java.Lang.Object Floor(Java.Lang.Object e);

		// Token: 0x060020F0 RID: 8432
		ISortedSet HeadSet(Java.Lang.Object toElement);

		// Token: 0x060020F1 RID: 8433
		INavigableSet HeadSet(Java.Lang.Object toElement, bool inclusive);

		// Token: 0x060020F2 RID: 8434
		Java.Lang.Object Higher(Java.Lang.Object e);

		// Token: 0x060020F3 RID: 8435
		IIterator Iterator();

		// Token: 0x060020F4 RID: 8436
		Java.Lang.Object Lower(Java.Lang.Object e);

		// Token: 0x060020F5 RID: 8437
		Java.Lang.Object PollFirst();

		// Token: 0x060020F6 RID: 8438
		Java.Lang.Object PollLast();

		// Token: 0x060020F7 RID: 8439
		INavigableSet SubSet(Java.Lang.Object fromElement, bool fromInclusive, Java.Lang.Object toElement, bool toInclusive);

		// Token: 0x060020F8 RID: 8440
		ISortedSet SubSet(Java.Lang.Object fromElement, Java.Lang.Object toElement);

		// Token: 0x060020F9 RID: 8441
		ISortedSet TailSet(Java.Lang.Object fromElement);

		// Token: 0x060020FA RID: 8442
		INavigableSet TailSet(Java.Lang.Object fromElement, bool inclusive);
	}
}
