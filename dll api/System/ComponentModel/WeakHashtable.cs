using System;
using System.Collections;

namespace System.ComponentModel
{
	// Token: 0x020002B3 RID: 691
	internal sealed class WeakHashtable : Hashtable
	{
		// Token: 0x0600128D RID: 4749 RVA: 0x000592D4 File Offset: 0x000574D4
		internal WeakHashtable() : base(WeakHashtable._comparer)
		{
		}

		// Token: 0x0600128E RID: 4750 RVA: 0x000592E1 File Offset: 0x000574E1
		public override void Clear()
		{
			base.Clear();
		}

		// Token: 0x0600128F RID: 4751 RVA: 0x000592E9 File Offset: 0x000574E9
		public override void Remove(object key)
		{
			base.Remove(key);
		}

		// Token: 0x04000D0A RID: 3338
		private static IEqualityComparer _comparer = new WeakHashtable.WeakKeyComparer();

		// Token: 0x020002B4 RID: 692
		private class WeakKeyComparer : IEqualityComparer
		{
			// Token: 0x06001291 RID: 4753 RVA: 0x00059300 File Offset: 0x00057500
			bool IEqualityComparer.Equals(object x, object y)
			{
				if (x == null)
				{
					return y == null;
				}
				if (y != null && x.GetHashCode() == y.GetHashCode())
				{
					WeakReference weakReference = x as WeakReference;
					WeakReference weakReference2 = y as WeakReference;
					if (weakReference != null)
					{
						if (!weakReference.IsAlive)
						{
							return false;
						}
						x = weakReference.Target;
					}
					if (weakReference2 != null)
					{
						if (!weakReference2.IsAlive)
						{
							return false;
						}
						y = weakReference2.Target;
					}
					return x == y;
				}
				return false;
			}

			// Token: 0x06001292 RID: 4754 RVA: 0x00059364 File Offset: 0x00057564
			int IEqualityComparer.GetHashCode(object obj)
			{
				return obj.GetHashCode();
			}
		}
	}
}
