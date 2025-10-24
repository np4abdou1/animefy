using System;

namespace System.Runtime.Serialization
{
	// Token: 0x020003A8 RID: 936
	[Serializable]
	internal class FixupHolderList
	{
		// Token: 0x06001D18 RID: 7448 RVA: 0x0007B7DF File Offset: 0x000799DF
		internal FixupHolderList() : this(2)
		{
		}

		// Token: 0x06001D19 RID: 7449 RVA: 0x0007B7E8 File Offset: 0x000799E8
		internal FixupHolderList(int startingSize)
		{
			this.m_count = 0;
			this.m_values = new FixupHolder[startingSize];
		}

		// Token: 0x06001D1A RID: 7450 RVA: 0x0007B804 File Offset: 0x00079A04
		internal virtual void Add(FixupHolder fixup)
		{
			if (this.m_count == this.m_values.Length)
			{
				this.EnlargeArray();
			}
			FixupHolder[] values = this.m_values;
			int count = this.m_count;
			this.m_count = count + 1;
			values[count] = fixup;
		}

		// Token: 0x06001D1B RID: 7451 RVA: 0x0007B840 File Offset: 0x00079A40
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
			FixupHolder[] array = new FixupHolder[num];
			Array.Copy(this.m_values, array, this.m_count);
			this.m_values = array;
		}

		// Token: 0x04000C2C RID: 3116
		internal FixupHolder[] m_values;

		// Token: 0x04000C2D RID: 3117
		internal int m_count;
	}
}
