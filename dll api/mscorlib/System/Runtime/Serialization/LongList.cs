using System;

namespace System.Runtime.Serialization
{
	// Token: 0x020003A9 RID: 937
	[Serializable]
	internal class LongList
	{
		// Token: 0x06001D1C RID: 7452 RVA: 0x0007B89A File Offset: 0x00079A9A
		internal LongList() : this(2)
		{
		}

		// Token: 0x06001D1D RID: 7453 RVA: 0x0007B8A3 File Offset: 0x00079AA3
		internal LongList(int startingSize)
		{
			this.m_count = 0;
			this.m_totalItems = 0;
			this.m_values = new long[startingSize];
		}

		// Token: 0x06001D1E RID: 7454 RVA: 0x0007B8C8 File Offset: 0x00079AC8
		internal void Add(long value)
		{
			if (this.m_totalItems == this.m_values.Length)
			{
				this.EnlargeArray();
			}
			long[] values = this.m_values;
			int totalItems = this.m_totalItems;
			this.m_totalItems = totalItems + 1;
			values[totalItems] = value;
			this.m_count++;
		}

		// Token: 0x170003BB RID: 955
		// (get) Token: 0x06001D1F RID: 7455 RVA: 0x0007B912 File Offset: 0x00079B12
		internal int Count
		{
			get
			{
				return this.m_count;
			}
		}

		// Token: 0x06001D20 RID: 7456 RVA: 0x0007B91A File Offset: 0x00079B1A
		internal void StartEnumeration()
		{
			this.m_currentItem = -1;
		}

		// Token: 0x06001D21 RID: 7457 RVA: 0x0007B924 File Offset: 0x00079B24
		internal bool MoveNext()
		{
			int num;
			do
			{
				num = this.m_currentItem + 1;
				this.m_currentItem = num;
			}
			while (num < this.m_totalItems && this.m_values[this.m_currentItem] == -1L);
			return this.m_currentItem != this.m_totalItems;
		}

		// Token: 0x170003BC RID: 956
		// (get) Token: 0x06001D22 RID: 7458 RVA: 0x0007B96C File Offset: 0x00079B6C
		internal long Current
		{
			get
			{
				return this.m_values[this.m_currentItem];
			}
		}

		// Token: 0x06001D23 RID: 7459 RVA: 0x0007B97C File Offset: 0x00079B7C
		internal bool RemoveElement(long value)
		{
			int num = 0;
			while (num < this.m_totalItems && this.m_values[num] != value)
			{
				num++;
			}
			if (num == this.m_totalItems)
			{
				return false;
			}
			this.m_values[num] = -1L;
			return true;
		}

		// Token: 0x06001D24 RID: 7460 RVA: 0x0007B9BC File Offset: 0x00079BBC
		private void EnlargeArray()
		{
			int num = this.m_values.Length * 2;
			if (num < 0)
			{
				if (num == 2147483647)
				{
					throw new SerializationException(Environment.GetResourceString("The internal array cannot expand to greater than Int32.MaxValue elements."));
				}
				num = int.MaxValue;
			}
			long[] array = new long[num];
			Array.Copy(this.m_values, array, this.m_count);
			this.m_values = array;
		}

		// Token: 0x04000C2E RID: 3118
		private long[] m_values;

		// Token: 0x04000C2F RID: 3119
		private int m_count;

		// Token: 0x04000C30 RID: 3120
		private int m_totalItems;

		// Token: 0x04000C31 RID: 3121
		private int m_currentItem;
	}
}
