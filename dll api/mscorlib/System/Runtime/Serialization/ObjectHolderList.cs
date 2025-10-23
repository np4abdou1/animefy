using System;

namespace System.Runtime.Serialization
{
	// Token: 0x020003AA RID: 938
	internal class ObjectHolderList
	{
		// Token: 0x06001D25 RID: 7461 RVA: 0x0007BA16 File Offset: 0x00079C16
		internal ObjectHolderList() : this(8)
		{
		}

		// Token: 0x06001D26 RID: 7462 RVA: 0x0007BA1F File Offset: 0x00079C1F
		internal ObjectHolderList(int startingSize)
		{
			this.m_count = 0;
			this.m_values = new ObjectHolder[startingSize];
		}

		// Token: 0x06001D27 RID: 7463 RVA: 0x0007BA3C File Offset: 0x00079C3C
		internal virtual void Add(ObjectHolder value)
		{
			if (this.m_count == this.m_values.Length)
			{
				this.EnlargeArray();
			}
			ObjectHolder[] values = this.m_values;
			int count = this.m_count;
			this.m_count = count + 1;
			values[count] = value;
		}

		// Token: 0x06001D28 RID: 7464 RVA: 0x0007BA78 File Offset: 0x00079C78
		internal ObjectHolderListEnumerator GetFixupEnumerator()
		{
			return new ObjectHolderListEnumerator(this, true);
		}

		// Token: 0x06001D29 RID: 7465 RVA: 0x0007BA84 File Offset: 0x00079C84
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
			ObjectHolder[] array = new ObjectHolder[num];
			Array.Copy(this.m_values, array, this.m_count);
			this.m_values = array;
		}

		// Token: 0x170003BD RID: 957
		// (get) Token: 0x06001D2A RID: 7466 RVA: 0x0007BADE File Offset: 0x00079CDE
		internal int Version
		{
			get
			{
				return this.m_count;
			}
		}

		// Token: 0x170003BE RID: 958
		// (get) Token: 0x06001D2B RID: 7467 RVA: 0x0007BADE File Offset: 0x00079CDE
		internal int Count
		{
			get
			{
				return this.m_count;
			}
		}

		// Token: 0x04000C32 RID: 3122
		internal ObjectHolder[] m_values;

		// Token: 0x04000C33 RID: 3123
		internal int m_count;
	}
}
