using System;
using System.Collections.Generic;
using Java.Interop;

namespace Android.Runtime
{
	// Token: 0x020002C1 RID: 705
	internal class IdentityHashTargets
	{
		// Token: 0x06001AE0 RID: 6880 RVA: 0x0004632F File Offset: 0x0004452F
		public static WeakReference<IJavaPeerable> CreateWeakReference(IJavaPeerable value)
		{
			return new WeakReference<IJavaPeerable>(value, true);
		}

		// Token: 0x06001AE1 RID: 6881 RVA: 0x00046338 File Offset: 0x00044538
		public IdentityHashTargets(IJavaPeerable value)
		{
			this.first = IdentityHashTargets.CreateWeakReference(value);
		}

		// Token: 0x170005C0 RID: 1472
		// (get) Token: 0x06001AE2 RID: 6882 RVA: 0x0004634C File Offset: 0x0004454C
		public int Count
		{
			get
			{
				return ((this.first != null) ? 1 : 0) + ((this.rest != null) ? this.rest.Count : 0);
			}
		}

		// Token: 0x170005C1 RID: 1473
		public WeakReference<IJavaPeerable> this[int index]
		{
			get
			{
				if (index == 0)
				{
					return this.first;
				}
				index--;
				if (this.rest == null || index >= this.rest.Count)
				{
					return null;
				}
				return this.rest[index];
			}
			set
			{
				if (index == 0)
				{
					this.first = value;
					return;
				}
				index--;
				if (this.rest != null)
				{
					this.rest[index] = value;
				}
			}
		}

		// Token: 0x06001AE5 RID: 6885 RVA: 0x000463CD File Offset: 0x000445CD
		public void Add(IJavaPeerable value)
		{
			if (this.first == null)
			{
				this.first = IdentityHashTargets.CreateWeakReference(value);
				return;
			}
			if (this.rest == null)
			{
				this.rest = new List<WeakReference<IJavaPeerable>>();
			}
			this.rest.Add(IdentityHashTargets.CreateWeakReference(value));
		}

		// Token: 0x06001AE6 RID: 6886 RVA: 0x00046408 File Offset: 0x00044608
		public void RemoveAt(int index)
		{
			if (index == 0)
			{
				this.first = null;
				List<WeakReference<IJavaPeerable>> list = this.rest;
				if (list != null && list.Count > 0)
				{
					this.first = this.rest[0];
					this.rest.RemoveAt(0);
				}
				return;
			}
			index--;
			List<WeakReference<IJavaPeerable>> list2 = this.rest;
			if (list2 == null)
			{
				return;
			}
			list2.RemoveAt(index);
		}

		// Token: 0x04000B7A RID: 2938
		private WeakReference<IJavaPeerable> first;

		// Token: 0x04000B7B RID: 2939
		private List<WeakReference<IJavaPeerable>> rest;
	}
}
