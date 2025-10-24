using System;

namespace System.Collections.Generic
{
	// Token: 0x0200014B RID: 331
	internal struct SparseArrayBuilder<T>
	{
		// Token: 0x06000A7A RID: 2682 RVA: 0x00027088 File Offset: 0x00025288
		public SparseArrayBuilder(bool initialize)
		{
			this = default(SparseArrayBuilder<T>);
			this._builder = new LargeArrayBuilder<T>(true);
		}

		// Token: 0x170001CB RID: 459
		// (get) Token: 0x06000A7B RID: 2683 RVA: 0x0002709D File Offset: 0x0002529D
		public int Count
		{
			get
			{
				return checked(this._builder.Count + this._reservedCount);
			}
		}

		// Token: 0x170001CC RID: 460
		// (get) Token: 0x06000A7C RID: 2684 RVA: 0x000270B1 File Offset: 0x000252B1
		public ArrayBuilder<Marker> Markers
		{
			get
			{
				return this._markers;
			}
		}

		// Token: 0x06000A7D RID: 2685 RVA: 0x000270B9 File Offset: 0x000252B9
		public void AddRange(IEnumerable<T> items)
		{
			this._builder.AddRange(items);
		}

		// Token: 0x06000A7E RID: 2686 RVA: 0x000270C8 File Offset: 0x000252C8
		public void CopyTo(T[] array, int arrayIndex, int count)
		{
			int num = 0;
			CopyPosition position = CopyPosition.Start;
			for (int i = 0; i < this._markers.Count; i++)
			{
				Marker marker = this._markers[i];
				int num2 = Math.Min(marker.Index - num, count);
				if (num2 > 0)
				{
					position = this._builder.CopyTo(position, array, arrayIndex, num2);
					arrayIndex += num2;
					num += num2;
					count -= num2;
				}
				if (count == 0)
				{
					return;
				}
				int num3 = Math.Min(marker.Count, count);
				arrayIndex += num3;
				num += num3;
				count -= num3;
			}
			if (count > 0)
			{
				this._builder.CopyTo(position, array, arrayIndex, count);
			}
		}

		// Token: 0x06000A7F RID: 2687 RVA: 0x00027170 File Offset: 0x00025370
		public void Reserve(int count)
		{
			this._markers.Add(new Marker(count, this.Count));
			checked
			{
				this._reservedCount += count;
			}
		}

		// Token: 0x06000A80 RID: 2688 RVA: 0x00027198 File Offset: 0x00025398
		public bool ReserveOrAdd(IEnumerable<T> items)
		{
			int num;
			if (EnumerableHelpers.TryGetCount<T>(items, out num))
			{
				if (num > 0)
				{
					this.Reserve(num);
					return true;
				}
			}
			else
			{
				this.AddRange(items);
			}
			return false;
		}

		// Token: 0x06000A81 RID: 2689 RVA: 0x000271C4 File Offset: 0x000253C4
		public T[] ToArray()
		{
			if (this._markers.Count == 0)
			{
				return this._builder.ToArray();
			}
			T[] array = new T[this.Count];
			this.CopyTo(array, 0, array.Length);
			return array;
		}

		// Token: 0x0400031A RID: 794
		private LargeArrayBuilder<T> _builder;

		// Token: 0x0400031B RID: 795
		private ArrayBuilder<Marker> _markers;

		// Token: 0x0400031C RID: 796
		private int _reservedCount;
	}
}
